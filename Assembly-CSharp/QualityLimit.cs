using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000096 RID: 150
[Token(Token = "0x2000096")]
[ExecuteAlways]
public class QualityLimit : MonoBehaviour
{
	// Token: 0x0600038C RID: 908 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600038C")]
	[Address(RVA = "0x32156DC", Offset = "0x32156DC", VA = "0x32156DC")]
	private void OnEnable()
	{
	}

	// Token: 0x0600038D RID: 909 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600038D")]
	[Address(RVA = "0x3215AC4", Offset = "0x3215AC4", VA = "0x3215AC4")]
	private void OnDisable()
	{
	}

	// Token: 0x0600038E RID: 910 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600038E")]
	[Address(RVA = "0x3215704", Offset = "0x3215704", VA = "0x3215704")]
	private void OnGrabToggle(bool isToggle)
	{
	}

	// Token: 0x0600038F RID: 911 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600038F")]
	[Address(RVA = "0x3215304", Offset = "0x3215304", VA = "0x3215304")]
	public void Refresh(int graphicLv)
	{
	}

	// Token: 0x06000390 RID: 912 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000390")]
	[Address(RVA = "0x3215AEC", Offset = "0x3215AEC", VA = "0x3215AEC")]
	public QualityLimit()
	{
	}

	// Token: 0x04000310 RID: 784
	[Token(Token = "0x4000310")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public bool hideLow;

	// Token: 0x04000311 RID: 785
	[Token(Token = "0x4000311")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject obj;
}
