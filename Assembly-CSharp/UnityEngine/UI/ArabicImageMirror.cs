using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.UI
{
	// Token: 0x02000CBE RID: 3262
	[Token(Token = "0x2000CBE")]
	[RequireComponent(typeof(Graphic))]
	public class ArabicImageMirror : BaseMeshEffect
	{
		// Token: 0x17000B2B RID: 2859
		// (get) Token: 0x06007B51 RID: 31569 RVA: 0x00054258 File Offset: 0x00052458
		// (set) Token: 0x06007B52 RID: 31570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B2B")]
		public ArabicImageMirror.MirrorType mirrorType
		{
			[Token(Token = "0x6007B51")]
			[Address(RVA = "0x3225540", Offset = "0x3225540", VA = "0x3225540")]
			get
			{
				return ArabicImageMirror.MirrorType.Horizontal;
			}
			[Token(Token = "0x6007B52")]
			[Address(RVA = "0x3225548", Offset = "0x3225548", VA = "0x3225548")]
			set
			{
			}
		}

		// Token: 0x17000B2C RID: 2860
		// (get) Token: 0x06007B53 RID: 31571 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B2C")]
		public RectTransform rectTransform
		{
			[Token(Token = "0x6007B53")]
			[Address(RVA = "0x3225600", Offset = "0x3225600", VA = "0x3225600")]
			get
			{
				return null;
			}
		}

		// Token: 0x06007B54 RID: 31572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B54")]
		[Address(RVA = "0x3225670", Offset = "0x3225670", VA = "0x3225670", Slot = "20")]
		public override void ModifyMesh(VertexHelper vh)
		{
		}

		// Token: 0x06007B55 RID: 31573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B55")]
		[Address(RVA = "0x322582C", Offset = "0x322582C", VA = "0x322582C")]
		protected void DrawSimple(List<UIVertex> output, int count)
		{
		}

		// Token: 0x06007B56 RID: 31574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B56")]
		[Address(RVA = "0x3225884", Offset = "0x3225884", VA = "0x3225884")]
		protected void DrawSliced(List<UIVertex> output, int count)
		{
		}

		// Token: 0x06007B57 RID: 31575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B57")]
		[Address(RVA = "0x32259C4", Offset = "0x32259C4", VA = "0x32259C4")]
		protected void DrawTiled(List<UIVertex> verts, int count)
		{
		}

		// Token: 0x06007B58 RID: 31576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B58")]
		[Address(RVA = "0x32264D8", Offset = "0x32264D8", VA = "0x32264D8")]
		protected void SimpleScale(Rect rect, List<UIVertex> verts, int count)
		{
		}

		// Token: 0x06007B59 RID: 31577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B59")]
		[Address(RVA = "0x3226620", Offset = "0x3226620", VA = "0x3226620")]
		protected void SlicedScale(Rect rect, List<UIVertex> verts, int count)
		{
		}

		// Token: 0x06007B5A RID: 31578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B5A")]
		[Address(RVA = "0x3225F80", Offset = "0x3225F80", VA = "0x3225F80")]
		protected void MirrorVerts(Rect rect, List<UIVertex> verts, int count, bool isHorizontal = true)
		{
		}

		// Token: 0x06007B5B RID: 31579 RVA: 0x00054270 File Offset: 0x00052470
		[Token(Token = "0x6007B5B")]
		[Address(RVA = "0x32261A8", Offset = "0x32261A8", VA = "0x32261A8")]
		protected int SliceExcludeVerts(List<UIVertex> verts, int count)
		{
			return 0;
		}

		// Token: 0x06007B5C RID: 31580 RVA: 0x00054288 File Offset: 0x00052488
		[Token(Token = "0x6007B5C")]
		[Address(RVA = "0x32267FC", Offset = "0x32267FC", VA = "0x32267FC")]
		protected Vector4 GetAdjustedBorders(Rect rect)
		{
			return default(Vector4);
		}

		// Token: 0x06007B5D RID: 31581 RVA: 0x000542A0 File Offset: 0x000524A0
		[Token(Token = "0x6007B5D")]
		[Address(RVA = "0x322648C", Offset = "0x322648C", VA = "0x322648C")]
		protected float GetCenter(float p1, float p2, float p3)
		{
			return 0f;
		}

		// Token: 0x06007B5E RID: 31582 RVA: 0x000542B8 File Offset: 0x000524B8
		[Token(Token = "0x6007B5E")]
		[Address(RVA = "0x32264B8", Offset = "0x32264B8", VA = "0x32264B8")]
		protected Vector2 GetOverturnUV(Vector2 uv, float start, float end, bool isHorizontal = true)
		{
			return default(Vector2);
		}

		// Token: 0x06007B5F RID: 31583 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B5F")]
		[Address(RVA = "0x32269B0", Offset = "0x32269B0", VA = "0x32269B0")]
		public ArabicImageMirror()
		{
		}

		// Token: 0x0400366D RID: 13933
		[Token(Token = "0x400366D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ArabicImageMirror.MirrorType m_MirrorType;

		// Token: 0x0400366E RID: 13934
		[Token(Token = "0x400366E")]
		[FieldOffset(Offset = "0x28")]
		[NonSerialized]
		private RectTransform m_RectTransform;

		// Token: 0x02000CBF RID: 3263
		[Token(Token = "0x2000CBF")]
		public enum MirrorType
		{
			// Token: 0x04003670 RID: 13936
			[Token(Token = "0x4003670")]
			Horizontal
		}
	}
}
