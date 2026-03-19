using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace NiceJson
{
	// Token: 0x020004A7 RID: 1191
	[Token(Token = "0x20004A7")]
	[Serializable]
	public abstract class JsonNode
	{
		// Token: 0x1700053B RID: 1339
		[Token(Token = "0x1700053B")]
		public JsonNode this[string key]
		{
			[Token(Token = "0x600231F")]
			[Address(RVA = "0x29FFEA4", Offset = "0x29FFEA4", VA = "0x29FFEA4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002320")]
			[Address(RVA = "0x29FFF30", Offset = "0x29FFF30", VA = "0x29FFF30")]
			set
			{
			}
		}

		// Token: 0x1700053C RID: 1340
		[Token(Token = "0x1700053C")]
		public JsonNode this[int index]
		{
			[Token(Token = "0x6002321")]
			[Address(RVA = "0x29FFFCC", Offset = "0x29FFFCC", VA = "0x29FFFCC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002322")]
			[Address(RVA = "0x2A000B0", Offset = "0x2A000B0", VA = "0x2A000B0")]
			set
			{
			}
		}

		// Token: 0x06002323 RID: 8995 RVA: 0x0000D650 File Offset: 0x0000B850
		[Token(Token = "0x6002323")]
		[Address(RVA = "0x2A001B4", Offset = "0x2A001B4", VA = "0x2A001B4")]
		public bool ContainsKey(string key)
		{
			return default(bool);
		}

		// Token: 0x06002324 RID: 8996 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002324")]
		[Address(RVA = "0x2A00240", Offset = "0x2A00240", VA = "0x2A00240")]
		protected static string EscapeString(string s)
		{
			return null;
		}

		// Token: 0x06002325 RID: 8997 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002325")]
		[Address(RVA = "0x2A004E4", Offset = "0x2A004E4", VA = "0x2A004E4")]
		protected static string UnescapeString(string s)
		{
			return null;
		}

		// Token: 0x06002326 RID: 8998 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002326")]
		[Address(RVA = "0x29FEB58", Offset = "0x29FEB58", VA = "0x29FEB58")]
		public static implicit operator JsonNode(string value)
		{
			return null;
		}

		// Token: 0x06002327 RID: 8999 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002327")]
		[Address(RVA = "0x29FC274", Offset = "0x29FC274", VA = "0x29FC274")]
		public static implicit operator JsonNode(int value)
		{
			return null;
		}

		// Token: 0x06002328 RID: 9000 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002328")]
		[Address(RVA = "0x2A006F4", Offset = "0x2A006F4", VA = "0x2A006F4")]
		public static implicit operator JsonNode(long value)
		{
			return null;
		}

		// Token: 0x06002329 RID: 9001 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002329")]
		[Address(RVA = "0x2A00798", Offset = "0x2A00798", VA = "0x2A00798")]
		public static implicit operator JsonNode(float value)
		{
			return null;
		}

		// Token: 0x0600232A RID: 9002 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600232A")]
		[Address(RVA = "0x2A0083C", Offset = "0x2A0083C", VA = "0x2A0083C")]
		public static implicit operator JsonNode(double value)
		{
			return null;
		}

		// Token: 0x0600232B RID: 9003 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600232B")]
		[Address(RVA = "0x2A008E0", Offset = "0x2A008E0", VA = "0x2A008E0")]
		public static implicit operator JsonNode(decimal value)
		{
			return null;
		}

		// Token: 0x0600232C RID: 9004 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600232C")]
		[Address(RVA = "0x29FEBC8", Offset = "0x29FEBC8", VA = "0x29FEBC8")]
		public static implicit operator JsonNode(bool value)
		{
			return null;
		}

		// Token: 0x0600232D RID: 9005 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600232D")]
		[Address(RVA = "0x29FBC14", Offset = "0x29FBC14", VA = "0x29FBC14")]
		public static implicit operator string(JsonNode value)
		{
			return null;
		}

		// Token: 0x0600232E RID: 9006 RVA: 0x0000D668 File Offset: 0x0000B868
		[Token(Token = "0x600232E")]
		[Address(RVA = "0x29FBEB8", Offset = "0x29FBEB8", VA = "0x29FBEB8")]
		public static implicit operator int(JsonNode value)
		{
			return 0;
		}

		// Token: 0x0600232F RID: 9007 RVA: 0x0000D680 File Offset: 0x0000B880
		[Token(Token = "0x600232F")]
		[Address(RVA = "0x2A009B8", Offset = "0x2A009B8", VA = "0x2A009B8")]
		public static implicit operator long(JsonNode value)
		{
			return 0L;
		}

		// Token: 0x06002330 RID: 9008 RVA: 0x0000D698 File Offset: 0x0000B898
		[Token(Token = "0x6002330")]
		[Address(RVA = "0x29FBD78", Offset = "0x29FBD78", VA = "0x29FBD78")]
		public static implicit operator float(JsonNode value)
		{
			return 0f;
		}

		// Token: 0x06002331 RID: 9009 RVA: 0x0000D6B0 File Offset: 0x0000B8B0
		[Token(Token = "0x6002331")]
		[Address(RVA = "0x2A00AF8", Offset = "0x2A00AF8", VA = "0x2A00AF8")]
		public static implicit operator double(JsonNode value)
		{
			return 0.0;
		}

		// Token: 0x06002332 RID: 9010 RVA: 0x0000D6C8 File Offset: 0x0000B8C8
		[Token(Token = "0x6002332")]
		[Address(RVA = "0x2A00C38", Offset = "0x2A00C38", VA = "0x2A00C38")]
		public static implicit operator decimal(JsonNode value)
		{
			return default(decimal);
		}

		// Token: 0x06002333 RID: 9011 RVA: 0x0000D6E0 File Offset: 0x0000B8E0
		[Token(Token = "0x6002333")]
		[Address(RVA = "0x29FBC38", Offset = "0x29FBC38", VA = "0x29FBC38")]
		public static implicit operator bool(JsonNode value)
		{
			return default(bool);
		}

		// Token: 0x06002334 RID: 9012 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002334")]
		[Address(RVA = "0x29FBC28", Offset = "0x29FBC28", VA = "0x29FBC28")]
		public static JsonNode ParseJsonString(string jsonString)
		{
			return null;
		}

		// Token: 0x06002335 RID: 9013 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002335")]
		[Address(RVA = "0x2A00EC8", Offset = "0x2A00EC8", VA = "0x2A00EC8")]
		private static JsonNode ParseJsonPart(string jsonPart)
		{
			return null;
		}

		// Token: 0x06002336 RID: 9014 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002336")]
		[Address(RVA = "0x2A01404", Offset = "0x2A01404", VA = "0x2A01404")]
		private static List<string> SplitJsonParts(string json)
		{
			return null;
		}

		// Token: 0x06002337 RID: 9015 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002337")]
		[Address(RVA = "0x2A0165C", Offset = "0x2A0165C", VA = "0x2A0165C")]
		private static string[] SplitKeyValuePart(string json)
		{
			return null;
		}

		// Token: 0x06002338 RID: 9016 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002338")]
		[Address(RVA = "0x2A00D7C", Offset = "0x2A00D7C", VA = "0x2A00D7C")]
		private static string RemoveNonTokenChars(string s)
		{
			return null;
		}

		// Token: 0x06002339 RID: 9017
		[Token(Token = "0x6002339")]
		public abstract string ToJsonString();

		// Token: 0x0600233A RID: 9018 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600233A")]
		[Address(RVA = "0x29FB960", Offset = "0x29FB960", VA = "0x29FB960")]
		public string ToJsonPrettyPrintString()
		{
			return null;
		}

		// Token: 0x0600233B RID: 9019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600233B")]
		[Address(RVA = "0x2A0194C", Offset = "0x2A0194C", VA = "0x2A0194C")]
		protected JsonNode()
		{
		}

		// Token: 0x04002091 RID: 8337
		[Token(Token = "0x4002091")]
		protected const char PP_IDENT_CHAR = '\t';

		// Token: 0x04002092 RID: 8338
		[Token(Token = "0x4002092")]
		protected const int PP_IDENT_COUNT = 1;

		// Token: 0x04002093 RID: 8339
		[Token(Token = "0x4002093")]
		protected const bool ESCAPE_SOLIDUS = false;

		// Token: 0x04002094 RID: 8340
		[Token(Token = "0x4002094")]
		protected const char CHAR_CURLY_OPEN = '{';

		// Token: 0x04002095 RID: 8341
		[Token(Token = "0x4002095")]
		protected const char CHAR_CURLY_CLOSED = '}';

		// Token: 0x04002096 RID: 8342
		[Token(Token = "0x4002096")]
		protected const char CHAR_SQUARED_OPEN = '[';

		// Token: 0x04002097 RID: 8343
		[Token(Token = "0x4002097")]
		protected const char CHAR_SQUARED_CLOSED = ']';

		// Token: 0x04002098 RID: 8344
		[Token(Token = "0x4002098")]
		protected const char CHAR_COLON = ':';

		// Token: 0x04002099 RID: 8345
		[Token(Token = "0x4002099")]
		protected const char CHAR_COMMA = ',';

		// Token: 0x0400209A RID: 8346
		[Token(Token = "0x400209A")]
		protected const char CHAR_QUOTE = '"';

		// Token: 0x0400209B RID: 8347
		[Token(Token = "0x400209B")]
		protected const char CHAR_NULL_LITERAL = 'n';

		// Token: 0x0400209C RID: 8348
		[Token(Token = "0x400209C")]
		protected const char CHAR_TRUE_LITERAL = 't';

		// Token: 0x0400209D RID: 8349
		[Token(Token = "0x400209D")]
		protected const char CHAR_FALSE_LITERAL = 'f';

		// Token: 0x0400209E RID: 8350
		[Token(Token = "0x400209E")]
		protected const char CHAR_SPACE = ' ';

		// Token: 0x0400209F RID: 8351
		[Token(Token = "0x400209F")]
		protected const char CHAR_BS = '\b';

		// Token: 0x040020A0 RID: 8352
		[Token(Token = "0x40020A0")]
		protected const char CHAR_FF = '\f';

		// Token: 0x040020A1 RID: 8353
		[Token(Token = "0x40020A1")]
		protected const char CHAR_RF = '\r';

		// Token: 0x040020A2 RID: 8354
		[Token(Token = "0x40020A2")]
		protected const char CHAR_NL = '\n';

		// Token: 0x040020A3 RID: 8355
		[Token(Token = "0x40020A3")]
		protected const char CHAR_HT = '\t';

		// Token: 0x040020A4 RID: 8356
		[Token(Token = "0x40020A4")]
		protected const char CHAR_ESCAPE = '\\';

		// Token: 0x040020A5 RID: 8357
		[Token(Token = "0x40020A5")]
		protected const char CHAR_SOLIDUS = '/';

		// Token: 0x040020A6 RID: 8358
		[Token(Token = "0x40020A6")]
		protected const char CHAR_ESCAPED_QUOTE = '"';

		// Token: 0x040020A7 RID: 8359
		[Token(Token = "0x40020A7")]
		protected const char CHAR_N = 'n';

		// Token: 0x040020A8 RID: 8360
		[Token(Token = "0x40020A8")]
		protected const char CHAR_R = 'r';

		// Token: 0x040020A9 RID: 8361
		[Token(Token = "0x40020A9")]
		protected const char CHAR_B = 'b';

		// Token: 0x040020AA RID: 8362
		[Token(Token = "0x40020AA")]
		protected const char CHAR_T = 't';

		// Token: 0x040020AB RID: 8363
		[Token(Token = "0x40020AB")]
		protected const char CHAR_F = 'f';

		// Token: 0x040020AC RID: 8364
		[Token(Token = "0x40020AC")]
		protected const char CHAR_U = 'u';

		// Token: 0x040020AD RID: 8365
		[Token(Token = "0x40020AD")]
		protected const string STRING_ESCAPED_BS = "\\b";

		// Token: 0x040020AE RID: 8366
		[Token(Token = "0x40020AE")]
		protected const string STRING_ESCAPED_FF = "\\f";

		// Token: 0x040020AF RID: 8367
		[Token(Token = "0x40020AF")]
		protected const string STRING_ESCAPED_RF = "\\r";

		// Token: 0x040020B0 RID: 8368
		[Token(Token = "0x40020B0")]
		protected const string STRING_ESCAPED_NL = "\\n";

		// Token: 0x040020B1 RID: 8369
		[Token(Token = "0x40020B1")]
		protected const string STRING_ESCAPED_TAB = "\\t";

		// Token: 0x040020B2 RID: 8370
		[Token(Token = "0x40020B2")]
		protected const string STRING_ESCAPED_ESCAPE = "\\\\";

		// Token: 0x040020B3 RID: 8371
		[Token(Token = "0x40020B3")]
		protected const string STRING_ESCAPED_SOLIDUS = "\\/";

		// Token: 0x040020B4 RID: 8372
		[Token(Token = "0x40020B4")]
		protected const string STRING_ESCAPED_ESCAPED_QUOTE = "\\\"";

		// Token: 0x040020B5 RID: 8373
		[Token(Token = "0x40020B5")]
		protected const string STRING_SPACE = " ";

		// Token: 0x040020B6 RID: 8374
		[Token(Token = "0x40020B6")]
		protected const string STRING_LITERAL_NULL = "null";

		// Token: 0x040020B7 RID: 8375
		[Token(Token = "0x40020B7")]
		protected const string STRING_LITERAL_TRUE = "true";

		// Token: 0x040020B8 RID: 8376
		[Token(Token = "0x40020B8")]
		protected const string STRING_LITERAL_FALSE = "false";

		// Token: 0x040020B9 RID: 8377
		[Token(Token = "0x40020B9")]
		protected const string STRING_ESCAPED_UNICODE_INIT = "\\u00";
	}
}
