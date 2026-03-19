using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace FIMSpace.FProceduralAnimation
{
	// Token: 0x02000C55 RID: 3157
	[Token(Token = "0x2000C55")]
	[AddComponentMenu("", 0)]
	public class RagdollCollisionHelper : RagdollIndicatorHelper
	{
		// Token: 0x17000ABA RID: 2746
		// (get) Token: 0x06007886 RID: 30854 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06007887 RID: 30855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000ABA")]
		public List<Collision> CollectedCollisions
		{
			[Token(Token = "0x6007886")]
			[Address(RVA = "0x1576F88", Offset = "0x1576F88", VA = "0x1576F88")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6007887")]
			[Address(RVA = "0x1576F90", Offset = "0x1576F90", VA = "0x1576F90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06007888 RID: 30856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007888")]
		[Address(RVA = "0x1576F98", Offset = "0x1576F98", VA = "0x1576F98")]
		public void EnableSavingEnteredCollisionsList()
		{
		}

		// Token: 0x06007889 RID: 30857 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007889")]
		[Address(RVA = "0x1577020", Offset = "0x1577020", VA = "0x1577020", Slot = "4")]
		public override RagdollIndicatorHelper Initialize(RagdollProcessor owner, RagdollProcessor.PosingBone c, bool isAnimatorBone = false)
		{
			return null;
		}

		// Token: 0x17000ABB RID: 2747
		// (get) Token: 0x0600788A RID: 30858 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600788B RID: 30859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000ABB")]
		public Collision LatestEnterCollision
		{
			[Token(Token = "0x600788A")]
			[Address(RVA = "0x157725C", Offset = "0x157725C", VA = "0x157725C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600788B")]
			[Address(RVA = "0x1577264", Offset = "0x1577264", VA = "0x1577264")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000ABC RID: 2748
		// (get) Token: 0x0600788C RID: 30860 RVA: 0x00053058 File Offset: 0x00051258
		// (set) Token: 0x0600788D RID: 30861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000ABC")]
		public ContactPoint LatestContact
		{
			[Token(Token = "0x600788C")]
			[Address(RVA = "0x157726C", Offset = "0x157726C", VA = "0x157726C")]
			[CompilerGenerated]
			get
			{
				return default(ContactPoint);
			}
			[Token(Token = "0x600788D")]
			[Address(RVA = "0x1577280", Offset = "0x1577280", VA = "0x1577280")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600788E RID: 30862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600788E")]
		[Address(RVA = "0x1577294", Offset = "0x1577294", VA = "0x1577294")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		// Token: 0x17000ABD RID: 2749
		// (get) Token: 0x0600788F RID: 30863 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06007890 RID: 30864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000ABD")]
		public Collision LatestExitCollision
		{
			[Token(Token = "0x600788F")]
			[Address(RVA = "0x1577520", Offset = "0x1577520", VA = "0x1577520")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6007890")]
			[Address(RVA = "0x1577528", Offset = "0x1577528", VA = "0x1577528")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06007891 RID: 30865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007891")]
		[Address(RVA = "0x1577530", Offset = "0x1577530", VA = "0x1577530")]
		private void OnCollisionExit(Collision collision)
		{
		}

		// Token: 0x06007892 RID: 30866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007892")]
		[Address(RVA = "0x1577700", Offset = "0x1577700", VA = "0x1577700")]
		public RagdollCollisionHelper()
		{
		}

		// Token: 0x04003277 RID: 12919
		[Token(Token = "0x4003277")]
		[FieldOffset(Offset = "0x50")]
		private bool CollectCollisions;

		// Token: 0x04003279 RID: 12921
		[Token(Token = "0x4003279")]
		[FieldOffset(Offset = "0x60")]
		public bool Colliding;

		// Token: 0x0400327A RID: 12922
		[Token(Token = "0x400327A")]
		[FieldOffset(Offset = "0x61")]
		public bool DebugLogs;

		// Token: 0x0400327B RID: 12923
		[Token(Token = "0x400327B")]
		[FieldOffset(Offset = "0x68")]
		[NonSerialized]
		public List<Transform> EnteredCollisions;

		// Token: 0x0400327C RID: 12924
		[Token(Token = "0x400327C")]
		[FieldOffset(Offset = "0x70")]
		[NonSerialized]
		public List<Transform> EnteredSelfCollisions;

		// Token: 0x0400327D RID: 12925
		[Token(Token = "0x400327D")]
		[FieldOffset(Offset = "0x78")]
		[NonSerialized]
		public List<Transform> ignores;

		// Token: 0x0400327E RID: 12926
		[Token(Token = "0x400327E")]
		[FieldOffset(Offset = "0x80")]
		internal bool CollidesJustWithSelf;
	}
}
