using System;
using System.Diagnostics;
using Google.Protobuf.Collections;
using Il2CppDummyDll;

namespace Google.Protobuf.Reflection
{
	// Token: 0x02000BA6 RID: 2982
	[Token(Token = "0x2000BA6")]
	public sealed class EnumOptions : IExtendableMessage<EnumOptions>, IMessage<EnumOptions>, IMessage, IEquatable<EnumOptions>, IDeepCloneable<EnumOptions>
	{
		// Token: 0x17000964 RID: 2404
		// (get) Token: 0x06007274 RID: 29300 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000964")]
		private ExtensionSet<EnumOptions> _Extensions
		{
			[Token(Token = "0x6007274")]
			[Address(RVA = "0x3200500", Offset = "0x3200500", VA = "0x3200500")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000965 RID: 2405
		// (get) Token: 0x06007275 RID: 29301 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000965")]
		[DebuggerNonUserCode]
		public static MessageParser<EnumOptions> Parser
		{
			[Token(Token = "0x6007275")]
			[Address(RVA = "0x3200508", Offset = "0x3200508", VA = "0x3200508")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000966 RID: 2406
		// (get) Token: 0x06007276 RID: 29302 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000966")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Token(Token = "0x6007276")]
			[Address(RVA = "0x3200560", Offset = "0x3200560", VA = "0x3200560")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000967 RID: 2407
		// (get) Token: 0x06007277 RID: 29303 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000967")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Token(Token = "0x6007277")]
			[Address(RVA = "0x3200664", Offset = "0x3200664", VA = "0x3200664", Slot = "15")]
			get
			{
				return null;
			}
		}

		// Token: 0x06007278 RID: 29304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007278")]
		[Address(RVA = "0x31F6D50", Offset = "0x31F6D50", VA = "0x31F6D50")]
		[DebuggerNonUserCode]
		public EnumOptions()
		{
		}

		// Token: 0x06007279 RID: 29305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007279")]
		[Address(RVA = "0x32006B0", Offset = "0x32006B0", VA = "0x32006B0")]
		[DebuggerNonUserCode]
		public EnumOptions(EnumOptions other)
		{
		}

		// Token: 0x0600727A RID: 29306 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600727A")]
		[Address(RVA = "0x31F6410", Offset = "0x31F6410", VA = "0x31F6410", Slot = "17")]
		[DebuggerNonUserCode]
		public EnumOptions Clone()
		{
			return null;
		}

		// Token: 0x17000968 RID: 2408
		// (get) Token: 0x0600727B RID: 29307 RVA: 0x00050CD0 File Offset: 0x0004EED0
		// (set) Token: 0x0600727C RID: 29308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000968")]
		[DebuggerNonUserCode]
		public bool AllowAlias
		{
			[Token(Token = "0x600727B")]
			[Address(RVA = "0x3200784", Offset = "0x3200784", VA = "0x3200784")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600727C")]
			[Address(RVA = "0x32007F4", Offset = "0x32007F4", VA = "0x32007F4")]
			set
			{
			}
		}

		// Token: 0x17000969 RID: 2409
		// (get) Token: 0x0600727D RID: 29309 RVA: 0x00050CE8 File Offset: 0x0004EEE8
		[Token(Token = "0x17000969")]
		[DebuggerNonUserCode]
		public bool HasAllowAlias
		{
			[Token(Token = "0x600727D")]
			[Address(RVA = "0x320080C", Offset = "0x320080C", VA = "0x320080C")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600727E RID: 29310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600727E")]
		[Address(RVA = "0x3200818", Offset = "0x3200818", VA = "0x3200818")]
		[DebuggerNonUserCode]
		public void ClearAllowAlias()
		{
		}

		// Token: 0x1700096A RID: 2410
		// (get) Token: 0x0600727F RID: 29311 RVA: 0x00050D00 File Offset: 0x0004EF00
		// (set) Token: 0x06007280 RID: 29312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700096A")]
		[DebuggerNonUserCode]
		public bool Deprecated
		{
			[Token(Token = "0x600727F")]
			[Address(RVA = "0x3200828", Offset = "0x3200828", VA = "0x3200828")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6007280")]
			[Address(RVA = "0x3200898", Offset = "0x3200898", VA = "0x3200898")]
			set
			{
			}
		}

		// Token: 0x1700096B RID: 2411
		// (get) Token: 0x06007281 RID: 29313 RVA: 0x00050D18 File Offset: 0x0004EF18
		[Token(Token = "0x1700096B")]
		[DebuggerNonUserCode]
		public bool HasDeprecated
		{
			[Token(Token = "0x6007281")]
			[Address(RVA = "0x32008B0", Offset = "0x32008B0", VA = "0x32008B0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06007282 RID: 29314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007282")]
		[Address(RVA = "0x32008BC", Offset = "0x32008BC", VA = "0x32008BC")]
		[DebuggerNonUserCode]
		public void ClearDeprecated()
		{
		}

		// Token: 0x1700096C RID: 2412
		// (get) Token: 0x06007283 RID: 29315 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700096C")]
		[DebuggerNonUserCode]
		public RepeatedField<UninterpretedOption> UninterpretedOption
		{
			[Token(Token = "0x6007283")]
			[Address(RVA = "0x32008CC", Offset = "0x32008CC", VA = "0x32008CC")]
			get
			{
				return null;
			}
		}

		// Token: 0x06007284 RID: 29316 RVA: 0x00050D30 File Offset: 0x0004EF30
		[Token(Token = "0x6007284")]
		[Address(RVA = "0x32008D4", Offset = "0x32008D4", VA = "0x32008D4", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06007285 RID: 29317 RVA: 0x00050D48 File Offset: 0x0004EF48
		[Token(Token = "0x6007285")]
		[Address(RVA = "0x3200938", Offset = "0x3200938", VA = "0x3200938", Slot = "16")]
		[DebuggerNonUserCode]
		public bool Equals(EnumOptions other)
		{
			return default(bool);
		}

		// Token: 0x06007286 RID: 29318 RVA: 0x00050D60 File Offset: 0x0004EF60
		[Token(Token = "0x6007286")]
		[Address(RVA = "0x3200A14", Offset = "0x3200A14", VA = "0x3200A14", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06007287 RID: 29319 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007287")]
		[Address(RVA = "0x3200B38", Offset = "0x3200B38", VA = "0x3200B38", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06007288 RID: 29320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007288")]
		[Address(RVA = "0x3200B90", Offset = "0x3200B90", VA = "0x3200B90", Slot = "13")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06007289 RID: 29321 RVA: 0x00050D78 File Offset: 0x0004EF78
		[Token(Token = "0x6007289")]
		[Address(RVA = "0x3200CD8", Offset = "0x3200CD8", VA = "0x3200CD8", Slot = "14")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600728A RID: 29322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600728A")]
		[Address(RVA = "0x31F6DD8", Offset = "0x31F6DD8", VA = "0x31F6DD8", Slot = "11")]
		[DebuggerNonUserCode]
		public void MergeFrom(EnumOptions other)
		{
		}

		// Token: 0x0600728B RID: 29323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600728B")]
		[Address(RVA = "0x3200DC4", Offset = "0x3200DC4", VA = "0x3200DC4", Slot = "12")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600728C RID: 29324 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600728C")]
		public TValue GetExtension<TValue>(Extension<EnumOptions, TValue> extension)
		{
			return null;
		}

		// Token: 0x0600728D RID: 29325 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600728D")]
		public RepeatedField<TValue> GetExtension<TValue>(RepeatedExtension<EnumOptions, TValue> extension)
		{
			return null;
		}

		// Token: 0x0600728E RID: 29326 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600728E")]
		public RepeatedField<TValue> GetOrInitializeExtension<TValue>(RepeatedExtension<EnumOptions, TValue> extension)
		{
			return null;
		}

		// Token: 0x0600728F RID: 29327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600728F")]
		public void SetExtension<TValue>(Extension<EnumOptions, TValue> extension, TValue value)
		{
		}

		// Token: 0x06007290 RID: 29328 RVA: 0x00050D90 File Offset: 0x0004EF90
		[Token(Token = "0x6007290")]
		public bool HasExtension<TValue>(Extension<EnumOptions, TValue> extension)
		{
			return default(bool);
		}

		// Token: 0x06007291 RID: 29329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007291")]
		public void ClearExtension<TValue>(Extension<EnumOptions, TValue> extension)
		{
		}

		// Token: 0x06007292 RID: 29330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007292")]
		public void ClearExtension<TValue>(RepeatedExtension<EnumOptions, TValue> extension)
		{
		}

		// Token: 0x04002E82 RID: 11906
		[Token(Token = "0x4002E82")]
		[FieldOffset(Offset = "0x0")]
		private static readonly MessageParser<EnumOptions> _parser;

		// Token: 0x04002E83 RID: 11907
		[Token(Token = "0x4002E83")]
		[FieldOffset(Offset = "0x10")]
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002E84 RID: 11908
		[Token(Token = "0x4002E84")]
		[FieldOffset(Offset = "0x18")]
		internal ExtensionSet<EnumOptions> _extensions;

		// Token: 0x04002E85 RID: 11909
		[Token(Token = "0x4002E85")]
		[FieldOffset(Offset = "0x20")]
		private int _hasBits0;

		// Token: 0x04002E86 RID: 11910
		[Token(Token = "0x4002E86")]
		public const int AllowAliasFieldNumber = 2;

		// Token: 0x04002E87 RID: 11911
		[Token(Token = "0x4002E87")]
		[FieldOffset(Offset = "0x8")]
		private static readonly bool AllowAliasDefaultValue;

		// Token: 0x04002E88 RID: 11912
		[Token(Token = "0x4002E88")]
		[FieldOffset(Offset = "0x24")]
		private bool allowAlias_;

		// Token: 0x04002E89 RID: 11913
		[Token(Token = "0x4002E89")]
		public const int DeprecatedFieldNumber = 3;

		// Token: 0x04002E8A RID: 11914
		[Token(Token = "0x4002E8A")]
		[FieldOffset(Offset = "0x9")]
		private static readonly bool DeprecatedDefaultValue;

		// Token: 0x04002E8B RID: 11915
		[Token(Token = "0x4002E8B")]
		[FieldOffset(Offset = "0x25")]
		private bool deprecated_;

		// Token: 0x04002E8C RID: 11916
		[Token(Token = "0x4002E8C")]
		public const int UninterpretedOptionFieldNumber = 999;

		// Token: 0x04002E8D RID: 11917
		[Token(Token = "0x4002E8D")]
		[FieldOffset(Offset = "0x10")]
		private static readonly FieldCodec<UninterpretedOption> _repeated_uninterpretedOption_codec;

		// Token: 0x04002E8E RID: 11918
		[Token(Token = "0x4002E8E")]
		[FieldOffset(Offset = "0x28")]
		private readonly RepeatedField<UninterpretedOption> uninterpretedOption_;
	}
}
