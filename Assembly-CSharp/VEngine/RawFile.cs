using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Networking;

namespace VEngine
{
	// Token: 0x020009E0 RID: 2528
	[Token(Token = "0x20009E0")]
	public sealed class RawFile : Loadable
	{
		// Token: 0x17000611 RID: 1553
		// (get) Token: 0x060060D9 RID: 24793 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060060DA RID: 24794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000611")]
		public string savePath
		{
			[Token(Token = "0x60060D9")]
			[Address(RVA = "0x140A050", Offset = "0x140A050", VA = "0x140A050")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60060DA")]
			[Address(RVA = "0x140A058", Offset = "0x140A058", VA = "0x140A058")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000612 RID: 1554
		// (get) Token: 0x060060DB RID: 24795 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060060DC RID: 24796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000612")]
		public byte[] bytes
		{
			[Token(Token = "0x60060DB")]
			[Address(RVA = "0x140A060", Offset = "0x140A060", VA = "0x140A060")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60060DC")]
			[Address(RVA = "0x140A068", Offset = "0x140A068", VA = "0x140A068")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060060DD RID: 24797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060DD")]
		[Address(RVA = "0x140A070", Offset = "0x140A070", VA = "0x140A070", Slot = "6")]
		protected override void OnLoad()
		{
		}

		// Token: 0x060060DE RID: 24798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060DE")]
		[Address(RVA = "0x140A188", Offset = "0x140A188", VA = "0x140A188", Slot = "7")]
		protected override void OnUnload()
		{
		}

		// Token: 0x060060DF RID: 24799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060DF")]
		[Address(RVA = "0x140A1E4", Offset = "0x140A1E4", VA = "0x140A1E4", Slot = "8")]
		protected override void OnComplete()
		{
		}

		// Token: 0x060060E0 RID: 24800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060E0")]
		[Address(RVA = "0x140A2B8", Offset = "0x140A2B8", VA = "0x140A2B8", Slot = "5")]
		protected override void OnUpdate()
		{
		}

		// Token: 0x060060E1 RID: 24801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060E1")]
		[Address(RVA = "0x140A670", Offset = "0x140A670", VA = "0x140A670", Slot = "11")]
		protected override void OnUnused()
		{
		}

		// Token: 0x060060E2 RID: 24802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060E2")]
		[Address(RVA = "0x140A598", Offset = "0x140A598", VA = "0x140A598")]
		private void UpdateLoading()
		{
		}

		// Token: 0x060060E3 RID: 24803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060E3")]
		[Address(RVA = "0x140A2D8", Offset = "0x140A2D8", VA = "0x140A2D8")]
		private void UpdateChecking()
		{
		}

		// Token: 0x060060E4 RID: 24804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060E4")]
		[Address(RVA = "0x140A758", Offset = "0x140A758", VA = "0x140A758")]
		public static void UpdateFiles()
		{
		}

		// Token: 0x060060E5 RID: 24805 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60060E5")]
		[Address(RVA = "0x140A914", Offset = "0x140A914", VA = "0x140A914")]
		public static RawFile LoadAsync(string filename)
		{
			return null;
		}

		// Token: 0x060060E6 RID: 24806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060E6")]
		[Address(RVA = "0x140AA28", Offset = "0x140AA28", VA = "0x140AA28")]
		public RawFile()
		{
		}

		// Token: 0x0400257D RID: 9597
		[Token(Token = "0x400257D")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<string, RawFile> Cache;

		// Token: 0x0400257E RID: 9598
		[Token(Token = "0x400257E")]
		[FieldOffset(Offset = "0x8")]
		private static readonly List<RawFile> Unused;

		// Token: 0x0400257F RID: 9599
		[Token(Token = "0x400257F")]
		[FieldOffset(Offset = "0x40")]
		public Action<RawFile> completed;

		// Token: 0x04002580 RID: 9600
		[Token(Token = "0x4002580")]
		[FieldOffset(Offset = "0x48")]
		private BundleInfo info;

		// Token: 0x04002581 RID: 9601
		[Token(Token = "0x4002581")]
		[FieldOffset(Offset = "0x50")]
		public string name;

		// Token: 0x04002582 RID: 9602
		[Token(Token = "0x4002582")]
		[FieldOffset(Offset = "0x58")]
		private UnityWebRequest request;
	}
}
