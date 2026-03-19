using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200027E RID: 638
[Token(Token = "0x200027E")]
public class DisapearObject : MonoBehaviour
{
	// Token: 0x060010FE RID: 4350 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010FE")]
	[Address(RVA = "0x1BF3160", Offset = "0x1BF3160", VA = "0x1BF3160")]
	private void Awake()
	{
	}

	// Token: 0x060010FF RID: 4351 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010FF")]
	[Address(RVA = "0x1BF326C", Offset = "0x1BF326C", VA = "0x1BF326C")]
	private void Update()
	{
	}

	// Token: 0x06001100 RID: 4352 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001100")]
	[Address(RVA = "0x1BF34C4", Offset = "0x1BF34C4", VA = "0x1BF34C4")]
	private void StartFadeOut()
	{
	}

	// Token: 0x06001101 RID: 4353 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001101")]
	[Address(RVA = "0x1BF34D0", Offset = "0x1BF34D0", VA = "0x1BF34D0")]
	public DisapearObject()
	{
	}

	// Token: 0x040013A6 RID: 5030
	[Token(Token = "0x40013A6")]
	[FieldOffset(Offset = "0x18")]
	private bool startEvent;

	// Token: 0x040013A7 RID: 5031
	[Token(Token = "0x40013A7")]
	[FieldOffset(Offset = "0x1C")]
	private Color destColor;

	// Token: 0x040013A8 RID: 5032
	[Token(Token = "0x40013A8")]
	[FieldOffset(Offset = "0x2C")]
	private float timeToFade;

	// Token: 0x040013A9 RID: 5033
	[Token(Token = "0x40013A9")]
	[FieldOffset(Offset = "0x30")]
	public bool isImmediate;

	// Token: 0x040013AA RID: 5034
	[Token(Token = "0x40013AA")]
	[FieldOffset(Offset = "0x31")]
	public bool isRootJoint;

	// Token: 0x040013AB RID: 5035
	[Token(Token = "0x40013AB")]
	[FieldOffset(Offset = "0x38")]
	private List<Renderer> m_disappearList;
}
