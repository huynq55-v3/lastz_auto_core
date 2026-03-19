using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

// Token: 0x020002B4 RID: 692
[Token(Token = "0x20002B4")]
public class RenderSettingManager
{
	// Token: 0x060011F1 RID: 4593 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011F1")]
	[Address(RVA = "0x1C567D4", Offset = "0x1C567D4", VA = "0x1C567D4")]
	public static void PushSetting(int instanceId, RenderSettingData settingData)
	{
	}

	// Token: 0x060011F2 RID: 4594 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011F2")]
	[Address(RVA = "0x1C56A44", Offset = "0x1C56A44", VA = "0x1C56A44")]
	public static void PopSetting(int instanceId)
	{
	}

	// Token: 0x060011F3 RID: 4595 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011F3")]
	[Address(RVA = "0x1C56EE4", Offset = "0x1C56EE4", VA = "0x1C56EE4")]
	public RenderSettingManager()
	{
	}

	// Token: 0x040014EB RID: 5355
	[Token(Token = "0x40014EB")]
	[FieldOffset(Offset = "0x0")]
	[TupleElementNames(new string[] { "instanceId", "data" })]
	private static List<ValueTuple<int, RenderSettingData>> settingList;
}
