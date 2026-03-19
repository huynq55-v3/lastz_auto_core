using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Protobuf
{
	// Token: 0x020003E4 RID: 996
	[Token(Token = "0x20003E4")]
	public sealed class AllianceCityUserRecord : IMessage<AllianceCityUserRecord>, IMessage, IEquatable<AllianceCityUserRecord>, IDeepCloneable<AllianceCityUserRecord>
	{
		// Token: 0x1700026E RID: 622
		// (get) Token: 0x0600194B RID: 6475 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700026E")]
		[DebuggerNonUserCode]
		public static MessageParser<AllianceCityUserRecord> Parser
		{
			[Token(Token = "0x600194B")]
			[Address(RVA = "0x20D946C", Offset = "0x20D946C", VA = "0x20D946C")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700026F RID: 623
		// (get) Token: 0x0600194C RID: 6476 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700026F")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Token(Token = "0x600194C")]
			[Address(RVA = "0x20D94C4", Offset = "0x20D94C4", VA = "0x20D94C4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000270 RID: 624
		// (get) Token: 0x0600194D RID: 6477 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000270")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Token(Token = "0x600194D")]
			[Address(RVA = "0x20D95C8", Offset = "0x20D95C8", VA = "0x20D95C8", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600194E RID: 6478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600194E")]
		[Address(RVA = "0x20D9614", Offset = "0x20D9614", VA = "0x20D9614")]
		[DebuggerNonUserCode]
		public AllianceCityUserRecord()
		{
		}

		// Token: 0x0600194F RID: 6479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600194F")]
		[Address(RVA = "0x20D966C", Offset = "0x20D966C", VA = "0x20D966C")]
		[DebuggerNonUserCode]
		public AllianceCityUserRecord(AllianceCityUserRecord other)
		{
		}

		// Token: 0x06001950 RID: 6480 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001950")]
		[Address(RVA = "0x20D96C4", Offset = "0x20D96C4", VA = "0x20D96C4", Slot = "10")]
		[DebuggerNonUserCode]
		public AllianceCityUserRecord Clone()
		{
			return null;
		}

		// Token: 0x17000271 RID: 625
		// (get) Token: 0x06001951 RID: 6481 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001952 RID: 6482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000271")]
		[DebuggerNonUserCode]
		public string Uid
		{
			[Token(Token = "0x6001951")]
			[Address(RVA = "0x20D9724", Offset = "0x20D9724", VA = "0x20D9724")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001952")]
			[Address(RVA = "0x20D972C", Offset = "0x20D972C", VA = "0x20D972C")]
			set
			{
			}
		}

		// Token: 0x17000272 RID: 626
		// (get) Token: 0x06001953 RID: 6483 RVA: 0x00009B28 File Offset: 0x00007D28
		// (set) Token: 0x06001954 RID: 6484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000272")]
		[DebuggerNonUserCode]
		public int Point
		{
			[Token(Token = "0x6001953")]
			[Address(RVA = "0x20D97A8", Offset = "0x20D97A8", VA = "0x20D97A8")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001954")]
			[Address(RVA = "0x20D97B0", Offset = "0x20D97B0", VA = "0x20D97B0")]
			set
			{
			}
		}

		// Token: 0x06001955 RID: 6485 RVA: 0x00009B40 File Offset: 0x00007D40
		[Token(Token = "0x6001955")]
		[Address(RVA = "0x20D97B8", Offset = "0x20D97B8", VA = "0x20D97B8", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06001956 RID: 6486 RVA: 0x00009B58 File Offset: 0x00007D58
		[Token(Token = "0x6001956")]
		[Address(RVA = "0x20D981C", Offset = "0x20D981C", VA = "0x20D981C", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(AllianceCityUserRecord other)
		{
			return default(bool);
		}

		// Token: 0x06001957 RID: 6487 RVA: 0x00009B70 File Offset: 0x00007D70
		[Token(Token = "0x6001957")]
		[Address(RVA = "0x20D988C", Offset = "0x20D988C", VA = "0x20D988C", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001958 RID: 6488 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001958")]
		[Address(RVA = "0x20D990C", Offset = "0x20D990C", VA = "0x20D990C", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001959 RID: 6489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001959")]
		[Address(RVA = "0x20D9964", Offset = "0x20D9964", VA = "0x20D9964", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600195A RID: 6490 RVA: 0x00009B88 File Offset: 0x00007D88
		[Token(Token = "0x600195A")]
		[Address(RVA = "0x20D9A00", Offset = "0x20D9A00", VA = "0x20D9A00", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600195B RID: 6491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600195B")]
		[Address(RVA = "0x20D9AC8", Offset = "0x20D9AC8", VA = "0x20D9AC8", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(AllianceCityUserRecord other)
		{
		}

		// Token: 0x0600195C RID: 6492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600195C")]
		[Address(RVA = "0x20D9B38", Offset = "0x20D9B38", VA = "0x20D9B38", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x04001B99 RID: 7065
		[Token(Token = "0x4001B99")]
		[FieldOffset(Offset = "0x0")]
		private static readonly MessageParser<AllianceCityUserRecord> _parser;

		// Token: 0x04001B9A RID: 7066
		[Token(Token = "0x4001B9A")]
		[FieldOffset(Offset = "0x10")]
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001B9B RID: 7067
		[Token(Token = "0x4001B9B")]
		public const int UidFieldNumber = 1;

		// Token: 0x04001B9C RID: 7068
		[Token(Token = "0x4001B9C")]
		[FieldOffset(Offset = "0x18")]
		private string uid_;

		// Token: 0x04001B9D RID: 7069
		[Token(Token = "0x4001B9D")]
		public const int PointFieldNumber = 2;

		// Token: 0x04001B9E RID: 7070
		[Token(Token = "0x4001B9E")]
		[FieldOffset(Offset = "0x20")]
		private int point_;
	}
}
