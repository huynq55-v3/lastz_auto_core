using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace XLua
{
	// Token: 0x02000553 RID: 1363
	[Token(Token = "0x2000553")]
	public class ObjectTranslatorPool
	{
		// Token: 0x170005EC RID: 1516
		// (get) Token: 0x060028C2 RID: 10434 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005EC")]
		public static ObjectTranslatorPool Instance
		{
			[Token(Token = "0x60028C2")]
			[Address(RVA = "0x26BF1BC", Offset = "0x26BF1BC", VA = "0x26BF1BC")]
			get
			{
				return null;
			}
		}

		// Token: 0x060028C3 RID: 10435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028C3")]
		[Address(RVA = "0x26BF21C", Offset = "0x26BF21C", VA = "0x26BF21C")]
		public ObjectTranslatorPool()
		{
		}

		// Token: 0x060028C4 RID: 10436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028C4")]
		[Address(RVA = "0x26BF2A4", Offset = "0x26BF2A4", VA = "0x26BF2A4")]
		public void Add(IntPtr L, ObjectTranslator translator)
		{
		}

		// Token: 0x060028C5 RID: 10437 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028C5")]
		[Address(RVA = "0x26BF388", Offset = "0x26BF388", VA = "0x26BF388")]
		public ObjectTranslator Find(IntPtr L)
		{
			return null;
		}

		// Token: 0x060028C6 RID: 10438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028C6")]
		[Address(RVA = "0x26BF51C", Offset = "0x26BF51C", VA = "0x26BF51C")]
		public void Remove(IntPtr L)
		{
		}

		// Token: 0x0400242C RID: 9260
		[Token(Token = "0x400242C")]
		[FieldOffset(Offset = "0x10")]
		private Dictionary<IntPtr, WeakReference> translators;

		// Token: 0x0400242D RID: 9261
		[Token(Token = "0x400242D")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr lastPtr;

		// Token: 0x0400242E RID: 9262
		[Token(Token = "0x400242E")]
		[FieldOffset(Offset = "0x20")]
		private ObjectTranslator lastTranslator;
	}
}
