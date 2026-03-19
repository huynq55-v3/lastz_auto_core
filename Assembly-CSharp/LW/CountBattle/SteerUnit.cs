using System;
using Il2CppDummyDll;
using UnityEngine;

namespace LW.CountBattle
{
	// Token: 0x020003E2 RID: 994
	[Token(Token = "0x20003E2")]
	public class SteerUnit
	{
		// Token: 0x17000269 RID: 617
		// (get) Token: 0x0600193D RID: 6461 RVA: 0x00009AC8 File Offset: 0x00007CC8
		[Token(Token = "0x17000269")]
		public Vector2 pos
		{
			[Token(Token = "0x600193D")]
			[Address(RVA = "0x20D8534", Offset = "0x20D8534", VA = "0x20D8534")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x1700026A RID: 618
		// (get) Token: 0x0600193E RID: 6462 RVA: 0x00009AE0 File Offset: 0x00007CE0
		[Token(Token = "0x1700026A")]
		public float radius
		{
			[Token(Token = "0x600193E")]
			[Address(RVA = "0x20D8550", Offset = "0x20D8550", VA = "0x20D8550")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700026B RID: 619
		// (get) Token: 0x0600193F RID: 6463 RVA: 0x00009AF8 File Offset: 0x00007CF8
		[Token(Token = "0x1700026B")]
		public Vector3 DisplayPos
		{
			[Token(Token = "0x600193F")]
			[Address(RVA = "0x20D856C", Offset = "0x20D856C", VA = "0x20D856C")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x1700026C RID: 620
		// (get) Token: 0x06001940 RID: 6464 RVA: 0x00009B10 File Offset: 0x00007D10
		[Token(Token = "0x1700026C")]
		public bool IsDead
		{
			[Token(Token = "0x6001940")]
			[Address(RVA = "0x20D858C", Offset = "0x20D858C", VA = "0x20D858C")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06001941 RID: 6465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001941")]
		[Address(RVA = "0x20D8594", Offset = "0x20D8594", VA = "0x20D8594")]
		public SteerUnit(int id, Vector3 pos0, int point, float radius, float firstTickTimeFix)
		{
		}

		// Token: 0x06001942 RID: 6466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001942")]
		[Address(RVA = "0x20D86A8", Offset = "0x20D86A8", VA = "0x20D86A8")]
		public void Destroy()
		{
		}

		// Token: 0x06001943 RID: 6467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001943")]
		[Address(RVA = "0x20D86E0", Offset = "0x20D86E0", VA = "0x20D86E0")]
		public void SetPos(float x, float z)
		{
		}

		// Token: 0x06001944 RID: 6468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001944")]
		[Address(RVA = "0x20D86F0", Offset = "0x20D86F0", VA = "0x20D86F0")]
		public void Move(Vector2 vec)
		{
		}

		// Token: 0x06001945 RID: 6469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001945")]
		[Address(RVA = "0x20D870C", Offset = "0x20D870C", VA = "0x20D870C")]
		public void Kill()
		{
		}

		// Token: 0x06001946 RID: 6470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001946")]
		[Address(RVA = "0x20D8738", Offset = "0x20D8738", VA = "0x20D8738")]
		public void Tick(float dt, float y)
		{
		}

		// Token: 0x06001947 RID: 6471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001947")]
		[Address(RVA = "0x20D876C", Offset = "0x20D876C", VA = "0x20D876C")]
		public void Update(float dt)
		{
		}

		// Token: 0x06001948 RID: 6472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001948")]
		[Address(RVA = "0x20D8788", Offset = "0x20D8788", VA = "0x20D8788")]
		public void Sync(Transform transform)
		{
		}

		// Token: 0x04001B8E RID: 7054
		[Token(Token = "0x4001B8E")]
		[FieldOffset(Offset = "0x10")]
		public int id;

		// Token: 0x04001B8F RID: 7055
		[Token(Token = "0x4001B8F")]
		[FieldOffset(Offset = "0x14")]
		public int initPoint;

		// Token: 0x04001B90 RID: 7056
		[Token(Token = "0x4001B90")]
		[FieldOffset(Offset = "0x18")]
		public int point;

		// Token: 0x04001B91 RID: 7057
		[Token(Token = "0x4001B91")]
		[FieldOffset(Offset = "0x20")]
		public Circle shape;

		// Token: 0x04001B92 RID: 7058
		[Token(Token = "0x4001B92")]
		[FieldOffset(Offset = "0x28")]
		public Vector2 velocity;

		// Token: 0x04001B93 RID: 7059
		[Token(Token = "0x4001B93")]
		[FieldOffset(Offset = "0x30")]
		public float sqrMag2Center;

		// Token: 0x04001B94 RID: 7060
		[Token(Token = "0x4001B94")]
		[FieldOffset(Offset = "0x34")]
		private bool _isDead;

		// Token: 0x04001B95 RID: 7061
		[Token(Token = "0x4001B95")]
		[FieldOffset(Offset = "0x38")]
		private float _tickTimer;

		// Token: 0x04001B96 RID: 7062
		[Token(Token = "0x4001B96")]
		[FieldOffset(Offset = "0x40")]
		private SteerDisplay _display;

		// Token: 0x04001B97 RID: 7063
		[Token(Token = "0x4001B97")]
		[FieldOffset(Offset = "0x48")]
		public Action OnDead;
	}
}
