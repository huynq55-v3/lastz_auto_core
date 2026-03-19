using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200012C RID: 300
[Token(Token = "0x200012C")]
[RequireComponent(typeof(MeshFilter))]
[AddComponentMenu("Mesh/Super Text Mesh", 3)]
[ExecuteInEditMode]
[RequireComponent(typeof(MeshRenderer))]
[DisallowMultipleComponent]
public class SuperTextMesh : MonoBehaviour
{
	// Token: 0x1700012F RID: 303
	// (get) Token: 0x060008A9 RID: 2217 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060008AA RID: 2218 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700012F")]
	public string text
	{
		[Token(Token = "0x60008A9")]
		[Address(RVA = "0x33A66AC", Offset = "0x33A66AC", VA = "0x33A66AC")]
		get
		{
			return null;
		}
		[Token(Token = "0x60008AA")]
		[Address(RVA = "0x33A66B4", Offset = "0x33A66B4", VA = "0x33A66B4")]
		set
		{
		}
	}

	// Token: 0x060008AB RID: 2219 RVA: 0x00004C68 File Offset: 0x00002E68
	[Token(Token = "0x60008AB")]
	[Address(RVA = "0x33A6974", Offset = "0x33A6974", VA = "0x33A6974")]
	[Obsolete]
	private bool IsRtl(string str)
	{
		return default(bool);
	}

	// Token: 0x060008AC RID: 2220 RVA: 0x00004C80 File Offset: 0x00002E80
	[Token(Token = "0x60008AC")]
	[Address(RVA = "0x33A679C", Offset = "0x33A679C", VA = "0x33A679C")]
	public bool HasArabic(string str, out int arabicCount)
	{
		return default(bool);
	}

	// Token: 0x17000130 RID: 304
	// (get) Token: 0x060008AD RID: 2221 RVA: 0x00004C98 File Offset: 0x00002E98
	// (set) Token: 0x060008AE RID: 2222 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000130")]
	public Color32 color32
	{
		[Token(Token = "0x60008AD")]
		[Address(RVA = "0x33A69F4", Offset = "0x33A69F4", VA = "0x33A69F4")]
		get
		{
			return default(Color32);
		}
		[Token(Token = "0x60008AE")]
		[Address(RVA = "0x33A69FC", Offset = "0x33A69FC", VA = "0x33A69FC")]
		set
		{
		}
	}

	// Token: 0x17000131 RID: 305
	// (get) Token: 0x060008AF RID: 2223 RVA: 0x00004CB0 File Offset: 0x00002EB0
	// (set) Token: 0x060008B0 RID: 2224 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000131")]
	public Color32 color
	{
		[Token(Token = "0x60008AF")]
		[Address(RVA = "0x33A6A04", Offset = "0x33A6A04", VA = "0x33A6A04")]
		get
		{
			return default(Color32);
		}
		[Token(Token = "0x60008B0")]
		[Address(RVA = "0x33A6A0C", Offset = "0x33A6A0C", VA = "0x33A6A0C")]
		set
		{
		}
	}

	// Token: 0x17000132 RID: 306
	// (get) Token: 0x060008B1 RID: 2225 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060008B2 RID: 2226 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000132")]
	public Gradient EffectGradient
	{
		[Token(Token = "0x60008B1")]
		[Address(RVA = "0x33A6A14", Offset = "0x33A6A14", VA = "0x33A6A14")]
		get
		{
			return null;
		}
		[Token(Token = "0x60008B2")]
		[Address(RVA = "0x33A6A1C", Offset = "0x33A6A1C", VA = "0x33A6A1C")]
		set
		{
		}
	}

	// Token: 0x17000133 RID: 307
	// (get) Token: 0x060008B3 RID: 2227 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060008B4 RID: 2228 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000133")]
	public string MaterialKey
	{
		[Token(Token = "0x60008B3")]
		[Address(RVA = "0x33A6A24", Offset = "0x33A6A24", VA = "0x33A6A24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60008B4")]
		[Address(RVA = "0x33A6A2C", Offset = "0x33A6A2C", VA = "0x33A6A2C")]
		[CompilerGenerated]
		set
		{
		}
	}

	// Token: 0x17000134 RID: 308
	// (get) Token: 0x060008B5 RID: 2229 RVA: 0x00004CC8 File Offset: 0x00002EC8
	[Token(Token = "0x17000134")]
	private float AutoWrap
	{
		[Token(Token = "0x60008B5")]
		[Address(RVA = "0x33A6A34", Offset = "0x33A6A34", VA = "0x33A6A34")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x17000135 RID: 309
	// (get) Token: 0x060008B6 RID: 2230 RVA: 0x00004CE0 File Offset: 0x00002EE0
	[Token(Token = "0x17000135")]
	public int LineCount
	{
		[Token(Token = "0x60008B6")]
		[Address(RVA = "0x33A6A3C", Offset = "0x33A6A3C", VA = "0x33A6A3C")]
		get
		{
			return 0;
		}
	}

	// Token: 0x060008B7 RID: 2231 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60008B7")]
	[Address(RVA = "0x33A6A44", Offset = "0x33A6A44", VA = "0x33A6A44")]
	private STMCharInfo NewCharInfo(SuperTextMesh stm)
	{
		return null;
	}

	// Token: 0x060008B8 RID: 2232 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60008B8")]
	[Address(RVA = "0x33A6C50", Offset = "0x33A6C50", VA = "0x33A6C50")]
	private STMCharInfo NewCharInfo(STMCharInfo clone, CharacterInfo ch)
	{
		return null;
	}

	// Token: 0x060008B9 RID: 2233 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008B9")]
	[Address(RVA = "0x33A6EE4", Offset = "0x33A6EE4", VA = "0x33A6EE4")]
	private void ResetCharInfoPool()
	{
	}

	// Token: 0x060008BA RID: 2234 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008BA")]
	[Address(RVA = "0x33A6EEC", Offset = "0x33A6EEC", VA = "0x33A6EEC")]
	public void FontTextureChanged()
	{
	}

	// Token: 0x060008BB RID: 2235 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008BB")]
	[Address(RVA = "0x33A6EF0", Offset = "0x33A6EF0", VA = "0x33A6EF0")]
	private void Awake()
	{
	}

	// Token: 0x060008BC RID: 2236 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008BC")]
	[Address(RVA = "0x33A6EF4", Offset = "0x33A6EF4", VA = "0x33A6EF4")]
	private void Init()
	{
	}

	// Token: 0x060008BD RID: 2237 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008BD")]
	[Address(RVA = "0x33A70A0", Offset = "0x33A70A0", VA = "0x33A70A0")]
	public void SetOrderInLayer(int orderInLayer)
	{
	}

	// Token: 0x060008BE RID: 2238 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008BE")]
	[Address(RVA = "0x33A70BC", Offset = "0x33A70BC", VA = "0x33A70BC")]
	private void OnEnable()
	{
	}

	// Token: 0x060008BF RID: 2239 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008BF")]
	[Address(RVA = "0x33A7568", Offset = "0x33A7568", VA = "0x33A7568")]
	private void OnDisable()
	{
	}

	// Token: 0x060008C0 RID: 2240 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008C0")]
	[Address(RVA = "0x33A7844", Offset = "0x33A7844", VA = "0x33A7844")]
	private void OnDestroy()
	{
	}

	// Token: 0x060008C1 RID: 2241 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008C1")]
	[Address(RVA = "0x33A78D4", Offset = "0x33A78D4", VA = "0x33A78D4")]
	public void SetCallBack(Action callBack)
	{
	}

	// Token: 0x060008C2 RID: 2242 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008C2")]
	[Address(RVA = "0x33A6864", Offset = "0x33A6864", VA = "0x33A6864")]
	public void Rebuild()
	{
	}

	// Token: 0x060008C3 RID: 2243 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008C3")]
	[Address(RVA = "0x33A78DC", Offset = "0x33A78DC", VA = "0x33A78DC")]
	private void RebuildTextInfo()
	{
	}

	// Token: 0x060008C4 RID: 2244 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008C4")]
	[Address(RVA = "0x33A9364", Offset = "0x33A9364", VA = "0x33A9364")]
	private void RecalculateBounds()
	{
	}

	// Token: 0x060008C5 RID: 2245 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008C5")]
	[Address(RVA = "0x33A8394", Offset = "0x33A8394", VA = "0x33A8394")]
	private void ApplyAlignment()
	{
	}

	// Token: 0x060008C6 RID: 2246 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008C6")]
	[Address(RVA = "0x33A862C", Offset = "0x33A862C", VA = "0x33A862C")]
	private void SetMesh()
	{
	}

	// Token: 0x060008C7 RID: 2247 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008C7")]
	[Address(RVA = "0x33A9204", Offset = "0x33A9204", VA = "0x33A9204")]
	private void ApplyMaterial()
	{
	}

	// Token: 0x060008C8 RID: 2248 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008C8")]
	[Address(RVA = "0x33AA8CC", Offset = "0x33AA8CC", VA = "0x33AA8CC")]
	public void OnUpdate(float alpha)
	{
	}

	// Token: 0x060008C9 RID: 2249 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008C9")]
	[Address(RVA = "0x33A97B0", Offset = "0x33A97B0", VA = "0x33A97B0")]
	private void ModityMesh(List<Vector3> verts, List<Vector2> uvs, List<Color32> colors)
	{
	}

	// Token: 0x060008CA RID: 2250 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008CA")]
	[Address(RVA = "0x33AA9B0", Offset = "0x33AA9B0", VA = "0x33AA9B0")]
	private void ApplyShadow(List<Vector3> verts, List<Vector2> uvs, List<Color32> colors, Color32 c, int start, int end, float x, float y)
	{
	}

	// Token: 0x060008CB RID: 2251 RVA: 0x00004CF8 File Offset: 0x00002EF8
	[Token(Token = "0x60008CB")]
	[Address(RVA = "0x33AAC88", Offset = "0x33AAC88", VA = "0x33AAC88")]
	public float GetHeight()
	{
		return 0f;
	}

	// Token: 0x060008CC RID: 2252 RVA: 0x00004D10 File Offset: 0x00002F10
	[Token(Token = "0x60008CC")]
	[Address(RVA = "0x33AAC90", Offset = "0x33AAC90", VA = "0x33AAC90")]
	public float GetWidth()
	{
		return 0f;
	}

	// Token: 0x060008CD RID: 2253 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008CD")]
	[Address(RVA = "0x33AAC98", Offset = "0x33AAC98", VA = "0x33AAC98")]
	public void SetColorAlpha(float a)
	{
	}

	// Token: 0x060008CE RID: 2254 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008CE")]
	[Address(RVA = "0x33AAD7C", Offset = "0x33AAD7C", VA = "0x33AAD7C")]
	public SuperTextMesh()
	{
	}

	// Token: 0x04000658 RID: 1624
	[Token(Token = "0x4000658")]
	[FieldOffset(Offset = "0x18")]
	private Transform t;

	// Token: 0x04000659 RID: 1625
	[Token(Token = "0x4000659")]
	[FieldOffset(Offset = "0x20")]
	private MeshFilter f;

	// Token: 0x0400065A RID: 1626
	[Token(Token = "0x400065A")]
	[FieldOffset(Offset = "0x28")]
	private MeshRenderer r;

	// Token: 0x0400065B RID: 1627
	[Token(Token = "0x400065B")]
	[FieldOffset(Offset = "0x30")]
	private bool isInit;

	// Token: 0x0400065C RID: 1628
	[Token(Token = "0x400065C")]
	private const int ReserveCount = 30;

	// Token: 0x0400065D RID: 1629
	[Token(Token = "0x400065D")]
	[FieldOffset(Offset = "0x38")]
	private List<STMCharInfo> info;

	// Token: 0x0400065E RID: 1630
	[Token(Token = "0x400065E")]
	[FieldOffset(Offset = "0x40")]
	private List<Vector3> endVerts;

	// Token: 0x0400065F RID: 1631
	[Token(Token = "0x400065F")]
	[FieldOffset(Offset = "0x48")]
	private List<Vector2> endUv;

	// Token: 0x04000660 RID: 1632
	[Token(Token = "0x4000660")]
	[FieldOffset(Offset = "0x50")]
	private List<Color32> endCol32;

	// Token: 0x04000661 RID: 1633
	[Token(Token = "0x4000661")]
	[FieldOffset(Offset = "0x58")]
	private List<int> tris;

	// Token: 0x04000662 RID: 1634
	[Token(Token = "0x4000662")]
	[FieldOffset(Offset = "0x60")]
	private List<STMCharInfo> charInfoPool;

	// Token: 0x04000663 RID: 1635
	[Token(Token = "0x4000663")]
	[FieldOffset(Offset = "0x68")]
	private int allocIndex;

	// Token: 0x04000664 RID: 1636
	[Token(Token = "0x4000664")]
	[FieldOffset(Offset = "0x6C")]
	public float alpha;

	// Token: 0x04000665 RID: 1637
	[Token(Token = "0x4000665")]
	[FieldOffset(Offset = "0x70")]
	[TextArea(3, 10)]
	public string _text;

	// Token: 0x04000666 RID: 1638
	[Token(Token = "0x4000666")]
	[FieldOffset(Offset = "0x78")]
	private Action _callBack;

	// Token: 0x04000667 RID: 1639
	[Token(Token = "0x4000667")]
	[FieldOffset(Offset = "0x80")]
	private string hyphenedText;

	// Token: 0x04000668 RID: 1640
	[Token(Token = "0x4000668")]
	[FieldOffset(Offset = "0x88")]
	[Tooltip("Font to be used by this text mesh. .rtf, .otf, and Unity fonts are supported.")]
	public Font font;

	// Token: 0x04000669 RID: 1641
	[Token(Token = "0x4000669")]
	[FieldOffset(Offset = "0x90")]
	[Tooltip("Default color of the text mesh. This can be changed with the <c> tag! See the docs for more info.")]
	public Color32 _color;

	// Token: 0x0400066A RID: 1642
	[Token(Token = "0x400066A")]
	[FieldOffset(Offset = "0x94")]
	[Tooltip("Size in local space for letters, by default. Can be changed with the <s> tag.")]
	public float size;

	// Token: 0x0400066B RID: 1643
	[Token(Token = "0x400066B")]
	[FieldOffset(Offset = "0x98")]
	[Tooltip("Point size of text. Try to keep it as small as possible while looking crisp!")]
	[Range(1f, 500f)]
	public int quality;

	// Token: 0x0400066C RID: 1644
	[Token(Token = "0x400066C")]
	[FieldOffset(Offset = "0x9C")]
	[Tooltip("Default letter style. Can be changed with the <i> and <b> tags, using rich text.")]
	public FontStyle style;

	// Token: 0x0400066D RID: 1645
	[Token(Token = "0x400066D")]
	[FieldOffset(Offset = "0xA0")]
	[Tooltip("Adjust line spacing between multiple lines of text. 1 is the default for the font.")]
	public float lineSpacing;

	// Token: 0x0400066E RID: 1646
	[Token(Token = "0x400066E")]
	[FieldOffset(Offset = "0xA4")]
	[Tooltip("Adjust additional spacing between characters. 0 is default.")]
	public float characterSpacing;

	// Token: 0x0400066F RID: 1647
	[Token(Token = "0x400066F")]
	[FieldOffset(Offset = "0xA8")]
	[Tooltip("How far tabs indent.")]
	public float tabSize;

	// Token: 0x04000670 RID: 1648
	[Token(Token = "0x4000670")]
	[FieldOffset(Offset = "0xAC")]
	[Tooltip("Distance in local space before a line break is automatically inserted at the previous space. Disabled if set to 0.")]
	public float autoWrap;

	// Token: 0x04000671 RID: 1649
	[Token(Token = "0x4000671")]
	[FieldOffset(Offset = "0xB0")]
	[Tooltip("With auto wrap, should large words be split to fit in the box?")]
	public bool breakText;

	// Token: 0x04000672 RID: 1650
	[Token(Token = "0x4000672")]
	[FieldOffset(Offset = "0xB1")]
	[Tooltip("When large words are split, Should a hyphen be inserted?")]
	public bool insertHyphens;

	// Token: 0x04000673 RID: 1651
	[Token(Token = "0x4000673")]
	[FieldOffset(Offset = "0xB8")]
	[Tooltip("The material to be used by this text mesh. Look under 'STM' in the shader menu for more compatible shaders.")]
	public Material textMat;

	// Token: 0x04000674 RID: 1652
	[Token(Token = "0x4000674")]
	[FieldOffset(Offset = "0xC0")]
	public bool gradient;

	// Token: 0x04000675 RID: 1653
	[Token(Token = "0x4000675")]
	[FieldOffset(Offset = "0xC8")]
	[SerializeField]
	private Gradient effectGradient;

	// Token: 0x04000676 RID: 1654
	[Token(Token = "0x4000676")]
	[FieldOffset(Offset = "0xD0")]
	public bool ztest;

	// Token: 0x04000677 RID: 1655
	[Token(Token = "0x4000677")]
	[FieldOffset(Offset = "0xD1")]
	public bool outline;

	// Token: 0x04000678 RID: 1656
	[Token(Token = "0x4000678")]
	[FieldOffset(Offset = "0xD4")]
	public Color outlineColor;

	// Token: 0x04000679 RID: 1657
	[Token(Token = "0x4000679")]
	[FieldOffset(Offset = "0xE4")]
	public Vector2 outlineDistance;

	// Token: 0x0400067B RID: 1659
	[Token(Token = "0x400067B")]
	[FieldOffset(Offset = "0xF8")]
	public SuperTextMesh.Alignment alignment;

	// Token: 0x0400067C RID: 1660
	[Token(Token = "0x400067C")]
	[FieldOffset(Offset = "0xFC")]
	[SerializeField]
	private float skewX;

	// Token: 0x0400067D RID: 1661
	[Token(Token = "0x400067D")]
	[FieldOffset(Offset = "0x100")]
	[SerializeField]
	private float skewY;

	// Token: 0x0400067E RID: 1662
	[Token(Token = "0x400067E")]
	[FieldOffset(Offset = "0x108")]
	[SerializeField]
	private string sortingLayer;

	// Token: 0x0400067F RID: 1663
	[Token(Token = "0x400067F")]
	[FieldOffset(Offset = "0x110")]
	[SerializeField]
	private int orderInLayer;

	// Token: 0x04000680 RID: 1664
	[Token(Token = "0x4000680")]
	[FieldOffset(Offset = "0x118")]
	private Mesh textMesh;

	// Token: 0x04000681 RID: 1665
	[Token(Token = "0x4000681")]
	[FieldOffset(Offset = "0x120")]
	private Vector3 rawTopLeftBounds;

	// Token: 0x04000682 RID: 1666
	[Token(Token = "0x4000682")]
	[FieldOffset(Offset = "0x12C")]
	private Vector3 rawBottomRightBounds;

	// Token: 0x04000683 RID: 1667
	[Token(Token = "0x4000683")]
	[FieldOffset(Offset = "0x138")]
	private Vector3 topLeftBounds;

	// Token: 0x04000684 RID: 1668
	[Token(Token = "0x4000684")]
	[FieldOffset(Offset = "0x144")]
	private Vector3 topRightBounds;

	// Token: 0x04000685 RID: 1669
	[Token(Token = "0x4000685")]
	[FieldOffset(Offset = "0x150")]
	private Vector3 bottomLeftBounds;

	// Token: 0x04000686 RID: 1670
	[Token(Token = "0x4000686")]
	[FieldOffset(Offset = "0x15C")]
	private Vector3 bottomRightBounds;

	// Token: 0x04000687 RID: 1671
	[Token(Token = "0x4000687")]
	[FieldOffset(Offset = "0x168")]
	private Vector3 centerBounds;

	// Token: 0x04000688 RID: 1672
	[Token(Token = "0x4000688")]
	[FieldOffset(Offset = "0x174")]
	private float lowestVert;

	// Token: 0x04000689 RID: 1673
	[Token(Token = "0x4000689")]
	[FieldOffset(Offset = "0x178")]
	private float rightestVert;

	// Token: 0x0400068A RID: 1674
	[Token(Token = "0x400068A")]
	[FieldOffset(Offset = "0x17C")]
	private float _lineWidth;

	// Token: 0x0400068B RID: 1675
	[Token(Token = "0x400068B")]
	[FieldOffset(Offset = "0x180")]
	private int _lineCount;

	// Token: 0x0400068C RID: 1676
	[Token(Token = "0x400068C")]
	[FieldOffset(Offset = "0x184")]
	private float _width;

	// Token: 0x0400068D RID: 1677
	[Token(Token = "0x400068D")]
	[FieldOffset(Offset = "0x0")]
	private static int mainTexId;

	// Token: 0x0400068E RID: 1678
	[Token(Token = "0x400068E")]
	[FieldOffset(Offset = "0x4")]
	private static int mixAlphaID;

	// Token: 0x0400068F RID: 1679
	[Token(Token = "0x400068F")]
	[FieldOffset(Offset = "0x8")]
	private static int keyAlphaID;

	// Token: 0x04000690 RID: 1680
	[Token(Token = "0x4000690")]
	[FieldOffset(Offset = "0x188")]
	private MaterialPropertyBlock matBlock;

	// Token: 0x0200012D RID: 301
	[Token(Token = "0x200012D")]
	public enum Alignment
	{
		// Token: 0x04000692 RID: 1682
		[Token(Token = "0x4000692")]
		TopLeft,
		// Token: 0x04000693 RID: 1683
		[Token(Token = "0x4000693")]
		TopCenter,
		// Token: 0x04000694 RID: 1684
		[Token(Token = "0x4000694")]
		TopRight,
		// Token: 0x04000695 RID: 1685
		[Token(Token = "0x4000695")]
		MidLeft,
		// Token: 0x04000696 RID: 1686
		[Token(Token = "0x4000696")]
		MidCenter,
		// Token: 0x04000697 RID: 1687
		[Token(Token = "0x4000697")]
		MidRight,
		// Token: 0x04000698 RID: 1688
		[Token(Token = "0x4000698")]
		BotLeft,
		// Token: 0x04000699 RID: 1689
		[Token(Token = "0x4000699")]
		BotCenter,
		// Token: 0x0400069A RID: 1690
		[Token(Token = "0x400069A")]
		BotRight
	}
}
