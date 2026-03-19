using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Protobuf
{
	// Token: 0x0200047B RID: 1147
	[Token(Token = "0x200047B")]
	public sealed class ResourceInfo : IMessage<ResourceInfo>, IMessage, IEquatable<ResourceInfo>, IDeepCloneable<ResourceInfo>
	{
		// Token: 0x1700049F RID: 1183
		// (get) Token: 0x060020E4 RID: 8420 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700049F")]
		[DebuggerNonUserCode]
		public static MessageParser<ResourceInfo> Parser
		{
			[Token(Token = "0x60020E4")]
			[Address(RVA = "0x288DF78", Offset = "0x288DF78", VA = "0x288DF78")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004A0 RID: 1184
		// (get) Token: 0x060020E5 RID: 8421 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004A0")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Token(Token = "0x60020E5")]
			[Address(RVA = "0x288DFD0", Offset = "0x288DFD0", VA = "0x288DFD0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004A1 RID: 1185
		// (get) Token: 0x060020E6 RID: 8422 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004A1")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Token(Token = "0x60020E6")]
			[Address(RVA = "0x288E0D4", Offset = "0x288E0D4", VA = "0x288E0D4", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x060020E7 RID: 8423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020E7")]
		[Address(RVA = "0x288E120", Offset = "0x288E120", VA = "0x288E120")]
		[DebuggerNonUserCode]
		public ResourceInfo()
		{
		}

		// Token: 0x060020E8 RID: 8424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020E8")]
		[Address(RVA = "0x288E128", Offset = "0x288E128", VA = "0x288E128")]
		[DebuggerNonUserCode]
		public ResourceInfo(ResourceInfo other)
		{
		}

		// Token: 0x060020E9 RID: 8425 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020E9")]
		[Address(RVA = "0x288E17C", Offset = "0x288E17C", VA = "0x288E17C", Slot = "10")]
		[DebuggerNonUserCode]
		public ResourceInfo Clone()
		{
			return null;
		}

		// Token: 0x170004A2 RID: 1186
		// (get) Token: 0x060020EA RID: 8426 RVA: 0x0000C960 File Offset: 0x0000AB60
		// (set) Token: 0x060020EB RID: 8427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004A2")]
		[DebuggerNonUserCode]
		public int ResourceId
		{
			[Token(Token = "0x60020EA")]
			[Address(RVA = "0x288E1DC", Offset = "0x288E1DC", VA = "0x288E1DC")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60020EB")]
			[Address(RVA = "0x288E1E4", Offset = "0x288E1E4", VA = "0x288E1E4")]
			set
			{
			}
		}

		// Token: 0x170004A3 RID: 1187
		// (get) Token: 0x060020EC RID: 8428 RVA: 0x0000C978 File Offset: 0x0000AB78
		// (set) Token: 0x060020ED RID: 8429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004A3")]
		[DebuggerNonUserCode]
		public int State
		{
			[Token(Token = "0x60020EC")]
			[Address(RVA = "0x288E1EC", Offset = "0x288E1EC", VA = "0x288E1EC")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60020ED")]
			[Address(RVA = "0x288E1F4", Offset = "0x288E1F4", VA = "0x288E1F4")]
			set
			{
			}
		}

		// Token: 0x170004A4 RID: 1188
		// (get) Token: 0x060020EE RID: 8430 RVA: 0x0000C990 File Offset: 0x0000AB90
		// (set) Token: 0x060020EF RID: 8431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004A4")]
		[DebuggerNonUserCode]
		public long GatherUuid
		{
			[Token(Token = "0x60020EE")]
			[Address(RVA = "0x288E1FC", Offset = "0x288E1FC", VA = "0x288E1FC")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x60020EF")]
			[Address(RVA = "0x288E204", Offset = "0x288E204", VA = "0x288E204")]
			set
			{
			}
		}

		// Token: 0x060020F0 RID: 8432 RVA: 0x0000C9A8 File Offset: 0x0000ABA8
		[Token(Token = "0x60020F0")]
		[Address(RVA = "0x288E20C", Offset = "0x288E20C", VA = "0x288E20C", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x060020F1 RID: 8433 RVA: 0x0000C9C0 File Offset: 0x0000ABC0
		[Token(Token = "0x60020F1")]
		[Address(RVA = "0x288E270", Offset = "0x288E270", VA = "0x288E270", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ResourceInfo other)
		{
			return default(bool);
		}

		// Token: 0x060020F2 RID: 8434 RVA: 0x0000C9D8 File Offset: 0x0000ABD8
		[Token(Token = "0x60020F2")]
		[Address(RVA = "0x288E2CC", Offset = "0x288E2CC", VA = "0x288E2CC", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060020F3 RID: 8435 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020F3")]
		[Address(RVA = "0x288E368", Offset = "0x288E368", VA = "0x288E368", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060020F4 RID: 8436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020F4")]
		[Address(RVA = "0x288E3C0", Offset = "0x288E3C0", VA = "0x288E3C0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060020F5 RID: 8437 RVA: 0x0000C9F0 File Offset: 0x0000ABF0
		[Token(Token = "0x60020F5")]
		[Address(RVA = "0x288E480", Offset = "0x288E480", VA = "0x288E480", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060020F6 RID: 8438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020F6")]
		[Address(RVA = "0x288E560", Offset = "0x288E560", VA = "0x288E560", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(ResourceInfo other)
		{
		}

		// Token: 0x060020F7 RID: 8439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020F7")]
		[Address(RVA = "0x288E5B8", Offset = "0x288E5B8", VA = "0x288E5B8", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x04001F50 RID: 8016
		[Token(Token = "0x4001F50")]
		[FieldOffset(Offset = "0x0")]
		private static readonly MessageParser<ResourceInfo> _parser;

		// Token: 0x04001F51 RID: 8017
		[Token(Token = "0x4001F51")]
		[FieldOffset(Offset = "0x10")]
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001F52 RID: 8018
		[Token(Token = "0x4001F52")]
		public const int ResourceIdFieldNumber = 1;

		// Token: 0x04001F53 RID: 8019
		[Token(Token = "0x4001F53")]
		[FieldOffset(Offset = "0x18")]
		private int resourceId_;

		// Token: 0x04001F54 RID: 8020
		[Token(Token = "0x4001F54")]
		public const int StateFieldNumber = 2;

		// Token: 0x04001F55 RID: 8021
		[Token(Token = "0x4001F55")]
		[FieldOffset(Offset = "0x1C")]
		private int state_;

		// Token: 0x04001F56 RID: 8022
		[Token(Token = "0x4001F56")]
		public const int GatherUuidFieldNumber = 3;

		// Token: 0x04001F57 RID: 8023
		[Token(Token = "0x4001F57")]
		[FieldOffset(Offset = "0x20")]
		private long gatherUuid_;
	}
}
