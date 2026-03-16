using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Input;
using Avalonia.Layout;
using Avalonia.Markup.Xaml.MarkupExtensions;
using Avalonia.Markup.Xaml.XamlIl.Runtime;
using Avalonia.Media;
using Avalonia.Media.Immutable;
using Avalonia.Styling;
using CompiledAvaloniaXaml;

namespace HamburgerMenu.Controls;

[CompilerGenerated]
public class SideBar : UserControl
{
	[GeneratedCode("Avalonia.Generators.NameGenerator.InitializeComponentCodeGenerator", "11.2.1.0")]
	internal ListBoxItem SideBar_Dashboard;

	[GeneratedCode("Avalonia.Generators.NameGenerator.InitializeComponentCodeGenerator", "11.2.1.0")]
	internal ListBoxItem SideBar_Mail;

	[GeneratedCode("Avalonia.Generators.NameGenerator.InitializeComponentCodeGenerator", "11.2.1.0")]
	internal ListBoxItem SideBar_Customer;

	[GeneratedCode("Avalonia.Generators.NameGenerator.InitializeComponentCodeGenerator", "11.2.1.0")]
	internal ListBoxItem SideBar_Analytics;

	[GeneratedCode("Avalonia.Generators.NameGenerator.InitializeComponentCodeGenerator", "11.2.1.0")]
	internal ListBoxItem SideBar_Settings;

	private static Action<object> _0021XamlIlPopulateOverride;

	public SideBar()
	{
		InitializeComponent();
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
		SideBar_Dashboard = nameScope?.Find<ListBoxItem>("SideBar_Dashboard");
		SideBar_Mail = nameScope?.Find<ListBoxItem>("SideBar_Mail");
		SideBar_Customer = nameScope?.Find<ListBoxItem>("SideBar_Customer");
		SideBar_Analytics = nameScope?.Find<ListBoxItem>("SideBar_Analytics");
		SideBar_Settings = nameScope?.Find<ListBoxItem>("SideBar_Settings");
	}

	private static void _0021XamlIlPopulate(IServiceProvider P_0, SideBar P_1)
	{
		CompiledAvaloniaXaml.XamlIlContext.Context<SideBar> context = new CompiledAvaloniaXaml.XamlIlContext.Context<SideBar>(P_0, new object[1] { _0021AvaloniaResources.NamespaceInfo_003A_002FControls_002FSideBar_002Eaxaml.Singleton }, "avares://HamburgerMenu.Avalonia/Controls/SideBar.axaml")
		{
			RootObject = P_1,
			IntermediateRoot = P_1
		};
		((ISupportInitialize)P_1).BeginInit();
		context.PushParent(P_1);
		StackPanel stackPanel2;
		StackPanel stackPanel = (stackPanel2 = new StackPanel());
		((ISupportInitialize)stackPanel).BeginInit();
		P_1.Content = stackPanel;
		StackPanel stackPanel4;
		StackPanel stackPanel3 = (stackPanel4 = stackPanel2);
		context.PushParent(stackPanel4);
		stackPanel4.Width = 50.0;
		stackPanel4.HorizontalAlignment = HorizontalAlignment.Right;
		stackPanel4.Height = 200.0;
		Avalonia.Controls.Controls children = stackPanel4.Children;
		ListBox listBox2;
		ListBox listBox = (listBox2 = new ListBox());
		((ISupportInitialize)listBox).BeginInit();
		children.Add(listBox);
		ListBox listBox4;
		ListBox listBox3 = (listBox4 = listBox2);
		context.PushParent(listBox4);
		listBox4.Background = new ImmutableSolidColorBrush(16777215u);
		listBox4.SelectionMode = SelectionMode.Single;
		listBox4.Cursor = new Cursor(StandardCursorType.Hand);
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
		listBoxItem5.Name = "SideBar_Dashboard";
		object element = listBoxItem5;
		context.AvaloniaNameScope.Register("SideBar_Dashboard", element);
		ToggleButton toggleButton2;
		ToggleButton toggleButton = (toggleButton2 = new ToggleButton());
		((ISupportInitialize)toggleButton).BeginInit();
		listBoxItem5.Content = toggleButton;
		ToggleButton toggleButton4;
		ToggleButton toggleButton3 = (toggleButton4 = toggleButton2);
		context.PushParent(toggleButton4);
		ToggleButton toggleButton5 = toggleButton4;
		toggleButton5.Classes.Add("SideBarItem");
		Image image2;
		Image image = (image2 = new Image());
		((ISupportInitialize)image).BeginInit();
		toggleButton5.Content = image;
		Image image4;
		Image image3 = (image4 = image2);
		context.PushParent(image4);
		Image image5 = image4;
		StaticResourceExtension staticResourceExtension = new StaticResourceExtension("Dashboard_S3");
		context.ProvideTargetProperty = Image.SourceProperty;
		object? obj = staticResourceExtension.ProvideValue(context);
		context.ProvideTargetProperty = null;
		CompiledAvaloniaXaml.XamlDynamicSetters._003C_003EXamlDynamicSetter_1(image5, obj);
		image5.Stretch = Stretch.None;
		context.PopParent();
		((ISupportInitialize)image3).EndInit();
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
		listBoxItem9.Name = "SideBar_Mail";
		element = listBoxItem9;
		context.AvaloniaNameScope.Register("SideBar_Mail", element);
		ToggleButton toggleButton7;
		ToggleButton toggleButton6 = (toggleButton7 = new ToggleButton());
		((ISupportInitialize)toggleButton6).BeginInit();
		listBoxItem9.Content = toggleButton6;
		ToggleButton toggleButton8 = (toggleButton4 = toggleButton7);
		context.PushParent(toggleButton4);
		ToggleButton toggleButton9 = toggleButton4;
		toggleButton9.Classes.Add("SideBarItem");
		Image image7;
		Image image6 = (image7 = new Image());
		((ISupportInitialize)image6).BeginInit();
		toggleButton9.Content = image6;
		Image image8 = (image4 = image7);
		context.PushParent(image4);
		Image image9 = image4;
		StaticResourceExtension staticResourceExtension2 = new StaticResourceExtension("Mail_S3");
		context.ProvideTargetProperty = Image.SourceProperty;
		object? obj2 = staticResourceExtension2.ProvideValue(context);
		context.ProvideTargetProperty = null;
		CompiledAvaloniaXaml.XamlDynamicSetters._003C_003EXamlDynamicSetter_1(image9, obj2);
		image9.Stretch = Stretch.None;
		context.PopParent();
		((ISupportInitialize)image8).EndInit();
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
		listBoxItem13.Name = "SideBar_Customer";
		element = listBoxItem13;
		context.AvaloniaNameScope.Register("SideBar_Customer", element);
		ToggleButton toggleButton11;
		ToggleButton toggleButton10 = (toggleButton11 = new ToggleButton());
		((ISupportInitialize)toggleButton10).BeginInit();
		listBoxItem13.Content = toggleButton10;
		ToggleButton toggleButton12 = (toggleButton4 = toggleButton11);
		context.PushParent(toggleButton4);
		ToggleButton toggleButton13 = toggleButton4;
		toggleButton13.Classes.Add("SideBarItem");
		Image image11;
		Image image10 = (image11 = new Image());
		((ISupportInitialize)image10).BeginInit();
		toggleButton13.Content = image10;
		Image image12 = (image4 = image11);
		context.PushParent(image4);
		Image image13 = image4;
		StaticResourceExtension staticResourceExtension3 = new StaticResourceExtension("Customer_S3");
		context.ProvideTargetProperty = Image.SourceProperty;
		object? obj3 = staticResourceExtension3.ProvideValue(context);
		context.ProvideTargetProperty = null;
		CompiledAvaloniaXaml.XamlDynamicSetters._003C_003EXamlDynamicSetter_1(image13, obj3);
		image13.Stretch = Stretch.None;
		context.PopParent();
		((ISupportInitialize)image12).EndInit();
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
		listBoxItem17.Name = "SideBar_Analytics";
		element = listBoxItem17;
		context.AvaloniaNameScope.Register("SideBar_Analytics", element);
		ToggleButton toggleButton15;
		ToggleButton toggleButton14 = (toggleButton15 = new ToggleButton());
		((ISupportInitialize)toggleButton14).BeginInit();
		listBoxItem17.Content = toggleButton14;
		ToggleButton toggleButton16 = (toggleButton4 = toggleButton15);
		context.PushParent(toggleButton4);
		ToggleButton toggleButton17 = toggleButton4;
		toggleButton17.Classes.Add("SideBarItem");
		Image image15;
		Image image14 = (image15 = new Image());
		((ISupportInitialize)image14).BeginInit();
		toggleButton17.Content = image14;
		Image image16 = (image4 = image15);
		context.PushParent(image4);
		Image image17 = image4;
		StaticResourceExtension staticResourceExtension4 = new StaticResourceExtension("Analytics_S3");
		context.ProvideTargetProperty = Image.SourceProperty;
		object? obj4 = staticResourceExtension4.ProvideValue(context);
		context.ProvideTargetProperty = null;
		CompiledAvaloniaXaml.XamlDynamicSetters._003C_003EXamlDynamicSetter_1(image17, obj4);
		image17.Stretch = Stretch.None;
		context.PopParent();
		((ISupportInitialize)image16).EndInit();
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
		listBoxItem21.Name = "SideBar_Settings";
		element = listBoxItem21;
		context.AvaloniaNameScope.Register("SideBar_Settings", element);
		ToggleButton toggleButton19;
		ToggleButton toggleButton18 = (toggleButton19 = new ToggleButton());
		((ISupportInitialize)toggleButton18).BeginInit();
		listBoxItem21.Content = toggleButton18;
		ToggleButton toggleButton20 = (toggleButton4 = toggleButton19);
		context.PushParent(toggleButton4);
		ToggleButton toggleButton21 = toggleButton4;
		toggleButton21.Classes.Add("SideBarItem");
		Image image19;
		Image image18 = (image19 = new Image());
		((ISupportInitialize)image18).BeginInit();
		toggleButton21.Content = image18;
		Image image20 = (image4 = image19);
		context.PushParent(image4);
		Image image21 = image4;
		StaticResourceExtension staticResourceExtension5 = new StaticResourceExtension("Settings_S3");
		context.ProvideTargetProperty = Image.SourceProperty;
		object? obj5 = staticResourceExtension5.ProvideValue(context);
		context.ProvideTargetProperty = null;
		CompiledAvaloniaXaml.XamlDynamicSetters._003C_003EXamlDynamicSetter_1(image21, obj5);
		image21.Stretch = Stretch.None;
		context.PopParent();
		((ISupportInitialize)image20).EndInit();
		context.PopParent();
		((ISupportInitialize)toggleButton20).EndInit();
		context.PopParent();
		((ISupportInitialize)listBoxItem20).EndInit();
		context.PopParent();
		((ISupportInitialize)listBox3).EndInit();
		context.PopParent();
		((ISupportInitialize)stackPanel3).EndInit();
		context.PopParent();
		((ISupportInitialize)P_1).EndInit();
		if (P_1 is StyledElement styled)
		{
			NameScope.SetNameScope(styled, context.AvaloniaNameScope);
		}
		context.AvaloniaNameScope.Complete();
	}

	private static void _0021XamlIlPopulateTrampoline(SideBar P_0)
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
