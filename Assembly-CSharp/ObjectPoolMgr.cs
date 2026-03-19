using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001CA RID: 458
[Token(Token = "0x20001CA")]
public class ObjectPoolMgr
{
	// Token: 0x17000178 RID: 376
	// (set) Token: 0x06000BD8 RID: 3032 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000178")]
	public bool IsOptMode
	{
		[Token(Token = "0x6000BD8")]
		[Address(RVA = "0x372CEF4", Offset = "0x372CEF4", VA = "0x372CEF4")]
		set
		{
		}
	}

	// Token: 0x06000BD9 RID: 3033 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BD9")]
	[Address(RVA = "0x372CF68", Offset = "0x372CF68", VA = "0x372CF68")]
	public ObjectPoolMgr()
	{
	}

	// Token: 0x06000BDA RID: 3034 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000BDA")]
	[Address(RVA = "0x372D0D0", Offset = "0x372D0D0", VA = "0x372D0D0")]
	public ObjectPool GetPool(string prefabPath, ResourceManager resourceManager)
	{
		return null;
	}

	// Token: 0x06000BDB RID: 3035 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BDB")]
	[Address(RVA = "0x372D378", Offset = "0x372D378", VA = "0x372D378")]
	public void ClearPool(string prefabPath)
	{
	}

	// Token: 0x06000BDC RID: 3036 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BDC")]
	[Address(RVA = "0x372D580", Offset = "0x372D580", VA = "0x372D580")]
	public void ClearAllPool(bool now = false)
	{
	}

	// Token: 0x06000BDD RID: 3037 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BDD")]
	[Address(RVA = "0x372D720", Offset = "0x372D720", VA = "0x372D720")]
	public void TryClearUnusedPool()
	{
	}

	// Token: 0x06000BDE RID: 3038 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BDE")]
	[Address(RVA = "0x372DA94", Offset = "0x372DA94", VA = "0x372DA94")]
	public void ClearUnusedPool(bool now = false)
	{
	}

	// Token: 0x06000BDF RID: 3039 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BDF")]
	[Address(RVA = "0x372DD68", Offset = "0x372DD68", VA = "0x372DD68")]
	public void DebugOutput()
	{
	}

	// Token: 0x06000BE0 RID: 3040 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BE0")]
	[Address(RVA = "0x372E0CC", Offset = "0x372E0CC", VA = "0x372E0CC")]
	public void TryCleanPool()
	{
	}

	// Token: 0x17000179 RID: 377
	// (get) Token: 0x06000BE1 RID: 3041 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000179")]
	public Transform Root
	{
		[Token(Token = "0x6000BE1")]
		[Address(RVA = "0x372E44C", Offset = "0x372E44C", VA = "0x372E44C")]
		get
		{
			return null;
		}
	}

	// Token: 0x0400101A RID: 4122
	[Token(Token = "0x400101A")]
	[FieldOffset(Offset = "0x0")]
	public static float CleanPoolTime;

	// Token: 0x0400101B RID: 4123
	[Token(Token = "0x400101B")]
	[FieldOffset(Offset = "0x10")]
	private GameObject root;

	// Token: 0x0400101C RID: 4124
	[Token(Token = "0x400101C")]
	[FieldOffset(Offset = "0x18")]
	private Dictionary<string, ObjectPool> poolList;

	// Token: 0x0400101D RID: 4125
	[Token(Token = "0x400101D")]
	[FieldOffset(Offset = "0x20")]
	private List<string> unusedPool;
}
