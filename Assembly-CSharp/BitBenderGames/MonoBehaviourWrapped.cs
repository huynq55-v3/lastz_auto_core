using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BitBenderGames
{
	// Token: 0x02000AAB RID: 2731
	[Token(Token = "0x2000AAB")]
	public class MonoBehaviourWrapped : MonoBehaviour
	{
		// Token: 0x17000746 RID: 1862
		// (get) Token: 0x06006843 RID: 26691 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000746")]
		public Transform Transform
		{
			[Token(Token = "0x6006843")]
			[Address(RVA = "0x33CE190", Offset = "0x33CE190", VA = "0x33CE190")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000747 RID: 1863
		// (get) Token: 0x06006844 RID: 26692 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000747")]
		public GameObject GameObject
		{
			[Token(Token = "0x6006844")]
			[Address(RVA = "0x33CE224", Offset = "0x33CE224", VA = "0x33CE224")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006845 RID: 26693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006845")]
		[Address(RVA = "0x33CE2B8", Offset = "0x33CE2B8", VA = "0x33CE2B8")]
		public MonoBehaviourWrapped()
		{
		}

		// Token: 0x040029D5 RID: 10709
		[Token(Token = "0x40029D5")]
		[FieldOffset(Offset = "0x18")]
		protected Transform cachedTransform;

		// Token: 0x040029D6 RID: 10710
		[Token(Token = "0x40029D6")]
		[FieldOffset(Offset = "0x20")]
		protected GameObject cachedGO;
	}
}
