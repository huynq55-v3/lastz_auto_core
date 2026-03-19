using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace FIMSpace.Basics
{
	// Token: 0x02000C18 RID: 3096
	[Token(Token = "0x2000C18")]
	public class FAnimationClips : Dictionary<string, int>
	{
		// Token: 0x17000A60 RID: 2656
		// (get) Token: 0x06007655 RID: 30293 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06007656 RID: 30294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A60")]
		public string CurrentAnimation
		{
			[Token(Token = "0x6007655")]
			[Address(RVA = "0x2EC3AA0", Offset = "0x2EC3AA0", VA = "0x2EC3AA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6007656")]
			[Address(RVA = "0x2EC3AA8", Offset = "0x2EC3AA8", VA = "0x2EC3AA8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000A61 RID: 2657
		// (get) Token: 0x06007657 RID: 30295 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06007658 RID: 30296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A61")]
		public string PreviousAnimation
		{
			[Token(Token = "0x6007657")]
			[Address(RVA = "0x2EC3AB0", Offset = "0x2EC3AB0", VA = "0x2EC3AB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6007658")]
			[Address(RVA = "0x2EC3AB8", Offset = "0x2EC3AB8", VA = "0x2EC3AB8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06007659 RID: 30297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007659")]
		[Address(RVA = "0x2EC3AC0", Offset = "0x2EC3AC0", VA = "0x2EC3AC0")]
		public FAnimationClips(Animator animator)
		{
		}

		// Token: 0x0600765A RID: 30298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600765A")]
		[Address(RVA = "0x2EC3B58", Offset = "0x2EC3B58", VA = "0x2EC3B58")]
		public void Add(string clipName, bool exactClipName = false)
		{
		}

		// Token: 0x0600765B RID: 30299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600765B")]
		[Address(RVA = "0x2EC3B6C", Offset = "0x2EC3B6C", VA = "0x2EC3B6C")]
		public void AddClip(string clipName, bool exactClipName = false)
		{
		}

		// Token: 0x0600765C RID: 30300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600765C")]
		[Address(RVA = "0x2EC3B80", Offset = "0x2EC3B80", VA = "0x2EC3B80")]
		public void AddClip(Animator animator, string clipName, bool exactClipName = false)
		{
		}

		// Token: 0x0600765D RID: 30301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600765D")]
		[Address(RVA = "0x2EC3E50", Offset = "0x2EC3E50", VA = "0x2EC3E50")]
		public void CrossFadeInFixedTime(string clip, float transitionTime = 0.25f, float timeOffset = 0f, bool startOver = false)
		{
		}

		// Token: 0x0600765E RID: 30302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600765E")]
		[Address(RVA = "0x2EC4088", Offset = "0x2EC4088", VA = "0x2EC4088")]
		public void CrossFade(string clip, float transitionTime = 0.25f, float timeOffset = 0f, bool startOver = false)
		{
		}

		// Token: 0x0600765F RID: 30303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600765F")]
		[Address(RVA = "0x2EC3F40", Offset = "0x2EC3F40", VA = "0x2EC3F40")]
		private void RefreshClipMemory(string name)
		{
		}

		// Token: 0x06007660 RID: 30304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007660")]
		[Address(RVA = "0x2EC4178", Offset = "0x2EC4178", VA = "0x2EC4178")]
		public void SetFloat(string parameter, float value = 0f, float deltaSpeed = 60f)
		{
		}

		// Token: 0x06007661 RID: 30305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007661")]
		[Address(RVA = "0x2EC4210", Offset = "0x2EC4210", VA = "0x2EC4210")]
		public void SetFloatUnscaledDelta(string parameter, float value = 0f, float deltaSpeed = 60f)
		{
		}

		// Token: 0x06007662 RID: 30306 RVA: 0x000528A8 File Offset: 0x00050AA8
		[Token(Token = "0x6007662")]
		[Address(RVA = "0x2EC3FA0", Offset = "0x2EC3FA0", VA = "0x2EC3FA0")]
		internal bool IsPlaying(string clip)
		{
			return default(bool);
		}

		// Token: 0x04003012 RID: 12306
		[Token(Token = "0x4003012")]
		[FieldOffset(Offset = "0x50")]
		public readonly Animator Animator;

		// Token: 0x04003015 RID: 12309
		[Token(Token = "0x4003015")]
		[FieldOffset(Offset = "0x68")]
		public int Layer;
	}
}
