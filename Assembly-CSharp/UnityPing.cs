using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000242 RID: 578
[Token(Token = "0x2000242")]
public class UnityPing : MonoBehaviour
{
	// Token: 0x06000F7D RID: 3965 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F7D")]
	[Address(RVA = "0x1BE3F9C", Offset = "0x1BE3F9C", VA = "0x1BE3F9C")]
	public void CreatePing(string ip, Action<int> callback)
	{
	}

	// Token: 0x06000F7E RID: 3966 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F7E")]
	[Address(RVA = "0x1BE40AC", Offset = "0x1BE40AC", VA = "0x1BE40AC")]
	private void OnDestroy()
	{
	}

	// Token: 0x06000F7F RID: 3967 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F7F")]
	[Address(RVA = "0x1BE4038", Offset = "0x1BE4038", VA = "0x1BE4038")]
	private IEnumerator PingConnect()
	{
		return null;
	}

	// Token: 0x06000F80 RID: 3968 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F80")]
	[Address(RVA = "0x1BE414C", Offset = "0x1BE414C", VA = "0x1BE414C")]
	public UnityPing()
	{
	}

	// Token: 0x0400121D RID: 4637
	[Token(Token = "0x400121D")]
	[FieldOffset(Offset = "0x18")]
	private string s_ip;

	// Token: 0x0400121E RID: 4638
	[Token(Token = "0x400121E")]
	[FieldOffset(Offset = "0x20")]
	private Action<int> s_callback;

	// Token: 0x0400121F RID: 4639
	[Token(Token = "0x400121F")]
	[FieldOffset(Offset = "0x28")]
	private int s_timeout;

	// Token: 0x04001220 RID: 4640
	[Token(Token = "0x4001220")]
	[FieldOffset(Offset = "0x30")]
	private Coroutine curCoroutine;
}
