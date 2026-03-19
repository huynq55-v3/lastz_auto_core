using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200003C RID: 60
[Token(Token = "0x200003C")]
public interface ITouchObjectDragHandler : ITouchObject
{
	// Token: 0x060000C6 RID: 198
	[Token(Token = "0x60000C6")]
	bool OnDrag(Vector3 dragStartPos, Vector3 dragCurrPos);
}
