using System;
using System.IO;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Google.Protobuf
{
	// Token: 0x02000AEB RID: 2795
	[Token(Token = "0x2000AEB")]
	public sealed class CodedInputStream : IDisposable
	{
		// Token: 0x06006AA3 RID: 27299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006AA3")]
		[Address(RVA = "0x349C84C", Offset = "0x349C84C", VA = "0x349C84C")]
		public CodedInputStream(byte[] buffer)
		{
		}

		// Token: 0x06006AA4 RID: 27300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006AA4")]
		[Address(RVA = "0x349D250", Offset = "0x349D250", VA = "0x349D250")]
		public CodedInputStream(byte[] buffer, int offset, int length)
		{
		}

		// Token: 0x06006AA5 RID: 27301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006AA5")]
		[Address(RVA = "0x349D3A8", Offset = "0x349D3A8", VA = "0x349D3A8")]
		public CodedInputStream(Stream input)
		{
		}

		// Token: 0x06006AA6 RID: 27302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006AA6")]
		[Address(RVA = "0x349D3B0", Offset = "0x349D3B0", VA = "0x349D3B0")]
		public CodedInputStream(Stream input, bool leaveOpen)
		{
		}

		// Token: 0x06006AA7 RID: 27303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006AA7")]
		[Address(RVA = "0x349D1CC", Offset = "0x349D1CC", VA = "0x349D1CC")]
		internal CodedInputStream(Stream input, byte[] buffer, int bufferPos, int bufferSize, bool leaveOpen)
		{
		}

		// Token: 0x06006AA8 RID: 27304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006AA8")]
		[Address(RVA = "0x349D46C", Offset = "0x349D46C", VA = "0x349D46C")]
		internal CodedInputStream(Stream input, byte[] buffer, int bufferPos, int bufferSize, int sizeLimit, int recursionLimit, bool leaveOpen)
		{
		}

		// Token: 0x06006AA9 RID: 27305 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006AA9")]
		[Address(RVA = "0x349D53C", Offset = "0x349D53C", VA = "0x349D53C")]
		public static CodedInputStream CreateWithLimits(Stream input, int sizeLimit, int recursionLimit)
		{
			return null;
		}

		// Token: 0x170007AD RID: 1965
		// (get) Token: 0x06006AAA RID: 27306 RVA: 0x0004DBB0 File Offset: 0x0004BDB0
		[Token(Token = "0x170007AD")]
		public long Position
		{
			[Token(Token = "0x6006AAA")]
			[Address(RVA = "0x349D5FC", Offset = "0x349D5FC", VA = "0x349D5FC")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x170007AE RID: 1966
		// (get) Token: 0x06006AAB RID: 27307 RVA: 0x0004DBC8 File Offset: 0x0004BDC8
		[Token(Token = "0x170007AE")]
		internal uint LastTag
		{
			[Token(Token = "0x6006AAB")]
			[Address(RVA = "0x349D63C", Offset = "0x349D63C", VA = "0x349D63C")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x170007AF RID: 1967
		// (get) Token: 0x06006AAC RID: 27308 RVA: 0x0004DBE0 File Offset: 0x0004BDE0
		[Token(Token = "0x170007AF")]
		public int SizeLimit
		{
			[Token(Token = "0x6006AAC")]
			[Address(RVA = "0x349D644", Offset = "0x349D644", VA = "0x349D644")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170007B0 RID: 1968
		// (get) Token: 0x06006AAD RID: 27309 RVA: 0x0004DBF8 File Offset: 0x0004BDF8
		[Token(Token = "0x170007B0")]
		public int RecursionLimit
		{
			[Token(Token = "0x6006AAD")]
			[Address(RVA = "0x349D64C", Offset = "0x349D64C", VA = "0x349D64C")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170007B1 RID: 1969
		// (get) Token: 0x06006AAE RID: 27310 RVA: 0x0004DC10 File Offset: 0x0004BE10
		// (set) Token: 0x06006AAF RID: 27311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007B1")]
		internal bool DiscardUnknownFields
		{
			[Token(Token = "0x6006AAE")]
			[Address(RVA = "0x349D654", Offset = "0x349D654", VA = "0x349D654")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6006AAF")]
			[Address(RVA = "0x349D65C", Offset = "0x349D65C", VA = "0x349D65C")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170007B2 RID: 1970
		// (get) Token: 0x06006AB0 RID: 27312 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006AB1 RID: 27313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007B2")]
		internal ExtensionRegistry ExtensionRegistry
		{
			[Token(Token = "0x6006AB0")]
			[Address(RVA = "0x349D668", Offset = "0x349D668", VA = "0x349D668")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006AB1")]
			[Address(RVA = "0x349D670", Offset = "0x349D670", VA = "0x349D670")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06006AB2 RID: 27314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006AB2")]
		[Address(RVA = "0x349D678", Offset = "0x349D678", VA = "0x349D678", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x06006AB3 RID: 27315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006AB3")]
		[Address(RVA = "0x349D6A4", Offset = "0x349D6A4", VA = "0x349D6A4")]
		internal void CheckReadEndOfStreamTag()
		{
		}

		// Token: 0x06006AB4 RID: 27316 RVA: 0x0004DC28 File Offset: 0x0004BE28
		[Token(Token = "0x6006AB4")]
		[Address(RVA = "0x349D6DC", Offset = "0x349D6DC", VA = "0x349D6DC")]
		public uint PeekTag()
		{
			return 0U;
		}

		// Token: 0x06006AB5 RID: 27317 RVA: 0x0004DC40 File Offset: 0x0004BE40
		[Token(Token = "0x6006AB5")]
		[Address(RVA = "0x349D71C", Offset = "0x349D71C", VA = "0x349D71C")]
		public uint ReadTag()
		{
			return 0U;
		}

		// Token: 0x06006AB6 RID: 27318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006AB6")]
		[Address(RVA = "0x349DA20", Offset = "0x349DA20", VA = "0x349DA20")]
		public void SkipLastField()
		{
		}

		// Token: 0x06006AB7 RID: 27319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006AB7")]
		[Address(RVA = "0x349DB34", Offset = "0x349DB34", VA = "0x349DB34")]
		internal void SkipGroup(uint startGroupTag)
		{
		}

		// Token: 0x06006AB8 RID: 27320 RVA: 0x0004DC58 File Offset: 0x0004BE58
		[Token(Token = "0x6006AB8")]
		[Address(RVA = "0x349DD6C", Offset = "0x349DD6C", VA = "0x349DD6C")]
		public double ReadDouble()
		{
			return 0.0;
		}

		// Token: 0x06006AB9 RID: 27321 RVA: 0x0004DC70 File Offset: 0x0004BE70
		[Token(Token = "0x6006AB9")]
		[Address(RVA = "0x349E224", Offset = "0x349E224", VA = "0x349E224")]
		public float ReadFloat()
		{
			return 0f;
		}

		// Token: 0x06006ABA RID: 27322 RVA: 0x0004DC88 File Offset: 0x0004BE88
		[Token(Token = "0x6006ABA")]
		[Address(RVA = "0x349E7C4", Offset = "0x349E7C4", VA = "0x349E7C4")]
		public ulong ReadUInt64()
		{
			return 0UL;
		}

		// Token: 0x06006ABB RID: 27323 RVA: 0x0004DCA0 File Offset: 0x0004BEA0
		[Token(Token = "0x6006ABB")]
		[Address(RVA = "0x349E8C8", Offset = "0x349E8C8", VA = "0x349E8C8")]
		public long ReadInt64()
		{
			return 0L;
		}

		// Token: 0x06006ABC RID: 27324 RVA: 0x0004DCB8 File Offset: 0x0004BEB8
		[Token(Token = "0x6006ABC")]
		[Address(RVA = "0x349E8CC", Offset = "0x349E8CC", VA = "0x349E8CC")]
		public int ReadInt32()
		{
			return 0;
		}

		// Token: 0x06006ABD RID: 27325 RVA: 0x0004DCD0 File Offset: 0x0004BED0
		[Token(Token = "0x6006ABD")]
		[Address(RVA = "0x349DCA4", Offset = "0x349DCA4", VA = "0x349DCA4")]
		public ulong ReadFixed64()
		{
			return 0UL;
		}

		// Token: 0x06006ABE RID: 27326 RVA: 0x0004DCE8 File Offset: 0x0004BEE8
		[Token(Token = "0x6006ABE")]
		[Address(RVA = "0x349DCA0", Offset = "0x349DCA0", VA = "0x349DCA0")]
		public uint ReadFixed32()
		{
			return 0U;
		}

		// Token: 0x06006ABF RID: 27327 RVA: 0x0004DD00 File Offset: 0x0004BF00
		[Token(Token = "0x6006ABF")]
		[Address(RVA = "0x349EA2C", Offset = "0x349EA2C", VA = "0x349EA2C")]
		public bool ReadBool()
		{
			return default(bool);
		}

		// Token: 0x06006AC0 RID: 27328 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006AC0")]
		[Address(RVA = "0x349EA44", Offset = "0x349EA44", VA = "0x349EA44")]
		public string ReadString()
		{
			return null;
		}

		// Token: 0x06006AC1 RID: 27329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006AC1")]
		[Address(RVA = "0x349EB68", Offset = "0x349EB68", VA = "0x349EB68")]
		public void ReadMessage(IMessage builder)
		{
		}

		// Token: 0x06006AC2 RID: 27330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006AC2")]
		[Address(RVA = "0x349ED8C", Offset = "0x349ED8C", VA = "0x349ED8C")]
		public void ReadGroup(IMessage builder)
		{
		}

		// Token: 0x06006AC3 RID: 27331 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006AC3")]
		[Address(RVA = "0x349EE78", Offset = "0x349EE78", VA = "0x349EE78")]
		public ByteString ReadBytes()
		{
			return null;
		}

		// Token: 0x06006AC4 RID: 27332 RVA: 0x0004DD18 File Offset: 0x0004BF18
		[Token(Token = "0x6006AC4")]
		[Address(RVA = "0x349EF50", Offset = "0x349EF50", VA = "0x349EF50")]
		public uint ReadUInt32()
		{
			return 0U;
		}

		// Token: 0x06006AC5 RID: 27333 RVA: 0x0004DD30 File Offset: 0x0004BF30
		[Token(Token = "0x6006AC5")]
		[Address(RVA = "0x349EF54", Offset = "0x349EF54", VA = "0x349EF54")]
		public int ReadEnum()
		{
			return 0;
		}

		// Token: 0x06006AC6 RID: 27334 RVA: 0x0004DD48 File Offset: 0x0004BF48
		[Token(Token = "0x6006AC6")]
		[Address(RVA = "0x349EF58", Offset = "0x349EF58", VA = "0x349EF58")]
		public int ReadSFixed32()
		{
			return 0;
		}

		// Token: 0x06006AC7 RID: 27335 RVA: 0x0004DD60 File Offset: 0x0004BF60
		[Token(Token = "0x6006AC7")]
		[Address(RVA = "0x349EF5C", Offset = "0x349EF5C", VA = "0x349EF5C")]
		public long ReadSFixed64()
		{
			return 0L;
		}

		// Token: 0x06006AC8 RID: 27336 RVA: 0x0004DD78 File Offset: 0x0004BF78
		[Token(Token = "0x6006AC8")]
		[Address(RVA = "0x349EF60", Offset = "0x349EF60", VA = "0x349EF60")]
		public int ReadSInt32()
		{
			return 0;
		}

		// Token: 0x06006AC9 RID: 27337 RVA: 0x0004DD90 File Offset: 0x0004BF90
		[Token(Token = "0x6006AC9")]
		[Address(RVA = "0x349EF8C", Offset = "0x349EF8C", VA = "0x349EF8C")]
		public long ReadSInt64()
		{
			return 0L;
		}

		// Token: 0x06006ACA RID: 27338 RVA: 0x0004DDA8 File Offset: 0x0004BFA8
		[Token(Token = "0x6006ACA")]
		[Address(RVA = "0x349DCA8", Offset = "0x349DCA8", VA = "0x349DCA8")]
		public int ReadLength()
		{
			return 0;
		}

		// Token: 0x06006ACB RID: 27339 RVA: 0x0004DDC0 File Offset: 0x0004BFC0
		[Token(Token = "0x6006ACB")]
		[Address(RVA = "0x349EFB8", Offset = "0x349EFB8", VA = "0x349EFB8")]
		public bool MaybeConsumeTag(uint tag)
		{
			return default(bool);
		}

		// Token: 0x06006ACC RID: 27340 RVA: 0x0004DDD8 File Offset: 0x0004BFD8
		[Token(Token = "0x6006ACC")]
		[Address(RVA = "0x349F014", Offset = "0x349F014", VA = "0x349F014")]
		internal static float? ReadFloatWrapperLittleEndian(CodedInputStream input)
		{
			return default(float?);
		}

		// Token: 0x06006ACD RID: 27341 RVA: 0x0004DDF0 File Offset: 0x0004BFF0
		[Token(Token = "0x6006ACD")]
		[Address(RVA = "0x349F13C", Offset = "0x349F13C", VA = "0x349F13C")]
		internal static float? ReadFloatWrapperSlow(CodedInputStream input)
		{
			return default(float?);
		}

		// Token: 0x06006ACE RID: 27342 RVA: 0x0004DE08 File Offset: 0x0004C008
		[Token(Token = "0x6006ACE")]
		[Address(RVA = "0x349F208", Offset = "0x349F208", VA = "0x349F208")]
		internal static double? ReadDoubleWrapperLittleEndian(CodedInputStream input)
		{
			return default(double?);
		}

		// Token: 0x06006ACF RID: 27343 RVA: 0x0004DE20 File Offset: 0x0004C020
		[Token(Token = "0x6006ACF")]
		[Address(RVA = "0x349F338", Offset = "0x349F338", VA = "0x349F338")]
		internal static double? ReadDoubleWrapperSlow(CodedInputStream input)
		{
			return default(double?);
		}

		// Token: 0x06006AD0 RID: 27344 RVA: 0x0004DE38 File Offset: 0x0004C038
		[Token(Token = "0x6006AD0")]
		[Address(RVA = "0x349F40C", Offset = "0x349F40C", VA = "0x349F40C")]
		internal static bool? ReadBoolWrapper(CodedInputStream input)
		{
			return default(bool?);
		}

		// Token: 0x06006AD1 RID: 27345 RVA: 0x0004DE50 File Offset: 0x0004C050
		[Token(Token = "0x6006AD1")]
		[Address(RVA = "0x349F4A0", Offset = "0x349F4A0", VA = "0x349F4A0")]
		internal static uint? ReadUInt32Wrapper(CodedInputStream input)
		{
			return default(uint?);
		}

		// Token: 0x06006AD2 RID: 27346 RVA: 0x0004DE68 File Offset: 0x0004C068
		[Token(Token = "0x6006AD2")]
		[Address(RVA = "0x349F5B4", Offset = "0x349F5B4", VA = "0x349F5B4")]
		private static uint? ReadUInt32WrapperSlow(CodedInputStream input)
		{
			return default(uint?);
		}

		// Token: 0x06006AD3 RID: 27347 RVA: 0x0004DE80 File Offset: 0x0004C080
		[Token(Token = "0x6006AD3")]
		[Address(RVA = "0x349F678", Offset = "0x349F678", VA = "0x349F678")]
		internal static int? ReadInt32Wrapper(CodedInputStream input)
		{
			return default(int?);
		}

		// Token: 0x06006AD4 RID: 27348 RVA: 0x0004DE98 File Offset: 0x0004C098
		[Token(Token = "0x6006AD4")]
		[Address(RVA = "0x349F700", Offset = "0x349F700", VA = "0x349F700")]
		internal static ulong? ReadUInt64Wrapper(CodedInputStream input)
		{
			return default(ulong?);
		}

		// Token: 0x06006AD5 RID: 27349 RVA: 0x0004DEB0 File Offset: 0x0004C0B0
		[Token(Token = "0x6006AD5")]
		[Address(RVA = "0x349F81C", Offset = "0x349F81C", VA = "0x349F81C")]
		internal static ulong? ReadUInt64WrapperSlow(CodedInputStream input)
		{
			return default(ulong?);
		}

		// Token: 0x06006AD6 RID: 27350 RVA: 0x0004DEC8 File Offset: 0x0004C0C8
		[Token(Token = "0x6006AD6")]
		[Address(RVA = "0x349F8E8", Offset = "0x349F8E8", VA = "0x349F8E8")]
		internal static long? ReadInt64Wrapper(CodedInputStream input)
		{
			return default(long?);
		}

		// Token: 0x06006AD7 RID: 27351 RVA: 0x0004DEE0 File Offset: 0x0004C0E0
		[Token(Token = "0x6006AD7")]
		[Address(RVA = "0x349F974", Offset = "0x349F974", VA = "0x349F974")]
		private uint SlowReadRawVarint32()
		{
			return 0U;
		}

		// Token: 0x06006AD8 RID: 27352 RVA: 0x0004DEF8 File Offset: 0x0004C0F8
		[Token(Token = "0x6006AD8")]
		[Address(RVA = "0x349D84C", Offset = "0x349D84C", VA = "0x349D84C")]
		internal uint ReadRawVarint32()
		{
			return 0U;
		}

		// Token: 0x06006AD9 RID: 27353 RVA: 0x0004DF10 File Offset: 0x0004C110
		[Token(Token = "0x6006AD9")]
		[Address(RVA = "0x349FAB8", Offset = "0x349FAB8", VA = "0x349FAB8")]
		internal static uint ReadRawVarint32(Stream input)
		{
			return 0U;
		}

		// Token: 0x06006ADA RID: 27354 RVA: 0x0004DF28 File Offset: 0x0004C128
		[Token(Token = "0x6006ADA")]
		[Address(RVA = "0x349E7C8", Offset = "0x349E7C8", VA = "0x349E7C8")]
		internal ulong ReadRawVarint64()
		{
			return 0UL;
		}

		// Token: 0x06006ADB RID: 27355 RVA: 0x0004DF40 File Offset: 0x0004C140
		[Token(Token = "0x6006ADB")]
		[Address(RVA = "0x349E8D0", Offset = "0x349E8D0", VA = "0x349E8D0")]
		internal uint ReadRawLittleEndian32()
		{
			return 0U;
		}

		// Token: 0x06006ADC RID: 27356 RVA: 0x0004DF58 File Offset: 0x0004C158
		[Token(Token = "0x6006ADC")]
		[Address(RVA = "0x349E018", Offset = "0x349E018", VA = "0x349E018")]
		internal ulong ReadRawLittleEndian64()
		{
			return 0UL;
		}

		// Token: 0x06006ADD RID: 27357 RVA: 0x0004DF70 File Offset: 0x0004C170
		[Token(Token = "0x6006ADD")]
		[Address(RVA = "0x349EF7C", Offset = "0x349EF7C", VA = "0x349EF7C")]
		internal static int DecodeZigZag32(uint n)
		{
			return 0;
		}

		// Token: 0x06006ADE RID: 27358 RVA: 0x0004DF88 File Offset: 0x0004C188
		[Token(Token = "0x6006ADE")]
		[Address(RVA = "0x349EFA8", Offset = "0x349EFA8", VA = "0x349EFA8")]
		internal static long DecodeZigZag64(ulong n)
		{
			return 0L;
		}

		// Token: 0x06006ADF RID: 27359 RVA: 0x0004DFA0 File Offset: 0x0004C1A0
		[Token(Token = "0x6006ADF")]
		[Address(RVA = "0x349ECD0", Offset = "0x349ECD0", VA = "0x349ECD0")]
		internal int PushLimit(int byteLimit)
		{
			return 0;
		}

		// Token: 0x06006AE0 RID: 27360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006AE0")]
		[Address(RVA = "0x349FB80", Offset = "0x349FB80", VA = "0x349FB80")]
		private void RecomputeBufferSizeAfterLimit()
		{
		}

		// Token: 0x06006AE1 RID: 27361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006AE1")]
		[Address(RVA = "0x349ED58", Offset = "0x349ED58", VA = "0x349ED58")]
		internal void PopLimit(int oldLimit)
		{
		}

		// Token: 0x170007B3 RID: 1971
		// (get) Token: 0x06006AE2 RID: 27362 RVA: 0x0004DFB8 File Offset: 0x0004C1B8
		[Token(Token = "0x170007B3")]
		internal bool ReachedLimit
		{
			[Token(Token = "0x6006AE2")]
			[Address(RVA = "0x349D9F0", Offset = "0x349D9F0", VA = "0x349D9F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170007B4 RID: 1972
		// (get) Token: 0x06006AE3 RID: 27363 RVA: 0x0004DFD0 File Offset: 0x0004C1D0
		[Token(Token = "0x170007B4")]
		public bool IsAtEnd
		{
			[Token(Token = "0x6006AE3")]
			[Address(RVA = "0x349D9BC", Offset = "0x349D9BC", VA = "0x349D9BC")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06006AE4 RID: 27364 RVA: 0x0004DFE8 File Offset: 0x0004C1E8
		[Token(Token = "0x6006AE4")]
		[Address(RVA = "0x349FBB0", Offset = "0x349FBB0", VA = "0x349FBB0")]
		private bool RefillBuffer(bool mustSucceed)
		{
			return default(bool);
		}

		// Token: 0x06006AE5 RID: 27365 RVA: 0x0004E000 File Offset: 0x0004C200
		[Token(Token = "0x6006AE5")]
		[Address(RVA = "0x349FA5C", Offset = "0x349FA5C", VA = "0x349FA5C")]
		internal byte ReadRawByte()
		{
			return 0;
		}

		// Token: 0x06006AE6 RID: 27366 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006AE6")]
		[Address(RVA = "0x349E32C", Offset = "0x349E32C", VA = "0x349E32C")]
		internal byte[] ReadRawBytes(int size)
		{
			return null;
		}

		// Token: 0x06006AE7 RID: 27367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006AE7")]
		[Address(RVA = "0x349DCAC", Offset = "0x349DCAC", VA = "0x349DCAC")]
		private void SkipRawBytes(int size)
		{
		}

		// Token: 0x06006AE8 RID: 27368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006AE8")]
		[Address(RVA = "0x349FD14", Offset = "0x349FD14", VA = "0x349FD14")]
		private void SkipImpl(int amountToSkip)
		{
		}

		// Token: 0x04002B02 RID: 11010
		[Token(Token = "0x4002B02")]
		[FieldOffset(Offset = "0x10")]
		private readonly bool leaveOpen;

		// Token: 0x04002B03 RID: 11011
		[Token(Token = "0x4002B03")]
		[FieldOffset(Offset = "0x18")]
		private readonly byte[] buffer;

		// Token: 0x04002B04 RID: 11012
		[Token(Token = "0x4002B04")]
		[FieldOffset(Offset = "0x20")]
		private int bufferSize;

		// Token: 0x04002B05 RID: 11013
		[Token(Token = "0x4002B05")]
		[FieldOffset(Offset = "0x24")]
		private int bufferSizeAfterLimit;

		// Token: 0x04002B06 RID: 11014
		[Token(Token = "0x4002B06")]
		[FieldOffset(Offset = "0x28")]
		private int bufferPos;

		// Token: 0x04002B07 RID: 11015
		[Token(Token = "0x4002B07")]
		[FieldOffset(Offset = "0x30")]
		private readonly Stream input;

		// Token: 0x04002B08 RID: 11016
		[Token(Token = "0x4002B08")]
		[FieldOffset(Offset = "0x38")]
		private uint lastTag;

		// Token: 0x04002B09 RID: 11017
		[Token(Token = "0x4002B09")]
		[FieldOffset(Offset = "0x3C")]
		private uint nextTag;

		// Token: 0x04002B0A RID: 11018
		[Token(Token = "0x4002B0A")]
		[FieldOffset(Offset = "0x40")]
		private bool hasNextTag;

		// Token: 0x04002B0B RID: 11019
		[Token(Token = "0x4002B0B")]
		internal const int DefaultRecursionLimit = 100;

		// Token: 0x04002B0C RID: 11020
		[Token(Token = "0x4002B0C")]
		internal const int DefaultSizeLimit = 2147483647;

		// Token: 0x04002B0D RID: 11021
		[Token(Token = "0x4002B0D")]
		internal const int BufferSize = 4096;

		// Token: 0x04002B0E RID: 11022
		[Token(Token = "0x4002B0E")]
		[FieldOffset(Offset = "0x44")]
		private int totalBytesRetired;

		// Token: 0x04002B0F RID: 11023
		[Token(Token = "0x4002B0F")]
		[FieldOffset(Offset = "0x48")]
		private int currentLimit;

		// Token: 0x04002B10 RID: 11024
		[Token(Token = "0x4002B10")]
		[FieldOffset(Offset = "0x4C")]
		private int recursionDepth;

		// Token: 0x04002B11 RID: 11025
		[Token(Token = "0x4002B11")]
		[FieldOffset(Offset = "0x50")]
		private readonly int recursionLimit;

		// Token: 0x04002B12 RID: 11026
		[Token(Token = "0x4002B12")]
		[FieldOffset(Offset = "0x54")]
		private readonly int sizeLimit;
	}
}
