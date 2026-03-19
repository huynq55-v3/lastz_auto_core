using System;
using Il2CppDummyDll;
using NiceJson;

namespace Mopsicus.Plugins
{
	// Token: 0x020004A5 RID: 1189
	[Token(Token = "0x20004A5")]
	public interface IPlugin
	{
		// Token: 0x1700053A RID: 1338
		// (get) Token: 0x06002317 RID: 8983
		[Token(Token = "0x1700053A")]
		string Name
		{
			[Token(Token = "0x6002317")]
			get;
		}

		// Token: 0x06002318 RID: 8984
		[Token(Token = "0x6002318")]
		void OnData(JsonObject data);

		// Token: 0x06002319 RID: 8985
		[Token(Token = "0x6002319")]
		void OnError(JsonObject data);
	}
}
