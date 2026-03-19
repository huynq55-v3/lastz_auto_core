using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Protobuf
{
	// Token: 0x020003FB RID: 1019
	[Token(Token = "0x20003FB")]
	public sealed class UnitEffectReason : IMessage<UnitEffectReason>, IMessage, IEquatable<UnitEffectReason>, IDeepCloneable<UnitEffectReason>
	{
		// Token: 0x170002C2 RID: 706
		// (get) Token: 0x06001A67 RID: 6759 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002C2")]
		[DebuggerNonUserCode]
		public static MessageParser<UnitEffectReason> Parser
		{
			[Token(Token = "0x6001A67")]
			[Address(RVA = "0x20E5E70", Offset = "0x20E5E70", VA = "0x20E5E70")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002C3 RID: 707
		// (get) Token: 0x06001A68 RID: 6760 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002C3")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Token(Token = "0x6001A68")]
			[Address(RVA = "0x20E5EC8", Offset = "0x20E5EC8", VA = "0x20E5EC8")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002C4 RID: 708
		// (get) Token: 0x06001A69 RID: 6761 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002C4")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Token(Token = "0x6001A69")]
			[Address(RVA = "0x20E5FCC", Offset = "0x20E5FCC", VA = "0x20E5FCC", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001A6A RID: 6762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A6A")]
		[Address(RVA = "0x20E6018", Offset = "0x20E6018", VA = "0x20E6018")]
		[DebuggerNonUserCode]
		public UnitEffectReason()
		{
		}

		// Token: 0x06001A6B RID: 6763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A6B")]
		[Address(RVA = "0x20E60A0", Offset = "0x20E60A0", VA = "0x20E60A0")]
		[DebuggerNonUserCode]
		public UnitEffectReason(UnitEffectReason other)
		{
		}

		// Token: 0x06001A6C RID: 6764 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A6C")]
		[Address(RVA = "0x20E6134", Offset = "0x20E6134", VA = "0x20E6134", Slot = "10")]
		[DebuggerNonUserCode]
		public UnitEffectReason Clone()
		{
			return null;
		}

		// Token: 0x170002C5 RID: 709
		// (get) Token: 0x06001A6D RID: 6765 RVA: 0x0000A1E8 File Offset: 0x000083E8
		// (set) Token: 0x06001A6E RID: 6766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170002C5")]
		[DebuggerNonUserCode]
		public int EffectId
		{
			[Token(Token = "0x6001A6D")]
			[Address(RVA = "0x20E6194", Offset = "0x20E6194", VA = "0x20E6194")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001A6E")]
			[Address(RVA = "0x20E619C", Offset = "0x20E619C", VA = "0x20E619C")]
			set
			{
			}
		}

		// Token: 0x170002C6 RID: 710
		// (get) Token: 0x06001A6F RID: 6767 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002C6")]
		[DebuggerNonUserCode]
		public RepeatedField<EffectReason> Reasons
		{
			[Token(Token = "0x6001A6F")]
			[Address(RVA = "0x20E61A4", Offset = "0x20E61A4", VA = "0x20E61A4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001A70 RID: 6768 RVA: 0x0000A200 File Offset: 0x00008400
		[Token(Token = "0x6001A70")]
		[Address(RVA = "0x20E61AC", Offset = "0x20E61AC", VA = "0x20E61AC", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06001A71 RID: 6769 RVA: 0x0000A218 File Offset: 0x00008418
		[Token(Token = "0x6001A71")]
		[Address(RVA = "0x20E6210", Offset = "0x20E6210", VA = "0x20E6210", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(UnitEffectReason other)
		{
			return default(bool);
		}

		// Token: 0x06001A72 RID: 6770 RVA: 0x0000A230 File Offset: 0x00008430
		[Token(Token = "0x6001A72")]
		[Address(RVA = "0x20E62B0", Offset = "0x20E62B0", VA = "0x20E62B0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001A73 RID: 6771 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A73")]
		[Address(RVA = "0x20E632C", Offset = "0x20E632C", VA = "0x20E632C", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001A74 RID: 6772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A74")]
		[Address(RVA = "0x20E6384", Offset = "0x20E6384", VA = "0x20E6384", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06001A75 RID: 6773 RVA: 0x0000A248 File Offset: 0x00008448
		[Token(Token = "0x6001A75")]
		[Address(RVA = "0x20E6468", Offset = "0x20E6468", VA = "0x20E6468", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06001A76 RID: 6774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A76")]
		[Address(RVA = "0x20E655C", Offset = "0x20E655C", VA = "0x20E655C", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(UnitEffectReason other)
		{
		}

		// Token: 0x06001A77 RID: 6775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A77")]
		[Address(RVA = "0x20E65F0", Offset = "0x20E65F0", VA = "0x20E65F0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x04001C2F RID: 7215
		[Token(Token = "0x4001C2F")]
		[FieldOffset(Offset = "0x0")]
		private static readonly MessageParser<UnitEffectReason> _parser;

		// Token: 0x04001C30 RID: 7216
		[Token(Token = "0x4001C30")]
		[FieldOffset(Offset = "0x10")]
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001C31 RID: 7217
		[Token(Token = "0x4001C31")]
		public const int EffectIdFieldNumber = 1;

		// Token: 0x04001C32 RID: 7218
		[Token(Token = "0x4001C32")]
		[FieldOffset(Offset = "0x18")]
		private int effectId_;

		// Token: 0x04001C33 RID: 7219
		[Token(Token = "0x4001C33")]
		public const int ReasonsFieldNumber = 2;

		// Token: 0x04001C34 RID: 7220
		[Token(Token = "0x4001C34")]
		[FieldOffset(Offset = "0x8")]
		private static readonly FieldCodec<EffectReason> _repeated_reasons_codec;

		// Token: 0x04001C35 RID: 7221
		[Token(Token = "0x4001C35")]
		[FieldOffset(Offset = "0x20")]
		private readonly RepeatedField<EffectReason> reasons_;
	}
}
