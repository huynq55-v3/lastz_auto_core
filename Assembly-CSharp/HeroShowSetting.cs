using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000020 RID: 32
[Token(Token = "0x2000020")]
[ExecuteAlways]
public class HeroShowSetting : MonoBehaviour
{
	// Token: 0x06000055 RID: 85 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000055")]
	[Address(RVA = "0x15E3DA8", Offset = "0x15E3DA8", VA = "0x15E3DA8")]
	private void Awake()
	{
	}

	// Token: 0x06000056 RID: 86 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000056")]
	[Address(RVA = "0x15E3E00", Offset = "0x15E3E00", VA = "0x15E3E00")]
	private void Start()
	{
	}

	// Token: 0x06000057 RID: 87 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000057")]
	[Address(RVA = "0x15E3E04", Offset = "0x15E3E04", VA = "0x15E3E04")]
	private void Update()
	{
	}

	// Token: 0x06000058 RID: 88 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000058")]
	[Address(RVA = "0x15E3EF4", Offset = "0x15E3EF4", VA = "0x15E3EF4")]
	private void OnDestroy()
	{
	}

	// Token: 0x06000059 RID: 89 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000059")]
	[Address(RVA = "0x15E3EF8", Offset = "0x15E3EF8", VA = "0x15E3EF8")]
	public HeroShowSetting()
	{
	}

	// Token: 0x040000AA RID: 170
	[Token(Token = "0x40000AA")]
	[FieldOffset(Offset = "0x18")]
	private Renderer[] render;

	// Token: 0x040000AB RID: 171
	[Token(Token = "0x40000AB")]
	[FieldOffset(Offset = "0x20")]
	[Range(0f, 1f)]
	public float _RimLevel;

	// Token: 0x040000AC RID: 172
	[Token(Token = "0x40000AC")]
	[FieldOffset(Offset = "0x24")]
	[Range(0f, 360f)]
	public float _RimNomalRotaion;
}
