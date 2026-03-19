using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000276 RID: 630
[Token(Token = "0x2000276")]
public class ResourceUpEffect : MonoBehaviour
{
	// Token: 0x060010AB RID: 4267 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010AB")]
	[Address(RVA = "0x1BF1AE0", Offset = "0x1BF1AE0", VA = "0x1BF1AE0")]
	public void Init(object userData)
	{
	}

	// Token: 0x060010AC RID: 4268 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010AC")]
	[Address(RVA = "0x1BF1CD4", Offset = "0x1BF1CD4", VA = "0x1BF1CD4")]
	private void Update()
	{
	}

	// Token: 0x060010AD RID: 4269 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010AD")]
	[Address(RVA = "0x1BF1E3C", Offset = "0x1BF1E3C", VA = "0x1BF1E3C")]
	private void OnDisable()
	{
	}

	// Token: 0x060010AE RID: 4270 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010AE")]
	[Address(RVA = "0x1BF1E70", Offset = "0x1BF1E70", VA = "0x1BF1E70")]
	public ResourceUpEffect()
	{
	}

	// Token: 0x04001379 RID: 4985
	[Token(Token = "0x4001379")]
	[FieldOffset(Offset = "0x18")]
	private ResourceUpEffect.Param paramData;

	// Token: 0x0400137A RID: 4986
	[Token(Token = "0x400137A")]
	[FieldOffset(Offset = "0x20")]
	private float _time;

	// Token: 0x0400137B RID: 4987
	[Token(Token = "0x400137B")]
	[FieldOffset(Offset = "0x24")]
	private Vector3 _startPos;

	// Token: 0x02000277 RID: 631
	[Token(Token = "0x2000277")]
	public class Param
	{
		// Token: 0x060010AF RID: 4271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60010AF")]
		[Address(RVA = "0x1BF1E78", Offset = "0x1BF1E78", VA = "0x1BF1E78")]
		public Param()
		{
		}

		// Token: 0x0400137C RID: 4988
		[Token(Token = "0x400137C")]
		[FieldOffset(Offset = "0x10")]
		public Vector3 worldPos;

		// Token: 0x0400137D RID: 4989
		[Token(Token = "0x400137D")]
		[FieldOffset(Offset = "0x20")]
		public Transform target;

		// Token: 0x0400137E RID: 4990
		[Token(Token = "0x400137E")]
		[FieldOffset(Offset = "0x28")]
		public ResourceType resType;

		// Token: 0x0400137F RID: 4991
		[Token(Token = "0x400137F")]
		[FieldOffset(Offset = "0x30")]
		public Action EffectUpDone;

		// Token: 0x04001380 RID: 4992
		[Token(Token = "0x4001380")]
		[FieldOffset(Offset = "0x38")]
		public bool notTrans;
	}
}
