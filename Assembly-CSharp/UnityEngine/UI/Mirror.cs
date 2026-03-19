using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.UI
{
	// Token: 0x02000CB3 RID: 3251
	[Token(Token = "0x2000CB3")]
	[RequireComponent(typeof(Graphic))]
	[AddComponentMenu("UI/Effects/Mirror", 20)]
	public class Mirror : BaseMeshEffect
	{
		// Token: 0x17000B13 RID: 2835
		// (get) Token: 0x06007AED RID: 31469 RVA: 0x00054018 File Offset: 0x00052218
		// (set) Token: 0x06007AEE RID: 31470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B13")]
		public Mirror.MirrorType mirrorType
		{
			[Token(Token = "0x6007AED")]
			[Address(RVA = "0x321E88C", Offset = "0x321E88C", VA = "0x321E88C")]
			get
			{
				return Mirror.MirrorType.Horizontal;
			}
			[Token(Token = "0x6007AEE")]
			[Address(RVA = "0x321E894", Offset = "0x321E894", VA = "0x321E894")]
			set
			{
			}
		}

		// Token: 0x17000B14 RID: 2836
		// (get) Token: 0x06007AEF RID: 31471 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B14")]
		public RectTransform rectTransform
		{
			[Token(Token = "0x6007AEF")]
			[Address(RVA = "0x321E94C", Offset = "0x321E94C", VA = "0x321E94C")]
			get
			{
				return null;
			}
		}

		// Token: 0x06007AF0 RID: 31472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007AF0")]
		[Address(RVA = "0x321E9BC", Offset = "0x321E9BC", VA = "0x321E9BC")]
		public void SetNativeSize()
		{
		}

		// Token: 0x06007AF1 RID: 31473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007AF1")]
		[Address(RVA = "0x321ECE0", Offset = "0x321ECE0", VA = "0x321ECE0", Slot = "20")]
		public override void ModifyMesh(VertexHelper vh)
		{
		}

		// Token: 0x06007AF2 RID: 31474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007AF2")]
		[Address(RVA = "0x321EE9C", Offset = "0x321EE9C", VA = "0x321EE9C")]
		protected void DrawSimple(List<UIVertex> output, int count)
		{
		}

		// Token: 0x06007AF3 RID: 31475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007AF3")]
		[Address(RVA = "0x321EFCC", Offset = "0x321EFCC", VA = "0x321EFCC")]
		protected void DrawSliced(List<UIVertex> output, int count)
		{
		}

		// Token: 0x06007AF4 RID: 31476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007AF4")]
		[Address(RVA = "0x321F1B0", Offset = "0x321F1B0", VA = "0x321F1B0")]
		protected void DrawTiled(List<UIVertex> verts, int count)
		{
		}

		// Token: 0x06007AF5 RID: 31477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007AF5")]
		[Address(RVA = "0x321FA58", Offset = "0x321FA58", VA = "0x321FA58")]
		protected void ExtendCapacity(List<UIVertex> verts, int addCount)
		{
		}

		// Token: 0x06007AF6 RID: 31478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007AF6")]
		[Address(RVA = "0x321F8DC", Offset = "0x321F8DC", VA = "0x321F8DC")]
		protected void SimpleScale(Rect rect, List<UIVertex> verts, int count)
		{
		}

		// Token: 0x06007AF7 RID: 31479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007AF7")]
		[Address(RVA = "0x321FCB0", Offset = "0x321FCB0", VA = "0x321FCB0")]
		protected void SlicedScale(Rect rect, List<UIVertex> verts, int count)
		{
		}

		// Token: 0x06007AF8 RID: 31480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007AF8")]
		[Address(RVA = "0x321FAF8", Offset = "0x321FAF8", VA = "0x321FAF8")]
		protected void MirrorVerts(Rect rect, List<UIVertex> verts, int count, bool isHorizontal = true)
		{
		}

		// Token: 0x06007AF9 RID: 31481 RVA: 0x00054030 File Offset: 0x00052230
		[Token(Token = "0x6007AF9")]
		[Address(RVA = "0x321FF00", Offset = "0x321FF00", VA = "0x321FF00")]
		protected int SliceExcludeVerts(List<UIVertex> verts, int count)
		{
			return 0;
		}

		// Token: 0x06007AFA RID: 31482 RVA: 0x00054048 File Offset: 0x00052248
		[Token(Token = "0x6007AFA")]
		[Address(RVA = "0x3220230", Offset = "0x3220230", VA = "0x3220230")]
		protected Vector4 GetAdjustedBorders(Rect rect)
		{
			return default(Vector4);
		}

		// Token: 0x06007AFB RID: 31483 RVA: 0x00054060 File Offset: 0x00052260
		[Token(Token = "0x6007AFB")]
		[Address(RVA = "0x32201E4", Offset = "0x32201E4", VA = "0x32201E4")]
		protected float GetCenter(float p1, float p2, float p3)
		{
			return 0f;
		}

		// Token: 0x06007AFC RID: 31484 RVA: 0x00054078 File Offset: 0x00052278
		[Token(Token = "0x6007AFC")]
		[Address(RVA = "0x3220210", Offset = "0x3220210", VA = "0x3220210")]
		protected Vector2 GetOverturnUV(Vector2 uv, float start, float end, bool isHorizontal = true)
		{
			return default(Vector2);
		}

		// Token: 0x06007AFD RID: 31485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007AFD")]
		[Address(RVA = "0x32203E4", Offset = "0x32203E4", VA = "0x32203E4")]
		public Mirror()
		{
		}

		// Token: 0x04003620 RID: 13856
		[Token(Token = "0x4003620")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Mirror.MirrorType m_MirrorType;

		// Token: 0x04003621 RID: 13857
		[Token(Token = "0x4003621")]
		[FieldOffset(Offset = "0x28")]
		[NonSerialized]
		private RectTransform m_RectTransform;

		// Token: 0x02000CB4 RID: 3252
		[Token(Token = "0x2000CB4")]
		public enum MirrorType
		{
			// Token: 0x04003623 RID: 13859
			[Token(Token = "0x4003623")]
			Horizontal,
			// Token: 0x04003624 RID: 13860
			[Token(Token = "0x4003624")]
			Vertical,
			// Token: 0x04003625 RID: 13861
			[Token(Token = "0x4003625")]
			Quarter
		}
	}
}
