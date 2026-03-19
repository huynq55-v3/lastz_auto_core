using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.IL2CPP.CompilerServices;
using UnityEngine.Scripting;

namespace XLua
{
	// Token: 0x0200052B RID: 1323
	[Token(Token = "0x200052B")]
	[Il2CppSetOption(Option.NullChecks, false)]
	[Preserve]
	public class OverloadMethodWrap
	{
		// Token: 0x170005E9 RID: 1513
		// (get) Token: 0x060027BD RID: 10173 RVA: 0x0000EF70 File Offset: 0x0000D170
		// (set) Token: 0x060027BE RID: 10174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005E9")]
		public bool HasDefalutValue
		{
			[Token(Token = "0x60027BD")]
			[Address(RVA = "0x26AA118", Offset = "0x26AA118", VA = "0x26AA118")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60027BE")]
			[Address(RVA = "0x26AA120", Offset = "0x26AA120", VA = "0x26AA120")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060027BF RID: 10175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027BF")]
		[Address(RVA = "0x26AA12C", Offset = "0x26AA12C", VA = "0x26AA12C")]
		public OverloadMethodWrap(ObjectTranslator translator, Type targetType, MethodBase method)
		{
		}

		// Token: 0x060027C0 RID: 10176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027C0")]
		[Address(RVA = "0x26AA1A0", Offset = "0x26AA1A0", VA = "0x26AA1A0")]
		public void Init(ObjectCheckers objCheckers, ObjectCasters objCasters)
		{
		}

		// Token: 0x060027C1 RID: 10177 RVA: 0x0000EF88 File Offset: 0x0000D188
		[Token(Token = "0x60027C1")]
		[Address(RVA = "0x26AB420", Offset = "0x26AB420", VA = "0x26AB420")]
		public bool Check(IntPtr L)
		{
			return default(bool);
		}

		// Token: 0x060027C2 RID: 10178 RVA: 0x0000EFA0 File Offset: 0x0000D1A0
		[Token(Token = "0x60027C2")]
		[Address(RVA = "0x26AB624", Offset = "0x26AB624", VA = "0x26AB624")]
		public int Call(IntPtr L)
		{
			return 0;
		}

		// Token: 0x0400237E RID: 9086
		[Token(Token = "0x400237E")]
		[FieldOffset(Offset = "0x0")]
		private static int[] EmptyIntArray;

		// Token: 0x0400237F RID: 9087
		[Token(Token = "0x400237F")]
		[FieldOffset(Offset = "0x8")]
		private static ObjectCheck[] EmptyObjectCheckArray;

		// Token: 0x04002380 RID: 9088
		[Token(Token = "0x4002380")]
		[FieldOffset(Offset = "0x10")]
		private static ObjectCast[] EmptyObjectCastArray;

		// Token: 0x04002381 RID: 9089
		[Token(Token = "0x4002381")]
		[FieldOffset(Offset = "0x18")]
		private static bool[] EmptyBoolArray;

		// Token: 0x04002382 RID: 9090
		[Token(Token = "0x4002382")]
		[FieldOffset(Offset = "0x20")]
		private static object[] EmptyObjectArray;

		// Token: 0x04002383 RID: 9091
		[Token(Token = "0x4002383")]
		[FieldOffset(Offset = "0x28")]
		private static List<int> inPosList;

		// Token: 0x04002384 RID: 9092
		[Token(Token = "0x4002384")]
		[FieldOffset(Offset = "0x30")]
		private static List<int> outPosList;

		// Token: 0x04002385 RID: 9093
		[Token(Token = "0x4002385")]
		[FieldOffset(Offset = "0x38")]
		private static List<ObjectCheck> paramsChecks;

		// Token: 0x04002386 RID: 9094
		[Token(Token = "0x4002386")]
		[FieldOffset(Offset = "0x40")]
		private static List<ObjectCast> paramsCasts;

		// Token: 0x04002387 RID: 9095
		[Token(Token = "0x4002387")]
		[FieldOffset(Offset = "0x48")]
		private static List<bool> isOptionalList;

		// Token: 0x04002388 RID: 9096
		[Token(Token = "0x4002388")]
		[FieldOffset(Offset = "0x50")]
		private static List<object> defaultValueList;

		// Token: 0x04002389 RID: 9097
		[Token(Token = "0x4002389")]
		[FieldOffset(Offset = "0x10")]
		private ObjectTranslator translator;

		// Token: 0x0400238A RID: 9098
		[Token(Token = "0x400238A")]
		[FieldOffset(Offset = "0x18")]
		private Type targetType;

		// Token: 0x0400238B RID: 9099
		[Token(Token = "0x400238B")]
		[FieldOffset(Offset = "0x20")]
		private MethodBase method;

		// Token: 0x0400238C RID: 9100
		[Token(Token = "0x400238C")]
		[FieldOffset(Offset = "0x28")]
		private ObjectCheck[] checkArray;

		// Token: 0x0400238D RID: 9101
		[Token(Token = "0x400238D")]
		[FieldOffset(Offset = "0x30")]
		private ObjectCast[] castArray;

		// Token: 0x0400238E RID: 9102
		[Token(Token = "0x400238E")]
		[FieldOffset(Offset = "0x38")]
		private int[] inPosArray;

		// Token: 0x0400238F RID: 9103
		[Token(Token = "0x400238F")]
		[FieldOffset(Offset = "0x40")]
		private int[] outPosArray;

		// Token: 0x04002390 RID: 9104
		[Token(Token = "0x4002390")]
		[FieldOffset(Offset = "0x48")]
		private bool[] isOptionalArray;

		// Token: 0x04002391 RID: 9105
		[Token(Token = "0x4002391")]
		[FieldOffset(Offset = "0x50")]
		private object[] defaultValueArray;

		// Token: 0x04002392 RID: 9106
		[Token(Token = "0x4002392")]
		[FieldOffset(Offset = "0x58")]
		private bool isVoid;

		// Token: 0x04002393 RID: 9107
		[Token(Token = "0x4002393")]
		[FieldOffset(Offset = "0x5C")]
		private int luaStackPosStart;

		// Token: 0x04002394 RID: 9108
		[Token(Token = "0x4002394")]
		[FieldOffset(Offset = "0x60")]
		private bool targetNeeded;

		// Token: 0x04002395 RID: 9109
		[Token(Token = "0x4002395")]
		[FieldOffset(Offset = "0x68")]
		private object[] args;

		// Token: 0x04002396 RID: 9110
		[Token(Token = "0x4002396")]
		[FieldOffset(Offset = "0x70")]
		private int[] refPos;

		// Token: 0x04002397 RID: 9111
		[Token(Token = "0x4002397")]
		[FieldOffset(Offset = "0x78")]
		private Type paramsType;
	}
}
