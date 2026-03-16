using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Security.Cryptography;
using Avalonia.Media.Imaging;

namespace HamburgerMenu.Services;

public static class InMemoryImageCache
{
	private static readonly Dictionary<string, Bitmap> _imageCache = new Dictionary<string, Bitmap>(StringComparer.OrdinalIgnoreCase);

	private static readonly Dictionary<string, byte[]> _rawImageData = new Dictionary<string, byte[]>(StringComparer.OrdinalIgnoreCase);

	private static bool _isInitialized;

	private static readonly object _lock = new object();

	public static bool IsInitialized => _isInitialized;

	public static bool Initialize(string appBaseDirectory)
	{
		lock (_lock)
		{
			if (_isInitialized)
			{
				return true;
			}
			try
			{
				string text = Path.Combine(appBaseDirectory, "Assets.enc");
				if (File.Exists(text))
				{
					return DecryptAndLoadToMemory(text);
				}
				string text2 = Path.Combine(appBaseDirectory, "Assets");
				if (Directory.Exists(text2))
				{
					return LoadFromFolder(text2);
				}
				string fullPath = Path.GetFullPath(Path.Combine(appBaseDirectory, "..", "..", "..", "Assets"));
				if (Directory.Exists(fullPath))
				{
					return LoadFromFolder(fullPath);
				}
				return false;
			}
			catch
			{
				return false;
			}
		}
	}

	private static bool LoadFromFolder(string imagesFolder)
	{
		try
		{
			if (!Directory.Exists(imagesFolder))
			{
				return false;
			}
			string[] files = Directory.GetFiles(imagesFolder, "*.png", SearchOption.TopDirectoryOnly);
			foreach (string path in files)
			{
				try
				{
					string fileName = Path.GetFileName(path);
					byte[] array = File.ReadAllBytes(path);
					_rawImageData[fileName] = array;
					Bitmap bitmap = CreateBitmapFromBytes(array);
					if (bitmap != null)
					{
						_imageCache[fileName] = bitmap;
					}
				}
				catch
				{
				}
			}
			_isInitialized = true;
			return true;
		}
		catch
		{
			return false;
		}
	}

	private static bool DecryptAndLoadToMemory(string encryptedFile)
	{
		try
		{
			byte[] array = DecryptToMemory(File.ReadAllBytes(encryptedFile));
			using MemoryStream stream = new MemoryStream(array);
			using ZipArchive zipArchive = new ZipArchive(stream, ZipArchiveMode.Read);
			foreach (ZipArchiveEntry entry in zipArchive.Entries)
			{
				if (string.IsNullOrEmpty(entry.Name))
				{
					continue;
				}
				try
				{
					using Stream stream2 = entry.Open();
					using MemoryStream memoryStream = new MemoryStream();
					stream2.CopyTo(memoryStream);
					byte[] array2 = memoryStream.ToArray();
					string name = entry.Name;
					_rawImageData[name] = array2;
					Bitmap bitmap = CreateBitmapFromBytes(array2);
					if (bitmap != null)
					{
						_imageCache[name] = bitmap;
					}
				}
				catch
				{
				}
			}
			Array.Clear(array, 0, array.Length);
			_isInitialized = true;
			return true;
		}
		catch
		{
			return false;
		}
	}

	private static byte[] GetKey()
	{
		byte[] array = new byte[4] { 72, 111, 108, 121 };
		byte[] array2 = new byte[7] { 67, 104, 101, 99, 107, 101, 114 };
		byte[] array3 = new byte[4] { 50, 48, 50, 53 };
		byte[] array4 = new byte[6] { 83, 101, 99, 114, 101, 116 };
		byte[] array5 = new byte[5] { 75, 101, 121, 51, 50 };
		byte[] array6 = new byte[5] { 66, 121, 116, 101, 115 };
		byte[] array7 = new byte[2] { 33, 33 };
		byte[] array8 = new byte[32];
		int num = 0;
		byte[][] array9 = new byte[7][] { array, array2, array3, array4, array5, array6, array7 };
		foreach (byte[] array10 in array9)
		{
			Buffer.BlockCopy(array10, 0, array8, num, Math.Min(array10.Length, 32 - num));
			num += array10.Length;
			if (num >= 32)
			{
				break;
			}
		}
		return array8;
	}

	private static byte[] GetIV()
	{
		byte[] array = "HolyChecker2025I"u8.ToArray();
		byte[] array2 = new byte[16];
		Array.Copy(array, array2, Math.Min(array.Length, 16));
		return array2;
	}

	private static byte[] DecryptToMemory(byte[] encryptedData)
	{
		using Aes aes = Aes.Create();
		aes.Key = GetKey();
		aes.IV = GetIV();
		aes.Mode = CipherMode.CBC;
		aes.Padding = PaddingMode.PKCS7;
		using MemoryStream stream = new MemoryStream(encryptedData);
		using CryptoStream cryptoStream = new CryptoStream(stream, aes.CreateDecryptor(), CryptoStreamMode.Read);
		using MemoryStream memoryStream = new MemoryStream();
		cryptoStream.CopyTo(memoryStream);
		return memoryStream.ToArray();
	}

	private static Bitmap? CreateBitmapFromBytes(byte[] imageData)
	{
		try
		{
			using MemoryStream stream = new MemoryStream(imageData);
			return new Bitmap(stream);
		}
		catch
		{
			return null;
		}
	}

	public static Bitmap? GetImage(string fileName)
	{
		if (!_isInitialized)
		{
			return null;
		}
		if (_imageCache.TryGetValue(fileName, out Bitmap value))
		{
			return value;
		}
		string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(fileName);
		foreach (string key in _imageCache.Keys)
		{
			if (Path.GetFileNameWithoutExtension(key).Equals(fileNameWithoutExtension, StringComparison.OrdinalIgnoreCase))
			{
				return _imageCache[key];
			}
		}
		return null;
	}

	public static byte[]? GetImageBytes(string fileName)
	{
		if (!_isInitialized)
		{
			return null;
		}
		if (!_rawImageData.TryGetValue(fileName, out byte[] value))
		{
			return null;
		}
		return value;
	}

	public static bool HasImage(string fileName)
	{
		if (_isInitialized)
		{
			return _imageCache.ContainsKey(fileName);
		}
		return false;
	}

	public static IEnumerable<string> GetAllImageNames()
	{
		return _imageCache.Keys;
	}

	public static void Clear()
	{
		lock (_lock)
		{
			foreach (string key in _rawImageData.Keys)
			{
				if (_rawImageData[key] != null)
				{
					Array.Clear(_rawImageData[key], 0, _rawImageData[key].Length);
				}
			}
			_rawImageData.Clear();
			_imageCache.Clear();
			_isInitialized = false;
		}
	}
}
