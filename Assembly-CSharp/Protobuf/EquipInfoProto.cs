using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Protobuf
{
	// Token: 0x020003F3 RID: 1011
	[Token(Token = "0x20003F3")]
	public sealed class EquipInfoProto : IMessage<EquipInfoProto>, IMessage, IEquatable<EquipInfoProto>, IDeepCloneable<EquipInfoProto>
	{
		// Token: 0x1700029E RID: 670
		// (get) Token: 0x060019FB RID: 6651 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700029E")]
		[DebuggerNonUserCode]
		public static MessageParser<EquipInfoProto> Parser
		{
			[Token(Token = "0x60019FB")]
			[Address(RVA = "0x20E19F0", Offset = "0x20E19F0", VA = "0x20E19F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700029F RID: 671
		// (get) Token: 0x060019FC RID: 6652 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700029F")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Token(Token = "0x60019FC")]
			[Address(RVA = "0x20E1A48", Offset = "0x20E1A48", VA = "0x20E1A48")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002A0 RID: 672
		// (get) Token: 0x060019FD RID: 6653 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002A0")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Token(Token = "0x60019FD")]
			[Address(RVA = "0x20E1B4C", Offset = "0x20E1B4C", VA = "0x20E1B4C", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x060019FE RID: 6654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019FE")]
		[Address(RVA = "0x20E1B98", Offset = "0x20E1B98", VA = "0x20E1B98")]
		[DebuggerNonUserCode]
		public EquipInfoProto()
		{
		}

		// Token: 0x060019FF RID: 6655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019FF")]
		[Address(RVA = "0x20E1BA0", Offset = "0x20E1BA0", VA = "0x20E1BA0")]
		[DebuggerNonUserCode]
		public EquipInfoProto(EquipInfoProto other)
		{
		}

		// Token: 0x06001A00 RID: 6656 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A00")]
		[Address(RVA = "0x20E1BEC", Offset = "0x20E1BEC", VA = "0x20E1BEC", Slot = "10")]
		[DebuggerNonUserCode]
		public EquipInfoProto Clone()
		{
			return null;
		}

		// Token: 0x170002A1 RID: 673
		// (get) Token: 0x06001A01 RID: 6657 RVA: 0x00009F90 File Offset: 0x00008190
		// (set) Token: 0x06001A02 RID: 6658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170002A1")]
		[DebuggerNonUserCode]
		public int EquipId
		{
			[Token(Token = "0x6001A01")]
			[Address(RVA = "0x20E1C4C", Offset = "0x20E1C4C", VA = "0x20E1C4C")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001A02")]
			[Address(RVA = "0x20E1C54", Offset = "0x20E1C54", VA = "0x20E1C54")]
			set
			{
			}
		}

		// Token: 0x170002A2 RID: 674
		// (get) Token: 0x06001A03 RID: 6659 RVA: 0x00009FA8 File Offset: 0x000081A8
		// (set) Token: 0x06001A04 RID: 6660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170002A2")]
		[DebuggerNonUserCode]
		public int Lv
		{
			[Token(Token = "0x6001A03")]
			[Address(RVA = "0x20E1C5C", Offset = "0x20E1C5C", VA = "0x20E1C5C")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001A04")]
			[Address(RVA = "0x20E1C64", Offset = "0x20E1C64", VA = "0x20E1C64")]
			set
			{
			}
		}

		// Token: 0x06001A05 RID: 6661 RVA: 0x00009FC0 File Offset: 0x000081C0
		[Token(Token = "0x6001A05")]
		[Address(RVA = "0x20E1C6C", Offset = "0x20E1C6C", VA = "0x20E1C6C", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06001A06 RID: 6662 RVA: 0x00009FD8 File Offset: 0x000081D8
		[Token(Token = "0x6001A06")]
		[Address(RVA = "0x20E1CD0", Offset = "0x20E1CD0", VA = "0x20E1CD0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(EquipInfoProto other)
		{
			return default(bool);
		}

		// Token: 0x06001A07 RID: 6663 RVA: 0x00009FF0 File Offset: 0x000081F0
		[Token(Token = "0x6001A07")]
		[Address(RVA = "0x20E1D1C", Offset = "0x20E1D1C", VA = "0x20E1D1C", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001A08 RID: 6664 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A08")]
		[Address(RVA = "0x20E1D94", Offset = "0x20E1D94", VA = "0x20E1D94", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001A09 RID: 6665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A09")]
		[Address(RVA = "0x20E1DEC", Offset = "0x20E1DEC", VA = "0x20E1DEC", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06001A0A RID: 6666 RVA: 0x0000A008 File Offset: 0x00008208
		[Token(Token = "0x6001A0A")]
		[Address(RVA = "0x20E1E80", Offset = "0x20E1E80", VA = "0x20E1E80", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06001A0B RID: 6667 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A0B")]
		[Address(RVA = "0x20E1F34", Offset = "0x20E1F34", VA = "0x20E1F34", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(EquipInfoProto other)
		{
		}

		// Token: 0x06001A0C RID: 6668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A0C")]
		[Address(RVA = "0x20E1F80", Offset = "0x20E1F80", VA = "0x20E1F80", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x04001BE7 RID: 7143
		[Token(Token = "0x4001BE7")]
		[FieldOffset(Offset = "0x0")]
		private static readonly MessageParser<EquipInfoProto> _parser;

		// Token: 0x04001BE8 RID: 7144
		[Token(Token = "0x4001BE8")]
		[FieldOffset(Offset = "0x10")]
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001BE9 RID: 7145
		[Token(Token = "0x4001BE9")]
		public const int EquipIdFieldNumber = 1;

		// Token: 0x04001BEA RID: 7146
		[Token(Token = "0x4001BEA")]
		[FieldOffset(Offset = "0x18")]
		private int equipId_;

		// Token: 0x04001BEB RID: 7147
		[Token(Token = "0x4001BEB")]
		public const int LvFieldNumber = 2;

		// Token: 0x04001BEC RID: 7148
		[Token(Token = "0x4001BEC")]
		[FieldOffset(Offset = "0x1C")]
		private int lv_;
	}
}
