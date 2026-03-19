using System;
using Il2CppDummyDll;

// Token: 0x02000150 RID: 336
[Token(Token = "0x2000150")]
public static class ArrayHelper
{
	// Token: 0x060009CD RID: 2509 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009CD")]
	public static void OrderBy<T, TKey>(T[] arr, SelectHandler<T, TKey> handler) where TKey : IComparable, IComparable<TKey>
	{
	}

	// Token: 0x060009CE RID: 2510 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009CE")]
	public static void OrderByDescending<T, TKey>(T[] arr, SelectHandler<T, TKey> handler) where TKey : IComparable, IComparable<TKey>
	{
	}

	// Token: 0x060009CF RID: 2511 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009CF")]
	public static T Min<T, TKey>(T[] arr, SelectHandler<T, TKey> handler) where TKey : IComparable, IComparable<TKey>
	{
		return null;
	}

	// Token: 0x060009D0 RID: 2512 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009D0")]
	public static T Max<T, TKey>(T[] arr, SelectHandler<T, TKey> handler) where TKey : IComparable, IComparable<TKey>
	{
		return null;
	}

	// Token: 0x060009D1 RID: 2513 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009D1")]
	public static TKey[] Select<T, TKey>(T[] arr, SelectHandler<T, TKey> handler)
	{
		return null;
	}

	// Token: 0x060009D2 RID: 2514 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009D2")]
	public static T Find<T>(T[] arr, FindHandler<T> handler)
	{
		return null;
	}

	// Token: 0x060009D3 RID: 2515 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009D3")]
	public static T[] FindAll<T>(T[] arr, FindHandler<T> handler)
	{
		return null;
	}

	// Token: 0x060009D4 RID: 2516 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009D4")]
	public static T[] Disrupted<T>(T[] arr)
	{
		return null;
	}
}
