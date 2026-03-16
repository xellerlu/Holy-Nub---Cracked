using System;

namespace HamburgerMenu.Shared.Services;

public class LicenseResult
{
	public bool IsValid { get; }

	public string? ErrorMessage { get; }

	public string? Email { get; }

	public DateTime? ExpiryDate { get; }

	public int DaysRemaining
	{
		get
		{
			if (!ExpiryDate.HasValue)
			{
				return 0;
			}
			return Math.Max(0, (ExpiryDate.Value - DateTime.UtcNow.Date).Days);
		}
	}

	public LicenseResult(bool isValid, string? errorMessage, string? email = null, DateTime? expiryDate = null)
	{
		IsValid = isValid;
		ErrorMessage = errorMessage;
		Email = email;
		ExpiryDate = expiryDate;
	}
}
