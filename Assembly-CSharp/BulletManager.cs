using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine;

// Token: 0x020002CA RID: 714
[Token(Token = "0x20002CA")]
public class BulletManager : WorldManagerBase
{
	// Token: 0x06001282 RID: 4738 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001282")]
	[Address(RVA = "0x1C5D100", Offset = "0x1C5D100", VA = "0x1C5D100")]
	public BulletManager(WorldScene scene)
	{
	}

	// Token: 0x06001283 RID: 4739 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001283")]
	[Address(RVA = "0x1C5D244", Offset = "0x1C5D244", VA = "0x1C5D244", Slot = "5")]
	public override void UnInit()
	{
	}

	// Token: 0x06001284 RID: 4740 RVA: 0x00007638 File Offset: 0x00005838
	[Token(Token = "0x6001284")]
	[Address(RVA = "0x1C5D340", Offset = "0x1C5D340", VA = "0x1C5D340")]
	public bool AddBullet(string prefabName, string hitPrefabName, float3 startPos, Quaternion rotation, int tType, int tileSize, Transform trans, bool isSelf, bool showHitEffect = true, float height = 0f, float percent = 0f, float speed = 0f, float flyValue = 0f, BulletFlyType flyType = BulletFlyType.CStyle, float hitDestroyDelay = 0.5f)
	{
		return default(bool);
	}

	// Token: 0x06001285 RID: 4741 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001285")]
	[Address(RVA = "0x1C5CBFC", Offset = "0x1C5CBFC", VA = "0x1C5CBFC")]
	public static void ResolveBulletParams(ref float height, ref float percent, ref float speed, ref BulletFlyType flyType, ref float hitDestroyDelay)
	{
	}

	// Token: 0x06001286 RID: 4742 RVA: 0x00007650 File Offset: 0x00005850
	[Token(Token = "0x6001286")]
	[Address(RVA = "0x1C5D55C", Offset = "0x1C5D55C", VA = "0x1C5D55C")]
	public bool AddBulletV2(string prefabName, string hitPrefabName, Vector3 startPos, Quaternion rotation, int tType, int tileSize, Transform trans, bool isSelf, bool showHitEffect = true, float height = 0f, float percent = 0f, float speed = 0f, float flyValue = 0f, BulletFlyType flyType = BulletFlyType.CStyle, float hitDestroyDelay = 0.5f)
	{
		return default(bool);
	}

	// Token: 0x06001287 RID: 4743 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001287")]
	[Address(RVA = "0x1C5D648", Offset = "0x1C5D648", VA = "0x1C5D648")]
	public void UpdateBullet(double time)
	{
	}

	// Token: 0x06001288 RID: 4744 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001288")]
	[Address(RVA = "0x1C5DF78", Offset = "0x1C5DF78", VA = "0x1C5DF78")]
	private void SpawnHit(string prefabName, Quaternion rotation, float3 gunPosition, int instanceId, float hitDestroyDelay)
	{
	}

	// Token: 0x06001289 RID: 4745 RVA: 0x00007668 File Offset: 0x00005868
	[Token(Token = "0x6001289")]
	[Address(RVA = "0x1C5DEE0", Offset = "0x1C5DEE0", VA = "0x1C5DEE0")]
	private bool CheckBeHitCount(int instanceId)
	{
		return default(bool);
	}

	// Token: 0x0600128A RID: 4746 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600128A")]
	[Address(RVA = "0x1C5E194", Offset = "0x1C5E194", VA = "0x1C5E194")]
	private void AddBeHitCount(int instanceId)
	{
	}

	// Token: 0x0600128B RID: 4747 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600128B")]
	[Address(RVA = "0x1C5E274", Offset = "0x1C5E274", VA = "0x1C5E274")]
	private void RemoveBeHitCount(int instanceId)
	{
	}

	// Token: 0x0400154B RID: 5451
	[Token(Token = "0x400154B")]
	[FieldOffset(Offset = "0x18")]
	private List<BulletInfo> transList;

	// Token: 0x0400154C RID: 5452
	[Token(Token = "0x400154C")]
	[FieldOffset(Offset = "0x20")]
	private int bulletCount;

	// Token: 0x0400154D RID: 5453
	[Token(Token = "0x400154D")]
	[FieldOffset(Offset = "0x28")]
	private List<InstanceRequest> hitInstList;

	// Token: 0x0400154E RID: 5454
	[Token(Token = "0x400154E")]
	[FieldOffset(Offset = "0x30")]
	private Dictionary<int, int> beHitCountMap;

	// Token: 0x0400154F RID: 5455
	[Token(Token = "0x400154F")]
	private const int beHitMaxCount = 5;

	// Token: 0x04001550 RID: 5456
	[Token(Token = "0x4001550")]
	[FieldOffset(Offset = "0x38")]
	private JobHandle curJobHandle;
}
