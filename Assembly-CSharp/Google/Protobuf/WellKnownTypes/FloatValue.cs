using System;
using System.Diagnostics;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Google.Protobuf.WellKnownTypes
{
	// Token: 0x02000B67 RID: 2919
	[Token(Token = "0x2000B67")]
	public sealed class FloatValue : IMessage<FloatValue>, IMessage, IEquatable<FloatValue>, IDeepCloneable<FloatValue>
	{
		// Token: 0x17000868 RID: 2152
		// (get) Token: 0x06006F34 RID: 28468 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000868")]
		[DebuggerNonUserCode]
		public static MessageParser<FloatValue> Parser
		{
			[Token(Token = "0x6006F34")]
			[Address(RVA = "0x3680C4C", Offset = "0x3680C4C", VA = "0x3680C4C")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000869 RID: 2153
		// (get) Token: 0x06006F35 RID: 28469 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000869")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Token(Token = "0x6006F35")]
			[Address(RVA = "0x3680CA4", Offset = "0x3680CA4", VA = "0x3680CA4")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700086A RID: 2154
		// (get) Token: 0x06006F36 RID: 28470 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700086A")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Token(Token = "0x6006F36")]
			[Address(RVA = "0x3680DA8", Offset = "0x3680DA8", VA = "0x3680DA8", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006F37 RID: 28471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F37")]
		[Address(RVA = "0x3680DF4", Offset = "0x3680DF4", VA = "0x3680DF4")]
		[DebuggerNonUserCode]
		public FloatValue()
		{
		}

		// Token: 0x06006F38 RID: 28472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F38")]
		[Address(RVA = "0x3680DFC", Offset = "0x3680DFC", VA = "0x3680DFC")]
		[DebuggerNonUserCode]
		public FloatValue(FloatValue other)
		{
		}

		// Token: 0x06006F39 RID: 28473 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006F39")]
		[Address(RVA = "0x3680E48", Offset = "0x3680E48", VA = "0x3680E48", Slot = "10")]
		[DebuggerNonUserCode]
		public FloatValue Clone()
		{
			return null;
		}

		// Token: 0x1700086B RID: 2155
		// (get) Token: 0x06006F3A RID: 28474 RVA: 0x0004F740 File Offset: 0x0004D940
		// (set) Token: 0x06006F3B RID: 28475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700086B")]
		[DebuggerNonUserCode]
		public float Value
		{
			[Token(Token = "0x6006F3A")]
			[Address(RVA = "0x3680EA8", Offset = "0x3680EA8", VA = "0x3680EA8")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6006F3B")]
			[Address(RVA = "0x3680EB0", Offset = "0x3680EB0", VA = "0x3680EB0")]
			set
			{
			}
		}

		// Token: 0x06006F3C RID: 28476 RVA: 0x0004F758 File Offset: 0x0004D958
		[Token(Token = "0x6006F3C")]
		[Address(RVA = "0x3680EB8", Offset = "0x3680EB8", VA = "0x3680EB8", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06006F3D RID: 28477 RVA: 0x0004F770 File Offset: 0x0004D970
		[Token(Token = "0x6006F3D")]
		[Address(RVA = "0x3680F1C", Offset = "0x3680F1C", VA = "0x3680F1C", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(FloatValue other)
		{
			return default(bool);
		}

		// Token: 0x06006F3E RID: 28478 RVA: 0x0004F788 File Offset: 0x0004D988
		[Token(Token = "0x6006F3E")]
		[Address(RVA = "0x3681008", Offset = "0x3681008", VA = "0x3681008", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06006F3F RID: 28479 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006F3F")]
		[Address(RVA = "0x36810E0", Offset = "0x36810E0", VA = "0x36810E0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06006F40 RID: 28480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F40")]
		[Address(RVA = "0x3681138", Offset = "0x3681138", VA = "0x3681138", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06006F41 RID: 28481 RVA: 0x0004F7A0 File Offset: 0x0004D9A0
		[Token(Token = "0x6006F41")]
		[Address(RVA = "0x36811A4", Offset = "0x36811A4", VA = "0x36811A4", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06006F42 RID: 28482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F42")]
		[Address(RVA = "0x36811D8", Offset = "0x36811D8", VA = "0x36811D8", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(FloatValue other)
		{
		}

		// Token: 0x06006F43 RID: 28483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F43")]
		[Address(RVA = "0x368121C", Offset = "0x368121C", VA = "0x368121C", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x04002CE0 RID: 11488
		[Token(Token = "0x4002CE0")]
		[FieldOffset(Offset = "0x0")]
		private static readonly MessageParser<FloatValue> _parser;

		// Token: 0x04002CE1 RID: 11489
		[Token(Token = "0x4002CE1")]
		[FieldOffset(Offset = "0x10")]
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002CE2 RID: 11490
		[Token(Token = "0x4002CE2")]
		public const int ValueFieldNumber = 1;

		// Token: 0x04002CE3 RID: 11491
		[Token(Token = "0x4002CE3")]
		[FieldOffset(Offset = "0x18")]
		private float value_;
	}
}
