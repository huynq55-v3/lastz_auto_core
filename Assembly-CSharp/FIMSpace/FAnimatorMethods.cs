using System;
using Il2CppDummyDll;
using UnityEngine;

namespace FIMSpace
{
	// Token: 0x02000C0B RID: 3083
	[Token(Token = "0x2000C0B")]
	public static class FAnimatorMethods
	{
		// Token: 0x060075B0 RID: 30128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60075B0")]
		[Address(RVA = "0x31B81BC", Offset = "0x31B81BC", VA = "0x31B81BC")]
		public static void LerpFloatValue(this Animator animator, string name = "RunWalk", float value = 0f, float deltaSpeed = 8f)
		{
		}

		// Token: 0x060075B1 RID: 30129 RVA: 0x00051D80 File Offset: 0x0004FF80
		[Token(Token = "0x60075B1")]
		[Address(RVA = "0x31B823C", Offset = "0x31B823C", VA = "0x31B823C")]
		public static bool CheckAnimationEnd(this Animator animator, int layer = 0, bool reverse = false, bool checkAnimLoop = true)
		{
			return default(bool);
		}

		// Token: 0x060075B2 RID: 30130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60075B2")]
		[Address(RVA = "0x31B8314", Offset = "0x31B8314", VA = "0x31B8314")]
		public static void ResetLayersWeights(this Animator animator, float speed = 10f)
		{
		}

		// Token: 0x060075B3 RID: 30131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60075B3")]
		[Address(RVA = "0x31B8418", Offset = "0x31B8418", VA = "0x31B8418")]
		public static void LerpLayerWeight(this Animator animator, int layer = 0, float newValue = 1f, float speed = 8f)
		{
		}

		// Token: 0x060075B4 RID: 30132 RVA: 0x00051D98 File Offset: 0x0004FF98
		[Token(Token = "0x60075B4")]
		[Address(RVA = "0x31B8498", Offset = "0x31B8498", VA = "0x31B8498")]
		public static bool StateExists(this Animator animator, string clipName, int layer = 0)
		{
			return default(bool);
		}
	}
}
