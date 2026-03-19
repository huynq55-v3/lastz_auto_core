using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

// Token: 0x0200033A RID: 826
[Token(Token = "0x200033A")]
public class GuideTimelineMarker : MonoBehaviour, INotificationReceiver
{
	// Token: 0x06001593 RID: 5523 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001593")]
	[Address(RVA = "0x1ED3D38", Offset = "0x1ED3D38", VA = "0x1ED3D38")]
	private void Awake()
	{
	}

	// Token: 0x06001594 RID: 5524 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001594")]
	[Address(RVA = "0x1ED3D40", Offset = "0x1ED3D40", VA = "0x1ED3D40", Slot = "4")]
	public void OnNotify(Playable origin, INotification notification, object context)
	{
	}

	// Token: 0x06001595 RID: 5525 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001595")]
	[Address(RVA = "0x1ED4140", Offset = "0x1ED4140", VA = "0x1ED4140")]
	public GuideTimelineMarker()
	{
	}

	// Token: 0x0400188F RID: 6287
	[Token(Token = "0x400188F")]
	[FieldOffset(Offset = "0x18")]
	public Func<bool> IsContinue;

	// Token: 0x04001890 RID: 6288
	[Token(Token = "0x4001890")]
	[FieldOffset(Offset = "0x20")]
	private double _markerTime;

	// Token: 0x0200033B RID: 827
	[Token(Token = "0x200033B")]
	private enum ShowMarkType
	{
		// Token: 0x04001892 RID: 6290
		[Token(Token = "0x4001892")]
		Zero,
		// Token: 0x04001893 RID: 6291
		[Token(Token = "0x4001893")]
		One,
		// Token: 0x04001894 RID: 6292
		[Token(Token = "0x4001894")]
		Start = 998,
		// Token: 0x04001895 RID: 6293
		[Token(Token = "0x4001895")]
		End
	}
}
