using System;
using Il2CppDummyDll;
using Sfs2X.Entities.Data;
using Sfs2X.Util;

namespace Sfs2X.Bitswarm
{
	// Token: 0x02000A9B RID: 2715
	[Token(Token = "0x2000A9B")]
	public interface IMessage
	{
		// Token: 0x170006F6 RID: 1782
		// (get) Token: 0x0600676F RID: 26479
		// (set) Token: 0x06006770 RID: 26480
		[Token(Token = "0x170006F6")]
		int Id
		{
			[Token(Token = "0x600676F")]
			get;
			[Token(Token = "0x6006770")]
			set;
		}

		// Token: 0x170006F7 RID: 1783
		// (get) Token: 0x06006771 RID: 26481
		// (set) Token: 0x06006772 RID: 26482
		[Token(Token = "0x170006F7")]
		ISFSObject Content
		{
			[Token(Token = "0x6006771")]
			get;
			[Token(Token = "0x6006772")]
			set;
		}

		// Token: 0x170006F8 RID: 1784
		// (get) Token: 0x06006773 RID: 26483
		// (set) Token: 0x06006774 RID: 26484
		[Token(Token = "0x170006F8")]
		int TargetController
		{
			[Token(Token = "0x6006773")]
			get;
			[Token(Token = "0x6006774")]
			set;
		}

		// Token: 0x170006F9 RID: 1785
		// (get) Token: 0x06006775 RID: 26485
		// (set) Token: 0x06006776 RID: 26486
		[Token(Token = "0x170006F9")]
		bool IsEncrypted
		{
			[Token(Token = "0x6006775")]
			get;
			[Token(Token = "0x6006776")]
			set;
		}

		// Token: 0x170006FA RID: 1786
		// (get) Token: 0x06006777 RID: 26487
		// (set) Token: 0x06006778 RID: 26488
		[Token(Token = "0x170006FA")]
		bool IsUDP
		{
			[Token(Token = "0x6006777")]
			get;
			[Token(Token = "0x6006778")]
			set;
		}

		// Token: 0x170006FB RID: 1787
		// (get) Token: 0x06006779 RID: 26489
		// (set) Token: 0x0600677A RID: 26490
		[Token(Token = "0x170006FB")]
		long PacketId
		{
			[Token(Token = "0x6006779")]
			get;
			[Token(Token = "0x600677A")]
			set;
		}

		// Token: 0x170006FC RID: 1788
		// (get) Token: 0x0600677B RID: 26491
		// (set) Token: 0x0600677C RID: 26492
		[Token(Token = "0x170006FC")]
		ISFSObject Header
		{
			[Token(Token = "0x600677B")]
			get;
			[Token(Token = "0x600677C")]
			set;
		}

		// Token: 0x170006FD RID: 1789
		// (get) Token: 0x0600677D RID: 26493
		// (set) Token: 0x0600677E RID: 26494
		[Token(Token = "0x170006FD")]
		ByteArray RawData
		{
			[Token(Token = "0x600677D")]
			get;
			[Token(Token = "0x600677E")]
			set;
		}
	}
}
