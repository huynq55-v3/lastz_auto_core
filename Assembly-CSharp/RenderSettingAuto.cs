using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002B2 RID: 690
[Token(Token = "0x20002B2")]
public class RenderSettingAuto : MonoBehaviour
{
	// Token: 0x060011EA RID: 4586 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011EA")]
	[Address(RVA = "0x1C56764", Offset = "0x1C56764", VA = "0x1C56764")]
	public void Reset()
	{
	}

	// Token: 0x060011EB RID: 4587 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011EB")]
	[Address(RVA = "0x1C56900", Offset = "0x1C56900", VA = "0x1C56900")]
	private void OnEnable()
	{
	}

	// Token: 0x060011EC RID: 4588 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011EC")]
	[Address(RVA = "0x1C569DC", Offset = "0x1C569DC", VA = "0x1C569DC")]
	private void OnDisable()
	{
	}

	// Token: 0x060011ED RID: 4589 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011ED")]
	[Address(RVA = "0x1C56BD0", Offset = "0x1C56BD0", VA = "0x1C56BD0")]
	public RenderSettingAuto()
	{
	}

	// Token: 0x040014CF RID: 5327
	[Token(Token = "0x40014CF")]
	[FieldOffset(Offset = "0x18")]
	public bool isCulling;

	// Token: 0x040014D0 RID: 5328
	[Token(Token = "0x40014D0")]
	[FieldOffset(Offset = "0x1C")]
	[Range(0f, 31f)]
	public int culingLayer;

	// Token: 0x040014D1 RID: 5329
	[Token(Token = "0x40014D1")]
	[FieldOffset(Offset = "0x20")]
	public float distance;

	// Token: 0x040014D2 RID: 5330
	[Token(Token = "0x40014D2")]
	[FieldOffset(Offset = "0x24")]
	public bool isDowloadDepth;

	// Token: 0x040014D3 RID: 5331
	[Token(Token = "0x40014D3")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private RenderSettingData _renderSettingData;
}
