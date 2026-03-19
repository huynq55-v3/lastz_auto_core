using System;
using System.Collections.Generic;
using System.Reflection;
using Il2CppDummyDll;
using Unity.IL2CPP.CompilerServices;
using UnityEngine.Scripting;
using XLua.LuaDLL;

namespace XLua
{
	// Token: 0x02000543 RID: 1347
	[Token(Token = "0x2000543")]
	[Il2CppSetOption(Option.NullChecks, false)]
	[Preserve]
	public class ObjectTranslator
	{
		// Token: 0x0600282E RID: 10286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600282E")]
		[Address(RVA = "0x26B652C", Offset = "0x26B652C", VA = "0x26B652C")]
		public void DelayWrapLoader(Type type, Action<IntPtr> loader)
		{
		}

		// Token: 0x0600282F RID: 10287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600282F")]
		[Address(RVA = "0x26B658C", Offset = "0x26B658C", VA = "0x26B658C")]
		public void AddInterfaceBridgeCreator(Type type, Func<int, LuaEnv, LuaBase> creator)
		{
		}

		// Token: 0x06002830 RID: 10288 RVA: 0x0000F288 File Offset: 0x0000D488
		[Token(Token = "0x6002830")]
		[Address(RVA = "0x26B65EC", Offset = "0x26B65EC", VA = "0x26B65EC")]
		public bool TryDelayWrapLoader(IntPtr L, Type type)
		{
			return default(bool);
		}

		// Token: 0x06002831 RID: 10289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002831")]
		[Address(RVA = "0x26B745C", Offset = "0x26B745C", VA = "0x26B745C")]
		public void Alias(Type type, string alias)
		{
		}

		// Token: 0x06002832 RID: 10290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002832")]
		[Address(RVA = "0x26B78BC", Offset = "0x26B78BC", VA = "0x26B78BC")]
		private void addAssemblieByName(IEnumerable<Assembly> assemblies_usorted, string name)
		{
		}

		// Token: 0x06002833 RID: 10291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002833")]
		[Address(RVA = "0x26B7C54", Offset = "0x26B7C54", VA = "0x26B7C54")]
		public ObjectTranslator(LuaEnv luaenv, IntPtr L)
		{
		}

		// Token: 0x06002834 RID: 10292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002834")]
		[Address(RVA = "0x26B8978", Offset = "0x26B8978", VA = "0x26B8978")]
		private void initCSharpCallLua()
		{
		}

		// Token: 0x06002835 RID: 10293 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002835")]
		[Address(RVA = "0x26B8A60", Offset = "0x26B8A60", VA = "0x26B8A60")]
		private Func<DelegateBridgeBase, Delegate> getCreatorUsingGeneric(DelegateBridgeBase bridge, Type delegateType, MethodInfo delegateMethod)
		{
			return null;
		}

		// Token: 0x06002836 RID: 10294 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002836")]
		[Address(RVA = "0x26B9494", Offset = "0x26B9494", VA = "0x26B9494")]
		private Delegate getDelegate(DelegateBridgeBase bridge, Type delegateType)
		{
			return null;
		}

		// Token: 0x06002837 RID: 10295 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002837")]
		[Address(RVA = "0x26AEDFC", Offset = "0x26AEDFC", VA = "0x26AEDFC")]
		public object CreateDelegateBridge(IntPtr L, Type delegateType, int idx)
		{
			return null;
		}

		// Token: 0x06002838 RID: 10296 RVA: 0x0000F2A0 File Offset: 0x0000D4A0
		[Token(Token = "0x6002838")]
		[Address(RVA = "0x26BA1B8", Offset = "0x26BA1B8", VA = "0x26BA1B8")]
		public bool AllDelegateBridgeReleased()
		{
			return default(bool);
		}

		// Token: 0x06002839 RID: 10297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002839")]
		[Address(RVA = "0x26BA320", Offset = "0x26BA320", VA = "0x26BA320")]
		public void ReleaseLuaBase(IntPtr L, int reference, bool is_delegate)
		{
		}

		// Token: 0x0600283A RID: 10298 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600283A")]
		[Address(RVA = "0x26B3B74", Offset = "0x26B3B74", VA = "0x26B3B74")]
		public object CreateInterfaceBridge(IntPtr L, Type interfaceType, int idx)
		{
			return null;
		}

		// Token: 0x0600283B RID: 10299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600283B")]
		[Address(RVA = "0x26BA514", Offset = "0x26BA514", VA = "0x26BA514")]
		public void CreateArrayMetatable(IntPtr L)
		{
		}

		// Token: 0x0600283C RID: 10300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600283C")]
		[Address(RVA = "0x26BB0E0", Offset = "0x26BB0E0", VA = "0x26BB0E0")]
		public void CreateDelegateMetatable(IntPtr L)
		{
		}

		// Token: 0x0600283D RID: 10301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600283D")]
		[Address(RVA = "0x26BB308", Offset = "0x26BB308", VA = "0x26BB308")]
		internal void CreateEnumerablePairs(IntPtr L)
		{
		}

		// Token: 0x0600283E RID: 10302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600283E")]
		[Address(RVA = "0x26BB43C", Offset = "0x26BB43C", VA = "0x26BB43C")]
		public void OpenLib(IntPtr L)
		{
		}

		// Token: 0x0600283F RID: 10303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600283F")]
		[Address(RVA = "0x26BB9FC", Offset = "0x26BB9FC", VA = "0x26BB9FC")]
		internal void createFunctionMetatable(IntPtr L)
		{
		}

		// Token: 0x06002840 RID: 10304 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002840")]
		[Address(RVA = "0x26B7560", Offset = "0x26B7560", VA = "0x26B7560")]
		internal Type FindType(string className, bool isQualifiedName = false)
		{
			return null;
		}

		// Token: 0x06002841 RID: 10305 RVA: 0x0000F2B8 File Offset: 0x0000D4B8
		[Token(Token = "0x6002841")]
		[Address(RVA = "0x26BBBBC", Offset = "0x26BBBBC", VA = "0x26BBBBC")]
		private bool hasMethod(Type type, string methodName)
		{
			return default(bool);
		}

		// Token: 0x06002842 RID: 10306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002842")]
		[Address(RVA = "0x26BBC60", Offset = "0x26BBC60", VA = "0x26BBC60")]
		internal void collectObject(int obj_index_to_collect)
		{
		}

		// Token: 0x06002843 RID: 10307 RVA: 0x0000F2D0 File Offset: 0x0000D4D0
		[Token(Token = "0x6002843")]
		[Address(RVA = "0x26BBD68", Offset = "0x26BBD68", VA = "0x26BBD68")]
		private int addObject(object obj, bool is_valuetype, bool is_enum)
		{
			return 0;
		}

		// Token: 0x06002844 RID: 10308 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002844")]
		[Address(RVA = "0x26A9F60", Offset = "0x26A9F60", VA = "0x26A9F60")]
		public object GetObject(IntPtr L, int index)
		{
			return null;
		}

		// Token: 0x06002845 RID: 10309 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002845")]
		[Address(RVA = "0x26B0EF8", Offset = "0x26B0EF8", VA = "0x26B0EF8")]
		public Type GetTypeOf(IntPtr L, int idx)
		{
			return null;
		}

		// Token: 0x06002846 RID: 10310 RVA: 0x0000F2E8 File Offset: 0x0000D4E8
		[Token(Token = "0x6002846")]
		public bool Assignable<T>(IntPtr L, int index)
		{
			return default(bool);
		}

		// Token: 0x06002847 RID: 10311 RVA: 0x0000F300 File Offset: 0x0000D500
		[Token(Token = "0x6002847")]
		[Address(RVA = "0x26B56D4", Offset = "0x26B56D4", VA = "0x26B56D4")]
		public bool Assignable(IntPtr L, int index, Type type)
		{
			return default(bool);
		}

		// Token: 0x06002848 RID: 10312 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002848")]
		[Address(RVA = "0x26AEB54", Offset = "0x26AEB54", VA = "0x26AEB54")]
		public object GetObject(IntPtr L, int index, Type type)
		{
			return null;
		}

		// Token: 0x06002849 RID: 10313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002849")]
		public void Get<T>(IntPtr L, int index, out T v)
		{
		}

		// Token: 0x0600284A RID: 10314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600284A")]
		public void PushByType<T>(IntPtr L, T v)
		{
		}

		// Token: 0x0600284B RID: 10315 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600284B")]
		public T[] GetParams<T>(IntPtr L, int index)
		{
			return null;
		}

		// Token: 0x0600284C RID: 10316 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600284C")]
		[Address(RVA = "0x26ABDD4", Offset = "0x26ABDD4", VA = "0x26ABDD4")]
		public Array GetParams(IntPtr L, int index, Type type)
		{
			return null;
		}

		// Token: 0x0600284D RID: 10317 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600284D")]
		public T GetDelegate<T>(IntPtr L, int index) where T : class
		{
			return null;
		}

		// Token: 0x0600284E RID: 10318 RVA: 0x0000F318 File Offset: 0x0000D518
		[Token(Token = "0x600284E")]
		[Address(RVA = "0x26B7444", Offset = "0x26B7444", VA = "0x26B7444")]
		public int GetTypeId(IntPtr L, Type type)
		{
			return 0;
		}

		// Token: 0x0600284F RID: 10319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600284F")]
		[Address(RVA = "0x26BC398", Offset = "0x26BC398", VA = "0x26BC398")]
		public void PrivateAccessible(IntPtr L, Type type)
		{
		}

		// Token: 0x06002850 RID: 10320 RVA: 0x0000F330 File Offset: 0x0000D530
		[Token(Token = "0x6002850")]
		[Address(RVA = "0x26BBDF8", Offset = "0x26BBDF8", VA = "0x26BBDF8")]
		public int getTypeId(IntPtr L, Type type, out bool is_first)
		{
			return 0;
		}

		// Token: 0x06002851 RID: 10321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002851")]
		[Address(RVA = "0x26BC930", Offset = "0x26BC930", VA = "0x26BC930")]
		private void pushPrimitive(IntPtr L, object o)
		{
		}

		// Token: 0x06002852 RID: 10322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002852")]
		[Address(RVA = "0x26AC088", Offset = "0x26AC088", VA = "0x26AC088")]
		public void PushAny(IntPtr L, object o)
		{
		}

		// Token: 0x06002853 RID: 10323 RVA: 0x0000F348 File Offset: 0x0000D548
		[Token(Token = "0x6002853")]
		[Address(RVA = "0x26BD2D0", Offset = "0x26BD2D0", VA = "0x26BD2D0")]
		public int TranslateToEnumToTop(IntPtr L, Type type, int idx)
		{
			return 0;
		}

		// Token: 0x06002854 RID: 10324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002854")]
		[Address(RVA = "0x26BCFDC", Offset = "0x26BCFDC", VA = "0x26BCFDC")]
		public void Push(IntPtr L, lua_CSFunction o)
		{
		}

		// Token: 0x06002855 RID: 10325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002855")]
		[Address(RVA = "0x26BD528", Offset = "0x26BD528", VA = "0x26BD528")]
		public void Push(IntPtr L, LuaBase o)
		{
		}

		// Token: 0x06002856 RID: 10326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002856")]
		[Address(RVA = "0x26BD0B4", Offset = "0x26BD0B4", VA = "0x26BD0B4")]
		public void Push(IntPtr L, object o)
		{
		}

		// Token: 0x06002857 RID: 10327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002857")]
		[Address(RVA = "0x26BD5A4", Offset = "0x26BD5A4", VA = "0x26BD5A4")]
		public void PushObject(IntPtr L, object o, int type_id)
		{
		}

		// Token: 0x06002858 RID: 10328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002858")]
		[Address(RVA = "0x26ABEF8", Offset = "0x26ABEF8", VA = "0x26ABEF8")]
		public void Update(IntPtr L, int index, object obj)
		{
		}

		// Token: 0x06002859 RID: 10329 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002859")]
		[Address(RVA = "0x26BD6E8", Offset = "0x26BD6E8", VA = "0x26BD6E8")]
		private object getCsObj(IntPtr L, int index, int udata)
		{
			return null;
		}

		// Token: 0x0600285A RID: 10330 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600285A")]
		[Address(RVA = "0x26B01D8", Offset = "0x26B01D8", VA = "0x26B01D8")]
		internal object SafeGetCSObj(IntPtr L, int index)
		{
			return null;
		}

		// Token: 0x0600285B RID: 10331 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600285B")]
		[Address(RVA = "0x26ABD54", Offset = "0x26ABD54", VA = "0x26ABD54")]
		public object FastGetCSObj(IntPtr L, int index)
		{
			return null;
		}

		// Token: 0x0600285C RID: 10332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600285C")]
		[Address(RVA = "0x26BD8F8", Offset = "0x26BD8F8", VA = "0x26BD8F8")]
		internal void ReleaseCSObj(IntPtr L, int index)
		{
		}

		// Token: 0x0600285D RID: 10333 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600285D")]
		[Address(RVA = "0x26BD9E0", Offset = "0x26BD9E0", VA = "0x26BD9E0")]
		internal lua_CSFunction GetFixCSFunction(int index)
		{
			return null;
		}

		// Token: 0x0600285E RID: 10334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600285E")]
		[Address(RVA = "0x26BDA38", Offset = "0x26BDA38", VA = "0x26BDA38")]
		internal void PushFixCSFunction(IntPtr L, lua_CSFunction func)
		{
		}

		// Token: 0x0600285F RID: 10335 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600285F")]
		[Address(RVA = "0x26BDB78", Offset = "0x26BDB78", VA = "0x26BDB78")]
		internal object[] popValues(IntPtr L, int oldTop)
		{
			return null;
		}

		// Token: 0x06002860 RID: 10336 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002860")]
		[Address(RVA = "0x26BDCA4", Offset = "0x26BDCA4", VA = "0x26BDCA4")]
		internal object[] popValues(IntPtr L, int oldTop, Type[] popTypes)
		{
			return null;
		}

		// Token: 0x06002861 RID: 10337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002861")]
		[Address(RVA = "0x26BDE68", Offset = "0x26BDE68", VA = "0x26BDE68")]
		private void registerCustomOp(Type type, ObjectTranslator.PushCSObject push, ObjectTranslator.GetCSObject get, ObjectTranslator.UpdateCSObject update)
		{
		}

		// Token: 0x06002862 RID: 10338 RVA: 0x0000F360 File Offset: 0x0000D560
		[Token(Token = "0x6002862")]
		[Address(RVA = "0x26BDF48", Offset = "0x26BDF48", VA = "0x26BDF48")]
		public bool HasCustomOp(Type type)
		{
			return default(bool);
		}

		// Token: 0x06002863 RID: 10339 RVA: 0x0000F378 File Offset: 0x0000D578
		[Token(Token = "0x6002863")]
		private bool tryGetPushFuncByType<T>(Type type, out T func) where T : class
		{
			return default(bool);
		}

		// Token: 0x06002864 RID: 10340 RVA: 0x0000F390 File Offset: 0x0000D590
		[Token(Token = "0x6002864")]
		private bool tryGetGetFuncByType<T>(Type type, out T func) where T : class
		{
			return default(bool);
		}

		// Token: 0x06002865 RID: 10341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002865")]
		public void RegisterPushAndGetAndUpdate<T>(Action<IntPtr, T> push, ObjectTranslator.GetFunc<T> get, Action<IntPtr, int, T> update)
		{
		}

		// Token: 0x06002866 RID: 10342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002866")]
		public void RegisterChecker<T>(ObjectTranslator.CheckFunc<T> check)
		{
		}

		// Token: 0x06002867 RID: 10343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002867")]
		public void RegisterCaster<T>(ObjectTranslator.GetFunc<T> get)
		{
		}

		// Token: 0x06002868 RID: 10344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002868")]
		[Address(RVA = "0x26BCE44", Offset = "0x26BCE44", VA = "0x26BCE44")]
		public void PushDecimal(IntPtr L, decimal val)
		{
		}

		// Token: 0x06002869 RID: 10345 RVA: 0x0000F3A8 File Offset: 0x0000D5A8
		[Token(Token = "0x6002869")]
		[Address(RVA = "0x26B036C", Offset = "0x26B036C", VA = "0x26B036C")]
		public bool IsDecimal(IntPtr L, int index)
		{
			return default(bool);
		}

		// Token: 0x0600286A RID: 10346 RVA: 0x0000F3C0 File Offset: 0x0000D5C0
		[Token(Token = "0x600286A")]
		[Address(RVA = "0x26BDFA0", Offset = "0x26BDFA0", VA = "0x26BDFA0")]
		public decimal GetDecimal(IntPtr L, int index)
		{
			return default(decimal);
		}

		// Token: 0x0600286B RID: 10347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600286B")]
		[Address(RVA = "0x26B24E8", Offset = "0x26B24E8", VA = "0x26B24E8")]
		public void Get(IntPtr L, int index, out decimal val)
		{
		}

		// Token: 0x0600286C RID: 10348 RVA: 0x0000F3D8 File Offset: 0x0000D5D8
		[Token(Token = "0x600286C")]
		public bool AddPushByteFunc<T>(Type t, Action<IntPtr, T> func)
		{
			return default(bool);
		}

		// Token: 0x0600286D RID: 10349 RVA: 0x0000F3F0 File Offset: 0x0000D5F0
		[Token(Token = "0x600286D")]
		[Address(RVA = "0x26BDFE4", Offset = "0x26BDFE4", VA = "0x26BDFE4")]
		public bool AddCustomFunc(Type t, ObjectTranslator.PushCSObject func)
		{
			return default(bool);
		}

		// Token: 0x0600286E RID: 10350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600286E")]
		[Address(RVA = "0x26BE050", Offset = "0x26BE050", VA = "0x26BE050")]
		public void PushByType(IntPtr L, int v)
		{
		}

		// Token: 0x0600286F RID: 10351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600286F")]
		[Address(RVA = "0x26BE0B8", Offset = "0x26BE0B8", VA = "0x26BE0B8")]
		public void PushByType(IntPtr L, double v)
		{
		}

		// Token: 0x06002870 RID: 10352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002870")]
		[Address(RVA = "0x26BE120", Offset = "0x26BE120", VA = "0x26BE120")]
		public void PushByType(IntPtr L, string v)
		{
		}

		// Token: 0x06002871 RID: 10353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002871")]
		[Address(RVA = "0x26BE188", Offset = "0x26BE188", VA = "0x26BE188")]
		public void PushByType(IntPtr L, byte[] v)
		{
		}

		// Token: 0x06002872 RID: 10354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002872")]
		[Address(RVA = "0x26BE1F0", Offset = "0x26BE1F0", VA = "0x26BE1F0")]
		public void PushByType(IntPtr L, bool v)
		{
		}

		// Token: 0x06002873 RID: 10355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002873")]
		[Address(RVA = "0x26BE258", Offset = "0x26BE258", VA = "0x26BE258")]
		public void PushByType(IntPtr L, long v)
		{
		}

		// Token: 0x06002874 RID: 10356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002874")]
		[Address(RVA = "0x26BE2C0", Offset = "0x26BE2C0", VA = "0x26BE2C0")]
		public void PushByType(IntPtr L, ulong v)
		{
		}

		// Token: 0x06002875 RID: 10357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002875")]
		[Address(RVA = "0x26BE328", Offset = "0x26BE328", VA = "0x26BE328")]
		public void PushByType(IntPtr L, uint v)
		{
		}

		// Token: 0x06002876 RID: 10358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002876")]
		[Address(RVA = "0x26BE390", Offset = "0x26BE390", VA = "0x26BE390")]
		public void PushByType(IntPtr L, float v)
		{
		}

		// Token: 0x06002877 RID: 10359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002877")]
		[Address(RVA = "0x26BE3F8", Offset = "0x26BE3F8", VA = "0x26BE3F8")]
		public void PushByType(IntPtr L, XLuaManager.ByteString v)
		{
		}

		// Token: 0x06002878 RID: 10360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002878")]
		[Address(RVA = "0x26BE468", Offset = "0x26BE468", VA = "0x26BE468")]
		public void PushByType(IntPtr L, EventId val)
		{
		}

		// Token: 0x06002879 RID: 10361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002879")]
		[Address(RVA = "0x26BE4D0", Offset = "0x26BE4D0", VA = "0x26BE4D0")]
		public void Get(IntPtr L, int index, out int v)
		{
		}

		// Token: 0x0600287A RID: 10362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600287A")]
		[Address(RVA = "0x26BE544", Offset = "0x26BE544", VA = "0x26BE544")]
		public void Get(IntPtr L, int index, out double v)
		{
		}

		// Token: 0x0600287B RID: 10363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600287B")]
		[Address(RVA = "0x26BE5B8", Offset = "0x26BE5B8", VA = "0x26BE5B8")]
		public void Get(IntPtr L, int index, out string v)
		{
		}

		// Token: 0x0600287C RID: 10364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600287C")]
		[Address(RVA = "0x26BE634", Offset = "0x26BE634", VA = "0x26BE634")]
		public void Get(IntPtr L, int index, out byte[] v)
		{
		}

		// Token: 0x0600287D RID: 10365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600287D")]
		[Address(RVA = "0x26BE6B0", Offset = "0x26BE6B0", VA = "0x26BE6B0")]
		public void Get(IntPtr L, int index, out bool v)
		{
		}

		// Token: 0x0600287E RID: 10366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600287E")]
		[Address(RVA = "0x26BE728", Offset = "0x26BE728", VA = "0x26BE728")]
		public void Get(IntPtr L, int index, out long v)
		{
		}

		// Token: 0x0600287F RID: 10367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600287F")]
		[Address(RVA = "0x26BE79C", Offset = "0x26BE79C", VA = "0x26BE79C")]
		public void Get(IntPtr L, int index, out ulong v)
		{
		}

		// Token: 0x06002880 RID: 10368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002880")]
		[Address(RVA = "0x26BE810", Offset = "0x26BE810", VA = "0x26BE810")]
		public void Get(IntPtr L, int index, out uint v)
		{
		}

		// Token: 0x06002881 RID: 10369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002881")]
		[Address(RVA = "0x26BE884", Offset = "0x26BE884", VA = "0x26BE884")]
		public void Get(IntPtr L, int index, out float v)
		{
		}

		// Token: 0x06002882 RID: 10370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002882")]
		[Address(RVA = "0x26BE8FC", Offset = "0x26BE8FC", VA = "0x26BE8FC")]
		public void Get(IntPtr L, int index, out EventId val)
		{
		}

		// Token: 0x040023E6 RID: 9190
		[Token(Token = "0x40023E6")]
		[FieldOffset(Offset = "0x10")]
		internal MethodWrapsCache methodWrapsCache;

		// Token: 0x040023E7 RID: 9191
		[Token(Token = "0x40023E7")]
		[FieldOffset(Offset = "0x18")]
		internal ObjectCheckers objectCheckers;

		// Token: 0x040023E8 RID: 9192
		[Token(Token = "0x40023E8")]
		[FieldOffset(Offset = "0x20")]
		public ObjectCasters objectCasters;

		// Token: 0x040023E9 RID: 9193
		[Token(Token = "0x40023E9")]
		[FieldOffset(Offset = "0x28")]
		internal readonly ObjectPool objects;

		// Token: 0x040023EA RID: 9194
		[Token(Token = "0x40023EA")]
		[FieldOffset(Offset = "0x30")]
		internal readonly Dictionary<object, int> reverseMap;

		// Token: 0x040023EB RID: 9195
		[Token(Token = "0x40023EB")]
		[FieldOffset(Offset = "0x38")]
		internal LuaEnv luaEnv;

		// Token: 0x040023EC RID: 9196
		[Token(Token = "0x40023EC")]
		[FieldOffset(Offset = "0x40")]
		internal StaticLuaCallbacks metaFunctions;

		// Token: 0x040023ED RID: 9197
		[Token(Token = "0x40023ED")]
		[FieldOffset(Offset = "0x48")]
		internal List<Assembly> assemblies;

		// Token: 0x040023EE RID: 9198
		[Token(Token = "0x40023EE")]
		[FieldOffset(Offset = "0x50")]
		private lua_CSFunction importTypeFunction;

		// Token: 0x040023EF RID: 9199
		[Token(Token = "0x40023EF")]
		[FieldOffset(Offset = "0x58")]
		private lua_CSFunction loadAssemblyFunction;

		// Token: 0x040023F0 RID: 9200
		[Token(Token = "0x40023F0")]
		[FieldOffset(Offset = "0x60")]
		private lua_CSFunction castFunction;

		// Token: 0x040023F1 RID: 9201
		[Token(Token = "0x40023F1")]
		[FieldOffset(Offset = "0x68")]
		private readonly Dictionary<Type, Action<IntPtr>> delayWrap;

		// Token: 0x040023F2 RID: 9202
		[Token(Token = "0x40023F2")]
		[FieldOffset(Offset = "0x70")]
		private readonly Dictionary<Type, Func<int, LuaEnv, LuaBase>> interfaceBridgeCreators;

		// Token: 0x040023F3 RID: 9203
		[Token(Token = "0x40023F3")]
		[FieldOffset(Offset = "0x78")]
		private readonly Dictionary<Type, Type> aliasCfg;

		// Token: 0x040023F4 RID: 9204
		[Token(Token = "0x40023F4")]
		[FieldOffset(Offset = "0x80")]
		private Dictionary<Type, bool> loaded_types;

		// Token: 0x040023F5 RID: 9205
		[Token(Token = "0x40023F5")]
		[FieldOffset(Offset = "0x88")]
		public int cacheRef;

		// Token: 0x040023F6 RID: 9206
		[Token(Token = "0x40023F6")]
		[FieldOffset(Offset = "0x90")]
		private Type delegate_birdge_type;

		// Token: 0x040023F7 RID: 9207
		[Token(Token = "0x40023F7")]
		[FieldOffset(Offset = "0x98")]
		private MethodInfo[] genericAction;

		// Token: 0x040023F8 RID: 9208
		[Token(Token = "0x40023F8")]
		[FieldOffset(Offset = "0xA0")]
		private MethodInfo[] genericFunc;

		// Token: 0x040023F9 RID: 9209
		[Token(Token = "0x40023F9")]
		[FieldOffset(Offset = "0xA8")]
		private Dictionary<Type, Func<DelegateBridgeBase, Delegate>> delegateCreatorCache;

		// Token: 0x040023FA RID: 9210
		[Token(Token = "0x40023FA")]
		[FieldOffset(Offset = "0xB0")]
		private Dictionary<int, WeakReference> delegate_bridges;

		// Token: 0x040023FB RID: 9211
		[Token(Token = "0x40023FB")]
		[FieldOffset(Offset = "0xB8")]
		private int common_array_meta;

		// Token: 0x040023FC RID: 9212
		[Token(Token = "0x40023FC")]
		[FieldOffset(Offset = "0xBC")]
		private int common_delegate_meta;

		// Token: 0x040023FD RID: 9213
		[Token(Token = "0x40023FD")]
		[FieldOffset(Offset = "0xC0")]
		private int enumerable_pairs_func;

		// Token: 0x040023FE RID: 9214
		[Token(Token = "0x40023FE")]
		[FieldOffset(Offset = "0xC8")]
		private Dictionary<Type, int> typeIdMap;

		// Token: 0x040023FF RID: 9215
		[Token(Token = "0x40023FF")]
		[FieldOffset(Offset = "0xD0")]
		private Dictionary<int, Type> typeMap;

		// Token: 0x04002400 RID: 9216
		[Token(Token = "0x4002400")]
		[FieldOffset(Offset = "0xD8")]
		private HashSet<Type> privateAccessibleFlags;

		// Token: 0x04002401 RID: 9217
		[Token(Token = "0x4002401")]
		[FieldOffset(Offset = "0xE0")]
		private Dictionary<object, int> enumMap;

		// Token: 0x04002402 RID: 9218
		[Token(Token = "0x4002402")]
		[FieldOffset(Offset = "0xE8")]
		private List<lua_CSFunction> fix_cs_functions;

		// Token: 0x04002403 RID: 9219
		[Token(Token = "0x4002403")]
		[FieldOffset(Offset = "0xF0")]
		private Dictionary<Type, ObjectTranslator.PushCSObject> custom_push_funcs;

		// Token: 0x04002404 RID: 9220
		[Token(Token = "0x4002404")]
		[FieldOffset(Offset = "0xF8")]
		private Dictionary<Type, ObjectTranslator.GetCSObject> custom_get_funcs;

		// Token: 0x04002405 RID: 9221
		[Token(Token = "0x4002405")]
		[FieldOffset(Offset = "0x100")]
		private Dictionary<Type, ObjectTranslator.UpdateCSObject> custom_update_funcs;

		// Token: 0x04002406 RID: 9222
		[Token(Token = "0x4002406")]
		[FieldOffset(Offset = "0x108")]
		private Dictionary<Type, Delegate> push_func_with_type;

		// Token: 0x04002407 RID: 9223
		[Token(Token = "0x4002407")]
		[FieldOffset(Offset = "0x110")]
		private Dictionary<Type, Delegate> get_func_with_type;

		// Token: 0x04002408 RID: 9224
		[Token(Token = "0x4002408")]
		[FieldOffset(Offset = "0x118")]
		private int decimal_type_id;

		// Token: 0x02000544 RID: 1348
		// (Invoke) Token: 0x06002885 RID: 10373
		[Token(Token = "0x2000544")]
		public delegate void PushCSObject(IntPtr L, object obj);

		// Token: 0x02000545 RID: 1349
		// (Invoke) Token: 0x06002889 RID: 10377
		[Token(Token = "0x2000545")]
		public delegate object GetCSObject(IntPtr L, int idx);

		// Token: 0x02000546 RID: 1350
		// (Invoke) Token: 0x0600288D RID: 10381
		[Token(Token = "0x2000546")]
		public delegate void UpdateCSObject(IntPtr L, int idx, object obj);

		// Token: 0x02000547 RID: 1351
		// (Invoke) Token: 0x06002891 RID: 10385
		[Token(Token = "0x2000547")]
		public delegate bool CheckFunc<T>(IntPtr L, int idx);

		// Token: 0x02000548 RID: 1352
		// (Invoke) Token: 0x06002895 RID: 10389
		[Token(Token = "0x2000548")]
		public delegate void GetFunc<T>(IntPtr L, int idx, out T val);
	}
}
