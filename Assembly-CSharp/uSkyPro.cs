using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using usky;

// Token: 0x02000064 RID: 100
[Token(Token = "0x2000064")]
[HelpURL("http://forum.unity3d.com/threads/uskypro-precomputed-atmospheric-scattering-2-0-beta.268288/")]
[ExecuteInEditMode]
[AddComponentMenu("uSkyPro/uSkyPro Manager")]
[DisallowMultipleComponent]
public class uSkyPro : MonoBehaviour
{
	// Token: 0x1700005C RID: 92
	// (get) Token: 0x06000230 RID: 560 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000231 RID: 561 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700005C")]
	public static uSkyPro instance
	{
		[Token(Token = "0x6000230")]
		[Address(RVA = "0x3203ED8", Offset = "0x3203ED8", VA = "0x3203ED8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000231")]
		[Address(RVA = "0x3203F20", Offset = "0x3203F20", VA = "0x3203F20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x1700005D RID: 93
	// (get) Token: 0x06000232 RID: 562 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700005D")]
	private uSkySun m_Sun
	{
		[Token(Token = "0x6000232")]
		[Address(RVA = "0x3203F78", Offset = "0x3203F78", VA = "0x3203F78")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700005E RID: 94
	// (get) Token: 0x06000233 RID: 563 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700005E")]
	private uSkyMoon m_Moon
	{
		[Token(Token = "0x6000233")]
		[Address(RVA = "0x3203FC0", Offset = "0x3203FC0", VA = "0x3203FC0")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700005F RID: 95
	// (get) Token: 0x06000234 RID: 564 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700005F")]
	private uSkyTimeline uST
	{
		[Token(Token = "0x6000234")]
		[Address(RVA = "0x3204008", Offset = "0x3204008", VA = "0x3204008")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000235 RID: 565 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000235")]
	[Address(RVA = "0x3204048", Offset = "0x3204048", VA = "0x3204048")]
	private void CheckMaterialResources()
	{
	}

	// Token: 0x06000236 RID: 566 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000236")]
	[Address(RVA = "0x320418C", Offset = "0x320418C", VA = "0x320418C")]
	private void SetEnumsAndToggles()
	{
	}

	// Token: 0x06000237 RID: 567 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000237")]
	[Address(RVA = "0x3204204", Offset = "0x3204204", VA = "0x3204204")]
	private void Awake()
	{
	}

	// Token: 0x06000238 RID: 568 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000238")]
	[Address(RVA = "0x3204344", Offset = "0x3204344", VA = "0x3204344")]
	private void Start()
	{
	}

	// Token: 0x06000239 RID: 569 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000239")]
	[Address(RVA = "0x3204570", Offset = "0x3204570", VA = "0x3204570")]
	private void Update()
	{
	}

	// Token: 0x0600023A RID: 570 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600023A")]
	[Address(RVA = "0x3204DB4", Offset = "0x3204DB4", VA = "0x3204DB4")]
	private void OnDestroy()
	{
	}

	// Token: 0x0600023B RID: 571 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600023B")]
	[Address(RVA = "0x3204478", Offset = "0x3204478", VA = "0x3204478")]
	private void UpdatePrecomputeData()
	{
	}

	// Token: 0x0600023C RID: 572 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600023C")]
	[Address(RVA = "0x3204760", Offset = "0x3204760", VA = "0x3204760")]
	private void CalculationCloud()
	{
	}

	// Token: 0x0600023D RID: 573 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600023D")]
	[Address(RVA = "0x3204854", Offset = "0x3204854", VA = "0x3204854")]
	public void UpdateMaterialUniform()
	{
	}

	// Token: 0x0600023E RID: 574 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600023E")]
	[Address(RVA = "0x32044B0", Offset = "0x32044B0", VA = "0x32044B0")]
	private void UpdateKeywords()
	{
	}

	// Token: 0x0600023F RID: 575 RVA: 0x00002D00 File Offset: 0x00000F00
	[Token(Token = "0x600023F")]
	[Address(RVA = "0x3205014", Offset = "0x3205014", VA = "0x3205014")]
	private Vector4 SunDirectionAndSize()
	{
		return default(Vector4);
	}

	// Token: 0x06000240 RID: 576 RVA: 0x00002D18 File Offset: 0x00000F18
	[Token(Token = "0x6000240")]
	[Address(RVA = "0x32051D4", Offset = "0x32051D4", VA = "0x32051D4")]
	private Vector4 MoonDirectionAndSize()
	{
		return default(Vector4);
	}

	// Token: 0x06000241 RID: 577 RVA: 0x00002D30 File Offset: 0x00000F30
	[Token(Token = "0x6000241")]
	[Address(RVA = "0x32054F8", Offset = "0x32054F8", VA = "0x32054F8")]
	public float DayTimeBrightness()
	{
		return 0f;
	}

	// Token: 0x06000242 RID: 578 RVA: 0x00002D48 File Offset: 0x00000F48
	[Token(Token = "0x6000242")]
	[Address(RVA = "0x3205538", Offset = "0x3205538", VA = "0x3205538")]
	public float NightTimeBrightness()
	{
		return 0f;
	}

	// Token: 0x06000243 RID: 579 RVA: 0x00002D60 File Offset: 0x00000F60
	[Token(Token = "0x6000243")]
	[Address(RVA = "0x320539C", Offset = "0x320539C", VA = "0x320539C")]
	public float NightFade()
	{
		return 0f;
	}

	// Token: 0x06000244 RID: 580 RVA: 0x00002D78 File Offset: 0x00000F78
	[Token(Token = "0x6000244")]
	[Address(RVA = "0x32053F8", Offset = "0x32053F8", VA = "0x32053F8")]
	public float MoonFade()
	{
		return 0f;
	}

	// Token: 0x06000245 RID: 581 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000245")]
	[Address(RVA = "0x32043A4", Offset = "0x32043A4", VA = "0x32043A4")]
	private void CheckSkyboxMaterialType()
	{
	}

	// Token: 0x06000246 RID: 582 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000246")]
	[Address(RVA = "0x320557C", Offset = "0x320557C", VA = "0x320557C")]
	private void OnValidate()
	{
	}

	// Token: 0x17000060 RID: 96
	// (get) Token: 0x06000247 RID: 583 RVA: 0x00002D90 File Offset: 0x00000F90
	// (set) Token: 0x06000248 RID: 584 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000060")]
	public float MieScattering
	{
		[Token(Token = "0x6000247")]
		[Address(RVA = "0x32056DC", Offset = "0x32056DC", VA = "0x32056DC")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6000248")]
		[Address(RVA = "0x32056E4", Offset = "0x32056E4", VA = "0x32056E4")]
		set
		{
		}
	}

	// Token: 0x17000061 RID: 97
	// (get) Token: 0x06000249 RID: 585 RVA: 0x00002DA8 File Offset: 0x00000FA8
	// (set) Token: 0x0600024A RID: 586 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000061")]
	public float SunAnisotropyFactor
	{
		[Token(Token = "0x6000249")]
		[Address(RVA = "0x32056EC", Offset = "0x32056EC", VA = "0x32056EC")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x600024A")]
		[Address(RVA = "0x32056F4", Offset = "0x32056F4", VA = "0x32056F4")]
		set
		{
		}
	}

	// Token: 0x17000062 RID: 98
	// (get) Token: 0x0600024B RID: 587 RVA: 0x00002DC0 File Offset: 0x00000FC0
	// (set) Token: 0x0600024C RID: 588 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000062")]
	public float SunSize
	{
		[Token(Token = "0x600024B")]
		[Address(RVA = "0x32056FC", Offset = "0x32056FC", VA = "0x32056FC")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x600024C")]
		[Address(RVA = "0x3205704", Offset = "0x3205704", VA = "0x3205704")]
		set
		{
		}
	}

	// Token: 0x17000063 RID: 99
	// (get) Token: 0x0600024D RID: 589 RVA: 0x00002DD8 File Offset: 0x00000FD8
	// (set) Token: 0x0600024E RID: 590 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000063")]
	public bool DisableSunDisk
	{
		[Token(Token = "0x600024D")]
		[Address(RVA = "0x320570C", Offset = "0x320570C", VA = "0x320570C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600024E")]
		[Address(RVA = "0x3205714", Offset = "0x3205714", VA = "0x3205714")]
		set
		{
		}
	}

	// Token: 0x17000064 RID: 100
	// (get) Token: 0x0600024F RID: 591 RVA: 0x00002DF0 File Offset: 0x00000FF0
	// (set) Token: 0x06000250 RID: 592 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000064")]
	public NightModes NightMode
	{
		[Token(Token = "0x600024F")]
		[Address(RVA = "0x32041F4", Offset = "0x32041F4", VA = "0x32041F4")]
		get
		{
			return NightModes.Static;
		}
		[Token(Token = "0x6000250")]
		[Address(RVA = "0x3205720", Offset = "0x3205720", VA = "0x3205720")]
		set
		{
		}
	}

	// Token: 0x17000065 RID: 101
	// (get) Token: 0x06000251 RID: 593 RVA: 0x00002E08 File Offset: 0x00001008
	// (set) Token: 0x06000252 RID: 594 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000065")]
	public float StarIntensity
	{
		[Token(Token = "0x6000251")]
		[Address(RVA = "0x3205728", Offset = "0x3205728", VA = "0x3205728")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6000252")]
		[Address(RVA = "0x3205730", Offset = "0x3205730", VA = "0x3205730")]
		set
		{
		}
	}

	// Token: 0x17000066 RID: 102
	// (get) Token: 0x06000253 RID: 595 RVA: 0x00002E20 File Offset: 0x00001020
	// (set) Token: 0x06000254 RID: 596 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000066")]
	public float OuterSpaceIntensity
	{
		[Token(Token = "0x6000253")]
		[Address(RVA = "0x32053E4", Offset = "0x32053E4", VA = "0x32053E4")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6000254")]
		[Address(RVA = "0x3205738", Offset = "0x3205738", VA = "0x3205738")]
		set
		{
		}
	}

	// Token: 0x17000067 RID: 103
	// (get) Token: 0x06000255 RID: 597 RVA: 0x00002E38 File Offset: 0x00001038
	// (set) Token: 0x06000256 RID: 598 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000067")]
	public Color MoonInnerCorona
	{
		[Token(Token = "0x6000255")]
		[Address(RVA = "0x32053EC", Offset = "0x32053EC", VA = "0x32053EC")]
		get
		{
			return default(Color);
		}
		[Token(Token = "0x6000256")]
		[Address(RVA = "0x3205740", Offset = "0x3205740", VA = "0x3205740")]
		set
		{
		}
	}

	// Token: 0x17000068 RID: 104
	// (get) Token: 0x06000257 RID: 599 RVA: 0x00002E50 File Offset: 0x00001050
	// (set) Token: 0x06000258 RID: 600 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000068")]
	public Color MoonOuterCorona
	{
		[Token(Token = "0x6000257")]
		[Address(RVA = "0x32054C4", Offset = "0x32054C4", VA = "0x32054C4")]
		get
		{
			return default(Color);
		}
		[Token(Token = "0x6000258")]
		[Address(RVA = "0x320574C", Offset = "0x320574C", VA = "0x320574C")]
		set
		{
		}
	}

	// Token: 0x17000069 RID: 105
	// (get) Token: 0x06000259 RID: 601 RVA: 0x00002E68 File Offset: 0x00001068
	// (set) Token: 0x0600025A RID: 602 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000069")]
	public float MoonSize
	{
		[Token(Token = "0x6000259")]
		[Address(RVA = "0x32054F0", Offset = "0x32054F0", VA = "0x32054F0")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x600025A")]
		[Address(RVA = "0x3205758", Offset = "0x3205758", VA = "0x3205758")]
		set
		{
		}
	}

	// Token: 0x1700006A RID: 106
	// (get) Token: 0x0600025B RID: 603 RVA: 0x00002E80 File Offset: 0x00001080
	// (set) Token: 0x0600025C RID: 604 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700006A")]
	public float GroundOffset
	{
		[Token(Token = "0x600025B")]
		[Address(RVA = "0x32054D0", Offset = "0x32054D0", VA = "0x32054D0")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x600025C")]
		[Address(RVA = "0x32056B4", Offset = "0x32056B4", VA = "0x32056B4")]
		set
		{
		}
	}

	// Token: 0x1700006B RID: 107
	// (get) Token: 0x0600025D RID: 605 RVA: 0x00002E98 File Offset: 0x00001098
	// (set) Token: 0x0600025E RID: 606 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700006B")]
	public float AltitudeScale
	{
		[Token(Token = "0x600025D")]
		[Address(RVA = "0x32054E0", Offset = "0x32054E0", VA = "0x32054E0")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x600025E")]
		[Address(RVA = "0x32056BC", Offset = "0x32056BC", VA = "0x32056BC")]
		set
		{
		}
	}

	// Token: 0x1700006C RID: 108
	// (get) Token: 0x0600025F RID: 607 RVA: 0x00002EB0 File Offset: 0x000010B0
	// (set) Token: 0x06000260 RID: 608 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700006C")]
	public bool DisableSkyboxOcean
	{
		[Token(Token = "0x600025F")]
		[Address(RVA = "0x32054E8", Offset = "0x32054E8", VA = "0x32054E8")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000260")]
		[Address(RVA = "0x3205760", Offset = "0x3205760", VA = "0x3205760")]
		set
		{
		}
	}

	// Token: 0x1700006D RID: 109
	// (get) Token: 0x06000261 RID: 609 RVA: 0x00002EC8 File Offset: 0x000010C8
	// (set) Token: 0x06000262 RID: 610 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700006D")]
	public bool HDRMode
	{
		[Token(Token = "0x6000261")]
		[Address(RVA = "0x32041FC", Offset = "0x32041FC", VA = "0x32041FC")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000262")]
		[Address(RVA = "0x320576C", Offset = "0x320576C", VA = "0x320576C")]
		set
		{
		}
	}

	// Token: 0x1700006E RID: 110
	// (get) Token: 0x06000263 RID: 611 RVA: 0x00002EE0 File Offset: 0x000010E0
	// (set) Token: 0x06000264 RID: 612 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700006E")]
	public float AtmosphereThickness
	{
		[Token(Token = "0x6000263")]
		[Address(RVA = "0x3205778", Offset = "0x3205778", VA = "0x3205778")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6000264")]
		[Address(RVA = "0x3205780", Offset = "0x3205780", VA = "0x3205780")]
		set
		{
		}
	}

	// Token: 0x1700006F RID: 111
	// (get) Token: 0x06000265 RID: 613 RVA: 0x00002EF8 File Offset: 0x000010F8
	// (set) Token: 0x06000266 RID: 614 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700006F")]
	public Vector3 Wavelengths
	{
		[Token(Token = "0x6000265")]
		[Address(RVA = "0x32056C4", Offset = "0x32056C4", VA = "0x32056C4")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6000266")]
		[Address(RVA = "0x32056D0", Offset = "0x32056D0", VA = "0x32056D0")]
		set
		{
		}
	}

	// Token: 0x17000070 RID: 112
	// (get) Token: 0x06000267 RID: 615 RVA: 0x00002F10 File Offset: 0x00001110
	// (set) Token: 0x06000268 RID: 616 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000070")]
	public Color SkyTint
	{
		[Token(Token = "0x6000267")]
		[Address(RVA = "0x3205788", Offset = "0x3205788", VA = "0x3205788")]
		get
		{
			return default(Color);
		}
		[Token(Token = "0x6000268")]
		[Address(RVA = "0x3205794", Offset = "0x3205794", VA = "0x3205794")]
		set
		{
		}
	}

	// Token: 0x17000071 RID: 113
	// (get) Token: 0x06000269 RID: 617 RVA: 0x00002F28 File Offset: 0x00001128
	// (set) Token: 0x0600026A RID: 618 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000071")]
	public DepthSample InscatterAltitudeSample
	{
		[Token(Token = "0x6000269")]
		[Address(RVA = "0x32054D8", Offset = "0x32054D8", VA = "0x32054D8")]
		get
		{
			return (DepthSample)0;
		}
		[Token(Token = "0x600026A")]
		[Address(RVA = "0x32057A0", Offset = "0x32057A0", VA = "0x32057A0")]
		set
		{
		}
	}

	// Token: 0x0600026B RID: 619 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600026B")]
	[Address(RVA = "0x32057A8", Offset = "0x32057A8", VA = "0x32057A8")]
	public uSkyPro()
	{
	}

	// Token: 0x040001FB RID: 507
	[Token(Token = "0x40001FB")]
	[FieldOffset(Offset = "0x18")]
	[Range(0f, 20f)]
	[Tooltip("Mie scattering is caused by aerosols in the lower atmosphere (up to 1.2 km).\nIt is for haze and halos around the sun on foggy days.")]
	[SerializeField]
	private float mieScattering;

	// Token: 0x040001FC RID: 508
	[Token(Token = "0x40001FC")]
	[FieldOffset(Offset = "0x1C")]
	[Range(0f, 0.9995f)]
	[Tooltip("The anisotropy factor controls the sun's appearance in the sky.\nThe closer this value gets to 1.0, the sharper and smaller the sun spot will be.\nHigher values cause more fuzzy and bigger sun spots.")]
	[SerializeField]
	private float sunAnisotropyFactor;

	// Token: 0x040001FD RID: 509
	[Token(Token = "0x40001FD")]
	[FieldOffset(Offset = "0x20")]
	[Range(0.001f, 50f)]
	[Tooltip("Size of the sun spot in the sky")]
	[SerializeField]
	private float sunSize;

	// Token: 0x040001FE RID: 510
	[Token(Token = "0x40001FE")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	[Tooltip("Enable or Disable the Sun Disk in Skybox")]
	private bool disableSunDisk;

	// Token: 0x040001FF RID: 511
	[Token(Token = "0x40001FF")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Mesh m_StarsMesh;

	// Token: 0x04000200 RID: 512
	[Token(Token = "0x4000200")]
	[FieldOffset(Offset = "0x30")]
	public Vector3 starEuler;

	// Token: 0x04000201 RID: 513
	[Token(Token = "0x4000201")]
	[FieldOffset(Offset = "0x3C")]
	public Color skyColor;

	// Token: 0x04000202 RID: 514
	[Token(Token = "0x4000202")]
	[FieldOffset(Offset = "0x50")]
	public Gradient skyGradientColor;

	// Token: 0x04000203 RID: 515
	[Token(Token = "0x4000203")]
	[FieldOffset(Offset = "0x58")]
	private uSkyTimeline skyTimeLine;

	// Token: 0x04000204 RID: 516
	[Token(Token = "0x4000204")]
	[FieldOffset(Offset = "0x60")]
	private uSkyLighting skyLighting;

	// Token: 0x04000205 RID: 517
	[Token(Token = "0x4000205")]
	[FieldOffset(Offset = "0x68")]
	public float cloundExposure;

	// Token: 0x04000206 RID: 518
	[Token(Token = "0x4000206")]
	[FieldOffset(Offset = "0x70")]
	public AnimationCurve cloundExposureCurve;

	// Token: 0x04000207 RID: 519
	[Token(Token = "0x4000207")]
	[FieldOffset(Offset = "0x78")]
	private NightSkySettings nightSky;

	// Token: 0x04000208 RID: 520
	[Token(Token = "0x4000208")]
	[FieldOffset(Offset = "0xA8")]
	[SerializeField]
	[HeaderLayout]
	private OtherSettings other;

	// Token: 0x04000209 RID: 521
	[Token(Token = "0x4000209")]
	[FieldOffset(Offset = "0xB4")]
	[SerializeField]
	[HeaderLayout]
	private PrecomputeSettings precomputeParams;

	// Token: 0x0400020A RID: 522
	[Token(Token = "0x400020A")]
	[FieldOffset(Offset = "0xD8")]
	[Space]
	public Material SkyboxMaterial;

	// Token: 0x0400020B RID: 523
	[Token(Token = "0x400020B")]
	[FieldOffset(Offset = "0xE0")]
	private bool AutoApplySkybox;

	// Token: 0x0400020C RID: 524
	[Token(Token = "0x400020C")]
	[FieldOffset(Offset = "0xE8")]
	[SerializeField]
	private Shader m_uStarShader;

	// Token: 0x0400020D RID: 525
	[Token(Token = "0x400020D")]
	[FieldOffset(Offset = "0xF0")]
	[SerializeField]
	private Shader m_PrecomputeShader;

	// Token: 0x0400020E RID: 526
	[Token(Token = "0x400020E")]
	[FieldOffset(Offset = "0xF8")]
	private Material m_PrecomputeMaterial;

	// Token: 0x0400020F RID: 527
	[Token(Token = "0x400020F")]
	[FieldOffset(Offset = "0x100")]
	private Material m_uStarsMaterial;

	// Token: 0x04000210 RID: 528
	[Token(Token = "0x4000210")]
	[FieldOffset(Offset = "0x108")]
	private bool m_isAwake;

	// Token: 0x04000211 RID: 529
	[Token(Token = "0x4000211")]
	[FieldOffset(Offset = "0x110")]
	private Camera cam;

	// Token: 0x04000212 RID: 530
	[Token(Token = "0x4000212")]
	[FieldOffset(Offset = "0x118")]
	public bool showStar;
}
