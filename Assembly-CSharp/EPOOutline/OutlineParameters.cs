using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

namespace EPOOutline
{
	// Token: 0x02000C99 RID: 3225
	[Token(Token = "0x2000C99")]
	public class OutlineParameters
	{
		// Token: 0x06007A60 RID: 31328 RVA: 0x00053BB0 File Offset: 0x00051DB0
		[Token(Token = "0x6007A60")]
		[Address(RVA = "0x32190CC", Offset = "0x32190CC", VA = "0x32190CC")]
		public Vector2Int MakeScaledVector(int x, int y)
		{
			return default(Vector2Int);
		}

		// Token: 0x06007A61 RID: 31329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A61")]
		[Address(RVA = "0x32191CC", Offset = "0x32191CC", VA = "0x32191CC")]
		public void CheckInitialization()
		{
		}

		// Token: 0x06007A62 RID: 31330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A62")]
		[Address(RVA = "0x3219248", Offset = "0x3219248", VA = "0x3219248")]
		public void Prepare()
		{
		}

		// Token: 0x06007A63 RID: 31331 RVA: 0x00053BC8 File Offset: 0x00051DC8
		[Token(Token = "0x6007A63")]
		[Address(RVA = "0x32194CC", Offset = "0x32194CC", VA = "0x32194CC")]
		private static bool CheckDiffers(Outlinable outlinable)
		{
			return default(bool);
		}

		// Token: 0x06007A64 RID: 31332 RVA: 0x00053BE0 File Offset: 0x00051DE0
		[Token(Token = "0x6007A64")]
		[Address(RVA = "0x321954C", Offset = "0x321954C", VA = "0x321954C")]
		private static bool CheckIfNonOne(Outlinable.OutlineProperties parameters)
		{
			return default(bool);
		}

		// Token: 0x06007A65 RID: 31333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A65")]
		[Address(RVA = "0x3219584", Offset = "0x3219584", VA = "0x3219584")]
		public OutlineParameters()
		{
		}

		// Token: 0x0400359E RID: 13726
		[Token(Token = "0x400359E")]
		[FieldOffset(Offset = "0x10")]
		public readonly MeshPool MeshPool;

		// Token: 0x0400359F RID: 13727
		[Token(Token = "0x400359F")]
		[FieldOffset(Offset = "0x18")]
		public Camera Camera;

		// Token: 0x040035A0 RID: 13728
		[Token(Token = "0x40035A0")]
		[FieldOffset(Offset = "0x20")]
		public RenderTargetIdentifier Target;

		// Token: 0x040035A1 RID: 13729
		[Token(Token = "0x40035A1")]
		[FieldOffset(Offset = "0x48")]
		public RenderTargetIdentifier DepthTarget;

		// Token: 0x040035A2 RID: 13730
		[Token(Token = "0x40035A2")]
		[FieldOffset(Offset = "0x70")]
		public CommandBuffer Buffer;

		// Token: 0x040035A3 RID: 13731
		[Token(Token = "0x40035A3")]
		[FieldOffset(Offset = "0x78")]
		public DilateQuality DilateQuality;

		// Token: 0x040035A4 RID: 13732
		[Token(Token = "0x40035A4")]
		[FieldOffset(Offset = "0x7C")]
		public int DilateIterations;

		// Token: 0x040035A5 RID: 13733
		[Token(Token = "0x40035A5")]
		[FieldOffset(Offset = "0x80")]
		public int BlurIterations;

		// Token: 0x040035A6 RID: 13734
		[Token(Token = "0x40035A6")]
		[FieldOffset(Offset = "0x84")]
		public Vector2 Scale;

		// Token: 0x040035A7 RID: 13735
		[Token(Token = "0x40035A7")]
		[FieldOffset(Offset = "0x8C")]
		public Rect? CustomViewport;

		// Token: 0x040035A8 RID: 13736
		[Token(Token = "0x40035A8")]
		[FieldOffset(Offset = "0xA0")]
		public long OutlineLayerMask;

		// Token: 0x040035A9 RID: 13737
		[Token(Token = "0x40035A9")]
		[FieldOffset(Offset = "0xA8")]
		public int TargetWidth;

		// Token: 0x040035AA RID: 13738
		[Token(Token = "0x40035AA")]
		[FieldOffset(Offset = "0xAC")]
		public int TargetHeight;

		// Token: 0x040035AB RID: 13739
		[Token(Token = "0x40035AB")]
		[FieldOffset(Offset = "0xB0")]
		public float BlurShift;

		// Token: 0x040035AC RID: 13740
		[Token(Token = "0x40035AC")]
		[FieldOffset(Offset = "0xB4")]
		public float DilateShift;

		// Token: 0x040035AD RID: 13741
		[Token(Token = "0x40035AD")]
		[FieldOffset(Offset = "0xB8")]
		public bool UseHDR;

		// Token: 0x040035AE RID: 13742
		[Token(Token = "0x40035AE")]
		[FieldOffset(Offset = "0xB9")]
		public bool UseInfoBuffer;

		// Token: 0x040035AF RID: 13743
		[Token(Token = "0x40035AF")]
		[FieldOffset(Offset = "0xBA")]
		public bool IsEditorCamera;

		// Token: 0x040035B0 RID: 13744
		[Token(Token = "0x40035B0")]
		[FieldOffset(Offset = "0xBC")]
		public BufferSizeMode PrimaryBufferSizeMode;

		// Token: 0x040035B1 RID: 13745
		[Token(Token = "0x40035B1")]
		[FieldOffset(Offset = "0xC0")]
		public int PrimaryBufferSizeReference;

		// Token: 0x040035B2 RID: 13746
		[Token(Token = "0x40035B2")]
		[FieldOffset(Offset = "0xC4")]
		public float PrimaryBufferScale;

		// Token: 0x040035B3 RID: 13747
		[Token(Token = "0x40035B3")]
		[FieldOffset(Offset = "0xC8")]
		public StereoTargetEyeMask EyeMask;

		// Token: 0x040035B4 RID: 13748
		[Token(Token = "0x40035B4")]
		[FieldOffset(Offset = "0xCC")]
		public int Antialiasing;

		// Token: 0x040035B5 RID: 13749
		[Token(Token = "0x40035B5")]
		[FieldOffset(Offset = "0xD0")]
		public BlurType BlurType;

		// Token: 0x040035B6 RID: 13750
		[Token(Token = "0x40035B6")]
		[FieldOffset(Offset = "0xD4")]
		public LayerMask Mask;

		// Token: 0x040035B7 RID: 13751
		[Token(Token = "0x40035B7")]
		[FieldOffset(Offset = "0xD8")]
		public Mesh BlitMesh;

		// Token: 0x040035B8 RID: 13752
		[Token(Token = "0x40035B8")]
		[FieldOffset(Offset = "0xE0")]
		public List<Outlinable> OutlinablesToRender;

		// Token: 0x040035B9 RID: 13753
		[Token(Token = "0x40035B9")]
		[FieldOffset(Offset = "0xE8")]
		private bool isInitialized;
	}
}
