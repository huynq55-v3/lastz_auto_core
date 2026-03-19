using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Sfs2X.Entities.Data
{
	// Token: 0x02000A74 RID: 2676
	[Token(Token = "0x2000A74")]
	public class SFSArrayEnumerator : IEnumerator
	{
		// Token: 0x060065F7 RID: 26103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065F7")]
		[Address(RVA = "0x2E0DA4C", Offset = "0x2E0DA4C", VA = "0x2E0DA4C")]
		public SFSArrayEnumerator(List<SFSDataWrapper> data)
		{
		}

		// Token: 0x060065F8 RID: 26104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065F8")]
		[Address(RVA = "0x2E0DADC", Offset = "0x2E0DADC", VA = "0x2E0DADC", Slot = "6")]
		private void System.Collections.IEnumerator.Reset()
		{
		}

		// Token: 0x060065F9 RID: 26105 RVA: 0x0004C3E0 File Offset: 0x0004A5E0
		[Token(Token = "0x60065F9")]
		[Address(RVA = "0x2E0DAE8", Offset = "0x2E0DAE8", VA = "0x2E0DAE8", Slot = "4")]
		private bool System.Collections.IEnumerator.MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170006B7 RID: 1719
		// (get) Token: 0x060065FA RID: 26106 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006B7")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60065FA")]
			[Address(RVA = "0x2E0DB4C", Offset = "0x2E0DB4C", VA = "0x2E0DB4C", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x040028BB RID: 10427
		[Token(Token = "0x40028BB")]
		[FieldOffset(Offset = "0x10")]
		private List<SFSDataWrapper> data;

		// Token: 0x040028BC RID: 10428
		[Token(Token = "0x40028BC")]
		[FieldOffset(Offset = "0x18")]
		private int cursorIndex;
	}
}
