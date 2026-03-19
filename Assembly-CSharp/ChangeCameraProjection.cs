using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000085 RID: 133
[Token(Token = "0x2000085")]
public class ChangeCameraProjection : MonoBehaviour
{
	// Token: 0x06000328 RID: 808 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000328")]
	[Address(RVA = "0x32111D8", Offset = "0x32111D8", VA = "0x32111D8")]
	private void Awake()
	{
	}

	// Token: 0x06000329 RID: 809 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000329")]
	[Address(RVA = "0x3211230", Offset = "0x3211230", VA = "0x3211230")]
	public void ChangeToPers()
	{
	}

	// Token: 0x0600032A RID: 810 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600032A")]
	[Address(RVA = "0x32112F8", Offset = "0x32112F8", VA = "0x32112F8")]
	public void ChangeToOrth()
	{
	}

	// Token: 0x0600032B RID: 811 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600032B")]
	[Address(RVA = "0x321139C", Offset = "0x321139C", VA = "0x321139C")]
	private void LateUpdate()
	{
	}

	// Token: 0x0600032C RID: 812 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600032C")]
	[Address(RVA = "0x32113EC", Offset = "0x32113EC", VA = "0x32113EC")]
	public ChangeCameraProjection()
	{
	}

	// Token: 0x040002B2 RID: 690
	[Token(Token = "0x40002B2")]
	[FieldOffset(Offset = "0x0")]
	private static readonly float MAXChangeTime;

	// Token: 0x040002B3 RID: 691
	[Token(Token = "0x40002B3")]
	[FieldOffset(Offset = "0x18")]
	private float m_changeTime;

	// Token: 0x040002B4 RID: 692
	[Token(Token = "0x40002B4")]
	[FieldOffset(Offset = "0x1C")]
	private bool m_isUpdateToPers;

	// Token: 0x040002B5 RID: 693
	[Token(Token = "0x40002B5")]
	[FieldOffset(Offset = "0x1D")]
	private bool m_isUpdateToOrth;

	// Token: 0x040002B6 RID: 694
	[Token(Token = "0x40002B6")]
	[FieldOffset(Offset = "0x20")]
	private Matrix4x4 m_curMatrix;

	// Token: 0x040002B7 RID: 695
	[Token(Token = "0x40002B7")]
	[FieldOffset(Offset = "0x60")]
	private bool m_isInitOrthMatrix;

	// Token: 0x040002B8 RID: 696
	[Token(Token = "0x40002B8")]
	[FieldOffset(Offset = "0x64")]
	private Matrix4x4 m_orthMatrix;

	// Token: 0x040002B9 RID: 697
	[Token(Token = "0x40002B9")]
	[FieldOffset(Offset = "0xA4")]
	private bool m_isInitPersMatrix;

	// Token: 0x040002BA RID: 698
	[Token(Token = "0x40002BA")]
	[FieldOffset(Offset = "0xA8")]
	private Matrix4x4 m_persMatrix;

	// Token: 0x040002BB RID: 699
	[Token(Token = "0x40002BB")]
	[FieldOffset(Offset = "0xE8")]
	private Camera m_camera;
}
