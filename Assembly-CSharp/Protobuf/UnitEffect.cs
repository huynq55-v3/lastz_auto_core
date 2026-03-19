using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Protobuf
{
	// Token: 0x020003FD RID: 1021
	[Token(Token = "0x20003FD")]
	public sealed class UnitEffect : IMessage<UnitEffect>, IMessage, IEquatable<UnitEffect>, IDeepCloneable<UnitEffect>
	{
		// Token: 0x170002C7 RID: 711
		// (get) Token: 0x06001A7C RID: 6780 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002C7")]
		[DebuggerNonUserCode]
		public static MessageParser<UnitEffect> Parser
		{
			[Token(Token = "0x6001A7C")]
			[Address(RVA = "0x20E6978", Offset = "0x20E6978", VA = "0x20E6978")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002C8 RID: 712
		// (get) Token: 0x06001A7D RID: 6781 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002C8")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Token(Token = "0x6001A7D")]
			[Address(RVA = "0x20E69D0", Offset = "0x20E69D0", VA = "0x20E69D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002C9 RID: 713
		// (get) Token: 0x06001A7E RID: 6782 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002C9")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Token(Token = "0x6001A7E")]
			[Address(RVA = "0x20E6AD4", Offset = "0x20E6AD4", VA = "0x20E6AD4", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001A7F RID: 6783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A7F")]
		[Address(RVA = "0x20E6B20", Offset = "0x20E6B20", VA = "0x20E6B20")]
		[DebuggerNonUserCode]
		public UnitEffect()
		{
		}

		// Token: 0x06001A80 RID: 6784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A80")]
		[Address(RVA = "0x20E6B28", Offset = "0x20E6B28", VA = "0x20E6B28")]
		[DebuggerNonUserCode]
		public UnitEffect(UnitEffect other)
		{
		}

		// Token: 0x06001A81 RID: 6785 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A81")]
		[Address(RVA = "0x20E6B74", Offset = "0x20E6B74", VA = "0x20E6B74", Slot = "10")]
		[DebuggerNonUserCode]
		public UnitEffect Clone()
		{
			return null;
		}

		// Token: 0x170002CA RID: 714
		// (get) Token: 0x06001A82 RID: 6786 RVA: 0x0000A260 File Offset: 0x00008460
		// (set) Token: 0x06001A83 RID: 6787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170002CA")]
		[DebuggerNonUserCode]
		public int EffectId
		{
			[Token(Token = "0x6001A82")]
			[Address(RVA = "0x20E6BD4", Offset = "0x20E6BD4", VA = "0x20E6BD4")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001A83")]
			[Address(RVA = "0x20E6BDC", Offset = "0x20E6BDC", VA = "0x20E6BDC")]
			set
			{
			}
		}

		// Token: 0x170002CB RID: 715
		// (get) Token: 0x06001A84 RID: 6788 RVA: 0x0000A278 File Offset: 0x00008478
		// (set) Token: 0x06001A85 RID: 6789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170002CB")]
		[DebuggerNonUserCode]
		public float Value
		{
			[Token(Token = "0x6001A84")]
			[Address(RVA = "0x20E6BE4", Offset = "0x20E6BE4", VA = "0x20E6BE4")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6001A85")]
			[Address(RVA = "0x20E6BEC", Offset = "0x20E6BEC", VA = "0x20E6BEC")]
			set
			{
			}
		}

		// Token: 0x06001A86 RID: 6790 RVA: 0x0000A290 File Offset: 0x00008490
		[Token(Token = "0x6001A86")]
		[Address(RVA = "0x20E6BF4", Offset = "0x20E6BF4", VA = "0x20E6BF4", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06001A87 RID: 6791 RVA: 0x0000A2A8 File Offset: 0x000084A8
		[Token(Token = "0x6001A87")]
		[Address(RVA = "0x20E6C58", Offset = "0x20E6C58", VA = "0x20E6C58", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(UnitEffect other)
		{
			return default(bool);
		}

		// Token: 0x06001A88 RID: 6792 RVA: 0x0000A2C0 File Offset: 0x000084C0
		[Token(Token = "0x6001A88")]
		[Address(RVA = "0x20E6D54", Offset = "0x20E6D54", VA = "0x20E6D54", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001A89 RID: 6793 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A89")]
		[Address(RVA = "0x20E6E54", Offset = "0x20E6E54", VA = "0x20E6E54", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001A8A RID: 6794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A8A")]
		[Address(RVA = "0x20E6EAC", Offset = "0x20E6EAC", VA = "0x20E6EAC", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06001A8B RID: 6795 RVA: 0x0000A2D8 File Offset: 0x000084D8
		[Token(Token = "0x6001A8B")]
		[Address(RVA = "0x20E6F44", Offset = "0x20E6F44", VA = "0x20E6F44", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06001A8C RID: 6796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A8C")]
		[Address(RVA = "0x20E6FDC", Offset = "0x20E6FDC", VA = "0x20E6FDC", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(UnitEffect other)
		{
		}

		// Token: 0x06001A8D RID: 6797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A8D")]
		[Address(RVA = "0x20E702C", Offset = "0x20E702C", VA = "0x20E702C", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x04001C37 RID: 7223
		[Token(Token = "0x4001C37")]
		[FieldOffset(Offset = "0x0")]
		private static readonly MessageParser<UnitEffect> _parser;

		// Token: 0x04001C38 RID: 7224
		[Token(Token = "0x4001C38")]
		[FieldOffset(Offset = "0x10")]
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001C39 RID: 7225
		[Token(Token = "0x4001C39")]
		public const int EffectIdFieldNumber = 1;

		// Token: 0x04001C3A RID: 7226
		[Token(Token = "0x4001C3A")]
		[FieldOffset(Offset = "0x18")]
		private int effectId_;

		// Token: 0x04001C3B RID: 7227
		[Token(Token = "0x4001C3B")]
		public const int ValueFieldNumber = 2;

		// Token: 0x04001C3C RID: 7228
		[Token(Token = "0x4001C3C")]
		[FieldOffset(Offset = "0x1C")]
		private float value_;
	}
}
