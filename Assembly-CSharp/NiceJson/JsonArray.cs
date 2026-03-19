using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace NiceJson
{
	// Token: 0x020004AB RID: 1195
	[Token(Token = "0x20004AB")]
	[Serializable]
	public class JsonArray : JsonNode, IEnumerable<JsonNode>, IEnumerable
	{
		// Token: 0x17000544 RID: 1348
		// (get) Token: 0x06002355 RID: 9045 RVA: 0x0000D770 File Offset: 0x0000B970
		[Token(Token = "0x17000544")]
		public int Count
		{
			[Token(Token = "0x6002355")]
			[Address(RVA = "0x2A02368", Offset = "0x2A02368", VA = "0x2A02368")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000545 RID: 1349
		[Token(Token = "0x17000545")]
		public new JsonNode this[int index]
		{
			[Token(Token = "0x6002356")]
			[Address(RVA = "0x2A00058", Offset = "0x2A00058", VA = "0x2A00058")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002357")]
			[Address(RVA = "0x2A0014C", Offset = "0x2A0014C", VA = "0x2A0014C")]
			set
			{
			}
		}

		// Token: 0x06002358 RID: 9048 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002358")]
		[Address(RVA = "0x2A023B0", Offset = "0x2A023B0", VA = "0x2A023B0", Slot = "5")]
		public IEnumerator<JsonNode> GetEnumerator()
		{
			return null;
		}

		// Token: 0x06002359 RID: 9049 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002359")]
		[Address(RVA = "0x2A0244C", Offset = "0x2A0244C", VA = "0x2A0244C", Slot = "6")]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}

		// Token: 0x0600235A RID: 9050 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600235A")]
		[Address(RVA = "0x2A0189C", Offset = "0x2A0189C", VA = "0x2A0189C")]
		public void Add(JsonNode item)
		{
		}

		// Token: 0x0600235B RID: 9051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600235B")]
		[Address(RVA = "0x2A02450", Offset = "0x2A02450", VA = "0x2A02450")]
		public void AddRange(IEnumerable<JsonNode> collection)
		{
		}

		// Token: 0x0600235C RID: 9052 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600235C")]
		[Address(RVA = "0x2A024A8", Offset = "0x2A024A8", VA = "0x2A024A8")]
		public void Insert(int index, JsonNode item)
		{
		}

		// Token: 0x0600235D RID: 9053 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600235D")]
		[Address(RVA = "0x2A02510", Offset = "0x2A02510", VA = "0x2A02510")]
		public void InsertRange(int index, IEnumerable<JsonNode> collection)
		{
		}

		// Token: 0x0600235E RID: 9054 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600235E")]
		[Address(RVA = "0x2A02578", Offset = "0x2A02578", VA = "0x2A02578")]
		public void RemoveAt(int index)
		{
		}

		// Token: 0x0600235F RID: 9055 RVA: 0x0000D788 File Offset: 0x0000B988
		[Token(Token = "0x600235F")]
		[Address(RVA = "0x2A025D0", Offset = "0x2A025D0", VA = "0x2A025D0")]
		public bool Remove(JsonNode item)
		{
			return default(bool);
		}

		// Token: 0x06002360 RID: 9056 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002360")]
		[Address(RVA = "0x2A02628", Offset = "0x2A02628", VA = "0x2A02628")]
		public void Clear()
		{
		}

		// Token: 0x06002361 RID: 9057 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002361")]
		[Address(RVA = "0x2A02698", Offset = "0x2A02698", VA = "0x2A02698", Slot = "4")]
		public override string ToJsonString()
		{
			return null;
		}

		// Token: 0x06002362 RID: 9058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002362")]
		[Address(RVA = "0x2A01814", Offset = "0x2A01814", VA = "0x2A01814")]
		public JsonArray()
		{
		}

		// Token: 0x040020C0 RID: 8384
		[Token(Token = "0x40020C0")]
		[FieldOffset(Offset = "0x10")]
		private List<JsonNode> m_list;
	}
}
