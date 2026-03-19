using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000008 RID: 8
[Token(Token = "0x2000008")]
public class CityEnergyConfig : MonoBehaviour
{
	// Token: 0x06000015 RID: 21 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000015")]
	[Address(RVA = "0x15DF128", Offset = "0x15DF128", VA = "0x15DF128")]
	public CityEnergyConfig()
	{
	}

	// Token: 0x04000030 RID: 48
	[Token(Token = "0x4000030")]
	[FieldOffset(Offset = "0x0")]
	private static int FOG_TILE_COUNT;

	// Token: 0x04000031 RID: 49
	[Token(Token = "0x4000031")]
	[FieldOffset(Offset = "0x4")]
	private static float FOG_TILE_SIZE;

	// Token: 0x04000032 RID: 50
	[Token(Token = "0x4000032")]
	[FieldOffset(Offset = "0x18")]
	public int objId;

	// Token: 0x04000033 RID: 51
	[Token(Token = "0x4000033")]
	[FieldOffset(Offset = "0x20")]
	public string triggerId;

	// Token: 0x04000034 RID: 52
	[Token(Token = "0x4000034")]
	[FieldOffset(Offset = "0x28")]
	public string triggerType;

	// Token: 0x04000035 RID: 53
	[Token(Token = "0x4000035")]
	[FieldOffset(Offset = "0x30")]
	public string unlockPara1;

	// Token: 0x04000036 RID: 54
	[Token(Token = "0x4000036")]
	[FieldOffset(Offset = "0x38")]
	public string unlockPara2;

	// Token: 0x04000037 RID: 55
	[Token(Token = "0x4000037")]
	[FieldOffset(Offset = "0x40")]
	public string modelName;

	// Token: 0x04000038 RID: 56
	[Token(Token = "0x4000038")]
	[FieldOffset(Offset = "0x48")]
	public int state;

	// Token: 0x04000039 RID: 57
	[Token(Token = "0x4000039")]
	[FieldOffset(Offset = "0x4C")]
	public int recoverCd;

	// Token: 0x0400003A RID: 58
	[Token(Token = "0x400003A")]
	[FieldOffset(Offset = "0x50")]
	public int linkTriggerId;

	// Token: 0x0400003B RID: 59
	[Token(Token = "0x400003B")]
	[FieldOffset(Offset = "0x54")]
	public int isGuidePt;

	// Token: 0x0400003C RID: 60
	[Token(Token = "0x400003C")]
	[FieldOffset(Offset = "0x58")]
	public int guideId;

	// Token: 0x0400003D RID: 61
	[Token(Token = "0x400003D")]
	[FieldOffset(Offset = "0x60")]
	public string trans;

	// Token: 0x0400003E RID: 62
	[Token(Token = "0x400003E")]
	[FieldOffset(Offset = "0x68")]
	public string pos;

	// Token: 0x0400003F RID: 63
	[Token(Token = "0x400003F")]
	[FieldOffset(Offset = "0x70")]
	public int savePos;

	// Token: 0x04000040 RID: 64
	[Token(Token = "0x4000040")]
	[FieldOffset(Offset = "0x78")]
	public string pre_guideId;

	// Token: 0x04000041 RID: 65
	[Token(Token = "0x4000041")]
	[FieldOffset(Offset = "0x80")]
	public bool isVirtualPt;

	// Token: 0x04000042 RID: 66
	[Token(Token = "0x4000042")]
	[FieldOffset(Offset = "0x84")]
	public E_LandLockRotate m_landLockRotate;

	// Token: 0x04000043 RID: 67
	[Token(Token = "0x4000043")]
	[FieldOffset(Offset = "0x88")]
	public string m_landLockBattleEffect;

	// Token: 0x04000044 RID: 68
	[Token(Token = "0x4000044")]
	[FieldOffset(Offset = "0x90")]
	public string m_landLockCollectEffect;

	// Token: 0x04000045 RID: 69
	[Token(Token = "0x4000045")]
	[FieldOffset(Offset = "0x98")]
	public string m_landLockUnlockEffect;

	// Token: 0x04000046 RID: 70
	[Token(Token = "0x4000046")]
	[FieldOffset(Offset = "0xA0")]
	public string m_landLockUnDoGuideEffect;
}
