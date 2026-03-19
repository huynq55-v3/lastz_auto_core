using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002DC RID: 732
[Token(Token = "0x20002DC")]
public class WorldZoneTreeNode
{
	// Token: 0x060012DF RID: 4831 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012DF")]
	[Address(RVA = "0x1A42EF8", Offset = "0x1A42EF8", VA = "0x1A42EF8")]
	public WorldZoneTreeNode(RectInt rc)
	{
	}

	// Token: 0x060012E0 RID: 4832 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012E0")]
	[Address(RVA = "0x1A42FE8", Offset = "0x1A42FE8", VA = "0x1A42FE8")]
	public void CrateSubNodes(int depth)
	{
	}

	// Token: 0x060012E1 RID: 4833 RVA: 0x00007818 File Offset: 0x00005A18
	[Token(Token = "0x60012E1")]
	[Address(RVA = "0x1A4356C", Offset = "0x1A4356C", VA = "0x1A4356C")]
	private bool IsRectIntersect(RectInt rc1, RectInt rc2)
	{
		return default(bool);
	}

	// Token: 0x060012E2 RID: 4834 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012E2")]
	[Address(RVA = "0x1A43638", Offset = "0x1A43638", VA = "0x1A43638")]
	public void AddZone(WorldZone zone)
	{
	}

	// Token: 0x060012E3 RID: 4835 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012E3")]
	[Address(RVA = "0x1A4379C", Offset = "0x1A4379C", VA = "0x1A4379C")]
	public void FindZone(RectInt rect, ref List<WorldZone> findZones, ref int count)
	{
	}

	// Token: 0x040015C2 RID: 5570
	[Token(Token = "0x40015C2")]
	[FieldOffset(Offset = "0x10")]
	public RectInt rect;

	// Token: 0x040015C3 RID: 5571
	[Token(Token = "0x40015C3")]
	[FieldOffset(Offset = "0x20")]
	public List<WorldZoneTreeNode> nodes;

	// Token: 0x040015C4 RID: 5572
	[Token(Token = "0x40015C4")]
	[FieldOffset(Offset = "0x28")]
	public List<WorldZone> zones;
}
