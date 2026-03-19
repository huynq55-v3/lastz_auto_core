using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Protobuf
{
	// Token: 0x02000456 RID: 1110
	[Token(Token = "0x2000456")]
	public sealed class BattleEffectGroup : IMessage<BattleEffectGroup>, IMessage, IEquatable<BattleEffectGroup>, IDeepCloneable<BattleEffectGroup>
	{
		// Token: 0x1700040B RID: 1035
		// (get) Token: 0x06001EF7 RID: 7927 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700040B")]
		[DebuggerNonUserCode]
		public static MessageParser<BattleEffectGroup> Parser
		{
			[Token(Token = "0x6001EF7")]
			[Address(RVA = "0x25A2E58", Offset = "0x25A2E58", VA = "0x25A2E58")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700040C RID: 1036
		// (get) Token: 0x06001EF8 RID: 7928 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700040C")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Token(Token = "0x6001EF8")]
			[Address(RVA = "0x25A2EB0", Offset = "0x25A2EB0", VA = "0x25A2EB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700040D RID: 1037
		// (get) Token: 0x06001EF9 RID: 7929 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700040D")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Token(Token = "0x6001EF9")]
			[Address(RVA = "0x25A2FB4", Offset = "0x25A2FB4", VA = "0x25A2FB4", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001EFA RID: 7930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EFA")]
		[Address(RVA = "0x25A3000", Offset = "0x25A3000", VA = "0x25A3000")]
		[DebuggerNonUserCode]
		public BattleEffectGroup()
		{
		}

		// Token: 0x06001EFB RID: 7931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EFB")]
		[Address(RVA = "0x25A3088", Offset = "0x25A3088", VA = "0x25A3088")]
		[DebuggerNonUserCode]
		public BattleEffectGroup(BattleEffectGroup other)
		{
		}

		// Token: 0x06001EFC RID: 7932 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EFC")]
		[Address(RVA = "0x25A311C", Offset = "0x25A311C", VA = "0x25A311C", Slot = "10")]
		[DebuggerNonUserCode]
		public BattleEffectGroup Clone()
		{
			return null;
		}

		// Token: 0x1700040E RID: 1038
		// (get) Token: 0x06001EFD RID: 7933 RVA: 0x0000BCA0 File Offset: 0x00009EA0
		// (set) Token: 0x06001EFE RID: 7934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700040E")]
		[DebuggerNonUserCode]
		public long MemberUuid
		{
			[Token(Token = "0x6001EFD")]
			[Address(RVA = "0x25A317C", Offset = "0x25A317C", VA = "0x25A317C")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x6001EFE")]
			[Address(RVA = "0x25A3184", Offset = "0x25A3184", VA = "0x25A3184")]
			set
			{
			}
		}

		// Token: 0x1700040F RID: 1039
		// (get) Token: 0x06001EFF RID: 7935 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700040F")]
		[DebuggerNonUserCode]
		public RepeatedField<BattleEffectInfo> BattleEffectInfos
		{
			[Token(Token = "0x6001EFF")]
			[Address(RVA = "0x25A318C", Offset = "0x25A318C", VA = "0x25A318C")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001F00 RID: 7936 RVA: 0x0000BCB8 File Offset: 0x00009EB8
		[Token(Token = "0x6001F00")]
		[Address(RVA = "0x25A3194", Offset = "0x25A3194", VA = "0x25A3194", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06001F01 RID: 7937 RVA: 0x0000BCD0 File Offset: 0x00009ED0
		[Token(Token = "0x6001F01")]
		[Address(RVA = "0x25A31F8", Offset = "0x25A31F8", VA = "0x25A31F8", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(BattleEffectGroup other)
		{
			return default(bool);
		}

		// Token: 0x06001F02 RID: 7938 RVA: 0x0000BCE8 File Offset: 0x00009EE8
		[Token(Token = "0x6001F02")]
		[Address(RVA = "0x25A3298", Offset = "0x25A3298", VA = "0x25A3298", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001F03 RID: 7939 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F03")]
		[Address(RVA = "0x25A3314", Offset = "0x25A3314", VA = "0x25A3314", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001F04 RID: 7940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F04")]
		[Address(RVA = "0x25A336C", Offset = "0x25A336C", VA = "0x25A336C", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06001F05 RID: 7941 RVA: 0x0000BD00 File Offset: 0x00009F00
		[Token(Token = "0x6001F05")]
		[Address(RVA = "0x25A3450", Offset = "0x25A3450", VA = "0x25A3450", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06001F06 RID: 7942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F06")]
		[Address(RVA = "0x25A3544", Offset = "0x25A3544", VA = "0x25A3544", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(BattleEffectGroup other)
		{
		}

		// Token: 0x06001F07 RID: 7943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F07")]
		[Address(RVA = "0x25A35D8", Offset = "0x25A35D8", VA = "0x25A35D8", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x04001E57 RID: 7767
		[Token(Token = "0x4001E57")]
		[FieldOffset(Offset = "0x0")]
		private static readonly MessageParser<BattleEffectGroup> _parser;

		// Token: 0x04001E58 RID: 7768
		[Token(Token = "0x4001E58")]
		[FieldOffset(Offset = "0x10")]
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001E59 RID: 7769
		[Token(Token = "0x4001E59")]
		public const int MemberUuidFieldNumber = 1;

		// Token: 0x04001E5A RID: 7770
		[Token(Token = "0x4001E5A")]
		[FieldOffset(Offset = "0x18")]
		private long memberUuid_;

		// Token: 0x04001E5B RID: 7771
		[Token(Token = "0x4001E5B")]
		public const int BattleEffectInfosFieldNumber = 2;

		// Token: 0x04001E5C RID: 7772
		[Token(Token = "0x4001E5C")]
		[FieldOffset(Offset = "0x8")]
		private static readonly FieldCodec<BattleEffectInfo> _repeated_battleEffectInfos_codec;

		// Token: 0x04001E5D RID: 7773
		[Token(Token = "0x4001E5D")]
		[FieldOffset(Offset = "0x20")]
		private readonly RepeatedField<BattleEffectInfo> battleEffectInfos_;
	}
}
