using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000373 RID: 883
[Token(Token = "0x2000373")]
[Serializable]
public class WorldGoTransAdjParam
{
	// Token: 0x06001686 RID: 5766 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001686")]
	[Address(RVA = "0x1EE10B8", Offset = "0x1EE10B8", VA = "0x1EE10B8")]
	public WorldGoTransAdjParam()
	{
	}

	// Token: 0x040019C4 RID: 6596
	[Token(Token = "0x40019C4")]
	[FieldOffset(Offset = "0x10")]
	public Transform TransNode;

	// Token: 0x040019C5 RID: 6597
	[Token(Token = "0x40019C5")]
	[FieldOffset(Offset = "0x18")]
	public WorldGoTransAdjParam.AdjustType AdjType;

	// Token: 0x040019C6 RID: 6598
	[Token(Token = "0x40019C6")]
	[FieldOffset(Offset = "0x20")]
	public string RefCurveName;

	// Token: 0x040019C7 RID: 6599
	[Token(Token = "0x40019C7")]
	[FieldOffset(Offset = "0x28")]
	public float ParamNumF;

	// Token: 0x040019C8 RID: 6600
	[Token(Token = "0x40019C8")]
	[FieldOffset(Offset = "0x2C")]
	public Vector3 V3Param;

	// Token: 0x02000374 RID: 884
	[Token(Token = "0x2000374")]
	public enum AdjustType
	{
		// Token: 0x040019CA RID: 6602
		[Token(Token = "0x40019CA")]
		None,
		// Token: 0x040019CB RID: 6603
		[Token(Token = "0x40019CB")]
		LocalScale,
		// Token: 0x040019CC RID: 6604
		[Token(Token = "0x40019CC")]
		LocalPos,
		// Token: 0x040019CD RID: 6605
		[Token(Token = "0x40019CD")]
		LocalPosZ
	}
}
