using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace NiceJson
{
	// Token: 0x020004A9 RID: 1193
	[Token(Token = "0x20004A9")]
	[Serializable]
	public class JsonObject : JsonNode, IEnumerable
	{
		// Token: 0x1700053E RID: 1342
		// (get) Token: 0x06002340 RID: 9024 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700053E")]
		public Dictionary<string, JsonNode>.KeyCollection Keys
		{
			[Token(Token = "0x6002340")]
			[Address(RVA = "0x2A01A94", Offset = "0x2A01A94", VA = "0x2A01A94")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700053F RID: 1343
		// (get) Token: 0x06002341 RID: 9025 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700053F")]
		public Dictionary<string, JsonNode>.ValueCollection Values
		{
			[Token(Token = "0x6002341")]
			[Address(RVA = "0x2A01AE4", Offset = "0x2A01AE4", VA = "0x2A01AE4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000540 RID: 1344
		[Token(Token = "0x17000540")]
		public new JsonNode this[string key]
		{
			[Token(Token = "0x6002342")]
			[Address(RVA = "0x29FBBBC", Offset = "0x29FBBBC", VA = "0x29FBBBC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002343")]
			[Address(RVA = "0x29FC318", Offset = "0x29FC318", VA = "0x29FC318")]
			set
			{
			}
		}

		// Token: 0x06002344 RID: 9028 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002344")]
		[Address(RVA = "0x2A01B34", Offset = "0x2A01B34", VA = "0x2A01B34")]
		public void Add(string key, JsonNode value)
		{
		}

		// Token: 0x06002345 RID: 9029 RVA: 0x0000D6F8 File Offset: 0x0000B8F8
		[Token(Token = "0x6002345")]
		[Address(RVA = "0x2A01B9C", Offset = "0x2A01B9C", VA = "0x2A01B9C")]
		public bool Remove(string key)
		{
			return default(bool);
		}

		// Token: 0x06002346 RID: 9030 RVA: 0x0000D710 File Offset: 0x0000B910
		[Token(Token = "0x6002346")]
		[Address(RVA = "0x29FFE44", Offset = "0x29FFE44", VA = "0x29FFE44")]
		public new bool ContainsKey(string key)
		{
			return default(bool);
		}

		// Token: 0x06002347 RID: 9031 RVA: 0x0000D728 File Offset: 0x0000B928
		[Token(Token = "0x6002347")]
		[Address(RVA = "0x2A01BF4", Offset = "0x2A01BF4", VA = "0x2A01BF4")]
		public bool ContainsValue(JsonNode value)
		{
			return default(bool);
		}

		// Token: 0x06002348 RID: 9032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002348")]
		[Address(RVA = "0x2A01C4C", Offset = "0x2A01C4C", VA = "0x2A01C4C")]
		public void Clear()
		{
		}

		// Token: 0x17000541 RID: 1345
		// (get) Token: 0x06002349 RID: 9033 RVA: 0x0000D740 File Offset: 0x0000B940
		[Token(Token = "0x17000541")]
		public int Count
		{
			[Token(Token = "0x6002349")]
			[Address(RVA = "0x2A01C9C", Offset = "0x2A01C9C", VA = "0x2A01C9C")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600234A RID: 9034 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600234A")]
		[Address(RVA = "0x2A01CEC", Offset = "0x2A01CEC", VA = "0x2A01CEC")]
		public IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x0600234B RID: 9035 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600234B")]
		[Address(RVA = "0x2A01D88", Offset = "0x2A01D88", VA = "0x2A01D88", Slot = "5")]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}

		// Token: 0x0600234C RID: 9036 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600234C")]
		[Address(RVA = "0x2A01D8C", Offset = "0x2A01D8C", VA = "0x2A01D8C", Slot = "4")]
		public override string ToJsonString()
		{
			return null;
		}

		// Token: 0x0600234D RID: 9037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600234D")]
		[Address(RVA = "0x29FEAD0", Offset = "0x29FEAD0", VA = "0x29FEAD0")]
		public JsonObject()
		{
		}

		// Token: 0x040020BB RID: 8379
		[Token(Token = "0x40020BB")]
		[FieldOffset(Offset = "0x10")]
		private Dictionary<string, JsonNode> m_dictionary;
	}
}
