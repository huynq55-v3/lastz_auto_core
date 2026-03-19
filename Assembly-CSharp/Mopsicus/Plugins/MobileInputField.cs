using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using NiceJson;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mopsicus.Plugins
{
	// Token: 0x0200049F RID: 1183
	[Token(Token = "0x200049F")]
	[RequireComponent(typeof(InputField))]
	public class MobileInputField : MobileInputReceiver
	{
		// Token: 0x060022E5 RID: 8933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022E5")]
		[Address(RVA = "0x29FCDA8", Offset = "0x29FCDA8", VA = "0x29FCDA8")]
		private void Awake()
		{
		}

		// Token: 0x060022E6 RID: 8934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022E6")]
		[Address(RVA = "0x29FCEA0", Offset = "0x29FCEA0", VA = "0x29FCEA0", Slot = "4")]
		protected override void Start()
		{
		}

		// Token: 0x060022E7 RID: 8935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022E7")]
		[Address(RVA = "0x29FCF3C", Offset = "0x29FCF3C", VA = "0x29FCF3C")]
		private void OnEnable()
		{
		}

		// Token: 0x060022E8 RID: 8936 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022E8")]
		[Address(RVA = "0x29FD054", Offset = "0x29FD054", VA = "0x29FD054")]
		private void OnDisable()
		{
		}

		// Token: 0x060022E9 RID: 8937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022E9")]
		[Address(RVA = "0x29FD188", Offset = "0x29FD188", VA = "0x29FD188", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x060022EA RID: 8938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022EA")]
		[Address(RVA = "0x29FD298", Offset = "0x29FD298", VA = "0x29FD298")]
		private void OnApplicationFocus(bool hasFocus)
		{
		}

		// Token: 0x17000533 RID: 1331
		// (get) Token: 0x060022EB RID: 8939 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000533")]
		public InputField InputField
		{
			[Token(Token = "0x60022EB")]
			[Address(RVA = "0x29FD514", Offset = "0x29FD514", VA = "0x29FD514")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000534 RID: 1332
		// (get) Token: 0x060022EC RID: 8940 RVA: 0x0000D5F0 File Offset: 0x0000B7F0
		// (set) Token: 0x060022ED RID: 8941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000534")]
		public bool Visible
		{
			[Token(Token = "0x60022EC")]
			[Address(RVA = "0x29FD51C", Offset = "0x29FD51C", VA = "0x29FD51C")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60022ED")]
			[Address(RVA = "0x29FD524", Offset = "0x29FD524", VA = "0x29FD524")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000535 RID: 1333
		// (get) Token: 0x060022EE RID: 8942 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060022EF RID: 8943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000535")]
		public string Text
		{
			[Token(Token = "0x60022EE")]
			[Address(RVA = "0x29FD530", Offset = "0x29FD530", VA = "0x29FD530")]
			get
			{
				return null;
			}
			[Token(Token = "0x60022EF")]
			[Address(RVA = "0x29FD54C", Offset = "0x29FD54C", VA = "0x29FD54C")]
			set
			{
			}
		}

		// Token: 0x060022F0 RID: 8944 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022F0")]
		[Address(RVA = "0x29FCEC8", Offset = "0x29FCEC8", VA = "0x29FCEC8")]
		private IEnumerator InitialzieOnNextFrame()
		{
			return null;
		}

		// Token: 0x060022F1 RID: 8945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022F1")]
		[Address(RVA = "0x29FD68C", Offset = "0x29FD68C", VA = "0x29FD68C")]
		public void SetUnityInputEnabled(bool enabled)
		{
		}

		// Token: 0x060022F2 RID: 8946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022F2")]
		[Address(RVA = "0x29FD6D0", Offset = "0x29FD6D0", VA = "0x29FD6D0")]
		private void Update()
		{
		}

		// Token: 0x060022F3 RID: 8947 RVA: 0x0000D608 File Offset: 0x0000B808
		[Token(Token = "0x60022F3")]
		[Address(RVA = "0x29FDB5C", Offset = "0x29FDB5C", VA = "0x29FDB5C")]
		public static Rect GetScreenRectFromRectTransform(RectTransform rect)
		{
			return default(Rect);
		}

		// Token: 0x060022F4 RID: 8948 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022F4")]
		[Address(RVA = "0x29FDDF0", Offset = "0x29FDDF0", VA = "0x29FDDF0")]
		private void PrepareNativeEdit()
		{
		}

		// Token: 0x060022F5 RID: 8949 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022F5")]
		[Address(RVA = "0x29FE0E0", Offset = "0x29FE0E0", VA = "0x29FE0E0")]
		private void OnTextChange(string text)
		{
		}

		// Token: 0x060022F6 RID: 8950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022F6")]
		[Address(RVA = "0x29FE17C", Offset = "0x29FE17C", VA = "0x29FE17C")]
		private void OnTextEditEnd(string text)
		{
		}

		// Token: 0x060022F7 RID: 8951 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022F7")]
		[Address(RVA = "0x29FE1FC", Offset = "0x29FE1FC", VA = "0x29FE1FC", Slot = "6")]
		public override void Send(JsonObject data)
		{
		}

		// Token: 0x060022F8 RID: 8952 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022F8")]
		[Address(RVA = "0x29FE344", Offset = "0x29FE344", VA = "0x29FE344", Slot = "7")]
		public override void Hide()
		{
		}

		// Token: 0x060022F9 RID: 8953 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022F9")]
		[Address(RVA = "0x29FE2B4", Offset = "0x29FE2B4", VA = "0x29FE2B4")]
		private IEnumerator PluginsMessageRoutine(JsonObject data)
		{
			return null;
		}

		// Token: 0x060022FA RID: 8954 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022FA")]
		[Address(RVA = "0x29FE374", Offset = "0x29FE374", VA = "0x29FE374")]
		private string InvariantCultureString(float value)
		{
			return null;
		}

		// Token: 0x060022FB RID: 8955 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022FB")]
		[Address(RVA = "0x29FE3F4", Offset = "0x29FE3F4", VA = "0x29FE3F4")]
		private void CreateNativeEdit()
		{
		}

		// Token: 0x060022FC RID: 8956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022FC")]
		[Address(RVA = "0x29FEC6C", Offset = "0x29FEC6C", VA = "0x29FEC6C")]
		private void Ready()
		{
		}

		// Token: 0x060022FD RID: 8957 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022FD")]
		[Address(RVA = "0x29FECB8", Offset = "0x29FECB8", VA = "0x29FECB8")]
		public void SetIngoreFocus(bool focus)
		{
		}

		// Token: 0x060022FE RID: 8958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022FE")]
		[Address(RVA = "0x29FD584", Offset = "0x29FD584", VA = "0x29FD584")]
		private void SetTextNative(string text)
		{
		}

		// Token: 0x060022FF RID: 8959 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022FF")]
		[Address(RVA = "0x29FD1F0", Offset = "0x29FD1F0", VA = "0x29FD1F0")]
		private void RemoveNative()
		{
		}

		// Token: 0x06002300 RID: 8960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002300")]
		[Address(RVA = "0x29FD920", Offset = "0x29FD920", VA = "0x29FD920")]
		public void SetRectNative(RectTransform inputRect)
		{
		}

		// Token: 0x06002301 RID: 8961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002301")]
		[Address(RVA = "0x29FD084", Offset = "0x29FD084", VA = "0x29FD084")]
		public void SetFocus(bool isFocus)
		{
		}

		// Token: 0x06002302 RID: 8962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002302")]
		[Address(RVA = "0x29FCF50", Offset = "0x29FCF50", VA = "0x29FCF50")]
		public void SetVisible(bool isVisible)
		{
		}

		// Token: 0x06002303 RID: 8963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002303")]
		[Address(RVA = "0x29FED98", Offset = "0x29FED98", VA = "0x29FED98")]
		private void ForceSendKeydownAndroid(string key)
		{
		}

		// Token: 0x06002304 RID: 8964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002304")]
		[Address(RVA = "0x29FD824", Offset = "0x29FD824", VA = "0x29FD824")]
		private void UpdateForceKeyeventForAndroid()
		{
		}

		// Token: 0x06002305 RID: 8965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002305")]
		[Address(RVA = "0x29FEE78", Offset = "0x29FEE78", VA = "0x29FEE78")]
		public MobileInputField()
		{
		}

		// Token: 0x0400204F RID: 8271
		[Token(Token = "0x400204F")]
		[FieldOffset(Offset = "0x20")]
		public string CustomFont;

		// Token: 0x04002050 RID: 8272
		[Token(Token = "0x4002050")]
		[FieldOffset(Offset = "0x28")]
		public bool IsManualHideControl;

		// Token: 0x04002051 RID: 8273
		[Token(Token = "0x4002051")]
		[FieldOffset(Offset = "0x29")]
		public bool IsWithDoneButton;

		// Token: 0x04002052 RID: 8274
		[Token(Token = "0x4002052")]
		[FieldOffset(Offset = "0x2A")]
		public bool IsWithClearButton;

		// Token: 0x04002053 RID: 8275
		[Token(Token = "0x4002053")]
		[FieldOffset(Offset = "0x2C")]
		public MobileInputField.ReturnKeyType ReturnKey;

		// Token: 0x04002054 RID: 8276
		[Token(Token = "0x4002054")]
		[FieldOffset(Offset = "0x30")]
		public Action OnReturnPressed;

		// Token: 0x04002055 RID: 8277
		[Token(Token = "0x4002055")]
		[FieldOffset(Offset = "0x38")]
		public Action<string> PushTextLineCount;

		// Token: 0x04002056 RID: 8278
		[Token(Token = "0x4002056")]
		[FieldOffset(Offset = "0x40")]
		public Action<bool> OnFocusChanged;

		// Token: 0x04002057 RID: 8279
		[Token(Token = "0x4002057")]
		[FieldOffset(Offset = "0x48")]
		public UnityEvent OnReturnPressedEvent;

		// Token: 0x04002058 RID: 8280
		[Token(Token = "0x4002058")]
		[FieldOffset(Offset = "0x50")]
		private bool _isMobileInputCreated;

		// Token: 0x04002059 RID: 8281
		[Token(Token = "0x4002059")]
		[FieldOffset(Offset = "0x58")]
		private InputField _inputObject;

		// Token: 0x0400205A RID: 8282
		[Token(Token = "0x400205A")]
		[FieldOffset(Offset = "0x60")]
		private Text _inputObjectText;

		// Token: 0x0400205B RID: 8283
		[Token(Token = "0x400205B")]
		[FieldOffset(Offset = "0x68")]
		private bool _isFocusOnCreate;

		// Token: 0x0400205C RID: 8284
		[Token(Token = "0x400205C")]
		[FieldOffset(Offset = "0x69")]
		private bool _isVisibleOnCreate;

		// Token: 0x0400205D RID: 8285
		[Token(Token = "0x400205D")]
		[FieldOffset(Offset = "0x6C")]
		private Rect _lastRect;

		// Token: 0x0400205E RID: 8286
		[Token(Token = "0x400205E")]
		[FieldOffset(Offset = "0x80")]
		private MobileInputField.MobileInputConfig _config;

		// Token: 0x0400205F RID: 8287
		[Token(Token = "0x400205F")]
		private const string CREATE = "CREATE_EDIT";

		// Token: 0x04002060 RID: 8288
		[Token(Token = "0x4002060")]
		private const string REMOVE = "REMOVE_EDIT";

		// Token: 0x04002061 RID: 8289
		[Token(Token = "0x4002061")]
		private const string IGNORE_CLICK = "IGNORE_CLICK";

		// Token: 0x04002062 RID: 8290
		[Token(Token = "0x4002062")]
		private const string SET_TEXT = "SET_TEXT";

		// Token: 0x04002063 RID: 8291
		[Token(Token = "0x4002063")]
		private const string SET_RECT = "SET_RECT";

		// Token: 0x04002064 RID: 8292
		[Token(Token = "0x4002064")]
		private const string SET_FOCUS = "SET_FOCUS";

		// Token: 0x04002065 RID: 8293
		[Token(Token = "0x4002065")]
		private const string ON_FOCUS = "ON_FOCUS";

		// Token: 0x04002066 RID: 8294
		[Token(Token = "0x4002066")]
		private const string ON_UNFOCUS = "ON_UNFOCUS";

		// Token: 0x04002067 RID: 8295
		[Token(Token = "0x4002067")]
		private const string SET_VISIBLE = "SET_VISIBLE";

		// Token: 0x04002068 RID: 8296
		[Token(Token = "0x4002068")]
		private const string TEXT_CHANGE = "TEXT_CHANGE";

		// Token: 0x04002069 RID: 8297
		[Token(Token = "0x4002069")]
		private const string TEXT_END_EDIT = "TEXT_END_EDIT";

		// Token: 0x0400206A RID: 8298
		[Token(Token = "0x400206A")]
		private const string ANDROID_KEY_DOWN = "ANDROID_KEY_DOWN";

		// Token: 0x0400206B RID: 8299
		[Token(Token = "0x400206B")]
		private const string RETURN_PRESSED = "RETURN_PRESSED";

		// Token: 0x0400206C RID: 8300
		[Token(Token = "0x400206C")]
		private const string LINE_COUNT = "LINE_COUNT";

		// Token: 0x0400206D RID: 8301
		[Token(Token = "0x400206D")]
		private const string READY = "READY";

		// Token: 0x0400206E RID: 8302
		[Token(Token = "0x400206E")]
		[FieldOffset(Offset = "0xF0")]
		private int _visiableBeforeFocusFlag;

		// Token: 0x04002070 RID: 8304
		[Token(Token = "0x4002070")]
		[FieldOffset(Offset = "0x0")]
		private static Camera UICamera;

		// Token: 0x020004A0 RID: 1184
		[Token(Token = "0x20004A0")]
		private struct MobileInputConfig
		{
			// Token: 0x04002071 RID: 8305
			[Token(Token = "0x4002071")]
			[FieldOffset(Offset = "0x0")]
			public bool Multiline;

			// Token: 0x04002072 RID: 8306
			[Token(Token = "0x4002072")]
			[FieldOffset(Offset = "0x4")]
			public Color TextColor;

			// Token: 0x04002073 RID: 8307
			[Token(Token = "0x4002073")]
			[FieldOffset(Offset = "0x14")]
			public Color BackgroundColor;

			// Token: 0x04002074 RID: 8308
			[Token(Token = "0x4002074")]
			[FieldOffset(Offset = "0x28")]
			public string ContentType;

			// Token: 0x04002075 RID: 8309
			[Token(Token = "0x4002075")]
			[FieldOffset(Offset = "0x30")]
			public string InputType;

			// Token: 0x04002076 RID: 8310
			[Token(Token = "0x4002076")]
			[FieldOffset(Offset = "0x38")]
			public string KeyboardType;

			// Token: 0x04002077 RID: 8311
			[Token(Token = "0x4002077")]
			[FieldOffset(Offset = "0x40")]
			public float FontSize;

			// Token: 0x04002078 RID: 8312
			[Token(Token = "0x4002078")]
			[FieldOffset(Offset = "0x48")]
			public string Align;

			// Token: 0x04002079 RID: 8313
			[Token(Token = "0x4002079")]
			[FieldOffset(Offset = "0x50")]
			public string Placeholder;

			// Token: 0x0400207A RID: 8314
			[Token(Token = "0x400207A")]
			[FieldOffset(Offset = "0x58")]
			public Color PlaceholderColor;

			// Token: 0x0400207B RID: 8315
			[Token(Token = "0x400207B")]
			[FieldOffset(Offset = "0x68")]
			public int CharacterLimit;
		}

		// Token: 0x020004A1 RID: 1185
		[Token(Token = "0x20004A1")]
		public enum ReturnKeyType
		{
			// Token: 0x0400207D RID: 8317
			[Token(Token = "0x400207D")]
			Default,
			// Token: 0x0400207E RID: 8318
			[Token(Token = "0x400207E")]
			Next,
			// Token: 0x0400207F RID: 8319
			[Token(Token = "0x400207F")]
			Done,
			// Token: 0x04002080 RID: 8320
			[Token(Token = "0x4002080")]
			Search,
			// Token: 0x04002081 RID: 8321
			[Token(Token = "0x4002081")]
			Send
		}
	}
}
