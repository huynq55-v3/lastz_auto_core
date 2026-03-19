using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000255 RID: 597
[Token(Token = "0x2000255")]
public class EnterTrigger : MonoBehaviour
{
	// Token: 0x06000FEE RID: 4078 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FEE")]
	[Address(RVA = "0x1BE9250", Offset = "0x1BE9250", VA = "0x1BE9250")]
	private void Awake()
	{
	}

	// Token: 0x06000FEF RID: 4079 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FEF")]
	[Address(RVA = "0x1BE92B4", Offset = "0x1BE92B4", VA = "0x1BE92B4")]
	private void Update()
	{
	}

	// Token: 0x06000FF0 RID: 4080 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FF0")]
	[Address(RVA = "0x1BE9658", Offset = "0x1BE9658", VA = "0x1BE9658")]
	private void OnTriggerEnter(Collider other)
	{
	}

	// Token: 0x06000FF1 RID: 4081 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FF1")]
	[Address(RVA = "0x1BE9460", Offset = "0x1BE9460", VA = "0x1BE9460")]
	private void SetControlGoListActive(bool active)
	{
	}

	// Token: 0x06000FF2 RID: 4082 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FF2")]
	[Address(RVA = "0x1BE96F4", Offset = "0x1BE96F4", VA = "0x1BE96F4")]
	private void OnTriggerExit(Collider other)
	{
	}

	// Token: 0x06000FF3 RID: 4083 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FF3")]
	[Address(RVA = "0x1BE9878", Offset = "0x1BE9878", VA = "0x1BE9878")]
	private void OnTriggerStay(Collider other)
	{
	}

	// Token: 0x06000FF4 RID: 4084 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FF4")]
	[Address(RVA = "0x1BE987C", Offset = "0x1BE987C", VA = "0x1BE987C")]
	public EnterTrigger()
	{
	}

	// Token: 0x0400125F RID: 4703
	[Token(Token = "0x400125F")]
	[FieldOffset(Offset = "0x18")]
	private int _WallSphereRadius;

	// Token: 0x04001260 RID: 4704
	[Token(Token = "0x4001260")]
	[FieldOffset(Offset = "0x20")]
	private GameObject player;

	// Token: 0x04001261 RID: 4705
	[Token(Token = "0x4001261")]
	[FieldOffset(Offset = "0x28")]
	private bool isLerp;

	// Token: 0x04001262 RID: 4706
	[Token(Token = "0x4001262")]
	[FieldOffset(Offset = "0x29")]
	private bool isEnter;

	// Token: 0x04001263 RID: 4707
	[Token(Token = "0x4001263")]
	[FieldOffset(Offset = "0x2C")]
	private float t;

	// Token: 0x04001264 RID: 4708
	[Token(Token = "0x4001264")]
	private const float minSphereRadius = 2f;

	// Token: 0x04001265 RID: 4709
	[Token(Token = "0x4001265")]
	[FieldOffset(Offset = "0x30")]
	public float speed;

	// Token: 0x04001266 RID: 4710
	[Token(Token = "0x4001266")]
	[FieldOffset(Offset = "0x34")]
	public Vector3 selfDirection;

	// Token: 0x04001267 RID: 4711
	[Token(Token = "0x4001267")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	public int roomID;

	// Token: 0x04001268 RID: 4712
	[Token(Token = "0x4001268")]
	[FieldOffset(Offset = "0x44")]
	private float lastEnterTime;

	// Token: 0x04001269 RID: 4713
	[Token(Token = "0x4001269")]
	[FieldOffset(Offset = "0x48")]
	private float lastExitTime;

	// Token: 0x0400126A RID: 4714
	[Token(Token = "0x400126A")]
	[FieldOffset(Offset = "0x50")]
	public Transform centerPos;

	// Token: 0x0400126B RID: 4715
	[Token(Token = "0x400126B")]
	[FieldOffset(Offset = "0x58")]
	public List<GameObject> controlGoList;
}
