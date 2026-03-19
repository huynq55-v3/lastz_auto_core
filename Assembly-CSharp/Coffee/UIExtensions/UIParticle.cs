using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace Coffee.UIExtensions
{
	// Token: 0x02000A46 RID: 2630
	[Token(Token = "0x2000A46")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(CanvasRenderer))]
	[RequireComponent(typeof(RectTransform))]
	public class UIParticle : MaskableGraphic
	{
		// Token: 0x17000679 RID: 1657
		// (get) Token: 0x06006374 RID: 25460 RVA: 0x0004BDE0 File Offset: 0x00049FE0
		// (set) Token: 0x06006375 RID: 25461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000679")]
		public override bool raycastTarget
		{
			[Token(Token = "0x6006374")]
			[Address(RVA = "0x3043A70", Offset = "0x3043A70", VA = "0x3043A70", Slot = "24")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6006375")]
			[Address(RVA = "0x3043A78", Offset = "0x3043A78", VA = "0x3043A78", Slot = "25")]
			set
			{
			}
		}

		// Token: 0x1700067A RID: 1658
		// (get) Token: 0x06006376 RID: 25462 RVA: 0x0004BDF8 File Offset: 0x00049FF8
		// (set) Token: 0x06006377 RID: 25463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700067A")]
		public bool ignoreCanvasScaler
		{
			[Token(Token = "0x6006376")]
			[Address(RVA = "0x3043A7C", Offset = "0x3043A7C", VA = "0x3043A7C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6006377")]
			[Address(RVA = "0x3043A84", Offset = "0x3043A84", VA = "0x3043A84")]
			set
			{
			}
		}

		// Token: 0x1700067B RID: 1659
		// (get) Token: 0x06006378 RID: 25464 RVA: 0x0004BE10 File Offset: 0x0004A010
		// (set) Token: 0x06006379 RID: 25465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700067B")]
		public bool shrinkByMaterial
		{
			[Token(Token = "0x6006378")]
			[Address(RVA = "0x3043AF8", Offset = "0x3043AF8", VA = "0x3043AF8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6006379")]
			[Address(RVA = "0x3043B00", Offset = "0x3043B00", VA = "0x3043B00")]
			set
			{
			}
		}

		// Token: 0x1700067C RID: 1660
		// (get) Token: 0x0600637A RID: 25466 RVA: 0x0004BE28 File Offset: 0x0004A028
		// (set) Token: 0x0600637B RID: 25467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700067C")]
		public float scale
		{
			[Token(Token = "0x600637A")]
			[Address(RVA = "0x3043B5C", Offset = "0x3043B5C", VA = "0x3043B5C")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600637B")]
			[Address(RVA = "0x3043B64", Offset = "0x3043B64", VA = "0x3043B64")]
			set
			{
			}
		}

		// Token: 0x1700067D RID: 1661
		// (get) Token: 0x0600637C RID: 25468 RVA: 0x0004BE40 File Offset: 0x0004A040
		// (set) Token: 0x0600637D RID: 25469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700067D")]
		public Vector3 scale3D
		{
			[Token(Token = "0x600637C")]
			[Address(RVA = "0x3043B7C", Offset = "0x3043B7C", VA = "0x3043B7C")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600637D")]
			[Address(RVA = "0x3043B88", Offset = "0x3043B88", VA = "0x3043B88")]
			set
			{
			}
		}

		// Token: 0x1700067E RID: 1662
		// (get) Token: 0x0600637E RID: 25470 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700067E")]
		internal Mesh bakedMesh
		{
			[Token(Token = "0x600637E")]
			[Address(RVA = "0x3043BE0", Offset = "0x3043BE0", VA = "0x3043BE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700067F RID: 1663
		// (get) Token: 0x0600637F RID: 25471 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700067F")]
		public List<ParticleSystem> particles
		{
			[Token(Token = "0x600637F")]
			[Address(RVA = "0x3043BE8", Offset = "0x3043BE8", VA = "0x3043BE8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000680 RID: 1664
		// (get) Token: 0x06006380 RID: 25472 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000680")]
		public IEnumerable<Material> materials
		{
			[Token(Token = "0x6006380")]
			[Address(RVA = "0x3043BF0", Offset = "0x3043BF0", VA = "0x3043BF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000681 RID: 1665
		// (get) Token: 0x06006381 RID: 25473 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000681")]
		public override Material materialForRendering
		{
			[Token(Token = "0x6006381")]
			[Address(RVA = "0x3043BF8", Offset = "0x3043BF8", VA = "0x3043BF8", Slot = "34")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000682 RID: 1666
		// (get) Token: 0x06006382 RID: 25474 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006383 RID: 25475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000682")]
		public List<bool> activeMeshIndices
		{
			[Token(Token = "0x6006382")]
			[Address(RVA = "0x3043C1C", Offset = "0x3043C1C", VA = "0x3043C1C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6006383")]
			[Address(RVA = "0x3043C24", Offset = "0x3043C24", VA = "0x3043C24")]
			set
			{
			}
		}

		// Token: 0x17000683 RID: 1667
		// (get) Token: 0x06006384 RID: 25476 RVA: 0x0004BE58 File Offset: 0x0004A058
		// (set) Token: 0x06006385 RID: 25477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000683")]
		internal Vector3 cachedPosition
		{
			[Token(Token = "0x6006384")]
			[Address(RVA = "0x3043CC4", Offset = "0x3043CC4", VA = "0x3043CC4")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6006385")]
			[Address(RVA = "0x3043CD4", Offset = "0x3043CD4", VA = "0x3043CD4")]
			set
			{
			}
		}

		// Token: 0x06006386 RID: 25478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006386")]
		[Address(RVA = "0x3043CE4", Offset = "0x3043CE4", VA = "0x3043CE4")]
		public void Play()
		{
		}

		// Token: 0x06006387 RID: 25479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006387")]
		[Address(RVA = "0x3043DD0", Offset = "0x3043DD0", VA = "0x3043DD0")]
		public void Pause()
		{
		}

		// Token: 0x06006388 RID: 25480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006388")]
		[Address(RVA = "0x3043EBC", Offset = "0x3043EBC", VA = "0x3043EBC")]
		public void Stop()
		{
		}

		// Token: 0x06006389 RID: 25481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006389")]
		[Address(RVA = "0x3043FA8", Offset = "0x3043FA8", VA = "0x3043FA8")]
		public void Clear()
		{
		}

		// Token: 0x0600638A RID: 25482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600638A")]
		[Address(RVA = "0x3044094", Offset = "0x3044094", VA = "0x3044094")]
		public void SetParticleSystemInstance(GameObject instance)
		{
		}

		// Token: 0x0600638B RID: 25483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600638B")]
		[Address(RVA = "0x304409C", Offset = "0x304409C", VA = "0x304409C")]
		public void SetParticleSystemInstance(GameObject instance, bool destroyOldParticles)
		{
		}

		// Token: 0x0600638C RID: 25484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600638C")]
		[Address(RVA = "0x30447B8", Offset = "0x30447B8", VA = "0x30447B8")]
		public void SetParticleSystemPrefab(GameObject prefab)
		{
		}

		// Token: 0x0600638D RID: 25485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600638D")]
		[Address(RVA = "0x3043B3C", Offset = "0x3043B3C", VA = "0x3043B3C")]
		public void RefreshParticles()
		{
		}

		// Token: 0x0600638E RID: 25486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600638E")]
		[Address(RVA = "0x30444B0", Offset = "0x30444B0", VA = "0x30444B0")]
		public void RefreshParticles(GameObject root)
		{
		}

		// Token: 0x0600638F RID: 25487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600638F")]
		[Address(RVA = "0x304488C", Offset = "0x304488C", VA = "0x304488C", Slot = "40")]
		protected override void UpdateMaterial()
		{
		}

		// Token: 0x06006390 RID: 25488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006390")]
		[Address(RVA = "0x3044FE4", Offset = "0x3044FE4", VA = "0x3044FE4")]
		private void ClearPreviousMaterials()
		{
		}

		// Token: 0x06006391 RID: 25489 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006391")]
		[Address(RVA = "0x30452EC", Offset = "0x30452EC", VA = "0x30452EC")]
		private Material GetModifiedMaterial(Material baseMaterial, Texture2D texture)
		{
			return null;
		}

		// Token: 0x06006392 RID: 25490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006392")]
		[Address(RVA = "0x304574C", Offset = "0x304574C", VA = "0x304574C")]
		internal void UpdateMaterialProperties()
		{
		}

		// Token: 0x06006393 RID: 25491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006393")]
		[Address(RVA = "0x3045524", Offset = "0x3045524", VA = "0x3045524")]
		internal void UpdateMaterialProperties(Renderer r, int index)
		{
		}

		// Token: 0x06006394 RID: 25492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006394")]
		[Address(RVA = "0x3045960", Offset = "0x3045960", VA = "0x3045960", Slot = "5")]
		protected override void OnEnable()
		{
		}

		// Token: 0x06006395 RID: 25493 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006395")]
		[Address(RVA = "0x3045BCC", Offset = "0x3045BCC", VA = "0x3045BCC")]
		private IEnumerator Start()
		{
			return null;
		}

		// Token: 0x06006396 RID: 25494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006396")]
		[Address(RVA = "0x3045C40", Offset = "0x3045C40", VA = "0x3045C40", Slot = "7")]
		protected override void OnDisable()
		{
		}

		// Token: 0x06006397 RID: 25495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006397")]
		[Address(RVA = "0x3045DC0", Offset = "0x3045DC0", VA = "0x3045DC0", Slot = "41")]
		protected override void UpdateGeometry()
		{
		}

		// Token: 0x06006398 RID: 25496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006398")]
		[Address(RVA = "0x3045DC4", Offset = "0x3045DC4", VA = "0x3045DC4", Slot = "13")]
		protected override void OnDidApplyAnimationProperties()
		{
		}

		// Token: 0x06006399 RID: 25497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006399")]
		[Address(RVA = "0x3045B28", Offset = "0x3045B28", VA = "0x3045B28")]
		private void InitializeIfNeeded()
		{
		}

		// Token: 0x0600639A RID: 25498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600639A")]
		[Address(RVA = "0x3045DC8", Offset = "0x3045DC8", VA = "0x3045DC8")]
		public UIParticle()
		{
		}

		// Token: 0x04002812 RID: 10258
		[Token(Token = "0x4002812")]
		[FieldOffset(Offset = "0xD0")]
		[Tooltip("Ignore canvas scaler")]
		[SerializeField]
		[FormerlySerializedAs("m_IgnoreParent")]
		private bool m_IgnoreCanvasScaler;

		// Token: 0x04002813 RID: 10259
		[Token(Token = "0x4002813")]
		[FieldOffset(Offset = "0xD4")]
		[SerializeField]
		[Tooltip("Particle effect scale")]
		private float m_Scale;

		// Token: 0x04002814 RID: 10260
		[Token(Token = "0x4002814")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		[Tooltip("Particle effect scale")]
		private Vector3 m_Scale3D;

		// Token: 0x04002815 RID: 10261
		[Token(Token = "0x4002815")]
		[FieldOffset(Offset = "0xE8")]
		[Tooltip("Animatable material properties. If you want to change the material properties of the ParticleSystem in Animation, enable it.")]
		[SerializeField]
		internal AnimatableProperty[] m_AnimatableProperties;

		// Token: 0x04002816 RID: 10262
		[Token(Token = "0x4002816")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		[Tooltip("Particles")]
		private List<ParticleSystem> m_Particles;

		// Token: 0x04002817 RID: 10263
		[Token(Token = "0x4002817")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		[Tooltip("Shrink rendering by material on refresh.\nNOTE: Performance will be improved, but in some cases the rendering is not correct.")]
		private bool m_ShrinkByMaterial;

		// Token: 0x04002818 RID: 10264
		[Token(Token = "0x4002818")]
		[FieldOffset(Offset = "0xF9")]
		private bool _shouldBeRemoved;

		// Token: 0x04002819 RID: 10265
		[Token(Token = "0x4002819")]
		[FieldOffset(Offset = "0xFA")]
		private DrivenRectTransformTracker _tracker;

		// Token: 0x0400281A RID: 10266
		[Token(Token = "0x400281A")]
		[FieldOffset(Offset = "0x100")]
		private Mesh _bakedMesh;

		// Token: 0x0400281B RID: 10267
		[Token(Token = "0x400281B")]
		[FieldOffset(Offset = "0x108")]
		private readonly List<Material> _modifiedMaterials;

		// Token: 0x0400281C RID: 10268
		[Token(Token = "0x400281C")]
		[FieldOffset(Offset = "0x110")]
		private readonly List<Material> _maskMaterials;

		// Token: 0x0400281D RID: 10269
		[Token(Token = "0x400281D")]
		[FieldOffset(Offset = "0x118")]
		private readonly List<bool> _activeMeshIndices;

		// Token: 0x0400281E RID: 10270
		[Token(Token = "0x400281E")]
		[FieldOffset(Offset = "0x120")]
		private Vector3 _cachedPosition;

		// Token: 0x0400281F RID: 10271
		[Token(Token = "0x400281F")]
		[FieldOffset(Offset = "0x0")]
		private static readonly List<Material> s_TempMaterials;

		// Token: 0x04002820 RID: 10272
		[Token(Token = "0x4002820")]
		[FieldOffset(Offset = "0x8")]
		private static MaterialPropertyBlock s_Mpb;

		// Token: 0x04002821 RID: 10273
		[Token(Token = "0x4002821")]
		[FieldOffset(Offset = "0x10")]
		private static readonly List<Material> s_PrevMaskMaterials;

		// Token: 0x04002822 RID: 10274
		[Token(Token = "0x4002822")]
		[FieldOffset(Offset = "0x18")]
		private static readonly List<Material> s_PrevModifiedMaterials;

		// Token: 0x04002823 RID: 10275
		[Token(Token = "0x4002823")]
		[FieldOffset(Offset = "0x20")]
		private static readonly List<Component> s_Components;

		// Token: 0x04002824 RID: 10276
		[Token(Token = "0x4002824")]
		[FieldOffset(Offset = "0x28")]
		private static readonly List<ParticleSystem> s_ParticleSystems;
	}
}
