using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Presenters;
using Avalonia.Controls.Primitives;
using Avalonia.Data;
using Avalonia.Input;
using Avalonia.Interactivity;
using Avalonia.Layout;
using Avalonia.Markup.Xaml;
using Avalonia.Markup.Xaml.MarkupExtensions;
using Avalonia.Markup.Xaml.Templates;
using Avalonia.Markup.Xaml.XamlIl.Runtime;
using Avalonia.Media;
using Avalonia.Media.Immutable;
using Avalonia.Styling;
using CompiledAvaloniaXaml;
using HamburgerMenu.Services;

namespace HamburgerMenu.Controls;

[CompilerGenerated]
public class SubmenuAnalytics : UserControl
{
	[CompilerGenerated]
	private class XamlClosure_1
	{
		public static object Build_1(IServiceProvider P_0)
		{
			CompiledAvaloniaXaml.XamlIlContext.Context<SubmenuAnalytics> context = CreateContext(P_0);
			context.IntermediateRoot = new StackPanel();
			object obj = context.IntermediateRoot;
			((ISupportInitialize)obj).BeginInit();
			StackPanel stackPanel = (StackPanel)obj;
			context.PushParent(stackPanel);
			StackPanel stackPanel2 = stackPanel;
			stackPanel2.Spacing = 2.0;
			Avalonia.Controls.Controls children = stackPanel2.Children;
			StackPanel stackPanel4;
			StackPanel stackPanel3 = (stackPanel4 = new StackPanel());
			((ISupportInitialize)stackPanel3).BeginInit();
			children.Add(stackPanel3);
			StackPanel stackPanel5 = (stackPanel = stackPanel4);
			context.PushParent(stackPanel);
			StackPanel stackPanel6 = stackPanel;
			stackPanel6.Orientation = Orientation.Horizontal;
			stackPanel6.Spacing = 8.0;
			Avalonia.Controls.Controls children2 = stackPanel6.Children;
			Border border2;
			Border border = (border2 = new Border());
			((ISupportInitialize)border).BeginInit();
			children2.Add(border);
			Border border4;
			Border border3 = (border4 = border2);
			context.PushParent(border4);
			Border border5 = border4;
			border5.Background = new ImmutableSolidColorBrush(4294919236u);
			border5.CornerRadius = new CornerRadius(3.0, 3.0, 3.0, 3.0);
			border5.Padding = new Thickness(5.0, 2.0, 5.0, 2.0);
			TextBlock textBlock2;
			TextBlock textBlock = (textBlock2 = new TextBlock());
			((ISupportInitialize)textBlock).BeginInit();
			border5.Child = textBlock;
			TextBlock textBlock4;
			TextBlock textBlock3 = (textBlock4 = textBlock2);
			context.PushParent(textBlock4);
			TextBlock textBlock5 = textBlock4;
			StyledProperty<string?> textProperty = TextBlock.TextProperty;
			ReflectionBindingExtension reflectionBindingExtension = new ReflectionBindingExtension("DetectionType");
			context.ProvideTargetProperty = TextBlock.TextProperty;
			Binding binding = reflectionBindingExtension.ProvideValue(context);
			context.ProvideTargetProperty = null;
			AvaloniaObjectExtensions.Bind(textBlock5, textProperty, binding);
			textBlock5.Foreground = new ImmutableSolidColorBrush(uint.MaxValue);
			textBlock5.FontSize = 10.0;
			textBlock5.FontWeight = FontWeight.Bold;
			context.PopParent();
			((ISupportInitialize)textBlock3).EndInit();
			context.PopParent();
			((ISupportInitialize)border3).EndInit();
			Avalonia.Controls.Controls children3 = stackPanel6.Children;
			TextBlock textBlock7;
			TextBlock textBlock6 = (textBlock7 = new TextBlock());
			((ISupportInitialize)textBlock6).BeginInit();
			children3.Add(textBlock6);
			TextBlock textBlock8 = (textBlock4 = textBlock7);
			context.PushParent(textBlock4);
			TextBlock textBlock9 = textBlock4;
			StyledProperty<string?> textProperty2 = TextBlock.TextProperty;
			ReflectionBindingExtension reflectionBindingExtension2 = new ReflectionBindingExtension("CheatName");
			context.ProvideTargetProperty = TextBlock.TextProperty;
			Binding binding2 = reflectionBindingExtension2.ProvideValue(context);
			context.ProvideTargetProperty = null;
			AvaloniaObjectExtensions.Bind(textBlock9, textProperty2, binding2);
			textBlock9.Foreground = new ImmutableSolidColorBrush(4294937600u);
			textBlock9.FontWeight = FontWeight.Bold;
			context.PopParent();
			((ISupportInitialize)textBlock8).EndInit();
			Avalonia.Controls.Controls children4 = stackPanel6.Children;
			Border border7;
			Border border6 = (border7 = new Border());
			((ISupportInitialize)border6).BeginInit();
			children4.Add(border6);
			Border border8 = (border4 = border7);
			context.PushParent(border4);
			Border border9 = border4;
			border9.Background = new ImmutableSolidColorBrush(4283215696u);
			border9.CornerRadius = new CornerRadius(3.0, 3.0, 3.0, 3.0);
			border9.Padding = new Thickness(5.0, 2.0, 5.0, 2.0);
			TextBlock textBlock11;
			TextBlock textBlock10 = (textBlock11 = new TextBlock());
			((ISupportInitialize)textBlock10).BeginInit();
			border9.Child = textBlock10;
			TextBlock textBlock12 = (textBlock4 = textBlock11);
			context.PushParent(textBlock4);
			TextBlock textBlock13 = textBlock4;
			StyledProperty<string?> textProperty3 = TextBlock.TextProperty;
			ReflectionBindingExtension obj2 = new ReflectionBindingExtension("Confidence")
			{
				StringFormat = "{0}%"
			};
			context.ProvideTargetProperty = TextBlock.TextProperty;
			Binding binding3 = obj2.ProvideValue(context);
			context.ProvideTargetProperty = null;
			AvaloniaObjectExtensions.Bind(textBlock13, textProperty3, binding3);
			textBlock13.Foreground = new ImmutableSolidColorBrush(uint.MaxValue);
			textBlock13.FontSize = 10.0;
			textBlock13.FontWeight = FontWeight.Bold;
			context.PopParent();
			((ISupportInitialize)textBlock12).EndInit();
			context.PopParent();
			((ISupportInitialize)border8).EndInit();
			context.PopParent();
			((ISupportInitialize)stackPanel5).EndInit();
			Avalonia.Controls.Controls children5 = stackPanel2.Children;
			TextBlock textBlock15;
			TextBlock textBlock14 = (textBlock15 = new TextBlock());
			((ISupportInitialize)textBlock14).BeginInit();
			children5.Add(textBlock14);
			TextBlock textBlock16 = (textBlock4 = textBlock15);
			context.PushParent(textBlock4);
			TextBlock textBlock17 = textBlock4;
			StyledProperty<string?> textProperty4 = TextBlock.TextProperty;
			ReflectionBindingExtension reflectionBindingExtension3 = new ReflectionBindingExtension("FileName");
			context.ProvideTargetProperty = TextBlock.TextProperty;
			Binding binding4 = reflectionBindingExtension3.ProvideValue(context);
			context.ProvideTargetProperty = null;
			AvaloniaObjectExtensions.Bind(textBlock17, textProperty4, binding4);
			textBlock17.Foreground = new ImmutableSolidColorBrush(4293322470u);
			textBlock17.FontSize = 11.0;
			context.PopParent();
			((ISupportInitialize)textBlock16).EndInit();
			Avalonia.Controls.Controls children6 = stackPanel2.Children;
			TextBlock textBlock19;
			TextBlock textBlock18 = (textBlock19 = new TextBlock());
			((ISupportInitialize)textBlock18).BeginInit();
			children6.Add(textBlock18);
			TextBlock textBlock20 = (textBlock4 = textBlock19);
			context.PushParent(textBlock4);
			TextBlock textBlock21 = textBlock4;
			StyledProperty<string?> textProperty5 = TextBlock.TextProperty;
			ReflectionBindingExtension reflectionBindingExtension4 = new ReflectionBindingExtension("FilePath");
			context.ProvideTargetProperty = TextBlock.TextProperty;
			Binding binding5 = reflectionBindingExtension4.ProvideValue(context);
			context.ProvideTargetProperty = null;
			AvaloniaObjectExtensions.Bind(textBlock21, textProperty5, binding5);
			textBlock21.Foreground = new ImmutableSolidColorBrush(4286611584u);
			textBlock21.FontSize = 10.0;
			textBlock21.TextTrimming = TextTrimming.CharacterEllipsis;
			context.PopParent();
			((ISupportInitialize)textBlock20).EndInit();
			context.PopParent();
			((ISupportInitialize)obj).EndInit();
			return obj;
		}

		public static CompiledAvaloniaXaml.XamlIlContext.Context<SubmenuAnalytics> CreateContext(IServiceProvider P_0)
		{
			CompiledAvaloniaXaml.XamlIlContext.Context<SubmenuAnalytics> context = new CompiledAvaloniaXaml.XamlIlContext.Context<SubmenuAnalytics>(P_0, new object[1] { _0021AvaloniaResources.NamespaceInfo_003A_002FControls_002FSubmenuAnalytics_002Eaxaml.Singleton }, "avares://HamburgerMenu.Avalonia/Controls/SubmenuAnalytics.axaml");
			if (P_0 != null)
			{
				object service = P_0.GetService(typeof(IRootObjectProvider));
				if (service != null)
				{
					service = ((IRootObjectProvider)service).RootObject;
					context.RootObject = (SubmenuAnalytics)service;
				}
			}
			return context;
		}
	}

	[GeneratedCode("Avalonia.Generators.NameGenerator.InitializeComponentCodeGenerator", "11.2.1.0")]
	internal Border AnalyticsPanel;

	[GeneratedCode("Avalonia.Generators.NameGenerator.InitializeComponentCodeGenerator", "11.2.1.0")]
	internal ListBox ResultsListBox;

	private static Action<object> _0021XamlIlPopulateOverride;

	public SubmenuAnalytics()
	{
		InitializeComponent();
		base.DataContext = new AnalyticsViewModel();
	}

	private void OpenInExplorer_Click(object? sender, RoutedEventArgs e)
	{
		string text = null;
		if (ResultsListBox.SelectedItem is CheatScanResult cheatScanResult)
		{
			text = cheatScanResult.FilePath;
		}
		else if (sender is MenuItem menuItem)
		{
			for (StyledElement styledElement = menuItem.Parent; styledElement != null; styledElement = (styledElement as Control)?.Parent)
			{
				if (styledElement is ContextMenu { DataContext: CheatScanResult dataContext })
				{
					text = dataContext.FilePath;
					break;
				}
			}
		}
		if (string.IsNullOrEmpty(text))
		{
			return;
		}
		try
		{
			if (File.Exists(text))
			{
				Process.Start("explorer.exe", "/select,\"" + text + "\"");
				return;
			}
			string directoryName = Path.GetDirectoryName(text);
			if (Directory.Exists(directoryName))
			{
				Process.Start("explorer.exe", directoryName);
			}
		}
		catch
		{
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
		AnalyticsPanel = nameScope?.Find<Border>("AnalyticsPanel");
		ResultsListBox = nameScope?.Find<ListBox>("ResultsListBox");
	}

	private unsafe static void _0021XamlIlPopulate(IServiceProvider P_0, SubmenuAnalytics P_1)
	{
		CompiledAvaloniaXaml.XamlIlContext.Context<SubmenuAnalytics> context = new CompiledAvaloniaXaml.XamlIlContext.Context<SubmenuAnalytics>(P_0, new object[1] { _0021AvaloniaResources.NamespaceInfo_003A_002FControls_002FSubmenuAnalytics_002Eaxaml.Singleton }, "avares://HamburgerMenu.Avalonia/Controls/SubmenuAnalytics.axaml")
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
		Border border5 = border4;
		border5.Name = "AnalyticsPanel";
		object element = border5;
		context.AvaloniaNameScope.Register("AnalyticsPanel", element);
		border5.MinWidth = 400.0;
		border5.Background = new ImmutableSolidColorBrush(4280558628u);
		border5.CornerRadius = new CornerRadius(10.0, 10.0, 10.0, 10.0);
		border5.BorderBrush = new ImmutableSolidColorBrush(4294937600u);
		border5.BorderThickness = new Thickness(0.0, 0.0, 5.0, 0.0);
		border5.HorizontalAlignment = HorizontalAlignment.Stretch;
		border5.VerticalAlignment = VerticalAlignment.Stretch;
		Grid grid2;
		Grid grid = (grid2 = new Grid());
		((ISupportInitialize)grid).BeginInit();
		border5.Child = grid;
		Grid grid4;
		Grid grid3 = (grid4 = grid2);
		context.PushParent(grid4);
		Grid grid5 = grid4;
		RowDefinitions rowDefinitions = new RowDefinitions();
		rowDefinitions.Capacity = 4;
		rowDefinitions.Add(new RowDefinition(new GridLength(0.0, GridUnitType.Auto)));
		rowDefinitions.Add(new RowDefinition(new GridLength(0.0, GridUnitType.Auto)));
		rowDefinitions.Add(new RowDefinition(new GridLength(0.0, GridUnitType.Auto)));
		rowDefinitions.Add(new RowDefinition(new GridLength(1.0, GridUnitType.Star)));
		grid5.RowDefinitions = rowDefinitions;
		Avalonia.Controls.Controls children = grid5.Children;
		Border border7;
		Border border6 = (border7 = new Border());
		((ISupportInitialize)border6).BeginInit();
		children.Add(border6);
		Border border8 = (border4 = border7);
		context.PushParent(border4);
		Border border9 = border4;
		Grid.SetRow(border9, 0);
		border9.Background = new ImmutableSolidColorBrush(4281677109u);
		border9.CornerRadius = new CornerRadius(10.0, 0.0, 0.0, 0.0);
		border9.Padding = new Thickness(15.0, 10.0, 15.0, 10.0);
		TextBlock textBlock2;
		TextBlock textBlock = (textBlock2 = new TextBlock());
		((ISupportInitialize)textBlock).BeginInit();
		border9.Child = textBlock;
		TextBlock textBlock4;
		TextBlock textBlock3 = (textBlock4 = textBlock2);
		context.PushParent(textBlock4);
		TextBlock textBlock5 = textBlock4;
		textBlock5.Text = "Cheat Scanner";
		textBlock5.FontSize = 18.0;
		textBlock5.FontWeight = FontWeight.Bold;
		textBlock5.Foreground = new ImmutableSolidColorBrush(4294937600u);
		StaticResourceExtension staticResourceExtension = new StaticResourceExtension("FontStyle_1");
		context.ProvideTargetProperty = TextBlock.FontFamilyProperty;
		object? obj = staticResourceExtension.ProvideValue(context);
		context.ProvideTargetProperty = null;
		CompiledAvaloniaXaml.XamlDynamicSetters._003C_003EXamlDynamicSetter_2(textBlock5, obj);
		context.PopParent();
		((ISupportInitialize)textBlock3).EndInit();
		context.PopParent();
		((ISupportInitialize)border8).EndInit();
		Avalonia.Controls.Controls children2 = grid5.Children;
		Border border11;
		Border border10 = (border11 = new Border());
		((ISupportInitialize)border10).BeginInit();
		children2.Add(border10);
		Border border12 = (border4 = border11);
		context.PushParent(border4);
		Border border13 = border4;
		Grid.SetRow(border13, 1);
		border13.Background = new ImmutableSolidColorBrush(4280953386u);
		border13.Margin = new Thickness(10.0, 10.0, 10.0, 5.0);
		border13.CornerRadius = new CornerRadius(8.0, 8.0, 8.0, 8.0);
		border13.Padding = new Thickness(15.0, 15.0, 15.0, 15.0);
		StackPanel stackPanel2;
		StackPanel stackPanel = (stackPanel2 = new StackPanel());
		((ISupportInitialize)stackPanel).BeginInit();
		border13.Child = stackPanel;
		StackPanel stackPanel4;
		StackPanel stackPanel3 = (stackPanel4 = stackPanel2);
		context.PushParent(stackPanel4);
		StackPanel stackPanel5 = stackPanel4;
		stackPanel5.Spacing = 12.0;
		Avalonia.Controls.Controls children3 = stackPanel5.Children;
		Button button2;
		Button button = (button2 = new Button());
		((ISupportInitialize)button).BeginInit();
		children3.Add(button);
		Button button4;
		Button button3 = (button4 = button2);
		context.PushParent(button4);
		Button button5 = button4;
		button5.Content = "\ud83d\udd0d Поиск читов";
		StyledProperty<ICommand?> commandProperty = Button.CommandProperty;
		ReflectionBindingExtension reflectionBindingExtension = new ReflectionBindingExtension("ShowScanOptionsCommand");
		context.ProvideTargetProperty = Button.CommandProperty;
		Binding binding = reflectionBindingExtension.ProvideValue(context);
		context.ProvideTargetProperty = null;
		AvaloniaObjectExtensions.Bind(button5, commandProperty, binding);
		StyledProperty<bool> isVisibleProperty = Visual.IsVisibleProperty;
		ReflectionBindingExtension reflectionBindingExtension2 = new ReflectionBindingExtension("!ShowScanOptions");
		context.ProvideTargetProperty = Visual.IsVisibleProperty;
		Binding binding2 = reflectionBindingExtension2.ProvideValue(context);
		context.ProvideTargetProperty = null;
		AvaloniaObjectExtensions.Bind(button5, isVisibleProperty, binding2);
		button5.Background = new ImmutableSolidColorBrush(4294937600u);
		button5.Foreground = new ImmutableSolidColorBrush(uint.MaxValue);
		button5.Padding = new Thickness(25.0, 12.0, 25.0, 12.0);
		button5.CornerRadius = new CornerRadius(8.0, 8.0, 8.0, 8.0);
		button5.FontWeight = FontWeight.Bold;
		button5.FontSize = 14.0;
		button5.HorizontalAlignment = HorizontalAlignment.Center;
		context.PopParent();
		((ISupportInitialize)button3).EndInit();
		Avalonia.Controls.Controls children4 = stackPanel5.Children;
		StackPanel stackPanel7;
		StackPanel stackPanel6 = (stackPanel7 = new StackPanel());
		((ISupportInitialize)stackPanel6).BeginInit();
		children4.Add(stackPanel6);
		StackPanel stackPanel8 = (stackPanel4 = stackPanel7);
		context.PushParent(stackPanel4);
		StackPanel stackPanel9 = stackPanel4;
		StyledProperty<bool> isVisibleProperty2 = Visual.IsVisibleProperty;
		ReflectionBindingExtension reflectionBindingExtension3 = new ReflectionBindingExtension("ShowScanOptions");
		context.ProvideTargetProperty = Visual.IsVisibleProperty;
		Binding binding3 = reflectionBindingExtension3.ProvideValue(context);
		context.ProvideTargetProperty = null;
		AvaloniaObjectExtensions.Bind(stackPanel9, isVisibleProperty2, binding3);
		stackPanel9.Spacing = 10.0;
		Avalonia.Controls.Controls children5 = stackPanel9.Children;
		TextBlock textBlock7;
		TextBlock textBlock6 = (textBlock7 = new TextBlock());
		((ISupportInitialize)textBlock6).BeginInit();
		children5.Add(textBlock6);
		textBlock7.Text = "Выберите тип сканирования:";
		textBlock7.Foreground = new ImmutableSolidColorBrush(4293322470u);
		textBlock7.FontSize = 13.0;
		textBlock7.HorizontalAlignment = HorizontalAlignment.Center;
		textBlock7.Margin = new Thickness(0.0, 0.0, 0.0, 5.0);
		((ISupportInitialize)textBlock7).EndInit();
		Avalonia.Controls.Controls children6 = stackPanel9.Children;
		StackPanel stackPanel11;
		StackPanel stackPanel10 = (stackPanel11 = new StackPanel());
		((ISupportInitialize)stackPanel10).BeginInit();
		children6.Add(stackPanel10);
		StackPanel stackPanel12 = (stackPanel4 = stackPanel11);
		context.PushParent(stackPanel4);
		StackPanel stackPanel13 = stackPanel4;
		stackPanel13.Orientation = Orientation.Horizontal;
		stackPanel13.Spacing = 15.0;
		stackPanel13.HorizontalAlignment = HorizontalAlignment.Center;
		Avalonia.Controls.Controls children7 = stackPanel13.Children;
		Button button7;
		Button button6 = (button7 = new Button());
		((ISupportInitialize)button6).BeginInit();
		children7.Add(button6);
		Button button8 = (button4 = button7);
		context.PushParent(button4);
		Button button9 = button4;
		StyledProperty<ICommand?> commandProperty2 = Button.CommandProperty;
		ReflectionBindingExtension reflectionBindingExtension4 = new ReflectionBindingExtension("FullScanCommand");
		context.ProvideTargetProperty = Button.CommandProperty;
		Binding binding4 = reflectionBindingExtension4.ProvideValue(context);
		context.ProvideTargetProperty = null;
		AvaloniaObjectExtensions.Bind(button9, commandProperty2, binding4);
		button9.Background = new ImmutableSolidColorBrush(4294919236u);
		button9.Foreground = new ImmutableSolidColorBrush(uint.MaxValue);
		button9.Padding = new Thickness(20.0, 12.0, 20.0, 12.0);
		button9.CornerRadius = new CornerRadius(8.0, 8.0, 8.0, 8.0);
		button9.FontWeight = FontWeight.Bold;
		StyledProperty<bool> isEnabledProperty = InputElement.IsEnabledProperty;
		ReflectionBindingExtension reflectionBindingExtension5 = new ReflectionBindingExtension("!IsScanning");
		context.ProvideTargetProperty = InputElement.IsEnabledProperty;
		Binding binding5 = reflectionBindingExtension5.ProvideValue(context);
		context.ProvideTargetProperty = null;
		AvaloniaObjectExtensions.Bind(button9, isEnabledProperty, binding5);
		StackPanel stackPanel15;
		StackPanel stackPanel14 = (stackPanel15 = new StackPanel());
		((ISupportInitialize)stackPanel14).BeginInit();
		button9.Content = stackPanel14;
		stackPanel15.Spacing = 3.0;
		Avalonia.Controls.Controls children8 = stackPanel15.Children;
		TextBlock textBlock9;
		TextBlock textBlock8 = (textBlock9 = new TextBlock());
		((ISupportInitialize)textBlock8).BeginInit();
		children8.Add(textBlock8);
		textBlock9.Text = "\ud83d\udda5\ufe0f Полное";
		textBlock9.HorizontalAlignment = HorizontalAlignment.Center;
		textBlock9.FontSize = 13.0;
		((ISupportInitialize)textBlock9).EndInit();
		Avalonia.Controls.Controls children9 = stackPanel15.Children;
		TextBlock textBlock11;
		TextBlock textBlock10 = (textBlock11 = new TextBlock());
		((ISupportInitialize)textBlock10).BeginInit();
		children9.Add(textBlock10);
		textBlock11.Text = "Все диски + USB";
		textBlock11.HorizontalAlignment = HorizontalAlignment.Center;
		textBlock11.FontSize = 10.0;
		textBlock11.Foreground = new ImmutableSolidColorBrush(4291611852u);
		((ISupportInitialize)textBlock11).EndInit();
		((ISupportInitialize)stackPanel15).EndInit();
		context.PopParent();
		((ISupportInitialize)button8).EndInit();
		Avalonia.Controls.Controls children10 = stackPanel13.Children;
		Button button11;
		Button button10 = (button11 = new Button());
		((ISupportInitialize)button10).BeginInit();
		children10.Add(button10);
		Button button12 = (button4 = button11);
		context.PushParent(button4);
		Button button13 = button4;
		StyledProperty<ICommand?> commandProperty3 = Button.CommandProperty;
		ReflectionBindingExtension reflectionBindingExtension6 = new ReflectionBindingExtension("QuickScanCommand");
		context.ProvideTargetProperty = Button.CommandProperty;
		Binding binding6 = reflectionBindingExtension6.ProvideValue(context);
		context.ProvideTargetProperty = null;
		AvaloniaObjectExtensions.Bind(button13, commandProperty3, binding6);
		button13.Background = new ImmutableSolidColorBrush(4294937600u);
		button13.Foreground = new ImmutableSolidColorBrush(uint.MaxValue);
		button13.Padding = new Thickness(20.0, 12.0, 20.0, 12.0);
		button13.CornerRadius = new CornerRadius(8.0, 8.0, 8.0, 8.0);
		button13.FontWeight = FontWeight.Bold;
		StyledProperty<bool> isEnabledProperty2 = InputElement.IsEnabledProperty;
		ReflectionBindingExtension reflectionBindingExtension7 = new ReflectionBindingExtension("!IsScanning");
		context.ProvideTargetProperty = InputElement.IsEnabledProperty;
		Binding binding7 = reflectionBindingExtension7.ProvideValue(context);
		context.ProvideTargetProperty = null;
		AvaloniaObjectExtensions.Bind(button13, isEnabledProperty2, binding7);
		StackPanel stackPanel17;
		StackPanel stackPanel16 = (stackPanel17 = new StackPanel());
		((ISupportInitialize)stackPanel16).BeginInit();
		button13.Content = stackPanel16;
		stackPanel17.Spacing = 3.0;
		Avalonia.Controls.Controls children11 = stackPanel17.Children;
		TextBlock textBlock13;
		TextBlock textBlock12 = (textBlock13 = new TextBlock());
		((ISupportInitialize)textBlock12).BeginInit();
		children11.Add(textBlock12);
		textBlock13.Text = "⚡ Быстрое";
		textBlock13.HorizontalAlignment = HorizontalAlignment.Center;
		textBlock13.FontSize = 13.0;
		((ISupportInitialize)textBlock13).EndInit();
		Avalonia.Controls.Controls children12 = stackPanel17.Children;
		TextBlock textBlock15;
		TextBlock textBlock14 = (textBlock15 = new TextBlock());
		((ISupportInitialize)textBlock14).BeginInit();
		children12.Add(textBlock14);
		textBlock15.Text = "Только диск C:";
		textBlock15.HorizontalAlignment = HorizontalAlignment.Center;
		textBlock15.FontSize = 10.0;
		textBlock15.Foreground = new ImmutableSolidColorBrush(4291611852u);
		((ISupportInitialize)textBlock15).EndInit();
		((ISupportInitialize)stackPanel17).EndInit();
		context.PopParent();
		((ISupportInitialize)button12).EndInit();
		context.PopParent();
		((ISupportInitialize)stackPanel12).EndInit();
		Avalonia.Controls.Controls children13 = stackPanel9.Children;
		Button button15;
		Button button14 = (button15 = new Button());
		((ISupportInitialize)button14).BeginInit();
		children13.Add(button14);
		Button button16 = (button4 = button15);
		context.PushParent(button4);
		Button button17 = button4;
		button17.Content = "← Назад";
		StyledProperty<ICommand?> commandProperty4 = Button.CommandProperty;
		ReflectionBindingExtension reflectionBindingExtension8 = new ReflectionBindingExtension("HideScanOptionsCommand");
		context.ProvideTargetProperty = Button.CommandProperty;
		Binding binding8 = reflectionBindingExtension8.ProvideValue(context);
		context.ProvideTargetProperty = null;
		AvaloniaObjectExtensions.Bind(button17, commandProperty4, binding8);
		button17.Background = new ImmutableSolidColorBrush(4283782485u);
		button17.Foreground = new ImmutableSolidColorBrush(uint.MaxValue);
		button17.Padding = new Thickness(15.0, 6.0, 15.0, 6.0);
		button17.CornerRadius = new CornerRadius(5.0, 5.0, 5.0, 5.0);
		button17.HorizontalAlignment = HorizontalAlignment.Center;
		button17.Margin = new Thickness(0.0, 5.0, 0.0, 0.0);
		StyledProperty<bool> isVisibleProperty3 = Visual.IsVisibleProperty;
		ReflectionBindingExtension reflectionBindingExtension9 = new ReflectionBindingExtension("!IsScanning");
		context.ProvideTargetProperty = Visual.IsVisibleProperty;
		Binding binding9 = reflectionBindingExtension9.ProvideValue(context);
		context.ProvideTargetProperty = null;
		AvaloniaObjectExtensions.Bind(button17, isVisibleProperty3, binding9);
		context.PopParent();
		((ISupportInitialize)button16).EndInit();
		context.PopParent();
		((ISupportInitialize)stackPanel8).EndInit();
		context.PopParent();
		((ISupportInitialize)stackPanel3).EndInit();
		context.PopParent();
		((ISupportInitialize)border12).EndInit();
		Avalonia.Controls.Controls children14 = grid5.Children;
		Border border15;
		Border border14 = (border15 = new Border());
		((ISupportInitialize)border14).BeginInit();
		children14.Add(border14);
		Border border16 = (border4 = border15);
		context.PushParent(border4);
		Border border17 = border4;
		Grid.SetRow(border17, 2);
		border17.Background = new ImmutableSolidColorBrush(4280953386u);
		border17.Margin = new Thickness(10.0, 5.0, 10.0, 5.0);
		border17.CornerRadius = new CornerRadius(8.0, 8.0, 8.0, 8.0);
		border17.Padding = new Thickness(10.0, 8.0, 10.0, 8.0);
		Grid grid7;
		Grid grid6 = (grid7 = new Grid());
		((ISupportInitialize)grid6).BeginInit();
		border17.Child = grid6;
		Grid grid8 = (grid4 = grid7);
		context.PushParent(grid4);
		Grid grid9 = grid4;
		ColumnDefinitions columnDefinitions = new ColumnDefinitions();
		columnDefinitions.Capacity = 2;
		columnDefinitions.Add(new ColumnDefinition(new GridLength(1.0, GridUnitType.Star)));
		columnDefinitions.Add(new ColumnDefinition(new GridLength(0.0, GridUnitType.Auto)));
		grid9.ColumnDefinitions = columnDefinitions;
		Avalonia.Controls.Controls children15 = grid9.Children;
		StackPanel stackPanel19;
		StackPanel stackPanel18 = (stackPanel19 = new StackPanel());
		((ISupportInitialize)stackPanel18).BeginInit();
		children15.Add(stackPanel18);
		StackPanel stackPanel20 = (stackPanel4 = stackPanel19);
		context.PushParent(stackPanel4);
		StackPanel stackPanel21 = stackPanel4;
		Grid.SetColumn(stackPanel21, 0);
		stackPanel21.Orientation = Orientation.Horizontal;
		stackPanel21.Spacing = 15.0;
		Avalonia.Controls.Controls children16 = stackPanel21.Children;
		TextBlock textBlock17;
		TextBlock textBlock16 = (textBlock17 = new TextBlock());
		((ISupportInitialize)textBlock16).BeginInit();
		children16.Add(textBlock16);
		TextBlock textBlock18 = (textBlock4 = textBlock17);
		context.PushParent(textBlock4);
		TextBlock textBlock19 = textBlock4;
		StyledProperty<string?> textProperty = TextBlock.TextProperty;
		ReflectionBindingExtension reflectionBindingExtension10 = new ReflectionBindingExtension("StatusText");
		context.ProvideTargetProperty = TextBlock.TextProperty;
		Binding binding10 = reflectionBindingExtension10.ProvideValue(context);
		context.ProvideTargetProperty = null;
		AvaloniaObjectExtensions.Bind(textBlock19, textProperty, binding10);
		textBlock19.Foreground = new ImmutableSolidColorBrush(4291745125u);
		textBlock19.FontSize = 12.0;
		context.PopParent();
		((ISupportInitialize)textBlock18).EndInit();
		Avalonia.Controls.Controls children17 = stackPanel21.Children;
		TextBlock textBlock21;
		TextBlock textBlock20 = (textBlock21 = new TextBlock());
		((ISupportInitialize)textBlock20).BeginInit();
		children17.Add(textBlock20);
		TextBlock textBlock22 = (textBlock4 = textBlock21);
		context.PushParent(textBlock4);
		TextBlock textBlock23 = textBlock4;
		StyledProperty<string?> textProperty2 = TextBlock.TextProperty;
		ReflectionBindingExtension obj2 = new ReflectionBindingExtension("ResultCount")
		{
			StringFormat = "Найдено: {0}"
		};
		context.ProvideTargetProperty = TextBlock.TextProperty;
		Binding binding11 = obj2.ProvideValue(context);
		context.ProvideTargetProperty = null;
		AvaloniaObjectExtensions.Bind(textBlock23, textProperty2, binding11);
		textBlock23.Foreground = new ImmutableSolidColorBrush(4294937600u);
		textBlock23.FontSize = 12.0;
		textBlock23.FontWeight = FontWeight.Bold;
		context.PopParent();
		((ISupportInitialize)textBlock22).EndInit();
		context.PopParent();
		((ISupportInitialize)stackPanel20).EndInit();
		Avalonia.Controls.Controls children18 = grid9.Children;
		Button button19;
		Button button18 = (button19 = new Button());
		((ISupportInitialize)button18).BeginInit();
		children18.Add(button18);
		Button button20 = (button4 = button19);
		context.PushParent(button4);
		Button button21 = button4;
		Grid.SetColumn(button21, 1);
		button21.Content = "\ud83d\udcc4 Export Log";
		StyledProperty<ICommand?> commandProperty5 = Button.CommandProperty;
		ReflectionBindingExtension reflectionBindingExtension11 = new ReflectionBindingExtension("ExportLogCommand");
		context.ProvideTargetProperty = Button.CommandProperty;
		Binding binding12 = reflectionBindingExtension11.ProvideValue(context);
		context.ProvideTargetProperty = null;
		AvaloniaObjectExtensions.Bind(button21, commandProperty5, binding12);
		button21.Background = new ImmutableSolidColorBrush(4283215696u);
		button21.Foreground = new ImmutableSolidColorBrush(uint.MaxValue);
		button21.Padding = new Thickness(10.0, 4.0, 10.0, 4.0);
		button21.CornerRadius = new CornerRadius(5.0, 5.0, 5.0, 5.0);
		button21.FontSize = 11.0;
		StyledProperty<bool> isVisibleProperty4 = Visual.IsVisibleProperty;
		ReflectionBindingExtension reflectionBindingExtension12 = new ReflectionBindingExtension("CanExport");
		context.ProvideTargetProperty = Visual.IsVisibleProperty;
		Binding binding13 = reflectionBindingExtension12.ProvideValue(context);
		context.ProvideTargetProperty = null;
		AvaloniaObjectExtensions.Bind(button21, isVisibleProperty4, binding13);
		context.PopParent();
		((ISupportInitialize)button20).EndInit();
		context.PopParent();
		((ISupportInitialize)grid8).EndInit();
		context.PopParent();
		((ISupportInitialize)border16).EndInit();
		Avalonia.Controls.Controls children19 = grid5.Children;
		ListBox listBox2;
		ListBox listBox = (listBox2 = new ListBox());
		((ISupportInitialize)listBox).BeginInit();
		children19.Add(listBox);
		ListBox listBox4;
		ListBox listBox3 = (listBox4 = listBox2);
		context.PushParent(listBox4);
		Grid.SetRow(listBox4, 3);
		listBox4.Name = "ResultsListBox";
		element = listBox4;
		context.AvaloniaNameScope.Register("ResultsListBox", element);
		StyledProperty<IEnumerable?> itemsSourceProperty = ItemsControl.ItemsSourceProperty;
		ReflectionBindingExtension reflectionBindingExtension13 = new ReflectionBindingExtension("Results");
		context.ProvideTargetProperty = ItemsControl.ItemsSourceProperty;
		Binding binding14 = reflectionBindingExtension13.ProvideValue(context);
		context.ProvideTargetProperty = null;
		AvaloniaObjectExtensions.Bind(listBox4, itemsSourceProperty, binding14);
		listBox4.Background = new ImmutableSolidColorBrush(16777215u);
		listBox4.Margin = new Thickness(10.0, 5.0, 10.0, 10.0);
		listBox4.BorderThickness = new Thickness(0.0, 0.0, 0.0, 0.0);
		listBox4.SelectionMode = SelectionMode.Single;
		Styles styles = listBox4.Styles;
		Style style = new Style();
		style.Selector = ((Selector?)null).OfType(typeof(ListBoxItem));
		Setter setter = new Setter();
		setter.Property = TemplatedControl.PaddingProperty;
		setter.Value = new Thickness(8.0, 6.0, 8.0, 6.0);
		style.Add(setter);
		Setter setter2 = new Setter();
		setter2.Property = Layoutable.MarginProperty;
		setter2.Value = new Thickness(0.0, 2.0, 0.0, 2.0);
		style.Add(setter2);
		Setter setter3 = new Setter();
		setter3.Property = TemplatedControl.BackgroundProperty;
		setter3.Value = new ImmutableSolidColorBrush(4281677109u);
		style.Add(setter3);
		Setter setter4 = new Setter();
		setter4.Property = TemplatedControl.CornerRadiusProperty;
		setter4.Value = new CornerRadius(5.0, 5.0, 5.0, 5.0);
		style.Add(setter4);
		Setter setter5 = new Setter();
		setter5.Property = TemplatedControl.ForegroundProperty;
		setter5.Value = new ImmutableSolidColorBrush(uint.MaxValue);
		style.Add(setter5);
		Setter setter6 = new Setter();
		setter6.Property = Control.ContextMenuProperty;
		ContextMenu contextMenu2;
		ContextMenu contextMenu = (contextMenu2 = new ContextMenu());
		((ISupportInitialize)contextMenu).BeginInit();
		setter6.Value = contextMenu;
		ItemCollection items = contextMenu2.Items;
		MenuItem menuItem2;
		MenuItem menuItem = (menuItem2 = new MenuItem());
		((ISupportInitialize)menuItem).BeginInit();
		items.Add(menuItem);
		menuItem2.Header = "\ud83d\udcc2 Открыть в проводнике";
		menuItem2.AddHandler((RoutedEvent)MenuItem.ClickEvent, (Delegate)new EventHandler<RoutedEventArgs>(context.RootObject.OpenInExplorer_Click), RoutingStrategies.Direct | RoutingStrategies.Bubble, handledEventsToo: false);
		((ISupportInitialize)menuItem2).EndInit();
		((ISupportInitialize)contextMenu2).EndInit();
		style.Add(setter6);
		styles.Add(style);
		Styles styles2 = listBox4.Styles;
		Style style2 = new Style();
		style2.Selector = ((Selector?)null).OfType(typeof(ListBoxItem)).Class(":pointerover");
		Setter setter7 = new Setter();
		setter7.Property = TemplatedControl.BackgroundProperty;
		setter7.Value = new ImmutableSolidColorBrush(4282729797u);
		style2.Add(setter7);
		styles2.Add(style2);
		Styles styles3 = listBox4.Styles;
		Style style3 = new Style();
		style3.Selector = ((Selector?)null).OfType(typeof(ListBoxItem)).Class(":selected");
		Setter setter8 = new Setter();
		setter8.Property = TemplatedControl.BackgroundProperty;
		setter8.Value = new ImmutableSolidColorBrush(4281677109u);
		style3.Add(setter8);
		styles3.Add(style3);
		Styles styles4 = listBox4.Styles;
		Style style4 = new Style();
		style4.Selector = ((Selector?)null).OfType(typeof(ListBoxItem)).Class(":selected").Class(":pointerover");
		Setter setter9 = new Setter();
		setter9.Property = TemplatedControl.BackgroundProperty;
		setter9.Value = new ImmutableSolidColorBrush(4282729797u);
		style4.Add(setter9);
		styles4.Add(style4);
		Styles styles5 = listBox4.Styles;
		Style style5 = new Style();
		style5.Selector = ((Selector?)null).OfType(typeof(ListBoxItem)).Class(":selected").Class(":focus");
		Setter setter10 = new Setter();
		setter10.Property = TemplatedControl.BackgroundProperty;
		setter10.Value = new ImmutableSolidColorBrush(4281677109u);
		style5.Add(setter10);
		styles5.Add(style5);
		Styles styles6 = listBox4.Styles;
		Style style6 = new Style();
		style6.Selector = ((Selector?)null).OfType(typeof(ListBoxItem)).Class(":pressed");
		Setter setter11 = new Setter();
		setter11.Property = TemplatedControl.BackgroundProperty;
		setter11.Value = new ImmutableSolidColorBrush(4281677109u);
		style6.Add(setter11);
		styles6.Add(style6);
		Styles styles7 = listBox4.Styles;
		Style style7 = new Style();
		style7.Selector = ((Selector?)null).OfType(typeof(ListBoxItem)).Class(":selected").Template()
			.OfType(typeof(ContentPresenter))
			.Name("PART_ContentPresenter");
		Setter setter12 = new Setter();
		setter12.Property = ContentPresenter.BackgroundProperty;
		setter12.Value = new ImmutableSolidColorBrush(16777215u);
		style7.Add(setter12);
		styles7.Add(style7);
		Styles styles8 = listBox4.Styles;
		Style style8 = new Style();
		style8.Selector = ((Selector?)null).OfType(typeof(ListBoxItem)).Class(":selected").Template()
			.OfType(typeof(Border));
		Setter setter13 = new Setter();
		setter13.Property = Border.BackgroundProperty;
		setter13.Value = new ImmutableSolidColorBrush(16777215u);
		style8.Add(setter13);
		styles8.Add(style8);
		DataTemplate dataTemplate;
		DataTemplate itemTemplate = (dataTemplate = new DataTemplate());
		context.PushParent(dataTemplate);
		dataTemplate.Content = XamlIlRuntimeHelpers.DeferredTransformationFactoryV3<Control>((nint)(delegate*<IServiceProvider, object>)(&XamlClosure_1.Build_1), context);
		context.PopParent();
		listBox4.ItemTemplate = itemTemplate;
		context.PopParent();
		((ISupportInitialize)listBox3).EndInit();
		context.PopParent();
		((ISupportInitialize)grid3).EndInit();
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

	private static void _0021XamlIlPopulateTrampoline(SubmenuAnalytics P_0)
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
