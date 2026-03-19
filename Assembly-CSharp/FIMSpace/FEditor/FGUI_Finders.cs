using System;
using Il2CppDummyDll;
using UnityEngine;

namespace FIMSpace.FEditor
{
	// Token: 0x02000C12 RID: 3090
	[Token(Token = "0x2000C12")]
	public static class FGUI_Finders
	{
		// Token: 0x06007631 RID: 30257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007631")]
		[Address(RVA = "0x2EBD85C", Offset = "0x2EBD85C", VA = "0x2EBD85C")]
		public static void ResetFinders(bool resetClicks = true)
		{
		}

		// Token: 0x06007632 RID: 30258 RVA: 0x000526F8 File Offset: 0x000508F8
		[Token(Token = "0x6007632")]
		[Address(RVA = "0x2EBD8F0", Offset = "0x2EBD8F0", VA = "0x2EBD8F0")]
		public static bool CheckForAnimator(GameObject root, bool needAnimatorBox = true, bool drawInactiveWarning = true, int clicksTohide = 1)
		{
			return default(bool);
		}

		// Token: 0x06007633 RID: 30259 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007633")]
		[Address(RVA = "0x2EBDB64", Offset = "0x2EBDB64", VA = "0x2EBDB64")]
		public static Component SearchForParentWithAnimator(GameObject root)
		{
			return null;
		}

		// Token: 0x06007634 RID: 30260 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007634")]
		[Address(RVA = "0x2EBDD78", Offset = "0x2EBDD78", VA = "0x2EBDD78")]
		public static SkinnedMeshRenderer GetBoneSearchArray(Transform root)
		{
			return null;
		}

		// Token: 0x06007635 RID: 30261 RVA: 0x00052710 File Offset: 0x00050910
		[Token(Token = "0x6007635")]
		[Address(RVA = "0x2EBE1B8", Offset = "0x2EBE1B8", VA = "0x2EBE1B8")]
		public static bool IsChildOf(Transform child, Transform rootParent)
		{
			return default(bool);
		}

		// Token: 0x06007636 RID: 30262 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007636")]
		[Address(RVA = "0x2EBE290", Offset = "0x2EBE290", VA = "0x2EBE290")]
		public static Transform GetLastChild(Transform rootParent)
		{
			return null;
		}

		// Token: 0x06007637 RID: 30263 RVA: 0x00052728 File Offset: 0x00050928
		[Token(Token = "0x6007637")]
		[Address(RVA = "0x2EBE2D8", Offset = "0x2EBE2D8", VA = "0x2EBE2D8")]
		public static bool? IsRightOrLeft(string name, bool includeNotSure = false)
		{
			return default(bool?);
		}

		// Token: 0x06007638 RID: 30264 RVA: 0x00052740 File Offset: 0x00050940
		[Token(Token = "0x6007638")]
		[Address(RVA = "0x2EBE5C0", Offset = "0x2EBE5C0", VA = "0x2EBE5C0")]
		public static bool? IsRightOrLeft(Transform child, Transform itsRoot)
		{
			return default(bool?);
		}

		// Token: 0x06007639 RID: 30265 RVA: 0x00052758 File Offset: 0x00050958
		[Token(Token = "0x6007639")]
		[Address(RVA = "0x2EBE664", Offset = "0x2EBE664", VA = "0x2EBE664")]
		public static bool HaveKey(string text, string[] keys)
		{
			return default(bool);
		}

		// Token: 0x04002FDE RID: 12254
		[Token(Token = "0x4002FDE")]
		[FieldOffset(Offset = "0x0")]
		public static Component FoundAnimator;

		// Token: 0x04002FDF RID: 12255
		[Token(Token = "0x4002FDF")]
		[FieldOffset(Offset = "0x8")]
		private static bool checkForAnim;

		// Token: 0x04002FE0 RID: 12256
		[Token(Token = "0x4002FE0")]
		[FieldOffset(Offset = "0xC")]
		private static int clicks;
	}
}
