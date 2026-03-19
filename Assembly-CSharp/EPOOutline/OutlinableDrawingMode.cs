using System;
using Il2CppDummyDll;

namespace EPOOutline
{
	// Token: 0x02000C8E RID: 3214
	[Token(Token = "0x2000C8E")]
	[Flags]
	public enum OutlinableDrawingMode
	{
		// Token: 0x0400352B RID: 13611
		[Token(Token = "0x400352B")]
		Normal = 1,
		// Token: 0x0400352C RID: 13612
		[Token(Token = "0x400352C")]
		ZOnly = 2,
		// Token: 0x0400352D RID: 13613
		[Token(Token = "0x400352D")]
		GenericMask = 4,
		// Token: 0x0400352E RID: 13614
		[Token(Token = "0x400352E")]
		Obstacle = 8,
		// Token: 0x0400352F RID: 13615
		[Token(Token = "0x400352F")]
		Mask = 16
	}
}
