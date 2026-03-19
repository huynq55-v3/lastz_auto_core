using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Serialization;

namespace EPOOutline
{
	// Token: 0x02000CA2 RID: 3234
	[Token(Token = "0x2000CA2")]
	[Serializable]
	public class OutlineTarget
	{
		// Token: 0x17000B03 RID: 2819
		// (get) Token: 0x06007A95 RID: 31381 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B03")]
		public Renderer Renderer
		{
			[Token(Token = "0x6007A95")]
			[Address(RVA = "0x321AA28", Offset = "0x321AA28", VA = "0x321AA28")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B04 RID: 2820
		// (get) Token: 0x06007A96 RID: 31382 RVA: 0x00053DA8 File Offset: 0x00051FA8
		[Token(Token = "0x17000B04")]
		public bool UsesCutout
		{
			[Token(Token = "0x6007A96")]
			[Address(RVA = "0x321AA30", Offset = "0x321AA30", VA = "0x321AA30")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000B05 RID: 2821
		// (get) Token: 0x06007A97 RID: 31383 RVA: 0x00053DC0 File Offset: 0x00051FC0
		// (set) Token: 0x06007A98 RID: 31384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B05")]
		public int CutoutTextureIndex
		{
			[Token(Token = "0x6007A97")]
			[Address(RVA = "0x321AA50", Offset = "0x321AA50", VA = "0x321AA50")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6007A98")]
			[Address(RVA = "0x321AA58", Offset = "0x321AA58", VA = "0x321AA58")]
			set
			{
			}
		}

		// Token: 0x17000B06 RID: 2822
		// (get) Token: 0x06007A99 RID: 31385 RVA: 0x00053DD8 File Offset: 0x00051FD8
		[Token(Token = "0x17000B06")]
		public int ShiftedSubmeshIndex
		{
			[Token(Token = "0x6007A99")]
			[Address(RVA = "0x321AAD8", Offset = "0x321AAD8", VA = "0x321AAD8")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000B07 RID: 2823
		// (get) Token: 0x06007A9A RID: 31386 RVA: 0x00053DF0 File Offset: 0x00051FF0
		[Token(Token = "0x17000B07")]
		public int CutoutTextureId
		{
			[Token(Token = "0x6007A9A")]
			[Address(RVA = "0x321AAE0", Offset = "0x321AAE0", VA = "0x321AAE0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000B08 RID: 2824
		// (get) Token: 0x06007A9B RID: 31387 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06007A9C RID: 31388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B08")]
		public string CutoutTextureName
		{
			[Token(Token = "0x6007A9B")]
			[Address(RVA = "0x321AB88", Offset = "0x321AB88", VA = "0x321AB88")]
			get
			{
				return null;
			}
			[Token(Token = "0x6007A9C")]
			[Address(RVA = "0x321AB90", Offset = "0x321AB90", VA = "0x321AB90")]
			set
			{
			}
		}

		// Token: 0x17000B09 RID: 2825
		// (get) Token: 0x06007A9D RID: 31389 RVA: 0x00053E08 File Offset: 0x00052008
		// (set) Token: 0x06007A9E RID: 31390 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B09")]
		public float EdgeDilateAmount
		{
			[Token(Token = "0x6007A9D")]
			[Address(RVA = "0x321ABB0", Offset = "0x321ABB0", VA = "0x321ABB0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6007A9E")]
			[Address(RVA = "0x321ABB8", Offset = "0x321ABB8", VA = "0x321ABB8")]
			set
			{
			}
		}

		// Token: 0x17000B0A RID: 2826
		// (get) Token: 0x06007A9F RID: 31391 RVA: 0x00053E20 File Offset: 0x00052020
		// (set) Token: 0x06007AA0 RID: 31392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B0A")]
		public float FrontEdgeDilateAmount
		{
			[Token(Token = "0x6007A9F")]
			[Address(RVA = "0x321ABC8", Offset = "0x321ABC8", VA = "0x321ABC8")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6007AA0")]
			[Address(RVA = "0x321ABD0", Offset = "0x321ABD0", VA = "0x321ABD0")]
			set
			{
			}
		}

		// Token: 0x17000B0B RID: 2827
		// (get) Token: 0x06007AA1 RID: 31393 RVA: 0x00053E38 File Offset: 0x00052038
		// (set) Token: 0x06007AA2 RID: 31394 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B0B")]
		public float BackEdgeDilateAmount
		{
			[Token(Token = "0x6007AA1")]
			[Address(RVA = "0x321ABE0", Offset = "0x321ABE0", VA = "0x321ABE0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6007AA2")]
			[Address(RVA = "0x321ABE8", Offset = "0x321ABE8", VA = "0x321ABE8")]
			set
			{
			}
		}

		// Token: 0x06007AA3 RID: 31395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007AA3")]
		[Address(RVA = "0x321ABF8", Offset = "0x321ABF8", VA = "0x321ABF8")]
		public OutlineTarget()
		{
		}

		// Token: 0x06007AA4 RID: 31396 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007AA4")]
		[Address(RVA = "0x321ACE8", Offset = "0x321ACE8", VA = "0x321ACE8")]
		public OutlineTarget(Renderer renderer, int submesh = 0)
		{
		}

		// Token: 0x06007AA5 RID: 31397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007AA5")]
		[Address(RVA = "0x321AE94", Offset = "0x321AE94", VA = "0x321AE94")]
		public OutlineTarget(Renderer renderer, string cutoutTextureName, float cutoutThreshold = 0.5f)
		{
		}

		// Token: 0x040035E4 RID: 13796
		[Token(Token = "0x40035E4")]
		[FieldOffset(Offset = "0x10")]
		public bool IsVisible;

		// Token: 0x040035E5 RID: 13797
		[Token(Token = "0x40035E5")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		public ColorMask CutoutMask;

		// Token: 0x040035E6 RID: 13798
		[Token(Token = "0x40035E6")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float edgeDilateAmount;

		// Token: 0x040035E7 RID: 13799
		[Token(Token = "0x40035E7")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float frontEdgeDilateAmount;

		// Token: 0x040035E8 RID: 13800
		[Token(Token = "0x40035E8")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float backEdgeDilateAmount;

		// Token: 0x040035E9 RID: 13801
		[Token(Token = "0x40035E9")]
		[FieldOffset(Offset = "0x28")]
		[FormerlySerializedAs("Renderer")]
		[SerializeField]
		public Renderer renderer;

		// Token: 0x040035EA RID: 13802
		[Token(Token = "0x40035EA")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		public int SubmeshIndex;

		// Token: 0x040035EB RID: 13803
		[Token(Token = "0x40035EB")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		public BoundsMode BoundsMode;

		// Token: 0x040035EC RID: 13804
		[Token(Token = "0x40035EC")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		public Bounds Bounds;

		// Token: 0x040035ED RID: 13805
		[Token(Token = "0x40035ED")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Range(0f, 1f)]
		public float CutoutThreshold;

		// Token: 0x040035EE RID: 13806
		[Token(Token = "0x40035EE")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		public CullMode CullMode;

		// Token: 0x040035EF RID: 13807
		[Token(Token = "0x40035EF")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private string cutoutTextureName;

		// Token: 0x040035F0 RID: 13808
		[Token(Token = "0x40035F0")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		public DilateRenderMode DilateRenderingMode;

		// Token: 0x040035F1 RID: 13809
		[Token(Token = "0x40035F1")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		private int cutoutTextureIndex;

		// Token: 0x040035F2 RID: 13810
		[Token(Token = "0x40035F2")]
		[FieldOffset(Offset = "0x68")]
		private int? cutoutTextureId;
	}
}
