using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BitBenderGames
{
	// Token: 0x02000AB0 RID: 2736
	[Token(Token = "0x2000AB0")]
	[RequireComponent(typeof(MobileTouchCamera))]
	public class SetBoundaryFromCollider : MonoBehaviour
	{
		// Token: 0x0600685B RID: 26715 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600685B")]
		[Address(RVA = "0x33CE6B8", Offset = "0x33CE6B8", VA = "0x33CE6B8")]
		public void Start()
		{
		}

		// Token: 0x0600685C RID: 26716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600685C")]
		[Address(RVA = "0x33CE7FC", Offset = "0x33CE7FC", VA = "0x33CE7FC")]
		public SetBoundaryFromCollider()
		{
		}

		// Token: 0x040029EA RID: 10730
		[Token(Token = "0x40029EA")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private BoxCollider boxCollider;
	}
}
