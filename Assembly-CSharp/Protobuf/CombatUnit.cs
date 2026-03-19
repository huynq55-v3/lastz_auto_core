using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Protobuf
{
	// Token: 0x02000422 RID: 1058
	[Token(Token = "0x2000422")]
	public sealed class CombatUnit : IMessage<CombatUnit>, IMessage, IEquatable<CombatUnit>, IDeepCloneable<CombatUnit>
	{
		// Token: 0x1700034E RID: 846
		// (get) Token: 0x06001C55 RID: 7253 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700034E")]
		[DebuggerNonUserCode]
		public static MessageParser<CombatUnit> Parser
		{
			[Token(Token = "0x6001C55")]
			[Address(RVA = "0x26F9928", Offset = "0x26F9928", VA = "0x26F9928")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700034F RID: 847
		// (get) Token: 0x06001C56 RID: 7254 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700034F")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Token(Token = "0x6001C56")]
			[Address(RVA = "0x26F9980", Offset = "0x26F9980", VA = "0x26F9980")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000350 RID: 848
		// (get) Token: 0x06001C57 RID: 7255 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000350")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Token(Token = "0x6001C57")]
			[Address(RVA = "0x26F9A84", Offset = "0x26F9A84", VA = "0x26F9A84", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001C58 RID: 7256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C58")]
		[Address(RVA = "0x26F9AD0", Offset = "0x26F9AD0", VA = "0x26F9AD0")]
		[DebuggerNonUserCode]
		public CombatUnit()
		{
		}

		// Token: 0x06001C59 RID: 7257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C59")]
		[Address(RVA = "0x26F9AD8", Offset = "0x26F9AD8", VA = "0x26F9AD8")]
		[DebuggerNonUserCode]
		public CombatUnit(CombatUnit other)
		{
		}

		// Token: 0x06001C5A RID: 7258 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C5A")]
		[Address(RVA = "0x26F9B90", Offset = "0x26F9B90", VA = "0x26F9B90", Slot = "10")]
		[DebuggerNonUserCode]
		public CombatUnit Clone()
		{
			return null;
		}

		// Token: 0x17000351 RID: 849
		// (get) Token: 0x06001C5B RID: 7259 RVA: 0x0000ADA0 File Offset: 0x00008FA0
		// (set) Token: 0x06001C5C RID: 7260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000351")]
		[DebuggerNonUserCode]
		public int Type
		{
			[Token(Token = "0x6001C5B")]
			[Address(RVA = "0x26F9BF0", Offset = "0x26F9BF0", VA = "0x26F9BF0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001C5C")]
			[Address(RVA = "0x26F9BF8", Offset = "0x26F9BF8", VA = "0x26F9BF8")]
			set
			{
			}
		}

		// Token: 0x17000352 RID: 850
		// (get) Token: 0x06001C5D RID: 7261 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001C5E RID: 7262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000352")]
		[DebuggerNonUserCode]
		public ArmyCombatUnit ArmyCombatUnit
		{
			[Token(Token = "0x6001C5D")]
			[Address(RVA = "0x26F9C00", Offset = "0x26F9C00", VA = "0x26F9C00")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001C5E")]
			[Address(RVA = "0x26F9C08", Offset = "0x26F9C08", VA = "0x26F9C08")]
			set
			{
			}
		}

		// Token: 0x17000353 RID: 851
		// (get) Token: 0x06001C5F RID: 7263 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001C60 RID: 7264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000353")]
		[DebuggerNonUserCode]
		public CombineCombatUnit CombineCombatUnit
		{
			[Token(Token = "0x6001C5F")]
			[Address(RVA = "0x26F9C10", Offset = "0x26F9C10", VA = "0x26F9C10")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001C60")]
			[Address(RVA = "0x26F9C18", Offset = "0x26F9C18", VA = "0x26F9C18")]
			set
			{
			}
		}

		// Token: 0x17000354 RID: 852
		// (get) Token: 0x06001C61 RID: 7265 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001C62 RID: 7266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000354")]
		[DebuggerNonUserCode]
		public SimpleCombatUnit SimpleCombatUnit
		{
			[Token(Token = "0x6001C61")]
			[Address(RVA = "0x26F9C20", Offset = "0x26F9C20", VA = "0x26F9C20")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001C62")]
			[Address(RVA = "0x26F9C28", Offset = "0x26F9C28", VA = "0x26F9C28")]
			set
			{
			}
		}

		// Token: 0x06001C63 RID: 7267 RVA: 0x0000ADB8 File Offset: 0x00008FB8
		[Token(Token = "0x6001C63")]
		[Address(RVA = "0x26F9C30", Offset = "0x26F9C30", VA = "0x26F9C30", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06001C64 RID: 7268 RVA: 0x0000ADD0 File Offset: 0x00008FD0
		[Token(Token = "0x6001C64")]
		[Address(RVA = "0x26F9C94", Offset = "0x26F9C94", VA = "0x26F9C94", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(CombatUnit other)
		{
			return default(bool);
		}

		// Token: 0x06001C65 RID: 7269 RVA: 0x0000ADE8 File Offset: 0x00008FE8
		[Token(Token = "0x6001C65")]
		[Address(RVA = "0x26F9D2C", Offset = "0x26F9D2C", VA = "0x26F9D2C", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001C66 RID: 7270 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C66")]
		[Address(RVA = "0x26F9DD0", Offset = "0x26F9DD0", VA = "0x26F9DD0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001C67 RID: 7271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C67")]
		[Address(RVA = "0x26F9E28", Offset = "0x26F9E28", VA = "0x26F9E28", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06001C68 RID: 7272 RVA: 0x0000AE00 File Offset: 0x00009000
		[Token(Token = "0x6001C68")]
		[Address(RVA = "0x26F9F14", Offset = "0x26F9F14", VA = "0x26F9F14", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06001C69 RID: 7273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C69")]
		[Address(RVA = "0x26FA020", Offset = "0x26FA020", VA = "0x26FA020", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CombatUnit other)
		{
		}

		// Token: 0x06001C6A RID: 7274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C6A")]
		[Address(RVA = "0x26FA1AC", Offset = "0x26FA1AC", VA = "0x26FA1AC", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x04001D1B RID: 7451
		[Token(Token = "0x4001D1B")]
		[FieldOffset(Offset = "0x0")]
		private static readonly MessageParser<CombatUnit> _parser;

		// Token: 0x04001D1C RID: 7452
		[Token(Token = "0x4001D1C")]
		[FieldOffset(Offset = "0x10")]
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001D1D RID: 7453
		[Token(Token = "0x4001D1D")]
		public const int TypeFieldNumber = 1;

		// Token: 0x04001D1E RID: 7454
		[Token(Token = "0x4001D1E")]
		[FieldOffset(Offset = "0x18")]
		private int type_;

		// Token: 0x04001D1F RID: 7455
		[Token(Token = "0x4001D1F")]
		public const int ArmyCombatUnitFieldNumber = 2;

		// Token: 0x04001D20 RID: 7456
		[Token(Token = "0x4001D20")]
		[FieldOffset(Offset = "0x20")]
		private ArmyCombatUnit armyCombatUnit_;

		// Token: 0x04001D21 RID: 7457
		[Token(Token = "0x4001D21")]
		public const int CombineCombatUnitFieldNumber = 3;

		// Token: 0x04001D22 RID: 7458
		[Token(Token = "0x4001D22")]
		[FieldOffset(Offset = "0x28")]
		private CombineCombatUnit combineCombatUnit_;

		// Token: 0x04001D23 RID: 7459
		[Token(Token = "0x4001D23")]
		public const int SimpleCombatUnitFieldNumber = 4;

		// Token: 0x04001D24 RID: 7460
		[Token(Token = "0x4001D24")]
		[FieldOffset(Offset = "0x30")]
		private SimpleCombatUnit simpleCombatUnit_;
	}
}
