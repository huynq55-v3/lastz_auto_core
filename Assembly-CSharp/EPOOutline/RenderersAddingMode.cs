using System;
using Il2CppDummyDll;

namespace EPOOutline
{
	// Token: 0x02000C8F RID: 3215
	[Token(Token = "0x2000C8F")]
	[Flags]
	public enum RenderersAddingMode
	{
		// Token: 0x04003531 RID: 13617
		[Token(Token = "0x4003531")]
		All = -1,
		// Token: 0x04003532 RID: 13618
		[Token(Token = "0x4003532")]
		None = 0,
		// Token: 0x04003533 RID: 13619
		[Token(Token = "0x4003533")]
		MeshRenderer = 1,
		// Token: 0x04003534 RID: 13620
		[Token(Token = "0x4003534")]
		SkinnedMeshRenderer = 2,
		// Token: 0x04003535 RID: 13621
		[Token(Token = "0x4003535")]
		SpriteRenderer = 4,
		// Token: 0x04003536 RID: 13622
		[Token(Token = "0x4003536")]
		Others = 4096
	}
}
