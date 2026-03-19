using System;
using System.Diagnostics;
using Il2CppDummyDll;

namespace GameFramework
{
	// Token: 0x020004F6 RID: 1270
	[Token(Token = "0x20004F6")]
	public class Log
	{
		// Token: 0x06002685 RID: 9861 RVA: 0x0000E838 File Offset: 0x0000CA38
		[Token(Token = "0x6002685")]
		[Address(RVA = "0x2B6143C", Offset = "0x2B6143C", VA = "0x2B6143C")]
		public static int GetWriteLogLevel()
		{
			return 0;
		}

		// Token: 0x06002686 RID: 9862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002686")]
		[Address(RVA = "0x2B61494", Offset = "0x2B61494", VA = "0x2B61494")]
		public static void SetWriteLogLevel(int value)
		{
		}

		// Token: 0x06002687 RID: 9863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002687")]
		[Address(RVA = "0x2B6153C", Offset = "0x2B6153C", VA = "0x2B6153C")]
		[Conditional("DEBUG")]
		public static void Debug(string message)
		{
		}

		// Token: 0x06002688 RID: 9864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002688")]
		[Address(RVA = "0x2B616A4", Offset = "0x2B616A4", VA = "0x2B616A4")]
		[Conditional("DEBUG")]
		public static void Debug(object message)
		{
		}

		// Token: 0x06002689 RID: 9865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002689")]
		[Address(RVA = "0x2B617A4", Offset = "0x2B617A4", VA = "0x2B617A4")]
		[Conditional("DEBUG")]
		public static void Debug(string format, object arg0)
		{
		}

		// Token: 0x0600268A RID: 9866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600268A")]
		[Address(RVA = "0x2B61854", Offset = "0x2B61854", VA = "0x2B61854")]
		[Conditional("DEBUG")]
		public static void Debug(string format, object arg0, object arg1)
		{
		}

		// Token: 0x0600268B RID: 9867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600268B")]
		[Address(RVA = "0x2B6190C", Offset = "0x2B6190C", VA = "0x2B6190C")]
		[Conditional("DEBUG")]
		public static void Debug(string format, object arg0, object arg1, object arg2)
		{
		}

		// Token: 0x0600268C RID: 9868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600268C")]
		[Address(RVA = "0x2B619D8", Offset = "0x2B619D8", VA = "0x2B619D8")]
		[Conditional("DEBUG")]
		public static void Debug(string format, params object[] args)
		{
		}

		// Token: 0x0600268D RID: 9869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600268D")]
		[Address(RVA = "0x2B61A88", Offset = "0x2B61A88", VA = "0x2B61A88")]
		public static void Info(string message)
		{
		}

		// Token: 0x0600268E RID: 9870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600268E")]
		[Address(RVA = "0x2B61B0C", Offset = "0x2B61B0C", VA = "0x2B61B0C")]
		public static void Info(object message)
		{
		}

		// Token: 0x0600268F RID: 9871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600268F")]
		[Address(RVA = "0x2B5F6DC", Offset = "0x2B5F6DC", VA = "0x2B5F6DC")]
		public static void Info(string format, object arg0)
		{
		}

		// Token: 0x06002690 RID: 9872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002690")]
		[Address(RVA = "0x2B61B90", Offset = "0x2B61B90", VA = "0x2B61B90")]
		public static void Info(string format, object arg0, object arg1)
		{
		}

		// Token: 0x06002691 RID: 9873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002691")]
		[Address(RVA = "0x2B5E7AC", Offset = "0x2B5E7AC", VA = "0x2B5E7AC")]
		public static void Info(string format, object arg0, object arg1, object arg2)
		{
		}

		// Token: 0x06002692 RID: 9874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002692")]
		[Address(RVA = "0x2B61C48", Offset = "0x2B61C48", VA = "0x2B61C48")]
		public static void Info(string format, params object[] args)
		{
		}

		// Token: 0x06002693 RID: 9875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002693")]
		[Address(RVA = "0x2B5EF18", Offset = "0x2B5EF18", VA = "0x2B5EF18")]
		public static void Error(string message)
		{
		}

		// Token: 0x06002694 RID: 9876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002694")]
		[Address(RVA = "0x2B61CF8", Offset = "0x2B61CF8", VA = "0x2B61CF8")]
		public static void Error(object message)
		{
		}

		// Token: 0x06002695 RID: 9877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002695")]
		[Address(RVA = "0x2B61D78", Offset = "0x2B61D78", VA = "0x2B61D78")]
		public static void Error(string format, object arg0)
		{
		}

		// Token: 0x06002696 RID: 9878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002696")]
		[Address(RVA = "0x2B61E24", Offset = "0x2B61E24", VA = "0x2B61E24")]
		public static void Error(string format, object arg0, object arg1)
		{
		}

		// Token: 0x06002697 RID: 9879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002697")]
		[Address(RVA = "0x2B61ED8", Offset = "0x2B61ED8", VA = "0x2B61ED8")]
		public static void Error(string format, object arg0, object arg1, object arg2)
		{
		}

		// Token: 0x06002698 RID: 9880 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002698")]
		[Address(RVA = "0x2B61FA0", Offset = "0x2B61FA0", VA = "0x2B61FA0")]
		public static void Error(string format, params object[] args)
		{
		}

		// Token: 0x06002699 RID: 9881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002699")]
		[Address(RVA = "0x2B61728", Offset = "0x2B61728", VA = "0x2B61728")]
		private static void LogHelper(LogLevel level, object message)
		{
		}

		// Token: 0x0600269A RID: 9882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600269A")]
		[Address(RVA = "0x2B615C0", Offset = "0x2B615C0", VA = "0x2B615C0")]
		private static void LogHelper(LogLevel level, string message)
		{
		}

		// Token: 0x0600269B RID: 9883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600269B")]
		[Address(RVA = "0x2B6204C", Offset = "0x2B6204C", VA = "0x2B6204C")]
		public Log()
		{
		}

		// Token: 0x040022AC RID: 8876
		[Token(Token = "0x40022AC")]
		[FieldOffset(Offset = "0x0")]
		private static int WriteLogLevel;
	}
}
