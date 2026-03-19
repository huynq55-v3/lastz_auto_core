using System;
using System.Diagnostics;
using Google.Protobuf.Collections;
using Il2CppDummyDll;

namespace Google.Protobuf.Reflection
{
	// Token: 0x02000BB0 RID: 2992
	[Token(Token = "0x2000BB0")]
	public sealed class UninterpretedOption : IMessage<UninterpretedOption>, IMessage, IEquatable<UninterpretedOption>, IDeepCloneable<UninterpretedOption>
	{
		// Token: 0x17000984 RID: 2436
		// (get) Token: 0x060072F8 RID: 29432 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000984")]
		[DebuggerNonUserCode]
		public static MessageParser<UninterpretedOption> Parser
		{
			[Token(Token = "0x60072F8")]
			[Address(RVA = "0x31A3718", Offset = "0x31A3718", VA = "0x31A3718")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000985 RID: 2437
		// (get) Token: 0x060072F9 RID: 29433 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000985")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Token(Token = "0x60072F9")]
			[Address(RVA = "0x31A3770", Offset = "0x31A3770", VA = "0x31A3770")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000986 RID: 2438
		// (get) Token: 0x060072FA RID: 29434 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000986")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Token(Token = "0x60072FA")]
			[Address(RVA = "0x31A3874", Offset = "0x31A3874", VA = "0x31A3874", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x060072FB RID: 29435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60072FB")]
		[Address(RVA = "0x31A38C0", Offset = "0x31A38C0", VA = "0x31A38C0")]
		[DebuggerNonUserCode]
		public UninterpretedOption()
		{
		}

		// Token: 0x060072FC RID: 29436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60072FC")]
		[Address(RVA = "0x31A3948", Offset = "0x31A3948", VA = "0x31A3948")]
		[DebuggerNonUserCode]
		public UninterpretedOption(UninterpretedOption other)
		{
		}

		// Token: 0x060072FD RID: 29437 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072FD")]
		[Address(RVA = "0x31A3A1C", Offset = "0x31A3A1C", VA = "0x31A3A1C", Slot = "10")]
		[DebuggerNonUserCode]
		public UninterpretedOption Clone()
		{
			return null;
		}

		// Token: 0x17000987 RID: 2439
		// (get) Token: 0x060072FE RID: 29438 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000987")]
		[DebuggerNonUserCode]
		public RepeatedField<UninterpretedOption.Types.NamePart> Name
		{
			[Token(Token = "0x60072FE")]
			[Address(RVA = "0x31A3A7C", Offset = "0x31A3A7C", VA = "0x31A3A7C")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000988 RID: 2440
		// (get) Token: 0x060072FF RID: 29439 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06007300 RID: 29440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000988")]
		[DebuggerNonUserCode]
		public string IdentifierValue
		{
			[Token(Token = "0x60072FF")]
			[Address(RVA = "0x31A3A84", Offset = "0x31A3A84", VA = "0x31A3A84")]
			get
			{
				return null;
			}
			[Token(Token = "0x6007300")]
			[Address(RVA = "0x31A3AE8", Offset = "0x31A3AE8", VA = "0x31A3AE8")]
			set
			{
			}
		}

		// Token: 0x17000989 RID: 2441
		// (get) Token: 0x06007301 RID: 29441 RVA: 0x00050FD0 File Offset: 0x0004F1D0
		[Token(Token = "0x17000989")]
		[DebuggerNonUserCode]
		public bool HasIdentifierValue
		{
			[Token(Token = "0x6007301")]
			[Address(RVA = "0x31A3B64", Offset = "0x31A3B64", VA = "0x31A3B64")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06007302 RID: 29442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007302")]
		[Address(RVA = "0x31A3B74", Offset = "0x31A3B74", VA = "0x31A3B74")]
		[DebuggerNonUserCode]
		public void ClearIdentifierValue()
		{
		}

		// Token: 0x1700098A RID: 2442
		// (get) Token: 0x06007303 RID: 29443 RVA: 0x00050FE8 File Offset: 0x0004F1E8
		// (set) Token: 0x06007304 RID: 29444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700098A")]
		[DebuggerNonUserCode]
		public ulong PositiveIntValue
		{
			[Token(Token = "0x6007303")]
			[Address(RVA = "0x31A3B80", Offset = "0x31A3B80", VA = "0x31A3B80")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6007304")]
			[Address(RVA = "0x31A3BF0", Offset = "0x31A3BF0", VA = "0x31A3BF0")]
			set
			{
			}
		}

		// Token: 0x1700098B RID: 2443
		// (get) Token: 0x06007305 RID: 29445 RVA: 0x00051000 File Offset: 0x0004F200
		[Token(Token = "0x1700098B")]
		[DebuggerNonUserCode]
		public bool HasPositiveIntValue
		{
			[Token(Token = "0x6007305")]
			[Address(RVA = "0x31A3C04", Offset = "0x31A3C04", VA = "0x31A3C04")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06007306 RID: 29446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007306")]
		[Address(RVA = "0x31A3C10", Offset = "0x31A3C10", VA = "0x31A3C10")]
		[DebuggerNonUserCode]
		public void ClearPositiveIntValue()
		{
		}

		// Token: 0x1700098C RID: 2444
		// (get) Token: 0x06007307 RID: 29447 RVA: 0x00051018 File Offset: 0x0004F218
		// (set) Token: 0x06007308 RID: 29448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700098C")]
		[DebuggerNonUserCode]
		public long NegativeIntValue
		{
			[Token(Token = "0x6007307")]
			[Address(RVA = "0x31A3C20", Offset = "0x31A3C20", VA = "0x31A3C20")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x6007308")]
			[Address(RVA = "0x31A3C90", Offset = "0x31A3C90", VA = "0x31A3C90")]
			set
			{
			}
		}

		// Token: 0x1700098D RID: 2445
		// (get) Token: 0x06007309 RID: 29449 RVA: 0x00051030 File Offset: 0x0004F230
		[Token(Token = "0x1700098D")]
		[DebuggerNonUserCode]
		public bool HasNegativeIntValue
		{
			[Token(Token = "0x6007309")]
			[Address(RVA = "0x31A3CA4", Offset = "0x31A3CA4", VA = "0x31A3CA4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600730A RID: 29450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600730A")]
		[Address(RVA = "0x31A3CB0", Offset = "0x31A3CB0", VA = "0x31A3CB0")]
		[DebuggerNonUserCode]
		public void ClearNegativeIntValue()
		{
		}

		// Token: 0x1700098E RID: 2446
		// (get) Token: 0x0600730B RID: 29451 RVA: 0x00051048 File Offset: 0x0004F248
		// (set) Token: 0x0600730C RID: 29452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700098E")]
		[DebuggerNonUserCode]
		public double DoubleValue
		{
			[Token(Token = "0x600730B")]
			[Address(RVA = "0x31A3CC0", Offset = "0x31A3CC0", VA = "0x31A3CC0")]
			get
			{
				return 0.0;
			}
			[Token(Token = "0x600730C")]
			[Address(RVA = "0x31A3D30", Offset = "0x31A3D30", VA = "0x31A3D30")]
			set
			{
			}
		}

		// Token: 0x1700098F RID: 2447
		// (get) Token: 0x0600730D RID: 29453 RVA: 0x00051060 File Offset: 0x0004F260
		[Token(Token = "0x1700098F")]
		[DebuggerNonUserCode]
		public bool HasDoubleValue
		{
			[Token(Token = "0x600730D")]
			[Address(RVA = "0x31A3D44", Offset = "0x31A3D44", VA = "0x31A3D44")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600730E RID: 29454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600730E")]
		[Address(RVA = "0x31A3D50", Offset = "0x31A3D50", VA = "0x31A3D50")]
		[DebuggerNonUserCode]
		public void ClearDoubleValue()
		{
		}

		// Token: 0x17000990 RID: 2448
		// (get) Token: 0x0600730F RID: 29455 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06007310 RID: 29456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000990")]
		[DebuggerNonUserCode]
		public ByteString StringValue
		{
			[Token(Token = "0x600730F")]
			[Address(RVA = "0x31A3D60", Offset = "0x31A3D60", VA = "0x31A3D60")]
			get
			{
				return null;
			}
			[Token(Token = "0x6007310")]
			[Address(RVA = "0x31A3DC4", Offset = "0x31A3DC4", VA = "0x31A3DC4")]
			set
			{
			}
		}

		// Token: 0x17000991 RID: 2449
		// (get) Token: 0x06007311 RID: 29457 RVA: 0x00051078 File Offset: 0x0004F278
		[Token(Token = "0x17000991")]
		[DebuggerNonUserCode]
		public bool HasStringValue
		{
			[Token(Token = "0x6007311")]
			[Address(RVA = "0x31A3E40", Offset = "0x31A3E40", VA = "0x31A3E40")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06007312 RID: 29458 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007312")]
		[Address(RVA = "0x31A3EA0", Offset = "0x31A3EA0", VA = "0x31A3EA0")]
		[DebuggerNonUserCode]
		public void ClearStringValue()
		{
		}

		// Token: 0x17000992 RID: 2450
		// (get) Token: 0x06007313 RID: 29459 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06007314 RID: 29460 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000992")]
		[DebuggerNonUserCode]
		public string AggregateValue
		{
			[Token(Token = "0x6007313")]
			[Address(RVA = "0x31A3EAC", Offset = "0x31A3EAC", VA = "0x31A3EAC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6007314")]
			[Address(RVA = "0x31A3F10", Offset = "0x31A3F10", VA = "0x31A3F10")]
			set
			{
			}
		}

		// Token: 0x17000993 RID: 2451
		// (get) Token: 0x06007315 RID: 29461 RVA: 0x00051090 File Offset: 0x0004F290
		[Token(Token = "0x17000993")]
		[DebuggerNonUserCode]
		public bool HasAggregateValue
		{
			[Token(Token = "0x6007315")]
			[Address(RVA = "0x31A3F8C", Offset = "0x31A3F8C", VA = "0x31A3F8C")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06007316 RID: 29462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007316")]
		[Address(RVA = "0x31A3F9C", Offset = "0x31A3F9C", VA = "0x31A3F9C")]
		[DebuggerNonUserCode]
		public void ClearAggregateValue()
		{
		}

		// Token: 0x06007317 RID: 29463 RVA: 0x000510A8 File Offset: 0x0004F2A8
		[Token(Token = "0x6007317")]
		[Address(RVA = "0x31A3FA8", Offset = "0x31A3FA8", VA = "0x31A3FA8", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06007318 RID: 29464 RVA: 0x000510C0 File Offset: 0x0004F2C0
		[Token(Token = "0x6007318")]
		[Address(RVA = "0x31A400C", Offset = "0x31A400C", VA = "0x31A400C", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(UninterpretedOption other)
		{
			return default(bool);
		}

		// Token: 0x06007319 RID: 29465 RVA: 0x000510D8 File Offset: 0x0004F2D8
		[Token(Token = "0x6007319")]
		[Address(RVA = "0x31A4224", Offset = "0x31A4224", VA = "0x31A4224", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600731A RID: 29466 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600731A")]
		[Address(RVA = "0x31A43EC", Offset = "0x31A43EC", VA = "0x31A43EC", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600731B RID: 29467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600731B")]
		[Address(RVA = "0x31A4444", Offset = "0x31A4444", VA = "0x31A4444", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600731C RID: 29468 RVA: 0x000510F0 File Offset: 0x0004F2F0
		[Token(Token = "0x600731C")]
		[Address(RVA = "0x31A4634", Offset = "0x31A4634", VA = "0x31A4634", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600731D RID: 29469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600731D")]
		[Address(RVA = "0x31A4834", Offset = "0x31A4834", VA = "0x31A4834", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(UninterpretedOption other)
		{
		}

		// Token: 0x0600731E RID: 29470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600731E")]
		[Address(RVA = "0x31A4980", Offset = "0x31A4980", VA = "0x31A4980", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x04002EB8 RID: 11960
		[Token(Token = "0x4002EB8")]
		[FieldOffset(Offset = "0x0")]
		private static readonly MessageParser<UninterpretedOption> _parser;

		// Token: 0x04002EB9 RID: 11961
		[Token(Token = "0x4002EB9")]
		[FieldOffset(Offset = "0x10")]
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002EBA RID: 11962
		[Token(Token = "0x4002EBA")]
		[FieldOffset(Offset = "0x18")]
		private int _hasBits0;

		// Token: 0x04002EBB RID: 11963
		[Token(Token = "0x4002EBB")]
		public const int NameFieldNumber = 2;

		// Token: 0x04002EBC RID: 11964
		[Token(Token = "0x4002EBC")]
		[FieldOffset(Offset = "0x8")]
		private static readonly FieldCodec<UninterpretedOption.Types.NamePart> _repeated_name_codec;

		// Token: 0x04002EBD RID: 11965
		[Token(Token = "0x4002EBD")]
		[FieldOffset(Offset = "0x20")]
		private readonly RepeatedField<UninterpretedOption.Types.NamePart> name_;

		// Token: 0x04002EBE RID: 11966
		[Token(Token = "0x4002EBE")]
		public const int IdentifierValueFieldNumber = 3;

		// Token: 0x04002EBF RID: 11967
		[Token(Token = "0x4002EBF")]
		[FieldOffset(Offset = "0x10")]
		private static readonly string IdentifierValueDefaultValue;

		// Token: 0x04002EC0 RID: 11968
		[Token(Token = "0x4002EC0")]
		[FieldOffset(Offset = "0x28")]
		private string identifierValue_;

		// Token: 0x04002EC1 RID: 11969
		[Token(Token = "0x4002EC1")]
		public const int PositiveIntValueFieldNumber = 4;

		// Token: 0x04002EC2 RID: 11970
		[Token(Token = "0x4002EC2")]
		[FieldOffset(Offset = "0x18")]
		private static readonly ulong PositiveIntValueDefaultValue;

		// Token: 0x04002EC3 RID: 11971
		[Token(Token = "0x4002EC3")]
		[FieldOffset(Offset = "0x30")]
		private ulong positiveIntValue_;

		// Token: 0x04002EC4 RID: 11972
		[Token(Token = "0x4002EC4")]
		public const int NegativeIntValueFieldNumber = 5;

		// Token: 0x04002EC5 RID: 11973
		[Token(Token = "0x4002EC5")]
		[FieldOffset(Offset = "0x20")]
		private static readonly long NegativeIntValueDefaultValue;

		// Token: 0x04002EC6 RID: 11974
		[Token(Token = "0x4002EC6")]
		[FieldOffset(Offset = "0x38")]
		private long negativeIntValue_;

		// Token: 0x04002EC7 RID: 11975
		[Token(Token = "0x4002EC7")]
		public const int DoubleValueFieldNumber = 6;

		// Token: 0x04002EC8 RID: 11976
		[Token(Token = "0x4002EC8")]
		[FieldOffset(Offset = "0x28")]
		private static readonly double DoubleValueDefaultValue;

		// Token: 0x04002EC9 RID: 11977
		[Token(Token = "0x4002EC9")]
		[FieldOffset(Offset = "0x40")]
		private double doubleValue_;

		// Token: 0x04002ECA RID: 11978
		[Token(Token = "0x4002ECA")]
		public const int StringValueFieldNumber = 7;

		// Token: 0x04002ECB RID: 11979
		[Token(Token = "0x4002ECB")]
		[FieldOffset(Offset = "0x30")]
		private static readonly ByteString StringValueDefaultValue;

		// Token: 0x04002ECC RID: 11980
		[Token(Token = "0x4002ECC")]
		[FieldOffset(Offset = "0x48")]
		private ByteString stringValue_;

		// Token: 0x04002ECD RID: 11981
		[Token(Token = "0x4002ECD")]
		public const int AggregateValueFieldNumber = 8;

		// Token: 0x04002ECE RID: 11982
		[Token(Token = "0x4002ECE")]
		[FieldOffset(Offset = "0x38")]
		private static readonly string AggregateValueDefaultValue;

		// Token: 0x04002ECF RID: 11983
		[Token(Token = "0x4002ECF")]
		[FieldOffset(Offset = "0x50")]
		private string aggregateValue_;

		// Token: 0x02000BB1 RID: 2993
		[Token(Token = "0x2000BB1")]
		[DebuggerNonUserCode]
		public static class Types
		{
			// Token: 0x02000BB2 RID: 2994
			[Token(Token = "0x2000BB2")]
			public sealed class NamePart : IMessage<UninterpretedOption.Types.NamePart>, IMessage, IEquatable<UninterpretedOption.Types.NamePart>, IDeepCloneable<UninterpretedOption.Types.NamePart>
			{
				// Token: 0x17000994 RID: 2452
				// (get) Token: 0x06007320 RID: 29472 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x17000994")]
				[DebuggerNonUserCode]
				public static MessageParser<UninterpretedOption.Types.NamePart> Parser
				{
					[Token(Token = "0x6007320")]
					[Address(RVA = "0x31A4DD0", Offset = "0x31A4DD0", VA = "0x31A4DD0")]
					get
					{
						return null;
					}
				}

				// Token: 0x17000995 RID: 2453
				// (get) Token: 0x06007321 RID: 29473 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x17000995")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Token(Token = "0x6007321")]
					[Address(RVA = "0x31A4E28", Offset = "0x31A4E28", VA = "0x31A4E28")]
					get
					{
						return null;
					}
				}

				// Token: 0x17000996 RID: 2454
				// (get) Token: 0x06007322 RID: 29474 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x17000996")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
				{
					[Token(Token = "0x6007322")]
					[Address(RVA = "0x31A4EF4", Offset = "0x31A4EF4", VA = "0x31A4EF4", Slot = "8")]
					get
					{
						return null;
					}
				}

				// Token: 0x06007323 RID: 29475 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6007323")]
				[Address(RVA = "0x31A4F40", Offset = "0x31A4F40", VA = "0x31A4F40")]
				[DebuggerNonUserCode]
				public NamePart()
				{
				}

				// Token: 0x06007324 RID: 29476 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6007324")]
				[Address(RVA = "0x31A4F48", Offset = "0x31A4F48", VA = "0x31A4F48")]
				[DebuggerNonUserCode]
				public NamePart(UninterpretedOption.Types.NamePart other)
				{
				}

				// Token: 0x06007325 RID: 29477 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6007325")]
				[Address(RVA = "0x31A4FAC", Offset = "0x31A4FAC", VA = "0x31A4FAC", Slot = "10")]
				[DebuggerNonUserCode]
				public UninterpretedOption.Types.NamePart Clone()
				{
					return null;
				}

				// Token: 0x17000997 RID: 2455
				// (get) Token: 0x06007326 RID: 29478 RVA: 0x00002050 File Offset: 0x00000250
				// (set) Token: 0x06007327 RID: 29479 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x17000997")]
				[DebuggerNonUserCode]
				public string NamePart_
				{
					[Token(Token = "0x6007326")]
					[Address(RVA = "0x31A500C", Offset = "0x31A500C", VA = "0x31A500C")]
					get
					{
						return null;
					}
					[Token(Token = "0x6007327")]
					[Address(RVA = "0x31A5070", Offset = "0x31A5070", VA = "0x31A5070")]
					set
					{
					}
				}

				// Token: 0x17000998 RID: 2456
				// (get) Token: 0x06007328 RID: 29480 RVA: 0x00051108 File Offset: 0x0004F308
				[Token(Token = "0x17000998")]
				[DebuggerNonUserCode]
				public bool HasNamePart_
				{
					[Token(Token = "0x6007328")]
					[Address(RVA = "0x31A50EC", Offset = "0x31A50EC", VA = "0x31A50EC")]
					get
					{
						return default(bool);
					}
				}

				// Token: 0x06007329 RID: 29481 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6007329")]
				[Address(RVA = "0x31A50FC", Offset = "0x31A50FC", VA = "0x31A50FC")]
				[DebuggerNonUserCode]
				public void ClearNamePart_()
				{
				}

				// Token: 0x17000999 RID: 2457
				// (get) Token: 0x0600732A RID: 29482 RVA: 0x00051120 File Offset: 0x0004F320
				// (set) Token: 0x0600732B RID: 29483 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x17000999")]
				[DebuggerNonUserCode]
				public bool IsExtension
				{
					[Token(Token = "0x600732A")]
					[Address(RVA = "0x31A5108", Offset = "0x31A5108", VA = "0x31A5108")]
					get
					{
						return default(bool);
					}
					[Token(Token = "0x600732B")]
					[Address(RVA = "0x31A5178", Offset = "0x31A5178", VA = "0x31A5178")]
					set
					{
					}
				}

				// Token: 0x1700099A RID: 2458
				// (get) Token: 0x0600732C RID: 29484 RVA: 0x00051138 File Offset: 0x0004F338
				[Token(Token = "0x1700099A")]
				[DebuggerNonUserCode]
				public bool HasIsExtension
				{
					[Token(Token = "0x600732C")]
					[Address(RVA = "0x31A5190", Offset = "0x31A5190", VA = "0x31A5190")]
					get
					{
						return default(bool);
					}
				}

				// Token: 0x0600732D RID: 29485 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600732D")]
				[Address(RVA = "0x31A519C", Offset = "0x31A519C", VA = "0x31A519C")]
				[DebuggerNonUserCode]
				public void ClearIsExtension()
				{
				}

				// Token: 0x0600732E RID: 29486 RVA: 0x00051150 File Offset: 0x0004F350
				[Token(Token = "0x600732E")]
				[Address(RVA = "0x31A51AC", Offset = "0x31A51AC", VA = "0x31A51AC", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				// Token: 0x0600732F RID: 29487 RVA: 0x00051168 File Offset: 0x0004F368
				[Token(Token = "0x600732F")]
				[Address(RVA = "0x31A5210", Offset = "0x31A5210", VA = "0x31A5210", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(UninterpretedOption.Types.NamePart other)
				{
					return default(bool);
				}

				// Token: 0x06007330 RID: 29488 RVA: 0x00051180 File Offset: 0x0004F380
				[Token(Token = "0x6007330")]
				[Address(RVA = "0x31A52A0", Offset = "0x31A52A0", VA = "0x31A52A0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x06007331 RID: 29489 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6007331")]
				[Address(RVA = "0x31A5374", Offset = "0x31A5374", VA = "0x31A5374", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x06007332 RID: 29490 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6007332")]
				[Address(RVA = "0x31A53CC", Offset = "0x31A53CC", VA = "0x31A53CC", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x06007333 RID: 29491 RVA: 0x00051198 File Offset: 0x0004F398
				[Token(Token = "0x6007333")]
				[Address(RVA = "0x31A5470", Offset = "0x31A5470", VA = "0x31A5470", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x06007334 RID: 29492 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6007334")]
				[Address(RVA = "0x31A5510", Offset = "0x31A5510", VA = "0x31A5510", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(UninterpretedOption.Types.NamePart other)
				{
				}

				// Token: 0x06007335 RID: 29493 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6007335")]
				[Address(RVA = "0x31A5590", Offset = "0x31A5590", VA = "0x31A5590", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x04002ED0 RID: 11984
				[Token(Token = "0x4002ED0")]
				[FieldOffset(Offset = "0x0")]
				private static readonly MessageParser<UninterpretedOption.Types.NamePart> _parser;

				// Token: 0x04002ED1 RID: 11985
				[Token(Token = "0x4002ED1")]
				[FieldOffset(Offset = "0x10")]
				private UnknownFieldSet _unknownFields;

				// Token: 0x04002ED2 RID: 11986
				[Token(Token = "0x4002ED2")]
				[FieldOffset(Offset = "0x18")]
				private int _hasBits0;

				// Token: 0x04002ED3 RID: 11987
				[Token(Token = "0x4002ED3")]
				public const int NamePart_FieldNumber = 1;

				// Token: 0x04002ED4 RID: 11988
				[Token(Token = "0x4002ED4")]
				[FieldOffset(Offset = "0x8")]
				private static readonly string NamePart_DefaultValue;

				// Token: 0x04002ED5 RID: 11989
				[Token(Token = "0x4002ED5")]
				[FieldOffset(Offset = "0x20")]
				private string namePart_;

				// Token: 0x04002ED6 RID: 11990
				[Token(Token = "0x4002ED6")]
				public const int IsExtensionFieldNumber = 2;

				// Token: 0x04002ED7 RID: 11991
				[Token(Token = "0x4002ED7")]
				[FieldOffset(Offset = "0x10")]
				private static readonly bool IsExtensionDefaultValue;

				// Token: 0x04002ED8 RID: 11992
				[Token(Token = "0x4002ED8")]
				[FieldOffset(Offset = "0x28")]
				private bool isExtension_;
			}
		}
	}
}
