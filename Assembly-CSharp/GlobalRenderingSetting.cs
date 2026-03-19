using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000258 RID: 600
[Token(Token = "0x2000258")]
[CreateAssetMenu(menuName = "ScriptableOject/GlobalRenderingSetting")]
[Serializable]
public class GlobalRenderingSetting : ScriptableObject
{
	// Token: 0x06001003 RID: 4099 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001003")]
	[Address(RVA = "0x1BE9E8C", Offset = "0x1BE9E8C", VA = "0x1BE9E8C")]
	public GlobalRenderingSetting()
	{
	}

	// Token: 0x04001277 RID: 4727
	[Token(Token = "0x4001277")]
	[FieldOffset(Offset = "0x18")]
	public List<GlobalRenderingSetting.RenderingInfo> infoList;

	// Token: 0x02000259 RID: 601
	[Token(Token = "0x2000259")]
	[Serializable]
	public class FogInfo
	{
		// Token: 0x06001004 RID: 4100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001004")]
		[Address(RVA = "0x1BE9F14", Offset = "0x1BE9F14", VA = "0x1BE9F14")]
		public FogInfo()
		{
		}

		// Token: 0x04001278 RID: 4728
		[Token(Token = "0x4001278")]
		[FieldOffset(Offset = "0x10")]
		public Gradient fogGradientColor;

		// Token: 0x04001279 RID: 4729
		[Token(Token = "0x4001279")]
		[FieldOffset(Offset = "0x18")]
		public Color _FogColor;

		// Token: 0x0400127A RID: 4730
		[Token(Token = "0x400127A")]
		[FieldOffset(Offset = "0x28")]
		public float _FogGlobalDensity;

		// Token: 0x0400127B RID: 4731
		[Token(Token = "0x400127B")]
		[FieldOffset(Offset = "0x2C")]
		public float _FogFallOff;

		// Token: 0x0400127C RID: 4732
		[Token(Token = "0x400127C")]
		[FieldOffset(Offset = "0x30")]
		public float _FogHeight;

		// Token: 0x0400127D RID: 4733
		[Token(Token = "0x400127D")]
		[FieldOffset(Offset = "0x34")]
		public float _FogStartDis;

		// Token: 0x0400127E RID: 4734
		[Token(Token = "0x400127E")]
		[FieldOffset(Offset = "0x38")]
		public float _FogInscatteringExp;

		// Token: 0x0400127F RID: 4735
		[Token(Token = "0x400127F")]
		[FieldOffset(Offset = "0x3C")]
		public float _FogGradientDis;

		// Token: 0x04001280 RID: 4736
		[Token(Token = "0x4001280")]
		[FieldOffset(Offset = "0x40")]
		public float _FogStart;

		// Token: 0x04001281 RID: 4737
		[Token(Token = "0x4001281")]
		[FieldOffset(Offset = "0x44")]
		public float _FogEnd;

		// Token: 0x04001282 RID: 4738
		[Token(Token = "0x4001282")]
		[FieldOffset(Offset = "0x48")]
		public bool _IsTimePass;

		// Token: 0x04001283 RID: 4739
		[Token(Token = "0x4001283")]
		[FieldOffset(Offset = "0x49")]
		public bool _UseShadowMap;

		// Token: 0x04001284 RID: 4740
		[Token(Token = "0x4001284")]
		[FieldOffset(Offset = "0x4A")]
		public bool _ForceToggleFog;

		// Token: 0x04001285 RID: 4741
		[Token(Token = "0x4001285")]
		[FieldOffset(Offset = "0x4B")]
		public bool _UseSun;

		// Token: 0x04001286 RID: 4742
		[Token(Token = "0x4001286")]
		[FieldOffset(Offset = "0x4C")]
		public bool _DownLoadCopyDepth;
	}

	// Token: 0x0200025A RID: 602
	[Token(Token = "0x200025A")]
	[Serializable]
	public class RenderingInfo
	{
		// Token: 0x06001005 RID: 4101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001005")]
		[Address(RVA = "0x1BE9FC4", Offset = "0x1BE9FC4", VA = "0x1BE9FC4")]
		public RenderingInfo()
		{
		}

		// Token: 0x04001287 RID: 4743
		[Token(Token = "0x4001287")]
		[FieldOffset(Offset = "0x10")]
		public int LevelID;

		// Token: 0x04001288 RID: 4744
		[Token(Token = "0x4001288")]
		[FieldOffset(Offset = "0x18")]
		public GlobalRenderingSetting.FogInfo fog;
	}
}
