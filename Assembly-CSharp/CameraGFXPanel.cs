using System;
using System.Collections.Generic;
using BitBenderGames;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001F8 RID: 504
[Token(Token = "0x20001F8")]
public class CameraGFXPanel : BaseGFXPanel
{
	// Token: 0x06000DA9 RID: 3497 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DA9")]
	[Address(RVA = "0x12D7728", Offset = "0x12D7728", VA = "0x12D7728")]
	public CameraGFXPanel()
	{
	}

	// Token: 0x06000DAA RID: 3498 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DAA")]
	[Address(RVA = "0x12D77FC", Offset = "0x12D77FC", VA = "0x12D77FC", Slot = "4")]
	public override void Init()
	{
	}

	// Token: 0x06000DAB RID: 3499 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DAB")]
	[Address(RVA = "0x12D7A20", Offset = "0x12D7A20", VA = "0x12D7A20", Slot = "5")]
	public override void DrawGUI()
	{
	}

	// Token: 0x06000DAC RID: 3500 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DAC")]
	[Address(RVA = "0x12D7C64", Offset = "0x12D7C64", VA = "0x12D7C64")]
	private void DrawZoomParams()
	{
	}

	// Token: 0x04001114 RID: 4372
	[Token(Token = "0x4001114")]
	[FieldOffset(Offset = "0x18")]
	private Camera _mainCamera;

	// Token: 0x04001115 RID: 4373
	[Token(Token = "0x4001115")]
	[FieldOffset(Offset = "0x20")]
	private string camZoomInit;

	// Token: 0x04001116 RID: 4374
	[Token(Token = "0x4001116")]
	[FieldOffset(Offset = "0x28")]
	private string camZoomMin;

	// Token: 0x04001117 RID: 4375
	[Token(Token = "0x4001117")]
	[FieldOffset(Offset = "0x30")]
	private string camZoomMax;

	// Token: 0x04001118 RID: 4376
	[Token(Token = "0x4001118")]
	[FieldOffset(Offset = "0x38")]
	private string camZoom;

	// Token: 0x04001119 RID: 4377
	[Token(Token = "0x4001119")]
	[FieldOffset(Offset = "0x40")]
	private string camZoomBuild;

	// Token: 0x0400111A RID: 4378
	[Token(Token = "0x400111A")]
	[FieldOffset(Offset = "0x48")]
	private string camZoomFocusRotation;

	// Token: 0x0400111B RID: 4379
	[Token(Token = "0x400111B")]
	[FieldOffset(Offset = "0x50")]
	private string camZoomFarmPlant;

	// Token: 0x0400111C RID: 4380
	[Token(Token = "0x400111C")]
	[FieldOffset(Offset = "0x58")]
	private string camZoomFarmPlantRotation;

	// Token: 0x0400111D RID: 4381
	[Token(Token = "0x400111D")]
	[FieldOffset(Offset = "0x60")]
	private string camZoomFormation;

	// Token: 0x0400111E RID: 4382
	[Token(Token = "0x400111E")]
	[FieldOffset(Offset = "0x68")]
	private string camZoomFormationRotation;

	// Token: 0x0400111F RID: 4383
	[Token(Token = "0x400111F")]
	[FieldOffset(Offset = "0x70")]
	private List<MobileTouchCamera.ZoomParam> zoomParams;

	// Token: 0x04001120 RID: 4384
	[Token(Token = "0x4001120")]
	[FieldOffset(Offset = "0x78")]
	private bool camToggle;
}
