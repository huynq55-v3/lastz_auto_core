using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

// Token: 0x0200037C RID: 892
[Token(Token = "0x200037C")]
[Hotfix(HotfixFlag.Stateless)]
public class CoroutineRunner : MonoBehaviour
{
	// Token: 0x060016A8 RID: 5800 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60016A8")]
	[Address(RVA = "0x1EE2570", Offset = "0x1EE2570", VA = "0x1EE2570")]
	public void YieldAndCallback(object toYield, Action callback)
	{
	}

	// Token: 0x060016A9 RID: 5801 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60016A9")]
	[Address(RVA = "0x1EE2590", Offset = "0x1EE2590", VA = "0x1EE2590")]
	private IEnumerator CoBody(object toYield, Action callback)
	{
		return null;
	}

	// Token: 0x060016AA RID: 5802 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60016AA")]
	[Address(RVA = "0x1EE265C", Offset = "0x1EE265C", VA = "0x1EE265C")]
	public CoroutineRunner()
	{
	}
}
