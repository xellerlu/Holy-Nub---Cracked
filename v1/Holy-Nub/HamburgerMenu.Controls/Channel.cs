using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Media;

namespace HamburgerMenu.Controls;

public partial class Channel : UserControl
{
    public Channel()
    {
        InitializeComponent();
        Loaded += OnLoaded;
    }

    private void OnLoaded(object? sender, RoutedEventArgs e)
    {
        if (Level0 != null)
            Level0.RenderTransform = new TranslateTransform(0, 0);
    }
}
