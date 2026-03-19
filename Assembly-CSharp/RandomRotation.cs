using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200009A RID: 154
[Token(Token = "0x200009A")]
public class RandomRotation : MonoBehaviour
{
	// Token: 0x0600039E RID: 926 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600039E")]
	[Address(RVA = "0x32166BC", Offset = "0x32166BC", VA = "0x32166BC")]
	private void Awake()
	{
	}

	// Token: 0x0600039F RID: 927 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600039F")]
	[Address(RVA = "0x32166EC", Offset = "0x32166EC", VA = "0x32166EC")]
	private void Start()
	{
	}

	// Token: 0x060003A0 RID: 928 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003A0")]
	[Address(RVA = "0x3216808", Offset = "0x3216808", VA = "0x3216808")]
	private void OnEnable()
	{
	}

	// Token: 0x060003A1 RID: 929 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003A1")]
	[Address(RVA = "0x32166FC", Offset = "0x32166FC", VA = "0x32166FC")]
	[ContextMenu("应用随机旋转")]
	public void ApplyRandomRotation()
	{
	}

	// Token: 0x060003A2 RID: 930 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003A2")]
	[Address(RVA = "0x3216820", Offset = "0x3216820", VA = "0x3216820")]
	[ContextMenu("重置旋转")]
	public void ResetRotation()
	{
	}

	// Token: 0x060003A3 RID: 931 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003A3")]
	[Address(RVA = "0x3216854", Offset = "0x3216854", VA = "0x3216854")]
	public void SetAngleRange(float newMinAngle, float newMaxAngle)
	{
	}

	// Token: 0x060003A4 RID: 932 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003A4")]
	[Address(RVA = "0x321688C", Offset = "0x321688C", VA = "0x321688C")]
	public void SetRotationAxis(RandomRotation.RotationAxis axis)
	{
	}

	// Token: 0x060003A5 RID: 933 RVA: 0x00003120 File Offset: 0x00001320
	[Token(Token = "0x60003A5")]
	[Address(RVA = "0x3216894", Offset = "0x3216894", VA = "0x3216894")]
	public Vector3 GetOriginalRotation()
	{
		return default(Vector3);
	}

	// Token: 0x060003A6 RID: 934 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003A6")]
	[Address(RVA = "0x32168A0", Offset = "0x32168A0", VA = "0x32168A0")]
	private void OnValidate()
	{
	}

	// Token: 0x060003A7 RID: 935 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003A7")]
	[Address(RVA = "0x32168B4", Offset = "0x32168B4", VA = "0x32168B4")]
	public RandomRotation()
	{
	}

	// Token: 0x04000331 RID: 817
	[Token(Token = "0x4000331")]
	[FieldOffset(Offset = "0x18")]
	[Header("旋转设置")]
	[Tooltip("旋转轴向")]
	public RandomRotation.RotationAxis rotationAxis;

	// Token: 0x04000332 RID: 818
	[Token(Token = "0x4000332")]
	[FieldOffset(Offset = "0x1C")]
	[Range(0f, 360f)]
	[Tooltip("最小旋转角度")]
	public float minAngle;

	// Token: 0x04000333 RID: 819
	[Token(Token = "0x4000333")]
	[FieldOffset(Offset = "0x20")]
	[Range(0f, 360f)]
	[Tooltip("最大旋转角度")]
	public float maxAngle;

	// Token: 0x04000334 RID: 820
	[Token(Token = "0x4000334")]
	[FieldOffset(Offset = "0x24")]
	[Tooltip("是否在Start时立即应用随机旋转")]
	[Header("控制选项")]
	public bool applyOnStart;

	// Token: 0x04000335 RID: 821
	[Token(Token = "0x4000335")]
	[FieldOffset(Offset = "0x25")]
	[Tooltip("是否在每次激活时重新随机旋转")]
	public bool reapplyOnEnable;

	// Token: 0x04000336 RID: 822
	[Token(Token = "0x4000336")]
	[FieldOffset(Offset = "0x26")]
	[Tooltip("是否保持原始旋转作为基准")]
	public bool useOriginalRotationAsBase;

	// Token: 0x04000337 RID: 823
	[Token(Token = "0x4000337")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Tooltip("原始旋转")]
	private Vector3 originalRotation;

	// Token: 0x04000338 RID: 824
	[Token(Token = "0x4000338")]
	[FieldOffset(Offset = "0x34")]
	private bool hasAppliedRotation;

	// Token: 0x0200009B RID: 155
	[Token(Token = "0x200009B")]
	public enum RotationAxis
	{
		// Token: 0x0400033A RID: 826
		[Token(Token = "0x400033A")]
		X,
		// Token: 0x0400033B RID: 827
		[Token(Token = "0x400033B")]
		Y,
		// Token: 0x0400033C RID: 828
		[Token(Token = "0x400033C")]
		Z
	}
}
