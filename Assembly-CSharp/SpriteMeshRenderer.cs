using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000A0 RID: 160
[Token(Token = "0x20000A0")]
[RequireComponent(typeof(MeshFilter), typeof(MeshRenderer))]
public class SpriteMeshRenderer : MonoBehaviour
{
	// Token: 0x17000090 RID: 144
	// (get) Token: 0x060003B6 RID: 950 RVA: 0x000031C8 File Offset: 0x000013C8
	[Token(Token = "0x17000090")]
	public int sortingLayerID
	{
		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x32178D8", Offset = "0x32178D8", VA = "0x32178D8")]
		get
		{
			return 0;
		}
	}

	// Token: 0x17000091 RID: 145
	// (get) Token: 0x060003B7 RID: 951 RVA: 0x000031E0 File Offset: 0x000013E0
	[Token(Token = "0x17000091")]
	public int sortingOrder
	{
		[Token(Token = "0x60003B7")]
		[Address(RVA = "0x32178E0", Offset = "0x32178E0", VA = "0x32178E0")]
		get
		{
			return 0;
		}
	}

	// Token: 0x17000092 RID: 146
	// (get) Token: 0x060003B8 RID: 952 RVA: 0x000031F8 File Offset: 0x000013F8
	// (set) Token: 0x060003B9 RID: 953 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000092")]
	public Color color
	{
		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x32178E8", Offset = "0x32178E8", VA = "0x32178E8")]
		get
		{
			return default(Color);
		}
		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x32178F4", Offset = "0x32178F4", VA = "0x32178F4")]
		set
		{
		}
	}

	// Token: 0x17000093 RID: 147
	// (get) Token: 0x060003BA RID: 954 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060003BB RID: 955 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000093")]
	public Sprite sprite
	{
		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x32179E4", Offset = "0x32179E4", VA = "0x32179E4")]
		get
		{
			return null;
		}
		[Token(Token = "0x60003BB")]
		[Address(RVA = "0x32179EC", Offset = "0x32179EC", VA = "0x32179EC")]
		set
		{
		}
	}

	// Token: 0x060003BC RID: 956 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003BC")]
	[Address(RVA = "0x3217E80", Offset = "0x3217E80", VA = "0x3217E80")]
	private void Awake()
	{
	}

	// Token: 0x060003BD RID: 957 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003BD")]
	[Address(RVA = "0x321811C", Offset = "0x321811C", VA = "0x321811C")]
	private void OnDestroy()
	{
	}

	// Token: 0x060003BE RID: 958 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003BE")]
	[Address(RVA = "0x3217CF0", Offset = "0x3217CF0", VA = "0x3217CF0")]
	private static Mesh GetMesh(Sprite sprite)
	{
		return null;
	}

	// Token: 0x060003BF RID: 959 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003BF")]
	[Address(RVA = "0x32181B4", Offset = "0x32181B4", VA = "0x32181B4")]
	private static Mesh SpriteToMesh(Sprite sprite)
	{
		return null;
	}

	// Token: 0x060003C0 RID: 960 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003C0")]
	[Address(RVA = "0x3217BA4", Offset = "0x3217BA4", VA = "0x3217BA4")]
	private static void ReleaseMesh(Sprite sprite)
	{
	}

	// Token: 0x060003C1 RID: 961 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003C1")]
	[Address(RVA = "0x3218470", Offset = "0x3218470", VA = "0x3218470")]
	public SpriteMeshRenderer()
	{
	}

	// Token: 0x04000354 RID: 852
	[Token(Token = "0x4000354")]
	[FieldOffset(Offset = "0x0")]
	private static readonly int Prop_MainTex;

	// Token: 0x04000355 RID: 853
	[Token(Token = "0x4000355")]
	[FieldOffset(Offset = "0x4")]
	private static readonly int Prop_Color;

	// Token: 0x04000356 RID: 854
	[Token(Token = "0x4000356")]
	[FieldOffset(Offset = "0x8")]
	private static Dictionary<Sprite, SpriteMeshRenderer.MeshReference> _meshes;

	// Token: 0x04000357 RID: 855
	[Token(Token = "0x4000357")]
	[FieldOffset(Offset = "0x18")]
	private MeshFilter _meshFilter;

	// Token: 0x04000358 RID: 856
	[Token(Token = "0x4000358")]
	[FieldOffset(Offset = "0x20")]
	private MeshRenderer _meshRenderer;

	// Token: 0x04000359 RID: 857
	[Token(Token = "0x4000359")]
	[FieldOffset(Offset = "0x28")]
	private Material _material;

	// Token: 0x0400035A RID: 858
	[Token(Token = "0x400035A")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Material _sharedMaterial;

	// Token: 0x0400035B RID: 859
	[Token(Token = "0x400035B")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Sprite _sprite;

	// Token: 0x0400035C RID: 860
	[Token(Token = "0x400035C")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private int _sortingLayerID;

	// Token: 0x0400035D RID: 861
	[Token(Token = "0x400035D")]
	[FieldOffset(Offset = "0x44")]
	[SerializeField]
	private int _sortingOrder;

	// Token: 0x0400035E RID: 862
	[Token(Token = "0x400035E")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private Color _color;

	// Token: 0x0400035F RID: 863
	[Token(Token = "0x400035F")]
	[FieldOffset(Offset = "0x58")]
	private bool _hasAwake;

	// Token: 0x020000A1 RID: 161
	[Token(Token = "0x20000A1")]
	private class MeshReference
	{
		// Token: 0x060003C3 RID: 963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003C3")]
		[Address(RVA = "0x2F66BF8", Offset = "0x2F66BF8", VA = "0x2F66BF8")]
		public MeshReference()
		{
		}

		// Token: 0x04000360 RID: 864
		[Token(Token = "0x4000360")]
		[FieldOffset(Offset = "0x10")]
		public Mesh mesh;

		// Token: 0x04000361 RID: 865
		[Token(Token = "0x4000361")]
		[FieldOffset(Offset = "0x18")]
		public int refCount;
	}
}
