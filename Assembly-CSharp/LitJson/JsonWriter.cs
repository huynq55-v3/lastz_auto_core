using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using Il2CppDummyDll;

namespace LitJson
{
	// Token: 0x02000AE2 RID: 2786
	[Token(Token = "0x2000AE2")]
	public class JsonWriter
	{
		// Token: 0x1700079F RID: 1951
		// (get) Token: 0x06006A2B RID: 27179 RVA: 0x0004D718 File Offset: 0x0004B918
		// (set) Token: 0x06006A2C RID: 27180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700079F")]
		public int IndentValue
		{
			[Token(Token = "0x6006A2B")]
			[Address(RVA = "0x3499200", Offset = "0x3499200", VA = "0x3499200")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6006A2C")]
			[Address(RVA = "0x3499208", Offset = "0x3499208", VA = "0x3499208")]
			set
			{
			}
		}

		// Token: 0x170007A0 RID: 1952
		// (get) Token: 0x06006A2D RID: 27181 RVA: 0x0004D730 File Offset: 0x0004B930
		// (set) Token: 0x06006A2E RID: 27182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007A0")]
		public bool PrettyPrint
		{
			[Token(Token = "0x6006A2D")]
			[Address(RVA = "0x349921C", Offset = "0x349921C", VA = "0x349921C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6006A2E")]
			[Address(RVA = "0x3499224", Offset = "0x3499224", VA = "0x3499224")]
			set
			{
			}
		}

		// Token: 0x170007A1 RID: 1953
		// (get) Token: 0x06006A2F RID: 27183 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007A1")]
		public TextWriter TextWriter
		{
			[Token(Token = "0x6006A2F")]
			[Address(RVA = "0x3499230", Offset = "0x3499230", VA = "0x3499230")]
			get
			{
				return null;
			}
		}

		// Token: 0x170007A2 RID: 1954
		// (get) Token: 0x06006A30 RID: 27184 RVA: 0x0004D748 File Offset: 0x0004B948
		// (set) Token: 0x06006A31 RID: 27185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007A2")]
		public bool Validate
		{
			[Token(Token = "0x6006A30")]
			[Address(RVA = "0x3499238", Offset = "0x3499238", VA = "0x3499238")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6006A31")]
			[Address(RVA = "0x3499240", Offset = "0x3499240", VA = "0x3499240")]
			set
			{
			}
		}

		// Token: 0x170007A3 RID: 1955
		// (get) Token: 0x06006A32 RID: 27186 RVA: 0x0004D760 File Offset: 0x0004B960
		// (set) Token: 0x06006A33 RID: 27187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007A3")]
		public bool LowerCaseProperties
		{
			[Token(Token = "0x6006A32")]
			[Address(RVA = "0x349924C", Offset = "0x349924C", VA = "0x349924C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6006A33")]
			[Address(RVA = "0x3499254", Offset = "0x3499254", VA = "0x3499254")]
			set
			{
			}
		}

		// Token: 0x06006A35 RID: 27189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A35")]
		[Address(RVA = "0x348EA08", Offset = "0x348EA08", VA = "0x348EA08")]
		public JsonWriter()
		{
		}

		// Token: 0x06006A36 RID: 27190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A36")]
		[Address(RVA = "0x34993F4", Offset = "0x34993F4", VA = "0x34993F4")]
		public JsonWriter(StringBuilder sb)
		{
		}

		// Token: 0x06006A37 RID: 27191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A37")]
		[Address(RVA = "0x348D804", Offset = "0x348D804", VA = "0x348D804")]
		public JsonWriter(TextWriter writer)
		{
		}

		// Token: 0x06006A38 RID: 27192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A38")]
		[Address(RVA = "0x3499468", Offset = "0x3499468", VA = "0x3499468")]
		private void DoValidation(Condition cond)
		{
		}

		// Token: 0x06006A39 RID: 27193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A39")]
		[Address(RVA = "0x34992BC", Offset = "0x34992BC", VA = "0x34992BC")]
		private void Init()
		{
		}

		// Token: 0x06006A3A RID: 27194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A3A")]
		[Address(RVA = "0x3499604", Offset = "0x3499604", VA = "0x3499604")]
		private static void IntToHex(int n, char[] hex)
		{
		}

		// Token: 0x06006A3B RID: 27195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A3B")]
		[Address(RVA = "0x349967C", Offset = "0x349967C", VA = "0x349967C")]
		private void Indent()
		{
		}

		// Token: 0x06006A3C RID: 27196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A3C")]
		[Address(RVA = "0x3499694", Offset = "0x3499694", VA = "0x3499694")]
		private void Put(string str)
		{
		}

		// Token: 0x06006A3D RID: 27197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A3D")]
		[Address(RVA = "0x3499720", Offset = "0x3499720", VA = "0x3499720")]
		private void PutNewline()
		{
		}

		// Token: 0x06006A3E RID: 27198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A3E")]
		[Address(RVA = "0x3499728", Offset = "0x3499728", VA = "0x3499728")]
		private void PutNewline(bool add_comma)
		{
		}

		// Token: 0x06006A3F RID: 27199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A3F")]
		[Address(RVA = "0x34997BC", Offset = "0x34997BC", VA = "0x34997BC")]
		private void PutString(string str)
		{
		}

		// Token: 0x06006A40 RID: 27200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A40")]
		[Address(RVA = "0x3499AC4", Offset = "0x3499AC4", VA = "0x3499AC4")]
		private void Unindent()
		{
		}

		// Token: 0x06006A41 RID: 27201 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A41")]
		[Address(RVA = "0x3499ADC", Offset = "0x3499ADC", VA = "0x3499ADC", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06006A42 RID: 27202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A42")]
		[Address(RVA = "0x3495CBC", Offset = "0x3495CBC", VA = "0x3495CBC")]
		public void Reset()
		{
		}

		// Token: 0x06006A43 RID: 27203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A43")]
		[Address(RVA = "0x348C784", Offset = "0x348C784", VA = "0x348C784")]
		public void Write(bool boolean)
		{
		}

		// Token: 0x06006A44 RID: 27204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A44")]
		[Address(RVA = "0x3496938", Offset = "0x3496938", VA = "0x3496938")]
		public void Write(decimal number)
		{
		}

		// Token: 0x06006A45 RID: 27205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A45")]
		[Address(RVA = "0x348C81C", Offset = "0x348C81C", VA = "0x348C81C")]
		public void Write(double number)
		{
		}

		// Token: 0x06006A46 RID: 27206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A46")]
		[Address(RVA = "0x349599C", Offset = "0x349599C", VA = "0x349599C")]
		public void Write(float number)
		{
		}

		// Token: 0x06006A47 RID: 27207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A47")]
		[Address(RVA = "0x348C958", Offset = "0x348C958", VA = "0x348C958")]
		public void Write(int number)
		{
		}

		// Token: 0x06006A48 RID: 27208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A48")]
		[Address(RVA = "0x348CA2C", Offset = "0x348CA2C", VA = "0x348CA2C")]
		public void Write(long number)
		{
		}

		// Token: 0x06006A49 RID: 27209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A49")]
		[Address(RVA = "0x348C6F8", Offset = "0x348C6F8", VA = "0x348C6F8")]
		public void Write(string str)
		{
		}

		// Token: 0x06006A4A RID: 27210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A4A")]
		[Address(RVA = "0x3495A70", Offset = "0x3495A70", VA = "0x3495A70")]
		public void Write(ulong number)
		{
		}

		// Token: 0x06006A4B RID: 27211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A4B")]
		[Address(RVA = "0x348CBF8", Offset = "0x348CBF8", VA = "0x348CBF8")]
		public void WriteArrayEnd()
		{
		}

		// Token: 0x06006A4C RID: 27212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A4C")]
		[Address(RVA = "0x348CB00", Offset = "0x348CB00", VA = "0x348CB00")]
		public void WriteArrayStart()
		{
		}

		// Token: 0x06006A4D RID: 27213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A4D")]
		[Address(RVA = "0x348CF1C", Offset = "0x348CF1C", VA = "0x348CF1C")]
		public void WriteObjectEnd()
		{
		}

		// Token: 0x06006A4E RID: 27214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A4E")]
		[Address(RVA = "0x348CCF8", Offset = "0x348CCF8", VA = "0x348CCF8")]
		public void WriteObjectStart()
		{
		}

		// Token: 0x06006A4F RID: 27215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A4F")]
		[Address(RVA = "0x348CDF0", Offset = "0x348CDF0", VA = "0x348CDF0")]
		public void WritePropertyName(string property_name)
		{
		}

		// Token: 0x04002AC7 RID: 10951
		[Token(Token = "0x4002AC7")]
		[FieldOffset(Offset = "0x0")]
		private static readonly NumberFormatInfo number_format;

		// Token: 0x04002AC8 RID: 10952
		[Token(Token = "0x4002AC8")]
		[FieldOffset(Offset = "0x10")]
		private WriterContext context;

		// Token: 0x04002AC9 RID: 10953
		[Token(Token = "0x4002AC9")]
		[FieldOffset(Offset = "0x18")]
		private Stack<WriterContext> ctx_stack;

		// Token: 0x04002ACA RID: 10954
		[Token(Token = "0x4002ACA")]
		[FieldOffset(Offset = "0x20")]
		private bool has_reached_end;

		// Token: 0x04002ACB RID: 10955
		[Token(Token = "0x4002ACB")]
		[FieldOffset(Offset = "0x28")]
		private char[] hex_seq;

		// Token: 0x04002ACC RID: 10956
		[Token(Token = "0x4002ACC")]
		[FieldOffset(Offset = "0x30")]
		private int indentation;

		// Token: 0x04002ACD RID: 10957
		[Token(Token = "0x4002ACD")]
		[FieldOffset(Offset = "0x34")]
		private int indent_value;

		// Token: 0x04002ACE RID: 10958
		[Token(Token = "0x4002ACE")]
		[FieldOffset(Offset = "0x38")]
		private StringBuilder inst_string_builder;

		// Token: 0x04002ACF RID: 10959
		[Token(Token = "0x4002ACF")]
		[FieldOffset(Offset = "0x40")]
		private bool pretty_print;

		// Token: 0x04002AD0 RID: 10960
		[Token(Token = "0x4002AD0")]
		[FieldOffset(Offset = "0x41")]
		private bool validate;

		// Token: 0x04002AD1 RID: 10961
		[Token(Token = "0x4002AD1")]
		[FieldOffset(Offset = "0x42")]
		private bool lower_case_properties;

		// Token: 0x04002AD2 RID: 10962
		[Token(Token = "0x4002AD2")]
		[FieldOffset(Offset = "0x48")]
		private TextWriter writer;
	}
}
