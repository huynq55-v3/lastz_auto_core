using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace FIMSpace.Basics
{
	// Token: 0x02000C19 RID: 3097
	[Token(Token = "0x2000C19")]
	public class FAnimator
	{
		// Token: 0x17000A62 RID: 2658
		// (get) Token: 0x06007663 RID: 30307 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06007664 RID: 30308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A62")]
		public string CurrentAnimation
		{
			[Token(Token = "0x6007663")]
			[Address(RVA = "0x2EC42A8", Offset = "0x2EC42A8", VA = "0x2EC42A8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6007664")]
			[Address(RVA = "0x2EC42B0", Offset = "0x2EC42B0", VA = "0x2EC42B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000A63 RID: 2659
		// (get) Token: 0x06007665 RID: 30309 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06007666 RID: 30310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A63")]
		public string PreviousAnimation
		{
			[Token(Token = "0x6007665")]
			[Address(RVA = "0x2EC42B8", Offset = "0x2EC42B8", VA = "0x2EC42B8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6007666")]
			[Address(RVA = "0x2EC42C0", Offset = "0x2EC42C0", VA = "0x2EC42C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000A64 RID: 2660
		// (get) Token: 0x06007667 RID: 30311 RVA: 0x000528C0 File Offset: 0x00050AC0
		// (set) Token: 0x06007668 RID: 30312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A64")]
		public int Layer
		{
			[Token(Token = "0x6007667")]
			[Address(RVA = "0x2EC42C8", Offset = "0x2EC42C8", VA = "0x2EC42C8")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6007668")]
			[Address(RVA = "0x2EC42D0", Offset = "0x2EC42D0", VA = "0x2EC42D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06007669 RID: 30313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007669")]
		[Address(RVA = "0x2EC42D8", Offset = "0x2EC42D8", VA = "0x2EC42D8")]
		public FAnimator(Animator animator, int layer = 0)
		{
		}

		// Token: 0x0600766A RID: 30314 RVA: 0x000528D8 File Offset: 0x00050AD8
		[Token(Token = "0x600766A")]
		[Address(RVA = "0x2EC4368", Offset = "0x2EC4368", VA = "0x2EC4368")]
		public bool ContainsClip(string clipName, bool exactClipName = false)
		{
			return default(bool);
		}

		// Token: 0x0600766B RID: 30315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600766B")]
		[Address(RVA = "0x2EC45C8", Offset = "0x2EC45C8", VA = "0x2EC45C8")]
		public void CrossFadeInFixedTime(string clip, float transitionTime = 0.25f, float timeOffset = 0f, bool startOver = false)
		{
		}

		// Token: 0x0600766C RID: 30316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600766C")]
		[Address(RVA = "0x2EC475C", Offset = "0x2EC475C", VA = "0x2EC475C")]
		public void CrossFade(string clip, float transitionTime = 0.25f, float timeOffset = 0f, bool startOver = false)
		{
		}

		// Token: 0x0600766D RID: 30317 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600766D")]
		[Address(RVA = "0x2EC4640", Offset = "0x2EC4640", VA = "0x2EC4640")]
		private void RefreshClipMemory(string name)
		{
		}

		// Token: 0x0600766E RID: 30318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600766E")]
		[Address(RVA = "0x2EC47D4", Offset = "0x2EC47D4", VA = "0x2EC47D4")]
		public void SetFloat(string parameter, float value = 0f, float deltaSpeed = 60f)
		{
		}

		// Token: 0x0600766F RID: 30319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600766F")]
		[Address(RVA = "0x2EC486C", Offset = "0x2EC486C", VA = "0x2EC486C")]
		public void SetFloatUnscaledDelta(string parameter, float value = 0f, float deltaSpeed = 60f)
		{
		}

		// Token: 0x06007670 RID: 30320 RVA: 0x000528F0 File Offset: 0x00050AF0
		[Token(Token = "0x6007670")]
		[Address(RVA = "0x2EC46A0", Offset = "0x2EC46A0", VA = "0x2EC46A0")]
		internal bool IsPlaying(string clip)
		{
			return default(bool);
		}

		// Token: 0x04003016 RID: 12310
		[Token(Token = "0x4003016")]
		[FieldOffset(Offset = "0x10")]
		public readonly Animator Animator;
	}
}
