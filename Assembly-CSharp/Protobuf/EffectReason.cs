using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Protobuf
{
	// Token: 0x02000403 RID: 1027
	[Token(Token = "0x2000403")]
	public sealed class EffectReason : IMessage<EffectReason>, IMessage, IEquatable<EffectReason>, IDeepCloneable<EffectReason>
	{
		// Token: 0x170002DC RID: 732
		// (get) Token: 0x06001AC6 RID: 6854 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002DC")]
		[DebuggerNonUserCode]
		public static MessageParser<EffectReason> Parser
		{
			[Token(Token = "0x6001AC6")]
			[Address(RVA = "0x20E8ED4", Offset = "0x20E8ED4", VA = "0x20E8ED4")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002DD RID: 733
		// (get) Token: 0x06001AC7 RID: 6855 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002DD")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Token(Token = "0x6001AC7")]
			[Address(RVA = "0x20E8F2C", Offset = "0x20E8F2C", VA = "0x20E8F2C")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002DE RID: 734
		// (get) Token: 0x06001AC8 RID: 6856 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002DE")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Token(Token = "0x6001AC8")]
			[Address(RVA = "0x20E9030", Offset = "0x20E9030", VA = "0x20E9030", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001AC9 RID: 6857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AC9")]
		[Address(RVA = "0x20E907C", Offset = "0x20E907C", VA = "0x20E907C")]
		[DebuggerNonUserCode]
		public EffectReason()
		{
		}

		// Token: 0x06001ACA RID: 6858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001ACA")]
		[Address(RVA = "0x20E9084", Offset = "0x20E9084", VA = "0x20E9084")]
		[DebuggerNonUserCode]
		public EffectReason(EffectReason other)
		{
		}

		// Token: 0x06001ACB RID: 6859 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001ACB")]
		[Address(RVA = "0x20E90D0", Offset = "0x20E90D0", VA = "0x20E90D0", Slot = "10")]
		[DebuggerNonUserCode]
		public EffectReason Clone()
		{
			return null;
		}

		// Token: 0x170002DF RID: 735
		// (get) Token: 0x06001ACC RID: 6860 RVA: 0x0000A440 File Offset: 0x00008640
		// (set) Token: 0x06001ACD RID: 6861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170002DF")]
		[DebuggerNonUserCode]
		public int Reason
		{
			[Token(Token = "0x6001ACC")]
			[Address(RVA = "0x20E9130", Offset = "0x20E9130", VA = "0x20E9130")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001ACD")]
			[Address(RVA = "0x20E9138", Offset = "0x20E9138", VA = "0x20E9138")]
			set
			{
			}
		}

		// Token: 0x170002E0 RID: 736
		// (get) Token: 0x06001ACE RID: 6862 RVA: 0x0000A458 File Offset: 0x00008658
		// (set) Token: 0x06001ACF RID: 6863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170002E0")]
		[DebuggerNonUserCode]
		public float Value
		{
			[Token(Token = "0x6001ACE")]
			[Address(RVA = "0x20E9140", Offset = "0x20E9140", VA = "0x20E9140")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6001ACF")]
			[Address(RVA = "0x20E9148", Offset = "0x20E9148", VA = "0x20E9148")]
			set
			{
			}
		}

		// Token: 0x06001AD0 RID: 6864 RVA: 0x0000A470 File Offset: 0x00008670
		[Token(Token = "0x6001AD0")]
		[Address(RVA = "0x20E9150", Offset = "0x20E9150", VA = "0x20E9150", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06001AD1 RID: 6865 RVA: 0x0000A488 File Offset: 0x00008688
		[Token(Token = "0x6001AD1")]
		[Address(RVA = "0x20E91B4", Offset = "0x20E91B4", VA = "0x20E91B4", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(EffectReason other)
		{
			return default(bool);
		}

		// Token: 0x06001AD2 RID: 6866 RVA: 0x0000A4A0 File Offset: 0x000086A0
		[Token(Token = "0x6001AD2")]
		[Address(RVA = "0x20E92B0", Offset = "0x20E92B0", VA = "0x20E92B0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001AD3 RID: 6867 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AD3")]
		[Address(RVA = "0x20E93B0", Offset = "0x20E93B0", VA = "0x20E93B0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001AD4 RID: 6868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AD4")]
		[Address(RVA = "0x20E9408", Offset = "0x20E9408", VA = "0x20E9408", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06001AD5 RID: 6869 RVA: 0x0000A4B8 File Offset: 0x000086B8
		[Token(Token = "0x6001AD5")]
		[Address(RVA = "0x20E94A0", Offset = "0x20E94A0", VA = "0x20E94A0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06001AD6 RID: 6870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AD6")]
		[Address(RVA = "0x20E9538", Offset = "0x20E9538", VA = "0x20E9538", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(EffectReason other)
		{
		}

		// Token: 0x06001AD7 RID: 6871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AD7")]
		[Address(RVA = "0x20E9588", Offset = "0x20E9588", VA = "0x20E9588", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x04001C5C RID: 7260
		[Token(Token = "0x4001C5C")]
		[FieldOffset(Offset = "0x0")]
		private static readonly MessageParser<EffectReason> _parser;

		// Token: 0x04001C5D RID: 7261
		[Token(Token = "0x4001C5D")]
		[FieldOffset(Offset = "0x10")]
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001C5E RID: 7262
		[Token(Token = "0x4001C5E")]
		public const int ReasonFieldNumber = 1;

		// Token: 0x04001C5F RID: 7263
		[Token(Token = "0x4001C5F")]
		[FieldOffset(Offset = "0x18")]
		private int reason_;

		// Token: 0x04001C60 RID: 7264
		[Token(Token = "0x4001C60")]
		public const int ValueFieldNumber = 2;

		// Token: 0x04001C61 RID: 7265
		[Token(Token = "0x4001C61")]
		[FieldOffset(Offset = "0x1C")]
		private float value_;
	}
}
