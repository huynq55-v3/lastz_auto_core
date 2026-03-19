using System;
using System.Diagnostics;
using Google.Protobuf.Collections;
using Il2CppDummyDll;

namespace Google.Protobuf.Reflection
{
	// Token: 0x02000B9F RID: 2975
	[Token(Token = "0x2000B9F")]
	public sealed class FieldOptions : IExtendableMessage<FieldOptions>, IMessage<FieldOptions>, IMessage, IEquatable<FieldOptions>, IDeepCloneable<FieldOptions>
	{
		// Token: 0x1700094E RID: 2382
		// (get) Token: 0x06007226 RID: 29222 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700094E")]
		private ExtensionSet<FieldOptions> _Extensions
		{
			[Token(Token = "0x6007226")]
			[Address(RVA = "0x31FE880", Offset = "0x31FE880", VA = "0x31FE880")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700094F RID: 2383
		// (get) Token: 0x06007227 RID: 29223 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700094F")]
		[DebuggerNonUserCode]
		public static MessageParser<FieldOptions> Parser
		{
			[Token(Token = "0x6007227")]
			[Address(RVA = "0x31FE888", Offset = "0x31FE888", VA = "0x31FE888")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000950 RID: 2384
		// (get) Token: 0x06007228 RID: 29224 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000950")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Token(Token = "0x6007228")]
			[Address(RVA = "0x31FE8E0", Offset = "0x31FE8E0", VA = "0x31FE8E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000951 RID: 2385
		// (get) Token: 0x06007229 RID: 29225 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000951")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Token(Token = "0x6007229")]
			[Address(RVA = "0x31FE9E4", Offset = "0x31FE9E4", VA = "0x31FE9E4", Slot = "15")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600722A RID: 29226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600722A")]
		[Address(RVA = "0x31F4CB4", Offset = "0x31F4CB4", VA = "0x31F4CB4")]
		[DebuggerNonUserCode]
		public FieldOptions()
		{
		}

		// Token: 0x0600722B RID: 29227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600722B")]
		[Address(RVA = "0x31FEA30", Offset = "0x31FEA30", VA = "0x31FEA30")]
		[DebuggerNonUserCode]
		public FieldOptions(FieldOptions other)
		{
		}

		// Token: 0x0600722C RID: 29228 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600722C")]
		[Address(RVA = "0x31F3990", Offset = "0x31F3990", VA = "0x31F3990", Slot = "17")]
		[DebuggerNonUserCode]
		public FieldOptions Clone()
		{
			return null;
		}

		// Token: 0x17000952 RID: 2386
		// (get) Token: 0x0600722D RID: 29229 RVA: 0x00050AC0 File Offset: 0x0004ECC0
		// (set) Token: 0x0600722E RID: 29230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000952")]
		[DebuggerNonUserCode]
		public FieldOptions.Types.CType Ctype
		{
			[Token(Token = "0x600722D")]
			[Address(RVA = "0x31FEB1C", Offset = "0x31FEB1C", VA = "0x31FEB1C")]
			get
			{
				return FieldOptions.Types.CType.String;
			}
			[Token(Token = "0x600722E")]
			[Address(RVA = "0x31FEB8C", Offset = "0x31FEB8C", VA = "0x31FEB8C")]
			set
			{
			}
		}

		// Token: 0x17000953 RID: 2387
		// (get) Token: 0x0600722F RID: 29231 RVA: 0x00050AD8 File Offset: 0x0004ECD8
		[Token(Token = "0x17000953")]
		[DebuggerNonUserCode]
		public bool HasCtype
		{
			[Token(Token = "0x600722F")]
			[Address(RVA = "0x31FEB9C", Offset = "0x31FEB9C", VA = "0x31FEB9C")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06007230 RID: 29232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007230")]
		[Address(RVA = "0x31FEBA8", Offset = "0x31FEBA8", VA = "0x31FEBA8")]
		[DebuggerNonUserCode]
		public void ClearCtype()
		{
		}

		// Token: 0x17000954 RID: 2388
		// (get) Token: 0x06007231 RID: 29233 RVA: 0x00050AF0 File Offset: 0x0004ECF0
		// (set) Token: 0x06007232 RID: 29234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000954")]
		[DebuggerNonUserCode]
		public bool Packed
		{
			[Token(Token = "0x6007231")]
			[Address(RVA = "0x31FEBB8", Offset = "0x31FEBB8", VA = "0x31FEBB8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6007232")]
			[Address(RVA = "0x31FEC28", Offset = "0x31FEC28", VA = "0x31FEC28")]
			set
			{
			}
		}

		// Token: 0x17000955 RID: 2389
		// (get) Token: 0x06007233 RID: 29235 RVA: 0x00050B08 File Offset: 0x0004ED08
		[Token(Token = "0x17000955")]
		[DebuggerNonUserCode]
		public bool HasPacked
		{
			[Token(Token = "0x6007233")]
			[Address(RVA = "0x31FEC40", Offset = "0x31FEC40", VA = "0x31FEC40")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06007234 RID: 29236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007234")]
		[Address(RVA = "0x31FEC4C", Offset = "0x31FEC4C", VA = "0x31FEC4C")]
		[DebuggerNonUserCode]
		public void ClearPacked()
		{
		}

		// Token: 0x17000956 RID: 2390
		// (get) Token: 0x06007235 RID: 29237 RVA: 0x00050B20 File Offset: 0x0004ED20
		// (set) Token: 0x06007236 RID: 29238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000956")]
		[DebuggerNonUserCode]
		public FieldOptions.Types.JSType Jstype
		{
			[Token(Token = "0x6007235")]
			[Address(RVA = "0x31FEC5C", Offset = "0x31FEC5C", VA = "0x31FEC5C")]
			get
			{
				return FieldOptions.Types.JSType.JsNormal;
			}
			[Token(Token = "0x6007236")]
			[Address(RVA = "0x31FECCC", Offset = "0x31FECCC", VA = "0x31FECCC")]
			set
			{
			}
		}

		// Token: 0x17000957 RID: 2391
		// (get) Token: 0x06007237 RID: 29239 RVA: 0x00050B38 File Offset: 0x0004ED38
		[Token(Token = "0x17000957")]
		[DebuggerNonUserCode]
		public bool HasJstype
		{
			[Token(Token = "0x6007237")]
			[Address(RVA = "0x31FECE0", Offset = "0x31FECE0", VA = "0x31FECE0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06007238 RID: 29240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007238")]
		[Address(RVA = "0x31FECEC", Offset = "0x31FECEC", VA = "0x31FECEC")]
		[DebuggerNonUserCode]
		public void ClearJstype()
		{
		}

		// Token: 0x17000958 RID: 2392
		// (get) Token: 0x06007239 RID: 29241 RVA: 0x00050B50 File Offset: 0x0004ED50
		// (set) Token: 0x0600723A RID: 29242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000958")]
		[DebuggerNonUserCode]
		public bool Lazy
		{
			[Token(Token = "0x6007239")]
			[Address(RVA = "0x31FECFC", Offset = "0x31FECFC", VA = "0x31FECFC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600723A")]
			[Address(RVA = "0x31FED6C", Offset = "0x31FED6C", VA = "0x31FED6C")]
			set
			{
			}
		}

		// Token: 0x17000959 RID: 2393
		// (get) Token: 0x0600723B RID: 29243 RVA: 0x00050B68 File Offset: 0x0004ED68
		[Token(Token = "0x17000959")]
		[DebuggerNonUserCode]
		public bool HasLazy
		{
			[Token(Token = "0x600723B")]
			[Address(RVA = "0x31FED84", Offset = "0x31FED84", VA = "0x31FED84")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600723C RID: 29244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600723C")]
		[Address(RVA = "0x31FED90", Offset = "0x31FED90", VA = "0x31FED90")]
		[DebuggerNonUserCode]
		public void ClearLazy()
		{
		}

		// Token: 0x1700095A RID: 2394
		// (get) Token: 0x0600723D RID: 29245 RVA: 0x00050B80 File Offset: 0x0004ED80
		// (set) Token: 0x0600723E RID: 29246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700095A")]
		[DebuggerNonUserCode]
		public bool Deprecated
		{
			[Token(Token = "0x600723D")]
			[Address(RVA = "0x31FEDA0", Offset = "0x31FEDA0", VA = "0x31FEDA0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600723E")]
			[Address(RVA = "0x31FEE10", Offset = "0x31FEE10", VA = "0x31FEE10")]
			set
			{
			}
		}

		// Token: 0x1700095B RID: 2395
		// (get) Token: 0x0600723F RID: 29247 RVA: 0x00050B98 File Offset: 0x0004ED98
		[Token(Token = "0x1700095B")]
		[DebuggerNonUserCode]
		public bool HasDeprecated
		{
			[Token(Token = "0x600723F")]
			[Address(RVA = "0x31FEE28", Offset = "0x31FEE28", VA = "0x31FEE28")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06007240 RID: 29248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007240")]
		[Address(RVA = "0x31FEE34", Offset = "0x31FEE34", VA = "0x31FEE34")]
		[DebuggerNonUserCode]
		public void ClearDeprecated()
		{
		}

		// Token: 0x1700095C RID: 2396
		// (get) Token: 0x06007241 RID: 29249 RVA: 0x00050BB0 File Offset: 0x0004EDB0
		// (set) Token: 0x06007242 RID: 29250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700095C")]
		[DebuggerNonUserCode]
		public bool Weak
		{
			[Token(Token = "0x6007241")]
			[Address(RVA = "0x31FEE44", Offset = "0x31FEE44", VA = "0x31FEE44")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6007242")]
			[Address(RVA = "0x31FEEB4", Offset = "0x31FEEB4", VA = "0x31FEEB4")]
			set
			{
			}
		}

		// Token: 0x1700095D RID: 2397
		// (get) Token: 0x06007243 RID: 29251 RVA: 0x00050BC8 File Offset: 0x0004EDC8
		[Token(Token = "0x1700095D")]
		[DebuggerNonUserCode]
		public bool HasWeak
		{
			[Token(Token = "0x6007243")]
			[Address(RVA = "0x31FEECC", Offset = "0x31FEECC", VA = "0x31FEECC")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06007244 RID: 29252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007244")]
		[Address(RVA = "0x31FEED8", Offset = "0x31FEED8", VA = "0x31FEED8")]
		[DebuggerNonUserCode]
		public void ClearWeak()
		{
		}

		// Token: 0x1700095E RID: 2398
		// (get) Token: 0x06007245 RID: 29253 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700095E")]
		[DebuggerNonUserCode]
		public RepeatedField<UninterpretedOption> UninterpretedOption
		{
			[Token(Token = "0x6007245")]
			[Address(RVA = "0x31FEEE8", Offset = "0x31FEEE8", VA = "0x31FEEE8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06007246 RID: 29254 RVA: 0x00050BE0 File Offset: 0x0004EDE0
		[Token(Token = "0x6007246")]
		[Address(RVA = "0x31FEEF0", Offset = "0x31FEEF0", VA = "0x31FEEF0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06007247 RID: 29255 RVA: 0x00050BF8 File Offset: 0x0004EDF8
		[Token(Token = "0x6007247")]
		[Address(RVA = "0x31FEF54", Offset = "0x31FEF54", VA = "0x31FEF54", Slot = "16")]
		[DebuggerNonUserCode]
		public bool Equals(FieldOptions other)
		{
			return default(bool);
		}

		// Token: 0x06007248 RID: 29256 RVA: 0x00050C10 File Offset: 0x0004EE10
		[Token(Token = "0x6007248")]
		[Address(RVA = "0x31FF0A0", Offset = "0x31FF0A0", VA = "0x31FF0A0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06007249 RID: 29257 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007249")]
		[Address(RVA = "0x31FF29C", Offset = "0x31FF29C", VA = "0x31FF29C", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600724A RID: 29258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600724A")]
		[Address(RVA = "0x31FF2F4", Offset = "0x31FF2F4", VA = "0x31FF2F4", Slot = "13")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600724B RID: 29259 RVA: 0x00050C28 File Offset: 0x0004EE28
		[Token(Token = "0x600724B")]
		[Address(RVA = "0x31FF50C", Offset = "0x31FF50C", VA = "0x31FF50C", Slot = "14")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600724C RID: 29260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600724C")]
		[Address(RVA = "0x31F4D3C", Offset = "0x31F4D3C", VA = "0x31F4D3C", Slot = "11")]
		[DebuggerNonUserCode]
		public void MergeFrom(FieldOptions other)
		{
		}

		// Token: 0x0600724D RID: 29261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600724D")]
		[Address(RVA = "0x31FF6A8", Offset = "0x31FF6A8", VA = "0x31FF6A8", Slot = "12")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600724E RID: 29262 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600724E")]
		public TValue GetExtension<TValue>(Extension<FieldOptions, TValue> extension)
		{
			return null;
		}

		// Token: 0x0600724F RID: 29263 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600724F")]
		public RepeatedField<TValue> GetExtension<TValue>(RepeatedExtension<FieldOptions, TValue> extension)
		{
			return null;
		}

		// Token: 0x06007250 RID: 29264 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007250")]
		public RepeatedField<TValue> GetOrInitializeExtension<TValue>(RepeatedExtension<FieldOptions, TValue> extension)
		{
			return null;
		}

		// Token: 0x06007251 RID: 29265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007251")]
		public void SetExtension<TValue>(Extension<FieldOptions, TValue> extension, TValue value)
		{
		}

		// Token: 0x06007252 RID: 29266 RVA: 0x00050C40 File Offset: 0x0004EE40
		[Token(Token = "0x6007252")]
		public bool HasExtension<TValue>(Extension<FieldOptions, TValue> extension)
		{
			return default(bool);
		}

		// Token: 0x06007253 RID: 29267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007253")]
		public void ClearExtension<TValue>(Extension<FieldOptions, TValue> extension)
		{
		}

		// Token: 0x06007254 RID: 29268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007254")]
		public void ClearExtension<TValue>(RepeatedExtension<FieldOptions, TValue> extension)
		{
		}

		// Token: 0x04002E59 RID: 11865
		[Token(Token = "0x4002E59")]
		[FieldOffset(Offset = "0x0")]
		private static readonly MessageParser<FieldOptions> _parser;

		// Token: 0x04002E5A RID: 11866
		[Token(Token = "0x4002E5A")]
		[FieldOffset(Offset = "0x10")]
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002E5B RID: 11867
		[Token(Token = "0x4002E5B")]
		[FieldOffset(Offset = "0x18")]
		internal ExtensionSet<FieldOptions> _extensions;

		// Token: 0x04002E5C RID: 11868
		[Token(Token = "0x4002E5C")]
		[FieldOffset(Offset = "0x20")]
		private int _hasBits0;

		// Token: 0x04002E5D RID: 11869
		[Token(Token = "0x4002E5D")]
		public const int CtypeFieldNumber = 1;

		// Token: 0x04002E5E RID: 11870
		[Token(Token = "0x4002E5E")]
		[FieldOffset(Offset = "0x8")]
		private static readonly FieldOptions.Types.CType CtypeDefaultValue;

		// Token: 0x04002E5F RID: 11871
		[Token(Token = "0x4002E5F")]
		[FieldOffset(Offset = "0x24")]
		private FieldOptions.Types.CType ctype_;

		// Token: 0x04002E60 RID: 11872
		[Token(Token = "0x4002E60")]
		public const int PackedFieldNumber = 2;

		// Token: 0x04002E61 RID: 11873
		[Token(Token = "0x4002E61")]
		[FieldOffset(Offset = "0xC")]
		private static readonly bool PackedDefaultValue;

		// Token: 0x04002E62 RID: 11874
		[Token(Token = "0x4002E62")]
		[FieldOffset(Offset = "0x28")]
		private bool packed_;

		// Token: 0x04002E63 RID: 11875
		[Token(Token = "0x4002E63")]
		public const int JstypeFieldNumber = 6;

		// Token: 0x04002E64 RID: 11876
		[Token(Token = "0x4002E64")]
		[FieldOffset(Offset = "0x10")]
		private static readonly FieldOptions.Types.JSType JstypeDefaultValue;

		// Token: 0x04002E65 RID: 11877
		[Token(Token = "0x4002E65")]
		[FieldOffset(Offset = "0x2C")]
		private FieldOptions.Types.JSType jstype_;

		// Token: 0x04002E66 RID: 11878
		[Token(Token = "0x4002E66")]
		public const int LazyFieldNumber = 5;

		// Token: 0x04002E67 RID: 11879
		[Token(Token = "0x4002E67")]
		[FieldOffset(Offset = "0x14")]
		private static readonly bool LazyDefaultValue;

		// Token: 0x04002E68 RID: 11880
		[Token(Token = "0x4002E68")]
		[FieldOffset(Offset = "0x30")]
		private bool lazy_;

		// Token: 0x04002E69 RID: 11881
		[Token(Token = "0x4002E69")]
		public const int DeprecatedFieldNumber = 3;

		// Token: 0x04002E6A RID: 11882
		[Token(Token = "0x4002E6A")]
		[FieldOffset(Offset = "0x15")]
		private static readonly bool DeprecatedDefaultValue;

		// Token: 0x04002E6B RID: 11883
		[Token(Token = "0x4002E6B")]
		[FieldOffset(Offset = "0x31")]
		private bool deprecated_;

		// Token: 0x04002E6C RID: 11884
		[Token(Token = "0x4002E6C")]
		public const int WeakFieldNumber = 10;

		// Token: 0x04002E6D RID: 11885
		[Token(Token = "0x4002E6D")]
		[FieldOffset(Offset = "0x16")]
		private static readonly bool WeakDefaultValue;

		// Token: 0x04002E6E RID: 11886
		[Token(Token = "0x4002E6E")]
		[FieldOffset(Offset = "0x32")]
		private bool weak_;

		// Token: 0x04002E6F RID: 11887
		[Token(Token = "0x4002E6F")]
		public const int UninterpretedOptionFieldNumber = 999;

		// Token: 0x04002E70 RID: 11888
		[Token(Token = "0x4002E70")]
		[FieldOffset(Offset = "0x18")]
		private static readonly FieldCodec<UninterpretedOption> _repeated_uninterpretedOption_codec;

		// Token: 0x04002E71 RID: 11889
		[Token(Token = "0x4002E71")]
		[FieldOffset(Offset = "0x38")]
		private readonly RepeatedField<UninterpretedOption> uninterpretedOption_;

		// Token: 0x02000BA0 RID: 2976
		[Token(Token = "0x2000BA0")]
		[DebuggerNonUserCode]
		public static class Types
		{
			// Token: 0x02000BA1 RID: 2977
			[Token(Token = "0x2000BA1")]
			public enum CType
			{
				// Token: 0x04002E73 RID: 11891
				[Token(Token = "0x4002E73")]
				[OriginalName("STRING")]
				String,
				// Token: 0x04002E74 RID: 11892
				[Token(Token = "0x4002E74")]
				[OriginalName("CORD")]
				Cord,
				// Token: 0x04002E75 RID: 11893
				[Token(Token = "0x4002E75")]
				[OriginalName("STRING_PIECE")]
				StringPiece
			}

			// Token: 0x02000BA2 RID: 2978
			[Token(Token = "0x2000BA2")]
			public enum JSType
			{
				// Token: 0x04002E77 RID: 11895
				[Token(Token = "0x4002E77")]
				[OriginalName("JS_NORMAL")]
				JsNormal,
				// Token: 0x04002E78 RID: 11896
				[Token(Token = "0x4002E78")]
				[OriginalName("JS_STRING")]
				JsString,
				// Token: 0x04002E79 RID: 11897
				[Token(Token = "0x4002E79")]
				[OriginalName("JS_NUMBER")]
				JsNumber
			}
		}
	}
}
