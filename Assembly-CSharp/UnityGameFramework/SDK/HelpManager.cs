using System;
using Il2CppDummyDll;
using LitJson;

namespace UnityGameFramework.SDK
{
	// Token: 0x020004AE RID: 1198
	[Token(Token = "0x20004AE")]
	public class HelpManager
	{
		// Token: 0x17000548 RID: 1352
		// (get) Token: 0x06002379 RID: 9081 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000548")]
		public static HelpManager Instance
		{
			[Token(Token = "0x6002379")]
			[Address(RVA = "0x2A04350", Offset = "0x2A04350", VA = "0x2A04350")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600237A RID: 9082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600237A")]
		[Address(RVA = "0x2A043E8", Offset = "0x2A043E8", VA = "0x2A043E8")]
		public static void Purge()
		{
		}

		// Token: 0x0600237B RID: 9083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600237B")]
		[Address(RVA = "0x2A0443C", Offset = "0x2A0443C", VA = "0x2A0443C")]
		public void init()
		{
		}

		// Token: 0x0600237C RID: 9084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600237C")]
		[Address(RVA = "0x2A04440", Offset = "0x2A04440", VA = "0x2A04440")]
		public void setUserData()
		{
		}

		// Token: 0x0600237D RID: 9085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600237D")]
		[Address(RVA = "0x2A04444", Offset = "0x2A04444", VA = "0x2A04444")]
		public void showHelpShiftFAQ()
		{
		}

		// Token: 0x0600237E RID: 9086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600237E")]
		[Address(RVA = "0x2A04448", Offset = "0x2A04448", VA = "0x2A04448")]
		public void showHelpShiftFAQ(string itemId)
		{
		}

		// Token: 0x0600237F RID: 9087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600237F")]
		[Address(RVA = "0x2A0444C", Offset = "0x2A0444C", VA = "0x2A0444C")]
		public void showSingleFAQ(string itemId)
		{
		}

		// Token: 0x06002380 RID: 9088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002380")]
		[Address(RVA = "0x2A04450", Offset = "0x2A04450", VA = "0x2A04450")]
		public void showQACommunity()
		{
		}

		// Token: 0x06002381 RID: 9089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002381")]
		[Address(RVA = "0x2A04454", Offset = "0x2A04454", VA = "0x2A04454")]
		public void showBlog()
		{
		}

		// Token: 0x06002382 RID: 9090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002382")]
		[Address(RVA = "0x2A04458", Offset = "0x2A04458", VA = "0x2A04458")]
		public void showTranslateView()
		{
		}

		// Token: 0x06002383 RID: 9091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002383")]
		[Address(RVA = "0x2A0445C", Offset = "0x2A0445C", VA = "0x2A0445C")]
		public void goToHelpShift()
		{
		}

		// Token: 0x06002384 RID: 9092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002384")]
		[Address(RVA = "0x2A04460", Offset = "0x2A04460", VA = "0x2A04460")]
		public void showFAQ(string publishId)
		{
		}

		// Token: 0x06002385 RID: 9093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002385")]
		[Address(RVA = "0x2A04464", Offset = "0x2A04464", VA = "0x2A04464")]
		public void onShowGuest(string tagKey)
		{
		}

		// Token: 0x06002386 RID: 9094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002386")]
		[Address(RVA = "0x2A04468", Offset = "0x2A04468", VA = "0x2A04468")]
		public void showConversation(string tag)
		{
		}

		// Token: 0x06002387 RID: 9095 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002387")]
		[Address(RVA = "0x2A0446C", Offset = "0x2A0446C", VA = "0x2A0446C")]
		private JsonData GetTags(string tag)
		{
			return null;
		}

		// Token: 0x06002388 RID: 9096 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002388")]
		[Address(RVA = "0x2A044C8", Offset = "0x2A044C8", VA = "0x2A044C8")]
		private JsonData GetMetaData(string tag)
		{
			return null;
		}

		// Token: 0x06002389 RID: 9097 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002389")]
		[Address(RVA = "0x2A04524", Offset = "0x2A04524", VA = "0x2A04524")]
		private JsonData GetCustomData(string tag)
		{
			return null;
		}

		// Token: 0x0600238A RID: 9098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600238A")]
		[Address(RVA = "0x2A043E0", Offset = "0x2A043E0", VA = "0x2A043E0")]
		public HelpManager()
		{
		}

		// Token: 0x040020E3 RID: 8419
		[Token(Token = "0x40020E3")]
		[FieldOffset(Offset = "0x0")]
		private static HelpManager _instance;
	}
}
