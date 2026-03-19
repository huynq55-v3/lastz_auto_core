using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using VEngine;

// Token: 0x020001DD RID: 477
[Token(Token = "0x20001DD")]
public class ShaderManager
{
	// Token: 0x06000CE1 RID: 3297 RVA: 0x00005DA8 File Offset: 0x00003FA8
	[Token(Token = "0x6000CE1")]
	[Address(RVA = "0x12CC7D0", Offset = "0x12CC7D0", VA = "0x12CC7D0")]
	public bool IsInitDone()
	{
		return default(bool);
	}

	// Token: 0x06000CE2 RID: 3298 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000CE2")]
	[Address(RVA = "0x12CC7F8", Offset = "0x12CC7F8", VA = "0x12CC7F8")]
	public Shader Find(string shaderName)
	{
		return null;
	}

	// Token: 0x06000CE3 RID: 3299 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CE3")]
	[Address(RVA = "0x12CC8C8", Offset = "0x12CC8C8", VA = "0x12CC8C8")]
	public void DumpCurBundle()
	{
	}

	// Token: 0x06000CE4 RID: 3300 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CE4")]
	[Address(RVA = "0x12CC95C", Offset = "0x12CC95C", VA = "0x12CC95C")]
	public void Initialize(Action callback)
	{
	}

	// Token: 0x06000CE5 RID: 3301 RVA: 0x00005DC0 File Offset: 0x00003FC0
	[Token(Token = "0x6000CE5")]
	[Address(RVA = "0x12CCE1C", Offset = "0x12CCE1C", VA = "0x12CCE1C")]
	public int GetCurWarmUpQueueCount()
	{
		return 0;
	}

	// Token: 0x06000CE6 RID: 3302 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CE6")]
	[Address(RVA = "0x12CCE64", Offset = "0x12CCE64", VA = "0x12CCE64")]
	public void StartWarmupByFrame()
	{
	}

	// Token: 0x06000CE7 RID: 3303 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CE7")]
	[Address(RVA = "0x12CCFC8", Offset = "0x12CCFC8", VA = "0x12CCFC8")]
	public void StopWarmUp()
	{
	}

	// Token: 0x06000CE8 RID: 3304 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000CE8")]
	[Address(RVA = "0x12CCF54", Offset = "0x12CCF54", VA = "0x12CCF54")]
	private IEnumerator WarmupCoroutine()
	{
		return null;
	}

	// Token: 0x06000CE9 RID: 3305 RVA: 0x00005DD8 File Offset: 0x00003FD8
	[Token(Token = "0x6000CE9")]
	[Address(RVA = "0x12CD0B0", Offset = "0x12CD0B0", VA = "0x12CD0B0")]
	public bool IsWarmUpDone()
	{
		return default(bool);
	}

	// Token: 0x06000CEA RID: 3306 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CEA")]
	[Address(RVA = "0x12CCC54", Offset = "0x12CCC54", VA = "0x12CCC54")]
	public void Shutdown()
	{
	}

	// Token: 0x06000CEB RID: 3307 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CEB")]
	[Address(RVA = "0x12CD100", Offset = "0x12CD100", VA = "0x12CD100")]
	public void Dump()
	{
	}

	// Token: 0x06000CEC RID: 3308 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CEC")]
	[Address(RVA = "0x12CD318", Offset = "0x12CD318", VA = "0x12CD318")]
	public ShaderManager()
	{
	}

	// Token: 0x04001080 RID: 4224
	[Token(Token = "0x4001080")]
	[FieldOffset(Offset = "0x10")]
	public Dictionary<string, Shader> m_kvNameToShader;

	// Token: 0x04001081 RID: 4225
	[Token(Token = "0x4001081")]
	[FieldOffset(Offset = "0x18")]
	private Shader m_defaultShader;

	// Token: 0x04001082 RID: 4226
	[Token(Token = "0x4001082")]
	[FieldOffset(Offset = "0x20")]
	private int m_loadCnt;

	// Token: 0x04001083 RID: 4227
	[Token(Token = "0x4001083")]
	[FieldOffset(Offset = "0x28")]
	private string[] SHADER_BUNDLE;

	// Token: 0x04001084 RID: 4228
	[Token(Token = "0x4001084")]
	[FieldOffset(Offset = "0x30")]
	private List<Asset> m_bundleList;

	// Token: 0x04001085 RID: 4229
	[Token(Token = "0x4001085")]
	[FieldOffset(Offset = "0x38")]
	private readonly Queue<ShaderVariantCollection> m_warmupQueue;

	// Token: 0x04001086 RID: 4230
	[Token(Token = "0x4001086")]
	[FieldOffset(Offset = "0x40")]
	private bool m_isWarmupRunning;

	// Token: 0x04001087 RID: 4231
	[Token(Token = "0x4001087")]
	[FieldOffset(Offset = "0x44")]
	public float m_warmupFrameBudgetMs;

	// Token: 0x04001088 RID: 4232
	[Token(Token = "0x4001088")]
	[FieldOffset(Offset = "0x48")]
	private Coroutine _coroutineWarmUp;
}
