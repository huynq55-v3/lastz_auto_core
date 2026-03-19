using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

// Token: 0x02000268 RID: 616
[Token(Token = "0x2000268")]
[RequireComponent(typeof(RawImage))]
public class ScreenCaptureBeforeUI : MonoBehaviour
{
	// Token: 0x0600104A RID: 4170 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600104A")]
	[Address(RVA = "0x1BECB1C", Offset = "0x1BECB1C", VA = "0x1BECB1C")]
	private void Awake()
	{
	}

	// Token: 0x0600104B RID: 4171 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600104B")]
	[Address(RVA = "0x1BECB74", Offset = "0x1BECB74", VA = "0x1BECB74")]
	private void OnDisable()
	{
	}

	// Token: 0x0600104C RID: 4172 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600104C")]
	[Address(RVA = "0x1BECC80", Offset = "0x1BECC80", VA = "0x1BECC80")]
	private void OnEnable()
	{
	}

	// Token: 0x0600104D RID: 4173 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600104D")]
	[Address(RVA = "0x1BECDE4", Offset = "0x1BECDE4", VA = "0x1BECDE4")]
	private void CaptureAction(RenderTargetIdentifier arg1, CommandBuffer arg2)
	{
	}

	// Token: 0x0600104E RID: 4174 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600104E")]
	[Address(RVA = "0x1BECFB0", Offset = "0x1BECFB0", VA = "0x1BECFB0")]
	public ScreenCaptureBeforeUI()
	{
	}

	// Token: 0x040012DA RID: 4826
	[Token(Token = "0x40012DA")]
	[FieldOffset(Offset = "0x18")]
	private Camera uiCamera;

	// Token: 0x040012DB RID: 4827
	[Token(Token = "0x40012DB")]
	[FieldOffset(Offset = "0x20")]
	private RawImage raw;

	// Token: 0x040012DC RID: 4828
	[Token(Token = "0x40012DC")]
	[FieldOffset(Offset = "0x28")]
	private bool isCapter;

	// Token: 0x040012DD RID: 4829
	[Token(Token = "0x40012DD")]
	[FieldOffset(Offset = "0x29")]
	private bool _captured;

	// Token: 0x040012DE RID: 4830
	[Token(Token = "0x40012DE")]
	[FieldOffset(Offset = "0x30")]
	private RenderTexture renderBuffer;

	// Token: 0x040012DF RID: 4831
	[Token(Token = "0x40012DF")]
	[FieldOffset(Offset = "0x38")]
	private int int_CameraGrabUI;
}
