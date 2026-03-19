using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000318 RID: 792
[Token(Token = "0x2000318")]
public class WorldTroopLine : MonoBehaviour
{
	// Token: 0x060014F7 RID: 5367 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014F7")]
	[Address(RVA = "0x198D8F0", Offset = "0x198D8F0", VA = "0x198D8F0")]
	public void Clear()
	{
	}

	// Token: 0x060014F8 RID: 5368 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014F8")]
	[Address(RVA = "0x198DA1C", Offset = "0x198DA1C", VA = "0x198DA1C")]
	public void FadeIn()
	{
	}

	// Token: 0x060014F9 RID: 5369 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014F9")]
	[Address(RVA = "0x198DA20", Offset = "0x198DA20", VA = "0x198DA20")]
	public void FadeOut()
	{
	}

	// Token: 0x060014FA RID: 5370 RVA: 0x00008430 File Offset: 0x00006630
	[Token(Token = "0x60014FA")]
	[Address(RVA = "0x198DA24", Offset = "0x198DA24", VA = "0x198DA24")]
	public bool IsFadeOutFinish()
	{
		return default(bool);
	}

	// Token: 0x060014FB RID: 5371 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014FB")]
	[Address(RVA = "0x198DA2C", Offset = "0x198DA2C", VA = "0x198DA2C")]
	public void SetDragPath(Vector3 start, Vector3 end)
	{
	}

	// Token: 0x060014FC RID: 5372 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014FC")]
	[Address(RVA = "0x198DBBC", Offset = "0x198DBBC", VA = "0x198DBBC")]
	public void SetMovePath(WorldTroopPathSegment[] path, int currPath, Vector3 currPos, int realTargetPos = 0, bool needRefresh = false)
	{
	}

	// Token: 0x060014FD RID: 5373 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014FD")]
	[Address(RVA = "0x198DFFC", Offset = "0x198DFFC", VA = "0x198DFFC")]
	public void SetMoveWorldPosPath(Vector3 tarPos, Vector3[] strPath, float speed, long blackST, long blackET, long sTime, long eTime, int realTargetPos)
	{
	}

	// Token: 0x060014FE RID: 5374 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014FE")]
	[Address(RVA = "0x198E840", Offset = "0x198E840", VA = "0x198E840")]
	public void StartMove(int tarPos, string strPath, float speed, long blackST, long blackET, long sTime, long eTime, int realTargetPos)
	{
	}

	// Token: 0x060014FF RID: 5375 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014FF")]
	[Address(RVA = "0x198E74C", Offset = "0x198E74C", VA = "0x198E74C")]
	private void CalcMoveOnPath(WorldTroopPathSegment[] path, int startIndex, float startPathLen, out int pathIdx, out float pathLen, out Vector3 pos)
	{
	}

	// Token: 0x06001500 RID: 5376 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001500")]
	[Address(RVA = "0x198F188", Offset = "0x198F188", VA = "0x198F188")]
	public void SetStraightMovePath(Vector3 startPos, Vector3 endPos)
	{
	}

	// Token: 0x06001501 RID: 5377 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001501")]
	[Address(RVA = "0x198F338", Offset = "0x198F338", VA = "0x198F338")]
	public void SetColor(Color color)
	{
	}

	// Token: 0x06001502 RID: 5378 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001502")]
	[Address(RVA = "0x198E3A8", Offset = "0x198E3A8", VA = "0x198E3A8")]
	private WorldTroopPathSegment[] CreatePathSegment(Vector3[] worldPath)
	{
		return null;
	}

	// Token: 0x06001503 RID: 5379 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001503")]
	[Address(RVA = "0x198EC28", Offset = "0x198EC28", VA = "0x198EC28")]
	private WorldTroopPathSegment[] CreatePathSegment(string strPath)
	{
		return null;
	}

	// Token: 0x06001504 RID: 5380 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001504")]
	[Address(RVA = "0x198F47C", Offset = "0x198F47C", VA = "0x198F47C")]
	private void Update()
	{
	}

	// Token: 0x06001505 RID: 5381 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001505")]
	[Address(RVA = "0x198E818", Offset = "0x198E818", VA = "0x198E818")]
	private void FinishMove()
	{
	}

	// Token: 0x06001506 RID: 5382 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001506")]
	[Address(RVA = "0x198F794", Offset = "0x198F794", VA = "0x198F794")]
	public WorldTroopLine()
	{
	}

	// Token: 0x040017D3 RID: 6099
	[Token(Token = "0x40017D3")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private LineRenderer lineRenderer;

	// Token: 0x040017D4 RID: 6100
	[Token(Token = "0x40017D4")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private SpriteRenderer lineStart;

	// Token: 0x040017D5 RID: 6101
	[Token(Token = "0x40017D5")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private SpriteRenderer lineEnd;

	// Token: 0x040017D6 RID: 6102
	[Token(Token = "0x40017D6")]
	[FieldOffset(Offset = "0x30")]
	private int pathIndex;

	// Token: 0x040017D7 RID: 6103
	[Token(Token = "0x40017D7")]
	[FieldOffset(Offset = "0x38")]
	private Vector3[] dragPath;

	// Token: 0x040017D8 RID: 6104
	[Token(Token = "0x40017D8")]
	[FieldOffset(Offset = "0x40")]
	private string cachePathStr;

	// Token: 0x040017D9 RID: 6105
	[Token(Token = "0x40017D9")]
	[FieldOffset(Offset = "0x48")]
	private WorldTroopPathSegment[] curPath;

	// Token: 0x040017DA RID: 6106
	[Token(Token = "0x40017DA")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private GameObject destEffectObject;

	// Token: 0x040017DB RID: 6107
	[Token(Token = "0x40017DB")]
	[FieldOffset(Offset = "0x58")]
	private WorldTroopPathSegment[] pathList;

	// Token: 0x040017DC RID: 6108
	[Token(Token = "0x40017DC")]
	[FieldOffset(Offset = "0x60")]
	private int curPathIndex;

	// Token: 0x040017DD RID: 6109
	[Token(Token = "0x40017DD")]
	[FieldOffset(Offset = "0x64")]
	private float curPathLen;

	// Token: 0x040017DE RID: 6110
	[Token(Token = "0x40017DE")]
	[FieldOffset(Offset = "0x68")]
	private float moveSpeed;

	// Token: 0x040017DF RID: 6111
	[Token(Token = "0x40017DF")]
	[FieldOffset(Offset = "0x6C")]
	private Vector3 moveDir;

	// Token: 0x040017E0 RID: 6112
	[Token(Token = "0x40017E0")]
	[FieldOffset(Offset = "0x78")]
	private Vector3 targetPos;

	// Token: 0x040017E1 RID: 6113
	[Token(Token = "0x40017E1")]
	[FieldOffset(Offset = "0x84")]
	private Vector3 position;

	// Token: 0x040017E2 RID: 6114
	[Token(Token = "0x40017E2")]
	[FieldOffset(Offset = "0x90")]
	private int realTPos;

	// Token: 0x040017E3 RID: 6115
	[Token(Token = "0x40017E3")]
	[FieldOffset(Offset = "0x98")]
	private long endTime;

	// Token: 0x040017E4 RID: 6116
	[Token(Token = "0x40017E4")]
	[FieldOffset(Offset = "0xA0")]
	private long marchUuid;

	// Token: 0x040017E5 RID: 6117
	[Token(Token = "0x40017E5")]
	[FieldOffset(Offset = "0xA8")]
	private long blackStartTime;

	// Token: 0x040017E6 RID: 6118
	[Token(Token = "0x40017E6")]
	[FieldOffset(Offset = "0xB0")]
	private long blackEndTime;

	// Token: 0x040017E7 RID: 6119
	[Token(Token = "0x40017E7")]
	[FieldOffset(Offset = "0xB8")]
	private long startTime;

	// Token: 0x040017E8 RID: 6120
	[Token(Token = "0x40017E8")]
	[FieldOffset(Offset = "0xC0")]
	private bool useUpdate;

	// Token: 0x040017E9 RID: 6121
	[Token(Token = "0x40017E9")]
	[FieldOffset(Offset = "0xC8")]
	private long lastUpdateTime;
}
