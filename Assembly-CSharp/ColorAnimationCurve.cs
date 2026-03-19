using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200015B RID: 347
[Token(Token = "0x200015B")]
public class ColorAnimationCurve
{
	// Token: 0x060009FC RID: 2556 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009FC")]
	[Address(RVA = "0x33B8770", Offset = "0x33B8770", VA = "0x33B8770")]
	public ColorAnimationCurve()
	{
	}

	// Token: 0x060009FD RID: 2557 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009FD")]
	[Address(RVA = "0x33B8888", Offset = "0x33B8888", VA = "0x33B8888")]
	public void AddKey(float time, Color color)
	{
	}

	// Token: 0x060009FE RID: 2558 RVA: 0x00005100 File Offset: 0x00003300
	[Token(Token = "0x60009FE")]
	[Address(RVA = "0x33B8960", Offset = "0x33B8960", VA = "0x33B8960")]
	public Color Evaluate(float time)
	{
		return default(Color);
	}

	// Token: 0x04000765 RID: 1893
	[Token(Token = "0x4000765")]
	[FieldOffset(Offset = "0x10")]
	private AnimationCurve[] curves;
}
