using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000370 RID: 880
[Token(Token = "0x2000370")]
public class WorldGoScaleAdjust : MonoBehaviour
{
	// Token: 0x06001680 RID: 5760 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001680")]
	[Address(RVA = "0x1EE0650", Offset = "0x1EE0650", VA = "0x1EE0650")]
	private void Update()
	{
	}

	// Token: 0x06001681 RID: 5761 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001681")]
	[Address(RVA = "0x1EE0A58", Offset = "0x1EE0A58", VA = "0x1EE0A58")]
	public WorldGoScaleAdjust()
	{
	}

	// Token: 0x040019B5 RID: 6581
	[Token(Token = "0x40019B5")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private List<Transform> _transGoScaleList;

	// Token: 0x040019B6 RID: 6582
	[Token(Token = "0x40019B6")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private List<Transform> _transGoPosList;

	// Token: 0x040019B7 RID: 6583
	[Token(Token = "0x40019B7")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private AnimationCurve _scaleCurve;

	// Token: 0x040019B8 RID: 6584
	[Token(Token = "0x40019B8")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private AnimationCurve _posCurve;

	// Token: 0x040019B9 RID: 6585
	[Token(Token = "0x40019B9")]
	[FieldOffset(Offset = "0x38")]
	[Header("Data")]
	[SerializeField]
	private int _maxDistance;

	// Token: 0x040019BA RID: 6586
	[Token(Token = "0x40019BA")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	private Vector3 _maxScale;

	// Token: 0x040019BB RID: 6587
	[Token(Token = "0x40019BB")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private float _maxLocalPosY;

	// Token: 0x040019BC RID: 6588
	[Token(Token = "0x40019BC")]
	[FieldOffset(Offset = "0x4C")]
	private float _cacheDistance;
}
