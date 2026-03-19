using System;
using Il2CppDummyDll;
using UnityEngine;
using usky;

// Token: 0x0200029F RID: 671
[Token(Token = "0x200029F")]
public class FogSetting : MonoBehaviour
{
	// Token: 0x060011A1 RID: 4513 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011A1")]
	[Address(RVA = "0x1C52800", Offset = "0x1C52800", VA = "0x1C52800")]
	private void OnEnable()
	{
	}

	// Token: 0x060011A2 RID: 4514 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011A2")]
	[Address(RVA = "0x1C52860", Offset = "0x1C52860", VA = "0x1C52860")]
	private void OnDisable()
	{
	}

	// Token: 0x060011A3 RID: 4515 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011A3")]
	[Address(RVA = "0x1C528C0", Offset = "0x1C528C0", VA = "0x1C528C0")]
	private void Update()
	{
	}

	// Token: 0x060011A4 RID: 4516 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011A4")]
	[Address(RVA = "0x1C52B40", Offset = "0x1C52B40", VA = "0x1C52B40")]
	private void UpdateFogParam()
	{
	}

	// Token: 0x060011A5 RID: 4517 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011A5")]
	[Address(RVA = "0x1C528C4", Offset = "0x1C528C4", VA = "0x1C528C4")]
	private void OnUpdateFogParam()
	{
	}

	// Token: 0x060011A6 RID: 4518 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011A6")]
	[Address(RVA = "0x1C52C68", Offset = "0x1C52C68", VA = "0x1C52C68")]
	public FogSetting()
	{
	}

	// Token: 0x0400144D RID: 5197
	[Token(Token = "0x400144D")]
	[FieldOffset(Offset = "0x18")]
	private GlobalRenderingSetting.FogInfo _CustomFogInfo;

	// Token: 0x0400144E RID: 5198
	[Token(Token = "0x400144E")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	public Gradient fogGradientColor;

	// Token: 0x0400144F RID: 5199
	[Token(Token = "0x400144F")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	public Color _FogColor;

	// Token: 0x04001450 RID: 5200
	[Token(Token = "0x4001450")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	public float _FogGlobalDensity;

	// Token: 0x04001451 RID: 5201
	[Token(Token = "0x4001451")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	public float _FogFallOff;

	// Token: 0x04001452 RID: 5202
	[Token(Token = "0x4001452")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	public float _FogHeight;

	// Token: 0x04001453 RID: 5203
	[Token(Token = "0x4001453")]
	[FieldOffset(Offset = "0x44")]
	[SerializeField]
	public float _FogStartDis;

	// Token: 0x04001454 RID: 5204
	[Token(Token = "0x4001454")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	public float _FogInscatteringExp;

	// Token: 0x04001455 RID: 5205
	[Token(Token = "0x4001455")]
	[FieldOffset(Offset = "0x4C")]
	[SerializeField]
	public float _FogGradientDis;

	// Token: 0x04001456 RID: 5206
	[Token(Token = "0x4001456")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	public float _FogStart;

	// Token: 0x04001457 RID: 5207
	[Token(Token = "0x4001457")]
	[FieldOffset(Offset = "0x54")]
	[SerializeField]
	public float _FogEnd;

	// Token: 0x04001458 RID: 5208
	[Token(Token = "0x4001458")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	public bool _IsTimePass;

	// Token: 0x04001459 RID: 5209
	[Token(Token = "0x4001459")]
	[FieldOffset(Offset = "0x59")]
	[SerializeField]
	public bool _UseShadowMap;

	// Token: 0x0400145A RID: 5210
	[Token(Token = "0x400145A")]
	[FieldOffset(Offset = "0x5A")]
	[SerializeField]
	public bool _ForceToggleFog;

	// Token: 0x0400145B RID: 5211
	[Token(Token = "0x400145B")]
	[FieldOffset(Offset = "0x5B")]
	[SerializeField]
	public bool _UseSun;

	// Token: 0x0400145C RID: 5212
	[Token(Token = "0x400145C")]
	[FieldOffset(Offset = "0x5C")]
	[SerializeField]
	public bool _DownLoadCopyDepth;

	// Token: 0x0400145D RID: 5213
	[Token(Token = "0x400145D")]
	[FieldOffset(Offset = "0x60")]
	private uSkyLighting usky;

	// Token: 0x0400145E RID: 5214
	[Token(Token = "0x400145E")]
	[FieldOffset(Offset = "0x0")]
	private static int refCount;

	// Token: 0x0400145F RID: 5215
	[Token(Token = "0x400145F")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	public bool isTimelinePlay;

	// Token: 0x04001460 RID: 5216
	[Token(Token = "0x4001460")]
	[FieldOffset(Offset = "0x4")]
	private static int int_FogColor;

	// Token: 0x04001461 RID: 5217
	[Token(Token = "0x4001461")]
	[FieldOffset(Offset = "0x8")]
	private static int in_FogStart;

	// Token: 0x04001462 RID: 5218
	[Token(Token = "0x4001462")]
	[FieldOffset(Offset = "0xC")]
	private static int in_FogEnd;

	// Token: 0x04001463 RID: 5219
	[Token(Token = "0x4001463")]
	[FieldOffset(Offset = "0x10")]
	private static int int_FogMaxHeight;

	// Token: 0x04001464 RID: 5220
	[Token(Token = "0x4001464")]
	[FieldOffset(Offset = "0x14")]
	private static int int_FogMinHeight;

	// Token: 0x04001465 RID: 5221
	[Token(Token = "0x4001465")]
	[FieldOffset(Offset = "0x18")]
	private static int int_FogDir;

	// Token: 0x04001466 RID: 5222
	[Token(Token = "0x4001466")]
	[FieldOffset(Offset = "0x1C")]
	public static int int_FogGlobalDensity;

	// Token: 0x04001467 RID: 5223
	[Token(Token = "0x4001467")]
	[FieldOffset(Offset = "0x20")]
	public static int int_FogFallOff;

	// Token: 0x04001468 RID: 5224
	[Token(Token = "0x4001468")]
	[FieldOffset(Offset = "0x24")]
	public static int int_FogHeight;

	// Token: 0x04001469 RID: 5225
	[Token(Token = "0x4001469")]
	[FieldOffset(Offset = "0x28")]
	public static int int_FogStartDis;

	// Token: 0x0400146A RID: 5226
	[Token(Token = "0x400146A")]
	[FieldOffset(Offset = "0x2C")]
	public static int int_FogInscatteringExp;

	// Token: 0x0400146B RID: 5227
	[Token(Token = "0x400146B")]
	[FieldOffset(Offset = "0x30")]
	public static int int_FogGradientDis;
}
