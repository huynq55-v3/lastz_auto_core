using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000132 RID: 306
[Token(Token = "0x2000132")]
public class UIBoxColliderSize : MonoBehaviour
{
	// Token: 0x060008E5 RID: 2277 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008E5")]
	[Address(RVA = "0x33AC13C", Offset = "0x33AC13C", VA = "0x33AC13C")]
	private void LateUpdate()
	{
	}

	// Token: 0x060008E6 RID: 2278 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008E6")]
	[Address(RVA = "0x33AC290", Offset = "0x33AC290", VA = "0x33AC290")]
	public UIBoxColliderSize()
	{
	}

	// Token: 0x040006A9 RID: 1705
	[Token(Token = "0x40006A9")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private RectTransform rectTransform;

	// Token: 0x040006AA RID: 1706
	[Token(Token = "0x40006AA")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private BoxCollider2D boxCollider2D;

	// Token: 0x040006AB RID: 1707
	[Token(Token = "0x40006AB")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private bool isUpdateSize;
}
