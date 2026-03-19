using System;
using Il2CppDummyDll;
using Sfs2X.Entities.Data;
using Sfs2X.Requests;
using UnityEngine.Scripting;

// Token: 0x02000239 RID: 569
[Token(Token = "0x2000239")]
[Preserve]
public abstract class BaseMessage
{
	// Token: 0x06000F5C RID: 3932
	[Token(Token = "0x6000F5C")]
	public abstract string GetMsgId();

	// Token: 0x06000F5D RID: 3933 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F5D")]
	[Address(RVA = "0x1BE00EC", Offset = "0x1BE00EC", VA = "0x1BE00EC", Slot = "5")]
	public virtual void Handle(ISFSObject message)
	{
	}

	// Token: 0x06000F5E RID: 3934 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F5E")]
	[Address(RVA = "0x1BE023C", Offset = "0x1BE023C", VA = "0x1BE023C")]
	private static void ShowErrorMessage(ISFSObject message)
	{
	}

	// Token: 0x06000F5F RID: 3935 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F5F")]
	[Address(RVA = "0x1BE0578", Offset = "0x1BE0578", VA = "0x1BE0578", Slot = "6")]
	public virtual void Send(params object[] args)
	{
	}

	// Token: 0x06000F60 RID: 3936 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F60")]
	[Address(RVA = "0x1BE06B0", Offset = "0x1BE06B0", VA = "0x1BE06B0", Slot = "7")]
	protected virtual void CSHandleResponse(ISFSObject message)
	{
	}

	// Token: 0x06000F61 RID: 3937 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F61")]
	[Address(RVA = "0x1BE06B4", Offset = "0x1BE06B4", VA = "0x1BE06B4", Slot = "8")]
	protected virtual IRequest CSSetData(params object[] args)
	{
		return null;
	}

	// Token: 0x06000F62 RID: 3938 RVA: 0x00006BE8 File Offset: 0x00004DE8
	[Token(Token = "0x6000F62")]
	[Address(RVA = "0x1BE08A4", Offset = "0x1BE08A4", VA = "0x1BE08A4", Slot = "9")]
	protected virtual bool showErrorCode()
	{
		return default(bool);
	}

	// Token: 0x06000F63 RID: 3939 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F63")]
	[Address(RVA = "0x1BDFDB8", Offset = "0x1BDFDB8", VA = "0x1BDFDB8")]
	protected BaseMessage()
	{
	}
}
