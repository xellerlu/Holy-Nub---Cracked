using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Avalonia;
using Avalonia.Animation;
using Avalonia.Animation.Easings;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;
using Avalonia.Layout;
using Avalonia.Markup.Xaml.MarkupExtensions;
using Avalonia.Markup.Xaml.XamlIl.Runtime;
using Avalonia.Media;
using Avalonia.Media.Immutable;
using Avalonia.Media.Transformation;
using Avalonia.Platform;
using Avalonia.Styling;
using Avalonia.Threading;
using CompiledAvaloniaXaml;
using HamburgerMenu.Controls;

namespace HamburgerMenu;

[CompilerGenerated]
public class MainWindow : Window
{
	private bool _isMaximized;

	private PixelPoint _restorePosition;

	private Size _restoreSize;

	[GeneratedCode("Avalonia.Generators.NameGenerator.InitializeComponentCodeGenerator", "11.2.1.0")]
	internal Grid MainGrid;

	[GeneratedCode("Avalonia.Generators.NameGenerator.InitializeComponentCodeGenerator", "11.2.1.0")]
	internal Image Logo;

	[GeneratedCode("Avalonia.Generators.NameGenerator.InitializeComponentCodeGenerator", "11.2.1.0")]
	internal Channel Channel_UC;

	[GeneratedCode("Avalonia.Generators.NameGenerator.InitializeComponentCodeGenerator", "11.2.1.0")]
	internal MainMenu MainMenu_UC;

	[GeneratedCode("Avalonia.Generators.NameGenerator.InitializeComponentCodeGenerator", "11.2.1.0")]
	internal TrackOne Track_One;

	[GeneratedCode("Avalonia.Generators.NameGenerator.InitializeComponentCodeGenerator", "11.2.1.0")]
	internal Grid ContentArea;

	[GeneratedCode("Avalonia.Generators.NameGenerator.InitializeComponentCodeGenerator", "11.2.1.0")]
	internal SubmenuOne SubmenuOne_UC;

	[GeneratedCode("Avalonia.Generators.NameGenerator.InitializeComponentCodeGenerator", "11.2.1.0")]
	internal SubmenuCustomer SubmenuCustomer_UC;

	[GeneratedCode("Avalonia.Generators.NameGenerator.InitializeComponentCodeGenerator", "11.2.1.0")]
	internal SubmenuAnalytics SubmenuAnalytics_UC;

	[GeneratedCode("Avalonia.Generators.NameGenerator.InitializeComponentCodeGenerator", "11.2.1.0")]
	internal SubmenuSettings SubmenuSettings_UC;

	[GeneratedCode("Avalonia.Generators.NameGenerator.InitializeComponentCodeGenerator", "11.2.1.0")]
	internal SubmenuTwo SubmenuTwo_UC;

	[GeneratedCode("Avalonia.Generators.NameGenerator.InitializeComponentCodeGenerator", "11.2.1.0")]
	internal TrackTwo Track_Two;

	[GeneratedCode("Avalonia.Generators.NameGenerator.InitializeComponentCodeGenerator", "11.2.1.0")]
	internal Border Window_Edge;

	private static Action<object> _0021XamlIlPopulateOverride;

	public MainWindow()
	{
		InitializeComponent();
		base.Loaded += OnWindowLoaded;
		Grid grid = this.FindControl<Grid>("MainGrid");
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
		SubmenuCustomer_UC.IsVisible = false;
		SubmenuAnalytics_UC.IsVisible = false;
		SubmenuSettings_UC.IsVisible = false;
		base.IsEnabled = false;
		await Task.Delay(3800);
		Logo.Opacity = 1.0;
		await Task.Delay(2000);
		Logo.Opacity = 0.0;
		await Task.Delay(2000);
		base.IsEnabled = true;
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
			_restorePosition = base.Position;
			_restoreSize = new Size(base.Width, base.Height);
			Screen primary = base.Screens.Primary;
			if (primary != null)
			{
				base.Position = new PixelPoint(0, 0);
				base.Width = primary.WorkingArea.Width;
				base.Height = primary.WorkingArea.Height;
			}
			Window_Edge.IsVisible = false;
			_isMaximized = true;
		}
		else
		{
			base.Position = _restorePosition;
			base.Width = _restoreSize.Width;
			base.Height = _restoreSize.Height;
			Window_Edge.IsVisible = true;
			_isMaximized = false;
		}
	}

	private void CloseAllMenus()
	{
		SubmenuOne_UC?.UnselectAccount();
		MainMenu_UC?.UncheckMenuToggle();
		MainMenu_UC?.UnselectAppsSidePanel();
		MainMenu_UC?.UnselectCustomerSidePanel();
		HideSubmenuCustomer();
		HideSubmenuAnalytics();
		HideSubmenuSettings();
	}

	public void ShowSubmenuOne()
	{
		SubmenuOne_UC.RenderTransform = TransformOperations.Parse("translateY(800px)");
		SubmenuOne_UC.IsVisible = true;
		Dispatcher.UIThread.Post(delegate
		{
			SubmenuOne_UC.RenderTransform = TransformOperations.Parse("translateY(0)");
		}, DispatcherPriority.Background);
	}

	public void HideSubmenuOne()
	{
		if (SubmenuOne_UC.IsVisible)
		{
			SubmenuOne_UC.RenderTransform = TransformOperations.Parse("translateY(800px)");
			Dispatcher.UIThread.Post(async delegate
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
		Dispatcher.UIThread.Post(delegate
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
			Dispatcher.UIThread.Post(async delegate
			{
				await Task.Delay(800);
				SubmenuTwo_UC.IsVisible = false;
			}, DispatcherPriority.Background);
		}
	}

	public void ShowSubmenuCustomer()
	{
		SubmenuCustomer_UC.RenderTransform = TransformOperations.Parse("translateY(800px)");
		SubmenuCustomer_UC.IsVisible = true;
		Dispatcher.UIThread.Post(delegate
		{
			SubmenuCustomer_UC.RenderTransform = TransformOperations.Parse("translateY(0)");
		}, DispatcherPriority.Background);
	}

	public void HideSubmenuCustomer()
	{
		if (SubmenuCustomer_UC.IsVisible)
		{
			SubmenuCustomer_UC.RenderTransform = TransformOperations.Parse("translateY(800px)");
			Dispatcher.UIThread.Post(async delegate
			{
				await Task.Delay(800);
				SubmenuCustomer_UC.IsVisible = false;
			}, DispatcherPriority.Background);
		}
	}

	public void ShowSubmenuAnalytics()
	{
		SubmenuAnalytics_UC.RenderTransform = TransformOperations.Parse("translateY(800px)");
		SubmenuAnalytics_UC.IsVisible = true;
		Dispatcher.UIThread.Post(delegate
		{
			SubmenuAnalytics_UC.RenderTransform = TransformOperations.Parse("translateY(0)");
		}, DispatcherPriority.Background);
	}

	public void HideSubmenuAnalytics()
	{
		if (SubmenuAnalytics_UC.IsVisible)
		{
			SubmenuAnalytics_UC.RenderTransform = TransformOperations.Parse("translateY(800px)");
			Dispatcher.UIThread.Post(async delegate
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
		Dispatcher.UIThread.Post(delegate
		{
			SubmenuSettings_UC.RenderTransform = TransformOperations.Parse("translateY(0)");
		}, DispatcherPriority.Background);
	}

	public void HideSubmenuSettings()
	{
		if (SubmenuSettings_UC.IsVisible)
		{
			SubmenuSettings_UC.RenderTransform = TransformOperations.Parse("translateY(800px)");
			Dispatcher.UIThread.Post(async delegate
			{
				await Task.Delay(800);
				SubmenuSettings_UC.IsVisible = false;
			}, DispatcherPriority.Background);
		}
	}

	[GeneratedCode("Avalonia.Generators.NameGenerator.InitializeComponentCodeGenerator", "11.2.1.0")]
	[ExcludeFromCodeCoverage]
	public void InitializeComponent(bool loadXaml = true)
	{
		if (loadXaml)
		{
			_0021XamlIlPopulateTrampoline(this);
		}
		INameScope nameScope = this.FindNameScope();
		MainGrid = nameScope?.Find<Grid>("MainGrid");
		Logo = nameScope?.Find<Image>("Logo");
		Channel_UC = nameScope?.Find<Channel>("Channel_UC");
		MainMenu_UC = nameScope?.Find<MainMenu>("MainMenu_UC");
		Track_One = nameScope?.Find<TrackOne>("Track_One");
		ContentArea = nameScope?.Find<Grid>("ContentArea");
		SubmenuOne_UC = nameScope?.Find<SubmenuOne>("SubmenuOne_UC");
		SubmenuCustomer_UC = nameScope?.Find<SubmenuCustomer>("SubmenuCustomer_UC");
		SubmenuAnalytics_UC = nameScope?.Find<SubmenuAnalytics>("SubmenuAnalytics_UC");
		SubmenuSettings_UC = nameScope?.Find<SubmenuSettings>("SubmenuSettings_UC");
		SubmenuTwo_UC = nameScope?.Find<SubmenuTwo>("SubmenuTwo_UC");
		Track_Two = nameScope?.Find<TrackTwo>("Track_Two");
		Window_Edge = nameScope?.Find<Border>("Window_Edge");
	}

	private static void _0021XamlIlPopulate(IServiceProvider P_0, MainWindow P_1)
	{
		CompiledAvaloniaXaml.XamlIlContext.Context<MainWindow> context = new CompiledAvaloniaXaml.XamlIlContext.Context<MainWindow>(P_0, new object[1] { _0021AvaloniaResources.NamespaceInfo_003A_002FMainWindow_002Eaxaml.Singleton }, "avares://HamburgerMenu.Avalonia/MainWindow.axaml")
		{
			RootObject = P_1,
			IntermediateRoot = P_1
		};
		((ISupportInitialize)P_1).BeginInit();
		context.PushParent(P_1);
		P_1.Title = "Holy-Nub";
		P_1.Width = 980.0;
		P_1.Height = 700.0;
		P_1.MinWidth = 800.0;
		P_1.MinHeight = 600.0;
		P_1.Background = new ImmutableSolidColorBrush(4280558628u);
		P_1.WindowStartupLocation = WindowStartupLocation.CenterScreen;
		P_1.ExtendClientAreaToDecorationsHint = true;
		P_1.ExtendClientAreaChromeHints = ExtendClientAreaChromeHints.NoChrome;
		P_1.ExtendClientAreaTitleBarHeightHint = -1.0;
		P_1.CanResize = true;
		Styles styles = P_1.Styles;
		Style style = new Style();
		style.Selector = ((Selector?)null).OfType(typeof(Border)).Class("WindowEdge");
		Setter setter = new Setter();
		setter.Property = Border.BorderBrushProperty;
		setter.Value = new ImmutableSolidColorBrush(16777215u);
		style.Add(setter);
		Setter setter2 = new Setter();
		setter2.Property = Border.BorderThicknessProperty;
		setter2.Value = new Thickness(0.0, 0.0, 0.0, 0.0);
		style.Add(setter2);
		Setter setter3 = new Setter();
		setter3.Property = Layoutable.HorizontalAlignmentProperty;
		setter3.Value = HorizontalAlignment.Stretch;
		style.Add(setter3);
		Setter setter4 = new Setter();
		setter4.Property = Layoutable.VerticalAlignmentProperty;
		setter4.Value = VerticalAlignment.Stretch;
		style.Add(setter4);
		styles.Add(style);
		Grid grid2;
		Grid grid = (grid2 = new Grid());
		((ISupportInitialize)grid).BeginInit();
		P_1.Content = grid;
		Grid grid4;
		Grid grid3 = (grid4 = grid2);
		context.PushParent(grid4);
		Grid grid5 = grid4;
		grid5.Name = "MainGrid";
		object element = grid5;
		context.AvaloniaNameScope.Register("MainGrid", element);
		grid5.ColumnDefinitions.Add(new ColumnDefinition
		{
			Width = new GridLength(250.0, GridUnitType.Pixel)
		});
		grid5.ColumnDefinitions.Add(new ColumnDefinition
		{
			Width = new GridLength(1.0, GridUnitType.Star)
		});
		grid5.ColumnDefinitions.Add(new ColumnDefinition
		{
			Width = new GridLength(52.0, GridUnitType.Pixel)
		});
		grid5.RowDefinitions.Add(new RowDefinition
		{
			Height = new GridLength(95.0, GridUnitType.Pixel)
		});
		grid5.RowDefinitions.Add(new RowDefinition
		{
			Height = new GridLength(1.0, GridUnitType.Star)
		});
		grid5.RowDefinitions.Add(new RowDefinition
		{
			Height = new GridLength(95.0, GridUnitType.Pixel)
		});
		Avalonia.Controls.Controls children = grid5.Children;
		Border border2;
		Border border = (border2 = new Border());
		((ISupportInitialize)border).BeginInit();
		children.Add(border);
		Border border4;
		Border border3 = (border4 = border2);
		context.PushParent(border4);
		Grid.SetColumnSpan(border4, 3);
		Grid.SetRowSpan(border4, 3);
		border4.Background = new ImmutableSolidColorBrush(4280558628u);
		border4.ZIndex = 0;
		Image image2;
		Image image = (image2 = new Image());
		((ISupportInitialize)image).BeginInit();
		border4.Child = image;
		Image image4;
		Image image3 = (image4 = image2);
		context.PushParent(image4);
		image4.Name = "Logo";
		element = image4;
		context.AvaloniaNameScope.Register("Logo", element);
		StaticResourceExtension staticResourceExtension = new StaticResourceExtension("Logo_1");
		context.ProvideTargetProperty = Image.SourceProperty;
		object? obj = staticResourceExtension.ProvideValue(context);
		context.ProvideTargetProperty = null;
		CompiledAvaloniaXaml.XamlDynamicSetters._003C_003EXamlDynamicSetter_1(image4, obj);
		image4.Width = 150.0;
		image4.Height = 150.0;
		image4.Stretch = Stretch.Uniform;
		image4.HorizontalAlignment = HorizontalAlignment.Center;
		image4.VerticalAlignment = VerticalAlignment.Center;
		image4.Margin = new Thickness(0.0, 0.0, 10.0, 20.0);
		image4.Opacity = 0.0;
		Transitions transitions = new Transitions();
		DoubleTransition doubleTransition = new DoubleTransition();
		doubleTransition.Property = Visual.OpacityProperty;
		doubleTransition.Duration = TimeSpan.FromTicks(20000000L);
		doubleTransition.Easing = Easing.Parse("CircularEaseOut");
		transitions.Add(doubleTransition);
		image4.Transitions = transitions;
		context.PopParent();
		((ISupportInitialize)image3).EndInit();
		context.PopParent();
		((ISupportInitialize)border3).EndInit();
		Avalonia.Controls.Controls children2 = grid5.Children;
		Channel channel2;
		Channel channel = (channel2 = new Channel());
		((ISupportInitialize)channel).BeginInit();
		children2.Add(channel);
		channel2.Name = "Channel_UC";
		element = channel2;
		context.AvaloniaNameScope.Register("Channel_UC", element);
		Grid.SetColumn(channel2, 1);
		Grid.SetColumnSpan(channel2, 2);
		Grid.SetRow(channel2, 0);
		channel2.HorizontalAlignment = HorizontalAlignment.Right;
		channel2.VerticalAlignment = VerticalAlignment.Top;
		channel2.ZIndex = 4;
		((ISupportInitialize)channel2).EndInit();
		Avalonia.Controls.Controls children3 = grid5.Children;
		MainMenu mainMenu2;
		MainMenu mainMenu = (mainMenu2 = new MainMenu());
		((ISupportInitialize)mainMenu).BeginInit();
		children3.Add(mainMenu);
		mainMenu2.Name = "MainMenu_UC";
		element = mainMenu2;
		context.AvaloniaNameScope.Register("MainMenu_UC", element);
		Grid.SetColumn(mainMenu2, 0);
		Grid.SetRowSpan(mainMenu2, 3);
		mainMenu2.ZIndex = 3;
		((ISupportInitialize)mainMenu2).EndInit();
		Avalonia.Controls.Controls children4 = grid5.Children;
		TrackOne trackOne2;
		TrackOne trackOne = (trackOne2 = new TrackOne());
		((ISupportInitialize)trackOne).BeginInit();
		children4.Add(trackOne);
		trackOne2.Name = "Track_One";
		element = trackOne2;
		context.AvaloniaNameScope.Register("Track_One", element);
		Grid.SetColumn(trackOne2, 1);
		Grid.SetRowSpan(trackOne2, 3);
		trackOne2.ZIndex = 1;
		((ISupportInitialize)trackOne2).EndInit();
		Avalonia.Controls.Controls children5 = grid5.Children;
		Grid grid7;
		Grid grid6 = (grid7 = new Grid());
		((ISupportInitialize)grid6).BeginInit();
		children5.Add(grid6);
		Grid grid8 = (grid4 = grid7);
		context.PushParent(grid4);
		Grid grid9 = grid4;
		grid9.Name = "ContentArea";
		element = grid9;
		context.AvaloniaNameScope.Register("ContentArea", element);
		Grid.SetColumn(grid9, 1);
		Grid.SetRow(grid9, 1);
		grid9.ZIndex = 2;
		grid9.Margin = new Thickness(20.0, 0.0, 0.0, 0.0);
		grid9.ClipToBounds = true;
		Avalonia.Controls.Controls children6 = grid9.Children;
		SubmenuOne submenuOne2;
		SubmenuOne submenuOne = (submenuOne2 = new SubmenuOne());
		((ISupportInitialize)submenuOne).BeginInit();
		children6.Add(submenuOne);
		SubmenuOne submenuOne4;
		SubmenuOne submenuOne3 = (submenuOne4 = submenuOne2);
		context.PushParent(submenuOne4);
		submenuOne4.Name = "SubmenuOne_UC";
		element = submenuOne4;
		context.AvaloniaNameScope.Register("SubmenuOne_UC", element);
		submenuOne4.IsVisible = false;
		submenuOne4.HorizontalAlignment = HorizontalAlignment.Stretch;
		submenuOne4.VerticalAlignment = VerticalAlignment.Stretch;
		submenuOne4.Margin = new Thickness(0.0, 0.0, 80.0, 0.0);
		submenuOne4.RenderTransform = (ITransform)new TransformConverter().ConvertFrom(context, CultureInfo.InvariantCulture, "translateY(800px)");
		Transitions transitions2 = new Transitions();
		TransformOperationsTransition transformOperationsTransition = new TransformOperationsTransition();
		transformOperationsTransition.Property = Visual.RenderTransformProperty;
		transformOperationsTransition.Duration = TimeSpan.FromTicks(8000000L);
		transformOperationsTransition.Easing = Easing.Parse("CircularEaseOut");
		transitions2.Add(transformOperationsTransition);
		submenuOne4.Transitions = transitions2;
		context.PopParent();
		((ISupportInitialize)submenuOne3).EndInit();
		Avalonia.Controls.Controls children7 = grid9.Children;
		SubmenuCustomer submenuCustomer2;
		SubmenuCustomer submenuCustomer = (submenuCustomer2 = new SubmenuCustomer());
		((ISupportInitialize)submenuCustomer).BeginInit();
		children7.Add(submenuCustomer);
		SubmenuCustomer submenuCustomer4;
		SubmenuCustomer submenuCustomer3 = (submenuCustomer4 = submenuCustomer2);
		context.PushParent(submenuCustomer4);
		submenuCustomer4.Name = "SubmenuCustomer_UC";
		element = submenuCustomer4;
		context.AvaloniaNameScope.Register("SubmenuCustomer_UC", element);
		submenuCustomer4.IsVisible = false;
		submenuCustomer4.HorizontalAlignment = HorizontalAlignment.Stretch;
		submenuCustomer4.VerticalAlignment = VerticalAlignment.Stretch;
		submenuCustomer4.Margin = new Thickness(0.0, 0.0, 80.0, 0.0);
		submenuCustomer4.RenderTransform = (ITransform)new TransformConverter().ConvertFrom(context, CultureInfo.InvariantCulture, "translateY(800px)");
		Transitions transitions3 = new Transitions();
		TransformOperationsTransition transformOperationsTransition2 = new TransformOperationsTransition();
		transformOperationsTransition2.Property = Visual.RenderTransformProperty;
		transformOperationsTransition2.Duration = TimeSpan.FromTicks(8000000L);
		transformOperationsTransition2.Easing = Easing.Parse("CircularEaseOut");
		transitions3.Add(transformOperationsTransition2);
		submenuCustomer4.Transitions = transitions3;
		context.PopParent();
		((ISupportInitialize)submenuCustomer3).EndInit();
		Avalonia.Controls.Controls children8 = grid9.Children;
		SubmenuAnalytics submenuAnalytics2;
		SubmenuAnalytics submenuAnalytics = (submenuAnalytics2 = new SubmenuAnalytics());
		((ISupportInitialize)submenuAnalytics).BeginInit();
		children8.Add(submenuAnalytics);
		SubmenuAnalytics submenuAnalytics4;
		SubmenuAnalytics submenuAnalytics3 = (submenuAnalytics4 = submenuAnalytics2);
		context.PushParent(submenuAnalytics4);
		submenuAnalytics4.Name = "SubmenuAnalytics_UC";
		element = submenuAnalytics4;
		context.AvaloniaNameScope.Register("SubmenuAnalytics_UC", element);
		submenuAnalytics4.IsVisible = false;
		submenuAnalytics4.HorizontalAlignment = HorizontalAlignment.Stretch;
		submenuAnalytics4.VerticalAlignment = VerticalAlignment.Stretch;
		submenuAnalytics4.Margin = new Thickness(0.0, 0.0, 80.0, 0.0);
		submenuAnalytics4.RenderTransform = (ITransform)new TransformConverter().ConvertFrom(context, CultureInfo.InvariantCulture, "translateY(800px)");
		Transitions transitions4 = new Transitions();
		TransformOperationsTransition transformOperationsTransition3 = new TransformOperationsTransition();
		transformOperationsTransition3.Property = Visual.RenderTransformProperty;
		transformOperationsTransition3.Duration = TimeSpan.FromTicks(8000000L);
		transformOperationsTransition3.Easing = Easing.Parse("CircularEaseOut");
		transitions4.Add(transformOperationsTransition3);
		submenuAnalytics4.Transitions = transitions4;
		context.PopParent();
		((ISupportInitialize)submenuAnalytics3).EndInit();
		Avalonia.Controls.Controls children9 = grid9.Children;
		SubmenuSettings submenuSettings2;
		SubmenuSettings submenuSettings = (submenuSettings2 = new SubmenuSettings());
		((ISupportInitialize)submenuSettings).BeginInit();
		children9.Add(submenuSettings);
		SubmenuSettings submenuSettings4;
		SubmenuSettings submenuSettings3 = (submenuSettings4 = submenuSettings2);
		context.PushParent(submenuSettings4);
		submenuSettings4.Name = "SubmenuSettings_UC";
		element = submenuSettings4;
		context.AvaloniaNameScope.Register("SubmenuSettings_UC", element);
		submenuSettings4.IsVisible = false;
		submenuSettings4.HorizontalAlignment = HorizontalAlignment.Stretch;
		submenuSettings4.VerticalAlignment = VerticalAlignment.Stretch;
		submenuSettings4.Margin = new Thickness(0.0, 0.0, 80.0, 0.0);
		submenuSettings4.RenderTransform = (ITransform)new TransformConverter().ConvertFrom(context, CultureInfo.InvariantCulture, "translateY(800px)");
		Transitions transitions5 = new Transitions();
		TransformOperationsTransition transformOperationsTransition4 = new TransformOperationsTransition();
		transformOperationsTransition4.Property = Visual.RenderTransformProperty;
		transformOperationsTransition4.Duration = TimeSpan.FromTicks(8000000L);
		transformOperationsTransition4.Easing = Easing.Parse("CircularEaseOut");
		transitions5.Add(transformOperationsTransition4);
		submenuSettings4.Transitions = transitions5;
		context.PopParent();
		((ISupportInitialize)submenuSettings3).EndInit();
		Avalonia.Controls.Controls children10 = grid9.Children;
		SubmenuTwo submenuTwo2;
		SubmenuTwo submenuTwo = (submenuTwo2 = new SubmenuTwo());
		((ISupportInitialize)submenuTwo).BeginInit();
		children10.Add(submenuTwo);
		SubmenuTwo submenuTwo4;
		SubmenuTwo submenuTwo3 = (submenuTwo4 = submenuTwo2);
		context.PushParent(submenuTwo4);
		submenuTwo4.Name = "SubmenuTwo_UC";
		element = submenuTwo4;
		context.AvaloniaNameScope.Register("SubmenuTwo_UC", element);
		submenuTwo4.IsVisible = false;
		submenuTwo4.HorizontalAlignment = HorizontalAlignment.Right;
		submenuTwo4.VerticalAlignment = VerticalAlignment.Center;
		submenuTwo4.Margin = new Thickness(0.0, 0.0, 20.0, 0.0);
		submenuTwo4.RenderTransform = (ITransform)new TransformConverter().ConvertFrom(context, CultureInfo.InvariantCulture, "translateX(300px)");
		Transitions transitions6 = new Transitions();
		TransformOperationsTransition transformOperationsTransition5 = new TransformOperationsTransition();
		transformOperationsTransition5.Property = Visual.RenderTransformProperty;
		transformOperationsTransition5.Duration = TimeSpan.FromTicks(8000000L);
		transformOperationsTransition5.Easing = Easing.Parse("CircularEaseOut");
		transitions6.Add(transformOperationsTransition5);
		DoubleTransition doubleTransition2 = new DoubleTransition();
		doubleTransition2.Property = Visual.OpacityProperty;
		doubleTransition2.Duration = TimeSpan.FromTicks(8000000L);
		transitions6.Add(doubleTransition2);
		submenuTwo4.Transitions = transitions6;
		context.PopParent();
		((ISupportInitialize)submenuTwo3).EndInit();
		context.PopParent();
		((ISupportInitialize)grid8).EndInit();
		Avalonia.Controls.Controls children11 = grid5.Children;
		TrackTwo trackTwo2;
		TrackTwo trackTwo = (trackTwo2 = new TrackTwo());
		((ISupportInitialize)trackTwo).BeginInit();
		children11.Add(trackTwo);
		trackTwo2.Name = "Track_Two";
		element = trackTwo2;
		context.AvaloniaNameScope.Register("Track_Two", element);
		Grid.SetColumn(trackTwo2, 2);
		Grid.SetRowSpan(trackTwo2, 3);
		trackTwo2.ZIndex = 2;
		((ISupportInitialize)trackTwo2).EndInit();
		Avalonia.Controls.Controls children12 = grid5.Children;
		Border border6;
		Border border5 = (border6 = new Border());
		((ISupportInitialize)border5).BeginInit();
		children12.Add(border5);
		border6.Name = "Window_Edge";
		element = border6;
		context.AvaloniaNameScope.Register("Window_Edge", element);
		Grid.SetColumnSpan(border6, 3);
		Grid.SetRowSpan(border6, 3);
		border6.Classes.Add("WindowEdge");
		border6.ZIndex = 1;
		((ISupportInitialize)border6).EndInit();
		Avalonia.Controls.Controls children13 = grid5.Children;
		AppControl appControl2;
		AppControl appControl = (appControl2 = new AppControl());
		((ISupportInitialize)appControl).BeginInit();
		children13.Add(appControl);
		Grid.SetColumnSpan(appControl2, 3);
		Grid.SetRowSpan(appControl2, 3);
		appControl2.ZIndex = 5;
		((ISupportInitialize)appControl2).EndInit();
		context.PopParent();
		((ISupportInitialize)grid3).EndInit();
		context.PopParent();
		((ISupportInitialize)P_1).EndInit();
		if (P_1 is StyledElement styled)
		{
			NameScope.SetNameScope(styled, context.AvaloniaNameScope);
		}
		context.AvaloniaNameScope.Complete();
	}

	private static void _0021XamlIlPopulateTrampoline(MainWindow P_0)
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
