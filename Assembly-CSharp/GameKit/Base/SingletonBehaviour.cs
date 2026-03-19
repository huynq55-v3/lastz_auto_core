using System;
using Il2CppDummyDll;
using UnityEngine;

namespace GameKit.Base
{
	// Token: 0x020004E0 RID: 1248
	[Token(Token = "0x20004E0")]
	public class SingletonBehaviour<T> : MonoBehaviour where T : MonoBehaviour
	{
		// Token: 0x170005B7 RID: 1463
		// (get) Token: 0x060025DA RID: 9690 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005B7")]
		public static T Instance
		{
			[Token(Token = "0x60025DA")]
			get
			{
				return null;
			}
		}

		// Token: 0x060025DB RID: 9691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025DB")]
		public static void DestroyInstance()
		{
		}

		// Token: 0x060025DC RID: 9692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025DC")]
		private void OnDestroy()
		{
		}

		// Token: 0x060025DD RID: 9693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025DD")]
		private void Update()
		{
		}

		// Token: 0x060025DE RID: 9694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025DE")]
		private void FixedUpdate()
		{
		}

		// Token: 0x060025DF RID: 9695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025DF")]
		private void LateUpdate()
		{
		}

		// Token: 0x060025E0 RID: 9696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025E0")]
		protected virtual void OnUpdate(float delta)
		{
		}

		// Token: 0x060025E1 RID: 9697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025E1")]
		public virtual void Release()
		{
		}

		// Token: 0x060025E2 RID: 9698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025E2")]
		public SingletonBehaviour()
		{
		}

		// Token: 0x04002274 RID: 8820
		[Token(Token = "0x4002274")]
		[FieldOffset(Offset = "0x0")]
		private static T _instance;

		// Token: 0x04002275 RID: 8821
		[Token(Token = "0x4002275")]
		[FieldOffset(Offset = "0x0")]
		private static bool applicationIsQuitting;

		// Token: 0x04002276 RID: 8822
		[Token(Token = "0x4002276")]
		[FieldOffset(Offset = "0x0")]
		public SingletonBehaviour<T>.UpdateMode updateMode;

		// Token: 0x020004E1 RID: 1249
		[Token(Token = "0x20004E1")]
		public enum UpdateMode
		{
			// Token: 0x04002278 RID: 8824
			[Token(Token = "0x4002278")]
			FIXED_UPDATE,
			// Token: 0x04002279 RID: 8825
			[Token(Token = "0x4002279")]
			UPDATE,
			// Token: 0x0400227A RID: 8826
			[Token(Token = "0x400227A")]
			LATE_UPDATE
		}
	}
}
