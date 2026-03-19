using System;
using BitBenderGames;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000037 RID: 55
[Token(Token = "0x2000037")]
public class TestChange : MonoBehaviour
{
	// Token: 0x060000B6 RID: 182 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000B6")]
	[Address(RVA = "0x15E9E88", Offset = "0x15E9E88", VA = "0x15E9E88")]
	private void Awake()
	{
	}

	// Token: 0x060000B7 RID: 183 RVA: 0x000021D8 File Offset: 0x000003D8
	[Token(Token = "0x60000B7")]
	[Address(RVA = "0x15E9F58", Offset = "0x15E9F58", VA = "0x15E9F58")]
	private float GetCameraN(float halfOfHeight, float fovDeg)
	{
		return 0f;
	}

	// Token: 0x060000B8 RID: 184 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000B8")]
	[Address(RVA = "0x15E9F8C", Offset = "0x15E9F8C", VA = "0x15E9F8C")]
	public void StartToMin(Action callback)
	{
	}

	// Token: 0x060000B9 RID: 185 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000B9")]
	[Address(RVA = "0x15EA038", Offset = "0x15EA038", VA = "0x15EA038")]
	public void StartToMax(Action callback, Vector3 targetPos)
	{
	}

	// Token: 0x060000BA RID: 186 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000BA")]
	[Address(RVA = "0x15EA17C", Offset = "0x15EA17C", VA = "0x15EA17C")]
	private void Calc(float curHalfOfHeight, float curFov)
	{
	}

	// Token: 0x060000BB RID: 187 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000BB")]
	[Address(RVA = "0x15EA284", Offset = "0x15EA284", VA = "0x15EA284")]
	private void LateUpdate()
	{
	}

	// Token: 0x060000BC RID: 188 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000BC")]
	[Address(RVA = "0x15EA2AC", Offset = "0x15EA2AC", VA = "0x15EA2AC")]
	private void ToMin()
	{
	}

	// Token: 0x060000BD RID: 189 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000BD")]
	[Address(RVA = "0x15EA520", Offset = "0x15EA520", VA = "0x15EA520")]
	private void ToMax()
	{
	}

	// Token: 0x060000BE RID: 190 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000BE")]
	[Address(RVA = "0x15EA7E0", Offset = "0x15EA7E0", VA = "0x15EA7E0")]
	public TestChange()
	{
	}

	// Token: 0x0400014C RID: 332
	[Token(Token = "0x400014C")]
	[FieldOffset(Offset = "0x18")]
	public Transform tCamera;

	// Token: 0x0400014D RID: 333
	[Token(Token = "0x400014D")]
	[FieldOffset(Offset = "0x20")]
	private Camera camera;

	// Token: 0x0400014E RID: 334
	[Token(Token = "0x400014E")]
	[FieldOffset(Offset = "0x28")]
	private MobileTouchCamera _mobileTouchCamera;

	// Token: 0x0400014F RID: 335
	[Token(Token = "0x400014F")]
	[FieldOffset(Offset = "0x30")]
	public float startFov;

	// Token: 0x04000150 RID: 336
	[Token(Token = "0x4000150")]
	[FieldOffset(Offset = "0x34")]
	public float targetFov;

	// Token: 0x04000151 RID: 337
	[Token(Token = "0x4000151")]
	[FieldOffset(Offset = "0x38")]
	private float startHalfOfHeight;

	// Token: 0x04000152 RID: 338
	[Token(Token = "0x4000152")]
	[FieldOffset(Offset = "0x3C")]
	public float targetHalfOfHeight;

	// Token: 0x04000153 RID: 339
	[Token(Token = "0x4000153")]
	[FieldOffset(Offset = "0x40")]
	private Vector3 oldPos;

	// Token: 0x04000154 RID: 340
	[Token(Token = "0x4000154")]
	[FieldOffset(Offset = "0x50")]
	private Action m_callback;

	// Token: 0x04000155 RID: 341
	[Token(Token = "0x4000155")]
	[FieldOffset(Offset = "0x0")]
	private static string orthographicKey;

	// Token: 0x04000156 RID: 342
	[Token(Token = "0x4000156")]
	[FieldOffset(Offset = "0x58")]
	private float m_fovDelta;

	// Token: 0x04000157 RID: 343
	[Token(Token = "0x4000157")]
	[FieldOffset(Offset = "0x5C")]
	private bool m_end;

	// Token: 0x04000158 RID: 344
	[Token(Token = "0x4000158")]
	[FieldOffset(Offset = "0x5D")]
	private bool m_toMin;

	// Token: 0x04000159 RID: 345
	[Token(Token = "0x4000159")]
	[FieldOffset(Offset = "0x5E")]
	private bool m_toMax;

	// Token: 0x0400015A RID: 346
	[Token(Token = "0x400015A")]
	[FieldOffset(Offset = "0x60")]
	private float m_orthSize;

	// Token: 0x0400015B RID: 347
	[Token(Token = "0x400015B")]
	[FieldOffset(Offset = "0x64")]
	private bool startChange;

	// Token: 0x0400015C RID: 348
	[Token(Token = "0x400015C")]
	[FieldOffset(Offset = "0x68")]
	private float dt;

	// Token: 0x0400015D RID: 349
	[Token(Token = "0x400015D")]
	[FieldOffset(Offset = "0x6C")]
	private float totalTime;

	// Token: 0x0400015E RID: 350
	[Token(Token = "0x400015E")]
	[FieldOffset(Offset = "0x70")]
	private float m_distance;

	// Token: 0x0400015F RID: 351
	[Token(Token = "0x400015F")]
	[FieldOffset(Offset = "0x74")]
	private Vector3 m_deltaPos;
}
