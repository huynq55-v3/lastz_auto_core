using System;
using System.Collections;
using Il2CppDummyDll;

namespace Sfs2X.Core
{
	// Token: 0x02000A82 RID: 2690
	[Token(Token = "0x2000A82")]
	public class SFSEvent : BaseEvent
	{
		// Token: 0x060066A3 RID: 26275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066A3")]
		[Address(RVA = "0x33BDE14", Offset = "0x33BDE14", VA = "0x33BDE14")]
		public SFSEvent(string type, Hashtable data)
		{
		}

		// Token: 0x060066A4 RID: 26276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066A4")]
		[Address(RVA = "0x33BDE18", Offset = "0x33BDE18", VA = "0x33BDE18")]
		public SFSEvent(string type)
		{
		}

		// Token: 0x040028EB RID: 10475
		[Token(Token = "0x40028EB")]
		[FieldOffset(Offset = "0x0")]
		public static readonly string HANDSHAKE;

		// Token: 0x040028EC RID: 10476
		[Token(Token = "0x40028EC")]
		[FieldOffset(Offset = "0x8")]
		public static readonly string UDP_INIT;

		// Token: 0x040028ED RID: 10477
		[Token(Token = "0x40028ED")]
		[FieldOffset(Offset = "0x10")]
		public static readonly string CONNECTION;

		// Token: 0x040028EE RID: 10478
		[Token(Token = "0x40028EE")]
		[FieldOffset(Offset = "0x18")]
		public static readonly string PING_PONG;

		// Token: 0x040028EF RID: 10479
		[Token(Token = "0x40028EF")]
		[FieldOffset(Offset = "0x20")]
		public static readonly string SOCKET_ERROR;

		// Token: 0x040028F0 RID: 10480
		[Token(Token = "0x40028F0")]
		[FieldOffset(Offset = "0x28")]
		public static readonly string SOCKET_EXCEPTION;

		// Token: 0x040028F1 RID: 10481
		[Token(Token = "0x40028F1")]
		[FieldOffset(Offset = "0x30")]
		public static readonly string CONNECTION_LOST;

		// Token: 0x040028F2 RID: 10482
		[Token(Token = "0x40028F2")]
		[FieldOffset(Offset = "0x38")]
		public static readonly string CONNECTION_RETRY;

		// Token: 0x040028F3 RID: 10483
		[Token(Token = "0x40028F3")]
		[FieldOffset(Offset = "0x40")]
		public static readonly string CONNECTION_RESUME;

		// Token: 0x040028F4 RID: 10484
		[Token(Token = "0x40028F4")]
		[FieldOffset(Offset = "0x48")]
		public static readonly string CONNECTION_ATTEMPT_HTTP;

		// Token: 0x040028F5 RID: 10485
		[Token(Token = "0x40028F5")]
		[FieldOffset(Offset = "0x50")]
		public static readonly string CONFIG_LOAD_SUCCESS;

		// Token: 0x040028F6 RID: 10486
		[Token(Token = "0x40028F6")]
		[FieldOffset(Offset = "0x58")]
		public static readonly string CONFIG_LOAD_FAILURE;

		// Token: 0x040028F7 RID: 10487
		[Token(Token = "0x40028F7")]
		[FieldOffset(Offset = "0x60")]
		public static readonly string LOGIN;

		// Token: 0x040028F8 RID: 10488
		[Token(Token = "0x40028F8")]
		[FieldOffset(Offset = "0x68")]
		public static readonly string LOGIN_ERROR;

		// Token: 0x040028F9 RID: 10489
		[Token(Token = "0x40028F9")]
		[FieldOffset(Offset = "0x70")]
		public static readonly string LOGOUT;

		// Token: 0x040028FA RID: 10490
		[Token(Token = "0x40028FA")]
		[FieldOffset(Offset = "0x78")]
		public static readonly string PUBLIC_MESSAGE;

		// Token: 0x040028FB RID: 10491
		[Token(Token = "0x40028FB")]
		[FieldOffset(Offset = "0x80")]
		public static readonly string PRIVATE_MESSAGE;

		// Token: 0x040028FC RID: 10492
		[Token(Token = "0x40028FC")]
		[FieldOffset(Offset = "0x88")]
		public static readonly string MODERATOR_MESSAGE;

		// Token: 0x040028FD RID: 10493
		[Token(Token = "0x40028FD")]
		[FieldOffset(Offset = "0x90")]
		public static readonly string ADMIN_MESSAGE;

		// Token: 0x040028FE RID: 10494
		[Token(Token = "0x40028FE")]
		[FieldOffset(Offset = "0x98")]
		public static readonly string OBJECT_MESSAGE;

		// Token: 0x040028FF RID: 10495
		[Token(Token = "0x40028FF")]
		[FieldOffset(Offset = "0xA0")]
		public static readonly string EXTENSION_RESPONSE;

		// Token: 0x04002900 RID: 10496
		[Token(Token = "0x4002900")]
		[FieldOffset(Offset = "0xA8")]
		public static readonly string CRYPTO_INIT;
	}
}
