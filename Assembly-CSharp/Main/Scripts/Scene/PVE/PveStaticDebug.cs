using System;
using System.Collections.Generic;
using BitBenderGames;
using Il2CppDummyDll;
using UnityEngine;

namespace Main.Scripts.Scene.PVE
{
	// Token: 0x02000505 RID: 1285
	[Token(Token = "0x2000505")]
	public class PveStaticDebug : MonoBehaviour
	{
		// Token: 0x060026D9 RID: 9945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026D9")]
		[Address(RVA = "0x2B65714", Offset = "0x2B65714", VA = "0x2B65714")]
		public void SetDesc(FIGridManager gridMgr)
		{
		}

		// Token: 0x060026DA RID: 9946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026DA")]
		[Address(RVA = "0x2B6571C", Offset = "0x2B6571C", VA = "0x2B6571C")]
		private void Test()
		{
		}

		// Token: 0x060026DB RID: 9947 RVA: 0x0000EA78 File Offset: 0x0000CC78
		[Token(Token = "0x60026DB")]
		[Address(RVA = "0x2B65750", Offset = "0x2B65750", VA = "0x2B65750")]
		private Ray ScreenPointToRay(Vector3 pos)
		{
			return default(Ray);
		}

		// Token: 0x060026DC RID: 9948 RVA: 0x0000EA90 File Offset: 0x0000CC90
		[Token(Token = "0x60026DC")]
		[Address(RVA = "0x2B65824", Offset = "0x2B65824", VA = "0x2B65824")]
		private Vector3 ScreenPointToWorld(Vector2 screenPos, float disPlane = 0f)
		{
			return default(Vector3);
		}

		// Token: 0x060026DD RID: 9949 RVA: 0x0000EAA8 File Offset: 0x0000CCA8
		[Token(Token = "0x60026DD")]
		[Address(RVA = "0x2B659BC", Offset = "0x2B659BC", VA = "0x2B659BC")]
		public Vector3 GetTouchPoint()
		{
			return default(Vector3);
		}

		// Token: 0x060026DE RID: 9950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026DE")]
		[Address(RVA = "0x2B659DC", Offset = "0x2B659DC", VA = "0x2B659DC")]
		public PveStaticDebug()
		{
		}

		// Token: 0x0400230F RID: 8975
		[Token(Token = "0x400230F")]
		[FieldOffset(Offset = "0x18")]
		private FIGridManager _gridMgr;

		// Token: 0x04002310 RID: 8976
		[Token(Token = "0x4002310")]
		[FieldOffset(Offset = "0x20")]
		private List<int> _testPath;

		// Token: 0x04002311 RID: 8977
		[Token(Token = "0x4002311")]
		[FieldOffset(Offset = "0x28")]
		private Vector3 _cubeSize;

		// Token: 0x04002312 RID: 8978
		[Token(Token = "0x4002312")]
		[FieldOffset(Offset = "0x38")]
		private MobileTouchCamera _touchCamera;
	}
}
