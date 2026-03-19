using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000340 RID: 832
[Token(Token = "0x2000340")]
[AddComponentMenu("UI/NewButton", 31)]
public class NewButton : Button
{
	// Token: 0x060015A1 RID: 5537 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015A1")]
	[Address(RVA = "0x1ED4788", Offset = "0x1ED4788", VA = "0x1ED4788")]
	private void SetGrayMaterial(Selectable.SelectionState state)
	{
	}

	// Token: 0x060015A2 RID: 5538 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015A2")]
	[Address(RVA = "0x1ED4948", Offset = "0x1ED4948", VA = "0x1ED4948", Slot = "26")]
	protected override void DoStateTransition(Selectable.SelectionState state, bool instant)
	{
	}

	// Token: 0x060015A3 RID: 5539 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015A3")]
	[Address(RVA = "0x1ED4BA4", Offset = "0x1ED4BA4", VA = "0x1ED4BA4")]
	private void StartColorTween(Color targetColor, bool instant)
	{
	}

	// Token: 0x060015A4 RID: 5540 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015A4")]
	[Address(RVA = "0x1ED4CC4", Offset = "0x1ED4CC4", VA = "0x1ED4CC4")]
	private void DoSpriteSwap(Sprite newSprite)
	{
	}

	// Token: 0x060015A5 RID: 5541 RVA: 0x00008580 File Offset: 0x00006780
	[Token(Token = "0x60015A5")]
	[Address(RVA = "0x1ED4F48", Offset = "0x1ED4F48", VA = "0x1ED4F48")]
	private bool GetPressedCurveInfo(out Vector3 pressedScale, out float pressedTime, out EaseFunction func)
	{
		return default(bool);
	}

	// Token: 0x060015A6 RID: 5542 RVA: 0x00008598 File Offset: 0x00006798
	[Token(Token = "0x60015A6")]
	[Address(RVA = "0x1ED5174", Offset = "0x1ED5174", VA = "0x1ED5174")]
	private bool GetOtherCurveInfo(out Vector3 otherScale, out float otherTime, out EaseFunction func)
	{
		return default(bool);
	}

	// Token: 0x060015A7 RID: 5543 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015A7")]
	[Address(RVA = "0x1ED4D74", Offset = "0x1ED4D74", VA = "0x1ED4D74")]
	private void TriggerAnimation(string triggername)
	{
	}

	// Token: 0x060015A8 RID: 5544 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015A8")]
	[Address(RVA = "0x1ED5368", Offset = "0x1ED5368", VA = "0x1ED5368")]
	public NewButton()
	{
	}

	// Token: 0x040018BA RID: 6330
	[Token(Token = "0x40018BA")]
	[FieldOffset(Offset = "0x100")]
	[Tooltip("需使用“SpriteGray”材质球")]
	[SerializeField]
	private Material m_GrayMaterial;

	// Token: 0x040018BB RID: 6331
	[Token(Token = "0x40018BB")]
	[FieldOffset(Offset = "0x108")]
	[SerializeField]
	private bool m_UseGrayMaterial;

	// Token: 0x040018BC RID: 6332
	[Token(Token = "0x40018BC")]
	[FieldOffset(Offset = "0x109")]
	[SerializeField]
	private bool m_DoubleEffect;

	// Token: 0x040018BD RID: 6333
	[Token(Token = "0x40018BD")]
	[FieldOffset(Offset = "0x110")]
	[SerializeField]
	private UIButtonCurve m_buttonCurve;
}
