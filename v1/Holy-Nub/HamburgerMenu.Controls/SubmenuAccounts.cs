using Avalonia.Controls;

namespace HamburgerMenu.Controls;

public partial class SubmenuAccounts : UserControl
{
    public SubmenuAccounts()
    {
        InitializeComponent();
        DataContext = new AccountsViewModel();
    }
}
