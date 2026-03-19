using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Protobuf
{
	// Token: 0x02000412 RID: 1042
	[Token(Token = "0x2000412")]
	public sealed class ReportRewardItem : IMessage<ReportRewardItem>, IMessage, IEquatable<ReportRewardItem>, IDeepCloneable<ReportRewardItem>
	{
		// Token: 0x17000318 RID: 792
		// (get) Token: 0x06001B8E RID: 7054 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000318")]
		[DebuggerNonUserCode]
		public static MessageParser<ReportRewardItem> Parser
		{
			[Token(Token = "0x6001B8E")]
			[Address(RVA = "0x26F3BA8", Offset = "0x26F3BA8", VA = "0x26F3BA8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000319 RID: 793
		// (get) Token: 0x06001B8F RID: 7055 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000319")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Token(Token = "0x6001B8F")]
			[Address(RVA = "0x26F3C00", Offset = "0x26F3C00", VA = "0x26F3C00")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700031A RID: 794
		// (get) Token: 0x06001B90 RID: 7056 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700031A")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Token(Token = "0x6001B90")]
			[Address(RVA = "0x26F3D04", Offset = "0x26F3D04", VA = "0x26F3D04", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001B91 RID: 7057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B91")]
		[Address(RVA = "0x26F3D50", Offset = "0x26F3D50", VA = "0x26F3D50")]
		[DebuggerNonUserCode]
		public ReportRewardItem()
		{
		}

		// Token: 0x06001B92 RID: 7058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B92")]
		[Address(RVA = "0x26F3DA8", Offset = "0x26F3DA8", VA = "0x26F3DA8")]
		[DebuggerNonUserCode]
		public ReportRewardItem(ReportRewardItem other)
		{
		}

		// Token: 0x06001B93 RID: 7059 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B93")]
		[Address(RVA = "0x26F3E00", Offset = "0x26F3E00", VA = "0x26F3E00", Slot = "10")]
		[DebuggerNonUserCode]
		public ReportRewardItem Clone()
		{
			return null;
		}

		// Token: 0x1700031B RID: 795
		// (get) Token: 0x06001B94 RID: 7060 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001B95 RID: 7061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700031B")]
		[DebuggerNonUserCode]
		public string Type
		{
			[Token(Token = "0x6001B94")]
			[Address(RVA = "0x26F3E60", Offset = "0x26F3E60", VA = "0x26F3E60")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001B95")]
			[Address(RVA = "0x26F3E68", Offset = "0x26F3E68", VA = "0x26F3E68")]
			set
			{
			}
		}

		// Token: 0x1700031C RID: 796
		// (get) Token: 0x06001B96 RID: 7062 RVA: 0x0000A8F0 File Offset: 0x00008AF0
		// (set) Token: 0x06001B97 RID: 7063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700031C")]
		[DebuggerNonUserCode]
		public int Value
		{
			[Token(Token = "0x6001B96")]
			[Address(RVA = "0x26F3EE4", Offset = "0x26F3EE4", VA = "0x26F3EE4")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001B97")]
			[Address(RVA = "0x26F3EEC", Offset = "0x26F3EEC", VA = "0x26F3EEC")]
			set
			{
			}
		}

		// Token: 0x06001B98 RID: 7064 RVA: 0x0000A908 File Offset: 0x00008B08
		[Token(Token = "0x6001B98")]
		[Address(RVA = "0x26F3EF4", Offset = "0x26F3EF4", VA = "0x26F3EF4", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06001B99 RID: 7065 RVA: 0x0000A920 File Offset: 0x00008B20
		[Token(Token = "0x6001B99")]
		[Address(RVA = "0x26F3F58", Offset = "0x26F3F58", VA = "0x26F3F58", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ReportRewardItem other)
		{
			return default(bool);
		}

		// Token: 0x06001B9A RID: 7066 RVA: 0x0000A938 File Offset: 0x00008B38
		[Token(Token = "0x6001B9A")]
		[Address(RVA = "0x26F3FC8", Offset = "0x26F3FC8", VA = "0x26F3FC8", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001B9B RID: 7067 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B9B")]
		[Address(RVA = "0x26F4048", Offset = "0x26F4048", VA = "0x26F4048", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001B9C RID: 7068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B9C")]
		[Address(RVA = "0x26F40A0", Offset = "0x26F40A0", VA = "0x26F40A0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06001B9D RID: 7069 RVA: 0x0000A950 File Offset: 0x00008B50
		[Token(Token = "0x6001B9D")]
		[Address(RVA = "0x26F413C", Offset = "0x26F413C", VA = "0x26F413C", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06001B9E RID: 7070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B9E")]
		[Address(RVA = "0x26F4204", Offset = "0x26F4204", VA = "0x26F4204", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(ReportRewardItem other)
		{
		}

		// Token: 0x06001B9F RID: 7071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B9F")]
		[Address(RVA = "0x26F4274", Offset = "0x26F4274", VA = "0x26F4274", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x04001CC2 RID: 7362
		[Token(Token = "0x4001CC2")]
		[FieldOffset(Offset = "0x0")]
		private static readonly MessageParser<ReportRewardItem> _parser;

		// Token: 0x04001CC3 RID: 7363
		[Token(Token = "0x4001CC3")]
		[FieldOffset(Offset = "0x10")]
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001CC4 RID: 7364
		[Token(Token = "0x4001CC4")]
		public const int TypeFieldNumber = 1;

		// Token: 0x04001CC5 RID: 7365
		[Token(Token = "0x4001CC5")]
		[FieldOffset(Offset = "0x18")]
		private string type_;

		// Token: 0x04001CC6 RID: 7366
		[Token(Token = "0x4001CC6")]
		public const int ValueFieldNumber = 2;

		// Token: 0x04001CC7 RID: 7367
		[Token(Token = "0x4001CC7")]
		[FieldOffset(Offset = "0x20")]
		private int value_;
	}
}
