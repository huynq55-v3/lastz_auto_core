using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace RTLTMPro
{
	// Token: 0x02000CD0 RID: 3280
	[Token(Token = "0x2000CD0")]
	public struct TashkeelLocation
	{
		// Token: 0x17000B30 RID: 2864
		// (get) Token: 0x06007BB3 RID: 31667 RVA: 0x00054480 File Offset: 0x00052680
		// (set) Token: 0x06007BB4 RID: 31668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B30")]
		public char Tashkeel
		{
			[Token(Token = "0x6007BB3")]
			[Address(RVA = "0x31929CC", Offset = "0x31929CC", VA = "0x31929CC")]
			[CompilerGenerated]
			readonly get
			{
				return '\0';
			}
			[Token(Token = "0x6007BB4")]
			[Address(RVA = "0x31929D4", Offset = "0x31929D4", VA = "0x31929D4")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000B31 RID: 2865
		// (get) Token: 0x06007BB5 RID: 31669 RVA: 0x00054498 File Offset: 0x00052698
		// (set) Token: 0x06007BB6 RID: 31670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B31")]
		public int Position
		{
			[Token(Token = "0x6007BB5")]
			[Address(RVA = "0x31929DC", Offset = "0x31929DC", VA = "0x31929DC")]
			[CompilerGenerated]
			readonly get
			{
				return 0;
			}
			[Token(Token = "0x6007BB6")]
			[Address(RVA = "0x31929E4", Offset = "0x31929E4", VA = "0x31929E4")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06007BB7 RID: 31671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007BB7")]
		[Address(RVA = "0x3192374", Offset = "0x3192374", VA = "0x3192374")]
		public TashkeelLocation(TashkeelCharacters tashkeel, int position)
		{
		}
	}
}
