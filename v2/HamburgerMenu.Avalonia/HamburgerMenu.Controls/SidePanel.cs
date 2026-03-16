using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Presenters;
using Avalonia.Controls.Primitives;
using Avalonia.Data;
using Avalonia.Input;
using Avalonia.Layout;
using Avalonia.Markup.Xaml.MarkupExtensions;
using Avalonia.Markup.Xaml.MarkupExtensions.CompiledBindings;
using Avalonia.Markup.Xaml.XamlIl.Runtime;
using Avalonia.Media;
using Avalonia.Media.Immutable;
using Avalonia.Styling;
using CompiledAvaloniaXaml;

namespace HamburgerMenu.Controls;

[CompilerGenerated]
public class SidePanel : UserControl
{
	[GeneratedCode("Avalonia.Generators.NameGenerator.InitializeComponentCodeGenerator", "11.2.1.0")]
	internal ListBox SidePanel_ListBox;

	[GeneratedCode("Avalonia.Generators.NameGenerator.InitializeComponentCodeGenerator", "11.2.1.0")]
	internal ListBoxItem Dashboard_ListBoxItem;

	[GeneratedCode("Avalonia.Generators.NameGenerator.InitializeComponentCodeGenerator", "11.2.1.0")]
	internal ListBoxItem Apps_ListBoxItem;

	[GeneratedCode("Avalonia.Generators.NameGenerator.InitializeComponentCodeGenerator", "11.2.1.0")]
	internal ListBoxItem Customer_ListBoxItem;

	[GeneratedCode("Avalonia.Generators.NameGenerator.InitializeComponentCodeGenerator", "11.2.1.0")]
	internal ListBoxItem Analytics_ListBoxItem;

	[GeneratedCode("Avalonia.Generators.NameGenerator.InitializeComponentCodeGenerator", "11.2.1.0")]
	internal ListBoxItem Settings_ListBoxItem;

	private static Action<object> _0021XamlIlPopulateOverride;

	public SidePanel()
	{
		InitializeComponent();
	}

	private MainWindow? GetMainWindow()
	{
		return TopLevel.GetTopLevel(this) as MainWindow;
	}

	private void SidePanel_SelectionChanged(object? sender, SelectionChangedEventArgs e)
	{
		MainWindow mainWindow = GetMainWindow();
		if (mainWindow == null)
		{
			return;
		}
		foreach (object removedItem in e.RemovedItems)
		{
			if (removedItem == Apps_ListBoxItem)
			{
				mainWindow.HideSubmenuOne();
				mainWindow.Track_One?.CloseTrackOne();
			}
			if (removedItem == Customer_ListBoxItem)
			{
				mainWindow.HideSubmenuCustomer();
			}
			if (removedItem == Analytics_ListBoxItem)
			{
				mainWindow.HideSubmenuAnalytics();
			}
			if (removedItem == Settings_ListBoxItem)
			{
				mainWindow.HideSubmenuSettings();
			}
		}
		foreach (object addedItem in e.AddedItems)
		{
			if (addedItem == Apps_ListBoxItem)
			{
				mainWindow.ShowSubmenuOne();
				mainWindow.Track_One?.OpenTrackOne();
			}
			if (addedItem == Customer_ListBoxItem)
			{
				mainWindow.ShowSubmenuCustomer();
			}
			if (addedItem == Analytics_ListBoxItem)
			{
				mainWindow.ShowSubmenuAnalytics();
			}
			if (addedItem == Settings_ListBoxItem)
			{
				mainWindow.ShowSubmenuSettings();
			}
		}
	}

	public void UnselectApps()
	{
		SidePanel_ListBox.SelectedItem = null;
	}

	public void UnselectCustomer()
	{
		if (SidePanel_ListBox.SelectedItem == Customer_ListBoxItem)
		{
			SidePanel_ListBox.SelectedItem = null;
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
		SidePanel_ListBox = nameScope?.Find<ListBox>("SidePanel_ListBox");
		Dashboard_ListBoxItem = nameScope?.Find<ListBoxItem>("Dashboard_ListBoxItem");
		Apps_ListBoxItem = nameScope?.Find<ListBoxItem>("Apps_ListBoxItem");
		Customer_ListBoxItem = nameScope?.Find<ListBoxItem>("Customer_ListBoxItem");
		Analytics_ListBoxItem = nameScope?.Find<ListBoxItem>("Analytics_ListBoxItem");
		Settings_ListBoxItem = nameScope?.Find<ListBoxItem>("Settings_ListBoxItem");
	}

	private static void _0021XamlIlPopulate(IServiceProvider P_0, SidePanel P_1)
	{
		CompiledAvaloniaXaml.XamlIlContext.Context<SidePanel> context = new CompiledAvaloniaXaml.XamlIlContext.Context<SidePanel>(P_0, new object[1] { _0021AvaloniaResources.NamespaceInfo_003A_002FControls_002FSidePanel_002Eaxaml.Singleton }, "avares://HamburgerMenu.Avalonia/Controls/SidePanel.axaml")
		{
			RootObject = P_1,
			IntermediateRoot = P_1
		};
		((ISupportInitialize)P_1).BeginInit();
		context.PushParent(P_1);
		ListBox listBox2;
		ListBox listBox = (listBox2 = new ListBox());
		((ISupportInitialize)listBox).BeginInit();
		P_1.Content = listBox;
		ListBox listBox4;
		ListBox listBox3 = (listBox4 = listBox2);
		context.PushParent(listBox4);
		listBox4.Name = "SidePanel_ListBox";
		object element = listBox4;
		context.AvaloniaNameScope.Register("SidePanel_ListBox", element);
		listBox4.Background = new ImmutableSolidColorBrush(16777215u);
		listBox4.SelectionMode = SelectionMode.Single;
		listBox4.Cursor = new Cursor(StandardCursorType.Hand);
		listBox4.Width = 210.0;
		listBox4.AddHandler(SelectingItemsControl.SelectionChangedEvent, context.RootObject.SidePanel_SelectionChanged);
		Styles styles = listBox4.Styles;
		Style style = new Style();
		style.Selector = ((Selector?)null).OfType(typeof(ListBoxItem));
		Setter setter = new Setter();
		setter.Property = TemplatedControl.PaddingProperty;
		setter.Value = new Thickness(0.0, 0.0, 0.0, 0.0);
		style.Add(setter);
		Setter setter2 = new Setter();
		setter2.Property = Layoutable.MarginProperty;
		setter2.Value = new Thickness(0.0, 0.0, 0.0, 0.0);
		style.Add(setter2);
		Setter setter3 = new Setter();
		setter3.Property = ContentControl.HorizontalContentAlignmentProperty;
		setter3.Value = HorizontalAlignment.Stretch;
		style.Add(setter3);
		Setter setter4 = new Setter();
		setter4.Property = TemplatedControl.BackgroundProperty;
		setter4.Value = new ImmutableSolidColorBrush(16777215u);
		style.Add(setter4);
		Setter setter5 = new Setter();
		setter5.Property = TemplatedControl.BorderThicknessProperty;
		setter5.Value = new Thickness(0.0, 0.0, 0.0, 0.0);
		style.Add(setter5);
		styles.Add(style);
		Styles styles2 = listBox4.Styles;
		Style style2 = new Style();
		style2.Selector = ((Selector?)null).OfType(typeof(ListBoxItem)).Class(":selected").Template()
			.OfType(typeof(ContentPresenter));
		Setter setter6 = new Setter();
		setter6.Property = ContentPresenter.BackgroundProperty;
		setter6.Value = new ImmutableSolidColorBrush(16777215u);
		style2.Add(setter6);
		styles2.Add(style2);
		Styles styles3 = listBox4.Styles;
		Style style3 = new Style();
		style3.Selector = ((Selector?)null).OfType(typeof(ListBoxItem)).Class(":pointerover").Template()
			.OfType(typeof(ContentPresenter));
		Setter setter7 = new Setter();
		setter7.Property = ContentPresenter.BackgroundProperty;
		setter7.Value = new ImmutableSolidColorBrush(16777215u);
		style3.Add(setter7);
		styles3.Add(style3);
		Styles styles4 = listBox4.Styles;
		Style style4 = new Style();
		style4.Selector = ((Selector?)null).OfType(typeof(ListBoxItem)).Class(":selected");
		Setter setter8 = new Setter();
		setter8.Property = TemplatedControl.BackgroundProperty;
		setter8.Value = new ImmutableSolidColorBrush(16777215u);
		style4.Add(setter8);
		styles4.Add(style4);
		ItemCollection items = listBox4.Items;
		ListBoxItem listBoxItem2;
		ListBoxItem listBoxItem = (listBoxItem2 = new ListBoxItem());
		((ISupportInitialize)listBoxItem).BeginInit();
		items.Add(listBoxItem);
		ListBoxItem listBoxItem4;
		ListBoxItem listBoxItem3 = (listBoxItem4 = listBoxItem2);
		context.PushParent(listBoxItem4);
		ListBoxItem listBoxItem5 = listBoxItem4;
		listBoxItem5.Name = "Dashboard_ListBoxItem";
		element = listBoxItem5;
		context.AvaloniaNameScope.Register("Dashboard_ListBoxItem", element);
		listBoxItem5.Tag = "Dashboard";
		ToggleButton toggleButton2;
		ToggleButton toggleButton = (toggleButton2 = new ToggleButton());
		((ISupportInitialize)toggleButton).BeginInit();
		listBoxItem5.Content = toggleButton;
		ToggleButton toggleButton4;
		ToggleButton toggleButton3 = (toggleButton4 = toggleButton2);
		context.PushParent(toggleButton4);
		ToggleButton toggleButton5 = toggleButton4;
		toggleButton5.Classes.Add("SidePanelItem");
		StyledProperty<bool?> isCheckedProperty = ToggleButton.IsCheckedProperty;
		CompiledBindingExtension obj = new CompiledBindingExtension(new CompiledBindingPathBuilder(1).Ancestor(typeof(ListBoxItem), 0).Property(ListBoxItem.IsSelectedProperty, PropertyInfoAccessorFactory.CreateAvaloniaPropertyAccessor).Build())
		{
			Mode = BindingMode.TwoWay
		};
		context.ProvideTargetProperty = ToggleButton.IsCheckedProperty;
		CompiledBindingExtension binding = obj.ProvideValue(context);
		context.ProvideTargetProperty = null;
		AvaloniaObjectExtensions.Bind(toggleButton5, isCheckedProperty, binding);
		Grid grid2;
		Grid grid = (grid2 = new Grid());
		((ISupportInitialize)grid).BeginInit();
		toggleButton5.Content = grid;
		Grid grid4;
		Grid grid3 = (grid4 = grid2);
		context.PushParent(grid4);
		Grid grid5 = grid4;
		grid5.Height = 40.0;
		grid5.Width = 210.0;
		ColumnDefinitions columnDefinitions = new ColumnDefinitions();
		columnDefinitions.Capacity = 2;
		columnDefinitions.Add(new ColumnDefinition(new GridLength(160.0, GridUnitType.Pixel)));
		columnDefinitions.Add(new ColumnDefinition(new GridLength(50.0, GridUnitType.Pixel)));
		grid5.ColumnDefinitions = columnDefinitions;
		Avalonia.Controls.Controls children = grid5.Children;
		TextBlock textBlock2;
		TextBlock textBlock = (textBlock2 = new TextBlock());
		((ISupportInitialize)textBlock).BeginInit();
		children.Add(textBlock);
		TextBlock textBlock4;
		TextBlock textBlock3 = (textBlock4 = textBlock2);
		context.PushParent(textBlock4);
		TextBlock textBlock5 = textBlock4;
		Grid.SetColumn(textBlock5, 0);
		textBlock5.Text = "Dashboard";
		StaticResourceExtension staticResourceExtension = new StaticResourceExtension("FontStyle_2");
		context.ProvideTargetProperty = TextBlock.FontFamilyProperty;
		object? obj2 = staticResourceExtension.ProvideValue(context);
		context.ProvideTargetProperty = null;
		CompiledAvaloniaXaml.XamlDynamicSetters._003C_003EXamlDynamicSetter_2(textBlock5, obj2);
		textBlock5.FontSize = 17.0;
		textBlock5.Foreground = new ImmutableSolidColorBrush(uint.MaxValue);
		textBlock5.VerticalAlignment = VerticalAlignment.Center;
		textBlock5.HorizontalAlignment = HorizontalAlignment.Left;
		textBlock5.Margin = new Thickness(10.0, 0.0, 0.0, 0.0);
		context.PopParent();
		((ISupportInitialize)textBlock3).EndInit();
		Avalonia.Controls.Controls children2 = grid5.Children;
		Image image2;
		Image image = (image2 = new Image());
		((ISupportInitialize)image).BeginInit();
		children2.Add(image);
		Image image4;
		Image image3 = (image4 = image2);
		context.PushParent(image4);
		Image image5 = image4;
		Grid.SetColumn(image5, 1);
		StaticResourceExtension staticResourceExtension2 = new StaticResourceExtension("Dashboard_S3");
		context.ProvideTargetProperty = Image.SourceProperty;
		object? obj3 = staticResourceExtension2.ProvideValue(context);
		context.ProvideTargetProperty = null;
		CompiledAvaloniaXaml.XamlDynamicSetters._003C_003EXamlDynamicSetter_1(image5, obj3);
		image5.Stretch = Stretch.None;
		image5.HorizontalAlignment = HorizontalAlignment.Center;
		image5.VerticalAlignment = VerticalAlignment.Center;
		context.PopParent();
		((ISupportInitialize)image3).EndInit();
		context.PopParent();
		((ISupportInitialize)grid3).EndInit();
		context.PopParent();
		((ISupportInitialize)toggleButton3).EndInit();
		context.PopParent();
		((ISupportInitialize)listBoxItem3).EndInit();
		ItemCollection items2 = listBox4.Items;
		ListBoxItem listBoxItem7;
		ListBoxItem listBoxItem6 = (listBoxItem7 = new ListBoxItem());
		((ISupportInitialize)listBoxItem6).BeginInit();
		items2.Add(listBoxItem6);
		ListBoxItem listBoxItem8 = (listBoxItem4 = listBoxItem7);
		context.PushParent(listBoxItem4);
		ListBoxItem listBoxItem9 = listBoxItem4;
		listBoxItem9.Name = "Apps_ListBoxItem";
		element = listBoxItem9;
		context.AvaloniaNameScope.Register("Apps_ListBoxItem", element);
		listBoxItem9.Tag = "Apps";
		ToggleButton toggleButton7;
		ToggleButton toggleButton6 = (toggleButton7 = new ToggleButton());
		((ISupportInitialize)toggleButton6).BeginInit();
		listBoxItem9.Content = toggleButton6;
		ToggleButton toggleButton8 = (toggleButton4 = toggleButton7);
		context.PushParent(toggleButton4);
		ToggleButton toggleButton9 = toggleButton4;
		toggleButton9.Classes.Add("SidePanelItem");
		StyledProperty<bool?> isCheckedProperty2 = ToggleButton.IsCheckedProperty;
		CompiledBindingExtension obj4 = new CompiledBindingExtension(new CompiledBindingPathBuilder(1).Ancestor(typeof(ListBoxItem), 0).Property(ListBoxItem.IsSelectedProperty, PropertyInfoAccessorFactory.CreateAvaloniaPropertyAccessor).Build())
		{
			Mode = BindingMode.TwoWay
		};
		context.ProvideTargetProperty = ToggleButton.IsCheckedProperty;
		CompiledBindingExtension binding2 = obj4.ProvideValue(context);
		context.ProvideTargetProperty = null;
		AvaloniaObjectExtensions.Bind(toggleButton9, isCheckedProperty2, binding2);
		Grid grid7;
		Grid grid6 = (grid7 = new Grid());
		((ISupportInitialize)grid6).BeginInit();
		toggleButton9.Content = grid6;
		Grid grid8 = (grid4 = grid7);
		context.PushParent(grid4);
		Grid grid9 = grid4;
		grid9.Height = 40.0;
		grid9.Width = 210.0;
		ColumnDefinitions columnDefinitions2 = new ColumnDefinitions();
		columnDefinitions2.Capacity = 2;
		columnDefinitions2.Add(new ColumnDefinition(new GridLength(160.0, GridUnitType.Pixel)));
		columnDefinitions2.Add(new ColumnDefinition(new GridLength(50.0, GridUnitType.Pixel)));
		grid9.ColumnDefinitions = columnDefinitions2;
		Avalonia.Controls.Controls children3 = grid9.Children;
		TextBlock textBlock7;
		TextBlock textBlock6 = (textBlock7 = new TextBlock());
		((ISupportInitialize)textBlock6).BeginInit();
		children3.Add(textBlock6);
		TextBlock textBlock8 = (textBlock4 = textBlock7);
		context.PushParent(textBlock4);
		TextBlock textBlock9 = textBlock4;
		Grid.SetColumn(textBlock9, 0);
		textBlock9.Text = "Apps";
		StaticResourceExtension staticResourceExtension3 = new StaticResourceExtension("FontStyle_2");
		context.ProvideTargetProperty = TextBlock.FontFamilyProperty;
		object? obj5 = staticResourceExtension3.ProvideValue(context);
		context.ProvideTargetProperty = null;
		CompiledAvaloniaXaml.XamlDynamicSetters._003C_003EXamlDynamicSetter_2(textBlock9, obj5);
		textBlock9.FontSize = 17.0;
		textBlock9.Foreground = new ImmutableSolidColorBrush(uint.MaxValue);
		textBlock9.VerticalAlignment = VerticalAlignment.Center;
		textBlock9.HorizontalAlignment = HorizontalAlignment.Left;
		textBlock9.Margin = new Thickness(10.0, 0.0, 0.0, 0.0);
		context.PopParent();
		((ISupportInitialize)textBlock8).EndInit();
		Avalonia.Controls.Controls children4 = grid9.Children;
		Image image7;
		Image image6 = (image7 = new Image());
		((ISupportInitialize)image6).BeginInit();
		children4.Add(image6);
		Image image8 = (image4 = image7);
		context.PushParent(image4);
		Image image9 = image4;
		Grid.SetColumn(image9, 1);
		StaticResourceExtension staticResourceExtension4 = new StaticResourceExtension("Mail_S3");
		context.ProvideTargetProperty = Image.SourceProperty;
		object? obj6 = staticResourceExtension4.ProvideValue(context);
		context.ProvideTargetProperty = null;
		CompiledAvaloniaXaml.XamlDynamicSetters._003C_003EXamlDynamicSetter_1(image9, obj6);
		image9.Stretch = Stretch.None;
		image9.HorizontalAlignment = HorizontalAlignment.Center;
		image9.VerticalAlignment = VerticalAlignment.Center;
		context.PopParent();
		((ISupportInitialize)image8).EndInit();
		context.PopParent();
		((ISupportInitialize)grid8).EndInit();
		context.PopParent();
		((ISupportInitialize)toggleButton8).EndInit();
		context.PopParent();
		((ISupportInitialize)listBoxItem8).EndInit();
		ItemCollection items3 = listBox4.Items;
		ListBoxItem listBoxItem11;
		ListBoxItem listBoxItem10 = (listBoxItem11 = new ListBoxItem());
		((ISupportInitialize)listBoxItem10).BeginInit();
		items3.Add(listBoxItem10);
		ListBoxItem listBoxItem12 = (listBoxItem4 = listBoxItem11);
		context.PushParent(listBoxItem4);
		ListBoxItem listBoxItem13 = listBoxItem4;
		listBoxItem13.Name = "Customer_ListBoxItem";
		element = listBoxItem13;
		context.AvaloniaNameScope.Register("Customer_ListBoxItem", element);
		listBoxItem13.Tag = "Customer";
		ToggleButton toggleButton11;
		ToggleButton toggleButton10 = (toggleButton11 = new ToggleButton());
		((ISupportInitialize)toggleButton10).BeginInit();
		listBoxItem13.Content = toggleButton10;
		ToggleButton toggleButton12 = (toggleButton4 = toggleButton11);
		context.PushParent(toggleButton4);
		ToggleButton toggleButton13 = toggleButton4;
		toggleButton13.Classes.Add("SidePanelItem");
		StyledProperty<bool?> isCheckedProperty3 = ToggleButton.IsCheckedProperty;
		CompiledBindingExtension obj7 = new CompiledBindingExtension(new CompiledBindingPathBuilder(1).Ancestor(typeof(ListBoxItem), 0).Property(ListBoxItem.IsSelectedProperty, PropertyInfoAccessorFactory.CreateAvaloniaPropertyAccessor).Build())
		{
			Mode = BindingMode.TwoWay
		};
		context.ProvideTargetProperty = ToggleButton.IsCheckedProperty;
		CompiledBindingExtension binding3 = obj7.ProvideValue(context);
		context.ProvideTargetProperty = null;
		AvaloniaObjectExtensions.Bind(toggleButton13, isCheckedProperty3, binding3);
		Grid grid11;
		Grid grid10 = (grid11 = new Grid());
		((ISupportInitialize)grid10).BeginInit();
		toggleButton13.Content = grid10;
		Grid grid12 = (grid4 = grid11);
		context.PushParent(grid4);
		Grid grid13 = grid4;
		grid13.Height = 40.0;
		grid13.Width = 210.0;
		ColumnDefinitions columnDefinitions3 = new ColumnDefinitions();
		columnDefinitions3.Capacity = 2;
		columnDefinitions3.Add(new ColumnDefinition(new GridLength(160.0, GridUnitType.Pixel)));
		columnDefinitions3.Add(new ColumnDefinition(new GridLength(50.0, GridUnitType.Pixel)));
		grid13.ColumnDefinitions = columnDefinitions3;
		Avalonia.Controls.Controls children5 = grid13.Children;
		TextBlock textBlock11;
		TextBlock textBlock10 = (textBlock11 = new TextBlock());
		((ISupportInitialize)textBlock10).BeginInit();
		children5.Add(textBlock10);
		TextBlock textBlock12 = (textBlock4 = textBlock11);
		context.PushParent(textBlock4);
		TextBlock textBlock13 = textBlock4;
		Grid.SetColumn(textBlock13, 0);
		textBlock13.Text = "Customer";
		StaticResourceExtension staticResourceExtension5 = new StaticResourceExtension("FontStyle_2");
		context.ProvideTargetProperty = TextBlock.FontFamilyProperty;
		object? obj8 = staticResourceExtension5.ProvideValue(context);
		context.ProvideTargetProperty = null;
		CompiledAvaloniaXaml.XamlDynamicSetters._003C_003EXamlDynamicSetter_2(textBlock13, obj8);
		textBlock13.FontSize = 17.0;
		textBlock13.Foreground = new ImmutableSolidColorBrush(uint.MaxValue);
		textBlock13.VerticalAlignment = VerticalAlignment.Center;
		textBlock13.HorizontalAlignment = HorizontalAlignment.Left;
		textBlock13.Margin = new Thickness(10.0, 0.0, 0.0, 0.0);
		context.PopParent();
		((ISupportInitialize)textBlock12).EndInit();
		Avalonia.Controls.Controls children6 = grid13.Children;
		Image image11;
		Image image10 = (image11 = new Image());
		((ISupportInitialize)image10).BeginInit();
		children6.Add(image10);
		Image image12 = (image4 = image11);
		context.PushParent(image4);
		Image image13 = image4;
		Grid.SetColumn(image13, 1);
		StaticResourceExtension staticResourceExtension6 = new StaticResourceExtension("Customer_S3");
		context.ProvideTargetProperty = Image.SourceProperty;
		object? obj9 = staticResourceExtension6.ProvideValue(context);
		context.ProvideTargetProperty = null;
		CompiledAvaloniaXaml.XamlDynamicSetters._003C_003EXamlDynamicSetter_1(image13, obj9);
		image13.Stretch = Stretch.None;
		image13.HorizontalAlignment = HorizontalAlignment.Center;
		image13.VerticalAlignment = VerticalAlignment.Center;
		context.PopParent();
		((ISupportInitialize)image12).EndInit();
		context.PopParent();
		((ISupportInitialize)grid12).EndInit();
		context.PopParent();
		((ISupportInitialize)toggleButton12).EndInit();
		context.PopParent();
		((ISupportInitialize)listBoxItem12).EndInit();
		ItemCollection items4 = listBox4.Items;
		ListBoxItem listBoxItem15;
		ListBoxItem listBoxItem14 = (listBoxItem15 = new ListBoxItem());
		((ISupportInitialize)listBoxItem14).BeginInit();
		items4.Add(listBoxItem14);
		ListBoxItem listBoxItem16 = (listBoxItem4 = listBoxItem15);
		context.PushParent(listBoxItem4);
		ListBoxItem listBoxItem17 = listBoxItem4;
		listBoxItem17.Name = "Analytics_ListBoxItem";
		element = listBoxItem17;
		context.AvaloniaNameScope.Register("Analytics_ListBoxItem", element);
		listBoxItem17.Tag = "Analytics";
		ToggleButton toggleButton15;
		ToggleButton toggleButton14 = (toggleButton15 = new ToggleButton());
		((ISupportInitialize)toggleButton14).BeginInit();
		listBoxItem17.Content = toggleButton14;
		ToggleButton toggleButton16 = (toggleButton4 = toggleButton15);
		context.PushParent(toggleButton4);
		ToggleButton toggleButton17 = toggleButton4;
		toggleButton17.Classes.Add("SidePanelItem");
		StyledProperty<bool?> isCheckedProperty4 = ToggleButton.IsCheckedProperty;
		CompiledBindingExtension obj10 = new CompiledBindingExtension(new CompiledBindingPathBuilder(1).Ancestor(typeof(ListBoxItem), 0).Property(ListBoxItem.IsSelectedProperty, PropertyInfoAccessorFactory.CreateAvaloniaPropertyAccessor).Build())
		{
			Mode = BindingMode.TwoWay
		};
		context.ProvideTargetProperty = ToggleButton.IsCheckedProperty;
		CompiledBindingExtension binding4 = obj10.ProvideValue(context);
		context.ProvideTargetProperty = null;
		AvaloniaObjectExtensions.Bind(toggleButton17, isCheckedProperty4, binding4);
		Grid grid15;
		Grid grid14 = (grid15 = new Grid());
		((ISupportInitialize)grid14).BeginInit();
		toggleButton17.Content = grid14;
		Grid grid16 = (grid4 = grid15);
		context.PushParent(grid4);
		Grid grid17 = grid4;
		grid17.Height = 40.0;
		grid17.Width = 210.0;
		ColumnDefinitions columnDefinitions4 = new ColumnDefinitions();
		columnDefinitions4.Capacity = 2;
		columnDefinitions4.Add(new ColumnDefinition(new GridLength(160.0, GridUnitType.Pixel)));
		columnDefinitions4.Add(new ColumnDefinition(new GridLength(50.0, GridUnitType.Pixel)));
		grid17.ColumnDefinitions = columnDefinitions4;
		Avalonia.Controls.Controls children7 = grid17.Children;
		TextBlock textBlock15;
		TextBlock textBlock14 = (textBlock15 = new TextBlock());
		((ISupportInitialize)textBlock14).BeginInit();
		children7.Add(textBlock14);
		TextBlock textBlock16 = (textBlock4 = textBlock15);
		context.PushParent(textBlock4);
		TextBlock textBlock17 = textBlock4;
		Grid.SetColumn(textBlock17, 0);
		textBlock17.Text = "Analytics";
		StaticResourceExtension staticResourceExtension7 = new StaticResourceExtension("FontStyle_2");
		context.ProvideTargetProperty = TextBlock.FontFamilyProperty;
		object? obj11 = staticResourceExtension7.ProvideValue(context);
		context.ProvideTargetProperty = null;
		CompiledAvaloniaXaml.XamlDynamicSetters._003C_003EXamlDynamicSetter_2(textBlock17, obj11);
		textBlock17.FontSize = 17.0;
		textBlock17.Foreground = new ImmutableSolidColorBrush(uint.MaxValue);
		textBlock17.VerticalAlignment = VerticalAlignment.Center;
		textBlock17.HorizontalAlignment = HorizontalAlignment.Left;
		textBlock17.Margin = new Thickness(10.0, 0.0, 0.0, 0.0);
		context.PopParent();
		((ISupportInitialize)textBlock16).EndInit();
		Avalonia.Controls.Controls children8 = grid17.Children;
		Image image15;
		Image image14 = (image15 = new Image());
		((ISupportInitialize)image14).BeginInit();
		children8.Add(image14);
		Image image16 = (image4 = image15);
		context.PushParent(image4);
		Image image17 = image4;
		Grid.SetColumn(image17, 1);
		StaticResourceExtension staticResourceExtension8 = new StaticResourceExtension("Analytics_S3");
		context.ProvideTargetProperty = Image.SourceProperty;
		object? obj12 = staticResourceExtension8.ProvideValue(context);
		context.ProvideTargetProperty = null;
		CompiledAvaloniaXaml.XamlDynamicSetters._003C_003EXamlDynamicSetter_1(image17, obj12);
		image17.Stretch = Stretch.None;
		image17.HorizontalAlignment = HorizontalAlignment.Center;
		image17.VerticalAlignment = VerticalAlignment.Center;
		context.PopParent();
		((ISupportInitialize)image16).EndInit();
		context.PopParent();
		((ISupportInitialize)grid16).EndInit();
		context.PopParent();
		((ISupportInitialize)toggleButton16).EndInit();
		context.PopParent();
		((ISupportInitialize)listBoxItem16).EndInit();
		ItemCollection items5 = listBox4.Items;
		ListBoxItem listBoxItem19;
		ListBoxItem listBoxItem18 = (listBoxItem19 = new ListBoxItem());
		((ISupportInitialize)listBoxItem18).BeginInit();
		items5.Add(listBoxItem18);
		ListBoxItem listBoxItem20 = (listBoxItem4 = listBoxItem19);
		context.PushParent(listBoxItem4);
		ListBoxItem listBoxItem21 = listBoxItem4;
		listBoxItem21.Name = "Settings_ListBoxItem";
		element = listBoxItem21;
		context.AvaloniaNameScope.Register("Settings_ListBoxItem", element);
		listBoxItem21.Tag = "Settings";
		ToggleButton toggleButton19;
		ToggleButton toggleButton18 = (toggleButton19 = new ToggleButton());
		((ISupportInitialize)toggleButton18).BeginInit();
		listBoxItem21.Content = toggleButton18;
		ToggleButton toggleButton20 = (toggleButton4 = toggleButton19);
		context.PushParent(toggleButton4);
		ToggleButton toggleButton21 = toggleButton4;
		toggleButton21.Classes.Add("SidePanelItem");
		StyledProperty<bool?> isCheckedProperty5 = ToggleButton.IsCheckedProperty;
		CompiledBindingExtension obj13 = new CompiledBindingExtension(new CompiledBindingPathBuilder(1).Ancestor(typeof(ListBoxItem), 0).Property(ListBoxItem.IsSelectedProperty, PropertyInfoAccessorFactory.CreateAvaloniaPropertyAccessor).Build())
		{
			Mode = BindingMode.TwoWay
		};
		context.ProvideTargetProperty = ToggleButton.IsCheckedProperty;
		CompiledBindingExtension binding5 = obj13.ProvideValue(context);
		context.ProvideTargetProperty = null;
		AvaloniaObjectExtensions.Bind(toggleButton21, isCheckedProperty5, binding5);
		Grid grid19;
		Grid grid18 = (grid19 = new Grid());
		((ISupportInitialize)grid18).BeginInit();
		toggleButton21.Content = grid18;
		Grid grid20 = (grid4 = grid19);
		context.PushParent(grid4);
		Grid grid21 = grid4;
		grid21.Height = 40.0;
		grid21.Width = 210.0;
		ColumnDefinitions columnDefinitions5 = new ColumnDefinitions();
		columnDefinitions5.Capacity = 2;
		columnDefinitions5.Add(new ColumnDefinition(new GridLength(160.0, GridUnitType.Pixel)));
		columnDefinitions5.Add(new ColumnDefinition(new GridLength(50.0, GridUnitType.Pixel)));
		grid21.ColumnDefinitions = columnDefinitions5;
		Avalonia.Controls.Controls children9 = grid21.Children;
		TextBlock textBlock19;
		TextBlock textBlock18 = (textBlock19 = new TextBlock());
		((ISupportInitialize)textBlock18).BeginInit();
		children9.Add(textBlock18);
		TextBlock textBlock20 = (textBlock4 = textBlock19);
		context.PushParent(textBlock4);
		TextBlock textBlock21 = textBlock4;
		Grid.SetColumn(textBlock21, 0);
		textBlock21.Text = "Settings";
		StaticResourceExtension staticResourceExtension9 = new StaticResourceExtension("FontStyle_2");
		context.ProvideTargetProperty = TextBlock.FontFamilyProperty;
		object? obj14 = staticResourceExtension9.ProvideValue(context);
		context.ProvideTargetProperty = null;
		CompiledAvaloniaXaml.XamlDynamicSetters._003C_003EXamlDynamicSetter_2(textBlock21, obj14);
		textBlock21.FontSize = 17.0;
		textBlock21.Foreground = new ImmutableSolidColorBrush(uint.MaxValue);
		textBlock21.VerticalAlignment = VerticalAlignment.Center;
		textBlock21.HorizontalAlignment = HorizontalAlignment.Left;
		textBlock21.Margin = new Thickness(10.0, 0.0, 0.0, 0.0);
		context.PopParent();
		((ISupportInitialize)textBlock20).EndInit();
		Avalonia.Controls.Controls children10 = grid21.Children;
		Image image19;
		Image image18 = (image19 = new Image());
		((ISupportInitialize)image18).BeginInit();
		children10.Add(image18);
		Image image20 = (image4 = image19);
		context.PushParent(image4);
		Image image21 = image4;
		Grid.SetColumn(image21, 1);
		StaticResourceExtension staticResourceExtension10 = new StaticResourceExtension("Settings_S3");
		context.ProvideTargetProperty = Image.SourceProperty;
		object? obj15 = staticResourceExtension10.ProvideValue(context);
		context.ProvideTargetProperty = null;
		CompiledAvaloniaXaml.XamlDynamicSetters._003C_003EXamlDynamicSetter_1(image21, obj15);
		image21.Stretch = Stretch.None;
		image21.HorizontalAlignment = HorizontalAlignment.Center;
		image21.VerticalAlignment = VerticalAlignment.Center;
		context.PopParent();
		((ISupportInitialize)image20).EndInit();
		context.PopParent();
		((ISupportInitialize)grid20).EndInit();
		context.PopParent();
		((ISupportInitialize)toggleButton20).EndInit();
		context.PopParent();
		((ISupportInitialize)listBoxItem20).EndInit();
		context.PopParent();
		((ISupportInitialize)listBox3).EndInit();
		context.PopParent();
		((ISupportInitialize)P_1).EndInit();
		if (P_1 is StyledElement styled)
		{
			NameScope.SetNameScope(styled, context.AvaloniaNameScope);
		}
		context.AvaloniaNameScope.Complete();
	}

	private static void _0021XamlIlPopulateTrampoline(SidePanel P_0)
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
