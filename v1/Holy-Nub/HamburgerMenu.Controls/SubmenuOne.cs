using System;
using System.Diagnostics;
using System.IO;
using Avalonia.Controls;
using Avalonia.Threading;

namespace HamburgerMenu.Controls;

public partial class SubmenuOne : UserControl
{
    public SubmenuOne()
    {
        InitializeComponent();
    }

    private MainWindow? GetMainWindow() => TopLevel.GetTopLevel(this) as MainWindow;

    private void SubmenuOne_SelectionChanged(object? sender, SelectionChangedEventArgs e)
    {
        var mw = GetMainWindow();
        if (mw == null) return;

        foreach (var added in e.AddedItems)
        {
            if (added is ListBoxItem item && item.Tag is string tag)
            {
                mw.ShowSubmenuTwo();
                LaunchApp(tag);
            }
        }
    }

    private void LaunchApp(string appTag)
    {
        try
        {
            string baseDir = AppDomain.CurrentDomain.BaseDirectory;
            string appsDir = Path.Combine(baseDir, "Apps");
            string? exePath = appTag switch
            {
                "ActivityViewer" => FindExe(appsDir, "ActivityViewer"),
                "JournalWindows" => FindExe(appsDir, "JournalWindows"),
                "SystemInformer" => FindExe(appsDir, "SystemInformer"),
                "RegistryAnalyzer" => FindExe(appsDir, "RegistryAnalyzer"),
                "Everything" => FindExe(appsDir, "Everything"),
                _ => null
            };

            if (exePath != null && File.Exists(exePath))
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = exePath,
                    UseShellExecute = true
                });
            }
        }
        catch { }
    }

    private string? FindExe(string appsDir, string name)
    {
        string dir = Path.Combine(appsDir, name);
        if (Directory.Exists(dir))
        {
            foreach (var f in Directory.GetFiles(dir, "*.exe"))
                return f;
        }
        return Path.Combine(appsDir, name + ".exe");
    }

    public void UnselectAccount()
    {
        SubmenuOne_ListBox.SelectedItem = null;
    }
}
