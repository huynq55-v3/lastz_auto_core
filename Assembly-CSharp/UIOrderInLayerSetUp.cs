using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000AD RID: 173
[Token(Token = "0x20000AD")]
[ExecuteInEditMode]
public class UIOrderInLayerSetUp : UIParticleSetUpBase
{
	// Token: 0x06000411 RID: 1041 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000411")]
	[Address(RVA = "0x2F6974C", Offset = "0x2F6974C", VA = "0x2F6974C")]
	private void Start()
	{
	}

	// Token: 0x06000412 RID: 1042 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000412")]
	[Address(RVA = "0x2F6992C", Offset = "0x2F6992C", VA = "0x2F6992C")]
	private void RefreshForCanvas()
	{
	}

	// Token: 0x06000413 RID: 1043 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000413")]
	[Address(RVA = "0x2F69AD0", Offset = "0x2F69AD0", VA = "0x2F69AD0")]
	private void RefreshForRender()
	{
	}

	// Token: 0x06000414 RID: 1044 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000414")]
	[Address(RVA = "0x2F69750", Offset = "0x2F69750", VA = "0x2F69750")]
	public new void Refresh()
	{
	}

	// Token: 0x06000415 RID: 1045 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000415")]
	[Address(RVA = "0x2F69C84", Offset = "0x2F69C84", VA = "0x2F69C84")]
	public UIOrderInLayerSetUp()
	{
	}

	// Token: 0x040003B4 RID: 948
	[Token(Token = "0x40003B4")]
	[FieldOffset(Offset = "0x18")]
	public int parentSortingOrder;

	// Token: 0x040003B5 RID: 949
	[Token(Token = "0x40003B5")]
	[FieldOffset(Offset = "0x1C")]
	public int finalOrder;

	// Token: 0x040003B6 RID: 950
	[Token(Token = "0x40003B6")]
	[FieldOffset(Offset = "0x20")]
	public bool Local;

	// Token: 0x040003B7 RID: 951
	[Token(Token = "0x40003B7")]
	[FieldOffset(Offset = "0x24")]
	public UIOrderInLayerSetUp.EType MyType;

	// Token: 0x040003B8 RID: 952
	[Token(Token = "0x40003B8")]
	[FieldOffset(Offset = "0x28")]
	public int sortingOrder;

	// Token: 0x040003B9 RID: 953
	[Token(Token = "0x40003B9")]
	[FieldOffset(Offset = "0x30")]
	private Canvas parentCanvas;

	// Token: 0x020000AE RID: 174
	[Token(Token = "0x20000AE")]
	public enum EType
	{
		// Token: 0x040003BB RID: 955
		[Token(Token = "0x40003BB")]
		Canvas,
		// Token: 0x040003BC RID: 956
		[Token(Token = "0x40003BC")]
		Renderer
	}
}
