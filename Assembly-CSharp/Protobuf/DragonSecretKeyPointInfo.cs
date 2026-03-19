using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Protobuf
{
	// Token: 0x02000497 RID: 1175
	[Token(Token = "0x2000497")]
	public sealed class DragonSecretKeyPointInfo : IMessage<DragonSecretKeyPointInfo>, IMessage, IEquatable<DragonSecretKeyPointInfo>, IDeepCloneable<DragonSecretKeyPointInfo>
	{
		// Token: 0x17000522 RID: 1314
		// (get) Token: 0x06002292 RID: 8850 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000522")]
		[DebuggerNonUserCode]
		public static MessageParser<DragonSecretKeyPointInfo> Parser
		{
			[Token(Token = "0x6002292")]
			[Address(RVA = "0x29F9378", Offset = "0x29F9378", VA = "0x29F9378")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000523 RID: 1315
		// (get) Token: 0x06002293 RID: 8851 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000523")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Token(Token = "0x6002293")]
			[Address(RVA = "0x29F93D0", Offset = "0x29F93D0", VA = "0x29F93D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000524 RID: 1316
		// (get) Token: 0x06002294 RID: 8852 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000524")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Token(Token = "0x6002294")]
			[Address(RVA = "0x29F94D4", Offset = "0x29F94D4", VA = "0x29F94D4", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002295 RID: 8853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002295")]
		[Address(RVA = "0x29F9520", Offset = "0x29F9520", VA = "0x29F9520")]
		[DebuggerNonUserCode]
		public DragonSecretKeyPointInfo()
		{
		}

		// Token: 0x06002296 RID: 8854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002296")]
		[Address(RVA = "0x29F9528", Offset = "0x29F9528", VA = "0x29F9528")]
		[DebuggerNonUserCode]
		public DragonSecretKeyPointInfo(DragonSecretKeyPointInfo other)
		{
		}

		// Token: 0x06002297 RID: 8855 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002297")]
		[Address(RVA = "0x29F957C", Offset = "0x29F957C", VA = "0x29F957C", Slot = "10")]
		[DebuggerNonUserCode]
		public DragonSecretKeyPointInfo Clone()
		{
			return null;
		}

		// Token: 0x17000525 RID: 1317
		// (get) Token: 0x06002298 RID: 8856 RVA: 0x0000D470 File Offset: 0x0000B670
		// (set) Token: 0x06002299 RID: 8857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000525")]
		[DebuggerNonUserCode]
		public long Uuid
		{
			[Token(Token = "0x6002298")]
			[Address(RVA = "0x29F95DC", Offset = "0x29F95DC", VA = "0x29F95DC")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x6002299")]
			[Address(RVA = "0x29F95E4", Offset = "0x29F95E4", VA = "0x29F95E4")]
			set
			{
			}
		}

		// Token: 0x17000526 RID: 1318
		// (get) Token: 0x0600229A RID: 8858 RVA: 0x0000D488 File Offset: 0x0000B688
		// (set) Token: 0x0600229B RID: 8859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000526")]
		[DebuggerNonUserCode]
		public long CreateTime
		{
			[Token(Token = "0x600229A")]
			[Address(RVA = "0x29F95EC", Offset = "0x29F95EC", VA = "0x29F95EC")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x600229B")]
			[Address(RVA = "0x29F95F4", Offset = "0x29F95F4", VA = "0x29F95F4")]
			set
			{
			}
		}

		// Token: 0x17000527 RID: 1319
		// (get) Token: 0x0600229C RID: 8860 RVA: 0x0000D4A0 File Offset: 0x0000B6A0
		// (set) Token: 0x0600229D RID: 8861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000527")]
		[DebuggerNonUserCode]
		public int Index
		{
			[Token(Token = "0x600229C")]
			[Address(RVA = "0x29F95FC", Offset = "0x29F95FC", VA = "0x29F95FC")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600229D")]
			[Address(RVA = "0x29F9604", Offset = "0x29F9604", VA = "0x29F9604")]
			set
			{
			}
		}

		// Token: 0x0600229E RID: 8862 RVA: 0x0000D4B8 File Offset: 0x0000B6B8
		[Token(Token = "0x600229E")]
		[Address(RVA = "0x29F960C", Offset = "0x29F960C", VA = "0x29F960C", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x0600229F RID: 8863 RVA: 0x0000D4D0 File Offset: 0x0000B6D0
		[Token(Token = "0x600229F")]
		[Address(RVA = "0x29F9670", Offset = "0x29F9670", VA = "0x29F9670", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(DragonSecretKeyPointInfo other)
		{
			return default(bool);
		}

		// Token: 0x060022A0 RID: 8864 RVA: 0x0000D4E8 File Offset: 0x0000B6E8
		[Token(Token = "0x60022A0")]
		[Address(RVA = "0x29F96CC", Offset = "0x29F96CC", VA = "0x29F96CC", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060022A1 RID: 8865 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022A1")]
		[Address(RVA = "0x29F9768", Offset = "0x29F9768", VA = "0x29F9768", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060022A2 RID: 8866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022A2")]
		[Address(RVA = "0x29F97C0", Offset = "0x29F97C0", VA = "0x29F97C0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060022A3 RID: 8867 RVA: 0x0000D500 File Offset: 0x0000B700
		[Token(Token = "0x60022A3")]
		[Address(RVA = "0x29F9880", Offset = "0x29F9880", VA = "0x29F9880", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060022A4 RID: 8868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022A4")]
		[Address(RVA = "0x29F9960", Offset = "0x29F9960", VA = "0x29F9960", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(DragonSecretKeyPointInfo other)
		{
		}

		// Token: 0x060022A5 RID: 8869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022A5")]
		[Address(RVA = "0x29F99B8", Offset = "0x29F99B8", VA = "0x29F99B8", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0400202C RID: 8236
		[Token(Token = "0x400202C")]
		[FieldOffset(Offset = "0x0")]
		private static readonly MessageParser<DragonSecretKeyPointInfo> _parser;

		// Token: 0x0400202D RID: 8237
		[Token(Token = "0x400202D")]
		[FieldOffset(Offset = "0x10")]
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400202E RID: 8238
		[Token(Token = "0x400202E")]
		public const int UuidFieldNumber = 1;

		// Token: 0x0400202F RID: 8239
		[Token(Token = "0x400202F")]
		[FieldOffset(Offset = "0x18")]
		private long uuid_;

		// Token: 0x04002030 RID: 8240
		[Token(Token = "0x4002030")]
		public const int CreateTimeFieldNumber = 2;

		// Token: 0x04002031 RID: 8241
		[Token(Token = "0x4002031")]
		[FieldOffset(Offset = "0x20")]
		private long createTime_;

		// Token: 0x04002032 RID: 8242
		[Token(Token = "0x4002032")]
		public const int IndexFieldNumber = 3;

		// Token: 0x04002033 RID: 8243
		[Token(Token = "0x4002033")]
		[FieldOffset(Offset = "0x28")]
		private int index_;
	}
}
