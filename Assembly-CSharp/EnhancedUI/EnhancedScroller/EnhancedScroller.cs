using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace EnhancedUI.EnhancedScroller
{
	// Token: 0x020004D0 RID: 1232
	[Token(Token = "0x20004D0")]
	[RequireComponent(typeof(ScrollRect))]
	public class EnhancedScroller : MonoBehaviour
	{
		// Token: 0x170005A1 RID: 1441
		// (get) Token: 0x06002516 RID: 9494 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002517 RID: 9495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005A1")]
		public IEnhancedScrollerDelegate Delegate
		{
			[Token(Token = "0x6002516")]
			[Address(RVA = "0x2CAC538", Offset = "0x2CAC538", VA = "0x2CAC538")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002517")]
			[Address(RVA = "0x2CAC540", Offset = "0x2CAC540", VA = "0x2CAC540")]
			set
			{
			}
		}

		// Token: 0x170005A2 RID: 1442
		// (get) Token: 0x06002518 RID: 9496 RVA: 0x0000DFE0 File Offset: 0x0000C1E0
		// (set) Token: 0x06002519 RID: 9497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005A2")]
		public float ScrollPosition
		{
			[Token(Token = "0x6002518")]
			[Address(RVA = "0x2CAC564", Offset = "0x2CAC564", VA = "0x2CAC564")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6002519")]
			[Address(RVA = "0x2CAC56C", Offset = "0x2CAC56C", VA = "0x2CAC56C")]
			set
			{
			}
		}

		// Token: 0x170005A3 RID: 1443
		// (get) Token: 0x0600251A RID: 9498 RVA: 0x0000DFF8 File Offset: 0x0000C1F8
		[Token(Token = "0x170005A3")]
		public float ScrollSize
		{
			[Token(Token = "0x600251A")]
			[Address(RVA = "0x2CAC758", Offset = "0x2CAC758", VA = "0x2CAC758")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170005A4 RID: 1444
		// (get) Token: 0x0600251B RID: 9499 RVA: 0x0000E010 File Offset: 0x0000C210
		[Token(Token = "0x170005A4")]
		public float NormalizedScrollPosition
		{
			[Token(Token = "0x600251B")]
			[Address(RVA = "0x2CAC818", Offset = "0x2CAC818", VA = "0x2CAC818")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170005A5 RID: 1445
		// (get) Token: 0x0600251C RID: 9500 RVA: 0x0000E028 File Offset: 0x0000C228
		// (set) Token: 0x0600251D RID: 9501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005A5")]
		public bool Loop
		{
			[Token(Token = "0x600251C")]
			[Address(RVA = "0x2CAC844", Offset = "0x2CAC844", VA = "0x2CAC844")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600251D")]
			[Address(RVA = "0x2CAC84C", Offset = "0x2CAC84C", VA = "0x2CAC84C")]
			set
			{
			}
		}

		// Token: 0x170005A6 RID: 1446
		// (get) Token: 0x0600251E RID: 9502 RVA: 0x0000E040 File Offset: 0x0000C240
		// (set) Token: 0x0600251F RID: 9503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005A6")]
		public EnhancedScroller.ScrollbarVisibilityEnum ScrollbarVisibility
		{
			[Token(Token = "0x600251E")]
			[Address(RVA = "0x2CACCD8", Offset = "0x2CACCD8", VA = "0x2CACCD8")]
			get
			{
				return EnhancedScroller.ScrollbarVisibilityEnum.OnlyIfNeeded;
			}
			[Token(Token = "0x600251F")]
			[Address(RVA = "0x2CACBAC", Offset = "0x2CACBAC", VA = "0x2CACBAC")]
			set
			{
			}
		}

		// Token: 0x170005A7 RID: 1447
		// (get) Token: 0x06002520 RID: 9504 RVA: 0x0000E058 File Offset: 0x0000C258
		// (set) Token: 0x06002521 RID: 9505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005A7")]
		public Vector2 Velocity
		{
			[Token(Token = "0x6002520")]
			[Address(RVA = "0x2CACD34", Offset = "0x2CACD34", VA = "0x2CACD34")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6002521")]
			[Address(RVA = "0x2CACD50", Offset = "0x2CACD50", VA = "0x2CACD50")]
			set
			{
			}
		}

		// Token: 0x170005A8 RID: 1448
		// (get) Token: 0x06002522 RID: 9506 RVA: 0x0000E070 File Offset: 0x0000C270
		// (set) Token: 0x06002523 RID: 9507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005A8")]
		public float LinearVelocity
		{
			[Token(Token = "0x6002522")]
			[Address(RVA = "0x2CACD6C", Offset = "0x2CACD6C", VA = "0x2CACD6C")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6002523")]
			[Address(RVA = "0x2CACD9C", Offset = "0x2CACD9C", VA = "0x2CACD9C")]
			set
			{
			}
		}

		// Token: 0x170005A9 RID: 1449
		// (get) Token: 0x06002524 RID: 9508 RVA: 0x0000E088 File Offset: 0x0000C288
		// (set) Token: 0x06002525 RID: 9509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005A9")]
		public bool IsScrolling
		{
			[Token(Token = "0x6002524")]
			[Address(RVA = "0x2CACDD0", Offset = "0x2CACDD0", VA = "0x2CACDD0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002525")]
			[Address(RVA = "0x2CACDD8", Offset = "0x2CACDD8", VA = "0x2CACDD8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170005AA RID: 1450
		// (get) Token: 0x06002526 RID: 9510 RVA: 0x0000E0A0 File Offset: 0x0000C2A0
		// (set) Token: 0x06002527 RID: 9511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005AA")]
		public bool IsTweening
		{
			[Token(Token = "0x6002526")]
			[Address(RVA = "0x2CACDE4", Offset = "0x2CACDE4", VA = "0x2CACDE4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002527")]
			[Address(RVA = "0x2CACDEC", Offset = "0x2CACDEC", VA = "0x2CACDEC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170005AB RID: 1451
		// (get) Token: 0x06002528 RID: 9512 RVA: 0x0000E0B8 File Offset: 0x0000C2B8
		[Token(Token = "0x170005AB")]
		public int StartCellViewIndex
		{
			[Token(Token = "0x6002528")]
			[Address(RVA = "0x2CACDF8", Offset = "0x2CACDF8", VA = "0x2CACDF8")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170005AC RID: 1452
		// (get) Token: 0x06002529 RID: 9513 RVA: 0x0000E0D0 File Offset: 0x0000C2D0
		[Token(Token = "0x170005AC")]
		public int EndCellViewIndex
		{
			[Token(Token = "0x6002529")]
			[Address(RVA = "0x2CACE00", Offset = "0x2CACE00", VA = "0x2CACE00")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170005AD RID: 1453
		// (get) Token: 0x0600252A RID: 9514 RVA: 0x0000E0E8 File Offset: 0x0000C2E8
		[Token(Token = "0x170005AD")]
		public int StartDataIndex
		{
			[Token(Token = "0x600252A")]
			[Address(RVA = "0x2CACE08", Offset = "0x2CACE08", VA = "0x2CACE08")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170005AE RID: 1454
		// (get) Token: 0x0600252B RID: 9515 RVA: 0x0000E100 File Offset: 0x0000C300
		[Token(Token = "0x170005AE")]
		public int EndDataIndex
		{
			[Token(Token = "0x600252B")]
			[Address(RVA = "0x2CACED4", Offset = "0x2CACED4", VA = "0x2CACED4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170005AF RID: 1455
		// (get) Token: 0x0600252C RID: 9516 RVA: 0x0000E118 File Offset: 0x0000C318
		[Token(Token = "0x170005AF")]
		public int NumberOfCells
		{
			[Token(Token = "0x600252C")]
			[Address(RVA = "0x2CACE24", Offset = "0x2CACE24", VA = "0x2CACE24")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170005B0 RID: 1456
		// (get) Token: 0x0600252D RID: 9517 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005B0")]
		public ScrollRect ScrollRect
		{
			[Token(Token = "0x600252D")]
			[Address(RVA = "0x2CACEF0", Offset = "0x2CACEF0", VA = "0x2CACEF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005B1 RID: 1457
		// (get) Token: 0x0600252E RID: 9518 RVA: 0x0000E130 File Offset: 0x0000C330
		[Token(Token = "0x170005B1")]
		public float ScrollRectSize
		{
			[Token(Token = "0x600252E")]
			[Address(RVA = "0x2CACCE0", Offset = "0x2CACCE0", VA = "0x2CACCE0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x0600252F RID: 9519 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600252F")]
		[Address(RVA = "0x2CACEF8", Offset = "0x2CACEF8", VA = "0x2CACEF8")]
		public EnhancedScrollerCellView GetCellView(EnhancedScrollerCellView cellPrefab)
		{
			return null;
		}

		// Token: 0x06002530 RID: 9520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002530")]
		[Address(RVA = "0x2CAD1C0", Offset = "0x2CAD1C0", VA = "0x2CAD1C0")]
		public void ReloadData(float scrollPositionFactor = 0f)
		{
		}

		// Token: 0x06002531 RID: 9521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002531")]
		[Address(RVA = "0x2CAD3B0", Offset = "0x2CAD3B0", VA = "0x2CAD3B0")]
		public void RefreshActiveCellViews()
		{
		}

		// Token: 0x06002532 RID: 9522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002532")]
		[Address(RVA = "0x2CAD434", Offset = "0x2CAD434", VA = "0x2CAD434")]
		public void ClearAll()
		{
		}

		// Token: 0x06002533 RID: 9523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002533")]
		[Address(RVA = "0x2CAD44C", Offset = "0x2CAD44C", VA = "0x2CAD44C")]
		public void ClearActive()
		{
		}

		// Token: 0x06002534 RID: 9524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002534")]
		[Address(RVA = "0x2CAD52C", Offset = "0x2CAD52C", VA = "0x2CAD52C")]
		public void ClearRecycled()
		{
		}

		// Token: 0x06002535 RID: 9525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002535")]
		[Address(RVA = "0x2CAD60C", Offset = "0x2CAD60C", VA = "0x2CAD60C")]
		public void ToggleLoop()
		{
		}

		// Token: 0x06002536 RID: 9526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002536")]
		[Address(RVA = "0x2CAD61C", Offset = "0x2CAD61C", VA = "0x2CAD61C")]
		public void JumpToDataIndex(int dataIndex, float scrollerOffset = 0f, float cellOffset = 0f, bool useSpacing = true, EnhancedScroller.TweenType tweenType = EnhancedScroller.TweenType.immediate, float tweenTime = 0f, [Optional] Action jumpComplete, EnhancedScroller.LoopJumpDirectionEnum loopJumpDirection = EnhancedScroller.LoopJumpDirectionEnum.Closest)
		{
		}

		// Token: 0x06002537 RID: 9527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002537")]
		[Address(RVA = "0x2CADAD4", Offset = "0x2CADAD4", VA = "0x2CADAD4")]
		public void Snap()
		{
		}

		// Token: 0x06002538 RID: 9528 RVA: 0x0000E148 File Offset: 0x0000C348
		[Token(Token = "0x6002538")]
		[Address(RVA = "0x2CAC624", Offset = "0x2CAC624", VA = "0x2CAC624")]
		public float GetScrollPositionForCellViewIndex(int cellViewIndex, EnhancedScroller.CellViewPositionEnum insertPosition)
		{
			return 0f;
		}

		// Token: 0x06002539 RID: 9529 RVA: 0x0000E160 File Offset: 0x0000C360
		[Token(Token = "0x6002539")]
		[Address(RVA = "0x2CAD934", Offset = "0x2CAD934", VA = "0x2CAD934")]
		public float GetScrollPositionForDataIndex(int dataIndex, EnhancedScroller.CellViewPositionEnum insertPosition)
		{
			return 0f;
		}

		// Token: 0x0600253A RID: 9530 RVA: 0x0000E178 File Offset: 0x0000C378
		[Token(Token = "0x600253A")]
		[Address(RVA = "0x2CADC3C", Offset = "0x2CADC3C", VA = "0x2CADC3C")]
		public int GetCellViewIndexAtPosition(float position)
		{
			return 0;
		}

		// Token: 0x0600253B RID: 9531 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600253B")]
		[Address(RVA = "0x2CADD3C", Offset = "0x2CADD3C", VA = "0x2CADD3C")]
		public EnhancedScrollerCellView GetCellViewAtDataIndex(int dataIndex)
		{
			return null;
		}

		// Token: 0x0600253C RID: 9532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600253C")]
		[Address(RVA = "0x2CAC8B8", Offset = "0x2CAC8B8", VA = "0x2CAC8B8")]
		private void _Resize(bool keepPosition)
		{
		}

		// Token: 0x0600253D RID: 9533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600253D")]
		[Address(RVA = "0x2CAE390", Offset = "0x2CAE390", VA = "0x2CAE390")]
		private void _UpdateSpacing(float spacing)
		{
		}

		// Token: 0x0600253E RID: 9534 RVA: 0x0000E190 File Offset: 0x0000C390
		[Token(Token = "0x600253E")]
		[Address(RVA = "0x2CADDF4", Offset = "0x2CADDF4", VA = "0x2CADDF4")]
		private float _AddCellViewSizes()
		{
			return 0f;
		}

		// Token: 0x0600253F RID: 9535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600253F")]
		[Address(RVA = "0x2CADF6C", Offset = "0x2CADF6C", VA = "0x2CADF6C")]
		private void _DuplicateCellViewSizes(int numberOfTimes, int cellCount)
		{
		}

		// Token: 0x06002540 RID: 9536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002540")]
		[Address(RVA = "0x2CAE050", Offset = "0x2CAE050", VA = "0x2CAE050")]
		private void _CalculateCellViewOffsets()
		{
		}

		// Token: 0x06002541 RID: 9537 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002541")]
		[Address(RVA = "0x2CAD0E8", Offset = "0x2CAD0E8", VA = "0x2CAD0E8")]
		private EnhancedScrollerCellView _GetRecycledCellView(EnhancedScrollerCellView cellPrefab)
		{
			return null;
		}

		// Token: 0x06002542 RID: 9538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002542")]
		[Address(RVA = "0x2CAE128", Offset = "0x2CAE128", VA = "0x2CAE128")]
		private void _ResetVisibleCellViews()
		{
		}

		// Token: 0x06002543 RID: 9539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002543")]
		[Address(RVA = "0x2CAD334", Offset = "0x2CAD334", VA = "0x2CAD334")]
		private void _RecycleAllCells()
		{
		}

		// Token: 0x06002544 RID: 9540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002544")]
		[Address(RVA = "0x2CAE484", Offset = "0x2CAE484", VA = "0x2CAE484")]
		private void _RecycleCell(EnhancedScrollerCellView cellView)
		{
		}

		// Token: 0x06002545 RID: 9541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002545")]
		[Address(RVA = "0x2CAE570", Offset = "0x2CAE570", VA = "0x2CAE570")]
		private void _AddCellView(int cellIndex, EnhancedScroller.ListPositionEnum listPosition)
		{
		}

		// Token: 0x06002546 RID: 9542 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002546")]
		[Address(RVA = "0x2CAE8EC", Offset = "0x2CAE8EC", VA = "0x2CAE8EC")]
		private void _SetPadders()
		{
		}

		// Token: 0x06002547 RID: 9543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002547")]
		[Address(RVA = "0x2CAEB3C", Offset = "0x2CAEB3C", VA = "0x2CAEB3C")]
		private void _RefreshActive()
		{
		}

		// Token: 0x06002548 RID: 9544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002548")]
		[Address(RVA = "0x2CAE3E0", Offset = "0x2CAE3E0", VA = "0x2CAE3E0")]
		private void _CalculateCurrentActiveCellRange(out int startIndex, out int endIndex)
		{
		}

		// Token: 0x06002549 RID: 9545 RVA: 0x0000E1A8 File Offset: 0x0000C3A8
		[Token(Token = "0x6002549")]
		[Address(RVA = "0x2CADC60", Offset = "0x2CADC60", VA = "0x2CADC60")]
		private int _GetCellIndexAtPosition(float position, int startIndex, int endIndex)
		{
			return 0;
		}

		// Token: 0x0600254A RID: 9546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600254A")]
		[Address(RVA = "0x2CAEC30", Offset = "0x2CAEC30", VA = "0x2CAEC30")]
		private void Awake()
		{
		}

		// Token: 0x0600254B RID: 9547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600254B")]
		[Address(RVA = "0x2CAF5BC", Offset = "0x2CAF5BC", VA = "0x2CAF5BC")]
		private void Update()
		{
		}

		// Token: 0x0600254C RID: 9548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600254C")]
		[Address(RVA = "0x2CAF6FC", Offset = "0x2CAF6FC", VA = "0x2CAF6FC")]
		private void OnValidate()
		{
		}

		// Token: 0x0600254D RID: 9549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600254D")]
		[Address(RVA = "0x2CAF734", Offset = "0x2CAF734", VA = "0x2CAF734")]
		private void OnEnable()
		{
		}

		// Token: 0x0600254E RID: 9550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600254E")]
		[Address(RVA = "0x2CAF7DC", Offset = "0x2CAF7DC", VA = "0x2CAF7DC")]
		private void OnDisable()
		{
		}

		// Token: 0x0600254F RID: 9551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600254F")]
		[Address(RVA = "0x2CAF884", Offset = "0x2CAF884", VA = "0x2CAF884")]
		private void _ScrollRect_OnValueChanged(Vector2 val)
		{
		}

		// Token: 0x06002550 RID: 9552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002550")]
		[Address(RVA = "0x2CAF9BC", Offset = "0x2CAF9BC", VA = "0x2CAF9BC")]
		private void SnapJumpComplete()
		{
		}

		// Token: 0x06002551 RID: 9553 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002551")]
		[Address(RVA = "0x2CADA18", Offset = "0x2CADA18", VA = "0x2CADA18")]
		private IEnumerator TweenPosition(EnhancedScroller.TweenType tweenType, float time, float start, float end, Action tweenComplete)
		{
			return null;
		}

		// Token: 0x06002552 RID: 9554 RVA: 0x0000E1C0 File Offset: 0x0000C3C0
		[Token(Token = "0x6002552")]
		[Address(RVA = "0x2CAFAA8", Offset = "0x2CAFAA8", VA = "0x2CAFAA8")]
		private float linear(float start, float end, float val)
		{
			return 0f;
		}

		// Token: 0x06002553 RID: 9555 RVA: 0x0000E1D8 File Offset: 0x0000C3D8
		[Token(Token = "0x6002553")]
		[Address(RVA = "0x2CAFACC", Offset = "0x2CAFACC", VA = "0x2CAFACC")]
		private static float spring(float start, float end, float val)
		{
			return 0f;
		}

		// Token: 0x06002554 RID: 9556 RVA: 0x0000E1F0 File Offset: 0x0000C3F0
		[Token(Token = "0x6002554")]
		[Address(RVA = "0x2CAFB7C", Offset = "0x2CAFB7C", VA = "0x2CAFB7C")]
		private static float easeInQuad(float start, float end, float val)
		{
			return 0f;
		}

		// Token: 0x06002555 RID: 9557 RVA: 0x0000E208 File Offset: 0x0000C408
		[Token(Token = "0x6002555")]
		[Address(RVA = "0x2CAFB90", Offset = "0x2CAFB90", VA = "0x2CAFB90")]
		private static float easeOutQuad(float start, float end, float val)
		{
			return 0f;
		}

		// Token: 0x06002556 RID: 9558 RVA: 0x0000E220 File Offset: 0x0000C420
		[Token(Token = "0x6002556")]
		[Address(RVA = "0x2CAFBAC", Offset = "0x2CAFBAC", VA = "0x2CAFBAC")]
		private static float easeInOutQuad(float start, float end, float val)
		{
			return 0f;
		}

		// Token: 0x06002557 RID: 9559 RVA: 0x0000E238 File Offset: 0x0000C438
		[Token(Token = "0x6002557")]
		[Address(RVA = "0x2CAFC00", Offset = "0x2CAFC00", VA = "0x2CAFC00")]
		private static float easeInCubic(float start, float end, float val)
		{
			return 0f;
		}

		// Token: 0x06002558 RID: 9560 RVA: 0x0000E250 File Offset: 0x0000C450
		[Token(Token = "0x6002558")]
		[Address(RVA = "0x2CAFC18", Offset = "0x2CAFC18", VA = "0x2CAFC18")]
		private static float easeOutCubic(float start, float end, float val)
		{
			return 0f;
		}

		// Token: 0x06002559 RID: 9561 RVA: 0x0000E268 File Offset: 0x0000C468
		[Token(Token = "0x6002559")]
		[Address(RVA = "0x2CAFC40", Offset = "0x2CAFC40", VA = "0x2CAFC40")]
		private static float easeInOutCubic(float start, float end, float val)
		{
			return 0f;
		}

		// Token: 0x0600255A RID: 9562 RVA: 0x0000E280 File Offset: 0x0000C480
		[Token(Token = "0x600255A")]
		[Address(RVA = "0x2CAFC98", Offset = "0x2CAFC98", VA = "0x2CAFC98")]
		private static float easeInQuart(float start, float end, float val)
		{
			return 0f;
		}

		// Token: 0x0600255B RID: 9563 RVA: 0x0000E298 File Offset: 0x0000C498
		[Token(Token = "0x600255B")]
		[Address(RVA = "0x2CAFCB4", Offset = "0x2CAFCB4", VA = "0x2CAFCB4")]
		private static float easeOutQuart(float start, float end, float val)
		{
			return 0f;
		}

		// Token: 0x0600255C RID: 9564 RVA: 0x0000E2B0 File Offset: 0x0000C4B0
		[Token(Token = "0x600255C")]
		[Address(RVA = "0x2CAFCDC", Offset = "0x2CAFCDC", VA = "0x2CAFCDC")]
		private static float easeInOutQuart(float start, float end, float val)
		{
			return 0f;
		}

		// Token: 0x0600255D RID: 9565 RVA: 0x0000E2C8 File Offset: 0x0000C4C8
		[Token(Token = "0x600255D")]
		[Address(RVA = "0x2CAFD38", Offset = "0x2CAFD38", VA = "0x2CAFD38")]
		private static float easeInQuint(float start, float end, float val)
		{
			return 0f;
		}

		// Token: 0x0600255E RID: 9566 RVA: 0x0000E2E0 File Offset: 0x0000C4E0
		[Token(Token = "0x600255E")]
		[Address(RVA = "0x2CAFD58", Offset = "0x2CAFD58", VA = "0x2CAFD58")]
		private static float easeOutQuint(float start, float end, float val)
		{
			return 0f;
		}

		// Token: 0x0600255F RID: 9567 RVA: 0x0000E2F8 File Offset: 0x0000C4F8
		[Token(Token = "0x600255F")]
		[Address(RVA = "0x2CAFD88", Offset = "0x2CAFD88", VA = "0x2CAFD88")]
		private static float easeInOutQuint(float start, float end, float val)
		{
			return 0f;
		}

		// Token: 0x06002560 RID: 9568 RVA: 0x0000E310 File Offset: 0x0000C510
		[Token(Token = "0x6002560")]
		[Address(RVA = "0x2CAFDF0", Offset = "0x2CAFDF0", VA = "0x2CAFDF0")]
		private static float easeInSine(float start, float end, float val)
		{
			return 0f;
		}

		// Token: 0x06002561 RID: 9569 RVA: 0x0000E328 File Offset: 0x0000C528
		[Token(Token = "0x6002561")]
		[Address(RVA = "0x2CAFE28", Offset = "0x2CAFE28", VA = "0x2CAFE28")]
		private static float easeOutSine(float start, float end, float val)
		{
			return 0f;
		}

		// Token: 0x06002562 RID: 9570 RVA: 0x0000E340 File Offset: 0x0000C540
		[Token(Token = "0x6002562")]
		[Address(RVA = "0x2CAFE5C", Offset = "0x2CAFE5C", VA = "0x2CAFE5C")]
		private static float easeInOutSine(float start, float end, float val)
		{
			return 0f;
		}

		// Token: 0x06002563 RID: 9571 RVA: 0x0000E358 File Offset: 0x0000C558
		[Token(Token = "0x6002563")]
		[Address(RVA = "0x2CAFEA0", Offset = "0x2CAFEA0", VA = "0x2CAFEA0")]
		private static float easeInExpo(float start, float end, float val)
		{
			return 0f;
		}

		// Token: 0x06002564 RID: 9572 RVA: 0x0000E370 File Offset: 0x0000C570
		[Token(Token = "0x6002564")]
		[Address(RVA = "0x2CAFED8", Offset = "0x2CAFED8", VA = "0x2CAFED8")]
		private static float easeOutExpo(float start, float end, float val)
		{
			return 0f;
		}

		// Token: 0x06002565 RID: 9573 RVA: 0x0000E388 File Offset: 0x0000C588
		[Token(Token = "0x6002565")]
		[Address(RVA = "0x2CAFF10", Offset = "0x2CAFF10", VA = "0x2CAFF10")]
		private static float easeInOutExpo(float start, float end, float val)
		{
			return 0f;
		}

		// Token: 0x06002566 RID: 9574 RVA: 0x0000E3A0 File Offset: 0x0000C5A0
		[Token(Token = "0x6002566")]
		[Address(RVA = "0x2CAFF80", Offset = "0x2CAFF80", VA = "0x2CAFF80")]
		private static float easeInCirc(float start, float end, float val)
		{
			return 0f;
		}

		// Token: 0x06002567 RID: 9575 RVA: 0x0000E3B8 File Offset: 0x0000C5B8
		[Token(Token = "0x6002567")]
		[Address(RVA = "0x2CAFFA8", Offset = "0x2CAFFA8", VA = "0x2CAFFA8")]
		private static float easeOutCirc(float start, float end, float val)
		{
			return 0f;
		}

		// Token: 0x06002568 RID: 9576 RVA: 0x0000E3D0 File Offset: 0x0000C5D0
		[Token(Token = "0x6002568")]
		[Address(RVA = "0x2CAFFD0", Offset = "0x2CAFFD0", VA = "0x2CAFFD0")]
		private static float easeInOutCirc(float start, float end, float val)
		{
			return 0f;
		}

		// Token: 0x06002569 RID: 9577 RVA: 0x0000E3E8 File Offset: 0x0000C5E8
		[Token(Token = "0x6002569")]
		[Address(RVA = "0x2CB0024", Offset = "0x2CB0024", VA = "0x2CB0024")]
		private static float easeInBounce(float start, float end, float val)
		{
			return 0f;
		}

		// Token: 0x0600256A RID: 9578 RVA: 0x0000E400 File Offset: 0x0000C600
		[Token(Token = "0x600256A")]
		[Address(RVA = "0x2CB005C", Offset = "0x2CB005C", VA = "0x2CB005C")]
		private static float easeOutBounce(float start, float end, float val)
		{
			return 0f;
		}

		// Token: 0x0600256B RID: 9579 RVA: 0x0000E418 File Offset: 0x0000C618
		[Token(Token = "0x600256B")]
		[Address(RVA = "0x2CB0124", Offset = "0x2CB0124", VA = "0x2CB0124")]
		private static float easeInOutBounce(float start, float end, float val)
		{
			return 0f;
		}

		// Token: 0x0600256C RID: 9580 RVA: 0x0000E430 File Offset: 0x0000C630
		[Token(Token = "0x600256C")]
		[Address(RVA = "0x2CB01A4", Offset = "0x2CB01A4", VA = "0x2CB01A4")]
		private static float easeInBack(float start, float end, float val)
		{
			return 0f;
		}

		// Token: 0x0600256D RID: 9581 RVA: 0x0000E448 File Offset: 0x0000C648
		[Token(Token = "0x600256D")]
		[Address(RVA = "0x2CB01D4", Offset = "0x2CB01D4", VA = "0x2CB01D4")]
		private static float easeOutBack(float start, float end, float val)
		{
			return 0f;
		}

		// Token: 0x0600256E RID: 9582 RVA: 0x0000E460 File Offset: 0x0000C660
		[Token(Token = "0x600256E")]
		[Address(RVA = "0x2CB0214", Offset = "0x2CB0214", VA = "0x2CB0214")]
		private static float easeInOutBack(float start, float end, float val)
		{
			return 0f;
		}

		// Token: 0x0600256F RID: 9583 RVA: 0x0000E478 File Offset: 0x0000C678
		[Token(Token = "0x600256F")]
		[Address(RVA = "0x2CB0298", Offset = "0x2CB0298", VA = "0x2CB0298")]
		private static float easeInElastic(float start, float end, float val)
		{
			return 0f;
		}

		// Token: 0x06002570 RID: 9584 RVA: 0x0000E490 File Offset: 0x0000C690
		[Token(Token = "0x6002570")]
		[Address(RVA = "0x2CB0328", Offset = "0x2CB0328", VA = "0x2CB0328")]
		private static float easeOutElastic(float start, float end, float val)
		{
			return 0f;
		}

		// Token: 0x06002571 RID: 9585 RVA: 0x0000E4A8 File Offset: 0x0000C6A8
		[Token(Token = "0x6002571")]
		[Address(RVA = "0x2CB03B8", Offset = "0x2CB03B8", VA = "0x2CB03B8")]
		private static float easeInOutElastic(float start, float end, float val)
		{
			return 0f;
		}

		// Token: 0x06002572 RID: 9586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002572")]
		[Address(RVA = "0x2CB04B4", Offset = "0x2CB04B4", VA = "0x2CB04B4")]
		public EnhancedScroller()
		{
		}

		// Token: 0x040021EE RID: 8686
		[Token(Token = "0x40021EE")]
		[FieldOffset(Offset = "0x18")]
		public EnhancedScroller.ScrollDirectionEnum scrollDirection;

		// Token: 0x040021EF RID: 8687
		[Token(Token = "0x40021EF")]
		[FieldOffset(Offset = "0x1C")]
		public float spacing;

		// Token: 0x040021F0 RID: 8688
		[Token(Token = "0x40021F0")]
		[FieldOffset(Offset = "0x20")]
		public RectOffset padding;

		// Token: 0x040021F1 RID: 8689
		[Token(Token = "0x40021F1")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool loop;

		// Token: 0x040021F2 RID: 8690
		[Token(Token = "0x40021F2")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private EnhancedScroller.ScrollbarVisibilityEnum scrollbarVisibility;

		// Token: 0x040021F3 RID: 8691
		[Token(Token = "0x40021F3")]
		[FieldOffset(Offset = "0x30")]
		public bool snapping;

		// Token: 0x040021F4 RID: 8692
		[Token(Token = "0x40021F4")]
		[FieldOffset(Offset = "0x34")]
		public float snapVelocityThreshold;

		// Token: 0x040021F5 RID: 8693
		[Token(Token = "0x40021F5")]
		[FieldOffset(Offset = "0x38")]
		public float snapWatchOffset;

		// Token: 0x040021F6 RID: 8694
		[Token(Token = "0x40021F6")]
		[FieldOffset(Offset = "0x3C")]
		public float snapJumpToOffset;

		// Token: 0x040021F7 RID: 8695
		[Token(Token = "0x40021F7")]
		[FieldOffset(Offset = "0x40")]
		public float snapCellCenterOffset;

		// Token: 0x040021F8 RID: 8696
		[Token(Token = "0x40021F8")]
		[FieldOffset(Offset = "0x44")]
		public bool snapUseCellSpacing;

		// Token: 0x040021F9 RID: 8697
		[Token(Token = "0x40021F9")]
		[FieldOffset(Offset = "0x48")]
		public EnhancedScroller.TweenType snapTweenType;

		// Token: 0x040021FA RID: 8698
		[Token(Token = "0x40021FA")]
		[FieldOffset(Offset = "0x4C")]
		public float snapTweenTime;

		// Token: 0x040021FB RID: 8699
		[Token(Token = "0x40021FB")]
		[FieldOffset(Offset = "0x50")]
		public CellViewVisibilityChangedDelegate cellViewVisibilityChanged;

		// Token: 0x040021FC RID: 8700
		[Token(Token = "0x40021FC")]
		[FieldOffset(Offset = "0x58")]
		public CellViewWillRecycleDelegate cellViewWillRecycle;

		// Token: 0x040021FD RID: 8701
		[Token(Token = "0x40021FD")]
		[FieldOffset(Offset = "0x60")]
		public ScrollerScrolledDelegate scrollerScrolled;

		// Token: 0x040021FE RID: 8702
		[Token(Token = "0x40021FE")]
		[FieldOffset(Offset = "0x68")]
		public ScrollerSnappedDelegate scrollerSnapped;

		// Token: 0x040021FF RID: 8703
		[Token(Token = "0x40021FF")]
		[FieldOffset(Offset = "0x70")]
		public ScrollerScrollingChangedDelegate scrollerScrollingChanged;

		// Token: 0x04002200 RID: 8704
		[Token(Token = "0x4002200")]
		[FieldOffset(Offset = "0x78")]
		public ScrollerTweeningChangedDelegate scrollerTweeningChanged;

		// Token: 0x04002201 RID: 8705
		[Token(Token = "0x4002201")]
		[FieldOffset(Offset = "0x80")]
		public CellViewInstantiated cellViewInstantiated;

		// Token: 0x04002202 RID: 8706
		[Token(Token = "0x4002202")]
		[FieldOffset(Offset = "0x88")]
		public CellViewReused cellViewReused;

		// Token: 0x04002205 RID: 8709
		[Token(Token = "0x4002205")]
		[FieldOffset(Offset = "0x92")]
		private bool _initialized;

		// Token: 0x04002206 RID: 8710
		[Token(Token = "0x4002206")]
		[FieldOffset(Offset = "0x93")]
		private bool _updateSpacing;

		// Token: 0x04002207 RID: 8711
		[Token(Token = "0x4002207")]
		[FieldOffset(Offset = "0x98")]
		private ScrollRect _scrollRect;

		// Token: 0x04002208 RID: 8712
		[Token(Token = "0x4002208")]
		[FieldOffset(Offset = "0xA0")]
		private RectTransform _scrollRectTransform;

		// Token: 0x04002209 RID: 8713
		[Token(Token = "0x4002209")]
		[FieldOffset(Offset = "0xA8")]
		private Scrollbar _scrollbar;

		// Token: 0x0400220A RID: 8714
		[Token(Token = "0x400220A")]
		[FieldOffset(Offset = "0xB0")]
		private RectTransform _container;

		// Token: 0x0400220B RID: 8715
		[Token(Token = "0x400220B")]
		[FieldOffset(Offset = "0xB8")]
		private HorizontalOrVerticalLayoutGroup _layoutGroup;

		// Token: 0x0400220C RID: 8716
		[Token(Token = "0x400220C")]
		[FieldOffset(Offset = "0xC0")]
		private IEnhancedScrollerDelegate _delegate;

		// Token: 0x0400220D RID: 8717
		[Token(Token = "0x400220D")]
		[FieldOffset(Offset = "0xC8")]
		private bool _reloadData;

		// Token: 0x0400220E RID: 8718
		[Token(Token = "0x400220E")]
		[FieldOffset(Offset = "0xC9")]
		private bool _refreshActive;

		// Token: 0x0400220F RID: 8719
		[Token(Token = "0x400220F")]
		[FieldOffset(Offset = "0xD0")]
		private SmallList<EnhancedScrollerCellView> _recycledCellViews;

		// Token: 0x04002210 RID: 8720
		[Token(Token = "0x4002210")]
		[FieldOffset(Offset = "0xD8")]
		private LayoutElement _firstPadder;

		// Token: 0x04002211 RID: 8721
		[Token(Token = "0x4002211")]
		[FieldOffset(Offset = "0xE0")]
		private LayoutElement _lastPadder;

		// Token: 0x04002212 RID: 8722
		[Token(Token = "0x4002212")]
		[FieldOffset(Offset = "0xE8")]
		private RectTransform _recycledCellViewContainer;

		// Token: 0x04002213 RID: 8723
		[Token(Token = "0x4002213")]
		[FieldOffset(Offset = "0xF0")]
		private SmallList<float> _cellViewSizeArray;

		// Token: 0x04002214 RID: 8724
		[Token(Token = "0x4002214")]
		[FieldOffset(Offset = "0xF8")]
		private SmallList<float> _cellViewOffsetArray;

		// Token: 0x04002215 RID: 8725
		[Token(Token = "0x4002215")]
		[FieldOffset(Offset = "0x100")]
		private float _scrollPosition;

		// Token: 0x04002216 RID: 8726
		[Token(Token = "0x4002216")]
		[FieldOffset(Offset = "0x108")]
		private SmallList<EnhancedScrollerCellView> _activeCellViews;

		// Token: 0x04002217 RID: 8727
		[Token(Token = "0x4002217")]
		[FieldOffset(Offset = "0x110")]
		private int _activeCellViewsStartIndex;

		// Token: 0x04002218 RID: 8728
		[Token(Token = "0x4002218")]
		[FieldOffset(Offset = "0x114")]
		private int _activeCellViewsEndIndex;

		// Token: 0x04002219 RID: 8729
		[Token(Token = "0x4002219")]
		[FieldOffset(Offset = "0x118")]
		private int _loopFirstCellIndex;

		// Token: 0x0400221A RID: 8730
		[Token(Token = "0x400221A")]
		[FieldOffset(Offset = "0x11C")]
		private int _loopLastCellIndex;

		// Token: 0x0400221B RID: 8731
		[Token(Token = "0x400221B")]
		[FieldOffset(Offset = "0x120")]
		private float _loopFirstScrollPosition;

		// Token: 0x0400221C RID: 8732
		[Token(Token = "0x400221C")]
		[FieldOffset(Offset = "0x124")]
		private float _loopLastScrollPosition;

		// Token: 0x0400221D RID: 8733
		[Token(Token = "0x400221D")]
		[FieldOffset(Offset = "0x128")]
		private float _loopFirstJumpTrigger;

		// Token: 0x0400221E RID: 8734
		[Token(Token = "0x400221E")]
		[FieldOffset(Offset = "0x12C")]
		private float _loopLastJumpTrigger;

		// Token: 0x0400221F RID: 8735
		[Token(Token = "0x400221F")]
		[FieldOffset(Offset = "0x130")]
		private float _lastScrollRectSize;

		// Token: 0x04002220 RID: 8736
		[Token(Token = "0x4002220")]
		[FieldOffset(Offset = "0x134")]
		private bool _lastLoop;

		// Token: 0x04002221 RID: 8737
		[Token(Token = "0x4002221")]
		[FieldOffset(Offset = "0x138")]
		private int _snapCellViewIndex;

		// Token: 0x04002222 RID: 8738
		[Token(Token = "0x4002222")]
		[FieldOffset(Offset = "0x13C")]
		private int _snapDataIndex;

		// Token: 0x04002223 RID: 8739
		[Token(Token = "0x4002223")]
		[FieldOffset(Offset = "0x140")]
		private bool _snapJumping;

		// Token: 0x04002224 RID: 8740
		[Token(Token = "0x4002224")]
		[FieldOffset(Offset = "0x141")]
		private bool _snapInertia;

		// Token: 0x04002225 RID: 8741
		[Token(Token = "0x4002225")]
		[FieldOffset(Offset = "0x144")]
		private EnhancedScroller.ScrollbarVisibilityEnum _lastScrollbarVisibility;

		// Token: 0x04002226 RID: 8742
		[Token(Token = "0x4002226")]
		[FieldOffset(Offset = "0x148")]
		private float _tweenTimeLeft;

		// Token: 0x020004D1 RID: 1233
		[Token(Token = "0x20004D1")]
		public enum ScrollDirectionEnum
		{
			// Token: 0x04002228 RID: 8744
			[Token(Token = "0x4002228")]
			Vertical,
			// Token: 0x04002229 RID: 8745
			[Token(Token = "0x4002229")]
			Horizontal
		}

		// Token: 0x020004D2 RID: 1234
		[Token(Token = "0x20004D2")]
		public enum CellViewPositionEnum
		{
			// Token: 0x0400222B RID: 8747
			[Token(Token = "0x400222B")]
			Before,
			// Token: 0x0400222C RID: 8748
			[Token(Token = "0x400222C")]
			After
		}

		// Token: 0x020004D3 RID: 1235
		[Token(Token = "0x20004D3")]
		public enum ScrollbarVisibilityEnum
		{
			// Token: 0x0400222E RID: 8750
			[Token(Token = "0x400222E")]
			OnlyIfNeeded,
			// Token: 0x0400222F RID: 8751
			[Token(Token = "0x400222F")]
			Always,
			// Token: 0x04002230 RID: 8752
			[Token(Token = "0x4002230")]
			Never
		}

		// Token: 0x020004D4 RID: 1236
		[Token(Token = "0x20004D4")]
		public enum LoopJumpDirectionEnum
		{
			// Token: 0x04002232 RID: 8754
			[Token(Token = "0x4002232")]
			Closest,
			// Token: 0x04002233 RID: 8755
			[Token(Token = "0x4002233")]
			Up,
			// Token: 0x04002234 RID: 8756
			[Token(Token = "0x4002234")]
			Down
		}

		// Token: 0x020004D5 RID: 1237
		[Token(Token = "0x20004D5")]
		private enum ListPositionEnum
		{
			// Token: 0x04002236 RID: 8758
			[Token(Token = "0x4002236")]
			First,
			// Token: 0x04002237 RID: 8759
			[Token(Token = "0x4002237")]
			Last
		}

		// Token: 0x020004D6 RID: 1238
		[Token(Token = "0x20004D6")]
		public enum TweenType
		{
			// Token: 0x04002239 RID: 8761
			[Token(Token = "0x4002239")]
			immediate,
			// Token: 0x0400223A RID: 8762
			[Token(Token = "0x400223A")]
			linear,
			// Token: 0x0400223B RID: 8763
			[Token(Token = "0x400223B")]
			spring,
			// Token: 0x0400223C RID: 8764
			[Token(Token = "0x400223C")]
			easeInQuad,
			// Token: 0x0400223D RID: 8765
			[Token(Token = "0x400223D")]
			easeOutQuad,
			// Token: 0x0400223E RID: 8766
			[Token(Token = "0x400223E")]
			easeInOutQuad,
			// Token: 0x0400223F RID: 8767
			[Token(Token = "0x400223F")]
			easeInCubic,
			// Token: 0x04002240 RID: 8768
			[Token(Token = "0x4002240")]
			easeOutCubic,
			// Token: 0x04002241 RID: 8769
			[Token(Token = "0x4002241")]
			easeInOutCubic,
			// Token: 0x04002242 RID: 8770
			[Token(Token = "0x4002242")]
			easeInQuart,
			// Token: 0x04002243 RID: 8771
			[Token(Token = "0x4002243")]
			easeOutQuart,
			// Token: 0x04002244 RID: 8772
			[Token(Token = "0x4002244")]
			easeInOutQuart,
			// Token: 0x04002245 RID: 8773
			[Token(Token = "0x4002245")]
			easeInQuint,
			// Token: 0x04002246 RID: 8774
			[Token(Token = "0x4002246")]
			easeOutQuint,
			// Token: 0x04002247 RID: 8775
			[Token(Token = "0x4002247")]
			easeInOutQuint,
			// Token: 0x04002248 RID: 8776
			[Token(Token = "0x4002248")]
			easeInSine,
			// Token: 0x04002249 RID: 8777
			[Token(Token = "0x4002249")]
			easeOutSine,
			// Token: 0x0400224A RID: 8778
			[Token(Token = "0x400224A")]
			easeInOutSine,
			// Token: 0x0400224B RID: 8779
			[Token(Token = "0x400224B")]
			easeInExpo,
			// Token: 0x0400224C RID: 8780
			[Token(Token = "0x400224C")]
			easeOutExpo,
			// Token: 0x0400224D RID: 8781
			[Token(Token = "0x400224D")]
			easeInOutExpo,
			// Token: 0x0400224E RID: 8782
			[Token(Token = "0x400224E")]
			easeInCirc,
			// Token: 0x0400224F RID: 8783
			[Token(Token = "0x400224F")]
			easeOutCirc,
			// Token: 0x04002250 RID: 8784
			[Token(Token = "0x4002250")]
			easeInOutCirc,
			// Token: 0x04002251 RID: 8785
			[Token(Token = "0x4002251")]
			easeInBounce,
			// Token: 0x04002252 RID: 8786
			[Token(Token = "0x4002252")]
			easeOutBounce,
			// Token: 0x04002253 RID: 8787
			[Token(Token = "0x4002253")]
			easeInOutBounce,
			// Token: 0x04002254 RID: 8788
			[Token(Token = "0x4002254")]
			easeInBack,
			// Token: 0x04002255 RID: 8789
			[Token(Token = "0x4002255")]
			easeOutBack,
			// Token: 0x04002256 RID: 8790
			[Token(Token = "0x4002256")]
			easeInOutBack,
			// Token: 0x04002257 RID: 8791
			[Token(Token = "0x4002257")]
			easeInElastic,
			// Token: 0x04002258 RID: 8792
			[Token(Token = "0x4002258")]
			easeOutElastic,
			// Token: 0x04002259 RID: 8793
			[Token(Token = "0x4002259")]
			easeInOutElastic
		}
	}
}
