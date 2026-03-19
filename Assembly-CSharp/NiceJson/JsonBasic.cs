using System;
using Il2CppDummyDll;

namespace NiceJson
{
	// Token: 0x020004A8 RID: 1192
	[Token(Token = "0x20004A8")]
	[Serializable]
	public class JsonBasic : JsonNode
	{
		// Token: 0x1700053D RID: 1341
		// (get) Token: 0x0600233C RID: 9020 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700053D")]
		public object ValueObject
		{
			[Token(Token = "0x600233C")]
			[Address(RVA = "0x2A01954", Offset = "0x2A01954", VA = "0x2A01954")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600233D RID: 9021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600233D")]
		[Address(RVA = "0x2A006C4", Offset = "0x2A006C4", VA = "0x2A006C4")]
		public JsonBasic(object value)
		{
		}

		// Token: 0x0600233E RID: 9022 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600233E")]
		[Address(RVA = "0x2A0195C", Offset = "0x2A0195C", VA = "0x2A0195C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600233F RID: 9023 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600233F")]
		[Address(RVA = "0x2A0197C", Offset = "0x2A0197C", VA = "0x2A0197C", Slot = "4")]
		public override string ToJsonString()
		{
			return null;
		}

		// Token: 0x040020BA RID: 8378
		[Token(Token = "0x40020BA")]
		[FieldOffset(Offset = "0x10")]
		private object m_value;
	}
}
