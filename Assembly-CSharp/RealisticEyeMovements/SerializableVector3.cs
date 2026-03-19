using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RealisticEyeMovements
{
	// Token: 0x02000C7F RID: 3199
	[Token(Token = "0x2000C7F")]
	[Serializable]
	public struct SerializableVector3
	{
		// Token: 0x060079AD RID: 31149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079AD")]
		[Address(RVA = "0x148EBB4", Offset = "0x148EBB4", VA = "0x148EBB4")]
		public SerializableVector3(float rX, float rY, float rZ)
		{
		}

		// Token: 0x060079AE RID: 31150 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60079AE")]
		[Address(RVA = "0x148EBC0", Offset = "0x148EBC0", VA = "0x148EBC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060079AF RID: 31151 RVA: 0x00053688 File Offset: 0x00051888
		[Token(Token = "0x60079AF")]
		[Address(RVA = "0x1487EB4", Offset = "0x1487EB4", VA = "0x1487EB4")]
		public static implicit operator Vector3(SerializableVector3 rValue)
		{
			return default(Vector3);
		}

		// Token: 0x060079B0 RID: 31152 RVA: 0x000536A0 File Offset: 0x000518A0
		[Token(Token = "0x60079B0")]
		[Address(RVA = "0x1487A40", Offset = "0x1487A40", VA = "0x1487A40")]
		public static implicit operator SerializableVector3(Vector3 rValue)
		{
			return default(SerializableVector3);
		}

		// Token: 0x040034C7 RID: 13511
		[Token(Token = "0x40034C7")]
		[FieldOffset(Offset = "0x0")]
		public float x;

		// Token: 0x040034C8 RID: 13512
		[Token(Token = "0x40034C8")]
		[FieldOffset(Offset = "0x4")]
		public float y;

		// Token: 0x040034C9 RID: 13513
		[Token(Token = "0x40034C9")]
		[FieldOffset(Offset = "0x8")]
		public float z;
	}
}
