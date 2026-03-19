using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Il2CppDummyDll;

namespace Google.Protobuf
{
	// Token: 0x02000AE8 RID: 2792
	[Token(Token = "0x2000AE8")]
	public sealed class ByteString : IEnumerable<byte>, IEnumerable, IEquatable<ByteString>
	{
		// Token: 0x06006A83 RID: 27267 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A83")]
		[Address(RVA = "0x349BE10", Offset = "0x349BE10", VA = "0x349BE10")]
		internal static ByteString AttachBytes(byte[] bytes)
		{
			return null;
		}

		// Token: 0x06006A84 RID: 27268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A84")]
		[Address(RVA = "0x349BE80", Offset = "0x349BE80", VA = "0x349BE80")]
		private ByteString(byte[] bytes)
		{
		}

		// Token: 0x170007A9 RID: 1961
		// (get) Token: 0x06006A85 RID: 27269 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007A9")]
		public static ByteString Empty
		{
			[Token(Token = "0x6006A85")]
			[Address(RVA = "0x349BEB0", Offset = "0x349BEB0", VA = "0x349BEB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170007AA RID: 1962
		// (get) Token: 0x06006A86 RID: 27270 RVA: 0x0004DAF0 File Offset: 0x0004BCF0
		[Token(Token = "0x170007AA")]
		public int Length
		{
			[Token(Token = "0x6006A86")]
			[Address(RVA = "0x349BF08", Offset = "0x349BF08", VA = "0x349BF08")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170007AB RID: 1963
		// (get) Token: 0x06006A87 RID: 27271 RVA: 0x0004DB08 File Offset: 0x0004BD08
		[Token(Token = "0x170007AB")]
		public bool IsEmpty
		{
			[Token(Token = "0x6006A87")]
			[Address(RVA = "0x349BF24", Offset = "0x349BF24", VA = "0x349BF24")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06006A88 RID: 27272 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A88")]
		[Address(RVA = "0x349BF48", Offset = "0x349BF48", VA = "0x349BF48")]
		public byte[] ToByteArray()
		{
			return null;
		}

		// Token: 0x06006A89 RID: 27273 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A89")]
		[Address(RVA = "0x349BFC0", Offset = "0x349BFC0", VA = "0x349BFC0")]
		public string ToBase64()
		{
			return null;
		}

		// Token: 0x06006A8A RID: 27274 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A8A")]
		[Address(RVA = "0x349C01C", Offset = "0x349C01C", VA = "0x349C01C")]
		public static ByteString FromBase64(string bytes)
		{
			return null;
		}

		// Token: 0x06006A8B RID: 27275 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A8B")]
		[Address(RVA = "0x349C13C", Offset = "0x349C13C", VA = "0x349C13C")]
		public static ByteString FromStream(Stream stream)
		{
			return null;
		}

		// Token: 0x06006A8C RID: 27276 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A8C")]
		[Address(RVA = "0x349C2FC", Offset = "0x349C2FC", VA = "0x349C2FC")]
		public static Task<ByteString> FromStreamAsync(Stream stream, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06006A8D RID: 27277 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A8D")]
		[Address(RVA = "0x349C424", Offset = "0x349C424", VA = "0x349C424")]
		public static ByteString CopyFrom(params byte[] bytes)
		{
			return null;
		}

		// Token: 0x06006A8E RID: 27278 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A8E")]
		[Address(RVA = "0x349C4F8", Offset = "0x349C4F8", VA = "0x349C4F8")]
		public static ByteString CopyFrom(byte[] bytes, int offset, int count)
		{
			return null;
		}

		// Token: 0x06006A8F RID: 27279 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A8F")]
		[Address(RVA = "0x349C5BC", Offset = "0x349C5BC", VA = "0x349C5BC")]
		public static ByteString CopyFrom(string text, Encoding encoding)
		{
			return null;
		}

		// Token: 0x06006A90 RID: 27280 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A90")]
		[Address(RVA = "0x349C654", Offset = "0x349C654", VA = "0x349C654")]
		public static ByteString CopyFromUtf8(string text)
		{
			return null;
		}

		// Token: 0x170007AC RID: 1964
		[Token(Token = "0x170007AC")]
		public byte this[int index]
		{
			[Token(Token = "0x6006A91")]
			[Address(RVA = "0x349C6BC", Offset = "0x349C6BC", VA = "0x349C6BC")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06006A92 RID: 27282 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A92")]
		[Address(RVA = "0x349C6EC", Offset = "0x349C6EC", VA = "0x349C6EC")]
		public string ToString(Encoding encoding)
		{
			return null;
		}

		// Token: 0x06006A93 RID: 27283 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A93")]
		[Address(RVA = "0x349C724", Offset = "0x349C724", VA = "0x349C724")]
		public string ToStringUtf8()
		{
			return null;
		}

		// Token: 0x06006A94 RID: 27284 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A94")]
		[Address(RVA = "0x349C744", Offset = "0x349C744", VA = "0x349C744", Slot = "4")]
		public IEnumerator<byte> GetEnumerator()
		{
			return null;
		}

		// Token: 0x06006A95 RID: 27285 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A95")]
		[Address(RVA = "0x349C7E4", Offset = "0x349C7E4", VA = "0x349C7E4", Slot = "5")]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}

		// Token: 0x06006A96 RID: 27286 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A96")]
		[Address(RVA = "0x349C7E8", Offset = "0x349C7E8", VA = "0x349C7E8")]
		public CodedInputStream CreateCodedInput()
		{
			return null;
		}

		// Token: 0x06006A97 RID: 27287 RVA: 0x0004DB38 File Offset: 0x0004BD38
		[Token(Token = "0x6006A97")]
		[Address(RVA = "0x349C8DC", Offset = "0x349C8DC", VA = "0x349C8DC")]
		public static bool operator ==(ByteString lhs, ByteString rhs)
		{
			return default(bool);
		}

		// Token: 0x06006A98 RID: 27288 RVA: 0x0004DB50 File Offset: 0x0004BD50
		[Token(Token = "0x6006A98")]
		[Address(RVA = "0x349C970", Offset = "0x349C970", VA = "0x349C970")]
		public static bool operator !=(ByteString lhs, ByteString rhs)
		{
			return default(bool);
		}

		// Token: 0x06006A99 RID: 27289 RVA: 0x0004DB68 File Offset: 0x0004BD68
		[Token(Token = "0x6006A99")]
		[Address(RVA = "0x349C9E0", Offset = "0x349C9E0", VA = "0x349C9E0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06006A9A RID: 27290 RVA: 0x0004DB80 File Offset: 0x0004BD80
		[Token(Token = "0x6006A9A")]
		[Address(RVA = "0x349CA60", Offset = "0x349CA60", VA = "0x349CA60", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06006A9B RID: 27291 RVA: 0x0004DB98 File Offset: 0x0004BD98
		[Token(Token = "0x6006A9B")]
		[Address(RVA = "0x349CAC8", Offset = "0x349CAC8", VA = "0x349CAC8", Slot = "6")]
		public bool Equals(ByteString other)
		{
			return default(bool);
		}

		// Token: 0x06006A9C RID: 27292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A9C")]
		[Address(RVA = "0x349CB2C", Offset = "0x349CB2C", VA = "0x349CB2C")]
		internal void WriteRawBytesTo(CodedOutputStream outputStream)
		{
		}

		// Token: 0x06006A9D RID: 27293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A9D")]
		[Address(RVA = "0x349CB5C", Offset = "0x349CB5C", VA = "0x349CB5C")]
		public void CopyTo(byte[] array, int position)
		{
		}

		// Token: 0x06006A9E RID: 27294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A9E")]
		[Address(RVA = "0x349CB84", Offset = "0x349CB84", VA = "0x349CB84")]
		public void WriteTo(Stream outputStream)
		{
		}

		// Token: 0x04002AFA RID: 11002
		[Token(Token = "0x4002AFA")]
		[FieldOffset(Offset = "0x0")]
		private static readonly ByteString empty;

		// Token: 0x04002AFB RID: 11003
		[Token(Token = "0x4002AFB")]
		[FieldOffset(Offset = "0x10")]
		private readonly byte[] bytes;

		// Token: 0x02000AE9 RID: 2793
		[Token(Token = "0x2000AE9")]
		internal static class Unsafe
		{
			// Token: 0x06006AA0 RID: 27296 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006AA0")]
			[Address(RVA = "0x349CC64", Offset = "0x349CC64", VA = "0x349CC64")]
			internal static ByteString FromBytes(byte[] bytes)
			{
				return null;
			}
		}
	}
}
