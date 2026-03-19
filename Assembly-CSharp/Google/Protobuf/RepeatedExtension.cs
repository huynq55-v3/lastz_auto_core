using System;
using Il2CppDummyDll;

namespace Google.Protobuf
{
	// Token: 0x02000AF0 RID: 2800
	[Token(Token = "0x2000AF0")]
	public sealed class RepeatedExtension<TTarget, TValue> : Extension where TTarget : IExtendableMessage<TTarget>
	{
		// Token: 0x06006B3A RID: 27450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B3A")]
		public RepeatedExtension(int fieldNumber, FieldCodec<TValue> codec)
		{
		}

		// Token: 0x170007BB RID: 1979
		// (get) Token: 0x06006B3B RID: 27451 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007BB")]
		internal override Type TargetType
		{
			[Token(Token = "0x6006B3B")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006B3C RID: 27452 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B3C")]
		internal override IExtensionValue CreateValue()
		{
			return null;
		}

		// Token: 0x04002B23 RID: 11043
		[Token(Token = "0x4002B23")]
		[FieldOffset(Offset = "0x0")]
		private readonly FieldCodec<TValue> codec;
	}
}
