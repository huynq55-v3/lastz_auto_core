using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace GameKit.Base
{
	// Token: 0x020004E2 RID: 1250
	[Token(Token = "0x20004E2")]
	public static class ComponentExtensions
	{
		// Token: 0x060025E3 RID: 9699 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025E3")]
		public static T GetOrAddComponent<T>(this Component comp, bool set_enable = false) where T : Component
		{
			return null;
		}

		// Token: 0x060025E4 RID: 9700 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025E4")]
		public static T GetOrAddComponent<T>(this GameObject go, bool set_enable = false) where T : Component
		{
			return null;
		}

		// Token: 0x060025E5 RID: 9701 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025E5")]
		[Address(RVA = "0x2B591DC", Offset = "0x2B591DC", VA = "0x2B591DC")]
		public static Component GetOrAddComponent(this Component comp, Type type, bool set_enable = false)
		{
			return null;
		}

		// Token: 0x060025E6 RID: 9702 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025E6")]
		[Address(RVA = "0x2B59320", Offset = "0x2B59320", VA = "0x2B59320")]
		public static Component GetOrAddComponent(this GameObject go, Type type, bool set_enable = false)
		{
			return null;
		}

		// Token: 0x060025E7 RID: 9703 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025E7")]
		[Address(RVA = "0x2B59458", Offset = "0x2B59458", VA = "0x2B59458")]
		public static void ScrollRect_EndDrag(this ScrollRect scrollRect)
		{
		}

		// Token: 0x060025E8 RID: 9704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025E8")]
		[Address(RVA = "0x2B59518", Offset = "0x2B59518", VA = "0x2B59518")]
		public static void ScrollView_EndDrag(this ScrollView scrollView)
		{
		}
	}
}
