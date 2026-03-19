using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Protobuf
{
	// Token: 0x02000467 RID: 1127
	[Token(Token = "0x2000467")]
	public sealed class CombineSelfArmyInfo : IMessage<CombineSelfArmyInfo>, IMessage, IEquatable<CombineSelfArmyInfo>, IDeepCloneable<CombineSelfArmyInfo>
	{
		// Token: 0x17000441 RID: 1089
		// (get) Token: 0x06001FC0 RID: 8128 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000441")]
		[DebuggerNonUserCode]
		public static MessageParser<CombineSelfArmyInfo> Parser
		{
			[Token(Token = "0x6001FC0")]
			[Address(RVA = "0x25AA658", Offset = "0x25AA658", VA = "0x25AA658")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000442 RID: 1090
		// (get) Token: 0x06001FC1 RID: 8129 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000442")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Token(Token = "0x6001FC1")]
			[Address(RVA = "0x25AA6B0", Offset = "0x25AA6B0", VA = "0x25AA6B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000443 RID: 1091
		// (get) Token: 0x06001FC2 RID: 8130 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000443")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Token(Token = "0x6001FC2")]
			[Address(RVA = "0x25AA7B4", Offset = "0x25AA7B4", VA = "0x25AA7B4", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001FC3 RID: 8131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FC3")]
		[Address(RVA = "0x25AA800", Offset = "0x25AA800", VA = "0x25AA800")]
		[DebuggerNonUserCode]
		public CombineSelfArmyInfo()
		{
		}

		// Token: 0x06001FC4 RID: 8132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FC4")]
		[Address(RVA = "0x25AA888", Offset = "0x25AA888", VA = "0x25AA888")]
		[DebuggerNonUserCode]
		public CombineSelfArmyInfo(CombineSelfArmyInfo other)
		{
		}

		// Token: 0x06001FC5 RID: 8133 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FC5")]
		[Address(RVA = "0x25AA938", Offset = "0x25AA938", VA = "0x25AA938", Slot = "10")]
		[DebuggerNonUserCode]
		public CombineSelfArmyInfo Clone()
		{
			return null;
		}

		// Token: 0x17000444 RID: 1092
		// (get) Token: 0x06001FC6 RID: 8134 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000444")]
		[DebuggerNonUserCode]
		public RepeatedField<SimpleSelfArmyInfo> Members
		{
			[Token(Token = "0x6001FC6")]
			[Address(RVA = "0x25AA998", Offset = "0x25AA998", VA = "0x25AA998")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000445 RID: 1093
		// (get) Token: 0x06001FC7 RID: 8135 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001FC8 RID: 8136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000445")]
		[DebuggerNonUserCode]
		public SimpleCombatUnitPushObj TargetInfo
		{
			[Token(Token = "0x6001FC7")]
			[Address(RVA = "0x25AA9A0", Offset = "0x25AA9A0", VA = "0x25AA9A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001FC8")]
			[Address(RVA = "0x25AA9A8", Offset = "0x25AA9A8", VA = "0x25AA9A8")]
			set
			{
			}
		}

		// Token: 0x06001FC9 RID: 8137 RVA: 0x0000C1B0 File Offset: 0x0000A3B0
		[Token(Token = "0x6001FC9")]
		[Address(RVA = "0x25AA9B0", Offset = "0x25AA9B0", VA = "0x25AA9B0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06001FCA RID: 8138 RVA: 0x0000C1C8 File Offset: 0x0000A3C8
		[Token(Token = "0x6001FCA")]
		[Address(RVA = "0x25AAA14", Offset = "0x25AAA14", VA = "0x25AAA14", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(CombineSelfArmyInfo other)
		{
			return default(bool);
		}

		// Token: 0x06001FCB RID: 8139 RVA: 0x0000C1E0 File Offset: 0x0000A3E0
		[Token(Token = "0x6001FCB")]
		[Address(RVA = "0x25AAAB8", Offset = "0x25AAAB8", VA = "0x25AAAB8", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001FCC RID: 8140 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FCC")]
		[Address(RVA = "0x25AAB24", Offset = "0x25AAB24", VA = "0x25AAB24", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001FCD RID: 8141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FCD")]
		[Address(RVA = "0x25AAB7C", Offset = "0x25AAB7C", VA = "0x25AAB7C", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06001FCE RID: 8142 RVA: 0x0000C1F8 File Offset: 0x0000A3F8
		[Token(Token = "0x6001FCE")]
		[Address(RVA = "0x25AAC60", Offset = "0x25AAC60", VA = "0x25AAC60", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06001FCF RID: 8143 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FCF")]
		[Address(RVA = "0x25AAD44", Offset = "0x25AAD44", VA = "0x25AAD44", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CombineSelfArmyInfo other)
		{
		}

		// Token: 0x06001FD0 RID: 8144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FD0")]
		[Address(RVA = "0x25AAE38", Offset = "0x25AAE38", VA = "0x25AAE38", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x04001EAD RID: 7853
		[Token(Token = "0x4001EAD")]
		[FieldOffset(Offset = "0x0")]
		private static readonly MessageParser<CombineSelfArmyInfo> _parser;

		// Token: 0x04001EAE RID: 7854
		[Token(Token = "0x4001EAE")]
		[FieldOffset(Offset = "0x10")]
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001EAF RID: 7855
		[Token(Token = "0x4001EAF")]
		public const int MembersFieldNumber = 1;

		// Token: 0x04001EB0 RID: 7856
		[Token(Token = "0x4001EB0")]
		[FieldOffset(Offset = "0x8")]
		private static readonly FieldCodec<SimpleSelfArmyInfo> _repeated_members_codec;

		// Token: 0x04001EB1 RID: 7857
		[Token(Token = "0x4001EB1")]
		[FieldOffset(Offset = "0x18")]
		private readonly RepeatedField<SimpleSelfArmyInfo> members_;

		// Token: 0x04001EB2 RID: 7858
		[Token(Token = "0x4001EB2")]
		public const int TargetInfoFieldNumber = 2;

		// Token: 0x04001EB3 RID: 7859
		[Token(Token = "0x4001EB3")]
		[FieldOffset(Offset = "0x20")]
		private SimpleCombatUnitPushObj targetInfo_;
	}
}
