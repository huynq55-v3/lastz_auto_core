using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace SDK
{
	// Token: 0x02000CF1 RID: 3313
	[Token(Token = "0x2000CF1")]
	public class TikTokContentsEvent : TikTokBaseEvent
	{
		// Token: 0x06007C56 RID: 31830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C56")]
		[Address(RVA = "0x319BC00", Offset = "0x319BC00", VA = "0x319BC00")]
		public TikTokContentsEvent(string eventName, Dictionary<string, object> properties, string eventId)
		{
		}

		// Token: 0x06007C57 RID: 31831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C57")]
		[Address(RVA = "0x319BC04", Offset = "0x319BC04", VA = "0x319BC04")]
		public void SetDescription(string description)
		{
		}

		// Token: 0x06007C58 RID: 31832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C58")]
		[Address(RVA = "0x319BC64", Offset = "0x319BC64", VA = "0x319BC64")]
		public void SetCurrency(TTCurrency currency)
		{
		}

		// Token: 0x06007C59 RID: 31833 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C59")]
		[Address(RVA = "0x319BCCC", Offset = "0x319BCCC", VA = "0x319BCCC")]
		public void SetValue(double value)
		{
		}

		// Token: 0x06007C5A RID: 31834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C5A")]
		[Address(RVA = "0x319BD5C", Offset = "0x319BD5C", VA = "0x319BD5C")]
		public void SetContentType(string contentType)
		{
		}

		// Token: 0x06007C5B RID: 31835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C5B")]
		[Address(RVA = "0x319BDBC", Offset = "0x319BDBC", VA = "0x319BDBC")]
		public void SetContentId(string contentId)
		{
		}

		// Token: 0x06007C5C RID: 31836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C5C")]
		[Address(RVA = "0x319BE1C", Offset = "0x319BE1C", VA = "0x319BE1C")]
		public void SetContents(TikTokContentParams[] contents)
		{
		}
	}
}
