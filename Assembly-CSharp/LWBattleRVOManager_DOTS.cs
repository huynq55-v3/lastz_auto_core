using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002BA RID: 698
[Token(Token = "0x20002BA")]
public class LWBattleRVOManager_DOTS
{
	// Token: 0x06001212 RID: 4626 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001212")]
	[Address(RVA = "0x1C58FA4", Offset = "0x1C58FA4", VA = "0x1C58FA4")]
	public void InitLW(float timeStep, float neighborDist, int maxNeighbors, float timeHorizon, float timeHorizonObst, float radius, float maxSpeed)
	{
	}

	// Token: 0x06001213 RID: 4627 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001213")]
	[Address(RVA = "0x1C59084", Offset = "0x1C59084", VA = "0x1C59084")]
	public void ProcessObstacles()
	{
	}

	// Token: 0x06001214 RID: 4628 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001214")]
	[Address(RVA = "0x1C590E4", Offset = "0x1C590E4", VA = "0x1C590E4")]
	public void OnDestroy()
	{
	}

	// Token: 0x06001215 RID: 4629 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001215")]
	[Address(RVA = "0x1C59144", Offset = "0x1C59144", VA = "0x1C59144")]
	public void OnApplicationQuit()
	{
	}

	// Token: 0x06001216 RID: 4630 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001216")]
	[Address(RVA = "0x1C591A4", Offset = "0x1C591A4", VA = "0x1C591A4")]
	public void Update(float x, float z)
	{
	}

	// Token: 0x06001217 RID: 4631 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001217")]
	[Address(RVA = "0x1C59220", Offset = "0x1C59220", VA = "0x1C59220")]
	public void LateUpdate()
	{
	}

	// Token: 0x06001218 RID: 4632 RVA: 0x000070F8 File Offset: 0x000052F8
	[Token(Token = "0x6001218")]
	[Address(RVA = "0x1C59224", Offset = "0x1C59224", VA = "0x1C59224")]
	public int AddAgent(Vector3 position, GameObject gameObject, float speed, float radius)
	{
		return 0;
	}

	// Token: 0x06001219 RID: 4633 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001219")]
	[Address(RVA = "0x1C58C0C", Offset = "0x1C58C0C", VA = "0x1C58C0C")]
	public void DeleteAgent(int sid)
	{
	}

	// Token: 0x0600121A RID: 4634 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600121A")]
	[Address(RVA = "0x1C5941C", Offset = "0x1C5941C", VA = "0x1C5941C")]
	public LWBattleRVOManager_DOTS()
	{
	}

	// Token: 0x040014FD RID: 5373
	[Token(Token = "0x40014FD")]
	[FieldOffset(Offset = "0x10")]
	public bool isDOTS_;
}
