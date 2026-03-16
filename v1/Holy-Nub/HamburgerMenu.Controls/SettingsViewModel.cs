using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Avalonia.Media;
using Microsoft.Win32;

namespace HamburgerMenu.Controls;

public class SettingsViewModel : INotifyPropertyChanged
{
	public string WindowsVersion { get; }

	public string WindowsInstallDate { get; }

	public string VmStatus { get; }

	public IBrush VmStatusColor { get; }

	public string GpuName { get; }

	public bool IsNvidiaGpu { get; }

	public ICommand OpenDataUsageCommand { get; }

	public ICommand OpenNvidiaControlPanelCommand { get; }

	public event PropertyChangedEventHandler? PropertyChanged;

	public SettingsViewModel()
	{
		WindowsVersion = GetWindowsVersion();
		WindowsInstallDate = GetWindowsInstallDate();
		(string, IBrush) tuple = DetectVirtualMachine();
		VmStatus = tuple.Item1;
		VmStatusColor = tuple.Item2;
		GpuName = GetGpuName();
		IsNvidiaGpu = GpuName.Contains("NVIDIA", StringComparison.OrdinalIgnoreCase);
		OpenDataUsageCommand = new SettingsRelayCommand(delegate
		{
			OpenDataUsage();
		});
		OpenNvidiaControlPanelCommand = new SettingsRelayCommand(delegate
		{
			OpenNvidiaControlPanel();
		});
	}

	private string GetWindowsVersion()
	{
		try
		{
			using RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion");
			if (registryKey != null)
			{
				string text = registryKey.GetValue("ProductName")?.ToString() ?? "Unknown";
				string value = registryKey.GetValue("DisplayVersion")?.ToString() ?? "";
				string text2 = registryKey.GetValue("CurrentBuildNumber")?.ToString() ?? "";
				if (int.TryParse(text2, out var result) && result >= 22000)
				{
					text = text.Replace("Windows 10", "Windows 11");
				}
				return $"{text} {value} (Build {text2})";
			}
		}
		catch
		{
		}
		return Environment.OSVersion.VersionString;
	}

	private string GetWindowsInstallDate()
	{
		try
		{
			using RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion");
			if (registryKey != null && registryKey.GetValue("InstallDate") is int num)
			{
				return DateTimeOffset.FromUnixTimeSeconds(num).LocalDateTime.ToString("dd.MM.yyyy HH:mm");
			}
		}
		catch
		{
		}
		return "Unknown";
	}

	private (string status, IBrush color) DetectVirtualMachine()
	{
		try
		{
			string[] array = new string[9] { "VMware", "VirtualBox", "Virtual", "VBOX", "QEMU", "Hyper-V", "Xen", "KVM", "Parallels" };
			using ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_BIOS");
			foreach (ManagementBaseObject item in managementObjectSearcher.Get())
			{
				string text = item["Manufacturer"]?.ToString() ?? "";
				string text2 = item["Version"]?.ToString() ?? "";
				string[] array2 = array;
				foreach (string value in array2)
				{
					if (text.Contains(value, StringComparison.OrdinalIgnoreCase) || text2.Contains(value, StringComparison.OrdinalIgnoreCase))
					{
						return (status: "⚠\ufe0f VM Detected!", color: Brushes.Red);
					}
				}
			}
			using ManagementObjectSearcher managementObjectSearcher2 = new ManagementObjectSearcher("SELECT * FROM Win32_ComputerSystem");
			foreach (ManagementBaseObject item2 in managementObjectSearcher2.Get())
			{
				string text3 = item2["Manufacturer"]?.ToString() ?? "";
				string text4 = item2["Model"]?.ToString() ?? "";
				string[] array2 = array;
				foreach (string value2 in array2)
				{
					if (text3.Contains(value2, StringComparison.OrdinalIgnoreCase) || text4.Contains(value2, StringComparison.OrdinalIgnoreCase))
					{
						return (status: "⚠\ufe0f VM Detected!", color: Brushes.Red);
					}
				}
			}
			return (status: "✓ Physical Machine", color: Brushes.LightGreen);
		}
		catch
		{
			return (status: "Unknown", color: Brushes.Gray);
		}
	}

	private string GetGpuName()
	{
		try
		{
			using ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("SELECT Name FROM Win32_VideoController");
			foreach (ManagementBaseObject item in managementObjectSearcher.Get())
			{
				string text = item["Name"]?.ToString();
				if (!string.IsNullOrEmpty(text))
				{
					return text;
				}
			}
		}
		catch
		{
		}
		return "Unknown";
	}

	private void OpenDataUsage()
	{
		try
		{
			Process.Start(new ProcessStartInfo
			{
				FileName = "ms-settings:datausage",
				UseShellExecute = true
			});
		}
		catch
		{
		}
	}

	private void OpenNvidiaControlPanel()
	{
		string[] array = new string[2] { "C:\\Program Files\\NVIDIA Corporation\\Control Panel Client\\nvcplui.exe", "C:\\Windows\\System32\\nvcplui.exe" };
		foreach (string text in array)
		{
			if (File.Exists(text))
			{
				try
				{
					Process.Start(new ProcessStartInfo
					{
						FileName = text,
						UseShellExecute = true
					});
					return;
				}
				catch
				{
				}
			}
		}
		try
		{
			Process.Start(new ProcessStartInfo
			{
				FileName = "explorer.exe",
				Arguments = "shell:AppsFolder\\NVIDIACorp.NVIDIAControlPanel_56jybvy8sckqj!NVIDIACorp.NVIDIAControlPanel",
				UseShellExecute = true
			});
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
