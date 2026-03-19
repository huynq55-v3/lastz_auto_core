using System;
using BitBenderGames;
using Il2CppDummyDll;
using RealisticEyeMovements;
using UnityEngine;

// Token: 0x02000029 RID: 41
[Token(Token = "0x2000029")]
public class GirlHeadTargetController : MonoBehaviour
{
	// Token: 0x06000073 RID: 115 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000073")]
	[Address(RVA = "0x15E5CD0", Offset = "0x15E5CD0", VA = "0x15E5CD0")]
	private void Awake()
	{
	}

	// Token: 0x06000074 RID: 116 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000074")]
	[Address(RVA = "0x15E5D7C", Offset = "0x15E5D7C", VA = "0x15E5D7C")]
	private void Start()
	{
	}

	// Token: 0x06000075 RID: 117 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000075")]
	[Address(RVA = "0x15E5DC8", Offset = "0x15E5DC8", VA = "0x15E5DC8")]
	private void Update()
	{
	}

	// Token: 0x06000076 RID: 118 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000076")]
	[Address(RVA = "0x15E5F3C", Offset = "0x15E5F3C", VA = "0x15E5F3C")]
	public GirlHeadTargetController()
	{
	}

	// Token: 0x040000D8 RID: 216
	[Token(Token = "0x40000D8")]
	[FieldOffset(Offset = "0x18")]
	private Transform tran;

	// Token: 0x040000D9 RID: 217
	[Token(Token = "0x40000D9")]
	[FieldOffset(Offset = "0x20")]
	private TouchInputController touchInputControll;

	// Token: 0x040000DA RID: 218
	[Token(Token = "0x40000DA")]
	[FieldOffset(Offset = "0x28")]
	private LookTargetController targetControl;

	// Token: 0x040000DB RID: 219
	[Token(Token = "0x40000DB")]
	[FieldOffset(Offset = "0x30")]
	public EyeAndHeadAnimator animator;

	// Token: 0x040000DC RID: 220
	[Token(Token = "0x40000DC")]
	[FieldOffset(Offset = "0x38")]
	public int maxX;

	// Token: 0x040000DD RID: 221
	[Token(Token = "0x40000DD")]
	[FieldOffset(Offset = "0x3C")]
	private float addHoriz;

	// Token: 0x040000DE RID: 222
	[Token(Token = "0x40000DE")]
	[FieldOffset(Offset = "0x40")]
	private float addTowards;

	// Token: 0x040000DF RID: 223
	[Token(Token = "0x40000DF")]
	[FieldOffset(Offset = "0x44")]
	private float minaAdHoriz;

	// Token: 0x040000E0 RID: 224
	[Token(Token = "0x40000E0")]
	[FieldOffset(Offset = "0x48")]
	private float minAddTowards;

	// Token: 0x040000E1 RID: 225
	[Token(Token = "0x40000E1")]
	[FieldOffset(Offset = "0x4C")]
	private float maxAdHorize;

	// Token: 0x040000E2 RID: 226
	[Token(Token = "0x40000E2")]
	[FieldOffset(Offset = "0x50")]
	private float maxAddTowards;

	// Token: 0x040000E3 RID: 227
	[Token(Token = "0x40000E3")]
	[FieldOffset(Offset = "0x54")]
	private GirlHeadTargetController.UpdateStatus upateStatus;

	// Token: 0x040000E4 RID: 228
	[Token(Token = "0x40000E4")]
	[FieldOffset(Offset = "0x58")]
	private float speed;

	// Token: 0x0200002A RID: 42
	[Token(Token = "0x200002A")]
	private enum UpdateStatus
	{
		// Token: 0x040000E6 RID: 230
		[Token(Token = "0x40000E6")]
		Up,
		// Token: 0x040000E7 RID: 231
		[Token(Token = "0x40000E7")]
		Down,
		// Token: 0x040000E8 RID: 232
		[Token(Token = "0x40000E8")]
		None
	}
}
