using System;
using System.Diagnostics;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Google.Protobuf.WellKnownTypes
{
	// Token: 0x02000B73 RID: 2931
	[Token(Token = "0x2000B73")]
	public sealed class StringValue : IMessage<StringValue>, IMessage, IEquatable<StringValue>, IDeepCloneable<StringValue>
	{
		// Token: 0x17000880 RID: 2176
		// (get) Token: 0x06006FAC RID: 28588 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000880")]
		[DebuggerNonUserCode]
		public static MessageParser<StringValue> Parser
		{
			[Token(Token = "0x6006FAC")]
			[Address(RVA = "0x36838DC", Offset = "0x36838DC", VA = "0x36838DC")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000881 RID: 2177
		// (get) Token: 0x06006FAD RID: 28589 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000881")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Token(Token = "0x6006FAD")]
			[Address(RVA = "0x3683934", Offset = "0x3683934", VA = "0x3683934")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000882 RID: 2178
		// (get) Token: 0x06006FAE RID: 28590 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000882")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Token(Token = "0x6006FAE")]
			[Address(RVA = "0x3683A38", Offset = "0x3683A38", VA = "0x3683A38", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006FAF RID: 28591 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FAF")]
		[Address(RVA = "0x3683A84", Offset = "0x3683A84", VA = "0x3683A84")]
		[DebuggerNonUserCode]
		public StringValue()
		{
		}

		// Token: 0x06006FB0 RID: 28592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FB0")]
		[Address(RVA = "0x3683ADC", Offset = "0x3683ADC", VA = "0x3683ADC")]
		[DebuggerNonUserCode]
		public StringValue(StringValue other)
		{
		}

		// Token: 0x06006FB1 RID: 28593 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006FB1")]
		[Address(RVA = "0x3683B2C", Offset = "0x3683B2C", VA = "0x3683B2C", Slot = "10")]
		[DebuggerNonUserCode]
		public StringValue Clone()
		{
			return null;
		}

		// Token: 0x17000883 RID: 2179
		// (get) Token: 0x06006FB2 RID: 28594 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006FB3 RID: 28595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000883")]
		[DebuggerNonUserCode]
		public string Value
		{
			[Token(Token = "0x6006FB2")]
			[Address(RVA = "0x3683B8C", Offset = "0x3683B8C", VA = "0x3683B8C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6006FB3")]
			[Address(RVA = "0x3683B94", Offset = "0x3683B94", VA = "0x3683B94")]
			set
			{
			}
		}

		// Token: 0x06006FB4 RID: 28596 RVA: 0x0004FA10 File Offset: 0x0004DC10
		[Token(Token = "0x6006FB4")]
		[Address(RVA = "0x3683C10", Offset = "0x3683C10", VA = "0x3683C10", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06006FB5 RID: 28597 RVA: 0x0004FA28 File Offset: 0x0004DC28
		[Token(Token = "0x6006FB5")]
		[Address(RVA = "0x3683C74", Offset = "0x3683C74", VA = "0x3683C74", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(StringValue other)
		{
			return default(bool);
		}

		// Token: 0x06006FB6 RID: 28598 RVA: 0x0004FA40 File Offset: 0x0004DC40
		[Token(Token = "0x6006FB6")]
		[Address(RVA = "0x3683CD4", Offset = "0x3683CD4", VA = "0x3683CD4", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06006FB7 RID: 28599 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006FB7")]
		[Address(RVA = "0x3683D34", Offset = "0x3683D34", VA = "0x3683D34", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06006FB8 RID: 28600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FB8")]
		[Address(RVA = "0x3683D8C", Offset = "0x3683D8C", VA = "0x3683D8C", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06006FB9 RID: 28601 RVA: 0x0004FA58 File Offset: 0x0004DC58
		[Token(Token = "0x6006FB9")]
		[Address(RVA = "0x3683DFC", Offset = "0x3683DFC", VA = "0x3683DFC", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06006FBA RID: 28602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FBA")]
		[Address(RVA = "0x3683E90", Offset = "0x3683E90", VA = "0x3683E90", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(StringValue other)
		{
		}

		// Token: 0x06006FBB RID: 28603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FBB")]
		[Address(RVA = "0x3683EF4", Offset = "0x3683EF4", VA = "0x3683EF4", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x04002CFE RID: 11518
		[Token(Token = "0x4002CFE")]
		[FieldOffset(Offset = "0x0")]
		private static readonly MessageParser<StringValue> _parser;

		// Token: 0x04002CFF RID: 11519
		[Token(Token = "0x4002CFF")]
		[FieldOffset(Offset = "0x10")]
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002D00 RID: 11520
		[Token(Token = "0x4002D00")]
		public const int ValueFieldNumber = 1;

		// Token: 0x04002D01 RID: 11521
		[Token(Token = "0x4002D01")]
		[FieldOffset(Offset = "0x18")]
		private string value_;
	}
}
