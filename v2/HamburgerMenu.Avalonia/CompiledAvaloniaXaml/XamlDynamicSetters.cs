using System;
using System.Runtime.CompilerServices;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Presenters;
using Avalonia.Controls.Primitives;
using Avalonia.Data;
using Avalonia.Media;

namespace CompiledAvaloniaXaml;

[CompilerGenerated]
internal class XamlDynamicSetters
{
	public static void _003C_003EXamlDynamicSetter_1(Image P_0, object P_1)
	{
		if (P_1 is UnsetValueType)
		{
			P_0.SetValue(Image.SourceProperty, AvaloniaProperty.UnsetValue);
			return;
		}
		if (P_1 is IBinding)
		{
			IBinding binding = (IBinding)P_1;
			AvaloniaObjectExtensions.Bind(P_0, Image.SourceProperty, binding);
			return;
		}
		if (P_1 is IImage)
		{
			P_0.Source = (IImage?)P_1;
			return;
		}
		if (P_1 == null)
		{
			P_0.Source = (IImage?)P_1;
			return;
		}
		throw new InvalidCastException();
	}

	public static void _003C_003EXamlDynamicSetter_2(TextBlock P_0, object P_1)
	{
		if (P_1 is UnsetValueType)
		{
			P_0.SetValue(TextBlock.FontFamilyProperty, AvaloniaProperty.UnsetValue);
			return;
		}
		if (P_1 is IBinding)
		{
			IBinding binding = (IBinding)P_1;
			AvaloniaObjectExtensions.Bind(P_0, TextBlock.FontFamilyProperty, binding);
			return;
		}
		if (P_1 is FontFamily)
		{
			P_0.FontFamily = (FontFamily)P_1;
			return;
		}
		if (P_1 == null)
		{
			P_0.FontFamily = (FontFamily)P_1;
			return;
		}
		throw new InvalidCastException();
	}

	public static void _003C_003EXamlDynamicSetter_3(SelectingItemsControl P_0, Binding P_1)
	{
		if (P_1 != null)
		{
			IBinding binding = P_1;
			AvaloniaObjectExtensions.Bind(P_0, SelectingItemsControl.SelectedItemProperty, binding);
		}
		else
		{
			P_0.SelectedItem = P_1;
		}
	}

	public static void _003C_003EXamlDynamicSetter_4(ContentPresenter P_0, BindingPriority P_1, IBinding P_2)
	{
		if (P_2 != null)
		{
			IBinding binding = P_2;
			AvaloniaObjectExtensions.Bind(P_0, ContentPresenter.ContentProperty, binding);
		}
		else
		{
			object value = P_2;
			int priority = (int)P_1;
			P_0.SetValue(ContentPresenter.ContentProperty, value, (BindingPriority)priority);
		}
	}

	public static void _003C_003EXamlDynamicSetter_5(SolidColorBrush P_0, object P_1)
	{
		if (P_1 is UnsetValueType)
		{
			P_0.SetValue(SolidColorBrush.ColorProperty, AvaloniaProperty.UnsetValue);
			return;
		}
		if (P_1 is IBinding)
		{
			IBinding binding = (IBinding)P_1;
			AvaloniaObjectExtensions.Bind(P_0, SolidColorBrush.ColorProperty, binding);
			return;
		}
		if (P_1 is Color)
		{
			P_0.Color = (Color)P_1;
			return;
		}
		if (P_1 == null)
		{
			throw new NullReferenceException();
		}
		throw new InvalidCastException();
	}
}
