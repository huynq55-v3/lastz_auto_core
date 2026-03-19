using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x020002B1 RID: 689
[Token(Token = "0x20002B1")]
[ExecuteAlways]
public class RenderSceneSetting : MonoBehaviour
{
	// Token: 0x060011E5 RID: 4581 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011E5")]
	[Address(RVA = "0x1C55EAC", Offset = "0x1C55EAC", VA = "0x1C55EAC")]
	private void OnEnable()
	{
	}

	// Token: 0x060011E6 RID: 4582 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011E6")]
	[Address(RVA = "0x1C5636C", Offset = "0x1C5636C", VA = "0x1C5636C")]
	private void OnDisable()
	{
	}

	// Token: 0x060011E7 RID: 4583 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011E7")]
	[Address(RVA = "0x1C55F54", Offset = "0x1C55F54", VA = "0x1C55F54")]
	private void SetSH()
	{
	}

	// Token: 0x060011E8 RID: 4584 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011E8")]
	[Address(RVA = "0x1C563C8", Offset = "0x1C563C8", VA = "0x1C563C8")]
	public RenderSceneSetting()
	{
	}

	// Token: 0x040014C9 RID: 5321
	[Token(Token = "0x40014C9")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public SphericalHarmonicsL2 ambientProbe;

	// Token: 0x040014CA RID: 5322
	[Token(Token = "0x40014CA")]
	[FieldOffset(Offset = "0x84")]
	[SerializeField]
	public bool customSH;

	// Token: 0x040014CB RID: 5323
	[Token(Token = "0x40014CB")]
	[FieldOffset(Offset = "0x85")]
	[SerializeField]
	public bool isFaceCamera;

	// Token: 0x040014CC RID: 5324
	[Token(Token = "0x40014CC")]
	[FieldOffset(Offset = "0x0")]
	private static string TOGGLE_SH;

	// Token: 0x040014CD RID: 5325
	[Token(Token = "0x40014CD")]
	[FieldOffset(Offset = "0x8")]
	private static string TOGGLE_FACE;

	// Token: 0x040014CE RID: 5326
	[Token(Token = "0x40014CE")]
	[FieldOffset(Offset = "0x88")]
	private string[] unitySHParamNames;
}
