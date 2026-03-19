using System;
using System.Diagnostics;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Google.Protobuf.WellKnownTypes
{
	// Token: 0x02000B3F RID: 2879
	[Token(Token = "0x2000B3F")]
	public sealed class Empty : IMessage<Empty>, IMessage, IEquatable<Empty>, IDeepCloneable<Empty>
	{
		// Token: 0x17000810 RID: 2064
		// (get) Token: 0x06006DC4 RID: 28100 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000810")]
		[DebuggerNonUserCode]
		public static MessageParser<Empty> Parser
		{
			[Token(Token = "0x6006DC4")]
			[Address(RVA = "0x366F8B4", Offset = "0x366F8B4", VA = "0x366F8B4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000811 RID: 2065
		// (get) Token: 0x06006DC5 RID: 28101 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000811")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Token(Token = "0x6006DC5")]
			[Address(RVA = "0x366F90C", Offset = "0x366F90C", VA = "0x366F90C")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000812 RID: 2066
		// (get) Token: 0x06006DC6 RID: 28102 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000812")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Token(Token = "0x6006DC6")]
			[Address(RVA = "0x366FA10", Offset = "0x366FA10", VA = "0x366FA10", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006DC7 RID: 28103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DC7")]
		[Address(RVA = "0x366FA5C", Offset = "0x366FA5C", VA = "0x366FA5C")]
		[DebuggerNonUserCode]
		public Empty()
		{
		}

		// Token: 0x06006DC8 RID: 28104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DC8")]
		[Address(RVA = "0x366FA64", Offset = "0x366FA64", VA = "0x366FA64")]
		[DebuggerNonUserCode]
		public Empty(Empty other)
		{
		}

		// Token: 0x06006DC9 RID: 28105 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006DC9")]
		[Address(RVA = "0x366FAA8", Offset = "0x366FAA8", VA = "0x366FAA8", Slot = "10")]
		[DebuggerNonUserCode]
		public Empty Clone()
		{
			return null;
		}

		// Token: 0x06006DCA RID: 28106 RVA: 0x0004EF30 File Offset: 0x0004D130
		[Token(Token = "0x6006DCA")]
		[Address(RVA = "0x366FB08", Offset = "0x366FB08", VA = "0x366FB08", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06006DCB RID: 28107 RVA: 0x0004EF48 File Offset: 0x0004D148
		[Token(Token = "0x6006DCB")]
		[Address(RVA = "0x366FB8C", Offset = "0x366FB8C", VA = "0x366FB8C", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(Empty other)
		{
			return default(bool);
		}

		// Token: 0x06006DCC RID: 28108 RVA: 0x0004EF60 File Offset: 0x0004D160
		[Token(Token = "0x6006DCC")]
		[Address(RVA = "0x366FBB8", Offset = "0x366FBB8", VA = "0x366FBB8", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06006DCD RID: 28109 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006DCD")]
		[Address(RVA = "0x366FBE4", Offset = "0x366FBE4", VA = "0x366FBE4", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06006DCE RID: 28110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DCE")]
		[Address(RVA = "0x366FC3C", Offset = "0x366FC3C", VA = "0x366FC3C", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06006DCF RID: 28111 RVA: 0x0004EF78 File Offset: 0x0004D178
		[Token(Token = "0x6006DCF")]
		[Address(RVA = "0x366FC50", Offset = "0x366FC50", VA = "0x366FC50", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06006DD0 RID: 28112 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DD0")]
		[Address(RVA = "0x366FC64", Offset = "0x366FC64", VA = "0x366FC64", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(Empty other)
		{
		}

		// Token: 0x06006DD1 RID: 28113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DD1")]
		[Address(RVA = "0x366FC98", Offset = "0x366FC98", VA = "0x366FC98", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x04002C2D RID: 11309
		[Token(Token = "0x4002C2D")]
		[FieldOffset(Offset = "0x0")]
		private static readonly MessageParser<Empty> _parser;

		// Token: 0x04002C2E RID: 11310
		[Token(Token = "0x4002C2E")]
		[FieldOffset(Offset = "0x10")]
		private UnknownFieldSet _unknownFields;
	}
}
