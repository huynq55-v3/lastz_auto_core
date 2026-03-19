using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000062 RID: 98
[Token(Token = "0x2000062")]
[CreateAssetMenu(fileName = "SkySeasonConfigManager", menuName = "uSkyPro/Sky Season Config Manager")]
public class SkySeasonConfigManager : ScriptableObject
{
	// Token: 0x06000229 RID: 553 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000229")]
	[Address(RVA = "0x3203AC8", Offset = "0x3203AC8", VA = "0x3203AC8")]
	private void OnEnable()
	{
	}

	// Token: 0x0600022A RID: 554 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600022A")]
	[Address(RVA = "0x3203ACC", Offset = "0x3203ACC", VA = "0x3203ACC")]
	private void InitializeDict()
	{
	}

	// Token: 0x0600022B RID: 555 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600022B")]
	[Address(RVA = "0x3203CF8", Offset = "0x3203CF8", VA = "0x3203CF8")]
	public SkySeasonConfig GetConfig(string seasonId)
	{
		return null;
	}

	// Token: 0x0600022C RID: 556 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600022C")]
	[Address(RVA = "0x3203DF8", Offset = "0x3203DF8", VA = "0x3203DF8")]
	private static string GetBaseSeasonId(string seasonId)
	{
		return null;
	}

	// Token: 0x0600022D RID: 557 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600022D")]
	[Address(RVA = "0x3203E40", Offset = "0x3203E40", VA = "0x3203E40")]
	public SkySeasonConfig GetDefaultConfig()
	{
		return null;
	}

	// Token: 0x0600022E RID: 558 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600022E")]
	[Address(RVA = "0x3203E48", Offset = "0x3203E48", VA = "0x3203E48")]
	public SkySeasonConfigManager()
	{
	}

	// Token: 0x040001F5 RID: 501
	[Token(Token = "0x40001F5")]
	[FieldOffset(Offset = "0x18")]
	[Header("默认配置（游戏启动时使用）")]
	[SerializeField]
	private SkySeasonConfig defaultConfig;

	// Token: 0x040001F6 RID: 502
	[Token(Token = "0x40001F6")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Header("赛季配置列表")]
	private List<SkySeasonConfigManager.SeasonConfigEntry> seasonConfigs;

	// Token: 0x040001F7 RID: 503
	[Token(Token = "0x40001F7")]
	[FieldOffset(Offset = "0x28")]
	private Dictionary<string, SkySeasonConfig> m_configDict;

	// Token: 0x02000063 RID: 99
	[Token(Token = "0x2000063")]
	[Serializable]
	public class SeasonConfigEntry
	{
		// Token: 0x0600022F RID: 559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600022F")]
		[Address(RVA = "0x3203ED0", Offset = "0x3203ED0", VA = "0x3203ED0")]
		public SeasonConfigEntry()
		{
		}

		// Token: 0x040001F8 RID: 504
		[Token(Token = "0x40001F8")]
		[FieldOffset(Offset = "0x10")]
		public string seasonId;

		// Token: 0x040001F9 RID: 505
		[Token(Token = "0x40001F9")]
		[FieldOffset(Offset = "0x18")]
		public SkySeasonConfig config;
	}
}
