using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200005F RID: 95
[Token(Token = "0x200005F")]
[AddComponentMenu("uSkyPro/Other/uSkyPro Script Access Example (C#)")]
[ExecuteInEditMode]
public class uSkyScriptAccessExample : MonoBehaviour
{
	// Token: 0x0600021E RID: 542 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600021E")]
	[Address(RVA = "0x3203554", Offset = "0x3203554", VA = "0x3203554")]
	private void Start()
	{
	}

	// Token: 0x0600021F RID: 543 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600021F")]
	[Address(RVA = "0x32035A8", Offset = "0x32035A8", VA = "0x32035A8")]
	public uSkyScriptAccessExample()
	{
	}

	// Token: 0x040001E4 RID: 484
	[Token(Token = "0x40001E4")]
	[FieldOffset(Offset = "0x18")]
	public float MyExposure;

	// Token: 0x040001E5 RID: 485
	[Token(Token = "0x40001E5")]
	[FieldOffset(Offset = "0x20")]
	private uSkyPro uSP;
}
