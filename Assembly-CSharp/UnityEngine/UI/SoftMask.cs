using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.Rendering;
using UnityEngine.Serialization;

namespace UnityEngine.UI
{
	// Token: 0x02000CBA RID: 3258
	[Token(Token = "0x2000CBA")]
	public class SoftMask : Mask, IMeshModifier
	{
		// Token: 0x17000B16 RID: 2838
		// (get) Token: 0x06007B12 RID: 31506 RVA: 0x000540D8 File Offset: 0x000522D8
		// (set) Token: 0x06007B13 RID: 31507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B16")]
		public SoftMask.DownSamplingRate downSamplingRate
		{
			[Token(Token = "0x6007B12")]
			[Address(RVA = "0x3221080", Offset = "0x3221080", VA = "0x3221080")]
			get
			{
				return SoftMask.DownSamplingRate.None;
			}
			[Token(Token = "0x6007B13")]
			[Address(RVA = "0x3221088", Offset = "0x3221088", VA = "0x3221088")]
			set
			{
			}
		}

		// Token: 0x17000B17 RID: 2839
		// (get) Token: 0x06007B14 RID: 31508 RVA: 0x000540F0 File Offset: 0x000522F0
		// (set) Token: 0x06007B15 RID: 31509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B17")]
		public float softness
		{
			[Token(Token = "0x6007B14")]
			[Address(RVA = "0x3221134", Offset = "0x3221134", VA = "0x3221134")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6007B15")]
			[Address(RVA = "0x322113C", Offset = "0x322113C", VA = "0x322113C")]
			set
			{
			}
		}

		// Token: 0x17000B18 RID: 2840
		// (get) Token: 0x06007B16 RID: 31510 RVA: 0x00054108 File Offset: 0x00052308
		// (set) Token: 0x06007B17 RID: 31511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B18")]
		public float alpha
		{
			[Token(Token = "0x6007B16")]
			[Address(RVA = "0x32211FC", Offset = "0x32211FC", VA = "0x32211FC")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6007B17")]
			[Address(RVA = "0x3221204", Offset = "0x3221204", VA = "0x3221204")]
			set
			{
			}
		}

		// Token: 0x17000B19 RID: 2841
		// (get) Token: 0x06007B18 RID: 31512 RVA: 0x00054120 File Offset: 0x00052320
		// (set) Token: 0x06007B19 RID: 31513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B19")]
		public bool ignoreParent
		{
			[Token(Token = "0x6007B18")]
			[Address(RVA = "0x32212C4", Offset = "0x32212C4", VA = "0x32212C4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6007B19")]
			[Address(RVA = "0x32212CC", Offset = "0x32212CC", VA = "0x32212CC")]
			set
			{
			}
		}

		// Token: 0x17000B1A RID: 2842
		// (get) Token: 0x06007B1A RID: 31514 RVA: 0x00054138 File Offset: 0x00052338
		// (set) Token: 0x06007B1B RID: 31515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B1A")]
		public bool partOfParent
		{
			[Token(Token = "0x6007B1A")]
			[Address(RVA = "0x322130C", Offset = "0x322130C", VA = "0x322130C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6007B1B")]
			[Address(RVA = "0x3221314", Offset = "0x3221314", VA = "0x3221314")]
			set
			{
			}
		}

		// Token: 0x17000B1B RID: 2843
		// (get) Token: 0x06007B1C RID: 31516 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B1B")]
		public RenderTexture softMaskBuffer
		{
			[Token(Token = "0x6007B1C")]
			[Address(RVA = "0x3221354", Offset = "0x3221354", VA = "0x3221354")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B1C RID: 2844
		// (get) Token: 0x06007B1D RID: 31517 RVA: 0x00054150 File Offset: 0x00052350
		// (set) Token: 0x06007B1E RID: 31518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B1C")]
		public bool hasChanged
		{
			[Token(Token = "0x6007B1D")]
			[Address(RVA = "0x3221740", Offset = "0x3221740", VA = "0x3221740")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6007B1E")]
			[Address(RVA = "0x32210A8", Offset = "0x32210A8", VA = "0x32210A8")]
			private set
			{
			}
		}

		// Token: 0x17000B1D RID: 2845
		// (get) Token: 0x06007B1F RID: 31519 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B1D")]
		public SoftMask parent
		{
			[Token(Token = "0x6007B1F")]
			[Address(RVA = "0x32217B8", Offset = "0x32217B8", VA = "0x32217B8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B1E RID: 2846
		// (get) Token: 0x06007B20 RID: 31520 RVA: 0x00054168 File Offset: 0x00052368
		// (set) Token: 0x06007B21 RID: 31521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B1E")]
		public bool ignoreSelfGraphic
		{
			[Token(Token = "0x6007B20")]
			[Address(RVA = "0x32217C0", Offset = "0x32217C0", VA = "0x32217C0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6007B21")]
			[Address(RVA = "0x32217C8", Offset = "0x32217C8", VA = "0x32217C8")]
			set
			{
			}
		}

		// Token: 0x17000B1F RID: 2847
		// (get) Token: 0x06007B22 RID: 31522 RVA: 0x00054180 File Offset: 0x00052380
		// (set) Token: 0x06007B23 RID: 31523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B1F")]
		public bool ignoreSelfStencil
		{
			[Token(Token = "0x6007B22")]
			[Address(RVA = "0x3221808", Offset = "0x3221808", VA = "0x3221808")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6007B23")]
			[Address(RVA = "0x3221810", Offset = "0x3221810", VA = "0x3221810")]
			set
			{
			}
		}

		// Token: 0x17000B20 RID: 2848
		// (get) Token: 0x06007B24 RID: 31524 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B20")]
		private Material material
		{
			[Token(Token = "0x6007B24")]
			[Address(RVA = "0x3221860", Offset = "0x3221860", VA = "0x3221860")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B21 RID: 2849
		// (get) Token: 0x06007B25 RID: 31525 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B21")]
		public Material materialable
		{
			[Token(Token = "0x6007B25")]
			[Address(RVA = "0x3221868", Offset = "0x3221868", VA = "0x3221868")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B22 RID: 2850
		// (get) Token: 0x06007B26 RID: 31526 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B22")]
		public Material materialableGray
		{
			[Token(Token = "0x6007B26")]
			[Address(RVA = "0x3221870", Offset = "0x3221870", VA = "0x3221870")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B23 RID: 2851
		// (get) Token: 0x06007B27 RID: 31527 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B23")]
		private Mesh mesh
		{
			[Token(Token = "0x6007B27")]
			[Address(RVA = "0x3221878", Offset = "0x3221878", VA = "0x3221878")]
			get
			{
				return null;
			}
		}

		// Token: 0x06007B28 RID: 31528 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007B28")]
		[Address(RVA = "0x3221938", Offset = "0x3221938", VA = "0x3221938", Slot = "22")]
		public override Material GetModifiedMaterial(Material baseMaterial)
		{
			return null;
		}

		// Token: 0x06007B29 RID: 31529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B29")]
		[Address(RVA = "0x3221A24", Offset = "0x3221A24", VA = "0x3221A24", Slot = "23")]
		private void UnityEngine.UI.IMeshModifier.ModifyMesh(Mesh mesh)
		{
		}

		// Token: 0x06007B2A RID: 31530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B2A")]
		[Address(RVA = "0x3221A54", Offset = "0x3221A54", VA = "0x3221A54", Slot = "24")]
		private void UnityEngine.UI.IMeshModifier.ModifyMesh(VertexHelper verts)
		{
		}

		// Token: 0x06007B2B RID: 31531 RVA: 0x00054198 File Offset: 0x00052398
		[Token(Token = "0x6007B2B")]
		[Address(RVA = "0x3221AEC", Offset = "0x3221AEC", VA = "0x3221AEC")]
		public bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera, Graphic g, int[] interactions)
		{
			return default(bool);
		}

		// Token: 0x06007B2C RID: 31532 RVA: 0x000541B0 File Offset: 0x000523B0
		[Token(Token = "0x6007B2C")]
		[Address(RVA = "0x32220D4", Offset = "0x32220D4", VA = "0x32220D4", Slot = "21")]
		public override bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera)
		{
			return default(bool);
		}

		// Token: 0x06007B2D RID: 31533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B2D")]
		[Address(RVA = "0x32220DC", Offset = "0x32220DC", VA = "0x32220DC", Slot = "5")]
		protected override void OnEnable()
		{
		}

		// Token: 0x06007B2E RID: 31534 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B2E")]
		[Address(RVA = "0x3222518", Offset = "0x3222518", VA = "0x3222518", Slot = "7")]
		protected override void OnDisable()
		{
		}

		// Token: 0x06007B2F RID: 31535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B2F")]
		[Address(RVA = "0x3222ACC", Offset = "0x3222ACC", VA = "0x3222ACC", Slot = "12")]
		protected override void OnTransformParentChanged()
		{
		}

		// Token: 0x06007B30 RID: 31536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B30")]
		[Address(RVA = "0x3222C08", Offset = "0x3222C08", VA = "0x3222C08", Slot = "10")]
		protected override void OnRectTransformDimensionsChange()
		{
		}

		// Token: 0x06007B31 RID: 31537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B31")]
		[Address(RVA = "0x3222C10", Offset = "0x3222C10", VA = "0x3222C10")]
		private static void UpdateMaskTextures()
		{
		}

		// Token: 0x06007B32 RID: 31538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B32")]
		[Address(RVA = "0x322343C", Offset = "0x322343C", VA = "0x322343C")]
		private void UpdateMaskTexture()
		{
		}

		// Token: 0x06007B33 RID: 31539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B33")]
		[Address(RVA = "0x32215BC", Offset = "0x32215BC", VA = "0x32215BC")]
		private static void GetDownSamplingSize(SoftMask.DownSamplingRate rate, out int w, out int h)
		{
		}

		// Token: 0x06007B34 RID: 31540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B34")]
		[Address(RVA = "0x3221520", Offset = "0x3221520", VA = "0x3221520")]
		private static void ReleaseRt(ref RenderTexture tmpRT)
		{
		}

		// Token: 0x06007B35 RID: 31541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B35")]
		[Address(RVA = "0x3222A48", Offset = "0x3222A48", VA = "0x3222A48")]
		private static void ReleaseObject(Object obj)
		{
		}

		// Token: 0x06007B36 RID: 31542 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B36")]
		[Address(RVA = "0x3222738", Offset = "0x3222738", VA = "0x3222738")]
		private void SetParent(SoftMask newParent)
		{
		}

		// Token: 0x06007B37 RID: 31543 RVA: 0x000541C8 File Offset: 0x000523C8
		[Token(Token = "0x6007B37")]
		[Address(RVA = "0x3221D3C", Offset = "0x3221D3C", VA = "0x3221D3C")]
		private float GetPixelValue(int x, int y, int[] interactions)
		{
			return 0f;
		}

		// Token: 0x06007B38 RID: 31544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B38")]
		[Address(RVA = "0x3223E70", Offset = "0x3223E70", VA = "0x3223E70")]
		public SoftMask()
		{
		}

		// Token: 0x0400362E RID: 13870
		[Token(Token = "0x400362E")]
		[FieldOffset(Offset = "0x0")]
		private static readonly List<SoftMask>[] s_TmpSoftMasks;

		// Token: 0x0400362F RID: 13871
		[Token(Token = "0x400362F")]
		[FieldOffset(Offset = "0x8")]
		private static readonly Color[] s_ClearColors;

		// Token: 0x04003630 RID: 13872
		[Token(Token = "0x4003630")]
		[FieldOffset(Offset = "0x10")]
		private static bool s_UVStartsAtTop;

		// Token: 0x04003631 RID: 13873
		[Token(Token = "0x4003631")]
		[FieldOffset(Offset = "0x11")]
		private static bool s_IsMetal;

		// Token: 0x04003632 RID: 13874
		[Token(Token = "0x4003632")]
		[FieldOffset(Offset = "0x18")]
		private static Shader s_SoftMaskShader;

		// Token: 0x04003633 RID: 13875
		[Token(Token = "0x4003633")]
		[FieldOffset(Offset = "0x20")]
		private static Texture2D s_ReadTexture;

		// Token: 0x04003634 RID: 13876
		[Token(Token = "0x4003634")]
		[FieldOffset(Offset = "0x28")]
		private static readonly List<SoftMask> s_ActiveSoftMasks;

		// Token: 0x04003635 RID: 13877
		[Token(Token = "0x4003635")]
		[FieldOffset(Offset = "0x30")]
		private static readonly List<SoftMask> s_TempRelatables;

		// Token: 0x04003636 RID: 13878
		[Token(Token = "0x4003636")]
		[FieldOffset(Offset = "0x38")]
		private static readonly Dictionary<int, Matrix4x4> s_PreviousViewProjectionMatrices;

		// Token: 0x04003637 RID: 13879
		[Token(Token = "0x4003637")]
		[FieldOffset(Offset = "0x40")]
		private static readonly Dictionary<int, Matrix4x4> s_NowViewProjectionMatrices;

		// Token: 0x04003638 RID: 13880
		[Token(Token = "0x4003638")]
		[FieldOffset(Offset = "0x48")]
		private static int s_StencilCompId;

		// Token: 0x04003639 RID: 13881
		[Token(Token = "0x4003639")]
		[FieldOffset(Offset = "0x4C")]
		private static int s_ColorMaskId;

		// Token: 0x0400363A RID: 13882
		[Token(Token = "0x400363A")]
		[FieldOffset(Offset = "0x50")]
		private static int s_MainTexId;

		// Token: 0x0400363B RID: 13883
		[Token(Token = "0x400363B")]
		[FieldOffset(Offset = "0x54")]
		private static int s_SoftnessId;

		// Token: 0x0400363C RID: 13884
		[Token(Token = "0x400363C")]
		[FieldOffset(Offset = "0x58")]
		private static int s_Alpha;

		// Token: 0x0400363D RID: 13885
		[Token(Token = "0x400363D")]
		[FieldOffset(Offset = "0x5C")]
		private static int s_PreviousWidth;

		// Token: 0x0400363E RID: 13886
		[Token(Token = "0x400363E")]
		[FieldOffset(Offset = "0x60")]
		private static int s_PreviousHeight;

		// Token: 0x0400363F RID: 13887
		[Token(Token = "0x400363F")]
		[FieldOffset(Offset = "0x40")]
		private MaterialPropertyBlock _mpb;

		// Token: 0x04003640 RID: 13888
		[Token(Token = "0x4003640")]
		[FieldOffset(Offset = "0x48")]
		private CommandBuffer _cb;

		// Token: 0x04003641 RID: 13889
		[Token(Token = "0x4003641")]
		[FieldOffset(Offset = "0x50")]
		private RenderTexture _softMaskBuffer;

		// Token: 0x04003642 RID: 13890
		[Token(Token = "0x4003642")]
		[FieldOffset(Offset = "0x58")]
		private int _stencilDepth;

		// Token: 0x04003643 RID: 13891
		[Token(Token = "0x4003643")]
		[FieldOffset(Offset = "0x60")]
		private Mesh _mesh;

		// Token: 0x04003644 RID: 13892
		[Token(Token = "0x4003644")]
		[FieldOffset(Offset = "0x68")]
		private SoftMask _parent;

		// Token: 0x04003645 RID: 13893
		[Token(Token = "0x4003645")]
		[FieldOffset(Offset = "0x70")]
		internal readonly List<SoftMask> _children;

		// Token: 0x04003646 RID: 13894
		[Token(Token = "0x4003646")]
		[FieldOffset(Offset = "0x78")]
		private bool _hasChanged;

		// Token: 0x04003647 RID: 13895
		[Token(Token = "0x4003647")]
		[FieldOffset(Offset = "0x79")]
		private bool _hasStencilStateChanged;

		// Token: 0x04003648 RID: 13896
		[Token(Token = "0x4003648")]
		[FieldOffset(Offset = "0x7C")]
		[Tooltip("The down sampling rate for soft mask buffer.")]
		[SerializeField]
		[FormerlySerializedAs("m_DesamplingRate")]
		private SoftMask.DownSamplingRate m_DownSamplingRate;

		// Token: 0x04003649 RID: 13897
		[Token(Token = "0x4003649")]
		[FieldOffset(Offset = "0x80")]
		[Tooltip("The value used by the soft mask to select the area of influence defined over the soft mask's graphic.")]
		[SerializeField]
		[Range(0f, 1f)]
		private float m_Softness;

		// Token: 0x0400364A RID: 13898
		[Token(Token = "0x400364A")]
		[FieldOffset(Offset = "0x84")]
		[Range(0f, 1f)]
		[Tooltip("The transparency of the whole masked graphic.")]
		[SerializeField]
		private float m_Alpha;

		// Token: 0x0400364B RID: 13899
		[Token(Token = "0x400364B")]
		[FieldOffset(Offset = "0x88")]
		[Tooltip("Should the soft mask ignore parent soft masks?")]
		[SerializeField]
		[Header("Advanced Options")]
		private bool m_IgnoreParent;

		// Token: 0x0400364C RID: 13900
		[Token(Token = "0x400364C")]
		[FieldOffset(Offset = "0x89")]
		[SerializeField]
		[Tooltip("Is the soft mask a part of parent soft mask?")]
		private bool m_PartOfParent;

		// Token: 0x0400364D RID: 13901
		[Token(Token = "0x400364D")]
		[FieldOffset(Offset = "0x8A")]
		[SerializeField]
		[Tooltip("Self graphic will not be drawn to soft mask buffer.")]
		private bool m_IgnoreSelfGraphic;

		// Token: 0x0400364E RID: 13902
		[Token(Token = "0x400364E")]
		[FieldOffset(Offset = "0x8B")]
		[Tooltip("Self graphic will not be written to stencil buffer.")]
		[SerializeField]
		private bool m_IgnoreSelfStencil;

		// Token: 0x0400364F RID: 13903
		[Token(Token = "0x400364F")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Material m_material;

		// Token: 0x04003650 RID: 13904
		[Token(Token = "0x4003650")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Material m_materialable;

		// Token: 0x04003651 RID: 13905
		[Token(Token = "0x4003651")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Material m_materialableGray;

		// Token: 0x02000CBB RID: 3259
		[Token(Token = "0x2000CBB")]
		public enum DownSamplingRate
		{
			// Token: 0x04003653 RID: 13907
			[Token(Token = "0x4003653")]
			None,
			// Token: 0x04003654 RID: 13908
			[Token(Token = "0x4003654")]
			x1,
			// Token: 0x04003655 RID: 13909
			[Token(Token = "0x4003655")]
			x2,
			// Token: 0x04003656 RID: 13910
			[Token(Token = "0x4003656")]
			x4 = 4,
			// Token: 0x04003657 RID: 13911
			[Token(Token = "0x4003657")]
			x8 = 8
		}
	}
}
