using System;
using System.Runtime.CompilerServices;
using System.Text;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000342 RID: 834
[Token(Token = "0x2000342")]
public class NewText : Text
{
	// Token: 0x17000244 RID: 580
	// (get) Token: 0x060015AD RID: 5549 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060015AE RID: 5550 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000244")]
	public override string text
	{
		[Token(Token = "0x60015AD")]
		[Address(RVA = "0x1ED54B8", Offset = "0x1ED54B8", VA = "0x1ED54B8", Slot = "74")]
		get
		{
			return null;
		}
		[Token(Token = "0x60015AE")]
		[Address(RVA = "0x1ED54C0", Offset = "0x1ED54C0", VA = "0x1ED54C0", Slot = "75")]
		set
		{
		}
	}

	// Token: 0x060015AF RID: 5551 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60015AF")]
	[Address(RVA = "0x1ED5708", Offset = "0x1ED5708", VA = "0x1ED5708")]
	private string GetTextWithEllipsis(string value)
	{
		return null;
	}

	// Token: 0x17000245 RID: 581
	// (get) Token: 0x060015B0 RID: 5552 RVA: 0x000085B0 File Offset: 0x000067B0
	// (set) Token: 0x060015B1 RID: 5553 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000245")]
	public int VisibleLines
	{
		[Token(Token = "0x60015B0")]
		[Address(RVA = "0x1ED5BCC", Offset = "0x1ED5BCC", VA = "0x1ED5BCC")]
		[CompilerGenerated]
		get
		{
			return 0;
		}
		[Token(Token = "0x60015B1")]
		[Address(RVA = "0x1ED5BD4", Offset = "0x1ED5BD4", VA = "0x1ED5BD4")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x060015B2 RID: 5554 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015B2")]
	[Address(RVA = "0x1ED5BDC", Offset = "0x1ED5BDC", VA = "0x1ED5BDC")]
	private void _UseFitSettings()
	{
	}

	// Token: 0x060015B3 RID: 5555 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015B3")]
	[Address(RVA = "0x1ED5EDC", Offset = "0x1ED5EDC", VA = "0x1ED5EDC", Slot = "44")]
	protected override void OnPopulateMesh(VertexHelper toFill)
	{
	}

	// Token: 0x060015B4 RID: 5556 RVA: 0x000085C8 File Offset: 0x000067C8
	[Token(Token = "0x60015B4")]
	[Address(RVA = "0x1ED5B08", Offset = "0x1ED5B08", VA = "0x1ED5B08")]
	private bool IsRtl(string str)
	{
		return default(bool);
	}

	// Token: 0x060015B5 RID: 5557 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015B5")]
	[Address(RVA = "0x1ED64A4", Offset = "0x1ED64A4", VA = "0x1ED64A4")]
	public NewText()
	{
	}

	// Token: 0x040018BF RID: 6335
	[Token(Token = "0x40018BF")]
	[FieldOffset(Offset = "0x100")]
	[SerializeField]
	private bool _useTextWithEllipsis;

	// Token: 0x040018C0 RID: 6336
	[Token(Token = "0x40018C0")]
	[FieldOffset(Offset = "0x101")]
	[SerializeField]
	private bool _useTextBestFit;

	// Token: 0x040018C1 RID: 6337
	[Token(Token = "0x40018C1")]
	[FieldOffset(Offset = "0x102")]
	[SerializeField]
	private bool _useNoLineSpace;

	// Token: 0x040018C2 RID: 6338
	[Token(Token = "0x40018C2")]
	private const string no_breaking_space = "\u00a0";

	// Token: 0x040018C3 RID: 6339
	[Token(Token = "0x40018C3")]
	[FieldOffset(Offset = "0x108")]
	private StringBuilder _stringBuilder;

	// Token: 0x040018C4 RID: 6340
	[Token(Token = "0x40018C4")]
	[FieldOffset(Offset = "0x110")]
	private bool _lock;

	// Token: 0x040018C5 RID: 6341
	[Token(Token = "0x40018C5")]
	[FieldOffset(Offset = "0x118")]
	private string _compareValue;

	// Token: 0x040018C6 RID: 6342
	[Token(Token = "0x40018C6")]
	[FieldOffset(Offset = "0x120")]
	private bool _needNewString;

	// Token: 0x040018C8 RID: 6344
	[Token(Token = "0x40018C8")]
	[FieldOffset(Offset = "0x128")]
	private readonly UIVertex[] _tmpVerts;
}
