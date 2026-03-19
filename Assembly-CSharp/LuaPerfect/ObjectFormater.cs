using System;
using System.Collections.Generic;
using System.Reflection;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace LuaPerfect
{
	// Token: 0x020003B5 RID: 949
	[Token(Token = "0x20003B5")]
	[LuaCallCSharp(GenFlag.No)]
	public class ObjectFormater
	{
		// Token: 0x060017E6 RID: 6118 RVA: 0x00008D78 File Offset: 0x00006F78
		[Token(Token = "0x60017E6")]
		[Address(RVA = "0x1DBAAD4", Offset = "0x1DBAAD4", VA = "0x1DBAAD4")]
		public static bool IsBasicType(Type type)
		{
			return default(bool);
		}

		// Token: 0x060017E7 RID: 6119 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017E7")]
		[Address(RVA = "0x1DBAFA8", Offset = "0x1DBAFA8", VA = "0x1DBAFA8")]
		public static List<FieldInfo> GetAllFields(Type type)
		{
			return null;
		}

		// Token: 0x060017E8 RID: 6120 RVA: 0x00008D90 File Offset: 0x00006F90
		[Token(Token = "0x60017E8")]
		[Address(RVA = "0x1DBB148", Offset = "0x1DBB148", VA = "0x1DBB148")]
		public static bool FindProperty(List<PropertyInfo> allProperties, string name)
		{
			return default(bool);
		}

		// Token: 0x060017E9 RID: 6121 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017E9")]
		[Address(RVA = "0x1DBB350", Offset = "0x1DBB350", VA = "0x1DBB350")]
		public static List<PropertyInfo> GetAllProperties(Type type)
		{
			return null;
		}

		// Token: 0x060017EA RID: 6122 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017EA")]
		[Address(RVA = "0x1DBB564", Offset = "0x1DBB564", VA = "0x1DBB564")]
		public static string GetClassFullName(Type type)
		{
			return null;
		}

		// Token: 0x060017EB RID: 6123 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017EB")]
		[Address(RVA = "0x1DBB638", Offset = "0x1DBB638", VA = "0x1DBB638")]
		public static ClassInfoItem GetClassInfo(Type type)
		{
			return null;
		}

		// Token: 0x060017EC RID: 6124 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017EC")]
		[Address(RVA = "0x1DBB7DC", Offset = "0x1DBB7DC", VA = "0x1DBB7DC")]
		public static List<GameObject> GetChildrenGameObjects(GameObject gameObject)
		{
			return null;
		}

		// Token: 0x060017ED RID: 6125 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017ED")]
		[Address(RVA = "0x1DBBBEC", Offset = "0x1DBBBEC", VA = "0x1DBBBEC")]
		public static ObjectItem FormatObject(object obj, bool collectChildren)
		{
			return null;
		}

		// Token: 0x060017EE RID: 6126 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017EE")]
		[Address(RVA = "0x1DBBDF8", Offset = "0x1DBBDF8", VA = "0x1DBBDF8")]
		public static ObjectItem InnerFormatObject(object obj, bool collectChildren)
		{
			return null;
		}

		// Token: 0x060017EF RID: 6127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017EF")]
		[Address(RVA = "0x1DBD1AC", Offset = "0x1DBD1AC", VA = "0x1DBD1AC")]
		public static void ClearObjectCache()
		{
		}

		// Token: 0x060017F0 RID: 6128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017F0")]
		[Address(RVA = "0x1DBD1F8", Offset = "0x1DBD1F8", VA = "0x1DBD1F8")]
		public ObjectFormater()
		{
		}

		// Token: 0x04001AA0 RID: 6816
		[Token(Token = "0x4001AA0")]
		[FieldOffset(Offset = "0x0")]
		public static Dictionary<Type, ClassInfoItem> s_classInfoDirectionary;
	}
}
