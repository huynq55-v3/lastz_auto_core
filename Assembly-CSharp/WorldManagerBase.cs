using System;
using Il2CppDummyDll;

// Token: 0x02000302 RID: 770
[Token(Token = "0x2000302")]
public abstract class WorldManagerBase
{
	// Token: 0x060013FE RID: 5118 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013FE")]
	[Address(RVA = "0x1A4A2F4", Offset = "0x1A4A2F4", VA = "0x1A4A2F4")]
	public WorldManagerBase(WorldScene scene)
	{
	}

	// Token: 0x060013FF RID: 5119 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013FF")]
	[Address(RVA = "0x1A5066C", Offset = "0x1A5066C", VA = "0x1A5066C", Slot = "4")]
	public virtual void Init()
	{
	}

	// Token: 0x06001400 RID: 5120 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001400")]
	[Address(RVA = "0x1A51548", Offset = "0x1A51548", VA = "0x1A51548", Slot = "5")]
	public virtual void UnInit()
	{
	}

	// Token: 0x06001401 RID: 5121 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001401")]
	[Address(RVA = "0x1A4FBF8", Offset = "0x1A4FBF8", VA = "0x1A4FBF8", Slot = "6")]
	public virtual void OnUpdate(float deltaTime)
	{
	}

	// Token: 0x040016CE RID: 5838
	[Token(Token = "0x40016CE")]
	[FieldOffset(Offset = "0x10")]
	protected WorldScene world;
}
