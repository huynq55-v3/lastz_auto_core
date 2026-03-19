using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Google.Protobuf
{
	// Token: 0x02000B1A RID: 2842
	[Token(Token = "0x2000B1A")]
	public sealed class JsonParser
	{
		// Token: 0x06006C69 RID: 27753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C69")]
		[Address(RVA = "0x36E6AA8", Offset = "0x36E6AA8", VA = "0x36E6AA8")]
		private static void MergeWrapperField(JsonParser parser, IMessage message, JsonTokenizer tokenizer)
		{
		}

		// Token: 0x170007D1 RID: 2001
		// (get) Token: 0x06006C6A RID: 27754 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007D1")]
		public static JsonParser Default
		{
			[Token(Token = "0x6006C6A")]
			[Address(RVA = "0x36E6DD4", Offset = "0x36E6DD4", VA = "0x36E6DD4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006C6B RID: 27755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C6B")]
		[Address(RVA = "0x36E6E2C", Offset = "0x36E6E2C", VA = "0x36E6E2C")]
		public JsonParser(JsonParser.Settings settings)
		{
		}

		// Token: 0x06006C6C RID: 27756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C6C")]
		[Address(RVA = "0x36E6E5C", Offset = "0x36E6E5C", VA = "0x36E6E5C")]
		internal void Merge(IMessage message, string json)
		{
		}

		// Token: 0x06006C6D RID: 27757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C6D")]
		[Address(RVA = "0x36E6ED8", Offset = "0x36E6ED8", VA = "0x36E6ED8")]
		internal void Merge(IMessage message, TextReader jsonReader)
		{
		}

		// Token: 0x06006C6E RID: 27758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C6E")]
		[Address(RVA = "0x36E7058", Offset = "0x36E7058", VA = "0x36E7058")]
		private void Merge(IMessage message, JsonTokenizer tokenizer)
		{
		}

		// Token: 0x06006C6F RID: 27759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C6F")]
		[Address(RVA = "0x36E6B88", Offset = "0x36E6B88", VA = "0x36E6B88")]
		private void MergeField(IMessage message, FieldDescriptor field, JsonTokenizer tokenizer)
		{
		}

		// Token: 0x06006C70 RID: 27760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C70")]
		[Address(RVA = "0x36E7AE8", Offset = "0x36E7AE8", VA = "0x36E7AE8")]
		private void MergeRepeatedField(IMessage message, FieldDescriptor field, JsonTokenizer tokenizer)
		{
		}

		// Token: 0x06006C71 RID: 27761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C71")]
		[Address(RVA = "0x36E77D0", Offset = "0x36E77D0", VA = "0x36E77D0")]
		private void MergeMapField(IMessage message, FieldDescriptor field, JsonTokenizer tokenizer)
		{
		}

		// Token: 0x06006C72 RID: 27762 RVA: 0x0004E870 File Offset: 0x0004CA70
		[Token(Token = "0x6006C72")]
		[Address(RVA = "0x36E7680", Offset = "0x36E7680", VA = "0x36E7680")]
		private static bool IsGoogleProtobufValueField(FieldDescriptor field)
		{
			return default(bool);
		}

		// Token: 0x06006C73 RID: 27763 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C73")]
		[Address(RVA = "0x36E7DA0", Offset = "0x36E7DA0", VA = "0x36E7DA0")]
		private object ParseSingleValue(FieldDescriptor field, JsonTokenizer tokenizer)
		{
			return null;
		}

		// Token: 0x06006C74 RID: 27764 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C74")]
		public T Parse<T>(string json) where T : IMessage, new()
		{
			return null;
		}

		// Token: 0x06006C75 RID: 27765 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C75")]
		public T Parse<T>(TextReader jsonReader) where T : IMessage, new()
		{
			return null;
		}

		// Token: 0x06006C76 RID: 27766 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C76")]
		[Address(RVA = "0x36E9224", Offset = "0x36E9224", VA = "0x36E9224")]
		public IMessage Parse(string json, MessageDescriptor descriptor)
		{
			return null;
		}

		// Token: 0x06006C77 RID: 27767 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C77")]
		[Address(RVA = "0x36E9320", Offset = "0x36E9320", VA = "0x36E9320")]
		public IMessage Parse(TextReader jsonReader, MessageDescriptor descriptor)
		{
			return null;
		}

		// Token: 0x06006C78 RID: 27768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C78")]
		[Address(RVA = "0x36E941C", Offset = "0x36E941C", VA = "0x36E941C")]
		private void MergeStructValue(IMessage message, JsonTokenizer tokenizer)
		{
		}

		// Token: 0x06006C79 RID: 27769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C79")]
		[Address(RVA = "0x36E9998", Offset = "0x36E9998", VA = "0x36E9998")]
		private void MergeStruct(IMessage message, JsonTokenizer tokenizer)
		{
		}

		// Token: 0x06006C7A RID: 27770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C7A")]
		[Address(RVA = "0x36E9AE4", Offset = "0x36E9AE4", VA = "0x36E9AE4")]
		private void MergeAny(IMessage message, JsonTokenizer tokenizer)
		{
		}

		// Token: 0x06006C7B RID: 27771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C7B")]
		[Address(RVA = "0x36EA0BC", Offset = "0x36EA0BC", VA = "0x36EA0BC")]
		private void MergeWellKnownTypeAnyBody(IMessage body, JsonTokenizer tokenizer)
		{
		}

		// Token: 0x06006C7C RID: 27772 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C7C")]
		[Address(RVA = "0x36E80EC", Offset = "0x36E80EC", VA = "0x36E80EC")]
		private static object ParseMapKey(FieldDescriptor field, string keyText)
		{
			return null;
		}

		// Token: 0x06006C7D RID: 27773 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C7D")]
		[Address(RVA = "0x36E8C1C", Offset = "0x36E8C1C", VA = "0x36E8C1C")]
		private static object ParseSingleNumberValue(FieldDescriptor field, JsonToken token)
		{
			return null;
		}

		// Token: 0x06006C7E RID: 27774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C7E")]
		[Address(RVA = "0x36EA1DC", Offset = "0x36EA1DC", VA = "0x36EA1DC")]
		private static void CheckInteger(double value)
		{
		}

		// Token: 0x06006C7F RID: 27775 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C7F")]
		[Address(RVA = "0x36E8538", Offset = "0x36E8538", VA = "0x36E8538")]
		private static object ParseSingleStringValue(FieldDescriptor field, string text)
		{
			return null;
		}

		// Token: 0x06006C80 RID: 27776 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C80")]
		[Address(RVA = "0x36E84FC", Offset = "0x36E84FC", VA = "0x36E84FC")]
		private static IMessage NewMessageForField(FieldDescriptor field)
		{
			return null;
		}

		// Token: 0x06006C81 RID: 27777 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C81")]
		private static T ParseNumericString<T>(string text, Func<string, NumberStyles, IFormatProvider, T> parser)
		{
			return null;
		}

		// Token: 0x06006C82 RID: 27778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C82")]
		[Address(RVA = "0x36EA340", Offset = "0x36EA340", VA = "0x36EA340")]
		private static void ValidateInfinityAndNan(string text, bool isPositiveInfinity, bool isNegativeInfinity, bool isNaN)
		{
		}

		// Token: 0x06006C83 RID: 27779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C83")]
		[Address(RVA = "0x36EA45C", Offset = "0x36EA45C", VA = "0x36EA45C")]
		private static void MergeTimestamp(IMessage message, JsonToken token)
		{
		}

		// Token: 0x06006C84 RID: 27780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C84")]
		[Address(RVA = "0x36EAE50", Offset = "0x36EAE50", VA = "0x36EAE50")]
		private static void MergeDuration(IMessage message, JsonToken token)
		{
		}

		// Token: 0x06006C85 RID: 27781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C85")]
		[Address(RVA = "0x36EB588", Offset = "0x36EB588", VA = "0x36EB588")]
		private static void MergeFieldMask(IMessage message, JsonToken token)
		{
		}

		// Token: 0x06006C86 RID: 27782 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C86")]
		[Address(RVA = "0x36EB880", Offset = "0x36EB880", VA = "0x36EB880")]
		private static string ToSnakeCase(string text)
		{
			return null;
		}

		// Token: 0x04002B8E RID: 11150
		[Token(Token = "0x4002B8E")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Regex TimestampRegex;

		// Token: 0x04002B8F RID: 11151
		[Token(Token = "0x4002B8F")]
		[FieldOffset(Offset = "0x8")]
		private static readonly Regex DurationRegex;

		// Token: 0x04002B90 RID: 11152
		[Token(Token = "0x4002B90")]
		[FieldOffset(Offset = "0x10")]
		private static readonly int[] SubsecondScalingFactors;

		// Token: 0x04002B91 RID: 11153
		[Token(Token = "0x4002B91")]
		[FieldOffset(Offset = "0x18")]
		private static readonly char[] FieldMaskPathSeparators;

		// Token: 0x04002B92 RID: 11154
		[Token(Token = "0x4002B92")]
		[FieldOffset(Offset = "0x20")]
		private static readonly JsonParser defaultInstance;

		// Token: 0x04002B93 RID: 11155
		[Token(Token = "0x4002B93")]
		[FieldOffset(Offset = "0x28")]
		private static readonly Dictionary<string, Action<JsonParser, IMessage, JsonTokenizer>> WellKnownTypeHandlers;

		// Token: 0x04002B94 RID: 11156
		[Token(Token = "0x4002B94")]
		[FieldOffset(Offset = "0x10")]
		private readonly JsonParser.Settings settings;

		// Token: 0x02000B1B RID: 2843
		[Token(Token = "0x2000B1B")]
		public sealed class Settings
		{
			// Token: 0x170007D2 RID: 2002
			// (get) Token: 0x06006C88 RID: 27784 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170007D2")]
			public static JsonParser.Settings Default
			{
				[Token(Token = "0x6006C88")]
				[Address(RVA = "0x36EC4D8", Offset = "0x36EC4D8", VA = "0x36EC4D8")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x170007D3 RID: 2003
			// (get) Token: 0x06006C8A RID: 27786 RVA: 0x0004E888 File Offset: 0x0004CA88
			[Token(Token = "0x170007D3")]
			public int RecursionLimit
			{
				[Token(Token = "0x6006C8A")]
				[Address(RVA = "0x36EC644", Offset = "0x36EC644", VA = "0x36EC644")]
				[CompilerGenerated]
				get
				{
					return 0;
				}
			}

			// Token: 0x170007D4 RID: 2004
			// (get) Token: 0x06006C8B RID: 27787 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170007D4")]
			public TypeRegistry TypeRegistry
			{
				[Token(Token = "0x6006C8B")]
				[Address(RVA = "0x36EC64C", Offset = "0x36EC64C", VA = "0x36EC64C")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x170007D5 RID: 2005
			// (get) Token: 0x06006C8C RID: 27788 RVA: 0x0004E8A0 File Offset: 0x0004CAA0
			[Token(Token = "0x170007D5")]
			public bool IgnoreUnknownFields
			{
				[Token(Token = "0x6006C8C")]
				[Address(RVA = "0x36EC654", Offset = "0x36EC654", VA = "0x36EC654")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06006C8D RID: 27789 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006C8D")]
			[Address(RVA = "0x36EC65C", Offset = "0x36EC65C", VA = "0x36EC65C")]
			private Settings(int recursionLimit, TypeRegistry typeRegistry, bool ignoreUnknownFields)
			{
			}

			// Token: 0x06006C8E RID: 27790 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006C8E")]
			[Address(RVA = "0x36EC5A0", Offset = "0x36EC5A0", VA = "0x36EC5A0")]
			public Settings(int recursionLimit)
			{
			}

			// Token: 0x06006C8F RID: 27791 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006C8F")]
			[Address(RVA = "0x36EC700", Offset = "0x36EC700", VA = "0x36EC700")]
			public Settings(int recursionLimit, TypeRegistry typeRegistry)
			{
			}

			// Token: 0x06006C90 RID: 27792 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006C90")]
			[Address(RVA = "0x36EC708", Offset = "0x36EC708", VA = "0x36EC708")]
			public JsonParser.Settings WithIgnoreUnknownFields(bool ignoreUnknownFields)
			{
				return null;
			}

			// Token: 0x06006C91 RID: 27793 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006C91")]
			[Address(RVA = "0x36EC784", Offset = "0x36EC784", VA = "0x36EC784")]
			public JsonParser.Settings WithRecursionLimit(int recursionLimit)
			{
				return null;
			}

			// Token: 0x06006C92 RID: 27794 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006C92")]
			[Address(RVA = "0x36EC804", Offset = "0x36EC804", VA = "0x36EC804")]
			public JsonParser.Settings WithTypeRegistry(TypeRegistry typeRegistry)
			{
				return null;
			}
		}
	}
}
