using System;
using System.Diagnostics;
using Google.Protobuf.Collections;
using Il2CppDummyDll;

namespace Google.Protobuf.Reflection
{
	// Token: 0x02000BAC RID: 2988
	[Token(Token = "0x2000BAC")]
	public sealed class MethodOptions : IExtendableMessage<MethodOptions>, IMessage<MethodOptions>, IMessage, IEquatable<MethodOptions>, IDeepCloneable<MethodOptions>
	{
		// Token: 0x1700097B RID: 2427
		// (get) Token: 0x060072D5 RID: 29397 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700097B")]
		private ExtensionSet<MethodOptions> _Extensions
		{
			[Token(Token = "0x60072D5")]
			[Address(RVA = "0x31A2840", Offset = "0x31A2840", VA = "0x31A2840")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700097C RID: 2428
		// (get) Token: 0x060072D6 RID: 29398 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700097C")]
		[DebuggerNonUserCode]
		public static MessageParser<MethodOptions> Parser
		{
			[Token(Token = "0x60072D6")]
			[Address(RVA = "0x31A2848", Offset = "0x31A2848", VA = "0x31A2848")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700097D RID: 2429
		// (get) Token: 0x060072D7 RID: 29399 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700097D")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Token(Token = "0x60072D7")]
			[Address(RVA = "0x31A28A0", Offset = "0x31A28A0", VA = "0x31A28A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700097E RID: 2430
		// (get) Token: 0x060072D8 RID: 29400 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700097E")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Token(Token = "0x60072D8")]
			[Address(RVA = "0x31A29A4", Offset = "0x31A29A4", VA = "0x31A29A4", Slot = "15")]
			get
			{
				return null;
			}
		}

		// Token: 0x060072D9 RID: 29401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60072D9")]
		[Address(RVA = "0x31A29F0", Offset = "0x31A29F0", VA = "0x31A29F0")]
		[DebuggerNonUserCode]
		public MethodOptions()
		{
		}

		// Token: 0x060072DA RID: 29402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60072DA")]
		[Address(RVA = "0x31A2A78", Offset = "0x31A2A78", VA = "0x31A2A78")]
		[DebuggerNonUserCode]
		public MethodOptions(MethodOptions other)
		{
		}

		// Token: 0x060072DB RID: 29403 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072DB")]
		[Address(RVA = "0x31A2B4C", Offset = "0x31A2B4C", VA = "0x31A2B4C", Slot = "17")]
		[DebuggerNonUserCode]
		public MethodOptions Clone()
		{
			return null;
		}

		// Token: 0x1700097F RID: 2431
		// (get) Token: 0x060072DC RID: 29404 RVA: 0x00050EF8 File Offset: 0x0004F0F8
		// (set) Token: 0x060072DD RID: 29405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700097F")]
		[DebuggerNonUserCode]
		public bool Deprecated
		{
			[Token(Token = "0x60072DC")]
			[Address(RVA = "0x31A2BAC", Offset = "0x31A2BAC", VA = "0x31A2BAC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60072DD")]
			[Address(RVA = "0x31A2C1C", Offset = "0x31A2C1C", VA = "0x31A2C1C")]
			set
			{
			}
		}

		// Token: 0x17000980 RID: 2432
		// (get) Token: 0x060072DE RID: 29406 RVA: 0x00050F10 File Offset: 0x0004F110
		[Token(Token = "0x17000980")]
		[DebuggerNonUserCode]
		public bool HasDeprecated
		{
			[Token(Token = "0x60072DE")]
			[Address(RVA = "0x31A2C34", Offset = "0x31A2C34", VA = "0x31A2C34")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060072DF RID: 29407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60072DF")]
		[Address(RVA = "0x31A2C40", Offset = "0x31A2C40", VA = "0x31A2C40")]
		[DebuggerNonUserCode]
		public void ClearDeprecated()
		{
		}

		// Token: 0x17000981 RID: 2433
		// (get) Token: 0x060072E0 RID: 29408 RVA: 0x00050F28 File Offset: 0x0004F128
		// (set) Token: 0x060072E1 RID: 29409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000981")]
		[DebuggerNonUserCode]
		public MethodOptions.Types.IdempotencyLevel IdempotencyLevel
		{
			[Token(Token = "0x60072E0")]
			[Address(RVA = "0x31A2C50", Offset = "0x31A2C50", VA = "0x31A2C50")]
			get
			{
				return MethodOptions.Types.IdempotencyLevel.IdempotencyUnknown;
			}
			[Token(Token = "0x60072E1")]
			[Address(RVA = "0x31A2CC0", Offset = "0x31A2CC0", VA = "0x31A2CC0")]
			set
			{
			}
		}

		// Token: 0x17000982 RID: 2434
		// (get) Token: 0x060072E2 RID: 29410 RVA: 0x00050F40 File Offset: 0x0004F140
		[Token(Token = "0x17000982")]
		[DebuggerNonUserCode]
		public bool HasIdempotencyLevel
		{
			[Token(Token = "0x60072E2")]
			[Address(RVA = "0x31A2CD4", Offset = "0x31A2CD4", VA = "0x31A2CD4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060072E3 RID: 29411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60072E3")]
		[Address(RVA = "0x31A2CE0", Offset = "0x31A2CE0", VA = "0x31A2CE0")]
		[DebuggerNonUserCode]
		public void ClearIdempotencyLevel()
		{
		}

		// Token: 0x17000983 RID: 2435
		// (get) Token: 0x060072E4 RID: 29412 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000983")]
		[DebuggerNonUserCode]
		public RepeatedField<UninterpretedOption> UninterpretedOption
		{
			[Token(Token = "0x60072E4")]
			[Address(RVA = "0x31A2CF0", Offset = "0x31A2CF0", VA = "0x31A2CF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060072E5 RID: 29413 RVA: 0x00050F58 File Offset: 0x0004F158
		[Token(Token = "0x60072E5")]
		[Address(RVA = "0x31A2CF8", Offset = "0x31A2CF8", VA = "0x31A2CF8", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x060072E6 RID: 29414 RVA: 0x00050F70 File Offset: 0x0004F170
		[Token(Token = "0x60072E6")]
		[Address(RVA = "0x31A2D5C", Offset = "0x31A2D5C", VA = "0x31A2D5C", Slot = "16")]
		[DebuggerNonUserCode]
		public bool Equals(MethodOptions other)
		{
			return default(bool);
		}

		// Token: 0x060072E7 RID: 29415 RVA: 0x00050F88 File Offset: 0x0004F188
		[Token(Token = "0x60072E7")]
		[Address(RVA = "0x31A2E38", Offset = "0x31A2E38", VA = "0x31A2E38", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060072E8 RID: 29416 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072E8")]
		[Address(RVA = "0x31A2F40", Offset = "0x31A2F40", VA = "0x31A2F40", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060072E9 RID: 29417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60072E9")]
		[Address(RVA = "0x31A2F98", Offset = "0x31A2F98", VA = "0x31A2F98", Slot = "13")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060072EA RID: 29418 RVA: 0x00050FA0 File Offset: 0x0004F1A0
		[Token(Token = "0x60072EA")]
		[Address(RVA = "0x31A30E8", Offset = "0x31A30E8", VA = "0x31A30E8", Slot = "14")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060072EB RID: 29419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60072EB")]
		[Address(RVA = "0x31A3218", Offset = "0x31A3218", VA = "0x31A3218", Slot = "11")]
		[DebuggerNonUserCode]
		public void MergeFrom(MethodOptions other)
		{
		}

		// Token: 0x060072EC RID: 29420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60072EC")]
		[Address(RVA = "0x31A3308", Offset = "0x31A3308", VA = "0x31A3308", Slot = "12")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060072ED RID: 29421 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072ED")]
		public TValue GetExtension<TValue>(Extension<MethodOptions, TValue> extension)
		{
			return null;
		}

		// Token: 0x060072EE RID: 29422 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072EE")]
		public RepeatedField<TValue> GetExtension<TValue>(RepeatedExtension<MethodOptions, TValue> extension)
		{
			return null;
		}

		// Token: 0x060072EF RID: 29423 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072EF")]
		public RepeatedField<TValue> GetOrInitializeExtension<TValue>(RepeatedExtension<MethodOptions, TValue> extension)
		{
			return null;
		}

		// Token: 0x060072F0 RID: 29424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60072F0")]
		public void SetExtension<TValue>(Extension<MethodOptions, TValue> extension, TValue value)
		{
		}

		// Token: 0x060072F1 RID: 29425 RVA: 0x00050FB8 File Offset: 0x0004F1B8
		[Token(Token = "0x60072F1")]
		public bool HasExtension<TValue>(Extension<MethodOptions, TValue> extension)
		{
			return default(bool);
		}

		// Token: 0x060072F2 RID: 29426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60072F2")]
		public void ClearExtension<TValue>(Extension<MethodOptions, TValue> extension)
		{
		}

		// Token: 0x060072F3 RID: 29427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60072F3")]
		public void ClearExtension<TValue>(RepeatedExtension<MethodOptions, TValue> extension)
		{
		}

		// Token: 0x04002EA6 RID: 11942
		[Token(Token = "0x4002EA6")]
		[FieldOffset(Offset = "0x0")]
		private static readonly MessageParser<MethodOptions> _parser;

		// Token: 0x04002EA7 RID: 11943
		[Token(Token = "0x4002EA7")]
		[FieldOffset(Offset = "0x10")]
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002EA8 RID: 11944
		[Token(Token = "0x4002EA8")]
		[FieldOffset(Offset = "0x18")]
		internal ExtensionSet<MethodOptions> _extensions;

		// Token: 0x04002EA9 RID: 11945
		[Token(Token = "0x4002EA9")]
		[FieldOffset(Offset = "0x20")]
		private int _hasBits0;

		// Token: 0x04002EAA RID: 11946
		[Token(Token = "0x4002EAA")]
		public const int DeprecatedFieldNumber = 33;

		// Token: 0x04002EAB RID: 11947
		[Token(Token = "0x4002EAB")]
		[FieldOffset(Offset = "0x8")]
		private static readonly bool DeprecatedDefaultValue;

		// Token: 0x04002EAC RID: 11948
		[Token(Token = "0x4002EAC")]
		[FieldOffset(Offset = "0x24")]
		private bool deprecated_;

		// Token: 0x04002EAD RID: 11949
		[Token(Token = "0x4002EAD")]
		public const int IdempotencyLevelFieldNumber = 34;

		// Token: 0x04002EAE RID: 11950
		[Token(Token = "0x4002EAE")]
		[FieldOffset(Offset = "0xC")]
		private static readonly MethodOptions.Types.IdempotencyLevel IdempotencyLevelDefaultValue;

		// Token: 0x04002EAF RID: 11951
		[Token(Token = "0x4002EAF")]
		[FieldOffset(Offset = "0x28")]
		private MethodOptions.Types.IdempotencyLevel idempotencyLevel_;

		// Token: 0x04002EB0 RID: 11952
		[Token(Token = "0x4002EB0")]
		public const int UninterpretedOptionFieldNumber = 999;

		// Token: 0x04002EB1 RID: 11953
		[Token(Token = "0x4002EB1")]
		[FieldOffset(Offset = "0x10")]
		private static readonly FieldCodec<UninterpretedOption> _repeated_uninterpretedOption_codec;

		// Token: 0x04002EB2 RID: 11954
		[Token(Token = "0x4002EB2")]
		[FieldOffset(Offset = "0x30")]
		private readonly RepeatedField<UninterpretedOption> uninterpretedOption_;

		// Token: 0x02000BAD RID: 2989
		[Token(Token = "0x2000BAD")]
		[DebuggerNonUserCode]
		public static class Types
		{
			// Token: 0x02000BAE RID: 2990
			[Token(Token = "0x2000BAE")]
			public enum IdempotencyLevel
			{
				// Token: 0x04002EB4 RID: 11956
				[Token(Token = "0x4002EB4")]
				[OriginalName("IDEMPOTENCY_UNKNOWN")]
				IdempotencyUnknown,
				// Token: 0x04002EB5 RID: 11957
				[Token(Token = "0x4002EB5")]
				[OriginalName("NO_SIDE_EFFECTS")]
				NoSideEffects,
				// Token: 0x04002EB6 RID: 11958
				[Token(Token = "0x4002EB6")]
				[OriginalName("IDEMPOTENT")]
				Idempotent
			}
		}
	}
}
