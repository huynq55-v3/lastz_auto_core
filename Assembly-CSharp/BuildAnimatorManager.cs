using System;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x02000205 RID: 517
[Token(Token = "0x2000205")]
public class BuildAnimatorManager
{
	// Token: 0x06000DE6 RID: 3558 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DE6")]
	[Address(RVA = "0x121A5E0", Offset = "0x121A5E0", VA = "0x121A5E0")]
	public BuildAnimatorManager()
	{
	}

	// Token: 0x06000DE7 RID: 3559 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DE7")]
	[Address(RVA = "0x121A668", Offset = "0x121A668", VA = "0x121A668")]
	public void Shutdown()
	{
	}

	// Token: 0x06000DE8 RID: 3560 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DE8")]
	[Address(RVA = "0x121A6E4", Offset = "0x121A6E4", VA = "0x121A6E4")]
	public void AddOneBuild(int posIndex, long startTime = -1L, long endTime = -1L)
	{
	}

	// Token: 0x06000DE9 RID: 3561 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DE9")]
	[Address(RVA = "0x121A870", Offset = "0x121A870", VA = "0x121A870")]
	public void RemoveOneBuild(int posIndex)
	{
	}

	// Token: 0x06000DEA RID: 3562 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000DEA")]
	[Address(RVA = "0x121A900", Offset = "0x121A900", VA = "0x121A900")]
	public BuildAnimatorManager.BuildAnimatorParam GetBuildingParam(int posIndex)
	{
		return null;
	}

	// Token: 0x06000DEB RID: 3563 RVA: 0x00006408 File Offset: 0x00004608
	[Token(Token = "0x6000DEB")]
	[Address(RVA = "0x121A994", Offset = "0x121A994", VA = "0x121A994")]
	public bool IsBuilding(int posIndex)
	{
		return default(bool);
	}

	// Token: 0x04001149 RID: 4425
	[Token(Token = "0x4001149")]
	[FieldOffset(Offset = "0x10")]
	private Dictionary<int, BuildAnimatorManager.BuildAnimatorParam> _buildBuilding;

	// Token: 0x02000206 RID: 518
	[Token(Token = "0x2000206")]
	public class BuildAnimatorParam
	{
		// Token: 0x06000DEC RID: 3564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000DEC")]
		[Address(RVA = "0x121A868", Offset = "0x121A868", VA = "0x121A868")]
		public BuildAnimatorParam()
		{
		}

		// Token: 0x0400114A RID: 4426
		[Token(Token = "0x400114A")]
		[FieldOffset(Offset = "0x10")]
		public long startTime;

		// Token: 0x0400114B RID: 4427
		[Token(Token = "0x400114B")]
		[FieldOffset(Offset = "0x18")]
		public long endTime;

		// Token: 0x0400114C RID: 4428
		[Token(Token = "0x400114C")]
		[FieldOffset(Offset = "0x20")]
		public int posIndex;
	}
}
