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
public class TrackTwo : UserControl
{
	[GeneratedCode("Avalonia.Generators.NameGenerator.InitializeComponentCodeGenerator", "11.2.1.0")]
	internal Border SubmenuTwo_In_Out;

	[GeneratedCode("Avalonia.Generators.NameGenerator.InitializeComponentCodeGenerator", "11.2.1.0")]
	internal Image T2_Open;

	[GeneratedCode("Avalonia.Generators.NameGenerator.InitializeComponentCodeGenerator", "11.2.1.0")]
	internal Image T2_Close;

	private static Action<object> _0021XamlIlPopulateOverride;

	public TrackTwo()
	{
		InitializeComponent();
		base.Loaded += OnLoaded;
	}

	private void OnLoaded(object? sender, RoutedEventArgs e)
	{
		SubmenuTwo_In_Out.RenderTransform = new TranslateTransform(0.0, 0.0);
	}

	public async void OpenTrackTwo()
	{
		for (int i = 0; i < 3; i++)
		{
			T2_Open.Opacity = 0.0;
			await Task.Delay(100);
			T2_Open.Opacity = 1.0;
			await Task.Delay(100);
		}
	}

	public async void CloseTrackTwo()
	{
		for (int i = 0; i < 3; i++)
		{
			T2_Close.Opacity = 0.0;
			await Task.Delay(100);
			T2_Close.Opacity = 1.0;
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
		SubmenuTwo_In_Out = nameScope?.Find<Border>("SubmenuTwo_In_Out");
		T2_Open = nameScope?.Find<Image>("T2_Open");
		T2_Close = nameScope?.Find<Image>("T2_Close");
	}

	private static void _0021XamlIlPopulate(IServiceProvider P_0, TrackTwo P_1)
	{
		CompiledAvaloniaXaml.XamlIlContext.Context<TrackTwo> context = new CompiledAvaloniaXaml.XamlIlContext.Context<TrackTwo>(P_0, new object[1] { _0021AvaloniaResources.NamespaceInfo_003A_002FControls_002FTrackTwo_002Eaxaml.Singleton }, "avares://HamburgerMenu.Avalonia/Controls/TrackTwo.axaml")
		{
			RootObject = P_1,
			IntermediateRoot = P_1
		};
		((ISupportInitialize)P_1).BeginInit();
		context.PushParent(P_1);
		Border border2;
		Border border = (border2 = new Border());
		((ISupportInitialize)border).BeginInit();
		P_1.Content = border;
		Border border4;
		Border border3 = (border4 = border2);
		context.PushParent(border4);
		border4.Name = "SubmenuTwo_In_Out";
		object element = border4;
		context.AvaloniaNameScope.Register("SubmenuTwo_In_Out", element);
		border4.Width = 35.0;
		border4.Background = new ImmutableSolidColorBrush(4281677109u);
		border4.CornerRadius = new CornerRadius(0.0, 0.0, 0.0, 0.0);
		border4.BorderBrush = new ImmutableSolidColorBrush(16777215u);
		border4.BorderThickness = new Thickness(0.0, 0.0, 0.0, 0.0);
		border4.VerticalAlignment = VerticalAlignment.Stretch;
		border4.HorizontalAlignment = HorizontalAlignment.Right;
		border4.Margin = new Thickness(0.0, 65.0, 17.0, 65.0);
		border4.RenderTransform = (ITransform)new TransformConverter().ConvertFrom(context, CultureInfo.InvariantCulture, "translateX(55px)");
		Transitions transitions = new Transitions();
		TransformOperationsTransition transformOperationsTransition = new TransformOperationsTransition();
		transformOperationsTransition.Property = Visual.RenderTransformProperty;
		transformOperationsTransition.Duration = TimeSpan.FromTicks(2500000L);
		transformOperationsTransition.Delay = TimeSpan.FromTicks(20000000L);
		transitions.Add(transformOperationsTransition);
		border4.Transitions = transitions;
		Panel panel2;
		Panel panel = (panel2 = new Panel());
		((ISupportInitialize)panel).BeginInit();
		border4.Child = panel;
		Panel panel4;
		Panel panel3 = (panel4 = panel2);
		context.PushParent(panel4);
		Avalonia.Controls.Controls children = panel4.Children;
		Image image2;
		Image image = (image2 = new Image());
		((ISupportInitialize)image).BeginInit();
		children.Add(image);
		Image image4;
		Image image3 = (image4 = image2);
		context.PushParent(image4);
		Image image5 = image4;
		image5.Name = "T2_Open";
		element = image5;
		context.AvaloniaNameScope.Register("T2_Open", element);
		StaticResourceExtension staticResourceExtension = new StaticResourceExtension("SMTR_1");
		context.ProvideTargetProperty = Image.SourceProperty;
		object? obj = staticResourceExtension.ProvideValue(context);
		context.ProvideTargetProperty = null;
		CompiledAvaloniaXaml.XamlDynamicSetters._003C_003EXamlDynamicSetter_1(image5, obj);
		image5.Stretch = Stretch.None;
		image5.HorizontalAlignment = HorizontalAlignment.Center;
		image5.VerticalAlignment = VerticalAlignment.Top;
		image5.Margin = new Thickness(0.0, 10.0, 0.0, 0.0);
		Transitions transitions2 = new Transitions();
		DoubleTransition doubleTransition = new DoubleTransition();
		doubleTransition.Property = Visual.OpacityProperty;
		doubleTransition.Duration = TimeSpan.FromTicks(1000000L);
		transitions2.Add(doubleTransition);
		image5.Transitions = transitions2;
		context.PopParent();
		((ISupportInitialize)image3).EndInit();
		Avalonia.Controls.Controls children2 = panel4.Children;
		Image image7;
		Image image6 = (image7 = new Image());
		((ISupportInitialize)image6).BeginInit();
		children2.Add(image6);
		Image image8 = (image4 = image7);
		context.PushParent(image4);
		Image image9 = image4;
		image9.Name = "T2_Close";
		element = image9;
		context.AvaloniaNameScope.Register("T2_Close", element);
		StaticResourceExtension staticResourceExtension2 = new StaticResourceExtension("SMTR_2");
		context.ProvideTargetProperty = Image.SourceProperty;
		object? obj2 = staticResourceExtension2.ProvideValue(context);
		context.ProvideTargetProperty = null;
		CompiledAvaloniaXaml.XamlDynamicSetters._003C_003EXamlDynamicSetter_1(image9, obj2);
		image9.Stretch = Stretch.None;
		image9.HorizontalAlignment = HorizontalAlignment.Center;
		image9.VerticalAlignment = VerticalAlignment.Bottom;
		image9.Margin = new Thickness(0.0, 0.0, 0.0, 10.0);
		Transitions transitions3 = new Transitions();
		DoubleTransition doubleTransition2 = new DoubleTransition();
		doubleTransition2.Property = Visual.OpacityProperty;
		doubleTransition2.Duration = TimeSpan.FromTicks(1000000L);
		transitions3.Add(doubleTransition2);
		image9.Transitions = transitions3;
		context.PopParent();
		((ISupportInitialize)image8).EndInit();
		Avalonia.Controls.Controls children3 = panel4.Children;
		StackPanel stackPanel2;
		StackPanel stackPanel = (stackPanel2 = new StackPanel());
		((ISupportInitialize)stackPanel).BeginInit();
		children3.Add(stackPanel);
		StackPanel stackPanel4;
		StackPanel stackPanel3 = (stackPanel4 = stackPanel2);
		context.PushParent(stackPanel4);
		stackPanel4.HorizontalAlignment = HorizontalAlignment.Center;
		stackPanel4.VerticalAlignment = VerticalAlignment.Center;
		stackPanel4.Margin = new Thickness(0.0, 40.0, 0.0, 0.0);
		stackPanel4.Spacing = 5.0;
		Avalonia.Controls.Controls children4 = stackPanel4.Children;
		TextBlock textBlock2;
		TextBlock textBlock = (textBlock2 = new TextBlock());
		((ISupportInitialize)textBlock).BeginInit();
		children4.Add(textBlock);
		TextBlock textBlock4;
		TextBlock textBlock3 = (textBlock4 = textBlock2);
		context.PushParent(textBlock4);
		TextBlock textBlock5 = textBlock4;
		textBlock5.FontSize = 12.0;
		StaticResourceExtension staticResourceExtension3 = new StaticResourceExtension("FontStyle_1");
		context.ProvideTargetProperty = TextBlock.FontFamilyProperty;
		object? obj3 = staticResourceExtension3.ProvideValue(context);
		context.ProvideTargetProperty = null;
		CompiledAvaloniaXaml.XamlDynamicSetters._003C_003EXamlDynamicSetter_2(textBlock5, obj3);
		textBlock5.Foreground = new ImmutableSolidColorBrush(uint.MaxValue);
		textBlock5.Text = "M";
		textBlock5.HorizontalAlignment = HorizontalAlignment.Center;
		context.PopParent();
		((ISupportInitialize)textBlock3).EndInit();
		Avalonia.Controls.Controls children5 = stackPanel4.Children;
		TextBlock textBlock7;
		TextBlock textBlock6 = (textBlock7 = new TextBlock());
		((ISupportInitialize)textBlock6).BeginInit();
		children5.Add(textBlock6);
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
		textBlock9.Text = "E";
		textBlock9.HorizontalAlignment = HorizontalAlignment.Center;
		context.PopParent();
		((ISupportInitialize)textBlock8).EndInit();
		Avalonia.Controls.Controls children6 = stackPanel4.Children;
		TextBlock textBlock11;
		TextBlock textBlock10 = (textBlock11 = new TextBlock());
		((ISupportInitialize)textBlock10).BeginInit();
		children6.Add(textBlock10);
		TextBlock textBlock12 = (textBlock4 = textBlock11);
		context.PushParent(textBlock4);
		TextBlock textBlock13 = textBlock4;
		textBlock13.FontSize = 12.0;
		StaticResourceExtension staticResourceExtension5 = new StaticResourceExtension("FontStyle_1");
		context.ProvideTargetProperty = TextBlock.FontFamilyProperty;
		object? obj5 = staticResourceExtension5.ProvideValue(context);
		context.ProvideTargetProperty = null;
		CompiledAvaloniaXaml.XamlDynamicSetters._003C_003EXamlDynamicSetter_2(textBlock13, obj5);
		textBlock13.Foreground = new ImmutableSolidColorBrush(uint.MaxValue);
		textBlock13.Text = "N";
		textBlock13.HorizontalAlignment = HorizontalAlignment.Center;
		context.PopParent();
		((ISupportInitialize)textBlock12).EndInit();
		Avalonia.Controls.Controls children7 = stackPanel4.Children;
		TextBlock textBlock15;
		TextBlock textBlock14 = (textBlock15 = new TextBlock());
		((ISupportInitialize)textBlock14).BeginInit();
		children7.Add(textBlock14);
		TextBlock textBlock16 = (textBlock4 = textBlock15);
		context.PushParent(textBlock4);
		TextBlock textBlock17 = textBlock4;
		textBlock17.FontSize = 12.0;
		StaticResourceExtension staticResourceExtension6 = new StaticResourceExtension("FontStyle_1");
		context.ProvideTargetProperty = TextBlock.FontFamilyProperty;
		object? obj6 = staticResourceExtension6.ProvideValue(context);
		context.ProvideTargetProperty = null;
		CompiledAvaloniaXaml.XamlDynamicSetters._003C_003EXamlDynamicSetter_2(textBlock17, obj6);
		textBlock17.Foreground = new ImmutableSolidColorBrush(uint.MaxValue);
		textBlock17.Text = "U";
		textBlock17.HorizontalAlignment = HorizontalAlignment.Center;
		context.PopParent();
		((ISupportInitialize)textBlock16).EndInit();
		Avalonia.Controls.Controls children8 = stackPanel4.Children;
		TextBlock textBlock19;
		TextBlock textBlock18 = (textBlock19 = new TextBlock());
		((ISupportInitialize)textBlock18).BeginInit();
		children8.Add(textBlock18);
		TextBlock textBlock20 = (textBlock4 = textBlock19);
		context.PushParent(textBlock4);
		TextBlock textBlock21 = textBlock4;
		textBlock21.FontSize = 12.0;
		StaticResourceExtension staticResourceExtension7 = new StaticResourceExtension("FontStyle_1");
		context.ProvideTargetProperty = TextBlock.FontFamilyProperty;
		object? obj7 = staticResourceExtension7.ProvideValue(context);
		context.ProvideTargetProperty = null;
		CompiledAvaloniaXaml.XamlDynamicSetters._003C_003EXamlDynamicSetter_2(textBlock21, obj7);
		textBlock21.Foreground = new ImmutableSolidColorBrush(uint.MaxValue);
		textBlock21.Text = " ";
		textBlock21.HorizontalAlignment = HorizontalAlignment.Center;
		context.PopParent();
		((ISupportInitialize)textBlock20).EndInit();
		Avalonia.Controls.Controls children9 = stackPanel4.Children;
		TextBlock textBlock23;
		TextBlock textBlock22 = (textBlock23 = new TextBlock());
		((ISupportInitialize)textBlock22).BeginInit();
		children9.Add(textBlock22);
		TextBlock textBlock24 = (textBlock4 = textBlock23);
		context.PushParent(textBlock4);
		TextBlock textBlock25 = textBlock4;
		textBlock25.FontSize = 12.0;
		StaticResourceExtension staticResourceExtension8 = new StaticResourceExtension("FontStyle_1");
		context.ProvideTargetProperty = TextBlock.FontFamilyProperty;
		object? obj8 = staticResourceExtension8.ProvideValue(context);
		context.ProvideTargetProperty = null;
		CompiledAvaloniaXaml.XamlDynamicSetters._003C_003EXamlDynamicSetter_2(textBlock25, obj8);
		textBlock25.Foreground = new ImmutableSolidColorBrush(uint.MaxValue);
		textBlock25.Text = "T";
		textBlock25.HorizontalAlignment = HorizontalAlignment.Center;
		context.PopParent();
		((ISupportInitialize)textBlock24).EndInit();
		Avalonia.Controls.Controls children10 = stackPanel4.Children;
		TextBlock textBlock27;
		TextBlock textBlock26 = (textBlock27 = new TextBlock());
		((ISupportInitialize)textBlock26).BeginInit();
		children10.Add(textBlock26);
		TextBlock textBlock28 = (textBlock4 = textBlock27);
		context.PushParent(textBlock4);
		TextBlock textBlock29 = textBlock4;
		textBlock29.FontSize = 12.0;
		StaticResourceExtension staticResourceExtension9 = new StaticResourceExtension("FontStyle_1");
		context.ProvideTargetProperty = TextBlock.FontFamilyProperty;
		object? obj9 = staticResourceExtension9.ProvideValue(context);
		context.ProvideTargetProperty = null;
		CompiledAvaloniaXaml.XamlDynamicSetters._003C_003EXamlDynamicSetter_2(textBlock29, obj9);
		textBlock29.Foreground = new ImmutableSolidColorBrush(uint.MaxValue);
		textBlock29.Text = "R";
		textBlock29.HorizontalAlignment = HorizontalAlignment.Center;
		context.PopParent();
		((ISupportInitialize)textBlock28).EndInit();
		Avalonia.Controls.Controls children11 = stackPanel4.Children;
		TextBlock textBlock31;
		TextBlock textBlock30 = (textBlock31 = new TextBlock());
		((ISupportInitialize)textBlock30).BeginInit();
		children11.Add(textBlock30);
		TextBlock textBlock32 = (textBlock4 = textBlock31);
		context.PushParent(textBlock4);
		TextBlock textBlock33 = textBlock4;
		textBlock33.FontSize = 12.0;
		StaticResourceExtension staticResourceExtension10 = new StaticResourceExtension("FontStyle_1");
		context.ProvideTargetProperty = TextBlock.FontFamilyProperty;
		object? obj10 = staticResourceExtension10.ProvideValue(context);
		context.ProvideTargetProperty = null;
		CompiledAvaloniaXaml.XamlDynamicSetters._003C_003EXamlDynamicSetter_2(textBlock33, obj10);
		textBlock33.Foreground = new ImmutableSolidColorBrush(uint.MaxValue);
		textBlock33.Text = "A";
		textBlock33.HorizontalAlignment = HorizontalAlignment.Center;
		context.PopParent();
		((ISupportInitialize)textBlock32).EndInit();
		Avalonia.Controls.Controls children12 = stackPanel4.Children;
		TextBlock textBlock35;
		TextBlock textBlock34 = (textBlock35 = new TextBlock());
		((ISupportInitialize)textBlock34).BeginInit();
		children12.Add(textBlock34);
		TextBlock textBlock36 = (textBlock4 = textBlock35);
		context.PushParent(textBlock4);
		TextBlock textBlock37 = textBlock4;
		textBlock37.FontSize = 12.0;
		StaticResourceExtension staticResourceExtension11 = new StaticResourceExtension("FontStyle_1");
		context.ProvideTargetProperty = TextBlock.FontFamilyProperty;
		object? obj11 = staticResourceExtension11.ProvideValue(context);
		context.ProvideTargetProperty = null;
		CompiledAvaloniaXaml.XamlDynamicSetters._003C_003EXamlDynamicSetter_2(textBlock37, obj11);
		textBlock37.Foreground = new ImmutableSolidColorBrush(uint.MaxValue);
		textBlock37.Text = "C";
		textBlock37.HorizontalAlignment = HorizontalAlignment.Center;
		context.PopParent();
		((ISupportInitialize)textBlock36).EndInit();
		Avalonia.Controls.Controls children13 = stackPanel4.Children;
		TextBlock textBlock39;
		TextBlock textBlock38 = (textBlock39 = new TextBlock());
		((ISupportInitialize)textBlock38).BeginInit();
		children13.Add(textBlock38);
		TextBlock textBlock40 = (textBlock4 = textBlock39);
		context.PushParent(textBlock4);
		TextBlock textBlock41 = textBlock4;
		textBlock41.FontSize = 12.0;
		StaticResourceExtension staticResourceExtension12 = new StaticResourceExtension("FontStyle_1");
		context.ProvideTargetProperty = TextBlock.FontFamilyProperty;
		object? obj12 = staticResourceExtension12.ProvideValue(context);
		context.ProvideTargetProperty = null;
		CompiledAvaloniaXaml.XamlDynamicSetters._003C_003EXamlDynamicSetter_2(textBlock41, obj12);
		textBlock41.Foreground = new ImmutableSolidColorBrush(uint.MaxValue);
		textBlock41.Text = "K";
		textBlock41.HorizontalAlignment = HorizontalAlignment.Center;
		context.PopParent();
		((ISupportInitialize)textBlock40).EndInit();
		Avalonia.Controls.Controls children14 = stackPanel4.Children;
		TextBlock textBlock43;
		TextBlock textBlock42 = (textBlock43 = new TextBlock());
		((ISupportInitialize)textBlock42).BeginInit();
		children14.Add(textBlock42);
		TextBlock textBlock44 = (textBlock4 = textBlock43);
		context.PushParent(textBlock4);
		TextBlock textBlock45 = textBlock4;
		textBlock45.FontSize = 12.0;
		StaticResourceExtension staticResourceExtension13 = new StaticResourceExtension("FontStyle_1");
		context.ProvideTargetProperty = TextBlock.FontFamilyProperty;
		object? obj13 = staticResourceExtension13.ProvideValue(context);
		context.ProvideTargetProperty = null;
		CompiledAvaloniaXaml.XamlDynamicSetters._003C_003EXamlDynamicSetter_2(textBlock45, obj13);
		textBlock45.Foreground = new ImmutableSolidColorBrush(uint.MaxValue);
		textBlock45.Text = " ";
		textBlock45.HorizontalAlignment = HorizontalAlignment.Center;
		context.PopParent();
		((ISupportInitialize)textBlock44).EndInit();
		Avalonia.Controls.Controls children15 = stackPanel4.Children;
		TextBlock textBlock47;
		TextBlock textBlock46 = (textBlock47 = new TextBlock());
		((ISupportInitialize)textBlock46).BeginInit();
		children15.Add(textBlock46);
		TextBlock textBlock48 = (textBlock4 = textBlock47);
		context.PushParent(textBlock4);
		TextBlock textBlock49 = textBlock4;
		textBlock49.FontSize = 12.0;
		StaticResourceExtension staticResourceExtension14 = new StaticResourceExtension("FontStyle_1");
		context.ProvideTargetProperty = TextBlock.FontFamilyProperty;
		object? obj14 = staticResourceExtension14.ProvideValue(context);
		context.ProvideTargetProperty = null;
		CompiledAvaloniaXaml.XamlDynamicSetters._003C_003EXamlDynamicSetter_2(textBlock49, obj14);
		textBlock49.Foreground = new ImmutableSolidColorBrush(uint.MaxValue);
		textBlock49.Text = "-";
		textBlock49.HorizontalAlignment = HorizontalAlignment.Center;
		context.PopParent();
		((ISupportInitialize)textBlock48).EndInit();
		Avalonia.Controls.Controls children16 = stackPanel4.Children;
		TextBlock textBlock51;
		TextBlock textBlock50 = (textBlock51 = new TextBlock());
		((ISupportInitialize)textBlock50).BeginInit();
		children16.Add(textBlock50);
		TextBlock textBlock52 = (textBlock4 = textBlock51);
		context.PushParent(textBlock4);
		TextBlock textBlock53 = textBlock4;
		textBlock53.FontSize = 12.0;
		StaticResourceExtension staticResourceExtension15 = new StaticResourceExtension("FontStyle_1");
		context.ProvideTargetProperty = TextBlock.FontFamilyProperty;
		object? obj15 = staticResourceExtension15.ProvideValue(context);
		context.ProvideTargetProperty = null;
		CompiledAvaloniaXaml.XamlDynamicSetters._003C_003EXamlDynamicSetter_2(textBlock53, obj15);
		textBlock53.Foreground = new ImmutableSolidColorBrush(uint.MaxValue);
		textBlock53.Text = " ";
		textBlock53.HorizontalAlignment = HorizontalAlignment.Center;
		context.PopParent();
		((ISupportInitialize)textBlock52).EndInit();
		Avalonia.Controls.Controls children17 = stackPanel4.Children;
		TextBlock textBlock55;
		TextBlock textBlock54 = (textBlock55 = new TextBlock());
		((ISupportInitialize)textBlock54).BeginInit();
		children17.Add(textBlock54);
		TextBlock textBlock56 = (textBlock4 = textBlock55);
		context.PushParent(textBlock4);
		TextBlock textBlock57 = textBlock4;
		textBlock57.FontSize = 12.0;
		StaticResourceExtension staticResourceExtension16 = new StaticResourceExtension("FontStyle_1");
		context.ProvideTargetProperty = TextBlock.FontFamilyProperty;
		object? obj16 = staticResourceExtension16.ProvideValue(context);
		context.ProvideTargetProperty = null;
		CompiledAvaloniaXaml.XamlDynamicSetters._003C_003EXamlDynamicSetter_2(textBlock57, obj16);
		textBlock57.Foreground = new ImmutableSolidColorBrush(uint.MaxValue);
		textBlock57.Text = "I";
		textBlock57.HorizontalAlignment = HorizontalAlignment.Center;
		context.PopParent();
		((ISupportInitialize)textBlock56).EndInit();
		Avalonia.Controls.Controls children18 = stackPanel4.Children;
		TextBlock textBlock59;
		TextBlock textBlock58 = (textBlock59 = new TextBlock());
		((ISupportInitialize)textBlock58).BeginInit();
		children18.Add(textBlock58);
		TextBlock textBlock60 = (textBlock4 = textBlock59);
		context.PushParent(textBlock4);
		TextBlock textBlock61 = textBlock4;
		textBlock61.FontSize = 12.0;
		StaticResourceExtension staticResourceExtension17 = new StaticResourceExtension("FontStyle_1");
		context.ProvideTargetProperty = TextBlock.FontFamilyProperty;
		object? obj17 = staticResourceExtension17.ProvideValue(context);
		context.ProvideTargetProperty = null;
		CompiledAvaloniaXaml.XamlDynamicSetters._003C_003EXamlDynamicSetter_2(textBlock61, obj17);
		textBlock61.Foreground = new ImmutableSolidColorBrush(uint.MaxValue);
		textBlock61.Text = "I";
		textBlock61.HorizontalAlignment = HorizontalAlignment.Center;
		context.PopParent();
		((ISupportInitialize)textBlock60).EndInit();
		context.PopParent();
		((ISupportInitialize)stackPanel3).EndInit();
		Avalonia.Controls.Controls children19 = panel4.Children;
		Border border6;
		Border border5 = (border6 = new Border());
		((ISupportInitialize)border5).BeginInit();
		children19.Add(border5);
		border6.Width = 21.0;
		border6.Background = new ImmutableSolidColorBrush(4280558628u);
		border6.HorizontalAlignment = HorizontalAlignment.Right;
		border6.Margin = new Thickness(0.0, 40.0, -56.0, 40.0);
		border6.ZIndex = 1;
		border6.BorderBrush = new ImmutableSolidColorBrush(16777215u);
		border6.BorderThickness = new Thickness(0.0, 0.0, 0.0, 0.0);
		((ISupportInitialize)border6).EndInit();
		context.PopParent();
		((ISupportInitialize)panel3).EndInit();
		context.PopParent();
		((ISupportInitialize)border3).EndInit();
		context.PopParent();
		((ISupportInitialize)P_1).EndInit();
		if (P_1 is StyledElement styled)
		{
			NameScope.SetNameScope(styled, context.AvaloniaNameScope);
		}
		context.AvaloniaNameScope.Complete();
	}

	private static void _0021XamlIlPopulateTrampoline(TrackTwo P_0)
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
