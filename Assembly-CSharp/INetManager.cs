using System;
using GameKit.Base;
using Il2CppDummyDll;
using Sfs2X.Core;

// Token: 0x02000225 RID: 549
[Token(Token = "0x2000225")]
public interface INetManager
{
	// Token: 0x06000EAA RID: 3754
	[Token(Token = "0x6000EAA")]
	bool OnConnection(INetProxy proxy, BaseEvent e);

	// Token: 0x06000EAB RID: 3755
	[Token(Token = "0x6000EAB")]
	void OnConnectionLost(string reason, INetProxy proxy);

	// Token: 0x06000EAC RID: 3756
	[Token(Token = "0x6000EAC")]
	void OnLogout(BaseEvent e);

	// Token: 0x06000EAD RID: 3757
	[Token(Token = "0x6000EAD")]
	void OnLogin(BaseEvent e);

	// Token: 0x06000EAE RID: 3758
	[Token(Token = "0x6000EAE")]
	void OnLoginError(BaseEvent e);
}
