using System;
using System.IO;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Google.Protobuf
{
	// Token: 0x02000B28 RID: 2856
	[Token(Token = "0x2000B28")]
	public class MessageParser
	{
		// Token: 0x170007E7 RID: 2023
		// (get) Token: 0x06006CEC RID: 27884 RVA: 0x0004EAF8 File Offset: 0x0004CCF8
		[Token(Token = "0x170007E7")]
		internal bool DiscardUnknownFields
		{
			[Token(Token = "0x6006CEC")]
			[Address(RVA = "0x36F0C50", Offset = "0x36F0C50", VA = "0x36F0C50")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170007E8 RID: 2024
		// (get) Token: 0x06006CED RID: 27885 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007E8")]
		internal ExtensionRegistry Extensions
		{
			[Token(Token = "0x6006CED")]
			[Address(RVA = "0x36F0C58", Offset = "0x36F0C58", VA = "0x36F0C58")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x06006CEE RID: 27886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CEE")]
		[Address(RVA = "0x36F0C60", Offset = "0x36F0C60", VA = "0x36F0C60")]
		internal MessageParser(Func<IMessage> factory, bool discardUnknownFields, ExtensionRegistry extensions)
		{
		}

		// Token: 0x06006CEF RID: 27887 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CEF")]
		[Address(RVA = "0x36DCFE4", Offset = "0x36DCFE4", VA = "0x36DCFE4")]
		internal IMessage CreateTemplate()
		{
			return null;
		}

		// Token: 0x06006CF0 RID: 27888 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CF0")]
		[Address(RVA = "0x36F0CB4", Offset = "0x36F0CB4", VA = "0x36F0CB4")]
		public IMessage ParseFrom(byte[] data)
		{
			return null;
		}

		// Token: 0x06006CF1 RID: 27889 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CF1")]
		[Address(RVA = "0x36F0D6C", Offset = "0x36F0D6C", VA = "0x36F0D6C")]
		public IMessage ParseFrom(byte[] data, int offset, int length)
		{
			return null;
		}

		// Token: 0x06006CF2 RID: 27890 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CF2")]
		[Address(RVA = "0x36DD0BC", Offset = "0x36DD0BC", VA = "0x36DD0BC")]
		public IMessage ParseFrom(ByteString data)
		{
			return null;
		}

		// Token: 0x06006CF3 RID: 27891 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CF3")]
		[Address(RVA = "0x36F0DDC", Offset = "0x36F0DDC", VA = "0x36F0DDC")]
		public IMessage ParseFrom(Stream input)
		{
			return null;
		}

		// Token: 0x06006CF4 RID: 27892 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CF4")]
		[Address(RVA = "0x36F0E34", Offset = "0x36F0E34", VA = "0x36F0E34")]
		public IMessage ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		// Token: 0x06006CF5 RID: 27893 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CF5")]
		[Address(RVA = "0x36F0E8C", Offset = "0x36F0E8C", VA = "0x36F0E8C")]
		public IMessage ParseFrom(CodedInputStream input)
		{
			return null;
		}

		// Token: 0x06006CF6 RID: 27894 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CF6")]
		[Address(RVA = "0x36F0FF4", Offset = "0x36F0FF4", VA = "0x36F0FF4")]
		public IMessage ParseJson(string json)
		{
			return null;
		}

		// Token: 0x06006CF7 RID: 27895 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CF7")]
		[Address(RVA = "0x36F0EE4", Offset = "0x36F0EE4", VA = "0x36F0EE4")]
		internal void MergeFrom(IMessage message, CodedInputStream codedInput)
		{
		}

		// Token: 0x06006CF8 RID: 27896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CF8")]
		[Address(RVA = "0x36F0D0C", Offset = "0x36F0D0C", VA = "0x36F0D0C")]
		internal static void CheckMergedRequiredFields(IMessage message)
		{
		}

		// Token: 0x06006CF9 RID: 27897 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CF9")]
		[Address(RVA = "0x36F10C4", Offset = "0x36F10C4", VA = "0x36F10C4")]
		public MessageParser WithDiscardUnknownFields(bool discardUnknownFields)
		{
			return null;
		}

		// Token: 0x06006CFA RID: 27898 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CFA")]
		[Address(RVA = "0x36F1140", Offset = "0x36F1140", VA = "0x36F1140")]
		public MessageParser WithExtensionRegistry(ExtensionRegistry registry)
		{
			return null;
		}

		// Token: 0x04002BCF RID: 11215
		[Token(Token = "0x4002BCF")]
		[FieldOffset(Offset = "0x10")]
		private Func<IMessage> factory;
	}
}
