using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000270 RID: 624
[Token(Token = "0x2000270")]
public class ChangeSceneCircleSlider : MonoBehaviour
{
	// Token: 0x06001088 RID: 4232 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001088")]
	[Address(RVA = "0x1BEF6B8", Offset = "0x1BEF6B8", VA = "0x1BEF6B8")]
	private void Awake()
	{
	}

	// Token: 0x06001089 RID: 4233 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001089")]
	[Address(RVA = "0x1BEF7E8", Offset = "0x1BEF7E8", VA = "0x1BEF7E8")]
	public void ResetValue()
	{
	}

	// Token: 0x0600108A RID: 4234 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600108A")]
	[Address(RVA = "0x1BEF854", Offset = "0x1BEF854", VA = "0x1BEF854")]
	public void Init(long startTime, long endTime)
	{
	}

	// Token: 0x0600108B RID: 4235 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600108B")]
	[Address(RVA = "0x1BEFA28", Offset = "0x1BEFA28", VA = "0x1BEFA28")]
	private void Update()
	{
	}

	// Token: 0x0600108C RID: 4236 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600108C")]
	[Address(RVA = "0x1BEF92C", Offset = "0x1BEF92C", VA = "0x1BEF92C")]
	private void RefreshValue()
	{
	}

	// Token: 0x0600108D RID: 4237 RVA: 0x00006DF8 File Offset: 0x00004FF8
	[Token(Token = "0x600108D")]
	[Address(RVA = "0x1BEF8DC", Offset = "0x1BEF8DC", VA = "0x1BEF8DC")]
	private int GetRefreshDuring()
	{
		return 0;
	}

	// Token: 0x0600108E RID: 4238 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600108E")]
	[Address(RVA = "0x1BEFA48", Offset = "0x1BEFA48", VA = "0x1BEFA48")]
	public ChangeSceneCircleSlider()
	{
	}

	// Token: 0x04001343 RID: 4931
	[Token(Token = "0x4001343")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private SpriteRenderer _renderer;

	// Token: 0x04001344 RID: 4932
	[Token(Token = "0x4001344")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Vector4 _bounds;

	// Token: 0x04001345 RID: 4933
	[Token(Token = "0x4001345")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private float _angle;

	// Token: 0x04001346 RID: 4934
	[Token(Token = "0x4001346")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Sprite sprite;

	// Token: 0x04001347 RID: 4935
	[Token(Token = "0x4001347")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private bool _invert;

	// Token: 0x04001348 RID: 4936
	[Token(Token = "0x4001348")]
	[FieldOffset(Offset = "0x48")]
	private long _startTime;

	// Token: 0x04001349 RID: 4937
	[Token(Token = "0x4001349")]
	[FieldOffset(Offset = "0x50")]
	private long _endTime;

	// Token: 0x0400134A RID: 4938
	[Token(Token = "0x400134A")]
	[FieldOffset(Offset = "0x58")]
	private MaterialPropertyBlock _propertyBlock;

	// Token: 0x0400134B RID: 4939
	[Token(Token = "0x400134B")]
	[FieldOffset(Offset = "0x60")]
	public int _waitRefresh;

	// Token: 0x0400134C RID: 4940
	[Token(Token = "0x400134C")]
	[FieldOffset(Offset = "0x64")]
	private int _waitCount;

	// Token: 0x0400134D RID: 4941
	[Token(Token = "0x400134D")]
	[FieldOffset(Offset = "0x68")]
	private float _maxTime;
}
