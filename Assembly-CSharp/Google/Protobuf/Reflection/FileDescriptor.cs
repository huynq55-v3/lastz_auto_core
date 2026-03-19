using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.Protobuf.Collections;
using Il2CppDummyDll;

namespace Google.Protobuf.Reflection
{
	// Token: 0x02000BD1 RID: 3025
	[Token(Token = "0x2000BD1")]
	public sealed class FileDescriptor : IDescriptor
	{
		// Token: 0x06007412 RID: 29714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007412")]
		[Address(RVA = "0x31AE9E0", Offset = "0x31AE9E0", VA = "0x31AE9E0")]
		private FileDescriptor(ByteString descriptorData, FileDescriptorProto proto, IEnumerable<FileDescriptor> dependencies, DescriptorPool pool, bool allowUnknownDependencies, GeneratedClrTypeInfo generatedCodeInfo)
		{
		}

		// Token: 0x06007413 RID: 29715 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007413")]
		[Address(RVA = "0x31AF278", Offset = "0x31AF278", VA = "0x31AF278")]
		private Dictionary<IDescriptor, DescriptorDeclaration> CreateDeclarationMap()
		{
			return null;
		}

		// Token: 0x06007414 RID: 29716 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007414")]
		[Address(RVA = "0x31AF654", Offset = "0x31AF654", VA = "0x31AF654")]
		private IDescriptor FindDescriptorForPath(IList<int> path)
		{
			return null;
		}

		// Token: 0x06007415 RID: 29717 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007415")]
		[Address(RVA = "0x31AFA50", Offset = "0x31AFA50", VA = "0x31AFA50")]
		private DescriptorBase GetDescriptorFromList(IReadOnlyList<DescriptorBase> list, int index)
		{
			return null;
		}

		// Token: 0x06007416 RID: 29718 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007416")]
		[Address(RVA = "0x31AF9B4", Offset = "0x31AF9B4", VA = "0x31AF9B4")]
		private IReadOnlyList<DescriptorBase> GetNestedDescriptorListForField(int fieldNumber)
		{
			return null;
		}

		// Token: 0x06007417 RID: 29719 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007417")]
		[Address(RVA = "0x31A8E3C", Offset = "0x31A8E3C", VA = "0x31A8E3C")]
		internal DescriptorDeclaration GetDeclaration(IDescriptor descriptor)
		{
			return null;
		}

		// Token: 0x06007418 RID: 29720 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007418")]
		[Address(RVA = "0x31AB9C0", Offset = "0x31AB9C0", VA = "0x31AB9C0")]
		internal string ComputeFullName(MessageDescriptor parent, string name)
		{
			return null;
		}

		// Token: 0x06007419 RID: 29721 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007419")]
		[Address(RVA = "0x31AEEC4", Offset = "0x31AEEC4", VA = "0x31AEEC4")]
		private static IList<FileDescriptor> DeterminePublicDependencies(FileDescriptor @this, FileDescriptorProto proto, IEnumerable<FileDescriptor> dependencies, bool allowUnknownDependencies)
		{
			return null;
		}

		// Token: 0x170009E6 RID: 2534
		// (get) Token: 0x0600741A RID: 29722 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009E6")]
		internal FileDescriptorProto Proto
		{
			[Token(Token = "0x600741A")]
			[Address(RVA = "0x31AFBC4", Offset = "0x31AFBC4", VA = "0x31AFBC4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x170009E7 RID: 2535
		// (get) Token: 0x0600741B RID: 29723 RVA: 0x00051570 File Offset: 0x0004F770
		[Token(Token = "0x170009E7")]
		public Syntax Syntax
		{
			[Token(Token = "0x600741B")]
			[Address(RVA = "0x31AFBCC", Offset = "0x31AFBCC", VA = "0x31AFBCC")]
			[CompilerGenerated]
			get
			{
				return Syntax.Proto2;
			}
		}

		// Token: 0x170009E8 RID: 2536
		// (get) Token: 0x0600741C RID: 29724 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009E8")]
		public string Name
		{
			[Token(Token = "0x600741C")]
			[Address(RVA = "0x31A9EEC", Offset = "0x31A9EEC", VA = "0x31A9EEC", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x170009E9 RID: 2537
		// (get) Token: 0x0600741D RID: 29725 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009E9")]
		public string Package
		{
			[Token(Token = "0x600741D")]
			[Address(RVA = "0x31A9B48", Offset = "0x31A9B48", VA = "0x31A9B48")]
			get
			{
				return null;
			}
		}

		// Token: 0x170009EA RID: 2538
		// (get) Token: 0x0600741E RID: 29726 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009EA")]
		public IList<MessageDescriptor> MessageTypes
		{
			[Token(Token = "0x600741E")]
			[Address(RVA = "0x31AFBD4", Offset = "0x31AFBD4", VA = "0x31AFBD4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x170009EB RID: 2539
		// (get) Token: 0x0600741F RID: 29727 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009EB")]
		public IList<EnumDescriptor> EnumTypes
		{
			[Token(Token = "0x600741F")]
			[Address(RVA = "0x31AFBDC", Offset = "0x31AFBDC", VA = "0x31AFBDC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x170009EC RID: 2540
		// (get) Token: 0x06007420 RID: 29728 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009EC")]
		public IList<ServiceDescriptor> Services
		{
			[Token(Token = "0x6007420")]
			[Address(RVA = "0x31AFBE4", Offset = "0x31AFBE4", VA = "0x31AFBE4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x170009ED RID: 2541
		// (get) Token: 0x06007421 RID: 29729 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009ED")]
		public ExtensionCollection Extensions
		{
			[Token(Token = "0x6007421")]
			[Address(RVA = "0x31AFBEC", Offset = "0x31AFBEC", VA = "0x31AFBEC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x170009EE RID: 2542
		// (get) Token: 0x06007422 RID: 29730 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009EE")]
		public IList<FileDescriptor> Dependencies
		{
			[Token(Token = "0x6007422")]
			[Address(RVA = "0x31AFBF4", Offset = "0x31AFBF4", VA = "0x31AFBF4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x170009EF RID: 2543
		// (get) Token: 0x06007423 RID: 29731 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009EF")]
		public IList<FileDescriptor> PublicDependencies
		{
			[Token(Token = "0x6007423")]
			[Address(RVA = "0x31AFBFC", Offset = "0x31AFBFC", VA = "0x31AFBFC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x170009F0 RID: 2544
		// (get) Token: 0x06007424 RID: 29732 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009F0")]
		public ByteString SerializedData
		{
			[Token(Token = "0x6007424")]
			[Address(RVA = "0x31AFC04", Offset = "0x31AFC04", VA = "0x31AFC04")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x170009F1 RID: 2545
		// (get) Token: 0x06007425 RID: 29733 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009F1")]
		private string Google.Protobuf.Reflection.IDescriptor.FullName
		{
			[Token(Token = "0x6007425")]
			[Address(RVA = "0x31AFC0C", Offset = "0x31AFC0C", VA = "0x31AFC0C", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x170009F2 RID: 2546
		// (get) Token: 0x06007426 RID: 29734 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009F2")]
		private FileDescriptor Google.Protobuf.Reflection.IDescriptor.File
		{
			[Token(Token = "0x6007426")]
			[Address(RVA = "0x31AFC28", Offset = "0x31AFC28", VA = "0x31AFC28", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x170009F3 RID: 2547
		// (get) Token: 0x06007427 RID: 29735 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009F3")]
		internal DescriptorPool DescriptorPool
		{
			[Token(Token = "0x6007427")]
			[Address(RVA = "0x31AFC2C", Offset = "0x31AFC2C", VA = "0x31AFC2C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x06007428 RID: 29736 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007428")]
		public T FindTypeByName<T>(string name) where T : class, IDescriptor
		{
			return null;
		}

		// Token: 0x06007429 RID: 29737 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007429")]
		[Address(RVA = "0x31AFC34", Offset = "0x31AFC34", VA = "0x31AFC34")]
		private static FileDescriptor BuildFrom(ByteString descriptorData, FileDescriptorProto proto, FileDescriptor[] dependencies, bool allowUnknownDependencies, GeneratedClrTypeInfo generatedCodeInfo)
		{
			return null;
		}

		// Token: 0x0600742A RID: 29738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600742A")]
		[Address(RVA = "0x31AFD9C", Offset = "0x31AFD9C", VA = "0x31AFD9C")]
		private void CrossLink()
		{
		}

		// Token: 0x0600742B RID: 29739 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600742B")]
		[Address(RVA = "0x31B0DBC", Offset = "0x31B0DBC", VA = "0x31B0DBC")]
		public static FileDescriptor FromGeneratedCode(byte[] descriptorData, FileDescriptor[] dependencies, GeneratedClrTypeInfo generatedCodeInfo)
		{
			return null;
		}

		// Token: 0x0600742C RID: 29740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600742C")]
		[Address(RVA = "0x31B1150", Offset = "0x31B1150", VA = "0x31B1150")]
		private static void AddAllExtensions(FileDescriptor[] dependencies, GeneratedClrTypeInfo generatedInfo, ExtensionRegistry registry)
		{
		}

		// Token: 0x0600742D RID: 29741 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600742D")]
		[Address(RVA = "0x31B1290", Offset = "0x31B1290", VA = "0x31B1290")]
		private static IEnumerable<Extension> GetAllGeneratedExtensions(GeneratedClrTypeInfo generated)
		{
			return null;
		}

		// Token: 0x0600742E RID: 29742 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600742E")]
		[Address(RVA = "0x31B1434", Offset = "0x31B1434", VA = "0x31B1434")]
		private static IEnumerable<Extension> GetAllDependedExtensions(FileDescriptor descriptor)
		{
			return null;
		}

		// Token: 0x0600742F RID: 29743 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600742F")]
		[Address(RVA = "0x31B1758", Offset = "0x31B1758", VA = "0x31B1758")]
		private static IEnumerable<Extension> GetAllDependedExtensionsFromMessage(MessageDescriptor descriptor)
		{
			return null;
		}

		// Token: 0x06007430 RID: 29744 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007430")]
		[Address(RVA = "0x31B19C8", Offset = "0x31B19C8", VA = "0x31B19C8")]
		public static IReadOnlyList<FileDescriptor> BuildFromByteStrings(IEnumerable<ByteString> descriptorData)
		{
			return null;
		}

		// Token: 0x06007431 RID: 29745 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007431")]
		[Address(RVA = "0x31B247C", Offset = "0x31B247C", VA = "0x31B247C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x170009F4 RID: 2548
		// (get) Token: 0x06007432 RID: 29746 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009F4")]
		public static FileDescriptor DescriptorProtoFileDescriptor
		{
			[Token(Token = "0x6007432")]
			[Address(RVA = "0x31B24E0", Offset = "0x31B24E0", VA = "0x31B24E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170009F5 RID: 2549
		// (get) Token: 0x06007433 RID: 29747 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009F5")]
		[Obsolete("CustomOptions are obsolete. Use GetOption")]
		public CustomOptions CustomOptions
		{
			[Token(Token = "0x6007433")]
			[Address(RVA = "0x31B2568", Offset = "0x31B2568", VA = "0x31B2568")]
			get
			{
				return null;
			}
		}

		// Token: 0x06007434 RID: 29748 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007434")]
		public T GetOption<T>(Extension<FileOptions, T> extension)
		{
			return null;
		}

		// Token: 0x06007435 RID: 29749 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007435")]
		public RepeatedField<T> GetOption<T>(RepeatedExtension<FileOptions, T> extension)
		{
			return null;
		}

		// Token: 0x06007436 RID: 29750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007436")]
		public static void ForceReflectionInitialization<T>()
		{
		}

		// Token: 0x04002F57 RID: 12119
		[Token(Token = "0x4002F57")]
		[FieldOffset(Offset = "0x10")]
		private readonly Lazy<Dictionary<IDescriptor, DescriptorDeclaration>> declarations;
	}
}
