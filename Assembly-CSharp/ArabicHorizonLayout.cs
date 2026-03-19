using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200031C RID: 796
[Token(Token = "0x200031C")]
[DisallowMultipleComponent]
public class ArabicHorizonLayout : MonoBehaviour
{
	// Token: 0x06001520 RID: 5408 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001520")]
	[Address(RVA = "0x1991C70", Offset = "0x1991C70", VA = "0x1991C70")]
	private void Start()
	{
	}

	// Token: 0x06001521 RID: 5409 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001521")]
	[Address(RVA = "0x19924CC", Offset = "0x19924CC", VA = "0x19924CC")]
	private IEnumerator DelayedCall()
	{
		return null;
	}

	// Token: 0x06001522 RID: 5410 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001522")]
	[Address(RVA = "0x1992568", Offset = "0x1992568", VA = "0x1992568")]
	public ArabicHorizonLayout()
	{
	}

	// Token: 0x04001806 RID: 6150
	[Token(Token = "0x4001806")]
	[FieldOffset(Offset = "0x18")]
	public bool IsReverseImage;

	// Token: 0x04001807 RID: 6151
	[Token(Token = "0x4001807")]
	[FieldOffset(Offset = "0x19")]
	public bool IsControlChildWidth;

	// Token: 0x04001808 RID: 6152
	[Token(Token = "0x4001808")]
	[FieldOffset(Offset = "0x1A")]
	public bool IsChildForceExpandWidth;

	// Token: 0x04001809 RID: 6153
	[Token(Token = "0x4001809")]
	[FieldOffset(Offset = "0x1C")]
	public ArabicHorizonLayout.AlignmentType TextAlignType;

	// Token: 0x0400180A RID: 6154
	[Token(Token = "0x400180A")]
	[FieldOffset(Offset = "0x20")]
	public TextAnchor ChildAlignment;

	// Token: 0x0400180B RID: 6155
	[Token(Token = "0x400180B")]
	[FieldOffset(Offset = "0x24")]
	public bool IsDisableChildContentSizeFitter;

	// Token: 0x0400180C RID: 6156
	[Token(Token = "0x400180C")]
	[FieldOffset(Offset = "0x25")]
	[Header("Mirror版本控制")]
	[Tooltip("是否与Mirror版本一起上线")]
	public bool IsControlledByMirror;

	// Token: 0x0200031D RID: 797
	[Token(Token = "0x200031D")]
	private enum _HorizontalAlignmentOptions
	{
		// Token: 0x0400180E RID: 6158
		[Token(Token = "0x400180E")]
		Left = 1,
		// Token: 0x0400180F RID: 6159
		[Token(Token = "0x400180F")]
		Center,
		// Token: 0x04001810 RID: 6160
		[Token(Token = "0x4001810")]
		Right = 4,
		// Token: 0x04001811 RID: 6161
		[Token(Token = "0x4001811")]
		Justified = 8,
		// Token: 0x04001812 RID: 6162
		[Token(Token = "0x4001812")]
		Flush = 16,
		// Token: 0x04001813 RID: 6163
		[Token(Token = "0x4001813")]
		Geometry = 32
	}

	// Token: 0x0200031E RID: 798
	[Token(Token = "0x200031E")]
	private enum _VerticalAlignmentOptions
	{
		// Token: 0x04001815 RID: 6165
		[Token(Token = "0x4001815")]
		Top = 256,
		// Token: 0x04001816 RID: 6166
		[Token(Token = "0x4001816")]
		Middle = 512,
		// Token: 0x04001817 RID: 6167
		[Token(Token = "0x4001817")]
		Bottom = 1024,
		// Token: 0x04001818 RID: 6168
		[Token(Token = "0x4001818")]
		Baseline = 2048,
		// Token: 0x04001819 RID: 6169
		[Token(Token = "0x4001819")]
		Geometry = 4096,
		// Token: 0x0400181A RID: 6170
		[Token(Token = "0x400181A")]
		Capline = 8192
	}

	// Token: 0x0200031F RID: 799
	[Token(Token = "0x200031F")]
	public enum AlignmentType
	{
		// Token: 0x0400181C RID: 6172
		[Token(Token = "0x400181C")]
		NoControl = 1,
		// Token: 0x0400181D RID: 6173
		[Token(Token = "0x400181D")]
		AllLeftAlign,
		// Token: 0x0400181E RID: 6174
		[Token(Token = "0x400181E")]
		AllRightAlign,
		// Token: 0x0400181F RID: 6175
		[Token(Token = "0x400181F")]
		FirstLeftAndLastRight,
		// Token: 0x04001820 RID: 6176
		[Token(Token = "0x4001820")]
		FirstRightAndLastLeft
	}
}
