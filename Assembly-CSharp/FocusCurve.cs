using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002D2 RID: 722
[Token(Token = "0x20002D2")]
public class FocusCurve : MonoBehaviour
{
	// Token: 0x060012A3 RID: 4771 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012A3")]
	[Address(RVA = "0x1C5F558", Offset = "0x1C5F558", VA = "0x1C5F558")]
	public FocusCurve()
	{
	}

	// Token: 0x04001573 RID: 5491
	[Token(Token = "0x4001573")]
	[FieldOffset(Offset = "0x18")]
	public float camZoom;

	// Token: 0x04001574 RID: 5492
	[Token(Token = "0x4001574")]
	[FieldOffset(Offset = "0x1C")]
	public float camZoomFocusRotation;

	// Token: 0x04001575 RID: 5493
	[Token(Token = "0x4001575")]
	[FieldOffset(Offset = "0x20")]
	public AnimationCurve enterCurve;
}
