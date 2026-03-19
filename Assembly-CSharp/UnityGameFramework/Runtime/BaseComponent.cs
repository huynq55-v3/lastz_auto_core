using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UnityGameFramework.Runtime
{
	// Token: 0x020004AF RID: 1199
	[Token(Token = "0x20004AF")]
	[DisallowMultipleComponent]
	public sealed class BaseComponent : GameFrameworkComponent
	{
		// Token: 0x17000549 RID: 1353
		// (get) Token: 0x0600238B RID: 9099 RVA: 0x0000D7B8 File Offset: 0x0000B9B8
		// (set) Token: 0x0600238C RID: 9100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000549")]
		public int FrameRate
		{
			[Token(Token = "0x600238B")]
			[Address(RVA = "0x2A04580", Offset = "0x2A04580", VA = "0x2A04580")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600238C")]
			[Address(RVA = "0x2A04588", Offset = "0x2A04588", VA = "0x2A04588")]
			set
			{
			}
		}

		// Token: 0x1700054A RID: 1354
		// (get) Token: 0x0600238D RID: 9101 RVA: 0x0000D7D0 File Offset: 0x0000B9D0
		// (set) Token: 0x0600238E RID: 9102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700054A")]
		public float GameSpeed
		{
			[Token(Token = "0x600238D")]
			[Address(RVA = "0x2A04598", Offset = "0x2A04598", VA = "0x2A04598")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600238E")]
			[Address(RVA = "0x2A045A0", Offset = "0x2A045A0", VA = "0x2A045A0")]
			set
			{
			}
		}

		// Token: 0x1700054B RID: 1355
		// (get) Token: 0x0600238F RID: 9103 RVA: 0x0000D7E8 File Offset: 0x0000B9E8
		[Token(Token = "0x1700054B")]
		public bool IsGamePaused
		{
			[Token(Token = "0x600238F")]
			[Address(RVA = "0x2A045C8", Offset = "0x2A045C8", VA = "0x2A045C8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700054C RID: 1356
		// (get) Token: 0x06002390 RID: 9104 RVA: 0x0000D800 File Offset: 0x0000BA00
		[Token(Token = "0x1700054C")]
		public bool IsNormalGameSpeed
		{
			[Token(Token = "0x6002390")]
			[Address(RVA = "0x2A045D8", Offset = "0x2A045D8", VA = "0x2A045D8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700054D RID: 1357
		// (get) Token: 0x06002391 RID: 9105 RVA: 0x0000D818 File Offset: 0x0000BA18
		// (set) Token: 0x06002392 RID: 9106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700054D")]
		public bool RunInBackground
		{
			[Token(Token = "0x6002391")]
			[Address(RVA = "0x2A045EC", Offset = "0x2A045EC", VA = "0x2A045EC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002392")]
			[Address(RVA = "0x2A045F4", Offset = "0x2A045F4", VA = "0x2A045F4")]
			set
			{
			}
		}

		// Token: 0x1700054E RID: 1358
		// (get) Token: 0x06002393 RID: 9107 RVA: 0x0000D830 File Offset: 0x0000BA30
		// (set) Token: 0x06002394 RID: 9108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700054E")]
		public bool NeverSleep
		{
			[Token(Token = "0x6002393")]
			[Address(RVA = "0x2A04608", Offset = "0x2A04608", VA = "0x2A04608")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002394")]
			[Address(RVA = "0x2A04610", Offset = "0x2A04610", VA = "0x2A04610")]
			set
			{
			}
		}

		// Token: 0x1700054F RID: 1359
		// (get) Token: 0x06002395 RID: 9109 RVA: 0x0000D848 File Offset: 0x0000BA48
		// (set) Token: 0x06002396 RID: 9110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700054F")]
		public bool UsePtrForLua
		{
			[Token(Token = "0x6002395")]
			[Address(RVA = "0x2A04630", Offset = "0x2A04630", VA = "0x2A04630")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002396")]
			[Address(RVA = "0x2A04638", Offset = "0x2A04638", VA = "0x2A04638")]
			set
			{
			}
		}

		// Token: 0x06002397 RID: 9111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002397")]
		[Address(RVA = "0x2A04644", Offset = "0x2A04644", VA = "0x2A04644")]
		private void OnApplicationPause(bool pause)
		{
		}

		// Token: 0x06002398 RID: 9112 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002398")]
		[Address(RVA = "0x2A04694", Offset = "0x2A04694", VA = "0x2A04694", Slot = "4")]
		protected override void Awake()
		{
		}

		// Token: 0x06002399 RID: 9113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002399")]
		[Address(RVA = "0x2A04708", Offset = "0x2A04708", VA = "0x2A04708")]
		private void Start()
		{
		}

		// Token: 0x0600239A RID: 9114 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600239A")]
		[Address(RVA = "0x2A04758", Offset = "0x2A04758", VA = "0x2A04758")]
		public void PauseGame()
		{
		}

		// Token: 0x0600239B RID: 9115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600239B")]
		[Address(RVA = "0x2A0477C", Offset = "0x2A0477C", VA = "0x2A0477C")]
		public void ResumeGame()
		{
		}

		// Token: 0x0600239C RID: 9116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600239C")]
		[Address(RVA = "0x2A04794", Offset = "0x2A04794", VA = "0x2A04794")]
		public void ResetNormalGameSpeed()
		{
		}

		// Token: 0x0600239D RID: 9117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600239D")]
		[Address(RVA = "0x2A047BC", Offset = "0x2A047BC", VA = "0x2A047BC")]
		public BaseComponent()
		{
		}

		// Token: 0x040020E4 RID: 8420
		[Token(Token = "0x40020E4")]
		[FieldOffset(Offset = "0x18")]
		private float m_GameSpeedBeforePause;

		// Token: 0x040020E5 RID: 8421
		[Token(Token = "0x40020E5")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private int m_FrameRate;

		// Token: 0x040020E6 RID: 8422
		[Token(Token = "0x40020E6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float m_GameSpeed;

		// Token: 0x040020E7 RID: 8423
		[Token(Token = "0x40020E7")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private bool m_RunInBackground;

		// Token: 0x040020E8 RID: 8424
		[Token(Token = "0x40020E8")]
		[FieldOffset(Offset = "0x25")]
		[SerializeField]
		private bool m_NeverSleep;

		// Token: 0x040020E9 RID: 8425
		[Token(Token = "0x40020E9")]
		[FieldOffset(Offset = "0x26")]
		[SerializeField]
		private bool m_UsePtrForLua;

		// Token: 0x040020EA RID: 8426
		[Token(Token = "0x40020EA")]
		[FieldOffset(Offset = "0x28")]
		private int m_ScreenWidth;

		// Token: 0x040020EB RID: 8427
		[Token(Token = "0x40020EB")]
		[FieldOffset(Offset = "0x2C")]
		private int m_ScreenHeight;
	}
}
