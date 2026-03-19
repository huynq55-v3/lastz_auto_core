using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002A7 RID: 679
[Token(Token = "0x20002A7")]
public class ObjectPatrol : MonoBehaviour
{
	// Token: 0x060011B1 RID: 4529 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011B1")]
	[Address(RVA = "0x1C53348", Offset = "0x1C53348", VA = "0x1C53348")]
	private void Awake()
	{
	}

	// Token: 0x060011B2 RID: 4530 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011B2")]
	[Address(RVA = "0x1C5336C", Offset = "0x1C5336C", VA = "0x1C5336C")]
	private void Start()
	{
	}

	// Token: 0x060011B3 RID: 4531 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011B3")]
	[Address(RVA = "0x1C53374", Offset = "0x1C53374", VA = "0x1C53374")]
	private void FixedUpdate()
	{
	}

	// Token: 0x060011B4 RID: 4532 RVA: 0x00006FA8 File Offset: 0x000051A8
	[Token(Token = "0x60011B4")]
	[Address(RVA = "0x1C53530", Offset = "0x1C53530", VA = "0x1C53530")]
	private float Get_Distance(Vector3 point)
	{
		return 0f;
	}

	// Token: 0x060011B5 RID: 4533 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011B5")]
	[Address(RVA = "0x1C533A4", Offset = "0x1C533A4", VA = "0x1C533A4")]
	private void Move_line0()
	{
	}

	// Token: 0x060011B6 RID: 4534 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011B6")]
	[Address(RVA = "0x1C53474", Offset = "0x1C53474", VA = "0x1C53474")]
	private void Move_line1()
	{
	}

	// Token: 0x060011B7 RID: 4535 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011B7")]
	[Address(RVA = "0x1C534C4", Offset = "0x1C534C4", VA = "0x1C534C4")]
	private void Move_line2()
	{
	}

	// Token: 0x060011B8 RID: 4536 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011B8")]
	[Address(RVA = "0x1C5358C", Offset = "0x1C5358C", VA = "0x1C5358C")]
	private void Move()
	{
	}

	// Token: 0x060011B9 RID: 4537 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011B9")]
	[Address(RVA = "0x1C53638", Offset = "0x1C53638", VA = "0x1C53638")]
	public ObjectPatrol()
	{
	}

	// Token: 0x0400148A RID: 5258
	[Token(Token = "0x400148A")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public Vector3[] line_array;

	// Token: 0x0400148B RID: 5259
	[Token(Token = "0x400148B")]
	[FieldOffset(Offset = "0x20")]
	[Range(0f, 50f)]
	public float speed;

	// Token: 0x0400148C RID: 5260
	[Token(Token = "0x400148C")]
	[FieldOffset(Offset = "0x24")]
	[Range(0f, 2f)]
	public int move_method;

	// Token: 0x0400148D RID: 5261
	[Token(Token = "0x400148D")]
	[FieldOffset(Offset = "0x28")]
	private Rigidbody2D body;

	// Token: 0x0400148E RID: 5262
	[Token(Token = "0x400148E")]
	[FieldOffset(Offset = "0x30")]
	[Range(0f, 10f)]
	public float point_waittime;

	// Token: 0x0400148F RID: 5263
	[Token(Token = "0x400148F")]
	[FieldOffset(Offset = "0x34")]
	[Range(0f, 10f)]
	public float point_distance;

	// Token: 0x04001490 RID: 5264
	[Token(Token = "0x4001490")]
	[FieldOffset(Offset = "0x38")]
	private int index;

	// Token: 0x04001491 RID: 5265
	[Token(Token = "0x4001491")]
	[FieldOffset(Offset = "0x3C")]
	private bool set;

	// Token: 0x04001492 RID: 5266
	[Token(Token = "0x4001492")]
	[FieldOffset(Offset = "0x40")]
	private Transform tran;

	// Token: 0x04001493 RID: 5267
	[Token(Token = "0x4001493")]
	[FieldOffset(Offset = "0x48")]
	public bool isRun;
}
