using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Sfs2X.FSM
{
	// Token: 0x02000A6B RID: 2667
	[Token(Token = "0x2000A6B")]
	public class FiniteStateMachine
	{
		// Token: 0x06006533 RID: 25907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006533")]
		[Address(RVA = "0x2E0B2A4", Offset = "0x2E0B2A4", VA = "0x2E0B2A4")]
		public void AddState(int st)
		{
		}

		// Token: 0x06006534 RID: 25908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006534")]
		[Address(RVA = "0x2E0B3BC", Offset = "0x2E0B3BC", VA = "0x2E0B3BC")]
		public void AddAllStates(Type statesEnumType)
		{
		}

		// Token: 0x06006535 RID: 25909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006535")]
		[Address(RVA = "0x2E0B6AC", Offset = "0x2E0B6AC", VA = "0x2E0B6AC")]
		public void AddStateTransition(int from, int to, int tr)
		{
		}

		// Token: 0x06006536 RID: 25910 RVA: 0x0004C260 File Offset: 0x0004A460
		[Token(Token = "0x6006536")]
		[Address(RVA = "0x2E0B7BC", Offset = "0x2E0B7BC", VA = "0x2E0B7BC")]
		public int ApplyTransition(int tr)
		{
			return 0;
		}

		// Token: 0x06006537 RID: 25911 RVA: 0x0004C278 File Offset: 0x0004A478
		[Token(Token = "0x6006537")]
		[Address(RVA = "0x2E0B9B0", Offset = "0x2E0B9B0", VA = "0x2E0B9B0")]
		public int GetCurrentState()
		{
			return 0;
		}

		// Token: 0x06006538 RID: 25912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006538")]
		[Address(RVA = "0x2E0BA78", Offset = "0x2E0BA78", VA = "0x2E0BA78")]
		public void SetCurrentState(int state)
		{
		}

		// Token: 0x06006539 RID: 25913 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006539")]
		[Address(RVA = "0x2E0B6DC", Offset = "0x2E0B6DC", VA = "0x2E0B6DC")]
		private FSMState FindStateObjByName(int st)
		{
			return null;
		}

		// Token: 0x0600653A RID: 25914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600653A")]
		[Address(RVA = "0x2E0BACC", Offset = "0x2E0BACC", VA = "0x2E0BACC")]
		public FiniteStateMachine()
		{
		}

		// Token: 0x040028B2 RID: 10418
		[Token(Token = "0x40028B2")]
		[FieldOffset(Offset = "0x10")]
		private Dictionary<int, FSMState> states;

		// Token: 0x040028B3 RID: 10419
		[Token(Token = "0x40028B3")]
		[FieldOffset(Offset = "0x18")]
		private object locker;

		// Token: 0x040028B4 RID: 10420
		[Token(Token = "0x40028B4")]
		[FieldOffset(Offset = "0x20")]
		private int currentStateName;

		// Token: 0x040028B5 RID: 10421
		[Token(Token = "0x40028B5")]
		[FieldOffset(Offset = "0x28")]
		public FiniteStateMachine.OnStateChangeDelegate onStateChange;

		// Token: 0x02000A6C RID: 2668
		// (Invoke) Token: 0x0600653C RID: 25916
		[Token(Token = "0x2000A6C")]
		public delegate void OnStateChangeDelegate(int fromStateName, int toStateName);
	}
}
