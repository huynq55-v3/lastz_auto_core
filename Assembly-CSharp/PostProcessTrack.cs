using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

// Token: 0x020003A1 RID: 929
[Token(Token = "0x20003A1")]
[TrackClipType(typeof(PostProcessClip))]
[TrackColor(0.98f, 0.27f, 0.42f)]
public class PostProcessTrack : TrackAsset
{
	// Token: 0x060017A3 RID: 6051 RVA: 0x00008C10 File Offset: 0x00006E10
	[Token(Token = "0x60017A3")]
	[Address(RVA = "0x1DB7528", Offset = "0x1DB7528", VA = "0x1DB7528", Slot = "24")]
	public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
	{
		return default(Playable);
	}

	// Token: 0x060017A4 RID: 6052 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60017A4")]
	[Address(RVA = "0x1DB75C8", Offset = "0x1DB75C8", VA = "0x1DB75C8")]
	public PostProcessTrack()
	{
	}
}
