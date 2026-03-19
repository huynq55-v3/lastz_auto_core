using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000177 RID: 375
[Token(Token = "0x2000177")]
[AttributeUsage(272)]
public sealed class Reference : PropertyAttribute
{
	// Token: 0x1700015F RID: 351
	// (get) Token: 0x06000AA9 RID: 2729 RVA: 0x000054F0 File Offset: 0x000036F0
	// (set) Token: 0x06000AAA RID: 2730 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700015F")]
	public ReferenceType RefType
	{
		[Token(Token = "0x6000AA9")]
		[Address(RVA = "0x371A6B0", Offset = "0x371A6B0", VA = "0x371A6B0")]
		[CompilerGenerated]
		get
		{
			return ReferenceType.Prefab;
		}
		[Token(Token = "0x6000AAA")]
		[Address(RVA = "0x371A6B8", Offset = "0x371A6B8", VA = "0x371A6B8")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x06000AAB RID: 2731 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AAB")]
	[Address(RVA = "0x371A6C0", Offset = "0x371A6C0", VA = "0x371A6C0")]
	public Reference(ReferenceType refType)
	{
	}

	// Token: 0x040007A9 RID: 1961
	[Token(Token = "0x40007A9")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public string Path;
}
