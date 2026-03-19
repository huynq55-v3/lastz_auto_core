using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200008B RID: 139
[Token(Token = "0x200008B")]
public class GhostEffect : MonoBehaviour
{
	// Token: 0x06000358 RID: 856 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000358")]
	[Address(RVA = "0x3212704", Offset = "0x3212704", VA = "0x3212704")]
	public void Ghost()
	{
	}

	// Token: 0x1700008B RID: 139
	// (get) Token: 0x06000359 RID: 857 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700008B")]
	private List<SkinnedMeshRenderer> cachedSkinnedMeshRenderer
	{
		[Token(Token = "0x6000359")]
		[Address(RVA = "0x321355C", Offset = "0x321355C", VA = "0x321355C")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700008C RID: 140
	// (get) Token: 0x0600035A RID: 858 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700008C")]
	private List<MeshFilter> cachedMeshFilterList
	{
		[Token(Token = "0x600035A")]
		[Address(RVA = "0x321361C", Offset = "0x321361C", VA = "0x321361C")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700008D RID: 141
	// (get) Token: 0x0600035B RID: 859 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700008D")]
	private Material ghostMaterial
	{
		[Token(Token = "0x600035B")]
		[Address(RVA = "0x32136DC", Offset = "0x32136DC", VA = "0x32136DC")]
		get
		{
			return null;
		}
	}

	// Token: 0x0600035C RID: 860 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600035C")]
	[Address(RVA = "0x3213818", Offset = "0x3213818", VA = "0x3213818")]
	private void OnEnable()
	{
	}

	// Token: 0x0600035D RID: 861 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600035D")]
	[Address(RVA = "0x3213998", Offset = "0x3213998", VA = "0x3213998")]
	private void OnDisable()
	{
	}

	// Token: 0x0600035E RID: 862 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600035E")]
	[Address(RVA = "0x3213ADC", Offset = "0x3213ADC", VA = "0x3213ADC")]
	private void Update()
	{
	}

	// Token: 0x0600035F RID: 863 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600035F")]
	[Address(RVA = "0x321399C", Offset = "0x321399C", VA = "0x321399C")]
	private void CleanUp()
	{
	}

	// Token: 0x06000360 RID: 864 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000360")]
	[Address(RVA = "0x3213FC4", Offset = "0x3213FC4", VA = "0x3213FC4")]
	private void DestroyGhostShadowObj(GhostEffect.GhostObject obj)
	{
	}

	// Token: 0x06000361 RID: 865 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000361")]
	[Address(RVA = "0x321274C", Offset = "0x321274C", VA = "0x321274C")]
	public void CreateGhostEffectObject(Color color, float fresnelStrength, float fresnelColorStrength, float alpha, float fadeoutTime, float mainTexStrength = 0f)
	{
	}

	// Token: 0x06000362 RID: 866 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000362")]
	[Address(RVA = "0x321413C", Offset = "0x321413C", VA = "0x321413C")]
	public GhostEffect()
	{
	}

	// Token: 0x040002DD RID: 733
	[Token(Token = "0x40002DD")]
	[FieldOffset(Offset = "0x0")]
	private static readonly int m_IdFresnelStrength;

	// Token: 0x040002DE RID: 734
	[Token(Token = "0x40002DE")]
	[FieldOffset(Offset = "0x4")]
	private static readonly int m_IdFresnelColorStrength;

	// Token: 0x040002DF RID: 735
	[Token(Token = "0x40002DF")]
	[FieldOffset(Offset = "0x8")]
	private static readonly int m_IdMainTexStrength;

	// Token: 0x040002E0 RID: 736
	[Token(Token = "0x40002E0")]
	[FieldOffset(Offset = "0xC")]
	private static readonly int m_IdMainTex;

	// Token: 0x040002E1 RID: 737
	[Token(Token = "0x40002E1")]
	[FieldOffset(Offset = "0x10")]
	private static readonly int m_IdAlpha;

	// Token: 0x040002E2 RID: 738
	[Token(Token = "0x40002E2")]
	[FieldOffset(Offset = "0x14")]
	private static readonly int m_IdColor;

	// Token: 0x040002E3 RID: 739
	[Token(Token = "0x40002E3")]
	[FieldOffset(Offset = "0x18")]
	private static int m_DefaultLayer;

	// Token: 0x040002E4 RID: 740
	[Token(Token = "0x40002E4")]
	[FieldOffset(Offset = "0x20")]
	private static MaterialPropertyBlock m_MaterialPropertyBlock;

	// Token: 0x040002E5 RID: 741
	[Token(Token = "0x40002E5")]
	[FieldOffset(Offset = "0x18")]
	private List<GhostEffect.GhostObject> m_GhostShadowList;

	// Token: 0x040002E6 RID: 742
	[Token(Token = "0x40002E6")]
	[FieldOffset(Offset = "0x20")]
	private List<SkinnedMeshRenderer> m_SkinnedMeshRendererList;

	// Token: 0x040002E7 RID: 743
	[Token(Token = "0x40002E7")]
	[FieldOffset(Offset = "0x28")]
	private List<MeshFilter> m_MeshFilterList;

	// Token: 0x040002E8 RID: 744
	[Token(Token = "0x40002E8")]
	[FieldOffset(Offset = "0x30")]
	private Material m_GhostMaterial;

	// Token: 0x0200008C RID: 140
	[Token(Token = "0x200008C")]
	private struct MeshInfo
	{
		// Token: 0x040002E9 RID: 745
		[Token(Token = "0x40002E9")]
		[FieldOffset(Offset = "0x0")]
		public Mesh mesh;

		// Token: 0x040002EA RID: 746
		[Token(Token = "0x40002EA")]
		[FieldOffset(Offset = "0x8")]
		public Matrix4x4 matrix;

		// Token: 0x040002EB RID: 747
		[Token(Token = "0x40002EB")]
		[FieldOffset(Offset = "0x48")]
		public bool isSharedMesh;

		// Token: 0x040002EC RID: 748
		[Token(Token = "0x40002EC")]
		[FieldOffset(Offset = "0x50")]
		public Material material;
	}

	// Token: 0x0200008D RID: 141
	[Token(Token = "0x200008D")]
	private class GhostObject
	{
		// Token: 0x06000364 RID: 868 RVA: 0x000030A8 File Offset: 0x000012A8
		[Token(Token = "0x6000364")]
		[Address(RVA = "0x3213BC0", Offset = "0x3213BC0", VA = "0x3213BC0")]
		public bool Update(Material material)
		{
			return default(bool);
		}

		// Token: 0x06000365 RID: 869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000365")]
		[Address(RVA = "0x32140B4", Offset = "0x32140B4", VA = "0x32140B4")]
		public GhostObject()
		{
		}

		// Token: 0x040002ED RID: 749
		[Token(Token = "0x40002ED")]
		[FieldOffset(Offset = "0x10")]
		public List<GhostEffect.MeshInfo> meshInfoList;

		// Token: 0x040002EE RID: 750
		[Token(Token = "0x40002EE")]
		[FieldOffset(Offset = "0x18")]
		public Color color;

		// Token: 0x040002EF RID: 751
		[Token(Token = "0x40002EF")]
		[FieldOffset(Offset = "0x28")]
		public float fresnelStrength;

		// Token: 0x040002F0 RID: 752
		[Token(Token = "0x40002F0")]
		[FieldOffset(Offset = "0x2C")]
		public float mainTexStrength;

		// Token: 0x040002F1 RID: 753
		[Token(Token = "0x40002F1")]
		[FieldOffset(Offset = "0x30")]
		public float totalTime;

		// Token: 0x040002F2 RID: 754
		[Token(Token = "0x40002F2")]
		[FieldOffset(Offset = "0x34")]
		public float remainingTime;

		// Token: 0x040002F3 RID: 755
		[Token(Token = "0x40002F3")]
		[FieldOffset(Offset = "0x38")]
		public float originFresnelColorStrength;

		// Token: 0x040002F4 RID: 756
		[Token(Token = "0x40002F4")]
		[FieldOffset(Offset = "0x3C")]
		public float originAlpha;

		// Token: 0x040002F5 RID: 757
		[Token(Token = "0x40002F5")]
		[FieldOffset(Offset = "0x40")]
		public float originMainTexStrength;
	}
}
