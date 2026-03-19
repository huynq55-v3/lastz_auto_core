using System;
using Il2CppDummyDll;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x02000CC4 RID: 3268
	[Token(Token = "0x2000CC4")]
	public class PlanarURP : MonoBehaviour
	{
		// Token: 0x06007B69 RID: 31593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B69")]
		[Address(RVA = "0x3227B28", Offset = "0x3227B28", VA = "0x3227B28")]
		private void OnEnable()
		{
		}

		// Token: 0x06007B6A RID: 31594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B6A")]
		[Address(RVA = "0x3227C08", Offset = "0x3227C08", VA = "0x3227C08")]
		private void OnDisable()
		{
		}

		// Token: 0x06007B6B RID: 31595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B6B")]
		[Address(RVA = "0x3227E1C", Offset = "0x3227E1C", VA = "0x3227E1C")]
		public void Start()
		{
		}

		// Token: 0x06007B6C RID: 31596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B6C")]
		[Address(RVA = "0x32282F8", Offset = "0x32282F8", VA = "0x32282F8")]
		private void RenderObject(ScriptableRenderContext context, Camera cam)
		{
		}

		// Token: 0x06007B6D RID: 31597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B6D")]
		[Address(RVA = "0x3227DA4", Offset = "0x3227DA4", VA = "0x3227DA4")]
		private void RemoveObject(Object obj)
		{
		}

		// Token: 0x06007B6E RID: 31598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B6E")]
		[Address(RVA = "0x3228F54", Offset = "0x3228F54", VA = "0x3228F54")]
		private void RenderObjectCamera(Matrix4x4 projection, bool right)
		{
		}

		// Token: 0x06007B6F RID: 31599 RVA: 0x000542D0 File Offset: 0x000524D0
		[Token(Token = "0x6007B6F")]
		[Address(RVA = "0x32291A0", Offset = "0x32291A0", VA = "0x32291A0")]
		private static float sgn(float a)
		{
			return 0f;
		}

		// Token: 0x06007B70 RID: 31600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B70")]
		[Address(RVA = "0x32291C0", Offset = "0x32291C0", VA = "0x32291C0")]
		public PlanarURP()
		{
		}

		// Token: 0x04003695 RID: 13973
		[Token(Token = "0x4003695")]
		[FieldOffset(Offset = "0x18")]
		public bool VR;

		// Token: 0x04003696 RID: 13974
		[Token(Token = "0x4003696")]
		[FieldOffset(Offset = "0x1C")]
		public int ReflectionTexResolution;

		// Token: 0x04003697 RID: 13975
		[Token(Token = "0x4003697")]
		[FieldOffset(Offset = "0x20")]
		public float Offset;

		// Token: 0x04003698 RID: 13976
		[Token(Token = "0x4003698")]
		[FieldOffset(Offset = "0x24")]
		[Range(0f, 1f)]
		public float ReflectionAlpha;

		// Token: 0x04003699 RID: 13977
		[Token(Token = "0x4003699")]
		[FieldOffset(Offset = "0x28")]
		public bool BlurredReflection;

		// Token: 0x0400369A RID: 13978
		[Token(Token = "0x400369A")]
		[FieldOffset(Offset = "0x2C")]
		public LayerMask LayersToReflect;

		// Token: 0x0400369B RID: 13979
		[Token(Token = "0x400369B")]
		[FieldOffset(Offset = "0x30")]
		private Camera reflectionCamera;

		// Token: 0x0400369C RID: 13980
		[Token(Token = "0x400369C")]
		[FieldOffset(Offset = "0x38")]
		private RenderTexture reflectionTexture;

		// Token: 0x0400369D RID: 13981
		[Token(Token = "0x400369D")]
		[FieldOffset(Offset = "0x40")]
		private RenderTexture reflectionTextureRight;

		// Token: 0x0400369E RID: 13982
		[Token(Token = "0x400369E")]
		[FieldOffset(Offset = "0x0")]
		private static bool isRendering;

		// Token: 0x0400369F RID: 13983
		[Token(Token = "0x400369F")]
		[FieldOffset(Offset = "0x48")]
		private Material material;

		// Token: 0x040036A0 RID: 13984
		[Token(Token = "0x40036A0")]
		[FieldOffset(Offset = "0x4")]
		private static readonly int reflectionTexString;

		// Token: 0x040036A1 RID: 13985
		[Token(Token = "0x40036A1")]
		[FieldOffset(Offset = "0x8")]
		private static readonly int reflectionTexRString;

		// Token: 0x040036A2 RID: 13986
		[Token(Token = "0x40036A2")]
		[FieldOffset(Offset = "0xC")]
		private static readonly int reflectionAlphaString;

		// Token: 0x040036A3 RID: 13987
		[Token(Token = "0x40036A3")]
		[FieldOffset(Offset = "0x10")]
		private static readonly string blurString;

		// Token: 0x040036A4 RID: 13988
		[Token(Token = "0x40036A4")]
		[FieldOffset(Offset = "0x18")]
		private static readonly string vrString;

		// Token: 0x040036A5 RID: 13989
		[Token(Token = "0x40036A5")]
		[FieldOffset(Offset = "0x50")]
		private Matrix4x4 reflectionMatrix;

		// Token: 0x040036A6 RID: 13990
		[Token(Token = "0x40036A6")]
		[FieldOffset(Offset = "0x90")]
		private Vector4 reflectionPlane;

		// Token: 0x040036A7 RID: 13991
		[Token(Token = "0x40036A7")]
		[FieldOffset(Offset = "0xA0")]
		private Vector3 posistion;

		// Token: 0x040036A8 RID: 13992
		[Token(Token = "0x40036A8")]
		[FieldOffset(Offset = "0xAC")]
		private Vector3 normal;

		// Token: 0x040036A9 RID: 13993
		[Token(Token = "0x40036A9")]
		[FieldOffset(Offset = "0xB8")]
		private Matrix4x4 projection;

		// Token: 0x040036AA RID: 13994
		[Token(Token = "0x40036AA")]
		[FieldOffset(Offset = "0xF8")]
		private Vector4 oblique;

		// Token: 0x040036AB RID: 13995
		[Token(Token = "0x40036AB")]
		[FieldOffset(Offset = "0x108")]
		private Matrix4x4 worldToCameraMatrix;

		// Token: 0x040036AC RID: 13996
		[Token(Token = "0x40036AC")]
		[FieldOffset(Offset = "0x148")]
		private Vector3 clipNormal;

		// Token: 0x040036AD RID: 13997
		[Token(Token = "0x40036AD")]
		[FieldOffset(Offset = "0x154")]
		private Vector4 clipPlane;

		// Token: 0x040036AE RID: 13998
		[Token(Token = "0x40036AE")]
		[FieldOffset(Offset = "0x164")]
		private Vector3 oldPosition;

		// Token: 0x040036AF RID: 13999
		[Token(Token = "0x40036AF")]
		[FieldOffset(Offset = "0x170")]
		private Vector3 eulerAngles;

		// Token: 0x040036B0 RID: 14000
		[Token(Token = "0x40036B0")]
		[FieldOffset(Offset = "0x17C")]
		[Range(0f, 5f)]
		public float _blurSize;

		// Token: 0x040036B1 RID: 14001
		[Token(Token = "0x40036B1")]
		[FieldOffset(Offset = "0x180")]
		public int _blurIterations;

		// Token: 0x040036B2 RID: 14002
		[Token(Token = "0x40036B2")]
		[FieldOffset(Offset = "0x184")]
		public float _downsample;

		// Token: 0x040036B3 RID: 14003
		[Token(Token = "0x40036B3")]
		[FieldOffset(Offset = "0x188")]
		private Shader _blurShader;

		// Token: 0x040036B4 RID: 14004
		[Token(Token = "0x40036B4")]
		[FieldOffset(Offset = "0x190")]
		private Material _blurMaterial;

		// Token: 0x040036B5 RID: 14005
		[Token(Token = "0x40036B5")]
		[FieldOffset(Offset = "0x198")]
		private GameObject player;
	}
}
