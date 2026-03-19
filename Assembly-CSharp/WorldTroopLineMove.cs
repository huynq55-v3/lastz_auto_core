using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200031A RID: 794
[Token(Token = "0x200031A")]
public class WorldTroopLineMove : MonoBehaviour
{
	// Token: 0x0600150A RID: 5386 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600150A")]
	[Address(RVA = "0x198F8B0", Offset = "0x198F8B0", VA = "0x198F8B0")]
	public void Init()
	{
	}

	// Token: 0x0600150B RID: 5387 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600150B")]
	[Address(RVA = "0x198FA2C", Offset = "0x198FA2C", VA = "0x198FA2C")]
	public void Clear()
	{
	}

	// Token: 0x0600150C RID: 5388 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600150C")]
	[Address(RVA = "0x198FA7C", Offset = "0x198FA7C", VA = "0x198FA7C")]
	private void HideLine()
	{
	}

	// Token: 0x0600150D RID: 5389 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600150D")]
	[Address(RVA = "0x198FAFC", Offset = "0x198FAFC", VA = "0x198FAFC")]
	private void SetPath(List<Vector3> path)
	{
	}

	// Token: 0x0600150E RID: 5390 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600150E")]
	[Address(RVA = "0x1990028", Offset = "0x1990028", VA = "0x1990028")]
	private void Awake()
	{
	}

	// Token: 0x0600150F RID: 5391 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600150F")]
	[Address(RVA = "0x198FE48", Offset = "0x198FE48", VA = "0x198FE48")]
	private void DrawLine(Transform line, Vector3 startPos, Vector3 endPos)
	{
	}

	// Token: 0x06001510 RID: 5392 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001510")]
	[Address(RVA = "0x199002C", Offset = "0x199002C", VA = "0x199002C")]
	private void SetLineColor(Transform line, Color color)
	{
	}

	// Token: 0x06001511 RID: 5393 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001511")]
	[Address(RVA = "0x19901C0", Offset = "0x19901C0", VA = "0x19901C0")]
	private void SetLineSpeed(Transform line, float mSpeed)
	{
	}

	// Token: 0x06001512 RID: 5394 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001512")]
	[Address(RVA = "0x1990364", Offset = "0x1990364", VA = "0x1990364")]
	public void SetMoveSpeed(float mSpeed)
	{
	}

	// Token: 0x06001513 RID: 5395 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001513")]
	[Address(RVA = "0x1990448", Offset = "0x1990448", VA = "0x1990448")]
	public void SetColor(Color color)
	{
	}

	// Token: 0x06001514 RID: 5396 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001514")]
	[Address(RVA = "0x19905A4", Offset = "0x19905A4", VA = "0x19905A4")]
	public void SetMovePath(WorldTroopPathSegment[] path, int currPath, Vector3 currPos, int realTargetPos = 0, bool needRefresh = false)
	{
	}

	// Token: 0x06001515 RID: 5397 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001515")]
	[Address(RVA = "0x19907E4", Offset = "0x19907E4", VA = "0x19907E4")]
	public void SetMoveWorldPosPath(Vector3 tarPos, Vector3[] strPath, float speed, long blackST, long blackET, long sTime, long eTime, int realTargetPos)
	{
	}

	// Token: 0x06001516 RID: 5398 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001516")]
	[Address(RVA = "0x1990FFC", Offset = "0x1990FFC", VA = "0x1990FFC")]
	public void StartMove(int tarPos, string strPath, float speed, long blackST, long blackET, long sTime, long eTime, int realTargetPos)
	{
	}

	// Token: 0x06001517 RID: 5399 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001517")]
	[Address(RVA = "0x1990F30", Offset = "0x1990F30", VA = "0x1990F30")]
	private void CalcMoveOnPath(WorldTroopPathSegment[] path, int startIndex, float startPathLen, out int pathIdx, out float pathLen, out Vector3 pos)
	{
	}

	// Token: 0x06001518 RID: 5400 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001518")]
	[Address(RVA = "0x1990B8C", Offset = "0x1990B8C", VA = "0x1990B8C")]
	private WorldTroopPathSegment[] CreatePathSegment(Vector3[] worldPath)
	{
		return null;
	}

	// Token: 0x06001519 RID: 5401 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001519")]
	[Address(RVA = "0x1991390", Offset = "0x1991390", VA = "0x1991390")]
	private WorldTroopPathSegment[] CreatePathSegment(string strPath)
	{
		return null;
	}

	// Token: 0x0600151A RID: 5402 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600151A")]
	[Address(RVA = "0x199181C", Offset = "0x199181C", VA = "0x199181C")]
	private void Update()
	{
	}

	// Token: 0x0600151B RID: 5403 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600151B")]
	[Address(RVA = "0x198FA54", Offset = "0x198FA54", VA = "0x198FA54")]
	private void FinishMove()
	{
	}

	// Token: 0x0600151C RID: 5404 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600151C")]
	[Address(RVA = "0x1991B38", Offset = "0x1991B38", VA = "0x1991B38")]
	public WorldTroopLineMove()
	{
	}

	// Token: 0x040017EC RID: 6124
	[Token(Token = "0x40017EC")]
	[FieldOffset(Offset = "0x18")]
	private SpriteRenderer startSprite;

	// Token: 0x040017ED RID: 6125
	[Token(Token = "0x40017ED")]
	[FieldOffset(Offset = "0x20")]
	private SpriteRenderer endSprite;

	// Token: 0x040017EE RID: 6126
	[Token(Token = "0x40017EE")]
	[FieldOffset(Offset = "0x28")]
	private GameObject line1;

	// Token: 0x040017EF RID: 6127
	[Token(Token = "0x40017EF")]
	[FieldOffset(Offset = "0x30")]
	private GameObject line2;

	// Token: 0x040017F0 RID: 6128
	[Token(Token = "0x40017F0")]
	[FieldOffset(Offset = "0x38")]
	private bool isInit;

	// Token: 0x040017F1 RID: 6129
	[Token(Token = "0x40017F1")]
	[FieldOffset(Offset = "0x40")]
	private List<Vector3> movePath;

	// Token: 0x040017F2 RID: 6130
	[Token(Token = "0x40017F2")]
	[FieldOffset(Offset = "0x48")]
	private Vector3 targetPos;

	// Token: 0x040017F3 RID: 6131
	[Token(Token = "0x40017F3")]
	[FieldOffset(Offset = "0x58")]
	private WorldTroopPathSegment[] pathList;

	// Token: 0x040017F4 RID: 6132
	[Token(Token = "0x40017F4")]
	[FieldOffset(Offset = "0x60")]
	private int curPathIndex;

	// Token: 0x040017F5 RID: 6133
	[Token(Token = "0x40017F5")]
	[FieldOffset(Offset = "0x64")]
	private float curPathLen;

	// Token: 0x040017F6 RID: 6134
	[Token(Token = "0x40017F6")]
	[FieldOffset(Offset = "0x68")]
	private float moveSpeed;

	// Token: 0x040017F7 RID: 6135
	[Token(Token = "0x40017F7")]
	[FieldOffset(Offset = "0x6C")]
	private Vector3 moveDir;

	// Token: 0x040017F8 RID: 6136
	[Token(Token = "0x40017F8")]
	[FieldOffset(Offset = "0x78")]
	private Vector3 position;

	// Token: 0x040017F9 RID: 6137
	[Token(Token = "0x40017F9")]
	[FieldOffset(Offset = "0x84")]
	private int realTPos;

	// Token: 0x040017FA RID: 6138
	[Token(Token = "0x40017FA")]
	[FieldOffset(Offset = "0x88")]
	private long endTime;

	// Token: 0x040017FB RID: 6139
	[Token(Token = "0x40017FB")]
	[FieldOffset(Offset = "0x90")]
	private long marchUuid;

	// Token: 0x040017FC RID: 6140
	[Token(Token = "0x40017FC")]
	[FieldOffset(Offset = "0x98")]
	private long blackStartTime;

	// Token: 0x040017FD RID: 6141
	[Token(Token = "0x40017FD")]
	[FieldOffset(Offset = "0xA0")]
	private long blackEndTime;

	// Token: 0x040017FE RID: 6142
	[Token(Token = "0x40017FE")]
	[FieldOffset(Offset = "0xA8")]
	private long startTime;

	// Token: 0x040017FF RID: 6143
	[Token(Token = "0x40017FF")]
	[FieldOffset(Offset = "0xB0")]
	private bool useUpdate;

	// Token: 0x04001800 RID: 6144
	[Token(Token = "0x4001800")]
	[FieldOffset(Offset = "0xB8")]
	private long lastUpdateTime;

	// Token: 0x04001801 RID: 6145
	[Token(Token = "0x4001801")]
	[FieldOffset(Offset = "0xC0")]
	private int pathIndex;

	// Token: 0x04001802 RID: 6146
	[Token(Token = "0x4001802")]
	[FieldOffset(Offset = "0xC8")]
	private string cachePathStr;

	// Token: 0x04001803 RID: 6147
	[Token(Token = "0x4001803")]
	[FieldOffset(Offset = "0xD0")]
	private float firstScale;
}
