using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace RealisticEyeMovements
{
	// Token: 0x02000C80 RID: 3200
	[Token(Token = "0x2000C80")]
	public static class Utils
	{
		// Token: 0x060079B1 RID: 31153 RVA: 0x000536B8 File Offset: 0x000518B8
		[Token(Token = "0x60079B1")]
		[Address(RVA = "0x148EC84", Offset = "0x148EC84", VA = "0x148EC84")]
		public static bool AreTransformsChildrenOf(List<Transform> children, Transform ancestor)
		{
			return default(bool);
		}

		// Token: 0x060079B2 RID: 31154 RVA: 0x000536D0 File Offset: 0x000518D0
		[Token(Token = "0x60079B2")]
		[Address(RVA = "0x14875EC", Offset = "0x14875EC", VA = "0x14875EC")]
		public static bool CanGetTransformFromPath(Transform startXform, string path, [Optional] string targetNameForErrorMessage)
		{
			return default(bool);
		}

		// Token: 0x060079B3 RID: 31155 RVA: 0x000536E8 File Offset: 0x000518E8
		[Token(Token = "0x60079B3")]
		[Address(RVA = "0x148EDEC", Offset = "0x148EDEC", VA = "0x148EDEC")]
		public static float EaseSineIn(float t, float b, float c, float d)
		{
			return 0f;
		}

		// Token: 0x060079B4 RID: 31156 RVA: 0x00053700 File Offset: 0x00051900
		[Token(Token = "0x60079B4")]
		[Address(RVA = "0x148E920", Offset = "0x148E920", VA = "0x148E920")]
		public static float Fbm(Vector2 coord, int octave)
		{
			return 0f;
		}

		// Token: 0x060079B5 RID: 31157 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60079B5")]
		[Address(RVA = "0x148EE28", Offset = "0x148EE28", VA = "0x148EE28")]
		public static GameObject FindChildInHierarchy(GameObject go, string name)
		{
			return null;
		}

		// Token: 0x060079B6 RID: 31158 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60079B6")]
		[Address(RVA = "0x148F1D0", Offset = "0x148F1D0", VA = "0x148F1D0")]
		public static Transform GetCommonAncestor(Transform xform1, Transform xform2)
		{
			return null;
		}

		// Token: 0x060079B7 RID: 31159 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60079B7")]
		[Address(RVA = "0x148633C", Offset = "0x148633C", VA = "0x148633C")]
		public static string GetPathForTransform(Transform startXform, Transform targetXform)
		{
			return null;
		}

		// Token: 0x060079B8 RID: 31160 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60079B8")]
		[Address(RVA = "0x148B364", Offset = "0x148B364", VA = "0x148B364")]
		public static Transform GetSpineBoneFromAnimator(Animator animator)
		{
			return null;
		}

		// Token: 0x060079B9 RID: 31161 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60079B9")]
		[Address(RVA = "0x14861C0", Offset = "0x14861C0", VA = "0x14861C0")]
		public static Transform GetTransformFromPath(Transform startXform, string path)
		{
			return null;
		}

		// Token: 0x060079BA RID: 31162 RVA: 0x00053718 File Offset: 0x00051918
		[Token(Token = "0x60079BA")]
		[Address(RVA = "0x148F428", Offset = "0x148F428", VA = "0x148F428")]
		public static bool IsEqualOrDescendant(Transform ancestor, Transform descendant)
		{
			return default(bool);
		}

		// Token: 0x060079BB RID: 31163 RVA: 0x00053730 File Offset: 0x00051930
		[Token(Token = "0x60079BB")]
		[Address(RVA = "0x148F7A4", Offset = "0x148F7A4", VA = "0x148F7A4")]
		public static bool IsVRDevicePresent()
		{
			return default(bool);
		}

		// Token: 0x060079BC RID: 31164 RVA: 0x00053748 File Offset: 0x00051948
		[Token(Token = "0x60079BC")]
		[Address(RVA = "0x1488E74", Offset = "0x1488E74", VA = "0x1488E74")]
		public static float NormalizedDegAngle(float degrees)
		{
			return 0f;
		}

		// Token: 0x060079BD RID: 31165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079BD")]
		[Address(RVA = "0x148F7AC", Offset = "0x148F7AC", VA = "0x148F7AC")]
		public static void PlaceDummyObject(string name, Vector3 pos, float scale = 0.1f, [Optional] Quaternion? rotation)
		{
		}

		// Token: 0x040034CA RID: 13514
		[Token(Token = "0x40034CA")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<string, GameObject> dummyObjects;
	}
}
