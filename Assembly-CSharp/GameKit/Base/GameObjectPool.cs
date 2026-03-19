using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace GameKit.Base
{
	// Token: 0x020004DD RID: 1245
	[Token(Token = "0x20004DD")]
	public sealed class GameObjectPool : SingletonBehaviour<GameObjectPool>
	{
		// Token: 0x170005B6 RID: 1462
		// (get) Token: 0x06002584 RID: 9604 RVA: 0x0000E4F0 File Offset: 0x0000C6F0
		// (set) Token: 0x06002585 RID: 9605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005B6")]
		public float ExpiredTime
		{
			[Token(Token = "0x6002584")]
			[Address(RVA = "0x2B55838", Offset = "0x2B55838", VA = "0x2B55838")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6002585")]
			[Address(RVA = "0x2B55840", Offset = "0x2B55840", VA = "0x2B55840")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06002586 RID: 9606 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002586")]
		[Address(RVA = "0x2B55848", Offset = "0x2B55848", VA = "0x2B55848")]
		private void Start()
		{
		}

		// Token: 0x06002587 RID: 9607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002587")]
		[Address(RVA = "0x2B5591C", Offset = "0x2B5591C", VA = "0x2B5591C")]
		public void Shutdown()
		{
		}

		// Token: 0x06002588 RID: 9608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002588")]
		[Address(RVA = "0x2B55920", Offset = "0x2B55920", VA = "0x2B55920")]
		public void ClearPool()
		{
		}

		// Token: 0x06002589 RID: 9609 RVA: 0x0000E508 File Offset: 0x0000C708
		[Token(Token = "0x6002589")]
		[Address(RVA = "0x2B55C00", Offset = "0x2B55C00", VA = "0x2B55C00")]
		private bool CheckExpiredObject()
		{
			return default(bool);
		}

		// Token: 0x0600258A RID: 9610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600258A")]
		[Address(RVA = "0x2B563BC", Offset = "0x2B563BC", VA = "0x2B563BC")]
		private static void RecordTimeStamp(GameObject obj)
		{
		}

		// Token: 0x0600258B RID: 9611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600258B")]
		[Address(RVA = "0x2B5643C", Offset = "0x2B5643C", VA = "0x2B5643C")]
		private static void RemoveFromTimeStamp(GameObject obj)
		{
		}

		// Token: 0x0600258C RID: 9612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600258C")]
		public static void CreatePool<T>(T prefab, int initialPoolSize) where T : Component
		{
		}

		// Token: 0x0600258D RID: 9613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600258D")]
		[Address(RVA = "0x2B564F4", Offset = "0x2B564F4", VA = "0x2B564F4")]
		public static void CreatePool(GameObject prefab, int initialPoolSize)
		{
		}

		// Token: 0x0600258E RID: 9614 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600258E")]
		public static T Spawn<T>(T prefab, Transform parent, Vector3 position, Quaternion rotation) where T : Component
		{
			return null;
		}

		// Token: 0x0600258F RID: 9615 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600258F")]
		public static T Spawn<T>(T prefab, Vector3 position, Quaternion rotation) where T : Component
		{
			return null;
		}

		// Token: 0x06002590 RID: 9616 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002590")]
		public static T Spawn<T>(T prefab, Transform parent, Vector3 position) where T : Component
		{
			return null;
		}

		// Token: 0x06002591 RID: 9617 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002591")]
		public static T Spawn<T>(T prefab, Vector3 position) where T : Component
		{
			return null;
		}

		// Token: 0x06002592 RID: 9618 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002592")]
		public static T Spawn<T>(T prefab, Transform parent) where T : Component
		{
			return null;
		}

		// Token: 0x06002593 RID: 9619 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002593")]
		public static T Spawn<T>(T prefab) where T : Component
		{
			return null;
		}

		// Token: 0x06002594 RID: 9620 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002594")]
		[Address(RVA = "0x2B56830", Offset = "0x2B56830", VA = "0x2B56830")]
		public static GameObject Spawn(GameObject prefab, Transform parent, Vector3 position, Quaternion rotation)
		{
			return null;
		}

		// Token: 0x06002595 RID: 9621 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002595")]
		[Address(RVA = "0x2B56C94", Offset = "0x2B56C94", VA = "0x2B56C94")]
		public static GameObject Spawn(GameObject prefab, Transform parent, Vector3 position)
		{
			return null;
		}

		// Token: 0x06002596 RID: 9622 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002596")]
		[Address(RVA = "0x2B56D78", Offset = "0x2B56D78", VA = "0x2B56D78")]
		public static GameObject Spawn(GameObject prefab, Vector3 position, Quaternion rotation)
		{
			return null;
		}

		// Token: 0x06002597 RID: 9623 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002597")]
		[Address(RVA = "0x2B56E28", Offset = "0x2B56E28", VA = "0x2B56E28")]
		public static GameObject Spawn(GameObject prefab, Transform parent)
		{
			return null;
		}

		// Token: 0x06002598 RID: 9624 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002598")]
		[Address(RVA = "0x2B56F38", Offset = "0x2B56F38", VA = "0x2B56F38")]
		public static GameObject Spawn(GameObject prefab, Vector3 position)
		{
			return null;
		}

		// Token: 0x06002599 RID: 9625 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002599")]
		[Address(RVA = "0x2B57010", Offset = "0x2B57010", VA = "0x2B57010")]
		public static GameObject Spawn(GameObject prefab)
		{
			return null;
		}

		// Token: 0x0600259A RID: 9626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600259A")]
		public static void Recycle<T>(T obj) where T : Component
		{
		}

		// Token: 0x0600259B RID: 9627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600259B")]
		[Address(RVA = "0x2B57114", Offset = "0x2B57114", VA = "0x2B57114")]
		public static void Recycle(GameObject obj)
		{
		}

		// Token: 0x0600259C RID: 9628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600259C")]
		[Address(RVA = "0x2B57350", Offset = "0x2B57350", VA = "0x2B57350")]
		private static void Recycle(GameObject obj, GameObject prefab)
		{
		}

		// Token: 0x0600259D RID: 9629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600259D")]
		public static void RecycleAll<T>(T prefab) where T : Component
		{
		}

		// Token: 0x0600259E RID: 9630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600259E")]
		[Address(RVA = "0x2B57600", Offset = "0x2B57600", VA = "0x2B57600")]
		public static void RecycleAll(GameObject prefab)
		{
		}

		// Token: 0x0600259F RID: 9631 RVA: 0x0000E520 File Offset: 0x0000C720
		[Token(Token = "0x600259F")]
		[Address(RVA = "0x2B57978", Offset = "0x2B57978", VA = "0x2B57978")]
		public static bool IsSpawned(GameObject obj)
		{
			return default(bool);
		}

		// Token: 0x060025A0 RID: 9632 RVA: 0x0000E538 File Offset: 0x0000C738
		[Token(Token = "0x60025A0")]
		public static int CountPooled<T>(T prefab) where T : Component
		{
			return 0;
		}

		// Token: 0x060025A1 RID: 9633 RVA: 0x0000E550 File Offset: 0x0000C750
		[Token(Token = "0x60025A1")]
		[Address(RVA = "0x2B579EC", Offset = "0x2B579EC", VA = "0x2B579EC")]
		public static int CountPooled(GameObject prefab)
		{
			return 0;
		}

		// Token: 0x060025A2 RID: 9634 RVA: 0x0000E568 File Offset: 0x0000C768
		[Token(Token = "0x60025A2")]
		public static int CountSpawned<T>(T prefab) where T : Component
		{
			return 0;
		}

		// Token: 0x060025A3 RID: 9635 RVA: 0x0000E580 File Offset: 0x0000C780
		[Token(Token = "0x60025A3")]
		[Address(RVA = "0x2B57A98", Offset = "0x2B57A98", VA = "0x2B57A98")]
		public static int CountSpawned(GameObject prefab)
		{
			return 0;
		}

		// Token: 0x060025A4 RID: 9636 RVA: 0x0000E598 File Offset: 0x0000C798
		[Token(Token = "0x60025A4")]
		[Address(RVA = "0x2B57C58", Offset = "0x2B57C58", VA = "0x2B57C58")]
		public static int CountAllPooled()
		{
			return 0;
		}

		// Token: 0x060025A5 RID: 9637 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025A5")]
		[Address(RVA = "0x2B57DF0", Offset = "0x2B57DF0", VA = "0x2B57DF0")]
		public static List<GameObject> GetPooled(GameObject prefab, List<GameObject> list, bool appendList)
		{
			return null;
		}

		// Token: 0x060025A6 RID: 9638 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025A6")]
		public static List<T> GetPooled<T>(T prefab, List<T> list, bool appendList) where T : Component
		{
			return null;
		}

		// Token: 0x060025A7 RID: 9639 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025A7")]
		[Address(RVA = "0x2B57F34", Offset = "0x2B57F34", VA = "0x2B57F34")]
		public static List<GameObject> GetSpawned(GameObject prefab, List<GameObject> list, bool appendList)
		{
			return null;
		}

		// Token: 0x060025A8 RID: 9640 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025A8")]
		public static List<T> GetSpawned<T>(T prefab, List<T> list, bool appendList) where T : Component
		{
			return null;
		}

		// Token: 0x060025A9 RID: 9641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025A9")]
		[Address(RVA = "0x2B58218", Offset = "0x2B58218", VA = "0x2B58218")]
		public static void DestroyPooled(GameObject prefab)
		{
		}

		// Token: 0x060025AA RID: 9642 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025AA")]
		public static void DestroyPooled<T>(T prefab) where T : Component
		{
		}

		// Token: 0x060025AB RID: 9643 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025AB")]
		[Address(RVA = "0x2B58404", Offset = "0x2B58404", VA = "0x2B58404")]
		public static GameObject GetPrefab(GameObject obj)
		{
			return null;
		}

		// Token: 0x060025AC RID: 9644 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025AC")]
		public static GameObject GetPrefab<T>(T obj) where T : Component
		{
			return null;
		}

		// Token: 0x060025AD RID: 9645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025AD")]
		[Address(RVA = "0x2B58498", Offset = "0x2B58498", VA = "0x2B58498")]
		public GameObjectPool()
		{
		}

		// Token: 0x0400226D RID: 8813
		[Token(Token = "0x400226D")]
		[FieldOffset(Offset = "0x0")]
		private static List<GameObject> tempList;

		// Token: 0x0400226E RID: 8814
		[Token(Token = "0x400226E")]
		[FieldOffset(Offset = "0x20")]
		private readonly Dictionary<GameObject, List<GameObject>> pooledObjects;

		// Token: 0x0400226F RID: 8815
		[Token(Token = "0x400226F")]
		[FieldOffset(Offset = "0x28")]
		private readonly Dictionary<GameObject, GameObject> spawnedObjects;

		// Token: 0x04002270 RID: 8816
		[Token(Token = "0x4002270")]
		[FieldOffset(Offset = "0x30")]
		private readonly Dictionary<GameObject, float> pooledTimeStamps;

		// Token: 0x04002271 RID: 8817
		[Token(Token = "0x4002271")]
		[FieldOffset(Offset = "0x38")]
		private bool startupPoolsCreated;

		// Token: 0x04002273 RID: 8819
		[Token(Token = "0x4002273")]
		[FieldOffset(Offset = "0x40")]
		private ITimer checkTimer;
	}
}
