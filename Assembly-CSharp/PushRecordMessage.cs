using System;
using Il2CppDummyDll;
using Sfs2X.Entities.Data;
using Sfs2X.Requests;
using UnityEngine.Scripting;

// Token: 0x02000240 RID: 576
[Token(Token = "0x2000240")]
[Preserve]
public class PushRecordMessage : BaseMessage
{
	// Token: 0x06000F78 RID: 3960 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F78")]
	[Address(RVA = "0x1BE3B78", Offset = "0x1BE3B78", VA = "0x1BE3B78")]
	public PushRecordMessage()
	{
	}

	// Token: 0x06000F79 RID: 3961 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F79")]
	[Address(RVA = "0x1BE3BDC", Offset = "0x1BE3BDC", VA = "0x1BE3BDC", Slot = "4")]
	public override string GetMsgId()
	{
		return null;
	}

	// Token: 0x06000F7A RID: 3962 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F7A")]
	[Address(RVA = "0x1BE3C1C", Offset = "0x1BE3C1C", VA = "0x1BE3C1C", Slot = "8")]
	protected override IRequest CSSetData(params object[] args)
	{
		return null;
	}

	// Token: 0x06000F7B RID: 3963 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F7B")]
	[Address(RVA = "0x1BE3F74", Offset = "0x1BE3F74", VA = "0x1BE3F74", Slot = "7")]
	protected override void CSHandleResponse(ISFSObject message)
	{
	}

	// Token: 0x0400121A RID: 4634
	[Token(Token = "0x400121A")]
	[FieldOffset(Offset = "0x0")]
	public static PushRecordMessage Instance;

	// Token: 0x02000241 RID: 577
	[Token(Token = "0x2000241")]
	public class Request
	{
		// Token: 0x06000F7C RID: 3964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F7C")]
		[Address(RVA = "0x1BE3F94", Offset = "0x1BE3F94", VA = "0x1BE3F94")]
		public Request()
		{
		}

		// Token: 0x0400121B RID: 4635
		[Token(Token = "0x400121B")]
		[FieldOffset(Offset = "0x10")]
		public string record;

		// Token: 0x0400121C RID: 4636
		[Token(Token = "0x400121C")]
		[FieldOffset(Offset = "0x18")]
		public string click;
	}
}
