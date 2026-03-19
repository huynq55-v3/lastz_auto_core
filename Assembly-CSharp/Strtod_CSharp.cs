using System;
using Il2CppDummyDll;

// Token: 0x0200017D RID: 381
[Token(Token = "0x200017D")]
public class Strtod_CSharp
{
	// Token: 0x06000AEC RID: 2796 RVA: 0x00005568 File Offset: 0x00003768
	[Token(Token = "0x6000AEC")]
	[Address(RVA = "0x3721884", Offset = "0x3721884", VA = "0x3721884")]
	public static char CH(ReadOnlySpan<char> buffer, int p)
	{
		return '\0';
	}

	// Token: 0x06000AED RID: 2797 RVA: 0x00005580 File Offset: 0x00003780
	[Token(Token = "0x6000AED")]
	[Address(RVA = "0x37218E8", Offset = "0x37218E8", VA = "0x37218E8")]
	public static double strtod(string str)
	{
		return 0.0;
	}

	// Token: 0x06000AEE RID: 2798 RVA: 0x00005598 File Offset: 0x00003798
	[Token(Token = "0x6000AEE")]
	[Address(RVA = "0x3721980", Offset = "0x3721980", VA = "0x3721980")]
	public static double strtod(ReadOnlySpan<char> str)
	{
		return 0.0;
	}

	// Token: 0x06000AEF RID: 2799 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AEF")]
	[Address(RVA = "0x3722044", Offset = "0x3722044", VA = "0x3722044")]
	public Strtod_CSharp()
	{
	}

	// Token: 0x040007C7 RID: 1991
	[Token(Token = "0x40007C7")]
	[FieldOffset(Offset = "0x0")]
	private static int maxExponent;

	// Token: 0x040007C8 RID: 1992
	[Token(Token = "0x40007C8")]
	[FieldOffset(Offset = "0x8")]
	private static double[] powersOf10;

	// Token: 0x040007C9 RID: 1993
	[Token(Token = "0x40007C9")]
	[FieldOffset(Offset = "0x10")]
	public static int errno;
}
