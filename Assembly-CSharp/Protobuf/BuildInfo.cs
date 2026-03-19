using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Protobuf
{
	// Token: 0x02000473 RID: 1139
	[Token(Token = "0x2000473")]
	public sealed class BuildInfo : IMessage<BuildInfo>, IMessage, IEquatable<BuildInfo>, IDeepCloneable<BuildInfo>
	{
		// Token: 0x1700046D RID: 1133
		// (get) Token: 0x06002052 RID: 8274 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700046D")]
		[DebuggerNonUserCode]
		public static MessageParser<BuildInfo> Parser
		{
			[Token(Token = "0x6002052")]
			[Address(RVA = "0x2889DAC", Offset = "0x2889DAC", VA = "0x2889DAC")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700046E RID: 1134
		// (get) Token: 0x06002053 RID: 8275 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700046E")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Token(Token = "0x6002053")]
			[Address(RVA = "0x2889E04", Offset = "0x2889E04", VA = "0x2889E04")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700046F RID: 1135
		// (get) Token: 0x06002054 RID: 8276 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700046F")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Token(Token = "0x6002054")]
			[Address(RVA = "0x2889F08", Offset = "0x2889F08", VA = "0x2889F08", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002055 RID: 8277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002055")]
		[Address(RVA = "0x2889F54", Offset = "0x2889F54", VA = "0x2889F54")]
		[DebuggerNonUserCode]
		public BuildInfo()
		{
		}

		// Token: 0x06002056 RID: 8278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002056")]
		[Address(RVA = "0x288A098", Offset = "0x288A098", VA = "0x288A098")]
		[DebuggerNonUserCode]
		public BuildInfo(BuildInfo other)
		{
		}

		// Token: 0x06002057 RID: 8279 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002057")]
		[Address(RVA = "0x288A1FC", Offset = "0x288A1FC", VA = "0x288A1FC", Slot = "10")]
		[DebuggerNonUserCode]
		public BuildInfo Clone()
		{
			return null;
		}

		// Token: 0x17000470 RID: 1136
		// (get) Token: 0x06002058 RID: 8280 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002059 RID: 8281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000470")]
		[DebuggerNonUserCode]
		public string OwnerUid
		{
			[Token(Token = "0x6002058")]
			[Address(RVA = "0x288A25C", Offset = "0x288A25C", VA = "0x288A25C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002059")]
			[Address(RVA = "0x288A264", Offset = "0x288A264", VA = "0x288A264")]
			set
			{
			}
		}

		// Token: 0x17000471 RID: 1137
		// (get) Token: 0x0600205A RID: 8282 RVA: 0x0000C528 File Offset: 0x0000A728
		// (set) Token: 0x0600205B RID: 8283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000471")]
		[DebuggerNonUserCode]
		public long Uuid
		{
			[Token(Token = "0x600205A")]
			[Address(RVA = "0x288A2E0", Offset = "0x288A2E0", VA = "0x288A2E0")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x600205B")]
			[Address(RVA = "0x288A2E8", Offset = "0x288A2E8", VA = "0x288A2E8")]
			set
			{
			}
		}

		// Token: 0x17000472 RID: 1138
		// (get) Token: 0x0600205C RID: 8284 RVA: 0x0000C540 File Offset: 0x0000A740
		// (set) Token: 0x0600205D RID: 8285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000472")]
		[DebuggerNonUserCode]
		public int BuildId
		{
			[Token(Token = "0x600205C")]
			[Address(RVA = "0x288A2F0", Offset = "0x288A2F0", VA = "0x288A2F0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600205D")]
			[Address(RVA = "0x288A2F8", Offset = "0x288A2F8", VA = "0x288A2F8")]
			set
			{
			}
		}

		// Token: 0x17000473 RID: 1139
		// (get) Token: 0x0600205E RID: 8286 RVA: 0x0000C558 File Offset: 0x0000A758
		// (set) Token: 0x0600205F RID: 8287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000473")]
		[DebuggerNonUserCode]
		public int Level
		{
			[Token(Token = "0x600205E")]
			[Address(RVA = "0x288A300", Offset = "0x288A300", VA = "0x288A300")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600205F")]
			[Address(RVA = "0x288A308", Offset = "0x288A308", VA = "0x288A308")]
			set
			{
			}
		}

		// Token: 0x17000474 RID: 1140
		// (get) Token: 0x06002060 RID: 8288 RVA: 0x0000C570 File Offset: 0x0000A770
		// (set) Token: 0x06002061 RID: 8289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000474")]
		[DebuggerNonUserCode]
		public int BuildState
		{
			[Token(Token = "0x6002060")]
			[Address(RVA = "0x288A310", Offset = "0x288A310", VA = "0x288A310")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002061")]
			[Address(RVA = "0x288A318", Offset = "0x288A318", VA = "0x288A318")]
			set
			{
			}
		}

		// Token: 0x17000475 RID: 1141
		// (get) Token: 0x06002062 RID: 8290 RVA: 0x0000C588 File Offset: 0x0000A788
		// (set) Token: 0x06002063 RID: 8291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000475")]
		[DebuggerNonUserCode]
		public int QueueState
		{
			[Token(Token = "0x6002062")]
			[Address(RVA = "0x288A320", Offset = "0x288A320", VA = "0x288A320")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002063")]
			[Address(RVA = "0x288A328", Offset = "0x288A328", VA = "0x288A328")]
			set
			{
			}
		}

		// Token: 0x17000476 RID: 1142
		// (get) Token: 0x06002064 RID: 8292 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002065 RID: 8293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000476")]
		[DebuggerNonUserCode]
		public string AllianceId
		{
			[Token(Token = "0x6002064")]
			[Address(RVA = "0x288A330", Offset = "0x288A330", VA = "0x288A330")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002065")]
			[Address(RVA = "0x288A338", Offset = "0x288A338", VA = "0x288A338")]
			set
			{
			}
		}

		// Token: 0x17000477 RID: 1143
		// (get) Token: 0x06002066 RID: 8294 RVA: 0x0000C5A0 File Offset: 0x0000A7A0
		// (set) Token: 0x06002067 RID: 8295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000477")]
		[DebuggerNonUserCode]
		public int UpdateEndTime
		{
			[Token(Token = "0x6002066")]
			[Address(RVA = "0x288A3B4", Offset = "0x288A3B4", VA = "0x288A3B4")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002067")]
			[Address(RVA = "0x288A3BC", Offset = "0x288A3BC", VA = "0x288A3BC")]
			set
			{
			}
		}

		// Token: 0x17000478 RID: 1144
		// (get) Token: 0x06002068 RID: 8296 RVA: 0x0000C5B8 File Offset: 0x0000A7B8
		// (set) Token: 0x06002069 RID: 8297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000478")]
		[DebuggerNonUserCode]
		public int UpdateStartTime
		{
			[Token(Token = "0x6002068")]
			[Address(RVA = "0x288A3C4", Offset = "0x288A3C4", VA = "0x288A3C4")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002069")]
			[Address(RVA = "0x288A3CC", Offset = "0x288A3CC", VA = "0x288A3CC")]
			set
			{
			}
		}

		// Token: 0x17000479 RID: 1145
		// (get) Token: 0x0600206A RID: 8298 RVA: 0x0000C5D0 File Offset: 0x0000A7D0
		// (set) Token: 0x0600206B RID: 8299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000479")]
		[DebuggerNonUserCode]
		public int LastHpTime
		{
			[Token(Token = "0x600206A")]
			[Address(RVA = "0x288A3D4", Offset = "0x288A3D4", VA = "0x288A3D4")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600206B")]
			[Address(RVA = "0x288A3DC", Offset = "0x288A3DC", VA = "0x288A3DC")]
			set
			{
			}
		}

		// Token: 0x1700047A RID: 1146
		// (get) Token: 0x0600206C RID: 8300 RVA: 0x0000C5E8 File Offset: 0x0000A7E8
		// (set) Token: 0x0600206D RID: 8301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700047A")]
		[DebuggerNonUserCode]
		public int ProtectEndTime
		{
			[Token(Token = "0x600206C")]
			[Address(RVA = "0x288A3E4", Offset = "0x288A3E4", VA = "0x288A3E4")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600206D")]
			[Address(RVA = "0x288A3EC", Offset = "0x288A3EC", VA = "0x288A3EC")]
			set
			{
			}
		}

		// Token: 0x1700047B RID: 1147
		// (get) Token: 0x0600206E RID: 8302 RVA: 0x0000C600 File Offset: 0x0000A800
		// (set) Token: 0x0600206F RID: 8303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700047B")]
		[DebuggerNonUserCode]
		public int Inside
		{
			[Token(Token = "0x600206E")]
			[Address(RVA = "0x288A3F4", Offset = "0x288A3F4", VA = "0x288A3F4")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600206F")]
			[Address(RVA = "0x288A3FC", Offset = "0x288A3FC", VA = "0x288A3FC")]
			set
			{
			}
		}

		// Token: 0x1700047C RID: 1148
		// (get) Token: 0x06002070 RID: 8304 RVA: 0x0000C618 File Offset: 0x0000A818
		// (set) Token: 0x06002071 RID: 8305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700047C")]
		[DebuggerNonUserCode]
		public int CurrentHp
		{
			[Token(Token = "0x6002070")]
			[Address(RVA = "0x288A404", Offset = "0x288A404", VA = "0x288A404")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002071")]
			[Address(RVA = "0x288A40C", Offset = "0x288A40C", VA = "0x288A40C")]
			set
			{
			}
		}

		// Token: 0x1700047D RID: 1149
		// (get) Token: 0x06002072 RID: 8306 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002073 RID: 8307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700047D")]
		[DebuggerNonUserCode]
		public string Name
		{
			[Token(Token = "0x6002072")]
			[Address(RVA = "0x288A414", Offset = "0x288A414", VA = "0x288A414")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002073")]
			[Address(RVA = "0x288A41C", Offset = "0x288A41C", VA = "0x288A41C")]
			set
			{
			}
		}

		// Token: 0x1700047E RID: 1150
		// (get) Token: 0x06002074 RID: 8308 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002075 RID: 8309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700047E")]
		[DebuggerNonUserCode]
		public string AlAbbr
		{
			[Token(Token = "0x6002074")]
			[Address(RVA = "0x288A498", Offset = "0x288A498", VA = "0x288A498")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002075")]
			[Address(RVA = "0x288A4A0", Offset = "0x288A4A0", VA = "0x288A4A0")]
			set
			{
			}
		}

		// Token: 0x1700047F RID: 1151
		// (get) Token: 0x06002076 RID: 8310 RVA: 0x0000C630 File Offset: 0x0000A830
		// (set) Token: 0x06002077 RID: 8311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700047F")]
		[DebuggerNonUserCode]
		public int LastCollectTime
		{
			[Token(Token = "0x6002076")]
			[Address(RVA = "0x288A51C", Offset = "0x288A51C", VA = "0x288A51C")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002077")]
			[Address(RVA = "0x288A524", Offset = "0x288A524", VA = "0x288A524")]
			set
			{
			}
		}

		// Token: 0x17000480 RID: 1152
		// (get) Token: 0x06002078 RID: 8312 RVA: 0x0000C648 File Offset: 0x0000A848
		// (set) Token: 0x06002079 RID: 8313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000480")]
		[DebuggerNonUserCode]
		public int UnavailableTime
		{
			[Token(Token = "0x6002078")]
			[Address(RVA = "0x288A52C", Offset = "0x288A52C", VA = "0x288A52C")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002079")]
			[Address(RVA = "0x288A534", Offset = "0x288A534", VA = "0x288A534")]
			set
			{
			}
		}

		// Token: 0x17000481 RID: 1153
		// (get) Token: 0x0600207A RID: 8314 RVA: 0x0000C660 File Offset: 0x0000A860
		// (set) Token: 0x0600207B RID: 8315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000481")]
		[DebuggerNonUserCode]
		public int MonthCardEndTime
		{
			[Token(Token = "0x600207A")]
			[Address(RVA = "0x288A53C", Offset = "0x288A53C", VA = "0x288A53C")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600207B")]
			[Address(RVA = "0x288A544", Offset = "0x288A544", VA = "0x288A544")]
			set
			{
			}
		}

		// Token: 0x17000482 RID: 1154
		// (get) Token: 0x0600207C RID: 8316 RVA: 0x0000C678 File Offset: 0x0000A878
		// (set) Token: 0x0600207D RID: 8317 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000482")]
		[DebuggerNonUserCode]
		public int QueueItemId
		{
			[Token(Token = "0x600207C")]
			[Address(RVA = "0x288A54C", Offset = "0x288A54C", VA = "0x288A54C")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600207D")]
			[Address(RVA = "0x288A554", Offset = "0x288A554", VA = "0x288A554")]
			set
			{
			}
		}

		// Token: 0x17000483 RID: 1155
		// (get) Token: 0x0600207E RID: 8318 RVA: 0x0000C690 File Offset: 0x0000A890
		// (set) Token: 0x0600207F RID: 8319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000483")]
		[DebuggerNonUserCode]
		public int QueueStartTime
		{
			[Token(Token = "0x600207E")]
			[Address(RVA = "0x288A55C", Offset = "0x288A55C", VA = "0x288A55C")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600207F")]
			[Address(RVA = "0x288A564", Offset = "0x288A564", VA = "0x288A564")]
			set
			{
			}
		}

		// Token: 0x17000484 RID: 1156
		// (get) Token: 0x06002080 RID: 8320 RVA: 0x0000C6A8 File Offset: 0x0000A8A8
		// (set) Token: 0x06002081 RID: 8321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000484")]
		[DebuggerNonUserCode]
		public int QueueUpdateTime
		{
			[Token(Token = "0x6002080")]
			[Address(RVA = "0x288A56C", Offset = "0x288A56C", VA = "0x288A56C")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002081")]
			[Address(RVA = "0x288A574", Offset = "0x288A574", VA = "0x288A574")]
			set
			{
			}
		}

		// Token: 0x17000485 RID: 1157
		// (get) Token: 0x06002082 RID: 8322 RVA: 0x0000C6C0 File Offset: 0x0000A8C0
		// (set) Token: 0x06002083 RID: 8323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000485")]
		[DebuggerNonUserCode]
		public int DestroyStartTime
		{
			[Token(Token = "0x6002082")]
			[Address(RVA = "0x288A57C", Offset = "0x288A57C", VA = "0x288A57C")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002083")]
			[Address(RVA = "0x288A584", Offset = "0x288A584", VA = "0x288A584")]
			set
			{
			}
		}

		// Token: 0x17000486 RID: 1158
		// (get) Token: 0x06002084 RID: 8324 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000486")]
		[DebuggerNonUserCode]
		public RepeatedField<Skin> Skins
		{
			[Token(Token = "0x6002084")]
			[Address(RVA = "0x288A58C", Offset = "0x288A58C", VA = "0x288A58C")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000487 RID: 1159
		// (get) Token: 0x06002085 RID: 8325 RVA: 0x0000C6D8 File Offset: 0x0000A8D8
		// (set) Token: 0x06002086 RID: 8326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000487")]
		[DebuggerNonUserCode]
		public int FireEndTime
		{
			[Token(Token = "0x6002085")]
			[Address(RVA = "0x288A594", Offset = "0x288A594", VA = "0x288A594")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002086")]
			[Address(RVA = "0x288A59C", Offset = "0x288A59C", VA = "0x288A59C")]
			set
			{
			}
		}

		// Token: 0x17000488 RID: 1160
		// (get) Token: 0x06002087 RID: 8327 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002088 RID: 8328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000488")]
		[DebuggerNonUserCode]
		public string PositionId
		{
			[Token(Token = "0x6002087")]
			[Address(RVA = "0x288A5A4", Offset = "0x288A5A4", VA = "0x288A5A4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002088")]
			[Address(RVA = "0x288A5AC", Offset = "0x288A5AC", VA = "0x288A5AC")]
			set
			{
			}
		}

		// Token: 0x17000489 RID: 1161
		// (get) Token: 0x06002089 RID: 8329 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000489")]
		[DebuggerNonUserCode]
		public RepeatedField<BuildingBreak> Breaks
		{
			[Token(Token = "0x6002089")]
			[Address(RVA = "0x288A628", Offset = "0x288A628", VA = "0x288A628")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600208A RID: 8330 RVA: 0x0000C6F0 File Offset: 0x0000A8F0
		[Token(Token = "0x600208A")]
		[Address(RVA = "0x288A630", Offset = "0x288A630", VA = "0x288A630", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x0600208B RID: 8331 RVA: 0x0000C708 File Offset: 0x0000A908
		[Token(Token = "0x600208B")]
		[Address(RVA = "0x288A694", Offset = "0x288A694", VA = "0x288A694", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(BuildInfo other)
		{
			return default(bool);
		}

		// Token: 0x0600208C RID: 8332 RVA: 0x0000C720 File Offset: 0x0000A920
		[Token(Token = "0x600208C")]
		[Address(RVA = "0x288A8E4", Offset = "0x288A8E4", VA = "0x288A8E4", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600208D RID: 8333 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600208D")]
		[Address(RVA = "0x288AC18", Offset = "0x288AC18", VA = "0x288AC18", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600208E RID: 8334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600208E")]
		[Address(RVA = "0x288AC70", Offset = "0x288AC70", VA = "0x288AC70", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600208F RID: 8335 RVA: 0x0000C738 File Offset: 0x0000A938
		[Token(Token = "0x600208F")]
		[Address(RVA = "0x288B1DC", Offset = "0x288B1DC", VA = "0x288B1DC", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06002090 RID: 8336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002090")]
		[Address(RVA = "0x288B734", Offset = "0x288B734", VA = "0x288B734", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(BuildInfo other)
		{
		}

		// Token: 0x06002091 RID: 8337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002091")]
		[Address(RVA = "0x288B940", Offset = "0x288B940", VA = "0x288B940", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x04001EF6 RID: 7926
		[Token(Token = "0x4001EF6")]
		[FieldOffset(Offset = "0x0")]
		private static readonly MessageParser<BuildInfo> _parser;

		// Token: 0x04001EF7 RID: 7927
		[Token(Token = "0x4001EF7")]
		[FieldOffset(Offset = "0x10")]
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001EF8 RID: 7928
		[Token(Token = "0x4001EF8")]
		public const int OwnerUidFieldNumber = 1;

		// Token: 0x04001EF9 RID: 7929
		[Token(Token = "0x4001EF9")]
		[FieldOffset(Offset = "0x18")]
		private string ownerUid_;

		// Token: 0x04001EFA RID: 7930
		[Token(Token = "0x4001EFA")]
		public const int UuidFieldNumber = 2;

		// Token: 0x04001EFB RID: 7931
		[Token(Token = "0x4001EFB")]
		[FieldOffset(Offset = "0x20")]
		private long uuid_;

		// Token: 0x04001EFC RID: 7932
		[Token(Token = "0x4001EFC")]
		public const int BuildIdFieldNumber = 3;

		// Token: 0x04001EFD RID: 7933
		[Token(Token = "0x4001EFD")]
		[FieldOffset(Offset = "0x28")]
		private int buildId_;

		// Token: 0x04001EFE RID: 7934
		[Token(Token = "0x4001EFE")]
		public const int LevelFieldNumber = 4;

		// Token: 0x04001EFF RID: 7935
		[Token(Token = "0x4001EFF")]
		[FieldOffset(Offset = "0x2C")]
		private int level_;

		// Token: 0x04001F00 RID: 7936
		[Token(Token = "0x4001F00")]
		public const int BuildStateFieldNumber = 5;

		// Token: 0x04001F01 RID: 7937
		[Token(Token = "0x4001F01")]
		[FieldOffset(Offset = "0x30")]
		private int buildState_;

		// Token: 0x04001F02 RID: 7938
		[Token(Token = "0x4001F02")]
		public const int QueueStateFieldNumber = 6;

		// Token: 0x04001F03 RID: 7939
		[Token(Token = "0x4001F03")]
		[FieldOffset(Offset = "0x34")]
		private int queueState_;

		// Token: 0x04001F04 RID: 7940
		[Token(Token = "0x4001F04")]
		public const int AllianceIdFieldNumber = 7;

		// Token: 0x04001F05 RID: 7941
		[Token(Token = "0x4001F05")]
		[FieldOffset(Offset = "0x38")]
		private string allianceId_;

		// Token: 0x04001F06 RID: 7942
		[Token(Token = "0x4001F06")]
		public const int UpdateEndTimeFieldNumber = 8;

		// Token: 0x04001F07 RID: 7943
		[Token(Token = "0x4001F07")]
		[FieldOffset(Offset = "0x40")]
		private int updateEndTime_;

		// Token: 0x04001F08 RID: 7944
		[Token(Token = "0x4001F08")]
		public const int UpdateStartTimeFieldNumber = 9;

		// Token: 0x04001F09 RID: 7945
		[Token(Token = "0x4001F09")]
		[FieldOffset(Offset = "0x44")]
		private int updateStartTime_;

		// Token: 0x04001F0A RID: 7946
		[Token(Token = "0x4001F0A")]
		public const int LastHpTimeFieldNumber = 10;

		// Token: 0x04001F0B RID: 7947
		[Token(Token = "0x4001F0B")]
		[FieldOffset(Offset = "0x48")]
		private int lastHpTime_;

		// Token: 0x04001F0C RID: 7948
		[Token(Token = "0x4001F0C")]
		public const int ProtectEndTimeFieldNumber = 11;

		// Token: 0x04001F0D RID: 7949
		[Token(Token = "0x4001F0D")]
		[FieldOffset(Offset = "0x4C")]
		private int protectEndTime_;

		// Token: 0x04001F0E RID: 7950
		[Token(Token = "0x4001F0E")]
		public const int InsideFieldNumber = 12;

		// Token: 0x04001F0F RID: 7951
		[Token(Token = "0x4001F0F")]
		[FieldOffset(Offset = "0x50")]
		private int inside_;

		// Token: 0x04001F10 RID: 7952
		[Token(Token = "0x4001F10")]
		public const int CurrentHpFieldNumber = 13;

		// Token: 0x04001F11 RID: 7953
		[Token(Token = "0x4001F11")]
		[FieldOffset(Offset = "0x54")]
		private int currentHp_;

		// Token: 0x04001F12 RID: 7954
		[Token(Token = "0x4001F12")]
		public const int NameFieldNumber = 14;

		// Token: 0x04001F13 RID: 7955
		[Token(Token = "0x4001F13")]
		[FieldOffset(Offset = "0x58")]
		private string name_;

		// Token: 0x04001F14 RID: 7956
		[Token(Token = "0x4001F14")]
		public const int AlAbbrFieldNumber = 15;

		// Token: 0x04001F15 RID: 7957
		[Token(Token = "0x4001F15")]
		[FieldOffset(Offset = "0x60")]
		private string alAbbr_;

		// Token: 0x04001F16 RID: 7958
		[Token(Token = "0x4001F16")]
		public const int LastCollectTimeFieldNumber = 16;

		// Token: 0x04001F17 RID: 7959
		[Token(Token = "0x4001F17")]
		[FieldOffset(Offset = "0x68")]
		private int lastCollectTime_;

		// Token: 0x04001F18 RID: 7960
		[Token(Token = "0x4001F18")]
		public const int UnavailableTimeFieldNumber = 17;

		// Token: 0x04001F19 RID: 7961
		[Token(Token = "0x4001F19")]
		[FieldOffset(Offset = "0x6C")]
		private int unavailableTime_;

		// Token: 0x04001F1A RID: 7962
		[Token(Token = "0x4001F1A")]
		public const int MonthCardEndTimeFieldNumber = 18;

		// Token: 0x04001F1B RID: 7963
		[Token(Token = "0x4001F1B")]
		[FieldOffset(Offset = "0x70")]
		private int monthCardEndTime_;

		// Token: 0x04001F1C RID: 7964
		[Token(Token = "0x4001F1C")]
		public const int QueueItemIdFieldNumber = 19;

		// Token: 0x04001F1D RID: 7965
		[Token(Token = "0x4001F1D")]
		[FieldOffset(Offset = "0x74")]
		private int queueItemId_;

		// Token: 0x04001F1E RID: 7966
		[Token(Token = "0x4001F1E")]
		public const int QueueStartTimeFieldNumber = 20;

		// Token: 0x04001F1F RID: 7967
		[Token(Token = "0x4001F1F")]
		[FieldOffset(Offset = "0x78")]
		private int queueStartTime_;

		// Token: 0x04001F20 RID: 7968
		[Token(Token = "0x4001F20")]
		public const int QueueUpdateTimeFieldNumber = 21;

		// Token: 0x04001F21 RID: 7969
		[Token(Token = "0x4001F21")]
		[FieldOffset(Offset = "0x7C")]
		private int queueUpdateTime_;

		// Token: 0x04001F22 RID: 7970
		[Token(Token = "0x4001F22")]
		public const int DestroyStartTimeFieldNumber = 22;

		// Token: 0x04001F23 RID: 7971
		[Token(Token = "0x4001F23")]
		[FieldOffset(Offset = "0x80")]
		private int destroyStartTime_;

		// Token: 0x04001F24 RID: 7972
		[Token(Token = "0x4001F24")]
		public const int SkinsFieldNumber = 23;

		// Token: 0x04001F25 RID: 7973
		[Token(Token = "0x4001F25")]
		[FieldOffset(Offset = "0x8")]
		private static readonly FieldCodec<Skin> _repeated_skins_codec;

		// Token: 0x04001F26 RID: 7974
		[Token(Token = "0x4001F26")]
		[FieldOffset(Offset = "0x88")]
		private readonly RepeatedField<Skin> skins_;

		// Token: 0x04001F27 RID: 7975
		[Token(Token = "0x4001F27")]
		public const int FireEndTimeFieldNumber = 24;

		// Token: 0x04001F28 RID: 7976
		[Token(Token = "0x4001F28")]
		[FieldOffset(Offset = "0x90")]
		private int fireEndTime_;

		// Token: 0x04001F29 RID: 7977
		[Token(Token = "0x4001F29")]
		public const int PositionIdFieldNumber = 25;

		// Token: 0x04001F2A RID: 7978
		[Token(Token = "0x4001F2A")]
		[FieldOffset(Offset = "0x98")]
		private string positionId_;

		// Token: 0x04001F2B RID: 7979
		[Token(Token = "0x4001F2B")]
		public const int BreaksFieldNumber = 26;

		// Token: 0x04001F2C RID: 7980
		[Token(Token = "0x4001F2C")]
		[FieldOffset(Offset = "0x10")]
		private static readonly FieldCodec<BuildingBreak> _repeated_breaks_codec;

		// Token: 0x04001F2D RID: 7981
		[Token(Token = "0x4001F2D")]
		[FieldOffset(Offset = "0xA0")]
		private readonly RepeatedField<BuildingBreak> breaks_;
	}
}
