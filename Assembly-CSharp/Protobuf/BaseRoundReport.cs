using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Protobuf
{
	// Token: 0x0200040E RID: 1038
	[Token(Token = "0x200040E")]
	public sealed class BaseRoundReport : IMessage<BaseRoundReport>, IMessage, IEquatable<BaseRoundReport>, IDeepCloneable<BaseRoundReport>
	{
		// Token: 0x17000304 RID: 772
		// (get) Token: 0x06001B4E RID: 6990 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000304")]
		[DebuggerNonUserCode]
		public static MessageParser<BaseRoundReport> Parser
		{
			[Token(Token = "0x6001B4E")]
			[Address(RVA = "0x26F2180", Offset = "0x26F2180", VA = "0x26F2180")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000305 RID: 773
		// (get) Token: 0x06001B4F RID: 6991 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000305")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Token(Token = "0x6001B4F")]
			[Address(RVA = "0x26F21D8", Offset = "0x26F21D8", VA = "0x26F21D8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000306 RID: 774
		// (get) Token: 0x06001B50 RID: 6992 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000306")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Token(Token = "0x6001B50")]
			[Address(RVA = "0x26F22DC", Offset = "0x26F22DC", VA = "0x26F22DC", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001B51 RID: 6993 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B51")]
		[Address(RVA = "0x26F2328", Offset = "0x26F2328", VA = "0x26F2328")]
		[DebuggerNonUserCode]
		public BaseRoundReport()
		{
		}

		// Token: 0x06001B52 RID: 6994 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B52")]
		[Address(RVA = "0x26F2380", Offset = "0x26F2380", VA = "0x26F2380")]
		[DebuggerNonUserCode]
		public BaseRoundReport(BaseRoundReport other)
		{
		}

		// Token: 0x06001B53 RID: 6995 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B53")]
		[Address(RVA = "0x26F23F8", Offset = "0x26F23F8", VA = "0x26F23F8", Slot = "10")]
		[DebuggerNonUserCode]
		public BaseRoundReport Clone()
		{
			return null;
		}

		// Token: 0x17000307 RID: 775
		// (get) Token: 0x06001B54 RID: 6996 RVA: 0x0000A710 File Offset: 0x00008910
		// (set) Token: 0x06001B55 RID: 6997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000307")]
		[DebuggerNonUserCode]
		public int TriggerIndex
		{
			[Token(Token = "0x6001B54")]
			[Address(RVA = "0x26F2458", Offset = "0x26F2458", VA = "0x26F2458")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001B55")]
			[Address(RVA = "0x26F2460", Offset = "0x26F2460", VA = "0x26F2460")]
			set
			{
			}
		}

		// Token: 0x17000308 RID: 776
		// (get) Token: 0x06001B56 RID: 6998 RVA: 0x0000A728 File Offset: 0x00008928
		// (set) Token: 0x06001B57 RID: 6999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000308")]
		[DebuggerNonUserCode]
		public int Round
		{
			[Token(Token = "0x6001B56")]
			[Address(RVA = "0x26F2468", Offset = "0x26F2468", VA = "0x26F2468")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001B57")]
			[Address(RVA = "0x26F2470", Offset = "0x26F2470", VA = "0x26F2470")]
			set
			{
			}
		}

		// Token: 0x17000309 RID: 777
		// (get) Token: 0x06001B58 RID: 7000 RVA: 0x0000A740 File Offset: 0x00008940
		// (set) Token: 0x06001B59 RID: 7001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000309")]
		[DebuggerNonUserCode]
		public int Value
		{
			[Token(Token = "0x6001B58")]
			[Address(RVA = "0x26F2478", Offset = "0x26F2478", VA = "0x26F2478")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001B59")]
			[Address(RVA = "0x26F2480", Offset = "0x26F2480", VA = "0x26F2480")]
			set
			{
			}
		}

		// Token: 0x1700030A RID: 778
		// (get) Token: 0x06001B5A RID: 7002 RVA: 0x0000A758 File Offset: 0x00008958
		// (set) Token: 0x06001B5B RID: 7003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700030A")]
		[DebuggerNonUserCode]
		public int Type
		{
			[Token(Token = "0x6001B5A")]
			[Address(RVA = "0x26F2488", Offset = "0x26F2488", VA = "0x26F2488")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001B5B")]
			[Address(RVA = "0x26F2490", Offset = "0x26F2490", VA = "0x26F2490")]
			set
			{
			}
		}

		// Token: 0x1700030B RID: 779
		// (get) Token: 0x06001B5C RID: 7004 RVA: 0x0000A770 File Offset: 0x00008970
		// (set) Token: 0x06001B5D RID: 7005 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700030B")]
		[DebuggerNonUserCode]
		public int SkillId
		{
			[Token(Token = "0x6001B5C")]
			[Address(RVA = "0x26F2498", Offset = "0x26F2498", VA = "0x26F2498")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001B5D")]
			[Address(RVA = "0x26F24A0", Offset = "0x26F24A0", VA = "0x26F24A0")]
			set
			{
			}
		}

		// Token: 0x1700030C RID: 780
		// (get) Token: 0x06001B5E RID: 7006 RVA: 0x0000A788 File Offset: 0x00008988
		// (set) Token: 0x06001B5F RID: 7007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700030C")]
		[DebuggerNonUserCode]
		public int SkillLevel
		{
			[Token(Token = "0x6001B5E")]
			[Address(RVA = "0x26F24A8", Offset = "0x26F24A8", VA = "0x26F24A8")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001B5F")]
			[Address(RVA = "0x26F24B0", Offset = "0x26F24B0", VA = "0x26F24B0")]
			set
			{
			}
		}

		// Token: 0x1700030D RID: 781
		// (get) Token: 0x06001B60 RID: 7008 RVA: 0x0000A7A0 File Offset: 0x000089A0
		// (set) Token: 0x06001B61 RID: 7009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700030D")]
		[DebuggerNonUserCode]
		public int HeroId
		{
			[Token(Token = "0x6001B60")]
			[Address(RVA = "0x26F24B8", Offset = "0x26F24B8", VA = "0x26F24B8")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001B61")]
			[Address(RVA = "0x26F24C0", Offset = "0x26F24C0", VA = "0x26F24C0")]
			set
			{
			}
		}

		// Token: 0x1700030E RID: 782
		// (get) Token: 0x06001B62 RID: 7010 RVA: 0x0000A7B8 File Offset: 0x000089B8
		// (set) Token: 0x06001B63 RID: 7011 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700030E")]
		[DebuggerNonUserCode]
		public int TargetIndex
		{
			[Token(Token = "0x6001B62")]
			[Address(RVA = "0x26F24C8", Offset = "0x26F24C8", VA = "0x26F24C8")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001B63")]
			[Address(RVA = "0x26F24D0", Offset = "0x26F24D0", VA = "0x26F24D0")]
			set
			{
			}
		}

		// Token: 0x1700030F RID: 783
		// (get) Token: 0x06001B64 RID: 7012 RVA: 0x0000A7D0 File Offset: 0x000089D0
		// (set) Token: 0x06001B65 RID: 7013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700030F")]
		[DebuggerNonUserCode]
		public int Health
		{
			[Token(Token = "0x6001B64")]
			[Address(RVA = "0x26F24D8", Offset = "0x26F24D8", VA = "0x26F24D8")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001B65")]
			[Address(RVA = "0x26F24E0", Offset = "0x26F24E0", VA = "0x26F24E0")]
			set
			{
			}
		}

		// Token: 0x17000310 RID: 784
		// (get) Token: 0x06001B66 RID: 7014 RVA: 0x0000A7E8 File Offset: 0x000089E8
		// (set) Token: 0x06001B67 RID: 7015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000310")]
		[DebuggerNonUserCode]
		public int Param
		{
			[Token(Token = "0x6001B66")]
			[Address(RVA = "0x26F24E8", Offset = "0x26F24E8", VA = "0x26F24E8")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001B67")]
			[Address(RVA = "0x26F24F0", Offset = "0x26F24F0", VA = "0x26F24F0")]
			set
			{
			}
		}

		// Token: 0x17000311 RID: 785
		// (get) Token: 0x06001B68 RID: 7016 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001B69 RID: 7017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000311")]
		[DebuggerNonUserCode]
		public string SpecialParam
		{
			[Token(Token = "0x6001B68")]
			[Address(RVA = "0x26F24F8", Offset = "0x26F24F8", VA = "0x26F24F8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001B69")]
			[Address(RVA = "0x26F2500", Offset = "0x26F2500", VA = "0x26F2500")]
			set
			{
			}
		}

		// Token: 0x17000312 RID: 786
		// (get) Token: 0x06001B6A RID: 7018 RVA: 0x0000A800 File Offset: 0x00008A00
		// (set) Token: 0x06001B6B RID: 7019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000312")]
		[DebuggerNonUserCode]
		public int DamageEffectType
		{
			[Token(Token = "0x6001B6A")]
			[Address(RVA = "0x26F257C", Offset = "0x26F257C", VA = "0x26F257C")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001B6B")]
			[Address(RVA = "0x26F2584", Offset = "0x26F2584", VA = "0x26F2584")]
			set
			{
			}
		}

		// Token: 0x06001B6C RID: 7020 RVA: 0x0000A818 File Offset: 0x00008A18
		[Token(Token = "0x6001B6C")]
		[Address(RVA = "0x26F258C", Offset = "0x26F258C", VA = "0x26F258C", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06001B6D RID: 7021 RVA: 0x0000A830 File Offset: 0x00008A30
		[Token(Token = "0x6001B6D")]
		[Address(RVA = "0x26F25F0", Offset = "0x26F25F0", VA = "0x26F25F0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(BaseRoundReport other)
		{
			return default(bool);
		}

		// Token: 0x06001B6E RID: 7022 RVA: 0x0000A848 File Offset: 0x00008A48
		[Token(Token = "0x6001B6E")]
		[Address(RVA = "0x26F2700", Offset = "0x26F2700", VA = "0x26F2700", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001B6F RID: 7023 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B6F")]
		[Address(RVA = "0x26F2898", Offset = "0x26F2898", VA = "0x26F2898", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001B70 RID: 7024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B70")]
		[Address(RVA = "0x26F28F0", Offset = "0x26F28F0", VA = "0x26F28F0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06001B71 RID: 7025 RVA: 0x0000A860 File Offset: 0x00008A60
		[Token(Token = "0x6001B71")]
		[Address(RVA = "0x26F2B44", Offset = "0x26F2B44", VA = "0x26F2B44", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06001B72 RID: 7026 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B72")]
		[Address(RVA = "0x26F2DBC", Offset = "0x26F2DBC", VA = "0x26F2DBC", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(BaseRoundReport other)
		{
		}

		// Token: 0x06001B73 RID: 7027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B73")]
		[Address(RVA = "0x26F2EA4", Offset = "0x26F2EA4", VA = "0x26F2EA4", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x04001CA0 RID: 7328
		[Token(Token = "0x4001CA0")]
		[FieldOffset(Offset = "0x0")]
		private static readonly MessageParser<BaseRoundReport> _parser;

		// Token: 0x04001CA1 RID: 7329
		[Token(Token = "0x4001CA1")]
		[FieldOffset(Offset = "0x10")]
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001CA2 RID: 7330
		[Token(Token = "0x4001CA2")]
		public const int TriggerIndexFieldNumber = 1;

		// Token: 0x04001CA3 RID: 7331
		[Token(Token = "0x4001CA3")]
		[FieldOffset(Offset = "0x18")]
		private int triggerIndex_;

		// Token: 0x04001CA4 RID: 7332
		[Token(Token = "0x4001CA4")]
		public const int RoundFieldNumber = 2;

		// Token: 0x04001CA5 RID: 7333
		[Token(Token = "0x4001CA5")]
		[FieldOffset(Offset = "0x1C")]
		private int round_;

		// Token: 0x04001CA6 RID: 7334
		[Token(Token = "0x4001CA6")]
		public const int ValueFieldNumber = 3;

		// Token: 0x04001CA7 RID: 7335
		[Token(Token = "0x4001CA7")]
		[FieldOffset(Offset = "0x20")]
		private int value_;

		// Token: 0x04001CA8 RID: 7336
		[Token(Token = "0x4001CA8")]
		public const int TypeFieldNumber = 4;

		// Token: 0x04001CA9 RID: 7337
		[Token(Token = "0x4001CA9")]
		[FieldOffset(Offset = "0x24")]
		private int type_;

		// Token: 0x04001CAA RID: 7338
		[Token(Token = "0x4001CAA")]
		public const int SkillIdFieldNumber = 5;

		// Token: 0x04001CAB RID: 7339
		[Token(Token = "0x4001CAB")]
		[FieldOffset(Offset = "0x28")]
		private int skillId_;

		// Token: 0x04001CAC RID: 7340
		[Token(Token = "0x4001CAC")]
		public const int SkillLevelFieldNumber = 6;

		// Token: 0x04001CAD RID: 7341
		[Token(Token = "0x4001CAD")]
		[FieldOffset(Offset = "0x2C")]
		private int skillLevel_;

		// Token: 0x04001CAE RID: 7342
		[Token(Token = "0x4001CAE")]
		public const int HeroIdFieldNumber = 7;

		// Token: 0x04001CAF RID: 7343
		[Token(Token = "0x4001CAF")]
		[FieldOffset(Offset = "0x30")]
		private int heroId_;

		// Token: 0x04001CB0 RID: 7344
		[Token(Token = "0x4001CB0")]
		public const int TargetIndexFieldNumber = 8;

		// Token: 0x04001CB1 RID: 7345
		[Token(Token = "0x4001CB1")]
		[FieldOffset(Offset = "0x34")]
		private int targetIndex_;

		// Token: 0x04001CB2 RID: 7346
		[Token(Token = "0x4001CB2")]
		public const int HealthFieldNumber = 9;

		// Token: 0x04001CB3 RID: 7347
		[Token(Token = "0x4001CB3")]
		[FieldOffset(Offset = "0x38")]
		private int health_;

		// Token: 0x04001CB4 RID: 7348
		[Token(Token = "0x4001CB4")]
		public const int ParamFieldNumber = 10;

		// Token: 0x04001CB5 RID: 7349
		[Token(Token = "0x4001CB5")]
		[FieldOffset(Offset = "0x3C")]
		private int param_;

		// Token: 0x04001CB6 RID: 7350
		[Token(Token = "0x4001CB6")]
		public const int SpecialParamFieldNumber = 11;

		// Token: 0x04001CB7 RID: 7351
		[Token(Token = "0x4001CB7")]
		[FieldOffset(Offset = "0x40")]
		private string specialParam_;

		// Token: 0x04001CB8 RID: 7352
		[Token(Token = "0x4001CB8")]
		public const int DamageEffectTypeFieldNumber = 12;

		// Token: 0x04001CB9 RID: 7353
		[Token(Token = "0x4001CB9")]
		[FieldOffset(Offset = "0x48")]
		private int damageEffectType_;
	}
}
