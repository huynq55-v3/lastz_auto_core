using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Google.Protobuf.Reflection
{
	// Token: 0x02000BBF RID: 3007
	[Token(Token = "0x2000BBF")]
	public abstract class DescriptorBase : IDescriptor
	{
		// Token: 0x0600739F RID: 29599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600739F")]
		[Address(RVA = "0x31A8DB0", Offset = "0x31A8DB0", VA = "0x31A8DB0")]
		internal DescriptorBase(FileDescriptor file, string fullName, int index)
		{
		}

		// Token: 0x170009B7 RID: 2487
		// (get) Token: 0x060073A0 RID: 29600 RVA: 0x000513D8 File Offset: 0x0004F5D8
		[Token(Token = "0x170009B7")]
		public int Index
		{
			[Token(Token = "0x60073A0")]
			[Address(RVA = "0x31A8E08", Offset = "0x31A8E08", VA = "0x31A8E08")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
		}

		// Token: 0x170009B8 RID: 2488
		// (get) Token: 0x060073A1 RID: 29601
		[Token(Token = "0x170009B8")]
		public abstract string Name
		{
			[Token(Token = "0x60073A1")]
			get;
		}

		// Token: 0x170009B9 RID: 2489
		// (get) Token: 0x060073A2 RID: 29602 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009B9")]
		public string FullName
		{
			[Token(Token = "0x60073A2")]
			[Address(RVA = "0x31A8E10", Offset = "0x31A8E10", VA = "0x31A8E10", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x170009BA RID: 2490
		// (get) Token: 0x060073A3 RID: 29603 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009BA")]
		public FileDescriptor File
		{
			[Token(Token = "0x60073A3")]
			[Address(RVA = "0x31A8E18", Offset = "0x31A8E18", VA = "0x31A8E18", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x170009BB RID: 2491
		// (get) Token: 0x060073A4 RID: 29604 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009BB")]
		public DescriptorDeclaration Declaration
		{
			[Token(Token = "0x60073A4")]
			[Address(RVA = "0x31A8E20", Offset = "0x31A8E20", VA = "0x31A8E20")]
			get
			{
				return null;
			}
		}

		// Token: 0x060073A5 RID: 29605 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60073A5")]
		[Address(RVA = "0x31A8ECC", Offset = "0x31A8ECC", VA = "0x31A8ECC", Slot = "8")]
		internal virtual IReadOnlyList<DescriptorBase> GetNestedDescriptorListForField(int fieldNumber)
		{
			return null;
		}
	}
}
