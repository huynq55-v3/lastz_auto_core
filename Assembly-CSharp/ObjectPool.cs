using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using VEngine;

// Token: 0x020001CB RID: 459
[Token(Token = "0x20001CB")]
public class ObjectPool
{
	// Token: 0x06000BE3 RID: 3043 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BE3")]
	[Address(RVA = "0x372E4B4", Offset = "0x372E4B4", VA = "0x372E4B4")]
	public void AddInstanceRecord(InstanceRequest req)
	{
	}

	// Token: 0x06000BE4 RID: 3044 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BE4")]
	[Address(RVA = "0x372E520", Offset = "0x372E520", VA = "0x372E520")]
	public void RemoveInstanceRecord(InstanceRequest req)
	{
	}

	// Token: 0x1700017A RID: 378
	// (get) Token: 0x06000BE5 RID: 3045 RVA: 0x000059A0 File Offset: 0x00003BA0
	[Token(Token = "0x1700017A")]
	public bool IsAssetLoaded
	{
		[Token(Token = "0x6000BE5")]
		[Address(RVA = "0x372E588", Offset = "0x372E588", VA = "0x372E588")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700017B RID: 379
	// (get) Token: 0x06000BE7 RID: 3047 RVA: 0x000059B8 File Offset: 0x00003BB8
	// (set) Token: 0x06000BE6 RID: 3046 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700017B")]
	public bool AlwaysHold
	{
		[Token(Token = "0x6000BE7")]
		[Address(RVA = "0x372E5AC", Offset = "0x372E5AC", VA = "0x372E5AC")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000BE6")]
		[Address(RVA = "0x372E5A0", Offset = "0x372E5A0", VA = "0x372E5A0")]
		set
		{
		}
	}

	// Token: 0x06000BE8 RID: 3048 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BE8")]
	[Address(RVA = "0x372D1AC", Offset = "0x372D1AC", VA = "0x372D1AC")]
	public ObjectPool(ObjectPoolMgr mgr, string prefabPath, ResourceManager resourceManager)
	{
	}

	// Token: 0x06000BE9 RID: 3049 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000BE9")]
	[Address(RVA = "0x372E5B4", Offset = "0x372E5B4", VA = "0x372E5B4")]
	public GameObject Spawn([Optional] Transform parent)
	{
		return null;
	}

	// Token: 0x06000BEA RID: 3050 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BEA")]
	[Address(RVA = "0x372E828", Offset = "0x372E828", VA = "0x372E828")]
	public void DeSpawn(GameObject obj, bool backToPool = true, bool moveToFar = false)
	{
	}

	// Token: 0x06000BEB RID: 3051 RVA: 0x000059D0 File Offset: 0x00003BD0
	[Token(Token = "0x6000BEB")]
	[Address(RVA = "0x372D420", Offset = "0x372D420", VA = "0x372D420")]
	public bool Clear(bool now = false)
	{
		return default(bool);
	}

	// Token: 0x06000BEC RID: 3052 RVA: 0x000059E8 File Offset: 0x00003BE8
	[Token(Token = "0x6000BEC")]
	[Address(RVA = "0x372D9F0", Offset = "0x372D9F0", VA = "0x372D9F0")]
	public bool TryClean()
	{
		return default(bool);
	}

	// Token: 0x06000BED RID: 3053 RVA: 0x00005A00 File Offset: 0x00003C00
	[Token(Token = "0x6000BED")]
	[Address(RVA = "0x372E084", Offset = "0x372E084", VA = "0x372E084")]
	public int GetPoolCount()
	{
		return 0;
	}

	// Token: 0x06000BEE RID: 3054 RVA: 0x00005A18 File Offset: 0x00003C18
	[Token(Token = "0x6000BEE")]
	[Address(RVA = "0x372E9C8", Offset = "0x372E9C8", VA = "0x372E9C8")]
	public int GetObjCount()
	{
		return 0;
	}

	// Token: 0x06000BEF RID: 3055 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BEF")]
	[Address(RVA = "0x372E9D0", Offset = "0x372E9D0", VA = "0x372E9D0")]
	public void SetPriority(int v)
	{
	}

	// Token: 0x0400101E RID: 4126
	[Token(Token = "0x400101E")]
	[FieldOffset(Offset = "0x0")]
	private static readonly Vector3 FarAwayPos;

	// Token: 0x0400101F RID: 4127
	[Token(Token = "0x400101F")]
	[FieldOffset(Offset = "0x10")]
	private ObjectPoolMgr mgr;

	// Token: 0x04001020 RID: 4128
	[Token(Token = "0x4001020")]
	[FieldOffset(Offset = "0x18")]
	private Asset request;

	// Token: 0x04001021 RID: 4129
	[Token(Token = "0x4001021")]
	[FieldOffset(Offset = "0x20")]
	private Stack<GameObject> pool;

	// Token: 0x04001022 RID: 4130
	[Token(Token = "0x4001022")]
	[FieldOffset(Offset = "0x28")]
	private int objCount;

	// Token: 0x04001023 RID: 4131
	[Token(Token = "0x4001023")]
	[FieldOffset(Offset = "0x2C")]
	private float lastDespawnTime;

	// Token: 0x04001024 RID: 4132
	[Token(Token = "0x4001024")]
	[FieldOffset(Offset = "0x30")]
	private readonly Dictionary<InstanceRequest, bool> _instanceRecord;

	// Token: 0x04001025 RID: 4133
	[Token(Token = "0x4001025")]
	[FieldOffset(Offset = "0x38")]
	private bool _alwaysHold;
}
