using System;
using Il2CppDummyDll;
using UnityEngine.UI;

// Token: 0x0200010F RID: 271
[Token(Token = "0x200010F")]
public class ItemRender : DynamicInfinityItem
{
	// Token: 0x060007AB RID: 1963 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007AB")]
	[Address(RVA = "0x347B6E8", Offset = "0x347B6E8", VA = "0x347B6E8")]
	private void Start()
	{
	}

	// Token: 0x060007AC RID: 1964 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007AC")]
	[Address(RVA = "0x347B77C", Offset = "0x347B77C", VA = "0x347B77C", Slot = "4")]
	protected override void OnRenderer()
	{
	}

	// Token: 0x060007AD RID: 1965 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007AD")]
	[Address(RVA = "0x347B7C0", Offset = "0x347B7C0", VA = "0x347B7C0")]
	public ItemRender()
	{
	}

	// Token: 0x0400059A RID: 1434
	[Token(Token = "0x400059A")]
	[FieldOffset(Offset = "0x38")]
	public Text m_TxtName;

	// Token: 0x0400059B RID: 1435
	[Token(Token = "0x400059B")]
	[FieldOffset(Offset = "0x40")]
	public Button m_Btn;
}
