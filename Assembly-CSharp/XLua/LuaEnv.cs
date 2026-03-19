using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Unity.IL2CPP.CompilerServices;
using UnityEngine.Scripting;
using VEngine;
using XLua.LuaDLL;

namespace XLua
{
	// Token: 0x02000522 RID: 1314
	[Token(Token = "0x2000522")]
	[Preserve]
	[Il2CppSetOption(Option.NullChecks, false)]
	public class LuaEnv : IDisposable
	{
		// Token: 0x170005DD RID: 1501
		// (get) Token: 0x06002757 RID: 10071 RVA: 0x0000EE68 File Offset: 0x0000D068
		[Token(Token = "0x170005DD")]
		public IntPtr L
		{
			[Token(Token = "0x6002757")]
			[Address(RVA = "0x2B68CA4", Offset = "0x2B68CA4", VA = "0x2B68CA4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06002758 RID: 10072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002758")]
		[Address(RVA = "0x2B6AB18", Offset = "0x2B6AB18", VA = "0x2B6AB18")]
		public LuaEnv()
		{
		}

		// Token: 0x06002759 RID: 10073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002759")]
		[Address(RVA = "0x2B6BB60", Offset = "0x2B6BB60", VA = "0x2B6BB60")]
		public static void AddIniter(Action<LuaEnv, ObjectTranslator> initer)
		{
		}

		// Token: 0x170005DE RID: 1502
		// (get) Token: 0x0600275A RID: 10074 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005DE")]
		public LuaTable Global
		{
			[Token(Token = "0x600275A")]
			[Address(RVA = "0x2B6BC98", Offset = "0x2B6BC98", VA = "0x2B6BC98")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600275B RID: 10075 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600275B")]
		public T LoadString<T>(byte[] chunk, string chunkName = "chunk", [Optional] LuaTable env)
		{
			return null;
		}

		// Token: 0x0600275C RID: 10076 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600275C")]
		public T LoadString<T>(string chunk, string chunkName = "chunk", [Optional] LuaTable env)
		{
			return null;
		}

		// Token: 0x0600275D RID: 10077 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600275D")]
		[Address(RVA = "0x2B6BCA0", Offset = "0x2B6BCA0", VA = "0x2B6BCA0")]
		public LuaFunction LoadString(string chunk, string chunkName = "chunk", [Optional] LuaTable env)
		{
			return null;
		}

		// Token: 0x0600275E RID: 10078 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600275E")]
		[Address(RVA = "0x2B6BD10", Offset = "0x2B6BD10", VA = "0x2B6BD10")]
		public object[] DoString(byte[] chunk, string chunkName = "chunk", [Optional] LuaTable env)
		{
			return null;
		}

		// Token: 0x0600275F RID: 10079 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600275F")]
		[Address(RVA = "0x2B6BA2C", Offset = "0x2B6BA2C", VA = "0x2B6BA2C")]
		public object[] DoString(string chunk, string chunkName = "chunk", [Optional] LuaTable env)
		{
			return null;
		}

		// Token: 0x06002760 RID: 10080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002760")]
		[Address(RVA = "0x2B6B888", Offset = "0x2B6B888", VA = "0x2B6B888")]
		private void AddSearcher(lua_CSFunction searcher, int index)
		{
		}

		// Token: 0x06002761 RID: 10081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002761")]
		[Address(RVA = "0x2B6BE74", Offset = "0x2B6BE74", VA = "0x2B6BE74")]
		public void Alias(Type type, string alias)
		{
		}

		// Token: 0x06002762 RID: 10082 RVA: 0x0000EE80 File Offset: 0x0000D080
		[Token(Token = "0x6002762")]
		[Address(RVA = "0x2B6BE80", Offset = "0x2B6BE80", VA = "0x2B6BE80")]
		private static bool ObjectValidCheck(object obj)
		{
			return default(bool);
		}

		// Token: 0x06002763 RID: 10083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002763")]
		[Address(RVA = "0x2B6BF48", Offset = "0x2B6BF48", VA = "0x2B6BF48")]
		public void Tick()
		{
		}

		// Token: 0x06002764 RID: 10084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002764")]
		[Address(RVA = "0x2B6C094", Offset = "0x2B6C094", VA = "0x2B6C094")]
		public void GC()
		{
		}

		// Token: 0x06002765 RID: 10085 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002765")]
		[Address(RVA = "0x2B6C098", Offset = "0x2B6C098", VA = "0x2B6C098")]
		public LuaTable NewTable()
		{
			return null;
		}

		// Token: 0x06002766 RID: 10086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002766")]
		[Address(RVA = "0x2B6C1E4", Offset = "0x2B6C1E4", VA = "0x2B6C1E4", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x06002767 RID: 10087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002767")]
		[Address(RVA = "0x2B6C2DC", Offset = "0x2B6C2DC", VA = "0x2B6C2DC", Slot = "5")]
		public virtual void Dispose(bool dispose)
		{
		}

		// Token: 0x06002768 RID: 10088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002768")]
		[Address(RVA = "0x2B68A8C", Offset = "0x2B68A8C", VA = "0x2B68A8C")]
		public void ThrowExceptionFromError(int oldTop)
		{
		}

		// Token: 0x06002769 RID: 10089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002769")]
		[Address(RVA = "0x2B6A74C", Offset = "0x2B6A74C", VA = "0x2B6A74C")]
		internal void equeueGCAction(LuaEnv.GCAction action)
		{
		}

		// Token: 0x0600276A RID: 10090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600276A")]
		[Address(RVA = "0x2B6C438", Offset = "0x2B6C438", VA = "0x2B6C438")]
		public void AddLoader(LuaEnv.CustomLoader loader)
		{
		}

		// Token: 0x0600276B RID: 10091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600276B")]
		[Address(RVA = "0x2B6BA84", Offset = "0x2B6BA84", VA = "0x2B6BA84")]
		public void AddBuildin(string name, lua_CSFunction initer)
		{
		}

		// Token: 0x170005DF RID: 1503
		// (get) Token: 0x0600276C RID: 10092 RVA: 0x0000EE98 File Offset: 0x0000D098
		// (set) Token: 0x0600276D RID: 10093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005DF")]
		public int GcPause
		{
			[Token(Token = "0x600276C")]
			[Address(RVA = "0x2B6C4F0", Offset = "0x2B6C4F0", VA = "0x2B6C4F0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600276D")]
			[Address(RVA = "0x2B6C584", Offset = "0x2B6C584", VA = "0x2B6C584")]
			set
			{
			}
		}

		// Token: 0x170005E0 RID: 1504
		// (get) Token: 0x0600276E RID: 10094 RVA: 0x0000EEB0 File Offset: 0x0000D0B0
		// (set) Token: 0x0600276F RID: 10095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005E0")]
		public int GcStepmul
		{
			[Token(Token = "0x600276E")]
			[Address(RVA = "0x2B6C600", Offset = "0x2B6C600", VA = "0x2B6C600")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600276F")]
			[Address(RVA = "0x2B6C694", Offset = "0x2B6C694", VA = "0x2B6C694")]
			set
			{
			}
		}

		// Token: 0x06002770 RID: 10096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002770")]
		[Address(RVA = "0x2B6C26C", Offset = "0x2B6C26C", VA = "0x2B6C26C")]
		public void FullGc()
		{
		}

		// Token: 0x06002771 RID: 10097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002771")]
		[Address(RVA = "0x2B6C710", Offset = "0x2B6C710", VA = "0x2B6C710")]
		public void StopGc()
		{
		}

		// Token: 0x06002772 RID: 10098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002772")]
		[Address(RVA = "0x2B6C780", Offset = "0x2B6C780", VA = "0x2B6C780")]
		public void RestartGc()
		{
		}

		// Token: 0x06002773 RID: 10099 RVA: 0x0000EEC8 File Offset: 0x0000D0C8
		[Token(Token = "0x6002773")]
		[Address(RVA = "0x2B6C7F0", Offset = "0x2B6C7F0", VA = "0x2B6C7F0")]
		public bool GcStep(int data)
		{
			return default(bool);
		}

		// Token: 0x170005E1 RID: 1505
		// (get) Token: 0x06002774 RID: 10100 RVA: 0x0000EEE0 File Offset: 0x0000D0E0
		[Token(Token = "0x170005E1")]
		public int Memroy
		{
			[Token(Token = "0x6002774")]
			[Address(RVA = "0x2B6C878", Offset = "0x2B6C878", VA = "0x2B6C878")]
			get
			{
				return 0;
			}
		}

		// Token: 0x04002358 RID: 9048
		[Token(Token = "0x4002358")]
		public const string CSHARP_NAMESPACE = "xlua_csharp_namespace";

		// Token: 0x04002359 RID: 9049
		[Token(Token = "0x4002359")]
		public const string MAIN_SHREAD = "xlua_main_thread";

		// Token: 0x0400235A RID: 9050
		[Token(Token = "0x400235A")]
		[FieldOffset(Offset = "0x10")]
		internal IntPtr rawL;

		// Token: 0x0400235B RID: 9051
		[Token(Token = "0x400235B")]
		[FieldOffset(Offset = "0x18")]
		private LuaTable _G;

		// Token: 0x0400235C RID: 9052
		[Token(Token = "0x400235C")]
		[FieldOffset(Offset = "0x20")]
		public ObjectTranslator translator;

		// Token: 0x0400235D RID: 9053
		[Token(Token = "0x400235D")]
		[FieldOffset(Offset = "0x28")]
		public int errorFuncRef;

		// Token: 0x0400235E RID: 9054
		[Token(Token = "0x400235E")]
		private const int LIB_VERSION_EXPECT = 105;

		// Token: 0x0400235F RID: 9055
		[Token(Token = "0x400235F")]
		[FieldOffset(Offset = "0x0")]
		private static List<Action<LuaEnv, ObjectTranslator>> initers;

		// Token: 0x04002360 RID: 9056
		[Token(Token = "0x4002360")]
		[FieldOffset(Offset = "0x2C")]
		private int last_check_point;

		// Token: 0x04002361 RID: 9057
		[Token(Token = "0x4002361")]
		[FieldOffset(Offset = "0x30")]
		private int max_check_per_tick;

		// Token: 0x04002362 RID: 9058
		[Token(Token = "0x4002362")]
		[FieldOffset(Offset = "0x38")]
		private Func<object, bool> object_valid_checker;

		// Token: 0x04002363 RID: 9059
		[Token(Token = "0x4002363")]
		[FieldOffset(Offset = "0x40")]
		private bool disposed;

		// Token: 0x04002364 RID: 9060
		[Token(Token = "0x4002364")]
		[FieldOffset(Offset = "0x48")]
		private Queue<LuaEnv.GCAction> refQueue;

		// Token: 0x04002365 RID: 9061
		[Token(Token = "0x4002365")]
		[FieldOffset(Offset = "0x50")]
		private string init_xlua;

		// Token: 0x04002366 RID: 9062
		[Token(Token = "0x4002366")]
		[FieldOffset(Offset = "0x58")]
		internal List<LuaEnv.CustomLoader> customLoaders;

		// Token: 0x04002367 RID: 9063
		[Token(Token = "0x4002367")]
		[FieldOffset(Offset = "0x60")]
		internal Dictionary<string, lua_CSFunction> buildin_initer;

		// Token: 0x02000523 RID: 1315
		[Token(Token = "0x2000523")]
		internal struct GCAction
		{
			// Token: 0x04002368 RID: 9064
			[Token(Token = "0x4002368")]
			[FieldOffset(Offset = "0x0")]
			public int Reference;

			// Token: 0x04002369 RID: 9065
			[Token(Token = "0x4002369")]
			[FieldOffset(Offset = "0x4")]
			public bool IsDelegate;
		}

		// Token: 0x02000524 RID: 1316
		[Token(Token = "0x2000524")]
		public struct LuaFileInfo
		{
			// Token: 0x0400236A RID: 9066
			[Token(Token = "0x400236A")]
			[FieldOffset(Offset = "0x0")]
			public string filepath;

			// Token: 0x0400236B RID: 9067
			[Token(Token = "0x400236B")]
			[FieldOffset(Offset = "0x8")]
			public byte[] optionalBuf;

			// Token: 0x0400236C RID: 9068
			[Token(Token = "0x400236C")]
			[FieldOffset(Offset = "0x10")]
			public IntPtr nativeBufPtr;

			// Token: 0x0400236D RID: 9069
			[Token(Token = "0x400236D")]
			[FieldOffset(Offset = "0x18")]
			public long dataSize;

			// Token: 0x0400236E RID: 9070
			[Token(Token = "0x400236E")]
			[FieldOffset(Offset = "0x20")]
			public Asset assetRequest;

			// Token: 0x0400236F RID: 9071
			[Token(Token = "0x400236F")]
			[FieldOffset(Offset = "0x28")]
			public Action<Asset> checkIfReleaseAsset;
		}

		// Token: 0x02000525 RID: 1317
		// (Invoke) Token: 0x06002776 RID: 10102
		[Token(Token = "0x2000525")]
		public delegate LuaEnv.LuaFileInfo CustomLoader(ref string filepath);
	}
}
