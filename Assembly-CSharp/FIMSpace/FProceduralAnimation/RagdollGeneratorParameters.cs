using System;
using Il2CppDummyDll;
using UnityEngine;

namespace FIMSpace.FProceduralAnimation
{
	// Token: 0x02000C47 RID: 3143
	[Token(Token = "0x2000C47")]
	[Serializable]
	public class RagdollGeneratorParameters
	{
		// Token: 0x060077FA RID: 30714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60077FA")]
		[Address(RVA = "0x2F957A4", Offset = "0x2F957A4", VA = "0x2F957A4")]
		public RagdollGeneratorParameters()
		{
		}

		// Token: 0x04003225 RID: 12837
		[Token(Token = "0x4003225")]
		[FieldOffset(Offset = "0x10")]
		public float TargetMassOfWholeModel;

		// Token: 0x04003226 RID: 12838
		[Token(Token = "0x4003226")]
		[FieldOffset(Offset = "0x14")]
		[Range(0.05f, 2f)]
		public float ScaleRagdoll;

		// Token: 0x04003227 RID: 12839
		[Token(Token = "0x4003227")]
		[FieldOffset(Offset = "0x18")]
		[Range(0f, 1f)]
		public float DragForAllRigidbodies;

		// Token: 0x04003228 RID: 12840
		[Token(Token = "0x4003228")]
		[FieldOffset(Offset = "0x1C")]
		[Range(0f, 3f)]
		public float AngularDragForRigidbodies;

		// Token: 0x04003229 RID: 12841
		[Token(Token = "0x4003229")]
		[FieldOffset(Offset = "0x20")]
		public RigidbodyInterpolation RigidbodiesInterpolation;

		// Token: 0x0400322A RID: 12842
		[Token(Token = "0x400322A")]
		[FieldOffset(Offset = "0x24")]
		public CollisionDetectionMode DetectionMode;

		// Token: 0x0400322B RID: 12843
		[Token(Token = "0x400322B")]
		[FieldOffset(Offset = "0x28")]
		public bool generateFists;

		// Token: 0x0400322C RID: 12844
		[Token(Token = "0x400322C")]
		[FieldOffset(Offset = "0x29")]
		public bool generateFoots;

		// Token: 0x0400322D RID: 12845
		[Token(Token = "0x400322D")]
		[FieldOffset(Offset = "0x2A")]
		public bool generateShoulders;

		// Token: 0x0400322E RID: 12846
		[Token(Token = "0x400322E")]
		[FieldOffset(Offset = "0x2B")]
		public bool AlignWithScale;
	}
}
