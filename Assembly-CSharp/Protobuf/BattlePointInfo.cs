using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Protobuf
{
	// Token: 0x02000444 RID: 1092
	[Token(Token = "0x2000444")]
	public sealed class BattlePointInfo : IMessage<BattlePointInfo>, IMessage, IEquatable<BattlePointInfo>, IDeepCloneable<BattlePointInfo>
	{
		// Token: 0x170003CE RID: 974
		// (get) Token: 0x06001E1A RID: 7706 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003CE")]
		[DebuggerNonUserCode]
		public static MessageParser<BattlePointInfo> Parser
		{
			[Token(Token = "0x6001E1A")]
			[Address(RVA = "0x259C11C", Offset = "0x259C11C", VA = "0x259C11C")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003CF RID: 975
		// (get) Token: 0x06001E1B RID: 7707 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003CF")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Token(Token = "0x6001E1B")]
			[Address(RVA = "0x259C174", Offset = "0x259C174", VA = "0x259C174")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003D0 RID: 976
		// (get) Token: 0x06001E1C RID: 7708 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003D0")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Token(Token = "0x6001E1C")]
			[Address(RVA = "0x259C278", Offset = "0x259C278", VA = "0x259C278", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001E1D RID: 7709 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E1D")]
		[Address(RVA = "0x259C2C4", Offset = "0x259C2C4", VA = "0x259C2C4")]
		[DebuggerNonUserCode]
		public BattlePointInfo()
		{
		}

		// Token: 0x06001E1E RID: 7710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E1E")]
		[Address(RVA = "0x259C2CC", Offset = "0x259C2CC", VA = "0x259C2CC")]
		[DebuggerNonUserCode]
		public BattlePointInfo(BattlePointInfo other)
		{
		}

		// Token: 0x06001E1F RID: 7711 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E1F")]
		[Address(RVA = "0x259C318", Offset = "0x259C318", VA = "0x259C318", Slot = "10")]
		[DebuggerNonUserCode]
		public BattlePointInfo Clone()
		{
			return null;
		}

		// Token: 0x170003D1 RID: 977
		// (get) Token: 0x06001E20 RID: 7712 RVA: 0x0000B778 File Offset: 0x00009978
		// (set) Token: 0x06001E21 RID: 7713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003D1")]
		[DebuggerNonUserCode]
		public int BattleServerId
		{
			[Token(Token = "0x6001E20")]
			[Address(RVA = "0x259C378", Offset = "0x259C378", VA = "0x259C378")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001E21")]
			[Address(RVA = "0x259C380", Offset = "0x259C380", VA = "0x259C380")]
			set
			{
			}
		}

		// Token: 0x170003D2 RID: 978
		// (get) Token: 0x06001E22 RID: 7714 RVA: 0x0000B790 File Offset: 0x00009990
		// (set) Token: 0x06001E23 RID: 7715 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003D2")]
		[DebuggerNonUserCode]
		public int ServerType
		{
			[Token(Token = "0x6001E22")]
			[Address(RVA = "0x259C388", Offset = "0x259C388", VA = "0x259C388")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001E23")]
			[Address(RVA = "0x259C390", Offset = "0x259C390", VA = "0x259C390")]
			set
			{
			}
		}

		// Token: 0x170003D3 RID: 979
		// (get) Token: 0x06001E24 RID: 7716 RVA: 0x0000B7A8 File Offset: 0x000099A8
		// (set) Token: 0x06001E25 RID: 7717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003D3")]
		[DebuggerNonUserCode]
		public int PointId
		{
			[Token(Token = "0x6001E24")]
			[Address(RVA = "0x259C398", Offset = "0x259C398", VA = "0x259C398")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001E25")]
			[Address(RVA = "0x259C3A0", Offset = "0x259C3A0", VA = "0x259C3A0")]
			set
			{
			}
		}

		// Token: 0x170003D4 RID: 980
		// (get) Token: 0x06001E26 RID: 7718 RVA: 0x0000B7C0 File Offset: 0x000099C0
		// (set) Token: 0x06001E27 RID: 7719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003D4")]
		[DebuggerNonUserCode]
		public int WorldId
		{
			[Token(Token = "0x6001E26")]
			[Address(RVA = "0x259C3A8", Offset = "0x259C3A8", VA = "0x259C3A8")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001E27")]
			[Address(RVA = "0x259C3B0", Offset = "0x259C3B0", VA = "0x259C3B0")]
			set
			{
			}
		}

		// Token: 0x06001E28 RID: 7720 RVA: 0x0000B7D8 File Offset: 0x000099D8
		[Token(Token = "0x6001E28")]
		[Address(RVA = "0x259C3B8", Offset = "0x259C3B8", VA = "0x259C3B8", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06001E29 RID: 7721 RVA: 0x0000B7F0 File Offset: 0x000099F0
		[Token(Token = "0x6001E29")]
		[Address(RVA = "0x259C41C", Offset = "0x259C41C", VA = "0x259C41C", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(BattlePointInfo other)
		{
			return default(bool);
		}

		// Token: 0x06001E2A RID: 7722 RVA: 0x0000B808 File Offset: 0x00009A08
		[Token(Token = "0x6001E2A")]
		[Address(RVA = "0x259C488", Offset = "0x259C488", VA = "0x259C488", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001E2B RID: 7723 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E2B")]
		[Address(RVA = "0x259C538", Offset = "0x259C538", VA = "0x259C538", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001E2C RID: 7724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E2C")]
		[Address(RVA = "0x259C590", Offset = "0x259C590", VA = "0x259C590", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06001E2D RID: 7725 RVA: 0x0000B820 File Offset: 0x00009A20
		[Token(Token = "0x6001E2D")]
		[Address(RVA = "0x259C67C", Offset = "0x259C67C", VA = "0x259C67C", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06001E2E RID: 7726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E2E")]
		[Address(RVA = "0x259C788", Offset = "0x259C788", VA = "0x259C788", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(BattlePointInfo other)
		{
		}

		// Token: 0x06001E2F RID: 7727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E2F")]
		[Address(RVA = "0x259C7EC", Offset = "0x259C7EC", VA = "0x259C7EC", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x04001DEF RID: 7663
		[Token(Token = "0x4001DEF")]
		[FieldOffset(Offset = "0x0")]
		private static readonly MessageParser<BattlePointInfo> _parser;

		// Token: 0x04001DF0 RID: 7664
		[Token(Token = "0x4001DF0")]
		[FieldOffset(Offset = "0x10")]
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001DF1 RID: 7665
		[Token(Token = "0x4001DF1")]
		public const int BattleServerIdFieldNumber = 1;

		// Token: 0x04001DF2 RID: 7666
		[Token(Token = "0x4001DF2")]
		[FieldOffset(Offset = "0x18")]
		private int battleServerId_;

		// Token: 0x04001DF3 RID: 7667
		[Token(Token = "0x4001DF3")]
		public const int ServerTypeFieldNumber = 2;

		// Token: 0x04001DF4 RID: 7668
		[Token(Token = "0x4001DF4")]
		[FieldOffset(Offset = "0x1C")]
		private int serverType_;

		// Token: 0x04001DF5 RID: 7669
		[Token(Token = "0x4001DF5")]
		public const int PointIdFieldNumber = 3;

		// Token: 0x04001DF6 RID: 7670
		[Token(Token = "0x4001DF6")]
		[FieldOffset(Offset = "0x20")]
		private int pointId_;

		// Token: 0x04001DF7 RID: 7671
		[Token(Token = "0x4001DF7")]
		public const int WorldIdFieldNumber = 4;

		// Token: 0x04001DF8 RID: 7672
		[Token(Token = "0x4001DF8")]
		[FieldOffset(Offset = "0x24")]
		private int worldId_;
	}
}
