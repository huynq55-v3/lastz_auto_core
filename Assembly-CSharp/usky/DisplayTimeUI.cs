using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace usky
{
	// Token: 0x02000A06 RID: 2566
	[Token(Token = "0x2000A06")]
	[AddComponentMenu("uSkyPro/Other/Display Time UI")]
	public class DisplayTimeUI : MonoBehaviour
	{
		// Token: 0x17000645 RID: 1605
		// (get) Token: 0x06006207 RID: 25095 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000645")]
		private uSkyTimeline uST
		{
			[Token(Token = "0x6006207")]
			[Address(RVA = "0x302FDD0", Offset = "0x302FDD0", VA = "0x302FDD0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006208 RID: 25096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006208")]
		[Address(RVA = "0x302FE10", Offset = "0x302FE10", VA = "0x302FE10")]
		private void Update()
		{
		}

		// Token: 0x06006209 RID: 25097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006209")]
		[Address(RVA = "0x3030048", Offset = "0x3030048", VA = "0x3030048")]
		public DisplayTimeUI()
		{
		}

		// Token: 0x0400264C RID: 9804
		[Token(Token = "0x400264C")]
		[FieldOffset(Offset = "0x18")]
		public Text DisplayTimeText;
	}
}
