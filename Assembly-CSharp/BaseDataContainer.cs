using System;
using Il2CppDummyDll;
using Sfs2X.Entities.Data;

// Token: 0x02000186 RID: 390
[Token(Token = "0x2000186")]
public abstract class BaseDataContainer
{
	// Token: 0x06000B19 RID: 2841 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B19")]
	[Address(RVA = "0x3724110", Offset = "0x3724110", VA = "0x3724110")]
	public void Update(ISFSObject obj)
	{
	}

	// Token: 0x06000B1A RID: 2842 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B1A")]
	[Address(RVA = "0x372411C", Offset = "0x372411C", VA = "0x372411C")]
	public void Init(ISFSObject obj)
	{
	}

	// Token: 0x06000B1B RID: 2843 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B1B")]
	[Address(RVA = "0x3724128", Offset = "0x3724128", VA = "0x3724128", Slot = "4")]
	public virtual void CSUpdate(ISFSObject obj)
	{
	}

	// Token: 0x06000B1C RID: 2844 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B1C")]
	[Address(RVA = "0x372412C", Offset = "0x372412C", VA = "0x372412C", Slot = "5")]
	public virtual void CSInit(ISFSObject obj)
	{
	}

	// Token: 0x06000B1D RID: 2845 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B1D")]
	[Address(RVA = "0x3724130", Offset = "0x3724130", VA = "0x3724130", Slot = "6")]
	public virtual void Release()
	{
	}

	// Token: 0x06000B1E RID: 2846 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B1E")]
	[Address(RVA = "0x3724134", Offset = "0x3724134", VA = "0x3724134")]
	protected BaseDataContainer()
	{
	}
}
