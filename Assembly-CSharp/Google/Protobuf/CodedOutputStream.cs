using System;
using System.IO;
using System.Text;
using Il2CppDummyDll;

namespace Google.Protobuf
{
	// Token: 0x02000AEC RID: 2796
	[Token(Token = "0x2000AEC")]
	public sealed class CodedOutputStream : IDisposable
	{
		// Token: 0x06006AE9 RID: 27369 RVA: 0x0004E018 File Offset: 0x0004C218
		[Token(Token = "0x6006AE9")]
		[Address(RVA = "0x36D5A58", Offset = "0x36D5A58", VA = "0x36D5A58")]
		public static int ComputeDoubleSize(double value)
		{
			return 0;
		}

		// Token: 0x06006AEA RID: 27370 RVA: 0x0004E030 File Offset: 0x0004C230
		[Token(Token = "0x6006AEA")]
		[Address(RVA = "0x36D5A60", Offset = "0x36D5A60", VA = "0x36D5A60")]
		public static int ComputeFloatSize(float value)
		{
			return 0;
		}

		// Token: 0x06006AEB RID: 27371 RVA: 0x0004E048 File Offset: 0x0004C248
		[Token(Token = "0x6006AEB")]
		[Address(RVA = "0x36D5A68", Offset = "0x36D5A68", VA = "0x36D5A68")]
		public static int ComputeUInt64Size(ulong value)
		{
			return 0;
		}

		// Token: 0x06006AEC RID: 27372 RVA: 0x0004E060 File Offset: 0x0004C260
		[Token(Token = "0x6006AEC")]
		[Address(RVA = "0x36D5B4C", Offset = "0x36D5B4C", VA = "0x36D5B4C")]
		public static int ComputeInt64Size(long value)
		{
			return 0;
		}

		// Token: 0x06006AED RID: 27373 RVA: 0x0004E078 File Offset: 0x0004C278
		[Token(Token = "0x6006AED")]
		[Address(RVA = "0x36D5BA0", Offset = "0x36D5BA0", VA = "0x36D5BA0")]
		public static int ComputeInt32Size(int value)
		{
			return 0;
		}

		// Token: 0x06006AEE RID: 27374 RVA: 0x0004E090 File Offset: 0x0004C290
		[Token(Token = "0x6006AEE")]
		[Address(RVA = "0x36D5C80", Offset = "0x36D5C80", VA = "0x36D5C80")]
		public static int ComputeFixed64Size(ulong value)
		{
			return 0;
		}

		// Token: 0x06006AEF RID: 27375 RVA: 0x0004E0A8 File Offset: 0x0004C2A8
		[Token(Token = "0x6006AEF")]
		[Address(RVA = "0x36D5C88", Offset = "0x36D5C88", VA = "0x36D5C88")]
		public static int ComputeFixed32Size(uint value)
		{
			return 0;
		}

		// Token: 0x06006AF0 RID: 27376 RVA: 0x0004E0C0 File Offset: 0x0004C2C0
		[Token(Token = "0x6006AF0")]
		[Address(RVA = "0x36D5C90", Offset = "0x36D5C90", VA = "0x36D5C90")]
		public static int ComputeBoolSize(bool value)
		{
			return 0;
		}

		// Token: 0x06006AF1 RID: 27377 RVA: 0x0004E0D8 File Offset: 0x0004C2D8
		[Token(Token = "0x6006AF1")]
		[Address(RVA = "0x36D5C98", Offset = "0x36D5C98", VA = "0x36D5C98")]
		public static int ComputeStringSize(string value)
		{
			return 0;
		}

		// Token: 0x06006AF2 RID: 27378 RVA: 0x0004E0F0 File Offset: 0x0004C2F0
		[Token(Token = "0x6006AF2")]
		[Address(RVA = "0x36D5DAC", Offset = "0x36D5DAC", VA = "0x36D5DAC")]
		public static int ComputeGroupSize(IMessage value)
		{
			return 0;
		}

		// Token: 0x06006AF3 RID: 27379 RVA: 0x0004E108 File Offset: 0x0004C308
		[Token(Token = "0x6006AF3")]
		[Address(RVA = "0x36D5E4C", Offset = "0x36D5E4C", VA = "0x36D5E4C")]
		public static int ComputeMessageSize(IMessage value)
		{
			return 0;
		}

		// Token: 0x06006AF4 RID: 27380 RVA: 0x0004E120 File Offset: 0x0004C320
		[Token(Token = "0x6006AF4")]
		[Address(RVA = "0x36D5F28", Offset = "0x36D5F28", VA = "0x36D5F28")]
		public static int ComputeBytesSize(ByteString value)
		{
			return 0;
		}

		// Token: 0x06006AF5 RID: 27381 RVA: 0x0004E138 File Offset: 0x0004C338
		[Token(Token = "0x6006AF5")]
		[Address(RVA = "0x36D5FB0", Offset = "0x36D5FB0", VA = "0x36D5FB0")]
		public static int ComputeUInt32Size(uint value)
		{
			return 0;
		}

		// Token: 0x06006AF6 RID: 27382 RVA: 0x0004E150 File Offset: 0x0004C350
		[Token(Token = "0x6006AF6")]
		[Address(RVA = "0x36D6040", Offset = "0x36D6040", VA = "0x36D6040")]
		public static int ComputeEnumSize(int value)
		{
			return 0;
		}

		// Token: 0x06006AF7 RID: 27383 RVA: 0x0004E168 File Offset: 0x0004C368
		[Token(Token = "0x6006AF7")]
		[Address(RVA = "0x36D6094", Offset = "0x36D6094", VA = "0x36D6094")]
		public static int ComputeSFixed32Size(int value)
		{
			return 0;
		}

		// Token: 0x06006AF8 RID: 27384 RVA: 0x0004E180 File Offset: 0x0004C380
		[Token(Token = "0x6006AF8")]
		[Address(RVA = "0x36D609C", Offset = "0x36D609C", VA = "0x36D609C")]
		public static int ComputeSFixed64Size(long value)
		{
			return 0;
		}

		// Token: 0x06006AF9 RID: 27385 RVA: 0x0004E198 File Offset: 0x0004C398
		[Token(Token = "0x6006AF9")]
		[Address(RVA = "0x36D60A4", Offset = "0x36D60A4", VA = "0x36D60A4")]
		public static int ComputeSInt32Size(int value)
		{
			return 0;
		}

		// Token: 0x06006AFA RID: 27386 RVA: 0x0004E1B0 File Offset: 0x0004C3B0
		[Token(Token = "0x6006AFA")]
		[Address(RVA = "0x36D6148", Offset = "0x36D6148", VA = "0x36D6148")]
		public static int ComputeSInt64Size(long value)
		{
			return 0;
		}

		// Token: 0x06006AFB RID: 27387 RVA: 0x0004E1C8 File Offset: 0x0004C3C8
		[Token(Token = "0x6006AFB")]
		[Address(RVA = "0x36D5D1C", Offset = "0x36D5D1C", VA = "0x36D5D1C")]
		public static int ComputeLengthSize(int length)
		{
			return 0;
		}

		// Token: 0x06006AFC RID: 27388 RVA: 0x0004E1E0 File Offset: 0x0004C3E0
		[Token(Token = "0x6006AFC")]
		[Address(RVA = "0x36D5C3C", Offset = "0x36D5C3C", VA = "0x36D5C3C")]
		public static int ComputeRawVarint32Size(uint value)
		{
			return 0;
		}

		// Token: 0x06006AFD RID: 27389 RVA: 0x0004E1F8 File Offset: 0x0004C3F8
		[Token(Token = "0x6006AFD")]
		[Address(RVA = "0x36D5ABC", Offset = "0x36D5ABC", VA = "0x36D5ABC")]
		public static int ComputeRawVarint64Size(ulong value)
		{
			return 0;
		}

		// Token: 0x06006AFE RID: 27390 RVA: 0x0004E210 File Offset: 0x0004C410
		[Token(Token = "0x6006AFE")]
		[Address(RVA = "0x36D61AC", Offset = "0x36D61AC", VA = "0x36D61AC")]
		public static int ComputeTagSize(int fieldNumber)
		{
			return 0;
		}

		// Token: 0x06006AFF RID: 27391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006AFF")]
		[Address(RVA = "0x36D6248", Offset = "0x36D6248", VA = "0x36D6248")]
		public CodedOutputStream(byte[] flatArray)
		{
		}

		// Token: 0x06006B00 RID: 27392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B00")]
		[Address(RVA = "0x36D6264", Offset = "0x36D6264", VA = "0x36D6264")]
		private CodedOutputStream(byte[] buffer, int offset, int length)
		{
		}

		// Token: 0x06006B01 RID: 27393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B01")]
		[Address(RVA = "0x36D62C8", Offset = "0x36D62C8", VA = "0x36D62C8")]
		private CodedOutputStream(Stream output, byte[] buffer, bool leaveOpen)
		{
		}

		// Token: 0x06006B02 RID: 27394 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B02")]
		[Address(RVA = "0x36D6394", Offset = "0x36D6394", VA = "0x36D6394")]
		public CodedOutputStream(Stream output)
		{
		}

		// Token: 0x06006B03 RID: 27395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B03")]
		[Address(RVA = "0x36D6480", Offset = "0x36D6480", VA = "0x36D6480")]
		public CodedOutputStream(Stream output, int bufferSize)
		{
		}

		// Token: 0x06006B04 RID: 27396 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B04")]
		[Address(RVA = "0x36D64EC", Offset = "0x36D64EC", VA = "0x36D64EC")]
		public CodedOutputStream(Stream output, bool leaveOpen)
		{
		}

		// Token: 0x06006B05 RID: 27397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B05")]
		[Address(RVA = "0x36D6408", Offset = "0x36D6408", VA = "0x36D6408")]
		public CodedOutputStream(Stream output, int bufferSize, bool leaveOpen)
		{
		}

		// Token: 0x170007B5 RID: 1973
		// (get) Token: 0x06006B06 RID: 27398 RVA: 0x0004E228 File Offset: 0x0004C428
		[Token(Token = "0x170007B5")]
		public long Position
		{
			[Token(Token = "0x6006B06")]
			[Address(RVA = "0x36D6564", Offset = "0x36D6564", VA = "0x36D6564")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x06006B07 RID: 27399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B07")]
		[Address(RVA = "0x36D6598", Offset = "0x36D6598", VA = "0x36D6598")]
		public void WriteDouble(double value)
		{
		}

		// Token: 0x06006B08 RID: 27400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B08")]
		[Address(RVA = "0x36D67F4", Offset = "0x36D67F4", VA = "0x36D67F4")]
		public void WriteFloat(float value)
		{
		}

		// Token: 0x06006B09 RID: 27401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B09")]
		[Address(RVA = "0x36D6A84", Offset = "0x36D6A84", VA = "0x36D6A84")]
		public void WriteUInt64(ulong value)
		{
		}

		// Token: 0x06006B0A RID: 27402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B0A")]
		[Address(RVA = "0x36D6B70", Offset = "0x36D6B70", VA = "0x36D6B70")]
		public void WriteInt64(long value)
		{
		}

		// Token: 0x06006B0B RID: 27403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B0B")]
		[Address(RVA = "0x36D6B74", Offset = "0x36D6B74", VA = "0x36D6B74")]
		public void WriteInt32(int value)
		{
		}

		// Token: 0x06006B0C RID: 27404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B0C")]
		[Address(RVA = "0x36D6C80", Offset = "0x36D6C80", VA = "0x36D6C80")]
		public void WriteFixed64(ulong value)
		{
		}

		// Token: 0x06006B0D RID: 27405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B0D")]
		[Address(RVA = "0x36D6C84", Offset = "0x36D6C84", VA = "0x36D6C84")]
		public void WriteFixed32(uint value)
		{
		}

		// Token: 0x06006B0E RID: 27406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B0E")]
		[Address(RVA = "0x36D6DA0", Offset = "0x36D6DA0", VA = "0x36D6DA0")]
		public void WriteBool(bool value)
		{
		}

		// Token: 0x06006B0F RID: 27407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B0F")]
		[Address(RVA = "0x36D6E14", Offset = "0x36D6E14", VA = "0x36D6E14")]
		public void WriteString(string value)
		{
		}

		// Token: 0x06006B10 RID: 27408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B10")]
		[Address(RVA = "0x36D6FFC", Offset = "0x36D6FFC", VA = "0x36D6FFC")]
		public void WriteMessage(IMessage value)
		{
		}

		// Token: 0x06006B11 RID: 27409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B11")]
		[Address(RVA = "0x36D710C", Offset = "0x36D710C", VA = "0x36D710C")]
		public void WriteGroup(IMessage value)
		{
		}

		// Token: 0x06006B12 RID: 27410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B12")]
		[Address(RVA = "0x36D71B4", Offset = "0x36D71B4", VA = "0x36D71B4")]
		public void WriteBytes(ByteString value)
		{
		}

		// Token: 0x06006B13 RID: 27411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B13")]
		[Address(RVA = "0x36D71FC", Offset = "0x36D71FC", VA = "0x36D71FC")]
		public void WriteUInt32(uint value)
		{
		}

		// Token: 0x06006B14 RID: 27412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B14")]
		[Address(RVA = "0x36D7200", Offset = "0x36D7200", VA = "0x36D7200")]
		public void WriteEnum(int value)
		{
		}

		// Token: 0x06006B15 RID: 27413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B15")]
		[Address(RVA = "0x36D7204", Offset = "0x36D7204", VA = "0x36D7204")]
		public void WriteSFixed32(int value)
		{
		}

		// Token: 0x06006B16 RID: 27414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B16")]
		[Address(RVA = "0x36D7208", Offset = "0x36D7208", VA = "0x36D7208")]
		public void WriteSFixed64(long value)
		{
		}

		// Token: 0x06006B17 RID: 27415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B17")]
		[Address(RVA = "0x36D720C", Offset = "0x36D720C", VA = "0x36D720C")]
		public void WriteSInt32(int value)
		{
		}

		// Token: 0x06006B18 RID: 27416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B18")]
		[Address(RVA = "0x36D7274", Offset = "0x36D7274", VA = "0x36D7274")]
		public void WriteSInt64(long value)
		{
		}

		// Token: 0x06006B19 RID: 27417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B19")]
		[Address(RVA = "0x36D6FDC", Offset = "0x36D6FDC", VA = "0x36D6FDC")]
		public void WriteLength(int length)
		{
		}

		// Token: 0x06006B1A RID: 27418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B1A")]
		[Address(RVA = "0x36D72DC", Offset = "0x36D72DC", VA = "0x36D72DC")]
		public void WriteTag(int fieldNumber, WireFormat.WireType type)
		{
		}

		// Token: 0x06006B1B RID: 27419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B1B")]
		[Address(RVA = "0x36D72E4", Offset = "0x36D72E4", VA = "0x36D72E4")]
		public void WriteTag(uint tag)
		{
		}

		// Token: 0x06006B1C RID: 27420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B1C")]
		[Address(RVA = "0x36D72E8", Offset = "0x36D72E8", VA = "0x36D72E8")]
		public void WriteRawTag(byte b1)
		{
		}

		// Token: 0x06006B1D RID: 27421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B1D")]
		[Address(RVA = "0x36D72EC", Offset = "0x36D72EC", VA = "0x36D72EC")]
		public void WriteRawTag(byte b1, byte b2)
		{
		}

		// Token: 0x06006B1E RID: 27422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B1E")]
		[Address(RVA = "0x36D7314", Offset = "0x36D7314", VA = "0x36D7314")]
		public void WriteRawTag(byte b1, byte b2, byte b3)
		{
		}

		// Token: 0x06006B1F RID: 27423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B1F")]
		[Address(RVA = "0x36D734C", Offset = "0x36D734C", VA = "0x36D734C")]
		public void WriteRawTag(byte b1, byte b2, byte b3, byte b4)
		{
		}

		// Token: 0x06006B20 RID: 27424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B20")]
		[Address(RVA = "0x36D739C", Offset = "0x36D739C", VA = "0x36D739C")]
		public void WriteRawTag(byte b1, byte b2, byte b3, byte b4, byte b5)
		{
		}

		// Token: 0x06006B21 RID: 27425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B21")]
		[Address(RVA = "0x36D6B84", Offset = "0x36D6B84", VA = "0x36D6B84")]
		internal void WriteRawVarint32(uint value)
		{
		}

		// Token: 0x06006B22 RID: 27426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B22")]
		[Address(RVA = "0x36D6A88", Offset = "0x36D6A88", VA = "0x36D6A88")]
		internal void WriteRawVarint64(ulong value)
		{
		}

		// Token: 0x06006B23 RID: 27427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B23")]
		[Address(RVA = "0x36D6C88", Offset = "0x36D6C88", VA = "0x36D6C88")]
		internal void WriteRawLittleEndian32(uint value)
		{
		}

		// Token: 0x06006B24 RID: 27428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B24")]
		[Address(RVA = "0x36D65FC", Offset = "0x36D65FC", VA = "0x36D65FC")]
		internal void WriteRawLittleEndian64(ulong value)
		{
		}

		// Token: 0x06006B25 RID: 27429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B25")]
		[Address(RVA = "0x36D6DB4", Offset = "0x36D6DB4", VA = "0x36D6DB4")]
		internal void WriteRawByte(byte value)
		{
		}

		// Token: 0x06006B26 RID: 27430 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B26")]
		[Address(RVA = "0x36D746C", Offset = "0x36D746C", VA = "0x36D746C")]
		internal void WriteRawByte(uint value)
		{
		}

		// Token: 0x06006B27 RID: 27431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B27")]
		[Address(RVA = "0x36D6FE0", Offset = "0x36D6FE0", VA = "0x36D6FE0")]
		internal void WriteRawBytes(byte[] value)
		{
		}

		// Token: 0x06006B28 RID: 27432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B28")]
		[Address(RVA = "0x36D6994", Offset = "0x36D6994", VA = "0x36D6994")]
		internal void WriteRawBytes(byte[] value, int offset, int length)
		{
		}

		// Token: 0x06006B29 RID: 27433 RVA: 0x0004E240 File Offset: 0x0004C440
		[Token(Token = "0x6006B29")]
		[Address(RVA = "0x36D613C", Offset = "0x36D613C", VA = "0x36D613C")]
		internal static uint EncodeZigZag32(int n)
		{
			return 0U;
		}

		// Token: 0x06006B2A RID: 27434 RVA: 0x0004E258 File Offset: 0x0004C458
		[Token(Token = "0x6006B2A")]
		[Address(RVA = "0x36D61A0", Offset = "0x36D61A0", VA = "0x36D61A0")]
		internal static ulong EncodeZigZag64(long n)
		{
			return 0UL;
		}

		// Token: 0x06006B2B RID: 27435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B2B")]
		[Address(RVA = "0x36D73FC", Offset = "0x36D73FC", VA = "0x36D73FC")]
		private void RefreshBuffer()
		{
		}

		// Token: 0x06006B2C RID: 27436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B2C")]
		[Address(RVA = "0x36D74BC", Offset = "0x36D74BC", VA = "0x36D74BC", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x06006B2D RID: 27437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B2D")]
		[Address(RVA = "0x36D74FC", Offset = "0x36D74FC", VA = "0x36D74FC")]
		public void Flush()
		{
		}

		// Token: 0x06006B2E RID: 27438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B2E")]
		[Address(RVA = "0x36D750C", Offset = "0x36D750C", VA = "0x36D750C")]
		public void CheckNoSpaceLeft()
		{
		}

		// Token: 0x170007B6 RID: 1974
		// (get) Token: 0x06006B2F RID: 27439 RVA: 0x0004E270 File Offset: 0x0004C470
		[Token(Token = "0x170007B6")]
		public int SpaceLeft
		{
			[Token(Token = "0x6006B2F")]
			[Address(RVA = "0x36D756C", Offset = "0x36D756C", VA = "0x36D756C")]
			get
			{
				return 0;
			}
		}

		// Token: 0x04002B15 RID: 11029
		[Token(Token = "0x4002B15")]
		private const int LittleEndian64Size = 8;

		// Token: 0x04002B16 RID: 11030
		[Token(Token = "0x4002B16")]
		private const int LittleEndian32Size = 4;

		// Token: 0x04002B17 RID: 11031
		[Token(Token = "0x4002B17")]
		internal const int DoubleSize = 8;

		// Token: 0x04002B18 RID: 11032
		[Token(Token = "0x4002B18")]
		internal const int FloatSize = 4;

		// Token: 0x04002B19 RID: 11033
		[Token(Token = "0x4002B19")]
		internal const int BoolSize = 1;

		// Token: 0x04002B1A RID: 11034
		[Token(Token = "0x4002B1A")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly Encoding Utf8Encoding;

		// Token: 0x04002B1B RID: 11035
		[Token(Token = "0x4002B1B")]
		[FieldOffset(Offset = "0x8")]
		public static readonly int DefaultBufferSize;

		// Token: 0x04002B1C RID: 11036
		[Token(Token = "0x4002B1C")]
		[FieldOffset(Offset = "0x10")]
		private readonly bool leaveOpen;

		// Token: 0x04002B1D RID: 11037
		[Token(Token = "0x4002B1D")]
		[FieldOffset(Offset = "0x18")]
		private readonly byte[] buffer;

		// Token: 0x04002B1E RID: 11038
		[Token(Token = "0x4002B1E")]
		[FieldOffset(Offset = "0x20")]
		private readonly int limit;

		// Token: 0x04002B1F RID: 11039
		[Token(Token = "0x4002B1F")]
		[FieldOffset(Offset = "0x24")]
		private int position;

		// Token: 0x04002B20 RID: 11040
		[Token(Token = "0x4002B20")]
		[FieldOffset(Offset = "0x28")]
		private readonly Stream output;

		// Token: 0x02000AED RID: 2797
		[Token(Token = "0x2000AED")]
		public sealed class OutOfSpaceException : IOException
		{
			// Token: 0x06006B31 RID: 27441 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006B31")]
			[Address(RVA = "0x36D7470", Offset = "0x36D7470", VA = "0x36D7470")]
			internal OutOfSpaceException()
			{
			}
		}
	}
}
