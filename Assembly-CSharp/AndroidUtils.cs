using System;
using Il2CppDummyDll;

// Token: 0x0200014C RID: 332
[Token(Token = "0x200014C")]
public static class AndroidUtils
{
	// Token: 0x060009BF RID: 2495 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009BF")]
	[Address(RVA = "0x33B6A60", Offset = "0x33B6A60", VA = "0x33B6A60")]
	public static void Quit()
	{
	}

	// Token: 0x060009C0 RID: 2496 RVA: 0x00005040 File Offset: 0x00003240
	[Token(Token = "0x60009C0")]
	[Address(RVA = "0x33B6B54", Offset = "0x33B6B54", VA = "0x33B6B54")]
	public static int GetKeyboardHeight()
	{
		return 0;
	}

	// Token: 0x060009C1 RID: 2497 RVA: 0x00005058 File Offset: 0x00003258
	[Token(Token = "0x60009C1")]
	[Address(RVA = "0x33B6F90", Offset = "0x33B6F90", VA = "0x33B6F90")]
	public static AndroidUtils.EGraphicAPI GetGraphicAPI()
	{
		return AndroidUtils.EGraphicAPI.OpenGL;
	}

	// Token: 0x060009C2 RID: 2498 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009C2")]
	[Address(RVA = "0x33B7098", Offset = "0x33B7098", VA = "0x33B7098")]
	public static void SetGraphicAPI(AndroidUtils.EGraphicAPI api)
	{
	}

	// Token: 0x060009C3 RID: 2499 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009C3")]
	[Address(RVA = "0x33B71D4", Offset = "0x33B71D4", VA = "0x33B71D4")]
	public static void RecoverGraphicAPI()
	{
	}

	// Token: 0x060009C4 RID: 2500 RVA: 0x00005070 File Offset: 0x00003270
	[Token(Token = "0x60009C4")]
	[Address(RVA = "0x33B72C8", Offset = "0x33B72C8", VA = "0x33B72C8")]
	public static int GetSDKLevel()
	{
		return 0;
	}

	// Token: 0x0200014D RID: 333
	[Token(Token = "0x200014D")]
	public enum EGraphicAPI
	{
		// Token: 0x0400073A RID: 1850
		[Token(Token = "0x400073A")]
		OpenGL,
		// Token: 0x0400073B RID: 1851
		[Token(Token = "0x400073B")]
		VulKan
	}
}
