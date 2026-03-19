using System;
using System.Diagnostics;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Google.Protobuf.WellKnownTypes
{
	// Token: 0x02000B35 RID: 2869
	[Token(Token = "0x2000B35")]
	public sealed class Api : IMessage<Api>, IMessage, IEquatable<Api>, IDeepCloneable<Api>
	{
		// Token: 0x170007F0 RID: 2032
		// (get) Token: 0x06006D4E RID: 27982 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007F0")]
		[DebuggerNonUserCode]
		public static MessageParser<Api> Parser
		{
			[Token(Token = "0x6006D4E")]
			[Address(RVA = "0x366A8A4", Offset = "0x366A8A4", VA = "0x366A8A4")]
			get
			{
				return null;
			}
		}

		// Token: 0x170007F1 RID: 2033
		// (get) Token: 0x06006D4F RID: 27983 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007F1")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Token(Token = "0x6006D4F")]
			[Address(RVA = "0x366A8FC", Offset = "0x366A8FC", VA = "0x366A8FC")]
			get
			{
				return null;
			}
		}

		// Token: 0x170007F2 RID: 2034
		// (get) Token: 0x06006D50 RID: 27984 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007F2")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Token(Token = "0x6006D50")]
			[Address(RVA = "0x366AA00", Offset = "0x366AA00", VA = "0x366AA00", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006D51 RID: 27985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D51")]
		[Address(RVA = "0x366AA4C", Offset = "0x366AA4C", VA = "0x366AA4C")]
		[DebuggerNonUserCode]
		public Api()
		{
		}

		// Token: 0x06006D52 RID: 27986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D52")]
		[Address(RVA = "0x366ABB0", Offset = "0x366ABB0", VA = "0x366ABB0")]
		[DebuggerNonUserCode]
		public Api(Api other)
		{
		}

		// Token: 0x06006D53 RID: 27987 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D53")]
		[Address(RVA = "0x366AD50", Offset = "0x366AD50", VA = "0x366AD50", Slot = "10")]
		[DebuggerNonUserCode]
		public Api Clone()
		{
			return null;
		}

		// Token: 0x170007F3 RID: 2035
		// (get) Token: 0x06006D54 RID: 27988 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006D55 RID: 27989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007F3")]
		[DebuggerNonUserCode]
		public string Name
		{
			[Token(Token = "0x6006D54")]
			[Address(RVA = "0x366ADB0", Offset = "0x366ADB0", VA = "0x366ADB0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6006D55")]
			[Address(RVA = "0x366ADB8", Offset = "0x366ADB8", VA = "0x366ADB8")]
			set
			{
			}
		}

		// Token: 0x170007F4 RID: 2036
		// (get) Token: 0x06006D56 RID: 27990 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007F4")]
		[DebuggerNonUserCode]
		public RepeatedField<Method> Methods
		{
			[Token(Token = "0x6006D56")]
			[Address(RVA = "0x366AE34", Offset = "0x366AE34", VA = "0x366AE34")]
			get
			{
				return null;
			}
		}

		// Token: 0x170007F5 RID: 2037
		// (get) Token: 0x06006D57 RID: 27991 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007F5")]
		[DebuggerNonUserCode]
		public RepeatedField<Option> Options
		{
			[Token(Token = "0x6006D57")]
			[Address(RVA = "0x366AE3C", Offset = "0x366AE3C", VA = "0x366AE3C")]
			get
			{
				return null;
			}
		}

		// Token: 0x170007F6 RID: 2038
		// (get) Token: 0x06006D58 RID: 27992 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006D59 RID: 27993 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007F6")]
		[DebuggerNonUserCode]
		public string Version
		{
			[Token(Token = "0x6006D58")]
			[Address(RVA = "0x366AE44", Offset = "0x366AE44", VA = "0x366AE44")]
			get
			{
				return null;
			}
			[Token(Token = "0x6006D59")]
			[Address(RVA = "0x366AE4C", Offset = "0x366AE4C", VA = "0x366AE4C")]
			set
			{
			}
		}

		// Token: 0x170007F7 RID: 2039
		// (get) Token: 0x06006D5A RID: 27994 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006D5B RID: 27995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007F7")]
		[DebuggerNonUserCode]
		public SourceContext SourceContext
		{
			[Token(Token = "0x6006D5A")]
			[Address(RVA = "0x366AEC8", Offset = "0x366AEC8", VA = "0x366AEC8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6006D5B")]
			[Address(RVA = "0x366AED0", Offset = "0x366AED0", VA = "0x366AED0")]
			set
			{
			}
		}

		// Token: 0x170007F8 RID: 2040
		// (get) Token: 0x06006D5C RID: 27996 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007F8")]
		[DebuggerNonUserCode]
		public RepeatedField<Mixin> Mixins
		{
			[Token(Token = "0x6006D5C")]
			[Address(RVA = "0x366AED8", Offset = "0x366AED8", VA = "0x366AED8")]
			get
			{
				return null;
			}
		}

		// Token: 0x170007F9 RID: 2041
		// (get) Token: 0x06006D5D RID: 27997 RVA: 0x0004ECF0 File Offset: 0x0004CEF0
		// (set) Token: 0x06006D5E RID: 27998 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007F9")]
		[DebuggerNonUserCode]
		public Syntax Syntax
		{
			[Token(Token = "0x6006D5D")]
			[Address(RVA = "0x366AEE0", Offset = "0x366AEE0", VA = "0x366AEE0")]
			get
			{
				return Syntax.Proto2;
			}
			[Token(Token = "0x6006D5E")]
			[Address(RVA = "0x366AEE8", Offset = "0x366AEE8", VA = "0x366AEE8")]
			set
			{
			}
		}

		// Token: 0x06006D5F RID: 27999 RVA: 0x0004ED08 File Offset: 0x0004CF08
		[Token(Token = "0x6006D5F")]
		[Address(RVA = "0x366AEF0", Offset = "0x366AEF0", VA = "0x366AEF0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06006D60 RID: 28000 RVA: 0x0004ED20 File Offset: 0x0004CF20
		[Token(Token = "0x6006D60")]
		[Address(RVA = "0x366AF54", Offset = "0x366AF54", VA = "0x366AF54", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(Api other)
		{
			return default(bool);
		}

		// Token: 0x06006D61 RID: 28001 RVA: 0x0004ED38 File Offset: 0x0004CF38
		[Token(Token = "0x6006D61")]
		[Address(RVA = "0x366B088", Offset = "0x366B088", VA = "0x366B088", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06006D62 RID: 28002 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D62")]
		[Address(RVA = "0x366B19C", Offset = "0x366B19C", VA = "0x366B19C", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06006D63 RID: 28003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D63")]
		[Address(RVA = "0x366B1F4", Offset = "0x366B1F4", VA = "0x366B1F4", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06006D64 RID: 28004 RVA: 0x0004ED50 File Offset: 0x0004CF50
		[Token(Token = "0x6006D64")]
		[Address(RVA = "0x366B3E8", Offset = "0x366B3E8", VA = "0x366B3E8", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06006D65 RID: 28005 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D65")]
		[Address(RVA = "0x366B5F8", Offset = "0x366B5F8", VA = "0x366B5F8", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(Api other)
		{
		}

		// Token: 0x06006D66 RID: 28006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D66")]
		[Address(RVA = "0x366B830", Offset = "0x366B830", VA = "0x366B830", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x04002BF1 RID: 11249
		[Token(Token = "0x4002BF1")]
		[FieldOffset(Offset = "0x0")]
		private static readonly MessageParser<Api> _parser;

		// Token: 0x04002BF2 RID: 11250
		[Token(Token = "0x4002BF2")]
		[FieldOffset(Offset = "0x10")]
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002BF3 RID: 11251
		[Token(Token = "0x4002BF3")]
		public const int NameFieldNumber = 1;

		// Token: 0x04002BF4 RID: 11252
		[Token(Token = "0x4002BF4")]
		[FieldOffset(Offset = "0x18")]
		private string name_;

		// Token: 0x04002BF5 RID: 11253
		[Token(Token = "0x4002BF5")]
		public const int MethodsFieldNumber = 2;

		// Token: 0x04002BF6 RID: 11254
		[Token(Token = "0x4002BF6")]
		[FieldOffset(Offset = "0x8")]
		private static readonly FieldCodec<Method> _repeated_methods_codec;

		// Token: 0x04002BF7 RID: 11255
		[Token(Token = "0x4002BF7")]
		[FieldOffset(Offset = "0x20")]
		private readonly RepeatedField<Method> methods_;

		// Token: 0x04002BF8 RID: 11256
		[Token(Token = "0x4002BF8")]
		public const int OptionsFieldNumber = 3;

		// Token: 0x04002BF9 RID: 11257
		[Token(Token = "0x4002BF9")]
		[FieldOffset(Offset = "0x10")]
		private static readonly FieldCodec<Option> _repeated_options_codec;

		// Token: 0x04002BFA RID: 11258
		[Token(Token = "0x4002BFA")]
		[FieldOffset(Offset = "0x28")]
		private readonly RepeatedField<Option> options_;

		// Token: 0x04002BFB RID: 11259
		[Token(Token = "0x4002BFB")]
		public const int VersionFieldNumber = 4;

		// Token: 0x04002BFC RID: 11260
		[Token(Token = "0x4002BFC")]
		[FieldOffset(Offset = "0x30")]
		private string version_;

		// Token: 0x04002BFD RID: 11261
		[Token(Token = "0x4002BFD")]
		public const int SourceContextFieldNumber = 5;

		// Token: 0x04002BFE RID: 11262
		[Token(Token = "0x4002BFE")]
		[FieldOffset(Offset = "0x38")]
		private SourceContext sourceContext_;

		// Token: 0x04002BFF RID: 11263
		[Token(Token = "0x4002BFF")]
		public const int MixinsFieldNumber = 6;

		// Token: 0x04002C00 RID: 11264
		[Token(Token = "0x4002C00")]
		[FieldOffset(Offset = "0x18")]
		private static readonly FieldCodec<Mixin> _repeated_mixins_codec;

		// Token: 0x04002C01 RID: 11265
		[Token(Token = "0x4002C01")]
		[FieldOffset(Offset = "0x40")]
		private readonly RepeatedField<Mixin> mixins_;

		// Token: 0x04002C02 RID: 11266
		[Token(Token = "0x4002C02")]
		public const int SyntaxFieldNumber = 7;

		// Token: 0x04002C03 RID: 11267
		[Token(Token = "0x4002C03")]
		[FieldOffset(Offset = "0x48")]
		private Syntax syntax_;
	}
}
