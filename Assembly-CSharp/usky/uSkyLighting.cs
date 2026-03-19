using System;
using System.Collections.Generic;
using BitBenderGames;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

namespace usky
{
	// Token: 0x02000A10 RID: 2576
	[Token(Token = "0x2000A10")]
	[AddComponentMenu("uSkyPro/uSky Lighting")]
	[ExecuteInEditMode]
	public class uSkyLighting : MonoBehaviour
	{
		// Token: 0x06006248 RID: 25160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006248")]
		[Address(RVA = "0x30326F4", Offset = "0x30326F4", VA = "0x30326F4")]
		private void UpdateSmooth()
		{
		}

		// Token: 0x17000654 RID: 1620
		// (get) Token: 0x06006249 RID: 25161 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000654")]
		private uSkySun m_Sun
		{
			[Token(Token = "0x6006249")]
			[Address(RVA = "0x30326F8", Offset = "0x30326F8", VA = "0x30326F8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000655 RID: 1621
		// (get) Token: 0x0600624A RID: 25162 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000655")]
		private uSkyMoon m_Moon
		{
			[Token(Token = "0x600624A")]
			[Address(RVA = "0x30327CC", Offset = "0x30327CC", VA = "0x30327CC")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600624B RID: 25163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600624B")]
		[Address(RVA = "0x30328A0", Offset = "0x30328A0", VA = "0x30328A0")]
		private void Awake()
		{
		}

		// Token: 0x0600624C RID: 25164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600624C")]
		[Address(RVA = "0x3032B34", Offset = "0x3032B34", VA = "0x3032B34")]
		private void Start()
		{
		}

		// Token: 0x0600624D RID: 25165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600624D")]
		[Address(RVA = "0x3032C70", Offset = "0x3032C70", VA = "0x3032C70")]
		private void OnEnable()
		{
		}

		// Token: 0x0600624E RID: 25166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600624E")]
		[Address(RVA = "0x3032D14", Offset = "0x3032D14", VA = "0x3032D14")]
		private void OnDisable()
		{
		}

		// Token: 0x0600624F RID: 25167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600624F")]
		[Address(RVA = "0x3032E3C", Offset = "0x3032E3C", VA = "0x3032E3C")]
		private void OnDestroy()
		{
		}

		// Token: 0x06006250 RID: 25168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006250")]
		[Address(RVA = "0x3032EE0", Offset = "0x3032EE0", VA = "0x3032EE0")]
		public void Init(int levelID)
		{
		}

		// Token: 0x06006251 RID: 25169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006251")]
		[Address(RVA = "0x3032FB4", Offset = "0x3032FB4", VA = "0x3032FB4")]
		private void RenderSetting(GlobalRenderingSetting.RenderingInfo renderInfo)
		{
		}

		// Token: 0x06006252 RID: 25170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006252")]
		[Address(RVA = "0x30331EC", Offset = "0x30331EC", VA = "0x30331EC")]
		private void RenderObject(ScriptableRenderContext context, Camera cam)
		{
		}

		// Token: 0x06006253 RID: 25171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006253")]
		[Address(RVA = "0x3033594", Offset = "0x3033594", VA = "0x3033594")]
		public void ResetFogParameters()
		{
		}

		// Token: 0x06006254 RID: 25172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006254")]
		[Address(RVA = "0x3033598", Offset = "0x3033598", VA = "0x3033598")]
		private void Update()
		{
		}

		// Token: 0x06006255 RID: 25173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006255")]
		[Address(RVA = "0x3033688", Offset = "0x3033688", VA = "0x3033688")]
		public void SetFogParamInfo(GlobalRenderingSetting.FogInfo fog)
		{
		}

		// Token: 0x06006256 RID: 25174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006256")]
		[Address(RVA = "0x30332E8", Offset = "0x30332E8", VA = "0x30332E8")]
		private void ComputeLightingParams(CommandBuffer cmd)
		{
		}

		// Token: 0x06006257 RID: 25175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006257")]
		[Address(RVA = "0x3032B50", Offset = "0x3032B50", VA = "0x3032B50")]
		private void InitLightComponent()
		{
		}

		// Token: 0x06006258 RID: 25176 RVA: 0x0004B948 File Offset: 0x00049B48
		[Token(Token = "0x6006258")]
		[Address(RVA = "0x30336FC", Offset = "0x30336FC", VA = "0x30336FC")]
		public bool isNight()
		{
			return default(bool);
		}

		// Token: 0x06006259 RID: 25177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006259")]
		[Address(RVA = "0x3033140", Offset = "0x3033140", VA = "0x3033140")]
		public void UpdateLighting()
		{
		}

		// Token: 0x0600625A RID: 25178 RVA: 0x0004B960 File Offset: 0x00049B60
		[Token(Token = "0x600625A")]
		[Address(RVA = "0x30338D8", Offset = "0x30338D8", VA = "0x30338D8")]
		public float MapValue(float value, float fromMin, float fromMax, float toMin, float toMax)
		{
			return 0f;
		}

		// Token: 0x0600625B RID: 25179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600625B")]
		[Address(RVA = "0x3033738", Offset = "0x3033738", VA = "0x3033738")]
		private void ComputeLightingParams()
		{
		}

		// Token: 0x0600625C RID: 25180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600625C")]
		[Address(RVA = "0x3033634", Offset = "0x3033634", VA = "0x3033634")]
		private void AmbientGradientUpdate()
		{
		}

		// Token: 0x17000656 RID: 1622
		// (get) Token: 0x0600625D RID: 25181 RVA: 0x0004B978 File Offset: 0x00049B78
		[Token(Token = "0x17000656")]
		private float SunDirUp
		{
			[Token(Token = "0x600625D")]
			[Address(RVA = "0x30338F4", Offset = "0x30338F4", VA = "0x30338F4")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000657 RID: 1623
		// (get) Token: 0x0600625E RID: 25182 RVA: 0x0004B990 File Offset: 0x00049B90
		[Token(Token = "0x17000657")]
		private float MoonDirUp
		{
			[Token(Token = "0x600625E")]
			[Address(RVA = "0x3033994", Offset = "0x3033994", VA = "0x3033994")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x0600625F RID: 25183 RVA: 0x0004B9A8 File Offset: 0x00049BA8
		[Token(Token = "0x600625F")]
		[Address(RVA = "0x3033A34", Offset = "0x3033A34", VA = "0x3033A34")]
		private float DayTimeBrightness()
		{
			return 0f;
		}

		// Token: 0x06006260 RID: 25184 RVA: 0x0004B9C0 File Offset: 0x00049BC0
		[Token(Token = "0x6006260")]
		[Address(RVA = "0x3033A74", Offset = "0x3033A74", VA = "0x3033A74")]
		public float NightTimeBrightness()
		{
			return 0f;
		}

		// Token: 0x06006261 RID: 25185 RVA: 0x0004B9D8 File Offset: 0x00049BD8
		[Token(Token = "0x6006261")]
		[Address(RVA = "0x3033AB8", Offset = "0x3033AB8", VA = "0x3033AB8")]
		private float MoonFade()
		{
			return 0f;
		}

		// Token: 0x06006262 RID: 25186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006262")]
		[Address(RVA = "0x3032A48", Offset = "0x3032A48", VA = "0x3032A48")]
		private void InitLightingParameters()
		{
		}

		// Token: 0x06006263 RID: 25187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006263")]
		[Address(RVA = "0x3033B84", Offset = "0x3033B84", VA = "0x3033B84")]
		private void SetLightingState()
		{
		}

		// Token: 0x06006264 RID: 25188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006264")]
		[Address(RVA = "0x3033B88", Offset = "0x3033B88", VA = "0x3033B88")]
		private void SetSunIntensity(float NewIntensity)
		{
		}

		// Token: 0x06006265 RID: 25189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006265")]
		[Address(RVA = "0x3033C94", Offset = "0x3033C94", VA = "0x3033C94")]
		private void SetMoonIntensity(float NewIntensity)
		{
		}

		// Token: 0x06006266 RID: 25190 RVA: 0x0004B9F0 File Offset: 0x00049BF0
		[Token(Token = "0x6006266")]
		[Address(RVA = "0x3033D10", Offset = "0x3033D10", VA = "0x3033D10")]
		private Vector2 CalcTargetPosi(Vector3 targetPosition)
		{
			return default(Vector2);
		}

		// Token: 0x06006267 RID: 25191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006267")]
		[Address(RVA = "0x3033DD0", Offset = "0x3033DD0", VA = "0x3033DD0")]
		public void Load(int targetX, int targetY)
		{
		}

		// Token: 0x06006268 RID: 25192 RVA: 0x0004BA08 File Offset: 0x00049C08
		[Token(Token = "0x6006268")]
		[Address(RVA = "0x30342E0", Offset = "0x30342E0", VA = "0x30342E0")]
		private bool isTerrainIsLoaded()
		{
			return default(bool);
		}

		// Token: 0x06006269 RID: 25193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006269")]
		[Address(RVA = "0x30343D0", Offset = "0x30343D0", VA = "0x30343D0")]
		private void OnUpdateRainSplash()
		{
		}

		// Token: 0x0600626A RID: 25194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600626A")]
		[Address(RVA = "0x3032A4C", Offset = "0x3032A4C", VA = "0x3032A4C")]
		private void InitRain()
		{
		}

		// Token: 0x0600626B RID: 25195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600626B")]
		[Address(RVA = "0x3032EA4", Offset = "0x3032EA4", VA = "0x3032EA4")]
		private void DestroyRain()
		{
		}

		// Token: 0x0600626C RID: 25196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600626C")]
		[Address(RVA = "0x303445C", Offset = "0x303445C", VA = "0x303445C")]
		private void Rain()
		{
		}

		// Token: 0x0600626D RID: 25197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600626D")]
		[Address(RVA = "0x3034568", Offset = "0x3034568", VA = "0x3034568")]
		private void Cloud()
		{
		}

		// Token: 0x0600626E RID: 25198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600626E")]
		[Address(RVA = "0x30346DC", Offset = "0x30346DC", VA = "0x30346DC")]
		public void OnDestroyScene()
		{
		}

		// Token: 0x0600626F RID: 25199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600626F")]
		[Address(RVA = "0x3032BE8", Offset = "0x3032BE8", VA = "0x3032BE8")]
		private void ToggleFog(bool isToggle)
		{
		}

		// Token: 0x06006270 RID: 25200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006270")]
		[Address(RVA = "0x3034868", Offset = "0x3034868", VA = "0x3034868")]
		public void SetWeather(int state, bool isAuto = false)
		{
		}

		// Token: 0x06006271 RID: 25201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006271")]
		[Address(RVA = "0x3034870", Offset = "0x3034870", VA = "0x3034870")]
		public void SetWeather(WeatherState state, bool isAuto = false)
		{
		}

		// Token: 0x06006272 RID: 25202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006272")]
		[Address(RVA = "0x30349C4", Offset = "0x30349C4", VA = "0x30349C4")]
		private void OnChangeWeather()
		{
		}

		// Token: 0x06006273 RID: 25203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006273")]
		[Address(RVA = "0x3034A78", Offset = "0x3034A78", VA = "0x3034A78")]
		public void SetSeason(string seasonId)
		{
		}

		// Token: 0x06006274 RID: 25204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006274")]
		[Address(RVA = "0x3034C44", Offset = "0x3034C44", VA = "0x3034C44")]
		private void ApplySeasonConfig(SkySeasonConfig config)
		{
		}

		// Token: 0x06006275 RID: 25205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006275")]
		[Address(RVA = "0x3034D28", Offset = "0x3034D28", VA = "0x3034D28")]
		public void OnUpdateTestWeather()
		{
		}

		// Token: 0x06006276 RID: 25206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006276")]
		[Address(RVA = "0x3034D70", Offset = "0x3034D70", VA = "0x3034D70")]
		public uSkyLighting()
		{
		}

		// Token: 0x04002673 RID: 9843
		[Token(Token = "0x4002673")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SkySeasonConfigManager seasonConfigManager;

		// Token: 0x04002674 RID: 9844
		[Token(Token = "0x4002674")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		public GlobalRenderingSetting renderConfig;

		// Token: 0x04002675 RID: 9845
		[Token(Token = "0x4002675")]
		[FieldOffset(Offset = "0x28")]
		private Light m_lightComponent;

		// Token: 0x04002676 RID: 9846
		[Token(Token = "0x4002676")]
		[FieldOffset(Offset = "0x30")]
		private float m_sunElevation;

		// Token: 0x04002677 RID: 9847
		[Token(Token = "0x4002677")]
		[FieldOffset(Offset = "0x34")]
		public float lightIntensity;

		// Token: 0x04002678 RID: 9848
		[Token(Token = "0x4002678")]
		[FieldOffset(Offset = "0x38")]
		public float bakeLightIntensity;

		// Token: 0x04002679 RID: 9849
		[Token(Token = "0x4002679")]
		[FieldOffset(Offset = "0x3C")]
		public float decalIntensity;

		// Token: 0x0400267A RID: 9850
		[Token(Token = "0x400267A")]
		[FieldOffset(Offset = "0x40")]
		public float decalHeight;

		// Token: 0x0400267B RID: 9851
		[Token(Token = "0x400267B")]
		[FieldOffset(Offset = "0x48")]
		public AnimationCurve lightIntensityCurve;

		// Token: 0x0400267C RID: 9852
		[Token(Token = "0x400267C")]
		[FieldOffset(Offset = "0x50")]
		public Color lightColor;

		// Token: 0x0400267D RID: 9853
		[Token(Token = "0x400267D")]
		[FieldOffset(Offset = "0x60")]
		public Gradient lightGradientColor;

		// Token: 0x0400267E RID: 9854
		[Token(Token = "0x400267E")]
		[FieldOffset(Offset = "0x68")]
		public AnimationCurve bakeMap_lightIntensityCurve;

		// Token: 0x0400267F RID: 9855
		[Token(Token = "0x400267F")]
		[FieldOffset(Offset = "0x70")]
		public Color bakeMap_lightColor;

		// Token: 0x04002680 RID: 9856
		[Token(Token = "0x4002680")]
		[FieldOffset(Offset = "0x80")]
		public Gradient bakeMap_lightGradientColor;

		// Token: 0x04002681 RID: 9857
		[Token(Token = "0x4002681")]
		[FieldOffset(Offset = "0x88")]
		public AnimationCurve hero_lightIntensityCurve;

		// Token: 0x04002682 RID: 9858
		[Token(Token = "0x4002682")]
		[FieldOffset(Offset = "0x90")]
		public Color hero_lightColor;

		// Token: 0x04002683 RID: 9859
		[Token(Token = "0x4002683")]
		[FieldOffset(Offset = "0xA0")]
		public Gradient hero_lightGradientColor;

		// Token: 0x04002684 RID: 9860
		[Token(Token = "0x4002684")]
		[FieldOffset(Offset = "0xA8")]
		public Color rainSkyColor;

		// Token: 0x04002685 RID: 9861
		[Token(Token = "0x4002685")]
		[FieldOffset(Offset = "0xB8")]
		public Gradient rainSkyGradientColor;

		// Token: 0x04002686 RID: 9862
		[Token(Token = "0x4002686")]
		[FieldOffset(Offset = "0xC0")]
		public float ambientIntensity;

		// Token: 0x04002687 RID: 9863
		[Token(Token = "0x4002687")]
		[FieldOffset(Offset = "0xC8")]
		public AnimationCurve ambientIntensityCurve;

		// Token: 0x04002688 RID: 9864
		[Token(Token = "0x4002688")]
		[FieldOffset(Offset = "0xD0")]
		public Color ambientSkyColor;

		// Token: 0x04002689 RID: 9865
		[Token(Token = "0x4002689")]
		[FieldOffset(Offset = "0xE0")]
		public Color equatorSkyColor;

		// Token: 0x0400268A RID: 9866
		[Token(Token = "0x400268A")]
		[FieldOffset(Offset = "0xF0")]
		public Color groundSkyColor;

		// Token: 0x0400268B RID: 9867
		[Token(Token = "0x400268B")]
		[FieldOffset(Offset = "0x100")]
		public Gradient ambientSkyGradientColor;

		// Token: 0x0400268C RID: 9868
		[Token(Token = "0x400268C")]
		[FieldOffset(Offset = "0x108")]
		public Gradient equatorSkyGradientColor;

		// Token: 0x0400268D RID: 9869
		[Token(Token = "0x400268D")]
		[FieldOffset(Offset = "0x110")]
		public Gradient groundSkyGradientColor;

		// Token: 0x0400268E RID: 9870
		[Token(Token = "0x400268E")]
		[FieldOffset(Offset = "0x118")]
		private float m_gradientTime;

		// Token: 0x0400268F RID: 9871
		[Token(Token = "0x400268F")]
		[FieldOffset(Offset = "0x120")]
		private uSkyTimeline skyTimeLine;

		// Token: 0x04002690 RID: 9872
		[Token(Token = "0x4002690")]
		[FieldOffset(Offset = "0x128")]
		public float lightSpeed;

		// Token: 0x04002691 RID: 9873
		[Token(Token = "0x4002691")]
		[FieldOffset(Offset = "0x12C")]
		[Header("Fog设置")]
		public bool toggleFog;

		// Token: 0x04002692 RID: 9874
		[Token(Token = "0x4002692")]
		[FieldOffset(Offset = "0x130")]
		public Color _FogColor;

		// Token: 0x04002693 RID: 9875
		[Token(Token = "0x4002693")]
		[FieldOffset(Offset = "0x140")]
		[Tooltip("雾颜色随时间变化")]
		public Gradient fogGradientColor;

		// Token: 0x04002694 RID: 9876
		[Token(Token = "0x4002694")]
		[FieldOffset(Offset = "0x148")]
		[Tooltip("雾浓度")]
		public float _FogGlobalDensity;

		// Token: 0x04002695 RID: 9877
		[Token(Token = "0x4002695")]
		[FieldOffset(Offset = "0x14C")]
		[Tooltip("高度衰减：距离地面多高开始衰减")]
		[Space(10f)]
		public float _FogHeight;

		// Token: 0x04002696 RID: 9878
		[Token(Token = "0x4002696")]
		[FieldOffset(Offset = "0x150")]
		[Tooltip("高度衰减：衰减幅度")]
		public float _FogFallOff;

		// Token: 0x04002697 RID: 9879
		[Token(Token = "0x4002697")]
		[FieldOffset(Offset = "0x154")]
		[Space(10f)]
		[Tooltip("距离衰减：离相机多远开始衰减")]
		public float _FogStartDis;

		// Token: 0x04002698 RID: 9880
		[Token(Token = "0x4002698")]
		[FieldOffset(Offset = "0x158")]
		[Tooltip("距离衰减：离相机多远停止衰减")]
		public float _FogGradientDis;

		// Token: 0x04002699 RID: 9881
		[Token(Token = "0x4002699")]
		[FieldOffset(Offset = "0x15C")]
		[Tooltip("雾：重新映射最小值")]
		[Range(0f, 1f)]
		[Space(10f)]
		public float _FogStart;

		// Token: 0x0400269A RID: 9882
		[Token(Token = "0x400269A")]
		[FieldOffset(Offset = "0x160")]
		[Tooltip("雾：重新映射最大值")]
		[Range(0f, 1f)]
		public float _FogEnd;

		// Token: 0x0400269B RID: 9883
		[Token(Token = "0x400269B")]
		[FieldOffset(Offset = "0x164")]
		public float _FogInscatteringExp;

		// Token: 0x0400269C RID: 9884
		[Token(Token = "0x400269C")]
		[FieldOffset(Offset = "0x168")]
		public Vector4 _FogDir;

		// Token: 0x0400269D RID: 9885
		[Token(Token = "0x400269D")]
		[FieldOffset(Offset = "0x178")]
		[Space(20f)]
		public GameObject target;

		// Token: 0x0400269E RID: 9886
		[Token(Token = "0x400269E")]
		[FieldOffset(Offset = "0x180")]
		private bool fogDirt;

		// Token: 0x0400269F RID: 9887
		[Token(Token = "0x400269F")]
		[FieldOffset(Offset = "0x0")]
		private static int int_FogColor;

		// Token: 0x040026A0 RID: 9888
		[Token(Token = "0x40026A0")]
		[FieldOffset(Offset = "0x4")]
		private static int in_FogStart;

		// Token: 0x040026A1 RID: 9889
		[Token(Token = "0x40026A1")]
		[FieldOffset(Offset = "0x8")]
		private static int in_FogEnd;

		// Token: 0x040026A2 RID: 9890
		[Token(Token = "0x40026A2")]
		[FieldOffset(Offset = "0xC")]
		private static int int_FogMaxHeight;

		// Token: 0x040026A3 RID: 9891
		[Token(Token = "0x40026A3")]
		[FieldOffset(Offset = "0x10")]
		private static int int_FogMinHeight;

		// Token: 0x040026A4 RID: 9892
		[Token(Token = "0x40026A4")]
		[FieldOffset(Offset = "0x14")]
		private static int int_FogDir;

		// Token: 0x040026A5 RID: 9893
		[Token(Token = "0x40026A5")]
		[FieldOffset(Offset = "0x18")]
		public static int int_FogGlobalDensity;

		// Token: 0x040026A6 RID: 9894
		[Token(Token = "0x40026A6")]
		[FieldOffset(Offset = "0x1C")]
		public static int int_FogFallOff;

		// Token: 0x040026A7 RID: 9895
		[Token(Token = "0x40026A7")]
		[FieldOffset(Offset = "0x20")]
		public static int int_FogHeight;

		// Token: 0x040026A8 RID: 9896
		[Token(Token = "0x40026A8")]
		[FieldOffset(Offset = "0x24")]
		public static int int_FogStartDis;

		// Token: 0x040026A9 RID: 9897
		[Token(Token = "0x40026A9")]
		[FieldOffset(Offset = "0x28")]
		public static int int_FogInscatteringExp;

		// Token: 0x040026AA RID: 9898
		[Token(Token = "0x40026AA")]
		[FieldOffset(Offset = "0x2C")]
		public static int int_FogGradientDis;

		// Token: 0x040026AB RID: 9899
		[Token(Token = "0x40026AB")]
		[FieldOffset(Offset = "0x30")]
		public static int int_decal_intensity;

		// Token: 0x040026AC RID: 9900
		[Token(Token = "0x40026AC")]
		[FieldOffset(Offset = "0x34")]
		public static int int_decal_height;

		// Token: 0x040026AD RID: 9901
		[Token(Token = "0x40026AD")]
		[FieldOffset(Offset = "0x184")]
		private LightShadows lastShadow;

		// Token: 0x040026AE RID: 9902
		[Token(Token = "0x40026AE")]
		[FieldOffset(Offset = "0x38")]
		private static string fogKeyWords;

		// Token: 0x040026AF RID: 9903
		[Token(Token = "0x40026AF")]
		[FieldOffset(Offset = "0x188")]
		private MobileTouchCamera touchCamera;

		// Token: 0x040026B0 RID: 9904
		[Token(Token = "0x40026B0")]
		[FieldOffset(Offset = "0x190")]
		private bool isLightGradientUpdate;

		// Token: 0x040026B1 RID: 9905
		[Token(Token = "0x40026B1")]
		public const string rainEffectPath = "Assets/_Art_LastDay/Effect/Prefab/Eff_rain.prefab";

		// Token: 0x040026B2 RID: 9906
		[Token(Token = "0x40026B2")]
		public const string ranSplashEffectPath = "Assets/_Art_LastDay/Effect/Prefab/Eff_rainsplash.prefab";

		// Token: 0x040026B3 RID: 9907
		[Token(Token = "0x40026B3")]
		private const int weatherCheckTime = 180;

		// Token: 0x040026B4 RID: 9908
		[Token(Token = "0x40026B4")]
		[FieldOffset(Offset = "0x194")]
		private float checkTimeDuring;

		// Token: 0x040026B5 RID: 9909
		[Token(Token = "0x40026B5")]
		[FieldOffset(Offset = "0x198")]
		private float rainKeepTime;

		// Token: 0x040026B6 RID: 9910
		[Token(Token = "0x40026B6")]
		[FieldOffset(Offset = "0x19C")]
		private float rainStartTime;

		// Token: 0x040026B7 RID: 9911
		[Token(Token = "0x40026B7")]
		[FieldOffset(Offset = "0x1A0")]
		private WeatherState weatherState;

		// Token: 0x040026B8 RID: 9912
		[Token(Token = "0x40026B8")]
		[FieldOffset(Offset = "0x1A4")]
		public float flashIntensity;

		// Token: 0x040026B9 RID: 9913
		[Token(Token = "0x40026B9")]
		[FieldOffset(Offset = "0x1A8")]
		private bool isAutoWeather;

		// Token: 0x040026BA RID: 9914
		[Token(Token = "0x40026BA")]
		[FieldOffset(Offset = "0x1B0")]
		private Volume m_volume;

		// Token: 0x040026BB RID: 9915
		[Token(Token = "0x40026BB")]
		[FieldOffset(Offset = "0x1B8")]
		private ColorAdjustments colorAdjustments;

		// Token: 0x040026BC RID: 9916
		[Token(Token = "0x40026BC")]
		[FieldOffset(Offset = "0x1C0")]
		private uSkySun m_sun;

		// Token: 0x040026BD RID: 9917
		[Token(Token = "0x40026BD")]
		[FieldOffset(Offset = "0x1C8")]
		private uSkyMoon m_moon;

		// Token: 0x040026BE RID: 9918
		[Token(Token = "0x40026BE")]
		[FieldOffset(Offset = "0x1D0")]
		private Light sunLight;

		// Token: 0x040026BF RID: 9919
		[Token(Token = "0x40026BF")]
		[FieldOffset(Offset = "0x1D8")]
		private Light moonLight;

		// Token: 0x040026C0 RID: 9920
		[Token(Token = "0x40026C0")]
		[FieldOffset(Offset = "0x1E0")]
		[HideInInspector]
		private float normalizedTime;

		// Token: 0x040026C1 RID: 9921
		[Token(Token = "0x40026C1")]
		[FieldOffset(Offset = "0x1E4")]
		[HideInInspector]
		private float exposureScale;

		// Token: 0x040026C2 RID: 9922
		[Token(Token = "0x40026C2")]
		[FieldOffset(Offset = "0x1E8")]
		private Material fogMat;

		// Token: 0x040026C3 RID: 9923
		[Token(Token = "0x40026C3")]
		[FieldOffset(Offset = "0x1F0")]
		private uSkyLighting.SkyBrightness skyBrightness;

		// Token: 0x040026C4 RID: 9924
		[Token(Token = "0x40026C4")]
		[FieldOffset(Offset = "0x1F8")]
		private uSkyLighting.LightingColor lightingColor;

		// Token: 0x040026C5 RID: 9925
		[Token(Token = "0x40026C5")]
		[FieldOffset(Offset = "0x238")]
		private bool IsTimePass;

		// Token: 0x040026C6 RID: 9926
		[Token(Token = "0x40026C6")]
		[FieldOffset(Offset = "0x239")]
		public bool IsLevel;

		// Token: 0x040026C7 RID: 9927
		[Token(Token = "0x40026C7")]
		[FieldOffset(Offset = "0x23A")]
		public bool IsDynamicModifyFog;

		// Token: 0x040026C8 RID: 9928
		[Token(Token = "0x40026C8")]
		[FieldOffset(Offset = "0x23C")]
		private float m_timeline;

		// Token: 0x040026C9 RID: 9929
		[Token(Token = "0x40026C9")]
		[FieldOffset(Offset = "0x240")]
		private float heroLighIntensity;

		// Token: 0x040026CA RID: 9930
		[Token(Token = "0x40026CA")]
		[FieldOffset(Offset = "0x244")]
		[HideInInspector]
		private float m_SunIntensity;

		// Token: 0x040026CB RID: 9931
		[Token(Token = "0x40026CB")]
		[FieldOffset(Offset = "0x248")]
		[HideInInspector]
		private float m_MoonIntensity;

		// Token: 0x040026CC RID: 9932
		[Token(Token = "0x40026CC")]
		[FieldOffset(Offset = "0x24C")]
		private int splashWidth;

		// Token: 0x040026CD RID: 9933
		[Token(Token = "0x40026CD")]
		[FieldOffset(Offset = "0x250")]
		private int splashHeight;

		// Token: 0x040026CE RID: 9934
		[Token(Token = "0x40026CE")]
		[FieldOffset(Offset = "0x254")]
		private int encircleLen;

		// Token: 0x040026CF RID: 9935
		[Token(Token = "0x40026CF")]
		[FieldOffset(Offset = "0x258")]
		private int targetX;

		// Token: 0x040026D0 RID: 9936
		[Token(Token = "0x40026D0")]
		[FieldOffset(Offset = "0x25C")]
		private int targetY;

		// Token: 0x040026D1 RID: 9937
		[Token(Token = "0x40026D1")]
		[FieldOffset(Offset = "0x260")]
		private int[,] posArr;

		// Token: 0x040026D2 RID: 9938
		[Token(Token = "0x40026D2")]
		[FieldOffset(Offset = "0x268")]
		private int max;

		// Token: 0x040026D3 RID: 9939
		[Token(Token = "0x40026D3")]
		[FieldOffset(Offset = "0x270")]
		private Dictionary<int, InstanceRequest> ranSplashObject;

		// Token: 0x040026D4 RID: 9940
		[Token(Token = "0x40026D4")]
		[FieldOffset(Offset = "0x278")]
		private List<int> inRangeList;

		// Token: 0x040026D5 RID: 9941
		[Token(Token = "0x40026D5")]
		[FieldOffset(Offset = "0x280")]
		private GameObject terrainCenter;

		// Token: 0x040026D6 RID: 9942
		[Token(Token = "0x40026D6")]
		[FieldOffset(Offset = "0x288")]
		private InstanceRequest rainRequest;

		// Token: 0x040026D7 RID: 9943
		[Token(Token = "0x40026D7")]
		[FieldOffset(Offset = "0x290")]
		private bool useFog;

		// Token: 0x040026D8 RID: 9944
		[Token(Token = "0x40026D8")]
		[FieldOffset(Offset = "0x291")]
		public bool isRain;

		// Token: 0x040026D9 RID: 9945
		[Token(Token = "0x40026D9")]
		[FieldOffset(Offset = "0x292")]
		public bool isClound;

		// Token: 0x02000A11 RID: 2577
		[Token(Token = "0x2000A11")]
		public static class Uniforms
		{
			// Token: 0x040026DA RID: 9946
			[Token(Token = "0x40026DA")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly int _FogDistance;

			// Token: 0x040026DB RID: 9947
			[Token(Token = "0x40026DB")]
			[FieldOffset(Offset = "0x4")]
			internal static readonly int _FogBlend;

			// Token: 0x040026DC RID: 9948
			[Token(Token = "0x40026DC")]
			[FieldOffset(Offset = "0x8")]
			internal static readonly int _MieDistance;

			// Token: 0x040026DD RID: 9949
			[Token(Token = "0x40026DD")]
			[FieldOffset(Offset = "0xC")]
			internal static readonly int _DistanceFogColor;

			// Token: 0x040026DE RID: 9950
			[Token(Token = "0x40026DE")]
			[FieldOffset(Offset = "0x10")]
			internal static readonly int _DistanceFogStart;

			// Token: 0x040026DF RID: 9951
			[Token(Token = "0x40026DF")]
			[FieldOffset(Offset = "0x14")]
			internal static readonly int _DistanceFogEnd;

			// Token: 0x040026E0 RID: 9952
			[Token(Token = "0x40026E0")]
			[FieldOffset(Offset = "0x18")]
			internal static readonly int _HeightFogStart;

			// Token: 0x040026E1 RID: 9953
			[Token(Token = "0x40026E1")]
			[FieldOffset(Offset = "0x1C")]
			internal static readonly int _HeightFogEnd;

			// Token: 0x040026E2 RID: 9954
			[Token(Token = "0x40026E2")]
			[FieldOffset(Offset = "0x20")]
			internal static readonly int _CloundAttenuation;

			// Token: 0x040026E3 RID: 9955
			[Token(Token = "0x40026E3")]
			[FieldOffset(Offset = "0x24")]
			internal static readonly int _SkyColorMultiplier;

			// Token: 0x040026E4 RID: 9956
			[Token(Token = "0x40026E4")]
			[FieldOffset(Offset = "0x28")]
			internal static readonly int _CloundExposure;

			// Token: 0x040026E5 RID: 9957
			[Token(Token = "0x40026E5")]
			[FieldOffset(Offset = "0x2C")]
			internal static readonly int _LightColor0;

			// Token: 0x040026E6 RID: 9958
			[Token(Token = "0x40026E6")]
			[FieldOffset(Offset = "0x30")]
			internal static readonly int _LightIntensity0;

			// Token: 0x040026E7 RID: 9959
			[Token(Token = "0x40026E7")]
			[FieldOffset(Offset = "0x34")]
			internal static readonly int _LightIntensity1;

			// Token: 0x040026E8 RID: 9960
			[Token(Token = "0x40026E8")]
			[FieldOffset(Offset = "0x38")]
			internal static readonly int _FogLightning;

			// Token: 0x040026E9 RID: 9961
			[Token(Token = "0x40026E9")]
			[FieldOffset(Offset = "0x3C")]
			internal static readonly int _RoleColor;

			// Token: 0x040026EA RID: 9962
			[Token(Token = "0x40026EA")]
			[FieldOffset(Offset = "0x40")]
			internal static readonly int Timeline;
		}

		// Token: 0x02000A12 RID: 2578
		[Token(Token = "0x2000A12")]
		private struct SkyBrightness
		{
			// Token: 0x040026EB RID: 9963
			[Token(Token = "0x40026EB")]
			[FieldOffset(Offset = "0x0")]
			public float daySky;

			// Token: 0x040026EC RID: 9964
			[Token(Token = "0x40026EC")]
			[FieldOffset(Offset = "0x4")]
			public float nightSky;
		}

		// Token: 0x02000A13 RID: 2579
		[Token(Token = "0x2000A13")]
		private struct LightingColor
		{
			// Token: 0x040026ED RID: 9965
			[Token(Token = "0x40026ED")]
			[FieldOffset(Offset = "0x0")]
			public Color lightColor;

			// Token: 0x040026EE RID: 9966
			[Token(Token = "0x40026EE")]
			[FieldOffset(Offset = "0x10")]
			public Color skyColor;

			// Token: 0x040026EF RID: 9967
			[Token(Token = "0x40026EF")]
			[FieldOffset(Offset = "0x20")]
			public Color equatorColor;

			// Token: 0x040026F0 RID: 9968
			[Token(Token = "0x40026F0")]
			[FieldOffset(Offset = "0x30")]
			public Color groundColor;
		}
	}
}
