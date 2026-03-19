using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Protobuf
{
	// Token: 0x0200048F RID: 1167
	[Token(Token = "0x200048F")]
	public sealed class WorldPointInfo : IMessage<WorldPointInfo>, IMessage, IEquatable<WorldPointInfo>, IDeepCloneable<WorldPointInfo>
	{
		// Token: 0x170004F0 RID: 1264
		// (get) Token: 0x060021FE RID: 8702 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004F0")]
		[DebuggerNonUserCode]
		public static MessageParser<WorldPointInfo> Parser
		{
			[Token(Token = "0x60021FE")]
			[Address(RVA = "0x2895850", Offset = "0x2895850", VA = "0x2895850")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004F1 RID: 1265
		// (get) Token: 0x060021FF RID: 8703 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004F1")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Token(Token = "0x60021FF")]
			[Address(RVA = "0x28958A8", Offset = "0x28958A8", VA = "0x28958A8")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004F2 RID: 1266
		// (get) Token: 0x06002200 RID: 8704 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004F2")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Token(Token = "0x6002200")]
			[Address(RVA = "0x28959AC", Offset = "0x28959AC", VA = "0x28959AC", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002201 RID: 8705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002201")]
		[Address(RVA = "0x28959F8", Offset = "0x28959F8", VA = "0x28959F8")]
		[DebuggerNonUserCode]
		public WorldPointInfo()
		{
		}

		// Token: 0x06002202 RID: 8706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002202")]
		[Address(RVA = "0x2895A98", Offset = "0x2895A98", VA = "0x2895A98")]
		[DebuggerNonUserCode]
		public WorldPointInfo(WorldPointInfo other)
		{
		}

		// Token: 0x06002203 RID: 8707 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002203")]
		[Address(RVA = "0x2895C04", Offset = "0x2895C04", VA = "0x2895C04", Slot = "10")]
		[DebuggerNonUserCode]
		public WorldPointInfo Clone()
		{
			return null;
		}

		// Token: 0x170004F3 RID: 1267
		// (get) Token: 0x06002204 RID: 8708 RVA: 0x0000D080 File Offset: 0x0000B280
		// (set) Token: 0x06002205 RID: 8709 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004F3")]
		[DebuggerNonUserCode]
		public int Id
		{
			[Token(Token = "0x6002204")]
			[Address(RVA = "0x2895C64", Offset = "0x2895C64", VA = "0x2895C64")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002205")]
			[Address(RVA = "0x2895C6C", Offset = "0x2895C6C", VA = "0x2895C6C")]
			set
			{
			}
		}

		// Token: 0x170004F4 RID: 1268
		// (get) Token: 0x06002206 RID: 8710 RVA: 0x0000D098 File Offset: 0x0000B298
		// (set) Token: 0x06002207 RID: 8711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004F4")]
		[DebuggerNonUserCode]
		public int PointType
		{
			[Token(Token = "0x6002206")]
			[Address(RVA = "0x2895C74", Offset = "0x2895C74", VA = "0x2895C74")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002207")]
			[Address(RVA = "0x2895C7C", Offset = "0x2895C7C", VA = "0x2895C7C")]
			set
			{
			}
		}

		// Token: 0x170004F5 RID: 1269
		// (get) Token: 0x06002208 RID: 8712 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002209 RID: 8713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004F5")]
		[DebuggerNonUserCode]
		public BuildInfo BuildInfo
		{
			[Token(Token = "0x6002208")]
			[Address(RVA = "0x2895C84", Offset = "0x2895C84", VA = "0x2895C84")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002209")]
			[Address(RVA = "0x2895C8C", Offset = "0x2895C8C", VA = "0x2895C8C")]
			set
			{
			}
		}

		// Token: 0x170004F6 RID: 1270
		// (get) Token: 0x0600220A RID: 8714 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600220B RID: 8715 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004F6")]
		[DebuggerNonUserCode]
		public RoadInfo RoadInfo
		{
			[Token(Token = "0x600220A")]
			[Address(RVA = "0x2895C94", Offset = "0x2895C94", VA = "0x2895C94")]
			get
			{
				return null;
			}
			[Token(Token = "0x600220B")]
			[Address(RVA = "0x2895C9C", Offset = "0x2895C9C", VA = "0x2895C9C")]
			set
			{
			}
		}

		// Token: 0x170004F7 RID: 1271
		// (get) Token: 0x0600220C RID: 8716 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600220D RID: 8717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004F7")]
		[DebuggerNonUserCode]
		public CollectResourceInfo CollectResourceInfo
		{
			[Token(Token = "0x600220C")]
			[Address(RVA = "0x2895CA4", Offset = "0x2895CA4", VA = "0x2895CA4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600220D")]
			[Address(RVA = "0x2895CAC", Offset = "0x2895CAC", VA = "0x2895CAC")]
			set
			{
			}
		}

		// Token: 0x170004F8 RID: 1272
		// (get) Token: 0x0600220E RID: 8718 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600220F RID: 8719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004F8")]
		[DebuggerNonUserCode]
		public ResourceInfo ResourceInfo
		{
			[Token(Token = "0x600220E")]
			[Address(RVA = "0x2895CB4", Offset = "0x2895CB4", VA = "0x2895CB4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600220F")]
			[Address(RVA = "0x2895CBC", Offset = "0x2895CBC", VA = "0x2895CBC")]
			set
			{
			}
		}

		// Token: 0x170004F9 RID: 1273
		// (get) Token: 0x06002210 RID: 8720 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002211 RID: 8721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004F9")]
		[DebuggerNonUserCode]
		public ExplorePointInfo ExplorePointInfo
		{
			[Token(Token = "0x6002210")]
			[Address(RVA = "0x2895CC4", Offset = "0x2895CC4", VA = "0x2895CC4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002211")]
			[Address(RVA = "0x2895CCC", Offset = "0x2895CCC", VA = "0x2895CCC")]
			set
			{
			}
		}

		// Token: 0x170004FA RID: 1274
		// (get) Token: 0x06002212 RID: 8722 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002213 RID: 8723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004FA")]
		[DebuggerNonUserCode]
		public SamplePointInfo SamplePointInfo
		{
			[Token(Token = "0x6002212")]
			[Address(RVA = "0x2895CD4", Offset = "0x2895CD4", VA = "0x2895CD4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002213")]
			[Address(RVA = "0x2895CDC", Offset = "0x2895CDC", VA = "0x2895CDC")]
			set
			{
			}
		}

		// Token: 0x170004FB RID: 1275
		// (get) Token: 0x06002214 RID: 8724 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002215 RID: 8725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004FB")]
		[DebuggerNonUserCode]
		public GarbagePointInfo GarbagePointInfo
		{
			[Token(Token = "0x6002214")]
			[Address(RVA = "0x2895CE4", Offset = "0x2895CE4", VA = "0x2895CE4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002215")]
			[Address(RVA = "0x2895CEC", Offset = "0x2895CEC", VA = "0x2895CEC")]
			set
			{
			}
		}

		// Token: 0x170004FC RID: 1276
		// (get) Token: 0x06002216 RID: 8726 RVA: 0x0000D0B0 File Offset: 0x0000B2B0
		// (set) Token: 0x06002217 RID: 8727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004FC")]
		[DebuggerNonUserCode]
		public long Uuid
		{
			[Token(Token = "0x6002216")]
			[Address(RVA = "0x2895CF4", Offset = "0x2895CF4", VA = "0x2895CF4")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x6002217")]
			[Address(RVA = "0x2895CFC", Offset = "0x2895CFC", VA = "0x2895CFC")]
			set
			{
			}
		}

		// Token: 0x170004FD RID: 1277
		// (get) Token: 0x06002218 RID: 8728 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002219 RID: 8729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004FD")]
		[DebuggerNonUserCode]
		public ByteString ExtraInfo
		{
			[Token(Token = "0x6002218")]
			[Address(RVA = "0x2895D04", Offset = "0x2895D04", VA = "0x2895D04")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002219")]
			[Address(RVA = "0x2895D0C", Offset = "0x2895D0C", VA = "0x2895D0C")]
			set
			{
			}
		}

		// Token: 0x170004FE RID: 1278
		// (get) Token: 0x0600221A RID: 8730 RVA: 0x0000D0C8 File Offset: 0x0000B2C8
		// (set) Token: 0x0600221B RID: 8731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004FE")]
		[DebuggerNonUserCode]
		public int ServerId
		{
			[Token(Token = "0x600221A")]
			[Address(RVA = "0x2895D88", Offset = "0x2895D88", VA = "0x2895D88")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600221B")]
			[Address(RVA = "0x2895D90", Offset = "0x2895D90", VA = "0x2895D90")]
			set
			{
			}
		}

		// Token: 0x170004FF RID: 1279
		// (get) Token: 0x0600221C RID: 8732 RVA: 0x0000D0E0 File Offset: 0x0000B2E0
		// (set) Token: 0x0600221D RID: 8733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004FF")]
		[DebuggerNonUserCode]
		public int SrcServerId
		{
			[Token(Token = "0x600221C")]
			[Address(RVA = "0x2895D98", Offset = "0x2895D98", VA = "0x2895D98")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600221D")]
			[Address(RVA = "0x2895DA0", Offset = "0x2895DA0", VA = "0x2895DA0")]
			set
			{
			}
		}

		// Token: 0x17000500 RID: 1280
		// (get) Token: 0x0600221E RID: 8734 RVA: 0x0000D0F8 File Offset: 0x0000B2F8
		// (set) Token: 0x0600221F RID: 8735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000500")]
		[DebuggerNonUserCode]
		public int WorldId
		{
			[Token(Token = "0x600221E")]
			[Address(RVA = "0x2895DA8", Offset = "0x2895DA8", VA = "0x2895DA8")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600221F")]
			[Address(RVA = "0x2895DB0", Offset = "0x2895DB0", VA = "0x2895DB0")]
			set
			{
			}
		}

		// Token: 0x06002220 RID: 8736 RVA: 0x0000D110 File Offset: 0x0000B310
		[Token(Token = "0x6002220")]
		[Address(RVA = "0x2895DB8", Offset = "0x2895DB8", VA = "0x2895DB8", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06002221 RID: 8737 RVA: 0x0000D128 File Offset: 0x0000B328
		[Token(Token = "0x6002221")]
		[Address(RVA = "0x2895E1C", Offset = "0x2895E1C", VA = "0x2895E1C", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(WorldPointInfo other)
		{
			return default(bool);
		}

		// Token: 0x06002222 RID: 8738 RVA: 0x0000D140 File Offset: 0x0000B340
		[Token(Token = "0x6002222")]
		[Address(RVA = "0x2895FC0", Offset = "0x2895FC0", VA = "0x2895FC0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06002223 RID: 8739 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002223")]
		[Address(RVA = "0x2896188", Offset = "0x2896188", VA = "0x2896188", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06002224 RID: 8740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002224")]
		[Address(RVA = "0x28961E0", Offset = "0x28961E0", VA = "0x28961E0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06002225 RID: 8741 RVA: 0x0000D158 File Offset: 0x0000B358
		[Token(Token = "0x6002225")]
		[Address(RVA = "0x28964A4", Offset = "0x28964A4", VA = "0x28964A4", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06002226 RID: 8742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002226")]
		[Address(RVA = "0x289677C", Offset = "0x289677C", VA = "0x289677C", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(WorldPointInfo other)
		{
		}

		// Token: 0x06002227 RID: 8743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002227")]
		[Address(RVA = "0x2896ADC", Offset = "0x2896ADC", VA = "0x2896ADC", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x04001FD4 RID: 8148
		[Token(Token = "0x4001FD4")]
		[FieldOffset(Offset = "0x0")]
		private static readonly MessageParser<WorldPointInfo> _parser;

		// Token: 0x04001FD5 RID: 8149
		[Token(Token = "0x4001FD5")]
		[FieldOffset(Offset = "0x10")]
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001FD6 RID: 8150
		[Token(Token = "0x4001FD6")]
		public const int IdFieldNumber = 1;

		// Token: 0x04001FD7 RID: 8151
		[Token(Token = "0x4001FD7")]
		[FieldOffset(Offset = "0x18")]
		private int id_;

		// Token: 0x04001FD8 RID: 8152
		[Token(Token = "0x4001FD8")]
		public const int PointTypeFieldNumber = 2;

		// Token: 0x04001FD9 RID: 8153
		[Token(Token = "0x4001FD9")]
		[FieldOffset(Offset = "0x1C")]
		private int pointType_;

		// Token: 0x04001FDA RID: 8154
		[Token(Token = "0x4001FDA")]
		public const int BuildInfoFieldNumber = 3;

		// Token: 0x04001FDB RID: 8155
		[Token(Token = "0x4001FDB")]
		[FieldOffset(Offset = "0x20")]
		private BuildInfo buildInfo_;

		// Token: 0x04001FDC RID: 8156
		[Token(Token = "0x4001FDC")]
		public const int RoadInfoFieldNumber = 4;

		// Token: 0x04001FDD RID: 8157
		[Token(Token = "0x4001FDD")]
		[FieldOffset(Offset = "0x28")]
		private RoadInfo roadInfo_;

		// Token: 0x04001FDE RID: 8158
		[Token(Token = "0x4001FDE")]
		public const int CollectResourceInfoFieldNumber = 5;

		// Token: 0x04001FDF RID: 8159
		[Token(Token = "0x4001FDF")]
		[FieldOffset(Offset = "0x30")]
		private CollectResourceInfo collectResourceInfo_;

		// Token: 0x04001FE0 RID: 8160
		[Token(Token = "0x4001FE0")]
		public const int ResourceInfoFieldNumber = 6;

		// Token: 0x04001FE1 RID: 8161
		[Token(Token = "0x4001FE1")]
		[FieldOffset(Offset = "0x38")]
		private ResourceInfo resourceInfo_;

		// Token: 0x04001FE2 RID: 8162
		[Token(Token = "0x4001FE2")]
		public const int ExplorePointInfoFieldNumber = 7;

		// Token: 0x04001FE3 RID: 8163
		[Token(Token = "0x4001FE3")]
		[FieldOffset(Offset = "0x40")]
		private ExplorePointInfo explorePointInfo_;

		// Token: 0x04001FE4 RID: 8164
		[Token(Token = "0x4001FE4")]
		public const int SamplePointInfoFieldNumber = 8;

		// Token: 0x04001FE5 RID: 8165
		[Token(Token = "0x4001FE5")]
		[FieldOffset(Offset = "0x48")]
		private SamplePointInfo samplePointInfo_;

		// Token: 0x04001FE6 RID: 8166
		[Token(Token = "0x4001FE6")]
		public const int GarbagePointInfoFieldNumber = 9;

		// Token: 0x04001FE7 RID: 8167
		[Token(Token = "0x4001FE7")]
		[FieldOffset(Offset = "0x50")]
		private GarbagePointInfo garbagePointInfo_;

		// Token: 0x04001FE8 RID: 8168
		[Token(Token = "0x4001FE8")]
		public const int UuidFieldNumber = 100;

		// Token: 0x04001FE9 RID: 8169
		[Token(Token = "0x4001FE9")]
		[FieldOffset(Offset = "0x58")]
		private long uuid_;

		// Token: 0x04001FEA RID: 8170
		[Token(Token = "0x4001FEA")]
		public const int ExtraInfoFieldNumber = 101;

		// Token: 0x04001FEB RID: 8171
		[Token(Token = "0x4001FEB")]
		[FieldOffset(Offset = "0x60")]
		private ByteString extraInfo_;

		// Token: 0x04001FEC RID: 8172
		[Token(Token = "0x4001FEC")]
		public const int ServerIdFieldNumber = 102;

		// Token: 0x04001FED RID: 8173
		[Token(Token = "0x4001FED")]
		[FieldOffset(Offset = "0x68")]
		private int serverId_;

		// Token: 0x04001FEE RID: 8174
		[Token(Token = "0x4001FEE")]
		public const int SrcServerIdFieldNumber = 103;

		// Token: 0x04001FEF RID: 8175
		[Token(Token = "0x4001FEF")]
		[FieldOffset(Offset = "0x6C")]
		private int srcServerId_;

		// Token: 0x04001FF0 RID: 8176
		[Token(Token = "0x4001FF0")]
		public const int WorldIdFieldNumber = 104;

		// Token: 0x04001FF1 RID: 8177
		[Token(Token = "0x4001FF1")]
		[FieldOffset(Offset = "0x70")]
		private int worldId_;
	}
}
