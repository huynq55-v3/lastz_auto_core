using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Protobuf
{
	// Token: 0x0200045C RID: 1116
	[Token(Token = "0x200045C")]
	public sealed class ReportRewardNeedCollect : IMessage<ReportRewardNeedCollect>, IMessage, IEquatable<ReportRewardNeedCollect>, IDeepCloneable<ReportRewardNeedCollect>
	{
		// Token: 0x1700041B RID: 1051
		// (get) Token: 0x06001F39 RID: 7993 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700041B")]
		[DebuggerNonUserCode]
		public static MessageParser<ReportRewardNeedCollect> Parser
		{
			[Token(Token = "0x6001F39")]
			[Address(RVA = "0x25A4F40", Offset = "0x25A4F40", VA = "0x25A4F40")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700041C RID: 1052
		// (get) Token: 0x06001F3A RID: 7994 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700041C")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Token(Token = "0x6001F3A")]
			[Address(RVA = "0x25A4F98", Offset = "0x25A4F98", VA = "0x25A4F98")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700041D RID: 1053
		// (get) Token: 0x06001F3B RID: 7995 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700041D")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Token(Token = "0x6001F3B")]
			[Address(RVA = "0x25A509C", Offset = "0x25A509C", VA = "0x25A509C", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001F3C RID: 7996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F3C")]
		[Address(RVA = "0x25A50E8", Offset = "0x25A50E8", VA = "0x25A50E8")]
		[DebuggerNonUserCode]
		public ReportRewardNeedCollect()
		{
		}

		// Token: 0x06001F3D RID: 7997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F3D")]
		[Address(RVA = "0x25A50F0", Offset = "0x25A50F0", VA = "0x25A50F0")]
		[DebuggerNonUserCode]
		public ReportRewardNeedCollect(ReportRewardNeedCollect other)
		{
		}

		// Token: 0x06001F3E RID: 7998 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F3E")]
		[Address(RVA = "0x25A514C", Offset = "0x25A514C", VA = "0x25A514C", Slot = "10")]
		[DebuggerNonUserCode]
		public ReportRewardNeedCollect Clone()
		{
			return null;
		}

		// Token: 0x1700041E RID: 1054
		// (get) Token: 0x06001F3F RID: 7999 RVA: 0x0000BE38 File Offset: 0x0000A038
		// (set) Token: 0x06001F40 RID: 8000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700041E")]
		[DebuggerNonUserCode]
		public int PointId
		{
			[Token(Token = "0x6001F3F")]
			[Address(RVA = "0x25A51AC", Offset = "0x25A51AC", VA = "0x25A51AC")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001F40")]
			[Address(RVA = "0x25A51B4", Offset = "0x25A51B4", VA = "0x25A51B4")]
			set
			{
			}
		}

		// Token: 0x1700041F RID: 1055
		// (get) Token: 0x06001F41 RID: 8001 RVA: 0x0000BE50 File Offset: 0x0000A050
		// (set) Token: 0x06001F42 RID: 8002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700041F")]
		[DebuggerNonUserCode]
		public bool InUserWorld
		{
			[Token(Token = "0x6001F41")]
			[Address(RVA = "0x25A51BC", Offset = "0x25A51BC", VA = "0x25A51BC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001F42")]
			[Address(RVA = "0x25A51C4", Offset = "0x25A51C4", VA = "0x25A51C4")]
			set
			{
			}
		}

		// Token: 0x17000420 RID: 1056
		// (get) Token: 0x06001F43 RID: 8003 RVA: 0x0000BE68 File Offset: 0x0000A068
		// (set) Token: 0x06001F44 RID: 8004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000420")]
		[DebuggerNonUserCode]
		public long RewardUuid
		{
			[Token(Token = "0x6001F43")]
			[Address(RVA = "0x25A51D0", Offset = "0x25A51D0", VA = "0x25A51D0")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x6001F44")]
			[Address(RVA = "0x25A51D8", Offset = "0x25A51D8", VA = "0x25A51D8")]
			set
			{
			}
		}

		// Token: 0x06001F45 RID: 8005 RVA: 0x0000BE80 File Offset: 0x0000A080
		[Token(Token = "0x6001F45")]
		[Address(RVA = "0x25A51E0", Offset = "0x25A51E0", VA = "0x25A51E0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06001F46 RID: 8006 RVA: 0x0000BE98 File Offset: 0x0000A098
		[Token(Token = "0x6001F46")]
		[Address(RVA = "0x25A5244", Offset = "0x25A5244", VA = "0x25A5244", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ReportRewardNeedCollect other)
		{
			return default(bool);
		}

		// Token: 0x06001F47 RID: 8007 RVA: 0x0000BEB0 File Offset: 0x0000A0B0
		[Token(Token = "0x6001F47")]
		[Address(RVA = "0x25A52B0", Offset = "0x25A52B0", VA = "0x25A52B0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001F48 RID: 8008 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F48")]
		[Address(RVA = "0x25A5390", Offset = "0x25A5390", VA = "0x25A5390", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001F49 RID: 8009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F49")]
		[Address(RVA = "0x25A53E8", Offset = "0x25A53E8", VA = "0x25A53E8", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06001F4A RID: 8010 RVA: 0x0000BEC8 File Offset: 0x0000A0C8
		[Token(Token = "0x6001F4A")]
		[Address(RVA = "0x25A54A8", Offset = "0x25A54A8", VA = "0x25A54A8", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06001F4B RID: 8011 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F4B")]
		[Address(RVA = "0x25A5574", Offset = "0x25A5574", VA = "0x25A5574", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(ReportRewardNeedCollect other)
		{
		}

		// Token: 0x06001F4C RID: 8012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F4C")]
		[Address(RVA = "0x25A55CC", Offset = "0x25A55CC", VA = "0x25A55CC", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x04001E70 RID: 7792
		[Token(Token = "0x4001E70")]
		[FieldOffset(Offset = "0x0")]
		private static readonly MessageParser<ReportRewardNeedCollect> _parser;

		// Token: 0x04001E71 RID: 7793
		[Token(Token = "0x4001E71")]
		[FieldOffset(Offset = "0x10")]
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001E72 RID: 7794
		[Token(Token = "0x4001E72")]
		public const int PointIdFieldNumber = 1;

		// Token: 0x04001E73 RID: 7795
		[Token(Token = "0x4001E73")]
		[FieldOffset(Offset = "0x18")]
		private int pointId_;

		// Token: 0x04001E74 RID: 7796
		[Token(Token = "0x4001E74")]
		public const int InUserWorldFieldNumber = 2;

		// Token: 0x04001E75 RID: 7797
		[Token(Token = "0x4001E75")]
		[FieldOffset(Offset = "0x1C")]
		private bool inUserWorld_;

		// Token: 0x04001E76 RID: 7798
		[Token(Token = "0x4001E76")]
		public const int RewardUuidFieldNumber = 3;

		// Token: 0x04001E77 RID: 7799
		[Token(Token = "0x4001E77")]
		[FieldOffset(Offset = "0x20")]
		private long rewardUuid_;
	}
}
