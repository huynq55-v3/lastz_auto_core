using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Google.Protobuf.Reflection
{
	// Token: 0x02000BC2 RID: 3010
	[Token(Token = "0x2000BC2")]
	internal static class DescriptorUtil
	{
		// Token: 0x060073BC RID: 29628 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60073BC")]
		internal static IList<TOutput> ConvertAndMakeReadOnly<TInput, TOutput>(IList<TInput> input, DescriptorUtil.IndexedConverter<TInput, TOutput> converter)
		{
			return null;
		}

		// Token: 0x02000BC3 RID: 3011
		// (Invoke) Token: 0x060073BE RID: 29630
		[Token(Token = "0x2000BC3")]
		internal delegate TOutput IndexedConverter<TInput, TOutput>(TInput element, int index);
	}
}
