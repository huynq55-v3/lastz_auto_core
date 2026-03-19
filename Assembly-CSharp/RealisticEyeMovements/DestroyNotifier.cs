using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace RealisticEyeMovements
{
	// Token: 0x02000C73 RID: 3187
	[Token(Token = "0x2000C73")]
	public class DestroyNotifier : MonoBehaviour
	{
		// Token: 0x14000021 RID: 33
		// (add) Token: 0x0600795E RID: 31070 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x0600795F RID: 31071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000021")]
		public event Action<DestroyNotifier> OnDestroyedEvent
		{
			[Token(Token = "0x600795E")]
			[Address(RVA = "0x1487130", Offset = "0x1487130", VA = "0x1487130")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600795F")]
			[Address(RVA = "0x14871E0", Offset = "0x14871E0", VA = "0x14871E0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06007960 RID: 31072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007960")]
		[Address(RVA = "0x1487290", Offset = "0x1487290", VA = "0x1487290")]
		private void OnDestroyed()
		{
		}

		// Token: 0x06007961 RID: 31073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007961")]
		[Address(RVA = "0x14872B0", Offset = "0x14872B0", VA = "0x14872B0")]
		public DestroyNotifier()
		{
		}
	}
}
