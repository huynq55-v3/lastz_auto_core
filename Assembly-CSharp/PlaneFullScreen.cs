using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000021 RID: 33
[Token(Token = "0x2000021")]
[RequireComponent(typeof(MeshRenderer))]
public class PlaneFullScreen : MonoBehaviour
{
	// Token: 0x0600005A RID: 90 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600005A")]
	[Address(RVA = "0x15E3F0C", Offset = "0x15E3F0C", VA = "0x15E3F0C")]
	private void LateUpdate()
	{
	}

	// Token: 0x0600005B RID: 91 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600005B")]
	[Address(RVA = "0x15E41C0", Offset = "0x15E41C0", VA = "0x15E41C0")]
	public PlaneFullScreen()
	{
	}

	// Token: 0x040000AD RID: 173
	[Token(Token = "0x40000AD")]
	[FieldOffset(Offset = "0x18")]
	public Camera targetCamera;

	// Token: 0x040000AE RID: 174
	[Token(Token = "0x40000AE")]
	[FieldOffset(Offset = "0x20")]
	public float distanceFromCamera;

	// Token: 0x040000AF RID: 175
	[Token(Token = "0x40000AF")]
	[FieldOffset(Offset = "0x24")]
	public bool faceCamera;

	// Token: 0x040000B0 RID: 176
	[Token(Token = "0x40000B0")]
	[FieldOffset(Offset = "0x28")]
	public Vector2 Size;
}
