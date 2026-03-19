using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Protobuf
{
	// Token: 0x0200040A RID: 1034
	[Token(Token = "0x200040A")]
	public sealed class ReportAllianceInfo : IMessage<ReportAllianceInfo>, IMessage, IEquatable<ReportAllianceInfo>, IDeepCloneable<ReportAllianceInfo>
	{
		// Token: 0x170002EF RID: 751
		// (get) Token: 0x06001B0C RID: 6924 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002EF")]
		[DebuggerNonUserCode]
		public static MessageParser<ReportAllianceInfo> Parser
		{
			[Token(Token = "0x6001B0C")]
			[Address(RVA = "0x20F53F0", Offset = "0x20F53F0", VA = "0x20F53F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002F0 RID: 752
		// (get) Token: 0x06001B0D RID: 6925 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002F0")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Token(Token = "0x6001B0D")]
			[Address(RVA = "0x20F5448", Offset = "0x20F5448", VA = "0x20F5448")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002F1 RID: 753
		// (get) Token: 0x06001B0E RID: 6926 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002F1")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Token(Token = "0x6001B0E")]
			[Address(RVA = "0x20F554C", Offset = "0x20F554C", VA = "0x20F554C", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001B0F RID: 6927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B0F")]
		[Address(RVA = "0x20F5598", Offset = "0x20F5598", VA = "0x20F5598")]
		[DebuggerNonUserCode]
		public ReportAllianceInfo()
		{
		}

		// Token: 0x06001B10 RID: 6928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B10")]
		[Address(RVA = "0x20F5620", Offset = "0x20F5620", VA = "0x20F5620")]
		[DebuggerNonUserCode]
		public ReportAllianceInfo(ReportAllianceInfo other)
		{
		}

		// Token: 0x06001B11 RID: 6929 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B11")]
		[Address(RVA = "0x20F56A0", Offset = "0x20F56A0", VA = "0x20F56A0", Slot = "10")]
		[DebuggerNonUserCode]
		public ReportAllianceInfo Clone()
		{
			return null;
		}

		// Token: 0x170002F2 RID: 754
		// (get) Token: 0x06001B12 RID: 6930 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001B13 RID: 6931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170002F2")]
		[DebuggerNonUserCode]
		public string AllianceId
		{
			[Token(Token = "0x6001B12")]
			[Address(RVA = "0x20F5700", Offset = "0x20F5700", VA = "0x20F5700")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001B13")]
			[Address(RVA = "0x20F5708", Offset = "0x20F5708", VA = "0x20F5708")]
			set
			{
			}
		}

		// Token: 0x170002F3 RID: 755
		// (get) Token: 0x06001B14 RID: 6932 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001B15 RID: 6933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170002F3")]
		[DebuggerNonUserCode]
		public string AlAbbr
		{
			[Token(Token = "0x6001B14")]
			[Address(RVA = "0x20F5784", Offset = "0x20F5784", VA = "0x20F5784")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001B15")]
			[Address(RVA = "0x20F578C", Offset = "0x20F578C", VA = "0x20F578C")]
			set
			{
			}
		}

		// Token: 0x170002F4 RID: 756
		// (get) Token: 0x06001B16 RID: 6934 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001B17 RID: 6935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170002F4")]
		[DebuggerNonUserCode]
		public string AlName
		{
			[Token(Token = "0x6001B16")]
			[Address(RVA = "0x20F5808", Offset = "0x20F5808", VA = "0x20F5808")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001B17")]
			[Address(RVA = "0x20F5810", Offset = "0x20F5810", VA = "0x20F5810")]
			set
			{
			}
		}

		// Token: 0x170002F5 RID: 757
		// (get) Token: 0x06001B18 RID: 6936 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001B19 RID: 6937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170002F5")]
		[DebuggerNonUserCode]
		public string AlIcon
		{
			[Token(Token = "0x6001B18")]
			[Address(RVA = "0x20F588C", Offset = "0x20F588C", VA = "0x20F588C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001B19")]
			[Address(RVA = "0x20F5894", Offset = "0x20F5894", VA = "0x20F5894")]
			set
			{
			}
		}

		// Token: 0x06001B1A RID: 6938 RVA: 0x0000A5A8 File Offset: 0x000087A8
		[Token(Token = "0x6001B1A")]
		[Address(RVA = "0x20F5910", Offset = "0x20F5910", VA = "0x20F5910", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06001B1B RID: 6939 RVA: 0x0000A5C0 File Offset: 0x000087C0
		[Token(Token = "0x6001B1B")]
		[Address(RVA = "0x20F5974", Offset = "0x20F5974", VA = "0x20F5974", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ReportAllianceInfo other)
		{
			return default(bool);
		}

		// Token: 0x06001B1C RID: 6940 RVA: 0x0000A5D8 File Offset: 0x000087D8
		[Token(Token = "0x6001B1C")]
		[Address(RVA = "0x20F5A10", Offset = "0x20F5A10", VA = "0x20F5A10", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001B1D RID: 6941 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B1D")]
		[Address(RVA = "0x20F5AD0", Offset = "0x20F5AD0", VA = "0x20F5AD0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001B1E RID: 6942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B1E")]
		[Address(RVA = "0x20F5B28", Offset = "0x20F5B28", VA = "0x20F5B28", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06001B1F RID: 6943 RVA: 0x0000A5F0 File Offset: 0x000087F0
		[Token(Token = "0x6001B1F")]
		[Address(RVA = "0x20F5C34", Offset = "0x20F5C34", VA = "0x20F5C34", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06001B20 RID: 6944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B20")]
		[Address(RVA = "0x20F5D6C", Offset = "0x20F5D6C", VA = "0x20F5D6C", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(ReportAllianceInfo other)
		{
		}

		// Token: 0x06001B21 RID: 6945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B21")]
		[Address(RVA = "0x20F5E18", Offset = "0x20F5E18", VA = "0x20F5E18", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x04001C7C RID: 7292
		[Token(Token = "0x4001C7C")]
		[FieldOffset(Offset = "0x0")]
		private static readonly MessageParser<ReportAllianceInfo> _parser;

		// Token: 0x04001C7D RID: 7293
		[Token(Token = "0x4001C7D")]
		[FieldOffset(Offset = "0x10")]
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001C7E RID: 7294
		[Token(Token = "0x4001C7E")]
		public const int AllianceIdFieldNumber = 1;

		// Token: 0x04001C7F RID: 7295
		[Token(Token = "0x4001C7F")]
		[FieldOffset(Offset = "0x18")]
		private string allianceId_;

		// Token: 0x04001C80 RID: 7296
		[Token(Token = "0x4001C80")]
		public const int AlAbbrFieldNumber = 2;

		// Token: 0x04001C81 RID: 7297
		[Token(Token = "0x4001C81")]
		[FieldOffset(Offset = "0x20")]
		private string alAbbr_;

		// Token: 0x04001C82 RID: 7298
		[Token(Token = "0x4001C82")]
		public const int AlNameFieldNumber = 3;

		// Token: 0x04001C83 RID: 7299
		[Token(Token = "0x4001C83")]
		[FieldOffset(Offset = "0x28")]
		private string alName_;

		// Token: 0x04001C84 RID: 7300
		[Token(Token = "0x4001C84")]
		public const int AlIconFieldNumber = 4;

		// Token: 0x04001C85 RID: 7301
		[Token(Token = "0x4001C85")]
		[FieldOffset(Offset = "0x30")]
		private string alIcon_;
	}
}
