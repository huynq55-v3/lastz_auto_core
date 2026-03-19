using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

// Token: 0x02000307 RID: 775
[Token(Token = "0x2000307")]
public class WorldCityColor
{
	// Token: 0x0600142E RID: 5166 RVA: 0x00007E60 File Offset: 0x00006060
	[Token(Token = "0x600142E")]
	[Address(RVA = "0x19816C8", Offset = "0x19816C8", VA = "0x19816C8")]
	public static Color ConvertToColor(string str)
	{
		return default(Color);
	}

	// Token: 0x0600142F RID: 5167 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600142F")]
	[Address(RVA = "0x19817A4", Offset = "0x19817A4", VA = "0x19817A4")]
	public WorldCityColor(int xmlId)
	{
	}

	// Token: 0x06001430 RID: 5168 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001430")]
	[Address(RVA = "0x1981CEC", Offset = "0x1981CEC", VA = "0x1981CEC")]
	public WorldCityColor(LuaTable tb)
	{
	}

	// Token: 0x0400170A RID: 5898
	[Token(Token = "0x400170A")]
	[FieldOffset(Offset = "0x10")]
	public int id;

	// Token: 0x0400170B RID: 5899
	[Token(Token = "0x400170B")]
	[FieldOffset(Offset = "0x14")]
	public Color outlineColor;

	// Token: 0x0400170C RID: 5900
	[Token(Token = "0x400170C")]
	[FieldOffset(Offset = "0x24")]
	public Color innerColor;

	// Token: 0x0400170D RID: 5901
	[Token(Token = "0x400170D")]
	[FieldOffset(Offset = "0x34")]
	public float innerIntensity;

	// Token: 0x0400170E RID: 5902
	[Token(Token = "0x400170E")]
	[FieldOffset(Offset = "0x38")]
	public Color baseColor;

	// Token: 0x0400170F RID: 5903
	[Token(Token = "0x400170F")]
	[FieldOffset(Offset = "0x48")]
	public float baseAlpha;

	// Token: 0x04001710 RID: 5904
	[Token(Token = "0x4001710")]
	[FieldOffset(Offset = "0x4C")]
	public int splashIndex;

	// Token: 0x04001711 RID: 5905
	[Token(Token = "0x4001711")]
	[FieldOffset(Offset = "0x50")]
	public int splashX;

	// Token: 0x04001712 RID: 5906
	[Token(Token = "0x4001712")]
	[FieldOffset(Offset = "0x54")]
	public int splashY;

	// Token: 0x04001713 RID: 5907
	[Token(Token = "0x4001713")]
	[FieldOffset(Offset = "0x58")]
	public int splashRot;

	// Token: 0x04001714 RID: 5908
	[Token(Token = "0x4001714")]
	[FieldOffset(Offset = "0x5C")]
	public float splashAlpha;

	// Token: 0x04001715 RID: 5909
	[Token(Token = "0x4001715")]
	[FieldOffset(Offset = "0x60")]
	public Color groundColor;

	// Token: 0x04001716 RID: 5910
	[Token(Token = "0x4001716")]
	[FieldOffset(Offset = "0x70")]
	public int useBaseMapOn;
}
