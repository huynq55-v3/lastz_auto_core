using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000163 RID: 355
[Token(Token = "0x2000163")]
public class CrashHandlerBootstrap : MonoBehaviour
{
	// Token: 0x06000A4C RID: 2636 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A4C")]
	[Address(RVA = "0x3712D8C", Offset = "0x3712D8C", VA = "0x3712D8C")]
	private void Awake()
	{
	}

	// Token: 0x06000A4D RID: 2637 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A4D")]
	[Address(RVA = "0x3713060", Offset = "0x3713060", VA = "0x3713060")]
	private void CheckCrashLog()
	{
	}

	// Token: 0x06000A4E RID: 2638 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A4E")]
	[Address(RVA = "0x3713064", Offset = "0x3713064", VA = "0x3713064")]
	private void OnDestroy()
	{
	}

	// Token: 0x06000A4F RID: 2639 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A4F")]
	[Address(RVA = "0x37130C8", Offset = "0x37130C8", VA = "0x37130C8")]
	public CrashHandlerBootstrap()
	{
	}

	// Token: 0x04000778 RID: 1912
	[Token(Token = "0x4000778")]
	[FieldOffset(Offset = "0x18")]
	[Tooltip("If set, minidump files will be written here (e.g. use Application.persistentDataPath).")]
	[SerializeField]
	private bool usePersistentDataPath;

	// Token: 0x04000779 RID: 1913
	[Token(Token = "0x4000779")]
	[FieldOffset(Offset = "0x19")]
	[SerializeField]
	[Tooltip("When true, crash.dmp is written on crash (if dump path is set). When false, no minidump.")]
	private bool writeMinidump;

	// Token: 0x0400077A RID: 1914
	[Token(Token = "0x400077A")]
	[FieldOffset(Offset = "0x1A")]
	[Tooltip("If set, native log messages (e.g. 'Crash handler installed') will appear in Unity Editor Console.")]
	[SerializeField]
	private bool logToUnityConsole;

	// Token: 0x0400077B RID: 1915
	[Token(Token = "0x400077B")]
	[FieldOffset(Offset = "0x1B")]
	[SerializeField]
	[Tooltip("Optional: crash callback is invoked! you can restart the game or/and log crash message (minidump path is also passed).")]
	private bool onCrashCallback;
}
