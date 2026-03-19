using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Serialization;

namespace EPOOutline
{
	// Token: 0x02000CA0 RID: 3232
	[Token(Token = "0x2000CA0")]
	[RequireComponent(typeof(Camera))]
	[ExecuteAlways]
	public class Outliner : MonoBehaviour
	{
		// Token: 0x17000AF2 RID: 2802
		// (get) Token: 0x06007A69 RID: 31337 RVA: 0x00053C10 File Offset: 0x00051E10
		// (set) Token: 0x06007A6A RID: 31338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AF2")]
		[Obsolete]
		public float InfoRendererScale
		{
			[Token(Token = "0x6007A69")]
			[Address(RVA = "0x32197DC", Offset = "0x32197DC", VA = "0x32197DC")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6007A6A")]
			[Address(RVA = "0x321981C", Offset = "0x321981C", VA = "0x321981C")]
			set
			{
			}
		}

		// Token: 0x17000AF3 RID: 2803
		// (get) Token: 0x06007A6B RID: 31339 RVA: 0x00053C28 File Offset: 0x00051E28
		// (set) Token: 0x06007A6C RID: 31340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AF3")]
		public int PrimarySizeReference
		{
			[Token(Token = "0x6007A6B")]
			[Address(RVA = "0x321985C", Offset = "0x321985C", VA = "0x321985C")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6007A6C")]
			[Address(RVA = "0x3219864", Offset = "0x3219864", VA = "0x3219864")]
			set
			{
			}
		}

		// Token: 0x17000AF4 RID: 2804
		// (get) Token: 0x06007A6D RID: 31341 RVA: 0x00053C40 File Offset: 0x00051E40
		// (set) Token: 0x06007A6E RID: 31342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AF4")]
		public BufferSizeMode PrimaryBufferSizeMode
		{
			[Token(Token = "0x6007A6D")]
			[Address(RVA = "0x321986C", Offset = "0x321986C", VA = "0x321986C")]
			get
			{
				return BufferSizeMode.WidthControllsHeight;
			}
			[Token(Token = "0x6007A6E")]
			[Address(RVA = "0x3219874", Offset = "0x3219874", VA = "0x3219874")]
			set
			{
			}
		}

		// Token: 0x17000AF5 RID: 2805
		// (get) Token: 0x06007A6F RID: 31343 RVA: 0x00053C58 File Offset: 0x00051E58
		[Token(Token = "0x17000AF5")]
		private CameraEvent Event
		{
			[Token(Token = "0x6007A6F")]
			[Address(RVA = "0x321987C", Offset = "0x321987C", VA = "0x321987C")]
			get
			{
				return default(CameraEvent);
			}
		}

		// Token: 0x17000AF6 RID: 2806
		// (get) Token: 0x06007A70 RID: 31344 RVA: 0x00053C70 File Offset: 0x00051E70
		// (set) Token: 0x06007A71 RID: 31345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AF6")]
		public OutlineRenderingStrategy RenderingStrategy
		{
			[Token(Token = "0x6007A70")]
			[Address(RVA = "0x3219894", Offset = "0x3219894", VA = "0x3219894")]
			get
			{
				return OutlineRenderingStrategy.Default;
			}
			[Token(Token = "0x6007A71")]
			[Address(RVA = "0x321989C", Offset = "0x321989C", VA = "0x321989C")]
			set
			{
			}
		}

		// Token: 0x17000AF7 RID: 2807
		// (get) Token: 0x06007A72 RID: 31346 RVA: 0x00053C88 File Offset: 0x00051E88
		// (set) Token: 0x06007A73 RID: 31347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AF7")]
		public RenderStage RenderStage
		{
			[Token(Token = "0x6007A72")]
			[Address(RVA = "0x32198A4", Offset = "0x32198A4", VA = "0x32198A4")]
			get
			{
				return RenderStage.BeforeTransparents;
			}
			[Token(Token = "0x6007A73")]
			[Address(RVA = "0x32198AC", Offset = "0x32198AC", VA = "0x32198AC")]
			set
			{
			}
		}

		// Token: 0x17000AF8 RID: 2808
		// (get) Token: 0x06007A74 RID: 31348 RVA: 0x00053CA0 File Offset: 0x00051EA0
		// (set) Token: 0x06007A75 RID: 31349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AF8")]
		public DilateQuality DilateQuality
		{
			[Token(Token = "0x6007A74")]
			[Address(RVA = "0x32198B4", Offset = "0x32198B4", VA = "0x32198B4")]
			get
			{
				return DilateQuality.Base;
			}
			[Token(Token = "0x6007A75")]
			[Address(RVA = "0x32198BC", Offset = "0x32198BC", VA = "0x32198BC")]
			set
			{
			}
		}

		// Token: 0x17000AF9 RID: 2809
		// (get) Token: 0x06007A76 RID: 31350 RVA: 0x00053CB8 File Offset: 0x00051EB8
		// (set) Token: 0x06007A77 RID: 31351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AF9")]
		private RenderingMode RenderingMode
		{
			[Token(Token = "0x6007A76")]
			[Address(RVA = "0x32198C4", Offset = "0x32198C4", VA = "0x32198C4")]
			get
			{
				return RenderingMode.LDR;
			}
			[Token(Token = "0x6007A77")]
			[Address(RVA = "0x32198CC", Offset = "0x32198CC", VA = "0x32198CC")]
			set
			{
			}
		}

		// Token: 0x17000AFA RID: 2810
		// (get) Token: 0x06007A78 RID: 31352 RVA: 0x00053CD0 File Offset: 0x00051ED0
		// (set) Token: 0x06007A79 RID: 31353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AFA")]
		public float BlurShift
		{
			[Token(Token = "0x6007A78")]
			[Address(RVA = "0x32198D4", Offset = "0x32198D4", VA = "0x32198D4")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6007A79")]
			[Address(RVA = "0x32198DC", Offset = "0x32198DC", VA = "0x32198DC")]
			set
			{
			}
		}

		// Token: 0x17000AFB RID: 2811
		// (get) Token: 0x06007A7A RID: 31354 RVA: 0x00053CE8 File Offset: 0x00051EE8
		// (set) Token: 0x06007A7B RID: 31355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AFB")]
		public float DilateShift
		{
			[Token(Token = "0x6007A7A")]
			[Address(RVA = "0x32198F8", Offset = "0x32198F8", VA = "0x32198F8")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6007A7B")]
			[Address(RVA = "0x3219900", Offset = "0x3219900", VA = "0x3219900")]
			set
			{
			}
		}

		// Token: 0x17000AFC RID: 2812
		// (get) Token: 0x06007A7C RID: 31356 RVA: 0x00053D00 File Offset: 0x00051F00
		// (set) Token: 0x06007A7D RID: 31357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AFC")]
		public long OutlineLayerMask
		{
			[Token(Token = "0x6007A7C")]
			[Address(RVA = "0x321991C", Offset = "0x321991C", VA = "0x321991C")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x6007A7D")]
			[Address(RVA = "0x3219924", Offset = "0x3219924", VA = "0x3219924")]
			set
			{
			}
		}

		// Token: 0x17000AFD RID: 2813
		// (get) Token: 0x06007A7E RID: 31358 RVA: 0x00053D18 File Offset: 0x00051F18
		// (set) Token: 0x06007A7F RID: 31359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AFD")]
		public float PrimaryRendererScale
		{
			[Token(Token = "0x6007A7E")]
			[Address(RVA = "0x321992C", Offset = "0x321992C", VA = "0x321992C")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6007A7F")]
			[Address(RVA = "0x3219934", Offset = "0x3219934", VA = "0x3219934")]
			set
			{
			}
		}

		// Token: 0x17000AFE RID: 2814
		// (get) Token: 0x06007A80 RID: 31360 RVA: 0x00053D30 File Offset: 0x00051F30
		// (set) Token: 0x06007A81 RID: 31361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AFE")]
		[Obsolete("Fixed incorrect spelling. Use BlurIterations instead")]
		public int BlurIterrations
		{
			[Token(Token = "0x6007A80")]
			[Address(RVA = "0x3219950", Offset = "0x3219950", VA = "0x3219950")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6007A81")]
			[Address(RVA = "0x3219958", Offset = "0x3219958", VA = "0x3219958")]
			set
			{
			}
		}

		// Token: 0x17000AFF RID: 2815
		// (get) Token: 0x06007A82 RID: 31362 RVA: 0x00053D48 File Offset: 0x00051F48
		// (set) Token: 0x06007A83 RID: 31363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AFF")]
		public int BlurIterations
		{
			[Token(Token = "0x6007A82")]
			[Address(RVA = "0x3219990", Offset = "0x3219990", VA = "0x3219990")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6007A83")]
			[Address(RVA = "0x3219974", Offset = "0x3219974", VA = "0x3219974")]
			set
			{
			}
		}

		// Token: 0x17000B00 RID: 2816
		// (get) Token: 0x06007A84 RID: 31364 RVA: 0x00053D60 File Offset: 0x00051F60
		// (set) Token: 0x06007A85 RID: 31365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B00")]
		public BlurType BlurType
		{
			[Token(Token = "0x6007A84")]
			[Address(RVA = "0x3219998", Offset = "0x3219998", VA = "0x3219998")]
			get
			{
				return BlurType.Anisotropic;
			}
			[Token(Token = "0x6007A85")]
			[Address(RVA = "0x32199A0", Offset = "0x32199A0", VA = "0x32199A0")]
			set
			{
			}
		}

		// Token: 0x17000B01 RID: 2817
		// (get) Token: 0x06007A86 RID: 31366 RVA: 0x00053D78 File Offset: 0x00051F78
		// (set) Token: 0x06007A87 RID: 31367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B01")]
		[Obsolete("Fixed incorrect spelling. Use DilateIterations instead")]
		public int DilateIterration
		{
			[Token(Token = "0x6007A86")]
			[Address(RVA = "0x32199A8", Offset = "0x32199A8", VA = "0x32199A8")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6007A87")]
			[Address(RVA = "0x32199B0", Offset = "0x32199B0", VA = "0x32199B0")]
			set
			{
			}
		}

		// Token: 0x17000B02 RID: 2818
		// (get) Token: 0x06007A88 RID: 31368 RVA: 0x00053D90 File Offset: 0x00051F90
		// (set) Token: 0x06007A89 RID: 31369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B02")]
		public int DilateIterations
		{
			[Token(Token = "0x6007A88")]
			[Address(RVA = "0x32199E8", Offset = "0x32199E8", VA = "0x32199E8")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6007A89")]
			[Address(RVA = "0x32199CC", Offset = "0x32199CC", VA = "0x32199CC")]
			set
			{
			}
		}

		// Token: 0x06007A8A RID: 31370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A8A")]
		[Address(RVA = "0x32199F0", Offset = "0x32199F0", VA = "0x32199F0")]
		private void OnValidate()
		{
		}

		// Token: 0x06007A8B RID: 31371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A8B")]
		[Address(RVA = "0x3219A10", Offset = "0x3219A10", VA = "0x3219A10")]
		private void OnEnable()
		{
		}

		// Token: 0x06007A8C RID: 31372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A8C")]
		[Address(RVA = "0x3219B18", Offset = "0x3219B18", VA = "0x3219B18")]
		private void OnDestroy()
		{
		}

		// Token: 0x06007A8D RID: 31373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A8D")]
		[Address(RVA = "0x3219BA4", Offset = "0x3219BA4", VA = "0x3219BA4")]
		private void OnDisable()
		{
		}

		// Token: 0x06007A8E RID: 31374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A8E")]
		[Address(RVA = "0x3219C34", Offset = "0x3219C34", VA = "0x3219C34")]
		private void UpdateBuffer(Camera targetCamera, CommandBuffer buffer, bool removeOnly)
		{
		}

		// Token: 0x06007A8F RID: 31375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A8F")]
		[Address(RVA = "0x3219CCC", Offset = "0x3219CCC", VA = "0x3219CCC")]
		private void OnPreRender()
		{
		}

		// Token: 0x06007A90 RID: 31376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A90")]
		[Address(RVA = "0x3219DA4", Offset = "0x3219DA4", VA = "0x3219DA4")]
		private void SetupOutline(Camera cameraToUse, OutlineParameters parametersToUse, bool isEditor)
		{
		}

		// Token: 0x06007A91 RID: 31377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A91")]
		[Address(RVA = "0x321A43C", Offset = "0x321A43C", VA = "0x321A43C")]
		public void UpdateSharedParameters(OutlineParameters parameters, Camera camera, bool editorCamera)
		{
		}

		// Token: 0x06007A92 RID: 31378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A92")]
		[Address(RVA = "0x321A140", Offset = "0x321A140", VA = "0x321A140")]
		private void UpdateParameters(OutlineParameters parameters, Camera camera, bool editorCamera)
		{
		}

		// Token: 0x06007A93 RID: 31379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A93")]
		[Address(RVA = "0x321A8F0", Offset = "0x321A8F0", VA = "0x321A8F0")]
		public Outliner()
		{
		}

		// Token: 0x040035CE RID: 13774
		[Token(Token = "0x40035CE")]
		[FieldOffset(Offset = "0x0")]
		private static List<Outlinable> temporaryOutlinables;

		// Token: 0x040035CF RID: 13775
		[Token(Token = "0x40035CF")]
		[FieldOffset(Offset = "0x18")]
		private OutlineParameters parameters;

		// Token: 0x040035D0 RID: 13776
		[Token(Token = "0x40035D0")]
		[FieldOffset(Offset = "0x20")]
		private Camera targetCamera;

		// Token: 0x040035D1 RID: 13777
		[Token(Token = "0x40035D1")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RenderStage stage;

		// Token: 0x040035D2 RID: 13778
		[Token(Token = "0x40035D2")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private OutlineRenderingStrategy renderingStrategy;

		// Token: 0x040035D3 RID: 13779
		[Token(Token = "0x40035D3")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RenderingMode renderingMode;

		// Token: 0x040035D4 RID: 13780
		[Token(Token = "0x40035D4")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private long outlineLayerMask;

		// Token: 0x040035D5 RID: 13781
		[Token(Token = "0x40035D5")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private BufferSizeMode primaryBufferSizeMode;

		// Token: 0x040035D6 RID: 13782
		[Token(Token = "0x40035D6")]
		[FieldOffset(Offset = "0x44")]
		[Range(0.15f, 1f)]
		[SerializeField]
		private float primaryRendererScale;

		// Token: 0x040035D7 RID: 13783
		[Token(Token = "0x40035D7")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private int primarySizeReference;

		// Token: 0x040035D8 RID: 13784
		[Token(Token = "0x40035D8")]
		[FieldOffset(Offset = "0x4C")]
		[Range(0f, 2f)]
		[SerializeField]
		private float blurShift;

		// Token: 0x040035D9 RID: 13785
		[Token(Token = "0x40035D9")]
		[FieldOffset(Offset = "0x50")]
		[Range(0f, 2f)]
		[SerializeField]
		private float dilateShift;

		// Token: 0x040035DA RID: 13786
		[Token(Token = "0x40035DA")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		[FormerlySerializedAs("dilateIterrations")]
		private int dilateIterations;

		// Token: 0x040035DB RID: 13787
		[Token(Token = "0x40035DB")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private DilateQuality dilateQuality;

		// Token: 0x040035DC RID: 13788
		[Token(Token = "0x40035DC")]
		[FieldOffset(Offset = "0x5C")]
		[FormerlySerializedAs("blurIterrations")]
		[SerializeField]
		private int blurIterations;

		// Token: 0x040035DD RID: 13789
		[Token(Token = "0x40035DD")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private BlurType blurType;
	}
}
