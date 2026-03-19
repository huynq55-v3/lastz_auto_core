using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Protobuf
{
	// Token: 0x020003EF RID: 1007
	[Token(Token = "0x20003EF")]
	public sealed class HeroSkillInfoProto : IMessage<HeroSkillInfoProto>, IMessage, IEquatable<HeroSkillInfoProto>, IDeepCloneable<HeroSkillInfoProto>
	{
		// Token: 0x1700028D RID: 653
		// (get) Token: 0x060019C2 RID: 6594 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700028D")]
		[DebuggerNonUserCode]
		public static MessageParser<HeroSkillInfoProto> Parser
		{
			[Token(Token = "0x60019C2")]
			[Address(RVA = "0x20E017C", Offset = "0x20E017C", VA = "0x20E017C")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700028E RID: 654
		// (get) Token: 0x060019C3 RID: 6595 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700028E")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Token(Token = "0x60019C3")]
			[Address(RVA = "0x20E01D4", Offset = "0x20E01D4", VA = "0x20E01D4")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700028F RID: 655
		// (get) Token: 0x060019C4 RID: 6596 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700028F")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Token(Token = "0x60019C4")]
			[Address(RVA = "0x20E02D8", Offset = "0x20E02D8", VA = "0x20E02D8", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x060019C5 RID: 6597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019C5")]
		[Address(RVA = "0x20E0324", Offset = "0x20E0324", VA = "0x20E0324")]
		[DebuggerNonUserCode]
		public HeroSkillInfoProto()
		{
		}

		// Token: 0x060019C6 RID: 6598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019C6")]
		[Address(RVA = "0x20E032C", Offset = "0x20E032C", VA = "0x20E032C")]
		[DebuggerNonUserCode]
		public HeroSkillInfoProto(HeroSkillInfoProto other)
		{
		}

		// Token: 0x060019C7 RID: 6599 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019C7")]
		[Address(RVA = "0x20E0378", Offset = "0x20E0378", VA = "0x20E0378", Slot = "10")]
		[DebuggerNonUserCode]
		public HeroSkillInfoProto Clone()
		{
			return null;
		}

		// Token: 0x17000290 RID: 656
		// (get) Token: 0x060019C8 RID: 6600 RVA: 0x00009DE0 File Offset: 0x00007FE0
		// (set) Token: 0x060019C9 RID: 6601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000290")]
		[DebuggerNonUserCode]
		public int SkillId
		{
			[Token(Token = "0x60019C8")]
			[Address(RVA = "0x20E03D8", Offset = "0x20E03D8", VA = "0x20E03D8")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60019C9")]
			[Address(RVA = "0x20E03E0", Offset = "0x20E03E0", VA = "0x20E03E0")]
			set
			{
			}
		}

		// Token: 0x17000291 RID: 657
		// (get) Token: 0x060019CA RID: 6602 RVA: 0x00009DF8 File Offset: 0x00007FF8
		// (set) Token: 0x060019CB RID: 6603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000291")]
		[DebuggerNonUserCode]
		public int SkillLv
		{
			[Token(Token = "0x60019CA")]
			[Address(RVA = "0x20E03E8", Offset = "0x20E03E8", VA = "0x20E03E8")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60019CB")]
			[Address(RVA = "0x20E03F0", Offset = "0x20E03F0", VA = "0x20E03F0")]
			set
			{
			}
		}

		// Token: 0x060019CC RID: 6604 RVA: 0x00009E10 File Offset: 0x00008010
		[Token(Token = "0x60019CC")]
		[Address(RVA = "0x20E03F8", Offset = "0x20E03F8", VA = "0x20E03F8", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x060019CD RID: 6605 RVA: 0x00009E28 File Offset: 0x00008028
		[Token(Token = "0x60019CD")]
		[Address(RVA = "0x20E045C", Offset = "0x20E045C", VA = "0x20E045C", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(HeroSkillInfoProto other)
		{
			return default(bool);
		}

		// Token: 0x060019CE RID: 6606 RVA: 0x00009E40 File Offset: 0x00008040
		[Token(Token = "0x60019CE")]
		[Address(RVA = "0x20E04A8", Offset = "0x20E04A8", VA = "0x20E04A8", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060019CF RID: 6607 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019CF")]
		[Address(RVA = "0x20E0520", Offset = "0x20E0520", VA = "0x20E0520", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060019D0 RID: 6608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019D0")]
		[Address(RVA = "0x20E0578", Offset = "0x20E0578", VA = "0x20E0578", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060019D1 RID: 6609 RVA: 0x00009E58 File Offset: 0x00008058
		[Token(Token = "0x60019D1")]
		[Address(RVA = "0x20E060C", Offset = "0x20E060C", VA = "0x20E060C", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060019D2 RID: 6610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019D2")]
		[Address(RVA = "0x20E06C0", Offset = "0x20E06C0", VA = "0x20E06C0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(HeroSkillInfoProto other)
		{
		}

		// Token: 0x060019D3 RID: 6611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019D3")]
		[Address(RVA = "0x20E070C", Offset = "0x20E070C", VA = "0x20E070C", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x04001BCA RID: 7114
		[Token(Token = "0x4001BCA")]
		[FieldOffset(Offset = "0x0")]
		private static readonly MessageParser<HeroSkillInfoProto> _parser;

		// Token: 0x04001BCB RID: 7115
		[Token(Token = "0x4001BCB")]
		[FieldOffset(Offset = "0x10")]
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001BCC RID: 7116
		[Token(Token = "0x4001BCC")]
		public const int SkillIdFieldNumber = 1;

		// Token: 0x04001BCD RID: 7117
		[Token(Token = "0x4001BCD")]
		[FieldOffset(Offset = "0x18")]
		private int skillId_;

		// Token: 0x04001BCE RID: 7118
		[Token(Token = "0x4001BCE")]
		public const int SkillLvFieldNumber = 2;

		// Token: 0x04001BCF RID: 7119
		[Token(Token = "0x4001BCF")]
		[FieldOffset(Offset = "0x1C")]
		private int skillLv_;
	}
}
