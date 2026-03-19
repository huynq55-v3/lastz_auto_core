using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Coffee.UIParticleExtensions
{
	// Token: 0x02000A37 RID: 2615
	[Token(Token = "0x2000A37")]
	internal class BakingCamera : MonoBehaviour
	{
		// Token: 0x17000675 RID: 1653
		// (get) Token: 0x06006339 RID: 25401 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000675")]
		private static BakingCamera Instance
		{
			[Token(Token = "0x6006339")]
			[Address(RVA = "0x303FF30", Offset = "0x303FF30", VA = "0x303FF30")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600633A RID: 25402 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600633A")]
		[Address(RVA = "0x304005C", Offset = "0x304005C", VA = "0x304005C")]
		private static BakingCamera Create()
		{
			return null;
		}

		// Token: 0x0600633B RID: 25403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600633B")]
		[Address(RVA = "0x30401B8", Offset = "0x30401B8", VA = "0x30401B8")]
		private void Awake()
		{
		}

		// Token: 0x0600633C RID: 25404 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600633C")]
		[Address(RVA = "0x3040288", Offset = "0x3040288", VA = "0x3040288")]
		public static Camera GetCamera(Canvas canvas)
		{
			return null;
		}

		// Token: 0x0600633D RID: 25405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600633D")]
		[Address(RVA = "0x3040510", Offset = "0x3040510", VA = "0x3040510")]
		public BakingCamera()
		{
		}

		// Token: 0x040027EE RID: 10222
		[Token(Token = "0x40027EE")]
		[FieldOffset(Offset = "0x0")]
		private static BakingCamera s_Instance;

		// Token: 0x040027EF RID: 10223
		[Token(Token = "0x40027EF")]
		[FieldOffset(Offset = "0x8")]
		private static readonly Vector3 s_OrthoPosition;

		// Token: 0x040027F0 RID: 10224
		[Token(Token = "0x40027F0")]
		[FieldOffset(Offset = "0x14")]
		private static readonly Quaternion s_OrthoRotation;

		// Token: 0x040027F1 RID: 10225
		[Token(Token = "0x40027F1")]
		[FieldOffset(Offset = "0x18")]
		private Camera _camera;
	}
}
