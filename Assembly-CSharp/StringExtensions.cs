using System;
using System.IO;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.IL2CPP.CompilerServices;
using UnityEngine.Scripting;

// Token: 0x020000C0 RID: 192
[Token(Token = "0x20000C0")]
[Il2CppSetOption(Option.NullChecks, false)]
[Preserve]
public static class StringExtensions
{
	// Token: 0x06000469 RID: 1129 RVA: 0x000034F8 File Offset: 0x000016F8
	[Token(Token = "0x6000469")]
	[Address(RVA = "0x2F721D0", Offset = "0x2F721D0", VA = "0x2F721D0")]
	public static int IndexOfAny_NewLine(this ReadOnlySpan<char> value)
	{
		return 0;
	}

	// Token: 0x0600046A RID: 1130 RVA: 0x00003510 File Offset: 0x00001710
	[Token(Token = "0x600046A")]
	[Address(RVA = "0x2F72240", Offset = "0x2F72240", VA = "0x2F72240")]
	public static StringExtensions.LineSplitEnumerator SplitLines(this string str)
	{
		return default(StringExtensions.LineSplitEnumerator);
	}

	// Token: 0x0600046B RID: 1131 RVA: 0x00003528 File Offset: 0x00001728
	[Token(Token = "0x600046B")]
	[Address(RVA = "0x2F722BC", Offset = "0x2F722BC", VA = "0x2F722BC")]
	public static StringExtensions.LineSplitEnumerator SplitLines(this ReadOnlySpan<char> str)
	{
		return default(StringExtensions.LineSplitEnumerator);
	}

	// Token: 0x0600046C RID: 1132 RVA: 0x00003540 File Offset: 0x00001740
	[Token(Token = "0x600046C")]
	[Address(RVA = "0x2F722CC", Offset = "0x2F722CC", VA = "0x2F722CC")]
	public static StringExtensions.SegmentSplitEnumerator SplitSegments(this string str, char segment)
	{
		return default(StringExtensions.SegmentSplitEnumerator);
	}

	// Token: 0x0600046D RID: 1133 RVA: 0x00003558 File Offset: 0x00001758
	[Token(Token = "0x600046D")]
	[Address(RVA = "0x2F72374", Offset = "0x2F72374", VA = "0x2F72374")]
	public static StringExtensions.SegmentSplitEnumerator SplitSegments(this ReadOnlySpan<char> strSpan, char segment, bool removeEmpty = false)
	{
		return default(StringExtensions.SegmentSplitEnumerator);
	}

	// Token: 0x0600046E RID: 1134 RVA: 0x00003570 File Offset: 0x00001770
	[Token(Token = "0x600046E")]
	[Address(RVA = "0x2F72394", Offset = "0x2F72394", VA = "0x2F72394")]
	public static StringExtensions.StreamSplitEnumerator SplitLines(this StreamReader sr)
	{
		return default(StringExtensions.StreamSplitEnumerator);
	}

	// Token: 0x0600046F RID: 1135 RVA: 0x00003588 File Offset: 0x00001788
	[Token(Token = "0x600046F")]
	[Address(RVA = "0x2F7249C", Offset = "0x2F7249C", VA = "0x2F7249C")]
	public static StringExtensions.StreamSplitEnumerator SplitLines(this StreamReader sr, char[] contentBuffer)
	{
		return default(StringExtensions.StreamSplitEnumerator);
	}

	// Token: 0x06000470 RID: 1136 RVA: 0x000035A0 File Offset: 0x000017A0
	[Token(Token = "0x6000470")]
	[Address(RVA = "0x2F7250C", Offset = "0x2F7250C", VA = "0x2F7250C")]
	public static bool Split_to_spanspan(this string str, char ch, out ReadOnlySpan<char> span1, out ReadOnlySpan<char> span2)
	{
		return default(bool);
	}

	// Token: 0x06000471 RID: 1137 RVA: 0x000035B8 File Offset: 0x000017B8
	[Token(Token = "0x6000471")]
	[Address(RVA = "0x2F72588", Offset = "0x2F72588", VA = "0x2F72588")]
	public static bool Split_to_spanspan(this ReadOnlySpan<char> span, char ch, out ReadOnlySpan<char> span1, out ReadOnlySpan<char> span2)
	{
		return default(bool);
	}

	// Token: 0x06000472 RID: 1138 RVA: 0x000035D0 File Offset: 0x000017D0
	[Token(Token = "0x6000472")]
	[Address(RVA = "0x2F72704", Offset = "0x2F72704", VA = "0x2F72704")]
	public static bool Split_to_spans(this ReadOnlySpan<char> span, char ch, out ReadOnlySpan<char> span1, out ReadOnlySpan<char> span2, out ReadOnlySpan<char> span3)
	{
		return default(bool);
	}

	// Token: 0x06000473 RID: 1139 RVA: 0x000035E8 File Offset: 0x000017E8
	[Token(Token = "0x6000473")]
	[Address(RVA = "0x2F72748", Offset = "0x2F72748", VA = "0x2F72748")]
	public static bool Split_to_spans(this ReadOnlySpan<char> span, char ch, out ReadOnlySpan<char> span1, out ReadOnlySpan<char> span2, out ReadOnlySpan<char> span3, out ReadOnlySpan<char> span4)
	{
		return default(bool);
	}

	// Token: 0x06000474 RID: 1140 RVA: 0x00003600 File Offset: 0x00001800
	[Token(Token = "0x6000474")]
	[Address(RVA = "0x2F727AC", Offset = "0x2F727AC", VA = "0x2F727AC")]
	public static bool Split_to_spans(this ReadOnlySpan<char> span, char ch, out ReadOnlySpan<char> span1, out ReadOnlySpan<char> span2, out ReadOnlySpan<char> span3, out ReadOnlySpan<char> span4, out ReadOnlySpan<char> span5)
	{
		return default(bool);
	}

	// Token: 0x06000475 RID: 1141 RVA: 0x00003618 File Offset: 0x00001818
	[Token(Token = "0x6000475")]
	[Address(RVA = "0x2F72828", Offset = "0x2F72828", VA = "0x2F72828")]
	public static bool Split_to_spans(this ReadOnlySpan<char> span, char ch, out ReadOnlySpan<char> span1, out ReadOnlySpan<char> span2, out ReadOnlySpan<char> span3, out ReadOnlySpan<char> span4, out ReadOnlySpan<char> span5, out ReadOnlySpan<char> span6)
	{
		return default(bool);
	}

	// Token: 0x06000476 RID: 1142 RVA: 0x00003630 File Offset: 0x00001830
	[Token(Token = "0x6000476")]
	[Address(RVA = "0x2F728C4", Offset = "0x2F728C4", VA = "0x2F728C4")]
	public static bool Split_to_spans(this ReadOnlySpan<char> span, char ch, out ReadOnlySpan<char> span1, out ReadOnlySpan<char> span2, out ReadOnlySpan<char> span3, out ReadOnlySpan<char> span4, out ReadOnlySpan<char> span5, out ReadOnlySpan<char> span6, out ReadOnlySpan<char> span7)
	{
		return default(bool);
	}

	// Token: 0x06000477 RID: 1143 RVA: 0x00003648 File Offset: 0x00001848
	[Token(Token = "0x6000477")]
	[Address(RVA = "0x2F72974", Offset = "0x2F72974", VA = "0x2F72974")]
	public static bool Split_to_ii(this string str, char ch, out int k, out int v)
	{
		return default(bool);
	}

	// Token: 0x06000478 RID: 1144 RVA: 0x00003660 File Offset: 0x00001860
	[Token(Token = "0x6000478")]
	[Address(RVA = "0x2F729F0", Offset = "0x2F729F0", VA = "0x2F729F0")]
	public static bool Split_to_ii(this ReadOnlySpan<char> span, char ch, out int k, out int v)
	{
		return default(bool);
	}

	// Token: 0x06000479 RID: 1145 RVA: 0x00003678 File Offset: 0x00001878
	[Token(Token = "0x6000479")]
	[Address(RVA = "0x2F72C48", Offset = "0x2F72C48", VA = "0x2F72C48")]
	public static int IndexOf(this ReadOnlySpan<char> span, char value, int startIndex)
	{
		return 0;
	}

	// Token: 0x0600047A RID: 1146 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600047A")]
	[Address(RVA = "0x2F72D28", Offset = "0x2F72D28", VA = "0x2F72D28")]
	public static int[] Split_to_IntArray(this ReadOnlySpan<char> str, char ch, bool removeEmpty = true, int defInt = 0)
	{
		return null;
	}

	// Token: 0x0600047B RID: 1147 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600047B")]
	[Address(RVA = "0x2F730D4", Offset = "0x2F730D4", VA = "0x2F730D4")]
	public static int[] Split_to_IntArrayEx(this ReadOnlySpan<char> str, char ch, bool removeEmpty = true, int defInt = 0)
	{
		return null;
	}

	// Token: 0x020000C1 RID: 193
	[Token(Token = "0x20000C1")]
	[Obsolete("Types with embedded references are not supported in this version of your compiler.", true)]
	public ref struct LineSplitEnumerator
	{
		// Token: 0x0600047C RID: 1148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600047C")]
		[Address(RVA = "0x2F722AC", Offset = "0x2F722AC", VA = "0x2F722AC")]
		public LineSplitEnumerator(ReadOnlySpan<char> str)
		{
		}

		// Token: 0x0600047D RID: 1149 RVA: 0x00003690 File Offset: 0x00001890
		[Token(Token = "0x600047D")]
		[Address(RVA = "0x2F73680", Offset = "0x2F73680", VA = "0x2F73680")]
		public StringExtensions.LineSplitEnumerator GetEnumerator()
		{
			return default(StringExtensions.LineSplitEnumerator);
		}

		// Token: 0x0600047E RID: 1150 RVA: 0x000036A8 File Offset: 0x000018A8
		[Token(Token = "0x600047E")]
		[Address(RVA = "0x2F73694", Offset = "0x2F73694", VA = "0x2F73694")]
		public bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x0600047F RID: 1151 RVA: 0x000036C0 File Offset: 0x000018C0
		// (set) Token: 0x06000480 RID: 1152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700009B")]
		public StringExtensions.LineSplitEntry Current
		{
			[Token(Token = "0x600047F")]
			[Address(RVA = "0x2F738E4", Offset = "0x2F738E4", VA = "0x2F738E4")]
			[CompilerGenerated]
			readonly get
			{
				return default(StringExtensions.LineSplitEntry);
			}
			[Token(Token = "0x6000480")]
			[Address(RVA = "0x2F738F0", Offset = "0x2F738F0", VA = "0x2F738F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0400043C RID: 1084
		[Token(Token = "0x400043C")]
		[FieldOffset(Offset = "0x0")]
		private ReadOnlySpan<char> _str;
	}

	// Token: 0x020000C2 RID: 194
	[Token(Token = "0x20000C2")]
	public readonly ref struct LineSplitEntry
	{
		// Token: 0x06000481 RID: 1153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000481")]
		[Address(RVA = "0x2F738D8", Offset = "0x2F738D8", VA = "0x2F738D8")]
		public LineSplitEntry(ReadOnlySpan<char> line, ReadOnlySpan<char> separator)
		{
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x06000482 RID: 1154 RVA: 0x000036D8 File Offset: 0x000018D8
		[Token(Token = "0x1700009C")]
		public ReadOnlySpan<char> Line
		{
			[Token(Token = "0x6000482")]
			[Address(RVA = "0x2F738FC", Offset = "0x2F738FC", VA = "0x2F738FC")]
			[CompilerGenerated]
			get
			{
				return default(ReadOnlySpan<char>);
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x06000483 RID: 1155 RVA: 0x000036F0 File Offset: 0x000018F0
		[Token(Token = "0x1700009D")]
		public ReadOnlySpan<char> Separator
		{
			[Token(Token = "0x6000483")]
			[Address(RVA = "0x2F73908", Offset = "0x2F73908", VA = "0x2F73908")]
			[CompilerGenerated]
			get
			{
				return default(ReadOnlySpan<char>);
			}
		}

		// Token: 0x06000484 RID: 1156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000484")]
		[Address(RVA = "0x2F73914", Offset = "0x2F73914", VA = "0x2F73914")]
		public void Deconstruct(out ReadOnlySpan<char> line, out ReadOnlySpan<char> separator)
		{
		}

		// Token: 0x06000485 RID: 1157 RVA: 0x00003708 File Offset: 0x00001908
		[Token(Token = "0x6000485")]
		[Address(RVA = "0x2F7347C", Offset = "0x2F7347C", VA = "0x2F7347C")]
		public static implicit operator ReadOnlySpan<char>(StringExtensions.LineSplitEntry entry)
		{
			return default(ReadOnlySpan<char>);
		}
	}

	// Token: 0x020000C3 RID: 195
	[Token(Token = "0x20000C3")]
	public ref struct SegmentSplitEnumerator
	{
		// Token: 0x06000486 RID: 1158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000486")]
		[Address(RVA = "0x2F72354", Offset = "0x2F72354", VA = "0x2F72354")]
		public SegmentSplitEnumerator(ReadOnlySpan<char> str, char segment, bool removeEmpty = false)
		{
		}

		// Token: 0x06000487 RID: 1159 RVA: 0x00003720 File Offset: 0x00001920
		[Token(Token = "0x6000487")]
		[Address(RVA = "0x2F73460", Offset = "0x2F73460", VA = "0x2F73460")]
		public StringExtensions.SegmentSplitEnumerator GetEnumerator()
		{
			return default(StringExtensions.SegmentSplitEnumerator);
		}

		// Token: 0x06000488 RID: 1160 RVA: 0x00003738 File Offset: 0x00001938
		[Token(Token = "0x6000488")]
		[Address(RVA = "0x2F73488", Offset = "0x2F73488", VA = "0x2F73488")]
		public bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x06000489 RID: 1161 RVA: 0x00003750 File Offset: 0x00001950
		// (set) Token: 0x0600048A RID: 1162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700009E")]
		public StringExtensions.LineSplitEntry Current
		{
			[Token(Token = "0x6000489")]
			[Address(RVA = "0x2F73928", Offset = "0x2F73928", VA = "0x2F73928")]
			[CompilerGenerated]
			readonly get
			{
				return default(StringExtensions.LineSplitEntry);
			}
			[Token(Token = "0x600048A")]
			[Address(RVA = "0x2F73938", Offset = "0x2F73938", VA = "0x2F73938")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x04000440 RID: 1088
		[Token(Token = "0x4000440")]
		[FieldOffset(Offset = "0x0")]
		private ReadOnlySpan<char> _str;

		// Token: 0x04000441 RID: 1089
		[Token(Token = "0x4000441")]
		[FieldOffset(Offset = "0x10")]
		private char _seg;

		// Token: 0x04000442 RID: 1090
		[Token(Token = "0x4000442")]
		[FieldOffset(Offset = "0x12")]
		private bool ShouldRemoveEmptyEntries;
	}

	// Token: 0x020000C4 RID: 196
	[Token(Token = "0x20000C4")]
	public ref struct StreamSplitEnumerator
	{
		// Token: 0x0600048B RID: 1163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600048B")]
		[Address(RVA = "0x2F72438", Offset = "0x2F72438", VA = "0x2F72438")]
		public StreamSplitEnumerator(StreamReader sr, char[] contentBuffer)
		{
		}

		// Token: 0x0600048C RID: 1164 RVA: 0x00003768 File Offset: 0x00001968
		[Token(Token = "0x600048C")]
		[Address(RVA = "0x2F73948", Offset = "0x2F73948", VA = "0x2F73948")]
		public StringExtensions.StreamSplitEnumerator GetEnumerator()
		{
			return default(StringExtensions.StreamSplitEnumerator);
		}

		// Token: 0x0600048D RID: 1165 RVA: 0x00003780 File Offset: 0x00001980
		[Token(Token = "0x600048D")]
		[Address(RVA = "0x2F7395C", Offset = "0x2F7395C", VA = "0x2F7395C")]
		public bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x0600048E RID: 1166 RVA: 0x00003798 File Offset: 0x00001998
		[Token(Token = "0x600048E")]
		[Address(RVA = "0x2F73BC8", Offset = "0x2F73BC8", VA = "0x2F73BC8")]
		private bool prepareBuffer()
		{
			return default(bool);
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x0600048F RID: 1167 RVA: 0x000037B0 File Offset: 0x000019B0
		// (set) Token: 0x06000490 RID: 1168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700009F")]
		public StringExtensions.LineSplitEntry Current
		{
			[Token(Token = "0x600048F")]
			[Address(RVA = "0x2F73E04", Offset = "0x2F73E04", VA = "0x2F73E04")]
			[CompilerGenerated]
			readonly get
			{
				return default(StringExtensions.LineSplitEntry);
			}
			[Token(Token = "0x6000490")]
			[Address(RVA = "0x2F73E10", Offset = "0x2F73E10", VA = "0x2F73E10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x04000444 RID: 1092
		[Token(Token = "0x4000444")]
		[FieldOffset(Offset = "0x0")]
		private StreamReader _sr;

		// Token: 0x04000445 RID: 1093
		[Token(Token = "0x4000445")]
		[FieldOffset(Offset = "0x8")]
		private char[] _buffer;

		// Token: 0x04000446 RID: 1094
		[Token(Token = "0x4000446")]
		[FieldOffset(Offset = "0x10")]
		private ReadOnlySpan<char> _str;
	}
}
