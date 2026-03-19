using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace EPOOutline
{
	// Token: 0x02000C98 RID: 3224
	[Token(Token = "0x2000C98")]
	public class MeshPool
	{
		// Token: 0x06007A5D RID: 31325 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007A5D")]
		[Address(RVA = "0x3218C70", Offset = "0x3218C70", VA = "0x3218C70")]
		public Mesh AllocateMesh()
		{
			return null;
		}

		// Token: 0x06007A5E RID: 31326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A5E")]
		[Address(RVA = "0x3218E64", Offset = "0x3218E64", VA = "0x3218E64")]
		public void ReleaseAllMeshes()
		{
		}

		// Token: 0x06007A5F RID: 31327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A5F")]
		[Address(RVA = "0x3218FF4", Offset = "0x3218FF4", VA = "0x3218FF4")]
		public MeshPool()
		{
		}

		// Token: 0x0400359C RID: 13724
		[Token(Token = "0x400359C")]
		[FieldOffset(Offset = "0x10")]
		private Queue<Mesh> freeMeshes;

		// Token: 0x0400359D RID: 13725
		[Token(Token = "0x400359D")]
		[FieldOffset(Offset = "0x18")]
		private List<Mesh> allMeshes;
	}
}
