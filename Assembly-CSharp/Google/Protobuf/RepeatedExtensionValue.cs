using System;
using Google.Protobuf.Collections;
using Il2CppDummyDll;

namespace Google.Protobuf
{
	// Token: 0x02000AF8 RID: 2808
	[Token(Token = "0x2000AF8")]
	internal sealed class RepeatedExtensionValue<T> : IExtensionValue, IEquatable<IExtensionValue>, IDeepCloneable<IExtensionValue>
	{
		// Token: 0x06006B74 RID: 27508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B74")]
		internal RepeatedExtensionValue(FieldCodec<T> codec)
		{
		}

		// Token: 0x06006B75 RID: 27509 RVA: 0x0004E450 File Offset: 0x0004C650
		[Token(Token = "0x6006B75")]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06006B76 RID: 27510 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B76")]
		public IExtensionValue Clone()
		{
			return null;
		}

		// Token: 0x06006B77 RID: 27511 RVA: 0x0004E468 File Offset: 0x0004C668
		[Token(Token = "0x6006B77")]
		public bool Equals(IExtensionValue other)
		{
			return default(bool);
		}

		// Token: 0x06006B78 RID: 27512 RVA: 0x0004E480 File Offset: 0x0004C680
		[Token(Token = "0x6006B78")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06006B79 RID: 27513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B79")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06006B7A RID: 27514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B7A")]
		public void MergeFrom(IExtensionValue value)
		{
		}

		// Token: 0x06006B7B RID: 27515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B7B")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06006B7C RID: 27516 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B7C")]
		public RepeatedField<T> GetValue()
		{
			return null;
		}

		// Token: 0x06006B7D RID: 27517 RVA: 0x0004E498 File Offset: 0x0004C698
		[Token(Token = "0x6006B7D")]
		public bool IsInitialized()
		{
			return default(bool);
		}

		// Token: 0x04002B2D RID: 11053
		[Token(Token = "0x4002B2D")]
		[FieldOffset(Offset = "0x0")]
		private RepeatedField<T> field;

		// Token: 0x04002B2E RID: 11054
		[Token(Token = "0x4002B2E")]
		[FieldOffset(Offset = "0x0")]
		private readonly FieldCodec<T> codec;
	}
}
