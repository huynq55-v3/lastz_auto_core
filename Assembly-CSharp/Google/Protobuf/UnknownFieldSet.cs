using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Google.Protobuf
{
	// Token: 0x02000B2E RID: 2862
	[Token(Token = "0x2000B2E")]
	public sealed class UnknownFieldSet
	{
		// Token: 0x06006D1C RID: 27932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D1C")]
		[Address(RVA = "0x36F283C", Offset = "0x36F283C", VA = "0x36F283C")]
		internal UnknownFieldSet()
		{
		}

		// Token: 0x06006D1D RID: 27933 RVA: 0x0004EBA0 File Offset: 0x0004CDA0
		[Token(Token = "0x6006D1D")]
		[Address(RVA = "0x36F28C4", Offset = "0x36F28C4", VA = "0x36F28C4")]
		internal bool HasField(int field)
		{
			return default(bool);
		}

		// Token: 0x06006D1E RID: 27934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D1E")]
		[Address(RVA = "0x36F19E0", Offset = "0x36F19E0", VA = "0x36F19E0")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06006D1F RID: 27935 RVA: 0x0004EBB8 File Offset: 0x0004CDB8
		[Token(Token = "0x6006D1F")]
		[Address(RVA = "0x36F21A0", Offset = "0x36F21A0", VA = "0x36F21A0")]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06006D20 RID: 27936 RVA: 0x0004EBD0 File Offset: 0x0004CDD0
		[Token(Token = "0x6006D20")]
		[Address(RVA = "0x36F2970", Offset = "0x36F2970", VA = "0x36F2970", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06006D21 RID: 27937 RVA: 0x0004EBE8 File Offset: 0x0004CDE8
		[Token(Token = "0x6006D21")]
		[Address(RVA = "0x36F2E58", Offset = "0x36F2E58", VA = "0x36F2E58", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06006D22 RID: 27938 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D22")]
		[Address(RVA = "0x36F3194", Offset = "0x36F3194", VA = "0x36F3194")]
		private UnknownField GetOrAddField(int number)
		{
			return null;
		}

		// Token: 0x06006D23 RID: 27939 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D23")]
		[Address(RVA = "0x36F32D8", Offset = "0x36F32D8", VA = "0x36F32D8")]
		internal UnknownFieldSet AddOrReplaceField(int number, UnknownField field)
		{
			return null;
		}

		// Token: 0x06006D24 RID: 27940 RVA: 0x0004EC00 File Offset: 0x0004CE00
		[Token(Token = "0x6006D24")]
		[Address(RVA = "0x36F3400", Offset = "0x36F3400", VA = "0x36F3400")]
		private bool MergeFieldFrom(CodedInputStream input)
		{
			return default(bool);
		}

		// Token: 0x06006D25 RID: 27941 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D25")]
		[Address(RVA = "0x36F35B8", Offset = "0x36F35B8", VA = "0x36F35B8")]
		public static UnknownFieldSet MergeFieldFrom(UnknownFieldSet unknownFields, CodedInputStream input)
		{
			return null;
		}

		// Token: 0x06006D26 RID: 27942 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D26")]
		[Address(RVA = "0x36F3690", Offset = "0x36F3690", VA = "0x36F3690")]
		private UnknownFieldSet MergeFrom(UnknownFieldSet other)
		{
			return null;
		}

		// Token: 0x06006D27 RID: 27943 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D27")]
		[Address(RVA = "0x36F3A54", Offset = "0x36F3A54", VA = "0x36F3A54")]
		public static UnknownFieldSet MergeFrom(UnknownFieldSet unknownFields, UnknownFieldSet other)
		{
			return null;
		}

		// Token: 0x06006D28 RID: 27944 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D28")]
		[Address(RVA = "0x36F3994", Offset = "0x36F3994", VA = "0x36F3994")]
		private UnknownFieldSet MergeField(int number, UnknownField field)
		{
			return null;
		}

		// Token: 0x06006D29 RID: 27945 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D29")]
		[Address(RVA = "0x36F3AC8", Offset = "0x36F3AC8", VA = "0x36F3AC8")]
		public static UnknownFieldSet Clone(UnknownFieldSet other)
		{
			return null;
		}

		// Token: 0x04002BDB RID: 11227
		[Token(Token = "0x4002BDB")]
		[FieldOffset(Offset = "0x10")]
		private readonly IDictionary<int, UnknownField> fields;

		// Token: 0x04002BDC RID: 11228
		[Token(Token = "0x4002BDC")]
		[FieldOffset(Offset = "0x18")]
		private int lastFieldNumber;

		// Token: 0x04002BDD RID: 11229
		[Token(Token = "0x4002BDD")]
		[FieldOffset(Offset = "0x20")]
		private UnknownField lastField;
	}
}
