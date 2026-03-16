using System.Threading.Tasks;
using Avalonia.Controls;
using Avalonia.Controls.Shapes;
using Avalonia.Input.Platform;
using Avalonia.Interactivity;
using Avalonia.Media;

namespace HamburgerMenu.Controls;

public partial class MainMenu : UserControl
{
    private bool _isMenuExpanded;

    public MainMenu()
    {
        InitializeComponent();
        Loaded += OnLoaded;
    }

    private void OnLoaded(object? sender, RoutedEventArgs e)
    {
        Menu_Status.RenderTransform = new TranslateTransform(0, 0);
        Menu_Base.RenderTransform = new TranslateTransform(0, 0);
        Menu_Container.RenderTransform = new TranslateTransform(0, 0);
    }

    private async void CopyServer_Click(object? sender, RoutedEventArgs e)
    {
        if (sender is not Button button) return;
        if (button.Tag is string serverCmd)
        {
            var clipboard = TopLevel.GetTopLevel(this)?.Clipboard;
            if (clipboard != null)
            {
                await clipboard.SetTextAsync(serverCmd);
                CopyStatus.Text = "Copied: " + serverCmd;
                CopyStatus.Opacity = 1;
                await Task.Delay(2000);
                CopyStatus.Opacity = 0;
            }
        }
    }

    private void Menu_ToggleButton_Checked(object? sender, RoutedEventArgs e)
    {
        _isMenuExpanded = true;
        Menu_Container.Width = 210;
        SideBar_Container.IsVisible = false;
        SidePanel_Container.IsVisible = true;
        UpdateStatusIndicators();
    }

    private void Menu_ToggleButton_Unchecked(object? sender, RoutedEventArgs e)
    {
        _isMenuExpanded = false;
        Menu_Container.Width = 50;
        SideBar_Container.IsVisible = true;
        SidePanel_Container.IsVisible = false;
        UpdateStatusIndicators();
    }

    private void UpdateStatusIndicators()
    {
        SideBar_Active.Fill = _isMenuExpanded
            ? new SolidColorBrush(Color.Parse("#5B5B5B"))
            : new SolidColorBrush(Color.Parse("#FF8C00"));
        SidePanel_Active.Fill = _isMenuExpanded
            ? new SolidColorBrush(Color.Parse("#FF8C00"))
            : new SolidColorBrush(Color.Parse("#5B5B5B"));
    }

    public void UncheckMenuToggle() => Menu_ToggleButton.IsChecked = false;
    public void UnselectAppsSidePanel() => SidePanel_UC?.UnselectApps();
    public void UnselectAccountsSidePanel() => SidePanel_UC?.UnselectAccounts();
}
