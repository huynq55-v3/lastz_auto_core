using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200016C RID: 364
[Token(Token = "0x200016C")]
[Serializable]
public class MeshData
{
	// Token: 0x1700015E RID: 350
	// (get) Token: 0x06000A72 RID: 2674 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700015E")]
	public byte[] Data
	{
		[Token(Token = "0x6000A72")]
		[Address(RVA = "0x3714D9C", Offset = "0x3714D9C", VA = "0x3714D9C")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000A73 RID: 2675 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A73")]
	[Address(RVA = "0x3714DA4", Offset = "0x3714DA4", VA = "0x3714DA4")]
	public void SetMesh(Mesh aMesh)
	{
	}

	// Token: 0x06000A74 RID: 2676 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A74")]
	[Address(RVA = "0x3714FF4", Offset = "0x3714FF4", VA = "0x3714FF4")]
	public Mesh GetMesh()
	{
		return null;
	}

	// Token: 0x06000A75 RID: 2677 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A75")]
	[Address(RVA = "0x3715228", Offset = "0x3715228", VA = "0x3715228")]
	public MeshData()
	{
	}

	// Token: 0x04000788 RID: 1928
	[Token(Token = "0x4000788")]
	[FieldOffset(Offset = "0x10")]
	[HideInInspector]
	[SerializeField]
	private byte[] m_Data;

	// Token: 0x04000789 RID: 1929
	[Token(Token = "0x4000789")]
	[FieldOffset(Offset = "0x18")]
	private Mesh m_Mesh;
}
