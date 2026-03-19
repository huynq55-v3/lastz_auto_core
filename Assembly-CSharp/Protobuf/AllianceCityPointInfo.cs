using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Protobuf
{
	// Token: 0x02000483 RID: 1155
	[Token(Token = "0x2000483")]
	public sealed class AllianceCityPointInfo : IMessage<AllianceCityPointInfo>, IMessage, IEquatable<AllianceCityPointInfo>, IDeepCloneable<AllianceCityPointInfo>
	{
		// Token: 0x170004B8 RID: 1208
		// (get) Token: 0x06002146 RID: 8518 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004B8")]
		[DebuggerNonUserCode]
		public static MessageParser<AllianceCityPointInfo> Parser
		{
			[Token(Token = "0x6002146")]
			[Address(RVA = "0x28909A0", Offset = "0x28909A0", VA = "0x28909A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004B9 RID: 1209
		// (get) Token: 0x06002147 RID: 8519 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004B9")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Token(Token = "0x6002147")]
			[Address(RVA = "0x28909F8", Offset = "0x28909F8", VA = "0x28909F8")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004BA RID: 1210
		// (get) Token: 0x06002148 RID: 8520 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004BA")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Token(Token = "0x6002148")]
			[Address(RVA = "0x2890AFC", Offset = "0x2890AFC", VA = "0x2890AFC", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002149 RID: 8521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002149")]
		[Address(RVA = "0x2890B48", Offset = "0x2890B48", VA = "0x2890B48")]
		[DebuggerNonUserCode]
		public AllianceCityPointInfo()
		{
		}

		// Token: 0x0600214A RID: 8522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600214A")]
		[Address(RVA = "0x2890BD0", Offset = "0x2890BD0", VA = "0x2890BD0")]
		[DebuggerNonUserCode]
		public AllianceCityPointInfo(AllianceCityPointInfo other)
		{
		}

		// Token: 0x0600214B RID: 8523 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600214B")]
		[Address(RVA = "0x2890C68", Offset = "0x2890C68", VA = "0x2890C68", Slot = "10")]
		[DebuggerNonUserCode]
		public AllianceCityPointInfo Clone()
		{
			return null;
		}

		// Token: 0x170004BB RID: 1211
		// (get) Token: 0x0600214C RID: 8524 RVA: 0x0000CB88 File Offset: 0x0000AD88
		// (set) Token: 0x0600214D RID: 8525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004BB")]
		[DebuggerNonUserCode]
		public int CityId
		{
			[Token(Token = "0x600214C")]
			[Address(RVA = "0x2890CC8", Offset = "0x2890CC8", VA = "0x2890CC8")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600214D")]
			[Address(RVA = "0x2890CD0", Offset = "0x2890CD0", VA = "0x2890CD0")]
			set
			{
			}
		}

		// Token: 0x170004BC RID: 1212
		// (get) Token: 0x0600214E RID: 8526 RVA: 0x0000CBA0 File Offset: 0x0000ADA0
		// (set) Token: 0x0600214F RID: 8527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004BC")]
		[DebuggerNonUserCode]
		public int OpenTime
		{
			[Token(Token = "0x600214E")]
			[Address(RVA = "0x2890CD8", Offset = "0x2890CD8", VA = "0x2890CD8")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600214F")]
			[Address(RVA = "0x2890CE0", Offset = "0x2890CE0", VA = "0x2890CE0")]
			set
			{
			}
		}

		// Token: 0x170004BD RID: 1213
		// (get) Token: 0x06002150 RID: 8528 RVA: 0x0000CBB8 File Offset: 0x0000ADB8
		// (set) Token: 0x06002151 RID: 8529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004BD")]
		[DebuggerNonUserCode]
		public int State
		{
			[Token(Token = "0x6002150")]
			[Address(RVA = "0x2890CE8", Offset = "0x2890CE8", VA = "0x2890CE8")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002151")]
			[Address(RVA = "0x2890CF0", Offset = "0x2890CF0", VA = "0x2890CF0")]
			set
			{
			}
		}

		// Token: 0x170004BE RID: 1214
		// (get) Token: 0x06002152 RID: 8530 RVA: 0x0000CBD0 File Offset: 0x0000ADD0
		// (set) Token: 0x06002153 RID: 8531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004BE")]
		[DebuggerNonUserCode]
		public int ProtectTime
		{
			[Token(Token = "0x6002152")]
			[Address(RVA = "0x2890CF8", Offset = "0x2890CF8", VA = "0x2890CF8")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002153")]
			[Address(RVA = "0x2890D00", Offset = "0x2890D00", VA = "0x2890D00")]
			set
			{
			}
		}

		// Token: 0x170004BF RID: 1215
		// (get) Token: 0x06002154 RID: 8532 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002155 RID: 8533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004BF")]
		[DebuggerNonUserCode]
		public string AlAbbr
		{
			[Token(Token = "0x6002154")]
			[Address(RVA = "0x2890D08", Offset = "0x2890D08", VA = "0x2890D08")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002155")]
			[Address(RVA = "0x2890D10", Offset = "0x2890D10", VA = "0x2890D10")]
			set
			{
			}
		}

		// Token: 0x170004C0 RID: 1216
		// (get) Token: 0x06002156 RID: 8534 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002157 RID: 8535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004C0")]
		[DebuggerNonUserCode]
		public string AllianceId
		{
			[Token(Token = "0x6002156")]
			[Address(RVA = "0x2890D8C", Offset = "0x2890D8C", VA = "0x2890D8C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002157")]
			[Address(RVA = "0x2890D94", Offset = "0x2890D94", VA = "0x2890D94")]
			set
			{
			}
		}

		// Token: 0x170004C1 RID: 1217
		// (get) Token: 0x06002158 RID: 8536 RVA: 0x0000CBE8 File Offset: 0x0000ADE8
		// (set) Token: 0x06002159 RID: 8537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004C1")]
		[DebuggerNonUserCode]
		public int Durability
		{
			[Token(Token = "0x6002158")]
			[Address(RVA = "0x2890E10", Offset = "0x2890E10", VA = "0x2890E10")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002159")]
			[Address(RVA = "0x2890E18", Offset = "0x2890E18", VA = "0x2890E18")]
			set
			{
			}
		}

		// Token: 0x170004C2 RID: 1218
		// (get) Token: 0x0600215A RID: 8538 RVA: 0x0000CC00 File Offset: 0x0000AE00
		// (set) Token: 0x0600215B RID: 8539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004C2")]
		[DebuggerNonUserCode]
		public int LastDurabilityTime
		{
			[Token(Token = "0x600215A")]
			[Address(RVA = "0x2890E20", Offset = "0x2890E20", VA = "0x2890E20")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600215B")]
			[Address(RVA = "0x2890E28", Offset = "0x2890E28", VA = "0x2890E28")]
			set
			{
			}
		}

		// Token: 0x170004C3 RID: 1219
		// (get) Token: 0x0600215C RID: 8540 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600215D RID: 8541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004C3")]
		[DebuggerNonUserCode]
		public string AlName
		{
			[Token(Token = "0x600215C")]
			[Address(RVA = "0x2890E30", Offset = "0x2890E30", VA = "0x2890E30")]
			get
			{
				return null;
			}
			[Token(Token = "0x600215D")]
			[Address(RVA = "0x2890E38", Offset = "0x2890E38", VA = "0x2890E38")]
			set
			{
			}
		}

		// Token: 0x170004C4 RID: 1220
		// (get) Token: 0x0600215E RID: 8542 RVA: 0x0000CC18 File Offset: 0x0000AE18
		// (set) Token: 0x0600215F RID: 8543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004C4")]
		[DebuggerNonUserCode]
		public int GiveUpTime
		{
			[Token(Token = "0x600215E")]
			[Address(RVA = "0x2890EB4", Offset = "0x2890EB4", VA = "0x2890EB4")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600215F")]
			[Address(RVA = "0x2890EBC", Offset = "0x2890EBC", VA = "0x2890EBC")]
			set
			{
			}
		}

		// Token: 0x170004C5 RID: 1221
		// (get) Token: 0x06002160 RID: 8544 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002161 RID: 8545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004C5")]
		[DebuggerNonUserCode]
		public string CityName
		{
			[Token(Token = "0x6002160")]
			[Address(RVA = "0x2890EC4", Offset = "0x2890EC4", VA = "0x2890EC4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002161")]
			[Address(RVA = "0x2890ECC", Offset = "0x2890ECC", VA = "0x2890ECC")]
			set
			{
			}
		}

		// Token: 0x06002162 RID: 8546 RVA: 0x0000CC30 File Offset: 0x0000AE30
		[Token(Token = "0x6002162")]
		[Address(RVA = "0x2890F48", Offset = "0x2890F48", VA = "0x2890F48", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06002163 RID: 8547 RVA: 0x0000CC48 File Offset: 0x0000AE48
		[Token(Token = "0x6002163")]
		[Address(RVA = "0x2890FAC", Offset = "0x2890FAC", VA = "0x2890FAC", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(AllianceCityPointInfo other)
		{
			return default(bool);
		}

		// Token: 0x06002164 RID: 8548 RVA: 0x0000CC60 File Offset: 0x0000AE60
		[Token(Token = "0x6002164")]
		[Address(RVA = "0x28910B8", Offset = "0x28910B8", VA = "0x28910B8", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06002165 RID: 8549 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002165")]
		[Address(RVA = "0x2891240", Offset = "0x2891240", VA = "0x2891240", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06002166 RID: 8550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002166")]
		[Address(RVA = "0x2891298", Offset = "0x2891298", VA = "0x2891298", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06002167 RID: 8551 RVA: 0x0000CC78 File Offset: 0x0000AE78
		[Token(Token = "0x6002167")]
		[Address(RVA = "0x28914D8", Offset = "0x28914D8", VA = "0x28914D8", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06002168 RID: 8552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002168")]
		[Address(RVA = "0x289173C", Offset = "0x289173C", VA = "0x289173C", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(AllianceCityPointInfo other)
		{
		}

		// Token: 0x06002169 RID: 8553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002169")]
		[Address(RVA = "0x289183C", Offset = "0x289183C", VA = "0x289183C", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x04001F76 RID: 8054
		[Token(Token = "0x4001F76")]
		[FieldOffset(Offset = "0x0")]
		private static readonly MessageParser<AllianceCityPointInfo> _parser;

		// Token: 0x04001F77 RID: 8055
		[Token(Token = "0x4001F77")]
		[FieldOffset(Offset = "0x10")]
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001F78 RID: 8056
		[Token(Token = "0x4001F78")]
		public const int CityIdFieldNumber = 1;

		// Token: 0x04001F79 RID: 8057
		[Token(Token = "0x4001F79")]
		[FieldOffset(Offset = "0x18")]
		private int cityId_;

		// Token: 0x04001F7A RID: 8058
		[Token(Token = "0x4001F7A")]
		public const int OpenTimeFieldNumber = 2;

		// Token: 0x04001F7B RID: 8059
		[Token(Token = "0x4001F7B")]
		[FieldOffset(Offset = "0x1C")]
		private int openTime_;

		// Token: 0x04001F7C RID: 8060
		[Token(Token = "0x4001F7C")]
		public const int StateFieldNumber = 3;

		// Token: 0x04001F7D RID: 8061
		[Token(Token = "0x4001F7D")]
		[FieldOffset(Offset = "0x20")]
		private int state_;

		// Token: 0x04001F7E RID: 8062
		[Token(Token = "0x4001F7E")]
		public const int ProtectTimeFieldNumber = 4;

		// Token: 0x04001F7F RID: 8063
		[Token(Token = "0x4001F7F")]
		[FieldOffset(Offset = "0x24")]
		private int protectTime_;

		// Token: 0x04001F80 RID: 8064
		[Token(Token = "0x4001F80")]
		public const int AlAbbrFieldNumber = 5;

		// Token: 0x04001F81 RID: 8065
		[Token(Token = "0x4001F81")]
		[FieldOffset(Offset = "0x28")]
		private string alAbbr_;

		// Token: 0x04001F82 RID: 8066
		[Token(Token = "0x4001F82")]
		public const int AllianceIdFieldNumber = 7;

		// Token: 0x04001F83 RID: 8067
		[Token(Token = "0x4001F83")]
		[FieldOffset(Offset = "0x30")]
		private string allianceId_;

		// Token: 0x04001F84 RID: 8068
		[Token(Token = "0x4001F84")]
		public const int DurabilityFieldNumber = 8;

		// Token: 0x04001F85 RID: 8069
		[Token(Token = "0x4001F85")]
		[FieldOffset(Offset = "0x38")]
		private int durability_;

		// Token: 0x04001F86 RID: 8070
		[Token(Token = "0x4001F86")]
		public const int LastDurabilityTimeFieldNumber = 9;

		// Token: 0x04001F87 RID: 8071
		[Token(Token = "0x4001F87")]
		[FieldOffset(Offset = "0x3C")]
		private int lastDurabilityTime_;

		// Token: 0x04001F88 RID: 8072
		[Token(Token = "0x4001F88")]
		public const int AlNameFieldNumber = 10;

		// Token: 0x04001F89 RID: 8073
		[Token(Token = "0x4001F89")]
		[FieldOffset(Offset = "0x40")]
		private string alName_;

		// Token: 0x04001F8A RID: 8074
		[Token(Token = "0x4001F8A")]
		public const int GiveUpTimeFieldNumber = 11;

		// Token: 0x04001F8B RID: 8075
		[Token(Token = "0x4001F8B")]
		[FieldOffset(Offset = "0x48")]
		private int giveUpTime_;

		// Token: 0x04001F8C RID: 8076
		[Token(Token = "0x4001F8C")]
		public const int CityNameFieldNumber = 12;

		// Token: 0x04001F8D RID: 8077
		[Token(Token = "0x4001F8D")]
		[FieldOffset(Offset = "0x50")]
		private string cityName_;
	}
}
