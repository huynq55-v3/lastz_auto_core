using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Protobuf
{
	// Token: 0x02000426 RID: 1062
	[Token(Token = "0x2000426")]
	public sealed class ArmyResultBase : IMessage<ArmyResultBase>, IMessage, IEquatable<ArmyResultBase>, IDeepCloneable<ArmyResultBase>
	{
		// Token: 0x1700035E RID: 862
		// (get) Token: 0x06001C8D RID: 7309 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700035E")]
		[DebuggerNonUserCode]
		public static MessageParser<ArmyResultBase> Parser
		{
			[Token(Token = "0x6001C8D")]
			[Address(RVA = "0x26FB350", Offset = "0x26FB350", VA = "0x26FB350")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700035F RID: 863
		// (get) Token: 0x06001C8E RID: 7310 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700035F")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Token(Token = "0x6001C8E")]
			[Address(RVA = "0x26FB3A8", Offset = "0x26FB3A8", VA = "0x26FB3A8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000360 RID: 864
		// (get) Token: 0x06001C8F RID: 7311 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000360")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Token(Token = "0x6001C8F")]
			[Address(RVA = "0x26FB4AC", Offset = "0x26FB4AC", VA = "0x26FB4AC", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001C90 RID: 7312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C90")]
		[Address(RVA = "0x26FB4F8", Offset = "0x26FB4F8", VA = "0x26FB4F8")]
		[DebuggerNonUserCode]
		public ArmyResultBase()
		{
		}

		// Token: 0x06001C91 RID: 7313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C91")]
		[Address(RVA = "0x26FB5D0", Offset = "0x26FB5D0", VA = "0x26FB5D0")]
		[DebuggerNonUserCode]
		public ArmyResultBase(ArmyResultBase other)
		{
		}

		// Token: 0x06001C92 RID: 7314 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C92")]
		[Address(RVA = "0x26FB6E0", Offset = "0x26FB6E0", VA = "0x26FB6E0", Slot = "10")]
		[DebuggerNonUserCode]
		public ArmyResultBase Clone()
		{
			return null;
		}

		// Token: 0x17000361 RID: 865
		// (get) Token: 0x06001C93 RID: 7315 RVA: 0x0000AF08 File Offset: 0x00009108
		// (set) Token: 0x06001C94 RID: 7316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000361")]
		[DebuggerNonUserCode]
		public int PointId
		{
			[Token(Token = "0x6001C93")]
			[Address(RVA = "0x26FB740", Offset = "0x26FB740", VA = "0x26FB740")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001C94")]
			[Address(RVA = "0x26FB748", Offset = "0x26FB748", VA = "0x26FB748")]
			set
			{
			}
		}

		// Token: 0x17000362 RID: 866
		// (get) Token: 0x06001C95 RID: 7317 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001C96 RID: 7318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000362")]
		[DebuggerNonUserCode]
		public CombatUnit ArmyObj
		{
			[Token(Token = "0x6001C95")]
			[Address(RVA = "0x26FB750", Offset = "0x26FB750", VA = "0x26FB750")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001C96")]
			[Address(RVA = "0x26FB758", Offset = "0x26FB758", VA = "0x26FB758")]
			set
			{
			}
		}

		// Token: 0x17000363 RID: 867
		// (get) Token: 0x06001C97 RID: 7319 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001C98 RID: 7320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000363")]
		[DebuggerNonUserCode]
		public CombatUnit AfterArmyObj
		{
			[Token(Token = "0x6001C97")]
			[Address(RVA = "0x26FB760", Offset = "0x26FB760", VA = "0x26FB760")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001C98")]
			[Address(RVA = "0x26FB768", Offset = "0x26FB768", VA = "0x26FB768")]
			set
			{
			}
		}

		// Token: 0x17000364 RID: 868
		// (get) Token: 0x06001C99 RID: 7321 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000364")]
		[DebuggerNonUserCode]
		public RepeatedField<int> DestroyValue
		{
			[Token(Token = "0x6001C99")]
			[Address(RVA = "0x26FB770", Offset = "0x26FB770", VA = "0x26FB770")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000365 RID: 869
		// (get) Token: 0x06001C9A RID: 7322 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000365")]
		[DebuggerNonUserCode]
		public RepeatedField<DamagePercentInfo> DamagePercent
		{
			[Token(Token = "0x6001C9A")]
			[Address(RVA = "0x26FB778", Offset = "0x26FB778", VA = "0x26FB778")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001C9B RID: 7323 RVA: 0x0000AF20 File Offset: 0x00009120
		[Token(Token = "0x6001C9B")]
		[Address(RVA = "0x26FB780", Offset = "0x26FB780", VA = "0x26FB780", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06001C9C RID: 7324 RVA: 0x0000AF38 File Offset: 0x00009138
		[Token(Token = "0x6001C9C")]
		[Address(RVA = "0x26FB7E4", Offset = "0x26FB7E4", VA = "0x26FB7E4", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ArmyResultBase other)
		{
			return default(bool);
		}

		// Token: 0x06001C9D RID: 7325 RVA: 0x0000AF50 File Offset: 0x00009150
		[Token(Token = "0x6001C9D")]
		[Address(RVA = "0x26FB8D8", Offset = "0x26FB8D8", VA = "0x26FB8D8", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001C9E RID: 7326 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C9E")]
		[Address(RVA = "0x26FB9A0", Offset = "0x26FB9A0", VA = "0x26FB9A0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001C9F RID: 7327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C9F")]
		[Address(RVA = "0x26FB9F8", Offset = "0x26FB9F8", VA = "0x26FB9F8", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06001CA0 RID: 7328 RVA: 0x0000AF68 File Offset: 0x00009168
		[Token(Token = "0x6001CA0")]
		[Address(RVA = "0x26FBB68", Offset = "0x26FBB68", VA = "0x26FBB68", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06001CA1 RID: 7329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CA1")]
		[Address(RVA = "0x26FBCEC", Offset = "0x26FBCEC", VA = "0x26FBCEC", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(ArmyResultBase other)
		{
		}

		// Token: 0x06001CA2 RID: 7330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CA2")]
		[Address(RVA = "0x26FBE60", Offset = "0x26FBE60", VA = "0x26FBE60", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x04001D35 RID: 7477
		[Token(Token = "0x4001D35")]
		[FieldOffset(Offset = "0x0")]
		private static readonly MessageParser<ArmyResultBase> _parser;

		// Token: 0x04001D36 RID: 7478
		[Token(Token = "0x4001D36")]
		[FieldOffset(Offset = "0x10")]
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001D37 RID: 7479
		[Token(Token = "0x4001D37")]
		public const int PointIdFieldNumber = 1;

		// Token: 0x04001D38 RID: 7480
		[Token(Token = "0x4001D38")]
		[FieldOffset(Offset = "0x18")]
		private int pointId_;

		// Token: 0x04001D39 RID: 7481
		[Token(Token = "0x4001D39")]
		public const int ArmyObjFieldNumber = 2;

		// Token: 0x04001D3A RID: 7482
		[Token(Token = "0x4001D3A")]
		[FieldOffset(Offset = "0x20")]
		private CombatUnit armyObj_;

		// Token: 0x04001D3B RID: 7483
		[Token(Token = "0x4001D3B")]
		public const int AfterArmyObjFieldNumber = 3;

		// Token: 0x04001D3C RID: 7484
		[Token(Token = "0x4001D3C")]
		[FieldOffset(Offset = "0x28")]
		private CombatUnit afterArmyObj_;

		// Token: 0x04001D3D RID: 7485
		[Token(Token = "0x4001D3D")]
		public const int DestroyValueFieldNumber = 4;

		// Token: 0x04001D3E RID: 7486
		[Token(Token = "0x4001D3E")]
		[FieldOffset(Offset = "0x8")]
		private static readonly FieldCodec<int> _repeated_destroyValue_codec;

		// Token: 0x04001D3F RID: 7487
		[Token(Token = "0x4001D3F")]
		[FieldOffset(Offset = "0x30")]
		private readonly RepeatedField<int> destroyValue_;

		// Token: 0x04001D40 RID: 7488
		[Token(Token = "0x4001D40")]
		public const int DamagePercentFieldNumber = 5;

		// Token: 0x04001D41 RID: 7489
		[Token(Token = "0x4001D41")]
		[FieldOffset(Offset = "0x10")]
		private static readonly FieldCodec<DamagePercentInfo> _repeated_damagePercent_codec;

		// Token: 0x04001D42 RID: 7490
		[Token(Token = "0x4001D42")]
		[FieldOffset(Offset = "0x38")]
		private readonly RepeatedField<DamagePercentInfo> damagePercent_;
	}
}
