using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200026C RID: 620
[Token(Token = "0x200026C")]
public class UvScroller : MonoBehaviour
{
	// Token: 0x06001067 RID: 4199 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001067")]
	[Address(RVA = "0x1BEDC68", Offset = "0x1BEDC68", VA = "0x1BEDC68")]
	private void Awake()
	{
	}

	// Token: 0x06001068 RID: 4200 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001068")]
	[Address(RVA = "0x1BEDDA0", Offset = "0x1BEDDA0", VA = "0x1BEDDA0")]
	private void Start()
	{
	}

	// Token: 0x06001069 RID: 4201 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001069")]
	[Address(RVA = "0x1BEDDA4", Offset = "0x1BEDDA4", VA = "0x1BEDDA4")]
	private void Update()
	{
	}

	// Token: 0x0600106A RID: 4202 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600106A")]
	[Address(RVA = "0x1BEDE68", Offset = "0x1BEDE68", VA = "0x1BEDE68")]
	public UvScroller()
	{
	}

	// Token: 0x04001300 RID: 4864
	[Token(Token = "0x4001300")]
	[FieldOffset(Offset = "0x18")]
	private int targetMaterialSlot;

	// Token: 0x04001301 RID: 4865
	[Token(Token = "0x4001301")]
	[FieldOffset(Offset = "0x1C")]
	public float speedY;

	// Token: 0x04001302 RID: 4866
	[Token(Token = "0x4001302")]
	[FieldOffset(Offset = "0x20")]
	public float speedX;

	// Token: 0x04001303 RID: 4867
	[Token(Token = "0x4001303")]
	[FieldOffset(Offset = "0x24")]
	public float timeWentX;

	// Token: 0x04001304 RID: 4868
	[Token(Token = "0x4001304")]
	[FieldOffset(Offset = "0x28")]
	public float timeWentY;

	// Token: 0x04001305 RID: 4869
	[Token(Token = "0x4001305")]
	[FieldOffset(Offset = "0x30")]
	private Renderer render;

	// Token: 0x04001306 RID: 4870
	[Token(Token = "0x4001306")]
	[FieldOffset(Offset = "0x38")]
	private MaterialPropertyBlock block;
}
