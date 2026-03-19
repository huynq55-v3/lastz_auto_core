using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200010A RID: 266
[Token(Token = "0x200010A")]
public class DynamicInfinityItem : MonoBehaviour
{
	// Token: 0x170000FB RID: 251
	// (get) Token: 0x06000784 RID: 1924 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000783 RID: 1923 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170000FB")]
	public DynamicRect DRect
	{
		[Token(Token = "0x6000784")]
		[Address(RVA = "0x34797C4", Offset = "0x34797C4", VA = "0x34797C4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000783")]
		[Address(RVA = "0x3479780", Offset = "0x3479780", VA = "0x3479780")]
		set
		{
		}
	}

	// Token: 0x06000785 RID: 1925 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000785")]
	[Address(RVA = "0x34797CC", Offset = "0x34797CC", VA = "0x34797CC")]
	private void Start()
	{
	}

	// Token: 0x06000786 RID: 1926 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000786")]
	[Address(RVA = "0x34797D0", Offset = "0x34797D0", VA = "0x34797D0")]
	public void SetData(object data)
	{
	}

	// Token: 0x06000787 RID: 1927 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000787")]
	[Address(RVA = "0x3479828", Offset = "0x3479828", VA = "0x3479828", Slot = "4")]
	protected virtual void OnRenderer()
	{
	}

	// Token: 0x06000788 RID: 1928 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000788")]
	[Address(RVA = "0x347982C", Offset = "0x347982C", VA = "0x347982C")]
	public object GetData()
	{
		return null;
	}

	// Token: 0x06000789 RID: 1929 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000789")]
	public T GetData<T>()
	{
		return null;
	}

	// Token: 0x0600078A RID: 1930 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600078A")]
	[Address(RVA = "0x3479834", Offset = "0x3479834", VA = "0x3479834")]
	public DynamicInfinityItem()
	{
	}

	// Token: 0x0400057E RID: 1406
	[Token(Token = "0x400057E")]
	[FieldOffset(Offset = "0x18")]
	public DynamicInfinityItem.OnSelect OnSelectHandler;

	// Token: 0x0400057F RID: 1407
	[Token(Token = "0x400057F")]
	[FieldOffset(Offset = "0x20")]
	public DynamicInfinityItem.OnUpdateData OnUpdateDataHandler;

	// Token: 0x04000580 RID: 1408
	[Token(Token = "0x4000580")]
	[FieldOffset(Offset = "0x28")]
	protected DynamicRect mDRect;

	// Token: 0x04000581 RID: 1409
	[Token(Token = "0x4000581")]
	[FieldOffset(Offset = "0x30")]
	protected object mData;

	// Token: 0x0200010B RID: 267
	// (Invoke) Token: 0x0600078C RID: 1932
	[Token(Token = "0x200010B")]
	public delegate void OnSelect(DynamicInfinityItem item);

	// Token: 0x0200010C RID: 268
	// (Invoke) Token: 0x06000790 RID: 1936
	[Token(Token = "0x200010C")]
	public delegate void OnUpdateData(DynamicInfinityItem item);
}
