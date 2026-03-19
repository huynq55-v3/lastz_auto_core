using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace FIMSpace.AnimationTools
{
	// Token: 0x02000C13 RID: 3091
	[Token(Token = "0x2000C13")]
	public static class SkeletonRecognize
	{
		// Token: 0x0600763B RID: 30267 RVA: 0x00052770 File Offset: 0x00050970
		[Token(Token = "0x600763B")]
		[Address(RVA = "0x2EBE738", Offset = "0x2EBE738", VA = "0x2EBE738")]
		public static bool IsChildOf(Transform child, Transform parent)
		{
			return default(bool);
		}

		// Token: 0x0600763C RID: 30268 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600763C")]
		[Address(RVA = "0x2EBE7F4", Offset = "0x2EBE7F4", VA = "0x2EBE7F4")]
		public static Transform GetBottomMostChildTransform(Transform parent)
		{
			return null;
		}

		// Token: 0x0600763D RID: 30269 RVA: 0x00052788 File Offset: 0x00050988
		[Token(Token = "0x600763D")]
		[Address(RVA = "0x2EBE9B8", Offset = "0x2EBE9B8", VA = "0x2EBE9B8")]
		public static bool NameContains(string name, string[] names)
		{
			return default(bool);
		}

		// Token: 0x04002FE1 RID: 12257
		[Token(Token = "0x4002FE1")]
		[FieldOffset(Offset = "0x0")]
		public static readonly string[] SpineNames;

		// Token: 0x04002FE2 RID: 12258
		[Token(Token = "0x4002FE2")]
		[FieldOffset(Offset = "0x8")]
		public static readonly string[] NeckNames;

		// Token: 0x04002FE3 RID: 12259
		[Token(Token = "0x4002FE3")]
		[FieldOffset(Offset = "0x10")]
		public static readonly string[] HeadNames;

		// Token: 0x04002FE4 RID: 12260
		[Token(Token = "0x4002FE4")]
		[FieldOffset(Offset = "0x18")]
		public static readonly string[] RootNames;

		// Token: 0x04002FE5 RID: 12261
		[Token(Token = "0x4002FE5")]
		[FieldOffset(Offset = "0x20")]
		public static readonly string[] PelvisNames;

		// Token: 0x04002FE6 RID: 12262
		[Token(Token = "0x4002FE6")]
		[FieldOffset(Offset = "0x28")]
		public static readonly string[] ChestNames;

		// Token: 0x04002FE7 RID: 12263
		[Token(Token = "0x4002FE7")]
		[FieldOffset(Offset = "0x30")]
		public static readonly string[] ShouldersNames;

		// Token: 0x04002FE8 RID: 12264
		[Token(Token = "0x4002FE8")]
		[FieldOffset(Offset = "0x38")]
		public static readonly string[] UpperLegNames;

		// Token: 0x04002FE9 RID: 12265
		[Token(Token = "0x4002FE9")]
		[FieldOffset(Offset = "0x40")]
		public static readonly string[] KneeNames;

		// Token: 0x04002FEA RID: 12266
		[Token(Token = "0x4002FEA")]
		[FieldOffset(Offset = "0x48")]
		public static readonly string[] ElbowNames;

		// Token: 0x02000C14 RID: 3092
		[Token(Token = "0x2000C14")]
		public enum EWhatIsIt
		{
			// Token: 0x04002FEC RID: 12268
			[Token(Token = "0x4002FEC")]
			Unknown,
			// Token: 0x04002FED RID: 12269
			[Token(Token = "0x4002FED")]
			Humanoidal,
			// Token: 0x04002FEE RID: 12270
			[Token(Token = "0x4002FEE")]
			Quadroped,
			// Token: 0x04002FEF RID: 12271
			[Token(Token = "0x4002FEF")]
			Creature
		}

		// Token: 0x02000C15 RID: 3093
		[Token(Token = "0x2000C15")]
		public class SkeletonInfo
		{
			// Token: 0x17000A59 RID: 2649
			// (get) Token: 0x0600763F RID: 30271 RVA: 0x000527A0 File Offset: 0x000509A0
			[Token(Token = "0x17000A59")]
			public int SpineChainLength
			{
				[Token(Token = "0x600763F")]
				[Address(RVA = "0x2EBF4A4", Offset = "0x2EBF4A4", VA = "0x2EBF4A4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17000A5A RID: 2650
			// (get) Token: 0x06007640 RID: 30272 RVA: 0x000527B8 File Offset: 0x000509B8
			[Token(Token = "0x17000A5A")]
			public int LeftArms
			{
				[Token(Token = "0x6007640")]
				[Address(RVA = "0x2EBF4EC", Offset = "0x2EBF4EC", VA = "0x2EBF4EC")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17000A5B RID: 2651
			// (get) Token: 0x06007641 RID: 30273 RVA: 0x000527D0 File Offset: 0x000509D0
			[Token(Token = "0x17000A5B")]
			public int LeftLegs
			{
				[Token(Token = "0x6007641")]
				[Address(RVA = "0x2EBF534", Offset = "0x2EBF534", VA = "0x2EBF534")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17000A5C RID: 2652
			// (get) Token: 0x06007642 RID: 30274 RVA: 0x000527E8 File Offset: 0x000509E8
			[Token(Token = "0x17000A5C")]
			public int RightArms
			{
				[Token(Token = "0x6007642")]
				[Address(RVA = "0x2EBF57C", Offset = "0x2EBF57C", VA = "0x2EBF57C")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17000A5D RID: 2653
			// (get) Token: 0x06007643 RID: 30275 RVA: 0x00052800 File Offset: 0x00050A00
			[Token(Token = "0x17000A5D")]
			public int RightLegs
			{
				[Token(Token = "0x6007643")]
				[Address(RVA = "0x2EBF5C4", Offset = "0x2EBF5C4", VA = "0x2EBF5C4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17000A5E RID: 2654
			// (get) Token: 0x06007644 RID: 30276 RVA: 0x00052818 File Offset: 0x00050A18
			[Token(Token = "0x17000A5E")]
			public int Legs
			{
				[Token(Token = "0x6007644")]
				[Address(RVA = "0x2EBF60C", Offset = "0x2EBF60C", VA = "0x2EBF60C")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17000A5F RID: 2655
			// (get) Token: 0x06007645 RID: 30277 RVA: 0x00052830 File Offset: 0x00050A30
			[Token(Token = "0x17000A5F")]
			public int Arms
			{
				[Token(Token = "0x6007645")]
				[Address(RVA = "0x2EBF638", Offset = "0x2EBF638", VA = "0x2EBF638")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06007646 RID: 30278 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007646")]
			[Address(RVA = "0x2EBF664", Offset = "0x2EBF664", VA = "0x2EBF664")]
			public SkeletonInfo(Transform t, [Optional] List<Transform> checkOnly, [Optional] Transform pelvisHelp)
			{
			}

			// Token: 0x06007647 RID: 30279 RVA: 0x00052848 File Offset: 0x00050A48
			[Token(Token = "0x6007647")]
			[Address(RVA = "0x2EC2594", Offset = "0x2EC2594", VA = "0x2EC2594")]
			private bool NotContainedYetByAny(Transform t)
			{
				return default(bool);
			}

			// Token: 0x06007648 RID: 30280 RVA: 0x00052860 File Offset: 0x00050A60
			[Token(Token = "0x6007648")]
			[Address(RVA = "0x2EC20B4", Offset = "0x2EC20B4", VA = "0x2EC20B4")]
			private bool NotContainedYetByLimbs(Transform t)
			{
				return default(bool);
			}

			// Token: 0x06007649 RID: 30281 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007649")]
			[Address(RVA = "0x2EC2168", Offset = "0x2EC2168", VA = "0x2EC2168")]
			public Transform GetHighestChild(Transform t, Transform root, float inCenterRangeFactor)
			{
				return null;
			}

			// Token: 0x0600764A RID: 30282 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600764A")]
			[Address(RVA = "0x2EC2414", Offset = "0x2EC2414", VA = "0x2EC2414")]
			private void ClearDuplicates(List<List<Transform>> limbs, List<Transform> roots)
			{
			}

			// Token: 0x0600764B RID: 30283 RVA: 0x00052878 File Offset: 0x00050A78
			[Token(Token = "0x600764B")]
			[Address(RVA = "0x2EC2138", Offset = "0x2EC2138", VA = "0x2EC2138")]
			private Vector3 Loc(Transform t)
			{
				return default(Vector3);
			}

			// Token: 0x0600764C RID: 30284 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600764C")]
			[Address(RVA = "0x2EC273C", Offset = "0x2EC273C", VA = "0x2EC273C")]
			public string GetLog()
			{
				return null;
			}

			// Token: 0x0600764D RID: 30285 RVA: 0x00052890 File Offset: 0x00050A90
			[Token(Token = "0x600764D")]
			[Address(RVA = "0x2EC22D0", Offset = "0x2EC22D0", VA = "0x2EC22D0")]
			public static int GetDepth(Transform t, Transform skelRootBone)
			{
				return 0;
			}

			// Token: 0x04002FF0 RID: 12272
			[Token(Token = "0x4002FF0")]
			[FieldOffset(Offset = "0x10")]
			public Transform AnimatorTransform;

			// Token: 0x04002FF1 RID: 12273
			[Token(Token = "0x4002FF1")]
			[FieldOffset(Offset = "0x18")]
			public float LowestVsHighestLen;

			// Token: 0x04002FF2 RID: 12274
			[Token(Token = "0x4002FF2")]
			[FieldOffset(Offset = "0x1C")]
			public float MostLeftVsMostRightLen;

			// Token: 0x04002FF3 RID: 12275
			[Token(Token = "0x4002FF3")]
			[FieldOffset(Offset = "0x20")]
			public float MostForwVsMostBackLen;

			// Token: 0x04002FF4 RID: 12276
			[Token(Token = "0x4002FF4")]
			[FieldOffset(Offset = "0x24")]
			public float AverageLen;

			// Token: 0x04002FF5 RID: 12277
			[Token(Token = "0x4002FF5")]
			[FieldOffset(Offset = "0x28")]
			public Transform ProbablyRootBone;

			// Token: 0x04002FF6 RID: 12278
			[Token(Token = "0x4002FF6")]
			[FieldOffset(Offset = "0x30")]
			public Transform ProbablyHips;

			// Token: 0x04002FF7 RID: 12279
			[Token(Token = "0x4002FF7")]
			[FieldOffset(Offset = "0x38")]
			public Transform ProbablyChest;

			// Token: 0x04002FF8 RID: 12280
			[Token(Token = "0x4002FF8")]
			[FieldOffset(Offset = "0x40")]
			public Transform ProbablyHead;

			// Token: 0x04002FF9 RID: 12281
			[Token(Token = "0x4002FF9")]
			[FieldOffset(Offset = "0x48")]
			public List<Transform> TrReachingGround;

			// Token: 0x04002FFA RID: 12282
			[Token(Token = "0x4002FFA")]
			[FieldOffset(Offset = "0x50")]
			public List<Transform> TrReachingSides;

			// Token: 0x04002FFB RID: 12283
			[Token(Token = "0x4002FFB")]
			[FieldOffset(Offset = "0x58")]
			public List<Transform> TrEnds;

			// Token: 0x04002FFC RID: 12284
			[Token(Token = "0x4002FFC")]
			[FieldOffset(Offset = "0x60")]
			public List<Transform> ProbablySpineChain;

			// Token: 0x04002FFD RID: 12285
			[Token(Token = "0x4002FFD")]
			[FieldOffset(Offset = "0x68")]
			public List<Transform> ProbablySpineChainShort;

			// Token: 0x04002FFE RID: 12286
			[Token(Token = "0x4002FFE")]
			[FieldOffset(Offset = "0x70")]
			public List<List<Transform>> ProbablyRightArms;

			// Token: 0x04002FFF RID: 12287
			[Token(Token = "0x4002FFF")]
			[FieldOffset(Offset = "0x78")]
			public List<List<Transform>> ProbablyLeftArms;

			// Token: 0x04003000 RID: 12288
			[Token(Token = "0x4003000")]
			[FieldOffset(Offset = "0x80")]
			public List<List<Transform>> ProbablyLeftLegs;

			// Token: 0x04003001 RID: 12289
			[Token(Token = "0x4003001")]
			[FieldOffset(Offset = "0x88")]
			public List<Transform> ProbablyLeftLegRoot;

			// Token: 0x04003002 RID: 12290
			[Token(Token = "0x4003002")]
			[FieldOffset(Offset = "0x90")]
			public List<List<Transform>> ProbablyRightLegs;

			// Token: 0x04003003 RID: 12291
			[Token(Token = "0x4003003")]
			[FieldOffset(Offset = "0x98")]
			public List<Transform> ProbablyRightLegRoot;

			// Token: 0x04003004 RID: 12292
			[Token(Token = "0x4003004")]
			[FieldOffset(Offset = "0xA0")]
			public Vector3 LocalSpaceHighest;

			// Token: 0x04003005 RID: 12293
			[Token(Token = "0x4003005")]
			[FieldOffset(Offset = "0xAC")]
			public Vector3 LocalSpaceMostRight;

			// Token: 0x04003006 RID: 12294
			[Token(Token = "0x4003006")]
			[FieldOffset(Offset = "0xB8")]
			public Vector3 LocalSpaceMostForward;

			// Token: 0x04003007 RID: 12295
			[Token(Token = "0x4003007")]
			[FieldOffset(Offset = "0xC4")]
			public Vector3 LocalSpaceMostBack;

			// Token: 0x04003008 RID: 12296
			[Token(Token = "0x4003008")]
			[FieldOffset(Offset = "0xD0")]
			public Vector3 LocalSpaceMostLeft;

			// Token: 0x04003009 RID: 12297
			[Token(Token = "0x4003009")]
			[FieldOffset(Offset = "0xDC")]
			public Vector3 LocalSpaceLowest;

			// Token: 0x0400300A RID: 12298
			[Token(Token = "0x400300A")]
			[FieldOffset(Offset = "0xE8")]
			public SkeletonRecognize.EWhatIsIt WhatIsIt;
		}
	}
}
