using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200001D RID: 29
[Token(Token = "0x200001D")]
public class DrawInstanceDecal : MonoBehaviour
{
	// Token: 0x06000044 RID: 68 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000044")]
	[Address(RVA = "0x15E2AC8", Offset = "0x15E2AC8", VA = "0x15E2AC8")]
	private void Start()
	{
	}

	// Token: 0x06000045 RID: 69 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000045")]
	[Address(RVA = "0x15E2E5C", Offset = "0x15E2E5C", VA = "0x15E2E5C")]
	private void OnLodChanged(object userdata)
	{
	}

	// Token: 0x06000046 RID: 70 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000046")]
	[Address(RVA = "0x15E2EF4", Offset = "0x15E2EF4", VA = "0x15E2EF4")]
	private void OnEnable()
	{
	}

	// Token: 0x06000047 RID: 71 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000047")]
	[Address(RVA = "0x15E2FB4", Offset = "0x15E2FB4", VA = "0x15E2FB4")]
	private void OnDisable()
	{
	}

	// Token: 0x06000048 RID: 72 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000048")]
	[Address(RVA = "0x15E3074", Offset = "0x15E3074", VA = "0x15E3074")]
	private void Update()
	{
	}

	// Token: 0x06000049 RID: 73 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000049")]
	[Address(RVA = "0x15E2C14", Offset = "0x15E2C14", VA = "0x15E2C14")]
	private void PrecomputeInstanceData()
	{
	}

	// Token: 0x0600004A RID: 74 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600004A")]
	[Address(RVA = "0x15E30B0", Offset = "0x15E30B0", VA = "0x15E30B0")]
	private void PerformCulling()
	{
	}

	// Token: 0x0600004B RID: 75 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600004B")]
	[Address(RVA = "0x15E34E4", Offset = "0x15E34E4", VA = "0x15E34E4")]
	private void DrawInstances()
	{
	}

	// Token: 0x0600004C RID: 76 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600004C")]
	[Address(RVA = "0x15E38E0", Offset = "0x15E38E0", VA = "0x15E38E0")]
	public void RefreshCulling()
	{
	}

	// Token: 0x0600004D RID: 77 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600004D")]
	[Address(RVA = "0x15E38E4", Offset = "0x15E38E4", VA = "0x15E38E4")]
	public void AddDecal(DrawInstanceDecalInfo decal)
	{
	}

	// Token: 0x0600004E RID: 78 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600004E")]
	[Address(RVA = "0x15E3998", Offset = "0x15E3998", VA = "0x15E3998")]
	public void RemoveDecal(int index)
	{
	}

	// Token: 0x0600004F RID: 79 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600004F")]
	[Address(RVA = "0x15E3A20", Offset = "0x15E3A20", VA = "0x15E3A20")]
	public DrawInstanceDecal()
	{
	}

	// Token: 0x04000090 RID: 144
	[Token(Token = "0x4000090")]
	[FieldOffset(Offset = "0x18")]
	public int maxLodRange;

	// Token: 0x04000091 RID: 145
	[Token(Token = "0x4000091")]
	[FieldOffset(Offset = "0x20")]
	[Header("贴花设置")]
	[SerializeField]
	private List<DrawInstanceDecalInfo> decalList;

	// Token: 0x04000092 RID: 146
	[Token(Token = "0x4000092")]
	[FieldOffset(Offset = "0x28")]
	[Header("网格设置")]
	public Mesh decalMesh;

	// Token: 0x04000093 RID: 147
	[Token(Token = "0x4000093")]
	[FieldOffset(Offset = "0x30")]
	[Header("相机设置")]
	public Camera targetCamera;

	// Token: 0x04000094 RID: 148
	[Token(Token = "0x4000094")]
	[FieldOffset(Offset = "0x38")]
	[Header("裁剪设置")]
	public bool enableCulling;

	// Token: 0x04000095 RID: 149
	[Token(Token = "0x4000095")]
	[FieldOffset(Offset = "0x3C")]
	public float cullingInterval;

	// Token: 0x04000096 RID: 150
	[Token(Token = "0x4000096")]
	[FieldOffset(Offset = "0x40")]
	[Header("实例化设置")]
	public int maxInstancesPerBatch;

	// Token: 0x04000097 RID: 151
	[Token(Token = "0x4000097")]
	[FieldOffset(Offset = "0x44")]
	public bool castShadows;

	// Token: 0x04000098 RID: 152
	[Token(Token = "0x4000098")]
	[FieldOffset(Offset = "0x45")]
	public bool receiveShadows;

	// Token: 0x04000099 RID: 153
	[Token(Token = "0x4000099")]
	[FieldOffset(Offset = "0x46")]
	[Header("调试")]
	public bool showGizmos;

	// Token: 0x0400009A RID: 154
	[Token(Token = "0x400009A")]
	[FieldOffset(Offset = "0x47")]
	public bool showStatistics;

	// Token: 0x0400009B RID: 155
	[Token(Token = "0x400009B")]
	[FieldOffset(Offset = "0x48")]
	private Dictionary<Material, List<Matrix4x4>> instanceBatches;

	// Token: 0x0400009C RID: 156
	[Token(Token = "0x400009C")]
	[FieldOffset(Offset = "0x50")]
	private Plane[] frustumPlanes;

	// Token: 0x0400009D RID: 157
	[Token(Token = "0x400009D")]
	[FieldOffset(Offset = "0x58")]
	private float lastCullingTime;

	// Token: 0x0400009E RID: 158
	[Token(Token = "0x400009E")]
	[FieldOffset(Offset = "0x5C")]
	private int totalInstances;

	// Token: 0x0400009F RID: 159
	[Token(Token = "0x400009F")]
	[FieldOffset(Offset = "0x60")]
	private int visibleInstances;

	// Token: 0x040000A0 RID: 160
	[Token(Token = "0x40000A0")]
	[FieldOffset(Offset = "0x64")]
	private int drawCalls;

	// Token: 0x040000A1 RID: 161
	[Token(Token = "0x40000A1")]
	[FieldOffset(Offset = "0x68")]
	private Matrix4x4[] cachedMatrixArray;

	// Token: 0x040000A2 RID: 162
	[Token(Token = "0x40000A2")]
	[FieldOffset(Offset = "0x70")]
	private bool supportsInstancing;

	// Token: 0x040000A3 RID: 163
	[Token(Token = "0x40000A3")]
	[FieldOffset(Offset = "0x74")]
	private int curLod;
}
