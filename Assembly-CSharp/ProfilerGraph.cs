using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000200 RID: 512
[Token(Token = "0x2000200")]
public class ProfilerGraph
{
	// Token: 0x06000DCA RID: 3530 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000DCA")]
	[Address(RVA = "0x1218A98", Offset = "0x1218A98", VA = "0x1218A98")]
	public static ProfilerGraph GetInstance()
	{
		return null;
	}

	// Token: 0x06000DCB RID: 3531 RVA: 0x00006300 File Offset: 0x00004500
	[Token(Token = "0x6000DCB")]
	[Address(RVA = "0x1218B24", Offset = "0x1218B24", VA = "0x1218B24")]
	public bool IsGraphVisible()
	{
		return default(bool);
	}

	// Token: 0x06000DCC RID: 3532 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DCC")]
	[Address(RVA = "0x1218B34", Offset = "0x1218B34", VA = "0x1218B34")]
	public void ToggleGraph()
	{
	}

	// Token: 0x06000DCD RID: 3533 RVA: 0x00006318 File Offset: 0x00004518
	[Token(Token = "0x6000DCD")]
	[Address(RVA = "0x1218D78", Offset = "0x1218D78", VA = "0x1218D78")]
	public bool IsConsoleVisible()
	{
		return default(bool);
	}

	// Token: 0x06000DCE RID: 3534 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DCE")]
	[Address(RVA = "0x1218D88", Offset = "0x1218D88", VA = "0x1218D88")]
	public void ToggleConsole()
	{
	}

	// Token: 0x06000DCF RID: 3535 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DCF")]
	[Address(RVA = "0x1218B1C", Offset = "0x1218B1C", VA = "0x1218B1C")]
	public ProfilerGraph()
	{
	}

	// Token: 0x0400113D RID: 4413
	[Token(Token = "0x400113D")]
	[FieldOffset(Offset = "0x10")]
	private InstanceRequest _graphRequest;

	// Token: 0x0400113E RID: 4414
	[Token(Token = "0x400113E")]
	[FieldOffset(Offset = "0x0")]
	private static ProfilerGraph _instance;

	// Token: 0x0400113F RID: 4415
	[Token(Token = "0x400113F")]
	[FieldOffset(Offset = "0x18")]
	private GameObject _gfxBg;

	// Token: 0x04001140 RID: 4416
	[Token(Token = "0x4001140")]
	[FieldOffset(Offset = "0x20")]
	private InstanceRequest gfxConsoleRequest;
}
