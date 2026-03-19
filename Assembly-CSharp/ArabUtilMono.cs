using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001B6 RID: 438
[Token(Token = "0x20001B6")]
public class ArabUtilMono : MonoBehaviour
{
	// Token: 0x17000160 RID: 352
	// (get) Token: 0x06000B38 RID: 2872 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000160")]
	public static ArabUtilMono Instance
	{
		[Token(Token = "0x6000B38")]
		[Address(RVA = "0x3724988", Offset = "0x3724988", VA = "0x3724988")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000B39 RID: 2873 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B39")]
	[Address(RVA = "0x37249D0", Offset = "0x37249D0", VA = "0x37249D0")]
	private void Awake()
	{
	}

	// Token: 0x06000B3A RID: 2874 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B3A")]
	[Address(RVA = "0x3724A28", Offset = "0x3724A28", VA = "0x3724A28")]
	private void OnDestroy()
	{
	}

	// Token: 0x06000B3B RID: 2875 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B3B")]
	[Address(RVA = "0x3724A7C", Offset = "0x3724A7C", VA = "0x3724A7C")]
	public ArabUtilMono()
	{
	}

	// Token: 0x04000FB4 RID: 4020
	[Token(Token = "0x4000FB4")]
	[FieldOffset(Offset = "0x18")]
	public Material TMP_NotoSansSC_Arab;

	// Token: 0x04000FB5 RID: 4021
	[Token(Token = "0x4000FB5")]
	[FieldOffset(Offset = "0x20")]
	public Material TMP_NotoSansSC_Arab_OtherColor;

	// Token: 0x04000FB6 RID: 4022
	[Token(Token = "0x4000FB6")]
	[FieldOffset(Offset = "0x28")]
	public Material TMP_Oswald_Arab;

	// Token: 0x04000FB7 RID: 4023
	[Token(Token = "0x4000FB7")]
	[FieldOffset(Offset = "0x30")]
	public Material TMP_Oswald_Arab_OtherColor;

	// Token: 0x04000FB8 RID: 4024
	[Token(Token = "0x4000FB8")]
	[FieldOffset(Offset = "0x0")]
	private static ArabUtilMono _instance;
}
