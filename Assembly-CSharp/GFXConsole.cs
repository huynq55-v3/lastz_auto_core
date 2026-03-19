using System;
using BitBenderGames;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001F7 RID: 503
[Token(Token = "0x20001F7")]
public class GFXConsole : BaseGFXConsole
{
	// Token: 0x06000DA5 RID: 3493 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DA5")]
	[Address(RVA = "0x12D7404", Offset = "0x12D7404", VA = "0x12D7404", Slot = "4")]
	protected override void Initialize()
	{
	}

	// Token: 0x06000DA6 RID: 3494 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DA6")]
	[Address(RVA = "0x12D7784", Offset = "0x12D7784", VA = "0x12D7784", Slot = "5")]
	protected override void OnShowConsole()
	{
	}

	// Token: 0x06000DA7 RID: 3495 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DA7")]
	[Address(RVA = "0x12D77B0", Offset = "0x12D77B0", VA = "0x12D77B0", Slot = "6")]
	protected override void OnHideConsole()
	{
	}

	// Token: 0x06000DA8 RID: 3496 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DA8")]
	[Address(RVA = "0x12D77DC", Offset = "0x12D77DC", VA = "0x12D77DC")]
	public GFXConsole()
	{
	}

	// Token: 0x04001111 RID: 4369
	[Token(Token = "0x4001111")]
	[FieldOffset(Offset = "0x60")]
	private GameObject _uiContainerGO;

	// Token: 0x04001112 RID: 4370
	[Token(Token = "0x4001112")]
	[FieldOffset(Offset = "0x68")]
	private GameObject _gfxBg;

	// Token: 0x04001113 RID: 4371
	[Token(Token = "0x4001113")]
	[FieldOffset(Offset = "0x70")]
	private MobileTouchCamera _touchCamera;
}
