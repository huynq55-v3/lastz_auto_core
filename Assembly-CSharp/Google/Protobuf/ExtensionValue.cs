using System;
using Il2CppDummyDll;

namespace Google.Protobuf
{
	// Token: 0x02000AF7 RID: 2807
	[Token(Token = "0x2000AF7")]
	internal sealed class ExtensionValue<T> : IExtensionValue, IEquatable<IExtensionValue>, IDeepCloneable<IExtensionValue>
	{
		// Token: 0x06006B69 RID: 27497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B69")]
		internal ExtensionValue(FieldCodec<T> codec)
		{
		}

		// Token: 0x06006B6A RID: 27498 RVA: 0x0004E3F0 File Offset: 0x0004C5F0
		[Token(Token = "0x6006B6A")]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06006B6B RID: 27499 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B6B")]
		public IExtensionValue Clone()
		{
			return null;
		}

		// Token: 0x06006B6C RID: 27500 RVA: 0x0004E408 File Offset: 0x0004C608
		[Token(Token = "0x6006B6C")]
		public bool Equals(IExtensionValue other)
		{
			return default(bool);
		}

		// Token: 0x06006B6D RID: 27501 RVA: 0x0004E420 File Offset: 0x0004C620
		[Token(Token = "0x6006B6D")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06006B6E RID: 27502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B6E")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06006B6F RID: 27503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B6F")]
		public void MergeFrom(IExtensionValue value)
		{
		}

		// Token: 0x06006B70 RID: 27504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B70")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06006B71 RID: 27505 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B71")]
		public T GetValue()
		{
			return null;
		}

		// Token: 0x06006B72 RID: 27506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B72")]
		public void SetValue(T value)
		{
		}

		// Token: 0x06006B73 RID: 27507 RVA: 0x0004E438 File Offset: 0x0004C638
		[Token(Token = "0x6006B73")]
		public bool IsInitialized()
		{
			return default(bool);
		}

		// Token: 0x04002B2B RID: 11051
		[Token(Token = "0x4002B2B")]
		[FieldOffset(Offset = "0x0")]
		private T field;

		// Token: 0x04002B2C RID: 11052
		[Token(Token = "0x4002B2C")]
		[FieldOffset(Offset = "0x0")]
		private FieldCodec<T> codec;
	}
}
