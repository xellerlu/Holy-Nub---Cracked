using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;
using HamburgerMenu.Shared.Models;

namespace HamburgerMenu.Shared.Services;

public class YandexDiskService
{
	private class YandexDownloadResponse
	{
		public string? Href { get; set; }
	}

	private readonly HttpClient _httpClient;

	private readonly string _publicUrl;

	private const string YandexApiBase = "https://cloud-api.yandex.net/v1/disk/public/resources";

	public YandexDiskService(string publicUrl)
	{
		_publicUrl = publicUrl;
		_httpClient = new HttpClient();
	}

	public async Task<VersionInfo?> GetVersionInfoAsync()
	{
		_ = 1;
		try
		{
			string text = await GetDownloadUrlAsync("version.json");
			if (string.IsNullOrEmpty(text))
			{
				return null;
			}
			return JsonSerializer.Deserialize<VersionInfo>(await _httpClient.GetStringAsync(text), new JsonSerializerOptions
			{
				PropertyNameCaseInsensitive = true
			});
		}
		catch
		{
			return null;
		}
	}

	public async Task<byte[]?> DownloadFileAsync(string fileName)
	{
		_ = 1;
		try
		{
			string text = await GetDownloadUrlAsync(fileName);
			if (string.IsNullOrEmpty(text))
			{
				return null;
			}
			return await _httpClient.GetByteArrayAsync(text);
		}
		catch
		{
			return null;
		}
	}

	private async Task<string?> GetDownloadUrlAsync(string path)
	{
		string requestUri = $"{"https://cloud-api.yandex.net/v1/disk/public/resources"}/download?public_key={Uri.EscapeDataString(_publicUrl)}&path=/{path}";
		HttpResponseMessage httpResponseMessage = await _httpClient.GetAsync(requestUri);
		if (!httpResponseMessage.IsSuccessStatusCode)
		{
			return null;
		}
		return (await httpResponseMessage.Content.ReadFromJsonAsync<YandexDownloadResponse>())?.Href;
	}
}
