using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace BitBenderGames
{
	// Token: 0x02000ABC RID: 2748
	[Token(Token = "0x2000ABC")]
	public class TouchWrapper
	{
		// Token: 0x1700074F RID: 1871
		// (get) Token: 0x060068BA RID: 26810 RVA: 0x0004CF80 File Offset: 0x0004B180
		[Token(Token = "0x1700074F")]
		public static int TouchCount
		{
			[Token(Token = "0x60068BA")]
			[Address(RVA = "0x33CC790", Offset = "0x33CC790", VA = "0x33CC790")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000750 RID: 1872
		// (get) Token: 0x060068BB RID: 26811 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000750")]
		public static WrappedTouch Touch0
		{
			[Token(Token = "0x60068BB")]
			[Address(RVA = "0x33D0928", Offset = "0x33D0928", VA = "0x33D0928")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000751 RID: 1873
		// (get) Token: 0x060068BC RID: 26812 RVA: 0x0004CF98 File Offset: 0x0004B198
		[Token(Token = "0x17000751")]
		public static bool IsFingerDown
		{
			[Token(Token = "0x60068BC")]
			[Address(RVA = "0x33CFAF4", Offset = "0x33CFAF4", VA = "0x33CFAF4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000752 RID: 1874
		// (get) Token: 0x060068BD RID: 26813 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000752")]
		public static List<WrappedTouch> Touches
		{
			[Token(Token = "0x60068BD")]
			[Address(RVA = "0x33CC798", Offset = "0x33CC798", VA = "0x33CC798")]
			get
			{
				return null;
			}
		}

		// Token: 0x060068BE RID: 26814 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60068BE")]
		[Address(RVA = "0x33D2014", Offset = "0x33D2014", VA = "0x33D2014")]
		private static List<WrappedTouch> GetTouchesFromInputTouches()
		{
			return null;
		}

		// Token: 0x17000753 RID: 1875
		// (get) Token: 0x060068BF RID: 26815 RVA: 0x0004CFB0 File Offset: 0x0004B1B0
		[Token(Token = "0x17000753")]
		public static Vector2 AverageTouchPos
		{
			[Token(Token = "0x60068BF")]
			[Address(RVA = "0x33D0BD0", Offset = "0x33D0BD0", VA = "0x33D0BD0")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x060068C0 RID: 26816 RVA: 0x0004CFC8 File Offset: 0x0004B1C8
		[Token(Token = "0x60068C0")]
		[Address(RVA = "0x33D2164", Offset = "0x33D2164", VA = "0x33D2164")]
		private static Vector2 GetAverageTouchPosFromInputTouches()
		{
			return default(Vector2);
		}

		// Token: 0x060068C1 RID: 26817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068C1")]
		[Address(RVA = "0x33D2280", Offset = "0x33D2280", VA = "0x33D2280")]
		public TouchWrapper()
		{
		}
	}
}
