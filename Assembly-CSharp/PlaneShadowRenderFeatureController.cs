using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering.Universal;

// Token: 0x020002A9 RID: 681
[Token(Token = "0x20002A9")]
public class PlaneShadowRenderFeatureController : MonoBehaviour
{
	// Token: 0x060011BD RID: 4541 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011BD")]
	[Address(RVA = "0x1C53674", Offset = "0x1C53674", VA = "0x1C53674")]
	private void OnEnable()
	{
	}

	// Token: 0x060011BE RID: 4542 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011BE")]
	[Address(RVA = "0x1C53C2C", Offset = "0x1C53C2C", VA = "0x1C53C2C")]
	private void Update()
	{
	}

	// Token: 0x060011BF RID: 4543 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011BF")]
	[Address(RVA = "0x1C54164", Offset = "0x1C54164", VA = "0x1C54164")]
	private void OnDisable()
	{
	}

	// Token: 0x060011C0 RID: 4544 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011C0")]
	[Address(RVA = "0x1C54168", Offset = "0x1C54168", VA = "0x1C54168")]
	private void OnDestroy()
	{
	}

	// Token: 0x060011C1 RID: 4545 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60011C1")]
	[Address(RVA = "0x1C5416C", Offset = "0x1C5416C", VA = "0x1C5416C")]
	private ScriptableRendererData GetRendererData()
	{
		return null;
	}

	// Token: 0x060011C2 RID: 4546 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011C2")]
	[Address(RVA = "0x1C5374C", Offset = "0x1C5374C", VA = "0x1C5374C")]
	private void ApplySettings()
	{
	}

	// Token: 0x060011C3 RID: 4547 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011C3")]
	[Address(RVA = "0x1C53CFC", Offset = "0x1C53CFC", VA = "0x1C53CFC")]
	private void RestoreSettings()
	{
	}

	// Token: 0x060011C4 RID: 4548 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011C4")]
	[Address(RVA = "0x1C54314", Offset = "0x1C54314", VA = "0x1C54314")]
	public void SetRenderPassEvent(RenderPassEvent evt)
	{
	}

	// Token: 0x060011C5 RID: 4549 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011C5")]
	[Address(RVA = "0x1C54618", Offset = "0x1C54618", VA = "0x1C54618")]
	public void SetRenderPassEvent(int id)
	{
	}

	// Token: 0x060011C6 RID: 4550 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011C6")]
	[Address(RVA = "0x1C54318", Offset = "0x1C54318", VA = "0x1C54318")]
	private void UpdateRenderPassEventOnly(RenderPassEvent evt)
	{
	}

	// Token: 0x060011C7 RID: 4551 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011C7")]
	[Address(RVA = "0x1C5461C", Offset = "0x1C5461C", VA = "0x1C5461C")]
	public PlaneShadowRenderFeatureController()
	{
	}

	// Token: 0x04001495 RID: 5269
	[Token(Token = "0x4001495")]
	[FieldOffset(Offset = "0x18")]
	[Tooltip("PlannerBlurShadowOpaques 和 PlaneShadowBlurFeature 的 RT 尺寸")]
	[Header("RT Size 设置")]
	public int rtWidth;

	// Token: 0x04001496 RID: 5270
	[Token(Token = "0x4001496")]
	[FieldOffset(Offset = "0x1C")]
	public int rtHeight;

	// Token: 0x04001497 RID: 5271
	[Token(Token = "0x4001497")]
	[FieldOffset(Offset = "0x20")]
	[Header("Render Pass Event")]
	[Tooltip("PlannerBlurShadowOpaques 和 PlaneShadowBlurFeature 的执行时机")]
	public RenderPassEvent renderPassEvent;

	// Token: 0x04001498 RID: 5272
	[Token(Token = "0x4001498")]
	private const string PlannerBlurShadowOpaques = "PlannerBlurShadowOpaques";

	// Token: 0x04001499 RID: 5273
	[Token(Token = "0x4001499")]
	private const string PlaneShadowBlurFeatureName = "PlaneShadowBlurFeature";

	// Token: 0x0400149A RID: 5274
	[Token(Token = "0x400149A")]
	private const string PlannerShadowOpaques = "PlannerShadowOpaques";

	// Token: 0x0400149B RID: 5275
	[Token(Token = "0x400149B")]
	[FieldOffset(Offset = "0x0")]
	private static readonly int BlurPlaneShadowOnId;

	// Token: 0x0400149C RID: 5276
	[Token(Token = "0x400149C")]
	[FieldOffset(Offset = "0x28")]
	private ScriptableRendererData _rendererData;

	// Token: 0x0400149D RID: 5277
	[Token(Token = "0x400149D")]
	[FieldOffset(Offset = "0x30")]
	private bool _hasApplied;

	// Token: 0x0400149E RID: 5278
	[Token(Token = "0x400149E")]
	[FieldOffset(Offset = "0x34")]
	private int _lastGraphicLevel;

	// Token: 0x0400149F RID: 5279
	[Token(Token = "0x400149F")]
	[FieldOffset(Offset = "0x38")]
	private bool _backupPlannerBlurActive;

	// Token: 0x040014A0 RID: 5280
	[Token(Token = "0x40014A0")]
	[FieldOffset(Offset = "0x39")]
	private bool _backupPlaneShadowBlurActive;

	// Token: 0x040014A1 RID: 5281
	[Token(Token = "0x40014A1")]
	[FieldOffset(Offset = "0x3A")]
	private bool _backupPlannerShadowActive;

	// Token: 0x040014A2 RID: 5282
	[Token(Token = "0x40014A2")]
	[FieldOffset(Offset = "0x3C")]
	private Vector2 _backupPlannerBlurRtSize;

	// Token: 0x040014A3 RID: 5283
	[Token(Token = "0x40014A3")]
	[FieldOffset(Offset = "0x44")]
	private int _backupPlaneShadowBlurWidth;

	// Token: 0x040014A4 RID: 5284
	[Token(Token = "0x40014A4")]
	[FieldOffset(Offset = "0x48")]
	private int _backupPlaneShadowBlurHeight;

	// Token: 0x040014A5 RID: 5285
	[Token(Token = "0x40014A5")]
	[FieldOffset(Offset = "0x4C")]
	private RenderPassEvent _backupPlannerBlurEvent;

	// Token: 0x040014A6 RID: 5286
	[Token(Token = "0x40014A6")]
	[FieldOffset(Offset = "0x50")]
	private RenderPassEvent _backupPlaneShadowBlurEvent;
}
