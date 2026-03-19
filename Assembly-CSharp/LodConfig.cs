using System;
using Il2CppDummyDll;
using XLua;

// Token: 0x02000301 RID: 769
[Token(Token = "0x2000301")]
public class LodConfig
{
	// Token: 0x060013FC RID: 5116 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013FC")]
	[Address(RVA = "0x1A54B30", Offset = "0x1A54B30", VA = "0x1A54B30")]
	public void InitByTemplate(LuaTable template)
	{
	}

	// Token: 0x060013FD RID: 5117 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013FD")]
	[Address(RVA = "0x1A54B28", Offset = "0x1A54B28", VA = "0x1A54B28")]
	public LodConfig()
	{
	}

	// Token: 0x040016C9 RID: 5833
	[Token(Token = "0x40016C9")]
	[FieldOffset(Offset = "0x10")]
	public string path;

	// Token: 0x040016CA RID: 5834
	[Token(Token = "0x40016CA")]
	[FieldOffset(Offset = "0x18")]
	public int lodStart;

	// Token: 0x040016CB RID: 5835
	[Token(Token = "0x40016CB")]
	[FieldOffset(Offset = "0x1C")]
	public int lodEnd;

	// Token: 0x040016CC RID: 5836
	[Token(Token = "0x40016CC")]
	[FieldOffset(Offset = "0x20")]
	public bool isMain;

	// Token: 0x040016CD RID: 5837
	[Token(Token = "0x40016CD")]
	[FieldOffset(Offset = "0x21")]
	public bool noFading;
}
