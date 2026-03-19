using System;
using System.IO;
using System.Text;
using Il2CppDummyDll;

namespace LitJson
{
	// Token: 0x02000AE4 RID: 2788
	[Token(Token = "0x2000AE4")]
	internal class Lexer
	{
		// Token: 0x170007A4 RID: 1956
		// (get) Token: 0x06006A51 RID: 27217 RVA: 0x0004D778 File Offset: 0x0004B978
		// (set) Token: 0x06006A52 RID: 27218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007A4")]
		public bool AllowComments
		{
			[Token(Token = "0x6006A51")]
			[Address(RVA = "0x3499B4C", Offset = "0x3499B4C", VA = "0x3499B4C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6006A52")]
			[Address(RVA = "0x3499B54", Offset = "0x3499B54", VA = "0x3499B54")]
			set
			{
			}
		}

		// Token: 0x170007A5 RID: 1957
		// (get) Token: 0x06006A53 RID: 27219 RVA: 0x0004D790 File Offset: 0x0004B990
		// (set) Token: 0x06006A54 RID: 27220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007A5")]
		public bool AllowSingleQuotedStrings
		{
			[Token(Token = "0x6006A53")]
			[Address(RVA = "0x3499B60", Offset = "0x3499B60", VA = "0x3499B60")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6006A54")]
			[Address(RVA = "0x3499B68", Offset = "0x3499B68", VA = "0x3499B68")]
			set
			{
			}
		}

		// Token: 0x170007A6 RID: 1958
		// (get) Token: 0x06006A55 RID: 27221 RVA: 0x0004D7A8 File Offset: 0x0004B9A8
		[Token(Token = "0x170007A6")]
		public bool EndOfInput
		{
			[Token(Token = "0x6006A55")]
			[Address(RVA = "0x3499B74", Offset = "0x3499B74", VA = "0x3499B74")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170007A7 RID: 1959
		// (get) Token: 0x06006A56 RID: 27222 RVA: 0x0004D7C0 File Offset: 0x0004B9C0
		[Token(Token = "0x170007A7")]
		public int Token
		{
			[Token(Token = "0x6006A56")]
			[Address(RVA = "0x3499B7C", Offset = "0x3499B7C", VA = "0x3499B7C")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170007A8 RID: 1960
		// (get) Token: 0x06006A57 RID: 27223 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007A8")]
		public string StringValue
		{
			[Token(Token = "0x6006A57")]
			[Address(RVA = "0x3499B84", Offset = "0x3499B84", VA = "0x3499B84")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006A59 RID: 27225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A59")]
		[Address(RVA = "0x34987D8", Offset = "0x34987D8", VA = "0x34987D8")]
		public Lexer(TextReader reader)
		{
		}

		// Token: 0x06006A5A RID: 27226 RVA: 0x0004D7D8 File Offset: 0x0004B9D8
		[Token(Token = "0x6006A5A")]
		[Address(RVA = "0x349A748", Offset = "0x349A748", VA = "0x349A748")]
		private static int HexValue(int digit)
		{
			return 0;
		}

		// Token: 0x06006A5B RID: 27227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A5B")]
		[Address(RVA = "0x3499BD4", Offset = "0x3499BD4", VA = "0x3499BD4")]
		private static void PopulateFsmTables(out Lexer.StateHandler[] fsm_handler_table, out int[] fsm_return_table)
		{
		}

		// Token: 0x06006A5C RID: 27228 RVA: 0x0004D7F0 File Offset: 0x0004B9F0
		[Token(Token = "0x6006A5C")]
		[Address(RVA = "0x349A908", Offset = "0x349A908", VA = "0x349A908")]
		private static char ProcessEscChar(int esc_char)
		{
			return '\0';
		}

		// Token: 0x06006A5D RID: 27229 RVA: 0x0004D808 File Offset: 0x0004BA08
		[Token(Token = "0x6006A5D")]
		[Address(RVA = "0x349A9F8", Offset = "0x349A9F8", VA = "0x349A9F8")]
		private static bool State1(FsmContext ctx)
		{
			return default(bool);
		}

		// Token: 0x06006A5E RID: 27230 RVA: 0x0004D820 File Offset: 0x0004BA20
		[Token(Token = "0x6006A5E")]
		[Address(RVA = "0x349ABFC", Offset = "0x349ABFC", VA = "0x349ABFC")]
		private static bool State2(FsmContext ctx)
		{
			return default(bool);
		}

		// Token: 0x06006A5F RID: 27231 RVA: 0x0004D838 File Offset: 0x0004BA38
		[Token(Token = "0x6006A5F")]
		[Address(RVA = "0x349ACA0", Offset = "0x349ACA0", VA = "0x349ACA0")]
		private static bool State3(FsmContext ctx)
		{
			return default(bool);
		}

		// Token: 0x06006A60 RID: 27232 RVA: 0x0004D850 File Offset: 0x0004BA50
		[Token(Token = "0x6006A60")]
		[Address(RVA = "0x349ADDC", Offset = "0x349ADDC", VA = "0x349ADDC")]
		private static bool State4(FsmContext ctx)
		{
			return default(bool);
		}

		// Token: 0x06006A61 RID: 27233 RVA: 0x0004D868 File Offset: 0x0004BA68
		[Token(Token = "0x6006A61")]
		[Address(RVA = "0x349AED8", Offset = "0x349AED8", VA = "0x349AED8")]
		private static bool State5(FsmContext ctx)
		{
			return default(bool);
		}

		// Token: 0x06006A62 RID: 27234 RVA: 0x0004D880 File Offset: 0x0004BA80
		[Token(Token = "0x6006A62")]
		[Address(RVA = "0x349AF58", Offset = "0x349AF58", VA = "0x349AF58")]
		private static bool State6(FsmContext ctx)
		{
			return default(bool);
		}

		// Token: 0x06006A63 RID: 27235 RVA: 0x0004D898 File Offset: 0x0004BA98
		[Token(Token = "0x6006A63")]
		[Address(RVA = "0x349B054", Offset = "0x349B054", VA = "0x349B054")]
		private static bool State7(FsmContext ctx)
		{
			return default(bool);
		}

		// Token: 0x06006A64 RID: 27236 RVA: 0x0004D8B0 File Offset: 0x0004BAB0
		[Token(Token = "0x6006A64")]
		[Address(RVA = "0x349B0E8", Offset = "0x349B0E8", VA = "0x349B0E8")]
		private static bool State8(FsmContext ctx)
		{
			return default(bool);
		}

		// Token: 0x06006A65 RID: 27237 RVA: 0x0004D8C8 File Offset: 0x0004BAC8
		[Token(Token = "0x6006A65")]
		[Address(RVA = "0x349B1A4", Offset = "0x349B1A4", VA = "0x349B1A4")]
		private static bool State9(FsmContext ctx)
		{
			return default(bool);
		}

		// Token: 0x06006A66 RID: 27238 RVA: 0x0004D8E0 File Offset: 0x0004BAE0
		[Token(Token = "0x6006A66")]
		[Address(RVA = "0x349B210", Offset = "0x349B210", VA = "0x349B210")]
		private static bool State10(FsmContext ctx)
		{
			return default(bool);
		}

		// Token: 0x06006A67 RID: 27239 RVA: 0x0004D8F8 File Offset: 0x0004BAF8
		[Token(Token = "0x6006A67")]
		[Address(RVA = "0x349B27C", Offset = "0x349B27C", VA = "0x349B27C")]
		private static bool State11(FsmContext ctx)
		{
			return default(bool);
		}

		// Token: 0x06006A68 RID: 27240 RVA: 0x0004D910 File Offset: 0x0004BB10
		[Token(Token = "0x6006A68")]
		[Address(RVA = "0x349B2E8", Offset = "0x349B2E8", VA = "0x349B2E8")]
		private static bool State12(FsmContext ctx)
		{
			return default(bool);
		}

		// Token: 0x06006A69 RID: 27241 RVA: 0x0004D928 File Offset: 0x0004BB28
		[Token(Token = "0x6006A69")]
		[Address(RVA = "0x349B354", Offset = "0x349B354", VA = "0x349B354")]
		private static bool State13(FsmContext ctx)
		{
			return default(bool);
		}

		// Token: 0x06006A6A RID: 27242 RVA: 0x0004D940 File Offset: 0x0004BB40
		[Token(Token = "0x6006A6A")]
		[Address(RVA = "0x349B3C0", Offset = "0x349B3C0", VA = "0x349B3C0")]
		private static bool State14(FsmContext ctx)
		{
			return default(bool);
		}

		// Token: 0x06006A6B RID: 27243 RVA: 0x0004D958 File Offset: 0x0004BB58
		[Token(Token = "0x6006A6B")]
		[Address(RVA = "0x349B42C", Offset = "0x349B42C", VA = "0x349B42C")]
		private static bool State15(FsmContext ctx)
		{
			return default(bool);
		}

		// Token: 0x06006A6C RID: 27244 RVA: 0x0004D970 File Offset: 0x0004BB70
		[Token(Token = "0x6006A6C")]
		[Address(RVA = "0x349B498", Offset = "0x349B498", VA = "0x349B498")]
		private static bool State16(FsmContext ctx)
		{
			return default(bool);
		}

		// Token: 0x06006A6D RID: 27245 RVA: 0x0004D988 File Offset: 0x0004BB88
		[Token(Token = "0x6006A6D")]
		[Address(RVA = "0x349B504", Offset = "0x349B504", VA = "0x349B504")]
		private static bool State17(FsmContext ctx)
		{
			return default(bool);
		}

		// Token: 0x06006A6E RID: 27246 RVA: 0x0004D9A0 File Offset: 0x0004BBA0
		[Token(Token = "0x6006A6E")]
		[Address(RVA = "0x349B570", Offset = "0x349B570", VA = "0x349B570")]
		private static bool State18(FsmContext ctx)
		{
			return default(bool);
		}

		// Token: 0x06006A6F RID: 27247 RVA: 0x0004D9B8 File Offset: 0x0004BBB8
		[Token(Token = "0x6006A6F")]
		[Address(RVA = "0x349B5DC", Offset = "0x349B5DC", VA = "0x349B5DC")]
		private static bool State19(FsmContext ctx)
		{
			return default(bool);
		}

		// Token: 0x06006A70 RID: 27248 RVA: 0x0004D9D0 File Offset: 0x0004BBD0
		[Token(Token = "0x6006A70")]
		[Address(RVA = "0x349B684", Offset = "0x349B684", VA = "0x349B684")]
		private static bool State20(FsmContext ctx)
		{
			return default(bool);
		}

		// Token: 0x06006A71 RID: 27249 RVA: 0x0004D9E8 File Offset: 0x0004BBE8
		[Token(Token = "0x6006A71")]
		[Address(RVA = "0x349B6F0", Offset = "0x349B6F0", VA = "0x349B6F0")]
		private static bool State21(FsmContext ctx)
		{
			return default(bool);
		}

		// Token: 0x06006A72 RID: 27250 RVA: 0x0004DA00 File Offset: 0x0004BC00
		[Token(Token = "0x6006A72")]
		[Address(RVA = "0x349B828", Offset = "0x349B828", VA = "0x349B828")]
		private static bool State22(FsmContext ctx)
		{
			return default(bool);
		}

		// Token: 0x06006A73 RID: 27251 RVA: 0x0004DA18 File Offset: 0x0004BC18
		[Token(Token = "0x6006A73")]
		[Address(RVA = "0x349B9A4", Offset = "0x349B9A4", VA = "0x349B9A4")]
		private static bool State23(FsmContext ctx)
		{
			return default(bool);
		}

		// Token: 0x06006A74 RID: 27252 RVA: 0x0004DA30 File Offset: 0x0004BC30
		[Token(Token = "0x6006A74")]
		[Address(RVA = "0x349BA4C", Offset = "0x349BA4C", VA = "0x349BA4C")]
		private static bool State24(FsmContext ctx)
		{
			return default(bool);
		}

		// Token: 0x06006A75 RID: 27253 RVA: 0x0004DA48 File Offset: 0x0004BC48
		[Token(Token = "0x6006A75")]
		[Address(RVA = "0x349BAC0", Offset = "0x349BAC0", VA = "0x349BAC0")]
		private static bool State25(FsmContext ctx)
		{
			return default(bool);
		}

		// Token: 0x06006A76 RID: 27254 RVA: 0x0004DA60 File Offset: 0x0004BC60
		[Token(Token = "0x6006A76")]
		[Address(RVA = "0x349BB3C", Offset = "0x349BB3C", VA = "0x349BB3C")]
		private static bool State26(FsmContext ctx)
		{
			return default(bool);
		}

		// Token: 0x06006A77 RID: 27255 RVA: 0x0004DA78 File Offset: 0x0004BC78
		[Token(Token = "0x6006A77")]
		[Address(RVA = "0x349BBA4", Offset = "0x349BBA4", VA = "0x349BBA4")]
		private static bool State27(FsmContext ctx)
		{
			return default(bool);
		}

		// Token: 0x06006A78 RID: 27256 RVA: 0x0004DA90 File Offset: 0x0004BC90
		[Token(Token = "0x6006A78")]
		[Address(RVA = "0x349BC0C", Offset = "0x349BC0C", VA = "0x349BC0C")]
		private static bool State28(FsmContext ctx)
		{
			return default(bool);
		}

		// Token: 0x06006A79 RID: 27257 RVA: 0x0004DAA8 File Offset: 0x0004BCA8
		[Token(Token = "0x6006A79")]
		[Address(RVA = "0x349ABD0", Offset = "0x349ABD0", VA = "0x349ABD0")]
		private bool GetChar()
		{
			return default(bool);
		}

		// Token: 0x06006A7A RID: 27258 RVA: 0x0004DAC0 File Offset: 0x0004BCC0
		[Token(Token = "0x6006A7A")]
		[Address(RVA = "0x349BC84", Offset = "0x349BC84", VA = "0x349BC84")]
		private int NextChar()
		{
			return 0;
		}

		// Token: 0x06006A7B RID: 27259 RVA: 0x0004DAD8 File Offset: 0x0004BCD8
		[Token(Token = "0x6006A7B")]
		[Address(RVA = "0x3498F54", Offset = "0x3498F54", VA = "0x3498F54")]
		public bool NextToken()
		{
			return default(bool);
		}

		// Token: 0x06006A7C RID: 27260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A7C")]
		[Address(RVA = "0x349ADD0", Offset = "0x349ADD0", VA = "0x349ADD0")]
		private void UngetChar()
		{
		}

		// Token: 0x04002AD7 RID: 10967
		[Token(Token = "0x4002AD7")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int[] fsm_return_table;

		// Token: 0x04002AD8 RID: 10968
		[Token(Token = "0x4002AD8")]
		[FieldOffset(Offset = "0x8")]
		private static readonly Lexer.StateHandler[] fsm_handler_table;

		// Token: 0x04002AD9 RID: 10969
		[Token(Token = "0x4002AD9")]
		[FieldOffset(Offset = "0x10")]
		private bool allow_comments;

		// Token: 0x04002ADA RID: 10970
		[Token(Token = "0x4002ADA")]
		[FieldOffset(Offset = "0x11")]
		private bool allow_single_quoted_strings;

		// Token: 0x04002ADB RID: 10971
		[Token(Token = "0x4002ADB")]
		[FieldOffset(Offset = "0x12")]
		private bool end_of_input;

		// Token: 0x04002ADC RID: 10972
		[Token(Token = "0x4002ADC")]
		[FieldOffset(Offset = "0x18")]
		private FsmContext fsm_context;

		// Token: 0x04002ADD RID: 10973
		[Token(Token = "0x4002ADD")]
		[FieldOffset(Offset = "0x20")]
		private int input_buffer;

		// Token: 0x04002ADE RID: 10974
		[Token(Token = "0x4002ADE")]
		[FieldOffset(Offset = "0x24")]
		private int input_char;

		// Token: 0x04002ADF RID: 10975
		[Token(Token = "0x4002ADF")]
		[FieldOffset(Offset = "0x28")]
		private TextReader reader;

		// Token: 0x04002AE0 RID: 10976
		[Token(Token = "0x4002AE0")]
		[FieldOffset(Offset = "0x30")]
		private int state;

		// Token: 0x04002AE1 RID: 10977
		[Token(Token = "0x4002AE1")]
		[FieldOffset(Offset = "0x38")]
		private StringBuilder string_buffer;

		// Token: 0x04002AE2 RID: 10978
		[Token(Token = "0x4002AE2")]
		[FieldOffset(Offset = "0x40")]
		private string string_value;

		// Token: 0x04002AE3 RID: 10979
		[Token(Token = "0x4002AE3")]
		[FieldOffset(Offset = "0x48")]
		private int token;

		// Token: 0x04002AE4 RID: 10980
		[Token(Token = "0x4002AE4")]
		[FieldOffset(Offset = "0x4C")]
		private int unichar;

		// Token: 0x02000AE5 RID: 2789
		// (Invoke) Token: 0x06006A7E RID: 27262
		[Token(Token = "0x2000AE5")]
		private delegate bool StateHandler(FsmContext ctx);
	}
}
