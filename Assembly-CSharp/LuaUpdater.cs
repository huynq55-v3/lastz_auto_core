using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

// Token: 0x02000380 RID: 896
[Token(Token = "0x2000380")]
[Hotfix(HotfixFlag.Stateless)]
public class LuaUpdater : MonoBehaviour
{
	// Token: 0x060016D4 RID: 5844 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60016D4")]
	[Address(RVA = "0x1DAE214", Offset = "0x1DAE214", VA = "0x1DAE214")]
	public void OnInit(LuaEnv luaEnv)
	{
	}

	// Token: 0x060016D5 RID: 5845 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60016D5")]
	[Address(RVA = "0x1DAE218", Offset = "0x1DAE218", VA = "0x1DAE218")]
	public void Restart(LuaEnv luaEnv)
	{
	}

	// Token: 0x060016D6 RID: 5846 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60016D6")]
	[Address(RVA = "0x1DAE298", Offset = "0x1DAE298", VA = "0x1DAE298")]
	private void Update()
	{
	}

	// Token: 0x060016D7 RID: 5847 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60016D7")]
	[Address(RVA = "0x1DAE3FC", Offset = "0x1DAE3FC", VA = "0x1DAE3FC")]
	public void Dispose()
	{
	}

	// Token: 0x060016D8 RID: 5848 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60016D8")]
	[Address(RVA = "0x1DAE408", Offset = "0x1DAE408", VA = "0x1DAE408")]
	public LuaUpdater()
	{
	}

	// Token: 0x040019EE RID: 6638
	[Token(Token = "0x40019EE")]
	[FieldOffset(Offset = "0x18")]
	private Action<float, float> luaUpdate;
}
