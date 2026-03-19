using System;
using Il2CppDummyDll;

// Token: 0x020001FE RID: 510
[Token(Token = "0x20001FE")]
public class ScreenGFXPanel : BaseGFXPanel
{
	// Token: 0x06000DC5 RID: 3525 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DC5")]
	[Address(RVA = "0x1217EA0", Offset = "0x1217EA0", VA = "0x1217EA0")]
	public ScreenGFXPanel()
	{
	}

	// Token: 0x06000DC6 RID: 3526 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DC6")]
	[Address(RVA = "0x1217F4C", Offset = "0x1217F4C", VA = "0x1217F4C", Slot = "4")]
	public override void Init()
	{
	}

	// Token: 0x06000DC7 RID: 3527 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DC7")]
	[Address(RVA = "0x1217FD0", Offset = "0x1217FD0", VA = "0x1217FD0", Slot = "5")]
	public override void DrawGUI()
	{
	}

	// Token: 0x04001137 RID: 4407
	[Token(Token = "0x4001137")]
	[FieldOffset(Offset = "0x18")]
	private float urpResolutionScale;

	// Token: 0x04001138 RID: 4408
	[Token(Token = "0x4001138")]
	[FieldOffset(Offset = "0x1C")]
	private float fullResolutionScale;

	// Token: 0x04001139 RID: 4409
	[Token(Token = "0x4001139")]
	[FieldOffset(Offset = "0x20")]
	private int initScreenWidth;

	// Token: 0x0400113A RID: 4410
	[Token(Token = "0x400113A")]
	[FieldOffset(Offset = "0x24")]
	private int initScreenHeight;

	// Token: 0x0400113B RID: 4411
	[Token(Token = "0x400113B")]
	[FieldOffset(Offset = "0x28")]
	private int targetFramerate;
}
