using System;
using DTT.AreaOfEffectRegions;
using Il2CppDummyDll;
using UnityEngine;

namespace Main.Scripts.Scene.PVE
{
	// Token: 0x02000506 RID: 1286
	[Token(Token = "0x2000506")]
	public class SkillIndicator : MonoBehaviour
	{
		// Token: 0x060026DF RID: 9951 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026DF")]
		[Address(RVA = "0x2B659E4", Offset = "0x2B659E4", VA = "0x2B659E4")]
		public void SetTotalTime(float totalTime)
		{
		}

		// Token: 0x060026E0 RID: 9952 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026E0")]
		[Address(RVA = "0x2B659F0", Offset = "0x2B659F0", VA = "0x2B659F0")]
		public void SetCircleData(float radius)
		{
		}

		// Token: 0x060026E1 RID: 9953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026E1")]
		[Address(RVA = "0x2B65AEC", Offset = "0x2B65AEC", VA = "0x2B65AEC")]
		public void SetArcData(float arc, float angle, float radius)
		{
		}

		// Token: 0x060026E2 RID: 9954 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026E2")]
		[Address(RVA = "0x2B65BFC", Offset = "0x2B65BFC", VA = "0x2B65BFC")]
		public void SetLineData(float angle, float width, float length)
		{
		}

		// Token: 0x060026E3 RID: 9955 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026E3")]
		[Address(RVA = "0x2B65CF8", Offset = "0x2B65CF8", VA = "0x2B65CF8")]
		private void Update()
		{
		}

		// Token: 0x060026E4 RID: 9956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026E4")]
		[Address(RVA = "0x2B65E40", Offset = "0x2B65E40", VA = "0x2B65E40")]
		public SkillIndicator()
		{
		}

		// Token: 0x04002313 RID: 8979
		[Token(Token = "0x4002313")]
		[FieldOffset(Offset = "0x18")]
		private CircleRegion _circleRegion;

		// Token: 0x04002314 RID: 8980
		[Token(Token = "0x4002314")]
		[FieldOffset(Offset = "0x20")]
		private ArcRegion _arcRegion;

		// Token: 0x04002315 RID: 8981
		[Token(Token = "0x4002315")]
		[FieldOffset(Offset = "0x28")]
		private LineRegion _lineRegion;

		// Token: 0x04002316 RID: 8982
		[Token(Token = "0x4002316")]
		[FieldOffset(Offset = "0x30")]
		private float _totalTime;

		// Token: 0x04002317 RID: 8983
		[Token(Token = "0x4002317")]
		[FieldOffset(Offset = "0x34")]
		private float _startTime;
	}
}
