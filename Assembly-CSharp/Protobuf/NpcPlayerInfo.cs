using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Protobuf
{
	// Token: 0x02000470 RID: 1136
	[Token(Token = "0x2000470")]
	public sealed class NpcPlayerInfo : IMessage<NpcPlayerInfo>, IMessage, IEquatable<NpcPlayerInfo>, IDeepCloneable<NpcPlayerInfo>
	{
		// Token: 0x1700045D RID: 1117
		// (get) Token: 0x06002026 RID: 8230 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700045D")]
		[DebuggerNonUserCode]
		public static MessageParser<NpcPlayerInfo> Parser
		{
			[Token(Token = "0x6002026")]
			[Address(RVA = "0x25AE110", Offset = "0x25AE110", VA = "0x25AE110")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700045E RID: 1118
		// (get) Token: 0x06002027 RID: 8231 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700045E")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Token(Token = "0x6002027")]
			[Address(RVA = "0x25AE168", Offset = "0x25AE168", VA = "0x25AE168")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700045F RID: 1119
		// (get) Token: 0x06002028 RID: 8232 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700045F")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Token(Token = "0x6002028")]
			[Address(RVA = "0x25AE26C", Offset = "0x25AE26C", VA = "0x25AE26C", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002029 RID: 8233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002029")]
		[Address(RVA = "0x25AE2B8", Offset = "0x25AE2B8", VA = "0x25AE2B8")]
		[DebuggerNonUserCode]
		public NpcPlayerInfo()
		{
		}

		// Token: 0x0600202A RID: 8234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600202A")]
		[Address(RVA = "0x25AE330", Offset = "0x25AE330", VA = "0x25AE330")]
		[DebuggerNonUserCode]
		public NpcPlayerInfo(NpcPlayerInfo other)
		{
		}

		// Token: 0x0600202B RID: 8235 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600202B")]
		[Address(RVA = "0x25AE3C8", Offset = "0x25AE3C8", VA = "0x25AE3C8", Slot = "10")]
		[DebuggerNonUserCode]
		public NpcPlayerInfo Clone()
		{
			return null;
		}

		// Token: 0x17000460 RID: 1120
		// (get) Token: 0x0600202C RID: 8236 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600202D RID: 8237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000460")]
		[DebuggerNonUserCode]
		public string Name
		{
			[Token(Token = "0x600202C")]
			[Address(RVA = "0x25AE428", Offset = "0x25AE428", VA = "0x25AE428")]
			get
			{
				return null;
			}
			[Token(Token = "0x600202D")]
			[Address(RVA = "0x25AE430", Offset = "0x25AE430", VA = "0x25AE430")]
			set
			{
			}
		}

		// Token: 0x17000461 RID: 1121
		// (get) Token: 0x0600202E RID: 8238 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600202F RID: 8239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000461")]
		[DebuggerNonUserCode]
		public string Pic
		{
			[Token(Token = "0x600202E")]
			[Address(RVA = "0x25AE4AC", Offset = "0x25AE4AC", VA = "0x25AE4AC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600202F")]
			[Address(RVA = "0x25AE4B4", Offset = "0x25AE4B4", VA = "0x25AE4B4")]
			set
			{
			}
		}

		// Token: 0x17000462 RID: 1122
		// (get) Token: 0x06002030 RID: 8240 RVA: 0x0000C3F0 File Offset: 0x0000A5F0
		// (set) Token: 0x06002031 RID: 8241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000462")]
		[DebuggerNonUserCode]
		public int SrcServerId
		{
			[Token(Token = "0x6002030")]
			[Address(RVA = "0x25AE530", Offset = "0x25AE530", VA = "0x25AE530")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002031")]
			[Address(RVA = "0x25AE538", Offset = "0x25AE538", VA = "0x25AE538")]
			set
			{
			}
		}

		// Token: 0x17000463 RID: 1123
		// (get) Token: 0x06002032 RID: 8242 RVA: 0x0000C408 File Offset: 0x0000A608
		// (set) Token: 0x06002033 RID: 8243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000463")]
		[DebuggerNonUserCode]
		public int PointId
		{
			[Token(Token = "0x6002032")]
			[Address(RVA = "0x25AE540", Offset = "0x25AE540", VA = "0x25AE540")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002033")]
			[Address(RVA = "0x25AE548", Offset = "0x25AE548", VA = "0x25AE548")]
			set
			{
			}
		}

		// Token: 0x17000464 RID: 1124
		// (get) Token: 0x06002034 RID: 8244 RVA: 0x0000C420 File Offset: 0x0000A620
		// (set) Token: 0x06002035 RID: 8245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000464")]
		[DebuggerNonUserCode]
		public int NpcId
		{
			[Token(Token = "0x6002034")]
			[Address(RVA = "0x25AE550", Offset = "0x25AE550", VA = "0x25AE550")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002035")]
			[Address(RVA = "0x25AE558", Offset = "0x25AE558", VA = "0x25AE558")]
			set
			{
			}
		}

		// Token: 0x17000465 RID: 1125
		// (get) Token: 0x06002036 RID: 8246 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002037 RID: 8247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000465")]
		[DebuggerNonUserCode]
		public string Country
		{
			[Token(Token = "0x6002036")]
			[Address(RVA = "0x25AE560", Offset = "0x25AE560", VA = "0x25AE560")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002037")]
			[Address(RVA = "0x25AE568", Offset = "0x25AE568", VA = "0x25AE568")]
			set
			{
			}
		}

		// Token: 0x17000466 RID: 1126
		// (get) Token: 0x06002038 RID: 8248 RVA: 0x0000C438 File Offset: 0x0000A638
		// (set) Token: 0x06002039 RID: 8249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000466")]
		[DebuggerNonUserCode]
		public int KillNum
		{
			[Token(Token = "0x6002038")]
			[Address(RVA = "0x25AE5E4", Offset = "0x25AE5E4", VA = "0x25AE5E4")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002039")]
			[Address(RVA = "0x25AE5EC", Offset = "0x25AE5EC", VA = "0x25AE5EC")]
			set
			{
			}
		}

		// Token: 0x17000467 RID: 1127
		// (get) Token: 0x0600203A RID: 8250 RVA: 0x0000C450 File Offset: 0x0000A650
		// (set) Token: 0x0600203B RID: 8251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000467")]
		[DebuggerNonUserCode]
		public int Power
		{
			[Token(Token = "0x600203A")]
			[Address(RVA = "0x25AE5F4", Offset = "0x25AE5F4", VA = "0x25AE5F4")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600203B")]
			[Address(RVA = "0x25AE5FC", Offset = "0x25AE5FC", VA = "0x25AE5FC")]
			set
			{
			}
		}

		// Token: 0x17000468 RID: 1128
		// (get) Token: 0x0600203C RID: 8252 RVA: 0x0000C468 File Offset: 0x0000A668
		// (set) Token: 0x0600203D RID: 8253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000468")]
		[DebuggerNonUserCode]
		public int Win
		{
			[Token(Token = "0x600203C")]
			[Address(RVA = "0x25AE604", Offset = "0x25AE604", VA = "0x25AE604")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600203D")]
			[Address(RVA = "0x25AE60C", Offset = "0x25AE60C", VA = "0x25AE60C")]
			set
			{
			}
		}

		// Token: 0x17000469 RID: 1129
		// (get) Token: 0x0600203E RID: 8254 RVA: 0x0000C480 File Offset: 0x0000A680
		// (set) Token: 0x0600203F RID: 8255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000469")]
		[DebuggerNonUserCode]
		public int Lose
		{
			[Token(Token = "0x600203E")]
			[Address(RVA = "0x25AE614", Offset = "0x25AE614", VA = "0x25AE614")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600203F")]
			[Address(RVA = "0x25AE61C", Offset = "0x25AE61C", VA = "0x25AE61C")]
			set
			{
			}
		}

		// Token: 0x1700046A RID: 1130
		// (get) Token: 0x06002040 RID: 8256 RVA: 0x0000C498 File Offset: 0x0000A698
		// (set) Token: 0x06002041 RID: 8257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700046A")]
		[DebuggerNonUserCode]
		public int DeadNum
		{
			[Token(Token = "0x6002040")]
			[Address(RVA = "0x25AE624", Offset = "0x25AE624", VA = "0x25AE624")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002041")]
			[Address(RVA = "0x25AE62C", Offset = "0x25AE62C", VA = "0x25AE62C")]
			set
			{
			}
		}

		// Token: 0x1700046B RID: 1131
		// (get) Token: 0x06002042 RID: 8258 RVA: 0x0000C4B0 File Offset: 0x0000A6B0
		// (set) Token: 0x06002043 RID: 8259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700046B")]
		[DebuggerNonUserCode]
		public int DectNum
		{
			[Token(Token = "0x6002042")]
			[Address(RVA = "0x25AE634", Offset = "0x25AE634", VA = "0x25AE634")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002043")]
			[Address(RVA = "0x25AE63C", Offset = "0x25AE63C", VA = "0x25AE63C")]
			set
			{
			}
		}

		// Token: 0x06002044 RID: 8260 RVA: 0x0000C4C8 File Offset: 0x0000A6C8
		[Token(Token = "0x6002044")]
		[Address(RVA = "0x25AE644", Offset = "0x25AE644", VA = "0x25AE644", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06002045 RID: 8261 RVA: 0x0000C4E0 File Offset: 0x0000A6E0
		[Token(Token = "0x6002045")]
		[Address(RVA = "0x25AE6A8", Offset = "0x25AE6A8", VA = "0x25AE6A8", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(NpcPlayerInfo other)
		{
			return default(bool);
		}

		// Token: 0x06002046 RID: 8262 RVA: 0x0000C4F8 File Offset: 0x0000A6F8
		[Token(Token = "0x6002046")]
		[Address(RVA = "0x25AE7C0", Offset = "0x25AE7C0", VA = "0x25AE7C0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06002047 RID: 8263 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002047")]
		[Address(RVA = "0x25AE960", Offset = "0x25AE960", VA = "0x25AE960", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06002048 RID: 8264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002048")]
		[Address(RVA = "0x25AE9B8", Offset = "0x25AE9B8", VA = "0x25AE9B8", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06002049 RID: 8265 RVA: 0x0000C510 File Offset: 0x0000A710
		[Token(Token = "0x6002049")]
		[Address(RVA = "0x25AEC1C", Offset = "0x25AEC1C", VA = "0x25AEC1C", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600204A RID: 8266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600204A")]
		[Address(RVA = "0x25AEEAC", Offset = "0x25AEEAC", VA = "0x25AEEAC", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(NpcPlayerInfo other)
		{
		}

		// Token: 0x0600204B RID: 8267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600204B")]
		[Address(RVA = "0x25AEFAC", Offset = "0x25AEFAC", VA = "0x25AEFAC", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x04001EDA RID: 7898
		[Token(Token = "0x4001EDA")]
		[FieldOffset(Offset = "0x0")]
		private static readonly MessageParser<NpcPlayerInfo> _parser;

		// Token: 0x04001EDB RID: 7899
		[Token(Token = "0x4001EDB")]
		[FieldOffset(Offset = "0x10")]
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001EDC RID: 7900
		[Token(Token = "0x4001EDC")]
		public const int NameFieldNumber = 1;

		// Token: 0x04001EDD RID: 7901
		[Token(Token = "0x4001EDD")]
		[FieldOffset(Offset = "0x18")]
		private string name_;

		// Token: 0x04001EDE RID: 7902
		[Token(Token = "0x4001EDE")]
		public const int PicFieldNumber = 2;

		// Token: 0x04001EDF RID: 7903
		[Token(Token = "0x4001EDF")]
		[FieldOffset(Offset = "0x20")]
		private string pic_;

		// Token: 0x04001EE0 RID: 7904
		[Token(Token = "0x4001EE0")]
		public const int SrcServerIdFieldNumber = 3;

		// Token: 0x04001EE1 RID: 7905
		[Token(Token = "0x4001EE1")]
		[FieldOffset(Offset = "0x28")]
		private int srcServerId_;

		// Token: 0x04001EE2 RID: 7906
		[Token(Token = "0x4001EE2")]
		public const int PointIdFieldNumber = 4;

		// Token: 0x04001EE3 RID: 7907
		[Token(Token = "0x4001EE3")]
		[FieldOffset(Offset = "0x2C")]
		private int pointId_;

		// Token: 0x04001EE4 RID: 7908
		[Token(Token = "0x4001EE4")]
		public const int NpcIdFieldNumber = 5;

		// Token: 0x04001EE5 RID: 7909
		[Token(Token = "0x4001EE5")]
		[FieldOffset(Offset = "0x30")]
		private int npcId_;

		// Token: 0x04001EE6 RID: 7910
		[Token(Token = "0x4001EE6")]
		public const int CountryFieldNumber = 6;

		// Token: 0x04001EE7 RID: 7911
		[Token(Token = "0x4001EE7")]
		[FieldOffset(Offset = "0x38")]
		private string country_;

		// Token: 0x04001EE8 RID: 7912
		[Token(Token = "0x4001EE8")]
		public const int KillNumFieldNumber = 7;

		// Token: 0x04001EE9 RID: 7913
		[Token(Token = "0x4001EE9")]
		[FieldOffset(Offset = "0x40")]
		private int killNum_;

		// Token: 0x04001EEA RID: 7914
		[Token(Token = "0x4001EEA")]
		public const int PowerFieldNumber = 8;

		// Token: 0x04001EEB RID: 7915
		[Token(Token = "0x4001EEB")]
		[FieldOffset(Offset = "0x44")]
		private int power_;

		// Token: 0x04001EEC RID: 7916
		[Token(Token = "0x4001EEC")]
		public const int WinFieldNumber = 9;

		// Token: 0x04001EED RID: 7917
		[Token(Token = "0x4001EED")]
		[FieldOffset(Offset = "0x48")]
		private int win_;

		// Token: 0x04001EEE RID: 7918
		[Token(Token = "0x4001EEE")]
		public const int LoseFieldNumber = 10;

		// Token: 0x04001EEF RID: 7919
		[Token(Token = "0x4001EEF")]
		[FieldOffset(Offset = "0x4C")]
		private int lose_;

		// Token: 0x04001EF0 RID: 7920
		[Token(Token = "0x4001EF0")]
		public const int DeadNumFieldNumber = 11;

		// Token: 0x04001EF1 RID: 7921
		[Token(Token = "0x4001EF1")]
		[FieldOffset(Offset = "0x50")]
		private int deadNum_;

		// Token: 0x04001EF2 RID: 7922
		[Token(Token = "0x4001EF2")]
		public const int DectNumFieldNumber = 12;

		// Token: 0x04001EF3 RID: 7923
		[Token(Token = "0x4001EF3")]
		[FieldOffset(Offset = "0x54")]
		private int dectNum_;
	}
}
