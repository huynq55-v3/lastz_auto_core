using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Protobuf
{
	// Token: 0x0200042E RID: 1070
	[Token(Token = "0x200042E")]
	public sealed class CityArmyResult : IMessage<CityArmyResult>, IMessage, IEquatable<CityArmyResult>, IDeepCloneable<CityArmyResult>
	{
		// Token: 0x17000376 RID: 886
		// (get) Token: 0x06001CEB RID: 7403 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000376")]
		[DebuggerNonUserCode]
		public static MessageParser<CityArmyResult> Parser
		{
			[Token(Token = "0x6001CEB")]
			[Address(RVA = "0x26FDFC4", Offset = "0x26FDFC4", VA = "0x26FDFC4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000377 RID: 887
		// (get) Token: 0x06001CEC RID: 7404 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000377")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Token(Token = "0x6001CEC")]
			[Address(RVA = "0x26FE01C", Offset = "0x26FE01C", VA = "0x26FE01C")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000378 RID: 888
		// (get) Token: 0x06001CED RID: 7405 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000378")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Token(Token = "0x6001CED")]
			[Address(RVA = "0x26FE120", Offset = "0x26FE120", VA = "0x26FE120", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001CEE RID: 7406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CEE")]
		[Address(RVA = "0x26FE16C", Offset = "0x26FE16C", VA = "0x26FE16C")]
		[DebuggerNonUserCode]
		public CityArmyResult()
		{
		}

		// Token: 0x06001CEF RID: 7407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CEF")]
		[Address(RVA = "0x26FE174", Offset = "0x26FE174", VA = "0x26FE174")]
		[DebuggerNonUserCode]
		public CityArmyResult(CityArmyResult other)
		{
		}

		// Token: 0x06001CF0 RID: 7408 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CF0")]
		[Address(RVA = "0x26FE1F0", Offset = "0x26FE1F0", VA = "0x26FE1F0", Slot = "10")]
		[DebuggerNonUserCode]
		public CityArmyResult Clone()
		{
			return null;
		}

		// Token: 0x17000379 RID: 889
		// (get) Token: 0x06001CF1 RID: 7409 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001CF2 RID: 7410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000379")]
		[DebuggerNonUserCode]
		public ArmyResultBase Base
		{
			[Token(Token = "0x6001CF1")]
			[Address(RVA = "0x26FE250", Offset = "0x26FE250", VA = "0x26FE250")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001CF2")]
			[Address(RVA = "0x26FE258", Offset = "0x26FE258", VA = "0x26FE258")]
			set
			{
			}
		}

		// Token: 0x1700037A RID: 890
		// (get) Token: 0x06001CF3 RID: 7411 RVA: 0x0000B100 File Offset: 0x00009300
		// (set) Token: 0x06001CF4 RID: 7412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700037A")]
		[DebuggerNonUserCode]
		public int Level
		{
			[Token(Token = "0x6001CF3")]
			[Address(RVA = "0x26FE260", Offset = "0x26FE260", VA = "0x26FE260")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001CF4")]
			[Address(RVA = "0x26FE268", Offset = "0x26FE268", VA = "0x26FE268")]
			set
			{
			}
		}

		// Token: 0x1700037B RID: 891
		// (get) Token: 0x06001CF5 RID: 7413 RVA: 0x0000B118 File Offset: 0x00009318
		// (set) Token: 0x06001CF6 RID: 7414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700037B")]
		[DebuggerNonUserCode]
		public bool IsDirect
		{
			[Token(Token = "0x6001CF5")]
			[Address(RVA = "0x26FE270", Offset = "0x26FE270", VA = "0x26FE270")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001CF6")]
			[Address(RVA = "0x26FE278", Offset = "0x26FE278", VA = "0x26FE278")]
			set
			{
			}
		}

		// Token: 0x06001CF7 RID: 7415 RVA: 0x0000B130 File Offset: 0x00009330
		[Token(Token = "0x6001CF7")]
		[Address(RVA = "0x26FE284", Offset = "0x26FE284", VA = "0x26FE284", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06001CF8 RID: 7416 RVA: 0x0000B148 File Offset: 0x00009348
		[Token(Token = "0x6001CF8")]
		[Address(RVA = "0x26FE2E8", Offset = "0x26FE2E8", VA = "0x26FE2E8", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(CityArmyResult other)
		{
			return default(bool);
		}

		// Token: 0x06001CF9 RID: 7417 RVA: 0x0000B160 File Offset: 0x00009360
		[Token(Token = "0x6001CF9")]
		[Address(RVA = "0x26FE378", Offset = "0x26FE378", VA = "0x26FE378", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001CFA RID: 7418 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CFA")]
		[Address(RVA = "0x26FE448", Offset = "0x26FE448", VA = "0x26FE448", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001CFB RID: 7419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CFB")]
		[Address(RVA = "0x26FE4A0", Offset = "0x26FE4A0", VA = "0x26FE4A0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06001CFC RID: 7420 RVA: 0x0000B178 File Offset: 0x00009378
		[Token(Token = "0x6001CFC")]
		[Address(RVA = "0x26FE560", Offset = "0x26FE560", VA = "0x26FE560", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06001CFD RID: 7421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CFD")]
		[Address(RVA = "0x26FE62C", Offset = "0x26FE62C", VA = "0x26FE62C", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CityArmyResult other)
		{
		}

		// Token: 0x06001CFE RID: 7422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CFE")]
		[Address(RVA = "0x26FE70C", Offset = "0x26FE70C", VA = "0x26FE70C", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x04001D5B RID: 7515
		[Token(Token = "0x4001D5B")]
		[FieldOffset(Offset = "0x0")]
		private static readonly MessageParser<CityArmyResult> _parser;

		// Token: 0x04001D5C RID: 7516
		[Token(Token = "0x4001D5C")]
		[FieldOffset(Offset = "0x10")]
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001D5D RID: 7517
		[Token(Token = "0x4001D5D")]
		public const int BaseFieldNumber = 1;

		// Token: 0x04001D5E RID: 7518
		[Token(Token = "0x4001D5E")]
		[FieldOffset(Offset = "0x18")]
		private ArmyResultBase base_;

		// Token: 0x04001D5F RID: 7519
		[Token(Token = "0x4001D5F")]
		public const int LevelFieldNumber = 2;

		// Token: 0x04001D60 RID: 7520
		[Token(Token = "0x4001D60")]
		[FieldOffset(Offset = "0x20")]
		private int level_;

		// Token: 0x04001D61 RID: 7521
		[Token(Token = "0x4001D61")]
		public const int IsDirectFieldNumber = 3;

		// Token: 0x04001D62 RID: 7522
		[Token(Token = "0x4001D62")]
		[FieldOffset(Offset = "0x24")]
		private bool isDirect_;
	}
}
