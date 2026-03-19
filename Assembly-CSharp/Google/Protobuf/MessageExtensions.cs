using System;
using System.IO;
using Il2CppDummyDll;

namespace Google.Protobuf
{
	// Token: 0x02000B26 RID: 2854
	[Token(Token = "0x2000B26")]
	public static class MessageExtensions
	{
		// Token: 0x06006CDB RID: 27867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CDB")]
		[Address(RVA = "0x36EF828", Offset = "0x36EF828", VA = "0x36EF828")]
		public static void MergeFrom(this IMessage message, byte[] data)
		{
		}

		// Token: 0x06006CDC RID: 27868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CDC")]
		[Address(RVA = "0x36EF9C4", Offset = "0x36EF9C4", VA = "0x36EF9C4")]
		public static void MergeFrom(this IMessage message, byte[] data, int offset, int length)
		{
		}

		// Token: 0x06006CDD RID: 27869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CDD")]
		[Address(RVA = "0x36DD0B0", Offset = "0x36DD0B0", VA = "0x36DD0B0")]
		public static void MergeFrom(this IMessage message, ByteString data)
		{
		}

		// Token: 0x06006CDE RID: 27870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CDE")]
		[Address(RVA = "0x36EFCDC", Offset = "0x36EFCDC", VA = "0x36EFCDC")]
		public static void MergeFrom(this IMessage message, Stream input)
		{
		}

		// Token: 0x06006CDF RID: 27871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CDF")]
		[Address(RVA = "0x36EFE78", Offset = "0x36EFE78", VA = "0x36EFE78")]
		public static void MergeDelimitedFrom(this IMessage message, Stream input)
		{
		}

		// Token: 0x06006CE0 RID: 27872 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CE0")]
		[Address(RVA = "0x36EFFA4", Offset = "0x36EFFA4", VA = "0x36EFFA4")]
		public static byte[] ToByteArray(this IMessage message)
		{
			return null;
		}

		// Token: 0x06006CE1 RID: 27873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CE1")]
		[Address(RVA = "0x36F014C", Offset = "0x36F014C", VA = "0x36F014C")]
		public static void WriteTo(this IMessage message, Stream output)
		{
		}

		// Token: 0x06006CE2 RID: 27874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CE2")]
		[Address(RVA = "0x36F02D0", Offset = "0x36F02D0", VA = "0x36F02D0")]
		public static void WriteDelimitedTo(this IMessage message, Stream output)
		{
		}

		// Token: 0x06006CE3 RID: 27875 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CE3")]
		[Address(RVA = "0x36DD008", Offset = "0x36DD008", VA = "0x36DD008")]
		public static ByteString ToByteString(this IMessage message)
		{
			return null;
		}

		// Token: 0x06006CE4 RID: 27876 RVA: 0x0004EAC8 File Offset: 0x0004CCC8
		[Token(Token = "0x6006CE4")]
		[Address(RVA = "0x36F04BC", Offset = "0x36F04BC", VA = "0x36F04BC")]
		public static bool IsInitialized(this IMessage message)
		{
			return default(bool);
		}

		// Token: 0x06006CE5 RID: 27877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CE5")]
		[Address(RVA = "0x36EF834", Offset = "0x36EF834", VA = "0x36EF834")]
		internal static void MergeFrom(this IMessage message, byte[] data, bool discardUnknownFields, ExtensionRegistry registry)
		{
		}

		// Token: 0x06006CE6 RID: 27878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CE6")]
		[Address(RVA = "0x36EF9D0", Offset = "0x36EF9D0", VA = "0x36EF9D0")]
		internal static void MergeFrom(this IMessage message, byte[] data, int offset, int length, bool discardUnknownFields, ExtensionRegistry registry)
		{
		}

		// Token: 0x06006CE7 RID: 27879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CE7")]
		[Address(RVA = "0x36EFB70", Offset = "0x36EFB70", VA = "0x36EFB70")]
		internal static void MergeFrom(this IMessage message, ByteString data, bool discardUnknownFields, ExtensionRegistry registry)
		{
		}

		// Token: 0x06006CE8 RID: 27880 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CE8")]
		[Address(RVA = "0x36EFCE8", Offset = "0x36EFCE8", VA = "0x36EFCE8")]
		internal static void MergeFrom(this IMessage message, Stream input, bool discardUnknownFields, ExtensionRegistry registry)
		{
		}

		// Token: 0x06006CE9 RID: 27881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CE9")]
		[Address(RVA = "0x36EFE84", Offset = "0x36EFE84", VA = "0x36EFE84")]
		internal static void MergeDelimitedFrom(this IMessage message, Stream input, bool discardUnknownFields, ExtensionRegistry registry)
		{
		}
	}
}
