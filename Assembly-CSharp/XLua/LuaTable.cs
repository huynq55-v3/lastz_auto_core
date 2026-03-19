using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Unity.IL2CPP.CompilerServices;
using UnityEngine.Scripting;

namespace XLua
{
	// Token: 0x02000528 RID: 1320
	[Token(Token = "0x2000528")]
	[Preserve]
	[Il2CppSetOption(Option.NullChecks, false)]
	public class LuaTable : LuaBase
	{
		// Token: 0x0600278A RID: 10122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600278A")]
		[Address(RVA = "0x2B6D600", Offset = "0x2B6D600", VA = "0x2B6D600")]
		public LuaTable(int reference, LuaEnv luaenv)
		{
		}

		// Token: 0x0600278B RID: 10123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600278B")]
		public void Get<TKey, TValue>(TKey key, out TValue value)
		{
		}

		// Token: 0x0600278C RID: 10124 RVA: 0x0000EEF8 File Offset: 0x0000D0F8
		[Token(Token = "0x600278C")]
		public bool ContainsKey<TKey>(TKey key)
		{
			return default(bool);
		}

		// Token: 0x0600278D RID: 10125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600278D")]
		public void Set<TKey, TValue>(TKey key, TValue value)
		{
		}

		// Token: 0x0600278E RID: 10126 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600278E")]
		public T GetInPath<T>(string path)
		{
			return null;
		}

		// Token: 0x0600278F RID: 10127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600278F")]
		public void SetInPath<T>(string path, T val)
		{
		}

		// Token: 0x170005E2 RID: 1506
		[Token(Token = "0x170005E2")]
		[Obsolete("use no boxing version: GetInPath/SetInPath Get/Set instead!")]
		public object this[string field]
		{
			[Token(Token = "0x6002790")]
			[Address(RVA = "0x2B6D638", Offset = "0x2B6D638", VA = "0x2B6D638")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002791")]
			[Address(RVA = "0x2B6D690", Offset = "0x2B6D690", VA = "0x2B6D690")]
			set
			{
			}
		}

		// Token: 0x170005E3 RID: 1507
		[Token(Token = "0x170005E3")]
		[Obsolete("use no boxing version: GetInPath/SetInPath Get/Set instead!")]
		public object this[object field]
		{
			[Token(Token = "0x6002792")]
			[Address(RVA = "0x2B6D6F0", Offset = "0x2B6D6F0", VA = "0x2B6D6F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002793")]
			[Address(RVA = "0x2B65110", Offset = "0x2B65110", VA = "0x2B65110")]
			set
			{
			}
		}

		// Token: 0x06002794 RID: 10132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002794")]
		public void ForEach<TKey, TValue>(Action<TKey, TValue> action)
		{
		}

		// Token: 0x170005E4 RID: 1508
		// (get) Token: 0x06002795 RID: 10133 RVA: 0x0000EF10 File Offset: 0x0000D110
		[Token(Token = "0x170005E4")]
		public int Length
		{
			[Token(Token = "0x6002795")]
			[Address(RVA = "0x2B6D748", Offset = "0x2B6D748", VA = "0x2B6D748")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06002796 RID: 10134 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002796")]
		[Address(RVA = "0x2B6D7F0", Offset = "0x2B6D7F0", VA = "0x2B6D7F0")]
		public IEnumerable GetKeys()
		{
			return null;
		}

		// Token: 0x06002797 RID: 10135 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002797")]
		public IEnumerable<T> GetKeys<T>()
		{
			return null;
		}

		// Token: 0x06002798 RID: 10136 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002798")]
		[Obsolete("use no boxing version: Get<TKey, TValue> !")]
		public T Get<T>(object key)
		{
			return null;
		}

		// Token: 0x06002799 RID: 10137 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002799")]
		public TValue Get<TKey, TValue>(TKey key)
		{
			return null;
		}

		// Token: 0x0600279A RID: 10138 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600279A")]
		public TValue Get<TValue>(string key)
		{
			return null;
		}

		// Token: 0x0600279B RID: 10139 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600279B")]
		[Address(RVA = "0x2B6D85C", Offset = "0x2B6D85C", VA = "0x2B6D85C")]
		public void SetMetaTable(LuaTable metaTable)
		{
		}

		// Token: 0x0600279C RID: 10140 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600279C")]
		public T Cast<T>()
		{
			return null;
		}

		// Token: 0x0600279D RID: 10141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600279D")]
		[Address(RVA = "0x2B6D920", Offset = "0x2B6D920", VA = "0x2B6D920", Slot = "6")]
		internal override void push(IntPtr L)
		{
		}

		// Token: 0x0600279E RID: 10142 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600279E")]
		[Address(RVA = "0x2B6D98C", Offset = "0x2B6D98C", VA = "0x2B6D98C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600279F RID: 10143 RVA: 0x0000EF28 File Offset: 0x0000D128
		[Token(Token = "0x600279F")]
		[Address(RVA = "0x2B6D9E8", Offset = "0x2B6D9E8", VA = "0x2B6D9E8")]
		public int TableCount()
		{
			return 0;
		}

		// Token: 0x060027A0 RID: 10144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027A0")]
		[Address(RVA = "0x2B6DBA8", Offset = "0x2B6DBA8", VA = "0x2B6DBA8")]
		public void ForEach(Action<int, int> action)
		{
		}

		// Token: 0x060027A1 RID: 10145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027A1")]
		[Address(RVA = "0x2B6DD60", Offset = "0x2B6DD60", VA = "0x2B6DD60")]
		public void SetInt(string key, int value)
		{
		}

		// Token: 0x060027A2 RID: 10146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027A2")]
		[Address(RVA = "0x2B6DE54", Offset = "0x2B6DE54", VA = "0x2B6DE54")]
		public void SetFloat(string key, float value)
		{
		}

		// Token: 0x060027A3 RID: 10147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027A3")]
		[Address(RVA = "0x2B6DF48", Offset = "0x2B6DF48", VA = "0x2B6DF48")]
		public void SetDouble(string key, double value)
		{
		}

		// Token: 0x060027A4 RID: 10148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027A4")]
		[Address(RVA = "0x2B6E03C", Offset = "0x2B6E03C", VA = "0x2B6E03C")]
		public void SetLong(string key, long value)
		{
		}

		// Token: 0x060027A5 RID: 10149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027A5")]
		[Address(RVA = "0x2B6E130", Offset = "0x2B6E130", VA = "0x2B6E130")]
		public void SetString(string key, string value)
		{
		}

		// Token: 0x060027A6 RID: 10150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027A6")]
		[Address(RVA = "0x2B6E224", Offset = "0x2B6E224", VA = "0x2B6E224")]
		public void SetTable(string key, LuaTable value)
		{
		}

		// Token: 0x060027A7 RID: 10151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027A7")]
		[Address(RVA = "0x2B6E31C", Offset = "0x2B6E31C", VA = "0x2B6E31C")]
		public void SetInt(int key, int value)
		{
		}

		// Token: 0x060027A8 RID: 10152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027A8")]
		[Address(RVA = "0x2B6E410", Offset = "0x2B6E410", VA = "0x2B6E410")]
		public void SetFloat(int key, float value)
		{
		}

		// Token: 0x060027A9 RID: 10153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027A9")]
		[Address(RVA = "0x2B6E504", Offset = "0x2B6E504", VA = "0x2B6E504")]
		public void SetDouble(int key, double value)
		{
		}

		// Token: 0x060027AA RID: 10154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027AA")]
		[Address(RVA = "0x2B6E5F8", Offset = "0x2B6E5F8", VA = "0x2B6E5F8")]
		public void SetLong(int key, long value)
		{
		}

		// Token: 0x060027AB RID: 10155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027AB")]
		[Address(RVA = "0x2B6E6EC", Offset = "0x2B6E6EC", VA = "0x2B6E6EC")]
		public void SetString(int key, string value)
		{
		}

		// Token: 0x060027AC RID: 10156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027AC")]
		[Address(RVA = "0x2B6E7E0", Offset = "0x2B6E7E0", VA = "0x2B6E7E0")]
		public void SetTable(int key, LuaTable value)
		{
		}
	}
}
