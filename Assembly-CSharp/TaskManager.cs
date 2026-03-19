using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000D5 RID: 213
[Token(Token = "0x20000D5")]
internal class TaskManager : MonoBehaviour
{
	// Token: 0x060005DD RID: 1501 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005DD")]
	[Address(RVA = "0x2F7D870", Offset = "0x2F7D870", VA = "0x2F7D870")]
	public static TaskManager.TaskState CreateTask(IEnumerator coroutine)
	{
		return null;
	}

	// Token: 0x060005DE RID: 1502 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005DE")]
	[Address(RVA = "0x2F7DDE8", Offset = "0x2F7DDE8", VA = "0x2F7DDE8")]
	public TaskManager()
	{
	}

	// Token: 0x0400046A RID: 1130
	[Token(Token = "0x400046A")]
	[FieldOffset(Offset = "0x0")]
	private static TaskManager singleton;

	// Token: 0x020000D6 RID: 214
	[Token(Token = "0x20000D6")]
	public class TaskState
	{
		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x060005DF RID: 1503 RVA: 0x00003D08 File Offset: 0x00001F08
		[Token(Token = "0x170000A4")]
		public bool Running
		{
			[Token(Token = "0x60005DF")]
			[Address(RVA = "0x2F7DDF0", Offset = "0x2F7DDF0", VA = "0x2F7DDF0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x060005E0 RID: 1504 RVA: 0x00003D20 File Offset: 0x00001F20
		[Token(Token = "0x170000A5")]
		public bool Paused
		{
			[Token(Token = "0x60005E0")]
			[Address(RVA = "0x2F7DDF8", Offset = "0x2F7DDF8", VA = "0x2F7DDF8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x060005E1 RID: 1505 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x060005E2 RID: 1506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000002")]
		public event TaskManager.TaskState.FinishedHandler Finished
		{
			[Token(Token = "0x60005E1")]
			[Address(RVA = "0x2F7DA70", Offset = "0x2F7DA70", VA = "0x2F7DA70")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60005E2")]
			[Address(RVA = "0x2F7DE00", Offset = "0x2F7DE00", VA = "0x2F7DE00")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x060005E3 RID: 1507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005E3")]
		[Address(RVA = "0x2F7DDB8", Offset = "0x2F7DDB8", VA = "0x2F7DDB8")]
		public TaskState(IEnumerator c)
		{
		}

		// Token: 0x060005E4 RID: 1508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005E4")]
		[Address(RVA = "0x2F7DBE8", Offset = "0x2F7DBE8", VA = "0x2F7DBE8")]
		public void Pause()
		{
		}

		// Token: 0x060005E5 RID: 1509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005E5")]
		[Address(RVA = "0x2F7DC10", Offset = "0x2F7DC10", VA = "0x2F7DC10")]
		public void Unpause()
		{
		}

		// Token: 0x060005E6 RID: 1510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005E6")]
		[Address(RVA = "0x2F7DB24", Offset = "0x2F7DB24", VA = "0x2F7DB24")]
		public void Start()
		{
		}

		// Token: 0x060005E7 RID: 1511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005E7")]
		[Address(RVA = "0x2F7DBB8", Offset = "0x2F7DBB8", VA = "0x2F7DBB8")]
		public void Stop()
		{
		}

		// Token: 0x060005E8 RID: 1512 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005E8")]
		[Address(RVA = "0x2F7DE9C", Offset = "0x2F7DE9C", VA = "0x2F7DE9C")]
		private IEnumerator CallWrapper()
		{
			return null;
		}

		// Token: 0x0400046C RID: 1132
		[Token(Token = "0x400046C")]
		[FieldOffset(Offset = "0x18")]
		private IEnumerator coroutine;

		// Token: 0x0400046D RID: 1133
		[Token(Token = "0x400046D")]
		[FieldOffset(Offset = "0x20")]
		private bool running;

		// Token: 0x0400046E RID: 1134
		[Token(Token = "0x400046E")]
		[FieldOffset(Offset = "0x21")]
		private bool paused;

		// Token: 0x0400046F RID: 1135
		[Token(Token = "0x400046F")]
		[FieldOffset(Offset = "0x22")]
		private bool stopped;

		// Token: 0x020000D7 RID: 215
		// (Invoke) Token: 0x060005EA RID: 1514
		[Token(Token = "0x20000D7")]
		public delegate void FinishedHandler(bool manual);
	}
}
