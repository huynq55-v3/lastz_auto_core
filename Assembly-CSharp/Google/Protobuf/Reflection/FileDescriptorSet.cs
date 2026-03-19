using System;
using System.Diagnostics;
using Google.Protobuf.Collections;
using Il2CppDummyDll;

namespace Google.Protobuf.Reflection
{
	// Token: 0x02000B7A RID: 2938
	[Token(Token = "0x2000B7A")]
	public sealed class FileDescriptorSet : IMessage<FileDescriptorSet>, IMessage, IEquatable<FileDescriptorSet>, IDeepCloneable<FileDescriptorSet>
	{
		// Token: 0x17000889 RID: 2185
		// (get) Token: 0x06006FED RID: 28653 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000889")]
		[DebuggerNonUserCode]
		public static MessageParser<FileDescriptorSet> Parser
		{
			[Token(Token = "0x6006FED")]
			[Address(RVA = "0x31EC858", Offset = "0x31EC858", VA = "0x31EC858")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700088A RID: 2186
		// (get) Token: 0x06006FEE RID: 28654 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700088A")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Token(Token = "0x6006FEE")]
			[Address(RVA = "0x31EC8B0", Offset = "0x31EC8B0", VA = "0x31EC8B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700088B RID: 2187
		// (get) Token: 0x06006FEF RID: 28655 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700088B")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Token(Token = "0x6006FEF")]
			[Address(RVA = "0x31EC9B4", Offset = "0x31EC9B4", VA = "0x31EC9B4", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006FF0 RID: 28656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FF0")]
		[Address(RVA = "0x31ECA00", Offset = "0x31ECA00", VA = "0x31ECA00")]
		[DebuggerNonUserCode]
		public FileDescriptorSet()
		{
		}

		// Token: 0x06006FF1 RID: 28657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FF1")]
		[Address(RVA = "0x31ECA88", Offset = "0x31ECA88", VA = "0x31ECA88")]
		[DebuggerNonUserCode]
		public FileDescriptorSet(FileDescriptorSet other)
		{
		}

		// Token: 0x06006FF2 RID: 28658 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006FF2")]
		[Address(RVA = "0x31ECB14", Offset = "0x31ECB14", VA = "0x31ECB14", Slot = "10")]
		[DebuggerNonUserCode]
		public FileDescriptorSet Clone()
		{
			return null;
		}

		// Token: 0x1700088C RID: 2188
		// (get) Token: 0x06006FF3 RID: 28659 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700088C")]
		[DebuggerNonUserCode]
		public RepeatedField<FileDescriptorProto> File
		{
			[Token(Token = "0x6006FF3")]
			[Address(RVA = "0x31ECB74", Offset = "0x31ECB74", VA = "0x31ECB74")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006FF4 RID: 28660 RVA: 0x0004FC68 File Offset: 0x0004DE68
		[Token(Token = "0x6006FF4")]
		[Address(RVA = "0x31ECB7C", Offset = "0x31ECB7C", VA = "0x31ECB7C", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06006FF5 RID: 28661 RVA: 0x0004FC80 File Offset: 0x0004DE80
		[Token(Token = "0x6006FF5")]
		[Address(RVA = "0x31ECBE0", Offset = "0x31ECBE0", VA = "0x31ECBE0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(FileDescriptorSet other)
		{
			return default(bool);
		}

		// Token: 0x06006FF6 RID: 28662 RVA: 0x0004FC98 File Offset: 0x0004DE98
		[Token(Token = "0x6006FF6")]
		[Address(RVA = "0x31ECC70", Offset = "0x31ECC70", VA = "0x31ECC70", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06006FF7 RID: 28663 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006FF7")]
		[Address(RVA = "0x31ECCBC", Offset = "0x31ECCBC", VA = "0x31ECCBC", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06006FF8 RID: 28664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FF8")]
		[Address(RVA = "0x31ECD14", Offset = "0x31ECD14", VA = "0x31ECD14", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06006FF9 RID: 28665 RVA: 0x0004FCB0 File Offset: 0x0004DEB0
		[Token(Token = "0x6006FF9")]
		[Address(RVA = "0x31ECDCC", Offset = "0x31ECDCC", VA = "0x31ECDCC", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06006FFA RID: 28666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FFA")]
		[Address(RVA = "0x31ECE74", Offset = "0x31ECE74", VA = "0x31ECE74", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(FileDescriptorSet other)
		{
		}

		// Token: 0x06006FFB RID: 28667 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FFB")]
		[Address(RVA = "0x31ECEFC", Offset = "0x31ECEFC", VA = "0x31ECEFC", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x04002D0E RID: 11534
		[Token(Token = "0x4002D0E")]
		[FieldOffset(Offset = "0x0")]
		private static readonly MessageParser<FileDescriptorSet> _parser;

		// Token: 0x04002D0F RID: 11535
		[Token(Token = "0x4002D0F")]
		[FieldOffset(Offset = "0x10")]
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002D10 RID: 11536
		[Token(Token = "0x4002D10")]
		public const int FileFieldNumber = 1;

		// Token: 0x04002D11 RID: 11537
		[Token(Token = "0x4002D11")]
		[FieldOffset(Offset = "0x8")]
		private static readonly FieldCodec<FileDescriptorProto> _repeated_file_codec;

		// Token: 0x04002D12 RID: 11538
		[Token(Token = "0x4002D12")]
		[FieldOffset(Offset = "0x18")]
		private readonly RepeatedField<FileDescriptorProto> file_;
	}
}
