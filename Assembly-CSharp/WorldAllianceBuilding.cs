using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

// Token: 0x020002E8 RID: 744
[Token(Token = "0x20002E8")]
public class WorldAllianceBuilding : MonoBehaviour, ITouchPickable, ITouchObjectClickHandler, ITouchObject
{
	// Token: 0x1700020F RID: 527
	// (get) Token: 0x0600132F RID: 4911 RVA: 0x00007998 File Offset: 0x00005B98
	[Token(Token = "0x1700020F")]
	public float Distance
	{
		[Token(Token = "0x600132F")]
		[Address(RVA = "0x1A4814C", Offset = "0x1A4814C", VA = "0x1A4814C", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return 0f;
		}
	}

	// Token: 0x17000210 RID: 528
	// (get) Token: 0x06001330 RID: 4912 RVA: 0x000079B0 File Offset: 0x00005BB0
	// (set) Token: 0x06001331 RID: 4913 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000210")]
	public Vector2Int TilePos
	{
		[Token(Token = "0x6001330")]
		[Address(RVA = "0x1A48154", Offset = "0x1A48154", VA = "0x1A48154")]
		get
		{
			return default(Vector2Int);
		}
		[Token(Token = "0x6001331")]
		[Address(RVA = "0x1A4815C", Offset = "0x1A4815C", VA = "0x1A4815C")]
		set
		{
		}
	}

	// Token: 0x17000211 RID: 529
	// (get) Token: 0x06001332 RID: 4914 RVA: 0x000079C8 File Offset: 0x00005BC8
	// (set) Token: 0x06001333 RID: 4915 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000211")]
	public long Uuid
	{
		[Token(Token = "0x6001332")]
		[Address(RVA = "0x1A48278", Offset = "0x1A48278", VA = "0x1A48278")]
		[CompilerGenerated]
		get
		{
			return 0L;
		}
		[Token(Token = "0x6001333")]
		[Address(RVA = "0x1A48280", Offset = "0x1A48280", VA = "0x1A48280")]
		[CompilerGenerated]
		set
		{
		}
	}

	// Token: 0x06001334 RID: 4916 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001334")]
	[Address(RVA = "0x1A48288", Offset = "0x1A48288", VA = "0x1A48288", Slot = "18")]
	protected internal virtual void CSInit(object userData)
	{
	}

	// Token: 0x06001335 RID: 4917 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001335")]
	[Address(RVA = "0x1A490B0", Offset = "0x1A490B0", VA = "0x1A490B0", Slot = "19")]
	protected internal virtual void CSUninit()
	{
	}

	// Token: 0x06001336 RID: 4918 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001336")]
	[Address(RVA = "0x1A49154", Offset = "0x1A49154", VA = "0x1A49154", Slot = "20")]
	public virtual void refeshDate()
	{
	}

	// Token: 0x06001337 RID: 4919 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001337")]
	[Address(RVA = "0x1A481C8", Offset = "0x1A481C8", VA = "0x1A481C8")]
	private void SetTilePos1(Vector2Int pos, Vector3 worldpos)
	{
	}

	// Token: 0x06001338 RID: 4920 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001338")]
	[Address(RVA = "0x1A49410", Offset = "0x1A49410", VA = "0x1A49410")]
	private void SetTouchPickAblePos()
	{
	}

	// Token: 0x06001339 RID: 4921 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001339")]
	[Address(RVA = "0x1A48738", Offset = "0x1A48738", VA = "0x1A48738")]
	private void FromUILoad()
	{
	}

	// Token: 0x0600133A RID: 4922 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600133A")]
	[Address(RVA = "0x1A48BB0", Offset = "0x1A48BB0", VA = "0x1A48BB0")]
	public void EnterMoveCityState(int moveCityType)
	{
	}

	// Token: 0x0600133B RID: 4923 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600133B")]
	[Address(RVA = "0x1A4972C", Offset = "0x1A4972C", VA = "0x1A4972C", Slot = "5")]
	public Transform GetTransform()
	{
		return null;
	}

	// Token: 0x0600133C RID: 4924 RVA: 0x000079E0 File Offset: 0x00005BE0
	[Token(Token = "0x600133C")]
	[Address(RVA = "0x1A497BC", Offset = "0x1A497BC", VA = "0x1A497BC", Slot = "7")]
	public bool PointInPick()
	{
		return default(bool);
	}

	// Token: 0x0600133D RID: 4925 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600133D")]
	[Address(RVA = "0x1A49900", Offset = "0x1A49900", VA = "0x1A49900", Slot = "8")]
	public void Drag(Vector3 pos)
	{
	}

	// Token: 0x0600133E RID: 4926 RVA: 0x000079F8 File Offset: 0x00005BF8
	[Token(Token = "0x600133E")]
	[Address(RVA = "0x1A49C1C", Offset = "0x1A49C1C", VA = "0x1A49C1C", Slot = "21")]
	public virtual bool Select()
	{
		return default(bool);
	}

	// Token: 0x0600133F RID: 4927 RVA: 0x00007A10 File Offset: 0x00005C10
	[Token(Token = "0x600133F")]
	[Address(RVA = "0x1A49C24", Offset = "0x1A49C24", VA = "0x1A49C24", Slot = "4")]
	public bool CanLongTap()
	{
		return default(bool);
	}

	// Token: 0x06001340 RID: 4928 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001340")]
	private T ITouchPickable.GetPickComponent<T>()
	{
		return null;
	}

	// Token: 0x06001341 RID: 4929 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001341")]
	[Address(RVA = "0x1A492EC", Offset = "0x1A492EC", VA = "0x1A492EC")]
	private void InitBuildingGrow()
	{
	}

	// Token: 0x06001342 RID: 4930 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001342")]
	[Address(RVA = "0x1A49644", Offset = "0x1A49644", VA = "0x1A49644")]
	private void ShowShadow(bool isShow)
	{
	}

	// Token: 0x06001343 RID: 4931 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001343")]
	[Address(RVA = "0x1A49C2C", Offset = "0x1A49C2C", VA = "0x1A49C2C", Slot = "10")]
	private void ITouchPickable.Click()
	{
	}

	// Token: 0x06001344 RID: 4932 RVA: 0x00007A28 File Offset: 0x00005C28
	[Token(Token = "0x6001344")]
	[Address(RVA = "0x1A49C30", Offset = "0x1A49C30", VA = "0x1A49C30", Slot = "11")]
	public bool IsOutRange(Vector3 pos)
	{
		return default(bool);
	}

	// Token: 0x06001345 RID: 4933 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001345")]
	[Address(RVA = "0x1A49CEC", Offset = "0x1A49CEC", VA = "0x1A49CEC", Slot = "12")]
	public void ChangeTouchPos(int index)
	{
	}

	// Token: 0x06001346 RID: 4934 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001346")]
	[Address(RVA = "0x1A49CF0", Offset = "0x1A49CF0", VA = "0x1A49CF0")]
	public void ResetParam(int posIndex = 0)
	{
	}

	// Token: 0x06001347 RID: 4935 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001347")]
	[Address(RVA = "0x1A49D00", Offset = "0x1A49D00", VA = "0x1A49D00")]
	public void ChangeMove()
	{
	}

	// Token: 0x06001348 RID: 4936 RVA: 0x00007A40 File Offset: 0x00005C40
	[Token(Token = "0x6001348")]
	[Address(RVA = "0x1A49D20", Offset = "0x1A49D20", VA = "0x1A49D20", Slot = "13")]
	public Vector3 GetClosestPoint(Vector3 pos)
	{
		return default(Vector3);
	}

	// Token: 0x17000212 RID: 530
	// (get) Token: 0x06001349 RID: 4937 RVA: 0x00007A58 File Offset: 0x00005C58
	[Token(Token = "0x17000212")]
	private float ITouchObject.Priority
	{
		[Token(Token = "0x6001349")]
		[Address(RVA = "0x1A49E28", Offset = "0x1A49E28", VA = "0x1A49E28", Slot = "15")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x17000213 RID: 531
	// (get) Token: 0x0600134A RID: 4938 RVA: 0x00007A70 File Offset: 0x00005C70
	[Token(Token = "0x17000213")]
	private Vector2Int ITouchObject.TilePos
	{
		[Token(Token = "0x600134A")]
		[Address(RVA = "0x1A49E30", Offset = "0x1A49E30", VA = "0x1A49E30", Slot = "17")]
		get
		{
			return default(Vector2Int);
		}
	}

	// Token: 0x0600134B RID: 4939 RVA: 0x00007A88 File Offset: 0x00005C88
	[Token(Token = "0x600134B")]
	[Address(RVA = "0x1A49E70", Offset = "0x1A49E70", VA = "0x1A49E70", Slot = "14")]
	public bool OnClick()
	{
		return default(bool);
	}

	// Token: 0x0600134C RID: 4940 RVA: 0x00007AA0 File Offset: 0x00005CA0
	[Token(Token = "0x600134C")]
	[Address(RVA = "0x1A49E78", Offset = "0x1A49E78", VA = "0x1A49E78")]
	public float GetHeight()
	{
		return 0f;
	}

	// Token: 0x0600134D RID: 4941 RVA: 0x00007AB8 File Offset: 0x00005CB8
	[Token(Token = "0x600134D")]
	[Address(RVA = "0x1A49F00", Offset = "0x1A49F00", VA = "0x1A49F00")]
	public bool ContainsPos(Vector2Int pos)
	{
		return default(bool);
	}

	// Token: 0x0600134E RID: 4942 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600134E")]
	[Address(RVA = "0x1A49FAC", Offset = "0x1A49FAC", VA = "0x1A49FAC")]
	public void ProfileToggleGlass()
	{
	}

	// Token: 0x0600134F RID: 4943 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600134F")]
	[Address(RVA = "0x1A4A078", Offset = "0x1A4A078", VA = "0x1A4A078")]
	public WorldAllianceBuilding()
	{
	}

	// Token: 0x0400161B RID: 5659
	[Token(Token = "0x400161B")]
	[FieldOffset(Offset = "0x0")]
	public static float ScreenRangeLeft;

	// Token: 0x0400161C RID: 5660
	[Token(Token = "0x400161C")]
	[FieldOffset(Offset = "0x4")]
	public static float ScreenRangeRight;

	// Token: 0x0400161D RID: 5661
	[Token(Token = "0x400161D")]
	[FieldOffset(Offset = "0x8")]
	public static float ScreenRangeTop;

	// Token: 0x0400161E RID: 5662
	[Token(Token = "0x400161E")]
	[FieldOffset(Offset = "0xC")]
	public static float ScreenRangeDown;

	// Token: 0x0400161F RID: 5663
	[Token(Token = "0x400161F")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject _shadow;

	// Token: 0x04001620 RID: 5664
	[Token(Token = "0x4001620")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject _baseGlass;

	// Token: 0x04001621 RID: 5665
	[Token(Token = "0x4001621")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private GameObject _effectGo;

	// Token: 0x04001622 RID: 5666
	[Token(Token = "0x4001622")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private GPUSkinningAnimator gpuAnim;

	// Token: 0x04001623 RID: 5667
	[Token(Token = "0x4001623")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private SimpleAnimation simpleAnim;

	// Token: 0x04001624 RID: 5668
	[Token(Token = "0x4001624")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private SimpleAnimation _effectAnim;

	// Token: 0x04001625 RID: 5669
	[Token(Token = "0x4001625")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private GameObject _foldUpGo;

	// Token: 0x04001626 RID: 5670
	[Token(Token = "0x4001626")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private GameObject _normalObj;

	// Token: 0x04001627 RID: 5671
	[Token(Token = "0x4001627")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private GameObject _boxObj;

	// Token: 0x04001628 RID: 5672
	[Token(Token = "0x4001628")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private GameObject _ruinsObj;

	// Token: 0x04001629 RID: 5673
	[Token(Token = "0x4001629")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private SimpleAnimation _boxAnim;

	// Token: 0x0400162A RID: 5674
	[Token(Token = "0x400162A")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private UIEventTrigger _focusEventTrigger;

	// Token: 0x0400162B RID: 5675
	[Token(Token = "0x400162B")]
	[FieldOffset(Offset = "0x78")]
	private UIWorldLabel[] cityLabels;

	// Token: 0x0400162C RID: 5676
	[Token(Token = "0x400162C")]
	[FieldOffset(Offset = "0x80")]
	private Vector2Int tilePos;

	// Token: 0x0400162D RID: 5677
	[Token(Token = "0x400162D")]
	[FieldOffset(Offset = "0x88")]
	private InstanceRequest tempInstance;

	// Token: 0x0400162E RID: 5678
	[Token(Token = "0x400162E")]
	[FieldOffset(Offset = "0x90")]
	private AutoAdjustLod adjuster;

	// Token: 0x04001631 RID: 5681
	[Token(Token = "0x4001631")]
	[FieldOffset(Offset = "0xA8")]
	public int build_Id;

	// Token: 0x04001632 RID: 5682
	[Token(Token = "0x4001632")]
	[FieldOffset(Offset = "0xAC")]
	public int tiles;

	// Token: 0x04001633 RID: 5683
	[Token(Token = "0x4001633")]
	[FieldOffset(Offset = "0xB0")]
	private WorldAllianceBuilding.Param _param;

	// Token: 0x04001634 RID: 5684
	[Token(Token = "0x4001634")]
	[FieldOffset(Offset = "0xB8")]
	private string _animName;

	// Token: 0x04001635 RID: 5685
	[Token(Token = "0x4001635")]
	[FieldOffset(Offset = "0xC0")]
	private BuildingGrowEffect _grow;

	// Token: 0x04001636 RID: 5686
	[Token(Token = "0x4001636")]
	[FieldOffset(Offset = "0xC8")]
	private float _minX;

	// Token: 0x04001637 RID: 5687
	[Token(Token = "0x4001637")]
	[FieldOffset(Offset = "0xCC")]
	private float _maxX;

	// Token: 0x04001638 RID: 5688
	[Token(Token = "0x4001638")]
	[FieldOffset(Offset = "0xD0")]
	private float _minY;

	// Token: 0x04001639 RID: 5689
	[Token(Token = "0x4001639")]
	[FieldOffset(Offset = "0xD4")]
	private float _maxY;

	// Token: 0x0400163A RID: 5690
	[Token(Token = "0x400163A")]
	[FieldOffset(Offset = "0xD8")]
	private bool? _canShowCityLabel;

	// Token: 0x0400163B RID: 5691
	[Token(Token = "0x400163B")]
	[FieldOffset(Offset = "0xE0")]
	private string _ownerUuid;

	// Token: 0x0400163C RID: 5692
	[Token(Token = "0x400163C")]
	[FieldOffset(Offset = "0xE8")]
	protected int _level;

	// Token: 0x0400163D RID: 5693
	[Token(Token = "0x400163D")]
	[FieldOffset(Offset = "0xEC")]
	private int _offset_range;

	// Token: 0x0400163E RID: 5694
	[Token(Token = "0x400163E")]
	[FieldOffset(Offset = "0xF0")]
	private int _state;

	// Token: 0x0400163F RID: 5695
	[Token(Token = "0x400163F")]
	[FieldOffset(Offset = "0xF4")]
	private bool _glassVisible;

	// Token: 0x020002E9 RID: 745
	[Token(Token = "0x20002E9")]
	public enum AllianceBuildSceneType
	{
		// Token: 0x04001641 RID: 5697
		[Token(Token = "0x4001641")]
		World = 1,
		// Token: 0x04001642 RID: 5698
		[Token(Token = "0x4001642")]
		Fake
	}

	// Token: 0x020002EA RID: 746
	[Token(Token = "0x20002EA")]
	public class Param
	{
		// Token: 0x06001351 RID: 4945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001351")]
		[Address(RVA = "0x1A4A13C", Offset = "0x1A4A13C", VA = "0x1A4A13C")]
		public Param()
		{
		}

		// Token: 0x04001643 RID: 5699
		[Token(Token = "0x4001643")]
		[FieldOffset(Offset = "0x10")]
		public int buildId;

		// Token: 0x04001644 RID: 5700
		[Token(Token = "0x4001644")]
		[FieldOffset(Offset = "0x18")]
		public long buildUuid;

		// Token: 0x04001645 RID: 5701
		[Token(Token = "0x4001645")]
		[FieldOffset(Offset = "0x20")]
		public int point;

		// Token: 0x04001646 RID: 5702
		[Token(Token = "0x4001646")]
		[FieldOffset(Offset = "0x24")]
		public PlaceBuildType BuildTopType;

		// Token: 0x04001647 RID: 5703
		[Token(Token = "0x4001647")]
		[FieldOffset(Offset = "0x28")]
		public LuaTable noPutPoint;

		// Token: 0x04001648 RID: 5704
		[Token(Token = "0x4001648")]
		[FieldOffset(Offset = "0x30")]
		public WorldAllianceBuilding.AllianceBuildSceneType buildSceneType;
	}
}
