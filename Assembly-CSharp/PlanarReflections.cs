using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Serialization;

// Token: 0x02000046 RID: 70
[Token(Token = "0x2000046")]
[ExecuteAlways]
public class PlanarReflections : MonoBehaviour
{
	// Token: 0x060000E4 RID: 228 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000E4")]
	[Address(RVA = "0x15EB430", Offset = "0x15EB430", VA = "0x15EB430")]
	private void Awake()
	{
	}

	// Token: 0x060000E5 RID: 229 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000E5")]
	[Address(RVA = "0x15EB434", Offset = "0x15EB434", VA = "0x15EB434")]
	private void OnEnable()
	{
	}

	// Token: 0x060000E6 RID: 230 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000E6")]
	[Address(RVA = "0x15EB4D8", Offset = "0x15EB4D8", VA = "0x15EB4D8")]
	private void OnDisable()
	{
	}

	// Token: 0x060000E7 RID: 231 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000E7")]
	[Address(RVA = "0x15EB680", Offset = "0x15EB680", VA = "0x15EB680")]
	private void OnDestroy()
	{
	}

	// Token: 0x060000E8 RID: 232 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000E8")]
	[Address(RVA = "0x15EB4DC", Offset = "0x15EB4DC", VA = "0x15EB4DC")]
	private void Cleanup()
	{
	}

	// Token: 0x060000E9 RID: 233 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000E9")]
	[Address(RVA = "0x15EB684", Offset = "0x15EB684", VA = "0x15EB684")]
	private void SafeDestroy(Object obj)
	{
	}

	// Token: 0x060000EA RID: 234 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000EA")]
	[Address(RVA = "0x15EB6FC", Offset = "0x15EB6FC", VA = "0x15EB6FC")]
	private void UpdateCamera(Camera src, Camera dest)
	{
	}

	// Token: 0x060000EB RID: 235 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000EB")]
	[Address(RVA = "0x15EB7B0", Offset = "0x15EB7B0", VA = "0x15EB7B0")]
	private void UpdateReflectionCamera(Camera realCamera)
	{
	}

	// Token: 0x060000EC RID: 236 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000EC")]
	[Address(RVA = "0x15EC13C", Offset = "0x15EC13C", VA = "0x15EC13C")]
	private static void CalculateReflectionMatrix(ref Matrix4x4 reflectionMat, Vector4 plane)
	{
	}

	// Token: 0x060000ED RID: 237 RVA: 0x00002370 File Offset: 0x00000570
	[Token(Token = "0x60000ED")]
	[Address(RVA = "0x15EC1D0", Offset = "0x15EC1D0", VA = "0x15EC1D0")]
	private static Vector3 ReflectPosition(Vector3 pos)
	{
		return default(Vector3);
	}

	// Token: 0x060000EE RID: 238 RVA: 0x00002388 File Offset: 0x00000588
	[Token(Token = "0x60000EE")]
	[Address(RVA = "0x15EC390", Offset = "0x15EC390", VA = "0x15EC390")]
	private float GetScaleValue()
	{
		return 0f;
	}

	// Token: 0x060000EF RID: 239 RVA: 0x000023A0 File Offset: 0x000005A0
	[Token(Token = "0x60000EF")]
	[Address(RVA = "0x15EC3C8", Offset = "0x15EC3C8", VA = "0x15EC3C8")]
	private static bool Int2Compare(Vector2Int a, Vector2Int b)
	{
		return default(bool);
	}

	// Token: 0x060000F0 RID: 240 RVA: 0x000023B8 File Offset: 0x000005B8
	[Token(Token = "0x60000F0")]
	[Address(RVA = "0x15EC1D8", Offset = "0x15EC1D8", VA = "0x15EC1D8")]
	private Vector4 CameraSpacePlane(Camera cam, Vector3 pos, Vector3 normal, float sideSign)
	{
		return default(Vector4);
	}

	// Token: 0x060000F1 RID: 241 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000F1")]
	[Address(RVA = "0x15EBD4C", Offset = "0x15EBD4C", VA = "0x15EBD4C")]
	private Camera CreateMirrorObjects(Camera currentCamera)
	{
		return null;
	}

	// Token: 0x060000F2 RID: 242 RVA: 0x000023D0 File Offset: 0x000005D0
	[Token(Token = "0x60000F2")]
	[Address(RVA = "0x15EC3F0", Offset = "0x15EC3F0", VA = "0x15EC3F0")]
	private Vector2Int ReflectionResolution(Camera cam, float scale)
	{
		return default(Vector2Int);
	}

	// Token: 0x060000F3 RID: 243 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000F3")]
	[Address(RVA = "0x15EC4D4", Offset = "0x15EC4D4", VA = "0x15EC4D4")]
	public void ExecuteBeforeCameraRender(ScriptableRenderContext context, Camera camera)
	{
	}

	// Token: 0x060000F4 RID: 244 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000F4")]
	[Address(RVA = "0x15ECEB8", Offset = "0x15ECEB8", VA = "0x15ECEB8")]
	public PlanarReflections()
	{
	}

	// Token: 0x04000166 RID: 358
	[Token(Token = "0x4000166")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public PlanarReflections.PlanarReflectionSettings m_settings;

	// Token: 0x04000167 RID: 359
	[Token(Token = "0x4000167")]
	[FieldOffset(Offset = "0x20")]
	public GameObject target;

	// Token: 0x04000168 RID: 360
	[Token(Token = "0x4000168")]
	[FieldOffset(Offset = "0x28")]
	[FormerlySerializedAs("camOffset")]
	public float m_planeOffset;

	// Token: 0x04000169 RID: 361
	[Token(Token = "0x4000169")]
	[FieldOffset(Offset = "0x0")]
	private static Camera m_ReflectionCamera;

	// Token: 0x0400016A RID: 362
	[Token(Token = "0x400016A")]
	[FieldOffset(Offset = "0x2C")]
	private Vector2Int m_TextureSize;

	// Token: 0x0400016B RID: 363
	[Token(Token = "0x400016B")]
	[FieldOffset(Offset = "0x38")]
	private RenderTexture m_ReflectionTexture;

	// Token: 0x0400016C RID: 364
	[Token(Token = "0x400016C")]
	[FieldOffset(Offset = "0x40")]
	private RenderTexture m_BlurReflectionTexture;

	// Token: 0x0400016D RID: 365
	[Token(Token = "0x400016D")]
	[FieldOffset(Offset = "0x48")]
	private int planarReflectionTextureID;

	// Token: 0x0400016E RID: 366
	[Token(Token = "0x400016E")]
	[FieldOffset(Offset = "0x4C")]
	private PlanarReflections.ResolutionMulltiplier m_OldRes;

	// Token: 0x0400016F RID: 367
	[Token(Token = "0x400016F")]
	private const string k_BlurShader = "Hidden/KawaseBlur";

	// Token: 0x04000170 RID: 368
	[Token(Token = "0x4000170")]
	[FieldOffset(Offset = "0x50")]
	private Material _blurMaterial;

	// Token: 0x02000047 RID: 71
	[Token(Token = "0x2000047")]
	[Serializable]
	public enum ResolutionMulltiplier
	{
		// Token: 0x04000172 RID: 370
		[Token(Token = "0x4000172")]
		Full,
		// Token: 0x04000173 RID: 371
		[Token(Token = "0x4000173")]
		Half,
		// Token: 0x04000174 RID: 372
		[Token(Token = "0x4000174")]
		Third,
		// Token: 0x04000175 RID: 373
		[Token(Token = "0x4000175")]
		Quarter
	}

	// Token: 0x02000048 RID: 72
	[Token(Token = "0x2000048")]
	[Serializable]
	public class PlanarReflectionSettings
	{
		// Token: 0x060000F5 RID: 245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x15ECF94", Offset = "0x15ECF94", VA = "0x15ECF94")]
		public PlanarReflectionSettings()
		{
		}

		// Token: 0x04000176 RID: 374
		[Token(Token = "0x4000176")]
		[FieldOffset(Offset = "0x10")]
		public PlanarReflections.ResolutionMulltiplier m_ResolutionMultiplier;

		// Token: 0x04000177 RID: 375
		[Token(Token = "0x4000177")]
		[FieldOffset(Offset = "0x14")]
		public float m_ClipPlaneOffset;

		// Token: 0x04000178 RID: 376
		[Token(Token = "0x4000178")]
		[FieldOffset(Offset = "0x18")]
		public LayerMask m_ReflectLayers;

		// Token: 0x04000179 RID: 377
		[Token(Token = "0x4000179")]
		[FieldOffset(Offset = "0x1C")]
		public bool m_shadows;

		// Token: 0x0400017A RID: 378
		[Token(Token = "0x400017A")]
		[FieldOffset(Offset = "0x1D")]
		public bool _blurOn;

		// Token: 0x0400017B RID: 379
		[Token(Token = "0x400017B")]
		[FieldOffset(Offset = "0x20")]
		[Range(0f, 5f)]
		public float _blurSize;

		// Token: 0x0400017C RID: 380
		[Token(Token = "0x400017C")]
		[FieldOffset(Offset = "0x24")]
		[Range(0f, 10f)]
		public int _blurIterations;

		// Token: 0x0400017D RID: 381
		[Token(Token = "0x400017D")]
		[FieldOffset(Offset = "0x28")]
		[Range(1f, 4f)]
		public float _downsample;
	}
}
