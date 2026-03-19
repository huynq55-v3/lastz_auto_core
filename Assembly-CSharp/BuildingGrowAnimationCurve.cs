using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002C7 RID: 711
[Token(Token = "0x20002C7")]
[CreateAssetMenu(fileName = "BuildingGrowAnimationCurve", menuName = "ScriptableObjects/BuildingGrowAnimationCurve", order = 1)]
public class BuildingGrowAnimationCurve : ScriptableObject
{
	// Token: 0x06001272 RID: 4722 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001272")]
	[Address(RVA = "0x1C5C978", Offset = "0x1C5C978", VA = "0x1C5C978")]
	public BuildingGrowAnimationCurve()
	{
	}

	// Token: 0x0400152F RID: 5423
	[Token(Token = "0x400152F")]
	[FieldOffset(Offset = "0x18")]
	[Header("生长进度")]
	public AnimationCurve progressCurve;

	// Token: 0x04001530 RID: 5424
	[Token(Token = "0x4001530")]
	[FieldOffset(Offset = "0x20")]
	public AnimationCurve progressCurve1;

	// Token: 0x04001531 RID: 5425
	[Token(Token = "0x4001531")]
	[FieldOffset(Offset = "0x28")]
	[Header("扫光进度")]
	public AnimationCurve scanCurve;

	// Token: 0x04001532 RID: 5426
	[Token(Token = "0x4001532")]
	[FieldOffset(Offset = "0x30")]
	public AnimationCurve scanCurve1;

	// Token: 0x04001533 RID: 5427
	[Token(Token = "0x4001533")]
	[FieldOffset(Offset = "0x38")]
	[Header("格子进度")]
	public AnimationCurve gridCurve;

	// Token: 0x04001534 RID: 5428
	[Token(Token = "0x4001534")]
	[FieldOffset(Offset = "0x40")]
	public AnimationCurve gridCurve1;

	// Token: 0x04001535 RID: 5429
	[Token(Token = "0x4001535")]
	[FieldOffset(Offset = "0x48")]
	[Header("大玻璃罩进度")]
	public AnimationCurve glassCoverCurve;

	// Token: 0x04001536 RID: 5430
	[Token(Token = "0x4001536")]
	[FieldOffset(Offset = "0x50")]
	public AnimationCurve glassCoverCurve1;
}
