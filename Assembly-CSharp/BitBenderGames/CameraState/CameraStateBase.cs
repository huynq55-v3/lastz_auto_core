using System;
using Il2CppDummyDll;

namespace BitBenderGames.CameraState
{
	// Token: 0x02000AC4 RID: 2756
	[Token(Token = "0x2000AC4")]
	public abstract class CameraStateBase
	{
		// Token: 0x060068CE RID: 26830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068CE")]
		[Address(RVA = "0x33D2480", Offset = "0x33D2480", VA = "0x33D2480")]
		public CameraStateBase(MobileTouchCamera touchCamera)
		{
		}

		// Token: 0x060068CF RID: 26831
		[Token(Token = "0x60068CF")]
		public abstract void OnEnter();

		// Token: 0x060068D0 RID: 26832
		[Token(Token = "0x60068D0")]
		public abstract void OnUpdate();

		// Token: 0x060068D1 RID: 26833
		[Token(Token = "0x60068D1")]
		public abstract void OnLeave();

		// Token: 0x04002A21 RID: 10785
		[Token(Token = "0x4002A21")]
		[FieldOffset(Offset = "0x10")]
		protected MobileTouchCamera _touchCamera;
	}
}
