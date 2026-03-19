using System;
using System.Diagnostics;
using Google.Protobuf.Collections;
using Il2CppDummyDll;

namespace Google.Protobuf.Reflection
{
	// Token: 0x02000BB5 RID: 2997
	[Token(Token = "0x2000BB5")]
	public sealed class SourceCodeInfo : IMessage<SourceCodeInfo>, IMessage, IEquatable<SourceCodeInfo>, IDeepCloneable<SourceCodeInfo>
	{
		// Token: 0x1700099B RID: 2459
		// (get) Token: 0x0600733D RID: 29501 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700099B")]
		[DebuggerNonUserCode]
		public static MessageParser<SourceCodeInfo> Parser
		{
			[Token(Token = "0x600733D")]
			[Address(RVA = "0x31A5934", Offset = "0x31A5934", VA = "0x31A5934")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700099C RID: 2460
		// (get) Token: 0x0600733E RID: 29502 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700099C")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Token(Token = "0x600733E")]
			[Address(RVA = "0x31A598C", Offset = "0x31A598C", VA = "0x31A598C")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700099D RID: 2461
		// (get) Token: 0x0600733F RID: 29503 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700099D")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Token(Token = "0x600733F")]
			[Address(RVA = "0x31A5A90", Offset = "0x31A5A90", VA = "0x31A5A90", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06007340 RID: 29504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007340")]
		[Address(RVA = "0x31A5ADC", Offset = "0x31A5ADC", VA = "0x31A5ADC")]
		[DebuggerNonUserCode]
		public SourceCodeInfo()
		{
		}

		// Token: 0x06007341 RID: 29505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007341")]
		[Address(RVA = "0x31A5B64", Offset = "0x31A5B64", VA = "0x31A5B64")]
		[DebuggerNonUserCode]
		public SourceCodeInfo(SourceCodeInfo other)
		{
		}

		// Token: 0x06007342 RID: 29506 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007342")]
		[Address(RVA = "0x31A5BF0", Offset = "0x31A5BF0", VA = "0x31A5BF0", Slot = "10")]
		[DebuggerNonUserCode]
		public SourceCodeInfo Clone()
		{
			return null;
		}

		// Token: 0x1700099E RID: 2462
		// (get) Token: 0x06007343 RID: 29507 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700099E")]
		[DebuggerNonUserCode]
		public RepeatedField<SourceCodeInfo.Types.Location> Location
		{
			[Token(Token = "0x6007343")]
			[Address(RVA = "0x31A5C50", Offset = "0x31A5C50", VA = "0x31A5C50")]
			get
			{
				return null;
			}
		}

		// Token: 0x06007344 RID: 29508 RVA: 0x000511B0 File Offset: 0x0004F3B0
		[Token(Token = "0x6007344")]
		[Address(RVA = "0x31A5C58", Offset = "0x31A5C58", VA = "0x31A5C58", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06007345 RID: 29509 RVA: 0x000511C8 File Offset: 0x0004F3C8
		[Token(Token = "0x6007345")]
		[Address(RVA = "0x31A5CBC", Offset = "0x31A5CBC", VA = "0x31A5CBC", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(SourceCodeInfo other)
		{
			return default(bool);
		}

		// Token: 0x06007346 RID: 29510 RVA: 0x000511E0 File Offset: 0x0004F3E0
		[Token(Token = "0x6007346")]
		[Address(RVA = "0x31A5D4C", Offset = "0x31A5D4C", VA = "0x31A5D4C", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06007347 RID: 29511 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007347")]
		[Address(RVA = "0x31A5D98", Offset = "0x31A5D98", VA = "0x31A5D98", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06007348 RID: 29512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007348")]
		[Address(RVA = "0x31A5DF0", Offset = "0x31A5DF0", VA = "0x31A5DF0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06007349 RID: 29513 RVA: 0x000511F8 File Offset: 0x0004F3F8
		[Token(Token = "0x6007349")]
		[Address(RVA = "0x31A5EA8", Offset = "0x31A5EA8", VA = "0x31A5EA8", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600734A RID: 29514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600734A")]
		[Address(RVA = "0x31A5F50", Offset = "0x31A5F50", VA = "0x31A5F50", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(SourceCodeInfo other)
		{
		}

		// Token: 0x0600734B RID: 29515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600734B")]
		[Address(RVA = "0x31A5FD8", Offset = "0x31A5FD8", VA = "0x31A5FD8", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x04002EDB RID: 11995
		[Token(Token = "0x4002EDB")]
		[FieldOffset(Offset = "0x0")]
		private static readonly MessageParser<SourceCodeInfo> _parser;

		// Token: 0x04002EDC RID: 11996
		[Token(Token = "0x4002EDC")]
		[FieldOffset(Offset = "0x10")]
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002EDD RID: 11997
		[Token(Token = "0x4002EDD")]
		public const int LocationFieldNumber = 1;

		// Token: 0x04002EDE RID: 11998
		[Token(Token = "0x4002EDE")]
		[FieldOffset(Offset = "0x8")]
		private static readonly FieldCodec<SourceCodeInfo.Types.Location> _repeated_location_codec;

		// Token: 0x04002EDF RID: 11999
		[Token(Token = "0x4002EDF")]
		[FieldOffset(Offset = "0x18")]
		private readonly RepeatedField<SourceCodeInfo.Types.Location> location_;

		// Token: 0x02000BB6 RID: 2998
		[Token(Token = "0x2000BB6")]
		[DebuggerNonUserCode]
		public static class Types
		{
			// Token: 0x02000BB7 RID: 2999
			[Token(Token = "0x2000BB7")]
			public sealed class Location : IMessage<SourceCodeInfo.Types.Location>, IMessage, IEquatable<SourceCodeInfo.Types.Location>, IDeepCloneable<SourceCodeInfo.Types.Location>
			{
				// Token: 0x1700099F RID: 2463
				// (get) Token: 0x0600734D RID: 29517 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x1700099F")]
				[DebuggerNonUserCode]
				public static MessageParser<SourceCodeInfo.Types.Location> Parser
				{
					[Token(Token = "0x600734D")]
					[Address(RVA = "0x31A6274", Offset = "0x31A6274", VA = "0x31A6274")]
					get
					{
						return null;
					}
				}

				// Token: 0x170009A0 RID: 2464
				// (get) Token: 0x0600734E RID: 29518 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x170009A0")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Token(Token = "0x600734E")]
					[Address(RVA = "0x31A62CC", Offset = "0x31A62CC", VA = "0x31A62CC")]
					get
					{
						return null;
					}
				}

				// Token: 0x170009A1 RID: 2465
				// (get) Token: 0x0600734F RID: 29519 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x170009A1")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
				{
					[Token(Token = "0x600734F")]
					[Address(RVA = "0x31A6398", Offset = "0x31A6398", VA = "0x31A6398", Slot = "8")]
					get
					{
						return null;
					}
				}

				// Token: 0x06007350 RID: 29520 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6007350")]
				[Address(RVA = "0x31A63E4", Offset = "0x31A63E4", VA = "0x31A63E4")]
				[DebuggerNonUserCode]
				public Location()
				{
				}

				// Token: 0x06007351 RID: 29521 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6007351")]
				[Address(RVA = "0x31A64EC", Offset = "0x31A64EC", VA = "0x31A64EC")]
				[DebuggerNonUserCode]
				public Location(SourceCodeInfo.Types.Location other)
				{
				}

				// Token: 0x06007352 RID: 29522 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6007352")]
				[Address(RVA = "0x31A65EC", Offset = "0x31A65EC", VA = "0x31A65EC", Slot = "10")]
				[DebuggerNonUserCode]
				public SourceCodeInfo.Types.Location Clone()
				{
					return null;
				}

				// Token: 0x170009A2 RID: 2466
				// (get) Token: 0x06007353 RID: 29523 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x170009A2")]
				[DebuggerNonUserCode]
				public RepeatedField<int> Path
				{
					[Token(Token = "0x6007353")]
					[Address(RVA = "0x31A664C", Offset = "0x31A664C", VA = "0x31A664C")]
					get
					{
						return null;
					}
				}

				// Token: 0x170009A3 RID: 2467
				// (get) Token: 0x06007354 RID: 29524 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x170009A3")]
				[DebuggerNonUserCode]
				public RepeatedField<int> Span
				{
					[Token(Token = "0x6007354")]
					[Address(RVA = "0x31A6654", Offset = "0x31A6654", VA = "0x31A6654")]
					get
					{
						return null;
					}
				}

				// Token: 0x170009A4 RID: 2468
				// (get) Token: 0x06007355 RID: 29525 RVA: 0x00002050 File Offset: 0x00000250
				// (set) Token: 0x06007356 RID: 29526 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x170009A4")]
				[DebuggerNonUserCode]
				public string LeadingComments
				{
					[Token(Token = "0x6007355")]
					[Address(RVA = "0x31A665C", Offset = "0x31A665C", VA = "0x31A665C")]
					get
					{
						return null;
					}
					[Token(Token = "0x6007356")]
					[Address(RVA = "0x31A66C0", Offset = "0x31A66C0", VA = "0x31A66C0")]
					set
					{
					}
				}

				// Token: 0x170009A5 RID: 2469
				// (get) Token: 0x06007357 RID: 29527 RVA: 0x00051210 File Offset: 0x0004F410
				[Token(Token = "0x170009A5")]
				[DebuggerNonUserCode]
				public bool HasLeadingComments
				{
					[Token(Token = "0x6007357")]
					[Address(RVA = "0x31A673C", Offset = "0x31A673C", VA = "0x31A673C")]
					get
					{
						return default(bool);
					}
				}

				// Token: 0x06007358 RID: 29528 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6007358")]
				[Address(RVA = "0x31A674C", Offset = "0x31A674C", VA = "0x31A674C")]
				[DebuggerNonUserCode]
				public void ClearLeadingComments()
				{
				}

				// Token: 0x170009A6 RID: 2470
				// (get) Token: 0x06007359 RID: 29529 RVA: 0x00002050 File Offset: 0x00000250
				// (set) Token: 0x0600735A RID: 29530 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x170009A6")]
				[DebuggerNonUserCode]
				public string TrailingComments
				{
					[Token(Token = "0x6007359")]
					[Address(RVA = "0x31A6758", Offset = "0x31A6758", VA = "0x31A6758")]
					get
					{
						return null;
					}
					[Token(Token = "0x600735A")]
					[Address(RVA = "0x31A67BC", Offset = "0x31A67BC", VA = "0x31A67BC")]
					set
					{
					}
				}

				// Token: 0x170009A7 RID: 2471
				// (get) Token: 0x0600735B RID: 29531 RVA: 0x00051228 File Offset: 0x0004F428
				[Token(Token = "0x170009A7")]
				[DebuggerNonUserCode]
				public bool HasTrailingComments
				{
					[Token(Token = "0x600735B")]
					[Address(RVA = "0x31A6838", Offset = "0x31A6838", VA = "0x31A6838")]
					get
					{
						return default(bool);
					}
				}

				// Token: 0x0600735C RID: 29532 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600735C")]
				[Address(RVA = "0x31A6848", Offset = "0x31A6848", VA = "0x31A6848")]
				[DebuggerNonUserCode]
				public void ClearTrailingComments()
				{
				}

				// Token: 0x170009A8 RID: 2472
				// (get) Token: 0x0600735D RID: 29533 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x170009A8")]
				[DebuggerNonUserCode]
				public RepeatedField<string> LeadingDetachedComments
				{
					[Token(Token = "0x600735D")]
					[Address(RVA = "0x31A6854", Offset = "0x31A6854", VA = "0x31A6854")]
					get
					{
						return null;
					}
				}

				// Token: 0x0600735E RID: 29534 RVA: 0x00051240 File Offset: 0x0004F440
				[Token(Token = "0x600735E")]
				[Address(RVA = "0x31A685C", Offset = "0x31A685C", VA = "0x31A685C", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				// Token: 0x0600735F RID: 29535 RVA: 0x00051258 File Offset: 0x0004F458
				[Token(Token = "0x600735F")]
				[Address(RVA = "0x31A68C0", Offset = "0x31A68C0", VA = "0x31A68C0", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(SourceCodeInfo.Types.Location other)
				{
					return default(bool);
				}

				// Token: 0x06007360 RID: 29536 RVA: 0x00051270 File Offset: 0x0004F470
				[Token(Token = "0x6007360")]
				[Address(RVA = "0x31A69E4", Offset = "0x31A69E4", VA = "0x31A69E4", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x06007361 RID: 29537 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6007361")]
				[Address(RVA = "0x31A6AB8", Offset = "0x31A6AB8", VA = "0x31A6AB8", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x06007362 RID: 29538 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6007362")]
				[Address(RVA = "0x31A6B10", Offset = "0x31A6B10", VA = "0x31A6B10", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x06007363 RID: 29539 RVA: 0x00051288 File Offset: 0x0004F488
				[Token(Token = "0x6007363")]
				[Address(RVA = "0x31A6C98", Offset = "0x31A6C98", VA = "0x31A6C98", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x06007364 RID: 29540 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6007364")]
				[Address(RVA = "0x31A6E40", Offset = "0x31A6E40", VA = "0x31A6E40", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(SourceCodeInfo.Types.Location other)
				{
				}

				// Token: 0x06007365 RID: 29541 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6007365")]
				[Address(RVA = "0x31A6F3C", Offset = "0x31A6F3C", VA = "0x31A6F3C", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x04002EE0 RID: 12000
				[Token(Token = "0x4002EE0")]
				[FieldOffset(Offset = "0x0")]
				private static readonly MessageParser<SourceCodeInfo.Types.Location> _parser;

				// Token: 0x04002EE1 RID: 12001
				[Token(Token = "0x4002EE1")]
				[FieldOffset(Offset = "0x10")]
				private UnknownFieldSet _unknownFields;

				// Token: 0x04002EE2 RID: 12002
				[Token(Token = "0x4002EE2")]
				public const int PathFieldNumber = 1;

				// Token: 0x04002EE3 RID: 12003
				[Token(Token = "0x4002EE3")]
				[FieldOffset(Offset = "0x8")]
				private static readonly FieldCodec<int> _repeated_path_codec;

				// Token: 0x04002EE4 RID: 12004
				[Token(Token = "0x4002EE4")]
				[FieldOffset(Offset = "0x18")]
				private readonly RepeatedField<int> path_;

				// Token: 0x04002EE5 RID: 12005
				[Token(Token = "0x4002EE5")]
				public const int SpanFieldNumber = 2;

				// Token: 0x04002EE6 RID: 12006
				[Token(Token = "0x4002EE6")]
				[FieldOffset(Offset = "0x10")]
				private static readonly FieldCodec<int> _repeated_span_codec;

				// Token: 0x04002EE7 RID: 12007
				[Token(Token = "0x4002EE7")]
				[FieldOffset(Offset = "0x20")]
				private readonly RepeatedField<int> span_;

				// Token: 0x04002EE8 RID: 12008
				[Token(Token = "0x4002EE8")]
				public const int LeadingCommentsFieldNumber = 3;

				// Token: 0x04002EE9 RID: 12009
				[Token(Token = "0x4002EE9")]
				[FieldOffset(Offset = "0x18")]
				private static readonly string LeadingCommentsDefaultValue;

				// Token: 0x04002EEA RID: 12010
				[Token(Token = "0x4002EEA")]
				[FieldOffset(Offset = "0x28")]
				private string leadingComments_;

				// Token: 0x04002EEB RID: 12011
				[Token(Token = "0x4002EEB")]
				public const int TrailingCommentsFieldNumber = 4;

				// Token: 0x04002EEC RID: 12012
				[Token(Token = "0x4002EEC")]
				[FieldOffset(Offset = "0x20")]
				private static readonly string TrailingCommentsDefaultValue;

				// Token: 0x04002EED RID: 12013
				[Token(Token = "0x4002EED")]
				[FieldOffset(Offset = "0x30")]
				private string trailingComments_;

				// Token: 0x04002EEE RID: 12014
				[Token(Token = "0x4002EEE")]
				public const int LeadingDetachedCommentsFieldNumber = 6;

				// Token: 0x04002EEF RID: 12015
				[Token(Token = "0x4002EEF")]
				[FieldOffset(Offset = "0x28")]
				private static readonly FieldCodec<string> _repeated_leadingDetachedComments_codec;

				// Token: 0x04002EF0 RID: 12016
				[Token(Token = "0x4002EF0")]
				[FieldOffset(Offset = "0x38")]
				private readonly RepeatedField<string> leadingDetachedComments_;
			}
		}
	}
}
