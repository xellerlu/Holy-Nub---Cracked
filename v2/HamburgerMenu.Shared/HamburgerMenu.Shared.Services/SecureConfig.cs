using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace HamburgerMenu.Shared.Services;

public static class SecureConfig
{
	private static readonly byte[] P1 = new byte[1] { 67 };

	private static readonly byte[] P2 = new byte[1] { 72 };

	private static readonly byte[] P3 = new byte[2] { 69, 67 };

	private static readonly byte[] P4 = new byte[1] { 75 };

	private static readonly byte[] P5 = new byte[2] { 69, 82 };

	private static readonly byte[] P6 = new byte[1] { 32 };

	private static readonly byte[] P7 = new byte[2] { 50, 46 };

	private static readonly byte[] P8 = new byte[1] { 48 };

	private static readonly byte[] U1 = new byte[5] { 104, 116, 116, 112, 115 };

	private static readonly byte[] U2 = new byte[3] { 58, 47, 47 };

	private static readonly byte[] U3 = Convert.FromBase64String("ZGlzay55YW5kZXgucnU=");

	private static readonly byte[] U4 = new byte[3] { 47, 100, 47 };

	private static readonly byte[] U5 = new byte[4] { 55, 72, 115, 85 };

	private static readonly byte[] U6 = new byte[4] { 100, 110, 80, 90 };

	private static readonly byte[] U7 = new byte[4] { 74, 118, 86, 83 };

	private static readonly byte[] U8 = new byte[2] { 55, 119 };

	public static string GetPassword()
	{
		byte[][] obj = new byte[8][] { P1, P2, P3, P4, P5, P6, P7, P8 };
		byte[] array = new byte[obj.Sum((byte[] p) => p.Length)];
		int num = 0;
		byte[][] array2 = obj;
		foreach (byte[] array3 in array2)
		{
			Buffer.BlockCopy(array3, 0, array, num, array3.Length);
			num += array3.Length;
		}
		return Encoding.ASCII.GetString(array);
	}

	public static string GetYandexUrl()
	{
		byte[][] obj = new byte[8][] { U1, U2, U3, U4, U5, U6, U7, U8 };
		byte[] array = new byte[obj.Sum((byte[] p) => p.Length)];
		int num = 0;
		byte[][] array2 = obj;
		foreach (byte[] array3 in array2)
		{
			Buffer.BlockCopy(array3, 0, array, num, array3.Length);
			num += array3.Length;
		}
		return Encoding.ASCII.GetString(array);
	}

	public static bool ValidateIntegrity()
	{
		string password = GetPassword();
		string yandexUrl = GetYandexUrl();
		using SHA256 sHA = SHA256.Create();
		byte[] array = sHA.ComputeHash(Encoding.UTF8.GetBytes(password + yandexUrl));
		return array[0] == 167 && array[1] == 139;
	}
}
