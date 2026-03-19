using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Protobuf
{
	// Token: 0x02000452 RID: 1106
	[Token(Token = "0x2000452")]
	public sealed class DetailReportPlayerInfo : IMessage<DetailReportPlayerInfo>, IMessage, IEquatable<DetailReportPlayerInfo>, IDeepCloneable<DetailReportPlayerInfo>
	{
		// Token: 0x170003FC RID: 1020
		// (get) Token: 0x06001EC4 RID: 7876 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003FC")]
		[DebuggerNonUserCode]
		public static MessageParser<DetailReportPlayerInfo> Parser
		{
			[Token(Token = "0x6001EC4")]
			[Address(RVA = "0x25A122C", Offset = "0x25A122C", VA = "0x25A122C")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003FD RID: 1021
		// (get) Token: 0x06001EC5 RID: 7877 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003FD")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Token(Token = "0x6001EC5")]
			[Address(RVA = "0x25A1284", Offset = "0x25A1284", VA = "0x25A1284")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003FE RID: 1022
		// (get) Token: 0x06001EC6 RID: 7878 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003FE")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Token(Token = "0x6001EC6")]
			[Address(RVA = "0x25A1388", Offset = "0x25A1388", VA = "0x25A1388", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001EC7 RID: 7879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EC7")]
		[Address(RVA = "0x25A13D4", Offset = "0x25A13D4", VA = "0x25A13D4")]
		[DebuggerNonUserCode]
		public DetailReportPlayerInfo()
		{
		}

		// Token: 0x06001EC8 RID: 7880 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EC8")]
		[Address(RVA = "0x25A143C", Offset = "0x25A143C", VA = "0x25A143C")]
		[DebuggerNonUserCode]
		public DetailReportPlayerInfo(DetailReportPlayerInfo other)
		{
		}

		// Token: 0x06001EC9 RID: 7881 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EC9")]
		[Address(RVA = "0x25A14BC", Offset = "0x25A14BC", VA = "0x25A14BC", Slot = "10")]
		[DebuggerNonUserCode]
		public DetailReportPlayerInfo Clone()
		{
			return null;
		}

		// Token: 0x170003FF RID: 1023
		// (get) Token: 0x06001ECA RID: 7882 RVA: 0x0000BB80 File Offset: 0x00009D80
		// (set) Token: 0x06001ECB RID: 7883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003FF")]
		[DebuggerNonUserCode]
		public int Index
		{
			[Token(Token = "0x6001ECA")]
			[Address(RVA = "0x25A151C", Offset = "0x25A151C", VA = "0x25A151C")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001ECB")]
			[Address(RVA = "0x25A1524", Offset = "0x25A1524", VA = "0x25A1524")]
			set
			{
			}
		}

		// Token: 0x17000400 RID: 1024
		// (get) Token: 0x06001ECC RID: 7884 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001ECD RID: 7885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000400")]
		[DebuggerNonUserCode]
		public string Name
		{
			[Token(Token = "0x6001ECC")]
			[Address(RVA = "0x25A152C", Offset = "0x25A152C", VA = "0x25A152C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001ECD")]
			[Address(RVA = "0x25A1534", Offset = "0x25A1534", VA = "0x25A1534")]
			set
			{
			}
		}

		// Token: 0x17000401 RID: 1025
		// (get) Token: 0x06001ECE RID: 7886 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001ECF RID: 7887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000401")]
		[DebuggerNonUserCode]
		public string AlAbbr
		{
			[Token(Token = "0x6001ECE")]
			[Address(RVA = "0x25A15B0", Offset = "0x25A15B0", VA = "0x25A15B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001ECF")]
			[Address(RVA = "0x25A15B8", Offset = "0x25A15B8", VA = "0x25A15B8")]
			set
			{
			}
		}

		// Token: 0x17000402 RID: 1026
		// (get) Token: 0x06001ED0 RID: 7888 RVA: 0x0000BB98 File Offset: 0x00009D98
		// (set) Token: 0x06001ED1 RID: 7889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000402")]
		[DebuggerNonUserCode]
		public bool IsSelf
		{
			[Token(Token = "0x6001ED0")]
			[Address(RVA = "0x25A1634", Offset = "0x25A1634", VA = "0x25A1634")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001ED1")]
			[Address(RVA = "0x25A163C", Offset = "0x25A163C", VA = "0x25A163C")]
			set
			{
			}
		}

		// Token: 0x17000403 RID: 1027
		// (get) Token: 0x06001ED2 RID: 7890 RVA: 0x0000BBB0 File Offset: 0x00009DB0
		// (set) Token: 0x06001ED3 RID: 7891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000403")]
		[DebuggerNonUserCode]
		public int InfoType
		{
			[Token(Token = "0x6001ED2")]
			[Address(RVA = "0x25A1648", Offset = "0x25A1648", VA = "0x25A1648")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001ED3")]
			[Address(RVA = "0x25A1650", Offset = "0x25A1650", VA = "0x25A1650")]
			set
			{
			}
		}

		// Token: 0x17000404 RID: 1028
		// (get) Token: 0x06001ED4 RID: 7892 RVA: 0x0000BBC8 File Offset: 0x00009DC8
		// (set) Token: 0x06001ED5 RID: 7893 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000404")]
		[DebuggerNonUserCode]
		public long Uuid
		{
			[Token(Token = "0x6001ED4")]
			[Address(RVA = "0x25A1658", Offset = "0x25A1658", VA = "0x25A1658")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x6001ED5")]
			[Address(RVA = "0x25A1660", Offset = "0x25A1660", VA = "0x25A1660")]
			set
			{
			}
		}

		// Token: 0x06001ED6 RID: 7894 RVA: 0x0000BBE0 File Offset: 0x00009DE0
		[Token(Token = "0x6001ED6")]
		[Address(RVA = "0x25A1668", Offset = "0x25A1668", VA = "0x25A1668", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06001ED7 RID: 7895 RVA: 0x0000BBF8 File Offset: 0x00009DF8
		[Token(Token = "0x6001ED7")]
		[Address(RVA = "0x25A16CC", Offset = "0x25A16CC", VA = "0x25A16CC", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(DetailReportPlayerInfo other)
		{
			return default(bool);
		}

		// Token: 0x06001ED8 RID: 7896 RVA: 0x0000BC10 File Offset: 0x00009E10
		[Token(Token = "0x6001ED8")]
		[Address(RVA = "0x25A1790", Offset = "0x25A1790", VA = "0x25A1790", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001ED9 RID: 7897 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001ED9")]
		[Address(RVA = "0x25A18D0", Offset = "0x25A18D0", VA = "0x25A18D0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001EDA RID: 7898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EDA")]
		[Address(RVA = "0x25A1928", Offset = "0x25A1928", VA = "0x25A1928", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06001EDB RID: 7899 RVA: 0x0000BC28 File Offset: 0x00009E28
		[Token(Token = "0x6001EDB")]
		[Address(RVA = "0x25A1A7C", Offset = "0x25A1A7C", VA = "0x25A1A7C", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06001EDC RID: 7900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EDC")]
		[Address(RVA = "0x25A1BE0", Offset = "0x25A1BE0", VA = "0x25A1BE0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(DetailReportPlayerInfo other)
		{
		}

		// Token: 0x06001EDD RID: 7901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EDD")]
		[Address(RVA = "0x25A1C8C", Offset = "0x25A1C8C", VA = "0x25A1C8C", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x04001E3C RID: 7740
		[Token(Token = "0x4001E3C")]
		[FieldOffset(Offset = "0x0")]
		private static readonly MessageParser<DetailReportPlayerInfo> _parser;

		// Token: 0x04001E3D RID: 7741
		[Token(Token = "0x4001E3D")]
		[FieldOffset(Offset = "0x10")]
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001E3E RID: 7742
		[Token(Token = "0x4001E3E")]
		public const int IndexFieldNumber = 1;

		// Token: 0x04001E3F RID: 7743
		[Token(Token = "0x4001E3F")]
		[FieldOffset(Offset = "0x18")]
		private int index_;

		// Token: 0x04001E40 RID: 7744
		[Token(Token = "0x4001E40")]
		public const int NameFieldNumber = 2;

		// Token: 0x04001E41 RID: 7745
		[Token(Token = "0x4001E41")]
		[FieldOffset(Offset = "0x20")]
		private string name_;

		// Token: 0x04001E42 RID: 7746
		[Token(Token = "0x4001E42")]
		public const int AlAbbrFieldNumber = 3;

		// Token: 0x04001E43 RID: 7747
		[Token(Token = "0x4001E43")]
		[FieldOffset(Offset = "0x28")]
		private string alAbbr_;

		// Token: 0x04001E44 RID: 7748
		[Token(Token = "0x4001E44")]
		public const int IsSelfFieldNumber = 4;

		// Token: 0x04001E45 RID: 7749
		[Token(Token = "0x4001E45")]
		[FieldOffset(Offset = "0x30")]
		private bool isSelf_;

		// Token: 0x04001E46 RID: 7750
		[Token(Token = "0x4001E46")]
		public const int InfoTypeFieldNumber = 5;

		// Token: 0x04001E47 RID: 7751
		[Token(Token = "0x4001E47")]
		[FieldOffset(Offset = "0x34")]
		private int infoType_;

		// Token: 0x04001E48 RID: 7752
		[Token(Token = "0x4001E48")]
		public const int UuidFieldNumber = 6;

		// Token: 0x04001E49 RID: 7753
		[Token(Token = "0x4001E49")]
		[FieldOffset(Offset = "0x38")]
		private long uuid_;
	}
}
