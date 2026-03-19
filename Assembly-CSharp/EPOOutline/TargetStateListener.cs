using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace EPOOutline
{
	// Token: 0x02000CAC RID: 3244
	[Token(Token = "0x2000CAC")]
	[ExecuteAlways]
	public class TargetStateListener : MonoBehaviour
	{
		// Token: 0x06007AC7 RID: 31431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007AC7")]
		[Address(RVA = "0x321D154", Offset = "0x321D154", VA = "0x321D154")]
		public void AddCallback(Outlinable outlinable, Action action)
		{
		}

		// Token: 0x06007AC8 RID: 31432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007AC8")]
		[Address(RVA = "0x321D274", Offset = "0x321D274", VA = "0x321D274")]
		public void RemoveCallback(Outlinable outlinable, Action callback)
		{
		}

		// Token: 0x06007AC9 RID: 31433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007AC9")]
		[Address(RVA = "0x321D3B8", Offset = "0x321D3B8", VA = "0x321D3B8")]
		private void Awake()
		{
		}

		// Token: 0x06007ACA RID: 31434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007ACA")]
		[Address(RVA = "0x321D3C4", Offset = "0x321D3C4", VA = "0x321D3C4")]
		public void ForceUpdate()
		{
		}

		// Token: 0x06007ACB RID: 31435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007ACB")]
		[Address(RVA = "0x321D5EC", Offset = "0x321D5EC", VA = "0x321D5EC")]
		private void OnBecameVisible()
		{
		}

		// Token: 0x06007ACC RID: 31436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007ACC")]
		[Address(RVA = "0x321D5F0", Offset = "0x321D5F0", VA = "0x321D5F0")]
		private void OnBecameInvisible()
		{
		}

		// Token: 0x06007ACD RID: 31437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007ACD")]
		[Address(RVA = "0x321D5F4", Offset = "0x321D5F4", VA = "0x321D5F4")]
		public TargetStateListener()
		{
		}

		// Token: 0x0400360B RID: 13835
		[Token(Token = "0x400360B")]
		[FieldOffset(Offset = "0x18")]
		private List<TargetStateListener.Callback> callbacks;

		// Token: 0x02000CAD RID: 3245
		[Token(Token = "0x2000CAD")]
		public struct Callback
		{
			// Token: 0x06007ACE RID: 31438 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007ACE")]
			[Address(RVA = "0x321D244", Offset = "0x321D244", VA = "0x321D244")]
			public Callback(Outlinable target, Action action)
			{
			}

			// Token: 0x0400360C RID: 13836
			[Token(Token = "0x400360C")]
			[FieldOffset(Offset = "0x0")]
			public readonly Outlinable Target;

			// Token: 0x0400360D RID: 13837
			[Token(Token = "0x400360D")]
			[FieldOffset(Offset = "0x8")]
			public readonly Action Action;
		}
	}
}
