using System;
using System.Diagnostics;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Google.Protobuf.WellKnownTypes
{
	// Token: 0x02000B53 RID: 2899
	[Token(Token = "0x2000B53")]
	public sealed class Timestamp : IMessage<Timestamp>, IMessage, IEquatable<Timestamp>, IDeepCloneable<Timestamp>, ICustomDiagnosticMessage, IComparable<Timestamp>
	{
		// Token: 0x17000834 RID: 2100
		// (get) Token: 0x06006E6D RID: 28269 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000834")]
		[DebuggerNonUserCode]
		public static MessageParser<Timestamp> Parser
		{
			[Token(Token = "0x6006E6D")]
			[Address(RVA = "0x3677010", Offset = "0x3677010", VA = "0x3677010")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000835 RID: 2101
		// (get) Token: 0x06006E6E RID: 28270 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000835")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Token(Token = "0x6006E6E")]
			[Address(RVA = "0x3677068", Offset = "0x3677068", VA = "0x3677068")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000836 RID: 2102
		// (get) Token: 0x06006E6F RID: 28271 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000836")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Token(Token = "0x6006E6F")]
			[Address(RVA = "0x367716C", Offset = "0x367716C", VA = "0x367716C", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006E70 RID: 28272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E70")]
		[Address(RVA = "0x36771B8", Offset = "0x36771B8", VA = "0x36771B8")]
		[DebuggerNonUserCode]
		public Timestamp()
		{
		}

		// Token: 0x06006E71 RID: 28273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E71")]
		[Address(RVA = "0x36771C0", Offset = "0x36771C0", VA = "0x36771C0")]
		[DebuggerNonUserCode]
		public Timestamp(Timestamp other)
		{
		}

		// Token: 0x06006E72 RID: 28274 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006E72")]
		[Address(RVA = "0x3677214", Offset = "0x3677214", VA = "0x3677214", Slot = "10")]
		[DebuggerNonUserCode]
		public Timestamp Clone()
		{
			return null;
		}

		// Token: 0x17000837 RID: 2103
		// (get) Token: 0x06006E73 RID: 28275 RVA: 0x0004F2A8 File Offset: 0x0004D4A8
		// (set) Token: 0x06006E74 RID: 28276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000837")]
		[DebuggerNonUserCode]
		public long Seconds
		{
			[Token(Token = "0x6006E73")]
			[Address(RVA = "0x3677274", Offset = "0x3677274", VA = "0x3677274")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x6006E74")]
			[Address(RVA = "0x367727C", Offset = "0x367727C", VA = "0x367727C")]
			set
			{
			}
		}

		// Token: 0x17000838 RID: 2104
		// (get) Token: 0x06006E75 RID: 28277 RVA: 0x0004F2C0 File Offset: 0x0004D4C0
		// (set) Token: 0x06006E76 RID: 28278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000838")]
		[DebuggerNonUserCode]
		public int Nanos
		{
			[Token(Token = "0x6006E75")]
			[Address(RVA = "0x3677284", Offset = "0x3677284", VA = "0x3677284")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6006E76")]
			[Address(RVA = "0x367728C", Offset = "0x367728C", VA = "0x367728C")]
			set
			{
			}
		}

		// Token: 0x06006E77 RID: 28279 RVA: 0x0004F2D8 File Offset: 0x0004D4D8
		[Token(Token = "0x6006E77")]
		[Address(RVA = "0x3677294", Offset = "0x3677294", VA = "0x3677294", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06006E78 RID: 28280 RVA: 0x0004F2F0 File Offset: 0x0004D4F0
		[Token(Token = "0x6006E78")]
		[Address(RVA = "0x36772F8", Offset = "0x36772F8", VA = "0x36772F8", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(Timestamp other)
		{
			return default(bool);
		}

		// Token: 0x06006E79 RID: 28281 RVA: 0x0004F308 File Offset: 0x0004D508
		[Token(Token = "0x6006E79")]
		[Address(RVA = "0x3677344", Offset = "0x3677344", VA = "0x3677344", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06006E7A RID: 28282 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006E7A")]
		[Address(RVA = "0x36773C4", Offset = "0x36773C4", VA = "0x36773C4", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06006E7B RID: 28283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E7B")]
		[Address(RVA = "0x367741C", Offset = "0x367741C", VA = "0x367741C", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06006E7C RID: 28284 RVA: 0x0004F320 File Offset: 0x0004D520
		[Token(Token = "0x6006E7C")]
		[Address(RVA = "0x36774B0", Offset = "0x36774B0", VA = "0x36774B0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06006E7D RID: 28285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E7D")]
		[Address(RVA = "0x3677564", Offset = "0x3677564", VA = "0x3677564", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(Timestamp other)
		{
		}

		// Token: 0x06006E7E RID: 28286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E7E")]
		[Address(RVA = "0x3677630", Offset = "0x3677630", VA = "0x3677630", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06006E7F RID: 28287 RVA: 0x0004F338 File Offset: 0x0004D538
		[Token(Token = "0x6006E7F")]
		[Address(RVA = "0x36776C4", Offset = "0x36776C4", VA = "0x36776C4")]
		private static bool IsNormalized(long seconds, int nanoseconds)
		{
			return default(bool);
		}

		// Token: 0x06006E80 RID: 28288 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006E80")]
		[Address(RVA = "0x3677704", Offset = "0x3677704", VA = "0x3677704")]
		public static Duration operator -(Timestamp lhs, Timestamp rhs)
		{
			return null;
		}

		// Token: 0x06006E81 RID: 28289 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006E81")]
		[Address(RVA = "0x3677844", Offset = "0x3677844", VA = "0x3677844")]
		public static Timestamp operator +(Timestamp lhs, Duration rhs)
		{
			return null;
		}

		// Token: 0x06006E82 RID: 28290 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006E82")]
		[Address(RVA = "0x3677A44", Offset = "0x3677A44", VA = "0x3677A44")]
		public static Timestamp operator -(Timestamp lhs, Duration rhs)
		{
			return null;
		}

		// Token: 0x06006E83 RID: 28291 RVA: 0x0004F350 File Offset: 0x0004D550
		[Token(Token = "0x6006E83")]
		[Address(RVA = "0x3677B94", Offset = "0x3677B94", VA = "0x3677B94")]
		public DateTime ToDateTime()
		{
			return default(DateTime);
		}

		// Token: 0x06006E84 RID: 28292 RVA: 0x0004F368 File Offset: 0x0004D568
		[Token(Token = "0x6006E84")]
		[Address(RVA = "0x3677CF8", Offset = "0x3677CF8", VA = "0x3677CF8")]
		public DateTimeOffset ToDateTimeOffset()
		{
			return default(DateTimeOffset);
		}

		// Token: 0x06006E85 RID: 28293 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006E85")]
		[Address(RVA = "0x3676718", Offset = "0x3676718", VA = "0x3676718")]
		public static Timestamp FromDateTime(DateTime dateTime)
		{
			return null;
		}

		// Token: 0x06006E86 RID: 28294 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006E86")]
		[Address(RVA = "0x3676910", Offset = "0x3676910", VA = "0x3676910")]
		public static Timestamp FromDateTimeOffset(DateTimeOffset dateTimeOffset)
		{
			return null;
		}

		// Token: 0x06006E87 RID: 28295 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006E87")]
		[Address(RVA = "0x367798C", Offset = "0x367798C", VA = "0x367798C")]
		internal static Timestamp Normalize(long seconds, int nanoseconds)
		{
			return null;
		}

		// Token: 0x06006E88 RID: 28296 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006E88")]
		[Address(RVA = "0x3677D84", Offset = "0x3677D84", VA = "0x3677D84")]
		internal static string ToJson(long seconds, int nanoseconds, bool diagnosticOnly)
		{
			return null;
		}

		// Token: 0x06006E89 RID: 28297 RVA: 0x0004F380 File Offset: 0x0004D580
		[Token(Token = "0x6006E89")]
		[Address(RVA = "0x3678070", Offset = "0x3678070", VA = "0x3678070", Slot = "12")]
		public int CompareTo(Timestamp other)
		{
			return 0;
		}

		// Token: 0x06006E8A RID: 28298 RVA: 0x0004F398 File Offset: 0x0004D598
		[Token(Token = "0x6006E8A")]
		[Address(RVA = "0x3678110", Offset = "0x3678110", VA = "0x3678110")]
		public static bool operator <(Timestamp a, Timestamp b)
		{
			return default(bool);
		}

		// Token: 0x06006E8B RID: 28299 RVA: 0x0004F3B0 File Offset: 0x0004D5B0
		[Token(Token = "0x6006E8B")]
		[Address(RVA = "0x367812C", Offset = "0x367812C", VA = "0x367812C")]
		public static bool operator >(Timestamp a, Timestamp b)
		{
			return default(bool);
		}

		// Token: 0x06006E8C RID: 28300 RVA: 0x0004F3C8 File Offset: 0x0004D5C8
		[Token(Token = "0x6006E8C")]
		[Address(RVA = "0x367814C", Offset = "0x367814C", VA = "0x367814C")]
		public static bool operator <=(Timestamp a, Timestamp b)
		{
			return default(bool);
		}

		// Token: 0x06006E8D RID: 28301 RVA: 0x0004F3E0 File Offset: 0x0004D5E0
		[Token(Token = "0x6006E8D")]
		[Address(RVA = "0x367816C", Offset = "0x367816C", VA = "0x367816C")]
		public static bool operator >=(Timestamp a, Timestamp b)
		{
			return default(bool);
		}

		// Token: 0x06006E8E RID: 28302 RVA: 0x0004F3F8 File Offset: 0x0004D5F8
		[Token(Token = "0x6006E8E")]
		[Address(RVA = "0x367760C", Offset = "0x367760C", VA = "0x367760C")]
		public static bool operator ==(Timestamp a, Timestamp b)
		{
			return default(bool);
		}

		// Token: 0x06006E8F RID: 28303 RVA: 0x0004F410 File Offset: 0x0004D610
		[Token(Token = "0x6006E8F")]
		[Address(RVA = "0x367818C", Offset = "0x367818C", VA = "0x367818C")]
		public static bool operator !=(Timestamp a, Timestamp b)
		{
			return default(bool);
		}

		// Token: 0x06006E90 RID: 28304 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006E90")]
		[Address(RVA = "0x367821C", Offset = "0x367821C", VA = "0x367821C", Slot = "11")]
		public string ToDiagnosticString()
		{
			return null;
		}

		// Token: 0x04002C66 RID: 11366
		[Token(Token = "0x4002C66")]
		[FieldOffset(Offset = "0x0")]
		private static readonly MessageParser<Timestamp> _parser;

		// Token: 0x04002C67 RID: 11367
		[Token(Token = "0x4002C67")]
		[FieldOffset(Offset = "0x10")]
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002C68 RID: 11368
		[Token(Token = "0x4002C68")]
		public const int SecondsFieldNumber = 1;

		// Token: 0x04002C69 RID: 11369
		[Token(Token = "0x4002C69")]
		[FieldOffset(Offset = "0x18")]
		private long seconds_;

		// Token: 0x04002C6A RID: 11370
		[Token(Token = "0x4002C6A")]
		public const int NanosFieldNumber = 2;

		// Token: 0x04002C6B RID: 11371
		[Token(Token = "0x4002C6B")]
		[FieldOffset(Offset = "0x20")]
		private int nanos_;

		// Token: 0x04002C6C RID: 11372
		[Token(Token = "0x4002C6C")]
		[FieldOffset(Offset = "0x8")]
		private static readonly DateTime UnixEpoch;

		// Token: 0x04002C6D RID: 11373
		[Token(Token = "0x4002C6D")]
		private const long BclSecondsAtUnixEpoch = 62135596800L;

		// Token: 0x04002C6E RID: 11374
		[Token(Token = "0x4002C6E")]
		internal const long UnixSecondsAtBclMaxValue = 253402300799L;

		// Token: 0x04002C6F RID: 11375
		[Token(Token = "0x4002C6F")]
		internal const long UnixSecondsAtBclMinValue = -62135596800L;

		// Token: 0x04002C70 RID: 11376
		[Token(Token = "0x4002C70")]
		internal const int MaxNanos = 999999999;
	}
}
