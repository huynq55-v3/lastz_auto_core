using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000010 RID: 16
[Token(Token = "0x2000010")]
public class TotalScriptableObject : ScriptableObject
{
	// Token: 0x06000023 RID: 35 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000023")]
	[Address(RVA = "0x15DF488", Offset = "0x15DF488", VA = "0x15DF488")]
	public TotalScriptableObject()
	{
	}

	// Token: 0x0400006A RID: 106
	[Token(Token = "0x400006A")]
	[FieldOffset(Offset = "0x18")]
	public float width;

	// Token: 0x0400006B RID: 107
	[Token(Token = "0x400006B")]
	[FieldOffset(Offset = "0x1C")]
	public float height;

	// Token: 0x0400006C RID: 108
	[Token(Token = "0x400006C")]
	[FieldOffset(Offset = "0x20")]
	public int regionRowNum;

	// Token: 0x0400006D RID: 109
	[Token(Token = "0x400006D")]
	[FieldOffset(Offset = "0x24")]
	public int regionColNum;

	// Token: 0x0400006E RID: 110
	[Token(Token = "0x400006E")]
	[FieldOffset(Offset = "0x28")]
	public string layerName;

	// Token: 0x0400006F RID: 111
	[Token(Token = "0x400006F")]
	[FieldOffset(Offset = "0x30")]
	public List<ResSerializeInfo> resLookupTable;

	// Token: 0x04000070 RID: 112
	[Token(Token = "0x4000070")]
	[FieldOffset(Offset = "0x38")]
	public List<RegionDetailScriptableObject> regionList;

	// Token: 0x04000071 RID: 113
	[Token(Token = "0x4000071")]
	[FieldOffset(Offset = "0x40")]
	public List<Mesh> meshList;

	// Token: 0x04000072 RID: 114
	[Token(Token = "0x4000072")]
	[FieldOffset(Offset = "0x48")]
	public List<Material> materialList;
}
