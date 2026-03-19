using System;
using System.Text;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000004 RID: 4
[Token(Token = "0x2000004")]
public class AreaRefreshZombieConfig : MonoBehaviour
{
	// Token: 0x0600000E RID: 14 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600000E")]
	[Address(RVA = "0x15DEB90", Offset = "0x15DEB90", VA = "0x15DEB90")]
	public void ToConfigString(StringBuilder stringBuilder)
	{
	}

	// Token: 0x0600000F RID: 15 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600000F")]
	[Address(RVA = "0x15DEE98", Offset = "0x15DEE98", VA = "0x15DEE98")]
	public void PosToString(StringBuilder stringBuilder)
	{
	}

	// Token: 0x06000010 RID: 16 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000010")]
	[Address(RVA = "0x15DEF94", Offset = "0x15DEF94", VA = "0x15DEF94")]
	public void RotationToString(StringBuilder stringBuilder)
	{
	}

	// Token: 0x06000011 RID: 17 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000011")]
	[Address(RVA = "0x15DEFF0", Offset = "0x15DEFF0", VA = "0x15DEFF0")]
	public AreaRefreshZombieConfig()
	{
	}

	// Token: 0x04000006 RID: 6
	[Token(Token = "0x4000006")]
	[FieldOffset(Offset = "0x18")]
	public string zombiePath;

	// Token: 0x04000007 RID: 7
	[Token(Token = "0x4000007")]
	[FieldOffset(Offset = "0x20")]
	public int zombieRefreshState;

	// Token: 0x04000008 RID: 8
	[Token(Token = "0x4000008")]
	[FieldOffset(Offset = "0x24")]
	public int zombieCanMoveState;

	// Token: 0x04000009 RID: 9
	[Token(Token = "0x4000009")]
	[FieldOffset(Offset = "0x28")]
	public float zombieMoveMaxRange;

	// Token: 0x0400000A RID: 10
	[Token(Token = "0x400000A")]
	[FieldOffset(Offset = "0x2C")]
	public float zombieMoveMinRange;
}
