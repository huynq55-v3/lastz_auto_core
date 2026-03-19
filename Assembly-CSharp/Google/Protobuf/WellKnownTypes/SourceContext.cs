using System;
using System.Diagnostics;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Google.Protobuf.WellKnownTypes
{
	// Token: 0x02000B46 RID: 2886
	[Token(Token = "0x2000B46")]
	public sealed class SourceContext : IMessage<SourceContext>, IMessage, IEquatable<SourceContext>, IDeepCloneable<SourceContext>
	{
		// Token: 0x1700081C RID: 2076
		// (get) Token: 0x06006E06 RID: 28166 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700081C")]
		[DebuggerNonUserCode]
		public static MessageParser<SourceContext> Parser
		{
			[Token(Token = "0x6006E06")]
			[Address(RVA = "0x36722E0", Offset = "0x36722E0", VA = "0x36722E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700081D RID: 2077
		// (get) Token: 0x06006E07 RID: 28167 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700081D")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Token(Token = "0x6006E07")]
			[Address(RVA = "0x3672338", Offset = "0x3672338", VA = "0x3672338")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700081E RID: 2078
		// (get) Token: 0x06006E08 RID: 28168 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700081E")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Token(Token = "0x6006E08")]
			[Address(RVA = "0x367243C", Offset = "0x367243C", VA = "0x367243C", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006E09 RID: 28169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E09")]
		[Address(RVA = "0x366B774", Offset = "0x366B774", VA = "0x366B774")]
		[DebuggerNonUserCode]
		public SourceContext()
		{
		}

		// Token: 0x06006E0A RID: 28170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E0A")]
		[Address(RVA = "0x3672488", Offset = "0x3672488", VA = "0x3672488")]
		[DebuggerNonUserCode]
		public SourceContext(SourceContext other)
		{
		}

		// Token: 0x06006E0B RID: 28171 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006E0B")]
		[Address(RVA = "0x366ACF0", Offset = "0x366ACF0", VA = "0x366ACF0", Slot = "10")]
		[DebuggerNonUserCode]
		public SourceContext Clone()
		{
			return null;
		}

		// Token: 0x1700081F RID: 2079
		// (get) Token: 0x06006E0C RID: 28172 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006E0D RID: 28173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700081F")]
		[DebuggerNonUserCode]
		public string FileName
		{
			[Token(Token = "0x6006E0C")]
			[Address(RVA = "0x36724D8", Offset = "0x36724D8", VA = "0x36724D8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6006E0D")]
			[Address(RVA = "0x36724E0", Offset = "0x36724E0", VA = "0x36724E0")]
			set
			{
			}
		}

		// Token: 0x06006E0E RID: 28174 RVA: 0x0004F0C8 File Offset: 0x0004D2C8
		[Token(Token = "0x6006E0E")]
		[Address(RVA = "0x367255C", Offset = "0x367255C", VA = "0x367255C", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06006E0F RID: 28175 RVA: 0x0004F0E0 File Offset: 0x0004D2E0
		[Token(Token = "0x6006E0F")]
		[Address(RVA = "0x36725C0", Offset = "0x36725C0", VA = "0x36725C0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(SourceContext other)
		{
			return default(bool);
		}

		// Token: 0x06006E10 RID: 28176 RVA: 0x0004F0F8 File Offset: 0x0004D2F8
		[Token(Token = "0x6006E10")]
		[Address(RVA = "0x3672620", Offset = "0x3672620", VA = "0x3672620", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06006E11 RID: 28177 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006E11")]
		[Address(RVA = "0x3672680", Offset = "0x3672680", VA = "0x3672680", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06006E12 RID: 28178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E12")]
		[Address(RVA = "0x36726D8", Offset = "0x36726D8", VA = "0x36726D8", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06006E13 RID: 28179 RVA: 0x0004F110 File Offset: 0x0004D310
		[Token(Token = "0x6006E13")]
		[Address(RVA = "0x3672748", Offset = "0x3672748", VA = "0x3672748", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06006E14 RID: 28180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E14")]
		[Address(RVA = "0x366B7CC", Offset = "0x366B7CC", VA = "0x366B7CC", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(SourceContext other)
		{
		}

		// Token: 0x06006E15 RID: 28181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E15")]
		[Address(RVA = "0x36727DC", Offset = "0x36727DC", VA = "0x36727DC", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x04002C3E RID: 11326
		[Token(Token = "0x4002C3E")]
		[FieldOffset(Offset = "0x0")]
		private static readonly MessageParser<SourceContext> _parser;

		// Token: 0x04002C3F RID: 11327
		[Token(Token = "0x4002C3F")]
		[FieldOffset(Offset = "0x10")]
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002C40 RID: 11328
		[Token(Token = "0x4002C40")]
		public const int FileNameFieldNumber = 1;

		// Token: 0x04002C41 RID: 11329
		[Token(Token = "0x4002C41")]
		[FieldOffset(Offset = "0x18")]
		private string fileName_;
	}
}
