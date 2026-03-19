using System;
using System.Diagnostics;
using System.Text;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Google.Protobuf.WellKnownTypes
{
	// Token: 0x02000B3C RID: 2876
	[Token(Token = "0x2000B3C")]
	public sealed class Duration : IMessage<Duration>, IMessage, IEquatable<Duration>, IDeepCloneable<Duration>, ICustomDiagnosticMessage
	{
		// Token: 0x1700080A RID: 2058
		// (get) Token: 0x06006DA2 RID: 28066 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700080A")]
		[DebuggerNonUserCode]
		public static MessageParser<Duration> Parser
		{
			[Token(Token = "0x6006DA2")]
			[Address(RVA = "0x366DFEC", Offset = "0x366DFEC", VA = "0x366DFEC")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700080B RID: 2059
		// (get) Token: 0x06006DA3 RID: 28067 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700080B")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Token(Token = "0x6006DA3")]
			[Address(RVA = "0x366E044", Offset = "0x366E044", VA = "0x366E044")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700080C RID: 2060
		// (get) Token: 0x06006DA4 RID: 28068 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700080C")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Token(Token = "0x6006DA4")]
			[Address(RVA = "0x366E148", Offset = "0x366E148", VA = "0x366E148", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006DA5 RID: 28069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DA5")]
		[Address(RVA = "0x366E194", Offset = "0x366E194", VA = "0x366E194")]
		[DebuggerNonUserCode]
		public Duration()
		{
		}

		// Token: 0x06006DA6 RID: 28070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DA6")]
		[Address(RVA = "0x366E19C", Offset = "0x366E19C", VA = "0x366E19C")]
		[DebuggerNonUserCode]
		public Duration(Duration other)
		{
		}

		// Token: 0x06006DA7 RID: 28071 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006DA7")]
		[Address(RVA = "0x366E1F0", Offset = "0x366E1F0", VA = "0x366E1F0", Slot = "10")]
		[DebuggerNonUserCode]
		public Duration Clone()
		{
			return null;
		}

		// Token: 0x1700080D RID: 2061
		// (get) Token: 0x06006DA8 RID: 28072 RVA: 0x0004EE70 File Offset: 0x0004D070
		// (set) Token: 0x06006DA9 RID: 28073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700080D")]
		[DebuggerNonUserCode]
		public long Seconds
		{
			[Token(Token = "0x6006DA8")]
			[Address(RVA = "0x366E250", Offset = "0x366E250", VA = "0x366E250")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x6006DA9")]
			[Address(RVA = "0x366E258", Offset = "0x366E258", VA = "0x366E258")]
			set
			{
			}
		}

		// Token: 0x1700080E RID: 2062
		// (get) Token: 0x06006DAA RID: 28074 RVA: 0x0004EE88 File Offset: 0x0004D088
		// (set) Token: 0x06006DAB RID: 28075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700080E")]
		[DebuggerNonUserCode]
		public int Nanos
		{
			[Token(Token = "0x6006DAA")]
			[Address(RVA = "0x366E260", Offset = "0x366E260", VA = "0x366E260")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6006DAB")]
			[Address(RVA = "0x366E268", Offset = "0x366E268", VA = "0x366E268")]
			set
			{
			}
		}

		// Token: 0x06006DAC RID: 28076 RVA: 0x0004EEA0 File Offset: 0x0004D0A0
		[Token(Token = "0x6006DAC")]
		[Address(RVA = "0x366E270", Offset = "0x366E270", VA = "0x366E270", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06006DAD RID: 28077 RVA: 0x0004EEB8 File Offset: 0x0004D0B8
		[Token(Token = "0x6006DAD")]
		[Address(RVA = "0x366E2D4", Offset = "0x366E2D4", VA = "0x366E2D4", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(Duration other)
		{
			return default(bool);
		}

		// Token: 0x06006DAE RID: 28078 RVA: 0x0004EED0 File Offset: 0x0004D0D0
		[Token(Token = "0x6006DAE")]
		[Address(RVA = "0x366E320", Offset = "0x366E320", VA = "0x366E320", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06006DAF RID: 28079 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006DAF")]
		[Address(RVA = "0x366E3A0", Offset = "0x366E3A0", VA = "0x366E3A0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06006DB0 RID: 28080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DB0")]
		[Address(RVA = "0x366E3F8", Offset = "0x366E3F8", VA = "0x366E3F8", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06006DB1 RID: 28081 RVA: 0x0004EEE8 File Offset: 0x0004D0E8
		[Token(Token = "0x6006DB1")]
		[Address(RVA = "0x366E48C", Offset = "0x366E48C", VA = "0x366E48C", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06006DB2 RID: 28082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DB2")]
		[Address(RVA = "0x366E540", Offset = "0x366E540", VA = "0x366E540", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(Duration other)
		{
		}

		// Token: 0x06006DB3 RID: 28083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DB3")]
		[Address(RVA = "0x366E58C", Offset = "0x366E58C", VA = "0x366E58C", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06006DB4 RID: 28084 RVA: 0x0004EF00 File Offset: 0x0004D100
		[Token(Token = "0x6006DB4")]
		[Address(RVA = "0x366E620", Offset = "0x366E620", VA = "0x366E620")]
		internal static bool IsNormalized(long seconds, int nanoseconds)
		{
			return default(bool);
		}

		// Token: 0x06006DB5 RID: 28085 RVA: 0x0004EF18 File Offset: 0x0004D118
		[Token(Token = "0x6006DB5")]
		[Address(RVA = "0x366E6E0", Offset = "0x366E6E0", VA = "0x366E6E0")]
		public TimeSpan ToTimeSpan()
		{
			return default(TimeSpan);
		}

		// Token: 0x06006DB6 RID: 28086 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006DB6")]
		[Address(RVA = "0x366E864", Offset = "0x366E864", VA = "0x366E864")]
		public static Duration FromTimeSpan(TimeSpan timeSpan)
		{
			return null;
		}

		// Token: 0x06006DB7 RID: 28087 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006DB7")]
		[Address(RVA = "0x366E954", Offset = "0x366E954", VA = "0x366E954")]
		public static Duration operator -(Duration value)
		{
			return null;
		}

		// Token: 0x06006DB8 RID: 28088 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006DB8")]
		[Address(RVA = "0x366EAFC", Offset = "0x366EAFC", VA = "0x366EAFC")]
		public static Duration operator +(Duration lhs, Duration rhs)
		{
			return null;
		}

		// Token: 0x06006DB9 RID: 28089 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006DB9")]
		[Address(RVA = "0x366EC34", Offset = "0x366EC34", VA = "0x366EC34")]
		public static Duration operator -(Duration lhs, Duration rhs)
		{
			return null;
		}

		// Token: 0x06006DBA RID: 28090 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006DBA")]
		[Address(RVA = "0x366EA34", Offset = "0x366EA34", VA = "0x366EA34")]
		internal static Duration Normalize(long seconds, int nanoseconds)
		{
			return null;
		}

		// Token: 0x06006DBB RID: 28091 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006DBB")]
		[Address(RVA = "0x366ED74", Offset = "0x366ED74", VA = "0x366ED74")]
		internal static string ToJson(long seconds, int nanoseconds, bool diagnosticOnly)
		{
			return null;
		}

		// Token: 0x06006DBC RID: 28092 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006DBC")]
		[Address(RVA = "0x366F180", Offset = "0x366F180", VA = "0x366F180", Slot = "11")]
		public string ToDiagnosticString()
		{
			return null;
		}

		// Token: 0x06006DBD RID: 28093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DBD")]
		[Address(RVA = "0x366F014", Offset = "0x366F014", VA = "0x366F014")]
		internal static void AppendNanoseconds(StringBuilder builder, int nanos)
		{
		}

		// Token: 0x04002C1F RID: 11295
		[Token(Token = "0x4002C1F")]
		[FieldOffset(Offset = "0x0")]
		private static readonly MessageParser<Duration> _parser;

		// Token: 0x04002C20 RID: 11296
		[Token(Token = "0x4002C20")]
		[FieldOffset(Offset = "0x10")]
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002C21 RID: 11297
		[Token(Token = "0x4002C21")]
		public const int SecondsFieldNumber = 1;

		// Token: 0x04002C22 RID: 11298
		[Token(Token = "0x4002C22")]
		[FieldOffset(Offset = "0x18")]
		private long seconds_;

		// Token: 0x04002C23 RID: 11299
		[Token(Token = "0x4002C23")]
		public const int NanosFieldNumber = 2;

		// Token: 0x04002C24 RID: 11300
		[Token(Token = "0x4002C24")]
		[FieldOffset(Offset = "0x20")]
		private int nanos_;

		// Token: 0x04002C25 RID: 11301
		[Token(Token = "0x4002C25")]
		public const int NanosecondsPerSecond = 1000000000;

		// Token: 0x04002C26 RID: 11302
		[Token(Token = "0x4002C26")]
		public const int NanosecondsPerTick = 100;

		// Token: 0x04002C27 RID: 11303
		[Token(Token = "0x4002C27")]
		public const long MaxSeconds = 315576000000L;

		// Token: 0x04002C28 RID: 11304
		[Token(Token = "0x4002C28")]
		public const long MinSeconds = -315576000000L;

		// Token: 0x04002C29 RID: 11305
		[Token(Token = "0x4002C29")]
		internal const int MaxNanoseconds = 999999999;

		// Token: 0x04002C2A RID: 11306
		[Token(Token = "0x4002C2A")]
		internal const int MinNanoseconds = -999999999;
	}
}
