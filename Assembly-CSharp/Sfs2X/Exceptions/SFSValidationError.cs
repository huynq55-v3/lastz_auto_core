using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Sfs2X.Exceptions
{
	// Token: 0x02000A70 RID: 2672
	[Token(Token = "0x2000A70")]
	public class SFSValidationError : Exception
	{
		// Token: 0x170006B3 RID: 1715
		// (get) Token: 0x06006546 RID: 25926 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006B3")]
		public List<string> Errors
		{
			[Token(Token = "0x6006546")]
			[Address(RVA = "0x2E0BD2C", Offset = "0x2E0BD2C", VA = "0x2E0BD2C")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006547 RID: 25927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006547")]
		[Address(RVA = "0x2DFC438", Offset = "0x2DFC438", VA = "0x2DFC438")]
		public SFSValidationError(string message, ICollection<string> errors)
		{
		}

		// Token: 0x040028B8 RID: 10424
		[Token(Token = "0x40028B8")]
		[FieldOffset(Offset = "0x90")]
		private List<string> errors;
	}
}
