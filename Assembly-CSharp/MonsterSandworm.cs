using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200036D RID: 877
[Token(Token = "0x200036D")]
public class MonsterSandworm : MonoBehaviour
{
	// Token: 0x0600166F RID: 5743 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600166F")]
	[Address(RVA = "0x1EDF504", Offset = "0x1EDF504", VA = "0x1EDF504")]
	private void Awake()
	{
	}

	// Token: 0x06001670 RID: 5744 RVA: 0x00008868 File Offset: 0x00006A68
	[Token(Token = "0x6001670")]
	[Address(RVA = "0x1EDF5F4", Offset = "0x1EDF5F4", VA = "0x1EDF5F4")]
	private float Play(string animName)
	{
		return 0f;
	}

	// Token: 0x06001671 RID: 5745 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001671")]
	[Address(RVA = "0x1EDF6D0", Offset = "0x1EDF6D0", VA = "0x1EDF6D0")]
	private void CheckPlayAnim()
	{
	}

	// Token: 0x06001672 RID: 5746 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001672")]
	[Address(RVA = "0x1EDF904", Offset = "0x1EDF904", VA = "0x1EDF904")]
	private void OnDisable()
	{
	}

	// Token: 0x06001673 RID: 5747 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001673")]
	[Address(RVA = "0x1EDF90C", Offset = "0x1EDF90C", VA = "0x1EDF90C")]
	private void OnEnable()
	{
	}

	// Token: 0x06001674 RID: 5748 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001674")]
	[Address(RVA = "0x1EDF924", Offset = "0x1EDF924", VA = "0x1EDF924")]
	public MonsterSandworm()
	{
	}

	// Token: 0x0400199B RID: 6555
	[Token(Token = "0x400199B")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GPUSkinningAnimator _monsterAnim;

	// Token: 0x0400199C RID: 6556
	[Token(Token = "0x400199C")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private SimpleAnimation _effectAnim;

	// Token: 0x0400199D RID: 6557
	[Token(Token = "0x400199D")]
	[FieldOffset(Offset = "0x0")]
	public static string[] TestAnimList;

	// Token: 0x0400199E RID: 6558
	[Token(Token = "0x400199E")]
	[FieldOffset(Offset = "0x8")]
	public static float UnderWaitTime;

	// Token: 0x0400199F RID: 6559
	[Token(Token = "0x400199F")]
	[FieldOffset(Offset = "0x28")]
	public string[] randomAnimList;

	// Token: 0x040019A0 RID: 6560
	[Token(Token = "0x40019A0")]
	[FieldOffset(Offset = "0x30")]
	private int _curIndex;

	// Token: 0x040019A1 RID: 6561
	[Token(Token = "0x40019A1")]
	[FieldOffset(Offset = "0x34")]
	private bool _isTimerDuring;

	// Token: 0x040019A2 RID: 6562
	[Token(Token = "0x40019A2")]
	[FieldOffset(Offset = "0x35")]
	private bool _isActive;

	// Token: 0x0200036E RID: 878
	[Token(Token = "0x200036E")]
	public static class AnimName
	{
		// Token: 0x040019A3 RID: 6563
		[Token(Token = "0x40019A3")]
		public const string attack = "attack";

		// Token: 0x040019A4 RID: 6564
		[Token(Token = "0x40019A4")]
		public const string skill = "skill";

		// Token: 0x040019A5 RID: 6565
		[Token(Token = "0x40019A5")]
		public const string Idle = "idle";
	}
}
