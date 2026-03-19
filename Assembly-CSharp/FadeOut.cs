using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000088 RID: 136
[Token(Token = "0x2000088")]
public class FadeOut : MonoBehaviour
{
	// Token: 0x06000349 RID: 841 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000349")]
	[Address(RVA = "0x3211E3C", Offset = "0x3211E3C", VA = "0x3211E3C")]
	private void Awake()
	{
	}

	// Token: 0x0600034A RID: 842 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600034A")]
	[Address(RVA = "0x3211E94", Offset = "0x3211E94", VA = "0x3211E94")]
	private void OnDisable()
	{
	}

	// Token: 0x0600034B RID: 843 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600034B")]
	[Address(RVA = "0x3211F34", Offset = "0x3211F34", VA = "0x3211F34")]
	private void OnEnable()
	{
	}

	// Token: 0x0600034C RID: 844 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600034C")]
	[Address(RVA = "0x3211F84", Offset = "0x3211F84", VA = "0x3211F84")]
	private void DoFadeOut()
	{
	}

	// Token: 0x0600034D RID: 845 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600034D")]
	[Address(RVA = "0x3211FB4", Offset = "0x3211FB4", VA = "0x3211FB4")]
	public FadeOut()
	{
	}

	// Token: 0x040002C9 RID: 713
	[Token(Token = "0x40002C9")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public float delayTime;

	// Token: 0x040002CA RID: 714
	[Token(Token = "0x40002CA")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	public float duringTime;

	// Token: 0x040002CB RID: 715
	[Token(Token = "0x40002CB")]
	[FieldOffset(Offset = "0x20")]
	private MeshRenderer meshRender;
}
