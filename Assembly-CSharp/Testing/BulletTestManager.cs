using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine;

namespace Testing
{
	// Token: 0x020003A9 RID: 937
	[Token(Token = "0x20003A9")]
	public class BulletTestManager : MonoBehaviour
	{
		// Token: 0x060017B0 RID: 6064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017B0")]
		[Address(RVA = "0x1DB79FC", Offset = "0x1DB79FC", VA = "0x1DB79FC")]
		public void AddBullet(GameObject prefab, GameObject hitPrefab, Vector3 startPos, Quaternion rot, Transform target, float height, float percent, float speed, float flyValue, BulletFlyType flyType, float hitDestroyDelay = 0.5f)
		{
		}

		// Token: 0x060017B1 RID: 6065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017B1")]
		[Address(RVA = "0x1DB7DCC", Offset = "0x1DB7DCC", VA = "0x1DB7DCC")]
		private void Update()
		{
		}

		// Token: 0x060017B2 RID: 6066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017B2")]
		[Address(RVA = "0x1DB8780", Offset = "0x1DB8780", VA = "0x1DB8780")]
		private void OnDestroy()
		{
		}

		// Token: 0x060017B3 RID: 6067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017B3")]
		[Address(RVA = "0x1DB88E8", Offset = "0x1DB88E8", VA = "0x1DB88E8")]
		public BulletTestManager()
		{
		}

		// Token: 0x04001A61 RID: 6753
		[Token(Token = "0x4001A61")]
		[FieldOffset(Offset = "0x18")]
		private List<BulletTestManager.BulletInfoTest> _bulletList;

		// Token: 0x04001A62 RID: 6754
		[Token(Token = "0x4001A62")]
		[FieldOffset(Offset = "0x20")]
		private JobHandle _curJobHandle;

		// Token: 0x020003AA RID: 938
		[Token(Token = "0x20003AA")]
		private class BulletInfoTest
		{
			// Token: 0x060017B4 RID: 6068 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60017B4")]
			[Address(RVA = "0x1DB7BA8", Offset = "0x1DB7BA8", VA = "0x1DB7BA8")]
			public void Init(GameObject prefab, GameObject hitPrefab, Vector3 startPos, Quaternion rot, Transform target, float height, float percent, float speed, float flyValue, BulletFlyType flyType, float hitDestroyDelay)
			{
			}

			// Token: 0x060017B5 RID: 6069 RVA: 0x00008C28 File Offset: 0x00006E28
			[Token(Token = "0x60017B5")]
			[Address(RVA = "0x1DB8614", Offset = "0x1DB8614", VA = "0x1DB8614")]
			public float3 GetTargetPosition()
			{
				return default(float3);
			}

			// Token: 0x060017B6 RID: 6070 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60017B6")]
			[Address(RVA = "0x1DB86D4", Offset = "0x1DB86D4", VA = "0x1DB86D4")]
			public void Destroy()
			{
			}

			// Token: 0x060017B7 RID: 6071 RVA: 0x00008C40 File Offset: 0x00006E40
			[Token(Token = "0x60017B7")]
			[Address(RVA = "0x1DB86C8", Offset = "0x1DB86C8", VA = "0x1DB86C8")]
			public float ArriveDistance()
			{
				return 0f;
			}

			// Token: 0x060017B8 RID: 6072 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60017B8")]
			[Address(RVA = "0x1DB8970", Offset = "0x1DB8970", VA = "0x1DB8970")]
			public GameObject GetHitPrefab()
			{
				return null;
			}

			// Token: 0x060017B9 RID: 6073 RVA: 0x00008C58 File Offset: 0x00006E58
			[Token(Token = "0x60017B9")]
			[Address(RVA = "0x1DB8978", Offset = "0x1DB8978", VA = "0x1DB8978")]
			public float GetHitDestroyDelay()
			{
				return 0f;
			}

			// Token: 0x060017BA RID: 6074 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60017BA")]
			[Address(RVA = "0x1DB7BA0", Offset = "0x1DB7BA0", VA = "0x1DB7BA0")]
			public BulletInfoTest()
			{
			}

			// Token: 0x04001A63 RID: 6755
			[Token(Token = "0x4001A63")]
			[FieldOffset(Offset = "0x10")]
			public Transform Transform;

			// Token: 0x04001A64 RID: 6756
			[Token(Token = "0x4001A64")]
			[FieldOffset(Offset = "0x18")]
			public float3 StartPosition;

			// Token: 0x04001A65 RID: 6757
			[Token(Token = "0x4001A65")]
			[FieldOffset(Offset = "0x28")]
			public double StartTime;

			// Token: 0x04001A66 RID: 6758
			[Token(Token = "0x4001A66")]
			[FieldOffset(Offset = "0x30")]
			public bool IsCreateFinish;

			// Token: 0x04001A67 RID: 6759
			[Token(Token = "0x4001A67")]
			[FieldOffset(Offset = "0x34")]
			public float HeightValue;

			// Token: 0x04001A68 RID: 6760
			[Token(Token = "0x4001A68")]
			[FieldOffset(Offset = "0x38")]
			public float CenterPercent;

			// Token: 0x04001A69 RID: 6761
			[Token(Token = "0x4001A69")]
			[FieldOffset(Offset = "0x3C")]
			public float Speed;

			// Token: 0x04001A6A RID: 6762
			[Token(Token = "0x4001A6A")]
			[FieldOffset(Offset = "0x40")]
			public BulletFlyType FlyType;

			// Token: 0x04001A6B RID: 6763
			[Token(Token = "0x4001A6B")]
			[FieldOffset(Offset = "0x48")]
			private Transform _targetTrans;

			// Token: 0x04001A6C RID: 6764
			[Token(Token = "0x4001A6C")]
			[FieldOffset(Offset = "0x50")]
			private float _flyValue;

			// Token: 0x04001A6D RID: 6765
			[Token(Token = "0x4001A6D")]
			[FieldOffset(Offset = "0x58")]
			private GameObject _hitPrefab;

			// Token: 0x04001A6E RID: 6766
			[Token(Token = "0x4001A6E")]
			[FieldOffset(Offset = "0x60")]
			private float _hitDestroyDelay;
		}
	}
}
