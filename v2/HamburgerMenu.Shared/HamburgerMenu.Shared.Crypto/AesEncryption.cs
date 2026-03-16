using System;
using System.Security.Cryptography;

namespace HamburgerMenu.Shared.Crypto;

public static class AesEncryption
{
	private const int KeySize = 256;

	private const int IvSize = 16;

	public static byte[] Encrypt(byte[] data, string password)
	{
		using Aes aes = Aes.Create();
		aes.KeySize = 256;
		byte[] key = DeriveKey(password, aes.KeySize / 8);
		aes.Key = key;
		aes.GenerateIV();
		using ICryptoTransform cryptoTransform = aes.CreateEncryptor();
		byte[] array = cryptoTransform.TransformFinalBlock(data, 0, data.Length);
		byte[] array2 = new byte[16 + array.Length];
		Buffer.BlockCopy(aes.IV, 0, array2, 0, 16);
		Buffer.BlockCopy(array, 0, array2, 16, array.Length);
		return array2;
	}

	public static byte[] Decrypt(byte[] encryptedData, string password)
	{
		using Aes aes = Aes.Create();
		aes.KeySize = 256;
		byte[] array = new byte[16];
		Buffer.BlockCopy(encryptedData, 0, array, 0, 16);
		byte[] key = DeriveKey(password, aes.KeySize / 8);
		aes.Key = key;
		aes.IV = array;
		using ICryptoTransform cryptoTransform = aes.CreateDecryptor();
		return cryptoTransform.TransformFinalBlock(encryptedData, 16, encryptedData.Length - 16);
	}

	private static byte[] DeriveKey(string password, int keyBytes)
	{
		byte[] salt = "HamburgerMenu_Salt_2024"u8.ToArray();
		using Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(password, salt, 100000, HashAlgorithmName.SHA256);
		return rfc2898DeriveBytes.GetBytes(keyBytes);
	}
}
