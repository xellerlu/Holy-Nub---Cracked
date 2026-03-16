using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;
using HamburgerMenu.Models;
using Microsoft.Win32;

namespace HamburgerMenu.Services;

public static class SteamDiscovery
{
	private const long SteamId64Base = 76561197960265728L;

	private static readonly HttpClient Http = new HttpClient();

	public static IReadOnlyList<string> FindSteamRootPaths()
	{
		List<string> list = new List<string>();
		try
		{
			using RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\Valve\\Steam");
			string text = registryKey?.GetValue("SteamPath") as string;
			if (!string.IsNullOrWhiteSpace(text) && Directory.Exists(text))
			{
				list.Add(text);
			}
		}
		catch
		{
		}
		try
		{
			using RegistryKey registryKey2 = Registry.LocalMachine.OpenSubKey("SOFTWARE\\WOW6432Node\\Valve\\Steam");
			string text2 = registryKey2?.GetValue("InstallPath") as string;
			if (!string.IsNullOrWhiteSpace(text2) && Directory.Exists(text2))
			{
				list.Add(text2);
			}
		}
		catch
		{
		}
		try
		{
			foreach (DriveInfo item in from d in DriveInfo.GetDrives()
				where d.IsReady && d.DriveType == DriveType.Fixed
				select d)
			{
				string[] array = new string[3]
				{
					Path.Combine(item.RootDirectory.FullName, "Program Files (x86)", "Steam"),
					Path.Combine(item.RootDirectory.FullName, "Program Files", "Steam"),
					Path.Combine(item.RootDirectory.FullName, "Steam")
				};
				foreach (string text3 in array)
				{
					if (Directory.Exists(text3))
					{
						list.Add(text3);
					}
				}
			}
		}
		catch
		{
		}
		return list.Distinct<string>(StringComparer.OrdinalIgnoreCase).ToList();
	}

	public static ObservableCollection<SteamAccount> LoadAccounts()
	{
		ObservableCollection<SteamAccount> observableCollection = new ObservableCollection<SteamAccount>();
		foreach (string item in FindSteamRootPaths())
		{
			string text = Path.Combine(item, "config", "loginusers.vdf");
			if (!File.Exists(text))
			{
				continue;
			}
			foreach (SteamAccount item2 in ParseLoginUsers(text))
			{
				item2.RootPath = item;
				if (string.IsNullOrWhiteSpace(item2.SteamId2) && !string.IsNullOrWhiteSpace(item2.SteamId64))
				{
					item2.SteamId2 = ToSteamId2(item2.SteamId64);
				}
				observableCollection.Add(item2);
			}
		}
		if (observableCollection.Count == 0)
		{
			foreach (string item3 in FindSteamRootPaths())
			{
				string path = Path.Combine(item3, "userdata");
				if (!Directory.Exists(path))
				{
					continue;
				}
				foreach (string item4 in Directory.EnumerateDirectories(path))
				{
					string fileName = Path.GetFileName(item4);
					if (Regex.IsMatch(fileName ?? string.Empty, "^\\d{17}$"))
					{
						string text2 = fileName;
						observableCollection.Add(new SteamAccount
						{
							SteamId64 = text2,
							SteamId2 = ToSteamId2(text2),
							AccountName = text2,
							PersonaName = text2,
							RootPath = item3,
							MostRecent = false
						});
					}
				}
			}
		}
		return new ObservableCollection<SteamAccount>((from a in observableCollection
			where !string.IsNullOrWhiteSpace(a.SteamId64)
			group a by a.SteamId64 into g
			select g.First()).ToList());
	}

	private static IEnumerable<SteamAccount> ParseLoginUsers(string vdfPath)
	{
		string text = File.ReadAllText(vdfPath);
		List<SteamAccount> list = new List<SteamAccount>();
		Regex regex = new Regex("\"(\\d{17})\"", RegexOptions.Compiled);
		Regex regex2 = new Regex("\"(?<k>[^\"]+)\"\\s+\"(?<v>[^\"]*)\"", RegexOptions.Compiled);
		SteamAccount steamAccount = null;
		int num = 0;
		string[] array = text.Split(new string[2] { "\r\n", "\n" }, StringSplitOptions.None);
		for (int i = 0; i < array.Length; i++)
		{
			string text2 = array[i].Trim();
			if (text2.Length == 0)
			{
				continue;
			}
			if (text2.Contains("{"))
			{
				num++;
				continue;
			}
			if (text2.Contains("}"))
			{
				num--;
				if (num == 1 && steamAccount != null)
				{
					list.Add(steamAccount);
					steamAccount = null;
				}
				continue;
			}
			switch (num)
			{
			case 1:
			{
				Match match2 = regex.Match(text2);
				if (match2.Success)
				{
					steamAccount = new SteamAccount
					{
						SteamId64 = match2.Groups[1].Value
					};
				}
				break;
			}
			case 2:
			{
				if (steamAccount == null)
				{
					break;
				}
				Match match = regex2.Match(text2);
				if (match.Success)
				{
					string value = match.Groups["k"].Value;
					string value2 = match.Groups["v"].Value;
					switch (value)
					{
					case "AccountName":
						steamAccount.AccountName = value2;
						break;
					case "PersonaName":
						steamAccount.PersonaName = value2;
						break;
					case "MostRecent":
						steamAccount.MostRecent = value2 == "1";
						break;
					case "Avatar":
						steamAccount.AvatarUrl = BuildAvatarUrlFromHash(value2);
						break;
					}
				}
				break;
			}
			}
		}
		return list;
	}

	public static string ToSteamId2(string steamId64)
	{
		if (!ulong.TryParse(steamId64, out var result))
		{
			return string.Empty;
		}
		ulong num = result - 76561197960265728L;
		ulong num2 = num % 2;
		ulong value = (num - num2) / 2;
		return $"STEAM_1:{num2}:{value}";
	}

	private static string? BuildAvatarUrlFromHash(string hash)
	{
		if (string.IsNullOrWhiteSpace(hash))
		{
			return null;
		}
		string text = hash.Trim();
		if (Regex.IsMatch(text, "^0{10,}$"))
		{
			return null;
		}
		return "https://avatars.akamai.steamstatic.com/" + text + "_full.jpg";
	}

	public static async Task<string?> GetAvatarUrlAsync(string steamId64)
	{
		if (string.IsNullOrWhiteSpace(steamId64))
		{
			return null;
		}
		try
		{
			string requestUri = "https://steamcommunity.com/profiles/" + steamId64 + "?xml=1";
			using HttpResponseMessage resp = await Http.GetAsync(requestUri).ConfigureAwait(continueOnCapturedContext: false);
			if (!resp.IsSuccessStatusCode)
			{
				return null;
			}
			string text = XDocument.Parse(await resp.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)).Root?.Element("avatarFull")?.Value;
			return string.IsNullOrWhiteSpace(text) ? null : text.Trim();
		}
		catch
		{
			return null;
		}
	}

	public static async Task<string> GetVacStatusAsync(string steamId64)
	{
		if (string.IsNullOrWhiteSpace(steamId64))
		{
			return "Unknown";
		}
		try
		{
			string requestUri = "https://steamcommunity.com/profiles/" + steamId64 + "?xml=1";
			using HttpResponseMessage resp = await Http.GetAsync(requestUri).ConfigureAwait(continueOnCapturedContext: false);
			if (!resp.IsSuccessStatusCode)
			{
				return "Unknown";
			}
			XDocument xDocument = XDocument.Parse(await resp.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false));
			string text = xDocument.Root?.Element("vacBanned")?.Value;
			string text2 = xDocument.Root?.Element("numberOfVACBans")?.Value;
			if (text == "1" || (text2 != null && int.TryParse(text2, out var result) && result > 0))
			{
				return "Banned";
			}
			return "Clean";
		}
		catch
		{
			return "Unknown";
		}
	}
}
