using System;
using Il2CppDummyDll;
using Sfs2X.Entities.Data;
using Sfs2X.Requests;
using UnityEngine.Scripting;

// Token: 0x0200023C RID: 572
[Token(Token = "0x200023C")]
[Preserve]
public class FcmTokenMessage : BaseMessage
{
	// Token: 0x06000F6A RID: 3946 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F6A")]
	[Address(RVA = "0x1BE0D58", Offset = "0x1BE0D58", VA = "0x1BE0D58")]
	public FcmTokenMessage()
	{
	}

	// Token: 0x06000F6B RID: 3947 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F6B")]
	[Address(RVA = "0x1BE0DBC", Offset = "0x1BE0DBC", VA = "0x1BE0DBC", Slot = "4")]
	public override string GetMsgId()
	{
		return null;
	}

	// Token: 0x06000F6C RID: 3948 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F6C")]
	[Address(RVA = "0x1BE0DFC", Offset = "0x1BE0DFC", VA = "0x1BE0DFC", Slot = "8")]
	protected override IRequest CSSetData(params object[] args)
	{
		return null;
	}

	// Token: 0x06000F6D RID: 3949 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F6D")]
	[Address(RVA = "0x1BE11D4", Offset = "0x1BE11D4", VA = "0x1BE11D4", Slot = "7")]
	protected override void CSHandleResponse(ISFSObject message)
	{
	}

	// Token: 0x04001212 RID: 4626
	[Token(Token = "0x4001212")]
	[FieldOffset(Offset = "0x0")]
	public static FcmTokenMessage Instance;

	// Token: 0x0200023D RID: 573
	[Token(Token = "0x200023D")]
	public class Request
	{
		// Token: 0x06000F6E RID: 3950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F6E")]
		[Address(RVA = "0x1BE11D8", Offset = "0x1BE11D8", VA = "0x1BE11D8")]
		public Request()
		{
		}

		// Token: 0x04001213 RID: 4627
		[Token(Token = "0x4001213")]
		[FieldOffset(Offset = "0x10")]
		public string token;

		// Token: 0x04001214 RID: 4628
		[Token(Token = "0x4001214")]
		[FieldOffset(Offset = "0x18")]
		public string fireabaseAppId;
	}
}
