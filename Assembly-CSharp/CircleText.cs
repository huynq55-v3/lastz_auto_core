using System;
using Il2CppDummyDll;
using UnityEngine.UI;

// Token: 0x02000338 RID: 824
[Token(Token = "0x2000338")]
public class CircleText : BaseMeshEffect
{
	// Token: 0x0600158E RID: 5518 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600158E")]
	[Address(RVA = "0x1ED34F0", Offset = "0x1ED34F0", VA = "0x1ED34F0", Slot = "20")]
	public override void ModifyMesh(VertexHelper vh)
	{
	}

	// Token: 0x0600158F RID: 5519 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600158F")]
	[Address(RVA = "0x1ED3B98", Offset = "0x1ED3B98", VA = "0x1ED3B98")]
	public CircleText()
	{
	}

	// Token: 0x0400188B RID: 6283
	[Token(Token = "0x400188B")]
	[FieldOffset(Offset = "0x20")]
	public int radius;

	// Token: 0x0400188C RID: 6284
	[Token(Token = "0x400188C")]
	[FieldOffset(Offset = "0x24")]
	public float spaceCoff;
}
