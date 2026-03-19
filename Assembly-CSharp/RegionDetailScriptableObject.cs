using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200000C RID: 12
[Token(Token = "0x200000C")]
public class RegionDetailScriptableObject : ScriptableObject
{
	// Token: 0x06000019 RID: 25 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000019")]
	[Address(RVA = "0x15DF1E0", Offset = "0x15DF1E0", VA = "0x15DF1E0")]
	public RegionDetailScriptableObject()
	{
	}

	// Token: 0x04000053 RID: 83
	[Token(Token = "0x4000053")]
	[FieldOffset(Offset = "0x18")]
	public int regionIdx;

	// Token: 0x04000054 RID: 84
	[Token(Token = "0x4000054")]
	[FieldOffset(Offset = "0x1C")]
	public int regionRow;

	// Token: 0x04000055 RID: 85
	[Token(Token = "0x4000055")]
	[FieldOffset(Offset = "0x20")]
	public int regionCol;

	// Token: 0x04000056 RID: 86
	[Token(Token = "0x4000056")]
	[FieldOffset(Offset = "0x24")]
	public Vector3 centerPos;

	// Token: 0x04000057 RID: 87
	[Token(Token = "0x4000057")]
	[FieldOffset(Offset = "0x30")]
	public List<DecorateItemScriptableObject> renderDataList;
}
