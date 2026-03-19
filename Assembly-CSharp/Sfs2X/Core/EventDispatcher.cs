using System;
using System.Collections;
using Il2CppDummyDll;

namespace Sfs2X.Core
{
	// Token: 0x02000A7C RID: 2684
	[Token(Token = "0x2000A7C")]
	public class EventDispatcher
	{
		// Token: 0x06006687 RID: 26247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006687")]
		[Address(RVA = "0x33BD55C", Offset = "0x33BD55C", VA = "0x33BD55C")]
		public EventDispatcher(object target)
		{
		}

		// Token: 0x06006688 RID: 26248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006688")]
		[Address(RVA = "0x33BD5EC", Offset = "0x33BD5EC", VA = "0x33BD5EC")]
		public void AddEventListener(string eventType, EventListenerDelegate listener)
		{
		}

		// Token: 0x06006689 RID: 26249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006689")]
		[Address(RVA = "0x33BD6B4", Offset = "0x33BD6B4", VA = "0x33BD6B4")]
		public void RemoveEventListener(string eventType, EventListenerDelegate listener)
		{
		}

		// Token: 0x0600668A RID: 26250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600668A")]
		[Address(RVA = "0x33BD78C", Offset = "0x33BD78C", VA = "0x33BD78C")]
		public void DispatchEvent(BaseEvent evt)
		{
		}

		// Token: 0x0600668B RID: 26251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600668B")]
		[Address(RVA = "0x33BD92C", Offset = "0x33BD92C", VA = "0x33BD92C")]
		public void RemoveAll()
		{
		}

		// Token: 0x040028E2 RID: 10466
		[Token(Token = "0x40028E2")]
		[FieldOffset(Offset = "0x10")]
		private Hashtable listeners;

		// Token: 0x040028E3 RID: 10467
		[Token(Token = "0x40028E3")]
		[FieldOffset(Offset = "0x18")]
		private object target;
	}
}
