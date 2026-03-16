using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Avalonia;
using Avalonia.Animation;
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
public class TrackOne : UserControl
{
	[GeneratedCode("Avalonia.Generators.NameGenerator.InitializeComponentCodeGenerator", "11.2.1.0")]
	internal Border Submenu_Out;

	[GeneratedCode("Avalonia.Generators.NameGenerator.InitializeComponentCodeGenerator", "11.2.1.0")]
	internal Image T1_Close;

	[GeneratedCode("Avalonia.Generators.NameGenerator.InitializeComponentCodeGenerator", "11.2.1.0")]
	internal Border Submenu_In;

	[GeneratedCode("Avalonia.Generators.NameGenerator.InitializeComponentCodeGenerator", "11.2.1.0")]
	internal Image T1_Open;

	private static Action<object> _0021XamlIlPopulateOverride;

	public TrackOne()
	{
		InitializeComponent();
		base.Loaded += OnLoaded;
	}

	private void OnLoaded(object? sender, RoutedEventArgs e)
	{
		Submenu_Out.RenderTransform = new TranslateTransform(0.0, 0.0);
		Submenu_In.RenderTransform = new TranslateTransform(0.0, 0.0);
	}

	public async void OpenTrackOne()
	{
		for (int i = 0; i < 3; i++)
		{
			T1_Open.Opacity = 0.0;
			await Task.Delay(100);
			T1_Open.Opacity = 1.0;
			await Task.Delay(100);
		}
	}

	public async void CloseTrackOne()
	{
		for (int i = 0; i < 3; i++)
		{
			T1_Close.Opacity = 0.0;
			await Task.Delay(100);
			T1_Close.Opacity = 1.0;
			await Task.Delay(100);
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
		Submenu_Out = nameScope?.Find<Border>("Submenu_Out");
		T1_Close = nameScope?.Find<Image>("T1_Close");
		Submenu_In = nameScope?.Find<Border>("Submenu_In");
		T1_Open = nameScope?.Find<Image>("T1_Open");
	}

	private static void _0021XamlIlPopulate(IServiceProvider P_0, TrackOne P_1)
	{
		CompiledAvaloniaXaml.XamlIlContext.Context<TrackOne> context = new CompiledAvaloniaXaml.XamlIlContext.Context<TrackOne>(P_0, new object[1] { _0021AvaloniaResources.NamespaceInfo_003A_002FControls_002FTrackOne_002Eaxaml.Singleton }, "avares://HamburgerMenu.Avalonia/Controls/TrackOne.axaml")
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
		border5.Name = "Submenu_Out";
		object element = border5;
		context.AvaloniaNameScope.Register("Submenu_Out", element);
		Grid.SetRow(border5, 0);
		border5.Height = 35.0;
		border5.Background = new ImmutableSolidColorBrush(4281677109u);
		border5.CornerRadius = new CornerRadius(10.0, 10.0, 10.0, 10.0);
		border5.BorderBrush = new ImmutableSolidColorBrush(4294937600u);
		border5.BorderThickness = new Thickness(5.0, 0.0, 0.0, 0.0);
		border5.HorizontalAlignment = HorizontalAlignment.Left;
		border5.VerticalAlignment = VerticalAlignment.Top;
		border5.Margin = new Thickness(20.0, 30.0, 0.0, 0.0);
		border5.RenderTransform = (ITransform)new TransformConverter().ConvertFrom(context, CultureInfo.InvariantCulture, "translateY(-75px)");
		Transitions transitions = new Transitions();
		TransformOperationsTransition transformOperationsTransition = new TransformOperationsTransition();
		transformOperationsTransition.Property = Visual.RenderTransformProperty;
		transformOperationsTransition.Duration = TimeSpan.FromTicks(3000000L);
		transformOperationsTransition.Delay = TimeSpan.FromTicks(15000000L);
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
		panel5.MinWidth = 200.0;
		panel5.MaxWidth = 300.0;
		Avalonia.Controls.Controls children2 = panel5.Children;
		Border border7;
		Border border6 = (border7 = new Border());
		((ISupportInitialize)border6).BeginInit();
		children2.Add(border6);
		border7.Height = 32.0;
		border7.Background = new ImmutableSolidColorBrush(4294937600u);
		border7.Margin = new Thickness(0.0, -66.0, 65.0, 0.0);
		border7.BorderBrush = new ImmutableSolidColorBrush(16777215u);
		border7.BorderThickness = new Thickness(0.0, 0.0, 0.0, 0.0);
		((ISupportInitialize)border7).EndInit();
		Avalonia.Controls.Controls children3 = panel5.Children;
		Image image2;
		Image image = (image2 = new Image());
		((ISupportInitialize)image).BeginInit();
		children3.Add(image);
		Image image4;
		Image image3 = (image4 = image2);
		context.PushParent(image4);
		Image image5 = image4;
		image5.Name = "T1_Close";
		element = image5;
		context.AvaloniaNameScope.Register("T1_Close", element);
		StaticResourceExtension staticResourceExtension = new StaticResourceExtension("ST_1");
		context.ProvideTargetProperty = Image.SourceProperty;
		object? obj = staticResourceExtension.ProvideValue(context);
		context.ProvideTargetProperty = null;
		CompiledAvaloniaXaml.XamlDynamicSetters._003C_003EXamlDynamicSetter_1(image5, obj);
		image5.Stretch = Stretch.None;
		image5.HorizontalAlignment = HorizontalAlignment.Right;
		image5.VerticalAlignment = VerticalAlignment.Center;
		image5.Margin = new Thickness(0.0, 0.0, 10.0, 0.0);
		Transitions transitions2 = new Transitions();
		DoubleTransition doubleTransition = new DoubleTransition();
		doubleTransition.Property = Visual.OpacityProperty;
		doubleTransition.Duration = TimeSpan.FromTicks(1000000L);
		transitions2.Add(doubleTransition);
		image5.Transitions = transitions2;
		context.PopParent();
		((ISupportInitialize)image3).EndInit();
		Avalonia.Controls.Controls children4 = panel5.Children;
		TextBlock textBlock2;
		TextBlock textBlock = (textBlock2 = new TextBlock());
		((ISupportInitialize)textBlock).BeginInit();
		children4.Add(textBlock);
		TextBlock textBlock4;
		TextBlock textBlock3 = (textBlock4 = textBlock2);
		context.PushParent(textBlock4);
		TextBlock textBlock5 = textBlock4;
		textBlock5.FontSize = 12.0;
		StaticResourceExtension staticResourceExtension2 = new StaticResourceExtension("FontStyle_1");
		context.ProvideTargetProperty = TextBlock.FontFamilyProperty;
		object? obj2 = staticResourceExtension2.ProvideValue(context);
		context.ProvideTargetProperty = null;
		CompiledAvaloniaXaml.XamlDynamicSetters._003C_003EXamlDynamicSetter_2(textBlock5, obj2);
		textBlock5.Foreground = new ImmutableSolidColorBrush(uint.MaxValue);
		textBlock5.Text = "MENU TRACK - I";
		textBlock5.VerticalAlignment = VerticalAlignment.Center;
		textBlock5.HorizontalAlignment = HorizontalAlignment.Left;
		textBlock5.Margin = new Thickness(20.0, 0.0, 70.0, 0.0);
		context.PopParent();
		((ISupportInitialize)textBlock3).EndInit();
		context.PopParent();
		((ISupportInitialize)panel3).EndInit();
		context.PopParent();
		((ISupportInitialize)border3).EndInit();
		Avalonia.Controls.Controls children5 = grid4.Children;
		Border border9;
		Border border8 = (border9 = new Border());
		((ISupportInitialize)border8).BeginInit();
		children5.Add(border8);
		Border border10 = (border4 = border9);
		context.PushParent(border4);
		Border border11 = border4;
		border11.Name = "Submenu_In";
		element = border11;
		context.AvaloniaNameScope.Register("Submenu_In", element);
		Grid.SetRow(border11, 2);
		border11.Height = 35.0;
		border11.Background = new ImmutableSolidColorBrush(4281677109u);
		border11.CornerRadius = new CornerRadius(10.0, 10.0, 10.0, 10.0);
		border11.BorderBrush = new ImmutableSolidColorBrush(4294937600u);
		border11.BorderThickness = new Thickness(0.0, 0.0, 5.0, 0.0);
		border11.HorizontalAlignment = HorizontalAlignment.Left;
		border11.VerticalAlignment = VerticalAlignment.Bottom;
		border11.Margin = new Thickness(20.0, 0.0, 0.0, 30.0);
		border11.RenderTransform = (ITransform)new TransformConverter().ConvertFrom(context, CultureInfo.InvariantCulture, "translateY(75px)");
		Transitions transitions3 = new Transitions();
		TransformOperationsTransition transformOperationsTransition2 = new TransformOperationsTransition();
		transformOperationsTransition2.Property = Visual.RenderTransformProperty;
		transformOperationsTransition2.Duration = TimeSpan.FromTicks(3000000L);
		transformOperationsTransition2.Delay = TimeSpan.FromTicks(15000000L);
		transitions3.Add(transformOperationsTransition2);
		border11.Transitions = transitions3;
		Panel panel7;
		Panel panel6 = (panel7 = new Panel());
		((ISupportInitialize)panel6).BeginInit();
		border11.Child = panel6;
		Panel panel8 = (panel4 = panel7);
		context.PushParent(panel4);
		Panel panel9 = panel4;
		panel9.MinWidth = 200.0;
		panel9.MaxWidth = 300.0;
		Avalonia.Controls.Controls children6 = panel9.Children;
		Border border13;
		Border border12 = (border13 = new Border());
		((ISupportInitialize)border12).BeginInit();
		children6.Add(border12);
		border13.Height = 32.0;
		border13.Background = new ImmutableSolidColorBrush(4294937600u);
		border13.Margin = new Thickness(65.0, 0.0, 0.0, -67.0);
		border13.BorderBrush = new ImmutableSolidColorBrush(16777215u);
		border13.BorderThickness = new Thickness(0.0, 0.0, 0.0, 0.0);
		((ISupportInitialize)border13).EndInit();
		Avalonia.Controls.Controls children7 = panel9.Children;
		Image image7;
		Image image6 = (image7 = new Image());
		((ISupportInitialize)image6).BeginInit();
		children7.Add(image6);
		Image image8 = (image4 = image7);
		context.PushParent(image4);
		Image image9 = image4;
		image9.Name = "T1_Open";
		element = image9;
		context.AvaloniaNameScope.Register("T1_Open", element);
		StaticResourceExtension staticResourceExtension3 = new StaticResourceExtension("ST_2");
		context.ProvideTargetProperty = Image.SourceProperty;
		object? obj3 = staticResourceExtension3.ProvideValue(context);
		context.ProvideTargetProperty = null;
		CompiledAvaloniaXaml.XamlDynamicSetters._003C_003EXamlDynamicSetter_1(image9, obj3);
		image9.Stretch = Stretch.None;
		image9.HorizontalAlignment = HorizontalAlignment.Left;
		image9.VerticalAlignment = VerticalAlignment.Center;
		image9.Margin = new Thickness(10.0, 0.0, 0.0, 0.0);
		Transitions transitions4 = new Transitions();
		DoubleTransition doubleTransition2 = new DoubleTransition();
		doubleTransition2.Property = Visual.OpacityProperty;
		doubleTransition2.Duration = TimeSpan.FromTicks(1000000L);
		transitions4.Add(doubleTransition2);
		image9.Transitions = transitions4;
		context.PopParent();
		((ISupportInitialize)image8).EndInit();
		Avalonia.Controls.Controls children8 = panel9.Children;
		TextBlock textBlock7;
		TextBlock textBlock6 = (textBlock7 = new TextBlock());
		((ISupportInitialize)textBlock6).BeginInit();
		children8.Add(textBlock6);
		TextBlock textBlock8 = (textBlock4 = textBlock7);
		context.PushParent(textBlock4);
		TextBlock textBlock9 = textBlock4;
		textBlock9.FontSize = 12.0;
		StaticResourceExtension staticResourceExtension4 = new StaticResourceExtension("FontStyle_1");
		context.ProvideTargetProperty = TextBlock.FontFamilyProperty;
		object? obj4 = staticResourceExtension4.ProvideValue(context);
		context.ProvideTargetProperty = null;
		CompiledAvaloniaXaml.XamlDynamicSetters._003C_003EXamlDynamicSetter_2(textBlock9, obj4);
		textBlock9.Foreground = new ImmutableSolidColorBrush(uint.MaxValue);
		textBlock9.Text = "MENU TRACK - I";
		textBlock9.VerticalAlignment = VerticalAlignment.Center;
		textBlock9.HorizontalAlignment = HorizontalAlignment.Right;
		textBlock9.Margin = new Thickness(70.0, 0.0, 20.0, 0.0);
		context.PopParent();
		((ISupportInitialize)textBlock8).EndInit();
		context.PopParent();
		((ISupportInitialize)panel8).EndInit();
		context.PopParent();
		((ISupportInitialize)border10).EndInit();
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

	private static void _0021XamlIlPopulateTrampoline(TrackOne P_0)
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
