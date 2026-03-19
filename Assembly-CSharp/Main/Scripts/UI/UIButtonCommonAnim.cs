using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;

namespace Main.Scripts.UI
{
	// Token: 0x02000500 RID: 1280
	[Token(Token = "0x2000500")]
	public class UIButtonCommonAnim : MonoBehaviour
	{
		// Token: 0x060026B7 RID: 9911 RVA: 0x0000E8B0 File Offset: 0x0000CAB0
		[Token(Token = "0x60026B7")]
		[Address(RVA = "0x2B6349C", Offset = "0x2B6349C", VA = "0x2B6349C")]
		private bool GetOtherCurveInfo(out Vector3 otherScale, out float otherTime, out EaseFunction func)
		{
			return default(bool);
		}

		// Token: 0x060026B8 RID: 9912 RVA: 0x0000E8C8 File Offset: 0x0000CAC8
		[Token(Token = "0x60026B8")]
		[Address(RVA = "0x2B635C8", Offset = "0x2B635C8", VA = "0x2B635C8")]
		private bool GetPressedCurveInfo(out Vector3 pressedScale, out float pressedTime, out EaseFunction func)
		{
			return default(bool);
		}

		// Token: 0x060026B9 RID: 9913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026B9")]
		[Address(RVA = "0x2B63714", Offset = "0x2B63714", VA = "0x2B63714")]
		public void TriggerAnimation_Pressed()
		{
		}

		// Token: 0x060026BA RID: 9914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026BA")]
		[Address(RVA = "0x2B63888", Offset = "0x2B63888", VA = "0x2B63888")]
		public void TriggerAnimation_Other()
		{
		}

		// Token: 0x060026BB RID: 9915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026BB")]
		[Address(RVA = "0x2B63994", Offset = "0x2B63994", VA = "0x2B63994")]
		public UIButtonCommonAnim()
		{
		}

		// Token: 0x040022F4 RID: 8948
		[Token(Token = "0x40022F4")]
		[FieldOffset(Offset = "0x18")]
		private Vector3 preScale;
	}
}
