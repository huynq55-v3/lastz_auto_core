using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002BC RID: 700
[Token(Token = "0x20002BC")]
public class SceneLowFpsMonitor : MonoBehaviour
{
	// Token: 0x0600121D RID: 4637 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600121D")]
	[Address(RVA = "0x1C59944", Offset = "0x1C59944", VA = "0x1C59944")]
	public void StartStats()
	{
	}

	// Token: 0x0600121E RID: 4638 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600121E")]
	[Address(RVA = "0x1C59950", Offset = "0x1C59950", VA = "0x1C59950")]
	private void Update()
	{
	}

	// Token: 0x0600121F RID: 4639 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600121F")]
	[Address(RVA = "0x1C59CF0", Offset = "0x1C59CF0", VA = "0x1C59CF0")]
	public SceneLowFpsMonitor()
	{
	}

	// Token: 0x040014FF RID: 5375
	[Token(Token = "0x40014FF")]
	[FieldOffset(Offset = "0x18")]
	private float _unscaledDeltaTime;

	// Token: 0x04001500 RID: 5376
	[Token(Token = "0x4001500")]
	[FieldOffset(Offset = "0x1C")]
	private float _avgFps;

	// Token: 0x04001501 RID: 5377
	[Token(Token = "0x4001501")]
	[FieldOffset(Offset = "0x20")]
	private float _currentFps;

	// Token: 0x04001502 RID: 5378
	[Token(Token = "0x4001502")]
	[FieldOffset(Offset = "0x28")]
	private List<float> _fpsSamples;

	// Token: 0x04001503 RID: 5379
	[Token(Token = "0x4001503")]
	[FieldOffset(Offset = "0x30")]
	private List<float> _avgFpsSamples;

	// Token: 0x04001504 RID: 5380
	[Token(Token = "0x4001504")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private int AvgFpsThreshold;

	// Token: 0x04001505 RID: 5381
	[Token(Token = "0x4001505")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	private int FpsSamplesMaxCount;

	// Token: 0x04001506 RID: 5382
	[Token(Token = "0x4001506")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private float AverageSampleInterval;

	// Token: 0x04001507 RID: 5383
	[Token(Token = "0x4001507")]
	[FieldOffset(Offset = "0x44")]
	[SerializeField]
	private int AverageSampleCount;

	// Token: 0x04001508 RID: 5384
	[Token(Token = "0x4001508")]
	[FieldOffset(Offset = "0x48")]
	private float _avgSampleTime;

	// Token: 0x04001509 RID: 5385
	[Token(Token = "0x4001509")]
	[FieldOffset(Offset = "0x4C")]
	private bool _startStats;
}
