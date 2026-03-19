using System;
using Google.Protobuf.Collections;
using Il2CppDummyDll;

namespace Google.Protobuf.Reflection
{
	// Token: 0x02000BC7 RID: 3015
	[Token(Token = "0x2000BC7")]
	public sealed class EnumValueDescriptor : DescriptorBase
	{
		// Token: 0x060073D3 RID: 29651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073D3")]
		[Address(RVA = "0x31ABCF0", Offset = "0x31ABCF0", VA = "0x31ABCF0")]
		internal EnumValueDescriptor(EnumValueDescriptorProto proto, FileDescriptor file, EnumDescriptor parent, int index)
		{
		}

		// Token: 0x170009CC RID: 2508
		// (get) Token: 0x060073D4 RID: 29652 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009CC")]
		internal EnumValueDescriptorProto Proto
		{
			[Token(Token = "0x60073D4")]
			[Address(RVA = "0x31ABDD4", Offset = "0x31ABDD4", VA = "0x31ABDD4")]
			get
			{
				return null;
			}
		}

		// Token: 0x170009CD RID: 2509
		// (get) Token: 0x060073D5 RID: 29653 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009CD")]
		public override string Name
		{
			[Token(Token = "0x60073D5")]
			[Address(RVA = "0x31ABDDC", Offset = "0x31ABDDC", VA = "0x31ABDDC", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x170009CE RID: 2510
		// (get) Token: 0x060073D6 RID: 29654 RVA: 0x00051450 File Offset: 0x0004F650
		[Token(Token = "0x170009CE")]
		public int Number
		{
			[Token(Token = "0x60073D6")]
			[Address(RVA = "0x31AB224", Offset = "0x31AB224", VA = "0x31AB224")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170009CF RID: 2511
		// (get) Token: 0x060073D7 RID: 29655 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009CF")]
		public EnumDescriptor EnumDescriptor
		{
			[Token(Token = "0x60073D7")]
			[Address(RVA = "0x31ABDF8", Offset = "0x31ABDF8", VA = "0x31ABDF8")]
			get
			{
				return null;
			}
		}

		// Token: 0x170009D0 RID: 2512
		// (get) Token: 0x060073D8 RID: 29656 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009D0")]
		[Obsolete("CustomOptions are obsolete. Use GetOption")]
		public CustomOptions CustomOptions
		{
			[Token(Token = "0x60073D8")]
			[Address(RVA = "0x31ABE00", Offset = "0x31ABE00", VA = "0x31ABE00")]
			get
			{
				return null;
			}
		}

		// Token: 0x060073D9 RID: 29657 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60073D9")]
		public T GetOption<T>(Extension<EnumValueOptions, T> extension)
		{
			return null;
		}

		// Token: 0x060073DA RID: 29658 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60073DA")]
		public RepeatedField<T> GetOption<T>(RepeatedExtension<EnumValueOptions, T> extension)
		{
			return null;
		}

		// Token: 0x04002F21 RID: 12065
		[Token(Token = "0x4002F21")]
		[FieldOffset(Offset = "0x28")]
		private readonly EnumDescriptor enumDescriptor;

		// Token: 0x04002F22 RID: 12066
		[Token(Token = "0x4002F22")]
		[FieldOffset(Offset = "0x30")]
		private readonly EnumValueDescriptorProto proto;
	}
}
