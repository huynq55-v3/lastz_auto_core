using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RealisticEyeMovements
{
	// Token: 0x02000C7E RID: 3198
	[Token(Token = "0x2000C7E")]
	[Serializable]
	public struct SerializableQuaternion
	{
		// Token: 0x060079A9 RID: 31145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079A9")]
		[Address(RVA = "0x148E9CC", Offset = "0x148E9CC", VA = "0x148E9CC")]
		public SerializableQuaternion(float rX, float rY, float rZ, float rW)
		{
		}

		// Token: 0x060079AA RID: 31146 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60079AA")]
		[Address(RVA = "0x148E9D8", Offset = "0x148E9D8", VA = "0x148E9D8", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060079AB RID: 31147 RVA: 0x00053658 File Offset: 0x00051858
		[Token(Token = "0x60079AB")]
		[Address(RVA = "0x1487EB0", Offset = "0x1487EB0", VA = "0x1487EB0")]
		public static implicit operator Quaternion(SerializableQuaternion rValue)
		{
			return default(Quaternion);
		}

		// Token: 0x060079AC RID: 31148 RVA: 0x00053670 File Offset: 0x00051870
		[Token(Token = "0x60079AC")]
		[Address(RVA = "0x1487A3C", Offset = "0x1487A3C", VA = "0x1487A3C")]
		public static implicit operator SerializableQuaternion(Quaternion rValue)
		{
			return default(SerializableQuaternion);
		}

		// Token: 0x040034C3 RID: 13507
		[Token(Token = "0x40034C3")]
		[FieldOffset(Offset = "0x0")]
		public float x;

		// Token: 0x040034C4 RID: 13508
		[Token(Token = "0x40034C4")]
		[FieldOffset(Offset = "0x4")]
		public float y;

		// Token: 0x040034C5 RID: 13509
		[Token(Token = "0x40034C5")]
		[FieldOffset(Offset = "0x8")]
		public float z;

		// Token: 0x040034C6 RID: 13510
		[Token(Token = "0x40034C6")]
		[FieldOffset(Offset = "0xC")]
		public float w;
	}
}
