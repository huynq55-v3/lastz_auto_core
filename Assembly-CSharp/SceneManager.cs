using System;
using Il2CppDummyDll;

// Token: 0x020002BD RID: 701
[Token(Token = "0x20002BD")]
public static class SceneManager
{
	// Token: 0x170001FF RID: 511
	// (get) Token: 0x06001220 RID: 4640 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001221 RID: 4641 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001FF")]
	public static WorldScene World
	{
		[Token(Token = "0x6001220")]
		[Address(RVA = "0x1C59DC0", Offset = "0x1C59DC0", VA = "0x1C59DC0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001221")]
		[Address(RVA = "0x1C59E08", Offset = "0x1C59E08", VA = "0x1C59E08")]
		set
		{
		}
	}

	// Token: 0x06001222 RID: 4642 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001222")]
	[Address(RVA = "0x1C59E60", Offset = "0x1C59E60", VA = "0x1C59E60")]
	public static void SetWorldObj(WorldScene wdscene)
	{
	}

	// Token: 0x06001223 RID: 4643 RVA: 0x00007110 File Offset: 0x00005310
	[Token(Token = "0x6001223")]
	[Address(RVA = "0x1C59EB8", Offset = "0x1C59EB8", VA = "0x1C59EB8")]
	public static bool IsInWorld()
	{
		return default(bool);
	}

	// Token: 0x06001224 RID: 4644 RVA: 0x00007128 File Offset: 0x00005328
	[Token(Token = "0x6001224")]
	[Address(RVA = "0x1C59F44", Offset = "0x1C59F44", VA = "0x1C59F44")]
	public static bool IsInCity()
	{
		return default(bool);
	}

	// Token: 0x0400150A RID: 5386
	[Token(Token = "0x400150A")]
	[FieldOffset(Offset = "0x0")]
	private static WorldScene world;
}
