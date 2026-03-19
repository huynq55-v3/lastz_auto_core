using System;
using System.Diagnostics;
using Google.Protobuf.Collections;
using Il2CppDummyDll;

namespace Google.Protobuf.Reflection
{
	// Token: 0x02000B7C RID: 2940
	[Token(Token = "0x2000B7C")]
	public sealed class FileDescriptorProto : IMessage<FileDescriptorProto>, IMessage, IEquatable<FileDescriptorProto>, IDeepCloneable<FileDescriptorProto>
	{
		// Token: 0x1700088D RID: 2189
		// (get) Token: 0x06007000 RID: 28672 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700088D")]
		[DebuggerNonUserCode]
		public static MessageParser<FileDescriptorProto> Parser
		{
			[Token(Token = "0x6007000")]
			[Address(RVA = "0x31ED268", Offset = "0x31ED268", VA = "0x31ED268")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700088E RID: 2190
		// (get) Token: 0x06007001 RID: 28673 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700088E")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Token(Token = "0x6007001")]
			[Address(RVA = "0x31ED2C0", Offset = "0x31ED2C0", VA = "0x31ED2C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700088F RID: 2191
		// (get) Token: 0x06007002 RID: 28674 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700088F")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Token(Token = "0x6007002")]
			[Address(RVA = "0x31ED3C4", Offset = "0x31ED3C4", VA = "0x31ED3C4", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06007003 RID: 28675 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007003")]
		[Address(RVA = "0x31ED410", Offset = "0x31ED410", VA = "0x31ED410")]
		[DebuggerNonUserCode]
		public FileDescriptorProto()
		{
		}

		// Token: 0x06007004 RID: 28676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007004")]
		[Address(RVA = "0x31ED658", Offset = "0x31ED658", VA = "0x31ED658")]
		[DebuggerNonUserCode]
		public FileDescriptorProto(FileDescriptorProto other)
		{
		}

		// Token: 0x06007005 RID: 28677 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007005")]
		[Address(RVA = "0x31ED904", Offset = "0x31ED904", VA = "0x31ED904", Slot = "10")]
		[DebuggerNonUserCode]
		public FileDescriptorProto Clone()
		{
			return null;
		}

		// Token: 0x17000890 RID: 2192
		// (get) Token: 0x06007006 RID: 28678 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06007007 RID: 28679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000890")]
		[DebuggerNonUserCode]
		public string Name
		{
			[Token(Token = "0x6007006")]
			[Address(RVA = "0x31ED964", Offset = "0x31ED964", VA = "0x31ED964")]
			get
			{
				return null;
			}
			[Token(Token = "0x6007007")]
			[Address(RVA = "0x31ED9C8", Offset = "0x31ED9C8", VA = "0x31ED9C8")]
			set
			{
			}
		}

		// Token: 0x17000891 RID: 2193
		// (get) Token: 0x06007008 RID: 28680 RVA: 0x0004FCC8 File Offset: 0x0004DEC8
		[Token(Token = "0x17000891")]
		[DebuggerNonUserCode]
		public bool HasName
		{
			[Token(Token = "0x6007008")]
			[Address(RVA = "0x31EDA44", Offset = "0x31EDA44", VA = "0x31EDA44")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06007009 RID: 28681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007009")]
		[Address(RVA = "0x31EDA54", Offset = "0x31EDA54", VA = "0x31EDA54")]
		[DebuggerNonUserCode]
		public void ClearName()
		{
		}

		// Token: 0x17000892 RID: 2194
		// (get) Token: 0x0600700A RID: 28682 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600700B RID: 28683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000892")]
		[DebuggerNonUserCode]
		public string Package
		{
			[Token(Token = "0x600700A")]
			[Address(RVA = "0x31EDA60", Offset = "0x31EDA60", VA = "0x31EDA60")]
			get
			{
				return null;
			}
			[Token(Token = "0x600700B")]
			[Address(RVA = "0x31EDAC4", Offset = "0x31EDAC4", VA = "0x31EDAC4")]
			set
			{
			}
		}

		// Token: 0x17000893 RID: 2195
		// (get) Token: 0x0600700C RID: 28684 RVA: 0x0004FCE0 File Offset: 0x0004DEE0
		[Token(Token = "0x17000893")]
		[DebuggerNonUserCode]
		public bool HasPackage
		{
			[Token(Token = "0x600700C")]
			[Address(RVA = "0x31EDB40", Offset = "0x31EDB40", VA = "0x31EDB40")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600700D RID: 28685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600700D")]
		[Address(RVA = "0x31EDB50", Offset = "0x31EDB50", VA = "0x31EDB50")]
		[DebuggerNonUserCode]
		public void ClearPackage()
		{
		}

		// Token: 0x17000894 RID: 2196
		// (get) Token: 0x0600700E RID: 28686 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000894")]
		[DebuggerNonUserCode]
		public RepeatedField<string> Dependency
		{
			[Token(Token = "0x600700E")]
			[Address(RVA = "0x31EDB5C", Offset = "0x31EDB5C", VA = "0x31EDB5C")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000895 RID: 2197
		// (get) Token: 0x0600700F RID: 28687 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000895")]
		[DebuggerNonUserCode]
		public RepeatedField<int> PublicDependency
		{
			[Token(Token = "0x600700F")]
			[Address(RVA = "0x31EDB64", Offset = "0x31EDB64", VA = "0x31EDB64")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000896 RID: 2198
		// (get) Token: 0x06007010 RID: 28688 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000896")]
		[DebuggerNonUserCode]
		public RepeatedField<int> WeakDependency
		{
			[Token(Token = "0x6007010")]
			[Address(RVA = "0x31EDB6C", Offset = "0x31EDB6C", VA = "0x31EDB6C")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000897 RID: 2199
		// (get) Token: 0x06007011 RID: 28689 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000897")]
		[DebuggerNonUserCode]
		public RepeatedField<DescriptorProto> MessageType
		{
			[Token(Token = "0x6007011")]
			[Address(RVA = "0x31EDB74", Offset = "0x31EDB74", VA = "0x31EDB74")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000898 RID: 2200
		// (get) Token: 0x06007012 RID: 28690 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000898")]
		[DebuggerNonUserCode]
		public RepeatedField<EnumDescriptorProto> EnumType
		{
			[Token(Token = "0x6007012")]
			[Address(RVA = "0x31EDB7C", Offset = "0x31EDB7C", VA = "0x31EDB7C")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000899 RID: 2201
		// (get) Token: 0x06007013 RID: 28691 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000899")]
		[DebuggerNonUserCode]
		public RepeatedField<ServiceDescriptorProto> Service
		{
			[Token(Token = "0x6007013")]
			[Address(RVA = "0x31EDB84", Offset = "0x31EDB84", VA = "0x31EDB84")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700089A RID: 2202
		// (get) Token: 0x06007014 RID: 28692 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700089A")]
		[DebuggerNonUserCode]
		public RepeatedField<FieldDescriptorProto> Extension
		{
			[Token(Token = "0x6007014")]
			[Address(RVA = "0x31EDB8C", Offset = "0x31EDB8C", VA = "0x31EDB8C")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700089B RID: 2203
		// (get) Token: 0x06007015 RID: 28693 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06007016 RID: 28694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700089B")]
		[DebuggerNonUserCode]
		public FileOptions Options
		{
			[Token(Token = "0x6007015")]
			[Address(RVA = "0x31EDB94", Offset = "0x31EDB94", VA = "0x31EDB94")]
			get
			{
				return null;
			}
			[Token(Token = "0x6007016")]
			[Address(RVA = "0x31EDB9C", Offset = "0x31EDB9C", VA = "0x31EDB9C")]
			set
			{
			}
		}

		// Token: 0x1700089C RID: 2204
		// (get) Token: 0x06007017 RID: 28695 RVA: 0x0004FCF8 File Offset: 0x0004DEF8
		[Token(Token = "0x1700089C")]
		[DebuggerNonUserCode]
		public bool HasOptions
		{
			[Token(Token = "0x6007017")]
			[Address(RVA = "0x31ED884", Offset = "0x31ED884", VA = "0x31ED884")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06007018 RID: 28696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007018")]
		[Address(RVA = "0x31EDBA4", Offset = "0x31EDBA4", VA = "0x31EDBA4")]
		[DebuggerNonUserCode]
		public void ClearOptions()
		{
		}

		// Token: 0x1700089D RID: 2205
		// (get) Token: 0x06007019 RID: 28697 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600701A RID: 28698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700089D")]
		[DebuggerNonUserCode]
		public SourceCodeInfo SourceCodeInfo
		{
			[Token(Token = "0x6007019")]
			[Address(RVA = "0x31EDBB0", Offset = "0x31EDBB0", VA = "0x31EDBB0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600701A")]
			[Address(RVA = "0x31EDBB8", Offset = "0x31EDBB8", VA = "0x31EDBB8")]
			set
			{
			}
		}

		// Token: 0x1700089E RID: 2206
		// (get) Token: 0x0600701B RID: 28699 RVA: 0x0004FD10 File Offset: 0x0004DF10
		[Token(Token = "0x1700089E")]
		[DebuggerNonUserCode]
		public bool HasSourceCodeInfo
		{
			[Token(Token = "0x600701B")]
			[Address(RVA = "0x31ED8F4", Offset = "0x31ED8F4", VA = "0x31ED8F4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600701C RID: 28700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600701C")]
		[Address(RVA = "0x31EDBC0", Offset = "0x31EDBC0", VA = "0x31EDBC0")]
		[DebuggerNonUserCode]
		public void ClearSourceCodeInfo()
		{
		}

		// Token: 0x1700089F RID: 2207
		// (get) Token: 0x0600701D RID: 28701 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600701E RID: 28702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700089F")]
		[DebuggerNonUserCode]
		public string Syntax
		{
			[Token(Token = "0x600701D")]
			[Address(RVA = "0x31EDBCC", Offset = "0x31EDBCC", VA = "0x31EDBCC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600701E")]
			[Address(RVA = "0x31EDC30", Offset = "0x31EDC30", VA = "0x31EDC30")]
			set
			{
			}
		}

		// Token: 0x170008A0 RID: 2208
		// (get) Token: 0x0600701F RID: 28703 RVA: 0x0004FD28 File Offset: 0x0004DF28
		[Token(Token = "0x170008A0")]
		[DebuggerNonUserCode]
		public bool HasSyntax
		{
			[Token(Token = "0x600701F")]
			[Address(RVA = "0x31EDCAC", Offset = "0x31EDCAC", VA = "0x31EDCAC")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06007020 RID: 28704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007020")]
		[Address(RVA = "0x31EDCBC", Offset = "0x31EDCBC", VA = "0x31EDCBC")]
		[DebuggerNonUserCode]
		public void ClearSyntax()
		{
		}

		// Token: 0x06007021 RID: 28705 RVA: 0x0004FD40 File Offset: 0x0004DF40
		[Token(Token = "0x6007021")]
		[Address(RVA = "0x31EDCC8", Offset = "0x31EDCC8", VA = "0x31EDCC8", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06007022 RID: 28706 RVA: 0x0004FD58 File Offset: 0x0004DF58
		[Token(Token = "0x6007022")]
		[Address(RVA = "0x31EDD2C", Offset = "0x31EDD2C", VA = "0x31EDD2C", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(FileDescriptorProto other)
		{
			return default(bool);
		}

		// Token: 0x06007023 RID: 28707 RVA: 0x0004FD70 File Offset: 0x0004DF70
		[Token(Token = "0x6007023")]
		[Address(RVA = "0x31EDF50", Offset = "0x31EDF50", VA = "0x31EDF50", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06007024 RID: 28708 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007024")]
		[Address(RVA = "0x31EE114", Offset = "0x31EE114", VA = "0x31EE114", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06007025 RID: 28709 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007025")]
		[Address(RVA = "0x31EE16C", Offset = "0x31EE16C", VA = "0x31EE16C", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06007026 RID: 28710 RVA: 0x0004FD88 File Offset: 0x0004DF88
		[Token(Token = "0x6007026")]
		[Address(RVA = "0x31EE450", Offset = "0x31EE450", VA = "0x31EE450", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06007027 RID: 28711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007027")]
		[Address(RVA = "0x31EE780", Offset = "0x31EE780", VA = "0x31EE780", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(FileDescriptorProto other)
		{
		}

		// Token: 0x06007028 RID: 28712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007028")]
		[Address(RVA = "0x31EEDDC", Offset = "0x31EEDDC", VA = "0x31EEDDC", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x04002D14 RID: 11540
		[Token(Token = "0x4002D14")]
		[FieldOffset(Offset = "0x0")]
		private static readonly MessageParser<FileDescriptorProto> _parser;

		// Token: 0x04002D15 RID: 11541
		[Token(Token = "0x4002D15")]
		[FieldOffset(Offset = "0x10")]
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002D16 RID: 11542
		[Token(Token = "0x4002D16")]
		public const int NameFieldNumber = 1;

		// Token: 0x04002D17 RID: 11543
		[Token(Token = "0x4002D17")]
		[FieldOffset(Offset = "0x8")]
		private static readonly string NameDefaultValue;

		// Token: 0x04002D18 RID: 11544
		[Token(Token = "0x4002D18")]
		[FieldOffset(Offset = "0x18")]
		private string name_;

		// Token: 0x04002D19 RID: 11545
		[Token(Token = "0x4002D19")]
		public const int PackageFieldNumber = 2;

		// Token: 0x04002D1A RID: 11546
		[Token(Token = "0x4002D1A")]
		[FieldOffset(Offset = "0x10")]
		private static readonly string PackageDefaultValue;

		// Token: 0x04002D1B RID: 11547
		[Token(Token = "0x4002D1B")]
		[FieldOffset(Offset = "0x20")]
		private string package_;

		// Token: 0x04002D1C RID: 11548
		[Token(Token = "0x4002D1C")]
		public const int DependencyFieldNumber = 3;

		// Token: 0x04002D1D RID: 11549
		[Token(Token = "0x4002D1D")]
		[FieldOffset(Offset = "0x18")]
		private static readonly FieldCodec<string> _repeated_dependency_codec;

		// Token: 0x04002D1E RID: 11550
		[Token(Token = "0x4002D1E")]
		[FieldOffset(Offset = "0x28")]
		private readonly RepeatedField<string> dependency_;

		// Token: 0x04002D1F RID: 11551
		[Token(Token = "0x4002D1F")]
		public const int PublicDependencyFieldNumber = 10;

		// Token: 0x04002D20 RID: 11552
		[Token(Token = "0x4002D20")]
		[FieldOffset(Offset = "0x20")]
		private static readonly FieldCodec<int> _repeated_publicDependency_codec;

		// Token: 0x04002D21 RID: 11553
		[Token(Token = "0x4002D21")]
		[FieldOffset(Offset = "0x30")]
		private readonly RepeatedField<int> publicDependency_;

		// Token: 0x04002D22 RID: 11554
		[Token(Token = "0x4002D22")]
		public const int WeakDependencyFieldNumber = 11;

		// Token: 0x04002D23 RID: 11555
		[Token(Token = "0x4002D23")]
		[FieldOffset(Offset = "0x28")]
		private static readonly FieldCodec<int> _repeated_weakDependency_codec;

		// Token: 0x04002D24 RID: 11556
		[Token(Token = "0x4002D24")]
		[FieldOffset(Offset = "0x38")]
		private readonly RepeatedField<int> weakDependency_;

		// Token: 0x04002D25 RID: 11557
		[Token(Token = "0x4002D25")]
		public const int MessageTypeFieldNumber = 4;

		// Token: 0x04002D26 RID: 11558
		[Token(Token = "0x4002D26")]
		[FieldOffset(Offset = "0x30")]
		private static readonly FieldCodec<DescriptorProto> _repeated_messageType_codec;

		// Token: 0x04002D27 RID: 11559
		[Token(Token = "0x4002D27")]
		[FieldOffset(Offset = "0x40")]
		private readonly RepeatedField<DescriptorProto> messageType_;

		// Token: 0x04002D28 RID: 11560
		[Token(Token = "0x4002D28")]
		public const int EnumTypeFieldNumber = 5;

		// Token: 0x04002D29 RID: 11561
		[Token(Token = "0x4002D29")]
		[FieldOffset(Offset = "0x38")]
		private static readonly FieldCodec<EnumDescriptorProto> _repeated_enumType_codec;

		// Token: 0x04002D2A RID: 11562
		[Token(Token = "0x4002D2A")]
		[FieldOffset(Offset = "0x48")]
		private readonly RepeatedField<EnumDescriptorProto> enumType_;

		// Token: 0x04002D2B RID: 11563
		[Token(Token = "0x4002D2B")]
		public const int ServiceFieldNumber = 6;

		// Token: 0x04002D2C RID: 11564
		[Token(Token = "0x4002D2C")]
		[FieldOffset(Offset = "0x40")]
		private static readonly FieldCodec<ServiceDescriptorProto> _repeated_service_codec;

		// Token: 0x04002D2D RID: 11565
		[Token(Token = "0x4002D2D")]
		[FieldOffset(Offset = "0x50")]
		private readonly RepeatedField<ServiceDescriptorProto> service_;

		// Token: 0x04002D2E RID: 11566
		[Token(Token = "0x4002D2E")]
		public const int ExtensionFieldNumber = 7;

		// Token: 0x04002D2F RID: 11567
		[Token(Token = "0x4002D2F")]
		[FieldOffset(Offset = "0x48")]
		private static readonly FieldCodec<FieldDescriptorProto> _repeated_extension_codec;

		// Token: 0x04002D30 RID: 11568
		[Token(Token = "0x4002D30")]
		[FieldOffset(Offset = "0x58")]
		private readonly RepeatedField<FieldDescriptorProto> extension_;

		// Token: 0x04002D31 RID: 11569
		[Token(Token = "0x4002D31")]
		public const int OptionsFieldNumber = 8;

		// Token: 0x04002D32 RID: 11570
		[Token(Token = "0x4002D32")]
		[FieldOffset(Offset = "0x60")]
		private FileOptions options_;

		// Token: 0x04002D33 RID: 11571
		[Token(Token = "0x4002D33")]
		public const int SourceCodeInfoFieldNumber = 9;

		// Token: 0x04002D34 RID: 11572
		[Token(Token = "0x4002D34")]
		[FieldOffset(Offset = "0x68")]
		private SourceCodeInfo sourceCodeInfo_;

		// Token: 0x04002D35 RID: 11573
		[Token(Token = "0x4002D35")]
		public const int SyntaxFieldNumber = 12;

		// Token: 0x04002D36 RID: 11574
		[Token(Token = "0x4002D36")]
		[FieldOffset(Offset = "0x50")]
		private static readonly string SyntaxDefaultValue;

		// Token: 0x04002D37 RID: 11575
		[Token(Token = "0x4002D37")]
		[FieldOffset(Offset = "0x70")]
		private string syntax_;
	}
}
