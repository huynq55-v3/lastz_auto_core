using System;
using System.Diagnostics;
using Google.Protobuf.Collections;
using Il2CppDummyDll;

namespace Google.Protobuf.Reflection
{
	// Token: 0x02000B85 RID: 2949
	[Token(Token = "0x2000B85")]
	public sealed class ExtensionRangeOptions : IExtendableMessage<ExtensionRangeOptions>, IMessage<ExtensionRangeOptions>, IMessage, IEquatable<ExtensionRangeOptions>, IDeepCloneable<ExtensionRangeOptions>
	{
		// Token: 0x170008C0 RID: 2240
		// (get) Token: 0x06007087 RID: 28807 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008C0")]
		private ExtensionSet<ExtensionRangeOptions> _Extensions
		{
			[Token(Token = "0x6007087")]
			[Address(RVA = "0x31F2D64", Offset = "0x31F2D64", VA = "0x31F2D64")]
			get
			{
				return null;
			}
		}

		// Token: 0x170008C1 RID: 2241
		// (get) Token: 0x06007088 RID: 28808 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008C1")]
		[DebuggerNonUserCode]
		public static MessageParser<ExtensionRangeOptions> Parser
		{
			[Token(Token = "0x6007088")]
			[Address(RVA = "0x31F2D6C", Offset = "0x31F2D6C", VA = "0x31F2D6C")]
			get
			{
				return null;
			}
		}

		// Token: 0x170008C2 RID: 2242
		// (get) Token: 0x06007089 RID: 28809 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008C2")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Token(Token = "0x6007089")]
			[Address(RVA = "0x31F2DC4", Offset = "0x31F2DC4", VA = "0x31F2DC4")]
			get
			{
				return null;
			}
		}

		// Token: 0x170008C3 RID: 2243
		// (get) Token: 0x0600708A RID: 28810 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008C3")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Token(Token = "0x600708A")]
			[Address(RVA = "0x31F2EC8", Offset = "0x31F2EC8", VA = "0x31F2EC8", Slot = "15")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600708B RID: 28811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600708B")]
		[Address(RVA = "0x31F1E68", Offset = "0x31F1E68", VA = "0x31F1E68")]
		[DebuggerNonUserCode]
		public ExtensionRangeOptions()
		{
		}

		// Token: 0x0600708C RID: 28812 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600708C")]
		[Address(RVA = "0x31F2F14", Offset = "0x31F2F14", VA = "0x31F2F14")]
		[DebuggerNonUserCode]
		public ExtensionRangeOptions(ExtensionRangeOptions other)
		{
		}

		// Token: 0x0600708D RID: 28813 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600708D")]
		[Address(RVA = "0x31F1778", Offset = "0x31F1778", VA = "0x31F1778", Slot = "17")]
		[DebuggerNonUserCode]
		public ExtensionRangeOptions Clone()
		{
			return null;
		}

		// Token: 0x170008C4 RID: 2244
		// (get) Token: 0x0600708E RID: 28814 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008C4")]
		[DebuggerNonUserCode]
		public RepeatedField<UninterpretedOption> UninterpretedOption
		{
			[Token(Token = "0x600708E")]
			[Address(RVA = "0x31F2FD0", Offset = "0x31F2FD0", VA = "0x31F2FD0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600708F RID: 28815 RVA: 0x0004FFC8 File Offset: 0x0004E1C8
		[Token(Token = "0x600708F")]
		[Address(RVA = "0x31F2FD8", Offset = "0x31F2FD8", VA = "0x31F2FD8", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06007090 RID: 28816 RVA: 0x0004FFE0 File Offset: 0x0004E1E0
		[Token(Token = "0x6007090")]
		[Address(RVA = "0x31F303C", Offset = "0x31F303C", VA = "0x31F303C", Slot = "16")]
		[DebuggerNonUserCode]
		public bool Equals(ExtensionRangeOptions other)
		{
			return default(bool);
		}

		// Token: 0x06007091 RID: 28817 RVA: 0x0004FFF8 File Offset: 0x0004E1F8
		[Token(Token = "0x6007091")]
		[Address(RVA = "0x31F30E0", Offset = "0x31F30E0", VA = "0x31F30E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06007092 RID: 28818 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007092")]
		[Address(RVA = "0x31F314C", Offset = "0x31F314C", VA = "0x31F314C", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06007093 RID: 28819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007093")]
		[Address(RVA = "0x31F31A4", Offset = "0x31F31A4", VA = "0x31F31A4", Slot = "13")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06007094 RID: 28820 RVA: 0x00050010 File Offset: 0x0004E210
		[Token(Token = "0x6007094")]
		[Address(RVA = "0x31F3284", Offset = "0x31F3284", VA = "0x31F3284", Slot = "14")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06007095 RID: 28821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007095")]
		[Address(RVA = "0x31F1EF0", Offset = "0x31F1EF0", VA = "0x31F1EF0", Slot = "11")]
		[DebuggerNonUserCode]
		public void MergeFrom(ExtensionRangeOptions other)
		{
		}

		// Token: 0x06007096 RID: 28822 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007096")]
		[Address(RVA = "0x31F3354", Offset = "0x31F3354", VA = "0x31F3354", Slot = "12")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06007097 RID: 28823 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007097")]
		public TValue GetExtension<TValue>(Extension<ExtensionRangeOptions, TValue> extension)
		{
			return null;
		}

		// Token: 0x06007098 RID: 28824 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007098")]
		public RepeatedField<TValue> GetExtension<TValue>(RepeatedExtension<ExtensionRangeOptions, TValue> extension)
		{
			return null;
		}

		// Token: 0x06007099 RID: 28825 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007099")]
		public RepeatedField<TValue> GetOrInitializeExtension<TValue>(RepeatedExtension<ExtensionRangeOptions, TValue> extension)
		{
			return null;
		}

		// Token: 0x0600709A RID: 28826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600709A")]
		public void SetExtension<TValue>(Extension<ExtensionRangeOptions, TValue> extension, TValue value)
		{
		}

		// Token: 0x0600709B RID: 28827 RVA: 0x00050028 File Offset: 0x0004E228
		[Token(Token = "0x600709B")]
		public bool HasExtension<TValue>(Extension<ExtensionRangeOptions, TValue> extension)
		{
			return default(bool);
		}

		// Token: 0x0600709C RID: 28828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600709C")]
		public void ClearExtension<TValue>(Extension<ExtensionRangeOptions, TValue> extension)
		{
		}

		// Token: 0x0600709D RID: 28829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600709D")]
		public void ClearExtension<TValue>(RepeatedExtension<ExtensionRangeOptions, TValue> extension)
		{
		}

		// Token: 0x04002D6F RID: 11631
		[Token(Token = "0x4002D6F")]
		[FieldOffset(Offset = "0x0")]
		private static readonly MessageParser<ExtensionRangeOptions> _parser;

		// Token: 0x04002D70 RID: 11632
		[Token(Token = "0x4002D70")]
		[FieldOffset(Offset = "0x10")]
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002D71 RID: 11633
		[Token(Token = "0x4002D71")]
		[FieldOffset(Offset = "0x18")]
		internal ExtensionSet<ExtensionRangeOptions> _extensions;

		// Token: 0x04002D72 RID: 11634
		[Token(Token = "0x4002D72")]
		public const int UninterpretedOptionFieldNumber = 999;

		// Token: 0x04002D73 RID: 11635
		[Token(Token = "0x4002D73")]
		[FieldOffset(Offset = "0x8")]
		private static readonly FieldCodec<UninterpretedOption> _repeated_uninterpretedOption_codec;

		// Token: 0x04002D74 RID: 11636
		[Token(Token = "0x4002D74")]
		[FieldOffset(Offset = "0x20")]
		private readonly RepeatedField<UninterpretedOption> uninterpretedOption_;
	}
}
