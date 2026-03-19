using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002B7 RID: 695
[Token(Token = "0x20002B7")]
public class LWBattleRVOManager
{
	// Token: 0x06001200 RID: 4608 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001200")]
	[Address(RVA = "0x1C57B64", Offset = "0x1C57B64", VA = "0x1C57B64")]
	public void InitLW(float timeStep, float neighborDist, int maxNeighbors, float timeHorizon, float timeHorizonObst, float radius, float maxSpeed)
	{
	}

	// Token: 0x06001201 RID: 4609 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001201")]
	[Address(RVA = "0x1C57CFC", Offset = "0x1C57CFC", VA = "0x1C57CFC")]
	public void ProcessObstacles()
	{
	}

	// Token: 0x06001202 RID: 4610 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001202")]
	[Address(RVA = "0x1C57D90", Offset = "0x1C57D90", VA = "0x1C57D90")]
	public void OnDestroy()
	{
	}

	// Token: 0x06001203 RID: 4611 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001203")]
	[Address(RVA = "0x1C57E24", Offset = "0x1C57E24", VA = "0x1C57E24")]
	public void Update(float x, float z)
	{
	}

	// Token: 0x06001204 RID: 4612 RVA: 0x00007098 File Offset: 0x00005298
	[Token(Token = "0x6001204")]
	[Address(RVA = "0x1C57F00", Offset = "0x1C57F00", VA = "0x1C57F00")]
	public int AddAgent(Vector3 position, GameObject gameObject, float speed, float radius)
	{
		return 0;
	}

	// Token: 0x06001205 RID: 4613 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001205")]
	[Address(RVA = "0x1C57698", Offset = "0x1C57698", VA = "0x1C57698")]
	public void DeleteAgent(int sid)
	{
	}

	// Token: 0x06001206 RID: 4614 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001206")]
	[Address(RVA = "0x1C5812C", Offset = "0x1C5812C", VA = "0x1C5812C")]
	public LWBattleRVOManager()
	{
	}

	// Token: 0x040014F4 RID: 5364
	[Token(Token = "0x40014F4")]
	[FieldOffset(Offset = "0x10")]
	private int _configCount;

	// Token: 0x040014F5 RID: 5365
	[Token(Token = "0x40014F5")]
	[FieldOffset(Offset = "0x14")]
	private int _finishConfigCount;
}
