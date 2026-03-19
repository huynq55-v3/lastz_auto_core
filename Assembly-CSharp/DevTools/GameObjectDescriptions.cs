using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Scripting;

namespace DevTools
{
	// Token: 0x02000D03 RID: 3331
	[Token(Token = "0x2000D03")]
	[Preserve]
	public static class GameObjectDescriptions
	{
		// Token: 0x06007CA0 RID: 31904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007CA0")]
		[Address(RVA = "0x319F498", Offset = "0x319F498", VA = "0x319F498")]
		public static void AddDesc(GameObject go, string desc, string callstack)
		{
		}

		// Token: 0x06007CA1 RID: 31905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007CA1")]
		[Address(RVA = "0x319F718", Offset = "0x319F718", VA = "0x319F718")]
		public static void RemoveDesc(GameObject go, string desc)
		{
		}

		// Token: 0x06007CA2 RID: 31906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007CA2")]
		[Address(RVA = "0x319F8E8", Offset = "0x319F8E8", VA = "0x319F8E8")]
		public static void Clear()
		{
		}

		// Token: 0x06007CA3 RID: 31907 RVA: 0x00054A20 File Offset: 0x00052C20
		[Token(Token = "0x6007CA3")]
		[Address(RVA = "0x319F960", Offset = "0x319F960", VA = "0x319F960")]
		public static bool GetDescriptions(int goInstanceId, out List<Description> descriptions)
		{
			return default(bool);
		}

		// Token: 0x06007CA4 RID: 31908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007CA4")]
		[Address(RVA = "0x319F9F0", Offset = "0x319F9F0", VA = "0x319F9F0")]
		[RuntimeInitializeOnLoadMethod]
		private static void InitializeOnLoad()
		{
		}

		// Token: 0x04003899 RID: 14489
		[Token(Token = "0x4003899")]
		[FieldOffset(Offset = "0x0")]
		public static bool Enabled;

		// Token: 0x0400389A RID: 14490
		[Token(Token = "0x400389A")]
		[FieldOffset(Offset = "0x8")]
		private static Dictionary<int, List<Description>> _descriptions;
	}
}
