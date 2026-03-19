using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000061 RID: 97
[Token(Token = "0x2000061")]
[CreateAssetMenu(fileName = "SkySeasonConfig", menuName = "uSkyPro/Sky Season Config")]
public class SkySeasonConfig : ScriptableObject
{
	// Token: 0x06000228 RID: 552 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000228")]
	[Address(RVA = "0x32038B0", Offset = "0x32038B0", VA = "0x32038B0")]
	public SkySeasonConfig()
	{
	}

	// Token: 0x040001E6 RID: 486
	[Token(Token = "0x40001E6")]
	[FieldOffset(Offset = "0x18")]
	[Header("赛季标识")]
	public string seasonId;

	// Token: 0x040001E7 RID: 487
	[Token(Token = "0x40001E7")]
	[FieldOffset(Offset = "0x20")]
	[Header("光照设置")]
	public Gradient lightGradientColor;

	// Token: 0x040001E8 RID: 488
	[Token(Token = "0x40001E8")]
	[FieldOffset(Offset = "0x28")]
	public AnimationCurve lightIntensityCurve;

	// Token: 0x040001E9 RID: 489
	[Token(Token = "0x40001E9")]
	[FieldOffset(Offset = "0x30")]
	[Header("烘焙贴图光照")]
	public Gradient bakeMapLightGradientColor;

	// Token: 0x040001EA RID: 490
	[Token(Token = "0x40001EA")]
	[FieldOffset(Offset = "0x38")]
	public AnimationCurve bakeMapLightIntensityCurve;

	// Token: 0x040001EB RID: 491
	[Token(Token = "0x40001EB")]
	[FieldOffset(Offset = "0x40")]
	[Header("角色光照")]
	public Gradient heroLightGradientColor;

	// Token: 0x040001EC RID: 492
	[Token(Token = "0x40001EC")]
	[FieldOffset(Offset = "0x48")]
	public AnimationCurve heroLightIntensityCurve;

	// Token: 0x040001ED RID: 493
	[Token(Token = "0x40001ED")]
	[FieldOffset(Offset = "0x50")]
	[Header("环境光设置")]
	public Gradient ambientSkyGradientColor;

	// Token: 0x040001EE RID: 494
	[Token(Token = "0x40001EE")]
	[FieldOffset(Offset = "0x58")]
	public Gradient equatorSkyGradientColor;

	// Token: 0x040001EF RID: 495
	[Token(Token = "0x40001EF")]
	[FieldOffset(Offset = "0x60")]
	public Gradient groundSkyGradientColor;

	// Token: 0x040001F0 RID: 496
	[Token(Token = "0x40001F0")]
	[FieldOffset(Offset = "0x68")]
	public AnimationCurve ambientIntensityCurve;

	// Token: 0x040001F1 RID: 497
	[Token(Token = "0x40001F1")]
	[FieldOffset(Offset = "0x70")]
	[Header("雾效设置")]
	public Gradient fogGradientColor;

	// Token: 0x040001F2 RID: 498
	[Token(Token = "0x40001F2")]
	[FieldOffset(Offset = "0x78")]
	public float fogGlobalDensity;

	// Token: 0x040001F3 RID: 499
	[Token(Token = "0x40001F3")]
	[FieldOffset(Offset = "0x7C")]
	public float fogHeight;

	// Token: 0x040001F4 RID: 500
	[Token(Token = "0x40001F4")]
	[FieldOffset(Offset = "0x80")]
	public float fogFallOff;
}
