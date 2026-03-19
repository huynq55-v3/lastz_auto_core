using System;
using Il2CppDummyDll;
using UnityEngine.UI;

// Token: 0x0200034A RID: 842
[Token(Token = "0x200034A")]
public class TextSpacing : BaseMeshEffect
{
	// Token: 0x060015DD RID: 5597 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015DD")]
	[Address(RVA = "0x1ED8B3C", Offset = "0x1ED8B3C", VA = "0x1ED8B3C", Slot = "20")]
	public override void ModifyMesh(VertexHelper vh)
	{
	}

	// Token: 0x060015DE RID: 5598 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015DE")]
	[Address(RVA = "0x1ED92D0", Offset = "0x1ED92D0", VA = "0x1ED92D0")]
	public TextSpacing()
	{
	}

	// Token: 0x040018FE RID: 6398
	[Token(Token = "0x40018FE")]
	[FieldOffset(Offset = "0x20")]
	public float Spacing;

	// Token: 0x0200034B RID: 843
	[Token(Token = "0x200034B")]
	public enum HorizontalAligmentType
	{
		// Token: 0x04001900 RID: 6400
		[Token(Token = "0x4001900")]
		Left,
		// Token: 0x04001901 RID: 6401
		[Token(Token = "0x4001901")]
		Center,
		// Token: 0x04001902 RID: 6402
		[Token(Token = "0x4001902")]
		Right
	}

	// Token: 0x0200034C RID: 844
	[Token(Token = "0x200034C")]
	public class Line
	{
		// Token: 0x1700024A RID: 586
		// (get) Token: 0x060015DF RID: 5599 RVA: 0x000086D0 File Offset: 0x000068D0
		[Token(Token = "0x1700024A")]
		public int StartVertexIndex
		{
			[Token(Token = "0x60015DF")]
			[Address(RVA = "0x1ED92E0", Offset = "0x1ED92E0", VA = "0x1ED92E0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700024B RID: 587
		// (get) Token: 0x060015E0 RID: 5600 RVA: 0x000086E8 File Offset: 0x000068E8
		[Token(Token = "0x1700024B")]
		public int EndVertexIndex
		{
			[Token(Token = "0x60015E0")]
			[Address(RVA = "0x1ED92E8", Offset = "0x1ED92E8", VA = "0x1ED92E8")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700024C RID: 588
		// (get) Token: 0x060015E1 RID: 5601 RVA: 0x00008700 File Offset: 0x00006900
		[Token(Token = "0x1700024C")]
		public int VertexCount
		{
			[Token(Token = "0x60015E1")]
			[Address(RVA = "0x1ED92F0", Offset = "0x1ED92F0", VA = "0x1ED92F0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060015E2 RID: 5602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015E2")]
		[Address(RVA = "0x1ED9290", Offset = "0x1ED9290", VA = "0x1ED9290")]
		public Line(int startVertexIndex, int length)
		{
		}

		// Token: 0x04001903 RID: 6403
		[Token(Token = "0x4001903")]
		[FieldOffset(Offset = "0x10")]
		private int _startVertexIndex;

		// Token: 0x04001904 RID: 6404
		[Token(Token = "0x4001904")]
		[FieldOffset(Offset = "0x14")]
		private int _endVertexIndex;

		// Token: 0x04001905 RID: 6405
		[Token(Token = "0x4001905")]
		[FieldOffset(Offset = "0x18")]
		private int _vertexCount;
	}
}
