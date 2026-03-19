using System;
using Il2CppDummyDll;

namespace UnityEngine.UI
{
	// Token: 0x02000CB2 RID: 3250
	[Token(Token = "0x2000CB2")]
	[AddComponentMenu("UI/Effects/UGUI_Gradient")]
	public class Gradient : BaseMeshEffect
	{
		// Token: 0x17000B0F RID: 2831
		// (get) Token: 0x06007AE2 RID: 31458 RVA: 0x00053FB8 File Offset: 0x000521B8
		// (set) Token: 0x06007AE3 RID: 31459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B0F")]
		public Blend BlendMode
		{
			[Token(Token = "0x6007AE2")]
			[Address(RVA = "0x321DD00", Offset = "0x321DD00", VA = "0x321DD00")]
			get
			{
				return Blend.Override;
			}
			[Token(Token = "0x6007AE3")]
			[Address(RVA = "0x321DD08", Offset = "0x321DD08", VA = "0x321DD08")]
			set
			{
			}
		}

		// Token: 0x17000B10 RID: 2832
		// (get) Token: 0x06007AE4 RID: 31460 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06007AE5 RID: 31461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B10")]
		public Gradient EffectGradient
		{
			[Token(Token = "0x6007AE4")]
			[Address(RVA = "0x321DD10", Offset = "0x321DD10", VA = "0x321DD10")]
			get
			{
				return null;
			}
			[Token(Token = "0x6007AE5")]
			[Address(RVA = "0x321DD18", Offset = "0x321DD18", VA = "0x321DD18")]
			set
			{
			}
		}

		// Token: 0x17000B11 RID: 2833
		// (get) Token: 0x06007AE6 RID: 31462 RVA: 0x00053FD0 File Offset: 0x000521D0
		// (set) Token: 0x06007AE7 RID: 31463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B11")]
		public GradientType GradientType
		{
			[Token(Token = "0x6007AE6")]
			[Address(RVA = "0x321DD20", Offset = "0x321DD20", VA = "0x321DD20")]
			get
			{
				return GradientType.Horizontal;
			}
			[Token(Token = "0x6007AE7")]
			[Address(RVA = "0x321DD28", Offset = "0x321DD28", VA = "0x321DD28")]
			set
			{
			}
		}

		// Token: 0x17000B12 RID: 2834
		// (get) Token: 0x06007AE8 RID: 31464 RVA: 0x00053FE8 File Offset: 0x000521E8
		// (set) Token: 0x06007AE9 RID: 31465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B12")]
		public float Offset
		{
			[Token(Token = "0x6007AE8")]
			[Address(RVA = "0x321DD30", Offset = "0x321DD30", VA = "0x321DD30")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6007AE9")]
			[Address(RVA = "0x321DD38", Offset = "0x321DD38", VA = "0x321DD38")]
			set
			{
			}
		}

		// Token: 0x06007AEA RID: 31466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007AEA")]
		[Address(RVA = "0x321DD40", Offset = "0x321DD40", VA = "0x321DD40", Slot = "20")]
		public override void ModifyMesh(VertexHelper helper)
		{
		}

		// Token: 0x06007AEB RID: 31467 RVA: 0x00054000 File Offset: 0x00052200
		[Token(Token = "0x6007AEB")]
		[Address(RVA = "0x321E6D8", Offset = "0x321E6D8", VA = "0x321E6D8")]
		private Color BlendColor(Color colorA, Color colorB)
		{
			return default(Color);
		}

		// Token: 0x06007AEC RID: 31468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007AEC")]
		[Address(RVA = "0x321E724", Offset = "0x321E724", VA = "0x321E724")]
		public Gradient()
		{
		}

		// Token: 0x0400361C RID: 13852
		[Token(Token = "0x400361C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GradientType _gradientType;

		// Token: 0x0400361D RID: 13853
		[Token(Token = "0x400361D")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private Blend _blendMode;

		// Token: 0x0400361E RID: 13854
		[Token(Token = "0x400361E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Range(-1f, 1f)]
		private float _offset;

		// Token: 0x0400361F RID: 13855
		[Token(Token = "0x400361F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Gradient _effectGradient;
	}
}
