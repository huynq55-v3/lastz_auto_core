using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000295 RID: 661
[Token(Token = "0x2000295")]
public class ViewStatusListener : MonoBehaviour
{
	// Token: 0x06001178 RID: 4472 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001178")]
	[Address(RVA = "0x1C50E28", Offset = "0x1C50E28", VA = "0x1C50E28")]
	public void SetCallback(Action<bool> ck)
	{
	}

	// Token: 0x06001179 RID: 4473 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001179")]
	[Address(RVA = "0x1C50E30", Offset = "0x1C50E30", VA = "0x1C50E30")]
	private void OnBecameVisible()
	{
	}

	// Token: 0x0600117A RID: 4474 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600117A")]
	[Address(RVA = "0x1C50E50", Offset = "0x1C50E50", VA = "0x1C50E50")]
	private void OnBecameInvisible()
	{
	}

	// Token: 0x0600117B RID: 4475 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600117B")]
	[Address(RVA = "0x1C50E70", Offset = "0x1C50E70", VA = "0x1C50E70")]
	private void OnDestroy()
	{
	}

	// Token: 0x0600117C RID: 4476 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600117C")]
	[Address(RVA = "0x1C50E7C", Offset = "0x1C50E7C", VA = "0x1C50E7C")]
	public ViewStatusListener()
	{
	}

	// Token: 0x0400143A RID: 5178
	[Token(Token = "0x400143A")]
	[FieldOffset(Offset = "0x18")]
	private Action<bool> callback;
}
