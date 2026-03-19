using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000278 RID: 632
[Token(Token = "0x2000278")]
public class BuildingLabel : MonoBehaviour
{
	// Token: 0x060010B0 RID: 4272 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010B0")]
	[Address(RVA = "0x1BF1E80", Offset = "0x1BF1E80", VA = "0x1BF1E80")]
	private void Awake()
	{
	}

	// Token: 0x060010B1 RID: 4273 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010B1")]
	[Address(RVA = "0x1BF1EB0", Offset = "0x1BF1EB0", VA = "0x1BF1EB0")]
	public void SetData()
	{
	}

	// Token: 0x060010B2 RID: 4274 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010B2")]
	[Address(RVA = "0x1BF1EB4", Offset = "0x1BF1EB4", VA = "0x1BF1EB4")]
	public void UpdateUpgradeLabel()
	{
	}

	// Token: 0x060010B3 RID: 4275 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010B3")]
	[Address(RVA = "0x1BF1EB8", Offset = "0x1BF1EB8", VA = "0x1BF1EB8")]
	public void OnBuildingPositionChanged()
	{
	}

	// Token: 0x060010B4 RID: 4276 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010B4")]
	[Address(RVA = "0x1BF1EBC", Offset = "0x1BF1EBC", VA = "0x1BF1EBC")]
	public void BuildingEnterMoveState(bool isEnter)
	{
	}

	// Token: 0x060010B5 RID: 4277 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010B5")]
	[Address(RVA = "0x1BF1EC0", Offset = "0x1BF1EC0", VA = "0x1BF1EC0")]
	public BuildingLabel()
	{
	}

	// Token: 0x04001381 RID: 4993
	[Token(Token = "0x4001381")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private SuperTextMesh m_level;

	// Token: 0x04001382 RID: 4994
	[Token(Token = "0x4001382")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject m_Upgrade;

	// Token: 0x04001383 RID: 4995
	[Token(Token = "0x4001383")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private SuperTextMesh m_name;

	// Token: 0x04001384 RID: 4996
	[Token(Token = "0x4001384")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private GameObject m_nameBg;

	// Token: 0x04001385 RID: 4997
	[Token(Token = "0x4001385")]
	[FieldOffset(Offset = "0x38")]
	private Vector3 localPosition;
}
