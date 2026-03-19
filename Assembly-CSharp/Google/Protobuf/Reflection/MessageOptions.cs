using System;
using System.Diagnostics;
using Google.Protobuf.Collections;
using Il2CppDummyDll;

namespace Google.Protobuf.Reflection
{
	// Token: 0x02000B9D RID: 2973
	[Token(Token = "0x2000B9D")]
	public sealed class MessageOptions : IExtendableMessage<MessageOptions>, IMessage<MessageOptions>, IMessage, IEquatable<MessageOptions>, IDeepCloneable<MessageOptions>
	{
		// Token: 0x17000941 RID: 2369
		// (get) Token: 0x060071FB RID: 29179 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000941")]
		private ExtensionSet<MessageOptions> _Extensions
		{
			[Token(Token = "0x60071FB")]
			[Address(RVA = "0x31FD8C4", Offset = "0x31FD8C4", VA = "0x31FD8C4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000942 RID: 2370
		// (get) Token: 0x060071FC RID: 29180 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000942")]
		[DebuggerNonUserCode]
		public static MessageParser<MessageOptions> Parser
		{
			[Token(Token = "0x60071FC")]
			[Address(RVA = "0x31FD8CC", Offset = "0x31FD8CC", VA = "0x31FD8CC")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000943 RID: 2371
		// (get) Token: 0x060071FD RID: 29181 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000943")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Token(Token = "0x60071FD")]
			[Address(RVA = "0x31FD924", Offset = "0x31FD924", VA = "0x31FD924")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000944 RID: 2372
		// (get) Token: 0x060071FE RID: 29182 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000944")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Token(Token = "0x60071FE")]
			[Address(RVA = "0x31FDA28", Offset = "0x31FDA28", VA = "0x31FDA28", Slot = "15")]
			get
			{
				return null;
			}
		}

		// Token: 0x060071FF RID: 29183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071FF")]
		[Address(RVA = "0x31F0AF8", Offset = "0x31F0AF8", VA = "0x31F0AF8")]
		[DebuggerNonUserCode]
		public MessageOptions()
		{
		}

		// Token: 0x06007200 RID: 29184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007200")]
		[Address(RVA = "0x31FDA74", Offset = "0x31FDA74", VA = "0x31FDA74")]
		[DebuggerNonUserCode]
		public MessageOptions(MessageOptions other)
		{
		}

		// Token: 0x06007201 RID: 29185 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007201")]
		[Address(RVA = "0x31EFD54", Offset = "0x31EFD54", VA = "0x31EFD54", Slot = "17")]
		[DebuggerNonUserCode]
		public MessageOptions Clone()
		{
			return null;
		}

		// Token: 0x17000945 RID: 2373
		// (get) Token: 0x06007202 RID: 29186 RVA: 0x00050988 File Offset: 0x0004EB88
		// (set) Token: 0x06007203 RID: 29187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000945")]
		[DebuggerNonUserCode]
		public bool MessageSetWireFormat
		{
			[Token(Token = "0x6007202")]
			[Address(RVA = "0x31FDB58", Offset = "0x31FDB58", VA = "0x31FDB58")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6007203")]
			[Address(RVA = "0x31FDBC8", Offset = "0x31FDBC8", VA = "0x31FDBC8")]
			set
			{
			}
		}

		// Token: 0x17000946 RID: 2374
		// (get) Token: 0x06007204 RID: 29188 RVA: 0x000509A0 File Offset: 0x0004EBA0
		[Token(Token = "0x17000946")]
		[DebuggerNonUserCode]
		public bool HasMessageSetWireFormat
		{
			[Token(Token = "0x6007204")]
			[Address(RVA = "0x31FDBE0", Offset = "0x31FDBE0", VA = "0x31FDBE0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06007205 RID: 29189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007205")]
		[Address(RVA = "0x31FDBEC", Offset = "0x31FDBEC", VA = "0x31FDBEC")]
		[DebuggerNonUserCode]
		public void ClearMessageSetWireFormat()
		{
		}

		// Token: 0x17000947 RID: 2375
		// (get) Token: 0x06007206 RID: 29190 RVA: 0x000509B8 File Offset: 0x0004EBB8
		// (set) Token: 0x06007207 RID: 29191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000947")]
		[DebuggerNonUserCode]
		public bool NoStandardDescriptorAccessor
		{
			[Token(Token = "0x6007206")]
			[Address(RVA = "0x31FDBFC", Offset = "0x31FDBFC", VA = "0x31FDBFC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6007207")]
			[Address(RVA = "0x31FDC6C", Offset = "0x31FDC6C", VA = "0x31FDC6C")]
			set
			{
			}
		}

		// Token: 0x17000948 RID: 2376
		// (get) Token: 0x06007208 RID: 29192 RVA: 0x000509D0 File Offset: 0x0004EBD0
		[Token(Token = "0x17000948")]
		[DebuggerNonUserCode]
		public bool HasNoStandardDescriptorAccessor
		{
			[Token(Token = "0x6007208")]
			[Address(RVA = "0x31FDC84", Offset = "0x31FDC84", VA = "0x31FDC84")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06007209 RID: 29193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007209")]
		[Address(RVA = "0x31FDC90", Offset = "0x31FDC90", VA = "0x31FDC90")]
		[DebuggerNonUserCode]
		public void ClearNoStandardDescriptorAccessor()
		{
		}

		// Token: 0x17000949 RID: 2377
		// (get) Token: 0x0600720A RID: 29194 RVA: 0x000509E8 File Offset: 0x0004EBE8
		// (set) Token: 0x0600720B RID: 29195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000949")]
		[DebuggerNonUserCode]
		public bool Deprecated
		{
			[Token(Token = "0x600720A")]
			[Address(RVA = "0x31FDCA0", Offset = "0x31FDCA0", VA = "0x31FDCA0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600720B")]
			[Address(RVA = "0x31FDD10", Offset = "0x31FDD10", VA = "0x31FDD10")]
			set
			{
			}
		}

		// Token: 0x1700094A RID: 2378
		// (get) Token: 0x0600720C RID: 29196 RVA: 0x00050A00 File Offset: 0x0004EC00
		[Token(Token = "0x1700094A")]
		[DebuggerNonUserCode]
		public bool HasDeprecated
		{
			[Token(Token = "0x600720C")]
			[Address(RVA = "0x31FDD28", Offset = "0x31FDD28", VA = "0x31FDD28")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600720D RID: 29197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600720D")]
		[Address(RVA = "0x31FDD34", Offset = "0x31FDD34", VA = "0x31FDD34")]
		[DebuggerNonUserCode]
		public void ClearDeprecated()
		{
		}

		// Token: 0x1700094B RID: 2379
		// (get) Token: 0x0600720E RID: 29198 RVA: 0x00050A18 File Offset: 0x0004EC18
		// (set) Token: 0x0600720F RID: 29199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700094B")]
		[DebuggerNonUserCode]
		public bool MapEntry
		{
			[Token(Token = "0x600720E")]
			[Address(RVA = "0x31FDD44", Offset = "0x31FDD44", VA = "0x31FDD44")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600720F")]
			[Address(RVA = "0x31FDDB4", Offset = "0x31FDDB4", VA = "0x31FDDB4")]
			set
			{
			}
		}

		// Token: 0x1700094C RID: 2380
		// (get) Token: 0x06007210 RID: 29200 RVA: 0x00050A30 File Offset: 0x0004EC30
		[Token(Token = "0x1700094C")]
		[DebuggerNonUserCode]
		public bool HasMapEntry
		{
			[Token(Token = "0x6007210")]
			[Address(RVA = "0x31FDDCC", Offset = "0x31FDDCC", VA = "0x31FDDCC")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06007211 RID: 29201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007211")]
		[Address(RVA = "0x31FDDD8", Offset = "0x31FDDD8", VA = "0x31FDDD8")]
		[DebuggerNonUserCode]
		public void ClearMapEntry()
		{
		}

		// Token: 0x1700094D RID: 2381
		// (get) Token: 0x06007212 RID: 29202 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700094D")]
		[DebuggerNonUserCode]
		public RepeatedField<UninterpretedOption> UninterpretedOption
		{
			[Token(Token = "0x6007212")]
			[Address(RVA = "0x31FDDE8", Offset = "0x31FDDE8", VA = "0x31FDDE8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06007213 RID: 29203 RVA: 0x00050A48 File Offset: 0x0004EC48
		[Token(Token = "0x6007213")]
		[Address(RVA = "0x31FDDF0", Offset = "0x31FDDF0", VA = "0x31FDDF0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06007214 RID: 29204 RVA: 0x00050A60 File Offset: 0x0004EC60
		[Token(Token = "0x6007214")]
		[Address(RVA = "0x31FDE54", Offset = "0x31FDE54", VA = "0x31FDE54", Slot = "16")]
		[DebuggerNonUserCode]
		public bool Equals(MessageOptions other)
		{
			return default(bool);
		}

		// Token: 0x06007215 RID: 29205 RVA: 0x00050A78 File Offset: 0x0004EC78
		[Token(Token = "0x6007215")]
		[Address(RVA = "0x31FDF68", Offset = "0x31FDF68", VA = "0x31FDF68", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06007216 RID: 29206 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007216")]
		[Address(RVA = "0x31FE10C", Offset = "0x31FE10C", VA = "0x31FE10C", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06007217 RID: 29207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007217")]
		[Address(RVA = "0x31FE164", Offset = "0x31FE164", VA = "0x31FE164", Slot = "13")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06007218 RID: 29208 RVA: 0x00050A90 File Offset: 0x0004EC90
		[Token(Token = "0x6007218")]
		[Address(RVA = "0x31FE314", Offset = "0x31FE314", VA = "0x31FE314", Slot = "14")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06007219 RID: 29209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007219")]
		[Address(RVA = "0x31F0B80", Offset = "0x31F0B80", VA = "0x31F0B80", Slot = "11")]
		[DebuggerNonUserCode]
		public void MergeFrom(MessageOptions other)
		{
		}

		// Token: 0x0600721A RID: 29210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600721A")]
		[Address(RVA = "0x31FE418", Offset = "0x31FE418", VA = "0x31FE418", Slot = "12")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600721B RID: 29211 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600721B")]
		public TValue GetExtension<TValue>(Extension<MessageOptions, TValue> extension)
		{
			return null;
		}

		// Token: 0x0600721C RID: 29212 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600721C")]
		public RepeatedField<TValue> GetExtension<TValue>(RepeatedExtension<MessageOptions, TValue> extension)
		{
			return null;
		}

		// Token: 0x0600721D RID: 29213 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600721D")]
		public RepeatedField<TValue> GetOrInitializeExtension<TValue>(RepeatedExtension<MessageOptions, TValue> extension)
		{
			return null;
		}

		// Token: 0x0600721E RID: 29214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600721E")]
		public void SetExtension<TValue>(Extension<MessageOptions, TValue> extension, TValue value)
		{
		}

		// Token: 0x0600721F RID: 29215 RVA: 0x00050AA8 File Offset: 0x0004ECA8
		[Token(Token = "0x600721F")]
		public bool HasExtension<TValue>(Extension<MessageOptions, TValue> extension)
		{
			return default(bool);
		}

		// Token: 0x06007220 RID: 29216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007220")]
		public void ClearExtension<TValue>(Extension<MessageOptions, TValue> extension)
		{
		}

		// Token: 0x06007221 RID: 29217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007221")]
		public void ClearExtension<TValue>(RepeatedExtension<MessageOptions, TValue> extension)
		{
		}

		// Token: 0x04002E45 RID: 11845
		[Token(Token = "0x4002E45")]
		[FieldOffset(Offset = "0x0")]
		private static readonly MessageParser<MessageOptions> _parser;

		// Token: 0x04002E46 RID: 11846
		[Token(Token = "0x4002E46")]
		[FieldOffset(Offset = "0x10")]
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002E47 RID: 11847
		[Token(Token = "0x4002E47")]
		[FieldOffset(Offset = "0x18")]
		internal ExtensionSet<MessageOptions> _extensions;

		// Token: 0x04002E48 RID: 11848
		[Token(Token = "0x4002E48")]
		[FieldOffset(Offset = "0x20")]
		private int _hasBits0;

		// Token: 0x04002E49 RID: 11849
		[Token(Token = "0x4002E49")]
		public const int MessageSetWireFormatFieldNumber = 1;

		// Token: 0x04002E4A RID: 11850
		[Token(Token = "0x4002E4A")]
		[FieldOffset(Offset = "0x8")]
		private static readonly bool MessageSetWireFormatDefaultValue;

		// Token: 0x04002E4B RID: 11851
		[Token(Token = "0x4002E4B")]
		[FieldOffset(Offset = "0x24")]
		private bool messageSetWireFormat_;

		// Token: 0x04002E4C RID: 11852
		[Token(Token = "0x4002E4C")]
		public const int NoStandardDescriptorAccessorFieldNumber = 2;

		// Token: 0x04002E4D RID: 11853
		[Token(Token = "0x4002E4D")]
		[FieldOffset(Offset = "0x9")]
		private static readonly bool NoStandardDescriptorAccessorDefaultValue;

		// Token: 0x04002E4E RID: 11854
		[Token(Token = "0x4002E4E")]
		[FieldOffset(Offset = "0x25")]
		private bool noStandardDescriptorAccessor_;

		// Token: 0x04002E4F RID: 11855
		[Token(Token = "0x4002E4F")]
		public const int DeprecatedFieldNumber = 3;

		// Token: 0x04002E50 RID: 11856
		[Token(Token = "0x4002E50")]
		[FieldOffset(Offset = "0xA")]
		private static readonly bool DeprecatedDefaultValue;

		// Token: 0x04002E51 RID: 11857
		[Token(Token = "0x4002E51")]
		[FieldOffset(Offset = "0x26")]
		private bool deprecated_;

		// Token: 0x04002E52 RID: 11858
		[Token(Token = "0x4002E52")]
		public const int MapEntryFieldNumber = 7;

		// Token: 0x04002E53 RID: 11859
		[Token(Token = "0x4002E53")]
		[FieldOffset(Offset = "0xB")]
		private static readonly bool MapEntryDefaultValue;

		// Token: 0x04002E54 RID: 11860
		[Token(Token = "0x4002E54")]
		[FieldOffset(Offset = "0x27")]
		private bool mapEntry_;

		// Token: 0x04002E55 RID: 11861
		[Token(Token = "0x4002E55")]
		public const int UninterpretedOptionFieldNumber = 999;

		// Token: 0x04002E56 RID: 11862
		[Token(Token = "0x4002E56")]
		[FieldOffset(Offset = "0x10")]
		private static readonly FieldCodec<UninterpretedOption> _repeated_uninterpretedOption_codec;

		// Token: 0x04002E57 RID: 11863
		[Token(Token = "0x4002E57")]
		[FieldOffset(Offset = "0x28")]
		private readonly RepeatedField<UninterpretedOption> uninterpretedOption_;
	}
}
