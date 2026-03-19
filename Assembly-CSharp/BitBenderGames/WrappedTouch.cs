using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace BitBenderGames
{
	// Token: 0x02000AC3 RID: 2755
	[Token(Token = "0x2000AC3")]
	public class WrappedTouch
	{
		// Token: 0x17000754 RID: 1876
		// (get) Token: 0x060068C8 RID: 26824 RVA: 0x0004CFE0 File Offset: 0x0004B1E0
		// (set) Token: 0x060068C9 RID: 26825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000754")]
		public Vector3 Position
		{
			[Token(Token = "0x60068C8")]
			[Address(RVA = "0x33D2438", Offset = "0x33D2438", VA = "0x33D2438")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60068C9")]
			[Address(RVA = "0x33D2444", Offset = "0x33D2444", VA = "0x33D2444")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000755 RID: 1877
		// (get) Token: 0x060068CA RID: 26826 RVA: 0x0004CFF8 File Offset: 0x0004B1F8
		// (set) Token: 0x060068CB RID: 26827 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000755")]
		public int FingerId
		{
			[Token(Token = "0x60068CA")]
			[Address(RVA = "0x33D2450", Offset = "0x33D2450", VA = "0x33D2450")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60068CB")]
			[Address(RVA = "0x33D2458", Offset = "0x33D2458", VA = "0x33D2458")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060068CC RID: 26828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068CC")]
		[Address(RVA = "0x33D2460", Offset = "0x33D2460", VA = "0x33D2460")]
		public WrappedTouch()
		{
		}

		// Token: 0x060068CD RID: 26829 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60068CD")]
		[Address(RVA = "0x33D1F88", Offset = "0x33D1F88", VA = "0x33D1F88")]
		public static WrappedTouch FromTouch(Touch touch)
		{
			return null;
		}
	}
}
