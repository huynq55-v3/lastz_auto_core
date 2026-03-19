using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000289 RID: 649
[Token(Token = "0x2000289")]
public class MaterialChange : MonoBehaviour, IMatChange
{
	// Token: 0x0600113C RID: 4412 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600113C")]
	[Address(RVA = "0x1C4E2CC", Offset = "0x1C4E2CC", VA = "0x1C4E2CC")]
	private void Awake()
	{
	}

	// Token: 0x0600113D RID: 4413 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600113D")]
	[Address(RVA = "0x1C4E2D0", Offset = "0x1C4E2D0", VA = "0x1C4E2D0")]
	private void InitSunMat()
	{
	}

	// Token: 0x0600113E RID: 4414 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600113E")]
	[Address(RVA = "0x1C4E45C", Offset = "0x1C4E45C", VA = "0x1C4E45C")]
	private void OnDestroy()
	{
	}

	// Token: 0x0600113F RID: 4415 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600113F")]
	[Address(RVA = "0x1C4E460", Offset = "0x1C4E460", VA = "0x1C4E460", Slot = "4")]
	public void ChangeMat(Mat_Type type)
	{
	}

	// Token: 0x06001140 RID: 4416 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001140")]
	[Address(RVA = "0x1C4E724", Offset = "0x1C4E724", VA = "0x1C4E724")]
	public MaterialChange()
	{
	}

	// Token: 0x040013FF RID: 5119
	[Token(Token = "0x40013FF")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public List<RenderItem> RenderItems;

	// Token: 0x04001400 RID: 5120
	[Token(Token = "0x4001400")]
	[FieldOffset(Offset = "0x20")]
	public List<GameObject> ActiveItems;

	// Token: 0x04001401 RID: 5121
	[Token(Token = "0x4001401")]
	[FieldOffset(Offset = "0x28")]
	private Mat_Type _matType;
}
