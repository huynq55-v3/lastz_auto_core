using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000102 RID: 258
[Token(Token = "0x2000102")]
public class InfinityRect
{
	// Token: 0x170000F5 RID: 245
	// (get) Token: 0x06000753 RID: 1875 RVA: 0x00004620 File Offset: 0x00002820
	[Token(Token = "0x170000F5")]
	public int Index
	{
		[Token(Token = "0x6000753")]
		[Address(RVA = "0x34786B4", Offset = "0x34786B4", VA = "0x34786B4")]
		get
		{
			return 0;
		}
	}

	// Token: 0x170000F6 RID: 246
	// (get) Token: 0x06000755 RID: 1877 RVA: 0x00004638 File Offset: 0x00002838
	// (set) Token: 0x06000754 RID: 1876 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170000F6")]
	public float RectX
	{
		[Token(Token = "0x6000755")]
		[Address(RVA = "0x34786C8", Offset = "0x34786C8", VA = "0x34786C8")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6000754")]
		[Address(RVA = "0x34786BC", Offset = "0x34786BC", VA = "0x34786BC")]
		set
		{
		}
	}

	// Token: 0x170000F7 RID: 247
	// (get) Token: 0x06000757 RID: 1879 RVA: 0x00004650 File Offset: 0x00002850
	// (set) Token: 0x06000756 RID: 1878 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170000F7")]
	public float RectY
	{
		[Token(Token = "0x6000757")]
		[Address(RVA = "0x34786E0", Offset = "0x34786E0", VA = "0x34786E0")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6000756")]
		[Address(RVA = "0x34786D4", Offset = "0x34786D4", VA = "0x34786D4")]
		set
		{
		}
	}

	// Token: 0x170000F8 RID: 248
	// (get) Token: 0x06000759 RID: 1881 RVA: 0x00004668 File Offset: 0x00002868
	// (set) Token: 0x06000758 RID: 1880 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170000F8")]
	public float RectWidth
	{
		[Token(Token = "0x6000759")]
		[Address(RVA = "0x34786F8", Offset = "0x34786F8", VA = "0x34786F8")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6000758")]
		[Address(RVA = "0x34786EC", Offset = "0x34786EC", VA = "0x34786EC")]
		set
		{
		}
	}

	// Token: 0x170000F9 RID: 249
	// (get) Token: 0x0600075B RID: 1883 RVA: 0x00004680 File Offset: 0x00002880
	// (set) Token: 0x0600075A RID: 1882 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170000F9")]
	public float RectHeight
	{
		[Token(Token = "0x600075B")]
		[Address(RVA = "0x3478710", Offset = "0x3478710", VA = "0x3478710")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x600075A")]
		[Address(RVA = "0x3478704", Offset = "0x3478704", VA = "0x3478704")]
		set
		{
		}
	}

	// Token: 0x0600075C RID: 1884 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600075C")]
	[Address(RVA = "0x34757A4", Offset = "0x34757A4", VA = "0x34757A4")]
	public InfinityRect(float x, float y, float width, float height, int index)
	{
	}

	// Token: 0x0600075D RID: 1885 RVA: 0x00004698 File Offset: 0x00002898
	[Token(Token = "0x600075D")]
	[Address(RVA = "0x3477C38", Offset = "0x3477C38", VA = "0x3477C38")]
	public bool Overlaps(Rect otherRect)
	{
		return default(bool);
	}

	// Token: 0x0400056F RID: 1391
	[Token(Token = "0x400056F")]
	[FieldOffset(Offset = "0x10")]
	private Rect rect;

	// Token: 0x04000570 RID: 1392
	[Token(Token = "0x4000570")]
	[FieldOffset(Offset = "0x20")]
	private int index;
}
