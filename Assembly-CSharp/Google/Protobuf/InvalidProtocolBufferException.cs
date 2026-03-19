using System;
using System.IO;
using Il2CppDummyDll;

namespace Google.Protobuf
{
	// Token: 0x02000B15 RID: 2837
	[Token(Token = "0x2000B15")]
	public sealed class InvalidProtocolBufferException : IOException
	{
		// Token: 0x06006C2C RID: 27692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C2C")]
		[Address(RVA = "0x36DBEEC", Offset = "0x36DBEEC", VA = "0x36DBEEC")]
		internal InvalidProtocolBufferException(string message)
		{
		}

		// Token: 0x06006C2D RID: 27693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C2D")]
		[Address(RVA = "0x36DD22C", Offset = "0x36DD22C", VA = "0x36DD22C")]
		internal InvalidProtocolBufferException(string message, Exception innerException)
		{
		}

		// Token: 0x06006C2E RID: 27694 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C2E")]
		[Address(RVA = "0x36DD234", Offset = "0x36DD234", VA = "0x36DD234")]
		internal static InvalidProtocolBufferException MoreDataAvailable()
		{
			return null;
		}

		// Token: 0x06006C2F RID: 27695 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C2F")]
		[Address(RVA = "0x36DD2A8", Offset = "0x36DD2A8", VA = "0x36DD2A8")]
		internal static InvalidProtocolBufferException TruncatedMessage()
		{
			return null;
		}

		// Token: 0x06006C30 RID: 27696 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C30")]
		[Address(RVA = "0x36DD31C", Offset = "0x36DD31C", VA = "0x36DD31C")]
		internal static InvalidProtocolBufferException NegativeSize()
		{
			return null;
		}

		// Token: 0x06006C31 RID: 27697 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C31")]
		[Address(RVA = "0x36DD390", Offset = "0x36DD390", VA = "0x36DD390")]
		internal static InvalidProtocolBufferException MalformedVarint()
		{
			return null;
		}

		// Token: 0x06006C32 RID: 27698 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C32")]
		[Address(RVA = "0x36DD404", Offset = "0x36DD404", VA = "0x36DD404")]
		internal static InvalidProtocolBufferException InvalidTag()
		{
			return null;
		}

		// Token: 0x06006C33 RID: 27699 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C33")]
		[Address(RVA = "0x36DD478", Offset = "0x36DD478", VA = "0x36DD478")]
		internal static InvalidProtocolBufferException InvalidWireType()
		{
			return null;
		}

		// Token: 0x06006C34 RID: 27700 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C34")]
		[Address(RVA = "0x36DD4EC", Offset = "0x36DD4EC", VA = "0x36DD4EC")]
		internal static InvalidProtocolBufferException InvalidBase64(Exception innerException)
		{
			return null;
		}

		// Token: 0x06006C35 RID: 27701 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C35")]
		[Address(RVA = "0x36DD568", Offset = "0x36DD568", VA = "0x36DD568")]
		internal static InvalidProtocolBufferException InvalidEndTag()
		{
			return null;
		}

		// Token: 0x06006C36 RID: 27702 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C36")]
		[Address(RVA = "0x36DD5DC", Offset = "0x36DD5DC", VA = "0x36DD5DC")]
		internal static InvalidProtocolBufferException RecursionLimitExceeded()
		{
			return null;
		}

		// Token: 0x06006C37 RID: 27703 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C37")]
		[Address(RVA = "0x36DD650", Offset = "0x36DD650", VA = "0x36DD650")]
		internal static InvalidProtocolBufferException JsonRecursionLimitExceeded()
		{
			return null;
		}

		// Token: 0x06006C38 RID: 27704 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C38")]
		[Address(RVA = "0x36DD6C4", Offset = "0x36DD6C4", VA = "0x36DD6C4")]
		internal static InvalidProtocolBufferException SizeLimitExceeded()
		{
			return null;
		}

		// Token: 0x06006C39 RID: 27705 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C39")]
		[Address(RVA = "0x36DD738", Offset = "0x36DD738", VA = "0x36DD738")]
		internal static InvalidProtocolBufferException InvalidMessageStreamTag()
		{
			return null;
		}

		// Token: 0x06006C3A RID: 27706 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C3A")]
		[Address(RVA = "0x36DD7AC", Offset = "0x36DD7AC", VA = "0x36DD7AC")]
		internal static InvalidProtocolBufferException MissingFields()
		{
			return null;
		}
	}
}
