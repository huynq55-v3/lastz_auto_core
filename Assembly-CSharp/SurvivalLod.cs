using System;
using System.Collections.Generic;
using BitBenderGames;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000290 RID: 656
[Token(Token = "0x2000290")]
public class SurvivalLod : MonoBehaviourWrapped
{
	// Token: 0x0600114B RID: 4427 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600114B")]
	[Address(RVA = "0x1C4F2FC", Offset = "0x1C4F2FC", VA = "0x1C4F2FC")]
	private void Awake()
	{
	}

	// Token: 0x0600114C RID: 4428 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600114C")]
	[Address(RVA = "0x1C4F308", Offset = "0x1C4F308", VA = "0x1C4F308", Slot = "4")]
	protected virtual void InitComponent()
	{
	}

	// Token: 0x0600114D RID: 4429 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600114D")]
	[Address(RVA = "0x1C4F490", Offset = "0x1C4F490", VA = "0x1C4F490")]
	private void OnEnable()
	{
	}

	// Token: 0x0600114E RID: 4430 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600114E")]
	[Address(RVA = "0x1C4F630", Offset = "0x1C4F630", VA = "0x1C4F630", Slot = "5")]
	protected virtual void InitHandler()
	{
	}

	// Token: 0x0600114F RID: 4431 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600114F")]
	[Address(RVA = "0x1C4F550", Offset = "0x1C4F550", VA = "0x1C4F550")]
	private void CheckIsScaleByLevel()
	{
	}

	// Token: 0x06001150 RID: 4432 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001150")]
	[Address(RVA = "0x1C4F754", Offset = "0x1C4F754", VA = "0x1C4F754")]
	private void OnDisable()
	{
	}

	// Token: 0x06001151 RID: 4433 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001151")]
	[Address(RVA = "0x1C4F7F4", Offset = "0x1C4F7F4", VA = "0x1C4F7F4", Slot = "6")]
	public virtual void Refresh(float curZoom)
	{
	}

	// Token: 0x06001152 RID: 4434 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001152")]
	[Address(RVA = "0x1C4F840", Offset = "0x1C4F840", VA = "0x1C4F840")]
	private void UpdateLod(float curZoom)
	{
	}

	// Token: 0x06001153 RID: 4435 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001153")]
	[Address(RVA = "0x1C4FA18", Offset = "0x1C4FA18", VA = "0x1C4FA18")]
	private void UpdateScale(float curZoom)
	{
	}

	// Token: 0x06001154 RID: 4436 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001154")]
	[Address(RVA = "0x1C4FBD0", Offset = "0x1C4FBD0", VA = "0x1C4FBD0")]
	public SurvivalLod()
	{
	}

	// Token: 0x04001413 RID: 5139
	[Token(Token = "0x4001413")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	public bool LodEnabled;

	// Token: 0x04001414 RID: 5140
	[Token(Token = "0x4001414")]
	[FieldOffset(Offset = "0x29")]
	public bool inverse;

	// Token: 0x04001415 RID: 5141
	[Token(Token = "0x4001415")]
	[FieldOffset(Offset = "0x2C")]
	public float height;

	// Token: 0x04001416 RID: 5142
	[Token(Token = "0x4001416")]
	[FieldOffset(Offset = "0x30")]
	public Renderer[] targets;

	// Token: 0x04001417 RID: 5143
	[Token(Token = "0x4001417")]
	[FieldOffset(Offset = "0x38")]
	public Terrain[] terrains;

	// Token: 0x04001418 RID: 5144
	[Token(Token = "0x4001418")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	public bool ScaleEnabled;

	// Token: 0x04001419 RID: 5145
	[Token(Token = "0x4001419")]
	[FieldOffset(Offset = "0x44")]
	public Vector2 ZoomRange;

	// Token: 0x0400141A RID: 5146
	[Token(Token = "0x400141A")]
	[FieldOffset(Offset = "0x4C")]
	public Vector2 ScaleRange;

	// Token: 0x0400141B RID: 5147
	[Token(Token = "0x400141B")]
	[FieldOffset(Offset = "0x54")]
	[SerializeField]
	public bool IsSupportLevel;

	// Token: 0x0400141C RID: 5148
	[Token(Token = "0x400141C")]
	[FieldOffset(Offset = "0x58")]
	private List<LevelScaleParam> _LevelScaleParams;

	// Token: 0x0400141D RID: 5149
	[Token(Token = "0x400141D")]
	[FieldOffset(Offset = "0x60")]
	private NormalScaleParam _normalScaleParam;

	// Token: 0x0400141E RID: 5150
	[Token(Token = "0x400141E")]
	[FieldOffset(Offset = "0x74")]
	private bool _isCulled;

	// Token: 0x0400141F RID: 5151
	[Token(Token = "0x400141F")]
	[FieldOffset(Offset = "0x78")]
	private Renderer[] _renderers;

	// Token: 0x04001420 RID: 5152
	[Token(Token = "0x4001420")]
	[FieldOffset(Offset = "0x80")]
	private bool _useTargets;
}
