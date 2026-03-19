using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BitBenderGames
{
	// Token: 0x02000AAA RID: 2730
	[Token(Token = "0x2000AAA")]
	public abstract class MobileTouchPickable : MonoBehaviour
	{
		// Token: 0x17000744 RID: 1860
		// (get) Token: 0x0600683D RID: 26685 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600683E RID: 26686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000744")]
		public Transform PickableTransform
		{
			[Token(Token = "0x600683D")]
			[Address(RVA = "0x33CDE04", Offset = "0x33CDE04", VA = "0x33CDE04")]
			get
			{
				return null;
			}
			[Token(Token = "0x600683E")]
			[Address(RVA = "0x33CDE0C", Offset = "0x33CDE0C", VA = "0x33CDE0C")]
			set
			{
			}
		}

		// Token: 0x17000745 RID: 1861
		// (get) Token: 0x0600683F RID: 26687 RVA: 0x0004CEC0 File Offset: 0x0004B0C0
		[Token(Token = "0x17000745")]
		public Vector2 LocalSnapOffset
		{
			[Token(Token = "0x600683F")]
			[Address(RVA = "0x33CDE14", Offset = "0x33CDE14", VA = "0x33CDE14")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x06006840 RID: 26688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006840")]
		[Address(RVA = "0x33CDE1C", Offset = "0x33CDE1C", VA = "0x33CDE1C")]
		public void Awake()
		{
		}

		// Token: 0x06006841 RID: 26689
		[Token(Token = "0x6006841")]
		public abstract bool PointInPick();

		// Token: 0x06006842 RID: 26690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006842")]
		[Address(RVA = "0x33CE138", Offset = "0x33CE138", VA = "0x33CE138")]
		protected MobileTouchPickable()
		{
		}

		// Token: 0x040029D2 RID: 10706
		[Token(Token = "0x40029D2")]
		[FieldOffset(Offset = "0x0")]
		private static MobileTouchCamera mobileTouchCam;

		// Token: 0x040029D3 RID: 10707
		[Token(Token = "0x40029D3")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Tooltip("可选的。如果可选项的冲突器不在可选项的根对象上，则只需要设置此值。如果可选项的冲突器不在可选项的根对象上，则需要设置此值.")]
		private Transform pickableTransform;

		// Token: 0x040029D4 RID: 10708
		[Token(Token = "0x40029D4")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Tooltip("启用捕捉时，此值定义一个位置偏移量，该偏移量在拖动时添加到对象的中心。注意，这个值是添加在MobilePickingController中定义的snapOffset之上的。当使用自顶向下相机时，这两个值应用于X/Z位置.")]
		private Vector2 localSnapOffset;
	}
}
