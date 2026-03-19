using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000293 RID: 659
[Token(Token = "0x2000293")]
public class SurvivalLodEx : SurvivalLod
{
	// Token: 0x0600115A RID: 4442 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600115A")]
	[Address(RVA = "0x1C4FD60", Offset = "0x1C4FD60", VA = "0x1C4FD60", Slot = "4")]
	protected override void InitComponent()
	{
	}

	// Token: 0x0600115B RID: 4443 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600115B")]
	[Address(RVA = "0x1C4FEFC", Offset = "0x1C4FEFC", VA = "0x1C4FEFC", Slot = "6")]
	public override void Refresh(float curZoom)
	{
	}

	// Token: 0x0600115C RID: 4444 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600115C")]
	[Address(RVA = "0x1C50014", Offset = "0x1C50014", VA = "0x1C50014")]
	public void UpdateRefresh()
	{
	}

	// Token: 0x0600115D RID: 4445 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600115D")]
	[Address(RVA = "0x1C5002C", Offset = "0x1C5002C", VA = "0x1C5002C")]
	public void PlayAnimation(string animationName)
	{
	}

	// Token: 0x0600115E RID: 4446 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600115E")]
	[Address(RVA = "0x1C500C0", Offset = "0x1C500C0", VA = "0x1C500C0")]
	private void _AllChildPlayAnimation(GameObject obj, string aniname)
	{
	}

	// Token: 0x0600115F RID: 4447 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600115F")]
	[Address(RVA = "0x1C4FF28", Offset = "0x1C4FF28", VA = "0x1C4FF28")]
	private void CheckModelLod(float curZoom)
	{
	}

	// Token: 0x06001160 RID: 4448 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001160")]
	[Address(RVA = "0x1C50284", Offset = "0x1C50284", VA = "0x1C50284")]
	private void SetModelActive(int index)
	{
	}

	// Token: 0x06001161 RID: 4449 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001161")]
	[Address(RVA = "0x1C503EC", Offset = "0x1C503EC", VA = "0x1C503EC")]
	public void SetIsCanUpdate(bool param)
	{
	}

	// Token: 0x06001162 RID: 4450 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001162")]
	[Address(RVA = "0x1C503BC", Offset = "0x1C503BC", VA = "0x1C503BC")]
	public void FixAnimation()
	{
	}

	// Token: 0x06001163 RID: 4451 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001163")]
	[Address(RVA = "0x1C503F8", Offset = "0x1C503F8", VA = "0x1C503F8")]
	public SurvivalLodEx()
	{
	}

	// Token: 0x04001427 RID: 5159
	[Token(Token = "0x4001427")]
	[FieldOffset(Offset = "0x81")]
	public bool ModelLod;

	// Token: 0x04001428 RID: 5160
	[Token(Token = "0x4001428")]
	[FieldOffset(Offset = "0x88")]
	public List<Item> modelList;

	// Token: 0x04001429 RID: 5161
	[Token(Token = "0x4001429")]
	[FieldOffset(Offset = "0x90")]
	private bool m_isCanUpdate;

	// Token: 0x0400142A RID: 5162
	[Token(Token = "0x400142A")]
	[FieldOffset(Offset = "0x94")]
	private float m_curZoom;

	// Token: 0x0400142B RID: 5163
	[Token(Token = "0x400142B")]
	[FieldOffset(Offset = "0x98")]
	public Action<int, string> StateChangeCallback;

	// Token: 0x0400142C RID: 5164
	[Token(Token = "0x400142C")]
	[FieldOffset(Offset = "0xA0")]
	private bool m_initOk;

	// Token: 0x0400142D RID: 5165
	[Token(Token = "0x400142D")]
	[FieldOffset(Offset = "0xA8")]
	private string m_aniName;

	// Token: 0x0400142E RID: 5166
	[Token(Token = "0x400142E")]
	[FieldOffset(Offset = "0xB0")]
	private int m_curindex;

	// Token: 0x0400142F RID: 5167
	[Token(Token = "0x400142F")]
	[FieldOffset(Offset = "0xB8")]
	private Random m_random;
}
