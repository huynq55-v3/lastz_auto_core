using System;
using Il2CppDummyDll;
using UnityEngine;

namespace usky
{
	// Token: 0x02000A07 RID: 2567
	[Token(Token = "0x2000A07")]
	[AddComponentMenu("uSkyPro/Other/Mouse Drag Timeline Controller")]
	public class MouseDragTimelineController : MonoBehaviour
	{
		// Token: 0x17000646 RID: 1606
		// (get) Token: 0x0600620A RID: 25098 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000646")]
		private uSkyTimeline uST
		{
			[Token(Token = "0x600620A")]
			[Address(RVA = "0x3030050", Offset = "0x3030050", VA = "0x3030050")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600620B RID: 25099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600620B")]
		[Address(RVA = "0x3030090", Offset = "0x3030090", VA = "0x3030090")]
		private void Update()
		{
		}

		// Token: 0x0600620C RID: 25100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600620C")]
		[Address(RVA = "0x30301A8", Offset = "0x30301A8", VA = "0x30301A8")]
		private void UpdateTimelineAndSunDirection(float x, float y)
		{
		}

		// Token: 0x0600620D RID: 25101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600620D")]
		[Address(RVA = "0x3030324", Offset = "0x3030324", VA = "0x3030324")]
		public MouseDragTimelineController()
		{
		}

		// Token: 0x0400264D RID: 9805
		[Token(Token = "0x400264D")]
		[FieldOffset(Offset = "0x18")]
		public float MoveSpeed;

		// Token: 0x0400264E RID: 9806
		[Token(Token = "0x400264E")]
		[FieldOffset(Offset = "0x1C")]
		private float altitude;

		// Token: 0x0400264F RID: 9807
		[Token(Token = "0x400264F")]
		[FieldOffset(Offset = "0x20")]
		private float azimuth;
	}
}
