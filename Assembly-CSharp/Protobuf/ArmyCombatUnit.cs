using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Protobuf
{
	// Token: 0x0200041C RID: 1052
	[Token(Token = "0x200041C")]
	public sealed class ArmyCombatUnit : IMessage<ArmyCombatUnit>, IMessage, IEquatable<ArmyCombatUnit>, IDeepCloneable<ArmyCombatUnit>
	{
		// Token: 0x17000338 RID: 824
		// (get) Token: 0x06001C06 RID: 7174 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000338")]
		[DebuggerNonUserCode]
		public static MessageParser<ArmyCombatUnit> Parser
		{
			[Token(Token = "0x6001C06")]
			[Address(RVA = "0x26F7290", Offset = "0x26F7290", VA = "0x26F7290")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000339 RID: 825
		// (get) Token: 0x06001C07 RID: 7175 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000339")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Token(Token = "0x6001C07")]
			[Address(RVA = "0x26F72E8", Offset = "0x26F72E8", VA = "0x26F72E8")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700033A RID: 826
		// (get) Token: 0x06001C08 RID: 7176 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700033A")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Token(Token = "0x6001C08")]
			[Address(RVA = "0x26F73EC", Offset = "0x26F73EC", VA = "0x26F73EC", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001C09 RID: 7177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C09")]
		[Address(RVA = "0x26F7438", Offset = "0x26F7438", VA = "0x26F7438")]
		[DebuggerNonUserCode]
		public ArmyCombatUnit()
		{
		}

		// Token: 0x06001C0A RID: 7178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C0A")]
		[Address(RVA = "0x26F7490", Offset = "0x26F7490", VA = "0x26F7490")]
		[DebuggerNonUserCode]
		public ArmyCombatUnit(ArmyCombatUnit other)
		{
		}

		// Token: 0x06001C0B RID: 7179 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C0B")]
		[Address(RVA = "0x26F75A8", Offset = "0x26F75A8", VA = "0x26F75A8", Slot = "10")]
		[DebuggerNonUserCode]
		public ArmyCombatUnit Clone()
		{
			return null;
		}

		// Token: 0x1700033B RID: 827
		// (get) Token: 0x06001C0C RID: 7180 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001C0D RID: 7181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700033B")]
		[DebuggerNonUserCode]
		public SimpleCombatUnit SimpleCombatUnit
		{
			[Token(Token = "0x6001C0C")]
			[Address(RVA = "0x26F7608", Offset = "0x26F7608", VA = "0x26F7608")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001C0D")]
			[Address(RVA = "0x26F7610", Offset = "0x26F7610", VA = "0x26F7610")]
			set
			{
			}
		}

		// Token: 0x1700033C RID: 828
		// (get) Token: 0x06001C0E RID: 7182 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001C0F RID: 7183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700033C")]
		[DebuggerNonUserCode]
		public ArmyUnitInfo ArmyInfo
		{
			[Token(Token = "0x6001C0E")]
			[Address(RVA = "0x26F7618", Offset = "0x26F7618", VA = "0x26F7618")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001C0F")]
			[Address(RVA = "0x26F7620", Offset = "0x26F7620", VA = "0x26F7620")]
			set
			{
			}
		}

		// Token: 0x1700033D RID: 829
		// (get) Token: 0x06001C10 RID: 7184 RVA: 0x0000ABD8 File Offset: 0x00008DD8
		// (set) Token: 0x06001C11 RID: 7185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700033D")]
		[DebuggerNonUserCode]
		public int SpecialArmyType
		{
			[Token(Token = "0x6001C10")]
			[Address(RVA = "0x26F7628", Offset = "0x26F7628", VA = "0x26F7628")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001C11")]
			[Address(RVA = "0x26F7630", Offset = "0x26F7630", VA = "0x26F7630")]
			set
			{
			}
		}

		// Token: 0x1700033E RID: 830
		// (get) Token: 0x06001C12 RID: 7186 RVA: 0x0000ABF0 File Offset: 0x00008DF0
		// (set) Token: 0x06001C13 RID: 7187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700033E")]
		[DebuggerNonUserCode]
		public int FormationIndex
		{
			[Token(Token = "0x6001C12")]
			[Address(RVA = "0x26F7638", Offset = "0x26F7638", VA = "0x26F7638")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001C13")]
			[Address(RVA = "0x26F7640", Offset = "0x26F7640", VA = "0x26F7640")]
			set
			{
			}
		}

		// Token: 0x1700033F RID: 831
		// (get) Token: 0x06001C14 RID: 7188 RVA: 0x0000AC08 File Offset: 0x00008E08
		// (set) Token: 0x06001C15 RID: 7189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700033F")]
		[DebuggerNonUserCode]
		public int InAllianceTerritory
		{
			[Token(Token = "0x6001C14")]
			[Address(RVA = "0x26F7648", Offset = "0x26F7648", VA = "0x26F7648")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001C15")]
			[Address(RVA = "0x26F7650", Offset = "0x26F7650", VA = "0x26F7650")]
			set
			{
			}
		}

		// Token: 0x17000340 RID: 832
		// (get) Token: 0x06001C16 RID: 7190 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001C17 RID: 7191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000340")]
		[DebuggerNonUserCode]
		public string Param
		{
			[Token(Token = "0x6001C16")]
			[Address(RVA = "0x26F7658", Offset = "0x26F7658", VA = "0x26F7658")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001C17")]
			[Address(RVA = "0x26F7660", Offset = "0x26F7660", VA = "0x26F7660")]
			set
			{
			}
		}

		// Token: 0x17000341 RID: 833
		// (get) Token: 0x06001C18 RID: 7192 RVA: 0x0000AC20 File Offset: 0x00008E20
		// (set) Token: 0x06001C19 RID: 7193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000341")]
		[DebuggerNonUserCode]
		public float EdenSignal
		{
			[Token(Token = "0x6001C18")]
			[Address(RVA = "0x26F76DC", Offset = "0x26F76DC", VA = "0x26F76DC")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6001C19")]
			[Address(RVA = "0x26F76E4", Offset = "0x26F76E4", VA = "0x26F76E4")]
			set
			{
			}
		}

		// Token: 0x06001C1A RID: 7194 RVA: 0x0000AC38 File Offset: 0x00008E38
		[Token(Token = "0x6001C1A")]
		[Address(RVA = "0x26F76EC", Offset = "0x26F76EC", VA = "0x26F76EC", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06001C1B RID: 7195 RVA: 0x0000AC50 File Offset: 0x00008E50
		[Token(Token = "0x6001C1B")]
		[Address(RVA = "0x26F7750", Offset = "0x26F7750", VA = "0x26F7750", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ArmyCombatUnit other)
		{
			return default(bool);
		}

		// Token: 0x06001C1C RID: 7196 RVA: 0x0000AC68 File Offset: 0x00008E68
		[Token(Token = "0x6001C1C")]
		[Address(RVA = "0x26F78A8", Offset = "0x26F78A8", VA = "0x26F78A8", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001C1D RID: 7197 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C1D")]
		[Address(RVA = "0x26F7A30", Offset = "0x26F7A30", VA = "0x26F7A30", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001C1E RID: 7198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C1E")]
		[Address(RVA = "0x26F7A88", Offset = "0x26F7A88", VA = "0x26F7A88", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06001C1F RID: 7199 RVA: 0x0000AC80 File Offset: 0x00008E80
		[Token(Token = "0x6001C1F")]
		[Address(RVA = "0x26F7C04", Offset = "0x26F7C04", VA = "0x26F7C04", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06001C20 RID: 7200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C20")]
		[Address(RVA = "0x26F7D8C", Offset = "0x26F7D8C", VA = "0x26F7D8C", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(ArmyCombatUnit other)
		{
		}

		// Token: 0x06001C21 RID: 7201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C21")]
		[Address(RVA = "0x26F7FE4", Offset = "0x26F7FE4", VA = "0x26F7FE4", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x04001CF7 RID: 7415
		[Token(Token = "0x4001CF7")]
		[FieldOffset(Offset = "0x0")]
		private static readonly MessageParser<ArmyCombatUnit> _parser;

		// Token: 0x04001CF8 RID: 7416
		[Token(Token = "0x4001CF8")]
		[FieldOffset(Offset = "0x10")]
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001CF9 RID: 7417
		[Token(Token = "0x4001CF9")]
		public const int SimpleCombatUnitFieldNumber = 1;

		// Token: 0x04001CFA RID: 7418
		[Token(Token = "0x4001CFA")]
		[FieldOffset(Offset = "0x18")]
		private SimpleCombatUnit simpleCombatUnit_;

		// Token: 0x04001CFB RID: 7419
		[Token(Token = "0x4001CFB")]
		public const int ArmyInfoFieldNumber = 2;

		// Token: 0x04001CFC RID: 7420
		[Token(Token = "0x4001CFC")]
		[FieldOffset(Offset = "0x20")]
		private ArmyUnitInfo armyInfo_;

		// Token: 0x04001CFD RID: 7421
		[Token(Token = "0x4001CFD")]
		public const int SpecialArmyTypeFieldNumber = 3;

		// Token: 0x04001CFE RID: 7422
		[Token(Token = "0x4001CFE")]
		[FieldOffset(Offset = "0x28")]
		private int specialArmyType_;

		// Token: 0x04001CFF RID: 7423
		[Token(Token = "0x4001CFF")]
		public const int FormationIndexFieldNumber = 4;

		// Token: 0x04001D00 RID: 7424
		[Token(Token = "0x4001D00")]
		[FieldOffset(Offset = "0x2C")]
		private int formationIndex_;

		// Token: 0x04001D01 RID: 7425
		[Token(Token = "0x4001D01")]
		public const int InAllianceTerritoryFieldNumber = 5;

		// Token: 0x04001D02 RID: 7426
		[Token(Token = "0x4001D02")]
		[FieldOffset(Offset = "0x30")]
		private int inAllianceTerritory_;

		// Token: 0x04001D03 RID: 7427
		[Token(Token = "0x4001D03")]
		public const int ParamFieldNumber = 6;

		// Token: 0x04001D04 RID: 7428
		[Token(Token = "0x4001D04")]
		[FieldOffset(Offset = "0x38")]
		private string param_;

		// Token: 0x04001D05 RID: 7429
		[Token(Token = "0x4001D05")]
		public const int EdenSignalFieldNumber = 7;

		// Token: 0x04001D06 RID: 7430
		[Token(Token = "0x4001D06")]
		[FieldOffset(Offset = "0x40")]
		private float edenSignal_;
	}
}
