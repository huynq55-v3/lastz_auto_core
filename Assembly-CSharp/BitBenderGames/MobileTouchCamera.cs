using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BitBenderGames.CameraState;
using Il2CppDummyDll;
using UnityEngine;

namespace BitBenderGames
{
	// Token: 0x02000AA4 RID: 2724
	[Token(Token = "0x2000AA4")]
	[RequireComponent(typeof(Camera))]
	public class MobileTouchCamera : MonoBehaviour
	{
		// Token: 0x1700071B RID: 1819
		// (get) Token: 0x060067C0 RID: 26560 RVA: 0x0004C998 File Offset: 0x0004AB98
		[Token(Token = "0x1700071B")]
		public MobileTouchCamera.State CurrentState
		{
			[Token(Token = "0x60067C0")]
			[Address(RVA = "0x33C9510", Offset = "0x33C9510", VA = "0x33C9510")]
			get
			{
				return MobileTouchCamera.State.Idle;
			}
		}

		// Token: 0x1700071C RID: 1820
		// (get) Token: 0x060067C1 RID: 26561 RVA: 0x0004C9B0 File Offset: 0x0004ABB0
		[Token(Token = "0x1700071C")]
		public Plane RefPlane
		{
			[Token(Token = "0x60067C1")]
			[Address(RVA = "0x33C9518", Offset = "0x33C9518", VA = "0x33C9518")]
			get
			{
				return default(Plane);
			}
		}

		// Token: 0x1700071D RID: 1821
		// (get) Token: 0x060067C2 RID: 26562 RVA: 0x0004C9C8 File Offset: 0x0004ABC8
		// (set) Token: 0x060067C3 RID: 26563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700071D")]
		public int LodLevel
		{
			[Token(Token = "0x60067C2")]
			[Address(RVA = "0x33C9524", Offset = "0x33C9524", VA = "0x33C9524")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60067C3")]
			[Address(RVA = "0x33C952C", Offset = "0x33C952C", VA = "0x33C952C")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060067C4 RID: 26564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60067C4")]
		[Address(RVA = "0x33C9534", Offset = "0x33C9534", VA = "0x33C9534")]
		public void Clone(MobileTouchCamera other)
		{
		}

		// Token: 0x060067C5 RID: 26565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60067C5")]
		[Address(RVA = "0x33C9640", Offset = "0x33C9640", VA = "0x33C9640")]
		private void CopyList(List<MobileTouchCamera.ZoomParam> source, List<MobileTouchCamera.ZoomParam> target)
		{
		}

		// Token: 0x060067C6 RID: 26566 RVA: 0x0004C9E0 File Offset: 0x0004ABE0
		[Token(Token = "0x60067C6")]
		[Address(RVA = "0x33C97C8", Offset = "0x33C97C8", VA = "0x33C97C8")]
		public bool IsOrth()
		{
			return default(bool);
		}

		// Token: 0x1700071E RID: 1822
		// (get) Token: 0x060067C8 RID: 26568 RVA: 0x0004C9F8 File Offset: 0x0004ABF8
		// (set) Token: 0x060067C7 RID: 26567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700071E")]
		public float RPGZoom
		{
			[Token(Token = "0x60067C8")]
			[Address(RVA = "0x33C97EC", Offset = "0x33C97EC", VA = "0x33C97EC")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60067C7")]
			[Address(RVA = "0x33C97E4", Offset = "0x33C97E4", VA = "0x33C97E4")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700071F RID: 1823
		// (get) Token: 0x060067CA RID: 26570 RVA: 0x0004CA10 File Offset: 0x0004AC10
		// (set) Token: 0x060067C9 RID: 26569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700071F")]
		public float SLGZoom
		{
			[Token(Token = "0x60067CA")]
			[Address(RVA = "0x33C97FC", Offset = "0x33C97FC", VA = "0x33C97FC")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60067C9")]
			[Address(RVA = "0x33C97F4", Offset = "0x33C97F4", VA = "0x33C97F4")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000720 RID: 1824
		// (get) Token: 0x060067CC RID: 26572 RVA: 0x0004CA28 File Offset: 0x0004AC28
		// (set) Token: 0x060067CB RID: 26571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000720")]
		public float SLGZoomMin
		{
			[Token(Token = "0x60067CC")]
			[Address(RVA = "0x33C980C", Offset = "0x33C980C", VA = "0x33C980C")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60067CB")]
			[Address(RVA = "0x33C9804", Offset = "0x33C9804", VA = "0x33C9804")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000721 RID: 1825
		// (get) Token: 0x060067CE RID: 26574 RVA: 0x0004CA40 File Offset: 0x0004AC40
		// (set) Token: 0x060067CD RID: 26573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000721")]
		public float SLGZoomMax
		{
			[Token(Token = "0x60067CE")]
			[Address(RVA = "0x33C981C", Offset = "0x33C981C", VA = "0x33C981C")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60067CD")]
			[Address(RVA = "0x33C9814", Offset = "0x33C9814", VA = "0x33C9814")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000722 RID: 1826
		// (get) Token: 0x060067CF RID: 26575 RVA: 0x0004CA58 File Offset: 0x0004AC58
		// (set) Token: 0x060067D0 RID: 26576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000722")]
		public float CamZoomInit
		{
			[Token(Token = "0x60067CF")]
			[Address(RVA = "0x33C9824", Offset = "0x33C9824", VA = "0x33C9824")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60067D0")]
			[Address(RVA = "0x33C9858", Offset = "0x33C9858", VA = "0x33C9858")]
			set
			{
			}
		}

		// Token: 0x17000723 RID: 1827
		// (get) Token: 0x060067D1 RID: 26577 RVA: 0x0004CA70 File Offset: 0x0004AC70
		// (set) Token: 0x060067D2 RID: 26578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000723")]
		public float CamZoomMin
		{
			[Token(Token = "0x60067D1")]
			[Address(RVA = "0x33C9860", Offset = "0x33C9860", VA = "0x33C9860")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60067D2")]
			[Address(RVA = "0x33C9868", Offset = "0x33C9868", VA = "0x33C9868")]
			set
			{
			}
		}

		// Token: 0x17000724 RID: 1828
		// (get) Token: 0x060067D3 RID: 26579 RVA: 0x0004CA88 File Offset: 0x0004AC88
		// (set) Token: 0x060067D4 RID: 26580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000724")]
		public float CamZoomMax
		{
			[Token(Token = "0x60067D3")]
			[Address(RVA = "0x33C9870", Offset = "0x33C9870", VA = "0x33C9870")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60067D4")]
			[Address(RVA = "0x33C9878", Offset = "0x33C9878", VA = "0x33C9878")]
			set
			{
			}
		}

		// Token: 0x17000725 RID: 1829
		// (get) Token: 0x060067D5 RID: 26581 RVA: 0x0004CAA0 File Offset: 0x0004ACA0
		[Token(Token = "0x17000725")]
		public float CamZoomMaxCity
		{
			[Token(Token = "0x60067D5")]
			[Address(RVA = "0x33C9880", Offset = "0x33C9880", VA = "0x33C9880")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000726 RID: 1830
		// (get) Token: 0x060067D6 RID: 26582 RVA: 0x0004CAB8 File Offset: 0x0004ACB8
		[Token(Token = "0x17000726")]
		public float CamZoomMaxWorld
		{
			[Token(Token = "0x60067D6")]
			[Address(RVA = "0x33C9888", Offset = "0x33C9888", VA = "0x33C9888")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000727 RID: 1831
		// (get) Token: 0x060067D7 RID: 26583 RVA: 0x0004CAD0 File Offset: 0x0004ACD0
		[Token(Token = "0x17000727")]
		public float CamOverZoomMargin
		{
			[Token(Token = "0x60067D7")]
			[Address(RVA = "0x33C9890", Offset = "0x33C9890", VA = "0x33C9890")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000728 RID: 1832
		// (get) Token: 0x060067D8 RID: 26584 RVA: 0x0004CAE8 File Offset: 0x0004ACE8
		// (set) Token: 0x060067D9 RID: 26585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000728")]
		public float CamZoom
		{
			[Token(Token = "0x60067D8")]
			[Address(RVA = "0x33C9898", Offset = "0x33C9898", VA = "0x33C9898")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60067D9")]
			[Address(RVA = "0x33C98F0", Offset = "0x33C98F0", VA = "0x33C98F0")]
			set
			{
			}
		}

		// Token: 0x060067DA RID: 26586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60067DA")]
		[Address(RVA = "0x33C9E18", Offset = "0x33C9E18", VA = "0x33C9E18")]
		public void SetYRotation(float rotation)
		{
		}

		// Token: 0x17000729 RID: 1833
		// (get) Token: 0x060067DB RID: 26587 RVA: 0x0004CB00 File Offset: 0x0004AD00
		// (set) Token: 0x060067DC RID: 26588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000729")]
		public bool use45XCamera
		{
			[Token(Token = "0x60067DB")]
			[Address(RVA = "0x33C9EBC", Offset = "0x33C9EBC", VA = "0x33C9EBC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60067DC")]
			[Address(RVA = "0x33C9EC4", Offset = "0x33C9EC4", VA = "0x33C9EC4")]
			set
			{
			}
		}

		// Token: 0x060067DD RID: 26589 RVA: 0x0004CB18 File Offset: 0x0004AD18
		[Token(Token = "0x60067DD")]
		[Address(RVA = "0x33C99EC", Offset = "0x33C99EC", VA = "0x33C99EC")]
		public bool CalcZoom(float cameraY, Vector3 pos, out Vector3 outPos, out Quaternion outRot)
		{
			return default(bool);
		}

		// Token: 0x1700072A RID: 1834
		// (get) Token: 0x060067DE RID: 26590 RVA: 0x0004CB30 File Offset: 0x0004AD30
		// (set) Token: 0x060067DF RID: 26591 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700072A")]
		public bool CanMoveing
		{
			[Token(Token = "0x60067DE")]
			[Address(RVA = "0x33CA018", Offset = "0x33CA018", VA = "0x33CA018")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60067DF")]
			[Address(RVA = "0x33CA020", Offset = "0x33CA020", VA = "0x33CA020")]
			set
			{
			}
		}

		// Token: 0x1700072B RID: 1835
		// (get) Token: 0x060067E0 RID: 26592 RVA: 0x0004CB48 File Offset: 0x0004AD48
		// (set) Token: 0x060067E1 RID: 26593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700072B")]
		public bool CanRotation
		{
			[Token(Token = "0x60067E0")]
			[Address(RVA = "0x33CA02C", Offset = "0x33CA02C", VA = "0x33CA02C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60067E1")]
			[Address(RVA = "0x33CA034", Offset = "0x33CA034", VA = "0x33CA034")]
			set
			{
			}
		}

		// Token: 0x1700072C RID: 1836
		// (get) Token: 0x060067E2 RID: 26594 RVA: 0x0004CB60 File Offset: 0x0004AD60
		[Token(Token = "0x1700072C")]
		public float DampFactorTimeMultiplier
		{
			[Token(Token = "0x60067E2")]
			[Address(RVA = "0x33CA040", Offset = "0x33CA040", VA = "0x33CA040")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700072D RID: 1837
		// (get) Token: 0x060067E3 RID: 26595 RVA: 0x0004CB78 File Offset: 0x0004AD78
		[Token(Token = "0x1700072D")]
		public float AutoScrollVelocityMax
		{
			[Token(Token = "0x60067E3")]
			[Address(RVA = "0x33CA048", Offset = "0x33CA048", VA = "0x33CA048")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700072E RID: 1838
		// (get) Token: 0x060067E4 RID: 26596 RVA: 0x0004CB90 File Offset: 0x0004AD90
		[Token(Token = "0x1700072E")]
		public float AutoScrollDamp
		{
			[Token(Token = "0x60067E4")]
			[Address(RVA = "0x33CA050", Offset = "0x33CA050", VA = "0x33CA050")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700072F RID: 1839
		// (get) Token: 0x060067E5 RID: 26597 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700072F")]
		public List<float> AutoScrollDamps
		{
			[Token(Token = "0x60067E5")]
			[Address(RVA = "0x33CA058", Offset = "0x33CA058", VA = "0x33CA058")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000730 RID: 1840
		// (get) Token: 0x060067E6 RID: 26598 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000730")]
		public AnimationCurve AutoScrollDampCurve
		{
			[Token(Token = "0x60067E6")]
			[Address(RVA = "0x33CA060", Offset = "0x33CA060", VA = "0x33CA060")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000731 RID: 1841
		// (get) Token: 0x060067E7 RID: 26599 RVA: 0x0004CBA8 File Offset: 0x0004ADA8
		[Token(Token = "0x17000731")]
		public float CamFollowFactor
		{
			[Token(Token = "0x60067E7")]
			[Address(RVA = "0x33CA068", Offset = "0x33CA068", VA = "0x33CA068")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000732 RID: 1842
		// (get) Token: 0x060067E8 RID: 26600 RVA: 0x0004CBC0 File Offset: 0x0004ADC0
		// (set) Token: 0x060067E9 RID: 26601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000732")]
		public float CamZoomFarmPlant
		{
			[Token(Token = "0x60067E8")]
			[Address(RVA = "0x33CA070", Offset = "0x33CA070", VA = "0x33CA070")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60067E9")]
			[Address(RVA = "0x33CA078", Offset = "0x33CA078", VA = "0x33CA078")]
			set
			{
			}
		}

		// Token: 0x17000733 RID: 1843
		// (get) Token: 0x060067EA RID: 26602 RVA: 0x0004CBD8 File Offset: 0x0004ADD8
		// (set) Token: 0x060067EB RID: 26603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000733")]
		public float CamZoomFarmPlantRotation
		{
			[Token(Token = "0x60067EA")]
			[Address(RVA = "0x33CA080", Offset = "0x33CA080", VA = "0x33CA080")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60067EB")]
			[Address(RVA = "0x33CA088", Offset = "0x33CA088", VA = "0x33CA088")]
			set
			{
			}
		}

		// Token: 0x17000734 RID: 1844
		// (get) Token: 0x060067EC RID: 26604 RVA: 0x0004CBF0 File Offset: 0x0004ADF0
		// (set) Token: 0x060067ED RID: 26605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000734")]
		public float CamZoomBuild
		{
			[Token(Token = "0x60067EC")]
			[Address(RVA = "0x33CA090", Offset = "0x33CA090", VA = "0x33CA090")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60067ED")]
			[Address(RVA = "0x33CA098", Offset = "0x33CA098", VA = "0x33CA098")]
			set
			{
			}
		}

		// Token: 0x17000735 RID: 1845
		// (get) Token: 0x060067EE RID: 26606 RVA: 0x0004CC08 File Offset: 0x0004AE08
		// (set) Token: 0x060067EF RID: 26607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000735")]
		public float CamZoomFocusRotation
		{
			[Token(Token = "0x60067EE")]
			[Address(RVA = "0x33CA0A0", Offset = "0x33CA0A0", VA = "0x33CA0A0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60067EF")]
			[Address(RVA = "0x33CA0A8", Offset = "0x33CA0A8", VA = "0x33CA0A8")]
			set
			{
			}
		}

		// Token: 0x17000736 RID: 1846
		// (get) Token: 0x060067F0 RID: 26608 RVA: 0x0004CC20 File Offset: 0x0004AE20
		// (set) Token: 0x060067F1 RID: 26609 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000736")]
		public float CamZoomFormation
		{
			[Token(Token = "0x60067F0")]
			[Address(RVA = "0x33CA0B0", Offset = "0x33CA0B0", VA = "0x33CA0B0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60067F1")]
			[Address(RVA = "0x33CA0B8", Offset = "0x33CA0B8", VA = "0x33CA0B8")]
			set
			{
			}
		}

		// Token: 0x17000737 RID: 1847
		// (get) Token: 0x060067F2 RID: 26610 RVA: 0x0004CC38 File Offset: 0x0004AE38
		// (set) Token: 0x060067F3 RID: 26611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000737")]
		public float CamZoomFocusFormationRotation
		{
			[Token(Token = "0x60067F2")]
			[Address(RVA = "0x33CA0C0", Offset = "0x33CA0C0", VA = "0x33CA0C0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60067F3")]
			[Address(RVA = "0x33CA0C8", Offset = "0x33CA0C8", VA = "0x33CA0C8")]
			set
			{
			}
		}

		// Token: 0x17000738 RID: 1848
		// (get) Token: 0x060067F4 RID: 26612 RVA: 0x0004CC50 File Offset: 0x0004AE50
		[Token(Token = "0x17000738")]
		public float CamZoomEarthOrder
		{
			[Token(Token = "0x60067F4")]
			[Address(RVA = "0x33CA0D0", Offset = "0x33CA0D0", VA = "0x33CA0D0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000739 RID: 1849
		// (get) Token: 0x060067F5 RID: 26613 RVA: 0x0004CC68 File Offset: 0x0004AE68
		[Token(Token = "0x17000739")]
		public float CamZoomDome
		{
			[Token(Token = "0x60067F5")]
			[Address(RVA = "0x33CA0D8", Offset = "0x33CA0D8", VA = "0x33CA0D8")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700073A RID: 1850
		// (get) Token: 0x060067F6 RID: 26614 RVA: 0x0004CC80 File Offset: 0x0004AE80
		[Token(Token = "0x1700073A")]
		public float CamZoomMoveCity
		{
			[Token(Token = "0x60067F6")]
			[Address(RVA = "0x33CA0E0", Offset = "0x33CA0E0", VA = "0x33CA0E0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700073B RID: 1851
		// (get) Token: 0x060067F7 RID: 26615 RVA: 0x0004CC98 File Offset: 0x0004AE98
		[Token(Token = "0x1700073B")]
		public float CamZoomFocusEarthOrderRotation
		{
			[Token(Token = "0x60067F7")]
			[Address(RVA = "0x33CA0E8", Offset = "0x33CA0E8", VA = "0x33CA0E8")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700073C RID: 1852
		// (get) Token: 0x060067F8 RID: 26616 RVA: 0x0004CCB0 File Offset: 0x0004AEB0
		[Token(Token = "0x1700073C")]
		public float CamZoomFocusMoveCityRotation
		{
			[Token(Token = "0x60067F8")]
			[Address(RVA = "0x33CA0F0", Offset = "0x33CA0F0", VA = "0x33CA0F0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700073D RID: 1853
		// (get) Token: 0x060067F9 RID: 26617 RVA: 0x0004CCC8 File Offset: 0x0004AEC8
		[Token(Token = "0x1700073D")]
		public float CamZoomInitRotation
		{
			[Token(Token = "0x60067F9")]
			[Address(RVA = "0x33CA0F8", Offset = "0x33CA0F8", VA = "0x33CA0F8")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700073E RID: 1854
		// (get) Token: 0x060067FA RID: 26618 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700073E")]
		public AnimationCurve CameraFocusCurve
		{
			[Token(Token = "0x60067FA")]
			[Address(RVA = "0x33CA124", Offset = "0x33CA124", VA = "0x33CA124")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700073F RID: 1855
		// (get) Token: 0x060067FB RID: 26619 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700073F")]
		public AnimationCurve CameraFocusEarthCurve
		{
			[Token(Token = "0x60067FB")]
			[Address(RVA = "0x33CA12C", Offset = "0x33CA12C", VA = "0x33CA12C")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000740 RID: 1856
		// (get) Token: 0x060067FC RID: 26620 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000740")]
		public AnimationCurve CameraFocusDomeCurve
		{
			[Token(Token = "0x60067FC")]
			[Address(RVA = "0x33CA134", Offset = "0x33CA134", VA = "0x33CA134")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000741 RID: 1857
		// (get) Token: 0x060067FD RID: 26621 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000741")]
		public AnimationCurve CameraFocusMoveCityCurve
		{
			[Token(Token = "0x60067FD")]
			[Address(RVA = "0x33CA13C", Offset = "0x33CA13C", VA = "0x33CA13C")]
			get
			{
				return null;
			}
		}

		// Token: 0x060067FE RID: 26622 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067FE")]
		[Address(RVA = "0x33CA144", Offset = "0x33CA144", VA = "0x33CA144")]
		public List<MobileTouchCamera.ZoomParam> GetZoomParams()
		{
			return null;
		}

		// Token: 0x060067FF RID: 26623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60067FF")]
		[Address(RVA = "0x33CA1C0", Offset = "0x33CA1C0", VA = "0x33CA1C0")]
		public void SetZoomParams(List<MobileTouchCamera.ZoomParam> zoomParams)
		{
		}

		// Token: 0x06006800 RID: 26624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006800")]
		[Address(RVA = "0x33CA1C8", Offset = "0x33CA1C8", VA = "0x33CA1C8")]
		public void SetZoomParams(int level, float y, float offsetZ, float sensitivity)
		{
		}

		// Token: 0x17000742 RID: 1858
		// (set) Token: 0x06006801 RID: 26625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000742")]
		public Action BeforeUpdate
		{
			[Token(Token = "0x6006801")]
			[Address(RVA = "0x33CA29C", Offset = "0x33CA29C", VA = "0x33CA29C")]
			set
			{
			}
		}

		// Token: 0x17000743 RID: 1859
		// (set) Token: 0x06006802 RID: 26626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000743")]
		public Action AfterUpdate
		{
			[Token(Token = "0x6006802")]
			[Address(RVA = "0x33CA2AC", Offset = "0x33CA2AC", VA = "0x33CA2AC")]
			set
			{
			}
		}

		// Token: 0x06006803 RID: 26627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006803")]
		[Address(RVA = "0x33CA2BC", Offset = "0x33CA2BC", VA = "0x33CA2BC")]
		public void Clear()
		{
		}

		// Token: 0x06006804 RID: 26628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006804")]
		[Address(RVA = "0x33CA3B4", Offset = "0x33CA3B4", VA = "0x33CA3B4")]
		public void Awake()
		{
		}

		// Token: 0x06006805 RID: 26629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006805")]
		[Address(RVA = "0x33CAF2C", Offset = "0x33CAF2C", VA = "0x33CAF2C")]
		public void ResetCamera()
		{
		}

		// Token: 0x06006806 RID: 26630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006806")]
		[Address(RVA = "0x33CB008", Offset = "0x33CB008", VA = "0x33CB008")]
		public void OnDestroy()
		{
		}

		// Token: 0x06006807 RID: 26631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006807")]
		[Address(RVA = "0x33CB0C4", Offset = "0x33CB0C4", VA = "0x33CB0C4")]
		public void Update()
		{
		}

		// Token: 0x06006808 RID: 26632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006808")]
		[Address(RVA = "0x33CB800", Offset = "0x33CB800", VA = "0x33CB800")]
		public void Follow(GameObject go, float time)
		{
		}

		// Token: 0x06006809 RID: 26633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006809")]
		[Address(RVA = "0x33CB9E4", Offset = "0x33CB9E4", VA = "0x33CB9E4")]
		public void AutoLookat(Vector3 target, float zoom, float time, Action onCompete)
		{
		}

		// Token: 0x0600680A RID: 26634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600680A")]
		[Address(RVA = "0x33CBCFC", Offset = "0x33CBCFC", VA = "0x33CBCFC")]
		public void AutoZoom(float zoom, float time, Action onComplete)
		{
		}

		// Token: 0x0600680B RID: 26635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600680B")]
		[Address(RVA = "0x33CBED8", Offset = "0x33CBED8", VA = "0x33CBED8")]
		public void ChangeViewMode(Action callback)
		{
		}

		// Token: 0x0600680C RID: 26636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600680C")]
		[Address(RVA = "0x33CBFF0", Offset = "0x33CBFF0", VA = "0x33CBFF0")]
		public void AutoFocus(Vector3 target, float zoom, float time, float rotation, bool focusToCenter, bool lockView, AnimationCurve curve, Action onCompete)
		{
		}

		// Token: 0x0600680D RID: 26637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600680D")]
		[Address(RVA = "0x33CC248", Offset = "0x33CC248", VA = "0x33CC248")]
		public void QuitFocus(float time)
		{
		}

		// Token: 0x0600680E RID: 26638 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600680E")]
		[Address(RVA = "0x33CC3D4", Offset = "0x33CC3D4", VA = "0x33CC3D4")]
		public void StopMove()
		{
		}

		// Token: 0x0600680F RID: 26639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600680F")]
		[Address(RVA = "0x33CC400", Offset = "0x33CC400", VA = "0x33CC400")]
		public void LookAt(Vector3 target)
		{
		}

		// Token: 0x06006810 RID: 26640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006810")]
		[Address(RVA = "0x33CC4E8", Offset = "0x33CC4E8", VA = "0x33CC4E8")]
		public void ResetMoveLastFrameToCameraPos()
		{
		}

		// Token: 0x06006811 RID: 26641 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006811")]
		[Address(RVA = "0x33CAED4", Offset = "0x33CAED4", VA = "0x33CAED4")]
		public CameraStateBase GetState(MobileTouchCamera.State state)
		{
			return null;
		}

		// Token: 0x06006812 RID: 26642 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006812")]
		[Address(RVA = "0x33CB03C", Offset = "0x33CB03C", VA = "0x33CB03C")]
		public void SetState(MobileTouchCamera.State newState)
		{
		}

		// Token: 0x06006813 RID: 26643 RVA: 0x0004CCE0 File Offset: 0x0004AEE0
		[Token(Token = "0x6006813")]
		[Address(RVA = "0x33CC5AC", Offset = "0x33CC5AC", VA = "0x33CC5AC")]
		public bool InputDonwOnUI(Vector3 pos)
		{
			return default(bool);
		}

		// Token: 0x06006814 RID: 26644 RVA: 0x0004CCF8 File Offset: 0x0004AEF8
		[Token(Token = "0x6006814")]
		[Address(RVA = "0x33CC79C", Offset = "0x33CC79C", VA = "0x33CC79C")]
		public Vector3 GetIntersectionPoint(Ray ray)
		{
			return default(Vector3);
		}

		// Token: 0x06006815 RID: 26645 RVA: 0x0004CD10 File Offset: 0x0004AF10
		[Token(Token = "0x6006815")]
		[Address(RVA = "0x33CC9B8", Offset = "0x33CC9B8", VA = "0x33CC9B8")]
		public bool RaycastGround(Ray ray, out Vector3 hitPoint)
		{
			return default(bool);
		}

		// Token: 0x06006816 RID: 26646 RVA: 0x0004CD28 File Offset: 0x0004AF28
		[Token(Token = "0x6006816")]
		[Address(RVA = "0x33CC9A8", Offset = "0x33CC9A8", VA = "0x33CC9A8")]
		public Vector3 UnprojectVector2(Vector2 v2, float offset = 0f)
		{
			return default(Vector3);
		}

		// Token: 0x06006817 RID: 26647 RVA: 0x0004CD40 File Offset: 0x0004AF40
		[Token(Token = "0x6006817")]
		[Address(RVA = "0x33CC9A0", Offset = "0x33CC9A0", VA = "0x33CC9A0")]
		public Vector2 ProjectVector3(Vector3 v3)
		{
			return default(Vector2);
		}

		// Token: 0x06006818 RID: 26648 RVA: 0x0004CD58 File Offset: 0x0004AF58
		[Token(Token = "0x6006818")]
		[Address(RVA = "0x33C9F18", Offset = "0x33C9F18", VA = "0x33C9F18")]
		public Vector3 GetCameraTargetPos()
		{
			return default(Vector3);
		}

		// Token: 0x06006819 RID: 26649 RVA: 0x0004CD70 File Offset: 0x0004AF70
		[Token(Token = "0x6006819")]
		[Address(RVA = "0x33CCB18", Offset = "0x33CCB18", VA = "0x33CCB18")]
		public Vector3 GetCameraPos()
		{
			return default(Vector3);
		}

		// Token: 0x0600681A RID: 26650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600681A")]
		[Address(RVA = "0x33CCB38", Offset = "0x33CCB38", VA = "0x33CCB38")]
		public void SetCameraPos(Vector3 pos)
		{
		}

		// Token: 0x0600681B RID: 26651 RVA: 0x0004CD88 File Offset: 0x0004AF88
		[Token(Token = "0x600681B")]
		[Address(RVA = "0x33CCB80", Offset = "0x33CCB80", VA = "0x33CCB80")]
		public Quaternion GetRotation()
		{
			return default(Quaternion);
		}

		// Token: 0x0600681C RID: 26652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600681C")]
		[Address(RVA = "0x33CCBA0", Offset = "0x33CCBA0", VA = "0x33CCBA0")]
		public void SetRotation(Quaternion rot)
		{
		}

		// Token: 0x0600681D RID: 26653 RVA: 0x0004CDA0 File Offset: 0x0004AFA0
		[Token(Token = "0x600681D")]
		[Address(RVA = "0x33CCA88", Offset = "0x33CCA88", VA = "0x33CCA88")]
		private Ray GetCamCenterRay()
		{
			return default(Ray);
		}

		// Token: 0x0600681E RID: 26654 RVA: 0x0004CDB8 File Offset: 0x0004AFB8
		[Token(Token = "0x600681E")]
		[Address(RVA = "0x33CCBF0", Offset = "0x33CCBF0", VA = "0x33CCBF0")]
		public Ray ScreenPointToRay(Vector3 pos)
		{
			return default(Ray);
		}

		// Token: 0x0600681F RID: 26655 RVA: 0x0004CDD0 File Offset: 0x0004AFD0
		[Token(Token = "0x600681F")]
		[Address(RVA = "0x33CCDAC", Offset = "0x33CCDAC", VA = "0x33CCDAC")]
		public bool GetTouchTerrainPos(float x, float y, out Vector3 pos)
		{
			return default(bool);
		}

		// Token: 0x06006820 RID: 26656 RVA: 0x0004CDE8 File Offset: 0x0004AFE8
		[Token(Token = "0x6006820")]
		[Address(RVA = "0x33CCEBC", Offset = "0x33CCEBC", VA = "0x33CCEBC")]
		public Vector3 WorldToScreenPoint(Vector3 position)
		{
			return default(Vector3);
		}

		// Token: 0x06006821 RID: 26657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006821")]
		[Address(RVA = "0x33C9F54", Offset = "0x33C9F54", VA = "0x33C9F54")]
		private void GetZoomInterval(float cameraY, out int beg, out int end)
		{
		}

		// Token: 0x06006822 RID: 26658 RVA: 0x0004CE00 File Offset: 0x0004B000
		[Token(Token = "0x6006822")]
		[Address(RVA = "0x33CCED8", Offset = "0x33CCED8", VA = "0x33CCED8")]
		public float GetZoomSensitivity()
		{
			return 0f;
		}

		// Token: 0x06006823 RID: 26659 RVA: 0x0004CE18 File Offset: 0x0004B018
		[Token(Token = "0x6006823")]
		[Address(RVA = "0x33CBBEC", Offset = "0x33CBBEC", VA = "0x33CBBEC")]
		public Vector3 AdjustTarget(Vector3 target)
		{
			return default(Vector3);
		}

		// Token: 0x06006824 RID: 26660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006824")]
		[Address(RVA = "0x33CD094", Offset = "0x33CD094", VA = "0x33CD094")]
		private void OnDrawGizmos()
		{
		}

		// Token: 0x06006825 RID: 26661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006825")]
		[Address(RVA = "0x33CD098", Offset = "0x33CD098", VA = "0x33CD098")]
		public MobileTouchCamera()
		{
		}

		// Token: 0x04002980 RID: 10624
		[Token(Token = "0x4002980")]
		[FieldOffset(Offset = "0x18")]
		private List<CameraStateBase> _stateList;

		// Token: 0x04002981 RID: 10625
		[Token(Token = "0x4002981")]
		[FieldOffset(Offset = "0x20")]
		private MobileTouchCamera.State _currentState;

		// Token: 0x04002982 RID: 10626
		[Token(Token = "0x4002982")]
		[FieldOffset(Offset = "0x28")]
		private CameraStateBase _cameraState;

		// Token: 0x04002983 RID: 10627
		[Token(Token = "0x4002983")]
		[FieldOffset(Offset = "0x30")]
		public TouchInputController touchInput;

		// Token: 0x04002984 RID: 10628
		[Token(Token = "0x4002984")]
		[FieldOffset(Offset = "0x38")]
		private Camera camera;

		// Token: 0x04002985 RID: 10629
		[Token(Token = "0x4002985")]
		[FieldOffset(Offset = "0x40")]
		private Plane refPlaneXZ;

		// Token: 0x04002986 RID: 10630
		[Token(Token = "0x4002986")]
		[FieldOffset(Offset = "0x50")]
		private bool showHorizonError;

		// Token: 0x04002987 RID: 10631
		[Token(Token = "0x4002987")]
		[FieldOffset(Offset = "0x54")]
		private float maxHorizonFallbackDistance;

		// Token: 0x04002989 RID: 10633
		[Token(Token = "0x4002989")]
		[FieldOffset(Offset = "0x5C")]
		public float zoomTime;

		// Token: 0x0400298A RID: 10634
		[Token(Token = "0x400298A")]
		[FieldOffset(Offset = "0x60")]
		[Tooltip("This value defines how quickly the camera comes to a halt when auto scrolling.")]
		[SerializeField]
		private float dampFactorTimeMultiplier;

		// Token: 0x0400298B RID: 10635
		[Token(Token = "0x400298B")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		[Tooltip("When swiping over the screen the camera will keep scrolling a while before coming to a halt. This variable limits the maximum velocity of the auto scroll.")]
		private float autoScrollVelocityMax;

		// Token: 0x0400298C RID: 10636
		[Token(Token = "0x400298C")]
		[FieldOffset(Offset = "0x68")]
		[Tooltip("When dragging quickly, the camera will keep autoscrolling in the last direction. The autoscrolling will slowly come to a halt. This value defines how fast the camera will come to a halt.")]
		[SerializeField]
		private float autoScrollDamp;

		// Token: 0x0400298D RID: 10637
		[Token(Token = "0x400298D")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private List<float> autoScrollDamps;

		// Token: 0x0400298E RID: 10638
		[Token(Token = "0x400298E")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Tooltip("This curve allows to modulate the auto scroll damp value over time.")]
		private AnimationCurve autoScrollDampCurve;

		// Token: 0x0400298F RID: 10639
		[Token(Token = "0x400298F")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Tooltip("The lower the value, the slower the camera will follow. The higher the value, the more direct the camera will follow movement updates. Necessary for keeping the camera smooth when the framerate is not in sync with the touch input update rate.")]
		private float camFollowFactor;

		// Token: 0x04002990 RID: 10640
		[Token(Token = "0x4002990")]
		[FieldOffset(Offset = "0x84")]
		private float yRotation;

		// Token: 0x04002991 RID: 10641
		[Token(Token = "0x4002991")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private float camZoomInit;

		// Token: 0x04002992 RID: 10642
		[Token(Token = "0x4002992")]
		[FieldOffset(Offset = "0x8C")]
		[SerializeField]
		private float camZoomCityInit;

		// Token: 0x04002993 RID: 10643
		[Token(Token = "0x4002993")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private float camZoomWorldInit;

		// Token: 0x04002994 RID: 10644
		[Token(Token = "0x4002994")]
		[FieldOffset(Offset = "0x94")]
		[SerializeField]
		private float camZoomMin;

		// Token: 0x04002995 RID: 10645
		[Token(Token = "0x4002995")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private float camZoomMax;

		// Token: 0x04002996 RID: 10646
		[Token(Token = "0x4002996")]
		[FieldOffset(Offset = "0x9C")]
		[SerializeField]
		private float camZoomMaxCity;

		// Token: 0x04002997 RID: 10647
		[Token(Token = "0x4002997")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private float camZoomMaxWorld;

		// Token: 0x04002998 RID: 10648
		[Token(Token = "0x4002998")]
		[FieldOffset(Offset = "0xA4")]
		[SerializeField]
		private float camZoomFarmPlant;

		// Token: 0x04002999 RID: 10649
		[Token(Token = "0x4002999")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private float camZoomFarmPlantRotation;

		// Token: 0x0400299A RID: 10650
		[Token(Token = "0x400299A")]
		[FieldOffset(Offset = "0xAC")]
		[SerializeField]
		private float camZoomBuild;

		// Token: 0x0400299B RID: 10651
		[Token(Token = "0x400299B")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private float camZoomFocusRotation;

		// Token: 0x0400299C RID: 10652
		[Token(Token = "0x400299C")]
		[FieldOffset(Offset = "0xB4")]
		[SerializeField]
		private float camZoomEarthOrder;

		// Token: 0x0400299D RID: 10653
		[Token(Token = "0x400299D")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private float camZoomDome;

		// Token: 0x0400299E RID: 10654
		[Token(Token = "0x400299E")]
		[FieldOffset(Offset = "0xBC")]
		[SerializeField]
		private float camZoomMoveCity;

		// Token: 0x0400299F RID: 10655
		[Token(Token = "0x400299F")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private float camZoomFormation;

		// Token: 0x040029A0 RID: 10656
		[Token(Token = "0x40029A0")]
		[FieldOffset(Offset = "0xC4")]
		[SerializeField]
		private float camZoomFocusEarthOrderRotation;

		// Token: 0x040029A1 RID: 10657
		[Token(Token = "0x40029A1")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private float camZoomFocusMoveCityRotation;

		// Token: 0x040029A2 RID: 10658
		[Token(Token = "0x40029A2")]
		[FieldOffset(Offset = "0xCC")]
		[SerializeField]
		private float camZoomFocusFormationRotation;

		// Token: 0x040029A3 RID: 10659
		[Token(Token = "0x40029A3")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private float camZoomInitCityRotation;

		// Token: 0x040029A4 RID: 10660
		[Token(Token = "0x40029A4")]
		[FieldOffset(Offset = "0xD4")]
		[SerializeField]
		private float camZoomInitWorldRotation;

		// Token: 0x040029A5 RID: 10661
		[Token(Token = "0x40029A5")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private float camOverzoomMargin;

		// Token: 0x040029A6 RID: 10662
		[Token(Token = "0x40029A6")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private List<MobileTouchCamera.ZoomParam> zoomParams;

		// Token: 0x040029A7 RID: 10663
		[Token(Token = "0x40029A7")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private AnimationCurve cameraFocusCurve;

		// Token: 0x040029A8 RID: 10664
		[Token(Token = "0x40029A8")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private AnimationCurve cameraFocusEarthCurve;

		// Token: 0x040029A9 RID: 10665
		[Token(Token = "0x40029A9")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private AnimationCurve cameraFocusDomeCurve;

		// Token: 0x040029AA RID: 10666
		[Token(Token = "0x40029AA")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private AnimationCurve cameraFocusMoveCityCurve;

		// Token: 0x040029AF RID: 10671
		[Token(Token = "0x40029AF")]
		[FieldOffset(Offset = "0x118")]
		private bool _use45XCamera;

		// Token: 0x040029B0 RID: 10672
		[Token(Token = "0x40029B0")]
		[FieldOffset(Offset = "0x119")]
		private bool canMoveing;

		// Token: 0x040029B1 RID: 10673
		[Token(Token = "0x40029B1")]
		[FieldOffset(Offset = "0x11A")]
		private bool canRotation;

		// Token: 0x040029B2 RID: 10674
		[Token(Token = "0x40029B2")]
		[FieldOffset(Offset = "0x120")]
		private Action beforeUpdate;

		// Token: 0x040029B3 RID: 10675
		[Token(Token = "0x40029B3")]
		[FieldOffset(Offset = "0x128")]
		private Action afterUpdate;

		// Token: 0x02000AA5 RID: 2725
		[Token(Token = "0x2000AA5")]
		public enum State
		{
			// Token: 0x040029B5 RID: 10677
			[Token(Token = "0x40029B5")]
			Idle,
			// Token: 0x040029B6 RID: 10678
			[Token(Token = "0x40029B6")]
			FreeLook,
			// Token: 0x040029B7 RID: 10679
			[Token(Token = "0x40029B7")]
			MoveTo,
			// Token: 0x040029B8 RID: 10680
			[Token(Token = "0x40029B8")]
			Focus,
			// Token: 0x040029B9 RID: 10681
			[Token(Token = "0x40029B9")]
			QuitFocus,
			// Token: 0x040029BA RID: 10682
			[Token(Token = "0x40029BA")]
			Follow
		}

		// Token: 0x02000AA6 RID: 2726
		[Token(Token = "0x2000AA6")]
		[Serializable]
		public class ZoomParam
		{
			// Token: 0x06006826 RID: 26662 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006826")]
			[Address(RVA = "0x33C97C0", Offset = "0x33C97C0", VA = "0x33C97C0")]
			public ZoomParam()
			{
			}

			// Token: 0x040029BB RID: 10683
			[Token(Token = "0x40029BB")]
			[FieldOffset(Offset = "0x10")]
			public float posY;

			// Token: 0x040029BC RID: 10684
			[Token(Token = "0x40029BC")]
			[FieldOffset(Offset = "0x14")]
			public float offsetZ;

			// Token: 0x040029BD RID: 10685
			[Token(Token = "0x40029BD")]
			[FieldOffset(Offset = "0x18")]
			public float sensitivity;
		}
	}
}
