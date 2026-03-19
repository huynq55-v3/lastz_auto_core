using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

// Token: 0x020001F2 RID: 498
[Token(Token = "0x20001F2")]
public class TimerComponent : IGameController
{
	// Token: 0x06000D62 RID: 3426 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D62")]
	[Address(RVA = "0x12D464C", Offset = "0x12D464C", VA = "0x12D464C")]
	public TimerComponent()
	{
	}

	// Token: 0x170001A8 RID: 424
	// (get) Token: 0x06000D63 RID: 3427 RVA: 0x00006150 File Offset: 0x00004350
	// (set) Token: 0x06000D64 RID: 3428 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001A8")]
	public long Tomorrow
	{
		[Token(Token = "0x6000D63")]
		[Address(RVA = "0x12D4754", Offset = "0x12D4754", VA = "0x12D4754")]
		[CompilerGenerated]
		get
		{
			return 0L;
		}
		[Token(Token = "0x6000D64")]
		[Address(RVA = "0x12D475C", Offset = "0x12D475C", VA = "0x12D475C")]
		[CompilerGenerated]
		set
		{
		}
	}

	// Token: 0x06000D65 RID: 3429 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D65")]
	[Address(RVA = "0x12D4764", Offset = "0x12D4764", VA = "0x12D4764", Slot = "5")]
	public void Shutdown()
	{
	}

	// Token: 0x06000D66 RID: 3430 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D66")]
	[Address(RVA = "0x12D493C", Offset = "0x12D493C", VA = "0x12D493C", Slot = "4")]
	public void OnUpdate(float elapseSeconds)
	{
	}

	// Token: 0x06000D67 RID: 3431 RVA: 0x00006168 File Offset: 0x00004368
	[Token(Token = "0x6000D67")]
	[Address(RVA = "0x12D4BA0", Offset = "0x12D4BA0", VA = "0x12D4BA0")]
	public long ChangeTime(long t)
	{
		return 0L;
	}

	// Token: 0x06000D68 RID: 3432 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D68")]
	[Address(RVA = "0x12D4BAC", Offset = "0x12D4BAC", VA = "0x12D4BAC")]
	public void UpdateServerMilliseconds(long ms)
	{
	}

	// Token: 0x06000D69 RID: 3433 RVA: 0x00006180 File Offset: 0x00004380
	[Token(Token = "0x6000D69")]
	[Address(RVA = "0x12D4BD4", Offset = "0x12D4BD4", VA = "0x12D4BD4")]
	public long GetLocalMilliseconds()
	{
		return 0L;
	}

	// Token: 0x06000D6A RID: 3434 RVA: 0x00006198 File Offset: 0x00004398
	[Token(Token = "0x6000D6A")]
	[Address(RVA = "0x12D4C9C", Offset = "0x12D4C9C", VA = "0x12D4C9C")]
	public long GetLocalSeconds()
	{
		return 0L;
	}

	// Token: 0x06000D6B RID: 3435 RVA: 0x000061B0 File Offset: 0x000043B0
	[Token(Token = "0x6000D6B")]
	[Address(RVA = "0x12D4D64", Offset = "0x12D4D64", VA = "0x12D4D64")]
	public long GetServerTime()
	{
		return 0L;
	}

	// Token: 0x06000D6C RID: 3436 RVA: 0x000061C8 File Offset: 0x000043C8
	[Token(Token = "0x6000D6C")]
	[Address(RVA = "0x12D4D7C", Offset = "0x12D4D7C", VA = "0x12D4D7C")]
	public int GetServerTimeSeconds()
	{
		return 0;
	}

	// Token: 0x06000D6D RID: 3437 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D6D")]
	[Address(RVA = "0x12D4DB4", Offset = "0x12D4DB4", VA = "0x12D4DB4")]
	public string MillisecondToSecondString(long mstime, string separator)
	{
		return null;
	}

	// Token: 0x06000D6E RID: 3438 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D6E")]
	[Address(RVA = "0x12D4DD4", Offset = "0x12D4DD4", VA = "0x12D4DD4")]
	public string SecondsToSecondString(long second, string separator)
	{
		return null;
	}

	// Token: 0x06000D6F RID: 3439 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D6F")]
	[Address(RVA = "0x12D4F50", Offset = "0x12D4F50", VA = "0x12D4F50")]
	public string MilliSecondToFmtString(long milliSecond)
	{
		return null;
	}

	// Token: 0x06000D70 RID: 3440 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D70")]
	[Address(RVA = "0x12D4F78", Offset = "0x12D4F78", VA = "0x12D4F78")]
	public string SecondToFmtString(long secs)
	{
		return null;
	}

	// Token: 0x06000D71 RID: 3441 RVA: 0x000061E0 File Offset: 0x000043E0
	[Token(Token = "0x6000D71")]
	[Address(RVA = "0x12D527C", Offset = "0x12D527C", VA = "0x12D527C")]
	public long RefixTimebyZone(long time)
	{
		return 0L;
	}

	// Token: 0x06000D72 RID: 3442 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D72")]
	[Address(RVA = "0x12D52A0", Offset = "0x12D52A0", VA = "0x12D52A0")]
	public string PassTimeSecondString(long passTime, bool isMstime = true)
	{
		return null;
	}

	// Token: 0x06000D73 RID: 3443 RVA: 0x000061F8 File Offset: 0x000043F8
	[Token(Token = "0x6000D73")]
	[Address(RVA = "0x12D55F4", Offset = "0x12D55F4", VA = "0x12D55F4")]
	public DateTime GetDateTime(long timeStamp)
	{
		return default(DateTime);
	}

	// Token: 0x06000D74 RID: 3444 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D74")]
	[Address(RVA = "0x12D56BC", Offset = "0x12D56BC", VA = "0x12D56BC")]
	public string TimeStampToTimeSimple(long timestamp, string format = "T")
	{
		return null;
	}

	// Token: 0x06000D75 RID: 3445 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D75")]
	[Address(RVA = "0x12D5738", Offset = "0x12D5738", VA = "0x12D5738")]
	public string TimeStampToTimeDate(long timestamp, string format = "yyyy-MM-dd")
	{
		return null;
	}

	// Token: 0x06000D76 RID: 3446 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D76")]
	[Address(RVA = "0x12D57B4", Offset = "0x12D57B4", VA = "0x12D57B4")]
	public string TimeStampToTimeDateMd(long timestamp, string format = "MM-dd")
	{
		return null;
	}

	// Token: 0x06000D77 RID: 3447 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D77")]
	[Address(RVA = "0x12D5830", Offset = "0x12D5830", VA = "0x12D5830")]
	public string TimeStampToTime(long timestamp, string format = "yyyy-MM-dd HH:mm:ss")
	{
		return null;
	}

	// Token: 0x06000D78 RID: 3448 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D78")]
	[Address(RVA = "0x12D58AC", Offset = "0x12D58AC", VA = "0x12D58AC")]
	public string GetUniversalTime(long timeStamp, string format = "yyyy-MM-dd HH:mm:ss")
	{
		return null;
	}

	// Token: 0x06000D79 RID: 3449 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D79")]
	[Address(RVA = "0x12D59C8", Offset = "0x12D59C8", VA = "0x12D59C8")]
	public string GetUniversalChatTime(long timeStamp, string format = "yyyy-MM-dd HH:mm:ss")
	{
		return null;
	}

	// Token: 0x06000D7A RID: 3450 RVA: 0x00006210 File Offset: 0x00004410
	[Token(Token = "0x6000D7A")]
	[Address(RVA = "0x12D5ACC", Offset = "0x12D5ACC", VA = "0x12D5ACC")]
	public int GetServerWeekDay()
	{
		return 0;
	}

	// Token: 0x06000D7B RID: 3451 RVA: 0x00006228 File Offset: 0x00004428
	[Token(Token = "0x6000D7B")]
	[Address(RVA = "0x12D5AEC", Offset = "0x12D5AEC", VA = "0x12D5AEC")]
	public int WeekDay(DateTime time)
	{
		return 0;
	}

	// Token: 0x06000D7C RID: 3452 RVA: 0x00006240 File Offset: 0x00004440
	[Token(Token = "0x6000D7C")]
	[Address(RVA = "0x12D5B54", Offset = "0x12D5B54", VA = "0x12D5B54")]
	public int GetWeekDay(long milliSecond)
	{
		return 0;
	}

	// Token: 0x06000D7D RID: 3453 RVA: 0x00006258 File Offset: 0x00004458
	[Token(Token = "0x6000D7D")]
	[Address(RVA = "0x12D5BC8", Offset = "0x12D5BC8", VA = "0x12D5BC8")]
	public int GetResSecondsTo24()
	{
		return 0;
	}

	// Token: 0x06000D7E RID: 3454 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D7E")]
	[Address(RVA = "0x12D5C2C", Offset = "0x12D5C2C", VA = "0x12D5C2C")]
	public ITimer RegisterTimer(float delaySec, Action onComplete)
	{
		return null;
	}

	// Token: 0x06000D7F RID: 3455 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D7F")]
	[Address(RVA = "0x12D5D80", Offset = "0x12D5D80", VA = "0x12D5D80")]
	public ITimer RegisterTimerRepeat(float delaySec, float repeatSec, Action onComplete)
	{
		return null;
	}

	// Token: 0x06000D80 RID: 3456 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D80")]
	[Address(RVA = "0x12D5E80", Offset = "0x12D5E80", VA = "0x12D5E80")]
	public void CancelTimer(ITimer timer)
	{
	}

	// Token: 0x06000D81 RID: 3457 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D81")]
	[Address(RVA = "0x12D4768", Offset = "0x12D4768", VA = "0x12D4768")]
	public void CancelAllTimers()
	{
	}

	// Token: 0x06000D82 RID: 3458 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D82")]
	[Address(RVA = "0x12D4940", Offset = "0x12D4940", VA = "0x12D4940")]
	private void UpdateAllTimers()
	{
	}

	// Token: 0x040010F1 RID: 4337
	[Token(Token = "0x40010F1")]
	[FieldOffset(Offset = "0x10")]
	private long m_ServerDeltaTime;

	// Token: 0x040010F2 RID: 4338
	[Token(Token = "0x40010F2")]
	[FieldOffset(Offset = "0x18")]
	private int m_TimeZone;

	// Token: 0x040010F3 RID: 4339
	[Token(Token = "0x40010F3")]
	[FieldOffset(Offset = "0x1C")]
	private int m_FrameCount;

	// Token: 0x040010F4 RID: 4340
	[Token(Token = "0x40010F4")]
	[FieldOffset(Offset = "0x20")]
	private bool m_IsNight;

	// Token: 0x040010F5 RID: 4341
	[Token(Token = "0x40010F5")]
	[FieldOffset(Offset = "0x21")]
	private bool _2Hours;

	// Token: 0x040010F6 RID: 4342
	[Token(Token = "0x40010F6")]
	[FieldOffset(Offset = "0x24")]
	private int _serverOffset;

	// Token: 0x040010F7 RID: 4343
	[Token(Token = "0x40010F7")]
	[FieldOffset(Offset = "0x28")]
	private DateTime _orignTime;

	// Token: 0x040010F9 RID: 4345
	[Token(Token = "0x40010F9")]
	[FieldOffset(Offset = "0x38")]
	private List<TimerComponent.Timer> timers;

	// Token: 0x040010FA RID: 4346
	[Token(Token = "0x40010FA")]
	[FieldOffset(Offset = "0x40")]
	private List<TimerComponent.Timer> timersToAdd;

	// Token: 0x020001F3 RID: 499
	[Token(Token = "0x20001F3")]
	private class Timer : ITimer
	{
		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x06000D83 RID: 3459 RVA: 0x00006270 File Offset: 0x00004470
		// (set) Token: 0x06000D84 RID: 3460 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001A9")]
		public bool isCompleted
		{
			[Token(Token = "0x6000D83")]
			[Address(RVA = "0x12D5FC8", Offset = "0x12D5FC8", VA = "0x12D5FC8", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000D84")]
			[Address(RVA = "0x12D5FD0", Offset = "0x12D5FD0", VA = "0x12D5FD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x06000D85 RID: 3461 RVA: 0x00006288 File Offset: 0x00004488
		// (set) Token: 0x06000D86 RID: 3462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001AA")]
		public bool isCancelled
		{
			[Token(Token = "0x6000D85")]
			[Address(RVA = "0x12D5FDC", Offset = "0x12D5FDC", VA = "0x12D5FDC", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000D86")]
			[Address(RVA = "0x12D5FE4", Offset = "0x12D5FE4", VA = "0x12D5FE4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x06000D87 RID: 3463 RVA: 0x000062A0 File Offset: 0x000044A0
		[Token(Token = "0x170001AB")]
		public bool isDone
		{
			[Token(Token = "0x6000D87")]
			[Address(RVA = "0x12D5FA8", Offset = "0x12D5FA8", VA = "0x12D5FA8", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000D88 RID: 3464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D88")]
		[Address(RVA = "0x12D5F10", Offset = "0x12D5F10", VA = "0x12D5F10")]
		public void Cancel()
		{
		}

		// Token: 0x06000D89 RID: 3465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D89")]
		[Address(RVA = "0x12D5D28", Offset = "0x12D5D28", VA = "0x12D5D28")]
		public Timer(float delaySec, float repeatSec, Action onComplete)
		{
		}

		// Token: 0x06000D8A RID: 3466 RVA: 0x000062B8 File Offset: 0x000044B8
		[Token(Token = "0x6000D8A")]
		[Address(RVA = "0x12D5FF0", Offset = "0x12D5FF0", VA = "0x12D5FF0")]
		private float GetNowTime()
		{
			return 0f;
		}

		// Token: 0x06000D8B RID: 3467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D8B")]
		[Address(RVA = "0x12D5F30", Offset = "0x12D5F30", VA = "0x12D5F30")]
		public void Update()
		{
		}

		// Token: 0x040010FD RID: 4349
		[Token(Token = "0x40010FD")]
		[FieldOffset(Offset = "0x18")]
		private readonly Action _onComplete;

		// Token: 0x040010FE RID: 4350
		[Token(Token = "0x40010FE")]
		[FieldOffset(Offset = "0x20")]
		private float repeatSec;

		// Token: 0x040010FF RID: 4351
		[Token(Token = "0x40010FF")]
		[FieldOffset(Offset = "0x24")]
		private float finishTime;
	}
}
