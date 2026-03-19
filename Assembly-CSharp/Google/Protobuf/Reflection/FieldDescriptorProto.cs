using System;
using System.Diagnostics;
using Il2CppDummyDll;

namespace Google.Protobuf.Reflection
{
	// Token: 0x02000B87 RID: 2951
	[Token(Token = "0x2000B87")]
	public sealed class FieldDescriptorProto : IMessage<FieldDescriptorProto>, IMessage, IEquatable<FieldDescriptorProto>, IDeepCloneable<FieldDescriptorProto>
	{
		// Token: 0x170008C5 RID: 2245
		// (get) Token: 0x060070A2 RID: 28834 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008C5")]
		[DebuggerNonUserCode]
		public static MessageParser<FieldDescriptorProto> Parser
		{
			[Token(Token = "0x60070A2")]
			[Address(RVA = "0x31F36F8", Offset = "0x31F36F8", VA = "0x31F36F8")]
			get
			{
				return null;
			}
		}

		// Token: 0x170008C6 RID: 2246
		// (get) Token: 0x060070A3 RID: 28835 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008C6")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Token(Token = "0x60070A3")]
			[Address(RVA = "0x31F3750", Offset = "0x31F3750", VA = "0x31F3750")]
			get
			{
				return null;
			}
		}

		// Token: 0x170008C7 RID: 2247
		// (get) Token: 0x060070A4 RID: 28836 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008C7")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Token(Token = "0x60070A4")]
			[Address(RVA = "0x31F3854", Offset = "0x31F3854", VA = "0x31F3854", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x060070A5 RID: 28837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60070A5")]
		[Address(RVA = "0x31F38A0", Offset = "0x31F38A0", VA = "0x31F38A0")]
		[DebuggerNonUserCode]
		public FieldDescriptorProto()
		{
		}

		// Token: 0x060070A6 RID: 28838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60070A6")]
		[Address(RVA = "0x31F38A8", Offset = "0x31F38A8", VA = "0x31F38A8")]
		[DebuggerNonUserCode]
		public FieldDescriptorProto(FieldDescriptorProto other)
		{
		}

		// Token: 0x060070A7 RID: 28839 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60070A7")]
		[Address(RVA = "0x31F39F0", Offset = "0x31F39F0", VA = "0x31F39F0", Slot = "10")]
		[DebuggerNonUserCode]
		public FieldDescriptorProto Clone()
		{
			return null;
		}

		// Token: 0x170008C8 RID: 2248
		// (get) Token: 0x060070A8 RID: 28840 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060070A9 RID: 28841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170008C8")]
		[DebuggerNonUserCode]
		public string Name
		{
			[Token(Token = "0x60070A8")]
			[Address(RVA = "0x31F3A50", Offset = "0x31F3A50", VA = "0x31F3A50")]
			get
			{
				return null;
			}
			[Token(Token = "0x60070A9")]
			[Address(RVA = "0x31F3AB4", Offset = "0x31F3AB4", VA = "0x31F3AB4")]
			set
			{
			}
		}

		// Token: 0x170008C9 RID: 2249
		// (get) Token: 0x060070AA RID: 28842 RVA: 0x00050040 File Offset: 0x0004E240
		[Token(Token = "0x170008C9")]
		[DebuggerNonUserCode]
		public bool HasName
		{
			[Token(Token = "0x60070AA")]
			[Address(RVA = "0x31F3B30", Offset = "0x31F3B30", VA = "0x31F3B30")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060070AB RID: 28843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60070AB")]
		[Address(RVA = "0x31F3B40", Offset = "0x31F3B40", VA = "0x31F3B40")]
		[DebuggerNonUserCode]
		public void ClearName()
		{
		}

		// Token: 0x170008CA RID: 2250
		// (get) Token: 0x060070AC RID: 28844 RVA: 0x00050058 File Offset: 0x0004E258
		// (set) Token: 0x060070AD RID: 28845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170008CA")]
		[DebuggerNonUserCode]
		public int Number
		{
			[Token(Token = "0x60070AC")]
			[Address(RVA = "0x31F3B4C", Offset = "0x31F3B4C", VA = "0x31F3B4C")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60070AD")]
			[Address(RVA = "0x31F3BBC", Offset = "0x31F3BBC", VA = "0x31F3BBC")]
			set
			{
			}
		}

		// Token: 0x170008CB RID: 2251
		// (get) Token: 0x060070AE RID: 28846 RVA: 0x00050070 File Offset: 0x0004E270
		[Token(Token = "0x170008CB")]
		[DebuggerNonUserCode]
		public bool HasNumber
		{
			[Token(Token = "0x60070AE")]
			[Address(RVA = "0x31F3BD0", Offset = "0x31F3BD0", VA = "0x31F3BD0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060070AF RID: 28847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60070AF")]
		[Address(RVA = "0x31F3BDC", Offset = "0x31F3BDC", VA = "0x31F3BDC")]
		[DebuggerNonUserCode]
		public void ClearNumber()
		{
		}

		// Token: 0x170008CC RID: 2252
		// (get) Token: 0x060070B0 RID: 28848 RVA: 0x00050088 File Offset: 0x0004E288
		// (set) Token: 0x060070B1 RID: 28849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170008CC")]
		[DebuggerNonUserCode]
		public FieldDescriptorProto.Types.Label Label
		{
			[Token(Token = "0x60070B0")]
			[Address(RVA = "0x31F3BEC", Offset = "0x31F3BEC", VA = "0x31F3BEC")]
			get
			{
				return (FieldDescriptorProto.Types.Label)0;
			}
			[Token(Token = "0x60070B1")]
			[Address(RVA = "0x31F3C5C", Offset = "0x31F3C5C", VA = "0x31F3C5C")]
			set
			{
			}
		}

		// Token: 0x170008CD RID: 2253
		// (get) Token: 0x060070B2 RID: 28850 RVA: 0x000500A0 File Offset: 0x0004E2A0
		[Token(Token = "0x170008CD")]
		[DebuggerNonUserCode]
		public bool HasLabel
		{
			[Token(Token = "0x60070B2")]
			[Address(RVA = "0x31F3C70", Offset = "0x31F3C70", VA = "0x31F3C70")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060070B3 RID: 28851 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60070B3")]
		[Address(RVA = "0x31F3C7C", Offset = "0x31F3C7C", VA = "0x31F3C7C")]
		[DebuggerNonUserCode]
		public void ClearLabel()
		{
		}

		// Token: 0x170008CE RID: 2254
		// (get) Token: 0x060070B4 RID: 28852 RVA: 0x000500B8 File Offset: 0x0004E2B8
		// (set) Token: 0x060070B5 RID: 28853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170008CE")]
		[DebuggerNonUserCode]
		public FieldDescriptorProto.Types.Type Type
		{
			[Token(Token = "0x60070B4")]
			[Address(RVA = "0x31F3C8C", Offset = "0x31F3C8C", VA = "0x31F3C8C")]
			get
			{
				return (FieldDescriptorProto.Types.Type)0;
			}
			[Token(Token = "0x60070B5")]
			[Address(RVA = "0x31F3CFC", Offset = "0x31F3CFC", VA = "0x31F3CFC")]
			set
			{
			}
		}

		// Token: 0x170008CF RID: 2255
		// (get) Token: 0x060070B6 RID: 28854 RVA: 0x000500D0 File Offset: 0x0004E2D0
		[Token(Token = "0x170008CF")]
		[DebuggerNonUserCode]
		public bool HasType
		{
			[Token(Token = "0x60070B6")]
			[Address(RVA = "0x31F3D10", Offset = "0x31F3D10", VA = "0x31F3D10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060070B7 RID: 28855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60070B7")]
		[Address(RVA = "0x31F3D1C", Offset = "0x31F3D1C", VA = "0x31F3D1C")]
		[DebuggerNonUserCode]
		public void ClearType()
		{
		}

		// Token: 0x170008D0 RID: 2256
		// (get) Token: 0x060070B8 RID: 28856 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060070B9 RID: 28857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170008D0")]
		[DebuggerNonUserCode]
		public string TypeName
		{
			[Token(Token = "0x60070B8")]
			[Address(RVA = "0x31F3D2C", Offset = "0x31F3D2C", VA = "0x31F3D2C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60070B9")]
			[Address(RVA = "0x31F3D90", Offset = "0x31F3D90", VA = "0x31F3D90")]
			set
			{
			}
		}

		// Token: 0x170008D1 RID: 2257
		// (get) Token: 0x060070BA RID: 28858 RVA: 0x000500E8 File Offset: 0x0004E2E8
		[Token(Token = "0x170008D1")]
		[DebuggerNonUserCode]
		public bool HasTypeName
		{
			[Token(Token = "0x60070BA")]
			[Address(RVA = "0x31F3E0C", Offset = "0x31F3E0C", VA = "0x31F3E0C")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060070BB RID: 28859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60070BB")]
		[Address(RVA = "0x31F3E1C", Offset = "0x31F3E1C", VA = "0x31F3E1C")]
		[DebuggerNonUserCode]
		public void ClearTypeName()
		{
		}

		// Token: 0x170008D2 RID: 2258
		// (get) Token: 0x060070BC RID: 28860 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060070BD RID: 28861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170008D2")]
		[DebuggerNonUserCode]
		public string Extendee
		{
			[Token(Token = "0x60070BC")]
			[Address(RVA = "0x31F3E28", Offset = "0x31F3E28", VA = "0x31F3E28")]
			get
			{
				return null;
			}
			[Token(Token = "0x60070BD")]
			[Address(RVA = "0x31F3E8C", Offset = "0x31F3E8C", VA = "0x31F3E8C")]
			set
			{
			}
		}

		// Token: 0x170008D3 RID: 2259
		// (get) Token: 0x060070BE RID: 28862 RVA: 0x00050100 File Offset: 0x0004E300
		[Token(Token = "0x170008D3")]
		[DebuggerNonUserCode]
		public bool HasExtendee
		{
			[Token(Token = "0x60070BE")]
			[Address(RVA = "0x31F3F08", Offset = "0x31F3F08", VA = "0x31F3F08")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060070BF RID: 28863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60070BF")]
		[Address(RVA = "0x31F3F18", Offset = "0x31F3F18", VA = "0x31F3F18")]
		[DebuggerNonUserCode]
		public void ClearExtendee()
		{
		}

		// Token: 0x170008D4 RID: 2260
		// (get) Token: 0x060070C0 RID: 28864 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060070C1 RID: 28865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170008D4")]
		[DebuggerNonUserCode]
		public string DefaultValue
		{
			[Token(Token = "0x60070C0")]
			[Address(RVA = "0x31F3F24", Offset = "0x31F3F24", VA = "0x31F3F24")]
			get
			{
				return null;
			}
			[Token(Token = "0x60070C1")]
			[Address(RVA = "0x31F3F88", Offset = "0x31F3F88", VA = "0x31F3F88")]
			set
			{
			}
		}

		// Token: 0x170008D5 RID: 2261
		// (get) Token: 0x060070C2 RID: 28866 RVA: 0x00050118 File Offset: 0x0004E318
		[Token(Token = "0x170008D5")]
		[DebuggerNonUserCode]
		public bool HasDefaultValue
		{
			[Token(Token = "0x60070C2")]
			[Address(RVA = "0x31F4004", Offset = "0x31F4004", VA = "0x31F4004")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060070C3 RID: 28867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60070C3")]
		[Address(RVA = "0x31F4014", Offset = "0x31F4014", VA = "0x31F4014")]
		[DebuggerNonUserCode]
		public void ClearDefaultValue()
		{
		}

		// Token: 0x170008D6 RID: 2262
		// (get) Token: 0x060070C4 RID: 28868 RVA: 0x00050130 File Offset: 0x0004E330
		// (set) Token: 0x060070C5 RID: 28869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170008D6")]
		[DebuggerNonUserCode]
		public int OneofIndex
		{
			[Token(Token = "0x60070C4")]
			[Address(RVA = "0x31F4020", Offset = "0x31F4020", VA = "0x31F4020")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60070C5")]
			[Address(RVA = "0x31F4090", Offset = "0x31F4090", VA = "0x31F4090")]
			set
			{
			}
		}

		// Token: 0x170008D7 RID: 2263
		// (get) Token: 0x060070C6 RID: 28870 RVA: 0x00050148 File Offset: 0x0004E348
		[Token(Token = "0x170008D7")]
		[DebuggerNonUserCode]
		public bool HasOneofIndex
		{
			[Token(Token = "0x60070C6")]
			[Address(RVA = "0x31F40A4", Offset = "0x31F40A4", VA = "0x31F40A4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060070C7 RID: 28871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60070C7")]
		[Address(RVA = "0x31F40B0", Offset = "0x31F40B0", VA = "0x31F40B0")]
		[DebuggerNonUserCode]
		public void ClearOneofIndex()
		{
		}

		// Token: 0x170008D8 RID: 2264
		// (get) Token: 0x060070C8 RID: 28872 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060070C9 RID: 28873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170008D8")]
		[DebuggerNonUserCode]
		public string JsonName
		{
			[Token(Token = "0x60070C8")]
			[Address(RVA = "0x31F40C0", Offset = "0x31F40C0", VA = "0x31F40C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60070C9")]
			[Address(RVA = "0x31F4124", Offset = "0x31F4124", VA = "0x31F4124")]
			set
			{
			}
		}

		// Token: 0x170008D9 RID: 2265
		// (get) Token: 0x060070CA RID: 28874 RVA: 0x00050160 File Offset: 0x0004E360
		[Token(Token = "0x170008D9")]
		[DebuggerNonUserCode]
		public bool HasJsonName
		{
			[Token(Token = "0x60070CA")]
			[Address(RVA = "0x31F41A0", Offset = "0x31F41A0", VA = "0x31F41A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060070CB RID: 28875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60070CB")]
		[Address(RVA = "0x31F41B0", Offset = "0x31F41B0", VA = "0x31F41B0")]
		[DebuggerNonUserCode]
		public void ClearJsonName()
		{
		}

		// Token: 0x170008DA RID: 2266
		// (get) Token: 0x060070CC RID: 28876 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060070CD RID: 28877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170008DA")]
		[DebuggerNonUserCode]
		public FieldOptions Options
		{
			[Token(Token = "0x60070CC")]
			[Address(RVA = "0x31F41BC", Offset = "0x31F41BC", VA = "0x31F41BC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60070CD")]
			[Address(RVA = "0x31F41C4", Offset = "0x31F41C4", VA = "0x31F41C4")]
			set
			{
			}
		}

		// Token: 0x170008DB RID: 2267
		// (get) Token: 0x060070CE RID: 28878 RVA: 0x00050178 File Offset: 0x0004E378
		[Token(Token = "0x170008DB")]
		[DebuggerNonUserCode]
		public bool HasOptions
		{
			[Token(Token = "0x60070CE")]
			[Address(RVA = "0x31F3980", Offset = "0x31F3980", VA = "0x31F3980")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060070CF RID: 28879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60070CF")]
		[Address(RVA = "0x31F41CC", Offset = "0x31F41CC", VA = "0x31F41CC")]
		[DebuggerNonUserCode]
		public void ClearOptions()
		{
		}

		// Token: 0x060070D0 RID: 28880 RVA: 0x00050190 File Offset: 0x0004E390
		[Token(Token = "0x60070D0")]
		[Address(RVA = "0x31F41D8", Offset = "0x31F41D8", VA = "0x31F41D8", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x060070D1 RID: 28881 RVA: 0x000501A8 File Offset: 0x0004E3A8
		[Token(Token = "0x60070D1")]
		[Address(RVA = "0x31F423C", Offset = "0x31F423C", VA = "0x31F423C", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(FieldDescriptorProto other)
		{
			return default(bool);
		}

		// Token: 0x060070D2 RID: 28882 RVA: 0x000501C0 File Offset: 0x0004E3C0
		[Token(Token = "0x60070D2")]
		[Address(RVA = "0x31F43D4", Offset = "0x31F43D4", VA = "0x31F43D4", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060070D3 RID: 28883 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60070D3")]
		[Address(RVA = "0x31F4588", Offset = "0x31F4588", VA = "0x31F4588", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060070D4 RID: 28884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60070D4")]
		[Address(RVA = "0x31F45E0", Offset = "0x31F45E0", VA = "0x31F45E0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060070D5 RID: 28885 RVA: 0x000501D8 File Offset: 0x0004E3D8
		[Token(Token = "0x60070D5")]
		[Address(RVA = "0x31F481C", Offset = "0x31F481C", VA = "0x31F481C", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060070D6 RID: 28886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60070D6")]
		[Address(RVA = "0x31F4AD4", Offset = "0x31F4AD4", VA = "0x31F4AD4", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(FieldDescriptorProto other)
		{
		}

		// Token: 0x060070D7 RID: 28887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60070D7")]
		[Address(RVA = "0x31F4ECC", Offset = "0x31F4ECC", VA = "0x31F4ECC", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x04002D76 RID: 11638
		[Token(Token = "0x4002D76")]
		[FieldOffset(Offset = "0x0")]
		private static readonly MessageParser<FieldDescriptorProto> _parser;

		// Token: 0x04002D77 RID: 11639
		[Token(Token = "0x4002D77")]
		[FieldOffset(Offset = "0x10")]
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002D78 RID: 11640
		[Token(Token = "0x4002D78")]
		[FieldOffset(Offset = "0x18")]
		private int _hasBits0;

		// Token: 0x04002D79 RID: 11641
		[Token(Token = "0x4002D79")]
		public const int NameFieldNumber = 1;

		// Token: 0x04002D7A RID: 11642
		[Token(Token = "0x4002D7A")]
		[FieldOffset(Offset = "0x8")]
		private static readonly string NameDefaultValue;

		// Token: 0x04002D7B RID: 11643
		[Token(Token = "0x4002D7B")]
		[FieldOffset(Offset = "0x20")]
		private string name_;

		// Token: 0x04002D7C RID: 11644
		[Token(Token = "0x4002D7C")]
		public const int NumberFieldNumber = 3;

		// Token: 0x04002D7D RID: 11645
		[Token(Token = "0x4002D7D")]
		[FieldOffset(Offset = "0x10")]
		private static readonly int NumberDefaultValue;

		// Token: 0x04002D7E RID: 11646
		[Token(Token = "0x4002D7E")]
		[FieldOffset(Offset = "0x28")]
		private int number_;

		// Token: 0x04002D7F RID: 11647
		[Token(Token = "0x4002D7F")]
		public const int LabelFieldNumber = 4;

		// Token: 0x04002D80 RID: 11648
		[Token(Token = "0x4002D80")]
		[FieldOffset(Offset = "0x14")]
		private static readonly FieldDescriptorProto.Types.Label LabelDefaultValue;

		// Token: 0x04002D81 RID: 11649
		[Token(Token = "0x4002D81")]
		[FieldOffset(Offset = "0x2C")]
		private FieldDescriptorProto.Types.Label label_;

		// Token: 0x04002D82 RID: 11650
		[Token(Token = "0x4002D82")]
		public const int TypeFieldNumber = 5;

		// Token: 0x04002D83 RID: 11651
		[Token(Token = "0x4002D83")]
		[FieldOffset(Offset = "0x18")]
		private static readonly FieldDescriptorProto.Types.Type TypeDefaultValue;

		// Token: 0x04002D84 RID: 11652
		[Token(Token = "0x4002D84")]
		[FieldOffset(Offset = "0x30")]
		private FieldDescriptorProto.Types.Type type_;

		// Token: 0x04002D85 RID: 11653
		[Token(Token = "0x4002D85")]
		public const int TypeNameFieldNumber = 6;

		// Token: 0x04002D86 RID: 11654
		[Token(Token = "0x4002D86")]
		[FieldOffset(Offset = "0x20")]
		private static readonly string TypeNameDefaultValue;

		// Token: 0x04002D87 RID: 11655
		[Token(Token = "0x4002D87")]
		[FieldOffset(Offset = "0x38")]
		private string typeName_;

		// Token: 0x04002D88 RID: 11656
		[Token(Token = "0x4002D88")]
		public const int ExtendeeFieldNumber = 2;

		// Token: 0x04002D89 RID: 11657
		[Token(Token = "0x4002D89")]
		[FieldOffset(Offset = "0x28")]
		private static readonly string ExtendeeDefaultValue;

		// Token: 0x04002D8A RID: 11658
		[Token(Token = "0x4002D8A")]
		[FieldOffset(Offset = "0x40")]
		private string extendee_;

		// Token: 0x04002D8B RID: 11659
		[Token(Token = "0x4002D8B")]
		public const int DefaultValueFieldNumber = 7;

		// Token: 0x04002D8C RID: 11660
		[Token(Token = "0x4002D8C")]
		[FieldOffset(Offset = "0x30")]
		private static readonly string DefaultValueDefaultValue;

		// Token: 0x04002D8D RID: 11661
		[Token(Token = "0x4002D8D")]
		[FieldOffset(Offset = "0x48")]
		private string defaultValue_;

		// Token: 0x04002D8E RID: 11662
		[Token(Token = "0x4002D8E")]
		public const int OneofIndexFieldNumber = 9;

		// Token: 0x04002D8F RID: 11663
		[Token(Token = "0x4002D8F")]
		[FieldOffset(Offset = "0x38")]
		private static readonly int OneofIndexDefaultValue;

		// Token: 0x04002D90 RID: 11664
		[Token(Token = "0x4002D90")]
		[FieldOffset(Offset = "0x50")]
		private int oneofIndex_;

		// Token: 0x04002D91 RID: 11665
		[Token(Token = "0x4002D91")]
		public const int JsonNameFieldNumber = 10;

		// Token: 0x04002D92 RID: 11666
		[Token(Token = "0x4002D92")]
		[FieldOffset(Offset = "0x40")]
		private static readonly string JsonNameDefaultValue;

		// Token: 0x04002D93 RID: 11667
		[Token(Token = "0x4002D93")]
		[FieldOffset(Offset = "0x58")]
		private string jsonName_;

		// Token: 0x04002D94 RID: 11668
		[Token(Token = "0x4002D94")]
		public const int OptionsFieldNumber = 8;

		// Token: 0x04002D95 RID: 11669
		[Token(Token = "0x4002D95")]
		[FieldOffset(Offset = "0x60")]
		private FieldOptions options_;

		// Token: 0x02000B88 RID: 2952
		[Token(Token = "0x2000B88")]
		[DebuggerNonUserCode]
		public static class Types
		{
			// Token: 0x02000B89 RID: 2953
			[Token(Token = "0x2000B89")]
			public enum Type
			{
				// Token: 0x04002D97 RID: 11671
				[Token(Token = "0x4002D97")]
				[OriginalName("TYPE_DOUBLE")]
				Double = 1,
				// Token: 0x04002D98 RID: 11672
				[Token(Token = "0x4002D98")]
				[OriginalName("TYPE_FLOAT")]
				Float,
				// Token: 0x04002D99 RID: 11673
				[Token(Token = "0x4002D99")]
				[OriginalName("TYPE_INT64")]
				Int64,
				// Token: 0x04002D9A RID: 11674
				[Token(Token = "0x4002D9A")]
				[OriginalName("TYPE_UINT64")]
				Uint64,
				// Token: 0x04002D9B RID: 11675
				[Token(Token = "0x4002D9B")]
				[OriginalName("TYPE_INT32")]
				Int32,
				// Token: 0x04002D9C RID: 11676
				[Token(Token = "0x4002D9C")]
				[OriginalName("TYPE_FIXED64")]
				Fixed64,
				// Token: 0x04002D9D RID: 11677
				[Token(Token = "0x4002D9D")]
				[OriginalName("TYPE_FIXED32")]
				Fixed32,
				// Token: 0x04002D9E RID: 11678
				[Token(Token = "0x4002D9E")]
				[OriginalName("TYPE_BOOL")]
				Bool,
				// Token: 0x04002D9F RID: 11679
				[Token(Token = "0x4002D9F")]
				[OriginalName("TYPE_STRING")]
				String,
				// Token: 0x04002DA0 RID: 11680
				[Token(Token = "0x4002DA0")]
				[OriginalName("TYPE_GROUP")]
				Group,
				// Token: 0x04002DA1 RID: 11681
				[Token(Token = "0x4002DA1")]
				[OriginalName("TYPE_MESSAGE")]
				Message,
				// Token: 0x04002DA2 RID: 11682
				[Token(Token = "0x4002DA2")]
				[OriginalName("TYPE_BYTES")]
				Bytes,
				// Token: 0x04002DA3 RID: 11683
				[Token(Token = "0x4002DA3")]
				[OriginalName("TYPE_UINT32")]
				Uint32,
				// Token: 0x04002DA4 RID: 11684
				[Token(Token = "0x4002DA4")]
				[OriginalName("TYPE_ENUM")]
				Enum,
				// Token: 0x04002DA5 RID: 11685
				[Token(Token = "0x4002DA5")]
				[OriginalName("TYPE_SFIXED32")]
				Sfixed32,
				// Token: 0x04002DA6 RID: 11686
				[Token(Token = "0x4002DA6")]
				[OriginalName("TYPE_SFIXED64")]
				Sfixed64,
				// Token: 0x04002DA7 RID: 11687
				[Token(Token = "0x4002DA7")]
				[OriginalName("TYPE_SINT32")]
				Sint32,
				// Token: 0x04002DA8 RID: 11688
				[Token(Token = "0x4002DA8")]
				[OriginalName("TYPE_SINT64")]
				Sint64
			}

			// Token: 0x02000B8A RID: 2954
			[Token(Token = "0x2000B8A")]
			public enum Label
			{
				// Token: 0x04002DAA RID: 11690
				[Token(Token = "0x4002DAA")]
				[OriginalName("LABEL_OPTIONAL")]
				Optional = 1,
				// Token: 0x04002DAB RID: 11691
				[Token(Token = "0x4002DAB")]
				[OriginalName("LABEL_REQUIRED")]
				Required,
				// Token: 0x04002DAC RID: 11692
				[Token(Token = "0x4002DAC")]
				[OriginalName("LABEL_REPEATED")]
				Repeated
			}
		}
	}
}
