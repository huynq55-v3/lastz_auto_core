using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Protobuf
{
	// Token: 0x0200042C RID: 1068
	[Token(Token = "0x200042C")]
	public sealed class CrossThroneBuildArmyResult : IMessage<CrossThroneBuildArmyResult>, IMessage, IEquatable<CrossThroneBuildArmyResult>, IDeepCloneable<CrossThroneBuildArmyResult>
	{
		// Token: 0x17000371 RID: 881
		// (get) Token: 0x06001CD5 RID: 7381 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000371")]
		[DebuggerNonUserCode]
		public static MessageParser<CrossThroneBuildArmyResult> Parser
		{
			[Token(Token = "0x6001CD5")]
			[Address(RVA = "0x26FD680", Offset = "0x26FD680", VA = "0x26FD680")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000372 RID: 882
		// (get) Token: 0x06001CD6 RID: 7382 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000372")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Token(Token = "0x6001CD6")]
			[Address(RVA = "0x26FD6D8", Offset = "0x26FD6D8", VA = "0x26FD6D8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000373 RID: 883
		// (get) Token: 0x06001CD7 RID: 7383 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000373")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Token(Token = "0x6001CD7")]
			[Address(RVA = "0x26FD7DC", Offset = "0x26FD7DC", VA = "0x26FD7DC", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001CD8 RID: 7384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CD8")]
		[Address(RVA = "0x26FD828", Offset = "0x26FD828", VA = "0x26FD828")]
		[DebuggerNonUserCode]
		public CrossThroneBuildArmyResult()
		{
		}

		// Token: 0x06001CD9 RID: 7385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CD9")]
		[Address(RVA = "0x26FD830", Offset = "0x26FD830", VA = "0x26FD830")]
		[DebuggerNonUserCode]
		public CrossThroneBuildArmyResult(CrossThroneBuildArmyResult other)
		{
		}

		// Token: 0x06001CDA RID: 7386 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CDA")]
		[Address(RVA = "0x26FD8A4", Offset = "0x26FD8A4", VA = "0x26FD8A4", Slot = "10")]
		[DebuggerNonUserCode]
		public CrossThroneBuildArmyResult Clone()
		{
			return null;
		}

		// Token: 0x17000374 RID: 884
		// (get) Token: 0x06001CDB RID: 7387 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001CDC RID: 7388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000374")]
		[DebuggerNonUserCode]
		public ArmyResultBase Base
		{
			[Token(Token = "0x6001CDB")]
			[Address(RVA = "0x26FD904", Offset = "0x26FD904", VA = "0x26FD904")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001CDC")]
			[Address(RVA = "0x26FD90C", Offset = "0x26FD90C", VA = "0x26FD90C")]
			set
			{
			}
		}

		// Token: 0x17000375 RID: 885
		// (get) Token: 0x06001CDD RID: 7389 RVA: 0x0000B088 File Offset: 0x00009288
		// (set) Token: 0x06001CDE RID: 7390 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000375")]
		[DebuggerNonUserCode]
		public int BuildId
		{
			[Token(Token = "0x6001CDD")]
			[Address(RVA = "0x26FD914", Offset = "0x26FD914", VA = "0x26FD914")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001CDE")]
			[Address(RVA = "0x26FD91C", Offset = "0x26FD91C", VA = "0x26FD91C")]
			set
			{
			}
		}

		// Token: 0x06001CDF RID: 7391 RVA: 0x0000B0A0 File Offset: 0x000092A0
		[Token(Token = "0x6001CDF")]
		[Address(RVA = "0x26FD924", Offset = "0x26FD924", VA = "0x26FD924", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06001CE0 RID: 7392 RVA: 0x0000B0B8 File Offset: 0x000092B8
		[Token(Token = "0x6001CE0")]
		[Address(RVA = "0x26FD988", Offset = "0x26FD988", VA = "0x26FD988", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(CrossThroneBuildArmyResult other)
		{
			return default(bool);
		}

		// Token: 0x06001CE1 RID: 7393 RVA: 0x0000B0D0 File Offset: 0x000092D0
		[Token(Token = "0x6001CE1")]
		[Address(RVA = "0x26FD9F8", Offset = "0x26FD9F8", VA = "0x26FD9F8", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001CE2 RID: 7394 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CE2")]
		[Address(RVA = "0x26FDA6C", Offset = "0x26FDA6C", VA = "0x26FDA6C", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001CE3 RID: 7395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CE3")]
		[Address(RVA = "0x26FDAC4", Offset = "0x26FDAC4", VA = "0x26FDAC4", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06001CE4 RID: 7396 RVA: 0x0000B0E8 File Offset: 0x000092E8
		[Token(Token = "0x6001CE4")]
		[Address(RVA = "0x26FDB58", Offset = "0x26FDB58", VA = "0x26FDB58", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06001CE5 RID: 7397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CE5")]
		[Address(RVA = "0x26FDC0C", Offset = "0x26FDC0C", VA = "0x26FDC0C", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CrossThroneBuildArmyResult other)
		{
		}

		// Token: 0x06001CE6 RID: 7398 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CE6")]
		[Address(RVA = "0x26FDCE0", Offset = "0x26FDCE0", VA = "0x26FDCE0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x04001D54 RID: 7508
		[Token(Token = "0x4001D54")]
		[FieldOffset(Offset = "0x0")]
		private static readonly MessageParser<CrossThroneBuildArmyResult> _parser;

		// Token: 0x04001D55 RID: 7509
		[Token(Token = "0x4001D55")]
		[FieldOffset(Offset = "0x10")]
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001D56 RID: 7510
		[Token(Token = "0x4001D56")]
		public const int BaseFieldNumber = 1;

		// Token: 0x04001D57 RID: 7511
		[Token(Token = "0x4001D57")]
		[FieldOffset(Offset = "0x18")]
		private ArmyResultBase base_;

		// Token: 0x04001D58 RID: 7512
		[Token(Token = "0x4001D58")]
		public const int BuildIdFieldNumber = 2;

		// Token: 0x04001D59 RID: 7513
		[Token(Token = "0x4001D59")]
		[FieldOffset(Offset = "0x20")]
		private int buildId_;
	}
}
