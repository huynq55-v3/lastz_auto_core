using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001D2 RID: 466
[Token(Token = "0x20001D2")]
public class InstanceRequest
{
	// Token: 0x06000C38 RID: 3128 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C38")]
	[Address(RVA = "0x12C32F0", Offset = "0x12C32F0", VA = "0x12C32F0")]
	public void SetAlwaysHold(bool hold)
	{
	}

	// Token: 0x06000C39 RID: 3129 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C39")]
	[Address(RVA = "0x12C32FC", Offset = "0x12C32FC", VA = "0x12C32FC")]
	public void SetMoveToFar(bool moveToFar)
	{
	}

	// Token: 0x17000181 RID: 385
	// (get) Token: 0x06000C3A RID: 3130 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000181")]
	public string PrefabPath
	{
		[Token(Token = "0x6000C3A")]
		[Address(RVA = "0x12C3308", Offset = "0x12C3308", VA = "0x12C3308")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000182 RID: 386
	// (get) Token: 0x06000C3B RID: 3131 RVA: 0x00005B50 File Offset: 0x00003D50
	// (set) Token: 0x06000C3C RID: 3132 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000182")]
	public bool isDone
	{
		[Token(Token = "0x6000C3B")]
		[Address(RVA = "0x12C3310", Offset = "0x12C3310", VA = "0x12C3310")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000C3C")]
		[Address(RVA = "0x12C3318", Offset = "0x12C3318", VA = "0x12C3318")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x14000008 RID: 8
	// (add) Token: 0x06000C3D RID: 3133 RVA: 0x00002053 File Offset: 0x00000253
	// (remove) Token: 0x06000C3E RID: 3134 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x14000008")]
	public event Action<InstanceRequest> completed
	{
		[Token(Token = "0x6000C3D")]
		[Address(RVA = "0x12C3324", Offset = "0x12C3324", VA = "0x12C3324")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000C3E")]
		[Address(RVA = "0x12C33D4", Offset = "0x12C33D4", VA = "0x12C33D4")]
		[CompilerGenerated]
		remove
		{
		}
	}

	// Token: 0x06000C3F RID: 3135 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C3F")]
	[Address(RVA = "0x12C2E10", Offset = "0x12C2E10", VA = "0x12C2E10")]
	public InstanceRequest(string prefabPath, [Optional] Transform parent)
	{
	}

	// Token: 0x06000C40 RID: 3136 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C40")]
	[Address(RVA = "0x12C2444", Offset = "0x12C2444", VA = "0x12C2444")]
	public void Instantiate()
	{
	}

	// Token: 0x06000C41 RID: 3137 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C41")]
	[Address(RVA = "0x12C28CC", Offset = "0x12C28CC", VA = "0x12C28CC")]
	public void Destroy(bool backToPool = true)
	{
	}

	// Token: 0x06000C42 RID: 3138 RVA: 0x00005B68 File Offset: 0x00003D68
	[Token(Token = "0x6000C42")]
	[Address(RVA = "0x12C2500", Offset = "0x12C2500", VA = "0x12C2500")]
	public bool Update()
	{
		return default(bool);
	}

	// Token: 0x06000C43 RID: 3139 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C43")]
	[Address(RVA = "0x12C3484", Offset = "0x12C3484", VA = "0x12C3484")]
	public void SetPriority(int priority)
	{
	}

	// Token: 0x06000C44 RID: 3140 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C44")]
	[Address(RVA = "0x12C348C", Offset = "0x12C348C", VA = "0x12C348C")]
	public static void PrintAllRequests()
	{
	}

	// Token: 0x04001048 RID: 4168
	[Token(Token = "0x4001048")]
	[FieldOffset(Offset = "0x10")]
	private string prefabPath;

	// Token: 0x04001049 RID: 4169
	[Token(Token = "0x4001049")]
	[FieldOffset(Offset = "0x18")]
	private ObjectPool pool;

	// Token: 0x0400104A RID: 4170
	[Token(Token = "0x400104A")]
	[FieldOffset(Offset = "0x20")]
	private int req_index;

	// Token: 0x0400104B RID: 4171
	[Token(Token = "0x400104B")]
	[FieldOffset(Offset = "0x24")]
	private int req_priority;

	// Token: 0x0400104C RID: 4172
	[Token(Token = "0x400104C")]
	[FieldOffset(Offset = "0x28")]
	private bool alwaysHold;

	// Token: 0x0400104D RID: 4173
	[Token(Token = "0x400104D")]
	[FieldOffset(Offset = "0x29")]
	private bool _moveToFar;

	// Token: 0x0400104F RID: 4175
	[Token(Token = "0x400104F")]
	[FieldOffset(Offset = "0x2B")]
	public bool isError;

	// Token: 0x04001050 RID: 4176
	[Token(Token = "0x4001050")]
	[FieldOffset(Offset = "0x2C")]
	public InstanceRequest.State state;

	// Token: 0x04001051 RID: 4177
	[Token(Token = "0x4001051")]
	[FieldOffset(Offset = "0x30")]
	public GameObject gameObject;

	// Token: 0x04001053 RID: 4179
	[Token(Token = "0x4001053")]
	[FieldOffset(Offset = "0x40")]
	public Transform presetParent;

	// Token: 0x020001D3 RID: 467
	[Token(Token = "0x20001D3")]
	public enum State
	{
		// Token: 0x04001055 RID: 4181
		[Token(Token = "0x4001055")]
		Init,
		// Token: 0x04001056 RID: 4182
		[Token(Token = "0x4001056")]
		Loading,
		// Token: 0x04001057 RID: 4183
		[Token(Token = "0x4001057")]
		Instanced,
		// Token: 0x04001058 RID: 4184
		[Token(Token = "0x4001058")]
		Destroy
	}
}
