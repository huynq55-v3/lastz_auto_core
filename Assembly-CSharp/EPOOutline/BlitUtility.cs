using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

namespace EPOOutline
{
	// Token: 0x02000C85 RID: 3205
	[Token(Token = "0x2000C85")]
	public static class BlitUtility
	{
		// Token: 0x17000AE0 RID: 2784
		// (get) Token: 0x060079E7 RID: 31207 RVA: 0x000537C0 File Offset: 0x000519C0
		[Token(Token = "0x17000AE0")]
		private static bool SupportsInstancing
		{
			[Token(Token = "0x60079E7")]
			[Address(RVA = "0x149245C", Offset = "0x149245C", VA = "0x149245C")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060079E8 RID: 31208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079E8")]
		[Address(RVA = "0x1492570", Offset = "0x1492570", VA = "0x1492570")]
		private static void UpdateBounds(Renderer renderer, OutlineTarget target)
		{
		}

		// Token: 0x060079E9 RID: 31209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079E9")]
		[Address(RVA = "0x149272C", Offset = "0x149272C", VA = "0x149272C")]
		public static void PrepareForRendering(OutlineParameters parameters)
		{
		}

		// Token: 0x060079EA RID: 31210 RVA: 0x000537D8 File Offset: 0x000519D8
		[Token(Token = "0x60079EA")]
		[Address(RVA = "0x1493C54", Offset = "0x1493C54", VA = "0x1493C54")]
		private static BlitUtility.MeshSetupResult? SetupForInstancing(OutlineParameters parameters)
		{
			return default(BlitUtility.MeshSetupResult?);
		}

		// Token: 0x060079EB RID: 31211 RVA: 0x000537F0 File Offset: 0x000519F0
		[Token(Token = "0x60079EB")]
		[Address(RVA = "0x14929EC", Offset = "0x14929EC", VA = "0x14929EC")]
		private static BlitUtility.MeshSetupResult? SetupForBruteForce(OutlineParameters parameters)
		{
			return default(BlitUtility.MeshSetupResult?);
		}

		// Token: 0x060079EC RID: 31212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079EC")]
		[Address(RVA = "0x1494B90", Offset = "0x1494B90", VA = "0x1494B90")]
		public static void Blit(OutlineParameters parameters, RenderTargetIdentifier source, RenderTargetIdentifier destination, RenderTargetIdentifier destinationDepth, Material material, CommandBuffer targetBuffer, int pass = -1, [Optional] Rect? viewport)
		{
		}

		// Token: 0x060079ED RID: 31213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079ED")]
		[Address(RVA = "0x1494DB4", Offset = "0x1494DB4", VA = "0x1494DB4")]
		public static void Draw(OutlineParameters parameters, RenderTargetIdentifier target, RenderTargetIdentifier depth, Material material, [Optional] Rect? viewport)
		{
		}

		// Token: 0x0400350D RID: 13581
		[Token(Token = "0x400350D")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int MainTexHash;

		// Token: 0x0400350E RID: 13582
		[Token(Token = "0x400350E")]
		[FieldOffset(Offset = "0x8")]
		private static Vector4[] normals;

		// Token: 0x0400350F RID: 13583
		[Token(Token = "0x400350F")]
		[FieldOffset(Offset = "0x10")]
		private static Vector4[] tempVertecies;

		// Token: 0x04003510 RID: 13584
		[Token(Token = "0x4003510")]
		[FieldOffset(Offset = "0x18")]
		private static VertexAttributeDescriptor[] vertexParams;

		// Token: 0x04003511 RID: 13585
		[Token(Token = "0x4003511")]
		[FieldOffset(Offset = "0x20")]
		private static ushort[] indecies;

		// Token: 0x04003512 RID: 13586
		[Token(Token = "0x4003512")]
		[FieldOffset(Offset = "0x28")]
		private static BlitUtility.Vertex[] vertices;

		// Token: 0x04003513 RID: 13587
		[Token(Token = "0x4003513")]
		[FieldOffset(Offset = "0x30")]
		private static Matrix4x4[] matrices;

		// Token: 0x04003514 RID: 13588
		[Token(Token = "0x4003514")]
		[FieldOffset(Offset = "0x38")]
		private static int itemsToDraw;

		// Token: 0x04003515 RID: 13589
		[Token(Token = "0x4003515")]
		[FieldOffset(Offset = "0x3C")]
		private static bool? supportsInstancing;

		// Token: 0x02000C86 RID: 3206
		[Token(Token = "0x2000C86")]
		public struct MeshSetupResult
		{
			// Token: 0x060079EF RID: 31215 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60079EF")]
			[Address(RVA = "0x1494B88", Offset = "0x1494B88", VA = "0x1494B88")]
			public MeshSetupResult(int vertexIndex, int triangleIndex)
			{
			}

			// Token: 0x04003516 RID: 13590
			[Token(Token = "0x4003516")]
			[FieldOffset(Offset = "0x0")]
			public readonly int VertexIndex;

			// Token: 0x04003517 RID: 13591
			[Token(Token = "0x4003517")]
			[FieldOffset(Offset = "0x4")]
			public readonly int TriangleIndex;
		}

		// Token: 0x02000C87 RID: 3207
		[Token(Token = "0x2000C87")]
		public struct Vertex
		{
			// Token: 0x04003518 RID: 13592
			[Token(Token = "0x4003518")]
			[FieldOffset(Offset = "0x0")]
			public Vector4 Position;

			// Token: 0x04003519 RID: 13593
			[Token(Token = "0x4003519")]
			[FieldOffset(Offset = "0x10")]
			public Vector3 Normal;
		}
	}
}
