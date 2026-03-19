using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000036 RID: 54
[Token(Token = "0x2000036")]
public interface ITouchPickable
{
	// Token: 0x060000AC RID: 172
	[Token(Token = "0x60000AC")]
	bool CanLongTap();

	// Token: 0x060000AD RID: 173
	[Token(Token = "0x60000AD")]
	Transform GetTransform();

	// Token: 0x060000AE RID: 174
	[Token(Token = "0x60000AE")]
	T GetPickComponent<T>() where T : MonoBehaviour;

	// Token: 0x060000AF RID: 175
	[Token(Token = "0x60000AF")]
	bool PointInPick();

	// Token: 0x060000B0 RID: 176
	[Token(Token = "0x60000B0")]
	void Drag(Vector3 pos);

	// Token: 0x060000B1 RID: 177
	[Token(Token = "0x60000B1")]
	bool Select();

	// Token: 0x060000B2 RID: 178
	[Token(Token = "0x60000B2")]
	void Click();

	// Token: 0x060000B3 RID: 179
	[Token(Token = "0x60000B3")]
	bool IsOutRange(Vector3 pos);

	// Token: 0x060000B4 RID: 180
	[Token(Token = "0x60000B4")]
	void ChangeTouchPos(int index);

	// Token: 0x060000B5 RID: 181
	[Token(Token = "0x60000B5")]
	Vector3 GetClosestPoint(Vector3 pos);
}
