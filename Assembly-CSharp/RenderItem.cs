using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000288 RID: 648
[Token(Token = "0x2000288")]
[Serializable]
public class RenderItem
{
	// Token: 0x0600113B RID: 4411 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600113B")]
	[Address(RVA = "0x1C4E2C4", Offset = "0x1C4E2C4", VA = "0x1C4E2C4")]
	public RenderItem()
	{
	}

	// Token: 0x040013FC RID: 5116
	[Token(Token = "0x40013FC")]
	[FieldOffset(Offset = "0x10")]
	public Renderer _Renderer;

	// Token: 0x040013FD RID: 5117
	[Token(Token = "0x40013FD")]
	[FieldOffset(Offset = "0x18")]
	public Material[] _matMoon;

	// Token: 0x040013FE RID: 5118
	[Token(Token = "0x40013FE")]
	[FieldOffset(Offset = "0x20")]
	[NonSerialized]
	public Material[] _matSun;
}
