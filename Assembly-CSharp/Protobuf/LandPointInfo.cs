using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Protobuf
{
	// Token: 0x02000491 RID: 1169
	[Token(Token = "0x2000491")]
	public sealed class LandPointInfo : IMessage<LandPointInfo>, IMessage, IEquatable<LandPointInfo>, IDeepCloneable<LandPointInfo>
	{
		// Token: 0x17000501 RID: 1281
		// (get) Token: 0x0600222C RID: 8748 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000501")]
		[DebuggerNonUserCode]
		public static MessageParser<LandPointInfo> Parser
		{
			[Token(Token = "0x600222C")]
			[Address(RVA = "0x28970B4", Offset = "0x28970B4", VA = "0x28970B4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000502 RID: 1282
		// (get) Token: 0x0600222D RID: 8749 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000502")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Token(Token = "0x600222D")]
			[Address(RVA = "0x289710C", Offset = "0x289710C", VA = "0x289710C")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000503 RID: 1283
		// (get) Token: 0x0600222E RID: 8750 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000503")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Token(Token = "0x600222E")]
			[Address(RVA = "0x2897210", Offset = "0x2897210", VA = "0x2897210", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600222F RID: 8751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600222F")]
		[Address(RVA = "0x289725C", Offset = "0x289725C", VA = "0x289725C")]
		[DebuggerNonUserCode]
		public LandPointInfo()
		{
		}

		// Token: 0x06002230 RID: 8752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002230")]
		[Address(RVA = "0x2897264", Offset = "0x2897264", VA = "0x2897264")]
		[DebuggerNonUserCode]
		public LandPointInfo(LandPointInfo other)
		{
		}

		// Token: 0x06002231 RID: 8753 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002231")]
		[Address(RVA = "0x28972B8", Offset = "0x28972B8", VA = "0x28972B8", Slot = "10")]
		[DebuggerNonUserCode]
		public LandPointInfo Clone()
		{
			return null;
		}

		// Token: 0x17000504 RID: 1284
		// (get) Token: 0x06002232 RID: 8754 RVA: 0x0000D170 File Offset: 0x0000B370
		// (set) Token: 0x06002233 RID: 8755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000504")]
		[DebuggerNonUserCode]
		public int Id
		{
			[Token(Token = "0x6002232")]
			[Address(RVA = "0x2897318", Offset = "0x2897318", VA = "0x2897318")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002233")]
			[Address(RVA = "0x2897320", Offset = "0x2897320", VA = "0x2897320")]
			set
			{
			}
		}

		// Token: 0x17000505 RID: 1285
		// (get) Token: 0x06002234 RID: 8756 RVA: 0x0000D188 File Offset: 0x0000B388
		// (set) Token: 0x06002235 RID: 8757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000505")]
		[DebuggerNonUserCode]
		public int LandId
		{
			[Token(Token = "0x6002234")]
			[Address(RVA = "0x2897328", Offset = "0x2897328", VA = "0x2897328")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002235")]
			[Address(RVA = "0x2897330", Offset = "0x2897330", VA = "0x2897330")]
			set
			{
			}
		}

		// Token: 0x17000506 RID: 1286
		// (get) Token: 0x06002236 RID: 8758 RVA: 0x0000D1A0 File Offset: 0x0000B3A0
		// (set) Token: 0x06002237 RID: 8759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000506")]
		[DebuggerNonUserCode]
		public int ServerId
		{
			[Token(Token = "0x6002236")]
			[Address(RVA = "0x2897338", Offset = "0x2897338", VA = "0x2897338")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002237")]
			[Address(RVA = "0x2897340", Offset = "0x2897340", VA = "0x2897340")]
			set
			{
			}
		}

		// Token: 0x06002238 RID: 8760 RVA: 0x0000D1B8 File Offset: 0x0000B3B8
		[Token(Token = "0x6002238")]
		[Address(RVA = "0x2897348", Offset = "0x2897348", VA = "0x2897348", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06002239 RID: 8761 RVA: 0x0000D1D0 File Offset: 0x0000B3D0
		[Token(Token = "0x6002239")]
		[Address(RVA = "0x28973AC", Offset = "0x28973AC", VA = "0x28973AC", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(LandPointInfo other)
		{
			return default(bool);
		}

		// Token: 0x0600223A RID: 8762 RVA: 0x0000D1E8 File Offset: 0x0000B3E8
		[Token(Token = "0x600223A")]
		[Address(RVA = "0x2897408", Offset = "0x2897408", VA = "0x2897408", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600223B RID: 8763 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600223B")]
		[Address(RVA = "0x289749C", Offset = "0x289749C", VA = "0x289749C", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600223C RID: 8764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600223C")]
		[Address(RVA = "0x28974F4", Offset = "0x28974F4", VA = "0x28974F4", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600223D RID: 8765 RVA: 0x0000D200 File Offset: 0x0000B400
		[Token(Token = "0x600223D")]
		[Address(RVA = "0x28975B4", Offset = "0x28975B4", VA = "0x28975B4", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600223E RID: 8766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600223E")]
		[Address(RVA = "0x2897694", Offset = "0x2897694", VA = "0x2897694", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(LandPointInfo other)
		{
		}

		// Token: 0x0600223F RID: 8767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600223F")]
		[Address(RVA = "0x28976EC", Offset = "0x28976EC", VA = "0x28976EC", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x04001FF3 RID: 8179
		[Token(Token = "0x4001FF3")]
		[FieldOffset(Offset = "0x0")]
		private static readonly MessageParser<LandPointInfo> _parser;

		// Token: 0x04001FF4 RID: 8180
		[Token(Token = "0x4001FF4")]
		[FieldOffset(Offset = "0x10")]
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001FF5 RID: 8181
		[Token(Token = "0x4001FF5")]
		public const int IdFieldNumber = 1;

		// Token: 0x04001FF6 RID: 8182
		[Token(Token = "0x4001FF6")]
		[FieldOffset(Offset = "0x18")]
		private int id_;

		// Token: 0x04001FF7 RID: 8183
		[Token(Token = "0x4001FF7")]
		public const int LandIdFieldNumber = 2;

		// Token: 0x04001FF8 RID: 8184
		[Token(Token = "0x4001FF8")]
		[FieldOffset(Offset = "0x1C")]
		private int landId_;

		// Token: 0x04001FF9 RID: 8185
		[Token(Token = "0x4001FF9")]
		public const int ServerIdFieldNumber = 3;

		// Token: 0x04001FFA RID: 8186
		[Token(Token = "0x4001FFA")]
		[FieldOffset(Offset = "0x20")]
		private int serverId_;
	}
}
