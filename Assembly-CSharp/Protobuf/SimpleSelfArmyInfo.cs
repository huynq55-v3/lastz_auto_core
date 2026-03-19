using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Protobuf
{
	// Token: 0x02000465 RID: 1125
	[Token(Token = "0x2000465")]
	public sealed class SimpleSelfArmyInfo : IMessage<SimpleSelfArmyInfo>, IMessage, IEquatable<SimpleSelfArmyInfo>, IDeepCloneable<SimpleSelfArmyInfo>
	{
		// Token: 0x17000435 RID: 1077
		// (get) Token: 0x06001F9D RID: 8093 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000435")]
		[DebuggerNonUserCode]
		public static MessageParser<SimpleSelfArmyInfo> Parser
		{
			[Token(Token = "0x6001F9D")]
			[Address(RVA = "0x25A9494", Offset = "0x25A9494", VA = "0x25A9494")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000436 RID: 1078
		// (get) Token: 0x06001F9E RID: 8094 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000436")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Token(Token = "0x6001F9E")]
			[Address(RVA = "0x25A94EC", Offset = "0x25A94EC", VA = "0x25A94EC")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000437 RID: 1079
		// (get) Token: 0x06001F9F RID: 8095 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000437")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Token(Token = "0x6001F9F")]
			[Address(RVA = "0x25A95F0", Offset = "0x25A95F0", VA = "0x25A95F0", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001FA0 RID: 8096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FA0")]
		[Address(RVA = "0x25A963C", Offset = "0x25A963C", VA = "0x25A963C")]
		[DebuggerNonUserCode]
		public SimpleSelfArmyInfo()
		{
		}

		// Token: 0x06001FA1 RID: 8097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FA1")]
		[Address(RVA = "0x25A96C4", Offset = "0x25A96C4", VA = "0x25A96C4")]
		[DebuggerNonUserCode]
		public SimpleSelfArmyInfo(SimpleSelfArmyInfo other)
		{
		}

		// Token: 0x06001FA2 RID: 8098 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FA2")]
		[Address(RVA = "0x25A97BC", Offset = "0x25A97BC", VA = "0x25A97BC", Slot = "10")]
		[DebuggerNonUserCode]
		public SimpleSelfArmyInfo Clone()
		{
			return null;
		}

		// Token: 0x17000438 RID: 1080
		// (get) Token: 0x06001FA3 RID: 8099 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001FA4 RID: 8100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000438")]
		[DebuggerNonUserCode]
		public SimpleCombatUnitPushObj ArmyInfo
		{
			[Token(Token = "0x6001FA3")]
			[Address(RVA = "0x25A981C", Offset = "0x25A981C", VA = "0x25A981C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001FA4")]
			[Address(RVA = "0x25A9824", Offset = "0x25A9824", VA = "0x25A9824")]
			set
			{
			}
		}

		// Token: 0x17000439 RID: 1081
		// (get) Token: 0x06001FA5 RID: 8101 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001FA6 RID: 8102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000439")]
		[DebuggerNonUserCode]
		public SimpleCombatUnitPushObj TargetInfo
		{
			[Token(Token = "0x6001FA5")]
			[Address(RVA = "0x25A982C", Offset = "0x25A982C", VA = "0x25A982C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001FA6")]
			[Address(RVA = "0x25A9834", Offset = "0x25A9834", VA = "0x25A9834")]
			set
			{
			}
		}

		// Token: 0x1700043A RID: 1082
		// (get) Token: 0x06001FA7 RID: 8103 RVA: 0x0000C0C0 File Offset: 0x0000A2C0
		// (set) Token: 0x06001FA8 RID: 8104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700043A")]
		[DebuggerNonUserCode]
		public int Hurt
		{
			[Token(Token = "0x6001FA7")]
			[Address(RVA = "0x25A983C", Offset = "0x25A983C", VA = "0x25A983C")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001FA8")]
			[Address(RVA = "0x25A9844", Offset = "0x25A9844", VA = "0x25A9844")]
			set
			{
			}
		}

		// Token: 0x1700043B RID: 1083
		// (get) Token: 0x06001FA9 RID: 8105 RVA: 0x0000C0D8 File Offset: 0x0000A2D8
		// (set) Token: 0x06001FAA RID: 8106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700043B")]
		[DebuggerNonUserCode]
		public int Heal
		{
			[Token(Token = "0x6001FA9")]
			[Address(RVA = "0x25A984C", Offset = "0x25A984C", VA = "0x25A984C")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001FAA")]
			[Address(RVA = "0x25A9854", Offset = "0x25A9854", VA = "0x25A9854")]
			set
			{
			}
		}

		// Token: 0x1700043C RID: 1084
		// (get) Token: 0x06001FAB RID: 8107 RVA: 0x0000C0F0 File Offset: 0x0000A2F0
		// (set) Token: 0x06001FAC RID: 8108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700043C")]
		[DebuggerNonUserCode]
		public int ShieldHurt
		{
			[Token(Token = "0x6001FAB")]
			[Address(RVA = "0x25A985C", Offset = "0x25A985C", VA = "0x25A985C")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001FAC")]
			[Address(RVA = "0x25A9864", Offset = "0x25A9864", VA = "0x25A9864")]
			set
			{
			}
		}

		// Token: 0x1700043D RID: 1085
		// (get) Token: 0x06001FAD RID: 8109 RVA: 0x0000C108 File Offset: 0x0000A308
		// (set) Token: 0x06001FAE RID: 8110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700043D")]
		[DebuggerNonUserCode]
		public int Shield
		{
			[Token(Token = "0x6001FAD")]
			[Address(RVA = "0x25A986C", Offset = "0x25A986C", VA = "0x25A986C")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001FAE")]
			[Address(RVA = "0x25A9874", Offset = "0x25A9874", VA = "0x25A9874")]
			set
			{
			}
		}

		// Token: 0x1700043E RID: 1086
		// (get) Token: 0x06001FAF RID: 8111 RVA: 0x0000C120 File Offset: 0x0000A320
		// (set) Token: 0x06001FB0 RID: 8112 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700043E")]
		[DebuggerNonUserCode]
		public int Anger
		{
			[Token(Token = "0x6001FAF")]
			[Address(RVA = "0x25A987C", Offset = "0x25A987C", VA = "0x25A987C")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001FB0")]
			[Address(RVA = "0x25A9884", Offset = "0x25A9884", VA = "0x25A9884")]
			set
			{
			}
		}

		// Token: 0x1700043F RID: 1087
		// (get) Token: 0x06001FB1 RID: 8113 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700043F")]
		[DebuggerNonUserCode]
		public RepeatedField<RoundStatusInfo> StatusInfo
		{
			[Token(Token = "0x6001FB1")]
			[Address(RVA = "0x25A988C", Offset = "0x25A988C", VA = "0x25A988C")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000440 RID: 1088
		// (get) Token: 0x06001FB2 RID: 8114 RVA: 0x0000C138 File Offset: 0x0000A338
		// (set) Token: 0x06001FB3 RID: 8115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000440")]
		[DebuggerNonUserCode]
		public int CarAnger
		{
			[Token(Token = "0x6001FB2")]
			[Address(RVA = "0x25A9894", Offset = "0x25A9894", VA = "0x25A9894")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001FB3")]
			[Address(RVA = "0x25A989C", Offset = "0x25A989C", VA = "0x25A989C")]
			set
			{
			}
		}

		// Token: 0x06001FB4 RID: 8116 RVA: 0x0000C150 File Offset: 0x0000A350
		[Token(Token = "0x6001FB4")]
		[Address(RVA = "0x25A98A4", Offset = "0x25A98A4", VA = "0x25A98A4", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06001FB5 RID: 8117 RVA: 0x0000C168 File Offset: 0x0000A368
		[Token(Token = "0x6001FB5")]
		[Address(RVA = "0x25A9908", Offset = "0x25A9908", VA = "0x25A9908", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(SimpleSelfArmyInfo other)
		{
			return default(bool);
		}

		// Token: 0x06001FB6 RID: 8118 RVA: 0x0000C180 File Offset: 0x0000A380
		[Token(Token = "0x6001FB6")]
		[Address(RVA = "0x25A9A20", Offset = "0x25A9A20", VA = "0x25A9A20", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001FB7 RID: 8119 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FB7")]
		[Address(RVA = "0x25A9B54", Offset = "0x25A9B54", VA = "0x25A9B54", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001FB8 RID: 8120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FB8")]
		[Address(RVA = "0x25A9BAC", Offset = "0x25A9BAC", VA = "0x25A9BAC", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06001FB9 RID: 8121 RVA: 0x0000C198 File Offset: 0x0000A398
		[Token(Token = "0x6001FB9")]
		[Address(RVA = "0x25A9DC4", Offset = "0x25A9DC4", VA = "0x25A9DC4", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06001FBA RID: 8122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FBA")]
		[Address(RVA = "0x25A9FE8", Offset = "0x25A9FE8", VA = "0x25A9FE8", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(SimpleSelfArmyInfo other)
		{
		}

		// Token: 0x06001FBB RID: 8123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FBB")]
		[Address(RVA = "0x25AA170", Offset = "0x25AA170", VA = "0x25AA170", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x04001E97 RID: 7831
		[Token(Token = "0x4001E97")]
		[FieldOffset(Offset = "0x0")]
		private static readonly MessageParser<SimpleSelfArmyInfo> _parser;

		// Token: 0x04001E98 RID: 7832
		[Token(Token = "0x4001E98")]
		[FieldOffset(Offset = "0x10")]
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001E99 RID: 7833
		[Token(Token = "0x4001E99")]
		public const int ArmyInfoFieldNumber = 1;

		// Token: 0x04001E9A RID: 7834
		[Token(Token = "0x4001E9A")]
		[FieldOffset(Offset = "0x18")]
		private SimpleCombatUnitPushObj armyInfo_;

		// Token: 0x04001E9B RID: 7835
		[Token(Token = "0x4001E9B")]
		public const int TargetInfoFieldNumber = 2;

		// Token: 0x04001E9C RID: 7836
		[Token(Token = "0x4001E9C")]
		[FieldOffset(Offset = "0x20")]
		private SimpleCombatUnitPushObj targetInfo_;

		// Token: 0x04001E9D RID: 7837
		[Token(Token = "0x4001E9D")]
		public const int HurtFieldNumber = 3;

		// Token: 0x04001E9E RID: 7838
		[Token(Token = "0x4001E9E")]
		[FieldOffset(Offset = "0x28")]
		private int hurt_;

		// Token: 0x04001E9F RID: 7839
		[Token(Token = "0x4001E9F")]
		public const int HealFieldNumber = 4;

		// Token: 0x04001EA0 RID: 7840
		[Token(Token = "0x4001EA0")]
		[FieldOffset(Offset = "0x2C")]
		private int heal_;

		// Token: 0x04001EA1 RID: 7841
		[Token(Token = "0x4001EA1")]
		public const int ShieldHurtFieldNumber = 5;

		// Token: 0x04001EA2 RID: 7842
		[Token(Token = "0x4001EA2")]
		[FieldOffset(Offset = "0x30")]
		private int shieldHurt_;

		// Token: 0x04001EA3 RID: 7843
		[Token(Token = "0x4001EA3")]
		public const int ShieldFieldNumber = 6;

		// Token: 0x04001EA4 RID: 7844
		[Token(Token = "0x4001EA4")]
		[FieldOffset(Offset = "0x34")]
		private int shield_;

		// Token: 0x04001EA5 RID: 7845
		[Token(Token = "0x4001EA5")]
		public const int AngerFieldNumber = 7;

		// Token: 0x04001EA6 RID: 7846
		[Token(Token = "0x4001EA6")]
		[FieldOffset(Offset = "0x38")]
		private int anger_;

		// Token: 0x04001EA7 RID: 7847
		[Token(Token = "0x4001EA7")]
		public const int StatusInfoFieldNumber = 8;

		// Token: 0x04001EA8 RID: 7848
		[Token(Token = "0x4001EA8")]
		[FieldOffset(Offset = "0x8")]
		private static readonly FieldCodec<RoundStatusInfo> _repeated_statusInfo_codec;

		// Token: 0x04001EA9 RID: 7849
		[Token(Token = "0x4001EA9")]
		[FieldOffset(Offset = "0x40")]
		private readonly RepeatedField<RoundStatusInfo> statusInfo_;

		// Token: 0x04001EAA RID: 7850
		[Token(Token = "0x4001EAA")]
		public const int CarAngerFieldNumber = 9;

		// Token: 0x04001EAB RID: 7851
		[Token(Token = "0x4001EAB")]
		[FieldOffset(Offset = "0x48")]
		private int carAnger_;
	}
}
