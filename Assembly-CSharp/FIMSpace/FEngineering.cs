using System;
using Il2CppDummyDll;
using UnityEngine;

namespace FIMSpace
{
	// Token: 0x02000C0D RID: 3085
	[Token(Token = "0x2000C0D")]
	public static class FEngineering
	{
		// Token: 0x060075BB RID: 30139 RVA: 0x00051DB0 File Offset: 0x0004FFB0
		[Token(Token = "0x60075BB")]
		[Address(RVA = "0x31B8AAC", Offset = "0x31B8AAC", VA = "0x31B8AAC")]
		public static bool VIsZero(this Vector3 vec)
		{
			return default(bool);
		}

		// Token: 0x060075BC RID: 30140 RVA: 0x00051DC8 File Offset: 0x0004FFC8
		[Token(Token = "0x60075BC")]
		[Address(RVA = "0x31B8ACC", Offset = "0x31B8ACC", VA = "0x31B8ACC")]
		public static bool VIsSame(this Vector3 vec1, Vector3 vec2)
		{
			return default(bool);
		}

		// Token: 0x060075BD RID: 30141 RVA: 0x00051DE0 File Offset: 0x0004FFE0
		[Token(Token = "0x60075BD")]
		[Address(RVA = "0x31B8AF0", Offset = "0x31B8AF0", VA = "0x31B8AF0")]
		public static Vector3 TransformVector(this Quaternion parentRot, Vector3 parentLossyScale, Vector3 childLocalPos)
		{
			return default(Vector3);
		}

		// Token: 0x060075BE RID: 30142 RVA: 0x00051DF8 File Offset: 0x0004FFF8
		[Token(Token = "0x60075BE")]
		[Address(RVA = "0x31B8B0C", Offset = "0x31B8B0C", VA = "0x31B8B0C")]
		public static Vector3 TransformInDirection(this Quaternion childRotation, Vector3 parentLossyScale, Vector3 childLocalPos)
		{
			return default(Vector3);
		}

		// Token: 0x060075BF RID: 30143 RVA: 0x00051E10 File Offset: 0x00050010
		[Token(Token = "0x60075BF")]
		[Address(RVA = "0x31B8B40", Offset = "0x31B8B40", VA = "0x31B8B40")]
		public static Vector3 InverseTransformVector(this Quaternion tRotation, Vector3 tLossyScale, Vector3 worldPos)
		{
			return default(Vector3);
		}

		// Token: 0x060075C0 RID: 30144 RVA: 0x00051E28 File Offset: 0x00050028
		[Token(Token = "0x60075C0")]
		[Address(RVA = "0x31B8BA0", Offset = "0x31B8BA0", VA = "0x31B8BA0")]
		public static Vector3 VAxis2DLimit(this Transform parent, Vector3 parentPos, Vector3 childPos, int axis = 3)
		{
			return default(Vector3);
		}

		// Token: 0x060075C1 RID: 30145 RVA: 0x00051E40 File Offset: 0x00050040
		[Token(Token = "0x60075C1")]
		[Address(RVA = "0x31B8CBC", Offset = "0x31B8CBC", VA = "0x31B8CBC")]
		public static Quaternion QToLocal(this Quaternion parentRotation, Quaternion worldRotation)
		{
			return default(Quaternion);
		}

		// Token: 0x060075C2 RID: 30146 RVA: 0x00051E58 File Offset: 0x00050058
		[Token(Token = "0x60075C2")]
		[Address(RVA = "0x31B8D60", Offset = "0x31B8D60", VA = "0x31B8D60")]
		public static Quaternion QToWorld(this Quaternion parentRotation, Quaternion localRotation)
		{
			return default(Quaternion);
		}

		// Token: 0x060075C3 RID: 30147 RVA: 0x00051E70 File Offset: 0x00050070
		[Token(Token = "0x60075C3")]
		[Address(RVA = "0x31B8DD4", Offset = "0x31B8DD4", VA = "0x31B8DD4")]
		public static Quaternion QRotateChild(this Quaternion offset, Quaternion parentRot, Quaternion childLocalRot)
		{
			return default(Quaternion);
		}

		// Token: 0x060075C4 RID: 30148 RVA: 0x00051E88 File Offset: 0x00050088
		[Token(Token = "0x60075C4")]
		[Address(RVA = "0x31B8EC4", Offset = "0x31B8EC4", VA = "0x31B8EC4")]
		public static Quaternion ClampRotation(this Vector3 current, Vector3 bounds)
		{
			return default(Quaternion);
		}

		// Token: 0x060075C5 RID: 30149 RVA: 0x00051EA0 File Offset: 0x000500A0
		[Token(Token = "0x60075C5")]
		[Address(RVA = "0x31B8FAC", Offset = "0x31B8FAC", VA = "0x31B8FAC")]
		public static Vector3 QToAngularVelocity(this Quaternion deltaRotation, bool fix = false)
		{
			return default(Vector3);
		}

		// Token: 0x060075C6 RID: 30150 RVA: 0x00051EB8 File Offset: 0x000500B8
		[Token(Token = "0x60075C6")]
		[Address(RVA = "0x31B91D0", Offset = "0x31B91D0", VA = "0x31B91D0")]
		public static Vector3 QToAngularVelocity(this Quaternion currentRotation, Quaternion targetRotation, bool fix = false)
		{
			return default(Vector3);
		}

		// Token: 0x060075C7 RID: 30151 RVA: 0x00051ED0 File Offset: 0x000500D0
		[Token(Token = "0x60075C7")]
		[Address(RVA = "0x31B927C", Offset = "0x31B927C", VA = "0x31B927C")]
		public static bool QIsZero(this Quaternion rot)
		{
			return default(bool);
		}

		// Token: 0x060075C8 RID: 30152 RVA: 0x00051EE8 File Offset: 0x000500E8
		[Token(Token = "0x60075C8")]
		[Address(RVA = "0x31B92A0", Offset = "0x31B92A0", VA = "0x31B92A0")]
		public static bool QIsSame(this Quaternion rot1, Quaternion rot2)
		{
			return default(bool);
		}

		// Token: 0x060075C9 RID: 30153 RVA: 0x00051F00 File Offset: 0x00050100
		[Token(Token = "0x60075C9")]
		[Address(RVA = "0x31B92CC", Offset = "0x31B92CC", VA = "0x31B92CC")]
		public static float WrapAngle(float angle)
		{
			return 0f;
		}

		// Token: 0x060075CA RID: 30154 RVA: 0x00051F18 File Offset: 0x00050118
		[Token(Token = "0x60075CA")]
		[Address(RVA = "0x31B8F1C", Offset = "0x31B8F1C", VA = "0x31B8F1C")]
		public static Vector3 WrapVector(Vector3 angles)
		{
			return default(Vector3);
		}

		// Token: 0x060075CB RID: 30155 RVA: 0x00051F30 File Offset: 0x00050130
		[Token(Token = "0x60075CB")]
		[Address(RVA = "0x31B9300", Offset = "0x31B9300", VA = "0x31B9300")]
		public static float UnwrapAngle(float angle)
		{
			return 0f;
		}

		// Token: 0x060075CC RID: 30156 RVA: 0x00051F48 File Offset: 0x00050148
		[Token(Token = "0x60075CC")]
		[Address(RVA = "0x31B9334", Offset = "0x31B9334", VA = "0x31B9334")]
		public static Vector3 UnwrapVector(Vector3 angles)
		{
			return default(Vector3);
		}

		// Token: 0x060075CD RID: 30157 RVA: 0x00051F60 File Offset: 0x00050160
		[Token(Token = "0x60075CD")]
		[Address(RVA = "0x31B93C8", Offset = "0x31B93C8", VA = "0x31B93C8")]
		public static Quaternion SmoothDampRotation(this Quaternion current, Quaternion target, ref Quaternion velocityRef, float duration, float delta)
		{
			return default(Quaternion);
		}

		// Token: 0x060075CE RID: 30158 RVA: 0x00051F78 File Offset: 0x00050178
		[Token(Token = "0x60075CE")]
		[Address(RVA = "0x31B93F8", Offset = "0x31B93F8", VA = "0x31B93F8")]
		public static Quaternion SmoothDampRotation(this Quaternion current, Quaternion target, ref Quaternion velocityRef, float duration, float maxSpeed, float delta)
		{
			return default(Quaternion);
		}

		// Token: 0x060075CF RID: 30159 RVA: 0x00051F90 File Offset: 0x00050190
		[Token(Token = "0x60075CF")]
		[Address(RVA = "0x31B9630", Offset = "0x31B9630", VA = "0x31B9630")]
		public static float PerlinNoise3D(float x, float y, float z)
		{
			return 0f;
		}

		// Token: 0x060075D0 RID: 30160 RVA: 0x00051FA8 File Offset: 0x000501A8
		[Token(Token = "0x60075D0")]
		[Address(RVA = "0x31B9730", Offset = "0x31B9730", VA = "0x31B9730")]
		public static float PerlinNoise3D(Vector3 pos)
		{
			return 0f;
		}

		// Token: 0x060075D1 RID: 30161 RVA: 0x00051FC0 File Offset: 0x000501C0
		[Token(Token = "0x60075D1")]
		[Address(RVA = "0x31B9734", Offset = "0x31B9734", VA = "0x31B9734")]
		public static bool SameDirection(this float a, float b)
		{
			return default(bool);
		}

		// Token: 0x060075D2 RID: 30162 RVA: 0x00051FD8 File Offset: 0x000501D8
		[Token(Token = "0x60075D2")]
		[Address(RVA = "0x31B9764", Offset = "0x31B9764", VA = "0x31B9764")]
		public static float PointDisperse01(int index, int baseV = 2)
		{
			return 0f;
		}

		// Token: 0x060075D3 RID: 30163 RVA: 0x00051FF0 File Offset: 0x000501F0
		[Token(Token = "0x60075D3")]
		[Address(RVA = "0x31B9818", Offset = "0x31B9818", VA = "0x31B9818")]
		public static float PointDisperse(int index, int baseV = 2)
		{
			return 0f;
		}

		// Token: 0x060075D4 RID: 30164 RVA: 0x00052008 File Offset: 0x00050208
		[Token(Token = "0x60075D4")]
		[Address(RVA = "0x31B98D0", Offset = "0x31B98D0", VA = "0x31B98D0")]
		public static float GetScaler(this Transform transform)
		{
			return 0f;
		}

		// Token: 0x060075D5 RID: 30165 RVA: 0x00052020 File Offset: 0x00050220
		[Token(Token = "0x60075D5")]
		[Address(RVA = "0x31B9954", Offset = "0x31B9954", VA = "0x31B9954")]
		public static Vector3 PosFromMatrix(this Matrix4x4 m)
		{
			return default(Vector3);
		}

		// Token: 0x060075D6 RID: 30166 RVA: 0x00052038 File Offset: 0x00050238
		[Token(Token = "0x60075D6")]
		[Address(RVA = "0x31B9960", Offset = "0x31B9960", VA = "0x31B9960")]
		public static Quaternion RotFromMatrix(this Matrix4x4 m)
		{
			return default(Quaternion);
		}

		// Token: 0x060075D7 RID: 30167 RVA: 0x00052050 File Offset: 0x00050250
		[Token(Token = "0x60075D7")]
		[Address(RVA = "0x31B99C4", Offset = "0x31B99C4", VA = "0x31B99C4")]
		public static Vector3 ScaleFromMatrix(this Matrix4x4 m)
		{
			return default(Vector3);
		}

		// Token: 0x060075D8 RID: 30168 RVA: 0x00052068 File Offset: 0x00050268
		[Token(Token = "0x60075D8")]
		[Address(RVA = "0x31B9B58", Offset = "0x31B9B58", VA = "0x31B9B58")]
		public static Bounds TransformBounding(Bounds b, Transform by)
		{
			return default(Bounds);
		}

		// Token: 0x060075D9 RID: 30169 RVA: 0x00052080 File Offset: 0x00050280
		[Token(Token = "0x60075D9")]
		[Address(RVA = "0x31B9BD8", Offset = "0x31B9BD8", VA = "0x31B9BD8")]
		public static Bounds TransformBounding(Bounds b, Matrix4x4 mx)
		{
			return default(Bounds);
		}

		// Token: 0x060075DA RID: 30170 RVA: 0x00052098 File Offset: 0x00050298
		[Token(Token = "0x60075DA")]
		[Address(RVA = "0x31B9DB4", Offset = "0x31B9DB4", VA = "0x31B9DB4")]
		public static Bounds RotateBoundsByMatrix(this Bounds b, Quaternion rotation)
		{
			return default(Bounds);
		}

		// Token: 0x060075DB RID: 30171 RVA: 0x000520B0 File Offset: 0x000502B0
		[Token(Token = "0x60075DB")]
		[Address(RVA = "0x31BA190", Offset = "0x31BA190", VA = "0x31BA190")]
		public static Bounds RotateLocalBounds(this Bounds b, Quaternion rotation)
		{
			return default(Bounds);
		}

		// Token: 0x060075DC RID: 30172 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60075DC")]
		[Address(RVA = "0x31BA328", Offset = "0x31BA328", VA = "0x31BA328")]
		public static int[] GetLayermaskValues(int mask, int optionsCount)
		{
			return null;
		}

		// Token: 0x060075DD RID: 30173 RVA: 0x000520C8 File Offset: 0x000502C8
		[Token(Token = "0x60075DD")]
		[Address(RVA = "0x31BA45C", Offset = "0x31BA45C", VA = "0x31BA45C")]
		public static LayerMask GetLayerMaskUsingPhysicsProjectSettingsMatrix(int maskForLayer)
		{
			return default(LayerMask);
		}

		// Token: 0x17000A55 RID: 2645
		// (get) Token: 0x060075DE RID: 30174 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A55")]
		public static PhysicMaterial PMSliding
		{
			[Token(Token = "0x60075DE")]
			[Address(RVA = "0x31BA4D8", Offset = "0x31BA4D8", VA = "0x31BA4D8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A56 RID: 2646
		// (get) Token: 0x060075DF RID: 30175 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A56")]
		public static PhysicMaterial PMFrict
		{
			[Token(Token = "0x60075DF")]
			[Address(RVA = "0x31BA610", Offset = "0x31BA610", VA = "0x31BA610")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A57 RID: 2647
		// (get) Token: 0x060075E0 RID: 30176 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A57")]
		public static PhysicsMaterial2D PMSliding2D
		{
			[Token(Token = "0x60075E0")]
			[Address(RVA = "0x31BA748", Offset = "0x31BA748", VA = "0x31BA748")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A58 RID: 2648
		// (get) Token: 0x060075E1 RID: 30177 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A58")]
		public static PhysicsMaterial2D PMFrict2D
		{
			[Token(Token = "0x60075E1")]
			[Address(RVA = "0x31BA848", Offset = "0x31BA848", VA = "0x31BA848")]
			get
			{
				return null;
			}
		}

		// Token: 0x060075E2 RID: 30178 RVA: 0x000520E0 File Offset: 0x000502E0
		[Token(Token = "0x60075E2")]
		[Address(RVA = "0x31BA948", Offset = "0x31BA948", VA = "0x31BA948")]
		public static float DistanceTo_2D(Vector3 aPos, Vector3 bPos)
		{
			return 0f;
		}

		// Token: 0x060075E3 RID: 30179 RVA: 0x000520F8 File Offset: 0x000502F8
		[Token(Token = "0x60075E3")]
		[Address(RVA = "0x31BA9C4", Offset = "0x31BA9C4", VA = "0x31BA9C4")]
		public static float DistanceTo_2DSqrt(Vector3 aPos, Vector3 bPos)
		{
			return 0f;
		}

		// Token: 0x060075E4 RID: 30180 RVA: 0x00052110 File Offset: 0x00050310
		[Token(Token = "0x60075E4")]
		[Address(RVA = "0x31BA9DC", Offset = "0x31BA9DC", VA = "0x31BA9DC")]
		public static Vector2 GetAngleDirection2D(float angle)
		{
			return default(Vector2);
		}

		// Token: 0x060075E5 RID: 30181 RVA: 0x00052128 File Offset: 0x00050328
		[Token(Token = "0x60075E5")]
		[Address(RVA = "0x31BAA04", Offset = "0x31BAA04", VA = "0x31BAA04")]
		public static Vector3 GetAngleDirection(float angle)
		{
			return default(Vector3);
		}

		// Token: 0x060075E6 RID: 30182 RVA: 0x00052140 File Offset: 0x00050340
		[Token(Token = "0x60075E6")]
		[Address(RVA = "0x31BAA30", Offset = "0x31BAA30", VA = "0x31BAA30")]
		public static Vector3 GetAngleDirectionXZ(float angle)
		{
			return default(Vector3);
		}

		// Token: 0x060075E7 RID: 30183 RVA: 0x00052158 File Offset: 0x00050358
		[Token(Token = "0x60075E7")]
		[Address(RVA = "0x31BAA5C", Offset = "0x31BAA5C", VA = "0x31BAA5C")]
		public static Vector3 GetAngleDirectionZX(float angle)
		{
			return default(Vector3);
		}

		// Token: 0x060075E8 RID: 30184 RVA: 0x00052170 File Offset: 0x00050370
		[Token(Token = "0x60075E8")]
		[Address(RVA = "0x31BAA88", Offset = "0x31BAA88", VA = "0x31BAA88")]
		public static Vector3 GetAngleDirectionXY(float angle, float radOffset = 0f, float secAxisRadOffset = 0f)
		{
			return default(Vector3);
		}

		// Token: 0x060075E9 RID: 30185 RVA: 0x00052188 File Offset: 0x00050388
		[Token(Token = "0x60075E9")]
		[Address(RVA = "0x31BAAD4", Offset = "0x31BAAD4", VA = "0x31BAAD4")]
		public static Vector3 GetAngleDirectionYX(float angle, float firstAxisRadOffset = 0f, float secAxisRadOffset = 0f)
		{
			return default(Vector3);
		}

		// Token: 0x060075EA RID: 30186 RVA: 0x000521A0 File Offset: 0x000503A0
		[Token(Token = "0x60075EA")]
		[Address(RVA = "0x31BAB20", Offset = "0x31BAB20", VA = "0x31BAB20")]
		public static Vector3 GetAngleDirectionYZ(float angle)
		{
			return default(Vector3);
		}

		// Token: 0x060075EB RID: 30187 RVA: 0x000521B8 File Offset: 0x000503B8
		[Token(Token = "0x60075EB")]
		[Address(RVA = "0x31BAB4C", Offset = "0x31BAB4C", VA = "0x31BAB4C")]
		public static Vector3 GetAngleDirectionZY(float angle)
		{
			return default(Vector3);
		}

		// Token: 0x060075EC RID: 30188 RVA: 0x000521D0 File Offset: 0x000503D0
		[Token(Token = "0x60075EC")]
		[Address(RVA = "0x31BAB78", Offset = "0x31BAB78", VA = "0x31BAB78")]
		public static Vector3 V2ToV3TopDown(Vector2 v)
		{
			return default(Vector3);
		}

		// Token: 0x060075ED RID: 30189 RVA: 0x000521E8 File Offset: 0x000503E8
		[Token(Token = "0x60075ED")]
		[Address(RVA = "0x31BAB84", Offset = "0x31BAB84", VA = "0x31BAB84")]
		public static Vector2 V3ToV2(Vector3 a)
		{
			return default(Vector2);
		}

		// Token: 0x060075EE RID: 30190 RVA: 0x00052200 File Offset: 0x00050400
		[Token(Token = "0x60075EE")]
		[Address(RVA = "0x31BAB8C", Offset = "0x31BAB8C", VA = "0x31BAB8C")]
		public static Vector2 V3TopDownDiff(Vector3 target, Vector3 me)
		{
			return default(Vector2);
		}

		// Token: 0x060075EF RID: 30191 RVA: 0x00052218 File Offset: 0x00050418
		[Token(Token = "0x60075EF")]
		[Address(RVA = "0x31BAB98", Offset = "0x31BAB98", VA = "0x31BAB98")]
		public static float GetAngleDeg(Vector3 v)
		{
			return 0f;
		}

		// Token: 0x060075F0 RID: 30192 RVA: 0x00052230 File Offset: 0x00050430
		[Token(Token = "0x60075F0")]
		[Address(RVA = "0x31BABD4", Offset = "0x31BABD4", VA = "0x31BABD4")]
		public static float GetAngleDeg(Vector2 v)
		{
			return 0f;
		}

		// Token: 0x060075F1 RID: 30193 RVA: 0x00052248 File Offset: 0x00050448
		[Token(Token = "0x60075F1")]
		[Address(RVA = "0x31BABB8", Offset = "0x31BABB8", VA = "0x31BABB8")]
		public static float GetAngleDeg(float x, float z)
		{
			return 0f;
		}

		// Token: 0x060075F2 RID: 30194 RVA: 0x00052260 File Offset: 0x00050460
		[Token(Token = "0x60075F2")]
		[Address(RVA = "0x31BABF0", Offset = "0x31BABF0", VA = "0x31BABF0")]
		public static float GetAngleRad(float x, float z)
		{
			return 0f;
		}

		// Token: 0x060075F3 RID: 30195 RVA: 0x00052278 File Offset: 0x00050478
		[Token(Token = "0x60075F3")]
		[Address(RVA = "0x31BABF4", Offset = "0x31BABF4", VA = "0x31BABF4")]
		public static float Rnd(float val, int dec = 0)
		{
			return 0f;
		}

		// Token: 0x060075F4 RID: 30196 RVA: 0x00052290 File Offset: 0x00050490
		[Token(Token = "0x60075F4")]
		[Address(RVA = "0x31BAD1C", Offset = "0x31BAD1C", VA = "0x31BAD1C")]
		internal static float ManhattanTopDown2D(Vector3 probePos, Vector3 worldPosition)
		{
			return 0f;
		}

		// Token: 0x060075F5 RID: 30197 RVA: 0x000522A8 File Offset: 0x000504A8
		[Token(Token = "0x60075F5")]
		[Address(RVA = "0x31BAD44", Offset = "0x31BAD44", VA = "0x31BAD44")]
		internal static bool IsInSqureBounds2D(Vector3 probePos, Vector3 boundsPos, float boundsRange)
		{
			return default(bool);
		}

		// Token: 0x060075F6 RID: 30198 RVA: 0x000522C0 File Offset: 0x000504C0
		[Token(Token = "0x60075F6")]
		[Address(RVA = "0x31BAD94", Offset = "0x31BAD94", VA = "0x31BAD94")]
		internal static bool IsInSqureBounds2D(Vector3 boundsAPos, float boundsAHalfRange, Vector3 boundsBPos, float boundsBHRange)
		{
			return default(bool);
		}

		// Token: 0x060075F7 RID: 30199 RVA: 0x000522D8 File Offset: 0x000504D8
		[Token(Token = "0x60075F7")]
		[Address(RVA = "0x31BADE0", Offset = "0x31BADE0", VA = "0x31BADE0")]
		internal static Vector3 GetDirectionTowards(Vector3 me, Vector3 target)
		{
			return default(Vector3);
		}

		// Token: 0x04002FD9 RID: 12249
		[Token(Token = "0x4002FD9")]
		[FieldOffset(Offset = "0x0")]
		private static Plane axis2DProjection;

		// Token: 0x04002FDA RID: 12250
		[Token(Token = "0x4002FDA")]
		[FieldOffset(Offset = "0x10")]
		private static PhysicMaterial _slidingMat;

		// Token: 0x04002FDB RID: 12251
		[Token(Token = "0x4002FDB")]
		[FieldOffset(Offset = "0x18")]
		private static PhysicMaterial _frictMat;

		// Token: 0x04002FDC RID: 12252
		[Token(Token = "0x4002FDC")]
		[FieldOffset(Offset = "0x20")]
		private static PhysicsMaterial2D _slidingMat2D;

		// Token: 0x04002FDD RID: 12253
		[Token(Token = "0x4002FDD")]
		[FieldOffset(Offset = "0x28")]
		private static PhysicsMaterial2D _frictMat2D;
	}
}
