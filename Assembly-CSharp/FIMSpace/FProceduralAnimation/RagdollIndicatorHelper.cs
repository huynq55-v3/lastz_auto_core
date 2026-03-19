using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace FIMSpace.FProceduralAnimation
{
	// Token: 0x02000C58 RID: 3160
	[Token(Token = "0x2000C58")]
	[AddComponentMenu("", 0)]
	public class RagdollIndicatorHelper : MonoBehaviour
	{
		// Token: 0x17000AC0 RID: 2752
		// (get) Token: 0x0600789E RID: 30878 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600789F RID: 30879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AC0")]
		public RagdollProcessor Parent
		{
			[Token(Token = "0x600789E")]
			[Address(RVA = "0x1577C94", Offset = "0x1577C94", VA = "0x1577C94")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600789F")]
			[Address(RVA = "0x1577C9C", Offset = "0x1577C9C", VA = "0x1577C9C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000AC1 RID: 2753
		// (get) Token: 0x060078A0 RID: 30880 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AC1")]
		public RagdollProcessor ParentRagdollProcessor
		{
			[Token(Token = "0x60078A0")]
			[Address(RVA = "0x1577CA4", Offset = "0x1577CA4", VA = "0x1577CA4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000AC2 RID: 2754
		// (get) Token: 0x060078A1 RID: 30881 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AC2")]
		public RagdollAnimator ParentRagdollAnimator
		{
			[Token(Token = "0x60078A1")]
			[Address(RVA = "0x1577CAC", Offset = "0x1577CAC", VA = "0x1577CAC")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000AC3 RID: 2755
		// (get) Token: 0x060078A2 RID: 30882 RVA: 0x00053088 File Offset: 0x00051288
		// (set) Token: 0x060078A3 RID: 30883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AC3")]
		public bool IsAnimatorBone
		{
			[Token(Token = "0x60078A2")]
			[Address(RVA = "0x1577CC8", Offset = "0x1577CC8", VA = "0x1577CC8")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60078A3")]
			[Address(RVA = "0x1577CD0", Offset = "0x1577CD0", VA = "0x1577CD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000AC4 RID: 2756
		// (get) Token: 0x060078A4 RID: 30884 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060078A5 RID: 30885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AC4")]
		public RagdollProcessor.PosingBone RagdollBone
		{
			[Token(Token = "0x60078A4")]
			[Address(RVA = "0x1577CDC", Offset = "0x1577CDC", VA = "0x1577CDC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60078A5")]
			[Address(RVA = "0x1577CE4", Offset = "0x1577CE4", VA = "0x1577CE4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000AC5 RID: 2757
		// (get) Token: 0x060078A6 RID: 30886 RVA: 0x000530A0 File Offset: 0x000512A0
		// (set) Token: 0x060078A7 RID: 30887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AC5")]
		public HumanBodyBones LimbID
		{
			[Token(Token = "0x60078A6")]
			[Address(RVA = "0x1577CEC", Offset = "0x1577CEC", VA = "0x1577CEC")]
			[CompilerGenerated]
			get
			{
				return default(HumanBodyBones);
			}
			[Token(Token = "0x60078A7")]
			[Address(RVA = "0x1577CF4", Offset = "0x1577CF4", VA = "0x1577CF4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000AC6 RID: 2758
		// (get) Token: 0x060078A8 RID: 30888 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060078A9 RID: 30889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AC6")]
		public string CustomBoneChainName
		{
			[Token(Token = "0x60078A8")]
			[Address(RVA = "0x1577CFC", Offset = "0x1577CFC", VA = "0x1577CFC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60078A9")]
			[Address(RVA = "0x1577D04", Offset = "0x1577D04", VA = "0x1577D04")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000AC7 RID: 2759
		// (get) Token: 0x060078AA RID: 30890 RVA: 0x000530B8 File Offset: 0x000512B8
		// (set) Token: 0x060078AB RID: 30891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AC7")]
		public int CustomChainBoneIndex
		{
			[Token(Token = "0x60078AA")]
			[Address(RVA = "0x1577D0C", Offset = "0x1577D0C", VA = "0x1577D0C")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60078AB")]
			[Address(RVA = "0x1577D14", Offset = "0x1577D14", VA = "0x1577D14")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000AC8 RID: 2760
		// (get) Token: 0x060078AC RID: 30892 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060078AD RID: 30893 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AC8")]
		public RagdollProcessor.BonesChain CustomBoneChain
		{
			[Token(Token = "0x60078AC")]
			[Address(RVA = "0x1577D1C", Offset = "0x1577D1C", VA = "0x1577D1C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60078AD")]
			[Address(RVA = "0x1577D24", Offset = "0x1577D24", VA = "0x1577D24")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060078AE RID: 30894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60078AE")]
		[Address(RVA = "0x1577D2C", Offset = "0x1577D2C", VA = "0x1577D2C")]
		public void CustomBoneChainApplyInfo(RagdollProcessor.BonesChain chain, int boneIndex)
		{
		}

		// Token: 0x060078AF RID: 30895 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60078AF")]
		[Address(RVA = "0x1577078", Offset = "0x1577078", VA = "0x1577078", Slot = "4")]
		public virtual RagdollIndicatorHelper Initialize(RagdollProcessor owner, RagdollProcessor.PosingBone c, bool isAnimatorBone = false)
		{
			return null;
		}

		// Token: 0x060078B0 RID: 30896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60078B0")]
		[Address(RVA = "0x15777B8", Offset = "0x15777B8", VA = "0x15777B8")]
		public RagdollIndicatorHelper()
		{
		}
	}
}
