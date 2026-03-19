using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using Il2CppDummyDll;
using Unity.Burst;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;
using UnityEngine;
using UnityEngine.Pool;
using UnityEngine.Rendering;

// Token: 0x02000282 RID: 642
[Token(Token = "0x2000282")]
public class RegionRenderManager : MonoBehaviour
{
	// Token: 0x170001F2 RID: 498
	// (get) Token: 0x0600110F RID: 4367 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170001F2")]
	public static RegionRenderManager Instance
	{
		[Token(Token = "0x600110F")]
		[Address(RVA = "0x1BF45A8", Offset = "0x1BF45A8", VA = "0x1BF45A8")]
		get
		{
			return null;
		}
	}

	// Token: 0x170001F3 RID: 499
	// (get) Token: 0x06001111 RID: 4369 RVA: 0x00006EB8 File Offset: 0x000050B8
	// (set) Token: 0x06001110 RID: 4368 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001F3")]
	public bool ForceRefresh
	{
		[Token(Token = "0x6001111")]
		[Address(RVA = "0x1BF460C", Offset = "0x1BF460C", VA = "0x1BF460C")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001110")]
		[Address(RVA = "0x1BF4600", Offset = "0x1BF4600", VA = "0x1BF4600")]
		[CompilerGenerated]
		set
		{
		}
	}

	// Token: 0x06001112 RID: 4370 RVA: 0x00006ED0 File Offset: 0x000050D0
	[Token(Token = "0x6001112")]
	[Address(RVA = "0x1BF4614", Offset = "0x1BF4614", VA = "0x1BF4614")]
	public int getIndex()
	{
		return 0;
	}

	// Token: 0x06001113 RID: 4371 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001113")]
	[Address(RVA = "0x1BF4900", Offset = "0x1BF4900", VA = "0x1BF4900")]
	public void CheckRegionUnlockByBound(Transform transform)
	{
	}

	// Token: 0x06001114 RID: 4372 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001114")]
	[Address(RVA = "0x1BF4E40", Offset = "0x1BF4E40", VA = "0x1BF4E40")]
	public void SetDecorateItemActive(Bounds areaBound, bool active)
	{
	}

	// Token: 0x06001115 RID: 4373 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001115")]
	[Address(RVA = "0x1BF5278", Offset = "0x1BF5278", VA = "0x1BF5278")]
	private void Start()
	{
	}

	// Token: 0x06001116 RID: 4374 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001116")]
	[Address(RVA = "0x1BF6210", Offset = "0x1BF6210", VA = "0x1BF6210")]
	private void OnDestroy()
	{
	}

	// Token: 0x06001117 RID: 4375 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001117")]
	[Address(RVA = "0x1BF66C4", Offset = "0x1BF66C4", VA = "0x1BF66C4")]
	private void OnApplicationQuit()
	{
	}

	// Token: 0x06001118 RID: 4376 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001118")]
	[Address(RVA = "0x1BF5B14", Offset = "0x1BF5B14", VA = "0x1BF5B14")]
	public void ResetMainCamera(Camera camera)
	{
	}

	// Token: 0x06001119 RID: 4377 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001119")]
	[Address(RVA = "0x1BF6AA8", Offset = "0x1BF6AA8", VA = "0x1BF6AA8")]
	private void OnEnable()
	{
	}

	// Token: 0x0600111A RID: 4378 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600111A")]
	[Address(RVA = "0x1BF6BA0", Offset = "0x1BF6BA0", VA = "0x1BF6BA0")]
	private void OnDisable()
	{
	}

	// Token: 0x0600111B RID: 4379 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600111B")]
	[Address(RVA = "0x1BF6CA8", Offset = "0x1BF6CA8", VA = "0x1BF6CA8")]
	private void OnTimeOfDayChanged(object userData)
	{
	}

	// Token: 0x0600111C RID: 4380 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600111C")]
	[Address(RVA = "0x1BF6E40", Offset = "0x1BF6E40", VA = "0x1BF6E40")]
	public void ResetRegionData()
	{
	}

	// Token: 0x0600111D RID: 4381 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600111D")]
	[Address(RVA = "0x1BF6D5C", Offset = "0x1BF6D5C", VA = "0x1BF6D5C")]
	private void ReFetchTimeOfDay()
	{
	}

	// Token: 0x0600111E RID: 4382 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600111E")]
	[Address(RVA = "0x1BF5BCC", Offset = "0x1BF5BCC", VA = "0x1BF5BCC")]
	private void InitData()
	{
	}

	// Token: 0x0600111F RID: 4383 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600111F")]
	[Address(RVA = "0x1BF707C", Offset = "0x1BF707C", VA = "0x1BF707C")]
	private void _InitRegionNativeList()
	{
	}

	// Token: 0x06001120 RID: 4384 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001120")]
	[Address(RVA = "0x1BF7430", Offset = "0x1BF7430", VA = "0x1BF7430")]
	private void Update()
	{
	}

	// Token: 0x06001121 RID: 4385 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001121")]
	[Address(RVA = "0x1BF76F0", Offset = "0x1BF76F0", VA = "0x1BF76F0")]
	private void LateUpdate()
	{
	}

	// Token: 0x06001122 RID: 4386 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001122")]
	[Address(RVA = "0x1BF77D0", Offset = "0x1BF77D0", VA = "0x1BF77D0")]
	private void GenFrustumPlanes()
	{
	}

	// Token: 0x06001123 RID: 4387 RVA: 0x00006EE8 File Offset: 0x000050E8
	[Token(Token = "0x6001123")]
	[Address(RVA = "0x1BF7568", Offset = "0x1BF7568", VA = "0x1BF7568")]
	private bool IsNeedReCulling()
	{
		return default(bool);
	}

	// Token: 0x06001124 RID: 4388 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001124")]
	[Address(RVA = "0x1BF6E00", Offset = "0x1BF6E00", VA = "0x1BF6E00")]
	private void CullingData1()
	{
	}

	// Token: 0x06001125 RID: 4389 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001125")]
	[Address(RVA = "0x1BF6E28", Offset = "0x1BF6E28", VA = "0x1BF6E28")]
	private void CullingData2()
	{
	}

	// Token: 0x06001126 RID: 4390 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001126")]
	[Address(RVA = "0x1BF7934", Offset = "0x1BF7934", VA = "0x1BF7934")]
	private void CullingRegion1()
	{
	}

	// Token: 0x06001127 RID: 4391 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001127")]
	[Address(RVA = "0x1BF7AC8", Offset = "0x1BF7AC8", VA = "0x1BF7AC8")]
	private void CullingRegion2()
	{
	}

	// Token: 0x06001128 RID: 4392 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001128")]
	[Address(RVA = "0x1BF7FA8", Offset = "0x1BF7FA8", VA = "0x1BF7FA8")]
	private void CullingObjects()
	{
	}

	// Token: 0x06001129 RID: 4393 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001129")]
	[Address(RVA = "0x1BF8ABC", Offset = "0x1BF8ABC", VA = "0x1BF8ABC")]
	private void ComputeBufferApply(RegionRenderManager.ComputeData computeData, RegionRenderManager.RenderData renderAssetData, int idx, int resId)
	{
	}

	// Token: 0x0600112A RID: 4394 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600112A")]
	[Address(RVA = "0x1BF3A38", Offset = "0x1BF3A38", VA = "0x1BF3A38")]
	public void Draw(CommandBuffer cmd)
	{
	}

	// Token: 0x0600112B RID: 4395 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600112B")]
	[Address(RVA = "0x1BF89CC", Offset = "0x1BF89CC", VA = "0x1BF89CC")]
	private Mesh GetMeshByName(string meshName)
	{
		return null;
	}

	// Token: 0x0600112C RID: 4396 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600112C")]
	[Address(RVA = "0x1BF8A44", Offset = "0x1BF8A44", VA = "0x1BF8A44")]
	private Material GetMaterialByName(string matName)
	{
		return null;
	}

	// Token: 0x0600112D RID: 4397 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600112D")]
	[Address(RVA = "0x1BF6414", Offset = "0x1BF6414", VA = "0x1BF6414")]
	private void ClearRenderDataList()
	{
	}

	// Token: 0x0600112E RID: 4398 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600112E")]
	[Address(RVA = "0x1BF66C8", Offset = "0x1BF66C8", VA = "0x1BF66C8")]
	private void ClearComputeDataList()
	{
	}

	// Token: 0x0600112F RID: 4399 RVA: 0x00006F00 File Offset: 0x00005100
	[Token(Token = "0x600112F")]
	[Address(RVA = "0x1BF8998", Offset = "0x1BF8998", VA = "0x1BF8998")]
	private bool LodCheck(DecorateItemScriptableObject data, float curZoom)
	{
		return default(bool);
	}

	// Token: 0x06001130 RID: 4400 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001130")]
	[Address(RVA = "0x1BF8ECC", Offset = "0x1BF8ECC", VA = "0x1BF8ECC")]
	private void DebugPrint()
	{
	}

	// Token: 0x06001131 RID: 4401 RVA: 0x00006F18 File Offset: 0x00005118
	[Token(Token = "0x6001131")]
	[Address(RVA = "0x1BF5540", Offset = "0x1BF5540", VA = "0x1BF5540")]
	public static bool IsComputeShaderSupported(ComputeShader computeShader, bool verbose = true)
	{
		return default(bool);
	}

	// Token: 0x06001132 RID: 4402 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001132")]
	[Address(RVA = "0x1BF8ED0", Offset = "0x1BF8ED0", VA = "0x1BF8ED0")]
	public RegionRenderManager()
	{
	}

	// Token: 0x040013B6 RID: 5046
	[Token(Token = "0x40013B6")]
	private const int RenderPerOnceMax = 1023;

	// Token: 0x040013B7 RID: 5047
	[Token(Token = "0x40013B7")]
	[FieldOffset(Offset = "0x18")]
	private ObjectPool<List<DecorateItemScriptableObject>> _decorateListPool;

	// Token: 0x040013B8 RID: 5048
	[Token(Token = "0x40013B8")]
	[FieldOffset(Offset = "0x20")]
	private readonly ObjectPool<RegionRenderManager.RenderData> _objectPool;

	// Token: 0x040013B9 RID: 5049
	[Token(Token = "0x40013B9")]
	[FieldOffset(Offset = "0x28")]
	private Dictionary<int, List<RegionRenderManager.RenderData>> _dicRenderDataList;

	// Token: 0x040013BA RID: 5050
	[Token(Token = "0x40013BA")]
	[FieldOffset(Offset = "0x0")]
	private static Dictionary<int, List<RegionRenderManager.ComputeData>> _dicComputeDataList;

	// Token: 0x040013BB RID: 5051
	[Token(Token = "0x40013BB")]
	[FieldOffset(Offset = "0x30")]
	public TotalScriptableObject totalScriptableObject;

	// Token: 0x040013BC RID: 5052
	[Token(Token = "0x40013BC")]
	[FieldOffset(Offset = "0x38")]
	public Camera _currentCamera;

	// Token: 0x040013BD RID: 5053
	[Token(Token = "0x40013BD")]
	[FieldOffset(Offset = "0x8")]
	private static RegionRenderManager instance;

	// Token: 0x040013BE RID: 5054
	[Token(Token = "0x40013BE")]
	[FieldOffset(Offset = "0x40")]
	private Transform _currentCameraTf;

	// Token: 0x040013BF RID: 5055
	[Token(Token = "0x40013BF")]
	[FieldOffset(Offset = "0x48")]
	private readonly Plane[] _planes;

	// Token: 0x040013C0 RID: 5056
	[Token(Token = "0x40013C0")]
	[FieldOffset(Offset = "0x50")]
	private readonly List<RegionDetailScriptableObject> _tmpRegionDetailList;

	// Token: 0x040013C1 RID: 5057
	[Token(Token = "0x40013C1")]
	[FieldOffset(Offset = "0x58")]
	private readonly Dictionary<string, Mesh> _meshDict;

	// Token: 0x040013C2 RID: 5058
	[Token(Token = "0x40013C2")]
	[FieldOffset(Offset = "0x60")]
	private readonly Dictionary<string, Material> _materialDict;

	// Token: 0x040013C3 RID: 5059
	[Token(Token = "0x40013C3")]
	[FieldOffset(Offset = "0x68")]
	private bool _useInstance;

	// Token: 0x040013C4 RID: 5060
	[Token(Token = "0x40013C4")]
	[FieldOffset(Offset = "0x6C")]
	private Vector3 _lastCameraPos;

	// Token: 0x040013C5 RID: 5061
	[Token(Token = "0x40013C5")]
	[FieldOffset(Offset = "0x78")]
	private Quaternion _lastCameraRot;

	// Token: 0x040013C6 RID: 5062
	[Token(Token = "0x40013C6")]
	[FieldOffset(Offset = "0x88")]
	private float _lastCameraFov;

	// Token: 0x040013C7 RID: 5063
	[Token(Token = "0x40013C7")]
	[FieldOffset(Offset = "0x90")]
	private readonly List<double> _debugCostRecord;

	// Token: 0x040013C8 RID: 5064
	[Token(Token = "0x40013C8")]
	[FieldOffset(Offset = "0x98")]
	private readonly StringBuilder _stringBuilder;

	// Token: 0x040013C9 RID: 5065
	[Token(Token = "0x40013C9")]
	private const bool DebugOpen = false;

	// Token: 0x040013CA RID: 5066
	[Token(Token = "0x40013CA")]
	[FieldOffset(Offset = "0xA0")]
	private readonly Stopwatch _stopwatch;

	// Token: 0x040013CB RID: 5067
	[Token(Token = "0x40013CB")]
	[FieldOffset(Offset = "0xA8")]
	private int _defaultLayer;

	// Token: 0x040013CC RID: 5068
	[Token(Token = "0x40013CC")]
	[FieldOffset(Offset = "0xAC")]
	private bool _curIsNightTime;

	// Token: 0x040013CE RID: 5070
	[Token(Token = "0x40013CE")]
	[FieldOffset(Offset = "0xB0")]
	private UnsafeList<RegionRenderManager.RegionJobItem> _allRegions;

	// Token: 0x040013CF RID: 5071
	[Token(Token = "0x40013CF")]
	[FieldOffset(Offset = "0xD0")]
	public Dictionary<int, bool> unlockRegionList;

	// Token: 0x040013D0 RID: 5072
	[Token(Token = "0x40013D0")]
	[FieldOffset(Offset = "0xD8")]
	private Dictionary<int, List<DecorateItemScriptableObject>> _afterCullObjects;

	// Token: 0x040013D1 RID: 5073
	[Token(Token = "0x40013D1")]
	[FieldOffset(Offset = "0xE0")]
	private bool _isHasDisabled;

	// Token: 0x040013D2 RID: 5074
	[Token(Token = "0x40013D2")]
	[FieldOffset(Offset = "0xE4")]
	private int _AfterDisabledCount;

	// Token: 0x040013D3 RID: 5075
	[Token(Token = "0x40013D3")]
	[FieldOffset(Offset = "0xE8")]
	private bool _isTimeOfDayChanged;

	// Token: 0x040013D4 RID: 5076
	[Token(Token = "0x40013D4")]
	[FieldOffset(Offset = "0xE9")]
	public bool _isEnableAsync;

	// Token: 0x040013D5 RID: 5077
	[Token(Token = "0x40013D5")]
	[FieldOffset(Offset = "0xEA")]
	public bool _isIndirectDraw;

	// Token: 0x040013D6 RID: 5078
	[Token(Token = "0x40013D6")]
	[FieldOffset(Offset = "0xEB")]
	public bool _isCullingRegion;

	// Token: 0x040013D7 RID: 5079
	[Token(Token = "0x40013D7")]
	[FieldOffset(Offset = "0xF0")]
	public ComputeShader _frustumCullShader;

	// Token: 0x040013D8 RID: 5080
	[Token(Token = "0x40013D8")]
	[FieldOffset(Offset = "0xF8")]
	public Bounds _drawBounds;

	// Token: 0x040013D9 RID: 5081
	[Token(Token = "0x40013D9")]
	[FieldOffset(Offset = "0x110")]
	private int _kernelID;

	// Token: 0x040013DA RID: 5082
	[Token(Token = "0x40013DA")]
	[FieldOffset(Offset = "0x114")]
	private int _matrixBufferID;

	// Token: 0x040013DB RID: 5083
	[Token(Token = "0x40013DB")]
	[FieldOffset(Offset = "0x118")]
	private int _matrixTexID;

	// Token: 0x040013DC RID: 5084
	[Token(Token = "0x40013DC")]
	[FieldOffset(Offset = "0x11C")]
	private int _matrixTextureID;

	// Token: 0x040013DD RID: 5085
	[Token(Token = "0x40013DD")]
	[FieldOffset(Offset = "0x120")]
	private int _visibleCountID;

	// Token: 0x040013DE RID: 5086
	[Token(Token = "0x40013DE")]
	[FieldOffset(Offset = "0x124")]
	private int _frustumPlanesID;

	// Token: 0x040013DF RID: 5087
	[Token(Token = "0x40013DF")]
	[FieldOffset(Offset = "0x128")]
	private int _extentsID;

	// Token: 0x040013E0 RID: 5088
	[Token(Token = "0x40013E0")]
	[FieldOffset(Offset = "0x12C")]
	public float heightBlockSize;

	// Token: 0x040013E1 RID: 5089
	[Token(Token = "0x40013E1")]
	[FieldOffset(Offset = "0x130")]
	private bool _needReCull;

	// Token: 0x040013E2 RID: 5090
	[Token(Token = "0x40013E2")]
	[FieldOffset(Offset = "0x10")]
	public static bool ShowLand;

	// Token: 0x040013E3 RID: 5091
	[Token(Token = "0x40013E3")]
	[FieldOffset(Offset = "0x138")]
	private JobHandle _jobHandle;

	// Token: 0x040013E4 RID: 5092
	[Token(Token = "0x40013E4")]
	[FieldOffset(Offset = "0x148")]
	private UnsafeList<bool> _regionIdx;

	// Token: 0x040013E5 RID: 5093
	[Token(Token = "0x40013E5")]
	[FieldOffset(Offset = "0x168")]
	private UnsafeList<Plane> _tmpPlane;

	// Token: 0x040013E6 RID: 5094
	[Token(Token = "0x40013E6")]
	[FieldOffset(Offset = "0x188")]
	private GraphicsFence _fence;

	// Token: 0x040013E7 RID: 5095
	[Token(Token = "0x40013E7")]
	[FieldOffset(Offset = "0x198")]
	private bool _hasFence;

	// Token: 0x040013E8 RID: 5096
	[Token(Token = "0x40013E8")]
	[FieldOffset(Offset = "0x18")]
	private static readonly string[] BlackListGPU;

	// Token: 0x040013E9 RID: 5097
	[Token(Token = "0x40013E9")]
	[FieldOffset(Offset = "0x20")]
	private static readonly string[] PartialSupportGPU;

	// Token: 0x02000283 RID: 643
	[Token(Token = "0x2000283")]
	private class RenderData
	{
		// Token: 0x06001134 RID: 4404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001134")]
		[Address(RVA = "0x1C4DE10", Offset = "0x1C4DE10", VA = "0x1C4DE10")]
		public RenderData()
		{
		}

		// Token: 0x040013EA RID: 5098
		[Token(Token = "0x40013EA")]
		[FieldOffset(Offset = "0x10")]
		public int ResId;

		// Token: 0x040013EB RID: 5099
		[Token(Token = "0x40013EB")]
		[FieldOffset(Offset = "0x18")]
		public Mesh Mesh;

		// Token: 0x040013EC RID: 5100
		[Token(Token = "0x40013EC")]
		[FieldOffset(Offset = "0x20")]
		public Material Mat;

		// Token: 0x040013ED RID: 5101
		[Token(Token = "0x40013ED")]
		[FieldOffset(Offset = "0x28")]
		public Matrix4x4[] Matrix4X4List;

		// Token: 0x040013EE RID: 5102
		[Token(Token = "0x40013EE")]
		[FieldOffset(Offset = "0x30")]
		public int Count;
	}

	// Token: 0x02000284 RID: 644
	[Token(Token = "0x2000284")]
	private class ComputeData
	{
		// Token: 0x06001135 RID: 4405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001135")]
		[Address(RVA = "0x1C4DE74", Offset = "0x1C4DE74", VA = "0x1C4DE74")]
		public ComputeData()
		{
		}

		// Token: 0x040013EF RID: 5103
		[Token(Token = "0x40013EF")]
		[FieldOffset(Offset = "0x10")]
		public ComputeBuffer ArgsBuffer;

		// Token: 0x040013F0 RID: 5104
		[Token(Token = "0x40013F0")]
		[FieldOffset(Offset = "0x18")]
		public ComputeBuffer MatrixBuffer;

		// Token: 0x040013F1 RID: 5105
		[Token(Token = "0x40013F1")]
		[FieldOffset(Offset = "0x20")]
		public RenderTexture MatrixTexture;

		// Token: 0x040013F2 RID: 5106
		[Token(Token = "0x40013F2")]
		[FieldOffset(Offset = "0x28")]
		public ComputeBuffer VisibleCount;

		// Token: 0x040013F3 RID: 5107
		[Token(Token = "0x40013F3")]
		[FieldOffset(Offset = "0x30")]
		public float[] Extents;
	}

	// Token: 0x02000285 RID: 645
	[Token(Token = "0x2000285")]
	private struct RegionJobItem
	{
		// Token: 0x040013F4 RID: 5108
		[Token(Token = "0x40013F4")]
		[FieldOffset(Offset = "0x0")]
		public Bounds _bound;

		// Token: 0x040013F5 RID: 5109
		[Token(Token = "0x40013F5")]
		[FieldOffset(Offset = "0x18")]
		public int regionIdx;
	}

	// Token: 0x02000286 RID: 646
	[Token(Token = "0x2000286")]
	[BurstCompile]
	private struct RegionSelectJob : IJobParallelFor
	{
		// Token: 0x06001136 RID: 4406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001136")]
		[Address(RVA = "0x1C4DE7C", Offset = "0x1C4DE7C", VA = "0x1C4DE7C", Slot = "4")]
		public void Execute(int index)
		{
		}

		// Token: 0x040013F6 RID: 5110
		[Token(Token = "0x40013F6")]
		[FieldOffset(Offset = "0x0")]
		public UnsafeList<RegionRenderManager.RegionJobItem> regions;

		// Token: 0x040013F7 RID: 5111
		[Token(Token = "0x40013F7")]
		[FieldOffset(Offset = "0x20")]
		public UnsafeList<Plane> planes;

		// Token: 0x040013F8 RID: 5112
		[Token(Token = "0x40013F8")]
		[FieldOffset(Offset = "0x40")]
		public UnsafeList<bool> regionIdx;
	}
}
