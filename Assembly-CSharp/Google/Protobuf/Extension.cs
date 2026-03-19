using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Google.Protobuf
{
	// Token: 0x02000AEE RID: 2798
	[Token(Token = "0x2000AEE")]
	public abstract class Extension
	{
		// Token: 0x170007B7 RID: 1975
		// (get) Token: 0x06006B32 RID: 27442
		[Token(Token = "0x170007B7")]
		internal abstract Type TargetType
		{
			[Token(Token = "0x6006B32")]
			get;
		}

		// Token: 0x06006B33 RID: 27443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B33")]
		[Address(RVA = "0x36D7644", Offset = "0x36D7644", VA = "0x36D7644")]
		protected Extension(int fieldNumber)
		{
		}

		// Token: 0x06006B34 RID: 27444
		[Token(Token = "0x6006B34")]
		internal abstract IExtensionValue CreateValue();

		// Token: 0x170007B8 RID: 1976
		// (get) Token: 0x06006B35 RID: 27445 RVA: 0x0004E288 File Offset: 0x0004C488
		[Token(Token = "0x170007B8")]
		public int FieldNumber
		{
			[Token(Token = "0x6006B35")]
			[Address(RVA = "0x36D766C", Offset = "0x36D766C", VA = "0x36D766C")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
		}
	}
}
