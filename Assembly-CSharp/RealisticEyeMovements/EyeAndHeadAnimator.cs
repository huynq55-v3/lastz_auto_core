using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

namespace RealisticEyeMovements
{
	// Token: 0x02000C60 RID: 3168
	[Token(Token = "0x2000C60")]
	public class EyeAndHeadAnimator : MonoBehaviour
	{
		// Token: 0x1400001E RID: 30
		// (add) Token: 0x060078C7 RID: 30919 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x060078C8 RID: 30920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400001E")]
		public event Action OnCannotGetTargetIntoView
		{
			[Token(Token = "0x60078C7")]
			[Address(RVA = "0x1579230", Offset = "0x1579230", VA = "0x1579230")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60078C8")]
			[Address(RVA = "0x15792CC", Offset = "0x15792CC", VA = "0x15792CC")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400001F RID: 31
		// (add) Token: 0x060078C9 RID: 30921 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x060078CA RID: 30922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400001F")]
		public event Action OnTargetDestroyed
		{
			[Token(Token = "0x60078C9")]
			[Address(RVA = "0x1579368", Offset = "0x1579368", VA = "0x1579368")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60078CA")]
			[Address(RVA = "0x1579404", Offset = "0x1579404", VA = "0x1579404")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000020 RID: 32
		// (add) Token: 0x060078CB RID: 30923 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x060078CC RID: 30924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000020")]
		public event Action OnUpdate2Finished
		{
			[Token(Token = "0x60078CB")]
			[Address(RVA = "0x15794A0", Offset = "0x15794A0", VA = "0x15794A0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60078CC")]
			[Address(RVA = "0x157953C", Offset = "0x157953C", VA = "0x157953C")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000ACC RID: 2764
		// (get) Token: 0x060078CD RID: 30925 RVA: 0x00053160 File Offset: 0x00051360
		// (set) Token: 0x060078CE RID: 30926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000ACC")]
		public float eyeDistance
		{
			[Token(Token = "0x60078CD")]
			[Address(RVA = "0x15795D8", Offset = "0x15795D8", VA = "0x15795D8")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60078CE")]
			[Address(RVA = "0x15795E0", Offset = "0x15795E0", VA = "0x15795E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000ACD RID: 2765
		// (get) Token: 0x060078CF RID: 30927 RVA: 0x00053178 File Offset: 0x00051378
		// (set) Token: 0x060078D0 RID: 30928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000ACD")]
		public float eyeDistanceScale
		{
			[Token(Token = "0x60078CF")]
			[Address(RVA = "0x15795E8", Offset = "0x15795E8", VA = "0x15795E8")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60078D0")]
			[Address(RVA = "0x15795F0", Offset = "0x15795F0", VA = "0x15795F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000ACE RID: 2766
		// (get) Token: 0x060078D1 RID: 30929 RVA: 0x00053190 File Offset: 0x00051390
		// (set) Token: 0x060078D2 RID: 30930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000ACE")]
		public bool ResetBlendshapesAtFrameStartEvenIfDisabled
		{
			[Token(Token = "0x60078D1")]
			[Address(RVA = "0x15795F8", Offset = "0x15795F8", VA = "0x15795F8")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60078D2")]
			[Address(RVA = "0x1579600", Offset = "0x1579600", VA = "0x1579600")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000ACF RID: 2767
		// (get) Token: 0x060078D3 RID: 30931 RVA: 0x000531A8 File Offset: 0x000513A8
		// (set) Token: 0x060078D4 RID: 30932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000ACF")]
		public Ray LeftEyeRay
		{
			[Token(Token = "0x60078D3")]
			[Address(RVA = "0x157960C", Offset = "0x157960C", VA = "0x157960C")]
			[CompilerGenerated]
			get
			{
				return default(Ray);
			}
			[Token(Token = "0x60078D4")]
			[Address(RVA = "0x1579624", Offset = "0x1579624", VA = "0x1579624")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000AD0 RID: 2768
		// (get) Token: 0x060078D5 RID: 30933 RVA: 0x000531C0 File Offset: 0x000513C0
		// (set) Token: 0x060078D6 RID: 30934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AD0")]
		public Ray RightEyeRay
		{
			[Token(Token = "0x60078D5")]
			[Address(RVA = "0x157963C", Offset = "0x157963C", VA = "0x157963C")]
			[CompilerGenerated]
			get
			{
				return default(Ray);
			}
			[Token(Token = "0x60078D6")]
			[Address(RVA = "0x1579654", Offset = "0x1579654", VA = "0x1579654")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000AD1 RID: 2769
		// (get) Token: 0x060078D7 RID: 30935 RVA: 0x000531D8 File Offset: 0x000513D8
		// (set) Token: 0x060078D8 RID: 30936 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AD1")]
		public Ray EyesCombinedRay
		{
			[Token(Token = "0x60078D7")]
			[Address(RVA = "0x157966C", Offset = "0x157966C", VA = "0x157966C")]
			[CompilerGenerated]
			get
			{
				return default(Ray);
			}
			[Token(Token = "0x60078D8")]
			[Address(RVA = "0x1579684", Offset = "0x1579684", VA = "0x1579684")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000AD2 RID: 2770
		// (get) Token: 0x060078D9 RID: 30937 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060078DA RID: 30938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AD2")]
		public Transform eyesRootXform
		{
			[Token(Token = "0x60078D9")]
			[Address(RVA = "0x157969C", Offset = "0x157969C", VA = "0x157969C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60078DA")]
			[Address(RVA = "0x15796A4", Offset = "0x15796A4", VA = "0x15796A4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060078DB RID: 30939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60078DB")]
		[Address(RVA = "0x15796B4", Offset = "0x15796B4", VA = "0x15796B4")]
		private void Awake()
		{
		}

		// Token: 0x060078DC RID: 30940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60078DC")]
		[Address(RVA = "0x15797E8", Offset = "0x15797E8", VA = "0x15797E8")]
		public void Blink(bool isShortBlink = true)
		{
		}

		// Token: 0x060078DD RID: 30941 RVA: 0x000531F0 File Offset: 0x000513F0
		[Token(Token = "0x60078DD")]
		[Address(RVA = "0x1579894", Offset = "0x1579894", VA = "0x1579894", Slot = "4")]
		public virtual bool CanGetIntoView(Vector3 point)
		{
			return default(bool);
		}

		// Token: 0x060078DE RID: 30942 RVA: 0x00053208 File Offset: 0x00051408
		[Token(Token = "0x60078DE")]
		[Address(RVA = "0x1579A28", Offset = "0x1579A28", VA = "0x1579A28", Slot = "5")]
		public virtual bool CanChangePointOfAttention()
		{
			return default(bool);
		}

		// Token: 0x060078DF RID: 30943 RVA: 0x00053220 File Offset: 0x00051420
		[Token(Token = "0x60078DF")]
		[Address(RVA = "0x1579B28", Offset = "0x1579B28", VA = "0x1579B28")]
		public bool CanImportFromFile(string filename)
		{
			return default(bool);
		}

		// Token: 0x060078E0 RID: 30944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60078E0")]
		[Address(RVA = "0x157ADD4", Offset = "0x157ADD4", VA = "0x157ADD4", Slot = "6")]
		protected virtual void CheckIdleLookTargets()
		{
		}

		// Token: 0x060078E1 RID: 30945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60078E1")]
		[Address(RVA = "0x157B2DC", Offset = "0x157B2DC", VA = "0x157B2DC")]
		private void CheckLatencies()
		{
		}

		// Token: 0x060078E2 RID: 30946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60078E2")]
		[Address(RVA = "0x157B45C", Offset = "0x157B45C", VA = "0x157B45C")]
		private void CheckMacroSaccades(float deltaTime)
		{
		}

		// Token: 0x060078E3 RID: 30947 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60078E3")]
		[Address(RVA = "0x157BD84", Offset = "0x157BD84", VA = "0x157BD84")]
		private void CheckMicroSaccades(float deltaTime)
		{
		}

		// Token: 0x060078E4 RID: 30948 RVA: 0x00053238 File Offset: 0x00051438
		[Token(Token = "0x60078E4")]
		[Address(RVA = "0x157C56C", Offset = "0x157C56C", VA = "0x157C56C", Slot = "7")]
		public virtual float ClampLeftHorizEyeAngle(float angle)
		{
			return 0f;
		}

		// Token: 0x060078E5 RID: 30949 RVA: 0x00053250 File Offset: 0x00051450
		[Token(Token = "0x60078E5")]
		[Address(RVA = "0x157C5FC", Offset = "0x157C5FC", VA = "0x157C5FC", Slot = "8")]
		public virtual float ClampRightHorizEyeAngle(float angle)
		{
			return 0f;
		}

		// Token: 0x060078E6 RID: 30950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60078E6")]
		[Address(RVA = "0x157C68C", Offset = "0x157C68C", VA = "0x157C68C")]
		public void ClearLookTarget()
		{
		}

		// Token: 0x060078E7 RID: 30951 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60078E7")]
		[Address(RVA = "0x157C7CC", Offset = "0x157C7CC", VA = "0x157C7CC")]
		public void ConvertLegacyIfNecessary()
		{
		}

		// Token: 0x060078E8 RID: 30952 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60078E8")]
		[Address(RVA = "0x157C7F8", Offset = "0x157C7F8", VA = "0x157C7F8")]
		private void DrawSightlinesInEditor()
		{
		}

		// Token: 0x060078E9 RID: 30953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60078E9")]
		[Address(RVA = "0x157CC80", Offset = "0x157CC80", VA = "0x157CC80")]
		public void ExportToFile(string filename)
		{
		}

		// Token: 0x060078EA RID: 30954 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60078EA")]
		[Address(RVA = "0x157E0D8", Offset = "0x157E0D8", VA = "0x157E0D8")]
		private IEnumerator FixedUpdateRT()
		{
			return null;
		}

		// Token: 0x060078EB RID: 30955 RVA: 0x00053268 File Offset: 0x00051468
		[Token(Token = "0x60078EB")]
		[Address(RVA = "0x157B694", Offset = "0x157B694", VA = "0x157B694")]
		private Vector3 GetCurrentEyeTargetPos()
		{
			return default(Vector3);
		}

		// Token: 0x060078EC RID: 30956 RVA: 0x00053280 File Offset: 0x00051480
		[Token(Token = "0x60078EC")]
		[Address(RVA = "0x157E174", Offset = "0x157E174", VA = "0x157E174")]
		public Vector3 GetCurrentHeadTargetPos()
		{
			return default(Vector3);
		}

		// Token: 0x060078ED RID: 30957 RVA: 0x00053298 File Offset: 0x00051498
		[Token(Token = "0x60078ED")]
		[Address(RVA = "0x157E24C", Offset = "0x157E24C", VA = "0x157E24C")]
		public Quaternion GetHeadBoneOrientationForLookingAt(Vector3 headTargetGlobal)
		{
			return default(Quaternion);
		}

		// Token: 0x060078EE RID: 30958 RVA: 0x000532B0 File Offset: 0x000514B0
		[Token(Token = "0x60078EE")]
		[Address(RVA = "0x157B1CC", Offset = "0x157B1CC", VA = "0x157B1CC")]
		public Vector3 GetHeadDirection()
		{
			return default(Vector3);
		}

		// Token: 0x060078EF RID: 30959 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60078EF")]
		[Address(RVA = "0x15799CC", Offset = "0x15799CC", VA = "0x15799CC")]
		public Transform GetHeadParentXform()
		{
			return null;
		}

		// Token: 0x060078F0 RID: 30960 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60078F0")]
		[Address(RVA = "0x1579FA0", Offset = "0x1579FA0", VA = "0x1579FA0")]
		private Transform GetHeadXformForImportExport()
		{
			return null;
		}

		// Token: 0x060078F1 RID: 30961 RVA: 0x000532C8 File Offset: 0x000514C8
		[Token(Token = "0x60078F1")]
		[Address(RVA = "0x157E268", Offset = "0x157E268", VA = "0x157E268")]
		private Vector3 GetLeftEyeDirection()
		{
			return default(Vector3);
		}

		// Token: 0x060078F2 RID: 30962 RVA: 0x000532E0 File Offset: 0x000514E0
		[Token(Token = "0x60078F2")]
		[Address(RVA = "0x157B8E4", Offset = "0x157B8E4", VA = "0x157B8E4")]
		private Vector3 GetLookTargetPosForSocialTriangle(EyeAndHeadAnimator.FaceLookTarget playerFaceLookTarget)
		{
			return default(Vector3);
		}

		// Token: 0x060078F3 RID: 30963 RVA: 0x000532F8 File Offset: 0x000514F8
		[Token(Token = "0x60078F3")]
		[Address(RVA = "0x157B1E8", Offset = "0x157B1E8", VA = "0x157B1E8")]
		public Vector3 GetOwnEyeCenter()
		{
			return default(Vector3);
		}

		// Token: 0x060078F4 RID: 30964 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60078F4")]
		[Address(RVA = "0x157E47C", Offset = "0x157E47C", VA = "0x157E47C")]
		public Transform GetOwnEyeCenterXform()
		{
			return null;
		}

		// Token: 0x060078F5 RID: 30965 RVA: 0x00053310 File Offset: 0x00051510
		[Token(Token = "0x60078F5")]
		[Address(RVA = "0x157E484", Offset = "0x157E484", VA = "0x157E484")]
		private Vector3 GetOwnLookDirection()
		{
			return default(Vector3);
		}

		// Token: 0x060078F6 RID: 30966 RVA: 0x00053328 File Offset: 0x00051528
		[Token(Token = "0x60078F6")]
		[Address(RVA = "0x157E6F0", Offset = "0x157E6F0", VA = "0x157E6F0")]
		private Vector3 GetRightEyeDirection()
		{
			return default(Vector3);
		}

		// Token: 0x060078F7 RID: 30967 RVA: 0x00053340 File Offset: 0x00051540
		[Token(Token = "0x60078F7")]
		[Address(RVA = "0x157E904", Offset = "0x157E904", VA = "0x157E904")]
		public float GetStareAngleMeAtTarget(Vector3 target)
		{
			return 0f;
		}

		// Token: 0x060078F8 RID: 30968 RVA: 0x00053358 File Offset: 0x00051558
		[Token(Token = "0x60078F8")]
		[Address(RVA = "0x157EA40", Offset = "0x157EA40", VA = "0x157EA40")]
		public float GetStareAngleTargetAtMe(Transform targetXform)
		{
			return 0f;
		}

		// Token: 0x060078F9 RID: 30969 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60078F9")]
		[Address(RVA = "0x157EBA0", Offset = "0x157EBA0", VA = "0x157EBA0")]
		private void Import(EyeAndHeadAnimatorForSerialization import)
		{
		}

		// Token: 0x060078FA RID: 30970 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60078FA")]
		[Address(RVA = "0x1580908", Offset = "0x1580908", VA = "0x1580908")]
		public void ImportFromFile(string filename)
		{
		}

		// Token: 0x060078FB RID: 30971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60078FB")]
		[Address(RVA = "0x1580C74", Offset = "0x1580C74", VA = "0x1580C74")]
		public void ImportFromJson(string json)
		{
		}

		// Token: 0x060078FC RID: 30972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60078FC")]
		[Address(RVA = "0x15796DC", Offset = "0x15796DC", VA = "0x15796DC")]
		public void Initialize()
		{
		}

		// Token: 0x060078FD RID: 30973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60078FD")]
		[Address(RVA = "0x1580E8C", Offset = "0x1580E8C", VA = "0x1580E8C")]
		private void InitializeCreatedTargetXforms()
		{
		}

		// Token: 0x060078FE RID: 30974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60078FE")]
		[Address(RVA = "0x1581CF4", Offset = "0x1581CF4", VA = "0x1581CF4")]
		private void InitializeEyelids()
		{
		}

		// Token: 0x060078FF RID: 30975 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60078FF")]
		[Address(RVA = "0x15812C8", Offset = "0x15812C8", VA = "0x15812C8")]
		private void InitializeEyes()
		{
		}

		// Token: 0x06007900 RID: 30976 RVA: 0x00053370 File Offset: 0x00051570
		[Token(Token = "0x6007900")]
		[Address(RVA = "0x1581E18", Offset = "0x1581E18", VA = "0x1581E18", Slot = "9")]
		public virtual bool IsInView(Vector3 target)
		{
			return default(bool);
		}

		// Token: 0x06007901 RID: 30977 RVA: 0x00053388 File Offset: 0x00051588
		[Token(Token = "0x6007901")]
		[Address(RVA = "0x15823C0", Offset = "0x15823C0", VA = "0x15823C0")]
		public bool IsLookingAtFace()
		{
			return default(bool);
		}

		// Token: 0x06007902 RID: 30978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007902")]
		[Address(RVA = "0x15823D0", Offset = "0x15823D0", VA = "0x15823D0")]
		private void LateUpdate()
		{
		}

		// Token: 0x06007903 RID: 30979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007903")]
		[Address(RVA = "0x1582618", Offset = "0x1582618", VA = "0x1582618")]
		public void LookAtFace(Transform eyeCenterXform, float headLatency = 0.075f)
		{
		}

		// Token: 0x06007904 RID: 30980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007904")]
		[Address(RVA = "0x15826A4", Offset = "0x15826A4", VA = "0x15826A4")]
		public void LookAtFace(Transform leftEyeXform, Transform rightEyeXform, Transform eyesCenterXform, float headLatency = 0.075f)
		{
		}

		// Token: 0x06007905 RID: 30981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007905")]
		[Address(RVA = "0x1582740", Offset = "0x1582740", VA = "0x1582740")]
		public void LookAtSpecificThing(Transform poi, float headLatency = 0.075f)
		{
		}

		// Token: 0x06007906 RID: 30982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007906")]
		[Address(RVA = "0x15827C8", Offset = "0x15827C8", VA = "0x15827C8")]
		public void LookAtSpecificThing(Vector3 point, float headLatency = 0.075f)
		{
		}

		// Token: 0x06007907 RID: 30983 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007907")]
		[Address(RVA = "0x15797AC", Offset = "0x15797AC", VA = "0x15797AC")]
		public void LookAroundIdly()
		{
		}

		// Token: 0x06007908 RID: 30984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007908")]
		[Address(RVA = "0x1582874", Offset = "0x1582874", VA = "0x1582874")]
		public void LookAtAreaAround(Transform poi)
		{
		}

		// Token: 0x06007909 RID: 30985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007909")]
		[Address(RVA = "0x157C728", Offset = "0x157C728", VA = "0x157C728")]
		public void LookAtAreaAround(Vector3 point)
		{
		}

		// Token: 0x0600790A RID: 30986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600790A")]
		[Address(RVA = "0x1582900", Offset = "0x1582900", VA = "0x1582900")]
		private void OnAnimatorIK(int layerIndex)
		{
		}

		// Token: 0x0600790B RID: 30987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600790B")]
		[Address(RVA = "0x1582968", Offset = "0x1582968", VA = "0x1582968")]
		private void OnCreatedXformDestroyed(DestroyNotifier destroyNotifer)
		{
		}

		// Token: 0x0600790C RID: 30988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600790C")]
		[Address(RVA = "0x1582A70", Offset = "0x1582A70", VA = "0x1582A70")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600790D RID: 30989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600790D")]
		[Address(RVA = "0x1582C98", Offset = "0x1582C98", VA = "0x1582C98")]
		private void OnDisable()
		{
		}

		// Token: 0x0600790E RID: 30990 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600790E")]
		[Address(RVA = "0x1582E1C", Offset = "0x1582E1C", VA = "0x1582E1C")]
		private void OnEarlyUpdate()
		{
		}

		// Token: 0x0600790F RID: 30991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600790F")]
		[Address(RVA = "0x1582E78", Offset = "0x1582E78", VA = "0x1582E78")]
		private void OnEnable()
		{
		}

		// Token: 0x06007910 RID: 30992 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007910")]
		[Address(RVA = "0x15837C0", Offset = "0x15837C0", VA = "0x15837C0")]
		private void OnValidate()
		{
		}

		// Token: 0x06007911 RID: 30993 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007911")]
		[Address(RVA = "0x1583BC8", Offset = "0x1583BC8", VA = "0x1583BC8")]
		private void OnVeryLateUpdate()
		{
		}

		// Token: 0x06007912 RID: 30994 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007912")]
		[Address(RVA = "0x1583C44", Offset = "0x1583C44", VA = "0x1583C44")]
		public void ResetBlinking()
		{
		}

		// Token: 0x06007913 RID: 30995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007913")]
		[Address(RVA = "0x157B85C", Offset = "0x157B85C", VA = "0x157B85C")]
		private void ResetTimeToMacroSaccade()
		{
		}

		// Token: 0x06007914 RID: 30996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007914")]
		[Address(RVA = "0x1583C94", Offset = "0x1583C94", VA = "0x1583C94")]
		private void ResetTimeToMicroSaccade()
		{
		}

		// Token: 0x06007915 RID: 30997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007915")]
		[Address(RVA = "0x1583D40", Offset = "0x1583D40", VA = "0x1583D40")]
		public void SetMacroSaccadesPerMinute(float macroSaccadesPerMinute)
		{
		}

		// Token: 0x06007916 RID: 30998 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007916")]
		[Address(RVA = "0x157B76C", Offset = "0x157B76C", VA = "0x157B76C")]
		private void SetMacroSaccadeTarget(Vector3 targetGlobal, bool blinkIfEyesMoveEnough = true)
		{
		}

		// Token: 0x06007917 RID: 30999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007917")]
		[Address(RVA = "0x1583D48", Offset = "0x1583D48", VA = "0x1583D48")]
		public void SetMicroSaccadesPerMinuteLookingIdle(float microSaccadesPerMinuteLookingIdle)
		{
		}

		// Token: 0x06007918 RID: 31000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007918")]
		[Address(RVA = "0x1583D50", Offset = "0x1583D50", VA = "0x1583D50")]
		public void SetMicroSaccadesPerMinuteLookingAtPOI(float microSaccadesPerMinuteLookingAtPOI)
		{
		}

		// Token: 0x06007919 RID: 31001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007919")]
		[Address(RVA = "0x157BF70", Offset = "0x157BF70", VA = "0x157BF70")]
		private void SetMicroSaccadeTarget(Vector3 targetGlobal, bool blinkIfEyesMoveEnough = true)
		{
		}

		// Token: 0x0600791A RID: 31002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600791A")]
		[Address(RVA = "0x157B204", Offset = "0x157B204", VA = "0x157B204")]
		private void StartEyeMovement([Optional] Transform targetXform, bool blinkIfEyesMoveEnough = true)
		{
		}

		// Token: 0x0600791B RID: 31003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600791B")]
		[Address(RVA = "0x157B378", Offset = "0x157B378", VA = "0x157B378")]
		private void StartHeadMovement([Optional] Transform targetXform)
		{
		}

		// Token: 0x0600791C RID: 31004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600791C")]
		[Address(RVA = "0x1583D98", Offset = "0x1583D98", VA = "0x1583D98")]
		private void Update()
		{
		}

		// Token: 0x0600791D RID: 31005 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600791D")]
		[Address(RVA = "0x158294C", Offset = "0x158294C", VA = "0x158294C")]
		public void Update1()
		{
		}

		// Token: 0x0600791E RID: 31006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600791E")]
		[Address(RVA = "0x1582420", Offset = "0x1582420", VA = "0x1582420")]
		public void Update1(float deltaTime)
		{
		}

		// Token: 0x0600791F RID: 31007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600791F")]
		[Address(RVA = "0x1583C28", Offset = "0x1583C28", VA = "0x1583C28")]
		public void Update2()
		{
		}

		// Token: 0x06007920 RID: 31008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007920")]
		[Address(RVA = "0x1583E58", Offset = "0x1583E58", VA = "0x1583E58")]
		public void Update2(float deltaTime)
		{
		}

		// Token: 0x06007921 RID: 31009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007921")]
		[Address(RVA = "0x158503C", Offset = "0x158503C", VA = "0x158503C")]
		private void UpdateEyelids()
		{
		}

		// Token: 0x06007922 RID: 31010 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007922")]
		[Address(RVA = "0x158414C", Offset = "0x158414C", VA = "0x158414C")]
		private void UpdateEyeMovement(float deltaTime)
		{
		}

		// Token: 0x06007923 RID: 31011 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007923")]
		[Address(RVA = "0x15852E0", Offset = "0x15852E0", VA = "0x15852E0")]
		public EyeAndHeadAnimator()
		{
		}

		// Token: 0x040032C3 RID: 12995
		[Token(Token = "0x40032C3")]
		[FieldOffset(Offset = "0x18")]
		public float mainWeight;

		// Token: 0x040032C4 RID: 12996
		[Token(Token = "0x40032C4")]
		private const float kMaxHorizViewAngle = 100f;

		// Token: 0x040032C5 RID: 12997
		[Token(Token = "0x40032C5")]
		private const float kMaxVertViewAngle = 60f;

		// Token: 0x040032C6 RID: 12998
		[Token(Token = "0x40032C6")]
		private const float kAttentionChangeDeadTimeAfterSaccadeEnd = 0.3f;

		// Token: 0x040032CA RID: 13002
		[Token(Token = "0x40032CA")]
		[FieldOffset(Offset = "0x38")]
		public float headChangeToNewTargetSpeed;

		// Token: 0x040032CB RID: 13003
		[Token(Token = "0x40032CB")]
		[FieldOffset(Offset = "0x3C")]
		public float headTrackTargetSpeed;

		// Token: 0x040032CC RID: 13004
		[Token(Token = "0x40032CC")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float headSpeedModifier;

		// Token: 0x040032CD RID: 13005
		[Token(Token = "0x40032CD")]
		[FieldOffset(Offset = "0x44")]
		public float headWeight;

		// Token: 0x040032CE RID: 13006
		[Token(Token = "0x40032CE")]
		[FieldOffset(Offset = "0x48")]
		public float bodyWeight;

		// Token: 0x040032CF RID: 13007
		[Token(Token = "0x40032CF")]
		[FieldOffset(Offset = "0x4C")]
		public float neckHorizWeight;

		// Token: 0x040032D0 RID: 13008
		[Token(Token = "0x40032D0")]
		[FieldOffset(Offset = "0x50")]
		public float neckVertWeight;

		// Token: 0x040032D1 RID: 13009
		[Token(Token = "0x40032D1")]
		[FieldOffset(Offset = "0x54")]
		public float headPitchAngle;

		// Token: 0x040032D2 RID: 13010
		[Token(Token = "0x40032D2")]
		[FieldOffset(Offset = "0x58")]
		[FormerlySerializedAs("headTilt")]
		public float headRollAngle;

		// Token: 0x040032D3 RID: 13011
		[Token(Token = "0x40032D3")]
		[FieldOffset(Offset = "0x5C")]
		public float headYawAngle;

		// Token: 0x040032D4 RID: 13012
		[Token(Token = "0x40032D4")]
		[FieldOffset(Offset = "0x60")]
		public float neckPitchAngle;

		// Token: 0x040032D5 RID: 13013
		[Token(Token = "0x40032D5")]
		[FieldOffset(Offset = "0x64")]
		[FormerlySerializedAs("neckTilt")]
		public float neckRollAngle;

		// Token: 0x040032D6 RID: 13014
		[Token(Token = "0x40032D6")]
		[FieldOffset(Offset = "0x68")]
		public float neckYawAngle;

		// Token: 0x040032D7 RID: 13015
		[Token(Token = "0x40032D7")]
		[FieldOffset(Offset = "0x6C")]
		public bool resetHeadAtFrameStart;

		// Token: 0x040032D8 RID: 13016
		[Token(Token = "0x40032D8")]
		[FieldOffset(Offset = "0x70")]
		[FormerlySerializedAs("headBoneNonMecanimXform")]
		public Transform headBoneNonMecanim;

		// Token: 0x040032D9 RID: 13017
		[Token(Token = "0x40032D9")]
		[FieldOffset(Offset = "0x78")]
		public Transform headTarget;

		// Token: 0x040032DA RID: 13018
		[Token(Token = "0x40032DA")]
		[FieldOffset(Offset = "0x80")]
		public Transform neckBoneNonMecanim;

		// Token: 0x040032DB RID: 13019
		[Token(Token = "0x40032DB")]
		[FieldOffset(Offset = "0x88")]
		public Transform spineBoneNonMecanim;

		// Token: 0x040032DC RID: 13020
		[Token(Token = "0x40032DC")]
		[FieldOffset(Offset = "0x90")]
		public HeadComponent headComponent;

		// Token: 0x040032DD RID: 13021
		[Token(Token = "0x40032DD")]
		[FieldOffset(Offset = "0x98")]
		public float eyesWeight;

		// Token: 0x040032DE RID: 13022
		[Token(Token = "0x40032DE")]
		[FieldOffset(Offset = "0x9C")]
		public bool useMicroSaccades;

		// Token: 0x040032DF RID: 13023
		[Token(Token = "0x40032DF")]
		[FieldOffset(Offset = "0x9D")]
		public bool useMacroSaccades;

		// Token: 0x040032E0 RID: 13024
		[Token(Token = "0x40032E0")]
		[FieldOffset(Offset = "0xA0")]
		public float saccadeSpeed;

		// Token: 0x040032E1 RID: 13025
		[Token(Token = "0x40032E1")]
		[FieldOffset(Offset = "0xA4")]
		[SerializeField]
		private float macroSaccadesPerMinute;

		// Token: 0x040032E2 RID: 13026
		[Token(Token = "0x40032E2")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[FormerlySerializedAs("microSaccadesPerMinute")]
		private float microSaccadesPerMinuteLookingIdle;

		// Token: 0x040032E3 RID: 13027
		[Token(Token = "0x40032E3")]
		[FieldOffset(Offset = "0xAC")]
		[SerializeField]
		private float microSaccadesPerMinuteLookingAtPOI;

		// Token: 0x040032E4 RID: 13028
		[Token(Token = "0x40032E4")]
		[FieldOffset(Offset = "0xB0")]
		public bool useHeadJitter;

		// Token: 0x040032E5 RID: 13029
		[Token(Token = "0x40032E5")]
		[FieldOffset(Offset = "0xB4")]
		public float headJitterFrequency;

		// Token: 0x040032E6 RID: 13030
		[Token(Token = "0x40032E6")]
		[FieldOffset(Offset = "0xB8")]
		public float headJitterAmplitude;

		// Token: 0x040032E7 RID: 13031
		[Token(Token = "0x40032E7")]
		[FieldOffset(Offset = "0xBC")]
		public bool kDrawSightlinesInEditor;

		// Token: 0x040032E8 RID: 13032
		[Token(Token = "0x40032E8")]
		[FieldOffset(Offset = "0xBD")]
		[SerializeField]
		private bool areUpdatedControlledExternally;

		// Token: 0x040032E9 RID: 13033
		[Token(Token = "0x40032E9")]
		[FieldOffset(Offset = "0xC0")]
		public EyeAndHeadAnimator.UpdateType updateType;

		// Token: 0x040032EA RID: 13034
		[Token(Token = "0x40032EA")]
		[FieldOffset(Offset = "0xC8")]
		public ControlData controlData;

		// Token: 0x040032EB RID: 13035
		[Token(Token = "0x40032EB")]
		[FieldOffset(Offset = "0xD0")]
		public float eyelidsWeight;

		// Token: 0x040032EC RID: 13036
		[Token(Token = "0x40032EC")]
		[FieldOffset(Offset = "0xD4")]
		public float kMinNextBlinkTime;

		// Token: 0x040032ED RID: 13037
		[Token(Token = "0x40032ED")]
		[FieldOffset(Offset = "0xD8")]
		public float kMaxNextBlinkTime;

		// Token: 0x040032EE RID: 13038
		[Token(Token = "0x40032EE")]
		[FieldOffset(Offset = "0xDC")]
		public float blinkSpeed;

		// Token: 0x040032EF RID: 13039
		[Token(Token = "0x40032EF")]
		[FieldOffset(Offset = "0xE0")]
		public bool eyelidsFollowEyesVertically;

		// Token: 0x040032F0 RID: 13040
		[Token(Token = "0x40032F0")]
		[FieldOffset(Offset = "0xE8")]
		private BlinkingComponent blinkingComponent;

		// Token: 0x040032F1 RID: 13041
		[Token(Token = "0x40032F1")]
		[FieldOffset(Offset = "0xF0")]
		private bool useUpperEyelids;

		// Token: 0x040032F2 RID: 13042
		[Token(Token = "0x40032F2")]
		[FieldOffset(Offset = "0xF1")]
		private bool useLowerEyelids;

		// Token: 0x040032F3 RID: 13043
		[Token(Token = "0x40032F3")]
		[FieldOffset(Offset = "0xF4")]
		public float maxEyeHorizAngle;

		// Token: 0x040032F4 RID: 13044
		[Token(Token = "0x40032F4")]
		[FieldOffset(Offset = "0xF8")]
		public float maxEyeHorizAngleTowardsNose;

		// Token: 0x040032F5 RID: 13045
		[Token(Token = "0x40032F5")]
		[FieldOffset(Offset = "0xFC")]
		public float idleTargetHorizAngle;

		// Token: 0x040032F6 RID: 13046
		[Token(Token = "0x40032F6")]
		[FieldOffset(Offset = "0x100")]
		public float crossEyeCorrection;

		// Token: 0x040032F7 RID: 13047
		[Token(Token = "0x40032F7")]
		[FieldOffset(Offset = "0x104")]
		public float limitHeadAngle;

		// Token: 0x040032FE RID: 13054
		[Token(Token = "0x40032FE")]
		[FieldOffset(Offset = "0x160")]
		private Transform leftEyeAnchor;

		// Token: 0x040032FF RID: 13055
		[Token(Token = "0x40032FF")]
		[FieldOffset(Offset = "0x168")]
		private Transform rightEyeAnchor;

		// Token: 0x04003300 RID: 13056
		[Token(Token = "0x4003300")]
		[FieldOffset(Offset = "0x170")]
		private float leftMaxSpeedHoriz;

		// Token: 0x04003301 RID: 13057
		[Token(Token = "0x4003301")]
		[FieldOffset(Offset = "0x174")]
		private float leftHorizDuration;

		// Token: 0x04003302 RID: 13058
		[Token(Token = "0x4003302")]
		[FieldOffset(Offset = "0x178")]
		private float leftMaxSpeedVert;

		// Token: 0x04003303 RID: 13059
		[Token(Token = "0x4003303")]
		[FieldOffset(Offset = "0x17C")]
		private float leftVertDuration;

		// Token: 0x04003304 RID: 13060
		[Token(Token = "0x4003304")]
		[FieldOffset(Offset = "0x180")]
		private float leftCurrentSpeedX;

		// Token: 0x04003305 RID: 13061
		[Token(Token = "0x4003305")]
		[FieldOffset(Offset = "0x184")]
		private float leftCurrentSpeedY;

		// Token: 0x04003306 RID: 13062
		[Token(Token = "0x4003306")]
		[FieldOffset(Offset = "0x188")]
		private float rightMaxSpeedHoriz;

		// Token: 0x04003307 RID: 13063
		[Token(Token = "0x4003307")]
		[FieldOffset(Offset = "0x18C")]
		private float rightHorizDuration;

		// Token: 0x04003308 RID: 13064
		[Token(Token = "0x4003308")]
		[FieldOffset(Offset = "0x190")]
		private float rightMaxSpeedVert;

		// Token: 0x04003309 RID: 13065
		[Token(Token = "0x4003309")]
		[FieldOffset(Offset = "0x194")]
		private float rightVertDuration;

		// Token: 0x0400330A RID: 13066
		[Token(Token = "0x400330A")]
		[FieldOffset(Offset = "0x198")]
		private float rightCurrentSpeedX;

		// Token: 0x0400330B RID: 13067
		[Token(Token = "0x400330B")]
		[FieldOffset(Offset = "0x19C")]
		private float rightCurrentSpeedY;

		// Token: 0x0400330C RID: 13068
		[Token(Token = "0x400330C")]
		[FieldOffset(Offset = "0x1A0")]
		private float startLeftEyeHorizDuration;

		// Token: 0x0400330D RID: 13069
		[Token(Token = "0x400330D")]
		[FieldOffset(Offset = "0x1A4")]
		private float startLeftEyeVertDuration;

		// Token: 0x0400330E RID: 13070
		[Token(Token = "0x400330E")]
		[FieldOffset(Offset = "0x1A8")]
		private float startLeftEyeMaxSpeedHoriz;

		// Token: 0x0400330F RID: 13071
		[Token(Token = "0x400330F")]
		[FieldOffset(Offset = "0x1AC")]
		private float startLeftEyeMaxSpeedVert;

		// Token: 0x04003310 RID: 13072
		[Token(Token = "0x4003310")]
		[FieldOffset(Offset = "0x1B0")]
		private float startRightEyeHorizDuration;

		// Token: 0x04003311 RID: 13073
		[Token(Token = "0x4003311")]
		[FieldOffset(Offset = "0x1B4")]
		private float startRightEyeVertDuration;

		// Token: 0x04003312 RID: 13074
		[Token(Token = "0x4003312")]
		[FieldOffset(Offset = "0x1B8")]
		private float startRightEyeMaxSpeedHoriz;

		// Token: 0x04003313 RID: 13075
		[Token(Token = "0x4003313")]
		[FieldOffset(Offset = "0x1BC")]
		private float startRightEyeMaxSpeedVert;

		// Token: 0x04003314 RID: 13076
		[Token(Token = "0x4003314")]
		[FieldOffset(Offset = "0x1C0")]
		private float timeOfEyeMovementStart;

		// Token: 0x04003315 RID: 13077
		[Token(Token = "0x4003315")]
		[FieldOffset(Offset = "0x1C4")]
		private float headLatency;

		// Token: 0x04003316 RID: 13078
		[Token(Token = "0x4003316")]
		[FieldOffset(Offset = "0x1C8")]
		private float eyeLatency;

		// Token: 0x04003317 RID: 13079
		[Token(Token = "0x4003317")]
		[FieldOffset(Offset = "0x1D0")]
		private Animator animator;

		// Token: 0x04003318 RID: 13080
		[Token(Token = "0x4003318")]
		[FieldOffset(Offset = "0x1D8")]
		private EarlyUpdateCallback earlyUpdateCallback;

		// Token: 0x04003319 RID: 13081
		[Token(Token = "0x4003319")]
		[FieldOffset(Offset = "0x1E0")]
		private VeryLateUpdateCallback veryLateUpdateCallback;

		// Token: 0x0400331A RID: 13082
		[Token(Token = "0x400331A")]
		[FieldOffset(Offset = "0x1E8")]
		private bool hasCheckedIdleLookTargetsThisFrame;

		// Token: 0x0400331B RID: 13083
		[Token(Token = "0x400331B")]
		[FieldOffset(Offset = "0x1E9")]
		private bool placeNewIdleLookTargetsAtNextOpportunity;

		// Token: 0x0400331C RID: 13084
		[Token(Token = "0x400331C")]
		[FieldOffset(Offset = "0x1EA")]
		private bool hasFixedUpdateRunThisFrame;

		// Token: 0x0400331D RID: 13085
		[Token(Token = "0x400331D")]
		[FieldOffset(Offset = "0x1F0")]
		private Transform currentHeadTargetPOI;

		// Token: 0x0400331E RID: 13086
		[Token(Token = "0x400331E")]
		[FieldOffset(Offset = "0x1F8")]
		private Transform currentEyeTargetPOI;

		// Token: 0x0400331F RID: 13087
		[Token(Token = "0x400331F")]
		[FieldOffset(Offset = "0x200")]
		private Transform nextHeadTargetPOI;

		// Token: 0x04003320 RID: 13088
		[Token(Token = "0x4003320")]
		[FieldOffset(Offset = "0x208")]
		private Transform nextEyeTargetPOI;

		// Token: 0x04003321 RID: 13089
		[Token(Token = "0x4003321")]
		[FieldOffset(Offset = "0x210")]
		private Transform socialTriangleLeftEyeXform;

		// Token: 0x04003322 RID: 13090
		[Token(Token = "0x4003322")]
		[FieldOffset(Offset = "0x218")]
		private Transform socialTriangleRightEyeXform;

		// Token: 0x04003323 RID: 13091
		[Token(Token = "0x4003323")]
		[FieldOffset(Offset = "0x220")]
		private readonly Transform[] createdTargetXforms;

		// Token: 0x04003324 RID: 13092
		[Token(Token = "0x4003324")]
		[FieldOffset(Offset = "0x228")]
		private int createdTargetXformIndex;

		// Token: 0x04003326 RID: 13094
		[Token(Token = "0x4003326")]
		[FieldOffset(Offset = "0x238")]
		private Quaternion eyeRoot_From_leftEyeAnchor_Q;

		// Token: 0x04003327 RID: 13095
		[Token(Token = "0x4003327")]
		[FieldOffset(Offset = "0x248")]
		private Quaternion eyeRoot_From_rightEyeAnchor_Q;

		// Token: 0x04003328 RID: 13096
		[Token(Token = "0x4003328")]
		[FieldOffset(Offset = "0x258")]
		private Quaternion leftEyeAnchor_From_eyeRoot_Q;

		// Token: 0x04003329 RID: 13097
		[Token(Token = "0x4003329")]
		[FieldOffset(Offset = "0x268")]
		private Quaternion rightEyeAnchor_From_eyeRoot_Q;

		// Token: 0x0400332A RID: 13098
		[Token(Token = "0x400332A")]
		[FieldOffset(Offset = "0x278")]
		private Vector3 currentLeftEyeLocalEuler;

		// Token: 0x0400332B RID: 13099
		[Token(Token = "0x400332B")]
		[FieldOffset(Offset = "0x284")]
		private Vector3 currentRightEyeLocalEuler;

		// Token: 0x0400332C RID: 13100
		[Token(Token = "0x400332C")]
		[FieldOffset(Offset = "0x290")]
		private Quaternion originalLeftEyeLocalQ;

		// Token: 0x0400332D RID: 13101
		[Token(Token = "0x400332D")]
		[FieldOffset(Offset = "0x2A0")]
		private Quaternion originalRightEyeLocalQ;

		// Token: 0x0400332E RID: 13102
		[Token(Token = "0x400332E")]
		[FieldOffset(Offset = "0x2B0")]
		private Quaternion lastLeftEyeLocalQ;

		// Token: 0x0400332F RID: 13103
		[Token(Token = "0x400332F")]
		[FieldOffset(Offset = "0x2C0")]
		private Quaternion lastRightEyeLocalQ;

		// Token: 0x04003330 RID: 13104
		[Token(Token = "0x4003330")]
		[FieldOffset(Offset = "0x2D0")]
		private Vector3 macroSaccadeTargetLocal;

		// Token: 0x04003331 RID: 13105
		[Token(Token = "0x4003331")]
		[FieldOffset(Offset = "0x2DC")]
		private Vector3 microSaccadeTargetLocal;

		// Token: 0x04003332 RID: 13106
		[Token(Token = "0x4003332")]
		[FieldOffset(Offset = "0x2E8")]
		private float timeOfEnteringClearingPhase;

		// Token: 0x04003333 RID: 13107
		[Token(Token = "0x4003333")]
		[FieldOffset(Offset = "0x2EC")]
		private float timeOfCheckingWhetherIdleTargetOutOfView;

		// Token: 0x04003334 RID: 13108
		[Token(Token = "0x4003334")]
		[FieldOffset(Offset = "0x2F0")]
		private float timeToMicroSaccade;

		// Token: 0x04003335 RID: 13109
		[Token(Token = "0x4003335")]
		[FieldOffset(Offset = "0x2F4")]
		private float timeToMacroSaccade;

		// Token: 0x04003336 RID: 13110
		[Token(Token = "0x4003336")]
		[FieldOffset(Offset = "0x2F8")]
		private bool isInitialized;

		// Token: 0x04003337 RID: 13111
		[Token(Token = "0x4003337")]
		[FieldOffset(Offset = "0x300")]
		private Coroutine fixedUpdateCoroutine;

		// Token: 0x04003338 RID: 13112
		[Token(Token = "0x4003338")]
		[FieldOffset(Offset = "0x308")]
		private EyeAndHeadAnimator.LookTarget lookTarget;

		// Token: 0x04003339 RID: 13113
		[Token(Token = "0x4003339")]
		[FieldOffset(Offset = "0x30C")]
		private EyeAndHeadAnimator.FaceLookTarget faceLookTarget;

		// Token: 0x0400333A RID: 13114
		[Token(Token = "0x400333A")]
		[FieldOffset(Offset = "0x310")]
		private float defalutMaxEyeHorizAngle;

		// Token: 0x0400333B RID: 13115
		[Token(Token = "0x400333B")]
		[FieldOffset(Offset = "0x314")]
		private float defaultMaxEyeHorizAngleTowardsNose;

		// Token: 0x02000C61 RID: 3169
		[Token(Token = "0x2000C61")]
		public enum UpdateType
		{
			// Token: 0x0400333D RID: 13117
			[Token(Token = "0x400333D")]
			LateUpdate,
			// Token: 0x0400333E RID: 13118
			[Token(Token = "0x400333E")]
			FixedUpdate,
			// Token: 0x0400333F RID: 13119
			[Token(Token = "0x400333F")]
			External
		}

		// Token: 0x02000C62 RID: 3170
		[Token(Token = "0x2000C62")]
		private enum LookTarget
		{
			// Token: 0x04003341 RID: 13121
			[Token(Token = "0x4003341")]
			None,
			// Token: 0x04003342 RID: 13122
			[Token(Token = "0x4003342")]
			StraightAhead,
			// Token: 0x04003343 RID: 13123
			[Token(Token = "0x4003343")]
			ClearingTargetPhase1,
			// Token: 0x04003344 RID: 13124
			[Token(Token = "0x4003344")]
			ClearingTargetPhase2,
			// Token: 0x04003345 RID: 13125
			[Token(Token = "0x4003345")]
			GeneralDirection,
			// Token: 0x04003346 RID: 13126
			[Token(Token = "0x4003346")]
			LookingAroundIdly,
			// Token: 0x04003347 RID: 13127
			[Token(Token = "0x4003347")]
			SpecificThing,
			// Token: 0x04003348 RID: 13128
			[Token(Token = "0x4003348")]
			Face
		}

		// Token: 0x02000C63 RID: 3171
		[Token(Token = "0x2000C63")]
		private enum FaceLookTarget
		{
			// Token: 0x0400334A RID: 13130
			[Token(Token = "0x400334A")]
			EyesCenter,
			// Token: 0x0400334B RID: 13131
			[Token(Token = "0x400334B")]
			LeftEye,
			// Token: 0x0400334C RID: 13132
			[Token(Token = "0x400334C")]
			RightEye,
			// Token: 0x0400334D RID: 13133
			[Token(Token = "0x400334D")]
			Mouth
		}
	}
}
