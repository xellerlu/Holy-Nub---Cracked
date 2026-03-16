using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Data;
using Avalonia.Input;
using Avalonia.Interactivity;
using Avalonia.Layout;
using Avalonia.Markup.Xaml;
using Avalonia.Markup.Xaml.MarkupExtensions;
using Avalonia.Markup.Xaml.MarkupExtensions.CompiledBindings;
using Avalonia.Markup.Xaml.Templates;
using Avalonia.Markup.Xaml.XamlIl.Runtime;
using Avalonia.Media;
using Avalonia.Media.Immutable;
using Avalonia.Styling;
using CompiledAvaloniaXaml;

namespace HamburgerMenu.Controls;

[CompilerGenerated]
public class SubmenuTwo : UserControl
{
	[CompilerGenerated]
	private class XamlClosure_4
	{
		public static object Build_1(IServiceProvider P_0)
		{
			CompiledAvaloniaXaml.XamlIlContext.Context<SubmenuTwo> context = CreateContext(P_0);
			context.IntermediateRoot = new UniformGrid();
			object obj = context.IntermediateRoot;
			((ISupportInitialize)obj).BeginInit();
			((AvaloniaObject)obj).SetValue(UniformGrid.ColumnsProperty, 2, BindingPriority.Template);
			((ISupportInitialize)obj).EndInit();
			return obj;
		}

		public static CompiledAvaloniaXaml.XamlIlContext.Context<SubmenuTwo> CreateContext(IServiceProvider P_0)
		{
			CompiledAvaloniaXaml.XamlIlContext.Context<SubmenuTwo> context = new CompiledAvaloniaXaml.XamlIlContext.Context<SubmenuTwo>(P_0, new object[1] { _0021AvaloniaResources.NamespaceInfo_003A_002FControls_002FSubmenuTwo_002Eaxaml.Singleton }, "avares://HamburgerMenu.Avalonia/Controls/SubmenuTwo.axaml");
			if (P_0 != null)
			{
				object service = P_0.GetService(typeof(IRootObjectProvider));
				if (service != null)
				{
					service = ((IRootObjectProvider)service).RootObject;
					context.RootObject = (SubmenuTwo)service;
				}
			}
			return context;
		}
	}

	[GeneratedCode("Avalonia.Generators.NameGenerator.InitializeComponentCodeGenerator", "11.2.1.0")]
	internal Panel SubmenuTwo_Container;

	[GeneratedCode("Avalonia.Generators.NameGenerator.InitializeComponentCodeGenerator", "11.2.1.0")]
	internal Button Close_SubmenuTwo;

	[GeneratedCode("Avalonia.Generators.NameGenerator.InitializeComponentCodeGenerator", "11.2.1.0")]
	internal ListBoxItem Password_ListBoxItem;

	[GeneratedCode("Avalonia.Generators.NameGenerator.InitializeComponentCodeGenerator", "11.2.1.0")]
	internal ListBoxItem Notification_ListBoxItem;

	private static Action<object> _0021XamlIlPopulateOverride;

	public SubmenuTwo()
	{
		InitializeComponent();
	}

	private MainWindow? GetMainWindow()
	{
		return TopLevel.GetTopLevel(this) as MainWindow;
	}

	private void Close_SubmenuTwo_Click(object? sender, RoutedEventArgs e)
	{
		MainWindow? mainWindow = GetMainWindow();
		mainWindow?.HideSubmenuTwo();
		SubmenuTwo_Container.IsEnabled = false;
		Password_ListBoxItem.IsSelected = false;
		Notification_ListBoxItem.IsSelected = false;
		mainWindow?.SubmenuOne_UC?.UnselectAccount();
	}

	public void EnableContainer()
	{
		SubmenuTwo_Container.IsEnabled = true;
	}

	public void DisableContainer()
	{
		SubmenuTwo_Container.IsEnabled = false;
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
		SubmenuTwo_Container = nameScope?.Find<Panel>("SubmenuTwo_Container");
		Close_SubmenuTwo = nameScope?.Find<Button>("Close_SubmenuTwo");
		Password_ListBoxItem = nameScope?.Find<ListBoxItem>("Password_ListBoxItem");
		Notification_ListBoxItem = nameScope?.Find<ListBoxItem>("Notification_ListBoxItem");
	}

	private unsafe static void _0021XamlIlPopulate(IServiceProvider P_0, SubmenuTwo P_1)
	{
		CompiledAvaloniaXaml.XamlIlContext.Context<SubmenuTwo> context = new CompiledAvaloniaXaml.XamlIlContext.Context<SubmenuTwo>(P_0, new object[1] { _0021AvaloniaResources.NamespaceInfo_003A_002FControls_002FSubmenuTwo_002Eaxaml.Singleton }, "avares://HamburgerMenu.Avalonia/Controls/SubmenuTwo.axaml")
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
		Panel panel5 = panel4;
		panel5.Name = "SubmenuTwo_Container";
		object element = panel5;
		context.AvaloniaNameScope.Register("SubmenuTwo_Container", element);
		panel5.Height = 152.0;
		panel5.Width = 275.0;
		Avalonia.Controls.Controls children = panel5.Children;
		Border border2;
		Border border = (border2 = new Border());
		((ISupportInitialize)border).BeginInit();
		children.Add(border);
		border2.Height = 40.0;
		border2.Background = new ImmutableSolidColorBrush(uint.MaxValue);
		border2.VerticalAlignment = VerticalAlignment.Top;
		border2.CornerRadius = new CornerRadius(8.0, 8.0, 0.0, 0.0);
		((ISupportInitialize)border2).EndInit();
		Avalonia.Controls.Controls children2 = panel5.Children;
		Border border4;
		Border border3 = (border4 = new Border());
		((ISupportInitialize)border3).BeginInit();
		children2.Add(border3);
		Border border6;
		Border border5 = (border6 = border4);
		context.PushParent(border6);
		Border border7 = border6;
		border7.Height = 24.0;
		border7.Width = 80.0;
		border7.Background = new ImmutableSolidColorBrush(4283782485u);
		border7.CornerRadius = new CornerRadius(6.0, 6.0, 6.0, 6.0);
		border7.VerticalAlignment = VerticalAlignment.Top;
		border7.HorizontalAlignment = HorizontalAlignment.Left;
		border7.Margin = new Thickness(10.0, 9.0, 0.0, 0.0);
		TextBlock textBlock2;
		TextBlock textBlock = (textBlock2 = new TextBlock());
		((ISupportInitialize)textBlock).BeginInit();
		border7.Child = textBlock;
		TextBlock textBlock4;
		TextBlock textBlock3 = (textBlock4 = textBlock2);
		context.PushParent(textBlock4);
		TextBlock textBlock5 = textBlock4;
		textBlock5.Text = "Account";
		textBlock5.FontSize = 15.0;
		textBlock5.Foreground = new ImmutableSolidColorBrush(uint.MaxValue);
		StaticResourceExtension staticResourceExtension = new StaticResourceExtension("FontStyle_2");
		context.ProvideTargetProperty = TextBlock.FontFamilyProperty;
		object? obj = staticResourceExtension.ProvideValue(context);
		context.ProvideTargetProperty = null;
		CompiledAvaloniaXaml.XamlDynamicSetters._003C_003EXamlDynamicSetter_2(textBlock5, obj);
		textBlock5.HorizontalAlignment = HorizontalAlignment.Center;
		textBlock5.VerticalAlignment = VerticalAlignment.Center;
		context.PopParent();
		((ISupportInitialize)textBlock3).EndInit();
		context.PopParent();
		((ISupportInitialize)border5).EndInit();
		Avalonia.Controls.Controls children3 = panel5.Children;
		Button button2;
		Button button = (button2 = new Button());
		((ISupportInitialize)button).BeginInit();
		children3.Add(button);
		Button button4;
		Button button3 = (button4 = button2);
		context.PushParent(button4);
		button4.Name = "Close_SubmenuTwo";
		element = button4;
		context.AvaloniaNameScope.Register("Close_SubmenuTwo", element);
		button4.Classes.Add("SubmenuCloseBtn");
		button4.Margin = new Thickness(0.0, 8.0, 8.0, 0.0);
		button4.HorizontalAlignment = HorizontalAlignment.Right;
		button4.VerticalAlignment = VerticalAlignment.Top;
		button4.AddHandler((RoutedEvent)Button.ClickEvent, (Delegate)new EventHandler<RoutedEventArgs>(context.RootObject.Close_SubmenuTwo_Click), RoutingStrategies.Direct | RoutingStrategies.Bubble, handledEventsToo: false);
		Image image2;
		Image image = (image2 = new Image());
		((ISupportInitialize)image).BeginInit();
		button4.Content = image;
		Image image4;
		Image image3 = (image4 = image2);
		context.PushParent(image4);
		Image image5 = image4;
		StaticResourceExtension staticResourceExtension2 = new StaticResourceExtension("SubmenuTwo_CB1");
		context.ProvideTargetProperty = Image.SourceProperty;
		object? obj2 = staticResourceExtension2.ProvideValue(context);
		context.ProvideTargetProperty = null;
		CompiledAvaloniaXaml.XamlDynamicSetters._003C_003EXamlDynamicSetter_1(image5, obj2);
		image5.Stretch = Stretch.None;
		context.PopParent();
		((ISupportInitialize)image3).EndInit();
		context.PopParent();
		((ISupportInitialize)button3).EndInit();
		Avalonia.Controls.Controls children4 = panel5.Children;
		Border border9;
		Border border8 = (border9 = new Border());
		((ISupportInitialize)border8).BeginInit();
		children4.Add(border8);
		Border border10 = (border6 = border9);
		context.PushParent(border6);
		Border border11 = border6;
		border11.Background = new ImmutableSolidColorBrush(4281545523u);
		border11.BorderBrush = new ImmutableSolidColorBrush(uint.MaxValue);
		border11.BorderThickness = new Thickness(0.0, 0.0, 0.0, 5.0);
		border11.CornerRadius = new CornerRadius(8.0, 8.0, 8.0, 8.0);
		border11.ZIndex = -1;
		Panel panel7;
		Panel panel6 = (panel7 = new Panel());
		((ISupportInitialize)panel6).BeginInit();
		border11.Child = panel6;
		Panel panel8 = (panel4 = panel7);
		context.PushParent(panel4);
		Panel panel9 = panel4;
		panel9.Margin = new Thickness(0.0, 38.0, 0.0, 0.0);
		panel9.Height = 70.0;
		panel9.VerticalAlignment = VerticalAlignment.Center;
		Avalonia.Controls.Controls children5 = panel9.Children;
		ListBox listBox2;
		ListBox listBox = (listBox2 = new ListBox());
		((ISupportInitialize)listBox).BeginInit();
		children5.Add(listBox);
		ListBox listBox4;
		ListBox listBox3 = (listBox4 = listBox2);
		context.PushParent(listBox4);
		listBox4.Background = new ImmutableSolidColorBrush(16777215u);
		listBox4.SelectionMode = SelectionMode.Single;
		listBox4.Cursor = new Cursor(StandardCursorType.Hand);
		listBox4.ItemsPanel = new ItemsPanelTemplate
		{
			Content = XamlIlRuntimeHelpers.DeferredTransformationFactoryV3<Control>((nint)(delegate*<IServiceProvider, object>)(&XamlClosure_4.Build_1), context)
		};
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
		styles.Add(style);
		ItemCollection items = listBox4.Items;
		ListBoxItem listBoxItem2;
		ListBoxItem listBoxItem = (listBoxItem2 = new ListBoxItem());
		((ISupportInitialize)listBoxItem).BeginInit();
		items.Add(listBoxItem);
		ListBoxItem listBoxItem4;
		ListBoxItem listBoxItem3 = (listBoxItem4 = listBoxItem2);
		context.PushParent(listBoxItem4);
		ListBoxItem listBoxItem5 = listBoxItem4;
		listBoxItem5.Name = "Password_ListBoxItem";
		element = listBoxItem5;
		context.AvaloniaNameScope.Register("Password_ListBoxItem", element);
		ToggleButton toggleButton2;
		ToggleButton toggleButton = (toggleButton2 = new ToggleButton());
		((ISupportInitialize)toggleButton).BeginInit();
		listBoxItem5.Content = toggleButton;
		ToggleButton toggleButton4;
		ToggleButton toggleButton3 = (toggleButton4 = toggleButton2);
		context.PushParent(toggleButton4);
		ToggleButton toggleButton5 = toggleButton4;
		toggleButton5.Classes.Add("SubmenuTwoItem");
		toggleButton5.Width = 112.0;
		toggleButton5.Margin = new Thickness(0.0, 0.0, 5.0, 0.0);
		StyledProperty<bool?> isCheckedProperty = ToggleButton.IsCheckedProperty;
		CompiledBindingExtension obj3 = new CompiledBindingExtension(new CompiledBindingPathBuilder(1).Ancestor(typeof(ListBoxItem), 0).Property(ListBoxItem.IsSelectedProperty, PropertyInfoAccessorFactory.CreateAvaloniaPropertyAccessor).Build())
		{
			Mode = BindingMode.TwoWay
		};
		context.ProvideTargetProperty = ToggleButton.IsCheckedProperty;
		CompiledBindingExtension binding = obj3.ProvideValue(context);
		context.ProvideTargetProperty = null;
		AvaloniaObjectExtensions.Bind(toggleButton5, isCheckedProperty, binding);
		StackPanel stackPanel2;
		StackPanel stackPanel = (stackPanel2 = new StackPanel());
		((ISupportInitialize)stackPanel).BeginInit();
		toggleButton5.Content = stackPanel;
		StackPanel stackPanel4;
		StackPanel stackPanel3 = (stackPanel4 = stackPanel2);
		context.PushParent(stackPanel4);
		StackPanel stackPanel5 = stackPanel4;
		stackPanel5.HorizontalAlignment = HorizontalAlignment.Center;
		stackPanel5.VerticalAlignment = VerticalAlignment.Center;
		Avalonia.Controls.Controls children6 = stackPanel5.Children;
		Image image7;
		Image image6 = (image7 = new Image());
		((ISupportInitialize)image6).BeginInit();
		children6.Add(image6);
		Image image8 = (image4 = image7);
		context.PushParent(image4);
		Image image9 = image4;
		StaticResourceExtension staticResourceExtension3 = new StaticResourceExtension("Password_B1");
		context.ProvideTargetProperty = Image.SourceProperty;
		object? obj4 = staticResourceExtension3.ProvideValue(context);
		context.ProvideTargetProperty = null;
		CompiledAvaloniaXaml.XamlDynamicSetters._003C_003EXamlDynamicSetter_1(image9, obj4);
		image9.Stretch = Stretch.None;
		image9.HorizontalAlignment = HorizontalAlignment.Center;
		image9.Margin = new Thickness(0.0, 0.0, 0.0, 5.0);
		context.PopParent();
		((ISupportInitialize)image8).EndInit();
		Avalonia.Controls.Controls children7 = stackPanel5.Children;
		TextBlock textBlock7;
		TextBlock textBlock6 = (textBlock7 = new TextBlock());
		((ISupportInitialize)textBlock6).BeginInit();
		children7.Add(textBlock6);
		TextBlock textBlock8 = (textBlock4 = textBlock7);
		context.PushParent(textBlock4);
		TextBlock textBlock9 = textBlock4;
		textBlock9.Text = "Password";
		textBlock9.FontSize = 14.0;
		StaticResourceExtension staticResourceExtension4 = new StaticResourceExtension("FontStyle_2");
		context.ProvideTargetProperty = TextBlock.FontFamilyProperty;
		object? obj5 = staticResourceExtension4.ProvideValue(context);
		context.ProvideTargetProperty = null;
		CompiledAvaloniaXaml.XamlDynamicSetters._003C_003EXamlDynamicSetter_2(textBlock9, obj5);
		textBlock9.Foreground = new ImmutableSolidColorBrush(uint.MaxValue);
		textBlock9.HorizontalAlignment = HorizontalAlignment.Center;
		context.PopParent();
		((ISupportInitialize)textBlock8).EndInit();
		context.PopParent();
		((ISupportInitialize)stackPanel3).EndInit();
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
		listBoxItem9.Name = "Notification_ListBoxItem";
		element = listBoxItem9;
		context.AvaloniaNameScope.Register("Notification_ListBoxItem", element);
		ToggleButton toggleButton7;
		ToggleButton toggleButton6 = (toggleButton7 = new ToggleButton());
		((ISupportInitialize)toggleButton6).BeginInit();
		listBoxItem9.Content = toggleButton6;
		ToggleButton toggleButton8 = (toggleButton4 = toggleButton7);
		context.PushParent(toggleButton4);
		ToggleButton toggleButton9 = toggleButton4;
		toggleButton9.Classes.Add("SubmenuTwoItem");
		toggleButton9.Width = 112.0;
		toggleButton9.Margin = new Thickness(5.0, 0.0, 0.0, 0.0);
		StyledProperty<bool?> isCheckedProperty2 = ToggleButton.IsCheckedProperty;
		CompiledBindingExtension obj6 = new CompiledBindingExtension(new CompiledBindingPathBuilder(1).Ancestor(typeof(ListBoxItem), 0).Property(ListBoxItem.IsSelectedProperty, PropertyInfoAccessorFactory.CreateAvaloniaPropertyAccessor).Build())
		{
			Mode = BindingMode.TwoWay
		};
		context.ProvideTargetProperty = ToggleButton.IsCheckedProperty;
		CompiledBindingExtension binding2 = obj6.ProvideValue(context);
		context.ProvideTargetProperty = null;
		AvaloniaObjectExtensions.Bind(toggleButton9, isCheckedProperty2, binding2);
		StackPanel stackPanel7;
		StackPanel stackPanel6 = (stackPanel7 = new StackPanel());
		((ISupportInitialize)stackPanel6).BeginInit();
		toggleButton9.Content = stackPanel6;
		StackPanel stackPanel8 = (stackPanel4 = stackPanel7);
		context.PushParent(stackPanel4);
		StackPanel stackPanel9 = stackPanel4;
		stackPanel9.HorizontalAlignment = HorizontalAlignment.Center;
		stackPanel9.VerticalAlignment = VerticalAlignment.Center;
		Avalonia.Controls.Controls children8 = stackPanel9.Children;
		Image image11;
		Image image10 = (image11 = new Image());
		((ISupportInitialize)image10).BeginInit();
		children8.Add(image10);
		Image image12 = (image4 = image11);
		context.PushParent(image4);
		Image image13 = image4;
		StaticResourceExtension staticResourceExtension5 = new StaticResourceExtension("Notification_B1");
		context.ProvideTargetProperty = Image.SourceProperty;
		object? obj7 = staticResourceExtension5.ProvideValue(context);
		context.ProvideTargetProperty = null;
		CompiledAvaloniaXaml.XamlDynamicSetters._003C_003EXamlDynamicSetter_1(image13, obj7);
		image13.Stretch = Stretch.None;
		image13.HorizontalAlignment = HorizontalAlignment.Center;
		image13.Margin = new Thickness(0.0, 0.0, 0.0, 5.0);
		context.PopParent();
		((ISupportInitialize)image12).EndInit();
		Avalonia.Controls.Controls children9 = stackPanel9.Children;
		TextBlock textBlock11;
		TextBlock textBlock10 = (textBlock11 = new TextBlock());
		((ISupportInitialize)textBlock10).BeginInit();
		children9.Add(textBlock10);
		TextBlock textBlock12 = (textBlock4 = textBlock11);
		context.PushParent(textBlock4);
		TextBlock textBlock13 = textBlock4;
		textBlock13.Text = "Notification";
		textBlock13.FontSize = 14.0;
		StaticResourceExtension staticResourceExtension6 = new StaticResourceExtension("FontStyle_2");
		context.ProvideTargetProperty = TextBlock.FontFamilyProperty;
		object? obj8 = staticResourceExtension6.ProvideValue(context);
		context.ProvideTargetProperty = null;
		CompiledAvaloniaXaml.XamlDynamicSetters._003C_003EXamlDynamicSetter_2(textBlock13, obj8);
		textBlock13.Foreground = new ImmutableSolidColorBrush(uint.MaxValue);
		textBlock13.HorizontalAlignment = HorizontalAlignment.Center;
		context.PopParent();
		((ISupportInitialize)textBlock12).EndInit();
		context.PopParent();
		((ISupportInitialize)stackPanel8).EndInit();
		context.PopParent();
		((ISupportInitialize)toggleButton8).EndInit();
		context.PopParent();
		((ISupportInitialize)listBoxItem8).EndInit();
		context.PopParent();
		((ISupportInitialize)listBox3).EndInit();
		context.PopParent();
		((ISupportInitialize)panel8).EndInit();
		context.PopParent();
		((ISupportInitialize)border10).EndInit();
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

	private static void _0021XamlIlPopulateTrampoline(SubmenuTwo P_0)
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
