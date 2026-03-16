using System;
using System.ComponentModel;
using Avalonia.Markup.Xaml.XamlIl.Runtime;
using HamburgerMenu;
using HamburgerMenu.Controls;

namespace CompiledAvaloniaXaml;

[EditorBrowsable(EditorBrowsableState.Never)]
public class _0021XamlLoader
{
	public static object TryLoad(IServiceProvider P_0, string P_1)
	{
		if (string.Equals(P_1, "avares://HamburgerMenu.Avalonia/App.axaml", StringComparison.OrdinalIgnoreCase))
		{
			return new App();
		}
		if (string.Equals(P_1, "avares://HamburgerMenu.Avalonia/Controls/AppControl.axaml", StringComparison.OrdinalIgnoreCase))
		{
			return new AppControl();
		}
		if (string.Equals(P_1, "avares://HamburgerMenu.Avalonia/Controls/Channel.axaml", StringComparison.OrdinalIgnoreCase))
		{
			return new Channel();
		}
		if (string.Equals(P_1, "avares://HamburgerMenu.Avalonia/Controls/MainMenu.axaml", StringComparison.OrdinalIgnoreCase))
		{
			return new MainMenu();
		}
		if (string.Equals(P_1, "avares://HamburgerMenu.Avalonia/Controls/SideBar.axaml", StringComparison.OrdinalIgnoreCase))
		{
			return new SideBar();
		}
		if (string.Equals(P_1, "avares://HamburgerMenu.Avalonia/Controls/SidePanel.axaml", StringComparison.OrdinalIgnoreCase))
		{
			return new SidePanel();
		}
		if (string.Equals(P_1, "avares://HamburgerMenu.Avalonia/Controls/SubmenuAnalytics.axaml", StringComparison.OrdinalIgnoreCase))
		{
			return new SubmenuAnalytics();
		}
		if (string.Equals(P_1, "avares://HamburgerMenu.Avalonia/Controls/SubmenuCustomer.axaml", StringComparison.OrdinalIgnoreCase))
		{
			return new SubmenuCustomer();
		}
		if (string.Equals(P_1, "avares://HamburgerMenu.Avalonia/Controls/SubmenuOne.axaml", StringComparison.OrdinalIgnoreCase))
		{
			return new SubmenuOne();
		}
		if (string.Equals(P_1, "avares://HamburgerMenu.Avalonia/Controls/SubmenuSettings.axaml", StringComparison.OrdinalIgnoreCase))
		{
			return new SubmenuSettings();
		}
		if (string.Equals(P_1, "avares://HamburgerMenu.Avalonia/Controls/SubmenuTwo.axaml", StringComparison.OrdinalIgnoreCase))
		{
			return new SubmenuTwo();
		}
		if (string.Equals(P_1, "avares://HamburgerMenu.Avalonia/Controls/TrackOne.axaml", StringComparison.OrdinalIgnoreCase))
		{
			return new TrackOne();
		}
		if (string.Equals(P_1, "avares://HamburgerMenu.Avalonia/Controls/TrackTwo.axaml", StringComparison.OrdinalIgnoreCase))
		{
			return new TrackTwo();
		}
		if (string.Equals(P_1, "avares://HamburgerMenu.Avalonia/MainWindow.axaml", StringComparison.OrdinalIgnoreCase))
		{
			return new MainWindow();
		}
		if (string.Equals(P_1, "avares://HamburgerMenu.Avalonia/Styles/ButtonStyles.axaml", StringComparison.OrdinalIgnoreCase))
		{
			return _0021AvaloniaResources.Build_003A_002FStyles_002FButtonStyles_002Eaxaml(XamlIlRuntimeHelpers.CreateRootServiceProviderV3(P_0));
		}
		if (string.Equals(P_1, "avares://HamburgerMenu.Avalonia/Styles/Colors.axaml", StringComparison.OrdinalIgnoreCase))
		{
			return _0021AvaloniaResources.Build_003A_002FStyles_002FColors_002Eaxaml(XamlIlRuntimeHelpers.CreateRootServiceProviderV3(P_0));
		}
		if (string.Equals(P_1, "avares://HamburgerMenu.Avalonia/Styles/FontResources.axaml", StringComparison.OrdinalIgnoreCase))
		{
			return _0021AvaloniaResources.Build_003A_002FStyles_002FFontResources_002Eaxaml(XamlIlRuntimeHelpers.CreateRootServiceProviderV3(P_0));
		}
		if (string.Equals(P_1, "avares://HamburgerMenu.Avalonia/Styles/ImageResources.axaml", StringComparison.OrdinalIgnoreCase))
		{
			return _0021AvaloniaResources.Build_003A_002FStyles_002FImageResources_002Eaxaml(XamlIlRuntimeHelpers.CreateRootServiceProviderV3(P_0));
		}
		if (string.Equals(P_1, "avares://HamburgerMenu.Avalonia/Styles/ToggleButtonStyles.axaml", StringComparison.OrdinalIgnoreCase))
		{
			return _0021AvaloniaResources.Build_003A_002FStyles_002FToggleButtonStyles_002Eaxaml(XamlIlRuntimeHelpers.CreateRootServiceProviderV3(P_0));
		}
		return null;
	}

	public static object TryLoad(string P_0)
	{
		return TryLoad(null, P_0);
	}
}
