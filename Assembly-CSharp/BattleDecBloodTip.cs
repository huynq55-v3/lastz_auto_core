using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200036A RID: 874
[Token(Token = "0x200036A")]
public class BattleDecBloodTip : MonoBehaviour
{
	// Token: 0x06001664 RID: 5732 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001664")]
	[Address(RVA = "0x1EDEB68", Offset = "0x1EDEB68", VA = "0x1EDEB68")]
	public void CSShow(object userData, InstanceRequest instanceRequest)
	{
	}

	// Token: 0x06001665 RID: 5733 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001665")]
	[Address(RVA = "0x1EDED24", Offset = "0x1EDED24", VA = "0x1EDED24")]
	private void StartPlay()
	{
	}

	// Token: 0x06001666 RID: 5734 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001666")]
	[Address(RVA = "0x1EDEEC0", Offset = "0x1EDEEC0", VA = "0x1EDEEC0")]
	private void Update()
	{
	}

	// Token: 0x06001667 RID: 5735 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001667")]
	[Address(RVA = "0x1EDF130", Offset = "0x1EDF130", VA = "0x1EDF130")]
	public BattleDecBloodTip()
	{
	}

	// Token: 0x0400198A RID: 6538
	[Token(Token = "0x400198A")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private SuperTextMesh _num;

	// Token: 0x0400198B RID: 6539
	[Token(Token = "0x400198B")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float _delay;

	// Token: 0x0400198C RID: 6540
	[Token(Token = "0x400198C")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	public float duringTime;

	// Token: 0x0400198D RID: 6541
	[Token(Token = "0x400198D")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private SimpleAnimation anim;

	// Token: 0x0400198E RID: 6542
	[Token(Token = "0x400198E")]
	[FieldOffset(Offset = "0x30")]
	private Vector3 newpos;

	// Token: 0x0400198F RID: 6543
	[Token(Token = "0x400198F")]
	[FieldOffset(Offset = "0x3C")]
	private float distance;

	// Token: 0x04001990 RID: 6544
	[Token(Token = "0x4001990")]
	[FieldOffset(Offset = "0x40")]
	private bool _isShow;

	// Token: 0x04001991 RID: 6545
	[Token(Token = "0x4001991")]
	[FieldOffset(Offset = "0x41")]
	private bool _isOnce;

	// Token: 0x04001992 RID: 6546
	[Token(Token = "0x4001992")]
	[FieldOffset(Offset = "0x44")]
	private float time;

	// Token: 0x04001993 RID: 6547
	[Token(Token = "0x4001993")]
	[FieldOffset(Offset = "0x48")]
	private InstanceRequest _InstanceRequest;

	// Token: 0x0200036B RID: 875
	[Token(Token = "0x200036B")]
	public class Param
	{
		// Token: 0x06001668 RID: 5736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001668")]
		[Address(RVA = "0x1EDF140", Offset = "0x1EDF140", VA = "0x1EDF140")]
		public Param()
		{
		}

		// Token: 0x04001994 RID: 6548
		[Token(Token = "0x4001994")]
		[FieldOffset(Offset = "0x10")]
		public Vector3 startPos;

		// Token: 0x04001995 RID: 6549
		[Token(Token = "0x4001995")]
		[FieldOffset(Offset = "0x1C")]
		public int num;

		// Token: 0x04001996 RID: 6550
		[Token(Token = "0x4001996")]
		[FieldOffset(Offset = "0x20")]
		public string path;
	}
}
