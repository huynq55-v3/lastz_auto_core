using System;
using Il2CppDummyDll;
using Sfs2X.Entities.Data;

namespace Sfs2X.Requests
{
	// Token: 0x02000A57 RID: 2647
	[Token(Token = "0x2000A57")]
	public class LoginRequest : BaseRequest
	{
		// Token: 0x06006462 RID: 25698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006462")]
		[Address(RVA = "0x2DFC8F0", Offset = "0x2DFC8F0", VA = "0x2DFC8F0")]
		private void Init(string userName, string password, string zoneName, ISFSObject parameters)
		{
		}

		// Token: 0x06006463 RID: 25699 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006463")]
		[Address(RVA = "0x2DFC99C", Offset = "0x2DFC99C", VA = "0x2DFC99C")]
		public LoginRequest(string userName, string password, string zoneName, ISFSObject parameters)
		{
		}

		// Token: 0x06006464 RID: 25700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006464")]
		[Address(RVA = "0x2DFCA2C", Offset = "0x2DFCA2C", VA = "0x2DFCA2C")]
		public LoginRequest(string userName, string password, string zoneName)
		{
		}

		// Token: 0x06006465 RID: 25701 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006465")]
		[Address(RVA = "0x2DFCAB8", Offset = "0x2DFCAB8", VA = "0x2DFCAB8")]
		public LoginRequest(string userName, string password)
		{
		}

		// Token: 0x06006466 RID: 25702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006466")]
		[Address(RVA = "0x2DFCB38", Offset = "0x2DFCB38", VA = "0x2DFCB38")]
		public LoginRequest(string userName)
		{
		}

		// Token: 0x06006467 RID: 25703 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006467")]
		[Address(RVA = "0x2DFCBB4", Offset = "0x2DFCBB4", VA = "0x2DFCBB4", Slot = "12")]
		public override void Execute(SmartFox sfs)
		{
		}

		// Token: 0x06006468 RID: 25704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006468")]
		[Address(RVA = "0x2DFCE94", Offset = "0x2DFCE94", VA = "0x2DFCE94", Slot = "11")]
		public override void Validate(SmartFox sfs)
		{
		}

		// Token: 0x04002876 RID: 10358
		[Token(Token = "0x4002876")]
		[FieldOffset(Offset = "0x0")]
		public static readonly string KEY_ZONE_NAME;

		// Token: 0x04002877 RID: 10359
		[Token(Token = "0x4002877")]
		[FieldOffset(Offset = "0x8")]
		public static readonly string KEY_USER_NAME;

		// Token: 0x04002878 RID: 10360
		[Token(Token = "0x4002878")]
		[FieldOffset(Offset = "0x10")]
		public static readonly string KEY_PASSWORD;

		// Token: 0x04002879 RID: 10361
		[Token(Token = "0x4002879")]
		[FieldOffset(Offset = "0x18")]
		public static readonly string KEY_PARAMS;

		// Token: 0x0400287A RID: 10362
		[Token(Token = "0x400287A")]
		[FieldOffset(Offset = "0x20")]
		public static readonly string KEY_ID;

		// Token: 0x0400287B RID: 10363
		[Token(Token = "0x400287B")]
		[FieldOffset(Offset = "0x28")]
		public static readonly string KEY_RECONNECTION_SECONDS;

		// Token: 0x0400287C RID: 10364
		[Token(Token = "0x400287C")]
		[FieldOffset(Offset = "0x28")]
		private string zoneName;

		// Token: 0x0400287D RID: 10365
		[Token(Token = "0x400287D")]
		[FieldOffset(Offset = "0x30")]
		private string userName;

		// Token: 0x0400287E RID: 10366
		[Token(Token = "0x400287E")]
		[FieldOffset(Offset = "0x38")]
		private string password;

		// Token: 0x0400287F RID: 10367
		[Token(Token = "0x400287F")]
		[FieldOffset(Offset = "0x40")]
		private ISFSObject parameters;
	}
}
