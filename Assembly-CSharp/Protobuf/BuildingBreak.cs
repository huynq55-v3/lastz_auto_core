using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Protobuf
{
	// Token: 0x02000475 RID: 1141
	[Token(Token = "0x2000475")]
	public sealed class BuildingBreak : IMessage<BuildingBreak>, IMessage, IEquatable<BuildingBreak>, IDeepCloneable<BuildingBreak>
	{
		// Token: 0x1700048A RID: 1162
		// (get) Token: 0x06002096 RID: 8342 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700048A")]
		[DebuggerNonUserCode]
		public static MessageParser<BuildingBreak> Parser
		{
			[Token(Token = "0x6002096")]
			[Address(RVA = "0x288C0AC", Offset = "0x288C0AC", VA = "0x288C0AC")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700048B RID: 1163
		// (get) Token: 0x06002097 RID: 8343 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700048B")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Token(Token = "0x6002097")]
			[Address(RVA = "0x288C104", Offset = "0x288C104", VA = "0x288C104")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700048C RID: 1164
		// (get) Token: 0x06002098 RID: 8344 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700048C")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Token(Token = "0x6002098")]
			[Address(RVA = "0x288C208", Offset = "0x288C208", VA = "0x288C208", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002099 RID: 8345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002099")]
		[Address(RVA = "0x288C254", Offset = "0x288C254", VA = "0x288C254")]
		[DebuggerNonUserCode]
		public BuildingBreak()
		{
		}

		// Token: 0x0600209A RID: 8346 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600209A")]
		[Address(RVA = "0x288C25C", Offset = "0x288C25C", VA = "0x288C25C")]
		[DebuggerNonUserCode]
		public BuildingBreak(BuildingBreak other)
		{
		}

		// Token: 0x0600209B RID: 8347 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600209B")]
		[Address(RVA = "0x288C2A8", Offset = "0x288C2A8", VA = "0x288C2A8", Slot = "10")]
		[DebuggerNonUserCode]
		public BuildingBreak Clone()
		{
			return null;
		}

		// Token: 0x1700048D RID: 1165
		// (get) Token: 0x0600209C RID: 8348 RVA: 0x0000C750 File Offset: 0x0000A950
		// (set) Token: 0x0600209D RID: 8349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700048D")]
		[DebuggerNonUserCode]
		public int BreakId
		{
			[Token(Token = "0x600209C")]
			[Address(RVA = "0x288C308", Offset = "0x288C308", VA = "0x288C308")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600209D")]
			[Address(RVA = "0x288C310", Offset = "0x288C310", VA = "0x288C310")]
			set
			{
			}
		}

		// Token: 0x1700048E RID: 1166
		// (get) Token: 0x0600209E RID: 8350 RVA: 0x0000C768 File Offset: 0x0000A968
		// (set) Token: 0x0600209F RID: 8351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700048E")]
		[DebuggerNonUserCode]
		public int Direction
		{
			[Token(Token = "0x600209E")]
			[Address(RVA = "0x288C318", Offset = "0x288C318", VA = "0x288C318")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600209F")]
			[Address(RVA = "0x288C320", Offset = "0x288C320", VA = "0x288C320")]
			set
			{
			}
		}

		// Token: 0x060020A0 RID: 8352 RVA: 0x0000C780 File Offset: 0x0000A980
		[Token(Token = "0x60020A0")]
		[Address(RVA = "0x288C328", Offset = "0x288C328", VA = "0x288C328", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x060020A1 RID: 8353 RVA: 0x0000C798 File Offset: 0x0000A998
		[Token(Token = "0x60020A1")]
		[Address(RVA = "0x288C38C", Offset = "0x288C38C", VA = "0x288C38C", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(BuildingBreak other)
		{
			return default(bool);
		}

		// Token: 0x060020A2 RID: 8354 RVA: 0x0000C7B0 File Offset: 0x0000A9B0
		[Token(Token = "0x60020A2")]
		[Address(RVA = "0x288C3D8", Offset = "0x288C3D8", VA = "0x288C3D8", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060020A3 RID: 8355 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020A3")]
		[Address(RVA = "0x288C450", Offset = "0x288C450", VA = "0x288C450", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060020A4 RID: 8356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020A4")]
		[Address(RVA = "0x288C4A8", Offset = "0x288C4A8", VA = "0x288C4A8", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060020A5 RID: 8357 RVA: 0x0000C7C8 File Offset: 0x0000A9C8
		[Token(Token = "0x60020A5")]
		[Address(RVA = "0x288C53C", Offset = "0x288C53C", VA = "0x288C53C", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060020A6 RID: 8358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020A6")]
		[Address(RVA = "0x288C5F0", Offset = "0x288C5F0", VA = "0x288C5F0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(BuildingBreak other)
		{
		}

		// Token: 0x060020A7 RID: 8359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020A7")]
		[Address(RVA = "0x288C63C", Offset = "0x288C63C", VA = "0x288C63C", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x04001F2F RID: 7983
		[Token(Token = "0x4001F2F")]
		[FieldOffset(Offset = "0x0")]
		private static readonly MessageParser<BuildingBreak> _parser;

		// Token: 0x04001F30 RID: 7984
		[Token(Token = "0x4001F30")]
		[FieldOffset(Offset = "0x10")]
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001F31 RID: 7985
		[Token(Token = "0x4001F31")]
		public const int BreakIdFieldNumber = 1;

		// Token: 0x04001F32 RID: 7986
		[Token(Token = "0x4001F32")]
		[FieldOffset(Offset = "0x18")]
		private int breakId_;

		// Token: 0x04001F33 RID: 7987
		[Token(Token = "0x4001F33")]
		public const int DirectionFieldNumber = 2;

		// Token: 0x04001F34 RID: 7988
		[Token(Token = "0x4001F34")]
		[FieldOffset(Offset = "0x1C")]
		private int direction_;
	}
}
