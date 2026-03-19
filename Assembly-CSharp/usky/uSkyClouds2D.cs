using System;
using Il2CppDummyDll;
using UnityEngine;

namespace usky
{
	// Token: 0x02000A0C RID: 2572
	[Token(Token = "0x2000A0C")]
	[ExecuteInEditMode]
	[AddComponentMenu("uSkyPro/uSky Clouds 2D")]
	public class uSkyClouds2D : MonoBehaviour
	{
		// Token: 0x0600623A RID: 25146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600623A")]
		[Address(RVA = "0x3031CC0", Offset = "0x3031CC0", VA = "0x3031CC0")]
		private void InitSkyDomeMesh()
		{
		}

		// Token: 0x0600623B RID: 25147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600623B")]
		[Address(RVA = "0x3031D80", Offset = "0x3031D80", VA = "0x3031D80")]
		private void Awake()
		{
		}

		// Token: 0x0600623C RID: 25148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600623C")]
		[Address(RVA = "0x3031DF8", Offset = "0x3031DF8", VA = "0x3031DF8")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600623D RID: 25149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600623D")]
		[Address(RVA = "0x3031EAC", Offset = "0x3031EAC", VA = "0x3031EAC")]
		private void Update()
		{
		}

		// Token: 0x0600623E RID: 25150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600623E")]
		[Address(RVA = "0x3031EB0", Offset = "0x3031EB0", VA = "0x3031EB0")]
		private void OnValidate()
		{
		}

		// Token: 0x0600623F RID: 25151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600623F")]
		[Address(RVA = "0x3031ECC", Offset = "0x3031ECC", VA = "0x3031ECC")]
		public void SetCloundSpeed()
		{
		}

		// Token: 0x06006240 RID: 25152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006240")]
		[Address(RVA = "0x3031F70", Offset = "0x3031F70", VA = "0x3031F70")]
		public void RecoverCloundSpeed()
		{
		}

		// Token: 0x06006241 RID: 25153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006241")]
		[Address(RVA = "0x3032010", Offset = "0x3032010", VA = "0x3032010")]
		public uSkyClouds2D()
		{
		}

		// Token: 0x04002660 RID: 9824
		[Token(Token = "0x4002660")]
		[FieldOffset(Offset = "0x18")]
		public Material Clouds2DMaterial;

		// Token: 0x04002661 RID: 9825
		[Token(Token = "0x4002661")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		public Mesh uCloundMesh;

		// Token: 0x04002662 RID: 9826
		[Token(Token = "0x4002662")]
		[FieldOffset(Offset = "0x28")]
		public int cloudsLayer;

		// Token: 0x04002663 RID: 9827
		[Token(Token = "0x4002663")]
		[FieldOffset(Offset = "0x30")]
		private Mesh m_SkyDome;

		// Token: 0x04002664 RID: 9828
		[Token(Token = "0x4002664")]
		[FieldOffset(Offset = "0x38")]
		private uSkyTimeline skyTimeLine;

		// Token: 0x04002665 RID: 9829
		[Token(Token = "0x4002665")]
		[FieldOffset(Offset = "0x40")]
		private uSkyLighting skyLighting;

		// Token: 0x04002666 RID: 9830
		[Token(Token = "0x4002666")]
		[FieldOffset(Offset = "0x48")]
		private float CloundSpeed;

		// Token: 0x04002667 RID: 9831
		[Token(Token = "0x4002667")]
		[FieldOffset(Offset = "0x4C")]
		public Vector3 pos;
	}
}
