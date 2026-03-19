using System;
using Il2CppDummyDll;
using UnityEngine;

namespace usky
{
	// Token: 0x02000A23 RID: 2595
	[Token(Token = "0x2000A23")]
	[Serializable]
	public struct RealisticTimelineSettings
	{
		// Token: 0x04002735 RID: 10037
		[Token(Token = "0x4002735")]
		[FieldOffset(Offset = "0x0")]
		[Range(-90f, 90f)]
		public float latitude;

		// Token: 0x04002736 RID: 10038
		[Token(Token = "0x4002736")]
		[FieldOffset(Offset = "0x4")]
		[Range(-180f, 180f)]
		public float longitude;

		// Token: 0x04002737 RID: 10039
		[Token(Token = "0x4002737")]
		[FieldOffset(Offset = "0x8")]
		[Range(1f, 31f)]
		[Tooltip("Note: The value of maximum day in month will dynamically clamped according to which month of the year.")]
		public int day;

		// Token: 0x04002738 RID: 10040
		[Token(Token = "0x4002738")]
		[FieldOffset(Offset = "0xC")]
		[Range(1f, 12f)]
		public int month;

		// Token: 0x04002739 RID: 10041
		[Token(Token = "0x4002739")]
		[FieldOffset(Offset = "0x10")]
		[HideInInspector]
		public int year;

		// Token: 0x0400273A RID: 10042
		[Token(Token = "0x400273A")]
		[FieldOffset(Offset = "0x14")]
		[Tooltip("UTC / Time Zone")]
		[Range(-14f, 14f)]
		public int GMTOffset;
	}
}
