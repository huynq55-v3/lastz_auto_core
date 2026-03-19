using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Google.Protobuf.WellKnownTypes
{
	// Token: 0x02000B42 RID: 2882
	[Token(Token = "0x2000B42")]
	public sealed class FieldMask : IMessage<FieldMask>, IMessage, IEquatable<FieldMask>, IDeepCloneable<FieldMask>, ICustomDiagnosticMessage
	{
		// Token: 0x17000814 RID: 2068
		// (get) Token: 0x06006DD8 RID: 28120 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000814")]
		[DebuggerNonUserCode]
		public static MessageParser<FieldMask> Parser
		{
			[Token(Token = "0x6006DD8")]
			[Address(RVA = "0x36704A0", Offset = "0x36704A0", VA = "0x36704A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000815 RID: 2069
		// (get) Token: 0x06006DD9 RID: 28121 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000815")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Token(Token = "0x6006DD9")]
			[Address(RVA = "0x36704F8", Offset = "0x36704F8", VA = "0x36704F8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000816 RID: 2070
		// (get) Token: 0x06006DDA RID: 28122 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000816")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Token(Token = "0x6006DDA")]
			[Address(RVA = "0x36705FC", Offset = "0x36705FC", VA = "0x36705FC", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006DDB RID: 28123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DDB")]
		[Address(RVA = "0x3670648", Offset = "0x3670648", VA = "0x3670648")]
		[DebuggerNonUserCode]
		public FieldMask()
		{
		}

		// Token: 0x06006DDC RID: 28124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DDC")]
		[Address(RVA = "0x36706D0", Offset = "0x36706D0", VA = "0x36706D0")]
		[DebuggerNonUserCode]
		public FieldMask(FieldMask other)
		{
		}

		// Token: 0x06006DDD RID: 28125 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006DDD")]
		[Address(RVA = "0x367075C", Offset = "0x367075C", VA = "0x367075C", Slot = "10")]
		[DebuggerNonUserCode]
		public FieldMask Clone()
		{
			return null;
		}

		// Token: 0x17000817 RID: 2071
		// (get) Token: 0x06006DDE RID: 28126 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000817")]
		[DebuggerNonUserCode]
		public RepeatedField<string> Paths
		{
			[Token(Token = "0x6006DDE")]
			[Address(RVA = "0x36707BC", Offset = "0x36707BC", VA = "0x36707BC")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006DDF RID: 28127 RVA: 0x0004EF90 File Offset: 0x0004D190
		[Token(Token = "0x6006DDF")]
		[Address(RVA = "0x36707C4", Offset = "0x36707C4", VA = "0x36707C4", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06006DE0 RID: 28128 RVA: 0x0004EFA8 File Offset: 0x0004D1A8
		[Token(Token = "0x6006DE0")]
		[Address(RVA = "0x3670828", Offset = "0x3670828", VA = "0x3670828", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(FieldMask other)
		{
			return default(bool);
		}

		// Token: 0x06006DE1 RID: 28129 RVA: 0x0004EFC0 File Offset: 0x0004D1C0
		[Token(Token = "0x6006DE1")]
		[Address(RVA = "0x36708B8", Offset = "0x36708B8", VA = "0x36708B8", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06006DE2 RID: 28130 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006DE2")]
		[Address(RVA = "0x3670904", Offset = "0x3670904", VA = "0x3670904", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06006DE3 RID: 28131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DE3")]
		[Address(RVA = "0x367095C", Offset = "0x367095C", VA = "0x367095C", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06006DE4 RID: 28132 RVA: 0x0004EFD8 File Offset: 0x0004D1D8
		[Token(Token = "0x6006DE4")]
		[Address(RVA = "0x3670A14", Offset = "0x3670A14", VA = "0x3670A14", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06006DE5 RID: 28133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DE5")]
		[Address(RVA = "0x3670ABC", Offset = "0x3670ABC", VA = "0x3670ABC", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(FieldMask other)
		{
		}

		// Token: 0x06006DE6 RID: 28134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DE6")]
		[Address(RVA = "0x3670B44", Offset = "0x3670B44", VA = "0x3670B44", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06006DE7 RID: 28135 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006DE7")]
		[Address(RVA = "0x3670C2C", Offset = "0x3670C2C", VA = "0x3670C2C")]
		internal static string ToJson(IList<string> paths, bool diagnosticOnly)
		{
			return null;
		}

		// Token: 0x06006DE8 RID: 28136 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006DE8")]
		[Address(RVA = "0x3670FC0", Offset = "0x3670FC0", VA = "0x3670FC0", Slot = "11")]
		public string ToDiagnosticString()
		{
			return null;
		}

		// Token: 0x06006DE9 RID: 28137 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006DE9")]
		[Address(RVA = "0x367101C", Offset = "0x367101C", VA = "0x367101C")]
		public static FieldMask FromString(string value)
		{
			return null;
		}

		// Token: 0x06006DEA RID: 28138 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006DEA")]
		public static FieldMask FromString<T>(string value) where T : IMessage
		{
			return null;
		}

		// Token: 0x06006DEB RID: 28139 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006DEB")]
		public static FieldMask FromStringEnumerable<T>(IEnumerable<string> paths) where T : IMessage
		{
			return null;
		}

		// Token: 0x06006DEC RID: 28140 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006DEC")]
		public static FieldMask FromFieldNumbers<T>(params int[] fieldNumbers) where T : IMessage
		{
			return null;
		}

		// Token: 0x06006DED RID: 28141 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006DED")]
		public static FieldMask FromFieldNumbers<T>(IEnumerable<int> fieldNumbers) where T : IMessage
		{
			return null;
		}

		// Token: 0x06006DEE RID: 28142 RVA: 0x0004EFF0 File Offset: 0x0004D1F0
		[Token(Token = "0x6006DEE")]
		[Address(RVA = "0x36710F8", Offset = "0x36710F8", VA = "0x36710F8")]
		private static bool IsPathValid(string input)
		{
			return default(bool);
		}

		// Token: 0x06006DEF RID: 28143 RVA: 0x0004F008 File Offset: 0x0004D208
		[Token(Token = "0x6006DEF")]
		public static bool IsValid<T>(FieldMask fieldMask) where T : IMessage
		{
			return default(bool);
		}

		// Token: 0x06006DF0 RID: 28144 RVA: 0x0004F020 File Offset: 0x0004D220
		[Token(Token = "0x6006DF0")]
		[Address(RVA = "0x36711A8", Offset = "0x36711A8", VA = "0x36711A8")]
		public static bool IsValid(MessageDescriptor descriptor, FieldMask fieldMask)
		{
			return default(bool);
		}

		// Token: 0x06006DF1 RID: 28145 RVA: 0x0004F038 File Offset: 0x0004D238
		[Token(Token = "0x6006DF1")]
		public static bool IsValid<T>(string path) where T : IMessage
		{
			return default(bool);
		}

		// Token: 0x06006DF2 RID: 28146 RVA: 0x0004F050 File Offset: 0x0004D250
		[Token(Token = "0x6006DF2")]
		[Address(RVA = "0x367148C", Offset = "0x367148C", VA = "0x367148C")]
		public static bool IsValid(MessageDescriptor descriptor, string path)
		{
			return default(bool);
		}

		// Token: 0x06006DF3 RID: 28147 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006DF3")]
		[Address(RVA = "0x3671564", Offset = "0x3671564", VA = "0x3671564")]
		public FieldMask Normalize()
		{
			return null;
		}

		// Token: 0x06006DF4 RID: 28148 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006DF4")]
		[Address(RVA = "0x36715CC", Offset = "0x36715CC", VA = "0x36715CC")]
		public FieldMask Union(params FieldMask[] otherMasks)
		{
			return null;
		}

		// Token: 0x06006DF5 RID: 28149 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006DF5")]
		[Address(RVA = "0x3671688", Offset = "0x3671688", VA = "0x3671688")]
		public FieldMask Intersection(FieldMask additionalMask)
		{
			return null;
		}

		// Token: 0x06006DF6 RID: 28150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DF6")]
		[Address(RVA = "0x3671970", Offset = "0x3671970", VA = "0x3671970")]
		public void Merge(IMessage source, IMessage destination, FieldMask.MergeOptions options)
		{
		}

		// Token: 0x06006DF7 RID: 28151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DF7")]
		[Address(RVA = "0x3671A00", Offset = "0x3671A00", VA = "0x3671A00")]
		public void Merge(IMessage source, IMessage destination)
		{
		}

		// Token: 0x04002C31 RID: 11313
		[Token(Token = "0x4002C31")]
		[FieldOffset(Offset = "0x0")]
		private static readonly MessageParser<FieldMask> _parser;

		// Token: 0x04002C32 RID: 11314
		[Token(Token = "0x4002C32")]
		[FieldOffset(Offset = "0x10")]
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002C33 RID: 11315
		[Token(Token = "0x4002C33")]
		public const int PathsFieldNumber = 1;

		// Token: 0x04002C34 RID: 11316
		[Token(Token = "0x4002C34")]
		[FieldOffset(Offset = "0x8")]
		private static readonly FieldCodec<string> _repeated_paths_codec;

		// Token: 0x04002C35 RID: 11317
		[Token(Token = "0x4002C35")]
		[FieldOffset(Offset = "0x18")]
		private readonly RepeatedField<string> paths_;

		// Token: 0x04002C36 RID: 11318
		[Token(Token = "0x4002C36")]
		private const char FIELD_PATH_SEPARATOR = ',';

		// Token: 0x04002C37 RID: 11319
		[Token(Token = "0x4002C37")]
		private const char FIELD_SEPARATOR_REGEX = '.';

		// Token: 0x02000B43 RID: 2883
		[Token(Token = "0x2000B43")]
		public sealed class MergeOptions
		{
			// Token: 0x17000818 RID: 2072
			// (get) Token: 0x06006DF9 RID: 28153 RVA: 0x0004F068 File Offset: 0x0004D268
			// (set) Token: 0x06006DFA RID: 28154 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000818")]
			public bool ReplaceMessageFields
			{
				[Token(Token = "0x6006DF9")]
				[Address(RVA = "0x3671BBC", Offset = "0x3671BBC", VA = "0x3671BBC")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6006DFA")]
				[Address(RVA = "0x3671BC4", Offset = "0x3671BC4", VA = "0x3671BC4")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17000819 RID: 2073
			// (get) Token: 0x06006DFB RID: 28155 RVA: 0x0004F080 File Offset: 0x0004D280
			// (set) Token: 0x06006DFC RID: 28156 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000819")]
			public bool ReplaceRepeatedFields
			{
				[Token(Token = "0x6006DFB")]
				[Address(RVA = "0x3671BD0", Offset = "0x3671BD0", VA = "0x3671BD0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6006DFC")]
				[Address(RVA = "0x3671BD8", Offset = "0x3671BD8", VA = "0x3671BD8")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x1700081A RID: 2074
			// (get) Token: 0x06006DFD RID: 28157 RVA: 0x0004F098 File Offset: 0x0004D298
			// (set) Token: 0x06006DFE RID: 28158 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700081A")]
			public bool ReplacePrimitiveFields
			{
				[Token(Token = "0x6006DFD")]
				[Address(RVA = "0x3671BE4", Offset = "0x3671BE4", VA = "0x3671BE4")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6006DFE")]
				[Address(RVA = "0x3671BEC", Offset = "0x3671BEC", VA = "0x3671BEC")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x06006DFF RID: 28159 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006DFF")]
			[Address(RVA = "0x3671A7C", Offset = "0x3671A7C", VA = "0x3671A7C")]
			public MergeOptions()
			{
			}
		}
	}
}
