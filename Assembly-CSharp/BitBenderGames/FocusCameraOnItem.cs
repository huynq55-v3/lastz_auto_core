using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace BitBenderGames
{
	// Token: 0x02000AAF RID: 2735
	[Token(Token = "0x2000AAF")]
	[RequireComponent(typeof(MobileTouchCamera))]
	public class FocusCameraOnItem : MonoBehaviourWrapped
	{
		// Token: 0x1700074B RID: 1867
		// (get) Token: 0x0600684E RID: 26702 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600684F RID: 26703 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700074B")]
		private MobileTouchCamera MobileTouchCamera
		{
			[Token(Token = "0x600684E")]
			[Address(RVA = "0x33CE308", Offset = "0x33CE308", VA = "0x33CE308")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600684F")]
			[Address(RVA = "0x33CE310", Offset = "0x33CE310", VA = "0x33CE310")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06006850 RID: 26704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006850")]
		[Address(RVA = "0x33CE318", Offset = "0x33CE318", VA = "0x33CE318")]
		public void Awake()
		{
		}

		// Token: 0x06006851 RID: 26705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006851")]
		[Address(RVA = "0x33CE378", Offset = "0x33CE378", VA = "0x33CE378")]
		public void LateUpdate()
		{
		}

		// Token: 0x06006852 RID: 26706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006852")]
		[Address(RVA = "0x33CE3CC", Offset = "0x33CE3CC", VA = "0x33CE3CC")]
		private void UpdatePosition()
		{
		}

		// Token: 0x06006853 RID: 26707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006853")]
		[Address(RVA = "0x33CE4C8", Offset = "0x33CE4C8", VA = "0x33CE4C8")]
		public void OnPickItem(RaycastHit hitInfo)
		{
		}

		// Token: 0x06006854 RID: 26708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006854")]
		[Address(RVA = "0x33CE584", Offset = "0x33CE584", VA = "0x33CE584")]
		public void OnPickItem2D(RaycastHit2D hitInfo2D)
		{
		}

		// Token: 0x06006855 RID: 26709 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006855")]
		[Address(RVA = "0x33CE5A8", Offset = "0x33CE5A8", VA = "0x33CE5A8")]
		public void OnPickableTransformSelected(Transform pickableTransform)
		{
		}

		// Token: 0x06006856 RID: 26710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006856")]
		[Address(RVA = "0x33CE4EC", Offset = "0x33CE4EC", VA = "0x33CE4EC")]
		public void FocusCameraOnTransform(Transform targetTransform)
		{
		}

		// Token: 0x06006857 RID: 26711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006857")]
		[Address(RVA = "0x33CE6A4", Offset = "0x33CE6A4", VA = "0x33CE6A4")]
		public void FocusCameraOnTransform(Vector3 targetPosition)
		{
		}

		// Token: 0x06006858 RID: 26712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006858")]
		[Address(RVA = "0x33CE5AC", Offset = "0x33CE5AC", VA = "0x33CE5AC")]
		public void FocusCameraOnTarget(Vector3 targetPosition)
		{
		}

		// Token: 0x06006859 RID: 26713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006859")]
		[Address(RVA = "0x33CE46C", Offset = "0x33CE46C", VA = "0x33CE46C")]
		private void SetPosition(Vector3 newPosition)
		{
		}

		// Token: 0x0600685A RID: 26714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600685A")]
		[Address(RVA = "0x33CE6A8", Offset = "0x33CE6A8", VA = "0x33CE6A8")]
		public FocusCameraOnItem()
		{
		}

		// Token: 0x040029E4 RID: 10724
		[Token(Token = "0x40029E4")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float transitionDuration;

		// Token: 0x040029E6 RID: 10726
		[Token(Token = "0x40029E6")]
		[FieldOffset(Offset = "0x38")]
		private Vector3 posTransitionStart;

		// Token: 0x040029E7 RID: 10727
		[Token(Token = "0x40029E7")]
		[FieldOffset(Offset = "0x44")]
		private Vector3 posTransitionEnd;

		// Token: 0x040029E8 RID: 10728
		[Token(Token = "0x40029E8")]
		[FieldOffset(Offset = "0x50")]
		private float timeTransitionStart;

		// Token: 0x040029E9 RID: 10729
		[Token(Token = "0x40029E9")]
		[FieldOffset(Offset = "0x54")]
		private bool isTransitionStarted;
	}
}
