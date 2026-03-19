using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000136 RID: 310
[Token(Token = "0x2000136")]
[RequireComponent(typeof(RawImage))]
public class UIFormBlurEffect : MonoBehaviour
{
	// Token: 0x060008F7 RID: 2295 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008F7")]
	[Address(RVA = "0x33AC7B4", Offset = "0x33AC7B4", VA = "0x33AC7B4")]
	private void Awake()
	{
	}

	// Token: 0x060008F8 RID: 2296 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008F8")]
	[Address(RVA = "0x33AC824", Offset = "0x33AC824", VA = "0x33AC824")]
	private void OnEnable()
	{
	}

	// Token: 0x060008F9 RID: 2297 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008F9")]
	[Address(RVA = "0x33AC828", Offset = "0x33AC828", VA = "0x33AC828")]
	private void OnDisable()
	{
	}

	// Token: 0x060008FA RID: 2298 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008FA")]
	[Address(RVA = "0x33AC888", Offset = "0x33AC888", VA = "0x33AC888")]
	private void OnDestroy()
	{
	}

	// Token: 0x060008FB RID: 2299 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008FB")]
	[Address(RVA = "0x33AC82C", Offset = "0x33AC82C", VA = "0x33AC82C")]
	public void HideBlurImage()
	{
	}

	// Token: 0x060008FC RID: 2300 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008FC")]
	[Address(RVA = "0x33AC930", Offset = "0x33AC930", VA = "0x33AC930")]
	public void CreateRt(int blurOrder)
	{
	}

	// Token: 0x060008FD RID: 2301 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008FD")]
	[Address(RVA = "0x33AC934", Offset = "0x33AC934", VA = "0x33AC934")]
	public void ShowBlurImage(int blurOrder)
	{
	}

	// Token: 0x060008FE RID: 2302 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008FE")]
	[Address(RVA = "0x33ACA88", Offset = "0x33ACA88", VA = "0x33ACA88")]
	public UIFormBlurEffect()
	{
	}

	// Token: 0x040006BE RID: 1726
	[Token(Token = "0x40006BE")]
	[FieldOffset(Offset = "0x18")]
	private RawImage blurImage;

	// Token: 0x040006BF RID: 1727
	[Token(Token = "0x40006BF")]
	[FieldOffset(Offset = "0x20")]
	private string rfName;

	// Token: 0x040006C0 RID: 1728
	[Token(Token = "0x40006C0")]
	[FieldOffset(Offset = "0x28")]
	private string keyWorldName;

	// Token: 0x040006C1 RID: 1729
	[Token(Token = "0x40006C1")]
	[FieldOffset(Offset = "0x30")]
	private bool isOpen;

	// Token: 0x040006C2 RID: 1730
	[Token(Token = "0x40006C2")]
	[FieldOffset(Offset = "0x38")]
	private Material mat;
}
