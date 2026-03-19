using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Protobuf
{
	// Token: 0x02000424 RID: 1060
	[Token(Token = "0x2000424")]
	public sealed class DamagePercentInfo : IMessage<DamagePercentInfo>, IMessage, IEquatable<DamagePercentInfo>, IDeepCloneable<DamagePercentInfo>
	{
		// Token: 0x17000355 RID: 853
		// (get) Token: 0x06001C6F RID: 7279 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000355")]
		[DebuggerNonUserCode]
		public static MessageParser<DamagePercentInfo> Parser
		{
			[Token(Token = "0x6001C6F")]
			[Address(RVA = "0x26FA55C", Offset = "0x26FA55C", VA = "0x26FA55C")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000356 RID: 854
		// (get) Token: 0x06001C70 RID: 7280 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000356")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Token(Token = "0x6001C70")]
			[Address(RVA = "0x26FA5B4", Offset = "0x26FA5B4", VA = "0x26FA5B4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000357 RID: 855
		// (get) Token: 0x06001C71 RID: 7281 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000357")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Token(Token = "0x6001C71")]
			[Address(RVA = "0x26FA6B8", Offset = "0x26FA6B8", VA = "0x26FA6B8", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001C72 RID: 7282 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C72")]
		[Address(RVA = "0x26FA704", Offset = "0x26FA704", VA = "0x26FA704")]
		[DebuggerNonUserCode]
		public DamagePercentInfo()
		{
		}

		// Token: 0x06001C73 RID: 7283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C73")]
		[Address(RVA = "0x26FA70C", Offset = "0x26FA70C", VA = "0x26FA70C")]
		[DebuggerNonUserCode]
		public DamagePercentInfo(DamagePercentInfo other)
		{
		}

		// Token: 0x06001C74 RID: 7284 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C74")]
		[Address(RVA = "0x26FA768", Offset = "0x26FA768", VA = "0x26FA768", Slot = "10")]
		[DebuggerNonUserCode]
		public DamagePercentInfo Clone()
		{
			return null;
		}

		// Token: 0x17000358 RID: 856
		// (get) Token: 0x06001C75 RID: 7285 RVA: 0x0000AE18 File Offset: 0x00009018
		// (set) Token: 0x06001C76 RID: 7286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000358")]
		[DebuggerNonUserCode]
		public long TargetUuid
		{
			[Token(Token = "0x6001C75")]
			[Address(RVA = "0x26FA7C8", Offset = "0x26FA7C8", VA = "0x26FA7C8")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x6001C76")]
			[Address(RVA = "0x26FA7D0", Offset = "0x26FA7D0", VA = "0x26FA7D0")]
			set
			{
			}
		}

		// Token: 0x17000359 RID: 857
		// (get) Token: 0x06001C77 RID: 7287 RVA: 0x0000AE30 File Offset: 0x00009030
		// (set) Token: 0x06001C78 RID: 7288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000359")]
		[DebuggerNonUserCode]
		public float DamagePercent
		{
			[Token(Token = "0x6001C77")]
			[Address(RVA = "0x26FA7D8", Offset = "0x26FA7D8", VA = "0x26FA7D8")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6001C78")]
			[Address(RVA = "0x26FA7E0", Offset = "0x26FA7E0", VA = "0x26FA7E0")]
			set
			{
			}
		}

		// Token: 0x1700035A RID: 858
		// (get) Token: 0x06001C79 RID: 7289 RVA: 0x0000AE48 File Offset: 0x00009048
		// (set) Token: 0x06001C7A RID: 7290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700035A")]
		[DebuggerNonUserCode]
		public float WoundedPercent
		{
			[Token(Token = "0x6001C79")]
			[Address(RVA = "0x26FA7E8", Offset = "0x26FA7E8", VA = "0x26FA7E8")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6001C7A")]
			[Address(RVA = "0x26FA7F0", Offset = "0x26FA7F0", VA = "0x26FA7F0")]
			set
			{
			}
		}

		// Token: 0x1700035B RID: 859
		// (get) Token: 0x06001C7B RID: 7291 RVA: 0x0000AE60 File Offset: 0x00009060
		// (set) Token: 0x06001C7C RID: 7292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700035B")]
		[DebuggerNonUserCode]
		public float InjuredPercent
		{
			[Token(Token = "0x6001C7B")]
			[Address(RVA = "0x26FA7F8", Offset = "0x26FA7F8", VA = "0x26FA7F8")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6001C7C")]
			[Address(RVA = "0x26FA800", Offset = "0x26FA800", VA = "0x26FA800")]
			set
			{
			}
		}

		// Token: 0x1700035C RID: 860
		// (get) Token: 0x06001C7D RID: 7293 RVA: 0x0000AE78 File Offset: 0x00009078
		// (set) Token: 0x06001C7E RID: 7294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700035C")]
		[DebuggerNonUserCode]
		public float DeadPercent
		{
			[Token(Token = "0x6001C7D")]
			[Address(RVA = "0x26FA808", Offset = "0x26FA808", VA = "0x26FA808")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6001C7E")]
			[Address(RVA = "0x26FA810", Offset = "0x26FA810", VA = "0x26FA810")]
			set
			{
			}
		}

		// Token: 0x1700035D RID: 861
		// (get) Token: 0x06001C7F RID: 7295 RVA: 0x0000AE90 File Offset: 0x00009090
		// (set) Token: 0x06001C80 RID: 7296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700035D")]
		[DebuggerNonUserCode]
		public long SelfUuid
		{
			[Token(Token = "0x6001C7F")]
			[Address(RVA = "0x26FA818", Offset = "0x26FA818", VA = "0x26FA818")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x6001C80")]
			[Address(RVA = "0x26FA820", Offset = "0x26FA820", VA = "0x26FA820")]
			set
			{
			}
		}

		// Token: 0x06001C81 RID: 7297 RVA: 0x0000AEA8 File Offset: 0x000090A8
		[Token(Token = "0x6001C81")]
		[Address(RVA = "0x26FA828", Offset = "0x26FA828", VA = "0x26FA828", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06001C82 RID: 7298 RVA: 0x0000AEC0 File Offset: 0x000090C0
		[Token(Token = "0x6001C82")]
		[Address(RVA = "0x26FA88C", Offset = "0x26FA88C", VA = "0x26FA88C", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(DamagePercentInfo other)
		{
			return default(bool);
		}

		// Token: 0x06001C83 RID: 7299 RVA: 0x0000AED8 File Offset: 0x000090D8
		[Token(Token = "0x6001C83")]
		[Address(RVA = "0x26FAAC4", Offset = "0x26FAAC4", VA = "0x26FAAC4", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001C84 RID: 7300 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C84")]
		[Address(RVA = "0x26FAD24", Offset = "0x26FAD24", VA = "0x26FAD24", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001C85 RID: 7301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C85")]
		[Address(RVA = "0x26FAD7C", Offset = "0x26FAD7C", VA = "0x26FAD7C", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06001C86 RID: 7302 RVA: 0x0000AEF0 File Offset: 0x000090F0
		[Token(Token = "0x6001C86")]
		[Address(RVA = "0x26FAED0", Offset = "0x26FAED0", VA = "0x26FAED0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06001C87 RID: 7303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C87")]
		[Address(RVA = "0x26FAFC4", Offset = "0x26FAFC4", VA = "0x26FAFC4", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(DamagePercentInfo other)
		{
		}

		// Token: 0x06001C88 RID: 7304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C88")]
		[Address(RVA = "0x26FB050", Offset = "0x26FB050", VA = "0x26FB050", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x04001D26 RID: 7462
		[Token(Token = "0x4001D26")]
		[FieldOffset(Offset = "0x0")]
		private static readonly MessageParser<DamagePercentInfo> _parser;

		// Token: 0x04001D27 RID: 7463
		[Token(Token = "0x4001D27")]
		[FieldOffset(Offset = "0x10")]
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001D28 RID: 7464
		[Token(Token = "0x4001D28")]
		public const int TargetUuidFieldNumber = 1;

		// Token: 0x04001D29 RID: 7465
		[Token(Token = "0x4001D29")]
		[FieldOffset(Offset = "0x18")]
		private long targetUuid_;

		// Token: 0x04001D2A RID: 7466
		[Token(Token = "0x4001D2A")]
		public const int DamagePercentFieldNumber = 2;

		// Token: 0x04001D2B RID: 7467
		[Token(Token = "0x4001D2B")]
		[FieldOffset(Offset = "0x20")]
		private float damagePercent_;

		// Token: 0x04001D2C RID: 7468
		[Token(Token = "0x4001D2C")]
		public const int WoundedPercentFieldNumber = 3;

		// Token: 0x04001D2D RID: 7469
		[Token(Token = "0x4001D2D")]
		[FieldOffset(Offset = "0x24")]
		private float woundedPercent_;

		// Token: 0x04001D2E RID: 7470
		[Token(Token = "0x4001D2E")]
		public const int InjuredPercentFieldNumber = 4;

		// Token: 0x04001D2F RID: 7471
		[Token(Token = "0x4001D2F")]
		[FieldOffset(Offset = "0x28")]
		private float injuredPercent_;

		// Token: 0x04001D30 RID: 7472
		[Token(Token = "0x4001D30")]
		public const int DeadPercentFieldNumber = 5;

		// Token: 0x04001D31 RID: 7473
		[Token(Token = "0x4001D31")]
		[FieldOffset(Offset = "0x2C")]
		private float deadPercent_;

		// Token: 0x04001D32 RID: 7474
		[Token(Token = "0x4001D32")]
		public const int SelfUuidFieldNumber = 6;

		// Token: 0x04001D33 RID: 7475
		[Token(Token = "0x4001D33")]
		[FieldOffset(Offset = "0x30")]
		private long selfUuid_;
	}
}
