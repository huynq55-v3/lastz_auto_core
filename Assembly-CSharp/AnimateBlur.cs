using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020000E2 RID: 226
[Token(Token = "0x20000E2")]
public class AnimateBlur : MonoBehaviour
{
	// Token: 0x06000622 RID: 1570 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000622")]
	[Address(RVA = "0x2E79914", Offset = "0x2E79914", VA = "0x2E79914")]
	private void OnEnable()
	{
	}

	// Token: 0x06000623 RID: 1571 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000623")]
	[Address(RVA = "0x2E79D64", Offset = "0x2E79D64", VA = "0x2E79D64")]
	private void OnDisable()
	{
	}

	// Token: 0x06000624 RID: 1572 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000624")]
	[Address(RVA = "0x2E79CE0", Offset = "0x2E79CE0", VA = "0x2E79CE0")]
	private IEnumerator DoFade(float duration)
	{
		return null;
	}

	// Token: 0x06000625 RID: 1573 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000625")]
	[Address(RVA = "0x2E799FC", Offset = "0x2E799FC", VA = "0x2E799FC")]
	private void ToggleRendererFeature(bool enable)
	{
	}

	// Token: 0x06000626 RID: 1574 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000626")]
	[Address(RVA = "0x2E79D94", Offset = "0x2E79D94", VA = "0x2E79D94")]
	public AnimateBlur()
	{
	}

	// Token: 0x0400049F RID: 1183
	[Token(Token = "0x400049F")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private RawImage rawImage;

	// Token: 0x040004A0 RID: 1184
	[Token(Token = "0x40004A0")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Material material;

	// Token: 0x040004A1 RID: 1185
	[Token(Token = "0x40004A1")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float duration;

	// Token: 0x040004A2 RID: 1186
	[Token(Token = "0x40004A2")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private float wait;

	// Token: 0x040004A3 RID: 1187
	[Token(Token = "0x40004A3")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private float MaxRadius;

	// Token: 0x040004A4 RID: 1188
	[Token(Token = "0x40004A4")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	private float MaxIterations;

	// Token: 0x040004A5 RID: 1189
	[Token(Token = "0x40004A5")]
	[FieldOffset(Offset = "0x0")]
	private static readonly int BlurRadius;

	// Token: 0x040004A6 RID: 1190
	[Token(Token = "0x40004A6")]
	[FieldOffset(Offset = "0x4")]
	private static readonly int Iterations;
}
