using System;
using System.Text;

namespace HamburgerMenu.Shared.Services;

public static class SecureConfig
{
	private static readonly string D1 = "OXfUgRatRpYesHc=";

	private static readonly string D2 = "Ekvlsi7SO5lI9zSYVEbwrDmNbJhe62iXVQjZsQiMeuZ21DGlKQjm";

	private static readonly byte[] K = new byte[12]
	{
		122, 63, 145, 194, 93, 232, 20, 182, 44, 158,
		71, 243
	};

	private static string Decode(string data)
	{
		byte[] array = Convert.FromBase64String(data);
		byte[] array2 = new byte[array.Length];
		for (int i = 0; i < array.Length; i++)
		{
			array2[i] = (byte)(array[i] ^ K[i % K.Length]);
		}
		return Encoding.UTF8.GetString(array2);
	}

	public static string GetPassword()
	{
		return Decode(D1);
	}

	public static string GetYandexUrl()
	{
		return Decode(D2);
	}

	public static bool ValidateIntegrity()
	{
		try
		{
			return GetPassword().Length > 0 && GetYandexUrl().Contains("://");
		}
		catch
		{
			return false;
		}
	}
}
