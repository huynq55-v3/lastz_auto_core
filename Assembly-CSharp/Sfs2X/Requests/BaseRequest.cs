using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Sfs2X.Bitswarm;
using Sfs2X.Entities.Data;

namespace Sfs2X.Requests
{
	// Token: 0x02000A53 RID: 2643
	[Token(Token = "0x2000A53")]
	public class BaseRequest : IRequest
	{
		// Token: 0x06006444 RID: 25668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006444")]
		[Address(RVA = "0x2DFBC48", Offset = "0x2DFBC48", VA = "0x2DFBC48")]
		public BaseRequest(RequestType tp)
		{
		}

		// Token: 0x06006445 RID: 25669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006445")]
		[Address(RVA = "0x2DFBCE4", Offset = "0x2DFBCE4", VA = "0x2DFBCE4")]
		public BaseRequest(int id)
		{
		}

		// Token: 0x06006446 RID: 25670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006446")]
		[Address(RVA = "0x2DFBD28", Offset = "0x2DFBD28", VA = "0x2DFBD28", Slot = "11")]
		public virtual void Validate(SmartFox sfs)
		{
		}

		// Token: 0x06006447 RID: 25671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006447")]
		[Address(RVA = "0x2DFBD2C", Offset = "0x2DFBD2C", VA = "0x2DFBD2C", Slot = "12")]
		public virtual void Execute(SmartFox sfs)
		{
		}

		// Token: 0x170006A1 RID: 1697
		// (get) Token: 0x06006448 RID: 25672 RVA: 0x0004C140 File Offset: 0x0004A340
		// (set) Token: 0x06006449 RID: 25673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006A1")]
		public int TargetController
		{
			[Token(Token = "0x6006448")]
			[Address(RVA = "0x2DFBD30", Offset = "0x2DFBD30", VA = "0x2DFBD30", Slot = "6")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6006449")]
			[Address(RVA = "0x2DFBD38", Offset = "0x2DFBD38", VA = "0x2DFBD38", Slot = "7")]
			set
			{
			}
		}

		// Token: 0x170006A2 RID: 1698
		// (get) Token: 0x0600644A RID: 25674 RVA: 0x0004C158 File Offset: 0x0004A358
		// (set) Token: 0x0600644B RID: 25675 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006A2")]
		public bool IsEncrypted
		{
			[Token(Token = "0x600644A")]
			[Address(RVA = "0x2DFBD40", Offset = "0x2DFBD40", VA = "0x2DFBD40", Slot = "8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600644B")]
			[Address(RVA = "0x2DFBD48", Offset = "0x2DFBD48", VA = "0x2DFBD48", Slot = "9")]
			set
			{
			}
		}

		// Token: 0x170006A3 RID: 1699
		// (get) Token: 0x0600644C RID: 25676 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006A3")]
		public IMessage Message
		{
			[Token(Token = "0x600644C")]
			[Address(RVA = "0x2DFBD54", Offset = "0x2DFBD54", VA = "0x2DFBD54", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x170006A4 RID: 1700
		// (get) Token: 0x0600644D RID: 25677 RVA: 0x0004C170 File Offset: 0x0004A370
		// (set) Token: 0x0600644E RID: 25678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006A4")]
		public int Id
		{
			[Token(Token = "0x600644D")]
			[Address(RVA = "0x2DFC010", Offset = "0x2DFC010", VA = "0x2DFC010")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x600644E")]
			[Address(RVA = "0x2DFC018", Offset = "0x2DFC018", VA = "0x2DFC018")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006A5 RID: 1701
		// (get) Token: 0x0600644F RID: 25679 RVA: 0x0004C188 File Offset: 0x0004A388
		// (set) Token: 0x06006450 RID: 25680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006A5")]
		public RequestType Type
		{
			[Token(Token = "0x600644F")]
			[Address(RVA = "0x2DFC020", Offset = "0x2DFC020", VA = "0x2DFC020")]
			get
			{
				return RequestType.Handshake;
			}
			[Token(Token = "0x6006450")]
			[Address(RVA = "0x2DFC028", Offset = "0x2DFC028", VA = "0x2DFC028")]
			set
			{
			}
		}

		// Token: 0x04002864 RID: 10340
		[Token(Token = "0x4002864")]
		[FieldOffset(Offset = "0x0")]
		public static readonly string KEY_ERROR_CODE;

		// Token: 0x04002865 RID: 10341
		[Token(Token = "0x4002865")]
		[FieldOffset(Offset = "0x8")]
		public static readonly string KEY_ERROR_PARAMS;

		// Token: 0x04002866 RID: 10342
		[Token(Token = "0x4002866")]
		[FieldOffset(Offset = "0x10")]
		protected ISFSObject sfso;

		// Token: 0x04002867 RID: 10343
		[Token(Token = "0x4002867")]
		[FieldOffset(Offset = "0x18")]
		protected int targetController;

		// Token: 0x04002868 RID: 10344
		[Token(Token = "0x4002868")]
		[FieldOffset(Offset = "0x1C")]
		private bool isEncrypted;
	}
}
