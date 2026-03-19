using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200035E RID: 862
[Token(Token = "0x200035E")]
[RequireComponent(typeof(RectTransform))]
public class UITopUnlit : MonoBehaviour
{
	// Token: 0x06001625 RID: 5669 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001625")]
	[Address(RVA = "0x1EDC13C", Offset = "0x1EDC13C", VA = "0x1EDC13C")]
	private void FindRectMask()
	{
	}

	// Token: 0x06001626 RID: 5670 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001626")]
	[Address(RVA = "0x1EDC16C", Offset = "0x1EDC16C", VA = "0x1EDC16C")]
	private UITopController FindRectMaskInParent(Transform current)
	{
		return null;
	}

	// Token: 0x06001627 RID: 5671 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001627")]
	[Address(RVA = "0x1EDC248", Offset = "0x1EDC248", VA = "0x1EDC248")]
	private void Start()
	{
	}

	// Token: 0x06001628 RID: 5672 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001628")]
	[Address(RVA = "0x1EDC2D8", Offset = "0x1EDC2D8", VA = "0x1EDC2D8")]
	private void Show()
	{
	}

	// Token: 0x06001629 RID: 5673 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001629")]
	[Address(RVA = "0x1EDC35C", Offset = "0x1EDC35C", VA = "0x1EDC35C")]
	private void Update()
	{
	}

	// Token: 0x0600162A RID: 5674 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600162A")]
	[Address(RVA = "0x1EDC404", Offset = "0x1EDC404", VA = "0x1EDC404")]
	private void Hide()
	{
	}

	// Token: 0x0600162B RID: 5675 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600162B")]
	[Address(RVA = "0x1EDC408", Offset = "0x1EDC408", VA = "0x1EDC408")]
	public UITopUnlit()
	{
	}

	// Token: 0x04001951 RID: 6481
	[Token(Token = "0x4001951")]
	[FieldOffset(Offset = "0x18")]
	private UITopController topController;

	// Token: 0x04001952 RID: 6482
	[Token(Token = "0x4001952")]
	[FieldOffset(Offset = "0x20")]
	private RectTransform m_rect;

	// Token: 0x04001953 RID: 6483
	[Token(Token = "0x4001953")]
	[FieldOffset(Offset = "0x28")]
	private Transform parent;

	// Token: 0x04001954 RID: 6484
	[Token(Token = "0x4001954")]
	[FieldOffset(Offset = "0x30")]
	private UITopUnlit.Status status;

	// Token: 0x0200035F RID: 863
	[Token(Token = "0x200035F")]
	private enum Status
	{
		// Token: 0x04001956 RID: 6486
		[Token(Token = "0x4001956")]
		None,
		// Token: 0x04001957 RID: 6487
		[Token(Token = "0x4001957")]
		FindComponent,
		// Token: 0x04001958 RID: 6488
		[Token(Token = "0x4001958")]
		Register,
		// Token: 0x04001959 RID: 6489
		[Token(Token = "0x4001959")]
		Finish
	}
}
