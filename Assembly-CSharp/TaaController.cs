using System;
using GameOldBoy.Rendering;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering.Universal;

// Token: 0x0200005D RID: 93
[Token(Token = "0x200005D")]
public class TaaController : MonoBehaviour
{
	// Token: 0x1700005A RID: 90
	// (get) Token: 0x06000216 RID: 534 RVA: 0x00002C28 File Offset: 0x00000E28
	// (set) Token: 0x06000217 RID: 535 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700005A")]
	private float Blend
	{
		[Token(Token = "0x6000216")]
		[Address(RVA = "0x3203370", Offset = "0x3203370", VA = "0x3203370")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6000217")]
		[Address(RVA = "0x3203388", Offset = "0x3203388", VA = "0x3203388")]
		set
		{
		}
	}

	// Token: 0x1700005B RID: 91
	// (get) Token: 0x06000218 RID: 536 RVA: 0x00002C40 File Offset: 0x00000E40
	// (set) Token: 0x06000219 RID: 537 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700005B")]
	private float RenderScale
	{
		[Token(Token = "0x6000218")]
		[Address(RVA = "0x32033B4", Offset = "0x32033B4", VA = "0x32033B4")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6000219")]
		[Address(RVA = "0x32033C8", Offset = "0x32033C8", VA = "0x32033C8")]
		set
		{
		}
	}

	// Token: 0x0600021A RID: 538 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600021A")]
	[Address(RVA = "0x32033F0", Offset = "0x32033F0", VA = "0x32033F0")]
	private void Start()
	{
	}

	// Token: 0x0600021B RID: 539 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600021B")]
	[Address(RVA = "0x3203520", Offset = "0x3203520", VA = "0x3203520")]
	public TaaController()
	{
	}

	// Token: 0x040001D8 RID: 472
	[Token(Token = "0x40001D8")]
	[FieldOffset(Offset = "0x18")]
	private TAAComponent taa;

	// Token: 0x040001D9 RID: 473
	[Token(Token = "0x40001D9")]
	[FieldOffset(Offset = "0x20")]
	private bool taaEnabled;

	// Token: 0x040001DA RID: 474
	[Token(Token = "0x40001DA")]
	[FieldOffset(Offset = "0x24")]
	private int blend;

	// Token: 0x040001DB RID: 475
	[Token(Token = "0x40001DB")]
	[FieldOffset(Offset = "0x28")]
	private bool antiGhosting;

	// Token: 0x040001DC RID: 476
	[Token(Token = "0x40001DC")]
	[FieldOffset(Offset = "0x29")]
	private bool vSync;

	// Token: 0x040001DD RID: 477
	[Token(Token = "0x40001DD")]
	[FieldOffset(Offset = "0x2C")]
	private int frameCount;

	// Token: 0x040001DE RID: 478
	[Token(Token = "0x40001DE")]
	[FieldOffset(Offset = "0x30")]
	private float timer;

	// Token: 0x040001DF RID: 479
	[Token(Token = "0x40001DF")]
	[FieldOffset(Offset = "0x34")]
	private int fps;

	// Token: 0x040001E0 RID: 480
	[Token(Token = "0x40001E0")]
	[FieldOffset(Offset = "0x38")]
	private UniversalRenderPipelineAsset renderPipelineAsset;

	// Token: 0x040001E1 RID: 481
	[Token(Token = "0x40001E1")]
	[FieldOffset(Offset = "0x40")]
	private int renderScale;

	// Token: 0x040001E2 RID: 482
	[Token(Token = "0x40001E2")]
	[FieldOffset(Offset = "0x44")]
	public float m_RenderScale;
}
