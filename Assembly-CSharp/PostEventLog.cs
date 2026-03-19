using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using Il2CppDummyDll;
using Unity.IL2CPP.CompilerServices;

// Token: 0x020000B7 RID: 183
[Token(Token = "0x20000B7")]
[Il2CppEagerStaticClassConstruction]
public static class PostEventLog
{
	// Token: 0x06000433 RID: 1075 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000433")]
	[Address(RVA = "0x2F6B62C", Offset = "0x2F6B62C", VA = "0x2F6B62C")]
	public static void SetLuaCallback(Action<string, string> action)
	{
	}

	// Token: 0x06000434 RID: 1076 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000434")]
	[Address(RVA = "0x2F6B67C", Offset = "0x2F6B67C", VA = "0x2F6B67C")]
	public static void RecordInThread_LUA(string paction, string pparam1 = "", string pparam2 = "")
	{
	}

	// Token: 0x06000435 RID: 1077 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000435")]
	[Address(RVA = "0x2F6B808", Offset = "0x2F6B808", VA = "0x2F6B808")]
	public static void RecordInThread(string paction, string pparam1 = "", string pparam2 = "")
	{
	}

	// Token: 0x06000436 RID: 1078 RVA: 0x00003450 File Offset: 0x00001650
	[Token(Token = "0x6000436")]
	[Address(RVA = "0x2F6B950", Offset = "0x2F6B950", VA = "0x2F6B950")]
	public static int UpdateThreadRecord()
	{
		return 0;
	}

	// Token: 0x06000437 RID: 1079 RVA: 0x00003468 File Offset: 0x00001668
	[Token(Token = "0x6000437")]
	[Address(RVA = "0x2F6BD3C", Offset = "0x2F6BD3C", VA = "0x2F6BD3C")]
	private static int getActionCount(string action)
	{
		return 0;
	}

	// Token: 0x06000438 RID: 1080 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000438")]
	[Address(RVA = "0x2F6BE3C", Offset = "0x2F6BE3C", VA = "0x2F6BE3C")]
	public static void init()
	{
	}

	// Token: 0x06000439 RID: 1081 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000439")]
	[Address(RVA = "0x2F6C288", Offset = "0x2F6C288", VA = "0x2F6C288")]
	private static string GetPostEventId()
	{
		return null;
	}

	// Token: 0x0600043A RID: 1082 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600043A")]
	[Address(RVA = "0x2F6C494", Offset = "0x2F6C494", VA = "0x2F6C494")]
	public static void stop()
	{
	}

	// Token: 0x0600043B RID: 1083 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600043B")]
	[Address(RVA = "0x2F6C788", Offset = "0x2F6C788", VA = "0x2F6C788")]
	public static void PostException(string action, string logString, string longText)
	{
	}

	// Token: 0x0600043C RID: 1084 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600043C")]
	[Address(RVA = "0x2F6DCA0", Offset = "0x2F6DCA0", VA = "0x2F6DCA0")]
	public static void Record(string action)
	{
	}

	// Token: 0x0600043D RID: 1085 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600043D")]
	[Address(RVA = "0x2F6DD24", Offset = "0x2F6DD24", VA = "0x2F6DD24")]
	public static void Record(int actionId)
	{
	}

	// Token: 0x0600043E RID: 1086 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600043E")]
	[Address(RVA = "0x2F6DE4C", Offset = "0x2F6DE4C", VA = "0x2F6DE4C")]
	public static void Record(string action, string param1)
	{
	}

	// Token: 0x0600043F RID: 1087 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600043F")]
	[Address(RVA = "0x2F6BC2C", Offset = "0x2F6BC2C", VA = "0x2F6BC2C")]
	public static void Record(string action, string param1, string param2)
	{
	}

	// Token: 0x06000440 RID: 1088 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000440")]
	[Address(RVA = "0x2F6DF24", Offset = "0x2F6DF24", VA = "0x2F6DF24")]
	public static void Record(string action, params string[] args)
	{
	}

	// Token: 0x06000441 RID: 1089 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000441")]
	[Address(RVA = "0x2F6CCA0", Offset = "0x2F6CCA0", VA = "0x2F6CCA0")]
	private static void Record(string action, [Optional] Dictionary<string, string> dictionary)
	{
	}

	// Token: 0x06000442 RID: 1090 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000442")]
	[Address(RVA = "0x2F6E354", Offset = "0x2F6E354", VA = "0x2F6E354")]
	public static void LogToServer(string value, int flag = 0)
	{
	}

	// Token: 0x06000443 RID: 1091 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000443")]
	[Address(RVA = "0x2F6E43C", Offset = "0x2F6E43C", VA = "0x2F6E43C")]
	public static void SendToFeishuMessage(string value)
	{
	}

	// Token: 0x06000444 RID: 1092 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000444")]
	[Address(RVA = "0x2F6EE90", Offset = "0x2F6EE90", VA = "0x2F6EE90")]
	public static void LogToFeishu(string value, int flag = 0)
	{
	}

	// Token: 0x040003EC RID: 1004
	[Token(Token = "0x40003EC")]
	[FieldOffset(Offset = "0x0")]
	private static readonly string[] pN;

	// Token: 0x040003ED RID: 1005
	[Token(Token = "0x40003ED")]
	[FieldOffset(Offset = "0x8")]
	private static readonly Dictionary<string, string> pairs;

	// Token: 0x040003EE RID: 1006
	[Token(Token = "0x40003EE")]
	[FieldOffset(Offset = "0x10")]
	private static readonly StringBuilder sb;

	// Token: 0x040003EF RID: 1007
	[Token(Token = "0x40003EF")]
	[FieldOffset(Offset = "0x18")]
	private static readonly PostEventThread postEventThread;

	// Token: 0x040003F0 RID: 1008
	[Token(Token = "0x40003F0")]
	[FieldOffset(Offset = "0x20")]
	public static bool hasInit;

	// Token: 0x040003F1 RID: 1009
	[Token(Token = "0x40003F1")]
	[FieldOffset(Offset = "0x28")]
	private static readonly object initLock;

	// Token: 0x040003F2 RID: 1010
	[Token(Token = "0x40003F2")]
	[FieldOffset(Offset = "0x30")]
	private static readonly Dictionary<string, int> actionCountMap;

	// Token: 0x040003F3 RID: 1011
	[Token(Token = "0x40003F3")]
	[FieldOffset(Offset = "0x38")]
	public static bool isGpTest;

	// Token: 0x040003F4 RID: 1012
	[Token(Token = "0x40003F4")]
	[FieldOffset(Offset = "0x40")]
	private static string posteventId;

	// Token: 0x040003F5 RID: 1013
	[Token(Token = "0x40003F5")]
	[FieldOffset(Offset = "0x48")]
	public static string POSTURL;

	// Token: 0x040003F6 RID: 1014
	[Token(Token = "0x40003F6")]
	[FieldOffset(Offset = "0x50")]
	public static string POSTURL_Loading;

	// Token: 0x040003F7 RID: 1015
	[Token(Token = "0x40003F7")]
	[FieldOffset(Offset = "0x58")]
	public static bool isApk;

	// Token: 0x040003F8 RID: 1016
	[Token(Token = "0x40003F8")]
	[FieldOffset(Offset = "0x60")]
	private static Dictionary<string, string> exceptionDict;

	// Token: 0x040003F9 RID: 1017
	[Token(Token = "0x40003F9")]
	[FieldOffset(Offset = "0x68")]
	private static Action<string, string> luaCallback;

	// Token: 0x040003FA RID: 1018
	[Token(Token = "0x40003FA")]
	[FieldOffset(Offset = "0x70")]
	private static ConcurrentQueue<PostEventLog.RecordMessage> _messageQueue_LUA;

	// Token: 0x040003FB RID: 1019
	[Token(Token = "0x40003FB")]
	[FieldOffset(Offset = "0x78")]
	private static ConcurrentQueue<PostEventLog.RecordMessage> _messageQueue;

	// Token: 0x040003FC RID: 1020
	[Token(Token = "0x40003FC")]
	[FieldOffset(Offset = "0x80")]
	public static Dictionary<int, bool> _logCache;

	// Token: 0x020000B8 RID: 184
	[Token(Token = "0x20000B8")]
	public static class Defines
	{
		// Token: 0x040003FD RID: 1021
		[Token(Token = "0x40003FD")]
		public const string LAUNCH = "APP_LAUNCH";

		// Token: 0x040003FE RID: 1022
		[Token(Token = "0x40003FE")]
		public const string RES_OK = "APP_RESOK";

		// Token: 0x040003FF RID: 1023
		[Token(Token = "0x40003FF")]
		public const string APP_QUIT = "APP_QUIT";

		// Token: 0x04000400 RID: 1024
		[Token(Token = "0x4000400")]
		public const string APP_PAUSE = "APP_PAUSE";

		// Token: 0x04000401 RID: 1025
		[Token(Token = "0x4000401")]
		public const string APP_RESUME = "APP_RESUME";

		// Token: 0x04000402 RID: 1026
		[Token(Token = "0x4000402")]
		public const string CHECK_VERSION_START = "CHECK_VERSION_START";

		// Token: 0x04000403 RID: 1027
		[Token(Token = "0x4000403")]
		public const string CHECK_VERSION_SUCCESS = "CHECK_VERSION_SUCCESS";

		// Token: 0x04000404 RID: 1028
		[Token(Token = "0x4000404")]
		public const string CHECK_VERSION_FAILED = "CHECK_VERSION_FAILED";

		// Token: 0x04000405 RID: 1029
		[Token(Token = "0x4000405")]
		public const string CHECK_VERSION_TIMEOUT = "CHECK_VERSION_TIMEOUT";

		// Token: 0x04000406 RID: 1030
		[Token(Token = "0x4000406")]
		public const string CHECK_VERSION_ONUPDATE = "CHECK_VERSION_ONUPDATE";

		// Token: 0x04000407 RID: 1031
		[Token(Token = "0x4000407")]
		public const string DOWNLOAD_MANIFEST_START = "DOWNLOAD_MANIFEST_START";

		// Token: 0x04000408 RID: 1032
		[Token(Token = "0x4000408")]
		public const string DOWNLOAD_MANIFEST_SUCCESS = "DOWNLOAD_MANIFEST_SUCCESS";

		// Token: 0x04000409 RID: 1033
		[Token(Token = "0x4000409")]
		public const string DOWNLOAD_MANIFEST_FAILED = "DOWNLOAD_MANIFEST_FAILED";

		// Token: 0x0400040A RID: 1034
		[Token(Token = "0x400040A")]
		public const string DOWNLOAD_MANIFEST_TIMEOUT = "DOWNLOAD_MANIFEST_TIMEOUT";

		// Token: 0x0400040B RID: 1035
		[Token(Token = "0x400040B")]
		public const string DOWNLOAD_START = "DOWNLOAD_START";

		// Token: 0x0400040C RID: 1036
		[Token(Token = "0x400040C")]
		public const string DOWNLOAD_FINISH = "DOWNLOAD_FINISH";

		// Token: 0x0400040D RID: 1037
		[Token(Token = "0x400040D")]
		public const string DOWNLOAD_FAILED = "DOWNLOAD_FAILED";

		// Token: 0x0400040E RID: 1038
		[Token(Token = "0x400040E")]
		public const string START_CONNECT = "START_CONNECT";

		// Token: 0x0400040F RID: 1039
		[Token(Token = "0x400040F")]
		public const string CONNECT_TIME_OUT = "CONNECT_TIME_OUT";

		// Token: 0x04000410 RID: 1040
		[Token(Token = "0x4000410")]
		public const string GET_SERVERLIST = "GET_SERVERLIST";

		// Token: 0x04000411 RID: 1041
		[Token(Token = "0x4000411")]
		public const string SERVERLIST_TIME_OUT = "SERVERLIST_TIME_OUT";

		// Token: 0x04000412 RID: 1042
		[Token(Token = "0x4000412")]
		public const string SERVERLIST_FAILED = "SERVERLIST_FAILED";

		// Token: 0x04000413 RID: 1043
		[Token(Token = "0x4000413")]
		public const string LONG_TIME_NOT_PUSH_INIT = "LONG_TIME_NOT_PUSH_INIT";

		// Token: 0x04000414 RID: 1044
		[Token(Token = "0x4000414")]
		public const string LOGIN_START = "LOGIN_START";

		// Token: 0x04000415 RID: 1045
		[Token(Token = "0x4000415")]
		public const string LOGIN_FINISH = "LOGIN_FINISH";

		// Token: 0x04000416 RID: 1046
		[Token(Token = "0x4000416")]
		public const string LOGIN_COMPLETE = "LOGIN_COMPLETE";

		// Token: 0x04000417 RID: 1047
		[Token(Token = "0x4000417")]
		public const string LOGIN_FAILED = "LOGIN_FAILED";

		// Token: 0x04000418 RID: 1048
		[Token(Token = "0x4000418")]
		public const string SERVER_STATUS = "SERVER_STATUS";

		// Token: 0x04000419 RID: 1049
		[Token(Token = "0x4000419")]
		public const string PUSH_INIT_RECV = "PUSH_INIT_RECV";

		// Token: 0x0400041A RID: 1050
		[Token(Token = "0x400041A")]
		public const string LOGIN_PARSE_ERROR = "LOGIN_PARSE_ERROR";

		// Token: 0x0400041B RID: 1051
		[Token(Token = "0x400041B")]
		public const string DISCONNECT_RETRY = "DISCONNECT_RETRY";

		// Token: 0x0400041C RID: 1052
		[Token(Token = "0x400041C")]
		public const string SOCKET_ERROR = "SOCKET_ERROR";

		// Token: 0x0400041D RID: 1053
		[Token(Token = "0x400041D")]
		public const string DNS_SUCESS = "DNS_SUCESS";

		// Token: 0x0400041E RID: 1054
		[Token(Token = "0x400041E")]
		public const string SOCKET_SHUTDOWN = "SOCKET_SHUTDOWN";

		// Token: 0x0400041F RID: 1055
		[Token(Token = "0x400041F")]
		public const string LOW_MEMORY = "LOW_MEMORY";
	}

	// Token: 0x020000B9 RID: 185
	[Token(Token = "0x20000B9")]
	private readonly struct RecordMessage
	{
		// Token: 0x06000446 RID: 1094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000446")]
		[Address(RVA = "0x2F6B7C4", Offset = "0x2F6B7C4", VA = "0x2F6B7C4")]
		public RecordMessage(string action, string param1 = "", string param2 = "")
		{
		}

		// Token: 0x04000420 RID: 1056
		[Token(Token = "0x4000420")]
		[FieldOffset(Offset = "0x0")]
		public readonly string Action;

		// Token: 0x04000421 RID: 1057
		[Token(Token = "0x4000421")]
		[FieldOffset(Offset = "0x8")]
		public readonly string Param1;

		// Token: 0x04000422 RID: 1058
		[Token(Token = "0x4000422")]
		[FieldOffset(Offset = "0x10")]
		public readonly string Param2;
	}
}
