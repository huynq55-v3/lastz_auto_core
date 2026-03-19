using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000337 RID: 823
[Token(Token = "0x2000337")]
public class SU_BuildSelectWorld : MonoBehaviour
{
	// Token: 0x06001588 RID: 5512 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001588")]
	[Address(RVA = "0x1ED2E08", Offset = "0x1ED2E08", VA = "0x1ED2E08")]
	private void Awake()
	{
	}

	// Token: 0x06001589 RID: 5513 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001589")]
	[Address(RVA = "0x1ED3090", Offset = "0x1ED3090", VA = "0x1ED3090")]
	public void Init(int tile)
	{
	}

	// Token: 0x0600158A RID: 5514 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600158A")]
	[Address(RVA = "0x1ED3094", Offset = "0x1ED3094", VA = "0x1ED3094")]
	private void InitBlocks(int tile)
	{
	}

	// Token: 0x0600158B RID: 5515 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600158B")]
	[Address(RVA = "0x1ED2F40", Offset = "0x1ED2F40", VA = "0x1ED2F40")]
	public void ChangeColor(List<int> occupyList)
	{
	}

	// Token: 0x0600158C RID: 5516 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600158C")]
	[Address(RVA = "0x1ED33C8", Offset = "0x1ED33C8", VA = "0x1ED33C8")]
	public SU_BuildSelectWorld()
	{
	}

	// Token: 0x04001882 RID: 6274
	[Token(Token = "0x4001882")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private float blockSize;

	// Token: 0x04001883 RID: 6275
	[Token(Token = "0x4001883")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private float blockSpace;

	// Token: 0x04001884 RID: 6276
	[Token(Token = "0x4001884")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject blockTemplate;

	// Token: 0x04001885 RID: 6277
	[Token(Token = "0x4001885")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Transform blockContainer;

	// Token: 0x04001886 RID: 6278
	[Token(Token = "0x4001886")]
	[FieldOffset(Offset = "0x30")]
	private MaterialPropertyBlock _diColorBlockGreen;

	// Token: 0x04001887 RID: 6279
	[Token(Token = "0x4001887")]
	[FieldOffset(Offset = "0x38")]
	private MaterialPropertyBlock _diColorBlockRed;

	// Token: 0x04001888 RID: 6280
	[Token(Token = "0x4001888")]
	[FieldOffset(Offset = "0x0")]
	private static int _ColorSwitch;

	// Token: 0x04001889 RID: 6281
	[Token(Token = "0x4001889")]
	[FieldOffset(Offset = "0x4")]
	private static int _Color;

	// Token: 0x0400188A RID: 6282
	[Token(Token = "0x400188A")]
	[FieldOffset(Offset = "0x40")]
	private List<Transform> blockList;
}
