using System;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x02000300 RID: 768
[Token(Token = "0x2000300")]
public class WorldLodManager : WorldManagerBase
{
	// Token: 0x060013F3 RID: 5107 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013F3")]
	[Address(RVA = "0x1A53E50", Offset = "0x1A53E50", VA = "0x1A53E50")]
	public WorldLodManager(WorldScene scene)
	{
	}

	// Token: 0x060013F4 RID: 5108 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013F4")]
	[Address(RVA = "0x1A53FB4", Offset = "0x1A53FB4", VA = "0x1A53FB4", Slot = "4")]
	public override void Init()
	{
	}

	// Token: 0x060013F5 RID: 5109 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013F5")]
	[Address(RVA = "0x1A54074", Offset = "0x1A54074", VA = "0x1A54074", Slot = "5")]
	public override void UnInit()
	{
	}

	// Token: 0x060013F6 RID: 5110 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013F6")]
	[Address(RVA = "0x1A54134", Offset = "0x1A54134", VA = "0x1A54134")]
	public void AddLodAdjuster(AutoAdjustLod adjuster)
	{
	}

	// Token: 0x060013F7 RID: 5111 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013F7")]
	[Address(RVA = "0x1A541C8", Offset = "0x1A541C8", VA = "0x1A541C8")]
	public void RemoveLodAdjuster(AutoAdjustLod adjuster)
	{
	}

	// Token: 0x060013F8 RID: 5112 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013F8")]
	[Address(RVA = "0x1A54248", Offset = "0x1A54248", VA = "0x1A54248", Slot = "6")]
	public override void OnUpdate(float deltaTime)
	{
	}

	// Token: 0x060013F9 RID: 5113 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013F9")]
	[Address(RVA = "0x1A5424C", Offset = "0x1A5424C", VA = "0x1A5424C")]
	private void OnLodChanged(object userdata)
	{
	}

	// Token: 0x060013FA RID: 5114 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013FA")]
	[Address(RVA = "0x1A54524", Offset = "0x1A54524", VA = "0x1A54524")]
	private void UpdateAutoAdjustLod()
	{
	}

	// Token: 0x060013FB RID: 5115 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013FB")]
	[Address(RVA = "0x1A548A0", Offset = "0x1A548A0", VA = "0x1A548A0")]
	public Dictionary<string, LodConfig> GetLodConfigs(int lodType)
	{
		return null;
	}

	// Token: 0x040016C4 RID: 5828
	[Token(Token = "0x40016C4")]
	[FieldOffset(Offset = "0x18")]
	private HashSet<AutoAdjustLod> adjusterSet;

	// Token: 0x040016C5 RID: 5829
	[Token(Token = "0x40016C5")]
	[FieldOffset(Offset = "0x20")]
	private HashSet<AutoAdjustLod> addingAdjusterSet;

	// Token: 0x040016C6 RID: 5830
	[Token(Token = "0x40016C6")]
	[FieldOffset(Offset = "0x28")]
	private HashSet<AutoAdjustLod> removingAdjusterSet;

	// Token: 0x040016C7 RID: 5831
	[Token(Token = "0x40016C7")]
	[FieldOffset(Offset = "0x30")]
	private int curLod;

	// Token: 0x040016C8 RID: 5832
	[Token(Token = "0x40016C8")]
	[FieldOffset(Offset = "0x0")]
	private static Dictionary<int, Dictionary<string, LodConfig>> lodConfigCache;
}
