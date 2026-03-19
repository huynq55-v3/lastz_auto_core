using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Protobuf
{
	// Token: 0x020003EA RID: 1002
	[Token(Token = "0x20003EA")]
	public sealed class WorldAllAllianceCityInfo : IMessage<WorldAllAllianceCityInfo>, IMessage, IEquatable<WorldAllAllianceCityInfo>, IDeepCloneable<WorldAllAllianceCityInfo>
	{
		// Token: 0x1700027D RID: 637
		// (get) Token: 0x0600198B RID: 6539 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700027D")]
		[DebuggerNonUserCode]
		public static MessageParser<WorldAllAllianceCityInfo> Parser
		{
			[Token(Token = "0x600198B")]
			[Address(RVA = "0x20DB290", Offset = "0x20DB290", VA = "0x20DB290")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700027E RID: 638
		// (get) Token: 0x0600198C RID: 6540 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700027E")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Token(Token = "0x600198C")]
			[Address(RVA = "0x20DB2E8", Offset = "0x20DB2E8", VA = "0x20DB2E8")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700027F RID: 639
		// (get) Token: 0x0600198D RID: 6541 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700027F")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Token(Token = "0x600198D")]
			[Address(RVA = "0x20DB3EC", Offset = "0x20DB3EC", VA = "0x20DB3EC", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600198E RID: 6542 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600198E")]
		[Address(RVA = "0x20DB438", Offset = "0x20DB438", VA = "0x20DB438")]
		[DebuggerNonUserCode]
		public WorldAllAllianceCityInfo()
		{
		}

		// Token: 0x0600198F RID: 6543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600198F")]
		[Address(RVA = "0x20DB4C0", Offset = "0x20DB4C0", VA = "0x20DB4C0")]
		[DebuggerNonUserCode]
		public WorldAllAllianceCityInfo(WorldAllAllianceCityInfo other)
		{
		}

		// Token: 0x06001990 RID: 6544 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001990")]
		[Address(RVA = "0x20DB54C", Offset = "0x20DB54C", VA = "0x20DB54C", Slot = "10")]
		[DebuggerNonUserCode]
		public WorldAllAllianceCityInfo Clone()
		{
			return null;
		}

		// Token: 0x17000280 RID: 640
		// (get) Token: 0x06001991 RID: 6545 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000280")]
		[DebuggerNonUserCode]
		public RepeatedField<AllianceCityOccupyInfo> Infoes
		{
			[Token(Token = "0x6001991")]
			[Address(RVA = "0x20DB5AC", Offset = "0x20DB5AC", VA = "0x20DB5AC")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001992 RID: 6546 RVA: 0x00009C78 File Offset: 0x00007E78
		[Token(Token = "0x6001992")]
		[Address(RVA = "0x20DB5B4", Offset = "0x20DB5B4", VA = "0x20DB5B4", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06001993 RID: 6547 RVA: 0x00009C90 File Offset: 0x00007E90
		[Token(Token = "0x6001993")]
		[Address(RVA = "0x20DB618", Offset = "0x20DB618", VA = "0x20DB618", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(WorldAllAllianceCityInfo other)
		{
			return default(bool);
		}

		// Token: 0x06001994 RID: 6548 RVA: 0x00009CA8 File Offset: 0x00007EA8
		[Token(Token = "0x6001994")]
		[Address(RVA = "0x20DB6A8", Offset = "0x20DB6A8", VA = "0x20DB6A8", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001995 RID: 6549 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001995")]
		[Address(RVA = "0x20DB6F4", Offset = "0x20DB6F4", VA = "0x20DB6F4", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001996 RID: 6550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001996")]
		[Address(RVA = "0x20DB74C", Offset = "0x20DB74C", VA = "0x20DB74C", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06001997 RID: 6551 RVA: 0x00009CC0 File Offset: 0x00007EC0
		[Token(Token = "0x6001997")]
		[Address(RVA = "0x20DB804", Offset = "0x20DB804", VA = "0x20DB804", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06001998 RID: 6552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001998")]
		[Address(RVA = "0x20DB8AC", Offset = "0x20DB8AC", VA = "0x20DB8AC", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(WorldAllAllianceCityInfo other)
		{
		}

		// Token: 0x06001999 RID: 6553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001999")]
		[Address(RVA = "0x20DB934", Offset = "0x20DB934", VA = "0x20DB934", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x04001BB0 RID: 7088
		[Token(Token = "0x4001BB0")]
		[FieldOffset(Offset = "0x0")]
		private static readonly MessageParser<WorldAllAllianceCityInfo> _parser;

		// Token: 0x04001BB1 RID: 7089
		[Token(Token = "0x4001BB1")]
		[FieldOffset(Offset = "0x10")]
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001BB2 RID: 7090
		[Token(Token = "0x4001BB2")]
		public const int InfoesFieldNumber = 1;

		// Token: 0x04001BB3 RID: 7091
		[Token(Token = "0x4001BB3")]
		[FieldOffset(Offset = "0x8")]
		private static readonly FieldCodec<AllianceCityOccupyInfo> _repeated_infoes_codec;

		// Token: 0x04001BB4 RID: 7092
		[Token(Token = "0x4001BB4")]
		[FieldOffset(Offset = "0x18")]
		private readonly RepeatedField<AllianceCityOccupyInfo> infoes_;
	}
}
