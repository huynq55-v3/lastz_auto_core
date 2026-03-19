using System;
using System.Diagnostics;
using Google.Protobuf.Collections;
using Il2CppDummyDll;

namespace Google.Protobuf.Reflection
{
	// Token: 0x02000BA8 RID: 2984
	[Token(Token = "0x2000BA8")]
	public sealed class EnumValueOptions : IExtendableMessage<EnumValueOptions>, IMessage<EnumValueOptions>, IMessage, IEquatable<EnumValueOptions>, IDeepCloneable<EnumValueOptions>
	{
		// Token: 0x1700096D RID: 2413
		// (get) Token: 0x06007297 RID: 29335 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700096D")]
		private ExtensionSet<EnumValueOptions> _Extensions
		{
			[Token(Token = "0x6007297")]
			[Address(RVA = "0x31A0E28", Offset = "0x31A0E28", VA = "0x31A0E28")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700096E RID: 2414
		// (get) Token: 0x06007298 RID: 29336 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700096E")]
		[DebuggerNonUserCode]
		public static MessageParser<EnumValueOptions> Parser
		{
			[Token(Token = "0x6007298")]
			[Address(RVA = "0x31A0E30", Offset = "0x31A0E30", VA = "0x31A0E30")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700096F RID: 2415
		// (get) Token: 0x06007299 RID: 29337 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700096F")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Token(Token = "0x6007299")]
			[Address(RVA = "0x31A0E88", Offset = "0x31A0E88", VA = "0x31A0E88")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000970 RID: 2416
		// (get) Token: 0x0600729A RID: 29338 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000970")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Token(Token = "0x600729A")]
			[Address(RVA = "0x31A0F8C", Offset = "0x31A0F8C", VA = "0x31A0F8C", Slot = "15")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600729B RID: 29339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600729B")]
		[Address(RVA = "0x31A0FD8", Offset = "0x31A0FD8", VA = "0x31A0FD8")]
		[DebuggerNonUserCode]
		public EnumValueOptions()
		{
		}

		// Token: 0x0600729C RID: 29340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600729C")]
		[Address(RVA = "0x31A1060", Offset = "0x31A1060", VA = "0x31A1060")]
		[DebuggerNonUserCode]
		public EnumValueOptions(EnumValueOptions other)
		{
		}

		// Token: 0x0600729D RID: 29341 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600729D")]
		[Address(RVA = "0x31A112C", Offset = "0x31A112C", VA = "0x31A112C", Slot = "17")]
		[DebuggerNonUserCode]
		public EnumValueOptions Clone()
		{
			return null;
		}

		// Token: 0x17000971 RID: 2417
		// (get) Token: 0x0600729E RID: 29342 RVA: 0x00050DA8 File Offset: 0x0004EFA8
		// (set) Token: 0x0600729F RID: 29343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000971")]
		[DebuggerNonUserCode]
		public bool Deprecated
		{
			[Token(Token = "0x600729E")]
			[Address(RVA = "0x31A118C", Offset = "0x31A118C", VA = "0x31A118C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600729F")]
			[Address(RVA = "0x31A11FC", Offset = "0x31A11FC", VA = "0x31A11FC")]
			set
			{
			}
		}

		// Token: 0x17000972 RID: 2418
		// (get) Token: 0x060072A0 RID: 29344 RVA: 0x00050DC0 File Offset: 0x0004EFC0
		[Token(Token = "0x17000972")]
		[DebuggerNonUserCode]
		public bool HasDeprecated
		{
			[Token(Token = "0x60072A0")]
			[Address(RVA = "0x31A1214", Offset = "0x31A1214", VA = "0x31A1214")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060072A1 RID: 29345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60072A1")]
		[Address(RVA = "0x31A1220", Offset = "0x31A1220", VA = "0x31A1220")]
		[DebuggerNonUserCode]
		public void ClearDeprecated()
		{
		}

		// Token: 0x17000973 RID: 2419
		// (get) Token: 0x060072A2 RID: 29346 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000973")]
		[DebuggerNonUserCode]
		public RepeatedField<UninterpretedOption> UninterpretedOption
		{
			[Token(Token = "0x60072A2")]
			[Address(RVA = "0x31A1230", Offset = "0x31A1230", VA = "0x31A1230")]
			get
			{
				return null;
			}
		}

		// Token: 0x060072A3 RID: 29347 RVA: 0x00050DD8 File Offset: 0x0004EFD8
		[Token(Token = "0x60072A3")]
		[Address(RVA = "0x31A1238", Offset = "0x31A1238", VA = "0x31A1238", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x060072A4 RID: 29348 RVA: 0x00050DF0 File Offset: 0x0004EFF0
		[Token(Token = "0x60072A4")]
		[Address(RVA = "0x31A129C", Offset = "0x31A129C", VA = "0x31A129C", Slot = "16")]
		[DebuggerNonUserCode]
		public bool Equals(EnumValueOptions other)
		{
			return default(bool);
		}

		// Token: 0x060072A5 RID: 29349 RVA: 0x00050E08 File Offset: 0x0004F008
		[Token(Token = "0x60072A5")]
		[Address(RVA = "0x31A135C", Offset = "0x31A135C", VA = "0x31A135C", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060072A6 RID: 29350 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072A6")]
		[Address(RVA = "0x31A1438", Offset = "0x31A1438", VA = "0x31A1438", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060072A7 RID: 29351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60072A7")]
		[Address(RVA = "0x31A1490", Offset = "0x31A1490", VA = "0x31A1490", Slot = "13")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060072A8 RID: 29352 RVA: 0x00050E20 File Offset: 0x0004F020
		[Token(Token = "0x60072A8")]
		[Address(RVA = "0x31A15A4", Offset = "0x31A15A4", VA = "0x31A15A4", Slot = "14")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060072A9 RID: 29353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60072A9")]
		[Address(RVA = "0x31A1684", Offset = "0x31A1684", VA = "0x31A1684", Slot = "11")]
		[DebuggerNonUserCode]
		public void MergeFrom(EnumValueOptions other)
		{
		}

		// Token: 0x060072AA RID: 29354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60072AA")]
		[Address(RVA = "0x31A1754", Offset = "0x31A1754", VA = "0x31A1754", Slot = "12")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060072AB RID: 29355 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072AB")]
		public TValue GetExtension<TValue>(Extension<EnumValueOptions, TValue> extension)
		{
			return null;
		}

		// Token: 0x060072AC RID: 29356 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072AC")]
		public RepeatedField<TValue> GetExtension<TValue>(RepeatedExtension<EnumValueOptions, TValue> extension)
		{
			return null;
		}

		// Token: 0x060072AD RID: 29357 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072AD")]
		public RepeatedField<TValue> GetOrInitializeExtension<TValue>(RepeatedExtension<EnumValueOptions, TValue> extension)
		{
			return null;
		}

		// Token: 0x060072AE RID: 29358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60072AE")]
		public void SetExtension<TValue>(Extension<EnumValueOptions, TValue> extension, TValue value)
		{
		}

		// Token: 0x060072AF RID: 29359 RVA: 0x00050E38 File Offset: 0x0004F038
		[Token(Token = "0x60072AF")]
		public bool HasExtension<TValue>(Extension<EnumValueOptions, TValue> extension)
		{
			return default(bool);
		}

		// Token: 0x060072B0 RID: 29360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60072B0")]
		public void ClearExtension<TValue>(Extension<EnumValueOptions, TValue> extension)
		{
		}

		// Token: 0x060072B1 RID: 29361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60072B1")]
		public void ClearExtension<TValue>(RepeatedExtension<EnumValueOptions, TValue> extension)
		{
		}

		// Token: 0x04002E90 RID: 11920
		[Token(Token = "0x4002E90")]
		[FieldOffset(Offset = "0x0")]
		private static readonly MessageParser<EnumValueOptions> _parser;

		// Token: 0x04002E91 RID: 11921
		[Token(Token = "0x4002E91")]
		[FieldOffset(Offset = "0x10")]
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002E92 RID: 11922
		[Token(Token = "0x4002E92")]
		[FieldOffset(Offset = "0x18")]
		internal ExtensionSet<EnumValueOptions> _extensions;

		// Token: 0x04002E93 RID: 11923
		[Token(Token = "0x4002E93")]
		[FieldOffset(Offset = "0x20")]
		private int _hasBits0;

		// Token: 0x04002E94 RID: 11924
		[Token(Token = "0x4002E94")]
		public const int DeprecatedFieldNumber = 1;

		// Token: 0x04002E95 RID: 11925
		[Token(Token = "0x4002E95")]
		[FieldOffset(Offset = "0x8")]
		private static readonly bool DeprecatedDefaultValue;

		// Token: 0x04002E96 RID: 11926
		[Token(Token = "0x4002E96")]
		[FieldOffset(Offset = "0x24")]
		private bool deprecated_;

		// Token: 0x04002E97 RID: 11927
		[Token(Token = "0x4002E97")]
		public const int UninterpretedOptionFieldNumber = 999;

		// Token: 0x04002E98 RID: 11928
		[Token(Token = "0x4002E98")]
		[FieldOffset(Offset = "0x10")]
		private static readonly FieldCodec<UninterpretedOption> _repeated_uninterpretedOption_codec;

		// Token: 0x04002E99 RID: 11929
		[Token(Token = "0x4002E99")]
		[FieldOffset(Offset = "0x28")]
		private readonly RepeatedField<UninterpretedOption> uninterpretedOption_;
	}
}
