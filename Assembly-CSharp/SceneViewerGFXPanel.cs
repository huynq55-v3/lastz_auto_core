using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001FD RID: 509
[Token(Token = "0x20001FD")]
public class SceneViewerGFXPanel : BaseGFXPanel
{
	// Token: 0x06000DBC RID: 3516 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DBC")]
	[Address(RVA = "0x1215C30", Offset = "0x1215C30", VA = "0x1215C30")]
	public SceneViewerGFXPanel()
	{
	}

	// Token: 0x06000DBD RID: 3517 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DBD")]
	[Address(RVA = "0x1215D1C", Offset = "0x1215D1C", VA = "0x1215D1C", Slot = "5")]
	public override void DrawGUI()
	{
	}

	// Token: 0x06000DBE RID: 3518 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DBE")]
	[Address(RVA = "0x1215D98", Offset = "0x1215D98", VA = "0x1215D98")]
	private void DrawSceneList()
	{
	}

	// Token: 0x06000DBF RID: 3519 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DBF")]
	[Address(RVA = "0x1216028", Offset = "0x1216028", VA = "0x1216028")]
	private void DrawTransformList()
	{
	}

	// Token: 0x06000DC0 RID: 3520 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DC0")]
	[Address(RVA = "0x1216A50", Offset = "0x1216A50", VA = "0x1216A50")]
	private void DrawTransform(Transform trm)
	{
	}

	// Token: 0x06000DC1 RID: 3521 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DC1")]
	[Address(RVA = "0x1216E9C", Offset = "0x1216E9C", VA = "0x1216E9C")]
	private void DrawDetail()
	{
	}

	// Token: 0x06000DC2 RID: 3522 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DC2")]
	[Address(RVA = "0x121780C", Offset = "0x121780C", VA = "0x121780C")]
	private void DumpOneMaterialAllTextures(Renderer renderer, Transform trm)
	{
	}

	// Token: 0x06000DC3 RID: 3523 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000DC3")]
	[Address(RVA = "0x1217CD4", Offset = "0x1217CD4", VA = "0x1217CD4")]
	private List<Texture> GetAllTexturesOfMaterial(Material mat)
	{
		return null;
	}

	// Token: 0x06000DC4 RID: 3524 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000DC4")]
	[Address(RVA = "0x1216854", Offset = "0x1216854", VA = "0x1216854")]
	private string GetTrmPath(Transform trm)
	{
		return null;
	}

	// Token: 0x04001131 RID: 4401
	[Token(Token = "0x4001131")]
	[FieldOffset(Offset = "0x18")]
	private Transform currTrm;

	// Token: 0x04001132 RID: 4402
	[Token(Token = "0x4001132")]
	[FieldOffset(Offset = "0x20")]
	private string currSceneName;

	// Token: 0x04001133 RID: 4403
	[Token(Token = "0x4001133")]
	[FieldOffset(Offset = "0x28")]
	private string tempSearchStr;

	// Token: 0x04001134 RID: 4404
	[Token(Token = "0x4001134")]
	[FieldOffset(Offset = "0x30")]
	private string targetSearchStr;

	// Token: 0x04001135 RID: 4405
	[Token(Token = "0x4001135")]
	[FieldOffset(Offset = "0x38")]
	private Transform detailTrm;

	// Token: 0x04001136 RID: 4406
	[Token(Token = "0x4001136")]
	[FieldOffset(Offset = "0x40")]
	private List<GameObject> tempDebugGameObjectList;
}
