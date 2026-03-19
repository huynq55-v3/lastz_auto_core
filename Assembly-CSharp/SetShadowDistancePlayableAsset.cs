using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

// Token: 0x020002C4 RID: 708
[Token(Token = "0x20002C4")]
[Serializable]
public class SetShadowDistancePlayableAsset : PlayableAsset
{
	// Token: 0x06001269 RID: 4713 RVA: 0x00007560 File Offset: 0x00005760
	[Token(Token = "0x6001269")]
	[Address(RVA = "0x1C5C74C", Offset = "0x1C5C74C", VA = "0x1C5C74C", Slot = "6")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject go)
	{
		return default(Playable);
	}

	// Token: 0x0600126A RID: 4714 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600126A")]
	[Address(RVA = "0x1C5C838", Offset = "0x1C5C838", VA = "0x1C5C838")]
	public SetShadowDistancePlayableAsset()
	{
	}

	// Token: 0x04001528 RID: 5416
	[Token(Token = "0x4001528")]
	[FieldOffset(Offset = "0x18")]
	public int shadowDistance;
}
