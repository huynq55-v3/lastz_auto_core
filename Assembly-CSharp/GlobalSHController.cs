using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002A0 RID: 672
[Token(Token = "0x20002A0")]
public class GlobalSHController : MonoBehaviour
{
	// Token: 0x060011A8 RID: 4520 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011A8")]
	[Address(RVA = "0x1C52FCC", Offset = "0x1C52FCC", VA = "0x1C52FCC")]
	[ContextMenu("Capture Current Scene Ambient SH")]
	public void CaptureSH()
	{
	}

	// Token: 0x060011A9 RID: 4521 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011A9")]
	[Address(RVA = "0x1C53124", Offset = "0x1C53124", VA = "0x1C53124")]
	private void Start()
	{
	}

	// Token: 0x060011AA RID: 4522 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011AA")]
	[Address(RVA = "0x1C53134", Offset = "0x1C53134", VA = "0x1C53134")]
	public void ApplyToRenderSettings()
	{
	}

	// Token: 0x060011AB RID: 4523 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011AB")]
	[Address(RVA = "0x1C53238", Offset = "0x1C53238", VA = "0x1C53238")]
	public GlobalSHController()
	{
	}

	// Token: 0x0400146C RID: 5228
	[Token(Token = "0x400146C")]
	[FieldOffset(Offset = "0x18")]
	[HideInInspector]
	[SerializeField]
	private float[] shCoefficients;

	// Token: 0x0400146D RID: 5229
	[Token(Token = "0x400146D")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private bool applyOnStart;
}
