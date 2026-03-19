using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace XLua
{
	// Token: 0x02000533 RID: 1331
	[Token(Token = "0x2000533")]
	public class ObjectCheckers
	{
		// Token: 0x060027DD RID: 10205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027DD")]
		[Address(RVA = "0x26AF7A0", Offset = "0x26AF7A0", VA = "0x26AF7A0")]
		public ObjectCheckers(ObjectTranslator translator)
		{
		}

		// Token: 0x060027DE RID: 10206 RVA: 0x0000F030 File Offset: 0x0000D230
		[Token(Token = "0x60027DE")]
		[Address(RVA = "0x26B00A4", Offset = "0x26B00A4", VA = "0x26B00A4")]
		private static bool objectCheck(IntPtr L, int idx)
		{
			return default(bool);
		}

		// Token: 0x060027DF RID: 10207 RVA: 0x0000F048 File Offset: 0x0000D248
		[Token(Token = "0x60027DF")]
		[Address(RVA = "0x26B00AC", Offset = "0x26B00AC", VA = "0x26B00AC")]
		private bool luaTableCheck(IntPtr L, int idx)
		{
			return default(bool);
		}

		// Token: 0x060027E0 RID: 10208 RVA: 0x0000F060 File Offset: 0x0000D260
		[Token(Token = "0x60027E0")]
		[Address(RVA = "0x26B0258", Offset = "0x26B0258", VA = "0x26B0258")]
		private bool numberCheck(IntPtr L, int idx)
		{
			return default(bool);
		}

		// Token: 0x060027E1 RID: 10209 RVA: 0x0000F078 File Offset: 0x0000D278
		[Token(Token = "0x60027E1")]
		[Address(RVA = "0x26B02CC", Offset = "0x26B02CC", VA = "0x26B02CC")]
		private bool decimalCheck(IntPtr L, int idx)
		{
			return default(bool);
		}

		// Token: 0x060027E2 RID: 10210 RVA: 0x0000F090 File Offset: 0x0000D290
		[Token(Token = "0x60027E2")]
		[Address(RVA = "0x26B03FC", Offset = "0x26B03FC", VA = "0x26B03FC")]
		private bool strCheck(IntPtr L, int idx)
		{
			return default(bool);
		}

		// Token: 0x060027E3 RID: 10211 RVA: 0x0000F0A8 File Offset: 0x0000D2A8
		[Token(Token = "0x60027E3")]
		[Address(RVA = "0x26B04A0", Offset = "0x26B04A0", VA = "0x26B04A0")]
		private bool bytesCheck(IntPtr L, int idx)
		{
			return default(bool);
		}

		// Token: 0x060027E4 RID: 10212 RVA: 0x0000F0C0 File Offset: 0x0000D2C0
		[Token(Token = "0x60027E4")]
		[Address(RVA = "0x26B05B0", Offset = "0x26B05B0", VA = "0x26B05B0")]
		private bool boolCheck(IntPtr L, int idx)
		{
			return default(bool);
		}

		// Token: 0x060027E5 RID: 10213 RVA: 0x0000F0D8 File Offset: 0x0000D2D8
		[Token(Token = "0x60027E5")]
		[Address(RVA = "0x26B0624", Offset = "0x26B0624", VA = "0x26B0624")]
		private bool int64Check(IntPtr L, int idx)
		{
			return default(bool);
		}

		// Token: 0x060027E6 RID: 10214 RVA: 0x0000F0F0 File Offset: 0x0000D2F0
		[Token(Token = "0x60027E6")]
		[Address(RVA = "0x26B06C8", Offset = "0x26B06C8", VA = "0x26B06C8")]
		private bool uint64Check(IntPtr L, int idx)
		{
			return default(bool);
		}

		// Token: 0x060027E7 RID: 10215 RVA: 0x0000F108 File Offset: 0x0000D308
		[Token(Token = "0x60027E7")]
		[Address(RVA = "0x26B076C", Offset = "0x26B076C", VA = "0x26B076C")]
		private bool luaFunctionCheck(IntPtr L, int idx)
		{
			return default(bool);
		}

		// Token: 0x060027E8 RID: 10216 RVA: 0x0000F120 File Offset: 0x0000D320
		[Token(Token = "0x60027E8")]
		[Address(RVA = "0x26B0898", Offset = "0x26B0898", VA = "0x26B0898")]
		private bool intptrCheck(IntPtr L, int idx)
		{
			return default(bool);
		}

		// Token: 0x060027E9 RID: 10217 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027E9")]
		[Address(RVA = "0x26B090C", Offset = "0x26B090C", VA = "0x26B090C")]
		private ObjectCheck genChecker(Type type)
		{
			return null;
		}

		// Token: 0x060027EA RID: 10218 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027EA")]
		[Address(RVA = "0x26B0C90", Offset = "0x26B0C90", VA = "0x26B0C90")]
		public ObjectCheck genNullableChecker(ObjectCheck oc)
		{
			return null;
		}

		// Token: 0x060027EB RID: 10219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027EB")]
		[Address(RVA = "0x26B0D4C", Offset = "0x26B0D4C", VA = "0x26B0D4C")]
		public void AddChecker(Type type, ObjectCheck oc)
		{
		}

		// Token: 0x060027EC RID: 10220 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027EC")]
		[Address(RVA = "0x26AB19C", Offset = "0x26AB19C", VA = "0x26AB19C")]
		public ObjectCheck GetChecker(Type type)
		{
			return null;
		}

		// Token: 0x040023AE RID: 9134
		[Token(Token = "0x40023AE")]
		[FieldOffset(Offset = "0x10")]
		private Dictionary<Type, ObjectCheck> checkersMap;

		// Token: 0x040023AF RID: 9135
		[Token(Token = "0x40023AF")]
		[FieldOffset(Offset = "0x18")]
		private ObjectTranslator translator;
	}
}
