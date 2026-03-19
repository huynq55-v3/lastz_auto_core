using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

namespace PowerUtilities
{
	// Token: 0x020003AF RID: 943
	[Token(Token = "0x20003AF")]
	public static class PresetBlendModeTools
	{
		// Token: 0x060017CC RID: 6092 RVA: 0x00008CE8 File Offset: 0x00006EE8
		[Token(Token = "0x60017CC")]
		[Address(RVA = "0x1DB9BDC", Offset = "0x1DB9BDC", VA = "0x1DB9BDC")]
		public static PresetBlendMode GetPresetBlendMode(BlendMode srcMode, BlendMode dstMode)
		{
			return PresetBlendMode.Normal;
		}

		// Token: 0x060017CD RID: 6093 RVA: 0x00008D00 File Offset: 0x00006F00
		[Token(Token = "0x60017CD")]
		[Address(RVA = "0x1DB9D14", Offset = "0x1DB9D14", VA = "0x1DB9D14")]
		public static PresetBlendMode GetPresetBlendMode(Material mat, string srcModeName = "_SrcMode", string dstModeName = "_DstMode")
		{
			return PresetBlendMode.Normal;
		}

		// Token: 0x060017CE RID: 6094 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017CE")]
		[Address(RVA = "0x1DB9DB0", Offset = "0x1DB9DB0", VA = "0x1DB9DB0")]
		public static BlendMode[] GetBlendMode(PresetBlendMode presetBlendMode)
		{
			return null;
		}

		// Token: 0x04001A91 RID: 6801
		[Token(Token = "0x4001A91")]
		[FieldOffset(Offset = "0x0")]
		public static Dictionary<PresetBlendMode, BlendMode[]> blendModeDict;

		// Token: 0x04001A92 RID: 6802
		[Token(Token = "0x4001A92")]
		public const string SRC_MODE = "_SrcMode";

		// Token: 0x04001A93 RID: 6803
		[Token(Token = "0x4001A93")]
		public const string DST_MODE = "_DstMode";
	}
}
