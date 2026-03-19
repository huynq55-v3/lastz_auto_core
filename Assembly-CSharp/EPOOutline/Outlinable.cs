using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace EPOOutline
{
	// Token: 0x02000C92 RID: 3218
	[Token(Token = "0x2000C92")]
	[ExecuteAlways]
	public class Outlinable : MonoBehaviour
	{
		// Token: 0x17000AE1 RID: 2785
		// (get) Token: 0x06007A00 RID: 31232 RVA: 0x00053838 File Offset: 0x00051A38
		// (set) Token: 0x06007A01 RID: 31233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AE1")]
		public RenderStyle RenderStyle
		{
			[Token(Token = "0x6007A00")]
			[Address(RVA = "0x1495F34", Offset = "0x1495F34", VA = "0x1495F34")]
			get
			{
				return (RenderStyle)0;
			}
			[Token(Token = "0x6007A01")]
			[Address(RVA = "0x1495F3C", Offset = "0x1495F3C", VA = "0x1495F3C")]
			set
			{
			}
		}

		// Token: 0x17000AE2 RID: 2786
		// (get) Token: 0x06007A02 RID: 31234 RVA: 0x00053850 File Offset: 0x00051A50
		// (set) Token: 0x06007A03 RID: 31235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AE2")]
		public ComplexMaskingMode ComplexMaskingMode
		{
			[Token(Token = "0x6007A02")]
			[Address(RVA = "0x1495F44", Offset = "0x1495F44", VA = "0x1495F44")]
			get
			{
				return ComplexMaskingMode.None;
			}
			[Token(Token = "0x6007A03")]
			[Address(RVA = "0x1495F4C", Offset = "0x1495F4C", VA = "0x1495F4C")]
			set
			{
			}
		}

		// Token: 0x17000AE3 RID: 2787
		// (get) Token: 0x06007A04 RID: 31236 RVA: 0x00053868 File Offset: 0x00051A68
		[Token(Token = "0x17000AE3")]
		public bool ComplexMaskingEnabled
		{
			[Token(Token = "0x6007A04")]
			[Address(RVA = "0x1495F54", Offset = "0x1495F54", VA = "0x1495F54")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000AE4 RID: 2788
		// (get) Token: 0x06007A05 RID: 31237 RVA: 0x00053880 File Offset: 0x00051A80
		// (set) Token: 0x06007A06 RID: 31238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AE4")]
		public OutlinableDrawingMode DrawingMode
		{
			[Token(Token = "0x6007A05")]
			[Address(RVA = "0x1495F64", Offset = "0x1495F64", VA = "0x1495F64")]
			get
			{
				return (OutlinableDrawingMode)0;
			}
			[Token(Token = "0x6007A06")]
			[Address(RVA = "0x1495F6C", Offset = "0x1495F6C", VA = "0x1495F6C")]
			set
			{
			}
		}

		// Token: 0x17000AE5 RID: 2789
		// (get) Token: 0x06007A07 RID: 31239 RVA: 0x00053898 File Offset: 0x00051A98
		// (set) Token: 0x06007A08 RID: 31240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AE5")]
		public int OutlineLayer
		{
			[Token(Token = "0x6007A07")]
			[Address(RVA = "0x1495F74", Offset = "0x1495F74", VA = "0x1495F74")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6007A08")]
			[Address(RVA = "0x1495F7C", Offset = "0x1495F7C", VA = "0x1495F7C")]
			set
			{
			}
		}

		// Token: 0x17000AE6 RID: 2790
		// (get) Token: 0x06007A09 RID: 31241 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AE6")]
		public IReadOnlyList<OutlineTarget> OutlineTargets
		{
			[Token(Token = "0x6007A09")]
			[Address(RVA = "0x1495F84", Offset = "0x1495F84", VA = "0x1495F84")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000AE7 RID: 2791
		// (get) Token: 0x06007A0A RID: 31242 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AE7")]
		public Outlinable.OutlineProperties OutlineParameters
		{
			[Token(Token = "0x6007A0A")]
			[Address(RVA = "0x1495F8C", Offset = "0x1495F8C", VA = "0x1495F8C")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000AE8 RID: 2792
		// (get) Token: 0x06007A0B RID: 31243 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AE8")]
		public Outlinable.OutlineProperties BackParameters
		{
			[Token(Token = "0x6007A0B")]
			[Address(RVA = "0x1495F94", Offset = "0x1495F94", VA = "0x1495F94")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000AE9 RID: 2793
		// (get) Token: 0x06007A0C RID: 31244 RVA: 0x000538B0 File Offset: 0x00051AB0
		[Token(Token = "0x17000AE9")]
		public bool NeedFillMask
		{
			[Token(Token = "0x6007A0C")]
			[Address(RVA = "0x1495F9C", Offset = "0x1495F9C", VA = "0x1495F9C")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000AEA RID: 2794
		// (get) Token: 0x06007A0D RID: 31245 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AEA")]
		public Outlinable.OutlineProperties FrontParameters
		{
			[Token(Token = "0x6007A0D")]
			[Address(RVA = "0x14960A4", Offset = "0x14960A4", VA = "0x14960A4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000AEB RID: 2795
		// (get) Token: 0x06007A0E RID: 31246 RVA: 0x000538C8 File Offset: 0x00051AC8
		[Token(Token = "0x17000AEB")]
		public bool IsObstacle
		{
			[Token(Token = "0x6007A0E")]
			[Address(RVA = "0x14960AC", Offset = "0x14960AC", VA = "0x14960AC")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06007A0F RID: 31247 RVA: 0x000538E0 File Offset: 0x00051AE0
		[Token(Token = "0x6007A0F")]
		[Address(RVA = "0x14960B8", Offset = "0x14960B8", VA = "0x14960B8")]
		public bool TryAddTarget(OutlineTarget target)
		{
			return default(bool);
		}

		// Token: 0x06007A10 RID: 31248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A10")]
		[Address(RVA = "0x14963A8", Offset = "0x14963A8", VA = "0x14963A8")]
		public void RemoveTarget(OutlineTarget target)
		{
		}

		// Token: 0x17000AEC RID: 2796
		[Token(Token = "0x17000AEC")]
		public OutlineTarget this[int index]
		{
			[Token(Token = "0x6007A11")]
			[Address(RVA = "0x1496508", Offset = "0x1496508", VA = "0x1496508")]
			get
			{
				return null;
			}
			[Token(Token = "0x6007A12")]
			[Address(RVA = "0x1496560", Offset = "0x1496560", VA = "0x1496560")]
			set
			{
			}
		}

		// Token: 0x06007A13 RID: 31251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A13")]
		[Address(RVA = "0x14965D0", Offset = "0x14965D0", VA = "0x14965D0")]
		private void Reset()
		{
		}

		// Token: 0x06007A14 RID: 31252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A14")]
		[Address(RVA = "0x1496734", Offset = "0x1496734", VA = "0x1496734")]
		private void OnValidate()
		{
		}

		// Token: 0x06007A15 RID: 31253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A15")]
		[Address(RVA = "0x1496758", Offset = "0x1496758", VA = "0x1496758")]
		private void SubscribeToVisibilityChange(GameObject go)
		{
		}

		// Token: 0x06007A16 RID: 31254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A16")]
		[Address(RVA = "0x14968B8", Offset = "0x14968B8", VA = "0x14968B8")]
		private void UpdateVisibility()
		{
		}

		// Token: 0x06007A17 RID: 31255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A17")]
		[Address(RVA = "0x1496F20", Offset = "0x1496F20", VA = "0x1496F20")]
		private void OnEnable()
		{
		}

		// Token: 0x06007A18 RID: 31256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A18")]
		[Address(RVA = "0x1496F24", Offset = "0x1496F24", VA = "0x1496F24")]
		private void OnDisable()
		{
		}

		// Token: 0x06007A19 RID: 31257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A19")]
		[Address(RVA = "0x1496FA4", Offset = "0x1496FA4", VA = "0x1496FA4")]
		private void Awake()
		{
		}

		// Token: 0x06007A1A RID: 31258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A1A")]
		[Address(RVA = "0x1496174", Offset = "0x1496174", VA = "0x1496174")]
		private void ValidateTargets()
		{
		}

		// Token: 0x06007A1B RID: 31259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A1B")]
		[Address(RVA = "0x1496FA8", Offset = "0x1496FA8", VA = "0x1496FA8")]
		private void OnDestroy()
		{
		}

		// Token: 0x06007A1C RID: 31260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A1C")]
		[Address(RVA = "0x1497028", Offset = "0x1497028", VA = "0x1497028")]
		public static void GetAllActiveOutlinables(Camera camera, List<Outlinable> outlinablesList)
		{
		}

		// Token: 0x06007A1D RID: 31261 RVA: 0x000538F8 File Offset: 0x00051AF8
		[Token(Token = "0x6007A1D")]
		[Address(RVA = "0x1497234", Offset = "0x1497234", VA = "0x1497234")]
		private int GetSubmeshCount(Renderer renderer)
		{
			return 0;
		}

		// Token: 0x06007A1E RID: 31262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A1E")]
		[Address(RVA = "0x14965D8", Offset = "0x14965D8", VA = "0x14965D8")]
		public void AddAllChildRenderersToRenderingList(RenderersAddingMode renderersAddingMode = RenderersAddingMode.All)
		{
		}

		// Token: 0x06007A1F RID: 31263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A1F")]
		[Address(RVA = "0x1497490", Offset = "0x1497490", VA = "0x1497490")]
		private void Update()
		{
		}

		// Token: 0x06007A20 RID: 31264 RVA: 0x00053910 File Offset: 0x00051B10
		[Token(Token = "0x6007A20")]
		[Address(RVA = "0x1497334", Offset = "0x1497334", VA = "0x1497334")]
		private bool MatchingMode(Renderer renderer, RenderersAddingMode mode)
		{
			return default(bool);
		}

		// Token: 0x06007A21 RID: 31265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A21")]
		[Address(RVA = "0x14974A4", Offset = "0x14974A4", VA = "0x14974A4")]
		public Outlinable()
		{
		}

		// Token: 0x0400353F RID: 13631
		[Token(Token = "0x400353F")]
		[FieldOffset(Offset = "0x0")]
		private static List<TargetStateListener> tempListeners;

		// Token: 0x04003540 RID: 13632
		[Token(Token = "0x4003540")]
		[FieldOffset(Offset = "0x8")]
		private static HashSet<Outlinable> outlinables;

		// Token: 0x04003541 RID: 13633
		[Token(Token = "0x4003541")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ComplexMaskingMode complexMaskingMode;

		// Token: 0x04003542 RID: 13634
		[Token(Token = "0x4003542")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private OutlinableDrawingMode drawingMode;

		// Token: 0x04003543 RID: 13635
		[Token(Token = "0x4003543")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private int outlineLayer;

		// Token: 0x04003544 RID: 13636
		[Token(Token = "0x4003544")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<OutlineTarget> outlineTargets;

		// Token: 0x04003545 RID: 13637
		[Token(Token = "0x4003545")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RenderStyle renderStyle;

		// Token: 0x04003546 RID: 13638
		[Token(Token = "0x4003546")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Outlinable.OutlineProperties outlineParameters;

		// Token: 0x04003547 RID: 13639
		[Token(Token = "0x4003547")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Outlinable.OutlineProperties backParameters;

		// Token: 0x04003548 RID: 13640
		[Token(Token = "0x4003548")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Outlinable.OutlineProperties frontParameters;

		// Token: 0x04003549 RID: 13641
		[Token(Token = "0x4003549")]
		[FieldOffset(Offset = "0x50")]
		private bool shouldValidateTargets;

		// Token: 0x02000C93 RID: 3219
		[Token(Token = "0x2000C93")]
		[Serializable]
		public class OutlineProperties
		{
			// Token: 0x17000AED RID: 2797
			// (get) Token: 0x06007A23 RID: 31267 RVA: 0x00053928 File Offset: 0x00051B28
			// (set) Token: 0x06007A24 RID: 31268 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000AED")]
			public bool Enabled
			{
				[Token(Token = "0x6007A23")]
				[Address(RVA = "0x1497740", Offset = "0x1497740", VA = "0x1497740")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6007A24")]
				[Address(RVA = "0x1497748", Offset = "0x1497748", VA = "0x1497748")]
				set
				{
				}
			}

			// Token: 0x17000AEE RID: 2798
			// (get) Token: 0x06007A25 RID: 31269 RVA: 0x00053940 File Offset: 0x00051B40
			// (set) Token: 0x06007A26 RID: 31270 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000AEE")]
			public Color Color
			{
				[Token(Token = "0x6007A25")]
				[Address(RVA = "0x1497754", Offset = "0x1497754", VA = "0x1497754")]
				get
				{
					return default(Color);
				}
				[Token(Token = "0x6007A26")]
				[Address(RVA = "0x1497760", Offset = "0x1497760", VA = "0x1497760")]
				set
				{
				}
			}

			// Token: 0x17000AEF RID: 2799
			// (get) Token: 0x06007A27 RID: 31271 RVA: 0x00053958 File Offset: 0x00051B58
			// (set) Token: 0x06007A28 RID: 31272 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000AEF")]
			public float DilateShift
			{
				[Token(Token = "0x6007A27")]
				[Address(RVA = "0x149776C", Offset = "0x149776C", VA = "0x149776C")]
				get
				{
					return 0f;
				}
				[Token(Token = "0x6007A28")]
				[Address(RVA = "0x1497774", Offset = "0x1497774", VA = "0x1497774")]
				set
				{
				}
			}

			// Token: 0x17000AF0 RID: 2800
			// (get) Token: 0x06007A29 RID: 31273 RVA: 0x00053970 File Offset: 0x00051B70
			// (set) Token: 0x06007A2A RID: 31274 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000AF0")]
			public float BlurShift
			{
				[Token(Token = "0x6007A29")]
				[Address(RVA = "0x149777C", Offset = "0x149777C", VA = "0x149777C")]
				get
				{
					return 0f;
				}
				[Token(Token = "0x6007A2A")]
				[Address(RVA = "0x1497784", Offset = "0x1497784", VA = "0x1497784")]
				set
				{
				}
			}

			// Token: 0x17000AF1 RID: 2801
			// (get) Token: 0x06007A2B RID: 31275 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000AF1")]
			public SerializedPass FillPass
			{
				[Token(Token = "0x6007A2B")]
				[Address(RVA = "0x149778C", Offset = "0x149778C", VA = "0x149778C")]
				get
				{
					return null;
				}
			}

			// Token: 0x06007A2C RID: 31276 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007A2C")]
			[Address(RVA = "0x14975C4", Offset = "0x14975C4", VA = "0x14975C4")]
			public OutlineProperties()
			{
			}

			// Token: 0x0400354A RID: 13642
			[Token(Token = "0x400354A")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private bool enabled;

			// Token: 0x0400354B RID: 13643
			[Token(Token = "0x400354B")]
			[FieldOffset(Offset = "0x14")]
			[SerializeField]
			private Color color;

			// Token: 0x0400354C RID: 13644
			[Token(Token = "0x400354C")]
			[FieldOffset(Offset = "0x24")]
			[Range(0f, 1f)]
			[SerializeField]
			private float dilateShift;

			// Token: 0x0400354D RID: 13645
			[Token(Token = "0x400354D")]
			[FieldOffset(Offset = "0x28")]
			[Range(0f, 1f)]
			[SerializeField]
			private float blurShift;

			// Token: 0x0400354E RID: 13646
			[Token(Token = "0x400354E")]
			[FieldOffset(Offset = "0x30")]
			[SerializeField]
			[SerializedPassInfo("Fill style", "Hidden/EPO/Fill/")]
			private SerializedPass fillPass;
		}
	}
}
