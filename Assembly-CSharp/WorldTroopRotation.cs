using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000375 RID: 885
[Token(Token = "0x2000375")]
public class WorldTroopRotation : MonoBehaviour
{
	// Token: 0x06001687 RID: 5767 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001687")]
	[Address(RVA = "0x1EE10C0", Offset = "0x1EE10C0", VA = "0x1EE10C0")]
	private void Awake()
	{
	}

	// Token: 0x06001688 RID: 5768 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001688")]
	[Address(RVA = "0x1EE10C4", Offset = "0x1EE10C4", VA = "0x1EE10C4")]
	private void Update()
	{
	}

	// Token: 0x06001689 RID: 5769 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001689")]
	[Address(RVA = "0x1EE1190", Offset = "0x1EE1190", VA = "0x1EE1190")]
	public WorldTroopRotation()
	{
	}

	// Token: 0x040019CE RID: 6606
	[Token(Token = "0x40019CE")]
	[FieldOffset(Offset = "0x18")]
	public GameObject[] wheels;

	// Token: 0x040019CF RID: 6607
	[Token(Token = "0x40019CF")]
	[FieldOffset(Offset = "0x20")]
	public bool isRun;

	// Token: 0x040019D0 RID: 6608
	[Token(Token = "0x40019D0")]
	[FieldOffset(Offset = "0x24")]
	public float speed;

	// Token: 0x040019D1 RID: 6609
	[Token(Token = "0x40019D1")]
	[FieldOffset(Offset = "0x28")]
	private float startRot;
}
