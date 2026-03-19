using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace LuaPerfect
{
	// Token: 0x020003B1 RID: 945
	[Token(Token = "0x20003B1")]
	public class ObjectCache
	{
		// Token: 0x060017D3 RID: 6099 RVA: 0x00008D30 File Offset: 0x00006F30
		[Token(Token = "0x60017D3")]
		[Address(RVA = "0x1DBA35C", Offset = "0x1DBA35C", VA = "0x1DBA35C")]
		public static int SaveObject(object obj)
		{
			return 0;
		}

		// Token: 0x060017D4 RID: 6100 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017D4")]
		[Address(RVA = "0x1DBA4DC", Offset = "0x1DBA4DC", VA = "0x1DBA4DC")]
		public static object GetObject(int objectID)
		{
			return null;
		}

		// Token: 0x060017D5 RID: 6101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017D5")]
		[Address(RVA = "0x1DBA21C", Offset = "0x1DBA21C", VA = "0x1DBA21C")]
		public static void ClearAll()
		{
		}

		// Token: 0x060017D6 RID: 6102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017D6")]
		[Address(RVA = "0x1DBA5A8", Offset = "0x1DBA5A8", VA = "0x1DBA5A8")]
		public ObjectCache()
		{
		}

		// Token: 0x04001A96 RID: 6806
		[Token(Token = "0x4001A96")]
		[FieldOffset(Offset = "0x0")]
		public static List<object> s_objectList;

		// Token: 0x04001A97 RID: 6807
		[Token(Token = "0x4001A97")]
		[FieldOffset(Offset = "0x8")]
		public static Dictionary<object, int> s_objectDirectionary;
	}
}
