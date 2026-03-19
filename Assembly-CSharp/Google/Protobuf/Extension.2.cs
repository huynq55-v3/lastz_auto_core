using System;
using Il2CppDummyDll;

namespace Google.Protobuf
{
	// Token: 0x02000AEF RID: 2799
	[Token(Token = "0x2000AEF")]
	public sealed class Extension<TTarget, TValue> : Extension where TTarget : IExtendableMessage<TTarget>
	{
		// Token: 0x06006B36 RID: 27446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B36")]
		public Extension(int fieldNumber, FieldCodec<TValue> codec)
		{
		}

		// Token: 0x170007B9 RID: 1977
		// (get) Token: 0x06006B37 RID: 27447 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007B9")]
		internal TValue DefaultValue
		{
			[Token(Token = "0x6006B37")]
			get
			{
				return null;
			}
		}

		// Token: 0x170007BA RID: 1978
		// (get) Token: 0x06006B38 RID: 27448 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007BA")]
		internal override Type TargetType
		{
			[Token(Token = "0x6006B38")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006B39 RID: 27449 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B39")]
		internal override IExtensionValue CreateValue()
		{
			return null;
		}

		// Token: 0x04002B22 RID: 11042
		[Token(Token = "0x4002B22")]
		[FieldOffset(Offset = "0x0")]
		private readonly FieldCodec<TValue> codec;
	}
}
