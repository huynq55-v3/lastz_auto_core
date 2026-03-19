using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace VEngine
{
	// Token: 0x020009EF RID: 2543
	[Token(Token = "0x20009EF")]
	public sealed class InstantiateObject : Operation
	{
		// Token: 0x17000624 RID: 1572
		// (get) Token: 0x06006156 RID: 24918 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006157 RID: 24919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000624")]
		public string path
		{
			[Token(Token = "0x6006156")]
			[Address(RVA = "0x1411478", Offset = "0x1411478", VA = "0x1411478")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006157")]
			[Address(RVA = "0x1411480", Offset = "0x1411480", VA = "0x1411480")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		// Token: 0x17000625 RID: 1573
		// (get) Token: 0x06006158 RID: 24920 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006159 RID: 24921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000625")]
		public GameObject result
		{
			[Token(Token = "0x6006158")]
			[Address(RVA = "0x1411488", Offset = "0x1411488", VA = "0x1411488")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006159")]
			[Address(RVA = "0x1411490", Offset = "0x1411490", VA = "0x1411490")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600615A RID: 24922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600615A")]
		[Address(RVA = "0x1411498", Offset = "0x1411498", VA = "0x1411498", Slot = "8")]
		public override void Start()
		{
		}

		// Token: 0x0600615B RID: 24923 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600615B")]
		[Address(RVA = "0x141161C", Offset = "0x141161C", VA = "0x141161C")]
		public static InstantiateObject InstantiateAsync(string assetPath)
		{
			return null;
		}

		// Token: 0x0600615C RID: 24924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600615C")]
		[Address(RVA = "0x14116F0", Offset = "0x14116F0", VA = "0x14116F0", Slot = "7")]
		protected override void Update()
		{
		}

		// Token: 0x0600615D RID: 24925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600615D")]
		[Address(RVA = "0x141187C", Offset = "0x141187C", VA = "0x141187C")]
		public void Destroy()
		{
		}

		// Token: 0x0600615E RID: 24926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600615E")]
		[Address(RVA = "0x14119BC", Offset = "0x14119BC", VA = "0x14119BC")]
		public static void UpdateObjects()
		{
		}

		// Token: 0x0600615F RID: 24927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600615F")]
		[Address(RVA = "0x1411698", Offset = "0x1411698", VA = "0x1411698")]
		public InstantiateObject()
		{
		}

		// Token: 0x040025D9 RID: 9689
		[Token(Token = "0x40025D9")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly List<InstantiateObject> AllObjects;

		// Token: 0x040025DA RID: 9690
		[Token(Token = "0x40025DA")]
		[FieldOffset(Offset = "0x30")]
		private Asset asset;
	}
}
