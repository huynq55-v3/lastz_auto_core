using System;
using Il2CppDummyDll;
using Sfs2X.Entities.Data;

namespace Sfs2X.Requests
{
	// Token: 0x02000A54 RID: 2644
	[Token(Token = "0x2000A54")]
	public class ExtensionRequest : BaseRequest
	{
		// Token: 0x06006452 RID: 25682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006452")]
		[Address(RVA = "0x2DFC0CC", Offset = "0x2DFC0CC", VA = "0x2DFC0CC")]
		private void Init(string extCmd, ISFSObject parameters, bool useUDP)
		{
		}

		// Token: 0x06006453 RID: 25683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006453")]
		[Address(RVA = "0x2DFC110", Offset = "0x2DFC110", VA = "0x2DFC110")]
		public ExtensionRequest(string extCmd, ISFSObject parameters, bool useUDP)
		{
		}

		// Token: 0x06006454 RID: 25684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006454")]
		[Address(RVA = "0x2DFC1B8", Offset = "0x2DFC1B8", VA = "0x2DFC1B8")]
		public ExtensionRequest(string extCmd, ISFSObject parameters)
		{
		}

		// Token: 0x170006A6 RID: 1702
		// (get) Token: 0x06006455 RID: 25685 RVA: 0x0004C1A0 File Offset: 0x0004A3A0
		[Token(Token = "0x170006A6")]
		public bool UseUDP
		{
			[Token(Token = "0x6006455")]
			[Address(RVA = "0x2DFC250", Offset = "0x2DFC250", VA = "0x2DFC250")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06006456 RID: 25686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006456")]
		[Address(RVA = "0x2DFC258", Offset = "0x2DFC258", VA = "0x2DFC258", Slot = "11")]
		public override void Validate(SmartFox sfs)
		{
		}

		// Token: 0x06006457 RID: 25687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006457")]
		[Address(RVA = "0x2DFC4FC", Offset = "0x2DFC4FC", VA = "0x2DFC4FC", Slot = "12")]
		public override void Execute(SmartFox sfs)
		{
		}

		// Token: 0x0400286A RID: 10346
		[Token(Token = "0x400286A")]
		[FieldOffset(Offset = "0x0")]
		public static readonly string KEY_CMD;

		// Token: 0x0400286B RID: 10347
		[Token(Token = "0x400286B")]
		[FieldOffset(Offset = "0x8")]
		public static readonly string KEY_PARAMS;

		// Token: 0x0400286C RID: 10348
		[Token(Token = "0x400286C")]
		[FieldOffset(Offset = "0x10")]
		public static readonly string KEY_ROOM;

		// Token: 0x0400286D RID: 10349
		[Token(Token = "0x400286D")]
		[FieldOffset(Offset = "0x28")]
		private string extCmd;

		// Token: 0x0400286E RID: 10350
		[Token(Token = "0x400286E")]
		[FieldOffset(Offset = "0x30")]
		private ISFSObject parameters;

		// Token: 0x0400286F RID: 10351
		[Token(Token = "0x400286F")]
		[FieldOffset(Offset = "0x38")]
		private bool useUDP;
	}
}
