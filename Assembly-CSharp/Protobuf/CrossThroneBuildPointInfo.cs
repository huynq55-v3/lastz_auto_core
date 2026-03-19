using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Protobuf
{
	// Token: 0x02000499 RID: 1177
	[Token(Token = "0x2000499")]
	public sealed class CrossThroneBuildPointInfo : IMessage<CrossThroneBuildPointInfo>, IMessage, IEquatable<CrossThroneBuildPointInfo>, IDeepCloneable<CrossThroneBuildPointInfo>
	{
		// Token: 0x17000528 RID: 1320
		// (get) Token: 0x060022AA RID: 8874 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000528")]
		[DebuggerNonUserCode]
		public static MessageParser<CrossThroneBuildPointInfo> Parser
		{
			[Token(Token = "0x60022AA")]
			[Address(RVA = "0x29F9C60", Offset = "0x29F9C60", VA = "0x29F9C60")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000529 RID: 1321
		// (get) Token: 0x060022AB RID: 8875 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000529")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Token(Token = "0x60022AB")]
			[Address(RVA = "0x29F9CB8", Offset = "0x29F9CB8", VA = "0x29F9CB8")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700052A RID: 1322
		// (get) Token: 0x060022AC RID: 8876 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700052A")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Token(Token = "0x60022AC")]
			[Address(RVA = "0x29F9DBC", Offset = "0x29F9DBC", VA = "0x29F9DBC", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x060022AD RID: 8877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022AD")]
		[Address(RVA = "0x29F9E08", Offset = "0x29F9E08", VA = "0x29F9E08")]
		[DebuggerNonUserCode]
		public CrossThroneBuildPointInfo()
		{
		}

		// Token: 0x060022AE RID: 8878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022AE")]
		[Address(RVA = "0x29F9E70", Offset = "0x29F9E70", VA = "0x29F9E70")]
		[DebuggerNonUserCode]
		public CrossThroneBuildPointInfo(CrossThroneBuildPointInfo other)
		{
		}

		// Token: 0x060022AF RID: 8879 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022AF")]
		[Address(RVA = "0x29F9EE8", Offset = "0x29F9EE8", VA = "0x29F9EE8", Slot = "10")]
		[DebuggerNonUserCode]
		public CrossThroneBuildPointInfo Clone()
		{
			return null;
		}

		// Token: 0x1700052B RID: 1323
		// (get) Token: 0x060022B0 RID: 8880 RVA: 0x0000D518 File Offset: 0x0000B718
		// (set) Token: 0x060022B1 RID: 8881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700052B")]
		[DebuggerNonUserCode]
		public long Uuid
		{
			[Token(Token = "0x60022B0")]
			[Address(RVA = "0x29F9F48", Offset = "0x29F9F48", VA = "0x29F9F48")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x60022B1")]
			[Address(RVA = "0x29F9F50", Offset = "0x29F9F50", VA = "0x29F9F50")]
			set
			{
			}
		}

		// Token: 0x1700052C RID: 1324
		// (get) Token: 0x060022B2 RID: 8882 RVA: 0x0000D530 File Offset: 0x0000B730
		// (set) Token: 0x060022B3 RID: 8883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700052C")]
		[DebuggerNonUserCode]
		public int BuildId
		{
			[Token(Token = "0x60022B2")]
			[Address(RVA = "0x29F9F58", Offset = "0x29F9F58", VA = "0x29F9F58")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60022B3")]
			[Address(RVA = "0x29F9F60", Offset = "0x29F9F60", VA = "0x29F9F60")]
			set
			{
			}
		}

		// Token: 0x1700052D RID: 1325
		// (get) Token: 0x060022B4 RID: 8884 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060022B5 RID: 8885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700052D")]
		[DebuggerNonUserCode]
		public string AlAbbr
		{
			[Token(Token = "0x60022B4")]
			[Address(RVA = "0x29F9F68", Offset = "0x29F9F68", VA = "0x29F9F68")]
			get
			{
				return null;
			}
			[Token(Token = "0x60022B5")]
			[Address(RVA = "0x29F9F70", Offset = "0x29F9F70", VA = "0x29F9F70")]
			set
			{
			}
		}

		// Token: 0x1700052E RID: 1326
		// (get) Token: 0x060022B6 RID: 8886 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060022B7 RID: 8887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700052E")]
		[DebuggerNonUserCode]
		public string AllianceId
		{
			[Token(Token = "0x60022B6")]
			[Address(RVA = "0x29F9FEC", Offset = "0x29F9FEC", VA = "0x29F9FEC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60022B7")]
			[Address(RVA = "0x29F9FF4", Offset = "0x29F9FF4", VA = "0x29F9FF4")]
			set
			{
			}
		}

		// Token: 0x1700052F RID: 1327
		// (get) Token: 0x060022B8 RID: 8888 RVA: 0x0000D548 File Offset: 0x0000B748
		// (set) Token: 0x060022B9 RID: 8889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700052F")]
		[DebuggerNonUserCode]
		public long OpenTime
		{
			[Token(Token = "0x60022B8")]
			[Address(RVA = "0x29FA070", Offset = "0x29FA070", VA = "0x29FA070")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x60022B9")]
			[Address(RVA = "0x29FA078", Offset = "0x29FA078", VA = "0x29FA078")]
			set
			{
			}
		}

		// Token: 0x17000530 RID: 1328
		// (get) Token: 0x060022BA RID: 8890 RVA: 0x0000D560 File Offset: 0x0000B760
		// (set) Token: 0x060022BB RID: 8891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000530")]
		[DebuggerNonUserCode]
		public long StartTime
		{
			[Token(Token = "0x60022BA")]
			[Address(RVA = "0x29FA080", Offset = "0x29FA080", VA = "0x29FA080")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x60022BB")]
			[Address(RVA = "0x29FA088", Offset = "0x29FA088", VA = "0x29FA088")]
			set
			{
			}
		}

		// Token: 0x060022BC RID: 8892 RVA: 0x0000D578 File Offset: 0x0000B778
		[Token(Token = "0x60022BC")]
		[Address(RVA = "0x29FA090", Offset = "0x29FA090", VA = "0x29FA090", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x060022BD RID: 8893 RVA: 0x0000D590 File Offset: 0x0000B790
		[Token(Token = "0x60022BD")]
		[Address(RVA = "0x29FA0F4", Offset = "0x29FA0F4", VA = "0x29FA0F4", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(CrossThroneBuildPointInfo other)
		{
			return default(bool);
		}

		// Token: 0x060022BE RID: 8894 RVA: 0x0000D5A8 File Offset: 0x0000B7A8
		[Token(Token = "0x60022BE")]
		[Address(RVA = "0x29FA1A8", Offset = "0x29FA1A8", VA = "0x29FA1A8", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060022BF RID: 8895 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022BF")]
		[Address(RVA = "0x29FA2A4", Offset = "0x29FA2A4", VA = "0x29FA2A4", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060022C0 RID: 8896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022C0")]
		[Address(RVA = "0x29FA2FC", Offset = "0x29FA2FC", VA = "0x29FA2FC", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060022C1 RID: 8897 RVA: 0x0000D5C0 File Offset: 0x0000B7C0
		[Token(Token = "0x60022C1")]
		[Address(RVA = "0x29FA450", Offset = "0x29FA450", VA = "0x29FA450", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060022C2 RID: 8898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022C2")]
		[Address(RVA = "0x29FA5C8", Offset = "0x29FA5C8", VA = "0x29FA5C8", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CrossThroneBuildPointInfo other)
		{
		}

		// Token: 0x060022C3 RID: 8899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022C3")]
		[Address(RVA = "0x29FA674", Offset = "0x29FA674", VA = "0x29FA674", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x04002035 RID: 8245
		[Token(Token = "0x4002035")]
		[FieldOffset(Offset = "0x0")]
		private static readonly MessageParser<CrossThroneBuildPointInfo> _parser;

		// Token: 0x04002036 RID: 8246
		[Token(Token = "0x4002036")]
		[FieldOffset(Offset = "0x10")]
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002037 RID: 8247
		[Token(Token = "0x4002037")]
		public const int UuidFieldNumber = 1;

		// Token: 0x04002038 RID: 8248
		[Token(Token = "0x4002038")]
		[FieldOffset(Offset = "0x18")]
		private long uuid_;

		// Token: 0x04002039 RID: 8249
		[Token(Token = "0x4002039")]
		public const int BuildIdFieldNumber = 2;

		// Token: 0x0400203A RID: 8250
		[Token(Token = "0x400203A")]
		[FieldOffset(Offset = "0x20")]
		private int buildId_;

		// Token: 0x0400203B RID: 8251
		[Token(Token = "0x400203B")]
		public const int AlAbbrFieldNumber = 3;

		// Token: 0x0400203C RID: 8252
		[Token(Token = "0x400203C")]
		[FieldOffset(Offset = "0x28")]
		private string alAbbr_;

		// Token: 0x0400203D RID: 8253
		[Token(Token = "0x400203D")]
		public const int AllianceIdFieldNumber = 4;

		// Token: 0x0400203E RID: 8254
		[Token(Token = "0x400203E")]
		[FieldOffset(Offset = "0x30")]
		private string allianceId_;

		// Token: 0x0400203F RID: 8255
		[Token(Token = "0x400203F")]
		public const int OpenTimeFieldNumber = 5;

		// Token: 0x04002040 RID: 8256
		[Token(Token = "0x4002040")]
		[FieldOffset(Offset = "0x38")]
		private long openTime_;

		// Token: 0x04002041 RID: 8257
		[Token(Token = "0x4002041")]
		public const int StartTimeFieldNumber = 6;

		// Token: 0x04002042 RID: 8258
		[Token(Token = "0x4002042")]
		[FieldOffset(Offset = "0x40")]
		private long startTime_;
	}
}
