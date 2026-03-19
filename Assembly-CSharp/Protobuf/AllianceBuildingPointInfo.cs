using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Protobuf
{
	// Token: 0x02000487 RID: 1159
	[Token(Token = "0x2000487")]
	public sealed class AllianceBuildingPointInfo : IMessage<AllianceBuildingPointInfo>, IMessage, IEquatable<AllianceBuildingPointInfo>, IDeepCloneable<AllianceBuildingPointInfo>
	{
		// Token: 0x170004CD RID: 1229
		// (get) Token: 0x06002188 RID: 8584 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004CD")]
		[DebuggerNonUserCode]
		public static MessageParser<AllianceBuildingPointInfo> Parser
		{
			[Token(Token = "0x6002188")]
			[Address(RVA = "0x28926DC", Offset = "0x28926DC", VA = "0x28926DC")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004CE RID: 1230
		// (get) Token: 0x06002189 RID: 8585 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004CE")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Token(Token = "0x6002189")]
			[Address(RVA = "0x2892734", Offset = "0x2892734", VA = "0x2892734")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004CF RID: 1231
		// (get) Token: 0x0600218A RID: 8586 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004CF")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Token(Token = "0x600218A")]
			[Address(RVA = "0x2892838", Offset = "0x2892838", VA = "0x2892838", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600218B RID: 8587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600218B")]
		[Address(RVA = "0x2892884", Offset = "0x2892884", VA = "0x2892884")]
		[DebuggerNonUserCode]
		public AllianceBuildingPointInfo()
		{
		}

		// Token: 0x0600218C RID: 8588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600218C")]
		[Address(RVA = "0x28928EC", Offset = "0x28928EC", VA = "0x28928EC")]
		[DebuggerNonUserCode]
		public AllianceBuildingPointInfo(AllianceBuildingPointInfo other)
		{
		}

		// Token: 0x0600218D RID: 8589 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600218D")]
		[Address(RVA = "0x289297C", Offset = "0x289297C", VA = "0x289297C", Slot = "10")]
		[DebuggerNonUserCode]
		public AllianceBuildingPointInfo Clone()
		{
			return null;
		}

		// Token: 0x170004D0 RID: 1232
		// (get) Token: 0x0600218E RID: 8590 RVA: 0x0000CD38 File Offset: 0x0000AF38
		// (set) Token: 0x0600218F RID: 8591 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004D0")]
		[DebuggerNonUserCode]
		public long Uuid
		{
			[Token(Token = "0x600218E")]
			[Address(RVA = "0x28929DC", Offset = "0x28929DC", VA = "0x28929DC")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x600218F")]
			[Address(RVA = "0x28929E4", Offset = "0x28929E4", VA = "0x28929E4")]
			set
			{
			}
		}

		// Token: 0x170004D1 RID: 1233
		// (get) Token: 0x06002190 RID: 8592 RVA: 0x0000CD50 File Offset: 0x0000AF50
		// (set) Token: 0x06002191 RID: 8593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004D1")]
		[DebuggerNonUserCode]
		public int BuildId
		{
			[Token(Token = "0x6002190")]
			[Address(RVA = "0x28929EC", Offset = "0x28929EC", VA = "0x28929EC")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002191")]
			[Address(RVA = "0x28929F4", Offset = "0x28929F4", VA = "0x28929F4")]
			set
			{
			}
		}

		// Token: 0x170004D2 RID: 1234
		// (get) Token: 0x06002192 RID: 8594 RVA: 0x0000CD68 File Offset: 0x0000AF68
		// (set) Token: 0x06002193 RID: 8595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004D2")]
		[DebuggerNonUserCode]
		public int Level
		{
			[Token(Token = "0x6002192")]
			[Address(RVA = "0x28929FC", Offset = "0x28929FC", VA = "0x28929FC")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002193")]
			[Address(RVA = "0x2892A04", Offset = "0x2892A04", VA = "0x2892A04")]
			set
			{
			}
		}

		// Token: 0x170004D3 RID: 1235
		// (get) Token: 0x06002194 RID: 8596 RVA: 0x0000CD80 File Offset: 0x0000AF80
		// (set) Token: 0x06002195 RID: 8597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004D3")]
		[DebuggerNonUserCode]
		public int State
		{
			[Token(Token = "0x6002194")]
			[Address(RVA = "0x2892A0C", Offset = "0x2892A0C", VA = "0x2892A0C")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002195")]
			[Address(RVA = "0x2892A14", Offset = "0x2892A14", VA = "0x2892A14")]
			set
			{
			}
		}

		// Token: 0x170004D4 RID: 1236
		// (get) Token: 0x06002196 RID: 8598 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002197 RID: 8599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004D4")]
		[DebuggerNonUserCode]
		public string AlAbbr
		{
			[Token(Token = "0x6002196")]
			[Address(RVA = "0x2892A1C", Offset = "0x2892A1C", VA = "0x2892A1C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002197")]
			[Address(RVA = "0x2892A24", Offset = "0x2892A24", VA = "0x2892A24")]
			set
			{
			}
		}

		// Token: 0x170004D5 RID: 1237
		// (get) Token: 0x06002198 RID: 8600 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002199 RID: 8601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004D5")]
		[DebuggerNonUserCode]
		public string AllianceId
		{
			[Token(Token = "0x6002198")]
			[Address(RVA = "0x2892AA0", Offset = "0x2892AA0", VA = "0x2892AA0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002199")]
			[Address(RVA = "0x2892AA8", Offset = "0x2892AA8", VA = "0x2892AA8")]
			set
			{
			}
		}

		// Token: 0x170004D6 RID: 1238
		// (get) Token: 0x0600219A RID: 8602 RVA: 0x0000CD98 File Offset: 0x0000AF98
		// (set) Token: 0x0600219B RID: 8603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004D6")]
		[DebuggerNonUserCode]
		public int Durability
		{
			[Token(Token = "0x600219A")]
			[Address(RVA = "0x2892B24", Offset = "0x2892B24", VA = "0x2892B24")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600219B")]
			[Address(RVA = "0x2892B2C", Offset = "0x2892B2C", VA = "0x2892B2C")]
			set
			{
			}
		}

		// Token: 0x170004D7 RID: 1239
		// (get) Token: 0x0600219C RID: 8604 RVA: 0x0000CDB0 File Offset: 0x0000AFB0
		// (set) Token: 0x0600219D RID: 8605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004D7")]
		[DebuggerNonUserCode]
		public long LastDurabilityTime
		{
			[Token(Token = "0x600219C")]
			[Address(RVA = "0x2892B34", Offset = "0x2892B34", VA = "0x2892B34")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x600219D")]
			[Address(RVA = "0x2892B3C", Offset = "0x2892B3C", VA = "0x2892B3C")]
			set
			{
			}
		}

		// Token: 0x170004D8 RID: 1240
		// (get) Token: 0x0600219E RID: 8606 RVA: 0x0000CDC8 File Offset: 0x0000AFC8
		// (set) Token: 0x0600219F RID: 8607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004D8")]
		[DebuggerNonUserCode]
		public float DurabilitySpeed
		{
			[Token(Token = "0x600219E")]
			[Address(RVA = "0x2892B44", Offset = "0x2892B44", VA = "0x2892B44")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600219F")]
			[Address(RVA = "0x2892B4C", Offset = "0x2892B4C", VA = "0x2892B4C")]
			set
			{
			}
		}

		// Token: 0x060021A0 RID: 8608 RVA: 0x0000CDE0 File Offset: 0x0000AFE0
		[Token(Token = "0x60021A0")]
		[Address(RVA = "0x2892B54", Offset = "0x2892B54", VA = "0x2892B54", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x060021A1 RID: 8609 RVA: 0x0000CDF8 File Offset: 0x0000AFF8
		[Token(Token = "0x60021A1")]
		[Address(RVA = "0x2892BB8", Offset = "0x2892BB8", VA = "0x2892BB8", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(AllianceBuildingPointInfo other)
		{
			return default(bool);
		}

		// Token: 0x060021A2 RID: 8610 RVA: 0x0000CE10 File Offset: 0x0000B010
		[Token(Token = "0x60021A2")]
		[Address(RVA = "0x2892D2C", Offset = "0x2892D2C", VA = "0x2892D2C", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060021A3 RID: 8611 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021A3")]
		[Address(RVA = "0x2892F04", Offset = "0x2892F04", VA = "0x2892F04", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060021A4 RID: 8612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021A4")]
		[Address(RVA = "0x2892F5C", Offset = "0x2892F5C", VA = "0x2892F5C", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060021A5 RID: 8613 RVA: 0x0000CE28 File Offset: 0x0000B028
		[Token(Token = "0x60021A5")]
		[Address(RVA = "0x2893138", Offset = "0x2893138", VA = "0x2893138", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060021A6 RID: 8614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021A6")]
		[Address(RVA = "0x2893320", Offset = "0x2893320", VA = "0x2893320", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(AllianceBuildingPointInfo other)
		{
		}

		// Token: 0x060021A7 RID: 8615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021A7")]
		[Address(RVA = "0x28933F4", Offset = "0x28933F4", VA = "0x28933F4", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x04001F9A RID: 8090
		[Token(Token = "0x4001F9A")]
		[FieldOffset(Offset = "0x0")]
		private static readonly MessageParser<AllianceBuildingPointInfo> _parser;

		// Token: 0x04001F9B RID: 8091
		[Token(Token = "0x4001F9B")]
		[FieldOffset(Offset = "0x10")]
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001F9C RID: 8092
		[Token(Token = "0x4001F9C")]
		public const int UuidFieldNumber = 1;

		// Token: 0x04001F9D RID: 8093
		[Token(Token = "0x4001F9D")]
		[FieldOffset(Offset = "0x18")]
		private long uuid_;

		// Token: 0x04001F9E RID: 8094
		[Token(Token = "0x4001F9E")]
		public const int BuildIdFieldNumber = 2;

		// Token: 0x04001F9F RID: 8095
		[Token(Token = "0x4001F9F")]
		[FieldOffset(Offset = "0x20")]
		private int buildId_;

		// Token: 0x04001FA0 RID: 8096
		[Token(Token = "0x4001FA0")]
		public const int LevelFieldNumber = 3;

		// Token: 0x04001FA1 RID: 8097
		[Token(Token = "0x4001FA1")]
		[FieldOffset(Offset = "0x24")]
		private int level_;

		// Token: 0x04001FA2 RID: 8098
		[Token(Token = "0x4001FA2")]
		public const int StateFieldNumber = 4;

		// Token: 0x04001FA3 RID: 8099
		[Token(Token = "0x4001FA3")]
		[FieldOffset(Offset = "0x28")]
		private int state_;

		// Token: 0x04001FA4 RID: 8100
		[Token(Token = "0x4001FA4")]
		public const int AlAbbrFieldNumber = 5;

		// Token: 0x04001FA5 RID: 8101
		[Token(Token = "0x4001FA5")]
		[FieldOffset(Offset = "0x30")]
		private string alAbbr_;

		// Token: 0x04001FA6 RID: 8102
		[Token(Token = "0x4001FA6")]
		public const int AllianceIdFieldNumber = 6;

		// Token: 0x04001FA7 RID: 8103
		[Token(Token = "0x4001FA7")]
		[FieldOffset(Offset = "0x38")]
		private string allianceId_;

		// Token: 0x04001FA8 RID: 8104
		[Token(Token = "0x4001FA8")]
		public const int DurabilityFieldNumber = 7;

		// Token: 0x04001FA9 RID: 8105
		[Token(Token = "0x4001FA9")]
		[FieldOffset(Offset = "0x40")]
		private int durability_;

		// Token: 0x04001FAA RID: 8106
		[Token(Token = "0x4001FAA")]
		public const int LastDurabilityTimeFieldNumber = 8;

		// Token: 0x04001FAB RID: 8107
		[Token(Token = "0x4001FAB")]
		[FieldOffset(Offset = "0x48")]
		private long lastDurabilityTime_;

		// Token: 0x04001FAC RID: 8108
		[Token(Token = "0x4001FAC")]
		public const int DurabilitySpeedFieldNumber = 9;

		// Token: 0x04001FAD RID: 8109
		[Token(Token = "0x4001FAD")]
		[FieldOffset(Offset = "0x50")]
		private float durabilitySpeed_;
	}
}
