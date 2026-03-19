using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace usky.Internal
{
	// Token: 0x02000A2E RID: 2606
	[Token(Token = "0x2000A2E")]
	public static class uSkyInternal
	{
		// Token: 0x060062F1 RID: 25329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062F1")]
		[Address(RVA = "0x303BBEC", Offset = "0x303BBEC", VA = "0x303BBEC")]
		public static void MarkTimelineStateDirty()
		{
		}

		// Token: 0x060062F2 RID: 25330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062F2")]
		[Address(RVA = "0x303BC7C", Offset = "0x303BC7C", VA = "0x303BC7C")]
		public static void MarkCycleStateDirty()
		{
		}

		// Token: 0x060062F3 RID: 25331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062F3")]
		[Address(RVA = "0x3033C04", Offset = "0x3033C04", VA = "0x3033C04")]
		public static void MarkLightingStateDirty()
		{
		}

		// Token: 0x060062F4 RID: 25332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062F4")]
		[Address(RVA = "0x3036AD4", Offset = "0x3036AD4", VA = "0x3036AD4")]
		public static void MarkAtmosphereStateDirty()
		{
		}

		// Token: 0x060062F5 RID: 25333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062F5")]
		[Address(RVA = "0x303BD0C", Offset = "0x303BD0C", VA = "0x303BD0C")]
		public static void MarkPrecomputedStateDirty()
		{
		}

		// Token: 0x060062F6 RID: 25334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062F6")]
		[Address(RVA = "0x3036B64", Offset = "0x3036B64", VA = "0x3036B64")]
		public static void MarkProbeStateDirty()
		{
		}

		// Token: 0x060062F7 RID: 25335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062F7")]
		[Address(RVA = "0x303BD9C", Offset = "0x303BD9C", VA = "0x303BD9C")]
		public static void RemoveAllEventListeners()
		{
		}

		// Token: 0x060062F8 RID: 25336 RVA: 0x0004BC60 File Offset: 0x00049E60
		[Token(Token = "0x60062F8")]
		[Address(RVA = "0x30322B8", Offset = "0x30322B8", VA = "0x30322B8")]
		public static float NormalizedTime(uSkySun m_Sun, uSkyMoon m_Moon)
		{
			return 0f;
		}

		// Token: 0x060062F9 RID: 25337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062F9")]
		[Address(RVA = "0x30395E4", Offset = "0x30395E4", VA = "0x30395E4")]
		public static void SetSpaceAndStarsRotation(Quaternion rotation)
		{
		}

		// Token: 0x060062FA RID: 25338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062FA")]
		[Address(RVA = "0x303BE48", Offset = "0x303BE48", VA = "0x303BE48")]
		public static void InitAtmosphereParameters(uSkyPro uSP)
		{
		}

		// Token: 0x060062FB RID: 25339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062FB")]
		[Address(RVA = "0x303C020", Offset = "0x303C020", VA = "0x303C020")]
		public static void SetNightSkyMode(int NewNightSkyMode)
		{
		}

		// Token: 0x060062FC RID: 25340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062FC")]
		[Address(RVA = "0x303C0AC", Offset = "0x303C0AC", VA = "0x303C0AC")]
		public static void SetSkyboxOcean(bool SkyboxOcean)
		{
		}

		// Token: 0x060062FD RID: 25341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062FD")]
		[Address(RVA = "0x303C13C", Offset = "0x303C13C", VA = "0x303C13C")]
		public static void SetHDRMode(bool NewHDRMode)
		{
		}

		// Token: 0x060062FE RID: 25342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062FE")]
		[Address(RVA = "0x303C1CC", Offset = "0x303C1CC", VA = "0x303C1CC")]
		public static void SetAtmosphereParameterState(uSkyPro uSP)
		{
		}

		// Token: 0x060062FF RID: 25343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062FF")]
		[Address(RVA = "0x303CCEC", Offset = "0x303CCEC", VA = "0x303CCEC")]
		private static void SetExposure(float NewExposure)
		{
		}

		// Token: 0x06006300 RID: 25344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006300")]
		[Address(RVA = "0x303C308", Offset = "0x303C308", VA = "0x303C308")]
		private static void SetMieScattering(float NewMieScattering)
		{
		}

		// Token: 0x06006301 RID: 25345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006301")]
		[Address(RVA = "0x303C39C", Offset = "0x303C39C", VA = "0x303C39C")]
		private static void SetSunAnisotropyFactor(float NewSunAnisotropyFactor)
		{
		}

		// Token: 0x06006302 RID: 25346 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006302")]
		[Address(RVA = "0x303C430", Offset = "0x303C430", VA = "0x303C430")]
		private static void SetSunSize(float NewSunSize)
		{
		}

		// Token: 0x06006303 RID: 25347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006303")]
		[Address(RVA = "0x303CD84", Offset = "0x303CD84", VA = "0x303CD84")]
		private static void SetNightZenithColor(Color NewNightZenithColor)
		{
		}

		// Token: 0x06006304 RID: 25348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006304")]
		[Address(RVA = "0x303CE6C", Offset = "0x303CE6C", VA = "0x303CE6C")]
		private static void SetNightHorizonColor(Color NewNightHorizonColor)
		{
		}

		// Token: 0x06006305 RID: 25349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006305")]
		[Address(RVA = "0x303C4C4", Offset = "0x303C4C4", VA = "0x303C4C4")]
		private static void SetStarIntensity(float NewStarIntensity)
		{
		}

		// Token: 0x06006306 RID: 25350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006306")]
		[Address(RVA = "0x303C57C", Offset = "0x303C57C", VA = "0x303C57C")]
		private static void SetOuterSpaceIntensity(float NewOuterSpaceIntensity)
		{
		}

		// Token: 0x06006307 RID: 25351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006307")]
		[Address(RVA = "0x303C610", Offset = "0x303C610", VA = "0x303C610")]
		private static void SetMoonInnerCorona(Color NewMoonInnerCorona)
		{
		}

		// Token: 0x06006308 RID: 25352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006308")]
		[Address(RVA = "0x303C6F8", Offset = "0x303C6F8", VA = "0x303C6F8")]
		private static void SetMoonOuterCorona(Color NewMoonOuterCorona)
		{
		}

		// Token: 0x06006309 RID: 25353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006309")]
		[Address(RVA = "0x303C7E0", Offset = "0x303C7E0", VA = "0x303C7E0")]
		private static void SetMoonSize(float NewMoonSize)
		{
		}

		// Token: 0x0600630A RID: 25354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600630A")]
		[Address(RVA = "0x303CF54", Offset = "0x303CF54", VA = "0x303CF54")]
		private static void SetGroundColor(Color NewGroundColor)
		{
		}

		// Token: 0x0600630B RID: 25355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600630B")]
		[Address(RVA = "0x303C874", Offset = "0x303C874", VA = "0x303C874")]
		private static void SetGroundOffset(float NewGroundOffset)
		{
		}

		// Token: 0x0600630C RID: 25356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600630C")]
		[Address(RVA = "0x303C908", Offset = "0x303C908", VA = "0x303C908")]
		private static void SetAltitudeScale(float NewAltitudeScale)
		{
		}

		// Token: 0x0600630D RID: 25357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600630D")]
		[Address(RVA = "0x303C99C", Offset = "0x303C99C", VA = "0x303C99C")]
		private static void SetAtmosphereThickness(float NewAtmosphereThickness)
		{
		}

		// Token: 0x0600630E RID: 25358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600630E")]
		[Address(RVA = "0x303CA60", Offset = "0x303CA60", VA = "0x303CA60")]
		private static void SetWavelengths(Vector3 NewWavelengths)
		{
		}

		// Token: 0x0600630F RID: 25359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600630F")]
		[Address(RVA = "0x303CB3C", Offset = "0x303CB3C", VA = "0x303CB3C")]
		private static void SetSkyTint(Color NewSkyTint)
		{
		}

		// Token: 0x06006310 RID: 25360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006310")]
		[Address(RVA = "0x303CC28", Offset = "0x303CC28", VA = "0x303CC28")]
		private static void SetInscatterAltitudeSample(int NewInscatterAltitudeSample)
		{
		}

		// Token: 0x06006311 RID: 25361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006311")]
		[Address(RVA = "0x303790C", Offset = "0x303790C", VA = "0x303790C")]
		public static void InitTimelineParameters(uSkyTimeline uST)
		{
		}

		// Token: 0x06006312 RID: 25362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006312")]
		[Address(RVA = "0x3038628", Offset = "0x3038628", VA = "0x3038628")]
		public static void SetTimeMode(int NewTimeMode)
		{
		}

		// Token: 0x06006313 RID: 25363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006313")]
		[Address(RVA = "0x30386B0", Offset = "0x30386B0", VA = "0x30386B0")]
		public static void SetTimeline(float NewTimeline)
		{
		}

		// Token: 0x06006314 RID: 25364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006314")]
		[Address(RVA = "0x30387D0", Offset = "0x30387D0", VA = "0x30387D0")]
		public static void SetTimelineSettingState(DefaultTimelineSettings Setting)
		{
		}

		// Token: 0x06006315 RID: 25365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006315")]
		[Address(RVA = "0x303D03C", Offset = "0x303D03C", VA = "0x303D03C")]
		public static void SetSunDirection(float NewSunDirection)
		{
		}

		// Token: 0x06006316 RID: 25366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006316")]
		[Address(RVA = "0x303D0D0", Offset = "0x303D0D0", VA = "0x303D0D0")]
		public static void SetSunEquatorOffset(float NewEquatorOffset)
		{
		}

		// Token: 0x06006317 RID: 25367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006317")]
		[Address(RVA = "0x303D164", Offset = "0x303D164", VA = "0x303D164")]
		public static void SetMoonPositionOffset(float NewMoonPositionOffset)
		{
		}

		// Token: 0x06006318 RID: 25368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006318")]
		[Address(RVA = "0x3038748", Offset = "0x3038748", VA = "0x3038748")]
		public static void SetTimelineSettingState(RealisticTimelineSettings Setting)
		{
		}

		// Token: 0x06006319 RID: 25369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006319")]
		[Address(RVA = "0x303D1F8", Offset = "0x303D1F8", VA = "0x303D1F8")]
		private static void SetLatitude(float NewLatitude)
		{
		}

		// Token: 0x0600631A RID: 25370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600631A")]
		[Address(RVA = "0x303D28C", Offset = "0x303D28C", VA = "0x303D28C")]
		private static void SetLongitude(float NewLongitude)
		{
		}

		// Token: 0x0600631B RID: 25371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600631B")]
		[Address(RVA = "0x303D320", Offset = "0x303D320", VA = "0x303D320")]
		private static void SetDay(int NewDay)
		{
		}

		// Token: 0x0600631C RID: 25372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600631C")]
		[Address(RVA = "0x303D3A8", Offset = "0x303D3A8", VA = "0x303D3A8")]
		private static void SetMonth(int NewMonth)
		{
		}

		// Token: 0x0600631D RID: 25373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600631D")]
		[Address(RVA = "0x303D430", Offset = "0x303D430", VA = "0x303D430")]
		private static void SetYear(int NewYear)
		{
		}

		// Token: 0x0600631E RID: 25374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600631E")]
		[Address(RVA = "0x303D4B8", Offset = "0x303D4B8", VA = "0x303D4B8")]
		private static void SetGMTOffset(int NewGMTOffset)
		{
		}

		// Token: 0x0400277E RID: 10110
		[Token(Token = "0x400277E")]
		[FieldOffset(Offset = "0x0")]
		public static UnityEvent UpdatePrecomputeEvent;

		// Token: 0x0400277F RID: 10111
		[Token(Token = "0x400277F")]
		[FieldOffset(Offset = "0x8")]
		public static UnityEvent UpdateAtmosphereEvent;

		// Token: 0x04002780 RID: 10112
		[Token(Token = "0x4002780")]
		[FieldOffset(Offset = "0x10")]
		public static UnityEvent UpdateTimelineEvent;

		// Token: 0x04002781 RID: 10113
		[Token(Token = "0x4002781")]
		[FieldOffset(Offset = "0x18")]
		public static UnityEvent UpdateCycleEvent;

		// Token: 0x04002782 RID: 10114
		[Token(Token = "0x4002782")]
		[FieldOffset(Offset = "0x20")]
		public static UnityEvent UpdateLightingEvent;

		// Token: 0x04002783 RID: 10115
		[Token(Token = "0x4002783")]
		[FieldOffset(Offset = "0x28")]
		public static UnityEvent UpdateProbeEvent;

		// Token: 0x04002784 RID: 10116
		[Token(Token = "0x4002784")]
		[FieldOffset(Offset = "0x30")]
		internal static float m_Exposure;

		// Token: 0x04002785 RID: 10117
		[Token(Token = "0x4002785")]
		[FieldOffset(Offset = "0x34")]
		internal static float m_MieScattering;

		// Token: 0x04002786 RID: 10118
		[Token(Token = "0x4002786")]
		[FieldOffset(Offset = "0x38")]
		internal static float m_SunAnisotropyFactor;

		// Token: 0x04002787 RID: 10119
		[Token(Token = "0x4002787")]
		[FieldOffset(Offset = "0x3C")]
		internal static float m_SunSize;

		// Token: 0x04002788 RID: 10120
		[Token(Token = "0x4002788")]
		[FieldOffset(Offset = "0x40")]
		internal static float m_StarIntensity;

		// Token: 0x04002789 RID: 10121
		[Token(Token = "0x4002789")]
		[FieldOffset(Offset = "0x44")]
		internal static float m_OuterSpaceIntensity;

		// Token: 0x0400278A RID: 10122
		[Token(Token = "0x400278A")]
		[FieldOffset(Offset = "0x48")]
		internal static float m_MoonSize;

		// Token: 0x0400278B RID: 10123
		[Token(Token = "0x400278B")]
		[FieldOffset(Offset = "0x4C")]
		internal static float m_GroundOffset;

		// Token: 0x0400278C RID: 10124
		[Token(Token = "0x400278C")]
		[FieldOffset(Offset = "0x50")]
		internal static float m_AltitudeScale;

		// Token: 0x0400278D RID: 10125
		[Token(Token = "0x400278D")]
		[FieldOffset(Offset = "0x54")]
		internal static Color m_GroundColor;

		// Token: 0x0400278E RID: 10126
		[Token(Token = "0x400278E")]
		[FieldOffset(Offset = "0x64")]
		internal static Color m_NightZenithColor;

		// Token: 0x0400278F RID: 10127
		[Token(Token = "0x400278F")]
		[FieldOffset(Offset = "0x74")]
		internal static Color m_NightHorizonColor;

		// Token: 0x04002790 RID: 10128
		[Token(Token = "0x4002790")]
		[FieldOffset(Offset = "0x84")]
		internal static Color m_MoonInnerCorona;

		// Token: 0x04002791 RID: 10129
		[Token(Token = "0x4002791")]
		[FieldOffset(Offset = "0x94")]
		internal static Color m_MoonOuterCorona;

		// Token: 0x04002792 RID: 10130
		[Token(Token = "0x4002792")]
		[FieldOffset(Offset = "0xA4")]
		internal static int m_NightSkyMode;

		// Token: 0x04002793 RID: 10131
		[Token(Token = "0x4002793")]
		[FieldOffset(Offset = "0xA8")]
		internal static bool m_DisableSkyboxOcean;

		// Token: 0x04002794 RID: 10132
		[Token(Token = "0x4002794")]
		[FieldOffset(Offset = "0xA9")]
		internal static bool m_HDRMode;

		// Token: 0x04002795 RID: 10133
		[Token(Token = "0x4002795")]
		[FieldOffset(Offset = "0xAC")]
		internal static float m_AtmosphereThickness;

		// Token: 0x04002796 RID: 10134
		[Token(Token = "0x4002796")]
		[FieldOffset(Offset = "0xB0")]
		internal static Vector3 m_Wavelengths;

		// Token: 0x04002797 RID: 10135
		[Token(Token = "0x4002797")]
		[FieldOffset(Offset = "0xBC")]
		internal static Color m_SkyTint;

		// Token: 0x04002798 RID: 10136
		[Token(Token = "0x4002798")]
		[FieldOffset(Offset = "0xCC")]
		internal static int m_InscatterAltitudeSample;

		// Token: 0x04002799 RID: 10137
		[Token(Token = "0x4002799")]
		[FieldOffset(Offset = "0xD0")]
		internal static int m_TimeMode;

		// Token: 0x0400279A RID: 10138
		[Token(Token = "0x400279A")]
		[FieldOffset(Offset = "0xD4")]
		internal static float m_Timeline;

		// Token: 0x0400279B RID: 10139
		[Token(Token = "0x400279B")]
		[FieldOffset(Offset = "0xD8")]
		internal static float m_SunDirection;

		// Token: 0x0400279C RID: 10140
		[Token(Token = "0x400279C")]
		[FieldOffset(Offset = "0xDC")]
		internal static float m_SunEquatorOffset;

		// Token: 0x0400279D RID: 10141
		[Token(Token = "0x400279D")]
		[FieldOffset(Offset = "0xE0")]
		internal static float m_MoonPositionOffset;

		// Token: 0x0400279E RID: 10142
		[Token(Token = "0x400279E")]
		[FieldOffset(Offset = "0xE4")]
		internal static float m_Latitude;

		// Token: 0x0400279F RID: 10143
		[Token(Token = "0x400279F")]
		[FieldOffset(Offset = "0xE8")]
		internal static float m_Longitude;

		// Token: 0x040027A0 RID: 10144
		[Token(Token = "0x40027A0")]
		[FieldOffset(Offset = "0xEC")]
		internal static int m_Day;

		// Token: 0x040027A1 RID: 10145
		[Token(Token = "0x40027A1")]
		[FieldOffset(Offset = "0xF0")]
		internal static int m_Month;

		// Token: 0x040027A2 RID: 10146
		[Token(Token = "0x40027A2")]
		[FieldOffset(Offset = "0xF4")]
		internal static int m_Year;

		// Token: 0x040027A3 RID: 10147
		[Token(Token = "0x40027A3")]
		[FieldOffset(Offset = "0xF8")]
		internal static int m_GMTOffset;
	}
}
