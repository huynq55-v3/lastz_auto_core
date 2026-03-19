using System;
using System.Diagnostics;
using Google.Protobuf.Collections;
using Il2CppDummyDll;

namespace Google.Protobuf.Reflection
{
	// Token: 0x02000BAA RID: 2986
	[Token(Token = "0x2000BAA")]
	public sealed class ServiceOptions : IExtendableMessage<ServiceOptions>, IMessage<ServiceOptions>, IMessage, IEquatable<ServiceOptions>, IDeepCloneable<ServiceOptions>
	{
		// Token: 0x17000974 RID: 2420
		// (get) Token: 0x060072B6 RID: 29366 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000974")]
		private ExtensionSet<ServiceOptions> _Extensions
		{
			[Token(Token = "0x60072B6")]
			[Address(RVA = "0x31A1B30", Offset = "0x31A1B30", VA = "0x31A1B30")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000975 RID: 2421
		// (get) Token: 0x060072B7 RID: 29367 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000975")]
		[DebuggerNonUserCode]
		public static MessageParser<ServiceOptions> Parser
		{
			[Token(Token = "0x60072B7")]
			[Address(RVA = "0x31A1B38", Offset = "0x31A1B38", VA = "0x31A1B38")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000976 RID: 2422
		// (get) Token: 0x060072B8 RID: 29368 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000976")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Token(Token = "0x60072B8")]
			[Address(RVA = "0x31A1B90", Offset = "0x31A1B90", VA = "0x31A1B90")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000977 RID: 2423
		// (get) Token: 0x060072B9 RID: 29369 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000977")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Token(Token = "0x60072B9")]
			[Address(RVA = "0x31A1C94", Offset = "0x31A1C94", VA = "0x31A1C94", Slot = "15")]
			get
			{
				return null;
			}
		}

		// Token: 0x060072BA RID: 29370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60072BA")]
		[Address(RVA = "0x31A1CE0", Offset = "0x31A1CE0", VA = "0x31A1CE0")]
		[DebuggerNonUserCode]
		public ServiceOptions()
		{
		}

		// Token: 0x060072BB RID: 29371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60072BB")]
		[Address(RVA = "0x31A1D68", Offset = "0x31A1D68", VA = "0x31A1D68")]
		[DebuggerNonUserCode]
		public ServiceOptions(ServiceOptions other)
		{
		}

		// Token: 0x060072BC RID: 29372 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072BC")]
		[Address(RVA = "0x31A1E34", Offset = "0x31A1E34", VA = "0x31A1E34", Slot = "17")]
		[DebuggerNonUserCode]
		public ServiceOptions Clone()
		{
			return null;
		}

		// Token: 0x17000978 RID: 2424
		// (get) Token: 0x060072BD RID: 29373 RVA: 0x00050E50 File Offset: 0x0004F050
		// (set) Token: 0x060072BE RID: 29374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000978")]
		[DebuggerNonUserCode]
		public bool Deprecated
		{
			[Token(Token = "0x60072BD")]
			[Address(RVA = "0x31A1E94", Offset = "0x31A1E94", VA = "0x31A1E94")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60072BE")]
			[Address(RVA = "0x31A1F04", Offset = "0x31A1F04", VA = "0x31A1F04")]
			set
			{
			}
		}

		// Token: 0x17000979 RID: 2425
		// (get) Token: 0x060072BF RID: 29375 RVA: 0x00050E68 File Offset: 0x0004F068
		[Token(Token = "0x17000979")]
		[DebuggerNonUserCode]
		public bool HasDeprecated
		{
			[Token(Token = "0x60072BF")]
			[Address(RVA = "0x31A1F1C", Offset = "0x31A1F1C", VA = "0x31A1F1C")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060072C0 RID: 29376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60072C0")]
		[Address(RVA = "0x31A1F28", Offset = "0x31A1F28", VA = "0x31A1F28")]
		[DebuggerNonUserCode]
		public void ClearDeprecated()
		{
		}

		// Token: 0x1700097A RID: 2426
		// (get) Token: 0x060072C1 RID: 29377 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700097A")]
		[DebuggerNonUserCode]
		public RepeatedField<UninterpretedOption> UninterpretedOption
		{
			[Token(Token = "0x60072C1")]
			[Address(RVA = "0x31A1F38", Offset = "0x31A1F38", VA = "0x31A1F38")]
			get
			{
				return null;
			}
		}

		// Token: 0x060072C2 RID: 29378 RVA: 0x00050E80 File Offset: 0x0004F080
		[Token(Token = "0x60072C2")]
		[Address(RVA = "0x31A1F40", Offset = "0x31A1F40", VA = "0x31A1F40", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x060072C3 RID: 29379 RVA: 0x00050E98 File Offset: 0x0004F098
		[Token(Token = "0x60072C3")]
		[Address(RVA = "0x31A1FA4", Offset = "0x31A1FA4", VA = "0x31A1FA4", Slot = "16")]
		[DebuggerNonUserCode]
		public bool Equals(ServiceOptions other)
		{
			return default(bool);
		}

		// Token: 0x060072C4 RID: 29380 RVA: 0x00050EB0 File Offset: 0x0004F0B0
		[Token(Token = "0x60072C4")]
		[Address(RVA = "0x31A2064", Offset = "0x31A2064", VA = "0x31A2064", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060072C5 RID: 29381 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072C5")]
		[Address(RVA = "0x31A2140", Offset = "0x31A2140", VA = "0x31A2140", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060072C6 RID: 29382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60072C6")]
		[Address(RVA = "0x31A2198", Offset = "0x31A2198", VA = "0x31A2198", Slot = "13")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060072C7 RID: 29383 RVA: 0x00050EC8 File Offset: 0x0004F0C8
		[Token(Token = "0x60072C7")]
		[Address(RVA = "0x31A22B0", Offset = "0x31A22B0", VA = "0x31A22B0", Slot = "14")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060072C8 RID: 29384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60072C8")]
		[Address(RVA = "0x31A2394", Offset = "0x31A2394", VA = "0x31A2394", Slot = "11")]
		[DebuggerNonUserCode]
		public void MergeFrom(ServiceOptions other)
		{
		}

		// Token: 0x060072C9 RID: 29385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60072C9")]
		[Address(RVA = "0x31A2464", Offset = "0x31A2464", VA = "0x31A2464", Slot = "12")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060072CA RID: 29386 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072CA")]
		public TValue GetExtension<TValue>(Extension<ServiceOptions, TValue> extension)
		{
			return null;
		}

		// Token: 0x060072CB RID: 29387 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072CB")]
		public RepeatedField<TValue> GetExtension<TValue>(RepeatedExtension<ServiceOptions, TValue> extension)
		{
			return null;
		}

		// Token: 0x060072CC RID: 29388 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072CC")]
		public RepeatedField<TValue> GetOrInitializeExtension<TValue>(RepeatedExtension<ServiceOptions, TValue> extension)
		{
			return null;
		}

		// Token: 0x060072CD RID: 29389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60072CD")]
		public void SetExtension<TValue>(Extension<ServiceOptions, TValue> extension, TValue value)
		{
		}

		// Token: 0x060072CE RID: 29390 RVA: 0x00050EE0 File Offset: 0x0004F0E0
		[Token(Token = "0x60072CE")]
		public bool HasExtension<TValue>(Extension<ServiceOptions, TValue> extension)
		{
			return default(bool);
		}

		// Token: 0x060072CF RID: 29391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60072CF")]
		public void ClearExtension<TValue>(Extension<ServiceOptions, TValue> extension)
		{
		}

		// Token: 0x060072D0 RID: 29392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60072D0")]
		public void ClearExtension<TValue>(RepeatedExtension<ServiceOptions, TValue> extension)
		{
		}

		// Token: 0x04002E9B RID: 11931
		[Token(Token = "0x4002E9B")]
		[FieldOffset(Offset = "0x0")]
		private static readonly MessageParser<ServiceOptions> _parser;

		// Token: 0x04002E9C RID: 11932
		[Token(Token = "0x4002E9C")]
		[FieldOffset(Offset = "0x10")]
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002E9D RID: 11933
		[Token(Token = "0x4002E9D")]
		[FieldOffset(Offset = "0x18")]
		internal ExtensionSet<ServiceOptions> _extensions;

		// Token: 0x04002E9E RID: 11934
		[Token(Token = "0x4002E9E")]
		[FieldOffset(Offset = "0x20")]
		private int _hasBits0;

		// Token: 0x04002E9F RID: 11935
		[Token(Token = "0x4002E9F")]
		public const int DeprecatedFieldNumber = 33;

		// Token: 0x04002EA0 RID: 11936
		[Token(Token = "0x4002EA0")]
		[FieldOffset(Offset = "0x8")]
		private static readonly bool DeprecatedDefaultValue;

		// Token: 0x04002EA1 RID: 11937
		[Token(Token = "0x4002EA1")]
		[FieldOffset(Offset = "0x24")]
		private bool deprecated_;

		// Token: 0x04002EA2 RID: 11938
		[Token(Token = "0x4002EA2")]
		public const int UninterpretedOptionFieldNumber = 999;

		// Token: 0x04002EA3 RID: 11939
		[Token(Token = "0x4002EA3")]
		[FieldOffset(Offset = "0x10")]
		private static readonly FieldCodec<UninterpretedOption> _repeated_uninterpretedOption_codec;

		// Token: 0x04002EA4 RID: 11940
		[Token(Token = "0x4002EA4")]
		[FieldOffset(Offset = "0x28")]
		private readonly RepeatedField<UninterpretedOption> uninterpretedOption_;
	}
}
