using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace usky
{
	// Token: 0x02000A2B RID: 2603
	[Token(Token = "0x2000A2B")]
	public class uStars
	{
		// Token: 0x060062E7 RID: 25319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062E7")]
		[Address(RVA = "0x303A138", Offset = "0x303A138", VA = "0x303A138")]
		public void InitializeStarfield(ref Mesh mesh)
		{
		}

		// Token: 0x060062E8 RID: 25320 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60062E8")]
		[Address(RVA = "0x303ABB8", Offset = "0x303ABB8", VA = "0x303ABB8")]
		private Mesh createQuad(float size)
		{
			return null;
		}

		// Token: 0x060062E9 RID: 25321 RVA: 0x0004BC30 File Offset: 0x00049E30
		[Token(Token = "0x60062E9")]
		[Address(RVA = "0x303AD9C", Offset = "0x303AD9C", VA = "0x303AD9C")]
		private Matrix4x4 BillboardMatrix(Vector3 particlePosition)
		{
			return default(Matrix4x4);
		}

		// Token: 0x060062EA RID: 25322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062EA")]
		[Address(RVA = "0x303B08C", Offset = "0x303B08C", VA = "0x303B08C")]
		public uStars()
		{
		}

		// Token: 0x04002772 RID: 10098
		[Token(Token = "0x4002772")]
		[FieldOffset(Offset = "0x10")]
		private float starSizeScale;

		// Token: 0x04002773 RID: 10099
		[Token(Token = "0x4002773")]
		[FieldOffset(Offset = "0x18")]
		private List<CombineInstance> starQuad;

		// Token: 0x02000A2C RID: 2604
		[Token(Token = "0x2000A2C")]
		private struct Star
		{
			// Token: 0x04002774 RID: 10100
			[Token(Token = "0x4002774")]
			[FieldOffset(Offset = "0x0")]
			public Vector3 position;

			// Token: 0x04002775 RID: 10101
			[Token(Token = "0x4002775")]
			[FieldOffset(Offset = "0xC")]
			public Vector4 color;
		}
	}
}
