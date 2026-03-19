using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Security;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using Il2CppDummyDll;
using UnityEngine;

namespace VEngine
{
	// Token: 0x020009CD RID: 2509
	[Token(Token = "0x20009CD")]
	public class Download : CustomYieldInstruction
	{
		// Token: 0x06006013 RID: 24595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006013")]
		[Address(RVA = "0x13FD864", Offset = "0x13FD864", VA = "0x13FD864")]
		private Download()
		{
		}

		// Token: 0x170005F2 RID: 1522
		// (get) Token: 0x06006014 RID: 24596 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006015 RID: 24597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005F2")]
		public DownloadInfo info
		{
			[Token(Token = "0x6006014")]
			[Address(RVA = "0x13FD90C", Offset = "0x13FD90C", VA = "0x13FD90C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006015")]
			[Address(RVA = "0x13FD914", Offset = "0x13FD914", VA = "0x13FD914")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170005F3 RID: 1523
		// (get) Token: 0x06006016 RID: 24598 RVA: 0x0004B150 File Offset: 0x00049350
		// (set) Token: 0x06006017 RID: 24599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005F3")]
		public DownloadStatus status
		{
			[Token(Token = "0x6006016")]
			[Address(RVA = "0x13FD91C", Offset = "0x13FD91C", VA = "0x13FD91C")]
			[CompilerGenerated]
			get
			{
				return DownloadStatus.Wait;
			}
			[Token(Token = "0x6006017")]
			[Address(RVA = "0x13FD924", Offset = "0x13FD924", VA = "0x13FD924")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170005F4 RID: 1524
		// (get) Token: 0x06006018 RID: 24600 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006019 RID: 24601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005F4")]
		public string error
		{
			[Token(Token = "0x6006018")]
			[Address(RVA = "0x13FD92C", Offset = "0x13FD92C", VA = "0x13FD92C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006019")]
			[Address(RVA = "0x13FD934", Offset = "0x13FD934", VA = "0x13FD934")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170005F5 RID: 1525
		// (get) Token: 0x0600601A RID: 24602 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600601B RID: 24603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005F5")]
		public Action<Download> completed
		{
			[Token(Token = "0x600601A")]
			[Address(RVA = "0x13FD93C", Offset = "0x13FD93C", VA = "0x13FD93C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600601B")]
			[Address(RVA = "0x13FD944", Offset = "0x13FD944", VA = "0x13FD944")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170005F6 RID: 1526
		// (get) Token: 0x0600601C RID: 24604 RVA: 0x0004B168 File Offset: 0x00049368
		[Token(Token = "0x170005F6")]
		public bool isDone
		{
			[Token(Token = "0x600601C")]
			[Address(RVA = "0x13FD94C", Offset = "0x13FD94C", VA = "0x13FD94C")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170005F7 RID: 1527
		// (get) Token: 0x0600601D RID: 24605 RVA: 0x0004B180 File Offset: 0x00049380
		[Token(Token = "0x170005F7")]
		public bool isRetry
		{
			[Token(Token = "0x600601D")]
			[Address(RVA = "0x13FD960", Offset = "0x13FD960", VA = "0x13FD960")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170005F8 RID: 1528
		// (get) Token: 0x0600601E RID: 24606 RVA: 0x0004B198 File Offset: 0x00049398
		// (set) Token: 0x0600601F RID: 24607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005F8")]
		public float createTime
		{
			[Token(Token = "0x600601E")]
			[Address(RVA = "0x13FD970", Offset = "0x13FD970", VA = "0x13FD970")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600601F")]
			[Address(RVA = "0x13FD978", Offset = "0x13FD978", VA = "0x13FD978")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170005F9 RID: 1529
		// (get) Token: 0x06006020 RID: 24608 RVA: 0x0004B1B0 File Offset: 0x000493B0
		[Token(Token = "0x170005F9")]
		public float progress
		{
			[Token(Token = "0x6006020")]
			[Address(RVA = "0x13FD980", Offset = "0x13FD980", VA = "0x13FD980")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170005FA RID: 1530
		// (get) Token: 0x06006021 RID: 24609 RVA: 0x0004B1C8 File Offset: 0x000493C8
		// (set) Token: 0x06006022 RID: 24610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005FA")]
		public ulong downloadedBytes
		{
			[Token(Token = "0x6006021")]
			[Address(RVA = "0x13FD9B4", Offset = "0x13FD9B4", VA = "0x13FD9B4")]
			[CompilerGenerated]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6006022")]
			[Address(RVA = "0x13FD9BC", Offset = "0x13FD9BC", VA = "0x13FD9BC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170005FB RID: 1531
		// (get) Token: 0x06006023 RID: 24611 RVA: 0x0004B1E0 File Offset: 0x000493E0
		[Token(Token = "0x170005FB")]
		public override bool keepWaiting
		{
			[Token(Token = "0x6006023")]
			[Address(RVA = "0x13FD9C4", Offset = "0x13FD9C4", VA = "0x13FD9C4", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170005FC RID: 1532
		// (get) Token: 0x06006024 RID: 24612 RVA: 0x0004B1F8 File Offset: 0x000493F8
		[Token(Token = "0x170005FC")]
		public static ulong TotalDownloadedBytes
		{
			[Token(Token = "0x6006024")]
			[Address(RVA = "0x13FD9D8", Offset = "0x13FD9D8", VA = "0x13FD9D8")]
			get
			{
				return 0UL;
			}
		}

		// Token: 0x170005FD RID: 1533
		// (get) Token: 0x06006025 RID: 24613 RVA: 0x0004B210 File Offset: 0x00049410
		// (set) Token: 0x06006026 RID: 24614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005FD")]
		public static ulong TotalBandwidth
		{
			[Token(Token = "0x6006025")]
			[Address(RVA = "0x13FDB60", Offset = "0x13FDB60", VA = "0x13FDB60")]
			[CompilerGenerated]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6006026")]
			[Address(RVA = "0x13FDBB8", Offset = "0x13FDBB8", VA = "0x13FDBB8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06006027 RID: 24615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006027")]
		[Address(RVA = "0x13FDC14", Offset = "0x13FDC14", VA = "0x13FDC14")]
		public static void ClearAllDownloads()
		{
		}

		// Token: 0x06006028 RID: 24616 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006028")]
		[Address(RVA = "0x13FDEA4", Offset = "0x13FDEA4", VA = "0x13FDEA4")]
		public static Download DownloadAsync(string url, string savePath, [Optional] Action<Download> completed, ulong size = 0UL, uint crc = 0U, int resMode = 0)
		{
			return null;
		}

		// Token: 0x06006029 RID: 24617 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006029")]
		[Address(RVA = "0x13FDF94", Offset = "0x13FDF94", VA = "0x13FDF94")]
		public static Download DownloadAsync(DownloadInfo info, [Optional] Action<Download> completed, bool highPriority = false)
		{
			return null;
		}

		// Token: 0x0600602A RID: 24618 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600602A")]
		[Address(RVA = "0x13FE30C", Offset = "0x13FE30C", VA = "0x13FE30C")]
		public static List<Download> DownloadGroupWithHighestPriority(DownloadInfo[] downloadInfos)
		{
			return null;
		}

		// Token: 0x0600602B RID: 24619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600602B")]
		[Address(RVA = "0x13FEA34", Offset = "0x13FEA34", VA = "0x13FEA34")]
		public static void UpdateDownloads()
		{
		}

		// Token: 0x0600602C RID: 24620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600602C")]
		[Address(RVA = "0x13FF174", Offset = "0x13FF174", VA = "0x13FF174")]
		public void Retry()
		{
		}

		// Token: 0x0600602D RID: 24621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600602D")]
		[Address(RVA = "0x13FF17C", Offset = "0x13FF17C", VA = "0x13FF17C")]
		public void UnPause()
		{
		}

		// Token: 0x0600602E RID: 24622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600602E")]
		[Address(RVA = "0x13FF184", Offset = "0x13FF184", VA = "0x13FF184")]
		public void Pause()
		{
		}

		// Token: 0x0600602F RID: 24623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600602F")]
		[Address(RVA = "0x13FDE4C", Offset = "0x13FDE4C", VA = "0x13FDE4C")]
		public void Cancel()
		{
		}

		// Token: 0x06006030 RID: 24624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006030")]
		[Address(RVA = "0x13FF120", Offset = "0x13FF120", VA = "0x13FF120")]
		private void Complete()
		{
		}

		// Token: 0x06006031 RID: 24625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006031")]
		[Address(RVA = "0x13FF410", Offset = "0x13FF410", VA = "0x13FF410")]
		private void Run()
		{
		}

		// Token: 0x06006032 RID: 24626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006032")]
		[Address(RVA = "0x13FF18C", Offset = "0x13FF18C", VA = "0x13FF18C")]
		private void CheckStatus()
		{
		}

		// Token: 0x06006033 RID: 24627 RVA: 0x0004B228 File Offset: 0x00049428
		[Token(Token = "0x6006033")]
		[Address(RVA = "0x13FFC78", Offset = "0x13FFC78", VA = "0x13FFC78")]
		private static bool CheckValidationResult(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors spe)
		{
			return default(bool);
		}

		// Token: 0x06006034 RID: 24628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006034")]
		[Address(RVA = "0x13FF5FC", Offset = "0x13FF5FC", VA = "0x13FF5FC")]
		private void Downloading()
		{
		}

		// Token: 0x06006035 RID: 24629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006035")]
		[Address(RVA = "0x13FFE40", Offset = "0x13FFE40", VA = "0x13FFE40")]
		private void UpdateBandwidth(ref DateTime startTime)
		{
		}

		// Token: 0x06006036 RID: 24630 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006036")]
		[Address(RVA = "0x13FFC80", Offset = "0x13FFC80", VA = "0x13FFC80")]
		private WebRequest CreateWebRequest()
		{
			return null;
		}

		// Token: 0x06006037 RID: 24631 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006037")]
		[Address(RVA = "0x14000A4", Offset = "0x14000A4", VA = "0x14000A4")]
		private WebRequest GetHttpWebRequest()
		{
			return null;
		}

		// Token: 0x06006038 RID: 24632 RVA: 0x0004B240 File Offset: 0x00049440
		[Token(Token = "0x6006038")]
		[Address(RVA = "0x13FFD64", Offset = "0x13FFD64", VA = "0x13FFD64")]
		private bool ReadToEnd(Stream reader)
		{
			return default(bool);
		}

		// Token: 0x06006039 RID: 24633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006039")]
		[Address(RVA = "0x13FEF18", Offset = "0x13FEF18", VA = "0x13FEF18")]
		private void Start()
		{
		}

		// Token: 0x04002525 RID: 9509
		[Token(Token = "0x4002525")]
		[FieldOffset(Offset = "0x0")]
		public static uint MaxDownloads;

		// Token: 0x04002526 RID: 9510
		[Token(Token = "0x4002526")]
		[FieldOffset(Offset = "0x8")]
		public static ulong MaxBandwidth;

		// Token: 0x04002527 RID: 9511
		[Token(Token = "0x4002527")]
		[FieldOffset(Offset = "0x10")]
		public static int MaxRetryTimes;

		// Token: 0x04002528 RID: 9512
		[Token(Token = "0x4002528")]
		[FieldOffset(Offset = "0x14")]
		public static uint ReadBufferSize;

		// Token: 0x04002529 RID: 9513
		[Token(Token = "0x4002529")]
		[FieldOffset(Offset = "0x18")]
		public static readonly List<Download> Prepared;

		// Token: 0x0400252A RID: 9514
		[Token(Token = "0x400252A")]
		[FieldOffset(Offset = "0x20")]
		public static readonly List<Download> Progressing;

		// Token: 0x0400252B RID: 9515
		[Token(Token = "0x400252B")]
		[FieldOffset(Offset = "0x28")]
		public static readonly Dictionary<string, Download> Cache;

		// Token: 0x0400252C RID: 9516
		[Token(Token = "0x400252C")]
		[FieldOffset(Offset = "0x30")]
		private static float lastSampleTime;

		// Token: 0x0400252D RID: 9517
		[Token(Token = "0x400252D")]
		[FieldOffset(Offset = "0x38")]
		private static ulong lastTotalDownloadedBytes;

		// Token: 0x0400252E RID: 9518
		[Token(Token = "0x400252E")]
		[FieldOffset(Offset = "0x10")]
		private readonly byte[] _readBuffer;

		// Token: 0x0400252F RID: 9519
		[Token(Token = "0x400252F")]
		[FieldOffset(Offset = "0x18")]
		private ulong _bandWidth;

		// Token: 0x04002530 RID: 9520
		[Token(Token = "0x4002530")]
		[FieldOffset(Offset = "0x20")]
		private Thread _thread;

		// Token: 0x04002531 RID: 9521
		[Token(Token = "0x4002531")]
		[FieldOffset(Offset = "0x28")]
		private int retryTimes;

		// Token: 0x04002532 RID: 9522
		[Token(Token = "0x4002532")]
		[FieldOffset(Offset = "0x30")]
		private FileStream writer;
	}
}
