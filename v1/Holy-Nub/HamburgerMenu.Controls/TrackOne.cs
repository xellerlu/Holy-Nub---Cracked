using System.Threading.Tasks;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Media;

namespace HamburgerMenu.Controls;

public partial class TrackOne : UserControl
{
    public TrackOne()
    {
        InitializeComponent();
        Loaded += OnLoaded;
    }

    private void OnLoaded(object? sender, RoutedEventArgs e)
    {
        Submenu_Out.RenderTransform = new TranslateTransform(0, 0);
        Submenu_In.RenderTransform = new TranslateTransform(0, 0);
    }

    public async void OpenTrackOne()
    {
        for (int i = 0; i < 3; i++)
        {
            T1_Open.Opacity = 0;
            await Task.Delay(100);
            T1_Open.Opacity = 1;
            await Task.Delay(100);
        }
    }

    public async void CloseTrackOne()
    {
        for (int i = 0; i < 3; i++)
        {
            T1_Close.Opacity = 0;
            await Task.Delay(100);
            T1_Close.Opacity = 1;
            await Task.Delay(100);
        }
    }
}
