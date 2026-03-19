using System;
using System.Diagnostics;
using Google.Protobuf.Collections;
using Il2CppDummyDll;

namespace Google.Protobuf.Reflection
{
	// Token: 0x02000B7E RID: 2942
	[Token(Token = "0x2000B7E")]
	public sealed class DescriptorProto : IMessage<DescriptorProto>, IMessage, IEquatable<DescriptorProto>, IDeepCloneable<DescriptorProto>
	{
		// Token: 0x170008A1 RID: 2209
		// (get) Token: 0x0600702D RID: 28717 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008A1")]
		[DebuggerNonUserCode]
		public static MessageParser<DescriptorProto> Parser
		{
			[Token(Token = "0x600702D")]
			[Address(RVA = "0x31EF6EC", Offset = "0x31EF6EC", VA = "0x31EF6EC")]
			get
			{
				return null;
			}
		}

		// Token: 0x170008A2 RID: 2210
		// (get) Token: 0x0600702E RID: 28718 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008A2")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Token(Token = "0x600702E")]
			[Address(RVA = "0x31EF744", Offset = "0x31EF744", VA = "0x31EF744")]
			get
			{
				return null;
			}
		}

		// Token: 0x170008A3 RID: 2211
		// (get) Token: 0x0600702F RID: 28719 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008A3")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Token(Token = "0x600702F")]
			[Address(RVA = "0x31EF848", Offset = "0x31EF848", VA = "0x31EF848", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06007030 RID: 28720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007030")]
		[Address(RVA = "0x31EF894", Offset = "0x31EF894", VA = "0x31EF894")]
		[DebuggerNonUserCode]
		public DescriptorProto()
		{
		}

		// Token: 0x06007031 RID: 28721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007031")]
		[Address(RVA = "0x31EFB2C", Offset = "0x31EFB2C", VA = "0x31EFB2C")]
		[DebuggerNonUserCode]
		public DescriptorProto(DescriptorProto other)
		{
		}

		// Token: 0x06007032 RID: 28722 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007032")]
		[Address(RVA = "0x31EFDB4", Offset = "0x31EFDB4", VA = "0x31EFDB4", Slot = "10")]
		[DebuggerNonUserCode]
		public DescriptorProto Clone()
		{
			return null;
		}

		// Token: 0x170008A4 RID: 2212
		// (get) Token: 0x06007033 RID: 28723 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06007034 RID: 28724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170008A4")]
		[DebuggerNonUserCode]
		public string Name
		{
			[Token(Token = "0x6007033")]
			[Address(RVA = "0x31EFE14", Offset = "0x31EFE14", VA = "0x31EFE14")]
			get
			{
				return null;
			}
			[Token(Token = "0x6007034")]
			[Address(RVA = "0x31EFE78", Offset = "0x31EFE78", VA = "0x31EFE78")]
			set
			{
			}
		}

		// Token: 0x170008A5 RID: 2213
		// (get) Token: 0x06007035 RID: 28725 RVA: 0x0004FDA0 File Offset: 0x0004DFA0
		[Token(Token = "0x170008A5")]
		[DebuggerNonUserCode]
		public bool HasName
		{
			[Token(Token = "0x6007035")]
			[Address(RVA = "0x31EFEF4", Offset = "0x31EFEF4", VA = "0x31EFEF4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06007036 RID: 28726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007036")]
		[Address(RVA = "0x31EFF04", Offset = "0x31EFF04", VA = "0x31EFF04")]
		[DebuggerNonUserCode]
		public void ClearName()
		{
		}

		// Token: 0x170008A6 RID: 2214
		// (get) Token: 0x06007037 RID: 28727 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008A6")]
		[DebuggerNonUserCode]
		public RepeatedField<FieldDescriptorProto> Field
		{
			[Token(Token = "0x6007037")]
			[Address(RVA = "0x31EFF10", Offset = "0x31EFF10", VA = "0x31EFF10")]
			get
			{
				return null;
			}
		}

		// Token: 0x170008A7 RID: 2215
		// (get) Token: 0x06007038 RID: 28728 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008A7")]
		[DebuggerNonUserCode]
		public RepeatedField<FieldDescriptorProto> Extension
		{
			[Token(Token = "0x6007038")]
			[Address(RVA = "0x31EFF18", Offset = "0x31EFF18", VA = "0x31EFF18")]
			get
			{
				return null;
			}
		}

		// Token: 0x170008A8 RID: 2216
		// (get) Token: 0x06007039 RID: 28729 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008A8")]
		[DebuggerNonUserCode]
		public RepeatedField<DescriptorProto> NestedType
		{
			[Token(Token = "0x6007039")]
			[Address(RVA = "0x31EFF20", Offset = "0x31EFF20", VA = "0x31EFF20")]
			get
			{
				return null;
			}
		}

		// Token: 0x170008A9 RID: 2217
		// (get) Token: 0x0600703A RID: 28730 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008A9")]
		[DebuggerNonUserCode]
		public RepeatedField<EnumDescriptorProto> EnumType
		{
			[Token(Token = "0x600703A")]
			[Address(RVA = "0x31EFF28", Offset = "0x31EFF28", VA = "0x31EFF28")]
			get
			{
				return null;
			}
		}

		// Token: 0x170008AA RID: 2218
		// (get) Token: 0x0600703B RID: 28731 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008AA")]
		[DebuggerNonUserCode]
		public RepeatedField<DescriptorProto.Types.ExtensionRange> ExtensionRange
		{
			[Token(Token = "0x600703B")]
			[Address(RVA = "0x31EFF30", Offset = "0x31EFF30", VA = "0x31EFF30")]
			get
			{
				return null;
			}
		}

		// Token: 0x170008AB RID: 2219
		// (get) Token: 0x0600703C RID: 28732 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008AB")]
		[DebuggerNonUserCode]
		public RepeatedField<OneofDescriptorProto> OneofDecl
		{
			[Token(Token = "0x600703C")]
			[Address(RVA = "0x31EFF38", Offset = "0x31EFF38", VA = "0x31EFF38")]
			get
			{
				return null;
			}
		}

		// Token: 0x170008AC RID: 2220
		// (get) Token: 0x0600703D RID: 28733 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600703E RID: 28734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170008AC")]
		[DebuggerNonUserCode]
		public MessageOptions Options
		{
			[Token(Token = "0x600703D")]
			[Address(RVA = "0x31EFF40", Offset = "0x31EFF40", VA = "0x31EFF40")]
			get
			{
				return null;
			}
			[Token(Token = "0x600703E")]
			[Address(RVA = "0x31EFF48", Offset = "0x31EFF48", VA = "0x31EFF48")]
			set
			{
			}
		}

		// Token: 0x170008AD RID: 2221
		// (get) Token: 0x0600703F RID: 28735 RVA: 0x0004FDB8 File Offset: 0x0004DFB8
		[Token(Token = "0x170008AD")]
		[DebuggerNonUserCode]
		public bool HasOptions
		{
			[Token(Token = "0x600703F")]
			[Address(RVA = "0x31EFD44", Offset = "0x31EFD44", VA = "0x31EFD44")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06007040 RID: 28736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007040")]
		[Address(RVA = "0x31EFF50", Offset = "0x31EFF50", VA = "0x31EFF50")]
		[DebuggerNonUserCode]
		public void ClearOptions()
		{
		}

		// Token: 0x170008AE RID: 2222
		// (get) Token: 0x06007041 RID: 28737 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008AE")]
		[DebuggerNonUserCode]
		public RepeatedField<DescriptorProto.Types.ReservedRange> ReservedRange
		{
			[Token(Token = "0x6007041")]
			[Address(RVA = "0x31EFF5C", Offset = "0x31EFF5C", VA = "0x31EFF5C")]
			get
			{
				return null;
			}
		}

		// Token: 0x170008AF RID: 2223
		// (get) Token: 0x06007042 RID: 28738 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008AF")]
		[DebuggerNonUserCode]
		public RepeatedField<string> ReservedName
		{
			[Token(Token = "0x6007042")]
			[Address(RVA = "0x31EFF64", Offset = "0x31EFF64", VA = "0x31EFF64")]
			get
			{
				return null;
			}
		}

		// Token: 0x06007043 RID: 28739 RVA: 0x0004FDD0 File Offset: 0x0004DFD0
		[Token(Token = "0x6007043")]
		[Address(RVA = "0x31EFF6C", Offset = "0x31EFF6C", VA = "0x31EFF6C", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06007044 RID: 28740 RVA: 0x0004FDE8 File Offset: 0x0004DFE8
		[Token(Token = "0x6007044")]
		[Address(RVA = "0x31EFFD0", Offset = "0x31EFFD0", VA = "0x31EFFD0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(DescriptorProto other)
		{
			return default(bool);
		}

		// Token: 0x06007045 RID: 28741 RVA: 0x0004FE00 File Offset: 0x0004E000
		[Token(Token = "0x6007045")]
		[Address(RVA = "0x31F01BC", Offset = "0x31F01BC", VA = "0x31F01BC", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06007046 RID: 28742 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007046")]
		[Address(RVA = "0x31F0338", Offset = "0x31F0338", VA = "0x31F0338", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06007047 RID: 28743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007047")]
		[Address(RVA = "0x31F0390", Offset = "0x31F0390", VA = "0x31F0390", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06007048 RID: 28744 RVA: 0x0004FE18 File Offset: 0x0004E018
		[Token(Token = "0x6007048")]
		[Address(RVA = "0x31F0614", Offset = "0x31F0614", VA = "0x31F0614", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06007049 RID: 28745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007049")]
		[Address(RVA = "0x31F08E8", Offset = "0x31F08E8", VA = "0x31F08E8", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(DescriptorProto other)
		{
		}

		// Token: 0x0600704A RID: 28746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600704A")]
		[Address(RVA = "0x31F0CCC", Offset = "0x31F0CCC", VA = "0x31F0CCC", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x04002D39 RID: 11577
		[Token(Token = "0x4002D39")]
		[FieldOffset(Offset = "0x0")]
		private static readonly MessageParser<DescriptorProto> _parser;

		// Token: 0x04002D3A RID: 11578
		[Token(Token = "0x4002D3A")]
		[FieldOffset(Offset = "0x10")]
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002D3B RID: 11579
		[Token(Token = "0x4002D3B")]
		public const int NameFieldNumber = 1;

		// Token: 0x04002D3C RID: 11580
		[Token(Token = "0x4002D3C")]
		[FieldOffset(Offset = "0x8")]
		private static readonly string NameDefaultValue;

		// Token: 0x04002D3D RID: 11581
		[Token(Token = "0x4002D3D")]
		[FieldOffset(Offset = "0x18")]
		private string name_;

		// Token: 0x04002D3E RID: 11582
		[Token(Token = "0x4002D3E")]
		public const int FieldFieldNumber = 2;

		// Token: 0x04002D3F RID: 11583
		[Token(Token = "0x4002D3F")]
		[FieldOffset(Offset = "0x10")]
		private static readonly FieldCodec<FieldDescriptorProto> _repeated_field_codec;

		// Token: 0x04002D40 RID: 11584
		[Token(Token = "0x4002D40")]
		[FieldOffset(Offset = "0x20")]
		private readonly RepeatedField<FieldDescriptorProto> field_;

		// Token: 0x04002D41 RID: 11585
		[Token(Token = "0x4002D41")]
		public const int ExtensionFieldNumber = 6;

		// Token: 0x04002D42 RID: 11586
		[Token(Token = "0x4002D42")]
		[FieldOffset(Offset = "0x18")]
		private static readonly FieldCodec<FieldDescriptorProto> _repeated_extension_codec;

		// Token: 0x04002D43 RID: 11587
		[Token(Token = "0x4002D43")]
		[FieldOffset(Offset = "0x28")]
		private readonly RepeatedField<FieldDescriptorProto> extension_;

		// Token: 0x04002D44 RID: 11588
		[Token(Token = "0x4002D44")]
		public const int NestedTypeFieldNumber = 3;

		// Token: 0x04002D45 RID: 11589
		[Token(Token = "0x4002D45")]
		[FieldOffset(Offset = "0x20")]
		private static readonly FieldCodec<DescriptorProto> _repeated_nestedType_codec;

		// Token: 0x04002D46 RID: 11590
		[Token(Token = "0x4002D46")]
		[FieldOffset(Offset = "0x30")]
		private readonly RepeatedField<DescriptorProto> nestedType_;

		// Token: 0x04002D47 RID: 11591
		[Token(Token = "0x4002D47")]
		public const int EnumTypeFieldNumber = 4;

		// Token: 0x04002D48 RID: 11592
		[Token(Token = "0x4002D48")]
		[FieldOffset(Offset = "0x28")]
		private static readonly FieldCodec<EnumDescriptorProto> _repeated_enumType_codec;

		// Token: 0x04002D49 RID: 11593
		[Token(Token = "0x4002D49")]
		[FieldOffset(Offset = "0x38")]
		private readonly RepeatedField<EnumDescriptorProto> enumType_;

		// Token: 0x04002D4A RID: 11594
		[Token(Token = "0x4002D4A")]
		public const int ExtensionRangeFieldNumber = 5;

		// Token: 0x04002D4B RID: 11595
		[Token(Token = "0x4002D4B")]
		[FieldOffset(Offset = "0x30")]
		private static readonly FieldCodec<DescriptorProto.Types.ExtensionRange> _repeated_extensionRange_codec;

		// Token: 0x04002D4C RID: 11596
		[Token(Token = "0x4002D4C")]
		[FieldOffset(Offset = "0x40")]
		private readonly RepeatedField<DescriptorProto.Types.ExtensionRange> extensionRange_;

		// Token: 0x04002D4D RID: 11597
		[Token(Token = "0x4002D4D")]
		public const int OneofDeclFieldNumber = 8;

		// Token: 0x04002D4E RID: 11598
		[Token(Token = "0x4002D4E")]
		[FieldOffset(Offset = "0x38")]
		private static readonly FieldCodec<OneofDescriptorProto> _repeated_oneofDecl_codec;

		// Token: 0x04002D4F RID: 11599
		[Token(Token = "0x4002D4F")]
		[FieldOffset(Offset = "0x48")]
		private readonly RepeatedField<OneofDescriptorProto> oneofDecl_;

		// Token: 0x04002D50 RID: 11600
		[Token(Token = "0x4002D50")]
		public const int OptionsFieldNumber = 7;

		// Token: 0x04002D51 RID: 11601
		[Token(Token = "0x4002D51")]
		[FieldOffset(Offset = "0x50")]
		private MessageOptions options_;

		// Token: 0x04002D52 RID: 11602
		[Token(Token = "0x4002D52")]
		public const int ReservedRangeFieldNumber = 9;

		// Token: 0x04002D53 RID: 11603
		[Token(Token = "0x4002D53")]
		[FieldOffset(Offset = "0x40")]
		private static readonly FieldCodec<DescriptorProto.Types.ReservedRange> _repeated_reservedRange_codec;

		// Token: 0x04002D54 RID: 11604
		[Token(Token = "0x4002D54")]
		[FieldOffset(Offset = "0x58")]
		private readonly RepeatedField<DescriptorProto.Types.ReservedRange> reservedRange_;

		// Token: 0x04002D55 RID: 11605
		[Token(Token = "0x4002D55")]
		public const int ReservedNameFieldNumber = 10;

		// Token: 0x04002D56 RID: 11606
		[Token(Token = "0x4002D56")]
		[FieldOffset(Offset = "0x48")]
		private static readonly FieldCodec<string> _repeated_reservedName_codec;

		// Token: 0x04002D57 RID: 11607
		[Token(Token = "0x4002D57")]
		[FieldOffset(Offset = "0x60")]
		private readonly RepeatedField<string> reservedName_;

		// Token: 0x02000B7F RID: 2943
		[Token(Token = "0x2000B7F")]
		[DebuggerNonUserCode]
		public static class Types
		{
			// Token: 0x02000B80 RID: 2944
			[Token(Token = "0x2000B80")]
			public sealed class ExtensionRange : IMessage<DescriptorProto.Types.ExtensionRange>, IMessage, IEquatable<DescriptorProto.Types.ExtensionRange>, IDeepCloneable<DescriptorProto.Types.ExtensionRange>
			{
				// Token: 0x170008B0 RID: 2224
				// (get) Token: 0x0600704C RID: 28748 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x170008B0")]
				[DebuggerNonUserCode]
				public static MessageParser<DescriptorProto.Types.ExtensionRange> Parser
				{
					[Token(Token = "0x600704C")]
					[Address(RVA = "0x31F1578", Offset = "0x31F1578", VA = "0x31F1578")]
					get
					{
						return null;
					}
				}

				// Token: 0x170008B1 RID: 2225
				// (get) Token: 0x0600704D RID: 28749 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x170008B1")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Token(Token = "0x600704D")]
					[Address(RVA = "0x31F15D0", Offset = "0x31F15D0", VA = "0x31F15D0")]
					get
					{
						return null;
					}
				}

				// Token: 0x170008B2 RID: 2226
				// (get) Token: 0x0600704E RID: 28750 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x170008B2")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
				{
					[Token(Token = "0x600704E")]
					[Address(RVA = "0x31F169C", Offset = "0x31F169C", VA = "0x31F169C", Slot = "8")]
					get
					{
						return null;
					}
				}

				// Token: 0x0600704F RID: 28751 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600704F")]
				[Address(RVA = "0x31F16E8", Offset = "0x31F16E8", VA = "0x31F16E8")]
				[DebuggerNonUserCode]
				public ExtensionRange()
				{
				}

				// Token: 0x06007050 RID: 28752 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6007050")]
				[Address(RVA = "0x31F16F0", Offset = "0x31F16F0", VA = "0x31F16F0")]
				[DebuggerNonUserCode]
				public ExtensionRange(DescriptorProto.Types.ExtensionRange other)
				{
				}

				// Token: 0x06007051 RID: 28753 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6007051")]
				[Address(RVA = "0x31F17D8", Offset = "0x31F17D8", VA = "0x31F17D8", Slot = "10")]
				[DebuggerNonUserCode]
				public DescriptorProto.Types.ExtensionRange Clone()
				{
					return null;
				}

				// Token: 0x170008B3 RID: 2227
				// (get) Token: 0x06007052 RID: 28754 RVA: 0x0004FE30 File Offset: 0x0004E030
				// (set) Token: 0x06007053 RID: 28755 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x170008B3")]
				[DebuggerNonUserCode]
				public int Start
				{
					[Token(Token = "0x6007052")]
					[Address(RVA = "0x31F1838", Offset = "0x31F1838", VA = "0x31F1838")]
					get
					{
						return 0;
					}
					[Token(Token = "0x6007053")]
					[Address(RVA = "0x31F18A8", Offset = "0x31F18A8", VA = "0x31F18A8")]
					set
					{
					}
				}

				// Token: 0x170008B4 RID: 2228
				// (get) Token: 0x06007054 RID: 28756 RVA: 0x0004FE48 File Offset: 0x0004E048
				[Token(Token = "0x170008B4")]
				[DebuggerNonUserCode]
				public bool HasStart
				{
					[Token(Token = "0x6007054")]
					[Address(RVA = "0x31F18B8", Offset = "0x31F18B8", VA = "0x31F18B8")]
					get
					{
						return default(bool);
					}
				}

				// Token: 0x06007055 RID: 28757 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6007055")]
				[Address(RVA = "0x31F18C4", Offset = "0x31F18C4", VA = "0x31F18C4")]
				[DebuggerNonUserCode]
				public void ClearStart()
				{
				}

				// Token: 0x170008B5 RID: 2229
				// (get) Token: 0x06007056 RID: 28758 RVA: 0x0004FE60 File Offset: 0x0004E060
				// (set) Token: 0x06007057 RID: 28759 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x170008B5")]
				[DebuggerNonUserCode]
				public int End
				{
					[Token(Token = "0x6007056")]
					[Address(RVA = "0x31F18D4", Offset = "0x31F18D4", VA = "0x31F18D4")]
					get
					{
						return 0;
					}
					[Token(Token = "0x6007057")]
					[Address(RVA = "0x31F1944", Offset = "0x31F1944", VA = "0x31F1944")]
					set
					{
					}
				}

				// Token: 0x170008B6 RID: 2230
				// (get) Token: 0x06007058 RID: 28760 RVA: 0x0004FE78 File Offset: 0x0004E078
				[Token(Token = "0x170008B6")]
				[DebuggerNonUserCode]
				public bool HasEnd
				{
					[Token(Token = "0x6007058")]
					[Address(RVA = "0x31F1958", Offset = "0x31F1958", VA = "0x31F1958")]
					get
					{
						return default(bool);
					}
				}

				// Token: 0x06007059 RID: 28761 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6007059")]
				[Address(RVA = "0x31F1964", Offset = "0x31F1964", VA = "0x31F1964")]
				[DebuggerNonUserCode]
				public void ClearEnd()
				{
				}

				// Token: 0x170008B7 RID: 2231
				// (get) Token: 0x0600705A RID: 28762 RVA: 0x00002050 File Offset: 0x00000250
				// (set) Token: 0x0600705B RID: 28763 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x170008B7")]
				[DebuggerNonUserCode]
				public ExtensionRangeOptions Options
				{
					[Token(Token = "0x600705A")]
					[Address(RVA = "0x31F1974", Offset = "0x31F1974", VA = "0x31F1974")]
					get
					{
						return null;
					}
					[Token(Token = "0x600705B")]
					[Address(RVA = "0x31F197C", Offset = "0x31F197C", VA = "0x31F197C")]
					set
					{
					}
				}

				// Token: 0x170008B8 RID: 2232
				// (get) Token: 0x0600705C RID: 28764 RVA: 0x0004FE90 File Offset: 0x0004E090
				[Token(Token = "0x170008B8")]
				[DebuggerNonUserCode]
				public bool HasOptions
				{
					[Token(Token = "0x600705C")]
					[Address(RVA = "0x31F1768", Offset = "0x31F1768", VA = "0x31F1768")]
					get
					{
						return default(bool);
					}
				}

				// Token: 0x0600705D RID: 28765 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600705D")]
				[Address(RVA = "0x31F1984", Offset = "0x31F1984", VA = "0x31F1984")]
				[DebuggerNonUserCode]
				public void ClearOptions()
				{
				}

				// Token: 0x0600705E RID: 28766 RVA: 0x0004FEA8 File Offset: 0x0004E0A8
				[Token(Token = "0x600705E")]
				[Address(RVA = "0x31F1990", Offset = "0x31F1990", VA = "0x31F1990", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				// Token: 0x0600705F RID: 28767 RVA: 0x0004FEC0 File Offset: 0x0004E0C0
				[Token(Token = "0x600705F")]
				[Address(RVA = "0x31F19F4", Offset = "0x31F19F4", VA = "0x31F19F4", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(DescriptorProto.Types.ExtensionRange other)
				{
					return default(bool);
				}

				// Token: 0x06007060 RID: 28768 RVA: 0x0004FED8 File Offset: 0x0004E0D8
				[Token(Token = "0x6007060")]
				[Address(RVA = "0x31F1A8C", Offset = "0x31F1A8C", VA = "0x31F1A8C", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x06007061 RID: 28769 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6007061")]
				[Address(RVA = "0x31F1B30", Offset = "0x31F1B30", VA = "0x31F1B30", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x06007062 RID: 28770 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6007062")]
				[Address(RVA = "0x31F1B88", Offset = "0x31F1B88", VA = "0x31F1B88", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x06007063 RID: 28771 RVA: 0x0004FEF0 File Offset: 0x0004E0F0
				[Token(Token = "0x6007063")]
				[Address(RVA = "0x31F1C58", Offset = "0x31F1C58", VA = "0x31F1C58", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x06007064 RID: 28772 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6007064")]
				[Address(RVA = "0x31F1D64", Offset = "0x31F1D64", VA = "0x31F1D64", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(DescriptorProto.Types.ExtensionRange other)
				{
				}

				// Token: 0x06007065 RID: 28773 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6007065")]
				[Address(RVA = "0x31F1F9C", Offset = "0x31F1F9C", VA = "0x31F1F9C", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x04002D58 RID: 11608
				[Token(Token = "0x4002D58")]
				[FieldOffset(Offset = "0x0")]
				private static readonly MessageParser<DescriptorProto.Types.ExtensionRange> _parser;

				// Token: 0x04002D59 RID: 11609
				[Token(Token = "0x4002D59")]
				[FieldOffset(Offset = "0x10")]
				private UnknownFieldSet _unknownFields;

				// Token: 0x04002D5A RID: 11610
				[Token(Token = "0x4002D5A")]
				[FieldOffset(Offset = "0x18")]
				private int _hasBits0;

				// Token: 0x04002D5B RID: 11611
				[Token(Token = "0x4002D5B")]
				public const int StartFieldNumber = 1;

				// Token: 0x04002D5C RID: 11612
				[Token(Token = "0x4002D5C")]
				[FieldOffset(Offset = "0x8")]
				private static readonly int StartDefaultValue;

				// Token: 0x04002D5D RID: 11613
				[Token(Token = "0x4002D5D")]
				[FieldOffset(Offset = "0x1C")]
				private int start_;

				// Token: 0x04002D5E RID: 11614
				[Token(Token = "0x4002D5E")]
				public const int EndFieldNumber = 2;

				// Token: 0x04002D5F RID: 11615
				[Token(Token = "0x4002D5F")]
				[FieldOffset(Offset = "0xC")]
				private static readonly int EndDefaultValue;

				// Token: 0x04002D60 RID: 11616
				[Token(Token = "0x4002D60")]
				[FieldOffset(Offset = "0x20")]
				private int end_;

				// Token: 0x04002D61 RID: 11617
				[Token(Token = "0x4002D61")]
				public const int OptionsFieldNumber = 3;

				// Token: 0x04002D62 RID: 11618
				[Token(Token = "0x4002D62")]
				[FieldOffset(Offset = "0x28")]
				private ExtensionRangeOptions options_;
			}

			// Token: 0x02000B82 RID: 2946
			[Token(Token = "0x2000B82")]
			public sealed class ReservedRange : IMessage<DescriptorProto.Types.ReservedRange>, IMessage, IEquatable<DescriptorProto.Types.ReservedRange>, IDeepCloneable<DescriptorProto.Types.ReservedRange>
			{
				// Token: 0x170008B9 RID: 2233
				// (get) Token: 0x0600706A RID: 28778 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x170008B9")]
				[DebuggerNonUserCode]
				public static MessageParser<DescriptorProto.Types.ReservedRange> Parser
				{
					[Token(Token = "0x600706A")]
					[Address(RVA = "0x31F22C8", Offset = "0x31F22C8", VA = "0x31F22C8")]
					get
					{
						return null;
					}
				}

				// Token: 0x170008BA RID: 2234
				// (get) Token: 0x0600706B RID: 28779 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x170008BA")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Token(Token = "0x600706B")]
					[Address(RVA = "0x31F2320", Offset = "0x31F2320", VA = "0x31F2320")]
					get
					{
						return null;
					}
				}

				// Token: 0x170008BB RID: 2235
				// (get) Token: 0x0600706C RID: 28780 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x170008BB")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
				{
					[Token(Token = "0x600706C")]
					[Address(RVA = "0x31F23EC", Offset = "0x31F23EC", VA = "0x31F23EC", Slot = "8")]
					get
					{
						return null;
					}
				}

				// Token: 0x0600706D RID: 28781 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600706D")]
				[Address(RVA = "0x31F2438", Offset = "0x31F2438", VA = "0x31F2438")]
				[DebuggerNonUserCode]
				public ReservedRange()
				{
				}

				// Token: 0x0600706E RID: 28782 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600706E")]
				[Address(RVA = "0x31F2440", Offset = "0x31F2440", VA = "0x31F2440")]
				[DebuggerNonUserCode]
				public ReservedRange(DescriptorProto.Types.ReservedRange other)
				{
				}

				// Token: 0x0600706F RID: 28783 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x600706F")]
				[Address(RVA = "0x31F2494", Offset = "0x31F2494", VA = "0x31F2494", Slot = "10")]
				[DebuggerNonUserCode]
				public DescriptorProto.Types.ReservedRange Clone()
				{
					return null;
				}

				// Token: 0x170008BC RID: 2236
				// (get) Token: 0x06007070 RID: 28784 RVA: 0x0004FF08 File Offset: 0x0004E108
				// (set) Token: 0x06007071 RID: 28785 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x170008BC")]
				[DebuggerNonUserCode]
				public int Start
				{
					[Token(Token = "0x6007070")]
					[Address(RVA = "0x31F24F4", Offset = "0x31F24F4", VA = "0x31F24F4")]
					get
					{
						return 0;
					}
					[Token(Token = "0x6007071")]
					[Address(RVA = "0x31F2564", Offset = "0x31F2564", VA = "0x31F2564")]
					set
					{
					}
				}

				// Token: 0x170008BD RID: 2237
				// (get) Token: 0x06007072 RID: 28786 RVA: 0x0004FF20 File Offset: 0x0004E120
				[Token(Token = "0x170008BD")]
				[DebuggerNonUserCode]
				public bool HasStart
				{
					[Token(Token = "0x6007072")]
					[Address(RVA = "0x31F2574", Offset = "0x31F2574", VA = "0x31F2574")]
					get
					{
						return default(bool);
					}
				}

				// Token: 0x06007073 RID: 28787 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6007073")]
				[Address(RVA = "0x31F2580", Offset = "0x31F2580", VA = "0x31F2580")]
				[DebuggerNonUserCode]
				public void ClearStart()
				{
				}

				// Token: 0x170008BE RID: 2238
				// (get) Token: 0x06007074 RID: 28788 RVA: 0x0004FF38 File Offset: 0x0004E138
				// (set) Token: 0x06007075 RID: 28789 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x170008BE")]
				[DebuggerNonUserCode]
				public int End
				{
					[Token(Token = "0x6007074")]
					[Address(RVA = "0x31F2590", Offset = "0x31F2590", VA = "0x31F2590")]
					get
					{
						return 0;
					}
					[Token(Token = "0x6007075")]
					[Address(RVA = "0x31F2600", Offset = "0x31F2600", VA = "0x31F2600")]
					set
					{
					}
				}

				// Token: 0x170008BF RID: 2239
				// (get) Token: 0x06007076 RID: 28790 RVA: 0x0004FF50 File Offset: 0x0004E150
				[Token(Token = "0x170008BF")]
				[DebuggerNonUserCode]
				public bool HasEnd
				{
					[Token(Token = "0x6007076")]
					[Address(RVA = "0x31F2614", Offset = "0x31F2614", VA = "0x31F2614")]
					get
					{
						return default(bool);
					}
				}

				// Token: 0x06007077 RID: 28791 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6007077")]
				[Address(RVA = "0x31F2620", Offset = "0x31F2620", VA = "0x31F2620")]
				[DebuggerNonUserCode]
				public void ClearEnd()
				{
				}

				// Token: 0x06007078 RID: 28792 RVA: 0x0004FF68 File Offset: 0x0004E168
				[Token(Token = "0x6007078")]
				[Address(RVA = "0x31F2630", Offset = "0x31F2630", VA = "0x31F2630", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				// Token: 0x06007079 RID: 28793 RVA: 0x0004FF80 File Offset: 0x0004E180
				[Token(Token = "0x6007079")]
				[Address(RVA = "0x31F2694", Offset = "0x31F2694", VA = "0x31F2694", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(DescriptorProto.Types.ReservedRange other)
				{
					return default(bool);
				}

				// Token: 0x0600707A RID: 28794 RVA: 0x0004FF98 File Offset: 0x0004E198
				[Token(Token = "0x600707A")]
				[Address(RVA = "0x31F2718", Offset = "0x31F2718", VA = "0x31F2718", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x0600707B RID: 28795 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x600707B")]
				[Address(RVA = "0x31F27A4", Offset = "0x31F27A4", VA = "0x31F27A4", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x0600707C RID: 28796 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600707C")]
				[Address(RVA = "0x31F27FC", Offset = "0x31F27FC", VA = "0x31F27FC", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x0600707D RID: 28797 RVA: 0x0004FFB0 File Offset: 0x0004E1B0
				[Token(Token = "0x600707D")]
				[Address(RVA = "0x31F28A0", Offset = "0x31F28A0", VA = "0x31F28A0", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x0600707E RID: 28798 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600707E")]
				[Address(RVA = "0x31F2978", Offset = "0x31F2978", VA = "0x31F2978", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(DescriptorProto.Types.ReservedRange other)
				{
				}

				// Token: 0x0600707F RID: 28799 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600707F")]
				[Address(RVA = "0x31F29F4", Offset = "0x31F29F4", VA = "0x31F29F4", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x04002D64 RID: 11620
				[Token(Token = "0x4002D64")]
				[FieldOffset(Offset = "0x0")]
				private static readonly MessageParser<DescriptorProto.Types.ReservedRange> _parser;

				// Token: 0x04002D65 RID: 11621
				[Token(Token = "0x4002D65")]
				[FieldOffset(Offset = "0x10")]
				private UnknownFieldSet _unknownFields;

				// Token: 0x04002D66 RID: 11622
				[Token(Token = "0x4002D66")]
				[FieldOffset(Offset = "0x18")]
				private int _hasBits0;

				// Token: 0x04002D67 RID: 11623
				[Token(Token = "0x4002D67")]
				public const int StartFieldNumber = 1;

				// Token: 0x04002D68 RID: 11624
				[Token(Token = "0x4002D68")]
				[FieldOffset(Offset = "0x8")]
				private static readonly int StartDefaultValue;

				// Token: 0x04002D69 RID: 11625
				[Token(Token = "0x4002D69")]
				[FieldOffset(Offset = "0x1C")]
				private int start_;

				// Token: 0x04002D6A RID: 11626
				[Token(Token = "0x4002D6A")]
				public const int EndFieldNumber = 2;

				// Token: 0x04002D6B RID: 11627
				[Token(Token = "0x4002D6B")]
				[FieldOffset(Offset = "0xC")]
				private static readonly int EndDefaultValue;

				// Token: 0x04002D6C RID: 11628
				[Token(Token = "0x4002D6C")]
				[FieldOffset(Offset = "0x20")]
				private int end_;
			}
		}
	}
}
