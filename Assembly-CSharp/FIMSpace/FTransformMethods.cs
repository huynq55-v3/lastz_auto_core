using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace FIMSpace
{
	// Token: 0x02000C0F RID: 3087
	[Token(Token = "0x2000C0F")]
	public static class FTransformMethods
	{
		// Token: 0x0600760E RID: 30222 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600760E")]
		[Address(RVA = "0x31BB43C", Offset = "0x31BB43C", VA = "0x31BB43C")]
		public static Transform FindChildByNameInDepth(string name, Transform transform, bool findInDeactivated = true, [Optional] string[] additionalContains)
		{
			return null;
		}

		// Token: 0x0600760F RID: 30223 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600760F")]
		public static List<T> FindComponentsInAllChildren<T>(Transform transformToSearchIn, bool includeInactive = false, bool tryGetMultipleOutOfSingleObject = false) where T : Component
		{
			return null;
		}

		// Token: 0x06007610 RID: 30224 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007610")]
		public static T FindComponentInAllChildren<T>(Transform transformToSearchIn) where T : Component
		{
			return null;
		}

		// Token: 0x06007611 RID: 30225 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007611")]
		public static T FindComponentInAllParents<T>(Transform transformToSearchIn) where T : Component
		{
			return null;
		}

		// Token: 0x06007612 RID: 30226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007612")]
		[Address(RVA = "0x31BB5DC", Offset = "0x31BB5DC", VA = "0x31BB5DC")]
		public static void ChangeActiveChildrenInside(Transform parentOfThem, bool active)
		{
		}

		// Token: 0x06007613 RID: 30227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007613")]
		[Address(RVA = "0x31BB65C", Offset = "0x31BB65C", VA = "0x31BB65C")]
		public static void ChangeActiveThroughParentTo(Transform start, Transform end, bool active, bool changeParentsChildrenActivation = false)
		{
		}
	}
}
