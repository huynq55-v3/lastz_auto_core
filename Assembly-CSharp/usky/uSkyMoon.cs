using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace usky
{
	// Token: 0x02000A18 RID: 2584
	[Token(Token = "0x2000A18")]
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	[AddComponentMenu("uSkyPro/uSky Moon")]
	public class uSkyMoon : MonoBehaviour
	{
		// Token: 0x17000659 RID: 1625
		// (get) Token: 0x06006285 RID: 25221 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006286 RID: 25222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000659")]
		public Transform transform
		{
			[Token(Token = "0x6006285")]
			[Address(RVA = "0x30364D0", Offset = "0x30364D0", VA = "0x30364D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006286")]
			[Address(RVA = "0x30364D8", Offset = "0x30364D8", VA = "0x30364D8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700065A RID: 1626
		// (get) Token: 0x06006287 RID: 25223 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006288 RID: 25224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700065A")]
		public Light MoonLight
		{
			[Token(Token = "0x6006287")]
			[Address(RVA = "0x30364E0", Offset = "0x30364E0", VA = "0x30364E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006288")]
			[Address(RVA = "0x30364E8", Offset = "0x30364E8", VA = "0x30364E8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700065B RID: 1627
		// (get) Token: 0x06006289 RID: 25225 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700065B")]
		public GameObject MoonEntity
		{
			[Token(Token = "0x6006289")]
			[Address(RVA = "0x30364F0", Offset = "0x30364F0", VA = "0x30364F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600628A RID: 25226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600628A")]
		[Address(RVA = "0x30365BC", Offset = "0x30365BC", VA = "0x30365BC")]
		private void OnEnable()
		{
		}

		// Token: 0x0600628B RID: 25227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600628B")]
		[Address(RVA = "0x30366B8", Offset = "0x30366B8", VA = "0x30366B8")]
		private void OnDisable()
		{
		}

		// Token: 0x0600628C RID: 25228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600628C")]
		[Address(RVA = "0x30367CC", Offset = "0x30367CC", VA = "0x30367CC")]
		private void Update()
		{
		}

		// Token: 0x0600628D RID: 25229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600628D")]
		[Address(RVA = "0x3036918", Offset = "0x3036918", VA = "0x3036918")]
		private void CheckMoonTransformState()
		{
		}

		// Token: 0x0600628E RID: 25230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600628E")]
		[Address(RVA = "0x3036BF4", Offset = "0x3036BF4", VA = "0x3036BF4")]
		public uSkyMoon()
		{
		}

		// Token: 0x0400270D RID: 9997
		[Token(Token = "0x400270D")]
		[FieldOffset(Offset = "0x0")]
		public static uSkyMoon instance;

		// Token: 0x04002710 RID: 10000
		[Token(Token = "0x4002710")]
		[FieldOffset(Offset = "0x28")]
		private GameObject moonEntity;
	}
}
