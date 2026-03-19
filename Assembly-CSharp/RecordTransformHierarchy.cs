using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020003A6 RID: 934
[Token(Token = "0x20003A6")]
public class RecordTransformHierarchy : MonoBehaviour
{
	// Token: 0x060017AC RID: 6060 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60017AC")]
	[Address(RVA = "0x1DB7878", Offset = "0x1DB7878", VA = "0x1DB7878")]
	public RecordTransformHierarchy()
	{
	}

	// Token: 0x04001A58 RID: 6744
	[Token(Token = "0x4001A58")]
	[FieldOffset(Offset = "0x18")]
	public AnimationClip clip;

	// Token: 0x04001A59 RID: 6745
	[Token(Token = "0x4001A59")]
	[FieldOffset(Offset = "0x20")]
	public float duringTime;

	// Token: 0x04001A5A RID: 6746
	[Token(Token = "0x4001A5A")]
	[FieldOffset(Offset = "0x28")]
	public List<RecordTransformHierarchy.RecordInfo> m_list;

	// Token: 0x020003A7 RID: 935
	[Token(Token = "0x20003A7")]
	public class RecordInfo
	{
		// Token: 0x060017AD RID: 6061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017AD")]
		[Address(RVA = "0x1DB7908", Offset = "0x1DB7908", VA = "0x1DB7908")]
		public RecordInfo()
		{
		}

		// Token: 0x04001A5B RID: 6747
		[Token(Token = "0x4001A5B")]
		[FieldOffset(Offset = "0x10")]
		public Transform tran;

		// Token: 0x04001A5C RID: 6748
		[Token(Token = "0x4001A5C")]
		[FieldOffset(Offset = "0x18")]
		public bool isSave;
	}
}
