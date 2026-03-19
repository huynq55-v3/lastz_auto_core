using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000257 RID: 599
[Token(Token = "0x2000257")]
[ExecuteAlways]
public class GlitchHelper : MonoBehaviour
{
	// Token: 0x170001DA RID: 474
	// (get) Token: 0x06000FF7 RID: 4087 RVA: 0x00006CF0 File Offset: 0x00004EF0
	// (set) Token: 0x06000FF8 RID: 4088 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001DA")]
	public float scanLineJitter
	{
		[Token(Token = "0x6000FF7")]
		[Address(RVA = "0x1BE9B74", Offset = "0x1BE9B74", VA = "0x1BE9B74")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6000FF8")]
		[Address(RVA = "0x1BE9B7C", Offset = "0x1BE9B7C", VA = "0x1BE9B7C")]
		set
		{
		}
	}

	// Token: 0x170001DB RID: 475
	// (get) Token: 0x06000FF9 RID: 4089 RVA: 0x00006D08 File Offset: 0x00004F08
	// (set) Token: 0x06000FFA RID: 4090 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001DB")]
	public float verticalJump
	{
		[Token(Token = "0x6000FF9")]
		[Address(RVA = "0x1BE9B84", Offset = "0x1BE9B84", VA = "0x1BE9B84")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6000FFA")]
		[Address(RVA = "0x1BE9B8C", Offset = "0x1BE9B8C", VA = "0x1BE9B8C")]
		set
		{
		}
	}

	// Token: 0x170001DC RID: 476
	// (get) Token: 0x06000FFB RID: 4091 RVA: 0x00006D20 File Offset: 0x00004F20
	// (set) Token: 0x06000FFC RID: 4092 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001DC")]
	public float horizontalShake
	{
		[Token(Token = "0x6000FFB")]
		[Address(RVA = "0x1BE9B94", Offset = "0x1BE9B94", VA = "0x1BE9B94")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6000FFC")]
		[Address(RVA = "0x1BE9B9C", Offset = "0x1BE9B9C", VA = "0x1BE9B9C")]
		set
		{
		}
	}

	// Token: 0x06000FFD RID: 4093 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FFD")]
	[Address(RVA = "0x1BE9BA4", Offset = "0x1BE9BA4", VA = "0x1BE9BA4")]
	private void Awake()
	{
	}

	// Token: 0x06000FFE RID: 4094 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FFE")]
	[Address(RVA = "0x1BE9BA8", Offset = "0x1BE9BA8", VA = "0x1BE9BA8")]
	private void Start()
	{
	}

	// Token: 0x06000FFF RID: 4095 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FFF")]
	[Address(RVA = "0x1BE9CF4", Offset = "0x1BE9CF4", VA = "0x1BE9CF4")]
	public void Update()
	{
	}

	// Token: 0x06001000 RID: 4096 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001000")]
	[Address(RVA = "0x1BE9E68", Offset = "0x1BE9E68", VA = "0x1BE9E68")]
	public GlitchHelper()
	{
	}

	// Token: 0x0400126F RID: 4719
	[Token(Token = "0x400126F")]
	[FieldOffset(Offset = "0x18")]
	public Material mmm;

	// Token: 0x04001270 RID: 4720
	[Token(Token = "0x4001270")]
	[FieldOffset(Offset = "0x20")]
	[Range(0f, 1f)]
	[SerializeField]
	private float _scanLineJitter;

	// Token: 0x04001271 RID: 4721
	[Token(Token = "0x4001271")]
	[FieldOffset(Offset = "0x24")]
	[Range(0f, 1f)]
	[SerializeField]
	private float _verticalJump;

	// Token: 0x04001272 RID: 4722
	[Token(Token = "0x4001272")]
	[FieldOffset(Offset = "0x28")]
	[Range(0f, 1f)]
	[SerializeField]
	private float _horizontalShake;

	// Token: 0x04001273 RID: 4723
	[Token(Token = "0x4001273")]
	[FieldOffset(Offset = "0x2C")]
	private float _verticalJumpTime;

	// Token: 0x04001274 RID: 4724
	[Token(Token = "0x4001274")]
	[FieldOffset(Offset = "0x30")]
	public bool showAnimation;

	// Token: 0x04001275 RID: 4725
	[Token(Token = "0x4001275")]
	[FieldOffset(Offset = "0x34")]
	[Range(0f, 1f)]
	public float _ColorOffset;

	// Token: 0x04001276 RID: 4726
	[Token(Token = "0x4001276")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	public float _scanLineMax;
}
