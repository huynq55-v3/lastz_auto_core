using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.Playables;

// Token: 0x02000054 RID: 84
[Token(Token = "0x2000054")]
public class SimpleAnimationPlayable : PlayableBehaviour
{
	// Token: 0x1700002D RID: 45
	// (get) Token: 0x06000170 RID: 368 RVA: 0x000025E0 File Offset: 0x000007E0
	// (set) Token: 0x06000171 RID: 369 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700002D")]
	public bool keepStoppedPlayablesConnected
	{
		[Token(Token = "0x6000170")]
		[Address(RVA = "0x15F2520", Offset = "0x15F2520", VA = "0x15F2520")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000171")]
		[Address(RVA = "0x15F2528", Offset = "0x15F2528", VA = "0x15F2528")]
		set
		{
		}
	}

	// Token: 0x06000172 RID: 370 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000172")]
	[Address(RVA = "0x15F2540", Offset = "0x15F2540", VA = "0x15F2540")]
	private void UpdateStoppedPlayablesConnections()
	{
	}

	// Token: 0x1700002E RID: 46
	// (get) Token: 0x06000173 RID: 371 RVA: 0x000025F8 File Offset: 0x000007F8
	[Token(Token = "0x1700002E")]
	protected Playable self
	{
		[Token(Token = "0x6000173")]
		[Address(RVA = "0x15F26E8", Offset = "0x15F26E8", VA = "0x15F26E8")]
		get
		{
			return default(Playable);
		}
	}

	// Token: 0x1700002F RID: 47
	// (get) Token: 0x06000174 RID: 372 RVA: 0x00002610 File Offset: 0x00000810
	[Token(Token = "0x1700002F")]
	public Playable playable
	{
		[Token(Token = "0x6000174")]
		[Address(RVA = "0x15F0348", Offset = "0x15F0348", VA = "0x15F0348")]
		get
		{
			return default(Playable);
		}
	}

	// Token: 0x17000030 RID: 48
	// (get) Token: 0x06000175 RID: 373 RVA: 0x00002628 File Offset: 0x00000828
	[Token(Token = "0x17000030")]
	protected PlayableGraph graph
	{
		[Token(Token = "0x6000175")]
		[Address(RVA = "0x15F26F4", Offset = "0x15F26F4", VA = "0x15F26F4")]
		get
		{
			return default(PlayableGraph);
		}
	}

	// Token: 0x06000176 RID: 374 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000176")]
	[Address(RVA = "0x15F0928", Offset = "0x15F0928", VA = "0x15F0928")]
	public SimpleAnimationPlayable()
	{
	}

	// Token: 0x06000177 RID: 375 RVA: 0x00002640 File Offset: 0x00000840
	[Token(Token = "0x6000177")]
	[Address(RVA = "0x15F273C", Offset = "0x15F273C", VA = "0x15F273C")]
	public Playable GetInput(int index)
	{
		return default(Playable);
	}

	// Token: 0x06000178 RID: 376 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000178")]
	[Address(RVA = "0x15F27F4", Offset = "0x15F27F4", VA = "0x15F27F4", Slot = "15")]
	public override void OnPlayableCreate(Playable playable)
	{
	}

	// Token: 0x06000179 RID: 377 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000179")]
	[Address(RVA = "0x15F16C8", Offset = "0x15F16C8", VA = "0x15F16C8")]
	public IEnumerable<SimpleAnimationPlayable.IState> GetStates()
	{
		return null;
	}

	// Token: 0x0600017A RID: 378 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600017A")]
	[Address(RVA = "0x15EFEDC", Offset = "0x15EFEDC", VA = "0x15EFEDC")]
	public SimpleAnimationPlayable.IState GetState(string name)
	{
		return null;
	}

	// Token: 0x0600017B RID: 379 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600017B")]
	[Address(RVA = "0x15F2920", Offset = "0x15F2920", VA = "0x15F2920")]
	private SimpleAnimationPlayable.StateInfo DoAddClip(string name, AnimationClip clip)
	{
		return null;
	}

	// Token: 0x0600017C RID: 380 RVA: 0x00002658 File Offset: 0x00000858
	[Token(Token = "0x600017C")]
	[Address(RVA = "0x15EF1F0", Offset = "0x15EF1F0", VA = "0x15EF1F0")]
	public bool AddClip(AnimationClip clip, string name)
	{
		return default(bool);
	}

	// Token: 0x0600017D RID: 381 RVA: 0x00002670 File Offset: 0x00000870
	[Token(Token = "0x600017D")]
	[Address(RVA = "0x15EF818", Offset = "0x15EF818", VA = "0x15EF818")]
	public bool RemoveClip(string name)
	{
		return default(bool);
	}

	// Token: 0x0600017E RID: 382 RVA: 0x00002688 File Offset: 0x00000888
	[Token(Token = "0x600017E")]
	[Address(RVA = "0x15EFD6C", Offset = "0x15EFD6C", VA = "0x15EFD6C")]
	public bool RemoveClip(AnimationClip clip)
	{
		return default(bool);
	}

	// Token: 0x0600017F RID: 383 RVA: 0x000026A0 File Offset: 0x000008A0
	[Token(Token = "0x600017F")]
	[Address(RVA = "0x15EF1B8", Offset = "0x15EF1B8", VA = "0x15EF1B8")]
	public bool Play(string name)
	{
		return default(bool);
	}

	// Token: 0x06000180 RID: 384 RVA: 0x000026B8 File Offset: 0x000008B8
	[Token(Token = "0x6000180")]
	[Address(RVA = "0x15F2C94", Offset = "0x15F2C94", VA = "0x15F2C94")]
	private bool Play(int index)
	{
		return default(bool);
	}

	// Token: 0x06000181 RID: 385 RVA: 0x000026D0 File Offset: 0x000008D0
	[Token(Token = "0x6000181")]
	[Address(RVA = "0x15EFC3C", Offset = "0x15EFC3C", VA = "0x15EFC3C")]
	public bool PlayQueued(string name, QueueMode queueMode)
	{
		return default(bool);
	}

	// Token: 0x06000182 RID: 386 RVA: 0x000026E8 File Offset: 0x000008E8
	[Token(Token = "0x6000182")]
	[Address(RVA = "0x15F2DA8", Offset = "0x15F2DA8", VA = "0x15F2DA8")]
	private bool PlayQueued(int index, QueueMode queueMode)
	{
		return default(bool);
	}

	// Token: 0x06000183 RID: 387 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000183")]
	[Address(RVA = "0x15EFEA4", Offset = "0x15EFEA4", VA = "0x15EFEA4")]
	public void Rewind(string name)
	{
	}

	// Token: 0x06000184 RID: 388 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000184")]
	[Address(RVA = "0x15F2FEC", Offset = "0x15F2FEC", VA = "0x15F2FEC")]
	private void Rewind(int index)
	{
	}

	// Token: 0x06000185 RID: 389 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000185")]
	[Address(RVA = "0x15EFDE0", Offset = "0x15EFDE0", VA = "0x15EFDE0")]
	public void Rewind()
	{
	}

	// Token: 0x06000186 RID: 390 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000186")]
	[Address(RVA = "0x15F2B88", Offset = "0x15F2B88", VA = "0x15F2B88")]
	private void RemoveClones(SimpleAnimationPlayable.StateInfo state)
	{
	}

	// Token: 0x06000187 RID: 391 RVA: 0x00002700 File Offset: 0x00000900
	[Token(Token = "0x6000187")]
	[Address(RVA = "0x15EF090", Offset = "0x15EF090", VA = "0x15EF090")]
	public bool Stop(string name)
	{
		return default(bool);
	}

	// Token: 0x06000188 RID: 392 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000188")]
	[Address(RVA = "0x15F2D3C", Offset = "0x15F2D3C", VA = "0x15F2D3C")]
	private void DoStop(int index)
	{
	}

	// Token: 0x06000189 RID: 393 RVA: 0x00002718 File Offset: 0x00000918
	[Token(Token = "0x6000189")]
	[Address(RVA = "0x15EEFE0", Offset = "0x15EEFE0", VA = "0x15EEFE0")]
	public bool StopAll()
	{
		return default(bool);
	}

	// Token: 0x0600018A RID: 394 RVA: 0x00002730 File Offset: 0x00000930
	[Token(Token = "0x600018A")]
	[Address(RVA = "0x15EEA44", Offset = "0x15EEA44", VA = "0x15EEA44")]
	public bool IsPlaying()
	{
		return default(bool);
	}

	// Token: 0x0600018B RID: 395 RVA: 0x00002748 File Offset: 0x00000948
	[Token(Token = "0x600018B")]
	[Address(RVA = "0x15EEF74", Offset = "0x15EEF74", VA = "0x15EEF74")]
	public bool IsPlaying(string stateName)
	{
		return default(bool);
	}

	// Token: 0x0600018C RID: 396 RVA: 0x00002760 File Offset: 0x00000960
	[Token(Token = "0x600018C")]
	[Address(RVA = "0x15F300C", Offset = "0x15F300C", VA = "0x15F300C")]
	private bool IsClonePlaying(SimpleAnimationPlayable.StateInfo state)
	{
		return default(bool);
	}

	// Token: 0x0600018D RID: 397 RVA: 0x00002778 File Offset: 0x00000978
	[Token(Token = "0x600018D")]
	[Address(RVA = "0x15EEEE8", Offset = "0x15EEEE8", VA = "0x15EEEE8")]
	public int GetClipCount()
	{
		return 0;
	}

	// Token: 0x0600018E RID: 398 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600018E")]
	[Address(RVA = "0x15F3098", Offset = "0x15F3098", VA = "0x15F3098")]
	private void SetupLerp(SimpleAnimationPlayable.StateInfo state, float targetWeight, float time)
	{
	}

	// Token: 0x0600018F RID: 399 RVA: 0x00002790 File Offset: 0x00000990
	[Token(Token = "0x600018F")]
	[Address(RVA = "0x15F3190", Offset = "0x15F3190", VA = "0x15F3190")]
	private bool Crossfade(int index, float time)
	{
		return default(bool);
	}

	// Token: 0x06000190 RID: 400 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000190")]
	[Address(RVA = "0x15F2E6C", Offset = "0x15F2E6C", VA = "0x15F2E6C")]
	private SimpleAnimationPlayable.StateInfo CloneState(int index)
	{
		return null;
	}

	// Token: 0x06000191 RID: 401 RVA: 0x000027A8 File Offset: 0x000009A8
	[Token(Token = "0x6000191")]
	[Address(RVA = "0x15EED90", Offset = "0x15EED90", VA = "0x15EED90")]
	public bool Crossfade(string name, float time)
	{
		return default(bool);
	}

	// Token: 0x06000192 RID: 402 RVA: 0x000027C0 File Offset: 0x000009C0
	[Token(Token = "0x6000192")]
	[Address(RVA = "0x15EEE64", Offset = "0x15EEE64", VA = "0x15EEE64")]
	public bool CrossfadeQueued(string name, float time, QueueMode queueMode)
	{
		return default(bool);
	}

	// Token: 0x06000193 RID: 403 RVA: 0x000027D8 File Offset: 0x000009D8
	[Token(Token = "0x6000193")]
	[Address(RVA = "0x15F3250", Offset = "0x15F3250", VA = "0x15F3250")]
	private bool CrossfadeQueued(int index, float time, QueueMode queueMode)
	{
		return default(bool);
	}

	// Token: 0x06000194 RID: 404 RVA: 0x000027F0 File Offset: 0x000009F0
	[Token(Token = "0x6000194")]
	[Address(RVA = "0x15F3324", Offset = "0x15F3324", VA = "0x15F3324")]
	private bool Blend(int index, float targetWeight, float time)
	{
		return default(bool);
	}

	// Token: 0x06000195 RID: 405 RVA: 0x00002808 File Offset: 0x00000A08
	[Token(Token = "0x6000195")]
	[Address(RVA = "0x15EECD4", Offset = "0x15EECD4", VA = "0x15EECD4")]
	public bool Blend(string name, float targetWeight, float time)
	{
		return default(bool);
	}

	// Token: 0x06000196 RID: 406 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000196")]
	[Address(RVA = "0x15F33B8", Offset = "0x15F33B8", VA = "0x15F33B8", Slot = "14")]
	public override void OnGraphStop(Playable playable)
	{
	}

	// Token: 0x06000197 RID: 407 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000197")]
	[Address(RVA = "0x15F2AC4", Offset = "0x15F2AC4", VA = "0x15F2AC4")]
	private void UpdateDoneStatus()
	{
	}

	// Token: 0x06000198 RID: 408 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000198")]
	[Address(RVA = "0x15F34F4", Offset = "0x15F34F4", VA = "0x15F34F4")]
	private void CleanClonedStates()
	{
	}

	// Token: 0x06000199 RID: 409 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000199")]
	[Address(RVA = "0x15F264C", Offset = "0x15F264C", VA = "0x15F264C")]
	private void DisconnectInput(int index)
	{
	}

	// Token: 0x0600019A RID: 410 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600019A")]
	[Address(RVA = "0x15F25B4", Offset = "0x15F25B4", VA = "0x15F25B4")]
	private void ConnectInput(int index)
	{
	}

	// Token: 0x0600019B RID: 411 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600019B")]
	[Address(RVA = "0x15F3630", Offset = "0x15F3630", VA = "0x15F3630")]
	private void UpdateStates(float deltaTime)
	{
	}

	// Token: 0x0600019C RID: 412 RVA: 0x00002820 File Offset: 0x00000A20
	[Token(Token = "0x600019C")]
	[Address(RVA = "0x15F39C8", Offset = "0x15F39C8", VA = "0x15F39C8")]
	private float CalculateQueueTimes()
	{
		return 0f;
	}

	// Token: 0x0600019D RID: 413 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600019D")]
	[Address(RVA = "0x15F3B00", Offset = "0x15F3B00", VA = "0x15F3B00")]
	private void ClearQueuedStates()
	{
	}

	// Token: 0x0600019E RID: 414 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600019E")]
	[Address(RVA = "0x15F3CA4", Offset = "0x15F3CA4", VA = "0x15F3CA4")]
	private void UpdateQueuedStates()
	{
	}

	// Token: 0x0600019F RID: 415 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600019F")]
	[Address(RVA = "0x15F3DAC", Offset = "0x15F3DAC", VA = "0x15F3DAC")]
	private void InvalidateStateTimes()
	{
	}

	// Token: 0x060001A0 RID: 416 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001A0")]
	[Address(RVA = "0x15F3E0C", Offset = "0x15F3E0C", VA = "0x15F3E0C", Slot = "19")]
	public override void PrepareFrame(Playable owner, FrameData data)
	{
	}

	// Token: 0x060001A1 RID: 417 RVA: 0x00002838 File Offset: 0x00000A38
	[Token(Token = "0x60001A1")]
	[Address(RVA = "0x15F3E54", Offset = "0x15F3E54", VA = "0x15F3E54")]
	public bool ValidateInput(int index, Playable input)
	{
		return default(bool);
	}

	// Token: 0x060001A2 RID: 418 RVA: 0x00002850 File Offset: 0x00000A50
	[Token(Token = "0x60001A2")]
	[Address(RVA = "0x15F3F94", Offset = "0x15F3F94", VA = "0x15F3F94")]
	public bool ValidateIndex(int index)
	{
		return default(bool);
	}

	// Token: 0x060001A3 RID: 419 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001A3")]
	[Address(RVA = "0x15F2B78", Offset = "0x15F2B78", VA = "0x15F2B78")]
	private void InvalidateStates()
	{
	}

	// Token: 0x060001A4 RID: 420 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001A4")]
	[Address(RVA = "0x15F2F64", Offset = "0x15F2F64", VA = "0x15F2F64")]
	private SimpleAnimationPlayable.StateHandle StateInfoToHandle(SimpleAnimationPlayable.StateInfo info)
	{
		return null;
	}

	// Token: 0x040001B1 RID: 433
	[Token(Token = "0x40001B1")]
	[FieldOffset(Offset = "0x10")]
	private LinkedList<SimpleAnimationPlayable.QueuedState> m_StateQueue;

	// Token: 0x040001B2 RID: 434
	[Token(Token = "0x40001B2")]
	[FieldOffset(Offset = "0x18")]
	private SimpleAnimationPlayable.StateManagement m_States;

	// Token: 0x040001B3 RID: 435
	[Token(Token = "0x40001B3")]
	[FieldOffset(Offset = "0x20")]
	private bool m_Initialized;

	// Token: 0x040001B4 RID: 436
	[Token(Token = "0x40001B4")]
	[FieldOffset(Offset = "0x21")]
	private bool m_KeepStoppedPlayablesConnected;

	// Token: 0x040001B5 RID: 437
	[Token(Token = "0x40001B5")]
	[FieldOffset(Offset = "0x28")]
	protected Playable m_ActualPlayable;

	// Token: 0x040001B6 RID: 438
	[Token(Token = "0x40001B6")]
	[FieldOffset(Offset = "0x38")]
	private AnimationMixerPlayable m_Mixer;

	// Token: 0x040001B7 RID: 439
	[Token(Token = "0x40001B7")]
	[FieldOffset(Offset = "0x48")]
	public Action onDone;

	// Token: 0x040001B8 RID: 440
	[Token(Token = "0x40001B8")]
	[FieldOffset(Offset = "0x50")]
	private int m_StatesVersion;

	// Token: 0x02000055 RID: 85
	[Token(Token = "0x2000055")]
	private class StateEnumerable : IEnumerable<SimpleAnimationPlayable.IState>, IEnumerable
	{
		// Token: 0x060001A5 RID: 421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x3201104", Offset = "0x3201104", VA = "0x3201104")]
		public StateEnumerable(SimpleAnimationPlayable owner)
		{
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x3201134", Offset = "0x3201134", VA = "0x3201134", Slot = "4")]
		public IEnumerator<SimpleAnimationPlayable.IState> GetEnumerator()
		{
			return null;
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x32011F0", Offset = "0x32011F0", VA = "0x32011F0", Slot = "5")]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}

		// Token: 0x040001B9 RID: 441
		[Token(Token = "0x40001B9")]
		[FieldOffset(Offset = "0x10")]
		private SimpleAnimationPlayable m_Owner;

		// Token: 0x02000056 RID: 86
		[Token(Token = "0x2000056")]
		private class StateEnumerator : IEnumerator<SimpleAnimationPlayable.IState>, IEnumerator, IDisposable
		{
			// Token: 0x060001A8 RID: 424 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60001A8")]
			[Address(RVA = "0x3201198", Offset = "0x3201198", VA = "0x3201198")]
			public StateEnumerator(SimpleAnimationPlayable owner)
			{
			}

			// Token: 0x060001A9 RID: 425 RVA: 0x00002868 File Offset: 0x00000A68
			[Token(Token = "0x60001A9")]
			[Address(RVA = "0x32012CC", Offset = "0x32012CC", VA = "0x32012CC")]
			private bool IsValid()
			{
				return default(bool);
			}

			// Token: 0x060001AA RID: 426 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60001AA")]
			[Address(RVA = "0x32012F0", Offset = "0x32012F0", VA = "0x32012F0")]
			private SimpleAnimationPlayable.IState GetCurrentHandle(int index)
			{
				return null;
			}

			// Token: 0x17000031 RID: 49
			// (get) Token: 0x060001AB RID: 427 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000031")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60001AB")]
				[Address(RVA = "0x32014D4", Offset = "0x32014D4", VA = "0x32014D4", Slot = "7")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000032 RID: 50
			// (get) Token: 0x060001AC RID: 428 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000032")]
			private SimpleAnimationPlayable.IState System.Collections.Generic.IEnumerator<SimpleAnimationPlayable.IState>.Current
			{
				[Token(Token = "0x60001AC")]
				[Address(RVA = "0x32014DC", Offset = "0x32014DC", VA = "0x32014DC", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x060001AD RID: 429 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60001AD")]
			[Address(RVA = "0x32014E4", Offset = "0x32014E4", VA = "0x32014E4", Slot = "5")]
			public void Dispose()
			{
			}

			// Token: 0x060001AE RID: 430 RVA: 0x00002880 File Offset: 0x00000A80
			[Token(Token = "0x60001AE")]
			[Address(RVA = "0x32014E8", Offset = "0x32014E8", VA = "0x32014E8", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x060001AF RID: 431 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60001AF")]
			[Address(RVA = "0x3201254", Offset = "0x3201254", VA = "0x3201254", Slot = "8")]
			public void Reset()
			{
			}

			// Token: 0x040001BA RID: 442
			[Token(Token = "0x40001BA")]
			[FieldOffset(Offset = "0x10")]
			private int m_Index;

			// Token: 0x040001BB RID: 443
			[Token(Token = "0x40001BB")]
			[FieldOffset(Offset = "0x14")]
			private int m_Version;

			// Token: 0x040001BC RID: 444
			[Token(Token = "0x40001BC")]
			[FieldOffset(Offset = "0x18")]
			private SimpleAnimationPlayable m_Owner;
		}
	}

	// Token: 0x02000057 RID: 87
	[Token(Token = "0x2000057")]
	public interface IState
	{
		// Token: 0x060001B0 RID: 432
		[Token(Token = "0x60001B0")]
		bool IsValid();

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060001B1 RID: 433
		// (set) Token: 0x060001B2 RID: 434
		[Token(Token = "0x17000033")]
		bool enabled
		{
			[Token(Token = "0x60001B1")]
			get;
			[Token(Token = "0x60001B2")]
			set;
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060001B3 RID: 435
		// (set) Token: 0x060001B4 RID: 436
		[Token(Token = "0x17000034")]
		float time
		{
			[Token(Token = "0x60001B3")]
			get;
			[Token(Token = "0x60001B4")]
			set;
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060001B5 RID: 437
		// (set) Token: 0x060001B6 RID: 438
		[Token(Token = "0x17000035")]
		float normalizedTime
		{
			[Token(Token = "0x60001B5")]
			get;
			[Token(Token = "0x60001B6")]
			set;
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060001B7 RID: 439
		// (set) Token: 0x060001B8 RID: 440
		[Token(Token = "0x17000036")]
		float speed
		{
			[Token(Token = "0x60001B7")]
			get;
			[Token(Token = "0x60001B8")]
			set;
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060001B9 RID: 441
		// (set) Token: 0x060001BA RID: 442
		[Token(Token = "0x17000037")]
		string name
		{
			[Token(Token = "0x60001B9")]
			get;
			[Token(Token = "0x60001BA")]
			set;
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060001BB RID: 443
		// (set) Token: 0x060001BC RID: 444
		[Token(Token = "0x17000038")]
		float weight
		{
			[Token(Token = "0x60001BB")]
			get;
			[Token(Token = "0x60001BC")]
			set;
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060001BD RID: 445
		[Token(Token = "0x17000039")]
		float length
		{
			[Token(Token = "0x60001BD")]
			get;
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060001BE RID: 446
		[Token(Token = "0x1700003A")]
		AnimationClip clip
		{
			[Token(Token = "0x60001BE")]
			get;
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060001BF RID: 447
		[Token(Token = "0x1700003B")]
		WrapMode wrapMode
		{
			[Token(Token = "0x60001BF")]
			get;
		}
	}

	// Token: 0x02000058 RID: 88
	[Token(Token = "0x2000058")]
	public class StateHandle : SimpleAnimationPlayable.IState
	{
		// Token: 0x060001C0 RID: 448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x3201484", Offset = "0x3201484", VA = "0x3201484")]
		public StateHandle(SimpleAnimationPlayable s, int index, Playable target)
		{
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x00002898 File Offset: 0x00000A98
		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x32015BC", Offset = "0x32015BC", VA = "0x32015BC", Slot = "4")]
		public bool IsValid()
		{
			return default(bool);
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060001C2 RID: 450 RVA: 0x000028B0 File Offset: 0x00000AB0
		// (set) Token: 0x060001C3 RID: 451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700003C")]
		public bool enabled
		{
			[Token(Token = "0x60001C2")]
			[Address(RVA = "0x32015E4", Offset = "0x32015E4", VA = "0x32015E4", Slot = "5")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001C3")]
			[Address(RVA = "0x320166C", Offset = "0x320166C", VA = "0x320166C", Slot = "6")]
			set
			{
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060001C4 RID: 452 RVA: 0x000028C8 File Offset: 0x00000AC8
		// (set) Token: 0x060001C5 RID: 453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700003D")]
		public float time
		{
			[Token(Token = "0x60001C4")]
			[Address(RVA = "0x32017EC", Offset = "0x32017EC", VA = "0x32017EC", Slot = "7")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60001C5")]
			[Address(RVA = "0x32018C8", Offset = "0x32018C8", VA = "0x32018C8", Slot = "8")]
			set
			{
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060001C6 RID: 454 RVA: 0x000028E0 File Offset: 0x00000AE0
		// (set) Token: 0x060001C7 RID: 455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700003E")]
		public float normalizedTime
		{
			[Token(Token = "0x60001C6")]
			[Address(RVA = "0x32019C4", Offset = "0x32019C4", VA = "0x32019C4", Slot = "9")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60001C7")]
			[Address(RVA = "0x3201B30", Offset = "0x3201B30", VA = "0x3201B30", Slot = "10")]
			set
			{
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060001C8 RID: 456 RVA: 0x000028F8 File Offset: 0x00000AF8
		// (set) Token: 0x060001C9 RID: 457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700003F")]
		public float speed
		{
			[Token(Token = "0x60001C8")]
			[Address(RVA = "0x3201BE0", Offset = "0x3201BE0", VA = "0x3201BE0", Slot = "11")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60001C9")]
			[Address(RVA = "0x3201CBC", Offset = "0x3201CBC", VA = "0x3201CBC", Slot = "12")]
			set
			{
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060001CA RID: 458 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060001CB RID: 459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000040")]
		public string name
		{
			[Token(Token = "0x60001CA")]
			[Address(RVA = "0x3201DB8", Offset = "0x3201DB8", VA = "0x3201DB8", Slot = "13")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001CB")]
			[Address(RVA = "0x3201E98", Offset = "0x3201E98", VA = "0x3201E98", Slot = "14")]
			set
			{
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060001CC RID: 460 RVA: 0x00002910 File Offset: 0x00000B10
		// (set) Token: 0x060001CD RID: 461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000041")]
		public float weight
		{
			[Token(Token = "0x60001CC")]
			[Address(RVA = "0x3201FD4", Offset = "0x3201FD4", VA = "0x3201FD4", Slot = "15")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60001CD")]
			[Address(RVA = "0x320205C", Offset = "0x320205C", VA = "0x320205C", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060001CE RID: 462 RVA: 0x00002928 File Offset: 0x00000B28
		[Token(Token = "0x17000042")]
		public float length
		{
			[Token(Token = "0x60001CE")]
			[Address(RVA = "0x32021A0", Offset = "0x32021A0", VA = "0x32021A0", Slot = "17")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060001CF RID: 463 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000043")]
		public AnimationClip clip
		{
			[Token(Token = "0x60001CF")]
			[Address(RVA = "0x3202318", Offset = "0x3202318", VA = "0x3202318", Slot = "18")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060001D0 RID: 464 RVA: 0x00002940 File Offset: 0x00000B40
		[Token(Token = "0x17000044")]
		public WrapMode wrapMode
		{
			[Token(Token = "0x60001D0")]
			[Address(RVA = "0x32023F8", Offset = "0x32023F8", VA = "0x32023F8", Slot = "19")]
			get
			{
				return default(WrapMode);
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060001D1 RID: 465 RVA: 0x00002958 File Offset: 0x00000B58
		[Token(Token = "0x17000045")]
		public int index
		{
			[Token(Token = "0x60001D1")]
			[Address(RVA = "0x32024D8", Offset = "0x32024D8", VA = "0x32024D8")]
			get
			{
				return 0;
			}
		}

		// Token: 0x040001BD RID: 445
		[Token(Token = "0x40001BD")]
		[FieldOffset(Offset = "0x10")]
		private SimpleAnimationPlayable m_Parent;

		// Token: 0x040001BE RID: 446
		[Token(Token = "0x40001BE")]
		[FieldOffset(Offset = "0x18")]
		private int m_Index;

		// Token: 0x040001BF RID: 447
		[Token(Token = "0x40001BF")]
		[FieldOffset(Offset = "0x20")]
		private Playable m_Target;
	}

	// Token: 0x02000059 RID: 89
	[Token(Token = "0x2000059")]
	private class StateInfo
	{
		// Token: 0x060001D2 RID: 466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x32024E0", Offset = "0x32024E0", VA = "0x32024E0")]
		public void Initialize(string name, AnimationClip clip, WrapMode wrapMode)
		{
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x00002970 File Offset: 0x00000B70
		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x320251C", Offset = "0x320251C", VA = "0x320251C")]
		public float GetTime()
		{
			return 0f;
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x3202588", Offset = "0x3202588", VA = "0x3202588")]
		public void SetTime(float newTime)
		{
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x3202634", Offset = "0x3202634", VA = "0x3202634")]
		public void Enable()
		{
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x3202650", Offset = "0x3202650", VA = "0x3202650")]
		public void Disable()
		{
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x3202668", Offset = "0x3202668", VA = "0x3202668")]
		public void Pause()
		{
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x32026B4", Offset = "0x32026B4", VA = "0x32026B4")]
		public void Play()
		{
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x3202700", Offset = "0x3202700", VA = "0x3202700")]
		public void Stop()
		{
		}

		// Token: 0x060001DA RID: 474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x3202790", Offset = "0x3202790", VA = "0x3202790")]
		public void ForceWeight(float weight)
		{
		}

		// Token: 0x060001DB RID: 475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x32027A8", Offset = "0x32027A8", VA = "0x32027A8")]
		public void SetWeight(float weight)
		{
		}

		// Token: 0x060001DC RID: 476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x32027B8", Offset = "0x32027B8", VA = "0x32027B8")]
		public void FadeTo(float weight, float speed)
		{
		}

		// Token: 0x060001DD RID: 477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x32027D4", Offset = "0x32027D4", VA = "0x32027D4")]
		public void DestroyPlayable()
		{
		}

		// Token: 0x060001DE RID: 478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x3202878", Offset = "0x3202878", VA = "0x3202878")]
		public void SetAsCloneOf(SimpleAnimationPlayable.StateHandle handle)
		{
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060001DF RID: 479 RVA: 0x00002988 File Offset: 0x00000B88
		[Token(Token = "0x17000046")]
		public bool enabled
		{
			[Token(Token = "0x60001DF")]
			[Address(RVA = "0x320289C", Offset = "0x320289C", VA = "0x320289C")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060001E0 RID: 480 RVA: 0x000029A0 File Offset: 0x00000BA0
		// (set) Token: 0x060001E1 RID: 481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000047")]
		public int index
		{
			[Token(Token = "0x60001E0")]
			[Address(RVA = "0x32028A4", Offset = "0x32028A4", VA = "0x32028A4")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60001E1")]
			[Address(RVA = "0x32028AC", Offset = "0x32028AC", VA = "0x32028AC")]
			set
			{
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060001E2 RID: 482 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060001E3 RID: 483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000048")]
		public string stateName
		{
			[Token(Token = "0x60001E2")]
			[Address(RVA = "0x32028B4", Offset = "0x32028B4", VA = "0x32028B4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001E3")]
			[Address(RVA = "0x32028BC", Offset = "0x32028BC", VA = "0x32028BC")]
			set
			{
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060001E4 RID: 484 RVA: 0x000029B8 File Offset: 0x00000BB8
		[Token(Token = "0x17000049")]
		public bool fading
		{
			[Token(Token = "0x60001E4")]
			[Address(RVA = "0x32028C4", Offset = "0x32028C4", VA = "0x32028C4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060001E5 RID: 485 RVA: 0x000029D0 File Offset: 0x00000BD0
		[Token(Token = "0x1700004A")]
		public float targetWeight
		{
			[Token(Token = "0x60001E5")]
			[Address(RVA = "0x32028CC", Offset = "0x32028CC", VA = "0x32028CC")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060001E6 RID: 486 RVA: 0x000029E8 File Offset: 0x00000BE8
		[Token(Token = "0x1700004B")]
		public float weight
		{
			[Token(Token = "0x60001E6")]
			[Address(RVA = "0x32028D4", Offset = "0x32028D4", VA = "0x32028D4")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060001E7 RID: 487 RVA: 0x00002A00 File Offset: 0x00000C00
		[Token(Token = "0x1700004C")]
		public float fadeSpeed
		{
			[Token(Token = "0x60001E7")]
			[Address(RVA = "0x32028DC", Offset = "0x32028DC", VA = "0x32028DC")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060001E8 RID: 488 RVA: 0x00002A18 File Offset: 0x00000C18
		// (set) Token: 0x060001E9 RID: 489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700004D")]
		public float speed
		{
			[Token(Token = "0x60001E8")]
			[Address(RVA = "0x32028E4", Offset = "0x32028E4", VA = "0x32028E4")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60001E9")]
			[Address(RVA = "0x3202934", Offset = "0x3202934", VA = "0x3202934")]
			set
			{
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060001EA RID: 490 RVA: 0x00002A30 File Offset: 0x00000C30
		[Token(Token = "0x1700004E")]
		public float playableDuration
		{
			[Token(Token = "0x60001EA")]
			[Address(RVA = "0x320298C", Offset = "0x320298C", VA = "0x320298C")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060001EB RID: 491 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700004F")]
		public AnimationClip clip
		{
			[Token(Token = "0x60001EB")]
			[Address(RVA = "0x32029DC", Offset = "0x32029DC", VA = "0x32029DC")]
			get
			{
				return null;
			}
		}

		// Token: 0x060001EC RID: 492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x32029E4", Offset = "0x32029E4", VA = "0x32029E4")]
		public void SetPlayable(Playable playable)
		{
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060001ED RID: 493 RVA: 0x00002A48 File Offset: 0x00000C48
		[Token(Token = "0x17000050")]
		public bool isDone
		{
			[Token(Token = "0x60001ED")]
			[Address(RVA = "0x32029EC", Offset = "0x32029EC", VA = "0x32029EC")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060001EE RID: 494 RVA: 0x00002A60 File Offset: 0x00000C60
		[Token(Token = "0x17000051")]
		public Playable playable
		{
			[Token(Token = "0x60001EE")]
			[Address(RVA = "0x3202A34", Offset = "0x3202A34", VA = "0x3202A34")]
			get
			{
				return default(Playable);
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060001EF RID: 495 RVA: 0x00002A78 File Offset: 0x00000C78
		[Token(Token = "0x17000052")]
		public WrapMode wrapMode
		{
			[Token(Token = "0x60001EF")]
			[Address(RVA = "0x3202A40", Offset = "0x3202A40", VA = "0x3202A40")]
			get
			{
				return default(WrapMode);
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060001F0 RID: 496 RVA: 0x00002A90 File Offset: 0x00000C90
		[Token(Token = "0x17000053")]
		public bool isClone
		{
			[Token(Token = "0x60001F0")]
			[Address(RVA = "0x3202A48", Offset = "0x3202A48", VA = "0x3202A48")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060001F1 RID: 497 RVA: 0x00002AA8 File Offset: 0x00000CA8
		[Token(Token = "0x17000054")]
		public bool isReadyForCleanup
		{
			[Token(Token = "0x60001F1")]
			[Address(RVA = "0x3202A50", Offset = "0x3202A50", VA = "0x3202A50")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x060001F2 RID: 498 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000055")]
		public SimpleAnimationPlayable.StateHandle parentState
		{
			[Token(Token = "0x60001F2")]
			[Address(RVA = "0x3202A58", Offset = "0x3202A58", VA = "0x3202A58")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x060001F3 RID: 499 RVA: 0x00002AC0 File Offset: 0x00000CC0
		[Token(Token = "0x17000056")]
		public bool enabledDirty
		{
			[Token(Token = "0x60001F3")]
			[Address(RVA = "0x3202A60", Offset = "0x3202A60", VA = "0x3202A60")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x060001F4 RID: 500 RVA: 0x00002AD8 File Offset: 0x00000CD8
		[Token(Token = "0x17000057")]
		public bool weightDirty
		{
			[Token(Token = "0x60001F4")]
			[Address(RVA = "0x3202A68", Offset = "0x3202A68", VA = "0x3202A68")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x3202A70", Offset = "0x3202A70", VA = "0x3202A70")]
		public void ResetDirtyFlags()
		{
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x3202A78", Offset = "0x3202A78", VA = "0x3202A78")]
		public void InvalidateTime()
		{
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x3202A80", Offset = "0x3202A80", VA = "0x3202A80")]
		public StateInfo()
		{
		}

		// Token: 0x040001C0 RID: 448
		[Token(Token = "0x40001C0")]
		[FieldOffset(Offset = "0x10")]
		private bool m_Enabled;

		// Token: 0x040001C1 RID: 449
		[Token(Token = "0x40001C1")]
		[FieldOffset(Offset = "0x14")]
		private int m_Index;

		// Token: 0x040001C2 RID: 450
		[Token(Token = "0x40001C2")]
		[FieldOffset(Offset = "0x18")]
		private string m_StateName;

		// Token: 0x040001C3 RID: 451
		[Token(Token = "0x40001C3")]
		[FieldOffset(Offset = "0x20")]
		private bool m_Fading;

		// Token: 0x040001C4 RID: 452
		[Token(Token = "0x40001C4")]
		[FieldOffset(Offset = "0x24")]
		private float m_Time;

		// Token: 0x040001C5 RID: 453
		[Token(Token = "0x40001C5")]
		[FieldOffset(Offset = "0x28")]
		private float m_TargetWeight;

		// Token: 0x040001C6 RID: 454
		[Token(Token = "0x40001C6")]
		[FieldOffset(Offset = "0x2C")]
		private float m_Weight;

		// Token: 0x040001C7 RID: 455
		[Token(Token = "0x40001C7")]
		[FieldOffset(Offset = "0x30")]
		private float m_FadeSpeed;

		// Token: 0x040001C8 RID: 456
		[Token(Token = "0x40001C8")]
		[FieldOffset(Offset = "0x38")]
		private AnimationClip m_Clip;

		// Token: 0x040001C9 RID: 457
		[Token(Token = "0x40001C9")]
		[FieldOffset(Offset = "0x40")]
		private Playable m_Playable;

		// Token: 0x040001CA RID: 458
		[Token(Token = "0x40001CA")]
		[FieldOffset(Offset = "0x50")]
		private WrapMode m_WrapMode;

		// Token: 0x040001CB RID: 459
		[Token(Token = "0x40001CB")]
		[FieldOffset(Offset = "0x54")]
		private bool m_IsClone;

		// Token: 0x040001CC RID: 460
		[Token(Token = "0x40001CC")]
		[FieldOffset(Offset = "0x55")]
		private bool m_ReadyForCleanup;

		// Token: 0x040001CD RID: 461
		[Token(Token = "0x40001CD")]
		[FieldOffset(Offset = "0x58")]
		public SimpleAnimationPlayable.StateHandle m_ParentState;

		// Token: 0x040001CE RID: 462
		[Token(Token = "0x40001CE")]
		[FieldOffset(Offset = "0x60")]
		private bool m_WeightDirty;

		// Token: 0x040001CF RID: 463
		[Token(Token = "0x40001CF")]
		[FieldOffset(Offset = "0x61")]
		private bool m_EnabledDirty;

		// Token: 0x040001D0 RID: 464
		[Token(Token = "0x40001D0")]
		[FieldOffset(Offset = "0x62")]
		private bool m_TimeIsUpToDate;
	}

	// Token: 0x0200005A RID: 90
	[Token(Token = "0x200005A")]
	private class StateManagement
	{
		// Token: 0x17000058 RID: 88
		// (get) Token: 0x060001F8 RID: 504 RVA: 0x00002AF0 File Offset: 0x00000CF0
		[Token(Token = "0x17000058")]
		public int Count
		{
			[Token(Token = "0x60001F8")]
			[Address(RVA = "0x3202A88", Offset = "0x3202A88", VA = "0x3202A88")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000059 RID: 89
		[Token(Token = "0x17000059")]
		public SimpleAnimationPlayable.StateInfo this[int i]
		{
			[Token(Token = "0x60001F9")]
			[Address(RVA = "0x320142C", Offset = "0x320142C", VA = "0x320142C")]
			get
			{
				return null;
			}
		}

		// Token: 0x060001FA RID: 506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x3202A90", Offset = "0x3202A90", VA = "0x3202A90")]
		public StateManagement()
		{
		}

		// Token: 0x060001FB RID: 507 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x3202B18", Offset = "0x3202B18", VA = "0x3202B18")]
		public SimpleAnimationPlayable.StateInfo InsertState()
		{
			return null;
		}

		// Token: 0x060001FC RID: 508 RVA: 0x00002B08 File Offset: 0x00000D08
		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x3202D2C", Offset = "0x3202D2C", VA = "0x3202D2C")]
		public bool AnyStatePlaying()
		{
			return default(bool);
		}

		// Token: 0x060001FD RID: 509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x3202E40", Offset = "0x3202E40", VA = "0x3202E40")]
		public void RemoveState(int index)
		{
		}

		// Token: 0x060001FE RID: 510 RVA: 0x00002B20 File Offset: 0x00000D20
		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x3202EF8", Offset = "0x3202EF8", VA = "0x3202EF8")]
		public bool RemoveClip(AnimationClip clip)
		{
			return default(bool);
		}

		// Token: 0x060001FF RID: 511 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x3202FE8", Offset = "0x3202FE8", VA = "0x3202FE8")]
		public SimpleAnimationPlayable.StateInfo FindState(string name)
		{
			return null;
		}

		// Token: 0x06000200 RID: 512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000200")]
		[Address(RVA = "0x3201704", Offset = "0x3201704", VA = "0x3201704")]
		public void EnableState(int index)
		{
		}

		// Token: 0x06000201 RID: 513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000201")]
		[Address(RVA = "0x3201778", Offset = "0x3201778", VA = "0x3201778")]
		public void DisableState(int index)
		{
		}

		// Token: 0x06000202 RID: 514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000202")]
		[Address(RVA = "0x3202128", Offset = "0x3202128", VA = "0x3202128")]
		public void SetInputWeight(int index, float weight)
		{
		}

		// Token: 0x06000203 RID: 515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000203")]
		[Address(RVA = "0x3201954", Offset = "0x3201954", VA = "0x3201954")]
		public void SetStateTime(int index, float time)
		{
		}

		// Token: 0x06000204 RID: 516 RVA: 0x00002B38 File Offset: 0x00000D38
		[Token(Token = "0x6000204")]
		[Address(RVA = "0x3201868", Offset = "0x3201868", VA = "0x3201868")]
		public float GetStateTime(int index)
		{
			return 0f;
		}

		// Token: 0x06000205 RID: 517 RVA: 0x00002B50 File Offset: 0x00000D50
		[Token(Token = "0x6000205")]
		[Address(RVA = "0x32030CC", Offset = "0x32030CC", VA = "0x32030CC")]
		public bool IsCloneOf(int potentialCloneIndex, int originalIndex)
		{
			return default(bool);
		}

		// Token: 0x06000206 RID: 518 RVA: 0x00002B68 File Offset: 0x00000D68
		[Token(Token = "0x6000206")]
		[Address(RVA = "0x3201C5C", Offset = "0x3201C5C", VA = "0x3201C5C")]
		public float GetStateSpeed(int index)
		{
			return 0f;
		}

		// Token: 0x06000207 RID: 519 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000207")]
		[Address(RVA = "0x3201D48", Offset = "0x3201D48", VA = "0x3201D48")]
		public void SetStateSpeed(int index, float value)
		{
		}

		// Token: 0x06000208 RID: 520 RVA: 0x00002B80 File Offset: 0x00000D80
		[Token(Token = "0x6000208")]
		[Address(RVA = "0x320315C", Offset = "0x320315C", VA = "0x320315C")]
		public float GetInputWeight(int index)
		{
			return 0f;
		}

		// Token: 0x06000209 RID: 521 RVA: 0x00002B98 File Offset: 0x00000D98
		[Token(Token = "0x6000209")]
		[Address(RVA = "0x320221C", Offset = "0x320221C", VA = "0x320221C")]
		public float GetStateLength(int index)
		{
			return 0f;
		}

		// Token: 0x0600020A RID: 522 RVA: 0x00002BB0 File Offset: 0x00000DB0
		[Token(Token = "0x600020A")]
		[Address(RVA = "0x3201A74", Offset = "0x3201A74", VA = "0x3201A74")]
		public float GetClipLength(int index)
		{
			return 0f;
		}

		// Token: 0x0600020B RID: 523 RVA: 0x00002BC8 File Offset: 0x00000DC8
		[Token(Token = "0x600020B")]
		[Address(RVA = "0x32031C0", Offset = "0x32031C0", VA = "0x32031C0")]
		public float GetStatePlayableDuration(int index)
		{
			return 0f;
		}

		// Token: 0x0600020C RID: 524 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600020C")]
		[Address(RVA = "0x3202394", Offset = "0x3202394", VA = "0x3202394")]
		public AnimationClip GetStateClip(int index)
		{
			return null;
		}

		// Token: 0x0600020D RID: 525 RVA: 0x00002BE0 File Offset: 0x00000DE0
		[Token(Token = "0x600020D")]
		[Address(RVA = "0x3202474", Offset = "0x3202474", VA = "0x3202474")]
		public WrapMode GetStateWrapMode(int index)
		{
			return default(WrapMode);
		}

		// Token: 0x0600020E RID: 526 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600020E")]
		[Address(RVA = "0x3201E34", Offset = "0x3201E34", VA = "0x3201E34")]
		public string GetStateName(int index)
		{
			return null;
		}

		// Token: 0x0600020F RID: 527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600020F")]
		[Address(RVA = "0x3201F60", Offset = "0x3201F60", VA = "0x3201F60")]
		public void SetStateName(int index, string name)
		{
		}

		// Token: 0x06000210 RID: 528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000210")]
		[Address(RVA = "0x3203220", Offset = "0x3203220", VA = "0x3203220")]
		public void StopState(int index, bool cleanup)
		{
		}

		// Token: 0x040001D1 RID: 465
		[Token(Token = "0x40001D1")]
		[FieldOffset(Offset = "0x10")]
		private List<SimpleAnimationPlayable.StateInfo> m_States;

		// Token: 0x040001D2 RID: 466
		[Token(Token = "0x40001D2")]
		[FieldOffset(Offset = "0x18")]
		private int m_Count;
	}

	// Token: 0x0200005C RID: 92
	[Token(Token = "0x200005C")]
	private struct QueuedState
	{
		// Token: 0x06000215 RID: 533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000215")]
		[Address(RVA = "0x3203348", Offset = "0x3203348", VA = "0x3203348")]
		public QueuedState(SimpleAnimationPlayable.StateHandle s, float t)
		{
		}

		// Token: 0x040001D6 RID: 470
		[Token(Token = "0x40001D6")]
		[FieldOffset(Offset = "0x0")]
		public SimpleAnimationPlayable.StateHandle state;

		// Token: 0x040001D7 RID: 471
		[Token(Token = "0x40001D7")]
		[FieldOffset(Offset = "0x8")]
		public float fadeTime;
	}
}
