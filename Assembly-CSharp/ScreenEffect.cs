using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000269 RID: 617
[Token(Token = "0x2000269")]
[ExecuteAlways]
public class ScreenEffect : MonoBehaviour
{
	// Token: 0x0600104F RID: 4175 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600104F")]
	[Address(RVA = "0x1BED008", Offset = "0x1BED008", VA = "0x1BED008")]
	private void Start()
	{
	}

	// Token: 0x06001050 RID: 4176 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001050")]
	[Address(RVA = "0x1BED00C", Offset = "0x1BED00C", VA = "0x1BED00C")]
	private void OnEnable()
	{
	}

	// Token: 0x06001051 RID: 4177 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001051")]
	[Address(RVA = "0x1BED050", Offset = "0x1BED050", VA = "0x1BED050")]
	private void OnDisable()
	{
	}

	// Token: 0x06001052 RID: 4178 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001052")]
	[Address(RVA = "0x1BED094", Offset = "0x1BED094", VA = "0x1BED094")]
	private void Update()
	{
	}

	// Token: 0x06001053 RID: 4179 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001053")]
	[Address(RVA = "0x1BED134", Offset = "0x1BED134", VA = "0x1BED134")]
	public ScreenEffect()
	{
	}

	// Token: 0x040012E0 RID: 4832
	[Token(Token = "0x40012E0")]
	[FieldOffset(Offset = "0x18")]
	public Texture2D texture2D;

	// Token: 0x040012E1 RID: 4833
	[Token(Token = "0x40012E1")]
	[FieldOffset(Offset = "0x20")]
	public Color lightColor;

	// Token: 0x040012E2 RID: 4834
	[Token(Token = "0x40012E2")]
	[FieldOffset(Offset = "0x30")]
	public float lightItensity;
}
