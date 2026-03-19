using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020003A4 RID: 932
[Token(Token = "0x20003A4")]
[ExecuteAlways]
public class GetHDRIntensity : MonoBehaviour
{
	// Token: 0x060017A7 RID: 6055 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60017A7")]
	[Address(RVA = "0x1DB7630", Offset = "0x1DB7630", VA = "0x1DB7630")]
	public void Init(Material material)
	{
	}

	// Token: 0x060017A8 RID: 6056 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60017A8")]
	[Address(RVA = "0x1DB76D8", Offset = "0x1DB76D8", VA = "0x1DB76D8")]
	private void Update()
	{
	}

	// Token: 0x060017A9 RID: 6057 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60017A9")]
	[Address(RVA = "0x1DB7780", Offset = "0x1DB7780", VA = "0x1DB7780")]
	private void OnDisable()
	{
	}

	// Token: 0x060017AA RID: 6058 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60017AA")]
	[Address(RVA = "0x1DB7818", Offset = "0x1DB7818", VA = "0x1DB7818")]
	public GetHDRIntensity()
	{
	}

	// Token: 0x04001A54 RID: 6740
	[Token(Token = "0x4001A54")]
	[FieldOffset(Offset = "0x18")]
	private int property;

	// Token: 0x04001A55 RID: 6741
	[Token(Token = "0x4001A55")]
	[FieldOffset(Offset = "0x20")]
	private Material mat;

	// Token: 0x04001A56 RID: 6742
	[Token(Token = "0x4001A56")]
	[FieldOffset(Offset = "0x28")]
	[Range(0f, 10f)]
	public float intensity;

	// Token: 0x04001A57 RID: 6743
	[Token(Token = "0x4001A57")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	public Color color;
}
