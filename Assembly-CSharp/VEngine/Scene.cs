using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace VEngine
{
	// Token: 0x020009E1 RID: 2529
	[Token(Token = "0x20009E1")]
	public class Scene : Loadable, IEnumerator
	{
		// Token: 0x17000613 RID: 1555
		// (get) Token: 0x060060E8 RID: 24808 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060060E9 RID: 24809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000613")]
		public AsyncOperation operation
		{
			[Token(Token = "0x60060E8")]
			[Address(RVA = "0x140AB68", Offset = "0x140AB68", VA = "0x140AB68")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60060E9")]
			[Address(RVA = "0x140AB70", Offset = "0x140AB70", VA = "0x140AB70")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000614 RID: 1556
		// (get) Token: 0x060060EA RID: 24810 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060060EB RID: 24811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000614")]
		public static Scene main
		{
			[Token(Token = "0x60060EA")]
			[Address(RVA = "0x140AB78", Offset = "0x140AB78", VA = "0x140AB78")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60060EB")]
			[Address(RVA = "0x140ABD0", Offset = "0x140ABD0", VA = "0x140ABD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000615 RID: 1557
		// (get) Token: 0x060060EC RID: 24812 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060060ED RID: 24813 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000615")]
		public static Scene current
		{
			[Token(Token = "0x60060EC")]
			[Address(RVA = "0x140AC30", Offset = "0x140AC30", VA = "0x140AC30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60060ED")]
			[Address(RVA = "0x140AC88", Offset = "0x140AC88", VA = "0x140AC88")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000616 RID: 1558
		// (get) Token: 0x060060EE RID: 24814 RVA: 0x0004B3C0 File Offset: 0x000495C0
		// (set) Token: 0x060060EF RID: 24815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000616")]
		protected internal LoadSceneMode loadSceneMode
		{
			[Token(Token = "0x60060EE")]
			[Address(RVA = "0x140ACE8", Offset = "0x140ACE8", VA = "0x140ACE8")]
			[CompilerGenerated]
			get
			{
				return default(LoadSceneMode);
			}
			[Token(Token = "0x60060EF")]
			[Address(RVA = "0x140ACF0", Offset = "0x140ACF0", VA = "0x140ACF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060060F0 RID: 24816 RVA: 0x0004B3D8 File Offset: 0x000495D8
		[Token(Token = "0x60060F0")]
		[Address(RVA = "0x140ACF8", Offset = "0x140ACF8", VA = "0x140ACF8", Slot = "13")]
		public bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x060060F1 RID: 24817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060F1")]
		[Address(RVA = "0x140AD18", Offset = "0x140AD18", VA = "0x140AD18", Slot = "15")]
		public void Reset()
		{
		}

		// Token: 0x17000617 RID: 1559
		// (get) Token: 0x060060F2 RID: 24818 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000617")]
		public object Current
		{
			[Token(Token = "0x60060F2")]
			[Address(RVA = "0x140AD1C", Offset = "0x140AD1C", VA = "0x140AD1C", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x060060F3 RID: 24819 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60060F3")]
		[Address(RVA = "0x140AD24", Offset = "0x140AD24", VA = "0x140AD24")]
		public static Scene LoadAsync(string assetPath, [Optional] Action<Scene> completed, bool additive = false)
		{
			return null;
		}

		// Token: 0x060060F4 RID: 24820 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60060F4")]
		[Address(RVA = "0x140AF98", Offset = "0x140AF98", VA = "0x140AF98")]
		public static Scene LoadAdditiveAsync(string assetPath, [Optional] Action<Scene> completed)
		{
			return null;
		}

		// Token: 0x060060F5 RID: 24821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060F5")]
		[Address(RVA = "0x140B000", Offset = "0x140B000", VA = "0x140B000", Slot = "5")]
		protected override void OnUpdate()
		{
		}

		// Token: 0x060060F6 RID: 24822 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060F6")]
		[Address(RVA = "0x140B014", Offset = "0x140B014", VA = "0x140B014")]
		protected void UpdateLoading()
		{
		}

		// Token: 0x060060F7 RID: 24823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060F7")]
		[Address(RVA = "0x140B0E0", Offset = "0x140B0E0", VA = "0x140B0E0", Slot = "6")]
		protected override void OnLoad()
		{
		}

		// Token: 0x060060F8 RID: 24824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060F8")]
		[Address(RVA = "0x140B15C", Offset = "0x140B15C", VA = "0x140B15C")]
		protected void PrepareToLoad()
		{
		}

		// Token: 0x060060F9 RID: 24825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060F9")]
		[Address(RVA = "0x140B400", Offset = "0x140B400", VA = "0x140B400", Slot = "11")]
		protected override void OnUnused()
		{
		}

		// Token: 0x060060FA RID: 24826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060FA")]
		[Address(RVA = "0x140B4E8", Offset = "0x140B4E8", VA = "0x140B4E8", Slot = "7")]
		protected override void OnUnload()
		{
		}

		// Token: 0x060060FB RID: 24827 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060FB")]
		[Address(RVA = "0x140B948", Offset = "0x140B948", VA = "0x140B948", Slot = "8")]
		protected override void OnComplete()
		{
		}

		// Token: 0x060060FC RID: 24828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060FC")]
		[Address(RVA = "0x140BA84", Offset = "0x140BA84", VA = "0x140BA84")]
		public static void UpdateScenes()
		{
		}

		// Token: 0x060060FD RID: 24829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060FD")]
		[Address(RVA = "0x140BCB0", Offset = "0x140BCB0", VA = "0x140BCB0")]
		public Scene()
		{
		}

		// Token: 0x04002585 RID: 9605
		[Token(Token = "0x4002585")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly List<Scene> Unused;

		// Token: 0x04002586 RID: 9606
		[Token(Token = "0x4002586")]
		[FieldOffset(Offset = "0x8")]
		public static Action<Scene> onSceneUnloaded;

		// Token: 0x04002587 RID: 9607
		[Token(Token = "0x4002587")]
		[FieldOffset(Offset = "0x10")]
		public static Action<Scene> onSceneLoaded;

		// Token: 0x04002588 RID: 9608
		[Token(Token = "0x4002588")]
		[FieldOffset(Offset = "0x40")]
		internal readonly List<Scene> additives;

		// Token: 0x04002589 RID: 9609
		[Token(Token = "0x4002589")]
		[FieldOffset(Offset = "0x48")]
		internal readonly List<SceneObject> objects;

		// Token: 0x0400258A RID: 9610
		[Token(Token = "0x400258A")]
		[FieldOffset(Offset = "0x50")]
		public Action<Scene> completed;

		// Token: 0x0400258B RID: 9611
		[Token(Token = "0x400258B")]
		[FieldOffset(Offset = "0x58")]
		protected string sceneName;
	}
}
