using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

// Token: 0x02000094 RID: 148
[Token(Token = "0x2000094")]
public class PlayTimeLine : MonoBehaviour
{
	// Token: 0x06000381 RID: 897 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000381")]
	[Address(RVA = "0x3214F34", Offset = "0x3214F34", VA = "0x3214F34")]
	private void Start()
	{
	}

	// Token: 0x06000382 RID: 898 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000382")]
	[Address(RVA = "0x3214F80", Offset = "0x3214F80", VA = "0x3214F80")]
	private void PlayTimelineStopHandle(PlayableDirector director)
	{
	}

	// Token: 0x06000383 RID: 899 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000383")]
	[Address(RVA = "0x3214F84", Offset = "0x3214F84", VA = "0x3214F84")]
	public PlayTimeLine()
	{
	}

	// Token: 0x0400030A RID: 778
	[Token(Token = "0x400030A")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public TimelineAsset timelineAsset;

	// Token: 0x0400030B RID: 779
	[Token(Token = "0x400030B")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	public PlayableDirector playeAble;
}
