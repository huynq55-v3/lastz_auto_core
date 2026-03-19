using System;
using Il2CppDummyDll;
using UnityEngine;

namespace NexgenDragon
{
	// Token: 0x020003BA RID: 954
	[Token(Token = "0x20003BA")]
	public class SceneColorToShader : MonoBehaviour
	{
		// Token: 0x060017F8 RID: 6136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017F8")]
		[Address(RVA = "0x1DBD370", Offset = "0x1DBD370", VA = "0x1DBD370")]
		private void Awake()
		{
		}

		// Token: 0x060017F9 RID: 6137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017F9")]
		[Address(RVA = "0x1DBD4F4", Offset = "0x1DBD4F4", VA = "0x1DBD4F4")]
		private void OnDestroy()
		{
		}

		// Token: 0x060017FA RID: 6138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017FA")]
		[Address(RVA = "0x1DBD538", Offset = "0x1DBD538", VA = "0x1DBD538")]
		public void CamCapture()
		{
		}

		// Token: 0x060017FB RID: 6139 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017FB")]
		[Address(RVA = "0x1DBDB54", Offset = "0x1DBDB54", VA = "0x1DBDB54")]
		public SceneColorToShader()
		{
		}

		// Token: 0x04001AAC RID: 6828
		[Token(Token = "0x4001AAC")]
		[FieldOffset(Offset = "0x18")]
		public string FilePath;

		// Token: 0x04001AAD RID: 6829
		[Token(Token = "0x4001AAD")]
		[FieldOffset(Offset = "0x20")]
		public string FileName;

		// Token: 0x04001AAE RID: 6830
		[Token(Token = "0x4001AAE")]
		[FieldOffset(Offset = "0x28")]
		[Header("RT 设置（可选）")]
		[Tooltip("如果为 0，则使用相机当前分辨率")]
		public int RTSize;

		// Token: 0x04001AAF RID: 6831
		[Token(Token = "0x4001AAF")]
		[FieldOffset(Offset = "0x30")]
		private string WholePathName;

		// Token: 0x04001AB0 RID: 6832
		[Token(Token = "0x4001AB0")]
		[FieldOffset(Offset = "0x38")]
		private Camera cam;

		// Token: 0x04001AB1 RID: 6833
		[Token(Token = "0x4001AB1")]
		[FieldOffset(Offset = "0x40")]
		private float camHeight;

		// Token: 0x04001AB2 RID: 6834
		[Token(Token = "0x4001AB2")]
		[FieldOffset(Offset = "0x44")]
		private float camWidth;

		// Token: 0x04001AB3 RID: 6835
		[Token(Token = "0x4001AB3")]
		[FieldOffset(Offset = "0x48")]
		public Texture2D GroundLightRT;
	}
}
