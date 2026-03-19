using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200035C RID: 860
[Token(Token = "0x200035C")]
[RequireComponent(typeof(RectTransform))]
public class UITopController : MonoBehaviour
{
	// Token: 0x0600161E RID: 5662 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600161E")]
	[Address(RVA = "0x1EDB504", Offset = "0x1EDB504", VA = "0x1EDB504")]
	public void BringToTop(RectTransform target)
	{
	}

	// Token: 0x0600161F RID: 5663 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600161F")]
	[Address(RVA = "0x1EDB9D8", Offset = "0x1EDB9D8", VA = "0x1EDB9D8")]
	private void LateUpdate()
	{
	}

	// Token: 0x06001620 RID: 5664 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001620")]
	[Address(RVA = "0x1EDBE9C", Offset = "0x1EDBE9C", VA = "0x1EDBE9C")]
	public void Restore(RectTransform target)
	{
	}

	// Token: 0x06001621 RID: 5665 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001621")]
	[Address(RVA = "0x1EDBFD4", Offset = "0x1EDBFD4", VA = "0x1EDBFD4")]
	public void StopFollow(RectTransform target)
	{
	}

	// Token: 0x06001622 RID: 5666 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001622")]
	[Address(RVA = "0x1EDC064", Offset = "0x1EDC064", VA = "0x1EDC064")]
	private void OnDestroy()
	{
	}

	// Token: 0x06001623 RID: 5667 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001623")]
	[Address(RVA = "0x1EDC0B4", Offset = "0x1EDC0B4", VA = "0x1EDC0B4")]
	public UITopController()
	{
	}

	// Token: 0x04001946 RID: 6470
	[Token(Token = "0x4001946")]
	[FieldOffset(Offset = "0x18")]
	private RectTransform topRoot;

	// Token: 0x04001947 RID: 6471
	[Token(Token = "0x4001947")]
	[FieldOffset(Offset = "0x20")]
	private Dictionary<RectTransform, UITopController.FollowInfo> _follows;

	// Token: 0x0200035D RID: 861
	[Token(Token = "0x200035D")]
	private class FollowInfo
	{
		// Token: 0x06001624 RID: 5668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001624")]
		[Address(RVA = "0x1EDB9D0", Offset = "0x1EDB9D0", VA = "0x1EDB9D0")]
		public FollowInfo()
		{
		}

		// Token: 0x04001948 RID: 6472
		[Token(Token = "0x4001948")]
		[FieldOffset(Offset = "0x10")]
		public RectTransform target;

		// Token: 0x04001949 RID: 6473
		[Token(Token = "0x4001949")]
		[FieldOffset(Offset = "0x18")]
		public RectTransform motionParent;

		// Token: 0x0400194A RID: 6474
		[Token(Token = "0x400194A")]
		[FieldOffset(Offset = "0x20")]
		public Vector3 parentPosition;

		// Token: 0x0400194B RID: 6475
		[Token(Token = "0x400194B")]
		[FieldOffset(Offset = "0x2C")]
		public Quaternion parentRotation;

		// Token: 0x0400194C RID: 6476
		[Token(Token = "0x400194C")]
		[FieldOffset(Offset = "0x3C")]
		public Vector3 parentScale;

		// Token: 0x0400194D RID: 6477
		[Token(Token = "0x400194D")]
		[FieldOffset(Offset = "0x48")]
		public Vector3 localPosInParent;

		// Token: 0x0400194E RID: 6478
		[Token(Token = "0x400194E")]
		[FieldOffset(Offset = "0x54")]
		public Quaternion localRotInParent;

		// Token: 0x0400194F RID: 6479
		[Token(Token = "0x400194F")]
		[FieldOffset(Offset = "0x64")]
		public Vector3 localScale;

		// Token: 0x04001950 RID: 6480
		[Token(Token = "0x4001950")]
		[FieldOffset(Offset = "0x70")]
		public bool originalActive;
	}
}
