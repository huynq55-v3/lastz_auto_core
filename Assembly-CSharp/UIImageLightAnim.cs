using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000359 RID: 857
[Token(Token = "0x2000359")]
public class UIImageLightAnim : MonoBehaviour
{
	// Token: 0x06001610 RID: 5648 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001610")]
	[Address(RVA = "0x1EDA40C", Offset = "0x1EDA40C", VA = "0x1EDA40C")]
	private void Awake()
	{
	}

	// Token: 0x06001611 RID: 5649 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001611")]
	[Address(RVA = "0x1EDA418", Offset = "0x1EDA418", VA = "0x1EDA418")]
	private void Start()
	{
	}

	// Token: 0x06001612 RID: 5650 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001612")]
	[Address(RVA = "0x1EDA5A4", Offset = "0x1EDA5A4", VA = "0x1EDA5A4")]
	public void Init(float allTime, float startTime, float endTime)
	{
	}

	// Token: 0x06001613 RID: 5651 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001613")]
	[Address(RVA = "0x1EDA688", Offset = "0x1EDA688", VA = "0x1EDA688")]
	private void Update()
	{
	}

	// Token: 0x06001614 RID: 5652 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001614")]
	[Address(RVA = "0x1EDA4E0", Offset = "0x1EDA4E0", VA = "0x1EDA4E0")]
	private void SetAnim(bool isShow)
	{
	}

	// Token: 0x06001615 RID: 5653 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001615")]
	[Address(RVA = "0x1EDA720", Offset = "0x1EDA720", VA = "0x1EDA720")]
	public UIImageLightAnim()
	{
	}

	// Token: 0x04001931 RID: 6449
	[Token(Token = "0x4001931")]
	[FieldOffset(Offset = "0x18")]
	private float _animAllTime;

	// Token: 0x04001932 RID: 6450
	[Token(Token = "0x4001932")]
	[FieldOffset(Offset = "0x1C")]
	private float _showAnimTime;

	// Token: 0x04001933 RID: 6451
	[Token(Token = "0x4001933")]
	[FieldOffset(Offset = "0x20")]
	private float _hideAnimTime;

	// Token: 0x04001934 RID: 6452
	[Token(Token = "0x4001934")]
	[FieldOffset(Offset = "0x24")]
	private float _time;

	// Token: 0x04001935 RID: 6453
	[Token(Token = "0x4001935")]
	[FieldOffset(Offset = "0x28")]
	private bool _isDoAnim;

	// Token: 0x04001936 RID: 6454
	[Token(Token = "0x4001936")]
	[FieldOffset(Offset = "0x30")]
	private Material _material;

	// Token: 0x04001937 RID: 6455
	[Token(Token = "0x4001937")]
	private const string PlayAnimName = "_Color_time";
}
