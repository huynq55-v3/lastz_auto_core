using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002A5 RID: 677
[Token(Token = "0x20002A5")]
[DisallowMultipleComponent]
public class NpcTouchEventTrigger : TouchObjectEventTrigger
{
	// Token: 0x060011AF RID: 4527 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60011AF")]
	[Address(RVA = "0x1C532C0", Offset = "0x1C532C0", VA = "0x1C532C0")]
	public string GetBodyRegionStr()
	{
		return null;
	}

	// Token: 0x060011B0 RID: 4528 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011B0")]
	[Address(RVA = "0x1C53338", Offset = "0x1C53338", VA = "0x1C53338")]
	public NpcTouchEventTrigger()
	{
	}

	// Token: 0x04001483 RID: 5251
	[Token(Token = "0x4001483")]
	[FieldOffset(Offset = "0x98")]
	public NpcTouchEventTrigger.BodyRegion bodyRegion;

	// Token: 0x020002A6 RID: 678
	[Token(Token = "0x20002A6")]
	public enum BodyRegion
	{
		// Token: 0x04001485 RID: 5253
		[Token(Token = "0x4001485")]
		Arm,
		// Token: 0x04001486 RID: 5254
		[Token(Token = "0x4001486")]
		Body,
		// Token: 0x04001487 RID: 5255
		[Token(Token = "0x4001487")]
		Boob,
		// Token: 0x04001488 RID: 5256
		[Token(Token = "0x4001488")]
		Leg,
		// Token: 0x04001489 RID: 5257
		[Token(Token = "0x4001489")]
		Head
	}
}
