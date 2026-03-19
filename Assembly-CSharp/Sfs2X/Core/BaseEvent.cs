using System;
using System.Collections;
using Il2CppDummyDll;

namespace Sfs2X.Core
{
	// Token: 0x02000A7B RID: 2683
	[Token(Token = "0x2000A7B")]
	public class BaseEvent
	{
		// Token: 0x170006C5 RID: 1733
		// (get) Token: 0x0600667D RID: 26237 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600667E RID: 26238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006C5")]
		public string Type
		{
			[Token(Token = "0x600667D")]
			[Address(RVA = "0x33BD294", Offset = "0x33BD294", VA = "0x33BD294")]
			get
			{
				return null;
			}
			[Token(Token = "0x600667E")]
			[Address(RVA = "0x33BD29C", Offset = "0x33BD29C", VA = "0x33BD29C")]
			set
			{
			}
		}

		// Token: 0x170006C6 RID: 1734
		// (get) Token: 0x0600667F RID: 26239 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006680 RID: 26240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006C6")]
		public IDictionary Params
		{
			[Token(Token = "0x600667F")]
			[Address(RVA = "0x33BD2A4", Offset = "0x33BD2A4", VA = "0x33BD2A4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6006680")]
			[Address(RVA = "0x33BD2AC", Offset = "0x33BD2AC", VA = "0x33BD2AC")]
			set
			{
			}
		}

		// Token: 0x170006C7 RID: 1735
		// (get) Token: 0x06006681 RID: 26241 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006682 RID: 26242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006C7")]
		public object Target
		{
			[Token(Token = "0x6006681")]
			[Address(RVA = "0x33BD368", Offset = "0x33BD368", VA = "0x33BD368")]
			get
			{
				return null;
			}
			[Token(Token = "0x6006682")]
			[Address(RVA = "0x33BD370", Offset = "0x33BD370", VA = "0x33BD370")]
			set
			{
			}
		}

		// Token: 0x06006683 RID: 26243 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006683")]
		[Address(RVA = "0x33BD378", Offset = "0x33BD378", VA = "0x33BD378", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06006684 RID: 26244 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006684")]
		[Address(RVA = "0x33BD414", Offset = "0x33BD414", VA = "0x33BD414")]
		public BaseEvent Clone()
		{
			return null;
		}

		// Token: 0x06006685 RID: 26245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006685")]
		[Address(RVA = "0x33BD4C0", Offset = "0x33BD4C0", VA = "0x33BD4C0")]
		public BaseEvent(string type)
		{
		}

		// Token: 0x06006686 RID: 26246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006686")]
		[Address(RVA = "0x33BD47C", Offset = "0x33BD47C", VA = "0x33BD47C")]
		public BaseEvent(string type, Hashtable args)
		{
		}

		// Token: 0x040028DF RID: 10463
		[Token(Token = "0x40028DF")]
		[FieldOffset(Offset = "0x10")]
		protected Hashtable arguments;

		// Token: 0x040028E0 RID: 10464
		[Token(Token = "0x40028E0")]
		[FieldOffset(Offset = "0x18")]
		protected string type;

		// Token: 0x040028E1 RID: 10465
		[Token(Token = "0x40028E1")]
		[FieldOffset(Offset = "0x20")]
		protected object target;
	}
}
