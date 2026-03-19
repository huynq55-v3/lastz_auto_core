using System;
using System.Collections.Generic;
using Google.Protobuf.Collections;
using Il2CppDummyDll;

namespace Google.Protobuf.Reflection
{
	// Token: 0x02000BDE RID: 3038
	[Token(Token = "0x2000BDE")]
	public sealed class OneofDescriptor : DescriptorBase
	{
		// Token: 0x06007492 RID: 29842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007492")]
		[Address(RVA = "0x31B480C", Offset = "0x31B480C", VA = "0x31B480C")]
		internal OneofDescriptor(OneofDescriptorProto proto, FileDescriptor file, MessageDescriptor parent, int index, string clrName)
		{
		}

		// Token: 0x17000A19 RID: 2585
		// (get) Token: 0x06007493 RID: 29843 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A19")]
		public override string Name
		{
			[Token(Token = "0x6007493")]
			[Address(RVA = "0x31B5478", Offset = "0x31B5478", VA = "0x31B5478", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A1A RID: 2586
		// (get) Token: 0x06007494 RID: 29844 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A1A")]
		public MessageDescriptor ContainingType
		{
			[Token(Token = "0x6007494")]
			[Address(RVA = "0x31B5494", Offset = "0x31B5494", VA = "0x31B5494")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A1B RID: 2587
		// (get) Token: 0x06007495 RID: 29845 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A1B")]
		public IList<FieldDescriptor> Fields
		{
			[Token(Token = "0x6007495")]
			[Address(RVA = "0x31B549C", Offset = "0x31B549C", VA = "0x31B549C")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A1C RID: 2588
		// (get) Token: 0x06007496 RID: 29846 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A1C")]
		public OneofAccessor Accessor
		{
			[Token(Token = "0x6007496")]
			[Address(RVA = "0x31B54A4", Offset = "0x31B54A4", VA = "0x31B54A4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A1D RID: 2589
		// (get) Token: 0x06007497 RID: 29847 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A1D")]
		[Obsolete("CustomOptions are obsolete. Use GetOption")]
		public CustomOptions CustomOptions
		{
			[Token(Token = "0x6007497")]
			[Address(RVA = "0x31B54AC", Offset = "0x31B54AC", VA = "0x31B54AC")]
			get
			{
				return null;
			}
		}

		// Token: 0x06007498 RID: 29848 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007498")]
		public T GetOption<T>(Extension<OneofOptions, T> extension)
		{
			return null;
		}

		// Token: 0x06007499 RID: 29849 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007499")]
		public RepeatedField<T> GetOption<T>(RepeatedExtension<OneofOptions, T> extension)
		{
			return null;
		}

		// Token: 0x0600749A RID: 29850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600749A")]
		[Address(RVA = "0x31B3F48", Offset = "0x31B3F48", VA = "0x31B3F48")]
		internal void CrossLink()
		{
		}

		// Token: 0x0600749B RID: 29851 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600749B")]
		[Address(RVA = "0x31B52C0", Offset = "0x31B52C0", VA = "0x31B52C0")]
		private OneofAccessor CreateAccessor(string clrName)
		{
			return null;
		}

		// Token: 0x04002F90 RID: 12176
		[Token(Token = "0x4002F90")]
		[FieldOffset(Offset = "0x28")]
		private readonly OneofDescriptorProto proto;

		// Token: 0x04002F91 RID: 12177
		[Token(Token = "0x4002F91")]
		[FieldOffset(Offset = "0x30")]
		private MessageDescriptor containingType;

		// Token: 0x04002F92 RID: 12178
		[Token(Token = "0x4002F92")]
		[FieldOffset(Offset = "0x38")]
		private IList<FieldDescriptor> fields;

		// Token: 0x04002F93 RID: 12179
		[Token(Token = "0x4002F93")]
		[FieldOffset(Offset = "0x40")]
		private readonly OneofAccessor accessor;
	}
}
