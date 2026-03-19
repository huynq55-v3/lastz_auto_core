using System;
using System.Diagnostics;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Google.Protobuf.WellKnownTypes
{
	// Token: 0x02000B6B RID: 2923
	[Token(Token = "0x2000B6B")]
	public sealed class UInt64Value : IMessage<UInt64Value>, IMessage, IEquatable<UInt64Value>, IDeepCloneable<UInt64Value>
	{
		// Token: 0x17000870 RID: 2160
		// (get) Token: 0x06006F5C RID: 28508 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000870")]
		[DebuggerNonUserCode]
		public static MessageParser<UInt64Value> Parser
		{
			[Token(Token = "0x6006F5C")]
			[Address(RVA = "0x3681BC4", Offset = "0x3681BC4", VA = "0x3681BC4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000871 RID: 2161
		// (get) Token: 0x06006F5D RID: 28509 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000871")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Token(Token = "0x6006F5D")]
			[Address(RVA = "0x3681C1C", Offset = "0x3681C1C", VA = "0x3681C1C")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000872 RID: 2162
		// (get) Token: 0x06006F5E RID: 28510 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000872")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Token(Token = "0x6006F5E")]
			[Address(RVA = "0x3681D20", Offset = "0x3681D20", VA = "0x3681D20", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006F5F RID: 28511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F5F")]
		[Address(RVA = "0x3681D6C", Offset = "0x3681D6C", VA = "0x3681D6C")]
		[DebuggerNonUserCode]
		public UInt64Value()
		{
		}

		// Token: 0x06006F60 RID: 28512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F60")]
		[Address(RVA = "0x3681D74", Offset = "0x3681D74", VA = "0x3681D74")]
		[DebuggerNonUserCode]
		public UInt64Value(UInt64Value other)
		{
		}

		// Token: 0x06006F61 RID: 28513 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006F61")]
		[Address(RVA = "0x3681DC0", Offset = "0x3681DC0", VA = "0x3681DC0", Slot = "10")]
		[DebuggerNonUserCode]
		public UInt64Value Clone()
		{
			return null;
		}

		// Token: 0x17000873 RID: 2163
		// (get) Token: 0x06006F62 RID: 28514 RVA: 0x0004F830 File Offset: 0x0004DA30
		// (set) Token: 0x06006F63 RID: 28515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000873")]
		[DebuggerNonUserCode]
		public ulong Value
		{
			[Token(Token = "0x6006F62")]
			[Address(RVA = "0x3681E20", Offset = "0x3681E20", VA = "0x3681E20")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6006F63")]
			[Address(RVA = "0x3681E28", Offset = "0x3681E28", VA = "0x3681E28")]
			set
			{
			}
		}

		// Token: 0x06006F64 RID: 28516 RVA: 0x0004F848 File Offset: 0x0004DA48
		[Token(Token = "0x6006F64")]
		[Address(RVA = "0x3681E30", Offset = "0x3681E30", VA = "0x3681E30", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06006F65 RID: 28517 RVA: 0x0004F860 File Offset: 0x0004DA60
		[Token(Token = "0x6006F65")]
		[Address(RVA = "0x3681E94", Offset = "0x3681E94", VA = "0x3681E94", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(UInt64Value other)
		{
			return default(bool);
		}

		// Token: 0x06006F66 RID: 28518 RVA: 0x0004F878 File Offset: 0x0004DA78
		[Token(Token = "0x6006F66")]
		[Address(RVA = "0x3681ED0", Offset = "0x3681ED0", VA = "0x3681ED0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06006F67 RID: 28519 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006F67")]
		[Address(RVA = "0x3681F2C", Offset = "0x3681F2C", VA = "0x3681F2C", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06006F68 RID: 28520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F68")]
		[Address(RVA = "0x3681F84", Offset = "0x3681F84", VA = "0x3681F84", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06006F69 RID: 28521 RVA: 0x0004F890 File Offset: 0x0004DA90
		[Token(Token = "0x6006F69")]
		[Address(RVA = "0x3681FEC", Offset = "0x3681FEC", VA = "0x3681FEC", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06006F6A RID: 28522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F6A")]
		[Address(RVA = "0x368206C", Offset = "0x368206C", VA = "0x368206C", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(UInt64Value other)
		{
		}

		// Token: 0x06006F6B RID: 28523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F6B")]
		[Address(RVA = "0x36820AC", Offset = "0x36820AC", VA = "0x36820AC", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x04002CEA RID: 11498
		[Token(Token = "0x4002CEA")]
		[FieldOffset(Offset = "0x0")]
		private static readonly MessageParser<UInt64Value> _parser;

		// Token: 0x04002CEB RID: 11499
		[Token(Token = "0x4002CEB")]
		[FieldOffset(Offset = "0x10")]
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002CEC RID: 11500
		[Token(Token = "0x4002CEC")]
		public const int ValueFieldNumber = 1;

		// Token: 0x04002CED RID: 11501
		[Token(Token = "0x4002CED")]
		[FieldOffset(Offset = "0x18")]
		private ulong value_;
	}
}
