using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace usky
{
	// Token: 0x02000A28 RID: 2600
	[Token(Token = "0x2000A28")]
	[AddComponentMenu("uSkyPro/uSky Sun")]
	[DisallowMultipleComponent]
	[ExecuteInEditMode]
	public class uSkySun : MonoBehaviour
	{
		// Token: 0x1700065C RID: 1628
		// (get) Token: 0x06006294 RID: 25236 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006295 RID: 25237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700065C")]
		public Transform transform
		{
			[Token(Token = "0x6006294")]
			[Address(RVA = "0x3036E98", Offset = "0x3036E98", VA = "0x3036E98")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006295")]
			[Address(RVA = "0x3036EA0", Offset = "0x3036EA0", VA = "0x3036EA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700065D RID: 1629
		// (get) Token: 0x06006296 RID: 25238 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006297 RID: 25239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700065D")]
		public Light SunLight
		{
			[Token(Token = "0x6006296")]
			[Address(RVA = "0x3036EA8", Offset = "0x3036EA8", VA = "0x3036EA8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006297")]
			[Address(RVA = "0x3036EB0", Offset = "0x3036EB0", VA = "0x3036EB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700065E RID: 1630
		// (get) Token: 0x06006298 RID: 25240 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700065E")]
		public GameObject SunEntity
		{
			[Token(Token = "0x6006298")]
			[Address(RVA = "0x3036EB8", Offset = "0x3036EB8", VA = "0x3036EB8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006299 RID: 25241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006299")]
		[Address(RVA = "0x3036F84", Offset = "0x3036F84", VA = "0x3036F84")]
		private void Awake()
		{
		}

		// Token: 0x0600629A RID: 25242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600629A")]
		[Address(RVA = "0x3036F88", Offset = "0x3036F88", VA = "0x3036F88")]
		private void OnEnable()
		{
		}

		// Token: 0x0600629B RID: 25243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600629B")]
		[Address(RVA = "0x3037154", Offset = "0x3037154", VA = "0x3037154")]
		private void OnDisable()
		{
		}

		// Token: 0x0600629C RID: 25244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600629C")]
		[Address(RVA = "0x30373C4", Offset = "0x30373C4", VA = "0x30373C4")]
		private void CheckSunTransformState()
		{
		}

		// Token: 0x0600629D RID: 25245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600629D")]
		[Address(RVA = "0x3037580", Offset = "0x3037580", VA = "0x3037580")]
		public uSkySun()
		{
		}

		// Token: 0x0400274D RID: 10061
		[Token(Token = "0x400274D")]
		[FieldOffset(Offset = "0x0")]
		public static uSkySun instance;

		// Token: 0x04002750 RID: 10064
		[Token(Token = "0x4002750")]
		[FieldOffset(Offset = "0x28")]
		private GameObject sunEntity;
	}
}
