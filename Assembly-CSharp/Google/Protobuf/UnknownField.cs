using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Google.Protobuf
{
	// Token: 0x02000B2D RID: 2861
	[Token(Token = "0x2000B2D")]
	internal sealed class UnknownField
	{
		// Token: 0x06006D0F RID: 27919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D0F")]
		[Address(RVA = "0x36F11C0", Offset = "0x36F11C0", VA = "0x36F11C0")]
		public UnknownField()
		{
		}

		// Token: 0x06006D10 RID: 27920 RVA: 0x0004EB58 File Offset: 0x0004CD58
		[Token(Token = "0x6006D10")]
		[Address(RVA = "0x36F11C8", Offset = "0x36F11C8", VA = "0x36F11C8", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06006D11 RID: 27921 RVA: 0x0004EB70 File Offset: 0x0004CD70
		[Token(Token = "0x6006D11")]
		[Address(RVA = "0x36F12F8", Offset = "0x36F12F8", VA = "0x36F12F8", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06006D12 RID: 27922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D12")]
		[Address(RVA = "0x36F1400", Offset = "0x36F1400", VA = "0x36F1400")]
		internal void WriteTo(int fieldNumber, CodedOutputStream output)
		{
		}

		// Token: 0x06006D13 RID: 27923 RVA: 0x0004EB88 File Offset: 0x0004CD88
		[Token(Token = "0x6006D13")]
		[Address(RVA = "0x36F1CE8", Offset = "0x36F1CE8", VA = "0x36F1CE8")]
		internal int GetSerializedSize(int fieldNumber)
		{
			return 0;
		}

		// Token: 0x06006D14 RID: 27924 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D14")]
		[Address(RVA = "0x36F24A8", Offset = "0x36F24A8", VA = "0x36F24A8")]
		internal UnknownField MergeFrom(UnknownField other)
		{
			return null;
		}

		// Token: 0x06006D15 RID: 27925 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D15")]
		private static List<T> AddAll<T>(List<T> current, IList<T> extras)
		{
			return null;
		}

		// Token: 0x06006D16 RID: 27926 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D16")]
		[Address(RVA = "0x36F25F8", Offset = "0x36F25F8", VA = "0x36F25F8")]
		internal UnknownField AddVarint(ulong value)
		{
			return null;
		}

		// Token: 0x06006D17 RID: 27927 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D17")]
		[Address(RVA = "0x36F266C", Offset = "0x36F266C", VA = "0x36F266C")]
		internal UnknownField AddFixed32(uint value)
		{
			return null;
		}

		// Token: 0x06006D18 RID: 27928 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D18")]
		[Address(RVA = "0x36F26E0", Offset = "0x36F26E0", VA = "0x36F26E0")]
		internal UnknownField AddFixed64(ulong value)
		{
			return null;
		}

		// Token: 0x06006D19 RID: 27929 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D19")]
		[Address(RVA = "0x36F2754", Offset = "0x36F2754", VA = "0x36F2754")]
		internal UnknownField AddLengthDelimited(ByteString value)
		{
			return null;
		}

		// Token: 0x06006D1A RID: 27930 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D1A")]
		[Address(RVA = "0x36F27C8", Offset = "0x36F27C8", VA = "0x36F27C8")]
		internal UnknownField AddGroup(UnknownFieldSet value)
		{
			return null;
		}

		// Token: 0x06006D1B RID: 27931 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D1B")]
		private static List<T> Add<T>(List<T> list, T value)
		{
			return null;
		}

		// Token: 0x04002BD6 RID: 11222
		[Token(Token = "0x4002BD6")]
		[FieldOffset(Offset = "0x10")]
		private List<ulong> varintList;

		// Token: 0x04002BD7 RID: 11223
		[Token(Token = "0x4002BD7")]
		[FieldOffset(Offset = "0x18")]
		private List<uint> fixed32List;

		// Token: 0x04002BD8 RID: 11224
		[Token(Token = "0x4002BD8")]
		[FieldOffset(Offset = "0x20")]
		private List<ulong> fixed64List;

		// Token: 0x04002BD9 RID: 11225
		[Token(Token = "0x4002BD9")]
		[FieldOffset(Offset = "0x28")]
		private List<ByteString> lengthDelimitedList;

		// Token: 0x04002BDA RID: 11226
		[Token(Token = "0x4002BDA")]
		[FieldOffset(Offset = "0x30")]
		private List<UnknownFieldSet> groupList;
	}
}
