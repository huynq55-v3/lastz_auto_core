using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Protobuf
{
	// Token: 0x02000432 RID: 1074
	[Token(Token = "0x2000432")]
	public sealed class AllianceCityArmyResult : IMessage<AllianceCityArmyResult>, IMessage, IEquatable<AllianceCityArmyResult>, IDeepCloneable<AllianceCityArmyResult>
	{
		// Token: 0x17000381 RID: 897
		// (get) Token: 0x06001D19 RID: 7449 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000381")]
		[DebuggerNonUserCode]
		public static MessageParser<AllianceCityArmyResult> Parser
		{
			[Token(Token = "0x6001D19")]
			[Address(RVA = "0x26FF35C", Offset = "0x26FF35C", VA = "0x26FF35C")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000382 RID: 898
		// (get) Token: 0x06001D1A RID: 7450 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000382")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Token(Token = "0x6001D1A")]
			[Address(RVA = "0x26FF3B4", Offset = "0x26FF3B4", VA = "0x26FF3B4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000383 RID: 899
		// (get) Token: 0x06001D1B RID: 7451 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000383")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Token(Token = "0x6001D1B")]
			[Address(RVA = "0x26FF4B8", Offset = "0x26FF4B8", VA = "0x26FF4B8", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001D1C RID: 7452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D1C")]
		[Address(RVA = "0x26FF504", Offset = "0x26FF504", VA = "0x26FF504")]
		[DebuggerNonUserCode]
		public AllianceCityArmyResult()
		{
		}

		// Token: 0x06001D1D RID: 7453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D1D")]
		[Address(RVA = "0x26FF55C", Offset = "0x26FF55C", VA = "0x26FF55C")]
		[DebuggerNonUserCode]
		public AllianceCityArmyResult(AllianceCityArmyResult other)
		{
		}

		// Token: 0x06001D1E RID: 7454 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D1E")]
		[Address(RVA = "0x26FF5DC", Offset = "0x26FF5DC", VA = "0x26FF5DC", Slot = "10")]
		[DebuggerNonUserCode]
		public AllianceCityArmyResult Clone()
		{
			return null;
		}

		// Token: 0x17000384 RID: 900
		// (get) Token: 0x06001D1F RID: 7455 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001D20 RID: 7456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000384")]
		[DebuggerNonUserCode]
		public ArmyResultBase Base
		{
			[Token(Token = "0x6001D1F")]
			[Address(RVA = "0x26FF63C", Offset = "0x26FF63C", VA = "0x26FF63C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001D20")]
			[Address(RVA = "0x26FF644", Offset = "0x26FF644", VA = "0x26FF644")]
			set
			{
			}
		}

		// Token: 0x17000385 RID: 901
		// (get) Token: 0x06001D21 RID: 7457 RVA: 0x0000B208 File Offset: 0x00009408
		// (set) Token: 0x06001D22 RID: 7458 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000385")]
		[DebuggerNonUserCode]
		public int CityId
		{
			[Token(Token = "0x6001D21")]
			[Address(RVA = "0x26FF64C", Offset = "0x26FF64C", VA = "0x26FF64C")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001D22")]
			[Address(RVA = "0x26FF654", Offset = "0x26FF654", VA = "0x26FF654")]
			set
			{
			}
		}

		// Token: 0x17000386 RID: 902
		// (get) Token: 0x06001D23 RID: 7459 RVA: 0x0000B220 File Offset: 0x00009420
		// (set) Token: 0x06001D24 RID: 7460 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000386")]
		[DebuggerNonUserCode]
		public int Health
		{
			[Token(Token = "0x6001D23")]
			[Address(RVA = "0x26FF65C", Offset = "0x26FF65C", VA = "0x26FF65C")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001D24")]
			[Address(RVA = "0x26FF664", Offset = "0x26FF664", VA = "0x26FF664")]
			set
			{
			}
		}

		// Token: 0x17000387 RID: 903
		// (get) Token: 0x06001D25 RID: 7461 RVA: 0x0000B238 File Offset: 0x00009438
		// (set) Token: 0x06001D26 RID: 7462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000387")]
		[DebuggerNonUserCode]
		public int InitHealth
		{
			[Token(Token = "0x6001D25")]
			[Address(RVA = "0x26FF66C", Offset = "0x26FF66C", VA = "0x26FF66C")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001D26")]
			[Address(RVA = "0x26FF674", Offset = "0x26FF674", VA = "0x26FF674")]
			set
			{
			}
		}

		// Token: 0x17000388 RID: 904
		// (get) Token: 0x06001D27 RID: 7463 RVA: 0x0000B250 File Offset: 0x00009450
		// (set) Token: 0x06001D28 RID: 7464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000388")]
		[DebuggerNonUserCode]
		public int AfterHealth
		{
			[Token(Token = "0x6001D27")]
			[Address(RVA = "0x26FF67C", Offset = "0x26FF67C", VA = "0x26FF67C")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001D28")]
			[Address(RVA = "0x26FF684", Offset = "0x26FF684", VA = "0x26FF684")]
			set
			{
			}
		}

		// Token: 0x17000389 RID: 905
		// (get) Token: 0x06001D29 RID: 7465 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001D2A RID: 7466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000389")]
		[DebuggerNonUserCode]
		public string CityName
		{
			[Token(Token = "0x6001D29")]
			[Address(RVA = "0x26FF68C", Offset = "0x26FF68C", VA = "0x26FF68C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001D2A")]
			[Address(RVA = "0x26FF694", Offset = "0x26FF694", VA = "0x26FF694")]
			set
			{
			}
		}

		// Token: 0x06001D2B RID: 7467 RVA: 0x0000B268 File Offset: 0x00009468
		[Token(Token = "0x6001D2B")]
		[Address(RVA = "0x26FF710", Offset = "0x26FF710", VA = "0x26FF710", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06001D2C RID: 7468 RVA: 0x0000B280 File Offset: 0x00009480
		[Token(Token = "0x6001D2C")]
		[Address(RVA = "0x26FF774", Offset = "0x26FF774", VA = "0x26FF774", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(AllianceCityArmyResult other)
		{
			return default(bool);
		}

		// Token: 0x06001D2D RID: 7469 RVA: 0x0000B298 File Offset: 0x00009498
		[Token(Token = "0x6001D2D")]
		[Address(RVA = "0x26FF828", Offset = "0x26FF828", VA = "0x26FF828", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001D2E RID: 7470 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D2E")]
		[Address(RVA = "0x26FF914", Offset = "0x26FF914", VA = "0x26FF914", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001D2F RID: 7471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D2F")]
		[Address(RVA = "0x26FF96C", Offset = "0x26FF96C", VA = "0x26FF96C", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06001D30 RID: 7472 RVA: 0x0000B2B0 File Offset: 0x000094B0
		[Token(Token = "0x6001D30")]
		[Address(RVA = "0x26FFAB8", Offset = "0x26FFAB8", VA = "0x26FFAB8", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06001D31 RID: 7473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D31")]
		[Address(RVA = "0x26FFC28", Offset = "0x26FFC28", VA = "0x26FFC28", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(AllianceCityArmyResult other)
		{
		}

		// Token: 0x06001D32 RID: 7474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D32")]
		[Address(RVA = "0x26FFD38", Offset = "0x26FFD38", VA = "0x26FFD38", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x04001D6B RID: 7531
		[Token(Token = "0x4001D6B")]
		[FieldOffset(Offset = "0x0")]
		private static readonly MessageParser<AllianceCityArmyResult> _parser;

		// Token: 0x04001D6C RID: 7532
		[Token(Token = "0x4001D6C")]
		[FieldOffset(Offset = "0x10")]
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001D6D RID: 7533
		[Token(Token = "0x4001D6D")]
		public const int BaseFieldNumber = 1;

		// Token: 0x04001D6E RID: 7534
		[Token(Token = "0x4001D6E")]
		[FieldOffset(Offset = "0x18")]
		private ArmyResultBase base_;

		// Token: 0x04001D6F RID: 7535
		[Token(Token = "0x4001D6F")]
		public const int CityIdFieldNumber = 2;

		// Token: 0x04001D70 RID: 7536
		[Token(Token = "0x4001D70")]
		[FieldOffset(Offset = "0x20")]
		private int cityId_;

		// Token: 0x04001D71 RID: 7537
		[Token(Token = "0x4001D71")]
		public const int HealthFieldNumber = 3;

		// Token: 0x04001D72 RID: 7538
		[Token(Token = "0x4001D72")]
		[FieldOffset(Offset = "0x24")]
		private int health_;

		// Token: 0x04001D73 RID: 7539
		[Token(Token = "0x4001D73")]
		public const int InitHealthFieldNumber = 4;

		// Token: 0x04001D74 RID: 7540
		[Token(Token = "0x4001D74")]
		[FieldOffset(Offset = "0x28")]
		private int initHealth_;

		// Token: 0x04001D75 RID: 7541
		[Token(Token = "0x4001D75")]
		public const int AfterHealthFieldNumber = 5;

		// Token: 0x04001D76 RID: 7542
		[Token(Token = "0x4001D76")]
		[FieldOffset(Offset = "0x2C")]
		private int afterHealth_;

		// Token: 0x04001D77 RID: 7543
		[Token(Token = "0x4001D77")]
		public const int CityNameFieldNumber = 6;

		// Token: 0x04001D78 RID: 7544
		[Token(Token = "0x4001D78")]
		[FieldOffset(Offset = "0x30")]
		private string cityName_;
	}
}
