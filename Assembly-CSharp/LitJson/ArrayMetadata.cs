using System;
using Il2CppDummyDll;

namespace LitJson
{
	// Token: 0x02000AD2 RID: 2770
	[Token(Token = "0x2000AD2")]
	internal struct ArrayMetadata
	{
		// Token: 0x1700077F RID: 1919
		// (get) Token: 0x0600697F RID: 27007 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006980 RID: 27008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700077F")]
		public Type ElementType
		{
			[Token(Token = "0x600697F")]
			[Address(RVA = "0x348E030", Offset = "0x348E030", VA = "0x348E030")]
			get
			{
				return null;
			}
			[Token(Token = "0x6006980")]
			[Address(RVA = "0x348E0D8", Offset = "0x348E0D8", VA = "0x348E0D8")]
			set
			{
			}
		}

		// Token: 0x17000780 RID: 1920
		// (get) Token: 0x06006981 RID: 27009 RVA: 0x0004D400 File Offset: 0x0004B600
		// (set) Token: 0x06006982 RID: 27010 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000780")]
		public bool IsArray
		{
			[Token(Token = "0x6006981")]
			[Address(RVA = "0x348E0E0", Offset = "0x348E0E0", VA = "0x348E0E0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6006982")]
			[Address(RVA = "0x348E0E8", Offset = "0x348E0E8", VA = "0x348E0E8")]
			set
			{
			}
		}

		// Token: 0x17000781 RID: 1921
		// (get) Token: 0x06006983 RID: 27011 RVA: 0x0004D418 File Offset: 0x0004B618
		// (set) Token: 0x06006984 RID: 27012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000781")]
		public bool IsList
		{
			[Token(Token = "0x6006983")]
			[Address(RVA = "0x348E0F4", Offset = "0x348E0F4", VA = "0x348E0F4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6006984")]
			[Address(RVA = "0x348E0FC", Offset = "0x348E0FC", VA = "0x348E0FC")]
			set
			{
			}
		}

		// Token: 0x04002A6A RID: 10858
		[Token(Token = "0x4002A6A")]
		[FieldOffset(Offset = "0x0")]
		private Type element_type;

		// Token: 0x04002A6B RID: 10859
		[Token(Token = "0x4002A6B")]
		[FieldOffset(Offset = "0x8")]
		private bool is_array;

		// Token: 0x04002A6C RID: 10860
		[Token(Token = "0x4002A6C")]
		[FieldOffset(Offset = "0x9")]
		private bool is_list;
	}
}
