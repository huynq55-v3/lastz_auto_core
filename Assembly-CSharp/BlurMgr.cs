using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000332 RID: 818
[Token(Token = "0x2000332")]
public class BlurMgr
{
	// Token: 0x0600156C RID: 5484 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600156C")]
	[Address(RVA = "0x1ED1A80", Offset = "0x1ED1A80", VA = "0x1ED1A80")]
	private BlurMgr()
	{
	}

	// Token: 0x0600156D RID: 5485 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600156D")]
	[Address(RVA = "0x1ED1B90", Offset = "0x1ED1B90", VA = "0x1ED1B90")]
	public static BlurMgr Inst()
	{
		return null;
	}

	// Token: 0x0600156E RID: 5486 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600156E")]
	[Address(RVA = "0x1ED1C1C", Offset = "0x1ED1C1C", VA = "0x1ED1C1C")]
	public void Register()
	{
	}

	// Token: 0x0600156F RID: 5487 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600156F")]
	[Address(RVA = "0x1ED1C94", Offset = "0x1ED1C94", VA = "0x1ED1C94")]
	public void UnRegister()
	{
	}

	// Token: 0x06001570 RID: 5488 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001570")]
	[Address(RVA = "0x1ED1C2C", Offset = "0x1ED1C2C", VA = "0x1ED1C2C")]
	private void CheckStatus()
	{
	}

	// Token: 0x06001571 RID: 5489 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001571")]
	[Address(RVA = "0x1ED1CA4", Offset = "0x1ED1CA4", VA = "0x1ED1CA4")]
	public void ToggleRenderFeature(bool isToggle)
	{
	}

	// Token: 0x04001861 RID: 6241
	[Token(Token = "0x4001861")]
	[FieldOffset(Offset = "0x10")]
	private int index;

	// Token: 0x04001862 RID: 6242
	[Token(Token = "0x4001862")]
	[FieldOffset(Offset = "0x14")]
	private bool m_isToggle;

	// Token: 0x04001863 RID: 6243
	[Token(Token = "0x4001863")]
	[FieldOffset(Offset = "0x18")]
	private GameObject m_blurCamera;

	// Token: 0x04001864 RID: 6244
	[Token(Token = "0x4001864")]
	[FieldOffset(Offset = "0x20")]
	private Canvas m_rootCanvas;

	// Token: 0x04001865 RID: 6245
	[Token(Token = "0x4001865")]
	[FieldOffset(Offset = "0x28")]
	private Camera m_uiCamera;

	// Token: 0x04001866 RID: 6246
	[Token(Token = "0x4001866")]
	[FieldOffset(Offset = "0x0")]
	private static BlurMgr _inst;
}
