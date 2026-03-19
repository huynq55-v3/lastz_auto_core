using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000222 RID: 546
[Token(Token = "0x2000222")]
[Serializable]
public class DynamicAsset
{
	// Token: 0x06000E96 RID: 3734 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E96")]
	[Address(RVA = "0x122906C", Offset = "0x122906C", VA = "0x122906C")]
	public DynamicAsset(Object obj)
	{
	}

	// Token: 0x06000E97 RID: 3735 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E97")]
	[Address(RVA = "0x1229758", Offset = "0x1229758", VA = "0x1229758")]
	public DynamicAsset(Object obj, int referencedCount)
	{
	}

	// Token: 0x170001BB RID: 443
	// (get) Token: 0x06000E98 RID: 3736 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170001BB")]
	public string Name
	{
		[Token(Token = "0x6000E98")]
		[Address(RVA = "0x12297B8", Offset = "0x12297B8", VA = "0x12297B8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	// Token: 0x06000E99 RID: 3737 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E99")]
	[Address(RVA = "0x12297C0", Offset = "0x12297C0", VA = "0x12297C0")]
	public Object Load()
	{
		return null;
	}

	// Token: 0x06000E9A RID: 3738 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E9A")]
	[Address(RVA = "0x1229840", Offset = "0x1229840", VA = "0x1229840")]
	public void Release()
	{
	}

	// Token: 0x06000E9B RID: 3739 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E9B")]
	[Address(RVA = "0x1228788", Offset = "0x1228788", VA = "0x1228788")]
	public void Update()
	{
	}

	// Token: 0x06000E9C RID: 3740 RVA: 0x00006720 File Offset: 0x00004920
	[Token(Token = "0x6000E9C")]
	[Address(RVA = "0x12287C0", Offset = "0x12287C0", VA = "0x12287C0")]
	public bool TryDestroy()
	{
		return default(bool);
	}

	// Token: 0x040011AA RID: 4522
	[Token(Token = "0x40011AA")]
	private const float RELEASE_TIME = 15f;

	// Token: 0x040011AB RID: 4523
	[Token(Token = "0x40011AB")]
	[FieldOffset(Offset = "0x10")]
	private Object m_Object;

	// Token: 0x040011AC RID: 4524
	[Token(Token = "0x40011AC")]
	[FieldOffset(Offset = "0x18")]
	private int m_ReferencedCount;

	// Token: 0x040011AD RID: 4525
	[Token(Token = "0x40011AD")]
	[FieldOffset(Offset = "0x1C")]
	private float m_ReleaseInverval;
}
