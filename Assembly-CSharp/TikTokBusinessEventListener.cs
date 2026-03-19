using System;
using System.Collections.Generic;
using System.Reflection;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.SceneManagement;

// Token: 0x02000017 RID: 23
[Token(Token = "0x2000017")]
public class TikTokBusinessEventListener : MonoBehaviour
{
	// Token: 0x0600002C RID: 44 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600002C")]
	[Address(RVA = "0x15DF910", Offset = "0x15DF910", VA = "0x15DF910")]
	private void Start()
	{
	}

	// Token: 0x0600002D RID: 45 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600002D")]
	[Address(RVA = "0x15DF914", Offset = "0x15DF914", VA = "0x15DF914")]
	private void Update()
	{
	}

	// Token: 0x0600002E RID: 46 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600002E")]
	[Address(RVA = "0x15E03D4", Offset = "0x15E03D4", VA = "0x15E03D4")]
	private Dictionary<string, object> CurrentUIInfo(Transform currentTransform, string parentName, long currentLevel, long targetLevel)
	{
		return null;
	}

	// Token: 0x0600002F RID: 47 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600002F")]
	[Address(RVA = "0x15E0DD4", Offset = "0x15E0DD4", VA = "0x15E0DD4")]
	private void OnActiveSceneChanged(Scene previousScene, Scene newScene)
	{
	}

	// Token: 0x06000030 RID: 48 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000030")]
	[Address(RVA = "0x15E0398", Offset = "0x15E0398", VA = "0x15E0398")]
	private void clearData()
	{
	}

	// Token: 0x06000031 RID: 49 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000031")]
	[Address(RVA = "0x15E1428", Offset = "0x15E1428", VA = "0x15E1428")]
	public TikTokBusinessEventListener()
	{
	}

	// Token: 0x0400007E RID: 126
	[Token(Token = "0x400007E")]
	[FieldOffset(Offset = "0x18")]
	private FieldInfo _fieldInfo;

	// Token: 0x0400007F RID: 127
	[Token(Token = "0x400007F")]
	[FieldOffset(Offset = "0x20")]
	private Transform _baseTransform;

	// Token: 0x04000080 RID: 128
	[Token(Token = "0x4000080")]
	[FieldOffset(Offset = "0x28")]
	private float _startTime;

	// Token: 0x04000081 RID: 129
	[Token(Token = "0x4000081")]
	[FieldOffset(Offset = "0x2C")]
	private float _endTime;

	// Token: 0x04000082 RID: 130
	[Token(Token = "0x4000082")]
	[FieldOffset(Offset = "0x30")]
	private Transform _currentClickTransform;

	// Token: 0x04000083 RID: 131
	[Token(Token = "0x4000083")]
	[FieldOffset(Offset = "0x38")]
	private Dictionary<string, object> _clickInfos;
}
