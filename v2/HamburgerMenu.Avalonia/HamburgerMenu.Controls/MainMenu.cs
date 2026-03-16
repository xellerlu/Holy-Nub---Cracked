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
using Avalonia.Controls.Primitives;
using Avalonia.Controls.Shapes;
using Avalonia.Input.Platform;
using Avalonia.Interactivity;
using Avalonia.Layout;
using Avalonia.Markup.Xaml.MarkupExtensions;
using Avalonia.Markup.Xaml.XamlIl.Runtime;
using Avalonia.Media;
using Avalonia.Media.Immutable;
using CompiledAvaloniaXaml;

namespace HamburgerMenu.Controls;

[CompilerGenerated]
public class MainMenu : UserControl
{
	private bool _isMenuExpanded;

	[GeneratedCode("Avalonia.Generators.NameGenerator.InitializeComponentCodeGenerator", "11.2.1.0")]
	internal Border Menu_Status;

	[GeneratedCode("Avalonia.Generators.NameGenerator.InitializeComponentCodeGenerator", "11.2.1.0")]
	internal Rectangle SideBar_Active;

	[GeneratedCode("Avalonia.Generators.NameGenerator.InitializeComponentCodeGenerator", "11.2.1.0")]
	internal Rectangle SidePanel_Active;

	[GeneratedCode("Avalonia.Generators.NameGenerator.InitializeComponentCodeGenerator", "11.2.1.0")]
	internal Border Menu_Container;

	[GeneratedCode("Avalonia.Generators.NameGenerator.InitializeComponentCodeGenerator", "11.2.1.0")]
	internal ToggleButton Menu_ToggleButton;

	[GeneratedCode("Avalonia.Generators.NameGenerator.InitializeComponentCodeGenerator", "11.2.1.0")]
	internal StackPanel SideBar_Container;

	[GeneratedCode("Avalonia.Generators.NameGenerator.InitializeComponentCodeGenerator", "11.2.1.0")]
	internal StackPanel SidePanel_Container;

	[GeneratedCode("Avalonia.Generators.NameGenerator.InitializeComponentCodeGenerator", "11.2.1.0")]
	internal SidePanel SidePanel_UC;

	[GeneratedCode("Avalonia.Generators.NameGenerator.InitializeComponentCodeGenerator", "11.2.1.0")]
	internal Border Menu_Base;

	[GeneratedCode("Avalonia.Generators.NameGenerator.InitializeComponentCodeGenerator", "11.2.1.0")]
	internal Button BtnMirage;

	[GeneratedCode("Avalonia.Generators.NameGenerator.InitializeComponentCodeGenerator", "11.2.1.0")]
	internal Button BtnAwp;

	[GeneratedCode("Avalonia.Generators.NameGenerator.InitializeComponentCodeGenerator", "11.2.1.0")]
	internal Button BtnDust;

	[GeneratedCode("Avalonia.Generators.NameGenerator.InitializeComponentCodeGenerator", "11.2.1.0")]
	internal TextBlock CopyStatus;

	private static Action<object> _0021XamlIlPopulateOverride;

	public MainMenu()
	{
		InitializeComponent();
		base.Loaded += OnLoaded;
	}

	private void OnLoaded(object? sender, RoutedEventArgs e)
	{
		Menu_Status.RenderTransform = new TranslateTransform(0.0, 0.0);
		Menu_Base.RenderTransform = new TranslateTransform(0.0, 0.0);
		Menu_Container.RenderTransform = new TranslateTransform(0.0, 0.0);
	}

	private async void CopyServer_Click(object? sender, RoutedEventArgs e)
	{
		if (!(sender is Button button))
		{
			return;
		}
		object tag = button.Tag;
		if (tag is string serverCmd)
		{
			IClipboard clipboard = TopLevel.GetTopLevel(this)?.Clipboard;
			if (clipboard != null)
			{
				await clipboard.SetTextAsync(serverCmd);
				CopyStatus.Text = "Copied: " + serverCmd;
				CopyStatus.Opacity = 1.0;
				await Task.Delay(2000);
				CopyStatus.Opacity = 0.0;
			}
		}
	}

	private void Menu_ToggleButton_Checked(object? sender, RoutedEventArgs e)
	{
		_isMenuExpanded = true;
		Menu_Container.Width = 210.0;
		SideBar_Container.IsVisible = false;
		SidePanel_Container.IsVisible = true;
		UpdateStatusIndicators();
	}

	private void Menu_ToggleButton_Unchecked(object? sender, RoutedEventArgs e)
	{
		_isMenuExpanded = false;
		Menu_Container.Width = 50.0;
		SideBar_Container.IsVisible = true;
		SidePanel_Container.IsVisible = false;
		UpdateStatusIndicators();
	}

	private void UpdateStatusIndicators()
	{
		SideBar_Active.Fill = (_isMenuExpanded ? new SolidColorBrush(Color.Parse("#5B5B5B")) : new SolidColorBrush(Color.Parse("#FF8C00")));
		SidePanel_Active.Fill = (_isMenuExpanded ? new SolidColorBrush(Color.Parse("#FF8C00")) : new SolidColorBrush(Color.Parse("#5B5B5B")));
	}

	public void UncheckMenuToggle()
	{
		Menu_ToggleButton.IsChecked = false;
	}

	public void UnselectAppsSidePanel()
	{
		SidePanel_UC?.UnselectApps();
	}

	public void UnselectCustomerSidePanel()
	{
		SidePanel_UC?.UnselectCustomer();
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
		Menu_Status = nameScope?.Find<Border>("Menu_Status");
		SideBar_Active = nameScope?.Find<Rectangle>("SideBar_Active");
		SidePanel_Active = nameScope?.Find<Rectangle>("SidePanel_Active");
		Menu_Container = nameScope?.Find<Border>("Menu_Container");
		Menu_ToggleButton = nameScope?.Find<ToggleButton>("Menu_ToggleButton");
		SideBar_Container = nameScope?.Find<StackPanel>("SideBar_Container");
		SidePanel_Container = nameScope?.Find<StackPanel>("SidePanel_Container");
		SidePanel_UC = nameScope?.Find<SidePanel>("SidePanel_UC");
		Menu_Base = nameScope?.Find<Border>("Menu_Base");
		BtnMirage = nameScope?.Find<Button>("BtnMirage");
		BtnAwp = nameScope?.Find<Button>("BtnAwp");
		BtnDust = nameScope?.Find<Button>("BtnDust");
		CopyStatus = nameScope?.Find<TextBlock>("CopyStatus");
	}

	private static void _0021XamlIlPopulate(IServiceProvider P_0, MainMenu P_1)
	{
		CompiledAvaloniaXaml.XamlIlContext.Context<MainMenu> context = new CompiledAvaloniaXaml.XamlIlContext.Context<MainMenu>(P_0, new object[1] { _0021AvaloniaResources.NamespaceInfo_003A_002FControls_002FMainMenu_002Eaxaml.Singleton }, "avares://HamburgerMenu.Avalonia/Controls/MainMenu.axaml")
		{
			RootObject = P_1,
			IntermediateRoot = P_1
		};
		((ISupportInitialize)P_1).BeginInit();
		context.PushParent(P_1);
		Grid grid2;
		Grid grid = (grid2 = new Grid());
		((ISupportInitialize)grid).BeginInit();
		P_1.Content = grid;
		Grid grid4;
		Grid grid3 = (grid4 = grid2);
		context.PushParent(grid4);
		RowDefinitions rowDefinitions = new RowDefinitions();
		rowDefinitions.Capacity = 3;
		rowDefinitions.Add(new RowDefinition(new GridLength(0.0, GridUnitType.Auto)));
		rowDefinitions.Add(new RowDefinition(new GridLength(1.0, GridUnitType.Star)));
		rowDefinitions.Add(new RowDefinition(new GridLength(0.0, GridUnitType.Auto)));
		grid4.RowDefinitions = rowDefinitions;
		Avalonia.Controls.Controls children = grid4.Children;
		Border border2;
		Border border = (border2 = new Border());
		((ISupportInitialize)border).BeginInit();
		children.Add(border);
		Border border4;
		Border border3 = (border4 = border2);
		context.PushParent(border4);
		Border border5 = border4;
		border5.Name = "Menu_Status";
		object element = border5;
		context.AvaloniaNameScope.Register("Menu_Status", element);
		Grid.SetRow(border5, 0);
		border5.Width = 210.0;
		border5.Height = 60.0;
		border5.Background = new ImmutableSolidColorBrush(4282664004u);
		border5.CornerRadius = new CornerRadius(10.0, 10.0, 10.0, 10.0);
		border5.VerticalAlignment = VerticalAlignment.Top;
		border5.HorizontalAlignment = HorizontalAlignment.Left;
		border5.Margin = new Thickness(20.0, 20.0, 0.0, 0.0);
		border5.RenderTransform = (ITransform)new TransformConverter().ConvertFrom(context, CultureInfo.InvariantCulture, "translateY(-200px)");
		Transitions transitions = new Transitions();
		TransformOperationsTransition transformOperationsTransition = new TransformOperationsTransition();
		transformOperationsTransition.Property = Visual.RenderTransformProperty;
		transformOperationsTransition.Duration = TimeSpan.FromTicks(6000000L);
		transformOperationsTransition.Delay = TimeSpan.FromTicks(4000000L);
		transitions.Add(transformOperationsTransition);
		border5.Transitions = transitions;
		Panel panel2;
		Panel panel = (panel2 = new Panel());
		((ISupportInitialize)panel).BeginInit();
		border5.Child = panel;
		Panel panel4;
		Panel panel3 = (panel4 = panel2);
		context.PushParent(panel4);
		Panel panel5 = panel4;
		Avalonia.Controls.Controls children2 = panel5.Children;
		Border border7;
		Border border6 = (border7 = new Border());
		((ISupportInitialize)border6).BeginInit();
		children2.Add(border6);
		Border border8 = (border4 = border7);
		context.PushParent(border4);
		Border border9 = border4;
		border9.Height = 20.0;
		border9.Width = 100.0;
		border9.Background = new ImmutableSolidColorBrush(4282664004u);
		border9.VerticalAlignment = VerticalAlignment.Top;
		border9.HorizontalAlignment = HorizontalAlignment.Center;
		border9.CornerRadius = new CornerRadius(5.0, 5.0, 0.0, 0.0);
		border9.Margin = new Thickness(0.0, 2.0, 0.0, 0.0);
		TextBlock textBlock2;
		TextBlock textBlock = (textBlock2 = new TextBlock());
		((ISupportInitialize)textBlock).BeginInit();
		border9.Child = textBlock;
		TextBlock textBlock4;
		TextBlock textBlock3 = (textBlock4 = textBlock2);
		context.PushParent(textBlock4);
		TextBlock textBlock5 = textBlock4;
		textBlock5.Text = "MENU STATUS";
		textBlock5.FontSize = 12.0;
		StaticResourceExtension staticResourceExtension = new StaticResourceExtension("FontStyle_1");
		context.ProvideTargetProperty = TextBlock.FontFamilyProperty;
		object? obj = staticResourceExtension.ProvideValue(context);
		context.ProvideTargetProperty = null;
		CompiledAvaloniaXaml.XamlDynamicSetters._003C_003EXamlDynamicSetter_2(textBlock5, obj);
		textBlock5.Foreground = new ImmutableSolidColorBrush(uint.MaxValue);
		textBlock5.HorizontalAlignment = HorizontalAlignment.Center;
		textBlock5.VerticalAlignment = VerticalAlignment.Center;
		context.PopParent();
		((ISupportInitialize)textBlock3).EndInit();
		context.PopParent();
		((ISupportInitialize)border8).EndInit();
		Avalonia.Controls.Controls children3 = panel5.Children;
		StackPanel stackPanel2;
		StackPanel stackPanel = (stackPanel2 = new StackPanel());
		((ISupportInitialize)stackPanel).BeginInit();
		children3.Add(stackPanel);
		StackPanel stackPanel4;
		StackPanel stackPanel3 = (stackPanel4 = stackPanel2);
		context.PushParent(stackPanel4);
		StackPanel stackPanel5 = stackPanel4;
		stackPanel5.Orientation = Orientation.Horizontal;
		stackPanel5.VerticalAlignment = VerticalAlignment.Bottom;
		stackPanel5.HorizontalAlignment = HorizontalAlignment.Center;
		stackPanel5.Margin = new Thickness(0.0, 0.0, 0.0, 5.0);
		stackPanel5.Spacing = 6.0;
		Avalonia.Controls.Controls children4 = stackPanel5.Children;
		Border border11;
		Border border10 = (border11 = new Border());
		((ISupportInitialize)border10).BeginInit();
		children4.Add(border10);
		Border border12 = (border4 = border11);
		context.PushParent(border4);
		Border border13 = border4;
		border13.Height = 30.0;
		border13.Width = 95.0;
		border13.Background = new ImmutableSolidColorBrush(4280756007u);
		border13.CornerRadius = new CornerRadius(3.0, 10.0, 10.0, 10.0);
		Panel panel7;
		Panel panel6 = (panel7 = new Panel());
		((ISupportInitialize)panel6).BeginInit();
		border13.Child = panel6;
		Panel panel8 = (panel4 = panel7);
		context.PushParent(panel4);
		Panel panel9 = panel4;
		Avalonia.Controls.Controls children5 = panel9.Children;
		Rectangle rectangle2;
		Rectangle rectangle = (rectangle2 = new Rectangle());
		((ISupportInitialize)rectangle).BeginInit();
		children5.Add(rectangle);
		rectangle2.Name = "SideBar_Active";
		element = rectangle2;
		context.AvaloniaNameScope.Register("SideBar_Active", element);
		rectangle2.Height = 4.0;
		rectangle2.Width = 20.0;
		rectangle2.Margin = new Thickness(0.0, 0.0, 0.0, 5.0);
		rectangle2.HorizontalAlignment = HorizontalAlignment.Center;
		rectangle2.VerticalAlignment = VerticalAlignment.Bottom;
		rectangle2.Fill = new ImmutableSolidColorBrush(4294937600u);
		rectangle2.RadiusX = 2.0;
		rectangle2.RadiusY = 2.0;
		((ISupportInitialize)rectangle2).EndInit();
		Avalonia.Controls.Controls children6 = panel9.Children;
		TextBlock textBlock7;
		TextBlock textBlock6 = (textBlock7 = new TextBlock());
		((ISupportInitialize)textBlock6).BeginInit();
		children6.Add(textBlock6);
		TextBlock textBlock8 = (textBlock4 = textBlock7);
		context.PushParent(textBlock4);
		TextBlock textBlock9 = textBlock4;
		textBlock9.Text = "SIDE BAR";
		textBlock9.Foreground = new ImmutableSolidColorBrush(uint.MaxValue);
		textBlock9.FontSize = 12.0;
		StaticResourceExtension staticResourceExtension2 = new StaticResourceExtension("FontStyle_1");
		context.ProvideTargetProperty = TextBlock.FontFamilyProperty;
		object? obj2 = staticResourceExtension2.ProvideValue(context);
		context.ProvideTargetProperty = null;
		CompiledAvaloniaXaml.XamlDynamicSetters._003C_003EXamlDynamicSetter_2(textBlock9, obj2);
		textBlock9.HorizontalAlignment = HorizontalAlignment.Center;
		textBlock9.VerticalAlignment = VerticalAlignment.Center;
		textBlock9.Margin = new Thickness(0.0, 0.0, 0.0, 8.0);
		context.PopParent();
		((ISupportInitialize)textBlock8).EndInit();
		context.PopParent();
		((ISupportInitialize)panel8).EndInit();
		context.PopParent();
		((ISupportInitialize)border12).EndInit();
		Avalonia.Controls.Controls children7 = stackPanel5.Children;
		Border border15;
		Border border14 = (border15 = new Border());
		((ISupportInitialize)border14).BeginInit();
		children7.Add(border14);
		Border border16 = (border4 = border15);
		context.PushParent(border4);
		Border border17 = border4;
		border17.Height = 30.0;
		border17.Width = 95.0;
		border17.Background = new ImmutableSolidColorBrush(4280756007u);
		border17.CornerRadius = new CornerRadius(10.0, 3.0, 10.0, 10.0);
		Panel panel11;
		Panel panel10 = (panel11 = new Panel());
		((ISupportInitialize)panel10).BeginInit();
		border17.Child = panel10;
		Panel panel12 = (panel4 = panel11);
		context.PushParent(panel4);
		Panel panel13 = panel4;
		Avalonia.Controls.Controls children8 = panel13.Children;
		Rectangle rectangle4;
		Rectangle rectangle3 = (rectangle4 = new Rectangle());
		((ISupportInitialize)rectangle3).BeginInit();
		children8.Add(rectangle3);
		rectangle4.Name = "SidePanel_Active";
		element = rectangle4;
		context.AvaloniaNameScope.Register("SidePanel_Active", element);
		rectangle4.Height = 4.0;
		rectangle4.Width = 20.0;
		rectangle4.Margin = new Thickness(0.0, 0.0, 0.0, 5.0);
		rectangle4.HorizontalAlignment = HorizontalAlignment.Center;
		rectangle4.VerticalAlignment = VerticalAlignment.Bottom;
		rectangle4.Fill = new ImmutableSolidColorBrush(4284177243u);
		rectangle4.RadiusX = 2.0;
		rectangle4.RadiusY = 2.0;
		((ISupportInitialize)rectangle4).EndInit();
		Avalonia.Controls.Controls children9 = panel13.Children;
		TextBlock textBlock11;
		TextBlock textBlock10 = (textBlock11 = new TextBlock());
		((ISupportInitialize)textBlock10).BeginInit();
		children9.Add(textBlock10);
		TextBlock textBlock12 = (textBlock4 = textBlock11);
		context.PushParent(textBlock4);
		TextBlock textBlock13 = textBlock4;
		textBlock13.Text = "SIDE PANEL";
		textBlock13.Foreground = new ImmutableSolidColorBrush(uint.MaxValue);
		textBlock13.FontSize = 12.0;
		StaticResourceExtension staticResourceExtension3 = new StaticResourceExtension("FontStyle_1");
		context.ProvideTargetProperty = TextBlock.FontFamilyProperty;
		object? obj3 = staticResourceExtension3.ProvideValue(context);
		context.ProvideTargetProperty = null;
		CompiledAvaloniaXaml.XamlDynamicSetters._003C_003EXamlDynamicSetter_2(textBlock13, obj3);
		textBlock13.HorizontalAlignment = HorizontalAlignment.Center;
		textBlock13.VerticalAlignment = VerticalAlignment.Center;
		textBlock13.Margin = new Thickness(0.0, 0.0, 0.0, 8.0);
		context.PopParent();
		((ISupportInitialize)textBlock12).EndInit();
		context.PopParent();
		((ISupportInitialize)panel12).EndInit();
		context.PopParent();
		((ISupportInitialize)border16).EndInit();
		context.PopParent();
		((ISupportInitialize)stackPanel3).EndInit();
		context.PopParent();
		((ISupportInitialize)panel3).EndInit();
		context.PopParent();
		((ISupportInitialize)border3).EndInit();
		Avalonia.Controls.Controls children10 = grid4.Children;
		Border border19;
		Border border18 = (border19 = new Border());
		((ISupportInitialize)border18).BeginInit();
		children10.Add(border18);
		Border border20 = (border4 = border19);
		context.PushParent(border4);
		Border border21 = border4;
		border21.Name = "Menu_Container";
		element = border21;
		context.AvaloniaNameScope.Register("Menu_Container", element);
		Grid.SetRow(border21, 1);
		border21.Width = 50.0;
		border21.HorizontalAlignment = HorizontalAlignment.Left;
		border21.Background = new ImmutableSolidColorBrush(16777215u);
		border21.Margin = new Thickness(20.0, 15.0, 0.0, 15.0);
		border21.RenderTransform = (ITransform)new TransformConverter().ConvertFrom(context, CultureInfo.InvariantCulture, "translateX(-80px)");
		Transitions transitions2 = new Transitions();
		TransformOperationsTransition transformOperationsTransition2 = new TransformOperationsTransition();
		transformOperationsTransition2.Property = Visual.RenderTransformProperty;
		transformOperationsTransition2.Duration = TimeSpan.FromTicks(2000000L);
		transformOperationsTransition2.Delay = TimeSpan.FromTicks(12000000L);
		transitions2.Add(transformOperationsTransition2);
		DoubleTransition doubleTransition = new DoubleTransition();
		doubleTransition.Property = Layoutable.WidthProperty;
		doubleTransition.Duration = TimeSpan.FromTicks(10000000L);
		doubleTransition.Easing = Easing.Parse("QuadraticEaseOut");
		transitions2.Add(doubleTransition);
		border21.Transitions = transitions2;
		Panel panel15;
		Panel panel14 = (panel15 = new Panel());
		((ISupportInitialize)panel14).BeginInit();
		border21.Child = panel14;
		Panel panel16 = (panel4 = panel15);
		context.PushParent(panel4);
		Panel panel17 = panel4;
		Avalonia.Controls.Controls children11 = panel17.Children;
		Border border23;
		Border border22 = (border23 = new Border());
		((ISupportInitialize)border22).BeginInit();
		children11.Add(border22);
		border23.Background = new ImmutableSolidColorBrush(4281677109u);
		border23.BorderBrush = new ImmutableSolidColorBrush(4294937600u);
		border23.BorderThickness = new Thickness(0.0, 0.0, 0.0, 5.0);
		border23.CornerRadius = new CornerRadius(8.0, 8.0, 8.0, 8.0);
		((ISupportInitialize)border23).EndInit();
		Avalonia.Controls.Controls children12 = panel17.Children;
		Panel panel19;
		Panel panel18 = (panel19 = new Panel());
		((ISupportInitialize)panel18).BeginInit();
		children12.Add(panel18);
		Panel panel20 = (panel4 = panel19);
		context.PushParent(panel4);
		Panel panel21 = panel4;
		Avalonia.Controls.Controls children13 = panel21.Children;
		ToggleButton toggleButton2;
		ToggleButton toggleButton = (toggleButton2 = new ToggleButton());
		((ISupportInitialize)toggleButton).BeginInit();
		children13.Add(toggleButton);
		ToggleButton toggleButton4;
		ToggleButton toggleButton3 = (toggleButton4 = toggleButton2);
		context.PushParent(toggleButton4);
		toggleButton4.Name = "Menu_ToggleButton";
		element = toggleButton4;
		context.AvaloniaNameScope.Register("Menu_ToggleButton", element);
		toggleButton4.Classes.Add("HamburgerToggle");
		toggleButton4.HorizontalAlignment = HorizontalAlignment.Right;
		toggleButton4.VerticalAlignment = VerticalAlignment.Top;
		toggleButton4.AddHandler((RoutedEvent)ToggleButton.CheckedEvent, (Delegate)new EventHandler<RoutedEventArgs>(context.RootObject.Menu_ToggleButton_Checked), RoutingStrategies.Direct | RoutingStrategies.Bubble, handledEventsToo: false);
		toggleButton4.AddHandler((RoutedEvent)ToggleButton.UncheckedEvent, (Delegate)new EventHandler<RoutedEventArgs>(context.RootObject.Menu_ToggleButton_Unchecked), RoutingStrategies.Direct | RoutingStrategies.Bubble, handledEventsToo: false);
		Image image2;
		Image image = (image2 = new Image());
		((ISupportInitialize)image).BeginInit();
		toggleButton4.Content = image;
		Image image4;
		Image image3 = (image4 = image2);
		context.PushParent(image4);
		StaticResourceExtension staticResourceExtension4 = new StaticResourceExtension("Hamburger_Image");
		context.ProvideTargetProperty = Image.SourceProperty;
		object? obj4 = staticResourceExtension4.ProvideValue(context);
		context.ProvideTargetProperty = null;
		CompiledAvaloniaXaml.XamlDynamicSetters._003C_003EXamlDynamicSetter_1(image4, obj4);
		image4.Stretch = Stretch.None;
		context.PopParent();
		((ISupportInitialize)image3).EndInit();
		context.PopParent();
		((ISupportInitialize)toggleButton3).EndInit();
		Avalonia.Controls.Controls children14 = panel21.Children;
		Border border25;
		Border border24 = (border25 = new Border());
		((ISupportInitialize)border24).BeginInit();
		children14.Add(border24);
		Border border26 = (border4 = border25);
		context.PushParent(border4);
		Border border27 = border4;
		border27.Height = 32.0;
		border27.Width = 150.0;
		border27.Background = new ImmutableSolidColorBrush(4294937600u);
		border27.HorizontalAlignment = HorizontalAlignment.Right;
		border27.VerticalAlignment = VerticalAlignment.Top;
		border27.Margin = new Thickness(0.0, 9.0, 52.0, 0.0);
		border27.CornerRadius = new CornerRadius(5.0, 5.0, 5.0, 5.0);
		Border border29;
		Border border28 = (border29 = new Border());
		((ISupportInitialize)border28).BeginInit();
		border27.Child = border28;
		Border border30 = (border4 = border29);
		context.PushParent(border4);
		Border border31 = border4;
		border31.Width = 65.0;
		border31.Background = new ImmutableSolidColorBrush(4283782485u);
		border31.HorizontalAlignment = HorizontalAlignment.Left;
		border31.Margin = new Thickness(10.0, 0.0, 0.0, 0.0);
		border31.CornerRadius = new CornerRadius(5.0, 5.0, 5.0, 5.0);
		border31.BorderBrush = new ImmutableSolidColorBrush(4281677109u);
		border31.BorderThickness = new Thickness(0.0, 3.0, 0.0, 3.0);
		TextBlock textBlock15;
		TextBlock textBlock14 = (textBlock15 = new TextBlock());
		((ISupportInitialize)textBlock14).BeginInit();
		border31.Child = textBlock14;
		TextBlock textBlock16 = (textBlock4 = textBlock15);
		context.PushParent(textBlock4);
		TextBlock textBlock17 = textBlock4;
		textBlock17.Text = "Menu";
		StaticResourceExtension staticResourceExtension5 = new StaticResourceExtension("FontStyle_1");
		context.ProvideTargetProperty = TextBlock.FontFamilyProperty;
		object? obj5 = staticResourceExtension5.ProvideValue(context);
		context.ProvideTargetProperty = null;
		CompiledAvaloniaXaml.XamlDynamicSetters._003C_003EXamlDynamicSetter_2(textBlock17, obj5);
		textBlock17.FontSize = 16.0;
		textBlock17.Foreground = new ImmutableSolidColorBrush(uint.MaxValue);
		textBlock17.HorizontalAlignment = HorizontalAlignment.Center;
		textBlock17.VerticalAlignment = VerticalAlignment.Center;
		context.PopParent();
		((ISupportInitialize)textBlock16).EndInit();
		context.PopParent();
		((ISupportInitialize)border30).EndInit();
		context.PopParent();
		((ISupportInitialize)border26).EndInit();
		Avalonia.Controls.Controls children15 = panel21.Children;
		StackPanel stackPanel7;
		StackPanel stackPanel6 = (stackPanel7 = new StackPanel());
		((ISupportInitialize)stackPanel6).BeginInit();
		children15.Add(stackPanel6);
		stackPanel7.Name = "SideBar_Container";
		element = stackPanel7;
		context.AvaloniaNameScope.Register("SideBar_Container", element);
		stackPanel7.Margin = new Thickness(0.0, 50.0, 0.0, 0.0);
		stackPanel7.ZIndex = 1;
		Avalonia.Controls.Controls children16 = stackPanel7.Children;
		SideBar sideBar2;
		SideBar sideBar = (sideBar2 = new SideBar());
		((ISupportInitialize)sideBar).BeginInit();
		children16.Add(sideBar);
		((ISupportInitialize)sideBar2).EndInit();
		((ISupportInitialize)stackPanel7).EndInit();
		Avalonia.Controls.Controls children17 = panel21.Children;
		StackPanel stackPanel9;
		StackPanel stackPanel8 = (stackPanel9 = new StackPanel());
		((ISupportInitialize)stackPanel8).BeginInit();
		children17.Add(stackPanel8);
		stackPanel9.Name = "SidePanel_Container";
		element = stackPanel9;
		context.AvaloniaNameScope.Register("SidePanel_Container", element);
		stackPanel9.Margin = new Thickness(0.0, 50.0, 0.0, 0.0);
		stackPanel9.IsVisible = false;
		stackPanel9.ClipToBounds = true;
		Avalonia.Controls.Controls children18 = stackPanel9.Children;
		SidePanel sidePanel2;
		SidePanel sidePanel = (sidePanel2 = new SidePanel());
		((ISupportInitialize)sidePanel).BeginInit();
		children18.Add(sidePanel);
		sidePanel2.Name = "SidePanel_UC";
		element = sidePanel2;
		context.AvaloniaNameScope.Register("SidePanel_UC", element);
		((ISupportInitialize)sidePanel2).EndInit();
		((ISupportInitialize)stackPanel9).EndInit();
		context.PopParent();
		((ISupportInitialize)panel20).EndInit();
		context.PopParent();
		((ISupportInitialize)panel16).EndInit();
		context.PopParent();
		((ISupportInitialize)border20).EndInit();
		Avalonia.Controls.Controls children19 = grid4.Children;
		Border border33;
		Border border32 = (border33 = new Border());
		((ISupportInitialize)border32).BeginInit();
		children19.Add(border32);
		Border border34 = (border4 = border33);
		context.PushParent(border4);
		Border border35 = border4;
		border35.Name = "Menu_Base";
		element = border35;
		context.AvaloniaNameScope.Register("Menu_Base", element);
		Grid.SetRow(border35, 2);
		border35.Width = 210.0;
		border35.Height = 90.0;
		border35.Background = new ImmutableSolidColorBrush(4294937600u);
		border35.CornerRadius = new CornerRadius(10.0, 10.0, 10.0, 10.0);
		border35.VerticalAlignment = VerticalAlignment.Bottom;
		border35.HorizontalAlignment = HorizontalAlignment.Left;
		border35.Margin = new Thickness(20.0, 0.0, 0.0, 20.0);
		border35.RenderTransform = (ITransform)new TransformConverter().ConvertFrom(context, CultureInfo.InvariantCulture, "translateY(110px)");
		Transitions transitions3 = new Transitions();
		TransformOperationsTransition transformOperationsTransition3 = new TransformOperationsTransition();
		transformOperationsTransition3.Property = Visual.RenderTransformProperty;
		transformOperationsTransition3.Duration = TimeSpan.FromTicks(6000000L);
		transformOperationsTransition3.Delay = TimeSpan.FromTicks(4000000L);
		transformOperationsTransition3.Easing = Easing.Parse("CubicEaseIn");
		transitions3.Add(transformOperationsTransition3);
		border35.Transitions = transitions3;
		StackPanel stackPanel11;
		StackPanel stackPanel10 = (stackPanel11 = new StackPanel());
		((ISupportInitialize)stackPanel10).BeginInit();
		border35.Child = stackPanel10;
		StackPanel stackPanel12 = (stackPanel4 = stackPanel11);
		context.PushParent(stackPanel4);
		StackPanel stackPanel13 = stackPanel4;
		stackPanel13.Margin = new Thickness(8.0, 3.0, 8.0, 3.0);
		stackPanel13.VerticalAlignment = VerticalAlignment.Top;
		Avalonia.Controls.Controls children20 = stackPanel13.Children;
		TextBlock textBlock19;
		TextBlock textBlock18 = (textBlock19 = new TextBlock());
		((ISupportInitialize)textBlock18).BeginInit();
		children20.Add(textBlock18);
		TextBlock textBlock20 = (textBlock4 = textBlock19);
		context.PushParent(textBlock4);
		TextBlock textBlock21 = textBlock4;
		textBlock21.Text = "CSGO SERVERS";
		StaticResourceExtension staticResourceExtension6 = new StaticResourceExtension("FontStyle_1");
		context.ProvideTargetProperty = TextBlock.FontFamilyProperty;
		object? obj6 = staticResourceExtension6.ProvideValue(context);
		context.ProvideTargetProperty = null;
		CompiledAvaloniaXaml.XamlDynamicSetters._003C_003EXamlDynamicSetter_2(textBlock21, obj6);
		textBlock21.FontSize = 11.0;
		textBlock21.Foreground = new ImmutableSolidColorBrush(uint.MaxValue);
		textBlock21.FontWeight = FontWeight.Bold;
		textBlock21.HorizontalAlignment = HorizontalAlignment.Center;
		textBlock21.Margin = new Thickness(0.0, 0.0, 0.0, 2.0);
		context.PopParent();
		((ISupportInitialize)textBlock20).EndInit();
		Avalonia.Controls.Controls children21 = stackPanel13.Children;
		Button button2;
		Button button = (button2 = new Button());
		((ISupportInitialize)button).BeginInit();
		children21.Add(button);
		Button button4;
		Button button3 = (button4 = button2);
		context.PushParent(button4);
		Button button5 = button4;
		button5.Name = "BtnMirage";
		element = button5;
		context.AvaloniaNameScope.Register("BtnMirage", element);
		button5.Classes.Add("ServerBtn");
		button5.AddHandler((RoutedEvent)Button.ClickEvent, (Delegate)new EventHandler<RoutedEventArgs>(context.RootObject.CopyServer_Click), RoutingStrategies.Direct | RoutingStrategies.Bubble, handledEventsToo: false);
		button5.Tag = "connect 37.48.252.7:27115";
		StackPanel stackPanel15;
		StackPanel stackPanel14 = (stackPanel15 = new StackPanel());
		((ISupportInitialize)stackPanel14).BeginInit();
		button5.Content = stackPanel14;
		StackPanel stackPanel16 = (stackPanel4 = stackPanel15);
		context.PushParent(stackPanel4);
		StackPanel stackPanel17 = stackPanel4;
		stackPanel17.Orientation = Orientation.Horizontal;
		stackPanel17.Spacing = 5.0;
		Avalonia.Controls.Controls children22 = stackPanel17.Children;
		TextBlock textBlock23;
		TextBlock textBlock22 = (textBlock23 = new TextBlock());
		((ISupportInitialize)textBlock22).BeginInit();
		children22.Add(textBlock22);
		TextBlock textBlock24 = (textBlock4 = textBlock23);
		context.PushParent(textBlock4);
		TextBlock textBlock25 = textBlock4;
		textBlock25.Text = "Mirage:";
		textBlock25.FontSize = 9.0;
		textBlock25.Foreground = new ImmutableSolidColorBrush(4294937600u);
		StaticResourceExtension staticResourceExtension7 = new StaticResourceExtension("FontStyle_1");
		context.ProvideTargetProperty = TextBlock.FontFamilyProperty;
		object? obj7 = staticResourceExtension7.ProvideValue(context);
		context.ProvideTargetProperty = null;
		CompiledAvaloniaXaml.XamlDynamicSetters._003C_003EXamlDynamicSetter_2(textBlock25, obj7);
		textBlock25.VerticalAlignment = VerticalAlignment.Center;
		context.PopParent();
		((ISupportInitialize)textBlock24).EndInit();
		Avalonia.Controls.Controls children23 = stackPanel17.Children;
		TextBlock textBlock27;
		TextBlock textBlock26 = (textBlock27 = new TextBlock());
		((ISupportInitialize)textBlock26).BeginInit();
		children23.Add(textBlock26);
		TextBlock textBlock28 = (textBlock4 = textBlock27);
		context.PushParent(textBlock4);
		TextBlock textBlock29 = textBlock4;
		textBlock29.Text = "connect 37.48.252.7:27115";
		textBlock29.FontSize = 8.0;
		textBlock29.Foreground = new ImmutableSolidColorBrush(uint.MaxValue);
		StaticResourceExtension staticResourceExtension8 = new StaticResourceExtension("FontStyle_1");
		context.ProvideTargetProperty = TextBlock.FontFamilyProperty;
		object? obj8 = staticResourceExtension8.ProvideValue(context);
		context.ProvideTargetProperty = null;
		CompiledAvaloniaXaml.XamlDynamicSetters._003C_003EXamlDynamicSetter_2(textBlock29, obj8);
		textBlock29.VerticalAlignment = VerticalAlignment.Center;
		context.PopParent();
		((ISupportInitialize)textBlock28).EndInit();
		context.PopParent();
		((ISupportInitialize)stackPanel16).EndInit();
		context.PopParent();
		((ISupportInitialize)button3).EndInit();
		Avalonia.Controls.Controls children24 = stackPanel13.Children;
		Button button7;
		Button button6 = (button7 = new Button());
		((ISupportInitialize)button6).BeginInit();
		children24.Add(button6);
		Button button8 = (button4 = button7);
		context.PushParent(button4);
		Button button9 = button4;
		button9.Name = "BtnAwp";
		element = button9;
		context.AvaloniaNameScope.Register("BtnAwp", element);
		button9.Classes.Add("ServerBtn");
		button9.AddHandler((RoutedEvent)Button.ClickEvent, (Delegate)new EventHandler<RoutedEventArgs>(context.RootObject.CopyServer_Click), RoutingStrategies.Direct | RoutingStrategies.Bubble, handledEventsToo: false);
		button9.Tag = "connect 95.213.255.151:27315";
		StackPanel stackPanel19;
		StackPanel stackPanel18 = (stackPanel19 = new StackPanel());
		((ISupportInitialize)stackPanel18).BeginInit();
		button9.Content = stackPanel18;
		StackPanel stackPanel20 = (stackPanel4 = stackPanel19);
		context.PushParent(stackPanel4);
		StackPanel stackPanel21 = stackPanel4;
		stackPanel21.Orientation = Orientation.Horizontal;
		stackPanel21.Spacing = 5.0;
		Avalonia.Controls.Controls children25 = stackPanel21.Children;
		TextBlock textBlock31;
		TextBlock textBlock30 = (textBlock31 = new TextBlock());
		((ISupportInitialize)textBlock30).BeginInit();
		children25.Add(textBlock30);
		TextBlock textBlock32 = (textBlock4 = textBlock31);
		context.PushParent(textBlock4);
		TextBlock textBlock33 = textBlock4;
		textBlock33.Text = "Awp:";
		textBlock33.FontSize = 9.0;
		textBlock33.Foreground = new ImmutableSolidColorBrush(4294937600u);
		StaticResourceExtension staticResourceExtension9 = new StaticResourceExtension("FontStyle_1");
		context.ProvideTargetProperty = TextBlock.FontFamilyProperty;
		object? obj9 = staticResourceExtension9.ProvideValue(context);
		context.ProvideTargetProperty = null;
		CompiledAvaloniaXaml.XamlDynamicSetters._003C_003EXamlDynamicSetter_2(textBlock33, obj9);
		textBlock33.VerticalAlignment = VerticalAlignment.Center;
		context.PopParent();
		((ISupportInitialize)textBlock32).EndInit();
		Avalonia.Controls.Controls children26 = stackPanel21.Children;
		TextBlock textBlock35;
		TextBlock textBlock34 = (textBlock35 = new TextBlock());
		((ISupportInitialize)textBlock34).BeginInit();
		children26.Add(textBlock34);
		TextBlock textBlock36 = (textBlock4 = textBlock35);
		context.PushParent(textBlock4);
		TextBlock textBlock37 = textBlock4;
		textBlock37.Text = "connect 95.213.255.151:27315";
		textBlock37.FontSize = 8.0;
		textBlock37.Foreground = new ImmutableSolidColorBrush(uint.MaxValue);
		StaticResourceExtension staticResourceExtension10 = new StaticResourceExtension("FontStyle_1");
		context.ProvideTargetProperty = TextBlock.FontFamilyProperty;
		object? obj10 = staticResourceExtension10.ProvideValue(context);
		context.ProvideTargetProperty = null;
		CompiledAvaloniaXaml.XamlDynamicSetters._003C_003EXamlDynamicSetter_2(textBlock37, obj10);
		textBlock37.VerticalAlignment = VerticalAlignment.Center;
		context.PopParent();
		((ISupportInitialize)textBlock36).EndInit();
		context.PopParent();
		((ISupportInitialize)stackPanel20).EndInit();
		context.PopParent();
		((ISupportInitialize)button8).EndInit();
		Avalonia.Controls.Controls children27 = stackPanel13.Children;
		Button button11;
		Button button10 = (button11 = new Button());
		((ISupportInitialize)button10).BeginInit();
		children27.Add(button10);
		Button button12 = (button4 = button11);
		context.PushParent(button4);
		Button button13 = button4;
		button13.Name = "BtnDust";
		element = button13;
		context.AvaloniaNameScope.Register("BtnDust", element);
		button13.Classes.Add("ServerBtn");
		button13.AddHandler((RoutedEvent)Button.ClickEvent, (Delegate)new EventHandler<RoutedEventArgs>(context.RootObject.CopyServer_Click), RoutingStrategies.Direct | RoutingStrategies.Bubble, handledEventsToo: false);
		button13.Tag = "connect 45.95.31.32:27115";
		StackPanel stackPanel23;
		StackPanel stackPanel22 = (stackPanel23 = new StackPanel());
		((ISupportInitialize)stackPanel22).BeginInit();
		button13.Content = stackPanel22;
		StackPanel stackPanel24 = (stackPanel4 = stackPanel23);
		context.PushParent(stackPanel4);
		StackPanel stackPanel25 = stackPanel4;
		stackPanel25.Orientation = Orientation.Horizontal;
		stackPanel25.Spacing = 5.0;
		Avalonia.Controls.Controls children28 = stackPanel25.Children;
		TextBlock textBlock39;
		TextBlock textBlock38 = (textBlock39 = new TextBlock());
		((ISupportInitialize)textBlock38).BeginInit();
		children28.Add(textBlock38);
		TextBlock textBlock40 = (textBlock4 = textBlock39);
		context.PushParent(textBlock4);
		TextBlock textBlock41 = textBlock4;
		textBlock41.Text = "Dust:";
		textBlock41.FontSize = 9.0;
		textBlock41.Foreground = new ImmutableSolidColorBrush(4294937600u);
		StaticResourceExtension staticResourceExtension11 = new StaticResourceExtension("FontStyle_1");
		context.ProvideTargetProperty = TextBlock.FontFamilyProperty;
		object? obj11 = staticResourceExtension11.ProvideValue(context);
		context.ProvideTargetProperty = null;
		CompiledAvaloniaXaml.XamlDynamicSetters._003C_003EXamlDynamicSetter_2(textBlock41, obj11);
		textBlock41.VerticalAlignment = VerticalAlignment.Center;
		context.PopParent();
		((ISupportInitialize)textBlock40).EndInit();
		Avalonia.Controls.Controls children29 = stackPanel25.Children;
		TextBlock textBlock43;
		TextBlock textBlock42 = (textBlock43 = new TextBlock());
		((ISupportInitialize)textBlock42).BeginInit();
		children29.Add(textBlock42);
		TextBlock textBlock44 = (textBlock4 = textBlock43);
		context.PushParent(textBlock4);
		TextBlock textBlock45 = textBlock4;
		textBlock45.Text = "connect 45.95.31.32:27115";
		textBlock45.FontSize = 8.0;
		textBlock45.Foreground = new ImmutableSolidColorBrush(uint.MaxValue);
		StaticResourceExtension staticResourceExtension12 = new StaticResourceExtension("FontStyle_1");
		context.ProvideTargetProperty = TextBlock.FontFamilyProperty;
		object? obj12 = staticResourceExtension12.ProvideValue(context);
		context.ProvideTargetProperty = null;
		CompiledAvaloniaXaml.XamlDynamicSetters._003C_003EXamlDynamicSetter_2(textBlock45, obj12);
		textBlock45.VerticalAlignment = VerticalAlignment.Center;
		context.PopParent();
		((ISupportInitialize)textBlock44).EndInit();
		context.PopParent();
		((ISupportInitialize)stackPanel24).EndInit();
		context.PopParent();
		((ISupportInitialize)button12).EndInit();
		Avalonia.Controls.Controls children30 = stackPanel13.Children;
		TextBlock textBlock47;
		TextBlock textBlock46 = (textBlock47 = new TextBlock());
		((ISupportInitialize)textBlock46).BeginInit();
		children30.Add(textBlock46);
		TextBlock textBlock48 = (textBlock4 = textBlock47);
		context.PushParent(textBlock4);
		TextBlock textBlock49 = textBlock4;
		textBlock49.Name = "CopyStatus";
		element = textBlock49;
		context.AvaloniaNameScope.Register("CopyStatus", element);
		textBlock49.FontSize = 8.0;
		textBlock49.Foreground = new ImmutableSolidColorBrush(uint.MaxValue);
		StaticResourceExtension staticResourceExtension13 = new StaticResourceExtension("FontStyle_1");
		context.ProvideTargetProperty = TextBlock.FontFamilyProperty;
		object? obj13 = staticResourceExtension13.ProvideValue(context);
		context.ProvideTargetProperty = null;
		CompiledAvaloniaXaml.XamlDynamicSetters._003C_003EXamlDynamicSetter_2(textBlock49, obj13);
		textBlock49.HorizontalAlignment = HorizontalAlignment.Center;
		textBlock49.Margin = new Thickness(0.0, 2.0, 0.0, 0.0);
		textBlock49.Opacity = 0.0;
		context.PopParent();
		((ISupportInitialize)textBlock48).EndInit();
		context.PopParent();
		((ISupportInitialize)stackPanel12).EndInit();
		context.PopParent();
		((ISupportInitialize)border34).EndInit();
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

	private static void _0021XamlIlPopulateTrampoline(MainMenu P_0)
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
