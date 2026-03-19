using System;
using Il2CppDummyDll;

// Token: 0x02000298 RID: 664
[Token(Token = "0x2000298")]
public class ArrayT<T>
{
	// Token: 0x170001F8 RID: 504
	// (get) Token: 0x06001183 RID: 4483 RVA: 0x00006F78 File Offset: 0x00005178
	[Token(Token = "0x170001F8")]
	public int size
	{
		[Token(Token = "0x6001183")]
		get
		{
			return 0;
		}
	}

	// Token: 0x170001F9 RID: 505
	[Token(Token = "0x170001F9")]
	public T this[int index]
	{
		[Token(Token = "0x6001184")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001185")]
		set
		{
		}
	}

	// Token: 0x06001186 RID: 4486 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001186")]
	public ArrayT(int bufferIncrement)
	{
	}

	// Token: 0x06001187 RID: 4487 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001187")]
	private void AllocateMore()
	{
	}

	// Token: 0x06001188 RID: 4488 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001188")]
	public void Clear()
	{
	}

	// Token: 0x06001189 RID: 4489 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001189")]
	public void Release()
	{
	}

	// Token: 0x0600118A RID: 4490 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600118A")]
	public void Add(T item)
	{
	}

	// Token: 0x0600118B RID: 4491 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600118B")]
	public void AddRange(T[] items)
	{
	}

	// Token: 0x0600118C RID: 4492 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600118C")]
	public void RemoveAt(int index)
	{
	}

	// Token: 0x0600118D RID: 4493 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600118D")]
	public T Pop()
	{
		return null;
	}

	// Token: 0x0600118E RID: 4494 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600118E")]
	public T Peek()
	{
		return null;
	}

	// Token: 0x0400143C RID: 5180
	[Token(Token = "0x400143C")]
	[FieldOffset(Offset = "0x0")]
	public T[] m_buffer;

	// Token: 0x0400143D RID: 5181
	[Token(Token = "0x400143D")]
	[FieldOffset(Offset = "0x0")]
	private int m_size;

	// Token: 0x0400143E RID: 5182
	[Token(Token = "0x400143E")]
	[FieldOffset(Offset = "0x0")]
	private int bufferIncrement;
}
