using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace RealisticEyeMovements
{
	// Token: 0x02000C78 RID: 3192
	[Token(Token = "0x2000C78")]
	[Serializable]
	public class EyeRotationLimiter
	{
		// Token: 0x06007978 RID: 31096 RVA: 0x000534C0 File Offset: 0x000516C0
		[Token(Token = "0x6007978")]
		[Address(RVA = "0x1488D20", Offset = "0x1488D20", VA = "0x1488D20")]
		public bool CanImport(EyeRotationLimiter.EyeRotationLimiterForExport import, Transform startXform, [Optional] string targetNameForErrorMessage)
		{
			return default(bool);
		}

		// Token: 0x06007979 RID: 31097 RVA: 0x000534D8 File Offset: 0x000516D8
		[Token(Token = "0x6007979")]
		[Address(RVA = "0x1488D98", Offset = "0x1488D98", VA = "0x1488D98")]
		public float ClampAngle(float angle)
		{
			return 0f;
		}

		// Token: 0x0600797A RID: 31098 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600797A")]
		[Address(RVA = "0x1488EE0", Offset = "0x1488EE0", VA = "0x1488EE0")]
		public EyeRotationLimiter.EyeRotationLimiterForExport GetExport(Transform startXform)
		{
			return null;
		}

		// Token: 0x0600797B RID: 31099 RVA: 0x000534F0 File Offset: 0x000516F0
		[Token(Token = "0x600797B")]
		[Address(RVA = "0x1488FC0", Offset = "0x1488FC0", VA = "0x1488FC0")]
		public float GetEyeUp01(float angle)
		{
			return 0f;
		}

		// Token: 0x0600797C RID: 31100 RVA: 0x00053508 File Offset: 0x00051708
		[Token(Token = "0x600797C")]
		[Address(RVA = "0x1488FF8", Offset = "0x1488FF8", VA = "0x1488FF8")]
		public float GetEyeDown01(float angle)
		{
			return 0f;
		}

		// Token: 0x0600797D RID: 31101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600797D")]
		[Address(RVA = "0x148902C", Offset = "0x148902C", VA = "0x148902C")]
		public void Import(EyeRotationLimiter.EyeRotationLimiterForExport import, Transform targetXform)
		{
		}

		// Token: 0x0600797E RID: 31102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600797E")]
		[Address(RVA = "0x14894F4", Offset = "0x14894F4", VA = "0x14894F4")]
		public void RestoreDefault()
		{
		}

		// Token: 0x0600797F RID: 31103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600797F")]
		[Address(RVA = "0x148951C", Offset = "0x148951C", VA = "0x148951C")]
		public void RestoreLookDown()
		{
		}

		// Token: 0x06007980 RID: 31104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007980")]
		[Address(RVA = "0x1489544", Offset = "0x1489544", VA = "0x1489544")]
		public void RestoreLookUp()
		{
		}

		// Token: 0x06007981 RID: 31105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007981")]
		[Address(RVA = "0x148956C", Offset = "0x148956C", VA = "0x148956C")]
		public void SaveDefault(Transform t)
		{
		}

		// Token: 0x06007982 RID: 31106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007982")]
		[Address(RVA = "0x1489708", Offset = "0x1489708", VA = "0x1489708")]
		public void SaveLookDown()
		{
		}

		// Token: 0x06007983 RID: 31107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007983")]
		[Address(RVA = "0x1489744", Offset = "0x1489744", VA = "0x1489744")]
		public void SaveLookUp()
		{
		}

		// Token: 0x06007984 RID: 31108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007984")]
		[Address(RVA = "0x1489088", Offset = "0x1489088", VA = "0x1489088")]
		private void UpdateMaxAngles()
		{
		}

		// Token: 0x06007985 RID: 31109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007985")]
		[Address(RVA = "0x1489780", Offset = "0x1489780", VA = "0x1489780")]
		public EyeRotationLimiter()
		{
		}

		// Token: 0x04003479 RID: 13433
		[Token(Token = "0x4003479")]
		[FieldOffset(Offset = "0x10")]
		public Transform transform;

		// Token: 0x0400347A RID: 13434
		[Token(Token = "0x400347A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Quaternion defaultQ;

		// Token: 0x0400347B RID: 13435
		[Token(Token = "0x400347B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Quaternion lookUpQ;

		// Token: 0x0400347C RID: 13436
		[Token(Token = "0x400347C")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Quaternion lookDownQ;

		// Token: 0x0400347D RID: 13437
		[Token(Token = "0x400347D")]
		[FieldOffset(Offset = "0x48")]
		public float maxUpAngle;

		// Token: 0x0400347E RID: 13438
		[Token(Token = "0x400347E")]
		[FieldOffset(Offset = "0x4C")]
		public float maxDownAngle;

		// Token: 0x0400347F RID: 13439
		[Token(Token = "0x400347F")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private bool isLookUpSet;

		// Token: 0x04003480 RID: 13440
		[Token(Token = "0x4003480")]
		[FieldOffset(Offset = "0x51")]
		[SerializeField]
		private bool isLookDownSet;

		// Token: 0x02000C79 RID: 3193
		[Token(Token = "0x2000C79")]
		[Serializable]
		public class EyeRotationLimiterForExport
		{
			// Token: 0x06007986 RID: 31110 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007986")]
			[Address(RVA = "0x1488FB8", Offset = "0x1488FB8", VA = "0x1488FB8")]
			public EyeRotationLimiterForExport()
			{
			}

			// Token: 0x04003481 RID: 13441
			[Token(Token = "0x4003481")]
			[FieldOffset(Offset = "0x10")]
			public string transformPath;

			// Token: 0x04003482 RID: 13442
			[Token(Token = "0x4003482")]
			[FieldOffset(Offset = "0x18")]
			public SerializableQuaternion defaultQ;

			// Token: 0x04003483 RID: 13443
			[Token(Token = "0x4003483")]
			[FieldOffset(Offset = "0x28")]
			public SerializableQuaternion lookUpQ;

			// Token: 0x04003484 RID: 13444
			[Token(Token = "0x4003484")]
			[FieldOffset(Offset = "0x38")]
			public SerializableQuaternion lookDownQ;

			// Token: 0x04003485 RID: 13445
			[Token(Token = "0x4003485")]
			[FieldOffset(Offset = "0x48")]
			public bool isLookUpSet;

			// Token: 0x04003486 RID: 13446
			[Token(Token = "0x4003486")]
			[FieldOffset(Offset = "0x49")]
			public bool isLookDownSet;
		}
	}
}
