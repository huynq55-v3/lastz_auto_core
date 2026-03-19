using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002C0 RID: 704
[Token(Token = "0x20002C0")]
public class ShaderWhiteEffect : MonoBehaviour
{
	// Token: 0x06001232 RID: 4658 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001232")]
	[Address(RVA = "0x1C5A830", Offset = "0x1C5A830", VA = "0x1C5A830")]
	private void Start()
	{
	}

	// Token: 0x06001233 RID: 4659 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001233")]
	[Address(RVA = "0x1C5A8B4", Offset = "0x1C5A8B4", VA = "0x1C5A8B4")]
	public void PlayEffect()
	{
	}

	// Token: 0x06001234 RID: 4660 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001234")]
	[Address(RVA = "0x1C5A9DC", Offset = "0x1C5A9DC", VA = "0x1C5A9DC")]
	private void Update()
	{
	}

	// Token: 0x06001235 RID: 4661 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001235")]
	[Address(RVA = "0x1C5AB5C", Offset = "0x1C5AB5C", VA = "0x1C5AB5C")]
	private void ChangeEffect()
	{
	}

	// Token: 0x06001236 RID: 4662 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001236")]
	[Address(RVA = "0x1C5ABC8", Offset = "0x1C5ABC8", VA = "0x1C5ABC8")]
	public ShaderWhiteEffect()
	{
	}

	// Token: 0x04001515 RID: 5397
	[Token(Token = "0x4001515")]
	[FieldOffset(Offset = "0x0")]
	public static float ShakeWhiteEffectChangeTime;

	// Token: 0x04001516 RID: 5398
	[Token(Token = "0x4001516")]
	[FieldOffset(Offset = "0x4")]
	public static float ShakeWhiteEffectStayTime;

	// Token: 0x04001517 RID: 5399
	[Token(Token = "0x4001517")]
	[FieldOffset(Offset = "0x8")]
	public static float ShakeWhiteEffectMinValue;

	// Token: 0x04001518 RID: 5400
	[Token(Token = "0x4001518")]
	[FieldOffset(Offset = "0xC")]
	public static float ShakeWhiteEffectMaxValue;

	// Token: 0x04001519 RID: 5401
	[Token(Token = "0x4001519")]
	[FieldOffset(Offset = "0x18")]
	private int _toggleFlashId;

	// Token: 0x0400151A RID: 5402
	[Token(Token = "0x400151A")]
	[FieldOffset(Offset = "0x20")]
	private MaterialPropertyBlock _propertyBlock;

	// Token: 0x0400151B RID: 5403
	[Token(Token = "0x400151B")]
	[FieldOffset(Offset = "0x28")]
	private Renderer[] _renderers;

	// Token: 0x0400151C RID: 5404
	[Token(Token = "0x400151C")]
	[FieldOffset(Offset = "0x30")]
	private int _length;

	// Token: 0x0400151D RID: 5405
	[Token(Token = "0x400151D")]
	[FieldOffset(Offset = "0x34")]
	private float _time;

	// Token: 0x0400151E RID: 5406
	[Token(Token = "0x400151E")]
	[FieldOffset(Offset = "0x38")]
	private bool _play;

	// Token: 0x0400151F RID: 5407
	[Token(Token = "0x400151F")]
	[FieldOffset(Offset = "0x3C")]
	private float _addTime;

	// Token: 0x04001520 RID: 5408
	[Token(Token = "0x4001520")]
	[FieldOffset(Offset = "0x40")]
	private float _desTime;

	// Token: 0x04001521 RID: 5409
	[Token(Token = "0x4001521")]
	[FieldOffset(Offset = "0x44")]
	private float _allTime;

	// Token: 0x04001522 RID: 5410
	[Token(Token = "0x4001522")]
	[FieldOffset(Offset = "0x48")]
	private float _changeValue;
}
