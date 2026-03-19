using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

// Token: 0x0200024E RID: 590
[Token(Token = "0x200024E")]
public class DynamicLoadEffect : MonoBehaviour
{
	// Token: 0x170001D6 RID: 470
	// (get) Token: 0x06000FD1 RID: 4049 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170001D6")]
	public Dictionary<string, InstanceRequest> EffectFinishDic
	{
		[Token(Token = "0x6000FD1")]
		[Address(RVA = "0x1BE83F4", Offset = "0x1BE83F4", VA = "0x1BE83F4")]
		get
		{
			return null;
		}
	}

	// Token: 0x170001D7 RID: 471
	// (get) Token: 0x06000FD2 RID: 4050 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000FD3 RID: 4051 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001D7")]
	public DynamicLoadEffect.LoadedEvent onloaded
	{
		[Token(Token = "0x6000FD2")]
		[Address(RVA = "0x1BE83FC", Offset = "0x1BE83FC", VA = "0x1BE83FC")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000FD3")]
		[Address(RVA = "0x1BE8404", Offset = "0x1BE8404", VA = "0x1BE8404")]
		set
		{
		}
	}

	// Token: 0x06000FD4 RID: 4052 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FD4")]
	[Address(RVA = "0x1BE840C", Offset = "0x1BE840C", VA = "0x1BE840C")]
	private void Start()
	{
	}

	// Token: 0x06000FD5 RID: 4053 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FD5")]
	[Address(RVA = "0x1BE86C4", Offset = "0x1BE86C4", VA = "0x1BE86C4")]
	private IEnumerator DelayCall()
	{
		return null;
	}

	// Token: 0x06000FD6 RID: 4054 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FD6")]
	[Address(RVA = "0x1BE8448", Offset = "0x1BE8448", VA = "0x1BE8448")]
	private void Call()
	{
	}

	// Token: 0x06000FD7 RID: 4055 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FD7")]
	[Address(RVA = "0x1BE8768", Offset = "0x1BE8768", VA = "0x1BE8768")]
	private void OnDestroy()
	{
	}

	// Token: 0x06000FD8 RID: 4056 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FD8")]
	[Address(RVA = "0x1BE88D8", Offset = "0x1BE88D8", VA = "0x1BE88D8")]
	public DynamicLoadEffect()
	{
	}

	// Token: 0x0400124A RID: 4682
	[Token(Token = "0x400124A")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public List<string> effectPaths;

	// Token: 0x0400124B RID: 4683
	[Token(Token = "0x400124B")]
	[FieldOffset(Offset = "0x20")]
	public float delayFrame;

	// Token: 0x0400124C RID: 4684
	[Token(Token = "0x400124C")]
	[FieldOffset(Offset = "0x28")]
	private Dictionary<string, InstanceRequest> effectFinishDic;

	// Token: 0x0400124D RID: 4685
	[Token(Token = "0x400124D")]
	[FieldOffset(Offset = "0x30")]
	private DynamicLoadEffect.LoadedEvent _onloaded;

	// Token: 0x0200024F RID: 591
	[Token(Token = "0x200024F")]
	public class LoadedEvent : UnityEvent
	{
		// Token: 0x06000FD9 RID: 4057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FD9")]
		[Address(RVA = "0x1BE8A00", Offset = "0x1BE8A00", VA = "0x1BE8A00")]
		public LoadedEvent()
		{
		}
	}
}
