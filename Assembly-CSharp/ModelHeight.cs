using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002A4 RID: 676
[Token(Token = "0x20002A4")]
public class ModelHeight : MonoBehaviour
{
	// Token: 0x060011AD RID: 4525 RVA: 0x00006F90 File Offset: 0x00005190
	[Token(Token = "0x60011AD")]
	[Address(RVA = "0x1C532AC", Offset = "0x1C532AC", VA = "0x1C532AC")]
	public float GetHeight()
	{
		return 0f;
	}

	// Token: 0x060011AE RID: 4526 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011AE")]
	[Address(RVA = "0x1C532B8", Offset = "0x1C532B8", VA = "0x1C532B8")]
	public ModelHeight()
	{
	}

	// Token: 0x04001480 RID: 5248
	[Token(Token = "0x4001480")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject _modelObj;

	// Token: 0x04001481 RID: 5249
	[Token(Token = "0x4001481")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float height;

	// Token: 0x04001482 RID: 5250
	[Token(Token = "0x4001482")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private float heightDelta;
}
