using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000097 RID: 151
[Token(Token = "0x2000097")]
public class RadialBlurHelper : MonoBehaviour
{
	// Token: 0x06000391 RID: 913 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000391")]
	[Address(RVA = "0x3215AFC", Offset = "0x3215AFC", VA = "0x3215AFC")]
	private void OnEnable()
	{
	}

	// Token: 0x06000392 RID: 914 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000392")]
	[Address(RVA = "0x3215EDC", Offset = "0x3215EDC", VA = "0x3215EDC")]
	private void OnDisable()
	{
	}

	// Token: 0x06000393 RID: 915 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000393")]
	[Address(RVA = "0x3215B04", Offset = "0x3215B04", VA = "0x3215B04")]
	private void ToggleBlur(bool toggle)
	{
	}

	// Token: 0x06000394 RID: 916 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000394")]
	[Address(RVA = "0x3215EE4", Offset = "0x3215EE4", VA = "0x3215EE4")]
	private void Update()
	{
	}

	// Token: 0x06000395 RID: 917 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000395")]
	[Address(RVA = "0x3215F58", Offset = "0x3215F58", VA = "0x3215F58")]
	public RadialBlurHelper()
	{
	}

	// Token: 0x04000312 RID: 786
	[Token(Token = "0x4000312")]
	[FieldOffset(Offset = "0x18")]
	[Range(0f, 1f)]
	public float ScreenX;

	// Token: 0x04000313 RID: 787
	[Token(Token = "0x4000313")]
	[FieldOffset(Offset = "0x1C")]
	[Range(0f, 1f)]
	public float ScreenY;

	// Token: 0x04000314 RID: 788
	[Token(Token = "0x4000314")]
	[FieldOffset(Offset = "0x20")]
	[Range(1f, 8f)]
	public int loop;

	// Token: 0x04000315 RID: 789
	[Token(Token = "0x4000315")]
	[FieldOffset(Offset = "0x24")]
	[Range(1f, 8f)]
	public float blur;

	// Token: 0x04000316 RID: 790
	[Token(Token = "0x4000316")]
	[FieldOffset(Offset = "0x28")]
	[Range(1f, 5f)]
	public int downsample;

	// Token: 0x04000317 RID: 791
	[Token(Token = "0x4000317")]
	[FieldOffset(Offset = "0x2C")]
	[Range(0f, 1f)]
	public float instensity;

	// Token: 0x04000318 RID: 792
	[Token(Token = "0x4000318")]
	[FieldOffset(Offset = "0x30")]
	public string featureName;

	// Token: 0x04000319 RID: 793
	[Token(Token = "0x4000319")]
	[FieldOffset(Offset = "0x38")]
	private RadialBlur myFeature;
}
