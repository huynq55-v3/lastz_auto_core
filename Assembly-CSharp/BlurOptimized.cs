using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000157 RID: 343
[Token(Token = "0x2000157")]
[RequireComponent(typeof(Camera))]
[ExecuteInEditMode]
public class BlurOptimized : MonoBehaviour
{
	// Token: 0x060009EE RID: 2542 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009EE")]
	[Address(RVA = "0x33B7CA8", Offset = "0x33B7CA8", VA = "0x33B7CA8")]
	public void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	// Token: 0x060009EF RID: 2543 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009EF")]
	[Address(RVA = "0x33B7F58", Offset = "0x33B7F58", VA = "0x33B7F58")]
	public BlurOptimized()
	{
	}

	// Token: 0x04000757 RID: 1879
	[Token(Token = "0x4000757")]
	[FieldOffset(Offset = "0x18")]
	[Range(0f, 10f)]
	public float blurSize;

	// Token: 0x04000758 RID: 1880
	[Token(Token = "0x4000758")]
	[FieldOffset(Offset = "0x1C")]
	[Range(1f, 4f)]
	public int blurIterations;

	// Token: 0x04000759 RID: 1881
	[Token(Token = "0x4000759")]
	[FieldOffset(Offset = "0x20")]
	public BlurOptimized.BlurType blurType;

	// Token: 0x0400075A RID: 1882
	[Token(Token = "0x400075A")]
	[FieldOffset(Offset = "0x28")]
	public Material blurMaterial;

	// Token: 0x02000158 RID: 344
	[Token(Token = "0x2000158")]
	public enum BlurType
	{
		// Token: 0x0400075C RID: 1884
		[Token(Token = "0x400075C")]
		StandardGauss,
		// Token: 0x0400075D RID: 1885
		[Token(Token = "0x400075D")]
		SgxGauss
	}
}
