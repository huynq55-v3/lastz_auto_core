using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

namespace VolumetricFogAndMist2
{
	// Token: 0x02000A01 RID: 2561
	[Token(Token = "0x2000A01")]
	[ExecuteInEditMode]
	public class VolumetricFog : MonoBehaviour
	{
		// Token: 0x17000642 RID: 1602
		// (get) Token: 0x060061EE RID: 25070 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000642")]
		public static VolumetricFog Instance
		{
			[Token(Token = "0x60061EE")]
			[Address(RVA = "0x1417C34", Offset = "0x1417C34", VA = "0x1417C34")]
			get
			{
				return null;
			}
		}

		// Token: 0x060061EF RID: 25071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061EF")]
		[Address(RVA = "0x1417C8C", Offset = "0x1417C8C", VA = "0x1417C8C")]
		private void Awake()
		{
		}

		// Token: 0x060061F0 RID: 25072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061F0")]
		[Address(RVA = "0x1417CEC", Offset = "0x1417CEC", VA = "0x1417CEC")]
		private void Start()
		{
		}

		// Token: 0x060061F1 RID: 25073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061F1")]
		[Address(RVA = "0x1417CF0", Offset = "0x1417CF0", VA = "0x1417CF0")]
		private void OnDisable()
		{
		}

		// Token: 0x060061F2 RID: 25074 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061F2")]
		[Address(RVA = "0x1417E28", Offset = "0x1417E28", VA = "0x1417E28")]
		private void OnEnable()
		{
		}

		// Token: 0x060061F3 RID: 25075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061F3")]
		[Address(RVA = "0x1417D9C", Offset = "0x1417D9C", VA = "0x1417D9C")]
		private void Clear()
		{
		}

		// Token: 0x060061F4 RID: 25076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061F4")]
		[Address(RVA = "0x1417ECC", Offset = "0x1417ECC", VA = "0x1417ECC")]
		private void RenderObjecst(ScriptableRenderContext context, Camera cam)
		{
		}

		// Token: 0x060061F5 RID: 25077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061F5")]
		[Address(RVA = "0x1418620", Offset = "0x1418620", VA = "0x1418620")]
		private void OnDestroy()
		{
		}

		// Token: 0x060061F6 RID: 25078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061F6")]
		[Address(RVA = "0x14186F4", Offset = "0x14186F4", VA = "0x14186F4")]
		public VolumetricFog()
		{
		}

		// Token: 0x04002628 RID: 9768
		[Token(Token = "0x4002628")]
		[FieldOffset(Offset = "0x18")]
		private readonly int _FogOfWar;

		// Token: 0x04002629 RID: 9769
		[Token(Token = "0x4002629")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int m_Params;

		// Token: 0x0400262A RID: 9770
		[Token(Token = "0x400262A")]
		[FieldOffset(Offset = "0x20")]
		private FowSystem2 fogSystem;

		// Token: 0x0400262B RID: 9771
		[Token(Token = "0x400262B")]
		private const string tag = "FogVolumn";

		// Token: 0x0400262C RID: 9772
		[Token(Token = "0x400262C")]
		[FieldOffset(Offset = "0x8")]
		private static VolumetricFog instance;

		// Token: 0x0400262D RID: 9773
		[Token(Token = "0x400262D")]
		[FieldOffset(Offset = "0x28")]
		private int rtA;

		// Token: 0x0400262E RID: 9774
		[Token(Token = "0x400262E")]
		[FieldOffset(Offset = "0x2C")]
		private int rtB;

		// Token: 0x0400262F RID: 9775
		[Token(Token = "0x400262F")]
		[FieldOffset(Offset = "0x30")]
		private int BlurSize;

		// Token: 0x04002630 RID: 9776
		[Token(Token = "0x4002630")]
		[FieldOffset(Offset = "0x34")]
		private int blurTexture;

		// Token: 0x04002631 RID: 9777
		[Token(Token = "0x4002631")]
		[FieldOffset(Offset = "0x38")]
		private Material mat;

		// Token: 0x04002632 RID: 9778
		[Token(Token = "0x4002632")]
		[FieldOffset(Offset = "0x40")]
		private int blurIterations;

		// Token: 0x04002633 RID: 9779
		[Token(Token = "0x4002633")]
		[FieldOffset(Offset = "0x48")]
		private RenderTexture m_BlurReflectionTexture;
	}
}
