using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace RealisticEyeMovements
{
	// Token: 0x02000C65 RID: 3173
	[Token(Token = "0x2000C65")]
	public class BlinkingComponent
	{
		// Token: 0x17000AD5 RID: 2773
		// (get) Token: 0x0600792A RID: 31018 RVA: 0x000533B8 File Offset: 0x000515B8
		// (set) Token: 0x0600792B RID: 31019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AD5")]
		public float blink01
		{
			[Token(Token = "0x600792A")]
			[Address(RVA = "0x1585BA4", Offset = "0x1585BA4", VA = "0x1585BA4")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600792B")]
			[Address(RVA = "0x1585BAC", Offset = "0x1585BAC", VA = "0x1585BAC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000AD6 RID: 2774
		// (get) Token: 0x0600792C RID: 31020 RVA: 0x000533D0 File Offset: 0x000515D0
		// (set) Token: 0x0600792D RID: 31021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AD6")]
		public float timeSinceLastBlinkFinished
		{
			[Token(Token = "0x600792C")]
			[Address(RVA = "0x1585BB4", Offset = "0x1585BB4", VA = "0x1585BB4")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600792D")]
			[Address(RVA = "0x1585BBC", Offset = "0x1585BBC", VA = "0x1585BBC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600792E RID: 31022 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600792E")]
		[Address(RVA = "0x1581DDC", Offset = "0x1581DDC", VA = "0x1581DDC")]
		public BlinkingComponent(EyeAndHeadAnimator eyeAndHeadAnimator)
		{
		}

		// Token: 0x0600792F RID: 31023 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600792F")]
		[Address(RVA = "0x1579804", Offset = "0x1579804", VA = "0x1579804")]
		public void Blink(bool isShortBlink = true)
		{
		}

		// Token: 0x06007930 RID: 31024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007930")]
		[Address(RVA = "0x1583C5C", Offset = "0x1583C5C", VA = "0x1583C5C")]
		public void ResetBlinking()
		{
		}

		// Token: 0x06007931 RID: 31025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007931")]
		[Address(RVA = "0x1584D44", Offset = "0x1584D44", VA = "0x1584D44")]
		public void UpdateBlinking(float deltaTime)
		{
		}

		// Token: 0x04003353 RID: 13139
		[Token(Token = "0x4003353")]
		[FieldOffset(Offset = "0x18")]
		private readonly EyeAndHeadAnimator eyeAndHeadAnimator;

		// Token: 0x04003354 RID: 13140
		[Token(Token = "0x4003354")]
		[FieldOffset(Offset = "0x20")]
		private float timeTillNextBlink;

		// Token: 0x04003356 RID: 13142
		[Token(Token = "0x4003356")]
		[FieldOffset(Offset = "0x28")]
		private BlinkingComponent.BlinkState blinkState;

		// Token: 0x04003357 RID: 13143
		[Token(Token = "0x4003357")]
		[FieldOffset(Offset = "0x2C")]
		private float blinkStateTime;

		// Token: 0x04003358 RID: 13144
		[Token(Token = "0x4003358")]
		[FieldOffset(Offset = "0x30")]
		private float blinkStateDuration;

		// Token: 0x04003359 RID: 13145
		[Token(Token = "0x4003359")]
		[FieldOffset(Offset = "0x34")]
		private float blinkLerpStart;

		// Token: 0x0400335A RID: 13146
		[Token(Token = "0x400335A")]
		[FieldOffset(Offset = "0x38")]
		private float blinkLerpEnd;

		// Token: 0x0400335B RID: 13147
		[Token(Token = "0x400335B")]
		[FieldOffset(Offset = "0x3C")]
		private float blinkLerpMaxSpeedClosing;

		// Token: 0x0400335C RID: 13148
		[Token(Token = "0x400335C")]
		[FieldOffset(Offset = "0x40")]
		private float blinkLerpMaxSpeedForEarlyOpening;

		// Token: 0x0400335D RID: 13149
		[Token(Token = "0x400335D")]
		[FieldOffset(Offset = "0x44")]
		private float blinkLerpEndSpeedForEarlyOpening;

		// Token: 0x0400335E RID: 13150
		[Token(Token = "0x400335E")]
		[FieldOffset(Offset = "0x48")]
		private float blinkLerpAccelerationClosing;

		// Token: 0x0400335F RID: 13151
		[Token(Token = "0x400335F")]
		[FieldOffset(Offset = "0x4C")]
		private float blinkLerpAccelerationEarlyOpening1;

		// Token: 0x04003360 RID: 13152
		[Token(Token = "0x4003360")]
		[FieldOffset(Offset = "0x50")]
		private float blinkLerpAccelerationLateOpening;

		// Token: 0x04003361 RID: 13153
		[Token(Token = "0x4003361")]
		[FieldOffset(Offset = "0x54")]
		private float blinkLerpSpeed;

		// Token: 0x04003362 RID: 13154
		[Token(Token = "0x4003362")]
		[FieldOffset(Offset = "0x58")]
		private bool isShortBlink;

		// Token: 0x04003363 RID: 13155
		[Token(Token = "0x4003363")]
		private const float kShortBlinkFactor = 0.8f;

		// Token: 0x04003364 RID: 13156
		[Token(Token = "0x4003364")]
		private const float kBlinkCloseDuration = 0.07988f;

		// Token: 0x04003365 RID: 13157
		[Token(Token = "0x4003365")]
		private const float kBlinkClosedDuration = 0.022990001f;

		// Token: 0x04003366 RID: 13158
		[Token(Token = "0x4003366")]
		private const float kBlinkEarlyOpenAccelerationDuration = 0.053430002f;

		// Token: 0x04003367 RID: 13159
		[Token(Token = "0x4003367")]
		private const float kBlinkEarlyOpenDecelerationDuration = 0.11748001f;

		// Token: 0x04003368 RID: 13160
		[Token(Token = "0x4003368")]
		private const float kBlinkLateOpenDuration = 0.3f;

		// Token: 0x04003369 RID: 13161
		[Token(Token = "0x4003369")]
		private const float kBlinkLerpAtEarlyOpenAccelerationEnd = 0.65999997f;

		// Token: 0x0400336A RID: 13162
		[Token(Token = "0x400336A")]
		private const float kBlinkLerpAtEarlyOpenDecelerationEnd = 0.16000003f;

		// Token: 0x02000C66 RID: 3174
		[Token(Token = "0x2000C66")]
		private enum BlinkState
		{
			// Token: 0x0400336C RID: 13164
			[Token(Token = "0x400336C")]
			Idle,
			// Token: 0x0400336D RID: 13165
			[Token(Token = "0x400336D")]
			Closing,
			// Token: 0x0400336E RID: 13166
			[Token(Token = "0x400336E")]
			Closed,
			// Token: 0x0400336F RID: 13167
			[Token(Token = "0x400336F")]
			EarlyOpeningAccelerating,
			// Token: 0x04003370 RID: 13168
			[Token(Token = "0x4003370")]
			EarlyOpeningDecelerating,
			// Token: 0x04003371 RID: 13169
			[Token(Token = "0x4003371")]
			LateOpening
		}
	}
}
