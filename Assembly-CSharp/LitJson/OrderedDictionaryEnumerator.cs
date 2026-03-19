using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace LitJson
{
	// Token: 0x02000ACF RID: 2767
	[Token(Token = "0x2000ACF")]
	internal class OrderedDictionaryEnumerator : IDictionaryEnumerator, IEnumerator
	{
		// Token: 0x1700077B RID: 1915
		// (get) Token: 0x06006971 RID: 26993 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700077B")]
		public object Current
		{
			[Token(Token = "0x6006971")]
			[Address(RVA = "0x348D9A8", Offset = "0x348D9A8", VA = "0x348D9A8", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700077C RID: 1916
		// (get) Token: 0x06006972 RID: 26994 RVA: 0x0004D3D0 File Offset: 0x0004B5D0
		[Token(Token = "0x1700077C")]
		public DictionaryEntry Entry
		{
			[Token(Token = "0x6006972")]
			[Address(RVA = "0x348DA0C", Offset = "0x348DA0C", VA = "0x348DA0C", Slot = "6")]
			get
			{
				return default(DictionaryEntry);
			}
		}

		// Token: 0x1700077D RID: 1917
		// (get) Token: 0x06006973 RID: 26995 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700077D")]
		public object Key
		{
			[Token(Token = "0x6006973")]
			[Address(RVA = "0x348DAF4", Offset = "0x348DAF4", VA = "0x348DAF4", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700077E RID: 1918
		// (get) Token: 0x06006974 RID: 26996 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700077E")]
		public object Value
		{
			[Token(Token = "0x6006974")]
			[Address(RVA = "0x348DBA0", Offset = "0x348DBA0", VA = "0x348DBA0", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006975 RID: 26997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006975")]
		[Address(RVA = "0x348B7E4", Offset = "0x348B7E4", VA = "0x348B7E4")]
		public OrderedDictionaryEnumerator(IEnumerator<KeyValuePair<string, JsonData>> enumerator)
		{
		}

		// Token: 0x06006976 RID: 26998 RVA: 0x0004D3E8 File Offset: 0x0004B5E8
		[Token(Token = "0x6006976")]
		[Address(RVA = "0x348DC54", Offset = "0x348DC54", VA = "0x348DC54", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x06006977 RID: 26999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006977")]
		[Address(RVA = "0x348DCF4", Offset = "0x348DCF4", VA = "0x348DCF4", Slot = "9")]
		public void Reset()
		{
		}

		// Token: 0x04002A66 RID: 10854
		[Token(Token = "0x4002A66")]
		[FieldOffset(Offset = "0x10")]
		private IEnumerator<KeyValuePair<string, JsonData>> list_enumerator;
	}
}
