using System;
using System.Collections.Generic;
using BitBenderGames;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

// Token: 0x02000360 RID: 864
[Token(Token = "0x2000360")]
public class AutoAdjustLod : MonoBehaviourWrapped
{
	// Token: 0x0600162C RID: 5676 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600162C")]
	[Address(RVA = "0x1EDC410", Offset = "0x1EDC410", VA = "0x1EDC410")]
	public void SetLodCallback(AutoAdjustLod.LuaLoadFadeInOrOutCallback cb)
	{
	}

	// Token: 0x0600162D RID: 5677 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600162D")]
	[Address(RVA = "0x1EDC418", Offset = "0x1EDC418", VA = "0x1EDC418")]
	public void SetLodType(int t)
	{
	}

	// Token: 0x0600162E RID: 5678 RVA: 0x000087D8 File Offset: 0x000069D8
	[Token(Token = "0x600162E")]
	[Address(RVA = "0x1EDC4F4", Offset = "0x1EDC4F4", VA = "0x1EDC4F4")]
	public int GetLodType()
	{
		return 0;
	}

	// Token: 0x0600162F RID: 5679 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600162F")]
	[Address(RVA = "0x1EDC4FC", Offset = "0x1EDC4FC", VA = "0x1EDC4FC")]
	public void UpdateLod(int lod)
	{
	}

	// Token: 0x06001630 RID: 5680 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001630")]
	[Address(RVA = "0x1EDC6BC", Offset = "0x1EDC6BC", VA = "0x1EDC6BC")]
	private void Awake()
	{
	}

	// Token: 0x06001631 RID: 5681 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001631")]
	[Address(RVA = "0x1EDC434", Offset = "0x1EDC434", VA = "0x1EDC434")]
	private void InitConfig()
	{
	}

	// Token: 0x06001632 RID: 5682 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001632")]
	[Address(RVA = "0x1EDC470", Offset = "0x1EDC470", VA = "0x1EDC470")]
	private void OnEnable()
	{
	}

	// Token: 0x06001633 RID: 5683 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001633")]
	[Address(RVA = "0x1EDCC40", Offset = "0x1EDCC40", VA = "0x1EDCC40")]
	private void OnDisable()
	{
	}

	// Token: 0x06001634 RID: 5684 RVA: 0x000087F0 File Offset: 0x000069F0
	[Token(Token = "0x6001634")]
	[Address(RVA = "0x1EDCD04", Offset = "0x1EDCD04", VA = "0x1EDCD04")]
	public bool IsMainShow()
	{
		return default(bool);
	}

	// Token: 0x06001635 RID: 5685 RVA: 0x00008808 File Offset: 0x00006A08
	[Token(Token = "0x6001635")]
	[Address(RVA = "0x1EDC718", Offset = "0x1EDC718", VA = "0x1EDC718")]
	private bool InitSettingsByConfig()
	{
		return default(bool);
	}

	// Token: 0x06001636 RID: 5686 RVA: 0x00008820 File Offset: 0x00006A20
	[Token(Token = "0x6001636")]
	[Address(RVA = "0x1EDCBAC", Offset = "0x1EDCBAC", VA = "0x1EDCBAC")]
	private bool InitSettingsByPrefab()
	{
		return default(bool);
	}

	// Token: 0x06001637 RID: 5687 RVA: 0x00008838 File Offset: 0x00006A38
	[Token(Token = "0x6001637")]
	[Address(RVA = "0x1EDC6F0", Offset = "0x1EDC6F0", VA = "0x1EDC6F0")]
	private bool IsSceneUseLod()
	{
		return default(bool);
	}

	// Token: 0x06001638 RID: 5688 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001638")]
	[Address(RVA = "0x1EDD590", Offset = "0x1EDD590", VA = "0x1EDD590")]
	public void SetNoOptimizeActivate(bool noOptimizeActivate)
	{
	}

	// Token: 0x06001639 RID: 5689 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001639")]
	[Address(RVA = "0x1EDD59C", Offset = "0x1EDD59C", VA = "0x1EDD59C")]
	public AutoAdjustLod()
	{
	}

	// Token: 0x0400195A RID: 6490
	[Token(Token = "0x400195A")]
	[FieldOffset(Offset = "0x0")]
	public static readonly float FADE_DURATION;

	// Token: 0x0400195B RID: 6491
	[Token(Token = "0x400195B")]
	[FieldOffset(Offset = "0x4")]
	public static readonly Vector3 OUT_POS;

	// Token: 0x0400195C RID: 6492
	[Token(Token = "0x400195C")]
	[FieldOffset(Offset = "0x10")]
	public static readonly Dictionary<GameObject, Vector3> targetOriginPos;

	// Token: 0x0400195D RID: 6493
	[Token(Token = "0x400195D")]
	[FieldOffset(Offset = "0x28")]
	public AutoAdjustLod.LuaLoadFadeInOrOutCallback luaCallback;

	// Token: 0x0400195E RID: 6494
	[Token(Token = "0x400195E")]
	[FieldOffset(Offset = "0x30")]
	public bool noOptimizeActivate;

	// Token: 0x0400195F RID: 6495
	[Token(Token = "0x400195F")]
	[FieldOffset(Offset = "0x31")]
	private bool settingSucc;

	// Token: 0x04001960 RID: 6496
	[Token(Token = "0x4001960")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	private int lodType;

	// Token: 0x04001961 RID: 6497
	[Token(Token = "0x4001961")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private AutoAdjustLod.Setting[] settings;

	// Token: 0x02000361 RID: 865
	// (Invoke) Token: 0x0600163C RID: 5692
	[Token(Token = "0x2000361")]
	[CSharpCallLua]
	public delegate void LuaLoadFadeInOrOutCallback(int arg);

	// Token: 0x02000362 RID: 866
	[Token(Token = "0x2000362")]
	public enum ActiveState
	{
		// Token: 0x04001963 RID: 6499
		[Token(Token = "0x4001963")]
		Unknown = -1,
		// Token: 0x04001964 RID: 6500
		[Token(Token = "0x4001964")]
		False,
		// Token: 0x04001965 RID: 6501
		[Token(Token = "0x4001965")]
		True
	}

	// Token: 0x02000363 RID: 867
	[Token(Token = "0x2000363")]
	[Serializable]
	public class Setting
	{
		// Token: 0x0600163F RID: 5695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600163F")]
		[Address(RVA = "0x1EDD7C0", Offset = "0x1EDD7C0", VA = "0x1EDD7C0")]
		public void SetAdjuster(AutoAdjustLod adjuster)
		{
		}

		// Token: 0x06001640 RID: 5696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001640")]
		[Address(RVA = "0x1EDCD7C", Offset = "0x1EDCD7C", VA = "0x1EDCD7C")]
		public void InitByConfig(GameObject[] targets, LodConfig lodConfig)
		{
		}

		// Token: 0x06001641 RID: 5697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001641")]
		[Address(RVA = "0x1EDD310", Offset = "0x1EDD310", VA = "0x1EDD310")]
		public void InitByPrefab()
		{
		}

		// Token: 0x06001642 RID: 5698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001642")]
		[Address(RVA = "0x1EDC6AC", Offset = "0x1EDC6AC", VA = "0x1EDC6AC")]
		public void FadeIn()
		{
		}

		// Token: 0x06001643 RID: 5699 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001643")]
		[Address(RVA = "0x1EDC6B4", Offset = "0x1EDC6B4", VA = "0x1EDC6B4")]
		public void FadeOut()
		{
		}

		// Token: 0x06001644 RID: 5700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001644")]
		[Address(RVA = "0x1EDCF54", Offset = "0x1EDCF54", VA = "0x1EDCF54")]
		public void SetTargetsActive(bool active)
		{
		}

		// Token: 0x06001645 RID: 5701 RVA: 0x00008850 File Offset: 0x00006A50
		[Token(Token = "0x6001645")]
		[Address(RVA = "0x1EDD7C8", Offset = "0x1EDD7C8", VA = "0x1EDD7C8")]
		private bool IsOutPos(Vector3 pos)
		{
			return default(bool);
		}

		// Token: 0x06001646 RID: 5702 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001646")]
		[Address(RVA = "0x1EDD874", Offset = "0x1EDD874", VA = "0x1EDD874")]
		private Tween DOFadeSprites(GameObject target, float endValue, float duration)
		{
			return null;
		}

		// Token: 0x06001647 RID: 5703 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001647")]
		[Address(RVA = "0x1EDD94C", Offset = "0x1EDD94C", VA = "0x1EDD94C")]
		private Tween DOFadeTexts(GameObject target, float endValue, float duration)
		{
			return null;
		}

		// Token: 0x06001648 RID: 5704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001648")]
		[Address(RVA = "0x1EDCD64", Offset = "0x1EDCD64", VA = "0x1EDCD64")]
		public Setting()
		{
		}

		// Token: 0x04001966 RID: 6502
		[Token(Token = "0x4001966")]
		[FieldOffset(Offset = "0x10")]
		public GameObject[] targets;

		// Token: 0x04001967 RID: 6503
		[Token(Token = "0x4001967")]
		[FieldOffset(Offset = "0x18")]
		public string lodRange;

		// Token: 0x04001968 RID: 6504
		[Token(Token = "0x4001968")]
		[FieldOffset(Offset = "0x20")]
		public bool isMain;

		// Token: 0x04001969 RID: 6505
		[Token(Token = "0x4001969")]
		[FieldOffset(Offset = "0x21")]
		public bool noFading;

		// Token: 0x0400196A RID: 6506
		[Token(Token = "0x400196A")]
		[FieldOffset(Offset = "0x28")]
		[HideInInspector]
		public List<int> showLods;

		// Token: 0x0400196B RID: 6507
		[Token(Token = "0x400196B")]
		[FieldOffset(Offset = "0x30")]
		public AutoAdjustLod.ActiveState activeCache;

		// Token: 0x0400196C RID: 6508
		[Token(Token = "0x400196C")]
		[FieldOffset(Offset = "0x38")]
		private Sequence fadeSeq;

		// Token: 0x0400196D RID: 6509
		[Token(Token = "0x400196D")]
		[FieldOffset(Offset = "0x40")]
		private AutoAdjustLod adjuster;
	}
}
