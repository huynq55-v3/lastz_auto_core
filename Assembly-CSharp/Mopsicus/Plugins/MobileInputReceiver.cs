using System;
using Il2CppDummyDll;
using NiceJson;
using UnityEngine;

namespace Mopsicus.Plugins
{
	// Token: 0x0200049B RID: 1179
	[Token(Token = "0x200049B")]
	public abstract class MobileInputReceiver : MonoBehaviour
	{
		// Token: 0x060022C8 RID: 8904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022C8")]
		[Address(RVA = "0x29FA980", Offset = "0x29FA980", VA = "0x29FA980", Slot = "4")]
		protected virtual void Start()
		{
		}

		// Token: 0x060022C9 RID: 8905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022C9")]
		[Address(RVA = "0x29FAA7C", Offset = "0x29FAA7C", VA = "0x29FAA7C", Slot = "5")]
		protected virtual void OnDestroy()
		{
		}

		// Token: 0x060022CA RID: 8906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022CA")]
		[Address(RVA = "0x29FAB5C", Offset = "0x29FAB5C", VA = "0x29FAB5C")]
		protected void Execute(JsonObject data)
		{
		}

		// Token: 0x060022CB RID: 8907
		[Token(Token = "0x60022CB")]
		public abstract void Send(JsonObject data);

		// Token: 0x060022CC RID: 8908
		[Token(Token = "0x60022CC")]
		public abstract void Hide();

		// Token: 0x060022CD RID: 8909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022CD")]
		[Address(RVA = "0x29FAF28", Offset = "0x29FAF28", VA = "0x29FAF28")]
		protected MobileInputReceiver()
		{
		}

		// Token: 0x04002044 RID: 8260
		[Token(Token = "0x4002044")]
		[FieldOffset(Offset = "0x18")]
		private int _id;
	}
}
