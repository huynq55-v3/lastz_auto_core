using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000368 RID: 872
[Token(Token = "0x2000368")]
public class BaseGlassShield : MonoBehaviour
{
	// Token: 0x0600165D RID: 5725 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600165D")]
	[Address(RVA = "0x1EDE680", Offset = "0x1EDE680", VA = "0x1EDE680")]
	private void Awake()
	{
	}

	// Token: 0x0600165E RID: 5726 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600165E")]
	[Address(RVA = "0x1EDE688", Offset = "0x1EDE688", VA = "0x1EDE688")]
	public void Hit()
	{
	}

	// Token: 0x0600165F RID: 5727 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600165F")]
	[Address(RVA = "0x1EDE7F4", Offset = "0x1EDE7F4", VA = "0x1EDE7F4")]
	private void Update()
	{
	}

	// Token: 0x06001660 RID: 5728 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001660")]
	[Address(RVA = "0x1EDEA78", Offset = "0x1EDEA78", VA = "0x1EDEA78")]
	private void OnTriggerEnter(Collider other)
	{
	}

	// Token: 0x06001661 RID: 5729 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001661")]
	[Address(RVA = "0x1EDEAFC", Offset = "0x1EDEAFC", VA = "0x1EDEAFC")]
	public BaseGlassShield()
	{
	}

	// Token: 0x0400197A RID: 6522
	[Token(Token = "0x400197A")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Material _material;

	// Token: 0x0400197B RID: 6523
	[Token(Token = "0x400197B")]
	[FieldOffset(Offset = "0x0")]
	public static float GlassShieldShowTime;

	// Token: 0x0400197C RID: 6524
	[Token(Token = "0x400197C")]
	[FieldOffset(Offset = "0x4")]
	public static float GlassShieldHideTime;

	// Token: 0x0400197D RID: 6525
	[Token(Token = "0x400197D")]
	[FieldOffset(Offset = "0x8")]
	public static float GlassShieldHitShowDuringTime;

	// Token: 0x0400197E RID: 6526
	[Token(Token = "0x400197E")]
	[FieldOffset(Offset = "0xC")]
	public static float GlassShieldShowMaxValue;

	// Token: 0x0400197F RID: 6527
	[Token(Token = "0x400197F")]
	[FieldOffset(Offset = "0x10")]
	public static float GlassShieldHideMaxValue;

	// Token: 0x04001980 RID: 6528
	[Token(Token = "0x4001980")]
	[FieldOffset(Offset = "0x14")]
	public static float GlassShieldHitTime;

	// Token: 0x04001981 RID: 6529
	[Token(Token = "0x4001981")]
	[FieldOffset(Offset = "0x18")]
	public static float GlassShieldHitMaxValue;

	// Token: 0x04001982 RID: 6530
	[Token(Token = "0x4001982")]
	[FieldOffset(Offset = "0x1C")]
	public static float GlassShieldHitMinValue;

	// Token: 0x04001983 RID: 6531
	[Token(Token = "0x4001983")]
	[FieldOffset(Offset = "0x20")]
	private BaseGlassShield.State _state;

	// Token: 0x04001984 RID: 6532
	[Token(Token = "0x4001984")]
	[FieldOffset(Offset = "0x24")]
	private float _time;

	// Token: 0x02000369 RID: 873
	[Token(Token = "0x2000369")]
	private enum State
	{
		// Token: 0x04001986 RID: 6534
		[Token(Token = "0x4001986")]
		Normal,
		// Token: 0x04001987 RID: 6535
		[Token(Token = "0x4001987")]
		Show,
		// Token: 0x04001988 RID: 6536
		[Token(Token = "0x4001988")]
		Hide,
		// Token: 0x04001989 RID: 6537
		[Token(Token = "0x4001989")]
		Hit
	}
}
