using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace RealisticEyeMovements
{
	// Token: 0x02000C74 RID: 3188
	[Token(Token = "0x2000C74")]
	[DefaultExecutionOrder(-999999)]
	public class EarlyUpdateCallback : MonoBehaviour
	{
		// Token: 0x14000022 RID: 34
		// (add) Token: 0x06007962 RID: 31074 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06007963 RID: 31075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000022")]
		public event Action onEarlyUpdate
		{
			[Token(Token = "0x6007962")]
			[Address(RVA = "0x14872B8", Offset = "0x14872B8", VA = "0x14872B8")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6007963")]
			[Address(RVA = "0x1487354", Offset = "0x1487354", VA = "0x1487354")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06007964 RID: 31076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007964")]
		[Address(RVA = "0x14873F0", Offset = "0x14873F0", VA = "0x14873F0")]
		private void Start()
		{
		}

		// Token: 0x06007965 RID: 31077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007965")]
		[Address(RVA = "0x14873FC", Offset = "0x14873FC", VA = "0x14873FC")]
		private void Update()
		{
		}

		// Token: 0x06007966 RID: 31078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007966")]
		[Address(RVA = "0x1487418", Offset = "0x1487418", VA = "0x1487418")]
		public EarlyUpdateCallback()
		{
		}
	}
}
