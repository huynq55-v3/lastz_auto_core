using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000B5 RID: 181
[Token(Token = "0x20000B5")]
public class ViewChange : MonoBehaviour
{
	// Token: 0x06000429 RID: 1065 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000429")]
	[Address(RVA = "0x2F6AF44", Offset = "0x2F6AF44", VA = "0x2F6AF44")]
	public void ChangeToPers()
	{
	}

	// Token: 0x0600042A RID: 1066 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600042A")]
	[Address(RVA = "0x2F6AF78", Offset = "0x2F6AF78", VA = "0x2F6AF78")]
	public void ChangeToOrth()
	{
	}

	// Token: 0x0600042B RID: 1067 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600042B")]
	[Address(RVA = "0x2F6AFAC", Offset = "0x2F6AFAC", VA = "0x2F6AFAC")]
	private void Update()
	{
	}

	// Token: 0x0600042C RID: 1068 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600042C")]
	[Address(RVA = "0x2F6AFD4", Offset = "0x2F6AFD4", VA = "0x2F6AFD4")]
	private void LateUpdate()
	{
	}

	// Token: 0x0600042D RID: 1069 RVA: 0x00003438 File Offset: 0x00001638
	[Token(Token = "0x600042D")]
	[Address(RVA = "0x2F6B2B0", Offset = "0x2F6B2B0", VA = "0x2F6B2B0")]
	private Matrix4x4 MatrixLerp(Matrix4x4 from, Matrix4x4 to, float t)
	{
		return default(Matrix4x4);
	}

	// Token: 0x0600042E RID: 1070 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600042E")]
	[Address(RVA = "0x2F6B4E4", Offset = "0x2F6B4E4", VA = "0x2F6B4E4")]
	private void OnGUI()
	{
	}

	// Token: 0x0600042F RID: 1071 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600042F")]
	[Address(RVA = "0x2F6B4E8", Offset = "0x2F6B4E8", VA = "0x2F6B4E8")]
	public ViewChange()
	{
	}

	// Token: 0x040003DF RID: 991
	[Token(Token = "0x40003DF")]
	[FieldOffset(Offset = "0x18")]
	public bool ChangeProjection;

	// Token: 0x040003E0 RID: 992
	[Token(Token = "0x40003E0")]
	[FieldOffset(Offset = "0x19")]
	private bool _changing;

	// Token: 0x040003E1 RID: 993
	[Token(Token = "0x40003E1")]
	[FieldOffset(Offset = "0x1C")]
	private float ProjectionChangeTime;

	// Token: 0x040003E2 RID: 994
	[Token(Token = "0x40003E2")]
	[FieldOffset(Offset = "0x20")]
	private float _currentT;

	// Token: 0x040003E3 RID: 995
	[Token(Token = "0x40003E3")]
	[FieldOffset(Offset = "0x28")]
	public Action onComplete;

	// Token: 0x040003E4 RID: 996
	[Token(Token = "0x40003E4")]
	[FieldOffset(Offset = "0x30")]
	private Matrix4x4 orthoMat;

	// Token: 0x040003E5 RID: 997
	[Token(Token = "0x40003E5")]
	[FieldOffset(Offset = "0x70")]
	private Matrix4x4 persMat;

	// Token: 0x040003E6 RID: 998
	[Token(Token = "0x40003E6")]
	[FieldOffset(Offset = "0xB0")]
	private bool isBegin;
}
