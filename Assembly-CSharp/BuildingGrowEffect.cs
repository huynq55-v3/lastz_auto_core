using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using VEngine;

// Token: 0x02000272 RID: 626
[Token(Token = "0x2000272")]
public class BuildingGrowEffect : MonoBehaviour
{
	// Token: 0x06001090 RID: 4240 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001090")]
	[Address(RVA = "0x1BEFA7C", Offset = "0x1BEFA7C", VA = "0x1BEFA7C")]
	private void Awake()
	{
	}

	// Token: 0x06001091 RID: 4241 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001091")]
	[Address(RVA = "0x1BEFAE4", Offset = "0x1BEFAE4", VA = "0x1BEFAE4")]
	public void StartBuild(long uuid, int buildId, int startTime, int endTime, int tileSize, string ownerUid, bool isDomeUpdate = false, bool isShowRobet = true, bool needGridAlpha = true)
	{
	}

	// Token: 0x06001092 RID: 4242 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001092")]
	[Address(RVA = "0x1BF00F8", Offset = "0x1BF00F8", VA = "0x1BF00F8")]
	public void DisappearBuild(long uuid, int buildId, int startTime, int endTime, int tileSize, string ownerUid)
	{
	}

	// Token: 0x06001093 RID: 4243 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001093")]
	[Address(RVA = "0x1BF04F0", Offset = "0x1BF04F0", VA = "0x1BF04F0")]
	public void ShowNormal(PlayerType playType = PlayerType.PlayerNone)
	{
	}

	// Token: 0x06001094 RID: 4244 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001094")]
	[Address(RVA = "0x1BF05E8", Offset = "0x1BF05E8", VA = "0x1BF05E8")]
	public void ShowBuildGridSelection()
	{
	}

	// Token: 0x06001095 RID: 4245 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001095")]
	[Address(RVA = "0x1BF0750", Offset = "0x1BF0750", VA = "0x1BF0750")]
	public void ShowCanPlace(bool canPlace)
	{
	}

	// Token: 0x06001096 RID: 4246 RVA: 0x00006E10 File Offset: 0x00005010
	[Token(Token = "0x6001096")]
	[Address(RVA = "0x1BF09B8", Offset = "0x1BF09B8", VA = "0x1BF09B8")]
	public float GetHeight()
	{
		return 0f;
	}

	// Token: 0x06001097 RID: 4247 RVA: 0x00006E28 File Offset: 0x00005028
	[Token(Token = "0x6001097")]
	[Address(RVA = "0x1BF09C4", Offset = "0x1BF09C4", VA = "0x1BF09C4")]
	private bool canStartGrow()
	{
		return default(bool);
	}

	// Token: 0x06001098 RID: 4248 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001098")]
	[Address(RVA = "0x1BF09DC", Offset = "0x1BF09DC", VA = "0x1BF09DC")]
	private void Update()
	{
	}

	// Token: 0x06001099 RID: 4249 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001099")]
	[Address(RVA = "0x1BF105C", Offset = "0x1BF105C", VA = "0x1BF105C")]
	private void OnDisable()
	{
	}

	// Token: 0x0600109A RID: 4250 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600109A")]
	[Address(RVA = "0x1BF00EC", Offset = "0x1BF00EC", VA = "0x1BF00EC")]
	private void SetNormalMaterials()
	{
	}

	// Token: 0x0600109B RID: 4251 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600109B")]
	[Address(RVA = "0x1BF0E84", Offset = "0x1BF0E84", VA = "0x1BF0E84")]
	private void EndAnimStage0()
	{
	}

	// Token: 0x0600109C RID: 4252 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600109C")]
	[Address(RVA = "0x1BF1164", Offset = "0x1BF1164", VA = "0x1BF1164")]
	public void EndAnim()
	{
	}

	// Token: 0x0600109D RID: 4253 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600109D")]
	[Address(RVA = "0x1BF118C", Offset = "0x1BF118C", VA = "0x1BF118C")]
	public void SetAlphaValue(float alpha)
	{
	}

	// Token: 0x0600109E RID: 4254 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600109E")]
	[Address(RVA = "0x1BF12C0", Offset = "0x1BF12C0", VA = "0x1BF12C0")]
	private void RefreshShowColor(PlayerType playType)
	{
	}

	// Token: 0x0600109F RID: 4255 RVA: 0x00006E40 File Offset: 0x00005040
	[Token(Token = "0x600109F")]
	[Address(RVA = "0x1BF13DC", Offset = "0x1BF13DC", VA = "0x1BF13DC")]
	public bool IsUseFakeShadow()
	{
		return default(bool);
	}

	// Token: 0x060010A0 RID: 4256 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010A0")]
	[Address(RVA = "0x1BF14E0", Offset = "0x1BF14E0", VA = "0x1BF14E0")]
	public void SetRendererMaterials()
	{
	}

	// Token: 0x060010A1 RID: 4257 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010A1")]
	[Address(RVA = "0x1BF14E4", Offset = "0x1BF14E4", VA = "0x1BF14E4")]
	private void TestStartBuild()
	{
	}

	// Token: 0x060010A2 RID: 4258 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010A2")]
	[Address(RVA = "0x1BF1690", Offset = "0x1BF1690", VA = "0x1BF1690")]
	private void TestStopBuild()
	{
	}

	// Token: 0x060010A3 RID: 4259 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010A3")]
	[Address(RVA = "0x1BF16B0", Offset = "0x1BF16B0", VA = "0x1BF16B0")]
	public BuildingGrowEffect()
	{
	}

	// Token: 0x0400134F RID: 4943
	[Token(Token = "0x400134F")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private BuildingGrowAnimationCurve animCurve;

	// Token: 0x04001350 RID: 4944
	[Token(Token = "0x4001350")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject normalObj;

	// Token: 0x04001351 RID: 4945
	[Token(Token = "0x4001351")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private GameObject shadowObj;

	// Token: 0x04001352 RID: 4946
	[Token(Token = "0x4001352")]
	[FieldOffset(Offset = "0x30")]
	private float EffectPlayLeftTime;

	// Token: 0x04001353 RID: 4947
	[Token(Token = "0x4001353")]
	[FieldOffset(Offset = "0x34")]
	private float GlassGridAlpha;

	// Token: 0x04001354 RID: 4948
	[Token(Token = "0x4001354")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private string[] prefabInstanceOnStart;

	// Token: 0x04001355 RID: 4949
	[Token(Token = "0x4001355")]
	[FieldOffset(Offset = "0x40")]
	private List<InstanceRequest> attachmentList;

	// Token: 0x04001356 RID: 4950
	[Token(Token = "0x4001356")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private float height;

	// Token: 0x04001357 RID: 4951
	[Token(Token = "0x4001357")]
	[FieldOffset(Offset = "0x4C")]
	[SerializeField]
	private float heightDelta;

	// Token: 0x04001358 RID: 4952
	[Token(Token = "0x4001358")]
	[FieldOffset(Offset = "0x50")]
	private Vector4 bounds;

	// Token: 0x04001359 RID: 4953
	[Token(Token = "0x4001359")]
	[FieldOffset(Offset = "0x60")]
	private Asset constructMaterial;

	// Token: 0x0400135A RID: 4954
	[Token(Token = "0x400135A")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private GameObject[] rendererMaterialsExclude;

	// Token: 0x0400135B RID: 4955
	[Token(Token = "0x400135B")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	[Space(10f)]
	private BuildingGrowEffect.RendererMaterial[] rendererMaterials;

	// Token: 0x0400135C RID: 4956
	[Token(Token = "0x400135C")]
	[FieldOffset(Offset = "0x78")]
	private int _startTime;

	// Token: 0x0400135D RID: 4957
	[Token(Token = "0x400135D")]
	[FieldOffset(Offset = "0x7C")]
	private int _endTime;

	// Token: 0x0400135E RID: 4958
	[Token(Token = "0x400135E")]
	[FieldOffset(Offset = "0x80")]
	private int _animStage;

	// Token: 0x0400135F RID: 4959
	[Token(Token = "0x400135F")]
	[FieldOffset(Offset = "0x88")]
	private long _uuid;

	// Token: 0x04001360 RID: 4960
	[Token(Token = "0x4001360")]
	[FieldOffset(Offset = "0x90")]
	private int _buildId;

	// Token: 0x04001361 RID: 4961
	[Token(Token = "0x4001361")]
	[FieldOffset(Offset = "0x94")]
	private float _time;

	// Token: 0x04001362 RID: 4962
	[Token(Token = "0x4001362")]
	[FieldOffset(Offset = "0x98")]
	public bool isWorking;

	// Token: 0x04001363 RID: 4963
	[Token(Token = "0x4001363")]
	[FieldOffset(Offset = "0x99")]
	public bool isHiding;

	// Token: 0x04001364 RID: 4964
	[Token(Token = "0x4001364")]
	[FieldOffset(Offset = "0xA0")]
	private MaterialPropertyBlock propBlock;

	// Token: 0x04001365 RID: 4965
	[Token(Token = "0x4001365")]
	[FieldOffset(Offset = "0xA8")]
	private float progressCurveFinalTime;

	// Token: 0x04001366 RID: 4966
	[Token(Token = "0x4001366")]
	[FieldOffset(Offset = "0xAC")]
	private float progressCurveFinalTimeEnd;

	// Token: 0x04001367 RID: 4967
	[Token(Token = "0x4001367")]
	[FieldOffset(Offset = "0xB0")]
	private float scanCurveFinalTime;

	// Token: 0x04001368 RID: 4968
	[Token(Token = "0x4001368")]
	[FieldOffset(Offset = "0xB4")]
	private float scanCurveFinalTimeEnd;

	// Token: 0x04001369 RID: 4969
	[Token(Token = "0x4001369")]
	[FieldOffset(Offset = "0xB8")]
	private float gridFinalTime;

	// Token: 0x0400136A RID: 4970
	[Token(Token = "0x400136A")]
	[FieldOffset(Offset = "0xBC")]
	private float gridFinalTimeEnd;

	// Token: 0x0400136B RID: 4971
	[Token(Token = "0x400136B")]
	[FieldOffset(Offset = "0xC0")]
	private float glassCoverCurveFinalTime;

	// Token: 0x0400136C RID: 4972
	[Token(Token = "0x400136C")]
	[FieldOffset(Offset = "0xC4")]
	private float glassCoverCurveFinalTimeEnd;

	// Token: 0x0400136D RID: 4973
	[Token(Token = "0x400136D")]
	[FieldOffset(Offset = "0xC8")]
	private bool isOther;

	// Token: 0x0400136E RID: 4974
	[Token(Token = "0x400136E")]
	[FieldOffset(Offset = "0xCC")]
	public float ProgressTime;

	// Token: 0x02000273 RID: 627
	[Token(Token = "0x2000273")]
	[Serializable]
	public class RendererMaterial
	{
		// Token: 0x060010A5 RID: 4261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60010A5")]
		[Address(RVA = "0x1BF194C", Offset = "0x1BF194C", VA = "0x1BF194C")]
		public RendererMaterial()
		{
		}

		// Token: 0x0400136F RID: 4975
		[Token(Token = "0x400136F")]
		[FieldOffset(Offset = "0x10")]
		public Renderer renderer;

		// Token: 0x04001370 RID: 4976
		[Token(Token = "0x4001370")]
		[FieldOffset(Offset = "0x18")]
		public Material[] normalMaterials;

		// Token: 0x04001371 RID: 4977
		[Token(Token = "0x4001371")]
		[FieldOffset(Offset = "0x20")]
		public Material[] growingMaterials;

		// Token: 0x04001372 RID: 4978
		[Token(Token = "0x4001372")]
		[FieldOffset(Offset = "0x28")]
		public Material[] disappearMaterials;

		// Token: 0x04001373 RID: 4979
		[Token(Token = "0x4001373")]
		[FieldOffset(Offset = "0x30")]
		public Material[] normalHighMaterials;
	}
}
