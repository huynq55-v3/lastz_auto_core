using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace usky
{
	// Token: 0x02000A04 RID: 2564
	[Token(Token = "0x2000A04")]
	[AddComponentMenu("uSkyPro/Other/Demo GUI")]
	public class DemoGUI : MonoBehaviour
	{
		// Token: 0x060061FE RID: 25086 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60061FE")]
		[Address(RVA = "0x302F8CC", Offset = "0x302F8CC", VA = "0x302F8CC")]
		private IEnumerator Start()
		{
			return null;
		}

		// Token: 0x060061FF RID: 25087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061FF")]
		[Address(RVA = "0x302F968", Offset = "0x302F968", VA = "0x302F968")]
		private void Update()
		{
		}

		// Token: 0x06006200 RID: 25088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006200")]
		[Address(RVA = "0x302FB60", Offset = "0x302FB60", VA = "0x302FB60")]
		public DemoGUI()
		{
		}

		// Token: 0x04002645 RID: 9797
		[Token(Token = "0x4002645")]
		[FieldOffset(Offset = "0x18")]
		public Text AltitudeText;

		// Token: 0x04002646 RID: 9798
		[Token(Token = "0x4002646")]
		[FieldOffset(Offset = "0x20")]
		public Transform PlayerCamera;

		// Token: 0x04002647 RID: 9799
		[Token(Token = "0x4002647")]
		[FieldOffset(Offset = "0x28")]
		public Image controlInfo;
	}
}
