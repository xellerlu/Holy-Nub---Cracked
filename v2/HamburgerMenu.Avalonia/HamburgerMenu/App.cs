using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Layout;
using Avalonia.Markup.Xaml.XamlIl.Runtime;
using Avalonia.Styling;
using Avalonia.Themes.Fluent;
using Avalonia.Threading;
using CompiledAvaloniaXaml;
using HamburgerMenu.Services;

namespace HamburgerMenu;

[CompilerGenerated]
public class App : Application
{
	private static Action<object> _0021XamlIlPopulateOverride;

	public override void Initialize()
	{
		_0021XamlIlPopulateTrampoline(this);
	}

	public override void OnFrameworkInitializationCompleted()
	{
		IApplicationLifetime applicationLifetime = base.ApplicationLifetime;
		IClassicDesktopStyleApplicationLifetime desktop = applicationLifetime as IClassicDesktopStyleApplicationLifetime;
		if (desktop != null)
		{
			// [CRACK] LaunchGuard bypass — закомментирована проверка запуска из temp
			// if (!LaunchGuard.ValidateLaunch())
			// {
			// 	desktop.MainWindow = new Window
			// 	{
			// 		Title = "Error",
			// 		Width = 300.0,
			// 		Height = 100.0,
			// 		Content = new TextBlock
			// 		{
			// 			Text = "Please use the launcher to start this application.",
			// 			HorizontalAlignment = HorizontalAlignment.Center,
			// 			VerticalAlignment = VerticalAlignment.Center
			// 		}
			// 	};
			// 	Task.Delay(3000).ContinueWith(delegate
			// 	{
			// 		Dispatcher.UIThread.Post(delegate
			// 		{
			// 			desktop.Shutdown();
			// 		});
			// 	});
			// 	base.OnFrameworkInitializationCompleted();
			// 	return;
			// }
			// LaunchGuard.LockFiles();
			desktop.MainWindow = new MainWindow();
			// desktop.Exit += delegate
			// {
			// 	LaunchGuard.UnlockFiles();
			// };
		}
		base.OnFrameworkInitializationCompleted();
	}

	private static void _0021XamlIlPopulate(IServiceProvider P_0, App P_1)
	{
		CompiledAvaloniaXaml.XamlIlContext.Context<App> context = new CompiledAvaloniaXaml.XamlIlContext.Context<App>(P_0, new object[1] { _0021AvaloniaResources.NamespaceInfo_003A_002FApp_002Eaxaml.Singleton }, "avares://HamburgerMenu.Avalonia/App.axaml")
		{
			RootObject = P_1,
			IntermediateRoot = P_1
		};
		App app2;
		App app = (app2 = P_1);
		context.PushParent(app2);
		app2.RequestedThemeVariant = ThemeVariant.Dark;
		ResourceDictionary resourceDictionary;
		ResourceDictionary resources = (resourceDictionary = new ResourceDictionary());
		context.PushParent(resourceDictionary);
		resourceDictionary.MergedDictionaries.Add(_0021AvaloniaResources.Build_003A_002FStyles_002FImageResources_002Eaxaml(XamlIlRuntimeHelpers.CreateRootServiceProviderV3(context)));
		resourceDictionary.MergedDictionaries.Add(_0021AvaloniaResources.Build_003A_002FStyles_002FFontResources_002Eaxaml(XamlIlRuntimeHelpers.CreateRootServiceProviderV3(context)));
		resourceDictionary.MergedDictionaries.Add(_0021AvaloniaResources.Build_003A_002FStyles_002FColors_002Eaxaml(XamlIlRuntimeHelpers.CreateRootServiceProviderV3(context)));
		context.PopParent();
		app2.Resources = resources;
		app2.Styles.Add(new FluentTheme(context));
		app2.Styles.Add(_0021AvaloniaResources.Build_003A_002FStyles_002FButtonStyles_002Eaxaml(XamlIlRuntimeHelpers.CreateRootServiceProviderV3(context)));
		app2.Styles.Add(_0021AvaloniaResources.Build_003A_002FStyles_002FToggleButtonStyles_002Eaxaml(XamlIlRuntimeHelpers.CreateRootServiceProviderV3(context)));
		context.PopParent();
		if ((object)app is StyledElement styled)
		{
			NameScope.SetNameScope(styled, context.AvaloniaNameScope);
		}
		context.AvaloniaNameScope.Complete();
	}

	private static void _0021XamlIlPopulateTrampoline(App P_0)
	{
		if (_0021XamlIlPopulateOverride != null)
		{
			_0021XamlIlPopulateOverride(P_0);
		}
		else
		{
			_0021XamlIlPopulate(XamlIlRuntimeHelpers.CreateRootServiceProviderV3(null), P_0);
		}
	}
}
