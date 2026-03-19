using System;
using Il2CppDummyDll;
using UnityEngine;

namespace usky
{
	// Token: 0x02000A08 RID: 2568
	[Token(Token = "0x2000A08")]
	[ExecuteInEditMode]
	[AddComponentMenu("uSkyPro/Other/Shadow Distance Helper")]
	public class ShadowDistanceHelper : MonoBehaviour
	{
		// Token: 0x0600620E RID: 25102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600620E")]
		[Address(RVA = "0x3030334", Offset = "0x3030334", VA = "0x3030334")]
		private void Awake()
		{
		}

		// Token: 0x0600620F RID: 25103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600620F")]
		[Address(RVA = "0x3030340", Offset = "0x3030340", VA = "0x3030340")]
		private void OnValidate()
		{
		}

		// Token: 0x06006210 RID: 25104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006210")]
		[Address(RVA = "0x3030358", Offset = "0x3030358", VA = "0x3030358")]
		public ShadowDistanceHelper()
		{
		}

		// Token: 0x04002650 RID: 9808
		[Token(Token = "0x4002650")]
		[FieldOffset(Offset = "0x18")]
		[Tooltip("This is a shortcut to control the \"Shadow Distance\" in QualitySettings for \"Scatter Occlusion\" effect.\n\nNote: If this value sets to very high, then closeup objects shadow may become very blurly.\n\nuSky does not require this script to run, this helper script can be removed at anytime.")]
		public float ShadowDistance;
	}
}
