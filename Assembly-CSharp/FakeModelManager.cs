using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

// Token: 0x020002CF RID: 719
[Token(Token = "0x20002CF")]
public class FakeModelManager : WorldManagerBase
{
	// Token: 0x06001295 RID: 4757 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001295")]
	[Address(RVA = "0x1C5E664", Offset = "0x1C5E664", VA = "0x1C5E664")]
	public FakeModelManager(WorldScene scene)
	{
	}

	// Token: 0x06001296 RID: 4758 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001296")]
	[Address(RVA = "0x1C5E66C", Offset = "0x1C5E66C", VA = "0x1C5E66C", Slot = "6")]
	public override void OnUpdate(float deltaTime)
	{
	}

	// Token: 0x06001297 RID: 4759 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001297")]
	[Address(RVA = "0x1C5E670", Offset = "0x1C5E670", VA = "0x1C5E670")]
	public void UICreateBuilding(int buildId, long buildUuid, int point, int buildTopType, [Optional] LuaTable noBuildList)
	{
	}

	// Token: 0x06001298 RID: 4760 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001298")]
	[Address(RVA = "0x1C5E8F4", Offset = "0x1C5E8F4", VA = "0x1C5E8F4")]
	public void UIChangeBuilding(int index)
	{
	}

	// Token: 0x06001299 RID: 4761 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001299")]
	[Address(RVA = "0x1C5EA68", Offset = "0x1C5EA68", VA = "0x1C5EA68")]
	public void UIDestroyRreCreateBuild()
	{
	}

	// Token: 0x0600129A RID: 4762 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600129A")]
	[Address(RVA = "0x1C5EB70", Offset = "0x1C5EB70", VA = "0x1C5EB70")]
	public void UIDestroyBuilding()
	{
	}

	// Token: 0x0600129B RID: 4763 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600129B")]
	[Address(RVA = "0x1C5EC18", Offset = "0x1C5EC18", VA = "0x1C5EC18")]
	public void UICreateAllianceBuilding(int buildId, long buildUuid, int point, int buildTopType, [Optional] LuaTable noBuildList)
	{
	}

	// Token: 0x0600129C RID: 4764 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600129C")]
	[Address(RVA = "0x1C5EEA0", Offset = "0x1C5EEA0", VA = "0x1C5EEA0")]
	public void UIChangeAllianceBuilding(int index)
	{
	}

	// Token: 0x0600129D RID: 4765 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600129D")]
	[Address(RVA = "0x1C5EFDC", Offset = "0x1C5EFDC", VA = "0x1C5EFDC")]
	public void UIDestroyRreCreateAllianceBuild()
	{
	}

	// Token: 0x0600129E RID: 4766 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600129E")]
	[Address(RVA = "0x1C5F0AC", Offset = "0x1C5F0AC", VA = "0x1C5F0AC")]
	public void UIDestroyAllianceBuilding()
	{
	}

	// Token: 0x0400155F RID: 5471
	[Token(Token = "0x400155F")]
	[FieldOffset(Offset = "0x18")]
	public FakeWorldBuilding preCreateBuild;

	// Token: 0x04001560 RID: 5472
	[Token(Token = "0x4001560")]
	[FieldOffset(Offset = "0x20")]
	public Queue<FakeWorldBuilding> placeFalseBuild;

	// Token: 0x04001561 RID: 5473
	[Token(Token = "0x4001561")]
	[FieldOffset(Offset = "0x28")]
	public GameObject attackRange;

	// Token: 0x04001562 RID: 5474
	[Token(Token = "0x4001562")]
	[FieldOffset(Offset = "0x30")]
	public bool isPaitai;

	// Token: 0x04001563 RID: 5475
	[Token(Token = "0x4001563")]
	[FieldOffset(Offset = "0x38")]
	public FakeAllianceBuilding preCreateAllianceBuild;

	// Token: 0x04001564 RID: 5476
	[Token(Token = "0x4001564")]
	[FieldOffset(Offset = "0x40")]
	public Queue<FakeAllianceBuilding> placeFalseAllianceBuild;
}
