using System;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x02000151 RID: 337
[Token(Token = "0x2000151")]
public static class ListHelper
{
	// Token: 0x060009D5 RID: 2517 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009D5")]
	public static void OrderBy<T, TKey>(List<T> list, SelectHandler<T, TKey> handler) where TKey : IComparable, IComparable<TKey>
	{
	}

	// Token: 0x060009D6 RID: 2518 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009D6")]
	public static void OrderByDescending<T, TKey>(List<T> list, SelectHandler<T, TKey> handler) where TKey : IComparable, IComparable<TKey>
	{
	}

	// Token: 0x060009D7 RID: 2519 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009D7")]
	public static List<T> RandomSortList<T>(List<T> ListT)
	{
		return null;
	}

	// Token: 0x060009D8 RID: 2520 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009D8")]
	public static T Min<T, TKey>(List<T> list, SelectHandler<T, TKey> handler) where TKey : IComparable, IComparable<TKey>
	{
		return null;
	}

	// Token: 0x060009D9 RID: 2521 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009D9")]
	public static T Max<T, TKey>(List<T> list, SelectHandler<T, TKey> handler) where TKey : IComparable, IComparable<TKey>
	{
		return null;
	}

	// Token: 0x060009DA RID: 2522 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009DA")]
	public static T Find<T>(List<T> list, FindHandler<T> handler)
	{
		return null;
	}

	// Token: 0x060009DB RID: 2523 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009DB")]
	public static List<T> FindAll<T>(List<T> list, FindHandler<T> handler)
	{
		return null;
	}

	// Token: 0x060009DC RID: 2524 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009DC")]
	public static Dictionary<TKey, List<T>> ToDictionary<TKey, T>(List<T> list, SelectHandler<T, TKey> handler)
	{
		return null;
	}

	// Token: 0x060009DD RID: 2525 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009DD")]
	public static List<T> GetRandomList<T>(List<T> list, int count = 1) where T : iRandomObject
	{
		return null;
	}

	// Token: 0x060009DE RID: 2526 RVA: 0x00005088 File Offset: 0x00003288
	[Token(Token = "0x60009DE")]
	[Address(RVA = "0x33B736C", Offset = "0x33B736C", VA = "0x33B736C")]
	public static int GetRandomSeed()
	{
		return 0;
	}

	// Token: 0x060009DF RID: 2527 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009DF")]
	public static T GetRandomItem<T>(List<T> list)
	{
		return null;
	}
}
