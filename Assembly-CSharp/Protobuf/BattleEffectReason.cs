using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Protobuf
{
	// Token: 0x02000458 RID: 1112
	[Token(Token = "0x2000458")]
	public sealed class BattleEffectReason : IMessage<BattleEffectReason>, IMessage, IEquatable<BattleEffectReason>, IDeepCloneable<BattleEffectReason>
	{
		// Token: 0x17000410 RID: 1040
		// (get) Token: 0x06001F0C RID: 7948 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000410")]
		[DebuggerNonUserCode]
		public static MessageParser<BattleEffectReason> Parser
		{
			[Token(Token = "0x6001F0C")]
			[Address(RVA = "0x25A3960", Offset = "0x25A3960", VA = "0x25A3960")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000411 RID: 1041
		// (get) Token: 0x06001F0D RID: 7949 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000411")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Token(Token = "0x6001F0D")]
			[Address(RVA = "0x25A39B8", Offset = "0x25A39B8", VA = "0x25A39B8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000412 RID: 1042
		// (get) Token: 0x06001F0E RID: 7950 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000412")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Token(Token = "0x6001F0E")]
			[Address(RVA = "0x25A3ABC", Offset = "0x25A3ABC", VA = "0x25A3ABC", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001F0F RID: 7951 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F0F")]
		[Address(RVA = "0x25A3B08", Offset = "0x25A3B08", VA = "0x25A3B08")]
		[DebuggerNonUserCode]
		public BattleEffectReason()
		{
		}

		// Token: 0x06001F10 RID: 7952 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F10")]
		[Address(RVA = "0x25A3B10", Offset = "0x25A3B10", VA = "0x25A3B10")]
		[DebuggerNonUserCode]
		public BattleEffectReason(BattleEffectReason other)
		{
		}

		// Token: 0x06001F11 RID: 7953 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F11")]
		[Address(RVA = "0x25A3B5C", Offset = "0x25A3B5C", VA = "0x25A3B5C", Slot = "10")]
		[DebuggerNonUserCode]
		public BattleEffectReason Clone()
		{
			return null;
		}

		// Token: 0x17000413 RID: 1043
		// (get) Token: 0x06001F12 RID: 7954 RVA: 0x0000BD18 File Offset: 0x00009F18
		// (set) Token: 0x06001F13 RID: 7955 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000413")]
		[DebuggerNonUserCode]
		public float Value
		{
			[Token(Token = "0x6001F12")]
			[Address(RVA = "0x25A3BBC", Offset = "0x25A3BBC", VA = "0x25A3BBC")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6001F13")]
			[Address(RVA = "0x25A3BC4", Offset = "0x25A3BC4", VA = "0x25A3BC4")]
			set
			{
			}
		}

		// Token: 0x17000414 RID: 1044
		// (get) Token: 0x06001F14 RID: 7956 RVA: 0x0000BD30 File Offset: 0x00009F30
		// (set) Token: 0x06001F15 RID: 7957 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000414")]
		[DebuggerNonUserCode]
		public int Reason
		{
			[Token(Token = "0x6001F14")]
			[Address(RVA = "0x25A3BCC", Offset = "0x25A3BCC", VA = "0x25A3BCC")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001F15")]
			[Address(RVA = "0x25A3BD4", Offset = "0x25A3BD4", VA = "0x25A3BD4")]
			set
			{
			}
		}

		// Token: 0x06001F16 RID: 7958 RVA: 0x0000BD48 File Offset: 0x00009F48
		[Token(Token = "0x6001F16")]
		[Address(RVA = "0x25A3BDC", Offset = "0x25A3BDC", VA = "0x25A3BDC", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06001F17 RID: 7959 RVA: 0x0000BD60 File Offset: 0x00009F60
		[Token(Token = "0x6001F17")]
		[Address(RVA = "0x25A3C40", Offset = "0x25A3C40", VA = "0x25A3C40", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(BattleEffectReason other)
		{
			return default(bool);
		}

		// Token: 0x06001F18 RID: 7960 RVA: 0x0000BD78 File Offset: 0x00009F78
		[Token(Token = "0x6001F18")]
		[Address(RVA = "0x25A3D3C", Offset = "0x25A3D3C", VA = "0x25A3D3C", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001F19 RID: 7961 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F19")]
		[Address(RVA = "0x25A3E3C", Offset = "0x25A3E3C", VA = "0x25A3E3C", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001F1A RID: 7962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F1A")]
		[Address(RVA = "0x25A3E94", Offset = "0x25A3E94", VA = "0x25A3E94", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06001F1B RID: 7963 RVA: 0x0000BD90 File Offset: 0x00009F90
		[Token(Token = "0x6001F1B")]
		[Address(RVA = "0x25A3F2C", Offset = "0x25A3F2C", VA = "0x25A3F2C", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06001F1C RID: 7964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F1C")]
		[Address(RVA = "0x25A3FC0", Offset = "0x25A3FC0", VA = "0x25A3FC0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(BattleEffectReason other)
		{
		}

		// Token: 0x06001F1D RID: 7965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F1D")]
		[Address(RVA = "0x25A4010", Offset = "0x25A4010", VA = "0x25A4010", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x04001E5F RID: 7775
		[Token(Token = "0x4001E5F")]
		[FieldOffset(Offset = "0x0")]
		private static readonly MessageParser<BattleEffectReason> _parser;

		// Token: 0x04001E60 RID: 7776
		[Token(Token = "0x4001E60")]
		[FieldOffset(Offset = "0x10")]
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001E61 RID: 7777
		[Token(Token = "0x4001E61")]
		public const int ValueFieldNumber = 1;

		// Token: 0x04001E62 RID: 7778
		[Token(Token = "0x4001E62")]
		[FieldOffset(Offset = "0x18")]
		private float value_;

		// Token: 0x04001E63 RID: 7779
		[Token(Token = "0x4001E63")]
		public const int ReasonFieldNumber = 2;

		// Token: 0x04001E64 RID: 7780
		[Token(Token = "0x4001E64")]
		[FieldOffset(Offset = "0x1C")]
		private int reason_;
	}
}
