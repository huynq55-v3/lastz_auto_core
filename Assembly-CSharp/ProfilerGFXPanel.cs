using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001FA RID: 506
[Token(Token = "0x20001FA")]
public class ProfilerGFXPanel : BaseGFXPanel
{
	// Token: 0x06000DB1 RID: 3505 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DB1")]
	[Address(RVA = "0x1213BE8", Offset = "0x1213BE8", VA = "0x1213BE8")]
	public ProfilerGFXPanel()
	{
	}

	// Token: 0x06000DB2 RID: 3506 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DB2")]
	[Address(RVA = "0x1213CFC", Offset = "0x1213CFC", VA = "0x1213CFC", Slot = "5")]
	public override void DrawGUI()
	{
	}

	// Token: 0x04001123 RID: 4387
	[Token(Token = "0x4001123")]
	[FieldOffset(Offset = "0x18")]
	private InstanceRequest graphyRequest;

	// Token: 0x04001124 RID: 4388
	[Token(Token = "0x4001124")]
	[FieldOffset(Offset = "0x20")]
	private readonly GameObject _uiRoot;

	// Token: 0x04001125 RID: 4389
	[Token(Token = "0x4001125")]
	[FieldOffset(Offset = "0x28")]
	private readonly GameObject _dynamic;

	// Token: 0x04001126 RID: 4390
	[Token(Token = "0x4001126")]
	[FieldOffset(Offset = "0x30")]
	private readonly WorldScene _worldScene;

	// Token: 0x04001127 RID: 4391
	[Token(Token = "0x4001127")]
	[FieldOffset(Offset = "0x38")]
	private bool fogVisible;
}
