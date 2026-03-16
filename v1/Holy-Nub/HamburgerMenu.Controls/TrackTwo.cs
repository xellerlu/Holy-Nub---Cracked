using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Media;

namespace HamburgerMenu.Controls;

public partial class TrackTwo : UserControl
{
    public TrackTwo()
    {
        InitializeComponent();
        Loaded += OnLoaded;
    }

    private void OnLoaded(object? sender, RoutedEventArgs e)
    {
        TrackTwo_Border.RenderTransform = new TranslateTransform(0, 0);
    }
}
