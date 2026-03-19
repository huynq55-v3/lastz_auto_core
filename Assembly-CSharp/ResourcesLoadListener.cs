using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000018 RID: 24
[Token(Token = "0x2000018")]
public class ResourcesLoadListener : ResourcesAPI
{
	// Token: 0x06000032 RID: 50 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000032")]
	[Address(RVA = "0x15E1430", Offset = "0x15E1430", VA = "0x15E1430")]
	[RuntimeInitializeOnLoadMethod]
	private static void OnRuntimeMethodLoad()
	{
	}

	// Token: 0x06000033 RID: 51 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000033")]
	[Address(RVA = "0x15E1540", Offset = "0x15E1540", VA = "0x15E1540", Slot = "6")]
	protected override Object Load(string path, Type systemTypeInstance)
	{
		return null;
	}

	// Token: 0x06000034 RID: 52 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000034")]
	[Address(RVA = "0x15E1810", Offset = "0x15E1810", VA = "0x15E1810", Slot = "7")]
	protected override Object[] LoadAll(string path, Type systemTypeInstance)
	{
		return null;
	}

	// Token: 0x06000035 RID: 53 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000035")]
	[Address(RVA = "0x15E14E8", Offset = "0x15E14E8", VA = "0x15E14E8")]
	public ResourcesLoadListener()
	{
	}
}
