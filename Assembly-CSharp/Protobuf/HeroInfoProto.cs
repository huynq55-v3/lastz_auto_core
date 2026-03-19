using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Protobuf
{
	// Token: 0x020003F1 RID: 1009
	[Token(Token = "0x20003F1")]
	public sealed class HeroInfoProto : IMessage<HeroInfoProto>, IMessage, IEquatable<HeroInfoProto>, IDeepCloneable<HeroInfoProto>
	{
		// Token: 0x17000292 RID: 658
		// (get) Token: 0x060019D8 RID: 6616 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000292")]
		[DebuggerNonUserCode]
		public static MessageParser<HeroInfoProto> Parser
		{
			[Token(Token = "0x60019D8")]
			[Address(RVA = "0x20E0988", Offset = "0x20E0988", VA = "0x20E0988")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000293 RID: 659
		// (get) Token: 0x060019D9 RID: 6617 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000293")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Token(Token = "0x60019D9")]
			[Address(RVA = "0x20E09E0", Offset = "0x20E09E0", VA = "0x20E09E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000294 RID: 660
		// (get) Token: 0x060019DA RID: 6618 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000294")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Token(Token = "0x60019DA")]
			[Address(RVA = "0x20E0AE4", Offset = "0x20E0AE4", VA = "0x20E0AE4", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x060019DB RID: 6619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019DB")]
		[Address(RVA = "0x20E0B30", Offset = "0x20E0B30", VA = "0x20E0B30")]
		[DebuggerNonUserCode]
		public HeroInfoProto()
		{
		}

		// Token: 0x060019DC RID: 6620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019DC")]
		[Address(RVA = "0x20E0BB8", Offset = "0x20E0BB8", VA = "0x20E0BB8")]
		[DebuggerNonUserCode]
		public HeroInfoProto(HeroInfoProto other)
		{
		}

		// Token: 0x060019DD RID: 6621 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019DD")]
		[Address(RVA = "0x20E0C64", Offset = "0x20E0C64", VA = "0x20E0C64", Slot = "10")]
		[DebuggerNonUserCode]
		public HeroInfoProto Clone()
		{
			return null;
		}

		// Token: 0x17000295 RID: 661
		// (get) Token: 0x060019DE RID: 6622 RVA: 0x00009E70 File Offset: 0x00008070
		// (set) Token: 0x060019DF RID: 6623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000295")]
		[DebuggerNonUserCode]
		public int HeroId
		{
			[Token(Token = "0x60019DE")]
			[Address(RVA = "0x20E0CC4", Offset = "0x20E0CC4", VA = "0x20E0CC4")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60019DF")]
			[Address(RVA = "0x20E0CCC", Offset = "0x20E0CCC", VA = "0x20E0CCC")]
			set
			{
			}
		}

		// Token: 0x17000296 RID: 662
		// (get) Token: 0x060019E0 RID: 6624 RVA: 0x00009E88 File Offset: 0x00008088
		// (set) Token: 0x060019E1 RID: 6625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000296")]
		[DebuggerNonUserCode]
		public int HeroLevel
		{
			[Token(Token = "0x60019E0")]
			[Address(RVA = "0x20E0CD4", Offset = "0x20E0CD4", VA = "0x20E0CD4")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60019E1")]
			[Address(RVA = "0x20E0CDC", Offset = "0x20E0CDC", VA = "0x20E0CDC")]
			set
			{
			}
		}

		// Token: 0x17000297 RID: 663
		// (get) Token: 0x060019E2 RID: 6626 RVA: 0x00009EA0 File Offset: 0x000080A0
		// (set) Token: 0x060019E3 RID: 6627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000297")]
		[DebuggerNonUserCode]
		public int HeroQuality
		{
			[Token(Token = "0x60019E2")]
			[Address(RVA = "0x20E0CE4", Offset = "0x20E0CE4", VA = "0x20E0CE4")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60019E3")]
			[Address(RVA = "0x20E0CEC", Offset = "0x20E0CEC", VA = "0x20E0CEC")]
			set
			{
			}
		}

		// Token: 0x17000298 RID: 664
		// (get) Token: 0x060019E4 RID: 6628 RVA: 0x00009EB8 File Offset: 0x000080B8
		// (set) Token: 0x060019E5 RID: 6629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000298")]
		[DebuggerNonUserCode]
		public int Index
		{
			[Token(Token = "0x60019E4")]
			[Address(RVA = "0x20E0CF4", Offset = "0x20E0CF4", VA = "0x20E0CF4")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60019E5")]
			[Address(RVA = "0x20E0CFC", Offset = "0x20E0CFC", VA = "0x20E0CFC")]
			set
			{
			}
		}

		// Token: 0x17000299 RID: 665
		// (get) Token: 0x060019E6 RID: 6630 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000299")]
		[DebuggerNonUserCode]
		public RepeatedField<HeroSkillInfoProto> SkillInfos
		{
			[Token(Token = "0x60019E6")]
			[Address(RVA = "0x20E0D04", Offset = "0x20E0D04", VA = "0x20E0D04")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700029A RID: 666
		// (get) Token: 0x060019E7 RID: 6631 RVA: 0x00009ED0 File Offset: 0x000080D0
		// (set) Token: 0x060019E8 RID: 6632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700029A")]
		[DebuggerNonUserCode]
		public long HeroUuid
		{
			[Token(Token = "0x60019E7")]
			[Address(RVA = "0x20E0D0C", Offset = "0x20E0D0C", VA = "0x20E0D0C")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x60019E8")]
			[Address(RVA = "0x20E0D14", Offset = "0x20E0D14", VA = "0x20E0D14")]
			set
			{
			}
		}

		// Token: 0x1700029B RID: 667
		// (get) Token: 0x060019E9 RID: 6633 RVA: 0x00009EE8 File Offset: 0x000080E8
		// (set) Token: 0x060019EA RID: 6634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700029B")]
		[DebuggerNonUserCode]
		public int MaxLevel
		{
			[Token(Token = "0x60019E9")]
			[Address(RVA = "0x20E0D1C", Offset = "0x20E0D1C", VA = "0x20E0D1C")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60019EA")]
			[Address(RVA = "0x20E0D24", Offset = "0x20E0D24", VA = "0x20E0D24")]
			set
			{
			}
		}

		// Token: 0x1700029C RID: 668
		// (get) Token: 0x060019EB RID: 6635 RVA: 0x00009F00 File Offset: 0x00008100
		// (set) Token: 0x060019EC RID: 6636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700029C")]
		[DebuggerNonUserCode]
		public int RankLv
		{
			[Token(Token = "0x60019EB")]
			[Address(RVA = "0x20E0D2C", Offset = "0x20E0D2C", VA = "0x20E0D2C")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60019EC")]
			[Address(RVA = "0x20E0D34", Offset = "0x20E0D34", VA = "0x20E0D34")]
			set
			{
			}
		}

		// Token: 0x1700029D RID: 669
		// (get) Token: 0x060019ED RID: 6637 RVA: 0x00009F18 File Offset: 0x00008118
		// (set) Token: 0x060019EE RID: 6638 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700029D")]
		[DebuggerNonUserCode]
		public int Stage
		{
			[Token(Token = "0x60019ED")]
			[Address(RVA = "0x20E0D3C", Offset = "0x20E0D3C", VA = "0x20E0D3C")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60019EE")]
			[Address(RVA = "0x20E0D44", Offset = "0x20E0D44", VA = "0x20E0D44")]
			set
			{
			}
		}

		// Token: 0x060019EF RID: 6639 RVA: 0x00009F30 File Offset: 0x00008130
		[Token(Token = "0x60019EF")]
		[Address(RVA = "0x20E0D4C", Offset = "0x20E0D4C", VA = "0x20E0D4C", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x060019F0 RID: 6640 RVA: 0x00009F48 File Offset: 0x00008148
		[Token(Token = "0x60019F0")]
		[Address(RVA = "0x20E0DB0", Offset = "0x20E0DB0", VA = "0x20E0DB0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(HeroInfoProto other)
		{
			return default(bool);
		}

		// Token: 0x060019F1 RID: 6641 RVA: 0x00009F60 File Offset: 0x00008160
		[Token(Token = "0x60019F1")]
		[Address(RVA = "0x20E0EC0", Offset = "0x20E0EC0", VA = "0x20E0EC0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060019F2 RID: 6642 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019F2")]
		[Address(RVA = "0x20E1004", Offset = "0x20E1004", VA = "0x20E1004", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060019F3 RID: 6643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019F3")]
		[Address(RVA = "0x20E105C", Offset = "0x20E105C", VA = "0x20E105C", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060019F4 RID: 6644 RVA: 0x00009F78 File Offset: 0x00008178
		[Token(Token = "0x60019F4")]
		[Address(RVA = "0x20E1274", Offset = "0x20E1274", VA = "0x20E1274", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060019F5 RID: 6645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019F5")]
		[Address(RVA = "0x20E1498", Offset = "0x20E1498", VA = "0x20E1498", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(HeroInfoProto other)
		{
		}

		// Token: 0x060019F6 RID: 6646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019F6")]
		[Address(RVA = "0x20E1580", Offset = "0x20E1580", VA = "0x20E1580", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x04001BD1 RID: 7121
		[Token(Token = "0x4001BD1")]
		[FieldOffset(Offset = "0x0")]
		private static readonly MessageParser<HeroInfoProto> _parser;

		// Token: 0x04001BD2 RID: 7122
		[Token(Token = "0x4001BD2")]
		[FieldOffset(Offset = "0x10")]
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001BD3 RID: 7123
		[Token(Token = "0x4001BD3")]
		public const int HeroIdFieldNumber = 1;

		// Token: 0x04001BD4 RID: 7124
		[Token(Token = "0x4001BD4")]
		[FieldOffset(Offset = "0x18")]
		private int heroId_;

		// Token: 0x04001BD5 RID: 7125
		[Token(Token = "0x4001BD5")]
		public const int HeroLevelFieldNumber = 2;

		// Token: 0x04001BD6 RID: 7126
		[Token(Token = "0x4001BD6")]
		[FieldOffset(Offset = "0x1C")]
		private int heroLevel_;

		// Token: 0x04001BD7 RID: 7127
		[Token(Token = "0x4001BD7")]
		public const int HeroQualityFieldNumber = 3;

		// Token: 0x04001BD8 RID: 7128
		[Token(Token = "0x4001BD8")]
		[FieldOffset(Offset = "0x20")]
		private int heroQuality_;

		// Token: 0x04001BD9 RID: 7129
		[Token(Token = "0x4001BD9")]
		public const int IndexFieldNumber = 4;

		// Token: 0x04001BDA RID: 7130
		[Token(Token = "0x4001BDA")]
		[FieldOffset(Offset = "0x24")]
		private int index_;

		// Token: 0x04001BDB RID: 7131
		[Token(Token = "0x4001BDB")]
		public const int SkillInfosFieldNumber = 5;

		// Token: 0x04001BDC RID: 7132
		[Token(Token = "0x4001BDC")]
		[FieldOffset(Offset = "0x8")]
		private static readonly FieldCodec<HeroSkillInfoProto> _repeated_skillInfos_codec;

		// Token: 0x04001BDD RID: 7133
		[Token(Token = "0x4001BDD")]
		[FieldOffset(Offset = "0x28")]
		private readonly RepeatedField<HeroSkillInfoProto> skillInfos_;

		// Token: 0x04001BDE RID: 7134
		[Token(Token = "0x4001BDE")]
		public const int HeroUuidFieldNumber = 6;

		// Token: 0x04001BDF RID: 7135
		[Token(Token = "0x4001BDF")]
		[FieldOffset(Offset = "0x30")]
		private long heroUuid_;

		// Token: 0x04001BE0 RID: 7136
		[Token(Token = "0x4001BE0")]
		public const int MaxLevelFieldNumber = 7;

		// Token: 0x04001BE1 RID: 7137
		[Token(Token = "0x4001BE1")]
		[FieldOffset(Offset = "0x38")]
		private int maxLevel_;

		// Token: 0x04001BE2 RID: 7138
		[Token(Token = "0x4001BE2")]
		public const int RankLvFieldNumber = 8;

		// Token: 0x04001BE3 RID: 7139
		[Token(Token = "0x4001BE3")]
		[FieldOffset(Offset = "0x3C")]
		private int rankLv_;

		// Token: 0x04001BE4 RID: 7140
		[Token(Token = "0x4001BE4")]
		public const int StageFieldNumber = 9;

		// Token: 0x04001BE5 RID: 7141
		[Token(Token = "0x4001BE5")]
		[FieldOffset(Offset = "0x40")]
		private int stage_;
	}
}
