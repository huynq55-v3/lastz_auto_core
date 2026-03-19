using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

// Token: 0x02000294 RID: 660
[Token(Token = "0x2000294")]
public class SurvivalLodManager
{
	// Token: 0x170001F6 RID: 502
	// (get) Token: 0x06001164 RID: 4452 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170001F6")]
	public static SurvivalLodManager Instance
	{
		[Token(Token = "0x6001164")]
		[Address(RVA = "0x1C4F650", Offset = "0x1C4F650", VA = "0x1C4F650")]
		get
		{
			return null;
		}
	}

	// Token: 0x170001F7 RID: 503
	// (get) Token: 0x06001166 RID: 4454 RVA: 0x00006F48 File Offset: 0x00005148
	// (set) Token: 0x06001165 RID: 4453 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001F7")]
	public int CurLevelId
	{
		[Token(Token = "0x6001166")]
		[Address(RVA = "0x1C505A4", Offset = "0x1C505A4", VA = "0x1C505A4")]
		[CompilerGenerated]
		get
		{
			return 0;
		}
		[Token(Token = "0x6001165")]
		[Address(RVA = "0x1C5059C", Offset = "0x1C5059C", VA = "0x1C5059C")]
		[CompilerGenerated]
		set
		{
		}
	}

	// Token: 0x06001167 RID: 4455 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001167")]
	[Address(RVA = "0x1C4F6D0", Offset = "0x1C4F6D0", VA = "0x1C4F6D0")]
	public void Register(SurvivalLod lod)
	{
	}

	// Token: 0x06001168 RID: 4456 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001168")]
	[Address(RVA = "0x1C4F788", Offset = "0x1C4F788", VA = "0x1C4F788")]
	public void Unregister(SurvivalLod lod)
	{
	}

	// Token: 0x06001169 RID: 4457 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001169")]
	[Address(RVA = "0x1C505AC", Offset = "0x1C505AC", VA = "0x1C505AC")]
	public void Init(int levelId)
	{
	}

	// Token: 0x0600116A RID: 4458 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600116A")]
	[Address(RVA = "0x1C506A8", Offset = "0x1C506A8", VA = "0x1C506A8")]
	public void UnInit()
	{
	}

	// Token: 0x0600116B RID: 4459 RVA: 0x00006F60 File Offset: 0x00005160
	[Token(Token = "0x600116B")]
	[Address(RVA = "0x1C507B4", Offset = "0x1C507B4", VA = "0x1C507B4")]
	public float GetLastCameraZoom()
	{
		return 0f;
	}

	// Token: 0x0600116C RID: 4460 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600116C")]
	[Address(RVA = "0x1C507BC", Offset = "0x1C507BC", VA = "0x1C507BC")]
	public void SetStartByMainCamera(bool driveByMainCamera)
	{
	}

	// Token: 0x0600116D RID: 4461 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600116D")]
	[Address(RVA = "0x1C507C8", Offset = "0x1C507C8", VA = "0x1C507C8")]
	public void UpdateByManual(float curZoom)
	{
	}

	// Token: 0x0600116E RID: 4462 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600116E")]
	[Address(RVA = "0x1C507D8", Offset = "0x1C507D8", VA = "0x1C507D8")]
	private void LodUpdate(float curZoom)
	{
	}

	// Token: 0x0600116F RID: 4463 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600116F")]
	[Address(RVA = "0x1C50B34", Offset = "0x1C50B34", VA = "0x1C50B34")]
	public void OnAfterCameraUpdate(float curZoom)
	{
	}

	// Token: 0x06001170 RID: 4464 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001170")]
	[Address(RVA = "0x1C50B44", Offset = "0x1C50B44", VA = "0x1C50B44")]
	public void SetZoomKey(float minZoom, float maxZoom)
	{
	}

	// Token: 0x06001171 RID: 4465 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001171")]
	[Address(RVA = "0x1C50AE4", Offset = "0x1C50AE4", VA = "0x1C50AE4")]
	public void UpdateVisible(float zoom)
	{
	}

	// Token: 0x06001172 RID: 4466 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001172")]
	[Address(RVA = "0x1C50D1C", Offset = "0x1C50D1C", VA = "0x1C50D1C")]
	public void StartCheckVisibleObj()
	{
	}

	// Token: 0x06001173 RID: 4467 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001173")]
	[Address(RVA = "0x1C50D28", Offset = "0x1C50D28", VA = "0x1C50D28")]
	public void StopCheckVisibleObj()
	{
	}

	// Token: 0x06001174 RID: 4468 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001174")]
	[Address(RVA = "0x1C50D34", Offset = "0x1C50D34", VA = "0x1C50D34")]
	public void AddIVisibleByCamZoom(IVisibleByCameraZoom obj)
	{
	}

	// Token: 0x06001175 RID: 4469 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001175")]
	[Address(RVA = "0x1C50DD0", Offset = "0x1C50DD0", VA = "0x1C50DD0")]
	public void RemoveIVisibleByCamZoom(IVisibleByCameraZoom obj)
	{
	}

	// Token: 0x06001176 RID: 4470 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001176")]
	[Address(RVA = "0x1C50B4C", Offset = "0x1C50B4C", VA = "0x1C50B4C")]
	public void SetIVisibleByCamZoomObj(bool visible)
	{
	}

	// Token: 0x06001177 RID: 4471 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001177")]
	[Address(RVA = "0x1C50478", Offset = "0x1C50478", VA = "0x1C50478")]
	public SurvivalLodManager()
	{
	}

	// Token: 0x04001430 RID: 5168
	[Token(Token = "0x4001430")]
	[FieldOffset(Offset = "0x10")]
	private bool _driveByMainCamera;

	// Token: 0x04001431 RID: 5169
	[Token(Token = "0x4001431")]
	[FieldOffset(Offset = "0x0")]
	private static SurvivalLodManager _instance;

	// Token: 0x04001432 RID: 5170
	[Token(Token = "0x4001432")]
	[FieldOffset(Offset = "0x18")]
	private readonly Dictionary<int, SurvivalLod> children;

	// Token: 0x04001433 RID: 5171
	[Token(Token = "0x4001433")]
	[FieldOffset(Offset = "0x20")]
	private readonly Dictionary<int, SurvivalLod> children_tmp;

	// Token: 0x04001434 RID: 5172
	[Token(Token = "0x4001434")]
	[FieldOffset(Offset = "0x28")]
	private float _lastZoom;

	// Token: 0x04001436 RID: 5174
	[Token(Token = "0x4001436")]
	[FieldOffset(Offset = "0x30")]
	private Dictionary<IVisibleByCameraZoom, bool> _visibleByCameraObjs;

	// Token: 0x04001437 RID: 5175
	[Token(Token = "0x4001437")]
	[FieldOffset(Offset = "0x38")]
	private bool m_startCheck;

	// Token: 0x04001438 RID: 5176
	[Token(Token = "0x4001438")]
	[FieldOffset(Offset = "0x3C")]
	private float m_minZoom;

	// Token: 0x04001439 RID: 5177
	[Token(Token = "0x4001439")]
	[FieldOffset(Offset = "0x40")]
	private float m_maxZoom;
}
