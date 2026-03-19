using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace VEngine
{
	// Token: 0x020009F0 RID: 2544
	[Token(Token = "0x20009F0")]
	public class Operation : IEnumerator
	{
		// Token: 0x17000626 RID: 1574
		// (get) Token: 0x06006161 RID: 24929 RVA: 0x0004B558 File Offset: 0x00049758
		// (set) Token: 0x06006162 RID: 24930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000626")]
		public OperationStatus status
		{
			[Token(Token = "0x6006161")]
			[Address(RVA = "0x1411C00", Offset = "0x1411C00", VA = "0x1411C00")]
			[CompilerGenerated]
			get
			{
				return OperationStatus.Idle;
			}
			[Token(Token = "0x6006162")]
			[Address(RVA = "0x1411C08", Offset = "0x1411C08", VA = "0x1411C08")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000627 RID: 1575
		// (get) Token: 0x06006163 RID: 24931 RVA: 0x0004B570 File Offset: 0x00049770
		// (set) Token: 0x06006164 RID: 24932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000627")]
		public float progress
		{
			[Token(Token = "0x6006163")]
			[Address(RVA = "0x1411C10", Offset = "0x1411C10", VA = "0x1411C10")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6006164")]
			[Address(RVA = "0x1411C18", Offset = "0x1411C18", VA = "0x1411C18")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000628 RID: 1576
		// (get) Token: 0x06006165 RID: 24933 RVA: 0x0004B588 File Offset: 0x00049788
		[Token(Token = "0x17000628")]
		public bool isDone
		{
			[Token(Token = "0x6006165")]
			[Address(RVA = "0x14119A8", Offset = "0x14119A8", VA = "0x14119A8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000629 RID: 1577
		// (get) Token: 0x06006166 RID: 24934 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006167 RID: 24935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000629")]
		public string error
		{
			[Token(Token = "0x6006166")]
			[Address(RVA = "0x1411C20", Offset = "0x1411C20", VA = "0x1411C20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006167")]
			[Address(RVA = "0x1411C28", Offset = "0x1411C28", VA = "0x1411C28")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700062A RID: 1578
		// (get) Token: 0x06006168 RID: 24936 RVA: 0x0004B5A0 File Offset: 0x000497A0
		[Token(Token = "0x1700062A")]
		public bool isError
		{
			[Token(Token = "0x6006168")]
			[Address(RVA = "0x1411C30", Offset = "0x1411C30", VA = "0x1411C30")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06006169 RID: 24937 RVA: 0x0004B5B8 File Offset: 0x000497B8
		[Token(Token = "0x6006169")]
		[Address(RVA = "0x1411C50", Offset = "0x1411C50", VA = "0x1411C50", Slot = "4")]
		public bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x0600616A RID: 24938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600616A")]
		[Address(RVA = "0x1411C64", Offset = "0x1411C64", VA = "0x1411C64", Slot = "6")]
		public void Reset()
		{
		}

		// Token: 0x1700062B RID: 1579
		// (get) Token: 0x0600616B RID: 24939 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700062B")]
		public object Current
		{
			[Token(Token = "0x600616B")]
			[Address(RVA = "0x1411C68", Offset = "0x1411C68", VA = "0x1411C68", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x0600616C RID: 24940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600616C")]
		[Address(RVA = "0x1411C70", Offset = "0x1411C70", VA = "0x1411C70")]
		internal static void Process(Operation operation)
		{
		}

		// Token: 0x0600616D RID: 24941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600616D")]
		[Address(RVA = "0x1411D54", Offset = "0x1411D54", VA = "0x1411D54", Slot = "7")]
		protected virtual void Update()
		{
		}

		// Token: 0x0600616E RID: 24942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600616E")]
		[Address(RVA = "0x140FE68", Offset = "0x140FE68", VA = "0x140FE68", Slot = "8")]
		public virtual void Start()
		{
		}

		// Token: 0x0600616F RID: 24943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600616F")]
		[Address(RVA = "0x140CDEC", Offset = "0x140CDEC", VA = "0x140CDEC")]
		public void Cancel()
		{
		}

		// Token: 0x06006170 RID: 24944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006170")]
		[Address(RVA = "0x14100A0", Offset = "0x14100A0", VA = "0x14100A0")]
		protected void Finish([Optional] string errorCode)
		{
		}

		// Token: 0x06006171 RID: 24945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006171")]
		[Address(RVA = "0x1411D58", Offset = "0x1411D58", VA = "0x1411D58")]
		protected void Complete()
		{
		}

		// Token: 0x06006172 RID: 24946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006172")]
		[Address(RVA = "0x1411E2C", Offset = "0x1411E2C", VA = "0x1411E2C")]
		public static void UpdateOperations()
		{
		}

		// Token: 0x06006173 RID: 24947 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006173")]
		[Address(RVA = "0x141019C", Offset = "0x141019C", VA = "0x141019C")]
		public Operation()
		{
		}

		// Token: 0x040025DD RID: 9693
		[Token(Token = "0x40025DD")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly List<Operation> Processing;

		// Token: 0x040025DE RID: 9694
		[Token(Token = "0x40025DE")]
		[FieldOffset(Offset = "0x10")]
		public Action<Operation> completed;
	}
}
