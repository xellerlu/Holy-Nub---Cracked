using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace HamburgerMenu.Services;

public static class CheatScanner
{
	private static readonly HashSet<string> HighConfidenceCheats = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
	{
		"INTERIUM", "Neverlose", "Legendware", "nixware.cc", "PhoenixHack", "OneByteRadar", "EZinjector", "OneByteWall", "Annihilation", "Multihack",
		"ExtrimHack", "RHcheats", "FREEQN", "Pphud", "KlarWare", "Aimware", "Skeet.cc", "gamesense.pub", "SpirtHack", "Fatality.win",
		"OneTap.com", "ev0lve.xyz", "Demonside.us", "ExLoader", "CSGhost", "AIRFLOW", "Primordial", "Angelrose", "ClemExternal", "rawetrip",
		"Apasia_steam", "iLikeFeet", "Nullhooks", "Elysion", "BotLucky", "ProjectAspire", "Aimfuck", "Anyx.gg", "Arbeitsamthook", "Menthol",
		"Zenox", "iXternal", "Reversive.xyz", "Monolith", "KAMIDERE", "ExtrimLoader", "JesterEngine", "MadLoader", "AlisaAlis", "d1gital.pw",
		"SelectFire", "Desolver", "Iniuria", "Zapped.cc", "NinjaWare", "RyzeXTR", "Terrority", "Hydrawebz", "FECURITY", "sharhack",
		"2324_CS2_Wh", "Kaban.exe"
	};

	private static readonly HashSet<string> MediumConfidenceCheats = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
	{
		"Xone", "Midnight", "MUTINY", "VRedux", "ESPDX", "NAIM", "Keter", "Sapphire", "Osiris", "Aqua",
		"Aurora", "luno", "EzCS", "EzGlobal", "Demotion", "Crux", "Wenis", "leito", "Dispose", "BetterGo",
		"Astrox", "Untery", "Victoria", "Doras", "Sector", "Dork", "Maze", "Singlelady", "Mirium", "OXIDE",
		"Azrah", "Alphen", "Euclid", "Coaster"
	};

	private static readonly Regex[] SuspiciousPatterns = new Regex[6]
	{
		new Regex("(?i)(aimbot|wallhack|esp|triggerbot|bhop|bunny\\s*hop)", RegexOptions.Compiled),
		new Regex("(?i)cheat.*\\.(exe|dll)$", RegexOptions.Compiled),
		new Regex("(?i)hack.*\\.(exe|dll)$", RegexOptions.Compiled),
		new Regex("(?i)inject(or)?.*\\.(exe|dll)$", RegexOptions.Compiled),
		new Regex("(?i)(cs2?|csgo|counter.?strike).*hack", RegexOptions.Compiled),
		new Regex("(?i)imgui\\.ini$", RegexOptions.Compiled)
	};

	private static readonly HashSet<string> CheatDomains = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
	{
		"exloader.ru", "exloader.cc", "aimware.net", "gamesense.pub", "skeet.cc", "neverlose.cc", "fatality.win", "onetap.com", "ev0lve.xyz", "nixware.cc",
		"legendware.net", "interium.ooo", "demonside.us", "primordial.agency", "spirthack.me", "iniuria.us", "zapped.cc", "fantasy.cat", "mutiny.pw"
	};

	private static readonly Dictionary<string, string> KnownCheatSignatures = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase) { { "X PROGRAMM LTD", "Xone" } };

	private static readonly Dictionary<string, string> KnownCheatDescriptions = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
	{
		{ "Unified library of best and free in-game modifications", "ExLoader" },
		{ "Extreme Injector", "Extreme Injector" },
		{ "CSGhost-v4.3.1.exe", "CSGhost" },
		{ "loader.exe", "Cheat Loader" }
	};

	private static readonly Dictionary<long, string> KnownCheatSizes = new Dictionary<long, string> { { 24885142L, "ExLoader Installer" } };

	private static readonly HashSet<string> SkipFolders = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
	{
		"Windows", "$Recycle.Bin", "System Volume Information", "node_modules", ".git", ".vs", "obj", "bin", "WindowsApps", "Packages",
		"dotnet", "nuget", "Android", "gradle", "maven", "Recovery", "MSOCache", "Microsoft Visual Studio", "VisualStudio", "repos",
		"SecureAppData", ".system", "NuGetPackages"
	};

	private static readonly HashSet<string> SkipExtensions = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
	{
		".cs", ".vb", ".fs", ".cpp", ".c", ".h", ".hpp", ".cxx", ".java", ".kt",
		".scala", ".groovy", ".py", ".pyw", ".pyx", ".pyd", ".js", ".ts", ".jsx", ".tsx",
		".mjs", ".cjs", ".vue", ".svelte", ".php", ".rb", ".pl", ".pm", ".lua", ".go",
		".rs", ".swift", ".html", ".htm", ".css", ".scss", ".sass", ".less", ".xml", ".xaml",
		".axaml", ".json", ".yaml", ".yml", ".toml", ".sql", ".sh", ".bash", ".ps1", ".psm1",
		".bat", ".cmd", ".md", ".markdown", ".rst", ".tex", ".pdf", ".doc", ".docx", ".sln",
		".csproj", ".vbproj", ".fsproj", ".vcxproj", ".props", ".targets", ".resx", ".resources", ".gitignore", ".gitattributes",
		".editorconfig", ".lock", ".log", ".map", ".min.js", ".min.css", ".png", ".jpg", ".jpeg", ".gif",
		".bmp", ".ico", ".svg", ".webp", ".mp3", ".mp4", ".wav", ".avi", ".mkv", ".mov",
		".zip", ".rar", ".7z", ".tar", ".gz"
	};

	private static readonly HashSet<string> Whitelist = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
	{
		"steam.exe", "steamwebhelper.exe", "GameOverlayUI.exe", "discord.exe", "chrome.exe", "firefox.exe", "msedge.exe", "explorer.exe", "cmd.exe", "powershell.exe",
		"devenv.exe", "code.exe", "rider64.exe", "msbuild.exe", "dotnet.exe", "node.exe", "WindowSpy.ahk", "Ahk2Exe.exe", "install.ahk", "install-ahk2exe.ahk",
		"install-version.ahk", "launcher.ahk", "reload-v1.ahk", "reset-assoc.ahk", "ui-dash.ahk", "ui-editor.ahk", "ui-launcherconfig.ahk", "ui-newscript.ahk", "ui-setup.ahk", "ui-uninstall.ahk",
		"bounce-v1.ahk", "CommandLineToArgs.ahk", "common.ahk", "config.ahk", "createAppShortcut.ahk", "EnableUIAccess.ahk", "GetGitHubReleaseAssetURL.ahk", "HashFile.ahk", "identify_regex.ahk", "identify.ahk",
		"launcher-common.ahk", "ShellRun.ahk", "ui-base.ahk", "Minimal for v2.ahk"
	};

	public static async Task<List<CheatScanResult>> ScanDirectoryAsync(string path, IProgress<string>? progress = null, CancellationToken cancellationToken = default(CancellationToken))
	{
		ConcurrentBag<CheatScanResult> results = new ConcurrentBag<CheatScanResult>();
		if (!Directory.Exists(path))
		{
			return results.ToList();
		}
		await Task.Run(delegate
		{
			try
			{
				IEnumerable<string> source = EnumerateFilesSafe(path);
				ParallelOptions parallelOptions = new ParallelOptions
				{
					MaxDegreeOfParallelism = Environment.ProcessorCount,
					CancellationToken = cancellationToken
				};
				int processed = 0;
				Parallel.ForEach(source, parallelOptions, delegate(string file)
				{
					if (cancellationToken.IsCancellationRequested)
					{
						return;
					}
					try
					{
						if (Interlocked.Increment(ref processed) % 100 == 0)
						{
							progress?.Report($"Проверено: {processed} файлов...");
						}
						CheatScanResult cheatScanResult = ScanFile(file);
						if (cheatScanResult != null && cheatScanResult.Confidence >= 70)
						{
							results.Add(cheatScanResult);
						}
					}
					catch
					{
					}
				});
			}
			catch
			{
			}
		}, cancellationToken);
		return results.OrderByDescending((CheatScanResult r) => r.Confidence).ToList();
	}

	private static IEnumerable<string> EnumerateFilesSafe(string path)
	{
		Stack<string> stack = new Stack<string>();
		stack.Push(path);
		while (stack.Count > 0)
		{
			string dir = stack.Pop();
			string fileName = Path.GetFileName(dir);
			if (SkipFolders.Contains(fileName))
			{
				continue;
			}
			string[] array = Array.Empty<string>();
			try
			{
				array = Directory.GetFiles(dir);
			}
			catch
			{
			}
			string[] array2 = array;
			foreach (string text in array2)
			{
				string extension = Path.GetExtension(text);
				if (!SkipExtensions.Contains(extension))
				{
					yield return text;
				}
			}
			try
			{
				string[] directories = Directory.GetDirectories(dir);
				foreach (string text2 in directories)
				{
					string fileName2 = Path.GetFileName(text2);
					if (!SkipFolders.Contains(fileName2))
					{
						stack.Push(text2);
					}
				}
			}
			catch
			{
			}
		}
	}

	private static CheatScanResult? ScanFile(string filePath)
	{
		string fileName = Path.GetFileName(filePath);
		string extension = Path.GetExtension(filePath);
		if (Whitelist.Contains(fileName))
		{
			return null;
		}
		if (extension.Equals(".ahk", StringComparison.OrdinalIgnoreCase))
		{
			return new CheatScanResult
			{
				FilePath = filePath,
				FileName = fileName,
				DetectionType = "Script",
				CheatName = "AutoHotkey",
				Details = "AutoHotkey скрипт (макросы/автоматизация)",
				FileDate = GetFileDate(filePath),
				Confidence = 80
			};
		}
		if (extension.Equals(".pf", StringComparison.OrdinalIgnoreCase))
		{
			foreach (string highConfidenceCheat in HighConfidenceCheats)
			{
				if (fileName.Contains(highConfidenceCheat, StringComparison.OrdinalIgnoreCase))
				{
					return new CheatScanResult
					{
						FilePath = filePath,
						FileName = fileName,
						DetectionType = "Prefetch",
						CheatName = highConfidenceCheat,
						Details = "Запускался чит: " + highConfidenceCheat,
						FileDate = GetFileDate(filePath),
						Confidence = 95
					};
				}
			}
			return null;
		}
		if (extension.Equals(".exe", StringComparison.OrdinalIgnoreCase))
		{
			try
			{
				long length = new FileInfo(filePath).Length;
				if (KnownCheatSizes.TryGetValue(length, out string value))
				{
					return new CheatScanResult
					{
						FilePath = filePath,
						FileName = fileName,
						DetectionType = "Size",
						CheatName = value,
						Details = $"Размер файла совпадает: {length} байт",
						FileDate = GetFileDate(filePath),
						Confidence = 95
					};
				}
			}
			catch
			{
			}
		}
		if (extension.Equals(".exe", StringComparison.OrdinalIgnoreCase) || extension.Equals(".dll", StringComparison.OrdinalIgnoreCase))
		{
			CheatScanResult cheatScanResult = CheckDigitalSignature(filePath);
			if (cheatScanResult != null)
			{
				return cheatScanResult;
			}
			CheatScanResult cheatScanResult2 = CheckFileDescription(filePath);
			if (cheatScanResult2 != null)
			{
				return cheatScanResult2;
			}
		}
		foreach (string highConfidenceCheat2 in HighConfidenceCheats)
		{
			if (fileName.Contains(highConfidenceCheat2, StringComparison.OrdinalIgnoreCase))
			{
				return new CheatScanResult
				{
					FilePath = filePath,
					FileName = fileName,
					DetectionType = "Name",
					CheatName = highConfidenceCheat2,
					Details = "Имя файла: " + highConfidenceCheat2,
					FileDate = GetFileDate(filePath),
					Confidence = 95
				};
			}
		}
		foreach (string mediumConfidenceCheat in MediumConfidenceCheats)
		{
			if (fileName.Equals(mediumConfidenceCheat + ".exe", StringComparison.OrdinalIgnoreCase) || fileName.Equals(mediumConfidenceCheat + ".dll", StringComparison.OrdinalIgnoreCase))
			{
				return new CheatScanResult
				{
					FilePath = filePath,
					FileName = fileName,
					DetectionType = "Name",
					CheatName = mediumConfidenceCheat,
					Details = "Точное совпадение: " + mediumConfidenceCheat,
					FileDate = GetFileDate(filePath),
					Confidence = 85
				};
			}
		}
		if (extension.Equals(".exe", StringComparison.OrdinalIgnoreCase) || extension.Equals(".dll", StringComparison.OrdinalIgnoreCase))
		{
			Regex[] suspiciousPatterns = SuspiciousPatterns;
			for (int i = 0; i < suspiciousPatterns.Length; i++)
			{
				if (suspiciousPatterns[i].IsMatch(fileName))
				{
					return new CheatScanResult
					{
						FilePath = filePath,
						FileName = fileName,
						DetectionType = "Pattern",
						CheatName = "Suspicious",
						Details = "Подозрительный паттерн в имени",
						FileDate = GetFileDate(filePath),
						Confidence = 75
					};
				}
			}
			CheatScanResult cheatScanResult3 = CheckPEMetadata(filePath);
			if (cheatScanResult3 != null)
			{
				return cheatScanResult3;
			}
		}
		if (fileName.Equals("imgui.ini", StringComparison.OrdinalIgnoreCase))
		{
			string text = TryReadFile(filePath);
			if (text != null && (text.Contains("ESP", StringComparison.OrdinalIgnoreCase) || text.Contains("Aimbot", StringComparison.OrdinalIgnoreCase) || text.Contains("Wallhack", StringComparison.OrdinalIgnoreCase) || text.Contains("Triggerbot", StringComparison.OrdinalIgnoreCase)))
			{
				return new CheatScanResult
				{
					FilePath = filePath,
					FileName = fileName,
					DetectionType = "Config",
					CheatName = "ImGui Cheat Config",
					Details = "Конфиг ImGui с подозрительными окнами",
					FileDate = GetFileDate(filePath),
					Confidence = 80
				};
			}
		}
		return null;
	}

	private static CheatScanResult? CheckDigitalSignature(string filePath)
	{
		try
		{
			X509Certificate x509Certificate = X509Certificate.CreateFromSignedFile(filePath);
			if (x509Certificate == null)
			{
				return null;
			}
			foreach (KeyValuePair<string, string> knownCheatSignature in KnownCheatSignatures)
			{
				if (x509Certificate.Subject.Contains(knownCheatSignature.Key, StringComparison.OrdinalIgnoreCase))
				{
					return new CheatScanResult
					{
						FilePath = filePath,
						FileName = Path.GetFileName(filePath),
						DetectionType = "Signature",
						CheatName = knownCheatSignature.Value,
						Details = "Подпись: " + knownCheatSignature.Key,
						FileDate = GetFileDate(filePath),
						Confidence = 100
					};
				}
			}
		}
		catch
		{
		}
		return null;
	}

	private static CheatScanResult? CheckFileDescription(string filePath)
	{
		try
		{
			FileVersionInfo versionInfo = FileVersionInfo.GetVersionInfo(filePath);
			if (string.IsNullOrEmpty(versionInfo.FileDescription))
			{
				return null;
			}
			foreach (KeyValuePair<string, string> knownCheatDescription in KnownCheatDescriptions)
			{
				if (versionInfo.FileDescription.Contains(knownCheatDescription.Key, StringComparison.OrdinalIgnoreCase))
				{
					return new CheatScanResult
					{
						FilePath = filePath,
						FileName = Path.GetFileName(filePath),
						DetectionType = "Description",
						CheatName = knownCheatDescription.Value,
						Details = "Описание: \"" + knownCheatDescription.Key + "\"",
						FileDate = GetFileDate(filePath),
						Confidence = 100
					};
				}
			}
		}
		catch
		{
		}
		return null;
	}

	private static CheatScanResult? CheckPEMetadata(string filePath)
	{
		try
		{
			FileVersionInfo versionInfo = FileVersionInfo.GetVersionInfo(filePath);
			string[] array = new string[3] { versionInfo.OriginalFilename, versionInfo.ProductName, versionInfo.InternalName };
			foreach (string text in array)
			{
				if (string.IsNullOrEmpty(text))
				{
					continue;
				}
				foreach (string highConfidenceCheat in HighConfidenceCheats)
				{
					if (text.Contains(highConfidenceCheat, StringComparison.OrdinalIgnoreCase))
					{
						return new CheatScanResult
						{
							FilePath = filePath,
							FileName = Path.GetFileName(filePath),
							DetectionType = "Metadata",
							CheatName = highConfidenceCheat,
							Details = "Метаданные: " + highConfidenceCheat,
							FileDate = GetFileDate(filePath),
							Confidence = 90
						};
					}
				}
			}
		}
		catch
		{
		}
		return null;
	}

	private static string? TryReadFile(string path)
	{
		try
		{
			if (new FileInfo(path).Length > 51200)
			{
				return null;
			}
			return File.ReadAllText(path, Encoding.UTF8);
		}
		catch
		{
			return null;
		}
	}

	private static DateTime? GetFileDate(string path)
	{
		try
		{
			return File.GetLastWriteTime(path);
		}
		catch
		{
			return null;
		}
	}

	public static List<string> GetDefaultScanPaths()
	{
		List<string> list = new List<string>();
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
		string folderPath2 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
		string folderPath3 = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
		list.Add(Path.Combine(folderPath, "Downloads"));
		list.Add(Path.Combine(folderPath, "Desktop"));
		list.Add(folderPath2);
		list.Add(Path.Combine(folderPath3, "Temp"));
		return list.Where(Directory.Exists).ToList();
	}

	public static async Task<List<CheatScanResult>> CheckDnsCacheAsync()
	{
		List<CheatScanResult> results = new List<CheatScanResult>();
		try
		{
			ProcessStartInfo startInfo = new ProcessStartInfo
			{
				FileName = "ipconfig",
				Arguments = "/displaydns",
				RedirectStandardOutput = true,
				UseShellExecute = false,
				CreateNoWindow = true
			};
			using Process process = Process.Start(startInfo);
			if (process == null)
			{
				return results;
			}
			string output = await process.StandardOutput.ReadToEndAsync();
			await process.WaitForExitAsync();
			foreach (string cheatDomain in CheatDomains)
			{
				if (output.Contains(cheatDomain, StringComparison.OrdinalIgnoreCase))
				{
					results.Add(new CheatScanResult
					{
						FilePath = "DNS Cache",
						FileName = cheatDomain,
						DetectionType = "Network",
						CheatName = cheatDomain,
						Details = "Домен чита в DNS кэше: " + cheatDomain,
						FileDate = DateTime.Now,
						Confidence = 95
					});
				}
			}
		}
		catch
		{
		}
		return results;
	}

	public static async Task<List<CheatScanResult>> CheckSteamUserdataAsync(IProgress<string>? progress = null)
	{
		ConcurrentBag<CheatScanResult> results = new ConcurrentBag<CheatScanResult>();
		string text = new string[3]
		{
			"C:\\Program Files (x86)\\Steam",
			"C:\\Program Files\\Steam",
			Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Steam")
		}.FirstOrDefault(Directory.Exists);
		if (text == null)
		{
			return results.ToList();
		}
		string userdataPath = Path.Combine(text, "userdata");
		if (!Directory.Exists(userdataPath))
		{
			return results.ToList();
		}
		await Task.Run(delegate
		{
			try
			{
				foreach (string item in Directory.EnumerateFiles(userdataPath, "*.*", SearchOption.AllDirectories))
				{
					try
					{
						string fileName = Path.GetFileName(item);
						string extension = Path.GetExtension(item);
						progress?.Report("Steam: " + fileName);
						if (fileName.Equals("imgui.ini", StringComparison.OrdinalIgnoreCase) || extension.Equals(".cfg", StringComparison.OrdinalIgnoreCase))
						{
							string text2 = TryReadFile(item);
							if (text2 != null)
							{
								string[] array = new string[8] { "aimbot", "esp", "wallhack", "triggerbot", "bhop", "neverlose", "aimware", "skeet" };
								foreach (string text3 in array)
								{
									if (text2.Contains(text3, StringComparison.OrdinalIgnoreCase))
									{
										results.Add(new CheatScanResult
										{
											FilePath = item,
											FileName = fileName,
											DetectionType = "Steam",
											CheatName = text3,
											Details = "Steam userdata содержит: " + text3,
											FileDate = GetFileDate(item),
											Confidence = 85
										});
										break;
									}
								}
							}
						}
						foreach (string highConfidenceCheat in HighConfidenceCheats)
						{
							if (fileName.Contains(highConfidenceCheat, StringComparison.OrdinalIgnoreCase))
							{
								results.Add(new CheatScanResult
								{
									FilePath = item,
									FileName = fileName,
									DetectionType = "Steam",
									CheatName = highConfidenceCheat,
									Details = "Steam userdata: " + highConfidenceCheat,
									FileDate = GetFileDate(item),
									Confidence = 90
								});
								break;
							}
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
		});
		return results.ToList();
	}
}
