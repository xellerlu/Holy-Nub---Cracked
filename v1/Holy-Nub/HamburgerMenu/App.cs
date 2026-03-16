using System;
using System.Threading.Tasks;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Layout;
using Avalonia.Markup.Xaml;
using Avalonia.Threading;
using HamburgerMenu.Services;

namespace HamburgerMenu;

public class App : Application
{
    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
    }

    public override void OnFrameworkInitializationCompleted()
    {
        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            // [CRACK] LaunchGuard disabled - original checks:
            //   1. App must run from %TEMP%\.hm_* directory
            //   2. Parent process must be holy-nub/dotnet/devenv/rider64/code
            //   3. Locks Holy-Nub.exe, Holy-Nub.dll, HamburgerMenu.Shared.dll
            // if (!LaunchGuard.ValidateLaunch())
            // {
            //     desktop.MainWindow = new Window
            //     {
            //         Title = "Error",
            //         Width = 300,
            //         Height = 100,
            //         Content = new TextBlock
            //         {
            //             Text = "Please use the launcher to start this application.",
            //             HorizontalAlignment = HorizontalAlignment.Center,
            //             VerticalAlignment = VerticalAlignment.Center
            //         }
            //     };
            //     Task.Delay(3000).ContinueWith(_ =>
            //     {
            //         Dispatcher.UIThread.Post(() => desktop.Shutdown());
            //     });
            //     base.OnFrameworkInitializationCompleted();
            //     return;
            // }
            // LaunchGuard.LockFiles();
            desktop.MainWindow = new MainWindow();
            // desktop.Exit += (_, _) => LaunchGuard.UnlockFiles();
        }
        base.OnFrameworkInitializationCompleted();
    }
}
