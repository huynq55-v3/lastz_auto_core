using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200024C RID: 588
[Token(Token = "0x200024C")]
[ExecuteAlways]
public class CameraCapture : MonoBehaviour
{
	// Token: 0x06000FC6 RID: 4038 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FC6")]
	[Address(RVA = "0x1BE7D90", Offset = "0x1BE7D90", VA = "0x1BE7D90")]
	private void Update()
	{
	}

	// Token: 0x06000FC7 RID: 4039 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FC7")]
	[Address(RVA = "0x1BE7DC0", Offset = "0x1BE7DC0", VA = "0x1BE7DC0")]
	public void CaptureScreenshot()
	{
	}

	// Token: 0x06000FC8 RID: 4040 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FC8")]
	[Address(RVA = "0x1BE7DE0", Offset = "0x1BE7DE0", VA = "0x1BE7DE0")]
	private IEnumerator CaptureCoroutine()
	{
		return null;
	}

	// Token: 0x06000FC9 RID: 4041 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FC9")]
	[Address(RVA = "0x1BE7E7C", Offset = "0x1BE7E7C", VA = "0x1BE7E7C")]
	public Texture2D CaptureToTexture()
	{
		return null;
	}

	// Token: 0x06000FCA RID: 4042 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FCA")]
	[Address(RVA = "0x1BE8008", Offset = "0x1BE8008", VA = "0x1BE8008")]
	public CameraCapture()
	{
	}

	// Token: 0x04001242 RID: 4674
	[Token(Token = "0x4001242")]
	[FieldOffset(Offset = "0x18")]
	public Camera targetCamera;

	// Token: 0x04001243 RID: 4675
	[Token(Token = "0x4001243")]
	[FieldOffset(Offset = "0x20")]
	public int resolutionWidth;

	// Token: 0x04001244 RID: 4676
	[Token(Token = "0x4001244")]
	[FieldOffset(Offset = "0x24")]
	public int resolutionHeight;

	// Token: 0x04001245 RID: 4677
	[Token(Token = "0x4001245")]
	[FieldOffset(Offset = "0x28")]
	public string savePath;

	// Token: 0x04001246 RID: 4678
	[Token(Token = "0x4001246")]
	[FieldOffset(Offset = "0x30")]
	public bool IsCapture;
}
