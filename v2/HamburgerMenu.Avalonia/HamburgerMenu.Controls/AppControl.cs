using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.CompilerServices;
using Avalonia;
using Avalonia.Animation;
using Avalonia.Animation.Easings;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Layout;
using Avalonia.Markup.Xaml.MarkupExtensions;
using Avalonia.Markup.Xaml.XamlIl.Runtime;
using Avalonia.Media;
using Avalonia.Media.Immutable;
using CompiledAvaloniaXaml;

namespace HamburgerMenu.Controls;

[CompilerGenerated]
public class AppControl : UserControl
{
	[GeneratedCode("Avalonia.Generators.NameGenerator.InitializeComponentCodeGenerator", "11.2.1.0")]
	internal Border Control_Header;

	[GeneratedCode("Avalonia.Generators.NameGenerator.InitializeComponentCodeGenerator", "11.2.1.0")]
	internal Button App_ShutDown;

	[GeneratedCode("Avalonia.Generators.NameGenerator.InitializeComponentCodeGenerator", "11.2.1.0")]
	internal Button App_Maximize;

	[GeneratedCode("Avalonia.Generators.NameGenerator.InitializeComponentCodeGenerator", "11.2.1.0")]
	internal Button App_Minimize;

	[GeneratedCode("Avalonia.Generators.NameGenerator.InitializeComponentCodeGenerator", "11.2.1.0")]
	internal Border Control_Footer;

	private static Action<object> _0021XamlIlPopulateOverride;

	public AppControl()
	{
		InitializeComponent();
		base.Loaded += OnLoaded;
	}

	private void OnLoaded(object? sender, RoutedEventArgs e)
	{
		Control_Header.RenderTransform = new TranslateTransform(0.0, 0.0);
		Control_Footer.RenderTransform = new TranslateTransform(0.0, 0.0);
	}

	private MainWindow? GetMainWindow()
	{
		return TopLevel.GetTopLevel(this) as MainWindow;
	}

	private void App_Minimize_Click(object? sender, RoutedEventArgs e)
	{
		MainWindow mainWindow = GetMainWindow();
		if (mainWindow != null)
		{
			mainWindow.WindowState = WindowState.Minimized;
		}
	}

	private void App_Maximize_Click(object? sender, RoutedEventArgs e)
	{
		GetMainWindow()?.ToggleWindowState();
	}

	private void App_ShutDown_Click(object? sender, RoutedEventArgs e)
	{
		GetMainWindow()?.Close();
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
		Control_Header = nameScope?.Find<Border>("Control_Header");
		App_ShutDown = nameScope?.Find<Button>("App_ShutDown");
		App_Maximize = nameScope?.Find<Button>("App_Maximize");
		App_Minimize = nameScope?.Find<Button>("App_Minimize");
		Control_Footer = nameScope?.Find<Border>("Control_Footer");
	}

	private static void _0021XamlIlPopulate(IServiceProvider P_0, AppControl P_1)
	{
		CompiledAvaloniaXaml.XamlIlContext.Context<AppControl> context = new CompiledAvaloniaXaml.XamlIlContext.Context<AppControl>(P_0, new object[1] { _0021AvaloniaResources.NamespaceInfo_003A_002FControls_002FAppControl_002Eaxaml.Singleton }, "avares://HamburgerMenu.Avalonia/Controls/AppControl.axaml")
		{
			RootObject = P_1,
			IntermediateRoot = P_1
		};
		((ISupportInitialize)P_1).BeginInit();
		context.PushParent(P_1);
		Panel panel2;
		Panel panel = (panel2 = new Panel());
		((ISupportInitialize)panel).BeginInit();
		P_1.Content = panel;
		Panel panel4;
		Panel panel3 = (panel4 = panel2);
		context.PushParent(panel4);
		Avalonia.Controls.Controls children = panel4.Children;
		Border border2;
		Border border = (border2 = new Border());
		((ISupportInitialize)border).BeginInit();
		children.Add(border);
		Border border4;
		Border border3 = (border4 = border2);
		context.PushParent(border4);
		Border border5 = border4;
		border5.Name = "Control_Header";
		object element = border5;
		context.AvaloniaNameScope.Register("Control_Header", element);
		border5.Height = 123.0;
		border5.Width = 36.0;
		border5.Background = new ImmutableSolidColorBrush(4294937600u);
		border5.Margin = new Thickness(0.0, 24.0, 17.0, 0.0);
		border5.VerticalAlignment = VerticalAlignment.Top;
		border5.HorizontalAlignment = HorizontalAlignment.Right;
		border5.CornerRadius = new CornerRadius(0.0, 0.0, 0.0, 0.0);
		border5.BorderBrush = new ImmutableSolidColorBrush(16777215u);
		border5.BorderThickness = new Thickness(0.0, 0.0, 0.0, 0.0);
		border5.RenderTransform = (ITransform)new TransformConverter().ConvertFrom(context, CultureInfo.InvariantCulture, "translateY(-160px)");
		Transitions transitions = new Transitions();
		TransformOperationsTransition transformOperationsTransition = new TransformOperationsTransition();
		transformOperationsTransition.Property = Visual.RenderTransformProperty;
		transformOperationsTransition.Duration = TimeSpan.FromTicks(3500000L);
		transformOperationsTransition.Delay = TimeSpan.FromTicks(32000000L);
		transformOperationsTransition.Easing = Easing.Parse("CircularEaseOut");
		transitions.Add(transformOperationsTransition);
		border5.Transitions = transitions;
		Border border7;
		Border border6 = (border7 = new Border());
		((ISupportInitialize)border6).BeginInit();
		border5.Child = border6;
		Border border8 = (border4 = border7);
		context.PushParent(border4);
		Border border9 = border4;
		border9.Margin = new Thickness(0.0, 12.0, 0.0, 12.0);
		border9.CornerRadius = new CornerRadius(5.0, 5.0, 5.0, 5.0);
		border9.Background = new ImmutableSolidColorBrush(4281677109u);
		StackPanel stackPanel2;
		StackPanel stackPanel = (stackPanel2 = new StackPanel());
		((ISupportInitialize)stackPanel).BeginInit();
		border9.Child = stackPanel;
		StackPanel stackPanel4;
		StackPanel stackPanel3 = (stackPanel4 = stackPanel2);
		context.PushParent(stackPanel4);
		stackPanel4.VerticalAlignment = VerticalAlignment.Center;
		stackPanel4.Spacing = 5.0;
		Avalonia.Controls.Controls children2 = stackPanel4.Children;
		Button button2;
		Button button = (button2 = new Button());
		((ISupportInitialize)button).BeginInit();
		children2.Add(button);
		Button button4;
		Button button3 = (button4 = button2);
		context.PushParent(button4);
		Button button5 = button4;
		button5.Name = "App_ShutDown";
		element = button5;
		context.AvaloniaNameScope.Register("App_ShutDown", element);
		button5.Classes.Add("ControlBtn");
		button5.Height = 25.0;
		button5.Margin = new Thickness(4.0, 0.0, 4.0, 0.0);
		button5.AddHandler((RoutedEvent)Button.ClickEvent, (Delegate)new EventHandler<RoutedEventArgs>(context.RootObject.App_ShutDown_Click), RoutingStrategies.Direct | RoutingStrategies.Bubble, handledEventsToo: false);
		Image image2;
		Image image = (image2 = new Image());
		((ISupportInitialize)image).BeginInit();
		button5.Content = image;
		Image image4;
		Image image3 = (image4 = image2);
		context.PushParent(image4);
		Image image5 = image4;
		StaticResourceExtension staticResourceExtension = new StaticResourceExtension("Close_01");
		context.ProvideTargetProperty = Image.SourceProperty;
		object? obj = staticResourceExtension.ProvideValue(context);
		context.ProvideTargetProperty = null;
		CompiledAvaloniaXaml.XamlDynamicSetters._003C_003EXamlDynamicSetter_1(image5, obj);
		image5.Stretch = Stretch.None;
		context.PopParent();
		((ISupportInitialize)image3).EndInit();
		context.PopParent();
		((ISupportInitialize)button3).EndInit();
		Avalonia.Controls.Controls children3 = stackPanel4.Children;
		Button button7;
		Button button6 = (button7 = new Button());
		((ISupportInitialize)button6).BeginInit();
		children3.Add(button6);
		Button button8 = (button4 = button7);
		context.PushParent(button4);
		Button button9 = button4;
		button9.Name = "App_Maximize";
		element = button9;
		context.AvaloniaNameScope.Register("App_Maximize", element);
		button9.Classes.Add("ControlBtn");
		button9.Height = 25.0;
		button9.Margin = new Thickness(4.0, 0.0, 4.0, 0.0);
		button9.AddHandler((RoutedEvent)Button.ClickEvent, (Delegate)new EventHandler<RoutedEventArgs>(context.RootObject.App_Maximize_Click), RoutingStrategies.Direct | RoutingStrategies.Bubble, handledEventsToo: false);
		Image image7;
		Image image6 = (image7 = new Image());
		((ISupportInitialize)image6).BeginInit();
		button9.Content = image6;
		Image image8 = (image4 = image7);
		context.PushParent(image4);
		Image image9 = image4;
		StaticResourceExtension staticResourceExtension2 = new StaticResourceExtension("Maximize_01");
		context.ProvideTargetProperty = Image.SourceProperty;
		object? obj2 = staticResourceExtension2.ProvideValue(context);
		context.ProvideTargetProperty = null;
		CompiledAvaloniaXaml.XamlDynamicSetters._003C_003EXamlDynamicSetter_1(image9, obj2);
		image9.Stretch = Stretch.None;
		context.PopParent();
		((ISupportInitialize)image8).EndInit();
		context.PopParent();
		((ISupportInitialize)button8).EndInit();
		Avalonia.Controls.Controls children4 = stackPanel4.Children;
		Button button11;
		Button button10 = (button11 = new Button());
		((ISupportInitialize)button10).BeginInit();
		children4.Add(button10);
		Button button12 = (button4 = button11);
		context.PushParent(button4);
		Button button13 = button4;
		button13.Name = "App_Minimize";
		element = button13;
		context.AvaloniaNameScope.Register("App_Minimize", element);
		button13.Classes.Add("ControlBtn");
		button13.Height = 25.0;
		button13.Margin = new Thickness(4.0, 0.0, 4.0, 0.0);
		button13.AddHandler((RoutedEvent)Button.ClickEvent, (Delegate)new EventHandler<RoutedEventArgs>(context.RootObject.App_Minimize_Click), RoutingStrategies.Direct | RoutingStrategies.Bubble, handledEventsToo: false);
		Image image11;
		Image image10 = (image11 = new Image());
		((ISupportInitialize)image10).BeginInit();
		button13.Content = image10;
		Image image12 = (image4 = image11);
		context.PushParent(image4);
		Image image13 = image4;
		StaticResourceExtension staticResourceExtension3 = new StaticResourceExtension("Minimize_01");
		context.ProvideTargetProperty = Image.SourceProperty;
		object? obj3 = staticResourceExtension3.ProvideValue(context);
		context.ProvideTargetProperty = null;
		CompiledAvaloniaXaml.XamlDynamicSetters._003C_003EXamlDynamicSetter_1(image13, obj3);
		image13.Stretch = Stretch.None;
		context.PopParent();
		((ISupportInitialize)image12).EndInit();
		context.PopParent();
		((ISupportInitialize)button12).EndInit();
		context.PopParent();
		((ISupportInitialize)stackPanel3).EndInit();
		context.PopParent();
		((ISupportInitialize)border8).EndInit();
		context.PopParent();
		((ISupportInitialize)border3).EndInit();
		Avalonia.Controls.Controls children5 = panel4.Children;
		Border border11;
		Border border10 = (border11 = new Border());
		((ISupportInitialize)border10).BeginInit();
		children5.Add(border10);
		Border border12 = (border4 = border11);
		context.PushParent(border4);
		Border border13 = border4;
		border13.Name = "Control_Footer";
		element = border13;
		context.AvaloniaNameScope.Register("Control_Footer", element);
		border13.Height = 123.0;
		border13.Width = 36.0;
		border13.Background = new ImmutableSolidColorBrush(4294937600u);
		border13.Margin = new Thickness(0.0, 0.0, 17.0, 24.0);
		border13.VerticalAlignment = VerticalAlignment.Bottom;
		border13.HorizontalAlignment = HorizontalAlignment.Right;
		border13.CornerRadius = new CornerRadius(0.0, 0.0, 0.0, 0.0);
		border13.BorderBrush = new ImmutableSolidColorBrush(16777215u);
		border13.BorderThickness = new Thickness(0.0, 0.0, 0.0, 0.0);
		border13.RenderTransform = (ITransform)new TransformConverter().ConvertFrom(context, CultureInfo.InvariantCulture, "translateY(160px)");
		Transitions transitions2 = new Transitions();
		TransformOperationsTransition transformOperationsTransition2 = new TransformOperationsTransition();
		transformOperationsTransition2.Property = Visual.RenderTransformProperty;
		transformOperationsTransition2.Duration = TimeSpan.FromTicks(3500000L);
		transformOperationsTransition2.Delay = TimeSpan.FromTicks(32000000L);
		transformOperationsTransition2.Easing = Easing.Parse("CircularEaseOut");
		transitions2.Add(transformOperationsTransition2);
		border13.Transitions = transitions2;
		context.PopParent();
		((ISupportInitialize)border12).EndInit();
		context.PopParent();
		((ISupportInitialize)panel3).EndInit();
		context.PopParent();
		((ISupportInitialize)P_1).EndInit();
		if (P_1 is StyledElement styled)
		{
			NameScope.SetNameScope(styled, context.AvaloniaNameScope);
		}
		context.AvaloniaNameScope.Complete();
	}

	private static void _0021XamlIlPopulateTrampoline(AppControl P_0)
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
