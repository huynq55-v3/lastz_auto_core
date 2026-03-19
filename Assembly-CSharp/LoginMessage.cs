using System;
using Il2CppDummyDll;
using Sfs2X.Entities.Data;
using Sfs2X.Requests;
using UnityEngine.Scripting;

// Token: 0x0200023E RID: 574
[Token(Token = "0x200023E")]
[Preserve]
public class LoginMessage : BaseMessage
{
	// Token: 0x06000F6F RID: 3951 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F6F")]
	[Address(RVA = "0x1BE11E0", Offset = "0x1BE11E0", VA = "0x1BE11E0")]
	public LoginMessage()
	{
	}

	// Token: 0x06000F70 RID: 3952 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F70")]
	[Address(RVA = "0x1BE1244", Offset = "0x1BE1244", VA = "0x1BE1244", Slot = "4")]
	public override string GetMsgId()
	{
		return null;
	}

	// Token: 0x06000F71 RID: 3953 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F71")]
	[Address(RVA = "0x1BE1284", Offset = "0x1BE1284", VA = "0x1BE1284", Slot = "8")]
	protected override IRequest CSSetData(params object[] args)
	{
		return null;
	}

	// Token: 0x06000F72 RID: 3954 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F72")]
	[Address(RVA = "0x1BE28B0", Offset = "0x1BE28B0", VA = "0x1BE28B0", Slot = "7")]
	protected override void CSHandleResponse(ISFSObject message)
	{
	}

	// Token: 0x04001215 RID: 4629
	[Token(Token = "0x4001215")]
	[FieldOffset(Offset = "0x0")]
	public static LoginMessage Instance;

	// Token: 0x04001216 RID: 4630
	[Token(Token = "0x4001216")]
	[FieldOffset(Offset = "0x10")]
	public Action<ISFSObject> onLoginResponse;

	// Token: 0x04001217 RID: 4631
	[Token(Token = "0x4001217")]
	[FieldOffset(Offset = "0x18")]
	public Action<object> onLuaLoginResponse;
}
