using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Scripting;

namespace Mopsicus.Plugins
{
	// Token: 0x020004A6 RID: 1190
	[Token(Token = "0x20004A6")]
	[Preserve]
	public class Plugins : MonoBehaviour
	{
		// Token: 0x0600231A RID: 8986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600231A")]
		[Address(RVA = "0x29FF6B4", Offset = "0x29FF6B4", VA = "0x29FF6B4")]
		private void Awake()
		{
		}

		// Token: 0x0600231B RID: 8987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600231B")]
		[Address(RVA = "0x29FF9F8", Offset = "0x29FF9F8", VA = "0x29FF9F8")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600231C RID: 8988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600231C")]
		[Address(RVA = "0x29FF754", Offset = "0x29FF754", VA = "0x29FF754")]
		private void InitPlugins()
		{
		}

		// Token: 0x0600231D RID: 8989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600231D")]
		[Address(RVA = "0x29FFA04", Offset = "0x29FFA04", VA = "0x29FFA04")]
		private void OnDataReceive(string data)
		{
		}

		// Token: 0x0600231E RID: 8990 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600231E")]
		[Address(RVA = "0x29FFE9C", Offset = "0x29FFE9C", VA = "0x29FFE9C")]
		public Plugins()
		{
		}

		// Token: 0x0400208D RID: 8333
		[Token(Token = "0x400208D")]
		public const string ANDROID_CLASS_MASK = "ru.mopsicus.{0}.Plugin";

		// Token: 0x0400208E RID: 8334
		[Token(Token = "0x400208E")]
		private const string _dataObject = "Plugins";

		// Token: 0x0400208F RID: 8335
		[Token(Token = "0x400208F")]
		private const string _dataReceiver = "OnDataReceive";

		// Token: 0x04002090 RID: 8336
		[Token(Token = "0x4002090")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<string, IPlugin> _plugins;
	}
}
