using System;
using Il2CppDummyDll;
using UnityEngine;

namespace usky
{
	// Token: 0x02000A0D RID: 2573
	[Token(Token = "0x2000A0D")]
	public class uSkyDomeData
	{
		// Token: 0x06006242 RID: 25154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006242")]
		[Address(RVA = "0x15D38EC", Offset = "0x15D38EC", VA = "0x15D38EC")]
		public uSkyDomeData()
		{
		}

		// Token: 0x04002668 RID: 9832
		[Token(Token = "0x4002668")]
		[FieldOffset(Offset = "0x10")]
		public Vector3[] vertices;

		// Token: 0x04002669 RID: 9833
		[Token(Token = "0x4002669")]
		[FieldOffset(Offset = "0x18")]
		public Vector2[] UV0;

		// Token: 0x0400266A RID: 9834
		[Token(Token = "0x400266A")]
		[FieldOffset(Offset = "0x20")]
		public Vector2[] UV2;

		// Token: 0x0400266B RID: 9835
		[Token(Token = "0x400266B")]
		[FieldOffset(Offset = "0x28")]
		public int[] triangles;

		// Token: 0x0400266C RID: 9836
		[Token(Token = "0x400266C")]
		[FieldOffset(Offset = "0x30")]
		public Vector3[] normals;

		// Token: 0x0400266D RID: 9837
		[Token(Token = "0x400266D")]
		[FieldOffset(Offset = "0x38")]
		public Vector4[] tangents;
	}
}
