using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace LW.CountBattle
{
	// Token: 0x020003DD RID: 989
	[Token(Token = "0x20003DD")]
	public class SteerDisplay
	{
		// Token: 0x17000256 RID: 598
		// (get) Token: 0x060018FC RID: 6396 RVA: 0x000098E8 File Offset: 0x00007AE8
		[Token(Token = "0x17000256")]
		public Vector3 Position
		{
			[Token(Token = "0x60018FC")]
			[Address(RVA = "0x2025FE4", Offset = "0x2025FE4", VA = "0x2025FE4")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x060018FD RID: 6397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018FD")]
		[Address(RVA = "0x2025FF0", Offset = "0x2025FF0", VA = "0x2025FF0")]
		public SteerDisplay(Vector3 pos0, float firstTickTimeFix = 0f)
		{
		}

		// Token: 0x060018FE RID: 6398 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018FE")]
		[Address(RVA = "0x2026148", Offset = "0x2026148", VA = "0x2026148")]
		public void Push(Vector3 position, float timestamp)
		{
		}

		// Token: 0x060018FF RID: 6399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018FF")]
		[Address(RVA = "0x2026230", Offset = "0x2026230", VA = "0x2026230")]
		public void Update(float dt)
		{
		}

		// Token: 0x04001B62 RID: 7010
		[Token(Token = "0x4001B62")]
		[FieldOffset(Offset = "0x0")]
		public static int AUTO_INC_ID;

		// Token: 0x04001B63 RID: 7011
		[Token(Token = "0x4001B63")]
		[FieldOffset(Offset = "0x4")]
		public static int DELAY_TICKS;

		// Token: 0x04001B64 RID: 7012
		[Token(Token = "0x4001B64")]
		[FieldOffset(Offset = "0x10")]
		private List<SteerDisplay.SyncState> _buffer;

		// Token: 0x04001B65 RID: 7013
		[Token(Token = "0x4001B65")]
		[FieldOffset(Offset = "0x18")]
		private float _syncTimer;

		// Token: 0x04001B66 RID: 7014
		[Token(Token = "0x4001B66")]
		[FieldOffset(Offset = "0x1C")]
		private float _firstTickTimeFix;

		// Token: 0x04001B67 RID: 7015
		[Token(Token = "0x4001B67")]
		[FieldOffset(Offset = "0x20")]
		private int _id;

		// Token: 0x04001B68 RID: 7016
		[Token(Token = "0x4001B68")]
		[FieldOffset(Offset = "0x24")]
		private Vector3 _position;

		// Token: 0x020003DE RID: 990
		[Token(Token = "0x20003DE")]
		private struct SyncState
		{
			// Token: 0x06001901 RID: 6401 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001901")]
			[Address(RVA = "0x2026224", Offset = "0x2026224", VA = "0x2026224")]
			public SyncState(Vector3 position, float timestamp)
			{
			}

			// Token: 0x04001B69 RID: 7017
			[Token(Token = "0x4001B69")]
			[FieldOffset(Offset = "0x0")]
			public Vector3 position;

			// Token: 0x04001B6A RID: 7018
			[Token(Token = "0x4001B6A")]
			[FieldOffset(Offset = "0xC")]
			public float timestamp;
		}
	}
}
