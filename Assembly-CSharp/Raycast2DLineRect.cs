using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200009C RID: 156
[Token(Token = "0x200009C")]
public static class Raycast2DLineRect
{
	// Token: 0x060003A8 RID: 936 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003A8")]
	[Address(RVA = "0x32168D4", Offset = "0x32168D4", VA = "0x32168D4")]
	public static void RaycastLineRect(Vector2 begin, Vector2 end, Rect rect, ref Raycast2DLineRect.LineRectResult res)
	{
	}

	// Token: 0x060003A9 RID: 937 RVA: 0x00003138 File Offset: 0x00001338
	[Token(Token = "0x60003A9")]
	[Address(RVA = "0x3216AD8", Offset = "0x3216AD8", VA = "0x3216AD8")]
	private static int GetRectPointSector(Rect rect, Vector2 point)
	{
		return 0;
	}

	// Token: 0x060003AA RID: 938 RVA: 0x00003150 File Offset: 0x00001350
	[Token(Token = "0x60003AA")]
	[Address(RVA = "0x3216BCC", Offset = "0x3216BCC", VA = "0x3216BCC")]
	private static float GetRayToRectSide(Vector2 begin, Vector2 dir, Raycast2DLineRect.Sector side, Rect rect, float r4val, out Raycast2DLineRect.Sector hitSide)
	{
		return 0f;
	}

	// Token: 0x060003AB RID: 939 RVA: 0x00003168 File Offset: 0x00001368
	[Token(Token = "0x60003AB")]
	[Address(RVA = "0x32170C0", Offset = "0x32170C0", VA = "0x32170C0")]
	private static float RayToHoriz(Vector2 fromPoint, Vector2 fromDir, float x, float y, float width)
	{
		return 0f;
	}

	// Token: 0x060003AC RID: 940 RVA: 0x00003180 File Offset: 0x00001380
	[Token(Token = "0x60003AC")]
	[Address(RVA = "0x3217114", Offset = "0x3217114", VA = "0x3217114")]
	private static float RayToVert(Vector2 fromPoint, Vector2 fromDir, float x, float y, float height)
	{
		return 0f;
	}

	// Token: 0x060003AD RID: 941 RVA: 0x00003198 File Offset: 0x00001398
	[Token(Token = "0x60003AD")]
	[Address(RVA = "0x3217168", Offset = "0x3217168", VA = "0x3217168")]
	private static float RayToRay(Vector2 fromPoint, Vector2 fromDir, Vector2 toPoint, Vector2 toDir)
	{
		return 0f;
	}

	// Token: 0x0400033D RID: 829
	[Token(Token = "0x400033D")]
	[FieldOffset(Offset = "0x0")]
	private static readonly Raycast2DLineRect.Sector[,,] RaycastLookup;

	// Token: 0x0200009D RID: 157
	[Token(Token = "0x200009D")]
	public struct LineRectResult
	{
		// Token: 0x1700008F RID: 143
		// (get) Token: 0x060003AF RID: 943 RVA: 0x000031B0 File Offset: 0x000013B0
		[Token(Token = "0x1700008F")]
		public bool HaveHit
		{
			[Token(Token = "0x60003AF")]
			[Address(RVA = "0x32172A8", Offset = "0x32172A8", VA = "0x32172A8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060003B0 RID: 944 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x32172C0", Offset = "0x32172C0", VA = "0x32172C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0400033E RID: 830
		[Token(Token = "0x400033E")]
		[FieldOffset(Offset = "0x0")]
		public float entry;

		// Token: 0x0400033F RID: 831
		[Token(Token = "0x400033F")]
		[FieldOffset(Offset = "0x4")]
		public Raycast2DLineRect.Sector entrySector;

		// Token: 0x04000340 RID: 832
		[Token(Token = "0x4000340")]
		[FieldOffset(Offset = "0x8")]
		public float exit;

		// Token: 0x04000341 RID: 833
		[Token(Token = "0x4000341")]
		[FieldOffset(Offset = "0xC")]
		public Raycast2DLineRect.Sector exitSector;
	}

	// Token: 0x0200009E RID: 158
	[Token(Token = "0x200009E")]
	public enum Sector
	{
		// Token: 0x04000343 RID: 835
		[Token(Token = "0x4000343")]
		__,
		// Token: 0x04000344 RID: 836
		[Token(Token = "0x4000344")]
		S0,
		// Token: 0x04000345 RID: 837
		[Token(Token = "0x4000345")]
		S1,
		// Token: 0x04000346 RID: 838
		[Token(Token = "0x4000346")]
		S2,
		// Token: 0x04000347 RID: 839
		[Token(Token = "0x4000347")]
		S3,
		// Token: 0x04000348 RID: 840
		[Token(Token = "0x4000348")]
		S4,
		// Token: 0x04000349 RID: 841
		[Token(Token = "0x4000349")]
		S5,
		// Token: 0x0400034A RID: 842
		[Token(Token = "0x400034A")]
		S6,
		// Token: 0x0400034B RID: 843
		[Token(Token = "0x400034B")]
		S7,
		// Token: 0x0400034C RID: 844
		[Token(Token = "0x400034C")]
		S8
	}
}
