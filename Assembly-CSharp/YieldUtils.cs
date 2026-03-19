using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200015E RID: 350
[Token(Token = "0x200015E")]
internal static class YieldUtils
{
	// Token: 0x06000A21 RID: 2593 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A21")]
	[Address(RVA = "0x3711FB8", Offset = "0x3711FB8", VA = "0x3711FB8")]
	public static WaitForFixedUpdate WaitForFixedUpdate()
	{
		return null;
	}

	// Token: 0x06000A22 RID: 2594 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A22")]
	[Address(RVA = "0x3712010", Offset = "0x3712010", VA = "0x3712010")]
	public static WaitForEndOfFrame WaitForEndOfFrame()
	{
		return null;
	}

	// Token: 0x06000A23 RID: 2595 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A23")]
	[Address(RVA = "0x3712068", Offset = "0x3712068", VA = "0x3712068")]
	public static WaitForSeconds WaitForSeconds(float seconds)
	{
		return null;
	}

	// Token: 0x06000A24 RID: 2596 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A24")]
	[Address(RVA = "0x3712188", Offset = "0x3712188", VA = "0x3712188")]
	public static WaitForSecondsRealtime WaitForSecondsRealtime(float seconds)
	{
		return null;
	}

	// Token: 0x06000A25 RID: 2597 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A25")]
	[Address(RVA = "0x37122A8", Offset = "0x37122A8", VA = "0x37122A8")]
	public static Coroutine DelayAction(MonoBehaviour context, Action action, float delay)
	{
		return null;
	}

	// Token: 0x06000A26 RID: 2598 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A26")]
	[Address(RVA = "0x37122E4", Offset = "0x37122E4", VA = "0x37122E4")]
	public static void StopDelayAction(MonoBehaviour context, Coroutine coroutine)
	{
	}

	// Token: 0x06000A27 RID: 2599 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A27")]
	[Address(RVA = "0x3712300", Offset = "0x3712300", VA = "0x3712300")]
	public static Coroutine DoEndOfFrame(MonoBehaviour context, Action action)
	{
		return null;
	}

	// Token: 0x06000A28 RID: 2600 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A28")]
	[Address(RVA = "0x371233C", Offset = "0x371233C", VA = "0x371233C")]
	public static Coroutine DelayActionWithOutContext(Action action, float delay)
	{
		return null;
	}

	// Token: 0x06000A29 RID: 2601 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A29")]
	[Address(RVA = "0x371238C", Offset = "0x371238C", VA = "0x371238C")]
	public static void StopDelayActionWithOutContext(Coroutine coroutine)
	{
	}

	// Token: 0x06000A2A RID: 2602 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A2A")]
	[Address(RVA = "0x37123B4", Offset = "0x37123B4", VA = "0x37123B4")]
	public static Coroutine StartCoroutine(IEnumerator cor)
	{
		return null;
	}

	// Token: 0x06000A2B RID: 2603 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A2B")]
	[Address(RVA = "0x37123DC", Offset = "0x37123DC", VA = "0x37123DC")]
	public static void StopCoroutine(Coroutine cor)
	{
	}

	// Token: 0x04000768 RID: 1896
	[Token(Token = "0x4000768")]
	[FieldOffset(Offset = "0x0")]
	private static readonly WaitForEndOfFrame EndOfFrame;

	// Token: 0x04000769 RID: 1897
	[Token(Token = "0x4000769")]
	[FieldOffset(Offset = "0x8")]
	private static readonly WaitForFixedUpdate FixedUpdate;

	// Token: 0x0400076A RID: 1898
	[Token(Token = "0x400076A")]
	[FieldOffset(Offset = "0x10")]
	private static readonly Dictionary<float, WaitForSeconds> _waitSecondsCache;

	// Token: 0x0400076B RID: 1899
	[Token(Token = "0x400076B")]
	[FieldOffset(Offset = "0x18")]
	private static readonly Dictionary<float, WaitForSecondsRealtime> _waitSecondsRealTimeCache;

	// Token: 0x0200015F RID: 351
	[Token(Token = "0x200015F")]
	private class CoroutineUtil : MonoBehaviour
	{
		// Token: 0x17000157 RID: 343
		// (get) Token: 0x06000A2D RID: 2605 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000157")]
		private static YieldUtils.CoroutineUtil Instance
		{
			[Token(Token = "0x6000A2D")]
			[Address(RVA = "0x37125D4", Offset = "0x37125D4", VA = "0x37125D4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000A2E RID: 2606 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A2E")]
		[Address(RVA = "0x37123B8", Offset = "0x37123B8", VA = "0x37123B8")]
		public static Coroutine NStartCoroutine(IEnumerator cor)
		{
			return null;
		}

		// Token: 0x06000A2F RID: 2607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A2F")]
		[Address(RVA = "0x37123E0", Offset = "0x37123E0", VA = "0x37123E0")]
		public static void NStopCoroutine(Coroutine cor)
		{
		}

		// Token: 0x06000A30 RID: 2608 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A30")]
		[Address(RVA = "0x37127F0", Offset = "0x37127F0", VA = "0x37127F0")]
		private static IEnumerator DelayAction(float delay, Action action)
		{
			return null;
		}

		// Token: 0x06000A31 RID: 2609 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A31")]
		[Address(RVA = "0x3712340", Offset = "0x3712340", VA = "0x3712340")]
		public static Coroutine DoDelayAction(float delay, Action action)
		{
			return null;
		}

		// Token: 0x06000A32 RID: 2610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A32")]
		[Address(RVA = "0x3712390", Offset = "0x3712390", VA = "0x3712390")]
		public static void StopDelayAction(Coroutine coroutine)
		{
		}

		// Token: 0x06000A33 RID: 2611 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A33")]
		[Address(RVA = "0x37122B8", Offset = "0x37122B8", VA = "0x37122B8")]
		public static Coroutine DoDelayByContext(MonoBehaviour context, float delay, Action action)
		{
			return null;
		}

		// Token: 0x06000A34 RID: 2612 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A34")]
		[Address(RVA = "0x3712310", Offset = "0x3712310", VA = "0x3712310")]
		public static Coroutine DoEndOfFrame(MonoBehaviour context, Action action)
		{
			return null;
		}

		// Token: 0x06000A35 RID: 2613 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A35")]
		[Address(RVA = "0x371289C", Offset = "0x371289C", VA = "0x371289C")]
		private static IEnumerator DelayEndOfFrame(Action action)
		{
			return null;
		}

		// Token: 0x06000A36 RID: 2614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A36")]
		[Address(RVA = "0x3712938", Offset = "0x3712938", VA = "0x3712938")]
		public static void DoDelayRealTimeAction(float dTime, Action callback)
		{
		}

		// Token: 0x06000A37 RID: 2615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A37")]
		[Address(RVA = "0x3712A08", Offset = "0x3712A08", VA = "0x3712A08")]
		public static void DoRealDelayByContext(MonoBehaviour context, float dTime, Action callback)
		{
		}

		// Token: 0x06000A38 RID: 2616 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A38")]
		[Address(RVA = "0x3712984", Offset = "0x3712984", VA = "0x3712984")]
		public static IEnumerator DelayRealTimeAction(float dTime, Action callback)
		{
			return null;
		}

		// Token: 0x06000A39 RID: 2617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A39")]
		[Address(RVA = "0x3712A5C", Offset = "0x3712A5C", VA = "0x3712A5C")]
		public CoroutineUtil()
		{
		}

		// Token: 0x0400076C RID: 1900
		[Token(Token = "0x400076C")]
		[FieldOffset(Offset = "0x0")]
		private static YieldUtils.CoroutineUtil _instance;
	}
}
