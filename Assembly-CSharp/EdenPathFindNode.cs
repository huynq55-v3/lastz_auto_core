using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002FB RID: 763
[Token(Token = "0x20002FB")]
public class EdenPathFindNode
{
	// Token: 0x060013D4 RID: 5076 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013D4")]
	[Address(RVA = "0x1A523BC", Offset = "0x1A523BC", VA = "0x1A523BC")]
	public EdenPathFindNode(EdenAreaInfo areaInfo)
	{
	}

	// Token: 0x060013D5 RID: 5077 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013D5")]
	[Address(RVA = "0x1A538EC", Offset = "0x1A538EC", VA = "0x1A538EC")]
	public EdenAreaInfo getAreaInfo()
	{
		return null;
	}

	// Token: 0x060013D6 RID: 5078 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013D6")]
	[Address(RVA = "0x1A538F4", Offset = "0x1A538F4", VA = "0x1A538F4")]
	public EdenPathFindNode getParent()
	{
		return null;
	}

	// Token: 0x060013D7 RID: 5079 RVA: 0x00007CF8 File Offset: 0x00005EF8
	[Token(Token = "0x60013D7")]
	[Address(RVA = "0x1A538FC", Offset = "0x1A538FC", VA = "0x1A538FC")]
	public float getfCost()
	{
		return 0f;
	}

	// Token: 0x060013D8 RID: 5080 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013D8")]
	[Address(RVA = "0x1A53904", Offset = "0x1A53904", VA = "0x1A53904")]
	public void setParent(EdenPathFindNode parent)
	{
	}

	// Token: 0x060013D9 RID: 5081 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013D9")]
	[Address(RVA = "0x1A5390C", Offset = "0x1A5390C", VA = "0x1A5390C")]
	public void setfCost(float fCost)
	{
	}

	// Token: 0x060013DA RID: 5082 RVA: 0x00007D10 File Offset: 0x00005F10
	[Token(Token = "0x60013DA")]
	[Address(RVA = "0x1A53914", Offset = "0x1A53914", VA = "0x1A53914")]
	public float GetgCost()
	{
		return 0f;
	}

	// Token: 0x060013DB RID: 5083 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013DB")]
	[Address(RVA = "0x1A5391C", Offset = "0x1A5391C", VA = "0x1A5391C")]
	public void SetgCost(float gCost)
	{
	}

	// Token: 0x060013DC RID: 5084 RVA: 0x00007D28 File Offset: 0x00005F28
	[Token(Token = "0x60013DC")]
	[Address(RVA = "0x1A53924", Offset = "0x1A53924", VA = "0x1A53924")]
	public Vector2Int GetLastOutPoint()
	{
		return default(Vector2Int);
	}

	// Token: 0x060013DD RID: 5085 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013DD")]
	[Address(RVA = "0x1A5392C", Offset = "0x1A5392C", VA = "0x1A5392C")]
	public void SetLastOutPoint(Vector2Int pos)
	{
	}

	// Token: 0x060013DE RID: 5086 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013DE")]
	[Address(RVA = "0x1A53934", Offset = "0x1A53934", VA = "0x1A53934")]
	public EdenAreaOuterPoint GetAreaOuterPoint()
	{
		return null;
	}

	// Token: 0x060013DF RID: 5087 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013DF")]
	[Address(RVA = "0x1A5393C", Offset = "0x1A5393C", VA = "0x1A5393C")]
	public void SetAreaOuterPoint(EdenAreaOuterPoint areaOuterPoint)
	{
	}

	// Token: 0x060013E0 RID: 5088 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013E0")]
	[Address(RVA = "0x1A52C4C", Offset = "0x1A52C4C", VA = "0x1A52C4C")]
	public Tuple<Vector2Int, Vector2Int> FindNearestInnerPointAndOutPoint(Vector2Int startPoint, EdenAreaOuterPoint pass)
	{
		return null;
	}

	// Token: 0x040016AA RID: 5802
	[Token(Token = "0x40016AA")]
	[FieldOffset(Offset = "0x10")]
	private EdenAreaInfo areaInfo;

	// Token: 0x040016AB RID: 5803
	[Token(Token = "0x40016AB")]
	[FieldOffset(Offset = "0x18")]
	private EdenPathFindNode parent;

	// Token: 0x040016AC RID: 5804
	[Token(Token = "0x40016AC")]
	[FieldOffset(Offset = "0x20")]
	private Vector2Int lastOutPoint;

	// Token: 0x040016AD RID: 5805
	[Token(Token = "0x40016AD")]
	[FieldOffset(Offset = "0x28")]
	private EdenAreaOuterPoint areaOuterPoint;

	// Token: 0x040016AE RID: 5806
	[Token(Token = "0x40016AE")]
	[FieldOffset(Offset = "0x30")]
	private float fCost;

	// Token: 0x040016AF RID: 5807
	[Token(Token = "0x40016AF")]
	[FieldOffset(Offset = "0x34")]
	private float gCost;
}
