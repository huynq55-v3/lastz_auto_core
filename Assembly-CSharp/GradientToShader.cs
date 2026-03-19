using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200008E RID: 142
[Token(Token = "0x200008E")]
public class GradientToShader : MonoBehaviour
{
	// Token: 0x06000366 RID: 870 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000366")]
	[Address(RVA = "0x3214330", Offset = "0x3214330", VA = "0x3214330")]
	public static Texture2D GradientToLUT(Gradient gradient, int width)
	{
		return null;
	}

	// Token: 0x06000367 RID: 871 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000367")]
	[Address(RVA = "0x321447C", Offset = "0x321447C", VA = "0x321447C")]
	private void Start()
	{
	}

	// Token: 0x06000368 RID: 872 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000368")]
	[Address(RVA = "0x3214480", Offset = "0x3214480", VA = "0x3214480")]
	private void Refresh()
	{
	}

	// Token: 0x06000369 RID: 873 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000369")]
	[Address(RVA = "0x321457C", Offset = "0x321457C", VA = "0x321457C")]
	private void OnDestroy()
	{
	}

	// Token: 0x0600036A RID: 874 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600036A")]
	[Address(RVA = "0x321461C", Offset = "0x321461C", VA = "0x321461C")]
	public GradientToShader()
	{
	}

	// Token: 0x040002F6 RID: 758
	[Token(Token = "0x40002F6")]
	[FieldOffset(Offset = "0x18")]
	[Header("渐变设置")]
	[SerializeField]
	public Gradient gradient;

	// Token: 0x040002F7 RID: 759
	[Token(Token = "0x40002F7")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	public int lutWidth;

	// Token: 0x040002F8 RID: 760
	[Token(Token = "0x40002F8")]
	[FieldOffset(Offset = "0x28")]
	[Header("材质设置")]
	[SerializeField]
	public string shaderPropertyName;

	// Token: 0x040002F9 RID: 761
	[Token(Token = "0x40002F9")]
	[FieldOffset(Offset = "0x30")]
	private Texture2D lut;
}
