using System;

namespace HamburgerMenu.Shared.Models;

public class VersionInfo
{
	public string Version { get; set; } = "1.0.0";

	public string FileName { get; set; } = "app.enc";

	public string Checksum { get; set; } = "";

	public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
}
