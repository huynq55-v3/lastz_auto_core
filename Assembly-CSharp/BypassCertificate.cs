using System;
using Il2CppDummyDll;
using UnityEngine.Networking;
using UnityEngine.Scripting;

// Token: 0x0200023A RID: 570
[Token(Token = "0x200023A")]
[Preserve]
public class BypassCertificate : CertificateHandler
{
	// Token: 0x06000F64 RID: 3940 RVA: 0x00006C00 File Offset: 0x00004E00
	[Token(Token = "0x6000F64")]
	[Address(RVA = "0x1BE08AC", Offset = "0x1BE08AC", VA = "0x1BE08AC", Slot = "5")]
	protected override bool ValidateCertificate(byte[] certificateData)
	{
		return default(bool);
	}

	// Token: 0x06000F65 RID: 3941 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F65")]
	[Address(RVA = "0x1BE08B4", Offset = "0x1BE08B4", VA = "0x1BE08B4")]
	public BypassCertificate()
	{
	}
}
