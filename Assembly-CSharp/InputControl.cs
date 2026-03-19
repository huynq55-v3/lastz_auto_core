using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000108 RID: 264
[Token(Token = "0x2000108")]
public class InputControl : MonoBehaviour
{
	// Token: 0x14000003 RID: 3
	// (add) Token: 0x06000771 RID: 1905 RVA: 0x00002053 File Offset: 0x00000253
	// (remove) Token: 0x06000772 RID: 1906 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x14000003")]
	public event MouseDownEvent EVENT_MOUSE_DOWN
	{
		[Token(Token = "0x6000771")]
		[Address(RVA = "0x3478D0C", Offset = "0x3478D0C", VA = "0x3478D0C")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000772")]
		[Address(RVA = "0x3478DA8", Offset = "0x3478DA8", VA = "0x3478DA8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	// Token: 0x14000004 RID: 4
	// (add) Token: 0x06000773 RID: 1907 RVA: 0x00002053 File Offset: 0x00000253
	// (remove) Token: 0x06000774 RID: 1908 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x14000004")]
	public event MouseUpEvent EVENT_MOUSE_UP
	{
		[Token(Token = "0x6000773")]
		[Address(RVA = "0x3478E44", Offset = "0x3478E44", VA = "0x3478E44")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000774")]
		[Address(RVA = "0x3478EE0", Offset = "0x3478EE0", VA = "0x3478EE0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	// Token: 0x14000005 RID: 5
	// (add) Token: 0x06000775 RID: 1909 RVA: 0x00002053 File Offset: 0x00000253
	// (remove) Token: 0x06000776 RID: 1910 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x14000005")]
	public event MouseDragEvent EVENT_MOUSE_DRAG
	{
		[Token(Token = "0x6000775")]
		[Address(RVA = "0x3478F7C", Offset = "0x3478F7C", VA = "0x3478F7C")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000776")]
		[Address(RVA = "0x3479018", Offset = "0x3479018", VA = "0x3479018")]
		[CompilerGenerated]
		remove
		{
		}
	}

	// Token: 0x14000006 RID: 6
	// (add) Token: 0x06000777 RID: 1911 RVA: 0x00002053 File Offset: 0x00000253
	// (remove) Token: 0x06000778 RID: 1912 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x14000006")]
	public event MouseClickEvent EVENT_MOUSE_CLICK
	{
		[Token(Token = "0x6000777")]
		[Address(RVA = "0x34790B4", Offset = "0x34790B4", VA = "0x34790B4")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000778")]
		[Address(RVA = "0x3479150", Offset = "0x3479150", VA = "0x3479150")]
		[CompilerGenerated]
		remove
		{
		}
	}

	// Token: 0x06000779 RID: 1913 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000779")]
	[Address(RVA = "0x34791EC", Offset = "0x34791EC", VA = "0x34791EC")]
	private void Awake()
	{
	}

	// Token: 0x0600077A RID: 1914 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600077A")]
	[Address(RVA = "0x3479324", Offset = "0x3479324", VA = "0x3479324")]
	private void Start()
	{
	}

	// Token: 0x0600077B RID: 1915 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600077B")]
	[Address(RVA = "0x347932C", Offset = "0x347932C", VA = "0x347932C")]
	private void AvoidEmpty(Vector2 noUse)
	{
	}

	// Token: 0x0600077C RID: 1916 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600077C")]
	[Address(RVA = "0x3479330", Offset = "0x3479330", VA = "0x3479330")]
	private void Update()
	{
	}

	// Token: 0x0600077D RID: 1917 RVA: 0x000046B0 File Offset: 0x000028B0
	[Token(Token = "0x600077D")]
	[Address(RVA = "0x3479448", Offset = "0x3479448", VA = "0x3479448")]
	private static bool JudgeMove(Vector2 p1, Vector2 p2)
	{
		return default(bool);
	}

	// Token: 0x0600077E RID: 1918 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600077E")]
	[Address(RVA = "0x3479470", Offset = "0x3479470", VA = "0x3479470")]
	public InputControl()
	{
	}

	// Token: 0x04000572 RID: 1394
	[Token(Token = "0x4000572")]
	[FieldOffset(Offset = "0x18")]
	private bool isPress;

	// Token: 0x04000573 RID: 1395
	[Token(Token = "0x4000573")]
	[FieldOffset(Offset = "0x19")]
	private bool isClick;

	// Token: 0x04000574 RID: 1396
	[Token(Token = "0x4000574")]
	[FieldOffset(Offset = "0x1A")]
	private bool tempPress;

	// Token: 0x04000575 RID: 1397
	[Token(Token = "0x4000575")]
	[FieldOffset(Offset = "0x1C")]
	private Vector2 oldMousePosition;

	// Token: 0x04000576 RID: 1398
	[Token(Token = "0x4000576")]
	[FieldOffset(Offset = "0x24")]
	private Vector2 tempMousePosition;

	// Token: 0x0400057B RID: 1403
	[Token(Token = "0x400057B")]
	public const float JUDGE_DISTANCE = 1f;
}
