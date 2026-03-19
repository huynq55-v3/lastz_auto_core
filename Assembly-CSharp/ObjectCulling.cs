using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200029A RID: 666
[Token(Token = "0x200029A")]
public class ObjectCulling : MonoBehaviour
{
	// Token: 0x06001193 RID: 4499 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001193")]
	[Address(RVA = "0x1C510F8", Offset = "0x1C510F8", VA = "0x1C510F8")]
	public void InitCullCom()
	{
	}

	// Token: 0x06001194 RID: 4500 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001194")]
	[Address(RVA = "0x1C512B4", Offset = "0x1C512B4", VA = "0x1C512B4")]
	private void StateChanged(CullingGroupEvent sphere)
	{
	}

	// Token: 0x06001195 RID: 4501 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001195")]
	[Address(RVA = "0x1C513BC", Offset = "0x1C513BC", VA = "0x1C513BC")]
	public void AddCullingObj(ICulling cull)
	{
	}

	// Token: 0x06001196 RID: 4502 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001196")]
	[Address(RVA = "0x1C51568", Offset = "0x1C51568", VA = "0x1C51568")]
	public void RemoveCullingObj(ICulling cull)
	{
	}

	// Token: 0x06001197 RID: 4503 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001197")]
	[Address(RVA = "0x1C51810", Offset = "0x1C51810", VA = "0x1C51810")]
	private void OnDestroy()
	{
	}

	// Token: 0x06001198 RID: 4504 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001198")]
	[Address(RVA = "0x1C518A8", Offset = "0x1C518A8", VA = "0x1C518A8")]
	public ObjectCulling()
	{
	}

	// Token: 0x0400143F RID: 5183
	[Token(Token = "0x400143F")]
	[FieldOffset(Offset = "0x18")]
	private CullingGroup m_cullingGroup;

	// Token: 0x04001440 RID: 5184
	[Token(Token = "0x4001440")]
	[FieldOffset(Offset = "0x20")]
	private ArrayT<BoundingSphere> m_cullBounds;

	// Token: 0x04001441 RID: 5185
	[Token(Token = "0x4001441")]
	[FieldOffset(Offset = "0x28")]
	private Dictionary<int, ICulling> m_kvcullDic;
}
