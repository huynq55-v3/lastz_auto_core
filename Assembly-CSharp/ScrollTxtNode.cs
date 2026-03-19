using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

// Token: 0x0200011F RID: 287
[Token(Token = "0x200011F")]
[Hotfix(HotfixFlag.Stateless)]
public class ScrollTxtNode : MonoBehaviour
{
	// Token: 0x06000810 RID: 2064 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000810")]
	[Address(RVA = "0x348020C", Offset = "0x348020C", VA = "0x348020C")]
	private void Start()
	{
	}

	// Token: 0x06000811 RID: 2065 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000811")]
	[Address(RVA = "0x348023C", Offset = "0x348023C", VA = "0x348023C")]
	public void Move()
	{
	}

	// Token: 0x06000812 RID: 2066 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000812")]
	[Address(RVA = "0x3480254", Offset = "0x3480254", VA = "0x3480254")]
	private void Update()
	{
	}

	// Token: 0x06000813 RID: 2067 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000813")]
	[Address(RVA = "0x3480330", Offset = "0x3480330", VA = "0x3480330")]
	public ScrollTxtNode()
	{
	}

	// Token: 0x040005F8 RID: 1528
	[Token(Token = "0x40005F8")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private RectTransform txtRect;

	// Token: 0x040005F9 RID: 1529
	[Token(Token = "0x40005F9")]
	[FieldOffset(Offset = "0x20")]
	public float target;

	// Token: 0x040005FA RID: 1530
	[Token(Token = "0x40005FA")]
	[FieldOffset(Offset = "0x24")]
	public float scrollInterval;

	// Token: 0x040005FB RID: 1531
	[Token(Token = "0x40005FB")]
	[FieldOffset(Offset = "0x28")]
	public float speed;

	// Token: 0x040005FC RID: 1532
	[Token(Token = "0x40005FC")]
	[FieldOffset(Offset = "0x2C")]
	public bool canMove;

	// Token: 0x040005FD RID: 1533
	[Token(Token = "0x40005FD")]
	[FieldOffset(Offset = "0x30")]
	private float scrollTimer;

	// Token: 0x040005FE RID: 1534
	[Token(Token = "0x40005FE")]
	[FieldOffset(Offset = "0x34")]
	private Vector2 originPos;

	// Token: 0x040005FF RID: 1535
	[Token(Token = "0x40005FF")]
	[FieldOffset(Offset = "0x3C")]
	public bool run;
}
