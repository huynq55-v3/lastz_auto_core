using System;
using FIMSpace.FProceduralAnimation;
using Il2CppDummyDll;
using UnityEngine;

namespace FIMSpace.RagdollAnimatorDemo
{
	// Token: 0x02000C2B RID: 3115
	[Token(Token = "0x2000C2B")]
	[DefaultExecutionOrder(-2)]
	public class Demo_Ragd_UnpinAndGetUp : MonoBehaviour
	{
		// Token: 0x060076CE RID: 30414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076CE")]
		[Address(RVA = "0x2ECB354", Offset = "0x2ECB354", VA = "0x2ECB354")]
		private void Start()
		{
		}

		// Token: 0x060076CF RID: 30415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076CF")]
		[Address(RVA = "0x2ECB3E8", Offset = "0x2ECB3E8", VA = "0x2ECB3E8")]
		private void LateUpdate()
		{
		}

		// Token: 0x060076D0 RID: 30416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076D0")]
		[Address(RVA = "0x2ECB894", Offset = "0x2ECB894", VA = "0x2ECB894")]
		public Demo_Ragd_UnpinAndGetUp()
		{
		}

		// Token: 0x0400309B RID: 12443
		[Token(Token = "0x400309B")]
		[FieldOffset(Offset = "0x18")]
		public RagdollAnimator Ragdoll;

		// Token: 0x0400309C RID: 12444
		[Token(Token = "0x400309C")]
		[FieldOffset(Offset = "0x20")]
		public float UnpinAtDistance;

		// Token: 0x0400309D RID: 12445
		[Token(Token = "0x400309D")]
		[FieldOffset(Offset = "0x24")]
		[Header("< Just Debugging >")]
		public float DebugHipsDistance;

		// Token: 0x0400309E RID: 12446
		[Token(Token = "0x400309E")]
		[FieldOffset(Offset = "0x28")]
		private float getUpCulldown;
	}
}
