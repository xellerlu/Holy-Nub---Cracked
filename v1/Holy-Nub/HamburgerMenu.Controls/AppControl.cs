using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Media;

namespace HamburgerMenu.Controls;

public partial class AppControl : UserControl
{
    public AppControl()
    {
        InitializeComponent();
        Loaded += OnLoaded;
    }

    private void OnLoaded(object? sender, RoutedEventArgs e)
    {
        Control_Header.RenderTransform = new TranslateTransform(0, 0);
        Control_Footer.RenderTransform = new TranslateTransform(0, 0);
    }

    private MainWindow? GetMainWindow() => TopLevel.GetTopLevel(this) as MainWindow;

    private void App_Minimize_Click(object? sender, RoutedEventArgs e)
    {
        var mw = GetMainWindow();
        if (mw != null) mw.WindowState = WindowState.Minimized;
    }

    private void App_Maximize_Click(object? sender, RoutedEventArgs e)
    {
        GetMainWindow()?.ToggleWindowState();
    }

    private void App_ShutDown_Click(object? sender, RoutedEventArgs e)
    {
        GetMainWindow()?.Close();
    }
}
