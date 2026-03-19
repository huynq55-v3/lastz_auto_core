using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

// Token: 0x020000EF RID: 239
[Token(Token = "0x20000EF")]
public class BaseImage : MaskableGraphic, ISerializationCallbackReceiver, ILayoutElement, ICanvasRaycastFilter
{
	// Token: 0x170000E0 RID: 224
	// (get) Token: 0x060006C5 RID: 1733 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060006C6 RID: 1734 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170000E0")]
	public Sprite sprite
	{
		[Token(Token = "0x60006C5")]
		[Address(RVA = "0x2E82970", Offset = "0x2E82970", VA = "0x2E82970")]
		get
		{
			return null;
		}
		[Token(Token = "0x60006C6")]
		[Address(RVA = "0x2E82978", Offset = "0x2E82978", VA = "0x2E82978")]
		set
		{
		}
	}

	// Token: 0x170000E1 RID: 225
	// (get) Token: 0x060006C7 RID: 1735 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060006C8 RID: 1736 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170000E1")]
	public Sprite overrideSprite
	{
		[Token(Token = "0x60006C7")]
		[Address(RVA = "0x2E829F8", Offset = "0x2E829F8", VA = "0x2E829F8")]
		get
		{
			return null;
		}
		[Token(Token = "0x60006C8")]
		[Address(RVA = "0x2E82A70", Offset = "0x2E82A70", VA = "0x2E82A70")]
		set
		{
		}
	}

	// Token: 0x170000E2 RID: 226
	// (get) Token: 0x060006C9 RID: 1737 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170000E2")]
	public override Texture mainTexture
	{
		[Token(Token = "0x60006C9")]
		[Address(RVA = "0x2E82AF0", Offset = "0x2E82AF0", VA = "0x2E82AF0", Slot = "35")]
		get
		{
			return null;
		}
	}

	// Token: 0x170000E3 RID: 227
	// (get) Token: 0x060006CA RID: 1738 RVA: 0x00004308 File Offset: 0x00002508
	[Token(Token = "0x170000E3")]
	public float pixelsPerUnit
	{
		[Token(Token = "0x60006CA")]
		[Address(RVA = "0x2E82BB4", Offset = "0x2E82BB4", VA = "0x2E82BB4")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x060006CB RID: 1739 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006CB")]
	[Address(RVA = "0x2E82CA0", Offset = "0x2E82CA0", VA = "0x2E82CA0", Slot = "44")]
	protected override void OnPopulateMesh(VertexHelper vh)
	{
	}

	// Token: 0x060006CC RID: 1740 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006CC")]
	[Address(RVA = "0x2E82CA8", Offset = "0x2E82CA8", VA = "0x2E82CA8", Slot = "66")]
	public void OnAfterDeserialize()
	{
	}

	// Token: 0x060006CD RID: 1741 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006CD")]
	[Address(RVA = "0x2E82CAC", Offset = "0x2E82CAC", VA = "0x2E82CAC", Slot = "65")]
	public void OnBeforeSerialize()
	{
	}

	// Token: 0x060006CE RID: 1742 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006CE")]
	[Address(RVA = "0x2E82CB0", Offset = "0x2E82CB0", VA = "0x2E82CB0", Slot = "77")]
	public virtual void CalculateLayoutInputHorizontal()
	{
	}

	// Token: 0x060006CF RID: 1743 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006CF")]
	[Address(RVA = "0x2E82CB4", Offset = "0x2E82CB4", VA = "0x2E82CB4", Slot = "78")]
	public virtual void CalculateLayoutInputVertical()
	{
	}

	// Token: 0x170000E4 RID: 228
	// (get) Token: 0x060006D0 RID: 1744 RVA: 0x00004320 File Offset: 0x00002520
	[Token(Token = "0x170000E4")]
	public virtual float minWidth
	{
		[Token(Token = "0x60006D0")]
		[Address(RVA = "0x2E82CB8", Offset = "0x2E82CB8", VA = "0x2E82CB8", Slot = "79")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x170000E5 RID: 229
	// (get) Token: 0x060006D1 RID: 1745 RVA: 0x00004338 File Offset: 0x00002538
	[Token(Token = "0x170000E5")]
	public virtual float preferredWidth
	{
		[Token(Token = "0x60006D1")]
		[Address(RVA = "0x2E82CC0", Offset = "0x2E82CC0", VA = "0x2E82CC0", Slot = "80")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x170000E6 RID: 230
	// (get) Token: 0x060006D2 RID: 1746 RVA: 0x00004350 File Offset: 0x00002550
	[Token(Token = "0x170000E6")]
	public virtual float flexibleWidth
	{
		[Token(Token = "0x60006D2")]
		[Address(RVA = "0x2E82D88", Offset = "0x2E82D88", VA = "0x2E82D88", Slot = "81")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x170000E7 RID: 231
	// (get) Token: 0x060006D3 RID: 1747 RVA: 0x00004368 File Offset: 0x00002568
	[Token(Token = "0x170000E7")]
	public virtual float minHeight
	{
		[Token(Token = "0x60006D3")]
		[Address(RVA = "0x2E82D90", Offset = "0x2E82D90", VA = "0x2E82D90", Slot = "82")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x170000E8 RID: 232
	// (get) Token: 0x060006D4 RID: 1748 RVA: 0x00004380 File Offset: 0x00002580
	[Token(Token = "0x170000E8")]
	public virtual float preferredHeight
	{
		[Token(Token = "0x60006D4")]
		[Address(RVA = "0x2E82D98", Offset = "0x2E82D98", VA = "0x2E82D98", Slot = "83")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x170000E9 RID: 233
	// (get) Token: 0x060006D5 RID: 1749 RVA: 0x00004398 File Offset: 0x00002598
	[Token(Token = "0x170000E9")]
	public virtual float flexibleHeight
	{
		[Token(Token = "0x60006D5")]
		[Address(RVA = "0x2E82E60", Offset = "0x2E82E60", VA = "0x2E82E60", Slot = "84")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x170000EA RID: 234
	// (get) Token: 0x060006D6 RID: 1750 RVA: 0x000043B0 File Offset: 0x000025B0
	[Token(Token = "0x170000EA")]
	public virtual int layoutPriority
	{
		[Token(Token = "0x60006D6")]
		[Address(RVA = "0x2E82E68", Offset = "0x2E82E68", VA = "0x2E82E68", Slot = "85")]
		get
		{
			return 0;
		}
	}

	// Token: 0x060006D7 RID: 1751 RVA: 0x000043C8 File Offset: 0x000025C8
	[Token(Token = "0x60006D7")]
	[Address(RVA = "0x2E82E70", Offset = "0x2E82E70", VA = "0x2E82E70", Slot = "86")]
	public virtual bool IsRaycastLocationValid(Vector2 screenPoint, Camera eventCamera)
	{
		return default(bool);
	}

	// Token: 0x060006D8 RID: 1752 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006D8")]
	[Address(RVA = "0x2E82E78", Offset = "0x2E82E78", VA = "0x2E82E78")]
	public BaseImage()
	{
	}

	// Token: 0x04000504 RID: 1284
	[Token(Token = "0x4000504")]
	[FieldOffset(Offset = "0xD0")]
	[FormerlySerializedAs("m_Frame")]
	[SerializeField]
	private Sprite m_Sprite;

	// Token: 0x04000505 RID: 1285
	[Token(Token = "0x4000505")]
	[FieldOffset(Offset = "0xD8")]
	[NonSerialized]
	private Sprite m_OverrideSprite;
}
