using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

// Token: 0x0200004E RID: 78
[Token(Token = "0x200004E")]
[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(Animator))]
public class SimpleAnimation : MonoBehaviour, IAnimationClipSource
{
	// Token: 0x1700000F RID: 15
	// (get) Token: 0x0600010A RID: 266 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700000F")]
	public Animator animator
	{
		[Token(Token = "0x600010A")]
		[Address(RVA = "0x15EE900", Offset = "0x15EE900", VA = "0x15EE900")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000010 RID: 16
	// (get) Token: 0x0600010B RID: 267 RVA: 0x000023E8 File Offset: 0x000005E8
	// (set) Token: 0x0600010C RID: 268 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000010")]
	public bool animatePhysics
	{
		[Token(Token = "0x600010B")]
		[Address(RVA = "0x15EE9A8", Offset = "0x15EE9A8", VA = "0x15EE9A8")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600010C")]
		[Address(RVA = "0x15EE9B0", Offset = "0x15EE9B0", VA = "0x15EE9B0")]
		set
		{
		}
	}

	// Token: 0x17000011 RID: 17
	// (get) Token: 0x0600010D RID: 269 RVA: 0x00002400 File Offset: 0x00000600
	// (set) Token: 0x0600010E RID: 270 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000011")]
	public AnimatorCullingMode cullingMode
	{
		[Token(Token = "0x600010D")]
		[Address(RVA = "0x15EE9DC", Offset = "0x15EE9DC", VA = "0x15EE9DC")]
		get
		{
			return default(AnimatorCullingMode);
		}
		[Token(Token = "0x600010E")]
		[Address(RVA = "0x15EE9F8", Offset = "0x15EE9F8", VA = "0x15EE9F8")]
		set
		{
		}
	}

	// Token: 0x17000012 RID: 18
	// (get) Token: 0x0600010F RID: 271 RVA: 0x00002418 File Offset: 0x00000618
	[Token(Token = "0x17000012")]
	public bool isPlaying
	{
		[Token(Token = "0x600010F")]
		[Address(RVA = "0x15EEA20", Offset = "0x15EEA20", VA = "0x15EEA20")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000013 RID: 19
	// (get) Token: 0x06000110 RID: 272 RVA: 0x00002430 File Offset: 0x00000630
	// (set) Token: 0x06000111 RID: 273 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000013")]
	public bool playAutomatically
	{
		[Token(Token = "0x6000110")]
		[Address(RVA = "0x15EEA60", Offset = "0x15EEA60", VA = "0x15EEA60")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000111")]
		[Address(RVA = "0x15EEA68", Offset = "0x15EEA68", VA = "0x15EEA68")]
		set
		{
		}
	}

	// Token: 0x17000014 RID: 20
	// (get) Token: 0x06000112 RID: 274 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000113 RID: 275 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000014")]
	public AnimationClip clip
	{
		[Token(Token = "0x6000112")]
		[Address(RVA = "0x15EEA74", Offset = "0x15EEA74", VA = "0x15EEA74")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000113")]
		[Address(RVA = "0x15EEA7C", Offset = "0x15EEA7C", VA = "0x15EEA7C")]
		set
		{
		}
	}

	// Token: 0x17000015 RID: 21
	// (get) Token: 0x06000114 RID: 276 RVA: 0x00002448 File Offset: 0x00000648
	// (set) Token: 0x06000115 RID: 277 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000015")]
	public WrapMode wrapMode
	{
		[Token(Token = "0x6000114")]
		[Address(RVA = "0x15EEB80", Offset = "0x15EEB80", VA = "0x15EEB80")]
		get
		{
			return default(WrapMode);
		}
		[Token(Token = "0x6000115")]
		[Address(RVA = "0x15EEB88", Offset = "0x15EEB88", VA = "0x15EEB88")]
		set
		{
		}
	}

	// Token: 0x06000116 RID: 278 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000116")]
	[Address(RVA = "0x15EEB90", Offset = "0x15EEB90", VA = "0x15EEB90")]
	public void AddClip(AnimationClip clip, string newName)
	{
	}

	// Token: 0x06000117 RID: 279 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000117")]
	[Address(RVA = "0x15EEC34", Offset = "0x15EEC34", VA = "0x15EEC34")]
	public void Blend(string stateName, float targetWeight, float fadeLength)
	{
	}

	// Token: 0x06000118 RID: 280 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000118")]
	[Address(RVA = "0x15EED24", Offset = "0x15EED24", VA = "0x15EED24")]
	public void CrossFade(string stateName, float fadeLength)
	{
	}

	// Token: 0x06000119 RID: 281 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000119")]
	[Address(RVA = "0x15EEDE8", Offset = "0x15EEDE8", VA = "0x15EEDE8")]
	public void CrossFadeQueued(string stateName, float fadeLength, QueueMode queueMode)
	{
	}

	// Token: 0x0600011A RID: 282 RVA: 0x00002460 File Offset: 0x00000660
	[Token(Token = "0x600011A")]
	[Address(RVA = "0x15EEEBC", Offset = "0x15EEEBC", VA = "0x15EEEBC")]
	public int GetClipCount()
	{
		return 0;
	}

	// Token: 0x0600011B RID: 283 RVA: 0x00002478 File Offset: 0x00000678
	[Token(Token = "0x600011B")]
	[Address(RVA = "0x15EEF48", Offset = "0x15EEF48", VA = "0x15EEF48")]
	public bool IsPlaying(string stateName)
	{
		return default(bool);
	}

	// Token: 0x0600011C RID: 284 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600011C")]
	[Address(RVA = "0x15EEFB8", Offset = "0x15EEFB8", VA = "0x15EEFB8")]
	public void Stop()
	{
	}

	// Token: 0x0600011D RID: 285 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600011D")]
	[Address(RVA = "0x15EF068", Offset = "0x15EF068", VA = "0x15EF068")]
	public void Stop(string stateName)
	{
	}

	// Token: 0x0600011E RID: 286 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600011E")]
	[Address(RVA = "0x15EF0D0", Offset = "0x15EF0D0", VA = "0x15EF0D0")]
	public void Sample()
	{
	}

	// Token: 0x0600011F RID: 287 RVA: 0x00002490 File Offset: 0x00000690
	[Token(Token = "0x600011F")]
	[Address(RVA = "0x15EF0DC", Offset = "0x15EF0DC", VA = "0x15EF0DC")]
	public bool Play()
	{
		return default(bool);
	}

	// Token: 0x06000120 RID: 288 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000120")]
	[Address(RVA = "0x15EEBC4", Offset = "0x15EEBC4", VA = "0x15EEBC4")]
	public void AddState(AnimationClip clip, string name)
	{
	}

	// Token: 0x06000121 RID: 289 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000121")]
	[Address(RVA = "0x15EF7E8", Offset = "0x15EF7E8", VA = "0x15EF7E8")]
	public void RemoveState(string name)
	{
	}

	// Token: 0x06000122 RID: 290 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000122")]
	[Address(RVA = "0x15EF8FC", Offset = "0x15EF8FC", VA = "0x15EF8FC")]
	public void SetStateSpeed(string aniName, float speed)
	{
	}

	// Token: 0x06000123 RID: 291 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000123")]
	[Address(RVA = "0x15EFA5C", Offset = "0x15EFA5C", VA = "0x15EFA5C")]
	public string GetRootPath()
	{
		return null;
	}

	// Token: 0x06000124 RID: 292 RVA: 0x000024A8 File Offset: 0x000006A8
	[Token(Token = "0x6000124")]
	[Address(RVA = "0x15EFB44", Offset = "0x15EFB44", VA = "0x15EFB44")]
	public bool Play(string stateName)
	{
		return default(bool);
	}

	// Token: 0x06000125 RID: 293 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000125")]
	[Address(RVA = "0x15EFBB8", Offset = "0x15EFBB8", VA = "0x15EFBB8")]
	public void PlayQueued(string stateName, QueueMode queueMode = 0)
	{
	}

	// Token: 0x06000126 RID: 294 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000126")]
	[Address(RVA = "0x15EFC84", Offset = "0x15EFC84", VA = "0x15EFC84")]
	public void RemoveClip(AnimationClip clip)
	{
	}

	// Token: 0x06000127 RID: 295 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000127")]
	[Address(RVA = "0x15EFD98", Offset = "0x15EFD98", VA = "0x15EFD98")]
	public void Rewind()
	{
	}

	// Token: 0x06000128 RID: 296 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000128")]
	[Address(RVA = "0x15EFE48", Offset = "0x15EFE48", VA = "0x15EFE48")]
	public void Rewind(string stateName)
	{
	}

	// Token: 0x06000129 RID: 297 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000129")]
	[Address(RVA = "0x15EF9CC", Offset = "0x15EF9CC", VA = "0x15EF9CC")]
	public SimpleAnimation.State GetState(string stateName)
	{
		return null;
	}

	// Token: 0x0600012A RID: 298 RVA: 0x000024C0 File Offset: 0x000006C0
	[Token(Token = "0x600012A")]
	[Address(RVA = "0x15EFFC4", Offset = "0x15EFFC4", VA = "0x15EFFC4")]
	public bool HasState(string stateName)
	{
		return default(bool);
	}

	// Token: 0x0600012B RID: 299 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600012B")]
	[Address(RVA = "0x15EFFF8", Offset = "0x15EFFF8", VA = "0x15EFFF8")]
	public IEnumerable<SimpleAnimation.State> GetStates()
	{
		return null;
	}

	// Token: 0x17000016 RID: 22
	[Token(Token = "0x17000016")]
	public SimpleAnimation.State this[string name]
	{
		[Token(Token = "0x600012C")]
		[Address(RVA = "0x15F0098", Offset = "0x15F0098", VA = "0x15F0098")]
		get
		{
			return null;
		}
	}

	// Token: 0x0600012D RID: 301 RVA: 0x000024D8 File Offset: 0x000006D8
	[Token(Token = "0x600012D")]
	[Address(RVA = "0x15F009C", Offset = "0x15F009C", VA = "0x15F009C")]
	public float GetClipLength(string stateName)
	{
		return 0f;
	}

	// Token: 0x0600012E RID: 302 RVA: 0x000024F0 File Offset: 0x000006F0
	[Token(Token = "0x600012E")]
	[Address(RVA = "0x15F01C8", Offset = "0x15F01C8", VA = "0x15F01C8")]
	public float GetClipTime(string stateName)
	{
		return 0f;
	}

	// Token: 0x0600012F RID: 303 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600012F")]
	[Address(RVA = "0x15F02F4", Offset = "0x15F02F4", VA = "0x15F02F4")]
	public void Pause()
	{
	}

	// Token: 0x06000130 RID: 304 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000130")]
	[Address(RVA = "0x15F0354", Offset = "0x15F0354", VA = "0x15F0354")]
	public void Resume()
	{
	}

	// Token: 0x06000131 RID: 305 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000131")]
	[Address(RVA = "0x15F03A8", Offset = "0x15F03A8", VA = "0x15F03A8")]
	public void SetStateTime(string stateName, float time)
	{
	}

	// Token: 0x06000132 RID: 306 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000132")]
	[Address(RVA = "0x15EECA8", Offset = "0x15EECA8", VA = "0x15EECA8")]
	protected void Kick()
	{
	}

	// Token: 0x06000133 RID: 307 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000133")]
	[Address(RVA = "0x15F0478", Offset = "0x15F0478", VA = "0x15F0478", Slot = "4")]
	protected virtual void OnEnable()
	{
	}

	// Token: 0x06000134 RID: 308 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000134")]
	[Address(RVA = "0x15F08C0", Offset = "0x15F08C0", VA = "0x15F08C0", Slot = "5")]
	protected virtual void OnDisable()
	{
	}

	// Token: 0x06000135 RID: 309 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000135")]
	[Address(RVA = "0x15F08EC", Offset = "0x15F08EC", VA = "0x15F08EC")]
	private void Reset()
	{
	}

	// Token: 0x06000136 RID: 310 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000136")]
	[Address(RVA = "0x15F04B4", Offset = "0x15F04B4", VA = "0x15F04B4")]
	private void Initialize()
	{
	}

	// Token: 0x06000137 RID: 311 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000137")]
	[Address(RVA = "0x15F09FC", Offset = "0x15F09FC", VA = "0x15F09FC")]
	private void EnsureDefaultStateExists()
	{
	}

	// Token: 0x06000138 RID: 312 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000138")]
	[Address(RVA = "0x15F0AC8", Offset = "0x15F0AC8", VA = "0x15F0AC8", Slot = "6")]
	protected virtual void Awake()
	{
	}

	// Token: 0x06000139 RID: 313 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000139")]
	[Address(RVA = "0x15F0ACC", Offset = "0x15F0ACC", VA = "0x15F0ACC")]
	protected void OnDestroy()
	{
	}

	// Token: 0x0600013A RID: 314 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600013A")]
	[Address(RVA = "0x15F0AFC", Offset = "0x15F0AFC", VA = "0x15F0AFC")]
	private void OnPlayableDone()
	{
	}

	// Token: 0x0600013B RID: 315 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600013B")]
	[Address(RVA = "0x15EF2D4", Offset = "0x15EF2D4", VA = "0x15EF2D4")]
	private void RebuildStates()
	{
	}

	// Token: 0x0600013C RID: 316 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600013C")]
	[Address(RVA = "0x15F0B1C", Offset = "0x15F0B1C", VA = "0x15F0B1C")]
	private SimpleAnimation.EditorState CreateDefaultEditorState()
	{
		return null;
	}

	// Token: 0x0600013D RID: 317 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600013D")]
	[Address(RVA = "0x15EEAAC", Offset = "0x15EEAAC", VA = "0x15EEAAC")]
	private static void LegacyClipCheck(AnimationClip clip)
	{
	}

	// Token: 0x0600013E RID: 318 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600013E")]
	[Address(RVA = "0x15F0BB8", Offset = "0x15F0BB8", VA = "0x15F0BB8")]
	private void InvalidLegacyClipError(string clipName, string stateName)
	{
	}

	// Token: 0x0600013F RID: 319 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600013F")]
	[Address(RVA = "0x15F0CF0", Offset = "0x15F0CF0", VA = "0x15F0CF0")]
	private void OnValidate()
	{
	}

	// Token: 0x06000140 RID: 320 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000140")]
	[Address(RVA = "0x15F13CC", Offset = "0x15F13CC", VA = "0x15F13CC", Slot = "7")]
	public void GetAnimationClips(List<AnimationClip> results)
	{
	}

	// Token: 0x06000141 RID: 321 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000141")]
	[Address(RVA = "0x15F1500", Offset = "0x15F1500", VA = "0x15F1500")]
	public SimpleAnimation()
	{
	}

	// Token: 0x0400019B RID: 411
	[Token(Token = "0x400019B")]
	private const string kDefaultStateName = "Default";

	// Token: 0x0400019C RID: 412
	[Token(Token = "0x400019C")]
	[FieldOffset(Offset = "0x18")]
	protected PlayableGraph m_Graph;

	// Token: 0x0400019D RID: 413
	[Token(Token = "0x400019D")]
	[FieldOffset(Offset = "0x28")]
	protected PlayableHandle m_LayerMixer;

	// Token: 0x0400019E RID: 414
	[Token(Token = "0x400019E")]
	[FieldOffset(Offset = "0x38")]
	protected PlayableHandle m_TransitionMixer;

	// Token: 0x0400019F RID: 415
	[Token(Token = "0x400019F")]
	[FieldOffset(Offset = "0x48")]
	protected Animator m_Animator;

	// Token: 0x040001A0 RID: 416
	[Token(Token = "0x40001A0")]
	[FieldOffset(Offset = "0x50")]
	protected bool m_Initialized;

	// Token: 0x040001A1 RID: 417
	[Token(Token = "0x40001A1")]
	[FieldOffset(Offset = "0x51")]
	protected bool m_IsPlaying;

	// Token: 0x040001A2 RID: 418
	[Token(Token = "0x40001A2")]
	[FieldOffset(Offset = "0x58")]
	protected SimpleAnimationPlayable m_Playable;

	// Token: 0x040001A3 RID: 419
	[Token(Token = "0x40001A3")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	protected bool m_PlayAutomatically;

	// Token: 0x040001A4 RID: 420
	[Token(Token = "0x40001A4")]
	[FieldOffset(Offset = "0x61")]
	[SerializeField]
	protected bool m_AnimatePhysics;

	// Token: 0x040001A5 RID: 421
	[Token(Token = "0x40001A5")]
	[FieldOffset(Offset = "0x64")]
	[SerializeField]
	protected AnimatorCullingMode m_CullingMode;

	// Token: 0x040001A6 RID: 422
	[Token(Token = "0x40001A6")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	protected WrapMode m_WrapMode;

	// Token: 0x040001A7 RID: 423
	[Token(Token = "0x40001A7")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	protected AnimationClip m_Clip;

	// Token: 0x040001A8 RID: 424
	[Token(Token = "0x40001A8")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private SimpleAnimation.EditorState[] m_States;

	// Token: 0x0200004F RID: 79
	[Token(Token = "0x200004F")]
	public interface State
	{
		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000142 RID: 322
		// (set) Token: 0x06000143 RID: 323
		[Token(Token = "0x17000017")]
		bool enabled
		{
			[Token(Token = "0x6000142")]
			get;
			[Token(Token = "0x6000143")]
			set;
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000144 RID: 324
		[Token(Token = "0x17000018")]
		bool isValid
		{
			[Token(Token = "0x6000144")]
			get;
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000145 RID: 325
		// (set) Token: 0x06000146 RID: 326
		[Token(Token = "0x17000019")]
		float time
		{
			[Token(Token = "0x6000145")]
			get;
			[Token(Token = "0x6000146")]
			set;
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000147 RID: 327
		// (set) Token: 0x06000148 RID: 328
		[Token(Token = "0x1700001A")]
		float normalizedTime
		{
			[Token(Token = "0x6000147")]
			get;
			[Token(Token = "0x6000148")]
			set;
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000149 RID: 329
		// (set) Token: 0x0600014A RID: 330
		[Token(Token = "0x1700001B")]
		float speed
		{
			[Token(Token = "0x6000149")]
			get;
			[Token(Token = "0x600014A")]
			set;
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600014B RID: 331
		// (set) Token: 0x0600014C RID: 332
		[Token(Token = "0x1700001C")]
		string name
		{
			[Token(Token = "0x600014B")]
			get;
			[Token(Token = "0x600014C")]
			set;
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600014D RID: 333
		// (set) Token: 0x0600014E RID: 334
		[Token(Token = "0x1700001D")]
		float weight
		{
			[Token(Token = "0x600014D")]
			get;
			[Token(Token = "0x600014E")]
			set;
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600014F RID: 335
		[Token(Token = "0x1700001E")]
		float length
		{
			[Token(Token = "0x600014F")]
			get;
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000150 RID: 336
		[Token(Token = "0x1700001F")]
		AnimationClip clip
		{
			[Token(Token = "0x6000150")]
			get;
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000151 RID: 337
		// (set) Token: 0x06000152 RID: 338
		[Token(Token = "0x17000020")]
		WrapMode wrapMode
		{
			[Token(Token = "0x6000151")]
			get;
			[Token(Token = "0x6000152")]
			set;
		}
	}

	// Token: 0x02000050 RID: 80
	[Token(Token = "0x2000050")]
	private class StateEnumerable : IEnumerable<SimpleAnimation.State>, IEnumerable
	{
		// Token: 0x06000153 RID: 339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000153")]
		[Address(RVA = "0x15F0068", Offset = "0x15F0068", VA = "0x15F0068")]
		public StateEnumerable(SimpleAnimation owner)
		{
		}

		// Token: 0x06000154 RID: 340 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000154")]
		[Address(RVA = "0x15F1510", Offset = "0x15F1510", VA = "0x15F1510", Slot = "4")]
		public IEnumerator<SimpleAnimation.State> GetEnumerator()
		{
			return null;
		}

		// Token: 0x06000155 RID: 341 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000155")]
		[Address(RVA = "0x15F1664", Offset = "0x15F1664", VA = "0x15F1664", Slot = "5")]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}

		// Token: 0x040001A9 RID: 425
		[Token(Token = "0x40001A9")]
		[FieldOffset(Offset = "0x10")]
		private SimpleAnimation m_Owner;

		// Token: 0x02000051 RID: 81
		[Token(Token = "0x2000051")]
		private class StateEnumerator : IEnumerator<SimpleAnimation.State>, IEnumerator, IDisposable
		{
			// Token: 0x06000156 RID: 342 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000156")]
			[Address(RVA = "0x15F1574", Offset = "0x15F1574", VA = "0x15F1574")]
			public StateEnumerator(SimpleAnimation owner)
			{
			}

			// Token: 0x06000157 RID: 343 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000157")]
			[Address(RVA = "0x15F17D0", Offset = "0x15F17D0", VA = "0x15F17D0")]
			private SimpleAnimation.State GetCurrent()
			{
				return null;
			}

			// Token: 0x17000021 RID: 33
			// (get) Token: 0x06000158 RID: 344 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000021")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000158")]
				[Address(RVA = "0x15F18B4", Offset = "0x15F18B4", VA = "0x15F18B4", Slot = "7")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000022 RID: 34
			// (get) Token: 0x06000159 RID: 345 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000022")]
			private SimpleAnimation.State System.Collections.Generic.IEnumerator<SimpleAnimation.State>.Current
			{
				[Token(Token = "0x6000159")]
				[Address(RVA = "0x15F18B8", Offset = "0x15F18B8", VA = "0x15F18B8", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x0600015A RID: 346 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600015A")]
			[Address(RVA = "0x15F18BC", Offset = "0x15F18BC", VA = "0x15F18BC", Slot = "5")]
			public void Dispose()
			{
			}

			// Token: 0x0600015B RID: 347 RVA: 0x00002508 File Offset: 0x00000708
			[Token(Token = "0x600015B")]
			[Address(RVA = "0x15F18C0", Offset = "0x15F18C0", VA = "0x15F18C0", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x0600015C RID: 348 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600015C")]
			[Address(RVA = "0x15F172C", Offset = "0x15F172C", VA = "0x15F172C", Slot = "8")]
			public void Reset()
			{
			}

			// Token: 0x040001AA RID: 426
			[Token(Token = "0x40001AA")]
			[FieldOffset(Offset = "0x10")]
			private SimpleAnimation m_Owner;

			// Token: 0x040001AB RID: 427
			[Token(Token = "0x40001AB")]
			[FieldOffset(Offset = "0x18")]
			private IEnumerator<SimpleAnimationPlayable.IState> m_Impl;
		}
	}

	// Token: 0x02000052 RID: 82
	[Token(Token = "0x2000052")]
	private class StateImpl : SimpleAnimation.State
	{
		// Token: 0x0600015D RID: 349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600015D")]
		[Address(RVA = "0x15EFF80", Offset = "0x15EFF80", VA = "0x15EFF80")]
		public StateImpl(SimpleAnimationPlayable.IState handle, SimpleAnimation component)
		{
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x0600015E RID: 350 RVA: 0x00002520 File Offset: 0x00000720
		// (set) Token: 0x0600015F RID: 351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000023")]
		private bool SimpleAnimation.State.enabled
		{
			[Token(Token = "0x600015E")]
			[Address(RVA = "0x15F1960", Offset = "0x15F1960", VA = "0x15F1960", Slot = "4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600015F")]
			[Address(RVA = "0x15F1A04", Offset = "0x15F1A04", VA = "0x15F1A04", Slot = "5")]
			set
			{
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000160 RID: 352 RVA: 0x00002538 File Offset: 0x00000738
		[Token(Token = "0x17000024")]
		private bool SimpleAnimation.State.isValid
		{
			[Token(Token = "0x6000160")]
			[Address(RVA = "0x15F1ADC", Offset = "0x15F1ADC", VA = "0x15F1ADC", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000161 RID: 353 RVA: 0x00002550 File Offset: 0x00000750
		// (set) Token: 0x06000162 RID: 354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000025")]
		private float SimpleAnimation.State.time
		{
			[Token(Token = "0x6000161")]
			[Address(RVA = "0x15F1B7C", Offset = "0x15F1B7C", VA = "0x15F1B7C", Slot = "7")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000162")]
			[Address(RVA = "0x15F1C20", Offset = "0x15F1C20", VA = "0x15F1C20", Slot = "8")]
			set
			{
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000163 RID: 355 RVA: 0x00002568 File Offset: 0x00000768
		// (set) Token: 0x06000164 RID: 356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000026")]
		private float SimpleAnimation.State.normalizedTime
		{
			[Token(Token = "0x6000163")]
			[Address(RVA = "0x15F1CFC", Offset = "0x15F1CFC", VA = "0x15F1CFC", Slot = "9")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000164")]
			[Address(RVA = "0x15F1DA0", Offset = "0x15F1DA0", VA = "0x15F1DA0", Slot = "10")]
			set
			{
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000165 RID: 357 RVA: 0x00002580 File Offset: 0x00000780
		// (set) Token: 0x06000166 RID: 358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000027")]
		private float SimpleAnimation.State.speed
		{
			[Token(Token = "0x6000165")]
			[Address(RVA = "0x15F1E7C", Offset = "0x15F1E7C", VA = "0x15F1E7C", Slot = "11")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000166")]
			[Address(RVA = "0x15F1F20", Offset = "0x15F1F20", VA = "0x15F1F20", Slot = "12")]
			set
			{
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000167 RID: 359 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000168 RID: 360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000028")]
		private string SimpleAnimation.State.name
		{
			[Token(Token = "0x6000167")]
			[Address(RVA = "0x15F1FFC", Offset = "0x15F1FFC", VA = "0x15F1FFC", Slot = "13")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000168")]
			[Address(RVA = "0x15F20A0", Offset = "0x15F20A0", VA = "0x15F20A0", Slot = "14")]
			set
			{
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000169 RID: 361 RVA: 0x00002598 File Offset: 0x00000798
		// (set) Token: 0x0600016A RID: 362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000029")]
		private float SimpleAnimation.State.weight
		{
			[Token(Token = "0x6000169")]
			[Address(RVA = "0x15F214C", Offset = "0x15F214C", VA = "0x15F214C", Slot = "15")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600016A")]
			[Address(RVA = "0x15F21F0", Offset = "0x15F21F0", VA = "0x15F21F0", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x0600016B RID: 363 RVA: 0x000025B0 File Offset: 0x000007B0
		[Token(Token = "0x1700002A")]
		private float SimpleAnimation.State.length
		{
			[Token(Token = "0x600016B")]
			[Address(RVA = "0x15F22CC", Offset = "0x15F22CC", VA = "0x15F22CC", Slot = "17")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x0600016C RID: 364 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700002B")]
		private AnimationClip SimpleAnimation.State.clip
		{
			[Token(Token = "0x600016C")]
			[Address(RVA = "0x15F2370", Offset = "0x15F2370", VA = "0x15F2370", Slot = "18")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x0600016D RID: 365 RVA: 0x000025C8 File Offset: 0x000007C8
		// (set) Token: 0x0600016E RID: 366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700002C")]
		private WrapMode SimpleAnimation.State.wrapMode
		{
			[Token(Token = "0x600016D")]
			[Address(RVA = "0x15F2414", Offset = "0x15F2414", VA = "0x15F2414", Slot = "19")]
			get
			{
				return default(WrapMode);
			}
			[Token(Token = "0x600016E")]
			[Address(RVA = "0x15F24B8", Offset = "0x15F24B8", VA = "0x15F24B8", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x040001AC RID: 428
		[Token(Token = "0x40001AC")]
		[FieldOffset(Offset = "0x10")]
		private SimpleAnimationPlayable.IState m_StateHandle;

		// Token: 0x040001AD RID: 429
		[Token(Token = "0x40001AD")]
		[FieldOffset(Offset = "0x18")]
		private SimpleAnimation m_Component;
	}

	// Token: 0x02000053 RID: 83
	[Token(Token = "0x2000053")]
	[Serializable]
	public class EditorState
	{
		// Token: 0x0600016F RID: 367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600016F")]
		[Address(RVA = "0x15F09F4", Offset = "0x15F09F4", VA = "0x15F09F4")]
		public EditorState()
		{
		}

		// Token: 0x040001AE RID: 430
		[Token(Token = "0x40001AE")]
		[FieldOffset(Offset = "0x10")]
		public AnimationClip clip;

		// Token: 0x040001AF RID: 431
		[Token(Token = "0x40001AF")]
		[FieldOffset(Offset = "0x18")]
		public string name;

		// Token: 0x040001B0 RID: 432
		[Token(Token = "0x40001B0")]
		[FieldOffset(Offset = "0x20")]
		public bool defaultState;
	}
}
