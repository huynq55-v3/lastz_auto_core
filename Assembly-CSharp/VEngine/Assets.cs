using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace VEngine
{
	// Token: 0x020009CC RID: 2508
	[Token(Token = "0x20009CC")]
	public class Assets
	{
		// Token: 0x0600600C RID: 24588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600600C")]
		[Address(RVA = "0x16E5F68", Offset = "0x16E5F68", VA = "0x16E5F68")]
		public void SetQueueSize(int size, bool autoMaxSize = true)
		{
		}

		// Token: 0x0600600D RID: 24589 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600600D")]
		[Address(RVA = "0x16E5FF4", Offset = "0x16E5FF4", VA = "0x16E5FF4")]
		public Asset Enqueue(string path, Type type, [Optional] Action<Asset> completed)
		{
			return null;
		}

		// Token: 0x0600600E RID: 24590 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600600E")]
		[Address(RVA = "0x16E60F0", Offset = "0x16E60F0", VA = "0x16E60F0")]
		public Asset Preload(string path, Type type, [Optional] Action<Asset> completed)
		{
			return null;
		}

		// Token: 0x0600600F RID: 24591 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600600F")]
		public T GetAsset<T>(string path) where T : Object
		{
			return null;
		}

		// Token: 0x06006010 RID: 24592 RVA: 0x0004B138 File Offset: 0x00049338
		[Token(Token = "0x6006010")]
		[Address(RVA = "0x16E6254", Offset = "0x16E6254", VA = "0x16E6254")]
		public float GetProgress()
		{
			return 0f;
		}

		// Token: 0x06006011 RID: 24593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006011")]
		[Address(RVA = "0x16E63D8", Offset = "0x16E63D8", VA = "0x16E63D8")]
		public void Clear()
		{
		}

		// Token: 0x06006012 RID: 24594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006012")]
		[Address(RVA = "0x16E66F8", Offset = "0x16E66F8", VA = "0x16E66F8")]
		public Assets()
		{
		}

		// Token: 0x04002521 RID: 9505
		[Token(Token = "0x4002521")]
		[FieldOffset(Offset = "0x10")]
		private readonly List<Asset> preload;

		// Token: 0x04002522 RID: 9506
		[Token(Token = "0x4002522")]
		[FieldOffset(Offset = "0x18")]
		private readonly Dictionary<string, Asset> cache;

		// Token: 0x04002523 RID: 9507
		[Token(Token = "0x4002523")]
		[FieldOffset(Offset = "0x20")]
		private readonly Queue<Asset> queue;

		// Token: 0x04002524 RID: 9508
		[Token(Token = "0x4002524")]
		[FieldOffset(Offset = "0x28")]
		private int queueSize;
	}
}
