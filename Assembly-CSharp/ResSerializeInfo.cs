using System;
using Il2CppDummyDll;

// Token: 0x0200000F RID: 15
[Token(Token = "0x200000F")]
[Serializable]
public class ResSerializeInfo
{
	// Token: 0x06000021 RID: 33 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000021")]
	[Address(RVA = "0x15DF37C", Offset = "0x15DF37C", VA = "0x15DF37C")]
	public ResSerializeInfo(int resId, string meshName, string materialName)
	{
	}

	// Token: 0x06000022 RID: 34 RVA: 0x00002118 File Offset: 0x00000318
	[Token(Token = "0x6000022")]
	[Address(RVA = "0x15DF3D0", Offset = "0x15DF3D0", VA = "0x15DF3D0", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	// Token: 0x04000067 RID: 103
	[Token(Token = "0x4000067")]
	[FieldOffset(Offset = "0x10")]
	public int resId;

	// Token: 0x04000068 RID: 104
	[Token(Token = "0x4000068")]
	[FieldOffset(Offset = "0x18")]
	public string meshName;

	// Token: 0x04000069 RID: 105
	[Token(Token = "0x4000069")]
	[FieldOffset(Offset = "0x20")]
	public string materialName;
}
