using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000349 RID: 841
[Token(Token = "0x2000349")]
public class ScreenSafeArea : MonoBehaviour
{
	// Token: 0x060015D5 RID: 5589 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015D5")]
	[Address(RVA = "0x1ED8120", Offset = "0x1ED8120", VA = "0x1ED8120")]
	private void Awake()
	{
	}

	// Token: 0x060015D6 RID: 5590 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015D6")]
	[Address(RVA = "0x1ED8330", Offset = "0x1ED8330", VA = "0x1ED8330")]
	private void Update()
	{
	}

	// Token: 0x060015D7 RID: 5591 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015D7")]
	[Address(RVA = "0x1ED8334", Offset = "0x1ED8334", VA = "0x1ED8334")]
	private void CheckSize()
	{
	}

	// Token: 0x060015D8 RID: 5592 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015D8")]
	[Address(RVA = "0x1ED82C4", Offset = "0x1ED82C4", VA = "0x1ED82C4")]
	private void Refresh()
	{
	}

	// Token: 0x060015D9 RID: 5593 RVA: 0x000086A0 File Offset: 0x000068A0
	[Token(Token = "0x60015D9")]
	[Address(RVA = "0x1ED83A4", Offset = "0x1ED83A4", VA = "0x1ED83A4")]
	public Rect GetSafeArea_View()
	{
		return default(Rect);
	}

	// Token: 0x060015DA RID: 5594 RVA: 0x000086B8 File Offset: 0x000068B8
	[Token(Token = "0x60015DA")]
	[Address(RVA = "0x1ED892C", Offset = "0x1ED892C", VA = "0x1ED892C")]
	public static Rect GetSafeArea()
	{
		return default(Rect);
	}

	// Token: 0x060015DB RID: 5595 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015DB")]
	[Address(RVA = "0x1ED8820", Offset = "0x1ED8820", VA = "0x1ED8820")]
	private void SetSafeArea(Rect r)
	{
	}

	// Token: 0x060015DC RID: 5596 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015DC")]
	[Address(RVA = "0x1ED8AC8", Offset = "0x1ED8AC8", VA = "0x1ED8AC8")]
	public ScreenSafeArea()
	{
	}

	// Token: 0x040018F9 RID: 6393
	[Token(Token = "0x40018F9")]
	[FieldOffset(Offset = "0x18")]
	public Rect iphoneDelta;

	// Token: 0x040018FA RID: 6394
	[Token(Token = "0x40018FA")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private RectTransform Panel;

	// Token: 0x040018FB RID: 6395
	[Token(Token = "0x40018FB")]
	[FieldOffset(Offset = "0x30")]
	private Rect LastSafeArea;

	// Token: 0x040018FC RID: 6396
	[Token(Token = "0x40018FC")]
	[FieldOffset(Offset = "0x40")]
	private float ScreenWidth;

	// Token: 0x040018FD RID: 6397
	[Token(Token = "0x40018FD")]
	[FieldOffset(Offset = "0x44")]
	private float ScreenHeight;
}
