using System;
using System.IO;
using Il2CppDummyDll;

namespace Google.Protobuf
{
	// Token: 0x02000B29 RID: 2857
	[Token(Token = "0x2000B29")]
	public sealed class MessageParser<T> : MessageParser where T : IMessage<T>
	{
		// Token: 0x06006CFB RID: 27899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CFB")]
		public MessageParser(Func<T> factory)
		{
		}

		// Token: 0x06006CFC RID: 27900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CFC")]
		internal MessageParser(Func<T> factory, bool discardUnknownFields, ExtensionRegistry extensions)
		{
		}

		// Token: 0x06006CFD RID: 27901 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CFD")]
		internal new T CreateTemplate()
		{
			return null;
		}

		// Token: 0x06006CFE RID: 27902 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CFE")]
		public new T ParseFrom(byte[] data)
		{
			return null;
		}

		// Token: 0x06006CFF RID: 27903 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CFF")]
		public new T ParseFrom(byte[] data, int offset, int length)
		{
			return null;
		}

		// Token: 0x06006D00 RID: 27904 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D00")]
		public new T ParseFrom(ByteString data)
		{
			return null;
		}

		// Token: 0x06006D01 RID: 27905 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D01")]
		public new T ParseFrom(Stream input)
		{
			return null;
		}

		// Token: 0x06006D02 RID: 27906 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D02")]
		public new T ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		// Token: 0x06006D03 RID: 27907 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D03")]
		public new T ParseFrom(CodedInputStream input)
		{
			return null;
		}

		// Token: 0x06006D04 RID: 27908 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D04")]
		public new T ParseJson(string json)
		{
			return null;
		}

		// Token: 0x06006D05 RID: 27909 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D05")]
		public new MessageParser<T> WithDiscardUnknownFields(bool discardUnknownFields)
		{
			return null;
		}

		// Token: 0x06006D06 RID: 27910 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D06")]
		public new MessageParser<T> WithExtensionRegistry(ExtensionRegistry registry)
		{
			return null;
		}

		// Token: 0x04002BD2 RID: 11218
		[Token(Token = "0x4002BD2")]
		[FieldOffset(Offset = "0x0")]
		private readonly Func<T> factory;
	}
}
