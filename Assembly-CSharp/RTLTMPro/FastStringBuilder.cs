using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace RTLTMPro
{
	// Token: 0x02000CC6 RID: 3270
	[Token(Token = "0x2000CC6")]
	public class FastStringBuilder
	{
		// Token: 0x17000B2D RID: 2861
		// (get) Token: 0x06007B7A RID: 31610 RVA: 0x000543A8 File Offset: 0x000525A8
		// (set) Token: 0x06007B7B RID: 31611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B2D")]
		public int Length
		{
			[Token(Token = "0x6007B7A")]
			[Address(RVA = "0x3229570", Offset = "0x3229570", VA = "0x3229570")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6007B7B")]
			[Address(RVA = "0x3229578", Offset = "0x3229578", VA = "0x3229578")]
			set
			{
			}
		}

		// Token: 0x06007B7C RID: 31612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B7C")]
		[Address(RVA = "0x322958C", Offset = "0x322958C", VA = "0x322958C")]
		public FastStringBuilder(int capacity)
		{
		}

		// Token: 0x06007B7D RID: 31613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B7D")]
		[Address(RVA = "0x3229648", Offset = "0x3229648", VA = "0x3229648")]
		public FastStringBuilder(string text)
		{
		}

		// Token: 0x06007B7E RID: 31614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B7E")]
		[Address(RVA = "0x322967C", Offset = "0x322967C", VA = "0x322967C")]
		public FastStringBuilder(string text, int capacity)
		{
		}

		// Token: 0x06007B7F RID: 31615 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007B7F")]
		[Address(RVA = "0x3229794", Offset = "0x3229794", VA = "0x3229794")]
		public static implicit operator string(FastStringBuilder x)
		{
			return null;
		}

		// Token: 0x06007B80 RID: 31616 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007B80")]
		[Address(RVA = "0x32297B0", Offset = "0x32297B0", VA = "0x32297B0")]
		public static implicit operator FastStringBuilder(string x)
		{
			return null;
		}

		// Token: 0x06007B81 RID: 31617 RVA: 0x000543C0 File Offset: 0x000525C0
		[Token(Token = "0x6007B81")]
		[Address(RVA = "0x3229810", Offset = "0x3229810", VA = "0x3229810")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public int Get(int index)
		{
			return 0;
		}

		// Token: 0x06007B82 RID: 31618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B82")]
		[Address(RVA = "0x3229840", Offset = "0x3229840", VA = "0x3229840")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void Set(int index, int ch)
		{
		}

		// Token: 0x06007B83 RID: 31619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B83")]
		[Address(RVA = "0x32296A8", Offset = "0x32296A8", VA = "0x32296A8")]
		public void SetValue(string text)
		{
		}

		// Token: 0x06007B84 RID: 31620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B84")]
		[Address(RVA = "0x3229930", Offset = "0x3229930", VA = "0x3229930")]
		public void SetValue(FastStringBuilder other)
		{
		}

		// Token: 0x06007B85 RID: 31621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B85")]
		[Address(RVA = "0x32299D8", Offset = "0x32299D8", VA = "0x32299D8")]
		public void Append(int ch)
		{
		}

		// Token: 0x06007B86 RID: 31622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B86")]
		[Address(RVA = "0x3229A44", Offset = "0x3229A44", VA = "0x3229A44")]
		public void Append(char ch)
		{
		}

		// Token: 0x06007B87 RID: 31623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B87")]
		[Address(RVA = "0x3229AB4", Offset = "0x3229AB4", VA = "0x3229AB4")]
		public void Insert(int pos, FastStringBuilder str, int offset, int count)
		{
		}

		// Token: 0x06007B88 RID: 31624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B88")]
		[Address(RVA = "0x3229C18", Offset = "0x3229C18", VA = "0x3229C18")]
		public void Insert(int pos, FastStringBuilder str)
		{
		}

		// Token: 0x06007B89 RID: 31625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B89")]
		[Address(RVA = "0x3229C34", Offset = "0x3229C34", VA = "0x3229C34")]
		public void Insert(int pos, int ch)
		{
		}

		// Token: 0x06007B8A RID: 31626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B8A")]
		[Address(RVA = "0x3229CD4", Offset = "0x3229CD4", VA = "0x3229CD4")]
		public void RemoveAll(int character)
		{
		}

		// Token: 0x06007B8B RID: 31627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B8B")]
		[Address(RVA = "0x3229D54", Offset = "0x3229D54", VA = "0x3229D54")]
		public void Remove(int start, int length)
		{
		}

		// Token: 0x06007B8C RID: 31628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B8C")]
		[Address(RVA = "0x3229DC4", Offset = "0x3229DC4", VA = "0x3229DC4")]
		public void Reverse(int startIndex, int length)
		{
		}

		// Token: 0x06007B8D RID: 31629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B8D")]
		[Address(RVA = "0x3229E4C", Offset = "0x3229E4C", VA = "0x3229E4C")]
		public void Reverse()
		{
		}

		// Token: 0x06007B8E RID: 31630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B8E")]
		[Address(RVA = "0x3229E58", Offset = "0x3229E58", VA = "0x3229E58")]
		public void Substring(FastStringBuilder output, int start, int length)
		{
		}

		// Token: 0x06007B8F RID: 31631 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007B8F")]
		[Address(RVA = "0x3229EE0", Offset = "0x3229EE0", VA = "0x3229EE0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06007B90 RID: 31632 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007B90")]
		[Address(RVA = "0x3229FD0", Offset = "0x3229FD0", VA = "0x3229FD0")]
		public string ToDebugString()
		{
			return null;
		}

		// Token: 0x06007B91 RID: 31633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B91")]
		[Address(RVA = "0x322A0E0", Offset = "0x322A0E0", VA = "0x322A0E0")]
		public void Replace(int oldChar, int newChar)
		{
		}

		// Token: 0x06007B92 RID: 31634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B92")]
		[Address(RVA = "0x322A13C", Offset = "0x322A13C", VA = "0x322A13C")]
		public void Replace(FastStringBuilder oldStr, FastStringBuilder newStr)
		{
		}

		// Token: 0x06007B93 RID: 31635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B93")]
		[Address(RVA = "0x322A430", Offset = "0x322A430", VA = "0x322A430")]
		public void Clear()
		{
		}

		// Token: 0x06007B94 RID: 31636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B94")]
		[Address(RVA = "0x3229870", Offset = "0x3229870", VA = "0x3229870")]
		private void EnsureCapacity(int cap, bool keepValues)
		{
		}

		// Token: 0x06007B95 RID: 31637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B95")]
		[Address(RVA = "0x3229974", Offset = "0x3229974", VA = "0x3229974")]
		private static void Copy(int[] src, int[] dst)
		{
		}

		// Token: 0x040036B6 RID: 14006
		[Token(Token = "0x40036B6")]
		[FieldOffset(Offset = "0x10")]
		private int length;

		// Token: 0x040036B7 RID: 14007
		[Token(Token = "0x40036B7")]
		[FieldOffset(Offset = "0x18")]
		private int[] array;

		// Token: 0x040036B8 RID: 14008
		[Token(Token = "0x40036B8")]
		[FieldOffset(Offset = "0x20")]
		private int capacity;
	}
}
