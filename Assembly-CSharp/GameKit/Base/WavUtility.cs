using System;
using System.IO;
using Il2CppDummyDll;
using UnityEngine;

namespace GameKit.Base
{
	// Token: 0x020004ED RID: 1261
	[Token(Token = "0x20004ED")]
	public class WavUtility
	{
		// Token: 0x06002629 RID: 9769 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002629")]
		[Address(RVA = "0x2B5C7F8", Offset = "0x2B5C7F8", VA = "0x2B5C7F8")]
		public static AudioClip ToAudioClip(string filePath)
		{
			return null;
		}

		// Token: 0x0600262A RID: 9770 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600262A")]
		[Address(RVA = "0x2B5C8DC", Offset = "0x2B5C8DC", VA = "0x2B5C8DC")]
		public static AudioClip ToAudioClip(byte[] fileBytes, int offsetSamples = 0, string name = "wav")
		{
			return null;
		}

		// Token: 0x0600262B RID: 9771 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600262B")]
		[Address(RVA = "0x2B5CBF8", Offset = "0x2B5CBF8", VA = "0x2B5CBF8")]
		private static float[] Convert8BitByteArrayToAudioClipData(byte[] source, int headerOffset, int dataSize)
		{
			return null;
		}

		// Token: 0x0600262C RID: 9772 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600262C")]
		[Address(RVA = "0x2B5CCF0", Offset = "0x2B5CCF0", VA = "0x2B5CCF0")]
		private static float[] Convert16BitByteArrayToAudioClipData(byte[] source, int headerOffset, int dataSize)
		{
			return null;
		}

		// Token: 0x0600262D RID: 9773 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600262D")]
		[Address(RVA = "0x2B5CE18", Offset = "0x2B5CE18", VA = "0x2B5CE18")]
		private static float[] Convert24BitByteArrayToAudioClipData(byte[] source, int headerOffset, int dataSize)
		{
			return null;
		}

		// Token: 0x0600262E RID: 9774 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600262E")]
		[Address(RVA = "0x2B5CF90", Offset = "0x2B5CF90", VA = "0x2B5CF90")]
		private static float[] Convert32BitByteArrayToAudioClipData(byte[] source, int headerOffset, int dataSize)
		{
			return null;
		}

		// Token: 0x0600262F RID: 9775 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600262F")]
		[Address(RVA = "0x2B5D0B8", Offset = "0x2B5D0B8", VA = "0x2B5D0B8")]
		public static byte[] FromAudioClip(AudioClip audioClip)
		{
			return null;
		}

		// Token: 0x06002630 RID: 9776 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002630")]
		[Address(RVA = "0x2B5D118", Offset = "0x2B5D118", VA = "0x2B5D118")]
		public static byte[] FromAudioClip(AudioClip audioClip, out string filepath, bool saveAsFile = true, string dirname = "recordings")
		{
			return null;
		}

		// Token: 0x06002631 RID: 9777 RVA: 0x0000E6D0 File Offset: 0x0000C8D0
		[Token(Token = "0x6002631")]
		[Address(RVA = "0x2B5D44C", Offset = "0x2B5D44C", VA = "0x2B5D44C")]
		private static int WriteFileHeader(ref MemoryStream stream, int fileSize)
		{
			return 0;
		}

		// Token: 0x06002632 RID: 9778 RVA: 0x0000E6E8 File Offset: 0x0000C8E8
		[Token(Token = "0x6002632")]
		[Address(RVA = "0x2B5D57C", Offset = "0x2B5D57C", VA = "0x2B5D57C")]
		private static int WriteFileFormat(ref MemoryStream stream, int channels, int sampleRate, ushort bitDepth)
		{
			return 0;
		}

		// Token: 0x06002633 RID: 9779 RVA: 0x0000E700 File Offset: 0x0000C900
		[Token(Token = "0x6002633")]
		[Address(RVA = "0x2B5D7B8", Offset = "0x2B5D7B8", VA = "0x2B5D7B8")]
		private static int WriteFileData(ref MemoryStream stream, AudioClip audioClip, ushort bitDepth)
		{
			return 0;
		}

		// Token: 0x06002634 RID: 9780 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002634")]
		[Address(RVA = "0x2B5D9B0", Offset = "0x2B5D9B0", VA = "0x2B5D9B0")]
		private static byte[] ConvertAudioClipDataToInt16ByteArray(float[] data)
		{
			return null;
		}

		// Token: 0x06002635 RID: 9781 RVA: 0x0000E718 File Offset: 0x0000C918
		[Token(Token = "0x6002635")]
		[Address(RVA = "0x2B5D96C", Offset = "0x2B5D96C", VA = "0x2B5D96C")]
		private static int WriteBytesToMemoryStream(ref MemoryStream stream, byte[] bytes, string tag = "")
		{
			return 0;
		}

		// Token: 0x06002636 RID: 9782 RVA: 0x0000E730 File Offset: 0x0000C930
		[Token(Token = "0x6002636")]
		[Address(RVA = "0x2B5DB18", Offset = "0x2B5DB18", VA = "0x2B5DB18")]
		public static ushort BitDepth(AudioClip audioClip)
		{
			return 0;
		}

		// Token: 0x06002637 RID: 9783 RVA: 0x0000E748 File Offset: 0x0000C948
		[Token(Token = "0x6002637")]
		[Address(RVA = "0x2B5D9A8", Offset = "0x2B5D9A8", VA = "0x2B5D9A8")]
		private static int BytesPerSample(ushort bitDepth)
		{
			return 0;
		}

		// Token: 0x06002638 RID: 9784 RVA: 0x0000E760 File Offset: 0x0000C960
		[Token(Token = "0x6002638")]
		[Address(RVA = "0x2B5DBDC", Offset = "0x2B5DBDC", VA = "0x2B5DBDC")]
		private static int BlockSize(ushort bitDepth)
		{
			return 0;
		}

		// Token: 0x06002639 RID: 9785 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002639")]
		[Address(RVA = "0x2B5CAD8", Offset = "0x2B5CAD8", VA = "0x2B5CAD8")]
		private static string FormatCode(ushort code)
		{
			return null;
		}

		// Token: 0x0600263A RID: 9786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600263A")]
		[Address(RVA = "0x2B5DC94", Offset = "0x2B5DC94", VA = "0x2B5DC94")]
		public WavUtility()
		{
		}

		// Token: 0x0400228F RID: 8847
		[Token(Token = "0x400228F")]
		private const int BlockSize_16Bit = 2;
	}
}
