using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Protobuf
{
	// Token: 0x0200042A RID: 1066
	[Token(Token = "0x200042A")]
	public sealed class DragonBuildArmyResult : IMessage<DragonBuildArmyResult>, IMessage, IEquatable<DragonBuildArmyResult>, IDeepCloneable<DragonBuildArmyResult>
	{
		// Token: 0x1700036C RID: 876
		// (get) Token: 0x06001CBF RID: 7359 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700036C")]
		[DebuggerNonUserCode]
		public static MessageParser<DragonBuildArmyResult> Parser
		{
			[Token(Token = "0x6001CBF")]
			[Address(RVA = "0x26FCD3C", Offset = "0x26FCD3C", VA = "0x26FCD3C")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700036D RID: 877
		// (get) Token: 0x06001CC0 RID: 7360 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700036D")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Token(Token = "0x6001CC0")]
			[Address(RVA = "0x26FCD94", Offset = "0x26FCD94", VA = "0x26FCD94")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700036E RID: 878
		// (get) Token: 0x06001CC1 RID: 7361 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700036E")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Token(Token = "0x6001CC1")]
			[Address(RVA = "0x26FCE98", Offset = "0x26FCE98", VA = "0x26FCE98", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001CC2 RID: 7362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CC2")]
		[Address(RVA = "0x26FCEE4", Offset = "0x26FCEE4", VA = "0x26FCEE4")]
		[DebuggerNonUserCode]
		public DragonBuildArmyResult()
		{
		}

		// Token: 0x06001CC3 RID: 7363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CC3")]
		[Address(RVA = "0x26FCEEC", Offset = "0x26FCEEC", VA = "0x26FCEEC")]
		[DebuggerNonUserCode]
		public DragonBuildArmyResult(DragonBuildArmyResult other)
		{
		}

		// Token: 0x06001CC4 RID: 7364 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CC4")]
		[Address(RVA = "0x26FCF60", Offset = "0x26FCF60", VA = "0x26FCF60", Slot = "10")]
		[DebuggerNonUserCode]
		public DragonBuildArmyResult Clone()
		{
			return null;
		}

		// Token: 0x1700036F RID: 879
		// (get) Token: 0x06001CC5 RID: 7365 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001CC6 RID: 7366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700036F")]
		[DebuggerNonUserCode]
		public ArmyResultBase Base
		{
			[Token(Token = "0x6001CC5")]
			[Address(RVA = "0x26FCFC0", Offset = "0x26FCFC0", VA = "0x26FCFC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001CC6")]
			[Address(RVA = "0x26FCFC8", Offset = "0x26FCFC8", VA = "0x26FCFC8")]
			set
			{
			}
		}

		// Token: 0x17000370 RID: 880
		// (get) Token: 0x06001CC7 RID: 7367 RVA: 0x0000B010 File Offset: 0x00009210
		// (set) Token: 0x06001CC8 RID: 7368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000370")]
		[DebuggerNonUserCode]
		public int BuildId
		{
			[Token(Token = "0x6001CC7")]
			[Address(RVA = "0x26FCFD0", Offset = "0x26FCFD0", VA = "0x26FCFD0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001CC8")]
			[Address(RVA = "0x26FCFD8", Offset = "0x26FCFD8", VA = "0x26FCFD8")]
			set
			{
			}
		}

		// Token: 0x06001CC9 RID: 7369 RVA: 0x0000B028 File Offset: 0x00009228
		[Token(Token = "0x6001CC9")]
		[Address(RVA = "0x26FCFE0", Offset = "0x26FCFE0", VA = "0x26FCFE0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06001CCA RID: 7370 RVA: 0x0000B040 File Offset: 0x00009240
		[Token(Token = "0x6001CCA")]
		[Address(RVA = "0x26FD044", Offset = "0x26FD044", VA = "0x26FD044", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(DragonBuildArmyResult other)
		{
			return default(bool);
		}

		// Token: 0x06001CCB RID: 7371 RVA: 0x0000B058 File Offset: 0x00009258
		[Token(Token = "0x6001CCB")]
		[Address(RVA = "0x26FD0B4", Offset = "0x26FD0B4", VA = "0x26FD0B4", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001CCC RID: 7372 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CCC")]
		[Address(RVA = "0x26FD128", Offset = "0x26FD128", VA = "0x26FD128", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001CCD RID: 7373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CCD")]
		[Address(RVA = "0x26FD180", Offset = "0x26FD180", VA = "0x26FD180", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06001CCE RID: 7374 RVA: 0x0000B070 File Offset: 0x00009270
		[Token(Token = "0x6001CCE")]
		[Address(RVA = "0x26FD214", Offset = "0x26FD214", VA = "0x26FD214", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06001CCF RID: 7375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CCF")]
		[Address(RVA = "0x26FD2C8", Offset = "0x26FD2C8", VA = "0x26FD2C8", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(DragonBuildArmyResult other)
		{
		}

		// Token: 0x06001CD0 RID: 7376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CD0")]
		[Address(RVA = "0x26FD39C", Offset = "0x26FD39C", VA = "0x26FD39C", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x04001D4D RID: 7501
		[Token(Token = "0x4001D4D")]
		[FieldOffset(Offset = "0x0")]
		private static readonly MessageParser<DragonBuildArmyResult> _parser;

		// Token: 0x04001D4E RID: 7502
		[Token(Token = "0x4001D4E")]
		[FieldOffset(Offset = "0x10")]
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001D4F RID: 7503
		[Token(Token = "0x4001D4F")]
		public const int BaseFieldNumber = 1;

		// Token: 0x04001D50 RID: 7504
		[Token(Token = "0x4001D50")]
		[FieldOffset(Offset = "0x18")]
		private ArmyResultBase base_;

		// Token: 0x04001D51 RID: 7505
		[Token(Token = "0x4001D51")]
		public const int BuildIdFieldNumber = 2;

		// Token: 0x04001D52 RID: 7506
		[Token(Token = "0x4001D52")]
		[FieldOffset(Offset = "0x20")]
		private int buildId_;
	}
}
