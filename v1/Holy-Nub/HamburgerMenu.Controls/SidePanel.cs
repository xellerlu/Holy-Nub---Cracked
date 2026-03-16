using Avalonia.Controls;

namespace HamburgerMenu.Controls;

public partial class SidePanel : UserControl
{
    public SidePanel()
    {
        InitializeComponent();
    }

    private MainWindow? GetMainWindow() => TopLevel.GetTopLevel(this) as MainWindow;

    private void SidePanel_SelectionChanged(object? sender, SelectionChangedEventArgs e)
    {
        var mw = GetMainWindow();
        if (mw == null) return;

        foreach (var removed in e.RemovedItems)
        {
            if (removed == Apps_ListBoxItem) { mw.HideSubmenuOne(); mw.Track_One?.CloseTrackOne(); }
            if (removed == Accounts_ListBoxItem) mw.HideSubmenuAccounts();
            if (removed == Analytics_ListBoxItem) mw.HideSubmenuAnalytics();
            if (removed == Settings_ListBoxItem) mw.HideSubmenuSettings();
        }
        foreach (var added in e.AddedItems)
        {
            if (added == Apps_ListBoxItem) { mw.ShowSubmenuOne(); mw.Track_One?.OpenTrackOne(); }
            if (added == Accounts_ListBoxItem) mw.ShowSubmenuAccounts();
            if (added == Analytics_ListBoxItem) mw.ShowSubmenuAnalytics();
            if (added == Settings_ListBoxItem) mw.ShowSubmenuSettings();
        }
    }

    public void UnselectApps() => SidePanel_ListBox.SelectedItem = null;

    public void UnselectAccounts()
    {
        if (SidePanel_ListBox.SelectedItem == Accounts_ListBoxItem)
            SidePanel_ListBox.SelectedItem = null;
    }
}
