using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000089 RID: 137
[Token(Token = "0x2000089")]
[ExecuteAlways]
public class FlowAniCtrl : MonoBehaviour
{
	// Token: 0x0600034E RID: 846 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600034E")]
	[Address(RVA = "0x3211FC4", Offset = "0x3211FC4", VA = "0x3211FC4")]
	private void Awake()
	{
	}

	// Token: 0x0600034F RID: 847 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600034F")]
	[Address(RVA = "0x3212090", Offset = "0x3212090", VA = "0x3212090")]
	private void Update()
	{
	}

	// Token: 0x06000350 RID: 848 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000350")]
	[Address(RVA = "0x321216C", Offset = "0x321216C", VA = "0x321216C")]
	private void OnDestroy()
	{
	}

	// Token: 0x06000351 RID: 849 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000351")]
	[Address(RVA = "0x3212170", Offset = "0x3212170", VA = "0x3212170")]
	public FlowAniCtrl()
	{
	}

	// Token: 0x040002CC RID: 716
	[Token(Token = "0x40002CC")]
	[FieldOffset(Offset = "0x18")]
	public float _Tick;

	// Token: 0x040002CD RID: 717
	[Token(Token = "0x40002CD")]
	[FieldOffset(Offset = "0x1C")]
	public float _Power;

	// Token: 0x040002CE RID: 718
	[Token(Token = "0x40002CE")]
	[FieldOffset(Offset = "0x0")]
	private static int _TickId;

	// Token: 0x040002CF RID: 719
	[Token(Token = "0x40002CF")]
	[FieldOffset(Offset = "0x4")]
	private static int _PowerId;

	// Token: 0x040002D0 RID: 720
	[Token(Token = "0x40002D0")]
	[FieldOffset(Offset = "0x20")]
	private Material mat;
}
