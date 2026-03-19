using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000133 RID: 307
[Token(Token = "0x2000133")]
[CreateAssetMenu(fileName = "UIButtonCurve", menuName = "ScriptableObjects/UIButtonCurve", order = 0)]
public class UIButtonCurve : ScriptableObject
{
	// Token: 0x060008E7 RID: 2279 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008E7")]
	[Address(RVA = "0x33AC2A0", Offset = "0x33AC2A0", VA = "0x33AC2A0")]
	public UIButtonCurve()
	{
	}

	// Token: 0x040006AC RID: 1708
	[Token(Token = "0x40006AC")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public AnimationCurve m_PressedCurve;

	// Token: 0x040006AD RID: 1709
	[Token(Token = "0x40006AD")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	public float m_DoPressedTime;

	// Token: 0x040006AE RID: 1710
	[Token(Token = "0x40006AE")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	public Vector3 m_PressedScale;

	// Token: 0x040006AF RID: 1711
	[Token(Token = "0x40006AF")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	public AnimationCurve m_OtherCurve;

	// Token: 0x040006B0 RID: 1712
	[Token(Token = "0x40006B0")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	public float m_DoOtherTime;
}
