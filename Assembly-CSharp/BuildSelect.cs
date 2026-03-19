using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000335 RID: 821
[Token(Token = "0x2000335")]
public class BuildSelect : MonoBehaviour
{
	// Token: 0x0600157C RID: 5500 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600157C")]
	[Address(RVA = "0x1ED22D8", Offset = "0x1ED22D8", VA = "0x1ED22D8")]
	private void Awake()
	{
	}

	// Token: 0x0600157D RID: 5501 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600157D")]
	[Address(RVA = "0x1ED2470", Offset = "0x1ED2470", VA = "0x1ED2470")]
	public void ChangeColor(bool isOk)
	{
	}

	// Token: 0x0600157E RID: 5502 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600157E")]
	[Address(RVA = "0x1ED2350", Offset = "0x1ED2350", VA = "0x1ED2350")]
	private void SetColor()
	{
	}

	// Token: 0x0600157F RID: 5503 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600157F")]
	[Address(RVA = "0x1ED248C", Offset = "0x1ED248C", VA = "0x1ED248C")]
	public BuildSelect()
	{
	}

	// Token: 0x0400186C RID: 6252
	[Token(Token = "0x400186C")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private MeshRenderer[] _diMeshRenderer;

	// Token: 0x0400186D RID: 6253
	[Token(Token = "0x400186D")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private MeshRenderer[] _arrowMeshRenderer;

	// Token: 0x0400186E RID: 6254
	[Token(Token = "0x400186E")]
	[FieldOffset(Offset = "0x28")]
	private bool _isOk;

	// Token: 0x0400186F RID: 6255
	[Token(Token = "0x400186F")]
	[FieldOffset(Offset = "0x30")]
	private MaterialPropertyBlock _diBlock;

	// Token: 0x04001870 RID: 6256
	[Token(Token = "0x4001870")]
	[FieldOffset(Offset = "0x0")]
	private static int _ColorSwitch;
}
