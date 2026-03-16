using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace HamburgerMenu.Models;

public class SteamAccount : INotifyPropertyChanged
{
	private string _vacStatus = "Loading...";

	public string SteamId64 { get; set; } = "";

	public string SteamId2 { get; set; } = "";

	public string AccountName { get; set; } = "";

	public string PersonaName { get; set; } = "";

	public string? AvatarUrl { get; set; }

	public string RootPath { get; set; } = "";

	public bool MostRecent { get; set; }

	public string VacStatus
	{
		get
		{
			return _vacStatus;
		}
		set
		{
			if (_vacStatus != value)
			{
				_vacStatus = value;
				OnPropertyChanged("VacStatus");
			}
		}
	}

	public event PropertyChangedEventHandler? PropertyChanged;

	protected void OnPropertyChanged([CallerMemberName] string? name = null)
	{
		this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
	}
}
