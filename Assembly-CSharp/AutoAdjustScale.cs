using System;
using BitBenderGames;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000365 RID: 869
[Token(Token = "0x2000365")]
public class AutoAdjustScale : MonoBehaviourWrapped
{
	// Token: 0x0600164B RID: 5707 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600164B")]
	[Address(RVA = "0x1EDDB34", Offset = "0x1EDDB34", VA = "0x1EDDB34")]
	private void OnEnable()
	{
	}

	// Token: 0x0600164C RID: 5708 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600164C")]
	[Address(RVA = "0x1EDDC50", Offset = "0x1EDDC50", VA = "0x1EDDC50")]
	private void OnDisable()
	{
	}

	// Token: 0x0600164D RID: 5709 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600164D")]
	[Address(RVA = "0x1EDDCB4", Offset = "0x1EDDCB4", VA = "0x1EDDCB4")]
	private void RefreshScale(Camera mainCamera)
	{
	}

	// Token: 0x0600164E RID: 5710 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600164E")]
	[Address(RVA = "0x1EDDE58", Offset = "0x1EDDE58", VA = "0x1EDDE58")]
	public void OnUpdate(Camera mainCamera)
	{
	}

	// Token: 0x0600164F RID: 5711 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600164F")]
	[Address(RVA = "0x1EDDE5C", Offset = "0x1EDDE5C", VA = "0x1EDDE5C")]
	public AutoAdjustScale()
	{
	}

	// Token: 0x0400196F RID: 6511
	[Token(Token = "0x400196F")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float minScale;

	// Token: 0x04001970 RID: 6512
	[Token(Token = "0x4001970")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private float maxScale;

	// Token: 0x04001971 RID: 6513
	[Token(Token = "0x4001971")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private float DefaultScale;
}
