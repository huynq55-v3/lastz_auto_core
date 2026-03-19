using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Google.Protobuf.Reflection
{
	// Token: 0x02000BF6 RID: 3062
	[Token(Token = "0x2000BF6")]
	public sealed class TypeRegistry
	{
		// Token: 0x17000A28 RID: 2600
		// (get) Token: 0x060074F0 RID: 29936 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A28")]
		public static TypeRegistry Empty
		{
			[Token(Token = "0x60074F0")]
			[Address(RVA = "0x31B635C", Offset = "0x31B635C", VA = "0x31B635C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x060074F1 RID: 29937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60074F1")]
		[Address(RVA = "0x31B63B4", Offset = "0x31B63B4", VA = "0x31B63B4")]
		private TypeRegistry(Dictionary<string, MessageDescriptor> fullNameToMessageMap)
		{
		}

		// Token: 0x060074F2 RID: 29938 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60074F2")]
		[Address(RVA = "0x31B63E4", Offset = "0x31B63E4", VA = "0x31B63E4")]
		public MessageDescriptor Find(string fullName)
		{
			return null;
		}

		// Token: 0x060074F3 RID: 29939 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60074F3")]
		[Address(RVA = "0x31B6454", Offset = "0x31B6454", VA = "0x31B6454")]
		public static TypeRegistry FromFiles(params FileDescriptor[] fileDescriptors)
		{
			return null;
		}

		// Token: 0x060074F4 RID: 29940 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60074F4")]
		[Address(RVA = "0x31B64A8", Offset = "0x31B64A8", VA = "0x31B64A8")]
		public static TypeRegistry FromFiles(IEnumerable<FileDescriptor> fileDescriptors)
		{
			return null;
		}

		// Token: 0x060074F5 RID: 29941 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60074F5")]
		[Address(RVA = "0x31B6ED0", Offset = "0x31B6ED0", VA = "0x31B6ED0")]
		public static TypeRegistry FromMessages(params MessageDescriptor[] messageDescriptors)
		{
			return null;
		}

		// Token: 0x060074F6 RID: 29942 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60074F6")]
		[Address(RVA = "0x31B6F24", Offset = "0x31B6F24", VA = "0x31B6F24")]
		public static TypeRegistry FromMessages(IEnumerable<MessageDescriptor> messageDescriptors)
		{
			return null;
		}

		// Token: 0x04002FB2 RID: 12210
		[Token(Token = "0x4002FB2")]
		[FieldOffset(Offset = "0x10")]
		private readonly Dictionary<string, MessageDescriptor> fullNameToMessageMap;

		// Token: 0x02000BF7 RID: 3063
		[Token(Token = "0x2000BF7")]
		private class Builder
		{
			// Token: 0x060074F8 RID: 29944 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60074F8")]
			[Address(RVA = "0x31B67D8", Offset = "0x31B67D8", VA = "0x31B67D8")]
			internal Builder()
			{
			}

			// Token: 0x060074F9 RID: 29945 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60074F9")]
			[Address(RVA = "0x31B68B0", Offset = "0x31B68B0", VA = "0x31B68B0")]
			internal void AddFile(FileDescriptor fileDescriptor)
			{
			}

			// Token: 0x060074FA RID: 29946 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60074FA")]
			[Address(RVA = "0x31B7150", Offset = "0x31B7150", VA = "0x31B7150")]
			private void AddMessage(MessageDescriptor messageDescriptor)
			{
			}

			// Token: 0x060074FB RID: 29947 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60074FB")]
			[Address(RVA = "0x31B6E5C", Offset = "0x31B6E5C", VA = "0x31B6E5C")]
			internal TypeRegistry Build()
			{
				return null;
			}

			// Token: 0x04002FB3 RID: 12211
			[Token(Token = "0x4002FB3")]
			[FieldOffset(Offset = "0x10")]
			private readonly Dictionary<string, MessageDescriptor> types;

			// Token: 0x04002FB4 RID: 12212
			[Token(Token = "0x4002FB4")]
			[FieldOffset(Offset = "0x18")]
			private readonly HashSet<string> fileDescriptorNames;
		}
	}
}
