using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002A8 RID: 680
[Token(Token = "0x20002A8")]
public class ParkourDynamicRoot : MonoBehaviour
{
	// Token: 0x060011BA RID: 4538 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011BA")]
	[Address(RVA = "0x1C53648", Offset = "0x1C53648", VA = "0x1C53648")]
	private void LateUpdate()
	{
	}

	// Token: 0x060011BB RID: 4539 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011BB")]
	[Address(RVA = "0x1C53664", Offset = "0x1C53664", VA = "0x1C53664")]
	public void SetParkourLogicLateUpdate(Action lateUpdate)
	{
	}

	// Token: 0x060011BC RID: 4540 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011BC")]
	[Address(RVA = "0x1C5366C", Offset = "0x1C5366C", VA = "0x1C5366C")]
	public ParkourDynamicRoot()
	{
	}

	// Token: 0x04001494 RID: 5268
	[Token(Token = "0x4001494")]
	[FieldOffset(Offset = "0x18")]
	private Action parkourLogicLateUpdate;
}
