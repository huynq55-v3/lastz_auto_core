using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Protobuf
{
	// Token: 0x02000420 RID: 1056
	[Token(Token = "0x2000420")]
	public sealed class SimpleCombatUnit : IMessage<SimpleCombatUnit>, IMessage, IEquatable<SimpleCombatUnit>, IDeepCloneable<SimpleCombatUnit>
	{
		// Token: 0x17000347 RID: 839
		// (get) Token: 0x06001C3B RID: 7227 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000347")]
		[DebuggerNonUserCode]
		public static MessageParser<SimpleCombatUnit> Parser
		{
			[Token(Token = "0x6001C3B")]
			[Address(RVA = "0x26F8F88", Offset = "0x26F8F88", VA = "0x26F8F88")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000348 RID: 840
		// (get) Token: 0x06001C3C RID: 7228 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000348")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Token(Token = "0x6001C3C")]
			[Address(RVA = "0x26F8FE0", Offset = "0x26F8FE0", VA = "0x26F8FE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000349 RID: 841
		// (get) Token: 0x06001C3D RID: 7229 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000349")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Token(Token = "0x6001C3D")]
			[Address(RVA = "0x26F90E4", Offset = "0x26F90E4", VA = "0x26F90E4", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001C3E RID: 7230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C3E")]
		[Address(RVA = "0x26F7F04", Offset = "0x26F7F04", VA = "0x26F7F04")]
		[DebuggerNonUserCode]
		public SimpleCombatUnit()
		{
		}

		// Token: 0x06001C3F RID: 7231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C3F")]
		[Address(RVA = "0x26F9130", Offset = "0x26F9130", VA = "0x26F9130")]
		[DebuggerNonUserCode]
		public SimpleCombatUnit(SimpleCombatUnit other)
		{
		}

		// Token: 0x06001C40 RID: 7232 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C40")]
		[Address(RVA = "0x26F7548", Offset = "0x26F7548", VA = "0x26F7548", Slot = "10")]
		[DebuggerNonUserCode]
		public SimpleCombatUnit Clone()
		{
			return null;
		}

		// Token: 0x1700034A RID: 842
		// (get) Token: 0x06001C41 RID: 7233 RVA: 0x0000ACF8 File Offset: 0x00008EF8
		// (set) Token: 0x06001C42 RID: 7234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700034A")]
		[DebuggerNonUserCode]
		public int InitHealth
		{
			[Token(Token = "0x6001C41")]
			[Address(RVA = "0x26F9190", Offset = "0x26F9190", VA = "0x26F9190")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001C42")]
			[Address(RVA = "0x26F9198", Offset = "0x26F9198", VA = "0x26F9198")]
			set
			{
			}
		}

		// Token: 0x1700034B RID: 843
		// (get) Token: 0x06001C43 RID: 7235 RVA: 0x0000AD10 File Offset: 0x00008F10
		// (set) Token: 0x06001C44 RID: 7236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700034B")]
		[DebuggerNonUserCode]
		public int Health
		{
			[Token(Token = "0x6001C43")]
			[Address(RVA = "0x26F91A0", Offset = "0x26F91A0", VA = "0x26F91A0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001C44")]
			[Address(RVA = "0x26F91A8", Offset = "0x26F91A8", VA = "0x26F91A8")]
			set
			{
			}
		}

		// Token: 0x1700034C RID: 844
		// (get) Token: 0x06001C45 RID: 7237 RVA: 0x0000AD28 File Offset: 0x00008F28
		// (set) Token: 0x06001C46 RID: 7238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700034C")]
		[DebuggerNonUserCode]
		public long Uuid
		{
			[Token(Token = "0x6001C45")]
			[Address(RVA = "0x26F91B0", Offset = "0x26F91B0", VA = "0x26F91B0")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x6001C46")]
			[Address(RVA = "0x26F91B8", Offset = "0x26F91B8", VA = "0x26F91B8")]
			set
			{
			}
		}

		// Token: 0x1700034D RID: 845
		// (get) Token: 0x06001C47 RID: 7239 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001C48 RID: 7240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700034D")]
		[DebuggerNonUserCode]
		public string Uid
		{
			[Token(Token = "0x6001C47")]
			[Address(RVA = "0x26F91C0", Offset = "0x26F91C0", VA = "0x26F91C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001C48")]
			[Address(RVA = "0x26F91C8", Offset = "0x26F91C8", VA = "0x26F91C8")]
			set
			{
			}
		}

		// Token: 0x06001C49 RID: 7241 RVA: 0x0000AD40 File Offset: 0x00008F40
		[Token(Token = "0x6001C49")]
		[Address(RVA = "0x26F9244", Offset = "0x26F9244", VA = "0x26F9244", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06001C4A RID: 7242 RVA: 0x0000AD58 File Offset: 0x00008F58
		[Token(Token = "0x6001C4A")]
		[Address(RVA = "0x26F92A8", Offset = "0x26F92A8", VA = "0x26F92A8", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(SimpleCombatUnit other)
		{
			return default(bool);
		}

		// Token: 0x06001C4B RID: 7243 RVA: 0x0000AD70 File Offset: 0x00008F70
		[Token(Token = "0x6001C4B")]
		[Address(RVA = "0x26F9338", Offset = "0x26F9338", VA = "0x26F9338", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001C4C RID: 7244 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C4C")]
		[Address(RVA = "0x26F93F8", Offset = "0x26F93F8", VA = "0x26F93F8", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001C4D RID: 7245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C4D")]
		[Address(RVA = "0x26F9450", Offset = "0x26F9450", VA = "0x26F9450", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06001C4E RID: 7246 RVA: 0x0000AD88 File Offset: 0x00008F88
		[Token(Token = "0x6001C4E")]
		[Address(RVA = "0x26F9544", Offset = "0x26F9544", VA = "0x26F9544", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06001C4F RID: 7247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C4F")]
		[Address(RVA = "0x26F7F5C", Offset = "0x26F7F5C", VA = "0x26F7F5C", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(SimpleCombatUnit other)
		{
		}

		// Token: 0x06001C50 RID: 7248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C50")]
		[Address(RVA = "0x26F965C", Offset = "0x26F965C", VA = "0x26F965C", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x04001D10 RID: 7440
		[Token(Token = "0x4001D10")]
		[FieldOffset(Offset = "0x0")]
		private static readonly MessageParser<SimpleCombatUnit> _parser;

		// Token: 0x04001D11 RID: 7441
		[Token(Token = "0x4001D11")]
		[FieldOffset(Offset = "0x10")]
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001D12 RID: 7442
		[Token(Token = "0x4001D12")]
		public const int InitHealthFieldNumber = 1;

		// Token: 0x04001D13 RID: 7443
		[Token(Token = "0x4001D13")]
		[FieldOffset(Offset = "0x18")]
		private int initHealth_;

		// Token: 0x04001D14 RID: 7444
		[Token(Token = "0x4001D14")]
		public const int HealthFieldNumber = 2;

		// Token: 0x04001D15 RID: 7445
		[Token(Token = "0x4001D15")]
		[FieldOffset(Offset = "0x1C")]
		private int health_;

		// Token: 0x04001D16 RID: 7446
		[Token(Token = "0x4001D16")]
		public const int UuidFieldNumber = 3;

		// Token: 0x04001D17 RID: 7447
		[Token(Token = "0x4001D17")]
		[FieldOffset(Offset = "0x20")]
		private long uuid_;

		// Token: 0x04001D18 RID: 7448
		[Token(Token = "0x4001D18")]
		public const int UidFieldNumber = 4;

		// Token: 0x04001D19 RID: 7449
		[Token(Token = "0x4001D19")]
		[FieldOffset(Offset = "0x28")]
		private string uid_;
	}
}
