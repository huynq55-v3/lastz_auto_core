using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Networking;

namespace GameKit.Base
{
	// Token: 0x020004F1 RID: 1265
	[Token(Token = "0x20004F1")]
	public class WebRequestManager : SingletonBehaviour<WebRequestManager>
	{
		// Token: 0x06002664 RID: 9828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002664")]
		[Address(RVA = "0x2B5F810", Offset = "0x2B5F810", VA = "0x2B5F810")]
		private void OnDisable()
		{
		}

		// Token: 0x06002665 RID: 9829 RVA: 0x0000E7F0 File Offset: 0x0000C9F0
		[Token(Token = "0x6002665")]
		[Address(RVA = "0x2B5F97C", Offset = "0x2B5F97C", VA = "0x2B5F97C")]
		public bool IsDownloadResult(UnityWebRequest request, string result)
		{
			return default(bool);
		}

		// Token: 0x06002666 RID: 9830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002666")]
		[Address(RVA = "0x2B5FA0C", Offset = "0x2B5FA0C", VA = "0x2B5FA0C")]
		public void LoadTexture(string uri, WebRequestManager.OnWebRequestCallback callback, int priority = 0, int timeout = 0, [Optional] object userdata)
		{
		}

		// Token: 0x06002667 RID: 9831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002667")]
		[Address(RVA = "0x2B5FC88", Offset = "0x2B5FC88", VA = "0x2B5FC88")]
		public void LoadTexture(string uri, bool nonReadable, WebRequestManager.OnWebRequestCallback callback, int priority = 0, int timeout = 0, [Optional] object userdata)
		{
		}

		// Token: 0x06002668 RID: 9832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002668")]
		[Address(RVA = "0x2B5FCE4", Offset = "0x2B5FCE4", VA = "0x2B5FCE4")]
		public void Get(string uri, WebRequestManager.OnWebRequestCallback callback, int priority = 0, int timeout = 0, [Optional] object userdata)
		{
		}

		// Token: 0x06002669 RID: 9833 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002669")]
		[Address(RVA = "0x2B5FD38", Offset = "0x2B5FD38", VA = "0x2B5FD38")]
		public void Post(string uri, string postData, WebRequestManager.OnWebRequestCallback callback, int priority = 0, int timeout = 0, [Optional] object userdata)
		{
		}

		// Token: 0x0600266A RID: 9834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600266A")]
		[Address(RVA = "0x2B5FD90", Offset = "0x2B5FD90", VA = "0x2B5FD90")]
		public void Post(string uri, WWWForm formData, WebRequestManager.OnWebRequestCallback callback, int priority = 0, int timeout = 0, [Optional] object userdata)
		{
		}

		// Token: 0x0600266B RID: 9835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600266B")]
		[Address(RVA = "0x2B5FDE8", Offset = "0x2B5FDE8", VA = "0x2B5FDE8")]
		public void Post(string uri, List<IMultipartFormSection> multipartFormSections, WebRequestManager.OnWebRequestCallback callback, int priority = 0, int timeout = 0, [Optional] object userdata)
		{
		}

		// Token: 0x0600266C RID: 9836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600266C")]
		[Address(RVA = "0x2B5FE40", Offset = "0x2B5FE40", VA = "0x2B5FE40")]
		public void Post(string uri, Dictionary<string, string> formFields, WebRequestManager.OnWebRequestCallback callback, int priority = 0, int timeout = 0, [Optional] object userdata)
		{
		}

		// Token: 0x0600266D RID: 9837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600266D")]
		[Address(RVA = "0x2B5FE98", Offset = "0x2B5FE98", VA = "0x2B5FE98")]
		public void Head(string uri, WebRequestManager.OnWebRequestCallback callback, int priority = 0, int timeout = 0, [Optional] object userdata)
		{
		}

		// Token: 0x0600266E RID: 9838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600266E")]
		[Address(RVA = "0x2B5FEEC", Offset = "0x2B5FEEC", VA = "0x2B5FEEC")]
		public void Put(string uri, string bodyData, [Optional] WebRequestManager.OnWebRequestCallback callback, int priority = 0, int timeout = 0, [Optional] object userdata)
		{
		}

		// Token: 0x0600266F RID: 9839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600266F")]
		[Address(RVA = "0x2B5FF44", Offset = "0x2B5FF44", VA = "0x2B5FF44")]
		public void Put(string uri, byte[] bodyData, [Optional] WebRequestManager.OnWebRequestCallback callback, int priority = 0, int timeout = 0, [Optional] object userdata)
		{
		}

		// Token: 0x06002670 RID: 9840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002670")]
		[Address(RVA = "0x2B5FF9C", Offset = "0x2B5FF9C", VA = "0x2B5FF9C")]
		public void Delete(string uri, [Optional] WebRequestManager.OnWebRequestCallback callback, int priority = 0, int timeout = 0, [Optional] object userdata)
		{
		}

		// Token: 0x06002671 RID: 9841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002671")]
		[Address(RVA = "0x2B5FFF0", Offset = "0x2B5FFF0", VA = "0x2B5FFF0")]
		public void DownFile(string uri, string localFilePath, WebRequestManager.OnWebRequestCallback callback, int priority = 0, int timeout = 0, [Optional] object userdata)
		{
		}

		// Token: 0x06002672 RID: 9842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002672")]
		[Address(RVA = "0x2B600C0", Offset = "0x2B600C0", VA = "0x2B600C0")]
		public void UploadFile(string uri, string localFilePath, WebRequestManager.OnWebRequestCallback callback, int priority = 0, int timeout = 0, [Optional] object userdata, string contentType = "")
		{
		}

		// Token: 0x06002673 RID: 9843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002673")]
		[Address(RVA = "0x2B60234", Offset = "0x2B60234", VA = "0x2B60234")]
		public void ModifyURLPriority(string uri, int modifyValue)
		{
		}

		// Token: 0x06002674 RID: 9844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002674")]
		[Address(RVA = "0x2B6038C", Offset = "0x2B6038C", VA = "0x2B6038C")]
		private void ReorderWaitingList()
		{
		}

		// Token: 0x06002675 RID: 9845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002675")]
		[Address(RVA = "0x2B5FA64", Offset = "0x2B5FA64", VA = "0x2B5FA64")]
		private void Request(UnityWebRequest request, [Optional] WebRequestManager.OnWebRequestCallback callback, int priority = 0, int timeout = 0, [Optional] object userdata)
		{
		}

		// Token: 0x06002676 RID: 9846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002676")]
		[Address(RVA = "0x2B6042C", Offset = "0x2B6042C", VA = "0x2B6042C", Slot = "4")]
		protected override void OnUpdate(float delta)
		{
		}

		// Token: 0x06002677 RID: 9847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002677")]
		[Address(RVA = "0x2B5F908", Offset = "0x2B5F908", VA = "0x2B5F908")]
		private void Dispose(UnityWebRequest request)
		{
		}

		// Token: 0x06002678 RID: 9848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002678")]
		[Address(RVA = "0x2B60DB0", Offset = "0x2B60DB0", VA = "0x2B60DB0")]
		public WebRequestManager()
		{
		}

		// Token: 0x040022A1 RID: 8865
		[Token(Token = "0x40022A1")]
		public const string FILE_NO_EXISTS = "file no exists";

		// Token: 0x040022A2 RID: 8866
		[Token(Token = "0x40022A2")]
		[FieldOffset(Offset = "0x20")]
		private readonly Dictionary<string, UnityWebRequestAsyncOperation> m_WorkingRequests;

		// Token: 0x040022A3 RID: 8867
		[Token(Token = "0x40022A3")]
		[FieldOffset(Offset = "0x28")]
		private readonly List<UnityWebRequest> m_WaitingRequests;

		// Token: 0x040022A4 RID: 8868
		[Token(Token = "0x40022A4")]
		[FieldOffset(Offset = "0x30")]
		private readonly Dictionary<UnityWebRequest, WebRequestManager.WebRequestParams> m_ParamsStack;

		// Token: 0x040022A5 RID: 8869
		[Token(Token = "0x40022A5")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private int maxWorkingWebRequestThread;

		// Token: 0x040022A6 RID: 8870
		[Token(Token = "0x40022A6")]
		[FieldOffset(Offset = "0x40")]
		private Dictionary<string, UnityWebRequestAsyncOperation>.Enumerator enumeratorWorking;

		// Token: 0x040022A7 RID: 8871
		[Token(Token = "0x40022A7")]
		[FieldOffset(Offset = "0x68")]
		private readonly List<string> keysToRemove;

		// Token: 0x020004F2 RID: 1266
		[Token(Token = "0x20004F2")]
		[Serializable]
		private struct WebRequestParams
		{
			// Token: 0x040022A8 RID: 8872
			[Token(Token = "0x40022A8")]
			[FieldOffset(Offset = "0x0")]
			public WebRequestManager.OnWebRequestCallback calback;

			// Token: 0x040022A9 RID: 8873
			[Token(Token = "0x40022A9")]
			[FieldOffset(Offset = "0x8")]
			public int priority;

			// Token: 0x040022AA RID: 8874
			[Token(Token = "0x40022AA")]
			[FieldOffset(Offset = "0x10")]
			public object userdata;
		}

		// Token: 0x020004F3 RID: 1267
		// (Invoke) Token: 0x0600267B RID: 9851
		[Token(Token = "0x20004F3")]
		public delegate void OnWebRequestCallback(UnityWebRequest request, bool hasErr, object userdata);

		// Token: 0x020004F4 RID: 1268
		// (Invoke) Token: 0x0600267F RID: 9855
		[Token(Token = "0x20004F4")]
		public delegate void OnWebRequestProgressCallBack(UnityWebRequest request, object userdata);
	}
}
