using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Networking;
using UnityEngine.Scripting;

namespace Main.Scripts.Application.LoadingState
{
	// Token: 0x0200050B RID: 1291
	[Token(Token = "0x200050B")]
	[Preserve]
	public class HttpRequest
	{
		// Token: 0x170005D0 RID: 1488
		// (get) Token: 0x060026F3 RID: 9971 RVA: 0x0000EB08 File Offset: 0x0000CD08
		// (set) Token: 0x060026F4 RID: 9972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005D0")]
		public float Timeout
		{
			[Token(Token = "0x60026F3")]
			[Address(RVA = "0x2B669B4", Offset = "0x2B669B4", VA = "0x2B669B4")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60026F4")]
			[Address(RVA = "0x2B669BC", Offset = "0x2B669BC", VA = "0x2B669BC")]
			set
			{
			}
		}

		// Token: 0x170005D1 RID: 1489
		// (get) Token: 0x060026F5 RID: 9973 RVA: 0x0000EB20 File Offset: 0x0000CD20
		// (set) Token: 0x060026F6 RID: 9974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005D1")]
		public int TryCount
		{
			[Token(Token = "0x60026F5")]
			[Address(RVA = "0x2B669C4", Offset = "0x2B669C4", VA = "0x2B669C4")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60026F6")]
			[Address(RVA = "0x2B669CC", Offset = "0x2B669CC", VA = "0x2B669CC")]
			set
			{
			}
		}

		// Token: 0x170005D2 RID: 1490
		// (get) Token: 0x060026F7 RID: 9975 RVA: 0x0000EB38 File Offset: 0x0000CD38
		[Token(Token = "0x170005D2")]
		public bool isDone
		{
			[Token(Token = "0x60026F7")]
			[Address(RVA = "0x2B669D4", Offset = "0x2B669D4", VA = "0x2B669D4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170005D3 RID: 1491
		// (get) Token: 0x060026F8 RID: 9976 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005D3")]
		public string error
		{
			[Token(Token = "0x60026F8")]
			[Address(RVA = "0x2B669DC", Offset = "0x2B669DC", VA = "0x2B669DC")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005D4 RID: 1492
		// (get) Token: 0x060026F9 RID: 9977 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005D4")]
		public byte[] data
		{
			[Token(Token = "0x60026F9")]
			[Address(RVA = "0x2B669E4", Offset = "0x2B669E4", VA = "0x2B669E4")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005D5 RID: 1493
		// (get) Token: 0x060026FA RID: 9978 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005D5")]
		public string url
		{
			[Token(Token = "0x60026FA")]
			[Address(RVA = "0x2B669EC", Offset = "0x2B669EC", VA = "0x2B669EC")]
			get
			{
				return null;
			}
		}

		// Token: 0x1400000A RID: 10
		// (add) Token: 0x060026FB RID: 9979 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x060026FC RID: 9980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400000A")]
		public event Action<string> onFailed
		{
			[Token(Token = "0x60026FB")]
			[Address(RVA = "0x2B669F4", Offset = "0x2B669F4", VA = "0x2B669F4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60026FC")]
			[Address(RVA = "0x2B66AA4", Offset = "0x2B66AA4", VA = "0x2B66AA4")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400000B RID: 11
		// (add) Token: 0x060026FD RID: 9981 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x060026FE RID: 9982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400000B")]
		public event Action<int> onRetry
		{
			[Token(Token = "0x60026FD")]
			[Address(RVA = "0x2B66B54", Offset = "0x2B66B54", VA = "0x2B66B54")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60026FE")]
			[Address(RVA = "0x2B66C04", Offset = "0x2B66C04", VA = "0x2B66C04")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400000C RID: 12
		// (add) Token: 0x060026FF RID: 9983 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06002700 RID: 9984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400000C")]
		public event Action onTimeOut
		{
			[Token(Token = "0x60026FF")]
			[Address(RVA = "0x2B66CB4", Offset = "0x2B66CB4", VA = "0x2B66CB4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6002700")]
			[Address(RVA = "0x2B66D50", Offset = "0x2B66D50", VA = "0x2B66D50")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400000D RID: 13
		// (add) Token: 0x06002701 RID: 9985 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06002702 RID: 9986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400000D")]
		public event Action<DownloadHandler> onSuccess
		{
			[Token(Token = "0x6002701")]
			[Address(RVA = "0x2B66DEC", Offset = "0x2B66DEC", VA = "0x2B66DEC")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6002702")]
			[Address(RVA = "0x2B66E9C", Offset = "0x2B66E9C", VA = "0x2B66E9C")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06002703 RID: 9987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002703")]
		[Address(RVA = "0x2B66F4C", Offset = "0x2B66F4C", VA = "0x2B66F4C")]
		public HttpRequest(string url)
		{
		}

		// Token: 0x06002704 RID: 9988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002704")]
		[Address(RVA = "0x2B6707C", Offset = "0x2B6707C", VA = "0x2B6707C")]
		public void SendRequest()
		{
		}

		// Token: 0x06002705 RID: 9989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002705")]
		[Address(RVA = "0x2B67098", Offset = "0x2B67098", VA = "0x2B67098")]
		public void Dispose()
		{
		}

		// Token: 0x06002706 RID: 9990 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002706")]
		[Address(RVA = "0x2B671C8", Offset = "0x2B671C8", VA = "0x2B671C8")]
		public void OnUpdate()
		{
		}

		// Token: 0x04002325 RID: 8997
		[Token(Token = "0x4002325")]
		[FieldOffset(Offset = "0x10")]
		public UnityWebRequest _httpRequest;

		// Token: 0x04002326 RID: 8998
		[Token(Token = "0x4002326")]
		[FieldOffset(Offset = "0x18")]
		private float _elapseTime;

		// Token: 0x04002327 RID: 8999
		[Token(Token = "0x4002327")]
		[FieldOffset(Offset = "0x1C")]
		private float _timeout;

		// Token: 0x04002328 RID: 9000
		[Token(Token = "0x4002328")]
		[FieldOffset(Offset = "0x20")]
		private int _maxTryCount;

		// Token: 0x04002329 RID: 9001
		[Token(Token = "0x4002329")]
		[FieldOffset(Offset = "0x24")]
		private int _tryCount;

		// Token: 0x0400232A RID: 9002
		[Token(Token = "0x400232A")]
		[FieldOffset(Offset = "0x28")]
		private string _url;

		// Token: 0x0400232B RID: 9003
		[Token(Token = "0x400232B")]
		[FieldOffset(Offset = "0x30")]
		private bool _isDone;

		// Token: 0x0400232C RID: 9004
		[Token(Token = "0x400232C")]
		[FieldOffset(Offset = "0x38")]
		private string _error;

		// Token: 0x0400232D RID: 9005
		[Token(Token = "0x400232D")]
		[FieldOffset(Offset = "0x40")]
		private byte[] _data;

		// Token: 0x0200050C RID: 1292
		[Token(Token = "0x200050C")]
		private class WebRequestCertificateHandler : CertificateHandler
		{
			// Token: 0x06002707 RID: 9991 RVA: 0x0000EB50 File Offset: 0x0000CD50
			[Token(Token = "0x6002707")]
			[Address(RVA = "0x2B67778", Offset = "0x2B67778", VA = "0x2B67778", Slot = "5")]
			protected override bool ValidateCertificate(byte[] certificateData)
			{
				return default(bool);
			}

			// Token: 0x06002708 RID: 9992 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002708")]
			[Address(RVA = "0x2B67074", Offset = "0x2B67074", VA = "0x2B67074")]
			public WebRequestCertificateHandler()
			{
			}
		}
	}
}
