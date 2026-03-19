using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering.Universal;

// Token: 0x020001FC RID: 508
[Token(Token = "0x20001FC")]
public class QualitySettingGFXPanel : BaseGFXPanel
{
	// Token: 0x06000DB7 RID: 3511 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DB7")]
	[Address(RVA = "0x12147CC", Offset = "0x12147CC", VA = "0x12147CC")]
	public QualitySettingGFXPanel()
	{
	}

	// Token: 0x06000DB8 RID: 3512 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DB8")]
	[Address(RVA = "0x1214A18", Offset = "0x1214A18", VA = "0x1214A18", Slot = "4")]
	public override void Init()
	{
	}

	// Token: 0x06000DB9 RID: 3513 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DB9")]
	[Address(RVA = "0x1214B5C", Offset = "0x1214B5C", VA = "0x1214B5C", Slot = "5")]
	public override void DrawGUI()
	{
	}

	// Token: 0x06000DBA RID: 3514 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000DBA")]
	[Address(RVA = "0x1215B80", Offset = "0x1215B80", VA = "0x1215B80")]
	private string GetAntialiasingModeText(AntialiasingMode mode)
	{
		return null;
	}

	// Token: 0x06000DBB RID: 3515 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000DBB")]
	[Address(RVA = "0x1215C00", Offset = "0x1215C00", VA = "0x1215C00")]
	private string GetSMAAQualityText(AntialiasingQuality quality)
	{
		return null;
	}

	// Token: 0x0400112A RID: 4394
	[Token(Token = "0x400112A")]
	[FieldOffset(Offset = "0x18")]
	private Camera mainCamera;

	// Token: 0x0400112B RID: 4395
	[Token(Token = "0x400112B")]
	[FieldOffset(Offset = "0x20")]
	private int initScreenWidth;

	// Token: 0x0400112C RID: 4396
	[Token(Token = "0x400112C")]
	[FieldOffset(Offset = "0x24")]
	private int initScreenHeight;

	// Token: 0x0400112D RID: 4397
	[Token(Token = "0x400112D")]
	[FieldOffset(Offset = "0x28")]
	private int pixelWidthMax;

	// Token: 0x0400112E RID: 4398
	[Token(Token = "0x400112E")]
	[FieldOffset(Offset = "0x2C")]
	private int pixelHeightMax;

	// Token: 0x0400112F RID: 4399
	[Token(Token = "0x400112F")]
	[FieldOffset(Offset = "0x30")]
	private int smaaQuality;

	// Token: 0x04001130 RID: 4400
	[Token(Token = "0x4001130")]
	[FieldOffset(Offset = "0x38")]
	private string[] smaaQualityString;
}
