using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace GameKit.Base
{
	// Token: 0x020004DE RID: 1246
	[Token(Token = "0x20004DE")]
	public static class GameObjectPoolExtensions
	{
		// Token: 0x060025B0 RID: 9648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025B0")]
		public static void CreatePool<T>(this T prefab) where T : Component
		{
		}

		// Token: 0x060025B1 RID: 9649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025B1")]
		public static void CreatePool<T>(this T prefab, int initialPoolSize) where T : Component
		{
		}

		// Token: 0x060025B2 RID: 9650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025B2")]
		[Address(RVA = "0x2B586E4", Offset = "0x2B586E4", VA = "0x2B586E4")]
		public static void CreatePool(this GameObject prefab)
		{
		}

		// Token: 0x060025B3 RID: 9651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025B3")]
		[Address(RVA = "0x2B5873C", Offset = "0x2B5873C", VA = "0x2B5873C")]
		public static void CreatePool(this GameObject prefab, int initialPoolSize)
		{
		}

		// Token: 0x060025B4 RID: 9652 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025B4")]
		public static T Spawn<T>(this T prefab, Transform parent, Vector3 position, Quaternion rotation) where T : Component
		{
			return null;
		}

		// Token: 0x060025B5 RID: 9653 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025B5")]
		public static T Spawn<T>(this T prefab, Vector3 position, Quaternion rotation) where T : Component
		{
			return null;
		}

		// Token: 0x060025B6 RID: 9654 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025B6")]
		public static T Spawn<T>(this T prefab, Transform parent, Vector3 position) where T : Component
		{
			return null;
		}

		// Token: 0x060025B7 RID: 9655 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025B7")]
		public static T Spawn<T>(this T prefab, Vector3 position) where T : Component
		{
			return null;
		}

		// Token: 0x060025B8 RID: 9656 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025B8")]
		public static T Spawn<T>(this T prefab, Transform parent) where T : Component
		{
			return null;
		}

		// Token: 0x060025B9 RID: 9657 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025B9")]
		public static T Spawn<T>(this T prefab) where T : Component
		{
			return null;
		}

		// Token: 0x060025BA RID: 9658 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025BA")]
		[Address(RVA = "0x2B587A0", Offset = "0x2B587A0", VA = "0x2B587A0")]
		public static GameObject Spawn(this GameObject prefab, Transform parent, Vector3 position, Quaternion rotation)
		{
			return null;
		}

		// Token: 0x060025BB RID: 9659 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025BB")]
		[Address(RVA = "0x2B5885C", Offset = "0x2B5885C", VA = "0x2B5885C")]
		public static GameObject Spawn(this GameObject prefab, Vector3 position, Quaternion rotation)
		{
			return null;
		}

		// Token: 0x060025BC RID: 9660 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025BC")]
		[Address(RVA = "0x2B5890C", Offset = "0x2B5890C", VA = "0x2B5890C")]
		public static GameObject Spawn(this GameObject prefab, Transform parent, Vector3 position)
		{
			return null;
		}

		// Token: 0x060025BD RID: 9661 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025BD")]
		[Address(RVA = "0x2B589F0", Offset = "0x2B589F0", VA = "0x2B589F0")]
		public static GameObject Spawn(this GameObject prefab, Vector3 position)
		{
			return null;
		}

		// Token: 0x060025BE RID: 9662 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025BE")]
		[Address(RVA = "0x2B58AC8", Offset = "0x2B58AC8", VA = "0x2B58AC8")]
		public static GameObject Spawn(this GameObject prefab, Transform parent)
		{
			return null;
		}

		// Token: 0x060025BF RID: 9663 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025BF")]
		[Address(RVA = "0x2B58BD8", Offset = "0x2B58BD8", VA = "0x2B58BD8")]
		public static GameObject Spawn(this GameObject prefab)
		{
			return null;
		}

		// Token: 0x060025C0 RID: 9664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025C0")]
		public static void Recycle<T>(this T obj) where T : Component
		{
		}

		// Token: 0x060025C1 RID: 9665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025C1")]
		[Address(RVA = "0x2B58CDC", Offset = "0x2B58CDC", VA = "0x2B58CDC")]
		public static void Recycle(this GameObject obj)
		{
		}

		// Token: 0x060025C2 RID: 9666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025C2")]
		public static void RecycleAll<T>(this T prefab) where T : Component
		{
		}

		// Token: 0x060025C3 RID: 9667 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025C3")]
		[Address(RVA = "0x2B58D30", Offset = "0x2B58D30", VA = "0x2B58D30")]
		public static void RecycleAll(this GameObject prefab)
		{
		}

		// Token: 0x060025C4 RID: 9668 RVA: 0x0000E5B0 File Offset: 0x0000C7B0
		[Token(Token = "0x60025C4")]
		public static int CountPooled<T>(this T prefab) where T : Component
		{
			return 0;
		}

		// Token: 0x060025C5 RID: 9669 RVA: 0x0000E5C8 File Offset: 0x0000C7C8
		[Token(Token = "0x60025C5")]
		[Address(RVA = "0x2B58D84", Offset = "0x2B58D84", VA = "0x2B58D84")]
		public static int CountPooled(this GameObject prefab)
		{
			return 0;
		}

		// Token: 0x060025C6 RID: 9670 RVA: 0x0000E5E0 File Offset: 0x0000C7E0
		[Token(Token = "0x60025C6")]
		public static int CountSpawned<T>(this T prefab) where T : Component
		{
			return 0;
		}

		// Token: 0x060025C7 RID: 9671 RVA: 0x0000E5F8 File Offset: 0x0000C7F8
		[Token(Token = "0x60025C7")]
		[Address(RVA = "0x2B58DD8", Offset = "0x2B58DD8", VA = "0x2B58DD8")]
		public static int CountSpawned(this GameObject prefab)
		{
			return 0;
		}

		// Token: 0x060025C8 RID: 9672 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025C8")]
		[Address(RVA = "0x2B58E2C", Offset = "0x2B58E2C", VA = "0x2B58E2C")]
		public static List<GameObject> GetSpawned(this GameObject prefab, List<GameObject> list, bool appendList)
		{
			return null;
		}

		// Token: 0x060025C9 RID: 9673 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025C9")]
		[Address(RVA = "0x2B58E98", Offset = "0x2B58E98", VA = "0x2B58E98")]
		public static List<GameObject> GetSpawned(this GameObject prefab, List<GameObject> list)
		{
			return null;
		}

		// Token: 0x060025CA RID: 9674 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025CA")]
		[Address(RVA = "0x2B58F00", Offset = "0x2B58F00", VA = "0x2B58F00")]
		public static List<GameObject> GetSpawned(this GameObject prefab)
		{
			return null;
		}

		// Token: 0x060025CB RID: 9675 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025CB")]
		public static List<T> GetSpawned<T>(this T prefab, List<T> list, bool appendList) where T : Component
		{
			return null;
		}

		// Token: 0x060025CC RID: 9676 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025CC")]
		public static List<T> GetSpawned<T>(this T prefab, List<T> list) where T : Component
		{
			return null;
		}

		// Token: 0x060025CD RID: 9677 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025CD")]
		public static List<T> GetSpawned<T>(this T prefab) where T : Component
		{
			return null;
		}

		// Token: 0x060025CE RID: 9678 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025CE")]
		[Address(RVA = "0x2B58F5C", Offset = "0x2B58F5C", VA = "0x2B58F5C")]
		public static List<GameObject> GetPooled(this GameObject prefab, List<GameObject> list, bool appendList)
		{
			return null;
		}

		// Token: 0x060025CF RID: 9679 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025CF")]
		[Address(RVA = "0x2B58FC8", Offset = "0x2B58FC8", VA = "0x2B58FC8")]
		public static List<GameObject> GetPooled(this GameObject prefab, List<GameObject> list)
		{
			return null;
		}

		// Token: 0x060025D0 RID: 9680 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025D0")]
		[Address(RVA = "0x2B59030", Offset = "0x2B59030", VA = "0x2B59030")]
		public static List<GameObject> GetPooled(this GameObject prefab)
		{
			return null;
		}

		// Token: 0x060025D1 RID: 9681 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025D1")]
		public static List<T> GetPooled<T>(this T prefab, List<T> list, bool appendList) where T : Component
		{
			return null;
		}

		// Token: 0x060025D2 RID: 9682 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025D2")]
		public static List<T> GetPooled<T>(this T prefab, List<T> list) where T : Component
		{
			return null;
		}

		// Token: 0x060025D3 RID: 9683 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025D3")]
		public static List<T> GetPooled<T>(this T prefab) where T : Component
		{
			return null;
		}

		// Token: 0x060025D4 RID: 9684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025D4")]
		[Address(RVA = "0x2B5908C", Offset = "0x2B5908C", VA = "0x2B5908C")]
		public static void DestroyPooled(this GameObject prefab)
		{
		}

		// Token: 0x060025D5 RID: 9685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025D5")]
		public static void DestroyPooled<T>(this T prefab) where T : Component
		{
		}

		// Token: 0x060025D6 RID: 9686 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025D6")]
		[Address(RVA = "0x2B590E0", Offset = "0x2B590E0", VA = "0x2B590E0")]
		public static GameObject GetPrefab(this GameObject obj)
		{
			return null;
		}

		// Token: 0x060025D7 RID: 9687 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025D7")]
		public static GameObject GetPrefab<T>(this T obj) where T : Component
		{
			return null;
		}
	}
}
