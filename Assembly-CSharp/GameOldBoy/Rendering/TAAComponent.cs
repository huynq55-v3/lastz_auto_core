using System;
using Il2CppDummyDll;
using UnityEngine;

namespace GameOldBoy.Rendering
{
	// Token: 0x02000A36 RID: 2614
	[Token(Token = "0x2000A36")]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Rendering/GameOldBoy/Temporal Anti-Aliasing")]
	public class TAAComponent : MonoBehaviour
	{
		// Token: 0x06006338 RID: 25400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006338")]
		[Address(RVA = "0x303FEF8", Offset = "0x303FEF8", VA = "0x303FEF8")]
		public TAAComponent()
		{
		}

		// Token: 0x040027DF RID: 10207
		[Token(Token = "0x40027DF")]
		[FieldOffset(Offset = "0x18")]
		public bool Enabled;

		// Token: 0x040027E0 RID: 10208
		[Token(Token = "0x40027E0")]
		[FieldOffset(Offset = "0x1C")]
		[Range(0.5f, 0.999f)]
		public float Blend;

		// Token: 0x040027E1 RID: 10209
		[Token(Token = "0x40027E1")]
		[FieldOffset(Offset = "0x20")]
		public TAAQuality Quality;

		// Token: 0x040027E2 RID: 10210
		[Token(Token = "0x40027E2")]
		[FieldOffset(Offset = "0x24")]
		public bool AntiGhosting;

		// Token: 0x040027E3 RID: 10211
		[Token(Token = "0x40027E3")]
		[FieldOffset(Offset = "0x25")]
		public bool UseBlurSharpenFilter;

		// Token: 0x040027E4 RID: 10212
		[Token(Token = "0x40027E4")]
		[FieldOffset(Offset = "0x26")]
		public bool UseBicubicFilter;

		// Token: 0x040027E5 RID: 10213
		[Token(Token = "0x40027E5")]
		[FieldOffset(Offset = "0x27")]
		public bool UseClipAABB;

		// Token: 0x040027E6 RID: 10214
		[Token(Token = "0x40027E6")]
		[FieldOffset(Offset = "0x28")]
		public bool UseDilation;

		// Token: 0x040027E7 RID: 10215
		[Token(Token = "0x40027E7")]
		[FieldOffset(Offset = "0x29")]
		public bool UseTonemap;

		// Token: 0x040027E8 RID: 10216
		[Token(Token = "0x40027E8")]
		[FieldOffset(Offset = "0x2A")]
		public bool UseVarianceClipping;

		// Token: 0x040027E9 RID: 10217
		[Token(Token = "0x40027E9")]
		[FieldOffset(Offset = "0x2B")]
		public bool UseYCoCgSpace;

		// Token: 0x040027EA RID: 10218
		[Token(Token = "0x40027EA")]
		[FieldOffset(Offset = "0x2C")]
		public bool Use4Tap;

		// Token: 0x040027EB RID: 10219
		[Token(Token = "0x40027EB")]
		[FieldOffset(Offset = "0x30")]
		[Min(0f)]
		public float Stability;

		// Token: 0x040027EC RID: 10220
		[Token(Token = "0x40027EC")]
		[FieldOffset(Offset = "0x34")]
		[Range(0f, 2f)]
		public float SharpenStrength;

		// Token: 0x040027ED RID: 10221
		[Token(Token = "0x40027ED")]
		[FieldOffset(Offset = "0x38")]
		[Range(0f, 1f)]
		public float HistorySharpening;
	}
}
