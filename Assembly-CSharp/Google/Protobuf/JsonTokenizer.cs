using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using Il2CppDummyDll;

namespace Google.Protobuf
{
	// Token: 0x02000B1F RID: 2847
	[Token(Token = "0x2000B1F")]
	internal abstract class JsonTokenizer
	{
		// Token: 0x06006CB0 RID: 27824 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CB0")]
		[Address(RVA = "0x36E6FF8", Offset = "0x36E6FF8", VA = "0x36E6FF8")]
		internal static JsonTokenizer FromTextReader(TextReader reader)
		{
			return null;
		}

		// Token: 0x06006CB1 RID: 27825 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CB1")]
		[Address(RVA = "0x36EA04C", Offset = "0x36EA04C", VA = "0x36EA04C")]
		internal static JsonTokenizer FromReplayedTokens(IList<JsonToken> tokens, JsonTokenizer continuation)
		{
			return null;
		}

		// Token: 0x170007E1 RID: 2017
		// (get) Token: 0x06006CB2 RID: 27826 RVA: 0x0004E930 File Offset: 0x0004CB30
		// (set) Token: 0x06006CB3 RID: 27827 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007E1")]
		internal int ObjectDepth
		{
			[Token(Token = "0x6006CB2")]
			[Address(RVA = "0x36ED818", Offset = "0x36ED818", VA = "0x36ED818")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6006CB3")]
			[Address(RVA = "0x36ED820", Offset = "0x36ED820", VA = "0x36ED820")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06006CB4 RID: 27828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CB4")]
		[Address(RVA = "0x36E7724", Offset = "0x36E7724", VA = "0x36E7724")]
		internal void PushBack(JsonToken token)
		{
		}

		// Token: 0x06006CB5 RID: 27829 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CB5")]
		[Address(RVA = "0x36E759C", Offset = "0x36E759C", VA = "0x36E759C")]
		internal JsonToken Next()
		{
			return null;
		}

		// Token: 0x06006CB6 RID: 27830
		[Token(Token = "0x6006CB6")]
		protected abstract JsonToken NextImpl();

		// Token: 0x06006CB7 RID: 27831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CB7")]
		[Address(RVA = "0x36E7618", Offset = "0x36E7618", VA = "0x36E7618")]
		internal void SkipValue()
		{
		}

		// Token: 0x06006CB8 RID: 27832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CB8")]
		[Address(RVA = "0x36ED828", Offset = "0x36ED828", VA = "0x36ED828")]
		protected JsonTokenizer()
		{
		}

		// Token: 0x04002BB1 RID: 11185
		[Token(Token = "0x4002BB1")]
		[FieldOffset(Offset = "0x10")]
		private JsonToken bufferedToken;

		// Token: 0x02000B20 RID: 2848
		[Token(Token = "0x2000B20")]
		private class JsonReplayTokenizer : JsonTokenizer
		{
			// Token: 0x06006CB9 RID: 27833 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006CB9")]
			[Address(RVA = "0x36ED7D4", Offset = "0x36ED7D4", VA = "0x36ED7D4")]
			internal JsonReplayTokenizer(IList<JsonToken> tokens, JsonTokenizer nextTokenizer)
			{
			}

			// Token: 0x06006CBA RID: 27834 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006CBA")]
			[Address(RVA = "0x36ED830", Offset = "0x36ED830", VA = "0x36ED830", Slot = "4")]
			protected override JsonToken NextImpl()
			{
				return null;
			}

			// Token: 0x04002BB3 RID: 11187
			[Token(Token = "0x4002BB3")]
			[FieldOffset(Offset = "0x20")]
			private readonly IList<JsonToken> tokens;

			// Token: 0x04002BB4 RID: 11188
			[Token(Token = "0x4002BB4")]
			[FieldOffset(Offset = "0x28")]
			private readonly JsonTokenizer nextTokenizer;

			// Token: 0x04002BB5 RID: 11189
			[Token(Token = "0x4002BB5")]
			[FieldOffset(Offset = "0x30")]
			private int nextTokenIndex;
		}

		// Token: 0x02000B21 RID: 2849
		[Token(Token = "0x2000B21")]
		private sealed class JsonTextTokenizer : JsonTokenizer
		{
			// Token: 0x06006CBB RID: 27835 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006CBB")]
			[Address(RVA = "0x36ED6C4", Offset = "0x36ED6C4", VA = "0x36ED6C4")]
			internal JsonTextTokenizer(TextReader reader)
			{
			}

			// Token: 0x06006CBC RID: 27836 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006CBC")]
			[Address(RVA = "0x36ED9A4", Offset = "0x36ED9A4", VA = "0x36ED9A4", Slot = "4")]
			protected override JsonToken NextImpl()
			{
				return null;
			}

			// Token: 0x06006CBD RID: 27837 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006CBD")]
			[Address(RVA = "0x36EE2D0", Offset = "0x36EE2D0", VA = "0x36EE2D0")]
			private void ValidateState(JsonTokenizer.JsonTextTokenizer.State validStates, string errorPrefix)
			{
			}

			// Token: 0x06006CBE RID: 27838 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006CBE")]
			[Address(RVA = "0x36EE370", Offset = "0x36EE370", VA = "0x36EE370")]
			private string ReadString()
			{
				return null;
			}

			// Token: 0x06006CBF RID: 27839 RVA: 0x0004E948 File Offset: 0x0004CB48
			[Token(Token = "0x6006CBF")]
			[Address(RVA = "0x36EED00", Offset = "0x36EED00", VA = "0x36EED00")]
			private char ReadEscapedCharacter()
			{
				return '\0';
			}

			// Token: 0x06006CC0 RID: 27840 RVA: 0x0004E960 File Offset: 0x0004CB60
			[Token(Token = "0x6006CC0")]
			[Address(RVA = "0x36EEE90", Offset = "0x36EEE90", VA = "0x36EEE90")]
			private char ReadUnicodeEscape()
			{
				return '\0';
			}

			// Token: 0x06006CC1 RID: 27841 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006CC1")]
			[Address(RVA = "0x36EE788", Offset = "0x36EE788", VA = "0x36EE788")]
			private void ConsumeLiteral(string text)
			{
			}

			// Token: 0x06006CC2 RID: 27842 RVA: 0x0004E978 File Offset: 0x0004CB78
			[Token(Token = "0x6006CC2")]
			[Address(RVA = "0x36EE8B0", Offset = "0x36EE8B0", VA = "0x36EE8B0")]
			private double ReadNumber(char initialCharacter)
			{
				return 0.0;
			}

			// Token: 0x06006CC3 RID: 27843 RVA: 0x0004E990 File Offset: 0x0004CB90
			[Token(Token = "0x6006CC3")]
			[Address(RVA = "0x36EF0A0", Offset = "0x36EF0A0", VA = "0x36EF0A0")]
			private char? ReadInt(StringBuilder builder)
			{
				return default(char?);
			}

			// Token: 0x06006CC4 RID: 27844 RVA: 0x0004E9A8 File Offset: 0x0004CBA8
			[Token(Token = "0x6006CC4")]
			[Address(RVA = "0x36EF1A0", Offset = "0x36EF1A0", VA = "0x36EF1A0")]
			private char? ReadFrac(StringBuilder builder)
			{
				return default(char?);
			}

			// Token: 0x06006CC5 RID: 27845 RVA: 0x0004E9C0 File Offset: 0x0004CBC0
			[Token(Token = "0x6006CC5")]
			[Address(RVA = "0x36EF22C", Offset = "0x36EF22C", VA = "0x36EF22C")]
			private char? ReadExp(StringBuilder builder)
			{
				return default(char?);
			}

			// Token: 0x06006CC6 RID: 27846 RVA: 0x0004E9D8 File Offset: 0x0004CBD8
			[Token(Token = "0x6006CC6")]
			[Address(RVA = "0x36EF410", Offset = "0x36EF410", VA = "0x36EF410")]
			private char? ConsumeDigits(StringBuilder builder, out int count)
			{
				return default(char?);
			}

			// Token: 0x06006CC7 RID: 27847 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006CC7")]
			[Address(RVA = "0x36EE560", Offset = "0x36EE560", VA = "0x36EE560")]
			private void ValidateAndModifyStateForValue(string errorPrefix)
			{
			}

			// Token: 0x06006CC8 RID: 27848 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006CC8")]
			[Address(RVA = "0x36EE664", Offset = "0x36EE664", VA = "0x36EE664")]
			private void PopContainer()
			{
			}

			// Token: 0x04002BB6 RID: 11190
			[Token(Token = "0x4002BB6")]
			[FieldOffset(Offset = "0x0")]
			private static readonly JsonTokenizer.JsonTextTokenizer.State ValueStates;

			// Token: 0x04002BB7 RID: 11191
			[Token(Token = "0x4002BB7")]
			[FieldOffset(Offset = "0x20")]
			private readonly Stack<JsonTokenizer.JsonTextTokenizer.ContainerType> containerStack;

			// Token: 0x04002BB8 RID: 11192
			[Token(Token = "0x4002BB8")]
			[FieldOffset(Offset = "0x28")]
			private readonly JsonTokenizer.JsonTextTokenizer.PushBackReader reader;

			// Token: 0x04002BB9 RID: 11193
			[Token(Token = "0x4002BB9")]
			[FieldOffset(Offset = "0x30")]
			private JsonTokenizer.JsonTextTokenizer.State state;

			// Token: 0x02000B22 RID: 2850
			[Token(Token = "0x2000B22")]
			private enum ContainerType
			{
				// Token: 0x04002BBB RID: 11195
				[Token(Token = "0x4002BBB")]
				Document,
				// Token: 0x04002BBC RID: 11196
				[Token(Token = "0x4002BBC")]
				Object,
				// Token: 0x04002BBD RID: 11197
				[Token(Token = "0x4002BBD")]
				Array
			}

			// Token: 0x02000B23 RID: 2851
			[Token(Token = "0x2000B23")]
			[Flags]
			private enum State
			{
				// Token: 0x04002BBF RID: 11199
				[Token(Token = "0x4002BBF")]
				StartOfDocument = 1,
				// Token: 0x04002BC0 RID: 11200
				[Token(Token = "0x4002BC0")]
				ExpectedEndOfDocument = 2,
				// Token: 0x04002BC1 RID: 11201
				[Token(Token = "0x4002BC1")]
				ReaderExhausted = 4,
				// Token: 0x04002BC2 RID: 11202
				[Token(Token = "0x4002BC2")]
				ObjectStart = 8,
				// Token: 0x04002BC3 RID: 11203
				[Token(Token = "0x4002BC3")]
				ObjectBeforeColon = 16,
				// Token: 0x04002BC4 RID: 11204
				[Token(Token = "0x4002BC4")]
				ObjectAfterColon = 32,
				// Token: 0x04002BC5 RID: 11205
				[Token(Token = "0x4002BC5")]
				ObjectAfterProperty = 64,
				// Token: 0x04002BC6 RID: 11206
				[Token(Token = "0x4002BC6")]
				ObjectAfterComma = 128,
				// Token: 0x04002BC7 RID: 11207
				[Token(Token = "0x4002BC7")]
				ArrayStart = 256,
				// Token: 0x04002BC8 RID: 11208
				[Token(Token = "0x4002BC8")]
				ArrayAfterValue = 512,
				// Token: 0x04002BC9 RID: 11209
				[Token(Token = "0x4002BC9")]
				ArrayAfterComma = 1024
			}

			// Token: 0x02000B24 RID: 2852
			[Token(Token = "0x2000B24")]
			private class PushBackReader
			{
				// Token: 0x06006CCA RID: 27850 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006CCA")]
				[Address(RVA = "0x36ED974", Offset = "0x36ED974", VA = "0x36ED974")]
				internal PushBackReader(TextReader reader)
				{
				}

				// Token: 0x06006CCB RID: 27851 RVA: 0x0004E9F0 File Offset: 0x0004CBF0
				[Token(Token = "0x6006CCB")]
				[Address(RVA = "0x36EE228", Offset = "0x36EE228", VA = "0x36EE228")]
				internal char? Read()
				{
					return default(char?);
				}

				// Token: 0x06006CCC RID: 27852 RVA: 0x0004EA08 File Offset: 0x0004CC08
				[Token(Token = "0x6006CCC")]
				[Address(RVA = "0x36EEC64", Offset = "0x36EEC64", VA = "0x36EEC64")]
				internal char ReadOrFail(string messageOnFailure)
				{
					return '\0';
				}

				// Token: 0x06006CCD RID: 27853 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006CCD")]
				[Address(RVA = "0x36EEFD8", Offset = "0x36EEFD8", VA = "0x36EEFD8")]
				internal void PushBack(char c)
				{
				}

				// Token: 0x06006CCE RID: 27854 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6006CCE")]
				[Address(RVA = "0x36EEC00", Offset = "0x36EEC00", VA = "0x36EEC00")]
				internal InvalidJsonException CreateException(string message)
				{
					return null;
				}

				// Token: 0x04002BCA RID: 11210
				[Token(Token = "0x4002BCA")]
				[FieldOffset(Offset = "0x10")]
				private readonly TextReader reader;

				// Token: 0x04002BCB RID: 11211
				[Token(Token = "0x4002BCB")]
				[FieldOffset(Offset = "0x18")]
				private char? nextChar;
			}
		}
	}
}
