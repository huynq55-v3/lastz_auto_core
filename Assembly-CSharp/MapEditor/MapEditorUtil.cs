using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace MapEditor
{
	// Token: 0x02000CF9 RID: 3321
	[Token(Token = "0x2000CF9")]
	public static class MapEditorUtil
	{
		// Token: 0x06007C6D RID: 31853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C6D")]
		[Address(RVA = "0x319C1D4", Offset = "0x319C1D4", VA = "0x319C1D4")]
		public static void InitXLua()
		{
		}

		// Token: 0x06007C6E RID: 31854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C6E")]
		[Address(RVA = "0x319C4F4", Offset = "0x319C4F4", VA = "0x319C4F4")]
		public static void EndXLua()
		{
		}

		// Token: 0x06007C6F RID: 31855 RVA: 0x000548D0 File Offset: 0x00052AD0
		[Token(Token = "0x6007C6F")]
		[Address(RVA = "0x319C564", Offset = "0x319C564", VA = "0x319C564")]
		private static LuaEnv.LuaFileInfo CustomLoader(ref string filepath)
		{
			return default(LuaEnv.LuaFileInfo);
		}

		// Token: 0x06007C70 RID: 31856 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007C70")]
		[Address(RVA = "0x319C7B8", Offset = "0x319C7B8", VA = "0x319C7B8")]
		public static string GetBuildAttrFromCfg(int buildId, string key)
		{
			return null;
		}

		// Token: 0x06007C71 RID: 31857 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007C71")]
		[Address(RVA = "0x319C8FC", Offset = "0x319C8FC", VA = "0x319C8FC")]
		public static string GetCfgForLua(string tableName, int id, string key)
		{
			return null;
		}

		// Token: 0x06007C72 RID: 31858 RVA: 0x000548E8 File Offset: 0x00052AE8
		[Token(Token = "0x6007C72")]
		[Address(RVA = "0x319CA50", Offset = "0x319CA50", VA = "0x319CA50")]
		public static int GetTileFromCfg(int buildId)
		{
			return 0;
		}

		// Token: 0x06007C73 RID: 31859 RVA: 0x00054900 File Offset: 0x00052B00
		[Token(Token = "0x6007C73")]
		[Address(RVA = "0x319CADC", Offset = "0x319CADC", VA = "0x319CADC")]
		public static bool GetOverlapAttribute(int buildId)
		{
			return default(bool);
		}

		// Token: 0x06007C74 RID: 31860 RVA: 0x00054918 File Offset: 0x00052B18
		[Token(Token = "0x6007C74")]
		[Address(RVA = "0x319CB68", Offset = "0x319CB68", VA = "0x319CB68")]
		public static int GetBuildRightCornerPosIndex(Vector3 buildCenterPos, int buildId)
		{
			return 0;
		}

		// Token: 0x06007C75 RID: 31861 RVA: 0x00054930 File Offset: 0x00052B30
		[Token(Token = "0x6007C75")]
		[Address(RVA = "0x319CC10", Offset = "0x319CC10", VA = "0x319CC10")]
		public static float GetZombieChaseRange(int zombieId)
		{
			return 0f;
		}

		// Token: 0x06007C76 RID: 31862 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007C76")]
		[Address(RVA = "0x319CCB4", Offset = "0x319CCB4", VA = "0x319CCB4")]
		public static List<int> GetCfgIdsForLua(string tableName)
		{
			return null;
		}

		// Token: 0x04003869 RID: 14441
		[Token(Token = "0x4003869")]
		public const int kTileCountX = 80;

		// Token: 0x0400386A RID: 14442
		[Token(Token = "0x400386A")]
		public const int kTileCountY = 80;

		// Token: 0x0400386B RID: 14443
		[Token(Token = "0x400386B")]
		[FieldOffset(Offset = "0x0")]
		public static readonly Vector2Int TileCount;

		// Token: 0x0400386C RID: 14444
		[Token(Token = "0x400386C")]
		[FieldOffset(Offset = "0x8")]
		private static LuaEnv m_LuaEnv;

		// Token: 0x0400386D RID: 14445
		[Token(Token = "0x400386D")]
		[FieldOffset(Offset = "0x10")]
		private static readonly string[] LuaRootPathEditor;

		// Token: 0x0400386E RID: 14446
		[Token(Token = "0x400386E")]
		[FieldOffset(Offset = "0x18")]
		private static XLuaManager.GetBuildCfgForEditorDelegate _getBuildCfgDelegate;

		// Token: 0x0400386F RID: 14447
		[Token(Token = "0x400386F")]
		[FieldOffset(Offset = "0x20")]
		private static XLuaManager.GetCfgForEditorDelegate _getCfgDelegate;

		// Token: 0x04003870 RID: 14448
		[Token(Token = "0x4003870")]
		[FieldOffset(Offset = "0x28")]
		private static XLuaManager.GetCfgIdsForEditorDelegate _getCfgIdsDelegate;
	}
}
