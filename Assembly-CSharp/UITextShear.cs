using System;
using Il2CppDummyDll;
using UnityEngine.UI;

// Token: 0x02000146 RID: 326
[Token(Token = "0x2000146")]
public class UITextShear : BaseMeshEffect
{
	// Token: 0x0600099E RID: 2462 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600099E")]
	[Address(RVA = "0x33B3D2C", Offset = "0x33B3D2C", VA = "0x33B3D2C", Slot = "20")]
	public override void ModifyMesh(VertexHelper vh)
	{
	}

	// Token: 0x0600099F RID: 2463 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600099F")]
	[Address(RVA = "0x33B3DF4", Offset = "0x33B3DF4", VA = "0x33B3DF4")]
	public UITextShear()
	{
	}

	// Token: 0x04000731 RID: 1841
	[Token(Token = "0x4000731")]
	[FieldOffset(Offset = "0x20")]
	public float kx;

	// Token: 0x04000732 RID: 1842
	[Token(Token = "0x4000732")]
	[FieldOffset(Offset = "0x24")]
	public float ky;
}
