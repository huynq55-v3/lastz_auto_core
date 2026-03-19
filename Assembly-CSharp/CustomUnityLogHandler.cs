using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001BF RID: 447
[Token(Token = "0x20001BF")]
public class CustomUnityLogHandler : ILogHandler
{
	// Token: 0x06000B66 RID: 2918 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B66")]
	[Address(RVA = "0x3727784", Offset = "0x3727784", VA = "0x3727784")]
	public CustomUnityLogHandler()
	{
	}

	// Token: 0x06000B67 RID: 2919 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B67")]
	[Address(RVA = "0x372778C", Offset = "0x372778C", VA = "0x372778C", Slot = "4")]
	[HideInCallstack]
	public void LogFormat(LogType logType, Object context, string format, params object[] args)
	{
	}

	// Token: 0x06000B68 RID: 2920 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B68")]
	[Address(RVA = "0x3727884", Offset = "0x3727884", VA = "0x3727884", Slot = "5")]
	[HideInCallstack]
	public void LogException(Exception exception, Object context)
	{
	}

	// Token: 0x04000FDB RID: 4059
	[Token(Token = "0x4000FDB")]
	[FieldOffset(Offset = "0x0")]
	private static ILogHandler m_DefaultLogHandler;
}
