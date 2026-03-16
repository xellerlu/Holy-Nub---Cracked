using System;
using System.Globalization;
using System.Security.Cryptography;
using System.Text;

namespace HamburgerMenu.Shared.Services;

public static class LicenseManager
{
	private const string HashSalt = "HolyNub_License_Salt_2024";

	private static readonly string[] ValidLicenses = new string[1] { "contactfayin@gmail.com-20260716-9212350881720319e4823a86d457a11c761b694f67426d101ab706a9d55f4b39" };

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
		string value = HashCode(userCode);
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
			if (array[2].Equals(value, StringComparison.OrdinalIgnoreCase))
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

	public static string HashCode(string code)
	{
		return Convert.ToHexString(SHA256.HashData(Encoding.UTF8.GetBytes(code + "HolyNub_License_Salt_2024"))).ToLower();
	}

	public static (string LicenseLine, string UserCode) GenerateLicense(string email, DateTime expiryDate)
	{
		string text = GenerateCode();
		string value = HashCode(text);
		string value2 = expiryDate.ToString("yyyyMMdd");
		return (LicenseLine: $"{email}-{value2}-{value}", UserCode: text);
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
