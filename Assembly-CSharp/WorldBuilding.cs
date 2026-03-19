using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

// Token: 0x020002ED RID: 749
[Token(Token = "0x20002ED")]
public class WorldBuilding : MonoBehaviour, ITouchPickable, ITouchObjectBeginLongTabHandler, ITouchObject, ITouchObjectEndLongTabHandler
{
	// Token: 0x17000214 RID: 532
	// (get) Token: 0x0600135B RID: 4955 RVA: 0x00007AD0 File Offset: 0x00005CD0
	[Token(Token = "0x17000214")]
	public float Distance
	{
		[Token(Token = "0x600135B")]
		[Address(RVA = "0x1A4A5D4", Offset = "0x1A4A5D4", VA = "0x1A4A5D4", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return 0f;
		}
	}

	// Token: 0x17000215 RID: 533
	// (get) Token: 0x0600135C RID: 4956 RVA: 0x00007AE8 File Offset: 0x00005CE8
	// (set) Token: 0x0600135D RID: 4957 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000215")]
	public Vector2Int TilePos
	{
		[Token(Token = "0x600135C")]
		[Address(RVA = "0x1A4A5DC", Offset = "0x1A4A5DC", VA = "0x1A4A5DC")]
		get
		{
			return default(Vector2Int);
		}
		[Token(Token = "0x600135D")]
		[Address(RVA = "0x1A4A5E4", Offset = "0x1A4A5E4", VA = "0x1A4A5E4")]
		set
		{
		}
	}

	// Token: 0x17000216 RID: 534
	// (get) Token: 0x0600135E RID: 4958 RVA: 0x00007B00 File Offset: 0x00005D00
	// (set) Token: 0x0600135F RID: 4959 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000216")]
	public long Uuid
	{
		[Token(Token = "0x600135E")]
		[Address(RVA = "0x1A4A700", Offset = "0x1A4A700", VA = "0x1A4A700")]
		[CompilerGenerated]
		get
		{
			return 0L;
		}
		[Token(Token = "0x600135F")]
		[Address(RVA = "0x1A4A708", Offset = "0x1A4A708", VA = "0x1A4A708")]
		[CompilerGenerated]
		set
		{
		}
	}

	// Token: 0x06001360 RID: 4960 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001360")]
	[Address(RVA = "0x1A4A710", Offset = "0x1A4A710", VA = "0x1A4A710")]
	private void Awake()
	{
	}

	// Token: 0x06001361 RID: 4961 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001361")]
	[Address(RVA = "0x1A4A7A0", Offset = "0x1A4A7A0", VA = "0x1A4A7A0", Slot = "19")]
	protected internal virtual void CSInit(object userData)
	{
	}

	// Token: 0x06001362 RID: 4962 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001362")]
	[Address(RVA = "0x1A4BA74", Offset = "0x1A4BA74", VA = "0x1A4BA74", Slot = "20")]
	public virtual void CSUninit()
	{
	}

	// Token: 0x06001363 RID: 4963 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001363")]
	[Address(RVA = "0x1A4BCA8", Offset = "0x1A4BCA8", VA = "0x1A4BCA8", Slot = "21")]
	protected internal virtual void CSUpdate(float elapseSeconds)
	{
	}

	// Token: 0x06001364 RID: 4964 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001364")]
	[Address(RVA = "0x1A4BA70", Offset = "0x1A4BA70", VA = "0x1A4BA70")]
	public void InitLod(GameObject gameObject)
	{
	}

	// Token: 0x06001365 RID: 4965 RVA: 0x00007B18 File Offset: 0x00005D18
	[Token(Token = "0x6001365")]
	[Address(RVA = "0x1A4BD20", Offset = "0x1A4BD20", VA = "0x1A4BD20")]
	public float DoFoldUpAnim()
	{
		return 0f;
	}

	// Token: 0x06001366 RID: 4966 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001366")]
	[Address(RVA = "0x1A4BFEC", Offset = "0x1A4BFEC", VA = "0x1A4BFEC")]
	public void DoExtendDome()
	{
	}

	// Token: 0x06001367 RID: 4967 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001367")]
	[Address(RVA = "0x1A4BFF0", Offset = "0x1A4BFF0", VA = "0x1A4BFF0")]
	public void DoUpgradeDome()
	{
	}

	// Token: 0x06001368 RID: 4968 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001368")]
	[Address(RVA = "0x1A4C0A0", Offset = "0x1A4C0A0", VA = "0x1A4C0A0", Slot = "22")]
	public virtual void refeshDate()
	{
	}

	// Token: 0x06001369 RID: 4969 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001369")]
	[Address(RVA = "0x1A4A650", Offset = "0x1A4A650", VA = "0x1A4A650")]
	private void SetTilePos1(Vector2Int pos, Vector3 worldpos)
	{
	}

	// Token: 0x0600136A RID: 4970 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600136A")]
	[Address(RVA = "0x1A4CC40", Offset = "0x1A4CC40", VA = "0x1A4CC40")]
	private void SetTouchPickAblePos()
	{
	}

	// Token: 0x0600136B RID: 4971 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600136B")]
	[Address(RVA = "0x1A4AE58", Offset = "0x1A4AE58", VA = "0x1A4AE58")]
	private void FromUILoad()
	{
	}

	// Token: 0x0600136C RID: 4972 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600136C")]
	[Address(RVA = "0x1A4B538", Offset = "0x1A4B538", VA = "0x1A4B538")]
	public void EnterMoveCityState(int moveCityType)
	{
	}

	// Token: 0x0600136D RID: 4973 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600136D")]
	[Address(RVA = "0x1A4CFF4", Offset = "0x1A4CFF4", VA = "0x1A4CFF4", Slot = "5")]
	public Transform GetTransform()
	{
		return null;
	}

	// Token: 0x0600136E RID: 4974 RVA: 0x00007B30 File Offset: 0x00005D30
	[Token(Token = "0x600136E")]
	[Address(RVA = "0x1A4D084", Offset = "0x1A4D084", VA = "0x1A4D084", Slot = "7")]
	public bool PointInPick()
	{
		return default(bool);
	}

	// Token: 0x0600136F RID: 4975 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600136F")]
	[Address(RVA = "0x1A4D1C8", Offset = "0x1A4D1C8", VA = "0x1A4D1C8", Slot = "8")]
	public void Drag(Vector3 pos)
	{
	}

	// Token: 0x06001370 RID: 4976 RVA: 0x00007B48 File Offset: 0x00005D48
	[Token(Token = "0x6001370")]
	[Address(RVA = "0x1A4D508", Offset = "0x1A4D508", VA = "0x1A4D508", Slot = "23")]
	public virtual bool Select()
	{
		return default(bool);
	}

	// Token: 0x06001371 RID: 4977 RVA: 0x00007B60 File Offset: 0x00005D60
	[Token(Token = "0x6001371")]
	[Address(RVA = "0x1A4D510", Offset = "0x1A4D510", VA = "0x1A4D510", Slot = "4")]
	public bool CanLongTap()
	{
		return default(bool);
	}

	// Token: 0x06001372 RID: 4978 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001372")]
	private T ITouchPickable.GetPickComponent<T>()
	{
		return null;
	}

	// Token: 0x06001373 RID: 4979 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001373")]
	[Address(RVA = "0x1A4C374", Offset = "0x1A4C374", VA = "0x1A4C374")]
	private void InitBuildingGrow()
	{
	}

	// Token: 0x06001374 RID: 4980 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001374")]
	[Address(RVA = "0x1A4CE74", Offset = "0x1A4CE74", VA = "0x1A4CE74")]
	private void ShowShadow(bool isShow)
	{
	}

	// Token: 0x06001375 RID: 4981 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001375")]
	[Address(RVA = "0x1A4DAAC", Offset = "0x1A4DAAC", VA = "0x1A4DAAC", Slot = "10")]
	private void ITouchPickable.Click()
	{
	}

	// Token: 0x06001376 RID: 4982 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001376")]
	[Address(RVA = "0x1A4BC70", Offset = "0x1A4BC70", VA = "0x1A4BC70")]
	public void DestroyDomeInstance()
	{
	}

	// Token: 0x06001377 RID: 4983 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001377")]
	[Address(RVA = "0x1A4C09C", Offset = "0x1A4C09C", VA = "0x1A4C09C")]
	private void ShowGlass(bool upgradeDome)
	{
	}

	// Token: 0x06001378 RID: 4984 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001378")]
	[Address(RVA = "0x1A4CF5C", Offset = "0x1A4CF5C", VA = "0x1A4CF5C")]
	private void ShowEffect(bool isShow)
	{
	}

	// Token: 0x06001379 RID: 4985 RVA: 0x00007B78 File Offset: 0x00005D78
	[Token(Token = "0x6001379")]
	[Address(RVA = "0x1A4DAB0", Offset = "0x1A4DAB0", VA = "0x1A4DAB0", Slot = "11")]
	public bool IsOutRange(Vector3 pos)
	{
		return default(bool);
	}

	// Token: 0x0600137A RID: 4986 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600137A")]
	[Address(RVA = "0x1A4DB6C", Offset = "0x1A4DB6C", VA = "0x1A4DB6C", Slot = "12")]
	public void ChangeTouchPos(int index)
	{
	}

	// Token: 0x0600137B RID: 4987 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600137B")]
	[Address(RVA = "0x1A4DB70", Offset = "0x1A4DB70", VA = "0x1A4DB70")]
	public void ResetParam(int posIndex = 0)
	{
	}

	// Token: 0x0600137C RID: 4988 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600137C")]
	[Address(RVA = "0x1A4DB80", Offset = "0x1A4DB80", VA = "0x1A4DB80")]
	public void ChangeMove()
	{
	}

	// Token: 0x0600137D RID: 4989 RVA: 0x00007B90 File Offset: 0x00005D90
	[Token(Token = "0x600137D")]
	[Address(RVA = "0x1A4DBA0", Offset = "0x1A4DBA0", VA = "0x1A4DBA0", Slot = "13")]
	public Vector3 GetClosestPoint(Vector3 pos)
	{
		return default(Vector3);
	}

	// Token: 0x0600137E RID: 4990 RVA: 0x00007BA8 File Offset: 0x00005DA8
	[Token(Token = "0x600137E")]
	[Address(RVA = "0x1A4DCA8", Offset = "0x1A4DCA8", VA = "0x1A4DCA8")]
	public bool HasAnimClip(string animName)
	{
		return default(bool);
	}

	// Token: 0x0600137F RID: 4991 RVA: 0x00007BC0 File Offset: 0x00005DC0
	[Token(Token = "0x600137F")]
	[Address(RVA = "0x1A4D850", Offset = "0x1A4D850", VA = "0x1A4D850")]
	public float PlayAnim(string animName)
	{
		return 0f;
	}

	// Token: 0x06001380 RID: 4992 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001380")]
	[Address(RVA = "0x1A4DE34", Offset = "0x1A4DE34", VA = "0x1A4DE34")]
	public void DoBuildClickAnim()
	{
	}

	// Token: 0x06001381 RID: 4993 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001381")]
	[Address(RVA = "0x1A4D518", Offset = "0x1A4D518", VA = "0x1A4D518")]
	public void DoBuildPlaceAnim()
	{
	}

	// Token: 0x06001382 RID: 4994 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001382")]
	[Address(RVA = "0x1A4AE54", Offset = "0x1A4AE54", VA = "0x1A4AE54")]
	private void CheckPlaced()
	{
	}

	// Token: 0x17000217 RID: 535
	// (get) Token: 0x06001383 RID: 4995 RVA: 0x00007BD8 File Offset: 0x00005DD8
	[Token(Token = "0x17000217")]
	private float ITouchObject.Priority
	{
		[Token(Token = "0x6001383")]
		[Address(RVA = "0x1A4DFFC", Offset = "0x1A4DFFC", VA = "0x1A4DFFC", Slot = "15")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x17000218 RID: 536
	// (get) Token: 0x06001384 RID: 4996 RVA: 0x00007BF0 File Offset: 0x00005DF0
	[Token(Token = "0x17000218")]
	private Vector2Int ITouchObject.TilePos
	{
		[Token(Token = "0x6001384")]
		[Address(RVA = "0x1A4E004", Offset = "0x1A4E004", VA = "0x1A4E004", Slot = "17")]
		get
		{
			return default(Vector2Int);
		}
	}

	// Token: 0x06001385 RID: 4997 RVA: 0x00007C08 File Offset: 0x00005E08
	[Token(Token = "0x6001385")]
	[Address(RVA = "0x1A4E110", Offset = "0x1A4E110", VA = "0x1A4E110")]
	public bool OnClick()
	{
		return default(bool);
	}

	// Token: 0x06001386 RID: 4998 RVA: 0x00007C20 File Offset: 0x00005E20
	[Token(Token = "0x6001386")]
	[Address(RVA = "0x1A4E118", Offset = "0x1A4E118", VA = "0x1A4E118", Slot = "14")]
	public bool OnBeginLongTap()
	{
		return default(bool);
	}

	// Token: 0x06001387 RID: 4999 RVA: 0x00007C38 File Offset: 0x00005E38
	[Token(Token = "0x6001387")]
	[Address(RVA = "0x1A4E2DC", Offset = "0x1A4E2DC", VA = "0x1A4E2DC", Slot = "18")]
	public bool OnEndLongTap()
	{
		return default(bool);
	}

	// Token: 0x06001388 RID: 5000 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001388")]
	[Address(RVA = "0x1A4DD8C", Offset = "0x1A4DD8C", VA = "0x1A4DD8C")]
	private void ChangeAnimTimerState(WorldBuilding.AnimTimeState animTimeState)
	{
	}

	// Token: 0x06001389 RID: 5001 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001389")]
	[Address(RVA = "0x1A4BC68", Offset = "0x1A4BC68", VA = "0x1A4BC68")]
	private void CancelAnimTimer()
	{
	}

	// Token: 0x0600138A RID: 5002 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600138A")]
	[Address(RVA = "0x1A4E430", Offset = "0x1A4E430", VA = "0x1A4E430")]
	private void AddAnimTimer(float time)
	{
	}

	// Token: 0x0600138B RID: 5003 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600138B")]
	[Address(RVA = "0x1A4E43C", Offset = "0x1A4E43C", VA = "0x1A4E43C")]
	private void StopAnim()
	{
	}

	// Token: 0x0600138C RID: 5004 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600138C")]
	[Address(RVA = "0x1A4BD00", Offset = "0x1A4BD00", VA = "0x1A4BD00")]
	private void ChangeAnimTimerCallBack()
	{
	}

	// Token: 0x0600138D RID: 5005 RVA: 0x00007C50 File Offset: 0x00005E50
	[Token(Token = "0x600138D")]
	[Address(RVA = "0x1A4E508", Offset = "0x1A4E508", VA = "0x1A4E508")]
	public float GetHeight()
	{
		return 0f;
	}

	// Token: 0x0600138E RID: 5006 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600138E")]
	[Address(RVA = "0x1A4E590", Offset = "0x1A4E590", VA = "0x1A4E590")]
	public void ShowDome()
	{
	}

	// Token: 0x0600138F RID: 5007 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600138F")]
	[Address(RVA = "0x1A4E594", Offset = "0x1A4E594", VA = "0x1A4E594")]
	public void HideDome()
	{
	}

	// Token: 0x06001390 RID: 5008 RVA: 0x00007C68 File Offset: 0x00005E68
	[Token(Token = "0x6001390")]
	[Address(RVA = "0x1A4E598", Offset = "0x1A4E598", VA = "0x1A4E598")]
	public bool IsSelf()
	{
		return default(bool);
	}

	// Token: 0x06001391 RID: 5009 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001391")]
	[Address(RVA = "0x1A4E5BC", Offset = "0x1A4E5BC", VA = "0x1A4E5BC")]
	public void DoGuideStartShow(int time)
	{
	}

	// Token: 0x06001392 RID: 5010 RVA: 0x00007C80 File Offset: 0x00005E80
	[Token(Token = "0x6001392")]
	[Address(RVA = "0x1A4E808", Offset = "0x1A4E808", VA = "0x1A4E808", Slot = "24")]
	protected virtual bool IsSelfControlWorkAnim()
	{
		return default(bool);
	}

	// Token: 0x06001393 RID: 5011 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001393")]
	[Address(RVA = "0x1A4D6E0", Offset = "0x1A4D6E0", VA = "0x1A4D6E0")]
	private void SetBuildShowState(WorldBuilding.BuildShowState state)
	{
	}

	// Token: 0x06001394 RID: 5012 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001394")]
	[Address(RVA = "0x1A4E9E8", Offset = "0x1A4E9E8", VA = "0x1A4E9E8")]
	public void ChangeToBox()
	{
	}

	// Token: 0x06001395 RID: 5013 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001395")]
	[Address(RVA = "0x1A4EA90", Offset = "0x1A4EA90", VA = "0x1A4EA90", Slot = "25")]
	public virtual void OnBattleAtkUpdate(long targetUuid)
	{
	}

	// Token: 0x06001396 RID: 5014 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001396")]
	[Address(RVA = "0x1A4EA94", Offset = "0x1A4EA94", VA = "0x1A4EA94", Slot = "26")]
	public virtual void OnBattleAtkEnd()
	{
	}

	// Token: 0x06001397 RID: 5015 RVA: 0x00007C98 File Offset: 0x00005E98
	[Token(Token = "0x6001397")]
	[Address(RVA = "0x1A4EA98", Offset = "0x1A4EA98", VA = "0x1A4EA98")]
	public bool ContainsPos(Vector2Int pos)
	{
		return default(bool);
	}

	// Token: 0x06001398 RID: 5016 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001398")]
	[Address(RVA = "0x1A4EB44", Offset = "0x1A4EB44", VA = "0x1A4EB44")]
	private void UpdateBuildDataSignal(object userData)
	{
	}

	// Token: 0x06001399 RID: 5017 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001399")]
	[Address(RVA = "0x1A4EBE8", Offset = "0x1A4EBE8", VA = "0x1A4EBE8")]
	public void ProfileToggleGlass()
	{
	}

	// Token: 0x0600139A RID: 5018 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600139A")]
	[Address(RVA = "0x1A4ECB4", Offset = "0x1A4ECB4", VA = "0x1A4ECB4")]
	public void SetMoveState(bool isHide)
	{
	}

	// Token: 0x0600139B RID: 5019 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600139B")]
	[Address(RVA = "0x1A4BEB4", Offset = "0x1A4BEB4", VA = "0x1A4BEB4")]
	private void ShowFoldUpEffect()
	{
	}

	// Token: 0x0600139C RID: 5020 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600139C")]
	[Address(RVA = "0x1A4BBE0", Offset = "0x1A4BBE0", VA = "0x1A4BBE0")]
	private void DestroyFoldUpEffect()
	{
	}

	// Token: 0x0600139D RID: 5021 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600139D")]
	[Address(RVA = "0x1A4E810", Offset = "0x1A4E810", VA = "0x1A4E810")]
	private void ShowBoxEffect(bool isOpen)
	{
	}

	// Token: 0x0600139E RID: 5022 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600139E")]
	[Address(RVA = "0x1A4BC1C", Offset = "0x1A4BC1C", VA = "0x1A4BC1C")]
	private void DestroyBoxEffect()
	{
	}

	// Token: 0x0600139F RID: 5023 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600139F")]
	[Address(RVA = "0x1A4ECE8", Offset = "0x1A4ECE8", VA = "0x1A4ECE8")]
	private void PlayBoxAnim(bool isOpen)
	{
	}

	// Token: 0x060013A0 RID: 5024 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013A0")]
	[Address(RVA = "0x1A4EDDC", Offset = "0x1A4EDDC", VA = "0x1A4EDDC")]
	public WorldBuilding()
	{
	}

	// Token: 0x0400164E RID: 5710
	[Token(Token = "0x400164E")]
	[FieldOffset(Offset = "0x0")]
	private static readonly string ModelGoPathName;

	// Token: 0x0400164F RID: 5711
	[Token(Token = "0x400164F")]
	[FieldOffset(Offset = "0x8")]
	private static readonly string FoldUpEffectPath;

	// Token: 0x04001650 RID: 5712
	[Token(Token = "0x4001650")]
	[FieldOffset(Offset = "0x10")]
	private static readonly string BoxEffectPath;

	// Token: 0x04001651 RID: 5713
	[Token(Token = "0x4001651")]
	[FieldOffset(Offset = "0x18")]
	public static float ScreenRangeLeft;

	// Token: 0x04001652 RID: 5714
	[Token(Token = "0x4001652")]
	[FieldOffset(Offset = "0x1C")]
	public static float ScreenRangeRight;

	// Token: 0x04001653 RID: 5715
	[Token(Token = "0x4001653")]
	[FieldOffset(Offset = "0x20")]
	public static float ScreenRangeTop;

	// Token: 0x04001654 RID: 5716
	[Token(Token = "0x4001654")]
	[FieldOffset(Offset = "0x24")]
	public static float ScreenRangeDown;

	// Token: 0x04001655 RID: 5717
	[Token(Token = "0x4001655")]
	[FieldOffset(Offset = "0x18")]
	private WorldBuilding.AnimTimeState _curAnimState;

	// Token: 0x04001656 RID: 5718
	[Token(Token = "0x4001656")]
	[FieldOffset(Offset = "0x1C")]
	private float _curTime;

	// Token: 0x04001657 RID: 5719
	[Token(Token = "0x4001657")]
	[FieldOffset(Offset = "0x20")]
	private float _allTime;

	// Token: 0x04001658 RID: 5720
	[Token(Token = "0x4001658")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private GameObject buildIcon;

	// Token: 0x04001659 RID: 5721
	[Token(Token = "0x4001659")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	protected GameObject buildModel;

	// Token: 0x0400165A RID: 5722
	[Token(Token = "0x400165A")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private GameObject _shadow;

	// Token: 0x0400165B RID: 5723
	[Token(Token = "0x400165B")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private GameObject _baseGlass;

	// Token: 0x0400165C RID: 5724
	[Token(Token = "0x400165C")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private GameObject _effectGo;

	// Token: 0x0400165D RID: 5725
	[Token(Token = "0x400165D")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private GPUSkinningAnimator gpuAnim;

	// Token: 0x0400165E RID: 5726
	[Token(Token = "0x400165E")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private SimpleAnimation simpleAnim;

	// Token: 0x0400165F RID: 5727
	[Token(Token = "0x400165F")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private SimpleAnimation _effectAnim;

	// Token: 0x04001660 RID: 5728
	[Token(Token = "0x4001660")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private GameObject _foldUpGo;

	// Token: 0x04001661 RID: 5729
	[Token(Token = "0x4001661")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private GameObject _normalObj;

	// Token: 0x04001662 RID: 5730
	[Token(Token = "0x4001662")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private GameObject _boxObj;

	// Token: 0x04001663 RID: 5731
	[Token(Token = "0x4001663")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	private GameObject _ruinsObj;

	// Token: 0x04001664 RID: 5732
	[Token(Token = "0x4001664")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	private SimpleAnimation _boxAnim;

	// Token: 0x04001665 RID: 5733
	[Token(Token = "0x4001665")]
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	private UIEventTrigger _focusEventTrigger;

	// Token: 0x04001666 RID: 5734
	[Token(Token = "0x4001666")]
	[FieldOffset(Offset = "0x98")]
	private UIWorldLabel[] cityLabels;

	// Token: 0x04001667 RID: 5735
	[Token(Token = "0x4001667")]
	[FieldOffset(Offset = "0xA0")]
	private Vector2Int tilePos;

	// Token: 0x04001668 RID: 5736
	[Token(Token = "0x4001668")]
	[FieldOffset(Offset = "0xA8")]
	private InstanceRequest tempInstance;

	// Token: 0x04001669 RID: 5737
	[Token(Token = "0x4001669")]
	[FieldOffset(Offset = "0xB0")]
	private AutoAdjustLod adjuster;

	// Token: 0x0400166C RID: 5740
	[Token(Token = "0x400166C")]
	[FieldOffset(Offset = "0xC8")]
	public int build_Id;

	// Token: 0x0400166D RID: 5741
	[Token(Token = "0x400166D")]
	[FieldOffset(Offset = "0xCC")]
	public int tiles;

	// Token: 0x0400166E RID: 5742
	[Token(Token = "0x400166E")]
	[FieldOffset(Offset = "0xD0")]
	public int scan;

	// Token: 0x0400166F RID: 5743
	[Token(Token = "0x400166F")]
	[FieldOffset(Offset = "0xD4")]
	public int build_type;

	// Token: 0x04001670 RID: 5744
	[Token(Token = "0x4001670")]
	[FieldOffset(Offset = "0xD8")]
	private WorldBuilding.Param _param;

	// Token: 0x04001671 RID: 5745
	[Token(Token = "0x4001671")]
	[FieldOffset(Offset = "0xE0")]
	private string _animName;

	// Token: 0x04001672 RID: 5746
	[Token(Token = "0x4001672")]
	[FieldOffset(Offset = "0xE8")]
	private BuildingGrowEffect _grow;

	// Token: 0x04001673 RID: 5747
	[Token(Token = "0x4001673")]
	[FieldOffset(Offset = "0xF0")]
	private float _minX;

	// Token: 0x04001674 RID: 5748
	[Token(Token = "0x4001674")]
	[FieldOffset(Offset = "0xF4")]
	private float _maxX;

	// Token: 0x04001675 RID: 5749
	[Token(Token = "0x4001675")]
	[FieldOffset(Offset = "0xF8")]
	private float _minY;

	// Token: 0x04001676 RID: 5750
	[Token(Token = "0x4001676")]
	[FieldOffset(Offset = "0xFC")]
	private float _maxY;

	// Token: 0x04001677 RID: 5751
	[Token(Token = "0x4001677")]
	[FieldOffset(Offset = "0x100")]
	private bool _isShowRobot;

	// Token: 0x04001678 RID: 5752
	[Token(Token = "0x4001678")]
	[FieldOffset(Offset = "0x101")]
	private bool? _canShowCityLabel;

	// Token: 0x04001679 RID: 5753
	[Token(Token = "0x4001679")]
	[FieldOffset(Offset = "0x108")]
	private string _ownerUuid;

	// Token: 0x0400167A RID: 5754
	[Token(Token = "0x400167A")]
	[FieldOffset(Offset = "0x110")]
	protected int _level;

	// Token: 0x0400167B RID: 5755
	[Token(Token = "0x400167B")]
	[FieldOffset(Offset = "0x118")]
	private Dictionary<WorldBuilding.AnimTimeState, float> _buildingLevelBuildActionTime;

	// Token: 0x0400167C RID: 5756
	[Token(Token = "0x400167C")]
	[FieldOffset(Offset = "0x120")]
	private int _offset_range;

	// Token: 0x0400167D RID: 5757
	[Token(Token = "0x400167D")]
	[FieldOffset(Offset = "0x124")]
	private int _state;

	// Token: 0x0400167E RID: 5758
	[Token(Token = "0x400167E")]
	[FieldOffset(Offset = "0x128")]
	private Transform _modelGo;

	// Token: 0x0400167F RID: 5759
	[Token(Token = "0x400167F")]
	[FieldOffset(Offset = "0x130")]
	private InstanceRequest _foldUpInstanceRequest;

	// Token: 0x04001680 RID: 5760
	[Token(Token = "0x4001680")]
	[FieldOffset(Offset = "0x138")]
	private InstanceRequest _boxInstanceRequest;

	// Token: 0x04001681 RID: 5761
	[Token(Token = "0x4001681")]
	[FieldOffset(Offset = "0x140")]
	private SimpleAnimation _boxSimpleAnimation;

	// Token: 0x04001682 RID: 5762
	[Token(Token = "0x4001682")]
	[FieldOffset(Offset = "0x148")]
	private bool _glassVisible;

	// Token: 0x020002EE RID: 750
	[Token(Token = "0x20002EE")]
	public enum BuildSceneType
	{
		// Token: 0x04001684 RID: 5764
		[Token(Token = "0x4001684")]
		City = 1,
		// Token: 0x04001685 RID: 5765
		[Token(Token = "0x4001685")]
		World,
		// Token: 0x04001686 RID: 5766
		[Token(Token = "0x4001686")]
		Fake
	}

	// Token: 0x020002EF RID: 751
	[Token(Token = "0x20002EF")]
	public class Param
	{
		// Token: 0x060013AB RID: 5035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013AB")]
		[Address(RVA = "0x1A4F648", Offset = "0x1A4F648", VA = "0x1A4F648")]
		public Param()
		{
		}

		// Token: 0x04001687 RID: 5767
		[Token(Token = "0x4001687")]
		[FieldOffset(Offset = "0x10")]
		public int buildId;

		// Token: 0x04001688 RID: 5768
		[Token(Token = "0x4001688")]
		[FieldOffset(Offset = "0x18")]
		public long buildUuid;

		// Token: 0x04001689 RID: 5769
		[Token(Token = "0x4001689")]
		[FieldOffset(Offset = "0x20")]
		public int point;

		// Token: 0x0400168A RID: 5770
		[Token(Token = "0x400168A")]
		[FieldOffset(Offset = "0x24")]
		public PlaceBuildType BuildTopType;

		// Token: 0x0400168B RID: 5771
		[Token(Token = "0x400168B")]
		[FieldOffset(Offset = "0x28")]
		public LuaTable noPutPoint;

		// Token: 0x0400168C RID: 5772
		[Token(Token = "0x400168C")]
		[FieldOffset(Offset = "0x30")]
		public WorldBuilding.BuildSceneType buildSceneType;
	}

	// Token: 0x020002F0 RID: 752
	[Token(Token = "0x20002F0")]
	public class AnimName
	{
		// Token: 0x060013AC RID: 5036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013AC")]
		[Address(RVA = "0x1A4F650", Offset = "0x1A4F650", VA = "0x1A4F650")]
		public AnimName()
		{
		}

		// Token: 0x0400168D RID: 5773
		[Token(Token = "0x400168D")]
		public const string Idle = "idle";

		// Token: 0x0400168E RID: 5774
		[Token(Token = "0x400168E")]
		public const string Click = "trigger";

		// Token: 0x0400168F RID: 5775
		[Token(Token = "0x400168F")]
		public const string Place = "placed";

		// Token: 0x04001690 RID: 5776
		[Token(Token = "0x4001690")]
		public const string Work = "working";

		// Token: 0x04001691 RID: 5777
		[Token(Token = "0x4001691")]
		public const string StartWork = "start";

		// Token: 0x04001692 RID: 5778
		[Token(Token = "0x4001692")]
		public const string EndWork = "end";

		// Token: 0x04001693 RID: 5779
		[Token(Token = "0x4001693")]
		public const string WorkIdle = "work_idle";

		// Token: 0x04001694 RID: 5780
		[Token(Token = "0x4001694")]
		public const string SelfWork = "self_working";

		// Token: 0x04001695 RID: 5781
		[Token(Token = "0x4001695")]
		public const string SelfEndWork = "self_end";
	}

	// Token: 0x020002F1 RID: 753
	[Token(Token = "0x20002F1")]
	public enum AnimTimeState
	{
		// Token: 0x04001697 RID: 5783
		[Token(Token = "0x4001697")]
		Play,
		// Token: 0x04001698 RID: 5784
		[Token(Token = "0x4001698")]
		Stop
	}

	// Token: 0x020002F2 RID: 754
	[Token(Token = "0x20002F2")]
	private enum BuildShowState
	{
		// Token: 0x0400169A RID: 5786
		[Token(Token = "0x400169A")]
		Normal,
		// Token: 0x0400169B RID: 5787
		[Token(Token = "0x400169B")]
		Box
	}
}
