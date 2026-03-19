using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000336 RID: 822
[Token(Token = "0x2000336")]
public class SU_BuildSelect : MonoBehaviour
{
	// Token: 0x06001581 RID: 5505 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001581")]
	[Address(RVA = "0x1ED24FC", Offset = "0x1ED24FC", VA = "0x1ED24FC")]
	private void Awake()
	{
	}

	// Token: 0x06001582 RID: 5506 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001582")]
	[Address(RVA = "0x1ED28E0", Offset = "0x1ED28E0", VA = "0x1ED28E0")]
	public void Init(int tile)
	{
	}

	// Token: 0x06001583 RID: 5507 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001583")]
	[Address(RVA = "0x1ED2908", Offset = "0x1ED2908", VA = "0x1ED2908")]
	private void InitBlocks(int tile)
	{
	}

	// Token: 0x06001584 RID: 5508 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001584")]
	[Address(RVA = "0x1ED2BAC", Offset = "0x1ED2BAC", VA = "0x1ED2BAC")]
	private void InitArrows(int tile)
	{
	}

	// Token: 0x06001585 RID: 5509 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001585")]
	[Address(RVA = "0x1ED26D4", Offset = "0x1ED26D4", VA = "0x1ED26D4")]
	public void ChangeColor(List<int> occupyList)
	{
	}

	// Token: 0x06001586 RID: 5510 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001586")]
	[Address(RVA = "0x1ED2CE0", Offset = "0x1ED2CE0", VA = "0x1ED2CE0")]
	public SU_BuildSelect()
	{
	}

	// Token: 0x04001871 RID: 6257
	[Token(Token = "0x4001871")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private float blockSize;

	// Token: 0x04001872 RID: 6258
	[Token(Token = "0x4001872")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private float blockSpace;

	// Token: 0x04001873 RID: 6259
	[Token(Token = "0x4001873")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float arrowMargin;

	// Token: 0x04001874 RID: 6260
	[Token(Token = "0x4001874")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private GameObject blockTemplate;

	// Token: 0x04001875 RID: 6261
	[Token(Token = "0x4001875")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Transform blockContainer;

	// Token: 0x04001876 RID: 6262
	[Token(Token = "0x4001876")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Transform arrowContainer;

	// Token: 0x04001877 RID: 6263
	[Token(Token = "0x4001877")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private Transform arrowLeft;

	// Token: 0x04001878 RID: 6264
	[Token(Token = "0x4001878")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private Transform arrowRight;

	// Token: 0x04001879 RID: 6265
	[Token(Token = "0x4001879")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private Transform arrowTop;

	// Token: 0x0400187A RID: 6266
	[Token(Token = "0x400187A")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private Transform arrowDown;

	// Token: 0x0400187B RID: 6267
	[Token(Token = "0x400187B")]
	[FieldOffset(Offset = "0x60")]
	private MaterialPropertyBlock _arrowColorBlockGreen;

	// Token: 0x0400187C RID: 6268
	[Token(Token = "0x400187C")]
	[FieldOffset(Offset = "0x68")]
	private MaterialPropertyBlock _arrowColorBlockRed;

	// Token: 0x0400187D RID: 6269
	[Token(Token = "0x400187D")]
	[FieldOffset(Offset = "0x70")]
	private MaterialPropertyBlock _diColorBlockGreen;

	// Token: 0x0400187E RID: 6270
	[Token(Token = "0x400187E")]
	[FieldOffset(Offset = "0x78")]
	private MaterialPropertyBlock _diColorBlockRed;

	// Token: 0x0400187F RID: 6271
	[Token(Token = "0x400187F")]
	[FieldOffset(Offset = "0x0")]
	private static int _ColorSwitch;

	// Token: 0x04001880 RID: 6272
	[Token(Token = "0x4001880")]
	[FieldOffset(Offset = "0x4")]
	private static int _Color;

	// Token: 0x04001881 RID: 6273
	[Token(Token = "0x4001881")]
	[FieldOffset(Offset = "0x80")]
	private List<Transform> blockList;
}
