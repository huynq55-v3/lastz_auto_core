using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace RealisticEyeMovements
{
	// Token: 0x02000C81 RID: 3201
	[Token(Token = "0x2000C81")]
	[DefaultExecutionOrder(999999)]
	public class VeryLateUpdateCallback : MonoBehaviour
	{
		// Token: 0x14000023 RID: 35
		// (add) Token: 0x060079BF RID: 31167 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x060079C0 RID: 31168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000023")]
		public event Action onVeryLateUpdate
		{
			[Token(Token = "0x60079BF")]
			[Address(RVA = "0x148FBD0", Offset = "0x148FBD0", VA = "0x148FBD0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60079C0")]
			[Address(RVA = "0x148FC6C", Offset = "0x148FC6C", VA = "0x148FC6C")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x060079C1 RID: 31169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079C1")]
		[Address(RVA = "0x148FD08", Offset = "0x148FD08", VA = "0x148FD08")]
		private void Start()
		{
		}

		// Token: 0x060079C2 RID: 31170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079C2")]
		[Address(RVA = "0x148FD14", Offset = "0x148FD14", VA = "0x148FD14")]
		private void LateUpdate()
		{
		}

		// Token: 0x060079C3 RID: 31171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079C3")]
		[Address(RVA = "0x148FD30", Offset = "0x148FD30", VA = "0x148FD30")]
		public VeryLateUpdateCallback()
		{
		}
	}
}
