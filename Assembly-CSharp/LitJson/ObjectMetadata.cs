using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace LitJson
{
	// Token: 0x02000AD3 RID: 2771
	[Token(Token = "0x2000AD3")]
	internal struct ObjectMetadata
	{
		// Token: 0x17000782 RID: 1922
		// (get) Token: 0x06006985 RID: 27013 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006986 RID: 27014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000782")]
		public Type ElementType
		{
			[Token(Token = "0x6006985")]
			[Address(RVA = "0x348E108", Offset = "0x348E108", VA = "0x348E108")]
			get
			{
				return null;
			}
			[Token(Token = "0x6006986")]
			[Address(RVA = "0x348E1B0", Offset = "0x348E1B0", VA = "0x348E1B0")]
			set
			{
			}
		}

		// Token: 0x17000783 RID: 1923
		// (get) Token: 0x06006987 RID: 27015 RVA: 0x0004D430 File Offset: 0x0004B630
		// (set) Token: 0x06006988 RID: 27016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000783")]
		public bool IsDictionary
		{
			[Token(Token = "0x6006987")]
			[Address(RVA = "0x348E1B8", Offset = "0x348E1B8", VA = "0x348E1B8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6006988")]
			[Address(RVA = "0x348E1C0", Offset = "0x348E1C0", VA = "0x348E1C0")]
			set
			{
			}
		}

		// Token: 0x17000784 RID: 1924
		// (get) Token: 0x06006989 RID: 27017 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600698A RID: 27018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000784")]
		public IDictionary<string, PropertyMetadata> Properties
		{
			[Token(Token = "0x6006989")]
			[Address(RVA = "0x348E1CC", Offset = "0x348E1CC", VA = "0x348E1CC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600698A")]
			[Address(RVA = "0x348E1D4", Offset = "0x348E1D4", VA = "0x348E1D4")]
			set
			{
			}
		}

		// Token: 0x04002A6D RID: 10861
		[Token(Token = "0x4002A6D")]
		[FieldOffset(Offset = "0x0")]
		private Type element_type;

		// Token: 0x04002A6E RID: 10862
		[Token(Token = "0x4002A6E")]
		[FieldOffset(Offset = "0x8")]
		private bool is_dictionary;

		// Token: 0x04002A6F RID: 10863
		[Token(Token = "0x4002A6F")]
		[FieldOffset(Offset = "0x10")]
		private IDictionary<string, PropertyMetadata> properties;
	}
}
