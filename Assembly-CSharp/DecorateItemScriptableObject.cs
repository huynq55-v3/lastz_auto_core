using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200000E RID: 14
[Token(Token = "0x200000E")]
[Serializable]
public class DecorateItemScriptableObject
{
	// Token: 0x17000006 RID: 6
	// (get) Token: 0x0600001B RID: 27 RVA: 0x000020B8 File Offset: 0x000002B8
	// (set) Token: 0x0600001A RID: 26 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000006")]
	public bool Unlock
	{
		[Token(Token = "0x600001B")]
		[Address(RVA = "0x15DF274", Offset = "0x15DF274", VA = "0x15DF274")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600001A")]
		[Address(RVA = "0x15DF268", Offset = "0x15DF268", VA = "0x15DF268")]
		[CompilerGenerated]
		set
		{
		}
	}

	// Token: 0x17000007 RID: 7
	// (get) Token: 0x0600001D RID: 29 RVA: 0x000020D0 File Offset: 0x000002D0
	// (set) Token: 0x0600001C RID: 28 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000007")]
	public bool IsActive
	{
		[Token(Token = "0x600001D")]
		[Address(RVA = "0x15DF288", Offset = "0x15DF288", VA = "0x15DF288")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600001C")]
		[Address(RVA = "0x15DF27C", Offset = "0x15DF27C", VA = "0x15DF27C")]
		[CompilerGenerated]
		set
		{
		}
	}

	// Token: 0x0600001E RID: 30 RVA: 0x000020E8 File Offset: 0x000002E8
	[Token(Token = "0x600001E")]
	[Address(RVA = "0x15DF290", Offset = "0x15DF290", VA = "0x15DF290")]
	public int GetResId()
	{
		return 0;
	}

	// Token: 0x0600001F RID: 31 RVA: 0x00002100 File Offset: 0x00000300
	[Token(Token = "0x600001F")]
	[Address(RVA = "0x15DF2B8", Offset = "0x15DF2B8", VA = "0x15DF2B8")]
	public bool Renderable()
	{
		return default(bool);
	}

	// Token: 0x06000020 RID: 32 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000020")]
	[Address(RVA = "0x15DF2E4", Offset = "0x15DF2E4", VA = "0x15DF2E4")]
	public DecorateItemScriptableObject()
	{
	}

	// Token: 0x0400005C RID: 92
	[Token(Token = "0x400005C")]
	[FieldOffset(Offset = "0x10")]
	public int resId;

	// Token: 0x0400005D RID: 93
	[Token(Token = "0x400005D")]
	[FieldOffset(Offset = "0x14")]
	public int resId2;

	// Token: 0x0400005E RID: 94
	[Token(Token = "0x400005E")]
	[FieldOffset(Offset = "0x18")]
	public float minZoom;

	// Token: 0x0400005F RID: 95
	[Token(Token = "0x400005F")]
	[FieldOffset(Offset = "0x1C")]
	public float maxZoom;

	// Token: 0x04000060 RID: 96
	[Token(Token = "0x4000060")]
	[FieldOffset(Offset = "0x20")]
	public float boundRadius;

	// Token: 0x04000061 RID: 97
	[Token(Token = "0x4000061")]
	[FieldOffset(Offset = "0x24")]
	public Vector3 pos;

	// Token: 0x04000062 RID: 98
	[Token(Token = "0x4000062")]
	[FieldOffset(Offset = "0x30")]
	public Vector3 euler;

	// Token: 0x04000063 RID: 99
	[Token(Token = "0x4000063")]
	[FieldOffset(Offset = "0x3C")]
	public Vector3 scale;

	// Token: 0x04000064 RID: 100
	[Token(Token = "0x4000064")]
	[FieldOffset(Offset = "0x48")]
	public ItemRenderLayer renderLayer;
}
