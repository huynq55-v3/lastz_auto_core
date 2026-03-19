using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Google.Protobuf
{
	// Token: 0x02000B06 RID: 2822
	[Token(Token = "0x2000B06")]
	public sealed class FieldCodec<T>
	{
		// Token: 0x06006BEE RID: 27630 RVA: 0x0004E6F0 File Offset: 0x0004C8F0
		[Token(Token = "0x6006BEE")]
		internal static bool IsPackedRepeatedField(uint tag)
		{
			return default(bool);
		}

		// Token: 0x170007BF RID: 1983
		// (get) Token: 0x06006BEF RID: 27631 RVA: 0x0004E708 File Offset: 0x0004C908
		[Token(Token = "0x170007BF")]
		internal bool PackedRepeatedField
		{
			[Token(Token = "0x6006BEF")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170007C0 RID: 1984
		// (get) Token: 0x06006BF0 RID: 27632 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007C0")]
		internal Action<CodedOutputStream, T> ValueWriter
		{
			[Token(Token = "0x6006BF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x170007C1 RID: 1985
		// (get) Token: 0x06006BF1 RID: 27633 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007C1")]
		internal Func<T, int> ValueSizeCalculator
		{
			[Token(Token = "0x6006BF1")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x170007C2 RID: 1986
		// (get) Token: 0x06006BF2 RID: 27634 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007C2")]
		internal Func<CodedInputStream, T> ValueReader
		{
			[Token(Token = "0x6006BF2")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x170007C3 RID: 1987
		// (get) Token: 0x06006BF3 RID: 27635 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007C3")]
		internal FieldCodec<T>.InputMerger ValueMerger
		{
			[Token(Token = "0x6006BF3")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x170007C4 RID: 1988
		// (get) Token: 0x06006BF4 RID: 27636 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007C4")]
		internal FieldCodec<T>.ValuesMerger FieldMerger
		{
			[Token(Token = "0x6006BF4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x170007C5 RID: 1989
		// (get) Token: 0x06006BF5 RID: 27637 RVA: 0x0004E720 File Offset: 0x0004C920
		[Token(Token = "0x170007C5")]
		internal int FixedSize
		{
			[Token(Token = "0x6006BF5")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
		}

		// Token: 0x170007C6 RID: 1990
		// (get) Token: 0x06006BF6 RID: 27638 RVA: 0x0004E738 File Offset: 0x0004C938
		[Token(Token = "0x170007C6")]
		internal uint Tag
		{
			[Token(Token = "0x6006BF6")]
			[CompilerGenerated]
			get
			{
				return 0U;
			}
		}

		// Token: 0x170007C7 RID: 1991
		// (get) Token: 0x06006BF7 RID: 27639 RVA: 0x0004E750 File Offset: 0x0004C950
		[Token(Token = "0x170007C7")]
		internal uint EndTag
		{
			[Token(Token = "0x6006BF7")]
			[CompilerGenerated]
			get
			{
				return 0U;
			}
		}

		// Token: 0x170007C8 RID: 1992
		// (get) Token: 0x06006BF8 RID: 27640 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007C8")]
		internal T DefaultValue
		{
			[Token(Token = "0x6006BF8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x06006BF9 RID: 27641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BF9")]
		internal FieldCodec(Func<CodedInputStream, T> reader, Action<CodedOutputStream, T> writer, int fixedSize, uint tag, T defaultValue)
		{
		}

		// Token: 0x06006BFA RID: 27642 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BFA")]
		internal FieldCodec(Func<CodedInputStream, T> reader, Action<CodedOutputStream, T> writer, Func<T, int> sizeCalculator, uint tag, T defaultValue)
		{
		}

		// Token: 0x06006BFB RID: 27643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BFB")]
		internal FieldCodec(Func<CodedInputStream, T> reader, Action<CodedOutputStream, T> writer, FieldCodec<T>.InputMerger inputMerger, FieldCodec<T>.ValuesMerger valuesMerger, Func<T, int> sizeCalculator, uint tag, uint endTag = 0U)
		{
		}

		// Token: 0x06006BFC RID: 27644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BFC")]
		internal FieldCodec(Func<CodedInputStream, T> reader, Action<CodedOutputStream, T> writer, FieldCodec<T>.InputMerger inputMerger, FieldCodec<T>.ValuesMerger valuesMerger, Func<T, int> sizeCalculator, uint tag, uint endTag, T defaultValue)
		{
		}

		// Token: 0x06006BFD RID: 27645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BFD")]
		public void WriteTagAndValue(CodedOutputStream output, T value)
		{
		}

		// Token: 0x06006BFE RID: 27646 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006BFE")]
		public T Read(CodedInputStream input)
		{
			return null;
		}

		// Token: 0x06006BFF RID: 27647 RVA: 0x0004E768 File Offset: 0x0004C968
		[Token(Token = "0x6006BFF")]
		public int CalculateSizeWithTag(T value)
		{
			return 0;
		}

		// Token: 0x06006C00 RID: 27648 RVA: 0x0004E780 File Offset: 0x0004C980
		[Token(Token = "0x6006C00")]
		private bool IsDefault(T value)
		{
			return default(bool);
		}

		// Token: 0x04002B63 RID: 11107
		[Token(Token = "0x4002B63")]
		[FieldOffset(Offset = "0x0")]
		private static readonly EqualityComparer<T> EqualityComparer;

		// Token: 0x04002B64 RID: 11108
		[Token(Token = "0x4002B64")]
		[FieldOffset(Offset = "0x0")]
		private static readonly T DefaultDefault;

		// Token: 0x04002B65 RID: 11109
		[Token(Token = "0x4002B65")]
		[FieldOffset(Offset = "0x0")]
		private static readonly bool TypeSupportsPacking;

		// Token: 0x04002B70 RID: 11120
		[Token(Token = "0x4002B70")]
		[FieldOffset(Offset = "0x0")]
		private readonly int tagSize;

		// Token: 0x02000B07 RID: 2823
		// (Invoke) Token: 0x06006C02 RID: 27650
		[Token(Token = "0x2000B07")]
		internal delegate void InputMerger(CodedInputStream input, ref T value);

		// Token: 0x02000B08 RID: 2824
		// (Invoke) Token: 0x06006C06 RID: 27654
		[Token(Token = "0x2000B08")]
		internal delegate bool ValuesMerger(ref T value, T other);
	}
}
