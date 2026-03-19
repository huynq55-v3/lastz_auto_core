using System;
using System.Diagnostics;
using Google.Protobuf.Collections;
using Il2CppDummyDll;

namespace Google.Protobuf.Reflection
{
	// Token: 0x02000B8E RID: 2958
	[Token(Token = "0x2000B8E")]
	public sealed class EnumDescriptorProto : IMessage<EnumDescriptorProto>, IMessage, IEquatable<EnumDescriptorProto>, IDeepCloneable<EnumDescriptorProto>
	{
		// Token: 0x170008E3 RID: 2275
		// (get) Token: 0x060070F6 RID: 28918 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008E3")]
		[DebuggerNonUserCode]
		public static MessageParser<EnumDescriptorProto> Parser
		{
			[Token(Token = "0x60070F6")]
			[Address(RVA = "0x31F6008", Offset = "0x31F6008", VA = "0x31F6008")]
			get
			{
				return null;
			}
		}

		// Token: 0x170008E4 RID: 2276
		// (get) Token: 0x060070F7 RID: 28919 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008E4")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Token(Token = "0x60070F7")]
			[Address(RVA = "0x31F6060", Offset = "0x31F6060", VA = "0x31F6060")]
			get
			{
				return null;
			}
		}

		// Token: 0x170008E5 RID: 2277
		// (get) Token: 0x060070F8 RID: 28920 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008E5")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Token(Token = "0x60070F8")]
			[Address(RVA = "0x31F6164", Offset = "0x31F6164", VA = "0x31F6164", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x060070F9 RID: 28921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60070F9")]
		[Address(RVA = "0x31F61B0", Offset = "0x31F61B0", VA = "0x31F61B0")]
		[DebuggerNonUserCode]
		public EnumDescriptorProto()
		{
		}

		// Token: 0x060070FA RID: 28922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60070FA")]
		[Address(RVA = "0x31F62D8", Offset = "0x31F62D8", VA = "0x31F62D8")]
		[DebuggerNonUserCode]
		public EnumDescriptorProto(EnumDescriptorProto other)
		{
		}

		// Token: 0x060070FB RID: 28923 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60070FB")]
		[Address(RVA = "0x31F6470", Offset = "0x31F6470", VA = "0x31F6470", Slot = "10")]
		[DebuggerNonUserCode]
		public EnumDescriptorProto Clone()
		{
			return null;
		}

		// Token: 0x170008E6 RID: 2278
		// (get) Token: 0x060070FC RID: 28924 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060070FD RID: 28925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170008E6")]
		[DebuggerNonUserCode]
		public string Name
		{
			[Token(Token = "0x60070FC")]
			[Address(RVA = "0x31F64D0", Offset = "0x31F64D0", VA = "0x31F64D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60070FD")]
			[Address(RVA = "0x31F6534", Offset = "0x31F6534", VA = "0x31F6534")]
			set
			{
			}
		}

		// Token: 0x170008E7 RID: 2279
		// (get) Token: 0x060070FE RID: 28926 RVA: 0x00050280 File Offset: 0x0004E480
		[Token(Token = "0x170008E7")]
		[DebuggerNonUserCode]
		public bool HasName
		{
			[Token(Token = "0x60070FE")]
			[Address(RVA = "0x31F65B0", Offset = "0x31F65B0", VA = "0x31F65B0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060070FF RID: 28927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60070FF")]
		[Address(RVA = "0x31F65C0", Offset = "0x31F65C0", VA = "0x31F65C0")]
		[DebuggerNonUserCode]
		public void ClearName()
		{
		}

		// Token: 0x170008E8 RID: 2280
		// (get) Token: 0x06007100 RID: 28928 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008E8")]
		[DebuggerNonUserCode]
		public RepeatedField<EnumValueDescriptorProto> Value
		{
			[Token(Token = "0x6007100")]
			[Address(RVA = "0x31F65CC", Offset = "0x31F65CC", VA = "0x31F65CC")]
			get
			{
				return null;
			}
		}

		// Token: 0x170008E9 RID: 2281
		// (get) Token: 0x06007101 RID: 28929 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06007102 RID: 28930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170008E9")]
		[DebuggerNonUserCode]
		public EnumOptions Options
		{
			[Token(Token = "0x6007101")]
			[Address(RVA = "0x31F65D4", Offset = "0x31F65D4", VA = "0x31F65D4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6007102")]
			[Address(RVA = "0x31F65DC", Offset = "0x31F65DC", VA = "0x31F65DC")]
			set
			{
			}
		}

		// Token: 0x170008EA RID: 2282
		// (get) Token: 0x06007103 RID: 28931 RVA: 0x00050298 File Offset: 0x0004E498
		[Token(Token = "0x170008EA")]
		[DebuggerNonUserCode]
		public bool HasOptions
		{
			[Token(Token = "0x6007103")]
			[Address(RVA = "0x31F6400", Offset = "0x31F6400", VA = "0x31F6400")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06007104 RID: 28932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007104")]
		[Address(RVA = "0x31F65E4", Offset = "0x31F65E4", VA = "0x31F65E4")]
		[DebuggerNonUserCode]
		public void ClearOptions()
		{
		}

		// Token: 0x170008EB RID: 2283
		// (get) Token: 0x06007105 RID: 28933 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008EB")]
		[DebuggerNonUserCode]
		public RepeatedField<EnumDescriptorProto.Types.EnumReservedRange> ReservedRange
		{
			[Token(Token = "0x6007105")]
			[Address(RVA = "0x31F65F0", Offset = "0x31F65F0", VA = "0x31F65F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170008EC RID: 2284
		// (get) Token: 0x06007106 RID: 28934 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008EC")]
		[DebuggerNonUserCode]
		public RepeatedField<string> ReservedName
		{
			[Token(Token = "0x6007106")]
			[Address(RVA = "0x31F65F8", Offset = "0x31F65F8", VA = "0x31F65F8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06007107 RID: 28935 RVA: 0x000502B0 File Offset: 0x0004E4B0
		[Token(Token = "0x6007107")]
		[Address(RVA = "0x31F6600", Offset = "0x31F6600", VA = "0x31F6600", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06007108 RID: 28936 RVA: 0x000502C8 File Offset: 0x0004E4C8
		[Token(Token = "0x6007108")]
		[Address(RVA = "0x31F6664", Offset = "0x31F6664", VA = "0x31F6664", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(EnumDescriptorProto other)
		{
			return default(bool);
		}

		// Token: 0x06007109 RID: 28937 RVA: 0x000502E0 File Offset: 0x0004E4E0
		[Token(Token = "0x6007109")]
		[Address(RVA = "0x31F6788", Offset = "0x31F6788", VA = "0x31F6788", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600710A RID: 28938 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600710A")]
		[Address(RVA = "0x31F6858", Offset = "0x31F6858", VA = "0x31F6858", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600710B RID: 28939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600710B")]
		[Address(RVA = "0x31F68B0", Offset = "0x31F68B0", VA = "0x31F68B0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600710C RID: 28940 RVA: 0x000502F8 File Offset: 0x0004E4F8
		[Token(Token = "0x600710C")]
		[Address(RVA = "0x31F6A44", Offset = "0x31F6A44", VA = "0x31F6A44", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600710D RID: 28941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600710D")]
		[Address(RVA = "0x31F6BF4", Offset = "0x31F6BF4", VA = "0x31F6BF4", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(EnumDescriptorProto other)
		{
		}

		// Token: 0x0600710E RID: 28942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600710E")]
		[Address(RVA = "0x31F6ECC", Offset = "0x31F6ECC", VA = "0x31F6ECC", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x04002DB6 RID: 11702
		[Token(Token = "0x4002DB6")]
		[FieldOffset(Offset = "0x0")]
		private static readonly MessageParser<EnumDescriptorProto> _parser;

		// Token: 0x04002DB7 RID: 11703
		[Token(Token = "0x4002DB7")]
		[FieldOffset(Offset = "0x10")]
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002DB8 RID: 11704
		[Token(Token = "0x4002DB8")]
		public const int NameFieldNumber = 1;

		// Token: 0x04002DB9 RID: 11705
		[Token(Token = "0x4002DB9")]
		[FieldOffset(Offset = "0x8")]
		private static readonly string NameDefaultValue;

		// Token: 0x04002DBA RID: 11706
		[Token(Token = "0x4002DBA")]
		[FieldOffset(Offset = "0x18")]
		private string name_;

		// Token: 0x04002DBB RID: 11707
		[Token(Token = "0x4002DBB")]
		public const int ValueFieldNumber = 2;

		// Token: 0x04002DBC RID: 11708
		[Token(Token = "0x4002DBC")]
		[FieldOffset(Offset = "0x10")]
		private static readonly FieldCodec<EnumValueDescriptorProto> _repeated_value_codec;

		// Token: 0x04002DBD RID: 11709
		[Token(Token = "0x4002DBD")]
		[FieldOffset(Offset = "0x20")]
		private readonly RepeatedField<EnumValueDescriptorProto> value_;

		// Token: 0x04002DBE RID: 11710
		[Token(Token = "0x4002DBE")]
		public const int OptionsFieldNumber = 3;

		// Token: 0x04002DBF RID: 11711
		[Token(Token = "0x4002DBF")]
		[FieldOffset(Offset = "0x28")]
		private EnumOptions options_;

		// Token: 0x04002DC0 RID: 11712
		[Token(Token = "0x4002DC0")]
		public const int ReservedRangeFieldNumber = 4;

		// Token: 0x04002DC1 RID: 11713
		[Token(Token = "0x4002DC1")]
		[FieldOffset(Offset = "0x18")]
		private static readonly FieldCodec<EnumDescriptorProto.Types.EnumReservedRange> _repeated_reservedRange_codec;

		// Token: 0x04002DC2 RID: 11714
		[Token(Token = "0x4002DC2")]
		[FieldOffset(Offset = "0x30")]
		private readonly RepeatedField<EnumDescriptorProto.Types.EnumReservedRange> reservedRange_;

		// Token: 0x04002DC3 RID: 11715
		[Token(Token = "0x4002DC3")]
		public const int ReservedNameFieldNumber = 5;

		// Token: 0x04002DC4 RID: 11716
		[Token(Token = "0x4002DC4")]
		[FieldOffset(Offset = "0x20")]
		private static readonly FieldCodec<string> _repeated_reservedName_codec;

		// Token: 0x04002DC5 RID: 11717
		[Token(Token = "0x4002DC5")]
		[FieldOffset(Offset = "0x38")]
		private readonly RepeatedField<string> reservedName_;

		// Token: 0x02000B8F RID: 2959
		[Token(Token = "0x2000B8F")]
		[DebuggerNonUserCode]
		public static class Types
		{
			// Token: 0x02000B90 RID: 2960
			[Token(Token = "0x2000B90")]
			public sealed class EnumReservedRange : IMessage<EnumDescriptorProto.Types.EnumReservedRange>, IMessage, IEquatable<EnumDescriptorProto.Types.EnumReservedRange>, IDeepCloneable<EnumDescriptorProto.Types.EnumReservedRange>
			{
				// Token: 0x170008ED RID: 2285
				// (get) Token: 0x06007110 RID: 28944 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x170008ED")]
				[DebuggerNonUserCode]
				public static MessageParser<EnumDescriptorProto.Types.EnumReservedRange> Parser
				{
					[Token(Token = "0x6007110")]
					[Address(RVA = "0x31F7384", Offset = "0x31F7384", VA = "0x31F7384")]
					get
					{
						return null;
					}
				}

				// Token: 0x170008EE RID: 2286
				// (get) Token: 0x06007111 RID: 28945 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x170008EE")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Token(Token = "0x6007111")]
					[Address(RVA = "0x31F73DC", Offset = "0x31F73DC", VA = "0x31F73DC")]
					get
					{
						return null;
					}
				}

				// Token: 0x170008EF RID: 2287
				// (get) Token: 0x06007112 RID: 28946 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x170008EF")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
				{
					[Token(Token = "0x6007112")]
					[Address(RVA = "0x31F74A8", Offset = "0x31F74A8", VA = "0x31F74A8", Slot = "8")]
					get
					{
						return null;
					}
				}

				// Token: 0x06007113 RID: 28947 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6007113")]
				[Address(RVA = "0x31F74F4", Offset = "0x31F74F4", VA = "0x31F74F4")]
				[DebuggerNonUserCode]
				public EnumReservedRange()
				{
				}

				// Token: 0x06007114 RID: 28948 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6007114")]
				[Address(RVA = "0x31F74FC", Offset = "0x31F74FC", VA = "0x31F74FC")]
				[DebuggerNonUserCode]
				public EnumReservedRange(EnumDescriptorProto.Types.EnumReservedRange other)
				{
				}

				// Token: 0x06007115 RID: 28949 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6007115")]
				[Address(RVA = "0x31F7550", Offset = "0x31F7550", VA = "0x31F7550", Slot = "10")]
				[DebuggerNonUserCode]
				public EnumDescriptorProto.Types.EnumReservedRange Clone()
				{
					return null;
				}

				// Token: 0x170008F0 RID: 2288
				// (get) Token: 0x06007116 RID: 28950 RVA: 0x00050310 File Offset: 0x0004E510
				// (set) Token: 0x06007117 RID: 28951 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x170008F0")]
				[DebuggerNonUserCode]
				public int Start
				{
					[Token(Token = "0x6007116")]
					[Address(RVA = "0x31F75B0", Offset = "0x31F75B0", VA = "0x31F75B0")]
					get
					{
						return 0;
					}
					[Token(Token = "0x6007117")]
					[Address(RVA = "0x31F7620", Offset = "0x31F7620", VA = "0x31F7620")]
					set
					{
					}
				}

				// Token: 0x170008F1 RID: 2289
				// (get) Token: 0x06007118 RID: 28952 RVA: 0x00050328 File Offset: 0x0004E528
				[Token(Token = "0x170008F1")]
				[DebuggerNonUserCode]
				public bool HasStart
				{
					[Token(Token = "0x6007118")]
					[Address(RVA = "0x31F7630", Offset = "0x31F7630", VA = "0x31F7630")]
					get
					{
						return default(bool);
					}
				}

				// Token: 0x06007119 RID: 28953 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6007119")]
				[Address(RVA = "0x31F763C", Offset = "0x31F763C", VA = "0x31F763C")]
				[DebuggerNonUserCode]
				public void ClearStart()
				{
				}

				// Token: 0x170008F2 RID: 2290
				// (get) Token: 0x0600711A RID: 28954 RVA: 0x00050340 File Offset: 0x0004E540
				// (set) Token: 0x0600711B RID: 28955 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x170008F2")]
				[DebuggerNonUserCode]
				public int End
				{
					[Token(Token = "0x600711A")]
					[Address(RVA = "0x31F764C", Offset = "0x31F764C", VA = "0x31F764C")]
					get
					{
						return 0;
					}
					[Token(Token = "0x600711B")]
					[Address(RVA = "0x31F76BC", Offset = "0x31F76BC", VA = "0x31F76BC")]
					set
					{
					}
				}

				// Token: 0x170008F3 RID: 2291
				// (get) Token: 0x0600711C RID: 28956 RVA: 0x00050358 File Offset: 0x0004E558
				[Token(Token = "0x170008F3")]
				[DebuggerNonUserCode]
				public bool HasEnd
				{
					[Token(Token = "0x600711C")]
					[Address(RVA = "0x31F76D0", Offset = "0x31F76D0", VA = "0x31F76D0")]
					get
					{
						return default(bool);
					}
				}

				// Token: 0x0600711D RID: 28957 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600711D")]
				[Address(RVA = "0x31F76DC", Offset = "0x31F76DC", VA = "0x31F76DC")]
				[DebuggerNonUserCode]
				public void ClearEnd()
				{
				}

				// Token: 0x0600711E RID: 28958 RVA: 0x00050370 File Offset: 0x0004E570
				[Token(Token = "0x600711E")]
				[Address(RVA = "0x31F76EC", Offset = "0x31F76EC", VA = "0x31F76EC", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				// Token: 0x0600711F RID: 28959 RVA: 0x00050388 File Offset: 0x0004E588
				[Token(Token = "0x600711F")]
				[Address(RVA = "0x31F7750", Offset = "0x31F7750", VA = "0x31F7750", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(EnumDescriptorProto.Types.EnumReservedRange other)
				{
					return default(bool);
				}

				// Token: 0x06007120 RID: 28960 RVA: 0x000503A0 File Offset: 0x0004E5A0
				[Token(Token = "0x6007120")]
				[Address(RVA = "0x31F77D4", Offset = "0x31F77D4", VA = "0x31F77D4", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x06007121 RID: 28961 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6007121")]
				[Address(RVA = "0x31F7860", Offset = "0x31F7860", VA = "0x31F7860", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x06007122 RID: 28962 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6007122")]
				[Address(RVA = "0x31F78B8", Offset = "0x31F78B8", VA = "0x31F78B8", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x06007123 RID: 28963 RVA: 0x000503B8 File Offset: 0x0004E5B8
				[Token(Token = "0x6007123")]
				[Address(RVA = "0x31F795C", Offset = "0x31F795C", VA = "0x31F795C", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x06007124 RID: 28964 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6007124")]
				[Address(RVA = "0x31F7A34", Offset = "0x31F7A34", VA = "0x31F7A34", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(EnumDescriptorProto.Types.EnumReservedRange other)
				{
				}

				// Token: 0x06007125 RID: 28965 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6007125")]
				[Address(RVA = "0x31F7AB0", Offset = "0x31F7AB0", VA = "0x31F7AB0", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x04002DC6 RID: 11718
				[Token(Token = "0x4002DC6")]
				[FieldOffset(Offset = "0x0")]
				private static readonly MessageParser<EnumDescriptorProto.Types.EnumReservedRange> _parser;

				// Token: 0x04002DC7 RID: 11719
				[Token(Token = "0x4002DC7")]
				[FieldOffset(Offset = "0x10")]
				private UnknownFieldSet _unknownFields;

				// Token: 0x04002DC8 RID: 11720
				[Token(Token = "0x4002DC8")]
				[FieldOffset(Offset = "0x18")]
				private int _hasBits0;

				// Token: 0x04002DC9 RID: 11721
				[Token(Token = "0x4002DC9")]
				public const int StartFieldNumber = 1;

				// Token: 0x04002DCA RID: 11722
				[Token(Token = "0x4002DCA")]
				[FieldOffset(Offset = "0x8")]
				private static readonly int StartDefaultValue;

				// Token: 0x04002DCB RID: 11723
				[Token(Token = "0x4002DCB")]
				[FieldOffset(Offset = "0x1C")]
				private int start_;

				// Token: 0x04002DCC RID: 11724
				[Token(Token = "0x4002DCC")]
				public const int EndFieldNumber = 2;

				// Token: 0x04002DCD RID: 11725
				[Token(Token = "0x4002DCD")]
				[FieldOffset(Offset = "0xC")]
				private static readonly int EndDefaultValue;

				// Token: 0x04002DCE RID: 11726
				[Token(Token = "0x4002DCE")]
				[FieldOffset(Offset = "0x20")]
				private int end_;
			}
		}
	}
}
