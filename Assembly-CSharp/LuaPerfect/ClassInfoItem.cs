using System;
using System.Collections.Generic;
using System.Reflection;
using Il2CppDummyDll;

namespace LuaPerfect
{
	// Token: 0x020003B4 RID: 948
	[Token(Token = "0x20003B4")]
	public class ClassInfoItem
	{
		// Token: 0x060017E5 RID: 6117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017E5")]
		[Address(RVA = "0x1DBAACC", Offset = "0x1DBAACC", VA = "0x1DBAACC")]
		public ClassInfoItem()
		{
		}

		// Token: 0x04001A9C RID: 6812
		[Token(Token = "0x4001A9C")]
		[FieldOffset(Offset = "0x10")]
		public string fullName;

		// Token: 0x04001A9D RID: 6813
		[Token(Token = "0x4001A9D")]
		[FieldOffset(Offset = "0x18")]
		public string fullName2;

		// Token: 0x04001A9E RID: 6814
		[Token(Token = "0x4001A9E")]
		[FieldOffset(Offset = "0x20")]
		public List<FieldInfo> fields;

		// Token: 0x04001A9F RID: 6815
		[Token(Token = "0x4001A9F")]
		[FieldOffset(Offset = "0x28")]
		public List<PropertyInfo> properties;
	}
}
