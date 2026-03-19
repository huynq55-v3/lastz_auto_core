using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace XLua.TemplateEngine
{
	// Token: 0x020009B9 RID: 2489
	[Token(Token = "0x20009B9")]
	public class Chunk
	{
		// Token: 0x170005EE RID: 1518
		// (get) Token: 0x06005F30 RID: 24368 RVA: 0x0004AF28 File Offset: 0x00049128
		// (set) Token: 0x06005F31 RID: 24369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005EE")]
		public TokenType Type
		{
			[Token(Token = "0x6005F30")]
			[Address(RVA = "0x16DE394", Offset = "0x16DE394", VA = "0x16DE394")]
			[CompilerGenerated]
			get
			{
				return TokenType.Code;
			}
			[Token(Token = "0x6005F31")]
			[Address(RVA = "0x16DE39C", Offset = "0x16DE39C", VA = "0x16DE39C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170005EF RID: 1519
		// (get) Token: 0x06005F32 RID: 24370 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005F33 RID: 24371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005EF")]
		public string Text
		{
			[Token(Token = "0x6005F32")]
			[Address(RVA = "0x16DE3A4", Offset = "0x16DE3A4", VA = "0x16DE3A4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005F33")]
			[Address(RVA = "0x16DE3AC", Offset = "0x16DE3AC", VA = "0x16DE3AC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06005F34 RID: 24372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F34")]
		[Address(RVA = "0x16DE3B4", Offset = "0x16DE3B4", VA = "0x16DE3B4")]
		public Chunk(TokenType type, string text)
		{
		}
	}
}
