using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200002F RID: 47
[Token(Token = "0x200002F")]
[ExecuteAlways]
public class FOWSystem : MonoBehaviour
{
	// Token: 0x17000008 RID: 8
	// (get) Token: 0x0600007A RID: 122 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000008")]
	public Texture2D texture0
	{
		[Token(Token = "0x600007A")]
		[Address(RVA = "0x15E6028", Offset = "0x15E6028", VA = "0x15E6028")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000009 RID: 9
	// (get) Token: 0x0600007B RID: 123 RVA: 0x00002190 File Offset: 0x00000390
	[Token(Token = "0x17000009")]
	public float blendFactor
	{
		[Token(Token = "0x600007B")]
		[Address(RVA = "0x15E6030", Offset = "0x15E6030", VA = "0x15E6030")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x1700000A RID: 10
	// (get) Token: 0x0600007C RID: 124 RVA: 0x000021A8 File Offset: 0x000003A8
	// (set) Token: 0x0600007D RID: 125 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700000A")]
	public bool isRevealRect
	{
		[Token(Token = "0x600007C")]
		[Address(RVA = "0x15E6038", Offset = "0x15E6038", VA = "0x15E6038")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600007D")]
		[Address(RVA = "0x15E6040", Offset = "0x15E6040", VA = "0x15E6040")]
		[CompilerGenerated]
		set
		{
		}
	}

	// Token: 0x0600007E RID: 126 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600007E")]
	[Address(RVA = "0x15E604C", Offset = "0x15E604C", VA = "0x15E604C")]
	public static FOWSystem.Revealer CreateRevealer()
	{
		return null;
	}

	// Token: 0x0600007F RID: 127 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600007F")]
	[Address(RVA = "0x15E6274", Offset = "0x15E6274", VA = "0x15E6274")]
	public static void AddRevealer(FOWSystem.Revealer rev)
	{
	}

	// Token: 0x06000080 RID: 128 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000080")]
	[Address(RVA = "0x15E640C", Offset = "0x15E640C", VA = "0x15E640C")]
	public static void AddRevealerParam(Vector3 position, Vector2 range, bool isBlack = false)
	{
	}

	// Token: 0x06000081 RID: 129 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000081")]
	[Address(RVA = "0x15E64CC", Offset = "0x15E64CC", VA = "0x15E64CC")]
	public static void AddRevealerParam2(float x, float y, float z, float cx, float cy, bool isBlack = false)
	{
	}

	// Token: 0x06000082 RID: 130 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000082")]
	[Address(RVA = "0x15E658C", Offset = "0x15E658C", VA = "0x15E658C")]
	public static void DeleteRevealer(FOWSystem.Revealer rev)
	{
	}

	// Token: 0x06000083 RID: 131 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000083")]
	[Address(RVA = "0x15E6724", Offset = "0x15E6724", VA = "0x15E6724")]
	private void Awake()
	{
	}

	// Token: 0x06000084 RID: 132 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000084")]
	[Address(RVA = "0x15E678C", Offset = "0x15E678C", VA = "0x15E678C")]
	public void Clear()
	{
	}

	// Token: 0x06000085 RID: 133 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000085")]
	[Address(RVA = "0x15E67F8", Offset = "0x15E67F8", VA = "0x15E67F8")]
	public void RegisterCompleteAction(Action onComplete)
	{
	}

	// Token: 0x06000086 RID: 134 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000086")]
	[Address(RVA = "0x15E68AC", Offset = "0x15E68AC", VA = "0x15E68AC")]
	private void Start()
	{
	}

	// Token: 0x06000087 RID: 135 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000087")]
	[Address(RVA = "0x15E7438", Offset = "0x15E7438", VA = "0x15E7438")]
	private void OnDestroy()
	{
	}

	// Token: 0x06000088 RID: 136 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000088")]
	[Address(RVA = "0x15E75C4", Offset = "0x15E75C4", VA = "0x15E75C4")]
	private void Update()
	{
	}

	// Token: 0x06000089 RID: 137 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000089")]
	[Address(RVA = "0x15E7668", Offset = "0x15E7668", VA = "0x15E7668")]
	private void ThreadUpdate()
	{
	}

	// Token: 0x0600008A RID: 138 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600008A")]
	[Address(RVA = "0x15E6B68", Offset = "0x15E6B68", VA = "0x15E6B68")]
	private void UpdateBuffer(bool isStart)
	{
	}

	// Token: 0x0600008B RID: 139 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600008B")]
	[Address(RVA = "0x15E789C", Offset = "0x15E789C", VA = "0x15E789C")]
	private void RevealUsingCache(FOWSystem.Revealer r, float worldToTex)
	{
	}

	// Token: 0x0600008C RID: 140 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600008C")]
	[Address(RVA = "0x15E7B64", Offset = "0x15E7B64", VA = "0x15E7B64")]
	private void RevealIntoCacheRect(FOWSystem.Revealer r, float worldToTex)
	{
	}

	// Token: 0x0600008D RID: 141 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600008D")]
	[Address(RVA = "0x15E799C", Offset = "0x15E799C", VA = "0x15E799C")]
	private void BlurVisibility()
	{
	}

	// Token: 0x0600008E RID: 142 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600008E")]
	[Address(RVA = "0x15E728C", Offset = "0x15E728C", VA = "0x15E728C")]
	private void UpdateTexture()
	{
	}

	// Token: 0x0600008F RID: 143 RVA: 0x000021C0 File Offset: 0x000003C0
	[Token(Token = "0x600008F")]
	[Address(RVA = "0x15E8114", Offset = "0x15E8114", VA = "0x15E8114")]
	public bool CanShowWhiteFog()
	{
		return default(bool);
	}

	// Token: 0x06000090 RID: 144 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000090")]
	[Address(RVA = "0x15E811C", Offset = "0x15E811C", VA = "0x15E811C")]
	public FOWSystem()
	{
	}

	// Token: 0x040000F8 RID: 248
	[Token(Token = "0x40000F8")]
	[FieldOffset(Offset = "0x0")]
	public static FOWSystem instance;

	// Token: 0x040000F9 RID: 249
	[Token(Token = "0x40000F9")]
	[FieldOffset(Offset = "0x8")]
	protected static int[,] mHeights;

	// Token: 0x040000FA RID: 250
	[Token(Token = "0x40000FA")]
	[FieldOffset(Offset = "0x18")]
	protected Transform mTrans;

	// Token: 0x040000FB RID: 251
	[Token(Token = "0x40000FB")]
	[FieldOffset(Offset = "0x20")]
	protected Vector3 mOrigin;

	// Token: 0x040000FC RID: 252
	[Token(Token = "0x40000FC")]
	[FieldOffset(Offset = "0x2C")]
	protected Vector3 mSize;

	// Token: 0x040000FD RID: 253
	[Token(Token = "0x40000FD")]
	[FieldOffset(Offset = "0x10")]
	private static List<FOWSystem.Revealer> mRevealers;

	// Token: 0x040000FE RID: 254
	[Token(Token = "0x40000FE")]
	[FieldOffset(Offset = "0x18")]
	private static List<FOWSystem.Revealer> mAdded;

	// Token: 0x040000FF RID: 255
	[Token(Token = "0x40000FF")]
	[FieldOffset(Offset = "0x20")]
	private static List<FOWSystem.Revealer> mRemoved;

	// Token: 0x04000100 RID: 256
	[Token(Token = "0x4000100")]
	[FieldOffset(Offset = "0x38")]
	protected Color32[] mBuffer0;

	// Token: 0x04000101 RID: 257
	[Token(Token = "0x4000101")]
	[FieldOffset(Offset = "0x40")]
	protected Color32[] mBuffer1;

	// Token: 0x04000102 RID: 258
	[Token(Token = "0x4000102")]
	[FieldOffset(Offset = "0x48")]
	protected Color32[] mBuffer2;

	// Token: 0x04000103 RID: 259
	[Token(Token = "0x4000103")]
	[FieldOffset(Offset = "0x50")]
	protected Texture2D mTexture0;

	// Token: 0x04000104 RID: 260
	[Token(Token = "0x4000104")]
	[FieldOffset(Offset = "0x58")]
	protected float mBlendFactor;

	// Token: 0x04000105 RID: 261
	[Token(Token = "0x4000105")]
	[FieldOffset(Offset = "0x5C")]
	protected float mNextUpdate;

	// Token: 0x04000106 RID: 262
	[Token(Token = "0x4000106")]
	[FieldOffset(Offset = "0x60")]
	protected int mScreenHeight;

	// Token: 0x04000107 RID: 263
	[Token(Token = "0x4000107")]
	[FieldOffset(Offset = "0x64")]
	protected FOWSystem.State mState;

	// Token: 0x04000108 RID: 264
	[Token(Token = "0x4000108")]
	[FieldOffset(Offset = "0x68")]
	private AutoResetEvent wakeupEvent;

	// Token: 0x04000109 RID: 265
	[Token(Token = "0x4000109")]
	[FieldOffset(Offset = "0x70")]
	private Thread mThread;

	// Token: 0x0400010A RID: 266
	[Token(Token = "0x400010A")]
	[FieldOffset(Offset = "0x78")]
	public int worldSize;

	// Token: 0x0400010B RID: 267
	[Token(Token = "0x400010B")]
	[FieldOffset(Offset = "0x7C")]
	public int textureSize;

	// Token: 0x0400010C RID: 268
	[Token(Token = "0x400010C")]
	[FieldOffset(Offset = "0x80")]
	public float updateFrequency;

	// Token: 0x0400010D RID: 269
	[Token(Token = "0x400010D")]
	[FieldOffset(Offset = "0x84")]
	public float textureBlendTime;

	// Token: 0x0400010E RID: 270
	[Token(Token = "0x400010E")]
	[FieldOffset(Offset = "0x88")]
	public int blurIterations;

	// Token: 0x0400010F RID: 271
	[Token(Token = "0x400010F")]
	[FieldOffset(Offset = "0x8C")]
	public Vector2 heightRange;

	// Token: 0x04000110 RID: 272
	[Token(Token = "0x4000110")]
	[FieldOffset(Offset = "0x94")]
	public float margin;

	// Token: 0x04000111 RID: 273
	[Token(Token = "0x4000111")]
	[FieldOffset(Offset = "0x98")]
	public bool debug;

	// Token: 0x04000113 RID: 275
	[Token(Token = "0x4000113")]
	[FieldOffset(Offset = "0x9A")]
	private bool isRun;

	// Token: 0x04000114 RID: 276
	[Token(Token = "0x4000114")]
	[FieldOffset(Offset = "0xA0")]
	private Action OnComplete;

	// Token: 0x04000115 RID: 277
	[Token(Token = "0x4000115")]
	[FieldOffset(Offset = "0xA8")]
	private float mElapsed;

	// Token: 0x04000116 RID: 278
	[Token(Token = "0x4000116")]
	[FieldOffset(Offset = "0xAC")]
	private Color32 white;

	// Token: 0x04000117 RID: 279
	[Token(Token = "0x4000117")]
	[FieldOffset(Offset = "0xB0")]
	private Color32 black;

	// Token: 0x02000030 RID: 48
	[Token(Token = "0x2000030")]
	public enum LOSChecks
	{
		// Token: 0x04000119 RID: 281
		[Token(Token = "0x4000119")]
		None,
		// Token: 0x0400011A RID: 282
		[Token(Token = "0x400011A")]
		OnlyOnce,
		// Token: 0x0400011B RID: 283
		[Token(Token = "0x400011B")]
		EveryUpdate
	}

	// Token: 0x02000031 RID: 49
	[Token(Token = "0x2000031")]
	public class Revealer
	{
		// Token: 0x06000092 RID: 146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000092")]
		[Address(RVA = "0x15E6214", Offset = "0x15E6214", VA = "0x15E6214")]
		public Revealer()
		{
		}

		// Token: 0x0400011C RID: 284
		[Token(Token = "0x400011C")]
		[FieldOffset(Offset = "0x10")]
		public bool isActive;

		// Token: 0x0400011D RID: 285
		[Token(Token = "0x400011D")]
		[FieldOffset(Offset = "0x14")]
		public FOWSystem.LOSChecks los;

		// Token: 0x0400011E RID: 286
		[Token(Token = "0x400011E")]
		[FieldOffset(Offset = "0x18")]
		public Vector3 pos;

		// Token: 0x0400011F RID: 287
		[Token(Token = "0x400011F")]
		[FieldOffset(Offset = "0x24")]
		public float inner;

		// Token: 0x04000120 RID: 288
		[Token(Token = "0x4000120")]
		[FieldOffset(Offset = "0x28")]
		public float outer;

		// Token: 0x04000121 RID: 289
		[Token(Token = "0x4000121")]
		[FieldOffset(Offset = "0x30")]
		public bool[] cachedBuffer;

		// Token: 0x04000122 RID: 290
		[Token(Token = "0x4000122")]
		[FieldOffset(Offset = "0x38")]
		public int cachedSize;

		// Token: 0x04000123 RID: 291
		[Token(Token = "0x4000123")]
		[FieldOffset(Offset = "0x3C")]
		public int cachedX;

		// Token: 0x04000124 RID: 292
		[Token(Token = "0x4000124")]
		[FieldOffset(Offset = "0x40")]
		public int cachedY;

		// Token: 0x04000125 RID: 293
		[Token(Token = "0x4000125")]
		[FieldOffset(Offset = "0x44")]
		public bool isBack;
	}

	// Token: 0x02000032 RID: 50
	[Token(Token = "0x2000032")]
	public enum State
	{
		// Token: 0x04000127 RID: 295
		[Token(Token = "0x4000127")]
		Blending,
		// Token: 0x04000128 RID: 296
		[Token(Token = "0x4000128")]
		NeedUpdate,
		// Token: 0x04000129 RID: 297
		[Token(Token = "0x4000129")]
		UpdateTexture0
	}
}
