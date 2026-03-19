using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Protobuf
{
	// Token: 0x020003ED RID: 1005
	[Token(Token = "0x20003ED")]
	public sealed class SoldierProto : IMessage<SoldierProto>, IMessage, IEquatable<SoldierProto>, IDeepCloneable<SoldierProto>
	{
		// Token: 0x17000282 RID: 642
		// (get) Token: 0x060019A0 RID: 6560 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000282")]
		[DebuggerNonUserCode]
		public static MessageParser<SoldierProto> Parser
		{
			[Token(Token = "0x60019A0")]
			[Address(RVA = "0x20DF38C", Offset = "0x20DF38C", VA = "0x20DF38C")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000283 RID: 643
		// (get) Token: 0x060019A1 RID: 6561 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000283")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Token(Token = "0x60019A1")]
			[Address(RVA = "0x20DF3E4", Offset = "0x20DF3E4", VA = "0x20DF3E4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000284 RID: 644
		// (get) Token: 0x060019A2 RID: 6562 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000284")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Token(Token = "0x60019A2")]
			[Address(RVA = "0x20DF4E8", Offset = "0x20DF4E8", VA = "0x20DF4E8", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x060019A3 RID: 6563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019A3")]
		[Address(RVA = "0x20DF534", Offset = "0x20DF534", VA = "0x20DF534")]
		[DebuggerNonUserCode]
		public SoldierProto()
		{
		}

		// Token: 0x060019A4 RID: 6564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019A4")]
		[Address(RVA = "0x20DF58C", Offset = "0x20DF58C", VA = "0x20DF58C")]
		[DebuggerNonUserCode]
		public SoldierProto(SoldierProto other)
		{
		}

		// Token: 0x060019A5 RID: 6565 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019A5")]
		[Address(RVA = "0x20DF5FC", Offset = "0x20DF5FC", VA = "0x20DF5FC", Slot = "10")]
		[DebuggerNonUserCode]
		public SoldierProto Clone()
		{
			return null;
		}

		// Token: 0x17000285 RID: 645
		// (get) Token: 0x060019A6 RID: 6566 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060019A7 RID: 6567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000285")]
		[DebuggerNonUserCode]
		public string ArmsId
		{
			[Token(Token = "0x60019A6")]
			[Address(RVA = "0x20DF65C", Offset = "0x20DF65C", VA = "0x20DF65C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60019A7")]
			[Address(RVA = "0x20DF664", Offset = "0x20DF664", VA = "0x20DF664")]
			set
			{
			}
		}

		// Token: 0x17000286 RID: 646
		// (get) Token: 0x060019A8 RID: 6568 RVA: 0x00009CD8 File Offset: 0x00007ED8
		// (set) Token: 0x060019A9 RID: 6569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000286")]
		[DebuggerNonUserCode]
		public int Type
		{
			[Token(Token = "0x60019A8")]
			[Address(RVA = "0x20DF6E0", Offset = "0x20DF6E0", VA = "0x20DF6E0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60019A9")]
			[Address(RVA = "0x20DF6E8", Offset = "0x20DF6E8", VA = "0x20DF6E8")]
			set
			{
			}
		}

		// Token: 0x17000287 RID: 647
		// (get) Token: 0x060019AA RID: 6570 RVA: 0x00009CF0 File Offset: 0x00007EF0
		// (set) Token: 0x060019AB RID: 6571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000287")]
		[DebuggerNonUserCode]
		public int Total
		{
			[Token(Token = "0x60019AA")]
			[Address(RVA = "0x20DF6F0", Offset = "0x20DF6F0", VA = "0x20DF6F0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60019AB")]
			[Address(RVA = "0x20DF6F8", Offset = "0x20DF6F8", VA = "0x20DF6F8")]
			set
			{
			}
		}

		// Token: 0x17000288 RID: 648
		// (get) Token: 0x060019AC RID: 6572 RVA: 0x00009D08 File Offset: 0x00007F08
		// (set) Token: 0x060019AD RID: 6573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000288")]
		[DebuggerNonUserCode]
		public int Lost
		{
			[Token(Token = "0x60019AC")]
			[Address(RVA = "0x20DF700", Offset = "0x20DF700", VA = "0x20DF700")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60019AD")]
			[Address(RVA = "0x20DF708", Offset = "0x20DF708", VA = "0x20DF708")]
			set
			{
			}
		}

		// Token: 0x17000289 RID: 649
		// (get) Token: 0x060019AE RID: 6574 RVA: 0x00009D20 File Offset: 0x00007F20
		// (set) Token: 0x060019AF RID: 6575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000289")]
		[DebuggerNonUserCode]
		public int Wounded
		{
			[Token(Token = "0x60019AE")]
			[Address(RVA = "0x20DF710", Offset = "0x20DF710", VA = "0x20DF710")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60019AF")]
			[Address(RVA = "0x20DF718", Offset = "0x20DF718", VA = "0x20DF718")]
			set
			{
			}
		}

		// Token: 0x1700028A RID: 650
		// (get) Token: 0x060019B0 RID: 6576 RVA: 0x00009D38 File Offset: 0x00007F38
		// (set) Token: 0x060019B1 RID: 6577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700028A")]
		[DebuggerNonUserCode]
		public int Injured
		{
			[Token(Token = "0x60019B0")]
			[Address(RVA = "0x20DF720", Offset = "0x20DF720", VA = "0x20DF720")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60019B1")]
			[Address(RVA = "0x20DF728", Offset = "0x20DF728", VA = "0x20DF728")]
			set
			{
			}
		}

		// Token: 0x1700028B RID: 651
		// (get) Token: 0x060019B2 RID: 6578 RVA: 0x00009D50 File Offset: 0x00007F50
		// (set) Token: 0x060019B3 RID: 6579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700028B")]
		[DebuggerNonUserCode]
		public int Dead
		{
			[Token(Token = "0x60019B2")]
			[Address(RVA = "0x20DF730", Offset = "0x20DF730", VA = "0x20DF730")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60019B3")]
			[Address(RVA = "0x20DF738", Offset = "0x20DF738", VA = "0x20DF738")]
			set
			{
			}
		}

		// Token: 0x1700028C RID: 652
		// (get) Token: 0x060019B4 RID: 6580 RVA: 0x00009D68 File Offset: 0x00007F68
		// (set) Token: 0x060019B5 RID: 6581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700028C")]
		[DebuggerNonUserCode]
		public int Cure
		{
			[Token(Token = "0x60019B4")]
			[Address(RVA = "0x20DF740", Offset = "0x20DF740", VA = "0x20DF740")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60019B5")]
			[Address(RVA = "0x20DF748", Offset = "0x20DF748", VA = "0x20DF748")]
			set
			{
			}
		}

		// Token: 0x060019B6 RID: 6582 RVA: 0x00009D80 File Offset: 0x00007F80
		[Token(Token = "0x60019B6")]
		[Address(RVA = "0x20DF750", Offset = "0x20DF750", VA = "0x20DF750", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x060019B7 RID: 6583 RVA: 0x00009D98 File Offset: 0x00007F98
		[Token(Token = "0x60019B7")]
		[Address(RVA = "0x20DF7B4", Offset = "0x20DF7B4", VA = "0x20DF7B4", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(SoldierProto other)
		{
			return default(bool);
		}

		// Token: 0x060019B8 RID: 6584 RVA: 0x00009DB0 File Offset: 0x00007FB0
		[Token(Token = "0x60019B8")]
		[Address(RVA = "0x20DF884", Offset = "0x20DF884", VA = "0x20DF884", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060019B9 RID: 6585 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019B9")]
		[Address(RVA = "0x20DF9AC", Offset = "0x20DF9AC", VA = "0x20DF9AC", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060019BA RID: 6586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019BA")]
		[Address(RVA = "0x20DFA04", Offset = "0x20DFA04", VA = "0x20DFA04", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060019BB RID: 6587 RVA: 0x00009DC8 File Offset: 0x00007FC8
		[Token(Token = "0x60019BB")]
		[Address(RVA = "0x20DFBA8", Offset = "0x20DFBA8", VA = "0x20DFBA8", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060019BC RID: 6588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019BC")]
		[Address(RVA = "0x20DFD78", Offset = "0x20DFD78", VA = "0x20DFD78", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(SoldierProto other)
		{
		}

		// Token: 0x060019BD RID: 6589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019BD")]
		[Address(RVA = "0x20DFE30", Offset = "0x20DFE30", VA = "0x20DFE30", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x04001BB7 RID: 7095
		[Token(Token = "0x4001BB7")]
		[FieldOffset(Offset = "0x0")]
		private static readonly MessageParser<SoldierProto> _parser;

		// Token: 0x04001BB8 RID: 7096
		[Token(Token = "0x4001BB8")]
		[FieldOffset(Offset = "0x10")]
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001BB9 RID: 7097
		[Token(Token = "0x4001BB9")]
		public const int ArmsIdFieldNumber = 1;

		// Token: 0x04001BBA RID: 7098
		[Token(Token = "0x4001BBA")]
		[FieldOffset(Offset = "0x18")]
		private string armsId_;

		// Token: 0x04001BBB RID: 7099
		[Token(Token = "0x4001BBB")]
		public const int TypeFieldNumber = 2;

		// Token: 0x04001BBC RID: 7100
		[Token(Token = "0x4001BBC")]
		[FieldOffset(Offset = "0x20")]
		private int type_;

		// Token: 0x04001BBD RID: 7101
		[Token(Token = "0x4001BBD")]
		public const int TotalFieldNumber = 3;

		// Token: 0x04001BBE RID: 7102
		[Token(Token = "0x4001BBE")]
		[FieldOffset(Offset = "0x24")]
		private int total_;

		// Token: 0x04001BBF RID: 7103
		[Token(Token = "0x4001BBF")]
		public const int LostFieldNumber = 4;

		// Token: 0x04001BC0 RID: 7104
		[Token(Token = "0x4001BC0")]
		[FieldOffset(Offset = "0x28")]
		private int lost_;

		// Token: 0x04001BC1 RID: 7105
		[Token(Token = "0x4001BC1")]
		public const int WoundedFieldNumber = 5;

		// Token: 0x04001BC2 RID: 7106
		[Token(Token = "0x4001BC2")]
		[FieldOffset(Offset = "0x2C")]
		private int wounded_;

		// Token: 0x04001BC3 RID: 7107
		[Token(Token = "0x4001BC3")]
		public const int InjuredFieldNumber = 6;

		// Token: 0x04001BC4 RID: 7108
		[Token(Token = "0x4001BC4")]
		[FieldOffset(Offset = "0x30")]
		private int injured_;

		// Token: 0x04001BC5 RID: 7109
		[Token(Token = "0x4001BC5")]
		public const int DeadFieldNumber = 7;

		// Token: 0x04001BC6 RID: 7110
		[Token(Token = "0x4001BC6")]
		[FieldOffset(Offset = "0x34")]
		private int dead_;

		// Token: 0x04001BC7 RID: 7111
		[Token(Token = "0x4001BC7")]
		public const int CureFieldNumber = 8;

		// Token: 0x04001BC8 RID: 7112
		[Token(Token = "0x4001BC8")]
		[FieldOffset(Offset = "0x38")]
		private int cure_;
	}
}
