using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Protobuf
{
	// Token: 0x02000479 RID: 1145
	[Token(Token = "0x2000479")]
	public sealed class CollectResourceInfo : IMessage<CollectResourceInfo>, IMessage, IEquatable<CollectResourceInfo>, IDeepCloneable<CollectResourceInfo>
	{
		// Token: 0x17000498 RID: 1176
		// (get) Token: 0x060020CA RID: 8394 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000498")]
		[DebuggerNonUserCode]
		public static MessageParser<CollectResourceInfo> Parser
		{
			[Token(Token = "0x60020CA")]
			[Address(RVA = "0x288D5E0", Offset = "0x288D5E0", VA = "0x288D5E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000499 RID: 1177
		// (get) Token: 0x060020CB RID: 8395 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000499")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Token(Token = "0x60020CB")]
			[Address(RVA = "0x288D638", Offset = "0x288D638", VA = "0x288D638")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700049A RID: 1178
		// (get) Token: 0x060020CC RID: 8396 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700049A")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Token(Token = "0x60020CC")]
			[Address(RVA = "0x288D73C", Offset = "0x288D73C", VA = "0x288D73C", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x060020CD RID: 8397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020CD")]
		[Address(RVA = "0x288D788", Offset = "0x288D788", VA = "0x288D788")]
		[DebuggerNonUserCode]
		public CollectResourceInfo()
		{
		}

		// Token: 0x060020CE RID: 8398 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020CE")]
		[Address(RVA = "0x288D790", Offset = "0x288D790", VA = "0x288D790")]
		[DebuggerNonUserCode]
		public CollectResourceInfo(CollectResourceInfo other)
		{
		}

		// Token: 0x060020CF RID: 8399 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020CF")]
		[Address(RVA = "0x288D7DC", Offset = "0x288D7DC", VA = "0x288D7DC", Slot = "10")]
		[DebuggerNonUserCode]
		public CollectResourceInfo Clone()
		{
			return null;
		}

		// Token: 0x1700049B RID: 1179
		// (get) Token: 0x060020D0 RID: 8400 RVA: 0x0000C8A0 File Offset: 0x0000AAA0
		// (set) Token: 0x060020D1 RID: 8401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700049B")]
		[DebuggerNonUserCode]
		public int ResourceType
		{
			[Token(Token = "0x60020D0")]
			[Address(RVA = "0x288D83C", Offset = "0x288D83C", VA = "0x288D83C")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60020D1")]
			[Address(RVA = "0x288D844", Offset = "0x288D844", VA = "0x288D844")]
			set
			{
			}
		}

		// Token: 0x1700049C RID: 1180
		// (get) Token: 0x060020D2 RID: 8402 RVA: 0x0000C8B8 File Offset: 0x0000AAB8
		// (set) Token: 0x060020D3 RID: 8403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700049C")]
		[DebuggerNonUserCode]
		public int Level
		{
			[Token(Token = "0x60020D2")]
			[Address(RVA = "0x288D84C", Offset = "0x288D84C", VA = "0x288D84C")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60020D3")]
			[Address(RVA = "0x288D854", Offset = "0x288D854", VA = "0x288D854")]
			set
			{
			}
		}

		// Token: 0x1700049D RID: 1181
		// (get) Token: 0x060020D4 RID: 8404 RVA: 0x0000C8D0 File Offset: 0x0000AAD0
		// (set) Token: 0x060020D5 RID: 8405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700049D")]
		[DebuggerNonUserCode]
		public int Type
		{
			[Token(Token = "0x60020D4")]
			[Address(RVA = "0x288D85C", Offset = "0x288D85C", VA = "0x288D85C")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60020D5")]
			[Address(RVA = "0x288D864", Offset = "0x288D864", VA = "0x288D864")]
			set
			{
			}
		}

		// Token: 0x1700049E RID: 1182
		// (get) Token: 0x060020D6 RID: 8406 RVA: 0x0000C8E8 File Offset: 0x0000AAE8
		// (set) Token: 0x060020D7 RID: 8407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700049E")]
		[DebuggerNonUserCode]
		public int AttachId
		{
			[Token(Token = "0x60020D6")]
			[Address(RVA = "0x288D86C", Offset = "0x288D86C", VA = "0x288D86C")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60020D7")]
			[Address(RVA = "0x288D874", Offset = "0x288D874", VA = "0x288D874")]
			set
			{
			}
		}

		// Token: 0x060020D8 RID: 8408 RVA: 0x0000C900 File Offset: 0x0000AB00
		[Token(Token = "0x60020D8")]
		[Address(RVA = "0x288D87C", Offset = "0x288D87C", VA = "0x288D87C", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x060020D9 RID: 8409 RVA: 0x0000C918 File Offset: 0x0000AB18
		[Token(Token = "0x60020D9")]
		[Address(RVA = "0x288D8E0", Offset = "0x288D8E0", VA = "0x288D8E0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(CollectResourceInfo other)
		{
			return default(bool);
		}

		// Token: 0x060020DA RID: 8410 RVA: 0x0000C930 File Offset: 0x0000AB30
		[Token(Token = "0x60020DA")]
		[Address(RVA = "0x288D94C", Offset = "0x288D94C", VA = "0x288D94C", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060020DB RID: 8411 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020DB")]
		[Address(RVA = "0x288D9FC", Offset = "0x288D9FC", VA = "0x288D9FC", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060020DC RID: 8412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020DC")]
		[Address(RVA = "0x288DA54", Offset = "0x288DA54", VA = "0x288DA54", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060020DD RID: 8413 RVA: 0x0000C948 File Offset: 0x0000AB48
		[Token(Token = "0x60020DD")]
		[Address(RVA = "0x288DB40", Offset = "0x288DB40", VA = "0x288DB40", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060020DE RID: 8414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020DE")]
		[Address(RVA = "0x288DC4C", Offset = "0x288DC4C", VA = "0x288DC4C", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CollectResourceInfo other)
		{
		}

		// Token: 0x060020DF RID: 8415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020DF")]
		[Address(RVA = "0x288DCB0", Offset = "0x288DCB0", VA = "0x288DCB0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x04001F45 RID: 8005
		[Token(Token = "0x4001F45")]
		[FieldOffset(Offset = "0x0")]
		private static readonly MessageParser<CollectResourceInfo> _parser;

		// Token: 0x04001F46 RID: 8006
		[Token(Token = "0x4001F46")]
		[FieldOffset(Offset = "0x10")]
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001F47 RID: 8007
		[Token(Token = "0x4001F47")]
		public const int ResourceTypeFieldNumber = 1;

		// Token: 0x04001F48 RID: 8008
		[Token(Token = "0x4001F48")]
		[FieldOffset(Offset = "0x18")]
		private int resourceType_;

		// Token: 0x04001F49 RID: 8009
		[Token(Token = "0x4001F49")]
		public const int LevelFieldNumber = 2;

		// Token: 0x04001F4A RID: 8010
		[Token(Token = "0x4001F4A")]
		[FieldOffset(Offset = "0x1C")]
		private int level_;

		// Token: 0x04001F4B RID: 8011
		[Token(Token = "0x4001F4B")]
		public const int TypeFieldNumber = 3;

		// Token: 0x04001F4C RID: 8012
		[Token(Token = "0x4001F4C")]
		[FieldOffset(Offset = "0x20")]
		private int type_;

		// Token: 0x04001F4D RID: 8013
		[Token(Token = "0x4001F4D")]
		public const int AttachIdFieldNumber = 4;

		// Token: 0x04001F4E RID: 8014
		[Token(Token = "0x4001F4E")]
		[FieldOffset(Offset = "0x24")]
		private int attachId_;
	}
}
