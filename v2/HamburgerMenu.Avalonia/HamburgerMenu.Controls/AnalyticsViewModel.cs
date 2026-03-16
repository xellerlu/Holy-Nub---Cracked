using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;
using Avalonia.Threading;
using HamburgerMenu.Services;

namespace HamburgerMenu.Controls;

public class AnalyticsViewModel : INotifyPropertyChanged
{
	private CancellationTokenSource? _cts;

	private string _statusText = "Готов к сканированию";

	private int _resultCount;

	private bool _isScanning;

	private bool _showScanOptions;

	private bool _canExport;

	private readonly HashSet<string> _scannedPaths = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

	public ObservableCollection<CheatScanResult> Results { get; } = new ObservableCollection<CheatScanResult>();

	public string StatusText
	{
		get
		{
			return _statusText;
		}
		set
		{
			_statusText = value;
			OnPropertyChanged("StatusText");
		}
	}

	public int ResultCount
	{
		get
		{
			return _resultCount;
		}
		set
		{
			_resultCount = value;
			OnPropertyChanged("ResultCount");
		}
	}

	public bool IsScanning
	{
		get
		{
			return _isScanning;
		}
		set
		{
			_isScanning = value;
			OnPropertyChanged("IsScanning");
		}
	}

	public bool ShowScanOptions
	{
		get
		{
			return _showScanOptions;
		}
		set
		{
			_showScanOptions = value;
			OnPropertyChanged("ShowScanOptions");
		}
	}

	public bool CanExport
	{
		get
		{
			return _canExport;
		}
		set
		{
			_canExport = value;
			OnPropertyChanged("CanExport");
		}
	}

	public ICommand ShowScanOptionsCommand { get; }

	public ICommand HideScanOptionsCommand { get; }

	public ICommand FullScanCommand { get; }

	public ICommand QuickScanCommand { get; }

	public ICommand CancelScanCommand { get; }

	public ICommand ExportLogCommand { get; }

	public event PropertyChangedEventHandler? PropertyChanged;

	public AnalyticsViewModel()
	{
		ShowScanOptionsCommand = new RelayCommand(delegate
		{
			ShowScanOptions = true;
		});
		HideScanOptionsCommand = new RelayCommand(delegate
		{
			ShowScanOptions = false;
		});
		FullScanCommand = new RelayCommand(delegate(object? _)
		{
			_ = FullScanAsync();
		});
		QuickScanCommand = new RelayCommand(delegate(object? _)
		{
			_ = QuickScanAsync();
		});
		CancelScanCommand = new RelayCommand(delegate
		{
			CancelScan();
		});
		ExportLogCommand = new RelayCommand(delegate
		{
			ExportLog();
		});
	}

	private void ExportLog()
	{
		if (Results.Count == 0)
		{
			return;
		}
		try
		{
			string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
			string text = $"CheatScan_{DateTime.Now:yyyy-MM-dd_HH-mm-ss}.txt";
			using StreamWriter streamWriter = new StreamWriter(Path.Combine(folderPath, text));
			streamWriter.WriteLine("=== CHEAT SCAN REPORT ===");
			streamWriter.WriteLine($"Date: {DateTime.Now:yyyy-MM-dd HH:mm:ss}");
			streamWriter.WriteLine($"Total Found: {Results.Count}");
			streamWriter.WriteLine(new string('=', 50));
			streamWriter.WriteLine();
			foreach (CheatScanResult result in Results)
			{
				streamWriter.WriteLine($"[{result.DetectionType}] {result.CheatName} ({result.Confidence}%)");
				streamWriter.WriteLine("  File: " + result.FileName);
				streamWriter.WriteLine("  Path: " + result.FilePath);
				streamWriter.WriteLine();
			}
			StatusText = "✓ Лог сохранён: " + text;
		}
		catch (Exception ex)
		{
			StatusText = "Ошибка экспорта: " + ex.Message;
		}
	}

	private void CancelScan()
	{
		_cts?.Cancel();
		StatusText = "Сканирование отменено";
		IsScanning = false;
	}

	private async Task FullScanAsync()
	{
		_cts = new CancellationTokenSource();
		Results.Clear();
		ResultCount = 0;
		IsScanning = true;
		_scannedPaths.Clear();
		List<Task> list = new List<Task>();
		StatusText = "Проверка DNS кэша...";
		list.Add(Task.Run(async delegate
		{
			foreach (CheatScanResult result in await CheatScanner.CheckDnsCacheAsync())
			{
				await Dispatcher.UIThread.InvokeAsync(delegate
				{
					Results.Add(result);
					ResultCount = Results.Count;
				});
			}
		}));
		StatusText = "Проверка Steam...";
		list.Add(Task.Run(async delegate
		{
			foreach (CheatScanResult result in await CheatScanner.CheckSteamUserdataAsync(new Progress<string>(delegate(string s)
			{
				Dispatcher.UIThread.Post(delegate
				{
					StatusText = s;
				});
			})))
			{
				await Dispatcher.UIThread.InvokeAsync(delegate
				{
					Results.Add(result);
					ResultCount = Results.Count;
				});
			}
		}));
		DriveInfo[] drives = DriveInfo.GetDrives();
		foreach (DriveInfo driveInfo in drives)
		{
			if (driveInfo.IsReady && (driveInfo.DriveType == DriveType.Fixed || driveInfo.DriveType == DriveType.Removable))
			{
				string fullName = driveInfo.RootDirectory.FullName;
				string driveType = ((driveInfo.DriveType == DriveType.Removable) ? "USB" : "HDD");
				list.Add(ScanDriveAsync(fullName, driveType, _cts.Token));
			}
		}
		try
		{
			await Task.WhenAll(list);
		}
		catch (OperationCanceledException)
		{
		}
		IsScanning = false;
		CanExport = ResultCount > 0;
		StatusText = ((ResultCount > 0) ? $"✓ Найдено: {ResultCount} подозрительных файлов" : "✓ Читы не найдены");
	}

	private async Task QuickScanAsync()
	{
		_cts = new CancellationTokenSource();
		Results.Clear();
		ResultCount = 0;
		IsScanning = true;
		_scannedPaths.Clear();
		string text = Path.GetPathRoot(Environment.SystemDirectory) ?? "C:\\";
		StatusText = "Быстрое сканирование " + text + "...";
		try
		{
			await ScanDriveAsync(text, "System", _cts.Token);
		}
		catch (OperationCanceledException)
		{
		}
		IsScanning = false;
		CanExport = ResultCount > 0;
		StatusText = ((ResultCount > 0) ? $"✓ Найдено: {ResultCount} подозрительных файлов" : "✓ Читы не найдены");
	}

	private async Task ScanDriveAsync(string drivePath, string driveType, CancellationToken ct)
	{
		List<string> list = new List<string>();
		if (driveType == "USB")
		{
			list.Add(drivePath);
		}
		else
		{
			string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
			string folderPath2 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
			string folderPath3 = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
			list.AddRange(new string[10]
			{
				Path.Combine(folderPath, "Downloads"),
				Path.Combine(folderPath, "Desktop"),
				Path.Combine(folderPath, "Documents"),
				folderPath2,
				folderPath3,
				Path.Combine(folderPath3, "Temp"),
				Path.Combine(drivePath, "Windows", "Prefetch"),
				Path.Combine(drivePath, "Games"),
				Path.Combine(drivePath, "Program Files"),
				Path.Combine(drivePath, "Program Files (x86)")
			});
			try
			{
				string[] directories = Directory.GetDirectories(drivePath);
				HashSet<string> hashSet = new HashSet<string>(StringComparer.OrdinalIgnoreCase) { "Windows", "$Recycle.Bin", "System Volume Information", "Recovery", "MSOCache" };
				string[] array = directories;
				foreach (string text in array)
				{
					string fileName = Path.GetFileName(text);
					if (!hashSet.Contains(fileName) && !fileName.StartsWith("$"))
					{
						list.Add(text);
					}
				}
			}
			catch
			{
			}
		}
		List<Task> list2 = new List<Task>();
		foreach (string item in list)
		{
			if (Directory.Exists(item))
			{
				list2.Add(ScanPathAsync(item, ct));
			}
		}
		await Task.WhenAll(list2);
	}

	private async Task ScanPathAsync(string path, CancellationToken ct)
	{
		lock (_scannedPaths)
		{
			if (_scannedPaths.Contains(path))
			{
				return;
			}
			_scannedPaths.Add(path);
		}
		try
		{
			foreach (CheatScanResult result in await CheatScanner.ScanDirectoryAsync(path, new Progress<string>(delegate(string s)
			{
				Dispatcher.UIThread.Post(delegate
				{
					StatusText = s;
				});
			}), ct))
			{
				await Dispatcher.UIThread.InvokeAsync(delegate
				{
					if (!Results.Any((CheatScanResult r) => r.FilePath.Equals(result.FilePath, StringComparison.OrdinalIgnoreCase)))
					{
						Results.Add(result);
						ResultCount = Results.Count;
					}
				});
			}
		}
		catch
		{
		}
	}

	protected void OnPropertyChanged([CallerMemberName] string? name = null)
	{
		this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
	}
}
