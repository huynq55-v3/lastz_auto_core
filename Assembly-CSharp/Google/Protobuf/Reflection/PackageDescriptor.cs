using System;
using Il2CppDummyDll;

namespace Google.Protobuf.Reflection
{
	// Token: 0x02000BE0 RID: 3040
	[Token(Token = "0x2000BE0")]
	internal sealed class PackageDescriptor : IDescriptor
	{
		// Token: 0x060074A1 RID: 29857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60074A1")]
		[Address(RVA = "0x31AA09C", Offset = "0x31AA09C", VA = "0x31AA09C")]
		internal PackageDescriptor(string name, string fullName, FileDescriptor file)
		{
		}

		// Token: 0x17000A20 RID: 2592
		// (get) Token: 0x060074A2 RID: 29858 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A20")]
		public string Name
		{
			[Token(Token = "0x60074A2")]
			[Address(RVA = "0x31B55F8", Offset = "0x31B55F8", VA = "0x31B55F8", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A21 RID: 2593
		// (get) Token: 0x060074A3 RID: 29859 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A21")]
		public string FullName
		{
			[Token(Token = "0x60074A3")]
			[Address(RVA = "0x31B5600", Offset = "0x31B5600", VA = "0x31B5600", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A22 RID: 2594
		// (get) Token: 0x060074A4 RID: 29860 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A22")]
		public FileDescriptor File
		{
			[Token(Token = "0x60074A4")]
			[Address(RVA = "0x31B5608", Offset = "0x31B5608", VA = "0x31B5608", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x04002F96 RID: 12182
		[Token(Token = "0x4002F96")]
		[FieldOffset(Offset = "0x10")]
		private readonly string name;

		// Token: 0x04002F97 RID: 12183
		[Token(Token = "0x4002F97")]
		[FieldOffset(Offset = "0x18")]
		private readonly string fullName;

		// Token: 0x04002F98 RID: 12184
		[Token(Token = "0x4002F98")]
		[FieldOffset(Offset = "0x20")]
		private readonly FileDescriptor file;
	}
}
