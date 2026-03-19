using System;
using Il2CppDummyDll;
using UnityEngine;

namespace MapEditor
{
	// Token: 0x02000CFB RID: 3323
	[Token(Token = "0x2000CFB")]
	public class SceneConfigEditor : MonoBehaviour
	{
		// Token: 0x06007C79 RID: 31865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C79")]
		[Address(RVA = "0x319CF20", Offset = "0x319CF20", VA = "0x319CF20")]
		public SceneConfigEditor()
		{
		}

		// Token: 0x04003871 RID: 14449
		[Token(Token = "0x4003871")]
		[FieldOffset(Offset = "0x18")]
		public int scene;

		// Token: 0x04003872 RID: 14450
		[Token(Token = "0x4003872")]
		[FieldOffset(Offset = "0x20")]
		public string sceneID;

		// Token: 0x04003873 RID: 14451
		[Token(Token = "0x4003873")]
		[FieldOffset(Offset = "0x28")]
		public Vector2 spawnPos;

		// Token: 0x04003874 RID: 14452
		[Token(Token = "0x4003874")]
		[FieldOffset(Offset = "0x30")]
		public float spawnRotation;

		// Token: 0x04003875 RID: 14453
		[Token(Token = "0x4003875")]
		[FieldOffset(Offset = "0x34")]
		public Vector2 runPos;

		// Token: 0x04003876 RID: 14454
		[Token(Token = "0x4003876")]
		[FieldOffset(Offset = "0x3C")]
		public Vector2Int minPos;

		// Token: 0x04003877 RID: 14455
		[Token(Token = "0x4003877")]
		[FieldOffset(Offset = "0x44")]
		public Vector2Int maxPos;

		// Token: 0x04003878 RID: 14456
		[Token(Token = "0x4003878")]
		[FieldOffset(Offset = "0x50")]
		public string mapDesc;
	}
}
