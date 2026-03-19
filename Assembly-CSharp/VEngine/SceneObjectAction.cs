using System;
using Il2CppDummyDll;

namespace VEngine
{
	// Token: 0x020009F2 RID: 2546
	[Token(Token = "0x20009F2")]
	public class SceneObjectAction : Operation
	{
		// Token: 0x06006175 RID: 24949 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006175")]
		[Address(RVA = "0x14120F8", Offset = "0x14120F8", VA = "0x14120F8", Slot = "7")]
		protected override void Update()
		{
		}

		// Token: 0x06006176 RID: 24950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006176")]
		[Address(RVA = "0x140C200", Offset = "0x140C200", VA = "0x140C200")]
		public SceneObjectAction()
		{
		}

		// Token: 0x040025E8 RID: 9704
		[Token(Token = "0x40025E8")]
		[FieldOffset(Offset = "0x30")]
		public Action<SceneObject> func;

		// Token: 0x040025E9 RID: 9705
		[Token(Token = "0x40025E9")]
		[FieldOffset(Offset = "0x38")]
		public string key;

		// Token: 0x040025EA RID: 9706
		[Token(Token = "0x40025EA")]
		[FieldOffset(Offset = "0x40")]
		public SceneObject sceneObject;
	}
}
