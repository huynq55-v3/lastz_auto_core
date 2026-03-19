using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace VEngine
{
	// Token: 0x020009F6 RID: 2550
	[Token(Token = "0x20009F6")]
	public class PlayerSettings : ScriptableObject
	{
		// Token: 0x06006185 RID: 24965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006185")]
		[Address(RVA = "0x1413334", Offset = "0x1413334", VA = "0x1413334")]
		public PlayerSettings()
		{
		}

		// Token: 0x040025F1 RID: 9713
		[Token(Token = "0x40025F1")]
		[FieldOffset(Offset = "0x18")]
		public List<string> assets;

		// Token: 0x040025F2 RID: 9714
		[Token(Token = "0x40025F2")]
		[FieldOffset(Offset = "0x20")]
		public List<string> whiteList;

		// Token: 0x040025F3 RID: 9715
		[Token(Token = "0x40025F3")]
		[FieldOffset(Offset = "0x28")]
		[Tooltip("初始化的清单配置，配置包外的清单，底层会自动按需更新下载")]
		public List<string> manifests;

		// Token: 0x040025F4 RID: 9716
		[Token(Token = "0x40025F4")]
		[FieldOffset(Offset = "0x30")]
		[Tooltip("后台更新的清单配置，游戏启动时不下载更新，在进入游戏后，在后台更新")]
		public string bkgroundManifest;

		// Token: 0x040025F5 RID: 9717
		[Token(Token = "0x40025F5")]
		[FieldOffset(Offset = "0x38")]
		[Tooltip("包内清单配置，资源不热更，随包更新")]
		public string packageResManifest;
	}
}
