using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace LuaPerfect
{
	// Token: 0x020003B3 RID: 947
	[Token(Token = "0x20003B3")]
	[LuaCallCSharp(GenFlag.No)]
	public class ObjectItem
	{
		// Token: 0x060017D8 RID: 6104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017D8")]
		[Address(RVA = "0x1DBA5D8", Offset = "0x1DBA5D8", VA = "0x1DBA5D8")]
		public ObjectItem()
		{
		}

		// Token: 0x060017D9 RID: 6105 RVA: 0x00008D48 File Offset: 0x00006F48
		[Token(Token = "0x60017D9")]
		[Address(RVA = "0x1DBA6B0", Offset = "0x1DBA6B0", VA = "0x1DBA6B0")]
		public int GetChildCount()
		{
			return 0;
		}

		// Token: 0x060017DA RID: 6106 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017DA")]
		[Address(RVA = "0x1DBA6F8", Offset = "0x1DBA6F8", VA = "0x1DBA6F8")]
		public string GetChildName(int i)
		{
			return null;
		}

		// Token: 0x060017DB RID: 6107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017DB")]
		[Address(RVA = "0x1DBA750", Offset = "0x1DBA750", VA = "0x1DBA750")]
		public void SetValue(string value)
		{
		}

		// Token: 0x060017DC RID: 6108 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017DC")]
		[Address(RVA = "0x1DBA758", Offset = "0x1DBA758", VA = "0x1DBA758")]
		public string GetValue()
		{
			return null;
		}

		// Token: 0x060017DD RID: 6109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017DD")]
		[Address(RVA = "0x1DBA760", Offset = "0x1DBA760", VA = "0x1DBA760")]
		public void AddChild(string name, object obj)
		{
		}

		// Token: 0x060017DE RID: 6110 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017DE")]
		[Address(RVA = "0x1DBA900", Offset = "0x1DBA900", VA = "0x1DBA900")]
		public ObjectRef GetChildObject(int i)
		{
			return null;
		}

		// Token: 0x060017DF RID: 6111 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017DF")]
		[Address(RVA = "0x1DBA958", Offset = "0x1DBA958", VA = "0x1DBA958")]
		public ObjectRef GetChildObjectByName(string name)
		{
			return null;
		}

		// Token: 0x060017E0 RID: 6112 RVA: 0x00008D60 File Offset: 0x00006F60
		[Token(Token = "0x60017E0")]
		[Address(RVA = "0x1DBAA74", Offset = "0x1DBAA74", VA = "0x1DBAA74")]
		public static int StaticGetChildCount(ObjectItem objectItem)
		{
			return 0;
		}

		// Token: 0x060017E1 RID: 6113 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017E1")]
		[Address(RVA = "0x1DBAA84", Offset = "0x1DBAA84", VA = "0x1DBAA84")]
		public static string StaticGetValue(ObjectItem objectItem)
		{
			return null;
		}

		// Token: 0x060017E2 RID: 6114 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017E2")]
		[Address(RVA = "0x1DBAA9C", Offset = "0x1DBAA9C", VA = "0x1DBAA9C")]
		public static string StaticGetChildName(ObjectItem objectItem, int i)
		{
			return null;
		}

		// Token: 0x060017E3 RID: 6115 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017E3")]
		[Address(RVA = "0x1DBAAAC", Offset = "0x1DBAAAC", VA = "0x1DBAAAC")]
		public static ObjectRef StaticGetChildObject(ObjectItem objectItem, int i)
		{
			return null;
		}

		// Token: 0x060017E4 RID: 6116 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017E4")]
		[Address(RVA = "0x1DBAABC", Offset = "0x1DBAABC", VA = "0x1DBAABC")]
		public static ObjectRef StaticGetChildObjectByName(ObjectItem objectItem, string name)
		{
			return null;
		}

		// Token: 0x04001A99 RID: 6809
		[Token(Token = "0x4001A99")]
		[FieldOffset(Offset = "0x10")]
		private string value;

		// Token: 0x04001A9A RID: 6810
		[Token(Token = "0x4001A9A")]
		[FieldOffset(Offset = "0x18")]
		private List<string> childNameList;

		// Token: 0x04001A9B RID: 6811
		[Token(Token = "0x4001A9B")]
		[FieldOffset(Offset = "0x20")]
		public List<ObjectRef> childObjectRefList;
	}
}
