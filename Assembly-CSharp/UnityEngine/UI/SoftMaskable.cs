using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.UI
{
	// Token: 0x02000CBD RID: 3261
	[Token(Token = "0x2000CBD")]
	[ExecuteAlways]
	[RequireComponent(typeof(Graphic))]
	public class SoftMaskable : MonoBehaviour, IMaterialModifier, ICanvasRaycastFilter
	{
		// Token: 0x17000B24 RID: 2852
		// (get) Token: 0x06007B3D RID: 31549 RVA: 0x000541F8 File Offset: 0x000523F8
		// (set) Token: 0x06007B3E RID: 31550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B24")]
		public bool inverse
		{
			[Token(Token = "0x6007B3D")]
			[Address(RVA = "0x322431C", Offset = "0x322431C", VA = "0x322431C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6007B3E")]
			[Address(RVA = "0x322432C", Offset = "0x322432C", VA = "0x322432C")]
			set
			{
			}
		}

		// Token: 0x17000B25 RID: 2853
		// (get) Token: 0x06007B3F RID: 31551 RVA: 0x00054210 File Offset: 0x00052410
		// (set) Token: 0x06007B40 RID: 31552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B25")]
		public bool raycastFilter
		{
			[Token(Token = "0x6007B3F")]
			[Address(RVA = "0x3224414", Offset = "0x3224414", VA = "0x3224414")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6007B40")]
			[Address(RVA = "0x322441C", Offset = "0x322441C", VA = "0x322441C")]
			set
			{
			}
		}

		// Token: 0x17000B26 RID: 2854
		// (get) Token: 0x06007B41 RID: 31553 RVA: 0x00054228 File Offset: 0x00052428
		// (set) Token: 0x06007B42 RID: 31554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B26")]
		public bool useStencil
		{
			[Token(Token = "0x6007B41")]
			[Address(RVA = "0x3224428", Offset = "0x3224428", VA = "0x3224428")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6007B42")]
			[Address(RVA = "0x3224430", Offset = "0x3224430", VA = "0x3224430")]
			set
			{
			}
		}

		// Token: 0x17000B27 RID: 2855
		// (get) Token: 0x06007B43 RID: 31555 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B27")]
		public Graphic graphic
		{
			[Token(Token = "0x6007B43")]
			[Address(RVA = "0x3224364", Offset = "0x3224364", VA = "0x3224364")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B28 RID: 2856
		// (get) Token: 0x06007B44 RID: 31556 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B28")]
		public SoftMask softMask
		{
			[Token(Token = "0x6007B44")]
			[Address(RVA = "0x322445C", Offset = "0x322445C", VA = "0x322445C")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B29 RID: 2857
		// (get) Token: 0x06007B45 RID: 31557 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06007B46 RID: 31558 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B29")]
		public Material modifiedMaterial
		{
			[Token(Token = "0x6007B45")]
			[Address(RVA = "0x3224510", Offset = "0x3224510", VA = "0x3224510")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6007B46")]
			[Address(RVA = "0x3224518", Offset = "0x3224518", VA = "0x3224518")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000B2A RID: 2858
		// (get) Token: 0x06007B47 RID: 31559 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B2A")]
		public Image grayImage
		{
			[Token(Token = "0x6007B47")]
			[Address(RVA = "0x3224520", Offset = "0x3224520", VA = "0x3224520")]
			get
			{
				return null;
			}
		}

		// Token: 0x06007B48 RID: 31560 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007B48")]
		[Address(RVA = "0x32245D0", Offset = "0x32245D0", VA = "0x32245D0", Slot = "4")]
		private Material UnityEngine.UI.IMaterialModifier.GetModifiedMaterial(Material baseMaterial)
		{
			return null;
		}

		// Token: 0x06007B49 RID: 31561 RVA: 0x00054240 File Offset: 0x00052440
		[Token(Token = "0x6007B49")]
		[Address(RVA = "0x32248CC", Offset = "0x32248CC", VA = "0x32248CC", Slot = "5")]
		private bool UnityEngine.ICanvasRaycastFilter.IsRaycastLocationValid(Vector2 sp, Camera eventCamera)
		{
			return default(bool);
		}

		// Token: 0x06007B4A RID: 31562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B4A")]
		[Address(RVA = "0x3224E9C", Offset = "0x3224E9C", VA = "0x3224E9C")]
		public void SetMaskInteraction(SpriteMaskInteraction intr)
		{
		}

		// Token: 0x06007B4B RID: 31563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B4B")]
		[Address(RVA = "0x3224EB8", Offset = "0x3224EB8", VA = "0x3224EB8")]
		public void SetMaskInteraction(SpriteMaskInteraction layer0, SpriteMaskInteraction layer1, SpriteMaskInteraction layer2, SpriteMaskInteraction layer3)
		{
		}

		// Token: 0x06007B4C RID: 31564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B4C")]
		[Address(RVA = "0x3224ED8", Offset = "0x3224ED8", VA = "0x3224ED8")]
		private void OnEnable()
		{
		}

		// Token: 0x06007B4D RID: 31565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B4D")]
		[Address(RVA = "0x32250E4", Offset = "0x32250E4", VA = "0x32250E4")]
		private void OnDisable()
		{
		}

		// Token: 0x06007B4E RID: 31566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B4E")]
		[Address(RVA = "0x32251D4", Offset = "0x32251D4", VA = "0x32251D4")]
		public SoftMaskable()
		{
		}

		// Token: 0x0400365A RID: 13914
		[Token(Token = "0x400365A")]
		private const int kVisibleInside = 85;

		// Token: 0x0400365B RID: 13915
		[Token(Token = "0x400365B")]
		private const int kVisibleOutside = 170;

		// Token: 0x0400365C RID: 13916
		[Token(Token = "0x400365C")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Hash128 k_InvalidHash;

		// Token: 0x0400365D RID: 13917
		[Token(Token = "0x400365D")]
		[FieldOffset(Offset = "0x10")]
		private static int s_SoftMaskTexId;

		// Token: 0x0400365E RID: 13918
		[Token(Token = "0x400365E")]
		[FieldOffset(Offset = "0x14")]
		private static int s_StencilCompId;

		// Token: 0x0400365F RID: 13919
		[Token(Token = "0x400365F")]
		[FieldOffset(Offset = "0x18")]
		private static int s_MaskInteractionId;

		// Token: 0x04003660 RID: 13920
		[Token(Token = "0x4003660")]
		[FieldOffset(Offset = "0x1C")]
		private static int s_GameVPId;

		// Token: 0x04003661 RID: 13921
		[Token(Token = "0x4003661")]
		[FieldOffset(Offset = "0x20")]
		private static int s_GameTVPId;

		// Token: 0x04003662 RID: 13922
		[Token(Token = "0x4003662")]
		[FieldOffset(Offset = "0x28")]
		private static List<SoftMaskable> s_ActiveSoftMaskables;

		// Token: 0x04003663 RID: 13923
		[Token(Token = "0x4003663")]
		[FieldOffset(Offset = "0x30")]
		private static int[] s_Interactions;

		// Token: 0x04003664 RID: 13924
		[Token(Token = "0x4003664")]
		[FieldOffset(Offset = "0x18")]
		[HideInInspector]
		[SerializeField]
		[Obsolete]
		private bool m_Inverse;

		// Token: 0x04003665 RID: 13925
		[Token(Token = "0x4003665")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		[Tooltip("The interaction for each masks.")]
		[HideInInspector]
		private int m_MaskInteraction;

		// Token: 0x04003666 RID: 13926
		[Token(Token = "0x4003666")]
		[FieldOffset(Offset = "0x20")]
		[Tooltip("Use stencil to mask.")]
		[SerializeField]
		private bool m_UseStencil;

		// Token: 0x04003667 RID: 13927
		[Token(Token = "0x4003667")]
		[FieldOffset(Offset = "0x21")]
		[Tooltip("Use soft-masked raycast target.\n\nNote: This option is expensive.")]
		[SerializeField]
		private bool m_RaycastFilter;

		// Token: 0x04003668 RID: 13928
		[Token(Token = "0x4003668")]
		[FieldOffset(Offset = "0x28")]
		private Graphic _graphic;

		// Token: 0x04003669 RID: 13929
		[Token(Token = "0x4003669")]
		[FieldOffset(Offset = "0x30")]
		private SoftMask _softMask;

		// Token: 0x0400366A RID: 13930
		[Token(Token = "0x400366A")]
		[FieldOffset(Offset = "0x38")]
		private Hash128 _effectMaterialHash;

		// Token: 0x0400366B RID: 13931
		[Token(Token = "0x400366B")]
		[FieldOffset(Offset = "0x48")]
		private Image _image;
	}
}
