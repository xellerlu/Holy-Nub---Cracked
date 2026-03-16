using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.CompilerServices;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Presenters;
using Avalonia.Controls.Primitives;
using Avalonia.Data;
using Avalonia.Input;
using Avalonia.Layout;
using Avalonia.Markup.Xaml;
using Avalonia.Markup.Xaml.Converters;
using Avalonia.Markup.Xaml.MarkupExtensions;
using Avalonia.Markup.Xaml.Templates;
using Avalonia.Markup.Xaml.XamlIl.Runtime;
using Avalonia.Media;
using Avalonia.Media.Imaging;
using Avalonia.Media.Immutable;
using Avalonia.Styling;

namespace CompiledAvaloniaXaml;

[EditorBrowsable(EditorBrowsableState.Never)]
[CompilerGenerated]
public class _0021AvaloniaResources
{
	[CompilerGenerated]
	internal class NamespaceInfo_003A_002FApp_002Eaxaml : IAvaloniaXamlIlXmlNamespaceInfoProvider
	{
		private IReadOnlyDictionary<string, IReadOnlyList<AvaloniaXamlIlXmlNamespaceInfo>> _xmlNamespaces;

		public static IAvaloniaXamlIlXmlNamespaceInfoProvider Singleton;

		public virtual IReadOnlyDictionary<string, IReadOnlyList<AvaloniaXamlIlXmlNamespaceInfo>> XmlNamespaces
		{
			get
			{
				if (_xmlNamespaces == null)
				{
					_xmlNamespaces = CreateNamespaces();
				}
				return _xmlNamespaces;
			}
		}

		private static AvaloniaXamlIlXmlNamespaceInfo CreateNamespaceInfo(string P_0, string P_1)
		{
			return new AvaloniaXamlIlXmlNamespaceInfo
			{
				ClrNamespace = P_0,
				ClrAssemblyName = P_1
			};
		}

		private static IReadOnlyDictionary<string, IReadOnlyList<AvaloniaXamlIlXmlNamespaceInfo>> CreateNamespaces()
		{
			return new Dictionary<string, IReadOnlyList<AvaloniaXamlIlXmlNamespaceInfo>>(2)
			{
				{
					"",
					new AvaloniaXamlIlXmlNamespaceInfo[33]
					{
						CreateNamespaceInfo("Avalonia", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Animation", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Animation.Easings", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Controls", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Data", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Data.Converters", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Input", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Input.GestureRecognizers", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Input.TextInput", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Layout", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.LogicalTree", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Media", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Media.Imaging", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Media.Transformation", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Styling", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Automation", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Embedding", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Presenters", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Primitives", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Shapes", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Templates", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Notifications", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Chrome", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Documents", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Fonts.Inter", "Avalonia.Fonts.Inter"),
						CreateNamespaceInfo("Avalonia.Data", "Avalonia.Markup"),
						CreateNamespaceInfo("Avalonia.Markup.Data", "Avalonia.Markup"),
						CreateNamespaceInfo("Avalonia.Markup.Xaml.MarkupExtensions", "Avalonia.Markup.Xaml"),
						CreateNamespaceInfo("Avalonia.Markup.Xaml.Styling", "Avalonia.Markup.Xaml"),
						CreateNamespaceInfo("Avalonia.Markup.Xaml.Templates", "Avalonia.Markup.Xaml"),
						CreateNamespaceInfo("Avalonia.Themes.Fluent", "Avalonia.Themes.Fluent")
					}
				},
				{
					"x",
					new AvaloniaXamlIlXmlNamespaceInfo[0]
				}
			};
		}

		static NamespaceInfo_003A_002FApp_002Eaxaml()
		{
			Singleton = new NamespaceInfo_003A_002FApp_002Eaxaml();
		}
	}

	[CompilerGenerated]
	internal class NamespaceInfo_003A_002FControls_002FAppControl_002Eaxaml : IAvaloniaXamlIlXmlNamespaceInfoProvider
	{
		private IReadOnlyDictionary<string, IReadOnlyList<AvaloniaXamlIlXmlNamespaceInfo>> _xmlNamespaces;

		public static IAvaloniaXamlIlXmlNamespaceInfoProvider Singleton;

		public virtual IReadOnlyDictionary<string, IReadOnlyList<AvaloniaXamlIlXmlNamespaceInfo>> XmlNamespaces
		{
			get
			{
				if (_xmlNamespaces == null)
				{
					_xmlNamespaces = CreateNamespaces();
				}
				return _xmlNamespaces;
			}
		}

		private static AvaloniaXamlIlXmlNamespaceInfo CreateNamespaceInfo(string P_0, string P_1)
		{
			return new AvaloniaXamlIlXmlNamespaceInfo
			{
				ClrNamespace = P_0,
				ClrAssemblyName = P_1
			};
		}

		private static IReadOnlyDictionary<string, IReadOnlyList<AvaloniaXamlIlXmlNamespaceInfo>> CreateNamespaces()
		{
			return new Dictionary<string, IReadOnlyList<AvaloniaXamlIlXmlNamespaceInfo>>(4)
			{
				{
					"",
					new AvaloniaXamlIlXmlNamespaceInfo[33]
					{
						CreateNamespaceInfo("Avalonia", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Animation", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Animation.Easings", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Controls", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Data", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Data.Converters", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Input", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Input.GestureRecognizers", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Input.TextInput", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Layout", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.LogicalTree", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Media", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Media.Imaging", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Media.Transformation", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Styling", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Automation", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Embedding", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Presenters", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Primitives", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Shapes", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Templates", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Notifications", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Chrome", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Documents", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Fonts.Inter", "Avalonia.Fonts.Inter"),
						CreateNamespaceInfo("Avalonia.Data", "Avalonia.Markup"),
						CreateNamespaceInfo("Avalonia.Markup.Data", "Avalonia.Markup"),
						CreateNamespaceInfo("Avalonia.Markup.Xaml.MarkupExtensions", "Avalonia.Markup.Xaml"),
						CreateNamespaceInfo("Avalonia.Markup.Xaml.Styling", "Avalonia.Markup.Xaml"),
						CreateNamespaceInfo("Avalonia.Markup.Xaml.Templates", "Avalonia.Markup.Xaml"),
						CreateNamespaceInfo("Avalonia.Themes.Fluent", "Avalonia.Themes.Fluent")
					}
				},
				{
					"x",
					new AvaloniaXamlIlXmlNamespaceInfo[0]
				},
				{
					"d",
					new AvaloniaXamlIlXmlNamespaceInfo[0]
				},
				{
					"mc",
					new AvaloniaXamlIlXmlNamespaceInfo[0]
				}
			};
		}

		static NamespaceInfo_003A_002FControls_002FAppControl_002Eaxaml()
		{
			Singleton = new NamespaceInfo_003A_002FControls_002FAppControl_002Eaxaml();
		}
	}

	[CompilerGenerated]
	internal class NamespaceInfo_003A_002FControls_002FChannel_002Eaxaml : IAvaloniaXamlIlXmlNamespaceInfoProvider
	{
		private IReadOnlyDictionary<string, IReadOnlyList<AvaloniaXamlIlXmlNamespaceInfo>> _xmlNamespaces;

		public static IAvaloniaXamlIlXmlNamespaceInfoProvider Singleton;

		public virtual IReadOnlyDictionary<string, IReadOnlyList<AvaloniaXamlIlXmlNamespaceInfo>> XmlNamespaces
		{
			get
			{
				if (_xmlNamespaces == null)
				{
					_xmlNamespaces = CreateNamespaces();
				}
				return _xmlNamespaces;
			}
		}

		private static AvaloniaXamlIlXmlNamespaceInfo CreateNamespaceInfo(string P_0, string P_1)
		{
			return new AvaloniaXamlIlXmlNamespaceInfo
			{
				ClrNamespace = P_0,
				ClrAssemblyName = P_1
			};
		}

		private static IReadOnlyDictionary<string, IReadOnlyList<AvaloniaXamlIlXmlNamespaceInfo>> CreateNamespaces()
		{
			return new Dictionary<string, IReadOnlyList<AvaloniaXamlIlXmlNamespaceInfo>>(4)
			{
				{
					"",
					new AvaloniaXamlIlXmlNamespaceInfo[33]
					{
						CreateNamespaceInfo("Avalonia", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Animation", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Animation.Easings", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Controls", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Data", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Data.Converters", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Input", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Input.GestureRecognizers", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Input.TextInput", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Layout", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.LogicalTree", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Media", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Media.Imaging", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Media.Transformation", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Styling", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Automation", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Embedding", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Presenters", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Primitives", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Shapes", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Templates", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Notifications", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Chrome", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Documents", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Fonts.Inter", "Avalonia.Fonts.Inter"),
						CreateNamespaceInfo("Avalonia.Data", "Avalonia.Markup"),
						CreateNamespaceInfo("Avalonia.Markup.Data", "Avalonia.Markup"),
						CreateNamespaceInfo("Avalonia.Markup.Xaml.MarkupExtensions", "Avalonia.Markup.Xaml"),
						CreateNamespaceInfo("Avalonia.Markup.Xaml.Styling", "Avalonia.Markup.Xaml"),
						CreateNamespaceInfo("Avalonia.Markup.Xaml.Templates", "Avalonia.Markup.Xaml"),
						CreateNamespaceInfo("Avalonia.Themes.Fluent", "Avalonia.Themes.Fluent")
					}
				},
				{
					"x",
					new AvaloniaXamlIlXmlNamespaceInfo[0]
				},
				{
					"d",
					new AvaloniaXamlIlXmlNamespaceInfo[0]
				},
				{
					"mc",
					new AvaloniaXamlIlXmlNamespaceInfo[0]
				}
			};
		}

		static NamespaceInfo_003A_002FControls_002FChannel_002Eaxaml()
		{
			Singleton = new NamespaceInfo_003A_002FControls_002FChannel_002Eaxaml();
		}
	}

	[CompilerGenerated]
	internal class NamespaceInfo_003A_002FControls_002FMainMenu_002Eaxaml : IAvaloniaXamlIlXmlNamespaceInfoProvider
	{
		private IReadOnlyDictionary<string, IReadOnlyList<AvaloniaXamlIlXmlNamespaceInfo>> _xmlNamespaces;

		public static IAvaloniaXamlIlXmlNamespaceInfoProvider Singleton;

		public virtual IReadOnlyDictionary<string, IReadOnlyList<AvaloniaXamlIlXmlNamespaceInfo>> XmlNamespaces
		{
			get
			{
				if (_xmlNamespaces == null)
				{
					_xmlNamespaces = CreateNamespaces();
				}
				return _xmlNamespaces;
			}
		}

		private static AvaloniaXamlIlXmlNamespaceInfo CreateNamespaceInfo(string P_0, string P_1)
		{
			return new AvaloniaXamlIlXmlNamespaceInfo
			{
				ClrNamespace = P_0,
				ClrAssemblyName = P_1
			};
		}

		private static IReadOnlyDictionary<string, IReadOnlyList<AvaloniaXamlIlXmlNamespaceInfo>> CreateNamespaces()
		{
			return new Dictionary<string, IReadOnlyList<AvaloniaXamlIlXmlNamespaceInfo>>(5)
			{
				{
					"",
					new AvaloniaXamlIlXmlNamespaceInfo[33]
					{
						CreateNamespaceInfo("Avalonia", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Animation", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Animation.Easings", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Controls", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Data", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Data.Converters", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Input", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Input.GestureRecognizers", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Input.TextInput", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Layout", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.LogicalTree", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Media", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Media.Imaging", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Media.Transformation", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Styling", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Automation", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Embedding", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Presenters", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Primitives", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Shapes", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Templates", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Notifications", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Chrome", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Documents", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Fonts.Inter", "Avalonia.Fonts.Inter"),
						CreateNamespaceInfo("Avalonia.Data", "Avalonia.Markup"),
						CreateNamespaceInfo("Avalonia.Markup.Data", "Avalonia.Markup"),
						CreateNamespaceInfo("Avalonia.Markup.Xaml.MarkupExtensions", "Avalonia.Markup.Xaml"),
						CreateNamespaceInfo("Avalonia.Markup.Xaml.Styling", "Avalonia.Markup.Xaml"),
						CreateNamespaceInfo("Avalonia.Markup.Xaml.Templates", "Avalonia.Markup.Xaml"),
						CreateNamespaceInfo("Avalonia.Themes.Fluent", "Avalonia.Themes.Fluent")
					}
				},
				{
					"x",
					new AvaloniaXamlIlXmlNamespaceInfo[0]
				},
				{
					"d",
					new AvaloniaXamlIlXmlNamespaceInfo[0]
				},
				{
					"mc",
					new AvaloniaXamlIlXmlNamespaceInfo[0]
				},
				{
					"controls",
					new AvaloniaXamlIlXmlNamespaceInfo[1] { CreateNamespaceInfo("HamburgerMenu.Controls", null) }
				}
			};
		}

		static NamespaceInfo_003A_002FControls_002FMainMenu_002Eaxaml()
		{
			Singleton = new NamespaceInfo_003A_002FControls_002FMainMenu_002Eaxaml();
		}
	}

	[CompilerGenerated]
	internal class NamespaceInfo_003A_002FControls_002FSideBar_002Eaxaml : IAvaloniaXamlIlXmlNamespaceInfoProvider
	{
		private IReadOnlyDictionary<string, IReadOnlyList<AvaloniaXamlIlXmlNamespaceInfo>> _xmlNamespaces;

		public static IAvaloniaXamlIlXmlNamespaceInfoProvider Singleton;

		public virtual IReadOnlyDictionary<string, IReadOnlyList<AvaloniaXamlIlXmlNamespaceInfo>> XmlNamespaces
		{
			get
			{
				if (_xmlNamespaces == null)
				{
					_xmlNamespaces = CreateNamespaces();
				}
				return _xmlNamespaces;
			}
		}

		private static AvaloniaXamlIlXmlNamespaceInfo CreateNamespaceInfo(string P_0, string P_1)
		{
			return new AvaloniaXamlIlXmlNamespaceInfo
			{
				ClrNamespace = P_0,
				ClrAssemblyName = P_1
			};
		}

		private static IReadOnlyDictionary<string, IReadOnlyList<AvaloniaXamlIlXmlNamespaceInfo>> CreateNamespaces()
		{
			return new Dictionary<string, IReadOnlyList<AvaloniaXamlIlXmlNamespaceInfo>>(4)
			{
				{
					"",
					new AvaloniaXamlIlXmlNamespaceInfo[33]
					{
						CreateNamespaceInfo("Avalonia", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Animation", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Animation.Easings", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Controls", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Data", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Data.Converters", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Input", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Input.GestureRecognizers", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Input.TextInput", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Layout", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.LogicalTree", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Media", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Media.Imaging", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Media.Transformation", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Styling", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Automation", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Embedding", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Presenters", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Primitives", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Shapes", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Templates", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Notifications", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Chrome", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Documents", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Fonts.Inter", "Avalonia.Fonts.Inter"),
						CreateNamespaceInfo("Avalonia.Data", "Avalonia.Markup"),
						CreateNamespaceInfo("Avalonia.Markup.Data", "Avalonia.Markup"),
						CreateNamespaceInfo("Avalonia.Markup.Xaml.MarkupExtensions", "Avalonia.Markup.Xaml"),
						CreateNamespaceInfo("Avalonia.Markup.Xaml.Styling", "Avalonia.Markup.Xaml"),
						CreateNamespaceInfo("Avalonia.Markup.Xaml.Templates", "Avalonia.Markup.Xaml"),
						CreateNamespaceInfo("Avalonia.Themes.Fluent", "Avalonia.Themes.Fluent")
					}
				},
				{
					"x",
					new AvaloniaXamlIlXmlNamespaceInfo[0]
				},
				{
					"d",
					new AvaloniaXamlIlXmlNamespaceInfo[0]
				},
				{
					"mc",
					new AvaloniaXamlIlXmlNamespaceInfo[0]
				}
			};
		}

		static NamespaceInfo_003A_002FControls_002FSideBar_002Eaxaml()
		{
			Singleton = new NamespaceInfo_003A_002FControls_002FSideBar_002Eaxaml();
		}
	}

	[CompilerGenerated]
	internal class NamespaceInfo_003A_002FControls_002FSidePanel_002Eaxaml : IAvaloniaXamlIlXmlNamespaceInfoProvider
	{
		private IReadOnlyDictionary<string, IReadOnlyList<AvaloniaXamlIlXmlNamespaceInfo>> _xmlNamespaces;

		public static IAvaloniaXamlIlXmlNamespaceInfoProvider Singleton;

		public virtual IReadOnlyDictionary<string, IReadOnlyList<AvaloniaXamlIlXmlNamespaceInfo>> XmlNamespaces
		{
			get
			{
				if (_xmlNamespaces == null)
				{
					_xmlNamespaces = CreateNamespaces();
				}
				return _xmlNamespaces;
			}
		}

		private static AvaloniaXamlIlXmlNamespaceInfo CreateNamespaceInfo(string P_0, string P_1)
		{
			return new AvaloniaXamlIlXmlNamespaceInfo
			{
				ClrNamespace = P_0,
				ClrAssemblyName = P_1
			};
		}

		private static IReadOnlyDictionary<string, IReadOnlyList<AvaloniaXamlIlXmlNamespaceInfo>> CreateNamespaces()
		{
			return new Dictionary<string, IReadOnlyList<AvaloniaXamlIlXmlNamespaceInfo>>(4)
			{
				{
					"",
					new AvaloniaXamlIlXmlNamespaceInfo[33]
					{
						CreateNamespaceInfo("Avalonia", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Animation", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Animation.Easings", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Controls", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Data", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Data.Converters", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Input", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Input.GestureRecognizers", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Input.TextInput", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Layout", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.LogicalTree", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Media", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Media.Imaging", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Media.Transformation", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Styling", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Automation", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Embedding", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Presenters", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Primitives", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Shapes", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Templates", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Notifications", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Chrome", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Documents", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Fonts.Inter", "Avalonia.Fonts.Inter"),
						CreateNamespaceInfo("Avalonia.Data", "Avalonia.Markup"),
						CreateNamespaceInfo("Avalonia.Markup.Data", "Avalonia.Markup"),
						CreateNamespaceInfo("Avalonia.Markup.Xaml.MarkupExtensions", "Avalonia.Markup.Xaml"),
						CreateNamespaceInfo("Avalonia.Markup.Xaml.Styling", "Avalonia.Markup.Xaml"),
						CreateNamespaceInfo("Avalonia.Markup.Xaml.Templates", "Avalonia.Markup.Xaml"),
						CreateNamespaceInfo("Avalonia.Themes.Fluent", "Avalonia.Themes.Fluent")
					}
				},
				{
					"x",
					new AvaloniaXamlIlXmlNamespaceInfo[0]
				},
				{
					"d",
					new AvaloniaXamlIlXmlNamespaceInfo[0]
				},
				{
					"mc",
					new AvaloniaXamlIlXmlNamespaceInfo[0]
				}
			};
		}

		static NamespaceInfo_003A_002FControls_002FSidePanel_002Eaxaml()
		{
			Singleton = new NamespaceInfo_003A_002FControls_002FSidePanel_002Eaxaml();
		}
	}

	[CompilerGenerated]
	internal class NamespaceInfo_003A_002FControls_002FSubmenuAnalytics_002Eaxaml : IAvaloniaXamlIlXmlNamespaceInfoProvider
	{
		private IReadOnlyDictionary<string, IReadOnlyList<AvaloniaXamlIlXmlNamespaceInfo>> _xmlNamespaces;

		public static IAvaloniaXamlIlXmlNamespaceInfoProvider Singleton;

		public virtual IReadOnlyDictionary<string, IReadOnlyList<AvaloniaXamlIlXmlNamespaceInfo>> XmlNamespaces
		{
			get
			{
				if (_xmlNamespaces == null)
				{
					_xmlNamespaces = CreateNamespaces();
				}
				return _xmlNamespaces;
			}
		}

		private static AvaloniaXamlIlXmlNamespaceInfo CreateNamespaceInfo(string P_0, string P_1)
		{
			return new AvaloniaXamlIlXmlNamespaceInfo
			{
				ClrNamespace = P_0,
				ClrAssemblyName = P_1
			};
		}

		private static IReadOnlyDictionary<string, IReadOnlyList<AvaloniaXamlIlXmlNamespaceInfo>> CreateNamespaces()
		{
			return new Dictionary<string, IReadOnlyList<AvaloniaXamlIlXmlNamespaceInfo>>(4)
			{
				{
					"",
					new AvaloniaXamlIlXmlNamespaceInfo[33]
					{
						CreateNamespaceInfo("Avalonia", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Animation", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Animation.Easings", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Controls", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Data", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Data.Converters", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Input", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Input.GestureRecognizers", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Input.TextInput", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Layout", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.LogicalTree", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Media", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Media.Imaging", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Media.Transformation", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Styling", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Automation", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Embedding", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Presenters", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Primitives", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Shapes", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Templates", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Notifications", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Chrome", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Documents", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Fonts.Inter", "Avalonia.Fonts.Inter"),
						CreateNamespaceInfo("Avalonia.Data", "Avalonia.Markup"),
						CreateNamespaceInfo("Avalonia.Markup.Data", "Avalonia.Markup"),
						CreateNamespaceInfo("Avalonia.Markup.Xaml.MarkupExtensions", "Avalonia.Markup.Xaml"),
						CreateNamespaceInfo("Avalonia.Markup.Xaml.Styling", "Avalonia.Markup.Xaml"),
						CreateNamespaceInfo("Avalonia.Markup.Xaml.Templates", "Avalonia.Markup.Xaml"),
						CreateNamespaceInfo("Avalonia.Themes.Fluent", "Avalonia.Themes.Fluent")
					}
				},
				{
					"x",
					new AvaloniaXamlIlXmlNamespaceInfo[0]
				},
				{
					"d",
					new AvaloniaXamlIlXmlNamespaceInfo[0]
				},
				{
					"mc",
					new AvaloniaXamlIlXmlNamespaceInfo[0]
				}
			};
		}

		static NamespaceInfo_003A_002FControls_002FSubmenuAnalytics_002Eaxaml()
		{
			Singleton = new NamespaceInfo_003A_002FControls_002FSubmenuAnalytics_002Eaxaml();
		}
	}

	[CompilerGenerated]
	internal class NamespaceInfo_003A_002FControls_002FSubmenuCustomer_002Eaxaml : IAvaloniaXamlIlXmlNamespaceInfoProvider
	{
		private IReadOnlyDictionary<string, IReadOnlyList<AvaloniaXamlIlXmlNamespaceInfo>> _xmlNamespaces;

		public static IAvaloniaXamlIlXmlNamespaceInfoProvider Singleton;

		public virtual IReadOnlyDictionary<string, IReadOnlyList<AvaloniaXamlIlXmlNamespaceInfo>> XmlNamespaces
		{
			get
			{
				if (_xmlNamespaces == null)
				{
					_xmlNamespaces = CreateNamespaces();
				}
				return _xmlNamespaces;
			}
		}

		private static AvaloniaXamlIlXmlNamespaceInfo CreateNamespaceInfo(string P_0, string P_1)
		{
			return new AvaloniaXamlIlXmlNamespaceInfo
			{
				ClrNamespace = P_0,
				ClrAssemblyName = P_1
			};
		}

		private static IReadOnlyDictionary<string, IReadOnlyList<AvaloniaXamlIlXmlNamespaceInfo>> CreateNamespaces()
		{
			return new Dictionary<string, IReadOnlyList<AvaloniaXamlIlXmlNamespaceInfo>>(5)
			{
				{
					"",
					new AvaloniaXamlIlXmlNamespaceInfo[33]
					{
						CreateNamespaceInfo("Avalonia", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Animation", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Animation.Easings", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Controls", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Data", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Data.Converters", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Input", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Input.GestureRecognizers", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Input.TextInput", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Layout", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.LogicalTree", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Media", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Media.Imaging", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Media.Transformation", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Styling", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Automation", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Embedding", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Presenters", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Primitives", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Shapes", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Templates", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Notifications", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Chrome", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Documents", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Fonts.Inter", "Avalonia.Fonts.Inter"),
						CreateNamespaceInfo("Avalonia.Data", "Avalonia.Markup"),
						CreateNamespaceInfo("Avalonia.Markup.Data", "Avalonia.Markup"),
						CreateNamespaceInfo("Avalonia.Markup.Xaml.MarkupExtensions", "Avalonia.Markup.Xaml"),
						CreateNamespaceInfo("Avalonia.Markup.Xaml.Styling", "Avalonia.Markup.Xaml"),
						CreateNamespaceInfo("Avalonia.Markup.Xaml.Templates", "Avalonia.Markup.Xaml"),
						CreateNamespaceInfo("Avalonia.Themes.Fluent", "Avalonia.Themes.Fluent")
					}
				},
				{
					"x",
					new AvaloniaXamlIlXmlNamespaceInfo[0]
				},
				{
					"d",
					new AvaloniaXamlIlXmlNamespaceInfo[0]
				},
				{
					"mc",
					new AvaloniaXamlIlXmlNamespaceInfo[0]
				},
				{
					"models",
					new AvaloniaXamlIlXmlNamespaceInfo[1] { CreateNamespaceInfo("HamburgerMenu.Models", null) }
				}
			};
		}

		static NamespaceInfo_003A_002FControls_002FSubmenuCustomer_002Eaxaml()
		{
			Singleton = new NamespaceInfo_003A_002FControls_002FSubmenuCustomer_002Eaxaml();
		}
	}

	[CompilerGenerated]
	internal class NamespaceInfo_003A_002FControls_002FSubmenuOne_002Eaxaml : IAvaloniaXamlIlXmlNamespaceInfoProvider
	{
		private IReadOnlyDictionary<string, IReadOnlyList<AvaloniaXamlIlXmlNamespaceInfo>> _xmlNamespaces;

		public static IAvaloniaXamlIlXmlNamespaceInfoProvider Singleton;

		public virtual IReadOnlyDictionary<string, IReadOnlyList<AvaloniaXamlIlXmlNamespaceInfo>> XmlNamespaces
		{
			get
			{
				if (_xmlNamespaces == null)
				{
					_xmlNamespaces = CreateNamespaces();
				}
				return _xmlNamespaces;
			}
		}

		private static AvaloniaXamlIlXmlNamespaceInfo CreateNamespaceInfo(string P_0, string P_1)
		{
			return new AvaloniaXamlIlXmlNamespaceInfo
			{
				ClrNamespace = P_0,
				ClrAssemblyName = P_1
			};
		}

		private static IReadOnlyDictionary<string, IReadOnlyList<AvaloniaXamlIlXmlNamespaceInfo>> CreateNamespaces()
		{
			return new Dictionary<string, IReadOnlyList<AvaloniaXamlIlXmlNamespaceInfo>>(4)
			{
				{
					"",
					new AvaloniaXamlIlXmlNamespaceInfo[33]
					{
						CreateNamespaceInfo("Avalonia", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Animation", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Animation.Easings", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Controls", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Data", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Data.Converters", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Input", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Input.GestureRecognizers", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Input.TextInput", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Layout", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.LogicalTree", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Media", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Media.Imaging", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Media.Transformation", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Styling", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Automation", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Embedding", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Presenters", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Primitives", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Shapes", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Templates", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Notifications", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Chrome", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Documents", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Fonts.Inter", "Avalonia.Fonts.Inter"),
						CreateNamespaceInfo("Avalonia.Data", "Avalonia.Markup"),
						CreateNamespaceInfo("Avalonia.Markup.Data", "Avalonia.Markup"),
						CreateNamespaceInfo("Avalonia.Markup.Xaml.MarkupExtensions", "Avalonia.Markup.Xaml"),
						CreateNamespaceInfo("Avalonia.Markup.Xaml.Styling", "Avalonia.Markup.Xaml"),
						CreateNamespaceInfo("Avalonia.Markup.Xaml.Templates", "Avalonia.Markup.Xaml"),
						CreateNamespaceInfo("Avalonia.Themes.Fluent", "Avalonia.Themes.Fluent")
					}
				},
				{
					"x",
					new AvaloniaXamlIlXmlNamespaceInfo[0]
				},
				{
					"d",
					new AvaloniaXamlIlXmlNamespaceInfo[0]
				},
				{
					"mc",
					new AvaloniaXamlIlXmlNamespaceInfo[0]
				}
			};
		}

		static NamespaceInfo_003A_002FControls_002FSubmenuOne_002Eaxaml()
		{
			Singleton = new NamespaceInfo_003A_002FControls_002FSubmenuOne_002Eaxaml();
		}
	}

	[CompilerGenerated]
	internal class NamespaceInfo_003A_002FControls_002FSubmenuSettings_002Eaxaml : IAvaloniaXamlIlXmlNamespaceInfoProvider
	{
		private IReadOnlyDictionary<string, IReadOnlyList<AvaloniaXamlIlXmlNamespaceInfo>> _xmlNamespaces;

		public static IAvaloniaXamlIlXmlNamespaceInfoProvider Singleton;

		public virtual IReadOnlyDictionary<string, IReadOnlyList<AvaloniaXamlIlXmlNamespaceInfo>> XmlNamespaces
		{
			get
			{
				if (_xmlNamespaces == null)
				{
					_xmlNamespaces = CreateNamespaces();
				}
				return _xmlNamespaces;
			}
		}

		private static AvaloniaXamlIlXmlNamespaceInfo CreateNamespaceInfo(string P_0, string P_1)
		{
			return new AvaloniaXamlIlXmlNamespaceInfo
			{
				ClrNamespace = P_0,
				ClrAssemblyName = P_1
			};
		}

		private static IReadOnlyDictionary<string, IReadOnlyList<AvaloniaXamlIlXmlNamespaceInfo>> CreateNamespaces()
		{
			return new Dictionary<string, IReadOnlyList<AvaloniaXamlIlXmlNamespaceInfo>>(4)
			{
				{
					"",
					new AvaloniaXamlIlXmlNamespaceInfo[33]
					{
						CreateNamespaceInfo("Avalonia", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Animation", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Animation.Easings", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Controls", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Data", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Data.Converters", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Input", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Input.GestureRecognizers", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Input.TextInput", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Layout", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.LogicalTree", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Media", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Media.Imaging", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Media.Transformation", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Styling", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Automation", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Embedding", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Presenters", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Primitives", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Shapes", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Templates", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Notifications", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Chrome", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Documents", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Fonts.Inter", "Avalonia.Fonts.Inter"),
						CreateNamespaceInfo("Avalonia.Data", "Avalonia.Markup"),
						CreateNamespaceInfo("Avalonia.Markup.Data", "Avalonia.Markup"),
						CreateNamespaceInfo("Avalonia.Markup.Xaml.MarkupExtensions", "Avalonia.Markup.Xaml"),
						CreateNamespaceInfo("Avalonia.Markup.Xaml.Styling", "Avalonia.Markup.Xaml"),
						CreateNamespaceInfo("Avalonia.Markup.Xaml.Templates", "Avalonia.Markup.Xaml"),
						CreateNamespaceInfo("Avalonia.Themes.Fluent", "Avalonia.Themes.Fluent")
					}
				},
				{
					"x",
					new AvaloniaXamlIlXmlNamespaceInfo[0]
				},
				{
					"d",
					new AvaloniaXamlIlXmlNamespaceInfo[0]
				},
				{
					"mc",
					new AvaloniaXamlIlXmlNamespaceInfo[0]
				}
			};
		}

		static NamespaceInfo_003A_002FControls_002FSubmenuSettings_002Eaxaml()
		{
			Singleton = new NamespaceInfo_003A_002FControls_002FSubmenuSettings_002Eaxaml();
		}
	}

	[CompilerGenerated]
	internal class NamespaceInfo_003A_002FControls_002FSubmenuTwo_002Eaxaml : IAvaloniaXamlIlXmlNamespaceInfoProvider
	{
		private IReadOnlyDictionary<string, IReadOnlyList<AvaloniaXamlIlXmlNamespaceInfo>> _xmlNamespaces;

		public static IAvaloniaXamlIlXmlNamespaceInfoProvider Singleton;

		public virtual IReadOnlyDictionary<string, IReadOnlyList<AvaloniaXamlIlXmlNamespaceInfo>> XmlNamespaces
		{
			get
			{
				if (_xmlNamespaces == null)
				{
					_xmlNamespaces = CreateNamespaces();
				}
				return _xmlNamespaces;
			}
		}

		private static AvaloniaXamlIlXmlNamespaceInfo CreateNamespaceInfo(string P_0, string P_1)
		{
			return new AvaloniaXamlIlXmlNamespaceInfo
			{
				ClrNamespace = P_0,
				ClrAssemblyName = P_1
			};
		}

		private static IReadOnlyDictionary<string, IReadOnlyList<AvaloniaXamlIlXmlNamespaceInfo>> CreateNamespaces()
		{
			return new Dictionary<string, IReadOnlyList<AvaloniaXamlIlXmlNamespaceInfo>>(4)
			{
				{
					"",
					new AvaloniaXamlIlXmlNamespaceInfo[33]
					{
						CreateNamespaceInfo("Avalonia", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Animation", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Animation.Easings", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Controls", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Data", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Data.Converters", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Input", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Input.GestureRecognizers", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Input.TextInput", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Layout", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.LogicalTree", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Media", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Media.Imaging", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Media.Transformation", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Styling", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Automation", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Embedding", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Presenters", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Primitives", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Shapes", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Templates", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Notifications", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Chrome", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Documents", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Fonts.Inter", "Avalonia.Fonts.Inter"),
						CreateNamespaceInfo("Avalonia.Data", "Avalonia.Markup"),
						CreateNamespaceInfo("Avalonia.Markup.Data", "Avalonia.Markup"),
						CreateNamespaceInfo("Avalonia.Markup.Xaml.MarkupExtensions", "Avalonia.Markup.Xaml"),
						CreateNamespaceInfo("Avalonia.Markup.Xaml.Styling", "Avalonia.Markup.Xaml"),
						CreateNamespaceInfo("Avalonia.Markup.Xaml.Templates", "Avalonia.Markup.Xaml"),
						CreateNamespaceInfo("Avalonia.Themes.Fluent", "Avalonia.Themes.Fluent")
					}
				},
				{
					"x",
					new AvaloniaXamlIlXmlNamespaceInfo[0]
				},
				{
					"d",
					new AvaloniaXamlIlXmlNamespaceInfo[0]
				},
				{
					"mc",
					new AvaloniaXamlIlXmlNamespaceInfo[0]
				}
			};
		}

		static NamespaceInfo_003A_002FControls_002FSubmenuTwo_002Eaxaml()
		{
			Singleton = new NamespaceInfo_003A_002FControls_002FSubmenuTwo_002Eaxaml();
		}
	}

	[CompilerGenerated]
	internal class NamespaceInfo_003A_002FControls_002FTrackOne_002Eaxaml : IAvaloniaXamlIlXmlNamespaceInfoProvider
	{
		private IReadOnlyDictionary<string, IReadOnlyList<AvaloniaXamlIlXmlNamespaceInfo>> _xmlNamespaces;

		public static IAvaloniaXamlIlXmlNamespaceInfoProvider Singleton;

		public virtual IReadOnlyDictionary<string, IReadOnlyList<AvaloniaXamlIlXmlNamespaceInfo>> XmlNamespaces
		{
			get
			{
				if (_xmlNamespaces == null)
				{
					_xmlNamespaces = CreateNamespaces();
				}
				return _xmlNamespaces;
			}
		}

		private static AvaloniaXamlIlXmlNamespaceInfo CreateNamespaceInfo(string P_0, string P_1)
		{
			return new AvaloniaXamlIlXmlNamespaceInfo
			{
				ClrNamespace = P_0,
				ClrAssemblyName = P_1
			};
		}

		private static IReadOnlyDictionary<string, IReadOnlyList<AvaloniaXamlIlXmlNamespaceInfo>> CreateNamespaces()
		{
			return new Dictionary<string, IReadOnlyList<AvaloniaXamlIlXmlNamespaceInfo>>(4)
			{
				{
					"",
					new AvaloniaXamlIlXmlNamespaceInfo[33]
					{
						CreateNamespaceInfo("Avalonia", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Animation", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Animation.Easings", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Controls", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Data", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Data.Converters", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Input", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Input.GestureRecognizers", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Input.TextInput", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Layout", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.LogicalTree", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Media", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Media.Imaging", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Media.Transformation", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Styling", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Automation", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Embedding", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Presenters", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Primitives", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Shapes", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Templates", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Notifications", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Chrome", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Documents", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Fonts.Inter", "Avalonia.Fonts.Inter"),
						CreateNamespaceInfo("Avalonia.Data", "Avalonia.Markup"),
						CreateNamespaceInfo("Avalonia.Markup.Data", "Avalonia.Markup"),
						CreateNamespaceInfo("Avalonia.Markup.Xaml.MarkupExtensions", "Avalonia.Markup.Xaml"),
						CreateNamespaceInfo("Avalonia.Markup.Xaml.Styling", "Avalonia.Markup.Xaml"),
						CreateNamespaceInfo("Avalonia.Markup.Xaml.Templates", "Avalonia.Markup.Xaml"),
						CreateNamespaceInfo("Avalonia.Themes.Fluent", "Avalonia.Themes.Fluent")
					}
				},
				{
					"x",
					new AvaloniaXamlIlXmlNamespaceInfo[0]
				},
				{
					"d",
					new AvaloniaXamlIlXmlNamespaceInfo[0]
				},
				{
					"mc",
					new AvaloniaXamlIlXmlNamespaceInfo[0]
				}
			};
		}

		static NamespaceInfo_003A_002FControls_002FTrackOne_002Eaxaml()
		{
			Singleton = new NamespaceInfo_003A_002FControls_002FTrackOne_002Eaxaml();
		}
	}

	[CompilerGenerated]
	internal class NamespaceInfo_003A_002FControls_002FTrackTwo_002Eaxaml : IAvaloniaXamlIlXmlNamespaceInfoProvider
	{
		private IReadOnlyDictionary<string, IReadOnlyList<AvaloniaXamlIlXmlNamespaceInfo>> _xmlNamespaces;

		public static IAvaloniaXamlIlXmlNamespaceInfoProvider Singleton;

		public virtual IReadOnlyDictionary<string, IReadOnlyList<AvaloniaXamlIlXmlNamespaceInfo>> XmlNamespaces
		{
			get
			{
				if (_xmlNamespaces == null)
				{
					_xmlNamespaces = CreateNamespaces();
				}
				return _xmlNamespaces;
			}
		}

		private static AvaloniaXamlIlXmlNamespaceInfo CreateNamespaceInfo(string P_0, string P_1)
		{
			return new AvaloniaXamlIlXmlNamespaceInfo
			{
				ClrNamespace = P_0,
				ClrAssemblyName = P_1
			};
		}

		private static IReadOnlyDictionary<string, IReadOnlyList<AvaloniaXamlIlXmlNamespaceInfo>> CreateNamespaces()
		{
			return new Dictionary<string, IReadOnlyList<AvaloniaXamlIlXmlNamespaceInfo>>(4)
			{
				{
					"",
					new AvaloniaXamlIlXmlNamespaceInfo[33]
					{
						CreateNamespaceInfo("Avalonia", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Animation", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Animation.Easings", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Controls", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Data", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Data.Converters", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Input", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Input.GestureRecognizers", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Input.TextInput", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Layout", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.LogicalTree", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Media", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Media.Imaging", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Media.Transformation", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Styling", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Automation", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Embedding", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Presenters", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Primitives", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Shapes", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Templates", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Notifications", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Chrome", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Documents", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Fonts.Inter", "Avalonia.Fonts.Inter"),
						CreateNamespaceInfo("Avalonia.Data", "Avalonia.Markup"),
						CreateNamespaceInfo("Avalonia.Markup.Data", "Avalonia.Markup"),
						CreateNamespaceInfo("Avalonia.Markup.Xaml.MarkupExtensions", "Avalonia.Markup.Xaml"),
						CreateNamespaceInfo("Avalonia.Markup.Xaml.Styling", "Avalonia.Markup.Xaml"),
						CreateNamespaceInfo("Avalonia.Markup.Xaml.Templates", "Avalonia.Markup.Xaml"),
						CreateNamespaceInfo("Avalonia.Themes.Fluent", "Avalonia.Themes.Fluent")
					}
				},
				{
					"x",
					new AvaloniaXamlIlXmlNamespaceInfo[0]
				},
				{
					"d",
					new AvaloniaXamlIlXmlNamespaceInfo[0]
				},
				{
					"mc",
					new AvaloniaXamlIlXmlNamespaceInfo[0]
				}
			};
		}

		static NamespaceInfo_003A_002FControls_002FTrackTwo_002Eaxaml()
		{
			Singleton = new NamespaceInfo_003A_002FControls_002FTrackTwo_002Eaxaml();
		}
	}

	[CompilerGenerated]
	internal class NamespaceInfo_003A_002FMainWindow_002Eaxaml : IAvaloniaXamlIlXmlNamespaceInfoProvider
	{
		private IReadOnlyDictionary<string, IReadOnlyList<AvaloniaXamlIlXmlNamespaceInfo>> _xmlNamespaces;

		public static IAvaloniaXamlIlXmlNamespaceInfoProvider Singleton;

		public virtual IReadOnlyDictionary<string, IReadOnlyList<AvaloniaXamlIlXmlNamespaceInfo>> XmlNamespaces
		{
			get
			{
				if (_xmlNamespaces == null)
				{
					_xmlNamespaces = CreateNamespaces();
				}
				return _xmlNamespaces;
			}
		}

		private static AvaloniaXamlIlXmlNamespaceInfo CreateNamespaceInfo(string P_0, string P_1)
		{
			return new AvaloniaXamlIlXmlNamespaceInfo
			{
				ClrNamespace = P_0,
				ClrAssemblyName = P_1
			};
		}

		private static IReadOnlyDictionary<string, IReadOnlyList<AvaloniaXamlIlXmlNamespaceInfo>> CreateNamespaces()
		{
			return new Dictionary<string, IReadOnlyList<AvaloniaXamlIlXmlNamespaceInfo>>(5)
			{
				{
					"",
					new AvaloniaXamlIlXmlNamespaceInfo[33]
					{
						CreateNamespaceInfo("Avalonia", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Animation", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Animation.Easings", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Controls", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Data", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Data.Converters", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Input", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Input.GestureRecognizers", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Input.TextInput", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Layout", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.LogicalTree", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Media", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Media.Imaging", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Media.Transformation", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Styling", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Automation", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Embedding", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Presenters", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Primitives", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Shapes", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Templates", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Notifications", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Chrome", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Documents", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Fonts.Inter", "Avalonia.Fonts.Inter"),
						CreateNamespaceInfo("Avalonia.Data", "Avalonia.Markup"),
						CreateNamespaceInfo("Avalonia.Markup.Data", "Avalonia.Markup"),
						CreateNamespaceInfo("Avalonia.Markup.Xaml.MarkupExtensions", "Avalonia.Markup.Xaml"),
						CreateNamespaceInfo("Avalonia.Markup.Xaml.Styling", "Avalonia.Markup.Xaml"),
						CreateNamespaceInfo("Avalonia.Markup.Xaml.Templates", "Avalonia.Markup.Xaml"),
						CreateNamespaceInfo("Avalonia.Themes.Fluent", "Avalonia.Themes.Fluent")
					}
				},
				{
					"x",
					new AvaloniaXamlIlXmlNamespaceInfo[0]
				},
				{
					"d",
					new AvaloniaXamlIlXmlNamespaceInfo[0]
				},
				{
					"mc",
					new AvaloniaXamlIlXmlNamespaceInfo[0]
				},
				{
					"controls",
					new AvaloniaXamlIlXmlNamespaceInfo[1] { CreateNamespaceInfo("HamburgerMenu.Controls", null) }
				}
			};
		}

		static NamespaceInfo_003A_002FMainWindow_002Eaxaml()
		{
			Singleton = new NamespaceInfo_003A_002FMainWindow_002Eaxaml();
		}
	}

	[CompilerGenerated]
	internal class NamespaceInfo_003A_002FStyles_002FButtonStyles_002Eaxaml : IAvaloniaXamlIlXmlNamespaceInfoProvider
	{
		private IReadOnlyDictionary<string, IReadOnlyList<AvaloniaXamlIlXmlNamespaceInfo>> _xmlNamespaces;

		public static IAvaloniaXamlIlXmlNamespaceInfoProvider Singleton;

		public virtual IReadOnlyDictionary<string, IReadOnlyList<AvaloniaXamlIlXmlNamespaceInfo>> XmlNamespaces
		{
			get
			{
				if (_xmlNamespaces == null)
				{
					_xmlNamespaces = CreateNamespaces();
				}
				return _xmlNamespaces;
			}
		}

		private static AvaloniaXamlIlXmlNamespaceInfo CreateNamespaceInfo(string P_0, string P_1)
		{
			return new AvaloniaXamlIlXmlNamespaceInfo
			{
				ClrNamespace = P_0,
				ClrAssemblyName = P_1
			};
		}

		private static IReadOnlyDictionary<string, IReadOnlyList<AvaloniaXamlIlXmlNamespaceInfo>> CreateNamespaces()
		{
			return new Dictionary<string, IReadOnlyList<AvaloniaXamlIlXmlNamespaceInfo>>(2)
			{
				{
					"",
					new AvaloniaXamlIlXmlNamespaceInfo[33]
					{
						CreateNamespaceInfo("Avalonia", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Animation", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Animation.Easings", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Controls", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Data", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Data.Converters", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Input", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Input.GestureRecognizers", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Input.TextInput", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Layout", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.LogicalTree", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Media", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Media.Imaging", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Media.Transformation", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Styling", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Automation", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Embedding", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Presenters", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Primitives", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Shapes", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Templates", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Notifications", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Chrome", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Documents", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Fonts.Inter", "Avalonia.Fonts.Inter"),
						CreateNamespaceInfo("Avalonia.Data", "Avalonia.Markup"),
						CreateNamespaceInfo("Avalonia.Markup.Data", "Avalonia.Markup"),
						CreateNamespaceInfo("Avalonia.Markup.Xaml.MarkupExtensions", "Avalonia.Markup.Xaml"),
						CreateNamespaceInfo("Avalonia.Markup.Xaml.Styling", "Avalonia.Markup.Xaml"),
						CreateNamespaceInfo("Avalonia.Markup.Xaml.Templates", "Avalonia.Markup.Xaml"),
						CreateNamespaceInfo("Avalonia.Themes.Fluent", "Avalonia.Themes.Fluent")
					}
				},
				{
					"x",
					new AvaloniaXamlIlXmlNamespaceInfo[0]
				}
			};
		}

		static NamespaceInfo_003A_002FStyles_002FButtonStyles_002Eaxaml()
		{
			Singleton = new NamespaceInfo_003A_002FStyles_002FButtonStyles_002Eaxaml();
		}
	}

	[CompilerGenerated]
	private class XamlClosure_5
	{
		public static object Build_1(IServiceProvider P_0)
		{
			CompiledAvaloniaXaml.XamlIlContext.Context<Styles> context = CreateContext(P_0);
			context.IntermediateRoot = new Border();
			object obj = context.IntermediateRoot;
			((ISupportInitialize)obj).BeginInit();
			((StyledElement)obj).Name = "PART_Border";
			object element = obj;
			context.AvaloniaNameScope.Register("PART_Border", element);
			AvaloniaObjectExtensions.Bind((AvaloniaObject)obj, Border.BackgroundProperty, new TemplateBinding(TemplatedControl.BackgroundProperty).ProvideValue());
			((AvaloniaObject)obj).SetValue(Border.CornerRadiusProperty, new CornerRadius(7.0, 7.0, 7.0, 7.0), BindingPriority.Template);
			AvaloniaObjectExtensions.Bind((AvaloniaObject)obj, Decorator.PaddingProperty, new TemplateBinding(TemplatedControl.PaddingProperty).ProvideValue());
			ContentPresenter contentPresenter2;
			ContentPresenter contentPresenter = (contentPresenter2 = new ContentPresenter());
			((ISupportInitialize)contentPresenter).BeginInit();
			((Decorator)obj).Child = contentPresenter;
			CompiledAvaloniaXaml.XamlDynamicSetters._003C_003EXamlDynamicSetter_4(contentPresenter2, BindingPriority.Template, new TemplateBinding(ContentControl.ContentProperty).ProvideValue());
			contentPresenter2.SetValue(Layoutable.HorizontalAlignmentProperty, HorizontalAlignment.Center, BindingPriority.Template);
			contentPresenter2.SetValue(Layoutable.VerticalAlignmentProperty, VerticalAlignment.Center, BindingPriority.Template);
			((ISupportInitialize)contentPresenter2).EndInit();
			((ISupportInitialize)obj).EndInit();
			return obj;
		}

		public static CompiledAvaloniaXaml.XamlIlContext.Context<Styles> CreateContext(IServiceProvider P_0)
		{
			CompiledAvaloniaXaml.XamlIlContext.Context<Styles> context = new CompiledAvaloniaXaml.XamlIlContext.Context<Styles>(P_0, new object[1] { NamespaceInfo_003A_002FStyles_002FButtonStyles_002Eaxaml.Singleton }, "avares://HamburgerMenu.Avalonia/Styles/ButtonStyles.axaml");
			if (P_0 != null)
			{
				object service = P_0.GetService(typeof(IRootObjectProvider));
				if (service != null)
				{
					service = ((IRootObjectProvider)service).RootObject;
					context.RootObject = (Styles)service;
				}
			}
			return context;
		}

		public static object Build_2(IServiceProvider P_0)
		{
			CompiledAvaloniaXaml.XamlIlContext.Context<Styles> context = CreateContext(P_0);
			context.IntermediateRoot = new Border();
			object obj = context.IntermediateRoot;
			((ISupportInitialize)obj).BeginInit();
			((StyledElement)obj).Name = "PART_Border";
			object element = obj;
			context.AvaloniaNameScope.Register("PART_Border", element);
			AvaloniaObjectExtensions.Bind((AvaloniaObject)obj, Border.BackgroundProperty, new TemplateBinding(TemplatedControl.BackgroundProperty).ProvideValue());
			((AvaloniaObject)obj).SetValue(Border.CornerRadiusProperty, new CornerRadius(7.0, 7.0, 7.0, 7.0), BindingPriority.Template);
			ContentPresenter contentPresenter2;
			ContentPresenter contentPresenter = (contentPresenter2 = new ContentPresenter());
			((ISupportInitialize)contentPresenter).BeginInit();
			((Decorator)obj).Child = contentPresenter;
			CompiledAvaloniaXaml.XamlDynamicSetters._003C_003EXamlDynamicSetter_4(contentPresenter2, BindingPriority.Template, new TemplateBinding(ContentControl.ContentProperty).ProvideValue());
			contentPresenter2.SetValue(Layoutable.HorizontalAlignmentProperty, HorizontalAlignment.Center, BindingPriority.Template);
			contentPresenter2.SetValue(Layoutable.VerticalAlignmentProperty, VerticalAlignment.Center, BindingPriority.Template);
			((ISupportInitialize)contentPresenter2).EndInit();
			((ISupportInitialize)obj).EndInit();
			return obj;
		}

		public static object Build_3(IServiceProvider P_0)
		{
			CompiledAvaloniaXaml.XamlIlContext.Context<Styles> context = CreateContext(P_0);
			context.IntermediateRoot = new Border();
			object obj = context.IntermediateRoot;
			((ISupportInitialize)obj).BeginInit();
			((StyledElement)obj).Name = "PART_Border";
			object element = obj;
			context.AvaloniaNameScope.Register("PART_Border", element);
			AvaloniaObjectExtensions.Bind((AvaloniaObject)obj, Border.BackgroundProperty, new TemplateBinding(TemplatedControl.BackgroundProperty).ProvideValue());
			((AvaloniaObject)obj).SetValue(Border.CornerRadiusProperty, new CornerRadius(5.0, 5.0, 5.0, 5.0), BindingPriority.Template);
			AvaloniaObjectExtensions.Bind((AvaloniaObject)obj, Decorator.PaddingProperty, new TemplateBinding(TemplatedControl.PaddingProperty).ProvideValue());
			ContentPresenter contentPresenter2;
			ContentPresenter contentPresenter = (contentPresenter2 = new ContentPresenter());
			((ISupportInitialize)contentPresenter).BeginInit();
			((Decorator)obj).Child = contentPresenter;
			CompiledAvaloniaXaml.XamlDynamicSetters._003C_003EXamlDynamicSetter_4(contentPresenter2, BindingPriority.Template, new TemplateBinding(ContentControl.ContentProperty).ProvideValue());
			((ISupportInitialize)contentPresenter2).EndInit();
			((ISupportInitialize)obj).EndInit();
			return obj;
		}
	}

	[CompilerGenerated]
	internal class NamespaceInfo_003A_002FStyles_002FColors_002Eaxaml : IAvaloniaXamlIlXmlNamespaceInfoProvider
	{
		private IReadOnlyDictionary<string, IReadOnlyList<AvaloniaXamlIlXmlNamespaceInfo>> _xmlNamespaces;

		public static IAvaloniaXamlIlXmlNamespaceInfoProvider Singleton;

		public virtual IReadOnlyDictionary<string, IReadOnlyList<AvaloniaXamlIlXmlNamespaceInfo>> XmlNamespaces
		{
			get
			{
				if (_xmlNamespaces == null)
				{
					_xmlNamespaces = CreateNamespaces();
				}
				return _xmlNamespaces;
			}
		}

		private static AvaloniaXamlIlXmlNamespaceInfo CreateNamespaceInfo(string P_0, string P_1)
		{
			return new AvaloniaXamlIlXmlNamespaceInfo
			{
				ClrNamespace = P_0,
				ClrAssemblyName = P_1
			};
		}

		private static IReadOnlyDictionary<string, IReadOnlyList<AvaloniaXamlIlXmlNamespaceInfo>> CreateNamespaces()
		{
			return new Dictionary<string, IReadOnlyList<AvaloniaXamlIlXmlNamespaceInfo>>(2)
			{
				{
					"",
					new AvaloniaXamlIlXmlNamespaceInfo[33]
					{
						CreateNamespaceInfo("Avalonia", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Animation", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Animation.Easings", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Controls", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Data", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Data.Converters", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Input", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Input.GestureRecognizers", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Input.TextInput", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Layout", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.LogicalTree", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Media", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Media.Imaging", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Media.Transformation", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Styling", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Automation", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Embedding", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Presenters", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Primitives", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Shapes", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Templates", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Notifications", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Chrome", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Documents", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Fonts.Inter", "Avalonia.Fonts.Inter"),
						CreateNamespaceInfo("Avalonia.Data", "Avalonia.Markup"),
						CreateNamespaceInfo("Avalonia.Markup.Data", "Avalonia.Markup"),
						CreateNamespaceInfo("Avalonia.Markup.Xaml.MarkupExtensions", "Avalonia.Markup.Xaml"),
						CreateNamespaceInfo("Avalonia.Markup.Xaml.Styling", "Avalonia.Markup.Xaml"),
						CreateNamespaceInfo("Avalonia.Markup.Xaml.Templates", "Avalonia.Markup.Xaml"),
						CreateNamespaceInfo("Avalonia.Themes.Fluent", "Avalonia.Themes.Fluent")
					}
				},
				{
					"x",
					new AvaloniaXamlIlXmlNamespaceInfo[0]
				}
			};
		}

		static NamespaceInfo_003A_002FStyles_002FColors_002Eaxaml()
		{
			Singleton = new NamespaceInfo_003A_002FStyles_002FColors_002Eaxaml();
		}
	}

	[CompilerGenerated]
	private class XamlClosure_6
	{
		public static object Build_1(IServiceProvider P_0)
		{
			CompiledAvaloniaXaml.XamlIlContext.Context<ResourceDictionary> context = CreateContext(P_0);
			SolidColorBrush solidColorBrush;
			SolidColorBrush result = (solidColorBrush = new SolidColorBrush());
			context.PushParent(solidColorBrush);
			StaticResourceExtension staticResourceExtension = new StaticResourceExtension("BackgroundColor");
			context.ProvideTargetProperty = SolidColorBrush.ColorProperty;
			object? obj = staticResourceExtension.ProvideValue(context);
			context.ProvideTargetProperty = null;
			CompiledAvaloniaXaml.XamlDynamicSetters._003C_003EXamlDynamicSetter_5(solidColorBrush, obj);
			context.PopParent();
			return result;
		}

		public static CompiledAvaloniaXaml.XamlIlContext.Context<ResourceDictionary> CreateContext(IServiceProvider P_0)
		{
			CompiledAvaloniaXaml.XamlIlContext.Context<ResourceDictionary> context = new CompiledAvaloniaXaml.XamlIlContext.Context<ResourceDictionary>(P_0, new object[1] { NamespaceInfo_003A_002FStyles_002FColors_002Eaxaml.Singleton }, "avares://HamburgerMenu.Avalonia/Styles/Colors.axaml");
			if (P_0 != null)
			{
				object service = P_0.GetService(typeof(IRootObjectProvider));
				if (service != null)
				{
					service = ((IRootObjectProvider)service).RootObject;
					context.RootObject = (ResourceDictionary)service;
				}
			}
			return context;
		}

		public static object Build_2(IServiceProvider P_0)
		{
			CompiledAvaloniaXaml.XamlIlContext.Context<ResourceDictionary> context = CreateContext(P_0);
			SolidColorBrush solidColorBrush;
			SolidColorBrush result = (solidColorBrush = new SolidColorBrush());
			context.PushParent(solidColorBrush);
			StaticResourceExtension staticResourceExtension = new StaticResourceExtension("PanelColor");
			context.ProvideTargetProperty = SolidColorBrush.ColorProperty;
			object? obj = staticResourceExtension.ProvideValue(context);
			context.ProvideTargetProperty = null;
			CompiledAvaloniaXaml.XamlDynamicSetters._003C_003EXamlDynamicSetter_5(solidColorBrush, obj);
			context.PopParent();
			return result;
		}

		public static object Build_3(IServiceProvider P_0)
		{
			CompiledAvaloniaXaml.XamlIlContext.Context<ResourceDictionary> context = CreateContext(P_0);
			SolidColorBrush solidColorBrush;
			SolidColorBrush result = (solidColorBrush = new SolidColorBrush());
			context.PushParent(solidColorBrush);
			StaticResourceExtension staticResourceExtension = new StaticResourceExtension("PanelDarkColor");
			context.ProvideTargetProperty = SolidColorBrush.ColorProperty;
			object? obj = staticResourceExtension.ProvideValue(context);
			context.ProvideTargetProperty = null;
			CompiledAvaloniaXaml.XamlDynamicSetters._003C_003EXamlDynamicSetter_5(solidColorBrush, obj);
			context.PopParent();
			return result;
		}

		public static object Build_4(IServiceProvider P_0)
		{
			CompiledAvaloniaXaml.XamlIlContext.Context<ResourceDictionary> context = CreateContext(P_0);
			SolidColorBrush solidColorBrush;
			SolidColorBrush result = (solidColorBrush = new SolidColorBrush());
			context.PushParent(solidColorBrush);
			StaticResourceExtension staticResourceExtension = new StaticResourceExtension("AccentColor");
			context.ProvideTargetProperty = SolidColorBrush.ColorProperty;
			object? obj = staticResourceExtension.ProvideValue(context);
			context.ProvideTargetProperty = null;
			CompiledAvaloniaXaml.XamlDynamicSetters._003C_003EXamlDynamicSetter_5(solidColorBrush, obj);
			context.PopParent();
			return result;
		}

		public static object Build_5(IServiceProvider P_0)
		{
			CompiledAvaloniaXaml.XamlIlContext.Context<ResourceDictionary> context = CreateContext(P_0);
			SolidColorBrush solidColorBrush;
			SolidColorBrush result = (solidColorBrush = new SolidColorBrush());
			context.PushParent(solidColorBrush);
			StaticResourceExtension staticResourceExtension = new StaticResourceExtension("TextColor");
			context.ProvideTargetProperty = SolidColorBrush.ColorProperty;
			object? obj = staticResourceExtension.ProvideValue(context);
			context.ProvideTargetProperty = null;
			CompiledAvaloniaXaml.XamlDynamicSetters._003C_003EXamlDynamicSetter_5(solidColorBrush, obj);
			context.PopParent();
			return result;
		}

		public static object Build_6(IServiceProvider P_0)
		{
			CompiledAvaloniaXaml.XamlIlContext.Context<ResourceDictionary> context = CreateContext(P_0);
			SolidColorBrush solidColorBrush;
			SolidColorBrush result = (solidColorBrush = new SolidColorBrush());
			context.PushParent(solidColorBrush);
			StaticResourceExtension staticResourceExtension = new StaticResourceExtension("HoverColor");
			context.ProvideTargetProperty = SolidColorBrush.ColorProperty;
			object? obj = staticResourceExtension.ProvideValue(context);
			context.ProvideTargetProperty = null;
			CompiledAvaloniaXaml.XamlDynamicSetters._003C_003EXamlDynamicSetter_5(solidColorBrush, obj);
			context.PopParent();
			return result;
		}

		public static object Build_7(IServiceProvider P_0)
		{
			CompiledAvaloniaXaml.XamlIlContext.Context<ResourceDictionary> context = CreateContext(P_0);
			SolidColorBrush solidColorBrush;
			SolidColorBrush result = (solidColorBrush = new SolidColorBrush());
			context.PushParent(solidColorBrush);
			StaticResourceExtension staticResourceExtension = new StaticResourceExtension("PressedColor");
			context.ProvideTargetProperty = SolidColorBrush.ColorProperty;
			object? obj = staticResourceExtension.ProvideValue(context);
			context.ProvideTargetProperty = null;
			CompiledAvaloniaXaml.XamlDynamicSetters._003C_003EXamlDynamicSetter_5(solidColorBrush, obj);
			context.PopParent();
			return result;
		}
	}

	[CompilerGenerated]
	internal class NamespaceInfo_003A_002FStyles_002FFontResources_002Eaxaml : IAvaloniaXamlIlXmlNamespaceInfoProvider
	{
		private IReadOnlyDictionary<string, IReadOnlyList<AvaloniaXamlIlXmlNamespaceInfo>> _xmlNamespaces;

		public static IAvaloniaXamlIlXmlNamespaceInfoProvider Singleton;

		public virtual IReadOnlyDictionary<string, IReadOnlyList<AvaloniaXamlIlXmlNamespaceInfo>> XmlNamespaces
		{
			get
			{
				if (_xmlNamespaces == null)
				{
					_xmlNamespaces = CreateNamespaces();
				}
				return _xmlNamespaces;
			}
		}

		private static AvaloniaXamlIlXmlNamespaceInfo CreateNamespaceInfo(string P_0, string P_1)
		{
			return new AvaloniaXamlIlXmlNamespaceInfo
			{
				ClrNamespace = P_0,
				ClrAssemblyName = P_1
			};
		}

		private static IReadOnlyDictionary<string, IReadOnlyList<AvaloniaXamlIlXmlNamespaceInfo>> CreateNamespaces()
		{
			return new Dictionary<string, IReadOnlyList<AvaloniaXamlIlXmlNamespaceInfo>>(2)
			{
				{
					"",
					new AvaloniaXamlIlXmlNamespaceInfo[33]
					{
						CreateNamespaceInfo("Avalonia", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Animation", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Animation.Easings", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Controls", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Data", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Data.Converters", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Input", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Input.GestureRecognizers", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Input.TextInput", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Layout", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.LogicalTree", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Media", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Media.Imaging", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Media.Transformation", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Styling", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Automation", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Embedding", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Presenters", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Primitives", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Shapes", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Templates", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Notifications", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Chrome", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Documents", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Fonts.Inter", "Avalonia.Fonts.Inter"),
						CreateNamespaceInfo("Avalonia.Data", "Avalonia.Markup"),
						CreateNamespaceInfo("Avalonia.Markup.Data", "Avalonia.Markup"),
						CreateNamespaceInfo("Avalonia.Markup.Xaml.MarkupExtensions", "Avalonia.Markup.Xaml"),
						CreateNamespaceInfo("Avalonia.Markup.Xaml.Styling", "Avalonia.Markup.Xaml"),
						CreateNamespaceInfo("Avalonia.Markup.Xaml.Templates", "Avalonia.Markup.Xaml"),
						CreateNamespaceInfo("Avalonia.Themes.Fluent", "Avalonia.Themes.Fluent")
					}
				},
				{
					"x",
					new AvaloniaXamlIlXmlNamespaceInfo[0]
				}
			};
		}

		static NamespaceInfo_003A_002FStyles_002FFontResources_002Eaxaml()
		{
			Singleton = new NamespaceInfo_003A_002FStyles_002FFontResources_002Eaxaml();
		}
	}

	[CompilerGenerated]
	private class XamlClosure_7
	{
		public static object Build_1(IServiceProvider P_0)
		{
			CompiledAvaloniaXaml.XamlIlContext.Context<ResourceDictionary> context = CreateContext(P_0);
			return new FontFamily(((IUriContext)context).BaseUri, "avares://HamburgerMenu.Avalonia/Fonts#Saira SemiBold");
		}

		public static CompiledAvaloniaXaml.XamlIlContext.Context<ResourceDictionary> CreateContext(IServiceProvider P_0)
		{
			CompiledAvaloniaXaml.XamlIlContext.Context<ResourceDictionary> context = new CompiledAvaloniaXaml.XamlIlContext.Context<ResourceDictionary>(P_0, new object[1] { NamespaceInfo_003A_002FStyles_002FFontResources_002Eaxaml.Singleton }, "avares://HamburgerMenu.Avalonia/Styles/FontResources.axaml");
			if (P_0 != null)
			{
				object service = P_0.GetService(typeof(IRootObjectProvider));
				if (service != null)
				{
					service = ((IRootObjectProvider)service).RootObject;
					context.RootObject = (ResourceDictionary)service;
				}
			}
			return context;
		}

		public static object Build_2(IServiceProvider P_0)
		{
			CompiledAvaloniaXaml.XamlIlContext.Context<ResourceDictionary> context = CreateContext(P_0);
			return new FontFamily(((IUriContext)context).BaseUri, "avares://HamburgerMenu.Avalonia/Fonts#Open Sans SemiBold");
		}
	}

	[CompilerGenerated]
	internal class NamespaceInfo_003A_002FStyles_002FImageResources_002Eaxaml : IAvaloniaXamlIlXmlNamespaceInfoProvider
	{
		private IReadOnlyDictionary<string, IReadOnlyList<AvaloniaXamlIlXmlNamespaceInfo>> _xmlNamespaces;

		public static IAvaloniaXamlIlXmlNamespaceInfoProvider Singleton;

		public virtual IReadOnlyDictionary<string, IReadOnlyList<AvaloniaXamlIlXmlNamespaceInfo>> XmlNamespaces
		{
			get
			{
				if (_xmlNamespaces == null)
				{
					_xmlNamespaces = CreateNamespaces();
				}
				return _xmlNamespaces;
			}
		}

		private static AvaloniaXamlIlXmlNamespaceInfo CreateNamespaceInfo(string P_0, string P_1)
		{
			return new AvaloniaXamlIlXmlNamespaceInfo
			{
				ClrNamespace = P_0,
				ClrAssemblyName = P_1
			};
		}

		private static IReadOnlyDictionary<string, IReadOnlyList<AvaloniaXamlIlXmlNamespaceInfo>> CreateNamespaces()
		{
			return new Dictionary<string, IReadOnlyList<AvaloniaXamlIlXmlNamespaceInfo>>(2)
			{
				{
					"",
					new AvaloniaXamlIlXmlNamespaceInfo[33]
					{
						CreateNamespaceInfo("Avalonia", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Animation", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Animation.Easings", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Controls", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Data", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Data.Converters", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Input", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Input.GestureRecognizers", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Input.TextInput", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Layout", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.LogicalTree", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Media", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Media.Imaging", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Media.Transformation", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Styling", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Automation", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Embedding", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Presenters", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Primitives", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Shapes", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Templates", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Notifications", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Chrome", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Documents", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Fonts.Inter", "Avalonia.Fonts.Inter"),
						CreateNamespaceInfo("Avalonia.Data", "Avalonia.Markup"),
						CreateNamespaceInfo("Avalonia.Markup.Data", "Avalonia.Markup"),
						CreateNamespaceInfo("Avalonia.Markup.Xaml.MarkupExtensions", "Avalonia.Markup.Xaml"),
						CreateNamespaceInfo("Avalonia.Markup.Xaml.Styling", "Avalonia.Markup.Xaml"),
						CreateNamespaceInfo("Avalonia.Markup.Xaml.Templates", "Avalonia.Markup.Xaml"),
						CreateNamespaceInfo("Avalonia.Themes.Fluent", "Avalonia.Themes.Fluent")
					}
				},
				{
					"x",
					new AvaloniaXamlIlXmlNamespaceInfo[0]
				}
			};
		}

		static NamespaceInfo_003A_002FStyles_002FImageResources_002Eaxaml()
		{
			Singleton = new NamespaceInfo_003A_002FStyles_002FImageResources_002Eaxaml();
		}
	}

	[CompilerGenerated]
	private class XamlClosure_8
	{
		public static object Build_1(IServiceProvider P_0)
		{
			CompiledAvaloniaXaml.XamlIlContext.Context<ResourceDictionary> context = CreateContext(P_0);
			return (Bitmap)new BitmapTypeConverter().ConvertFrom(context, CultureInfo.InvariantCulture, "avares://HamburgerMenu.Avalonia/Assets/D_01.png");
		}

		public static CompiledAvaloniaXaml.XamlIlContext.Context<ResourceDictionary> CreateContext(IServiceProvider P_0)
		{
			CompiledAvaloniaXaml.XamlIlContext.Context<ResourceDictionary> context = new CompiledAvaloniaXaml.XamlIlContext.Context<ResourceDictionary>(P_0, new object[1] { NamespaceInfo_003A_002FStyles_002FImageResources_002Eaxaml.Singleton }, "avares://HamburgerMenu.Avalonia/Styles/ImageResources.axaml");
			if (P_0 != null)
			{
				object service = P_0.GetService(typeof(IRootObjectProvider));
				if (service != null)
				{
					service = ((IRootObjectProvider)service).RootObject;
					context.RootObject = (ResourceDictionary)service;
				}
			}
			return context;
		}

		public static object Build_2(IServiceProvider P_0)
		{
			CompiledAvaloniaXaml.XamlIlContext.Context<ResourceDictionary> context = CreateContext(P_0);
			return (Bitmap)new BitmapTypeConverter().ConvertFrom(context, CultureInfo.InvariantCulture, "avares://HamburgerMenu.Avalonia/Assets/D_02.png");
		}

		public static object Build_3(IServiceProvider P_0)
		{
			CompiledAvaloniaXaml.XamlIlContext.Context<ResourceDictionary> context = CreateContext(P_0);
			return (Bitmap)new BitmapTypeConverter().ConvertFrom(context, CultureInfo.InvariantCulture, "avares://HamburgerMenu.Avalonia/Assets/D_03.png");
		}

		public static object Build_4(IServiceProvider P_0)
		{
			CompiledAvaloniaXaml.XamlIlContext.Context<ResourceDictionary> context = CreateContext(P_0);
			return (Bitmap)new BitmapTypeConverter().ConvertFrom(context, CultureInfo.InvariantCulture, "avares://HamburgerMenu.Avalonia/Assets/M_01.png");
		}

		public static object Build_5(IServiceProvider P_0)
		{
			CompiledAvaloniaXaml.XamlIlContext.Context<ResourceDictionary> context = CreateContext(P_0);
			return (Bitmap)new BitmapTypeConverter().ConvertFrom(context, CultureInfo.InvariantCulture, "avares://HamburgerMenu.Avalonia/Assets/M_02.png");
		}

		public static object Build_6(IServiceProvider P_0)
		{
			CompiledAvaloniaXaml.XamlIlContext.Context<ResourceDictionary> context = CreateContext(P_0);
			return (Bitmap)new BitmapTypeConverter().ConvertFrom(context, CultureInfo.InvariantCulture, "avares://HamburgerMenu.Avalonia/Assets/M_03.png");
		}

		public static object Build_7(IServiceProvider P_0)
		{
			CompiledAvaloniaXaml.XamlIlContext.Context<ResourceDictionary> context = CreateContext(P_0);
			return (Bitmap)new BitmapTypeConverter().ConvertFrom(context, CultureInfo.InvariantCulture, "avares://HamburgerMenu.Avalonia/Assets/C_01.png");
		}

		public static object Build_8(IServiceProvider P_0)
		{
			CompiledAvaloniaXaml.XamlIlContext.Context<ResourceDictionary> context = CreateContext(P_0);
			return (Bitmap)new BitmapTypeConverter().ConvertFrom(context, CultureInfo.InvariantCulture, "avares://HamburgerMenu.Avalonia/Assets/C_02.png");
		}

		public static object Build_9(IServiceProvider P_0)
		{
			CompiledAvaloniaXaml.XamlIlContext.Context<ResourceDictionary> context = CreateContext(P_0);
			return (Bitmap)new BitmapTypeConverter().ConvertFrom(context, CultureInfo.InvariantCulture, "avares://HamburgerMenu.Avalonia/Assets/C_03.png");
		}

		public static object Build_10(IServiceProvider P_0)
		{
			CompiledAvaloniaXaml.XamlIlContext.Context<ResourceDictionary> context = CreateContext(P_0);
			return (Bitmap)new BitmapTypeConverter().ConvertFrom(context, CultureInfo.InvariantCulture, "avares://HamburgerMenu.Avalonia/Assets/A_01.png");
		}

		public static object Build_11(IServiceProvider P_0)
		{
			CompiledAvaloniaXaml.XamlIlContext.Context<ResourceDictionary> context = CreateContext(P_0);
			return (Bitmap)new BitmapTypeConverter().ConvertFrom(context, CultureInfo.InvariantCulture, "avares://HamburgerMenu.Avalonia/Assets/A_02.png");
		}

		public static object Build_12(IServiceProvider P_0)
		{
			CompiledAvaloniaXaml.XamlIlContext.Context<ResourceDictionary> context = CreateContext(P_0);
			return (Bitmap)new BitmapTypeConverter().ConvertFrom(context, CultureInfo.InvariantCulture, "avares://HamburgerMenu.Avalonia/Assets/A_03.png");
		}

		public static object Build_13(IServiceProvider P_0)
		{
			CompiledAvaloniaXaml.XamlIlContext.Context<ResourceDictionary> context = CreateContext(P_0);
			return (Bitmap)new BitmapTypeConverter().ConvertFrom(context, CultureInfo.InvariantCulture, "avares://HamburgerMenu.Avalonia/Assets/S_01.png");
		}

		public static object Build_14(IServiceProvider P_0)
		{
			CompiledAvaloniaXaml.XamlIlContext.Context<ResourceDictionary> context = CreateContext(P_0);
			return (Bitmap)new BitmapTypeConverter().ConvertFrom(context, CultureInfo.InvariantCulture, "avares://HamburgerMenu.Avalonia/Assets/S_02.png");
		}

		public static object Build_15(IServiceProvider P_0)
		{
			CompiledAvaloniaXaml.XamlIlContext.Context<ResourceDictionary> context = CreateContext(P_0);
			return (Bitmap)new BitmapTypeConverter().ConvertFrom(context, CultureInfo.InvariantCulture, "avares://HamburgerMenu.Avalonia/Assets/S_03.png");
		}

		public static object Build_16(IServiceProvider P_0)
		{
			CompiledAvaloniaXaml.XamlIlContext.Context<ResourceDictionary> context = CreateContext(P_0);
			return (Bitmap)new BitmapTypeConverter().ConvertFrom(context, CultureInfo.InvariantCulture, "avares://HamburgerMenu.Avalonia/Assets/DT_01.png");
		}

		public static object Build_17(IServiceProvider P_0)
		{
			CompiledAvaloniaXaml.XamlIlContext.Context<ResourceDictionary> context = CreateContext(P_0);
			return (Bitmap)new BitmapTypeConverter().ConvertFrom(context, CultureInfo.InvariantCulture, "avares://HamburgerMenu.Avalonia/Assets/MT_02.png");
		}

		public static object Build_18(IServiceProvider P_0)
		{
			CompiledAvaloniaXaml.XamlIlContext.Context<ResourceDictionary> context = CreateContext(P_0);
			return (Bitmap)new BitmapTypeConverter().ConvertFrom(context, CultureInfo.InvariantCulture, "avares://HamburgerMenu.Avalonia/Assets/CT_03.png");
		}

		public static object Build_19(IServiceProvider P_0)
		{
			CompiledAvaloniaXaml.XamlIlContext.Context<ResourceDictionary> context = CreateContext(P_0);
			return (Bitmap)new BitmapTypeConverter().ConvertFrom(context, CultureInfo.InvariantCulture, "avares://HamburgerMenu.Avalonia/Assets/AT_04.png");
		}

		public static object Build_20(IServiceProvider P_0)
		{
			CompiledAvaloniaXaml.XamlIlContext.Context<ResourceDictionary> context = CreateContext(P_0);
			return (Bitmap)new BitmapTypeConverter().ConvertFrom(context, CultureInfo.InvariantCulture, "avares://HamburgerMenu.Avalonia/Assets/ST_05.png");
		}

		public static object Build_21(IServiceProvider P_0)
		{
			CompiledAvaloniaXaml.XamlIlContext.Context<ResourceDictionary> context = CreateContext(P_0);
			return (Bitmap)new BitmapTypeConverter().ConvertFrom(context, CultureInfo.InvariantCulture, "avares://HamburgerMenu.Avalonia/Assets/SMO_1.png");
		}

		public static object Build_22(IServiceProvider P_0)
		{
			CompiledAvaloniaXaml.XamlIlContext.Context<ResourceDictionary> context = CreateContext(P_0);
			return (Bitmap)new BitmapTypeConverter().ConvertFrom(context, CultureInfo.InvariantCulture, "avares://HamburgerMenu.Avalonia/Assets/SMO_2.png");
		}

		public static object Build_23(IServiceProvider P_0)
		{
			CompiledAvaloniaXaml.XamlIlContext.Context<ResourceDictionary> context = CreateContext(P_0);
			return (Bitmap)new BitmapTypeConverter().ConvertFrom(context, CultureInfo.InvariantCulture, "avares://HamburgerMenu.Avalonia/Assets/SMT_1.png");
		}

		public static object Build_24(IServiceProvider P_0)
		{
			CompiledAvaloniaXaml.XamlIlContext.Context<ResourceDictionary> context = CreateContext(P_0);
			return (Bitmap)new BitmapTypeConverter().ConvertFrom(context, CultureInfo.InvariantCulture, "avares://HamburgerMenu.Avalonia/Assets/SMT_2.png");
		}

		public static object Build_25(IServiceProvider P_0)
		{
			CompiledAvaloniaXaml.XamlIlContext.Context<ResourceDictionary> context = CreateContext(P_0);
			return (Bitmap)new BitmapTypeConverter().ConvertFrom(context, CultureInfo.InvariantCulture, "avares://HamburgerMenu.Avalonia/Assets/I_01.png");
		}

		public static object Build_26(IServiceProvider P_0)
		{
			CompiledAvaloniaXaml.XamlIlContext.Context<ResourceDictionary> context = CreateContext(P_0);
			return (Bitmap)new BitmapTypeConverter().ConvertFrom(context, CultureInfo.InvariantCulture, "avares://HamburgerMenu.Avalonia/Assets/I_02.png");
		}

		public static object Build_27(IServiceProvider P_0)
		{
			CompiledAvaloniaXaml.XamlIlContext.Context<ResourceDictionary> context = CreateContext(P_0);
			return (Bitmap)new BitmapTypeConverter().ConvertFrom(context, CultureInfo.InvariantCulture, "avares://HamburgerMenu.Avalonia/Assets/I_03.png");
		}

		public static object Build_28(IServiceProvider P_0)
		{
			CompiledAvaloniaXaml.XamlIlContext.Context<ResourceDictionary> context = CreateContext(P_0);
			return (Bitmap)new BitmapTypeConverter().ConvertFrom(context, CultureInfo.InvariantCulture, "avares://HamburgerMenu.Avalonia/Assets/P_01.png");
		}

		public static object Build_29(IServiceProvider P_0)
		{
			CompiledAvaloniaXaml.XamlIlContext.Context<ResourceDictionary> context = CreateContext(P_0);
			return (Bitmap)new BitmapTypeConverter().ConvertFrom(context, CultureInfo.InvariantCulture, "avares://HamburgerMenu.Avalonia/Assets/P_02.png");
		}

		public static object Build_30(IServiceProvider P_0)
		{
			CompiledAvaloniaXaml.XamlIlContext.Context<ResourceDictionary> context = CreateContext(P_0);
			return (Bitmap)new BitmapTypeConverter().ConvertFrom(context, CultureInfo.InvariantCulture, "avares://HamburgerMenu.Avalonia/Assets/P_03.png");
		}

		public static object Build_31(IServiceProvider P_0)
		{
			CompiledAvaloniaXaml.XamlIlContext.Context<ResourceDictionary> context = CreateContext(P_0);
			return (Bitmap)new BitmapTypeConverter().ConvertFrom(context, CultureInfo.InvariantCulture, "avares://HamburgerMenu.Avalonia/Assets/SL_01.png");
		}

		public static object Build_32(IServiceProvider P_0)
		{
			CompiledAvaloniaXaml.XamlIlContext.Context<ResourceDictionary> context = CreateContext(P_0);
			return (Bitmap)new BitmapTypeConverter().ConvertFrom(context, CultureInfo.InvariantCulture, "avares://HamburgerMenu.Avalonia/Assets/SL_02.png");
		}

		public static object Build_33(IServiceProvider P_0)
		{
			CompiledAvaloniaXaml.XamlIlContext.Context<ResourceDictionary> context = CreateContext(P_0);
			return (Bitmap)new BitmapTypeConverter().ConvertFrom(context, CultureInfo.InvariantCulture, "avares://HamburgerMenu.Avalonia/Assets/SL_03.png");
		}

		public static object Build_34(IServiceProvider P_0)
		{
			CompiledAvaloniaXaml.XamlIlContext.Context<ResourceDictionary> context = CreateContext(P_0);
			return (Bitmap)new BitmapTypeConverter().ConvertFrom(context, CultureInfo.InvariantCulture, "avares://HamburgerMenu.Avalonia/Assets/ST_01.png");
		}

		public static object Build_35(IServiceProvider P_0)
		{
			CompiledAvaloniaXaml.XamlIlContext.Context<ResourceDictionary> context = CreateContext(P_0);
			return (Bitmap)new BitmapTypeConverter().ConvertFrom(context, CultureInfo.InvariantCulture, "avares://HamburgerMenu.Avalonia/Assets/ST_02.png");
		}

		public static object Build_36(IServiceProvider P_0)
		{
			CompiledAvaloniaXaml.XamlIlContext.Context<ResourceDictionary> context = CreateContext(P_0);
			return (Bitmap)new BitmapTypeConverter().ConvertFrom(context, CultureInfo.InvariantCulture, "avares://HamburgerMenu.Avalonia/Assets/ST_03.png");
		}

		public static object Build_37(IServiceProvider P_0)
		{
			CompiledAvaloniaXaml.XamlIlContext.Context<ResourceDictionary> context = CreateContext(P_0);
			return (Bitmap)new BitmapTypeConverter().ConvertFrom(context, CultureInfo.InvariantCulture, "avares://HamburgerMenu.Avalonia/Assets/AC_01.png");
		}

		public static object Build_38(IServiceProvider P_0)
		{
			CompiledAvaloniaXaml.XamlIlContext.Context<ResourceDictionary> context = CreateContext(P_0);
			return (Bitmap)new BitmapTypeConverter().ConvertFrom(context, CultureInfo.InvariantCulture, "avares://HamburgerMenu.Avalonia/Assets/AC_02.png");
		}

		public static object Build_39(IServiceProvider P_0)
		{
			CompiledAvaloniaXaml.XamlIlContext.Context<ResourceDictionary> context = CreateContext(P_0);
			return (Bitmap)new BitmapTypeConverter().ConvertFrom(context, CultureInfo.InvariantCulture, "avares://HamburgerMenu.Avalonia/Assets/AC_03.png");
		}

		public static object Build_40(IServiceProvider P_0)
		{
			CompiledAvaloniaXaml.XamlIlContext.Context<ResourceDictionary> context = CreateContext(P_0);
			return (Bitmap)new BitmapTypeConverter().ConvertFrom(context, CultureInfo.InvariantCulture, "avares://HamburgerMenu.Avalonia/Assets/PWD_01.png");
		}

		public static object Build_41(IServiceProvider P_0)
		{
			CompiledAvaloniaXaml.XamlIlContext.Context<ResourceDictionary> context = CreateContext(P_0);
			return (Bitmap)new BitmapTypeConverter().ConvertFrom(context, CultureInfo.InvariantCulture, "avares://HamburgerMenu.Avalonia/Assets/NOT_01.png");
		}

		public static object Build_42(IServiceProvider P_0)
		{
			CompiledAvaloniaXaml.XamlIlContext.Context<ResourceDictionary> context = CreateContext(P_0);
			return (Bitmap)new BitmapTypeConverter().ConvertFrom(context, CultureInfo.InvariantCulture, "avares://HamburgerMenu.Avalonia/Assets/H.png");
		}

		public static object Build_43(IServiceProvider P_0)
		{
			CompiledAvaloniaXaml.XamlIlContext.Context<ResourceDictionary> context = CreateContext(P_0);
			return (Bitmap)new BitmapTypeConverter().ConvertFrom(context, CultureInfo.InvariantCulture, "avares://HamburgerMenu.Avalonia/Assets/IND_1.png");
		}

		public static object Build_44(IServiceProvider P_0)
		{
			CompiledAvaloniaXaml.XamlIlContext.Context<ResourceDictionary> context = CreateContext(P_0);
			return (Bitmap)new BitmapTypeConverter().ConvertFrom(context, CultureInfo.InvariantCulture, "avares://HamburgerMenu.Avalonia/Assets/logo.png");
		}

		public static object Build_45(IServiceProvider P_0)
		{
			CompiledAvaloniaXaml.XamlIlContext.Context<ResourceDictionary> context = CreateContext(P_0);
			return (Bitmap)new BitmapTypeConverter().ConvertFrom(context, CultureInfo.InvariantCulture, "avares://HamburgerMenu.Avalonia/Assets/CL_01.png");
		}

		public static object Build_46(IServiceProvider P_0)
		{
			CompiledAvaloniaXaml.XamlIlContext.Context<ResourceDictionary> context = CreateContext(P_0);
			return (Bitmap)new BitmapTypeConverter().ConvertFrom(context, CultureInfo.InvariantCulture, "avares://HamburgerMenu.Avalonia/Assets/MX_01.png");
		}

		public static object Build_47(IServiceProvider P_0)
		{
			CompiledAvaloniaXaml.XamlIlContext.Context<ResourceDictionary> context = CreateContext(P_0);
			return (Bitmap)new BitmapTypeConverter().ConvertFrom(context, CultureInfo.InvariantCulture, "avares://HamburgerMenu.Avalonia/Assets/MN_01.png");
		}

		public static object Build_48(IServiceProvider P_0)
		{
			CompiledAvaloniaXaml.XamlIlContext.Context<ResourceDictionary> context = CreateContext(P_0);
			return (Bitmap)new BitmapTypeConverter().ConvertFrom(context, CultureInfo.InvariantCulture, "avares://HamburgerMenu.Avalonia/Assets/RS_01.png");
		}

		public static object Build_49(IServiceProvider P_0)
		{
			CompiledAvaloniaXaml.XamlIlContext.Context<ResourceDictionary> context = CreateContext(P_0);
			return (Bitmap)new BitmapTypeConverter().ConvertFrom(context, CultureInfo.InvariantCulture, "avares://HamburgerMenu.Avalonia/Assets/U_01.png");
		}

		public static object Build_50(IServiceProvider P_0)
		{
			CompiledAvaloniaXaml.XamlIlContext.Context<ResourceDictionary> context = CreateContext(P_0);
			return (Bitmap)new BitmapTypeConverter().ConvertFrom(context, CultureInfo.InvariantCulture, "avares://HamburgerMenu.Avalonia/Assets/U_01.png");
		}

		public static object Build_51(IServiceProvider P_0)
		{
			CompiledAvaloniaXaml.XamlIlContext.Context<ResourceDictionary> context = CreateContext(P_0);
			return (Bitmap)new BitmapTypeConverter().ConvertFrom(context, CultureInfo.InvariantCulture, "avares://HamburgerMenu.Avalonia/Assets/L_01.png");
		}

		public static object Build_52(IServiceProvider P_0)
		{
			CompiledAvaloniaXaml.XamlIlContext.Context<ResourceDictionary> context = CreateContext(P_0);
			return (Bitmap)new BitmapTypeConverter().ConvertFrom(context, CultureInfo.InvariantCulture, "avares://HamburgerMenu.Avalonia/Assets/R_01.png");
		}
	}

	[CompilerGenerated]
	internal class NamespaceInfo_003A_002FStyles_002FToggleButtonStyles_002Eaxaml : IAvaloniaXamlIlXmlNamespaceInfoProvider
	{
		private IReadOnlyDictionary<string, IReadOnlyList<AvaloniaXamlIlXmlNamespaceInfo>> _xmlNamespaces;

		public static IAvaloniaXamlIlXmlNamespaceInfoProvider Singleton;

		public virtual IReadOnlyDictionary<string, IReadOnlyList<AvaloniaXamlIlXmlNamespaceInfo>> XmlNamespaces
		{
			get
			{
				if (_xmlNamespaces == null)
				{
					_xmlNamespaces = CreateNamespaces();
				}
				return _xmlNamespaces;
			}
		}

		private static AvaloniaXamlIlXmlNamespaceInfo CreateNamespaceInfo(string P_0, string P_1)
		{
			return new AvaloniaXamlIlXmlNamespaceInfo
			{
				ClrNamespace = P_0,
				ClrAssemblyName = P_1
			};
		}

		private static IReadOnlyDictionary<string, IReadOnlyList<AvaloniaXamlIlXmlNamespaceInfo>> CreateNamespaces()
		{
			return new Dictionary<string, IReadOnlyList<AvaloniaXamlIlXmlNamespaceInfo>>(2)
			{
				{
					"",
					new AvaloniaXamlIlXmlNamespaceInfo[33]
					{
						CreateNamespaceInfo("Avalonia", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Animation", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Animation.Easings", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Controls", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Data", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Data.Converters", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Input", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Input.GestureRecognizers", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Input.TextInput", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Layout", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.LogicalTree", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Media", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Media.Imaging", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Media.Transformation", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia.Styling", "Avalonia.Base"),
						CreateNamespaceInfo("Avalonia", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Automation", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Embedding", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Presenters", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Primitives", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Shapes", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Templates", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Notifications", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Chrome", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Controls.Documents", "Avalonia.Controls"),
						CreateNamespaceInfo("Avalonia.Fonts.Inter", "Avalonia.Fonts.Inter"),
						CreateNamespaceInfo("Avalonia.Data", "Avalonia.Markup"),
						CreateNamespaceInfo("Avalonia.Markup.Data", "Avalonia.Markup"),
						CreateNamespaceInfo("Avalonia.Markup.Xaml.MarkupExtensions", "Avalonia.Markup.Xaml"),
						CreateNamespaceInfo("Avalonia.Markup.Xaml.Styling", "Avalonia.Markup.Xaml"),
						CreateNamespaceInfo("Avalonia.Markup.Xaml.Templates", "Avalonia.Markup.Xaml"),
						CreateNamespaceInfo("Avalonia.Themes.Fluent", "Avalonia.Themes.Fluent")
					}
				},
				{
					"x",
					new AvaloniaXamlIlXmlNamespaceInfo[0]
				}
			};
		}

		static NamespaceInfo_003A_002FStyles_002FToggleButtonStyles_002Eaxaml()
		{
			Singleton = new NamespaceInfo_003A_002FStyles_002FToggleButtonStyles_002Eaxaml();
		}
	}

	[CompilerGenerated]
	private class XamlClosure_9
	{
		public static object Build_1(IServiceProvider P_0)
		{
			CompiledAvaloniaXaml.XamlIlContext.Context<Styles> context = CreateContext(P_0);
			context.IntermediateRoot = new Border();
			object obj = context.IntermediateRoot;
			((ISupportInitialize)obj).BeginInit();
			((StyledElement)obj).Name = "PART_Border";
			object element = obj;
			context.AvaloniaNameScope.Register("PART_Border", element);
			AvaloniaObjectExtensions.Bind((AvaloniaObject)obj, Border.BackgroundProperty, new TemplateBinding(TemplatedControl.BackgroundProperty).ProvideValue());
			((AvaloniaObject)obj).SetValue(Border.CornerRadiusProperty, new CornerRadius(5.0, 5.0, 5.0, 5.0), BindingPriority.Template);
			((AvaloniaObject)obj).SetValue(Layoutable.MarginProperty, new Thickness(7.0, 7.0, 7.0, 7.0), BindingPriority.Template);
			ContentPresenter contentPresenter2;
			ContentPresenter contentPresenter = (contentPresenter2 = new ContentPresenter());
			((ISupportInitialize)contentPresenter).BeginInit();
			((Decorator)obj).Child = contentPresenter;
			CompiledAvaloniaXaml.XamlDynamicSetters._003C_003EXamlDynamicSetter_4(contentPresenter2, BindingPriority.Template, new TemplateBinding(ContentControl.ContentProperty).ProvideValue());
			contentPresenter2.SetValue(Layoutable.HorizontalAlignmentProperty, HorizontalAlignment.Center, BindingPriority.Template);
			contentPresenter2.SetValue(Layoutable.VerticalAlignmentProperty, VerticalAlignment.Center, BindingPriority.Template);
			((ISupportInitialize)contentPresenter2).EndInit();
			((ISupportInitialize)obj).EndInit();
			return obj;
		}

		public static CompiledAvaloniaXaml.XamlIlContext.Context<Styles> CreateContext(IServiceProvider P_0)
		{
			CompiledAvaloniaXaml.XamlIlContext.Context<Styles> context = new CompiledAvaloniaXaml.XamlIlContext.Context<Styles>(P_0, new object[1] { NamespaceInfo_003A_002FStyles_002FToggleButtonStyles_002Eaxaml.Singleton }, "avares://HamburgerMenu.Avalonia/Styles/ToggleButtonStyles.axaml");
			if (P_0 != null)
			{
				object service = P_0.GetService(typeof(IRootObjectProvider));
				if (service != null)
				{
					service = ((IRootObjectProvider)service).RootObject;
					context.RootObject = (Styles)service;
				}
			}
			return context;
		}

		public static object Build_2(IServiceProvider P_0)
		{
			CompiledAvaloniaXaml.XamlIlContext.Context<Styles> context = CreateContext(P_0);
			context.IntermediateRoot = new Border();
			object obj = context.IntermediateRoot;
			((ISupportInitialize)obj).BeginInit();
			((StyledElement)obj).Name = "PART_Border";
			object element = obj;
			context.AvaloniaNameScope.Register("PART_Border", element);
			AvaloniaObjectExtensions.Bind((AvaloniaObject)obj, Border.BackgroundProperty, new TemplateBinding(TemplatedControl.BackgroundProperty).ProvideValue());
			((AvaloniaObject)obj).SetValue(Border.BorderThicknessProperty, new Thickness(3.0, 0.0, 0.0, 0.0), BindingPriority.Template);
			((AvaloniaObject)obj).SetValue(Border.BorderBrushProperty, (IBrush)new ImmutableSolidColorBrush(16777215u), BindingPriority.Template);
			ContentPresenter contentPresenter2;
			ContentPresenter contentPresenter = (contentPresenter2 = new ContentPresenter());
			((ISupportInitialize)contentPresenter).BeginInit();
			((Decorator)obj).Child = contentPresenter;
			CompiledAvaloniaXaml.XamlDynamicSetters._003C_003EXamlDynamicSetter_4(contentPresenter2, BindingPriority.Template, new TemplateBinding(ContentControl.ContentProperty).ProvideValue());
			contentPresenter2.SetValue(Layoutable.HorizontalAlignmentProperty, HorizontalAlignment.Center, BindingPriority.Template);
			contentPresenter2.SetValue(Layoutable.VerticalAlignmentProperty, VerticalAlignment.Center, BindingPriority.Template);
			((ISupportInitialize)contentPresenter2).EndInit();
			((ISupportInitialize)obj).EndInit();
			return obj;
		}

		public static object Build_3(IServiceProvider P_0)
		{
			CompiledAvaloniaXaml.XamlIlContext.Context<Styles> context = CreateContext(P_0);
			context.IntermediateRoot = new Border();
			object obj = context.IntermediateRoot;
			((ISupportInitialize)obj).BeginInit();
			((StyledElement)obj).Name = "PART_Border";
			object element = obj;
			context.AvaloniaNameScope.Register("PART_Border", element);
			AvaloniaObjectExtensions.Bind((AvaloniaObject)obj, Border.BackgroundProperty, new TemplateBinding(TemplatedControl.BackgroundProperty).ProvideValue());
			((AvaloniaObject)obj).SetValue(Layoutable.HeightProperty, 40.0, BindingPriority.Template);
			ContentPresenter contentPresenter2;
			ContentPresenter contentPresenter = (contentPresenter2 = new ContentPresenter());
			((ISupportInitialize)contentPresenter).BeginInit();
			((Decorator)obj).Child = contentPresenter;
			CompiledAvaloniaXaml.XamlDynamicSetters._003C_003EXamlDynamicSetter_4(contentPresenter2, BindingPriority.Template, new TemplateBinding(ContentControl.ContentProperty).ProvideValue());
			contentPresenter2.SetValue(Layoutable.HorizontalAlignmentProperty, HorizontalAlignment.Stretch, BindingPriority.Template);
			contentPresenter2.SetValue(Layoutable.VerticalAlignmentProperty, VerticalAlignment.Center, BindingPriority.Template);
			((ISupportInitialize)contentPresenter2).EndInit();
			((ISupportInitialize)obj).EndInit();
			return obj;
		}

		public static object Build_4(IServiceProvider P_0)
		{
			CompiledAvaloniaXaml.XamlIlContext.Context<Styles> context = CreateContext(P_0);
			context.IntermediateRoot = new Border();
			object obj = context.IntermediateRoot;
			((ISupportInitialize)obj).BeginInit();
			((StyledElement)obj).Name = "PART_Border";
			object element = obj;
			context.AvaloniaNameScope.Register("PART_Border", element);
			AvaloniaObjectExtensions.Bind((AvaloniaObject)obj, Border.BackgroundProperty, new TemplateBinding(TemplatedControl.BackgroundProperty).ProvideValue());
			((AvaloniaObject)obj).SetValue(Layoutable.HeightProperty, 35.0, BindingPriority.Template);
			ContentPresenter contentPresenter2;
			ContentPresenter contentPresenter = (contentPresenter2 = new ContentPresenter());
			((ISupportInitialize)contentPresenter).BeginInit();
			((Decorator)obj).Child = contentPresenter;
			CompiledAvaloniaXaml.XamlDynamicSetters._003C_003EXamlDynamicSetter_4(contentPresenter2, BindingPriority.Template, new TemplateBinding(ContentControl.ContentProperty).ProvideValue());
			contentPresenter2.SetValue(Layoutable.HorizontalAlignmentProperty, HorizontalAlignment.Stretch, BindingPriority.Template);
			contentPresenter2.SetValue(Layoutable.VerticalAlignmentProperty, VerticalAlignment.Center, BindingPriority.Template);
			((ISupportInitialize)contentPresenter2).EndInit();
			((ISupportInitialize)obj).EndInit();
			return obj;
		}

		public static object Build_5(IServiceProvider P_0)
		{
			CompiledAvaloniaXaml.XamlIlContext.Context<Styles> context = CreateContext(P_0);
			context.IntermediateRoot = new Border();
			object obj = context.IntermediateRoot;
			((ISupportInitialize)obj).BeginInit();
			((StyledElement)obj).Name = "PART_Border";
			object element = obj;
			context.AvaloniaNameScope.Register("PART_Border", element);
			AvaloniaObjectExtensions.Bind((AvaloniaObject)obj, Border.BackgroundProperty, new TemplateBinding(TemplatedControl.BackgroundProperty).ProvideValue());
			((AvaloniaObject)obj).SetValue(Border.CornerRadiusProperty, new CornerRadius(5.0, 5.0, 5.0, 5.0), BindingPriority.Template);
			((AvaloniaObject)obj).SetValue(Layoutable.HeightProperty, 70.0, BindingPriority.Template);
			ContentPresenter contentPresenter2;
			ContentPresenter contentPresenter = (contentPresenter2 = new ContentPresenter());
			((ISupportInitialize)contentPresenter).BeginInit();
			((Decorator)obj).Child = contentPresenter;
			CompiledAvaloniaXaml.XamlDynamicSetters._003C_003EXamlDynamicSetter_4(contentPresenter2, BindingPriority.Template, new TemplateBinding(ContentControl.ContentProperty).ProvideValue());
			contentPresenter2.SetValue(Layoutable.HorizontalAlignmentProperty, HorizontalAlignment.Center, BindingPriority.Template);
			contentPresenter2.SetValue(Layoutable.VerticalAlignmentProperty, VerticalAlignment.Center, BindingPriority.Template);
			((ISupportInitialize)contentPresenter2).EndInit();
			((ISupportInitialize)obj).EndInit();
			return obj;
		}
	}

	public unsafe static void Populate_003A_002FStyles_002FImageResources_002Eaxaml(IServiceProvider P_0, ResourceDictionary P_1)
	{
		CompiledAvaloniaXaml.XamlIlContext.Context<ResourceDictionary> context = new CompiledAvaloniaXaml.XamlIlContext.Context<ResourceDictionary>(P_0, new object[1] { NamespaceInfo_003A_002FStyles_002FImageResources_002Eaxaml.Singleton }, "avares://HamburgerMenu.Avalonia/Styles/ImageResources.axaml")
		{
			RootObject = P_1,
			IntermediateRoot = P_1
		};
		ResourceDictionary resourceDictionary2;
		ResourceDictionary resourceDictionary = (resourceDictionary2 = P_1);
		context.PushParent(resourceDictionary2);
		if (resourceDictionary2 is ResourceDictionary resourceDictionary3)
		{
			resourceDictionary3.EnsureCapacity(resourceDictionary3.Count + 52);
		}
		resourceDictionary2.AddDeferred("Dashboard_S1", XamlIlRuntimeHelpers.DeferredTransformationFactoryV3<object>((nint)(delegate*<IServiceProvider, object>)(&XamlClosure_8.Build_1), context));
		resourceDictionary2.AddDeferred("Dashboard_S2", XamlIlRuntimeHelpers.DeferredTransformationFactoryV3<object>((nint)(delegate*<IServiceProvider, object>)(&XamlClosure_8.Build_2), context));
		resourceDictionary2.AddDeferred("Dashboard_S3", XamlIlRuntimeHelpers.DeferredTransformationFactoryV3<object>((nint)(delegate*<IServiceProvider, object>)(&XamlClosure_8.Build_3), context));
		resourceDictionary2.AddDeferred("Mail_S1", XamlIlRuntimeHelpers.DeferredTransformationFactoryV3<object>((nint)(delegate*<IServiceProvider, object>)(&XamlClosure_8.Build_4), context));
		resourceDictionary2.AddDeferred("Mail_S2", XamlIlRuntimeHelpers.DeferredTransformationFactoryV3<object>((nint)(delegate*<IServiceProvider, object>)(&XamlClosure_8.Build_5), context));
		resourceDictionary2.AddDeferred("Mail_S3", XamlIlRuntimeHelpers.DeferredTransformationFactoryV3<object>((nint)(delegate*<IServiceProvider, object>)(&XamlClosure_8.Build_6), context));
		resourceDictionary2.AddDeferred("Customer_S1", XamlIlRuntimeHelpers.DeferredTransformationFactoryV3<object>((nint)(delegate*<IServiceProvider, object>)(&XamlClosure_8.Build_7), context));
		resourceDictionary2.AddDeferred("Customer_S2", XamlIlRuntimeHelpers.DeferredTransformationFactoryV3<object>((nint)(delegate*<IServiceProvider, object>)(&XamlClosure_8.Build_8), context));
		resourceDictionary2.AddDeferred("Customer_S3", XamlIlRuntimeHelpers.DeferredTransformationFactoryV3<object>((nint)(delegate*<IServiceProvider, object>)(&XamlClosure_8.Build_9), context));
		resourceDictionary2.AddDeferred("Analytics_S1", XamlIlRuntimeHelpers.DeferredTransformationFactoryV3<object>((nint)(delegate*<IServiceProvider, object>)(&XamlClosure_8.Build_10), context));
		resourceDictionary2.AddDeferred("Analytics_S2", XamlIlRuntimeHelpers.DeferredTransformationFactoryV3<object>((nint)(delegate*<IServiceProvider, object>)(&XamlClosure_8.Build_11), context));
		resourceDictionary2.AddDeferred("Analytics_S3", XamlIlRuntimeHelpers.DeferredTransformationFactoryV3<object>((nint)(delegate*<IServiceProvider, object>)(&XamlClosure_8.Build_12), context));
		resourceDictionary2.AddDeferred("Settings_S1", XamlIlRuntimeHelpers.DeferredTransformationFactoryV3<object>((nint)(delegate*<IServiceProvider, object>)(&XamlClosure_8.Build_13), context));
		resourceDictionary2.AddDeferred("Settings_S2", XamlIlRuntimeHelpers.DeferredTransformationFactoryV3<object>((nint)(delegate*<IServiceProvider, object>)(&XamlClosure_8.Build_14), context));
		resourceDictionary2.AddDeferred("Settings_S3", XamlIlRuntimeHelpers.DeferredTransformationFactoryV3<object>((nint)(delegate*<IServiceProvider, object>)(&XamlClosure_8.Build_15), context));
		resourceDictionary2.AddDeferred("Dashboard_T", XamlIlRuntimeHelpers.DeferredTransformationFactoryV3<object>((nint)(delegate*<IServiceProvider, object>)(&XamlClosure_8.Build_16), context));
		resourceDictionary2.AddDeferred("Mail_T", XamlIlRuntimeHelpers.DeferredTransformationFactoryV3<object>((nint)(delegate*<IServiceProvider, object>)(&XamlClosure_8.Build_17), context));
		resourceDictionary2.AddDeferred("Customer_T", XamlIlRuntimeHelpers.DeferredTransformationFactoryV3<object>((nint)(delegate*<IServiceProvider, object>)(&XamlClosure_8.Build_18), context));
		resourceDictionary2.AddDeferred("Analytics_T", XamlIlRuntimeHelpers.DeferredTransformationFactoryV3<object>((nint)(delegate*<IServiceProvider, object>)(&XamlClosure_8.Build_19), context));
		resourceDictionary2.AddDeferred("Settings_T", XamlIlRuntimeHelpers.DeferredTransformationFactoryV3<object>((nint)(delegate*<IServiceProvider, object>)(&XamlClosure_8.Build_20), context));
		resourceDictionary2.AddDeferred("SubmenuOne_CB1", XamlIlRuntimeHelpers.DeferredTransformationFactoryV3<object>((nint)(delegate*<IServiceProvider, object>)(&XamlClosure_8.Build_21), context));
		resourceDictionary2.AddDeferred("SubmenuOne_CB2", XamlIlRuntimeHelpers.DeferredTransformationFactoryV3<object>((nint)(delegate*<IServiceProvider, object>)(&XamlClosure_8.Build_22), context));
		resourceDictionary2.AddDeferred("SubmenuTwo_CB1", XamlIlRuntimeHelpers.DeferredTransformationFactoryV3<object>((nint)(delegate*<IServiceProvider, object>)(&XamlClosure_8.Build_23), context));
		resourceDictionary2.AddDeferred("SubmenuTwo_CB2", XamlIlRuntimeHelpers.DeferredTransformationFactoryV3<object>((nint)(delegate*<IServiceProvider, object>)(&XamlClosure_8.Build_24), context));
		resourceDictionary2.AddDeferred("Inbox_B1", XamlIlRuntimeHelpers.DeferredTransformationFactoryV3<object>((nint)(delegate*<IServiceProvider, object>)(&XamlClosure_8.Build_25), context));
		resourceDictionary2.AddDeferred("Inbox_B2", XamlIlRuntimeHelpers.DeferredTransformationFactoryV3<object>((nint)(delegate*<IServiceProvider, object>)(&XamlClosure_8.Build_26), context));
		resourceDictionary2.AddDeferred("Inbox_B3", XamlIlRuntimeHelpers.DeferredTransformationFactoryV3<object>((nint)(delegate*<IServiceProvider, object>)(&XamlClosure_8.Build_27), context));
		resourceDictionary2.AddDeferred("Primary_B1", XamlIlRuntimeHelpers.DeferredTransformationFactoryV3<object>((nint)(delegate*<IServiceProvider, object>)(&XamlClosure_8.Build_28), context));
		resourceDictionary2.AddDeferred("Primary_B2", XamlIlRuntimeHelpers.DeferredTransformationFactoryV3<object>((nint)(delegate*<IServiceProvider, object>)(&XamlClosure_8.Build_29), context));
		resourceDictionary2.AddDeferred("Primary_B3", XamlIlRuntimeHelpers.DeferredTransformationFactoryV3<object>((nint)(delegate*<IServiceProvider, object>)(&XamlClosure_8.Build_30), context));
		resourceDictionary2.AddDeferred("Social_B1", XamlIlRuntimeHelpers.DeferredTransformationFactoryV3<object>((nint)(delegate*<IServiceProvider, object>)(&XamlClosure_8.Build_31), context));
		resourceDictionary2.AddDeferred("Social_B2", XamlIlRuntimeHelpers.DeferredTransformationFactoryV3<object>((nint)(delegate*<IServiceProvider, object>)(&XamlClosure_8.Build_32), context));
		resourceDictionary2.AddDeferred("Social_B3", XamlIlRuntimeHelpers.DeferredTransformationFactoryV3<object>((nint)(delegate*<IServiceProvider, object>)(&XamlClosure_8.Build_33), context));
		resourceDictionary2.AddDeferred("Sent_B1", XamlIlRuntimeHelpers.DeferredTransformationFactoryV3<object>((nint)(delegate*<IServiceProvider, object>)(&XamlClosure_8.Build_34), context));
		resourceDictionary2.AddDeferred("Sent_B2", XamlIlRuntimeHelpers.DeferredTransformationFactoryV3<object>((nint)(delegate*<IServiceProvider, object>)(&XamlClosure_8.Build_35), context));
		resourceDictionary2.AddDeferred("Sent_B3", XamlIlRuntimeHelpers.DeferredTransformationFactoryV3<object>((nint)(delegate*<IServiceProvider, object>)(&XamlClosure_8.Build_36), context));
		resourceDictionary2.AddDeferred("Account_B1", XamlIlRuntimeHelpers.DeferredTransformationFactoryV3<object>((nint)(delegate*<IServiceProvider, object>)(&XamlClosure_8.Build_37), context));
		resourceDictionary2.AddDeferred("Account_B2", XamlIlRuntimeHelpers.DeferredTransformationFactoryV3<object>((nint)(delegate*<IServiceProvider, object>)(&XamlClosure_8.Build_38), context));
		resourceDictionary2.AddDeferred("Account_B3", XamlIlRuntimeHelpers.DeferredTransformationFactoryV3<object>((nint)(delegate*<IServiceProvider, object>)(&XamlClosure_8.Build_39), context));
		resourceDictionary2.AddDeferred("Password_B1", XamlIlRuntimeHelpers.DeferredTransformationFactoryV3<object>((nint)(delegate*<IServiceProvider, object>)(&XamlClosure_8.Build_40), context));
		resourceDictionary2.AddDeferred("Notification_B1", XamlIlRuntimeHelpers.DeferredTransformationFactoryV3<object>((nint)(delegate*<IServiceProvider, object>)(&XamlClosure_8.Build_41), context));
		resourceDictionary2.AddDeferred("Hamburger_Image", XamlIlRuntimeHelpers.DeferredTransformationFactoryV3<object>((nint)(delegate*<IServiceProvider, object>)(&XamlClosure_8.Build_42), context));
		resourceDictionary2.AddDeferred("SubmenuOne_Indicator", XamlIlRuntimeHelpers.DeferredTransformationFactoryV3<object>((nint)(delegate*<IServiceProvider, object>)(&XamlClosure_8.Build_43), context));
		resourceDictionary2.AddDeferred("Logo_1", XamlIlRuntimeHelpers.DeferredTransformationFactoryV3<object>((nint)(delegate*<IServiceProvider, object>)(&XamlClosure_8.Build_44), context));
		resourceDictionary2.AddDeferred("Close_01", XamlIlRuntimeHelpers.DeferredTransformationFactoryV3<object>((nint)(delegate*<IServiceProvider, object>)(&XamlClosure_8.Build_45), context));
		resourceDictionary2.AddDeferred("Maximize_01", XamlIlRuntimeHelpers.DeferredTransformationFactoryV3<object>((nint)(delegate*<IServiceProvider, object>)(&XamlClosure_8.Build_46), context));
		resourceDictionary2.AddDeferred("Minimize_01", XamlIlRuntimeHelpers.DeferredTransformationFactoryV3<object>((nint)(delegate*<IServiceProvider, object>)(&XamlClosure_8.Build_47), context));
		resourceDictionary2.AddDeferred("Reset_01", XamlIlRuntimeHelpers.DeferredTransformationFactoryV3<object>((nint)(delegate*<IServiceProvider, object>)(&XamlClosure_8.Build_48), context));
		resourceDictionary2.AddDeferred("ST_1", XamlIlRuntimeHelpers.DeferredTransformationFactoryV3<object>((nint)(delegate*<IServiceProvider, object>)(&XamlClosure_8.Build_49), context));
		resourceDictionary2.AddDeferred("ST_2", XamlIlRuntimeHelpers.DeferredTransformationFactoryV3<object>((nint)(delegate*<IServiceProvider, object>)(&XamlClosure_8.Build_50), context));
		resourceDictionary2.AddDeferred("SMTR_1", XamlIlRuntimeHelpers.DeferredTransformationFactoryV3<object>((nint)(delegate*<IServiceProvider, object>)(&XamlClosure_8.Build_51), context));
		resourceDictionary2.AddDeferred("SMTR_2", XamlIlRuntimeHelpers.DeferredTransformationFactoryV3<object>((nint)(delegate*<IServiceProvider, object>)(&XamlClosure_8.Build_52), context));
		context.PopParent();
		if ((object)resourceDictionary is StyledElement styled)
		{
			NameScope.SetNameScope(styled, context.AvaloniaNameScope);
		}
		context.AvaloniaNameScope.Complete();
	}

	public static ResourceDictionary Build_003A_002FStyles_002FImageResources_002Eaxaml(IServiceProvider P_0)
	{
		ResourceDictionary resourceDictionary = new ResourceDictionary();
		Populate_003A_002FStyles_002FImageResources_002Eaxaml(P_0, resourceDictionary);
		return resourceDictionary;
	}

	public unsafe static void Populate_003A_002FStyles_002FFontResources_002Eaxaml(IServiceProvider P_0, ResourceDictionary P_1)
	{
		CompiledAvaloniaXaml.XamlIlContext.Context<ResourceDictionary> context = new CompiledAvaloniaXaml.XamlIlContext.Context<ResourceDictionary>(P_0, new object[1] { NamespaceInfo_003A_002FStyles_002FFontResources_002Eaxaml.Singleton }, "avares://HamburgerMenu.Avalonia/Styles/FontResources.axaml")
		{
			RootObject = P_1,
			IntermediateRoot = P_1
		};
		if (P_1 is ResourceDictionary resourceDictionary)
		{
			resourceDictionary.EnsureCapacity(resourceDictionary.Count + 2);
		}
		P_1.AddDeferred("FontStyle_1", XamlIlRuntimeHelpers.DeferredTransformationFactoryV3<object>((nint)(delegate*<IServiceProvider, object>)(&XamlClosure_7.Build_1), context));
		P_1.AddDeferred("FontStyle_2", XamlIlRuntimeHelpers.DeferredTransformationFactoryV3<object>((nint)(delegate*<IServiceProvider, object>)(&XamlClosure_7.Build_2), context));
		if ((object)P_1 is StyledElement styled)
		{
			NameScope.SetNameScope(styled, context.AvaloniaNameScope);
		}
		context.AvaloniaNameScope.Complete();
	}

	public static ResourceDictionary Build_003A_002FStyles_002FFontResources_002Eaxaml(IServiceProvider P_0)
	{
		ResourceDictionary resourceDictionary = new ResourceDictionary();
		Populate_003A_002FStyles_002FFontResources_002Eaxaml(P_0, resourceDictionary);
		return resourceDictionary;
	}

	public unsafe static void Populate_003A_002FStyles_002FColors_002Eaxaml(IServiceProvider P_0, ResourceDictionary P_1)
	{
		CompiledAvaloniaXaml.XamlIlContext.Context<ResourceDictionary> context = new CompiledAvaloniaXaml.XamlIlContext.Context<ResourceDictionary>(P_0, new object[1] { NamespaceInfo_003A_002FStyles_002FColors_002Eaxaml.Singleton }, "avares://HamburgerMenu.Avalonia/Styles/Colors.axaml")
		{
			RootObject = P_1,
			IntermediateRoot = P_1
		};
		ResourceDictionary resourceDictionary2;
		ResourceDictionary resourceDictionary = (resourceDictionary2 = P_1);
		context.PushParent(resourceDictionary2);
		if (resourceDictionary2 is ResourceDictionary resourceDictionary3)
		{
			resourceDictionary3.EnsureCapacity(resourceDictionary3.Count + 14);
		}
		resourceDictionary2.Add("BackgroundColor", Color.FromUInt32(4280558628u));
		resourceDictionary2.Add("PanelColor", Color.FromUInt32(4281677109u));
		resourceDictionary2.Add("PanelDarkColor", Color.FromUInt32(4281545523u));
		resourceDictionary2.Add("AccentColor", Color.FromUInt32(4294937600u));
		resourceDictionary2.Add("TextColor", Color.FromUInt32(uint.MaxValue));
		resourceDictionary2.Add("HoverColor", Color.FromUInt32(4284440415u));
		resourceDictionary2.Add("PressedColor", Color.FromUInt32(4283782485u));
		resourceDictionary2.AddDeferred("BackgroundBrush", XamlIlRuntimeHelpers.DeferredTransformationFactoryV3<object>((nint)(delegate*<IServiceProvider, object>)(&XamlClosure_6.Build_1), context));
		resourceDictionary2.AddDeferred("PanelBrush", XamlIlRuntimeHelpers.DeferredTransformationFactoryV3<object>((nint)(delegate*<IServiceProvider, object>)(&XamlClosure_6.Build_2), context));
		resourceDictionary2.AddDeferred("PanelDarkBrush", XamlIlRuntimeHelpers.DeferredTransformationFactoryV3<object>((nint)(delegate*<IServiceProvider, object>)(&XamlClosure_6.Build_3), context));
		resourceDictionary2.AddDeferred("AccentBrush", XamlIlRuntimeHelpers.DeferredTransformationFactoryV3<object>((nint)(delegate*<IServiceProvider, object>)(&XamlClosure_6.Build_4), context));
		resourceDictionary2.AddDeferred("TextBrush", XamlIlRuntimeHelpers.DeferredTransformationFactoryV3<object>((nint)(delegate*<IServiceProvider, object>)(&XamlClosure_6.Build_5), context));
		resourceDictionary2.AddDeferred("HoverBrush", XamlIlRuntimeHelpers.DeferredTransformationFactoryV3<object>((nint)(delegate*<IServiceProvider, object>)(&XamlClosure_6.Build_6), context));
		resourceDictionary2.AddDeferred("PressedBrush", XamlIlRuntimeHelpers.DeferredTransformationFactoryV3<object>((nint)(delegate*<IServiceProvider, object>)(&XamlClosure_6.Build_7), context));
		context.PopParent();
		if ((object)resourceDictionary is StyledElement styled)
		{
			NameScope.SetNameScope(styled, context.AvaloniaNameScope);
		}
		context.AvaloniaNameScope.Complete();
	}

	public static ResourceDictionary Build_003A_002FStyles_002FColors_002Eaxaml(IServiceProvider P_0)
	{
		ResourceDictionary resourceDictionary = new ResourceDictionary();
		Populate_003A_002FStyles_002FColors_002Eaxaml(P_0, resourceDictionary);
		return resourceDictionary;
	}

	public unsafe static void Populate_003A_002FStyles_002FButtonStyles_002Eaxaml(IServiceProvider P_0, Styles P_1)
	{
		CompiledAvaloniaXaml.XamlIlContext.Context<Styles> context = new CompiledAvaloniaXaml.XamlIlContext.Context<Styles>(P_0, new object[1] { NamespaceInfo_003A_002FStyles_002FButtonStyles_002Eaxaml.Singleton }, "avares://HamburgerMenu.Avalonia/Styles/ButtonStyles.axaml")
		{
			RootObject = P_1,
			IntermediateRoot = P_1
		};
		Style style = new Style();
		style.Selector = ((Selector?)null).OfType(typeof(Button)).Class("ControlBtn");
		Setter setter = new Setter();
		setter.Property = TemplatedControl.BackgroundProperty;
		setter.Value = new ImmutableSolidColorBrush(16777215u);
		style.Add(setter);
		Setter setter2 = new Setter();
		setter2.Property = TemplatedControl.BorderThicknessProperty;
		setter2.Value = new Thickness(0.0, 0.0, 0.0, 0.0);
		style.Add(setter2);
		Setter setter3 = new Setter();
		setter3.Property = TemplatedControl.PaddingProperty;
		setter3.Value = new Thickness(0.0, 0.0, 0.0, 0.0);
		style.Add(setter3);
		Setter setter4 = new Setter();
		setter4.Property = InputElement.CursorProperty;
		setter4.Value = new Cursor(StandardCursorType.Hand);
		style.Add(setter4);
		Setter setter5 = new Setter();
		setter5.Property = TemplatedControl.TemplateProperty;
		setter5.Value = new ControlTemplate
		{
			Content = XamlIlRuntimeHelpers.DeferredTransformationFactoryV3<Control>((nint)(delegate*<IServiceProvider, object>)(&XamlClosure_5.Build_1), context)
		};
		style.Add(setter5);
		Style style2 = new Style();
		style2.Selector = ((Selector?)null).Nesting().Class(":pointerover").Template()
			.OfType(typeof(Border))
			.Name("PART_Border");
		Setter setter6 = new Setter();
		setter6.Property = Border.BackgroundProperty;
		setter6.Value = new ImmutableSolidColorBrush(4284440415u);
		style2.Add(setter6);
		style.Add(style2);
		Style style3 = new Style();
		style3.Selector = ((Selector?)null).Nesting().Class(":pressed").Template()
			.OfType(typeof(Border))
			.Name("PART_Border");
		Setter setter7 = new Setter();
		setter7.Property = Border.BackgroundProperty;
		setter7.Value = new ImmutableSolidColorBrush(4283782485u);
		style3.Add(setter7);
		style.Add(style3);
		P_1.Add(style);
		Style style4 = new Style();
		style4.Selector = ((Selector?)null).OfType(typeof(Button)).Class("ResetBtn");
		Setter setter8 = new Setter();
		setter8.Property = TemplatedControl.BackgroundProperty;
		setter8.Value = new ImmutableSolidColorBrush(4281677109u);
		style4.Add(setter8);
		Setter setter9 = new Setter();
		setter9.Property = TemplatedControl.BorderThicknessProperty;
		setter9.Value = new Thickness(0.0, 0.0, 0.0, 0.0);
		style4.Add(setter9);
		Setter setter10 = new Setter();
		setter10.Property = InputElement.CursorProperty;
		setter10.Value = new Cursor(StandardCursorType.Hand);
		style4.Add(setter10);
		Setter setter11 = new Setter();
		setter11.Property = TemplatedControl.TemplateProperty;
		setter11.Value = new ControlTemplate
		{
			Content = XamlIlRuntimeHelpers.DeferredTransformationFactoryV3<Control>((nint)(delegate*<IServiceProvider, object>)(&XamlClosure_5.Build_2), context)
		};
		style4.Add(setter11);
		Style style5 = new Style();
		style5.Selector = ((Selector?)null).Nesting().Class(":pointerover").Template()
			.OfType(typeof(Border))
			.Name("PART_Border");
		Setter setter12 = new Setter();
		setter12.Property = Border.BackgroundProperty;
		setter12.Value = new ImmutableSolidColorBrush(4284440415u);
		style5.Add(setter12);
		style4.Add(style5);
		Style style6 = new Style();
		style6.Selector = ((Selector?)null).Nesting().Class(":pressed").Template()
			.OfType(typeof(Border))
			.Name("PART_Border");
		Setter setter13 = new Setter();
		setter13.Property = Border.BackgroundProperty;
		setter13.Value = new ImmutableSolidColorBrush(4283782485u);
		style6.Add(setter13);
		style4.Add(style6);
		P_1.Add(style4);
		Style style7 = new Style();
		style7.Selector = ((Selector?)null).OfType(typeof(Button)).Class("SubmenuCloseBtn");
		Setter setter14 = new Setter();
		setter14.Property = TemplatedControl.BackgroundProperty;
		setter14.Value = new ImmutableSolidColorBrush(16777215u);
		style7.Add(setter14);
		Setter setter15 = new Setter();
		setter15.Property = TemplatedControl.BorderThicknessProperty;
		setter15.Value = new Thickness(0.0, 0.0, 0.0, 0.0);
		style7.Add(setter15);
		Setter setter16 = new Setter();
		setter16.Property = InputElement.CursorProperty;
		setter16.Value = new Cursor(StandardCursorType.Hand);
		style7.Add(setter16);
		Setter setter17 = new Setter();
		setter17.Property = Layoutable.WidthProperty;
		setter17.Value = 25.0;
		style7.Add(setter17);
		Setter setter18 = new Setter();
		setter18.Property = Layoutable.HeightProperty;
		setter18.Value = 25.0;
		style7.Add(setter18);
		P_1.Add(style7);
		Style style8 = new Style();
		style8.Selector = ((Selector?)null).OfType(typeof(Button)).Class("ServerBtn");
		Setter setter19 = new Setter();
		setter19.Property = TemplatedControl.BackgroundProperty;
		setter19.Value = new ImmutableSolidColorBrush(4281677109u);
		style8.Add(setter19);
		Setter setter20 = new Setter();
		setter20.Property = TemplatedControl.BorderThicknessProperty;
		setter20.Value = new Thickness(0.0, 0.0, 0.0, 0.0);
		style8.Add(setter20);
		Setter setter21 = new Setter();
		setter21.Property = InputElement.CursorProperty;
		setter21.Value = new Cursor(StandardCursorType.Hand);
		style8.Add(setter21);
		Setter setter22 = new Setter();
		setter22.Property = TemplatedControl.PaddingProperty;
		setter22.Value = new Thickness(6.0, 3.0, 6.0, 3.0);
		style8.Add(setter22);
		Setter setter23 = new Setter();
		setter23.Property = Layoutable.MarginProperty;
		setter23.Value = new Thickness(0.0, 1.0, 0.0, 1.0);
		style8.Add(setter23);
		Setter setter24 = new Setter();
		setter24.Property = Layoutable.HorizontalAlignmentProperty;
		setter24.Value = HorizontalAlignment.Stretch;
		style8.Add(setter24);
		Setter setter25 = new Setter();
		setter25.Property = TemplatedControl.TemplateProperty;
		setter25.Value = new ControlTemplate
		{
			Content = XamlIlRuntimeHelpers.DeferredTransformationFactoryV3<Control>((nint)(delegate*<IServiceProvider, object>)(&XamlClosure_5.Build_3), context)
		};
		style8.Add(setter25);
		Style style9 = new Style();
		style9.Selector = ((Selector?)null).Nesting().Class(":pointerover").Template()
			.OfType(typeof(Border))
			.Name("PART_Border");
		Setter setter26 = new Setter();
		setter26.Property = Border.BackgroundProperty;
		setter26.Value = new ImmutableSolidColorBrush(4282729797u);
		style9.Add(setter26);
		style8.Add(style9);
		Style style10 = new Style();
		style10.Selector = ((Selector?)null).Nesting().Class(":pressed").Template()
			.OfType(typeof(Border))
			.Name("PART_Border");
		Setter setter27 = new Setter();
		setter27.Property = Border.BackgroundProperty;
		setter27.Value = new ImmutableSolidColorBrush(4283782485u);
		style10.Add(setter27);
		style8.Add(style10);
		P_1.Add(style8);
		if ((object)P_1 is StyledElement styled)
		{
			NameScope.SetNameScope(styled, context.AvaloniaNameScope);
		}
		context.AvaloniaNameScope.Complete();
	}

	public static Styles Build_003A_002FStyles_002FButtonStyles_002Eaxaml(IServiceProvider P_0)
	{
		Styles styles = new Styles();
		Populate_003A_002FStyles_002FButtonStyles_002Eaxaml(P_0, styles);
		return styles;
	}

	public unsafe static void Populate_003A_002FStyles_002FToggleButtonStyles_002Eaxaml(IServiceProvider P_0, Styles P_1)
	{
		CompiledAvaloniaXaml.XamlIlContext.Context<Styles> context = new CompiledAvaloniaXaml.XamlIlContext.Context<Styles>(P_0, new object[1] { NamespaceInfo_003A_002FStyles_002FToggleButtonStyles_002Eaxaml.Singleton }, "avares://HamburgerMenu.Avalonia/Styles/ToggleButtonStyles.axaml")
		{
			RootObject = P_1,
			IntermediateRoot = P_1
		};
		Style style = new Style();
		style.Selector = ((Selector?)null).OfType(typeof(ToggleButton)).Class("HamburgerToggle");
		Setter setter = new Setter();
		setter.Property = TemplatedControl.BackgroundProperty;
		setter.Value = new ImmutableSolidColorBrush(16777215u);
		style.Add(setter);
		Setter setter2 = new Setter();
		setter2.Property = TemplatedControl.BorderThicknessProperty;
		setter2.Value = new Thickness(0.0, 0.0, 0.0, 0.0);
		style.Add(setter2);
		Setter setter3 = new Setter();
		setter3.Property = InputElement.CursorProperty;
		setter3.Value = new Cursor(StandardCursorType.Hand);
		style.Add(setter3);
		Setter setter4 = new Setter();
		setter4.Property = Layoutable.WidthProperty;
		setter4.Value = 50.0;
		style.Add(setter4);
		Setter setter5 = new Setter();
		setter5.Property = Layoutable.HeightProperty;
		setter5.Value = 50.0;
		style.Add(setter5);
		Setter setter6 = new Setter();
		setter6.Property = TemplatedControl.TemplateProperty;
		setter6.Value = new ControlTemplate
		{
			Content = XamlIlRuntimeHelpers.DeferredTransformationFactoryV3<Control>((nint)(delegate*<IServiceProvider, object>)(&XamlClosure_9.Build_1), context)
		};
		style.Add(setter6);
		Style style2 = new Style();
		style2.Selector = ((Selector?)null).Nesting().Class(":pointerover").Template()
			.OfType(typeof(Border))
			.Name("PART_Border");
		Setter setter7 = new Setter();
		setter7.Property = Border.BackgroundProperty;
		setter7.Value = new ImmutableSolidColorBrush(4294937600u);
		style2.Add(setter7);
		style.Add(style2);
		Style style3 = new Style();
		style3.Selector = ((Selector?)null).Nesting().Class(":checked").Template()
			.OfType(typeof(Border))
			.Name("PART_Border");
		Setter setter8 = new Setter();
		setter8.Property = Border.BackgroundProperty;
		setter8.Value = new ImmutableSolidColorBrush(4294937600u);
		style3.Add(setter8);
		style.Add(style3);
		P_1.Add(style);
		Style style4 = new Style();
		style4.Selector = ((Selector?)null).OfType(typeof(ToggleButton)).Class("SideBarItem");
		Setter setter9 = new Setter();
		setter9.Property = TemplatedControl.BackgroundProperty;
		setter9.Value = new ImmutableSolidColorBrush(4281545523u);
		style4.Add(setter9);
		Setter setter10 = new Setter();
		setter10.Property = TemplatedControl.BorderThicknessProperty;
		setter10.Value = new Thickness(0.0, 0.0, 0.0, 0.0);
		style4.Add(setter10);
		Setter setter11 = new Setter();
		setter11.Property = InputElement.CursorProperty;
		setter11.Value = new Cursor(StandardCursorType.Hand);
		style4.Add(setter11);
		Setter setter12 = new Setter();
		setter12.Property = Layoutable.HeightProperty;
		setter12.Value = 40.0;
		style4.Add(setter12);
		Setter setter13 = new Setter();
		setter13.Property = Layoutable.WidthProperty;
		setter13.Value = 50.0;
		style4.Add(setter13);
		Setter setter14 = new Setter();
		setter14.Property = Layoutable.HorizontalAlignmentProperty;
		setter14.Value = HorizontalAlignment.Right;
		style4.Add(setter14);
		Setter setter15 = new Setter();
		setter15.Property = TemplatedControl.TemplateProperty;
		setter15.Value = new ControlTemplate
		{
			Content = XamlIlRuntimeHelpers.DeferredTransformationFactoryV3<Control>((nint)(delegate*<IServiceProvider, object>)(&XamlClosure_9.Build_2), context)
		};
		style4.Add(setter15);
		Style style5 = new Style();
		style5.Selector = ((Selector?)null).Nesting().Class(":pointerover").Template()
			.OfType(typeof(Border))
			.Name("PART_Border");
		Setter setter16 = new Setter();
		setter16.Property = Border.BorderBrushProperty;
		setter16.Value = new ImmutableSolidColorBrush(uint.MaxValue);
		style5.Add(setter16);
		style4.Add(style5);
		Style style6 = new Style();
		style6.Selector = ((Selector?)null).Nesting().Class(":checked").Template()
			.OfType(typeof(Border))
			.Name("PART_Border");
		Setter setter17 = new Setter();
		setter17.Property = Border.BorderBrushProperty;
		setter17.Value = new ImmutableSolidColorBrush(4294937600u);
		style6.Add(setter17);
		style4.Add(style6);
		P_1.Add(style4);
		Style style7 = new Style();
		style7.Selector = ((Selector?)null).OfType(typeof(ToggleButton)).Class("SidePanelItem");
		Setter setter18 = new Setter();
		setter18.Property = TemplatedControl.BackgroundProperty;
		setter18.Value = new ImmutableSolidColorBrush(4281545523u);
		style7.Add(setter18);
		Setter setter19 = new Setter();
		setter19.Property = TemplatedControl.BorderThicknessProperty;
		setter19.Value = new Thickness(0.0, 0.0, 0.0, 0.0);
		style7.Add(setter19);
		Setter setter20 = new Setter();
		setter20.Property = InputElement.CursorProperty;
		setter20.Value = new Cursor(StandardCursorType.Hand);
		style7.Add(setter20);
		Setter setter21 = new Setter();
		setter21.Property = Layoutable.HeightProperty;
		setter21.Value = 40.0;
		style7.Add(setter21);
		Setter setter22 = new Setter();
		setter22.Property = TemplatedControl.TemplateProperty;
		setter22.Value = new ControlTemplate
		{
			Content = XamlIlRuntimeHelpers.DeferredTransformationFactoryV3<Control>((nint)(delegate*<IServiceProvider, object>)(&XamlClosure_9.Build_3), context)
		};
		style7.Add(setter22);
		P_1.Add(style7);
		Style style8 = new Style();
		style8.Selector = ((Selector?)null).OfType(typeof(ToggleButton)).Class("SubmenuItem");
		Setter setter23 = new Setter();
		setter23.Property = TemplatedControl.BackgroundProperty;
		setter23.Value = new ImmutableSolidColorBrush(16777215u);
		style8.Add(setter23);
		Setter setter24 = new Setter();
		setter24.Property = TemplatedControl.BorderThicknessProperty;
		setter24.Value = new Thickness(0.0, 0.0, 0.0, 0.0);
		style8.Add(setter24);
		Setter setter25 = new Setter();
		setter25.Property = InputElement.CursorProperty;
		setter25.Value = new Cursor(StandardCursorType.Hand);
		style8.Add(setter25);
		Setter setter26 = new Setter();
		setter26.Property = Layoutable.HeightProperty;
		setter26.Value = 35.0;
		style8.Add(setter26);
		Setter setter27 = new Setter();
		setter27.Property = TemplatedControl.TemplateProperty;
		setter27.Value = new ControlTemplate
		{
			Content = XamlIlRuntimeHelpers.DeferredTransformationFactoryV3<Control>((nint)(delegate*<IServiceProvider, object>)(&XamlClosure_9.Build_4), context)
		};
		style8.Add(setter27);
		Style style9 = new Style();
		style9.Selector = ((Selector?)null).Nesting().Class(":pointerover").Template()
			.OfType(typeof(Border))
			.Name("PART_Border");
		Setter setter28 = new Setter();
		setter28.Property = Border.BackgroundProperty;
		setter28.Value = new ImmutableSolidColorBrush(4283519313u);
		style9.Add(setter28);
		style8.Add(style9);
		Style style10 = new Style();
		style10.Selector = ((Selector?)null).Nesting().Class(":checked").Template()
			.OfType(typeof(Border))
			.Name("PART_Border");
		Setter setter29 = new Setter();
		setter29.Property = Border.BackgroundProperty;
		setter29.Value = new ImmutableSolidColorBrush(4294937600u);
		style10.Add(setter29);
		style8.Add(style10);
		P_1.Add(style8);
		Style style11 = new Style();
		style11.Selector = ((Selector?)null).OfType(typeof(ToggleButton)).Class("SubmenuItemLight");
		Setter setter30 = new Setter();
		setter30.Property = TemplatedControl.BackgroundProperty;
		setter30.Value = new ImmutableSolidColorBrush(uint.MaxValue);
		style11.Add(setter30);
		Style style12 = new Style();
		style12.Selector = ((Selector?)null).Nesting().Class(":pointerover").Template()
			.OfType(typeof(Border))
			.Name("PART_Border");
		Setter setter31 = new Setter();
		setter31.Property = Border.BackgroundProperty;
		setter31.Value = new ImmutableSolidColorBrush(4293454056u);
		style12.Add(setter31);
		style11.Add(style12);
		Style style13 = new Style();
		style13.Selector = ((Selector?)null).Nesting().Class(":checked").Template()
			.OfType(typeof(Border))
			.Name("PART_Border");
		Setter setter32 = new Setter();
		setter32.Property = Border.BackgroundProperty;
		setter32.Value = new ImmutableSolidColorBrush(4292730333u);
		style13.Add(setter32);
		style11.Add(style13);
		P_1.Add(style11);
		Style style14 = new Style();
		style14.Selector = ((Selector?)null).OfType(typeof(ToggleButton)).Class("SubmenuTwoItem");
		Setter setter33 = new Setter();
		setter33.Property = TemplatedControl.BackgroundProperty;
		setter33.Value = new ImmutableSolidColorBrush(4282729797u);
		style14.Add(setter33);
		Setter setter34 = new Setter();
		setter34.Property = TemplatedControl.BorderThicknessProperty;
		setter34.Value = new Thickness(0.0, 0.0, 0.0, 0.0);
		style14.Add(setter34);
		Setter setter35 = new Setter();
		setter35.Property = InputElement.CursorProperty;
		setter35.Value = new Cursor(StandardCursorType.Hand);
		style14.Add(setter35);
		Setter setter36 = new Setter();
		setter36.Property = TemplatedControl.TemplateProperty;
		setter36.Value = new ControlTemplate
		{
			Content = XamlIlRuntimeHelpers.DeferredTransformationFactoryV3<Control>((nint)(delegate*<IServiceProvider, object>)(&XamlClosure_9.Build_5), context)
		};
		style14.Add(setter36);
		Style style15 = new Style();
		style15.Selector = ((Selector?)null).Nesting().Class(":pointerover").Template()
			.OfType(typeof(Border))
			.Name("PART_Border");
		Setter setter37 = new Setter();
		setter37.Property = Border.BackgroundProperty;
		setter37.Value = new ImmutableSolidColorBrush(4294937600u);
		style15.Add(setter37);
		style14.Add(style15);
		Style style16 = new Style();
		style16.Selector = ((Selector?)null).Nesting().Class(":checked").Template()
			.OfType(typeof(Border))
			.Name("PART_Border");
		Setter setter38 = new Setter();
		setter38.Property = Border.BackgroundProperty;
		setter38.Value = new ImmutableSolidColorBrush(4283782485u);
		style16.Add(setter38);
		Setter setter39 = new Setter();
		setter39.Property = Border.BorderBrushProperty;
		setter39.Value = new ImmutableSolidColorBrush(uint.MaxValue);
		style16.Add(setter39);
		Setter setter40 = new Setter();
		setter40.Property = Border.BorderThicknessProperty;
		setter40.Value = new Thickness(2.0, 0.0, 0.0, 0.0);
		style16.Add(setter40);
		style14.Add(style16);
		P_1.Add(style14);
		if ((object)P_1 is StyledElement styled)
		{
			NameScope.SetNameScope(styled, context.AvaloniaNameScope);
		}
		context.AvaloniaNameScope.Complete();
	}

	public static Styles Build_003A_002FStyles_002FToggleButtonStyles_002Eaxaml(IServiceProvider P_0)
	{
		Styles styles = new Styles();
		Populate_003A_002FStyles_002FToggleButtonStyles_002Eaxaml(P_0, styles);
		return styles;
	}
}
