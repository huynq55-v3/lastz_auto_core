using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Collections;
using Il2CppDummyDll;

namespace Google.Protobuf.Reflection
{
	// Token: 0x02000BCE RID: 3022
	[Token(Token = "0x2000BCE")]
	public sealed class FieldDescriptor : DescriptorBase, IComparable<FieldDescriptor>
	{
		// Token: 0x170009D4 RID: 2516
		// (get) Token: 0x060073F8 RID: 29688 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009D4")]
		public MessageDescriptor ContainingType
		{
			[Token(Token = "0x60073F8")]
			[Address(RVA = "0x31ADE28", Offset = "0x31ADE28", VA = "0x31ADE28")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x170009D5 RID: 2517
		// (get) Token: 0x060073F9 RID: 29689 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009D5")]
		public OneofDescriptor ContainingOneof
		{
			[Token(Token = "0x60073F9")]
			[Address(RVA = "0x31ADE30", Offset = "0x31ADE30", VA = "0x31ADE30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x170009D6 RID: 2518
		// (get) Token: 0x060073FA RID: 29690 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009D6")]
		public string JsonName
		{
			[Token(Token = "0x60073FA")]
			[Address(RVA = "0x31ADE38", Offset = "0x31ADE38", VA = "0x31ADE38")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x170009D7 RID: 2519
		// (get) Token: 0x060073FB RID: 29691 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009D7")]
		internal FieldDescriptorProto Proto
		{
			[Token(Token = "0x60073FB")]
			[Address(RVA = "0x31ADE40", Offset = "0x31ADE40", VA = "0x31ADE40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x170009D8 RID: 2520
		// (get) Token: 0x060073FC RID: 29692 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009D8")]
		public Extension Extension
		{
			[Token(Token = "0x60073FC")]
			[Address(RVA = "0x31ADE48", Offset = "0x31ADE48", VA = "0x31ADE48")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x060073FD RID: 29693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073FD")]
		[Address(RVA = "0x31AD7BC", Offset = "0x31AD7BC", VA = "0x31AD7BC")]
		internal FieldDescriptor(FieldDescriptorProto proto, FileDescriptor file, MessageDescriptor parent, int index, string propertyName, Extension extension)
		{
		}

		// Token: 0x170009D9 RID: 2521
		// (get) Token: 0x060073FE RID: 29694 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009D9")]
		public override string Name
		{
			[Token(Token = "0x60073FE")]
			[Address(RVA = "0x31ADEC0", Offset = "0x31ADEC0", VA = "0x31ADEC0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x170009DA RID: 2522
		// (get) Token: 0x060073FF RID: 29695 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009DA")]
		public IFieldAccessor Accessor
		{
			[Token(Token = "0x60073FF")]
			[Address(RVA = "0x31ADEDC", Offset = "0x31ADEDC", VA = "0x31ADEDC")]
			get
			{
				return null;
			}
		}

		// Token: 0x06007400 RID: 29696 RVA: 0x00051498 File Offset: 0x0004F698
		[Token(Token = "0x6007400")]
		[Address(RVA = "0x31ADE50", Offset = "0x31ADE50", VA = "0x31ADE50")]
		private static FieldType GetFieldTypeFromProtoType(FieldDescriptorProto.Types.Type type)
		{
			return FieldType.Double;
		}

		// Token: 0x170009DB RID: 2523
		// (get) Token: 0x06007401 RID: 29697 RVA: 0x000514B0 File Offset: 0x0004F6B0
		[Token(Token = "0x170009DB")]
		public bool IsRepeated
		{
			[Token(Token = "0x6007401")]
			[Address(RVA = "0x31ADEE4", Offset = "0x31ADEE4", VA = "0x31ADEE4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170009DC RID: 2524
		// (get) Token: 0x06007402 RID: 29698 RVA: 0x000514C8 File Offset: 0x0004F6C8
		[Token(Token = "0x170009DC")]
		public bool IsRequired
		{
			[Token(Token = "0x6007402")]
			[Address(RVA = "0x31ADF0C", Offset = "0x31ADF0C", VA = "0x31ADF0C")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170009DD RID: 2525
		// (get) Token: 0x06007403 RID: 29699 RVA: 0x000514E0 File Offset: 0x0004F6E0
		[Token(Token = "0x170009DD")]
		public bool IsMap
		{
			[Token(Token = "0x6007403")]
			[Address(RVA = "0x31ADF34", Offset = "0x31ADF34", VA = "0x31ADF34")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170009DE RID: 2526
		// (get) Token: 0x06007404 RID: 29700 RVA: 0x000514F8 File Offset: 0x0004F6F8
		[Token(Token = "0x170009DE")]
		public bool IsPacked
		{
			[Token(Token = "0x6007404")]
			[Address(RVA = "0x31ADF78", Offset = "0x31ADF78", VA = "0x31ADF78")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170009DF RID: 2527
		// (get) Token: 0x06007405 RID: 29701 RVA: 0x00051510 File Offset: 0x0004F710
		[Token(Token = "0x170009DF")]
		public bool IsExtension
		{
			[Token(Token = "0x6007405")]
			[Address(RVA = "0x31ADFE0", Offset = "0x31ADFE0", VA = "0x31ADFE0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170009E0 RID: 2528
		// (get) Token: 0x06007406 RID: 29702 RVA: 0x00051528 File Offset: 0x0004F728
		[Token(Token = "0x170009E0")]
		public FieldType FieldType
		{
			[Token(Token = "0x6007406")]
			[Address(RVA = "0x31ADFFC", Offset = "0x31ADFFC", VA = "0x31ADFFC")]
			get
			{
				return FieldType.Double;
			}
		}

		// Token: 0x170009E1 RID: 2529
		// (get) Token: 0x06007407 RID: 29703 RVA: 0x00051540 File Offset: 0x0004F740
		[Token(Token = "0x170009E1")]
		public int FieldNumber
		{
			[Token(Token = "0x6007407")]
			[Address(RVA = "0x31AB07C", Offset = "0x31AB07C", VA = "0x31AB07C")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06007408 RID: 29704 RVA: 0x00051558 File Offset: 0x0004F758
		[Token(Token = "0x6007408")]
		[Address(RVA = "0x31AE004", Offset = "0x31AE004", VA = "0x31AE004", Slot = "9")]
		public int CompareTo(FieldDescriptor other)
		{
			return 0;
		}

		// Token: 0x170009E2 RID: 2530
		// (get) Token: 0x06007409 RID: 29705 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009E2")]
		public EnumDescriptor EnumType
		{
			[Token(Token = "0x6007409")]
			[Address(RVA = "0x31AE0A4", Offset = "0x31AE0A4", VA = "0x31AE0A4")]
			get
			{
				return null;
			}
		}

		// Token: 0x170009E3 RID: 2531
		// (get) Token: 0x0600740A RID: 29706 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009E3")]
		public MessageDescriptor MessageType
		{
			[Token(Token = "0x600740A")]
			[Address(RVA = "0x31AE10C", Offset = "0x31AE10C", VA = "0x31AE10C")]
			get
			{
				return null;
			}
		}

		// Token: 0x170009E4 RID: 2532
		// (get) Token: 0x0600740B RID: 29707 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009E4")]
		public MessageDescriptor ExtendeeType
		{
			[Token(Token = "0x600740B")]
			[Address(RVA = "0x31AB004", Offset = "0x31AB004", VA = "0x31AB004")]
			get
			{
				return null;
			}
		}

		// Token: 0x170009E5 RID: 2533
		// (get) Token: 0x0600740C RID: 29708 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009E5")]
		[Obsolete("CustomOptions are obsolete. Use GetOption")]
		public CustomOptions CustomOptions
		{
			[Token(Token = "0x600740C")]
			[Address(RVA = "0x31AE178", Offset = "0x31AE178", VA = "0x31AE178")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600740D RID: 29709 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600740D")]
		public T GetOption<T>(Extension<FieldOptions, T> extension)
		{
			return null;
		}

		// Token: 0x0600740E RID: 29710 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600740E")]
		public RepeatedField<T> GetOption<T>(RepeatedExtension<FieldOptions, T> extension)
		{
			return null;
		}

		// Token: 0x0600740F RID: 29711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600740F")]
		[Address(RVA = "0x31ACF80", Offset = "0x31ACF80", VA = "0x31ACF80")]
		internal void CrossLink()
		{
		}

		// Token: 0x06007410 RID: 29712 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007410")]
		[Address(RVA = "0x31AE20C", Offset = "0x31AE20C", VA = "0x31AE20C")]
		private IFieldAccessor CreateAccessor()
		{
			return null;
		}

		// Token: 0x04002F35 RID: 12085
		[Token(Token = "0x4002F35")]
		[FieldOffset(Offset = "0x28")]
		private EnumDescriptor enumType;

		// Token: 0x04002F36 RID: 12086
		[Token(Token = "0x4002F36")]
		[FieldOffset(Offset = "0x30")]
		private MessageDescriptor extendeeType;

		// Token: 0x04002F37 RID: 12087
		[Token(Token = "0x4002F37")]
		[FieldOffset(Offset = "0x38")]
		private MessageDescriptor messageType;

		// Token: 0x04002F38 RID: 12088
		[Token(Token = "0x4002F38")]
		[FieldOffset(Offset = "0x40")]
		private FieldType fieldType;

		// Token: 0x04002F39 RID: 12089
		[Token(Token = "0x4002F39")]
		[FieldOffset(Offset = "0x48")]
		private readonly string propertyName;

		// Token: 0x04002F3A RID: 12090
		[Token(Token = "0x4002F3A")]
		[FieldOffset(Offset = "0x50")]
		private IFieldAccessor accessor;
	}
}
