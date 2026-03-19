using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Main.Scripts.Network;
using Unity.IL2CPP.CompilerServices;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x020000C9 RID: 201
[Token(Token = "0x20000C9")]
[Preserve]
[Il2CppSetOption(Option.NullChecks, false)]
public static class UnityExtension_StringLookup
{
	// Token: 0x060004C0 RID: 1216 RVA: 0x000038E8 File Offset: 0x00001AE8
	[Token(Token = "0x60004C0")]
	[Address(RVA = "0x2F75174", Offset = "0x2F75174", VA = "0x2F75174")]
	public static bool Play(this SimpleAnimation ani, int stateNameToId)
	{
		return default(bool);
	}

	// Token: 0x060004C1 RID: 1217 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004C1")]
	[Address(RVA = "0x2F751E4", Offset = "0x2F751E4", VA = "0x2F751E4")]
	public static void Rewind(this SimpleAnimation ani, int stateNameToId)
	{
	}

	// Token: 0x060004C2 RID: 1218 RVA: 0x00003900 File Offset: 0x00001B00
	[Token(Token = "0x60004C2")]
	[Address(RVA = "0x2F75254", Offset = "0x2F75254", VA = "0x2F75254")]
	public static bool IsPlaying(this SimpleAnimation ani, int stateNameToId)
	{
		return default(bool);
	}

	// Token: 0x060004C3 RID: 1219 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004C3")]
	[Address(RVA = "0x2F752C4", Offset = "0x2F752C4", VA = "0x2F752C4")]
	public static void PlayQueued(this SimpleAnimation simpleAni, int stateNameToId)
	{
	}

	// Token: 0x060004C4 RID: 1220 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004C4")]
	[Address(RVA = "0x2F75338", Offset = "0x2F75338", VA = "0x2F75338")]
	public static SimpleAnimation.State GetState(this SimpleAnimation simpleAni, int stateNameToId)
	{
		return null;
	}

	// Token: 0x060004C5 RID: 1221 RVA: 0x00003918 File Offset: 0x00001B18
	[Token(Token = "0x60004C5")]
	[Address(RVA = "0x2F753A8", Offset = "0x2F753A8", VA = "0x2F753A8")]
	public static bool HasState(this SimpleAnimation simpleAni, int stateNameId)
	{
		return default(bool);
	}

	// Token: 0x060004C6 RID: 1222 RVA: 0x00003930 File Offset: 0x00001B30
	[Token(Token = "0x60004C6")]
	[Address(RVA = "0x2F75418", Offset = "0x2F75418", VA = "0x2F75418")]
	public static float GetClipLength(this SimpleAnimation simpleAni, int stateNameId)
	{
		return 0f;
	}

	// Token: 0x060004C7 RID: 1223 RVA: 0x00003948 File Offset: 0x00001B48
	[Token(Token = "0x60004C7")]
	[Address(RVA = "0x2F75488", Offset = "0x2F75488", VA = "0x2F75488")]
	public static float GetClipTime(this SimpleAnimation simpleAni, int stateNameId)
	{
		return 0f;
	}

	// Token: 0x060004C8 RID: 1224 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004C8")]
	[Address(RVA = "0x2F754F8", Offset = "0x2F754F8", VA = "0x2F754F8")]
	public static void CrossFade(this SimpleAnimation simpleAni, int stateNameId, float fadeLength)
	{
	}

	// Token: 0x060004C9 RID: 1225 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004C9")]
	[Address(RVA = "0x2F75578", Offset = "0x2F75578", VA = "0x2F75578")]
	public static void CrossFadeQueued(this SimpleAnimation simpleAni, int stateNameId, float fadeLength, QueueMode queueMode)
	{
	}

	// Token: 0x060004CA RID: 1226 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004CA")]
	[Address(RVA = "0x2F75600", Offset = "0x2F75600", VA = "0x2F75600")]
	public static void SetStateSpeed(this SimpleAnimation simpleAni, int stateNameId, float speed)
	{
	}

	// Token: 0x060004CB RID: 1227 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004CB")]
	[Address(RVA = "0x2F75680", Offset = "0x2F75680", VA = "0x2F75680")]
	public static void SetStateTime(this SimpleAnimation simpleAni, int stateNameId, float time)
	{
	}

	// Token: 0x060004CC RID: 1228 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004CC")]
	[Address(RVA = "0x2F75700", Offset = "0x2F75700", VA = "0x2F75700")]
	public static void PlayAnimation(this SurvivalLodEx lodEx, int animationNameId)
	{
	}

	// Token: 0x060004CD RID: 1229 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004CD")]
	[Address(RVA = "0x2F75770", Offset = "0x2F75770", VA = "0x2F75770")]
	public static void Play(this Animator ani, int stateNameToId, int layerIdx, float normalizedTime)
	{
	}

	// Token: 0x060004CE RID: 1230 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004CE")]
	[Address(RVA = "0x2F757F8", Offset = "0x2F757F8", VA = "0x2F757F8")]
	public static void SetTrigger(this Animator ani, int triggerNameToId)
	{
	}

	// Token: 0x060004CF RID: 1231 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004CF")]
	[Address(RVA = "0x2F75868", Offset = "0x2F75868", VA = "0x2F75868")]
	public static Transform Find(this Transform tran, int pathToId)
	{
		return null;
	}

	// Token: 0x060004D0 RID: 1232 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004D0")]
	[Address(RVA = "0x2F758D8", Offset = "0x2F758D8", VA = "0x2F758D8")]
	public static void EnableKeyword(this Material mater, int id)
	{
	}

	// Token: 0x060004D1 RID: 1233 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004D1")]
	[Address(RVA = "0x2F75948", Offset = "0x2F75948", VA = "0x2F75948")]
	public static void DisableKeyword(this Material mater, int id)
	{
	}

	// Token: 0x060004D2 RID: 1234 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004D2")]
	[Address(RVA = "0x2F759B8", Offset = "0x2F759B8", VA = "0x2F759B8")]
	public static InstanceRequest InstantiateAsync(this ResourceManager resMgr, int prefabPathId, [Optional] Action<InstanceRequest> callback, [Optional] Transform presetParent)
	{
		return null;
	}

	// Token: 0x060004D3 RID: 1235 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004D3")]
	[Address(RVA = "0x2F759BC", Offset = "0x2F759BC", VA = "0x2F759BC")]
	public static InstanceRequest InstantiateAsyncId(this ResourceManager resMgr, int prefabPathId, [Optional] Action<InstanceRequest> callback, [Optional] Transform presetParent)
	{
		return null;
	}

	// Token: 0x060004D4 RID: 1236 RVA: 0x00003960 File Offset: 0x00001B60
	[Token(Token = "0x60004D4")]
	[Address(RVA = "0x2F75AC0", Offset = "0x2F75AC0", VA = "0x2F75AC0")]
	public static int PlayEffect(this SoundComponent sound, int effectId, bool loop = false, float volume = 1f, int groupId = -1)
	{
		return 0;
	}

	// Token: 0x060004D5 RID: 1237 RVA: 0x00003978 File Offset: 0x00001B78
	[Token(Token = "0x60004D5")]
	[Address(RVA = "0x2F75B64", Offset = "0x2F75B64", VA = "0x2F75B64")]
	public static int PlaySound(this SoundComponent sound, int effectId, string soundGroupName, SoundComponent.PlaySoundParams playSoundParams, object userData, [Optional] Action<bool, int> action)
	{
		return 0;
	}

	// Token: 0x060004D6 RID: 1238 RVA: 0x00003990 File Offset: 0x00001B90
	[Token(Token = "0x60004D6")]
	[Address(RVA = "0x2F75C04", Offset = "0x2F75C04", VA = "0x2F75C04")]
	public static int PlayWorldScopeEffect(this SoundComponent sound, int effectId, bool loop = false)
	{
		return 0;
	}

	// Token: 0x060004D7 RID: 1239 RVA: 0x000039A8 File Offset: 0x00001BA8
	[Token(Token = "0x60004D7")]
	[Address(RVA = "0x2F75C80", Offset = "0x2F75C80", VA = "0x2F75C80")]
	public static int PlayWorldScopeEffect(this SoundComponent sound, int effectId, bool loop, float volume)
	{
		return 0;
	}

	// Token: 0x060004D8 RID: 1240 RVA: 0x000039C0 File Offset: 0x00001BC0
	[Token(Token = "0x60004D8")]
	[Address(RVA = "0x2F75D08", Offset = "0x2F75D08", VA = "0x2F75D08")]
	public static bool IsAssetDownloaded(this ResourceManager res, int pathId)
	{
		return default(bool);
	}

	// Token: 0x060004D9 RID: 1241 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004D9")]
	[Address(RVA = "0x2F75D78", Offset = "0x2F75D78", VA = "0x2F75D78")]
	public static void SetName(this Object obj, int nameId)
	{
	}

	// Token: 0x060004DA RID: 1242 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004DA")]
	[Address(RVA = "0x2F75E04", Offset = "0x2F75E04", VA = "0x2F75E04")]
	public static void LoadSprite(this Image image, int spritePathId, [Optional] string defaultSprite)
	{
	}

	// Token: 0x060004DB RID: 1243 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004DB")]
	[Address(RVA = "0x2F75EA8", Offset = "0x2F75EA8", VA = "0x2F75EA8")]
	public static void LoadSprite(this CircleImage image, int spritePathId, [Optional] string defaultSprite)
	{
	}

	// Token: 0x060004DC RID: 1244 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004DC")]
	[Address(RVA = "0x2F75F4C", Offset = "0x2F75F4C", VA = "0x2F75F4C")]
	public static void LoadSprite(this SpriteRenderer spriteRenderer, int spritePathId, [Optional] string defaultSprite)
	{
	}

	// Token: 0x060004DD RID: 1245 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004DD")]
	[Address(RVA = "0x2F75FF0", Offset = "0x2F75FF0", VA = "0x2F75FF0")]
	public static void LoadSprite(this SpriteMeshRenderer meshRenderer, int spritePathId, [Optional] string defaultSprite)
	{
	}

	// Token: 0x060004DE RID: 1246 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004DE")]
	[Address(RVA = "0x2F76094", Offset = "0x2F76094", VA = "0x2F76094")]
	public static void SendLuaMessage(this NetworkManager netMgr, int msgToId, byte[] sfsObjBinary)
	{
	}

	// Token: 0x060004DF RID: 1247 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004DF")]
	[Address(RVA = "0x2F7610C", Offset = "0x2F7610C", VA = "0x2F7610C")]
	public static void onSendRequest(this FutureManager mgr, int fuid, int msgIntId)
	{
	}

	// Token: 0x060004E0 RID: 1248 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004E0")]
	[Address(RVA = "0x2F76184", Offset = "0x2F76184", VA = "0x2F76184")]
	public static void StopGroupSound(this SoundComponent s, int soundGroupNameId)
	{
	}
}
