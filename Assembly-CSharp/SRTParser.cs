using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000D9 RID: 217
[Token(Token = "0x20000D9")]
public class SRTParser
{
	// Token: 0x060005F3 RID: 1523 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005F3")]
	[Address(RVA = "0x2E77F78", Offset = "0x2E77F78", VA = "0x2E77F78")]
	public SRTParser(TextAsset textAsset)
	{
	}

	// Token: 0x060005F4 RID: 1524 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005F4")]
	[Address(RVA = "0x2E77FB0", Offset = "0x2E77FB0", VA = "0x2E77FB0")]
	public static List<SubtitleBlock> Load(TextAsset textAsset)
	{
		return null;
	}

	// Token: 0x060005F5 RID: 1525 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005F5")]
	[Address(RVA = "0x2E785E4", Offset = "0x2E785E4", VA = "0x2E785E4")]
	public SubtitleBlock GetForTime(float time)
	{
		return null;
	}

	// Token: 0x04000474 RID: 1140
	[Token(Token = "0x4000474")]
	[FieldOffset(Offset = "0x10")]
	private List<SubtitleBlock> _subtitles;

	// Token: 0x020000DA RID: 218
	[Token(Token = "0x20000DA")]
	private enum eReadState
	{
		// Token: 0x04000476 RID: 1142
		[Token(Token = "0x4000476")]
		Index,
		// Token: 0x04000477 RID: 1143
		[Token(Token = "0x4000477")]
		Time,
		// Token: 0x04000478 RID: 1144
		[Token(Token = "0x4000478")]
		Text
	}
}
