using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000366 RID: 870
[Token(Token = "0x2000366")]
public class AutoAdjustScreenPos : MonoBehaviour
{
	// Token: 0x06001650 RID: 5712 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001650")]
	[Address(RVA = "0x1EDDE70", Offset = "0x1EDDE70", VA = "0x1EDDE70")]
	private void Awake()
	{
	}

	// Token: 0x06001651 RID: 5713 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001651")]
	[Address(RVA = "0x1EDDED4", Offset = "0x1EDDED4", VA = "0x1EDDED4")]
	public void Init(Vector3 pos)
	{
	}

	// Token: 0x06001652 RID: 5714 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001652")]
	[Address(RVA = "0x1EDE16C", Offset = "0x1EDE16C", VA = "0x1EDE16C")]
	public void Init(Transform obj, Vector3 deltaPos)
	{
	}

	// Token: 0x06001653 RID: 5715 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001653")]
	[Address(RVA = "0x1EDDEE0", Offset = "0x1EDDEE0", VA = "0x1EDDEE0")]
	private void RefreshPos()
	{
	}

	// Token: 0x06001654 RID: 5716 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001654")]
	[Address(RVA = "0x1EDE1AC", Offset = "0x1EDE1AC", VA = "0x1EDE1AC")]
	private void OnEnable()
	{
	}

	// Token: 0x06001655 RID: 5717 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001655")]
	[Address(RVA = "0x1EDE31C", Offset = "0x1EDE31C", VA = "0x1EDE31C")]
	private void OnDisable()
	{
	}

	// Token: 0x06001656 RID: 5718 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001656")]
	[Address(RVA = "0x1EDE48C", Offset = "0x1EDE48C", VA = "0x1EDE48C")]
	public AutoAdjustScreenPos()
	{
	}

	// Token: 0x04001972 RID: 6514
	[Token(Token = "0x4001972")]
	[FieldOffset(Offset = "0x18")]
	private Vector3 _worldPos;

	// Token: 0x04001973 RID: 6515
	[Token(Token = "0x4001973")]
	[FieldOffset(Offset = "0x24")]
	private Vector3 _screenPos;

	// Token: 0x04001974 RID: 6516
	[Token(Token = "0x4001974")]
	[FieldOffset(Offset = "0x30")]
	private Transform _obj;

	// Token: 0x04001975 RID: 6517
	[Token(Token = "0x4001975")]
	[FieldOffset(Offset = "0x38")]
	private Vector3 _deltaPos;

	// Token: 0x04001976 RID: 6518
	[Token(Token = "0x4001976")]
	[FieldOffset(Offset = "0x44")]
	public bool debug;
}
