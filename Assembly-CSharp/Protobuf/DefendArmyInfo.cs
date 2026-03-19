using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Protobuf
{
	// Token: 0x02000407 RID: 1031
	[Token(Token = "0x2000407")]
	public sealed class DefendArmyInfo : IMessage<DefendArmyInfo>, IMessage, IEquatable<DefendArmyInfo>, IDeepCloneable<DefendArmyInfo>
	{
		// Token: 0x170002EA RID: 746
		// (get) Token: 0x06001AF7 RID: 6903 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002EA")]
		[DebuggerNonUserCode]
		public static MessageParser<DefendArmyInfo> Parser
		{
			[Token(Token = "0x6001AF7")]
			[Address(RVA = "0x20EAB00", Offset = "0x20EAB00", VA = "0x20EAB00")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002EB RID: 747
		// (get) Token: 0x06001AF8 RID: 6904 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002EB")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Token(Token = "0x6001AF8")]
			[Address(RVA = "0x20EAB58", Offset = "0x20EAB58", VA = "0x20EAB58")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002EC RID: 748
		// (get) Token: 0x06001AF9 RID: 6905 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002EC")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Token(Token = "0x6001AF9")]
			[Address(RVA = "0x20EAC5C", Offset = "0x20EAC5C", VA = "0x20EAC5C", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001AFA RID: 6906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AFA")]
		[Address(RVA = "0x20EACA8", Offset = "0x20EACA8", VA = "0x20EACA8")]
		[DebuggerNonUserCode]
		public DefendArmyInfo()
		{
		}

		// Token: 0x06001AFB RID: 6907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AFB")]
		[Address(RVA = "0x20EAD30", Offset = "0x20EAD30", VA = "0x20EAD30")]
		[DebuggerNonUserCode]
		public DefendArmyInfo(DefendArmyInfo other)
		{
		}

		// Token: 0x06001AFC RID: 6908 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AFC")]
		[Address(RVA = "0x20EADBC", Offset = "0x20EADBC", VA = "0x20EADBC", Slot = "10")]
		[DebuggerNonUserCode]
		public DefendArmyInfo Clone()
		{
			return null;
		}

		// Token: 0x170002ED RID: 749
		// (get) Token: 0x06001AFD RID: 6909 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002ED")]
		[DebuggerNonUserCode]
		public RepeatedField<ArmyDBUnitInfo> Defends
		{
			[Token(Token = "0x6001AFD")]
			[Address(RVA = "0x20EAE1C", Offset = "0x20EAE1C", VA = "0x20EAE1C")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001AFE RID: 6910 RVA: 0x0000A548 File Offset: 0x00008748
		[Token(Token = "0x6001AFE")]
		[Address(RVA = "0x20EAE24", Offset = "0x20EAE24", VA = "0x20EAE24", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06001AFF RID: 6911 RVA: 0x0000A560 File Offset: 0x00008760
		[Token(Token = "0x6001AFF")]
		[Address(RVA = "0x20EAE88", Offset = "0x20EAE88", VA = "0x20EAE88", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(DefendArmyInfo other)
		{
			return default(bool);
		}

		// Token: 0x06001B00 RID: 6912 RVA: 0x0000A578 File Offset: 0x00008778
		[Token(Token = "0x6001B00")]
		[Address(RVA = "0x20EAF18", Offset = "0x20EAF18", VA = "0x20EAF18", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001B01 RID: 6913 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B01")]
		[Address(RVA = "0x20EAF64", Offset = "0x20EAF64", VA = "0x20EAF64", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001B02 RID: 6914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B02")]
		[Address(RVA = "0x20EAFBC", Offset = "0x20EAFBC", VA = "0x20EAFBC", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06001B03 RID: 6915 RVA: 0x0000A590 File Offset: 0x00008790
		[Token(Token = "0x6001B03")]
		[Address(RVA = "0x20EB074", Offset = "0x20EB074", VA = "0x20EB074", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06001B04 RID: 6916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B04")]
		[Address(RVA = "0x20EB11C", Offset = "0x20EB11C", VA = "0x20EB11C", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(DefendArmyInfo other)
		{
		}

		// Token: 0x06001B05 RID: 6917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B05")]
		[Address(RVA = "0x20EB1A4", Offset = "0x20EB1A4", VA = "0x20EB1A4", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x04001C75 RID: 7285
		[Token(Token = "0x4001C75")]
		[FieldOffset(Offset = "0x0")]
		private static readonly MessageParser<DefendArmyInfo> _parser;

		// Token: 0x04001C76 RID: 7286
		[Token(Token = "0x4001C76")]
		[FieldOffset(Offset = "0x10")]
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001C77 RID: 7287
		[Token(Token = "0x4001C77")]
		public const int DefendsFieldNumber = 1;

		// Token: 0x04001C78 RID: 7288
		[Token(Token = "0x4001C78")]
		[FieldOffset(Offset = "0x8")]
		private static readonly FieldCodec<ArmyDBUnitInfo> _repeated_defends_codec;

		// Token: 0x04001C79 RID: 7289
		[Token(Token = "0x4001C79")]
		[FieldOffset(Offset = "0x18")]
		private readonly RepeatedField<ArmyDBUnitInfo> defends_;
	}
}
