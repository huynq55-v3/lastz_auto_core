using System;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x02000095 RID: 149
[Token(Token = "0x2000095")]
public class QualityChangeRegistry
{
	// Token: 0x1700008E RID: 142
	// (get) Token: 0x06000384 RID: 900 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700008E")]
	public static QualityChangeRegistry Instance
	{
		[Token(Token = "0x6000384")]
		[Address(RVA = "0x3214F8C", Offset = "0x3214F8C", VA = "0x3214F8C")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000385 RID: 901 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000385")]
	[Address(RVA = "0x32150D8", Offset = "0x32150D8", VA = "0x32150D8")]
	public void Init()
	{
	}

	// Token: 0x06000386 RID: 902 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000386")]
	[Address(RVA = "0x32151C8", Offset = "0x32151C8", VA = "0x32151C8")]
	public void UnInit()
	{
	}

	// Token: 0x06000387 RID: 903 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000387")]
	[Address(RVA = "0x3215288", Offset = "0x3215288", VA = "0x3215288")]
	public void Register(QualityLimit listener)
	{
	}

	// Token: 0x06000388 RID: 904 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000388")]
	[Address(RVA = "0x32153B0", Offset = "0x32153B0", VA = "0x32153B0")]
	public void Unregister(QualityLimit listener)
	{
	}

	// Token: 0x06000389 RID: 905 RVA: 0x000030C0 File Offset: 0x000012C0
	[Token(Token = "0x6000389")]
	[Address(RVA = "0x321541C", Offset = "0x321541C", VA = "0x321541C")]
	public int GetLastGraphicLevel()
	{
		return 0;
	}

	// Token: 0x0600038A RID: 906 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600038A")]
	[Address(RVA = "0x3215424", Offset = "0x3215424", VA = "0x3215424")]
	private void OnQualityChange(object data)
	{
	}

	// Token: 0x0600038B RID: 907 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600038B")]
	[Address(RVA = "0x321500C", Offset = "0x321500C", VA = "0x321500C")]
	public QualityChangeRegistry()
	{
	}

	// Token: 0x0400030C RID: 780
	[Token(Token = "0x400030C")]
	[FieldOffset(Offset = "0x0")]
	private static QualityChangeRegistry _instance;

	// Token: 0x0400030D RID: 781
	[Token(Token = "0x400030D")]
	[FieldOffset(Offset = "0x10")]
	private readonly Dictionary<int, QualityLimit> _children;

	// Token: 0x0400030E RID: 782
	[Token(Token = "0x400030E")]
	[FieldOffset(Offset = "0x18")]
	private int _lastGraphicLevel;

	// Token: 0x0400030F RID: 783
	[Token(Token = "0x400030F")]
	[FieldOffset(Offset = "0x20")]
	private readonly Dictionary<int, QualityLimit> _tmpDict;
}
