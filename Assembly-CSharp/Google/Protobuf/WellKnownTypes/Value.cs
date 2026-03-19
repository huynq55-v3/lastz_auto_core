using System;
using System.Diagnostics;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Google.Protobuf.WellKnownTypes
{
	// Token: 0x02000B4C RID: 2892
	[Token(Token = "0x2000B4C")]
	public sealed class Value : IMessage<Value>, IMessage, IEquatable<Value>, IDeepCloneable<Value>
	{
		// Token: 0x17000825 RID: 2085
		// (get) Token: 0x06006E2F RID: 28207 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000825")]
		[DebuggerNonUserCode]
		public static MessageParser<Value> Parser
		{
			[Token(Token = "0x6006E2F")]
			[Address(RVA = "0x3674344", Offset = "0x3674344", VA = "0x3674344")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000826 RID: 2086
		// (get) Token: 0x06006E30 RID: 28208 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000826")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Token(Token = "0x6006E30")]
			[Address(RVA = "0x367439C", Offset = "0x367439C", VA = "0x367439C")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000827 RID: 2087
		// (get) Token: 0x06006E31 RID: 28209 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000827")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Token(Token = "0x6006E31")]
			[Address(RVA = "0x36744A0", Offset = "0x36744A0", VA = "0x36744A0", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006E32 RID: 28210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E32")]
		[Address(RVA = "0x36744EC", Offset = "0x36744EC", VA = "0x36744EC")]
		[DebuggerNonUserCode]
		public Value()
		{
		}

		// Token: 0x06006E33 RID: 28211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E33")]
		[Address(RVA = "0x36744F4", Offset = "0x36744F4", VA = "0x36744F4")]
		[DebuggerNonUserCode]
		public Value(Value other)
		{
		}

		// Token: 0x06006E34 RID: 28212 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006E34")]
		[Address(RVA = "0x3674B9C", Offset = "0x3674B9C", VA = "0x3674B9C", Slot = "10")]
		[DebuggerNonUserCode]
		public Value Clone()
		{
			return null;
		}

		// Token: 0x17000828 RID: 2088
		// (get) Token: 0x06006E35 RID: 28213 RVA: 0x0004F188 File Offset: 0x0004D388
		// (set) Token: 0x06006E36 RID: 28214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000828")]
		[DebuggerNonUserCode]
		public NullValue NullValue
		{
			[Token(Token = "0x6006E35")]
			[Address(RVA = "0x36745F8", Offset = "0x36745F8", VA = "0x36745F8")]
			get
			{
				return NullValue.NullValue;
			}
			[Token(Token = "0x6006E36")]
			[Address(RVA = "0x367467C", Offset = "0x367467C", VA = "0x367467C")]
			set
			{
			}
		}

		// Token: 0x17000829 RID: 2089
		// (get) Token: 0x06006E37 RID: 28215 RVA: 0x0004F1A0 File Offset: 0x0004D3A0
		// (set) Token: 0x06006E38 RID: 28216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000829")]
		[DebuggerNonUserCode]
		public double NumberValue
		{
			[Token(Token = "0x6006E37")]
			[Address(RVA = "0x36746F0", Offset = "0x36746F0", VA = "0x36746F0")]
			get
			{
				return 0.0;
			}
			[Token(Token = "0x6006E38")]
			[Address(RVA = "0x3674770", Offset = "0x3674770", VA = "0x3674770")]
			set
			{
			}
		}

		// Token: 0x1700082A RID: 2090
		// (get) Token: 0x06006E39 RID: 28217 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006E3A RID: 28218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700082A")]
		[DebuggerNonUserCode]
		public string StringValue
		{
			[Token(Token = "0x6006E39")]
			[Address(RVA = "0x36747E4", Offset = "0x36747E4", VA = "0x36747E4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6006E3A")]
			[Address(RVA = "0x3674864", Offset = "0x3674864", VA = "0x3674864")]
			set
			{
			}
		}

		// Token: 0x1700082B RID: 2091
		// (get) Token: 0x06006E3B RID: 28219 RVA: 0x0004F1B8 File Offset: 0x0004D3B8
		// (set) Token: 0x06006E3C RID: 28220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700082B")]
		[DebuggerNonUserCode]
		public bool BoolValue
		{
			[Token(Token = "0x6006E3B")]
			[Address(RVA = "0x36748EC", Offset = "0x36748EC", VA = "0x36748EC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6006E3C")]
			[Address(RVA = "0x3674978", Offset = "0x3674978", VA = "0x3674978")]
			set
			{
			}
		}

		// Token: 0x1700082C RID: 2092
		// (get) Token: 0x06006E3D RID: 28221 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006E3E RID: 28222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700082C")]
		[DebuggerNonUserCode]
		public Struct StructValue
		{
			[Token(Token = "0x6006E3D")]
			[Address(RVA = "0x36749EC", Offset = "0x36749EC", VA = "0x36749EC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6006E3E")]
			[Address(RVA = "0x3674A58", Offset = "0x3674A58", VA = "0x3674A58")]
			set
			{
			}
		}

		// Token: 0x1700082D RID: 2093
		// (get) Token: 0x06006E3F RID: 28223 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006E40 RID: 28224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700082D")]
		[DebuggerNonUserCode]
		public ListValue ListValue
		{
			[Token(Token = "0x6006E3F")]
			[Address(RVA = "0x3674A94", Offset = "0x3674A94", VA = "0x3674A94")]
			get
			{
				return null;
			}
			[Token(Token = "0x6006E40")]
			[Address(RVA = "0x3674B60", Offset = "0x3674B60", VA = "0x3674B60")]
			set
			{
			}
		}

		// Token: 0x1700082E RID: 2094
		// (get) Token: 0x06006E41 RID: 28225 RVA: 0x0004F1D0 File Offset: 0x0004D3D0
		[Token(Token = "0x1700082E")]
		[DebuggerNonUserCode]
		public Value.KindOneofCase KindCase
		{
			[Token(Token = "0x6006E41")]
			[Address(RVA = "0x3674BFC", Offset = "0x3674BFC", VA = "0x3674BFC")]
			get
			{
				return Value.KindOneofCase.None;
			}
		}

		// Token: 0x06006E42 RID: 28226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E42")]
		[Address(RVA = "0x3674C04", Offset = "0x3674C04", VA = "0x3674C04")]
		[DebuggerNonUserCode]
		public void ClearKind()
		{
		}

		// Token: 0x06006E43 RID: 28227 RVA: 0x0004F1E8 File Offset: 0x0004D3E8
		[Token(Token = "0x6006E43")]
		[Address(RVA = "0x3674C14", Offset = "0x3674C14", VA = "0x3674C14", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06006E44 RID: 28228 RVA: 0x0004F200 File Offset: 0x0004D400
		[Token(Token = "0x6006E44")]
		[Address(RVA = "0x3674C78", Offset = "0x3674C78", VA = "0x3674C78", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(Value other)
		{
			return default(bool);
		}

		// Token: 0x06006E45 RID: 28229 RVA: 0x0004F218 File Offset: 0x0004D418
		[Token(Token = "0x6006E45")]
		[Address(RVA = "0x3674E48", Offset = "0x3674E48", VA = "0x3674E48", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06006E46 RID: 28230 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006E46")]
		[Address(RVA = "0x3675034", Offset = "0x3675034", VA = "0x3675034", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06006E47 RID: 28231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E47")]
		[Address(RVA = "0x367508C", Offset = "0x367508C", VA = "0x367508C", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06006E48 RID: 28232 RVA: 0x0004F230 File Offset: 0x0004D430
		[Token(Token = "0x6006E48")]
		[Address(RVA = "0x3675214", Offset = "0x3675214", VA = "0x3675214", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06006E49 RID: 28233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E49")]
		[Address(RVA = "0x3675398", Offset = "0x3675398", VA = "0x3675398", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(Value other)
		{
		}

		// Token: 0x06006E4A RID: 28234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E4A")]
		[Address(RVA = "0x3675658", Offset = "0x3675658", VA = "0x3675658", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06006E4B RID: 28235 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006E4B")]
		[Address(RVA = "0x36758A0", Offset = "0x36758A0", VA = "0x36758A0")]
		public static Value ForString(string value)
		{
			return null;
		}

		// Token: 0x06006E4C RID: 28236 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006E4C")]
		[Address(RVA = "0x367594C", Offset = "0x367594C", VA = "0x367594C")]
		public static Value ForNumber(double value)
		{
			return null;
		}

		// Token: 0x06006E4D RID: 28237 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006E4D")]
		[Address(RVA = "0x36759C0", Offset = "0x36759C0", VA = "0x36759C0")]
		public static Value ForBool(bool value)
		{
			return null;
		}

		// Token: 0x06006E4E RID: 28238 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006E4E")]
		[Address(RVA = "0x3675A2C", Offset = "0x3675A2C", VA = "0x3675A2C")]
		public static Value ForNull()
		{
			return null;
		}

		// Token: 0x06006E4F RID: 28239 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006E4F")]
		[Address(RVA = "0x3675A94", Offset = "0x3675A94", VA = "0x3675A94")]
		public static Value ForList(params Value[] values)
		{
			return null;
		}

		// Token: 0x06006E50 RID: 28240 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006E50")]
		[Address(RVA = "0x3675B90", Offset = "0x3675B90", VA = "0x3675B90")]
		public static Value ForStruct(Struct value)
		{
			return null;
		}

		// Token: 0x04002C4C RID: 11340
		[Token(Token = "0x4002C4C")]
		[FieldOffset(Offset = "0x0")]
		private static readonly MessageParser<Value> _parser;

		// Token: 0x04002C4D RID: 11341
		[Token(Token = "0x4002C4D")]
		[FieldOffset(Offset = "0x10")]
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002C4E RID: 11342
		[Token(Token = "0x4002C4E")]
		public const int NullValueFieldNumber = 1;

		// Token: 0x04002C4F RID: 11343
		[Token(Token = "0x4002C4F")]
		public const int NumberValueFieldNumber = 2;

		// Token: 0x04002C50 RID: 11344
		[Token(Token = "0x4002C50")]
		public const int StringValueFieldNumber = 3;

		// Token: 0x04002C51 RID: 11345
		[Token(Token = "0x4002C51")]
		public const int BoolValueFieldNumber = 4;

		// Token: 0x04002C52 RID: 11346
		[Token(Token = "0x4002C52")]
		public const int StructValueFieldNumber = 5;

		// Token: 0x04002C53 RID: 11347
		[Token(Token = "0x4002C53")]
		public const int ListValueFieldNumber = 6;

		// Token: 0x04002C54 RID: 11348
		[Token(Token = "0x4002C54")]
		[FieldOffset(Offset = "0x18")]
		private object kind_;

		// Token: 0x04002C55 RID: 11349
		[Token(Token = "0x4002C55")]
		[FieldOffset(Offset = "0x20")]
		private Value.KindOneofCase kindCase_;

		// Token: 0x02000B4D RID: 2893
		[Token(Token = "0x2000B4D")]
		public enum KindOneofCase
		{
			// Token: 0x04002C57 RID: 11351
			[Token(Token = "0x4002C57")]
			None,
			// Token: 0x04002C58 RID: 11352
			[Token(Token = "0x4002C58")]
			NullValue,
			// Token: 0x04002C59 RID: 11353
			[Token(Token = "0x4002C59")]
			NumberValue,
			// Token: 0x04002C5A RID: 11354
			[Token(Token = "0x4002C5A")]
			StringValue,
			// Token: 0x04002C5B RID: 11355
			[Token(Token = "0x4002C5B")]
			BoolValue,
			// Token: 0x04002C5C RID: 11356
			[Token(Token = "0x4002C5C")]
			StructValue,
			// Token: 0x04002C5D RID: 11357
			[Token(Token = "0x4002C5D")]
			ListValue
		}
	}
}
