using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000299 RID: 665
[Token(Token = "0x2000299")]
public interface ICulling
{
	// Token: 0x170001FA RID: 506
	// (get) Token: 0x06001190 RID: 4496
	// (set) Token: 0x0600118F RID: 4495
	[Token(Token = "0x170001FA")]
	int indexId
	{
		[Token(Token = "0x6001190")]
		get;
		[Token(Token = "0x600118F")]
		set;
	}

	// Token: 0x06001191 RID: 4497
	[Token(Token = "0x6001191")]
	BoundingSphere GetBoundingSphere();

	// Token: 0x06001192 RID: 4498
	[Token(Token = "0x6001192")]
	void OnCullingStateVisible(bool visible);
}
