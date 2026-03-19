using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace RealisticEyeMovements
{
	// Token: 0x02000C76 RID: 3190
	[Token(Token = "0x2000C76")]
	[Serializable]
	public class EyelidRotationLimiter
	{
		// Token: 0x06007969 RID: 31081 RVA: 0x000534A8 File Offset: 0x000516A8
		[Token(Token = "0x6007969")]
		[Address(RVA = "0x1487574", Offset = "0x1487574", VA = "0x1487574")]
		public static bool CanImport(EyelidRotationLimiter.EyelidRotationLimiterForExport import, Transform startXform, [Optional] string targetNameForErrorMessage)
		{
			return default(bool);
		}

		// Token: 0x0600796A RID: 31082 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600796A")]
		[Address(RVA = "0x14878EC", Offset = "0x14878EC", VA = "0x14878EC")]
		public EyelidRotationLimiter.EyelidRotationLimiterForExport GetExport(Transform startXform)
		{
			return null;
		}

		// Token: 0x0600796B RID: 31083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600796B")]
		[Address(RVA = "0x1487A44", Offset = "0x1487A44", VA = "0x1487A44")]
		public void GetRotationAndPosition(float eyeAngle, float blink01, float eyeWidenOrSquint, bool isUpper, out Quaternion rotation, ref Vector3 position, ControlData.EyelidBoneMode eyelidBoneMode)
		{
		}

		// Token: 0x0600796C RID: 31084 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600796C")]
		[Address(RVA = "0x1487D5C", Offset = "0x1487D5C", VA = "0x1487D5C")]
		public static EyelidRotationLimiter Import(EyelidRotationLimiter.EyelidRotationLimiterForExport import, Transform startXform)
		{
			return null;
		}

		// Token: 0x0600796D RID: 31085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600796D")]
		[Address(RVA = "0x1487EB8", Offset = "0x1487EB8", VA = "0x1487EB8")]
		public void PrettyPrint()
		{
		}

		// Token: 0x0600796E RID: 31086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600796E")]
		[Address(RVA = "0x14887E4", Offset = "0x14887E4", VA = "0x14887E4")]
		public void RestoreClosed(ControlData.EyelidBoneMode eyelidBoneMode)
		{
		}

		// Token: 0x0600796F RID: 31087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600796F")]
		[Address(RVA = "0x1488860", Offset = "0x1488860", VA = "0x1488860")]
		public void RestoreDefault(ControlData.EyelidBoneMode eyelidBoneMode)
		{
		}

		// Token: 0x06007970 RID: 31088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007970")]
		[Address(RVA = "0x1488938", Offset = "0x1488938", VA = "0x1488938")]
		public void RestoreLookDown(ControlData.EyelidBoneMode eyelidBoneMode)
		{
		}

		// Token: 0x06007971 RID: 31089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007971")]
		[Address(RVA = "0x14889B4", Offset = "0x14889B4", VA = "0x14889B4")]
		public void RestoreLookUp(ControlData.EyelidBoneMode eyelidBoneMode)
		{
		}

		// Token: 0x06007972 RID: 31090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007972")]
		[Address(RVA = "0x1488A30", Offset = "0x1488A30", VA = "0x1488A30")]
		public void SaveClosed()
		{
		}

		// Token: 0x06007973 RID: 31091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007973")]
		[Address(RVA = "0x1488A7C", Offset = "0x1488A7C", VA = "0x1488A7C")]
		public void SaveDefault(Transform t)
		{
		}

		// Token: 0x06007974 RID: 31092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007974")]
		[Address(RVA = "0x1488C78", Offset = "0x1488C78", VA = "0x1488C78")]
		public void SaveLookDown(float eyeMaxDownAngle)
		{
		}

		// Token: 0x06007975 RID: 31093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007975")]
		[Address(RVA = "0x1488CCC", Offset = "0x1488CCC", VA = "0x1488CCC")]
		public void SaveLookUp(float eyeMaxUpAngle)
		{
		}

		// Token: 0x06007976 RID: 31094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007976")]
		[Address(RVA = "0x1487EA8", Offset = "0x1487EA8", VA = "0x1487EA8")]
		public EyelidRotationLimiter()
		{
		}

		// Token: 0x04003457 RID: 13399
		[Token(Token = "0x4003457")]
		[FieldOffset(Offset = "0x10")]
		public Transform transform;

		// Token: 0x04003458 RID: 13400
		[Token(Token = "0x4003458")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Quaternion defaultQ;

		// Token: 0x04003459 RID: 13401
		[Token(Token = "0x4003459")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Quaternion closedQ;

		// Token: 0x0400345A RID: 13402
		[Token(Token = "0x400345A")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Quaternion lookUpQ;

		// Token: 0x0400345B RID: 13403
		[Token(Token = "0x400345B")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Quaternion lookDownQ;

		// Token: 0x0400345C RID: 13404
		[Token(Token = "0x400345C")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private float eyeMaxDownAngle;

		// Token: 0x0400345D RID: 13405
		[Token(Token = "0x400345D")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private float eyeMaxUpAngle;

		// Token: 0x0400345E RID: 13406
		[Token(Token = "0x400345E")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Vector3 defaultPos;

		// Token: 0x0400345F RID: 13407
		[Token(Token = "0x400345F")]
		[FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private Vector3 closedPos;

		// Token: 0x04003460 RID: 13408
		[Token(Token = "0x4003460")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Vector3 lookUpPos;

		// Token: 0x04003461 RID: 13409
		[Token(Token = "0x4003461")]
		[FieldOffset(Offset = "0x84")]
		[SerializeField]
		private Vector3 lookDownPos;

		// Token: 0x04003462 RID: 13410
		[Token(Token = "0x4003462")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private bool isLookUpSet;

		// Token: 0x04003463 RID: 13411
		[Token(Token = "0x4003463")]
		[FieldOffset(Offset = "0x91")]
		[SerializeField]
		private bool isLookDownSet;

		// Token: 0x04003464 RID: 13412
		[Token(Token = "0x4003464")]
		[FieldOffset(Offset = "0x92")]
		[SerializeField]
		private bool isDefaultPosSet;

		// Token: 0x04003465 RID: 13413
		[Token(Token = "0x4003465")]
		[FieldOffset(Offset = "0x93")]
		[SerializeField]
		private bool isClosedPosSet;

		// Token: 0x04003466 RID: 13414
		[Token(Token = "0x4003466")]
		[FieldOffset(Offset = "0x94")]
		[SerializeField]
		private bool isLookUpPosSet;

		// Token: 0x04003467 RID: 13415
		[Token(Token = "0x4003467")]
		[FieldOffset(Offset = "0x95")]
		[SerializeField]
		private bool isLookDownPosSet;

		// Token: 0x02000C77 RID: 3191
		[Token(Token = "0x2000C77")]
		[Serializable]
		public class EyelidRotationLimiterForExport
		{
			// Token: 0x06007977 RID: 31095 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007977")]
			[Address(RVA = "0x1487A34", Offset = "0x1487A34", VA = "0x1487A34")]
			public EyelidRotationLimiterForExport()
			{
			}

			// Token: 0x04003468 RID: 13416
			[Token(Token = "0x4003468")]
			[FieldOffset(Offset = "0x10")]
			public string transformPath;

			// Token: 0x04003469 RID: 13417
			[Token(Token = "0x4003469")]
			[FieldOffset(Offset = "0x18")]
			public SerializableQuaternion defaultQ;

			// Token: 0x0400346A RID: 13418
			[Token(Token = "0x400346A")]
			[FieldOffset(Offset = "0x28")]
			public SerializableQuaternion closedQ;

			// Token: 0x0400346B RID: 13419
			[Token(Token = "0x400346B")]
			[FieldOffset(Offset = "0x38")]
			public SerializableQuaternion lookUpQ;

			// Token: 0x0400346C RID: 13420
			[Token(Token = "0x400346C")]
			[FieldOffset(Offset = "0x48")]
			public SerializableQuaternion lookDownQ;

			// Token: 0x0400346D RID: 13421
			[Token(Token = "0x400346D")]
			[FieldOffset(Offset = "0x58")]
			public float eyeMaxDownAngle;

			// Token: 0x0400346E RID: 13422
			[Token(Token = "0x400346E")]
			[FieldOffset(Offset = "0x5C")]
			public float eyeMaxUpAngle;

			// Token: 0x0400346F RID: 13423
			[Token(Token = "0x400346F")]
			[FieldOffset(Offset = "0x60")]
			public SerializableVector3 defaultPos;

			// Token: 0x04003470 RID: 13424
			[Token(Token = "0x4003470")]
			[FieldOffset(Offset = "0x6C")]
			public SerializableVector3 closedPos;

			// Token: 0x04003471 RID: 13425
			[Token(Token = "0x4003471")]
			[FieldOffset(Offset = "0x78")]
			public SerializableVector3 lookUpPos;

			// Token: 0x04003472 RID: 13426
			[Token(Token = "0x4003472")]
			[FieldOffset(Offset = "0x84")]
			public SerializableVector3 lookDownPos;

			// Token: 0x04003473 RID: 13427
			[Token(Token = "0x4003473")]
			[FieldOffset(Offset = "0x90")]
			public bool isLookUpSet;

			// Token: 0x04003474 RID: 13428
			[Token(Token = "0x4003474")]
			[FieldOffset(Offset = "0x91")]
			public bool isLookDownSet;

			// Token: 0x04003475 RID: 13429
			[Token(Token = "0x4003475")]
			[FieldOffset(Offset = "0x92")]
			public bool isDefaultPosSet;

			// Token: 0x04003476 RID: 13430
			[Token(Token = "0x4003476")]
			[FieldOffset(Offset = "0x93")]
			public bool isClosedPosSet;

			// Token: 0x04003477 RID: 13431
			[Token(Token = "0x4003477")]
			[FieldOffset(Offset = "0x94")]
			public bool isLookUpPosSet;

			// Token: 0x04003478 RID: 13432
			[Token(Token = "0x4003478")]
			[FieldOffset(Offset = "0x95")]
			public bool isLookDownPosSet;
		}
	}
}
