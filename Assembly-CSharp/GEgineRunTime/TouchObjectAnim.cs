using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;

namespace GEgineRunTime
{
	// Token: 0x020004FD RID: 1277
	[Token(Token = "0x20004FD")]
	public class TouchObjectAnim : MonoBehaviour
	{
		// Token: 0x060026A7 RID: 9895 RVA: 0x0000E850 File Offset: 0x0000CA50
		[Token(Token = "0x60026A7")]
		[Address(RVA = "0x2B62C70", Offset = "0x2B62C70", VA = "0x2B62C70")]
		private bool GetPressedCurveInfo(out Vector3 pressedScale, out float pressedTime, out EaseFunction func)
		{
			return default(bool);
		}

		// Token: 0x060026A8 RID: 9896 RVA: 0x0000E868 File Offset: 0x0000CA68
		[Token(Token = "0x60026A8")]
		[Address(RVA = "0x2B62E08", Offset = "0x2B62E08", VA = "0x2B62E08")]
		private bool GetOtherCurveInfo(out Vector3 otherScale, out float otherTime, out EaseFunction func)
		{
			return default(bool);
		}

		// Token: 0x060026A9 RID: 9897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026A9")]
		[Address(RVA = "0x2B62F54", Offset = "0x2B62F54", VA = "0x2B62F54")]
		public void ShowClickPressAnim()
		{
		}

		// Token: 0x060026AA RID: 9898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026AA")]
		[Address(RVA = "0x2B63064", Offset = "0x2B63064", VA = "0x2B63064")]
		public void HideClickPressAnim()
		{
		}

		// Token: 0x060026AB RID: 9899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026AB")]
		[Address(RVA = "0x2B63174", Offset = "0x2B63174", VA = "0x2B63174")]
		public TouchObjectAnim()
		{
		}

		// Token: 0x040022EB RID: 8939
		[Token(Token = "0x40022EB")]
		[FieldOffset(Offset = "0x18")]
		public bool useRecordScale;

		// Token: 0x040022EC RID: 8940
		[Token(Token = "0x40022EC")]
		[FieldOffset(Offset = "0x1C")]
		public Vector3 useScale;
	}
}
