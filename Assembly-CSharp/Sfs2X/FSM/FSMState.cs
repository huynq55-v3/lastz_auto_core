using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Sfs2X.FSM
{
	// Token: 0x02000A6D RID: 2669
	[Token(Token = "0x2000A6D")]
	public class FSMState
	{
		// Token: 0x0600653F RID: 25919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600653F")]
		[Address(RVA = "0x2E0BD1C", Offset = "0x2E0BD1C", VA = "0x2E0BD1C")]
		public void SetStateName(int newStateName)
		{
		}

		// Token: 0x06006540 RID: 25920 RVA: 0x0004C290 File Offset: 0x0004A490
		[Token(Token = "0x6006540")]
		[Address(RVA = "0x2E0BD24", Offset = "0x2E0BD24", VA = "0x2E0BD24")]
		public int GetStateName()
		{
			return 0;
		}

		// Token: 0x06006541 RID: 25921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006541")]
		[Address(RVA = "0x2E0B754", Offset = "0x2E0B754", VA = "0x2E0B754")]
		public void AddTransition(int transition, int outputState)
		{
		}

		// Token: 0x06006542 RID: 25922 RVA: 0x0004C2A8 File Offset: 0x0004A4A8
		[Token(Token = "0x6006542")]
		[Address(RVA = "0x2E0B918", Offset = "0x2E0B918", VA = "0x2E0B918")]
		public int ApplyTransition(int transition)
		{
			return 0;
		}

		// Token: 0x06006543 RID: 25923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006543")]
		[Address(RVA = "0x2E0B334", Offset = "0x2E0B334", VA = "0x2E0B334")]
		public FSMState()
		{
		}

		// Token: 0x040028B6 RID: 10422
		[Token(Token = "0x40028B6")]
		[FieldOffset(Offset = "0x10")]
		private Dictionary<int, int> transitions;

		// Token: 0x040028B7 RID: 10423
		[Token(Token = "0x40028B7")]
		[FieldOffset(Offset = "0x18")]
		private int stateName;
	}
}
