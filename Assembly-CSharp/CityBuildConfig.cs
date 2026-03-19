using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000006 RID: 6
[Token(Token = "0x2000006")]
[ExecuteInEditMode]
public class CityBuildConfig : MonoBehaviour
{
	// Token: 0x06000014 RID: 20 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000014")]
	[Address(RVA = "0x15DF0A8", Offset = "0x15DF0A8", VA = "0x15DF0A8")]
	public CityBuildConfig()
	{
	}

	// Token: 0x0400001A RID: 26
	[Token(Token = "0x400001A")]
	[FieldOffset(Offset = "0x18")]
	public int buildConfigId;

	// Token: 0x0400001B RID: 27
	[Token(Token = "0x400001B")]
	[FieldOffset(Offset = "0x1C")]
	public int buildId;

	// Token: 0x0400001C RID: 28
	[Token(Token = "0x400001C")]
	[FieldOffset(Offset = "0x20")]
	public float level;

	// Token: 0x0400001D RID: 29
	[Token(Token = "0x400001D")]
	[FieldOffset(Offset = "0x24")]
	public int initHp;

	// Token: 0x0400001E RID: 30
	[Token(Token = "0x400001E")]
	[FieldOffset(Offset = "0x28")]
	public int yRotation;

	// Token: 0x0400001F RID: 31
	[Token(Token = "0x400001F")]
	[FieldOffset(Offset = "0x2C")]
	public int landLock;

	// Token: 0x04000020 RID: 32
	[Token(Token = "0x4000020")]
	[FieldOffset(Offset = "0x30")]
	public int order;

	// Token: 0x04000021 RID: 33
	[Token(Token = "0x4000021")]
	[FieldOffset(Offset = "0x38")]
	public string dependencyOrder;

	// Token: 0x04000022 RID: 34
	[Token(Token = "0x4000022")]
	[FieldOffset(Offset = "0x40")]
	public int initUpState;

	// Token: 0x04000023 RID: 35
	[Token(Token = "0x4000023")]
	[FieldOffset(Offset = "0x44")]
	public int unLockLandLockId;

	// Token: 0x04000024 RID: 36
	[Token(Token = "0x4000024")]
	[FieldOffset(Offset = "0x48")]
	public int unLockAreaIdChangeToBox;

	// Token: 0x04000025 RID: 37
	[Token(Token = "0x4000025")]
	[FieldOffset(Offset = "0x50")]
	public string changeBoxByTriggers;

	// Token: 0x04000026 RID: 38
	[Token(Token = "0x4000026")]
	[FieldOffset(Offset = "0x58")]
	public int uuid;

	// Token: 0x04000027 RID: 39
	[Token(Token = "0x4000027")]
	[FieldOffset(Offset = "0x5C")]
	public int changeRuinLevel;

	// Token: 0x04000028 RID: 40
	[Token(Token = "0x4000028")]
	[FieldOffset(Offset = "0x60")]
	public int onGuideFinish;

	// Token: 0x04000029 RID: 41
	[Token(Token = "0x4000029")]
	[FieldOffset(Offset = "0x64")]
	public int lockBuildInput;

	// Token: 0x0400002A RID: 42
	[Token(Token = "0x400002A")]
	[FieldOffset(Offset = "0x68")]
	public string buildListUnlockStr;
}
