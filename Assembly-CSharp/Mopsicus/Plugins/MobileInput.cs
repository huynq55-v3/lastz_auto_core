using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using NiceJson;
using UnityEngine;

namespace Mopsicus.Plugins
{
	// Token: 0x0200049C RID: 1180
	[Token(Token = "0x200049C")]
	public class MobileInput : MonoBehaviour, IPlugin
	{
		// Token: 0x060022CE RID: 8910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022CE")]
		[Address(RVA = "0x29FAF30", Offset = "0x29FAF30", VA = "0x29FAF30")]
		private void Awake()
		{
		}

		// Token: 0x17000531 RID: 1329
		// (get) Token: 0x060022CF RID: 8911 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000531")]
		public string Name
		{
			[Token(Token = "0x60022CF")]
			[Address(RVA = "0x29FB378", Offset = "0x29FB378", VA = "0x29FB378", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000532 RID: 1330
		// (get) Token: 0x060022D0 RID: 8912 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000532")]
		public static MobileInput Plugin
		{
			[Token(Token = "0x60022D0")]
			[Address(RVA = "0x29FB3B8", Offset = "0x29FB3B8", VA = "0x29FB3B8")]
			get
			{
				return null;
			}
		}

		// Token: 0x060022D1 RID: 8913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022D1")]
		[Address(RVA = "0x29FB410", Offset = "0x29FB410", VA = "0x29FB410", Slot = "5")]
		public void OnData(JsonObject data)
		{
		}

		// Token: 0x060022D2 RID: 8914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022D2")]
		[Address(RVA = "0x29FC080", Offset = "0x29FC080", VA = "0x29FC080", Slot = "6")]
		public void OnError(JsonObject data)
		{
		}

		// Token: 0x060022D3 RID: 8915 RVA: 0x0000D5D8 File Offset: 0x0000B7D8
		[Token(Token = "0x60022D3")]
		[Address(RVA = "0x29FA9DC", Offset = "0x29FA9DC", VA = "0x29FA9DC")]
		public static int Register(MobileInputReceiver receiver)
		{
			return 0;
		}

		// Token: 0x060022D4 RID: 8916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022D4")]
		[Address(RVA = "0x29FAAD4", Offset = "0x29FAAD4", VA = "0x29FAAD4")]
		public static void RemoveReceiver(int id)
		{
		}

		// Token: 0x060022D5 RID: 8917 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022D5")]
		[Address(RVA = "0x29FBFF8", Offset = "0x29FBFF8", VA = "0x29FBFF8")]
		public static MobileInputReceiver GetReceiver(int id)
		{
			return null;
		}

		// Token: 0x060022D6 RID: 8918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022D6")]
		[Address(RVA = "0x29FABC4", Offset = "0x29FABC4", VA = "0x29FABC4")]
		public static void Execute(int id, JsonObject data)
		{
		}

		// Token: 0x060022D7 RID: 8919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022D7")]
		[Address(RVA = "0x29FAFE8", Offset = "0x29FAFE8", VA = "0x29FAFE8")]
		public static void Init()
		{
		}

		// Token: 0x060022D8 RID: 8920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022D8")]
		[Address(RVA = "0x29FC5B4", Offset = "0x29FC5B4", VA = "0x29FC5B4")]
		public static void Destroy()
		{
		}

		// Token: 0x060022D9 RID: 8921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022D9")]
		[Address(RVA = "0x29FC830", Offset = "0x29FC830", VA = "0x29FC830")]
		private void OnApplicationPause(bool pauseStatus)
		{
		}

		// Token: 0x060022DA RID: 8922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022DA")]
		[Address(RVA = "0x29FC380", Offset = "0x29FC380", VA = "0x29FC380")]
		private static void PrepareFontsAssets(string fileName)
		{
		}

		// Token: 0x060022DB RID: 8923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022DB")]
		[Address(RVA = "0x29FC850", Offset = "0x29FC850", VA = "0x29FC850")]
		private void OnApplicationFocus(bool focusStatus)
		{
		}

		// Token: 0x060022DC RID: 8924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022DC")]
		[Address(RVA = "0x29FC9F8", Offset = "0x29FC9F8", VA = "0x29FC9F8")]
		public MobileInput()
		{
		}

		// Token: 0x04002045 RID: 8261
		[Token(Token = "0x4002045")]
		private const string KEYBOARD_ACTION = "KEYBOARD_ACTION";

		// Token: 0x04002046 RID: 8262
		[Token(Token = "0x4002046")]
		private const string INIT_KEY = "mobileinput_inited";

		// Token: 0x04002047 RID: 8263
		[Token(Token = "0x4002047")]
		private const string SELF_NAME = "mobileinput";

		// Token: 0x04002048 RID: 8264
		[Token(Token = "0x4002048")]
		[FieldOffset(Offset = "0x0")]
		public static MobileInput.ShowDelegate OnShowKeyboard;

		// Token: 0x04002049 RID: 8265
		[Token(Token = "0x4002049")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<int, MobileInputReceiver> _inputs;

		// Token: 0x0400204A RID: 8266
		[Token(Token = "0x400204A")]
		[FieldOffset(Offset = "0x8")]
		private static MobileInput _instance;

		// Token: 0x0400204B RID: 8267
		[Token(Token = "0x400204B")]
		[FieldOffset(Offset = "0x20")]
		private JsonObject _data;

		// Token: 0x0400204C RID: 8268
		[Token(Token = "0x400204C")]
		[FieldOffset(Offset = "0x28")]
		private JsonObject _error;

		// Token: 0x0400204D RID: 8269
		[Token(Token = "0x400204D")]
		[FieldOffset(Offset = "0x30")]
		private int _counter;

		// Token: 0x0200049D RID: 1181
		// (Invoke) Token: 0x060022DF RID: 8927
		[Token(Token = "0x200049D")]
		public delegate void ShowDelegate(bool isShow, int height, int leftOffset, int rightOffset);
	}
}
