using System;

namespace HamburgerMenu.Services;

public class CheatScanResult
{
	public string FilePath { get; set; } = "";

	public string FileName { get; set; } = "";

	public string DetectionType { get; set; } = "";

	public string CheatName { get; set; } = "";

	public string Details { get; set; } = "";

	public DateTime? FileDate { get; set; }

	public int Confidence { get; set; }
}
