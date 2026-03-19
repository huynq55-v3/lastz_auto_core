using System;
using Il2CppDummyDll;
using Sfs2X.Entities.Data;
using Sfs2X.Requests;
using UnityEngine.Scripting;
using XLua;

// Token: 0x02000237 RID: 567
[Token(Token = "0x2000237")]
[Hotfix(HotfixFlag.Stateless)]
[Preserve]
public class UserBindGaidMessage : BaseMessage
{
	// Token: 0x06000F57 RID: 3927 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F57")]
	[Address(RVA = "0x1BDFD54", Offset = "0x1BDFD54", VA = "0x1BDFD54")]
	public UserBindGaidMessage()
	{
	}

	// Token: 0x06000F58 RID: 3928 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F58")]
	[Address(RVA = "0x1BDFDC0", Offset = "0x1BDFDC0", VA = "0x1BDFDC0", Slot = "4")]
	public override string GetMsgId()
	{
		return null;
	}

	// Token: 0x06000F59 RID: 3929 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F59")]
	[Address(RVA = "0x1BDFE00", Offset = "0x1BDFE00", VA = "0x1BDFE00", Slot = "8")]
	protected override IRequest CSSetData(params object[] args)
	{
		return null;
	}

	// Token: 0x06000F5A RID: 3930 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F5A")]
	[Address(RVA = "0x1BE00E0", Offset = "0x1BE00E0", VA = "0x1BE00E0", Slot = "7")]
	protected override void CSHandleResponse(ISFSObject message)
	{
	}

	// Token: 0x0400120F RID: 4623
	[Token(Token = "0x400120F")]
	[FieldOffset(Offset = "0x0")]
	public static UserBindGaidMessage Instance;

	// Token: 0x02000238 RID: 568
	[Token(Token = "0x2000238")]
	public class Request
	{
		// Token: 0x06000F5B RID: 3931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F5B")]
		[Address(RVA = "0x1BE00E4", Offset = "0x1BE00E4", VA = "0x1BE00E4")]
		public Request()
		{
		}

		// Token: 0x04001210 RID: 4624
		[Token(Token = "0x4001210")]
		[FieldOffset(Offset = "0x10")]
		public string gaid;
	}
}
