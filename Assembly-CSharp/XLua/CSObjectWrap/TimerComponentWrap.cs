using System;
using Il2CppDummyDll;
using Unity.IL2CPP.CompilerServices;
using XLua.LuaDLL;

namespace XLua.CSObjectWrap
{
	// Token: 0x020008BC RID: 2236
	[Token(Token = "0x20008BC")]
	[Il2CppSetOption(Option.NullChecks, false)]
	public class TimerComponentWrap
	{
		// Token: 0x060044F8 RID: 17656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044F8")]
		[Address(RVA = "0x32449E0", Offset = "0x32449E0", VA = "0x32449E0")]
		public static void __Register(IntPtr L)
		{
		}

		// Token: 0x060044F9 RID: 17657 RVA: 0x00026A30 File Offset: 0x00024C30
		[Token(Token = "0x60044F9")]
		[Address(RVA = "0x323FC80", Offset = "0x323FC80", VA = "0x323FC80")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int __CreateInstance(IntPtr L)
		{
			return 0;
		}

		// Token: 0x060044FA RID: 17658 RVA: 0x00026A48 File Offset: 0x00024C48
		[Token(Token = "0x60044FA")]
		[Address(RVA = "0x323FE70", Offset = "0x323FE70", VA = "0x323FE70")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_Shutdown(IntPtr L)
		{
			return 0;
		}

		// Token: 0x060044FB RID: 17659 RVA: 0x00026A60 File Offset: 0x00024C60
		[Token(Token = "0x60044FB")]
		[Address(RVA = "0x324000C", Offset = "0x324000C", VA = "0x324000C")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_OnUpdate(IntPtr L)
		{
			return 0;
		}

		// Token: 0x060044FC RID: 17660 RVA: 0x00026A78 File Offset: 0x00024C78
		[Token(Token = "0x60044FC")]
		[Address(RVA = "0x32401F8", Offset = "0x32401F8", VA = "0x32401F8")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_ChangeTime(IntPtr L)
		{
			return 0;
		}

		// Token: 0x060044FD RID: 17661 RVA: 0x00026A90 File Offset: 0x00024C90
		[Token(Token = "0x60044FD")]
		[Address(RVA = "0x32403FC", Offset = "0x32403FC", VA = "0x32403FC")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_UpdateServerMilliseconds(IntPtr L)
		{
			return 0;
		}

		// Token: 0x060044FE RID: 17662 RVA: 0x00026AA8 File Offset: 0x00024CA8
		[Token(Token = "0x60044FE")]
		[Address(RVA = "0x32405EC", Offset = "0x32405EC", VA = "0x32405EC")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_GetLocalMilliseconds(IntPtr L)
		{
			return 0;
		}

		// Token: 0x060044FF RID: 17663 RVA: 0x00026AC0 File Offset: 0x00024CC0
		[Token(Token = "0x60044FF")]
		[Address(RVA = "0x32407C8", Offset = "0x32407C8", VA = "0x32407C8")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_GetLocalSeconds(IntPtr L)
		{
			return 0;
		}

		// Token: 0x06004500 RID: 17664 RVA: 0x00026AD8 File Offset: 0x00024CD8
		[Token(Token = "0x6004500")]
		[Address(RVA = "0x32409A4", Offset = "0x32409A4", VA = "0x32409A4")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_GetServerTime(IntPtr L)
		{
			return 0;
		}

		// Token: 0x06004501 RID: 17665 RVA: 0x00026AF0 File Offset: 0x00024CF0
		[Token(Token = "0x6004501")]
		[Address(RVA = "0x3240B80", Offset = "0x3240B80", VA = "0x3240B80")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_GetServerTimeSeconds(IntPtr L)
		{
			return 0;
		}

		// Token: 0x06004502 RID: 17666 RVA: 0x00026B08 File Offset: 0x00024D08
		[Token(Token = "0x6004502")]
		[Address(RVA = "0x3240D5C", Offset = "0x3240D5C", VA = "0x3240D5C")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_MillisecondToSecondString(IntPtr L)
		{
			return 0;
		}

		// Token: 0x06004503 RID: 17667 RVA: 0x00026B20 File Offset: 0x00024D20
		[Token(Token = "0x6004503")]
		[Address(RVA = "0x3240F78", Offset = "0x3240F78", VA = "0x3240F78")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_SecondsToSecondString(IntPtr L)
		{
			return 0;
		}

		// Token: 0x06004504 RID: 17668 RVA: 0x00026B38 File Offset: 0x00024D38
		[Token(Token = "0x6004504")]
		[Address(RVA = "0x3241194", Offset = "0x3241194", VA = "0x3241194")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_MilliSecondToFmtString(IntPtr L)
		{
			return 0;
		}

		// Token: 0x06004505 RID: 17669 RVA: 0x00026B50 File Offset: 0x00024D50
		[Token(Token = "0x6004505")]
		[Address(RVA = "0x3241398", Offset = "0x3241398", VA = "0x3241398")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_SecondToFmtString(IntPtr L)
		{
			return 0;
		}

		// Token: 0x06004506 RID: 17670 RVA: 0x00026B68 File Offset: 0x00024D68
		[Token(Token = "0x6004506")]
		[Address(RVA = "0x324159C", Offset = "0x324159C", VA = "0x324159C")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_RefixTimebyZone(IntPtr L)
		{
			return 0;
		}

		// Token: 0x06004507 RID: 17671 RVA: 0x00026B80 File Offset: 0x00024D80
		[Token(Token = "0x6004507")]
		[Address(RVA = "0x32417A0", Offset = "0x32417A0", VA = "0x32417A0")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_PassTimeSecondString(IntPtr L)
		{
			return 0;
		}

		// Token: 0x06004508 RID: 17672 RVA: 0x00026B98 File Offset: 0x00024D98
		[Token(Token = "0x6004508")]
		[Address(RVA = "0x3241B60", Offset = "0x3241B60", VA = "0x3241B60")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_GetDateTime(IntPtr L)
		{
			return 0;
		}

		// Token: 0x06004509 RID: 17673 RVA: 0x00026BB0 File Offset: 0x00024DB0
		[Token(Token = "0x6004509")]
		[Address(RVA = "0x3241D98", Offset = "0x3241D98", VA = "0x3241D98")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_TimeStampToTimeSimple(IntPtr L)
		{
			return 0;
		}

		// Token: 0x0600450A RID: 17674 RVA: 0x00026BC8 File Offset: 0x00024DC8
		[Token(Token = "0x600450A")]
		[Address(RVA = "0x3242198", Offset = "0x3242198", VA = "0x3242198")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_TimeStampToTimeDate(IntPtr L)
		{
			return 0;
		}

		// Token: 0x0600450B RID: 17675 RVA: 0x00026BE0 File Offset: 0x00024DE0
		[Token(Token = "0x600450B")]
		[Address(RVA = "0x3242598", Offset = "0x3242598", VA = "0x3242598")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_TimeStampToTimeDateMd(IntPtr L)
		{
			return 0;
		}

		// Token: 0x0600450C RID: 17676 RVA: 0x00026BF8 File Offset: 0x00024DF8
		[Token(Token = "0x600450C")]
		[Address(RVA = "0x3242998", Offset = "0x3242998", VA = "0x3242998")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_TimeStampToTime(IntPtr L)
		{
			return 0;
		}

		// Token: 0x0600450D RID: 17677 RVA: 0x00026C10 File Offset: 0x00024E10
		[Token(Token = "0x600450D")]
		[Address(RVA = "0x3242D98", Offset = "0x3242D98", VA = "0x3242D98")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_GetUniversalTime(IntPtr L)
		{
			return 0;
		}

		// Token: 0x0600450E RID: 17678 RVA: 0x00026C28 File Offset: 0x00024E28
		[Token(Token = "0x600450E")]
		[Address(RVA = "0x3243198", Offset = "0x3243198", VA = "0x3243198")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_GetUniversalChatTime(IntPtr L)
		{
			return 0;
		}

		// Token: 0x0600450F RID: 17679 RVA: 0x00026C40 File Offset: 0x00024E40
		[Token(Token = "0x600450F")]
		[Address(RVA = "0x3243598", Offset = "0x3243598", VA = "0x3243598")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_GetServerWeekDay(IntPtr L)
		{
			return 0;
		}

		// Token: 0x06004510 RID: 17680 RVA: 0x00026C58 File Offset: 0x00024E58
		[Token(Token = "0x6004510")]
		[Address(RVA = "0x3243774", Offset = "0x3243774", VA = "0x3243774")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_WeekDay(IntPtr L)
		{
			return 0;
		}

		// Token: 0x06004511 RID: 17681 RVA: 0x00026C70 File Offset: 0x00024E70
		[Token(Token = "0x6004511")]
		[Address(RVA = "0x324399C", Offset = "0x324399C", VA = "0x324399C")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_GetWeekDay(IntPtr L)
		{
			return 0;
		}

		// Token: 0x06004512 RID: 17682 RVA: 0x00026C88 File Offset: 0x00024E88
		[Token(Token = "0x6004512")]
		[Address(RVA = "0x3243BA0", Offset = "0x3243BA0", VA = "0x3243BA0")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_GetResSecondsTo24(IntPtr L)
		{
			return 0;
		}

		// Token: 0x06004513 RID: 17683 RVA: 0x00026CA0 File Offset: 0x00024EA0
		[Token(Token = "0x6004513")]
		[Address(RVA = "0x3243D7C", Offset = "0x3243D7C", VA = "0x3243D7C")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_RegisterTimer(IntPtr L)
		{
			return 0;
		}

		// Token: 0x06004514 RID: 17684 RVA: 0x00026CB8 File Offset: 0x00024EB8
		[Token(Token = "0x6004514")]
		[Address(RVA = "0x3243FC4", Offset = "0x3243FC4", VA = "0x3243FC4")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_RegisterTimerRepeat(IntPtr L)
		{
			return 0;
		}

		// Token: 0x06004515 RID: 17685 RVA: 0x00026CD0 File Offset: 0x00024ED0
		[Token(Token = "0x6004515")]
		[Address(RVA = "0x3244228", Offset = "0x3244228", VA = "0x3244228")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_CancelTimer(IntPtr L)
		{
			return 0;
		}

		// Token: 0x06004516 RID: 17686 RVA: 0x00026CE8 File Offset: 0x00024EE8
		[Token(Token = "0x6004516")]
		[Address(RVA = "0x3244494", Offset = "0x3244494", VA = "0x3244494")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_CancelAllTimers(IntPtr L)
		{
			return 0;
		}

		// Token: 0x06004517 RID: 17687 RVA: 0x00026D00 File Offset: 0x00024F00
		[Token(Token = "0x6004517")]
		[Address(RVA = "0x3244630", Offset = "0x3244630", VA = "0x3244630")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_Tomorrow(IntPtr L)
		{
			return 0;
		}

		// Token: 0x06004518 RID: 17688 RVA: 0x00026D18 File Offset: 0x00024F18
		[Token(Token = "0x6004518")]
		[Address(RVA = "0x3244804", Offset = "0x3244804", VA = "0x3244804")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _s_set_Tomorrow(IntPtr L)
		{
			return 0;
		}

		// Token: 0x06004519 RID: 17689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004519")]
		[Address(RVA = "0x324569C", Offset = "0x324569C", VA = "0x324569C")]
		public TimerComponentWrap()
		{
		}
	}
}
