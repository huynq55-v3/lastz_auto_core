using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Protobuf
{
	// Token: 0x02000489 RID: 1161
	[Token(Token = "0x2000489")]
	public sealed class NpcCityPointInfo : IMessage<NpcCityPointInfo>, IMessage, IEquatable<NpcCityPointInfo>, IDeepCloneable<NpcCityPointInfo>
	{
		// Token: 0x170004D9 RID: 1241
		// (get) Token: 0x060021AC RID: 8620 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004D9")]
		[DebuggerNonUserCode]
		public static MessageParser<NpcCityPointInfo> Parser
		{
			[Token(Token = "0x60021AC")]
			[Address(RVA = "0x2893764", Offset = "0x2893764", VA = "0x2893764")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004DA RID: 1242
		// (get) Token: 0x060021AD RID: 8621 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004DA")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Token(Token = "0x60021AD")]
			[Address(RVA = "0x28937BC", Offset = "0x28937BC", VA = "0x28937BC")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004DB RID: 1243
		// (get) Token: 0x060021AE RID: 8622 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004DB")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Token(Token = "0x60021AE")]
			[Address(RVA = "0x28938C0", Offset = "0x28938C0", VA = "0x28938C0", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x060021AF RID: 8623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021AF")]
		[Address(RVA = "0x289390C", Offset = "0x289390C", VA = "0x289390C")]
		[DebuggerNonUserCode]
		public NpcCityPointInfo()
		{
		}

		// Token: 0x060021B0 RID: 8624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021B0")]
		[Address(RVA = "0x2893964", Offset = "0x2893964", VA = "0x2893964")]
		[DebuggerNonUserCode]
		public NpcCityPointInfo(NpcCityPointInfo other)
		{
		}

		// Token: 0x060021B1 RID: 8625 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021B1")]
		[Address(RVA = "0x28939CC", Offset = "0x28939CC", VA = "0x28939CC", Slot = "10")]
		[DebuggerNonUserCode]
		public NpcCityPointInfo Clone()
		{
			return null;
		}

		// Token: 0x170004DC RID: 1244
		// (get) Token: 0x060021B2 RID: 8626 RVA: 0x0000CE40 File Offset: 0x0000B040
		// (set) Token: 0x060021B3 RID: 8627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004DC")]
		[DebuggerNonUserCode]
		public long Uuid
		{
			[Token(Token = "0x60021B2")]
			[Address(RVA = "0x2893A2C", Offset = "0x2893A2C", VA = "0x2893A2C")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x60021B3")]
			[Address(RVA = "0x2893A34", Offset = "0x2893A34", VA = "0x2893A34")]
			set
			{
			}
		}

		// Token: 0x170004DD RID: 1245
		// (get) Token: 0x060021B4 RID: 8628 RVA: 0x0000CE58 File Offset: 0x0000B058
		// (set) Token: 0x060021B5 RID: 8629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004DD")]
		[DebuggerNonUserCode]
		public int NpcId
		{
			[Token(Token = "0x60021B4")]
			[Address(RVA = "0x2893A3C", Offset = "0x2893A3C", VA = "0x2893A3C")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60021B5")]
			[Address(RVA = "0x2893A44", Offset = "0x2893A44", VA = "0x2893A44")]
			set
			{
			}
		}

		// Token: 0x170004DE RID: 1246
		// (get) Token: 0x060021B6 RID: 8630 RVA: 0x0000CE70 File Offset: 0x0000B070
		// (set) Token: 0x060021B7 RID: 8631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004DE")]
		[DebuggerNonUserCode]
		public int LastHpTime
		{
			[Token(Token = "0x60021B6")]
			[Address(RVA = "0x2893A4C", Offset = "0x2893A4C", VA = "0x2893A4C")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60021B7")]
			[Address(RVA = "0x2893A54", Offset = "0x2893A54", VA = "0x2893A54")]
			set
			{
			}
		}

		// Token: 0x170004DF RID: 1247
		// (get) Token: 0x060021B8 RID: 8632 RVA: 0x0000CE88 File Offset: 0x0000B088
		// (set) Token: 0x060021B9 RID: 8633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004DF")]
		[DebuggerNonUserCode]
		public int CurrentHp
		{
			[Token(Token = "0x60021B8")]
			[Address(RVA = "0x2893A5C", Offset = "0x2893A5C", VA = "0x2893A5C")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60021B9")]
			[Address(RVA = "0x2893A64", Offset = "0x2893A64", VA = "0x2893A64")]
			set
			{
			}
		}

		// Token: 0x170004E0 RID: 1248
		// (get) Token: 0x060021BA RID: 8634 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060021BB RID: 8635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004E0")]
		[DebuggerNonUserCode]
		public string Name
		{
			[Token(Token = "0x60021BA")]
			[Address(RVA = "0x2893A6C", Offset = "0x2893A6C", VA = "0x2893A6C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60021BB")]
			[Address(RVA = "0x2893A74", Offset = "0x2893A74", VA = "0x2893A74")]
			set
			{
			}
		}

		// Token: 0x060021BC RID: 8636 RVA: 0x0000CEA0 File Offset: 0x0000B0A0
		[Token(Token = "0x60021BC")]
		[Address(RVA = "0x2893AF0", Offset = "0x2893AF0", VA = "0x2893AF0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x060021BD RID: 8637 RVA: 0x0000CEB8 File Offset: 0x0000B0B8
		[Token(Token = "0x60021BD")]
		[Address(RVA = "0x2893B54", Offset = "0x2893B54", VA = "0x2893B54", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(NpcCityPointInfo other)
		{
			return default(bool);
		}

		// Token: 0x060021BE RID: 8638 RVA: 0x0000CED0 File Offset: 0x0000B0D0
		[Token(Token = "0x60021BE")]
		[Address(RVA = "0x2893BF4", Offset = "0x2893BF4", VA = "0x2893BF4", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060021BF RID: 8639 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021BF")]
		[Address(RVA = "0x2893CD0", Offset = "0x2893CD0", VA = "0x2893CD0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060021C0 RID: 8640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021C0")]
		[Address(RVA = "0x2893D28", Offset = "0x2893D28", VA = "0x2893D28", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060021C1 RID: 8641 RVA: 0x0000CEE8 File Offset: 0x0000B0E8
		[Token(Token = "0x60021C1")]
		[Address(RVA = "0x2893E48", Offset = "0x2893E48", VA = "0x2893E48", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060021C2 RID: 8642 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021C2")]
		[Address(RVA = "0x2893F8C", Offset = "0x2893F8C", VA = "0x2893F8C", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(NpcCityPointInfo other)
		{
		}

		// Token: 0x060021C3 RID: 8643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021C3")]
		[Address(RVA = "0x2894020", Offset = "0x2894020", VA = "0x2894020", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x04001FAF RID: 8111
		[Token(Token = "0x4001FAF")]
		[FieldOffset(Offset = "0x0")]
		private static readonly MessageParser<NpcCityPointInfo> _parser;

		// Token: 0x04001FB0 RID: 8112
		[Token(Token = "0x4001FB0")]
		[FieldOffset(Offset = "0x10")]
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001FB1 RID: 8113
		[Token(Token = "0x4001FB1")]
		public const int UuidFieldNumber = 1;

		// Token: 0x04001FB2 RID: 8114
		[Token(Token = "0x4001FB2")]
		[FieldOffset(Offset = "0x18")]
		private long uuid_;

		// Token: 0x04001FB3 RID: 8115
		[Token(Token = "0x4001FB3")]
		public const int NpcIdFieldNumber = 2;

		// Token: 0x04001FB4 RID: 8116
		[Token(Token = "0x4001FB4")]
		[FieldOffset(Offset = "0x20")]
		private int npcId_;

		// Token: 0x04001FB5 RID: 8117
		[Token(Token = "0x4001FB5")]
		public const int LastHpTimeFieldNumber = 3;

		// Token: 0x04001FB6 RID: 8118
		[Token(Token = "0x4001FB6")]
		[FieldOffset(Offset = "0x24")]
		private int lastHpTime_;

		// Token: 0x04001FB7 RID: 8119
		[Token(Token = "0x4001FB7")]
		public const int CurrentHpFieldNumber = 4;

		// Token: 0x04001FB8 RID: 8120
		[Token(Token = "0x4001FB8")]
		[FieldOffset(Offset = "0x28")]
		private int currentHp_;

		// Token: 0x04001FB9 RID: 8121
		[Token(Token = "0x4001FB9")]
		public const int NameFieldNumber = 5;

		// Token: 0x04001FBA RID: 8122
		[Token(Token = "0x4001FBA")]
		[FieldOffset(Offset = "0x30")]
		private string name_;
	}
}
