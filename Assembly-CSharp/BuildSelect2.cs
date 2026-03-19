using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000279 RID: 633
[Token(Token = "0x2000279")]
public class BuildSelect2 : MonoBehaviour
{
	// Token: 0x060010B6 RID: 4278 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010B6")]
	[Address(RVA = "0x1BF1EC8", Offset = "0x1BF1EC8", VA = "0x1BF1EC8")]
	private void Awake()
	{
	}

	// Token: 0x060010B7 RID: 4279 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010B7")]
	[Address(RVA = "0x1BF2034", Offset = "0x1BF2034", VA = "0x1BF2034")]
	public void ChangeAllColor()
	{
	}

	// Token: 0x060010B8 RID: 4280 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010B8")]
	[Address(RVA = "0x1BF2040", Offset = "0x1BF2040", VA = "0x1BF2040")]
	public void ChangeColorByIndex(int index)
	{
	}

	// Token: 0x060010B9 RID: 4281 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010B9")]
	[Address(RVA = "0x1BF2048", Offset = "0x1BF2048", VA = "0x1BF2048")]
	public void ResetColor()
	{
	}

	// Token: 0x060010BA RID: 4282 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010BA")]
	[Address(RVA = "0x1BF1F44", Offset = "0x1BF1F44", VA = "0x1BF1F44")]
	private void SetColor(int index)
	{
	}

	// Token: 0x060010BB RID: 4283 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010BB")]
	[Address(RVA = "0x1BF20C8", Offset = "0x1BF20C8", VA = "0x1BF20C8")]
	public void SetVisible(int index, bool b)
	{
	}

	// Token: 0x060010BC RID: 4284 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010BC")]
	[Address(RVA = "0x1BF2124", Offset = "0x1BF2124", VA = "0x1BF2124")]
	public BuildSelect2()
	{
	}

	// Token: 0x04001386 RID: 4998
	[Token(Token = "0x4001386")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private MeshRenderer[] _diMeshRenderer;

	// Token: 0x04001387 RID: 4999
	[Token(Token = "0x4001387")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private MeshRenderer[] _arrowMeshRenderer;

	// Token: 0x04001388 RID: 5000
	[Token(Token = "0x4001388")]
	[FieldOffset(Offset = "0x28")]
	private bool _isOk;

	// Token: 0x04001389 RID: 5001
	[Token(Token = "0x4001389")]
	[FieldOffset(Offset = "0x30")]
	private MaterialPropertyBlock _diBlock;

	// Token: 0x0400138A RID: 5002
	[Token(Token = "0x400138A")]
	[FieldOffset(Offset = "0x0")]
	private static int _ColorSwitch;

	// Token: 0x0400138B RID: 5003
	[Token(Token = "0x400138B")]
	[FieldOffset(Offset = "0x38")]
	private int testIndex;

	// Token: 0x0400138C RID: 5004
	[Token(Token = "0x400138C")]
	[FieldOffset(Offset = "0x3C")]
	public bool isRun;

	// Token: 0x0400138D RID: 5005
	[Token(Token = "0x400138D")]
	[FieldOffset(Offset = "0x3D")]
	public bool isReset;
}
