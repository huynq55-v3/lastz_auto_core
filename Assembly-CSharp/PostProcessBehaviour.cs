using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Rendering;

// Token: 0x0200039E RID: 926
[Token(Token = "0x200039E")]
[Serializable]
public class PostProcessBehaviour : PlayableBehaviour
{
	// Token: 0x06001799 RID: 6041 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001799")]
	[Address(RVA = "0x1DB6DC4", Offset = "0x1DB6DC4", VA = "0x1DB6DC4", Slot = "17")]
	public override void OnBehaviourPlay(Playable playable, FrameData info)
	{
	}

	// Token: 0x0600179A RID: 6042 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600179A")]
	[Address(RVA = "0x1DB7000", Offset = "0x1DB7000", VA = "0x1DB7000", Slot = "18")]
	public override void OnBehaviourPause(Playable playable, FrameData info)
	{
	}

	// Token: 0x0600179B RID: 6043 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600179B")]
	[Address(RVA = "0x1DB6E3C", Offset = "0x1DB6E3C", VA = "0x1DB6E3C")]
	private void QuickVolume()
	{
	}

	// Token: 0x0600179C RID: 6044 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600179C")]
	[Address(RVA = "0x1DB70A8", Offset = "0x1DB70A8", VA = "0x1DB70A8")]
	public void ChangeWeight(float time)
	{
	}

	// Token: 0x0600179D RID: 6045 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600179D")]
	[Address(RVA = "0x1DB7140", Offset = "0x1DB7140", VA = "0x1DB7140")]
	public PostProcessBehaviour()
	{
	}

	// Token: 0x04001A4A RID: 6730
	[Token(Token = "0x4001A4A")]
	[FieldOffset(Offset = "0x10")]
	[HideInInspector]
	public Volume volume;

	// Token: 0x04001A4B RID: 6731
	[Token(Token = "0x4001A4B")]
	[FieldOffset(Offset = "0x18")]
	public VolumeProfile profile;

	// Token: 0x04001A4C RID: 6732
	[Token(Token = "0x4001A4C")]
	[FieldOffset(Offset = "0x20")]
	public int layer;

	// Token: 0x04001A4D RID: 6733
	[Token(Token = "0x4001A4D")]
	[FieldOffset(Offset = "0x28")]
	public AnimationCurve weightCurve;
}
