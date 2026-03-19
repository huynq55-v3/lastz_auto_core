using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Protobuf
{
	// Token: 0x02000434 RID: 1076
	[Token(Token = "0x2000434")]
	public sealed class PveArmyResult : IMessage<PveArmyResult>, IMessage, IEquatable<PveArmyResult>, IDeepCloneable<PveArmyResult>
	{
		// Token: 0x1700038A RID: 906
		// (get) Token: 0x06001D37 RID: 7479 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700038A")]
		[DebuggerNonUserCode]
		public static MessageParser<PveArmyResult> Parser
		{
			[Token(Token = "0x6001D37")]
			[Address(RVA = "0x27000A4", Offset = "0x27000A4", VA = "0x27000A4")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700038B RID: 907
		// (get) Token: 0x06001D38 RID: 7480 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700038B")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Token(Token = "0x6001D38")]
			[Address(RVA = "0x27000FC", Offset = "0x27000FC", VA = "0x27000FC")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700038C RID: 908
		// (get) Token: 0x06001D39 RID: 7481 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700038C")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Token(Token = "0x6001D39")]
			[Address(RVA = "0x2700200", Offset = "0x2700200", VA = "0x2700200", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001D3A RID: 7482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D3A")]
		[Address(RVA = "0x270024C", Offset = "0x270024C", VA = "0x270024C")]
		[DebuggerNonUserCode]
		public PveArmyResult()
		{
		}

		// Token: 0x06001D3B RID: 7483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D3B")]
		[Address(RVA = "0x2700254", Offset = "0x2700254", VA = "0x2700254")]
		[DebuggerNonUserCode]
		public PveArmyResult(PveArmyResult other)
		{
		}

		// Token: 0x06001D3C RID: 7484 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D3C")]
		[Address(RVA = "0x27002C8", Offset = "0x27002C8", VA = "0x27002C8", Slot = "10")]
		[DebuggerNonUserCode]
		public PveArmyResult Clone()
		{
			return null;
		}

		// Token: 0x1700038D RID: 909
		// (get) Token: 0x06001D3D RID: 7485 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001D3E RID: 7486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700038D")]
		[DebuggerNonUserCode]
		public ArmyResultBase Base
		{
			[Token(Token = "0x6001D3D")]
			[Address(RVA = "0x2700328", Offset = "0x2700328", VA = "0x2700328")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001D3E")]
			[Address(RVA = "0x2700330", Offset = "0x2700330", VA = "0x2700330")]
			set
			{
			}
		}

		// Token: 0x1700038E RID: 910
		// (get) Token: 0x06001D3F RID: 7487 RVA: 0x0000B2C8 File Offset: 0x000094C8
		// (set) Token: 0x06001D40 RID: 7488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700038E")]
		[DebuggerNonUserCode]
		public int MonsterId
		{
			[Token(Token = "0x6001D3F")]
			[Address(RVA = "0x2700338", Offset = "0x2700338", VA = "0x2700338")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001D40")]
			[Address(RVA = "0x2700340", Offset = "0x2700340", VA = "0x2700340")]
			set
			{
			}
		}

		// Token: 0x06001D41 RID: 7489 RVA: 0x0000B2E0 File Offset: 0x000094E0
		[Token(Token = "0x6001D41")]
		[Address(RVA = "0x2700348", Offset = "0x2700348", VA = "0x2700348", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06001D42 RID: 7490 RVA: 0x0000B2F8 File Offset: 0x000094F8
		[Token(Token = "0x6001D42")]
		[Address(RVA = "0x27003AC", Offset = "0x27003AC", VA = "0x27003AC", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(PveArmyResult other)
		{
			return default(bool);
		}

		// Token: 0x06001D43 RID: 7491 RVA: 0x0000B310 File Offset: 0x00009510
		[Token(Token = "0x6001D43")]
		[Address(RVA = "0x270041C", Offset = "0x270041C", VA = "0x270041C", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001D44 RID: 7492 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D44")]
		[Address(RVA = "0x2700490", Offset = "0x2700490", VA = "0x2700490", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001D45 RID: 7493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D45")]
		[Address(RVA = "0x27004E8", Offset = "0x27004E8", VA = "0x27004E8", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06001D46 RID: 7494 RVA: 0x0000B328 File Offset: 0x00009528
		[Token(Token = "0x6001D46")]
		[Address(RVA = "0x270057C", Offset = "0x270057C", VA = "0x270057C", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06001D47 RID: 7495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D47")]
		[Address(RVA = "0x2700630", Offset = "0x2700630", VA = "0x2700630", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(PveArmyResult other)
		{
		}

		// Token: 0x06001D48 RID: 7496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D48")]
		[Address(RVA = "0x2700704", Offset = "0x2700704", VA = "0x2700704", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x04001D7A RID: 7546
		[Token(Token = "0x4001D7A")]
		[FieldOffset(Offset = "0x0")]
		private static readonly MessageParser<PveArmyResult> _parser;

		// Token: 0x04001D7B RID: 7547
		[Token(Token = "0x4001D7B")]
		[FieldOffset(Offset = "0x10")]
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001D7C RID: 7548
		[Token(Token = "0x4001D7C")]
		public const int BaseFieldNumber = 1;

		// Token: 0x04001D7D RID: 7549
		[Token(Token = "0x4001D7D")]
		[FieldOffset(Offset = "0x18")]
		private ArmyResultBase base_;

		// Token: 0x04001D7E RID: 7550
		[Token(Token = "0x4001D7E")]
		public const int MonsterIdFieldNumber = 2;

		// Token: 0x04001D7F RID: 7551
		[Token(Token = "0x4001D7F")]
		[FieldOffset(Offset = "0x20")]
		private int monsterId_;
	}
}
