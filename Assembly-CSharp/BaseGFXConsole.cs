using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001F4 RID: 500
[Token(Token = "0x20001F4")]
public class BaseGFXConsole : MonoBehaviour
{
	// Token: 0x170001AC RID: 428
	// (get) Token: 0x06000D8C RID: 3468 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000D8D RID: 3469 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001AC")]
	public static BaseGFXConsole Instance
	{
		[Token(Token = "0x6000D8C")]
		[Address(RVA = "0x12D5FF8", Offset = "0x12D5FF8", VA = "0x12D5FF8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000D8D")]
		[Address(RVA = "0x12D6040", Offset = "0x12D6040", VA = "0x12D6040")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x06000D8E RID: 3470 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D8E")]
	[Address(RVA = "0x12D6098", Offset = "0x12D6098", VA = "0x12D6098")]
	private void Awake()
	{
	}

	// Token: 0x06000D8F RID: 3471 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D8F")]
	[Address(RVA = "0x12D6168", Offset = "0x12D6168", VA = "0x12D6168", Slot = "4")]
	protected virtual void Initialize()
	{
	}

	// Token: 0x06000D90 RID: 3472 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D90")]
	[Address(RVA = "0x12D616C", Offset = "0x12D616C", VA = "0x12D616C", Slot = "5")]
	protected virtual void OnShowConsole()
	{
	}

	// Token: 0x06000D91 RID: 3473 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D91")]
	[Address(RVA = "0x12D6170", Offset = "0x12D6170", VA = "0x12D6170", Slot = "6")]
	protected virtual void OnHideConsole()
	{
	}

	// Token: 0x06000D92 RID: 3474 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D92")]
	[Address(RVA = "0x12D6174", Offset = "0x12D6174", VA = "0x12D6174")]
	protected void AddPanel(BaseGFXPanel panel)
	{
	}

	// Token: 0x06000D93 RID: 3475 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D93")]
	[Address(RVA = "0x12D6238", Offset = "0x12D6238", VA = "0x12D6238")]
	private void OnGUI()
	{
	}

	// Token: 0x06000D94 RID: 3476 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D94")]
	[Address(RVA = "0x12D6A50", Offset = "0x12D6A50", VA = "0x12D6A50")]
	private void DoMyWindow(int windowID)
	{
	}

	// Token: 0x06000D95 RID: 3477 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D95")]
	[Address(RVA = "0x12D6B10", Offset = "0x12D6B10", VA = "0x12D6B10")]
	private void DrawHead()
	{
	}

	// Token: 0x06000D96 RID: 3478 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D96")]
	[Address(RVA = "0x12D6CEC", Offset = "0x12D6CEC", VA = "0x12D6CEC")]
	private void InitPanelNameArray()
	{
	}

	// Token: 0x06000D97 RID: 3479 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D97")]
	[Address(RVA = "0x12D6C88", Offset = "0x12D6C88", VA = "0x12D6C88")]
	private void DrawBody()
	{
	}

	// Token: 0x06000D98 RID: 3480 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D98")]
	[Address(RVA = "0x12D67B4", Offset = "0x12D67B4", VA = "0x12D67B4")]
	private void MakeBigGUISkin()
	{
	}

	// Token: 0x06000D99 RID: 3481 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D99")]
	[Address(RVA = "0x12D6F28", Offset = "0x12D6F28", VA = "0x12D6F28")]
	public BaseGFXConsole()
	{
	}

	// Token: 0x04001100 RID: 4352
	[Token(Token = "0x4001100")]
	[FieldOffset(Offset = "0x18")]
	private bool bShowConsole;

	// Token: 0x04001101 RID: 4353
	[Token(Token = "0x4001101")]
	[FieldOffset(Offset = "0x20")]
	private List<BaseGFXPanel> panelList;

	// Token: 0x04001102 RID: 4354
	[Token(Token = "0x4001102")]
	[FieldOffset(Offset = "0x28")]
	private string[] panelNameArr;

	// Token: 0x04001103 RID: 4355
	[Token(Token = "0x4001103")]
	[FieldOffset(Offset = "0x30")]
	private int currPanelIdx;

	// Token: 0x04001104 RID: 4356
	[Token(Token = "0x4001104")]
	[FieldOffset(Offset = "0x34")]
	private Rect windowRect;

	// Token: 0x04001105 RID: 4357
	[Token(Token = "0x4001105")]
	[FieldOffset(Offset = "0x44")]
	private Vector2 scrollPosi;

	// Token: 0x04001107 RID: 4359
	[Token(Token = "0x4001107")]
	[FieldOffset(Offset = "0x4C")]
	private float screenWidth;

	// Token: 0x04001108 RID: 4360
	[Token(Token = "0x4001108")]
	[FieldOffset(Offset = "0x50")]
	private float screenHeight;

	// Token: 0x04001109 RID: 4361
	[Token(Token = "0x4001109")]
	[FieldOffset(Offset = "0x54")]
	private float resFactor;

	// Token: 0x0400110A RID: 4362
	[Token(Token = "0x400110A")]
	[FieldOffset(Offset = "0x58")]
	private float fixedWidth;

	// Token: 0x0400110B RID: 4363
	[Token(Token = "0x400110B")]
	[FieldOffset(Offset = "0x5C")]
	private bool firstShow;
}
