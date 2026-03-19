using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200000A RID: 10
[Token(Token = "0x200000A")]
public class MinimapWall : MonoBehaviour
{
	// Token: 0x06000018 RID: 24 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000018")]
	[Address(RVA = "0x15DF1D8", Offset = "0x15DF1D8", VA = "0x15DF1D8")]
	public MinimapWall()
	{
	}

	// Token: 0x0400004E RID: 78
	[Token(Token = "0x400004E")]
	[FieldOffset(Offset = "0x18")]
	public MinimapWall.EType type;

	// Token: 0x0200000B RID: 11
	[Token(Token = "0x200000B")]
	public enum EType
	{
		// Token: 0x04000050 RID: 80
		[Token(Token = "0x4000050")]
		Wall,
		// Token: 0x04000051 RID: 81
		[Token(Token = "0x4000051")]
		Door,
		// Token: 0x04000052 RID: 82
		[Token(Token = "0x4000052")]
		Border
	}
}
