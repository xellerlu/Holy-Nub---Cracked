using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Input;
using Avalonia.Media.Imaging;
using Avalonia.Threading;
using HamburgerMenu.Models;
using HamburgerMenu.Services;

namespace HamburgerMenu.Controls;

public class CustomerViewModel : INotifyPropertyChanged
{
	private static readonly HttpClient Http = new HttpClient();

	private SteamAccount? _selectedAccount;

	private Bitmap? _avatarBitmap;

	public ObservableCollection<SteamAccount> Accounts { get; }

	public SteamAccount? SelectedAccount
	{
		get
		{
			return _selectedAccount;
		}
		set
		{
			if (_selectedAccount != value)
			{
				_selectedAccount = value;
				OnPropertyChanged("SelectedAccount");
				OnPropertyChanged("Nickname");
				OnPropertyChanged("SteamId2");
				OnPropertyChanged("UniqueId");
				OnPropertyChanged("HasSelectedAccount");
				LoadAvatarAsync();
			}
		}
	}

	public string Nickname => SelectedAccount?.PersonaName ?? SelectedAccount?.AccountName ?? "";

	public string SteamId2 => SelectedAccount?.SteamId2 ?? "";

	public string UniqueId => SelectedAccount?.SteamId64 ?? "";

	public bool HasSelectedAccount => SelectedAccount != null;

	public Bitmap? AvatarBitmap
	{
		get
		{
			return _avatarBitmap;
		}
		set
		{
			_avatarBitmap = value;
			OnPropertyChanged("AvatarBitmap");
		}
	}

	public ICommand OpenProfileCommand { get; }

	public event PropertyChangedEventHandler? PropertyChanged;

	public CustomerViewModel()
	{
		Accounts = SteamDiscovery.LoadAccounts();
		foreach (SteamAccount account in Accounts)
		{
			account.VacStatus = "Loading...";
		}
		OpenProfileCommand = new RelayCommand(delegate
		{
			OpenProfile();
		});
		LoadVacStatusesAsync();
	}

	private async Task LoadVacStatusesAsync()
	{
		foreach (SteamAccount account in Accounts)
		{
			if (!string.IsNullOrWhiteSpace(account.SteamId64))
			{
				try
				{
					SteamAccount steamAccount = account;
					steamAccount.VacStatus = await SteamDiscovery.GetVacStatusAsync(account.SteamId64);
				}
				catch
				{
					account.VacStatus = "Error";
				}
			}
			else
			{
				account.VacStatus = "Unknown";
			}
		}
	}

	private async Task LoadAvatarAsync()
	{
		if (SelectedAccount == null)
		{
			AvatarBitmap = null;
			return;
		}
		try
		{
			string text = SelectedAccount.AvatarUrl;
			if (string.IsNullOrWhiteSpace(text))
			{
				text = await SteamDiscovery.GetAvatarUrlAsync(SelectedAccount.SteamId64);
				SelectedAccount.AvatarUrl = text;
			}
			if (!string.IsNullOrWhiteSpace(text))
			{
				MemoryStream stream = new MemoryStream(await Http.GetByteArrayAsync(text));
				try
				{
					await Dispatcher.UIThread.InvokeAsync(delegate
					{
						AvatarBitmap = new Bitmap(stream);
					});
					return;
				}
				finally
				{
					if (stream != null)
					{
						((IDisposable)stream).Dispose();
					}
				}
			}
			AvatarBitmap = null;
		}
		catch
		{
			AvatarBitmap = null;
		}
	}

	private void OpenProfile()
	{
		if (SelectedAccount == null || string.IsNullOrWhiteSpace(SelectedAccount.SteamId64))
		{
			return;
		}
		string fileName = "https://steamcommunity.com/profiles/" + SelectedAccount.SteamId64;
		try
		{
			Process.Start(new ProcessStartInfo
			{
				FileName = fileName,
				UseShellExecute = true
			});
		}
		catch
		{
		}
	}

	protected void OnPropertyChanged([CallerMemberName] string? name = null)
	{
		this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
	}
}
