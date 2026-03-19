using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

namespace usky
{
	// Token: 0x02000A19 RID: 2585
	[Token(Token = "0x2000A19")]
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	[AddComponentMenu("uSkyPro/uSky ReflectionProbe Updater")]
	public class uSkyReflectionProbeUpdater : MonoBehaviour
	{
		// Token: 0x0600628F RID: 25231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600628F")]
		[Address(RVA = "0x3036BFC", Offset = "0x3036BFC", VA = "0x3036BFC")]
		private void OnEnable()
		{
		}

		// Token: 0x06006290 RID: 25232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006290")]
		[Address(RVA = "0x3036CEC", Offset = "0x3036CEC", VA = "0x3036CEC")]
		private void OnDisable()
		{
		}

		// Token: 0x06006291 RID: 25233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006291")]
		[Address(RVA = "0x3036DA4", Offset = "0x3036DA4", VA = "0x3036DA4")]
		private void Start()
		{
		}

		// Token: 0x06006292 RID: 25234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006292")]
		[Address(RVA = "0x3036E74", Offset = "0x3036E74", VA = "0x3036E74")]
		private void RenderReflectionProbe()
		{
		}

		// Token: 0x06006293 RID: 25235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006293")]
		[Address(RVA = "0x3036E90", Offset = "0x3036E90", VA = "0x3036E90")]
		public uSkyReflectionProbeUpdater()
		{
		}

		// Token: 0x04002711 RID: 10001
		[Token(Token = "0x4002711")]
		[FieldOffset(Offset = "0x18")]
		[Tooltip("The Time Slicing setting can be different between in Editor and Play Mode (or at RunTime),\n\nRecommended using \"No Time Slicing\" in Editor for correctly generate reflection cubemap.\n\nOnly requires to set \"No Time Slicing\" at Runtime if the probe needed to update per frame. \n(uSkyTimeline / Day Night Cycle : Stepped Interval = 0)")]
		public ReflectionProbeTimeSlicingMode RuntimeTimeSlicing;

		// Token: 0x04002712 RID: 10002
		[Token(Token = "0x4002712")]
		[FieldOffset(Offset = "0x20")]
		private ReflectionProbe TheProbe;
	}
}
