using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using VEngine;
using Zendesk.Runtime.Localisation;

// Token: 0x02000072 RID: 114
[Token(Token = "0x2000072")]
public class ZendeskSDK : MonoBehaviour
{
	// Token: 0x060002D0 RID: 720 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002D0")]
	[Address(RVA = "0x320BFC0", Offset = "0x320BFC0", VA = "0x320BFC0")]
	public static ZendeskSDK GetInst()
	{
		return null;
	}

	// Token: 0x060002D1 RID: 721 RVA: 0x00002FB8 File Offset: 0x000011B8
	[Token(Token = "0x60002D1")]
	[Address(RVA = "0x320C0D8", Offset = "0x320C0D8", VA = "0x320C0D8")]
	private ZendeskLanguage GetLanguage()
	{
		return default(ZendeskLanguage);
	}

	// Token: 0x060002D2 RID: 722 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002D2")]
	[Address(RVA = "0x320C184", Offset = "0x320C184", VA = "0x320C184")]
	public void OnInitSDK(string channelId, Action action)
	{
	}

	// Token: 0x060002D3 RID: 723 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002D3")]
	[Address(RVA = "0x320C338", Offset = "0x320C338", VA = "0x320C338")]
	private IEnumerator ToInit(string channelId)
	{
		return null;
	}

	// Token: 0x060002D4 RID: 724 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002D4")]
	[Address(RVA = "0x320C3F0", Offset = "0x320C3F0", VA = "0x320C3F0")]
	public void Login(string jwt, Action action)
	{
	}

	// Token: 0x060002D5 RID: 725 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002D5")]
	[Address(RVA = "0x320C5B4", Offset = "0x320C5B4", VA = "0x320C5B4")]
	private IEnumerator ToLogin(string jwt)
	{
		return null;
	}

	// Token: 0x060002D6 RID: 726 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002D6")]
	[Address(RVA = "0x320C66C", Offset = "0x320C66C", VA = "0x320C66C")]
	public void SetTicketField(Dictionary<string, object> param)
	{
	}

	// Token: 0x060002D7 RID: 727 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002D7")]
	[Address(RVA = "0x320C800", Offset = "0x320C800", VA = "0x320C800")]
	public void SetTag(List<string> param)
	{
	}

	// Token: 0x060002D8 RID: 728 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002D8")]
	[Address(RVA = "0x320C994", Offset = "0x320C994", VA = "0x320C994")]
	public void OnShowMessage()
	{
	}

	// Token: 0x060002D9 RID: 729 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002D9")]
	[Address(RVA = "0x320CCB8", Offset = "0x320CCB8", VA = "0x320CCB8")]
	public void OnShowHome()
	{
	}

	// Token: 0x060002DA RID: 730 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002DA")]
	[Address(RVA = "0x320CE48", Offset = "0x320CE48", VA = "0x320CE48")]
	public void OnGetUnreadCount(Action<int> action)
	{
	}

	// Token: 0x060002DB RID: 731 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002DB")]
	[Address(RVA = "0x320CFB0", Offset = "0x320CFB0", VA = "0x320CFB0")]
	private IEnumerator GetUnreadCountCoroutine()
	{
		return null;
	}

	// Token: 0x060002DC RID: 732 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002DC")]
	[Address(RVA = "0x320D04C", Offset = "0x320D04C", VA = "0x320D04C")]
	private GameObject LoadZendeskPrefab(string path)
	{
		return null;
	}

	// Token: 0x060002DD RID: 733 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002DD")]
	[Address(RVA = "0x320D200", Offset = "0x320D200", VA = "0x320D200")]
	private void UnloadZendeskPrefab(string path)
	{
	}

	// Token: 0x060002DE RID: 734 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002DE")]
	[Address(RVA = "0x320C080", Offset = "0x320C080", VA = "0x320C080")]
	public ZendeskSDK()
	{
	}

	// Token: 0x0400026C RID: 620
	[Token(Token = "0x400026C")]
	[FieldOffset(Offset = "0x0")]
	public static ZendeskSDK _inst;

	// Token: 0x0400026D RID: 621
	[Token(Token = "0x400026D")]
	[FieldOffset(Offset = "0x8")]
	private static bool hasInit;

	// Token: 0x0400026E RID: 622
	[Token(Token = "0x400026E")]
	[FieldOffset(Offset = "0x18")]
	private Action _actionInit;

	// Token: 0x0400026F RID: 623
	[Token(Token = "0x400026F")]
	[FieldOffset(Offset = "0x20")]
	private string _channelId;

	// Token: 0x04000270 RID: 624
	[Token(Token = "0x4000270")]
	[FieldOffset(Offset = "0x28")]
	private Action _actionLogin;

	// Token: 0x04000271 RID: 625
	[Token(Token = "0x4000271")]
	[FieldOffset(Offset = "0x30")]
	private Action<int> _getUnReadAction;

	// Token: 0x04000272 RID: 626
	[Token(Token = "0x4000272")]
	[FieldOffset(Offset = "0x38")]
	private Dictionary<string, Asset> _loadedAssets;
}
