using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x020001F9 RID: 505
[Token(Token = "0x20001F9")]
public class PostProcessGFXPanel : BaseGFXPanel
{
	// Token: 0x06000DAD RID: 3501 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DAD")]
	[Address(RVA = "0x12D76CC", Offset = "0x12D76CC", VA = "0x12D76CC")]
	public PostProcessGFXPanel()
	{
	}

	// Token: 0x06000DAE RID: 3502 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DAE")]
	[Address(RVA = "0x12D84D0", Offset = "0x12D84D0", VA = "0x12D84D0", Slot = "4")]
	public override void Init()
	{
	}

	// Token: 0x06000DAF RID: 3503 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DAF")]
	[Address(RVA = "0x12D8664", Offset = "0x12D8664", VA = "0x12D8664", Slot = "5")]
	public override void DrawGUI()
	{
	}

	// Token: 0x06000DB0 RID: 3504 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DB0")]
	[Address(RVA = "0x12D8AB0", Offset = "0x12D8AB0", VA = "0x12D8AB0")]
	private void DoDrawPostProcessingModle(VolumeComponent com)
	{
	}

	// Token: 0x04001121 RID: 4385
	[Token(Token = "0x4001121")]
	[FieldOffset(Offset = "0x18")]
	private Camera _mainCamera;

	// Token: 0x04001122 RID: 4386
	[Token(Token = "0x4001122")]
	[FieldOffset(Offset = "0x20")]
	private Volume _ppVolume;
}
