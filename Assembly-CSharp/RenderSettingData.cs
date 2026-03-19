using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x020002B3 RID: 691
[Token(Token = "0x20002B3")]
[Serializable]
public class RenderSettingData
{
	// Token: 0x060011EE RID: 4590 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011EE")]
	[Address(RVA = "0x1C56BE0", Offset = "0x1C56BE0", VA = "0x1C56BE0")]
	public void LoadSettingData()
	{
	}

	// Token: 0x060011EF RID: 4591 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011EF")]
	[Address(RVA = "0x1C56D6C", Offset = "0x1C56D6C", VA = "0x1C56D6C")]
	public void ApplyRenderSetting()
	{
	}

	// Token: 0x060011F0 RID: 4592 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011F0")]
	[Address(RVA = "0x1C56ED4", Offset = "0x1C56ED4", VA = "0x1C56ED4")]
	public RenderSettingData()
	{
	}

	// Token: 0x040014D4 RID: 5332
	[Token(Token = "0x40014D4")]
	[FieldOffset(Offset = "0x10")]
	public Color ambientEquatorColor;

	// Token: 0x040014D5 RID: 5333
	[Token(Token = "0x40014D5")]
	[FieldOffset(Offset = "0x20")]
	public Color ambientGroundColor;

	// Token: 0x040014D6 RID: 5334
	[Token(Token = "0x40014D6")]
	[FieldOffset(Offset = "0x30")]
	public float ambientIntensity;

	// Token: 0x040014D7 RID: 5335
	[Token(Token = "0x40014D7")]
	[FieldOffset(Offset = "0x34")]
	public Color ambientLight;

	// Token: 0x040014D8 RID: 5336
	[Token(Token = "0x40014D8")]
	[FieldOffset(Offset = "0x44")]
	public AmbientMode ambientMode;

	// Token: 0x040014D9 RID: 5337
	[Token(Token = "0x40014D9")]
	[FieldOffset(Offset = "0x48")]
	public SphericalHarmonicsL2 ambientProbe;

	// Token: 0x040014DA RID: 5338
	[Token(Token = "0x40014DA")]
	[FieldOffset(Offset = "0xB4")]
	public Color ambientSkyColor;

	// Token: 0x040014DB RID: 5339
	[Token(Token = "0x40014DB")]
	[FieldOffset(Offset = "0xC8")]
	public Texture customReflection;

	// Token: 0x040014DC RID: 5340
	[Token(Token = "0x40014DC")]
	[FieldOffset(Offset = "0xD0")]
	public DefaultReflectionMode defaultReflectionMode;

	// Token: 0x040014DD RID: 5341
	[Token(Token = "0x40014DD")]
	[FieldOffset(Offset = "0xD4")]
	public float flareFadeSpeed;

	// Token: 0x040014DE RID: 5342
	[Token(Token = "0x40014DE")]
	[FieldOffset(Offset = "0xD8")]
	public float flareStrength;

	// Token: 0x040014DF RID: 5343
	[Token(Token = "0x40014DF")]
	[FieldOffset(Offset = "0xDC")]
	public bool fog;

	// Token: 0x040014E0 RID: 5344
	[Token(Token = "0x40014E0")]
	[FieldOffset(Offset = "0xE0")]
	public Color fogColor;

	// Token: 0x040014E1 RID: 5345
	[Token(Token = "0x40014E1")]
	[FieldOffset(Offset = "0xF0")]
	public float fogDensity;

	// Token: 0x040014E2 RID: 5346
	[Token(Token = "0x40014E2")]
	[FieldOffset(Offset = "0xF4")]
	public float fogEndDistance;

	// Token: 0x040014E3 RID: 5347
	[Token(Token = "0x40014E3")]
	[FieldOffset(Offset = "0xF8")]
	public FogMode fogMode;

	// Token: 0x040014E4 RID: 5348
	[Token(Token = "0x40014E4")]
	[FieldOffset(Offset = "0xFC")]
	public float fogStartDistance;

	// Token: 0x040014E5 RID: 5349
	[Token(Token = "0x40014E5")]
	[FieldOffset(Offset = "0x100")]
	public float haloStrength;

	// Token: 0x040014E6 RID: 5350
	[Token(Token = "0x40014E6")]
	[FieldOffset(Offset = "0x104")]
	public int reflectionBounces;

	// Token: 0x040014E7 RID: 5351
	[Token(Token = "0x40014E7")]
	[FieldOffset(Offset = "0x108")]
	public float reflectionIntensity;

	// Token: 0x040014E8 RID: 5352
	[Token(Token = "0x40014E8")]
	[FieldOffset(Offset = "0x110")]
	public Material skybox;

	// Token: 0x040014E9 RID: 5353
	[Token(Token = "0x40014E9")]
	[FieldOffset(Offset = "0x118")]
	public Color subtractiveShadowColor;

	// Token: 0x040014EA RID: 5354
	[Token(Token = "0x40014EA")]
	[FieldOffset(Offset = "0x128")]
	public Light sun;
}
