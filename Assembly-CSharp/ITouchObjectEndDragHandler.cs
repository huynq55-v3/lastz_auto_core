using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200003D RID: 61
[Token(Token = "0x200003D")]
public interface ITouchObjectEndDragHandler : ITouchObject
{
	// Token: 0x060000C7 RID: 199
	[Token(Token = "0x60000C7")]
	bool OnEndDrag(Vector3 dragStopPos);
}
