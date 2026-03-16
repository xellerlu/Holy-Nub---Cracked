using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.CompilerServices;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Input;
using Avalonia.Layout;
using Avalonia.Markup.Xaml;
using Avalonia.Markup.Xaml.MarkupExtensions;
using Avalonia.Markup.Xaml.Templates;
using Avalonia.Markup.Xaml.XamlIl.Runtime;
using Avalonia.Media;
using Avalonia.Media.Immutable;
using Avalonia.Styling;
using Avalonia.Threading;
using CompiledAvaloniaXaml;

namespace HamburgerMenu.Controls;

[CompilerGenerated]
public class SubmenuOne : UserControl
{
	[CompilerGenerated]
	private class XamlClosure_3
	{
		public static object Build_1(IServiceProvider P_0)
		{
			CompiledAvaloniaXaml.XamlIlContext.Context<SubmenuOne> context = CreateContext(P_0);
			context.IntermediateRoot = new StackPanel();
			object obj = context.IntermediateRoot;
			((ISupportInitialize)obj).BeginInit();
			((ISupportInitialize)obj).EndInit();
			return obj;
		}

		public static CompiledAvaloniaXaml.XamlIlContext.Context<SubmenuOne> CreateContext(IServiceProvider P_0)
		{
			CompiledAvaloniaXaml.XamlIlContext.Context<SubmenuOne> context = new CompiledAvaloniaXaml.XamlIlContext.Context<SubmenuOne>(P_0, new object[1] { _0021AvaloniaResources.NamespaceInfo_003A_002FControls_002FSubmenuOne_002Eaxaml.Singleton }, "avares://HamburgerMenu.Avalonia/Controls/SubmenuOne.axaml");
			if (P_0 != null)
			{
				object service = P_0.GetService(typeof(IRootObjectProvider));
				if (service != null)
				{
					service = ((IRootObjectProvider)service).RootObject;
					context.RootObject = (SubmenuOne)service;
				}
			}
			return context;
		}
	}

	[GeneratedCode("Avalonia.Generators.NameGenerator.InitializeComponentCodeGenerator", "11.2.1.0")]
	internal Border AppsPanel;

	[GeneratedCode("Avalonia.Generators.NameGenerator.InitializeComponentCodeGenerator", "11.2.1.0")]
	internal ListBox SubmenuOne_ListBox;

	[GeneratedCode("Avalonia.Generators.NameGenerator.InitializeComponentCodeGenerator", "11.2.1.0")]
	internal ListBoxItem ActivityViewer_ListBoxItem;

	[GeneratedCode("Avalonia.Generators.NameGenerator.InitializeComponentCodeGenerator", "11.2.1.0")]
	internal ListBoxItem JournalWindows_ListBoxItem;

	[GeneratedCode("Avalonia.Generators.NameGenerator.InitializeComponentCodeGenerator", "11.2.1.0")]
	internal ListBoxItem SystemInformer_ListBoxItem;

	[GeneratedCode("Avalonia.Generators.NameGenerator.InitializeComponentCodeGenerator", "11.2.1.0")]
	internal ListBoxItem RegistryAnalyzer_ListBoxItem;

	[GeneratedCode("Avalonia.Generators.NameGenerator.InitializeComponentCodeGenerator", "11.2.1.0")]
	internal ListBoxItem Everything_ListBoxItem;

	private static Action<object> _0021XamlIlPopulateOverride;

	private static string AppsFolder
	{
		get
		{
			string text = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Apps");
			if (Directory.Exists(text))
			{
				return text;
			}
			string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
			string fullPath = Path.GetFullPath(Path.Combine(baseDirectory, "..", "..", "..", "..", "Apps"));
			if (Directory.Exists(fullPath))
			{
				return fullPath;
			}
			return text;
		}
	}

	public SubmenuOne()
	{
		InitializeComponent();
	}

	private void SubmenuOne_SelectionChanged(object? sender, SelectionChangedEventArgs e)
	{
		foreach (object addedItem in e.AddedItems)
		{
			if (addedItem is ListBoxItem listBoxItem)
			{
				string appTag = listBoxItem.Tag?.ToString();
				LaunchApp(appTag);
			}
		}
		Dispatcher.UIThread.Post(delegate
		{
			SubmenuOne_ListBox.SelectedItem = null;
		});
	}

	private void LaunchApp(string? appTag)
	{
		if (string.IsNullOrEmpty(appTag))
		{
			return;
		}
		string text = appTag switch
		{
			"ActivityViewer" => Path.Combine(AppsFolder, "ActivityViewer.exe"), 
			"JournalWindows" => Path.Combine(AppsFolder, "Journal Windows.exe"), 
			"SystemInformer" => Path.Combine(AppsFolder, "amd64", "SystemInformer.exe"), 
			"RegistryAnalyzer" => Path.Combine(AppsFolder, "win-64", "RegistryAnalyzer.exe"), 
			"Everything" => Path.Combine(AppsFolder, "win-x64", "publish", "Everything.exe"), 
			"USBDeview" => Path.Combine(AppsFolder, "usbdeview-x64", "USBDeview.exe"), 
			_ => null, 
		};
		if (text == null || !File.Exists(text))
		{
			return;
		}
		try
		{
			Process.Start(new ProcessStartInfo
			{
				FileName = text,
				WorkingDirectory = Path.GetDirectoryName(text),
				UseShellExecute = true
			});
		}
		catch (Exception)
		{
		}
	}

	public void UnselectAccount()
	{
		SubmenuOne_ListBox.SelectedItem = null;
	}

	private void USBDeview_Click(object? sender, PointerPressedEventArgs e)
	{
		e.Handled = true;
		string[] array = new string[3]
		{
			Path.Combine(AppsFolder, "usbdeview-x64", "USBDeview.exe"),
			Path.Combine(AppsFolder, "USBDeview", "USBDeview.exe"),
			Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "..", "Apps", "usbdeview-x64", "USBDeview.exe")
		};
		for (int i = 0; i < array.Length; i++)
		{
			string fullPath = Path.GetFullPath(array[i]);
			if (File.Exists(fullPath))
			{
				try
				{
					Process.Start(new ProcessStartInfo
					{
						FileName = fullPath,
						WorkingDirectory = Path.GetDirectoryName(fullPath),
						UseShellExecute = true
					});
					break;
				}
				catch
				{
				}
			}
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
		AppsPanel = nameScope?.Find<Border>("AppsPanel");
		SubmenuOne_ListBox = nameScope?.Find<ListBox>("SubmenuOne_ListBox");
		ActivityViewer_ListBoxItem = nameScope?.Find<ListBoxItem>("ActivityViewer_ListBoxItem");
		JournalWindows_ListBoxItem = nameScope?.Find<ListBoxItem>("JournalWindows_ListBoxItem");
		SystemInformer_ListBoxItem = nameScope?.Find<ListBoxItem>("SystemInformer_ListBoxItem");
		RegistryAnalyzer_ListBoxItem = nameScope?.Find<ListBoxItem>("RegistryAnalyzer_ListBoxItem");
		Everything_ListBoxItem = nameScope?.Find<ListBoxItem>("Everything_ListBoxItem");
	}

	private unsafe static void _0021XamlIlPopulate(IServiceProvider P_0, SubmenuOne P_1)
	{
		CompiledAvaloniaXaml.XamlIlContext.Context<SubmenuOne> context = new CompiledAvaloniaXaml.XamlIlContext.Context<SubmenuOne>(P_0, new object[1] { _0021AvaloniaResources.NamespaceInfo_003A_002FControls_002FSubmenuOne_002Eaxaml.Singleton }, "avares://HamburgerMenu.Avalonia/Controls/SubmenuOne.axaml")
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
		border5.Name = "AppsPanel";
		object element = border5;
		context.AvaloniaNameScope.Register("AppsPanel", element);
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
		RowDefinitions rowDefinitions = new RowDefinitions();
		rowDefinitions.Capacity = 2;
		rowDefinitions.Add(new RowDefinition(new GridLength(0.0, GridUnitType.Auto)));
		rowDefinitions.Add(new RowDefinition(new GridLength(1.0, GridUnitType.Star)));
		grid4.RowDefinitions = rowDefinitions;
		Avalonia.Controls.Controls children = grid4.Children;
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
		textBlock5.Text = "Apps";
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
		Avalonia.Controls.Controls children2 = grid4.Children;
		ScrollViewer scrollViewer2;
		ScrollViewer scrollViewer = (scrollViewer2 = new ScrollViewer());
		((ISupportInitialize)scrollViewer).BeginInit();
		children2.Add(scrollViewer);
		ScrollViewer scrollViewer4;
		ScrollViewer scrollViewer3 = (scrollViewer4 = scrollViewer2);
		context.PushParent(scrollViewer4);
		Grid.SetRow(scrollViewer4, 1);
		scrollViewer4.Margin = new Thickness(10.0, 10.0, 10.0, 10.0);
		StackPanel stackPanel2;
		StackPanel stackPanel = (stackPanel2 = new StackPanel());
		((ISupportInitialize)stackPanel).BeginInit();
		scrollViewer4.Content = stackPanel;
		StackPanel stackPanel4;
		StackPanel stackPanel3 = (stackPanel4 = stackPanel2);
		context.PushParent(stackPanel4);
		StackPanel stackPanel5 = stackPanel4;
		Avalonia.Controls.Controls children3 = stackPanel5.Children;
		ListBox listBox2;
		ListBox listBox = (listBox2 = new ListBox());
		((ISupportInitialize)listBox).BeginInit();
		children3.Add(listBox);
		ListBox listBox4;
		ListBox listBox3 = (listBox4 = listBox2);
		context.PushParent(listBox4);
		listBox4.Name = "SubmenuOne_ListBox";
		element = listBox4;
		context.AvaloniaNameScope.Register("SubmenuOne_ListBox", element);
		listBox4.Background = new ImmutableSolidColorBrush(16777215u);
		listBox4.BorderThickness = new Thickness(0.0, 0.0, 0.0, 0.0);
		listBox4.AddHandler(SelectingItemsControl.SelectionChangedEvent, context.RootObject.SubmenuOne_SelectionChanged);
		listBox4.ItemsPanel = new ItemsPanelTemplate
		{
			Content = XamlIlRuntimeHelpers.DeferredTransformationFactoryV3<Control>((nint)(delegate*<IServiceProvider, object>)(&XamlClosure_3.Build_1), context)
		};
		Styles styles = listBox4.Styles;
		Style style = new Style();
		style.Selector = ((Selector?)null).OfType(typeof(ListBoxItem));
		Setter setter = new Setter();
		setter.Property = TemplatedControl.PaddingProperty;
		setter.Value = new Thickness(15.0, 12.0, 15.0, 12.0);
		style.Add(setter);
		Setter setter2 = new Setter();
		setter2.Property = Layoutable.MarginProperty;
		setter2.Value = new Thickness(0.0, 4.0, 0.0, 4.0);
		style.Add(setter2);
		Setter setter3 = new Setter();
		setter3.Property = TemplatedControl.BackgroundProperty;
		setter3.Value = new ImmutableSolidColorBrush(4281677109u);
		style.Add(setter3);
		Setter setter4 = new Setter();
		setter4.Property = TemplatedControl.CornerRadiusProperty;
		setter4.Value = new CornerRadius(8.0, 8.0, 8.0, 8.0);
		style.Add(setter4);
		Setter setter5 = new Setter();
		setter5.Property = InputElement.CursorProperty;
		setter5.Value = new Cursor(StandardCursorType.Hand);
		style.Add(setter5);
		styles.Add(style);
		Styles styles2 = listBox4.Styles;
		Style style2 = new Style();
		style2.Selector = ((Selector?)null).OfType(typeof(ListBoxItem)).Class(":pointerover");
		Setter setter6 = new Setter();
		setter6.Property = TemplatedControl.BackgroundProperty;
		setter6.Value = new ImmutableSolidColorBrush(4282729797u);
		style2.Add(setter6);
		styles2.Add(style2);
		Styles styles3 = listBox4.Styles;
		Style style3 = new Style();
		style3.Selector = ((Selector?)null).OfType(typeof(ListBoxItem)).Class(":selected");
		Setter setter7 = new Setter();
		setter7.Property = TemplatedControl.BackgroundProperty;
		setter7.Value = new ImmutableSolidColorBrush(4283453520u);
		style3.Add(setter7);
		styles3.Add(style3);
		ItemCollection items = listBox4.Items;
		ListBoxItem listBoxItem2;
		ListBoxItem listBoxItem = (listBoxItem2 = new ListBoxItem());
		((ISupportInitialize)listBoxItem).BeginInit();
		items.Add(listBoxItem);
		ListBoxItem listBoxItem4;
		ListBoxItem listBoxItem3 = (listBoxItem4 = listBoxItem2);
		context.PushParent(listBoxItem4);
		ListBoxItem listBoxItem5 = listBoxItem4;
		listBoxItem5.Name = "ActivityViewer_ListBoxItem";
		element = listBoxItem5;
		context.AvaloniaNameScope.Register("ActivityViewer_ListBoxItem", element);
		listBoxItem5.Tag = "ActivityViewer";
		StackPanel stackPanel7;
		StackPanel stackPanel6 = (stackPanel7 = new StackPanel());
		((ISupportInitialize)stackPanel6).BeginInit();
		listBoxItem5.Content = stackPanel6;
		StackPanel stackPanel8 = (stackPanel4 = stackPanel7);
		context.PushParent(stackPanel4);
		StackPanel stackPanel9 = stackPanel4;
		stackPanel9.Orientation = Orientation.Horizontal;
		stackPanel9.Spacing = 12.0;
		Avalonia.Controls.Controls children4 = stackPanel9.Children;
		Border border11;
		Border border10 = (border11 = new Border());
		((ISupportInitialize)border10).BeginInit();
		children4.Add(border10);
		border11.Width = 40.0;
		border11.Height = 40.0;
		border11.Background = new ImmutableSolidColorBrush(4294937600u);
		border11.CornerRadius = new CornerRadius(8.0, 8.0, 8.0, 8.0);
		TextBlock textBlock7;
		TextBlock textBlock6 = (textBlock7 = new TextBlock());
		((ISupportInitialize)textBlock6).BeginInit();
		border11.Child = textBlock6;
		textBlock7.Text = "\ud83d\udcca";
		textBlock7.FontSize = 20.0;
		textBlock7.HorizontalAlignment = HorizontalAlignment.Center;
		textBlock7.VerticalAlignment = VerticalAlignment.Center;
		((ISupportInitialize)textBlock7).EndInit();
		((ISupportInitialize)border11).EndInit();
		Avalonia.Controls.Controls children5 = stackPanel9.Children;
		StackPanel stackPanel11;
		StackPanel stackPanel10 = (stackPanel11 = new StackPanel());
		((ISupportInitialize)stackPanel10).BeginInit();
		children5.Add(stackPanel10);
		StackPanel stackPanel12 = (stackPanel4 = stackPanel11);
		context.PushParent(stackPanel4);
		StackPanel stackPanel13 = stackPanel4;
		stackPanel13.VerticalAlignment = VerticalAlignment.Center;
		Avalonia.Controls.Controls children6 = stackPanel13.Children;
		TextBlock textBlock9;
		TextBlock textBlock8 = (textBlock9 = new TextBlock());
		((ISupportInitialize)textBlock8).BeginInit();
		children6.Add(textBlock8);
		TextBlock textBlock10 = (textBlock4 = textBlock9);
		context.PushParent(textBlock4);
		TextBlock textBlock11 = textBlock4;
		textBlock11.Text = "LastActivityView";
		textBlock11.Foreground = new ImmutableSolidColorBrush(4293322470u);
		textBlock11.FontSize = 14.0;
		textBlock11.FontWeight = FontWeight.DemiBold;
		StaticResourceExtension staticResourceExtension2 = new StaticResourceExtension("FontStyle_2");
		context.ProvideTargetProperty = TextBlock.FontFamilyProperty;
		object? obj2 = staticResourceExtension2.ProvideValue(context);
		context.ProvideTargetProperty = null;
		CompiledAvaloniaXaml.XamlDynamicSetters._003C_003EXamlDynamicSetter_2(textBlock11, obj2);
		context.PopParent();
		((ISupportInitialize)textBlock10).EndInit();
		Avalonia.Controls.Controls children7 = stackPanel13.Children;
		TextBlock textBlock13;
		TextBlock textBlock12 = (textBlock13 = new TextBlock());
		((ISupportInitialize)textBlock12).BeginInit();
		children7.Add(textBlock12);
		textBlock13.Text = "View recent system activity";
		textBlock13.Foreground = new ImmutableSolidColorBrush(4286611584u);
		textBlock13.FontSize = 11.0;
		((ISupportInitialize)textBlock13).EndInit();
		context.PopParent();
		((ISupportInitialize)stackPanel12).EndInit();
		context.PopParent();
		((ISupportInitialize)stackPanel8).EndInit();
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
		listBoxItem9.Name = "JournalWindows_ListBoxItem";
		element = listBoxItem9;
		context.AvaloniaNameScope.Register("JournalWindows_ListBoxItem", element);
		listBoxItem9.Tag = "JournalWindows";
		StackPanel stackPanel15;
		StackPanel stackPanel14 = (stackPanel15 = new StackPanel());
		((ISupportInitialize)stackPanel14).BeginInit();
		listBoxItem9.Content = stackPanel14;
		StackPanel stackPanel16 = (stackPanel4 = stackPanel15);
		context.PushParent(stackPanel4);
		StackPanel stackPanel17 = stackPanel4;
		stackPanel17.Orientation = Orientation.Horizontal;
		stackPanel17.Spacing = 12.0;
		Avalonia.Controls.Controls children8 = stackPanel17.Children;
		Border border13;
		Border border12 = (border13 = new Border());
		((ISupportInitialize)border12).BeginInit();
		children8.Add(border12);
		border13.Width = 40.0;
		border13.Height = 40.0;
		border13.Background = new ImmutableSolidColorBrush(4294937600u);
		border13.CornerRadius = new CornerRadius(8.0, 8.0, 8.0, 8.0);
		TextBlock textBlock15;
		TextBlock textBlock14 = (textBlock15 = new TextBlock());
		((ISupportInitialize)textBlock14).BeginInit();
		border13.Child = textBlock14;
		textBlock15.Text = "\ud83d\udcd3";
		textBlock15.FontSize = 20.0;
		textBlock15.HorizontalAlignment = HorizontalAlignment.Center;
		textBlock15.VerticalAlignment = VerticalAlignment.Center;
		((ISupportInitialize)textBlock15).EndInit();
		((ISupportInitialize)border13).EndInit();
		Avalonia.Controls.Controls children9 = stackPanel17.Children;
		StackPanel stackPanel19;
		StackPanel stackPanel18 = (stackPanel19 = new StackPanel());
		((ISupportInitialize)stackPanel18).BeginInit();
		children9.Add(stackPanel18);
		StackPanel stackPanel20 = (stackPanel4 = stackPanel19);
		context.PushParent(stackPanel4);
		StackPanel stackPanel21 = stackPanel4;
		stackPanel21.VerticalAlignment = VerticalAlignment.Center;
		Avalonia.Controls.Controls children10 = stackPanel21.Children;
		TextBlock textBlock17;
		TextBlock textBlock16 = (textBlock17 = new TextBlock());
		((ISupportInitialize)textBlock16).BeginInit();
		children10.Add(textBlock16);
		TextBlock textBlock18 = (textBlock4 = textBlock17);
		context.PushParent(textBlock4);
		TextBlock textBlock19 = textBlock4;
		textBlock19.Text = "Journal Windows";
		textBlock19.Foreground = new ImmutableSolidColorBrush(4293322470u);
		textBlock19.FontSize = 14.0;
		textBlock19.FontWeight = FontWeight.DemiBold;
		StaticResourceExtension staticResourceExtension3 = new StaticResourceExtension("FontStyle_2");
		context.ProvideTargetProperty = TextBlock.FontFamilyProperty;
		object? obj3 = staticResourceExtension3.ProvideValue(context);
		context.ProvideTargetProperty = null;
		CompiledAvaloniaXaml.XamlDynamicSetters._003C_003EXamlDynamicSetter_2(textBlock19, obj3);
		context.PopParent();
		((ISupportInitialize)textBlock18).EndInit();
		Avalonia.Controls.Controls children11 = stackPanel21.Children;
		TextBlock textBlock21;
		TextBlock textBlock20 = (textBlock21 = new TextBlock());
		((ISupportInitialize)textBlock20).BeginInit();
		children11.Add(textBlock20);
		textBlock21.Text = "Windows event journal viewer";
		textBlock21.Foreground = new ImmutableSolidColorBrush(4286611584u);
		textBlock21.FontSize = 11.0;
		((ISupportInitialize)textBlock21).EndInit();
		context.PopParent();
		((ISupportInitialize)stackPanel20).EndInit();
		context.PopParent();
		((ISupportInitialize)stackPanel16).EndInit();
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
		listBoxItem13.Name = "SystemInformer_ListBoxItem";
		element = listBoxItem13;
		context.AvaloniaNameScope.Register("SystemInformer_ListBoxItem", element);
		listBoxItem13.Tag = "SystemInformer";
		StackPanel stackPanel23;
		StackPanel stackPanel22 = (stackPanel23 = new StackPanel());
		((ISupportInitialize)stackPanel22).BeginInit();
		listBoxItem13.Content = stackPanel22;
		StackPanel stackPanel24 = (stackPanel4 = stackPanel23);
		context.PushParent(stackPanel4);
		StackPanel stackPanel25 = stackPanel4;
		stackPanel25.Orientation = Orientation.Horizontal;
		stackPanel25.Spacing = 12.0;
		Avalonia.Controls.Controls children12 = stackPanel25.Children;
		Border border15;
		Border border14 = (border15 = new Border());
		((ISupportInitialize)border14).BeginInit();
		children12.Add(border14);
		border15.Width = 40.0;
		border15.Height = 40.0;
		border15.Background = new ImmutableSolidColorBrush(4294937600u);
		border15.CornerRadius = new CornerRadius(8.0, 8.0, 8.0, 8.0);
		TextBlock textBlock23;
		TextBlock textBlock22 = (textBlock23 = new TextBlock());
		((ISupportInitialize)textBlock22).BeginInit();
		border15.Child = textBlock22;
		textBlock23.Text = "⚙\ufe0f";
		textBlock23.FontSize = 20.0;
		textBlock23.HorizontalAlignment = HorizontalAlignment.Center;
		textBlock23.VerticalAlignment = VerticalAlignment.Center;
		((ISupportInitialize)textBlock23).EndInit();
		((ISupportInitialize)border15).EndInit();
		Avalonia.Controls.Controls children13 = stackPanel25.Children;
		StackPanel stackPanel27;
		StackPanel stackPanel26 = (stackPanel27 = new StackPanel());
		((ISupportInitialize)stackPanel26).BeginInit();
		children13.Add(stackPanel26);
		StackPanel stackPanel28 = (stackPanel4 = stackPanel27);
		context.PushParent(stackPanel4);
		StackPanel stackPanel29 = stackPanel4;
		stackPanel29.VerticalAlignment = VerticalAlignment.Center;
		Avalonia.Controls.Controls children14 = stackPanel29.Children;
		TextBlock textBlock25;
		TextBlock textBlock24 = (textBlock25 = new TextBlock());
		((ISupportInitialize)textBlock24).BeginInit();
		children14.Add(textBlock24);
		TextBlock textBlock26 = (textBlock4 = textBlock25);
		context.PushParent(textBlock4);
		TextBlock textBlock27 = textBlock4;
		textBlock27.Text = "System Informer";
		textBlock27.Foreground = new ImmutableSolidColorBrush(4293322470u);
		textBlock27.FontSize = 14.0;
		textBlock27.FontWeight = FontWeight.DemiBold;
		StaticResourceExtension staticResourceExtension4 = new StaticResourceExtension("FontStyle_2");
		context.ProvideTargetProperty = TextBlock.FontFamilyProperty;
		object? obj4 = staticResourceExtension4.ProvideValue(context);
		context.ProvideTargetProperty = null;
		CompiledAvaloniaXaml.XamlDynamicSetters._003C_003EXamlDynamicSetter_2(textBlock27, obj4);
		context.PopParent();
		((ISupportInitialize)textBlock26).EndInit();
		Avalonia.Controls.Controls children15 = stackPanel29.Children;
		TextBlock textBlock29;
		TextBlock textBlock28 = (textBlock29 = new TextBlock());
		((ISupportInitialize)textBlock28).BeginInit();
		children15.Add(textBlock28);
		textBlock29.Text = "Advanced system monitor";
		textBlock29.Foreground = new ImmutableSolidColorBrush(4286611584u);
		textBlock29.FontSize = 11.0;
		((ISupportInitialize)textBlock29).EndInit();
		context.PopParent();
		((ISupportInitialize)stackPanel28).EndInit();
		context.PopParent();
		((ISupportInitialize)stackPanel24).EndInit();
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
		listBoxItem17.Name = "RegistryAnalyzer_ListBoxItem";
		element = listBoxItem17;
		context.AvaloniaNameScope.Register("RegistryAnalyzer_ListBoxItem", element);
		listBoxItem17.Tag = "RegistryAnalyzer";
		StackPanel stackPanel31;
		StackPanel stackPanel30 = (stackPanel31 = new StackPanel());
		((ISupportInitialize)stackPanel30).BeginInit();
		listBoxItem17.Content = stackPanel30;
		StackPanel stackPanel32 = (stackPanel4 = stackPanel31);
		context.PushParent(stackPanel4);
		StackPanel stackPanel33 = stackPanel4;
		stackPanel33.Orientation = Orientation.Horizontal;
		stackPanel33.Spacing = 12.0;
		Avalonia.Controls.Controls children16 = stackPanel33.Children;
		Border border17;
		Border border16 = (border17 = new Border());
		((ISupportInitialize)border16).BeginInit();
		children16.Add(border16);
		border17.Width = 40.0;
		border17.Height = 40.0;
		border17.Background = new ImmutableSolidColorBrush(4294937600u);
		border17.CornerRadius = new CornerRadius(8.0, 8.0, 8.0, 8.0);
		TextBlock textBlock31;
		TextBlock textBlock30 = (textBlock31 = new TextBlock());
		((ISupportInitialize)textBlock30).BeginInit();
		border17.Child = textBlock30;
		textBlock31.Text = "\ud83d\uddc2\ufe0f";
		textBlock31.FontSize = 20.0;
		textBlock31.HorizontalAlignment = HorizontalAlignment.Center;
		textBlock31.VerticalAlignment = VerticalAlignment.Center;
		((ISupportInitialize)textBlock31).EndInit();
		((ISupportInitialize)border17).EndInit();
		Avalonia.Controls.Controls children17 = stackPanel33.Children;
		StackPanel stackPanel35;
		StackPanel stackPanel34 = (stackPanel35 = new StackPanel());
		((ISupportInitialize)stackPanel34).BeginInit();
		children17.Add(stackPanel34);
		StackPanel stackPanel36 = (stackPanel4 = stackPanel35);
		context.PushParent(stackPanel4);
		StackPanel stackPanel37 = stackPanel4;
		stackPanel37.VerticalAlignment = VerticalAlignment.Center;
		Avalonia.Controls.Controls children18 = stackPanel37.Children;
		TextBlock textBlock33;
		TextBlock textBlock32 = (textBlock33 = new TextBlock());
		((ISupportInitialize)textBlock32).BeginInit();
		children18.Add(textBlock32);
		TextBlock textBlock34 = (textBlock4 = textBlock33);
		context.PushParent(textBlock4);
		TextBlock textBlock35 = textBlock4;
		textBlock35.Text = "Shellbag";
		textBlock35.Foreground = new ImmutableSolidColorBrush(4293322470u);
		textBlock35.FontSize = 14.0;
		textBlock35.FontWeight = FontWeight.DemiBold;
		StaticResourceExtension staticResourceExtension5 = new StaticResourceExtension("FontStyle_2");
		context.ProvideTargetProperty = TextBlock.FontFamilyProperty;
		object? obj5 = staticResourceExtension5.ProvideValue(context);
		context.ProvideTargetProperty = null;
		CompiledAvaloniaXaml.XamlDynamicSetters._003C_003EXamlDynamicSetter_2(textBlock35, obj5);
		context.PopParent();
		((ISupportInitialize)textBlock34).EndInit();
		Avalonia.Controls.Controls children19 = stackPanel37.Children;
		TextBlock textBlock37;
		TextBlock textBlock36 = (textBlock37 = new TextBlock());
		((ISupportInitialize)textBlock36).BeginInit();
		children19.Add(textBlock36);
		textBlock37.Text = "Registry shellbag analyzer";
		textBlock37.Foreground = new ImmutableSolidColorBrush(4286611584u);
		textBlock37.FontSize = 11.0;
		((ISupportInitialize)textBlock37).EndInit();
		context.PopParent();
		((ISupportInitialize)stackPanel36).EndInit();
		context.PopParent();
		((ISupportInitialize)stackPanel32).EndInit();
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
		listBoxItem21.Name = "Everything_ListBoxItem";
		element = listBoxItem21;
		context.AvaloniaNameScope.Register("Everything_ListBoxItem", element);
		listBoxItem21.Tag = "Everything";
		StackPanel stackPanel39;
		StackPanel stackPanel38 = (stackPanel39 = new StackPanel());
		((ISupportInitialize)stackPanel38).BeginInit();
		listBoxItem21.Content = stackPanel38;
		StackPanel stackPanel40 = (stackPanel4 = stackPanel39);
		context.PushParent(stackPanel4);
		StackPanel stackPanel41 = stackPanel4;
		stackPanel41.Orientation = Orientation.Horizontal;
		stackPanel41.Spacing = 12.0;
		Avalonia.Controls.Controls children20 = stackPanel41.Children;
		Border border19;
		Border border18 = (border19 = new Border());
		((ISupportInitialize)border18).BeginInit();
		children20.Add(border18);
		border19.Width = 40.0;
		border19.Height = 40.0;
		border19.Background = new ImmutableSolidColorBrush(4294937600u);
		border19.CornerRadius = new CornerRadius(8.0, 8.0, 8.0, 8.0);
		TextBlock textBlock39;
		TextBlock textBlock38 = (textBlock39 = new TextBlock());
		((ISupportInitialize)textBlock38).BeginInit();
		border19.Child = textBlock38;
		textBlock39.Text = "\ud83d\udd0d";
		textBlock39.FontSize = 20.0;
		textBlock39.HorizontalAlignment = HorizontalAlignment.Center;
		textBlock39.VerticalAlignment = VerticalAlignment.Center;
		((ISupportInitialize)textBlock39).EndInit();
		((ISupportInitialize)border19).EndInit();
		Avalonia.Controls.Controls children21 = stackPanel41.Children;
		StackPanel stackPanel43;
		StackPanel stackPanel42 = (stackPanel43 = new StackPanel());
		((ISupportInitialize)stackPanel42).BeginInit();
		children21.Add(stackPanel42);
		StackPanel stackPanel44 = (stackPanel4 = stackPanel43);
		context.PushParent(stackPanel4);
		StackPanel stackPanel45 = stackPanel4;
		stackPanel45.VerticalAlignment = VerticalAlignment.Center;
		Avalonia.Controls.Controls children22 = stackPanel45.Children;
		TextBlock textBlock41;
		TextBlock textBlock40 = (textBlock41 = new TextBlock());
		((ISupportInitialize)textBlock40).BeginInit();
		children22.Add(textBlock40);
		TextBlock textBlock42 = (textBlock4 = textBlock41);
		context.PushParent(textBlock4);
		TextBlock textBlock43 = textBlock4;
		textBlock43.Text = "Everything";
		textBlock43.Foreground = new ImmutableSolidColorBrush(4293322470u);
		textBlock43.FontSize = 14.0;
		textBlock43.FontWeight = FontWeight.DemiBold;
		StaticResourceExtension staticResourceExtension6 = new StaticResourceExtension("FontStyle_2");
		context.ProvideTargetProperty = TextBlock.FontFamilyProperty;
		object? obj6 = staticResourceExtension6.ProvideValue(context);
		context.ProvideTargetProperty = null;
		CompiledAvaloniaXaml.XamlDynamicSetters._003C_003EXamlDynamicSetter_2(textBlock43, obj6);
		context.PopParent();
		((ISupportInitialize)textBlock42).EndInit();
		Avalonia.Controls.Controls children23 = stackPanel45.Children;
		TextBlock textBlock45;
		TextBlock textBlock44 = (textBlock45 = new TextBlock());
		((ISupportInitialize)textBlock44).BeginInit();
		children23.Add(textBlock44);
		textBlock45.Text = "Instant file search";
		textBlock45.Foreground = new ImmutableSolidColorBrush(4286611584u);
		textBlock45.FontSize = 11.0;
		((ISupportInitialize)textBlock45).EndInit();
		context.PopParent();
		((ISupportInitialize)stackPanel44).EndInit();
		context.PopParent();
		((ISupportInitialize)stackPanel40).EndInit();
		context.PopParent();
		((ISupportInitialize)listBoxItem20).EndInit();
		context.PopParent();
		((ISupportInitialize)listBox3).EndInit();
		Avalonia.Controls.Controls children24 = stackPanel5.Children;
		Border border21;
		Border border20 = (border21 = new Border());
		((ISupportInitialize)border20).BeginInit();
		children24.Add(border20);
		Border border22 = (border4 = border21);
		context.PushParent(border4);
		Border border23 = border4;
		border23.Background = new ImmutableSolidColorBrush(4281677109u);
		border23.CornerRadius = new CornerRadius(8.0, 8.0, 8.0, 8.0);
		border23.Padding = new Thickness(15.0, 12.0, 15.0, 12.0);
		border23.Margin = new Thickness(0.0, 4.0, 0.0, 4.0);
		border23.Cursor = new Cursor(StandardCursorType.Hand);
		border23.AddHandler(InputElement.PointerPressedEvent, context.RootObject.USBDeview_Click);
		StackPanel stackPanel47;
		StackPanel stackPanel46 = (stackPanel47 = new StackPanel());
		((ISupportInitialize)stackPanel46).BeginInit();
		border23.Child = stackPanel46;
		StackPanel stackPanel48 = (stackPanel4 = stackPanel47);
		context.PushParent(stackPanel4);
		StackPanel stackPanel49 = stackPanel4;
		stackPanel49.Orientation = Orientation.Horizontal;
		stackPanel49.Spacing = 12.0;
		Avalonia.Controls.Controls children25 = stackPanel49.Children;
		Border border25;
		Border border24 = (border25 = new Border());
		((ISupportInitialize)border24).BeginInit();
		children25.Add(border24);
		border25.Width = 40.0;
		border25.Height = 40.0;
		border25.Background = new ImmutableSolidColorBrush(4294937600u);
		border25.CornerRadius = new CornerRadius(8.0, 8.0, 8.0, 8.0);
		TextBlock textBlock47;
		TextBlock textBlock46 = (textBlock47 = new TextBlock());
		((ISupportInitialize)textBlock46).BeginInit();
		border25.Child = textBlock46;
		textBlock47.Text = "\ud83d\udd0c";
		textBlock47.FontSize = 20.0;
		textBlock47.HorizontalAlignment = HorizontalAlignment.Center;
		textBlock47.VerticalAlignment = VerticalAlignment.Center;
		((ISupportInitialize)textBlock47).EndInit();
		((ISupportInitialize)border25).EndInit();
		Avalonia.Controls.Controls children26 = stackPanel49.Children;
		StackPanel stackPanel51;
		StackPanel stackPanel50 = (stackPanel51 = new StackPanel());
		((ISupportInitialize)stackPanel50).BeginInit();
		children26.Add(stackPanel50);
		StackPanel stackPanel52 = (stackPanel4 = stackPanel51);
		context.PushParent(stackPanel4);
		StackPanel stackPanel53 = stackPanel4;
		stackPanel53.VerticalAlignment = VerticalAlignment.Center;
		Avalonia.Controls.Controls children27 = stackPanel53.Children;
		TextBlock textBlock49;
		TextBlock textBlock48 = (textBlock49 = new TextBlock());
		((ISupportInitialize)textBlock48).BeginInit();
		children27.Add(textBlock48);
		TextBlock textBlock50 = (textBlock4 = textBlock49);
		context.PushParent(textBlock4);
		TextBlock textBlock51 = textBlock4;
		textBlock51.Text = "USBDeview";
		textBlock51.Foreground = new ImmutableSolidColorBrush(4293322470u);
		textBlock51.FontSize = 14.0;
		textBlock51.FontWeight = FontWeight.DemiBold;
		StaticResourceExtension staticResourceExtension7 = new StaticResourceExtension("FontStyle_2");
		context.ProvideTargetProperty = TextBlock.FontFamilyProperty;
		object? obj7 = staticResourceExtension7.ProvideValue(context);
		context.ProvideTargetProperty = null;
		CompiledAvaloniaXaml.XamlDynamicSetters._003C_003EXamlDynamicSetter_2(textBlock51, obj7);
		context.PopParent();
		((ISupportInitialize)textBlock50).EndInit();
		Avalonia.Controls.Controls children28 = stackPanel53.Children;
		TextBlock textBlock53;
		TextBlock textBlock52 = (textBlock53 = new TextBlock());
		((ISupportInitialize)textBlock52).BeginInit();
		children28.Add(textBlock52);
		textBlock53.Text = "USB device history viewer";
		textBlock53.Foreground = new ImmutableSolidColorBrush(4286611584u);
		textBlock53.FontSize = 11.0;
		((ISupportInitialize)textBlock53).EndInit();
		context.PopParent();
		((ISupportInitialize)stackPanel52).EndInit();
		context.PopParent();
		((ISupportInitialize)stackPanel48).EndInit();
		context.PopParent();
		((ISupportInitialize)border22).EndInit();
		context.PopParent();
		((ISupportInitialize)stackPanel3).EndInit();
		context.PopParent();
		((ISupportInitialize)scrollViewer3).EndInit();
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

	private static void _0021XamlIlPopulateTrampoline(SubmenuOne P_0)
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
