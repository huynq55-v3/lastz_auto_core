using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Coffee.UIParticleExtensions
{
	// Token: 0x02000A38 RID: 2616
	[Token(Token = "0x2000A38")]
	internal class CombineInstanceEx
	{
		// Token: 0x0600633F RID: 25407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600633F")]
		[Address(RVA = "0x30405A8", Offset = "0x30405A8", VA = "0x30405A8")]
		public void Combine()
		{
		}

		// Token: 0x06006340 RID: 25408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006340")]
		[Address(RVA = "0x3040C38", Offset = "0x3040C38", VA = "0x3040C38")]
		public void Clear()
		{
		}

		// Token: 0x06006341 RID: 25409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006341")]
		[Address(RVA = "0x3040F1C", Offset = "0x3040F1C", VA = "0x3040F1C")]
		public void Push(Mesh mesh, Matrix4x4 transform)
		{
		}

		// Token: 0x06006342 RID: 25410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006342")]
		[Address(RVA = "0x3041078", Offset = "0x3041078", VA = "0x3041078")]
		public CombineInstanceEx()
		{
		}

		// Token: 0x040027F2 RID: 10226
		[Token(Token = "0x40027F2")]
		[FieldOffset(Offset = "0x10")]
		private int count;

		// Token: 0x040027F3 RID: 10227
		[Token(Token = "0x40027F3")]
		[FieldOffset(Offset = "0x18")]
		public long hash;

		// Token: 0x040027F4 RID: 10228
		[Token(Token = "0x40027F4")]
		[FieldOffset(Offset = "0x20")]
		public int index;

		// Token: 0x040027F5 RID: 10229
		[Token(Token = "0x40027F5")]
		[FieldOffset(Offset = "0x28")]
		private readonly List<CombineInstance> combineInstances;

		// Token: 0x040027F6 RID: 10230
		[Token(Token = "0x40027F6")]
		[FieldOffset(Offset = "0x30")]
		public Mesh mesh;

		// Token: 0x040027F7 RID: 10231
		[Token(Token = "0x40027F7")]
		[FieldOffset(Offset = "0x38")]
		public Matrix4x4 transform;
	}
}
