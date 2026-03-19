using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000044 RID: 68
[Token(Token = "0x2000044")]
public static class TouchObjectEvent
{
	// Token: 0x060000CE RID: 206 RVA: 0x000021F0 File Offset: 0x000003F0
	[Token(Token = "0x60000CE")]
	[Address(RVA = "0x15EA87C", Offset = "0x15EA87C", VA = "0x15EA87C")]
	public static bool Execute(ITouchObjectClickHandler handler)
	{
		return default(bool);
	}

	// Token: 0x060000CF RID: 207 RVA: 0x00002208 File Offset: 0x00000408
	[Token(Token = "0x60000CF")]
	[Address(RVA = "0x15EA918", Offset = "0x15EA918", VA = "0x15EA918")]
	public static bool Execute(ITouchObjectDoubleClickHandler handler)
	{
		return default(bool);
	}

	// Token: 0x060000D0 RID: 208 RVA: 0x00002220 File Offset: 0x00000420
	[Token(Token = "0x60000D0")]
	[Address(RVA = "0x15EA9B4", Offset = "0x15EA9B4", VA = "0x15EA9B4")]
	public static bool Execute(ITouchObjectBeginLongTabHandler handler)
	{
		return default(bool);
	}

	// Token: 0x060000D1 RID: 209 RVA: 0x00002238 File Offset: 0x00000438
	[Token(Token = "0x60000D1")]
	[Address(RVA = "0x15EAA50", Offset = "0x15EAA50", VA = "0x15EAA50")]
	public static bool Execute(ITouchObjectEndLongTabHandler handler)
	{
		return default(bool);
	}

	// Token: 0x060000D2 RID: 210 RVA: 0x00002250 File Offset: 0x00000450
	[Token(Token = "0x60000D2")]
	[Address(RVA = "0x15EAAEC", Offset = "0x15EAAEC", VA = "0x15EAAEC")]
	public static bool Execute(ITouchObjectPointerDownHandler handler)
	{
		return default(bool);
	}

	// Token: 0x060000D3 RID: 211 RVA: 0x00002268 File Offset: 0x00000468
	[Token(Token = "0x60000D3")]
	[Address(RVA = "0x15EAB88", Offset = "0x15EAB88", VA = "0x15EAB88")]
	public static bool Execute(ITouchObjectPointerUpHandler handler)
	{
		return default(bool);
	}

	// Token: 0x060000D4 RID: 212 RVA: 0x00002280 File Offset: 0x00000480
	[Token(Token = "0x60000D4")]
	public static bool Execute<T>(ITouchObject obj, TouchObjectEvent.EventFunction<T> functor) where T : ITouchObject
	{
		return default(bool);
	}

	// Token: 0x060000D5 RID: 213 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000D5")]
	public static ITouchObject GetFirstEventObject<T>(List<ITouchObject> objs)
	{
		return null;
	}

	// Token: 0x060000D6 RID: 214 RVA: 0x00002298 File Offset: 0x00000498
	[Token(Token = "0x60000D6")]
	[Address(RVA = "0x15EAC24", Offset = "0x15EAC24", VA = "0x15EAC24")]
	public static bool ExecuteClick(ITouchObject obj)
	{
		return default(bool);
	}

	// Token: 0x060000D7 RID: 215 RVA: 0x000022B0 File Offset: 0x000004B0
	[Token(Token = "0x60000D7")]
	[Address(RVA = "0x15EAC9C", Offset = "0x15EAC9C", VA = "0x15EAC9C")]
	public static bool ExecuteDoubleClick(ITouchObject obj)
	{
		return default(bool);
	}

	// Token: 0x060000D8 RID: 216 RVA: 0x000022C8 File Offset: 0x000004C8
	[Token(Token = "0x60000D8")]
	[Address(RVA = "0x15EAD14", Offset = "0x15EAD14", VA = "0x15EAD14")]
	public static bool ExecuteBeginDrag(ITouchObject obj, Vector3 dragStartPos)
	{
		return default(bool);
	}

	// Token: 0x060000D9 RID: 217 RVA: 0x000022E0 File Offset: 0x000004E0
	[Token(Token = "0x60000D9")]
	[Address(RVA = "0x15EADF8", Offset = "0x15EADF8", VA = "0x15EADF8")]
	public static bool ExecuteDrag(ITouchObject obj, Vector3 dragStartPos, Vector3 dragCurrPos)
	{
		return default(bool);
	}

	// Token: 0x060000DA RID: 218 RVA: 0x000022F8 File Offset: 0x000004F8
	[Token(Token = "0x60000DA")]
	[Address(RVA = "0x15EAF00", Offset = "0x15EAF00", VA = "0x15EAF00")]
	public static bool ExecuteEndDrag(ITouchObject obj, Vector3 dragStopPos)
	{
		return default(bool);
	}

	// Token: 0x060000DB RID: 219 RVA: 0x00002310 File Offset: 0x00000510
	[Token(Token = "0x60000DB")]
	[Address(RVA = "0x15EAFE4", Offset = "0x15EAFE4", VA = "0x15EAFE4")]
	public static bool ExecuteBeginLongTab(ITouchObject obj)
	{
		return default(bool);
	}

	// Token: 0x060000DC RID: 220 RVA: 0x00002328 File Offset: 0x00000528
	[Token(Token = "0x60000DC")]
	[Address(RVA = "0x15EB05C", Offset = "0x15EB05C", VA = "0x15EB05C")]
	public static bool ExecuteEndLongTab(ITouchObject obj)
	{
		return default(bool);
	}

	// Token: 0x060000DD RID: 221 RVA: 0x00002340 File Offset: 0x00000540
	[Token(Token = "0x60000DD")]
	[Address(RVA = "0x15EB0D4", Offset = "0x15EB0D4", VA = "0x15EB0D4")]
	public static bool ExecutePointerDown(ITouchObject obj)
	{
		return default(bool);
	}

	// Token: 0x060000DE RID: 222 RVA: 0x00002358 File Offset: 0x00000558
	[Token(Token = "0x60000DE")]
	[Address(RVA = "0x15EB14C", Offset = "0x15EB14C", VA = "0x15EB14C")]
	public static bool ExecutePointerUp(ITouchObject obj)
	{
		return default(bool);
	}

	// Token: 0x04000160 RID: 352
	[Token(Token = "0x4000160")]
	[FieldOffset(Offset = "0x0")]
	public static readonly TouchObjectEvent.EventFunction<ITouchObjectClickHandler> s_ClickHandler;

	// Token: 0x04000161 RID: 353
	[Token(Token = "0x4000161")]
	[FieldOffset(Offset = "0x8")]
	public static readonly TouchObjectEvent.EventFunction<ITouchObjectDoubleClickHandler> s_DoubleClickHandler;

	// Token: 0x04000162 RID: 354
	[Token(Token = "0x4000162")]
	[FieldOffset(Offset = "0x10")]
	public static readonly TouchObjectEvent.EventFunction<ITouchObjectBeginLongTabHandler> s_BeginLongTabHandler;

	// Token: 0x04000163 RID: 355
	[Token(Token = "0x4000163")]
	[FieldOffset(Offset = "0x18")]
	public static readonly TouchObjectEvent.EventFunction<ITouchObjectEndLongTabHandler> s_EndLongTabHandler;

	// Token: 0x04000164 RID: 356
	[Token(Token = "0x4000164")]
	[FieldOffset(Offset = "0x20")]
	public static readonly TouchObjectEvent.EventFunction<ITouchObjectPointerDownHandler> s_PointerDownHandler;

	// Token: 0x04000165 RID: 357
	[Token(Token = "0x4000165")]
	[FieldOffset(Offset = "0x28")]
	public static readonly TouchObjectEvent.EventFunction<ITouchObjectPointerUpHandler> s_PointerUpHandler;

	// Token: 0x02000045 RID: 69
	// (Invoke) Token: 0x060000E1 RID: 225
	[Token(Token = "0x2000045")]
	public delegate bool EventFunction<T1>(T1 handler);
}
