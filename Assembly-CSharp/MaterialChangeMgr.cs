using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200028C RID: 652
[Token(Token = "0x200028C")]
public class MaterialChangeMgr : MonoBehaviour
{
	// Token: 0x170001F4 RID: 500
	// (get) Token: 0x06001142 RID: 4418 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170001F4")]
	public static MaterialChangeMgr Instance
	{
		[Token(Token = "0x6001142")]
		[Address(RVA = "0x1C4E7FC", Offset = "0x1C4E7FC", VA = "0x1C4E7FC")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001143 RID: 4419 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001143")]
	[Address(RVA = "0x1C4E844", Offset = "0x1C4E844", VA = "0x1C4E844")]
	private void Awake()
	{
	}

	// Token: 0x06001144 RID: 4420 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001144")]
	[Address(RVA = "0x1C4E89C", Offset = "0x1C4E89C", VA = "0x1C4E89C")]
	public void ChangeMoonLight(Mat_Type type)
	{
	}

	// Token: 0x06001145 RID: 4421 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001145")]
	[Address(RVA = "0x1C4E9B0", Offset = "0x1C4E9B0", VA = "0x1C4E9B0")]
	public void Register(IMatChange obj)
	{
	}

	// Token: 0x06001146 RID: 4422 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001146")]
	[Address(RVA = "0x1C4EB5C", Offset = "0x1C4EB5C", VA = "0x1C4EB5C")]
	public void UnRegister(IMatChange obj)
	{
	}

	// Token: 0x06001147 RID: 4423 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001147")]
	[Address(RVA = "0x1C4EC3C", Offset = "0x1C4EC3C", VA = "0x1C4EC3C")]
	public MaterialChangeMgr()
	{
	}

	// Token: 0x04001405 RID: 5125
	[Token(Token = "0x4001405")]
	[FieldOffset(Offset = "0x0")]
	private static MaterialChangeMgr inst;

	// Token: 0x04001406 RID: 5126
	[Token(Token = "0x4001406")]
	[FieldOffset(Offset = "0x18")]
	private List<IMatChange> objList;

	// Token: 0x04001407 RID: 5127
	[Token(Token = "0x4001407")]
	[FieldOffset(Offset = "0x20")]
	private Mat_Type curType;
}
