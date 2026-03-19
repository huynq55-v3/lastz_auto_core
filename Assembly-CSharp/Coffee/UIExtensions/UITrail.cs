using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Coffee.UIExtensions
{
	// Token: 0x02000A4A RID: 2634
	[Token(Token = "0x2000A4A")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(RectTransform))]
	[RequireComponent(typeof(CanvasRenderer))]
	public class UITrail : MaskableGraphic
	{
		// Token: 0x060063BB RID: 25531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063BB")]
		[Address(RVA = "0x2DF3FE8", Offset = "0x2DF3FE8", VA = "0x2DF3FE8", Slot = "5")]
		protected override void OnEnable()
		{
		}

		// Token: 0x060063BC RID: 25532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063BC")]
		[Address(RVA = "0x2DF4148", Offset = "0x2DF4148", VA = "0x2DF4148", Slot = "7")]
		protected override void OnDisable()
		{
		}

		// Token: 0x060063BD RID: 25533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063BD")]
		[Address(RVA = "0x2DF41E8", Offset = "0x2DF41E8", VA = "0x2DF41E8", Slot = "40")]
		protected override void UpdateMaterial()
		{
		}

		// Token: 0x060063BE RID: 25534 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063BE")]
		[Address(RVA = "0x2DF2834", Offset = "0x2DF2834", VA = "0x2DF2834")]
		public void Refresh()
		{
		}

		// Token: 0x060063BF RID: 25535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063BF")]
		[Address(RVA = "0x2DF41EC", Offset = "0x2DF41EC", VA = "0x2DF41EC")]
		public UITrail()
		{
		}

		// Token: 0x04002835 RID: 10293
		[Token(Token = "0x4002835")]
		[FieldOffset(Offset = "0xD0")]
		private Mesh bakedMesh;

		// Token: 0x04002836 RID: 10294
		[Token(Token = "0x4002836")]
		[FieldOffset(Offset = "0xD8")]
		private Mesh resultMesh;

		// Token: 0x04002837 RID: 10295
		[Token(Token = "0x4002837")]
		[FieldOffset(Offset = "0xE0")]
		private TrailRenderer trailRenderer;

		// Token: 0x04002838 RID: 10296
		[Token(Token = "0x4002838")]
		[FieldOffset(Offset = "0xE8")]
		public Material mat;
	}
}
