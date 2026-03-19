using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Protobuf
{
	// Token: 0x02000493 RID: 1171
	[Token(Token = "0x2000493")]
	public sealed class DesertInfo : IMessage<DesertInfo>, IMessage, IEquatable<DesertInfo>, IDeepCloneable<DesertInfo>
	{
		// Token: 0x17000507 RID: 1287
		// (get) Token: 0x06002244 RID: 8772 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000507")]
		[DebuggerNonUserCode]
		public static MessageParser<DesertInfo> Parser
		{
			[Token(Token = "0x6002244")]
			[Address(RVA = "0x29F7204", Offset = "0x29F7204", VA = "0x29F7204")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000508 RID: 1288
		// (get) Token: 0x06002245 RID: 8773 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000508")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Token(Token = "0x6002245")]
			[Address(RVA = "0x29F725C", Offset = "0x29F725C", VA = "0x29F725C")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000509 RID: 1289
		// (get) Token: 0x06002246 RID: 8774 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000509")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Token(Token = "0x6002246")]
			[Address(RVA = "0x29F7360", Offset = "0x29F7360", VA = "0x29F7360", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002247 RID: 8775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002247")]
		[Address(RVA = "0x29F73AC", Offset = "0x29F73AC", VA = "0x29F73AC")]
		[DebuggerNonUserCode]
		public DesertInfo()
		{
		}

		// Token: 0x06002248 RID: 8776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002248")]
		[Address(RVA = "0x29F7414", Offset = "0x29F7414", VA = "0x29F7414")]
		[DebuggerNonUserCode]
		public DesertInfo(DesertInfo other)
		{
		}

		// Token: 0x06002249 RID: 8777 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002249")]
		[Address(RVA = "0x29F74AC", Offset = "0x29F74AC", VA = "0x29F74AC", Slot = "10")]
		[DebuggerNonUserCode]
		public DesertInfo Clone()
		{
			return null;
		}

		// Token: 0x1700050A RID: 1290
		// (get) Token: 0x0600224A RID: 8778 RVA: 0x0000D218 File Offset: 0x0000B418
		// (set) Token: 0x0600224B RID: 8779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700050A")]
		[DebuggerNonUserCode]
		public int Id
		{
			[Token(Token = "0x600224A")]
			[Address(RVA = "0x29F750C", Offset = "0x29F750C", VA = "0x29F750C")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600224B")]
			[Address(RVA = "0x29F7514", Offset = "0x29F7514", VA = "0x29F7514")]
			set
			{
			}
		}

		// Token: 0x1700050B RID: 1291
		// (get) Token: 0x0600224C RID: 8780 RVA: 0x0000D230 File Offset: 0x0000B430
		// (set) Token: 0x0600224D RID: 8781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700050B")]
		[DebuggerNonUserCode]
		public long Uuid
		{
			[Token(Token = "0x600224C")]
			[Address(RVA = "0x29F751C", Offset = "0x29F751C", VA = "0x29F751C")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x600224D")]
			[Address(RVA = "0x29F7524", Offset = "0x29F7524", VA = "0x29F7524")]
			set
			{
			}
		}

		// Token: 0x1700050C RID: 1292
		// (get) Token: 0x0600224E RID: 8782 RVA: 0x0000D248 File Offset: 0x0000B448
		// (set) Token: 0x0600224F RID: 8783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700050C")]
		[DebuggerNonUserCode]
		public int DesertId
		{
			[Token(Token = "0x600224E")]
			[Address(RVA = "0x29F752C", Offset = "0x29F752C", VA = "0x29F752C")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600224F")]
			[Address(RVA = "0x29F7534", Offset = "0x29F7534", VA = "0x29F7534")]
			set
			{
			}
		}

		// Token: 0x1700050D RID: 1293
		// (get) Token: 0x06002250 RID: 8784 RVA: 0x0000D260 File Offset: 0x0000B460
		// (set) Token: 0x06002251 RID: 8785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700050D")]
		[DebuggerNonUserCode]
		public int ProtectEndTime
		{
			[Token(Token = "0x6002250")]
			[Address(RVA = "0x29F753C", Offset = "0x29F753C", VA = "0x29F753C")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002251")]
			[Address(RVA = "0x29F7544", Offset = "0x29F7544", VA = "0x29F7544")]
			set
			{
			}
		}

		// Token: 0x1700050E RID: 1294
		// (get) Token: 0x06002252 RID: 8786 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002253 RID: 8787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700050E")]
		[DebuggerNonUserCode]
		public string Uid
		{
			[Token(Token = "0x6002252")]
			[Address(RVA = "0x29F754C", Offset = "0x29F754C", VA = "0x29F754C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002253")]
			[Address(RVA = "0x29F7554", Offset = "0x29F7554", VA = "0x29F7554")]
			set
			{
			}
		}

		// Token: 0x1700050F RID: 1295
		// (get) Token: 0x06002254 RID: 8788 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002255 RID: 8789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700050F")]
		[DebuggerNonUserCode]
		public string AllianceId
		{
			[Token(Token = "0x6002254")]
			[Address(RVA = "0x29F75D0", Offset = "0x29F75D0", VA = "0x29F75D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002255")]
			[Address(RVA = "0x29F75D8", Offset = "0x29F75D8", VA = "0x29F75D8")]
			set
			{
			}
		}

		// Token: 0x17000510 RID: 1296
		// (get) Token: 0x06002256 RID: 8790 RVA: 0x0000D278 File Offset: 0x0000B478
		// (set) Token: 0x06002257 RID: 8791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000510")]
		[DebuggerNonUserCode]
		public int ServerId
		{
			[Token(Token = "0x6002256")]
			[Address(RVA = "0x29F7654", Offset = "0x29F7654", VA = "0x29F7654")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002257")]
			[Address(RVA = "0x29F765C", Offset = "0x29F765C", VA = "0x29F765C")]
			set
			{
			}
		}

		// Token: 0x17000511 RID: 1297
		// (get) Token: 0x06002258 RID: 8792 RVA: 0x0000D290 File Offset: 0x0000B490
		// (set) Token: 0x06002259 RID: 8793 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000511")]
		[DebuggerNonUserCode]
		public bool HasAssistance
		{
			[Token(Token = "0x6002258")]
			[Address(RVA = "0x29F7664", Offset = "0x29F7664", VA = "0x29F7664")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002259")]
			[Address(RVA = "0x29F766C", Offset = "0x29F766C", VA = "0x29F766C")]
			set
			{
			}
		}

		// Token: 0x17000512 RID: 1298
		// (get) Token: 0x0600225A RID: 8794 RVA: 0x0000D2A8 File Offset: 0x0000B4A8
		// (set) Token: 0x0600225B RID: 8795 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000512")]
		[DebuggerNonUserCode]
		public int MineId
		{
			[Token(Token = "0x600225A")]
			[Address(RVA = "0x29F7678", Offset = "0x29F7678", VA = "0x29F7678")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600225B")]
			[Address(RVA = "0x29F7680", Offset = "0x29F7680", VA = "0x29F7680")]
			set
			{
			}
		}

		// Token: 0x17000513 RID: 1299
		// (get) Token: 0x0600225C RID: 8796 RVA: 0x0000D2C0 File Offset: 0x0000B4C0
		// (set) Token: 0x0600225D RID: 8797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000513")]
		[DebuggerNonUserCode]
		public int OwnerServer
		{
			[Token(Token = "0x600225C")]
			[Address(RVA = "0x29F7688", Offset = "0x29F7688", VA = "0x29F7688")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600225D")]
			[Address(RVA = "0x29F7690", Offset = "0x29F7690", VA = "0x29F7690")]
			set
			{
			}
		}

		// Token: 0x17000514 RID: 1300
		// (get) Token: 0x0600225E RID: 8798 RVA: 0x0000D2D8 File Offset: 0x0000B4D8
		// (set) Token: 0x0600225F RID: 8799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000514")]
		[DebuggerNonUserCode]
		public int OriDesertId
		{
			[Token(Token = "0x600225E")]
			[Address(RVA = "0x29F7698", Offset = "0x29F7698", VA = "0x29F7698")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600225F")]
			[Address(RVA = "0x29F76A0", Offset = "0x29F76A0", VA = "0x29F76A0")]
			set
			{
			}
		}

		// Token: 0x06002260 RID: 8800 RVA: 0x0000D2F0 File Offset: 0x0000B4F0
		[Token(Token = "0x6002260")]
		[Address(RVA = "0x29F76A8", Offset = "0x29F76A8", VA = "0x29F76A8", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06002261 RID: 8801 RVA: 0x0000D308 File Offset: 0x0000B508
		[Token(Token = "0x6002261")]
		[Address(RVA = "0x29F770C", Offset = "0x29F770C", VA = "0x29F770C", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(DesertInfo other)
		{
			return default(bool);
		}

		// Token: 0x06002262 RID: 8802 RVA: 0x0000D320 File Offset: 0x0000B520
		[Token(Token = "0x6002262")]
		[Address(RVA = "0x29F7820", Offset = "0x29F7820", VA = "0x29F7820", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06002263 RID: 8803 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002263")]
		[Address(RVA = "0x29F79EC", Offset = "0x29F79EC", VA = "0x29F79EC", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06002264 RID: 8804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002264")]
		[Address(RVA = "0x29F7A44", Offset = "0x29F7A44", VA = "0x29F7A44", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06002265 RID: 8805 RVA: 0x0000D338 File Offset: 0x0000B538
		[Token(Token = "0x6002265")]
		[Address(RVA = "0x29F7C74", Offset = "0x29F7C74", VA = "0x29F7C74", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06002266 RID: 8806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002266")]
		[Address(RVA = "0x29F7EB4", Offset = "0x29F7EB4", VA = "0x29F7EB4", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(DesertInfo other)
		{
		}

		// Token: 0x06002267 RID: 8807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002267")]
		[Address(RVA = "0x29F7F9C", Offset = "0x29F7F9C", VA = "0x29F7F9C", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x04001FFC RID: 8188
		[Token(Token = "0x4001FFC")]
		[FieldOffset(Offset = "0x0")]
		private static readonly MessageParser<DesertInfo> _parser;

		// Token: 0x04001FFD RID: 8189
		[Token(Token = "0x4001FFD")]
		[FieldOffset(Offset = "0x10")]
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001FFE RID: 8190
		[Token(Token = "0x4001FFE")]
		public const int IdFieldNumber = 1;

		// Token: 0x04001FFF RID: 8191
		[Token(Token = "0x4001FFF")]
		[FieldOffset(Offset = "0x18")]
		private int id_;

		// Token: 0x04002000 RID: 8192
		[Token(Token = "0x4002000")]
		public const int UuidFieldNumber = 2;

		// Token: 0x04002001 RID: 8193
		[Token(Token = "0x4002001")]
		[FieldOffset(Offset = "0x20")]
		private long uuid_;

		// Token: 0x04002002 RID: 8194
		[Token(Token = "0x4002002")]
		public const int DesertIdFieldNumber = 3;

		// Token: 0x04002003 RID: 8195
		[Token(Token = "0x4002003")]
		[FieldOffset(Offset = "0x28")]
		private int desertId_;

		// Token: 0x04002004 RID: 8196
		[Token(Token = "0x4002004")]
		public const int ProtectEndTimeFieldNumber = 4;

		// Token: 0x04002005 RID: 8197
		[Token(Token = "0x4002005")]
		[FieldOffset(Offset = "0x2C")]
		private int protectEndTime_;

		// Token: 0x04002006 RID: 8198
		[Token(Token = "0x4002006")]
		public const int UidFieldNumber = 5;

		// Token: 0x04002007 RID: 8199
		[Token(Token = "0x4002007")]
		[FieldOffset(Offset = "0x30")]
		private string uid_;

		// Token: 0x04002008 RID: 8200
		[Token(Token = "0x4002008")]
		public const int AllianceIdFieldNumber = 6;

		// Token: 0x04002009 RID: 8201
		[Token(Token = "0x4002009")]
		[FieldOffset(Offset = "0x38")]
		private string allianceId_;

		// Token: 0x0400200A RID: 8202
		[Token(Token = "0x400200A")]
		public const int ServerIdFieldNumber = 7;

		// Token: 0x0400200B RID: 8203
		[Token(Token = "0x400200B")]
		[FieldOffset(Offset = "0x40")]
		private int serverId_;

		// Token: 0x0400200C RID: 8204
		[Token(Token = "0x400200C")]
		public const int HasAssistanceFieldNumber = 8;

		// Token: 0x0400200D RID: 8205
		[Token(Token = "0x400200D")]
		[FieldOffset(Offset = "0x44")]
		private bool hasAssistance_;

		// Token: 0x0400200E RID: 8206
		[Token(Token = "0x400200E")]
		public const int MineIdFieldNumber = 9;

		// Token: 0x0400200F RID: 8207
		[Token(Token = "0x400200F")]
		[FieldOffset(Offset = "0x48")]
		private int mineId_;

		// Token: 0x04002010 RID: 8208
		[Token(Token = "0x4002010")]
		public const int OwnerServerFieldNumber = 10;

		// Token: 0x04002011 RID: 8209
		[Token(Token = "0x4002011")]
		[FieldOffset(Offset = "0x4C")]
		private int ownerServer_;

		// Token: 0x04002012 RID: 8210
		[Token(Token = "0x4002012")]
		public const int OriDesertIdFieldNumber = 11;

		// Token: 0x04002013 RID: 8211
		[Token(Token = "0x4002013")]
		[FieldOffset(Offset = "0x50")]
		private int oriDesertId_;
	}
}
