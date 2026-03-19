using System;
using System.IO;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200016D RID: 365
[Token(Token = "0x200016D")]
public static class MeshSerializer
{
	// Token: 0x06000A76 RID: 2678 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A76")]
	[Address(RVA = "0x3714E48", Offset = "0x3714E48", VA = "0x3714E48")]
	public static byte[] SerializeMesh(Mesh aMesh)
	{
		return null;
	}

	// Token: 0x06000A77 RID: 2679 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A77")]
	[Address(RVA = "0x3715230", Offset = "0x3715230", VA = "0x3715230")]
	public static void SerializeMesh(MemoryStream aStream, Mesh aMesh)
	{
	}

	// Token: 0x06000A78 RID: 2680 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A78")]
	[Address(RVA = "0x37153C0", Offset = "0x37153C0", VA = "0x37153C0")]
	public static void SerializeMesh(BinaryWriter aWriter, Mesh aMesh)
	{
	}

	// Token: 0x06000A79 RID: 2681 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A79")]
	[Address(RVA = "0x371508C", Offset = "0x371508C", VA = "0x371508C")]
	public static Mesh DeserializeMesh(byte[] aData, [Optional] Mesh aTarget)
	{
		return null;
	}

	// Token: 0x06000A7A RID: 2682 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A7A")]
	[Address(RVA = "0x37165C0", Offset = "0x37165C0", VA = "0x37165C0")]
	public static Mesh DeserializeMesh(MemoryStream aStream, [Optional] Mesh aTarget)
	{
		return null;
	}

	// Token: 0x06000A7B RID: 2683 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A7B")]
	[Address(RVA = "0x371675C", Offset = "0x371675C", VA = "0x371675C")]
	public static Mesh DeserializeMesh(BinaryReader aReader, [Optional] Mesh aTarget)
	{
		return null;
	}

	// Token: 0x0400078A RID: 1930
	[Token(Token = "0x400078A")]
	private const uint m_Magic = 1752393037U;

	// Token: 0x0200016E RID: 366
	[Token(Token = "0x200016E")]
	private enum EChunkID : byte
	{
		// Token: 0x0400078C RID: 1932
		[Token(Token = "0x400078C")]
		End,
		// Token: 0x0400078D RID: 1933
		[Token(Token = "0x400078D")]
		Name,
		// Token: 0x0400078E RID: 1934
		[Token(Token = "0x400078E")]
		Normals,
		// Token: 0x0400078F RID: 1935
		[Token(Token = "0x400078F")]
		Tangents,
		// Token: 0x04000790 RID: 1936
		[Token(Token = "0x4000790")]
		Colors,
		// Token: 0x04000791 RID: 1937
		[Token(Token = "0x4000791")]
		BoneWeights,
		// Token: 0x04000792 RID: 1938
		[Token(Token = "0x4000792")]
		UV0,
		// Token: 0x04000793 RID: 1939
		[Token(Token = "0x4000793")]
		UV1,
		// Token: 0x04000794 RID: 1940
		[Token(Token = "0x4000794")]
		UV2,
		// Token: 0x04000795 RID: 1941
		[Token(Token = "0x4000795")]
		UV3,
		// Token: 0x04000796 RID: 1942
		[Token(Token = "0x4000796")]
		Submesh,
		// Token: 0x04000797 RID: 1943
		[Token(Token = "0x4000797")]
		Bindposes,
		// Token: 0x04000798 RID: 1944
		[Token(Token = "0x4000798")]
		BlendShape
	}
}
