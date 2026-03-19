using System;
using Il2CppDummyDll;
using Sfs2X.Entities.Data;
using Sfs2X.Requests;
using UnityEngine.Scripting;

// Token: 0x0200023B RID: 571
[Token(Token = "0x200023B")]
[Preserve]
public class ChangePFdisplayName : BaseMessage
{
	// Token: 0x06000F66 RID: 3942 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F66")]
	[Address(RVA = "0x1BE08BC", Offset = "0x1BE08BC", VA = "0x1BE08BC")]
	public ChangePFdisplayName()
	{
	}

	// Token: 0x06000F67 RID: 3943 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F67")]
	[Address(RVA = "0x1BE0920", Offset = "0x1BE0920", VA = "0x1BE0920", Slot = "4")]
	public override string GetMsgId()
	{
		return null;
	}

	// Token: 0x06000F68 RID: 3944 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F68")]
	[Address(RVA = "0x1BE0960", Offset = "0x1BE0960", VA = "0x1BE0960", Slot = "8")]
	protected override IRequest CSSetData(params object[] args)
	{
		return null;
	}

	// Token: 0x06000F69 RID: 3945 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F69")]
	[Address(RVA = "0x1BE0B58", Offset = "0x1BE0B58", VA = "0x1BE0B58", Slot = "7")]
	protected override void CSHandleResponse(ISFSObject message)
	{
	}

	// Token: 0x04001211 RID: 4625
	[Token(Token = "0x4001211")]
	[FieldOffset(Offset = "0x0")]
	public static ChangePFdisplayName Instance;
}
