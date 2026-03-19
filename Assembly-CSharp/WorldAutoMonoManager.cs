using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002EC RID: 748
[Token(Token = "0x20002EC")]
public class WorldAutoMonoManager : WorldManagerBase
{
	// Token: 0x06001355 RID: 4949 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001355")]
	[Address(RVA = "0x1A4A1E8", Offset = "0x1A4A1E8", VA = "0x1A4A1E8")]
	public WorldAutoMonoManager(WorldScene scene)
	{
	}

	// Token: 0x06001356 RID: 4950 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001356")]
	[Address(RVA = "0x1A4A324", Offset = "0x1A4A324", VA = "0x1A4A324", Slot = "6")]
	public override void OnUpdate(float deltaTime)
	{
	}

	// Token: 0x06001357 RID: 4951 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001357")]
	[Address(RVA = "0x1A4A474", Offset = "0x1A4A474", VA = "0x1A4A474")]
	public void AddAutoFace(AutoFaceToCamera autoFace)
	{
	}

	// Token: 0x06001358 RID: 4952 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001358")]
	[Address(RVA = "0x1A4A4CC", Offset = "0x1A4A4CC", VA = "0x1A4A4CC")]
	public void RemoveAutoFace(AutoFaceToCamera autoFace)
	{
	}

	// Token: 0x06001359 RID: 4953 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001359")]
	[Address(RVA = "0x1A4A524", Offset = "0x1A4A524", VA = "0x1A4A524")]
	public void AddAutoScale(AutoAdjustScale autoScale)
	{
	}

	// Token: 0x0600135A RID: 4954 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600135A")]
	[Address(RVA = "0x1A4A57C", Offset = "0x1A4A57C", VA = "0x1A4A57C")]
	public void RemoveAutoScale(AutoAdjustScale autoScale)
	{
	}

	// Token: 0x0400164B RID: 5707
	[Token(Token = "0x400164B")]
	[FieldOffset(Offset = "0x18")]
	private HashSet<AutoFaceToCamera> autoFaceSet;

	// Token: 0x0400164C RID: 5708
	[Token(Token = "0x400164C")]
	[FieldOffset(Offset = "0x20")]
	private HashSet<AutoAdjustScale> autoScaleSet;

	// Token: 0x0400164D RID: 5709
	[Token(Token = "0x400164D")]
	[FieldOffset(Offset = "0x28")]
	private Camera mainCamera;
}
