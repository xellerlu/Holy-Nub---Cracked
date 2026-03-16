using System.Threading.Tasks;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;
using Avalonia.Media.Transformation;
using Avalonia.Threading;
using HamburgerMenu.Controls;

namespace HamburgerMenu;

public partial class MainWindow : Window
{
    private bool _isMaximized;
    private PixelPoint _restorePosition;
    private Size _restoreSize;

    public MainWindow()
    {
        InitializeComponent();
        Loaded += OnWindowLoaded;
        var grid = this.FindControl<Grid>("MainGrid");
        if (grid != null)
        {
            grid.PointerPressed += OnMainPanelPointerPressed;
            grid.DoubleTapped += OnMainPanelDoubleTapped;
        }
    }

    private async void OnWindowLoaded(object? sender, RoutedEventArgs e)
    {
        SubmenuOne_UC.IsVisible = false;
        SubmenuTwo_UC.IsVisible = false;
        SubmenuAccounts_UC.IsVisible = false;
        SubmenuAnalytics_UC.IsVisible = false;
        SubmenuSettings_UC.IsVisible = false;
        IsEnabled = false;
        await Task.Delay(3800);
        Logo.Opacity = 1.0;
        await Task.Delay(2000);
        Logo.Opacity = 0.0;
        await Task.Delay(2000);
        IsEnabled = true;
    }

    private void OnMainPanelPointerPressed(object? sender, PointerPressedEventArgs e)
    {
        if (e.GetCurrentPoint(this).Properties.IsLeftButtonPressed)
        {
            CloseAllMenus();
            BeginMoveDrag(e);
        }
    }

    private void OnMainPanelDoubleTapped(object? sender, TappedEventArgs e)
    {
        ToggleWindowState();
    }

    public void ToggleWindowState()
    {
        if (!_isMaximized)
        {
            _restorePosition = Position;
            _restoreSize = new Size(Width, Height);
            var primary = Screens.Primary;
            if (primary != null)
            {
                Position = new PixelPoint(0, 0);
                Width = primary.WorkingArea.Width;
                Height = primary.WorkingArea.Height;
            }
            Window_Edge.IsVisible = false;
            _isMaximized = true;
        }
        else
        {
            Position = _restorePosition;
            Width = _restoreSize.Width;
            Height = _restoreSize.Height;
            Window_Edge.IsVisible = true;
            _isMaximized = false;
        }
    }

    private void CloseAllMenus()
    {
        SubmenuOne_UC?.UnselectAccount();
        MainMenu_UC?.UncheckMenuToggle();
        MainMenu_UC?.UnselectAppsSidePanel();
        MainMenu_UC?.UnselectAccountsSidePanel();
        HideSubmenuAccounts();
        HideSubmenuAnalytics();
        HideSubmenuSettings();
    }

    public void ShowSubmenuOne()
    {
        SubmenuOne_UC.RenderTransform = TransformOperations.Parse("translateY(800px)");
        SubmenuOne_UC.IsVisible = true;
        Dispatcher.UIThread.Post(() =>
        {
            SubmenuOne_UC.RenderTransform = TransformOperations.Parse("translateY(0)");
        }, DispatcherPriority.Background);
    }

    public void HideSubmenuOne()
    {
        if (SubmenuOne_UC.IsVisible)
        {
            SubmenuOne_UC.RenderTransform = TransformOperations.Parse("translateY(800px)");
            Dispatcher.UIThread.Post(async () =>
            {
                await Task.Delay(800);
                SubmenuOne_UC.IsVisible = false;
            }, DispatcherPriority.Background);
        }
    }

    public void ShowSubmenuTwo()
    {
        SubmenuTwo_UC.RenderTransform = TransformOperations.Parse("translateX(300px)");
        SubmenuTwo_UC.Opacity = 0.0;
        SubmenuTwo_UC.IsVisible = true;
        Dispatcher.UIThread.Post(() =>
        {
            SubmenuTwo_UC.RenderTransform = TransformOperations.Parse("translateX(0)");
            SubmenuTwo_UC.Opacity = 1.0;
        }, DispatcherPriority.Background);
    }

    public void HideSubmenuTwo()
    {
        if (SubmenuTwo_UC.IsVisible)
        {
            SubmenuTwo_UC.RenderTransform = TransformOperations.Parse("translateX(300px)");
            SubmenuTwo_UC.Opacity = 0.0;
            Dispatcher.UIThread.Post(async () =>
            {
                await Task.Delay(800);
                SubmenuTwo_UC.IsVisible = false;
            }, DispatcherPriority.Background);
        }
    }

    public void ShowSubmenuAccounts()
    {
        SubmenuAccounts_UC.RenderTransform = TransformOperations.Parse("translateY(800px)");
        SubmenuAccounts_UC.IsVisible = true;
        Dispatcher.UIThread.Post(() =>
        {
            SubmenuAccounts_UC.RenderTransform = TransformOperations.Parse("translateY(0)");
        }, DispatcherPriority.Background);
    }

    public void HideSubmenuAccounts()
    {
        if (SubmenuAccounts_UC.IsVisible)
        {
            SubmenuAccounts_UC.RenderTransform = TransformOperations.Parse("translateY(800px)");
            Dispatcher.UIThread.Post(async () =>
            {
                await Task.Delay(800);
                SubmenuAccounts_UC.IsVisible = false;
            }, DispatcherPriority.Background);
        }
    }

    public void ShowSubmenuAnalytics()
    {
        SubmenuAnalytics_UC.RenderTransform = TransformOperations.Parse("translateY(800px)");
        SubmenuAnalytics_UC.IsVisible = true;
        Dispatcher.UIThread.Post(() =>
        {
            SubmenuAnalytics_UC.RenderTransform = TransformOperations.Parse("translateY(0)");
        }, DispatcherPriority.Background);
    }

    public void HideSubmenuAnalytics()
    {
        if (SubmenuAnalytics_UC.IsVisible)
        {
            SubmenuAnalytics_UC.RenderTransform = TransformOperations.Parse("translateY(800px)");
            Dispatcher.UIThread.Post(async () =>
            {
                await Task.Delay(800);
                SubmenuAnalytics_UC.IsVisible = false;
            }, DispatcherPriority.Background);
        }
    }

    public void ShowSubmenuSettings()
    {
        SubmenuSettings_UC.RenderTransform = TransformOperations.Parse("translateY(800px)");
        SubmenuSettings_UC.IsVisible = true;
        Dispatcher.UIThread.Post(() =>
        {
            SubmenuSettings_UC.RenderTransform = TransformOperations.Parse("translateY(0)");
        }, DispatcherPriority.Background);
    }

    public void HideSubmenuSettings()
    {
        if (SubmenuSettings_UC.IsVisible)
        {
            SubmenuSettings_UC.RenderTransform = TransformOperations.Parse("translateY(800px)");
            Dispatcher.UIThread.Post(async () =>
            {
                await Task.Delay(800);
                SubmenuSettings_UC.IsVisible = false;
            }, DispatcherPriority.Background);
        }
    }
}
