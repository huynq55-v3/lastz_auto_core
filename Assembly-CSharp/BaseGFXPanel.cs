using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

// Token: 0x020001F5 RID: 501
[Token(Token = "0x20001F5")]
public class BaseGFXPanel
{
	// Token: 0x170001AD RID: 429
	// (get) Token: 0x06000D9A RID: 3482 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000D9B RID: 3483 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001AD")]
	public string name
	{
		[Token(Token = "0x6000D9A")]
		[Address(RVA = "0x12D6F48", Offset = "0x12D6F48", VA = "0x12D6F48")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000D9B")]
		[Address(RVA = "0x12D6F50", Offset = "0x12D6F50", VA = "0x12D6F50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x06000D9C RID: 3484 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D9C")]
	[Address(RVA = "0x12D6F58", Offset = "0x12D6F58", VA = "0x12D6F58")]
	public BaseGFXPanel(string p_name)
	{
	}

	// Token: 0x06000D9D RID: 3485 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D9D")]
	[Address(RVA = "0x12D6F88", Offset = "0x12D6F88", VA = "0x12D6F88", Slot = "4")]
	public virtual void Init()
	{
	}

	// Token: 0x06000D9E RID: 3486 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D9E")]
	[Address(RVA = "0x12D6F8C", Offset = "0x12D6F8C", VA = "0x12D6F8C", Slot = "5")]
	public virtual void DrawGUI()
	{
	}

	// Token: 0x06000D9F RID: 3487 RVA: 0x000062D0 File Offset: 0x000044D0
	[Token(Token = "0x6000D9F")]
	[Address(RVA = "0x12D6F90", Offset = "0x12D6F90", VA = "0x12D6F90")]
	protected float DrawSlider(string label, float v, float min, float max)
	{
		return 0f;
	}

	// Token: 0x06000DA0 RID: 3488 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000DA0")]
	[Address(RVA = "0x12D70E4", Offset = "0x12D70E4", VA = "0x12D70E4")]
	protected string DrawInputField(string label, string inputTex)
	{
		return null;
	}
}
