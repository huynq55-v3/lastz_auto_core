using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Protobuf
{
	// Token: 0x02000428 RID: 1064
	[Token(Token = "0x2000428")]
	public sealed class BuildArmyResult : IMessage<BuildArmyResult>, IMessage, IEquatable<BuildArmyResult>, IDeepCloneable<BuildArmyResult>
	{
		// Token: 0x17000366 RID: 870
		// (get) Token: 0x06001CA7 RID: 7335 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000366")]
		[DebuggerNonUserCode]
		public static MessageParser<BuildArmyResult> Parser
		{
			[Token(Token = "0x6001CA7")]
			[Address(RVA = "0x26FC334", Offset = "0x26FC334", VA = "0x26FC334")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000367 RID: 871
		// (get) Token: 0x06001CA8 RID: 7336 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000367")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Token(Token = "0x6001CA8")]
			[Address(RVA = "0x26FC38C", Offset = "0x26FC38C", VA = "0x26FC38C")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000368 RID: 872
		// (get) Token: 0x06001CA9 RID: 7337 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000368")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Token(Token = "0x6001CA9")]
			[Address(RVA = "0x26FC490", Offset = "0x26FC490", VA = "0x26FC490", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001CAA RID: 7338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CAA")]
		[Address(RVA = "0x26FC4DC", Offset = "0x26FC4DC", VA = "0x26FC4DC")]
		[DebuggerNonUserCode]
		public BuildArmyResult()
		{
		}

		// Token: 0x06001CAB RID: 7339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CAB")]
		[Address(RVA = "0x26FC4E4", Offset = "0x26FC4E4", VA = "0x26FC4E4")]
		[DebuggerNonUserCode]
		public BuildArmyResult(BuildArmyResult other)
		{
		}

		// Token: 0x06001CAC RID: 7340 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CAC")]
		[Address(RVA = "0x26FC558", Offset = "0x26FC558", VA = "0x26FC558", Slot = "10")]
		[DebuggerNonUserCode]
		public BuildArmyResult Clone()
		{
			return null;
		}

		// Token: 0x17000369 RID: 873
		// (get) Token: 0x06001CAD RID: 7341 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001CAE RID: 7342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000369")]
		[DebuggerNonUserCode]
		public ArmyResultBase Base
		{
			[Token(Token = "0x6001CAD")]
			[Address(RVA = "0x26FC5B8", Offset = "0x26FC5B8", VA = "0x26FC5B8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001CAE")]
			[Address(RVA = "0x26FC5C0", Offset = "0x26FC5C0", VA = "0x26FC5C0")]
			set
			{
			}
		}

		// Token: 0x1700036A RID: 874
		// (get) Token: 0x06001CAF RID: 7343 RVA: 0x0000AF80 File Offset: 0x00009180
		// (set) Token: 0x06001CB0 RID: 7344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700036A")]
		[DebuggerNonUserCode]
		public int Level
		{
			[Token(Token = "0x6001CAF")]
			[Address(RVA = "0x26FC5C8", Offset = "0x26FC5C8", VA = "0x26FC5C8")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001CB0")]
			[Address(RVA = "0x26FC5D0", Offset = "0x26FC5D0", VA = "0x26FC5D0")]
			set
			{
			}
		}

		// Token: 0x1700036B RID: 875
		// (get) Token: 0x06001CB1 RID: 7345 RVA: 0x0000AF98 File Offset: 0x00009198
		// (set) Token: 0x06001CB2 RID: 7346 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700036B")]
		[DebuggerNonUserCode]
		public int BuildId
		{
			[Token(Token = "0x6001CB1")]
			[Address(RVA = "0x26FC5D8", Offset = "0x26FC5D8", VA = "0x26FC5D8")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001CB2")]
			[Address(RVA = "0x26FC5E0", Offset = "0x26FC5E0", VA = "0x26FC5E0")]
			set
			{
			}
		}

		// Token: 0x06001CB3 RID: 7347 RVA: 0x0000AFB0 File Offset: 0x000091B0
		[Token(Token = "0x6001CB3")]
		[Address(RVA = "0x26FC5E8", Offset = "0x26FC5E8", VA = "0x26FC5E8", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06001CB4 RID: 7348 RVA: 0x0000AFC8 File Offset: 0x000091C8
		[Token(Token = "0x6001CB4")]
		[Address(RVA = "0x26FC64C", Offset = "0x26FC64C", VA = "0x26FC64C", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(BuildArmyResult other)
		{
			return default(bool);
		}

		// Token: 0x06001CB5 RID: 7349 RVA: 0x0000AFE0 File Offset: 0x000091E0
		[Token(Token = "0x6001CB5")]
		[Address(RVA = "0x26FC6CC", Offset = "0x26FC6CC", VA = "0x26FC6CC", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001CB6 RID: 7350 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CB6")]
		[Address(RVA = "0x26FC75C", Offset = "0x26FC75C", VA = "0x26FC75C", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001CB7 RID: 7351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CB7")]
		[Address(RVA = "0x26FC7B4", Offset = "0x26FC7B4", VA = "0x26FC7B4", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06001CB8 RID: 7352 RVA: 0x0000AFF8 File Offset: 0x000091F8
		[Token(Token = "0x6001CB8")]
		[Address(RVA = "0x26FC874", Offset = "0x26FC874", VA = "0x26FC874", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06001CB9 RID: 7353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CB9")]
		[Address(RVA = "0x26FC954", Offset = "0x26FC954", VA = "0x26FC954", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(BuildArmyResult other)
		{
		}

		// Token: 0x06001CBA RID: 7354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CBA")]
		[Address(RVA = "0x26FCA34", Offset = "0x26FCA34", VA = "0x26FCA34", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x04001D44 RID: 7492
		[Token(Token = "0x4001D44")]
		[FieldOffset(Offset = "0x0")]
		private static readonly MessageParser<BuildArmyResult> _parser;

		// Token: 0x04001D45 RID: 7493
		[Token(Token = "0x4001D45")]
		[FieldOffset(Offset = "0x10")]
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001D46 RID: 7494
		[Token(Token = "0x4001D46")]
		public const int BaseFieldNumber = 1;

		// Token: 0x04001D47 RID: 7495
		[Token(Token = "0x4001D47")]
		[FieldOffset(Offset = "0x18")]
		private ArmyResultBase base_;

		// Token: 0x04001D48 RID: 7496
		[Token(Token = "0x4001D48")]
		public const int LevelFieldNumber = 2;

		// Token: 0x04001D49 RID: 7497
		[Token(Token = "0x4001D49")]
		[FieldOffset(Offset = "0x20")]
		private int level_;

		// Token: 0x04001D4A RID: 7498
		[Token(Token = "0x4001D4A")]
		public const int BuildIdFieldNumber = 3;

		// Token: 0x04001D4B RID: 7499
		[Token(Token = "0x4001D4B")]
		[FieldOffset(Offset = "0x24")]
		private int buildId_;
	}
}
