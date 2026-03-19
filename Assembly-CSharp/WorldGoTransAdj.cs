using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000371 RID: 881
[Token(Token = "0x2000371")]
public class WorldGoTransAdj : MonoBehaviour
{
	// Token: 0x06001682 RID: 5762 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001682")]
	[Address(RVA = "0x1EE0A60", Offset = "0x1EE0A60", VA = "0x1EE0A60")]
	private void Start()
	{
	}

	// Token: 0x06001683 RID: 5763 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001683")]
	[Address(RVA = "0x1EE0BF0", Offset = "0x1EE0BF0", VA = "0x1EE0BF0")]
	private void Update()
	{
	}

	// Token: 0x06001684 RID: 5764 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001684")]
	[Address(RVA = "0x1EE1028", Offset = "0x1EE1028", VA = "0x1EE1028")]
	public WorldGoTransAdj()
	{
	}

	// Token: 0x040019BD RID: 6589
	[Token(Token = "0x40019BD")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private List<WorldGoTransAdjCurve> _curveList;

	// Token: 0x040019BE RID: 6590
	[Token(Token = "0x40019BE")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private List<WorldGoTransAdjParam> _worldTransList;

	// Token: 0x040019BF RID: 6591
	[Token(Token = "0x40019BF")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float _maxCameraDistance;

	// Token: 0x040019C0 RID: 6592
	[Token(Token = "0x40019C0")]
	[FieldOffset(Offset = "0x2C")]
	private float _cacheDistance;

	// Token: 0x040019C1 RID: 6593
	[Token(Token = "0x40019C1")]
	[FieldOffset(Offset = "0x30")]
	private Dictionary<string, AnimationCurve> _curveDic;
}
