using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Threading;
using System.Threading.Tasks;
using HamburgerMenu.Shared.Crypto;

namespace HamburgerMenu.Shared.Services;

public class SecureAppRunner : IDisposable
{
	private string? _tempFolder;

	private Process? _process;

	private readonly List<int> _childProcessIds = new List<int>();

	public event Action<string>? OnStatusChanged;

	public async Task<bool> ExtractAndRunAsync(byte[] encryptedData, string password, string exeName)
	{
		try
		{
			this.OnStatusChanged?.Invoke("Расшифровка...");
			byte[] buffer;
			try
			{
				buffer = AesEncryption.Decrypt(encryptedData, password);
			}
			catch
			{
				this.OnStatusChanged?.Invoke("Ошибка расшифровки");
				return false;
			}
			this.OnStatusChanged?.Invoke("Подготовка...");
			_tempFolder = Path.Combine(Path.GetTempPath(), $".hm_{Guid.NewGuid():N}");
			Directory.CreateDirectory(_tempFolder);
			new DirectoryInfo(_tempFolder).Attributes |= FileAttributes.Hidden;
			using (MemoryStream stream = new MemoryStream(buffer))
			{
				using ZipArchive source = new ZipArchive(stream, ZipArchiveMode.Read);
				source.ExtractToDirectory(_tempFolder);
			}
			string text = Path.Combine(_tempFolder, exeName);
			if (!File.Exists(text))
			{
				string[] files = Directory.GetFiles(_tempFolder, "*.exe", SearchOption.AllDirectories);
				if (files.Length == 0)
				{
					this.OnStatusChanged?.Invoke("Exe файл не найден");
					Cleanup();
					return false;
				}
				text = files[0];
			}
			this.OnStatusChanged?.Invoke("Запуск...");
			_process = new Process
			{
				StartInfo = new ProcessStartInfo
				{
					FileName = text,
					WorkingDirectory = Path.GetDirectoryName(text),
					UseShellExecute = true
				},
				EnableRaisingEvents = true
			};
			_process.Start();
			await Task.Delay(500);
			if (_process.HasExited)
			{
				this.OnStatusChanged?.Invoke($"Процесс завершился с кодом {_process.ExitCode}");
				return false;
			}
			return true;
		}
		catch (Exception ex)
		{
			this.OnStatusChanged?.Invoke("Ошибка: " + ex.Message);
			Cleanup();
			return false;
		}
	}

	public async Task WaitForExitAsync()
	{
		if (_process != null && !_process.HasExited)
		{
			await _process.WaitForExitAsync();
		}
	}

	public void Cleanup()
	{
		try
		{
			_process?.Kill();
			_process?.Dispose();
			_process = null;
		}
		catch
		{
		}
		KillProcessesFromTempFolder();
		for (int i = 0; i < 5; i++)
		{
			try
			{
				if (_tempFolder == null || !Directory.Exists(_tempFolder))
				{
					continue;
				}
				string[] files = Directory.GetFiles(_tempFolder, "*", SearchOption.AllDirectories);
				foreach (string path in files)
				{
					try
					{
						File.SetAttributes(path, FileAttributes.Normal);
					}
					catch
					{
					}
				}
				Directory.Delete(_tempFolder, recursive: true);
				_tempFolder = null;
				break;
			}
			catch
			{
				Thread.Sleep(500);
				KillProcessesFromTempFolder();
			}
		}
	}

	private void KillProcessesFromTempFolder()
	{
		if (_tempFolder == null)
		{
			return;
		}
		try
		{
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				try
				{
					string text = process.MainModule?.FileName;
					if (text != null && text.StartsWith(_tempFolder, StringComparison.OrdinalIgnoreCase))
					{
						process.Kill();
						process.WaitForExit(1000);
					}
				}
				catch
				{
				}
			}
		}
		catch
		{
		}
	}

	public void Dispose()
	{
		Cleanup();
	}
}
