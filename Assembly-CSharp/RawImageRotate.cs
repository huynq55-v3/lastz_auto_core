using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020003A8 RID: 936
[Token(Token = "0x20003A8")]
public class RawImageRotate : MonoBehaviour
{
	// Token: 0x060017AE RID: 6062 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60017AE")]
	[Address(RVA = "0x1DB7910", Offset = "0x1DB7910", VA = "0x1DB7910")]
	private void Update()
	{
	}

	// Token: 0x060017AF RID: 6063 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60017AF")]
	[Address(RVA = "0x1DB79F4", Offset = "0x1DB79F4", VA = "0x1DB79F4")]
	public RawImageRotate()
	{
	}

	// Token: 0x04001A5D RID: 6749
	[Token(Token = "0x4001A5D")]
	[FieldOffset(Offset = "0x18")]
	public RawImage rawImage;

	// Token: 0x04001A5E RID: 6750
	[Token(Token = "0x4001A5E")]
	[FieldOffset(Offset = "0x20")]
	public Transform model;

	// Token: 0x04001A5F RID: 6751
	[Token(Token = "0x4001A5F")]
	[FieldOffset(Offset = "0x28")]
	private Vector2 previousTouchPos;

	// Token: 0x04001A60 RID: 6752
	[Token(Token = "0x4001A60")]
	[FieldOffset(Offset = "0x30")]
	private bool isDragging;
}
