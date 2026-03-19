using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000261 RID: 609
[Token(Token = "0x2000261")]
[ExecuteInEditMode]
public class ParticleRectMask2D : MonoBehaviour
{
	// Token: 0x0600102F RID: 4143 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600102F")]
	[Address(RVA = "0x1BEB808", Offset = "0x1BEB808", VA = "0x1BEB808")]
	private void Awake()
	{
	}

	// Token: 0x06001030 RID: 4144 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001030")]
	[Address(RVA = "0x1BEB8A8", Offset = "0x1BEB8A8", VA = "0x1BEB8A8")]
	private void OnEnable()
	{
	}

	// Token: 0x06001031 RID: 4145 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001031")]
	[Address(RVA = "0x1BEBB0C", Offset = "0x1BEBB0C", VA = "0x1BEBB0C")]
	private void Start()
	{
	}

	// Token: 0x06001032 RID: 4146 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001032")]
	[Address(RVA = "0x1BEB950", Offset = "0x1BEB950", VA = "0x1BEB950")]
	public void ReInitialize()
	{
	}

	// Token: 0x06001033 RID: 4147 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001033")]
	[Address(RVA = "0x1BEBB10", Offset = "0x1BEBB10", VA = "0x1BEBB10")]
	private void OnDisable()
	{
	}

	// Token: 0x06001034 RID: 4148 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001034")]
	[Address(RVA = "0x1BEBC90", Offset = "0x1BEBC90", VA = "0x1BEBC90")]
	private void UpdateClip()
	{
	}

	// Token: 0x06001035 RID: 4149 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001035")]
	[Address(RVA = "0x1BEBD94", Offset = "0x1BEBD94", VA = "0x1BEBD94")]
	private void FindRectMask()
	{
	}

	// Token: 0x06001036 RID: 4150 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001036")]
	[Address(RVA = "0x1BEC0A8", Offset = "0x1BEC0A8", VA = "0x1BEC0A8")]
	private RectMask2D FindRectMaskInParent(Transform current)
	{
		return null;
	}

	// Token: 0x06001037 RID: 4151 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001037")]
	[Address(RVA = "0x1BEBE1C", Offset = "0x1BEBE1C", VA = "0x1BEBE1C")]
	public void EnableClippingKeywords()
	{
	}

	// Token: 0x06001038 RID: 4152 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001038")]
	[Address(RVA = "0x1BEBA08", Offset = "0x1BEBA08", VA = "0x1BEBA08")]
	private void DisablelippingKeywords()
	{
	}

	// Token: 0x06001039 RID: 4153 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001039")]
	[Address(RVA = "0x1BEBF20", Offset = "0x1BEBF20", VA = "0x1BEBF20")]
	private void UpdateClipping()
	{
	}

	// Token: 0x0600103A RID: 4154 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600103A")]
	[Address(RVA = "0x1BEC184", Offset = "0x1BEC184", VA = "0x1BEC184")]
	private void ResetClipping()
	{
	}

	// Token: 0x0600103B RID: 4155 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600103B")]
	[Address(RVA = "0x1BEC2E0", Offset = "0x1BEC2E0", VA = "0x1BEC2E0")]
	private void OnTransformParentChanged()
	{
	}

	// Token: 0x0600103C RID: 4156 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600103C")]
	[Address(RVA = "0x1BEC370", Offset = "0x1BEC370", VA = "0x1BEC370")]
	private void OnDestroy()
	{
	}

	// Token: 0x0600103D RID: 4157 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600103D")]
	[Address(RVA = "0x1BEBB38", Offset = "0x1BEBB38", VA = "0x1BEBB38")]
	private void ClearPropertyBlocks()
	{
	}

	// Token: 0x0600103E RID: 4158 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600103E")]
	[Address(RVA = "0x1BEC374", Offset = "0x1BEC374", VA = "0x1BEC374")]
	public ParticleRectMask2D()
	{
	}

	// Token: 0x040012A7 RID: 4775
	[Token(Token = "0x40012A7")]
	[FieldOffset(Offset = "0x18")]
	[Header("\ufffd\ufffd\ufffd\ufffd")]
	public bool updateEveryFrame;

	// Token: 0x040012A8 RID: 4776
	[Token(Token = "0x40012A8")]
	[FieldOffset(Offset = "0x19")]
	public bool includeChildren;

	// Token: 0x040012A9 RID: 4777
	[Token(Token = "0x40012A9")]
	private const int findRectMaxTimes = 100;

	// Token: 0x040012AA RID: 4778
	[Token(Token = "0x40012AA")]
	[FieldOffset(Offset = "0x1C")]
	private int findTimes;

	// Token: 0x040012AB RID: 4779
	[Token(Token = "0x40012AB")]
	[FieldOffset(Offset = "0x20")]
	private RectMask2D _rectMask;

	// Token: 0x040012AC RID: 4780
	[Token(Token = "0x40012AC")]
	[FieldOffset(Offset = "0x28")]
	private ParticleSystemRenderer[] _renderers;

	// Token: 0x040012AD RID: 4781
	[Token(Token = "0x40012AD")]
	[FieldOffset(Offset = "0x30")]
	public ParticleRectMask2D.UpdateStatus status;

	// Token: 0x040012AE RID: 4782
	[Token(Token = "0x40012AE")]
	[FieldOffset(Offset = "0x38")]
	private MaterialPropertyBlock _block;

	// Token: 0x02000262 RID: 610
	[Token(Token = "0x2000262")]
	public enum UpdateStatus
	{
		// Token: 0x040012B0 RID: 4784
		[Token(Token = "0x40012B0")]
		FindMask,
		// Token: 0x040012B1 RID: 4785
		[Token(Token = "0x40012B1")]
		EnableKeyworlds,
		// Token: 0x040012B2 RID: 4786
		[Token(Token = "0x40012B2")]
		UpdateValue
	}
}
