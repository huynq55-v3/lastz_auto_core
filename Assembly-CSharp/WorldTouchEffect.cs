using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000316 RID: 790
[Token(Token = "0x2000316")]
public class WorldTouchEffect : MonoBehaviour
{
	// Token: 0x060014EE RID: 5358 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014EE")]
	[Address(RVA = "0x198D690", Offset = "0x198D690", VA = "0x198D690")]
	public void FadeIn()
	{
	}

	// Token: 0x060014EF RID: 5359 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60014EF")]
	[Address(RVA = "0x198D6E4", Offset = "0x198D6E4", VA = "0x198D6E4")]
	private IEnumerator CoFadeIn()
	{
		return null;
	}

	// Token: 0x060014F0 RID: 5360 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014F0")]
	[Address(RVA = "0x198D780", Offset = "0x198D780", VA = "0x198D780")]
	public WorldTouchEffect()
	{
	}

	// Token: 0x040017CC RID: 6092
	[Token(Token = "0x40017CC")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private MeshRenderer renderer;

	// Token: 0x040017CD RID: 6093
	[Token(Token = "0x40017CD")]
	[FieldOffset(Offset = "0x20")]
	private Coroutine co;
}
