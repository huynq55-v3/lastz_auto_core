using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Google.Protobuf
{
	// Token: 0x02000B16 RID: 2838
	[Token(Token = "0x2000B16")]
	public sealed class JsonFormatter
	{
		// Token: 0x170007CB RID: 1995
		// (get) Token: 0x06006C3B RID: 27707 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007CB")]
		public static JsonFormatter Default
		{
			[Token(Token = "0x6006C3B")]
			[Address(RVA = "0x36DD820", Offset = "0x36DD820", VA = "0x36DD820")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x170007CC RID: 1996
		// (get) Token: 0x06006C3D RID: 27709 RVA: 0x0004E7C8 File Offset: 0x0004C9C8
		[Token(Token = "0x170007CC")]
		private bool DiagnosticOnly
		{
			[Token(Token = "0x6006C3D")]
			[Address(RVA = "0x36E0DB8", Offset = "0x36E0DB8", VA = "0x36E0DB8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06006C3E RID: 27710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C3E")]
		[Address(RVA = "0x36E0D88", Offset = "0x36E0D88", VA = "0x36E0D88")]
		public JsonFormatter(JsonFormatter.Settings settings)
		{
		}

		// Token: 0x06006C3F RID: 27711 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C3F")]
		[Address(RVA = "0x36E0E1C", Offset = "0x36E0E1C", VA = "0x36E0E1C")]
		public string Format(IMessage message)
		{
			return null;
		}

		// Token: 0x06006C40 RID: 27712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C40")]
		[Address(RVA = "0x36E0EA0", Offset = "0x36E0EA0", VA = "0x36E0EA0")]
		public void Format(IMessage message, TextWriter writer)
		{
		}

		// Token: 0x06006C41 RID: 27713 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C41")]
		[Address(RVA = "0x36E1848", Offset = "0x36E1848", VA = "0x36E1848")]
		public static string ToDiagnosticString(IMessage message)
		{
			return null;
		}

		// Token: 0x06006C42 RID: 27714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C42")]
		[Address(RVA = "0x36E16A8", Offset = "0x36E16A8", VA = "0x36E16A8")]
		private void WriteMessage(TextWriter writer, IMessage message)
		{
		}

		// Token: 0x06006C43 RID: 27715 RVA: 0x0004E7E0 File Offset: 0x0004C9E0
		[Token(Token = "0x6006C43")]
		[Address(RVA = "0x36E194C", Offset = "0x36E194C", VA = "0x36E194C")]
		private bool WriteMessageFields(TextWriter writer, IMessage message, bool assumeFirstFieldWritten)
		{
			return default(bool);
		}

		// Token: 0x06006C44 RID: 27716 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C44")]
		[Address(RVA = "0x36E3184", Offset = "0x36E3184", VA = "0x36E3184")]
		internal static string ToJsonName(string name)
		{
			return null;
		}

		// Token: 0x06006C45 RID: 27717 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C45")]
		[Address(RVA = "0x36E32A0", Offset = "0x36E32A0", VA = "0x36E32A0")]
		internal static string FromJsonName(string name)
		{
			return null;
		}

		// Token: 0x06006C46 RID: 27718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C46")]
		[Address(RVA = "0x36E18F0", Offset = "0x36E18F0", VA = "0x36E18F0")]
		private static void WriteNull(TextWriter writer)
		{
		}

		// Token: 0x06006C47 RID: 27719 RVA: 0x0004E7F8 File Offset: 0x0004C9F8
		[Token(Token = "0x6006C47")]
		[Address(RVA = "0x36E1F64", Offset = "0x36E1F64", VA = "0x36E1F64")]
		private static bool IsDefaultValue(IFieldAccessor accessor, object value)
		{
			return default(bool);
		}

		// Token: 0x06006C48 RID: 27720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C48")]
		[Address(RVA = "0x36E2878", Offset = "0x36E2878", VA = "0x36E2878")]
		public void WriteValue(TextWriter writer, object value)
		{
		}

		// Token: 0x06006C49 RID: 27721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C49")]
		[Address(RVA = "0x36E1074", Offset = "0x36E1074", VA = "0x36E1074")]
		private void WriteWellKnownTypeValue(TextWriter writer, MessageDescriptor descriptor, object value)
		{
		}

		// Token: 0x06006C4A RID: 27722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C4A")]
		[Address(RVA = "0x36E41D4", Offset = "0x36E41D4", VA = "0x36E41D4")]
		private void WriteTimestamp(TextWriter writer, IMessage value)
		{
		}

		// Token: 0x06006C4B RID: 27723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C4B")]
		[Address(RVA = "0x36E44DC", Offset = "0x36E44DC", VA = "0x36E44DC")]
		private void WriteDuration(TextWriter writer, IMessage value)
		{
		}

		// Token: 0x06006C4C RID: 27724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C4C")]
		[Address(RVA = "0x36E47E4", Offset = "0x36E47E4", VA = "0x36E47E4")]
		private void WriteFieldMask(TextWriter writer, IMessage value)
		{
		}

		// Token: 0x06006C4D RID: 27725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C4D")]
		[Address(RVA = "0x36E55D4", Offset = "0x36E55D4", VA = "0x36E55D4")]
		private void WriteAny(TextWriter writer, IMessage value)
		{
		}

		// Token: 0x06006C4E RID: 27726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C4E")]
		[Address(RVA = "0x36E5B04", Offset = "0x36E5B04", VA = "0x36E5B04")]
		private void WriteDiagnosticOnlyAny(TextWriter writer, IMessage value)
		{
		}

		// Token: 0x06006C4F RID: 27727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C4F")]
		[Address(RVA = "0x36E49CC", Offset = "0x36E49CC", VA = "0x36E49CC")]
		private void WriteStruct(TextWriter writer, IMessage message)
		{
		}

		// Token: 0x06006C50 RID: 27728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C50")]
		[Address(RVA = "0x36E50AC", Offset = "0x36E50AC", VA = "0x36E50AC")]
		private void WriteStructFieldValue(TextWriter writer, IMessage message)
		{
		}

		// Token: 0x06006C51 RID: 27729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C51")]
		[Address(RVA = "0x36E3BCC", Offset = "0x36E3BCC", VA = "0x36E3BCC")]
		internal void WriteList(TextWriter writer, IList list)
		{
		}

		// Token: 0x06006C52 RID: 27730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C52")]
		[Address(RVA = "0x36E33C8", Offset = "0x36E33C8", VA = "0x36E33C8")]
		internal void WriteDictionary(TextWriter writer, IDictionary dictionary)
		{
		}

		// Token: 0x06006C53 RID: 27731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C53")]
		[Address(RVA = "0x36E252C", Offset = "0x36E252C", VA = "0x36E252C")]
		internal static void WriteString(TextWriter writer, string text)
		{
		}

		// Token: 0x06006C54 RID: 27732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C54")]
		[Address(RVA = "0x36E5FF4", Offset = "0x36E5FF4", VA = "0x36E5FF4")]
		private static void HexEncodeUtf16CodeUnit(TextWriter writer, char c)
		{
		}

		// Token: 0x04002B79 RID: 11129
		[Token(Token = "0x4002B79")]
		internal const string AnyTypeUrlField = "@type";

		// Token: 0x04002B7A RID: 11130
		[Token(Token = "0x4002B7A")]
		internal const string AnyDiagnosticValueField = "@value";

		// Token: 0x04002B7B RID: 11131
		[Token(Token = "0x4002B7B")]
		internal const string AnyWellKnownTypeValueField = "value";

		// Token: 0x04002B7C RID: 11132
		[Token(Token = "0x4002B7C")]
		private const string TypeUrlPrefix = "type.googleapis.com";

		// Token: 0x04002B7D RID: 11133
		[Token(Token = "0x4002B7D")]
		private const string NameValueSeparator = ": ";

		// Token: 0x04002B7E RID: 11134
		[Token(Token = "0x4002B7E")]
		private const string PropertySeparator = ", ";

		// Token: 0x04002B80 RID: 11136
		[Token(Token = "0x4002B80")]
		[FieldOffset(Offset = "0x8")]
		private static readonly JsonFormatter diagnosticFormatter;

		// Token: 0x04002B81 RID: 11137
		[Token(Token = "0x4002B81")]
		[FieldOffset(Offset = "0x10")]
		private static readonly string[] CommonRepresentations;

		// Token: 0x04002B82 RID: 11138
		[Token(Token = "0x4002B82")]
		[FieldOffset(Offset = "0x10")]
		private readonly JsonFormatter.Settings settings;

		// Token: 0x04002B83 RID: 11139
		[Token(Token = "0x4002B83")]
		private const string Hex = "0123456789abcdef";

		// Token: 0x02000B17 RID: 2839
		[Token(Token = "0x2000B17")]
		public sealed class Settings
		{
			// Token: 0x170007CD RID: 1997
			// (get) Token: 0x06006C55 RID: 27733 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170007CD")]
			public static JsonFormatter.Settings Default
			{
				[Token(Token = "0x6006C55")]
				[Address(RVA = "0x36E611C", Offset = "0x36E611C", VA = "0x36E611C")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x170007CE RID: 1998
			// (get) Token: 0x06006C57 RID: 27735 RVA: 0x0004E810 File Offset: 0x0004CA10
			[Token(Token = "0x170007CE")]
			public bool FormatDefaultValues
			{
				[Token(Token = "0x6006C57")]
				[Address(RVA = "0x36E6288", Offset = "0x36E6288", VA = "0x36E6288")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170007CF RID: 1999
			// (get) Token: 0x06006C58 RID: 27736 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170007CF")]
			public TypeRegistry TypeRegistry
			{
				[Token(Token = "0x6006C58")]
				[Address(RVA = "0x36E6290", Offset = "0x36E6290", VA = "0x36E6290")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x170007D0 RID: 2000
			// (get) Token: 0x06006C59 RID: 27737 RVA: 0x0004E828 File Offset: 0x0004CA28
			[Token(Token = "0x170007D0")]
			public bool FormatEnumsAsIntegers
			{
				[Token(Token = "0x6006C59")]
				[Address(RVA = "0x36E6298", Offset = "0x36E6298", VA = "0x36E6298")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06006C5A RID: 27738 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006C5A")]
			[Address(RVA = "0x36E61E4", Offset = "0x36E61E4", VA = "0x36E61E4")]
			public Settings(bool formatDefaultValues)
			{
			}

			// Token: 0x06006C5B RID: 27739 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006C5B")]
			[Address(RVA = "0x36E62A0", Offset = "0x36E62A0", VA = "0x36E62A0")]
			public Settings(bool formatDefaultValues, TypeRegistry typeRegistry)
			{
			}

			// Token: 0x06006C5C RID: 27740 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006C5C")]
			[Address(RVA = "0x36E62AC", Offset = "0x36E62AC", VA = "0x36E62AC")]
			private Settings(bool formatDefaultValues, TypeRegistry typeRegistry, bool formatEnumsAsIntegers)
			{
			}

			// Token: 0x06006C5D RID: 27741 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006C5D")]
			[Address(RVA = "0x36E6374", Offset = "0x36E6374", VA = "0x36E6374")]
			public JsonFormatter.Settings WithFormatDefaultValues(bool formatDefaultValues)
			{
				return null;
			}

			// Token: 0x06006C5E RID: 27742 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006C5E")]
			[Address(RVA = "0x36E63F4", Offset = "0x36E63F4", VA = "0x36E63F4")]
			public JsonFormatter.Settings WithTypeRegistry(TypeRegistry typeRegistry)
			{
				return null;
			}

			// Token: 0x06006C5F RID: 27743 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006C5F")]
			[Address(RVA = "0x36E6478", Offset = "0x36E6478", VA = "0x36E6478")]
			public JsonFormatter.Settings WithFormatEnumsAsIntegers(bool formatEnumsAsIntegers)
			{
				return null;
			}
		}

		// Token: 0x02000B18 RID: 2840
		[Token(Token = "0x2000B18")]
		private static class OriginalEnumValueHelper
		{
			// Token: 0x06006C60 RID: 27744 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006C60")]
			[Address(RVA = "0x36E3FB8", Offset = "0x36E3FB8", VA = "0x36E3FB8")]
			internal static string GetOriginalName(object value)
			{
				return null;
			}

			// Token: 0x06006C61 RID: 27745 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006C61")]
			[Address(RVA = "0x36E64F8", Offset = "0x36E64F8", VA = "0x36E64F8")]
			private static Dictionary<object, string> GetNameMapping(Type enumType)
			{
				return null;
			}

			// Token: 0x04002B88 RID: 11144
			[Token(Token = "0x4002B88")]
			[FieldOffset(Offset = "0x0")]
			private static readonly Dictionary<Type, Dictionary<object, string>> dictionaries;
		}
	}
}
