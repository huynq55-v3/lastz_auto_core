using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Protobuf
{
	// Token: 0x0200045A RID: 1114
	[Token(Token = "0x200045A")]
	public sealed class BattleEffectInfo : IMessage<BattleEffectInfo>, IMessage, IEquatable<BattleEffectInfo>, IDeepCloneable<BattleEffectInfo>
	{
		// Token: 0x17000415 RID: 1045
		// (get) Token: 0x06001F22 RID: 7970 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000415")]
		[DebuggerNonUserCode]
		public static MessageParser<BattleEffectInfo> Parser
		{
			[Token(Token = "0x6001F22")]
			[Address(RVA = "0x25A428C", Offset = "0x25A428C", VA = "0x25A428C")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000416 RID: 1046
		// (get) Token: 0x06001F23 RID: 7971 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000416")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Token(Token = "0x6001F23")]
			[Address(RVA = "0x25A42E4", Offset = "0x25A42E4", VA = "0x25A42E4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000417 RID: 1047
		// (get) Token: 0x06001F24 RID: 7972 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000417")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Token(Token = "0x6001F24")]
			[Address(RVA = "0x25A43E8", Offset = "0x25A43E8", VA = "0x25A43E8", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001F25 RID: 7973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F25")]
		[Address(RVA = "0x25A4434", Offset = "0x25A4434", VA = "0x25A4434")]
		[DebuggerNonUserCode]
		public BattleEffectInfo()
		{
		}

		// Token: 0x06001F26 RID: 7974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F26")]
		[Address(RVA = "0x25A44BC", Offset = "0x25A44BC", VA = "0x25A44BC")]
		[DebuggerNonUserCode]
		public BattleEffectInfo(BattleEffectInfo other)
		{
		}

		// Token: 0x06001F27 RID: 7975 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F27")]
		[Address(RVA = "0x25A4550", Offset = "0x25A4550", VA = "0x25A4550", Slot = "10")]
		[DebuggerNonUserCode]
		public BattleEffectInfo Clone()
		{
			return null;
		}

		// Token: 0x17000418 RID: 1048
		// (get) Token: 0x06001F28 RID: 7976 RVA: 0x0000BDA8 File Offset: 0x00009FA8
		// (set) Token: 0x06001F29 RID: 7977 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000418")]
		[DebuggerNonUserCode]
		public int EffectId
		{
			[Token(Token = "0x6001F28")]
			[Address(RVA = "0x25A45B0", Offset = "0x25A45B0", VA = "0x25A45B0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001F29")]
			[Address(RVA = "0x25A45B8", Offset = "0x25A45B8", VA = "0x25A45B8")]
			set
			{
			}
		}

		// Token: 0x17000419 RID: 1049
		// (get) Token: 0x06001F2A RID: 7978 RVA: 0x0000BDC0 File Offset: 0x00009FC0
		// (set) Token: 0x06001F2B RID: 7979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000419")]
		[DebuggerNonUserCode]
		public float Value
		{
			[Token(Token = "0x6001F2A")]
			[Address(RVA = "0x25A45C0", Offset = "0x25A45C0", VA = "0x25A45C0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6001F2B")]
			[Address(RVA = "0x25A45C8", Offset = "0x25A45C8", VA = "0x25A45C8")]
			set
			{
			}
		}

		// Token: 0x1700041A RID: 1050
		// (get) Token: 0x06001F2C RID: 7980 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700041A")]
		[DebuggerNonUserCode]
		public RepeatedField<BattleEffectReason> Reasons
		{
			[Token(Token = "0x6001F2C")]
			[Address(RVA = "0x25A45D0", Offset = "0x25A45D0", VA = "0x25A45D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001F2D RID: 7981 RVA: 0x0000BDD8 File Offset: 0x00009FD8
		[Token(Token = "0x6001F2D")]
		[Address(RVA = "0x25A45D8", Offset = "0x25A45D8", VA = "0x25A45D8", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06001F2E RID: 7982 RVA: 0x0000BDF0 File Offset: 0x00009FF0
		[Token(Token = "0x6001F2E")]
		[Address(RVA = "0x25A463C", Offset = "0x25A463C", VA = "0x25A463C", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(BattleEffectInfo other)
		{
			return default(bool);
		}

		// Token: 0x06001F2F RID: 7983 RVA: 0x0000BE08 File Offset: 0x0000A008
		[Token(Token = "0x6001F2F")]
		[Address(RVA = "0x25A4764", Offset = "0x25A4764", VA = "0x25A4764", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001F30 RID: 7984 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F30")]
		[Address(RVA = "0x25A4880", Offset = "0x25A4880", VA = "0x25A4880", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001F31 RID: 7985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F31")]
		[Address(RVA = "0x25A48D8", Offset = "0x25A48D8", VA = "0x25A48D8", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06001F32 RID: 7986 RVA: 0x0000BE20 File Offset: 0x0000A020
		[Token(Token = "0x6001F32")]
		[Address(RVA = "0x25A49EC", Offset = "0x25A49EC", VA = "0x25A49EC", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06001F33 RID: 7987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F33")]
		[Address(RVA = "0x25A4AF0", Offset = "0x25A4AF0", VA = "0x25A4AF0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(BattleEffectInfo other)
		{
		}

		// Token: 0x06001F34 RID: 7988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F34")]
		[Address(RVA = "0x25A4B94", Offset = "0x25A4B94", VA = "0x25A4B94", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x04001E66 RID: 7782
		[Token(Token = "0x4001E66")]
		[FieldOffset(Offset = "0x0")]
		private static readonly MessageParser<BattleEffectInfo> _parser;

		// Token: 0x04001E67 RID: 7783
		[Token(Token = "0x4001E67")]
		[FieldOffset(Offset = "0x10")]
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001E68 RID: 7784
		[Token(Token = "0x4001E68")]
		public const int EffectIdFieldNumber = 1;

		// Token: 0x04001E69 RID: 7785
		[Token(Token = "0x4001E69")]
		[FieldOffset(Offset = "0x18")]
		private int effectId_;

		// Token: 0x04001E6A RID: 7786
		[Token(Token = "0x4001E6A")]
		public const int ValueFieldNumber = 2;

		// Token: 0x04001E6B RID: 7787
		[Token(Token = "0x4001E6B")]
		[FieldOffset(Offset = "0x1C")]
		private float value_;

		// Token: 0x04001E6C RID: 7788
		[Token(Token = "0x4001E6C")]
		public const int ReasonsFieldNumber = 3;

		// Token: 0x04001E6D RID: 7789
		[Token(Token = "0x4001E6D")]
		[FieldOffset(Offset = "0x8")]
		private static readonly FieldCodec<BattleEffectReason> _repeated_reasons_codec;

		// Token: 0x04001E6E RID: 7790
		[Token(Token = "0x4001E6E")]
		[FieldOffset(Offset = "0x20")]
		private readonly RepeatedField<BattleEffectReason> reasons_;
	}
}
