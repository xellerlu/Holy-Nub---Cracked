using Avalonia.Controls;

namespace HamburgerMenu.Controls;

public partial class SubmenuAnalytics : UserControl
{
    public SubmenuAnalytics()
    {
        InitializeComponent();
        DataContext = new AnalyticsViewModel();
    }
}
