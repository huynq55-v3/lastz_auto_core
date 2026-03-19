using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000329 RID: 809
[Token(Token = "0x2000329")]
[ExecuteAlways]
[RequireComponent(typeof(Slider))]
public class ArabicSliderMirror : MonoBehaviour
{
	// Token: 0x06001545 RID: 5445 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001545")]
	[Address(RVA = "0x1ECF52C", Offset = "0x1ECF52C", VA = "0x1ECF52C")]
	private void Awake()
	{
	}

	// Token: 0x06001546 RID: 5446 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001546")]
	[Address(RVA = "0x1ECF688", Offset = "0x1ECF688", VA = "0x1ECF688")]
	public ArabicSliderMirror()
	{
	}

	// Token: 0x04001849 RID: 6217
	[Token(Token = "0x4001849")]
	[FieldOffset(Offset = "0x18")]
	public Slider slider;

	// Token: 0x0400184A RID: 6218
	[Token(Token = "0x400184A")]
	[FieldOffset(Offset = "0x20")]
	public bool ArabicAutoRight;
}
