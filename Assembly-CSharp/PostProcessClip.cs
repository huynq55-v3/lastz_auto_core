using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

// Token: 0x0200039F RID: 927
[Token(Token = "0x200039F")]
[Serializable]
public class PostProcessClip : PlayableAsset, ITimelineClipAsset
{
	// Token: 0x17000253 RID: 595
	// (get) Token: 0x0600179E RID: 6046 RVA: 0x00008BE0 File Offset: 0x00006DE0
	[Token(Token = "0x17000253")]
	public ClipCaps clipCaps
	{
		[Token(Token = "0x600179E")]
		[Address(RVA = "0x1DB7180", Offset = "0x1DB7180", VA = "0x1DB7180", Slot = "9")]
		get
		{
			return default(ClipCaps);
		}
	}

	// Token: 0x0600179F RID: 6047 RVA: 0x00008BF8 File Offset: 0x00006DF8
	[Token(Token = "0x600179F")]
	[Address(RVA = "0x1DB7188", Offset = "0x1DB7188", VA = "0x1DB7188", Slot = "6")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}

	// Token: 0x060017A0 RID: 6048 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60017A0")]
	[Address(RVA = "0x1DB7274", Offset = "0x1DB7274", VA = "0x1DB7274")]
	public PostProcessClip()
	{
	}

	// Token: 0x04001A4E RID: 6734
	[Token(Token = "0x4001A4E")]
	[FieldOffset(Offset = "0x18")]
	public PostProcessBehaviour template;
}
