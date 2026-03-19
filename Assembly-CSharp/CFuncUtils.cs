using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using AOT;
using Il2CppDummyDll;

// Token: 0x02000385 RID: 901
[Token(Token = "0x2000385")]
public class CFuncUtils
{
	// Token: 0x060016F4 RID: 5876
	[Token(Token = "0x60016F4")]
	[Address(RVA = "0x1DB010C", Offset = "0x1DB010C", VA = "0x1DB010C")]
	[PreserveSig]
	public static extern void InitProfileDelegate(CFuncUtils.BeginSample begin, CFuncUtils.EndSample end);

	// Token: 0x060016F5 RID: 5877
	[Token(Token = "0x60016F5")]
	[Address(RVA = "0x1DB01A4", Offset = "0x1DB01A4", VA = "0x1DB01A4")]
	[PreserveSig]
	public static extern long WriteBufferToFile(string filename, IntPtr buff, long size);

	// Token: 0x060016F6 RID: 5878 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60016F6")]
	[Address(RVA = "0x1DB0250", Offset = "0x1DB0250", VA = "0x1DB0250")]
	public static void InitUnityProfile_xLuaDll()
	{
	}

	// Token: 0x060016F7 RID: 5879 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60016F7")]
	[Address(RVA = "0x1DAFFDC", Offset = "0x1DAFFDC", VA = "0x1DAFFDC")]
	[MonoPInvokeCallback(typeof(CFuncUtils.BeginSample))]
	public static void Unity_BeginSample(IntPtr pointer)
	{
	}

	// Token: 0x060016F8 RID: 5880 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60016F8")]
	[Address(RVA = "0x1DB0108", Offset = "0x1DB0108", VA = "0x1DB0108")]
	[MonoPInvokeCallback(typeof(CFuncUtils.EndSample))]
	public static void Unity_EndProfile()
	{
	}

	// Token: 0x060016F9 RID: 5881 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60016F9")]
	[Address(RVA = "0x1DB04D0", Offset = "0x1DB04D0", VA = "0x1DB04D0")]
	public CFuncUtils()
	{
	}

	// Token: 0x04001A01 RID: 6657
	[Token(Token = "0x4001A01")]
	private const string LUADLL = "xlua";

	// Token: 0x04001A02 RID: 6658
	[Token(Token = "0x4001A02")]
	[FieldOffset(Offset = "0x0")]
	private static readonly Dictionary<long, string> _showNames;

	// Token: 0x02000386 RID: 902
	// (Invoke) Token: 0x060016FC RID: 5884
	[Token(Token = "0x2000386")]
	public delegate void BeginSample(IntPtr pointer);

	// Token: 0x02000387 RID: 903
	// (Invoke) Token: 0x06001700 RID: 5888
	[Token(Token = "0x2000387")]
	public delegate void EndSample();
}
