using System;
using System.Text;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

// Token: 0x020001C5 RID: 453
[Token(Token = "0x20001C5")]
public class LuaMonoBase : MonoBehaviour
{
	// Token: 0x06000BB7 RID: 2999 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BB7")]
	[Address(RVA = "0x372B480", Offset = "0x372B480", VA = "0x372B480")]
	private void MakeLuaBytes(out byte[] bytes, out int bytes_len)
	{
	}

	// Token: 0x06000BB8 RID: 3000 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BB8")]
	private void CallLuaFunc<T>(int funcref, int para_count, T para)
	{
	}

	// Token: 0x06000BB9 RID: 3001 RVA: 0x00005958 File Offset: 0x00003B58
	[Token(Token = "0x6000BB9")]
	[Address(RVA = "0x372B724", Offset = "0x372B724", VA = "0x372B724")]
	protected int GetFunction(string funcName)
	{
		return 0;
	}

	// Token: 0x06000BBA RID: 3002 RVA: 0x00005970 File Offset: 0x00003B70
	[Token(Token = "0x6000BBA")]
	[Address(RVA = "0x372BAB4", Offset = "0x372BAB4", VA = "0x372BAB4")]
	private int GetFunctionInternal(string funcName)
	{
		return 0;
	}

	// Token: 0x06000BBB RID: 3003 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BBB")]
	[Address(RVA = "0x372BCD8", Offset = "0x372BCD8", VA = "0x372BCD8")]
	protected void ReleaseLuaTable()
	{
	}

	// Token: 0x06000BBC RID: 3004 RVA: 0x00005988 File Offset: 0x00003B88
	[Token(Token = "0x6000BBC")]
	[Address(RVA = "0x372BE4C", Offset = "0x372BE4C", VA = "0x372BE4C")]
	protected int GetLuaTable(byte[] bytes, int bytes_len)
	{
		return 0;
	}

	// Token: 0x06000BBD RID: 3005 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BBD")]
	protected void Set<TKey, TValue>(int luaref, TKey key, TValue value)
	{
	}

	// Token: 0x06000BBE RID: 3006 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BBE")]
	[Address(RVA = "0x372C2DC", Offset = "0x372C2DC", VA = "0x372C2DC")]
	protected void UnRef(ref int funcref)
	{
	}

	// Token: 0x06000BBF RID: 3007 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BBF")]
	[Address(RVA = "0x372C3D4", Offset = "0x372C3D4", VA = "0x372C3D4")]
	protected void Init()
	{
	}

	// Token: 0x06000BC0 RID: 3008 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BC0")]
	[Address(RVA = "0x372C580", Offset = "0x372C580", VA = "0x372C580")]
	protected void Uninit()
	{
	}

	// Token: 0x06000BC1 RID: 3009 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BC1")]
	[Address(RVA = "0x372C5B0", Offset = "0x372C5B0", VA = "0x372C5B0")]
	protected void CallLuaFunc(string funcname, ref int funcref)
	{
	}

	// Token: 0x06000BC2 RID: 3010 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BC2")]
	protected void CallLuaFunc<T>(string funcname, int funcref, T para)
	{
	}

	// Token: 0x06000BC3 RID: 3011 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000BC3")]
	[Address(RVA = "0x372C62C", Offset = "0x372C62C", VA = "0x372C62C")]
	public LuaTable GetLuaTable()
	{
		return null;
	}

	// Token: 0x06000BC4 RID: 3012 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BC4")]
	[Address(RVA = "0x372C6D4", Offset = "0x372C6D4", VA = "0x372C6D4")]
	public LuaMonoBase()
	{
	}

	// Token: 0x04000FFD RID: 4093
	[Token(Token = "0x4000FFD")]
	[FieldOffset(Offset = "0x18")]
	public string para1;

	// Token: 0x04000FFE RID: 4094
	[Token(Token = "0x4000FFE")]
	[FieldOffset(Offset = "0x20")]
	public string para2;

	// Token: 0x04000FFF RID: 4095
	[Token(Token = "0x4000FFF")]
	[FieldOffset(Offset = "0x28")]
	public GameObject object1;

	// Token: 0x04001000 RID: 4096
	[Token(Token = "0x4001000")]
	[FieldOffset(Offset = "0x30")]
	public GameObject object2;

	// Token: 0x04001001 RID: 4097
	[Token(Token = "0x4001001")]
	[FieldOffset(Offset = "0x38")]
	public LuaMonoBase.Values[] _values;

	// Token: 0x04001002 RID: 4098
	[Token(Token = "0x4001002")]
	[FieldOffset(Offset = "0x40")]
	public LuaMonoBase.Objects[] _objects;

	// Token: 0x04001003 RID: 4099
	[Token(Token = "0x4001003")]
	[FieldOffset(Offset = "0x48")]
	public string _luaPath;

	// Token: 0x04001004 RID: 4100
	[Token(Token = "0x4001004")]
	[FieldOffset(Offset = "0x0")]
	protected static readonly int LUA_REFNIL;

	// Token: 0x04001005 RID: 4101
	[Token(Token = "0x4001005")]
	[FieldOffset(Offset = "0x50")]
	protected int _luaTableReference;

	// Token: 0x04001006 RID: 4102
	[Token(Token = "0x4001006")]
	[FieldOffset(Offset = "0x8")]
	private static char[] globalBuf;

	// Token: 0x04001007 RID: 4103
	[Token(Token = "0x4001007")]
	[FieldOffset(Offset = "0x10")]
	private static StringBuilder globalSB;

	// Token: 0x020001C6 RID: 454
	[Token(Token = "0x20001C6")]
	[Serializable]
	public class Objects
	{
		// Token: 0x06000BC6 RID: 3014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000BC6")]
		[Address(RVA = "0x372C80C", Offset = "0x372C80C", VA = "0x372C80C")]
		public Objects()
		{
		}

		// Token: 0x04001008 RID: 4104
		[Token(Token = "0x4001008")]
		[FieldOffset(Offset = "0x10")]
		public string name;

		// Token: 0x04001009 RID: 4105
		[Token(Token = "0x4001009")]
		[FieldOffset(Offset = "0x18")]
		public GameObject value;
	}

	// Token: 0x020001C7 RID: 455
	[Token(Token = "0x20001C7")]
	[Serializable]
	public class Values
	{
		// Token: 0x06000BC7 RID: 3015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000BC7")]
		[Address(RVA = "0x372C814", Offset = "0x372C814", VA = "0x372C814")]
		public Values()
		{
		}

		// Token: 0x0400100A RID: 4106
		[Token(Token = "0x400100A")]
		[FieldOffset(Offset = "0x10")]
		public string name;

		// Token: 0x0400100B RID: 4107
		[Token(Token = "0x400100B")]
		[FieldOffset(Offset = "0x18")]
		public string value;
	}
}
