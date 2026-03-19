using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Token: 0x020000FC RID: 252
[Token(Token = "0x20000FC")]
public class HyperlinkText : Text, IPointerClickHandler, IEventSystemHandler
{
	// Token: 0x170000EF RID: 239
	// (get) Token: 0x0600071C RID: 1820 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600071D RID: 1821 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170000EF")]
	public HyperlinkText.HrefClickEvent onHrefClick
	{
		[Token(Token = "0x600071C")]
		[Address(RVA = "0x347645C", Offset = "0x347645C", VA = "0x347645C")]
		get
		{
			return null;
		}
		[Token(Token = "0x600071D")]
		[Address(RVA = "0x3476464", Offset = "0x3476464", VA = "0x3476464")]
		set
		{
		}
	}

	// Token: 0x170000F0 RID: 240
	// (get) Token: 0x0600071E RID: 1822 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170000F0")]
	public string GetHyperlinkInfo
	{
		[Token(Token = "0x600071E")]
		[Address(RVA = "0x3476474", Offset = "0x3476474", VA = "0x3476474")]
		get
		{
			return null;
		}
	}

	// Token: 0x0600071F RID: 1823 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600071F")]
	[Address(RVA = "0x34764C0", Offset = "0x34764C0", VA = "0x34764C0", Slot = "4")]
	protected override void Awake()
	{
	}

	// Token: 0x06000720 RID: 1824 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000720")]
	[Address(RVA = "0x3476524", Offset = "0x3476524", VA = "0x3476524", Slot = "5")]
	protected override void OnEnable()
	{
	}

	// Token: 0x06000721 RID: 1825 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000721")]
	[Address(RVA = "0x34765D8", Offset = "0x34765D8", VA = "0x34765D8", Slot = "7")]
	protected override void OnDisable()
	{
	}

	// Token: 0x06000722 RID: 1826 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000722")]
	[Address(RVA = "0x347668C", Offset = "0x347668C", VA = "0x347668C", Slot = "28")]
	public override void SetVerticesDirty()
	{
	}

	// Token: 0x06000723 RID: 1827 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000723")]
	[Address(RVA = "0x34766DC", Offset = "0x34766DC", VA = "0x34766DC", Slot = "44")]
	protected override void OnPopulateMesh(VertexHelper toFill)
	{
	}

	// Token: 0x06000724 RID: 1828 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000724")]
	[Address(RVA = "0x3476BD0", Offset = "0x3476BD0", VA = "0x3476BD0", Slot = "86")]
	protected virtual string GetOutputText(string outputText)
	{
		return null;
	}

	// Token: 0x06000725 RID: 1829 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000725")]
	[Address(RVA = "0x3477368", Offset = "0x3477368", VA = "0x3477368", Slot = "85")]
	public void OnPointerClick(PointerEventData eventData)
	{
	}

	// Token: 0x06000726 RID: 1830 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000726")]
	[Address(RVA = "0x3477638", Offset = "0x3477638", VA = "0x3477638")]
	private void OnHyperlinkTextInfo(string info)
	{
	}

	// Token: 0x06000727 RID: 1831 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000727")]
	[Address(RVA = "0x347763C", Offset = "0x347763C", VA = "0x347763C")]
	public HyperlinkText()
	{
	}

	// Token: 0x04000542 RID: 1346
	[Token(Token = "0x4000542")]
	[FieldOffset(Offset = "0x100")]
	private string m_OutputText;

	// Token: 0x04000543 RID: 1347
	[Token(Token = "0x4000543")]
	[FieldOffset(Offset = "0x108")]
	private readonly List<HyperlinkText.HyperlinkInfo> m_HrefInfos;

	// Token: 0x04000544 RID: 1348
	[Token(Token = "0x4000544")]
	[FieldOffset(Offset = "0x0")]
	protected static readonly StringBuilder s_TextBuilder;

	// Token: 0x04000545 RID: 1349
	[Token(Token = "0x4000545")]
	[FieldOffset(Offset = "0x110")]
	[SerializeField]
	private HyperlinkText.HrefClickEvent m_OnHrefClick;

	// Token: 0x04000546 RID: 1350
	[Token(Token = "0x4000546")]
	[FieldOffset(Offset = "0x8")]
	private static readonly Regex s_HrefRegex;

	// Token: 0x04000547 RID: 1351
	[Token(Token = "0x4000547")]
	[FieldOffset(Offset = "0x118")]
	private HyperlinkText mHyperlinkText;

	// Token: 0x04000548 RID: 1352
	[Token(Token = "0x4000548")]
	[FieldOffset(Offset = "0x120")]
	[SerializeField]
	public string mLink;

	// Token: 0x04000549 RID: 1353
	[Token(Token = "0x4000549")]
	[FieldOffset(Offset = "0x128")]
	[SerializeField]
	public string mName;

	// Token: 0x020000FD RID: 253
	[Token(Token = "0x20000FD")]
	private class HyperlinkInfo
	{
		// Token: 0x06000729 RID: 1833 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000729")]
		[Address(RVA = "0x34772E0", Offset = "0x34772E0", VA = "0x34772E0")]
		public HyperlinkInfo()
		{
		}

		// Token: 0x0400054A RID: 1354
		[Token(Token = "0x400054A")]
		[FieldOffset(Offset = "0x10")]
		public int startIndex;

		// Token: 0x0400054B RID: 1355
		[Token(Token = "0x400054B")]
		[FieldOffset(Offset = "0x14")]
		public int endIndex;

		// Token: 0x0400054C RID: 1356
		[Token(Token = "0x400054C")]
		[FieldOffset(Offset = "0x18")]
		public string name;

		// Token: 0x0400054D RID: 1357
		[Token(Token = "0x400054D")]
		[FieldOffset(Offset = "0x20")]
		public readonly List<Rect> boxes;
	}

	// Token: 0x020000FE RID: 254
	[Token(Token = "0x20000FE")]
	[Serializable]
	public class HrefClickEvent : UnityEvent<string>
	{
		// Token: 0x0600072A RID: 1834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600072A")]
		[Address(RVA = "0x347774C", Offset = "0x347774C", VA = "0x347774C")]
		public HrefClickEvent()
		{
		}
	}
}
