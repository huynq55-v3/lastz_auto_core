using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200013B RID: 315
[Token(Token = "0x200013B")]
[ExecuteInEditMode]
[RequireComponent(typeof(CanvasRenderer))]
[RequireComponent(typeof(ParticleSystem))]
public class UIParticleSystem : MaskableGraphic
{
	// Token: 0x1700014B RID: 331
	// (get) Token: 0x06000931 RID: 2353 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700014B")]
	public override Texture mainTexture
	{
		[Token(Token = "0x6000931")]
		[Address(RVA = "0x33B01C4", Offset = "0x33B01C4", VA = "0x33B01C4", Slot = "35")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000932 RID: 2354 RVA: 0x00004EF0 File Offset: 0x000030F0
	[Token(Token = "0x6000932")]
	[Address(RVA = "0x33B0278", Offset = "0x33B0278", VA = "0x33B0278")]
	protected bool Initialize()
	{
		return default(bool);
	}

	// Token: 0x06000933 RID: 2355 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000933")]
	[Address(RVA = "0x33B0738", Offset = "0x33B0738", VA = "0x33B0738", Slot = "4")]
	protected override void Awake()
	{
	}

	// Token: 0x06000934 RID: 2356 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000934")]
	[Address(RVA = "0x33B0770", Offset = "0x33B0770", VA = "0x33B0770", Slot = "44")]
	protected override void OnPopulateMesh(VertexHelper vh)
	{
	}

	// Token: 0x06000935 RID: 2357 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000935")]
	[Address(RVA = "0x33B0F14", Offset = "0x33B0F14", VA = "0x33B0F14")]
	private void Update()
	{
	}

	// Token: 0x06000936 RID: 2358 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000936")]
	[Address(RVA = "0x33B0F7C", Offset = "0x33B0F7C", VA = "0x33B0F7C")]
	public UIParticleSystem()
	{
	}

	// Token: 0x040006DE RID: 1758
	[Token(Token = "0x40006DE")]
	[FieldOffset(Offset = "0xD0")]
	public Texture particleTexture;

	// Token: 0x040006DF RID: 1759
	[Token(Token = "0x40006DF")]
	[FieldOffset(Offset = "0xD8")]
	public Sprite particleSprite;

	// Token: 0x040006E0 RID: 1760
	[Token(Token = "0x40006E0")]
	[FieldOffset(Offset = "0xE0")]
	private Transform _transform;

	// Token: 0x040006E1 RID: 1761
	[Token(Token = "0x40006E1")]
	[FieldOffset(Offset = "0xE8")]
	private ParticleSystem _particleSystem;

	// Token: 0x040006E2 RID: 1762
	[Token(Token = "0x40006E2")]
	[FieldOffset(Offset = "0xF0")]
	private ParticleSystem.Particle[] _particles;

	// Token: 0x040006E3 RID: 1763
	[Token(Token = "0x40006E3")]
	[FieldOffset(Offset = "0xF8")]
	private UIVertex[] _quad;

	// Token: 0x040006E4 RID: 1764
	[Token(Token = "0x40006E4")]
	[FieldOffset(Offset = "0x100")]
	private Vector4 _uv;

	// Token: 0x040006E5 RID: 1765
	[Token(Token = "0x40006E5")]
	[FieldOffset(Offset = "0x110")]
	private ParticleSystem.TextureSheetAnimationModule _textureSheetAnimation;

	// Token: 0x040006E6 RID: 1766
	[Token(Token = "0x40006E6")]
	[FieldOffset(Offset = "0x118")]
	private int _textureSheetAnimationFrames;

	// Token: 0x040006E7 RID: 1767
	[Token(Token = "0x40006E7")]
	[FieldOffset(Offset = "0x11C")]
	private Vector2 _textureSheedAnimationFrameSize;
}
