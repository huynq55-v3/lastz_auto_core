using System;
using System.Collections.Generic;
using System.IO;
using Il2CppDummyDll;

namespace LitJson
{
	// Token: 0x02000ADF RID: 2783
	[Token(Token = "0x2000ADF")]
	public class JsonReader
	{
		// Token: 0x17000798 RID: 1944
		// (get) Token: 0x06006A14 RID: 27156 RVA: 0x0004D658 File Offset: 0x0004B858
		// (set) Token: 0x06006A15 RID: 27157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000798")]
		public bool AllowComments
		{
			[Token(Token = "0x6006A14")]
			[Address(RVA = "0x3497DCC", Offset = "0x3497DCC", VA = "0x3497DCC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6006A15")]
			[Address(RVA = "0x3497DE8", Offset = "0x3497DE8", VA = "0x3497DE8")]
			set
			{
			}
		}

		// Token: 0x17000799 RID: 1945
		// (get) Token: 0x06006A16 RID: 27158 RVA: 0x0004D670 File Offset: 0x0004B870
		// (set) Token: 0x06006A17 RID: 27159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000799")]
		public bool AllowSingleQuotedStrings
		{
			[Token(Token = "0x6006A16")]
			[Address(RVA = "0x3497E08", Offset = "0x3497E08", VA = "0x3497E08")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6006A17")]
			[Address(RVA = "0x3497E24", Offset = "0x3497E24", VA = "0x3497E24")]
			set
			{
			}
		}

		// Token: 0x1700079A RID: 1946
		// (get) Token: 0x06006A18 RID: 27160 RVA: 0x0004D688 File Offset: 0x0004B888
		// (set) Token: 0x06006A19 RID: 27161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700079A")]
		public bool SkipNonMembers
		{
			[Token(Token = "0x6006A18")]
			[Address(RVA = "0x3497E44", Offset = "0x3497E44", VA = "0x3497E44")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6006A19")]
			[Address(RVA = "0x3497E4C", Offset = "0x3497E4C", VA = "0x3497E4C")]
			set
			{
			}
		}

		// Token: 0x1700079B RID: 1947
		// (get) Token: 0x06006A1A RID: 27162 RVA: 0x0004D6A0 File Offset: 0x0004B8A0
		[Token(Token = "0x1700079B")]
		public bool EndOfInput
		{
			[Token(Token = "0x6006A1A")]
			[Address(RVA = "0x3497E58", Offset = "0x3497E58", VA = "0x3497E58")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700079C RID: 1948
		// (get) Token: 0x06006A1B RID: 27163 RVA: 0x0004D6B8 File Offset: 0x0004B8B8
		[Token(Token = "0x1700079C")]
		public bool EndOfJson
		{
			[Token(Token = "0x6006A1B")]
			[Address(RVA = "0x3497E60", Offset = "0x3497E60", VA = "0x3497E60")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700079D RID: 1949
		// (get) Token: 0x06006A1C RID: 27164 RVA: 0x0004D6D0 File Offset: 0x0004B8D0
		[Token(Token = "0x1700079D")]
		public JsonToken Token
		{
			[Token(Token = "0x6006A1C")]
			[Address(RVA = "0x3497E68", Offset = "0x3497E68", VA = "0x3497E68")]
			get
			{
				return JsonToken.None;
			}
		}

		// Token: 0x1700079E RID: 1950
		// (get) Token: 0x06006A1D RID: 27165 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700079E")]
		public object Value
		{
			[Token(Token = "0x6006A1D")]
			[Address(RVA = "0x3497E70", Offset = "0x3497E70", VA = "0x3497E70")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006A1F RID: 27167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A1F")]
		[Address(RVA = "0x3496374", Offset = "0x3496374", VA = "0x3496374")]
		public JsonReader(string json_text)
		{
		}

		// Token: 0x06006A20 RID: 27168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A20")]
		[Address(RVA = "0x34960F0", Offset = "0x34960F0", VA = "0x34960F0")]
		public JsonReader(TextReader reader)
		{
		}

		// Token: 0x06006A21 RID: 27169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A21")]
		[Address(RVA = "0x3498638", Offset = "0x3498638", VA = "0x3498638")]
		private JsonReader(TextReader reader, bool owned)
		{
		}

		// Token: 0x06006A22 RID: 27170 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A22")]
		[Address(RVA = "0x3497ED0", Offset = "0x3497ED0", VA = "0x3497ED0")]
		private static IDictionary<int, IDictionary<int, int[]>> PopulateParseTable()
		{
			return null;
		}

		// Token: 0x06006A23 RID: 27171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A23")]
		[Address(RVA = "0x34989CC", Offset = "0x34989CC", VA = "0x34989CC")]
		private static void TableAddCol(IDictionary<int, IDictionary<int, int[]>> parse_table, ParserToken row, int col, params int[] symbols)
		{
		}

		// Token: 0x06006A24 RID: 27172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A24")]
		[Address(RVA = "0x34988D8", Offset = "0x34988D8", VA = "0x34988D8")]
		private static void TableAddRow(IDictionary<int, IDictionary<int, int[]>> parse_table, ParserToken rule)
		{
		}

		// Token: 0x06006A25 RID: 27173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A25")]
		[Address(RVA = "0x3498B00", Offset = "0x3498B00", VA = "0x3498B00")]
		private void ProcessNumber(string number)
		{
		}

		// Token: 0x06006A26 RID: 27174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A26")]
		[Address(RVA = "0x3498D48", Offset = "0x3498D48", VA = "0x3498D48")]
		private void ProcessSymbol()
		{
		}

		// Token: 0x06006A27 RID: 27175 RVA: 0x0004D6E8 File Offset: 0x0004B8E8
		[Token(Token = "0x6006A27")]
		[Address(RVA = "0x3498F00", Offset = "0x3498F00", VA = "0x3498F00")]
		private bool ReadToken()
		{
			return default(bool);
		}

		// Token: 0x06006A28 RID: 27176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A28")]
		[Address(RVA = "0x3499128", Offset = "0x3499128", VA = "0x3499128")]
		public void Close()
		{
		}

		// Token: 0x06006A29 RID: 27177 RVA: 0x0004D700 File Offset: 0x0004B900
		[Token(Token = "0x6006A29")]
		[Address(RVA = "0x34930F8", Offset = "0x34930F8", VA = "0x34930F8")]
		public bool Read()
		{
			return default(bool);
		}

		// Token: 0x04002AAD RID: 10925
		[Token(Token = "0x4002AAD")]
		[FieldOffset(Offset = "0x0")]
		private static readonly IDictionary<int, IDictionary<int, int[]>> parse_table;

		// Token: 0x04002AAE RID: 10926
		[Token(Token = "0x4002AAE")]
		[FieldOffset(Offset = "0x10")]
		private Stack<int> automaton_stack;

		// Token: 0x04002AAF RID: 10927
		[Token(Token = "0x4002AAF")]
		[FieldOffset(Offset = "0x18")]
		private int current_input;

		// Token: 0x04002AB0 RID: 10928
		[Token(Token = "0x4002AB0")]
		[FieldOffset(Offset = "0x1C")]
		private int current_symbol;

		// Token: 0x04002AB1 RID: 10929
		[Token(Token = "0x4002AB1")]
		[FieldOffset(Offset = "0x20")]
		private bool end_of_json;

		// Token: 0x04002AB2 RID: 10930
		[Token(Token = "0x4002AB2")]
		[FieldOffset(Offset = "0x21")]
		private bool end_of_input;

		// Token: 0x04002AB3 RID: 10931
		[Token(Token = "0x4002AB3")]
		[FieldOffset(Offset = "0x28")]
		private Lexer lexer;

		// Token: 0x04002AB4 RID: 10932
		[Token(Token = "0x4002AB4")]
		[FieldOffset(Offset = "0x30")]
		private bool parser_in_string;

		// Token: 0x04002AB5 RID: 10933
		[Token(Token = "0x4002AB5")]
		[FieldOffset(Offset = "0x31")]
		private bool parser_return;

		// Token: 0x04002AB6 RID: 10934
		[Token(Token = "0x4002AB6")]
		[FieldOffset(Offset = "0x32")]
		private bool read_started;

		// Token: 0x04002AB7 RID: 10935
		[Token(Token = "0x4002AB7")]
		[FieldOffset(Offset = "0x38")]
		private TextReader reader;

		// Token: 0x04002AB8 RID: 10936
		[Token(Token = "0x4002AB8")]
		[FieldOffset(Offset = "0x40")]
		private bool reader_is_owned;

		// Token: 0x04002AB9 RID: 10937
		[Token(Token = "0x4002AB9")]
		[FieldOffset(Offset = "0x41")]
		private bool skip_non_members;

		// Token: 0x04002ABA RID: 10938
		[Token(Token = "0x4002ABA")]
		[FieldOffset(Offset = "0x48")]
		private object token_value;

		// Token: 0x04002ABB RID: 10939
		[Token(Token = "0x4002ABB")]
		[FieldOffset(Offset = "0x50")]
		private JsonToken token;
	}
}
