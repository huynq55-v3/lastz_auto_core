using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002E4 RID: 740
[Token(Token = "0x20002E4")]
public class UIWorldLabel : MonoBehaviour
{
	// Token: 0x0600131C RID: 4892 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600131C")]
	[Address(RVA = "0x1A4607C", Offset = "0x1A4607C", VA = "0x1A4607C")]
	private void Awake()
	{
	}

	// Token: 0x0600131D RID: 4893 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600131D")]
	[Address(RVA = "0x1A4636C", Offset = "0x1A4636C", VA = "0x1A4636C")]
	public void SetLevel(int l)
	{
	}

	// Token: 0x0600131E RID: 4894 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600131E")]
	[Address(RVA = "0x1A4661C", Offset = "0x1A4661C", VA = "0x1A4661C")]
	public void SetCamp(int camp)
	{
	}

	// Token: 0x0600131F RID: 4895 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600131F")]
	[Address(RVA = "0x1A4672C", Offset = "0x1A4672C", VA = "0x1A4672C")]
	public void SetCountry(string countryStr)
	{
	}

	// Token: 0x06001320 RID: 4896 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001320")]
	[Address(RVA = "0x1A468F4", Offset = "0x1A468F4", VA = "0x1A468F4")]
	public void SetLevel(int l, Color color)
	{
	}

	// Token: 0x06001321 RID: 4897 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001321")]
	[Address(RVA = "0x1A46CC4", Offset = "0x1A46CC4", VA = "0x1A46CC4")]
	public void SetName(string n)
	{
	}

	// Token: 0x06001322 RID: 4898 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001322")]
	[Address(RVA = "0x1A46DFC", Offset = "0x1A46DFC", VA = "0x1A46DFC")]
	public void SetName(string n, Color color)
	{
	}

	// Token: 0x06001323 RID: 4899 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001323")]
	[Address(RVA = "0x1A47218", Offset = "0x1A47218", VA = "0x1A47218")]
	public void SetLevel(bool visible)
	{
	}

	// Token: 0x06001324 RID: 4900 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001324")]
	[Address(RVA = "0x1A4726C", Offset = "0x1A4726C", VA = "0x1A4726C")]
	public void ShowNameTitle(bool s)
	{
	}

	// Token: 0x06001325 RID: 4901 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001325")]
	[Address(RVA = "0x1A4729C", Offset = "0x1A4729C", VA = "0x1A4729C")]
	private void NameBgAutoFit()
	{
	}

	// Token: 0x06001326 RID: 4902 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001326")]
	[Address(RVA = "0x1A474C8", Offset = "0x1A474C8", VA = "0x1A474C8")]
	public void SetDirectionLevel(int showLevel, string iconName)
	{
	}

	// Token: 0x06001327 RID: 4903 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001327")]
	[Address(RVA = "0x1A46474", Offset = "0x1A46474", VA = "0x1A46474")]
	private void SetCityLevelLabelActive(bool visible)
	{
	}

	// Token: 0x06001328 RID: 4904 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001328")]
	[Address(RVA = "0x1A46578", Offset = "0x1A46578", VA = "0x1A46578")]
	private void SetDirectionLevelLabelActive(bool visible)
	{
	}

	// Token: 0x06001329 RID: 4905 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001329")]
	[Address(RVA = "0x1A475EC", Offset = "0x1A475EC", VA = "0x1A475EC")]
	public void SetNameBgSkin(int skinId = 0)
	{
	}

	// Token: 0x0600132A RID: 4906 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600132A")]
	[Address(RVA = "0x1A4795C", Offset = "0x1A4795C", VA = "0x1A4795C")]
	public void SetBuildData(string name, Color color, int level, int camp, int skinId = 0)
	{
	}

	// Token: 0x0600132B RID: 4907 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600132B")]
	[Address(RVA = "0x1A47A00", Offset = "0x1A47A00", VA = "0x1A47A00")]
	public UIWorldLabel()
	{
	}

	// Token: 0x040015F4 RID: 5620
	[Token(Token = "0x40015F4")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private SuperTextMesh name;

	// Token: 0x040015F5 RID: 5621
	[Token(Token = "0x40015F5")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private SpriteRenderer nameTitle;

	// Token: 0x040015F6 RID: 5622
	[Token(Token = "0x40015F6")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private SuperTextMesh level;

	// Token: 0x040015F7 RID: 5623
	[Token(Token = "0x40015F7")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private SpriteRenderer nameBg;

	// Token: 0x040015F8 RID: 5624
	[Token(Token = "0x40015F8")]
	[FieldOffset(Offset = "0x38")]
	private int nameBGType;

	// Token: 0x040015F9 RID: 5625
	[Token(Token = "0x40015F9")]
	[FieldOffset(Offset = "0x40")]
	private SpriteRenderer _directionImage;

	// Token: 0x040015FA RID: 5626
	[Token(Token = "0x40015FA")]
	[FieldOffset(Offset = "0x48")]
	private SuperTextMesh _directionLevel;

	// Token: 0x040015FB RID: 5627
	[Token(Token = "0x40015FB")]
	[FieldOffset(Offset = "0x50")]
	private SpriteRenderer _campSprite;

	// Token: 0x040015FC RID: 5628
	[Token(Token = "0x40015FC")]
	[FieldOffset(Offset = "0x58")]
	private SpriteRenderer _countrySprite;

	// Token: 0x040015FD RID: 5629
	[Token(Token = "0x40015FD")]
	[FieldOffset(Offset = "0x60")]
	private UIWorldLabel.LevelShowType _levelShowType;

	// Token: 0x040015FE RID: 5630
	[Token(Token = "0x40015FE")]
	[FieldOffset(Offset = "0x0")]
	private static readonly string DirectionImagePathName;

	// Token: 0x040015FF RID: 5631
	[Token(Token = "0x40015FF")]
	[FieldOffset(Offset = "0x8")]
	private static readonly string DirectionLevelPathName;

	// Token: 0x04001600 RID: 5632
	[Token(Token = "0x4001600")]
	[FieldOffset(Offset = "0x10")]
	private static readonly Vector3 TitleBgScale;

	// Token: 0x04001601 RID: 5633
	[Token(Token = "0x4001601")]
	[FieldOffset(Offset = "0x1C")]
	private static readonly float TitleBgMinSizeX;

	// Token: 0x04001602 RID: 5634
	[Token(Token = "0x4001602")]
	[FieldOffset(Offset = "0x20")]
	private static readonly float TitleBgMinSizeY;

	// Token: 0x04001603 RID: 5635
	[Token(Token = "0x4001603")]
	[FieldOffset(Offset = "0x24")]
	private static readonly Vector3 TitleNamePos;

	// Token: 0x04001604 RID: 5636
	[Token(Token = "0x4001604")]
	[FieldOffset(Offset = "0x30")]
	private static readonly float TitleBgSizeDeltaX;

	// Token: 0x04001605 RID: 5637
	[Token(Token = "0x4001605")]
	[FieldOffset(Offset = "0x38")]
	private static readonly string DefaultBgName;

	// Token: 0x04001606 RID: 5638
	[Token(Token = "0x4001606")]
	[FieldOffset(Offset = "0x40")]
	private static readonly string defaultBgNamePath;

	// Token: 0x020002E5 RID: 741
	[Token(Token = "0x20002E5")]
	public enum LevelShowType
	{
		// Token: 0x04001608 RID: 5640
		[Token(Token = "0x4001608")]
		Normal,
		// Token: 0x04001609 RID: 5641
		[Token(Token = "0x4001609")]
		Direction
	}
}
