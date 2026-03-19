using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Google.Protobuf
{
	// Token: 0x02000AF4 RID: 2804
	[Token(Token = "0x2000AF4")]
	public sealed class ExtensionSet<TTarget> where TTarget : IExtendableMessage<TTarget>
	{
		// Token: 0x170007BE RID: 1982
		// (get) Token: 0x06006B5A RID: 27482 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007BE")]
		internal Dictionary<int, IExtensionValue> ValuesByNumber
		{
			[Token(Token = "0x6006B5A")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x06006B5B RID: 27483 RVA: 0x0004E378 File Offset: 0x0004C578
		[Token(Token = "0x6006B5B")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06006B5C RID: 27484 RVA: 0x0004E390 File Offset: 0x0004C590
		[Token(Token = "0x6006B5C")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06006B5D RID: 27485 RVA: 0x0004E3A8 File Offset: 0x0004C5A8
		[Token(Token = "0x6006B5D")]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06006B5E RID: 27486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B5E")]
		public void WriteTo(CodedOutputStream stream)
		{
		}

		// Token: 0x06006B5F RID: 27487 RVA: 0x0004E3C0 File Offset: 0x0004C5C0
		[Token(Token = "0x6006B5F")]
		internal bool IsInitialized()
		{
			return default(bool);
		}

		// Token: 0x06006B60 RID: 27488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B60")]
		public ExtensionSet()
		{
		}
	}
}
