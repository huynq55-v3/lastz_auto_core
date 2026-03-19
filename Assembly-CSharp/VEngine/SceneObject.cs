using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace VEngine
{
	// Token: 0x020009E2 RID: 2530
	[Token(Token = "0x20009E2")]
	public class SceneObject : Loadable, IEnumerator
	{
		// Token: 0x17000618 RID: 1560
		// (get) Token: 0x060060FF RID: 24831 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006100 RID: 24832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000618")]
		public GameObject gameObject
		{
			[Token(Token = "0x60060FF")]
			[Address(RVA = "0x140BE40", Offset = "0x140BE40", VA = "0x140BE40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006100")]
			[Address(RVA = "0x140BE48", Offset = "0x140BE48", VA = "0x140BE48")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06006101 RID: 24833 RVA: 0x0004B3F0 File Offset: 0x000495F0
		[Token(Token = "0x6006101")]
		[Address(RVA = "0x140BE50", Offset = "0x140BE50", VA = "0x140BE50", Slot = "13")]
		public bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x06006102 RID: 24834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006102")]
		[Address(RVA = "0x140BE70", Offset = "0x140BE70", VA = "0x140BE70", Slot = "15")]
		public void Reset()
		{
		}

		// Token: 0x17000619 RID: 1561
		// (get) Token: 0x06006103 RID: 24835 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000619")]
		public object Current
		{
			[Token(Token = "0x6006103")]
			[Address(RVA = "0x140BE74", Offset = "0x140BE74", VA = "0x140BE74", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006104 RID: 24836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006104")]
		[Address(RVA = "0x140BE7C", Offset = "0x140BE7C", VA = "0x140BE7C")]
		public void SetTransformParent(Transform tranParent, bool worldPositionStays)
		{
		}

		// Token: 0x1700061A RID: 1562
		// (get) Token: 0x06006105 RID: 24837 RVA: 0x0004B408 File Offset: 0x00049608
		// (set) Token: 0x06006106 RID: 24838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700061A")]
		public bool ActiveSelf
		{
			[Token(Token = "0x6006105")]
			[Address(RVA = "0x140BF50", Offset = "0x140BF50", VA = "0x140BF50")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6006106")]
			[Address(RVA = "0x140BF58", Offset = "0x140BF58", VA = "0x140BF58")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06006107 RID: 24839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006107")]
		[Address(RVA = "0x140BF64", Offset = "0x140BF64", VA = "0x140BF64")]
		public void SetActive(bool active)
		{
		}

		// Token: 0x06006108 RID: 24840 RVA: 0x0004B420 File Offset: 0x00049620
		[Token(Token = "0x6006108")]
		[Address(RVA = "0x140C00C", Offset = "0x140C00C", VA = "0x140C00C")]
		public bool RemoveAction(string key)
		{
			return default(bool);
		}

		// Token: 0x06006109 RID: 24841 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006109")]
		[Address(RVA = "0x140C064", Offset = "0x140C064", VA = "0x140C064")]
		public SceneObjectAction RunAction(Action<SceneObject> func, [Optional] string key)
		{
			return null;
		}

		// Token: 0x0600610A RID: 24842 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600610A")]
		[Address(RVA = "0x140C258", Offset = "0x140C258", VA = "0x140C258")]
		public static SceneObject LoadAsync(string assetPath, [Optional] Action<SceneObject> completed)
		{
			return null;
		}

		// Token: 0x0600610B RID: 24843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600610B")]
		[Address(RVA = "0x140C4E0", Offset = "0x140C4E0", VA = "0x140C4E0")]
		public void AddChild(SceneObject child)
		{
		}

		// Token: 0x0600610C RID: 24844 RVA: 0x0004B438 File Offset: 0x00049638
		[Token(Token = "0x600610C")]
		[Address(RVA = "0x140C5B4", Offset = "0x140C5B4", VA = "0x140C5B4")]
		public bool RemoveChild(SceneObject child)
		{
			return default(bool);
		}

		// Token: 0x0600610D RID: 24845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600610D")]
		[Address(RVA = "0x140C60C", Offset = "0x140C60C", VA = "0x140C60C", Slot = "5")]
		protected override void OnUpdate()
		{
		}

		// Token: 0x0600610E RID: 24846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600610E")]
		[Address(RVA = "0x140C7C0", Offset = "0x140C7C0", VA = "0x140C7C0", Slot = "6")]
		protected override void OnLoad()
		{
		}

		// Token: 0x0600610F RID: 24847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600610F")]
		[Address(RVA = "0x140C97C", Offset = "0x140C97C", VA = "0x140C97C", Slot = "11")]
		protected override void OnUnused()
		{
		}

		// Token: 0x06006110 RID: 24848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006110")]
		[Address(RVA = "0x140CA64", Offset = "0x140CA64", VA = "0x140CA64", Slot = "7")]
		protected override void OnUnload()
		{
		}

		// Token: 0x06006111 RID: 24849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006111")]
		[Address(RVA = "0x140CE34", Offset = "0x140CE34", VA = "0x140CE34", Slot = "8")]
		protected override void OnComplete()
		{
		}

		// Token: 0x06006112 RID: 24850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006112")]
		[Address(RVA = "0x140CF08", Offset = "0x140CF08", VA = "0x140CF08")]
		public static void UpdateObjects()
		{
		}

		// Token: 0x06006113 RID: 24851 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006113")]
		[Address(RVA = "0x140C3AC", Offset = "0x140C3AC", VA = "0x140C3AC")]
		public SceneObject()
		{
		}

		// Token: 0x04002590 RID: 9616
		[Token(Token = "0x4002590")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly List<SceneObject> Unused;

		// Token: 0x04002591 RID: 9617
		[Token(Token = "0x4002591")]
		[FieldOffset(Offset = "0x40")]
		internal readonly Dictionary<string, SceneObjectAction> actions;

		// Token: 0x04002592 RID: 9618
		[Token(Token = "0x4002592")]
		[FieldOffset(Offset = "0x48")]
		public readonly Assets assets;

		// Token: 0x04002593 RID: 9619
		[Token(Token = "0x4002593")]
		[FieldOffset(Offset = "0x50")]
		protected readonly List<SceneObject> children;

		// Token: 0x04002594 RID: 9620
		[Token(Token = "0x4002594")]
		[FieldOffset(Offset = "0x58")]
		protected int actionTimes;

		// Token: 0x04002595 RID: 9621
		[Token(Token = "0x4002595")]
		[FieldOffset(Offset = "0x60")]
		private Asset asset;

		// Token: 0x04002596 RID: 9622
		[Token(Token = "0x4002596")]
		[FieldOffset(Offset = "0x68")]
		public Action<SceneObject> completed;

		// Token: 0x04002597 RID: 9623
		[Token(Token = "0x4002597")]
		[FieldOffset(Offset = "0x70")]
		protected Scene owner;

		// Token: 0x04002598 RID: 9624
		[Token(Token = "0x4002598")]
		[FieldOffset(Offset = "0x78")]
		protected SceneObject parent;

		// Token: 0x04002599 RID: 9625
		[Token(Token = "0x4002599")]
		[FieldOffset(Offset = "0x80")]
		protected Transform transformParent;

		// Token: 0x0400259A RID: 9626
		[Token(Token = "0x400259A")]
		[FieldOffset(Offset = "0x88")]
		protected bool transformWorldPositionStays;
	}
}
