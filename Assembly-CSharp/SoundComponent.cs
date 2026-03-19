using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using VEngine;

// Token: 0x020001E2 RID: 482
[Token(Token = "0x20001E2")]
public sealed class SoundComponent
{
	// Token: 0x17000196 RID: 406
	// (get) Token: 0x06000CF7 RID: 3319 RVA: 0x00005E20 File Offset: 0x00004020
	[Token(Token = "0x17000196")]
	public int SoundGroupCount
	{
		[Token(Token = "0x6000CF7")]
		[Address(RVA = "0x12CDDE8", Offset = "0x12CDDE8", VA = "0x12CDDE8")]
		get
		{
			return 0;
		}
	}

	// Token: 0x06000CF8 RID: 3320 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CF8")]
	[Address(RVA = "0x12CDE38", Offset = "0x12CDE38", VA = "0x12CDE38")]
	public SoundComponent()
	{
	}

	// Token: 0x06000CF9 RID: 3321 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CF9")]
	[Address(RVA = "0x12CE214", Offset = "0x12CE214", VA = "0x12CE214")]
	public void ShutDown()
	{
	}

	// Token: 0x06000CFA RID: 3322 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CFA")]
	[Address(RVA = "0x12CE538", Offset = "0x12CE538", VA = "0x12CE538")]
	public void SetAudioListenerPosition(float x, float y, float z)
	{
	}

	// Token: 0x06000CFB RID: 3323 RVA: 0x00005E38 File Offset: 0x00004038
	[Token(Token = "0x6000CFB")]
	[Address(RVA = "0x12CE5EC", Offset = "0x12CE5EC", VA = "0x12CE5EC")]
	public int Play3DSoundAtGO(GameObject go, string name)
	{
		return 0;
	}

	// Token: 0x06000CFC RID: 3324 RVA: 0x00005E50 File Offset: 0x00004050
	[Token(Token = "0x6000CFC")]
	[Address(RVA = "0x12CE8EC", Offset = "0x12CE8EC", VA = "0x12CE8EC")]
	public int Stop3DSoundAtGO(GameObject go)
	{
		return 0;
	}

	// Token: 0x06000CFD RID: 3325 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CFD")]
	[Address(RVA = "0x12CEB94", Offset = "0x12CEB94", VA = "0x12CEB94")]
	public void Remove3DSoundAll()
	{
	}

	// Token: 0x06000CFE RID: 3326 RVA: 0x00005E68 File Offset: 0x00004068
	[Token(Token = "0x6000CFE")]
	[Address(RVA = "0x12CEDB4", Offset = "0x12CEDB4", VA = "0x12CEDB4")]
	public bool HasSoundGroup(string soundGroupName)
	{
		return default(bool);
	}

	// Token: 0x06000CFF RID: 3327 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CFF")]
	[Address(RVA = "0x12CEE0C", Offset = "0x12CEE0C", VA = "0x12CEE0C")]
	public void SetSoundGroupMute(string soundGroupName, bool mute)
	{
	}

	// Token: 0x06000D00 RID: 3328 RVA: 0x00005E80 File Offset: 0x00004080
	[Token(Token = "0x6000D00")]
	[Address(RVA = "0x12CEED4", Offset = "0x12CEED4", VA = "0x12CEED4")]
	public int PlaySound(string soundAssetName, string soundGroupName, [Optional] Action<bool, int> action, bool loop = false, float volume = 1f)
	{
		return 0;
	}

	// Token: 0x06000D01 RID: 3329 RVA: 0x00005E98 File Offset: 0x00004098
	[Token(Token = "0x6000D01")]
	[Address(RVA = "0x12CF348", Offset = "0x12CF348", VA = "0x12CF348")]
	public int PlayMusic(string name, bool loop = true, float volume = 1f)
	{
		return 0;
	}

	// Token: 0x06000D02 RID: 3330 RVA: 0x00005EB0 File Offset: 0x000040B0
	[Token(Token = "0x6000D02")]
	[Address(RVA = "0x12CF448", Offset = "0x12CF448", VA = "0x12CF448")]
	public float GetSoundLength(int serialId)
	{
		return 0f;
	}

	// Token: 0x06000D03 RID: 3331 RVA: 0x00005EC8 File Offset: 0x000040C8
	[Token(Token = "0x6000D03")]
	[Address(RVA = "0x12CF6B0", Offset = "0x12CF6B0", VA = "0x12CF6B0")]
	public int PlayEffect(string name, bool loop = false, float volume = 1f, [Optional] string specifiedGroup)
	{
		return 0;
	}

	// Token: 0x06000D04 RID: 3332 RVA: 0x00005EE0 File Offset: 0x000040E0
	[Token(Token = "0x6000D04")]
	[Address(RVA = "0x12CF9DC", Offset = "0x12CF9DC", VA = "0x12CF9DC")]
	public int Play3DEffect(string name, Vector3 pos, float volume = 1f)
	{
		return 0;
	}

	// Token: 0x06000D05 RID: 3333 RVA: 0x00005EF8 File Offset: 0x000040F8
	[Token(Token = "0x6000D05")]
	[Address(RVA = "0x12CFCD0", Offset = "0x12CFCD0", VA = "0x12CFCD0")]
	public int PlayDub(int nameId, [Optional] Action<bool, int> action)
	{
		return 0;
	}

	// Token: 0x06000D06 RID: 3334 RVA: 0x00005F10 File Offset: 0x00004110
	[Token(Token = "0x6000D06")]
	[Address(RVA = "0x12CFD0C", Offset = "0x12CFD0C", VA = "0x12CFD0C")]
	public int PlayDub(string name, [Optional] Action<bool, int> action)
	{
		return 0;
	}

	// Token: 0x06000D07 RID: 3335 RVA: 0x00005F28 File Offset: 0x00004128
	[Token(Token = "0x6000D07")]
	[Address(RVA = "0x12CFECC", Offset = "0x12CFECC", VA = "0x12CFECC")]
	public int PlayBGMusicByName(string nameStr, float volume = 1f, bool isLoop = true)
	{
		return 0;
	}

	// Token: 0x06000D08 RID: 3336 RVA: 0x00005F40 File Offset: 0x00004140
	[Token(Token = "0x6000D08")]
	[Address(RVA = "0x12D0154", Offset = "0x12D0154", VA = "0x12D0154")]
	public int PlayWorldScopeEffect(string name, bool loop = false, float volume = 1f)
	{
		return 0;
	}

	// Token: 0x06000D09 RID: 3337 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D09")]
	[Address(RVA = "0x12D03DC", Offset = "0x12D03DC", VA = "0x12D03DC")]
	public string GetCurPlayMusicName()
	{
		return null;
	}

	// Token: 0x06000D0A RID: 3338 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D0A")]
	[Address(RVA = "0x12D04C0", Offset = "0x12D04C0", VA = "0x12D04C0")]
	public void OnUpdate(float elapseSeconds)
	{
	}

	// Token: 0x06000D0B RID: 3339 RVA: 0x00005F58 File Offset: 0x00004158
	[Token(Token = "0x6000D0B")]
	[Address(RVA = "0x12CFF3C", Offset = "0x12CFF3C", VA = "0x12CFF3C")]
	public bool StopSound(int serialId)
	{
		return default(bool);
	}

	// Token: 0x06000D0C RID: 3340 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D0C")]
	[Address(RVA = "0x12D08B4", Offset = "0x12D08B4", VA = "0x12D08B4")]
	public void StopGroupSound(string soundGroupName)
	{
	}

	// Token: 0x06000D0D RID: 3341 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D0D")]
	[Address(RVA = "0x12D09B8", Offset = "0x12D09B8", VA = "0x12D09B8")]
	public void StopAllSoundsWithoutMusicGroup()
	{
	}

	// Token: 0x06000D0E RID: 3342 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D0E")]
	[Address(RVA = "0x12CE218", Offset = "0x12CE218", VA = "0x12CE218")]
	public void StopAllSounds()
	{
	}

	// Token: 0x06000D0F RID: 3343 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D0F")]
	[Address(RVA = "0x12D0C00", Offset = "0x12D0C00", VA = "0x12D0C00")]
	public void PauseSound(int serialId)
	{
	}

	// Token: 0x06000D10 RID: 3344 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D10")]
	[Address(RVA = "0x12D0E1C", Offset = "0x12D0E1C", VA = "0x12D0E1C")]
	public void ResumeSound(int serialId)
	{
	}

	// Token: 0x06000D11 RID: 3345 RVA: 0x00005F70 File Offset: 0x00004170
	[Token(Token = "0x6000D11")]
	[Address(RVA = "0x12D1038", Offset = "0x12D1038", VA = "0x12D1038")]
	public bool IsAllSoundPause()
	{
		return default(bool);
	}

	// Token: 0x06000D12 RID: 3346 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D12")]
	[Address(RVA = "0x12D1040", Offset = "0x12D1040", VA = "0x12D1040")]
	public void PauseAllSound()
	{
	}

	// Token: 0x06000D13 RID: 3347 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D13")]
	[Address(RVA = "0x12D11FC", Offset = "0x12D11FC", VA = "0x12D11FC")]
	public void ResumeAllSound()
	{
	}

	// Token: 0x06000D14 RID: 3348 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D14")]
	[Address(RVA = "0x12D13B4", Offset = "0x12D13B4", VA = "0x12D13B4")]
	public void MuteAllSounds(bool mute)
	{
	}

	// Token: 0x06000D15 RID: 3349 RVA: 0x00005F88 File Offset: 0x00004188
	[Token(Token = "0x6000D15")]
	[Address(RVA = "0x12D157C", Offset = "0x12D157C", VA = "0x12D157C")]
	public bool IsAllSoundMute()
	{
		return default(bool);
	}

	// Token: 0x06000D16 RID: 3350 RVA: 0x00005FA0 File Offset: 0x000041A0
	[Token(Token = "0x6000D16")]
	[Address(RVA = "0x12CE8C8", Offset = "0x12CE8C8", VA = "0x12CE8C8")]
	private int GetSerial()
	{
		return 0;
	}

	// Token: 0x06000D17 RID: 3351 RVA: 0x00005FB8 File Offset: 0x000041B8
	[Token(Token = "0x6000D17")]
	[Address(RVA = "0x12CEFC4", Offset = "0x12CEFC4", VA = "0x12CEFC4")]
	public int PlaySound(string soundAssetName, string soundGroupName, SoundComponent.PlaySoundParams playSoundParams, object userData, [Optional] Action<bool, int> action)
	{
		return 0;
	}

	// Token: 0x06000D18 RID: 3352 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D18")]
	[Address(RVA = "0x12CE9A0", Offset = "0x12CE9A0", VA = "0x12CE9A0")]
	private SoundComponent.ISoundGroup GetSoundGroup(string soundGroupName, bool soundGroupMute = false, float volume = 1f)
	{
		return null;
	}

	// Token: 0x06000D19 RID: 3353 RVA: 0x00005FD0 File Offset: 0x000041D0
	[Token(Token = "0x6000D19")]
	[Address(RVA = "0x12D172C", Offset = "0x12D172C", VA = "0x12D172C")]
	private bool LoadSoundSuccess(string soundAssetName, Asset soundAsset, Action<bool, int> action, object userData)
	{
		return default(bool);
	}

	// Token: 0x06000D1A RID: 3354 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D1A")]
	[Address(RVA = "0x12D1D18", Offset = "0x12D1D18", VA = "0x12D1D18")]
	private void LoadSoundFailure(string soundAssetName, Asset soundAsset, object userData)
	{
	}

	// Token: 0x06000D1B RID: 3355 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D1B")]
	[Address(RVA = "0x12D1E7C", Offset = "0x12D1E7C", VA = "0x12D1E7C")]
	public void ChangeGameVolume(string soundGroupName, float toVolume)
	{
	}

	// Token: 0x06000D1C RID: 3356 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D1C")]
	[Address(RVA = "0x12D1F58", Offset = "0x12D1F58", VA = "0x12D1F58")]
	public void ChangeVolume(string soundGroupName, float toVolume, float time)
	{
	}

	// Token: 0x06000D1D RID: 3357 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D1D")]
	[Address(RVA = "0x12D2088", Offset = "0x12D2088", VA = "0x12D2088")]
	public void ChangeVolumeExclude(string soundGroupName, float time, float toVolume = -1f)
	{
	}

	// Token: 0x06000D1E RID: 3358 RVA: 0x00005FE8 File Offset: 0x000041E8
	[Token(Token = "0x6000D1E")]
	[Address(RVA = "0x12D2294", Offset = "0x12D2294", VA = "0x12D2294")]
	public float GetClipLength(int serialId)
	{
		return 0f;
	}

	// Token: 0x06000D1F RID: 3359 RVA: 0x00006000 File Offset: 0x00004200
	[Token(Token = "0x6000D1F")]
	[Address(RVA = "0x12D2450", Offset = "0x12D2450", VA = "0x12D2450")]
	public int GetSoundStatus(int serialId)
	{
		return 0;
	}

	// Token: 0x04001096 RID: 4246
	[Token(Token = "0x4001096")]
	[FieldOffset(Offset = "0x10")]
	private AudioListener m_AudioListener;

	// Token: 0x04001097 RID: 4247
	[Token(Token = "0x4001097")]
	[FieldOffset(Offset = "0x18")]
	private Transform m_AudioListenerTrans;

	// Token: 0x04001098 RID: 4248
	[Token(Token = "0x4001098")]
	[FieldOffset(Offset = "0x20")]
	private Transform m_InstanceRoot;

	// Token: 0x04001099 RID: 4249
	[Token(Token = "0x4001099")]
	[FieldOffset(Offset = "0x28")]
	private readonly Dictionary<string, SoundComponent.ISoundGroup> m_SoundGroupDic;

	// Token: 0x0400109A RID: 4250
	[Token(Token = "0x400109A")]
	[FieldOffset(Offset = "0x30")]
	private Dictionary<string, string> m_nameToPath;

	// Token: 0x0400109B RID: 4251
	[Token(Token = "0x400109B")]
	[FieldOffset(Offset = "0x38")]
	private int m_Serial;

	// Token: 0x0400109C RID: 4252
	[Token(Token = "0x400109C")]
	[FieldOffset(Offset = "0x40")]
	private readonly Dictionary<int, Asset> m_SoundsBeingLoaded;

	// Token: 0x0400109D RID: 4253
	[Token(Token = "0x400109D")]
	[FieldOffset(Offset = "0x48")]
	private readonly HashSet<int> m_SoundsToReleaseOnLoad;

	// Token: 0x0400109E RID: 4254
	[Token(Token = "0x400109E")]
	[FieldOffset(Offset = "0x0")]
	private static string MusicGroup;

	// Token: 0x0400109F RID: 4255
	[Token(Token = "0x400109F")]
	[FieldOffset(Offset = "0x50")]
	private int _bgMusicId;

	// Token: 0x040010A0 RID: 4256
	[Token(Token = "0x40010A0")]
	[FieldOffset(Offset = "0x58")]
	private string _bgMusicName;

	// Token: 0x040010A1 RID: 4257
	[Token(Token = "0x40010A1")]
	[FieldOffset(Offset = "0x60")]
	private bool m_soundIsPause;

	// Token: 0x040010A2 RID: 4258
	[Token(Token = "0x40010A2")]
	[FieldOffset(Offset = "0x61")]
	private bool m_soundIsMute;

	// Token: 0x020001E3 RID: 483
	[Token(Token = "0x20001E3")]
	internal static class Constant
	{
		// Token: 0x040010A3 RID: 4259
		[Token(Token = "0x40010A3")]
		internal const float DefaultTime = 0f;

		// Token: 0x040010A4 RID: 4260
		[Token(Token = "0x40010A4")]
		internal const bool DefaultMute = false;

		// Token: 0x040010A5 RID: 4261
		[Token(Token = "0x40010A5")]
		internal const bool DefaultLoop = false;

		// Token: 0x040010A6 RID: 4262
		[Token(Token = "0x40010A6")]
		internal const int DefaultPriority = 0;

		// Token: 0x040010A7 RID: 4263
		[Token(Token = "0x40010A7")]
		internal const float DefaultVolume = 1f;

		// Token: 0x040010A8 RID: 4264
		[Token(Token = "0x40010A8")]
		internal const float DefaultFadeInSeconds = 0f;

		// Token: 0x040010A9 RID: 4265
		[Token(Token = "0x40010A9")]
		internal const float DefaultFadeOutSeconds = 0f;

		// Token: 0x040010AA RID: 4266
		[Token(Token = "0x40010AA")]
		internal const float DefaultPitch = 1f;

		// Token: 0x040010AB RID: 4267
		[Token(Token = "0x40010AB")]
		internal const float DefaultPanStereo = 0f;

		// Token: 0x040010AC RID: 4268
		[Token(Token = "0x40010AC")]
		internal const float DefaultSpatialBlend = 0f;

		// Token: 0x040010AD RID: 4269
		[Token(Token = "0x40010AD")]
		internal const float DefaultMaxDistance = 100f;

		// Token: 0x040010AE RID: 4270
		[Token(Token = "0x40010AE")]
		internal const float DefaultDopplerLevel = 1f;
	}

	// Token: 0x020001E4 RID: 484
	[Token(Token = "0x20001E4")]
	public sealed class PlaySoundParams
	{
		// Token: 0x06000D21 RID: 3361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D21")]
		[Address(RVA = "0x12CEFA0", Offset = "0x12CEFA0", VA = "0x12CEFA0")]
		public PlaySoundParams()
		{
		}

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x06000D22 RID: 3362 RVA: 0x00006018 File Offset: 0x00004218
		// (set) Token: 0x06000D23 RID: 3363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000197")]
		public bool Loop
		{
			[Token(Token = "0x6000D22")]
			[Address(RVA = "0x12D27E0", Offset = "0x12D27E0", VA = "0x12D27E0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000D23")]
			[Address(RVA = "0x12D27E8", Offset = "0x12D27E8", VA = "0x12D27E8")]
			set
			{
			}
		}

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x06000D24 RID: 3364 RVA: 0x00006030 File Offset: 0x00004230
		// (set) Token: 0x06000D25 RID: 3365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000198")]
		public float VolumeInSoundGroup
		{
			[Token(Token = "0x6000D24")]
			[Address(RVA = "0x12D27F4", Offset = "0x12D27F4", VA = "0x12D27F4")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000D25")]
			[Address(RVA = "0x12D27FC", Offset = "0x12D27FC", VA = "0x12D27FC")]
			set
			{
			}
		}

		// Token: 0x040010AF RID: 4271
		[Token(Token = "0x40010AF")]
		[FieldOffset(Offset = "0x10")]
		public int serialId;

		// Token: 0x040010B0 RID: 4272
		[Token(Token = "0x40010B0")]
		[FieldOffset(Offset = "0x14")]
		private bool m_Loop;

		// Token: 0x040010B1 RID: 4273
		[Token(Token = "0x40010B1")]
		[FieldOffset(Offset = "0x18")]
		private float m_VolumeInSoundGroup;
	}

	// Token: 0x020001E5 RID: 485
	[Token(Token = "0x20001E5")]
	internal sealed class PlaySoundInfo
	{
		// Token: 0x06000D26 RID: 3366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D26")]
		[Address(RVA = "0x12D2804", Offset = "0x12D2804", VA = "0x12D2804")]
		public PlaySoundInfo(int serialId, SoundComponent.SoundGroup soundGroup, SoundComponent.PlaySoundParams playSoundParams, object userData)
		{
		}

		// Token: 0x06000D27 RID: 3367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D27")]
		[Address(RVA = "0x12D286C", Offset = "0x12D286C", VA = "0x12D286C")]
		public PlaySoundInfo(Vector3 worldPosition, object userData)
		{
		}

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x06000D28 RID: 3368 RVA: 0x00006048 File Offset: 0x00004248
		[Token(Token = "0x17000199")]
		public Vector3 WorldPosition
		{
			[Token(Token = "0x6000D28")]
			[Address(RVA = "0x12D28C0", Offset = "0x12D28C0", VA = "0x12D28C0")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x06000D29 RID: 3369 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700019A")]
		public object UserData
		{
			[Token(Token = "0x6000D29")]
			[Address(RVA = "0x12D28CC", Offset = "0x12D28CC", VA = "0x12D28CC")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x06000D2A RID: 3370 RVA: 0x00006060 File Offset: 0x00004260
		[Token(Token = "0x1700019B")]
		public int SerialId
		{
			[Token(Token = "0x6000D2A")]
			[Address(RVA = "0x12D28D4", Offset = "0x12D28D4", VA = "0x12D28D4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x06000D2B RID: 3371 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700019C")]
		public SoundComponent.SoundGroup SoundGroup
		{
			[Token(Token = "0x6000D2B")]
			[Address(RVA = "0x12D28DC", Offset = "0x12D28DC", VA = "0x12D28DC")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x06000D2C RID: 3372 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700019D")]
		public SoundComponent.PlaySoundParams PlaySoundParams
		{
			[Token(Token = "0x6000D2C")]
			[Address(RVA = "0x12D28E4", Offset = "0x12D28E4", VA = "0x12D28E4")]
			get
			{
				return null;
			}
		}

		// Token: 0x040010B2 RID: 4274
		[Token(Token = "0x40010B2")]
		[FieldOffset(Offset = "0x10")]
		private readonly Vector3 m_WorldPosition;

		// Token: 0x040010B3 RID: 4275
		[Token(Token = "0x40010B3")]
		[FieldOffset(Offset = "0x20")]
		private readonly object m_UserData;

		// Token: 0x040010B4 RID: 4276
		[Token(Token = "0x40010B4")]
		[FieldOffset(Offset = "0x28")]
		private readonly int m_SerialId;

		// Token: 0x040010B5 RID: 4277
		[Token(Token = "0x40010B5")]
		[FieldOffset(Offset = "0x30")]
		private readonly SoundComponent.SoundGroup m_SoundGroup;

		// Token: 0x040010B6 RID: 4278
		[Token(Token = "0x40010B6")]
		[FieldOffset(Offset = "0x38")]
		private readonly SoundComponent.PlaySoundParams m_PlaySoundParams;
	}

	// Token: 0x020001E6 RID: 486
	[Token(Token = "0x20001E6")]
	private interface ISoundGroup
	{
		// Token: 0x06000D2D RID: 3373
		[Token(Token = "0x6000D2D")]
		void OnUpate();

		// Token: 0x06000D2E RID: 3374
		[Token(Token = "0x6000D2E")]
		void ChangeVolume(float to, float time);

		// Token: 0x06000D2F RID: 3375
		[Token(Token = "0x6000D2F")]
		void PauseSound();

		// Token: 0x06000D30 RID: 3376
		[Token(Token = "0x6000D30")]
		void ResumeSound();

		// Token: 0x06000D31 RID: 3377
		[Token(Token = "0x6000D31")]
		void MuteSound(bool mute);
	}

	// Token: 0x020001E7 RID: 487
	[Token(Token = "0x20001E7")]
	public enum SoundStatus
	{
		// Token: 0x040010B8 RID: 4280
		[Token(Token = "0x40010B8")]
		None = -1,
		// Token: 0x040010B9 RID: 4281
		[Token(Token = "0x40010B9")]
		Playing,
		// Token: 0x040010BA RID: 4282
		[Token(Token = "0x40010BA")]
		Stopped,
		// Token: 0x040010BB RID: 4283
		[Token(Token = "0x40010BB")]
		Pause,
		// Token: 0x040010BC RID: 4284
		[Token(Token = "0x40010BC")]
		Finished
	}

	// Token: 0x020001E8 RID: 488
	[Token(Token = "0x20001E8")]
	[Serializable]
	public class SoundGroup : SoundComponent.ISoundGroup
	{
		// Token: 0x06000D32 RID: 3378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D32")]
		[Address(RVA = "0x12D28EC", Offset = "0x12D28EC", VA = "0x12D28EC")]
		private SoundGroup()
		{
		}

		// Token: 0x06000D33 RID: 3379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D33")]
		[Address(RVA = "0x12D158C", Offset = "0x12D158C", VA = "0x12D158C")]
		public SoundGroup(string name)
		{
		}

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x06000D34 RID: 3380 RVA: 0x00006078 File Offset: 0x00004278
		[Token(Token = "0x1700019E")]
		public int SerialId
		{
			[Token(Token = "0x6000D34")]
			[Address(RVA = "0x12D297C", Offset = "0x12D297C", VA = "0x12D297C")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x06000D35 RID: 3381 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000D36 RID: 3382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700019F")]
		public string Name
		{
			[Token(Token = "0x6000D35")]
			[Address(RVA = "0x12D2984", Offset = "0x12D2984", VA = "0x12D2984")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000D36")]
			[Address(RVA = "0x12D298C", Offset = "0x12D298C", VA = "0x12D298C")]
			set
			{
			}
		}

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x06000D37 RID: 3383 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001A0")]
		public Transform AudioSourceTransform
		{
			[Token(Token = "0x6000D37")]
			[Address(RVA = "0x12D2994", Offset = "0x12D2994", VA = "0x12D2994")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x06000D38 RID: 3384 RVA: 0x00006090 File Offset: 0x00004290
		// (set) Token: 0x06000D39 RID: 3385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001A1")]
		public bool Mute
		{
			[Token(Token = "0x6000D38")]
			[Address(RVA = "0x12D299C", Offset = "0x12D299C", VA = "0x12D299C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000D39")]
			[Address(RVA = "0x12CEEB4", Offset = "0x12CEEB4", VA = "0x12CEEB4")]
			set
			{
			}
		}

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x06000D3A RID: 3386 RVA: 0x000060A8 File Offset: 0x000042A8
		// (set) Token: 0x06000D3B RID: 3387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001A2")]
		public float Volume
		{
			[Token(Token = "0x6000D3A")]
			[Address(RVA = "0x12D29B8", Offset = "0x12D29B8", VA = "0x12D29B8")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000D3B")]
			[Address(RVA = "0x12D1710", Offset = "0x12D1710", VA = "0x12D1710")]
			set
			{
			}
		}

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x06000D3C RID: 3388 RVA: 0x000060C0 File Offset: 0x000042C0
		// (set) Token: 0x06000D3D RID: 3389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001A3")]
		public bool Loop
		{
			[Token(Token = "0x6000D3C")]
			[Address(RVA = "0x12D29D4", Offset = "0x12D29D4", VA = "0x12D29D4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000D3D")]
			[Address(RVA = "0x12D29F0", Offset = "0x12D29F0", VA = "0x12D29F0")]
			set
			{
			}
		}

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x06000D3E RID: 3390 RVA: 0x000060D8 File Offset: 0x000042D8
		[Token(Token = "0x170001A4")]
		public float Length
		{
			[Token(Token = "0x6000D3E")]
			[Address(RVA = "0x12CF60C", Offset = "0x12CF60C", VA = "0x12CF60C")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06000D3F RID: 3391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D3F")]
		[Address(RVA = "0x12D199C", Offset = "0x12D199C", VA = "0x12D199C")]
		public void PlaySound(int serialId, Asset soundAsset, bool loop = false, float volume = 1f)
		{
		}

		// Token: 0x06000D40 RID: 3392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D40")]
		[Address(RVA = "0x12D2A10", Offset = "0x12D2A10", VA = "0x12D2A10")]
		public void PlayOneShot(int serialId, Asset soundAsset, bool loop, float volume)
		{
		}

		// Token: 0x06000D41 RID: 3393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D41")]
		[Address(RVA = "0x12D2C5C", Offset = "0x12D2C5C", VA = "0x12D2C5C")]
		public void PlayClipAtPoint(int serialId, Asset soundAsset, float volume, Vector3 pos)
		{
		}

		// Token: 0x06000D42 RID: 3394 RVA: 0x000060F0 File Offset: 0x000042F0
		[Token(Token = "0x6000D42")]
		[Address(RVA = "0x12D0680", Offset = "0x12D0680", VA = "0x12D0680")]
		public bool StopSound()
		{
			return default(bool);
		}

		// Token: 0x06000D43 RID: 3395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D43")]
		[Address(RVA = "0x12D0D98", Offset = "0x12D0D98", VA = "0x12D0D98", Slot = "6")]
		public void PauseSound()
		{
		}

		// Token: 0x06000D44 RID: 3396 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D44")]
		[Address(RVA = "0x12D0FB4", Offset = "0x12D0FB4", VA = "0x12D0FB4", Slot = "7")]
		public void ResumeSound()
		{
		}

		// Token: 0x06000D45 RID: 3397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D45")]
		[Address(RVA = "0x12D2EE0", Offset = "0x12D2EE0", VA = "0x12D2EE0", Slot = "8")]
		public void MuteSound(bool mute)
		{
		}

		// Token: 0x06000D46 RID: 3398 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D46")]
		[Address(RVA = "0x12D2F78", Offset = "0x12D2F78", VA = "0x12D2F78", Slot = "4")]
		public void OnUpate()
		{
		}

		// Token: 0x06000D47 RID: 3399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D47")]
		[Address(RVA = "0x12D1F30", Offset = "0x12D1F30", VA = "0x12D1F30")]
		public void ChangeGameVolume(float to)
		{
		}

		// Token: 0x06000D48 RID: 3400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D48")]
		[Address(RVA = "0x12D2014", Offset = "0x12D2014", VA = "0x12D2014", Slot = "5")]
		public void ChangeVolume(float to, float time)
		{
		}

		// Token: 0x06000D49 RID: 3401 RVA: 0x00006108 File Offset: 0x00004308
		[Token(Token = "0x6000D49")]
		[Address(RVA = "0x12D263C", Offset = "0x12D263C", VA = "0x12D263C")]
		public SoundComponent.SoundStatus GetStatus()
		{
			return SoundComponent.SoundStatus.Playing;
		}

		// Token: 0x040010BD RID: 4285
		[Token(Token = "0x40010BD")]
		[FieldOffset(Offset = "0x10")]
		private int m_serialId;

		// Token: 0x040010BE RID: 4286
		[Token(Token = "0x40010BE")]
		[FieldOffset(Offset = "0x18")]
		private string m_Name;

		// Token: 0x040010BF RID: 4287
		[Token(Token = "0x40010BF")]
		[FieldOffset(Offset = "0x20")]
		private AudioSource m_AudioSource;

		// Token: 0x040010C0 RID: 4288
		[Token(Token = "0x40010C0")]
		[FieldOffset(Offset = "0x28")]
		private Transform m_AudioSourceTransform;

		// Token: 0x040010C1 RID: 4289
		[Token(Token = "0x40010C1")]
		[FieldOffset(Offset = "0x30")]
		private Asset m_SoundAsset;

		// Token: 0x040010C2 RID: 4290
		[Token(Token = "0x40010C2")]
		[FieldOffset(Offset = "0x38")]
		public float m_curLength;

		// Token: 0x040010C3 RID: 4291
		[Token(Token = "0x40010C3")]
		[FieldOffset(Offset = "0x3C")]
		private float m_curVolume;

		// Token: 0x040010C4 RID: 4292
		[Token(Token = "0x40010C4")]
		[FieldOffset(Offset = "0x40")]
		private float m_gameVolume;

		// Token: 0x040010C5 RID: 4293
		[Token(Token = "0x40010C5")]
		[FieldOffset(Offset = "0x44")]
		private float _fromVolume;

		// Token: 0x040010C6 RID: 4294
		[Token(Token = "0x40010C6")]
		[FieldOffset(Offset = "0x48")]
		private float _toVolume;

		// Token: 0x040010C7 RID: 4295
		[Token(Token = "0x40010C7")]
		[FieldOffset(Offset = "0x4C")]
		private float _time;

		// Token: 0x040010C8 RID: 4296
		[Token(Token = "0x40010C8")]
		[FieldOffset(Offset = "0x50")]
		private float _curTime;

		// Token: 0x040010C9 RID: 4297
		[Token(Token = "0x40010C9")]
		[FieldOffset(Offset = "0x54")]
		private bool _changeVolume;

		// Token: 0x040010CA RID: 4298
		[Token(Token = "0x40010CA")]
		[FieldOffset(Offset = "0x58")]
		private List<SoundComponent.SoundGroup.OneShotSound> m_OneShots;

		// Token: 0x020001E9 RID: 489
		[Token(Token = "0x20001E9")]
		private struct OneShotSound
		{
			// Token: 0x040010CB RID: 4299
			[Token(Token = "0x40010CB")]
			[FieldOffset(Offset = "0x0")]
			public Asset soundAsset;

			// Token: 0x040010CC RID: 4300
			[Token(Token = "0x40010CC")]
			[FieldOffset(Offset = "0x8")]
			public float playTime;

			// Token: 0x040010CD RID: 4301
			[Token(Token = "0x40010CD")]
			[FieldOffset(Offset = "0xC")]
			public float clipLength;
		}
	}

	// Token: 0x020001EA RID: 490
	[Token(Token = "0x20001EA")]
	[Serializable]
	public class Sound3DGroup : SoundComponent.ISoundGroup
	{
		// Token: 0x06000D4A RID: 3402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D4A")]
		[Address(RVA = "0x12D3138", Offset = "0x12D3138", VA = "0x12D3138")]
		private Sound3DGroup()
		{
		}

		// Token: 0x06000D4B RID: 3403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D4B")]
		[Address(RVA = "0x12CE170", Offset = "0x12CE170", VA = "0x12CE170")]
		public Sound3DGroup(string name)
		{
		}

		// Token: 0x06000D4C RID: 3404 RVA: 0x00006120 File Offset: 0x00004320
		[Token(Token = "0x6000D4C")]
		[Address(RVA = "0x12D31C0", Offset = "0x12D31C0", VA = "0x12D31C0")]
		public bool PlaySound(int serialId, GameObject go, Asset soundAsset)
		{
			return default(bool);
		}

		// Token: 0x06000D4D RID: 3405 RVA: 0x00006138 File Offset: 0x00004338
		[Token(Token = "0x6000D4D")]
		[Address(RVA = "0x12CEAC8", Offset = "0x12CEAC8", VA = "0x12CEAC8")]
		public bool Stop(GameObject go)
		{
			return default(bool);
		}

		// Token: 0x06000D4E RID: 3406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D4E")]
		[Address(RVA = "0x12CEC30", Offset = "0x12CEC30", VA = "0x12CEC30")]
		public void RemoveAll()
		{
		}

		// Token: 0x06000D4F RID: 3407 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D4F")]
		[Address(RVA = "0x12D357C", Offset = "0x12D357C", VA = "0x12D357C")]
		public AudioSource GetAudioSource(GameObject go)
		{
			return null;
		}

		// Token: 0x06000D50 RID: 3408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D50")]
		[Address(RVA = "0x12D35F8", Offset = "0x12D35F8", VA = "0x12D35F8", Slot = "4")]
		public void OnUpate()
		{
		}

		// Token: 0x06000D51 RID: 3409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D51")]
		[Address(RVA = "0x12D389C", Offset = "0x12D389C", VA = "0x12D389C", Slot = "5")]
		public void ChangeVolume(float to, float time)
		{
		}

		// Token: 0x06000D52 RID: 3410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D52")]
		[Address(RVA = "0x12D3A7C", Offset = "0x12D3A7C", VA = "0x12D3A7C", Slot = "6")]
		public void PauseSound()
		{
		}

		// Token: 0x06000D53 RID: 3411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D53")]
		[Address(RVA = "0x12D3BDC", Offset = "0x12D3BDC", VA = "0x12D3BDC", Slot = "7")]
		public void ResumeSound()
		{
		}

		// Token: 0x06000D54 RID: 3412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D54")]
		[Address(RVA = "0x12D3D3C", Offset = "0x12D3D3C", VA = "0x12D3D3C", Slot = "8")]
		public void MuteSound(bool mute)
		{
		}

		// Token: 0x040010CE RID: 4302
		[Token(Token = "0x40010CE")]
		[FieldOffset(Offset = "0x10")]
		private float _toVolume;

		// Token: 0x040010CF RID: 4303
		[Token(Token = "0x40010CF")]
		[FieldOffset(Offset = "0x14")]
		private float _time;

		// Token: 0x040010D0 RID: 4304
		[Token(Token = "0x40010D0")]
		[FieldOffset(Offset = "0x18")]
		private float _curTime;

		// Token: 0x040010D1 RID: 4305
		[Token(Token = "0x40010D1")]
		[FieldOffset(Offset = "0x1C")]
		private bool _changeVolume;

		// Token: 0x040010D2 RID: 4306
		[Token(Token = "0x40010D2")]
		[FieldOffset(Offset = "0x20")]
		private string m_Name;

		// Token: 0x040010D3 RID: 4307
		[Token(Token = "0x40010D3")]
		[FieldOffset(Offset = "0x28")]
		private Dictionary<GameObject, SoundComponent.Sound3DGroup.OneSound> m_all3DSource;

		// Token: 0x020001EB RID: 491
		[Token(Token = "0x20001EB")]
		private struct OneSound
		{
			// Token: 0x040010D4 RID: 4308
			[Token(Token = "0x40010D4")]
			[FieldOffset(Offset = "0x0")]
			public float volume;

			// Token: 0x040010D5 RID: 4309
			[Token(Token = "0x40010D5")]
			[FieldOffset(Offset = "0x8")]
			public Asset soundAsset;

			// Token: 0x040010D6 RID: 4310
			[Token(Token = "0x40010D6")]
			[FieldOffset(Offset = "0x10")]
			public AudioSource source;
		}
	}
}
