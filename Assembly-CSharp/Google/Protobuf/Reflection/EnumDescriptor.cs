using System;
using System.Collections.Generic;
using Google.Protobuf.Collections;
using Il2CppDummyDll;

namespace Google.Protobuf.Reflection
{
	// Token: 0x02000BC5 RID: 3013
	[Token(Token = "0x2000BC5")]
	public sealed class EnumDescriptor : DescriptorBase
	{
		// Token: 0x060073C5 RID: 29637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073C5")]
		[Address(RVA = "0x31AB7A4", Offset = "0x31AB7A4", VA = "0x31AB7A4")]
		internal EnumDescriptor(EnumDescriptorProto proto, FileDescriptor file, MessageDescriptor parent, int index, Type clrType)
		{
		}

		// Token: 0x170009C6 RID: 2502
		// (get) Token: 0x060073C6 RID: 29638 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009C6")]
		internal EnumDescriptorProto Proto
		{
			[Token(Token = "0x60073C6")]
			[Address(RVA = "0x31ABA70", Offset = "0x31ABA70", VA = "0x31ABA70")]
			get
			{
				return null;
			}
		}

		// Token: 0x170009C7 RID: 2503
		// (get) Token: 0x060073C7 RID: 29639 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009C7")]
		public override string Name
		{
			[Token(Token = "0x60073C7")]
			[Address(RVA = "0x31ABA78", Offset = "0x31ABA78", VA = "0x31ABA78", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x060073C8 RID: 29640 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60073C8")]
		[Address(RVA = "0x31ABA94", Offset = "0x31ABA94", VA = "0x31ABA94", Slot = "8")]
		internal override IReadOnlyList<DescriptorBase> GetNestedDescriptorListForField(int fieldNumber)
		{
			return null;
		}

		// Token: 0x170009C8 RID: 2504
		// (get) Token: 0x060073C9 RID: 29641 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009C8")]
		public Type ClrType
		{
			[Token(Token = "0x60073C9")]
			[Address(RVA = "0x31ABB0C", Offset = "0x31ABB0C", VA = "0x31ABB0C")]
			get
			{
				return null;
			}
		}

		// Token: 0x170009C9 RID: 2505
		// (get) Token: 0x060073CA RID: 29642 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009C9")]
		public MessageDescriptor ContainingType
		{
			[Token(Token = "0x60073CA")]
			[Address(RVA = "0x31ABB14", Offset = "0x31ABB14", VA = "0x31ABB14")]
			get
			{
				return null;
			}
		}

		// Token: 0x170009CA RID: 2506
		// (get) Token: 0x060073CB RID: 29643 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009CA")]
		public IList<EnumValueDescriptor> Values
		{
			[Token(Token = "0x60073CB")]
			[Address(RVA = "0x31ABB1C", Offset = "0x31ABB1C", VA = "0x31ABB1C")]
			get
			{
				return null;
			}
		}

		// Token: 0x060073CC RID: 29644 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60073CC")]
		[Address(RVA = "0x31ABB24", Offset = "0x31ABB24", VA = "0x31ABB24")]
		public EnumValueDescriptor FindValueByNumber(int number)
		{
			return null;
		}

		// Token: 0x060073CD RID: 29645 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60073CD")]
		[Address(RVA = "0x31ABB50", Offset = "0x31ABB50", VA = "0x31ABB50")]
		public EnumValueDescriptor FindValueByName(string name)
		{
			return null;
		}

		// Token: 0x170009CB RID: 2507
		// (get) Token: 0x060073CE RID: 29646 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009CB")]
		[Obsolete("CustomOptions are obsolete. Use GetOption")]
		public CustomOptions CustomOptions
		{
			[Token(Token = "0x60073CE")]
			[Address(RVA = "0x31ABBDC", Offset = "0x31ABBDC", VA = "0x31ABBDC")]
			get
			{
				return null;
			}
		}

		// Token: 0x060073CF RID: 29647 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60073CF")]
		public T GetOption<T>(Extension<EnumOptions, T> extension)
		{
			return null;
		}

		// Token: 0x060073D0 RID: 29648 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60073D0")]
		public RepeatedField<T> GetOption<T>(RepeatedExtension<EnumOptions, T> extension)
		{
			return null;
		}

		// Token: 0x04002F1B RID: 12059
		[Token(Token = "0x4002F1B")]
		[FieldOffset(Offset = "0x28")]
		private readonly EnumDescriptorProto proto;

		// Token: 0x04002F1C RID: 12060
		[Token(Token = "0x4002F1C")]
		[FieldOffset(Offset = "0x30")]
		private readonly MessageDescriptor containingType;

		// Token: 0x04002F1D RID: 12061
		[Token(Token = "0x4002F1D")]
		[FieldOffset(Offset = "0x38")]
		private readonly IList<EnumValueDescriptor> values;

		// Token: 0x04002F1E RID: 12062
		[Token(Token = "0x4002F1E")]
		[FieldOffset(Offset = "0x40")]
		private readonly Type clrType;
	}
}
