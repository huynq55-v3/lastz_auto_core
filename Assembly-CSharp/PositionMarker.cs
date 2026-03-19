using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002E3 RID: 739
[Token(Token = "0x20002E3")]
[ExecuteInEditMode]
public class PositionMarker : MonoBehaviour
{
	// Token: 0x06001318 RID: 4888 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001318")]
	[Address(RVA = "0x1A45F84", Offset = "0x1A45F84", VA = "0x1A45F84")]
	private void Awake()
	{
	}

	// Token: 0x06001319 RID: 4889 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001319")]
	[Address(RVA = "0x1A45FB8", Offset = "0x1A45FB8", VA = "0x1A45FB8")]
	public void SetToTileCenter()
	{
	}

	// Token: 0x0600131A RID: 4890 RVA: 0x00007968 File Offset: 0x00005B68
	[Token(Token = "0x600131A")]
	[Address(RVA = "0x1A4604C", Offset = "0x1A4604C", VA = "0x1A4604C")]
	public Vector2Int GetTilePos()
	{
		return default(Vector2Int);
	}

	// Token: 0x0600131B RID: 4891 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600131B")]
	[Address(RVA = "0x1A46074", Offset = "0x1A46074", VA = "0x1A46074")]
	public PositionMarker()
	{
	}

	// Token: 0x040015F3 RID: 5619
	[Token(Token = "0x40015F3")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Vector2Int tilePos;
}
