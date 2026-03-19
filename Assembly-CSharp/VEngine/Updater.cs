using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace VEngine
{
	// Token: 0x020009F8 RID: 2552
	[Token(Token = "0x20009F8")]
	public sealed class Updater : MonoBehaviour
	{
		// Token: 0x17000630 RID: 1584
		// (get) Token: 0x0600618C RID: 24972 RVA: 0x0004B630 File Offset: 0x00049830
		// (set) Token: 0x0600618D RID: 24973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000630")]
		public static double time
		{
			[Token(Token = "0x600618C")]
			[Address(RVA = "0x1413424", Offset = "0x1413424", VA = "0x1413424")]
			[CompilerGenerated]
			get
			{
				return 0.0;
			}
			[Token(Token = "0x600618D")]
			[Address(RVA = "0x141347C", Offset = "0x141347C", VA = "0x141347C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000631 RID: 1585
		// (get) Token: 0x0600618E RID: 24974 RVA: 0x0004B648 File Offset: 0x00049848
		[Token(Token = "0x17000631")]
		public static bool busy
		{
			[Token(Token = "0x600618E")]
			[Address(RVA = "0x14010A4", Offset = "0x14010A4", VA = "0x14010A4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000632 RID: 1586
		// (get) Token: 0x0600618F RID: 24975 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006190 RID: 24976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000632")]
		public static Action onUpdate
		{
			[Token(Token = "0x600618F")]
			[Address(RVA = "0x14134E0", Offset = "0x14134E0", VA = "0x14134E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006190")]
			[Address(RVA = "0x1413538", Offset = "0x1413538", VA = "0x1413538")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06006191 RID: 24977 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006191")]
		[Address(RVA = "0x1413598", Offset = "0x1413598", VA = "0x1413598")]
		private void Awake()
		{
		}

		// Token: 0x06006192 RID: 24978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006192")]
		[Address(RVA = "0x14137B8", Offset = "0x14137B8", VA = "0x14137B8")]
		private void Update()
		{
		}

		// Token: 0x06006193 RID: 24979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006193")]
		[Address(RVA = "0x1413964", Offset = "0x1413964", VA = "0x1413964")]
		[RuntimeInitializeOnLoadMethod]
		private static void InitializeOnLoad()
		{
		}

		// Token: 0x06006194 RID: 24980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006194")]
		[Address(RVA = "0x14136AC", Offset = "0x14136AC", VA = "0x14136AC")]
		public static void AddUpdateCallback(Action callback)
		{
		}

		// Token: 0x06006195 RID: 24981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006195")]
		[Address(RVA = "0x1413A70", Offset = "0x1413A70", VA = "0x1413A70")]
		public static void RemoveUpdateCallback(Action callback)
		{
		}

		// Token: 0x06006196 RID: 24982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006196")]
		[Address(RVA = "0x1413B7C", Offset = "0x1413B7C", VA = "0x1413B7C")]
		public Updater()
		{
		}

		// Token: 0x040025F7 RID: 9719
		[Token(Token = "0x40025F7")]
		[FieldOffset(Offset = "0x0")]
		public static float maxUpdateTimeSlice;
	}
}
