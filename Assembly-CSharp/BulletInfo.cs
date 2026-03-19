using System;
using Il2CppDummyDll;
using Unity.Mathematics;
using UnityEngine;

// Token: 0x020002C8 RID: 712
[Token(Token = "0x20002C8")]
public class BulletInfo
{
	// Token: 0x06001273 RID: 4723 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001273")]
	[Address(RVA = "0x1C5C980", Offset = "0x1C5C980", VA = "0x1C5C980")]
	public void CreateObjectV2(string prefabName, string hitPrefabName, float3 startPos, Quaternion rotation, int tType, int tileSize, Transform trans, bool showHitEffect, float height = 0f, float percent = 0f, float speed = 0f, float flyValue = 0f, BulletFlyType flyType = BulletFlyType.Line, float hitDestroyDelay = 0.5f)
	{
	}

	// Token: 0x06001274 RID: 4724 RVA: 0x00007578 File Offset: 0x00005778
	[Token(Token = "0x6001274")]
	[Address(RVA = "0x1C5CCFC", Offset = "0x1C5CCFC", VA = "0x1C5CCFC")]
	public bool IsShowHitEffect()
	{
		return default(bool);
	}

	// Token: 0x06001275 RID: 4725 RVA: 0x00007590 File Offset: 0x00005790
	[Token(Token = "0x6001275")]
	[Address(RVA = "0x1C5CD04", Offset = "0x1C5CD04", VA = "0x1C5CD04")]
	public Quaternion GetRotation()
	{
		return default(Quaternion);
	}

	// Token: 0x06001276 RID: 4726 RVA: 0x000075A8 File Offset: 0x000057A8
	[Token(Token = "0x6001276")]
	[Address(RVA = "0x1C5CD20", Offset = "0x1C5CD20", VA = "0x1C5CD20")]
	public float3 GetPosition()
	{
		return default(float3);
	}

	// Token: 0x06001277 RID: 4727 RVA: 0x000075C0 File Offset: 0x000057C0
	[Token(Token = "0x6001277")]
	[Address(RVA = "0x1C5CD44", Offset = "0x1C5CD44", VA = "0x1C5CD44")]
	public bool IsCreateFinish()
	{
		return default(bool);
	}

	// Token: 0x06001278 RID: 4728 RVA: 0x000075D8 File Offset: 0x000057D8
	[Token(Token = "0x6001278")]
	[Address(RVA = "0x1C5CD4C", Offset = "0x1C5CD4C", VA = "0x1C5CD4C")]
	public int GetInstanceID()
	{
		return 0;
	}

	// Token: 0x06001279 RID: 4729 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001279")]
	[Address(RVA = "0x1C5CD54", Offset = "0x1C5CD54", VA = "0x1C5CD54")]
	public void Destroy()
	{
	}

	// Token: 0x0600127A RID: 4730 RVA: 0x000075F0 File Offset: 0x000057F0
	[Token(Token = "0x600127A")]
	[Address(RVA = "0x1C5CDB0", Offset = "0x1C5CDB0", VA = "0x1C5CDB0")]
	public float3 GetTargetPositionV2()
	{
		return default(float3);
	}

	// Token: 0x0600127B RID: 4731 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600127B")]
	[Address(RVA = "0x1C5CCF8", Offset = "0x1C5CCF8", VA = "0x1C5CCF8")]
	public void SetTargetPositionV2()
	{
	}

	// Token: 0x0600127C RID: 4732 RVA: 0x00007608 File Offset: 0x00005808
	[Token(Token = "0x600127C")]
	[Address(RVA = "0x1C5CDBC", Offset = "0x1C5CDBC", VA = "0x1C5CDBC")]
	public float ArriveDistance()
	{
		return 0f;
	}

	// Token: 0x0600127D RID: 4733 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600127D")]
	[Address(RVA = "0x1C5CE14", Offset = "0x1C5CE14", VA = "0x1C5CE14")]
	public string GetHitPrefabName()
	{
		return null;
	}

	// Token: 0x0600127E RID: 4734 RVA: 0x00007620 File Offset: 0x00005820
	[Token(Token = "0x600127E")]
	[Address(RVA = "0x1C5CE1C", Offset = "0x1C5CE1C", VA = "0x1C5CE1C")]
	public float GetHitDestroyDelay()
	{
		return 0f;
	}

	// Token: 0x0600127F RID: 4735 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600127F")]
	[Address(RVA = "0x1C5CE24", Offset = "0x1C5CE24", VA = "0x1C5CE24")]
	public BulletInfo()
	{
	}

	// Token: 0x04001537 RID: 5431
	[Token(Token = "0x4001537")]
	[FieldOffset(Offset = "0x10")]
	public Transform Transform;

	// Token: 0x04001538 RID: 5432
	[Token(Token = "0x4001538")]
	[FieldOffset(Offset = "0x18")]
	public float3 StartPosition;

	// Token: 0x04001539 RID: 5433
	[Token(Token = "0x4001539")]
	[FieldOffset(Offset = "0x24")]
	private float3 _targetPosition;

	// Token: 0x0400153A RID: 5434
	[Token(Token = "0x400153A")]
	[FieldOffset(Offset = "0x30")]
	public double StartTime;

	// Token: 0x0400153B RID: 5435
	[Token(Token = "0x400153B")]
	[FieldOffset(Offset = "0x38")]
	private InstanceRequest _reqInst;

	// Token: 0x0400153C RID: 5436
	[Token(Token = "0x400153C")]
	[FieldOffset(Offset = "0x40")]
	private bool _isCreateFinish;

	// Token: 0x0400153D RID: 5437
	[Token(Token = "0x400153D")]
	[FieldOffset(Offset = "0x44")]
	private int _targetId;

	// Token: 0x0400153E RID: 5438
	[Token(Token = "0x400153E")]
	[FieldOffset(Offset = "0x48")]
	private int _targetType;

	// Token: 0x0400153F RID: 5439
	[Token(Token = "0x400153F")]
	[FieldOffset(Offset = "0x4C")]
	private bool _isSetPosition;

	// Token: 0x04001540 RID: 5440
	[Token(Token = "0x4001540")]
	[FieldOffset(Offset = "0x50")]
	private string _hitEffectName;

	// Token: 0x04001541 RID: 5441
	[Token(Token = "0x4001541")]
	[FieldOffset(Offset = "0x58")]
	private Transform _targetTrans;

	// Token: 0x04001542 RID: 5442
	[Token(Token = "0x4001542")]
	[FieldOffset(Offset = "0x60")]
	private int _tileSize;

	// Token: 0x04001543 RID: 5443
	[Token(Token = "0x4001543")]
	[FieldOffset(Offset = "0x64")]
	private bool _showHitEffect;

	// Token: 0x04001544 RID: 5444
	[Token(Token = "0x4001544")]
	[FieldOffset(Offset = "0x68")]
	private float _hitDestroyDelay;

	// Token: 0x04001545 RID: 5445
	[Token(Token = "0x4001545")]
	[FieldOffset(Offset = "0x6C")]
	public float HeightValue;

	// Token: 0x04001546 RID: 5446
	[Token(Token = "0x4001546")]
	[FieldOffset(Offset = "0x70")]
	public float CenterPercent;

	// Token: 0x04001547 RID: 5447
	[Token(Token = "0x4001547")]
	[FieldOffset(Offset = "0x74")]
	public float Speed;

	// Token: 0x04001548 RID: 5448
	[Token(Token = "0x4001548")]
	[FieldOffset(Offset = "0x78")]
	public BulletFlyType FlyType;
}
