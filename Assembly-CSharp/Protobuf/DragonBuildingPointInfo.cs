using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Protobuf
{
	// Token: 0x02000495 RID: 1173
	[Token(Token = "0x2000495")]
	public sealed class DragonBuildingPointInfo : IMessage<DragonBuildingPointInfo>, IMessage, IEquatable<DragonBuildingPointInfo>, IDeepCloneable<DragonBuildingPointInfo>
	{
		// Token: 0x17000515 RID: 1301
		// (get) Token: 0x0600226C RID: 8812 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000515")]
		[DebuggerNonUserCode]
		public static MessageParser<DragonBuildingPointInfo> Parser
		{
			[Token(Token = "0x600226C")]
			[Address(RVA = "0x29F8348", Offset = "0x29F8348", VA = "0x29F8348")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000516 RID: 1302
		// (get) Token: 0x0600226D RID: 8813 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000516")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Token(Token = "0x600226D")]
			[Address(RVA = "0x29F83A0", Offset = "0x29F83A0", VA = "0x29F83A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000517 RID: 1303
		// (get) Token: 0x0600226E RID: 8814 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000517")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Token(Token = "0x600226E")]
			[Address(RVA = "0x29F84A4", Offset = "0x29F84A4", VA = "0x29F84A4", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600226F RID: 8815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600226F")]
		[Address(RVA = "0x29F84F0", Offset = "0x29F84F0", VA = "0x29F84F0")]
		[DebuggerNonUserCode]
		public DragonBuildingPointInfo()
		{
		}

		// Token: 0x06002270 RID: 8816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002270")]
		[Address(RVA = "0x29F8558", Offset = "0x29F8558", VA = "0x29F8558")]
		[DebuggerNonUserCode]
		public DragonBuildingPointInfo(DragonBuildingPointInfo other)
		{
		}

		// Token: 0x06002271 RID: 8817 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002271")]
		[Address(RVA = "0x29F85E0", Offset = "0x29F85E0", VA = "0x29F85E0", Slot = "10")]
		[DebuggerNonUserCode]
		public DragonBuildingPointInfo Clone()
		{
			return null;
		}

		// Token: 0x17000518 RID: 1304
		// (get) Token: 0x06002272 RID: 8818 RVA: 0x0000D350 File Offset: 0x0000B550
		// (set) Token: 0x06002273 RID: 8819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000518")]
		[DebuggerNonUserCode]
		public long Uuid
		{
			[Token(Token = "0x6002272")]
			[Address(RVA = "0x29F8640", Offset = "0x29F8640", VA = "0x29F8640")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x6002273")]
			[Address(RVA = "0x29F8648", Offset = "0x29F8648", VA = "0x29F8648")]
			set
			{
			}
		}

		// Token: 0x17000519 RID: 1305
		// (get) Token: 0x06002274 RID: 8820 RVA: 0x0000D368 File Offset: 0x0000B568
		// (set) Token: 0x06002275 RID: 8821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000519")]
		[DebuggerNonUserCode]
		public int BuildId
		{
			[Token(Token = "0x6002274")]
			[Address(RVA = "0x29F8650", Offset = "0x29F8650", VA = "0x29F8650")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002275")]
			[Address(RVA = "0x29F8658", Offset = "0x29F8658", VA = "0x29F8658")]
			set
			{
			}
		}

		// Token: 0x1700051A RID: 1306
		// (get) Token: 0x06002276 RID: 8822 RVA: 0x0000D380 File Offset: 0x0000B580
		// (set) Token: 0x06002277 RID: 8823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700051A")]
		[DebuggerNonUserCode]
		public int State
		{
			[Token(Token = "0x6002276")]
			[Address(RVA = "0x29F8660", Offset = "0x29F8660", VA = "0x29F8660")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002277")]
			[Address(RVA = "0x29F8668", Offset = "0x29F8668", VA = "0x29F8668")]
			set
			{
			}
		}

		// Token: 0x1700051B RID: 1307
		// (get) Token: 0x06002278 RID: 8824 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002279 RID: 8825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700051B")]
		[DebuggerNonUserCode]
		public string AlAbbr
		{
			[Token(Token = "0x6002278")]
			[Address(RVA = "0x29F8670", Offset = "0x29F8670", VA = "0x29F8670")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002279")]
			[Address(RVA = "0x29F8678", Offset = "0x29F8678", VA = "0x29F8678")]
			set
			{
			}
		}

		// Token: 0x1700051C RID: 1308
		// (get) Token: 0x0600227A RID: 8826 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600227B RID: 8827 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700051C")]
		[DebuggerNonUserCode]
		public string AllianceId
		{
			[Token(Token = "0x600227A")]
			[Address(RVA = "0x29F86F4", Offset = "0x29F86F4", VA = "0x29F86F4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600227B")]
			[Address(RVA = "0x29F86FC", Offset = "0x29F86FC", VA = "0x29F86FC")]
			set
			{
			}
		}

		// Token: 0x1700051D RID: 1309
		// (get) Token: 0x0600227C RID: 8828 RVA: 0x0000D398 File Offset: 0x0000B598
		// (set) Token: 0x0600227D RID: 8829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700051D")]
		[DebuggerNonUserCode]
		public long OccupyTime
		{
			[Token(Token = "0x600227C")]
			[Address(RVA = "0x29F8778", Offset = "0x29F8778", VA = "0x29F8778")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x600227D")]
			[Address(RVA = "0x29F8780", Offset = "0x29F8780", VA = "0x29F8780")]
			set
			{
			}
		}

		// Token: 0x1700051E RID: 1310
		// (get) Token: 0x0600227E RID: 8830 RVA: 0x0000D3B0 File Offset: 0x0000B5B0
		// (set) Token: 0x0600227F RID: 8831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700051E")]
		[DebuggerNonUserCode]
		public long OpenTime
		{
			[Token(Token = "0x600227E")]
			[Address(RVA = "0x29F8788", Offset = "0x29F8788", VA = "0x29F8788")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x600227F")]
			[Address(RVA = "0x29F8790", Offset = "0x29F8790", VA = "0x29F8790")]
			set
			{
			}
		}

		// Token: 0x1700051F RID: 1311
		// (get) Token: 0x06002280 RID: 8832 RVA: 0x0000D3C8 File Offset: 0x0000B5C8
		// (set) Token: 0x06002281 RID: 8833 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700051F")]
		[DebuggerNonUserCode]
		public long StartTime
		{
			[Token(Token = "0x6002280")]
			[Address(RVA = "0x29F8798", Offset = "0x29F8798", VA = "0x29F8798")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x6002281")]
			[Address(RVA = "0x29F87A0", Offset = "0x29F87A0", VA = "0x29F87A0")]
			set
			{
			}
		}

		// Token: 0x17000520 RID: 1312
		// (get) Token: 0x06002282 RID: 8834 RVA: 0x0000D3E0 File Offset: 0x0000B5E0
		// (set) Token: 0x06002283 RID: 8835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000520")]
		[DebuggerNonUserCode]
		public long ProtectTime
		{
			[Token(Token = "0x6002282")]
			[Address(RVA = "0x29F87A8", Offset = "0x29F87A8", VA = "0x29F87A8")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x6002283")]
			[Address(RVA = "0x29F87B0", Offset = "0x29F87B0", VA = "0x29F87B0")]
			set
			{
			}
		}

		// Token: 0x17000521 RID: 1313
		// (get) Token: 0x06002284 RID: 8836 RVA: 0x0000D3F8 File Offset: 0x0000B5F8
		// (set) Token: 0x06002285 RID: 8837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000521")]
		[DebuggerNonUserCode]
		public int RewardCount
		{
			[Token(Token = "0x6002284")]
			[Address(RVA = "0x29F87B8", Offset = "0x29F87B8", VA = "0x29F87B8")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002285")]
			[Address(RVA = "0x29F87C0", Offset = "0x29F87C0", VA = "0x29F87C0")]
			set
			{
			}
		}

		// Token: 0x06002286 RID: 8838 RVA: 0x0000D410 File Offset: 0x0000B610
		[Token(Token = "0x6002286")]
		[Address(RVA = "0x29F87C8", Offset = "0x29F87C8", VA = "0x29F87C8", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06002287 RID: 8839 RVA: 0x0000D428 File Offset: 0x0000B628
		[Token(Token = "0x6002287")]
		[Address(RVA = "0x29F882C", Offset = "0x29F882C", VA = "0x29F882C", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(DragonBuildingPointInfo other)
		{
			return default(bool);
		}

		// Token: 0x06002288 RID: 8840 RVA: 0x0000D440 File Offset: 0x0000B640
		[Token(Token = "0x6002288")]
		[Address(RVA = "0x29F8920", Offset = "0x29F8920", VA = "0x29F8920", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06002289 RID: 8841 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002289")]
		[Address(RVA = "0x29F8A8C", Offset = "0x29F8A8C", VA = "0x29F8A8C", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600228A RID: 8842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600228A")]
		[Address(RVA = "0x29F8AE4", Offset = "0x29F8AE4", VA = "0x29F8AE4", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600228B RID: 8843 RVA: 0x0000D458 File Offset: 0x0000B658
		[Token(Token = "0x600228B")]
		[Address(RVA = "0x29F8CE8", Offset = "0x29F8CE8", VA = "0x29F8CE8", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600228C RID: 8844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600228C")]
		[Address(RVA = "0x29F8F10", Offset = "0x29F8F10", VA = "0x29F8F10", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(DragonBuildingPointInfo other)
		{
		}

		// Token: 0x0600228D RID: 8845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600228D")]
		[Address(RVA = "0x29F8FEC", Offset = "0x29F8FEC", VA = "0x29F8FEC", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x04002015 RID: 8213
		[Token(Token = "0x4002015")]
		[FieldOffset(Offset = "0x0")]
		private static readonly MessageParser<DragonBuildingPointInfo> _parser;

		// Token: 0x04002016 RID: 8214
		[Token(Token = "0x4002016")]
		[FieldOffset(Offset = "0x10")]
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002017 RID: 8215
		[Token(Token = "0x4002017")]
		public const int UuidFieldNumber = 1;

		// Token: 0x04002018 RID: 8216
		[Token(Token = "0x4002018")]
		[FieldOffset(Offset = "0x18")]
		private long uuid_;

		// Token: 0x04002019 RID: 8217
		[Token(Token = "0x4002019")]
		public const int BuildIdFieldNumber = 2;

		// Token: 0x0400201A RID: 8218
		[Token(Token = "0x400201A")]
		[FieldOffset(Offset = "0x20")]
		private int buildId_;

		// Token: 0x0400201B RID: 8219
		[Token(Token = "0x400201B")]
		public const int StateFieldNumber = 3;

		// Token: 0x0400201C RID: 8220
		[Token(Token = "0x400201C")]
		[FieldOffset(Offset = "0x24")]
		private int state_;

		// Token: 0x0400201D RID: 8221
		[Token(Token = "0x400201D")]
		public const int AlAbbrFieldNumber = 4;

		// Token: 0x0400201E RID: 8222
		[Token(Token = "0x400201E")]
		[FieldOffset(Offset = "0x28")]
		private string alAbbr_;

		// Token: 0x0400201F RID: 8223
		[Token(Token = "0x400201F")]
		public const int AllianceIdFieldNumber = 5;

		// Token: 0x04002020 RID: 8224
		[Token(Token = "0x4002020")]
		[FieldOffset(Offset = "0x30")]
		private string allianceId_;

		// Token: 0x04002021 RID: 8225
		[Token(Token = "0x4002021")]
		public const int OccupyTimeFieldNumber = 6;

		// Token: 0x04002022 RID: 8226
		[Token(Token = "0x4002022")]
		[FieldOffset(Offset = "0x38")]
		private long occupyTime_;

		// Token: 0x04002023 RID: 8227
		[Token(Token = "0x4002023")]
		public const int OpenTimeFieldNumber = 7;

		// Token: 0x04002024 RID: 8228
		[Token(Token = "0x4002024")]
		[FieldOffset(Offset = "0x40")]
		private long openTime_;

		// Token: 0x04002025 RID: 8229
		[Token(Token = "0x4002025")]
		public const int StartTimeFieldNumber = 8;

		// Token: 0x04002026 RID: 8230
		[Token(Token = "0x4002026")]
		[FieldOffset(Offset = "0x48")]
		private long startTime_;

		// Token: 0x04002027 RID: 8231
		[Token(Token = "0x4002027")]
		public const int ProtectTimeFieldNumber = 9;

		// Token: 0x04002028 RID: 8232
		[Token(Token = "0x4002028")]
		[FieldOffset(Offset = "0x50")]
		private long protectTime_;

		// Token: 0x04002029 RID: 8233
		[Token(Token = "0x4002029")]
		public const int RewardCountFieldNumber = 10;

		// Token: 0x0400202A RID: 8234
		[Token(Token = "0x400202A")]
		[FieldOffset(Offset = "0x58")]
		private int rewardCount_;
	}
}
