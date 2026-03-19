using System;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x020001BE RID: 446
[Token(Token = "0x20001BE")]
public class ConfigCache
{
	// Token: 0x06000B63 RID: 2915 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B63")]
	[Address(RVA = "0x3727288", Offset = "0x3727288", VA = "0x3727288")]
	public ConfigCache()
	{
	}

	// Token: 0x06000B64 RID: 2916 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B64")]
	[Address(RVA = "0x3727310", Offset = "0x3727310", VA = "0x3727310")]
	public string GetTemplateData(string tabName, int id, string colName)
	{
		return null;
	}

	// Token: 0x06000B65 RID: 2917 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B65")]
	[Address(RVA = "0x3727734", Offset = "0x3727734", VA = "0x3727734")]
	public void reset()
	{
	}

	// Token: 0x04000FDA RID: 4058
	[Token(Token = "0x4000FDA")]
	[FieldOffset(Offset = "0x10")]
	private Dictionary<string, Dictionary<int, Dictionary<string, string>>> cacheConfig;
}
