using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200025E RID: 606
[Token(Token = "0x200025E")]
[RequireComponent(typeof(RenderSettingAuto))]
public class LevelRenderingSetting : MonoBehaviour
{
	// Token: 0x0600101D RID: 4125 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600101D")]
	[Address(RVA = "0x1BEACB8", Offset = "0x1BEACB8", VA = "0x1BEACB8")]
	private void Awake()
	{
	}

	// Token: 0x0600101E RID: 4126 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600101E")]
	[Address(RVA = "0x1BEAD10", Offset = "0x1BEAD10", VA = "0x1BEAD10")]
	private void OnEnable()
	{
	}

	// Token: 0x0600101F RID: 4127 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600101F")]
	[Address(RVA = "0x1BEADF0", Offset = "0x1BEADF0", VA = "0x1BEADF0")]
	private IEnumerator ResetRender()
	{
		return null;
	}

	// Token: 0x06001020 RID: 4128 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001020")]
	[Address(RVA = "0x1BEAE8C", Offset = "0x1BEAE8C", VA = "0x1BEAE8C")]
	private void Update()
	{
	}

	// Token: 0x06001021 RID: 4129 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001021")]
	[Address(RVA = "0x1BEAF54", Offset = "0x1BEAF54", VA = "0x1BEAF54")]
	private void OnDisable()
	{
	}

	// Token: 0x06001022 RID: 4130 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001022")]
	[Address(RVA = "0x1BEAF90", Offset = "0x1BEAF90", VA = "0x1BEAF90")]
	public LevelRenderingSetting()
	{
	}

	// Token: 0x0400129B RID: 4763
	[Token(Token = "0x400129B")]
	[FieldOffset(Offset = "0x18")]
	private RenderSettingAuto renerAuot;

	// Token: 0x0400129C RID: 4764
	[Token(Token = "0x400129C")]
	[FieldOffset(Offset = "0x20")]
	private GameObject sunLight;

	// Token: 0x0400129D RID: 4765
	[Token(Token = "0x400129D")]
	[FieldOffset(Offset = "0x28")]
	private int i;

	// Token: 0x0400129E RID: 4766
	[Token(Token = "0x400129E")]
	[FieldOffset(Offset = "0x2C")]
	public bool openFog;
}
