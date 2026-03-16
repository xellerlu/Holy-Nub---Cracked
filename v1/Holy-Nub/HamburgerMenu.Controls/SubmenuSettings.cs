using Avalonia.Controls;

namespace HamburgerMenu.Controls;

public partial class SubmenuSettings : UserControl
{
    public SubmenuSettings()
    {
        InitializeComponent();
        DataContext = new SettingsViewModel();
    }
}
