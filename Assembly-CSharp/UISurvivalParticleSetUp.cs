using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000B1 RID: 177
[Token(Token = "0x20000B1")]
[ExecuteInEditMode]
public class UISurvivalParticleSetUp : UIParticleSetUpBase
{
	// Token: 0x0600041C RID: 1052 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600041C")]
	[Address(RVA = "0x2F6A498", Offset = "0x2F6A498", VA = "0x2F6A498")]
	private void Start()
	{
	}

	// Token: 0x0600041D RID: 1053 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600041D")]
	[Address(RVA = "0x2F6A4A0", Offset = "0x2F6A4A0", VA = "0x2F6A4A0")]
	public void Refresh(bool includeInactive = false)
	{
	}

	// Token: 0x0600041E RID: 1054 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600041E")]
	[Address(RVA = "0x2F6A7C4", Offset = "0x2F6A7C4", VA = "0x2F6A7C4")]
	public void RefreshForHeadSpine()
	{
	}

	// Token: 0x0600041F RID: 1055 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600041F")]
	[Address(RVA = "0x2F6A874", Offset = "0x2F6A874", VA = "0x2F6A874")]
	public void SetLocalOrder(int order)
	{
	}

	// Token: 0x06000420 RID: 1056 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000420")]
	[Address(RVA = "0x2F6A880", Offset = "0x2F6A880", VA = "0x2F6A880")]
	public UISurvivalParticleSetUp()
	{
	}

	// Token: 0x040003D8 RID: 984
	[Token(Token = "0x40003D8")]
	[FieldOffset(Offset = "0x18")]
	public int parentSortingOrder;

	// Token: 0x040003D9 RID: 985
	[Token(Token = "0x40003D9")]
	[FieldOffset(Offset = "0x1C")]
	public int finalOrderInLayer;

	// Token: 0x040003DA RID: 986
	[Token(Token = "0x40003DA")]
	[FieldOffset(Offset = "0x20")]
	public int orderInLayer;

	// Token: 0x040003DB RID: 987
	[Token(Token = "0x40003DB")]
	[FieldOffset(Offset = "0x28")]
	public UISurvivalParticleSetUp.SpecialNodeCfg[] specialNodeList;

	// Token: 0x020000B2 RID: 178
	[Token(Token = "0x20000B2")]
	[Serializable]
	public class SpecialNodeCfg
	{
		// Token: 0x06000421 RID: 1057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000421")]
		[Address(RVA = "0x2F6A890", Offset = "0x2F6A890", VA = "0x2F6A890")]
		public SpecialNodeCfg()
		{
		}

		// Token: 0x040003DC RID: 988
		[Token(Token = "0x40003DC")]
		[FieldOffset(Offset = "0x10")]
		public Renderer render;

		// Token: 0x040003DD RID: 989
		[Token(Token = "0x40003DD")]
		[FieldOffset(Offset = "0x18")]
		public int order;
	}
}
