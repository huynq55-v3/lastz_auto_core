using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002D7 RID: 727
[Token(Token = "0x20002D7")]
public class WorldZone
{
	// Token: 0x060012C2 RID: 4802 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012C2")]
	[Address(RVA = "0x1C60E94", Offset = "0x1C60E94", VA = "0x1C60E94")]
	public WorldZone(WorldMapZoneManager manager, WorldZoneData info)
	{
	}

	// Token: 0x060012C3 RID: 4803 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012C3")]
	[Address(RVA = "0x1C61248", Offset = "0x1C61248", VA = "0x1C61248")]
	public void Reset()
	{
	}

	// Token: 0x060012C4 RID: 4804 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012C4")]
	[Address(RVA = "0x1C6130C", Offset = "0x1C6130C", VA = "0x1C6130C")]
	public void SetEdgePosition(Vector3 pos)
	{
	}

	// Token: 0x060012C5 RID: 4805 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012C5")]
	[Address(RVA = "0x1C61318", Offset = "0x1C61318", VA = "0x1C61318")]
	public void ToggleEdge(bool visible)
	{
	}

	// Token: 0x060012C6 RID: 4806 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012C6")]
	[Address(RVA = "0x1C61424", Offset = "0x1C61424", VA = "0x1C61424")]
	private void CreateEdge()
	{
	}

	// Token: 0x060012C7 RID: 4807 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012C7")]
	[Address(RVA = "0x1C62018", Offset = "0x1C62018", VA = "0x1C62018")]
	private IEnumerator DelayActive()
	{
		return null;
	}

	// Token: 0x060012C8 RID: 4808 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012C8")]
	[Address(RVA = "0x1C6208C", Offset = "0x1C6208C", VA = "0x1C6208C")]
	public void ToggleZone(bool visible)
	{
	}

	// Token: 0x060012C9 RID: 4809 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012C9")]
	[Address(RVA = "0x1C62198", Offset = "0x1C62198", VA = "0x1C62198")]
	private void CreateZone()
	{
	}

	// Token: 0x060012CA RID: 4810 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012CA")]
	[Address(RVA = "0x1C62744", Offset = "0x1C62744", VA = "0x1C62744")]
	private static void SetOutlineParam(Transform trans, WorldCityColor cfg, WorldZoneData zoneInfo)
	{
	}

	// Token: 0x060012CB RID: 4811 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012CB")]
	[Address(RVA = "0x1C629BC", Offset = "0x1C629BC", VA = "0x1C629BC")]
	private void RefreshZoneRenderParam()
	{
	}

	// Token: 0x060012CC RID: 4812 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012CC")]
	[Address(RVA = "0x1C62D48", Offset = "0x1C62D48", VA = "0x1C62D48")]
	private void RefreshEdgeRenderParam()
	{
	}

	// Token: 0x060012CD RID: 4813 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012CD")]
	[Address(RVA = "0x1C62E20", Offset = "0x1C62E20", VA = "0x1C62E20")]
	private void SetEdgeMaterial(Material useMaterial)
	{
	}

	// Token: 0x060012CE RID: 4814 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012CE")]
	[Address(RVA = "0x1C6301C", Offset = "0x1C6301C", VA = "0x1C6301C")]
	public void SetZoneChangeColor(int beforeColorIndex, int afterColorIndex)
	{
	}

	// Token: 0x060012CF RID: 4815 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012CF")]
	[Address(RVA = "0x1C63494", Offset = "0x1C63494", VA = "0x1C63494")]
	private void RefreshZoneShadow()
	{
	}

	// Token: 0x060012D0 RID: 4816 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012D0")]
	[Address(RVA = "0x1C63638", Offset = "0x1C63638", VA = "0x1C63638")]
	public void OwnerInfoChanged()
	{
	}

	// Token: 0x0400158C RID: 5516
	[Token(Token = "0x400158C")]
	[FieldOffset(Offset = "0x0")]
	public static Color Color_Alliance;

	// Token: 0x0400158D RID: 5517
	[Token(Token = "0x400158D")]
	[FieldOffset(Offset = "0x10")]
	public int index;

	// Token: 0x0400158E RID: 5518
	[Token(Token = "0x400158E")]
	[FieldOffset(Offset = "0x14")]
	public RectInt rect;

	// Token: 0x0400158F RID: 5519
	[Token(Token = "0x400158F")]
	[FieldOffset(Offset = "0x28")]
	public WorldZoneData data;

	// Token: 0x04001590 RID: 5520
	[Token(Token = "0x4001590")]
	[FieldOffset(Offset = "0x30")]
	public Transform zoneRoot;

	// Token: 0x04001591 RID: 5521
	[Token(Token = "0x4001591")]
	[FieldOffset(Offset = "0x38")]
	private SpriteRenderer _zoneState1;

	// Token: 0x04001592 RID: 5522
	[Token(Token = "0x4001592")]
	[FieldOffset(Offset = "0x40")]
	private SpriteRenderer _zoneState2;

	// Token: 0x04001593 RID: 5523
	[Token(Token = "0x4001593")]
	[FieldOffset(Offset = "0x48")]
	public SpriteRenderer shadow;

	// Token: 0x04001594 RID: 5524
	[Token(Token = "0x4001594")]
	[FieldOffset(Offset = "0x50")]
	public bool zone_visible;

	// Token: 0x04001595 RID: 5525
	[Token(Token = "0x4001595")]
	[FieldOffset(Offset = "0x51")]
	public bool zone_loaded;

	// Token: 0x04001596 RID: 5526
	[Token(Token = "0x4001596")]
	[FieldOffset(Offset = "0x52")]
	public bool icon_visible;

	// Token: 0x04001597 RID: 5527
	[Token(Token = "0x4001597")]
	[FieldOffset(Offset = "0x53")]
	public bool icon_loaded;

	// Token: 0x04001598 RID: 5528
	[Token(Token = "0x4001598")]
	[FieldOffset(Offset = "0x54")]
	public bool edge_visible;

	// Token: 0x04001599 RID: 5529
	[Token(Token = "0x4001599")]
	[FieldOffset(Offset = "0x55")]
	public bool edge_loaded;

	// Token: 0x0400159A RID: 5530
	[Token(Token = "0x400159A")]
	[FieldOffset(Offset = "0x56")]
	public bool battleNews_visible;

	// Token: 0x0400159B RID: 5531
	[Token(Token = "0x400159B")]
	[FieldOffset(Offset = "0x57")]
	public bool marchNews_visible;

	// Token: 0x0400159C RID: 5532
	[Token(Token = "0x400159C")]
	[FieldOffset(Offset = "0x58")]
	public bool cityChangeNews_visible;

	// Token: 0x0400159D RID: 5533
	[Token(Token = "0x400159D")]
	[FieldOffset(Offset = "0x59")]
	public bool finded;

	// Token: 0x0400159E RID: 5534
	[Token(Token = "0x400159E")]
	[FieldOffset(Offset = "0x5C")]
	public int findState;

	// Token: 0x0400159F RID: 5535
	[Token(Token = "0x400159F")]
	[FieldOffset(Offset = "0x60")]
	public Vector3 pos_body;

	// Token: 0x040015A0 RID: 5536
	[Token(Token = "0x40015A0")]
	[FieldOffset(Offset = "0x6C")]
	public Vector3 pos_cityIcon;

	// Token: 0x040015A1 RID: 5537
	[Token(Token = "0x40015A1")]
	[FieldOffset(Offset = "0x78")]
	public Vector3 pos_edge;

	// Token: 0x040015A2 RID: 5538
	[Token(Token = "0x40015A2")]
	[FieldOffset(Offset = "0x88")]
	private readonly WorldMapZoneManager mapManager;

	// Token: 0x040015A3 RID: 5539
	[Token(Token = "0x40015A3")]
	[FieldOffset(Offset = "0x90")]
	public GameObject edgeRoot;

	// Token: 0x040015A4 RID: 5540
	[Token(Token = "0x40015A4")]
	[FieldOffset(Offset = "0x98")]
	private Dictionary<int, GameObject> edgeEntities;

	// Token: 0x040015A5 RID: 5541
	[Token(Token = "0x40015A5")]
	[FieldOffset(Offset = "0x10")]
	private static readonly int SolidOutline;

	// Token: 0x040015A6 RID: 5542
	[Token(Token = "0x40015A6")]
	[FieldOffset(Offset = "0x14")]
	private static readonly int BaseAlpha;

	// Token: 0x040015A7 RID: 5543
	[Token(Token = "0x40015A7")]
	[FieldOffset(Offset = "0x18")]
	private static readonly int SplashTex;

	// Token: 0x040015A8 RID: 5544
	[Token(Token = "0x40015A8")]
	[FieldOffset(Offset = "0x1C")]
	private static readonly int SplashAlpha;

	// Token: 0x040015A9 RID: 5545
	[Token(Token = "0x40015A9")]
	[FieldOffset(Offset = "0x20")]
	private static readonly int InnerColor;

	// Token: 0x040015AA RID: 5546
	[Token(Token = "0x40015AA")]
	[FieldOffset(Offset = "0x24")]
	private static readonly int InnerColorIntensity;

	// Token: 0x040015AB RID: 5547
	[Token(Token = "0x40015AB")]
	[FieldOffset(Offset = "0x28")]
	private static readonly int SplashAngle;

	// Token: 0x040015AC RID: 5548
	[Token(Token = "0x40015AC")]
	[FieldOffset(Offset = "0x2C")]
	private static readonly int SplashTex_ST;

	// Token: 0x040015AD RID: 5549
	[Token(Token = "0x40015AD")]
	[FieldOffset(Offset = "0x30")]
	private static readonly int Outline_Clip;

	// Token: 0x040015AE RID: 5550
	[Token(Token = "0x40015AE")]
	[FieldOffset(Offset = "0x34")]
	private static readonly int OutLine_Color;

	// Token: 0x040015AF RID: 5551
	[Token(Token = "0x40015AF")]
	[FieldOffset(Offset = "0x38")]
	private static readonly int Glow_Color;

	// Token: 0x040015B0 RID: 5552
	[Token(Token = "0x40015B0")]
	[FieldOffset(Offset = "0x3C")]
	private static readonly int UseBaseMapOn;

	// Token: 0x040015B1 RID: 5553
	[Token(Token = "0x40015B1")]
	[FieldOffset(Offset = "0xA0")]
	private List<WorldZone.ZoneColorInfo> zoneColorTestList;

	// Token: 0x020002D8 RID: 728
	[Token(Token = "0x20002D8")]
	public class ZoneColorInfo
	{
		// Token: 0x060012D2 RID: 4818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60012D2")]
		[Address(RVA = "0x1A42A40", Offset = "0x1A42A40", VA = "0x1A42A40")]
		public ZoneColorInfo()
		{
		}

		// Token: 0x040015B2 RID: 5554
		[Token(Token = "0x40015B2")]
		[FieldOffset(Offset = "0x10")]
		public Color baseColor;

		// Token: 0x040015B3 RID: 5555
		[Token(Token = "0x40015B3")]
		[FieldOffset(Offset = "0x20")]
		public Color outLineColor;

		// Token: 0x040015B4 RID: 5556
		[Token(Token = "0x40015B4")]
		[FieldOffset(Offset = "0x30")]
		public Color glowColor;
	}
}
