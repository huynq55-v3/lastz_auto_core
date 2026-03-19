using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000252 RID: 594
[Token(Token = "0x2000252")]
[RequireComponent(typeof(ParticleSystemRenderer))]
public class EffectAutoBatch : MonoBehaviour
{
	// Token: 0x06000FE2 RID: 4066 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FE2")]
	[Address(RVA = "0x1BE8B9C", Offset = "0x1BE8B9C", VA = "0x1BE8B9C")]
	private void Awake()
	{
	}

	// Token: 0x06000FE3 RID: 4067 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FE3")]
	[Address(RVA = "0x1BE8BA0", Offset = "0x1BE8BA0", VA = "0x1BE8BA0")]
	public EffectAutoBatch()
	{
	}

	// Token: 0x04001253 RID: 4691
	[Token(Token = "0x4001253")]
	[FieldOffset(Offset = "0x18")]
	public string nameLayer;

	// Token: 0x04001254 RID: 4692
	[Token(Token = "0x4001254")]
	[FieldOffset(Offset = "0x0")]
	private static int orderInLayer;

	// Token: 0x04001255 RID: 4693
	[Token(Token = "0x4001255")]
	[FieldOffset(Offset = "0x8")]
	private static Dictionary<int, int> matDic;
}
