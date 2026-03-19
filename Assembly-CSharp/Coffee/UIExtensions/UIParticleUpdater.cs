using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Coffee.UIExtensions
{
	// Token: 0x02000A49 RID: 2633
	[Token(Token = "0x2000A49")]
	internal static class UIParticleUpdater
	{
		// Token: 0x060063AE RID: 25518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063AE")]
		[Address(RVA = "0x2DF1EDC", Offset = "0x2DF1EDC", VA = "0x2DF1EDC")]
		public static void Register(UIParticle particle)
		{
		}

		// Token: 0x060063AF RID: 25519 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063AF")]
		[Address(RVA = "0x2DF1FF4", Offset = "0x2DF1FF4", VA = "0x2DF1FF4")]
		public static void Unregister(UIParticle particle)
		{
		}

		// Token: 0x060063B0 RID: 25520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063B0")]
		[Address(RVA = "0x2DF20B4", Offset = "0x2DF20B4", VA = "0x2DF20B4")]
		public static void Register(UITrail trail)
		{
		}

		// Token: 0x060063B1 RID: 25521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063B1")]
		[Address(RVA = "0x2DF21CC", Offset = "0x2DF21CC", VA = "0x2DF21CC")]
		public static void Unregister(UITrail trail)
		{
		}

		// Token: 0x060063B2 RID: 25522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063B2")]
		[Address(RVA = "0x2DF228C", Offset = "0x2DF228C", VA = "0x2DF228C")]
		[RuntimeInitializeOnLoadMethod]
		private static void InitializeOnLoad()
		{
		}

		// Token: 0x060063B3 RID: 25523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063B3")]
		[Address(RVA = "0x2DF23B8", Offset = "0x2DF23B8", VA = "0x2DF23B8")]
		private static void Refresh()
		{
		}

		// Token: 0x060063B4 RID: 25524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063B4")]
		[Address(RVA = "0x2DF2824", Offset = "0x2DF2824", VA = "0x2DF2824")]
		private static void Refresh(UITrail trail)
		{
		}

		// Token: 0x060063B5 RID: 25525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063B5")]
		[Address(RVA = "0x2DF2688", Offset = "0x2DF2688", VA = "0x2DF2688")]
		private static void Refresh(UIParticle particle)
		{
		}

		// Token: 0x060063B6 RID: 25526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063B6")]
		[Address(RVA = "0x2DF2A2C", Offset = "0x2DF2A2C", VA = "0x2DF2A2C")]
		private static void ModifyScale(UIParticle particle)
		{
		}

		// Token: 0x060063B7 RID: 25527 RVA: 0x0004BED0 File Offset: 0x0004A0D0
		[Token(Token = "0x60063B7")]
		[Address(RVA = "0x2DF3B60", Offset = "0x2DF3B60", VA = "0x2DF3B60")]
		private static Matrix4x4 GetScaledMatrix(ParticleSystem particle)
		{
			return default(Matrix4x4);
		}

		// Token: 0x060063B8 RID: 25528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063B8")]
		[Address(RVA = "0x2DF2C74", Offset = "0x2DF2C74", VA = "0x2DF2C74")]
		private static void BakeMesh(UIParticle particle)
		{
		}

		// Token: 0x060063B9 RID: 25529 RVA: 0x0004BEE8 File Offset: 0x0004A0E8
		[Token(Token = "0x60063B9")]
		[Address(RVA = "0x2DF3E0C", Offset = "0x2DF3E0C", VA = "0x2DF3E0C")]
		private static bool CanBakeMesh(ParticleSystemRenderer renderer)
		{
			return default(bool);
		}

		// Token: 0x04002831 RID: 10289
		[Token(Token = "0x4002831")]
		[FieldOffset(Offset = "0x0")]
		private static readonly List<UIParticle> s_ActiveParticles;

		// Token: 0x04002832 RID: 10290
		[Token(Token = "0x4002832")]
		[FieldOffset(Offset = "0x8")]
		private static MaterialPropertyBlock s_Mpb;

		// Token: 0x04002833 RID: 10291
		[Token(Token = "0x4002833")]
		[FieldOffset(Offset = "0x10")]
		private static ParticleSystem.Particle[] s_Particles;

		// Token: 0x04002834 RID: 10292
		[Token(Token = "0x4002834")]
		[FieldOffset(Offset = "0x18")]
		private static readonly List<UITrail> s_ActiveTrails;
	}
}
