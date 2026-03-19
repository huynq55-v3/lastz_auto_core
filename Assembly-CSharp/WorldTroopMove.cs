using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002E0 RID: 736
[Token(Token = "0x20002E0")]
public class WorldTroopMove : MonoBehaviour
{
	// Token: 0x06001307 RID: 4871 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001307")]
	[Address(RVA = "0x1A44524", Offset = "0x1A44524", VA = "0x1A44524")]
	public void StartMove(Transform trans, int tarPos, string strPath, float speed, long blackST, long blackET, long sTime, long eTime)
	{
	}

	// Token: 0x06001308 RID: 4872 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001308")]
	[Address(RVA = "0x1A45094", Offset = "0x1A45094", VA = "0x1A45094")]
	public void StartMoveWorldPosPath(Transform trans, Vector3 tarPos, Vector3[] path, float speed, long blackST, long blackET, long sTime, long eTime)
	{
	}

	// Token: 0x06001309 RID: 4873 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001309")]
	[Address(RVA = "0x1A45714", Offset = "0x1A45714", VA = "0x1A45714")]
	public void StartMoveInHome(Transform trans, Vector3 startPos, Vector3 endPos, float speed, long blackST, long blackET, long sTime, long eTime)
	{
	}

	// Token: 0x0600130A RID: 4874 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600130A")]
	[Address(RVA = "0x1A45BD0", Offset = "0x1A45BD0", VA = "0x1A45BD0")]
	public void StopMove()
	{
	}

	// Token: 0x0600130B RID: 4875 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600130B")]
	[Address(RVA = "0x1A44E64", Offset = "0x1A44E64", VA = "0x1A44E64")]
	private void FinishMove()
	{
	}

	// Token: 0x0600130C RID: 4876 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600130C")]
	[Address(RVA = "0x1A44918", Offset = "0x1A44918", VA = "0x1A44918")]
	private WorldTroopPathSegment[] CreatePathSegment(string strPath)
	{
		return null;
	}

	// Token: 0x0600130D RID: 4877 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600130D")]
	[Address(RVA = "0x1A459F4", Offset = "0x1A459F4", VA = "0x1A459F4")]
	private WorldTroopPathSegment[] CreatePathSegment_InHome(Vector3 startPos, Vector3 endPos)
	{
		return null;
	}

	// Token: 0x0600130E RID: 4878 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600130E")]
	[Address(RVA = "0x1A45448", Offset = "0x1A45448", VA = "0x1A45448")]
	private WorldTroopPathSegment[] CreatePathSegment(Vector3[] posPath)
	{
		return null;
	}

	// Token: 0x0600130F RID: 4879 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600130F")]
	[Address(RVA = "0x1A44F30", Offset = "0x1A44F30", VA = "0x1A44F30")]
	private void SetRotation(Quaternion rotation)
	{
	}

	// Token: 0x06001310 RID: 4880 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001310")]
	[Address(RVA = "0x1A45BDC", Offset = "0x1A45BDC", VA = "0x1A45BDC")]
	private void Update()
	{
	}

	// Token: 0x06001311 RID: 4881 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001311")]
	[Address(RVA = "0x1A44D98", Offset = "0x1A44D98", VA = "0x1A44D98")]
	private void CalcMoveOnPath(WorldTroopPathSegment[] path, int startIndex, float startPathLen, out int pathIdx, out float pathLen, out Vector3 pos)
	{
	}

	// Token: 0x06001312 RID: 4882 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001312")]
	[Address(RVA = "0x1A45EE4", Offset = "0x1A45EE4", VA = "0x1A45EE4")]
	public void SetFinishCallback(Action callback)
	{
	}

	// Token: 0x06001313 RID: 4883 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001313")]
	[Address(RVA = "0x1A45EEC", Offset = "0x1A45EEC", VA = "0x1A45EEC")]
	public void SetIsIgnoreRot(bool flag)
	{
	}

	// Token: 0x06001314 RID: 4884 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001314")]
	[Address(RVA = "0x1A45EF8", Offset = "0x1A45EF8", VA = "0x1A45EF8")]
	public WorldTroopMove()
	{
	}

	// Token: 0x040015DC RID: 5596
	[Token(Token = "0x40015DC")]
	[FieldOffset(Offset = "0x18")]
	private WorldTroopPathSegment[] pathList;

	// Token: 0x040015DD RID: 5597
	[Token(Token = "0x40015DD")]
	[FieldOffset(Offset = "0x20")]
	private int curPathIndex;

	// Token: 0x040015DE RID: 5598
	[Token(Token = "0x40015DE")]
	[FieldOffset(Offset = "0x24")]
	private float curPathLen;

	// Token: 0x040015DF RID: 5599
	[Token(Token = "0x40015DF")]
	[FieldOffset(Offset = "0x28")]
	private float moveSpeed;

	// Token: 0x040015E0 RID: 5600
	[Token(Token = "0x40015E0")]
	[FieldOffset(Offset = "0x2C")]
	private Vector3 moveDir;

	// Token: 0x040015E1 RID: 5601
	[Token(Token = "0x40015E1")]
	[FieldOffset(Offset = "0x38")]
	private Vector3 position;

	// Token: 0x040015E2 RID: 5602
	[Token(Token = "0x40015E2")]
	[FieldOffset(Offset = "0x44")]
	private Vector3 targetPos;

	// Token: 0x040015E3 RID: 5603
	[Token(Token = "0x40015E3")]
	[FieldOffset(Offset = "0x50")]
	private int realTargetPos;

	// Token: 0x040015E4 RID: 5604
	[Token(Token = "0x40015E4")]
	[FieldOffset(Offset = "0x54")]
	private Vector3 realTargetPos_v;

	// Token: 0x040015E5 RID: 5605
	[Token(Token = "0x40015E5")]
	[FieldOffset(Offset = "0x60")]
	private long endTime;

	// Token: 0x040015E6 RID: 5606
	[Token(Token = "0x40015E6")]
	[FieldOffset(Offset = "0x68")]
	private long marchUuid;

	// Token: 0x040015E7 RID: 5607
	[Token(Token = "0x40015E7")]
	[FieldOffset(Offset = "0x70")]
	private long blackStartTime;

	// Token: 0x040015E8 RID: 5608
	[Token(Token = "0x40015E8")]
	[FieldOffset(Offset = "0x78")]
	private long blackEndTime;

	// Token: 0x040015E9 RID: 5609
	[Token(Token = "0x40015E9")]
	[FieldOffset(Offset = "0x80")]
	private long startTime;

	// Token: 0x040015EA RID: 5610
	[Token(Token = "0x40015EA")]
	[FieldOffset(Offset = "0x88")]
	private Transform rotationTrans;

	// Token: 0x040015EB RID: 5611
	[Token(Token = "0x40015EB")]
	[FieldOffset(Offset = "0x90")]
	private long lastUpdateTime;

	// Token: 0x040015EC RID: 5612
	[Token(Token = "0x40015EC")]
	[FieldOffset(Offset = "0x98")]
	private Action finishCallback;

	// Token: 0x040015ED RID: 5613
	[Token(Token = "0x40015ED")]
	[FieldOffset(Offset = "0xA0")]
	private bool isIgnoreRot;
}
