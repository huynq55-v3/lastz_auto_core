using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

namespace usky
{
	// Token: 0x02000A0B RID: 2571
	[Token(Token = "0x2000A0B")]
	[DisallowMultipleComponent]
	[AddComponentMenu("uSkyPro/uSky Atmospherics Scattering")]
	[ExecuteInEditMode]
	public class uSkyAtmosphericScattering : MonoBehaviour
	{
		// Token: 0x17000648 RID: 1608
		// (get) Token: 0x0600621B RID: 25115 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600621C RID: 25116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000648")]
		public static uSkyAtmosphericScattering instance
		{
			[Token(Token = "0x600621B")]
			[Address(RVA = "0x3030C98", Offset = "0x3030C98", VA = "0x3030C98")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600621C")]
			[Address(RVA = "0x3030CE0", Offset = "0x3030CE0", VA = "0x3030CE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000649 RID: 1609
		// (get) Token: 0x0600621D RID: 25117 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000649")]
		private uSkySun activeSun
		{
			[Token(Token = "0x600621D")]
			[Address(RVA = "0x3030D38", Offset = "0x3030D38", VA = "0x3030D38")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600621E RID: 25118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600621E")]
		[Address(RVA = "0x3030D80", Offset = "0x3030D80", VA = "0x3030D80")]
		private void Awake()
		{
		}

		// Token: 0x0600621F RID: 25119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600621F")]
		[Address(RVA = "0x3031134", Offset = "0x3031134", VA = "0x3031134")]
		private void OnEnable()
		{
		}

		// Token: 0x06006220 RID: 25120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006220")]
		[Address(RVA = "0x3031580", Offset = "0x3031580", VA = "0x3031580")]
		private void EnsureHookedLightSource(Light light)
		{
		}

		// Token: 0x06006221 RID: 25121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006221")]
		[Address(RVA = "0x3031758", Offset = "0x3031758", VA = "0x3031758")]
		private void OnDisable()
		{
		}

		// Token: 0x06006222 RID: 25122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006222")]
		[Address(RVA = "0x30317C4", Offset = "0x30317C4", VA = "0x30317C4")]
		public void OnValidate()
		{
		}

		// Token: 0x06006223 RID: 25123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006223")]
		[Address(RVA = "0x3031844", Offset = "0x3031844", VA = "0x3031844")]
		private void OnWillRenderObject()
		{
		}

		// Token: 0x06006224 RID: 25124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006224")]
		[Address(RVA = "0x3031478", Offset = "0x3031478", VA = "0x3031478")]
		private void UpdateAtmosphereUniform()
		{
		}

		// Token: 0x1700064A RID: 1610
		// (get) Token: 0x06006225 RID: 25125 RVA: 0x0004B858 File Offset: 0x00049A58
		// (set) Token: 0x06006226 RID: 25126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700064A")]
		public bool EnableScattering
		{
			[Token(Token = "0x6006225")]
			[Address(RVA = "0x3030B10", Offset = "0x3030B10", VA = "0x3030B10")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6006226")]
			[Address(RVA = "0x3031C38", Offset = "0x3031C38", VA = "0x3031C38")]
			set
			{
			}
		}

		// Token: 0x1700064B RID: 1611
		// (get) Token: 0x06006227 RID: 25127 RVA: 0x0004B870 File Offset: 0x00049A70
		// (set) Token: 0x06006228 RID: 25128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700064B")]
		public float ScatteringIntensity
		{
			[Token(Token = "0x6006227")]
			[Address(RVA = "0x3031804", Offset = "0x3031804", VA = "0x3031804")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6006228")]
			[Address(RVA = "0x303180C", Offset = "0x303180C", VA = "0x303180C")]
			set
			{
			}
		}

		// Token: 0x1700064C RID: 1612
		// (get) Token: 0x06006229 RID: 25129 RVA: 0x0004B888 File Offset: 0x00049A88
		// (set) Token: 0x0600622A RID: 25130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700064C")]
		public float ScatterExtinction
		{
			[Token(Token = "0x6006229")]
			[Address(RVA = "0x3031814", Offset = "0x3031814", VA = "0x3031814")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600622A")]
			[Address(RVA = "0x303181C", Offset = "0x303181C", VA = "0x303181C")]
			set
			{
			}
		}

		// Token: 0x1700064D RID: 1613
		// (get) Token: 0x0600622B RID: 25131 RVA: 0x0004B8A0 File Offset: 0x00049AA0
		// (set) Token: 0x0600622C RID: 25132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700064D")]
		public float WorldScatterScale
		{
			[Token(Token = "0x600622B")]
			[Address(RVA = "0x3031824", Offset = "0x3031824", VA = "0x3031824")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600622C")]
			[Address(RVA = "0x303182C", Offset = "0x303182C", VA = "0x303182C")]
			set
			{
			}
		}

		// Token: 0x1700064E RID: 1614
		// (get) Token: 0x0600622D RID: 25133 RVA: 0x0004B8B8 File Offset: 0x00049AB8
		// (set) Token: 0x0600622E RID: 25134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700064E")]
		public float NearScatterPush
		{
			[Token(Token = "0x600622D")]
			[Address(RVA = "0x3031834", Offset = "0x3031834", VA = "0x3031834")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600622E")]
			[Address(RVA = "0x303183C", Offset = "0x303183C", VA = "0x303183C")]
			set
			{
			}
		}

		// Token: 0x1700064F RID: 1615
		// (get) Token: 0x0600622F RID: 25135 RVA: 0x0004B8D0 File Offset: 0x00049AD0
		// (set) Token: 0x06006230 RID: 25136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700064F")]
		public bool UseOcclusion
		{
			[Token(Token = "0x600622F")]
			[Address(RVA = "0x3030B20", Offset = "0x3030B20", VA = "0x3030B20")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6006230")]
			[Address(RVA = "0x3031C44", Offset = "0x3031C44", VA = "0x3031C44")]
			set
			{
			}
		}

		// Token: 0x17000650 RID: 1616
		// (get) Token: 0x06006231 RID: 25137 RVA: 0x0004B8E8 File Offset: 0x00049AE8
		// (set) Token: 0x06006232 RID: 25138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000650")]
		public float OcclusionDarkness
		{
			[Token(Token = "0x6006231")]
			[Address(RVA = "0x3031C30", Offset = "0x3031C30", VA = "0x3031C30")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6006232")]
			[Address(RVA = "0x3031C50", Offset = "0x3031C50", VA = "0x3031C50")]
			set
			{
			}
		}

		// Token: 0x17000651 RID: 1617
		// (get) Token: 0x06006233 RID: 25139 RVA: 0x0004B900 File Offset: 0x00049B00
		// (set) Token: 0x06006234 RID: 25140 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000651")]
		public OcclusionDownscaleMode OcclusionDownscale
		{
			[Token(Token = "0x6006233")]
			[Address(RVA = "0x3031C20", Offset = "0x3031C20", VA = "0x3031C20")]
			get
			{
				return (OcclusionDownscaleMode)0;
			}
			[Token(Token = "0x6006234")]
			[Address(RVA = "0x3031C58", Offset = "0x3031C58", VA = "0x3031C58")]
			set
			{
			}
		}

		// Token: 0x17000652 RID: 1618
		// (get) Token: 0x06006235 RID: 25141 RVA: 0x0004B918 File Offset: 0x00049B18
		// (set) Token: 0x06006236 RID: 25142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000652")]
		public OcclusionSamplesMode OcclusionSamples
		{
			[Token(Token = "0x6006235")]
			[Address(RVA = "0x3031C28", Offset = "0x3031C28", VA = "0x3031C28")]
			get
			{
				return OcclusionSamplesMode.x64;
			}
			[Token(Token = "0x6006236")]
			[Address(RVA = "0x3031C60", Offset = "0x3031C60", VA = "0x3031C60")]
			set
			{
			}
		}

		// Token: 0x17000653 RID: 1619
		// (get) Token: 0x06006237 RID: 25143 RVA: 0x0004B930 File Offset: 0x00049B30
		// (set) Token: 0x06006238 RID: 25144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000653")]
		public bool OcclusionDebug
		{
			[Token(Token = "0x6006237")]
			[Address(RVA = "0x3030B18", Offset = "0x3030B18", VA = "0x3030B18")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6006238")]
			[Address(RVA = "0x3031C68", Offset = "0x3031C68", VA = "0x3031C68")]
			set
			{
			}
		}

		// Token: 0x06006239 RID: 25145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006239")]
		[Address(RVA = "0x3031C74", Offset = "0x3031C74", VA = "0x3031C74")]
		public uSkyAtmosphericScattering()
		{
		}

		// Token: 0x04002657 RID: 9815
		[Token(Token = "0x4002657")]
		[FieldOffset(Offset = "0x18")]
		[HeaderLayout]
		[SerializeField]
		private WorldInscatterSettings worldInscatter;

		// Token: 0x04002658 RID: 9816
		[Token(Token = "0x4002658")]
		[FieldOffset(Offset = "0x2C")]
		[HeaderLayout]
		[SerializeField]
		private ScatterOcclusionSettings scatterOcclusion;

		// Token: 0x04002659 RID: 9817
		[Token(Token = "0x4002659")]
		[FieldOffset(Offset = "0x40")]
		private Light activeLight;

		// Token: 0x0400265A RID: 9818
		[Token(Token = "0x400265A")]
		[FieldOffset(Offset = "0x48")]
		[HideInInspector]
		public Shader occlusionShader;

		// Token: 0x0400265B RID: 9819
		[Token(Token = "0x400265B")]
		[FieldOffset(Offset = "0x50")]
		private bool m_isAwake;

		// Token: 0x0400265C RID: 9820
		[Token(Token = "0x400265C")]
		[FieldOffset(Offset = "0x58")]
		private Material m_occlusionMaterial;

		// Token: 0x0400265D RID: 9821
		[Token(Token = "0x400265D")]
		[FieldOffset(Offset = "0x60")]
		private Texture2D m_WhiteTexture;

		// Token: 0x0400265E RID: 9822
		[Token(Token = "0x400265E")]
		[FieldOffset(Offset = "0x68")]
		private CommandBuffer m_occlusionCmdAfterShadows;

		// Token: 0x0400265F RID: 9823
		[Token(Token = "0x400265F")]
		[FieldOffset(Offset = "0x70")]
		private CommandBuffer m_occlusionCmdBeforeScreen;
	}
}
