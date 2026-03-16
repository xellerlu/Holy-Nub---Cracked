using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Layout;
using Avalonia.Markup.Xaml;
using Avalonia.Markup.Xaml.MarkupExtensions;
using Avalonia.Markup.Xaml.Templates;
using Avalonia.Markup.Xaml.XamlIl.Runtime;
using Avalonia.Media;
using Avalonia.Media.Immutable;
using Avalonia.Styling;
using CompiledAvaloniaXaml;

namespace HamburgerMenu.Controls;

[CompilerGenerated]
public class SubmenuCustomer : UserControl
{
	[CompilerGenerated]
	private class XamlClosure_2
	{
		public static object Build_1(IServiceProvider P_0)
		{
			CompiledAvaloniaXaml.XamlIlContext.Context<SubmenuCustomer> context = CreateContext(P_0);
			context.IntermediateRoot = new StackPanel();
			object obj = context.IntermediateRoot;
			((ISupportInitialize)obj).BeginInit();
			((ISupportInitialize)obj).EndInit();
			return obj;
		}

		public static CompiledAvaloniaXaml.XamlIlContext.Context<SubmenuCustomer> CreateContext(IServiceProvider P_0)
		{
			CompiledAvaloniaXaml.XamlIlContext.Context<SubmenuCustomer> context = new CompiledAvaloniaXaml.XamlIlContext.Context<SubmenuCustomer>(P_0, new object[1] { _0021AvaloniaResources.NamespaceInfo_003A_002FControls_002FSubmenuCustomer_002Eaxaml.Singleton }, "avares://HamburgerMenu.Avalonia/Controls/SubmenuCustomer.axaml");
			if (P_0 != null)
			{
				object service = P_0.GetService(typeof(IRootObjectProvider));
				if (service != null)
				{
					service = ((IRootObjectProvider)service).RootObject;
					context.RootObject = (SubmenuCustomer)service;
				}
			}
			return context;
		}

		public static object Build_2(IServiceProvider P_0)
		{
			CompiledAvaloniaXaml.XamlIlContext.Context<SubmenuCustomer> context = CreateContext(P_0);
			context.IntermediateRoot = new StackPanel();
			object obj = context.IntermediateRoot;
			((ISupportInitialize)obj).BeginInit();
			StackPanel stackPanel = (StackPanel)obj;
			context.PushParent(stackPanel);
			stackPanel.Orientation = Orientation.Horizontal;
			stackPanel.Spacing = 5.0;
			Avalonia.Controls.Controls children = stackPanel.Children;
			TextBlock textBlock2;
			TextBlock textBlock = (textBlock2 = new TextBlock());
			((ISupportInitialize)textBlock).BeginInit();
			children.Add(textBlock);
			TextBlock textBlock4;
			TextBlock textBlock3 = (textBlock4 = textBlock2);
			context.PushParent(textBlock4);
			TextBlock textBlock5 = textBlock4;
			StyledProperty<string?> textProperty = TextBlock.TextProperty;
			ReflectionBindingExtension reflectionBindingExtension = new ReflectionBindingExtension("PersonaName");
			context.ProvideTargetProperty = TextBlock.TextProperty;
			Binding binding = reflectionBindingExtension.ProvideValue(context);
			context.ProvideTargetProperty = null;
			AvaloniaObjectExtensions.Bind(textBlock5, textProperty, binding);
			textBlock5.Foreground = new ImmutableSolidColorBrush(4293322470u);
			context.PopParent();
			((ISupportInitialize)textBlock3).EndInit();
			Avalonia.Controls.Controls children2 = stackPanel.Children;
			TextBlock textBlock7;
			TextBlock textBlock6 = (textBlock7 = new TextBlock());
			((ISupportInitialize)textBlock6).BeginInit();
			children2.Add(textBlock6);
			textBlock7.Text = " (";
			textBlock7.Foreground = new ImmutableSolidColorBrush(2161168592u);
			((ISupportInitialize)textBlock7).EndInit();
			Avalonia.Controls.Controls children3 = stackPanel.Children;
			TextBlock textBlock9;
			TextBlock textBlock8 = (textBlock9 = new TextBlock());
			((ISupportInitialize)textBlock8).BeginInit();
			children3.Add(textBlock8);
			TextBlock textBlock10 = (textBlock4 = textBlock9);
			context.PushParent(textBlock4);
			TextBlock textBlock11 = textBlock4;
			StyledProperty<string?> textProperty2 = TextBlock.TextProperty;
			ReflectionBindingExtension reflectionBindingExtension2 = new ReflectionBindingExtension("SteamId2");
			context.ProvideTargetProperty = TextBlock.TextProperty;
			Binding binding2 = reflectionBindingExtension2.ProvideValue(context);
			context.ProvideTargetProperty = null;
			AvaloniaObjectExtensions.Bind(textBlock11, textProperty2, binding2);
			textBlock11.Foreground = new ImmutableSolidColorBrush(4291745125u);
			context.PopParent();
			((ISupportInitialize)textBlock10).EndInit();
			Avalonia.Controls.Controls children4 = stackPanel.Children;
			TextBlock textBlock13;
			TextBlock textBlock12 = (textBlock13 = new TextBlock());
			((ISupportInitialize)textBlock12).BeginInit();
			children4.Add(textBlock12);
			textBlock13.Text = ") - ";
			textBlock13.Foreground = new ImmutableSolidColorBrush(2161168592u);
			((ISupportInitialize)textBlock13).EndInit();
			Avalonia.Controls.Controls children5 = stackPanel.Children;
			TextBlock textBlock15;
			TextBlock textBlock14 = (textBlock15 = new TextBlock());
			((ISupportInitialize)textBlock14).BeginInit();
			children5.Add(textBlock14);
			TextBlock textBlock16 = (textBlock4 = textBlock15);
			context.PushParent(textBlock4);
			TextBlock textBlock17 = textBlock4;
			StyledProperty<string?> textProperty3 = TextBlock.TextProperty;
			ReflectionBindingExtension reflectionBindingExtension3 = new ReflectionBindingExtension("VacStatus");
			context.ProvideTargetProperty = TextBlock.TextProperty;
			Binding binding3 = reflectionBindingExtension3.ProvideValue(context);
			context.ProvideTargetProperty = null;
			AvaloniaObjectExtensions.Bind(textBlock17, textProperty3, binding3);
			textBlock17.FontWeight = FontWeight.Bold;
			Styles styles = textBlock17.Styles;
			Style style = new Style();
			style.Selector = ((Selector?)null).OfType(typeof(TextBlock));
			Setter setter = new Setter();
			setter.Property = TextBlock.ForegroundProperty;
			setter.Value = new ImmutableSolidColorBrush(4290032820u);
			style.Add(setter);
			styles.Add(style);
			context.PopParent();
			((ISupportInitialize)textBlock16).EndInit();
			context.PopParent();
			((ISupportInitialize)obj).EndInit();
			return obj;
		}
	}

	[GeneratedCode("Avalonia.Generators.NameGenerator.InitializeComponentCodeGenerator", "11.2.1.0")]
	internal Border CustomerPanel;

	[GeneratedCode("Avalonia.Generators.NameGenerator.InitializeComponentCodeGenerator", "11.2.1.0")]
	internal ListBox AccountsList;

	private static Action<object> _0021XamlIlPopulateOverride;

	public SubmenuCustomer()
	{
		InitializeComponent();
		base.DataContext = new CustomerViewModel();
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
		CustomerPanel = nameScope?.Find<Border>("CustomerPanel");
		AccountsList = nameScope?.Find<ListBox>("AccountsList");
	}

	private unsafe static void _0021XamlIlPopulate(IServiceProvider P_0, SubmenuCustomer P_1)
	{
		CompiledAvaloniaXaml.XamlIlContext.Context<SubmenuCustomer> context = new CompiledAvaloniaXaml.XamlIlContext.Context<SubmenuCustomer>(P_0, new object[1] { _0021AvaloniaResources.NamespaceInfo_003A_002FControls_002FSubmenuCustomer_002Eaxaml.Singleton }, "avares://HamburgerMenu.Avalonia/Controls/SubmenuCustomer.axaml")
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
		border5.Name = "CustomerPanel";
		object element = border5;
		context.AvaloniaNameScope.Register("CustomerPanel", element);
		border5.MinWidth = 350.0;
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
		rowDefinitions.Capacity = 3;
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
		textBlock5.Text = "Steam Accounts";
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
		border13.Padding = new Thickness(10.0, 10.0, 10.0, 10.0);
		StyledProperty<bool> isVisibleProperty = Visual.IsVisibleProperty;
		ReflectionBindingExtension obj2 = new ReflectionBindingExtension("SelectedAccount")
		{
			Converter = ObjectConverters.IsNotNull
		};
		context.ProvideTargetProperty = Visual.IsVisibleProperty;
		Binding binding = obj2.ProvideValue(context);
		context.ProvideTargetProperty = null;
		AvaloniaObjectExtensions.Bind(border13, isVisibleProperty, binding);
		Grid grid7;
		Grid grid6 = (grid7 = new Grid());
		((ISupportInitialize)grid6).BeginInit();
		border13.Child = grid6;
		Grid grid8 = (grid4 = grid7);
		context.PushParent(grid4);
		Grid grid9 = grid4;
		ColumnDefinitions columnDefinitions = new ColumnDefinitions();
		columnDefinitions.Capacity = 2;
		columnDefinitions.Add(new ColumnDefinition(new GridLength(0.0, GridUnitType.Auto)));
		columnDefinitions.Add(new ColumnDefinition(new GridLength(1.0, GridUnitType.Star)));
		grid9.ColumnDefinitions = columnDefinitions;
		Avalonia.Controls.Controls children3 = grid9.Children;
		Border border15;
		Border border14 = (border15 = new Border());
		((ISupportInitialize)border14).BeginInit();
		children3.Add(border14);
		Border border16 = (border4 = border15);
		context.PushParent(border4);
		Border border17 = border4;
		Grid.SetColumn(border17, 0);
		border17.Width = 80.0;
		border17.Height = 80.0;
		border17.CornerRadius = new CornerRadius(8.0, 8.0, 8.0, 8.0);
		border17.ClipToBounds = true;
		border17.Background = new ImmutableSolidColorBrush(4281677109u);
		border17.Margin = new Thickness(0.0, 0.0, 15.0, 0.0);
		Image image2;
		Image image = (image2 = new Image());
		((ISupportInitialize)image).BeginInit();
		border17.Child = image;
		Image image4;
		Image image3 = (image4 = image2);
		context.PushParent(image4);
		StyledProperty<IImage?> sourceProperty = Image.SourceProperty;
		ReflectionBindingExtension reflectionBindingExtension = new ReflectionBindingExtension("AvatarBitmap");
		context.ProvideTargetProperty = Image.SourceProperty;
		Binding binding2 = reflectionBindingExtension.ProvideValue(context);
		context.ProvideTargetProperty = null;
		AvaloniaObjectExtensions.Bind(image4, sourceProperty, binding2);
		image4.Stretch = Stretch.UniformToFill;
		context.PopParent();
		((ISupportInitialize)image3).EndInit();
		context.PopParent();
		((ISupportInitialize)border16).EndInit();
		Avalonia.Controls.Controls children4 = grid9.Children;
		StackPanel stackPanel2;
		StackPanel stackPanel = (stackPanel2 = new StackPanel());
		((ISupportInitialize)stackPanel).BeginInit();
		children4.Add(stackPanel);
		StackPanel stackPanel4;
		StackPanel stackPanel3 = (stackPanel4 = stackPanel2);
		context.PushParent(stackPanel4);
		StackPanel stackPanel5 = stackPanel4;
		Grid.SetColumn(stackPanel5, 1);
		stackPanel5.VerticalAlignment = VerticalAlignment.Center;
		stackPanel5.Spacing = 4.0;
		Avalonia.Controls.Controls children5 = stackPanel5.Children;
		StackPanel stackPanel7;
		StackPanel stackPanel6 = (stackPanel7 = new StackPanel());
		((ISupportInitialize)stackPanel6).BeginInit();
		children5.Add(stackPanel6);
		StackPanel stackPanel8 = (stackPanel4 = stackPanel7);
		context.PushParent(stackPanel4);
		StackPanel stackPanel9 = stackPanel4;
		stackPanel9.Orientation = Orientation.Horizontal;
		Avalonia.Controls.Controls children6 = stackPanel9.Children;
		TextBlock textBlock7;
		TextBlock textBlock6 = (textBlock7 = new TextBlock());
		((ISupportInitialize)textBlock6).BeginInit();
		children6.Add(textBlock6);
		textBlock7.Text = "Nickname: ";
		textBlock7.Foreground = new ImmutableSolidColorBrush(4292598747u);
		textBlock7.FontSize = 12.0;
		((ISupportInitialize)textBlock7).EndInit();
		Avalonia.Controls.Controls children7 = stackPanel9.Children;
		TextBlock textBlock9;
		TextBlock textBlock8 = (textBlock9 = new TextBlock());
		((ISupportInitialize)textBlock8).BeginInit();
		children7.Add(textBlock8);
		TextBlock textBlock10 = (textBlock4 = textBlock9);
		context.PushParent(textBlock4);
		TextBlock textBlock11 = textBlock4;
		StyledProperty<string?> textProperty = TextBlock.TextProperty;
		ReflectionBindingExtension reflectionBindingExtension2 = new ReflectionBindingExtension("Nickname");
		context.ProvideTargetProperty = TextBlock.TextProperty;
		Binding binding3 = reflectionBindingExtension2.ProvideValue(context);
		context.ProvideTargetProperty = null;
		AvaloniaObjectExtensions.Bind(textBlock11, textProperty, binding3);
		textBlock11.Foreground = new ImmutableSolidColorBrush(4291745125u);
		textBlock11.FontSize = 12.0;
		context.PopParent();
		((ISupportInitialize)textBlock10).EndInit();
		context.PopParent();
		((ISupportInitialize)stackPanel8).EndInit();
		Avalonia.Controls.Controls children8 = stackPanel5.Children;
		StackPanel stackPanel11;
		StackPanel stackPanel10 = (stackPanel11 = new StackPanel());
		((ISupportInitialize)stackPanel10).BeginInit();
		children8.Add(stackPanel10);
		StackPanel stackPanel12 = (stackPanel4 = stackPanel11);
		context.PushParent(stackPanel4);
		StackPanel stackPanel13 = stackPanel4;
		stackPanel13.Orientation = Orientation.Horizontal;
		Avalonia.Controls.Controls children9 = stackPanel13.Children;
		TextBlock textBlock13;
		TextBlock textBlock12 = (textBlock13 = new TextBlock());
		((ISupportInitialize)textBlock12).BeginInit();
		children9.Add(textBlock12);
		textBlock13.Text = "SteamID: ";
		textBlock13.Foreground = new ImmutableSolidColorBrush(4292598747u);
		textBlock13.FontSize = 12.0;
		((ISupportInitialize)textBlock13).EndInit();
		Avalonia.Controls.Controls children10 = stackPanel13.Children;
		TextBlock textBlock15;
		TextBlock textBlock14 = (textBlock15 = new TextBlock());
		((ISupportInitialize)textBlock14).BeginInit();
		children10.Add(textBlock14);
		TextBlock textBlock16 = (textBlock4 = textBlock15);
		context.PushParent(textBlock4);
		TextBlock textBlock17 = textBlock4;
		StyledProperty<string?> textProperty2 = TextBlock.TextProperty;
		ReflectionBindingExtension reflectionBindingExtension3 = new ReflectionBindingExtension("SteamId2");
		context.ProvideTargetProperty = TextBlock.TextProperty;
		Binding binding4 = reflectionBindingExtension3.ProvideValue(context);
		context.ProvideTargetProperty = null;
		AvaloniaObjectExtensions.Bind(textBlock17, textProperty2, binding4);
		textBlock17.Foreground = new ImmutableSolidColorBrush(4291745125u);
		textBlock17.FontSize = 12.0;
		context.PopParent();
		((ISupportInitialize)textBlock16).EndInit();
		context.PopParent();
		((ISupportInitialize)stackPanel12).EndInit();
		Avalonia.Controls.Controls children11 = stackPanel5.Children;
		StackPanel stackPanel15;
		StackPanel stackPanel14 = (stackPanel15 = new StackPanel());
		((ISupportInitialize)stackPanel14).BeginInit();
		children11.Add(stackPanel14);
		StackPanel stackPanel16 = (stackPanel4 = stackPanel15);
		context.PushParent(stackPanel4);
		StackPanel stackPanel17 = stackPanel4;
		stackPanel17.Orientation = Orientation.Horizontal;
		Avalonia.Controls.Controls children12 = stackPanel17.Children;
		TextBlock textBlock19;
		TextBlock textBlock18 = (textBlock19 = new TextBlock());
		((ISupportInitialize)textBlock18).BeginInit();
		children12.Add(textBlock18);
		textBlock19.Text = "ID64: ";
		textBlock19.Foreground = new ImmutableSolidColorBrush(4292598747u);
		textBlock19.FontSize = 12.0;
		((ISupportInitialize)textBlock19).EndInit();
		Avalonia.Controls.Controls children13 = stackPanel17.Children;
		TextBlock textBlock21;
		TextBlock textBlock20 = (textBlock21 = new TextBlock());
		((ISupportInitialize)textBlock20).BeginInit();
		children13.Add(textBlock20);
		TextBlock textBlock22 = (textBlock4 = textBlock21);
		context.PushParent(textBlock4);
		TextBlock textBlock23 = textBlock4;
		StyledProperty<string?> textProperty3 = TextBlock.TextProperty;
		ReflectionBindingExtension reflectionBindingExtension4 = new ReflectionBindingExtension("UniqueId");
		context.ProvideTargetProperty = TextBlock.TextProperty;
		Binding binding5 = reflectionBindingExtension4.ProvideValue(context);
		context.ProvideTargetProperty = null;
		AvaloniaObjectExtensions.Bind(textBlock23, textProperty3, binding5);
		textBlock23.Foreground = new ImmutableSolidColorBrush(4291745125u);
		textBlock23.FontSize = 11.0;
		context.PopParent();
		((ISupportInitialize)textBlock22).EndInit();
		context.PopParent();
		((ISupportInitialize)stackPanel16).EndInit();
		Avalonia.Controls.Controls children14 = stackPanel5.Children;
		Button button2;
		Button button = (button2 = new Button());
		((ISupportInitialize)button).BeginInit();
		children14.Add(button);
		Button button4;
		Button button3 = (button4 = button2);
		context.PushParent(button4);
		button4.Content = "Open Profile";
		StyledProperty<ICommand?> commandProperty = Button.CommandProperty;
		ReflectionBindingExtension reflectionBindingExtension5 = new ReflectionBindingExtension("OpenProfileCommand");
		context.ProvideTargetProperty = Button.CommandProperty;
		Binding binding6 = reflectionBindingExtension5.ProvideValue(context);
		context.ProvideTargetProperty = null;
		AvaloniaObjectExtensions.Bind(button4, commandProperty, binding6);
		button4.Background = new ImmutableSolidColorBrush(4294937600u);
		button4.Foreground = new ImmutableSolidColorBrush(uint.MaxValue);
		button4.Padding = new Thickness(10.0, 5.0, 10.0, 5.0);
		button4.Margin = new Thickness(0.0, 5.0, 0.0, 0.0);
		button4.CornerRadius = new CornerRadius(5.0, 5.0, 5.0, 5.0);
		button4.HorizontalAlignment = HorizontalAlignment.Left;
		context.PopParent();
		((ISupportInitialize)button3).EndInit();
		context.PopParent();
		((ISupportInitialize)stackPanel3).EndInit();
		context.PopParent();
		((ISupportInitialize)grid8).EndInit();
		context.PopParent();
		((ISupportInitialize)border12).EndInit();
		Avalonia.Controls.Controls children15 = grid5.Children;
		ListBox listBox2;
		ListBox listBox = (listBox2 = new ListBox());
		((ISupportInitialize)listBox).BeginInit();
		children15.Add(listBox);
		ListBox listBox4;
		ListBox listBox3 = (listBox4 = listBox2);
		context.PushParent(listBox4);
		Grid.SetRow(listBox4, 2);
		listBox4.Name = "AccountsList";
		element = listBox4;
		context.AvaloniaNameScope.Register("AccountsList", element);
		StyledProperty<IEnumerable?> itemsSourceProperty = ItemsControl.ItemsSourceProperty;
		ReflectionBindingExtension reflectionBindingExtension6 = new ReflectionBindingExtension("Accounts");
		context.ProvideTargetProperty = ItemsControl.ItemsSourceProperty;
		Binding binding7 = reflectionBindingExtension6.ProvideValue(context);
		context.ProvideTargetProperty = null;
		AvaloniaObjectExtensions.Bind(listBox4, itemsSourceProperty, binding7);
		ReflectionBindingExtension obj3 = new ReflectionBindingExtension("SelectedAccount")
		{
			Mode = BindingMode.TwoWay
		};
		context.ProvideTargetProperty = SelectingItemsControl.SelectedItemProperty;
		Binding binding8 = obj3.ProvideValue(context);
		context.ProvideTargetProperty = null;
		CompiledAvaloniaXaml.XamlDynamicSetters._003C_003EXamlDynamicSetter_3(listBox4, binding8);
		listBox4.Background = new ImmutableSolidColorBrush(16777215u);
		listBox4.Margin = new Thickness(10.0, 5.0, 10.0, 10.0);
		listBox4.BorderThickness = new Thickness(0.0, 0.0, 0.0, 0.0);
		listBox4.ItemsPanel = new ItemsPanelTemplate
		{
			Content = XamlIlRuntimeHelpers.DeferredTransformationFactoryV3<Control>((nint)(delegate*<IServiceProvider, object>)(&XamlClosure_2.Build_1), context)
		};
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
		styles.Add(style);
		Styles styles2 = listBox4.Styles;
		Style style2 = new Style();
		style2.Selector = ((Selector?)null).OfType(typeof(ListBoxItem)).Class(":pointerover");
		Setter setter5 = new Setter();
		setter5.Property = TemplatedControl.BackgroundProperty;
		setter5.Value = new ImmutableSolidColorBrush(4282729797u);
		style2.Add(setter5);
		styles2.Add(style2);
		Styles styles3 = listBox4.Styles;
		Style style3 = new Style();
		style3.Selector = ((Selector?)null).OfType(typeof(ListBoxItem)).Class(":selected");
		Setter setter6 = new Setter();
		setter6.Property = TemplatedControl.BackgroundProperty;
		setter6.Value = new ImmutableSolidColorBrush(4283453520u);
		style3.Add(setter6);
		styles3.Add(style3);
		DataTemplate dataTemplate;
		DataTemplate itemTemplate = (dataTemplate = new DataTemplate());
		context.PushParent(dataTemplate);
		dataTemplate.Content = XamlIlRuntimeHelpers.DeferredTransformationFactoryV3<Control>((nint)(delegate*<IServiceProvider, object>)(&XamlClosure_2.Build_2), context);
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

	private static void _0021XamlIlPopulateTrampoline(SubmenuCustomer P_0)
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
