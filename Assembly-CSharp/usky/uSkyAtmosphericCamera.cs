using System;
using Il2CppDummyDll;
using UnityEngine;

namespace usky
{
	// Token: 0x02000A0A RID: 2570
	[Token(Token = "0x2000A0A")]
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("uSkyPro/uSky Atmospheric Camera")]
	[ImageEffectAllowedInSceneView]
	public class uSkyAtmosphericCamera : MonoBehaviour
	{
		// Token: 0x17000647 RID: 1607
		// (get) Token: 0x06006213 RID: 25107 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000647")]
		private uSkyAtmosphericScattering AtmoScatter
		{
			[Token(Token = "0x6006213")]
			[Address(RVA = "0x303061C", Offset = "0x303061C", VA = "0x303061C")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006214 RID: 25108 RVA: 0x0004B840 File Offset: 0x00049A40
		[Token(Token = "0x6006214")]
		[Address(RVA = "0x303065C", Offset = "0x303065C", VA = "0x303065C")]
		protected bool CheckSupport()
		{
			return default(bool);
		}

		// Token: 0x06006215 RID: 25109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006215")]
		[Address(RVA = "0x3030688", Offset = "0x3030688", VA = "0x3030688")]
		private void CheckMaterial()
		{
		}

		// Token: 0x06006216 RID: 25110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006216")]
		[Address(RVA = "0x3030828", Offset = "0x3030828", VA = "0x3030828")]
		private void OnEnable()
		{
		}

		// Token: 0x06006217 RID: 25111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006217")]
		[Address(RVA = "0x3030888", Offset = "0x3030888", VA = "0x3030888")]
		private void Start()
		{
		}

		// Token: 0x06006218 RID: 25112 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006218")]
		[Address(RVA = "0x3030970", Offset = "0x3030970", VA = "0x3030970")]
		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x06006219 RID: 25113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006219")]
		[Address(RVA = "0x3030B28", Offset = "0x3030B28", VA = "0x3030B28")]
		private static void FrustumCornersGraphicsBlit(RenderTexture source, RenderTexture dest, Material fxMaterial, int passNr)
		{
		}

		// Token: 0x0600621A RID: 25114 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600621A")]
		[Address(RVA = "0x3030C88", Offset = "0x3030C88", VA = "0x3030C88")]
		public uSkyAtmosphericCamera()
		{
		}

		// Token: 0x04002652 RID: 9810
		[Token(Token = "0x4002652")]
		[FieldOffset(Offset = "0x18")]
		[HideInInspector]
		public Shader m_AtmosphericCameraShader;

		// Token: 0x04002653 RID: 9811
		[Token(Token = "0x4002653")]
		[FieldOffset(Offset = "0x20")]
		private Material m_AtmosphericCameraMaterial;

		// Token: 0x04002654 RID: 9812
		[Token(Token = "0x4002654")]
		[FieldOffset(Offset = "0x28")]
		private Camera cam;

		// Token: 0x04002655 RID: 9813
		[Token(Token = "0x4002655")]
		[FieldOffset(Offset = "0x30")]
		private bool shouldRender;
	}
}
