using System;
using System.Threading.Tasks;
using Il2CppDummyDll;

namespace Balaso
{
	// Token: 0x02000CF7 RID: 3319
	[Token(Token = "0x2000CF7")]
	public static class AppTrackingTransparency
	{
		// Token: 0x17000B35 RID: 2869
		// (get) Token: 0x06007C68 RID: 31848 RVA: 0x000548B8 File Offset: 0x00052AB8
		[Token(Token = "0x17000B35")]
		public static AppTrackingTransparency.AuthorizationStatus TrackingAuthorizationStatus
		{
			[Token(Token = "0x6007C68")]
			[Address(RVA = "0x319C1B8", Offset = "0x319C1B8", VA = "0x319C1B8")]
			get
			{
				return AppTrackingTransparency.AuthorizationStatus.NOT_DETERMINED;
			}
		}

		// Token: 0x06007C69 RID: 31849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C69")]
		[Address(RVA = "0x319C1C0", Offset = "0x319C1C0", VA = "0x319C1C0")]
		public static void UpdateConversionValue(int value)
		{
		}

		// Token: 0x06007C6A RID: 31850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C6A")]
		[Address(RVA = "0x319C1C4", Offset = "0x319C1C4", VA = "0x319C1C4")]
		public static void RegisterAppForAdNetworkAttribution()
		{
		}

		// Token: 0x06007C6B RID: 31851 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C6B")]
		[Address(RVA = "0x319C1C8", Offset = "0x319C1C8", VA = "0x319C1C8")]
		public static void RequestTrackingAuthorization()
		{
		}

		// Token: 0x06007C6C RID: 31852 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007C6C")]
		[Address(RVA = "0x319C1CC", Offset = "0x319C1CC", VA = "0x319C1CC")]
		public static string IdentifierForAdvertising()
		{
			return null;
		}

		// Token: 0x04003862 RID: 14434
		[Token(Token = "0x4003862")]
		[FieldOffset(Offset = "0x0")]
		private static TaskScheduler currentSynchronizationContext;

		// Token: 0x04003863 RID: 14435
		[Token(Token = "0x4003863")]
		[FieldOffset(Offset = "0x8")]
		public static Action<AppTrackingTransparency.AuthorizationStatus> OnAuthorizationRequestDone;

		// Token: 0x02000CF8 RID: 3320
		[Token(Token = "0x2000CF8")]
		public enum AuthorizationStatus
		{
			// Token: 0x04003865 RID: 14437
			[Token(Token = "0x4003865")]
			NOT_DETERMINED,
			// Token: 0x04003866 RID: 14438
			[Token(Token = "0x4003866")]
			RESTRICTED,
			// Token: 0x04003867 RID: 14439
			[Token(Token = "0x4003867")]
			DENIED,
			// Token: 0x04003868 RID: 14440
			[Token(Token = "0x4003868")]
			AUTHORIZED
		}
	}
}
