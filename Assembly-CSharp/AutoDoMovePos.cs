using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200034F RID: 847
[Token(Token = "0x200034F")]
public class AutoDoMovePos : MonoBehaviour
{
	// Token: 0x060015EA RID: 5610 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015EA")]
	[Address(RVA = "0x1ED93FC", Offset = "0x1ED93FC", VA = "0x1ED93FC")]
	private void Awake()
	{
	}

	// Token: 0x060015EB RID: 5611 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015EB")]
	[Address(RVA = "0x1ED9478", Offset = "0x1ED9478", VA = "0x1ED9478")]
	public void Init(string posLists)
	{
	}

	// Token: 0x060015EC RID: 5612 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015EC")]
	[Address(RVA = "0x1ED9740", Offset = "0x1ED9740", VA = "0x1ED9740")]
	private void Update()
	{
	}

	// Token: 0x060015ED RID: 5613 RVA: 0x00008718 File Offset: 0x00006918
	[Token(Token = "0x60015ED")]
	[Address(RVA = "0x1ED97C4", Offset = "0x1ED97C4", VA = "0x1ED97C4")]
	public float GetDownTime()
	{
		return 0f;
	}

	// Token: 0x060015EE RID: 5614 RVA: 0x00008730 File Offset: 0x00006930
	[Token(Token = "0x60015EE")]
	[Address(RVA = "0x1ED981C", Offset = "0x1ED981C", VA = "0x1ED981C")]
	public float GetUpTime()
	{
		return 0f;
	}

	// Token: 0x060015EF RID: 5615 RVA: 0x00008748 File Offset: 0x00006948
	[Token(Token = "0x60015EF")]
	[Address(RVA = "0x1ED9874", Offset = "0x1ED9874", VA = "0x1ED9874")]
	public float GetMoveSpeed()
	{
		return 0f;
	}

	// Token: 0x060015F0 RID: 5616 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015F0")]
	[Address(RVA = "0x1ED98CC", Offset = "0x1ED98CC", VA = "0x1ED98CC")]
	public void ChangeStartPos()
	{
	}

	// Token: 0x060015F1 RID: 5617 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015F1")]
	[Address(RVA = "0x1ED9A60", Offset = "0x1ED9A60", VA = "0x1ED9A60")]
	public void ChangeEndPos()
	{
	}

	// Token: 0x060015F2 RID: 5618 RVA: 0x00008760 File Offset: 0x00006960
	[Token(Token = "0x60015F2")]
	[Address(RVA = "0x1ED9AD0", Offset = "0x1ED9AD0", VA = "0x1ED9AD0")]
	public int GetMovePosListCount()
	{
		return 0;
	}

	// Token: 0x060015F3 RID: 5619 RVA: 0x00008778 File Offset: 0x00006978
	[Token(Token = "0x60015F3")]
	[Address(RVA = "0x1ED990C", Offset = "0x1ED990C", VA = "0x1ED990C")]
	public Vector3 GetScreenPos(int index)
	{
		return default(Vector3);
	}

	// Token: 0x060015F4 RID: 5620 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015F4")]
	[Address(RVA = "0x1ED9B18", Offset = "0x1ED9B18", VA = "0x1ED9B18")]
	public AutoDoMovePos()
	{
	}

	// Token: 0x04001910 RID: 6416
	[Token(Token = "0x4001910")]
	[FieldOffset(Offset = "0x0")]
	public static float MoveSpeed;

	// Token: 0x04001911 RID: 6417
	[Token(Token = "0x4001911")]
	[FieldOffset(Offset = "0x4")]
	public static float DownTime;

	// Token: 0x04001912 RID: 6418
	[Token(Token = "0x4001912")]
	[FieldOffset(Offset = "0x8")]
	public static float UpTime;

	// Token: 0x04001913 RID: 6419
	[Token(Token = "0x4001913")]
	[FieldOffset(Offset = "0x18")]
	private List<AutoDoMovePos.PosParam> _posList;

	// Token: 0x04001914 RID: 6420
	[Token(Token = "0x4001914")]
	[FieldOffset(Offset = "0x20")]
	private AutoDoMovePosMachine _machine;

	// Token: 0x02000350 RID: 848
	[Token(Token = "0x2000350")]
	public class PosParam
	{
		// Token: 0x060015F6 RID: 5622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015F6")]
		[Address(RVA = "0x1ED96D8", Offset = "0x1ED96D8", VA = "0x1ED96D8")]
		public PosParam()
		{
		}

		// Token: 0x04001915 RID: 6421
		[Token(Token = "0x4001915")]
		[FieldOffset(Offset = "0x10")]
		public Vector3 pos;

		// Token: 0x04001916 RID: 6422
		[Token(Token = "0x4001916")]
		[FieldOffset(Offset = "0x1C")]
		public AutoDoMovePos.PositionType positionType;
	}

	// Token: 0x02000351 RID: 849
	[Token(Token = "0x2000351")]
	public enum PositionType
	{
		// Token: 0x04001918 RID: 6424
		[Token(Token = "0x4001918")]
		World = 1,
		// Token: 0x04001919 RID: 6425
		[Token(Token = "0x4001919")]
		Screen
	}

	// Token: 0x02000352 RID: 850
	[Token(Token = "0x2000352")]
	public enum PlayAnimName
	{
		// Token: 0x0400191B RID: 6427
		[Token(Token = "0x400191B")]
		Down = 1,
		// Token: 0x0400191C RID: 6428
		[Token(Token = "0x400191C")]
		Up
	}
}
