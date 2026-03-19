using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Coffee.UIParticleExtensions
{
	// Token: 0x02000A39 RID: 2617
	[Token(Token = "0x2000A39")]
	internal static class MeshHelper
	{
		// Token: 0x17000676 RID: 1654
		// (get) Token: 0x06006343 RID: 25411 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006344 RID: 25412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000676")]
		public static List<bool> activeMeshIndices
		{
			[Token(Token = "0x6006343")]
			[Address(RVA = "0x3041114", Offset = "0x3041114", VA = "0x3041114")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006344")]
			[Address(RVA = "0x304116C", Offset = "0x304116C", VA = "0x304116C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06006345 RID: 25413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006345")]
		[Address(RVA = "0x30411D4", Offset = "0x30411D4", VA = "0x30411D4")]
		public static void Init()
		{
		}

		// Token: 0x06006347 RID: 25415 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006347")]
		[Address(RVA = "0x304140C", Offset = "0x304140C", VA = "0x304140C")]
		private static CombineInstanceEx Get(int index, long hash)
		{
			return null;
		}

		// Token: 0x06006348 RID: 25416 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006348")]
		[Address(RVA = "0x3041670", Offset = "0x3041670", VA = "0x3041670")]
		public static Mesh GetTemporaryMesh()
		{
			return null;
		}

		// Token: 0x06006349 RID: 25417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006349")]
		[Address(RVA = "0x30416BC", Offset = "0x30416BC", VA = "0x30416BC")]
		public static void Push(int index, long hash, Mesh mesh, Matrix4x4 transform)
		{
		}

		// Token: 0x0600634A RID: 25418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600634A")]
		[Address(RVA = "0x304186C", Offset = "0x304186C", VA = "0x304186C")]
		public static void Clear()
		{
		}

		// Token: 0x0600634B RID: 25419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600634B")]
		[Address(RVA = "0x3041A34", Offset = "0x3041A34", VA = "0x3041A34")]
		public static void CombineMesh(Mesh result)
		{
		}

		// Token: 0x0600634C RID: 25420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600634C")]
		[Address(RVA = "0x3041818", Offset = "0x3041818", VA = "0x3041818")]
		public static void DiscardTemporaryMesh(Mesh mesh)
		{
		}

		// Token: 0x040027F9 RID: 10233
		[Token(Token = "0x40027F9")]
		[FieldOffset(Offset = "0x8")]
		private static readonly List<CombineInstanceEx> s_CachedInstance;

		// Token: 0x040027FA RID: 10234
		[Token(Token = "0x40027FA")]
		[FieldOffset(Offset = "0x10")]
		private static int count;
	}
}
