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
public class Channel : UserControl
{
	[GeneratedCode("Avalonia.Generators.NameGenerator.InitializeComponentCodeGenerator", "11.2.1.0")]
	internal Panel Level0;

	private static Action<object> _0021XamlIlPopulateOverride;

	public Channel()
	{
		InitializeComponent();
		base.Loaded += OnLoaded;
	}

	private void OnLoaded(object? sender, RoutedEventArgs e)
	{
		SetTranslateTransform(Level0, 0.0, 0.0);
	}

	private void SetTranslateTransform(Control control, double x, double y)
	{
		control.RenderTransform = new TranslateTransform(x, y);
	}

	[GeneratedCode("Avalonia.Generators.NameGenerator.InitializeComponentCodeGenerator", "11.2.1.0")]
	[ExcludeFromCodeCoverage]
	public void InitializeComponent(bool loadXaml = true)
	{
		if (loadXaml)
		{
			_0021XamlIlPopulateTrampoline(this);
		}
		Level0 = this.FindNameScope()?.Find<Panel>("Level0");
	}

	private static void _0021XamlIlPopulate(IServiceProvider P_0, Channel P_1)
	{
		CompiledAvaloniaXaml.XamlIlContext.Context<Channel> context = new CompiledAvaloniaXaml.XamlIlContext.Context<Channel>(P_0, new object[1] { _0021AvaloniaResources.NamespaceInfo_003A_002FControls_002FChannel_002Eaxaml.Singleton }, "avares://HamburgerMenu.Avalonia/Controls/Channel.axaml")
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
		Panel panel6;
		Panel panel5 = (panel6 = new Panel());
		((ISupportInitialize)panel5).BeginInit();
		children.Add(panel5);
		Panel panel7 = (panel4 = panel6);
		context.PushParent(panel4);
		Panel panel8 = panel4;
		panel8.Name = "Level0";
		object element = panel8;
		context.AvaloniaNameScope.Register("Level0", element);
		panel8.RenderTransform = (ITransform)new TransformConverter().ConvertFrom(context, CultureInfo.InvariantCulture, "translateX(450px)");
		Transitions transitions = new Transitions();
		TransformOperationsTransition transformOperationsTransition = new TransformOperationsTransition();
		transformOperationsTransition.Property = Visual.RenderTransformProperty;
		transformOperationsTransition.Duration = TimeSpan.FromTicks(3500000L);
		transformOperationsTransition.Delay = TimeSpan.FromTicks(21500000L);
		transformOperationsTransition.Easing = Easing.Parse("CircularEaseOut");
		transitions.Add(transformOperationsTransition);
		panel8.Transitions = transitions;
		Avalonia.Controls.Controls children2 = panel8.Children;
		Border border2;
		Border border = (border2 = new Border());
		((ISupportInitialize)border).BeginInit();
		children2.Add(border);
		Border border4;
		Border border3 = (border4 = border2);
		context.PushParent(border4);
		border4.Background = new ImmutableSolidColorBrush(4281677109u);
		border4.Height = 32.0;
		border4.Width = 180.0;
		border4.VerticalAlignment = VerticalAlignment.Top;
		border4.HorizontalAlignment = HorizontalAlignment.Right;
		border4.Margin = new Thickness(0.0, 30.0, 50.0, 0.0);
		border4.CornerRadius = new CornerRadius(10.0, 0.0, 0.0, 10.0);
		border4.BorderBrush = new ImmutableSolidColorBrush(4294937600u);
		border4.BorderThickness = new Thickness(5.0, 0.0, 0.0, 0.0);
		border4.RenderTransform = new SkewTransform
		{
			AngleX = -20.0
		};
		TextBlock textBlock2;
		TextBlock textBlock = (textBlock2 = new TextBlock());
		((ISupportInitialize)textBlock).BeginInit();
		border4.Child = textBlock;
		TextBlock textBlock4;
		TextBlock textBlock3 = (textBlock4 = textBlock2);
		context.PushParent(textBlock4);
		StaticResourceExtension staticResourceExtension = new StaticResourceExtension("FontStyle_1");
		context.ProvideTargetProperty = TextBlock.FontFamilyProperty;
		object? obj = staticResourceExtension.ProvideValue(context);
		context.ProvideTargetProperty = null;
		CompiledAvaloniaXaml.XamlDynamicSetters._003C_003EXamlDynamicSetter_2(textBlock4, obj);
		textBlock4.FontSize = 16.0;
		textBlock4.Foreground = new ImmutableSolidColorBrush(uint.MaxValue);
		textBlock4.Text = "Discord : fayin4";
		textBlock4.VerticalAlignment = VerticalAlignment.Center;
		textBlock4.Margin = new Thickness(15.0, 0.0, 0.0, 0.0);
		context.PopParent();
		((ISupportInitialize)textBlock3).EndInit();
		context.PopParent();
		((ISupportInitialize)border3).EndInit();
		context.PopParent();
		((ISupportInitialize)panel7).EndInit();
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

	private static void _0021XamlIlPopulateTrampoline(Channel P_0)
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
