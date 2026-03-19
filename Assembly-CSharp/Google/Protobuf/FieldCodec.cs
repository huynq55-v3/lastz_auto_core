using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Google.Protobuf
{
	// Token: 0x02000AF9 RID: 2809
	[Token(Token = "0x2000AF9")]
	public static class FieldCodec
	{
		// Token: 0x06006B7E RID: 27518 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B7E")]
		[Address(RVA = "0x36D86A4", Offset = "0x36D86A4", VA = "0x36D86A4")]
		public static FieldCodec<string> ForString(uint tag)
		{
			return null;
		}

		// Token: 0x06006B7F RID: 27519 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B7F")]
		[Address(RVA = "0x36D890C", Offset = "0x36D890C", VA = "0x36D890C")]
		public static FieldCodec<ByteString> ForBytes(uint tag)
		{
			return null;
		}

		// Token: 0x06006B80 RID: 27520 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B80")]
		[Address(RVA = "0x36D8BBC", Offset = "0x36D8BBC", VA = "0x36D8BBC")]
		public static FieldCodec<bool> ForBool(uint tag)
		{
			return null;
		}

		// Token: 0x06006B81 RID: 27521 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B81")]
		[Address(RVA = "0x36D8D9C", Offset = "0x36D8D9C", VA = "0x36D8D9C")]
		public static FieldCodec<int> ForInt32(uint tag)
		{
			return null;
		}

		// Token: 0x06006B82 RID: 27522 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B82")]
		[Address(RVA = "0x36D8FC4", Offset = "0x36D8FC4", VA = "0x36D8FC4")]
		public static FieldCodec<int> ForSInt32(uint tag)
		{
			return null;
		}

		// Token: 0x06006B83 RID: 27523 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B83")]
		[Address(RVA = "0x36D91EC", Offset = "0x36D91EC", VA = "0x36D91EC")]
		public static FieldCodec<uint> ForFixed32(uint tag)
		{
			return null;
		}

		// Token: 0x06006B84 RID: 27524 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B84")]
		[Address(RVA = "0x36D93CC", Offset = "0x36D93CC", VA = "0x36D93CC")]
		public static FieldCodec<int> ForSFixed32(uint tag)
		{
			return null;
		}

		// Token: 0x06006B85 RID: 27525 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B85")]
		[Address(RVA = "0x36D95AC", Offset = "0x36D95AC", VA = "0x36D95AC")]
		public static FieldCodec<uint> ForUInt32(uint tag)
		{
			return null;
		}

		// Token: 0x06006B86 RID: 27526 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B86")]
		[Address(RVA = "0x36D97D4", Offset = "0x36D97D4", VA = "0x36D97D4")]
		public static FieldCodec<long> ForInt64(uint tag)
		{
			return null;
		}

		// Token: 0x06006B87 RID: 27527 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B87")]
		[Address(RVA = "0x36D99FC", Offset = "0x36D99FC", VA = "0x36D99FC")]
		public static FieldCodec<long> ForSInt64(uint tag)
		{
			return null;
		}

		// Token: 0x06006B88 RID: 27528 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B88")]
		[Address(RVA = "0x36D9C24", Offset = "0x36D9C24", VA = "0x36D9C24")]
		public static FieldCodec<ulong> ForFixed64(uint tag)
		{
			return null;
		}

		// Token: 0x06006B89 RID: 27529 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B89")]
		[Address(RVA = "0x36D9E04", Offset = "0x36D9E04", VA = "0x36D9E04")]
		public static FieldCodec<long> ForSFixed64(uint tag)
		{
			return null;
		}

		// Token: 0x06006B8A RID: 27530 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B8A")]
		[Address(RVA = "0x36D9FE4", Offset = "0x36D9FE4", VA = "0x36D9FE4")]
		public static FieldCodec<ulong> ForUInt64(uint tag)
		{
			return null;
		}

		// Token: 0x06006B8B RID: 27531 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B8B")]
		[Address(RVA = "0x36DA20C", Offset = "0x36DA20C", VA = "0x36DA20C")]
		public static FieldCodec<float> ForFloat(uint tag)
		{
			return null;
		}

		// Token: 0x06006B8C RID: 27532 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B8C")]
		[Address(RVA = "0x36DA3EC", Offset = "0x36DA3EC", VA = "0x36DA3EC")]
		public static FieldCodec<double> ForDouble(uint tag)
		{
			return null;
		}

		// Token: 0x06006B8D RID: 27533 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B8D")]
		public static FieldCodec<T> ForEnum<T>(uint tag, Func<T, int> toInt32, Func<int, T> fromInt32)
		{
			return null;
		}

		// Token: 0x06006B8E RID: 27534 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B8E")]
		[Address(RVA = "0x36D86EC", Offset = "0x36D86EC", VA = "0x36D86EC")]
		public static FieldCodec<string> ForString(uint tag, string defaultValue)
		{
			return null;
		}

		// Token: 0x06006B8F RID: 27535 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B8F")]
		[Address(RVA = "0x36D899C", Offset = "0x36D899C", VA = "0x36D899C")]
		public static FieldCodec<ByteString> ForBytes(uint tag, ByteString defaultValue)
		{
			return null;
		}

		// Token: 0x06006B90 RID: 27536 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B90")]
		[Address(RVA = "0x36D8BC4", Offset = "0x36D8BC4", VA = "0x36D8BC4")]
		public static FieldCodec<bool> ForBool(uint tag, bool defaultValue)
		{
			return null;
		}

		// Token: 0x06006B91 RID: 27537 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B91")]
		[Address(RVA = "0x36D8DA4", Offset = "0x36D8DA4", VA = "0x36D8DA4")]
		public static FieldCodec<int> ForInt32(uint tag, int defaultValue)
		{
			return null;
		}

		// Token: 0x06006B92 RID: 27538 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B92")]
		[Address(RVA = "0x36D8FCC", Offset = "0x36D8FCC", VA = "0x36D8FCC")]
		public static FieldCodec<int> ForSInt32(uint tag, int defaultValue)
		{
			return null;
		}

		// Token: 0x06006B93 RID: 27539 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B93")]
		[Address(RVA = "0x36D91F4", Offset = "0x36D91F4", VA = "0x36D91F4")]
		public static FieldCodec<uint> ForFixed32(uint tag, uint defaultValue)
		{
			return null;
		}

		// Token: 0x06006B94 RID: 27540 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B94")]
		[Address(RVA = "0x36D93D4", Offset = "0x36D93D4", VA = "0x36D93D4")]
		public static FieldCodec<int> ForSFixed32(uint tag, int defaultValue)
		{
			return null;
		}

		// Token: 0x06006B95 RID: 27541 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B95")]
		[Address(RVA = "0x36D95B4", Offset = "0x36D95B4", VA = "0x36D95B4")]
		public static FieldCodec<uint> ForUInt32(uint tag, uint defaultValue)
		{
			return null;
		}

		// Token: 0x06006B96 RID: 27542 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B96")]
		[Address(RVA = "0x36D97DC", Offset = "0x36D97DC", VA = "0x36D97DC")]
		public static FieldCodec<long> ForInt64(uint tag, long defaultValue)
		{
			return null;
		}

		// Token: 0x06006B97 RID: 27543 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B97")]
		[Address(RVA = "0x36D9A04", Offset = "0x36D9A04", VA = "0x36D9A04")]
		public static FieldCodec<long> ForSInt64(uint tag, long defaultValue)
		{
			return null;
		}

		// Token: 0x06006B98 RID: 27544 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B98")]
		[Address(RVA = "0x36D9C2C", Offset = "0x36D9C2C", VA = "0x36D9C2C")]
		public static FieldCodec<ulong> ForFixed64(uint tag, ulong defaultValue)
		{
			return null;
		}

		// Token: 0x06006B99 RID: 27545 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B99")]
		[Address(RVA = "0x36D9E0C", Offset = "0x36D9E0C", VA = "0x36D9E0C")]
		public static FieldCodec<long> ForSFixed64(uint tag, long defaultValue)
		{
			return null;
		}

		// Token: 0x06006B9A RID: 27546 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B9A")]
		[Address(RVA = "0x36D9FEC", Offset = "0x36D9FEC", VA = "0x36D9FEC")]
		public static FieldCodec<ulong> ForUInt64(uint tag, ulong defaultValue)
		{
			return null;
		}

		// Token: 0x06006B9B RID: 27547 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B9B")]
		[Address(RVA = "0x36DA214", Offset = "0x36DA214", VA = "0x36DA214")]
		public static FieldCodec<float> ForFloat(uint tag, float defaultValue)
		{
			return null;
		}

		// Token: 0x06006B9C RID: 27548 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B9C")]
		[Address(RVA = "0x36DA3F4", Offset = "0x36DA3F4", VA = "0x36DA3F4")]
		public static FieldCodec<double> ForDouble(uint tag, double defaultValue)
		{
			return null;
		}

		// Token: 0x06006B9D RID: 27549 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B9D")]
		public static FieldCodec<T> ForEnum<T>(uint tag, Func<T, int> toInt32, Func<int, T> fromInt32, T defaultValue)
		{
			return null;
		}

		// Token: 0x06006B9E RID: 27550 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B9E")]
		public static FieldCodec<T> ForMessage<T>(uint tag, MessageParser<T> parser) where T : class, IMessage<T>
		{
			return null;
		}

		// Token: 0x06006B9F RID: 27551 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B9F")]
		public static FieldCodec<T> ForGroup<T>(uint startTag, uint endTag, MessageParser<T> parser) where T : class, IMessage<T>
		{
			return null;
		}

		// Token: 0x06006BA0 RID: 27552 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006BA0")]
		public static FieldCodec<T> ForClassWrapper<T>(uint tag) where T : class
		{
			return null;
		}

		// Token: 0x06006BA1 RID: 27553 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006BA1")]
		public static FieldCodec<T?> ForStructWrapper<T>(uint tag) where T : struct
		{
			return null;
		}

		// Token: 0x02000AFA RID: 2810
		[Token(Token = "0x2000AFA")]
		private static class WrapperCodecs
		{
			// Token: 0x06006BA2 RID: 27554 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006BA2")]
			internal static FieldCodec<T> GetCodec<T>()
			{
				return null;
			}

			// Token: 0x06006BA3 RID: 27555 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006BA3")]
			internal static Func<CodedInputStream, T?> GetReader<T>() where T : struct
			{
				return null;
			}

			// Token: 0x06006BA4 RID: 27556 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006BA4")]
			internal static T Read<T>(CodedInputStream input, FieldCodec<T> codec)
			{
				return null;
			}

			// Token: 0x06006BA5 RID: 27557 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006BA5")]
			internal static void Write<T>(CodedOutputStream output, T value, FieldCodec<T> codec)
			{
			}

			// Token: 0x06006BA6 RID: 27558 RVA: 0x0004E4B0 File Offset: 0x0004C6B0
			[Token(Token = "0x6006BA6")]
			internal static int CalculateSize<T>(T value, FieldCodec<T> codec)
			{
				return 0;
			}

			// Token: 0x04002B2F RID: 11055
			[Token(Token = "0x4002B2F")]
			[FieldOffset(Offset = "0x0")]
			private static readonly Dictionary<Type, object> Codecs;

			// Token: 0x04002B30 RID: 11056
			[Token(Token = "0x4002B30")]
			[FieldOffset(Offset = "0x8")]
			private static readonly Dictionary<Type, object> Readers;
		}
	}
}
