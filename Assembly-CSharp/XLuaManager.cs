using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Il2CppDummyDll;
using LuaScriptInterface;
using Unity.Collections;
using VEngine;
using XLua;

// Token: 0x02000388 RID: 904
[Token(Token = "0x2000388")]
public class XLuaManager
{
	// Token: 0x1700024F RID: 591
	// (get) Token: 0x06001703 RID: 5891 RVA: 0x00008AA8 File Offset: 0x00006CA8
	// (set) Token: 0x06001704 RID: 5892 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700024F")]
	public static bool loadUsePtr
	{
		[Token(Token = "0x6001703")]
		[Address(RVA = "0x1DB0658", Offset = "0x1DB0658", VA = "0x1DB0658")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001704")]
		[Address(RVA = "0x1DB06B0", Offset = "0x1DB06B0", VA = "0x1DB06B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	// Token: 0x17000250 RID: 592
	// (get) Token: 0x06001705 RID: 5893 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000250")]
	public LuaEnv Env
	{
		[Token(Token = "0x6001705")]
		[Address(RVA = "0x1DB070C", Offset = "0x1DB070C", VA = "0x1DB070C")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000251 RID: 593
	// (get) Token: 0x06001706 RID: 5894 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000251")]
	public UIManager UIManager
	{
		[Token(Token = "0x6001706")]
		[Address(RVA = "0x1DB0714", Offset = "0x1DB0714", VA = "0x1DB0714")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000252 RID: 594
	// (get) Token: 0x06001707 RID: 5895 RVA: 0x00008AC0 File Offset: 0x00006CC0
	// (set) Token: 0x06001708 RID: 5896 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000252")]
	public bool HasGameStart
	{
		[Token(Token = "0x6001707")]
		[Address(RVA = "0x1DB071C", Offset = "0x1DB071C", VA = "0x1DB071C")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001708")]
		[Address(RVA = "0x1DB0724", Offset = "0x1DB0724", VA = "0x1DB0724")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	// Token: 0x06001709 RID: 5897 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001709")]
	[Address(RVA = "0x1DB0730", Offset = "0x1DB0730", VA = "0x1DB0730")]
	public void Initialize([Optional] Action callback)
	{
	}

	// Token: 0x0600170A RID: 5898 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600170A")]
	[Address(RVA = "0x1DB0814", Offset = "0x1DB0814", VA = "0x1DB0814")]
	private void InitLuaEnv()
	{
	}

	// Token: 0x0600170B RID: 5899 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600170B")]
	[Address(RVA = "0x1DB0ABC", Offset = "0x1DB0ABC", VA = "0x1DB0ABC")]
	private void OnInit()
	{
	}

	// Token: 0x0600170C RID: 5900 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600170C")]
	[Address(RVA = "0x1DB1038", Offset = "0x1DB1038", VA = "0x1DB1038")]
	public void Update()
	{
	}

	// Token: 0x0600170D RID: 5901 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600170D")]
	[Address(RVA = "0x1DB11E8", Offset = "0x1DB11E8", VA = "0x1DB11E8")]
	public void StartGame()
	{
	}

	// Token: 0x0600170E RID: 5902 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600170E")]
	[Address(RVA = "0x1DB1BA0", Offset = "0x1DB1BA0", VA = "0x1DB1BA0")]
	public void ExitGame()
	{
	}

	// Token: 0x0600170F RID: 5903 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600170F")]
	[Address(RVA = "0x1DB20E0", Offset = "0x1DB20E0", VA = "0x1DB20E0")]
	public void Shutdown()
	{
	}

	// Token: 0x06001710 RID: 5904 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001710")]
	[Address(RVA = "0x1DB187C", Offset = "0x1DB187C", VA = "0x1DB187C")]
	private void CallLuaGameMainStart()
	{
	}

	// Token: 0x06001711 RID: 5905 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001711")]
	[Address(RVA = "0x1DB2294", Offset = "0x1DB2294", VA = "0x1DB2294")]
	public void DumpLoadingLuaScripts()
	{
	}

	// Token: 0x06001712 RID: 5906 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001712")]
	[Address(RVA = "0x1DB1D7C", Offset = "0x1DB1D7C", VA = "0x1DB1D7C")]
	private void ReleaseAllLuaAssets()
	{
	}

	// Token: 0x06001713 RID: 5907 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001713")]
	[Address(RVA = "0x1DB1C10", Offset = "0x1DB1C10", VA = "0x1DB1C10")]
	public void SafeDoString(string scriptContent)
	{
	}

	// Token: 0x06001714 RID: 5908 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001714")]
	[Address(RVA = "0x1DB0FD4", Offset = "0x1DB0FD4", VA = "0x1DB0FD4")]
	public void LoadScript(string scriptName)
	{
	}

	// Token: 0x06001715 RID: 5909 RVA: 0x00008AD8 File Offset: 0x00006CD8
	[Token(Token = "0x6001715")]
	[Address(RVA = "0x1DB2488", Offset = "0x1DB2488", VA = "0x1DB2488")]
	public bool IsUseNativeDebugMode()
	{
		return default(bool);
	}

	// Token: 0x06001716 RID: 5910 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001716")]
	[Address(RVA = "0x1DB0B30", Offset = "0x1DB0B30", VA = "0x1DB0B30")]
	private void CheckLoadNativeCode()
	{
	}

	// Token: 0x06001717 RID: 5911 RVA: 0x00008AF0 File Offset: 0x00006CF0
	[Token(Token = "0x6001717")]
	[Address(RVA = "0x1DB24E0", Offset = "0x1DB24E0", VA = "0x1DB24E0")]
	public static LuaEnv.LuaFileInfo CustomLoader(ref string filepath)
	{
		return default(LuaEnv.LuaFileInfo);
	}

	// Token: 0x06001718 RID: 5912 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001718")]
	[Address(RVA = "0x1DB2F44", Offset = "0x1DB2F44", VA = "0x1DB2F44")]
	public static void CheckIfReleaseTextAsset(Asset request)
	{
	}

	// Token: 0x06001719 RID: 5913 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001719")]
	[Address(RVA = "0x1DB3108", Offset = "0x1DB3108", VA = "0x1DB3108")]
	private static string ToHexStr(NativeArray<byte> array)
	{
		return null;
	}

	// Token: 0x0600171A RID: 5914 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600171A")]
	[Address(RVA = "0x1DB335C", Offset = "0x1DB335C", VA = "0x1DB335C")]
	public void DispatchResponse(string cmd, LuaTable table)
	{
	}

	// Token: 0x0600171B RID: 5915 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600171B")]
	[Address(RVA = "0x1DB3384", Offset = "0x1DB3384", VA = "0x1DB3384")]
	public void DispatchResponse(string cmd, LuaStackTable table)
	{
	}

	// Token: 0x0600171C RID: 5916 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600171C")]
	[Address(RVA = "0x1DB33D0", Offset = "0x1DB33D0", VA = "0x1DB33D0")]
	public void PreloadAssets()
	{
	}

	// Token: 0x0600171D RID: 5917 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600171D")]
	[Address(RVA = "0x1DB33FC", Offset = "0x1DB33FC", VA = "0x1DB33FC")]
	public void UpdateUITimeStamp(long timeStamp)
	{
	}

	// Token: 0x0600171E RID: 5918 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600171E")]
	[Address(RVA = "0x1DB3428", Offset = "0x1DB3428", VA = "0x1DB3428")]
	public void ShowTips(string msg, string img, string atlas)
	{
	}

	// Token: 0x0600171F RID: 5919 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600171F")]
	[Address(RVA = "0x1DB3454", Offset = "0x1DB3454", VA = "0x1DB3454")]
	public void ShowMessage(string tipText, int btnNum, string text1, string text2, Action action1, Action action2, Action closeAction, string titleText, bool isChangeImg)
	{
	}

	// Token: 0x06001720 RID: 5920 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001720")]
	[Address(RVA = "0x1DB3498", Offset = "0x1DB3498", VA = "0x1DB3498")]
	public void ShowFoldUpBuild(string posX, string posY, string posZ, string bUuid)
	{
	}

	// Token: 0x06001721 RID: 5921 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001721")]
	[Address(RVA = "0x1DB34C4", Offset = "0x1DB34C4", VA = "0x1DB34C4")]
	public void WebSocketResponse(string data)
	{
	}

	// Token: 0x06001722 RID: 5922 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001722")]
	[Address(RVA = "0x1DB34F0", Offset = "0x1DB34F0", VA = "0x1DB34F0")]
	public string GetTemplateData(string xmlId, int id, string attrStr)
	{
		return null;
	}

	// Token: 0x06001723 RID: 5923 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001723")]
	[Address(RVA = "0x1DB3588", Offset = "0x1DB3588", VA = "0x1DB3588")]
	public void OnApplicationPause(bool pause)
	{
	}

	// Token: 0x06001724 RID: 5924 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001724")]
	[Address(RVA = "0x1DB35B8", Offset = "0x1DB35B8", VA = "0x1DB35B8")]
	public void OnApplicationFocus(bool focus)
	{
	}

	// Token: 0x06001725 RID: 5925 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001725")]
	[Address(RVA = "0x1DB35E8", Offset = "0x1DB35E8", VA = "0x1DB35E8")]
	public void DispatchCSEvent(int eventId, object userData)
	{
	}

	// Token: 0x06001726 RID: 5926 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001726")]
	[Address(RVA = "0x1DB3614", Offset = "0x1DB3614", VA = "0x1DB3614")]
	public void LuaLoadPb(byte[] bytes)
	{
	}

	// Token: 0x06001727 RID: 5927 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001727")]
	[Address(RVA = "0x1DB1FF8", Offset = "0x1DB1FF8", VA = "0x1DB1FF8")]
	private void ClearLuaReference()
	{
	}

	// Token: 0x06001728 RID: 5928 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001728")]
	[Address(RVA = "0x1DB3630", Offset = "0x1DB3630", VA = "0x1DB3630")]
	public string GetLuaTracebackStr()
	{
		return null;
	}

	// Token: 0x06001729 RID: 5929 RVA: 0x00008B08 File Offset: 0x00006D08
	[Token(Token = "0x6001729")]
	[Address(RVA = "0x1DB36CC", Offset = "0x1DB36CC", VA = "0x1DB36CC")]
	public int GetLuaStackSize()
	{
		return 0;
	}

	// Token: 0x0600172A RID: 5930 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600172A")]
	[Address(RVA = "0x1DB0D6C", Offset = "0x1DB0D6C", VA = "0x1DB0D6C")]
	private void initContext()
	{
	}

	// Token: 0x0600172B RID: 5931 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600172B")]
	[Address(RVA = "0x1DB3748", Offset = "0x1DB3748", VA = "0x1DB3748")]
	private void fillByteArray(byte[] dest, ReadOnlySpan<char> src)
	{
	}

	// Token: 0x0600172C RID: 5932 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600172C")]
	[Address(RVA = "0x1DB37D4", Offset = "0x1DB37D4", VA = "0x1DB37D4")]
	public void ClearCacheTable(string luaTableName)
	{
	}

	// Token: 0x0600172D RID: 5933 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600172D")]
	[Address(RVA = "0x1DB0CD8", Offset = "0x1DB0CD8", VA = "0x1DB0CD8")]
	public void ClearCacheTableAll()
	{
	}

	// Token: 0x0600172E RID: 5934 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600172E")]
	[Address(RVA = "0x1DB38E4", Offset = "0x1DB38E4", VA = "0x1DB38E4")]
	private XLuaManager.LuaTableLookup cacheTable(ReadOnlySpan<char> tableName, uint tableHashCode, LuaTable tbl)
	{
		return null;
	}

	// Token: 0x0600172F RID: 5935 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600172F")]
	private T getLuaChild<T>(LuaTable parent, ReadOnlySpan<char> childName)
	{
		return null;
	}

	// Token: 0x06001730 RID: 5936 RVA: 0x00008B20 File Offset: 0x00006D20
	[Token(Token = "0x6001730")]
	[Address(RVA = "0x1DB3A30", Offset = "0x1DB3A30", VA = "0x1DB3A30")]
	private bool getAndCacheTable(ReadOnlySpan<char> tableName, out XLuaManager.LuaTableLookup lt)
	{
		return default(bool);
	}

	// Token: 0x06001731 RID: 5937 RVA: 0x00008B38 File Offset: 0x00006D38
	[Token(Token = "0x6001731")]
	[Address(RVA = "0x1DB3C00", Offset = "0x1DB3C00", VA = "0x1DB3C00")]
	private bool getAndCacheFunction(ReadOnlySpan<char> tableName, ReadOnlySpan<char> funcName, out LuaTable t, out LuaFunction f)
	{
		return default(bool);
	}

	// Token: 0x06001732 RID: 5938 RVA: 0x00008B50 File Offset: 0x00006D50
	[Token(Token = "0x6001732")]
	[Address(RVA = "0x1DB387C", Offset = "0x1DB387C", VA = "0x1DB387C")]
	private uint hash_function(ReadOnlySpan<char> str)
	{
		return 0U;
	}

	// Token: 0x06001733 RID: 5939 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001733")]
	[Address(RVA = "0x1DB3D90", Offset = "0x1DB3D90", VA = "0x1DB3D90")]
	private byte[] byte_Rent(int len)
	{
		return null;
	}

	// Token: 0x06001734 RID: 5940 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001734")]
	[Address(RVA = "0x1DB3D98", Offset = "0x1DB3D98", VA = "0x1DB3D98")]
	private void byte_Return(byte[] b)
	{
	}

	// Token: 0x06001735 RID: 5941 RVA: 0x00008B68 File Offset: 0x00006D68
	[Token(Token = "0x6001735")]
	[Address(RVA = "0x1DB3D9C", Offset = "0x1DB3D9C", VA = "0x1DB3D9C")]
	private bool makeCallContext(string fullPathName, ref XLuaManager.CallContext cc)
	{
		return default(bool);
	}

	// Token: 0x06001736 RID: 5942 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001736")]
	private T endCallContext<T>(XLuaManager.CallContext cc)
	{
		return null;
	}

	// Token: 0x06001737 RID: 5943 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001737")]
	[Address(RVA = "0x1DB405C", Offset = "0x1DB405C", VA = "0x1DB405C")]
	private static void AddIntParam(XLuaManager.CallContext cc, int param)
	{
	}

	// Token: 0x06001738 RID: 5944 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001738")]
	[Address(RVA = "0x1DB415C", Offset = "0x1DB415C", VA = "0x1DB415C")]
	private static void AddUIntParam(XLuaManager.CallContext cc, uint param)
	{
	}

	// Token: 0x06001739 RID: 5945 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001739")]
	[Address(RVA = "0x1DB42CC", Offset = "0x1DB42CC", VA = "0x1DB42CC")]
	private static void AddLongParam(XLuaManager.CallContext cc, long param)
	{
	}

	// Token: 0x0600173A RID: 5946 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600173A")]
	[Address(RVA = "0x1DB43C8", Offset = "0x1DB43C8", VA = "0x1DB43C8")]
	private static void AddULongParam(XLuaManager.CallContext cc, ulong param)
	{
	}

	// Token: 0x0600173B RID: 5947 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600173B")]
	[Address(RVA = "0x1DB4534", Offset = "0x1DB4534", VA = "0x1DB4534")]
	private static void AddDoubleParam(XLuaManager.CallContext cc, double param)
	{
	}

	// Token: 0x0600173C RID: 5948 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600173C")]
	[Address(RVA = "0x1DB4684", Offset = "0x1DB4684", VA = "0x1DB4684")]
	private static void AddBoolParam(XLuaManager.CallContext cc, bool param)
	{
	}

	// Token: 0x0600173D RID: 5949 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600173D")]
	[Address(RVA = "0x1DB47C0", Offset = "0x1DB47C0", VA = "0x1DB47C0")]
	private static void AddStringParam(XLuaManager.CallContext cc, string param)
	{
	}

	// Token: 0x0600173E RID: 5950 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600173E")]
	[Address(RVA = "0x1DB48E4", Offset = "0x1DB48E4", VA = "0x1DB48E4")]
	private static void AddObjectParam(XLuaManager.CallContext cc, object obj)
	{
	}

	// Token: 0x0600173F RID: 5951 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600173F")]
	private void AddParam<T>(XLuaManager.CallContext cc, T param)
	{
	}

	// Token: 0x06001740 RID: 5952 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001740")]
	[Address(RVA = "0x1DB4A04", Offset = "0x1DB4A04", VA = "0x1DB4A04")]
	public void Call(string luaFunctionPath)
	{
	}

	// Token: 0x06001741 RID: 5953 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001741")]
	public void Call<T1>(string luaFunctionPath, T1 param1)
	{
	}

	// Token: 0x06001742 RID: 5954 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001742")]
	public void Call<T1, T2>(string luaFunctionPath, T1 param1, T2 param2)
	{
	}

	// Token: 0x06001743 RID: 5955 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001743")]
	public void Call<T1, T2, T3>(string luaFunctionPath, T1 param1, T2 param2, T3 param3)
	{
	}

	// Token: 0x06001744 RID: 5956 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001744")]
	public void Call<T1, T2, T3, T4>(string luaFunctionPath, T1 param1, T2 param2, T3 param3, T4 param4)
	{
	}

	// Token: 0x06001745 RID: 5957 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001745")]
	public void Call<T1, T2, T3, T4, T5>(string luaFunctionPath, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5)
	{
	}

	// Token: 0x06001746 RID: 5958 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001746")]
	public T CallWithReturn<T>(string luaFunctionPath)
	{
		return null;
	}

	// Token: 0x06001747 RID: 5959 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001747")]
	public T CallWithReturn<T, T1>(string luaFunctionPath, T1 param1)
	{
		return null;
	}

	// Token: 0x06001748 RID: 5960 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001748")]
	public T CallWithReturn<T, T1, T2>(string luaFunctionPath, T1 param1, T2 param2)
	{
		return null;
	}

	// Token: 0x06001749 RID: 5961 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001749")]
	public T CallWithReturn<T, T1, T2, T3>(string luaFunctionPath, T1 param1, T2 param2, T3 param3)
	{
		return null;
	}

	// Token: 0x0600174A RID: 5962 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600174A")]
	public T CallWithReturn<T, T1, T2, T3, T4>(string luaFunctionPath, T1 param1, T2 param2, T3 param3, T4 param4)
	{
		return null;
	}

	// Token: 0x0600174B RID: 5963 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600174B")]
	public T CallWithReturn<T, T1, T2, T3, T4, T5>(string luaFunctionPath, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5)
	{
		return null;
	}

	// Token: 0x0600174C RID: 5964 RVA: 0x00008B80 File Offset: 0x00006D80
	[Token(Token = "0x600174C")]
	[Address(RVA = "0x1DB4A84", Offset = "0x1DB4A84", VA = "0x1DB4A84")]
	public int CallWithReturnInt(string luaFunctionPath)
	{
		return 0;
	}

	// Token: 0x0600174D RID: 5965 RVA: 0x00008B98 File Offset: 0x00006D98
	[Token(Token = "0x600174D")]
	public int CallWithReturnInt<T1>(string luaFunctionPath, T1 param1)
	{
		return 0;
	}

	// Token: 0x0600174E RID: 5966 RVA: 0x00008BB0 File Offset: 0x00006DB0
	[Token(Token = "0x600174E")]
	public int CallWithReturnInt<T1, T2>(string luaFunctionPath, T1 param1, T2 param2)
	{
		return 0;
	}

	// Token: 0x0600174F RID: 5967 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600174F")]
	[Address(RVA = "0x1DB4ADC", Offset = "0x1DB4ADC", VA = "0x1DB4ADC")]
	public string CallWithReturnString(string luaFunctionPath)
	{
		return null;
	}

	// Token: 0x06001750 RID: 5968 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001750")]
	public string CallWithReturnString<T1>(string luaFunctionPath, T1 param1)
	{
		return null;
	}

	// Token: 0x06001751 RID: 5969 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001751")]
	public string CallWithReturnString<T1, T2>(string luaFunctionPath, T1 param1, T2 param2)
	{
		return null;
	}

	// Token: 0x06001752 RID: 5970 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001752")]
	public void SetValue<T>(string luaTable, string attr, T value)
	{
	}

	// Token: 0x06001753 RID: 5971 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001753")]
	public T GetValue<T>(string luaTable, string attr)
	{
		return null;
	}

	// Token: 0x06001754 RID: 5972 RVA: 0x00008BC8 File Offset: 0x00006DC8
	[Token(Token = "0x6001754")]
	[Address(RVA = "0x1DB4B34", Offset = "0x1DB4B34", VA = "0x1DB4B34")]
	public int GetValue_Int(string luaTable, string attr)
	{
		return 0;
	}

	// Token: 0x06001755 RID: 5973 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001755")]
	[Address(RVA = "0x1DB4B94", Offset = "0x1DB4B94", VA = "0x1DB4B94")]
	public string GetValue_String(string luaTable, string attr)
	{
		return null;
	}

	// Token: 0x06001756 RID: 5974 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001756")]
	[Address(RVA = "0x1DB4BF4", Offset = "0x1DB4BF4", VA = "0x1DB4BF4")]
	public XLuaManager()
	{
	}

	// Token: 0x04001A03 RID: 6659
	[Token(Token = "0x4001A03")]
	[FieldOffset(Offset = "0x0")]
	private static readonly string[] LuaRootPath_portrait;

	// Token: 0x04001A04 RID: 6660
	[Token(Token = "0x4001A04")]
	[FieldOffset(Offset = "0x8")]
	private static readonly string[] LuaRootPath_landscape;

	// Token: 0x04001A05 RID: 6661
	[Token(Token = "0x4001A05")]
	[FieldOffset(Offset = "0x10")]
	private static string[] LuaRootPath;

	// Token: 0x04001A06 RID: 6662
	[Token(Token = "0x4001A06")]
	[FieldOffset(Offset = "0x18")]
	private static readonly string[] LuaRootPathEditor_portrait;

	// Token: 0x04001A07 RID: 6663
	[Token(Token = "0x4001A07")]
	[FieldOffset(Offset = "0x20")]
	private static readonly string[] LuaRootPathEditor_landscape;

	// Token: 0x04001A08 RID: 6664
	[Token(Token = "0x4001A08")]
	[FieldOffset(Offset = "0x28")]
	private static readonly string[] buildin_files;

	// Token: 0x04001A09 RID: 6665
	[Token(Token = "0x4001A09")]
	[FieldOffset(Offset = "0x30")]
	private static string[] LuaRootPathEditor;

	// Token: 0x04001A0A RID: 6666
	[Token(Token = "0x4001A0A")]
	private const string CommonMainScriptName = "Common.Main";

	// Token: 0x04001A0B RID: 6667
	[Token(Token = "0x4001A0B")]
	private const string GameMainScriptName = "GameMain";

	// Token: 0x04001A0C RID: 6668
	[Token(Token = "0x4001A0C")]
	[FieldOffset(Offset = "0x10")]
	private Dictionary<Bundle, Asset> m_LuaScripts;

	// Token: 0x04001A0D RID: 6669
	[Token(Token = "0x4001A0D")]
	[FieldOffset(Offset = "0x18")]
	private Action OnInitCallback;

	// Token: 0x04001A0E RID: 6670
	[Token(Token = "0x4001A0E")]
	[FieldOffset(Offset = "0x20")]
	private LuaEnv m_LuaEnv;

	// Token: 0x04001A0F RID: 6671
	[Token(Token = "0x4001A0F")]
	[FieldOffset(Offset = "0x28")]
	private UIManager uiManager;

	// Token: 0x04001A10 RID: 6672
	[Token(Token = "0x4001A10")]
	[FieldOffset(Offset = "0x30")]
	private Action<float, float> luaUpdate;

	// Token: 0x04001A11 RID: 6673
	[Token(Token = "0x4001A11")]
	[FieldOffset(Offset = "0x38")]
	public static bool NeedUnloadUnusedResource;

	// Token: 0x04001A12 RID: 6674
	[Token(Token = "0x4001A12")]
	[FieldOffset(Offset = "0x3C")]
	public static float UnloadUnusedResourceMinTime;

	// Token: 0x04001A14 RID: 6676
	[Token(Token = "0x4001A14")]
	[FieldOffset(Offset = "0x38")]
	private LuaFunction dispatchNetMessage;

	// Token: 0x04001A15 RID: 6677
	[Token(Token = "0x4001A15")]
	[FieldOffset(Offset = "0x40")]
	private XLuaManager.onApplicationPause _onApplicationPause;

	// Token: 0x04001A16 RID: 6678
	[Token(Token = "0x4001A16")]
	[FieldOffset(Offset = "0x48")]
	private XLuaManager.onApplicationFocus _onApplicationFocus;

	// Token: 0x04001A17 RID: 6679
	[Token(Token = "0x4001A17")]
	[FieldOffset(Offset = "0x50")]
	private XLuaManager.UITimeForLuaDelegate updateUITimeStamp;

	// Token: 0x04001A18 RID: 6680
	[Token(Token = "0x4001A18")]
	[FieldOffset(Offset = "0x58")]
	private XLuaManager.UIShowTipsDelegate showTips;

	// Token: 0x04001A19 RID: 6681
	[Token(Token = "0x4001A19")]
	[FieldOffset(Offset = "0x60")]
	private XLuaManager.UIShowMessageDelegate showMessage;

	// Token: 0x04001A1A RID: 6682
	[Token(Token = "0x4001A1A")]
	[FieldOffset(Offset = "0x68")]
	private XLuaManager.UIShowFoldUpBuild showFoldUpBuild;

	// Token: 0x04001A1B RID: 6683
	[Token(Token = "0x4001A1B")]
	[FieldOffset(Offset = "0x70")]
	private XLuaManager.WebSocketProtocalDelegate webSocketProtocal;

	// Token: 0x04001A1C RID: 6684
	[Token(Token = "0x4001A1C")]
	[FieldOffset(Offset = "0x78")]
	private XLuaManager.GetTemplateDataFromLua getTemplateDataFromLua;

	// Token: 0x04001A1D RID: 6685
	[Token(Token = "0x4001A1D")]
	[FieldOffset(Offset = "0x80")]
	private XLuaManager.PreloadAssetsDelegate preloadAssets;

	// Token: 0x04001A1E RID: 6686
	[Token(Token = "0x4001A1E")]
	[FieldOffset(Offset = "0x88")]
	private XLuaManager.LuaLoadPbConfig luaLoadPbConfig;

	// Token: 0x04001A1F RID: 6687
	[Token(Token = "0x4001A1F")]
	[FieldOffset(Offset = "0x90")]
	private XLuaManager.dispatchCSEvent _dispatchCsEvent;

	// Token: 0x04001A21 RID: 6689
	[Token(Token = "0x4001A21")]
	[FieldOffset(Offset = "0xA0")]
	private double m_lastTimePerSecondUpdate;

	// Token: 0x04001A22 RID: 6690
	[Token(Token = "0x4001A22")]
	[FieldOffset(Offset = "0x41")]
	public static bool m_useNative;

	// Token: 0x04001A23 RID: 6691
	[Token(Token = "0x4001A23")]
	[FieldOffset(Offset = "0x48")]
	private static StringBuilder loaderBuf;

	// Token: 0x04001A24 RID: 6692
	[Token(Token = "0x4001A24")]
	[FieldOffset(Offset = "0x50")]
	private static StringBuilder loaderFinalBuf;

	// Token: 0x04001A25 RID: 6693
	[Token(Token = "0x4001A25")]
	[FieldOffset(Offset = "0xA8")]
	private Dictionary<uint, XLuaManager.LuaTableLookup> lookupTables_;

	// Token: 0x04001A26 RID: 6694
	[Token(Token = "0x4001A26")]
	[FieldOffset(Offset = "0xB0")]
	private string lastFunctionName;

	// Token: 0x04001A27 RID: 6695
	[Token(Token = "0x4001A27")]
	[FieldOffset(Offset = "0xB8")]
	private LuaTable lastTable;

	// Token: 0x04001A28 RID: 6696
	[Token(Token = "0x4001A28")]
	[FieldOffset(Offset = "0xC0")]
	private LuaFunction lastFunction;

	// Token: 0x04001A29 RID: 6697
	[Token(Token = "0x4001A29")]
	[FieldOffset(Offset = "0xC8")]
	private int lastCacheCount;

	// Token: 0x04001A2A RID: 6698
	[Token(Token = "0x4001A2A")]
	[FieldOffset(Offset = "0xD0")]
	private char[] call_sep_;

	// Token: 0x04001A2B RID: 6699
	[Token(Token = "0x4001A2B")]
	[FieldOffset(Offset = "0xD8")]
	private Dictionary<Type, Delegate> dictPushParam_;

	// Token: 0x04001A2C RID: 6700
	[Token(Token = "0x4001A2C")]
	[FieldOffset(Offset = "0xE0")]
	private List<XLuaManager.LuaValue> global_list_cache_;

	// Token: 0x04001A2D RID: 6701
	[Token(Token = "0x4001A2D")]
	[FieldOffset(Offset = "0xE8")]
	private byte[] global_byte_cache_;

	// Token: 0x02000389 RID: 905
	// (Invoke) Token: 0x06001759 RID: 5977
	[Token(Token = "0x2000389")]
	[CSharpCallLua]
	public delegate void onApplicationPause(bool pause);

	// Token: 0x0200038A RID: 906
	// (Invoke) Token: 0x0600175D RID: 5981
	[Token(Token = "0x200038A")]
	[CSharpCallLua]
	public delegate void onApplicationFocus(bool focus);

	// Token: 0x0200038B RID: 907
	// (Invoke) Token: 0x06001761 RID: 5985
	[Token(Token = "0x200038B")]
	[CSharpCallLua]
	public delegate void UITimeForLuaDelegate(long timeStamp);

	// Token: 0x0200038C RID: 908
	// (Invoke) Token: 0x06001765 RID: 5989
	[Token(Token = "0x200038C")]
	[CSharpCallLua]
	public delegate void UIShowTipsDelegate(string msg, string img, string atlas);

	// Token: 0x0200038D RID: 909
	// (Invoke) Token: 0x06001769 RID: 5993
	[Token(Token = "0x200038D")]
	[CSharpCallLua]
	public delegate void UIShowFoldUpBuild(string posX, string posY, string posZ, string bUuid);

	// Token: 0x0200038E RID: 910
	// (Invoke) Token: 0x0600176D RID: 5997
	[Token(Token = "0x200038E")]
	[CSharpCallLua]
	public delegate void UIShowMessageDelegate(string tipText, int btnNum, string text1, string text2, Action action1, Action action2, Action closeAction, string titleText, bool isChangeImg);

	// Token: 0x0200038F RID: 911
	// (Invoke) Token: 0x06001771 RID: 6001
	[Token(Token = "0x200038F")]
	[CSharpCallLua]
	public delegate void WebSocketProtocalDelegate(string data);

	// Token: 0x02000390 RID: 912
	// (Invoke) Token: 0x06001775 RID: 6005
	[Token(Token = "0x2000390")]
	[CSharpCallLua]
	public delegate string GetTemplateDataFromLua(string xmlId, int id, string attrStr);

	// Token: 0x02000391 RID: 913
	// (Invoke) Token: 0x06001779 RID: 6009
	[Token(Token = "0x2000391")]
	[CSharpCallLua]
	public delegate void UpdateResourceItemMaxValueDelegate();

	// Token: 0x02000392 RID: 914
	// (Invoke) Token: 0x0600177D RID: 6013
	[Token(Token = "0x2000392")]
	[CSharpCallLua]
	public delegate void PreloadAssetsDelegate();

	// Token: 0x02000393 RID: 915
	// (Invoke) Token: 0x06001781 RID: 6017
	[Token(Token = "0x2000393")]
	[CSharpCallLua]
	public delegate string GetBuildCfgForEditorDelegate(int a);

	// Token: 0x02000394 RID: 916
	// (Invoke) Token: 0x06001785 RID: 6021
	[Token(Token = "0x2000394")]
	[CSharpCallLua]
	public delegate string GetCfgForEditorDelegate(string tableName, int id);

	// Token: 0x02000395 RID: 917
	// (Invoke) Token: 0x06001789 RID: 6025
	[Token(Token = "0x2000395")]
	[CSharpCallLua]
	public delegate List<int> GetCfgIdsForEditorDelegate(string tableName);

	// Token: 0x02000396 RID: 918
	// (Invoke) Token: 0x0600178D RID: 6029
	[Token(Token = "0x2000396")]
	[CSharpCallLua]
	public delegate void LuaLoadPbConfig(byte[] bytes);

	// Token: 0x02000397 RID: 919
	// (Invoke) Token: 0x06001791 RID: 6033
	[Token(Token = "0x2000397")]
	[CSharpCallLua]
	public delegate void dispatchCSEvent(int eventId, object userData);

	// Token: 0x02000398 RID: 920
	[Token(Token = "0x2000398")]
	private enum LuaValueEnum
	{
		// Token: 0x04001A2F RID: 6703
		[Token(Token = "0x4001A2F")]
		V_Bool,
		// Token: 0x04001A30 RID: 6704
		[Token(Token = "0x4001A30")]
		V_Int,
		// Token: 0x04001A31 RID: 6705
		[Token(Token = "0x4001A31")]
		V_UInt,
		// Token: 0x04001A32 RID: 6706
		[Token(Token = "0x4001A32")]
		V_Long,
		// Token: 0x04001A33 RID: 6707
		[Token(Token = "0x4001A33")]
		V_ULong,
		// Token: 0x04001A34 RID: 6708
		[Token(Token = "0x4001A34")]
		V_Double,
		// Token: 0x04001A35 RID: 6709
		[Token(Token = "0x4001A35")]
		V_String,
		// Token: 0x04001A36 RID: 6710
		[Token(Token = "0x4001A36")]
		V_Obj
	}

	// Token: 0x02000399 RID: 921
	[Token(Token = "0x2000399")]
	private struct LuaValue
	{
		// Token: 0x04001A37 RID: 6711
		[Token(Token = "0x4001A37")]
		[FieldOffset(Offset = "0x0")]
		public XLuaManager.LuaValueEnum type;

		// Token: 0x04001A38 RID: 6712
		[Token(Token = "0x4001A38")]
		[FieldOffset(Offset = "0x4")]
		public bool bv;

		// Token: 0x04001A39 RID: 6713
		[Token(Token = "0x4001A39")]
		[FieldOffset(Offset = "0x8")]
		public long lv;

		// Token: 0x04001A3A RID: 6714
		[Token(Token = "0x4001A3A")]
		[FieldOffset(Offset = "0x10")]
		public ulong ulv;

		// Token: 0x04001A3B RID: 6715
		[Token(Token = "0x4001A3B")]
		[FieldOffset(Offset = "0x18")]
		public double dv;

		// Token: 0x04001A3C RID: 6716
		[Token(Token = "0x4001A3C")]
		[FieldOffset(Offset = "0x20")]
		public string sv;

		// Token: 0x04001A3D RID: 6717
		[Token(Token = "0x4001A3D")]
		[FieldOffset(Offset = "0x28")]
		public object ov;
	}

	// Token: 0x0200039A RID: 922
	[Token(Token = "0x200039A")]
	private struct CallContext
	{
		// Token: 0x04001A3E RID: 6718
		[Token(Token = "0x4001A3E")]
		[FieldOffset(Offset = "0x0")]
		public LuaTable table;

		// Token: 0x04001A3F RID: 6719
		[Token(Token = "0x4001A3F")]
		[FieldOffset(Offset = "0x8")]
		public LuaFunction function;

		// Token: 0x04001A40 RID: 6720
		[Token(Token = "0x4001A40")]
		[FieldOffset(Offset = "0x10")]
		public bool pushSelf;

		// Token: 0x04001A41 RID: 6721
		[Token(Token = "0x4001A41")]
		[FieldOffset(Offset = "0x18")]
		public List<XLuaManager.LuaValue> paras;
	}

	// Token: 0x0200039B RID: 923
	[Token(Token = "0x200039B")]
	public struct ByteString
	{
		// Token: 0x04001A42 RID: 6722
		[Token(Token = "0x4001A42")]
		[FieldOffset(Offset = "0x0")]
		public byte[] str;

		// Token: 0x04001A43 RID: 6723
		[Token(Token = "0x4001A43")]
		[FieldOffset(Offset = "0x8")]
		public int str_len;
	}

	// Token: 0x0200039C RID: 924
	[Token(Token = "0x200039C")]
	private class LuaTableLookup
	{
		// Token: 0x06001794 RID: 6036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001794")]
		[Address(RVA = "0x1DB3A28", Offset = "0x1DB3A28", VA = "0x1DB3A28")]
		public LuaTableLookup()
		{
		}

		// Token: 0x04001A44 RID: 6724
		[Token(Token = "0x4001A44")]
		[FieldOffset(Offset = "0x10")]
		public string tablePath;

		// Token: 0x04001A45 RID: 6725
		[Token(Token = "0x4001A45")]
		[FieldOffset(Offset = "0x18")]
		public LuaTable table;

		// Token: 0x04001A46 RID: 6726
		[Token(Token = "0x4001A46")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<uint, LuaFunction> funcs;
	}
}
