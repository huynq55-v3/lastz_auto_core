using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002A1 RID: 673
[Token(Token = "0x20002A1")]
public class MapDecorateConfig : MonoBehaviour
{
	// Token: 0x060011AC RID: 4524 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011AC")]
	[Address(RVA = "0x1C532A4", Offset = "0x1C532A4", VA = "0x1C532A4")]
	public MapDecorateConfig()
	{
	}

	// Token: 0x0400146E RID: 5230
	[Token(Token = "0x400146E")]
	[FieldOffset(Offset = "0x18")]
	public MapDecorateConfig.DecorateType decorateType;

	// Token: 0x0400146F RID: 5231
	[Token(Token = "0x400146F")]
	[FieldOffset(Offset = "0x1C")]
	public MapDecorateConfig.DecorateSubType decorateSubType;

	// Token: 0x04001470 RID: 5232
	[Token(Token = "0x4001470")]
	[FieldOffset(Offset = "0x20")]
	public bool isStatic;

	// Token: 0x04001471 RID: 5233
	[Token(Token = "0x4001471")]
	[FieldOffset(Offset = "0x24")]
	public int genCount;

	// Token: 0x04001472 RID: 5234
	[Token(Token = "0x4001472")]
	[FieldOffset(Offset = "0x28")]
	public int space;

	// Token: 0x04001473 RID: 5235
	[Token(Token = "0x4001473")]
	[FieldOffset(Offset = "0x30")]
	public string prefabPath;

	// Token: 0x04001474 RID: 5236
	[Token(Token = "0x4001474")]
	[FieldOffset(Offset = "0x38")]
	public int priority;

	// Token: 0x04001475 RID: 5237
	[Token(Token = "0x4001475")]
	[FieldOffset(Offset = "0x3C")]
	public Bounds bounds;

	// Token: 0x04001476 RID: 5238
	[Token(Token = "0x4001476")]
	[FieldOffset(Offset = "0x54")]
	public int index;

	// Token: 0x04001477 RID: 5239
	[Token(Token = "0x4001477")]
	[FieldOffset(Offset = "0x58")]
	public int groupId;

	// Token: 0x020002A2 RID: 674
	[Token(Token = "0x20002A2")]
	public enum DecorateType
	{
		// Token: 0x04001479 RID: 5241
		[Token(Token = "0x4001479")]
		Unit,
		// Token: 0x0400147A RID: 5242
		[Token(Token = "0x400147A")]
		Decorate,
		// Token: 0x0400147B RID: 5243
		[Token(Token = "0x400147B")]
		BirthPoint
	}

	// Token: 0x020002A3 RID: 675
	[Token(Token = "0x20002A3")]
	public enum DecorateSubType
	{
		// Token: 0x0400147D RID: 5245
		[Token(Token = "0x400147D")]
		UnKnown,
		// Token: 0x0400147E RID: 5246
		[Token(Token = "0x400147E")]
		Mountain,
		// Token: 0x0400147F RID: 5247
		[Token(Token = "0x400147F")]
		Tree
	}
}
