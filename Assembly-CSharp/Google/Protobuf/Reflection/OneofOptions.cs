using System;
using System.Diagnostics;
using Google.Protobuf.Collections;
using Il2CppDummyDll;

namespace Google.Protobuf.Reflection
{
	// Token: 0x02000BA4 RID: 2980
	[Token(Token = "0x2000BA4")]
	public sealed class OneofOptions : IExtendableMessage<OneofOptions>, IMessage<OneofOptions>, IMessage, IEquatable<OneofOptions>, IDeepCloneable<OneofOptions>
	{
		// Token: 0x1700095F RID: 2399
		// (get) Token: 0x06007259 RID: 29273 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700095F")]
		private ExtensionSet<OneofOptions> _Extensions
		{
			[Token(Token = "0x6007259")]
			[Address(RVA = "0x31FFB6C", Offset = "0x31FFB6C", VA = "0x31FFB6C")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000960 RID: 2400
		// (get) Token: 0x0600725A RID: 29274 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000960")]
		[DebuggerNonUserCode]
		public static MessageParser<OneofOptions> Parser
		{
			[Token(Token = "0x600725A")]
			[Address(RVA = "0x31FFB74", Offset = "0x31FFB74", VA = "0x31FFB74")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000961 RID: 2401
		// (get) Token: 0x0600725B RID: 29275 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000961")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Token(Token = "0x600725B")]
			[Address(RVA = "0x31FFBCC", Offset = "0x31FFBCC", VA = "0x31FFBCC")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000962 RID: 2402
		// (get) Token: 0x0600725C RID: 29276 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000962")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Token(Token = "0x600725C")]
			[Address(RVA = "0x31FFCD0", Offset = "0x31FFCD0", VA = "0x31FFCD0", Slot = "15")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600725D RID: 29277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600725D")]
		[Address(RVA = "0x31F5BB8", Offset = "0x31F5BB8", VA = "0x31F5BB8")]
		[DebuggerNonUserCode]
		public OneofOptions()
		{
		}

		// Token: 0x0600725E RID: 29278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600725E")]
		[Address(RVA = "0x31FFD1C", Offset = "0x31FFD1C", VA = "0x31FFD1C")]
		[DebuggerNonUserCode]
		public OneofOptions(OneofOptions other)
		{
		}

		// Token: 0x0600725F RID: 29279 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600725F")]
		[Address(RVA = "0x31F55D4", Offset = "0x31F55D4", VA = "0x31F55D4", Slot = "17")]
		[DebuggerNonUserCode]
		public OneofOptions Clone()
		{
			return null;
		}

		// Token: 0x17000963 RID: 2403
		// (get) Token: 0x06007260 RID: 29280 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000963")]
		[DebuggerNonUserCode]
		public RepeatedField<UninterpretedOption> UninterpretedOption
		{
			[Token(Token = "0x6007260")]
			[Address(RVA = "0x31FFDD8", Offset = "0x31FFDD8", VA = "0x31FFDD8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06007261 RID: 29281 RVA: 0x00050C58 File Offset: 0x0004EE58
		[Token(Token = "0x6007261")]
		[Address(RVA = "0x31FFDE0", Offset = "0x31FFDE0", VA = "0x31FFDE0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06007262 RID: 29282 RVA: 0x00050C70 File Offset: 0x0004EE70
		[Token(Token = "0x6007262")]
		[Address(RVA = "0x31FFE44", Offset = "0x31FFE44", VA = "0x31FFE44", Slot = "16")]
		[DebuggerNonUserCode]
		public bool Equals(OneofOptions other)
		{
			return default(bool);
		}

		// Token: 0x06007263 RID: 29283 RVA: 0x00050C88 File Offset: 0x0004EE88
		[Token(Token = "0x6007263")]
		[Address(RVA = "0x31FFEE8", Offset = "0x31FFEE8", VA = "0x31FFEE8", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06007264 RID: 29284 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007264")]
		[Address(RVA = "0x31FFF54", Offset = "0x31FFF54", VA = "0x31FFF54", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06007265 RID: 29285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007265")]
		[Address(RVA = "0x31FFFAC", Offset = "0x31FFFAC", VA = "0x31FFFAC", Slot = "13")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06007266 RID: 29286 RVA: 0x00050CA0 File Offset: 0x0004EEA0
		[Token(Token = "0x6007266")]
		[Address(RVA = "0x320008C", Offset = "0x320008C", VA = "0x320008C", Slot = "14")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06007267 RID: 29287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007267")]
		[Address(RVA = "0x31F5C40", Offset = "0x31F5C40", VA = "0x31F5C40", Slot = "11")]
		[DebuggerNonUserCode]
		public void MergeFrom(OneofOptions other)
		{
		}

		// Token: 0x06007268 RID: 29288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007268")]
		[Address(RVA = "0x320015C", Offset = "0x320015C", VA = "0x320015C", Slot = "12")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06007269 RID: 29289 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007269")]
		public TValue GetExtension<TValue>(Extension<OneofOptions, TValue> extension)
		{
			return null;
		}

		// Token: 0x0600726A RID: 29290 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600726A")]
		public RepeatedField<TValue> GetExtension<TValue>(RepeatedExtension<OneofOptions, TValue> extension)
		{
			return null;
		}

		// Token: 0x0600726B RID: 29291 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600726B")]
		public RepeatedField<TValue> GetOrInitializeExtension<TValue>(RepeatedExtension<OneofOptions, TValue> extension)
		{
			return null;
		}

		// Token: 0x0600726C RID: 29292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600726C")]
		public void SetExtension<TValue>(Extension<OneofOptions, TValue> extension, TValue value)
		{
		}

		// Token: 0x0600726D RID: 29293 RVA: 0x00050CB8 File Offset: 0x0004EEB8
		[Token(Token = "0x600726D")]
		public bool HasExtension<TValue>(Extension<OneofOptions, TValue> extension)
		{
			return default(bool);
		}

		// Token: 0x0600726E RID: 29294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600726E")]
		public void ClearExtension<TValue>(Extension<OneofOptions, TValue> extension)
		{
		}

		// Token: 0x0600726F RID: 29295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600726F")]
		public void ClearExtension<TValue>(RepeatedExtension<OneofOptions, TValue> extension)
		{
		}

		// Token: 0x04002E7B RID: 11899
		[Token(Token = "0x4002E7B")]
		[FieldOffset(Offset = "0x0")]
		private static readonly MessageParser<OneofOptions> _parser;

		// Token: 0x04002E7C RID: 11900
		[Token(Token = "0x4002E7C")]
		[FieldOffset(Offset = "0x10")]
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002E7D RID: 11901
		[Token(Token = "0x4002E7D")]
		[FieldOffset(Offset = "0x18")]
		internal ExtensionSet<OneofOptions> _extensions;

		// Token: 0x04002E7E RID: 11902
		[Token(Token = "0x4002E7E")]
		public const int UninterpretedOptionFieldNumber = 999;

		// Token: 0x04002E7F RID: 11903
		[Token(Token = "0x4002E7F")]
		[FieldOffset(Offset = "0x8")]
		private static readonly FieldCodec<UninterpretedOption> _repeated_uninterpretedOption_codec;

		// Token: 0x04002E80 RID: 11904
		[Token(Token = "0x4002E80")]
		[FieldOffset(Offset = "0x20")]
		private readonly RepeatedField<UninterpretedOption> uninterpretedOption_;
	}
}
