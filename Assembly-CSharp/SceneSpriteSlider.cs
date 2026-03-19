using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002BF RID: 703
[Token(Token = "0x20002BF")]
public class SceneSpriteSlider : MonoBehaviour
{
	// Token: 0x0600122D RID: 4653 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600122D")]
	[Address(RVA = "0x1C5A224", Offset = "0x1C5A224", VA = "0x1C5A224")]
	private void Awake()
	{
	}

	// Token: 0x0600122E RID: 4654 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600122E")]
	[Address(RVA = "0x1C5A460", Offset = "0x1C5A460", VA = "0x1C5A460")]
	public void SetColorType(float type)
	{
	}

	// Token: 0x0600122F RID: 4655 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600122F")]
	[Address(RVA = "0x1C5A4D4", Offset = "0x1C5A4D4", VA = "0x1C5A4D4")]
	public void Init(long maxValue, long curValue)
	{
	}

	// Token: 0x06001230 RID: 4656 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001230")]
	[Address(RVA = "0x1C5A648", Offset = "0x1C5A648", VA = "0x1C5A648")]
	public void SetProgressValue(float value)
	{
	}

	// Token: 0x06001231 RID: 4657 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001231")]
	[Address(RVA = "0x1C5A798", Offset = "0x1C5A798", VA = "0x1C5A798")]
	public SceneSpriteSlider()
	{
	}

	// Token: 0x0400150C RID: 5388
	[Token(Token = "0x400150C")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private SpriteRenderer _renderer;

	// Token: 0x0400150D RID: 5389
	[Token(Token = "0x400150D")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Vector4 _bounds;

	// Token: 0x0400150E RID: 5390
	[Token(Token = "0x400150E")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private float _angle;

	// Token: 0x0400150F RID: 5391
	[Token(Token = "0x400150F")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Sprite sprite;

	// Token: 0x04001510 RID: 5392
	[Token(Token = "0x4001510")]
	[FieldOffset(Offset = "0x40")]
	private bool isSpirteRender;

	// Token: 0x04001511 RID: 5393
	[Token(Token = "0x4001511")]
	[FieldOffset(Offset = "0x48")]
	private MaterialPropertyBlock _propertyBlock;

	// Token: 0x04001512 RID: 5394
	[Token(Token = "0x4001512")]
	[FieldOffset(Offset = "0x50")]
	private MeshRenderer meshRender;

	// Token: 0x04001513 RID: 5395
	[Token(Token = "0x4001513")]
	[FieldOffset(Offset = "0x58")]
	private int int_Progress;

	// Token: 0x04001514 RID: 5396
	[Token(Token = "0x4001514")]
	[FieldOffset(Offset = "0x5C")]
	private int int_ColorType;
}
