using System;
using System.Globalization;
using System.Security.Cryptography;

namespace HamburgerMenu.Shared.Services;

public static class LicenseManager
{
	private static readonly string[] ValidLicenses = new string[1] { "test@test.com-20260113-7Ktrk6XW" };

	public static LicenseResult ValidateCode(string userCode)
	{
		if (string.IsNullOrWhiteSpace(userCode))
		{
			return new LicenseResult(isValid: false, "Введите код доступа");
		}
		userCode = userCode.Trim();
		if (userCode.Length != 8)
		{
			return new LicenseResult(isValid: false, "Код должен содержать 8 символов");
		}
		string[] validLicenses = ValidLicenses;
		for (int i = 0; i < validLicenses.Length; i++)
		{
			string[] array = validLicenses[i].Split('-');
			if (array.Length != 3)
			{
				continue;
			}
			string email = array[0];
			string s = array[1];
			if (array[2].Equals(userCode, StringComparison.Ordinal))
			{
				if (!DateTime.TryParseExact(s, "yyyyMMdd", CultureInfo.InvariantCulture, DateTimeStyles.None, out var result))
				{
					return new LicenseResult(isValid: false, "Ошибка лицензии");
				}
				if (DateTime.UtcNow.Date > result)
				{
					return new LicenseResult(isValid: false, $"Срок действия истёк ({result:dd.MM.yyyy})");
				}
				return new LicenseResult(isValid: true, null, email, result);
			}
		}
		return new LicenseResult(isValid: false, "Неверный код доступа");
	}

	public static string GenerateLicense(string email, DateTime expiryDate)
	{
		string value = GenerateCode();
		string value2 = expiryDate.ToString("yyyyMMdd");
		return $"{email}-{value2}-{value}";
	}

	private static string GenerateCode()
	{
		char[] array = new char[8];
		using RandomNumberGenerator randomNumberGenerator = RandomNumberGenerator.Create();
		byte[] array2 = new byte[8];
		randomNumberGenerator.GetBytes(array2);
		for (int i = 0; i < 8; i++)
		{
			array[i] = "ABCDEFGHJKLMNPQRSTUVWXYZabcdefghjkmnpqrstuvwxyz23456789"[array2[i] % "ABCDEFGHJKLMNPQRSTUVWXYZabcdefghjkmnpqrstuvwxyz23456789".Length];
		}
		return new string(array);
	}
}
