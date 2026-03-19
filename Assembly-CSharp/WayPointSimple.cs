using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002C6 RID: 710
[Token(Token = "0x20002C6")]
public class WayPointSimple : MonoBehaviour
{
	// Token: 0x06001271 RID: 4721 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001271")]
	[Address(RVA = "0x1C5C8F0", Offset = "0x1C5C8F0", VA = "0x1C5C8F0")]
	public WayPointSimple()
	{
	}

	// Token: 0x0400152A RID: 5418
	[Token(Token = "0x400152A")]
	[FieldOffset(Offset = "0x18")]
	public List<WayPointSimple> Neighbors;

	// Token: 0x0400152B RID: 5419
	[Token(Token = "0x400152B")]
	[FieldOffset(Offset = "0x20")]
	public string Param;

	// Token: 0x0400152C RID: 5420
	[Token(Token = "0x400152C")]
	[FieldOffset(Offset = "0x28")]
	public bool IsDoor;

	// Token: 0x0400152D RID: 5421
	[Token(Token = "0x400152D")]
	[FieldOffset(Offset = "0x30")]
	public string Func;

	// Token: 0x0400152E RID: 5422
	[Token(Token = "0x400152E")]
	[FieldOffset(Offset = "0x38")]
	public string Index;
}
