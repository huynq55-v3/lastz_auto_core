using System;
using Il2CppDummyDll;

namespace Sfs2X.Core
{
	// Token: 0x02000A7F RID: 2687
	[Token(Token = "0x2000A7F")]
	public interface IDispatchable
	{
		// Token: 0x170006C8 RID: 1736
		// (get) Token: 0x06006691 RID: 26257
		[Token(Token = "0x170006C8")]
		EventDispatcher Dispatcher
		{
			[Token(Token = "0x6006691")]
			get;
		}

		// Token: 0x06006692 RID: 26258
		[Token(Token = "0x6006692")]
		void AddEventListener(string eventType, EventListenerDelegate listener);
	}
}
