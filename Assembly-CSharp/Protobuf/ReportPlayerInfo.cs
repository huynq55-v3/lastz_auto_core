using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Protobuf
{
	// Token: 0x0200040C RID: 1036
	[Token(Token = "0x200040C")]
	public sealed class ReportPlayerInfo : IMessage<ReportPlayerInfo>, IMessage, IEquatable<ReportPlayerInfo>, IDeepCloneable<ReportPlayerInfo>
	{
		// Token: 0x170002F6 RID: 758
		// (get) Token: 0x06001B26 RID: 6950 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002F6")]
		[DebuggerNonUserCode]
		public static MessageParser<ReportPlayerInfo> Parser
		{
			[Token(Token = "0x6001B26")]
			[Address(RVA = "0x20F60FC", Offset = "0x20F60FC", VA = "0x20F60FC")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002F7 RID: 759
		// (get) Token: 0x06001B27 RID: 6951 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002F7")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Token(Token = "0x6001B27")]
			[Address(RVA = "0x20F6154", Offset = "0x20F6154", VA = "0x20F6154")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002F8 RID: 760
		// (get) Token: 0x06001B28 RID: 6952 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002F8")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Token(Token = "0x6001B28")]
			[Address(RVA = "0x20F6258", Offset = "0x20F6258", VA = "0x20F6258", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001B29 RID: 6953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B29")]
		[Address(RVA = "0x20F62A4", Offset = "0x20F62A4", VA = "0x20F62A4")]
		[DebuggerNonUserCode]
		public ReportPlayerInfo()
		{
		}

		// Token: 0x06001B2A RID: 6954 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B2A")]
		[Address(RVA = "0x20F631C", Offset = "0x20F631C", VA = "0x20F631C")]
		[DebuggerNonUserCode]
		public ReportPlayerInfo(ReportPlayerInfo other)
		{
		}

		// Token: 0x06001B2B RID: 6955 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B2B")]
		[Address(RVA = "0x20F63CC", Offset = "0x20F63CC", VA = "0x20F63CC", Slot = "10")]
		[DebuggerNonUserCode]
		public ReportPlayerInfo Clone()
		{
			return null;
		}

		// Token: 0x170002F9 RID: 761
		// (get) Token: 0x06001B2C RID: 6956 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001B2D RID: 6957 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170002F9")]
		[DebuggerNonUserCode]
		public string Uid
		{
			[Token(Token = "0x6001B2C")]
			[Address(RVA = "0x20F642C", Offset = "0x20F642C", VA = "0x20F642C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001B2D")]
			[Address(RVA = "0x20F6434", Offset = "0x20F6434", VA = "0x20F6434")]
			set
			{
			}
		}

		// Token: 0x170002FA RID: 762
		// (get) Token: 0x06001B2E RID: 6958 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001B2F RID: 6959 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170002FA")]
		[DebuggerNonUserCode]
		public string Name
		{
			[Token(Token = "0x6001B2E")]
			[Address(RVA = "0x20F64B0", Offset = "0x20F64B0", VA = "0x20F64B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001B2F")]
			[Address(RVA = "0x20F64B8", Offset = "0x20F64B8", VA = "0x20F64B8")]
			set
			{
			}
		}

		// Token: 0x170002FB RID: 763
		// (get) Token: 0x06001B30 RID: 6960 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001B31 RID: 6961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170002FB")]
		[DebuggerNonUserCode]
		public string Pic
		{
			[Token(Token = "0x6001B30")]
			[Address(RVA = "0x20F6534", Offset = "0x20F6534", VA = "0x20F6534")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001B31")]
			[Address(RVA = "0x20F653C", Offset = "0x20F653C", VA = "0x20F653C")]
			set
			{
			}
		}

		// Token: 0x170002FC RID: 764
		// (get) Token: 0x06001B32 RID: 6962 RVA: 0x0000A608 File Offset: 0x00008808
		// (set) Token: 0x06001B33 RID: 6963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170002FC")]
		[DebuggerNonUserCode]
		public int PicVer
		{
			[Token(Token = "0x6001B32")]
			[Address(RVA = "0x20F65B8", Offset = "0x20F65B8", VA = "0x20F65B8")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001B33")]
			[Address(RVA = "0x20F65C0", Offset = "0x20F65C0", VA = "0x20F65C0")]
			set
			{
			}
		}

		// Token: 0x170002FD RID: 765
		// (get) Token: 0x06001B34 RID: 6964 RVA: 0x0000A620 File Offset: 0x00008820
		// (set) Token: 0x06001B35 RID: 6965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170002FD")]
		[DebuggerNonUserCode]
		public int SrcServerId
		{
			[Token(Token = "0x6001B34")]
			[Address(RVA = "0x20F65C8", Offset = "0x20F65C8", VA = "0x20F65C8")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001B35")]
			[Address(RVA = "0x20F65D0", Offset = "0x20F65D0", VA = "0x20F65D0")]
			set
			{
			}
		}

		// Token: 0x170002FE RID: 766
		// (get) Token: 0x06001B36 RID: 6966 RVA: 0x0000A638 File Offset: 0x00008838
		// (set) Token: 0x06001B37 RID: 6967 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170002FE")]
		[DebuggerNonUserCode]
		public int PointId
		{
			[Token(Token = "0x6001B36")]
			[Address(RVA = "0x20F65D8", Offset = "0x20F65D8", VA = "0x20F65D8")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001B37")]
			[Address(RVA = "0x20F65E0", Offset = "0x20F65E0", VA = "0x20F65E0")]
			set
			{
			}
		}

		// Token: 0x170002FF RID: 767
		// (get) Token: 0x06001B38 RID: 6968 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001B39 RID: 6969 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170002FF")]
		[DebuggerNonUserCode]
		public ReportAllianceInfo AllianceInfo
		{
			[Token(Token = "0x6001B38")]
			[Address(RVA = "0x20F65E8", Offset = "0x20F65E8", VA = "0x20F65E8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001B39")]
			[Address(RVA = "0x20F65F0", Offset = "0x20F65F0", VA = "0x20F65F0")]
			set
			{
			}
		}

		// Token: 0x17000300 RID: 768
		// (get) Token: 0x06001B3A RID: 6970 RVA: 0x0000A650 File Offset: 0x00008850
		// (set) Token: 0x06001B3B RID: 6971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000300")]
		[DebuggerNonUserCode]
		public int HeadFrame
		{
			[Token(Token = "0x6001B3A")]
			[Address(RVA = "0x20F65F8", Offset = "0x20F65F8", VA = "0x20F65F8")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001B3B")]
			[Address(RVA = "0x20F6600", Offset = "0x20F6600", VA = "0x20F6600")]
			set
			{
			}
		}

		// Token: 0x17000301 RID: 769
		// (get) Token: 0x06001B3C RID: 6972 RVA: 0x0000A668 File Offset: 0x00008868
		// (set) Token: 0x06001B3D RID: 6973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000301")]
		[DebuggerNonUserCode]
		public int CareerType
		{
			[Token(Token = "0x6001B3C")]
			[Address(RVA = "0x20F6608", Offset = "0x20F6608", VA = "0x20F6608")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001B3D")]
			[Address(RVA = "0x20F6610", Offset = "0x20F6610", VA = "0x20F6610")]
			set
			{
			}
		}

		// Token: 0x17000302 RID: 770
		// (get) Token: 0x06001B3E RID: 6974 RVA: 0x0000A680 File Offset: 0x00008880
		// (set) Token: 0x06001B3F RID: 6975 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000302")]
		[DebuggerNonUserCode]
		public int CareerLv
		{
			[Token(Token = "0x6001B3E")]
			[Address(RVA = "0x20F6618", Offset = "0x20F6618", VA = "0x20F6618")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001B3F")]
			[Address(RVA = "0x20F6620", Offset = "0x20F6620", VA = "0x20F6620")]
			set
			{
			}
		}

		// Token: 0x17000303 RID: 771
		// (get) Token: 0x06001B40 RID: 6976 RVA: 0x0000A698 File Offset: 0x00008898
		// (set) Token: 0x06001B41 RID: 6977 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000303")]
		[DebuggerNonUserCode]
		public int HeadSkinId
		{
			[Token(Token = "0x6001B40")]
			[Address(RVA = "0x20F6628", Offset = "0x20F6628", VA = "0x20F6628")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001B41")]
			[Address(RVA = "0x20F6630", Offset = "0x20F6630", VA = "0x20F6630")]
			set
			{
			}
		}

		// Token: 0x06001B42 RID: 6978 RVA: 0x0000A6B0 File Offset: 0x000088B0
		[Token(Token = "0x6001B42")]
		[Address(RVA = "0x20F6638", Offset = "0x20F6638", VA = "0x20F6638", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06001B43 RID: 6979 RVA: 0x0000A6C8 File Offset: 0x000088C8
		[Token(Token = "0x6001B43")]
		[Address(RVA = "0x20F669C", Offset = "0x20F669C", VA = "0x20F669C", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ReportPlayerInfo other)
		{
			return default(bool);
		}

		// Token: 0x06001B44 RID: 6980 RVA: 0x0000A6E0 File Offset: 0x000088E0
		[Token(Token = "0x6001B44")]
		[Address(RVA = "0x20F67A8", Offset = "0x20F67A8", VA = "0x20F67A8", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001B45 RID: 6981 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B45")]
		[Address(RVA = "0x20F6928", Offset = "0x20F6928", VA = "0x20F6928", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001B46 RID: 6982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B46")]
		[Address(RVA = "0x20F6980", Offset = "0x20F6980", VA = "0x20F6980", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06001B47 RID: 6983 RVA: 0x0000A6F8 File Offset: 0x000088F8
		[Token(Token = "0x6001B47")]
		[Address(RVA = "0x20F6BB8", Offset = "0x20F6BB8", VA = "0x20F6BB8", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06001B48 RID: 6984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B48")]
		[Address(RVA = "0x20F6E1C", Offset = "0x20F6E1C", VA = "0x20F6E1C", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(ReportPlayerInfo other)
		{
		}

		// Token: 0x06001B49 RID: 6985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B49")]
		[Address(RVA = "0x20F6F80", Offset = "0x20F6F80", VA = "0x20F6F80", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x04001C87 RID: 7303
		[Token(Token = "0x4001C87")]
		[FieldOffset(Offset = "0x0")]
		private static readonly MessageParser<ReportPlayerInfo> _parser;

		// Token: 0x04001C88 RID: 7304
		[Token(Token = "0x4001C88")]
		[FieldOffset(Offset = "0x10")]
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001C89 RID: 7305
		[Token(Token = "0x4001C89")]
		public const int UidFieldNumber = 1;

		// Token: 0x04001C8A RID: 7306
		[Token(Token = "0x4001C8A")]
		[FieldOffset(Offset = "0x18")]
		private string uid_;

		// Token: 0x04001C8B RID: 7307
		[Token(Token = "0x4001C8B")]
		public const int NameFieldNumber = 2;

		// Token: 0x04001C8C RID: 7308
		[Token(Token = "0x4001C8C")]
		[FieldOffset(Offset = "0x20")]
		private string name_;

		// Token: 0x04001C8D RID: 7309
		[Token(Token = "0x4001C8D")]
		public const int PicFieldNumber = 3;

		// Token: 0x04001C8E RID: 7310
		[Token(Token = "0x4001C8E")]
		[FieldOffset(Offset = "0x28")]
		private string pic_;

		// Token: 0x04001C8F RID: 7311
		[Token(Token = "0x4001C8F")]
		public const int PicVerFieldNumber = 4;

		// Token: 0x04001C90 RID: 7312
		[Token(Token = "0x4001C90")]
		[FieldOffset(Offset = "0x30")]
		private int picVer_;

		// Token: 0x04001C91 RID: 7313
		[Token(Token = "0x4001C91")]
		public const int SrcServerIdFieldNumber = 5;

		// Token: 0x04001C92 RID: 7314
		[Token(Token = "0x4001C92")]
		[FieldOffset(Offset = "0x34")]
		private int srcServerId_;

		// Token: 0x04001C93 RID: 7315
		[Token(Token = "0x4001C93")]
		public const int PointIdFieldNumber = 6;

		// Token: 0x04001C94 RID: 7316
		[Token(Token = "0x4001C94")]
		[FieldOffset(Offset = "0x38")]
		private int pointId_;

		// Token: 0x04001C95 RID: 7317
		[Token(Token = "0x4001C95")]
		public const int AllianceInfoFieldNumber = 7;

		// Token: 0x04001C96 RID: 7318
		[Token(Token = "0x4001C96")]
		[FieldOffset(Offset = "0x40")]
		private ReportAllianceInfo allianceInfo_;

		// Token: 0x04001C97 RID: 7319
		[Token(Token = "0x4001C97")]
		public const int HeadFrameFieldNumber = 8;

		// Token: 0x04001C98 RID: 7320
		[Token(Token = "0x4001C98")]
		[FieldOffset(Offset = "0x48")]
		private int headFrame_;

		// Token: 0x04001C99 RID: 7321
		[Token(Token = "0x4001C99")]
		public const int CareerTypeFieldNumber = 9;

		// Token: 0x04001C9A RID: 7322
		[Token(Token = "0x4001C9A")]
		[FieldOffset(Offset = "0x4C")]
		private int careerType_;

		// Token: 0x04001C9B RID: 7323
		[Token(Token = "0x4001C9B")]
		public const int CareerLvFieldNumber = 10;

		// Token: 0x04001C9C RID: 7324
		[Token(Token = "0x4001C9C")]
		[FieldOffset(Offset = "0x50")]
		private int careerLv_;

		// Token: 0x04001C9D RID: 7325
		[Token(Token = "0x4001C9D")]
		public const int HeadSkinIdFieldNumber = 11;

		// Token: 0x04001C9E RID: 7326
		[Token(Token = "0x4001C9E")]
		[FieldOffset(Offset = "0x54")]
		private int headSkinId_;
	}
}
