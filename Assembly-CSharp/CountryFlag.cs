using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002CC RID: 716
[Token(Token = "0x20002CC")]
public class CountryFlag : MonoBehaviour
{
	// Token: 0x0600128F RID: 4751 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600128F")]
	[Address(RVA = "0x1C5E568", Offset = "0x1C5E568", VA = "0x1C5E568")]
	private void Awake()
	{
	}

	// Token: 0x06001290 RID: 4752 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001290")]
	[Address(RVA = "0x1C5E5AC", Offset = "0x1C5E5AC", VA = "0x1C5E5AC")]
	private void OnDestroy()
	{
	}

	// Token: 0x06001291 RID: 4753 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001291")]
	[Address(RVA = "0x1C5E5B0", Offset = "0x1C5E5B0", VA = "0x1C5E5B0")]
	public void SetCountry(string countryCode)
	{
	}

	// Token: 0x06001292 RID: 4754 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001292")]
	[Address(RVA = "0x1C5E5F4", Offset = "0x1C5E5F4", VA = "0x1C5E5F4")]
	public CountryFlag()
	{
	}

	// Token: 0x04001558 RID: 5464
	[Token(Token = "0x4001558")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private MeshRenderer _meshRenderer;

	// Token: 0x04001559 RID: 5465
	[Token(Token = "0x4001559")]
	[FieldOffset(Offset = "0x20")]
	private Material _mat;

	// Token: 0x0400155A RID: 5466
	[Token(Token = "0x400155A")]
	[FieldOffset(Offset = "0x28")]
	private string countryCode;
}
