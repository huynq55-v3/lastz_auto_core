using System;
using Il2CppDummyDll;
using UnityEngine;

namespace EPOOutline
{
	// Token: 0x02000C8B RID: 3211
	[Token(Token = "0x2000C8B")]
	[ExecuteAlways]
	public class OnPreRenderEventTransferer : MonoBehaviour
	{
		// Token: 0x060079FD RID: 31229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079FD")]
		[Address(RVA = "0x1495EB4", Offset = "0x1495EB4", VA = "0x1495EB4")]
		private void Awake()
		{
		}

		// Token: 0x060079FE RID: 31230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079FE")]
		[Address(RVA = "0x1495F0C", Offset = "0x1495F0C", VA = "0x1495F0C")]
		private void OnPreRender()
		{
		}

		// Token: 0x060079FF RID: 31231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079FF")]
		[Address(RVA = "0x1495F2C", Offset = "0x1495F2C", VA = "0x1495F2C")]
		public OnPreRenderEventTransferer()
		{
		}

		// Token: 0x04003522 RID: 13602
		[Token(Token = "0x4003522")]
		[FieldOffset(Offset = "0x18")]
		private Camera attachedCamera;

		// Token: 0x04003523 RID: 13603
		[Token(Token = "0x4003523")]
		[FieldOffset(Offset = "0x20")]
		public Action<Camera> OnPreRenderEvent;
	}
}
