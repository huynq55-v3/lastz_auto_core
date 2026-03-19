using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

namespace BitBenderGames
{
	// Token: 0x02000AB1 RID: 2737
	[Token(Token = "0x2000AB1")]
	public class TouchInputController
	{
		// Token: 0x1700074C RID: 1868
		// (get) Token: 0x0600685D RID: 26717 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600685E RID: 26718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700074C")]
		private List<Vector3> DragFinalMomentumVector
		{
			[Token(Token = "0x600685D")]
			[Address(RVA = "0x33CE804", Offset = "0x33CE804", VA = "0x33CE804")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600685E")]
			[Address(RVA = "0x33CE80C", Offset = "0x33CE80C", VA = "0x33CE80C")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600685F RID: 26719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600685F")]
		[Address(RVA = "0x33CE814", Offset = "0x33CE814", VA = "0x33CE814")]
		public void SetDragThresholdValue(float thresholdRelative, float durationThreshold)
		{
		}

		// Token: 0x14000010 RID: 16
		// (add) Token: 0x06006860 RID: 26720 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06006861 RID: 26721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000010")]
		public event TouchInputController.InputDragStartDelegate OnDragStart
		{
			[Token(Token = "0x6006860")]
			[Address(RVA = "0x33CE820", Offset = "0x33CE820", VA = "0x33CE820")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006861")]
			[Address(RVA = "0x33CE8BC", Offset = "0x33CE8BC", VA = "0x33CE8BC")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000011 RID: 17
		// (add) Token: 0x06006862 RID: 26722 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06006863 RID: 26723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000011")]
		public event TouchInputController.Input1PositionDelegate OnFingerDown
		{
			[Token(Token = "0x6006862")]
			[Address(RVA = "0x33CE958", Offset = "0x33CE958", VA = "0x33CE958")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006863")]
			[Address(RVA = "0x33CE9F4", Offset = "0x33CE9F4", VA = "0x33CE9F4")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000012 RID: 18
		// (add) Token: 0x06006864 RID: 26724 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06006865 RID: 26725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000012")]
		public event Action OnFingerUp
		{
			[Token(Token = "0x6006864")]
			[Address(RVA = "0x33CEA90", Offset = "0x33CEA90", VA = "0x33CEA90")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006865")]
			[Address(RVA = "0x33CEB2C", Offset = "0x33CEB2C", VA = "0x33CEB2C")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000013 RID: 19
		// (add) Token: 0x06006866 RID: 26726 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06006867 RID: 26727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000013")]
		public event TouchInputController.DragUpdateDelegate OnDragUpdate
		{
			[Token(Token = "0x6006866")]
			[Address(RVA = "0x33CEBC8", Offset = "0x33CEBC8", VA = "0x33CEBC8")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006867")]
			[Address(RVA = "0x33CEC64", Offset = "0x33CEC64", VA = "0x33CEC64")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000014 RID: 20
		// (add) Token: 0x06006868 RID: 26728 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06006869 RID: 26729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000014")]
		public event TouchInputController.DragStopDelegate OnDragStop
		{
			[Token(Token = "0x6006868")]
			[Address(RVA = "0x33CED00", Offset = "0x33CED00", VA = "0x33CED00")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006869")]
			[Address(RVA = "0x33CED9C", Offset = "0x33CED9C", VA = "0x33CED9C")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000015 RID: 21
		// (add) Token: 0x0600686A RID: 26730 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x0600686B RID: 26731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000015")]
		public event TouchInputController.PinchStartDelegate OnPinchStart
		{
			[Token(Token = "0x600686A")]
			[Address(RVA = "0x33CEE38", Offset = "0x33CEE38", VA = "0x33CEE38")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600686B")]
			[Address(RVA = "0x33CEED4", Offset = "0x33CEED4", VA = "0x33CEED4")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000016 RID: 22
		// (add) Token: 0x0600686C RID: 26732 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x0600686D RID: 26733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000016")]
		public event TouchInputController.PinchUpdateDelegate OnPinchUpdate
		{
			[Token(Token = "0x600686C")]
			[Address(RVA = "0x33CEF70", Offset = "0x33CEF70", VA = "0x33CEF70")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600686D")]
			[Address(RVA = "0x33CF00C", Offset = "0x33CF00C", VA = "0x33CF00C")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000017 RID: 23
		// (add) Token: 0x0600686E RID: 26734 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x0600686F RID: 26735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000017")]
		public event TouchInputController.PinchUpdateExtendedDelegate OnPinchUpdateExtended
		{
			[Token(Token = "0x600686E")]
			[Address(RVA = "0x33CF0A8", Offset = "0x33CF0A8", VA = "0x33CF0A8")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600686F")]
			[Address(RVA = "0x33CF144", Offset = "0x33CF144", VA = "0x33CF144")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000018 RID: 24
		// (add) Token: 0x06006870 RID: 26736 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06006871 RID: 26737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000018")]
		public event Action OnPinchStop
		{
			[Token(Token = "0x6006870")]
			[Address(RVA = "0x33CF1E0", Offset = "0x33CF1E0", VA = "0x33CF1E0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006871")]
			[Address(RVA = "0x33CF27C", Offset = "0x33CF27C", VA = "0x33CF27C")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000019 RID: 25
		// (add) Token: 0x06006872 RID: 26738 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06006873 RID: 26739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000019")]
		public event TouchInputController.InputLongTapProgress OnLongTapProgress
		{
			[Token(Token = "0x6006872")]
			[Address(RVA = "0x33CF318", Offset = "0x33CF318", VA = "0x33CF318")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006873")]
			[Address(RVA = "0x33CF3B8", Offset = "0x33CF3B8", VA = "0x33CF3B8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400001A RID: 26
		// (add) Token: 0x06006874 RID: 26740 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06006875 RID: 26741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400001A")]
		public event TouchInputController.InputClickDelegate OnInputClick
		{
			[Token(Token = "0x6006874")]
			[Address(RVA = "0x33CF458", Offset = "0x33CF458", VA = "0x33CF458")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006875")]
			[Address(RVA = "0x33CF4F8", Offset = "0x33CF4F8", VA = "0x33CF4F8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1700074D RID: 1869
		// (get) Token: 0x06006876 RID: 26742 RVA: 0x0004CF08 File Offset: 0x0004B108
		[Token(Token = "0x1700074D")]
		public bool LongTapStartsDrag
		{
			[Token(Token = "0x6006876")]
			[Address(RVA = "0x33CF598", Offset = "0x33CF598", VA = "0x33CF598")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700074E RID: 1870
		// (get) Token: 0x06006877 RID: 26743 RVA: 0x0004CF20 File Offset: 0x0004B120
		// (set) Token: 0x06006878 RID: 26744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700074E")]
		public bool IsInputOnLockedArea
		{
			[Token(Token = "0x6006877")]
			[Address(RVA = "0x33CF5A0", Offset = "0x33CF5A0", VA = "0x33CF5A0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6006878")]
			[Address(RVA = "0x33CF5A8", Offset = "0x33CF5A8", VA = "0x33CF5A8")]
			set
			{
			}
		}

		// Token: 0x1400001B RID: 27
		// (add) Token: 0x06006879 RID: 26745 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x0600687A RID: 26746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400001B")]
		public event TouchInputController.RightMouseButtonDelegate OnRightMouseButtonDown
		{
			[Token(Token = "0x6006879")]
			[Address(RVA = "0x33CF5B4", Offset = "0x33CF5B4", VA = "0x33CF5B4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600687A")]
			[Address(RVA = "0x33CF654", Offset = "0x33CF654", VA = "0x33CF654")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400001C RID: 28
		// (add) Token: 0x0600687B RID: 26747 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x0600687C RID: 26748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400001C")]
		public event TouchInputController.RightMouseButtonDelegate OnRightMouseButtonUp
		{
			[Token(Token = "0x600687B")]
			[Address(RVA = "0x33CF6F4", Offset = "0x33CF6F4", VA = "0x33CF6F4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600687C")]
			[Address(RVA = "0x33CF794", Offset = "0x33CF794", VA = "0x33CF794")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400001D RID: 29
		// (add) Token: 0x0600687D RID: 26749 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x0600687E RID: 26750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400001D")]
		public event TouchInputController.InputClickDelegate OnRightMouseButtonClick
		{
			[Token(Token = "0x600687D")]
			[Address(RVA = "0x33CF834", Offset = "0x33CF834", VA = "0x33CF834")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600687E")]
			[Address(RVA = "0x33CF8D4", Offset = "0x33CF8D4", VA = "0x33CF8D4")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x0600687F RID: 26751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600687F")]
		[Address(RVA = "0x33CA2FC", Offset = "0x33CA2FC", VA = "0x33CA2FC")]
		public void ClearDelegate()
		{
		}

		// Token: 0x06006880 RID: 26752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006880")]
		[Address(RVA = "0x33CA8C0", Offset = "0x33CA8C0", VA = "0x33CA8C0")]
		public TouchInputController()
		{
		}

		// Token: 0x06006881 RID: 26753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006881")]
		[Address(RVA = "0x33CF974", Offset = "0x33CF974", VA = "0x33CF974")]
		public void OnEventTriggerPointerDown(GameObject go)
		{
		}

		// Token: 0x06006882 RID: 26754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006882")]
		[Address(RVA = "0x33CF980", Offset = "0x33CF980", VA = "0x33CF980")]
		public void OnEventTriggerPointerDown(BaseEventData baseEventData)
		{
		}

		// Token: 0x06006883 RID: 26755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006883")]
		[Address(RVA = "0x33CF98C", Offset = "0x33CF98C", VA = "0x33CF98C")]
		private void InputDownOnUI()
		{
		}

		// Token: 0x06006884 RID: 26756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006884")]
		[Address(RVA = "0x33CB134", Offset = "0x33CB134", VA = "0x33CB134")]
		public void OnUpdate()
		{
		}

		// Token: 0x06006885 RID: 26757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006885")]
		[Address(RVA = "0x33D0C18", Offset = "0x33D0C18", VA = "0x33D0C18")]
		public void RestartDrag()
		{
		}

		// Token: 0x06006886 RID: 26758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006886")]
		[Address(RVA = "0x33CFB10", Offset = "0x33CFB10", VA = "0x33CFB10")]
		private void StartPinch()
		{
		}

		// Token: 0x06006887 RID: 26759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006887")]
		[Address(RVA = "0x33CFF58", Offset = "0x33CFF58", VA = "0x33CFF58")]
		private void UpdatePinch()
		{
		}

		// Token: 0x06006888 RID: 26760 RVA: 0x0004CF38 File Offset: 0x0004B138
		[Token(Token = "0x6006888")]
		[Address(RVA = "0x33D0CC4", Offset = "0x33D0CC4", VA = "0x33D0CC4")]
		private float GetPinchDistance(Vector3 pos0, Vector3 pos1)
		{
			return 0f;
		}

		// Token: 0x06006889 RID: 26761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006889")]
		[Address(RVA = "0x33CFEE0", Offset = "0x33CFEE0", VA = "0x33CFEE0")]
		private void StopPinch()
		{
		}

		// Token: 0x0600688A RID: 26762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600688A")]
		[Address(RVA = "0x33D0A20", Offset = "0x33D0A20", VA = "0x33D0A20")]
		private void DragStart(Vector3 pos, bool isLongTap)
		{
		}

		// Token: 0x0600688B RID: 26763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600688B")]
		[Address(RVA = "0x33D0AC4", Offset = "0x33D0AC4", VA = "0x33D0AC4")]
		private void DragUpdate(Vector3 pos)
		{
		}

		// Token: 0x0600688C RID: 26764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600688C")]
		[Address(RVA = "0x33CFD84", Offset = "0x33CFD84", VA = "0x33CFD84")]
		private void DragStop(Vector3 pos)
		{
		}

		// Token: 0x0600688D RID: 26765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600688D")]
		[Address(RVA = "0x33D0BD4", Offset = "0x33D0BD4", VA = "0x33D0BD4")]
		private void FingerDown(Vector3 pos)
		{
		}

		// Token: 0x0600688E RID: 26766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600688E")]
		[Address(RVA = "0x33D0BF8", Offset = "0x33D0BF8", VA = "0x33D0BF8")]
		private void FingerUp()
		{
		}

		// Token: 0x0600688F RID: 26767 RVA: 0x0004CF50 File Offset: 0x0004B150
		[Token(Token = "0x600688F")]
		[Address(RVA = "0x33D0D24", Offset = "0x33D0D24", VA = "0x33D0D24")]
		private Vector3 GetTouchPositionRelative(Vector3 touchPosScreen)
		{
			return default(Vector3);
		}

		// Token: 0x06006890 RID: 26768 RVA: 0x0004CF68 File Offset: 0x0004B168
		[Token(Token = "0x6006890")]
		[Address(RVA = "0x33D0988", Offset = "0x33D0988", VA = "0x33D0988")]
		private float GetRelativeDragDistance(Vector3 pos0, Vector3 pos1)
		{
			return 0f;
		}

		// Token: 0x06006891 RID: 26769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006891")]
		[Address(RVA = "0x33D0D74", Offset = "0x33D0D74", VA = "0x33D0D74")]
		private void HandleRightMouseButton()
		{
		}

		// Token: 0x040029EB RID: 10731
		[Token(Token = "0x40029EB")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		[Header("Expert Mode")]
		private bool expertModeEnabled;

		// Token: 0x040029EC RID: 10732
		[Token(Token = "0x40029EC")]
		[FieldOffset(Offset = "0x14")]
		[Tooltip("当手指在一个物品上停留至少这个时间而不动时，这个手势就被认为是一个长敲击.")]
		[SerializeField]
		private float clickDurationThreshold;

		// Token: 0x040029ED RID: 10733
		[Token(Token = "0x40029ED")]
		[FieldOffset(Offset = "0x18")]
		[Tooltip("当连续两次点击之间的时间短于此时间时，可以识别双击手势.")]
		[SerializeField]
		private float doubleclickDurationThreshold;

		// Token: 0x040029EE RID: 10734
		[Token(Token = "0x40029EE")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		[Tooltip("此值控制用户必须执行倾斜手势才能将其识别为垂直线的距离.")]
		private float tiltMoveDotTreshold;

		// Token: 0x040029EF RID: 10735
		[Token(Token = "0x40029EF")]
		[FieldOffset(Offset = "0x20")]
		[Tooltip("阈值，用于检测手指是否水平到足以启动倾斜。使用此值可以防止将垂直手指放置计算为倾斜手势.")]
		[SerializeField]
		private float tiltHorizontalDotThreshold;

		// Token: 0x040029F0 RID: 10736
		[Token(Token = "0x40029F0")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		[Tooltip("当用户的手指移动的距离超过这个值时，就会开始拖动。该值被定义为规范化值。拖动屏幕的整个宽度等于1。拖动整个屏幕的高度也等于1")]
		private float dragStartDistanceThresholdRelative;

		// Token: 0x040029F1 RID: 10737
		[Token(Token = "0x40029F1")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Tooltip("当启用此标志时，当长点击时间成功时，立即调用拖动启动事件.")]
		private bool longTapStartsDrag;

		// Token: 0x040029F2 RID: 10738
		[Token(Token = "0x40029F2")]
		[FieldOffset(Offset = "0x29")]
		[SerializeField]
		private bool checkInputOnUI;

		// Token: 0x040029F3 RID: 10739
		[Token(Token = "0x40029F3")]
		[FieldOffset(Offset = "0x2C")]
		private float lastFingerDownTimeReal;

		// Token: 0x040029F4 RID: 10740
		[Token(Token = "0x40029F4")]
		[FieldOffset(Offset = "0x30")]
		private float lastClickTimeReal;

		// Token: 0x040029F5 RID: 10741
		[Token(Token = "0x40029F5")]
		[FieldOffset(Offset = "0x34")]
		private bool wasFingerDownLastFrame;

		// Token: 0x040029F6 RID: 10742
		[Token(Token = "0x40029F6")]
		[FieldOffset(Offset = "0x38")]
		private Vector3 lastFinger0DownPos;

		// Token: 0x040029F7 RID: 10743
		[Token(Token = "0x40029F7")]
		[FieldOffset(Offset = "0x44")]
		private float dragDurationThreshold;

		// Token: 0x040029F8 RID: 10744
		[Token(Token = "0x40029F8")]
		private const float dragFingerChangeThreshold = 400f;

		// Token: 0x040029F9 RID: 10745
		[Token(Token = "0x40029F9")]
		[FieldOffset(Offset = "0x48")]
		private bool isDragging;

		// Token: 0x040029FA RID: 10746
		[Token(Token = "0x40029FA")]
		[FieldOffset(Offset = "0x4C")]
		private Vector3 dragStartPos;

		// Token: 0x040029FB RID: 10747
		[Token(Token = "0x40029FB")]
		[FieldOffset(Offset = "0x58")]
		private Vector3 dragStartOffset;

		// Token: 0x040029FC RID: 10748
		[Token(Token = "0x40029FC")]
		[FieldOffset(Offset = "0x64")]
		private Vector3 lastDragPos;

		// Token: 0x040029FE RID: 10750
		[Token(Token = "0x40029FE")]
		private const int momentumSamplesCount = 5;

		// Token: 0x040029FF RID: 10751
		[Token(Token = "0x40029FF")]
		[FieldOffset(Offset = "0x78")]
		private float pinchStartDistance;

		// Token: 0x04002A00 RID: 10752
		[Token(Token = "0x4002A00")]
		[FieldOffset(Offset = "0x80")]
		private List<Vector3> pinchStartPositions;

		// Token: 0x04002A01 RID: 10753
		[Token(Token = "0x4002A01")]
		[FieldOffset(Offset = "0x88")]
		private List<Vector3> touchPositionLastFrame;

		// Token: 0x04002A02 RID: 10754
		[Token(Token = "0x4002A02")]
		[FieldOffset(Offset = "0x90")]
		private Vector3 pinchRotationVectorStart;

		// Token: 0x04002A03 RID: 10755
		[Token(Token = "0x4002A03")]
		[FieldOffset(Offset = "0x9C")]
		private Vector3 pinchVectorLastFrame;

		// Token: 0x04002A04 RID: 10756
		[Token(Token = "0x4002A04")]
		[FieldOffset(Offset = "0xA8")]
		private float totalFingerMovement;

		// Token: 0x04002A05 RID: 10757
		[Token(Token = "0x4002A05")]
		[FieldOffset(Offset = "0xAC")]
		private bool wasDraggingLastFrame;

		// Token: 0x04002A06 RID: 10758
		[Token(Token = "0x4002A06")]
		[FieldOffset(Offset = "0xAD")]
		private bool wasPinchingLastFrame;

		// Token: 0x04002A07 RID: 10759
		[Token(Token = "0x4002A07")]
		[FieldOffset(Offset = "0xAE")]
		private bool isPinching;

		// Token: 0x04002A08 RID: 10760
		[Token(Token = "0x4002A08")]
		[FieldOffset(Offset = "0xAF")]
		private bool isInputOnLockedArea;

		// Token: 0x04002A09 RID: 10761
		[Token(Token = "0x4002A09")]
		[FieldOffset(Offset = "0xB0")]
		private float timeSinceDragStart;

		// Token: 0x04002A14 RID: 10772
		[Token(Token = "0x4002A14")]
		[FieldOffset(Offset = "0x108")]
		private bool isClickPrevented;

		// Token: 0x04002A16 RID: 10774
		[Token(Token = "0x4002A16")]
		[FieldOffset(Offset = "0x118")]
		private bool isFingerDown;

		// Token: 0x04002A17 RID: 10775
		[Token(Token = "0x4002A17")]
		[FieldOffset(Offset = "0x119")]
		public bool enabled;

		// Token: 0x04002A1B RID: 10779
		[Token(Token = "0x4002A1B")]
		[FieldOffset(Offset = "0x138")]
		private bool isRightMouseButtonDown;

		// Token: 0x04002A1C RID: 10780
		[Token(Token = "0x4002A1C")]
		[FieldOffset(Offset = "0x139")]
		private bool wasRightMouseButtonDownLastFrame;

		// Token: 0x04002A1D RID: 10781
		[Token(Token = "0x4002A1D")]
		[FieldOffset(Offset = "0x13C")]
		private Vector3 rightMouseDownPos;

		// Token: 0x04002A1E RID: 10782
		[Token(Token = "0x4002A1E")]
		[FieldOffset(Offset = "0x148")]
		private float rightMouseDownTimeReal;

		// Token: 0x02000AB2 RID: 2738
		// (Invoke) Token: 0x06006893 RID: 26771
		[Token(Token = "0x2000AB2")]
		public delegate void InputDragStartDelegate(Vector3 pos, bool isLongTap);

		// Token: 0x02000AB3 RID: 2739
		// (Invoke) Token: 0x06006897 RID: 26775
		[Token(Token = "0x2000AB3")]
		public delegate void Input1PositionDelegate(Vector3 pos);

		// Token: 0x02000AB4 RID: 2740
		// (Invoke) Token: 0x0600689B RID: 26779
		[Token(Token = "0x2000AB4")]
		public delegate void DragUpdateDelegate(Vector3 dragPosStart, Vector3 dragPosCurrent, Vector3 correctionOffset);

		// Token: 0x02000AB5 RID: 2741
		// (Invoke) Token: 0x0600689F RID: 26783
		[Token(Token = "0x2000AB5")]
		public delegate void DragStopDelegate(Vector3 dragStopPos, Vector3 dragFinalMomentum);

		// Token: 0x02000AB6 RID: 2742
		// (Invoke) Token: 0x060068A3 RID: 26787
		[Token(Token = "0x2000AB6")]
		public delegate void PinchStartDelegate(Vector3 pinchCenter, float pinchDistance);

		// Token: 0x02000AB7 RID: 2743
		// (Invoke) Token: 0x060068A7 RID: 26791
		[Token(Token = "0x2000AB7")]
		public delegate void PinchUpdateDelegate(Vector3 pinchCenter, float pinchDistance, float pinchStartDistance);

		// Token: 0x02000AB8 RID: 2744
		// (Invoke) Token: 0x060068AB RID: 26795
		[Token(Token = "0x2000AB8")]
		public delegate void PinchUpdateExtendedDelegate(PinchUpdateData pinchUpdateData);

		// Token: 0x02000AB9 RID: 2745
		// (Invoke) Token: 0x060068AF RID: 26799
		[Token(Token = "0x2000AB9")]
		public delegate void InputLongTapProgress(float progress);

		// Token: 0x02000ABA RID: 2746
		// (Invoke) Token: 0x060068B3 RID: 26803
		[Token(Token = "0x2000ABA")]
		public delegate void InputClickDelegate(Vector3 clickPosition, bool isDoubleClick, bool isLongTap);

		// Token: 0x02000ABB RID: 2747
		// (Invoke) Token: 0x060068B7 RID: 26807
		[Token(Token = "0x2000ABB")]
		public delegate void RightMouseButtonDelegate(Vector3 pos);
	}
}
