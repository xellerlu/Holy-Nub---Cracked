using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;

namespace HamburgerMenu.Services;

public static class LaunchGuard
{
	private struct PROCESS_BASIC_INFORMATION
	{
		public nint Reserved1;

		public nint PebBaseAddress;

		public nint Reserved2_0;

		public nint Reserved2_1;

		public nint UniqueProcessId;

		public nint InheritedFromUniqueProcessId;
	}

	private static readonly List<FileStream> _lockedFiles = new List<FileStream>();

	public static bool ValidateLaunch()
	{
		string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
		string tempPath = Path.GetTempPath();
		if (!baseDirectory.StartsWith(tempPath, StringComparison.OrdinalIgnoreCase))
		{
			return false;
		}
		if (!Path.GetFileName(baseDirectory.TrimEnd(Path.DirectorySeparatorChar)).StartsWith(".hm_", StringComparison.OrdinalIgnoreCase))
		{
			return false;
		}
		if (!ValidateParentProcess())
		{
			return false;
		}
		return true;
	}

	private static bool ValidateParentProcess()
	{
		try
		{
			int parentProcessId = GetParentProcessId(Process.GetCurrentProcess().Id);
			if (parentProcessId == 0)
			{
				return false;
			}
			string text = Process.GetProcessById(parentProcessId).ProcessName.ToLower();
			string[] array = new string[5] { "holy-nub", "dotnet", "devenv", "rider64", "code" };
			foreach (string value in array)
			{
				if (text.Contains(value))
				{
					return true;
				}
			}
			return false;
		}
		catch
		{
			return false;
		}
	}

	public static void LockFiles()
	{
		try
		{
			string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
			string[] array = new string[3] { "HamburgerMenu.Avalonia.exe", "HamburgerMenu.Avalonia.dll", "HamburgerMenu.Shared.dll" };
			foreach (string path in array)
			{
				string path2 = Path.Combine(baseDirectory, path);
				if (File.Exists(path2))
				{
					try
					{
						FileStream item = new FileStream(path2, FileMode.Open, FileAccess.Read, FileShare.None);
						_lockedFiles.Add(item);
					}
					catch
					{
					}
				}
			}
		}
		catch
		{
		}
	}

	public static void UnlockFiles()
	{
		foreach (FileStream lockedFile in _lockedFiles)
		{
			try
			{
				lockedFile.Dispose();
			}
			catch
			{
			}
		}
		_lockedFiles.Clear();
	}

	private static int GetParentProcessId(int processId)
	{
		try
		{
			nint num = OpenProcess(1024, bInheritHandle: false, processId);
			if (num == IntPtr.Zero)
			{
				return 0;
			}
			PROCESS_BASIC_INFORMATION processInformation = default(PROCESS_BASIC_INFORMATION);
			int returnLength;
			int num2 = NtQueryInformationProcess(num, 0, ref processInformation, Marshal.SizeOf(processInformation), out returnLength);
			CloseHandle(num);
			if (num2 != 0)
			{
				return 0;
			}
			return ((IntPtr)processInformation.InheritedFromUniqueProcessId).ToInt32();
		}
		catch
		{
			return 0;
		}
	}

	[DllImport("kernel32.dll")]
	private static extern nint OpenProcess(int dwDesiredAccess, bool bInheritHandle, int dwProcessId);

	[DllImport("kernel32.dll")]
	private static extern bool CloseHandle(nint hObject);

	[DllImport("ntdll.dll")]
	private static extern int NtQueryInformationProcess(nint processHandle, int processInformationClass, ref PROCESS_BASIC_INFORMATION processInformation, int processInformationLength, out int returnLength);
}
