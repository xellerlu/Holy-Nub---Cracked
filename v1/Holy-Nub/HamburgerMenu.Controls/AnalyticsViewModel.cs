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
		ShowScanOptions = false;
		_scannedPaths.Clear();
		try
		{
			StatusText = "\ud83d\udd0d Проверка DNS кэша...";
			await Task.Delay(100);
			try
			{
				List<CheatScanResult> list = await CheatScanner.CheckDnsCacheAsync();
				foreach (CheatScanResult item in list)
				{
					Results.Add(item);
					ResultCount = Results.Count;
				}
				StatusText = $"DNS: найдено {list.Count}";
				await Task.Delay(500);
			}
			catch (Exception ex)
			{
				StatusText = "DNS ошибка: " + ex.Message;
			}
			StatusText = "\ud83d\udd0d Проверка Steam...";
			await Task.Delay(100);
			try
			{
				List<CheatScanResult> list2 = await CheatScanner.CheckSteamUserdataAsync(new Progress<string>(delegate(string s)
				{
					Dispatcher.UIThread.Post(delegate
					{
						StatusText = s;
					});
				}));
				foreach (CheatScanResult item2 in list2)
				{
					Results.Add(item2);
					ResultCount = Results.Count;
				}
				StatusText = $"Steam: найдено {list2.Count}";
				await Task.Delay(500);
			}
			catch (Exception ex2)
			{
				StatusText = "Steam ошибка: " + ex2.Message;
			}
			StatusText = "\ud83d\udd0d Сканирование дисков...";
			await Task.Delay(100);
			DriveInfo[] drives = DriveInfo.GetDrives();
			DriveInfo[] array = drives;
			foreach (DriveInfo driveInfo in array)
			{
				if (!_cts.Token.IsCancellationRequested)
				{
					if (driveInfo.IsReady && (driveInfo.DriveType == DriveType.Fixed || driveInfo.DriveType == DriveType.Removable))
					{
						string fullName = driveInfo.RootDirectory.FullName;
						string driveType = ((driveInfo.DriveType == DriveType.Removable) ? "USB" : "HDD");
						StatusText = "\ud83d\udd0d Сканирование " + fullName + "...";
						await ScanDriveAsync(fullName, driveType, _cts.Token);
					}
					continue;
				}
				break;
			}
		}
		catch (OperationCanceledException)
		{
			StatusText = "❌ Сканирование отменено";
		}
		catch (Exception ex4)
		{
			StatusText = "❌ Ошибка: " + ex4.Message;
		}
		IsScanning = false;
		CanExport = ResultCount > 0;
		if (!_cts.Token.IsCancellationRequested)
		{
			StatusText = ((ResultCount > 0) ? $"✓ Найдено: {ResultCount} подозрительных файлов" : "✓ Читы не найдены");
		}
	}

	private async Task QuickScanAsync()
	{
		_cts = new CancellationTokenSource();
		Results.Clear();
		ResultCount = 0;
		IsScanning = true;
		ShowScanOptions = false;
		_scannedPaths.Clear();
		try
		{
			string tempPath = Path.GetTempPath();
			StatusText = "⚡ Быстрое сканирование " + tempPath + "...";
			await Task.Delay(100);
			await CheatScanner.ScanDirectoryAsync(tempPath, new Progress<string>(delegate(string s)
			{
				Dispatcher.UIThread.Post(delegate
				{
					StatusText = s;
				});
			}), _cts.Token, delegate(CheatScanResult result)
			{
				Dispatcher.UIThread.Post(delegate
				{
					if (!Results.Any((CheatScanResult r) => r.FilePath.Equals(result.FilePath, StringComparison.OrdinalIgnoreCase)))
					{
						Results.Add(result);
						ResultCount = Results.Count;
					}
				});
			});
			StatusText = $"Добавлено {ResultCount} результатов в UI";
		}
		catch (OperationCanceledException)
		{
			StatusText = "❌ Сканирование отменено";
		}
		catch (Exception ex2)
		{
			StatusText = "❌ Ошибка: " + ex2.Message;
		}
		IsScanning = false;
		CanExport = ResultCount > 0;
		if (!_cts.Token.IsCancellationRequested)
		{
			StatusText = ((ResultCount > 0) ? $"✓ Найдено: {ResultCount} подозрительных файлов" : "✓ Читы не найдены");
		}
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
			string folderPath2 = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
			list.AddRange(new string[5]
			{
				Path.Combine(folderPath, "Downloads"),
				Path.Combine(folderPath, "Desktop"),
				Path.Combine(folderPath, "Documents"),
				Path.Combine(folderPath2, "Temp"),
				Path.Combine(drivePath, "Windows", "Prefetch")
			});
		}
		foreach (string path in list)
		{
			if (ct.IsCancellationRequested)
			{
				break;
			}
			if (Directory.Exists(path))
			{
				await Dispatcher.UIThread.InvokeAsync(delegate
				{
					StatusText = "\ud83d\udcc2 " + Path.GetFileName(path) + "...";
				});
				await ScanPathAsync(path, ct);
			}
		}
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
			await CheatScanner.ScanDirectoryAsync(path, new Progress<string>(delegate(string s)
			{
				Dispatcher.UIThread.Post(delegate
				{
					StatusText = s;
				});
			}), ct, delegate(CheatScanResult result)
			{
				Dispatcher.UIThread.Post(delegate
				{
					if (!Results.Any((CheatScanResult r) => r.FilePath.Equals(result.FilePath, StringComparison.OrdinalIgnoreCase)))
					{
						Results.Add(result);
						ResultCount = Results.Count;
					}
				});
			});
		}
		catch (Exception ex)
		{
			Exception ex2 = ex;
			await Dispatcher.UIThread.InvokeAsync(delegate
			{
				StatusText = "Ошибка сканирования " + Path.GetFileName(path) + ": " + ex2.Message;
			});
		}
	}

	protected void OnPropertyChanged([CallerMemberName] string? name = null)
	{
		this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
	}
}
