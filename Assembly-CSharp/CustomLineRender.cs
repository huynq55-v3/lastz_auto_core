using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200029D RID: 669
[Token(Token = "0x200029D")]
public class CustomLineRender : MonoBehaviour
{
	// Token: 0x06001199 RID: 4505 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001199")]
	[Address(RVA = "0x1C51988", Offset = "0x1C51988", VA = "0x1C51988")]
	public void AddLockValue(int triggerId, float x, float y, float z, bool clipRadius = false)
	{
	}

	// Token: 0x0600119A RID: 4506 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600119A")]
	[Address(RVA = "0x1C51B18", Offset = "0x1C51B18", VA = "0x1C51B18")]
	private void GetTwoPointOfLine(int srcIndex, int endIndex, out Vector3 srcPt, out Vector3 endPt)
	{
	}

	// Token: 0x0600119B RID: 4507 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600119B")]
	[Address(RVA = "0x1C51E14", Offset = "0x1C51E14", VA = "0x1C51E14")]
	public void PreCalculateData()
	{
	}

	// Token: 0x0600119C RID: 4508 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600119C")]
	[Address(RVA = "0x1C52080", Offset = "0x1C52080", VA = "0x1C52080")]
	public void Draw()
	{
	}

	// Token: 0x0600119D RID: 4509 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600119D")]
	[Address(RVA = "0x1C523D0", Offset = "0x1C523D0", VA = "0x1C523D0")]
	public void RemoveLineByLandId(int landId)
	{
	}

	// Token: 0x0600119E RID: 4510 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600119E")]
	[Address(RVA = "0x1C524A0", Offset = "0x1C524A0", VA = "0x1C524A0")]
	public void Clear()
	{
	}

	// Token: 0x0600119F RID: 4511 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600119F")]
	[Address(RVA = "0x1C526C8", Offset = "0x1C526C8", VA = "0x1C526C8")]
	public CustomLineRender()
	{
	}

	// Token: 0x04001448 RID: 5192
	[Token(Token = "0x4001448")]
	[FieldOffset(Offset = "0x18")]
	private List<LandLockValue> m_transPos;

	// Token: 0x04001449 RID: 5193
	[Token(Token = "0x4001449")]
	[FieldOffset(Offset = "0x20")]
	private List<LineData> m_lineData;

	// Token: 0x0400144A RID: 5194
	[Token(Token = "0x400144A")]
	[FieldOffset(Offset = "0x28")]
	public Material m_material;

	// Token: 0x0400144B RID: 5195
	[Token(Token = "0x400144B")]
	[FieldOffset(Offset = "0x30")]
	public Dictionary<int, GameObject> m_allLine;

	// Token: 0x0400144C RID: 5196
	[Token(Token = "0x400144C")]
	[FieldOffset(Offset = "0x38")]
	public float Radius;
}
