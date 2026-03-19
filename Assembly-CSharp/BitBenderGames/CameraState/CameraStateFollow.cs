using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BitBenderGames.CameraState
{
	// Token: 0x02000AC6 RID: 2758
	[Token(Token = "0x2000AC6")]
	public class CameraStateFollow : CameraStateBase
	{
		// Token: 0x060068DC RID: 26844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068DC")]
		[Address(RVA = "0x33CAEA4", Offset = "0x33CAEA4", VA = "0x33CAEA4")]
		public CameraStateFollow(MobileTouchCamera touchCamera)
		{
		}

		// Token: 0x060068DD RID: 26845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068DD")]
		[Address(RVA = "0x33D2E9C", Offset = "0x33D2E9C", VA = "0x33D2E9C", Slot = "4")]
		public override void OnEnter()
		{
		}

		// Token: 0x060068DE RID: 26846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068DE")]
		[Address(RVA = "0x33CB9DC", Offset = "0x33CB9DC", VA = "0x33CB9DC")]
		public void Reset()
		{
		}

		// Token: 0x060068DF RID: 26847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068DF")]
		[Address(RVA = "0x33D2F04", Offset = "0x33D2F04", VA = "0x33D2F04", Slot = "5")]
		public override void OnUpdate()
		{
		}

		// Token: 0x060068E0 RID: 26848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068E0")]
		[Address(RVA = "0x33D30FC", Offset = "0x33D30FC", VA = "0x33D30FC", Slot = "6")]
		public override void OnLeave()
		{
		}

		// Token: 0x04002A34 RID: 10804
		[Token(Token = "0x4002A34")]
		[FieldOffset(Offset = "0x18")]
		public GameObject _leaderObj;

		// Token: 0x04002A35 RID: 10805
		[Token(Token = "0x4002A35")]
		[FieldOffset(Offset = "0x20")]
		public float _moveToLeaderTime;

		// Token: 0x04002A36 RID: 10806
		[Token(Token = "0x4002A36")]
		[FieldOffset(Offset = "0x24")]
		private float _animTime;
	}
}
