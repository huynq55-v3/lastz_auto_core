using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200003B RID: 59
[Token(Token = "0x200003B")]
public interface ITouchObjectBeginDragHandler : ITouchObject
{
	// Token: 0x060000C5 RID: 197
	[Token(Token = "0x60000C5")]
	bool OnBeginDrag(Vector3 dragStartPos);
}
