using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace usky
{
	// Token: 0x02000A2A RID: 2602
	[Token(Token = "0x2000A2A")]
	[AddComponentMenu("uSkyPro/uSky Timeline")]
	[DisallowMultipleComponent]
	public class uSkyTimeline : MonoBehaviour
	{
		// Token: 0x1700065F RID: 1631
		// (get) Token: 0x0600629E RID: 25246 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600629F RID: 25247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700065F")]
		public static uSkyTimeline instance
		{
			[Token(Token = "0x600629E")]
			[Address(RVA = "0x3037588", Offset = "0x3037588", VA = "0x3037588")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600629F")]
			[Address(RVA = "0x30375D0", Offset = "0x30375D0", VA = "0x30375D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000660 RID: 1632
		// (get) Token: 0x060062A0 RID: 25248 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000660")]
		private uSkySun m_Sun
		{
			[Token(Token = "0x60062A0")]
			[Address(RVA = "0x3037628", Offset = "0x3037628", VA = "0x3037628")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000661 RID: 1633
		// (get) Token: 0x060062A1 RID: 25249 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000661")]
		private uSkyMoon m_Moon
		{
			[Token(Token = "0x60062A1")]
			[Address(RVA = "0x3037670", Offset = "0x3037670", VA = "0x3037670")]
			get
			{
				return null;
			}
		}

		// Token: 0x060062A2 RID: 25250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062A2")]
		[Address(RVA = "0x30376B8", Offset = "0x30376B8", VA = "0x30376B8")]
		private void Awake()
		{
		}

		// Token: 0x060062A3 RID: 25251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062A3")]
		[Address(RVA = "0x3037994", Offset = "0x3037994", VA = "0x3037994")]
		public void ToggleSkyBox(bool isToggle)
		{
		}

		// Token: 0x060062A4 RID: 25252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062A4")]
		[Address(RVA = "0x3037B3C", Offset = "0x3037B3C", VA = "0x3037B3C")]
		private void Start()
		{
		}

		// Token: 0x060062A5 RID: 25253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062A5")]
		[Address(RVA = "0x3037B54", Offset = "0x3037B54", VA = "0x3037B54")]
		public void SetTime(float t)
		{
		}

		// Token: 0x060062A6 RID: 25254 RVA: 0x0004BA38 File Offset: 0x00049C38
		[Token(Token = "0x60062A6")]
		[Address(RVA = "0x3037B60", Offset = "0x3037B60", VA = "0x3037B60")]
		private float getDuringTime(float time)
		{
			return 0f;
		}

		// Token: 0x060062A7 RID: 25255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062A7")]
		[Address(RVA = "0x3037C74", Offset = "0x3037C74", VA = "0x3037C74")]
		private void UpdateTestTime()
		{
		}

		// Token: 0x060062A8 RID: 25256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062A8")]
		[Address(RVA = "0x3037D18", Offset = "0x3037D18", VA = "0x3037D18")]
		private void OnUpdateTimeInterval()
		{
		}

		// Token: 0x060062A9 RID: 25257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062A9")]
		[Address(RVA = "0x3037E28", Offset = "0x3037E28", VA = "0x3037E28")]
		private void OnTimeIntervalActionCallback(int state)
		{
		}

		// Token: 0x17000662 RID: 1634
		// (get) Token: 0x060062AA RID: 25258 RVA: 0x0004BA50 File Offset: 0x00049C50
		[Token(Token = "0x17000662")]
		public bool IsNight
		{
			[Token(Token = "0x60062AA")]
			[Address(RVA = "0x3037E70", Offset = "0x3037E70", VA = "0x3037E70")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060062AB RID: 25259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062AB")]
		[Address(RVA = "0x3037E98", Offset = "0x3037E98", VA = "0x3037E98")]
		public void InitTime(float time)
		{
		}

		// Token: 0x060062AC RID: 25260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062AC")]
		[Address(RVA = "0x3037EA8", Offset = "0x3037EA8", VA = "0x3037EA8")]
		public void SetDay()
		{
		}

		// Token: 0x060062AD RID: 25261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062AD")]
		[Address(RVA = "0x3037EC0", Offset = "0x3037EC0", VA = "0x3037EC0")]
		public void SetNight()
		{
		}

		// Token: 0x060062AE RID: 25262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062AE")]
		[Address(RVA = "0x3037ED8", Offset = "0x3037ED8", VA = "0x3037ED8")]
		public void Reset()
		{
		}

		// Token: 0x060062AF RID: 25263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062AF")]
		[Address(RVA = "0x3037EE0", Offset = "0x3037EE0", VA = "0x3037EE0")]
		public void Pause()
		{
		}

		// Token: 0x060062B0 RID: 25264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062B0")]
		[Address(RVA = "0x3037EEC", Offset = "0x3037EEC", VA = "0x3037EEC")]
		public void SetDayOfSecond(string stateArray, string tickArray)
		{
		}

		// Token: 0x060062B1 RID: 25265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062B1")]
		[Address(RVA = "0x303806C", Offset = "0x303806C", VA = "0x303806C")]
		public void SetTimeInterval(int state)
		{
		}

		// Token: 0x1400000F RID: 15
		// (add) Token: 0x060062B2 RID: 25266 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x060062B3 RID: 25267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400000F")]
		public event Action<int> OnTimeIntervalChange
		{
			[Token(Token = "0x60062B2")]
			[Address(RVA = "0x3038090", Offset = "0x3038090", VA = "0x3038090")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60062B3")]
			[Address(RVA = "0x3038144", Offset = "0x3038144", VA = "0x3038144")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x060062B4 RID: 25268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062B4")]
		[Address(RVA = "0x30381F8", Offset = "0x30381F8", VA = "0x30381F8")]
		private void Update()
		{
		}

		// Token: 0x060062B5 RID: 25269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062B5")]
		[Address(RVA = "0x30384D0", Offset = "0x30384D0", VA = "0x30384D0")]
		private void OnDestroy()
		{
		}

		// Token: 0x060062B6 RID: 25270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062B6")]
		[Address(RVA = "0x303823C", Offset = "0x303823C", VA = "0x303823C")]
		private void SetTimelineState()
		{
		}

		// Token: 0x060062B7 RID: 25271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062B7")]
		[Address(RVA = "0x303884C", Offset = "0x303884C", VA = "0x303884C")]
		private void InitSunAndMoonDirection()
		{
		}

		// Token: 0x060062B8 RID: 25272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062B8")]
		[Address(RVA = "0x3039234", Offset = "0x3039234", VA = "0x3039234")]
		private void UpdateSunAndMoonDirection()
		{
		}

		// Token: 0x060062B9 RID: 25273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062B9")]
		[Address(RVA = "0x3038340", Offset = "0x3038340", VA = "0x3038340")]
		private void UpdateTimeCycle()
		{
		}

		// Token: 0x060062BA RID: 25274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062BA")]
		[Address(RVA = "0x3037B48", Offset = "0x3037B48", VA = "0x3037B48")]
		private void UpdateTimelineState()
		{
		}

		// Token: 0x060062BB RID: 25275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062BB")]
		[Address(RVA = "0x3039248", Offset = "0x3039248", VA = "0x3039248")]
		private void DateIncrement()
		{
		}

		// Token: 0x060062BC RID: 25276 RVA: 0x0004BA68 File Offset: 0x00049C68
		[Token(Token = "0x60062BC")]
		[Address(RVA = "0x30392F8", Offset = "0x30392F8", VA = "0x30392F8")]
		private int DaysInMonth()
		{
			return 0;
		}

		// Token: 0x060062BD RID: 25277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062BD")]
		[Address(RVA = "0x3039378", Offset = "0x3039378", VA = "0x3039378")]
		private void OnValidate()
		{
		}

		// Token: 0x060062BE RID: 25278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062BE")]
		[Address(RVA = "0x3039408", Offset = "0x3039408", VA = "0x3039408")]
		public static void LockTimeline(int timeline = -1)
		{
		}

		// Token: 0x060062BF RID: 25279 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062BF")]
		[Address(RVA = "0x3039514", Offset = "0x3039514", VA = "0x3039514")]
		public static void UnlockTimeline()
		{
		}

		// Token: 0x060062C0 RID: 25280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062C0")]
		[Address(RVA = "0x3038D54", Offset = "0x3038D54", VA = "0x3038D54")]
		private void SetSunAndMoonDirection()
		{
		}

		// Token: 0x060062C1 RID: 25281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062C1")]
		[Address(RVA = "0x3038860", Offset = "0x3038860", VA = "0x3038860")]
		private void SetSunAndMoonRealisticPosition()
		{
		}

		// Token: 0x060062C2 RID: 25282 RVA: 0x0004BA80 File Offset: 0x00049C80
		[Token(Token = "0x60062C2")]
		[Address(RVA = "0x303981C", Offset = "0x303981C", VA = "0x303981C")]
		private Vector3 computeSunPosition(float d, float hour, float m_Sin_Ecl, float m_Cos_Ecl)
		{
			return default(Vector3);
		}

		// Token: 0x060062C3 RID: 25283 RVA: 0x0004BA98 File Offset: 0x00049C98
		[Token(Token = "0x60062C3")]
		[Address(RVA = "0x30399D4", Offset = "0x30399D4", VA = "0x30399D4")]
		private Vector3 computeMoonPosition(float d, float hour, float m_Sin_Ecl, float m_Cos_Ecl)
		{
			return default(Vector3);
		}

		// Token: 0x060062C4 RID: 25284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062C4")]
		[Address(RVA = "0x3039BE8", Offset = "0x3039BE8", VA = "0x3039BE8")]
		private void distanceAndTrueAnomaly(float M, float e, float a, ref float v, ref float r)
		{
		}

		// Token: 0x060062C5 RID: 25285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062C5")]
		[Address(RVA = "0x3039CAC", Offset = "0x3039CAC", VA = "0x3039CAC")]
		private void localSiderealTime(float Longitude_Sun, float Hour)
		{
		}

		// Token: 0x060062C6 RID: 25286 RVA: 0x0004BAB0 File Offset: 0x00049CB0
		[Token(Token = "0x60062C6")]
		[Address(RVA = "0x3039CE0", Offset = "0x3039CE0", VA = "0x3039CE0")]
		private Vector2 azimuthalCoordinates(float RightAscension, float Declination)
		{
			return default(Vector2);
		}

		// Token: 0x060062C7 RID: 25287 RVA: 0x0004BAC8 File Offset: 0x00049CC8
		[Token(Token = "0x60062C7")]
		[Address(RVA = "0x3039D88", Offset = "0x3039D88", VA = "0x3039D88")]
		private Vector3 cartesianCoordinates(Vector2 Phi_Theta)
		{
			return default(Vector3);
		}

		// Token: 0x17000663 RID: 1635
		// (get) Token: 0x060062C8 RID: 25288 RVA: 0x0004BAE0 File Offset: 0x00049CE0
		// (set) Token: 0x060062C9 RID: 25289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000663")]
		public TimeSettingsMode Type
		{
			[Token(Token = "0x60062C8")]
			[Address(RVA = "0x3039DDC", Offset = "0x3039DDC", VA = "0x3039DDC")]
			get
			{
				return TimeSettingsMode.Default;
			}
			[Token(Token = "0x60062C9")]
			[Address(RVA = "0x3039DE4", Offset = "0x3039DE4", VA = "0x3039DE4")]
			set
			{
			}
		}

		// Token: 0x17000664 RID: 1636
		// (get) Token: 0x060062CA RID: 25290 RVA: 0x0004BAF8 File Offset: 0x00049CF8
		// (set) Token: 0x060062CB RID: 25291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000664")]
		public float Timeline
		{
			[Token(Token = "0x60062CA")]
			[Address(RVA = "0x3039DEC", Offset = "0x3039DEC", VA = "0x3039DEC")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60062CB")]
			[Address(RVA = "0x30302B0", Offset = "0x30302B0", VA = "0x30302B0")]
			set
			{
			}
		}

		// Token: 0x17000665 RID: 1637
		// (get) Token: 0x060062CC RID: 25292 RVA: 0x0004BB10 File Offset: 0x00049D10
		// (set) Token: 0x060062CD RID: 25293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000665")]
		public float SunDirection
		{
			[Token(Token = "0x60062CC")]
			[Address(RVA = "0x3030304", Offset = "0x3030304", VA = "0x3030304")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60062CD")]
			[Address(RVA = "0x303030C", Offset = "0x303030C", VA = "0x303030C")]
			set
			{
			}
		}

		// Token: 0x17000666 RID: 1638
		// (get) Token: 0x060062CE RID: 25294 RVA: 0x0004BB28 File Offset: 0x00049D28
		// (set) Token: 0x060062CF RID: 25295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000666")]
		public float SunEquatorOffset
		{
			[Token(Token = "0x60062CE")]
			[Address(RVA = "0x30395DC", Offset = "0x30395DC", VA = "0x30395DC")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60062CF")]
			[Address(RVA = "0x3039DF4", Offset = "0x3039DF4", VA = "0x3039DF4")]
			set
			{
			}
		}

		// Token: 0x17000667 RID: 1639
		// (get) Token: 0x060062D0 RID: 25296 RVA: 0x0004BB40 File Offset: 0x00049D40
		// (set) Token: 0x060062D1 RID: 25297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000667")]
		public float MoonPositionOffset
		{
			[Token(Token = "0x60062D0")]
			[Address(RVA = "0x3039DFC", Offset = "0x3039DFC", VA = "0x3039DFC")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60062D1")]
			[Address(RVA = "0x3039E04", Offset = "0x3039E04", VA = "0x3039E04")]
			set
			{
			}
		}

		// Token: 0x17000668 RID: 1640
		// (get) Token: 0x060062D2 RID: 25298 RVA: 0x0004BB58 File Offset: 0x00049D58
		// (set) Token: 0x060062D3 RID: 25299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000668")]
		public float Latitude
		{
			[Token(Token = "0x60062D2")]
			[Address(RVA = "0x3030314", Offset = "0x3030314", VA = "0x3030314")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60062D3")]
			[Address(RVA = "0x303031C", Offset = "0x303031C", VA = "0x303031C")]
			set
			{
			}
		}

		// Token: 0x17000669 RID: 1641
		// (get) Token: 0x060062D4 RID: 25300 RVA: 0x0004BB70 File Offset: 0x00049D70
		// (set) Token: 0x060062D5 RID: 25301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000669")]
		public float Longitude
		{
			[Token(Token = "0x60062D4")]
			[Address(RVA = "0x30399CC", Offset = "0x30399CC", VA = "0x30399CC")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60062D5")]
			[Address(RVA = "0x3039E0C", Offset = "0x3039E0C", VA = "0x3039E0C")]
			set
			{
			}
		}

		// Token: 0x1700066A RID: 1642
		// (get) Token: 0x060062D6 RID: 25302 RVA: 0x0004BB88 File Offset: 0x00049D88
		// (set) Token: 0x060062D7 RID: 25303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700066A")]
		public int Day
		{
			[Token(Token = "0x60062D6")]
			[Address(RVA = "0x30392E0", Offset = "0x30392E0", VA = "0x30392E0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60062D7")]
			[Address(RVA = "0x30392E8", Offset = "0x30392E8", VA = "0x30392E8")]
			set
			{
			}
		}

		// Token: 0x1700066B RID: 1643
		// (get) Token: 0x060062D8 RID: 25304 RVA: 0x0004BBA0 File Offset: 0x00049DA0
		// (set) Token: 0x060062D9 RID: 25305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700066B")]
		public int Month
		{
			[Token(Token = "0x60062D8")]
			[Address(RVA = "0x3039358", Offset = "0x3039358", VA = "0x3039358")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60062D9")]
			[Address(RVA = "0x3039360", Offset = "0x3039360", VA = "0x3039360")]
			set
			{
			}
		}

		// Token: 0x1700066C RID: 1644
		// (get) Token: 0x060062DA RID: 25306 RVA: 0x0004BBB8 File Offset: 0x00049DB8
		// (set) Token: 0x060062DB RID: 25307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700066C")]
		public int Year
		{
			[Token(Token = "0x60062DA")]
			[Address(RVA = "0x3039370", Offset = "0x3039370", VA = "0x3039370")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60062DB")]
			[Address(RVA = "0x30378F8", Offset = "0x30378F8", VA = "0x30378F8")]
			set
			{
			}
		}

		// Token: 0x1700066D RID: 1645
		// (get) Token: 0x060062DC RID: 25308 RVA: 0x0004BBD0 File Offset: 0x00049DD0
		// (set) Token: 0x060062DD RID: 25309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700066D")]
		public int GMTOffset
		{
			[Token(Token = "0x60062DC")]
			[Address(RVA = "0x3039814", Offset = "0x3039814", VA = "0x3039814")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60062DD")]
			[Address(RVA = "0x3039E34", Offset = "0x3039E34", VA = "0x3039E34")]
			set
			{
			}
		}

		// Token: 0x1700066E RID: 1646
		// (get) Token: 0x060062DE RID: 25310 RVA: 0x0004BBE8 File Offset: 0x00049DE8
		// (set) Token: 0x060062DF RID: 25311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700066E")]
		public bool PlayAtRuntime
		{
			[Token(Token = "0x60062DE")]
			[Address(RVA = "0x3038338", Offset = "0x3038338", VA = "0x3038338")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60062DF")]
			[Address(RVA = "0x3039E48", Offset = "0x3039E48", VA = "0x3039E48")]
			set
			{
			}
		}

		// Token: 0x1700066F RID: 1647
		// (get) Token: 0x060062E0 RID: 25312 RVA: 0x0004BC00 File Offset: 0x00049E00
		// (set) Token: 0x060062E1 RID: 25313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700066F")]
		public float PlaySpeed
		{
			[Token(Token = "0x60062E0")]
			[Address(RVA = "0x3039238", Offset = "0x3039238", VA = "0x3039238")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60062E1")]
			[Address(RVA = "0x3039E54", Offset = "0x3039E54", VA = "0x3039E54")]
			set
			{
			}
		}

		// Token: 0x17000670 RID: 1648
		// (get) Token: 0x060062E2 RID: 25314 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060062E3 RID: 25315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000670")]
		public AnimationCurve CycleSpeedCurve
		{
			[Token(Token = "0x60062E2")]
			[Address(RVA = "0x3039240", Offset = "0x3039240", VA = "0x3039240")]
			get
			{
				return null;
			}
			[Token(Token = "0x60062E3")]
			[Address(RVA = "0x3039E5C", Offset = "0x3039E5C", VA = "0x3039E5C")]
			set
			{
			}
		}

		// Token: 0x17000671 RID: 1649
		// (get) Token: 0x060062E4 RID: 25316 RVA: 0x0004BC18 File Offset: 0x00049E18
		// (set) Token: 0x060062E5 RID: 25317 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000671")]
		public float SteppedInterval
		{
			[Token(Token = "0x60062E4")]
			[Address(RVA = "0x30392D8", Offset = "0x30392D8", VA = "0x30392D8")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60062E5")]
			[Address(RVA = "0x3039E64", Offset = "0x3039E64", VA = "0x3039E64")]
			set
			{
			}
		}

		// Token: 0x060062E6 RID: 25318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062E6")]
		[Address(RVA = "0x3039E6C", Offset = "0x3039E6C", VA = "0x3039E6C")]
		public uSkyTimeline()
		{
		}

		// Token: 0x04002756 RID: 10070
		[Token(Token = "0x4002756")]
		[FieldOffset(Offset = "0x18")]
		public float dayTime;

		// Token: 0x04002757 RID: 10071
		[Token(Token = "0x4002757")]
		[FieldOffset(Offset = "0x1C")]
		public float nightTime;

		// Token: 0x04002759 RID: 10073
		[Token(Token = "0x4002759")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TimeSettingsMode type;

		// Token: 0x0400275A RID: 10074
		[Token(Token = "0x400275A")]
		[FieldOffset(Offset = "0x24")]
		[Space(5f)]
		[Tooltip("Time of the day.")]
		[SerializeField]
		[Range(0f, 24f)]
		private float timeline;

		// Token: 0x0400275B RID: 10075
		[Token(Token = "0x400275B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[HeaderLayout]
		private DefaultTimelineSettings sunAndMoon;

		// Token: 0x0400275C RID: 10076
		[Token(Token = "0x400275C")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		[HeaderLayout]
		private RealisticTimelineSettings locationAndDate;

		// Token: 0x0400275D RID: 10077
		[Token(Token = "0x400275D")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[HeaderLayout]
		private DayNightCycleSettings dayNightCycle;

		// Token: 0x0400275E RID: 10078
		[Token(Token = "0x400275E")]
		[FieldOffset(Offset = "0x68")]
		private Matrix4x4 m_SpaceMatrix;

		// Token: 0x0400275F RID: 10079
		[Token(Token = "0x400275F")]
		[FieldOffset(Offset = "0xA8")]
		private bool m_isAwake;

		// Token: 0x04002760 RID: 10080
		[Token(Token = "0x4002760")]
		[FieldOffset(Offset = "0xAC")]
		[HideInInspector]
		[SerializeField]
		private float m_AccumulatedTime;

		// Token: 0x04002761 RID: 10081
		[Token(Token = "0x4002761")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[HideInInspector]
		private float m_ActualTime;

		// Token: 0x04002762 RID: 10082
		[Token(Token = "0x4002762")]
		[FieldOffset(Offset = "0xB8")]
		private uSkyLighting skyLighting;

		// Token: 0x04002763 RID: 10083
		[Token(Token = "0x4002763")]
		[FieldOffset(Offset = "0xC0")]
		private uSkyClouds2D skyClounds;

		// Token: 0x04002764 RID: 10084
		[Token(Token = "0x4002764")]
		[FieldOffset(Offset = "0xC8")]
		private uSkyPro uskyPro;

		// Token: 0x04002765 RID: 10085
		[Token(Token = "0x4002765")]
		[FieldOffset(Offset = "0xD0")]
		private GameObject playerPointLight;

		// Token: 0x04002766 RID: 10086
		[Token(Token = "0x4002766")]
		[FieldOffset(Offset = "0xD8")]
		private GameObject mainPlayer;

		// Token: 0x04002767 RID: 10087
		[Token(Token = "0x4002767")]
		[FieldOffset(Offset = "0xE0")]
		private Dictionary<int, float> duringTickDic;

		// Token: 0x04002768 RID: 10088
		[Token(Token = "0x4002768")]
		[FieldOffset(Offset = "0xE8")]
		private float pointLightIntensity;

		// Token: 0x04002769 RID: 10089
		[Token(Token = "0x4002769")]
		[FieldOffset(Offset = "0xEC")]
		private int targetTime;

		// Token: 0x0400276A RID: 10090
		[Token(Token = "0x400276A")]
		[FieldOffset(Offset = "0xF0")]
		private bool m_UpdateTimeline;

		// Token: 0x0400276B RID: 10091
		[Token(Token = "0x400276B")]
		[FieldOffset(Offset = "0xF4")]
		private float addTime;

		// Token: 0x0400276C RID: 10092
		[Token(Token = "0x400276C")]
		[FieldOffset(Offset = "0xF8")]
		private bool isPause;

		// Token: 0x0400276D RID: 10093
		[Token(Token = "0x400276D")]
		[FieldOffset(Offset = "0xFC")]
		private int lastState;

		// Token: 0x0400276F RID: 10095
		[Token(Token = "0x400276F")]
		[FieldOffset(Offset = "0x108")]
		[HideInInspector]
		private float m_LST;

		// Token: 0x04002770 RID: 10096
		[Token(Token = "0x4002770")]
		[FieldOffset(Offset = "0x10C")]
		[HideInInspector]
		private float m_Sin_Lat;

		// Token: 0x04002771 RID: 10097
		[Token(Token = "0x4002771")]
		[FieldOffset(Offset = "0x110")]
		[HideInInspector]
		private float m_Cos_Lat;
	}
}
