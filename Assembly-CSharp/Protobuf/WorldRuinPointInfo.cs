using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Protobuf
{
	// Token: 0x0200048B RID: 1163
	[Token(Token = "0x200048B")]
	public sealed class WorldRuinPointInfo : IMessage<WorldRuinPointInfo>, IMessage, IEquatable<WorldRuinPointInfo>, IDeepCloneable<WorldRuinPointInfo>
	{
		// Token: 0x170004E1 RID: 1249
		// (get) Token: 0x060021C8 RID: 8648 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004E1")]
		[DebuggerNonUserCode]
		public static MessageParser<WorldRuinPointInfo> Parser
		{
			[Token(Token = "0x60021C8")]
			[Address(RVA = "0x2894308", Offset = "0x2894308", VA = "0x2894308")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004E2 RID: 1250
		// (get) Token: 0x060021C9 RID: 8649 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004E2")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Token(Token = "0x60021C9")]
			[Address(RVA = "0x2894360", Offset = "0x2894360", VA = "0x2894360")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004E3 RID: 1251
		// (get) Token: 0x060021CA RID: 8650 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004E3")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Token(Token = "0x60021CA")]
			[Address(RVA = "0x2894464", Offset = "0x2894464", VA = "0x2894464", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x060021CB RID: 8651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021CB")]
		[Address(RVA = "0x28944B0", Offset = "0x28944B0", VA = "0x28944B0")]
		[DebuggerNonUserCode]
		public WorldRuinPointInfo()
		{
		}

		// Token: 0x060021CC RID: 8652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021CC")]
		[Address(RVA = "0x2894508", Offset = "0x2894508", VA = "0x2894508")]
		[DebuggerNonUserCode]
		public WorldRuinPointInfo(WorldRuinPointInfo other)
		{
		}

		// Token: 0x060021CD RID: 8653 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021CD")]
		[Address(RVA = "0x2894570", Offset = "0x2894570", VA = "0x2894570", Slot = "10")]
		[DebuggerNonUserCode]
		public WorldRuinPointInfo Clone()
		{
			return null;
		}

		// Token: 0x170004E4 RID: 1252
		// (get) Token: 0x060021CE RID: 8654 RVA: 0x0000CF00 File Offset: 0x0000B100
		// (set) Token: 0x060021CF RID: 8655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004E4")]
		[DebuggerNonUserCode]
		public long Uuid
		{
			[Token(Token = "0x60021CE")]
			[Address(RVA = "0x28945D0", Offset = "0x28945D0", VA = "0x28945D0")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x60021CF")]
			[Address(RVA = "0x28945D8", Offset = "0x28945D8", VA = "0x28945D8")]
			set
			{
			}
		}

		// Token: 0x170004E5 RID: 1253
		// (get) Token: 0x060021D0 RID: 8656 RVA: 0x0000CF18 File Offset: 0x0000B118
		// (set) Token: 0x060021D1 RID: 8657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004E5")]
		[DebuggerNonUserCode]
		public int Size
		{
			[Token(Token = "0x60021D0")]
			[Address(RVA = "0x28945E0", Offset = "0x28945E0", VA = "0x28945E0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60021D1")]
			[Address(RVA = "0x28945E8", Offset = "0x28945E8", VA = "0x28945E8")]
			set
			{
			}
		}

		// Token: 0x170004E6 RID: 1254
		// (get) Token: 0x060021D2 RID: 8658 RVA: 0x0000CF30 File Offset: 0x0000B130
		// (set) Token: 0x060021D3 RID: 8659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004E6")]
		[DebuggerNonUserCode]
		public int Type
		{
			[Token(Token = "0x60021D2")]
			[Address(RVA = "0x28945F0", Offset = "0x28945F0", VA = "0x28945F0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60021D3")]
			[Address(RVA = "0x28945F8", Offset = "0x28945F8", VA = "0x28945F8")]
			set
			{
			}
		}

		// Token: 0x170004E7 RID: 1255
		// (get) Token: 0x060021D4 RID: 8660 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060021D5 RID: 8661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004E7")]
		[DebuggerNonUserCode]
		public string Param
		{
			[Token(Token = "0x60021D4")]
			[Address(RVA = "0x2894600", Offset = "0x2894600", VA = "0x2894600")]
			get
			{
				return null;
			}
			[Token(Token = "0x60021D5")]
			[Address(RVA = "0x2894608", Offset = "0x2894608", VA = "0x2894608")]
			set
			{
			}
		}

		// Token: 0x170004E8 RID: 1256
		// (get) Token: 0x060021D6 RID: 8662 RVA: 0x0000CF48 File Offset: 0x0000B148
		// (set) Token: 0x060021D7 RID: 8663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004E8")]
		[DebuggerNonUserCode]
		public int StartTime
		{
			[Token(Token = "0x60021D6")]
			[Address(RVA = "0x2894684", Offset = "0x2894684", VA = "0x2894684")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60021D7")]
			[Address(RVA = "0x289468C", Offset = "0x289468C", VA = "0x289468C")]
			set
			{
			}
		}

		// Token: 0x170004E9 RID: 1257
		// (get) Token: 0x060021D8 RID: 8664 RVA: 0x0000CF60 File Offset: 0x0000B160
		// (set) Token: 0x060021D9 RID: 8665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004E9")]
		[DebuggerNonUserCode]
		public int EndTime
		{
			[Token(Token = "0x60021D8")]
			[Address(RVA = "0x2894694", Offset = "0x2894694", VA = "0x2894694")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60021D9")]
			[Address(RVA = "0x289469C", Offset = "0x289469C", VA = "0x289469C")]
			set
			{
			}
		}

		// Token: 0x060021DA RID: 8666 RVA: 0x0000CF78 File Offset: 0x0000B178
		[Token(Token = "0x60021DA")]
		[Address(RVA = "0x28946A4", Offset = "0x28946A4", VA = "0x28946A4", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x060021DB RID: 8667 RVA: 0x0000CF90 File Offset: 0x0000B190
		[Token(Token = "0x60021DB")]
		[Address(RVA = "0x2894708", Offset = "0x2894708", VA = "0x2894708", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(WorldRuinPointInfo other)
		{
			return default(bool);
		}

		// Token: 0x060021DC RID: 8668 RVA: 0x0000CFA8 File Offset: 0x0000B1A8
		[Token(Token = "0x60021DC")]
		[Address(RVA = "0x28947B8", Offset = "0x28947B8", VA = "0x28947B8", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060021DD RID: 8669 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021DD")]
		[Address(RVA = "0x28948B0", Offset = "0x28948B0", VA = "0x28948B0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060021DE RID: 8670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021DE")]
		[Address(RVA = "0x2894908", Offset = "0x2894908", VA = "0x2894908", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060021DF RID: 8671 RVA: 0x0000CFC0 File Offset: 0x0000B1C0
		[Token(Token = "0x60021DF")]
		[Address(RVA = "0x2894A54", Offset = "0x2894A54", VA = "0x2894A54", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060021E0 RID: 8672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021E0")]
		[Address(RVA = "0x2894BC4", Offset = "0x2894BC4", VA = "0x2894BC4", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(WorldRuinPointInfo other)
		{
		}

		// Token: 0x060021E1 RID: 8673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021E1")]
		[Address(RVA = "0x2894C64", Offset = "0x2894C64", VA = "0x2894C64", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x04001FBC RID: 8124
		[Token(Token = "0x4001FBC")]
		[FieldOffset(Offset = "0x0")]
		private static readonly MessageParser<WorldRuinPointInfo> _parser;

		// Token: 0x04001FBD RID: 8125
		[Token(Token = "0x4001FBD")]
		[FieldOffset(Offset = "0x10")]
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001FBE RID: 8126
		[Token(Token = "0x4001FBE")]
		public const int UuidFieldNumber = 1;

		// Token: 0x04001FBF RID: 8127
		[Token(Token = "0x4001FBF")]
		[FieldOffset(Offset = "0x18")]
		private long uuid_;

		// Token: 0x04001FC0 RID: 8128
		[Token(Token = "0x4001FC0")]
		public const int SizeFieldNumber = 2;

		// Token: 0x04001FC1 RID: 8129
		[Token(Token = "0x4001FC1")]
		[FieldOffset(Offset = "0x20")]
		private int size_;

		// Token: 0x04001FC2 RID: 8130
		[Token(Token = "0x4001FC2")]
		public const int TypeFieldNumber = 3;

		// Token: 0x04001FC3 RID: 8131
		[Token(Token = "0x4001FC3")]
		[FieldOffset(Offset = "0x24")]
		private int type_;

		// Token: 0x04001FC4 RID: 8132
		[Token(Token = "0x4001FC4")]
		public const int ParamFieldNumber = 4;

		// Token: 0x04001FC5 RID: 8133
		[Token(Token = "0x4001FC5")]
		[FieldOffset(Offset = "0x28")]
		private string param_;

		// Token: 0x04001FC6 RID: 8134
		[Token(Token = "0x4001FC6")]
		public const int StartTimeFieldNumber = 5;

		// Token: 0x04001FC7 RID: 8135
		[Token(Token = "0x4001FC7")]
		[FieldOffset(Offset = "0x30")]
		private int startTime_;

		// Token: 0x04001FC8 RID: 8136
		[Token(Token = "0x4001FC8")]
		public const int EndTimeFieldNumber = 6;

		// Token: 0x04001FC9 RID: 8137
		[Token(Token = "0x4001FC9")]
		[FieldOffset(Offset = "0x34")]
		private int endTime_;
	}
}
