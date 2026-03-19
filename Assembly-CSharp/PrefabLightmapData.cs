using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002AA RID: 682
[Token(Token = "0x20002AA")]
public class PrefabLightmapData : MonoBehaviour
{
	// Token: 0x060011C9 RID: 4553 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011C9")]
	[Address(RVA = "0x1C546A4", Offset = "0x1C546A4", VA = "0x1C546A4")]
	private void Awake()
	{
	}

	// Token: 0x060011CA RID: 4554 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011CA")]
	[Address(RVA = "0x1C54864", Offset = "0x1C54864", VA = "0x1C54864")]
	private void ApplyRendererInfo(PrefabLightmapData.RendererInfo[] infos, int lightmapOffsetIndex)
	{
	}

	// Token: 0x060011CB RID: 4555 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011CB")]
	[Address(RVA = "0x1C549D8", Offset = "0x1C549D8", VA = "0x1C549D8")]
	public PrefabLightmapData()
	{
	}

	// Token: 0x040014A7 RID: 5287
	[Token(Token = "0x40014A7")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public PrefabLightmapData.RendererInfo[] m_RendererInfo;

	// Token: 0x040014A8 RID: 5288
	[Token(Token = "0x40014A8")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Texture2D[] m_Lightmaps;

	// Token: 0x020002AB RID: 683
	[Token(Token = "0x20002AB")]
	[Serializable]
	public struct RendererInfo
	{
		// Token: 0x040014A9 RID: 5289
		[Token(Token = "0x40014A9")]
		[FieldOffset(Offset = "0x0")]
		public Renderer renderer;

		// Token: 0x040014AA RID: 5290
		[Token(Token = "0x40014AA")]
		[FieldOffset(Offset = "0x8")]
		public int lightmapIndex;

		// Token: 0x040014AB RID: 5291
		[Token(Token = "0x40014AB")]
		[FieldOffset(Offset = "0xC")]
		public Vector3 position;

		// Token: 0x040014AC RID: 5292
		[Token(Token = "0x40014AC")]
		[FieldOffset(Offset = "0x18")]
		public Vector4 lightmapOffsetScale;
	}
}
