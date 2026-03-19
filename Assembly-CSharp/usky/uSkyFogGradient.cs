using System;
using Il2CppDummyDll;
using UnityEngine;

namespace usky
{
	// Token: 0x02000A0E RID: 2574
	[Token(Token = "0x2000A0E")]
	[AddComponentMenu("uSkyPro/uSky Fog Gradient (Standard Fog)")]
	[DisallowMultipleComponent]
	[ExecuteInEditMode]
	public class uSkyFogGradient : MonoBehaviour
	{
		// Token: 0x06006243 RID: 25155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006243")]
		[Address(RVA = "0x3032070", Offset = "0x3032070", VA = "0x3032070")]
		private void OnEnable()
		{
		}

		// Token: 0x06006244 RID: 25156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006244")]
		[Address(RVA = "0x3032134", Offset = "0x3032134", VA = "0x3032134")]
		private void OnDisable()
		{
		}

		// Token: 0x06006245 RID: 25157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006245")]
		[Address(RVA = "0x30321F8", Offset = "0x30321F8", VA = "0x30321F8")]
		private void Start()
		{
		}

		// Token: 0x06006246 RID: 25158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006246")]
		[Address(RVA = "0x30321FC", Offset = "0x30321FC", VA = "0x30321FC")]
		private void UpdateUnityFog()
		{
		}

		// Token: 0x06006247 RID: 25159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006247")]
		[Address(RVA = "0x30323B4", Offset = "0x30323B4", VA = "0x30323B4")]
		public uSkyFogGradient()
		{
		}

		// Token: 0x0400266E RID: 9838
		[Token(Token = "0x400266E")]
		[FieldOffset(Offset = "0x18")]
		[Tooltip("Control unity built-in fog color in Lighting window.\n\n* Note: Support \"Forward\" rendering path only.")]
		public Gradient FogColor;
	}
}
